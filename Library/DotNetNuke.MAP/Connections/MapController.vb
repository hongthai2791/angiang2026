Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.EPORTAL
Imports Microsoft.ApplicationBlocks.Data

Public Class MapController

#Region "CMS_Targets"
    Public Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_By_Group_Parent(PortalConnect, group_ID, ParentID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_By_Group_ID(PortalConnect, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As CMS_TargetsInfo
        Return CBO.FillObject(Of CMS_TargetsInfo)(DataProvider.Instance().CMS_Targets_Get(PortalConnect, targets_ID))
    End Function
    Public Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
        Return DataProvider.Instance().CMS_Targets_Get_ByCode(PortalConnect, targets_code)
    End Function
    Public Function CMS_Targets_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List(PortalConnect), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_IsGroup(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_IsGroup(PortalConnect), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_ByCateTar(PortalConnect, GroupID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_TinhTP(PortalConnect, TinhTP), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
        Return DataProvider.Instance().CMS_Targets_Count_TinhTP(PortalConnect, TinhTP)
    End Function
    Public Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentId As Integer) As String
        Return DataProvider.Instance().CMS_Targets_GenCode(PortalConnect, maTinh, maHuyen, maXa, asxh_id, group_id, targetID, parentId)
    End Function
    Public Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
        Return DataProvider.Instance().CMS_Sys_CopyTarget(PortalConnect, TinhTP1, TinhTP2, CreatedUser, CreatedDate)
    End Function
    Public Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Parent_Search_Null(PortalConnect, search, isOrder), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Parent_Search_ID(PortalConnect, tinhTp, quanhuyen, phuongxa, search, asxh_id, group_id, Parent_ID, currPage, recodperpage), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Analytic(PortalConnect, tinhTp, search, group_id, Parent_ID, isMain), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Select(PortalConnect, tinhTp, asxh_id, group_id), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Parent_Null(PortalConnect, tinhTP, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Parent_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Parent_Foreign(PortalConnect, tinhTp, quanHuyen, phuongXa, thonTo, yearId), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect, tinhTP, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Targets(PortalConnect, Targets_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Targets_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer, Targets_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Targets_Foreign(PortalConnect, tinhTp, quanHuyen, phuongXa, thonTo, yearId, Targets_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect, tinhTp, Targets_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
        Return DataProvider.Instance().CMS_Targets_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
        DataProvider.Instance().CMS_Targets_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
        DataProvider.Instance().CMS_Targets_Delete(PortalConnect, targets_ID)
    End Sub

    Public Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect, temp_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect, temp_ID, Parent_ID), GetType(CMS_TargetsInfo))
    End Function
#End Region
#Region "CMS_Group"
    Public Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As CMS_GroupInfo
        Return CBO.FillObject(Of CMS_GroupInfo)(DataProvider.Instance().CMS_Group_Get(PortalConnect, group_ID))
    End Function
    Public Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
        Return DataProvider.Instance().CMS_Group_Count_Parent(PortalConnect, group_ID)
    End Function
    Public Function CMS_Group_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List(PortalConnect), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_By_ParentID(PortalConnect, asxh_id, parentID), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Parent_Null(PortalConnect, asxh_id, groupType), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Search(PortalConnect, asxh_id, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_GroupInfo))
    End Function

    Public Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        DataProvider.Instance().CMS_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_Update_IsHome(PortalConnect As String, groupId As Integer, isHome As Boolean)
        DataProvider.Instance().CMS_Group_Update_IsHome(PortalConnect, groupId, isHome)
    End Sub
    Public Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
        DataProvider.Instance().CMS_Group_Delete(PortalConnect, group_ID)
    End Sub
#End Region
#Region "Banner"
    Public Function Banner_Get(PortalConnect As String, id As Integer) As BannerInfo
        Return CBO.FillObject(Of BannerInfo)(DataProvider.Instance().Banner_Get(PortalConnect, id))
    End Function
    Public Function Banner_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Banner_List(PortalConnect), GetType(BannerInfo))
    End Function
    Public Function Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Banner_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BannerInfo))
    End Function

    Public Function Banner_Add(PortalConnect As String, obj As BannerInfo) As Integer
        Return DataProvider.Instance().Banner_Add(PortalConnect, obj)
    End Function
    Public Sub Banner_Update(PortalConnect As String, obj As BannerInfo)
        DataProvider.Instance().Banner_Update(PortalConnect, obj)
    End Sub
    Public Sub Banner_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().Banner_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "LienKet"
    Public Function LienKet_Get(PortalConnect As String, id As Integer) As LienKetInfo
        Return CBO.FillObject(Of LienKetInfo)(DataProvider.Instance().LienKet_Get(PortalConnect, id))
    End Function
    Public Function LienKet_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LienKet_List(PortalConnect), GetType(LienKetInfo))
    End Function
    Public Function LienKet_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LienKet_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(LienKetInfo))
    End Function

    Public Function LienKet_Add(PortalConnect As String, obj As LienKetInfo) As Integer
        Return DataProvider.Instance().LienKet_Add(PortalConnect, obj)
    End Function
    Public Sub LienKet_Update(PortalConnect As String, obj As LienKetInfo)
        DataProvider.Instance().LienKet_Update(PortalConnect, obj)
    End Sub
    Public Sub LienKet_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().LienKet_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "MauSac"
    Public Function MauSac_Get(PortalConnect As String, id As Integer) As MauSacInfo
        Return CBO.FillObject(Of MauSacInfo)(DataProvider.Instance().MauSac_Get(PortalConnect, id))
    End Function
    Public Function MauSac_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MauSac_List(PortalConnect), GetType(MauSacInfo))
    End Function
    Public Function MauSac_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MauSac_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MauSacInfo))
    End Function

    Public Function MauSac_Add(PortalConnect As String, obj As MauSacInfo) As Integer
        Return DataProvider.Instance().MauSac_Add(PortalConnect, obj)
    End Function
    Public Sub MauSac_Update(PortalConnect As String, obj As MauSacInfo)
        DataProvider.Instance().MauSac_Update(PortalConnect, obj)
    End Sub
    Public Sub MauSac_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MauSac_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "LopBanDo"
    Public Function LopBanDo_Get(PortalConnect As String, id As Integer) As LopBanDoInfo
        Return CBO.FillObject(Of LopBanDoInfo)(DataProvider.Instance().LopBanDo_Get(PortalConnect, id))
    End Function
    Public Function LopBanDo_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LopBanDo_List(PortalConnect), GetType(LopBanDoInfo))
    End Function
    Public Function LopBanDo_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LopBanDo_List_Search(PortalConnect, MaTinh, MaHuyen, MaXa, MaThon, search, isOrder, currPage, recodperpage, UserName), GetType(LopBanDoInfo))
    End Function
    Public Function LopBanDo_Add(PortalConnect As String, obj As LopBanDoInfo) As Integer
        Return DataProvider.Instance().LopBanDo_Add(PortalConnect, obj)
    End Function
    Public Sub LopBanDo_Update(PortalConnect As String, obj As LopBanDoInfo)
        DataProvider.Instance().LopBanDo_Update(PortalConnect, obj)
    End Sub
    Public Sub LopBanDo_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().LopBanDo_Delete(PortalConnect, id)
    End Sub
    Public Sub LopBanDo_DeleteMauSac(PortalConnect As String, id As Integer)
        DataProvider.Instance().LopBanDo_DeleteMauSac(PortalConnect, id)
    End Sub
    Public Function LopBanDo_List_ById(PortalConnect As String, IdStr As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LopBanDo_List_ById(PortalConnect, IdStr), GetType(LopBanDoInfo))
    End Function
    Public Function LopBanDo_List_Search_By(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, TargetGroup As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().LopBanDo_List_Search_By(PortalConnect, MaTinh, MaHuyen, MaXa, MaThon, TargetGroup), GetType(LopBanDoInfo))
    End Function
    Public Function Map_List_Search_ByDoanhNghiep(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Map_List_Search_ByDoanhNghiep(PortalConnect, MaTinh, MaHuyen, MaXa), GetType(MapDoanhNghiepInfo))
    End Function
    Public Function Map_List_Search_ByTuyenDung(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Map_List_Search_ByTuyenDung(PortalConnect, MaTinh, MaHuyen, MaXa), GetType(MapTuyenDungInfo))
    End Function
#End Region
#Region "DiemLop"
    Public Function DiemLop_Get(PortalConnect As String, id As Integer) As DiemLopInfo
        Return CBO.FillObject(Of DiemLopInfo)(DataProvider.Instance().DiemLop_Get(PortalConnect, id))
    End Function
    Public Function DiemLop_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DiemLop_List(PortalConnect), GetType(DiemLopInfo))
    End Function
    Public Function DiemLop_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DiemLop_List_Search(PortalConnect, MaTinh, MaHuyen, MaXa, MaThon, search, isOrder, currPage, recodperpage, UserName), GetType(DiemLopInfo))
    End Function

    Public Function DiemLop_Add(PortalConnect As String, obj As DiemLopInfo) As Integer
        Return DataProvider.Instance().DiemLop_Add(PortalConnect, obj)
    End Function
    Public Sub DiemLop_Update(PortalConnect As String, obj As DiemLopInfo)
        DataProvider.Instance().DiemLop_Update(PortalConnect, obj)
    End Sub
    Public Sub DiemLop_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().DiemLop_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "VungBanDo"
    Public Function VungBanDo_Get(PortalConnect As String, id As Integer) As VungBanDoInfo
        Return CBO.FillObject(Of VungBanDoInfo)(DataProvider.Instance().VungBanDo_Get(PortalConnect, id))
    End Function
    Public Function VungBanDo_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().VungBanDo_List(PortalConnect), GetType(VungBanDoInfo))
    End Function
    Public Function VungBanDo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().VungBanDo_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(VungBanDoInfo))
    End Function

    Public Function VungBanDo_Add(PortalConnect As String, obj As VungBanDoInfo) As Integer
        Return DataProvider.Instance().VungBanDo_Add(PortalConnect, obj)
    End Function
    Public Sub VungBanDo_Update(PortalConnect As String, obj As VungBanDoInfo)
        DataProvider.Instance().VungBanDo_Update(PortalConnect, obj)
    End Sub
    Public Sub VungBanDo_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().VungBanDo_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "BoCuc"
    Public Function BoCuc_Get(PortalConnect As String, id As Integer) As BoCucInfo
        Return CBO.FillObject(Of BoCucInfo)(DataProvider.Instance().BoCuc_Get(PortalConnect, id))
    End Function
    Public Function BoCuc_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BoCuc_List(PortalConnect), GetType(BoCucInfo))
    End Function
    Public Function BoCuc_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().BoCuc_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(BoCucInfo))
    End Function

    Public Function BoCuc_Add(PortalConnect As String, obj As BoCucInfo) As Integer
        Return DataProvider.Instance().BoCuc_Add(PortalConnect, obj)
    End Function
    Public Sub BoCuc_Update(PortalConnect As String, obj As BoCucInfo)
        DataProvider.Instance().BoCuc_Update(PortalConnect, obj)
    End Sub
    Public Sub BoCuc_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().BoCuc_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "MAP_API"
    Public Function MAP_API_Get(PortalConnect As String, id As Integer) As MAP_APIInfo
        Return CBO.FillObject(Of MAP_APIInfo)(DataProvider.Instance().MAP_API_Get(PortalConnect, id))
    End Function
    Public Function MAP_API_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_API_List(PortalConnect), GetType(MAP_APIInfo))
    End Function
    Public Function MAP_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_API_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_APIInfo))
    End Function

    Public Function MAP_API_Add(PortalConnect As String, obj As MAP_APIInfo) As Integer
        Return DataProvider.Instance().MAP_API_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_API_Update(PortalConnect As String, obj As MAP_APIInfo)
        DataProvider.Instance().MAP_API_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_API_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().MAP_API_Delete(PortalConnect, id, userId)
    End Sub
#End Region
#Region "MAP_APIHeader"
    Public Function MAP_APIHeader_Get(PortalConnect As String, id As Integer) As MAP_APIHeaderInfo
        Return CBO.FillObject(Of MAP_APIHeaderInfo)(DataProvider.Instance().MAP_APIHeader_Get(PortalConnect, id))
    End Function
    'Public Shared Function APIHeader_List(PortalConnect As String, idAPI As Integer) As ArrayList
    '    Return CBO.FillCollection(DataProvider.Instance().APIHeader_List(PortalConnect, idAPI), GetType(APIHeaderInfo))
    'End Function

    Public Function MAP_APIHeader_Add(PortalConnect As String, obj As MAP_APIHeaderInfo) As Integer
        Return DataProvider.Instance().MAP_APIHeader_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_APIHeader_Update(PortalConnect As String, obj As MAP_APIHeaderInfo)
        DataProvider.Instance().MAP_APIHeader_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().MAP_APIHeader_Delete(PortalConnect, id, userId)
    End Sub
    Public Function MAP_APIHeader_List(PortalConnect As String, idAPI As Integer) As List(Of MAP_APIHeaderInfo)
        Return CBO.FillCollection(Of MAP_APIHeaderInfo)(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_APIHeader_List", idAPI))
    End Function
    Public Function MAP_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_APIHeader_List_Search(PortalConnect, idAPI, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_APIHeaderInfo))
    End Function
    Public Sub MAP_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)
        DataProvider.Instance().MAP_APIHeader_LichDongBo(PortalConnect, id, lichDongBo, userId)
    End Sub
#End Region
#Region "MAP_LogsAPI"
    Public Function MAP_LogsAPI_Get(PortalConnect As String, id As Integer) As MAP_LogsAPIInfo
        Return CBO.FillObject(Of MAP_LogsAPIInfo)(DataProvider.Instance().MAP_LogsAPI_Get(PortalConnect, id))
    End Function
    Public Function MAP_LogsAPI_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_LogsAPI_List(PortalConnect), GetType(MAP_LogsAPIInfo))
    End Function
    Public Function MAP_LogsAPI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_LogsAPI_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_LogsAPIInfo))
    End Function

    Public Function MAP_LogsAPI_Add(PortalConnect As String, obj As MAP_LogsAPIInfo) As Integer
        Return DataProvider.Instance().MAP_LogsAPI_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_LogsAPI_Update(PortalConnect As String, obj As MAP_LogsAPIInfo)
        DataProvider.Instance().MAP_LogsAPI_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_LogsAPI_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_LogsAPI_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "MAP_NhomMenu"
    Public Function MAP_NhomMenu_Get(PortalConnect As String, id As Integer) As MAP_NhomMenuInfo
        Return CBO.FillObject(Of MAP_NhomMenuInfo)(DataProvider.Instance().MAP_NhomMenu_Get(PortalConnect, id))
    End Function
    Public Function MAP_NhomMenu_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_NhomMenu_List(PortalConnect), GetType(MAP_NhomMenuInfo))
    End Function
    Public Function MAP_NhomMenu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_NhomMenu_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_NhomMenuInfo))
    End Function

    Public Function MAP_NhomMenu_Add(PortalConnect As String, obj As MAP_NhomMenuInfo) As Integer
        Return DataProvider.Instance().MAP_NhomMenu_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_NhomMenu_Update(PortalConnect As String, obj As MAP_NhomMenuInfo)
        DataProvider.Instance().MAP_NhomMenu_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_NhomMenu_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_NhomMenu_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "MAP_Menu"
    Public Function MAP_Menu_Get(PortalConnect As String, id As Integer) As MAP_MenuInfo
        Return CBO.FillObject(Of MAP_MenuInfo)(DataProvider.Instance().MAP_Menu_Get(PortalConnect, id))
    End Function
    Public Function MAP_Menu_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_Menu_List(PortalConnect), GetType(MAP_MenuInfo))
    End Function
    Public Function MAP_Menu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_Menu_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_MenuInfo))
    End Function

    Public Function MAP_Menu_Add(PortalConnect As String, obj As MAP_MenuInfo) As Integer
        Return DataProvider.Instance().MAP_Menu_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_Menu_Update(PortalConnect As String, obj As MAP_MenuInfo)
        DataProvider.Instance().MAP_Menu_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_Menu_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_Menu_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "HT_ThietLap"
    Public Shared Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As HT_ThietLapInfo
        Return CBO.FillObject(Of HT_ThietLapInfo)(DataProvider.Instance().HT_ThietLap_Get(PortalConnect, id))
    End Function
    Public Shared Function HT_ThietLap_List(PortalConnect As String) As List(Of HT_ThietLapInfo)
        'Return CBO.FillCollection(Of HT_ThietLapInfo)(DataProvider.Instance().HT_ThietLap_List(PortalConnect), GetType(HT_ThietLapInfo))
        Return CBO.FillCollection(Of HT_ThietLapInfo)(SqlHelper.ExecuteReader(New flConnect().MapConnect, "HT_ThietLap_List"))
    End Function

    Public Shared Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
        Return DataProvider.Instance().HT_ThietLap_Add(PortalConnect, obj)
    End Function
    Public Shared Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
        DataProvider.Instance().HT_ThietLap_Update(PortalConnect, obj)
    End Sub
#End Region

#Region "CMS_Advertise"
    Public Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As CMS_AdvertiseInfo
        Return CBO.FillObject(Of CMS_AdvertiseInfo)(DataProvider.Instance().CMS_Advertise_Get(PortalConnect, advertise_ID))
    End Function
    Public Function CMS_Advertise_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List(PortalConnect, portalId), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_Get_By_Category(PortalConnect As String, PageLoca_ID As String, CategoryID As Integer) As CMS_AdvertiseInfo
        Return CBO.FillObject(Of CMS_AdvertiseInfo)(DataProvider.Instance().CMS_Advertise_Get_By_Category(PortalConnect, PageLoca_ID, CategoryID))
    End Function
    Public Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, pageLocaID As String, Top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List_Home(PortalConnect, PortalID, pageLocaID, Top), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_Get_By_CMS_PageLoca(PortalConnect As String, pageLoca_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_Get_By_CMS_PageLoca(PortalConnect, pageLoca_ID), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_List_Search(PortalConnect As String, portalID As Integer, isLang As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, pageLoca_ID As String, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List_Search(PortalConnect, portalID, isLang, search, isOrder, currPage, recodperpage, pageLoca_ID, UserName), GetType(CMS_AdvertiseInfo))
    End Function
    Public Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Advertise_Update_Quick(PortalConnect, advertise_ID, isActive, isOrder)
    End Sub
    Public Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
        DataProvider.Instance().CMS_Advertise_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
        DataProvider.Instance().CMS_Advertise_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
        DataProvider.Instance().CMS_Advertise_Delete(PortalConnect, advertise_ID)
    End Sub
#End Region
#Region "CMS_Menu"
    Public Function CMS_Menu_Add(PortalConnect As String, obj As CMS_MenuInfo) As Integer
        Return DataProvider.Instance().CMS_Menu_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Menu_Update(PortalConnect As String, obj As CMS_MenuInfo)
        DataProvider.Instance().CMS_Menu_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Menu_Delete(PortalConnect As String, menuID As String)
        DataProvider.Instance().CMS_Menu_Delete(PortalConnect, menuID)
    End Sub
    Public Function CMS_Menu_Get(PortalConnect As String, menuID As String) As CMS_MenuInfo
        Return CBO.FillObject(Of CMS_MenuInfo)(DataProvider.Instance().CMS_Menu_Get(PortalConnect, menuID))
    End Function
    Public Function CMS_Menu_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Menu_List(PortalConnect, portalId), GetType(CMS_MenuInfo))
    End Function
#End Region
#Region "CMS_MenuD"
    Public Function CMS_MenuD_Get(PortalConnect As String, menuD_ID As String) As CMS_MenuDInfo
        Return CBO.FillObject(Of CMS_MenuDInfo)(DataProvider.Instance().CMS_MenuD_Get(PortalConnect, menuD_ID))
    End Function
    Public Function CMS_MenuD_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MenuD_List(PortalConnect, portalId), GetType(CMS_MenuDInfo))
    End Function
    Public Function CMS_MenuD_List_By_MenuID(ByVal PortalConnect As String, menuID As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MenuD_List_By_MenuID(PortalConnect, menuID, portalId), GetType(CMS_MenuDInfo))
    End Function
    Public Function CMS_MenuD_List_By_ParentID(ByVal PortalConnect As String, paID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MenuD_List_By_ParentID(PortalConnect, paID), GetType(CMS_MenuDInfo))
    End Function
    Public Sub CMS_MenuD_Update_Quick(ByVal PortalConnect As String, menuD_ID As String, parent_ID As String, isOrder As Integer)
        DataProvider.Instance().CMS_MenuD_Update_Quick(PortalConnect, menuD_ID, parent_ID, isOrder)
    End Sub
    Public Sub CMS_MenuD_Delete_By_MenuID(ByVal PortalConnect As String, menu_ID As String)
        DataProvider.Instance().CMS_MenuD_Delete_By_MenuID(PortalConnect, menu_ID)
    End Sub
    Public Sub CMS_MenuD_Add(PortalConnect As String, obj As CMS_MenuDInfo)
        DataProvider.Instance().CMS_MenuD_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_MenuD_Update(PortalConnect As String, obj As CMS_MenuDInfo)
        DataProvider.Instance().CMS_MenuD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MenuD_Delete(PortalConnect As String, menuD_ID As String)
        DataProvider.Instance().CMS_MenuD_Delete(PortalConnect, menuD_ID)
    End Sub
#End Region
#Region "CMS_Infomation"
    Public Function CMS_Infomation_Get(PortalConnect As String, id As Integer) As CMS_InfomationInfo
        Return CBO.FillObject(Of CMS_InfomationInfo)(DataProvider.Instance().CMS_Infomation_Get(PortalConnect, id))
    End Function
    Public Function CMS_Infomation_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Infomation_List(PortalConnect, portalId), GetType(CMS_InfomationInfo))
    End Function

    Public Function CMS_Infomation_Add(PortalConnect As String, obj As CMS_InfomationInfo) As Integer
        Return DataProvider.Instance().CMS_Infomation_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Infomation_Update(PortalConnect As String, obj As CMS_InfomationInfo)
        DataProvider.Instance().CMS_Infomation_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Infomation_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Infomation_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "DM_Slider"
    Public Function DM_Slider_Get(PortalConnect As String, iD As Integer) As DM_SliderInfo
        Return CBO.FillObject(Of DM_SliderInfo)(DataProvider.Instance().DM_Slider_Get(PortalConnect, iD))
    End Function
    Public Function DM_Slider_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_Slider_List(PortalConnect), GetType(DM_SliderInfo))
    End Function
    Public Function DM_Slider_List_Home(PortalConnect As String, Top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_Slider_List_Home(PortalConnect, Top), GetType(DM_SliderInfo))
    End Function

    Public Function DM_Slider_Add(PortalConnect As String, obj As DM_SliderInfo) As Integer
        Return DataProvider.Instance().DM_Slider_Add(PortalConnect, obj)
    End Function
    Public Sub DM_Slider_Update(PortalConnect As String, obj As DM_SliderInfo)
        DataProvider.Instance().DM_Slider_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_Slider_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_Slider_Delete(PortalConnect, iD)
    End Sub
    Public Function DM_Slider_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_Slider_List_Search(PortalConnect, search, currPage, recodperpage), GetType(DM_SliderInfo))
    End Function
#End Region

#Region "CMS_NewsCategories"
    Public Function CMS_NewsCategories_List_By_Parent(PortalConnect As String, Parentid As Integer, PortalId As Integer, LanguageId As String, Optional ByVal Type As Integer = 1) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsCategories_List_By_Parent(PortalConnect, Parentid, PortalId, LanguageId, Type), GetType(CMS_NewsCategoriesInfo))
    End Function
    Public Sub CMS_NewsCategories_UpdateTabId(PortalConnect As String, categoryid As Integer, TabID As Integer, TabPath As String)
        DataProvider.Instance.CMS_NewsCategories_UpdateTabId(PortalConnect, categoryid, TabID, TabPath)
    End Sub
    Public Sub CMS_NewsCategories_Update_Order(PortalConnect As String, CategoryID As Integer, OrderNumber As Integer)
        DataProvider.Instance.CMS_NewsCategories_Update_Order(PortalConnect, CategoryID, OrderNumber)
    End Sub
    Public Function CMS_NewsCategoriesPermission_Get_By_Category(PortalConnect As String, userId As String, categoryId As Integer) As Integer
        Return CType(DataProvider.Instance().CMS_NewsCategoriesPermission_Get_By_Category(PortalConnect, userId, categoryId), Integer)
    End Function
    Public Function CMS_NewsCategories_ByParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional ByVal Type As Integer = 1, Optional ByVal ParentId As Integer = 0, Optional ByVal Search As String = "") As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsCategories_ByParentId(PortalConnect, PortalId, LanguageId, Type, ParentId, Search), GetType(CMS_NewsCategoriesInfo))
    End Function
    Public Function CMS_NewsCategories_Get_By_ParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, UserId As String, Optional ByVal Type As Integer = 1, Optional ByVal ParentId As Integer = 0) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsCategories_Get_By_ParentId(PortalConnect, PortalId, LanguageId, UserId, Type, ParentId), GetType(CMS_NewsCategoriesInfo))
    End Function
    Public Function CMS_NewsCategories_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional ByVal Type As Integer = 1) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsCategories_List_All(PortalConnect, PortalId, LanguageId, Type), GetType(CMS_NewsCategoriesInfo))
    End Function
    Public Function CMS_NewsCategories_Get_ID_By_TabMobileID(ByVal PortalConnect As String, TabID As Integer, Parent As Boolean) As CMS_NewsCategoriesInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesInfo)(DataProvider.Instance().CMS_NewsCategories_Get_ID_By_TabMobileID(PortalConnect, TabID, Parent))
    End Function
    Public Function CMS_NewsCategories_Get_By_TabID_Parent(ByVal PortalConnect As String, TabID As Integer, Parent As Boolean) As CMS_NewsCategoriesInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesInfo)(DataProvider.Instance().CMS_NewsCategories_Get_By_TabID_Parent(PortalConnect, TabID, Parent))
    End Function
    Public Function CMS_NewsCategories_Get_TabPath(ByVal PortalConnect As String, categoryid As Integer) As CMS_NewsCategoriesInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesInfo)(DataProvider.Instance().CMS_NewsCategories_Get_TabPath(PortalConnect, categoryid))
    End Function
    Public Function CMS_NewsCategories_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As CMS_NewsCategoriesInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesInfo)(DataProvider.Instance().CMS_NewsCategories_Get_By_TabID(PortalConnect, tabID, portalID))
    End Function
    Public Function CMS_NewsCategories_Get(PortalConnect As String, categoryID As Integer) As CMS_NewsCategoriesInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesInfo)(DataProvider.Instance().CMS_NewsCategories_Get(PortalConnect, categoryID))
    End Function
    Public Function CMS_NewsCategories_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsCategories_List(PortalConnect, portalId), GetType(CMS_NewsCategoriesInfo))
    End Function

    Public Function CMS_NewsCategories_Add(PortalConnect As String, obj As CMS_NewsCategoriesInfo) As Integer
        Return DataProvider.Instance().CMS_NewsCategories_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsCategories_Update(PortalConnect As String, obj As CMS_NewsCategoriesInfo)
        DataProvider.Instance().CMS_NewsCategories_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsCategories_Delete(PortalConnect As String, categoryID As Integer)
        DataProvider.Instance().CMS_NewsCategories_Delete(PortalConnect, categoryID)
    End Sub
#End Region

#Region "CMS_WebLink"
    Public Function CMS_WebLink_List_Search(PortalConnect As String, Name As String, ViewType As Integer, PortalId As Integer, LanguageId As String, PageSize As Integer, PageIndex As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WebLink_List_Search(PortalConnect, Name, ViewType, PortalId, LanguageId, PageSize, PageIndex), GetType(CMS_WebLinkInfo))
    End Function
    Public Function CMS_WebLink_Get(PortalConnect As String, id As Integer) As CMS_WebLinkInfo
        Return CBO.FillObject(Of CMS_WebLinkInfo)(DataProvider.Instance().CMS_WebLink_Get(PortalConnect, id))
    End Function
    Public Function CMS_WebLink_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WebLink_List(PortalConnect, portalId), GetType(CMS_WebLinkInfo))
    End Function
    Public Sub CMS_WebLink_Update_Order(PortalConnect As String, Id As Integer, OrderNo As Integer)
        DataProvider.Instance().CMS_WebLink_Update_Order(PortalConnect, Id, OrderNo)
    End Sub
    Public Function CMS_WebLink_Add(PortalConnect As String, obj As CMS_WebLinkInfo) As Integer
        Return DataProvider.Instance().CMS_WebLink_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_WebLink_Update(PortalConnect As String, obj As CMS_WebLinkInfo)
        DataProvider.Instance().CMS_WebLink_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_WebLink_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_WebLink_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "MAP_DATA"
    Public Function MAP_DATA_Get(PortalConnect As String, id As Integer) As MAP_DATAInfo
        Return CBO.FillObject(Of MAP_DATAInfo)(DataProvider.Instance().MAP_DATA_Get(PortalConnect, id))
    End Function
    Public Function MAP_DATA_GetData(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As Integer
        Return DataProvider.Instance().MAP_DATA_GetData(PortalConnect, tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, types)
    End Function
    Public Function MAP_DATA_ListData_ForMap(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_ListData_ForMap(PortalConnect, tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, types), GetType(MAP_DATAInfo))
    End Function
    Public Function MAP_DATA_ListData_By_List(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, color As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_ListData_By_List(PortalConnect, tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, color), GetType(MAP_DATALstInfo))
    End Function
    Public Function MAP_DATA_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_List(PortalConnect), GetType(MAP_DATAInfo))
    End Function

    Public Function MAP_DATA_Add(PortalConnect As String, obj As MAP_DATAInfo) As Integer
        Return DataProvider.Instance().MAP_DATA_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_DATA_Update(PortalConnect As String, obj As MAP_DATAInfo)
        DataProvider.Instance().MAP_DATA_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_DATA_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_DATA_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "MAP_DATA_BUSSINESS"
    Public Function MAP_DATA_BUSSINESS_Get(PortalConnect As String, id As Integer) As MAP_DATA_BUSSINESSInfo
        Return CBO.FillObject(Of MAP_DATA_BUSSINESSInfo)(DataProvider.Instance().MAP_DATA_BUSSINESS_Get(PortalConnect, id))
    End Function
    Public Function MAP_DATA_BUSSINESS_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_BUSSINESS_List(PortalConnect), GetType(MAP_DATA_BUSSINESSInfo))
    End Function
    Public Function MAP_DATA_BUSSINESS_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_BUSSINESS_List_Search(PortalConnect, key, currPage, recordPerPage, tinhTp, quanHuyen, phuongXa), GetType(MAP_DATA_BUSSINESSInfo))
    End Function

    Public Function MAP_DATA_BUSSINESS_Add(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo) As Integer
        Return DataProvider.Instance().MAP_DATA_BUSSINESS_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_DATA_BUSSINESS_Update(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo)
        DataProvider.Instance().MAP_DATA_BUSSINESS_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_DATA_BUSSINESS_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_DATA_BUSSINESS_Delete(PortalConnect, id)
    End Sub
    Public Sub MAP_DATA_BUSSINESS_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)
        DataProvider.Instance().MAP_DATA_BUSSINESS_Delete_ByHC(PortalConnect, tinhTp, quanHuyen, phuongXa)
    End Sub
#End Region
#Region "MAP_DATA_WORK"
    Public Sub MAP_DATA_WORK_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)
        DataProvider.Instance().MAP_DATA_WORK_Delete_ByHC(PortalConnect, tinhTp, quanHuyen, phuongXa)
    End Sub
    Public Function MAP_DATA_WORK_Get(PortalConnect As String, id As Integer) As MAP_DATA_WORKInfo
        Return CBO.FillObject(Of MAP_DATA_WORKInfo)(DataProvider.Instance().MAP_DATA_WORK_Get(PortalConnect, id))
    End Function
    Public Function MAP_DATA_WORK_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_WORK_List_Search(PortalConnect, key, currPage, recordPerPage, tinhTp, quanHuyen, phuongXa), GetType(MAP_DATA_WORKInfo))
    End Function
    Public Function MAP_DATA_WORK_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_DATA_WORK_List(PortalConnect), GetType(MAP_DATA_WORKInfo))
    End Function

    Public Function MAP_DATA_WORK_Add(PortalConnect As String, obj As MAP_DATA_WORKInfo) As Integer
        Return DataProvider.Instance().MAP_DATA_WORK_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_DATA_WORK_Update(PortalConnect As String, obj As MAP_DATA_WORKInfo)
        DataProvider.Instance().MAP_DATA_WORK_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_DATA_WORK_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_DATA_WORK_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_PageLocal"
    Public Function CMS_PageLocal_Get(PortalConnect As String, pageLocalID As Integer) As CMS_PageLocalInfo
        Return CBO.FillObject(Of CMS_PageLocalInfo)(DataProvider.Instance().CMS_PageLocal_Get(PortalConnect, pageLocalID))
    End Function
    Public Function CMS_PageLocal_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PageLocal_List(PortalConnect), GetType(CMS_PageLocalInfo))
    End Function

    Public Sub CMS_PageLocal_Add(PortalConnect As String, obj As CMS_PageLocalInfo)
        DataProvider.Instance().CMS_PageLocal_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_PageLocal_Update(PortalConnect As String, obj As CMS_PageLocalInfo)
        DataProvider.Instance().CMS_PageLocal_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_PageLocal_Delete(PortalConnect As String, pageLocalID As Integer)
        DataProvider.Instance().CMS_PageLocal_Delete(PortalConnect, pageLocalID)
    End Sub
#End Region
#Region "MAP_KyNhapLieu"
    Public Function MAP_KyNhapLieu_Get(PortalConnect As String, id As Integer) As MAP_KyNhapLieuInfo
        Return CBO.FillObject(Of MAP_KyNhapLieuInfo)(DataProvider.Instance().MAP_KyNhapLieu_Get(PortalConnect, id))
    End Function
    Public Function MAP_KyNhapLieu_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_KyNhapLieu_List(PortalConnect), GetType(MAP_KyNhapLieuInfo))
    End Function
    Public Function MAP_KyNhapLieu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().MAP_KyNhapLieu_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(MAP_KyNhapLieuInfo))
    End Function

    Public Function MAP_KyNhapLieu_Add(PortalConnect As String, obj As MAP_KyNhapLieuInfo) As Integer
        Return DataProvider.Instance().MAP_KyNhapLieu_Add(PortalConnect, obj)
    End Function
    Public Sub MAP_KyNhapLieu_Update(PortalConnect As String, obj As MAP_KyNhapLieuInfo)
        DataProvider.Instance().MAP_KyNhapLieu_Update(PortalConnect, obj)
    End Sub
    Public Sub MAP_KyNhapLieu_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().MAP_KyNhapLieu_Delete(PortalConnect, id)
    End Sub
#End Region
End Class