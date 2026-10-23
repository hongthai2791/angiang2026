Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Modules

Namespace Modules.ExSetting
	Partial Public Class View
		Inherits ModuleSettingsBase
		Dim objModules As New Entities.Modules.ModuleController
		Dim arrTemp, arrTemp1 As New ArrayList
		Dim strOld, str(), strRole As String
		Dim _tabName As String = PortalSettings.ActiveTab.TabName

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			If Not IsPostBack Then
				Call LoadSettings()
			End If
		End Sub

		Public Overrides Sub LoadSettings()
			Try
				Call ANALY.flFunction.LoadGroup_Parent_Null(Me.PortalId, Group_ID, 0, "--Chọn nhóm--", ANALY.GroupType.DLTongHop)
				Group_ID.SelectedValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "Group_ID", Request.Item("page"))
            Catch exc As Exception
            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
        End Sub

        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "Group_ID", Group_ID.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)

		End Sub
	End Class
End Namespace