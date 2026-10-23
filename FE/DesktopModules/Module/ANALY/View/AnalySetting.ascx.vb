Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.ANALY
Imports OfficeOpenXml
Imports System.IO

Namespace DotNetNuke.Modules
    Partial Public Class ReportSetting
        Inherits ModuleSettingsBase
        Dim objModules As New Entities.Modules.ModuleController
        Dim str() As String
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Dim settingValue As String
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call InitData()
                Call LoadSettings()
            End If
        End Sub
        Private Sub InitData()
            Call flFunction.LoadGroup(Me.PortalId, Group_ID, 0, 0, "")
            Call flFunction.LoadTargets(Me.PortalId, 0, Targets_ID, Group_ID.SelectedValue)
            Call flFunction.LoadChartType(ChartType_ID, 0)
        End Sub
        Public Overrides Sub LoadSettings()
            Try
                settingValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "ANALY_GETPAGE", Request.Item("page"))
                str = settingValue.Split(";")
                Group_ID.SelectedValue = str(0)

                Call flFunction.LoadTargets(Me.PortalId, flReg.WriteNumber(Request.Item("tp")), Targets_ID, Group_ID.SelectedValue)

                Targets_ID.SelectedValue = str(1)
                ChartType_ID.SelectedValue = str(2)
            Catch exc As Exception
            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & _tabName & "/view/" & Request.Item("page"), True)
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            settingValue = Group_ID.SelectedValue
            settingValue += ";" & Targets_ID.SelectedValue
            settingValue += ";" & ChartType_ID.SelectedValue
            settingValue += ";" & 0
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "ANALY_GETPAGE", settingValue, Request.Item("page"), Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật cấu hình thành công.', 'Thông báo', false);", True)

        End Sub

        Private Sub Group_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Group_ID.SelectedIndexChanged
            Call flFunction.LoadTargets(Me.PortalId, flReg.WriteNumber(Request.Item("tp")), Targets_ID, Group_ID.SelectedValue)
        End Sub
    End Class
End Namespace