<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService

    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function remove(pid As String) As String
        Call SetContentResponse()
        remove = ConfigurationManager.AppSettings("myIP")
        If IsNothing(flCache.GetCache("CMSCache_Get_IP_" & remove & "_" & pid)) Then
            For Each Cr As CMSCacheInfo In flDnn.CMSCache_Get_IP(flConnect.DnnSqlServer, remove, pid)
                flCache.RemoveCache(Cr.CacheName)
            Next
            flCache.SetCache("CMSCache_Get_IP_" & remove & "_" & pid, SecondCache.S2)
        End If
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub ClearTabsCache(PortalConnect As String)
        Call SetContentResponse()
        DataCache.ClearTabsCache(PortalConnect)
    End Sub
End Class
