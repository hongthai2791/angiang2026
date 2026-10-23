Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules

Namespace DotNetNuke.Modules
    Partial Public Class Edit_Settings
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
                WF_EMAIL_LH.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_EMAIL_LH", "lien-he")

            Catch exc As Exception
            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            If Request.Item("edit") & "" <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("page"), True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
            End If
        End Sub
        Private Sub RemoveCache()
            flCache.RemoveCache("WF_EMAIL_LH" & "_" & _tabName & "_lien-he")
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Call RemoveCache()
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_EMAIL_LH", WF_EMAIL_LH.Text, "lien-he", Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)

        End Sub
    End Class
End Namespace