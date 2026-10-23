<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.INSU
Imports DotNetNuke.VBN
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading
Imports System.Web.Services.Protocols

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class AuthHeader
    Inherits SoapHeader
    Public userLogin As String
    Public Password As String
End Class
Public Class WebService
    Inherits System.Web.Services.WebService
    Private objCTL As New InsuController
    Public Authentication As AuthHeader

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function kbvl(pid As String, id As String, tt As Integer) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If tt = TrangThaiHS.TiepNhan Then
                objCTL.EXE_Notification_Update_TrangThai(pid, id, TrangThaiHS.TiepNhan, Now, UserInfo.Username, "")
                objCTL.EXE_Notification_Update_TrangThai(pid, id, TrangThaiHS.ChuyenXuLy, Now, UserInfo.Username, "")
            Else
                objCTL.EXE_Notification_Update_TrangThai(pid, id, TrangThaiHS.TraLai, Now, UserInfo.Username, "")
            End If
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CMS_Door_List(pid As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                data.data = objCTL.CMS_Door_List(PortalSettings.Current.PortalId, pid)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CMS_Satellite_List(pid As Integer) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                data.data = objCTL.CMS_Satellite_List(0, pid)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CMS_Portal_List() As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                data.data = objCTL.CMS_Portal_List(0)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CMS_Portal_Get(pid As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                data.data = objCTL.CMS_Portal_Get(0, flReg.WriteNumber(pid))
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyXepHang(tinhtp As Integer) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                data.data = objCTL.EXE_NumberAuto_List_IsOnline(tinhtp, tinhtp)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CapNhatTinhTrang(id As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                objCTL.EXE_NumberAuto_Update_IsOnline(PortalSettings.Current.PortalId, id, True)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function addNumberAuto_Offline(portalID As Integer, dichVu As Integer, vetinhID As String, sangChieu As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            If Authentication.userLogin <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then
                data.data = Nothing
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            Else
                Dim obj As New EXE_NumberAutoInfo
                obj.NumberAuto_ID = flReg.GenKey()
                obj.NoCode = flCheck.NoCode(portalID, ProType.DKXH)
                obj.DichVu = dichVu
                obj.PortalID = portalID
                obj.VeTinhID = vetinhID
                obj.SangChieu = sangChieu
                obj.NgayDangKy = Now
                obj.TinhTrang = numberStatus.DangCho
                obj.CreatedDate = Now
                obj.CreatedUser = "GUEST"
                obj.ThuTu = objCTL.EXE_NumberAuto_Add_Offline(portalID, obj)

                data.data = obj.ThuTu
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            End If
        Catch ex As Exception
            data.data = ex.Message
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Module Moduler
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