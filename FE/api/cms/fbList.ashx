<%@ WebHandler Language="VB" Class="listcomment" %>
Imports DotnetNuke.CMS
Imports DotnetNuke.EPORTAL

Public Class listcomment : Implements IHttpHandler
    Dim CurrentPage, litComment As String
    Dim ObjControler As New CMSController
    Dim ItemId, TotalRecord As Integer
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            CurrentPage = flReg.WriteNumber(context.Request.Item("p"))
            ItemId = flReg.WriteNumber(context.Request.Item("id"))
            litComment = "<div class='row pdt10'><div class='members-comments'>"
            Dim arrList, arr As New ArrayList
            arrList = ObjControler.CMS_NewsFeedback_List_By_NewsID(GetPortalSettings.PortalId, ItemId, CommentStatus.Pulished & "," & CommentStatus.Active, 0, GetPortalSettings.PortalId, flConnect.IsLang, CurrentPage, 10)
            For Each Cr As CMS_NewsFeedbackInfo In arrList
                litComment += "<div class='bs-callout bs-callout-info' style='margin:0!important;'>"
                litComment += "<div class='col-sm-2 col-xs-2'>"
                litComment += "<div class='comment-user'>"
                litComment += "<img src='" & IIf(Cr.Avatar & "" <> "", Cr.Avatar, "/images/noavatar.png") & "' class='img-thumbnail avatar'"
                litComment += "data-toggle='tooltip' data-placement='top' title='" & Cr.FullName & "' />"
                litComment += "</div></div><div class='col-sm-10 col-xs-10'>"
                litComment += "<div class='comment-info'><div class='c-arrow'></div>"
                litComment += "<div class='c-content'>"
                litComment += "<span class='c-info'>" & Cr.FullName & "</span> - <span class='c-date'>on " & Cr.CreateDate & "</span>"
                litComment += "<div class='c-des'>" & Cr.Content & "</div>"
                litComment += "</div></div></div><div class='clear'></div>"
                litComment += "</div>"
                arr = ObjControler.CMS_NewsFeedback_List_By_NewsID(GetPortalSettings.PortalId, ItemId, CommentStatus.Pulished & "," & CommentStatus.Active, Cr.NewsFeedbackId, GetPortalSettings.PortalId, flConnect.IsLang, CurrentPage, 100)
                For Each Cj As CMS_NewsFeedbackInfo In arr
                    litComment += "<div class='bs-callout bs-callout-info' style='margin:0!important;'>"
                    litComment += "<div class='col-sm-2 col-sm-2'>"
                    litComment += "<div class='comment-user' style='margin-left: 15px;'>"
                    litComment += "<img src='/images/noavatar.png' class='img-thumbnail avatar'"
                    litComment += "data-toggle='tooltip' data-placement='top' title='" & Cj.FullName & "' />"
                    litComment += "</div></div><div class='col-sm-10 col-sm-10'>"
                    litComment += "<div class='comment-info'><div class='c-arrow'></div>"
                    litComment += "<div class='c-content'>"
                    litComment += "<span class='c-info'>" & Cj.FullName & "</span> - <span class='c-date'>on " & Cj.CreateDate & "</span>"
                    litComment += "<div class='c-des'>" & Cj.Content & "</div>"
                    litComment += "</div></div></div><div class='clear'></div>"
                    litComment += "</div>"
                Next
                TotalRecord = Cr.Total
            Next
            litComment += "</div></div>"
            If TotalRecord > 10 Then
                litComment += "<div class=""row pdt10""><div class='comments-title'><i class='fa fa-comments-o f-1d5'>&nbsp;&nbsp;</i><span class='comments-name'>DANH SÁCH Ý KIẾN ĐÓNG GÓP (" & TotalRecord & ")</span></div>"
                litComment += flReg.NextPageJs(TotalRecord, 10, CurrentPage, 5, "fnext(")
                litComment += "</div>"
            End If
            context.Response.Write(litComment)
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