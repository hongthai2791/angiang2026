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
        Public Function RedirectURL() As String
            Dim str As String = "/" & Me.PortalSettings.ActiveTab.TabName
            str += "/pid/" & Me.PortalId
            If txtTitle.Text.Trim <> "" Then str += "/key/" & txtTitle.Text.Trim
            Return str
        End Function

        Dim lit As Literal, textBox As TextBox
        Protected Sub grdTab1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("OrderNo")
            lit.Text = e.Item.ItemIndex + 1

            lit = e.Item.FindControl("Contents")
            lit.Text = "<a title='Bấm để xem chi tiết câu hỏi' href='/hoi-dap-chi-tiet/id/" & DataBinder.Eval(e.Item.DataItem, "ID") & "/pid/" & DataBinder.Eval(e.Item.DataItem, "PortalId") & "'>"
            lit.Text += DataBinder.Eval(e.Item.DataItem, "Contents") & "</a>"

            lit = e.Item.FindControl("Name")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "Name")

            lit = e.Item.FindControl("SendDate")
            lit.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "SendDate"), False)

        End Sub

        Private Sub GetID()
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1
            txtTitle.Text = flCheck.DecodeSearch(Request.Item("key") & "")

        End Sub
        Private Sub LoadQuestionList()
            Try
                'ltQues.Text = ""
                litPage.Text = ""
                Dim arr = New CmsController().CMS_FAQQuestions_List_Search(Me.PortalId, txtTitle.Text, "", 1, CurrentPage.Value, 10, "", QuestionStatus.DaDuyet)
                For Each Cr As CMS_FAQQuestionsInfo In arr
                    If Cr.Total > 10 Then
                        litPage.Text = flReg.NextPage(Cr.Total, 10, CurrentPage.Value, 5, RedirectURL() & "/p/")
                    End If
                    lbTotal.Text = flReg.FormatPrice(Cr.Total)
                    Exit For
                Next
                grdData.DataSource = arr
                grdData.DataBind()
                'Dim aswInfo As CMS_FAQAnswersInfo
                'For Each cr As CMS_FAQQuestionsInfo In arr
                'ltQues.Text += "<div class=""mt10 boxQues"">" & vbCrLf
                'ltQues.Text += String.Format("<a class=""btn btn-primary"" data-toggle=""collapse"" title=""Bấm để xem câu trả lời"" href=""#collapseExample{0}"" role=""button"" aria-expanded=""False"" aria-controls=""collapseExample"">{1}", cr.Id, flReg.Trimstr(cr.Contents, 300)) & vbCrLf
                'ltQues.Text += "</a>" & vbCrLf
                'ltQues.Text += String.Format("<div class=""collapse"" id=""collapseExample{0}"">", cr.Id) & vbCrLf
                'ltQues.Text += "<div class=""card card-body"">" & vbCrLf
                ''aswInfo = New CmsController().CMS_FAQAnswers_Get(Me.PortalId, cr.Id)
                ''If aswInfo IsNot Nothing Then
                ''    ltQues.Text += aswInfo.Contents
                ''Else
                ''    ltQues.Text += ""
                ''End If
                'ltQues.Text += cr.ContentAnswer

                'ltQues.Text += "<div class=""comment_item width_common"">" & vbCrLf
                'ltQues.Text += String.Format("<div class=""user_status""><a class=""avata_coment"" title=""{0}"">{1}</a></div>", cr.AnswerName, cr.Name.ToString().Substring(0, 1)) & vbCrLf
                'ltQues.Text += "<div class=""content-comment"">" & vbCrLf
                'ltQues.Text += String.Format("<span class=""txt-name""><a class=""nickname"" data-toggle=""collapse"" href=""#collapseExample{1}""><b>{0}</b></a></span>", cr.Name, cr.Id) & vbCrLf
                'ltQues.Text += String.Format("<a class=""full_content"" data-toggle=""collapse"" title=""Bấm để xem câu trả lời"" href=""#collapseExample{0}"">{1}</a>", cr.Id, flReg.Trimstr(cr.Contents, 300)) & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += String.Format("<div class=""collapse"" id=""collapseExample{0}"">", cr.Id) & vbCrLf
                'ltQues.Text += "<div class=""sub_comment width_common"">" & vbCrLf
                'ltQues.Text += "<div class=""sub_comment_item comment_item width_common"">" & vbCrLf
                'ltQues.Text += "<div class=""user_status"">" & vbCrLf
                'ltQues.Text += "<a class=""avata_coment"" title=""Việc làm hòa bình"">" & vbCrLf
                'ltQues.Text += String.Format("<img class=""img_avatar"" src=""http://file.eportal.top/image/noimage/2.jpg?dpi=50&quality=50""></a>") & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += "<div class=""content-comment"">" & vbCrLf
                'ltQues.Text += String.Format("<p class=""full_content"">{0}</p>", flReg.Trimstr(cr.ContentAnswer, 500)) & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf
                'ltQues.Text += "</div>" & vbCrLf

                'Next
            Catch ex As Exception
                litPage.Text = ex.ToString
            End Try
        End Sub
        Private Sub FAQ_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                GetID()
                LoadQuestionList()
                If Me.UserId > 0 Then
                    FullName.Text = Me.UserInfo.DisplayName
                    Email.Text = Me.UserInfo.Email
                    Tel.Text = Me.UserInfo.Profile.Telephone
                End If
            End If
        End Sub

        Private Sub lbtFind_Click(sender As Object, e As EventArgs) Handles lbtFind.Click
            LoadQuestionList()
        End Sub
    End Class
End Namespace

