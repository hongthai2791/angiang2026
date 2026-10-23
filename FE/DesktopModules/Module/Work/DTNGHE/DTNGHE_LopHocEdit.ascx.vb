Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports DotNetNuke.CHATBOT
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_LopHocEdit
    Partial Class Edit
        Inherits Entities.Modules.PortalModuleBase

#Region "Varial..."
        Dim ObjController As New WorkController
        Dim obj As New DTNGHE_LopHocInfo
        Dim strURL As String
        Dim liter As Literal
        Dim chkBox As CheckBox
#End Region

#Region "Function..."

        Private Sub LoadValues()
            If ItemId.Value = "0" Then
                cmdDelete.Visible = False
            Else
                cmdDelete.Visible = True
                obj = ObjController.DTNGHE_LopHoc_Get(ItemId.Value)
                If IsNothing(obj) = False Then
                    TenLopHoc.Text = obj.TenLopHoc
                    drNgheDaoTao.SelectedValue = obj.NgheDaoTao
                    NgayKhaiGiang.Text = flReg.ReadDate(obj.NgayKhaiGiang)
                    NgayKetThuc.Text = flReg.ReadDate(obj.NgayKetThuc)
                    TenGiangVien.Text = obj.TenGiangVien
                    ThongTinLienHeGV.Text = obj.ThongTinLienHeGV
                    DonViChuTri.Text = obj.DonViChuTri
                    DiaDiemHoc.Text = obj.DiaDiemHoc
                    drThoiGianDaoTao.SelectedValue = obj.ThoiGianDaoTao
                    KinhPhi.Text = flReg.WriteNumber(obj.KinhPhi.ToString())
                    SoLuongToiDa.Text = flReg.WriteNumber(obj.SoLuongToiDa.ToString())
                    drTrangThai.SelectedValue = obj.TrangThai.ToString()
                    GhiChu.Text = obj.GhiChu
                    litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate, True)
                    litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                    If obj.UpdatedUser <> "" Then
                        litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate, True)
                        litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                    End If
                End If
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
                ObjController.DTNGHE_LopHoc_Delete(ItemId.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "error", "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết, không xóa được.', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            Try
                If flReg.WriteDate(NgayKetThuc.Text, False) < flReg.WriteDate(NgayKhaiGiang.Text, False) Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Ngày kết thúc không được nhỏ hơn ngày khai giảng!', 'Thông báo', false);", True)
                    Exit Sub
                End If

                obj = New DTNGHE_LopHocInfo
                obj.TenLopHoc = TenLopHoc.Text
                obj.NgheDaoTao = CInt(drNgheDaoTao.SelectedValue)
                obj.NgayKhaiGiang = flReg.WriteDate(NgayKhaiGiang.Text, False)
                obj.NgayKetThuc = flReg.WriteDate(NgayKetThuc.Text, False)

                obj.TenGiangVien = TenGiangVien.Text.Trim()
                obj.ThongTinLienHeGV = ThongTinLienHeGV.Text.Trim()
                obj.DonViChuTri = DonViChuTri.Text.Trim()
                obj.DiaDiemHoc = DiaDiemHoc.Text.Trim()
                obj.ThoiGianDaoTao = flReg.WriteNumber(drThoiGianDaoTao.SelectedValue)
                obj.KinhPhi = If(IsNumeric(KinhPhi.Text), Convert.ToDecimal(KinhPhi.Text), 0)
                obj.SoLuongToiDa = If(IsNumeric(SoLuongToiDa.Text), Convert.ToInt32(SoLuongToiDa.Text), 0)
                obj.TrangThai = Convert.ToInt32(drTrangThai.SelectedValue)
                obj.GhiChu = GhiChu.Text.Trim()
                If flReg.WriteNumber(ItemId.Value) > 0 Then
                    obj.ID = ItemId.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = Me.UserInfo.Username
                    obj.UpdatedDate = Now
                    ObjController.DTNGHE_LopHoc_Update(obj)
                Else
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username
                    obj.UpdatedUser = ""
                    obj.UpdatedDate = Now
                    ItemId.Value = ObjController.DTNGHE_LopHoc_Add(obj)
                End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success", "removewaiting();notify('success', 'Đã cập nhật dữ liệu thành công.', 'Thông báo', false);", True)
                Call LoadValues()

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "error", "removewaiting();notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
#End Region

    End Class

End Namespace