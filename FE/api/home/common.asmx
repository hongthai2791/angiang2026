<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading
<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.Status = ServiceStatus.NODATA, .Data = Nothing, .Message = String.Empty}
    Private objController As New CmsController
    Dim objInfo As New CMS_RegisterInfo
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub

    Public Class Response
        Public Property Data As Object
        Public Property Status As Short
        Public Property Message As String
    End Class
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Register(pid As String, TenPhuHuynh As String, Email As String, Mobile As String, TenCon As String, TuoiCon As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objInfo = New CMS_RegisterInfo
            objInfo.RegisterID = flReg.GenKey
            objInfo.ParentName = TenPhuHuynh
            objInfo.CreatedDate = Now
            objInfo.CreatedUser = ""
            objInfo.ChildName = TenCon
            objInfo.ChildOld = TuoiCon
            objInfo.Email = Email
            objInfo.PhoneNumber = Mobile
            objController.CMS_Register_Add(pid, objInfo)
            data.Data = "1"
        Catch ex As Exception
            data.Data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Enum ServiceStatus
    FAILED = 0
    NODATA
    SUCCESS
    EXCEPTION
End Enum
Public Class Response
    Public Property Data As Object
    Public Property Status As Int16
    Public Property Message As String
End Class
Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As Response)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
    End Sub
    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.GetCurrentPortalSettings()
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