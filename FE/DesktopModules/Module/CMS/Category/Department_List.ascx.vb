Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports System.Threading

Namespace DesktopModules.DanhMuc.PhongBan
    Public MustInherit Class inc_list
        Inherits Entities.Modules.PortalModuleBase
        Dim cbSub, cbGroup As CheckBox
        Public isLang As String = Thread.CurrentThread.CurrentCulture.Name
        Dim EditIMG As ImageButton
        Dim ObjController As New CmsController
        Dim arr As New ArrayList

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Call BindLoadPortal()
                Call LoadValue()
            End If
        End Sub
        Private Sub LoadValue()
            arr = ObjController.CMS_Departments_List(ddlPortal.SelectedValue)
            drgViewData.DataSource = arr
            drgViewData.DataBind()
        End Sub
        Protected Sub drgViewData_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles drgViewData.ItemCommand
            Select Case e.CommandName
                Case "imb_edit"
                    Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue & "/itemid/" & drgViewData.DataKeys.Item(e.CommandArgument).ToString, True)
            End Select
        End Sub

        Protected Sub drgViewData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgViewData.ItemDataBound
            If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then
                EditIMG = CType(e.Item.FindControl("imb_edit"), ImageButton)
                EditIMG.CommandArgument = e.Item.ItemIndex.ToString()
            End If
        End Sub

        Protected Sub lbtAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
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
        End Sub

        Protected Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            If ddlPortal.SelectedValue = Me.PortalId Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view"), True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
            End If
        End Sub
    End Class
End Namespace
