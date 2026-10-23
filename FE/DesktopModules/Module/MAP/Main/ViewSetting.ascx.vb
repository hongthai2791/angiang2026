Imports DotNetNuke.EPORTAL
Imports DotNetNuke.MAP
Imports DotNetNuke.Entities.Modules

Namespace Modules.ExSetting
	Partial Public Class View
		Inherits ModuleSettingsBase
		Dim objModules As New Entities.Modules.ModuleController
		Dim arrTemp, arrTemp1 As New ArrayList
		Dim strOld, str(), strRole As String
		Dim _tabName As String = PortalSettings.ActiveTab.TabName

        Private Sub LoadBoCuc()
            drBoCuc.Items.Clear()
            drBoCuc.DataSource = New MapController().VungBanDo_List(PortalId)
            drBoCuc.DataTextField = "TenVungBanDo"
            drBoCuc.DataValueField = "Id"
            drBoCuc.DataBind()
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call LoadSettings()
            End If
        End Sub

        Public Overrides Sub LoadSettings()
            Try
                Call LoadBoCuc()
                drBoCuc.SelectedValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "MAP_BOCUCMACDINH", Request.Item("page"))
            Catch exc As Exception
            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
        End Sub

        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "MAP_BOCUCMACDINH", drBoCuc.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)

        End Sub
	End Class
End Namespace