Imports DotNetNuke.EPORTAL
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.CMS

Namespace DesktopModules.DanhMuc.PhongBan
    Public MustInherit Class inc_Edit
        Inherits Entities.Modules.PortalModuleBase

        Dim objPhongBan As CMS_DepartmentsInfo
        Dim arrPhongBan As New ArrayList
        Dim itemToRemove As ListItem
        Dim ObjController As New CmsController
        Dim uinfo As New UserInfo

        Private Sub LoadValue()
            ItemID.Value = Request.Item("itemid") & ""
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
            If IsNothing(Request.UrlReferrer) = False Then ViewState("UrlReferrer") = Request.UrlReferrer.ToString & ""

            If ItemID.Value = "" Then
                txtOrder.Text = Integer.Parse(Request.Item("c"))
            Else
                Dim obj As CMS_DMNhuanButInfo = ObjController.CMS_DMNhuanBut_Get(ddlPortal.SelectedValue, Integer.Parse(ItemID.Value))
                If Not IsNothing(obj) Then
                    txtMaDM.Text = obj.MaDM
                    drType.SelectedValue = obj.Type
                    txtHeSo.Text = obj.HeSo
                    txtDonGia.Text = obj.DonGia
                    drMonth.SelectedValue = obj.Month
                    drYear.SelectedValue = obj.Year
                    txtMoTa.Text = obj.Description
                    txtOrder.Text = obj.Orders
                    ckActive.Checked = obj.Active
                End If
            End If

        End Sub
        Private Sub LoadLoaiDinhMuc()
            drType.Items.Clear()
            drType.Items.Add(New ListItem("Định mức tin", 1))
            drType.Items.Add(New ListItem("Định mức ảnh", 2))
        End Sub

        Private Sub LoadMonth()
            drMonth.Items.Clear()
            For i As Integer = 1 To 12
                drMonth.Items.Add(New ListItem("Tháng " + i.ToString(), i))
            Next
            drMonth.SelectedValue = Now.Month
        End Sub
        Private Sub LoadYear()
            drYear.Items.Clear()
            For i As Integer = 2010 To Now.Year + 1
                drYear.Items.Add(New ListItem("Năm " + i.ToString(), i))
            Next
            drYear.SelectedValue = Now.Year

        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    cmdDelete.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
                    Call BindLoadPortal()
                    Call LoadLoaiDinhMuc()
                    Call LoadMonth()
                    Call LoadYear()
                    Call LoadValue()
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
        End Sub
        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            If ItemID.Value <> "" Then
                ObjController.CMS_DMNhuanBut_Delete(ddlPortal.SelectedValue, ItemID.Value)
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), False)
            End If
        End Sub
        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            Dim obj As New CMS_DMNhuanButInfo()
            obj.MaDM = txtMaDM.Text
            obj.Type = drType.SelectedValue
            obj.HeSo = flReg.WriteNumber(txtHeSo.Text)
            obj.DonGia = flReg.WriteNumber(txtDonGia.Text)
            obj.Month = drMonth.SelectedValue
            obj.Year = drYear.SelectedValue
            obj.Description = txtMoTa.Text
            obj.Orders = txtOrder.Text
            obj.Active = ckActive.Checked

            If ItemID.Value <> "" Then
                obj.ID = ItemID.Value
                obj.CreateUser = Me.UserInfo.Username
                obj.CreateDate = Now
                obj.UpdateUser = Me.UserInfo.Username
                obj.UpdateDate = Now
                ObjController.CMS_DMNhuanBut_Update(ddlPortal.SelectedValue, obj)
            Else
                obj.CreateUser = Me.UserInfo.Username
                obj.CreateDate = Now
                obj.UpdateUser = ""
                obj.UpdateDate = Now
                ObjController.CMS_DMNhuanBut_Add(ddlPortal.SelectedValue, obj)
            End If

            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), False)
        End Sub

        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), False)
        End Sub
    End Class
End Namespace
