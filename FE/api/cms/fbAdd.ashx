<%@ WebHandler Language="VB" Class="addcomment" %>

Imports DotnetNuke.CMS
Imports DotnetNuke.EPORTAL

Public Class addcomment : Implements IHttpHandler
    Dim Id, fname, mail, content, ip, pid As String
    Dim ObjController As New CmsController
    Dim info As New CMS_NewsFeedbackInfo
    Dim NOATAVAR_URL As String = "/images/noavatar.png"

    Public Function DeCode64(values As String) As String
        If values.Trim & "" = "" Then Return ""
        values = Encoding.Unicode.GetString(Convert.FromBase64String(values))
        Return values
    End Function
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            Id = context.Request.Item("id")
            fname = context.Request.Item("fname")
            mail = context.Request.Item("m")
            content = context.Request.Item("c")
            ip = context.Request.Item("rip")
            pid = context.Request.Item("pid")

            With info
                .ItemId = Id
                If pid = 15 Then 'Tiếng trung
                    .Content = DeCode64(content)
                    .FullName = DeCode64(fname)
                Else
                    .Content = flReg.DeCode64(content)
                    .FullName = flReg.DeCode64(fname)
                End If
                .Status = CommentStatus.Created
                .CreateDate = Date.Now
                .Type = 1
                .Avatar = NOATAVAR_URL
                .IPTrack = flReg.DeCode64(ip)
                .PortalId = pid
                .LanguageId = flConnect.IsLang
                .Email = flReg.DeCode64(mail)
            End With
            info.NewsFeedbackId = ObjController.CMS_NewsFeedback_Add(pid, info)

            Dim hisInfo As New CMS_NewsFeedBack_HistoryInfo
            hisInfo.NewFB_ID = info.NewsFeedbackId
            hisInfo.Contents = info.Content
            hisInfo.CreateDate = Now
            hisInfo.UserName = info.FullName
            ObjController.CMS_NewsFeedBack_History_Add(pid, hisInfo)

            context.Response.Write("")
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