<%@ WebHandler Language="VB" Class="nextpage" %>

Imports DotNetNuke.EPORTAL

Public Class nextpage : Implements IHttpHandler
    Dim t, pr, ps, cp, ru As String

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            t = flReg.WriteNumber(context.Request.Item("t"))
            pr = flReg.WriteNumber(context.Request.Item("pr"))
            ps = flReg.WriteNumber(context.Request.Item("ps"))
            cp = flReg.WriteNumber(context.Request.Item("cp"))
            ru = flReg.DeCode64(context.Request.Item("ru"))
            context.Response.Write(flReg.NextPage(t, pr, cp, ps, ru & "&p="))
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