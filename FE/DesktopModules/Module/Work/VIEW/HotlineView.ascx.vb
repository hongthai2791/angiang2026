Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules

Namespace DotNetNuke.Modules
    Partial Public Class HotlineView
        Inherits ModuleSettingsBase
        Dim objModules As New Entities.Modules.ModuleController
        Dim _tabName As String = PortalSettings.ActiveTab.TabName

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call LoadSettings()
            End If
        End Sub

        Public Overrides Sub LoadSettings()
            Try
                ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName
                NLD_Hotline.Text = flCheck.SetupValue(0, "NLD_Hotline")
                NTD_Hotline.Text = flCheck.SetupValue(0, "NTD_Hotline")
                NLD_Email.Text = flCheck.SetupValue(0, "NLD_Email")
                NTD_Email.Text = flCheck.SetupValue(0, "NTD_Email")
            Catch exc As Exception
            End Try
        End Sub

        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub Removecachehotlineview()
            flCache.RemoveCache("SetupValue0NLD_Hotline")
            flCache.RemoveCache("SetupValue0NTD_Hotline")
            flCache.RemoveCache("SetupValue0NLD_Email")
            flCache.RemoveCache("SetupValue0NTD_Email")
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                Call Removecachehotlineview()
                flFunction.SaveSetup(0, "NLD_Hotline", NLD_Hotline.Text, Me.UserInfo.Username)
                flFunction.SaveSetup(0, "NTD_Hotline", NTD_Hotline.Text, Me.UserInfo.Username)
                flFunction.SaveSetup(0, "NLD_Email", NLD_Email.Text, Me.UserInfo.Username)
                flFunction.SaveSetup(0, "NTD_Email", NTD_Email.Text, Me.UserInfo.Username)


                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success_info", "removewaiting();notify('success', 'Đã lưu lại thông tin thành công', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "removewaiting", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try

        End Sub
    End Class
End Namespace