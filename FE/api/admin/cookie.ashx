<%@ WebHandler Language="VB" Class="cookie" %>
Imports DotNetNuke.EPORTAL

Public Class cookie : Implements IHttpHandler, System.Web.SessionState.IRequiresSessionState
    Dim IdKey, IdValue As String
    Dim dicInfo As New CMSCookieInfo
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            IdKey = flReg.DeCode64(context.Request.Item("k"))
            dicInfo = flDnn.CMSCookie_Get(IdKey)
            IdValue = ""
            If IsNothing(dicInfo) = False Then
                IdValue = dicInfo.IdValue
                If IdValue <> "" Then
                    context.Session(IdKey) = ""
                    flDnn.CMSCookie_Delete(IdKey)
                End If
            End If
            context.Response.Write(IdValue)
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