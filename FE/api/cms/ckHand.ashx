<%@ WebHandler Language="VB" Class="ckHand" %>

Imports DotNetNuke.CMS

Public Class ckHand : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim key, sSettings As String
    Dim portal As Integer
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            key = context.Request.Item("key") & ""
            portal = EPORTAL.flReg.WriteNumber(context.Request.Item("portal"))
            sSettings = flCheck.SetupValue(portal, key & "_ckHand")
            context.Response.Write(sSettings.ToLower)
        Catch
            context.Response.Write("")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
 
End Class