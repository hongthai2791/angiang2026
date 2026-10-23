<%@ WebHandler Language="VB" Class="unlock" %>
Imports DotNetNuke.EPORTAL

Public Class unlock : Implements IHttpHandler

    Dim Username As String
    Dim portalID, NewsID As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            Username = context.Request.Item("u")
            portalID = flReg.WriteNumber(context.Request.Item("pid"))
            NewsID = flReg.WriteNumber(context.Request.Item("id"))
            CMS.Ultis.UnlockNews(portalID, NewsID, Username)
            context.Response.Write("")
        Catch ex As Exception
            context.Response.Write(0)
        End Try
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class