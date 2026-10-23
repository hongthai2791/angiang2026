<%@ WebService Language="VB" Class="account" %>
Imports System.Web.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Web.Script.Services

<ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class account
    Inherits System.Web.Services.WebService
    Dim ObjControler As New CmsController

    Private result As New Response With {.Status = ServiceStatus.NODATA, .Data = Nothing, .Message = String.Empty}
    Private ReadOnly settings As New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

    <WebMethod(Description:="Tiền nhuận bút", EnableSession:=True)>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub SaveNB(NB_ID As String, pid As String, NewsID As String, DM_ID As String)
        Try
            Dim tinM As Integer
            Dim dmNhuanButInfo As CMS_DMNhuanButInfo = ObjControler.CMS_DMNhuanBut_Get(pid, DM_ID)
            If IsNothing(dmNhuanButInfo) = False Then
                tinM = dmNhuanButInfo.DonGia * dmNhuanButInfo.HeSo
            End If
            Dim nbInfo As New CMS_News_NBInfo
            nbInfo.NewsID = NewsID
            nbInfo.DM_ID = DM_ID
            nbInfo.Price = tinM
            If NB_ID <> "" Then
                nbInfo.ID = NB_ID
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = GetPortalSettings.UserInfo.Username
                nbInfo.UpdateUser = GetPortalSettings.UserInfo.Username
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.Album
                ObjControler.CMS_News_NB_Update(pid, nbInfo)
            Else
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = GetPortalSettings.UserInfo.Username
                nbInfo.UpdateUser = ""
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.Album
                nbInfo.ID = ObjControler.CMS_News_NB_Add(pid, nbInfo)
            End If
            result.Data = nbInfo.ID
            result.Status = ServiceStatus.SUCCESS
            result.Message = "success"
        Catch ex As Exception
            LogException(ex)
            result.Message = "error"
            result.Status = ServiceStatus.FAILED
        End Try
        result.ToHttpResponse()
    End Sub
    <WebMethod(Description:="Tiền nhuận bút detail", EnableSession:=True)>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub SaveNBDetail(NewsNB_ID As String, pid As String, id As String, MaDM As String, HeSo As String, SoLuong As String, DonGia As String, IsMoney As String)
        Try
            Dim nbDetailInfo As New CMS_News_NBDetailInfo
            nbDetailInfo.NewsNB_ID = NewsNB_ID
            nbDetailInfo.ID = id
            nbDetailInfo.MaDM = MaDM
            nbDetailInfo.HeSo = flReg.WriteNumber(HeSo)
            nbDetailInfo.SoLuong = flReg.WriteNumber(SoLuong)
            nbDetailInfo.Price = flReg.WriteNumber(IsMoney)
            nbDetailInfo.DonGia = flReg.WriteNumber(DonGia)
            nbDetailInfo.CreateDate = Now
            nbDetailInfo.CreateUser = GetPortalSettings.UserInfo.Username
            nbDetailInfo.UpdateDate = Now
            nbDetailInfo.UpdateUser = GetPortalSettings.UserInfo.Username
            ObjControler.CMS_News_NBDetail_Add(pid, nbDetailInfo)

            result.Status = ServiceStatus.SUCCESS
            result.Message = "success"
        Catch ex As Exception
            LogException(ex)
            result.Message = "error"
            result.Status = ServiceStatus.FAILED
        End Try
        result.ToHttpResponse()
    End Sub

    <WebMethod(Description:="Lấy thông tin người dùng", EnableSession:=True)>
    Public Function GetMoney(PortalID As Integer, ID As String, ItemID As String, type As Integer) As String
        Try
            If flReg.WriteNumber(ID) > 0 Then
                Dim Money As Integer
                If ItemID <> 0 Then
                    Dim obj As CMS_News_NBInfo = New CMS.CmsController().CMS_News_NB_Get_By_NewsID(PortalID, ItemID, type)
                    If Not IsNothing(obj) Then Money = obj.Price
                Else
                    Dim obj As CMS_DMNhuanButInfo = New CMS.CmsController().CMS_DMNhuanBut_Get(PortalID, ID)
                    If Not IsNothing(obj) Then Money = obj.DonGia * obj.HeSo
                End If
                result.Data = Money
                result.Status = ServiceStatus.SUCCESS
                result.Message = "Success"
            Else
                result.Data = 0
                result.Status = ServiceStatus.SUCCESS
                result.Message = "Success"
            End If
        Catch ex As Exception
            LogException(ex)
            result.Status = ServiceStatus.FAILED
            result.Message = "Error"
        End Try
        Return result.Data
    End Function

    <WebMethod(Description:="Lấy thông tin người dùng", EnableSession:=True)>
    Public Function NhuanButDetail(PortalID As String, ItemID As String, Type As Integer, PublishedDate As DateTime) As String
        Try
            Dim arr As ArrayList = New CmsController().CMS_DMNhuanBut_Get_By_Type(PortalID, Type, PublishedDate.Month, PublishedDate.Year)
            Dim temp As Integer = 0
            Dim str As String = "<table class='table table-bordered' id='table' cellspacing='0'><thead>"
            str += "<tr style='color:White;background-color:#006699;font-weight:bold;'>"
            str += "<td class='fix-column' style='width:7%;text-align:center;'>STT</td>"
            str += "<td class='fix-column' style='display:none;'>ID</td>"
            str += "<td class='column-primary'>Định mức ảnh</td>"
            str += "<td class='HeSo respo-title' style='width:15%;'>Hệ số</td>"
            str += "<td class='SoLuong respo-title' style='width:15%;'>Số lượng</td>"
            str += "<td class='DonGia respo-title' style='width:15%;'>Đơn giá</td>"
            str += "<td class='IsMoney respo-title' style='width:20%;'>Tiền nhuận bút</td>"
            str += "</tr></thead><tbody>"
            For Each item As CMS_DMNhuanButInfo In arr
                temp += 1
                str += "<tr class='TRgrid' style='background-color:#F7FBFB;'>"
                str += "<td class='fix-column' style='width:7%;text-align:center;'>" & temp
                str += "</td><td class='column-primary' style='display:none;'>" & item.ID
                str += "</td><td class='column-primary'>" & item.MaDM

                str += " </td><td class='HeSo respo-view' style='width:15%;'>" & item.HeSo

                str += "</td><td class=' respo-view' style='width:15%;'>"
                str += "<span class='' style='width:100%;'><input class='form-control SoLuong' onchange=""updatePrice('" & item.HeSo & "','" & item.DonGia & "',this,'" & item.ID & "')"" value='0' type='text' /></span>"
                str += "</td><td class='DonGia respo-view' style='width:15%;'>" & item.DonGia

                str += "</td><td class='respo-view' style='width:20%;'>"
                str += "<span class='' style='width:100%;'><input class='form-control money-" & item.ID & " IsMoney' readonly='ReadOnly' value='0' type='text'></span>"
                str += "</td>"
                str += "</tr>"
            Next
            str += "</tbody></table>"

            result.Data = str
            result.Status = ServiceStatus.SUCCESS
            result.Message = "Success"
        Catch ex As Exception
            LogException(ex)
            result.Status = ServiceStatus.FAILED
            result.Message = "Error"
        End Try
        Return result.Data
    End Function

    <WebMethod(Description:="Lấy thông tin người dùng", EnableSession:=True)>
    Public Function SaveNhuanButTin(PortalID As Integer, ItemID As Integer, MaDM As Integer, Price As Double, Type As Integer) As String
        Try
            Dim obj As CMS_News_NBInfo = New CmsController().CMS_News_NB_Get_By_NewsID(PortalID, ItemID, Type)
            Dim nbInfo As New CMS_News_NBInfo
            nbInfo.NewsID = ItemID
            nbInfo.DM_ID = MaDM
            nbInfo.Price = Price

            nbInfo.ID = obj.ID
            nbInfo.CreateDate = Now
            nbInfo.CreateUser = ""
            nbInfo.UpdateUser = UserInfo.Username
            nbInfo.UpdateDate = Now
            nbInfo.Type = Type
            ObjControler.CMS_News_NB_Update(PortalID, nbInfo)

            result.Data = obj.ID
            result.Status = ServiceStatus.SUCCESS
            result.Message = "Success"
        Catch ex As Exception
            LogException(ex)
            result.Status = ServiceStatus.FAILED
            result.Message = "Error"
        End Try

        'Return JsonConvert.SerializeObject(result)
        Return result.Data
    End Function

    <WebMethod(Description:="Lấy thông tin người dùng", EnableSession:=True)>
    Public Function SaveNhuanButAnh(NB_ID As Integer, ID As Integer, SoLuong As Integer, DonGia As Double, Price As Double) As String
        Try
            Dim obj As CMS_DMNhuanButInfo = ObjControler.CMS_DMNhuanBut_Get(GetPortalSettings.PortalId, ID)

            Dim nbDetailInfo As New CMS_News_NBDetailInfo
            nbDetailInfo.NewsNB_ID = NB_ID
            nbDetailInfo.ID = ID
            nbDetailInfo.MaDM = obj.MaDM
            nbDetailInfo.HeSo = obj.HeSo
            nbDetailInfo.SoLuong = SoLuong
            nbDetailInfo.Price = Price
            nbDetailInfo.DonGia = DonGia
            nbDetailInfo.CreateDate = Now
            nbDetailInfo.CreateUser = UserInfo.Username
            nbDetailInfo.UpdateDate = Now
            nbDetailInfo.UpdateUser = UserInfo.Username
            ObjControler.CMS_News_NBDetail_Add(0, nbDetailInfo)

            result.Data = ""
            result.Status = ServiceStatus.SUCCESS
            result.Message = "Success"
        Catch ex As Exception
            LogException(ex)
            result.Status = ServiceStatus.FAILED
            result.Message = "Error"
        End Try

        'Return JsonConvert.SerializeObject(result)
        Return JsonConvert.SerializeObject(result)
    End Function
End Class

Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As Object)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

        context.Response.ContentType = "application/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
    End Sub

    Public Class UserModelInfo
        Public Property Username As String
        Public Property DisplayName As String
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property UploadAvatar As String
        Public Property isInRole As Boolean
        Public Property createdOnDate As DateTime
        Public Property Birthday As DateTime
        Public Property DonVi As String
        Public Property IsSendEmail As Boolean
        Public Property IsSendSMS As Boolean
    End Class

    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, Thread.CurrentPrincipal.Identity.Name)
                    Return If(user, New UserInfo())
                End If
                Return New UserInfo()
            ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                If HttpContext.Current.Request.IsAuthenticated Then
                    user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                    HttpContext.Current.Items("UserInfo") = user
                End If
            End If
            user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
            Return If(user, New UserInfo())
        End Get
    End Property
End Module