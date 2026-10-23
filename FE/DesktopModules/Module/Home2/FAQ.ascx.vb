Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Namespace DesktopModules.Modules.Home
    Partial Class FAQ
        Inherits Entities.Modules.PortalModuleBase

        Private Sub cmdBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/", True)
        End Sub
        Private Sub ClearFrom()
            Email.Text = ""
            Contents.Text = ""
            FullName.Text = ""
            Tel.Text = ""
        End Sub
        Private Sub cmdSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSend.Click
            Try
                If ctlCaptcha.IsValid = True Then
                    Dim _email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                    If Email.Text <> "" Then
                        If _email.IsMatch(Email.Text) = False Then
                            lbMsg.Text = "<div class='that-bai'>Địa chỉ email không hợp lệ. Vui lòng thử lại!</div>"
                            Exit Sub
                        End If
                    Else
                        lbMsg.Text = "<div class='that-bai'>Bạn chưa nhập vào địa chỉ email liên hệ của bạn!</div>"
                        Exit Sub
                    End If
                    If Contents.Text.Trim = "" Then
                        lbMsg.Text = "<div class='that-bai'>Bạn chưa nhập vào nội dung liên hệ của bạn!</div>"
                        Exit Sub
                    End If
                    Dim objInfo As New CMS_FAQQuestionsInfo
                    Dim objController As New CmsController
                    objInfo.Name = FullName.Text.Trim & ""
                    objInfo.Email = Email.Text
                    objInfo.Phone = Tel.Text
                    objInfo.Contents = flReg.RemoveScript(Contents.Text)
                    objInfo.PortalId = Me.PortalId
                    objInfo.UpdateDate = Now
                    objInfo.SendDate = Now
                    objInfo.CreateDate = Now
                    objInfo.Status = QuestionStatus.DaGui
                    objInfo.FAQID = ""
                    objInfo.IsPublic = False
                    If Me.UserId > 0 Then objInfo.CreateUser = Me.UserInfo.Username
                    objController.CMS_FAQQuestions_Add(Me.PortalId, objInfo)
                    lbMsg.Text = "<div class='thanh-cong'>Câu hỏi của bạn đã được gửi đi, chúng tôi sẽ duyệt đăng trong thời gian sớm nhất. Trân trọng!</div>"
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success_0", " notify('success', 'Bạn đã gửi câu hỏi thành công', 'Thông báo', false);", True)
                    Call ClearFrom()
                End If
            Catch ex As Exception
                'lbMsg.Text = "<div class='that-bai'>Hệ thống đang bận. Vui lòng quay lại sau ít phút!</div>"
                lbMsg.Text = ex.ToString()
            End Try
        End Sub
        Private Sub LoadQuestionList()
            Try
                ltQues.Text = ""
                Dim arr = New CmsController().CMS_FAQQuestions_List_Search(Me.PortalId, "", "", 1, 1, 30, "", QuestionStatus.DaDuyet)
                Dim aswInfo As CMS_FAQAnswersInfo
                For Each cr As CMS_FAQQuestionsInfo In arr
                    ltQues.Text += "<div class=""mt10 boxQues"">" & vbCrLf
                    ltQues.Text += String.Format("<a class=""btn btn-primary"" data-toggle=""collapse"" title=""Bấm để xem câu trả lời"" href=""#collapseExample{0}"" role=""button"" aria-expanded=""False"" aria-controls=""collapseExample"">{1}", cr.Id, flReg.Trimstr(cr.Contents, 300)) & vbCrLf
                    ltQues.Text += "</a>" & vbCrLf
                    ltQues.Text += String.Format("<div class=""collapse"" id=""collapseExample{0}"">", cr.Id) & vbCrLf
                    ltQues.Text += "<div class=""card card-body"">" & vbCrLf
                    aswInfo = New CmsController().CMS_FAQAnswers_Get(Me.PortalId, cr.Id)
                    If aswInfo IsNot Nothing Then
                        ltQues.Text += aswInfo.Contents
                    Else
                        ltQues.Text += ""
                    End If
                    ltQues.Text += "</div>" & vbCrLf
                    ltQues.Text += " </div>" & vbCrLf
                    ltQues.Text += "</div>" & vbCrLf

                Next
            Catch ex As Exception

            End Try
        End Sub
        Private Sub FAQ_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                LoadQuestionList()
                If Me.UserId > 0 Then
                    FullName.Text = Me.UserInfo.DisplayName
                    Email.Text = Me.UserInfo.Email
                    Tel.Text = Me.UserInfo.Profile.Telephone
                End If
            End If
        End Sub
    End Class
End Namespace

