<%@ WebService Language="VB" Class="WebserviceGolbal.search" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

Namespace WebserviceGolbal
    <ScriptService()>
    <WebService(Namespace:="http://tempuri.org/")>
    <WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
    Public Class search
        Inherits System.Web.Services.WebService
        Dim arr As New ArrayList
        Dim ObjController As New AppController
        Dim str As String
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function ListNotification(pid As Integer, tabPage As String) As String
            Call flReg.SetContentResponse()
            Dim data = New Response
            Dim settings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Try
                str = ""

                If tabPage = "employers" Then
                    Dim dem = 0
                    For Each cr As CMS_BusUserInfo In ObjController.CMS_BusUser_Get_By_CMS_Business(pid, flCheck.Business_ID(pid, UserInfo.Username))
                        For Each cr2 As CMS_NotiSendInfo In ObjController.CMS_NotiSend_List_Search_ForWeb_VLKeng(pid, "bb65b66b-fe4a-430e-ae73-9e7a99d293f7", cr.UserAdmin, 1, 20, Now.AddMonths(-1), Now.AddDays(1), appNotiSend.Send)
                            arr.Add(cr2)
                        Next
                    Next
                Else
                    arr = ObjController.CMS_NotiSend_List_Search_ForWeb_VLKeng(pid, "bf7f714a-4db6-422d-a0e9-c44b53e46357", UserInfo.Username, 1, 20, Now.AddMonths(-1), Now.AddDays(1), appNotiSend.Send)
                End If

                For Each cr As CMS_NotiSendInfo In arr
                    str += "<li>"
                    str += "<a onclick=""changetb();"" href=""/" & tabPage & "/view/notify-list/itemid/" & cr.NotiSend_ID & """ >"
                    str += "<i  Class=""fa fa-arrow-right"" aria-hidden=""True""></i>" & cr.Titles
                    str += "</a>"
                    str += "</li>"
                Next
                If arr.Count <= 0 Then
                    str += "<li>"
                    str += "<a href='javascript:;'>Rất tiếc! Bạn chưa có thông báo mới nào</a>"
                    str += "</li>"
                End If
                data.data = str
            Catch ex As Exception
                data.data = ex.Message
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function DetailNotify(pid As Integer, id As String, us As String) As String
            Call flReg.SetContentResponse()
            Dim data = New Response
            Dim settings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Try
                str = ""
                Dim obj As New CMS_NotiSendInfo
                obj = ObjController.CMS_NotiSend_Get(pid, id)
                If IsNothing(obj) = False Then
                    With obj
                        str += "<p>Tiêu đề: <b>" & obj.Titles & "</b></p>"
                        str += "<p>Nội dung chi tiết:</p>"
                        str += "<p  class='strong'>" & obj.Contents & "</p>"
                        str += "Ngày gửi thông báo: <b>" & flReg.ReadDate(obj.SendDate) & "</b>"
                    End With
                Else
                    str = "Không tìm thấy nội dung"
                End If
                data.data = str
                ObjController.CMS_NotiSend_Update_TinhTrang(pid, id, appNotiSend.Read)
            Catch ex As Exception
                data.data = ex.Message
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function findBusiness(search As String, tp As String, qh As String) As ArrayList
            arr = New ArrayList
            For Each Cr As CMS_BusinessInfo In ObjController.CMS_Business_List_Find(flConnect.PortalId, search, tp, qh)
                Cr.Business_Vn = flReg.RemoveScript(Cr.Business_Vn, False)
                Cr.ContactUser = flReg.RemoveScript(Cr.ContactUser, False)
                Cr.ContactMobile = flReg.RemoveScript(Cr.ContactMobile, False)
                Cr.ContactEmail = flReg.RemoveScript(Cr.ContactEmail, False)
                Cr.Address = flReg.RemoveScript(Cr.Address, False)
                arr.Add(Cr)
            Next
            Return arr
        End Function
    End Class

End Namespace
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