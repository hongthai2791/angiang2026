Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.ANALY
Imports OfficeOpenXml
Imports System.IO

Namespace DotNetNuke.Modules
    Partial Public Class ReportSetting
        Inherits ModuleSettingsBase
        Dim objModules As New Entities.Modules.ModuleController
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim strOld, str(), strRole As String
        Dim _tabName As String = PortalSettings.ActiveTab.TabName
        Dim settingValue As String
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call InitData()
                Call LoadSettings()
            End If
        End Sub

        Private Sub InitData()
            Call flFunction.LoadGroup(Me.PortalId, Group_ID, 0, 0, "")
            Call flFunction.LoadGroup(Me.PortalId, Group_ID2, 0, 0, "")
            Call flFunction.LoadTargets(Me.PortalId, 0, Targets_ID, Group_ID.SelectedValue)
            Call flFunction.LoadTargets(Me.PortalId, 0, Targets_ID2, Group_ID2.SelectedValue)
            Call flFunction.LoadChartType(ChartType_ID, 0)
        End Sub
        Public Overrides Sub LoadSettings()
            Try
                flFunction.LoadTargets(Me.PortalId, flReg.WriteNumber(Request.Item("tp")), Targets_ID, Group_ID.SelectedValue)
                flFunction.LoadTargets(Me.PortalId, flReg.WriteNumber(Request.Item("tp")), Targets_ID2, Group_ID2.SelectedValue)
                settingValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "ANALY_GETPAGE", Request.Item("page"))
                str = settingValue.Split(";")
                Group_ID.SelectedValue = str(0)
                Call flFunction.LoadTargets(Me.PortalId, flReg.WriteNumber(Request.Item("tp")), Targets_ID, Group_ID.SelectedValue)
                Targets_ID.SelectedValue = str(1)
                Targets_ID2.SelectedValue = str(2)
                Targets_ID2.SelectedValue = str(3)
                ChartType_ID.SelectedValue = str(4)
            Catch exc As Exception
            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
        End Sub

        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            settingValue = Group_ID.SelectedValue
            settingValue += ";" & Targets_ID.SelectedValue
            settingValue += ";" & Group_ID2.SelectedValue
            settingValue += ";" & Targets_ID2.SelectedValue
            settingValue += ";" & ChartType_ID.SelectedValue
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "ANALY_GETPAGE", settingValue, Request.Item("page"), Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật cấu hình thành công.', 'Thông báo', false);", True)
            flCache.RemoveCache("ANALY_GETPAGE" & "_" & _tabName & "_" & Request.Item("page"))
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Group_ID.SelectedIndexChanged
            LoadSettings()
        End Sub
    End Class
End Namespace