Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports DotNetNuke.CHATBOT
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_HocVienEdit
    Partial Class Edit
        Inherits Entities.Modules.PortalModuleBase

#Region "Varial..."
        Dim ObjController As New WorkController
        Dim objHocVien As New DTNGHE_HocVienInfo
#End Region

#Region "Function..."

        Private Sub LoadValues()
            If ItemId.Value = "0" Then
                cmdDelete.Visible = False
                pnlDiem.Visible = False
            Else
                cmdDelete.Visible = True
                pnlDiem.Visible = True

                objHocVien = ObjController.DTNGHE_HocVien_Get(ItemId.Value)
                If IsNothing(objHocVien) = False Then

                    HoTen.Text = objHocVien.HoTen
                    NgaySinh.Text = flReg.ReadDate(objHocVien.NgaySinh)
                    SoDienThoai.Text = objHocVien.SoDienThoai
                    drLopHoc.SelectedValue = objHocVien.MaLopHoc
                    LoadLopHoc()
                    HoTen.Text = objHocVien.HoTen
                    SoCCCD.Text = objHocVien.SoCCCD
                    NgaySinh.Text = flReg.ReadDate(objHocVien.NgaySinh)
                    drGioiTinh.SelectedValue = objHocVien.GioiTinh
                    SoDienThoai.Text = objHocVien.SoDienThoai
                    NgayKhaiGiang.Text = flReg.ReadDate(objHocVien.NgayKhaiGiang)
                    Email.Text = objHocVien.Email
                    DiaChi.Text = objHocVien.DiaChi
                    TrinhDoHocVan.Text = objHocVien.TrinhDoHocVan
                    TrinhDoChuyenMon.Text = objHocVien.TrinhDoChuyenMon
                    drLopHoc.SelectedValue = objHocVien.MaLopHoc
                    drNgheDaoTao.SelectedValue = objHocVien.NgheDaoTaoHV
                    drThoiGianDaoTao.SelectedValue = objHocVien.ThoiGianDaoTaoHV
                    drKetQuaDaoTao.SelectedValue = objHocVien.KetQuaDaoTao
                    GhiChu.Text = objHocVien.GhiChu
                    litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(objHocVien.CreatedDate, True)
                    litUpdate.Text += " - bởi: " & objHocVien.CreatedUser & " - " & flReg.GetUserName(objHocVien.CreatedUser) & "</div>"
                    If objHocVien.UpdatedUser <> "" Then
                        litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(objHocVien.UpdatedDate, True)
                        litUpdate.Text += " - bởi: " & objHocVien.UpdatedUser & " - " & flReg.GetUserName(objHocVien.UpdatedUser) & "</div>"
                    End If

                    Call LoadDiem()
                End If
            End If
        End Sub

        Private Sub LoadDiem()
            If ItemId.Value > 0 Then
                Dim arrDiem As ArrayList = ObjController.DTNGHE_Diem_ListByHocVien(ItemId.Value)
                rptDiem.DataSource = arrDiem
                rptDiem.DataBind()
            End If
        End Sub

        Private Sub BackEnd()
            Dim scs = ViewState("UrlReferrer")
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub

        Private Sub InitControls()
            ItemId.Value = flReg.WriteNumber(Request.Item("itemid"))
            If IsNothing(Request.UrlReferrer) = False Then ViewState("UrlReferrer") = Request.UrlReferrer.ToString & ""

            WebHelper.DDL_BindData(drNgheDaoTao, ObjController.DTNGHE_NgheDaoTao_List(), "Name", "ID", "--- Chọn nghề đào tạo ---", "0", "")
            WebHelper.DDL_BindData(drThoiGianDaoTao, ObjController.DTNGHE_ThoiGianDaoTao_List(), "Name", "ID", "--- Chọn thời gian ---", "0", "")
            WebHelper.DDL_BindData(drLopHoc, ObjController.DTNGHE_LopHoc_List(), "TenLopHoc", "ID", "--- Chọn lớp học ---", "0", "")
            WebHelper.DDL_BindData(drKetQuaDaoTao, ObjController.DTNGHE_KetQuaDaoTao_List(), "Name", "ID", "--- Chọn kết quả ---", "0", "")
        End Sub

#End Region

#Region "Event..."
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Try
                ObjController.DTNGHE_HocVien_Delete(ItemId.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "error", "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết (điểm), không xóa được.', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub LoadLopHoc()
            Dim objLH As DTNGHE_LopHocInfo = ObjController.DTNGHE_LopHoc_Get(drLopHoc.SelectedValue)
            If Not IsNothing(objLH) Then
                drNgheDaoTao.SelectedValue = objLH.NgheDaoTao
                drThoiGianDaoTao.SelectedValue = objLH.ThoiGianDaoTao
                NgayKhaiGiang.Text = flReg.ReadDate(objLH.NgayKhaiGiang)
            End If
        End Sub
        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            Try
                objHocVien = New DTNGHE_HocVienInfo
                objHocVien.HoTen = HoTen.Text
                objHocVien.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                objHocVien.SoDienThoai = SoDienThoai.Text
                objHocVien.MaLopHoc = drLopHoc.SelectedValue
                objHocVien.HoTen = HoTen.Text.Trim()
                objHocVien.SoCCCD = SoCCCD.Text.Trim()
                objHocVien.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                objHocVien.NgayKhaiGiang = flReg.WriteDate(NgayKhaiGiang.Text, False)
                objHocVien.GioiTinh = drGioiTinh.SelectedValue
                objHocVien.SoDienThoai = SoDienThoai.Text.Trim()
                objHocVien.Email = Email.Text.Trim()
                objHocVien.DiaChi = DiaChi.Text.Trim()
                objHocVien.TrinhDoHocVan = TrinhDoHocVan.Text.Trim()
                objHocVien.TrinhDoChuyenMon = TrinhDoChuyenMon.Text.Trim()
                objHocVien.MaLopHoc = drLopHoc.SelectedValue
                objHocVien.NgheDaoTaoHV = flReg.WriteNumber(drNgheDaoTao.SelectedValue)
                objHocVien.ThoiGianDaoTaoHV = flReg.WriteNumber(drThoiGianDaoTao.SelectedValue)
                objHocVien.KetQuaDaoTao = flReg.WriteNumber(drKetQuaDaoTao.SelectedValue)
                objHocVien.GhiChu = GhiChu.Text.Trim()
                objHocVien.CreatedDate = Now
                objHocVien.CreatedUser = Me.UserInfo.Username
                If flReg.WriteNumber(ItemId.Value) > 0 Then
                    objHocVien.ID = ItemId.Value
                    objHocVien.UpdatedUser = Me.UserInfo.Username
                    objHocVien.UpdatedDate = Now
                    ObjController.DTNGHE_HocVien_Update(objHocVien)
                Else
                    objHocVien.UpdatedUser = ""
                    objHocVien.UpdatedDate = flReg.DateNull
                    ItemId.Value = ObjController.DTNGHE_HocVien_Add(objHocVien)
                    pnlDiem.Visible = True
                End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success", "removewaiting();notify('success', 'Đã cập nhật dữ liệu học viên thành công.', 'Thông báo', false);", True)
                Call LoadValues()

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "error", "removewaiting();notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub ResetDiemForm()
            txtMonHoc.Text = ""
            txtDiemSo.Text = ""
            hiddenMaDiem.Value = "0"
            cmdAddDiem.Text = "Thêm điểm"
            cmdCancelEditDiem.Visible = False
        End Sub
        Protected Sub cmdAddDiem_Click(sender As Object, e As EventArgs) Handles cmdAddDiem.Click
            If String.IsNullOrEmpty(txtMonHoc.Text.Trim) Or String.IsNullOrEmpty(txtDiemSo.Text.Trim) Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "missing_info", "removewaiting();notify('info', 'Vui lòng nhập đầy đủ Môn học và Điểm số.', 'Thông báo', false);", True)
                Exit Sub
            End If

            Dim objDiem As New DTNGHE_DiemInfo()
            objDiem.MaHocVien = ItemId.Value
            objDiem.MonHoc = txtMonHoc.Text.Trim
            objDiem.DiemSo = CSng(txtDiemSo.Text.Trim)
            objDiem.CreatedDate = Now
            objDiem.CreatedUser = Me.UserInfo.Username
            objDiem.UpdatedUser = ""
            objDiem.UpdatedDate = flReg.DateNull
            If CInt(hiddenMaDiem.Value) > 0 Then
                objDiem.ID = CInt(hiddenMaDiem.Value)
                ObjController.DTNGHE_Diem_Update(objDiem)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "update_score_success", "removewaiting();notify('success', 'Đã cập nhật điểm thành công.', 'Thông báo', false);", True)
            Else
                ObjController.DTNGHE_Diem_Add(objDiem)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "add_score_success", "removewaiting();notify('success', 'Đã thêm điểm thành công.', 'Thông báo', false);", True)
            End If

            Call ResetDiemForm()
            Call LoadDiem()

            txtMonHoc.Text = ""
            txtDiemSo.Text = ""
            Call LoadDiem()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "add_score_success", "removewaiting();notify('success', 'Đã thêm điểm thành công.', 'Thông báo', false);", True)
        End Sub
        Protected Sub cmdCancelEditDiem_Click(sender As Object, e As EventArgs) Handles cmdCancelEditDiem.Click
            Call ResetDiemForm()
        End Sub
        Protected Sub rptDiem_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptDiem.ItemCommand
            Select Case e.CommandName
                Case "DeleteDiem"
                    Dim maDiemToDelete As Integer = CInt(e.CommandArgument)
                    ObjController.DTNGHE_Diem_Delete(maDiemToDelete)
                    Call ResetDiemForm()
                    Call LoadDiem()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "delete_score_success", "removewaiting();notify('success', 'Đã xóa điểm thành công.', 'Thông báo', false);", True)

                Case "EditDiem"
                    Dim maDiemToEdit As Integer = CInt(e.CommandArgument)
                    Dim objDiemToEdit As DTNGHE_DiemInfo = ObjController.DTNGHE_Diem_Get(maDiemToEdit)

                    If objDiemToEdit IsNot Nothing Then
                        txtMonHoc.Text = objDiemToEdit.MonHoc
                        txtDiemSo.Text = objDiemToEdit.DiemSo.ToString()
                        hiddenMaDiem.Value = maDiemToEdit
                        cmdAddDiem.Text = "Cập nhật điểm"
                        cmdCancelEditDiem.Visible = True
                    End If
            End Select
        End Sub

        Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Private Sub drLopHoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drLopHoc.SelectedIndexChanged
            LoadLopHoc()
        End Sub
#End Region

    End Class

End Namespace