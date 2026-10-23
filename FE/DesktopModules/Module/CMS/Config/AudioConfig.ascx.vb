Imports DotNetNuke.EPORTAL
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.CMS

Namespace DesktopModules.TinTuc.Configurations
    Partial Class AudioConfig
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim arr As New ArrayList

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call BindLoadPortal()
                    If Not Request.UrlReferrer Is Nothing Then
                        If Request.UrlReferrer.AbsoluteUri = Request.Url.AbsoluteUri Then
                            ViewState("UrlReferrer") = ""
                        Else
                            ViewState("UrlReferrer") = Convert.ToString(Request.UrlReferrer)
                        End If
                    Else
                        ViewState("UrlReferrer") = ""
                    End If
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

        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            Response.Redirect("/administration/news-management/news-home/pid/" & ddlPortal.SelectedValue)
        End Sub
        Protected Sub lbtUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtUpdate.Click
            Try
                PortalController.UpdatePortalSetting(Convert.ToInt32(ddlPortal.SelectedValue), drlSettings.SelectedValue, hdf_Value.Value, True)
                PortalController.UpdatePortalSetting(Convert.ToInt32(ddlPortal.SelectedValue), drlSettings.SelectedValue & "_ckHand", ckHand.Checked.ToString, True)

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Cập nhật " & drlSettings.SelectedItem.Text & " thành công.', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Protected Sub lbtCancelTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtCancelTop.Click
            Try
                Response.Redirect("/administration/audio-management", True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

    End Class
End Namespace

