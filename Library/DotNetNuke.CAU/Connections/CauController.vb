Imports DotNetNuke.Common.Utilities
Public Class CauController

#Region "BC_Business"
    Public Function BC_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As BC_BusinessInfo
        Return CBO.FillObject(Of BC_BusinessInfo)(DataProvider.Instance().BC_Business_Check_TaxCode(PortalConnect, business_ID, taxCode))
    End Function
    Public Function BC_CauLD_List_By_Flag(PortalConnect As String, isFlag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_CauLD_List_By_Flag(PortalConnect, isFlag), GetType(BC_CauLDInfo))
    End Function
    Public Function BC_Business_Check_Code(PortalConnect As String, tinhTP As String, quanHuyen As String, xaPhuong As String) As Integer
        Return DataProvider.Instance().BC_Business_Check_Code(PortalConnect, tinhTP, quanHuyen, xaPhuong)
    End Function
    Public Function BC_Business_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, XaPhuong As String, ThonTo As String, KCN As String, TrangThai As Integer, Year As Integer, NganhNghe As Integer, IsDelete As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List_Search(PortalConnect, Search, currPage, recodperpage, TinhTP, QuanHuyen, XaPhuong, ThonTo, KCN, TrangThai, Year, NganhNghe, IsDelete), GetType(BC_BusinessInfo))
    End Function
    Public Function BC_Business_List_XuatSo(PortalConnect As String, TinhTP As String, QuanHuyen As String, XaPhuong As String, Year As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List_XuatSo(PortalConnect, TinhTP, QuanHuyen, XaPhuong, Year), GetType(BC_BusinessInfo))
    End Function
    Public Sub BC_Business_Update_TbGui(PortalConnect As String, DoanhNghiep_ID As String, tbGui As Boolean)
        DataProvider.Instance().BC_Business_Update_TbGui(PortalConnect, DoanhNghiep_ID, tbGui)
    End Sub
    Public Sub BC_Business_Update_Tbao(PortalConnect As String, DoanhNghiep_ID As String, tuNgay As DateTime, denNgay As DateTime)
        DataProvider.Instance().BC_Business_Update_Tbao(PortalConnect, DoanhNghiep_ID, tuNgay, denNgay)
    End Sub
    Public Function BC_Business_List_Tbao(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, TrangThai As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List_Tbao(PortalConnect, Search, currPage, recodperpage, TinhTP, QuanHuyen, TrangThai), GetType(BC_BusinessInfo))
    End Function
    Public Function BC_Business_Get(PortalConnect As String, doanhNghiep_ID As String) As BC_BusinessInfo
        Return CBO.FillObject(Of BC_BusinessInfo)(DataProvider.Instance().BC_Business_Get(PortalConnect, doanhNghiep_ID))
    End Function
    Public Function BC_Business_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List(PortalConnect, portalId), GetType(BC_BusinessInfo))
    End Function
    Public Sub BC_Business_Add(PortalConnect As String, obj As BC_BusinessInfo)
        DataProvider.Instance().BC_Business_Add(PortalConnect, obj.DoanhNghiep_ID, obj.MaDoanhNghiep, obj.TenDoanhNghiep, obj.TaxCode, obj.Mobile, obj.Fax, obj.Email, obj.Website, obj.TinhTrang, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.TT_NT, obj.SoNha, obj.KhuCN_ID, obj.LoaiHinh_ID, obj.NganhNghe, obj.LD_TongSo, obj.LD_NgoaiTinh, obj.LD_TrucTiep, obj.LD_Nu, obj.LD_HD_Tong, obj.LD_HD_Nu, obj.LD_NuocNgoai_Tong, obj.LD_NuocNgoai_Nu, obj.LD_PhoThong, obj.CMKT_Khong, obj.CMKT_BangCap, obj.CMKT_DaoTao, obj.CMKT_SoCap, obj.CMKT_TrungCap, obj.CMKT_CaoDang, obj.CMKT_DaiHoc, obj.GDDT_KTXH, obj.GDDT_KHTN, obj.GDDT_KTCN, obj.GDDT_NongNghiep, obj.GDDT_YTe, obj.GDDT_Khac, obj.Nhom_LanhDao, obj.Nhom_ChuyenMon, obj.Nhom_TroLy, obj.Nhom_DichVu, obj.Nhom_NongNghiep, obj.Nhom_ThuCong, obj.Nhom_Tho, obj.Nhom_DonGian, obj.TL_BinhQuan, obj.TL_ThapNhat, obj.TL_CaoNhat, obj.Chia_Khong, obj.Chia_BangCap, obj.Chia_DaoTao, obj.Chia_SoCap, obj.Chia_TrungCap, obj.Chia_CaoDang, obj.Chia_DaiHoc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.SanPhamChinh, obj.QuyMoLaoDong, obj.LD_NgoaiTinh_Nu, obj.LD_TrucTiep_Nu, obj.LD_GianTiep_Nu, obj.LD_BHXH, obj.LD_BHXH_Nu, obj.LD_TREN35, obj.LD_TREN35_Nu, obj.LD_PhoThong_Nu, obj.VT_NhaQuanLy, obj.VT_NhaQuanLy_Nu, obj.VT_CMKT_Cao, obj.VT_CMKT_Cao_Nu, obj.VT_CMKT_Trung, obj.VT_CMKT_Trung_Nu, obj.VT_CMKT_Khac, obj.VT_CMKT_Khac_Nu, obj.CMKT_Khong_Nu, obj.CMKT_BangCap_Nu, obj.CMKT_DaoTao_Nu, obj.CMKT_SoCap_Nu, obj.CMKT_TrungCap_Nu, obj.CMKT_CaoDang_Nu, obj.CMKT_DaiHoc_Nu, obj.GDDT_KTXH_Nu, obj.GDDT_KHTN_Nu, obj.GDDT_KTCN_Nu, obj.GDDT_NongNghiep_Nu, obj.GDDT_YTe_Nu, obj.GDDT_Khac_Nu, obj.C8_17, obj.C8_21, obj.C8_22, obj.C8_23, obj.C8_24, obj.C8_25, obj.C8_26, obj.C8_31, obj.C8_32, obj.C8_33, obj.C8_34, obj.C8_35, obj.C8_36, obj.C8_41, obj.C8_42, obj.C8_43, obj.C8_44, obj.C8_51, obj.C8_52, obj.C8_53, obj.C8_54, obj.C8_61, obj.C8_62, obj.C8_63, obj.C8_71, obj.C8_72, obj.C8_73, obj.C8_74, obj.C8_75, obj.C8_81, obj.C8_82, obj.C8_83, obj.C8_91, obj.C8_92, obj.C8_93, obj.C8_94, obj.C8_95, obj.C8_96, obj.C8_17_Nu, obj.C8_21_Nu, obj.C8_22_Nu, obj.C8_23_Nu, obj.C8_24_Nu, obj.C8_25_Nu, obj.C8_26_Nu, obj.C8_31_Nu, obj.C8_32_Nu, obj.C8_33_Nu, obj.C8_34_Nu, obj.C8_35_Nu, obj.C8_36_Nu, obj.C8_41_Nu, obj.C8_42_Nu, obj.C8_43_Nu, obj.C8_44_Nu, obj.C8_51_Nu, obj.C8_52_Nu, obj.C8_53_Nu, obj.C8_54_Nu, obj.C8_61_Nu, obj.C8_62_Nu, obj.C8_63_Nu, obj.C8_71_Nu, obj.C8_72_Nu, obj.C8_73_Nu, obj.C8_74_Nu, obj.C8_75_Nu, obj.C8_81_Nu, obj.C8_82_Nu, obj.C8_83_Nu, obj.C8_91_Nu, obj.C8_92_Nu, obj.C8_93_Nu, obj.C8_94_Nu, obj.C8_95_Nu, obj.C8_96_Nu, obj.C11_17, obj.C11_21, obj.C11_22, obj.C11_23, obj.C11_24, obj.C11_25, obj.C11_26, obj.C11_31, obj.C11_32, obj.C11_33, obj.C11_34, obj.C11_35, obj.C11_36, obj.C11_41, obj.C11_42, obj.C11_43, obj.C11_44, obj.C11_51, obj.C11_52, obj.C11_53, obj.C11_54, obj.C11_61, obj.C11_62, obj.C11_63, obj.C11_71, obj.C11_72, obj.C11_73, obj.C11_74, obj.C11_75, obj.C11_81, obj.C11_82, obj.C11_83, obj.C11_91, obj.C11_92, obj.C11_93, obj.C11_94, obj.C11_95, obj.C11_96, obj.C11_17_Nu, obj.C11_21_Nu, obj.C11_22_Nu, obj.C11_23_Nu, obj.C11_24_Nu, obj.C11_25_Nu, obj.C11_26_Nu, obj.C11_31_Nu, obj.C11_32_Nu, obj.C11_33_Nu, obj.C11_34_Nu, obj.C11_35_Nu, obj.C11_36_Nu, obj.C11_41_Nu, obj.C11_42_Nu, obj.C11_43_Nu, obj.C11_44_Nu, obj.C11_51_Nu, obj.C11_52_Nu, obj.C11_53_Nu, obj.C11_54_Nu, obj.C11_61_Nu, obj.C11_62_Nu, obj.C11_63_Nu, obj.C11_71_Nu, obj.C11_72_Nu, obj.C11_73_Nu, obj.C11_74_Nu, obj.C11_75_Nu, obj.C11_81_Nu, obj.C11_82_Nu, obj.C11_83_Nu, obj.C11_91_Nu, obj.C11_92_Nu, obj.C11_93_Nu, obj.C11_94_Nu, obj.C11_95_Nu, obj.C11_96_Nu, obj.C10_LaoDong, obj.Chia_Khong_Nu, obj.Chia_BangCap_Nu, obj.Chia_DaoTao_Nu, obj.Chia_SoCap_Nu, obj.Chia_TrungCap_Nu, obj.Chia_CaoDang_Nu, obj.Chia_DaiHoc_Nu, obj.LD_GianTiep)
    End Sub
    Public Sub BC_Business_Update(PortalConnect As String, obj As BC_BusinessInfo)
        DataProvider.Instance().BC_Business_Update(PortalConnect, obj.DoanhNghiep_ID, obj.MaDoanhNghiep, obj.TenDoanhNghiep, obj.TaxCode, obj.Mobile, obj.Fax, obj.Email, obj.Website, obj.TinhTrang, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.TT_NT, obj.SoNha, obj.KhuCN_ID, obj.LoaiHinh_ID, obj.NganhNghe, obj.LD_TongSo, obj.LD_NgoaiTinh, obj.LD_TrucTiep, obj.LD_Nu, obj.LD_HD_Tong, obj.LD_HD_Nu, obj.LD_NuocNgoai_Tong, obj.LD_NuocNgoai_Nu, obj.LD_PhoThong, obj.CMKT_Khong, obj.CMKT_BangCap, obj.CMKT_DaoTao, obj.CMKT_SoCap, obj.CMKT_TrungCap, obj.CMKT_CaoDang, obj.CMKT_DaiHoc, obj.GDDT_KTXH, obj.GDDT_KHTN, obj.GDDT_KTCN, obj.GDDT_NongNghiep, obj.GDDT_YTe, obj.GDDT_Khac, obj.Nhom_LanhDao, obj.Nhom_ChuyenMon, obj.Nhom_TroLy, obj.Nhom_DichVu, obj.Nhom_NongNghiep, obj.Nhom_ThuCong, obj.Nhom_Tho, obj.Nhom_DonGian, obj.TL_BinhQuan, obj.TL_ThapNhat, obj.TL_CaoNhat, obj.Chia_Khong, obj.Chia_BangCap, obj.Chia_DaoTao, obj.Chia_SoCap, obj.Chia_TrungCap, obj.Chia_CaoDang, obj.Chia_DaiHoc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.SanPhamChinh, obj.QuyMoLaoDong, obj.LD_NgoaiTinh_Nu, obj.LD_TrucTiep_Nu, obj.LD_GianTiep_Nu, obj.LD_BHXH, obj.LD_BHXH_Nu, obj.LD_TREN35, obj.LD_TREN35_Nu, obj.LD_PhoThong_Nu, obj.VT_NhaQuanLy, obj.VT_NhaQuanLy_Nu, obj.VT_CMKT_Cao, obj.VT_CMKT_Cao_Nu, obj.VT_CMKT_Trung, obj.VT_CMKT_Trung_Nu, obj.VT_CMKT_Khac, obj.VT_CMKT_Khac_Nu, obj.CMKT_Khong_Nu, obj.CMKT_BangCap_Nu, obj.CMKT_DaoTao_Nu, obj.CMKT_SoCap_Nu, obj.CMKT_TrungCap_Nu, obj.CMKT_CaoDang_Nu, obj.CMKT_DaiHoc_Nu, obj.GDDT_KTXH_Nu, obj.GDDT_KHTN_Nu, obj.GDDT_KTCN_Nu, obj.GDDT_NongNghiep_Nu, obj.GDDT_YTe_Nu, obj.GDDT_Khac_Nu, obj.C8_17, obj.C8_21, obj.C8_22, obj.C8_23, obj.C8_24, obj.C8_25, obj.C8_26, obj.C8_31, obj.C8_32, obj.C8_33, obj.C8_34, obj.C8_35, obj.C8_36, obj.C8_41, obj.C8_42, obj.C8_43, obj.C8_44, obj.C8_51, obj.C8_52, obj.C8_53, obj.C8_54, obj.C8_61, obj.C8_62, obj.C8_63, obj.C8_71, obj.C8_72, obj.C8_73, obj.C8_74, obj.C8_75, obj.C8_81, obj.C8_82, obj.C8_83, obj.C8_91, obj.C8_92, obj.C8_93, obj.C8_94, obj.C8_95, obj.C8_96, obj.C8_17_Nu, obj.C8_21_Nu, obj.C8_22_Nu, obj.C8_23_Nu, obj.C8_24_Nu, obj.C8_25_Nu, obj.C8_26_Nu, obj.C8_31_Nu, obj.C8_32_Nu, obj.C8_33_Nu, obj.C8_34_Nu, obj.C8_35_Nu, obj.C8_36_Nu, obj.C8_41_Nu, obj.C8_42_Nu, obj.C8_43_Nu, obj.C8_44_Nu, obj.C8_51_Nu, obj.C8_52_Nu, obj.C8_53_Nu, obj.C8_54_Nu, obj.C8_61_Nu, obj.C8_62_Nu, obj.C8_63_Nu, obj.C8_71_Nu, obj.C8_72_Nu, obj.C8_73_Nu, obj.C8_74_Nu, obj.C8_75_Nu, obj.C8_81_Nu, obj.C8_82_Nu, obj.C8_83_Nu, obj.C8_91_Nu, obj.C8_92_Nu, obj.C8_93_Nu, obj.C8_94_Nu, obj.C8_95_Nu, obj.C8_96_Nu, obj.C11_17, obj.C11_21, obj.C11_22, obj.C11_23, obj.C11_24, obj.C11_25, obj.C11_26, obj.C11_31, obj.C11_32, obj.C11_33, obj.C11_34, obj.C11_35, obj.C11_36, obj.C11_41, obj.C11_42, obj.C11_43, obj.C11_44, obj.C11_51, obj.C11_52, obj.C11_53, obj.C11_54, obj.C11_61, obj.C11_62, obj.C11_63, obj.C11_71, obj.C11_72, obj.C11_73, obj.C11_74, obj.C11_75, obj.C11_81, obj.C11_82, obj.C11_83, obj.C11_91, obj.C11_92, obj.C11_93, obj.C11_94, obj.C11_95, obj.C11_96, obj.C11_17_Nu, obj.C11_21_Nu, obj.C11_22_Nu, obj.C11_23_Nu, obj.C11_24_Nu, obj.C11_25_Nu, obj.C11_26_Nu, obj.C11_31_Nu, obj.C11_32_Nu, obj.C11_33_Nu, obj.C11_34_Nu, obj.C11_35_Nu, obj.C11_36_Nu, obj.C11_41_Nu, obj.C11_42_Nu, obj.C11_43_Nu, obj.C11_44_Nu, obj.C11_51_Nu, obj.C11_52_Nu, obj.C11_53_Nu, obj.C11_54_Nu, obj.C11_61_Nu, obj.C11_62_Nu, obj.C11_63_Nu, obj.C11_71_Nu, obj.C11_72_Nu, obj.C11_73_Nu, obj.C11_74_Nu, obj.C11_75_Nu, obj.C11_81_Nu, obj.C11_82_Nu, obj.C11_83_Nu, obj.C11_91_Nu, obj.C11_92_Nu, obj.C11_93_Nu, obj.C11_94_Nu, obj.C11_95_Nu, obj.C11_96_Nu, obj.C10_LaoDong, obj.Chia_Khong_Nu, obj.Chia_BangCap_Nu, obj.Chia_DaoTao_Nu, obj.Chia_SoCap_Nu, obj.Chia_TrungCap_Nu, obj.Chia_CaoDang_Nu, obj.Chia_DaiHoc_Nu, obj.LD_GianTiep)
    End Sub
    Public Sub BC_Business_Delete(PortalConnect As String, doanhNghiep_ID As String)
        DataProvider.Instance().BC_Business_Delete(PortalConnect, doanhNghiep_ID)
    End Sub
    Public Sub BC_Business_Update_IsDelete(PortalConnect As String, doanhNghiep_ID As String, isDelete As Boolean)
        DataProvider.Instance().BC_Business_Update_IsDelete(PortalConnect, doanhNghiep_ID, isDelete)
    End Sub
    Public Sub BC_Business_Update_ByID(PortalConnect As String, obj As BC_BusinessInfo)
        DataProvider.Instance().BC_Business_Update_ByID(PortalConnect, obj.ID, obj.DoanhNghiep_ID, obj.MaDoanhNghiep, obj.TenDoanhNghiep, obj.TaxCode, obj.Mobile, obj.Fax, obj.Email, obj.Website, obj.TinhTrang, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.TT_NT, obj.SoNha, obj.KhuCN_ID, obj.LoaiHinh_ID, obj.NganhNghe, obj.LD_TongSo, obj.LD_NgoaiTinh, obj.LD_TrucTiep, obj.LD_Nu, obj.LD_HD_Tong, obj.LD_HD_Nu, obj.LD_NuocNgoai_Tong, obj.LD_NuocNgoai_Nu, obj.LD_PhoThong, obj.CMKT_Khong, obj.CMKT_BangCap, obj.CMKT_DaoTao, obj.CMKT_SoCap, obj.CMKT_TrungCap, obj.CMKT_CaoDang, obj.CMKT_DaiHoc, obj.GDDT_KTXH, obj.GDDT_KHTN, obj.GDDT_KTCN, obj.GDDT_NongNghiep, obj.GDDT_YTe, obj.GDDT_Khac, obj.Nhom_LanhDao, obj.Nhom_ChuyenMon, obj.Nhom_TroLy, obj.Nhom_DichVu, obj.Nhom_NongNghiep, obj.Nhom_ThuCong, obj.Nhom_Tho, obj.Nhom_DonGian, obj.TL_BinhQuan, obj.TL_ThapNhat, obj.TL_CaoNhat, obj.Chia_Khong, obj.Chia_BangCap, obj.Chia_DaoTao, obj.Chia_SoCap, obj.Chia_TrungCap, obj.Chia_CaoDang, obj.Chia_DaiHoc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.SanPhamChinh, obj.QuyMoLaoDong, obj.LD_NgoaiTinh_Nu, obj.LD_TrucTiep_Nu, obj.LD_GianTiep_Nu, obj.LD_BHXH, obj.LD_BHXH_Nu, obj.LD_TREN35, obj.LD_TREN35_Nu, obj.LD_PhoThong_Nu, obj.VT_NhaQuanLy, obj.VT_NhaQuanLy_Nu, obj.VT_CMKT_Cao, obj.VT_CMKT_Cao_Nu, obj.VT_CMKT_Trung, obj.VT_CMKT_Trung_Nu, obj.VT_CMKT_Khac, obj.VT_CMKT_Khac_Nu, obj.CMKT_Khong_Nu, obj.CMKT_BangCap_Nu, obj.CMKT_DaoTao_Nu, obj.CMKT_SoCap_Nu, obj.CMKT_TrungCap_Nu, obj.CMKT_CaoDang_Nu, obj.CMKT_DaiHoc_Nu, obj.GDDT_KTXH_Nu, obj.GDDT_KHTN_Nu, obj.GDDT_KTCN_Nu, obj.GDDT_NongNghiep_Nu, obj.GDDT_YTe_Nu, obj.GDDT_Khac_Nu, obj.C8_17, obj.C8_21, obj.C8_22, obj.C8_23, obj.C8_24, obj.C8_25, obj.C8_26, obj.C8_31, obj.C8_32, obj.C8_33, obj.C8_34, obj.C8_35, obj.C8_36, obj.C8_41, obj.C8_42, obj.C8_43, obj.C8_44, obj.C8_51, obj.C8_52, obj.C8_53, obj.C8_54, obj.C8_61, obj.C8_62, obj.C8_63, obj.C8_71, obj.C8_72, obj.C8_73, obj.C8_74, obj.C8_75, obj.C8_81, obj.C8_82, obj.C8_83, obj.C8_91, obj.C8_92, obj.C8_93, obj.C8_94, obj.C8_95, obj.C8_96, obj.C8_17_Nu, obj.C8_21_Nu, obj.C8_22_Nu, obj.C8_23_Nu, obj.C8_24_Nu, obj.C8_25_Nu, obj.C8_26_Nu, obj.C8_31_Nu, obj.C8_32_Nu, obj.C8_33_Nu, obj.C8_34_Nu, obj.C8_35_Nu, obj.C8_36_Nu, obj.C8_41_Nu, obj.C8_42_Nu, obj.C8_43_Nu, obj.C8_44_Nu, obj.C8_51_Nu, obj.C8_52_Nu, obj.C8_53_Nu, obj.C8_54_Nu, obj.C8_61_Nu, obj.C8_62_Nu, obj.C8_63_Nu, obj.C8_71_Nu, obj.C8_72_Nu, obj.C8_73_Nu, obj.C8_74_Nu, obj.C8_75_Nu, obj.C8_81_Nu, obj.C8_82_Nu, obj.C8_83_Nu, obj.C8_91_Nu, obj.C8_92_Nu, obj.C8_93_Nu, obj.C8_94_Nu, obj.C8_95_Nu, obj.C8_96_Nu, obj.C11_17, obj.C11_21, obj.C11_22, obj.C11_23, obj.C11_24, obj.C11_25, obj.C11_26, obj.C11_31, obj.C11_32, obj.C11_33, obj.C11_34, obj.C11_35, obj.C11_36, obj.C11_41, obj.C11_42, obj.C11_43, obj.C11_44, obj.C11_51, obj.C11_52, obj.C11_53, obj.C11_54, obj.C11_61, obj.C11_62, obj.C11_63, obj.C11_71, obj.C11_72, obj.C11_73, obj.C11_74, obj.C11_75, obj.C11_81, obj.C11_82, obj.C11_83, obj.C11_91, obj.C11_92, obj.C11_93, obj.C11_94, obj.C11_95, obj.C11_96, obj.C11_17_Nu, obj.C11_21_Nu, obj.C11_22_Nu, obj.C11_23_Nu, obj.C11_24_Nu, obj.C11_25_Nu, obj.C11_26_Nu, obj.C11_31_Nu, obj.C11_32_Nu, obj.C11_33_Nu, obj.C11_34_Nu, obj.C11_35_Nu, obj.C11_36_Nu, obj.C11_41_Nu, obj.C11_42_Nu, obj.C11_43_Nu, obj.C11_44_Nu, obj.C11_51_Nu, obj.C11_52_Nu, obj.C11_53_Nu, obj.C11_54_Nu, obj.C11_61_Nu, obj.C11_62_Nu, obj.C11_63_Nu, obj.C11_71_Nu, obj.C11_72_Nu, obj.C11_73_Nu, obj.C11_74_Nu, obj.C11_75_Nu, obj.C11_81_Nu, obj.C11_82_Nu, obj.C11_83_Nu, obj.C11_91_Nu, obj.C11_92_Nu, obj.C11_93_Nu, obj.C11_94_Nu, obj.C11_95_Nu, obj.C11_96_Nu, obj.C10_LaoDong, obj.Chia_Khong_Nu, obj.Chia_BangCap_Nu, obj.Chia_DaoTao_Nu, obj.Chia_SoCap_Nu, obj.Chia_TrungCap_Nu, obj.Chia_CaoDang_Nu, obj.Chia_DaiHoc_Nu, obj.LD_GianTiep)
    End Sub
    Public Sub BC_Business_Delete_ByID(PortalConnect As String, ID As String)
        DataProvider.Instance().BC_Business_Delete_ByID(PortalConnect, ID)
    End Sub
    Public Function BC_Business_List_PhieuDT(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List_PhieuDT(PortalConnect, isYear, isNow, tinhTP, quanHuyen, xaPhuong, trangThai, currPage, recodperpage), GetType(BC_BusinessInfo))
    End Function
    Public Function BC_Business_List_PhieuDT_DN(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, trangThai As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Business_List_PhieuDT_DN(PortalConnect, isYear, isNow, tinhTP, quanHuyen, trangThai), GetType(BC_BusinessInfo))
    End Function
#End Region
#Region "BC_LDGiam"
    Public Function BC_LDGiam_Get(PortalConnect As String, lDGiam_ID As String) As BC_LDGiamInfo
        Return CBO.FillObject(Of BC_LDGiamInfo)(DataProvider.Instance().BC_LDGiam_Get(PortalConnect, lDGiam_ID))
    End Function
    Public Function BC_LDGiam_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDGiam_List(PortalConnect, portalId), GetType(BC_LDGiamInfo))
    End Function
    Public Function BC_LDGiam_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDGiam_Get_By_BC_ThongBao(PortalConnect, thongBao_ID), GetType(BC_LDGiamInfo))
    End Function

    Public Sub BC_LDGiam_Add(PortalConnect As String, obj As BC_LDGiamInfo)
        DataProvider.Instance().BC_LDGiam_Add(PortalConnect, obj.IsOrder, obj.LDGiam_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.NgayChamDut, obj.BHTN, obj.LD_NghiHuu, obj.LD_DonPhuong, obj.LD_CoCau, obj.LD_ChamDut, obj.LD_Khac, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDGiam_Update(PortalConnect As String, obj As BC_LDGiamInfo)
        DataProvider.Instance().BC_LDGiam_Update(PortalConnect, obj.LDGiam_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.NgayChamDut, obj.LD_NghiHuu, obj.LD_DonPhuong, obj.LD_CoCau, obj.LD_ChamDut, obj.LD_Khac, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDGiam_Delete(PortalConnect As String, lDGiam_ID As String)
        DataProvider.Instance().BC_LDGiam_Delete(PortalConnect, lDGiam_ID)
    End Sub
    Public Sub BC_LDGiam_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_LDGiam_Delete_By_BC_ThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_LDGiam_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
        DataProvider.Instance().BC_LDGiam_NopThongBao(PortalConnect, thongBao_ID, ngayNop)
    End Sub
#End Region
#Region "BC_LDHoan"
    Public Function BC_LDHoan_Get(PortalConnect As String, lDHoan_ID As String) As BC_LDHoanInfo
        Return CBO.FillObject(Of BC_LDHoanInfo)(DataProvider.Instance().BC_LDHoan_Get(PortalConnect, lDHoan_ID))
    End Function
    Public Function BC_LDHoan_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDHoan_List(PortalConnect, portalId), GetType(BC_LDHoanInfo))
    End Function
    Public Function BC_LDHoan_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDHoan_Get_By_BC_ThongBao(PortalConnect, thongBao_ID), GetType(BC_LDHoanInfo))
    End Function
    Public Sub BC_LDHoan_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_LDHoan_Delete_By_BC_ThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_LDHoan_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
        DataProvider.Instance().BC_LDHoan_NopThongBao(PortalConnect, thongBao_ID, ngayNop)
    End Sub

    Public Sub BC_LDHoan_Add(PortalConnect As String, obj As BC_LDHoanInfo)
        DataProvider.Instance().BC_LDHoan_Add(PortalConnect, obj.IsOrder, obj.LDHoan_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.BHTN, obj.HoanTu, obj.HoanDen, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDHoan_Update(PortalConnect As String, obj As BC_LDHoanInfo)
        DataProvider.Instance().BC_LDHoan_Update(PortalConnect, obj.LDHoan_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.BHTN, obj.HoanTu, obj.HoanDen, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDHoan_Delete(PortalConnect As String, lDHoan_ID As String)
        DataProvider.Instance().BC_LDHoan_Delete(PortalConnect, lDHoan_ID)
    End Sub
#End Region
#Region "BC_LDTang"
    Public Function BC_LDTang_Get(PortalConnect As String, lDTang_ID As String) As BC_LDTangInfo
        Return CBO.FillObject(Of BC_LDTangInfo)(DataProvider.Instance().BC_LDTang_Get(PortalConnect, lDTang_ID))
    End Function
    Public Function BC_LDTang_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDTang_List(PortalConnect, portalId), GetType(BC_LDTangInfo))
    End Function
    Public Function BC_LDTang_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_LDTang_Get_By_BC_ThongBao(PortalConnect, thongBao_ID), GetType(BC_LDTangInfo))
    End Function

    Public Sub BC_LDTang_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_LDTang_Delete_By_BC_ThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_LDTang_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
        DataProvider.Instance().BC_LDTang_NopThongBao(PortalConnect, thongBao_ID, ngayNop)
    End Sub
    Public Sub BC_LDTang_Add(PortalConnect As String, obj As BC_LDTangInfo)
        DataProvider.Instance().BC_LDTang_Add(PortalConnect, obj.IsOrder, obj.LDTang_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.ViTri, obj.BHTN, obj.TG_BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDTang_Update(PortalConnect As String, obj As BC_LDTangInfo)
        DataProvider.Instance().BC_LDTang_Update(PortalConnect, obj.LDTang_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.ViTri, obj.BHTN, obj.TG_BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_LDTang_Delete(PortalConnect As String, lDTang_ID As String)
        DataProvider.Instance().BC_LDTang_Delete(PortalConnect, lDTang_ID)
    End Sub
#End Region
#Region "BC_TBCuoiKy"
    Public Function BC_TBCuoiKy_Get(PortalConnect As String, tBCuoiKy_ID As String) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_TBCuoiKy_Get(PortalConnect, tBCuoiKy_ID))
    End Function
    Public Function BC_TBCuoiKy_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_TBCuoiKy_List(PortalConnect, portalId), GetType(BC_TBCuoiKyInfo))
    End Function
    Public Function BC_TBCuoiKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_TBCuoiKy_Get_By_BC_ThongBao(PortalConnect, thongBao_ID), GetType(BC_TBCuoiKyInfo))
    End Function
    Public Sub BC_TBCuoiKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_TBCuoiKy_Delete_By_BC_ThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_TBCuoiKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
        DataProvider.Instance().BC_TBCuoiKy_NopThongBao(PortalConnect, thongBao_ID, ngayNop)
    End Sub
    Public Sub BC_TBCuoiKy_Add(PortalConnect As String, obj As BC_TBCuoiKyInfo)
        DataProvider.Instance().BC_TBCuoiKy_Add(PortalConnect, obj.IsOrder, obj.TBCuoiKy_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.ThoiDiem, obj.TongSoLD, obj.TongSoNu, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_TBCuoiKy_Update(PortalConnect As String, obj As BC_TBCuoiKyInfo)
        DataProvider.Instance().BC_TBCuoiKy_Update(PortalConnect, obj.TBCuoiKy_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.ThoiDiem, obj.TongSoLD, obj.TongSoNu, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_TBCuoiKy_Delete(PortalConnect As String, tBCuoiKy_ID As String)
        DataProvider.Instance().BC_TBCuoiKy_Delete(PortalConnect, tBCuoiKy_ID)
    End Sub
#End Region
#Region "BC_TBDauKy"
    Public Function BC_TBDauKy_Get(PortalConnect As String, tBDauKy_ID As String) As BC_TBDauKyInfo
        Return CBO.FillObject(Of BC_TBDauKyInfo)(DataProvider.Instance().BC_TBDauKy_Get(PortalConnect, tBDauKy_ID))
    End Function
    Public Function BC_TBDauKy_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_TBDauKy_List(PortalConnect, portalId), GetType(BC_TBDauKyInfo))
    End Function
    Public Function BC_TBDauKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_TBDauKy_Get_By_BC_ThongBao(PortalConnect, thongBao_ID), GetType(BC_TBDauKyInfo))
    End Function
    Public Sub BC_TBDauKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_TBDauKy_Delete_By_BC_ThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_TBDauKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
        DataProvider.Instance().BC_TBDauKy_NopThongBao(PortalConnect, thongBao_ID, ngayNop)
    End Sub
    Public Sub BC_TBDauKy_Add(PortalConnect As String, obj As BC_TBDauKyInfo)
        DataProvider.Instance().BC_TBDauKy_Add(PortalConnect, obj.IsOrder, obj.TBDauKy_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.ViTri, obj.BHTN, obj.TG_BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_TBDauKy_Update(PortalConnect As String, obj As BC_TBDauKyInfo)
        DataProvider.Instance().BC_TBDauKy_Update(PortalConnect, obj.TBDauKy_ID, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.NgayNop, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.CMND, obj.BHXH, obj.CNKT, obj.CCN, obj.SoCap, obj.TrungCap, obj.CaoDang, obj.DaiHoc, obj.HD_0T, obj.HD_36T, obj.HD_12T, obj.HD_3T, obj.NgayHD, obj.ViTri, obj.BHTN, obj.TG_BHTN, obj.TrangThai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub BC_TBDauKy_Delete(PortalConnect As String, tBDauKy_ID As String)
        DataProvider.Instance().BC_TBDauKy_Delete(PortalConnect, tBDauKy_ID)
    End Sub
#End Region
#Region "BC_ThongBao"
    Public Function BC_ThongBao_List_QuanHuyen(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_ThongBao_List_QuanHuyen(PortalConnect, tinh, huyen, nambc, kybc), GetType(BC_ThongBaoInfo))
    End Function
    Public Function BC_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_TBCuoiKy_TongHop(PortalConnect, QuanHuyen, nambc, kybc, ThoiDiem))
    End Function
    Public Function RUN_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().RUN_TBCuoiKy_TongHop(PortalConnect, QuanHuyen, nambc, kybc, ThoiDiem))
    End Function
    Public Function BC_TBDauKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_TBDauKy_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function BC_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_LDTang_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function RUN_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().RUN_LDTang_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function

    Public Function BC_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_LDGiam_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function RUN_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().RUN_LDGiam_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function BC_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().BC_LDHoan_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function RUN_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As BC_TBCuoiKyInfo
        Return CBO.FillObject(Of BC_TBCuoiKyInfo)(DataProvider.Instance().RUN_LDHoan_TongHop(PortalConnect, QuanHuyen, nambc, kybc))
    End Function
    Public Function BC_ThongBao_List_DoanhNghiep(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_ThongBao_List_DoanhNghiep(PortalConnect, tinh, huyen, nambc, kybc, currPage, recodperpage, txtSearch), GetType(BC_ThongBaoInfo))
    End Function
    Public Function BC_ThongBao_List_ChuaTB(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_ThongBao_List_ChuaTB(PortalConnect, tinh, huyen, nambc, kybc, currPage, recodperpage, txtSearch), GetType(BC_BusinessInfo))
    End Function
    Public Function BC_ThongBao_Get_TinhTrang(PortalConnect As String, thongBao_ID As String, baoCaoID As Integer) As BC_NoiDungInfo
        Return CBO.FillObject(Of BC_NoiDungInfo)(DataProvider.Instance().BC_ThongBao_Get_TinhTrang(PortalConnect, thongBao_ID, baoCaoID))
    End Function
    Public Function BC_ThongBao_Get(PortalConnect As String, thongBao_ID As String) As BC_ThongBaoInfo
        Return CBO.FillObject(Of BC_ThongBaoInfo)(DataProvider.Instance().BC_ThongBao_Get(PortalConnect, thongBao_ID))
    End Function
    Public Function BC_ThongBao_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_ThongBao_List(PortalConnect, portalId), GetType(BC_ThongBaoInfo))
    End Function
    Public Function BC_ThongBao_Get_By_BC_Business(PortalConnect As String, doanhNghiep_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_ThongBao_Get_By_BC_Business(PortalConnect, doanhNghiep_ID), GetType(BC_ThongBaoInfo))
    End Function
    Public Sub BC_ThongBao_NopThongBao(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_ThongBao_NopThongBao(PortalConnect, thongBao_ID)
    End Sub
    Public Sub BC_ThongBao_Add(PortalConnect As String, obj As BC_ThongBaoInfo)
        DataProvider.Instance().BC_ThongBao_Add(PortalConnect, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.Business_Vn, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.TT_NT, obj.SoNha, obj.NgayThongBao, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.Years_ID, obj.Period_ID)
    End Sub
    Public Sub BC_ThongBao_Update(PortalConnect As String, obj As BC_ThongBaoInfo)
        DataProvider.Instance().BC_ThongBao_Update(PortalConnect, obj.ThongBao_ID, obj.DoanhNghiep_ID, obj.Business_Vn, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.TT_NT, obj.SoNha, obj.NgayThongBao, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.Years_ID, obj.Period_ID)
    End Sub
    Public Sub BC_ThongBao_Delete(PortalConnect As String, thongBao_ID As String)
        DataProvider.Instance().BC_ThongBao_Delete(PortalConnect, thongBao_ID)
    End Sub
#End Region
#Region "BC_Career"
    Public Function BC_Career_Get(PortalConnect As String, Career_ID As Integer) As BC_CareerInfo
        Return CBO.FillObject(Of BC_CareerInfo)(DataProvider.Instance().BC_Career_Get(PortalConnect, Career_ID))
    End Function
    Public Function BC_Career_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_List(PortalConnect, portalId), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_Parent_Search_Null(PortalConnect, search, isOrder), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_List_Parent_Null(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_List_Parent_Null(PortalConnect), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_Get_By_BC_Career(PortalConnect As String, Career_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_Career_Get_By_BC_Career(PortalConnect, Career_ID), GetType(BC_CareerInfo))
    End Function
    Public Function BC_Career_Add(PortalConnect As String, obj As BC_CareerInfo) As Integer
        Return DataProvider.Instance().BC_Career_Add(PortalConnect, obj)
    End Function
    Public Sub BC_Career_Update(PortalConnect As String, obj As BC_CareerInfo)
        DataProvider.Instance().BC_Career_Update(PortalConnect, obj)
    End Sub
    Public Sub BC_Career_Delete(PortalConnect As String, Career_ID As Integer)
        DataProvider.Instance().BC_Career_Delete(PortalConnect, Career_ID)
    End Sub
#End Region
#Region "BC_IndustrialZone"

    Public Function BC_IndustrialZone_Get(PortalConnect As String, industrialZone_ID As String) As BC_IndustrialZoneInfo
        Return CBO.FillObject(Of BC_IndustrialZoneInfo)(DataProvider.Instance().BC_IndustrialZone_Get(PortalConnect, industrialZone_ID))
    End Function
    Public Function BC_IndustrialZone_List(PortalConnect As String, parentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_IndustrialZone_List(PortalConnect, parentId), GetType(BC_IndustrialZoneInfo))
    End Function
    Public Function BC_IndustrialZone_List_ByTP(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, parentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_IndustrialZone_List_ByTP(PortalConnect, tinhTp, quanHuyen, parentId), GetType(BC_IndustrialZoneInfo))
    End Function
    Public Function BC_IndustrialZone_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_IndustrialZone_List_Search(PortalConnect, search, isOrder, parent_ID, currPage, recodperpage), GetType(BC_IndustrialZoneInfo))
    End Function

    Public Sub BC_IndustrialZone_Add(PortalConnect As String, obj As BC_IndustrialZoneInfo)
        DataProvider.Instance().BC_IndustrialZone_Add(PortalConnect, obj.IndustrialZone_ID, obj.TinhTP, obj.QuanHuyen, obj.IndustrialZone_Name, obj.IndustrialZone_Code, obj.IndustrialZone_Des, obj.Parent_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub

    Public Sub BC_IndustrialZone_Update(PortalConnect As String, obj As BC_IndustrialZoneInfo)
        DataProvider.Instance().BC_IndustrialZone_Update(PortalConnect, obj.IndustrialZone_ID, obj.TinhTP, obj.QuanHuyen, obj.IndustrialZone_Name, obj.IndustrialZone_Code, obj.IndustrialZone_Des, obj.Parent_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub BC_IndustrialZone_Delete(PortalConnect As String, industrialZone_ID As String)
        DataProvider.Instance().BC_IndustrialZone_Delete(PortalConnect, industrialZone_ID)
    End Sub
    Public Sub BC_IndustrialZone_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().BC_IndustrialZone_Update_Quick(PortalConnect, industrialZone_ID, isActive, isOrder)
    End Sub
#End Region
#Region "BC_SendMail"
    Public Sub BC_Business_Update_SendMail(PortalConnect As String, TuNgay As DateTime, denNgay As DateTime, tinhTP As String, PortalID As Integer)
        DataProvider.Instance().BC_Business_Update_SendMail(PortalConnect, TuNgay, denNgay, tinhTP, PortalID)
    End Sub
    Public Function BC_SendMail_List_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As BC_SendMailInfo
        Return CBO.FillObject(Of BC_SendMailInfo)(DataProvider.Instance().BC_SendMail_List_Years(PortalConnect, TinhTP, portalId))
    End Function
    Public Function BC_SendMail_Send_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As BC_SendMailInfo
        Return CBO.FillObject(Of BC_SendMailInfo)(DataProvider.Instance().BC_SendMail_Send_Years(PortalConnect, TinhTP, portalId))
    End Function
    Public Function BC_SendMail_Get(PortalConnect As String, iD As String) As BC_SendMailInfo
        Return CBO.FillObject(Of BC_SendMailInfo)(DataProvider.Instance().BC_SendMail_Get(PortalConnect, iD))
    End Function
    Public Function BC_SendMail_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_SendMail_List(PortalConnect, portalId), GetType(BC_SendMailInfo))
    End Function
    Public Function BC_SendMail_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, TinhTP As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_SendMail_List_Search(PortalConnect, currPage, recodperpage, TinhTP), GetType(BC_SendMailInfo))
    End Function
    Public Function BC_SendMail_Get_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_SendMail_Get_Years(PortalConnect, TinhTP, portalId), GetType(BC_SendMailInfo))
    End Function
    Public Sub BC_SendMail_Add(PortalConnect As String, obj As BC_SendMailInfo)
        DataProvider.Instance().BC_SendMail_Add(PortalConnect, obj)
    End Sub
    Public Sub BC_SendMail_Update(PortalConnect As String, obj As BC_SendMailInfo)
        DataProvider.Instance().BC_SendMail_Update(PortalConnect, obj)
    End Sub
    Public Sub BC_SendMail_Update_Active(PortalConnect As String, TinhTP As String, Years_ID As Integer, PortalID As Integer, UpdateUser As String)
        DataProvider.Instance().BC_SendMail_Update_Active(PortalConnect, TinhTP, Years_ID, PortalID, UpdateUser)
    End Sub
    Public Sub BC_SendMail_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().BC_SendMail_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "BC_Backup"
    Public Function BC_Business_Backup_Get_Years(PortalConnect As String, doanhNghiep_ID As String, Years As Integer) As BC_BusinessInfo
        Return CBO.FillObject(Of BC_BusinessInfo)(DataProvider.Instance().BC_Business_Backup_Get_Years(PortalConnect, doanhNghiep_ID, Years))
    End Function
    Public Function BC_Backup_Get_TinhTP_Years(PortalConnect As String, TinhTP As String, Years As Integer) As BC_BackupInfo
        Return CBO.FillObject(Of BC_BackupInfo)(DataProvider.Instance().BC_Backup_Get_TinhTP_Years(PortalConnect, TinhTP, Years))
    End Function
    Public Sub BC_Backup_Add(PortalConnect As String, obj As BC_BackupInfo)
        DataProvider.Instance().BC_Backup_Add(PortalConnect, obj)
    End Sub
    Public Sub BC_Business_Backup_Add(PortalConnect As String, TinhTP As String, isYears As Integer)
        DataProvider.Instance().BC_Business_Backup_Add(PortalConnect, TinhTP, isYears)
    End Sub
    Public Sub RPT_TongHop_SoLieu(PortalConnect As String, TinhTP As String, Years As Integer, Code As String)
        DataProvider.Instance().RPT_TongHop_SoLieu(PortalConnect, TinhTP, Years, Code)
    End Sub

#End Region
#Region "BC_CAULD"
    Public Function BC_CauLD_Mau_04_KyTruoc(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_CauLD_Mau_04_KyTruoc(PortalConnect, TinhTP, PhuongXa, IsYears), GetType(BC_BusinessInfo))
    End Function
    Public Function BC_CauLD_Mau_04_KyBC(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_CauLD_Mau_04_KyBC(PortalConnect, TinhTP, PhuongXa, IsYears), GetType(BC_BusinessInfo))
    End Function
    Public Function RPT_Run_DN01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN01A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN02A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN03A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN04A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN05A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN06A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN07A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_DN08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_DN08A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD01A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD02A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD03A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD04A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD05A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD06A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD07A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD08A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD09A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD09A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD10A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD10A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD11A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD11A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD12A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD12A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD13A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD13A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD14A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD14A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD15A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD15A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD16A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD16A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD17A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD17A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD18A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD18A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD19A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD19A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD20A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD20A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
	Public Function RPT_Run_NLD21A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD21A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function
    Public Function RPT_Run_NLD22A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD22A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
    End Function
    Public Function RPT_Run_NLD23A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD23A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
    End Function
    Public Function RPT_Run_NLD24A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD24A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
    End Function
    Public Function RPT_Run_NLD25A(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Run_NLD25A(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
    End Function
    Public Function RPT_Run_THBienDong(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Run_THBienDong(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
    End Function
    Public Function RPT_Run_TT271(PortalConnect As String, TinhTP As String, IsYears As Integer) As ArrayList
		Return CBO.FillCollection(DataProvider.Instance().RPT_Run_TT271(PortalConnect, TinhTP, IsYears), GetType(Rpt_CauInfo))
	End Function

#End Region
#Region "BC_CompanyType"
    Public Function BC_CompanyType_Get(PortalConnect As String, iD As Integer) As BC_CompanyTypeInfo
        Return CBO.FillObject(Of BC_CompanyTypeInfo)(DataProvider.Instance().BC_CompanyType_Get(PortalConnect, iD))
    End Function
    Public Function BC_CompanyType_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_CompanyType_List(PortalConnect), GetType(BC_CompanyTypeInfo))
    End Function


    Public Function BC_CompanyType_Add(PortalConnect As String, obj As BC_CompanyTypeInfo) As Integer
        Return DataProvider.Instance().BC_CompanyType_Add(PortalConnect, obj)
    End Function
    Public Sub BC_CompanyType_Update(PortalConnect As String, obj As BC_CompanyTypeInfo)
        DataProvider.Instance().BC_CompanyType_Update(PortalConnect, obj)
    End Sub
    Public Sub BC_CompanyType_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().BC_CompanyType_Delete(PortalConnect, iD)
    End Sub

#End Region
#Region "BC_PhieuDT"
    Public Function BC_PhieuDT_Get(PortalConnect As String, iD As Integer) As BC_PhieuDTInfo
        Return CBO.FillObject(Of BC_PhieuDTInfo)(DataProvider.Instance().BC_PhieuDT_Get(PortalConnect, iD))
    End Function
    Public Function BC_PhieuDT_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_PhieuDT_List(PortalConnect), GetType(BC_PhieuDTInfo))
    End Function
    Public Function BC_PhieuDT_List_Search(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BC_PhieuDT_List_Search(PortalConnect, isYear, tinhTP, quanHuyen), GetType(BC_PhieuDTInfo))
    End Function
    Public Function BC_PhieuDT_Add(PortalConnect As String, obj As BC_PhieuDTInfo) As Integer
        Return DataProvider.Instance().BC_PhieuDT_Add(PortalConnect, obj)
    End Function
    Public Sub BC_PhieuDT_Update(PortalConnect As String, obj As BC_PhieuDTInfo)
        DataProvider.Instance().BC_PhieuDT_Update(PortalConnect, obj)
    End Sub
    Public Sub BC_PhieuDT_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().BC_PhieuDT_Delete(PortalConnect, iD)
    End Sub
    Public Sub BC_PhieuDT_Refresh(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer)
        DataProvider.Instance().BC_PhieuDT_Refresh(PortalConnect, isYear, tinhTP, quanHuyen)
    End Sub
#End Region
#Region "TH27_M02_A"
    Public Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
        DataProvider.Instance().RPT_TH27_M02_A_RUN(PortalConnect, m01ID, years, tinhTP, quanHuyen)
    End Sub
    Public Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_A_Get_By_TH27_M02(PortalConnect, iD), GetType(TH27_M02_AInfo))
    End Function
    Public Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M02_A_Delete_By_TH27_M02(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M02_B"
    Public Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
        DataProvider.Instance().RPT_TH27_M02_B_RUN(PortalConnect, m02ID, sTT, tinhTP, quanHuyen, xaPhuong, tenXaPhuong, years)
    End Sub
    Public Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_B_Get_By_TH27_M02(PortalConnect, iD), GetType(TH27_M02_BInfo))
    End Function
    Public Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M02_B_Delete_By_TH27_M02(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M03_A"
    Public Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer)
        DataProvider.Instance().RPT_TH27_M03_A_RUN(PortalConnect, m01ID, years, tinhTP)
    End Sub
    Public Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_A_Get_By_TH27_M03(PortalConnect, iD), GetType(TH27_M03_AInfo))
    End Function
    Public Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M03_A_Delete_By_TH27_M03(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M03_B"
    Public Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
        DataProvider.Instance().RPT_TH27_M03_B_RUN(PortalConnect, m02ID, sTT, tinhTP, quanHuyen, tenQuanHuyen, years)
    End Sub
    Public Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_B_Get_By_TH27_M03(PortalConnect, iD), GetType(TH27_M03_BInfo))
    End Function
    Public Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M03_B_Delete_By_TH27_M03(PortalConnect, iD)
    End Sub
#End Region
#Region "API"
    Public Function API_CAULD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, kcn As String, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_CAULD_01(PortalConnect, tp, qh, xp, kcn, year, isNow), GetType(apiBusinessInfo))
    End Function
    Public Function API_CAULD_02(PortalConnect As String, tp As Integer, mst As String, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_CAULD_02(PortalConnect, tp, mst, year, isNow), GetType(apiBusinessInfo))
    End Function
#End Region

#Region "REPORT CHART"

    Public Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As ChartInfo
        Return CBO.FillObject(Of ChartInfo)(DataProvider.Instance().CMS_Chart_Data(tpConnect, tp, qh, xp, year, isNow, maBC))
    End Function
    Public Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chart_DataHC(tpConnect, tp, qh, ids, year, isNow, maBC), GetType(ChartInfo))
    End Function
    Public Function ThongKe_DN_TheoTinhTrang(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, Key As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ThongKe_DN_TheoTinhTrang(PhuongXa, TrangThai, KyDuLieu, Key), GetType(ThongKeInfo))
    End Function
    Public Function ThongKe_DN_TheoNguoiNhapTin(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ThongKe_DN_TheoNguoiNhapTin(PhuongXa, TrangThai, KyDuLieu, UserName), GetType(ThongKeInfo))
    End Function


#End Region
End Class
