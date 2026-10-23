Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace Modules.KBVL
    Partial Class Edit
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_NotificationInfo
        Dim tbox As Literal, arr As New ArrayList
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Public _pid As Integer
        Dim linkTKVL As String = ""
        Private Sub LoadValue()
            obj = objController.EXE_Notification_Get(_pid, ItemID.Value)
            If IsNothing(obj) = False Then
                drPortal.SelectedValue = obj.PortalID
                NoCode.Text = "<span class='hdh-span'>Mã HS: </span><span class='apid-span'>" & obj.NoCode & "</span>"

                ThangHuong.Text = obj.ThangHuong
                HoTen.Text = flReg.RemoveScript(obj.HoTen, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                NgaySinh.Text = flReg.ReadDate(obj.NgaySinh, False)
                GioiTinh.SelectedValue = obj.GioiTinh
                SoCMND.Text = flReg.RemoveScript(obj.SoCMND, False)
                NgayCap.Text = flReg.ReadDate(obj.NgayCap, False)
                NoiCap.Text = flReg.RemoveScript(obj.NoiCap, False)
                DienThoai.Text = flReg.RemoveScript(obj.DienThoai, False)
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong

                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)
                QD_So.Text = flReg.RemoveScript(obj.QD_So, False)
                QD_Ngay.Text = flReg.ReadDate(obj.QD_Ngay, False)
                QD_TuNgay.Text = flReg.ReadDate(obj.QD_TuNgay, False)
                QD_DenNgay.Text = flReg.ReadDate(obj.QD_DenNgay, False)
                QD_ThangHuong.Text = obj.QD_ThangHuong
                QD_TinhTP.SelectedValue = obj.QD_TinhTP
                TinhTrang.Checked = obj.TinhTrang
                NeuCoVL.Text = flReg.RemoveScript(obj.NeuCoVL, False)
                TT_Khac.Text = flReg.RemoveScript(obj.TT_Khac, False)

                If obj.TrangThai <> TrangThaiHS.DaNop Then
                    cmdActive.Visible = False
                    cmdReturn.Visible = False
                End If
            End If
            arr = objController.EXE_FileAttch_List_By_IdKey(_pid, ItemID.Value)
            For Each cr As EXE_FileAttchInfo In arr
                littkvl.Text += "<a class=""aedit"" href=""" & cr.FilePaths & """ title=""Xem chi tiết file""><img src=""/image/images/view.png?w=20"" alt=""edit"" />&nbsp;" & cr.FileName & "</a>"
            Next
            ViewState("backUrl") = "/" & _tabName & "/view/" & Request.Item("edit") & "/pid/" & drPortal.SelectedValue
            arr = objController.EXE_NotificationD_Get_By_EXE_Notification(Me.PortalId, ItemID.Value)
            grdData.DataSource = arr
            grdData.PageSize = arr.Count + 1
            grdData.DataKeyField = "NotificationD_ID"
            grdData.DataBind()
        End Sub
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            Call flDic.LoadRegional_Parent_Null(0, QD_TinhTP)
            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flDic.LoadPlace(0, NoiCap)
            ItemID.Value = Request.Item("itemid")
            _pid = flReg.WriteNumber(Request.Item("pid"))
        End Sub
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InnitController()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            tbox = e.Item.FindControl("IsOrder")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            tbox = e.Item.FindControl("KetQua")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "KetQua")

            tbox = e.Item.FindControl("ViTriDuTuyen")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "ViTriDuTuyen")

            tbox = e.Item.FindControl("NguoiLienHe")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "NguoiLienHe")

            tbox = e.Item.FindControl("DiaChi")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "DiaChi")

            tbox = e.Item.FindControl("TenDonVi")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "TenDonVi")
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                objController.EXE_Notification_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.TiepNhan, Now, Me.UserInfo.Username, "")
                objController.EXE_Notification_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.ChuyenXuLy, Now, Me.UserInfo.Username, "")

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã tiếp nhận và chuyển xử lý hồ sơ thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace

