Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules
    Partial Class DocSettings
        Inherits Entities.Modules.PortalModuleBase
		Dim _tabName As String = PortalSettings.ActiveTab.TabName

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			Try
				If Not Page.IsPostBack Then
					DOC_LIST_TITLE.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "DOC_LIST_TITLE", Request.Item("page"))
					Call flFunction.LoadDocGroup_Parent_Null(Me.PortalId, DOC_LIST_GROUP)
					DOC_LIST_GROUP.SelectedValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "DOC_LIST_GROUP", Request.Item("page"))
				End If
			Catch ex As Exception
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyinfo", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
			End Try
		End Sub
		Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack.Click
			Response.Redirect("/" & _tabName & "/view" & Request.Item("page"), True)
		End Sub
		Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
			Try
				flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "DOC_LIST_TITLE", DOC_LIST_TITLE.Text, Request.Item("page"), Me.UserInfo.Username)
				flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "DOC_LIST_GROUP", DOC_LIST_GROUP.SelectedValue, Request.Item("page"), Me.UserInfo.Username)

				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
			Catch ex As Exception
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyinfo", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
			End Try
		End Sub

	End Class
End Namespace

