<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService

    Private result As New Response With {.Data = Nothing, .Message = String.Empty}
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub

    Dim ObjController As New CmsController
    Dim strVal As String

    <WebMethod(EnableSession:=True)>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub NewsContent(PortalConnect As String, NewsID As Integer)
        Call SetContentResponse()
        Dim objNews As CMS_NewsInfo = ObjController.CMS_News_Get(PortalConnect, NewsID)
        If IsNothing(objNews) = False Then
            strVal = "<div class='new-content none'>"
            If objNews.Content.Contains(objNews.ImagePath) = False Then
                strVal += "<img src='" & EPORTAL.flConnect.fileDomain & objNews.ImagePath & "'>"
            End If
            strVal += objNews.Content
            strVal += "</div>"
        End If
        result.Data = strVal
        result.Message = "Success"

        result.ToHttpResponse()
    End Sub
End Class
Public Class Response
    Public Property Message As String
    Public Property Data As String
End Class
Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As Response)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

        context.Response.Clear()
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
    End Sub

End Module