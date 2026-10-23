Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication

Namespace Modules.AdminLogin
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Request.Item("page") & "" <> "" Then plogin.Visible = False
            txtUsername.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdLogin.ClientID + "')")
            txtPassword.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdLogin.ClientID + "')")
        End Sub

        Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
            Dim status As New DotNetNuke.Security.Membership.UserLoginStatus()
            status = UserLoginStatus.LOGIN_FAILURE
            Try
                Dim obj = UserController.ValidateUser(PortalId, txtUsername.Text.Trim, txtPassword.Text, "DNN", PortalSettings.PortalName, DotNetNuke.Services.Authentication.AuthenticationLoginBase.GetIPAddress(), status)
                If status = UserLoginStatus.LOGIN_SUCCESS OrElse status = UserLoginStatus.LOGIN_SUPERUSER Then
                    UserController.UserLogin(PortalId, obj, PortalSettings.PortalName, DotNetNuke.Services.Authentication.AuthenticationLoginBase.GetIPAddress(), False)
                    Dim eventArgs As New UserAuthenticatedEventArgs(obj, txtUsername.Text.Trim, status, "DNN")
                    eventArgs.Authenticated = True
                    Response.Redirect("/sub", True)
                ElseIf status = UserLoginStatus.LOGIN_USERLOCKEDOUT Then
                    lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">"
                    lbmsg.Text += "<span>Tài khoản này đã bị khóa sau quá nhiều cố gắng đăng nhập không thành công. Hãy đợi 10 phút trước khi thử đăng nhập lại.</span>"
                    lbmsg.Text += "<span>Nếu bạn đã quên mật khẩu, hãy chọn chứ năng lấy lại mật khẩu trước khi liên hệ với Quản trị để được trợ giúp.</span>"
                    lbmsg.Text += "</div>"
                Else
                    lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">"
                    lbmsg.Text += "<span>Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng kiểm tra lại</span>"
                    lbmsg.Text += "</div>"
                End If
            Catch ex As Exception
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">"
                lbmsg.Text += "<span>Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng kiểm tra lại</span>"
                lbmsg.Text += "</div>"
            End Try
        End Sub
    End Class

End Namespace
