Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
    Inherits DataProvider

#Region "Bot"
    Public Overrides Function Bot_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bot_Get", id), IDataReader)
    End Function
    Public Overrides Function Bot_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bot_List"), IDataReader)
    End Function
    Public Overrides Function Bot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bot_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function Bot_Add(PortalConnect As String, obj As BotInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "Bot_Add", obj.Id, obj.TenBot, obj.TenChatBot, obj.Logo, obj.SoYHieu, obj.SoTrichDan, obj.GhiChu, obj.LoaiBot, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub Bot_Update(PortalConnect As String, obj As BotInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Bot_Update", obj.Id, obj.TenBot, obj.TenChatBot, obj.Logo, obj.SoYHieu, obj.SoTrichDan, obj.GhiChu, obj.LoaiBot, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub Bot_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Bot_Delete", id, userId)
    End Sub
    Public Overrides Function Bot_Copy(PortalConnect As String, idBot As Integer, IdUser As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "Bot_Copy", idBot, IdUser), Integer)
    End Function
#End Region
#Region "Bien"
    Public Overrides Function Bien_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bien_Get", id), IDataReader)
    End Function
    Public Overrides Function Bien_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bien_List"), IDataReader)
    End Function
    Public Overrides Function Bien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bien_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function Bien_List_By_IdBoBien(PortalConnect As String, idBoBien As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Bien_List_By_IdBoBien", idBoBien), IDataReader)
    End Function
    Public Overrides Function Bien_Add(PortalConnect As String, obj As BienInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "Bien_Add", obj.Id, obj.IdThucThe, obj.TenBien, obj.KeyBien, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub Bien_Update(PortalConnect As String, obj As BienInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Bien_Update", obj.Id, obj.IdThucThe, obj.TenBien, obj.KeyBien, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub Bien_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Bien_Delete", id, userId)
    End Sub
#End Region
#Region "BoBien"
    Public Overrides Function BoBien_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "BoBien_Get", id), IDataReader)
    End Function
    Public Overrides Function BoBien_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "BoBien_List"), IDataReader)
    End Function
    Public Overrides Function BoBien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "BoBien_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function BoBien_Add(PortalConnect As String, obj As BoBienInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "BoBien_Add", obj.Id, obj.IdBien, obj.TenBoBien, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub BoBien_Update(PortalConnect As String, obj As BoBienInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "BoBien_Update", obj.Id, obj.IdBien, obj.TenBoBien, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub BoBien_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "BoBien_Delete", id, userId)
    End Sub
#End Region
#Region "ThucThe"
    Public Overrides Function ThucThe_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "ThucThe_Get", id), IDataReader)
    End Function
    Public Overrides Function ThucThe_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "ThucThe_List"), IDataReader)
    End Function
    Public Overrides Function ThucThe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "ThucThe_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function ThucThe_Add(PortalConnect As String, obj As ThucTheInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "ThucThe_Add", obj.Id, obj.TenThucThe, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.Color), Integer)
    End Function
    Public Overrides Sub ThucThe_Update(PortalConnect As String, obj As ThucTheInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "ThucThe_Update", obj.Id, obj.TenThucThe, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.Color)
    End Sub
    Public Overrides Sub ThucThe_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "ThucThe_Delete", id, userId)
    End Sub
#End Region
#Region "TuDongNghia"
    Public Overrides Function TuDongNghia_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuDongNghia_Get", id), IDataReader)
    End Function
    Public Overrides Function TuDongNghia_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuDongNghia_List"), IDataReader)
    End Function
    Public Overrides Function TuDongNghia_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuDongNghia_List_Search", search, isOrder, currPage, recodperpage, UserName, idThucThe), IDataReader)
    End Function

    Public Overrides Function TuDongNghia_Add(PortalConnect As String, obj As TuDongNghiaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "TuDongNghia_Add", obj.IdThucThe, obj.TenTuDongNghia, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub TuDongNghia_Update(PortalConnect As String, obj As TuDongNghiaInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TuDongNghia_Update", obj.Id, obj.IdThucThe, obj.TenTuDongNghia, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub TuDongNghia_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TuDongNghia_Delete", id, userId)
    End Sub
#End Region
#Region "CauMau"
    Public Overrides Function CauMau_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CauMau_Get", id), IDataReader)
    End Function
    Public Overrides Function CauMau_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CauMau_List"), IDataReader)
    End Function
    Public Overrides Function CauMau_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CauMau_List_Search", search, isOrder, currPage, recodperpage, UserName, idThucThe), IDataReader)
    End Function

    Public Overrides Function CauMau_Add(PortalConnect As String, obj As CauMauInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "CauMau_Add", obj.IdThucThe, obj.TenCauMau, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CauMau_Update(PortalConnect As String, obj As CauMauInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "CauMau_Update", obj.Id, obj.IdThucThe, obj.TenCauMau, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CauMau_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "CauMau_Delete", id, userId)
    End Sub
    Public Overrides Sub CauMau_DeleteNhan(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "CauMau_DeleteNhan", id, userId)
    End Sub
#End Region
#Region "YDinh"
    Public Overrides Function YDinh_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "YDinh_Get", id), IDataReader)
    End Function
    Public Overrides Function YDinh_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "YDinh_List"), IDataReader)
    End Function
    Public Overrides Function YDinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "YDinh_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function YDinh_Add(PortalConnect As String, obj As YDinhInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "YDinh_Add", obj.TenYDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub YDinh_Update(PortalConnect As String, obj As YDinhInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "YDinh_Update", obj.Id, obj.TenYDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub YDinh_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "YDinh_Delete", id, userId)
    End Sub
#End Region
#Region "NhomTuKhoa"
    Public Overrides Function NhomTuKhoa_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomTuKhoa_Get", id), IDataReader)
    End Function
    Public Overrides Function NhomTuKhoa_List(PortalConnect As String, idBot As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomTuKhoa_List", idBot), IDataReader)
    End Function
    Public Overrides Function NhomTuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomTuKhoa_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function NhomTuKhoa_Add(PortalConnect As String, obj As NhomTuKhoaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "NhomTuKhoa_Add", obj.IdBot, obj.TenNhom, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub NhomTuKhoa_Update(PortalConnect As String, obj As NhomTuKhoaInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "NhomTuKhoa_Update", obj.Id, obj.IdBot, obj.TenNhom, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub NhomTuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "NhomTuKhoa_Delete", id, userId)
    End Sub
#End Region
#Region "TuKhoa"
    Public Overrides Function TuKhoa_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuKhoa_Get", id), IDataReader)
    End Function
    Public Overrides Function TuKhoa_List(PortalConnect As String, idBot As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuKhoa_List", idBot), IDataReader)
    End Function
    Public Overrides Function TuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomTuKhoa As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TuKhoa_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName, idNhomTuKhoa), IDataReader)
    End Function

    Public Overrides Function TuKhoa_Add(PortalConnect As String, obj As TuKhoaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "TuKhoa_Add", obj.IdBot, obj.IdNhomTuKhoa, obj.TenTuKhoa, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub TuKhoa_Update(PortalConnect As String, obj As TuKhoaInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TuKhoa_Update", obj.Id, obj.IdBot, obj.IdNhomTuKhoa, obj.TenTuKhoa, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub TuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TuKhoa_Delete", id, userId)
    End Sub
#End Region
#Region "NhomKichBan"
    Public Overrides Function NhomKichBan_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomKichBan_Get", id), IDataReader)
    End Function
    Public Overrides Function NhomKichBan_List(PortalConnect As String, idBot As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomKichBan_List", idBot), IDataReader)
    End Function
    Public Overrides Function NhomKichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomKichBan_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function NhomKichBan_Add(PortalConnect As String, obj As NhomKichBanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "NhomKichBan_Add", obj.IdBot, obj.TenNhomKichBan, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub NhomKichBan_Update(PortalConnect As String, obj As NhomKichBanInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "NhomKichBan_Update", obj.Id, obj.IdBot, obj.TenNhomKichBan, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub NhomKichBan_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "NhomKichBan_Delete", id, userId)
    End Sub
    Public Overrides Function NhomKichBan_Copy(PortalConnect As String, idNhomKichBan As Integer, IdUser As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "NhomKichBan_Copy", idNhomKichBan, IdUser), Integer)
    End Function
#End Region
#Region "KichBan"
    Public Overrides Function KichBan_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "KichBan_Get", id), IDataReader)
    End Function
    Public Overrides Function KichBan_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "KichBan_List"), IDataReader)
    End Function
    Public Overrides Function KichBan_List_ByTinNhan(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer, idKichBan As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "KichBan_List_ByTinNhan", idBot, idNhomKichBan, idKichBan), IDataReader)
    End Function
    Public Overrides Function KichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomKichBan As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "KichBan_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName, idNhomKichBan), IDataReader)
    End Function
    Public Overrides Function KichBan_ListSort(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "KichBan_ListSort", idBot, idNhomKichBan), IDataReader)
    End Function

    Public Overrides Function KichBan_Add(PortalConnect As String, obj As KichBanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "KichBan_Add", obj.IdBot, obj.IdNhomKichBan, obj.IdNhomTuKhoa, obj.IdYDinh, obj.TenKichBan, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub KichBan_Update(PortalConnect As String, obj As KichBanInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "KichBan_Update", obj.Id, obj.IdBot, obj.IdNhomKichBan, obj.IdNhomTuKhoa, obj.IdYDinh, obj.TenKichBan, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub KichBan_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "KichBan_Delete", id, userId)
    End Sub
    Public Overrides Function KichBan_Copy(PortalConnect As String, idKichBan As Integer, IdUser As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "KichBan_Copy", idKichBan, IdUser), Integer)
    End Function
    Public Overrides Function KichBan_Setting(PortalConnect As String, idKichBan As String, idNhomTuKhoa As Integer, idYDinh As Integer, typeSetting As Integer, IdUser As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "KichBan_Setting", idKichBan, idNhomTuKhoa, idYDinh, typeSetting, IdUser), Integer)
    End Function
    Public Overrides Function KichBan_Update_OrderBy(PortalConnect As String, idStr As String, idStr2 As String, idNhomKichBan As Integer, idNhomKichBan2 As Integer, userId As String) As Integer
        Return CType(SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "KichBan_Update_OrderBy", idStr, idStr2, idNhomKichBan, idNhomKichBan2, userId), Integer)
    End Function
#End Region
#Region "CaiDatBaoMat"
    Public Overrides Function CaiDatBaoMat_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CaiDatBaoMat_Get", id), IDataReader)
    End Function
    Public Overrides Function CaiDatBaoMat_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CaiDatBaoMat_List"), IDataReader)
    End Function
    Public Overrides Function CaiDatBaoMat_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "CaiDatBaoMat_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CaiDatBaoMat_Add(PortalConnect As String, obj As CaiDatBaoMatInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "CaiDatBaoMat_Add", obj.IdBot, obj.IdAdress, obj.Note, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CaiDatBaoMat_Update(PortalConnect As String, obj As CaiDatBaoMatInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "CaiDatBaoMat_Update", obj.Id, obj.IdBot, obj.IdAdress, obj.Note, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CaiDatBaoMat_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "CaiDatBaoMat_Delete", id, userId)
    End Sub
#End Region
#Region "MauEmail"
    Public Overrides Function MauEmail_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "MauEmail_Get", id), IDataReader)
    End Function
    Public Overrides Function MauEmail_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "MauEmail_List"), IDataReader)
    End Function
    Public Overrides Function MauEmail_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "MauEmail_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MauEmail_Add(PortalConnect As String, obj As MauEmailInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "MauEmail_Add", obj.IdBoBien, obj.TenMauEmail, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MauEmail_Update(PortalConnect As String, obj As MauEmailInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "MauEmail_Update", obj.Id, obj.IdBoBien, obj.TenMauEmail, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MauEmail_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "MauEmail_Delete", id, userId)
    End Sub
#End Region
#Region "TinNhan"
    Public Overrides Function TinNhan_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_Get", id), IDataReader)
    End Function
    Public Overrides Function TinNhan_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_List"), IDataReader)
    End Function
    Public Overrides Function TinNhan_List_Search(PortalConnect As String, idKichBan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, urlFile As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_List_Search", idKichBan, search, isOrder, currPage, recodperpage, UserName, urlFile), IDataReader)
    End Function

    Public Overrides Function TinNhan_Add(PortalConnect As String, obj As TinNhanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "TinNhan_Add", obj.IdBot, obj.IdKichBan, obj.IdKichBanLienKet, obj.IdNhomTuKhoa, obj.IdBoBien, obj.IdBien, obj.TenTinNhan, obj.NoiDung, obj.HinhAnh, obj.Url, obj.ViTri, obj.ThoiGian, obj.TapTin, obj.KieuHienThi, obj.PhanLoai, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDanhMay, obj.IdAPI, obj.IsCall, obj.KieuHienThi), Integer)
    End Function
    Public Overrides Sub TinNhan_Update(PortalConnect As String, obj As TinNhanInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhan_Update", obj.Id, obj.IdBot, obj.IdKichBan, obj.IdKichBanLienKet, obj.IdNhomTuKhoa, obj.IdBoBien, obj.IdBien, obj.TenTinNhan, obj.NoiDung, obj.HinhAnh, obj.Url, obj.ViTri, obj.ThoiGian, obj.TapTin, obj.KieuHienThi, obj.PhanLoai, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDanhMay, obj.IdAPI, obj.IsCall, obj.KieuHienThi)
    End Sub
    Public Overrides Sub TinNhan_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhan_Delete", id, userId)
    End Sub
    Public Overrides Sub TinNhan_KieuHienThi(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhan_KieuHienThi", id, userId)
    End Sub
    Public Overrides Function TinNhan_Update_OrderBy(PortalConnect As String, idStr As String, idKichBan As Integer, userId As String) As Integer
        Return CType(SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhan_Update_OrderBy", idStr, idKichBan, userId), Integer)
    End Function
#End Region
#Region "TinNhanSub"
    Public Overrides Function TinNhanSub_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhanSub_Get", id), IDataReader)
    End Function
    Public Overrides Function TinNhanSub_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhanSub_List"), IDataReader)
    End Function
    Public Overrides Function TinNhanSub_List_Search(PortalConnect As String, idTinNhan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional PhanLoai As Short = -1) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhanSub_List_Search", idTinNhan, search, isOrder, currPage, recodperpage, UserName, PhanLoai), IDataReader)
    End Function

    Public Overrides Function TinNhanSub_Add(PortalConnect As String, obj As TinNhanSubInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "TinNhanSub_Add", obj.IdTinNhan, obj.IdKichBan, obj.TenTinNhanSub, obj.Url, obj.Logo, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IdYDinh, obj.IdTuKhoa, obj.PhanLoai), Integer)
    End Function
    Public Overrides Sub TinNhanSub_Update(PortalConnect As String, obj As TinNhanSubInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhanSub_Update", obj.Id, obj.IdTinNhan, obj.IdKichBan, obj.TenTinNhanSub, obj.Url, obj.Logo, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IdYDinh, obj.IdTuKhoa, obj.PhanLoai)
    End Sub
    Public Overrides Function TinNhanSub_Update_OrderBy(PortalConnect As String, idStr As String, userId As String) As Integer
        Return CType(SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhanSub_Update_OrderBy", idStr, userId), Integer)
    End Function
    Public Overrides Sub TinNhanSub_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhanSub_Delete", id, userId)
    End Sub
    Public Overrides Sub TinNhanSub_Delete_All(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "TinNhanSub_Delete_All", id, userId)
    End Sub
#End Region
#Region "Email"
    Public Overrides Function Email_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Email_Get", id), IDataReader)
    End Function
    Public Overrides Function Email_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Email_List"), IDataReader)
    End Function
    Public Overrides Function Email_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "Email_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function Email_Add(PortalConnect As String, obj As EmailInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "Email_Add", obj.IdBoBien, obj.IdMauEmail, obj.TenEmail, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub Email_Update(PortalConnect As String, obj As EmailInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Email_Update", obj.Id, obj.IdBoBien, obj.IdMauEmail, obj.TenEmail, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub Email_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "Email_Delete", id, userId)
    End Sub
#End Region
#Region "HT_ThietLap"
    Public Overrides Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "HT_ThietLap_Get", id), IDataReader)
    End Function

    Public Overrides Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "HT_ThietLap_Add", obj.MaThietLap, obj.TenThietLap, obj.GiaTri, obj.GiaTriMacDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "HT_ThietLap_Update", obj.Id, obj.MaThietLap, obj.TenThietLap, obj.GiaTri, obj.GiaTriMacDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
#End Region
#Region "DaoTao"
    Public Overrides Function DaoTao_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "DaoTao_List_Search", idBot, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DaoTao_Add(PortalConnect As String, obj As DaoTaoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "DaoTao_Add", obj.IdBot, obj.TenTuKhoa, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub DaoTao_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "DaoTao_Delete", id, userId)
    End Sub
    Public Overrides Function DaoTao_Setting(PortalConnect As String, idKichBan As String, idNhomTuKhoa As Integer, IdUser As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "DaoTao_Setting", idKichBan, idNhomTuKhoa, IdUser), Integer)
    End Function
#End Region
#Region "API"
    Public Overrides Function API_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "API_Get", id), IDataReader)
    End Function
    Public Overrides Function API_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "API_List"), IDataReader)
    End Function
    Public Overrides Function API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "API_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function API_Add(PortalConnect As String, obj As APIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "API_Add", obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub API_Update(PortalConnect As String, obj As APIInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "API_Update", obj.Id, obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub API_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "API_Delete", id, userId)
    End Sub
#End Region
#Region "APIHeader"
    Public Overrides Function APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APIHeader_Get", id), IDataReader)
    End Function
    'Public Overrides Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    '    Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APIHeader_List", idAPI), IDataReader)
    'End Function

    Public Overrides Function APIHeader_Add(PortalConnect As String, obj As APIHeaderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "APIHeader_Add", obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub APIHeader_Update(PortalConnect As String, obj As APIHeaderInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "APIHeader_Update", obj.Id, obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "APIHeader_Delete", id, userId)
    End Sub
#End Region
#Region "HoiThoai"
    Public Overrides Function HoiThoai_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "HoiThoai_Get", id), IDataReader)
    End Function
    Public Overrides Function HoiThoai_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "HoiThoai_List"), IDataReader)
    End Function
    Public Overrides Function HoiThoai_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, trangThai As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "HoiThoai_List_Search", search, isOrder, currPage, recodperpage, UserName, trangThai), IDataReader)
    End Function

    Public Overrides Function HoiThoai_Add(PortalConnect As String, obj As HoiThoaiInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "HoiThoai_Add", obj.IdBot, obj.TenHoiThoai, obj.Ydinh, obj.DanhDauSao, obj.TrangThai, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Function HoiThoai_Delete(PortalConnect As String, id As String, userId As String) As Integer
        Return CType(SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "HoiThoai_Delete", id, userId), Integer)
    End Function
    Public Overrides Function HoiThoai_Sao(PortalConnect As String, id As String, userId As String, sao As Integer) As Integer
        Return CType(SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "HoiThoai_Sao", id, userId, sao), Integer)
    End Function
#End Region
#Region "TinHoiThoai"
    Public Overrides Function TinHoiThoai_List(PortalConnect As String, idHoiThoai As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinHoiThoai_List", idHoiThoai), IDataReader)
    End Function
    Public Overrides Function TinHoiThoai_Add(PortalConnect As String, obj As TinHoiThoaiInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().ChatbotConnect, "TinHoiThoai_Add", obj.IdHoiThoai, obj.NoiDungHTML, obj.NoiDungText, obj.Type, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function

#End Region
#Region "CHATBOT_DashBoard"
    Public Overrides Function CHATBOT_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.ChatbotConnect, "CHATBOT_DashBoard_Admin", year), IDataReader)
    End Function
    Public Overrides Function CHATBOT_DashBoard_HoiThoai(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.ChatbotConnect, "CHATBOT_DashBoard_HoiThoai"), IDataReader)
    End Function
#End Region
#Region "APISync"
    Public Overrides Function APISync_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APISync_Get", id), IDataReader)
    End Function
    Public Overrides Function APISync_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APISync_List"), IDataReader)
    End Function
    Public Overrides Sub APISync_Update(PortalConnect As String, obj As APISyncInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().ChatbotConnect, "APISync_Update", obj.Id, obj.IdAPI, obj.TenAPISync, obj.KieuDongBo, obj.ThoiGian, obj.NgayBatDau, obj.NgayKetThuc, obj.LichSu, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
#End Region



End Class

