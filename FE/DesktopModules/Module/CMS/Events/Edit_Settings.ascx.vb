Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules

Namespace DotNetNuke.Modules
    Partial Public Class Edit_Settings
        Inherits ModuleSettingsBase
        Dim objModules As New Entities.Modules.ModuleController
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim ObjController As New CmsController
        Dim strOld, str(), strRole As String
        Dim _tabName As String = PortalSettings.ActiveTab.TabName

        Public Sub LoadRole()
            WF_PUBROLE.DataSource = flDnn.CMS_Roles_Get_By_CMS_SubMod(PortalId, flDic.SubMod_ID(PortalId, Me.PortalSettings.ActiveTab.TabName))
            WF_PUBROLE.DataTextField = "Roles_Name"
            WF_PUBROLE.DataValueField = "Roles_Code"
            WF_PUBROLE.DataBind()
        End Sub
        Private Sub LoadWorkFlow(dr As DropDownList)
            dr.Items.Clear()
            dr.Items.Add(New ListItem("- - - Chọn quy trình - - -", 0))
            arrTemp = ObjController.CMS_News_UserWF_List(PortalId)
            For Each Cr As CMS_News_UserWFInfo In arrTemp
                dr.Items.Add(New ListItem(Cr.TenLuong, Cr.ID))
            Next
        End Sub
        Public Sub LoadPortald()
            WF_VIVN.DataSource = Ultis.AllPortal()
            WF_VIVN.DataTextField = "PortalName"
            WF_VIVN.DataValueField = "PortalId"
            WF_VIVN.DataBind()
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call LoadSettings()
            End If
        End Sub

        Public Overrides Sub LoadSettings()
            Try

                Call LoadWorkFlow(WF_TO1)
                WF_TO1.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TO1", Request.Item("page")))
                WF_TEXT1.Text = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TEXT1", Request.Item("page"))

                Call LoadWorkFlow(WF_TO2)
                WF_TO2.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TO2", Request.Item("page")))
                WF_TEXT2.Text = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TEXT2", Request.Item("page"))

                Call LoadWorkFlow(WF_TO3)
                WF_TO3.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TO3", Request.Item("page")))
                WF_TEXT3.Text = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TEXT3", Request.Item("page"))

                Call LoadWorkFlow(WF_DEFAULT)
                WF_DEFAULT.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_DEFAULT", Request.Item("page")))
                WF_TEXTDF.Text = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TEXTDF", Request.Item("page"))

                Call LoadWorkFlow(WF_PUBNOW)
                WF_PUBNOW.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_PUBNOW", Request.Item("page")))
                WF_TEXTPUBNOW.Text = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_TEXTPUBNOW", Request.Item("page"))

                Call LoadRole()
                strRole = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_PUBROLE", Request.Item("page"))
                str = strRole.Split(",")
                For i As Integer = 0 To str.Length - 1
                    For Each item As ListItem In WF_PUBROLE.Items
                        If str(i) = item.Value Then
                            item.Selected = True
                            Exit For
                        End If
                    Next
                Next

                strOld = flReg.SettingValue(flConnect.CmsConnect(0), _tabName, "WF_VIVN", Request.Item("page"))
                str = strOld.Split(",")
                For i As Integer = 0 To str.Length - 1
                    For Each item As ListItem In WF_VIVN.Items
                        If str(i) = item.Value Then
                            item.Selected = True
                            Exit For
                        End If
                    Next
                Next

                Call LoadPortald()
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
            flCache.RemoveCache("WF_DEFAULT" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXTDF" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PUBNOW" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXTPUBNOW" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TO1" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXT1" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TO2" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXT2" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TO3" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXT3" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_VIVN" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PUBROLE" & "_" & _tabName & "_" & Request.Item("page"))

        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Call RemoveCache()
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_DEFAULT", WF_DEFAULT.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TEXTDF", WF_TEXTDF.Text, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_PUBNOW", WF_PUBNOW.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TEXTPUBNOW", WF_TEXTPUBNOW.Text, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TO1", WF_TO1.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TEXT1", WF_TEXT1.Text, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TO2", WF_TO2.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TEXT2", WF_TEXT2.Text, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TO3", WF_TO3.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_TEXT3", WF_TEXT3.Text, Request.Item("page"), Me.UserInfo.Username)

            strOld = ""
            For Each item As ListItem In WF_VIVN.Items
                If item.Selected Then
                    strOld += item.Value & ","
                End If
            Next
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_VIVN", strOld, Request.Item("page"), Me.UserInfo.Username)

            strRole = ""
            For Each item As ListItem In WF_PUBROLE.Items
                If item.Selected Then
                    strRole += item.Value & ","
                End If
            Next
            flDnn.CMS_Settings_Update(flConnect.CmsConnect(0), _tabName, "WF_PUBROLE", strRole, Request.Item("page"), Me.UserInfo.Username)

            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)

        End Sub
    End Class
End Namespace