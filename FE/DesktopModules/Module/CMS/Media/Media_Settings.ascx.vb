Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Security.Roles

Namespace DotNetNuke.Modules
    Partial Public Class Media_Settings
        Inherits ModuleSettingsBase
        Dim objModules As New Entities.Modules.ModuleController
        Dim ObjController As New CmsController
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim _tabName As String = PortalSettings.ActiveTab.TabName
        Dim strOld, strRole, str() As String
        Private Sub LoadWorkFlow(dr As DropDownList)
            dr.Items.Clear()
            dr.Items.Add(New ListItem("- - - Chọn quy trình - - -", 0))
            arrTemp = ObjController.CMS_News_UserWF_List(PortalId)
            For Each Cr As CMS_News_UserWFInfo In arrTemp
                dr.Items.Add(New ListItem(Cr.TenLuong, Cr.ID))
            Next
        End Sub
        Private Sub LoadWfType()
            WF_TYPE.Items.Clear()
            WF_TYPE.Items.Add(New ListItem("- - - Chọn kiểu dữ liệu - - -", 0))
            WF_TYPE.Items.Add(New ListItem("Dữ liệu video", mediaType.Video))
            WF_TYPE.Items.Add(New ListItem("Dữ liệu audio", mediaType.Audio))
        End Sub
        Public Sub LoadRole()
            WF_ROLE.DataSource = flDnn.CMS_Roles_Get_By_CMS_SubMod(PortalId, flDic.SubMod_ID(PortalId, Me.PortalSettings.ActiveTab.TabName))
            WF_ROLE.DataTextField = "Roles_Name"
            WF_ROLE.DataValueField = "Roles_Code"
            WF_ROLE.DataBind()
        End Sub
        Private Sub LoadWF_PAGE(dr As DropDownList)
            dr.Items.Clear()
            dr.Items.Add(New ListItem("- - - Chọn trang - - -", "0"))
            arrTemp = flDnn.CMS_Module_List_By_Host(flConnect.DmConnect, _tabName, flDic.Module_Parent(0, _tabName, Request.Item("page")))
            For Each Ci As CMS_ModuleInfo In arrTemp
                dr.Items.Add(New ListItem(Ci.ModuleName, flReg.Decrypt("1", Ci.ModuleSrc)))
            Next
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Call LoadSettings()
            End If
        End Sub

        Public Overrides Sub LoadSettings()
            Try
                Call LoadWfType()
                WF_TYPE.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TYPE", Request.Item("page")))

                Call LoadRole()
                strRole = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_ROLE", Request.Item("page"))
                str = strRole.Split(",")
                For i As Integer = 0 To str.Length - 1
                    For Each item As ListItem In WF_ROLE.Items
                        If str(i) = item.Value Then
                            item.Selected = True
                            Exit For
                        End If
                    Next
                Next
                Call LoadWorkFlow(WF_FROM)
                WF_FROM.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_FROM", Request.Item("page")))

                Call LoadWorkFlow(WF_RETURN)
                WF_RETURN.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_RETURN", Request.Item("page")))

                Call LoadWorkFlow(WF_TO)
                WF_TO.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TO", Request.Item("page")))

                Call LoadWorkFlow(WF_BACK1)
                WF_BACK1.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK1", Request.Item("page")))
                WF_BACK_TEXT1.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT1", Request.Item("page"))

                Call LoadWorkFlow(WF_BACK2)
                WF_BACK2.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK2", Request.Item("page")))
                WF_BACK_TEXT2.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT2", Request.Item("page"))

                Call LoadWorkFlow(WF_BACK3)
                WF_BACK3.SelectedValue = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK3", Request.Item("page")))
                WF_BACK_TEXT3.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT3", Request.Item("page"))

                WF_TEXT.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXT", Request.Item("page"))
                WF_PAGETEXT.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PAGETEXT", Request.Item("page"))
                WF_PAGENEXTTEXT.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PAGENEXTTEXT", Request.Item("page"))

                Call LoadWF_PAGE(WF_PAGE)
                WF_PAGE.SelectedValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PAGE", Request.Item("page"))

                Call LoadWF_PAGE(WF_PAGENEXT)
                WF_PAGENEXT.SelectedValue = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PAGENEXT", Request.Item("page"))

                WF_TITLE.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TITLE", Request.Item("page"))
                If flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_NEW", Request.Item("page")) & "" = "True" Then WF_NEW.Checked = True
                If flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBLIC", Request.Item("page")) & "" = "True" Then WF_PUBLIC.Checked = True
                If flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_STOP", Request.Item("page")) & "" = "True" Then WF_STOP.Checked = True

            Catch exc As Exception
            End Try
        End Sub

        Protected Sub WF_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WF_TYPE.SelectedIndexChanged
            Call LoadWF_PAGE(WF_PAGE)

            Call LoadWF_PAGE(WF_PAGENEXT)
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
        End Sub
        Private Sub RemoveCache()
            flCache.RemoveCache("WF_FROM" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_RETURN" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TO" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK1" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK2" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK3" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PAGE" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_NEW" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK_TEXT1" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK_TEXT2" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_BACK_TEXT3" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TEXT" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PUBLIC" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_STOP" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PAGENEXT" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_PAGENEXTTEXT" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TITLE" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_TYPE" & "_" & _tabName & "_" & Request.Item("page"))
            flCache.RemoveCache("WF_ROLE" & "_" & _tabName & "_" & Request.Item("page"))
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Call RemoveCache()
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_FROM", WF_FROM.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_RETURN", WF_RETURN.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_TO", WF_TO.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK1", WF_BACK1.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK2", WF_BACK2.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK3", WF_BACK3.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_PAGE", WF_PAGE.SelectedValue, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_NEW", WF_NEW.Checked, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK_TEXT1", WF_BACK_TEXT1.Text, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK_TEXT2", WF_BACK_TEXT2.Text, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_BACK_TEXT3", WF_BACK_TEXT3.Text, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_TEXT", WF_TEXT.Text, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_PUBLIC", WF_PUBLIC.Checked, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_STOP", WF_STOP.Checked, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_PAGENEXT", WF_PAGENEXT.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_PAGENEXTTEXT", WF_PAGENEXTTEXT.Text, Request.Item("page"), Me.UserInfo.Username)
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_TITLE", WF_TITLE.Text, Request.Item("page"), Me.UserInfo.Username)

            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_TYPE", WF_TYPE.SelectedValue, Request.Item("page"), Me.UserInfo.Username)
            strRole = ""
            For Each item As ListItem In WF_ROLE.Items
                If item.Selected Then
                    strRole += item.Value & ","
                End If
            Next
            flDnn.CMS_Settings_Update(flConnect.DmConnect, _tabName, "WF_ROLE", strRole, Request.Item("page"), Me.UserInfo.Username)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
        End Sub
    End Class
End Namespace