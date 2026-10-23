Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.MAP", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region

#Region "CMS_Group"
    Public MustOverride Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As IDataReader
    Public MustOverride Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
    Public MustOverride Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
    Public MustOverride Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
    Public MustOverride Sub CMS_Group_Update_IsHome(PortalConnect As String, groupId As Integer, isHome As Boolean)
    Public MustOverride Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
#End Region
#Region "CMS_Targets"
    Public MustOverride Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
    Public MustOverride Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Targets_List_IsGroup(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
    Public MustOverride Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentID As Integer) As String
    Public MustOverride Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
    Public MustOverride Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Parent_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As IDataReader
    Public MustOverride Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Targets_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer, Targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
    Public MustOverride Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
    Public MustOverride Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
    Public MustOverride Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As IDataReader


#End Region
#Region "Banner"
    Public MustOverride Function Banner_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function Banner_List(PortalConnect As String) As IDataReader
    Public MustOverride Function Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function Banner_Add(PortalConnect As String, obj As BannerInfo) As Integer
    Public MustOverride Sub Banner_Update(PortalConnect As String, obj As BannerInfo)
    Public MustOverride Sub Banner_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "LienKet"
    Public MustOverride Function LienKet_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function LienKet_List(PortalConnect As String) As IDataReader
    Public MustOverride Function LienKet_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function LienKet_Add(PortalConnect As String, obj As LienKetInfo) As Integer
    Public MustOverride Sub LienKet_Update(PortalConnect As String, obj As LienKetInfo)
    Public MustOverride Sub LienKet_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "MauSac"
    Public MustOverride Function MauSac_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MauSac_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MauSac_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function MauSac_Add(PortalConnect As String, obj As MauSacInfo) As Integer
    Public MustOverride Sub MauSac_Update(PortalConnect As String, obj As MauSacInfo)
    Public MustOverride Sub MauSac_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "LopBanDo"
    Public MustOverride Function LopBanDo_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function LopBanDo_List(PortalConnect As String) As IDataReader
    Public MustOverride Function LopBanDo_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function LopBanDo_Add(PortalConnect As String, obj As LopBanDoInfo) As Integer
    Public MustOverride Sub LopBanDo_Update(PortalConnect As String, obj As LopBanDoInfo)
    Public MustOverride Sub LopBanDo_Delete(PortalConnect As String, id As Integer)
    Public MustOverride Sub LopBanDo_DeleteMauSac(PortalConnect As String, id As Integer)
    Public MustOverride Function LopBanDo_List_ById(PortalConnect As String, IdStr As String) As IDataReader
    Public MustOverride Function LopBanDo_List_Search_By(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, TargetGroup As String) As IDataReader
    Public MustOverride Function Map_List_Search_ByDoanhNghiep(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As IDataReader
    Public MustOverride Function Map_List_Search_ByTuyenDung(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As IDataReader
#End Region
#Region "DiemLop"
    Public MustOverride Function DiemLop_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function DiemLop_List(PortalConnect As String) As IDataReader
    Public MustOverride Function DiemLop_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DiemLop_Add(PortalConnect As String, obj As DiemLopInfo) As Integer
    Public MustOverride Sub DiemLop_Update(PortalConnect As String, obj As DiemLopInfo)
    Public MustOverride Sub DiemLop_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "VungBanDo"
    Public MustOverride Function VungBanDo_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function VungBanDo_List(PortalConnect As String) As IDataReader
    Public MustOverride Function VungBanDo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function VungBanDo_Add(PortalConnect As String, obj As VungBanDoInfo) As Integer
    Public MustOverride Sub VungBanDo_Update(PortalConnect As String, obj As VungBanDoInfo)
    Public MustOverride Sub VungBanDo_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "BoCuc"
    Public MustOverride Function BoCuc_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function BoCuc_List(PortalConnect As String) As IDataReader
    Public MustOverride Function BoCuc_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function BoCuc_Add(PortalConnect As String, obj As BoCucInfo) As Integer
    Public MustOverride Sub BoCuc_Update(PortalConnect As String, obj As BoCucInfo)
    Public MustOverride Sub BoCuc_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "MAP_API"
    Public MustOverride Function MAP_API_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_API_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function MAP_API_Add(PortalConnect As String, obj As MAP_APIInfo) As Integer
    Public MustOverride Sub MAP_API_Update(PortalConnect As String, obj As MAP_APIInfo)
    Public MustOverride Sub MAP_API_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "MAP_APIHeader"
    Public MustOverride Function MAP_APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
    'Public MustOverride Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    Public MustOverride Function MAP_APIHeader_Add(PortalConnect As String, obj As MAP_APIHeaderInfo) As Integer
    Public MustOverride Sub MAP_APIHeader_Update(PortalConnect As String, obj As MAP_APIHeaderInfo)
    Public MustOverride Sub MAP_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function MAP_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub MAP_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)

#End Region
#Region "MAP_LogsAPI"
    Public MustOverride Function MAP_LogsAPI_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_LogsAPI_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_LogsAPI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function MAP_LogsAPI_Add(PortalConnect As String, obj As MAP_LogsAPIInfo) As Integer
    Public MustOverride Sub MAP_LogsAPI_Update(PortalConnect As String, obj As MAP_LogsAPIInfo)
    Public MustOverride Sub MAP_LogsAPI_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "MAP_NhomMenu"
    Public MustOverride Function MAP_NhomMenu_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_NhomMenu_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_NhomMenu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function MAP_NhomMenu_Add(PortalConnect As String, obj As MAP_NhomMenuInfo) As Integer
    Public MustOverride Sub MAP_NhomMenu_Update(PortalConnect As String, obj As MAP_NhomMenuInfo)
    Public MustOverride Sub MAP_NhomMenu_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "MAP_Menu"
    Public MustOverride Function MAP_Menu_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_Menu_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_Menu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function MAP_Menu_Add(PortalConnect As String, obj As MAP_MenuInfo) As Integer
    Public MustOverride Sub MAP_Menu_Update(PortalConnect As String, obj As MAP_MenuInfo)
    Public MustOverride Sub MAP_Menu_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "HT_ThietLap"
    Public MustOverride Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
    Public MustOverride Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
#End Region

#Region "CMS_Advertise"
    Public MustOverride Function CMS_Advertise_Get_By_Category(PortalConnect As String, PageLoca_ID As String, CategoryID As Integer) As IDataReader
    Public MustOverride Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As IDataReader
    Public MustOverride Function CMS_Advertise_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, pageLocaID As String, Top As Integer) As IDataReader
    Public MustOverride Function CMS_Advertise_List_Search(PortalConnect As String, portalID As Integer, isLang As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, pageLoca_ID As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_Advertise_Get_By_CMS_PageLoca(PortalConnect As String, pageLoca_ID As String) As IDataReader
    Public MustOverride Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
    Public MustOverride Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
    Public MustOverride Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
#End Region

#Region "CMS_Menu"

    Public MustOverride Function CMS_Menu_Add(PortalConnect As String, obj As CMS_MenuInfo) As Integer
    Public MustOverride Sub CMS_Menu_Update(PortalConnect As String, obj As CMS_MenuInfo)
    Public MustOverride Sub CMS_Menu_Delete(PortalConnect As String, menuID As String)
    Public MustOverride Function CMS_Menu_Get(PortalConnect As String, menuID As String) As IDataReader
    Public MustOverride Function CMS_Menu_List(PortalConnect As String, portalId As Integer) As IDataReader
#End Region
#Region "CMS_MenuD"
    Public MustOverride Function CMS_MenuD_Get(PortalConnect As String, menuD_ID As String) As IDataReader
    Public MustOverride Function CMS_MenuD_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_MenuD_List_By_MenuID(PortalConnect As String, menuID As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_MenuD_List_By_ParentID(PortalConnect As String, parentID As String) As IDataReader
    Public MustOverride Sub CMS_MenuD_Delete_By_MenuID(PortalConnect As String, menu_ID As String)
    Public MustOverride Sub CMS_MenuD_Update_Quick(PortalConnect As String, menuD_ID As String, parent_ID As String, isOrder As Integer)

    Public MustOverride Sub CMS_MenuD_Add(PortalConnect As String, obj As CMS_MenuDInfo)
    Public MustOverride Sub CMS_MenuD_Update(PortalConnect As String, obj As CMS_MenuDInfo)
    Public MustOverride Sub CMS_MenuD_Delete(PortalConnect As String, menuD_ID As String)
#End Region

#Region "DM_Slider"
    Public MustOverride Function DM_Slider_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_Slider_List(PortalConnect As String) As IDataReader
    Public MustOverride Function DM_Slider_List_Home(PortalConnect As String, Top As Integer) As IDataReader
    Public MustOverride Function DM_Slider_Add(PortalConnect As String, obj As DM_SliderInfo) As Integer
    Public MustOverride Sub DM_Slider_Update(PortalConnect As String, obj As DM_SliderInfo)
    Public MustOverride Sub DM_Slider_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function DM_Slider_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region

#Region "CMS_WebLink"
    Public MustOverride Function CMS_WebLink_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_WebLink_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_WebLink_List_Search(PortalConnect As String, Name As String, ViewType As Integer, PortalId As Integer, LanguageId As String, PageSize As Integer, PageIndex As Integer) As IDataReader
    Public MustOverride Sub CMS_WebLink_Update_Order(PortalConnect As String, Id As Integer, OrderNo As Integer)
    Public MustOverride Function CMS_WebLink_Add(PortalConnect As String, obj As CMS_WebLinkInfo) As Integer
    Public MustOverride Sub CMS_WebLink_Update(PortalConnect As String, obj As CMS_WebLinkInfo)
    Public MustOverride Sub CMS_WebLink_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Infomation"
    Public MustOverride Function CMS_Infomation_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Infomation_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Infomation_Add(PortalConnect As String, obj As CMS_InfomationInfo) As Integer
    Public MustOverride Sub CMS_Infomation_Update(PortalConnect As String, obj As CMS_InfomationInfo)
    Public MustOverride Sub CMS_Infomation_Delete(PortalConnect As String, id As Integer)
#End Region

#Region "CMS_NewsCategories"
    Public MustOverride Function CMS_NewsCategories_List_By_Parent(PortalConnect As String, Parentid As Integer, PortalId As Integer, LanguageId As String, Type As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsCategories_UpdateTabId(PortalConnect As String, categoryid As Integer, TabID As Integer, TabPath As String)
    Public MustOverride Sub CMS_NewsCategories_Update_Order(PortalConnect As String, categoryid As Integer, OrderNumber As Integer)
    Public MustOverride Function CMS_NewsCategoriesPermission_Get_By_Category(PortalConnect As String, userId As String, categoryId As Integer) As Integer
    Public MustOverride Function CMS_NewsCategories_ByParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0, Optional Search As String = "") As IDataReader
    Public MustOverride Function CMS_NewsCategories_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1) As IDataReader
    Public MustOverride Sub CMS_NewsByCategory_Delete_By_NewsID(PortalConnect As String, NewsId As Integer)
    Public MustOverride Function CMS_NewsCategories_Get_By_TabID_Parent(PortalConnect As String, TabID As Integer, Parent As Boolean) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Get_ID_By_TabMobileID(PortalConnect As String, TabID As Integer, Parent As Boolean) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Get_TabPath(PortalConnect As String, categoryid As Integer) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Get_By_ParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, UserID As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Get(PortalConnect As String, categoryID As Integer) As IDataReader
    Public MustOverride Function CMS_NewsCategories_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsCategories_Add(PortalConnect As String, obj As CMS_NewsCategoriesInfo) As Integer
    Public MustOverride Sub CMS_NewsCategories_Update(PortalConnect As String, obj As CMS_NewsCategoriesInfo)
    Public MustOverride Sub CMS_NewsCategories_Delete(PortalConnect As String, categoryID As Integer)
#End Region
#Region "MAP_DATA"
    Public MustOverride Function MAP_DATA_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_DATA_GetData(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As Integer
    Public MustOverride Function MAP_DATA_ListData_ForMap(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As IDataReader
    Public MustOverride Function MAP_DATA_ListData_By_List(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, color As String) As IDataReader
    Public MustOverride Function MAP_DATA_List(PortalConnect As String) As IDataReader

    Public MustOverride Function MAP_DATA_Add(PortalConnect As String, obj As MAP_DATAInfo) As Integer
    Public MustOverride Sub MAP_DATA_Update(PortalConnect As String, obj As MAP_DATAInfo)
    Public MustOverride Sub MAP_DATA_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "MAP_DATA_BUSSINESS"
    Public MustOverride Function MAP_DATA_BUSSINESS_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_DATA_BUSSINESS_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_DATA_BUSSINESS_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As IDataReader

    Public MustOverride Function MAP_DATA_BUSSINESS_Add(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo) As Integer
    Public MustOverride Sub MAP_DATA_BUSSINESS_Update(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo)
    Public MustOverride Sub MAP_DATA_BUSSINESS_Delete(PortalConnect As String, id As Integer)
    Public MustOverride Sub MAP_DATA_BUSSINESS_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)
#End Region
#Region "MAP_DATA_WORK"
    Public MustOverride Sub MAP_DATA_WORK_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)

    Public MustOverride Function MAP_DATA_WORK_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_DATA_WORK_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As IDataReader
    Public MustOverride Function MAP_DATA_WORK_List(PortalConnect As String) As IDataReader

    Public MustOverride Function MAP_DATA_WORK_Add(PortalConnect As String, obj As MAP_DATA_WORKInfo) As Integer
    Public MustOverride Sub MAP_DATA_WORK_Update(PortalConnect As String, obj As MAP_DATA_WORKInfo)
    Public MustOverride Sub MAP_DATA_WORK_Delete(PortalConnect As String, id As Integer)
#End Region

#Region "CMS_PageLocal"
    Public MustOverride Function CMS_PageLocal_Get(PortalConnect As String, pageLocalID As Integer) As IDataReader
    Public MustOverride Function CMS_PageLocal_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_PageLocal_Add(PortalConnect As String, obj As CMS_PageLocalInfo)
    Public MustOverride Sub CMS_PageLocal_Update(PortalConnect As String, obj As CMS_PageLocalInfo)
    Public MustOverride Sub CMS_PageLocal_Delete(PortalConnect As String, pageLocalID As Integer)
#End Region
#Region "MAP_KyNhapLieu"
    Public MustOverride Function MAP_KyNhapLieu_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function MAP_KyNhapLieu_List(PortalConnect As String) As IDataReader
    Public MustOverride Function MAP_KyNhapLieu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function MAP_KyNhapLieu_Add(PortalConnect As String, obj As MAP_KyNhapLieuInfo) As Integer
    Public MustOverride Sub MAP_KyNhapLieu_Update(PortalConnect As String, obj As MAP_KyNhapLieuInfo)
    Public MustOverride Sub MAP_KyNhapLieu_Delete(PortalConnect As String, id As Integer)
#End Region
End Class

