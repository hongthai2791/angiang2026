Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.INSU
Imports DotNetNuke.EPORTAL

Namespace Modules.TVGT
    Partial Class Edit
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim arr As New ArrayList
        Dim obj As EXE_AdvisoryInfo
        Dim lit As Literal
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Public _pid As Integer
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            Call flDic.LoadRegional_Parent_Null(0, TT_TinhTP)
            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            Call flDic.LoadRegional_Parent_Null(0, GT_TinhTP)

            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadReligion(0, TonGiao)
            Call flDic.LoadLanguage(0, NgoaiNgu)
            Call flDic.LoadPlace(0, NoiCap)
            Call flFunction.LoadTechnology(0, TinHoc)
            Call flFunction.LoadTechnical(0, ChuyenMonKT)
            Call flFunction.LoadLeaving(0, LyDoNghi)
            Call flFunction.LoadSkill(0, KyNangNghe)
            Call flFunction.LoadLocation(0, GT_ViTri)
            Call flFunction.LoadWage(0, GT_MucLuong)
            Call flFunction.LoadComType(0, GT_LoaiHinh)
            Call flFunction.LoadRecruitment(0, GT_CongViec)
            Call flFunction.LoadBanking(0, NganHang, "- - - Chọn ngân hàng - - -")
            Call flFunction.LoadGioiTinh(GioiTinh)
            ItemID.Value = Request.Item("itemid")
            _pid = flReg.WriteNumber(Request.Item("pid"))
        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_Advisory_Get(_pid, ItemID.Value)
            If IsNothing(obj) = False Then
                drPortal.SelectedValue = obj.PortalID
                NoCode.Text = "<span class='hdh-span'>Mã HS: </span><span class='apid-span'>" & obj.NoCode & "</span>"

                HoTen.Text = flReg.RemoveScript(obj.HoTen, False)
                NgaySinh.Text = flReg.ReadDate(obj.NgaySinh, False)
                GioiTinh.SelectedValue = obj.GioiTinh
                SoCMND.Text = flReg.RemoveScript(obj.SoCMND, False)
                NgayCap.Text = flReg.ReadDate(obj.NgayCap, False)
                NoiCap.Text = flReg.RemoveScript(obj.NoiCap, False)
                SoBHXH.Text = flReg.RemoveScript(obj.SoBHXH, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                DienThoai.Text = flReg.RemoveScript(obj.DienThoai, False)
                DanToc.SelectedValue = obj.DanToc
                TonGiao.SelectedValue = obj.TonGiao
                SoTaiKhoan.Text = flReg.RemoveScript(obj.SoTaiKhoan, False)
                NganHang.SelectedValue = obj.NganHang
                ChiNhanhNH.SelectedValue = obj.ChiNhanhNH
                TT_TinhTP.SelectedValue = obj.TT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                TT_QuanHuyen.SelectedValue = obj.TT_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, TT_XaPhuong, TT_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                TT_XaPhuong.SelectedValue = obj.TT_XaPhuong

                TT_DuongPho.Text = flReg.RemoveScript(obj.TT_DuongPho, False)
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong

                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)

                SucKhoe.Text = flReg.RemoveScript(obj.SucKhoe, False)
                ChieuCao.Text = flReg.RemoveScript(obj.ChieuCao, False)
                CanNang.Text = flReg.RemoveScript(obj.CanNang, False)
                NgoaiNgu.SelectedValue = obj.NgoaiNgu
                GiaoDucPT.Text = flReg.RemoveScript(obj.GiaoDucPT, False)
                TinHoc.SelectedValue = obj.TinHoc
                ChuyenMonKT.SelectedValue = obj.ChuyenMonKT
                MucLuong.Text = flReg.RemoveScript(obj.MucLuong, False)
                LyDoNghi.SelectedValue = obj.LyDoNghi
                DaTimViecTai.Text = flReg.RemoveScript(obj.DaTimViecTai, False)
                KyNangNghe.SelectedValue = obj.KyNangNghe
                KhaNangNoiTroi.Text = flReg.RemoveScript(obj.KhaNangNoiTroi, False)
                TuVan_ChinhSach.Checked = obj.TuVan_ChinhSach
                TuVan_ViecLam.Checked = obj.TuVan_ViecLam
                TuVan_BHTN.Checked = obj.TuVan_BHTN
                TuVan_Khac.Checked = obj.TuVan_Khac
                GT_ViTri.SelectedValue = obj.GT_ViTri
                GT_MucLuong.SelectedValue = obj.GT_MucLuong
                GT_CongViec.SelectedValue = obj.GT_CongViec
                GT_TinhTP.SelectedValue = obj.GT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, GT_QuanHuyen, GT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                GT_QuanHuyen.SelectedValue = obj.GT_QuanHuyen

                GT_LoaiHinh.SelectedValue = obj.GT_LoaiHinh
                GT_DieuKien.Text = flReg.RemoveScript(obj.GT_DieuKien, False)
                GT_Khac.Text = flReg.RemoveScript(obj.GT_Khac, False)

                If obj.TrangThai <> TrangThaiHS.DaNop Then
                    cmdActive.Visible = False
                    cmdReturn.Visible = False
                End If
            End If
            ViewState("backUrl") = "/" & _tabName & "/view/" & Request.Item("edit") & "/pid/" & drPortal.SelectedValue

            arr = objController.EXE_AdvisoryS_Get_By_EXE_Advisory(Me.PortalId, ItemID.Value)
            grdAds.DataSource = arr
            grdAds.PageSize = arr.Count + 1
            grdAds.DataKeyField = "AdvisoryS_ID"
            grdAds.DataBind()

            arr = objController.EXE_AdvisoryC_Get_By_EXE_Advisory(Me.PortalId, ItemID.Value)
            grdAdc.DataSource = arr
            grdAdc.PageSize = arr.Count + 1
            grdAdc.DataKeyField = "AdvisoryC_ID"
            grdAdc.DataBind()
        End Sub

        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Call InnitController()
                Call LoadValue()
            End If
        End Sub

        Private Sub grdAds_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdAds.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("IsOrder")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            lit = e.Item.FindControl("Specialized")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "Specialized")

            lit = e.Item.FindControl("LevelName")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "LevelName")

        End Sub
        Private Sub grdAdc_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdAdc.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("IsOrder")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            lit = e.Item.FindControl("Company")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "Company")

            lit = e.Item.FindControl("TimeWork")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "TimeWork")

            lit = e.Item.FindControl("Location")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "Location")

        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                objController.EXE_Advisory_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.TiepNhan, Now, Me.UserInfo.Username, "")
                objController.EXE_Advisory_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.ChuyenXuLy, Now, Me.UserInfo.Username, "")

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã tiếp nhận và chuyển xử lý hồ sơ thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace

