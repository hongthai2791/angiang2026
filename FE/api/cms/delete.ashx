<%@ WebHandler Language="VB" Class="delete" %>

Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Public Class delete : Implements IHttpHandler

    Dim id As Integer, PortalConnect As Integer
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        id = flReg.WriteNumber(context.Request.Item("id"))
        PortalConnect = flReg.WriteNumber(context.Request.Item("pid"))

        Dim cMedia As New CmsController
        cMedia.CMS_Media_Delete(PortalConnect, id)
        cMedia.CMS_NewsByMedia_Delete_By_MediaID(PortalConnect, id)

    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class