Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
	Inherits DataProvider

#Region "BC_Business"
	Public Overrides Function BC_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_Check_TaxCode", business_ID, taxCode), IDataReader)
	End Function
	Public Overrides Function BC_CauLD_List_By_Flag(PortalConnect As String, isFlag As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_CauLD_List_By_Flag", isFlag), IDataReader)
	End Function
	Public Overrides Function BC_Business_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, XaPhuong As String, ThonTo As String, KCN As String, TrangThai As Integer, Year As Integer, NganhNghe As Integer, IsDelete As Boolean) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List_Search", Search, currPage, recodperpage, TinhTP, QuanHuyen, XaPhuong, ThonTo, KCN, TrangThai, Year, NganhNghe, IsDelete), IDataReader)
	End Function
	Public Overrides Function BC_Business_List_XuatSo(PortalConnect As String, TinhTP As String, QuanHuyen As String, XaPhuong As String, Year As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List_XuatSo", TinhTP, QuanHuyen, XaPhuong, Year), IDataReader)
	End Function
	Public Overrides Function BC_Business_List_Tbao(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, TinhTP As String, QuanHuyen As String, TrangThai As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List_Tbao", Search, currPage, recodperpage, TinhTP, QuanHuyen, TrangThai), IDataReader)
	End Function
	Public Overrides Sub BC_Business_Update_TbGui(PortalConnect As String, DoanhNghiep_ID As String, tbGui As Boolean)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update_TbGui", DoanhNghiep_ID, tbGui)
	End Sub
	Public Overrides Sub BC_Business_Update_Tbao(PortalConnect As String, DoanhNghiep_ID As String, tuNgay As DateTime, denNgay As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update_Tbao", DoanhNghiep_ID, tuNgay, denNgay)
	End Sub
	Public Overrides Function BC_Business_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_Get", doanhNghiep_ID), IDataReader)
	End Function
	Public Overrides Function BC_Business_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List", portalId), IDataReader)
	End Function
	Public Overrides Sub BC_Business_Add(PortalConnect As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, CMKT_CaoDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, Chia_CaoDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_Business_Add", doanhNghiep_ID, maDoanhNghiep, tenDoanhNghiep, taxCode, mobile, fax, email, website, flReg.GetNull(tinhTrang), tinhTP, flReg.GetNull(quanHuyen), flReg.GetNull(xaPhuong), flReg.GetNull(tT_NT), flReg.GetNull(soNha), flReg.GetNull(khuCN_ID), flReg.GetNull(loaiHinh_ID), (nganhNghe), lD_TongSo, lD_NgoaiTinh, lD_TrucTiep, lD_Nu, lD_HD_Tong, lD_HD_Nu, lD_NuocNgoai_Tong, lD_NuocNgoai_Nu, lD_PhoThong, cMKT_Khong, cMKT_BangCap, cMKT_DaoTao, cMKT_SoCap, cMKT_TrungCap, CMKT_CaoDang, cMKT_DaiHoc, gDDT_KTXH, gDDT_KHTN, gDDT_KTCN, gDDT_NongNghiep, gDDT_YTe, gDDT_Khac, nhom_LanhDao, nhom_ChuyenMon, nhom_TroLy, nhom_DichVu, nhom_NongNghiep, nhom_ThuCong, nhom_Tho, nhom_DonGian, tL_BinhQuan, tL_ThapNhat, tL_CaoNhat, chia_Khong, chia_BangCap, chia_DaoTao, chia_SoCap, chia_TrungCap, Chia_CaoDang, chia_DaiHoc, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, SanPhamChinh, QuyMoLaoDong, LD_NgoaiTinh_Nu, LD_TrucTiep_Nu, LD_GianTiep_Nu, LD_BHXH, LD_BHXH_Nu, LD_TREN35, LD_TREN35_Nu, LD_PhoThong_Nu, VT_NhaQuanLy, VT_NhaQuanLy_Nu, VT_CMKT_Cao, VT_CMKT_Cao_Nu, VT_CMKT_Trung, VT_CMKT_Trung_Nu, VT_CMKT_Khac, VT_CMKT_Khac_Nu, CMKT_Khong_Nu, CMKT_BangCap_Nu, CMKT_DaoTao_Nu, CMKT_SoCap_Nu, CMKT_TrungCap_Nu, CMKT_CaoDang_Nu, CMKT_DaiHoc_Nu, GDDT_KTXH_Nu, GDDT_KHTN_Nu, GDDT_KTCN_Nu, GDDT_NongNghiep_Nu, GDDT_YTe_Nu, GDDT_Khac_Nu, C8_17, C8_21, C8_22, C8_23, C8_24, C8_25, C8_26, C8_31, C8_32, C8_33, C8_34, C8_35, C8_36, C8_41, C8_42, C8_43, C8_44, C8_51, C8_52, C8_53, C8_54, C8_61, C8_62, C8_63, C8_71, C8_72, C8_73, C8_74, C8_75, C8_81, C8_82, C8_83, C8_91, C8_92, C8_93, C8_94, C8_95, C8_96, C8_17_Nu, C8_21_Nu, C8_22_Nu, C8_23_Nu, C8_24_Nu, C8_25_Nu, C8_26_Nu, C8_31_Nu, C8_32_Nu, C8_33_Nu, C8_34_Nu, C8_35_Nu, C8_36_Nu, C8_41_Nu, C8_42_Nu, C8_43_Nu, C8_44_Nu, C8_51_Nu, C8_52_Nu, C8_53_Nu, C8_54_Nu, C8_61_Nu, C8_62_Nu, C8_63_Nu, C8_71_Nu, C8_72_Nu, C8_73_Nu, C8_74_Nu, C8_75_Nu, C8_81_Nu, C8_82_Nu, C8_83_Nu, C8_91_Nu, C8_92_Nu, C8_93_Nu, C8_94_Nu, C8_95_Nu, C8_96_Nu, C11_17, C11_21, C11_22, C11_23, C11_24, C11_25, C11_26, C11_31, C11_32, C11_33, C11_34, C11_35, C11_36, C11_41, C11_42, C11_43, C11_44, C11_51, C11_52, C11_53, C11_54, C11_61, C11_62, C11_63, C11_71, C11_72, C11_73, C11_74, C11_75, C11_81, C11_82, C11_83, C11_91, C11_92, C11_93, C11_94, C11_95, C11_96, C11_17_Nu, C11_21_Nu, C11_22_Nu, C11_23_Nu, C11_24_Nu, C11_25_Nu, C11_26_Nu, C11_31_Nu, C11_32_Nu, C11_33_Nu, C11_34_Nu, C11_35_Nu, C11_36_Nu, C11_41_Nu, C11_42_Nu, C11_43_Nu, C11_44_Nu, C11_51_Nu, C11_52_Nu, C11_53_Nu, C11_54_Nu, C11_61_Nu, C11_62_Nu, C11_63_Nu, C11_71_Nu, C11_72_Nu, C11_73_Nu, C11_74_Nu, C11_75_Nu, C11_81_Nu, C11_82_Nu, C11_83_Nu, C11_91_Nu, C11_92_Nu, C11_93_Nu, C11_94_Nu, C11_95_Nu, C11_96_Nu, C10_LaoDong, Chia_Khong_Nu, Chia_BangCap_Nu, Chia_DaoTao_Nu, Chia_SoCap_Nu, Chia_TrungCap_Nu, Chia_CaoDang_Nu, Chia_DaiHoc_Nu, LD_GianTiep)
	End Sub
	Public Overrides Sub BC_Business_Update(PortalConnect As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, CMKT_CaoDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, Chia_CaoDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update", doanhNghiep_ID, maDoanhNghiep, tenDoanhNghiep, taxCode, mobile, fax, email, website, flReg.GetNull(tinhTrang), tinhTP, flReg.GetNull(quanHuyen), flReg.GetNull(xaPhuong), flReg.GetNull(tT_NT), flReg.GetNull(soNha), flReg.GetNull(khuCN_ID), flReg.GetNull(loaiHinh_ID), (nganhNghe), lD_TongSo, lD_NgoaiTinh, lD_TrucTiep, lD_Nu, lD_HD_Tong, lD_HD_Nu, lD_NuocNgoai_Tong, lD_NuocNgoai_Nu, lD_PhoThong, cMKT_Khong, cMKT_BangCap, cMKT_DaoTao, cMKT_SoCap, cMKT_TrungCap, CMKT_CaoDang, cMKT_DaiHoc, gDDT_KTXH, gDDT_KHTN, gDDT_KTCN, gDDT_NongNghiep, gDDT_YTe, gDDT_Khac, nhom_LanhDao, nhom_ChuyenMon, nhom_TroLy, nhom_DichVu, nhom_NongNghiep, nhom_ThuCong, nhom_Tho, nhom_DonGian, tL_BinhQuan, tL_ThapNhat, tL_CaoNhat, chia_Khong, chia_BangCap, chia_DaoTao, chia_SoCap, chia_TrungCap, Chia_CaoDang, chia_DaiHoc, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, SanPhamChinh, QuyMoLaoDong, LD_NgoaiTinh_Nu, LD_TrucTiep_Nu, LD_GianTiep_Nu, LD_BHXH, LD_BHXH_Nu, LD_TREN35, LD_TREN35_Nu, LD_PhoThong_Nu, VT_NhaQuanLy, VT_NhaQuanLy_Nu, VT_CMKT_Cao, VT_CMKT_Cao_Nu, VT_CMKT_Trung, VT_CMKT_Trung_Nu, VT_CMKT_Khac, VT_CMKT_Khac_Nu, CMKT_Khong_Nu, CMKT_BangCap_Nu, CMKT_DaoTao_Nu, CMKT_SoCap_Nu, CMKT_TrungCap_Nu, CMKT_CaoDang_Nu, CMKT_DaiHoc_Nu, GDDT_KTXH_Nu, GDDT_KHTN_Nu, GDDT_KTCN_Nu, GDDT_NongNghiep_Nu, GDDT_YTe_Nu, GDDT_Khac_Nu, C8_17, C8_21, C8_22, C8_23, C8_24, C8_25, C8_26, C8_31, C8_32, C8_33, C8_34, C8_35, C8_36, C8_41, C8_42, C8_43, C8_44, C8_51, C8_52, C8_53, C8_54, C8_61, C8_62, C8_63, C8_71, C8_72, C8_73, C8_74, C8_75, C8_81, C8_82, C8_83, C8_91, C8_92, C8_93, C8_94, C8_95, C8_96, C8_17_Nu, C8_21_Nu, C8_22_Nu, C8_23_Nu, C8_24_Nu, C8_25_Nu, C8_26_Nu, C8_31_Nu, C8_32_Nu, C8_33_Nu, C8_34_Nu, C8_35_Nu, C8_36_Nu, C8_41_Nu, C8_42_Nu, C8_43_Nu, C8_44_Nu, C8_51_Nu, C8_52_Nu, C8_53_Nu, C8_54_Nu, C8_61_Nu, C8_62_Nu, C8_63_Nu, C8_71_Nu, C8_72_Nu, C8_73_Nu, C8_74_Nu, C8_75_Nu, C8_81_Nu, C8_82_Nu, C8_83_Nu, C8_91_Nu, C8_92_Nu, C8_93_Nu, C8_94_Nu, C8_95_Nu, C8_96_Nu, C11_17, C11_21, C11_22, C11_23, C11_24, C11_25, C11_26, C11_31, C11_32, C11_33, C11_34, C11_35, C11_36, C11_41, C11_42, C11_43, C11_44, C11_51, C11_52, C11_53, C11_54, C11_61, C11_62, C11_63, C11_71, C11_72, C11_73, C11_74, C11_75, C11_81, C11_82, C11_83, C11_91, C11_92, C11_93, C11_94, C11_95, C11_96, C11_17_Nu, C11_21_Nu, C11_22_Nu, C11_23_Nu, C11_24_Nu, C11_25_Nu, C11_26_Nu, C11_31_Nu, C11_32_Nu, C11_33_Nu, C11_34_Nu, C11_35_Nu, C11_36_Nu, C11_41_Nu, C11_42_Nu, C11_43_Nu, C11_44_Nu, C11_51_Nu, C11_52_Nu, C11_53_Nu, C11_54_Nu, C11_61_Nu, C11_62_Nu, C11_63_Nu, C11_71_Nu, C11_72_Nu, C11_73_Nu, C11_74_Nu, C11_75_Nu, C11_81_Nu, C11_82_Nu, C11_83_Nu, C11_91_Nu, C11_92_Nu, C11_93_Nu, C11_94_Nu, C11_95_Nu, C11_96_Nu, C10_LaoDong, Chia_Khong_Nu, Chia_BangCap_Nu, Chia_DaoTao_Nu, Chia_SoCap_Nu, Chia_TrungCap_Nu, Chia_CaoDang_Nu, Chia_DaiHoc_Nu, LD_GianTiep)
	End Sub
	Public Overrides Sub BC_Business_Delete(PortalConnect As String, doanhNghiep_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Delete", doanhNghiep_ID)
	End Sub
	Public Overrides Sub BC_Business_Update_IsDelete(PortalConnect As String, doanhNghiep_ID As String, isDelete As Boolean)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update_IsDelete", doanhNghiep_ID, isDelete)
	End Sub
	Public Overrides Sub BC_Business_Update_ByID(PortalConnect As String, ID As String, doanhNghiep_ID As String, maDoanhNghiep As String, tenDoanhNghiep As String, taxCode As String, mobile As String, fax As String, email As String, website As String, tinhTrang As Integer, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, khuCN_ID As String, loaiHinh_ID As String, nganhNghe As Integer, lD_TongSo As Integer, lD_NgoaiTinh As Integer, lD_TrucTiep As Integer, lD_Nu As Integer, lD_HD_Tong As Integer, lD_HD_Nu As Integer, lD_NuocNgoai_Tong As Integer, lD_NuocNgoai_Nu As Integer, lD_PhoThong As Integer, cMKT_Khong As Integer, cMKT_BangCap As Integer, cMKT_DaoTao As Integer, cMKT_SoCap As Integer, cMKT_TrungCap As Integer, CMKT_CaoDang As Integer, cMKT_DaiHoc As Integer, gDDT_KTXH As Integer, gDDT_KHTN As Integer, gDDT_KTCN As Integer, gDDT_NongNghiep As Integer, gDDT_YTe As Integer, gDDT_Khac As Integer, nhom_LanhDao As Integer, nhom_ChuyenMon As Integer, nhom_TroLy As Integer, nhom_DichVu As Integer, nhom_NongNghiep As Integer, nhom_ThuCong As Integer, nhom_Tho As Integer, nhom_DonGian As Integer, tL_BinhQuan As Integer, tL_ThapNhat As Integer, tL_CaoNhat As Integer, chia_Khong As Integer, chia_BangCap As Integer, chia_DaoTao As Integer, chia_SoCap As Integer, chia_TrungCap As Integer, Chia_CaoDang As Integer, chia_DaiHoc As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, SanPhamChinh As String, QuyMoLaoDong As Integer, LD_NgoaiTinh_Nu As Integer, LD_TrucTiep_Nu As Integer, LD_GianTiep_Nu As Integer, LD_BHXH As Integer, LD_BHXH_Nu As Integer, LD_TREN35 As Integer, LD_TREN35_Nu As Integer, LD_PhoThong_Nu As Integer, VT_NhaQuanLy As Integer, VT_NhaQuanLy_Nu As Integer, VT_CMKT_Cao As Integer, VT_CMKT_Cao_Nu As Integer, VT_CMKT_Trung As Integer, VT_CMKT_Trung_Nu As Integer, VT_CMKT_Khac As Integer, VT_CMKT_Khac_Nu As Integer, CMKT_Khong_Nu As Integer, CMKT_BangCap_Nu As Integer, CMKT_DaoTao_Nu As Integer, CMKT_SoCap_Nu As Integer, CMKT_TrungCap_Nu As Integer, CMKT_CaoDang_Nu As Integer, CMKT_DaiHoc_Nu As Integer, GDDT_KTXH_Nu As Integer, GDDT_KHTN_Nu As Integer, GDDT_KTCN_Nu As Integer, GDDT_NongNghiep_Nu As Integer, GDDT_YTe_Nu As Integer, GDDT_Khac_Nu As Integer, C8_17 As Integer, C8_21 As Integer, C8_22 As Integer, C8_23 As Integer, C8_24 As Integer, C8_25 As Integer, C8_26 As Integer, C8_31 As Integer, C8_32 As Integer, C8_33 As Integer, C8_34 As Integer, C8_35 As Integer, C8_36 As Integer, C8_41 As Integer, C8_42 As Integer, C8_43 As Integer, C8_44 As Integer, C8_51 As Integer, C8_52 As Integer, C8_53 As Integer, C8_54 As Integer, C8_61 As Integer, C8_62 As Integer, C8_63 As Integer, C8_71 As Integer, C8_72 As Integer, C8_73 As Integer, C8_74 As Integer, C8_75 As Integer, C8_81 As Integer, C8_82 As Integer, C8_83 As Integer, C8_91 As Integer, C8_92 As Integer, C8_93 As Integer, C8_94 As Integer, C8_95 As Integer, C8_96 As Integer, C8_17_Nu As Integer, C8_21_Nu As Integer, C8_22_Nu As Integer, C8_23_Nu As Integer, C8_24_Nu As Integer, C8_25_Nu As Integer, C8_26_Nu As Integer, C8_31_Nu As Integer, C8_32_Nu As Integer, C8_33_Nu As Integer, C8_34_Nu As Integer, C8_35_Nu As Integer, C8_36_Nu As Integer, C8_41_Nu As Integer, C8_42_Nu As Integer, C8_43_Nu As Integer, C8_44_Nu As Integer, C8_51_Nu As Integer, C8_52_Nu As Integer, C8_53_Nu As Integer, C8_54_Nu As Integer, C8_61_Nu As Integer, C8_62_Nu As Integer, C8_63_Nu As Integer, C8_71_Nu As Integer, C8_72_Nu As Integer, C8_73_Nu As Integer, C8_74_Nu As Integer, C8_75_Nu As Integer, C8_81_Nu As Integer, C8_82_Nu As Integer, C8_83_Nu As Integer, C8_91_Nu As Integer, C8_92_Nu As Integer, C8_93_Nu As Integer, C8_94_Nu As Integer, C8_95_Nu As Integer, C8_96_Nu As Integer, C11_17 As Integer, C11_21 As Integer, C11_22 As Integer, C11_23 As Integer, C11_24 As Integer, C11_25 As Integer, C11_26 As Integer, C11_31 As Integer, C11_32 As Integer, C11_33 As Integer, C11_34 As Integer, C11_35 As Integer, C11_36 As Integer, C11_41 As Integer, C11_42 As Integer, C11_43 As Integer, C11_44 As Integer, C11_51 As Integer, C11_52 As Integer, C11_53 As Integer, C11_54 As Integer, C11_61 As Integer, C11_62 As Integer, C11_63 As Integer, C11_71 As Integer, C11_72 As Integer, C11_73 As Integer, C11_74 As Integer, C11_75 As Integer, C11_81 As Integer, C11_82 As Integer, C11_83 As Integer, C11_91 As Integer, C11_92 As Integer, C11_93 As Integer, C11_94 As Integer, C11_95 As Integer, C11_96 As Integer, C11_17_Nu As Integer, C11_21_Nu As Integer, C11_22_Nu As Integer, C11_23_Nu As Integer, C11_24_Nu As Integer, C11_25_Nu As Integer, C11_26_Nu As Integer, C11_31_Nu As Integer, C11_32_Nu As Integer, C11_33_Nu As Integer, C11_34_Nu As Integer, C11_35_Nu As Integer, C11_36_Nu As Integer, C11_41_Nu As Integer, C11_42_Nu As Integer, C11_43_Nu As Integer, C11_44_Nu As Integer, C11_51_Nu As Integer, C11_52_Nu As Integer, C11_53_Nu As Integer, C11_54_Nu As Integer, C11_61_Nu As Integer, C11_62_Nu As Integer, C11_63_Nu As Integer, C11_71_Nu As Integer, C11_72_Nu As Integer, C11_73_Nu As Integer, C11_74_Nu As Integer, C11_75_Nu As Integer, C11_81_Nu As Integer, C11_82_Nu As Integer, C11_83_Nu As Integer, C11_91_Nu As Integer, C11_92_Nu As Integer, C11_93_Nu As Integer, C11_94_Nu As Integer, C11_95_Nu As Integer, C11_96_Nu As Integer, C10_LaoDong As Integer, Chia_Khong_Nu As Integer, Chia_BangCap_Nu As Integer, Chia_DaoTao_Nu As Integer, Chia_SoCap_Nu As Integer, Chia_TrungCap_Nu As Integer, Chia_CaoDang_Nu As Integer, Chia_DaiHoc_Nu As Integer, LD_GianTiep As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update_ByID", ID, doanhNghiep_ID, maDoanhNghiep, tenDoanhNghiep, taxCode, mobile, fax, email, website, flReg.GetNull(tinhTrang), tinhTP, flReg.GetNull(quanHuyen), flReg.GetNull(xaPhuong), flReg.GetNull(tT_NT), flReg.GetNull(soNha), flReg.GetNull(khuCN_ID), flReg.GetNull(loaiHinh_ID), (nganhNghe), lD_TongSo, lD_NgoaiTinh, lD_TrucTiep, lD_Nu, lD_HD_Tong, lD_HD_Nu, lD_NuocNgoai_Tong, lD_NuocNgoai_Nu, lD_PhoThong, cMKT_Khong, cMKT_BangCap, cMKT_DaoTao, cMKT_SoCap, cMKT_TrungCap, CMKT_CaoDang, cMKT_DaiHoc, gDDT_KTXH, gDDT_KHTN, gDDT_KTCN, gDDT_NongNghiep, gDDT_YTe, gDDT_Khac, nhom_LanhDao, nhom_ChuyenMon, nhom_TroLy, nhom_DichVu, nhom_NongNghiep, nhom_ThuCong, nhom_Tho, nhom_DonGian, tL_BinhQuan, tL_ThapNhat, tL_CaoNhat, chia_Khong, chia_BangCap, chia_DaoTao, chia_SoCap, chia_TrungCap, Chia_CaoDang, chia_DaiHoc, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, SanPhamChinh, QuyMoLaoDong, LD_NgoaiTinh_Nu, LD_TrucTiep_Nu, LD_GianTiep_Nu, LD_BHXH, LD_BHXH_Nu, LD_TREN35, LD_TREN35_Nu, LD_PhoThong_Nu, VT_NhaQuanLy, VT_NhaQuanLy_Nu, VT_CMKT_Cao, VT_CMKT_Cao_Nu, VT_CMKT_Trung, VT_CMKT_Trung_Nu, VT_CMKT_Khac, VT_CMKT_Khac_Nu, CMKT_Khong_Nu, CMKT_BangCap_Nu, CMKT_DaoTao_Nu, CMKT_SoCap_Nu, CMKT_TrungCap_Nu, CMKT_CaoDang_Nu, CMKT_DaiHoc_Nu, GDDT_KTXH_Nu, GDDT_KHTN_Nu, GDDT_KTCN_Nu, GDDT_NongNghiep_Nu, GDDT_YTe_Nu, GDDT_Khac_Nu, C8_17, C8_21, C8_22, C8_23, C8_24, C8_25, C8_26, C8_31, C8_32, C8_33, C8_34, C8_35, C8_36, C8_41, C8_42, C8_43, C8_44, C8_51, C8_52, C8_53, C8_54, C8_61, C8_62, C8_63, C8_71, C8_72, C8_73, C8_74, C8_75, C8_81, C8_82, C8_83, C8_91, C8_92, C8_93, C8_94, C8_95, C8_96, C8_17_Nu, C8_21_Nu, C8_22_Nu, C8_23_Nu, C8_24_Nu, C8_25_Nu, C8_26_Nu, C8_31_Nu, C8_32_Nu, C8_33_Nu, C8_34_Nu, C8_35_Nu, C8_36_Nu, C8_41_Nu, C8_42_Nu, C8_43_Nu, C8_44_Nu, C8_51_Nu, C8_52_Nu, C8_53_Nu, C8_54_Nu, C8_61_Nu, C8_62_Nu, C8_63_Nu, C8_71_Nu, C8_72_Nu, C8_73_Nu, C8_74_Nu, C8_75_Nu, C8_81_Nu, C8_82_Nu, C8_83_Nu, C8_91_Nu, C8_92_Nu, C8_93_Nu, C8_94_Nu, C8_95_Nu, C8_96_Nu, C11_17, C11_21, C11_22, C11_23, C11_24, C11_25, C11_26, C11_31, C11_32, C11_33, C11_34, C11_35, C11_36, C11_41, C11_42, C11_43, C11_44, C11_51, C11_52, C11_53, C11_54, C11_61, C11_62, C11_63, C11_71, C11_72, C11_73, C11_74, C11_75, C11_81, C11_82, C11_83, C11_91, C11_92, C11_93, C11_94, C11_95, C11_96, C11_17_Nu, C11_21_Nu, C11_22_Nu, C11_23_Nu, C11_24_Nu, C11_25_Nu, C11_26_Nu, C11_31_Nu, C11_32_Nu, C11_33_Nu, C11_34_Nu, C11_35_Nu, C11_36_Nu, C11_41_Nu, C11_42_Nu, C11_43_Nu, C11_44_Nu, C11_51_Nu, C11_52_Nu, C11_53_Nu, C11_54_Nu, C11_61_Nu, C11_62_Nu, C11_63_Nu, C11_71_Nu, C11_72_Nu, C11_73_Nu, C11_74_Nu, C11_75_Nu, C11_81_Nu, C11_82_Nu, C11_83_Nu, C11_91_Nu, C11_92_Nu, C11_93_Nu, C11_94_Nu, C11_95_Nu, C11_96_Nu, C10_LaoDong, Chia_Khong_Nu, Chia_BangCap_Nu, Chia_DaoTao_Nu, Chia_SoCap_Nu, Chia_TrungCap_Nu, Chia_CaoDang_Nu, Chia_DaiHoc_Nu, LD_GianTiep)
	End Sub
	Public Overrides Sub BC_Business_Delete_ByID(PortalConnect As String, ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Delete_ByID", ID)
	End Sub
	Public Overrides Function BC_Business_Check_Code(PortalConnect As String, tinhTP As String, quanHuyen As String, xaPhuong As String) As Integer
		Return CType(SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_Business_Check_Code", tinhTP, quanHuyen, xaPhuong), Integer)
	End Function
	Public Overrides Function BC_Business_List_PhieuDT(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List_PhieuDT", isYear, isNow, tinhTP, quanHuyen, xaPhuong, trangThai, currPage, recodperpage), IDataReader)
	End Function
	Public Overrides Function BC_Business_List_PhieuDT_DN(PortalConnect As String, isYear As Integer, isNow As Boolean, tinhTP As Integer, quanHuyen As Integer, trangThai As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_List_PhieuDT_DN", isYear, isNow, tinhTP, quanHuyen, trangThai), IDataReader)
	End Function
#End Region
#Region "BC_LDGiam"
	Public Overrides Function BC_LDGiam_Get(PortalConnect As String, lDGiam_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDGiam_Get", lDGiam_ID), IDataReader)
	End Function
	Public Overrides Function BC_LDGiam_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDGiam_List", portalId), IDataReader)
	End Function

	Public Overrides Sub BC_LDGiam_Add(PortalConnect As String, IsOrder As Integer, lDGiam_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, ngayChamDut As DateTime, BHTN As Boolean, lD_NghiHuu As Boolean, lD_DonPhuong As Boolean, lD_CoCau As Boolean, lD_ChamDut As Boolean, lD_Khac As Boolean, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_LDGiam_Add", IsOrder, lDGiam_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(ngayChamDut), flReg.GetNull(BHTN), flReg.GetNull(lD_NghiHuu), flReg.GetNull(lD_DonPhuong), flReg.GetNull(lD_CoCau), flReg.GetNull(lD_ChamDut), flReg.GetNull(lD_Khac), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Sub BC_LDGiam_Update(PortalConnect As String, lDGiam_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, ngayChamDut As DateTime, lD_NghiHuu As Boolean, lD_DonPhuong As Boolean, lD_CoCau As Boolean, lD_ChamDut As Boolean, lD_Khac As Boolean, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDGiam_Update", lDGiam_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(ngayChamDut), flReg.GetNull(lD_NghiHuu), flReg.GetNull(lD_DonPhuong), flReg.GetNull(lD_CoCau), flReg.GetNull(lD_ChamDut), flReg.GetNull(lD_Khac), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Function BC_LDGiam_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDGiam_Get_By_BC_ThongBao", thongBao_ID), IDataReader)
	End Function
	Public Overrides Sub BC_LDGiam_Delete(PortalConnect As String, lDGiam_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDGiam_Delete", lDGiam_ID)
	End Sub
	Public Overrides Sub BC_LDGiam_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDGiam_Delete_By_BC_ThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_LDGiam_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDGiam_NopThongBao", thongBao_ID, ngayNop)
	End Sub
#End Region
#Region "BC_LDHoan"
	Public Overrides Function BC_LDHoan_Get(PortalConnect As String, lDHoan_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDHoan_Get", lDHoan_ID), IDataReader)
	End Function
	Public Overrides Function BC_LDHoan_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDHoan_List", portalId), IDataReader)
	End Function

	Public Overrides Sub BC_LDHoan_Add(PortalConnect As String, IsOrder As Integer, lDHoan_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, bHTN As Boolean, hoanTu As DateTime, hoanDen As DateTime, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_LDHoan_Add", IsOrder, lDHoan_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(bHTN), flReg.GetNull(hoanTu), flReg.GetNull(hoanDen), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Sub BC_LDHoan_Update(PortalConnect As String, lDHoan_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, bHTN As Boolean, hoanTu As DateTime, hoanDen As DateTime, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDHoan_Update", lDHoan_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(bHTN), flReg.GetNull(hoanTu), flReg.GetNull(hoanDen), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Function BC_LDHoan_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDHoan_Get_By_BC_ThongBao", thongBao_ID), IDataReader)
	End Function
	Public Overrides Sub BC_LDHoan_Delete(PortalConnect As String, lDHoan_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDHoan_Delete", lDHoan_ID)
	End Sub
	Public Overrides Sub BC_LDHoan_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDHoan_Delete_By_BC_ThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_LDHoan_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDHoan_NopThongBao", thongBao_ID, ngayNop)
	End Sub
#End Region
#Region "BC_LDTang"
	Public Overrides Function BC_LDTang_Get(PortalConnect As String, lDTang_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDTang_Get", lDTang_ID), IDataReader)
	End Function
	Public Overrides Function BC_LDTang_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDTang_List", portalId), IDataReader)
	End Function

	Public Overrides Sub BC_LDTang_Add(PortalConnect As String, IsOrder As Integer, lDTang_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_LDTang_Add", IsOrder, lDTang_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(viTri), flReg.GetNull(bHTN), flReg.GetNull(tG_BHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Sub BC_LDTang_Update(PortalConnect As String, lDTang_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDTang_Update", lDTang_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(viTri), flReg.GetNull(bHTN), flReg.GetNull(tG_BHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Function BC_LDTang_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDTang_Get_By_BC_ThongBao", thongBao_ID), IDataReader)
	End Function
	Public Overrides Sub BC_LDTang_Delete(PortalConnect As String, lDTang_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDTang_Delete", lDTang_ID)
	End Sub
	Public Overrides Sub BC_LDTang_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDTang_Delete_By_BC_ThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_LDTang_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_LDTang_NopThongBao", thongBao_ID, ngayNop)
	End Sub
#End Region
#Region "BC_TBCuoiKy"
	Public Overrides Function BC_TBCuoiKy_Get(PortalConnect As String, tBCuoiKy_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBCuoiKy_Get", tBCuoiKy_ID), IDataReader)
	End Function
	Public Overrides Function BC_TBCuoiKy_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBCuoiKy_List", portalId), IDataReader)
	End Function
	Public Overrides Sub BC_TBCuoiKy_Add(PortalConnect As String, IsOrder As Integer, tBCuoiKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, thoiDiem As String, tongSoLD As Integer, tongSoNu As Integer, cNKT As Integer, cCN As Integer, soCap As Integer, trungCap As Integer, caoDang As Integer, daiHoc As Integer, hD_0T As Integer, hD_36T As Integer, hD_12T As Integer, hD_3T As Integer, bHTN As Integer, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_TBCuoiKy_Add", IsOrder, tBCuoiKy_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(thoiDiem), flReg.GetNull(tongSoLD), flReg.GetNull(tongSoNu), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(bHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Sub BC_TBCuoiKy_Update(PortalConnect As String, tBCuoiKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, thoiDiem As String, tongSoLD As Integer, tongSoNu As Integer, cNKT As Integer, cCN As Integer, soCap As Integer, trungCap As Integer, caoDang As Integer, daiHoc As Integer, hD_0T As Integer, hD_36T As Integer, hD_12T As Integer, hD_3T As Integer, bHTN As Integer, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBCuoiKy_Update", tBCuoiKy_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(thoiDiem), flReg.GetNull(tongSoLD), flReg.GetNull(tongSoNu), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(bHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Function BC_TBCuoiKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBCuoiKy_Get_By_BC_ThongBao", thongBao_ID), IDataReader)
	End Function
	Public Overrides Sub BC_TBCuoiKy_Delete(PortalConnect As String, tBCuoiKy_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBCuoiKy_Delete", tBCuoiKy_ID)
	End Sub
	Public Overrides Sub BC_TBCuoiKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBCuoiKy_Delete_By_BC_ThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_TBCuoiKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBCuoiKy_NopThongBao", thongBao_ID, ngayNop)
	End Sub
#End Region
#Region "BC_TBDauKy"
	Public Overrides Function BC_TBDauKy_Get(PortalConnect As String, tBDauKy_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBDauKy_Get", tBDauKy_ID), IDataReader)
	End Function
	Public Overrides Function BC_TBDauKy_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBDauKy_List", portalId), IDataReader)
	End Function
	Public Overrides Sub BC_TBDauKy_Add(PortalConnect As String, IsOrder As Integer, tBDauKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_TBDauKy_Add", IsOrder, tBDauKy_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(viTri), flReg.GetNull(bHTN), flReg.GetNull(tG_BHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Sub BC_TBDauKy_Update(PortalConnect As String, tBDauKy_ID As String, thongBao_ID As String, doanhNghiep_ID As String, ngayNop As DateTime, hoTen As String, ngaySinh As String, gioiTinh As Boolean, danToc As String, cMND As String, bHXH As String, cNKT As Boolean, cCN As Boolean, soCap As Boolean, trungCap As Boolean, caoDang As Boolean, daiHoc As Boolean, hD_0T As Boolean, hD_36T As Boolean, hD_12T As Boolean, hD_3T As Boolean, ngayHD As DateTime, viTri As String, bHTN As Double, tG_BHTN As Double, trangThai As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBDauKy_Update", tBDauKy_ID, thongBao_ID, doanhNghiep_ID, flReg.DateNull(ngayNop), flReg.GetNull(hoTen), flReg.GetNull(ngaySinh), gioiTinh, flReg.GetNull(danToc), flReg.GetNull(cMND), flReg.GetNull(bHXH), flReg.GetNull(cNKT), flReg.GetNull(cCN), flReg.GetNull(soCap), flReg.GetNull(trungCap), flReg.GetNull(caoDang), flReg.GetNull(daiHoc), flReg.GetNull(hD_0T), flReg.GetNull(hD_36T), flReg.GetNull(hD_12T), flReg.GetNull(hD_3T), flReg.GetNull(ngayHD), flReg.GetNull(viTri), flReg.GetNull(bHTN), flReg.GetNull(tG_BHTN), trangThai, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
	End Sub
	Public Overrides Function BC_TBDauKy_Get_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBDauKy_Get_By_BC_ThongBao", thongBao_ID), IDataReader)
	End Function
	Public Overrides Sub BC_TBDauKy_Delete(PortalConnect As String, tBDauKy_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBDauKy_Delete", tBDauKy_ID)
	End Sub
	Public Overrides Sub BC_TBDauKy_Delete_By_BC_ThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBDauKy_Delete_By_BC_ThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_TBDauKy_NopThongBao(PortalConnect As String, thongBao_ID As String, ngayNop As DateTime)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_TBDauKy_NopThongBao", thongBao_ID, ngayNop)
	End Sub
#End Region
#Region "BC_ThongBao"

	Public Overrides Function BC_TBDauKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBDauKy_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function BC_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDTang_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function RUN_LDTang_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RUN_LDTang_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function

	Public Overrides Function BC_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDGiam_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function RUN_LDGiam_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RUN_LDGiam_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function BC_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_LDHoan_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function RUN_LDHoan_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RUN_LDHoan_TongHop", QuanHuyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_List_QuanHuyen(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_List_QuanHuyen", tinh, huyen, nambc, kybc), IDataReader)
	End Function
	Public Overrides Function BC_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_TBCuoiKy_TongHop", QuanHuyen, nambc, kybc, ThoiDiem), IDataReader)
	End Function
	Public Overrides Function RUN_TBCuoiKy_TongHop(PortalConnect As String, QuanHuyen As String, nambc As Integer, kybc As Integer, ThoiDiem As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RUN_TBCuoiKy_TongHop", QuanHuyen, nambc, kybc, ThoiDiem), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_List_DoanhNghiep(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_List_DoanhNghiep", tinh, huyen, nambc, kybc, currPage, recodperpage, txtSearch), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_List_ChuaTB(PortalConnect As String, tinh As String, huyen As String, nambc As Integer, kybc As Integer, currPage As Integer, recodperpage As Integer, txtSearch As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_List_ChuaTB", tinh, huyen, nambc, kybc, currPage, recodperpage, txtSearch), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_Get_TinhTrang(PortalConnect As String, thongBao_ID As String, baoCaoID As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_Get_TinhTrang", thongBao_ID, baoCaoID), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_Get(PortalConnect As String, thongBao_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_Get", thongBao_ID), IDataReader)
	End Function
	Public Overrides Function BC_ThongBao_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_List", portalId), IDataReader)
	End Function
	Public Overrides Sub BC_ThongBao_NopThongBao(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_ThongBao_NopThongBao", thongBao_ID)
	End Sub
	Public Overrides Sub BC_ThongBao_Add(PortalConnect As String, thongBao_ID As String, doanhNghiep_ID As String, business_Vn As String, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, ngayThongBao As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, Years_ID As Integer, Period_ID As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_ThongBao_Add", thongBao_ID, doanhNghiep_ID, flReg.GetNull(business_Vn), tinhTP, flReg.GetNull(quanHuyen), flReg.GetNull(xaPhuong), flReg.GetNull(tT_NT), flReg.GetNull(soNha), flReg.GetNull(ngayThongBao), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, Years_ID, Period_ID)
	End Sub
	Public Overrides Sub BC_ThongBao_Update(PortalConnect As String, thongBao_ID As String, doanhNghiep_ID As String, business_Vn As String, tinhTP As String, quanHuyen As String, xaPhuong As String, tT_NT As String, soNha As String, ngayThongBao As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, Years_ID As Integer, Period_ID As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_ThongBao_Update", thongBao_ID, doanhNghiep_ID, flReg.GetNull(business_Vn), tinhTP, flReg.GetNull(quanHuyen), flReg.GetNull(xaPhuong), flReg.GetNull(tT_NT), flReg.GetNull(soNha), flReg.GetNull(ngayThongBao), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, Years_ID, Period_ID)
	End Sub
	Public Overrides Function BC_ThongBao_Get_By_BC_Business(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_ThongBao_Get_By_BC_Business", doanhNghiep_ID), IDataReader)
	End Function
	Public Overrides Sub BC_ThongBao_Delete(PortalConnect As String, thongBao_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_ThongBao_Delete", thongBao_ID)
	End Sub
#End Region
#Region "BC_Career"
	Public Overrides Function BC_Career_Get(PortalConnect As String, Career_ID As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_Get", Career_ID), IDataReader)
	End Function
	Public Overrides Function BC_Career_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_List", portalId), IDataReader)
	End Function
	Public Overrides Function BC_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
	End Function
	Public Overrides Function BC_Career_List_Parent_Null(PortalConnect As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_List_Parent_Null"), IDataReader)
	End Function
	Public Overrides Function BC_Career_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_Parent_Search_Null", search, isOrder), IDataReader)
	End Function
	Public Overrides Function BC_Career_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
	End Function
	Public Overrides Function BC_Career_Get_By_BC_Career(PortalConnect As String, Career_ID As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Career_Get_By_BC_Career", Career_ID), IDataReader)
	End Function
	Public Overrides Function BC_Career_Add(PortalConnect As String, obj As BC_CareerInfo) As Integer
		Return CType(SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_Career_Add", obj.Career_Code, obj.Career_Name, obj.Career_Des, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
	End Function
	Public Overrides Sub BC_Career_Update(PortalConnect As String, obj As BC_CareerInfo)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Career_Update", obj.Career_ID, obj.Career_Code, obj.Career_Name, obj.Career_Des, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
	End Sub
	Public Overrides Sub BC_Career_Delete(PortalConnect As String, Career_ID As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Career_Delete", Career_ID)
	End Sub
#End Region
#Region "BC_IndustrialZone"
	Public Overrides Function BC_IndustrialZone_Get(PortalConnect As String, industrialZone_ID As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_IndustrialZone_Get", industrialZone_ID), IDataReader)
	End Function
	Public Overrides Function BC_IndustrialZone_List(PortalConnect As String, parentId As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_IndustrialZone_List", parentId), IDataReader)
	End Function
	Public Overrides Function BC_IndustrialZone_List_ByTP(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, parentId As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_IndustrialZone_List_ByTP", tinhTP, quanHuyen, parentId), IDataReader)
	End Function
	Public Overrides Function BC_IndustrialZone_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_IndustrialZone_List_Search", search, isOrder, parent_ID, currPage, recodperpage), IDataReader)
	End Function

	Public Overrides Sub BC_IndustrialZone_Add(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_IndustrialZone_Add", industrialZone_ID, tinhTP, quanHuyen, industrialZone_Name, industrialZone_Code, industrialZone_Des, flReg.GetNull(parent_ID), isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
	End Sub
	Public Overrides Sub BC_IndustrialZone_Update(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_IndustrialZone_Update", industrialZone_ID, tinhTP, quanHuyen, industrialZone_Name, industrialZone_Code, industrialZone_Des, flReg.GetNull(parent_ID), isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
	End Sub
	Public Overrides Sub BC_IndustrialZone_Delete(PortalConnect As String, industrialZone_ID As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_IndustrialZone_Delete", industrialZone_ID)
	End Sub
	Public Overrides Sub BC_IndustrialZone_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_IndustrialZone_Update_Quick", industrialZone_ID, isActive, isOrder)
	End Sub
#End Region
#Region "BC_SendMail"
	Public Overrides Sub BC_Business_Update_SendMail(PortalConnect As String, TuNgay As DateTime, denNgay As DateTime, tinhTP As String, PortalID As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_Business_Update_SendMail", TuNgay, denNgay, tinhTP, PortalID)
	End Sub
	Public Overrides Function BC_SendMail_List_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_List_Years", TinhTP, portalId), IDataReader)
	End Function
	Public Overrides Function BC_SendMail_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, TinhTP As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_List_Search", currPage, recodperpage, TinhTP), IDataReader)
	End Function
	Public Overrides Function BC_SendMail_Send_Years(PortalConnect As String, TinhTP As String, PortalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_Send_Years", TinhTP, PortalId), IDataReader)
	End Function
	Public Overrides Function BC_SendMail_Get(PortalConnect As String, iD As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_Get", iD), IDataReader)
	End Function
	Public Overrides Function BC_SendMail_Get_Years(PortalConnect As String, TinhTP As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_Get_Years", TinhTP, portalId), IDataReader)
	End Function
	Public Overrides Function BC_SendMail_List(PortalConnect As String, portalId As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_SendMail_List", portalId), IDataReader)
	End Function
	Public Overrides Sub BC_SendMail_Update_Active(PortalConnect As String, TinhTP As String, Years_ID As Integer, PortalID As Integer, UpdateUser As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_SendMail_Update_Active", TinhTP, Years_ID, PortalID, UpdateUser)
	End Sub
	Public Overrides Sub BC_SendMail_Add(PortalConnect As String, obj As BC_SendMailInfo)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_SendMail_Add", obj.ID, obj.TinhTP, obj.FromDate, obj.ToDate, obj.Years_ID, obj.Contents, obj.CreateDate, obj.UserName, obj.PortalID, obj.IsActive, obj.IsLock)
	End Sub
	Public Overrides Sub BC_SendMail_Update(PortalConnect As String, obj As BC_SendMailInfo)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_SendMail_Update", obj.ID, obj.TinhTP, obj.FromDate, obj.ToDate, obj.Years_ID, obj.Contents, obj.CreateDate, obj.UserName, obj.PortalID, obj.IsActive, obj.IsLock)
	End Sub
	Public Overrides Sub BC_SendMail_Delete(PortalConnect As String, iD As String)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_SendMail_Delete", iD)
	End Sub

#End Region
#Region "BC_Backup"
	Public Overrides Function BC_Business_Backup_Get_Years(PortalConnect As String, doanhNghiep_ID As String, Years As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Business_Backup_Get_Years", doanhNghiep_ID, Years), IDataReader)
	End Function
	Public Overrides Function BC_Backup_Get_TinhTP_Years(PortalConnect As String, TinhTP As String, Years As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_Backup_Get_TinhTP_Years", TinhTP, Years), IDataReader)
	End Function
	Public Overrides Sub BC_Backup_Add(PortalConnect As String, obj As BC_BackupInfo)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_Backup_Add", obj.ID, obj.TinhTP, obj.Years, obj.IsData, obj.CreatedDate, obj.CreatedUser, obj.PortalId)
	End Sub
	Public Overrides Sub BC_Business_Backup_Add(PortalConnect As String, TinhTP As String, isYears As Integer)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_Business_Backup_Add", TinhTP, isYears)
	End Sub
	Public Overrides Sub RPT_TongHop_SoLieu(PortalConnect As String, TinhTP As String, Years As Integer, Code As String)
		SqlHelper.ExecuteScalar(flConnect.CauConnect, "RPT_Run_" & Code & IIf(Years = Now.Year, "_Now", ""), TinhTP, Years)
	End Sub

#End Region
#Region "BC_CAULD"
	Public Overrides Function BC_CauLD_Mau_04_KyTruoc(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_CauLD_Mau_04_KyTruoc", TinhTP, PhuongXa, IsYears), IDataReader)
	End Function
	Public Overrides Function BC_CauLD_Mau_04_KyBC(PortalConnect As String, TinhTP As String, PhuongXa As Integer, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_CauLD_Mau_04_KyBC", TinhTP, PhuongXa, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN01A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN02A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN03A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN04A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN05A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN06A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN07A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_DN08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_DN08A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD01A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD01A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD02A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD02A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD03A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD03A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD04A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD04A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD05A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD05A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD06A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD06A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD07A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD07A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD08A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD08A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD09A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD09A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD10A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD10A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD11A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD11A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD12A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD12A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD13A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD13A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD14A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD14A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD15A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD15A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD16A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD16A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD17A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD17A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD18A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD18A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD19A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD19A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD20A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD20A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD21A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD21A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD22A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD22A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD23A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD23A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD24A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD24A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_NLD25A(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_NLD25A", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_THBienDong(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_THBienDong", TinhTP, IsYears), IDataReader)
	End Function
	Public Overrides Function RPT_Run_TT271(PortalConnect As String, TinhTP As String, IsYears As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "RPT_Run_TT271", TinhTP, IsYears), IDataReader)
	End Function

#End Region
#Region "BC_CompanyType"
	Public Overrides Function BC_CompanyType_Get(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_CompanyType_Get", iD), IDataReader)
	End Function
	Public Overrides Function BC_CompanyType_List(PortalConnect As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_CompanyType_List"), IDataReader)
	End Function


	Public Overrides Function BC_CompanyType_Add(PortalConnect As String, obj As BC_CompanyTypeInfo) As Integer
		Return CType(SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_CompanyType_Add", obj.ID, obj.MaLoaiHinh, obj.TenLoaiHinh, obj.STT), Integer)
	End Function
	Public Overrides Sub BC_CompanyType_Update(PortalConnect As String, obj As BC_CompanyTypeInfo)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_CompanyType_Update", obj.ID, obj.MaLoaiHinh, obj.TenLoaiHinh, obj.STT)
	End Sub
	Public Overrides Sub BC_CompanyType_Delete(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_CompanyType_Delete", iD)
	End Sub

#End Region
#Region "BC_PhieuDT"
	Public Overrides Function BC_PhieuDT_Get(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_PhieuDT_Get", iD), IDataReader)
	End Function
	Public Overrides Function BC_PhieuDT_List(PortalConnect As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_PhieuDT_List"), IDataReader)
	End Function
	Public Overrides Function BC_PhieuDT_List_Search(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "BC_PhieuDT_List_Search", isYear, tinhTP, quanHuyen), IDataReader)
	End Function

	Public Overrides Function BC_PhieuDT_Add(PortalConnect As String, obj As BC_PhieuDTInfo) As Integer
		Return CType(SqlHelper.ExecuteScalar(flConnect.CauConnect, "BC_PhieuDT_Add", flReg.GetNull(obj.IsYears), flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.TenXP), flReg.GetNull(obj.PhieuDT), flReg.GetNull(obj.Paths), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
	End Function
	Public Overrides Sub BC_PhieuDT_Update(PortalConnect As String, obj As BC_PhieuDTInfo)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_PhieuDT_Update", obj.ID, flReg.GetNull(obj.IsYears), flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.TenXP), flReg.GetNull(obj.PhieuDT), flReg.GetNull(obj.Paths), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
	End Sub
	Public Overrides Sub BC_PhieuDT_Delete(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_PhieuDT_Delete", iD)
	End Sub
	Public Overrides Sub BC_PhieuDT_Refresh(PortalConnect As String, isYear As Integer, tinhTP As Integer, quanHuyen As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "BC_PhieuDT_Refresh", isYear, tinhTP, quanHuyen)
	End Sub
#End Region
#Region "TH27_M02_A"
	Public Overrides Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m02ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "RPT_TH27_M02_A_RUN", m02ID, years, tinhTP, quanHuyen)
	End Sub
	Public Overrides Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "TH27_M02_A_Get_By_TH27_M02", iD), IDataReader)
	End Function
	Public Overrides Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "TH27_M02_A_Delete_By_TH27_M02", iD)
	End Sub
#End Region
#Region "TH27_M02_B"
	Public Overrides Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "RPT_TH27_M02_B_RUN", m02ID, sTT, tinhTP, quanHuyen, xaPhuong, tenXaPhuong, years)
	End Sub
	Public Overrides Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "TH27_M02_B_Get_By_TH27_M02", iD), IDataReader)
	End Function
	Public Overrides Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "TH27_M02_B_Delete_By_TH27_M02", iD)
	End Sub
#End Region
#Region "TH27_M03_A"
	Public Overrides Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m03ID As Integer, years As Integer, tinhTP As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "RPT_TH27_M03_A_RUN", m03ID, years, tinhTP)
	End Sub
	Public Overrides Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "TH27_M03_A_Get_By_TH27_M03", iD), IDataReader)
	End Function
	Public Overrides Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "TH27_M03_A_Delete_By_TH27_M03", iD)
	End Sub
#End Region
#Region "TH27_M03_B"
	Public Overrides Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m03ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "RPT_TH27_M03_B_RUN", m03ID, sTT, tinhTP, quanHuyen, tenQuanHuyen, years)
	End Sub
	Public Overrides Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "TH27_M03_B_Get_By_TH27_M03", iD), IDataReader)
	End Function
	Public Overrides Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
		SqlHelper.ExecuteNonQuery(flConnect.CauConnect, "TH27_M03_B_Delete_By_TH27_M03", iD)
	End Sub
#End Region
#Region "API"
	Public Overrides Function API_CAULD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, kcn As String, year As Integer, isNow As Boolean) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "API_CAULD_01", tp, qh, xp, kcn, year, isNow), IDataReader)
	End Function
	Public Overrides Function API_CAULD_02(PortalConnect As String, tp As Integer, mst As String, year As Integer, isNow As Boolean) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "API_CAULD_02", tp, mst, year, isNow), IDataReader)
	End Function
#End Region

#Region "REPORT CHART"
	Public Overrides Function CMS_Chart_Data(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "CMS_Chart" & maBC, tp, qh, xp, year, isNow), IDataReader)
	End Function
	Public Overrides Function CMS_Chart_DataHC(PortalConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "CMS_Chart_DataHC" & maBC, tp, qh, ids, year, isNow), IDataReader)
	End Function
	Public Overrides Function ThongKe_DN_TheoTinhTrang(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, Key As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "ThongKe_DN_TheoTinhTrang", PhuongXa, TrangThai, KyDuLieu, Key), IDataReader)
	End Function
	Public Overrides Function ThongKe_DN_TheoNguoiNhapTin(PhuongXa As Integer, TrangThai As Integer, KyDuLieu As Integer, UserName As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(flConnect.CauConnect, "ThongKe_DN_TheoNguoiNhapTin", PhuongXa, TrangThai, KyDuLieu, UserName), IDataReader)
	End Function

#End Region
End Class

