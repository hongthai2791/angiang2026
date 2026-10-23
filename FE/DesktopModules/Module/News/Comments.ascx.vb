Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Home
    Partial Class Comments

        Inherits PortalModuleBase
        Dim ObjControler As New CmsController
        Private NOATAVAR_URL As String = "/images/noavatar.png"
        Dim info As New CMS_NewsFeedbackInfo
        Dim TotalRecord As Integer, strVal As String
        Dim arrList, arr As New ArrayList
#Region "Event"
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ItemId.Value = flReg.WriteNumber(Ultis.GetRequestId(Request.RawUrl))
            If Not Page.IsPostBack Then
                FullName.Text = Me.UserInfo.DisplayName & ""
                Call BindComments()
                _IPContrack.Value = Request.ServerVariables("REMOTE_ADDR")
            End If
        End Sub

        Public Sub BindComments()
            If IsNothing(flCache.GetCache("BindComments_" & Me.PortalId & "_" & ItemId.Value & "_" & CurrentPage.Value)) Then
                arrList = ObjControler.CMS_NewsFeedback_List_By_NewsID(Me.PortalId, ItemId.Value, CommentStatus.Pulished & "," & CommentStatus.Active, 0, PortalId, flConnect.IsLang, CurrentPage.Value, 10)
                flCache.SetCache("BindComments_" & Me.PortalId & "_" & ItemId.Value & "_" & CurrentPage.Value, arrList, SecondCache.S8)
            Else
                arrList = CType(flCache.GetCache("BindComments_" & Me.PortalId & "_" & ItemId.Value & "_" & CurrentPage.Value), ArrayList)
            End If
            If arrList.Count > 0 Then
                litComment.Text = "<div class='comment-view'><div class='row pdt10'><div class='members-comments'>"
                For Each Cr As CMS_NewsFeedbackInfo In arrList
                    litComment.Text += "<div class='bs-callout bs-callout-info' style='margin:0!important;'>"
                    litComment.Text += "<div class='col-sm-2 col-xs-2'>"
                    litComment.Text += "<div class='comment-user'>"
                    litComment.Text += "<img alt=""avatar"" src='" & IIf(Cr.Avatar & "" <> "", Cr.Avatar, "/images/noavatar.png?w") & "' class='img-thumbnail avatar'"
                    litComment.Text += "data-toggle='tooltip' data-placement='top' title='" & Cr.FullName & "' />"
                    litComment.Text += "</div></div><div class='col-sm-10 col-xs-10'>"
                    litComment.Text += "<div class='comment-info'><div class='c-arrow'></div>"
                    litComment.Text += "<div class='c-content'>"
                    litComment.Text += "<span class='c-info'>" & Cr.FullName & "</span> - <span class='c-date'>on " & Cr.CreateDate & "</span>"
                    litComment.Text += "<div class='c-des'>" & Cr.Content & "</div>"
                    litComment.Text += "</div></div></div><div class='clear'></div>"
                    litComment.Text += "</div>"

                    If IsNothing(flCache.GetCache("BindComments_NewsFeedbackId_" & Me.PortalId & "_" & ItemId.Value & "_" & Cr.NewsFeedbackId)) Then
                        arr = ObjControler.CMS_NewsFeedback_List_By_NewsID(Me.PortalId, ItemId.Value, CommentStatus.Pulished & "," & CommentStatus.Active, Cr.NewsFeedbackId, PortalId, flConnect.IsLang, 1, 100)
                        flCache.SetCache("BindComments_NewsFeedbackId_" & Me.PortalId & "_" & ItemId.Value & "_" & Cr.NewsFeedbackId, arr, SecondCache.S8)
                    Else
                        arr = CType(flCache.GetCache("BindComments_NewsFeedbackId_" & Me.PortalId & "_" & ItemId.Value & "_" & Cr.NewsFeedbackId), ArrayList)
                    End If

                    For Each Cj As CMS_NewsFeedbackInfo In arr
                        litComment.Text += "<div class='bs-callout bs-callout-info' style='margin:0!important;'>"
                        litComment.Text += "<div class='col-sm-2 col-sm-2'>"
                        litComment.Text += "<div class='comment-user' style='margin-left: 15px;'>"
                        litComment.Text += "<img alt=""avatar"" src='/images/noavatar.png?w' class='img-thumbnail avatar'"
                        litComment.Text += "data-toggle='tooltip' data-placement='top' title='" & Cj.FullName & "' />"
                        litComment.Text += "</div></div><div class='col-sm-10 col-sm-10'>"
                        litComment.Text += "<div class='comment-info'><div class='c-arrow'></div>"
                        litComment.Text += "<div class='c-content'>"
                        litComment.Text += "<span class='c-info'>" & Cj.FullName & "</span> - <span class='c-date'>on " & flReg.ReadDate(Cj.CreateDate) & "</span>"
                        litComment.Text += "<div class='c-des'>" & Cj.Content & "</div>"
                        litComment.Text += "</div></div></div><div class='clear'></div>"
                        litComment.Text += "</div>"
                    Next
                    TotalRecord = Cr.Total
                Next

                strVal = "<div class='row pdt10' style='padding-left: 15px;'>"
                strVal += "<div class='comments-title'><i class='fa fa-comments-o f-1d5'>&nbsp;&nbsp;</i><span class='comments-name'>DANH SÁCH BÌNH LUẬN (" & TotalRecord & ")</span></div>"
                strVal += "</div>"

                litComment.Text += "</div></div>"
                If TotalRecord > 10 Then
                    litComment.Text += "<div class=""row pdt10"">"
                    litComment.Text += flReg.NextPageJs(TotalRecord, 10, CurrentPage.Value, 5, "fnext(")
                    litComment.Text += "</div>"
                End If
                litComment.Text = strVal & litComment.Text & "</div>"
            End If
        End Sub

        Public Function EnCode64(values As String) As String
            If values.Trim & "" = "" Then Return ""
            Return Convert.ToBase64String(Encoding.Unicode.GetBytes(values))
        End Function

        Public Sub ClearForm()
            Contents.Text = ""
            Email.Text = ""
            FullName.Text = ""
        End Sub
#End Region
    End Class
End Namespace