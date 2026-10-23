Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
    Inherits DataProvider

#Region "CMS_HoGD"
    Public Overrides Function CMS_HoGD_Backup_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Backup_List_Menu", id, key, matinh, mahuyen, maxa, mathon, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_List_Menu", id, key, matinh, mahuyen, maxa, mathon), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_GenMaHo(tpConnect As String, matinh As String, mahuyen As String, maxa As String, mathon As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_GenMaHo", matinh, mahuyen, maxa, mathon), Integer)
    End Function
    Public Overrides Function CMS_HoGD_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Backup_Get_By_YearID", id, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Get(tpConnect As String, id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, isNow As Boolean, Optional ByVal IsDuplicate As Boolean = False) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_List_Search", search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, loaiHo, currPage, recodperpage, isNow, IsDuplicate), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_List_Search_Deleted(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_List_Search_Deleted", search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, loaiHo, currPage, recodperpage, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_List_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_List_Backup", matinh, mahuyen, maxa, mathon, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Add(tpConnect As String, obj As CMS_HoGDInfo) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_Add", obj.Id, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaHo, obj.TenChuHo, obj.DiaChi, obj.SoNhanKhau, obj.LoaiHo, obj.IdSo, obj.LoaiBienDong, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID)
    End Function
    Public Overrides Sub CMS_HoGD_Update(tpConnect As String, obj As CMS_HoGDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update", obj.Id, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaHo, obj.TenChuHo, obj.DiaChi, obj.SoNhanKhau, obj.LoaiHo, obj.IdSo, obj.LoaiBienDong, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_BienDong(tpConnect As String, id As String, loaiBienDong As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_BienDong", id, loaiBienDong)
    End Sub
    Public Overrides Sub CMS_HoGD_Backup_Update_BienDong(tpConnect As String, ID As String, loaiBienDong As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Backup_Update_BienDong", ID, loaiBienDong, yearID)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_Move(tpConnect As String, id As String, chuyen As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_Move", id, chuyen)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_SoNhanKhau(tpConnect As String, id As String, soNhanKhau As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_SoNhanKhau", id, soNhanKhau)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_Delete", id, isDelete, deleteDate, deleteUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_SoSo(tpConnect As String, id As String, IdSo As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_SoSo", id, IdSo)
    End Sub
    Public Overrides Sub CMS_HoGD_Update_Name(tpConnect As String, id As String, Ten As String, type As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_Name", id, Ten, type)
    End Sub
    Public Overrides Function CMS_HoGD_Update_MaHo(tpConnect As String, index As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_Update_MaHo", index, matinh, mahuyen, maxa, mathon, idHo), String)
    End Function
    Public Overrides Sub CMS_HoGD_Update_Merger(tpConnect As String, ID As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, diachi As String, idSo As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Update_Merger", ID, matinh, mahuyen, maxa, mathon, diachi, idSo)
    End Sub
    Public Overrides Sub CMS_HoGD_Delete(tpConnect As String, id As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Delete", id)
    End Sub
    Public Overrides Sub CMS_HoGD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_BackupData", matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Overrides Function CMS_HoGD_RecoveryData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_RecoveryData", matinh, mahuyen, maxa, mathon, yearid), Integer)
    End Function
#End Region
#Region "CMS_HoGD_Khau"
    Public Overrides Function CMS_HoGD_Khau_List_Fix(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, errType As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_List_Fix", matinh, mahuyen, maxa, mathon, errType, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_HoGD_Khau_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_BackupData", matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Overrides Function CMS_HoGD_GenMaThanhVien(tpConnect As String, idHo As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_GenMaThanhVien", idHo), Integer)
    End Function
    Public Overrides Function CMS_HoGD_Khau_CheckCCCD(tpConnect As String, cmnd As String, Id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_CheckCCCD", cmnd, Id), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_Get(tpConnect As String, id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Get_By_YearID", id, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_List_ByIDHo", matinh, mahuyen, maxa, mathon, idHo), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_Backup_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_List_ByIDHo", matinh, mahuyen, maxa, mathon, idHo, yearID), IDataReader)
    End Function

    Public Overrides Function CMS_HoGD_Khau_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, currPage As Integer, recodperpage As Integer, isNow As Boolean, Optional ByVal yearCreated As Integer = 0) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_List_Search", search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, currPage, recodperpage, isNow, yearCreated), IDataReader)
    End Function
    Public Overrides Sub CMS_HoGD_Khau_Add(tpConnect As String, obj As CMS_HoGD_KhauInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_Khau_Add", obj.Id, obj.MaDoiTuong, obj.CMND, obj.IdHo, obj.MaHo, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.MaTinh_TT, obj.MaHuyen_TT, obj.MaXa_TT, obj.MaThon_TT, obj.DiaChi_TT, obj.DTUT_NKT, obj.DTUT_HN, obj.DTUT_DTTS, obj.DTUT_CN, obj.DTUT_THUHOI, obj.DTUT_NCC, obj.NCVL, obj.NTN, obj.KTGHDKT, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.CongViecDangLam, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.ThoiGianThatNghiep, obj.CongViecThamGia, obj.LyDoKhongThamGia, obj.GhiChu, obj.LoaiBienDong, obj.CatChet, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsDelete, flReg.GetNull(obj.DeletedDate), obj.DeletedUser, obj.PortalID, obj.ChuyenDen, obj.KhuVuc, obj.SoDienThoai, obj.SoBHXH, obj.ThamGiaBHXH, obj.ThamGiaBHXH_Loai, obj.HDLD, obj.LoaiHDLD, obj.ThoiGianHDLD, obj.DoanhNghiepLamViec, obj.LoaiHinhKT_DN, obj.MaTinh_NLV, obj.MaHuyen_NLV, obj.MaXa_NLV, obj.MaThon_NLV, obj.DiaChi_NLV, obj.IsDCTT, obj.IsDCHT)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Update(tpConnect As String, obj As CMS_HoGD_KhauInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Update", obj.Id, obj.MaDoiTuong, obj.CMND, obj.IdHo, obj.MaHo, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.MaTinh_TT, obj.MaHuyen_TT, obj.MaXa_TT, obj.MaThon_TT, obj.DiaChi_TT, obj.DTUT_NKT, obj.DTUT_HN, obj.DTUT_DTTS, obj.DTUT_CN, obj.DTUT_THUHOI, obj.DTUT_NCC, obj.NCVL, obj.NTN, obj.KTGHDKT, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.CongViecDangLam, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.ThoiGianThatNghiep, obj.CongViecThamGia, obj.LyDoKhongThamGia, obj.GhiChu, obj.LoaiBienDong, obj.CatChet, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsDelete, flReg.GetNull(obj.DeletedDate), obj.DeletedUser, obj.PortalID, obj.ChuyenDen, obj.KhuVuc, obj.SoDienThoai, obj.SoBHXH, obj.ThamGiaBHXH, obj.ThamGiaBHXH_Loai, obj.HDLD, obj.LoaiHDLD, obj.ThoiGianHDLD, obj.DoanhNghiepLamViec, obj.LoaiHinhKT_DN, obj.MaTinh_NLV, obj.MaHuyen_NLV, obj.MaXa_NLV, obj.MaThon_NLV, obj.DiaChi_NLV, obj.IsDCTT, obj.IsDCHT)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Update_Delete", id, isDelete, deleteDate, deleteUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Update_BienDong", idHo, idTv, loaiBienDong)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Backup_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Update_BienDong", idHo, idTv, loaiBienDong, yearID)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_TDHV(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_TDHV", id, valKey, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_TDGD(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_TDGD", id, valKey, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_CMKT(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_CMKT", id, valKey, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_CVLTN(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_CVLTN", id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_CVLKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_CVLKHDKT", id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_TNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_TNKHDKT", id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_KVLKTNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, valKey3 As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_KVLKTNKHDKT", id, valKey, valKey2, valKey3, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Fix_NganhNghe(tpConnect As String, id As String, valKey As String, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Fix_NganhNghe", id, valKey, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Delete(tpConnect As String, id As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Delete", id)
    End Sub
#End Region
#Region "CMS_Provide_History"
    Public Overrides Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_History_Get", history_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_History_List(tpConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_History_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_Provide_History_Add", obj.History_ID, obj.History_Name, obj.History_Des, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.IsFlag, obj.TotalHoAdd, obj.TotalKhauAdd, obj.TotalHo, obj.TotalKhau, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_History_Update", obj.History_ID, obj.History_Name, obj.History_Des, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.IsFlag, obj.TotalHoAdd, obj.TotalKhauAdd, obj.TotalHo, obj.TotalKhau, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_History_Delete", history_ID)
    End Sub

    Public Overrides Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, huyen As Integer, xa As Integer, maDvi As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_History_Get_Send", tinhTP, huyen, xa, maDvi), IDataReader)
    End Function
#End Region
#Region "CMS_HoGD_Backup"
    Public Overrides Function CMS_HoGD_Backup_Get(tpConnect As String, idBackup As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Backup_Get", idBackup), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Backup_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Backup_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Backup_Add(tpConnect As String, obj As CMS_HoGD_BackupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_Backup_Add", obj.Id, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaHo, obj.TenChuHo, obj.DiaChi, obj.SoNhanKhau, obj.LoaiHo, obj.IdSo, obj.LoaiBienDong, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag), Integer)
    End Function
    Public Overrides Sub CMS_HoGD_Backup_Update(tpConnect As String, obj As CMS_HoGD_BackupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Backup_Update", obj.IdBackup, obj.Id, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaHo, obj.TenChuHo, obj.DiaChi, obj.SoNhanKhau, obj.LoaiHo, obj.IdSo, obj.LoaiBienDong, obj.YearID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag)
    End Sub
    Public Overrides Sub CMS_HoGD_Backup_Delete(tpConnect As String, idBackup As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Backup_Delete", idBackup)
    End Sub
#End Region
#Region "CMS_HoGD_Khau_Backup"
    Public Overrides Function CMS_HoGD_Khau_Backup_Get(tpConnect As String, idBackup As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Get", idBackup), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_Backup_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_HoGD_Khau_Backup_Add(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Add", obj.Id, obj.MaDoiTuong, obj.CMND, obj.IdHo, obj.MaHo, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.CongViecThamGia, obj.ThoiGianThatNghiep, obj.LyDoKhongThamGia, obj.GhiChu, obj.LoaiBienDong, obj.CatChet, obj.Year, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag, obj.JoinHDKT, obj.UnJoinHDKT), Integer)
    End Function
    Public Overrides Sub CMS_HoGD_Khau_Backup_Update(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Update", obj.IdBackup, obj.Id, obj.MaDoiTuong, obj.CMND, obj.IdHo, obj.MaHo, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.CongViecThamGia, obj.ThoiGianThatNghiep, obj.LyDoKhongThamGia, obj.GhiChu, obj.LoaiBienDong, obj.CatChet, obj.Year, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag)
    End Sub
    Public Overrides Sub CMS_HoGD_Khau_Backup_Delete(tpConnect As String, idBackup As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_HoGD_Khau_Backup_Delete", idBackup)
    End Sub
#End Region
#Region "CMS_Provide_Config"

    Public Overrides Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_List_Search", tinhTP, isActive, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, active As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_Get_Active", TinhTP, active), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get_Value(tpConnect As String, TinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_Get_Value", TinhTP, QuanHuyen, PhuongXa, ThonTo, proconfig_value), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_Get", proConfig_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinh As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Config_List_ByTinh", tinh), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_Config_Add(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, isOrder As Integer)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_Provide_Config_Add", proConfig_ID, tinhTP, QuanHuyen, PhuongXa, ThonTo, proConfig_Name, proConfig_Value, isActive, isLock, isFlag, flReg.GetNull(createdDate), createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, isOrder)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Update(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_Config_Update", proConfig_ID, tinhTP, QuanHuyen, PhuongXa, ThonTo, proConfig_Name, proConfig_Value, isActive, flReg.GetNull(isLock), isFlag, flReg.GetNull(createdDate), createdUser, flReg.GetNull(updatedDate), updatedUser, portalId, isOrder)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_Config_Delete", proConfig_ID)
    End Sub
    Public Overrides Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_Config_Delete", proConfig_ID, active)
    End Sub
#End Region
#Region "CMS_Provide_Book"
    Public Overrides Function CMS_Provide_Book_Get(tpConnect As String, book_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Book_Get", book_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_Book_List(tpConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_Book_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_Book_Add(tpConnect As String, obj As CMS_Provide_BookInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_Provide_Book_Add", obj.Book_ID, obj.Book_Code, obj.Book_Name, obj.Year, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Provide_Book_Update(tpConnect As String, obj As CMS_Provide_BookInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_Book_Update", obj.Book_ID, obj.Book_Code, obj.Book_Name, obj.Year, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Provide_Book_Delete(tpConnect As String, book_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_Book_Delete", book_ID)
    End Sub
#End Region
#Region "CMS_CareerCLD"
    Public Overrides Function CMS_CareerCLD_Get(PortalConnect As String, CareerCLD_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CareerCLD_Get", CareerCLD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CareerCLD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CareerCLD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_Add(PortalConnect As String, obj As CMS_CareerCLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_CareerCLD_Add", obj.CareerCLD_Name, obj.CareerCLD_Code, obj.CareerCLD_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate), Integer)
    End Function
    Public Overrides Sub CMS_CareerCLD_Update(PortalConnect As String, obj As CMS_CareerCLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_CareerCLD_Update", obj.CareerCLD_ID, obj.CareerCLD_Name, obj.CareerCLD_Code, obj.CareerCLD_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_CareerCLD_Delete(PortalConnect As String, CareerCLD_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_CareerCLD_Delete", CareerCLD_ID)
    End Sub
#End Region
#Region "CMS_Method"
    Public Overrides Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Method_Get", method_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Method_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Method_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Method_Add(PortalConnect As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Method_Add", method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Method_Update(PortalConnect As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Method_Update", method_ID, method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Method_Delete", method_ID)
    End Sub
    Public Overrides Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Method_Update_Quick", method_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Reason"
    Public Overrides Function CMS_Reason_Get(PortalConnect As String, reason_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Reason_Get", reason_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Reason_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Reason_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Reason_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Reason_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Reason_Add(PortalConnect As String, reason_Code As String, reason_Name As String, reason_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Reason_Add", reason_Code, reason_Name, reason_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Reason_Update(PortalConnect As String, reason_ID As Integer, reason_Code As String, reason_Name As String, reason_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Reason_Update", reason_ID, reason_Code, reason_Name, reason_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Reason_Delete(PortalConnect As String, reason_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Reason_Delete", reason_ID)
    End Sub
    Public Overrides Sub CMS_Reason_Update_Quick(PortalConnect As String, reason_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Reason_Update_Quick", reason_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Specialize"
    Public Overrides Function CMS_Specialize_Get(PortalConnect As String, specialize_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Specialize_Get", specialize_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_GetByCode(PortalConnect As String, specialize_code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Specialize_GetByCode", specialize_code), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Specialize_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Specialize_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Specialize_Add(PortalConnect As String, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Specialize_Add", specialize_Code, specialize_Name, specialize_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Specialize_Update(PortalConnect As String, specialize_ID As Integer, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Specialize_Update", specialize_ID, specialize_Code, specialize_Name, specialize_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Specialize_Delete(PortalConnect As String, specialize_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Specialize_Delete", specialize_ID)
    End Sub
    Public Overrides Sub CMS_Specialize_Update_Quick(PortalConnect As String, specialize_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Specialize_Update_Quick", specialize_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Education"
    Public Overrides Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Education_Get", Education_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Education_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Education_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Education_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Education_Add(PortalConnect As String, Education_Code As String, Education_Name As String, Education_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Education_Add", Education_Code, Education_Name, Education_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Education_Update(PortalConnect As String, Education_ID As Integer, Education_Code As String, Education_Name As String, Education_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Education_Update", Education_ID, Education_Code, Education_Name, Education_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Education_Delete", Education_ID)
    End Sub
    Public Overrides Sub CMS_Education_Update_Quick(PortalConnect As String, Education_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Education_Update_Quick", Education_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_LoaiSo"
    Public Overrides Function CMS_LoaiSo_Get(PortalConnect As String, LoaiSo_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_LoaiSo_Get", LoaiSo_ID), IDataReader)
    End Function
    Public Overrides Function CMS_LoaiSo_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_LoaiSo_List"), IDataReader)
    End Function
    Public Overrides Function CMS_LoaiSo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_LoaiSo_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_LoaiSo_Add(PortalConnect As String, LoaiSo_Code As String, LoaiSo_Name As String, isActive As Boolean, isOrder As Integer, isDeleted As Boolean) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_LoaiSo_Add", LoaiSo_Code, LoaiSo_Name, isActive, isOrder, isDeleted), Integer)
    End Function
    Public Overrides Sub CMS_LoaiSo_Update(PortalConnect As String, LoaiSo_ID As Integer, LoaiSo_Code As String, LoaiSo_Name As String, isActive As Boolean, isOrder As Integer, isDeleted As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_LoaiSo_Update", LoaiSo_ID, LoaiSo_Code, LoaiSo_Name, isActive, isOrder, isDeleted)
    End Sub
    Public Overrides Sub CMS_LoaiSo_Delete(PortalConnect As String, LoaiSo_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_LoaiSo_Delete", LoaiSo_ID)
    End Sub
    Public Overrides Sub CMS_LoaiSo_Update_Quick(PortalConnect As String, LoaiSo_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_LoaiSo_Update_Quick", LoaiSo_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Trainning"
    Public Overrides Function CMS_Trainning_Get(PortalConnect As String, trainning_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Trainning_Get", trainning_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Trainning_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Trainning_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Trainning_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Trainning_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Trainning_Add(PortalConnect As String, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Trainning_Add", trainning_Code, trainning_Name, trainning_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Trainning_Update(PortalConnect As String, trainning_ID As Integer, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Trainning_Update", trainning_ID, trainning_Code, trainning_Name, trainning_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Trainning_Delete(PortalConnect As String, trainning_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Trainning_Delete", trainning_ID)
    End Sub
    Public Overrides Sub CMS_Trainning_Update_Quick(PortalConnect As String, trainning_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Trainning_Update_Quick", trainning_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_TypeEco"
    Public Overrides Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeEco_Get", typeEco_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeEco_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeEco_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_TypeEco_Add(PortalConnect As String, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_TypeEco_Add", typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_TypeEco_Update(PortalConnect As String, typeEco_ID As Integer, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeEco_Update", typeEco_ID, typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeEco_Delete", typeEco_ID)
    End Sub
    Public Overrides Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeEco_Update_Quick", typeEco_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_WorkJoin"
    Public Overrides Function CMS_WorkJoin_Get(PortalConnect As String, workJoin_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_WorkJoin_Get", workJoin_ID), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_WorkJoin_List"), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_WorkJoin_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_Add(PortalConnect As String, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_WorkJoin_Add", workJoin_Code, workJoin_Name, workJoin_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_WorkJoin_Update(PortalConnect As String, workJoin_ID As Integer, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_WorkJoin_Update", workJoin_ID, workJoin_Code, workJoin_Name, workJoin_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_WorkJoin_Delete(PortalConnect As String, workJoin_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_WorkJoin_Delete", workJoin_ID)
    End Sub
    Public Overrides Sub CMS_WorkJoin_Update_Quick(PortalConnect As String, workJoin_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_WorkJoin_Update_Quick", workJoin_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_TypeUnemploy"
    Public Overrides Function CMS_TypeUnemploy_Get(PortalConnect As String, TypeUnemploy_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeUnemploy_Get", TypeUnemploy_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeUnemploy_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeUnemploy_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TypeUnemploy_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_TypeUnemploy_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_TypeUnemploy_Add(PortalConnect As String, TypeUnemploy_Code As String, TypeUnemploy_Name As String, TypeUnemploy_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_TypeUnemploy_Add", TypeUnemploy_Code, TypeUnemploy_Name, TypeUnemploy_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_TypeUnemploy_Update(PortalConnect As String, TypeUnemploy_ID As Integer, TypeUnemploy_Code As String, TypeUnemploy_Name As String, TypeUnemploy_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeUnemploy_Update", TypeUnemploy_ID, TypeUnemploy_Code, TypeUnemploy_Name, TypeUnemploy_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_TypeUnemploy_Delete(PortalConnect As String, TypeUnemploy_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeUnemploy_Delete", TypeUnemploy_ID)
    End Sub
    Public Overrides Sub CMS_TypeUnemploy_Update_Quick(PortalConnect As String, TypeUnemploy_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_TypeUnemploy_Update_Quick", TypeUnemploy_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Provide_BienDongKhau"
    Public Overrides Function CMS_Provide_BienDongKhau_Get(tpConnect As String, bienDong_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_BienDongKhau_Get", bienDong_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_BienDongKhau_List(tpConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_BienDongKhau_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_BienDongKhau_Add(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_Provide_BienDongKhau_Add", obj.BienDong_ID, obj.IdKey, obj.IdPa, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThonTo, obj.LoaiBienDong, obj.GiaTriBDMoi, obj.GiaTriBDCu, obj.IsFlag, obj.YearID, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_BienDongKhau_Update(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_BienDongKhau_Update", obj.BienDong_ID, obj.IdKey, obj.IdPa, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThonTo, obj.LoaiBienDong, obj.GiaTriBDMoi, obj.GiaTriBDCu, obj.IsFlag, obj.YearID, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_BienDongKhau_Delete(tpConnect As String, bienDong_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_BienDongKhau_Delete", bienDong_ID)
    End Sub
#End Region
#Region "CMS_Provide_BienDongHo"
    Public Overrides Function CMS_Provide_BienDongHo_Get(tpConnect As String, bienDong_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_BienDongHo_Get", bienDong_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Provide_BienDongHo_List(tpConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Provide_BienDongHo_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_Provide_BienDongHo_Add(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
        SqlHelper.ExecuteScalar(flConnect.CungConnect, "CMS_Provide_BienDongHo_Add", obj.BienDong_ID, obj.IdKey, obj.IdPa, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThonTo, obj.LoaiBienDong, obj.GiaTriBDMoi, obj.GiaTriBDCu, obj.IsFlag, obj.YearID, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_BienDongHo_Update(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_BienDongHo_Update", obj.BienDong_ID, obj.IdKey, obj.IdPa, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThonTo, obj.LoaiBienDong, obj.GiaTriBDMoi, obj.GiaTriBDCu, obj.IsFlag, obj.YearID, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_Provide_BienDongHo_Delete(tpConnect As String, bienDong_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_Provide_BienDongHo_Delete", bienDong_ID)
    End Sub
#End Region
#Region "Report-CungLD"
    Public Overrides Sub CMS_BCTH_ClearData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer)
        SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_BCTH_ClearData", matinh, mahuyen, maxa, mathon, year, typeData)
    End Sub
    Public Overrides Function CMS_CungLD_Report0(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report0", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report0_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report0_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Function CMS_CungLD_Report1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report1", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report1_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Sub CMS_CungLD_Report2_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report2_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Function CMS_CungLD_Report2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report2", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Report3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report3", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report3_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report3_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Sub CMS_CungLD_Report4_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report4_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Function CMS_CungLD_Report4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report4", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Report5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report5", matinh, mahuyen, maxa, mathon, year), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Report5_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report5_1", matinh, mahuyen, maxa, mathon, year), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report5_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report5_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Sub CMS_CungLD_Report5_1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, dotuoiTu As Integer, doTuoiDen As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report5_1_TH", matinh, mahuyen, maxa, mathon, year, isNow, dotuoiTu, doTuoiDen)
    End Sub
    Public Overrides Function CMS_CungLD_Report6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report6", matinh, mahuyen, maxa, mathon, year), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report6_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report6_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Sub CMS_CungLD_Report7_TH(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, madonvi As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report7_TH", phanloai, matinh, mahuyen, maxa, madonvi, year, isNow)
    End Sub
    Public Overrides Function CMS_CungLD_Report7(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, madonvi As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report7", phanloai, matinh, mahuyen, maxa, madonvi, year), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Report8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report8", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Report9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report9", matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), IDataReader)
    End Function
    Public Overrides Sub CMS_CungLD_Report9_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report9_TH", matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Overrides Sub CMS_CungLD_Report10_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, typeData As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "CMS_CungLD_Report10_TH", matinh, mahuyen, maxa, mathon, year, isNow, typeData)
    End Sub
    Public Overrides Function CMS_CungLD_Report10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_Report10", matinh, mahuyen, maxa, mathon, year, typeData), IDataReader)
    End Function

    Public Overrides Function CMS_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_1" & sqlTb, matinh, mahuyen, maxa, year, isFlag), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_1" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_2" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_2" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub
    Public Overrides Function CMS_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_3" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_3" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_4" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_4" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_5" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_5" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_6" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_6" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_7" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_7" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_8" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_8" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_9" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_9" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub


    Public Overrides Function CMS_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH1_10" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH1_10" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub


    Public Overrides Function CMS_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH11a" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH11a" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH12a" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH12a" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH13a" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH13a" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH11a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH11a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH12a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH12a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH13a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH13a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Overrides Function CMS_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH14a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH14a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH15a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH15a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH16a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH16a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH17a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH17a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH18a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH18a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH19a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH19a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH20a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH20a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH21a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH21a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH22a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH22a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH23a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH23a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH24a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH24a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH25a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH25a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH26a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH26a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH27a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH27a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub

    Public Overrides Function CMS_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH28a_CVL" & sqlTb, matinh, mahuyen, maxa, year, isFlag, level), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH28a_CVL", matinh, mahuyen, maxa, year, isNow, isFlag, level)
    End Sub
    Public Overrides Function CMS_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isFlag As Int16, level As Integer, parentID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report_BCTH29a_CVL", matinh, mahuyen, maxa, year, isFlag, level, parentID), IDataReader)
    End Function
    Public Overrides Sub RUN_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, isFlag As Int16, strRow As String, level As Integer, parentID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RUN_Report_BCTH29a_CVL", matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub
    Public Overrides Function CMS_CungLD_CustomReport(tpConnect As String, matinh As Int16, maHuyen As Integer, maXa As Integer, levelHC As Integer, rowID As Integer, colID As String, isNow As Boolean, years As Integer, typeRow As Int16, typeCol As Int16, option1 As String, option2 As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_CungLD_CustomReport" & option1, matinh, maHuyen, maXa, levelHC, rowID, colID, isNow, years, typeRow, typeCol, option2), IDataReader)
    End Function
#End Region
#Region "CMS_CungLD"
    Public Overrides Function CMS_CungLD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CungLD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CungLD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_CungLD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_CungLD_Add(PortalConnect As String, obj As CMS_CungLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_CungLD_Add", obj.MaBC, obj.TenBaoCao, obj.MoTa, obj.IsFlag, obj.IsActive, obj.TenVietTat), Integer)
    End Function
    Public Overrides Sub CMS_CungLD_Update(PortalConnect As String, obj As CMS_CungLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_CungLD_Update", obj.ID, obj.MaBC, obj.TenBaoCao, obj.MoTa, obj.IsFlag, obj.IsActive, obj.TenVietTat)
    End Sub
    Public Overrides Sub CMS_CungLD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_CungLD_Delete", iD)
    End Sub
#End Region
#Region "CMS_Age"
    Public Overrides Function CMS_Age_Get(PortalConnect As String, age_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Age_Get", age_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Age_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmcConnect, "CMS_Age_List"), IDataReader)
    End Function

    Public Overrides Function CMS_Age_Add(PortalConnect As String, obj As CMS_AgeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmcConnect, "CMS_Age_Add", obj.Age_Code, obj.Age_Name, obj.AgeMin, obj.AgeMax, obj.AgeType, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Age_Update(PortalConnect As String, obj As CMS_AgeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Age_Update", obj.Age_ID, obj.Age_Code, obj.Age_Name, obj.AgeMin, obj.AgeMax, obj.AgeType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Age_Delete(PortalConnect As String, age_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmcConnect, "CMS_Age_Delete", age_ID)
    End Sub
#End Region
#Region "TH27_M01"
    Public Overrides Function TH27_M01_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M01_Get", iD), IDataReader)
    End Function
    Public Overrides Function TH27_M01_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M01_List"), IDataReader)
    End Function
    Public Overrides Function TH27_M01_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M01_List_Search", tinhTP, quanHuyen, xaPhuong, years, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function TH27_M01_Add(PortalConnect As String, obj As TH27_M01Info) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "TH27_M01_Add", obj.Years, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub TH27_M01_Update(PortalConnect As String, obj As TH27_M01Info)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M01_Update", obj.ID, obj.Years, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub TH27_M01_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M01_Delete", iD)
    End Sub
#End Region
#Region "TH27_M02"
    Public Overrides Function TH27_M02_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M02_Get", iD), IDataReader)
    End Function
    Public Overrides Function TH27_M02_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M02_List"), IDataReader)
    End Function
    Public Overrides Function TH27_M02_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M02_List_Search", tinhTP, quanHuyen, years, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function TH27_M02_Add(PortalConnect As String, obj As TH27_M02Info) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "TH27_M02_Add", obj.Years, obj.TinhTP, obj.QuanHuyen, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub TH27_M02_Update(PortalConnect As String, obj As TH27_M02Info)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M02_Update", obj.ID, obj.Years, obj.TinhTP, obj.QuanHuyen, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub TH27_M02_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M02_Delete", iD)
    End Sub
#End Region
#Region "TH27_M03"
    Public Overrides Function TH27_M03_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M03_Get", iD), IDataReader)
    End Function
    Public Overrides Function TH27_M03_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M03_List"), IDataReader)
    End Function
    Public Overrides Function TH27_M03_List_Search(PortalConnect As String, tinhTP As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M03_List_Search", tinhTP, years, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function TH27_M03_Add(PortalConnect As String, obj As TH27_M03Info) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CungConnect, "TH27_M03_Add", obj.Years, obj.TinhTP, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub TH27_M03_Update(PortalConnect As String, obj As TH27_M03Info)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M03_Update", obj.ID, obj.Years, obj.TinhTP, obj.MaBC, obj.TenBC, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub TH27_M03_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M03_Delete", iD)
    End Sub
#End Region
#Region "TH27_M01_A"
    Public Overrides Sub RPT_TH27_M01_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M01_A_RUN", m01ID, years, tinhTP, quanHuyen, xaPhuong)
    End Sub
    Public Overrides Function TH27_M01_A_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M01_A_Get_By_TH27_M01", iD), IDataReader)
    End Function
    Public Overrides Sub TH27_M01_A_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M01_A_Delete_By_TH27_M01", iD)
    End Sub
#End Region
#Region "TH27_M01_B"
    Public Overrides Sub RPT_TH27_M01_B_RUN(PortalConnect As String, m01ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, maThon As Integer, tenThon As String, years As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M01_B_RUN", m01ID, sTT, tinhTP, quanHuyen, xaPhuong, maThon, tenThon, years)
    End Sub
    Public Overrides Sub TH27_M01_B_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M01_B_Delete_By_TH27_M01", iD)
    End Sub
    Public Overrides Function TH27_M01_B_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M01_B_Get_By_TH27_M01", iD), IDataReader)
    End Function
#End Region
#Region "TH27_M02_A"
    Public Overrides Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m02ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M02_A_RUN", m02ID, years, tinhTP, quanHuyen)
    End Sub
    Public Overrides Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M02_A_Get_By_TH27_M02", iD), IDataReader)
    End Function
    Public Overrides Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M02_A_Delete_By_TH27_M02", iD)
    End Sub
#End Region
#Region "TH27_M02_B"
    Public Overrides Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M02_B_RUN", m02ID, sTT, tinhTP, quanHuyen, xaPhuong, tenXaPhuong, years)
    End Sub
    Public Overrides Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M02_B_Get_By_TH27_M02", iD), IDataReader)
    End Function
    Public Overrides Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M02_B_Delete_By_TH27_M02", iD)
    End Sub
#End Region
#Region "TH27_M03_A"
    Public Overrides Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m03ID As Integer, years As Integer, tinhTP As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M03_A_RUN", m03ID, years, tinhTP)
    End Sub
    Public Overrides Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M03_A_Get_By_TH27_M03", iD), IDataReader)
    End Function
    Public Overrides Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M03_A_Delete_By_TH27_M03", iD)
    End Sub
#End Region
#Region "TH27_M03_B"
    Public Overrides Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m03ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "RPT_TH27_M03_B_RUN", m03ID, sTT, tinhTP, quanHuyen, tenQuanHuyen, years)
    End Sub
    Public Overrides Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "TH27_M03_B_Get_By_TH27_M03", iD), IDataReader)
    End Function
    Public Overrides Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CungConnect, "TH27_M03_B_Delete_By_TH27_M03", iD)
    End Sub
#End Region
#Region "API"
    Public Overrides Function API_CungLD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, tto As Integer, year As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "API_CungLD_01", tp, qh, xp, tto, year, isNow), IDataReader)
    End Function
    Public Overrides Function API_CungLD_02(PortalConnect As String, tp As Integer, maHo As String, loaiHo As Integer, year As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "API_CungLD_02", tp, maHo, loaiHo, year, isNow), IDataReader)
    End Function
    Public Overrides Function API_CungLD_03(PortalConnect As String, tp As Integer, gt As Integer, cmkt As Integer, tdgd As Integer, tinhtrang As Integer, year As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "API_CungLD_03", tp, gt, cmkt, tdgd, tinhtrang, year, isNow), IDataReader)
    End Function
#End Region

#Region "REPORT CHART"
    Public Overrides Function CMS_Report13(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report13", tp, qh, xp, year, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_Report13_1(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Report13_1", tp, qh, xp, year, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_Chart_Data(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Chart" & maBC, tp, qh, xp, year, isNow), IDataReader)
    End Function
    Public Overrides Function CMS_Chart_DataHC(PortalConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "CMS_Chart_DataHC" & maBC, tp, qh, ids, year, isNow), IDataReader)
    End Function
#End Region
#Region "MAP"

#End Region
End Class

