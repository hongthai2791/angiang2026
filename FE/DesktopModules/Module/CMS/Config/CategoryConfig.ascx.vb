Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.TinTuc.Configurations
    Partial Class HomeBlockConfig
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim obj As New CMS_SetupsInfo
        Dim arr As New ArrayList
        Dim blockInfo As New CMS_BlockInfo

        Private Sub LoadSettings()
            drlSettings.Items.Clear()
            arr = ObjController.CMS_Block_List_By_Flag(PortalId, ddlBlockFlag.SelectedValue)
            For Each item As CMS_BlockInfo In arr
                drlSettings.Items.Add(New ListItem(item.Block_Name, item.Block_Key))
            Next
        End Sub

        Private Sub LoadBlockFlag()
            ddlBlockFlag.Items.Clear()
            ddlBlockFlag.Items.Add(New ListItem("Website news", BlockFlag.Web_News))
            ddlBlockFlag.Items.Add(New ListItem("Website video", BlockFlag.Web_Video))
            ddlBlockFlag.Items.Add(New ListItem("Website audio", BlockFlag.Web_Audio))
            ddlBlockFlag.Items.Add(New ListItem("Website album", BlockFlag.Web_Album))
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call BindLoadPortal()
                    Call LoadBlockFlag()
                    Call LoadSettings()
                    ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Private Sub BindLoadPortal()
            ddlPortal.DataSource = Ultis.UserPortal(Me.UserInfo.Username)
            ddlPortal.DataTextField = "PortalName"
            ddlPortal.DataValueField = "PortalId"
            ddlPortal.DataBind()
            If Request.Item("pid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("pid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
            _HTTPAlias.Value = flConnect.WebDomain(ddlPortal.SelectedValue)
        End Sub
        Protected Sub lbtUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtUpdate.Click
            Try
                flCache.RemoveCache("SetupValue" & PortalId & drlSettings.SelectedValue)
                flFunction.SaveSetup(ddlPortal.SelectedValue, drlSettings.SelectedValue, hdf_Value.Value, Me.UserInfo.Username)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Cập nhật " & drlSettings.SelectedItem.Text & " thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Protected Sub lbtCancelTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtCancelTop.Click
            Try
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view"), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue)
        End Sub

        Private Sub ddlBlockFlag_SelectedIndexChanged() Handles ddlBlockFlag.SelectedIndexChanged
            Call LoadSettings()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changevalue", "changevalue(); settingval();", True)
        End Sub
    End Class
End Namespace