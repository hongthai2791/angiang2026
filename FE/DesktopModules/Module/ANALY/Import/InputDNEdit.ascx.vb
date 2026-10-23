Imports DotNetNuke.EPORTAL
Imports DotNetNuke.ANALY

Namespace Modules.Analy.Import
    Partial Class InputDNEdit
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New AnalyController()
        Dim obj As New InputDNInfo
        Dim dicInfo As New WORK.CMS_BusinessInfo
        Dim str() As String
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP, "", "TP")
            If Request.Item("tp") <> "" Then
                TinhTP.SelectedValue = Request.Item("tp")
            Else
                If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            End If

            Call flDic.LoadMonth(ThangKhaoSat, False)
            Call flDic.LoadYear(drYear, Now.Year - 2, Now.Year + 1)
            drYear.SelectedValue = Now.Year
            Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "", "QH")
            QuanHuyen.SelectedValue = flReg.WriteNumber(Request.Item("qh"))

            Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue, "", "XP")
            XaPhuong.SelectedValue = flReg.WriteNumber(Request.Item("xa"))

            Call flDic.LoadDropList(LoaiHinh_Id, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_LOAIHINH"))
            Call flDic.LoadCheckList(NganhNghe_Id, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_NGANHNGHE"))
            Call flDic.LoadDropList(QuyMoLaoDong_Id, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_QUYMOLD"), False, "Chọn quy mô lao động")
            '' Load kỹ năng
            Dim _lstNKN = flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_NHOMKYNANG")
            Dim _textNKN = "Chọn kỹ năng"
            Call flDic.LoadDropList(DanhGia11KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia12KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia13KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia21KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia22KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia23KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia31KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia32KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia33KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia41KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia42KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia43KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia51KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia52KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia53KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia61KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia62KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia63KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia71KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia72KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia73KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia81KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia82KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia83KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia91KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia92KN, _lstNKN,, _textNKN)
            Call flDic.LoadDropList(DanhGia93KN, _lstNKN,, _textNKN)
            '' Load mức độ
            Dim _lstMD = flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_MUCDO")
            Dim _textDM = "Chọn mức độ"
            Call flDic.LoadDropList(DanhGia11MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia12MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia13MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia21MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia22MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia23MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia31MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia32MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia33MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia41MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia42MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia43MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia51MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia52MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia53MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia61MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia62MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia63MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia71MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia72MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia73MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia81MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia82MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia83MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia91MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia92MD, _lstMD,, _textDM)
            Call flDic.LoadDropList(DanhGia93MD, _lstMD,, _textDM)
            ''
            Call flDic.LoadCheckList(KhoKhanPhiaLD, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_KHOKHANNLD"))
            Call flDic.LoadCheckList(KhoKhanPhiaDN, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_KHOKHANDN"))
            Call flDic.LoadCheckList(NhomTrinhDoCMKT, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_TRINHDO"))
            Call flDic.LoadCheckList(NhomNgheKTD, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_NGHE"))
            Call flDic.LoadCheckList(HinhThucTuyenDung, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_HINHTHUCTUYEN"))
            Call flDic.LoadCheckList(DaHopTac, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_DNLIENKET"))

            ItemID.Value = IIf(Request.Item("itemid") <> "", Request.Item("itemid"), "0")

        End Sub
        Private Sub BackEnd()
            If Request.Item("page") <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page"), True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), True)
            End If
        End Sub
        Private Sub LoadValue()
            If ItemID.Value <> "0" Then
                obj = objController.InputDN_Get(Me.PortalId, ItemID.Value)
                If IsNothing(obj) = False Then
                    TenDoanhNghiep.Text = flReg.RemoveScript(obj.TenDoanhNghiep, False)
                    TinhTP.SelectedValue = obj.TinhTP
                    Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "", "QH")
                    QuanHuyen.SelectedValue = obj.QuanHuyen
                    Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue, "", "XP")
                    XaPhuong.SelectedValue = obj.XaPhuong

                    ThangKhaoSat.SelectedValue = obj.ThangKhaoSat
                    drYear.SelectedValue = obj.NamKhaoSat
                    MaDoiTuong.Text = obj.MaDoanhNghiep
                    MaSDDKD.Text = obj.MaSDDKD
                    LoaiHinh_Id.SelectedValue = obj.LoaiHinh
                    SoNha.Text = obj.DiaChi
                    KCNKKT.Text = obj.KCNKKT
                    SoDienThoai.Text = obj.SoDienThoai
                    Email.Text = obj.Email
                    Website.Text = obj.Website
                    NamThanhLap.Text = obj.NamThanhLap
                    flReg.SetCheckListValue(NganhNghe_Id, obj.NganhSanXuat)
                    QuyMoLaoDong_Id.SelectedValue = obj.QuyMo
                    TongSoLaoDong.Text = obj.TongSoLaoDong
                    TongSoLaoDongNu.Text = obj.TongSoLaoDongNu
                    SoLDNgoaiTinh.Text = obj.SoLDNgoaiTinh
                    SoLDNgoaiTinhNu.Text = obj.SoLDNgoaiTinhNu
                    SoLDTrucTiep.Text = obj.SoLDTrucTiep
                    SoLDTrucTiepNu.Text = obj.SoLDTrucTiepNu
                    SoLDGianTiep.Text = obj.SoLDGianTiep
                    SoLDGianTiepNu.Text = obj.SoLDGianTiepNu
                    SoLDDaKyHopDong.Text = obj.SoLDDaKyHopDong
                    SoLDDaKyHopDongNu.Text = obj.SoLDDaKyHopDongNu
                    SoLDBHXH.Text = obj.SoLDBHXH
                    SoLDBHXHNu.Text = obj.SoLDBHXHNu
                    SoLDTren35.Text = obj.SoLDTren35
                    SoLDTren35Nu.Text = obj.SoLDTren35Nu
                    SoLDNguoiNN.Text = obj.SoLDNguoiNN
                    SoLDNguoiNNNu.Text = obj.SoLDNguoiNNNu
                    SoLDTHPT.Text = obj.SoLDTHPT
                    SoLDTHPTNu.Text = obj.SoLDTHPTNU
                    SoLDTDKhongCo.Text = obj.SoLDTDKhongCo
                    SoLDTDKhongCoNu.Text = obj.SoLDTDKhongCoNu
                    SoLDTDCongNhan.Text = obj.SoLDTDCongNhan
                    SoLDTDCongNhanNu.Text = obj.SoLDTDCongNhanNu
                    SoLDTDDaoTao.Text = obj.SoLDTDDaoTao
                    SoLDTDDaoTaoNu.Text = obj.SoLDTDDaoTaoNu
                    SoLDTDSoCap.Text = obj.SoLDTDSoCap
                    SoLDTDSoCapNu.Text = obj.SoLDTDSoCapNu
                    SoLDTDTrungCap.Text = obj.SoLDTDTrungCap
                    SoLDTDTrungCapNu.Text = obj.SoLDTDTrungCapNu
                    SoLDTDCaoDang.Text = obj.SoLDTDCaoDang
                    SoLDTDCaoDangNu.Text = obj.SoLDTDCaoDangNu
                    SoLDTDDaiHoc.Text = obj.SoLDTDDaiHoc
                    SoLDTDDaiHocNu.Text = obj.SoLDTDDaiHocNu
                    SoLDLVChuongTrinh.Text = obj.SoLDLVChuongTrinh
                    SoLDLVChuongTrinhNu.Text = obj.SoLDLVChuongTrinhNu
                    SoLDLVKhoaHoc.Text = obj.SoLDLVKhoaHoc
                    SoLDLVKhoaHocNu.Text = obj.SoLDLVKhoaHocNu
                    SoLDLVNgheThuat.Text = obj.SoLDLVNgheThuat
                    SoLDLVNgheThuatNu.Text = obj.SoLDLVNgheThuatNu
                    SoLDLVNhanVan.Text = obj.SoLDLVNhanVan
                    SoLDLVNhanVanNu.Text = obj.SoLDLVNhanVanNu
                    SoLDLVKhoaHocXH.Text = obj.SoLDLVKhoaHocXH
                    SoLDLVKhoaHocXHNu.Text = obj.SoLDLVKhoaHocXHNu
                    SoLDLVBaoTri.Text = obj.SoLDLVBaoTri
                    SoLDLVBaoTriNu.Text = obj.SoLDLVBaoTriNu
                    SoLDLVKinhDoanh.Text = obj.SoLDLVKinhDoanh
                    SoLDLVKinhDoanhNu.Text = obj.SoLDLVKinhDoanhNu
                    SoLDLVPhapLuat.Text = obj.SoLDLVPhapLuat
                    SoLDLVPhapLuatNu.Text = obj.SoLDLVPhapLuatNu
                    SoLDLVKhoaHocSS.Text = obj.SoLDLVKhoaHocSS
                    SoLDLVKhoaHocSSNu.Text = obj.SoLDLVKhoaHocSSNu
                    SoLDLVKhoaHocTN.Text = obj.SoLDLVKhoaHocTN
                    SoLDLVKhoaHocTNNu.Text = obj.SoLDLVKhoaHocTNNu
                    SoLDLVToan.Text = obj.SoLDLVToan
                    SoLDLVToanNu.Text = obj.SoLDLVToanNu
                    SoLDLVMayTinh.Text = obj.SoLDLVMayTinh
                    SoLDLVMayTinhNu.Text = obj.SoLDLVMayTinhNu
                    SoLDLVCongNghe.Text = obj.SoLDLVCongNghe
                    SoLDLVCongNgheNu.Text = obj.SoLDLVCongNgheNu
                    SoLDLVKyThuat.Text = obj.SoLDLVKyThuat
                    SoLDLVKyThuatNu.Text = obj.SoLDLVKyThuatNu
                    SoLDLVSanXuat.Text = obj.SoLDLVSanXuat
                    SoLDLVSanXuatNu.Text = obj.SoLDLVSanXuatNu
                    SoLDLVKienTruc.Text = obj.SoLDLVKienTruc
                    SoLDLVKienTrucNu.Text = obj.SoLDLVKienTrucNu
                    SoLDLVNongLam.Text = obj.SoLDLVNongLam
                    SoLDLVNongLamNu.Text = obj.SoLDLVNongLamNu
                    SoLDLVThuY.Text = obj.SoLDLVThuY
                    SoLDLVThuYNu.Text = obj.SoLDLVThuYNu
                    SoLDLVSucKhoe.Text = obj.SoLDLVSucKhoe
                    SoLDLVSucKhoeNu.Text = obj.SoLDLVSucKhoeNu
                    SoLDLVDichVuXH.Text = obj.SoLDLVDichVuXH
                    SoLDLVDichVuXHNu.Text = obj.SoLDLVDichVuXHNu
                    SoLDLVDuLich.Text = obj.SoLDLVDuLich
                    SoLDLVDuLichNu.Text = obj.SoLDLVDuLichNu
                    SoLDLVDichVuVT.Text = obj.SoLDLVDichVuVT
                    SoLDLVDichVuVTNu.Text = obj.SoLDLVDichVuVTNu
                    SoLDLVMoiTruong.Text = obj.SoLDLVMoiTruong
                    SoLDLVMoiTruongNu.Text = obj.SoLDLVMoiTruongNu
                    SoLDLVAnNinh.Text = obj.SoLDLVAnNinh
                    SoLDLVAnNinhNu.Text = obj.SoLDLVAnNinhNu
                    SoLDLVKhac.Text = obj.SoLDLVKhac
                    SoLDLVKhacNu.Text = obj.SoLDLVKhacNu
                    SoLDNNLanhDao.Text = obj.SoLDNNLanhDao
                    SoLDNNLanhDaoNu.Text = obj.SoLDNNLanhDaoNu
                    SoLDNNKyThuatBC.Text = obj.SoLDNNKyThuatBC
                    SoLDNNKyThuatBCNu.Text = obj.SoLDNNKyThuatBCNu
                    SoLDNNKyThuatBT.Text = obj.SoLDNNKyThuatBT
                    SoLDNNKyThuatBTNu.Text = obj.SoLDNNKyThuatBTNu
                    SoLDNNNhanVienNghe.Text = obj.SoLDNNNhanVienNghe
                    SoLDNNNhanVienNgheNu.Text = obj.SoLDNNNhanVienNgheNu
                    SoLDNNNhanVienDV.Text = obj.SoLDNNNhanVienDV
                    SoLDNNNhanVienDVNu.Text = obj.SoLDNNNhanVienDVNu
                    SoLDNNLaoDongCoKT.Text = obj.SoLDNNLaoDongCoKT
                    SoLDNNLaoDongCoKTNu.Text = obj.SoLDNNLaoDongCoKTNu
                    SoLDNNThoThuCong.Text = obj.SoLDNNThoThuCong
                    SoLDNNThoThuCongNu.Text = obj.SoLDNNThoThuCongNu
                    SoLDNNThoKyThuat.Text = obj.SoLDNNThoKyThuat
                    SoLDNNThoKyThuatNu.Text = obj.SoLDNNThoKyThuatNu
                    SoLDNNLaoDongPT.Text = obj.SoLDNNLaoDongPT
                    SoLDNNLaoDongPTNu.Text = obj.SoLDNNLaoDongPTNu
                    SoLDTDTiengAnh.Text = obj.SoLDTDTiengAnh
                    SoLDTDTiengAnhNu.Text = obj.SoLDTDTiengAnhNu
                    SoLDTDTiengTrung.Text = obj.SoLDTDTiengTrung
                    SoLDTDTiengTrungNu.Text = obj.SoLDTDTiengTrungNu
                    SoLDTDTiengNhat.Text = obj.SoLDTDTiengNhat
                    SoLDTDTiengNhatNu.Text = obj.SoLDTDTiengNhatNu
                    SoLDTDTiengKhac.Text = obj.SoLDTDTiengKhac
                    SoLDTDTiengKhacNu.Text = obj.SoLDTDTiengKhacNu
                    SoLDTDTinHocCB.Text = obj.SoLDTDTinHocCB
                    SoLDTDTinHocCBNu.Text = obj.SoLDTDTinHocCBNu
                    SoLDTDTinHocNC.Text = obj.SoLDTDTinHocNC
                    SoLDTDTinHocNCNu.Text = obj.SoLDTDTinHocNCNu
                    SoLDTDTinHocNC2.Text = obj.SoLDTDTinHocNC2
                    SoLDTDTinHocNC2Nu.Text = obj.SoLDTDTinHocNC2Nu
                    TienLuongBinhQuan.Text = obj.TienLuongBinhQuan
                    TienLuongThapNhat.Text = obj.TienLuongThapNhat
                    TienLuongCaoNhat.Text = obj.TienLuongCaoNhat
                    DanhGia11KN.SelectedValue = obj.DanhGia11KN
                    DanhGia11MD.SelectedValue = obj.DanhGia11MD
                    DanhGia12KN.SelectedValue = obj.DanhGia12KN
                    DanhGia12MD.SelectedValue = obj.DanhGia12MD
                    DanhGia13KN.SelectedValue = obj.DanhGia13KN
                    DanhGia13MD.SelectedValue = obj.DanhGia13MD
                    DanhGia21KN.SelectedValue = obj.DanhGia21KN
                    DanhGia21MD.SelectedValue = obj.DanhGia21MD
                    DanhGia22KN.SelectedValue = obj.DanhGia22KN
                    DanhGia22MD.SelectedValue = obj.DanhGia22MD
                    DanhGia23KN.SelectedValue = obj.DanhGia23KN
                    DanhGia23MD.SelectedValue = obj.DanhGia23MD
                    DanhGia31KN.SelectedValue = obj.DanhGia31KN
                    DanhGia31MD.SelectedValue = obj.DanhGia31MD
                    DanhGia32KN.SelectedValue = obj.DanhGia32KN
                    DanhGia32MD.SelectedValue = obj.DanhGia32MD
                    DanhGia33KN.SelectedValue = obj.DanhGia33KN
                    DanhGia33MD.SelectedValue = obj.DanhGia33MD
                    DanhGia41KN.SelectedValue = obj.DanhGia41KN
                    DanhGia41MD.SelectedValue = obj.DanhGia41MD
                    DanhGia42KN.SelectedValue = obj.DanhGia42KN
                    DanhGia42MD.SelectedValue = obj.DanhGia42MD
                    DanhGia43KN.SelectedValue = obj.DanhGia43KN
                    DanhGia43MD.SelectedValue = obj.DanhGia43MD
                    DanhGia51KN.SelectedValue = obj.DanhGia51KN
                    DanhGia51MD.SelectedValue = obj.DanhGia51MD
                    DanhGia52KN.SelectedValue = obj.DanhGia52KN
                    DanhGia52MD.SelectedValue = obj.DanhGia52MD
                    DanhGia53KN.SelectedValue = obj.DanhGia53KN
                    DanhGia53MD.SelectedValue = obj.DanhGia53MD
                    DanhGia61KN.SelectedValue = obj.DanhGia61KN
                    DanhGia61MD.SelectedValue = obj.DanhGia61MD
                    DanhGia62KN.SelectedValue = obj.DanhGia62KN
                    DanhGia62MD.SelectedValue = obj.DanhGia62MD
                    DanhGia63KN.SelectedValue = obj.DanhGia63KN
                    DanhGia63MD.SelectedValue = obj.DanhGia63MD
                    DanhGia71KN.SelectedValue = obj.DanhGia71KN
                    DanhGia71MD.SelectedValue = obj.DanhGia71MD
                    DanhGia72KN.SelectedValue = obj.DanhGia72KN
                    DanhGia72MD.SelectedValue = obj.DanhGia72MD
                    DanhGia73KN.SelectedValue = obj.DanhGia73KN
                    DanhGia73MD.SelectedValue = obj.DanhGia73MD
                    DanhGia81KN.SelectedValue = obj.DanhGia81KN
                    DanhGia81MD.SelectedValue = obj.DanhGia81MD
                    DanhGia82KN.SelectedValue = obj.DanhGia82KN
                    DanhGia82MD.SelectedValue = obj.DanhGia82MD
                    DanhGia83KN.SelectedValue = obj.DanhGia83KN
                    DanhGia83MD.SelectedValue = obj.DanhGia83MD
                    DanhGia91KN.SelectedValue = obj.DanhGia91KN
                    DanhGia91MD.SelectedValue = obj.DanhGia91MD
                    DanhGia92KN.SelectedValue = obj.DanhGia92KN
                    DanhGia92MD.SelectedValue = obj.DanhGia92MD
                    DanhGia93KN.SelectedValue = obj.DanhGia93KN
                    DanhGia93MD.SelectedValue = obj.DanhGia93MD
                    NhuCauNNNongLam.Text = obj.NhuCauNNNongLam
                    NhuCauNNNongLamNu.Text = obj.NhuCauNNNongLamNu
                    NhuCauNNCongNghiep.Text = obj.NhuCauNNCongNghiep
                    NhuCauNNCongNghiepNu.Text = obj.NhuCauNNCongNghiepNu
                    NhuCauNNThuongMai.Text = obj.NhuCauNNThuongMai
                    NhuCauNNThuongMaiNu.Text = obj.NhuCauNNThuongMaiNu
                    NhuCauTDLanhDao.Text = obj.NhuCauTDLanhDao
                    NhuCauTDLanhDaoNu.Text = obj.NhuCauTDLanhDaoNu
                    NhuCauTDSoCap.Text = obj.NhuCauTDSoCap
                    NhuCauTDSoCapNu.Text = obj.NhuCauTDSoCapNu
                    NhuCauTDTrungCap.Text = obj.NhuCauTDTrungCap
                    NhuCauTDTrungCapNu.Text = obj.NhuCauTDTrungCapNu
                    NhuCauTDCaoDang.Text = obj.NhuCauTDCaoDang
                    NhuCauTDCaoDangNu.Text = obj.NhuCauTDCaoDangNu
                    NhuCauTDDaiHoc.Text = obj.NhuCauTDDaiHoc
                    NhuCauTDDaiHocNu.Text = obj.NhuCauTDDaiHocNu
                    NhuCauLDNNLanhDao.Text = obj.NhuCauLDNNLanhDao
                    NhuCauTDNNLanhDaoNu.Text = obj.NhuCauTDNNLanhDaoNu
                    NhuCauTDNNChuyenMonBC.Text = obj.NhuCauTDNNChuyenMonBC
                    NhuCauTDNNChuyenMonBCNu.Text = obj.NhuCauTDNNChuyenMonBCNu
                    NhuCauTDNNChuyenMocBT.Text = obj.NhuCauTDNNChuyenMocBT
                    NhuCauTDNNChuyenMonBTNu.Text = obj.NhuCauTDNNChuyenMonBTNu
                    NhuCauTDNNNhanVienNN.Text = obj.NhuCauTDNNNhanVienNN
                    NhuCauTDNNNhanVienNNNu.Text = obj.NhuCauTDNNNhanVienNNNu
                    NhuCauTDNNNhanVienDV.Text = obj.NhuCauTDNNNhanVienDV
                    NhuCauTDNNNhanVienDVNu.Text = obj.NhuCauTDNNNhanVienDVNu
                    NhuCauTDNNLaoDongKT.Text = obj.NhuCauTDNNLaoDongKT
                    NhuCauTDNNLaoDongKTNu.Text = obj.NhuCauTDNNLaoDongKTNu
                    NhuCauTDNNThoTC.Text = obj.NhuCauTDNNThoTC
                    NhuCauTDNNThoTCNu.Text = obj.NhuCauTDNNThoTCNu
                    NhuCauTDNNThoKT.Text = obj.NhuCauTDNNThoKT
                    NhuCauTDNNThoKTNu.Text = obj.NhuCauTDNNThoKTNu
                    NhuCauTDNNLaoDongPT.Text = obj.NhuCauTDNNLaoDongPT
                    NhuCauTDNNLaoDongPTNu.Text = obj.NhuCauTDNNLaoDongPTNu
                    NhuCauTDTDTiengAnh.Text = obj.NhuCauTDTDTiengAnh
                    NhuCauTDTDTiengAnhNu.Text = obj.NhuCauTDTDTiengAnhNu
                    NhuCauTDTDTiengTrung.Text = obj.NhuCauTDTDTiengTrung
                    NhuCauTDTDTiengTrungNu.Text = obj.NhuCauTDTDTiengTrungNu
                    NhuCauTDTDTiengHN.Text = obj.NhuCauTDTDTiengHN
                    NhuCauTDTDTiengHNNu.Text = obj.NhuCauTDTDTiengHNNu
                    NhuCauTDTDTiengKhac.Text = obj.NhuCauTDTDTiengKhac
                    NhuCauTDTDTiengKhacNu.Text = obj.NhuCauTDTDTiengKhacNu
                    NhuCauTDTDTinHocCB.Text = obj.NhuCauTDTDTinHocCB
                    NhuCauTDTDTinHocCBNu.Text = obj.NhuCauTDTDTinHocCBNu
                    NhuCauTDTDTinHocNC.Text = obj.NhuCauTDTDTinHocNC
                    NhuCauTDTDTinHocNCNu.Text = obj.NhuCauTDTDTinHocNCNu
                    NhuCauTDTDTinHocNC2.Text = obj.NhuCauTDTDTinHocNC2
                    NhuCauTDTDTinHocNC2Nu.Text = obj.NhuCauTDTDTinHocNC2Nu
                    NhuCauTDMLThoaThuan.Text = obj.NhuCauTDMLThoaThuan
                    NhuCauTDMLThoaThuanNu.Text = obj.NhuCauTDMLThoaThuanNu
                    NhuCauTDML3.Text = obj.NhuCauTDML3
                    NhuCauTDML3Nu.Text = obj.NhuCauTDML3Nu
                    NhuCauTDML5.Text = obj.NhuCauTDML5
                    NhuCauTDML5Nu.Text = obj.NhuCauTDML5Nu
                    NhuCauTDML7.Text = obj.NhuCauTDML7
                    NhuCauTDML7Nu.Text = obj.NhuCauTDML7Nu
                    NhuCauTDML10.Text = obj.NhuCauTDML10
                    NhuCauTDML10Nu.Text = obj.NhuCauTDML10Nu
                    NhuCauTDML15.Text = obj.NhuCauTDML15
                    NhuCauTDML15Nu.Text = obj.NhuCauTDML15Nu
                    NhuCauTBKNChua.Text = obj.NhuCauTBKNChua
                    NhuCauTBKNChuaNu.Text = obj.NhuCauTBKNChuaNu
                    NhuCauTBKN1.Text = obj.NhuCauTBKN1
                    NhuCauTBKN1Nu.Text = obj.NhuCauTBKN1Nu
                    NhuCauTBKN3.Text = obj.NhuCauTBKN3
                    NhuCauTBKN3Nu.Text = obj.NhuCauTBKN3Nu
                    NhuCauTBKN5.Text = obj.NhuCauTBKN5
                    NhuCauTBKN5Nu.Text = obj.NhuCauTBKN5Nu
                    NhuCauTBKN10.Text = obj.NhuCauTBKN10
                    NhuCauTBKN10Nu.Text = obj.NhuCauTBKN10Nu
                    KhoKhanTDLDCo.Checked = IIf(obj.KhoKhanTDLD, True, False)
                    KhoKhanTDLDKhong.Checked = IIf(obj.KhoKhanTDLD, False, True)
                    flReg.SetCheckListValue(KhoKhanPhiaLD, obj.KhoKhanPhiaLD)
                    flReg.SetCheckListValue(KhoKhanPhiaDN, obj.KhoKhanPhiaDN)
                    KhoKhanPhiaDNKhac.Text = obj.KhoKhanPhiaDNKhac
                    flReg.SetCheckListValue(NhomTrinhDoCMKT, obj.NhomTrinhDoCMKT)
                    flReg.SetCheckListValue(NhomNgheKTD, obj.NhomNgheKTD)
                    flReg.SetCheckListValue(HinhThucTuyenDung, obj.HinhThucTuyenDung)
                    HinhThucTuyenDungKhac.Text = obj.HinhThucTuyenDungKhac
                    TungLienKetCo.Checked = IIf(obj.TungLienKet, True, False)
                    TungLienKetKhong.Checked = IIf(obj.TungLienKet, False, True)
                    flReg.SetCheckListValue(DaHopTac, obj.DaHopTac)
                    DaHopTacKhac.Text = obj.DaHopTacKhac
                    KhoKhanVuongMac.Text = obj.KhoKhanVuongMac
                    KhuyenNghi.Text = obj.KhuyenNghi
                    TongSo13.Text = (obj.SoLDTDKhongCo + obj.SoLDTDCongNhan + obj.SoLDTDDaoTao + obj.SoLDTDSoCap + obj.SoLDTDTrungCap + obj.SoLDTDCaoDang + obj.SoLDTDDaiHoc)
                    TongSo13Nu.Text = (obj.SoLDTDKhongCoNu + obj.SoLDTDCongNhanNu + obj.SoLDTDDaoTaoNu + obj.SoLDTDSoCapNu + obj.SoLDTDTrungCapNu + obj.SoLDTDCaoDangNu + obj.SoLDTDDaiHocNu)

                    TongSo14.Text = (obj.SoLDLVChuongTrinh + obj.SoLDLVKhoaHoc + obj.SoLDLVNgheThuat + obj.SoLDLVNhanVan + obj.SoLDLVKhoaHocXH + obj.SoLDLVBaoTri + obj.SoLDLVKinhDoanh + obj.SoLDLVPhapLuat + obj.SoLDLVKhoaHocSS + obj.SoLDLVKhoaHocTN + obj.SoLDLVToan + obj.SoLDLVMayTinh + obj.SoLDLVCongNghe + obj.SoLDLVKyThuat + obj.SoLDLVSanXuat + obj.SoLDLVKienTruc + obj.SoLDLVNongLam + obj.SoLDLVThuY + obj.SoLDLVSucKhoe + obj.SoLDLVDichVuXH + obj.SoLDLVDuLich + obj.SoLDLVDichVuVT + obj.SoLDLVMoiTruong + obj.SoLDLVAnNinh + obj.SoLDLVKhac
                        )

                    TongSo14Nu.Text = (obj.SoLDLVChuongTrinhNu + obj.SoLDLVKhoaHocNu + obj.SoLDLVNgheThuatNu + obj.SoLDLVNhanVanNu + obj.SoLDLVKhoaHocXHNu + obj.SoLDLVBaoTriNu + obj.SoLDLVKinhDoanhNu + obj.SoLDLVPhapLuatNu + obj.SoLDLVKhoaHocSSNu + obj.SoLDLVKhoaHocTNNu + obj.SoLDLVToanNu + obj.SoLDLVMayTinhNu + obj.SoLDLVCongNgheNu + obj.SoLDLVKyThuatNu + obj.SoLDLVSanXuatNu + obj.SoLDLVKienTrucNu + obj.SoLDLVNongLamNu + obj.SoLDLVThuYNu + obj.SoLDLVSucKhoeNu + obj.SoLDLVDichVuXHNu + obj.SoLDLVDuLichNu + obj.SoLDLVDichVuVTNu + obj.SoLDLVMoiTruongNu + obj.SoLDLVAnNinhNu + obj.SoLDLVKhacNu
                        )

                    TongSo15.Text = (obj.SoLDNNLanhDao + obj.SoLDNNKyThuatBC + obj.SoLDNNKyThuatBT + obj.SoLDNNNhanVienNghe + obj.SoLDNNNhanVienDV + obj.SoLDNNLaoDongCoKT + obj.SoLDNNThoThuCong + obj.SoLDNNThoKyThuat + obj.SoLDNNLaoDongPT)
                    TongSo15Nu.Text = (obj.SoLDNNLanhDaoNu + obj.SoLDNNKyThuatBCNu + obj.SoLDNNKyThuatBTNu + obj.SoLDNNNhanVienNgheNu + obj.SoLDNNNhanVienDVNu + obj.SoLDNNLaoDongCoKTNu + obj.SoLDNNThoThuCongNu + obj.SoLDNNThoKyThuatNu + obj.SoLDNNLaoDongPTNu)

                    TongSo16NN.Text = (obj.SoLDTDTiengAnh + obj.SoLDTDTiengTrung + obj.SoLDTDTiengNhat + obj.SoLDTDTiengKhac)
                    TongSo16NNNu.Text = (obj.SoLDTDTiengAnhNu + obj.SoLDTDTiengTrungNu + obj.SoLDTDTiengNhatNu + obj.SoLDTDTiengKhacNu)
                    TongSo16TH.Text = (obj.SoLDTDTinHocCB + obj.SoLDTDTinHocNC + obj.SoLDTDTinHocNC2)
                    TongSo16THNu.Text = (obj.SoLDTDTinHocCBNu + obj.SoLDTDTinHocNCNu + obj.SoLDTDTinHocNC2Nu)

                    TongSo19.Text = (obj.NhuCauNNNongLam + obj.NhuCauNNCongNghiep + obj.NhuCauNNThuongMai)
                    TongSo19Nu.Text = (obj.NhuCauNNNongLamNu + obj.NhuCauNNCongNghiepNu + obj.NhuCauNNThuongMaiNu)

                    TongSo20.Text = (obj.NhuCauTDLanhDao + obj.NhuCauTDSoCap + obj.NhuCauTDTrungCap + obj.NhuCauTDCaoDang + obj.NhuCauTDDaiHoc)
                    TongSo20Nu.Text = (obj.NhuCauTDLanhDaoNu + obj.NhuCauTDSoCapNu + obj.NhuCauTDTrungCapNu + obj.NhuCauTDCaoDangNu + obj.NhuCauTDDaiHocNu)

                    TongSo21.Text = (obj.NhuCauLDNNLanhDao + obj.NhuCauTDNNChuyenMonBC + obj.NhuCauTDNNChuyenMocBT + obj.NhuCauTDNNNhanVienNN + obj.NhuCauTDNNNhanVienDV + obj.NhuCauTDNNLaoDongKT + obj.NhuCauTDNNThoTC + obj.NhuCauTDNNThoKT + obj.NhuCauTDNNLaoDongPT)
                    TongSo21Nu.Text = (obj.NhuCauTDNNLanhDaoNu + obj.NhuCauTDNNChuyenMonBCNu + obj.NhuCauTDNNChuyenMonBTNu + obj.NhuCauTDNNNhanVienNNNu + obj.NhuCauTDNNNhanVienDVNu + obj.NhuCauTDNNLaoDongKTNu + obj.NhuCauTDNNThoTCNu + obj.NhuCauTDNNThoKTNu + obj.NhuCauTDNNLaoDongPTNu)

                    TongSo22NN.Text = (obj.NhuCauTDTDTiengAnh + obj.NhuCauTDTDTiengTrung + obj.NhuCauTDTDTiengHN + obj.NhuCauTDTDTiengKhac)
                    TongSo22NNNu.Text = (obj.NhuCauTDTDTiengAnhNu + obj.NhuCauTDTDTiengTrungNu + obj.NhuCauTDTDTiengHNNu + obj.NhuCauTDTDTiengKhacNu)
                    TongSo22TH.Text = (obj.NhuCauTDTDTinHocCB + obj.NhuCauTDTDTinHocNC + obj.NhuCauTDTDTinHocNC2)
                    TongSo22THNu.Text = (obj.NhuCauTDTDTinHocCBNu + obj.NhuCauTDTDTinHocNCNu + obj.NhuCauTDTDTinHocNC2Nu)

                    litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate)
                    litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                    If obj.UpdatedUser <> "" Then
                        litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                        litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                    End If

                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "loaddnkhokhanco", "loaddnkhokhanco(" & IIf(obj.KhoKhanTDLD, 1, 0) & ");loaddnhoptac(" & IIf(obj.TungLienKet, 1, 0) & ")", True)
                End If
            Else
                SetMaPhieu()
                'ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
            End If
        End Sub
        Private Sub ShowNotify(message As String)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_warning", "removewaiting();notify('warning', '" & message & "', 'Thông báo', false);loadchange();", True)
        End Sub

#Region "Thông báo"
        Private Const MSG01 As String = "Vui lòng chọn ngành sản xuất, kinh doanh chính!"
        Private Const MSG02 As String = "Vui lòng nhập số lao động nữ nhỏ hơn hoặc bằng tổng số lao động!"
        Private Const MSG03 As String = "Vui lòng nhập số lao động trực tiếp và gián tiếp bằng tổng số lao động!"
        Private Const MSG04 As String = "Vui lòng nhập số lao động ngoại tỉnh, đã ký hợp đồng lao động, tham gia BHXH bắt buộc, trên 35 tuổi, là người nước ngoài, đã tốt nghiệp Trung học phổ thông phải nhỏ hơn hoặc bằng tổng số lao động!"
        Private Const MSG05 As String = "Vui lòng nhập tổng số lao động theo trình độ chuyên môn kỹ thuật bằng tổng số lao động!"
        Private Const MSG06 As String = "Vui lòng nhập tổng số lao động theo trình độ chuyên môn kỹ thuật nữ bằng tổng số lao động nữ!"
        Private Const MSG07 As String = "Vui lòng nhập tổng số lao động theo nhóm nghề bằng tổng số lao động!"
        Private Const MSG08 As String = "Vui lòng nhập tổng số lao động theo nhóm nghề nữ bằng tổng số lao động nữ!"
        Private Const MSG09 As String = "Vui lòng nhập tổng số lao động theo trình độ ngoại ngữ và tin học bằng tổng số lao động!"
        Private Const MSG10 As String = "Vui lòng nhập tổng số lao động theo trình độ ngoại ngữ và tin học nữ bằng tổng số lao động nữ!"
        Private Const MSG11 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động theo trình độ chuyên môn kỹ thuật bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế!"
        Private Const MSG12 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động theo trình độ chuyên môn kỹ thuật nữ bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế nữ!"
        Private Const MSG13 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo nhóm nghề bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế!"
        Private Const MSG14 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo nhóm nghề nữ bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế nữ!"
        Private Const MSG15 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo trình độ ngoại ngữ và tin học nhỏ hơn hoặc bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế!"
        Private Const MSG16 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo trình độ ngoại ngữ và tin học nữ nhỏ hơn hoặc bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế nữ!"
        Private Const MSG17 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo mức lương bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế!"
        Private Const MSG18 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo mức lương nữ bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế nữ!"
        Private Const MSG19 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo kinh nghiệm làm việc bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế!"
        Private Const MSG20 As String = "Vui lòng nhập tổng số nhu cầu tuyển dụng lao động của doanh nghiệp theo kinh nghiệm làm việc nữ bằng nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế nữ!"
        Private Const MSG21 As String = "Mã phiếu trùng nhau, vui lòng nhập mã phiếu khác!"
#End Region

        Private Function CheckShowNotify() As Boolean
            Dim isActive As Boolean = False
            Try
                Dim _nganhNgheSX = "", _tongSoLD = 0, _tongSoLDNu = 0, _SoLDTrucTiep = 0, _SoLDTrucTiepNu = 0, _SoLDGianTiep = 0, _SoLDGianTiepNu = 0, _SoLDNgoaiTinh = 0, _SoLDNgoaiTinhNu = 0, _SoLDDaKyHopDong = 0, _SoLDDaKyHopDongNu = 0, _SoLDBHXH = 0, _SoLDBHXHNu = 0, _SoLDTren35 = 0, _SoLDTren35Nu = 0, _SoLDNguoiNN = 0, _SoLDNguoiNNNu = 0, _SoLDTHPT = 0, _SoLDTHPTNu = 0, _TongSo13 = 0, _TongSo13Nu = 0, _TongSo15 = 0, _TongSo15Nu = 0, _TongSo16NN = 0, _TongSo16NNNu = 0, _TongSo16TH = 0, _TongSo16THNu = 0, _TongSo19 = 0, _TongSo19Nu = 0, _TongSo20 = 0, _TongSo20Nu = 0, _TongSo21 = 0, _TongSo21Nu = 0, _TongSo22NN = 0, _TongSo22NNNu = 0, _TongSo22TH = 0, _TongSo22THNu = 0
                Dim _NhuCauTDMLThoaThuan = 0, _NhuCauTDMLThoaThuanNu = 0, _NhuCauTDML3 = 0, _NhuCauTDML3Nu = 0, _NhuCauTDML5 = 0, _NhuCauTDML5Nu = 0, _NhuCauTDML7 = 0, _NhuCauTDML7Nu = 0, _NhuCauTDML10 = 0, _NhuCauTDML10Nu = 0, _NhuCauTDML15 = 0, _NhuCauTDML15Nu = 0
                Dim _NhuCauTBKNChua = 0, _NhuCauTBKNChuaNu = 0, _NhuCauTBKN1 = 0, _NhuCauTBKN1Nu = 0, _NhuCauTBKN3 = 0, _NhuCauTBKN3Nu = 0, _NhuCauTBKN5 = 0, _NhuCauTBKN5Nu = 0, _NhuCauTBKN10 = 0, _NhuCauTBKN10Nu = 0
                ''Câu 10. Quy mô lao động
                _nganhNgheSX = flReg.GetCheckListValue(NganhNghe_Id)
                ''Câu 11. Tổng số lao động 
                _tongSoLD = flReg.WriteNumber(TongSoLaoDong.Text)
                _tongSoLDNu = flReg.WriteNumber(TongSoLaoDongNu.Text)
                ''Câu 12.  Tổng số lao động trực tiếp và gián tiếp (dòng 3 và dòng 4) phải bằng tổng số lao động ở câu 11
                _SoLDTrucTiep = flReg.WriteNumber(SoLDTrucTiep.Text)
                _SoLDTrucTiepNu = flReg.WriteNumber(SoLDTrucTiepNu.Text)
                _SoLDGianTiep = flReg.WriteNumber(SoLDGianTiep.Text)
                _SoLDGianTiepNu = flReg.WriteNumber(SoLDGianTiepNu.Text)
                ''Câu 12.  Ở các dòng còn lại, số lao động phải nhỏ hơn hoặc bằng tổng số lao động ở câu 11, không được lớn hơn tổng số lao động ở câu 11
                _SoLDNgoaiTinh = flReg.WriteNumber(SoLDNgoaiTinh.Text)
                _SoLDNgoaiTinhNu = flReg.WriteNumber(SoLDNgoaiTinhNu.Text)
                _SoLDDaKyHopDong = flReg.WriteNumber(SoLDDaKyHopDong.Text)
                _SoLDDaKyHopDongNu = flReg.WriteNumber(SoLDDaKyHopDongNu.Text)
                _SoLDBHXH = flReg.WriteNumber(SoLDBHXH.Text)
                _SoLDBHXHNu = flReg.WriteNumber(SoLDBHXHNu.Text)
                _SoLDTren35 = flReg.WriteNumber(SoLDTren35.Text)
                _SoLDTren35Nu = flReg.WriteNumber(SoLDTren35Nu.Text)
                _SoLDNguoiNN = flReg.WriteNumber(SoLDNguoiNN.Text)
                _SoLDNguoiNNNu = flReg.WriteNumber(SoLDNguoiNNNu.Text)
                _SoLDTHPT = flReg.WriteNumber(SoLDTHPT.Text)
                _SoLDTHPTNu = flReg.WriteNumber(SoLDTHPTNu.Text)
                ''Câu 13. ĐTV hỏi NTL về từng đối tượng lao động (theo từng dòng) và điền số lượng người vào 2 cột tương ứng là số lượng và số lượng nữ
                _TongSo13 = flReg.WriteNumber(TongSo13.Text)
                _TongSo13Nu = flReg.WriteNumber(TongSo13Nu.Text)
                '' Câu 15. Số lao động theo nhóm nghề
                _TongSo15 = flReg.WriteNumber(TongSo15.Text)
                _TongSo15Nu = flReg.WriteNumber(TongSo15Nu.Text)
                '' Câu 16. Số lao động theo trình độ ngoại ngữ và tin học
                _TongSo16NN = flReg.WriteNumber(TongSo16NN.Text)
                _TongSo16NNNu = flReg.WriteNumber(TongSo16NNNu.Text)
                _TongSo16TH = flReg.WriteNumber(TongSo16TH.Text)
                _TongSo16THNu = flReg.WriteNumber(TongSo16THNu.Text)
                '' Câu 20. Nhu cầu tuyển dụng lao động theo trình độ CMKT
                _TongSo19 = flReg.WriteNumber(TongSo19.Text)
                _TongSo19Nu = flReg.WriteNumber(TongSo19Nu.Text)
                _TongSo20 = flReg.WriteNumber(TongSo20.Text)
                _TongSo20Nu = flReg.WriteNumber(TongSo20Nu.Text)
                '' Câu 21.Nhu cầu tuyển dụng lao động theo nhóm nghề
                _TongSo21 = flReg.WriteNumber(TongSo21.Text)
                _TongSo21Nu = flReg.WriteNumber(TongSo21Nu.Text)
                '' Câu 22. Nhu cầu tuyển dụng lao động của doanh nghiệp theo trình độ ngoại ngữ và tin học
                _TongSo22NN = flReg.WriteNumber(TongSo22NN.Text)
                _TongSo22NNNu = flReg.WriteNumber(TongSo22NNNu.Text)
                _TongSo22TH = flReg.WriteNumber(TongSo22TH.Text)
                _TongSo22THNu = flReg.WriteNumber(TongSo22THNu.Text)
                '' Câu 23. Nhu cầu tuyển dụng lao động của doanh nghiệp theo mức lương
                _NhuCauTDMLThoaThuan = flReg.WriteNumber(NhuCauTDMLThoaThuan.Text)
                _NhuCauTDMLThoaThuanNu = flReg.WriteNumber(NhuCauTDMLThoaThuanNu.Text)
                _NhuCauTDML3 = flReg.WriteNumber(NhuCauTDML3.Text)
                _NhuCauTDML3Nu = flReg.WriteNumber(NhuCauTDML3Nu.Text)
                _NhuCauTDML5 = flReg.WriteNumber(NhuCauTDML5.Text)
                _NhuCauTDML5Nu = flReg.WriteNumber(NhuCauTDML5Nu.Text)
                _NhuCauTDML7 = flReg.WriteNumber(NhuCauTDML7.Text)
                _NhuCauTDML7Nu = flReg.WriteNumber(NhuCauTDML7Nu.Text)
                _NhuCauTDML10 = flReg.WriteNumber(NhuCauTDML10.Text)
                _NhuCauTDML10Nu = flReg.WriteNumber(NhuCauTDML10Nu.Text)
                _NhuCauTDML15 = flReg.WriteNumber(NhuCauTDML15.Text)
                _NhuCauTDML15Nu = flReg.WriteNumber(NhuCauTDML15Nu.Text)
                '' Nhu cầu tuyển dụng lao động của doanh nghiệp theo kinh nghiệm làm việc 
                _NhuCauTBKNChua = flReg.WriteNumber(NhuCauTBKNChua.Text)
                _NhuCauTBKNChuaNu = flReg.WriteNumber(NhuCauTBKNChuaNu.Text)
                _NhuCauTBKN1 = flReg.WriteNumber(NhuCauTBKN1.Text)
                _NhuCauTBKN1Nu = flReg.WriteNumber(NhuCauTBKN1Nu.Text)
                _NhuCauTBKN3 = flReg.WriteNumber(NhuCauTBKN3.Text)
                _NhuCauTBKN3Nu = flReg.WriteNumber(NhuCauTBKN3Nu.Text)
                _NhuCauTBKN5 = flReg.WriteNumber(NhuCauTBKN5.Text)
                _NhuCauTBKN5Nu = flReg.WriteNumber(NhuCauTBKN5Nu.Text)
                _NhuCauTBKN10 = flReg.WriteNumber(NhuCauTBKN10.Text)
                _NhuCauTBKN10Nu = flReg.WriteNumber(NhuCauTBKN10Nu.Text)

                If _nganhNgheSX = "" Then ''Câu 10
                    ShowNotify(MSG01)
                ElseIf _tongSoLDNu > _tongSoLD Then ''Câu 11
                    ShowNotify(MSG02)
                ElseIf (_SoLDTrucTiep + _SoLDGianTiep) <> _tongSoLD Then ''Câu 11
                    ShowNotify(MSG03)
                ElseIf (_SoLDNgoaiTinh + _SoLDDaKyHopDong + _SoLDBHXH + _SoLDTren35 + _SoLDNguoiNN + _SoLDTHPT) > _tongSoLD Then ''Câu 12
                    ShowNotify(MSG04)
                ElseIf _TongSo13 <> _tongSoLD Then ''Câu 13
                    ShowNotify(MSG05)
                ElseIf _TongSo13Nu <> _tongSoLDNu Then ''Câu 13
                    ShowNotify(MSG06)
                ElseIf _TongSo15 <> _tongSoLD Then ''Câu 15
                    ShowNotify(MSG07)
                ElseIf _TongSo15Nu <> _tongSoLDNu Then ''Câu 15
                    ShowNotify(MSG08)
                ElseIf (_TongSo16NN + _TongSo16TH) > _tongSoLD Then ''Câu 16
                    ShowNotify(MSG09)
                ElseIf (_TongSo16NNNu + _TongSo16THNu) > _tongSoLDNu Then ''Câu 16
                    ShowNotify(MSG10)
                ElseIf _TongSo19 <> _TongSo20 Then ''Câu 20
                    ShowNotify(MSG11)
                ElseIf _TongSo19Nu <> _TongSo20Nu Then ''Câu 20
                    ShowNotify(MSG12)
                ElseIf _TongSo19 <> _TongSo21 Then ''Câu 21
                    ShowNotify(MSG13)
                ElseIf _TongSo19Nu <> _TongSo21Nu Then ''Câu 21
                    ShowNotify(MSG14)
                ElseIf (_TongSo22NN + _TongSo22TH) > _TongSo19 Then ''Câu 22
                    ShowNotify(MSG15)
                ElseIf (_TongSo22NNNu + _TongSo22THNu) > _TongSo19Nu Then ''Câu 22
                    ShowNotify(MSG16)
                ElseIf (_NhuCauTDMLThoaThuan + _NhuCauTDML3 + _NhuCauTDML5 + _NhuCauTDML7 + _NhuCauTDML10 + _NhuCauTDML15) <> _TongSo19 Then ''Câu 23
                    ShowNotify(MSG17)
                ElseIf (_NhuCauTDMLThoaThuanNu + _NhuCauTDML3Nu + _NhuCauTDML5Nu + _NhuCauTDML7Nu + _NhuCauTDML10Nu + _NhuCauTDML15Nu) <> _TongSo19Nu Then ''Câu 23
                    ShowNotify(MSG18)
                ElseIf (_NhuCauTBKNChua + _NhuCauTBKN1 + _NhuCauTBKN3 + _NhuCauTBKN5 + _NhuCauTBKN10) <> _TongSo19 Then ''Câu 24
                    ShowNotify(MSG19)
                ElseIf (_NhuCauTBKNChuaNu + _NhuCauTBKN1Nu + _NhuCauTBKN3Nu + _NhuCauTBKN5Nu + _NhuCauTBKN10Nu) <> _TongSo19Nu Then ''Câu 24
                    ShowNotify(MSG20)
                ElseIf (objController.InputDN_CheckMaPhieu(MaDoiTuong.Text.Trim()) > 1) Then ''Câu 24
                    ShowNotify(MSG21)
                Else
                    isActive = True
                End If

                Return isActive
            Catch ex As Exception
                Return isActive
            End Try
        End Function
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If CheckShowNotify() Then
                    obj = New InputDNInfo
                    obj.ThangKhaoSat = ThangKhaoSat.SelectedValue
                    obj.NamKhaoSat = drYear.SelectedValue
                    obj.MaDoanhNghiep = MaDoiTuong.Text
                    obj.TenDoanhNghiep = TenDoanhNghiep.Text
                    obj.MaSDDKD = MaSDDKD.Text
                    obj.LoaiHinh = LoaiHinh_Id.SelectedValue
                    obj.TinhTP = TinhTP.SelectedValue
                    obj.QuanHuyen = QuanHuyen.SelectedValue
                    obj.XaPhuong = XaPhuong.SelectedValue
                    obj.DiaChi = SoNha.Text
                    obj.KCNKKT = KCNKKT.Text
                    obj.SoDienThoai = SoDienThoai.Text
                    obj.Email = Email.Text
                    obj.Website = Website.Text
                    obj.NamThanhLap = flReg.WriteNumber(NamThanhLap.Text)
                    obj.NganhSanXuat = flReg.GetCheckListValue(NganhNghe_Id)
                    obj.QuyMo = QuyMoLaoDong_Id.SelectedValue
                    obj.TongSoLaoDong = flReg.WriteNumber(TongSoLaoDong.Text)
                    obj.TongSoLaoDongNu = flReg.WriteNumber(TongSoLaoDongNu.Text)
                    obj.SoLDNgoaiTinh = flReg.WriteNumber(SoLDNgoaiTinh.Text)
                    obj.SoLDNgoaiTinhNu = flReg.WriteNumber(SoLDNgoaiTinhNu.Text)
                    obj.SoLDTrucTiep = flReg.WriteNumber(SoLDTrucTiep.Text)
                    obj.SoLDTrucTiepNu = flReg.WriteNumber(SoLDTrucTiepNu.Text)
                    obj.SoLDGianTiep = flReg.WriteNumber(SoLDGianTiep.Text)
                    obj.SoLDGianTiepNu = flReg.WriteNumber(SoLDGianTiepNu.Text)
                    obj.SoLDDaKyHopDong = flReg.WriteNumber(SoLDDaKyHopDong.Text)
                    obj.SoLDDaKyHopDongNu = flReg.WriteNumber(SoLDDaKyHopDongNu.Text)
                    obj.SoLDBHXH = flReg.WriteNumber(SoLDBHXH.Text)
                    obj.SoLDBHXHNu = flReg.WriteNumber(SoLDBHXHNu.Text)
                    obj.SoLDTren35 = flReg.WriteNumber(SoLDTren35.Text)
                    obj.SoLDTren35Nu = flReg.WriteNumber(SoLDTren35Nu.Text)
                    obj.SoLDNguoiNN = flReg.WriteNumber(SoLDNguoiNN.Text)
                    obj.SoLDNguoiNNNu = flReg.WriteNumber(SoLDNguoiNNNu.Text)
                    obj.SoLDTHPT = flReg.WriteNumber(SoLDTHPT.Text)
                    obj.SoLDTHPTNU = flReg.WriteNumber(SoLDTHPTNu.Text)
                    obj.SoLDTDKhongCo = flReg.WriteNumber(SoLDTDKhongCo.Text)
                    obj.SoLDTDKhongCoNu = flReg.WriteNumber(SoLDTDKhongCoNu.Text)
                    obj.SoLDTDCongNhan = flReg.WriteNumber(SoLDTDCongNhan.Text)
                    obj.SoLDTDCongNhanNu = flReg.WriteNumber(SoLDTDCongNhanNu.Text)
                    obj.SoLDTDDaoTao = flReg.WriteNumber(SoLDTDDaoTao.Text)
                    obj.SoLDTDDaoTaoNu = flReg.WriteNumber(SoLDTDDaoTaoNu.Text)
                    obj.SoLDTDSoCap = flReg.WriteNumber(SoLDTDSoCap.Text)
                    obj.SoLDTDSoCapNu = flReg.WriteNumber(SoLDTDSoCapNu.Text)
                    obj.SoLDTDTrungCap = flReg.WriteNumber(SoLDTDTrungCap.Text)
                    obj.SoLDTDTrungCapNu = flReg.WriteNumber(SoLDTDTrungCapNu.Text)
                    obj.SoLDTDCaoDang = flReg.WriteNumber(SoLDTDCaoDang.Text)
                    obj.SoLDTDCaoDangNu = flReg.WriteNumber(SoLDTDCaoDangNu.Text)
                    obj.SoLDTDDaiHoc = flReg.WriteNumber(SoLDTDDaiHoc.Text)
                    obj.SoLDTDDaiHocNu = flReg.WriteNumber(SoLDTDDaiHocNu.Text)
                    obj.SoLDLVChuongTrinh = flReg.WriteNumber(SoLDLVChuongTrinh.Text)
                    obj.SoLDLVChuongTrinhNu = flReg.WriteNumber(SoLDLVChuongTrinhNu.Text)
                    obj.SoLDLVKhoaHoc = flReg.WriteNumber(SoLDLVKhoaHoc.Text)
                    obj.SoLDLVKhoaHocNu = flReg.WriteNumber(SoLDLVKhoaHocNu.Text)
                    obj.SoLDLVNgheThuat = flReg.WriteNumber(SoLDLVNgheThuat.Text)
                    obj.SoLDLVNgheThuatNu = flReg.WriteNumber(SoLDLVNgheThuatNu.Text)
                    obj.SoLDLVNhanVan = flReg.WriteNumber(SoLDLVNhanVan.Text)
                    obj.SoLDLVNhanVanNu = flReg.WriteNumber(SoLDLVNhanVanNu.Text)
                    obj.SoLDLVKhoaHocXH = flReg.WriteNumber(SoLDLVKhoaHocXH.Text)
                    obj.SoLDLVKhoaHocXHNu = flReg.WriteNumber(SoLDLVKhoaHocXHNu.Text)
                    obj.SoLDLVBaoTri = flReg.WriteNumber(SoLDLVBaoTri.Text)
                    obj.SoLDLVBaoTriNu = flReg.WriteNumber(SoLDLVBaoTriNu.Text)
                    obj.SoLDLVKinhDoanh = flReg.WriteNumber(SoLDLVKinhDoanh.Text)
                    obj.SoLDLVKinhDoanhNu = flReg.WriteNumber(SoLDLVKinhDoanhNu.Text)
                    obj.SoLDLVPhapLuat = flReg.WriteNumber(SoLDLVPhapLuat.Text)
                    obj.SoLDLVPhapLuatNu = flReg.WriteNumber(SoLDLVPhapLuatNu.Text)
                    obj.SoLDLVKhoaHocSS = flReg.WriteNumber(SoLDLVKhoaHocSS.Text)
                    obj.SoLDLVKhoaHocSSNu = flReg.WriteNumber(SoLDLVKhoaHocSSNu.Text)
                    obj.SoLDLVKhoaHocTN = flReg.WriteNumber(SoLDLVKhoaHocTN.Text)
                    obj.SoLDLVKhoaHocTNNu = flReg.WriteNumber(SoLDLVKhoaHocTNNu.Text)
                    obj.SoLDLVToan = flReg.WriteNumber(SoLDLVToan.Text)
                    obj.SoLDLVToanNu = flReg.WriteNumber(SoLDLVToanNu.Text)
                    obj.SoLDLVMayTinh = flReg.WriteNumber(SoLDLVMayTinh.Text)
                    obj.SoLDLVMayTinhNu = flReg.WriteNumber(SoLDLVMayTinhNu.Text)
                    obj.SoLDLVCongNghe = flReg.WriteNumber(SoLDLVCongNghe.Text)
                    obj.SoLDLVCongNgheNu = flReg.WriteNumber(SoLDLVCongNgheNu.Text)
                    obj.SoLDLVKyThuat = flReg.WriteNumber(SoLDLVKyThuat.Text)
                    obj.SoLDLVKyThuatNu = flReg.WriteNumber(SoLDLVKyThuatNu.Text)
                    obj.SoLDLVSanXuat = flReg.WriteNumber(SoLDLVSanXuat.Text)
                    obj.SoLDLVSanXuatNu = flReg.WriteNumber(SoLDLVSanXuatNu.Text)
                    obj.SoLDLVKienTruc = flReg.WriteNumber(SoLDLVKienTruc.Text)
                    obj.SoLDLVKienTrucNu = flReg.WriteNumber(SoLDLVKienTrucNu.Text)
                    obj.SoLDLVNongLam = flReg.WriteNumber(SoLDLVNongLam.Text)
                    obj.SoLDLVNongLamNu = flReg.WriteNumber(SoLDLVNongLamNu.Text)
                    obj.SoLDLVThuY = flReg.WriteNumber(SoLDLVThuY.Text)
                    obj.SoLDLVThuYNu = flReg.WriteNumber(SoLDLVThuYNu.Text)
                    obj.SoLDLVSucKhoe = flReg.WriteNumber(SoLDLVSucKhoe.Text)
                    obj.SoLDLVSucKhoeNu = flReg.WriteNumber(SoLDLVSucKhoeNu.Text)
                    obj.SoLDLVDichVuXH = flReg.WriteNumber(SoLDLVDichVuXH.Text)
                    obj.SoLDLVDichVuXHNu = flReg.WriteNumber(SoLDLVDichVuXHNu.Text)
                    obj.SoLDLVDuLich = flReg.WriteNumber(SoLDLVDuLich.Text)
                    obj.SoLDLVDuLichNu = flReg.WriteNumber(SoLDLVDuLichNu.Text)
                    obj.SoLDLVDichVuVT = flReg.WriteNumber(SoLDLVDichVuVT.Text)
                    obj.SoLDLVDichVuVTNu = flReg.WriteNumber(SoLDLVDichVuVTNu.Text)
                    obj.SoLDLVMoiTruong = flReg.WriteNumber(SoLDLVMoiTruong.Text)
                    obj.SoLDLVMoiTruongNu = flReg.WriteNumber(SoLDLVMoiTruongNu.Text)
                    obj.SoLDLVAnNinh = flReg.WriteNumber(SoLDLVAnNinh.Text)
                    obj.SoLDLVAnNinhNu = flReg.WriteNumber(SoLDLVAnNinhNu.Text)
                    obj.SoLDLVKhac = flReg.WriteNumber(SoLDLVKhac.Text)
                    obj.SoLDLVKhacNu = flReg.WriteNumber(SoLDLVKhacNu.Text)
                    obj.SoLDNNLanhDao = flReg.WriteNumber(SoLDNNLanhDao.Text)
                    obj.SoLDNNLanhDaoNu = flReg.WriteNumber(SoLDNNLanhDaoNu.Text)
                    obj.SoLDNNKyThuatBC = flReg.WriteNumber(SoLDNNKyThuatBC.Text)
                    obj.SoLDNNKyThuatBCNu = flReg.WriteNumber(SoLDNNKyThuatBCNu.Text)
                    obj.SoLDNNKyThuatBT = flReg.WriteNumber(SoLDNNKyThuatBT.Text)
                    obj.SoLDNNKyThuatBTNu = flReg.WriteNumber(SoLDNNKyThuatBTNu.Text)
                    obj.SoLDNNNhanVienNghe = flReg.WriteNumber(SoLDNNNhanVienNghe.Text)
                    obj.SoLDNNNhanVienNgheNu = flReg.WriteNumber(SoLDNNNhanVienNgheNu.Text)
                    obj.SoLDNNNhanVienDV = flReg.WriteNumber(SoLDNNNhanVienDV.Text)
                    obj.SoLDNNNhanVienDVNu = flReg.WriteNumber(SoLDNNNhanVienDVNu.Text)
                    obj.SoLDNNLaoDongCoKT = flReg.WriteNumber(SoLDNNLaoDongCoKT.Text)
                    obj.SoLDNNLaoDongCoKTNu = flReg.WriteNumber(SoLDNNLaoDongCoKTNu.Text)
                    obj.SoLDNNThoThuCong = flReg.WriteNumber(SoLDNNThoThuCong.Text)
                    obj.SoLDNNThoThuCongNu = flReg.WriteNumber(SoLDNNThoThuCongNu.Text)
                    obj.SoLDNNThoKyThuat = flReg.WriteNumber(SoLDNNThoKyThuat.Text)
                    obj.SoLDNNThoKyThuatNu = flReg.WriteNumber(SoLDNNThoKyThuatNu.Text)
                    obj.SoLDNNLaoDongPT = flReg.WriteNumber(SoLDNNLaoDongPT.Text)
                    obj.SoLDNNLaoDongPTNu = flReg.WriteNumber(SoLDNNLaoDongPTNu.Text)
                    obj.SoLDTDTiengAnh = flReg.WriteNumber(SoLDTDTiengAnh.Text)
                    obj.SoLDTDTiengAnhNu = flReg.WriteNumber(SoLDTDTiengAnhNu.Text)
                    obj.SoLDTDTiengTrung = flReg.WriteNumber(SoLDTDTiengTrung.Text)
                    obj.SoLDTDTiengTrungNu = flReg.WriteNumber(SoLDTDTiengTrungNu.Text)
                    obj.SoLDTDTiengNhat = flReg.WriteNumber(SoLDTDTiengNhat.Text)
                    obj.SoLDTDTiengNhatNu = flReg.WriteNumber(SoLDTDTiengNhatNu.Text)
                    obj.SoLDTDTiengKhac = flReg.WriteNumber(SoLDTDTiengKhac.Text)
                    obj.SoLDTDTiengKhacNu = flReg.WriteNumber(SoLDTDTiengKhacNu.Text)
                    obj.SoLDTDTinHocCB = flReg.WriteNumber(SoLDTDTinHocCB.Text)
                    obj.SoLDTDTinHocCBNu = flReg.WriteNumber(SoLDTDTinHocCBNu.Text)
                    obj.SoLDTDTinHocNC = flReg.WriteNumber(SoLDTDTinHocNC.Text)
                    obj.SoLDTDTinHocNCNu = flReg.WriteNumber(SoLDTDTinHocNCNu.Text)
                    obj.SoLDTDTinHocNC2 = flReg.WriteNumber(SoLDTDTinHocNC2.Text)
                    obj.SoLDTDTinHocNC2Nu = flReg.WriteNumber(SoLDTDTinHocNC2Nu.Text)
                    obj.TienLuongBinhQuan = flReg.WritePrice(TienLuongBinhQuan.Text)
                    obj.TienLuongThapNhat = flReg.WritePrice(TienLuongThapNhat.Text)
                    obj.TienLuongCaoNhat = flReg.WritePrice(TienLuongCaoNhat.Text)
                    obj.DanhGia11KN = DanhGia11KN.SelectedValue
                    obj.DanhGia11MD = DanhGia11MD.SelectedValue
                    obj.DanhGia12KN = DanhGia12KN.SelectedValue
                    obj.DanhGia12MD = DanhGia12MD.SelectedValue
                    obj.DanhGia13KN = DanhGia13KN.SelectedValue
                    obj.DanhGia13MD = DanhGia13MD.SelectedValue
                    obj.DanhGia21KN = DanhGia21KN.SelectedValue
                    obj.DanhGia21MD = DanhGia21MD.SelectedValue
                    obj.DanhGia22KN = DanhGia22KN.SelectedValue
                    obj.DanhGia22MD = DanhGia22MD.SelectedValue
                    obj.DanhGia23KN = DanhGia23KN.SelectedValue
                    obj.DanhGia23MD = DanhGia23MD.SelectedValue
                    obj.DanhGia31KN = DanhGia31KN.SelectedValue
                    obj.DanhGia31MD = DanhGia31MD.SelectedValue
                    obj.DanhGia32KN = DanhGia32KN.SelectedValue
                    obj.DanhGia32MD = DanhGia32MD.SelectedValue
                    obj.DanhGia33KN = DanhGia33KN.SelectedValue
                    obj.DanhGia33MD = DanhGia33MD.SelectedValue
                    obj.DanhGia41KN = DanhGia41KN.SelectedValue
                    obj.DanhGia41MD = DanhGia41MD.SelectedValue
                    obj.DanhGia42KN = DanhGia42KN.SelectedValue
                    obj.DanhGia42MD = DanhGia42MD.SelectedValue
                    obj.DanhGia43KN = DanhGia43KN.SelectedValue
                    obj.DanhGia43MD = DanhGia43MD.SelectedValue
                    obj.DanhGia51KN = DanhGia51KN.SelectedValue
                    obj.DanhGia51MD = DanhGia51MD.SelectedValue
                    obj.DanhGia52KN = DanhGia52KN.SelectedValue
                    obj.DanhGia52MD = DanhGia52MD.SelectedValue
                    obj.DanhGia53KN = DanhGia53KN.SelectedValue
                    obj.DanhGia53MD = DanhGia53MD.SelectedValue
                    obj.DanhGia61KN = DanhGia61KN.SelectedValue
                    obj.DanhGia61MD = DanhGia61MD.SelectedValue
                    obj.DanhGia62KN = DanhGia62KN.SelectedValue
                    obj.DanhGia62MD = DanhGia62MD.SelectedValue
                    obj.DanhGia63KN = DanhGia63KN.SelectedValue
                    obj.DanhGia63MD = DanhGia63MD.SelectedValue
                    obj.DanhGia71KN = DanhGia71KN.SelectedValue
                    obj.DanhGia71MD = DanhGia71MD.SelectedValue
                    obj.DanhGia72KN = DanhGia72KN.SelectedValue
                    obj.DanhGia72MD = DanhGia72MD.SelectedValue
                    obj.DanhGia73KN = DanhGia73KN.SelectedValue
                    obj.DanhGia73MD = DanhGia73MD.SelectedValue
                    obj.DanhGia81KN = DanhGia81KN.SelectedValue
                    obj.DanhGia81MD = DanhGia81MD.SelectedValue
                    obj.DanhGia82KN = DanhGia82KN.SelectedValue
                    obj.DanhGia82MD = DanhGia82MD.SelectedValue
                    obj.DanhGia83KN = DanhGia83KN.SelectedValue
                    obj.DanhGia83MD = DanhGia83MD.SelectedValue
                    obj.DanhGia91KN = DanhGia91KN.SelectedValue
                    obj.DanhGia91MD = DanhGia91MD.SelectedValue
                    obj.DanhGia92KN = DanhGia92KN.SelectedValue
                    obj.DanhGia92MD = DanhGia92MD.SelectedValue
                    obj.DanhGia93KN = DanhGia93KN.SelectedValue
                    obj.DanhGia93MD = DanhGia93MD.SelectedValue
                    obj.NhuCauNNNongLam = flReg.WritePrice(NhuCauNNNongLam.Text)
                    obj.NhuCauNNNongLamNu = flReg.WritePrice(NhuCauNNNongLamNu.Text)
                    obj.NhuCauNNCongNghiep = flReg.WritePrice(NhuCauNNCongNghiep.Text)
                    obj.NhuCauNNCongNghiepNu = flReg.WritePrice(NhuCauNNCongNghiepNu.Text)
                    obj.NhuCauNNThuongMai = flReg.WritePrice(NhuCauNNThuongMai.Text)
                    obj.NhuCauNNThuongMaiNu = flReg.WritePrice(NhuCauNNThuongMaiNu.Text)
                    obj.NhuCauTDLanhDao = flReg.WritePrice(NhuCauTDLanhDao.Text)
                    obj.NhuCauTDLanhDaoNu = flReg.WritePrice(NhuCauTDLanhDaoNu.Text)
                    obj.NhuCauTDSoCap = flReg.WritePrice(NhuCauTDSoCap.Text)
                    obj.NhuCauTDSoCapNu = flReg.WritePrice(NhuCauTDSoCapNu.Text)
                    obj.NhuCauTDTrungCap = flReg.WritePrice(NhuCauTDTrungCap.Text)
                    obj.NhuCauTDTrungCapNu = flReg.WritePrice(NhuCauTDTrungCapNu.Text)
                    obj.NhuCauTDCaoDang = flReg.WritePrice(NhuCauTDCaoDang.Text)
                    obj.NhuCauTDCaoDangNu = flReg.WritePrice(NhuCauTDCaoDangNu.Text)
                    obj.NhuCauTDDaiHoc = flReg.WritePrice(NhuCauTDDaiHoc.Text)
                    obj.NhuCauTDDaiHocNu = flReg.WritePrice(NhuCauTDDaiHocNu.Text)
                    obj.NhuCauLDNNLanhDao = flReg.WritePrice(NhuCauLDNNLanhDao.Text)
                    obj.NhuCauTDNNLanhDaoNu = flReg.WritePrice(NhuCauTDNNLanhDaoNu.Text)
                    obj.NhuCauTDNNChuyenMonBC = flReg.WritePrice(NhuCauTDNNChuyenMonBC.Text)
                    obj.NhuCauTDNNChuyenMonBCNu = flReg.WritePrice(NhuCauTDNNChuyenMonBCNu.Text)
                    obj.NhuCauTDNNChuyenMocBT = flReg.WritePrice(NhuCauTDNNChuyenMocBT.Text)
                    obj.NhuCauTDNNChuyenMonBTNu = flReg.WritePrice(NhuCauTDNNChuyenMonBTNu.Text)
                    obj.NhuCauTDNNNhanVienNN = flReg.WritePrice(NhuCauTDNNNhanVienNN.Text)
                    obj.NhuCauTDNNNhanVienNNNu = flReg.WritePrice(NhuCauTDNNNhanVienNNNu.Text)
                    obj.NhuCauTDNNNhanVienDV = flReg.WritePrice(NhuCauTDNNNhanVienDV.Text)
                    obj.NhuCauTDNNNhanVienDVNu = flReg.WritePrice(NhuCauTDNNNhanVienDVNu.Text)
                    obj.NhuCauTDNNLaoDongKT = flReg.WritePrice(NhuCauTDNNLaoDongKT.Text)
                    obj.NhuCauTDNNLaoDongKTNu = flReg.WritePrice(NhuCauTDNNLaoDongKTNu.Text)
                    obj.NhuCauTDNNThoTC = flReg.WritePrice(NhuCauTDNNThoTC.Text)
                    obj.NhuCauTDNNThoTCNu = flReg.WritePrice(NhuCauTDNNThoTCNu.Text)
                    obj.NhuCauTDNNThoKT = flReg.WritePrice(NhuCauTDNNThoKT.Text)
                    obj.NhuCauTDNNThoKTNu = flReg.WritePrice(NhuCauTDNNThoKTNu.Text)
                    obj.NhuCauTDNNLaoDongPT = flReg.WritePrice(NhuCauTDNNLaoDongPT.Text)
                    obj.NhuCauTDNNLaoDongPTNu = flReg.WritePrice(NhuCauTDNNLaoDongPTNu.Text)
                    obj.NhuCauTDTDTiengAnh = flReg.WritePrice(NhuCauTDTDTiengAnh.Text)
                    obj.NhuCauTDTDTiengAnhNu = flReg.WritePrice(NhuCauTDTDTiengAnhNu.Text)
                    obj.NhuCauTDTDTiengTrung = flReg.WritePrice(NhuCauTDTDTiengTrung.Text)
                    obj.NhuCauTDTDTiengTrungNu = flReg.WritePrice(NhuCauTDTDTiengTrungNu.Text)
                    obj.NhuCauTDTDTiengHN = flReg.WritePrice(NhuCauTDTDTiengHN.Text)
                    obj.NhuCauTDTDTiengHNNu = flReg.WritePrice(NhuCauTDTDTiengHNNu.Text)
                    obj.NhuCauTDTDTiengKhac = flReg.WritePrice(NhuCauTDTDTiengKhac.Text)
                    obj.NhuCauTDTDTiengKhacNu = flReg.WritePrice(NhuCauTDTDTiengKhacNu.Text)
                    obj.NhuCauTDTDTinHocCB = flReg.WritePrice(NhuCauTDTDTinHocCB.Text)
                    obj.NhuCauTDTDTinHocCBNu = flReg.WritePrice(NhuCauTDTDTinHocCBNu.Text)
                    obj.NhuCauTDTDTinHocNC = flReg.WritePrice(NhuCauTDTDTinHocNC.Text)
                    obj.NhuCauTDTDTinHocNCNu = flReg.WritePrice(NhuCauTDTDTinHocNCNu.Text)
                    obj.NhuCauTDTDTinHocNC2 = flReg.WritePrice(NhuCauTDTDTinHocNC2.Text)
                    obj.NhuCauTDTDTinHocNC2Nu = flReg.WritePrice(NhuCauTDTDTinHocNC2Nu.Text)
                    obj.NhuCauTDMLThoaThuan = flReg.WritePrice(NhuCauTDMLThoaThuan.Text)
                    obj.NhuCauTDMLThoaThuanNu = flReg.WritePrice(NhuCauTDMLThoaThuanNu.Text)
                    obj.NhuCauTDML3 = flReg.WritePrice(NhuCauTDML3.Text)
                    obj.NhuCauTDML3Nu = flReg.WritePrice(NhuCauTDML3Nu.Text)
                    obj.NhuCauTDML5 = flReg.WritePrice(NhuCauTDML5.Text)
                    obj.NhuCauTDML5Nu = flReg.WritePrice(NhuCauTDML5Nu.Text)
                    obj.NhuCauTDML7 = flReg.WritePrice(NhuCauTDML7.Text)
                    obj.NhuCauTDML7Nu = flReg.WritePrice(NhuCauTDML7Nu.Text)
                    obj.NhuCauTDML10 = flReg.WritePrice(NhuCauTDML10.Text)
                    obj.NhuCauTDML10Nu = flReg.WritePrice(NhuCauTDML10Nu.Text)
                    obj.NhuCauTDML15 = flReg.WritePrice(NhuCauTDML15.Text)
                    obj.NhuCauTDML15Nu = flReg.WritePrice(NhuCauTDML15Nu.Text)
                    obj.NhuCauTBKNChua = flReg.WritePrice(NhuCauTBKNChua.Text)
                    obj.NhuCauTBKNChuaNu = flReg.WritePrice(NhuCauTBKNChuaNu.Text)
                    obj.NhuCauTBKN1 = flReg.WritePrice(NhuCauTBKN1.Text)
                    obj.NhuCauTBKN1Nu = flReg.WritePrice(NhuCauTBKN1Nu.Text)
                    obj.NhuCauTBKN3 = flReg.WritePrice(NhuCauTBKN3.Text)
                    obj.NhuCauTBKN3Nu = flReg.WritePrice(NhuCauTBKN3Nu.Text)
                    obj.NhuCauTBKN5 = flReg.WritePrice(NhuCauTBKN5.Text)
                    obj.NhuCauTBKN5Nu = flReg.WritePrice(NhuCauTBKN5Nu.Text)
                    obj.NhuCauTBKN10 = flReg.WritePrice(NhuCauTBKN10.Text)
                    obj.NhuCauTBKN10Nu = flReg.WritePrice(NhuCauTBKN10Nu.Text)
                    obj.KhoKhanTDLD = IIf(KhoKhanTDLDCo.Checked, True, False)
                    obj.KhoKhanPhiaLD = IIf(KhoKhanTDLDCo.Checked, flReg.GetCheckListValue(KhoKhanPhiaLD), "")
                    obj.KhoKhanPhiaDN = IIf(KhoKhanTDLDCo.Checked, flReg.GetCheckListValue(KhoKhanPhiaDN), "")
                    obj.KhoKhanPhiaDNKhac = IIf(KhoKhanTDLDCo.Checked, KhoKhanPhiaDNKhac.Text, "")
                    obj.NhomTrinhDoCMKT = IIf(KhoKhanTDLDKhong.Checked, flReg.GetCheckListValue(NhomTrinhDoCMKT), "")
                    obj.NhomNgheKTD = IIf(KhoKhanTDLDKhong.Checked, flReg.GetCheckListValue(NhomNgheKTD), "")
                    obj.HinhThucTuyenDung = flReg.GetCheckListValue(HinhThucTuyenDung)
                    obj.HinhThucTuyenDungKhac = HinhThucTuyenDungKhac.Text
                    obj.TungLienKet = IIf(TungLienKetCo.Checked, True, False)
                    obj.DaHopTac = IIf(TungLienKetCo.Checked, flReg.GetCheckListValue(DaHopTac), "")
                    obj.DaHopTacKhac = IIf(TungLienKetCo.Checked, DaHopTacKhac.Text, "")
                    obj.KhoKhanVuongMac = KhoKhanVuongMac.Text
                    obj.KhuyenNghi = IIf(TungLienKetKhong.Checked, KhuyenNghi.Text, "")

                    If ItemID.Value <> "0" Then
                        obj.DoanhNghiep_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = Me.UserInfo.Username
                        obj.UpdatedDate = Now
                        obj.UpdatedUser = Me.UserInfo.Username
                        obj.IsActive = True
                        obj.DeletedDate = flReg.DateNull
                        objController.InputDN_Update(Me.PortalId, obj)
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('success', 'Hệ thống cập nhật dữ liệu thành công', 'Thông báo', false);loadchange();", True)
                    Else
                        ItemID.Value = flReg.GenKey
                        obj.DoanhNghiep_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = Me.UserInfo.Username
                        obj.UpdatedUser = ""
                        obj.UpdatedDate = flReg.DateNull
                        obj.IsActive = True
                        obj.DeletedDate = flReg.DateNull
                        objController.InputDN_Add(Me.PortalId, obj)
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('success', 'Hệ thống thêm mới dữ liệu thành công', 'Thông báo', false);loadchange();", True)
                    End If
                End If
            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);loadchange();", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "", "QH")
            Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue, "", "XP")
            SetMaPhieu()
            'Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
            QuanHuyen.Focus()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue, "", "XP")
            'Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
            SetMaPhieu()
            XaPhuong.Focus()
        End Sub
        Private Sub SetMaPhieu()
            If ItemID.Value = "0" Then
                MaDoiTuong.Text = helper.GetMaPhieu(Me.PortalId, TinhTP.SelectedValue, QuanHuyen.SelectedValue, flReg.WriteNumber(Request.Item("c")))
            End If
        End Sub
    End Class

End Namespace
