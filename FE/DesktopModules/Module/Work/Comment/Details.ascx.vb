Imports DotNetNuke.EPORTAL
Imports DotnetNuke.WORK

Namespace DesktopModules.Modules.FeedBack
    Partial Public Class answer_comment
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController
        Dim arr As New ArrayList
        Dim idFedd, _portalID As Integer
        Dim objWF As New CMS_News_UserWFInfo
        Dim info As New CMS_NewsFeedbackInfo
        Dim _UrlAlias As String = flConnect.WebDomain(0)
        Dim hisInfo As New CMS_NewsFeedBack_HistoryInfo

        Public Function EnCode64(values As String) As String
            If values.Trim & "" = "" Then Return ""
            Return Convert.ToBase64String(Encoding.Unicode.GetBytes(values))
        End Function
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            _portalID = flReg.WriteNumber(Request.Item("pid") & "")
            Try
                If Not IsPostBack Then
                    Call LoadValue()
                    If flReg.WriteNumber(hditemid.Value) > 0 Then
                        ''strLink.Value = Ultis.FormatLink(_portalID, hdcategory.Value, hditemid.Value, hdTourl.Value)
                        'strLink.Value = strLink.Value.Replace(_UrlAlias, flConnect.WebDomain(_portalID))
                    End If
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub LoadValue()
            idFedd = flReg.WriteNumber(Request.Item("idfeed"))
            arr = ObjController.CMS_NewsFeedback_Get_By_FBID(_portalID, idFedd)
            ltrAnswer.Text = ""
            For Each cr As CMS_NewsFeedbackInfo In arr
                If cr.Status <> CommentStatus.Created Then
                    cmdActive.Visible = False
                    cmdUpdate.Visible = False
                End If
                If cr.ParentID = 0 Then
                    txtTitle.Text = cr.Title
                    txtLoiBinh.Text = cr.Content
                    txtComment.Text = cr.Content
                    ltrNguoiGui.Text = cr.FullName
                    ltrNgayGui.Text = cr.CreateDate.ToString("dd/MM/yyyy HH:mm")
                    ltrIp.Text = cr.IPTrack
                    hdcategory.Value = cr.CategoryId
                    hdTourl.Value = cr.ToUrl
                    hditemid.Value = cr.ItemId
                    hdMailTo.Value = cr.Email
                Else
                    If Request.Item("editid") = cr.NewsFeedbackId Then
                        txtanswer.Text = cr.Content
                    Else
                        ltrAnswer.Text += "<div class=""traloi"">"
                        ltrAnswer.Text += "<img class=""nimg"" src=""/images/noavatar.png"">"
                        ltrAnswer.Text += "<div class=""nname"">" & cr.FullName & "</div>"
                        ltrAnswer.Text += "<div class=""ntime"">(" & cr.CreateDate.ToString("dd/MM/yyyy HH:mm") & ")</div>"
                        ltrAnswer.Text += "<div class=""alleditdelete"">"
                        ltrAnswer.Text += "<div class=""nedit"">"
                        ltrAnswer.Text += "<a href=""/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/idfeed/" & idFedd & "/editid/" & cr.NewsFeedbackId & "/type/" & cr.Type.ToString

                        If Request.Item("capnhat") & "" <> "" Then
                            ltrAnswer.Text += "/itemid/" & cr.ItemId & "/portalid/" & cr.PortalId & "/capnhat/1/parentid/" & Request.Item("editid") & """>Sửa</a></div>"
                        Else
                            ltrAnswer.Text += "/itemid/" & cr.ItemId & "/portalid/" & cr.PortalId & "/parentid/" & Request.Item("editid") & """>Sửa</a></div>"
                        End If
                        ltrAnswer.Text += "&nbsp;<a class=""hove-point"" title=""Lịch sử thay đổi"" onclick=""popVersion(1000,650," & cr.NewsFeedbackId & "," & _portalID & ",'feedback')"">"
                        ltrAnswer.Text += "<img src=""/image/icon/history.png"" alt=""Lịch sử thay đổi""></a>"

                        ltrAnswer.Text += "<div class=""ndelete ""><img class=""del"" onclick=""javascript:del(" & cr.NewsFeedbackId & ");"" src=""/images/delete.gif""></div>"
                        ltrAnswer.Text += "</div>"
                        ltrAnswer.Text += "<div class=""cm""> " & cr.Content & "</div>"
                        ltrAnswer.Text += "</div>"
                    End If
                End If
            Next
            If flReg.WriteNumber(Request.Item("capnhat") & "") = 1 Then
                cmdPublic.Visible = True
                cmdSave.Visible = True
                cmdPrivate.Visible = True
                cmdUpdate.Visible = True
            Else
                cmdActive.Visible = True
            End If
            litHis.Text = "&nbsp;&nbsp;=>&nbsp;<a class=""hove-point"" title=""Lịch sử thay đổi"" onclick=""popVersion(1000,650," & idFedd & "," & _portalID & ",'feedback')"">"
            litHis.Text += "Lịch sử thay đổi</a>"
        End Sub
        Private Sub SaveHistory(idKey As Integer, strValue As String)
            hisInfo = New CMS_NewsFeedBack_HistoryInfo
            hisInfo.NewFB_ID = idKey
            hisInfo.Contents = strValue
            hisInfo.CreateDate = Now
            hisInfo.UserName = Me.UserInfo.Username
            ObjController.CMS_NewsFeedBack_History_Add(_portalID, hisInfo)
        End Sub
        Private Sub UpdateComment()
            If txtComment.Text.Trim <> txtLoiBinh.Text.Trim Then
                idFedd = Request.Item("idfeed")
                info = ObjController.CMS_NewsFeedback_Get(_portalID, idFedd)
                info.Content = txtLoiBinh.Text
                ObjController.CMS_NewsFeedback_Update(_portalID, info)

                txtComment.Text = txtLoiBinh.Text

                Call SaveHistory(idFedd, txtLoiBinh.Text)
            End If
        End Sub
        Private Sub cmdActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActive.Click
            Call UpdateComment()
            ObjController.CMS_NewsFeedback_Update_Status(_portalID, Request.Item("idfeed"), CommentStatus.Watting)
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/portalid/" & _portalID, True)
        End Sub
        Private Sub cmdPublic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPublic.Click
            Try
                Call UpdateComment()
                Dim htmlMail As String = ""
                Dim htmlMail1 As String = ""

                ObjController.CMS_NewsFeedback_Update_Status(_portalID, Request.Item("idfeed"), CommentStatus.Pulished)
                arr = ObjController.CMS_NewsFeedback_Get_By_FBID(_portalID, Request.Item("idfeed"))
                For Each cr As CMS_NewsFeedbackInfo In arr
                    If cr.ParentID = 0 Then
                        htmlMail = "<strong>Tên bài viết: </strong>" & cr.Title & "<br/>"

                        htmlMail += "<a href=" & flCheck.GetHomeLinkWork(cr.Title, cr.ItemId) & ">Xem chi tiết tại địa chỉ</a><br/>"
                        htmlMail += "<strong>Nội dung phản hồi </strong>" & cr.Content & "<br/>"
                        hdMailTo.Value = cr.Email
                    Else
                        htmlMail1 += cr.Content & "<p/>"
                    End If
                Next
                htmlMail += "<strong>Nội dung trả lời </strong>" & htmlMail1
                flDnn.DNN_SendMail(hdMailTo.Value, "Cổng thông tin trả lời phản hồi của bạn đọc:", htmlMail)
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/send-comment/portalid/" & _portalID, True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
            Call UpdateComment()
            ObjController.CMS_NewsFeedback_Update_Status(_portalID, Request.Item("idfeed"), CommentStatus.Active)
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/send-comment/portalid/" & _portalID, True)
        End Sub
        Private Sub cmdPrivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrivate.Click
            Try
                Call UpdateComment()
                Dim htmlMail As String = ""
                Dim htmlMail1 As String = ""

                ObjController.CMS_NewsFeedback_Update_Status(_portalID, Request.Item("idfeed"), CommentStatus.SendMail)
                arr = ObjController.CMS_NewsFeedback_Get_By_FBID(_portalID, Request.Item("idfeed"))
                For Each cr As CMS_NewsFeedbackInfo In arr
                    If cr.ParentID = 0 Then
                        htmlMail = "<strong>Tên bài viết: </strong>" & cr.Title & "<br/>"

                        htmlMail += "<a href=" & flCheck.GetHomeLinkWork(cr.Title, cr.ItemId) & ">Xem chi tiết tại địa chỉ</a><br/>"
                        htmlMail += "<strong>Nội dung phản hồi </strong>" & cr.Content & "<br/>"
                        hdMailTo.Value = cr.Email
                    Else
                        htmlMail1 += cr.Content & "<p/>"
                    End If
                Next
                htmlMail += "<strong>Nội dung trả lời </strong>" & htmlMail1
                flDnn.DNN_SendMail(hdMailTo.Value, "Trung tâm dịch vụ việc làm trả lời:", htmlMail)
                ObjController.CMS_NewsFeedback_Update_Status(_portalID, Request.Item("idfeed"), CommentStatus.SendMail)
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/portalid/" & _portalID, True)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/portalid/" & _portalID, True)
        End Sub
        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

            ObjController.CMS_NewsFeedback_Delete(_portalID, hdDelete.Value)
            Call LoadValue()
        End Sub
        Private Sub cmdNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNote.Click

            info = New CMS_NewsFeedbackInfo
            info.ItemId = Request.Item("itemid")
            info.Content = txtanswer.Text
            info.Type = Request.Item("type")
            info.Status = 1
            info.IPTrack = Request.ServerVariables("REMOTE_ADDR")
            info.PortalId = _portalID
            info.LanguageId = flConnect.IsLang
            info.CreateDate = Date.Now
            info.FullName = UserInfo.DisplayName

            Dim strUrl As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/idfeed/" & Request.Item("idfeed")
            If Request.Item("parentid") & "" <> "" Then
                info.ParentID = Request.Item("parentid")
                info.NewsFeedbackId = Request.Item("editid")
                ObjController.CMS_NewsFeedback_Update(_portalID, info)

                strUrl += "/editid/" & Request.Item("parentid") & "/type/" & Request.Item("type")
            Else
                strUrl += "/editid/" & Request.Item("editid") & "/type/" & Request.Item("type")

                info.ParentID = Request.Item("editid")
                info.NewsFeedbackId = ObjController.CMS_NewsFeedback_Add(_portalID, info)
            End If
            Call SaveHistory(info.NewsFeedbackId, info.Content)

            If Request.Item("capnhat") & "" <> "" Then
                strUrl += "/itemid/" & Request.Item("itemid") & "/portalid/" & _portalID & "/capnhat/1"
            Else
                strUrl += "/itemid/" & Request.Item("itemid") & "/portalid/" & _portalID
            End If

            Response.Redirect(strUrl, True)
        End Sub
        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                Call UpdateComment()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdUpdate_Click", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdUpdate_Error", " notify('error', 'Lỗi cập nhật thông tin.', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace