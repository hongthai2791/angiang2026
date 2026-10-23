Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Namespace DesktopModules.Modules.Home
    Partial Class Lienhe
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
        Private Sub SendMail(toMail As String)
            Dim subject As String = "VLPY | Người dùng gửi liên hệ."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "Liên hệ được gửi đến từ Ông /Bà: <b>" & FullName.Text.Trim & " (" & Email.Text & ")" & "</b><p></p>"
            body += "<p>Nội dung: </p> " & flReg.RemoveHTML(Contents.Text)
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị VLPY</div>"
            flDnn.DNN_SendMail(toMail, subject, body)
        End Sub
        Private Sub cmdSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSend.Click
            Try
                'If ctlCaptcha.IsValid = True Then
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
                Dim objInfo As New CMS_ContactInfo
                Dim objController As New CmsController
                Dim readmail, str() As String
                objInfo.FullName = FullName.Text.Trim & ""
                objInfo.Email = Email.Text
                objInfo.Tel = Tel.Text
                objInfo.Contents = flReg.RemoveScript(Contents.Text)
                objInfo.PortalId = Me.PortalId

                objInfo.CreatedDate = Now
                objInfo.Status = True
                objInfo.Address = ""
                objInfo.Subject = ""
                readmail = flReg.SettingValue(flConnect.DmConnect, "cms", "WF_EMAIL_LH", "lien-he")
                'If checkmail.Checked = True Then
                '    str = readmail.Split(";")
                '    For i = 0 To str.Length - 1
                '        SendMail(str(i))
                '        'flDnn.DNN_SendMail(str(i), Email.Text, objInfo.Contents)
                '    Next
                'End If
                objController.CMS_Contact_Add(Me.PortalId, objInfo)
                'Dim toMail As String = flReg.SettingValue(flConnect.DmConnect, "cms", "WF_EMAIL_LH", "lien-he") & ""
                'If toMail <> "" Then SendMail(toMail)
                lbMsg.Text = "<div class='thanh-cong'>Thông tin của Bạn đã được chuyển đến bộ phận hỗ trợ, chúng tôi sẽ gọi lại/mail lại trong thời gian sớm nhất. Trân trọng!</div>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success_0", " notify('success', 'Bạn đã đăng liên hệ thành công', 'Thông báo', false);", True)
                Call ClearFrom()

                'End If
            Catch ex As Exception
                lbMsg.Text = "<div class='that-bai'>Hệ thống đang bận. Vui lòng quay lại sau ít phút!</div>"
            End Try
        End Sub
    End Class
End Namespace

