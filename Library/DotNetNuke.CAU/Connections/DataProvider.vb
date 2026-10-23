Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.CAU", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "BC_Business"

    Public MustOverride Function BC_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As IDataReader
    Public MustOverride Function BC_CauLD_List_By_Flag(PortalConnect As String, isFlag As Integer) As IDataReader
    Public MustOverride Sub BC_Business_Update_TbGui(PortalConnect As String, DoanhNghiep_ID As String, tbGui As Boolean)
    Public MustOverride Sub BC_Business_Update_Tbao(PortalConnect As String, DoanhNghiep_ID As String, tuNgay As DateTime, denNgay As DateTime)
    Public MustOverride Function BC_Business_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, XaPhuong As String, ThonTo As String, KCN As String, TrangThai As Integer, Year As Integer, NganhNghe As Integer, IsDelete As Boolean) As IDataReader
    Public MustOverride Function BC_Business_List_XuatSo(PortalConnect As String, TinhTP As String, QuanHuyen As String, XaPhuong As String, Year As Integer) As IDataReader
    Public MustOverride Function BC_Business_List_Tbao(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, TrangThai As Integer) As IDataReader
    Public MustOverride Function BC_Business_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
    Public MustOverride Function BC_Business_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_Business_Add(PortalConnect As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, cMKT_CapDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, chia_CapDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
    Public MustOverride Sub BC_Business_Update(PortalConnect As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, cMKT_CapDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, chia_CapDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
    Public MustOverride Sub BC_Business_Delete(PortalConnect As String, doanhNghiep_ID As String)
    Public MustOverride Sub BC_Business_Update_IsDelete(PortalConnect As String, doanhNghiep_ID As String, isDelete As Boolean)
    Public MustOverride Sub BC_Business_Update_ByID(PortalConnect As String, ID As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, cMKT_CapDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, chia_CapDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
    Public MustOverride Sub BC_Business_Delete_ByID(PortalConnect As String, ID As String)
    Public MustOverride Function BC_Business_Check_Code(PortalConnect As String, tinhTP As String, quanHuyen As String, xaPhuong As String) As Integer
    Public MustOverride Function BC_Business_List_PhieuDT(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function BC_Business_List_PhieuDT_DN(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, trangThai As Integer) As IDataReader
#End Region
#Region "BC_LDGiam"
    Public MustOverride Function BC_LDGiam_Get(PortalConnect As String, lDGiam_ID As String) As IDataReader
    Public MustOverride Function BC_LDGiam_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_LDGiam_Add(PortalConnect As String, IsOrder As Integer, lDGiam_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, ngayChamDut As DateTime, BHTN As Boolean, lD_NghiHuu As Boolean, lD_DonPhuong As Boolean, lD_CoCau As Boolean, lD_ChamDut As Boolean, lD_Khac As Boolean, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub BC_LDGiam_Update(PortalConnect As String, lDGiam_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, ngayChamDut As DateTime, lD_NghiHuu As Boolean, lD_DonPhuong As Boolean, lD_CoCau As Boolean, lD_ChamDut As Boolean, lD_Khac As Boolean, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Function BC_LDGiam_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Sub BC_LDGiam_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_LDGiam_Delete(PortalConnect As String, lDGiam_ID As String)
    Public MustOverride Sub BC_LDGiam_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
#End Region
#Region "BC_LDHoan"
    Public MustOverride Function BC_LDHoan_Get(PortalConnect As String, lDHoan_ID As String) As IDataReader
    Public MustOverride Function BC_LDHoan_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_LDHoan_Add(PortalConnect As String, IsOrder As Integer, lDHoan_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, bHTN As Boolean, hoanTu As DateTime, hoanDen As DateTime, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub BC_LDHoan_Update(PortalConnect As String, lDHoan_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, bHTN As Boolean, hoanTu As DateTime, hoanDen As DateTime, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Function BC_LDHoan_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Sub BC_LDHoan_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_LDHoan_Delete(PortalConnect As String, lDHoan_ID As String)
    Public MustOverride Sub BC_LDHoan_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
#End Region
#Region "BC_LDTang"
    Public MustOverride Function BC_LDTang_Get(PortalConnect As String, lDTang_ID As String) As IDataReader
    Public MustOverride Function BC_LDTang_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_LDTang_Add(PortalConnect As String, IsOrder As Integer, lDTang_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub BC_LDTang_Update(PortalConnect As String, lDTang_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Function BC_LDTang_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Sub BC_LDTang_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_LDTang_Delete(PortalConnect As String, lDTang_ID As String)
    Public MustOverride Sub BC_LDTang_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
#End Region
#Region "BC_TBCuoiKy"
    Public MustOverride Function BC_TBCuoiKy_Get(PortalConnect As String, tBCuoiKy_ID As String) As IDataReader
    Public MustOverride Function BC_TBCuoiKy_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_TBCuoiKy_Add(PortalConnect As String, IsOrder As Integer, tBCuoiKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, thoiDiem As String, tongSoLD As Integer, tongSoNu As Integer, cNKT As Integer, cCN As Integer, soCap As Integer, trungCap As Integer, caoDang As Integer, daiHoc As Integer, hD_0T As Integer, hD_36T As Integer, hD_12T As Integer, hD_3T As Integer, bHTN As Integer, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub BC_TBCuoiKy_Update(PortalConnect As String, tBCuoiKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, thoiDiem As String, tongSoLD As Integer, tongSoNu As Integer, cNKT As Integer, cCN As Integer, soCap As Integer, trungCap As Integer, caoDang As Integer, daiHoc As Integer, hD_0T As Integer, hD_36T As Integer, hD_12T As Integer, hD_3T As Integer, bHTN As Integer, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Function BC_TBCuoiKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Sub BC_TBCuoiKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_TBCuoiKy_Delete(PortalConnect As String, tBCuoiKy_ID As String)
    Public MustOverride Sub BC_TBCuoiKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
#End Region
#Region "BC_TBDauKy"
    Public MustOverride Function BC_TBDauKy_Get(PortalConnect As String, tBDauKy_ID As String) As IDataReader
    Public MustOverride Function BC_TBDauKy_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_TBDauKy_Add(PortalConnect As String, IsOrder As Integer, tBDauKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub BC_TBDauKy_Update(PortalConnect As String, tBDauKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Function BC_TBDauKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Sub BC_TBDauKy_Delete(PortalConnect As String, tBDauKy_ID As String)
    Public MustOverride Sub BC_TBDauKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_TBDauKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
#End Region
#Region "BC_ThongBao"

    Public MustOverride Function BC_ThongBao_List_QuanHuyen(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function BC_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As IDataReader
    Public MustOverride Function RUN_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As IDataReader
    Public MustOverride Function BC_ThongBao_List_DoanhNghiep(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As IDataReader
    Public MustOverride Function BC_ThongBao_List_ChuaTB(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As IDataReader
    Public MustOverride Function BC_TBDauKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function BC_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function RUN_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function BC_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function RUN_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function BC_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function RUN_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
    Public MustOverride Function BC_ThongBao_Get_TinhTrang(PortalConnect As String, thongBao_ID As String, baoCaoID As Integer) As IDataReader
    Public MustOverride Function BC_ThongBao_Get(PortalConnect As String, thongBao_ID As String) As IDataReader
    Public MustOverride Function BC_ThongBao_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_ThongBao_Add(PortalConnect As String, thongBao_ID As String, doanhNghiep_ID As String, business_Vn As String, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, ngayThongBao As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, Years_ID As Integer, Period_ID As Integer)
    Public MustOverride Sub BC_ThongBao_Update(PortalConnect As String, thongBao_ID As String, doanhNghiep_ID As String, business_Vn As String, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, ngayThongBao As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, Years_ID As Integer, Period_ID As Integer)
    Public MustOverride Function BC_ThongBao_Get_By_BC_Business(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
    Public MustOverride Sub BC_ThongBao_Delete(PortalConnect As String, thongBao_ID As String)
    Public MustOverride Sub BC_ThongBao_NopThongBao(PortalConnect As String, thongBao_ID As String)
#End Region
#Region "BC_IndustrialZone"

    Public MustOverride Function BC_IndustrialZone_Get(PortalConnect As String, industrialZone_ID As String) As IDataReader
    Public MustOverride Function BC_IndustrialZone_List(PortalConnect As String, parentId As String) As IDataReader
    Public MustOverride Function BC_IndustrialZone_List_ByTP(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, parentId As String) As IDataReader
    Public MustOverride Function BC_IndustrialZone_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub BC_IndustrialZone_Add(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub BC_IndustrialZone_Update(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub BC_IndustrialZone_Delete(PortalConnect As String, industrialZone_ID As String)
    Public MustOverride Sub BC_IndustrialZone_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)

#End Region
#Region "BC_Career"
    Public MustOverride Function BC_Career_Get(PortalConnect As String, Career_ID As Integer) As IDataReader
    Public MustOverride Function BC_Career_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function BC_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function BC_Career_List_Parent_Null(PortalConnect As String) As IDataReader
    Public MustOverride Function BC_Career_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
    Public MustOverride Function BC_Career_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function BC_Career_Get_By_BC_Career(PortalConnect As String, Career_ID As Integer) As IDataReader
    Public MustOverride Function BC_Career_Add(PortalConnect As String, obj As BC_CareerInfo) As Integer
    Public MustOverride Sub BC_Career_Update(PortalConnect As String, obj As BC_CareerInfo)
    Public MustOverride Sub BC_Career_Delete(PortalConnect As String, Career_ID As Integer)
#End Region
#Region "BC_SendMail"
    Public MustOverride Sub BC_Business_Update_SendMail(PortalConnect As String, TuNgay As DateTime, denNgay As DateTime, tinhTP As String, PortalID As Integer)
    Public MustOverride Function BC_SendMail_List_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As IDataReader
    Public MustOverride Function BC_SendMail_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function BC_SendMail_Get_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As IDataReader
    Public MustOverride Function BC_SendMail_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, TinhTP As String) As IDataReader
    Public MustOverride Function BC_SendMail_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub BC_SendMail_Add(PortalConnect As String, obj As BC_SendMailInfo)
    Public MustOverride Sub BC_SendMail_Update_Active(PortalConnect As String, TinhTP As String, Years_ID As Integer, PortalID As Integer, UpdateUser As String)
    Public MustOverride Sub BC_SendMail_Update(PortalConnect As String, obj As BC_SendMailInfo)
    Public MustOverride Sub BC_SendMail_Delete(PortalConnect As String, iD As String)
    Public MustOverride Function BC_SendMail_Send_Years(PortalConnect As String, TinhTP As String, PortalId As Integer) As IDataReader

#End Region
#Region "BC_Backup"
    Public MustOverride Function BC_Backup_Get_TinhTP_Years(PortalConnect As String, TinhTP As String, Years As Integer) As IDataReader
    Public MustOverride Function BC_Business_Backup_Get_Years(PortalConnect As String, doanhNghiep_ID As String, Years As Integer) As IDataReader
    Public MustOverride Sub BC_Backup_Add(PortalConnect As String, obj As BC_BackupInfo)
    Public MustOverride Sub BC_Business_Backup_Add(PortalConnect As String, TinhTP As String, Years As Integer)
    Public MustOverride Sub RPT_TongHop_SoLieu(PortalConnect As String, TinhTP As String, Years As Integer, Code As String)

#End Region
#Region "BC_CAULD"
    Public MustOverride Function BC_CauLD_Mau_04_KyTruoc(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As IDataReader
    Public MustOverride Function BC_CauLD_Mau_04_KyBC(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_DN01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_DN02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_DN08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD09A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD10A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD11A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD12A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD13A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD14A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD15A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD16A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD17A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD18A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD19A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD20A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
	Public MustOverride Function RPT_Run_NLD21A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_NLD22A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_NLD23A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_NLD24A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_NLD25A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_THBienDong(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
    Public MustOverride Function RPT_Run_TT271(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader

#End Region
#Region "BC_CompanyType"
    Public MustOverride Function BC_CompanyType_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function BC_CompanyType_List(PortalConnect As String) As IDataReader

    Public MustOverride Function BC_CompanyType_Add(PortalConnect As String, obj As BC_CompanyTypeInfo) As Integer
    Public MustOverride Sub BC_CompanyType_Update(PortalConnect As String, obj As BC_CompanyTypeInfo)
    Public MustOverride Sub BC_CompanyType_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "BC_PhieuDT"
    Public MustOverride Function BC_PhieuDT_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function BC_PhieuDT_List(PortalConnect As String) As IDataReader
    Public MustOverride Function BC_PhieuDT_List_Search(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer) As IDataReader
    Public MustOverride Function BC_PhieuDT_Add(PortalConnect As String, obj As BC_PhieuDTInfo) As Integer
    Public MustOverride Sub BC_PhieuDT_Update(PortalConnect As String, obj As BC_PhieuDTInfo)
    Public MustOverride Sub BC_PhieuDT_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub BC_PhieuDT_Refresh(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer)

#End Region
#Region "TH27_M02_A"
    Public MustOverride Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m02ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
    Public MustOverride Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
#End Region
#Region "TH27_M02_B"
    Public MustOverride Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
    Public MustOverride Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M03_A"
    Public MustOverride Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m03ID As Integer, years As Integer, tinhTP As Integer)
    Public MustOverride Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M03_B"
    Public MustOverride Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m03ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
    Public MustOverride Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "API"
    Public MustOverride Function API_CAULD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, kcn As String, year As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function API_CAULD_02(PortalConnect As String, tp As Integer, mst As String, year As Integer, isNow As Boolean) As IDataReader
#End Region

#Region "REPORT CHART"
    Public MustOverride Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
    Public MustOverride Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader
    Public MustOverride Function ThongKe_DN_TheoTinhTrang(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, Key As String) As IDataReader
    Public MustOverride Function ThongKe_DN_TheoNguoiNhapTin(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, UserName As String) As IDataReader

#End Region
End Class
