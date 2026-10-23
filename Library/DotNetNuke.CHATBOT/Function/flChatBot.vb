Imports DotNetNuke.Common.Utilities
Imports System.Net.Mail
Imports DotNetNuke.Entities.Host
Imports System.Net.Mime
Imports System.Net
Imports DotNetNuke.Entities.Controllers
Imports DotNetNuke.Entities.Portals
Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL

Public Class flChatBot
    Shared strOld, str() As String
    Shared ObjControler As New ChatBotController
    Shared arrTemp, arrTemp1 As New ArrayList

#Region "Bot"
    Public Shared Function Bot_Get(PortalConnect As String, id As Integer) As BotInfo
        Return CBO.FillObject(Of BotInfo)(DataProvider.Instance().Bot_Get(PortalConnect, id))
    End Function
    Public Shared Function Bot_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Bot_List(PortalConnect), GetType(BotInfo))
    End Function
    Public Shared Function Bot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Bot_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BotInfo))
    End Function

    Public Shared Function Bot_Add(PortalConnect As String, obj As BotInfo) As Integer
        DataProvider.Instance().Bot_Add(PortalConnect, obj)
    End Function
    Public Shared Sub Bot_Update(PortalConnect As String, obj As BotInfo)
        DataProvider.Instance().Bot_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub Bot_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().Bot_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function Bot_Copy(PortalConnect As String, idBot As Integer, IdUser As String) As Integer
        Return DataProvider.Instance().Bot_Copy(PortalConnect, idBot, IdUser)
    End Function
#End Region

#Region "Bien"
    Public Shared Function Bien_Get(PortalConnect As String, id As Integer) As BienInfo
        Return CBO.FillObject(Of BienInfo)(DataProvider.Instance().Bien_Get(PortalConnect, id))
    End Function
    Public Shared Function Bien_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Bien_List(PortalConnect), GetType(BienInfo))
    End Function
    Public Shared Function Bien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Bien_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BienInfo))
    End Function
    Public Shared Function Bien_List_By_IdBoBien(PortalConnect As String, idBoBien As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Bien_List_By_IdBoBien(PortalConnect, idBoBien), GetType(BienInfo))
    End Function
    Public Shared Function Bien_Add(PortalConnect As String, obj As BienInfo) As Integer
        DataProvider.Instance().Bien_Add(PortalConnect, obj)
    End Function
    Public Shared Sub Bien_Update(PortalConnect As String, obj As BienInfo)
        DataProvider.Instance().Bien_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub Bien_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().Bien_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "BoBien"
    Public Shared Function BoBien_Get(PortalConnect As String, id As Integer) As BoBienInfo
        Return CBO.FillObject(Of BoBienInfo)(DataProvider.Instance().BoBien_Get(PortalConnect, id))
    End Function
    Public Shared Function BoBien_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BoBien_List(PortalConnect), GetType(BoBienInfo))
    End Function
    Public Shared Function BoBien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BoBien_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BoBienInfo))
    End Function

    Public Shared Function BoBien_Add(PortalConnect As String, obj As BoBienInfo) As Integer
        DataProvider.Instance().BoBien_Add(PortalConnect, obj)
    End Function
    Public Shared Sub BoBien_Update(PortalConnect As String, obj As BoBienInfo)
        DataProvider.Instance().BoBien_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub BoBien_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().BoBien_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "ThucThe"
    Public Shared Function ThucThe_Get(PortalConnect As String, id As Integer) As ThucTheInfo
        Return CBO.FillObject(Of ThucTheInfo)(DataProvider.Instance().ThucThe_Get(PortalConnect, id))
    End Function
    Public Shared Function ThucThe_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ThucThe_List(PortalConnect), GetType(ThucTheInfo))
    End Function
    Public Shared Function ThucThe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ThucThe_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(ThucTheInfo))
    End Function

    Public Shared Function ThucThe_Add(PortalConnect As String, obj As ThucTheInfo) As Integer
        DataProvider.Instance().ThucThe_Add(PortalConnect, obj)
    End Function
    Public Shared Sub ThucThe_Update(PortalConnect As String, obj As ThucTheInfo)
        DataProvider.Instance().ThucThe_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub ThucThe_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().ThucThe_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "TuDongNghia"
    Public Shared Function TuDongNghia_Get(PortalConnect As String, id As Integer) As TuDongNghiaInfo
        Return CBO.FillObject(Of TuDongNghiaInfo)(DataProvider.Instance().TuDongNghia_Get(PortalConnect, id))
    End Function
    Public Shared Function TuDongNghia_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TuDongNghia_List(PortalConnect), GetType(TuDongNghiaInfo))
    End Function
    Public Shared Function TuDongNghia_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TuDongNghia_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, idThucThe), GetType(TuDongNghiaInfo))
    End Function

    Public Shared Function TuDongNghia_Add(PortalConnect As String, obj As TuDongNghiaInfo) As Integer
        Return DataProvider.Instance().TuDongNghia_Add(PortalConnect, obj)
    End Function
    Public Shared Sub TuDongNghia_Update(PortalConnect As String, obj As TuDongNghiaInfo)
        DataProvider.Instance().TuDongNghia_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub TuDongNghia_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TuDongNghia_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "CauMau"
    Public Shared Function CauMau_Get(PortalConnect As String, id As Integer) As CauMauInfo
        Return CBO.FillObject(Of CauMauInfo)(DataProvider.Instance().CauMau_Get(PortalConnect, id))
    End Function
    Public Shared Function CauMau_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CauMau_List(PortalConnect), GetType(CauMauInfo))
    End Function
    Public Shared Function CauMau_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idThucThe As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CauMau_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, idThucThe), GetType(CauMauInfo))
    End Function

    Public Shared Function CauMau_Add(PortalConnect As String, obj As CauMauInfo) As Integer
        Return DataProvider.Instance().CauMau_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CauMau_Update(PortalConnect As String, obj As CauMauInfo)
        DataProvider.Instance().CauMau_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CauMau_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().CauMau_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Sub CauMau_DeleteNhan(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().CauMau_DeleteNhan(PortalConnect, id, userId)
    End Sub
#End Region

#Region "YDinh"
    Public Shared Function YDinh_Get(PortalConnect As String, id As Integer) As YDinhInfo
        Return CBO.FillObject(Of YDinhInfo)(DataProvider.Instance().YDinh_Get(PortalConnect, id))
    End Function
    Public Shared Function YDinh_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().YDinh_List(PortalConnect), GetType(YDinhInfo))
    End Function
    Public Shared Function YDinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().YDinh_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(YDinhInfo))
    End Function

    Public Shared Function YDinh_Add(PortalConnect As String, obj As YDinhInfo) As Integer
        Return DataProvider.Instance().YDinh_Add(PortalConnect, obj)
    End Function
    Public Shared Sub YDinh_Update(PortalConnect As String, obj As YDinhInfo)
        DataProvider.Instance().YDinh_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub YDinh_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().YDinh_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "NhomTuKhoa"
    Public Shared Function NhomTuKhoa_Get(PortalConnect As String, id As Integer) As NhomTuKhoaInfo
        Return CBO.FillObject(Of NhomTuKhoaInfo)(DataProvider.Instance().NhomTuKhoa_Get(PortalConnect, id))
    End Function
    Public Shared Function NhomTuKhoa_List(PortalConnect As String, idBot As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NhomTuKhoa_List(PortalConnect, idBot), GetType(NhomTuKhoaInfo))
    End Function
    Public Shared Function NhomTuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NhomTuKhoa_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName), GetType(NhomTuKhoaInfo))
    End Function

    Public Shared Function NhomTuKhoa_Add(PortalConnect As String, obj As NhomTuKhoaInfo) As Integer
        Return DataProvider.Instance().NhomTuKhoa_Add(PortalConnect, obj)
    End Function
    Public Shared Sub NhomTuKhoa_Update(PortalConnect As String, obj As NhomTuKhoaInfo)
        DataProvider.Instance().NhomTuKhoa_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub NhomTuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().NhomTuKhoa_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "TuKhoa"
    Public Shared Function TuKhoa_Get(PortalConnect As String, id As Integer) As TuKhoaInfo
        Return CBO.FillObject(Of TuKhoaInfo)(DataProvider.Instance().TuKhoa_Get(PortalConnect, id))
    End Function
    Public Shared Function TuKhoa_List(PortalConnect As String, idBot As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TuKhoa_List(PortalConnect, idBot), GetType(TuKhoaInfo))
    End Function
    Public Shared Function TuKhoa_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomTuKhoa As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TuKhoa_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName, idNhomTuKhoa), GetType(TuKhoaInfo))
    End Function

    Public Shared Function TuKhoa_Add(PortalConnect As String, obj As TuKhoaInfo) As Integer
        Return DataProvider.Instance().TuKhoa_Add(PortalConnect, obj)
    End Function
    Public Shared Sub TuKhoa_Update(PortalConnect As String, obj As TuKhoaInfo)
        DataProvider.Instance().TuKhoa_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub TuKhoa_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TuKhoa_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "NhomKichBan"
    Public Shared Function NhomKichBan_Get(PortalConnect As String, id As Integer) As NhomKichBanInfo
        Return CBO.FillObject(Of NhomKichBanInfo)(DataProvider.Instance().NhomKichBan_Get(PortalConnect, id))
    End Function
    Public Shared Function NhomKichBan_List(PortalConnect As String, idBot As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NhomKichBan_List(PortalConnect, idBot), GetType(NhomKichBanInfo))
    End Function
    Public Shared Function NhomKichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NhomKichBan_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName), GetType(NhomKichBanInfo))
    End Function

    Public Shared Function NhomKichBan_Add(PortalConnect As String, obj As NhomKichBanInfo) As Integer
        Return DataProvider.Instance().NhomKichBan_Add(PortalConnect, obj)
    End Function
    Public Shared Sub NhomKichBan_Update(PortalConnect As String, obj As NhomKichBanInfo)
        DataProvider.Instance().NhomKichBan_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub NhomKichBan_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().NhomKichBan_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function NhomKichBan_Copy(PortalConnect As String, idNhomKichBan As Integer, IdUser As String) As Integer
        Return DataProvider.Instance().NhomKichBan_Copy(PortalConnect, idNhomKichBan, IdUser)
    End Function
    Public Shared Function NhomKichBan_ListSort(PortalConnect As String, idBot As Integer) As List(Of NhomKichBanInfo)
        Return CBO.FillCollection(Of NhomKichBanInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "NhomKichBan_List", idBot))
    End Function
#End Region

#Region "KichBan"
    Public Shared Function KichBan_Get(PortalConnect As String, id As Integer) As KichBanInfo
        Return CBO.FillObject(Of KichBanInfo)(DataProvider.Instance().KichBan_Get(PortalConnect, id))
    End Function
    Public Shared Function KichBan_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().KichBan_List(PortalConnect), GetType(KichBanInfo))
    End Function
    Public Shared Function KichBan_List_ByTinNhan(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer, idKichBan As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().KichBan_List_ByTinNhan(PortalConnect, idBot, idNhomKichBan, idKichBan), GetType(KichBanInfo))
    End Function
    Public Shared Function KichBan_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, idNhomKichBan As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().KichBan_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName, idNhomKichBan), GetType(KichBanInfo))
    End Function
    Public Shared Function KichBan_ListSort(PortalConnect As String, idBot As Integer, idNhomKichBan As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().KichBan_ListSort(PortalConnect, idBot, idNhomKichBan), GetType(KichBanInfo))
    End Function
    Public Shared Function KichBan_Add(PortalConnect As String, obj As KichBanInfo) As Integer
        Return DataProvider.Instance().KichBan_Add(PortalConnect, obj)
    End Function
    Public Shared Sub KichBan_Update(PortalConnect As String, obj As KichBanInfo)
        DataProvider.Instance().KichBan_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub KichBan_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().KichBan_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function KichBan_Copy(PortalConnect As String, idKichBan As Integer, IdUser As String) As Integer
        Return DataProvider.Instance().KichBan_Copy(PortalConnect, idKichBan, IdUser)
    End Function
    Public Shared Function KichBan_Setting(PortalConnect As String, idKichBan As String, idNhomTuKhoa As Integer, idYDinh As Integer, typeSetting As Integer, IdUser As String) As Integer
        Return DataProvider.Instance().KichBan_Setting(PortalConnect, idKichBan, idNhomTuKhoa, idYDinh, typeSetting, IdUser)
    End Function

    Public Shared Function KichBan_Update_OrderBy(PortalConnect As String, idStr As String, idStr2 As String, idNhomKichBan As Integer, idNhomKichBan2 As Integer, userId As String) As Integer
        Return DataProvider.Instance().KichBan_Update_OrderBy(PortalConnect, idStr, idStr2, idNhomKichBan, idNhomKichBan2, userId)
    End Function
#End Region

#Region "CaiDatBaoMat"
    Public Shared Function CaiDatBaoMat_Get(PortalConnect As String, id As Integer) As CaiDatBaoMatInfo
        Return CBO.FillObject(Of CaiDatBaoMatInfo)(DataProvider.Instance().CaiDatBaoMat_Get(PortalConnect, id))
    End Function
    Public Shared Function CaiDatBaoMat_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CaiDatBaoMat_List(PortalConnect), GetType(CaiDatBaoMatInfo))
    End Function
    Public Shared Function CaiDatBaoMat_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CaiDatBaoMat_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName), GetType(CaiDatBaoMatInfo))
    End Function

    Public Shared Function CaiDatBaoMat_Add(PortalConnect As String, obj As CaiDatBaoMatInfo) As Integer
        Return DataProvider.Instance().CaiDatBaoMat_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CaiDatBaoMat_Update(PortalConnect As String, obj As CaiDatBaoMatInfo)
        DataProvider.Instance().CaiDatBaoMat_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CaiDatBaoMat_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().CaiDatBaoMat_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "MauEmail"
    Public Shared Function MauEmail_Get(PortalConnect As String, id As Integer) As MauEmailInfo
        Return CBO.FillObject(Of MauEmailInfo)(DataProvider.Instance().MauEmail_Get(PortalConnect, id))
    End Function
    Public Shared Function MauEmail_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MauEmail_List(PortalConnect), GetType(MauEmailInfo))
    End Function
    Public Shared Function MauEmail_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MauEmail_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MauEmailInfo))
    End Function

    Public Shared Function MauEmail_Add(PortalConnect As String, obj As MauEmailInfo) As Integer
        Return DataProvider.Instance().MauEmail_Add(PortalConnect, obj)
    End Function
    Public Shared Sub MauEmail_Update(PortalConnect As String, obj As MauEmailInfo)
        DataProvider.Instance().MauEmail_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub MauEmail_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().MauEmail_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "TinNhan"
    Public Shared Function TinNhan_Get(PortalConnect As String, id As Integer) As TinNhanInfo
        Return CBO.FillObject(Of TinNhanInfo)(DataProvider.Instance().TinNhan_Get(PortalConnect, id))
    End Function
    Public Shared Function TinNhan_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TinNhan_List(PortalConnect), GetType(TinNhanInfo))
    End Function
    Public Shared Function TinNhan_List_Search(PortalConnect As String, idKichBan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, urlFile As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TinNhan_List_Search(PortalConnect, idKichBan, search, isOrder, currPage, recodperpage, UserName, urlFile), GetType(TinNhanInfo))
    End Function

    Public Shared Function TinNhan_Add(PortalConnect As String, obj As TinNhanInfo) As Integer
        Return DataProvider.Instance().TinNhan_Add(PortalConnect, obj)
    End Function
    Public Shared Sub TinNhan_Update(PortalConnect As String, obj As TinNhanInfo)
        DataProvider.Instance().TinNhan_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub TinNhan_KieuHienThi(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TinNhan_KieuHienThi(PortalConnect, id, userId)
    End Sub
    Public Shared Sub TinNhan_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TinNhan_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function TinNhan_By_KeyWord(PortalConnect As String, idBot As Integer, urlFile As String, keyWord As String, userId As String) As List(Of TinNhanInfo)
        Return CBO.FillCollection(Of TinNhanInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_By_KeyWord", idBot, urlFile, keyWord, userId))
    End Function
    Public Shared Function TinNhan_By_NhomTuKhoaId(PortalConnect As String, idBot As Integer, urlFile As String, idNhomTuKhoa As Integer) As List(Of TinNhanInfo)
        Return CBO.FillCollection(Of TinNhanInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_By_NhomTuKhoaId", idBot, urlFile, idNhomTuKhoa))
    End Function
    Public Shared Function TinNhan_By_KichBanId(PortalConnect As String, idBot As Integer, urlFile As String, idKichBan As Integer) As List(Of TinNhanInfo)
        Return CBO.FillCollection(Of TinNhanInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_By_KichBanId", idBot, urlFile, idKichBan))
    End Function
    Public Shared Function TinNhan_By_NhomKichBanId(PortalConnect As String, idBot As Integer, urlFile As String, idNhomKichBan As Integer) As List(Of TinNhanInfo)
        Return CBO.FillCollection(Of TinNhanInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "TinNhan_By_NhomKichBanId", idBot, urlFile, idNhomKichBan))
    End Function
    Public Shared Function TinNhan_Update_OrderBy(PortalConnect As String, idStr As String, idKichBan As Integer, userId As String) As Integer
        Return DataProvider.Instance().TinNhan_Update_OrderBy(PortalConnect, idStr, idKichBan, userId)
    End Function
#End Region

#Region "TinNhanSub"
    Public Shared Function TinNhanSub_Get(PortalConnect As String, id As Integer) As TinNhanSubInfo
        Return CBO.FillObject(Of TinNhanSubInfo)(DataProvider.Instance().TinNhanSub_Get(PortalConnect, id))
    End Function
    Public Shared Function TinNhanSub_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TinNhanSub_List(PortalConnect), GetType(TinNhanSubInfo))
    End Function
    Public Shared Function TinNhanSub_List_Search(PortalConnect As String, idTinNhan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional PhanLoai As Short = -1) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TinNhanSub_List_Search(PortalConnect, idTinNhan, search, isOrder, currPage, recodperpage, UserName, PhanLoai), GetType(TinNhanSubInfo))
    End Function

    Public Shared Function TinNhanSub_Add(PortalConnect As String, obj As TinNhanSubInfo) As Integer
        Return DataProvider.Instance().TinNhanSub_Add(PortalConnect, obj)
    End Function
    Public Shared Sub TinNhanSub_Update(PortalConnect As String, obj As TinNhanSubInfo)
        DataProvider.Instance().TinNhanSub_Update(PortalConnect, obj)
    End Sub
    Public Shared Function TinNhanSub_Update_OrderBy(PortalConnect As String, idStr As String, userId As String) As Integer
        Return DataProvider.Instance().TinNhanSub_Update_OrderBy(PortalConnect, idStr, userId)
    End Function
    Public Shared Sub TinNhanSub_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TinNhanSub_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Sub TinNhanSub_Delete_All(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().TinNhanSub_Delete_All(PortalConnect, id, userId)
    End Sub
#End Region

#Region "Email"
    Public Shared Function Email_Get(PortalConnect As String, id As Integer) As EmailInfo
        Return CBO.FillObject(Of EmailInfo)(DataProvider.Instance().Email_Get(PortalConnect, id))
    End Function
    Public Shared Function Email_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Email_List(PortalConnect), GetType(EmailInfo))
    End Function
    Public Shared Function Email_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Email_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(EmailInfo))
    End Function

    Public Shared Function Email_Add(PortalConnect As String, obj As EmailInfo) As Integer
        Return DataProvider.Instance().Email_Add(PortalConnect, obj)
    End Function
    Public Shared Sub Email_Update(PortalConnect As String, obj As EmailInfo)
        DataProvider.Instance().Email_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub Email_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().Email_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "HT_ThietLap"
    Public Shared Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As HT_ThietLapInfo
        Return CBO.FillObject(Of HT_ThietLapInfo)(DataProvider.Instance().HT_ThietLap_Get(PortalConnect, id))
    End Function
    Public Shared Function HT_ThietLap_List(PortalConnect As String) As List(Of HT_ThietLapInfo)
        'Return CBO.FillCollection(Of HT_ThietLapInfo)(DataProvider.Instance().HT_ThietLap_List(PortalConnect), GetType(HT_ThietLapInfo))
        Return CBO.FillCollection(Of HT_ThietLapInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "HT_ThietLap_List"))
    End Function

    Public Shared Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
        Return DataProvider.Instance().HT_ThietLap_Add(PortalConnect, obj)
    End Function
    Public Shared Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
        DataProvider.Instance().HT_ThietLap_Update(PortalConnect, obj)
    End Sub
#End Region

#Region "DaoTao"
    Public Shared Function DaoTao_List_Search(PortalConnect As String, idBot As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DaoTao_List_Search(PortalConnect, idBot, search, isOrder, currPage, recodperpage, UserName), GetType(DaoTaoInfo))
    End Function

    Public Shared Function DaoTao_Add(PortalConnect As String, obj As DaoTaoInfo) As Integer
        Return DataProvider.Instance().DaoTao_Add(PortalConnect, obj)
    End Function
    Public Shared Sub DaoTao_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().DaoTao_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function DaoTao_Setting(PortalConnect As String, idKichBan As String, idNhomTuKhoa As Integer, IdUser As String) As Integer
        Return DataProvider.Instance().DaoTao_Setting(PortalConnect, idKichBan, idNhomTuKhoa, IdUser)
    End Function
#End Region

#Region "API"
    Public Shared Function API_Get(PortalConnect As String, id As Integer) As APIInfo
        Return CBO.FillObject(Of APIInfo)(DataProvider.Instance().API_Get(PortalConnect, id))
    End Function
    Public Shared Function API_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_List(PortalConnect), GetType(APIInfo))
    End Function
    Public Shared Function API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(APIInfo))
    End Function

    Public Shared Function API_Add(PortalConnect As String, obj As APIInfo) As Integer
        Return DataProvider.Instance().API_Add(PortalConnect, obj)
    End Function
    Public Shared Sub API_Update(PortalConnect As String, obj As APIInfo)
        DataProvider.Instance().API_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub API_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().API_Delete(PortalConnect, id, userId)
    End Sub
#End Region

#Region "APIHeader"
    Public Shared Function APIHeader_Get(PortalConnect As String, id As Integer) As APIHeaderInfo
        Return CBO.FillObject(Of APIHeaderInfo)(DataProvider.Instance().APIHeader_Get(PortalConnect, id))
    End Function
    'Public Shared Function APIHeader_List(PortalConnect As String, idAPI As Integer) As ArrayList
    '    Return CBO.FillCollection(DataProvider.Instance().APIHeader_List(PortalConnect, idAPI), GetType(APIHeaderInfo))
    'End Function

    Public Shared Function APIHeader_Add(PortalConnect As String, obj As APIHeaderInfo) As Integer
        Return DataProvider.Instance().APIHeader_Add(PortalConnect, obj)
    End Function
    Public Shared Sub APIHeader_Update(PortalConnect As String, obj As APIHeaderInfo)
        DataProvider.Instance().APIHeader_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().APIHeader_Delete(PortalConnect, id, userId)
    End Sub

    Public Shared Function APIHeader_List(PortalConnect As String, idAPI As Integer) As List(Of APIHeaderInfo)
        Return CBO.FillCollection(Of APIHeaderInfo)(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APIHeader_List", idAPI))
    End Function
#End Region

#Region "HoiThoai"
    Public Shared Function HoiThoai_Get(PortalConnect As String, id As Integer) As HoiThoaiInfo
        Return CBO.FillObject(Of HoiThoaiInfo)(DataProvider.Instance().HoiThoai_Get(PortalConnect, id))
    End Function
    Public Shared Function HoiThoai_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().HoiThoai_List(PortalConnect), GetType(HoiThoaiInfo))
    End Function
    Public Shared Function HoiThoai_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, trangThai As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().HoiThoai_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, trangThai), GetType(HoiThoaiInfo))
    End Function

    Public Shared Function HoiThoai_Add(PortalConnect As String, obj As HoiThoaiInfo) As Integer
        Return DataProvider.Instance().HoiThoai_Add(PortalConnect, obj)
    End Function
    Public Shared Function HoiThoai_Delete(PortalConnect As String, id As String, userId As String) As Integer
        Return DataProvider.Instance().HoiThoai_Delete(PortalConnect, id, userId)
    End Function
    Public Shared Function HoiThoai_Sao(PortalConnect As String, id As String, userId As String, sao As Integer) As Integer
        Return DataProvider.Instance().HoiThoai_Sao(PortalConnect, id, userId, sao)
    End Function
#End Region

#Region "TinHoiThoai"
    Public Shared Function TinHoiThoai_List(PortalConnect As String, idHoiThoai As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TinHoiThoai_List(PortalConnect, idHoiThoai), GetType(TinHoiThoaiInfo))
    End Function
    Public Shared Function TinHoiThoai_Add(PortalConnect As String, obj As TinHoiThoaiInfo) As Integer
        Return DataProvider.Instance().TinHoiThoai_Add(PortalConnect, obj)
    End Function

#End Region

#Region "CHATBOT_DashBoard"
    Public Shared Function CHATBOT_DashBoard_Admin(PortalConnect As String, year As Integer) As CHATBOT_DashInfo
        Return CBO.FillObject(Of CHATBOT_DashInfo)(DataProvider.Instance().CHATBOT_DashBoard_Admin(PortalConnect, year))
    End Function
    Public Shared Function CHATBOT_DashBoard_HoiThoai(PortalConnect As String) As CHATBOT_DashInfo
        Return CBO.FillObject(Of CHATBOT_DashInfo)(DataProvider.Instance().CHATBOT_DashBoard_HoiThoai(PortalConnect))
    End Function
#End Region

#Region "APISync"
    Public Shared Function APISync_Get(PortalConnect As String, id As Integer) As APISyncInfo
        Return CBO.FillObject(Of APISyncInfo)(DataProvider.Instance().APISync_Get(PortalConnect, id))
    End Function
    Public Shared Function APISync_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().APISync_List(PortalConnect), GetType(APISyncInfo))
    End Function
    Public Shared Sub APISync_Update(PortalConnect As String, obj As APISyncInfo)
        DataProvider.Instance().APISync_Update(PortalConnect, obj)
    End Sub
#End Region


End Class
