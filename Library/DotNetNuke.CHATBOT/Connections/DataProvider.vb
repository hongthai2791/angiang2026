Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.CHATBOT", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region

#Region "Bot"
    Public MustOverride Function Bot_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function Bot_List(PortalConnect As String) As IDataReader
    Public MustOverride Function Bot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function Bot_Add(PortalConnect As String, obj As BotInfo) As Integer
    Public MustOverride Sub Bot_Update(PortalConnect As String, obj As BotInfo)
    Public MustOverride Sub Bot_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function Bot_Copy(PortalConnect As String, idBot As Integer, IdUser As String) As Integer
#End Region
#Region "Bien"
    Public MustOverride Function Bien_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function Bien_List(PortalConnect As String) As IDataReader
    Public MustOverride Function Bien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function Bien_List_By_IdBoBien(PortalConnect As String, idBoBien As Integer) As IDataReader
    Public MustOverride Function Bien_Add(PortalConnect As String, obj As BienInfo) As Integer
    Public MustOverride Sub Bien_Update(PortalConnect As String, obj As BienInfo)
    Public MustOverride Sub Bien_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "BoBien"
    Public MustOverride Function BoBien_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function BoBien_List(PortalConnect As String) As IDataReader
    Public MustOverride Function BoBien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function BoBien_Add(PortalConnect As String, obj As BoBienInfo) As Integer
    Public MustOverride Sub BoBien_Update(PortalConnect As String, obj As BoBienInfo)
    Public MustOverride Sub BoBien_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "ThucThe"
    Public MustOverride Function ThucThe_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function ThucThe_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ThucThe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function ThucThe_Add(PortalConnect As String, obj As ThucTheInfo) As Integer
    Public MustOverride Sub ThucThe_Update(PortalConnect As String, obj As ThucTheInfo)
    Public MustOverride Sub ThucThe_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "TuDongNghia"
    Public MustOverride Function TuDongNghia_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function TuDongNghia_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TuDongNghia_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As IDataReader

    Public MustOverride Function TuDongNghia_Add(PortalConnect As String, obj As TuDongNghiaInfo) As Integer
    Public MustOverride Sub TuDongNghia_Update(PortalConnect As String, obj As TuDongNghiaInfo)
    Public MustOverride Sub TuDongNghia_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "CauMau"
    Public MustOverride Function CauMau_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CauMau_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CauMau_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As IDataReader

    Public MustOverride Function CauMau_Add(PortalConnect As String, obj As CauMauInfo) As Integer
    Public MustOverride Sub CauMau_Update(PortalConnect As String, obj As CauMauInfo)
    Public MustOverride Sub CauMau_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Sub CauMau_DeleteNhan(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "YDinh"
    Public MustOverride Function YDinh_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function YDinh_List(PortalConnect As String) As IDataReader
    Public MustOverride Function YDinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function YDinh_Add(PortalConnect As String, obj As YDinhInfo) As Integer
    Public MustOverride Sub YDinh_Update(PortalConnect As String, obj As YDinhInfo)
    Public MustOverride Sub YDinh_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "NhomTuKhoa"
    Public MustOverride Function NhomTuKhoa_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function NhomTuKhoa_List(PortalConnect As String, idBot As Integer) As IDataReader
    Public MustOverride Function NhomTuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function NhomTuKhoa_Add(PortalConnect As String, obj As NhomTuKhoaInfo) As Integer
    Public MustOverride Sub NhomTuKhoa_Update(PortalConnect As String, obj As NhomTuKhoaInfo)
    Public MustOverride Sub NhomTuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "TuKhoa"
    Public MustOverride Function TuKhoa_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function TuKhoa_List(PortalConnect As String, idBot As Integer) As IDataReader
    Public MustOverride Function TuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomTuKhoa As Integer) As IDataReader

    Public MustOverride Function TuKhoa_Add(PortalConnect As String, obj As TuKhoaInfo) As Integer
    Public MustOverride Sub TuKhoa_Update(PortalConnect As String, obj As TuKhoaInfo)
    Public MustOverride Sub TuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "NhomKichBan"
    Public MustOverride Function NhomKichBan_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function NhomKichBan_List(PortalConnect As String, idBot As Integer) As IDataReader
    Public MustOverride Function NhomKichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function NhomKichBan_Add(PortalConnect As String, obj As NhomKichBanInfo) As Integer
    Public MustOverride Sub NhomKichBan_Update(PortalConnect As String, obj As NhomKichBanInfo)
    Public MustOverride Sub NhomKichBan_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function NhomKichBan_Copy(PortalConnect As String, idNhomKichBan As Integer, IdUser As String) As Integer
#End Region
#Region "KichBan"
    Public MustOverride Function KichBan_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function KichBan_List(PortalConnect As String) As IDataReader
    Public MustOverride Function KichBan_List_ByTinNhan(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer, idKichBan As Integer) As IDataReader
    Public MustOverride Function KichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomKichBan As Integer) As IDataReader
    Public MustOverride Function KichBan_ListSort(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer) As IDataReader
    Public MustOverride Function KichBan_Add(PortalConnect As String, obj As KichBanInfo) As Integer
    Public MustOverride Sub KichBan_Update(PortalConnect As String, obj As KichBanInfo)
    Public MustOverride Sub KichBan_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function KichBan_Copy(PortalConnect As String, idKichBan As Integer, IdUser As String) As Integer
    Public MustOverride Function KichBan_Setting(PortalConnect As String, idKichBan As String, idNhomTuKhoa As Integer, idYDinh As Integer, typeSetting As Integer, IdUser As String) As Integer
    Public MustOverride Function KichBan_Update_OrderBy(PortalConnect As String, idStr As String, idStr2 As String, idNhomKichBan As Integer, idNhomKichBan2 As Integer, userId As String) As Integer
#End Region
#Region "CaiDatBaoMat"
    Public MustOverride Function CaiDatBaoMat_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CaiDatBaoMat_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CaiDatBaoMat_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CaiDatBaoMat_Add(PortalConnect As String, obj As CaiDatBaoMatInfo) As Integer
    Public MustOverride Sub CaiDatBaoMat_Update(PortalConnect As String, obj As CaiDatBaoMatInfo)
    Public MustOverride Sub CaiDatBaoMat_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "MauEmail"
    Public MustOverride Function MauEmail_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MauEmail_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MauEmail_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function MauEmail_Add(PortalConnect As String, obj As MauEmailInfo) As Integer
    Public MustOverride Sub MauEmail_Update(PortalConnect As String, obj As MauEmailInfo)
    Public MustOverride Sub MauEmail_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "TinNhan"
    Public MustOverride Function TinNhan_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function TinNhan_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TinNhan_List_Search(PortalConnect As String, idKichBan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, urlFile As String) As IDataReader

    Public MustOverride Function TinNhan_Add(PortalConnect As String, obj As TinNhanInfo) As Integer
    Public MustOverride Sub TinNhan_Update(PortalConnect As String, obj As TinNhanInfo)
    Public MustOverride Sub TinNhan_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Sub TinNhan_KieuHienThi(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function TinNhan_Update_OrderBy(PortalConnect As String, idStr As String, idKichBan As Integer, userId As String) As Integer
#End Region
#Region "TinNhanSub"
    Public MustOverride Function TinNhanSub_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function TinNhanSub_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TinNhanSub_List_Search(PortalConnect As String, idTinNhan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional PhanLoai As Short = -1) As IDataReader

    Public MustOverride Function TinNhanSub_Add(PortalConnect As String, obj As TinNhanSubInfo) As Integer
    Public MustOverride Sub TinNhanSub_Update(PortalConnect As String, obj As TinNhanSubInfo)
    Public MustOverride Function TinNhanSub_Update_OrderBy(PortalConnect As String, idStr As String, userId As String) As Integer
    Public MustOverride Sub TinNhanSub_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Sub TinNhanSub_Delete_All(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "Email"
    Public MustOverride Function Email_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function Email_List(PortalConnect As String) As IDataReader
    Public MustOverride Function Email_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function Email_Add(PortalConnect As String, obj As EmailInfo) As Integer
    Public MustOverride Sub Email_Update(PortalConnect As String, obj As EmailInfo)
    Public MustOverride Sub Email_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "HT_ThietLap"
    Public MustOverride Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
    Public MustOverride Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
#End Region
#Region "DaoTao"
    Public MustOverride Function DaoTao_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function DaoTao_Add(PortalConnect As String, obj As DaoTaoInfo) As Integer
    Public MustOverride Sub DaoTao_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function DaoTao_Setting(PortalConnect As String, idDaoTao As String, idNhomTuKhoa As Integer, IdUser As String) As Integer
#End Region
#Region "API"
    Public MustOverride Function API_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function API_List(PortalConnect As String) As IDataReader
    Public MustOverride Function API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function API_Add(PortalConnect As String, obj As APIInfo) As Integer
    Public MustOverride Sub API_Update(PortalConnect As String, obj As APIInfo)
    Public MustOverride Sub API_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "APIHeader"
    Public MustOverride Function APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
    'Public MustOverride Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    Public MustOverride Function APIHeader_Add(PortalConnect As String, obj As APIHeaderInfo) As Integer
    Public MustOverride Sub APIHeader_Update(PortalConnect As String, obj As APIHeaderInfo)
    Public MustOverride Sub APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "HoiThoai"
    Public MustOverride Function HoiThoai_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function HoiThoai_List(PortalConnect As String) As IDataReader
    Public MustOverride Function HoiThoai_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, trangThai As Integer) As IDataReader
    Public MustOverride Function HoiThoai_Add(PortalConnect As String, obj As HoiThoaiInfo) As Integer
    Public MustOverride Function HoiThoai_Delete(PortalConnect As String, id As String, userId As String) As Integer
    Public MustOverride Function HoiThoai_Sao(PortalConnect As String, id As String, userId As String, sao As Integer) As Integer
#End Region
#Region "TinHoiThoai"
    Public MustOverride Function TinHoiThoai_List(PortalConnect As String, idHoiThoai As Integer) As IDataReader
    Public MustOverride Function TinHoiThoai_Add(PortalConnect As String, obj As TinHoiThoaiInfo) As Integer
#End Region
#Region "CHATBOT_DashBoard"
    Public MustOverride Function CHATBOT_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
    Public MustOverride Function CHATBOT_DashBoard_HoiThoai(PortalConnect As String) As IDataReader
#End Region
#Region "APISync"
    Public MustOverride Function APISync_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function APISync_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub APISync_Update(PortalConnect As String, obj As APISyncInfo)
#End Region

End Class
