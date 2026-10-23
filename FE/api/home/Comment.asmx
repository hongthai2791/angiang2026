<%@ WebService Language="VB" Class="WebService" %>
Imports DotnetNuke.Entities.Modules
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotnetNuke.CMS
Imports DotNetNuke.EPORTAL
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading
<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.status = ServiceStatus.NODATA, .data = Nothing, .message = String.Empty}
    Private NOATAVAR_URL As String = "/images/noavatar.png"
    Dim objControler As New CmsController
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SaveData(pid As Integer, id As String, hoten As String, email As String, contents As String, ipcontrack As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim obj As New CMS_NewsFeedbackInfo
            obj.ItemId = flReg.getStringNullHtml(id)
            obj.Email = flReg.getStringNullHtml(email)
            obj.Status = CommentStatus.Created
            obj.CreateDate = Date.Now
            obj.Type = 1
            obj.IPTrack = flReg.getStringNullHtml(ipcontrack)
            obj.PortalId = pid
            obj.LanguageId = flConnect.IsLang
            obj.Content = flReg.getStringNullHtml(contents)
            obj.FullName = flReg.getStringNullHtml(hoten)
            obj.Avatar = NOATAVAR_URL
            objControler.CMS_NewsFeedback_Add(pid, obj)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "app")
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function MailDangKy(pid As Integer, email As String) As String
        Dim wCtl As New WORK.WorkController
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            wCtl.CMS_RegEmail_Add(pid, flReg.GenKey(), email, Now)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "app")
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