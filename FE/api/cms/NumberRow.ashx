<%@ WebHandler Language="VB" Class="NumberRow" %>
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Public Class NumberRow : Implements IHttpHandler
    Dim key, sSettings, type As String
    Dim portal As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            key = context.Request.Item("key") & ""
            portal = flReg.WriteNumber(context.Request.Item("portal"))
            type = context.Request.Item("type") & ""
            sSettings = flCheck.SetupValue(portal, key & "_" & type & "Row")
            context.Response.Write(flReg.WriteNumber(sSettings))
        Catch
            context.Response.Write("0")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class