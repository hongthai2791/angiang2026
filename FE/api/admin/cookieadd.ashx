<%@ WebHandler Language="VB" Class="cookie_add" %>
Imports DotNetNuke.EPORTAL

Public Class cookie_add : Implements IHttpHandler
    Dim IdKey, IdValue As String
    Dim b As Byte()
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            IdKey = flReg.DeCode64(context.Request.Item("k"))
            IdValue = flReg.DeCode64(context.Request.Item("v"))

            Dim ObjInfo As New CMSCookieInfo
            ObjInfo.IdKey = IdKey
            ObjInfo.IdValue = IdValue
            flDnn.CMSCookie_Update(ObjInfo)

            context.Response.Write("ok")
        Catch
            context.Response.Write("er")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class