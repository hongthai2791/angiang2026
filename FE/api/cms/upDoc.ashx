<%@ WebHandler Language="VB" Class="updateDoc" %>
Imports DotNetNuke.CMS

Public Class updateDoc : Implements IHttpHandler
    Dim idkey, pid As String
    Dim objCtl As New CmsController

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            idkey = context.Request.Item("id")
            pid = EPORTAL.flReg.WriteNumber(context.Request.Item("pid"))
            Dim obj As CMS_DocumentInfo = objCtl.CMS_Document_Get(pid, idkey)
            If IsNothing(obj) = False Then
                objCtl.CMS_Document_Update_IsDownload(pid, obj.Document_ID)
                If obj.IsURL <> "" Then
                    context.Response.Write(obj.IsURL)
                Else
                    context.Response.Write(EPORTAL.flConnect.fileDomain & obj.FileSource)
                End If
            Else
                context.Response.Write("nothing")
            End If
        Catch
            context.Response.Write("nothing")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class