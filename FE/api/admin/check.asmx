<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
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
    Public Function chitieu(pa As String, pid As String, id As String, c As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Select Case id
            Case "hcdb"
                data.Data = CHI.flCheck.HCDB_Code(pid, pa) & flReg.WriteNumber(c)
            Case "hck"
                data.Data = CHI.flCheck.HCK_Code(pid, pa) & flReg.WriteNumber(c)
            Case "httg"
                data.Data = CHI.flCheck.HTTG_Code(pid, pa) & flReg.WriteNumber(c)
            Case "nguyco"
                data.Data = CHI.flCheck.NguyCo_Code(pid, pa) & flReg.WriteNumber(c)
            Case Else
                data.Data = ""
        End Select
        Return JsonConvert.SerializeObject(data, settings)

    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function roles(pid As String, subid As String, id As String, code As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        If flDnn.CMS_Roles_Check_Code(flReg.WriteNumber(pid), flReg.WriteNumber(subid), flReg.WriteNumber(id), code) <> "0" Then
            data.Data = "<span>Mã: <b style='color:yellow'>" & code & "</b> đã tồn tại, vui nhập mã khác!</span>"
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function checkUname(uname As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        Dim dnnInfo As DnnInfo = flDnn.DNN_User_Get_UserName(flConnect.PortalId, flReg.ToEnglish(uname))
        If IsNothing(dnnInfo) = False Then
            data.Data = "Tên đăng nhập: <b>" & uname & "</b>  không hợp lệ, vui lòng nhập lại!"
        Else
            data.Data = ""
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function checkEmail(email As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        Dim dnnInfo As DnnInfo = flDnn.DNN_User_Get_Email(email)
        If IsNothing(dnnInfo) = False Then
            data.Data = "Email: <b>" & email & "</b>  không hợp lệ, vui lòng nhập lại!"
        End If
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