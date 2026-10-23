Imports DotNetNuke.EPORTAL
Namespace DotNetNuke.CMS
    Public MustInherit Class Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim objInfo As New CMS_ContactInfo
        Dim objController As New CmsController


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
        End Sub
        Private Sub LoadValues()
            ID.Value = Request.Item("itemid")
            objInfo = objController.CMS_Contact_Get(ddlPortal.SelectedValue, ID.Value)
            If IsNothing(objInfo) = False Then
                FullName.Text = objInfo.FullName
                ddlPortal.SelectedValue = objInfo.PortalId
                Email.Text = objInfo.Email
                Tel.Text = objInfo.Tel
                Contents.Text = objInfo.Contents
                litUpdate.Text = "<div class=""cmsUpdate"">Ngày gửi liên hệ: " & flReg.ReadDate(objInfo.CreatedDate) & "</div>"
            End If
        End Sub
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
                    Call BindLoadPortal()
                    Call LoadValues()
                    If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Xuat ban") = True Or Me.UserInfo.Username = "host" Then
                        cmdDel.Visible = True
                    End If
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view"), True)
        End Sub
        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            objController.CMS_Contact_Update_Status(Me.PortalId, ID.Value, False)
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view"), True)
        End Sub
    End Class

End Namespace