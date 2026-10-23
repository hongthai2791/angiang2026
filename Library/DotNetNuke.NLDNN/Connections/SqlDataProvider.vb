Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
    Inherits DataProvider

#Region "CMS_NLD"
    Public Overrides Sub CMS_NLD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect(tpConnect), "CMS_NLD_BackupData", matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Overrides Function CMS_NLD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, currPage As Integer, recodperpage As Integer, isNow As Boolean, yearCreated As Integer, quocTich As String, gioiTinh As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_NLD_List_Search", search, matinh, mahuyen, maxa, mathon, isOrder, year, currPage, recodperpage, isNow, yearCreated, quocTich, gioiTinh), IDataReader)
    End Function
    Public Overrides Sub CMS_NLD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect(tpConnect), "CMS_NLD_Update_Delete", id, isDelete, deleteDate, deleteUser)
    End Sub
    Public Overrides Function CMS_NLD_Get(PortalConnect As String, nguoiLD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_NLD_Get", nguoiLD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NLD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_NLD_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_NLD_Add(PortalConnect As String, obj As CMS_NLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "CMS_NLD_Add", obj.NguoiLD_ID, obj.MaNLD, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.QuocTich, obj.HoChieu, obj.CoQuanCap, obj.NgayCapHC, obj.ThoiHanHC, obj.TrinhDoCM, obj.ViTriCV, obj.ChuyenMonDT, obj.ChuyenMonDT_Khac, obj.LVTuNgay, obj.LVDenNgay, obj.NoiLamViec, obj.DiaDiemLV, obj.ChucDanh, obj.SoGP, obj.NgayCP, obj.DoanhNghiep_ID, obj.TenDoanhNghiep, obj.MaDoanhNghiep, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.LoaiHinh_ID, obj.NgheCongViec, obj.NgheCongViec_Khac, obj.HinhThucLamViec, obj.HinhThucLamViec_Khac, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.TrangThai), Integer)
    End Function
    Public Overrides Sub CMS_NLD_Update(PortalConnect As String, obj As CMS_NLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Update", obj.NguoiLD_ID, obj.MaNLD, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.QuocTich, obj.HoChieu, obj.CoQuanCap, obj.NgayCapHC, obj.ThoiHanHC, obj.TrinhDoCM, obj.ViTriCV, obj.ChuyenMonDT, obj.ChuyenMonDT_Khac, obj.LVTuNgay, obj.LVDenNgay, obj.NoiLamViec, obj.DiaDiemLV, obj.ChucDanh, obj.SoGP, obj.NgayCP, obj.DoanhNghiep_ID, obj.TenDoanhNghiep, obj.MaDoanhNghiep, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.LoaiHinh_ID, obj.NgheCongViec, obj.NgheCongViec_Khac, obj.HinhThucLamViec, obj.HinhThucLamViec_Khac, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.TrangThai)
    End Sub
    Public Overrides Sub CMS_NLD_Delete(PortalConnect As String, nguoiLD_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Delete", nguoiLD_ID)
    End Sub
    Public Overrides Sub CMS_NLD_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Update_Quick", nguoiLD_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_NLD_Backup"
    Public Overrides Function CMS_NLD_Backup_Get(PortalConnect As String, nguoiLD_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_NLD_Backup_Get", nguoiLD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NLD_Backup_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_NLD_Backup_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_NLD_Backup_Add(PortalConnect As String, obj As CMS_NLD_BackupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "CMS_NLD_Backup_Add", obj.ID_NLD, obj.MaNLD, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.QuocTich, obj.HoChieu, obj.CoQuanCap, obj.NgayCapHC, obj.ThoiHanHC, obj.TrinhDoCM, obj.ViTriCV, obj.ChuyenMonDT, obj.ChuyenMonDT_Khac, obj.LVTuNgay, obj.LVDenNgay, obj.NoiLamViec, obj.DiaDiemLV, obj.ChucDanh, obj.SoGP, obj.NgayCP, obj.DoanhNghiep_ID, obj.TenDoanhNghiep, obj.MaDoanhNghiep, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.LoaiHinh_ID, obj.NgheCongViec, obj.NgheCongViec_Khac, obj.HinhThucLamViec, obj.HinhThucLamViec_Khac, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.TrangThai), Integer)
    End Function
    Public Overrides Sub CMS_NLD_Backup_Update(PortalConnect As String, obj As CMS_NLD_BackupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Backup_Update", obj.NguoiLD_ID, obj.ID_NLD, obj.MaNLD, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.QuocTich, obj.HoChieu, obj.CoQuanCap, obj.NgayCapHC, obj.ThoiHanHC, obj.TrinhDoCM, obj.ViTriCV, obj.ChuyenMonDT, obj.ChuyenMonDT_Khac, obj.LVTuNgay, obj.LVDenNgay, obj.NoiLamViec, obj.DiaDiemLV, obj.ChucDanh, obj.SoGP, obj.NgayCP, obj.DoanhNghiep_ID, obj.TenDoanhNghiep, obj.MaDoanhNghiep, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.LoaiHinh_ID, obj.NgheCongViec, obj.NgheCongViec_Khac, obj.HinhThucLamViec, obj.HinhThucLamViec_Khac, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.TrangThai)
    End Sub
    Public Overrides Sub CMS_NLD_Backup_Delete(PortalConnect As String, nguoiLD_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Backup_Delete", nguoiLD_ID)
    End Sub
    Public Overrides Sub CMS_NLD_Backup_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "CMS_NLD_Backup_Update_Quick", nguoiLD_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Provide_Config"

    Public Overrides Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_List_Search", tinhTP, isActive, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, active As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Get_Active", TinhTP, active), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get_Value(tpConnect As String, TinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Get_Value", TinhTP, QuanHuyen, PhuongXa, ThonTo, proconfig_value), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Get", proConfig_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinh As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_List_ByTinh", tinh), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_Config_Add(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Add", proConfig_ID, tinhTP, QuanHuyen, PhuongXa, ThonTo, proConfig_Name, proConfig_Value, isActive, isLock, isFlag, flReg.GetNull(createdDate), createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Update(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Update", proConfig_ID, tinhTP, QuanHuyen, PhuongXa, ThonTo, proConfig_Name, proConfig_Value, isActive, flReg.GetNull(isLock), isFlag, flReg.GetNull(createdDate), createdUser, flReg.GetNull(updatedDate), updatedUser, portalId)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Delete", proConfig_ID)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect(tpConnect), "CMS_Provide_Config_Delete", proConfig_ID, active)
    End Sub
#End Region
#Region "CMS_Provide_History"
    Public Overrides Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect(tpConnect), "CMS_Provide_History_Get", history_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_History_List(tpConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect(tpConnect), "CMS_Provide_History_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect(tpConnect), "CMS_Provide_History_Add", obj.History_ID, obj.History_Name, obj.History_Des, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.IsFlag, obj.TotalHoAdd, obj.TotalKhauAdd, obj.TotalHo, obj.TotalKhau, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect(tpConnect), "CMS_Provide_History_Update", obj.History_ID, obj.History_Name, obj.History_Des, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.IsFlag, obj.TotalHoAdd, obj.TotalKhauAdd, obj.TotalHo, obj.TotalKhau, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect(tpConnect), "CMS_Provide_History_Delete", history_ID)
    End Sub

    Public Overrides Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, huyen As Integer, xa As Integer, maDvi As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect(tpConnect), "CMS_Provide_History_Get_Send", tinhTP, huyen, xa, maDvi), IDataReader)
    End Function
#End Region
#Region "DM_ChuyenMonDT"
    Public Overrides Function DM_ChuyenMonDT_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_ChuyenMonDT_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_ChuyenMonDT_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_ChuyenMonDT_List"), IDataReader)
    End Function

    Public Overrides Function DM_ChuyenMonDT_Add(PortalConnect As String, obj As DM_ChuyenMonDTInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "DM_ChuyenMonDT_Add", obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub DM_ChuyenMonDT_Update(PortalConnect As String, obj As DM_ChuyenMonDTInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ChuyenMonDT_Update", obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub DM_ChuyenMonDT_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ChuyenMonDT_Delete", iD)
    End Sub
    Public Overrides Sub DM_ChuyenMonDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ChuyenMonDT_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_HinhThucLV"
    Public Overrides Function DM_HinhThucLV_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_HinhThucLV_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_HinhThucLV_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_HinhThucLV_List"), IDataReader)
    End Function

    Public Overrides Function DM_HinhThucLV_Add(PortalConnect As String, obj As DM_HinhThucLVInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "DM_HinhThucLV_Add", obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub DM_HinhThucLV_Update(PortalConnect As String, obj As DM_HinhThucLVInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_HinhThucLV_Update", obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub DM_HinhThucLV_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_HinhThucLV_Delete", iD)
    End Sub
    Public Overrides Sub DM_HinhThucLV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_HinhThucLV_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_NgheCongViec"
    Public Overrides Function DM_NgheCongViec_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_NgheCongViec_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_NgheCongViec_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_NgheCongViec_List"), IDataReader)
    End Function

    Public Overrides Function DM_NgheCongViec_Add(PortalConnect As String, obj As DM_NgheCongViecInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "DM_NgheCongViec_Add", obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub DM_NgheCongViec_Update(PortalConnect As String, obj As DM_NgheCongViecInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_NgheCongViec_Update", obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub DM_NgheCongViec_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_NgheCongViec_Delete", iD)
    End Sub
    Public Overrides Sub DM_NgheCongViec_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_NgheCongViec_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_TrinhDoDT"
    Public Overrides Function DM_TrinhDoDT_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_TrinhDoDT_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_TrinhDoDT_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_TrinhDoDT_List"), IDataReader)
    End Function

    Public Overrides Function DM_TrinhDoDT_Add(PortalConnect As String, obj As DM_TrinhDoDTInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "DM_TrinhDoDT_Add", obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub DM_TrinhDoDT_Update(PortalConnect As String, obj As DM_TrinhDoDTInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_TrinhDoDT_Update", obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub DM_TrinhDoDT_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_TrinhDoDT_Delete", iD)
    End Sub
    Public Overrides Sub DM_TrinhDoDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_TrinhDoDT_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_ViTriCV"
    Public Overrides Function DM_ViTriCV_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_ViTriCV_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_ViTriCV_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "DM_ViTriCV_List"), IDataReader)
    End Function

    Public Overrides Function DM_ViTriCV_Add(PortalConnect As String, obj As DM_ViTriCVInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.NLDNNConnect, "DM_ViTriCV_Add", obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub DM_ViTriCV_Update(PortalConnect As String, obj As DM_ViTriCVInfo)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ViTriCV_Update", obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub DM_ViTriCV_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ViTriCV_Delete", iD)
    End Sub
    Public Overrides Sub DM_ViTriCV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.NLDNNConnect, "DM_ViTriCV_Update_Quick", iD, isActive, isOrder)
    End Sub

#End Region


#Region "REPORT CHART"
    Public Overrides Function CMS_Chart_Data(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_Chart" & maBC, tp, qh, xp, year, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_Chart_DataHC(PortalConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.NLDNNConnect, "CMS_Chart_DataHC" & maBC, tp, qh, ids, year, isNow), IDataReader)
    End Function
#End Region

End Class

