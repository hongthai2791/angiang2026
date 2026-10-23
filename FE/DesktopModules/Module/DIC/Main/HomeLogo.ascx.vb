Imports DotNetNuke.Entities.Modules
Namespace DesktopModules.Modules.Home
    Partial Class LogoProfile
        Inherits PortalModuleBase

		Private Sub LogoProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
			Try
				If Page.IsPostBack = False Then
					litLogo.Text = EPORTAL.flCache.GetCache("LogoProfile_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias) & ""
					If litLogo.Text = "" Then
						Dim obj As EPORTAL.CMS_ConfigTPInfo = EPORTAL.flDnn.CMS_ConfigTP_Get_By_TinhTP(0, EPORTAL.flReg.WebConfig("TinhTP"), EPORTAL.flReg.UrlAlias)
						If IsNothing(obj) = False Then
							litLogo.Text = "<div class=""i-img""><a href=""/"" title=""Trang chủ""><img src=""" & EPORTAL.flReg.ImgSRC(obj.PortalLogo, 0, 32, True) & """ alt=""Logo"" /></a></div>"
							litLogo.Text += "<div class=""i-title""><a href=""/"" title=""Trang chủ"">" & obj.PortalName & "</a></div>"
							EPORTAL.flCache.SetCache("LogoProfile_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias, litLogo.Text)
						Else
							litLogo.Text = "<div class=""i-img""><a href=""" & EPORTAL.flConnect.WebDomain(0) & """ target=""_blank"" title=""home""><img src=""/image/hng/bigtech.png?h=32"" alt=""logo"" /></a></div>"
						End If
					End If
				End If
			Catch ex As Exception
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
			End Try
		End Sub
	End Class
End Namespace

