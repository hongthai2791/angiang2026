<%@ WebHandler Language="VB" Class="token" %>
Public Class token : Implements IHttpHandler, System.Web.SessionState.IRequiresSessionState
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Session("token_u") = ""
        context.Session("token_f") = ""
        context.Session("token_c") = ""
        context.Session("token_i") = ""
        context.Response.Write("done")
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class