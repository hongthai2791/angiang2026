Imports DotNetNuke.EPORTAL
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.CMS

Namespace DesktopModules.DanhMuc.PhongBan
    Public MustInherit Class inc_Workflow
        Inherits Entities.Modules.PortalModuleBase

        Dim ObjController As New CmsController
        Dim arr As New ArrayList
        Dim obj As New CMS_News_UserWFInfo

#Region "Event Handlers"

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

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    pbID.Value = flReg.WriteNumber(Request.Item("itemid"))
                    Dim objInfo As CMS_DepartmentsInfo = ObjController.CMS_Departments_Get(Me.PortalId, pbID.Value)
                    If Not objInfo Is Nothing Then
                        lblPhongBan.Text = objInfo.TenPhongBan
                    End If
                    Call BindLoadPortal()
                    Call BindDdlStatus()
                    Call BindLuong()
                End If
            Catch ex As Exception
                lblPhongBan.Text = ex.Message
            End Try
        End Sub

        Private Sub BindDdlStatus()
            ddlStatus.DataSource = ObjController.CMS_NewsStatus_List(0)
            ddlStatus.DataTextField = "StatusName"
            ddlStatus.DataValueField = "NewsStatusId"
            ddlStatus.DataBind()
        End Sub

        Private Sub BindLuong()
            drgLuong.DataSource = ObjController.CMS_News_UserWF_GetByPhongBanId(0, LoaiWF.TatCa, pbID.Value)
            drgLuong.DataBind()
        End Sub
        Private Sub drgLuong_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles drgLuong.ItemCommand
            ' bind data
            Select Case e.CommandName
                Case "imb_edit"
                    ' bind data vao luoi nguoi dung thuoc phong
                    obj = ObjController.CMS_News_UserWF_Get(0, drgLuong.DataKeys(e.CommandArgument))
                    If IsNothing(obj) = False Then
                        txtTenLuong.Text = obj.TenLuong
                        txtLuongOrder.Text = obj.OrderNumber
                        chkLuongMacDinh.Checked = obj.IsDefault
                        ddlStatus.SelectedValue = obj.TrangThaiDich
                        wid.Value = obj.ID
                    End If
                    ClientAPI.RegisterStartUpScript(Page, "Open_Dialog", "<script>OpenDialog(" & wid.Value & ");</script>")
                Case "imb_delete"
                    ObjController.CMS_News_UserWF_Delete(0, drgLuong.DataKeys.Item(e.CommandArgument).ToString)
                    Call BindLuong()
            End Select

        End Sub
        Private Sub drgLuong_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgLuong.ItemDataBound
            If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then

                Dim DeleteIMG As ImageButton = CType(e.Item.FindControl("imb_delete"), ImageButton)
                DeleteIMG.CommandArgument = e.Item.ItemIndex.ToString()

                DeleteIMG.Attributes.Add("onclick", "javascript:return confirm('Bạn có chắc chắn muốn xóa nội dung này không?');")

                Dim EditIMG As ImageButton = CType(e.Item.FindControl("imb_edit"), ImageButton)
                EditIMG.CommandArgument = e.Item.ItemIndex.ToString()

            End If
        End Sub

        Protected Sub lbtLuongNguoiDung_Click(ByVal sender As Object, ByVal e As EventArgs)
            If wid.Value <> "" Then
                obj = ObjController.CMS_News_UserWF_Get(0, wid.Value)
                obj.NguoiNhan = ""
                obj.IsDefault = chkLuongMacDinh.Checked
                obj.TenLuong = txtTenLuong.Text
                obj.OrderNumber = txtLuongOrder.Text
                obj.PhongBan = pbID.Value
                obj.PositionID = 1
                obj.TrangThaiDich = ddlStatus.SelectedValue
                obj.LoaiWF = 0

                ObjController.CMS_News_UserWF_Update(0, obj)
            Else
                obj = New CMS_News_UserWFInfo
                obj.NguoiNhan = ""
                obj.IsDefault = chkLuongMacDinh.Checked
                obj.TenLuong = txtTenLuong.Text
                obj.OrderNumber = txtLuongOrder.Text
                obj.PhongBan = pbID.Value
                obj.PositionID = 1
                obj.TrangThaiDich = ddlStatus.SelectedValue
                obj.LoaiWF = 0
                ObjController.CMS_News_UserWF_Add(0, obj)
            End If

            Call BindLuong()
            wid.Value = ""
            ClientAPI.RegisterStartUpScript(Page, "CloseDialog", "<script>CloseDialog();</script>")
        End Sub
        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
        End Sub
#End Region


    End Class
End Namespace

