Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class MenuMain
        Inherits PortalModuleBase
        Dim UrlAlias As String = flReg.UrlAlias

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                ctlView.Visible = Me.EditMode
                ltAccount.Text = ""

                If Me.UserId > 0 Then
                    If Me.UserInfo.IsInRole("business") Then
                        ltAccount.Text += "Xin chào " & Me.UserInfo.DisplayName & "<a class=""account-info"" title='Bấm để vào quản trị tài khoản của bạn' href='/business'><i class='fa fa-cog'></i></a>&nbsp;<a class=""account-logoff"" title='Bấm để đăng xuất tài khoản' href='/logoff'><i class='fa fa-sign-out'></i></a>" & vbCrLf

                    ElseIf Me.UserInfo.IsInRole("users") Then
                        ltAccount.Text += "Xin chào " & Me.UserInfo.DisplayName & "<a class=""account-info"" title='Bấm để vào quản trị tài khoản của bạn' href='/users'><i class='fa fa-cog'></i></a>&nbsp;<a class=""account-logoff"" title='Bấm để đăng xuất tài khoản' href='/logoff'><i class='fa fa-sign-out'></i></a>" & vbCrLf
                    Else
                        ltAccount.Text += ""
                    End If
                    If Me.UserInfo.IsInRole("cms") Or Me.UserInfo.IsInRole("work") Or Me.UserInfo.IsInRole("chatbot") Or Me.UserInfo.IsInRole("dic") Or Me.UserInfo.IsSuperUser Then
                        ltAccount.Text += "<a class=""account-info hidden-xs"" title='Bạn là quản trị viên' href='/system'><i class='fa fa-cube'></i></a>"
                    End If
                Else
                    ltAccount.Text += "<a  class=""btnRegister"" href=""/dang-ky"" title=""đăng ký thành viên""><i class=""fa fa-user-plus""></i> Đăng ký </a>" & vbCrLf
                    ltAccount.Text += "<a href=""/dang-nhap"" class=""btnLogin"" title=""đăng nhập"" ><i class=""fa fa-sign-in""></i> Đăng nhập</a>" & vbCrLf
                End If
                litBanner.Text = flCache.GetCache("bannerLogo_" & Me.PortalId) & ""
                If litBanner.Text = "" Then
                    Call LoadInfomation()
                    flCache.SetCache("bannerLogo_" & Me.PortalId, litBanner.Text)
                End If
            Catch ex As Exception
                litBanner.Text = ex.Message
            End Try
        End Sub

        Private Sub LoadInfomation()
            For Each Cr As CMS_InfomationInfo In New CmsController().CMS_Infomation_List(PortalId, PortalId)
                litBanner.Text = "<div class=""vlogo"">"
                litBanner.Text += "<a href=""" & UrlAlias & """ title=""home"" class=""logo-avatar "">"
                litBanner.Text += "<img src=""" & flReg.ImgSRC(Cr.ImagePath, 0, 70, True) & """ alt=""home""/>"
                litBanner.Text += "</a>"
                litBanner.Text += "</div>"
                litBanner.Text += "<div class=""vlogo hidden-xs"">"
                litBanner.Text += "<a href=""" & UrlAlias & """ title=""" & flReg.ImgAlt(Cr.NameH1) & """ class=""text-banner""></a>"
                litBanner.Text += "</div>"
            Next
        End Sub
    End Class
End Namespace

