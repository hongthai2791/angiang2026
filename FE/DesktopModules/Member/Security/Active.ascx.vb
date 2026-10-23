Namespace Modules.MemberActive
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase

        Private Sub LoadLogo()
            litLogo.Text = EPORTAL.flCache.GetCache("LoadLogo_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias) & ""
            If litLogo.Text = "" Then
                For Each Cr As CMS.CMS_InfomationInfo In New CMS.CmsController().CMS_Infomation_List(0, 0)
                    litLogo.Text = "<a href=""" & EPORTAL.flConnect.WebDomain(Me.PortalId) & """ target=""_blank"" title=""home""><img src=""" & EPORTAL.flReg.ImgSRC(Cr.ImagePath, 0, 48, True) & """ alt=""logo"" /></a>"
                Next
                If litLogo.Text <> "" Then
                    EPORTAL.flCache.SetCache("LoadLogo_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias, litLogo.Text)
                Else
                    litLogo.Text = "<a href=""" & EPORTAL.flConnect.WebDomain(Me.PortalId) & """ target=""_blank"" title=""homekeng""><img src=""/image/hng/keng.png?h=48"" alt=""logo"" /></a>"
                End If
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Request.Item("rs") <> "" Then
                litRes.Text = EPORTAL.helper.ResetPass(Request.Item("rs"))
                pnew.Visible = False
                litRes.Text = "<div class=""member-login-title""><h3>Lấy lại mật khẩu</h3></div>" & litRes.Text
            Else
                EPORTAL.flDnn.DNN_User_Lock(EPORTAL.flReg.WriteNumber(EPORTAL.flReg.Decrypt("1", Request.Item("id"))), False, PortalId)
            End If
            Call LoadLogo()
        End Sub
    End Class

End Namespace
