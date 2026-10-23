Imports DotNetNuke.Common.Utilities
Public Class CmsController
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
#Region "CMS_Authors"
    Public Function CMS_Authors_Get(PortalConnect As String, authors_ID As String) As CMS_AuthorsInfo
        Return CBO.FillObject(Of CMS_AuthorsInfo)(DataProvider.Instance().CMS_Authors_Get(PortalConnect, authors_ID))
    End Function
    Public Function CMS_Authors_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Authors_List(PortalConnect, portalId), GetType(CMS_AuthorsInfo))
    End Function
    Public Function CMS_Authors_List_Search(ByVal PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Authors_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_AuthorsInfo))
    End Function
    Public Sub CMS_Authors_Add(PortalConnect As String, obj As CMS_AuthorsInfo)
        DataProvider.Instance().CMS_Authors_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Authors_Update(PortalConnect As String, obj As CMS_AuthorsInfo)
        DataProvider.Instance().CMS_Authors_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Authors_Delete(PortalConnect As String, authors_ID As String)
        DataProvider.Instance().CMS_Authors_Delete(PortalConnect, authors_ID)
    End Sub
#End Region
#Region "CMS_Calendar"
    Public Function CMS_Calendar_Get(PortalConnect As String, calendar_ID As String) As CMS_CalendarInfo
        Return CBO.FillObject(Of CMS_CalendarInfo)(DataProvider.Instance().CMS_Calendar_Get(PortalConnect, calendar_ID))
    End Function
    Public Function CMS_Calendar_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Calendar_List(PortalConnect, portalId), GetType(CMS_CalendarInfo))
    End Function

    Public Sub CMS_Calendar_Add(PortalConnect As String, obj As CMS_CalendarInfo)
        DataProvider.Instance().CMS_Calendar_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Calendar_Update(PortalConnect As String, obj As CMS_CalendarInfo)
        DataProvider.Instance().CMS_Calendar_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Calendar_Delete(PortalConnect As String, calendar_ID As String)
        DataProvider.Instance().CMS_Calendar_Delete(PortalConnect, calendar_ID)
    End Sub
#End Region
#Region "CMS_DocField"
    Public Function CMS_DocField_Get(PortalConnect As String, docField_ID As String) As CMS_DocFieldInfo
        Return CBO.FillObject(Of CMS_DocFieldInfo)(DataProvider.Instance().CMS_DocField_Get(PortalConnect, docField_ID))
    End Function
    Public Function CMS_DocField_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocField_List(PortalConnect, portalId), GetType(CMS_DocFieldInfo))
    End Function
    Public Function CMS_DocField_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocField_List_Search(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_DocFieldInfo))
    End Function
    Public Sub CMS_DocField_Add(PortalConnect As String, obj As CMS_DocFieldInfo)
        DataProvider.Instance().CMS_DocField_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocField_Update(PortalConnect As String, obj As CMS_DocFieldInfo)
        DataProvider.Instance().CMS_DocField_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocField_Delete(PortalConnect As String, docField_ID As String)
        DataProvider.Instance().CMS_DocField_Delete(PortalConnect, docField_ID)
    End Sub
#End Region
#Region "CMS_DocUnit"
    Public Function CMS_DocUnit_Get(PortalConnect As String, DocUnit_ID As String) As CMS_DocUnitInfo
        Return CBO.FillObject(Of CMS_DocUnitInfo)(DataProvider.Instance().CMS_DocUnit_Get(PortalConnect, DocUnit_ID))
    End Function
    Public Function CMS_DocUnit_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocUnit_List(PortalConnect, portalId), GetType(CMS_DocUnitInfo))
    End Function
    Public Function CMS_DocUnit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocUnit_List_Search(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_DocUnitInfo))
    End Function
    Public Sub CMS_DocUnit_Add(PortalConnect As String, obj As CMS_DocUnitInfo)
        DataProvider.Instance().CMS_DocUnit_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocUnit_Update(PortalConnect As String, obj As CMS_DocUnitInfo)
        DataProvider.Instance().CMS_DocUnit_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocUnit_Delete(PortalConnect As String, DocUnit_ID As String)
        DataProvider.Instance().CMS_DocUnit_Delete(PortalConnect, DocUnit_ID)
    End Sub
#End Region
#Region "CMS_DocType"
    Public Function CMS_DocType_Get(PortalConnect As String, docType_ID As String) As CMS_DocTypeInfo
        Return CBO.FillObject(Of CMS_DocTypeInfo)(DataProvider.Instance().CMS_DocType_Get(PortalConnect, docType_ID))
    End Function
    Public Function CMS_DocType_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocType_List(PortalConnect, portalId), GetType(CMS_DocTypeInfo))
    End Function
    Public Function CMS_DocType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_DocTypeInfo))
    End Function
    Public Sub CMS_DocType_Add(PortalConnect As String, obj As CMS_DocTypeInfo)
        DataProvider.Instance().CMS_DocType_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocType_Update(PortalConnect As String, obj As CMS_DocTypeInfo)
        DataProvider.Instance().CMS_DocType_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocType_Delete(PortalConnect As String, docType_ID As String)
        DataProvider.Instance().CMS_DocType_Delete(PortalConnect, docType_ID)
    End Sub
#End Region
#Region "CMS_Document"
    Public Function CMS_Document_Get(PortalConnect As String, document_ID As String) As CMS_DocumentInfo
        Return CBO.FillObject(Of CMS_DocumentInfo)(DataProvider.Instance().CMS_Document_Get(PortalConnect, document_ID))
    End Function
    Public Function CMS_Document_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Document_List(PortalConnect, portalId), GetType(CMS_DocumentInfo))
    End Function
    Public Function CMS_Document_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, docGroup_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Document_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, docType_ID, docField_ID, docGroup_ID), GetType(CMS_DocumentInfo))
    End Function
    Public Function CMS_Document_List_Home(PortalConnect As String, search As String, docType_ID As String, docFiled_ID As String, docUnit_ID As String, docGroup_ID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Document_List_Home(PortalConnect, search, docType_ID, docFiled_ID, docUnit_ID, docGroup_ID, currPage, recodperpage), GetType(CMS_DocumentInfo))
    End Function
    Public Sub CMS_Document_Add(PortalConnect As String, obj As CMS_DocumentInfo)
        DataProvider.Instance().CMS_Document_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Document_Update(PortalConnect As String, obj As CMS_DocumentInfo)
        DataProvider.Instance().CMS_Document_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Document_Update_IsDownload(PortalConnect As String, document_ID As String)
        DataProvider.Instance().CMS_Document_Update_IsDownload(PortalConnect, document_ID)
    End Sub
    Public Sub CMS_Document_Update_IsActive(PortalConnect As String, document_ID As String, IsActive As Boolean, UpdatedBy As DateTime, UpdateName As String)
        DataProvider.Instance().CMS_Document_Update_IsActive(PortalConnect, document_ID, IsActive, UpdatedBy, UpdateName)
    End Sub
    Public Sub CMS_Document_Delete(PortalConnect As String, document_ID As String)
        DataProvider.Instance().CMS_Document_Delete(PortalConnect, document_ID)
    End Sub
    Public Function CMS_Document_ListCheck_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, isActive As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Document_ListCheck_Search(PortalConnect, search, isOrder, currPage, recodperpage, docType_ID, docField_ID, isActive), GetType(CMS_DocumentInfo))
    End Function
#End Region
#Region "CMS_DocGroup"
    Public Function CMS_DocGroup_List_Parent_NULL(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocGroup_List_Parent_NULL(PortalConnect), GetType(CMS_DocGroupInfo))
    End Function
    Public Function CMS_DocGroup_Get(PortalConnect As String, docGroupID As String) As CMS_DocGroupInfo
        Return CBO.FillObject(Of CMS_DocGroupInfo)(DataProvider.Instance().CMS_DocGroup_Get(PortalConnect, docGroupID))
    End Function
    Public Function CMS_DocGroup_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocGroup_List(PortalConnect, portalId), GetType(CMS_DocGroupInfo))
    End Function
    Public Function CMS_DocGroup_Get_By_CMS_DocGroup(PortalConnect As String, docGroupID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DocGroup_Get_By_CMS_DocGroup(PortalConnect, docGroupID), GetType(CMS_DocGroupInfo))
    End Function
    Public Sub CMS_DocGroup_Delete_By_CMS_DocGroup(PortalConnect As String, docGroupID As String)
        DataProvider.Instance().CMS_DocGroup_Delete_By_CMS_DocGroup(PortalConnect, docGroupID)
    End Sub
    Public Sub CMS_DocGroup_Add(PortalConnect As String, obj As CMS_DocGroupInfo)
        DataProvider.Instance().CMS_DocGroup_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocGroup_Update(PortalConnect As String, obj As CMS_DocGroupInfo)
        DataProvider.Instance().CMS_DocGroup_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DocGroup_Delete(PortalConnect As String, docGroupID As String)
        DataProvider.Instance().CMS_DocGroup_Delete(PortalConnect, docGroupID)
    End Sub
#End Region
#Region "CMS_Events"
    Public Function CMS_Events_Get(PortalConnect As String, event_ID As String) As CMS_EventsInfo
        Return CBO.FillObject(Of CMS_EventsInfo)(DataProvider.Instance().CMS_Events_Get(PortalConnect, event_ID))
    End Function
    Public Function CMS_Events_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Events_List(PortalConnect, portalId), GetType(CMS_EventsInfo))
    End Function

    Public Sub CMS_Events_Add(PortalConnect As String, obj As CMS_EventsInfo)
        DataProvider.Instance().CMS_Events_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Events_Update(PortalConnect As String, obj As CMS_EventsInfo)
        DataProvider.Instance().CMS_Events_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Events_Delete(PortalConnect As String, event_ID As String)
        DataProvider.Instance().CMS_Events_Delete(PortalConnect, event_ID)
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
#Region "CMS_NewsPapers"
    Public Function CMS_NewsPapers_Get(PortalConnect As String, newsPapers_ID As String) As CMS_NewsPapersInfo
        Return CBO.FillObject(Of CMS_NewsPapersInfo)(DataProvider.Instance().CMS_NewsPapers_Get(PortalConnect, newsPapers_ID))
    End Function
    Public Function CMS_NewsPapers_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsPapers_List(PortalConnect, portalId), GetType(CMS_NewsPapersInfo))
    End Function

    Public Sub CMS_NewsPapers_Add(PortalConnect As String, obj As CMS_NewsPapersInfo)
        DataProvider.Instance().CMS_NewsPapers_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsPapers_Update(PortalConnect As String, obj As CMS_NewsPapersInfo)
        DataProvider.Instance().CMS_NewsPapers_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsPapers_Delete(PortalConnect As String, newsPapers_ID As String)
        DataProvider.Instance().CMS_NewsPapers_Delete(PortalConnect, newsPapers_ID)
    End Sub
#End Region
#Region "CMS_NewsPapersD"
    Public Function CMS_NewsPapersD_Get(PortalConnect As String, newsPapersD_ID As String) As CMS_NewsPapersDInfo
        Return CBO.FillObject(Of CMS_NewsPapersDInfo)(DataProvider.Instance().CMS_NewsPapersD_Get(PortalConnect, newsPapersD_ID))
    End Function
    Public Function CMS_NewsPapersD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsPapersD_List(PortalConnect), GetType(CMS_NewsPapersDInfo))
    End Function
    Public Function CMS_NewsPapersD_Get_By_CMS_NewsPapers(PortalConnect As String, newsPapers_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsPapersD_Get_By_CMS_NewsPapers(PortalConnect, newsPapers_ID), GetType(CMS_NewsPapersDInfo))
    End Function

    Public Sub CMS_NewsPapersD_Add(PortalConnect As String, obj As CMS_NewsPapersDInfo)
        DataProvider.Instance().CMS_NewsPapersD_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsPapersD_Update(PortalConnect As String, obj As CMS_NewsPapersDInfo)
        DataProvider.Instance().CMS_NewsPapersD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsPapersD_Delete(PortalConnect As String, newsPapersD_ID As String)
        DataProvider.Instance().CMS_NewsPapersD_Delete(PortalConnect, newsPapersD_ID)
    End Sub
#End Region
#Region "CMS_NewsRoy"
    Public Function CMS_NewsRoy_Get(PortalConnect As String, newsRoy_ID As String) As CMS_NewsRoyInfo
        Return CBO.FillObject(Of CMS_NewsRoyInfo)(DataProvider.Instance().CMS_NewsRoy_Get(PortalConnect, newsRoy_ID))
    End Function
    Public Function CMS_NewsRoy_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsRoy_List(PortalConnect), GetType(CMS_NewsRoyInfo))
    End Function
    Public Function CMS_NewsRoy_Get_By_CMS_News(PortalConnect As String, newId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsRoy_Get_By_CMS_News(PortalConnect, newId), GetType(CMS_NewsRoyInfo))
    End Function

    Public Sub CMS_NewsRoy_Add(PortalConnect As String, obj As CMS_NewsRoyInfo)
        DataProvider.Instance().CMS_NewsRoy_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsRoy_Update(PortalConnect As String, obj As CMS_NewsRoyInfo)
        DataProvider.Instance().CMS_NewsRoy_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsRoy_Delete(PortalConnect As String, newsRoy_ID As String)
        DataProvider.Instance().CMS_NewsRoy_Delete(PortalConnect, newsRoy_ID)
    End Sub
#End Region
#Region "CMS_Notify"
    Public Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As CMS_NotifyInfo
        Return CBO.FillObject(Of CMS_NotifyInfo)(DataProvider.Instance().CMS_Notify_Get(PortalConnect, notify_ID))
    End Function
    Public Function CMS_Notify_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Notify_List(PortalConnect), GetType(CMS_NotifyInfo))
    End Function

    Public Sub CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo)
        DataProvider.Instance().CMS_Notify_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
        DataProvider.Instance().CMS_Notify_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Notify_Delete(PortalConnect As String, notify_ID As String)
        DataProvider.Instance().CMS_Notify_Delete(PortalConnect, notify_ID)
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
#Region "CMS_PenName"
    Public Function CMS_PenName_Get(PortalConnect As String, id As Integer) As CMS_PenNameInfo
        Return CBO.FillObject(Of CMS_PenNameInfo)(DataProvider.Instance().CMS_PenName_Get(PortalConnect, id))
    End Function
    Public Function CMS_PenName_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PenName_List(PortalConnect, portalId), GetType(CMS_PenNameInfo))
    End Function

    Public Sub CMS_PenName_Add(PortalConnect As String, obj As CMS_PenNameInfo)
        DataProvider.Instance().CMS_PenName_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_PenName_Update(PortalConnect As String, obj As CMS_PenNameInfo)
        DataProvider.Instance().CMS_PenName_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_PenName_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_PenName_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_Setups"
    Public Function CMS_Setups_Get(PortalConnect As String, iD As String) As CMS_SetupsInfo
        Return CBO.FillObject(Of CMS_SetupsInfo)(DataProvider.Instance().CMS_Setups_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Setups_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Setups_List(PortalConnect, portalId), GetType(CMS_SetupsInfo))
    End Function
    Public Function CMS_Setups_Get_By_Name(PortalConnect As String, settingName As String) As CMS_SetupsInfo
        Return CBO.FillObject(Of CMS_SetupsInfo)(DataProvider.Instance().CMS_Setups_Get_By_Name(PortalConnect, settingName))
    End Function
    Public Function CMS_ConfigSystem_Get_PortalID(PortalConnect As String, PortalID As Integer) As CMS_ConfigSystemInfo
        Return CBO.FillObject(Of CMS_ConfigSystemInfo)(DataProvider.Instance().CMS_ConfigSystem_Get_PortalID(PortalConnect, PortalID))
    End Function
    Public Sub CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
        DataProvider.Instance().CMS_Setups_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Setups_Update(PortalConnect As String, obj As CMS_SetupsInfo)
        DataProvider.Instance().CMS_Setups_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Setups_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().CMS_Setups_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SiteMap"
    Public Function CMS_SiteMap_Get(PortalConnect As String, siteMap_ID As String) As CMS_SiteMapInfo
        Return CBO.FillObject(Of CMS_SiteMapInfo)(DataProvider.Instance().CMS_SiteMap_Get(PortalConnect, siteMap_ID))
    End Function
    Public Function CMS_SiteMap_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SiteMap_List(PortalConnect, portalId), GetType(CMS_SiteMapInfo))
    End Function

    Public Sub CMS_SiteMap_Add(PortalConnect As String, obj As CMS_SiteMapInfo)
        DataProvider.Instance().CMS_SiteMap_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_SiteMap_Update(PortalConnect As String, obj As CMS_SiteMapInfo)
        DataProvider.Instance().CMS_SiteMap_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SiteMap_Delete(PortalConnect As String, siteMap_ID As String)
        DataProvider.Instance().CMS_SiteMap_Delete(PortalConnect, siteMap_ID)
    End Sub
#End Region
#Region "CMS_Block"
    Public Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Block_List_By_Flag(PortalConnect, flag), GetType(CMS_BlockInfo))
    End Function
    Public Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As CMS_BlockInfo
        Return CBO.FillObject(Of CMS_BlockInfo)(DataProvider.Instance().CMS_Block_Get_By_Key(PortalConnect, idkey))
    End Function
#End Region
#Region "CMS_Contact"
    Public Function CMS_Contact_Get(PortalConnect As String, id As Integer) As CMS_ContactInfo
        Return CBO.FillObject(Of CMS_ContactInfo)(DataProvider.Instance().CMS_Contact_Get(PortalConnect, id))
    End Function
    Public Function CMS_Contact_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Contact_List(PortalConnect, portalId), GetType(CMS_ContactInfo))
    End Function
    Public Sub CMS_Contact_Update_Status(PortalConnect As String, Optional ByVal id As Integer = 1, Optional ByVal status As Boolean = 1)
        DataProvider.Instance().CMS_Contact_Update_Status(PortalConnect, id, status)
    End Sub
    Public Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PortalId As Integer, Status As Integer, PageSize As Integer, PageIndex As Integer, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Contact_List_Search(PortalConnect, Search, PortalId, Status, PageSize, PageIndex, fromDate, toDate), GetType(CMS_ContactInfo))
    End Function
    Public Function CMS_Contact_Add(PortalConnect As String, obj As CMS_ContactInfo) As Integer
        Return DataProvider.Instance().CMS_Contact_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Contact_Update(PortalConnect As String, obj As CMS_ContactInfo)
        DataProvider.Instance().CMS_Contact_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Contact_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Contact_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_Departments"
    Public Function CMS_Departments_GetByParentId(PortalConnect As String, PortalId As Integer, ParentId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Departments_GetByParentId(PortalConnect, PortalId, ParentId), GetType(CMS_DepartmentsInfo))
    End Function
    Public Function CMS_Departments_NguoiDung_Get_By_UserId(PortalConnect As String, UserId As String, PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Departments_NguoiDung_Get_By_UserId(PortalConnect, UserId, PortalId), GetType(CMS_Departments_NguoiDungInfo))
    End Function
    Public Function CMS_Departments_Get(PortalConnect As String, id As Integer) As CMS_DepartmentsInfo
        Return CBO.FillObject(Of CMS_DepartmentsInfo)(DataProvider.Instance().CMS_Departments_Get(PortalConnect, id))
    End Function
    Public Function CMS_Departments_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Departments_List(PortalConnect), GetType(CMS_DepartmentsInfo))
    End Function
    Public Function CMS_Departments_NguoiDung_GetByNguoiDung(PortalConnect As String, Nguoidung As String, PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Departments_NguoiDung_GetByNguoiDung(PortalConnect, Nguoidung, PortalId), GetType(CMS_DepartmentsInfo))
    End Function
    Public Function CMS_Departments_NguoiDung_Get_ChucVu(PortalConnect As String, UserId As String, chucVu As String) As String
        Return DataProvider.Instance.CMS_Departments_NguoiDung_Get_ChucVu(PortalConnect, UserId, chucVu)
    End Function
    Public Function CMS_Departments_Add(PortalConnect As String, obj As CMS_DepartmentsInfo) As Integer
        Return DataProvider.Instance().CMS_Departments_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Departments_Update(PortalConnect As String, obj As CMS_DepartmentsInfo)
        DataProvider.Instance().CMS_Departments_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Departments_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Departments_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_Departments_ChucVu"
    Public Function CMS_Departments_ChucVu_Get(PortalConnect As String, id As Integer) As CMS_Departments_ChucVuInfo
        Return CBO.FillObject(Of CMS_Departments_ChucVuInfo)(DataProvider.Instance().CMS_Departments_ChucVu_Get(PortalConnect, id))
    End Function
    Public Function CMS_Departments_ChucVu_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Departments_ChucVu_List(PortalConnect), GetType(CMS_Departments_ChucVuInfo))
    End Function

    Public Function CMS_Departments_ChucVu_Add(PortalConnect As String, obj As CMS_Departments_ChucVuInfo) As Integer
        Return DataProvider.Instance().CMS_Departments_ChucVu_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Departments_ChucVu_Update(PortalConnect As String, obj As CMS_Departments_ChucVuInfo)
        DataProvider.Instance().CMS_Departments_ChucVu_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Departments_ChucVu_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Departments_ChucVu_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_Departments_NguoiDung"
    Public Function CMS_Departments_NguoiDung_Get(PortalConnect As String, id As Integer) As CMS_Departments_NguoiDungInfo
        Return CBO.FillObject(Of CMS_Departments_NguoiDungInfo)(DataProvider.Instance().CMS_Departments_NguoiDung_Get(PortalConnect, id))
    End Function
    Public Function CMS_Departments_NguoiDung_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Departments_NguoiDung_List(PortalConnect, portalId), GetType(CMS_Departments_NguoiDungInfo))
    End Function
    Public Function CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(PortalConnect As String, U_Id As String, DepartmentId As Integer, PortalId As Integer) As CMS_Departments_NguoiDungInfo
        Return CBO.FillObject(Of CMS_Departments_NguoiDungInfo)(DataProvider.Instance().CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(PortalConnect, U_Id, DepartmentId, PortalId))
    End Function
    Public Function CMS_Departments_NguoiDung_List_UserID(PortalConnect As String, UserId As String, PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Departments_NguoiDung_List_UserID(PortalConnect, UserId, PortalId), GetType(CMS_Departments_NguoiDungInfo))
    End Function
    Public Function CMS_Departments_NguoiDung_Add(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo) As Integer
        Return DataProvider.Instance().CMS_Departments_NguoiDung_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Departments_NguoiDung_Update(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo)
        DataProvider.Instance().CMS_Departments_NguoiDung_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Departments_NguoiDung_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Departments_NguoiDung_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_DMNhuanBut"
    Public Function CMS_DMNhuanBut_List_Search(PortalConnect As String, search As String, isOrder As Integer, Months As Integer, Years As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DMNhuanBut_List_Search(PortalConnect, search, isOrder, Months, Years), GetType(CMS_DMNhuanButInfo))
    End Function
    Public Function CMS_DMNhuanBut_Get(PortalConnect As String, iD As Integer) As CMS_DMNhuanButInfo
        Return CBO.FillObject(Of CMS_DMNhuanButInfo)(DataProvider.Instance().CMS_DMNhuanBut_Get(PortalConnect, iD))
    End Function
    Public Function CMS_DMNhuanBut_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DMNhuanBut_List(PortalConnect), GetType(CMS_DMNhuanButInfo))
    End Function
    Public Function CMS_DMNhuanBut_Get_By_Type(PortalConnect As String, Type As Integer, Month As Integer, Year As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DMNhuanBut_Get_By_Type(PortalConnect, Type, Month, Year), GetType(CMS_DMNhuanButInfo))
    End Function
    Public Function CMS_DMNhuanBut_Add(PortalConnect As String, obj As CMS_DMNhuanButInfo) As Integer
        Return DataProvider.Instance().CMS_DMNhuanBut_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DMNhuanBut_Update(PortalConnect As String, obj As CMS_DMNhuanButInfo)
        DataProvider.Instance().CMS_DMNhuanBut_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DMNhuanBut_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_DMNhuanBut_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_FAQ"
    Public Function CMS_FAQ_Get(PortalConnect As String, id As String) As CMS_FAQInfo
        Return CBO.FillObject(Of CMS_FAQInfo)(DataProvider.Instance().CMS_FAQ_Get(PortalConnect, id))
    End Function
    Public Function CMS_FAQ_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FAQ_List(PortalConnect, portalId), GetType(CMS_FAQInfo))
    End Function

    Public Function CMS_FAQ_Add(PortalConnect As String, obj As CMS_FAQInfo) As Integer
        Return DataProvider.Instance().CMS_FAQ_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_FAQ_Update(PortalConnect As String, obj As CMS_FAQInfo)
        DataProvider.Instance().CMS_FAQ_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FAQ_Delete(PortalConnect As String, id As String)
        DataProvider.Instance().CMS_FAQ_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_FAQAnswers"
    Public Function CMS_FAQAnswers_Get(PortalConnect As String, id As String) As CMS_FAQAnswersInfo
        Return CBO.FillObject(Of CMS_FAQAnswersInfo)(DataProvider.Instance().CMS_FAQAnswers_Get(PortalConnect, id))
    End Function
    Public Function CMS_FAQAnswers_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FAQAnswers_List(PortalConnect, portalId), GetType(CMS_FAQAnswersInfo))
    End Function

    Public Function CMS_FAQAnswers_Add(PortalConnect As String, obj As CMS_FAQAnswersInfo) As Integer
        Return DataProvider.Instance().CMS_FAQAnswers_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_FAQAnswers_Update(PortalConnect As String, obj As CMS_FAQAnswersInfo)
        DataProvider.Instance().CMS_FAQAnswers_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FAQAnswers_Delete(PortalConnect As String, id As String)
        DataProvider.Instance().CMS_FAQAnswers_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_FAQQuestions"
    Public Function CMS_FAQQuestions_Get(PortalConnect As String, id As String) As CMS_FAQQuestionsInfo
        Return CBO.FillObject(Of CMS_FAQQuestionsInfo)(DataProvider.Instance().CMS_FAQQuestions_Get(PortalConnect, id))
    End Function
    Public Function CMS_FAQQuestions_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FAQQuestions_List(PortalConnect, portalId), GetType(CMS_FAQQuestionsInfo))
    End Function
    Public Function CMS_FAQQuestions_List_Search(PortalConnect As String, search As String, fAQID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FAQQuestions_List_Search(PortalConnect, search, fAQID, isOrder, currPage, recodperpage, UserName, Status), GetType(CMS_FAQQuestionsInfo))
    End Function
    Public Function CMS_FAQQuestions_Add(PortalConnect As String, obj As CMS_FAQQuestionsInfo) As Integer
        Return DataProvider.Instance().CMS_FAQQuestions_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_FAQQuestions_Update(PortalConnect As String, obj As CMS_FAQQuestionsInfo)
        DataProvider.Instance().CMS_FAQQuestions_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FAQQuestions_Update_Answer(PortalConnect As String, Id As Integer, ContentAnswer As String, AnswerName As String, AnswerUser As String, AnswerDate As DateTime)
        DataProvider.Instance().CMS_FAQQuestions_Update_Answer(PortalConnect, Id, ContentAnswer, AnswerName, AnswerUser, AnswerDate)
    End Sub
    Public Sub CMS_FAQQuestions_Update_Status(PortalConnect As String, Id As Integer, Status As Integer)
        DataProvider.Instance().CMS_FAQQuestions_Update_Status(PortalConnect, Id, Status)
    End Sub
    Public Sub CMS_FAQQuestions_Delete(PortalConnect As String, id As String)
        DataProvider.Instance().CMS_FAQQuestions_Delete(PortalConnect, id)
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
#Region "CMS_Media"
    Public Function CMS_Media_List_Home(PortalConnect As Integer, PortalId As Integer, LanguageId As String, Id As String, type As Integer, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_List_Home(PortalConnect, PortalId, LanguageId, Id, type, PageIndex, PageSize), GetType(CMS_MediaInfo))
    End Function
    Public Function CMS_Media_Search_Home(PortalConnect As Integer, PortalId As Integer, LanguageId As String, datefrom As Date, dateto As Date, key As String, categoryid As Integer, PageIndex As Integer, PageSize As Integer, arrPhongBan As String, uid As Integer, isImage As Boolean, type As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_Search_Home(PortalConnect, PortalId, LanguageId, datefrom, dateto, key, categoryid, PageIndex, PageSize, arrPhongBan, uid, isImage, type), GetType(CMS_MediaInfo))
    End Function
    Public Function CMS_Media_List_Select(PortalConnect As String, datefrom As Date, dateto As Date, title As String, danhmuc As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, Type As Integer, Settings As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_List_Select(PortalConnect, datefrom, dateto, title, danhmuc, PortalId, PageIndex, PageSize, Type, Settings), GetType(CMS_MediaInfo))
    End Function
    Public Sub CMS_Media_Delete_Update(PortalConnect As String, IsDelete As Boolean, DeleteDate As Date, DeleteUser As String, Id As Integer)
        DataProvider.Instance().CMS_Media_Delete_Update(PortalConnect, IsDelete, DeleteDate, DeleteUser, Id)
    End Sub
    Public Function CMS_Media_List_Search(PortalConnect As String, Status As Integer, UserName As String, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_List_Search(PortalConnect, Status, UserName, PortalID, IsLang, categoryid, title, PageIndex, PageSize, Type, Flag, FromDate, ToDate), GetType(CMS_MediaInfo))
    End Function
    Public Function CMS_Media_Admin_Search_Count(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As CMS_TongHopInfo
        Return CBO.FillObject(Of CMS_TongHopInfo)(DataProvider.Instance().CMS_Media_Admin_Search_Count(PortalConnect, title, danhmuc, PortalId, UserName, Type, Flag, FromDate, ToDate))
    End Function
    Public Function CMS_Media_Admin_Search(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, trangthai As Integer, PageIndex As Integer, PageSize As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_Admin_Search(PortalConnect, title, danhmuc, PortalId, trangthai, PageIndex, PageSize, UserName, Type, Flag, FromDate, ToDate), GetType(CMS_MediaInfo))
    End Function
    Public Sub CMS_Media_Guiduyet(PortalConnect As String, id As String, Trangthai As Integer, UserId As String, DateUpdate As DateTime)
        DataProvider.Instance.CMS_Media_GuiDuyet(PortalConnect, id, Trangthai, UserId, DateUpdate)
    End Sub
    Public Sub CMS_Media_Duyet(PortalConnect As String, id As Integer, Trangthai As Integer, DateUpdate As DateTime, UserAprrove As String)
        DataProvider.Instance.CMS_Media_Duyet(PortalConnect, id, Trangthai, DateUpdate, UserAprrove)
    End Sub
    Public Function CMS_Media_Get(PortalConnect As String, id As Integer) As CMS_MediaInfo
        Return CBO.FillObject(Of CMS_MediaInfo)(DataProvider.Instance().CMS_Media_Get(PortalConnect, id))
    End Function
    Public Function CMS_Media_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Media_List(PortalConnect, portalId), GetType(CMS_MediaInfo))
    End Function
    Public Function CMS_Media_Get_By_News_ID(PortalConnect As String, newsid As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Media_Get_By_News_ID(PortalConnect, newsid), GetType(CMS_MediaInfo))
    End Function
    Public Function CMS_Media_Add(PortalConnect As String, obj As CMS_MediaInfo) As Integer
        Return DataProvider.Instance().CMS_Media_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Media_Update(PortalConnect As String, obj As CMS_MediaInfo)
        DataProvider.Instance().CMS_Media_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Media_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Media_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_News"
    Public Function CMS_News_List_ToApp(PortalConnect As String, PortalID As Integer, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, isImages As Boolean, WBID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_List_ToApp(PortalConnect, PortalID, categoryid, title, PageIndex, PageSize, Flag, fromDate, toDate, isImages, WBID), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_MostView(PortalConnect As Integer, PortalId As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_List_MostView(PortalConnect, PortalId, top), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_Search_Home(PortalConnect As Integer, PortalId As Integer, tags As String, datefrom As Date, dateto As Date, categoryid As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean, key As String, advanced As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_Search_Home(PortalConnect, PortalId, tags, datefrom, dateto, categoryid, PageIndex, PageSize, isImage, key, advanced), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_Search_HomeMobile(PortalConnect As Integer, PortalId As Integer, categoryid As Integer, PageIndex As Integer, PageSize As Integer, key As String, status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_Search_HomeMobile(PortalConnect, PortalId, categoryid, PageIndex, PageSize, key, status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_HomeBlock(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_HomeBlock(PortalConnect, PortalId, IsFlag, NewId, CategoryId, Top, IsImage), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_HomeMobile(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_HomeMobile(PortalConnect, PortalId, IsFlag, NewId, CategoryId, Top, IsImage), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_SameCate(PortalConnect As String, PortalId As Integer, newid As Integer, catid As Integer, count As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_SameCate(PortalConnect, PortalId, newid, catid, count), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_Notification(PortalID As Integer, IsLang As String, Table As String, Status As Integer, isStep As Boolean, WfID As Integer, WF_RETURN As Integer, UserName As String, cateAll As Boolean) As Integer
        Return DataProvider.Instance().CMS_Notification(PortalID, IsLang, Table, Status, isStep, WfID, WF_RETURN, UserName, cateAll)
    End Function
    Public Function CMS_News_List_UserName(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_List_UserName(PortalConnect), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_GetLink(PortalConnect As String, datefrom As DateTime, dateto As DateTime, title As String, categoryid As Integer, PortalId As Integer, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_List_GetLink(PortalConnect, datefrom, dateto, title, categoryid, PortalId, Status, UserName, PageIndex, PageSize), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_News_Update_Tags_Media(PortalConnect As String, NewID As Integer, Tags As String)
        DataProvider.Instance.CMS_News_Update_Tags_Media(PortalConnect, NewID, Tags)
    End Sub
    Public Function CMS_News_ListAdmin_Count(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, UserName As String, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As CMS_TongHopInfo
        Return CBO.FillObject(Of CMS_TongHopInfo)(DataProvider.Instance().CMS_News_ListAdmin_Count(PortalConnect, title, categoryid, PortalId, LanguageId, UserName, isImage, IsActive, Flag, fromDate, toDate))
    End Function
    Public Function CMS_News_ListAdmin_Progress(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, status As Integer, UserId As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, ToUrl As String, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_ListAdmin_Progress(PortalConnect, title, categoryid, PortalId, LanguageId, status, UserId, PageIndex, PageSize, isImage, IsActive, Flag, ToUrl, fromDate, toDate), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_ListAdmin_Search(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_ListAdmin_Search(PortalConnect, title, categoryid, PortalId, LanguageId, Status, UserName, PageIndex, PageSize, isImage, IsActive, Flag, fromDate, toDate), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_News_Update_Visible(PortalConnect As String, NewId As Integer, IsVisible As Boolean)
        DataProvider.Instance.CMS_News_Update_Visible(PortalConnect, NewId, IsVisible)
    End Sub
    Public Sub CMS_News_Update_IsMobile(PortalConnect As String, NewId As Integer, IsMobile As Boolean)
        DataProvider.Instance.CMS_News_Update_IsMobile(PortalConnect, NewId, IsMobile)
    End Sub
    Public Sub CMS_News_Update_Tags(PortalConnect As String, NewID As Integer, Tags As String)
        DataProvider.Instance.CMS_News_Update_Tags(PortalConnect, NewID, Tags)
    End Sub
    Public Function CMS_BackWF_News(PortalConnect As String, NewsID As Integer) As CMS_News_UserProcessInfo
        Return CBO.FillObject(Of CMS_News_UserProcessInfo)(DataProvider.Instance().CMS_BackWF_News(PortalConnect, NewsID))
    End Function
    Public Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_SiteMap_News(PortalConnect, PortalID, IsLang, top), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_Update_View(PortalConnect As String, IdKey As String, ID As Integer)
        DataProvider.Instance.CMS_Update_View(PortalConnect, IdKey, ID)
    End Sub
    Public Function CMS_News_GetLocks(PortalConnect As String, PortalId As Integer, LanguageId As String, Search As String, Optional ByVal newsid As Integer = 0) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_GetLocks(PortalConnect, PortalId, LanguageId, Search, newsid), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_Get(PortalConnect As String, newId As Integer) As CMS_NewsInfo
        Return CBO.FillObject(Of CMS_NewsInfo)(DataProvider.Instance().CMS_News_Get(PortalConnect, newId))
    End Function
    Public Function CMS_News_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List(PortalConnect, portalId), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_News_Update_Status(PortalConnect As String, newid As Integer, Status As Integer, UserId As String, publisedDate As DateTime)
        DataProvider.Instance().CMS_News_Update_Status(PortalConnect, newid, Status, UserId, publisedDate)
    End Sub
    Public Function CMS_News_List_Search(PortalConnect As String, Status As Integer, WfID As Integer, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, UserName As String, isStep As Boolean, isImages As Boolean, WF_RETURN As Integer, cateAll As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search(PortalConnect, Status, WfID, PortalID, IsLang, categoryid, title, PageIndex, PageSize, Flag, fromDate, toDate, UserName, isStep, isImages, WF_RETURN, cateAll), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Search_All(PortalConnect As String, Search As String, categoryid As Integer, PortalID As Integer, PageIndex As Integer, PageSize As Integer, isImages As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search_All(PortalConnect, Search, categoryid, PortalID, PageIndex, PageSize, isImages), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Home(PortalConnect, NewsID, CategoryId, PortalId, PageIndex, PageSize, isImage), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_News_Update_Lock(PortalConnect As String, NewId As Integer, lock As Boolean, UserId As String)
        DataProvider.Instance().CMS_News_Update_Lock(PortalConnect, NewId, lock, UserId)
    End Sub
    Public Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
        Return DataProvider.Instance().CMS_News_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
        DataProvider.Instance().CMS_News_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_Delete(PortalConnect As String, newId As Integer)
        DataProvider.Instance().CMS_News_Delete(PortalConnect, newId)
    End Sub
#End Region
#Region "CMS_News_NB"
    Public Function CMS_News_NB_Get(PortalConnect As String, iD As Integer) As CMS_News_NBInfo
        Return CBO.FillObject(Of CMS_News_NBInfo)(DataProvider.Instance().CMS_News_NB_Get(PortalConnect, iD))
    End Function
    Public Function CMS_News_NB_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_NB_List(PortalConnect), GetType(CMS_News_NBInfo))
    End Function
    Public Function CMS_News_NB_Get_By_NewsID(PortalConnect As String, newsID As Integer, Type As Integer) As CMS_News_NBInfo
        Return CBO.FillObject(Of CMS_News_NBInfo)(DataProvider.Instance().CMS_News_NB_Get_By_NewsID(PortalConnect, newsID, Type))
    End Function
    Public Function CMS_News_NB_Add(PortalConnect As String, obj As CMS_News_NBInfo) As Integer
        Return DataProvider.Instance().CMS_News_NB_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_NB_Update(PortalConnect As String, obj As CMS_News_NBInfo)
        DataProvider.Instance().CMS_News_NB_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_NB_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_News_NB_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_News_NBDetail"
    Public Function CMS_News_NBDetail_Get(PortalConnect As String, detail_ID As Integer) As CMS_News_NBDetailInfo
        Return CBO.FillObject(Of CMS_News_NBDetailInfo)(DataProvider.Instance().CMS_News_NBDetail_Get(PortalConnect, detail_ID))
    End Function
    Public Function CMS_News_NBDetail_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_NBDetail_List(PortalConnect), GetType(CMS_News_NBDetailInfo))
    End Function
    Public Function CMS_News_NBDetail_Get_By_CMS_News_NB(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_NBDetail_Get_By_CMS_News_NB(PortalConnect, iD), GetType(CMS_News_NBDetailInfo))
    End Function
    Public Function CMS_News_NBDetail_Get_By_NB_DM_ID(PortalConnect As String, NB_ID As Integer, DM_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_NBDetail_Get_By_NB_DM_ID(PortalConnect, NB_ID, DM_ID), GetType(CMS_News_NBDetailInfo))
    End Function
    Public Function CMS_News_NBDetail_List_By_NewsNBID(PortalConnect As String, NewsNB_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_NBDetail_List_By_NewsNBID(PortalConnect, NewsNB_ID), GetType(CMS_News_NBDetailInfo))
    End Function
    Public Function CMS_News_NBDetail_Add(PortalConnect As String, obj As CMS_News_NBDetailInfo) As Integer
        Return DataProvider.Instance().CMS_News_NBDetail_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_NBDetail_Update(PortalConnect As String, obj As CMS_News_NBDetailInfo)
        DataProvider.Instance().CMS_News_NBDetail_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_NBDetail_Delete(PortalConnect As String, detail_ID As Integer)
        DataProvider.Instance().CMS_News_NBDetail_Delete(PortalConnect, detail_ID)
    End Sub
#End Region
#Region "CMS_News_Process"
    Public Function CMS_News_Process_Get(PortalConnect As String, iD As Integer) As CMS_News_ProcessInfo
        Return CBO.FillObject(Of CMS_News_ProcessInfo)(DataProvider.Instance().CMS_News_Process_Get(PortalConnect, iD))
    End Function
    Public Function CMS_News_Process_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_Process_List(PortalConnect), GetType(CMS_News_ProcessInfo))
    End Function
    Public Function CMS_News_Process_GetByNewsId(PortalConnect As String, itemid As Integer, Type As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_Process_GetByNewsId(PortalConnect, itemid, Type), GetType(CMS_News_ProcessInfo))
    End Function
    Public Function CMS_News_Process_Add(PortalConnect As String, obj As CMS_News_ProcessInfo) As Integer
        Return DataProvider.Instance().CMS_News_Process_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_Process_Update(PortalConnect As String, obj As CMS_News_ProcessInfo)
        DataProvider.Instance().CMS_News_Process_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_Process_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_News_Process_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_News_UserProcess"
    Public Function CMS_News_UserProcess_Get(PortalConnect As String, iD As Integer) As CMS_News_UserProcessInfo
        Return CBO.FillObject(Of CMS_News_UserProcessInfo)(DataProvider.Instance().CMS_News_UserProcess_Get(PortalConnect, iD))
    End Function
    Public Function CMS_News_UserProcess_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_UserProcess_List(PortalConnect), GetType(CMS_News_UserProcessInfo))
    End Function
    Public Sub CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(PortalConnect As String, NewsID As Integer, UserId As String, Optional ByVal isActive As Boolean = 1)
        DataProvider.Instance.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(PortalConnect, NewsID, UserId, isActive)
    End Sub
    Public Function CMS_News_UserProcess_Add(PortalConnect As String, obj As CMS_News_UserProcessInfo) As Integer
        Return DataProvider.Instance().CMS_News_UserProcess_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_UserProcess_Update(PortalConnect As String, obj As CMS_News_UserProcessInfo)
        DataProvider.Instance().CMS_News_UserProcess_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_UserProcess_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_News_UserProcess_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_News_UserWF"
    Public Function CMS_News_UserWF_Get(PortalConnect As String, iD As Integer) As CMS_News_UserWFInfo
        Return CBO.FillObject(Of CMS_News_UserWFInfo)(DataProvider.Instance().CMS_News_UserWF_Get(PortalConnect, iD))
    End Function
    Public Function CMS_News_UserWF_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_UserWF_List(PortalConnect), GetType(CMS_News_UserWFInfo))
    End Function
    Public Function CMS_News_UserWF_GetByPhongBanId(PortalConnect As String, LoaiWF As LoaiWF, phongbanID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_UserWF_GetByPhongBanId(PortalConnect, LoaiWF, phongbanID), GetType(CMS_News_UserWFInfo))
    End Function
    Public Function CMS_News_UserWF_Add(PortalConnect As String, obj As CMS_News_UserWFInfo) As Integer
        Return DataProvider.Instance().CMS_News_UserWF_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_UserWF_Update(PortalConnect As String, obj As CMS_News_UserWFInfo)
        DataProvider.Instance().CMS_News_UserWF_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_UserWF_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_News_UserWF_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_News_Version"
    Public Function CMS_News_Version_Get(PortalConnect As String, id As Integer) As CMS_News_VersionInfo
        Return CBO.FillObject(Of CMS_News_VersionInfo)(DataProvider.Instance().CMS_News_Version_Get(PortalConnect, id))
    End Function
    Public Function CMS_News_Version_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_Version_List(PortalConnect, portalId), GetType(CMS_News_VersionInfo))
    End Function
    Public Function CMS_News_CheckChange_Get_NewsID(PortalConnect As String, NewID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_News_CheckChange_Get_NewsID(PortalConnect, NewID), GetType(CMS_News_ProcessInfo))
    End Function
    Public Function CMS_News_Version_Add(PortalConnect As String, obj As CMS_News_VersionInfo) As Integer
        Return DataProvider.Instance().CMS_News_Version_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_Version_Update(PortalConnect As String, obj As CMS_News_VersionInfo)
        DataProvider.Instance().CMS_News_Version_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_Version_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_News_Version_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_NewsByCategory"
    Public Sub CMS_NewsByCategory_Delete_By_NewsID(PortalConnect As String, NewsId As Integer)
        DataProvider.Instance().CMS_NewsByCategory_Delete_By_NewsID(PortalConnect, NewsId)
    End Sub
    Public Function CMS_NewsByCategory_GetByNewsId(PortalConnect As String, PortalID As Integer, LanguageId As String, newsid As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsByCategory_GetByNewsId(PortalConnect, PortalID, LanguageId, newsid), GetType(CMS_NewsByCategoryInfo))
    End Function
    Public Function CMS_NewsByCategory_Get(PortalConnect As String, id As Long) As CMS_NewsByCategoryInfo
        Return CBO.FillObject(Of CMS_NewsByCategoryInfo)(DataProvider.Instance().CMS_NewsByCategory_Get(PortalConnect, id))
    End Function
    Public Function CMS_NewsByCategory_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsByCategory_List(PortalConnect, portalId), GetType(CMS_NewsByCategoryInfo))
    End Function

    Public Function CMS_NewsByCategory_Add(PortalConnect As String, NewsId As Integer, CategoryId As Integer, IsMainCategory As Boolean, NewsStatusId As Integer, portalId As Integer, LanguageId As String, isHotCate As Boolean) As Integer
        Return DataProvider.Instance().CMS_NewsByCategory_Add(PortalConnect, NewsId, CategoryId, IsMainCategory, NewsStatusId, portalId, LanguageId, isHotCate)
    End Function
    Public Sub CMS_NewsByCategory_Update(PortalConnect As String, obj As CMS_NewsByCategoryInfo)
        DataProvider.Instance().CMS_NewsByCategory_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsByCategory_Delete(PortalConnect As String, id As Long)
        DataProvider.Instance().CMS_NewsByCategory_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_NewsByMedia"
    Public Sub CMS_NewsByMedia_Delete_By_MediaID(PortalConnect As String, MediaID As Integer)
        DataProvider.Instance.CMS_NewsByMedia_Delete_By_MediaID(PortalConnect, MediaID)
    End Sub
    Public Sub CMS_NewsByMedia_DeleteByNewsId(PortalConnect As String, NewsId As Integer)
        DataProvider.Instance.CMS_NewsByMedia_DeleteByNewsId(PortalConnect, NewsId)
    End Sub
    Public Function CMS_NewsByMedia_Get(PortalConnect As String, id As Integer) As CMS_NewsByMediaInfo
        Return CBO.FillObject(Of CMS_NewsByMediaInfo)(DataProvider.Instance().CMS_NewsByMedia_Get(PortalConnect, id))
    End Function
    Public Function CMS_NewsByMedia_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsByMedia_List(PortalConnect), GetType(CMS_NewsByMediaInfo))
    End Function
    Public Function CMS_NewsByMedia_GetByNewsId(PortalConnect As String, NewsId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsByMedia_GetByNewsId(PortalConnect, NewsId), GetType(CMS_NewsByMediaInfo))
    End Function
    Public Function CMS_NewsByMedia_Add(PortalConnect As String, obj As CMS_NewsByMediaInfo) As Integer
        Return DataProvider.Instance().CMS_NewsByMedia_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsByMedia_Update(PortalConnect As String, obj As CMS_NewsByMediaInfo)
        DataProvider.Instance().CMS_NewsByMedia_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsByMedia_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_NewsByMedia_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_NewsByTags"
    Public Function CMS_NewsByTags_Get(PortalConnect As String, id As Long) As CMS_NewsByTagsInfo
        Return CBO.FillObject(Of CMS_NewsByTagsInfo)(DataProvider.Instance().CMS_NewsByTags_Get(PortalConnect, id))
    End Function
    Public Function CMS_NewsByTags_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsByTags_List(PortalConnect), GetType(CMS_NewsByTagsInfo))
    End Function
    Public Function CMS_NewsByTags_Get_By_NewsID(PortalConnect As Integer, NewsID As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsByTags_Get_By_NewsID(PortalConnect, NewsID, top), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_NewsByTags_Add(PortalConnect As String, newsId As Integer, tagName As String) As Integer
        Return DataProvider.Instance().CMS_NewsByTags_Add(PortalConnect, newsId, tagName, Now, Now)
    End Function
    Public Sub CMS_NewsByTags_Update(PortalConnect As String, obj As CMS_NewsByTagsInfo)
        DataProvider.Instance().CMS_NewsByTags_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsByTags_Delete(PortalConnect As String, id As Long)
        DataProvider.Instance().CMS_NewsByTags_Delete(PortalConnect, id)
    End Sub
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
#Region "CMS_NewsCategoriesPermission"
    Public Function CMS_NewsCategoriesPermission_Get(PortalConnect As String, id As Long) As CMS_NewsCategoriesPermissionInfo
        Return CBO.FillObject(Of CMS_NewsCategoriesPermissionInfo)(DataProvider.Instance().CMS_NewsCategoriesPermission_Get(PortalConnect, id))
    End Function
    Public Function CMS_NewsCategoriesPermission_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsCategoriesPermission_List(PortalConnect), GetType(CMS_NewsCategoriesPermissionInfo))
    End Function
    Public Sub CMS_NewsCategoriesPermission_Delete_Category(PortalConnect As String, userId As String, categoryId As Integer)
        DataProvider.Instance().CMS_NewsCategoriesPermission_Delete_Category(PortalConnect, userId, categoryId)
    End Sub
    Public Function CMS_NewsCategoriesPermission_Add(PortalConnect As String, userId As String, categoryId As Integer, permissionType As Integer) As Integer
        Return DataProvider.Instance().CMS_NewsCategoriesPermission_Add(PortalConnect, userId, categoryId, permissionType)
    End Function
    Public Sub CMS_NewsCategoriesPermission_Update(PortalConnect As String, obj As CMS_NewsCategoriesPermissionInfo)
        DataProvider.Instance().CMS_NewsCategoriesPermission_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsCategoriesPermission_Delete(PortalConnect As String, id As Long)
        DataProvider.Instance().CMS_NewsCategoriesPermission_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_NewsFeedback"
    Public Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, NewsId As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsFeedback_List_By_NewsID(PortalConnect, NewsId, Status, type, PortalId, LanguageId, PageIndex, PageSize), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As CMS_NewsFeedbackInfo
        Return CBO.FillObject(Of CMS_NewsFeedbackInfo)(DataProvider.Instance().CMS_NewsFeedback_Get(PortalConnect, newsFeedbackId))
    End Function
    Public Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedback_List(PortalConnect, portalId), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
        DataProvider.Instance().CMS_NewsFeedback_Update_Status(PortalConnect, newsFeedbackId, status)
    End Sub
    Public Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, idFeed As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedback_Get_By_FBID(PortalConnect, idFeed), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_List_Search(PortalConnect As String, NewsId As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsFeedback_List_Search(PortalConnect, NewsId, Status, type, PortalId, LanguageId, PageIndex, PageSize), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
        Return DataProvider.Instance().CMS_NewsFeedback_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
        DataProvider.Instance().CMS_NewsFeedback_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
        DataProvider.Instance().CMS_NewsFeedback_Delete(PortalConnect, newsFeedbackId)
    End Sub
#End Region
#Region "CMS_NewsFeedBack_History"
    Public Function CMS_NewsFeedBack_History_Get(PortalConnect As String, iD As Integer) As CMS_NewsFeedBack_HistoryInfo
        Return CBO.FillObject(Of CMS_NewsFeedBack_HistoryInfo)(DataProvider.Instance().CMS_NewsFeedBack_History_Get(PortalConnect, iD))
    End Function
    Public Function CMS_NewsFeedBack_History_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedBack_History_List(PortalConnect), GetType(CMS_NewsFeedBack_HistoryInfo))
    End Function
    Public Function CMS_NewsFeedBack_History_Get_By_CMS_NewsFeedback(PortalConnect As String, newsFeedbackId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedBack_History_Get_By_CMS_NewsFeedback(PortalConnect, newsFeedbackId), GetType(CMS_NewsFeedBack_HistoryInfo))
    End Function
    Public Function CMS_NewsFeedBack_History_Get_By_NewsFeedback(ByVal PortalConnect As String, newsFeedbackId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedBack_History_Get_By_NewsFeedback(PortalConnect, newsFeedbackId), GetType(CMS_NewsFeedBack_HistoryInfo))
    End Function
    Public Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
        Return DataProvider.Instance().CMS_NewsFeedBack_History_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsFeedBack_History_Update(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo)
        DataProvider.Instance().CMS_NewsFeedBack_History_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsFeedBack_History_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_NewsFeedBack_History_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_NewsStatus"
    Public Function CMS_NewsStatus_Get(PortalConnect As String, newsStatusId As Integer) As CMS_NewsStatusInfo
        Return CBO.FillObject(Of CMS_NewsStatusInfo)(DataProvider.Instance().CMS_NewsStatus_Get(PortalConnect, newsStatusId))
    End Function
    Public Function CMS_NewsStatus_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsStatus_List(PortalConnect), GetType(CMS_NewsStatusInfo))
    End Function

    Public Function CMS_NewsStatus_Add(PortalConnect As String, obj As CMS_NewsStatusInfo) As Integer
        Return DataProvider.Instance().CMS_NewsStatus_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsStatus_Update(PortalConnect As String, obj As CMS_NewsStatusInfo)
        DataProvider.Instance().CMS_NewsStatus_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsStatus_Delete(PortalConnect As String, newsStatusId As Integer)
        DataProvider.Instance().CMS_NewsStatus_Delete(PortalConnect, newsStatusId)
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
#Region "SQL_Service_Add"
    Public Sub SV_CMS_WebLink_Add(PortalConnect As String, objWebLink As CMS_WebLinkInfo)
        DataProvider.Instance().SV_CMS_WebLink_Add(PortalConnect, objWebLink.Id, objWebLink.Name, objWebLink.OrderNo, objWebLink.Url, objWebLink.Image, objWebLink.Description, objWebLink.PortalId, objWebLink.LanguageId, objWebLink.ViewType, objWebLink.UserName, objWebLink.Createdate)
    End Sub
    Public Sub SV_CMS_NewsCategories_Add(PortalConnect As String, objInfo As CMS_NewsCategoriesInfo)
        DataProvider.Instance().SV_CMS_NewsCategories_Add(PortalConnect, objInfo.CategoryID, objInfo.CategoryName, objInfo.Description, objInfo.TabID, objInfo.IsActive, objInfo.CreateDate, objInfo.PortalId, objInfo.LanguageId, objInfo.ParentId, objInfo.OrderNumber, objInfo.Type, objInfo.TabPath, objInfo.TabMobileID)
    End Sub
    Public Sub SV_CMS_Document_Add(ByVal PortalConnect As String, obj As CMS_DocumentInfo)
        DataProvider.Instance().SV_CMS_Document_Add(PortalConnect, obj.Document_ID, obj.Document_Name, obj.DocType_ID, obj.DocUnit_ID, obj.DocField_ID, obj.Contents, obj.NoCode, obj.SignerName, obj.PromDate, obj.EffectDate, obj.EndDate, obj.FileName, obj.FileSource, obj.IsURL, obj.IsDownload, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UpdateName, obj.PortalID)
    End Sub
    Public Sub SV_CMS_MenuD_Add(ByVal PortalConnect As String, obj As CMS_MenuDInfo)
        DataProvider.Instance().SV_CMS_MenuD_Add(PortalConnect, obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Function SV_CMS_ListError(PortalConnect As String, Type As Integer) As ArrayList
        Select Case Type
            Case ServiceType.Album
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_NewsInfo))
            Case ServiceType.Media
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_MediaInfo))
            Case ServiceType.Advertise
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_AdvertiseInfo))
            Case ServiceType.FAQ
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_FAQInfo))
            Case ServiceType.FAQQuestion
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_FAQQuestionsInfo))
            Case ServiceType.FAQAnswers
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_FAQAnswersInfo))
            Case ServiceType.Infomation
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_InfomationInfo))
            Case ServiceType.NewsCategories
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_NewsCategoriesInfo))
            Case ServiceType.WebLink
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_WebLinkInfo))
            Case ServiceType.Document
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_DocumentInfo))
            Case ServiceType.Menu
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_MenuDInfo))
            Case ServiceType.Feedback
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_NewsFeedbackInfo))
            Case ServiceType.ConfigSystem
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_ConfigSystemInfo))
            Case ServiceType.Setup
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, Type), GetType(CMS_SetupsInfo))
            Case Else
                Return CBO.FillCollection(DataProvider.Instance().SV_CMS_ListError(PortalConnect, 1), GetType(CMS_NewsInfo))
        End Select
    End Function
    Public Sub SV_CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo)
        DataProvider.Instance().SV_CMS_News_Add(PortalConnect, obj.NewId, obj.CategoryId, obj.Introduction, obj.Title, obj.ImagePath, obj.Summary, obj.Content, obj.isActive, obj.Hotcat, obj.IsCare, obj.isRead, obj.Status, obj.Unit, obj.NewsKind, obj.Type, obj.TypeUrl, obj.Links, obj.Tags, obj.IsImage, obj.Note, obj.SourceInfo, obj.IsEdited, obj.EditedUser, obj.EditedTime, obj.VoteCount, obj.ViewCount, obj.IsArchived, obj.ArchivedDate, obj.Credit, obj.Createdate, obj.ApprovalRequestDate, obj.ApprovalDate, obj.ApprovalUser, obj.ReturnedDate, obj.ReturnedUser, obj.CancelPublishDate, obj.CancelPublishUser, obj.PublishedDate, obj.PublishedUser, obj.UserId, obj.WriterName, obj.WriterFullName, obj.NumberNews, obj.NotePrices, obj.LanguageId, obj.PortalId, obj.ToUrl, obj.GetFromPortal, obj.GetFromNewId, obj.SendName, obj.SendView)
    End Sub
    Public Sub SV_CMS_NewsByCategory_Add(PortalConnect As String, objNewsByCategory As CMS_NewsByCategoryInfo)
        DataProvider.Instance().SV_CMS_NewsByCategory_Add(PortalConnect, objNewsByCategory.Id, objNewsByCategory.NewsId, objNewsByCategory.CategoryId, objNewsByCategory.IsMainCategory, objNewsByCategory.NewsStatusId, objNewsByCategory.PortalID, objNewsByCategory.LanguageId)
    End Sub
    Public Sub SV_CMS_NewsByMedia_Add(PortalConnect As String, objNewsByMedia As CMS_NewsByMediaInfo)
        DataProvider.Instance().SV_CMS_NewsByMedia_Add(PortalConnect, objNewsByMedia.Id, objNewsByMedia.NewsId, objNewsByMedia.MediaId)
    End Sub
    Public Sub SV_CMS_Media_Add(PortalConnect As String, objTNMedia As CMS_MediaInfo)
        DataProvider.Instance().SV_CMS_Media_Add(PortalConnect, objTNMedia.Id, objTNMedia.CategoryId, objTNMedia.Name, objTNMedia.Summary, objTNMedia.Avatar, objTNMedia.MediaUrl, objTNMedia.Folders, objTNMedia.Contents, objTNMedia.ViewCount, objTNMedia.Status, objTNMedia.Type, objTNMedia.IsYoutube, objTNMedia.IsHot, objTNMedia.IsFTP, objTNMedia.Tags, objTNMedia.Note, objTNMedia.CreatedDate, objTNMedia.PublishedDate, objTNMedia.ApprovalDate, objTNMedia.CreatedUser, objTNMedia.ApprovalUser, objTNMedia.PublishedUser, objTNMedia.PortalId, objTNMedia.LanguageId, objTNMedia.STT, objTNMedia.IsHome, objTNMedia.IsPage, objTNMedia.ToUrl)
    End Sub
    Public Sub SV_Update_CMS_Event_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Event_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_News_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_News_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_NewsByCategory_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsByCategory_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_NewsByMedia_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsByMedia_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_Media_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Media_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_CMS_Advertise_Add(PortalConnect As String, objCMS_Advertise As CMS_AdvertiseInfo)
        DataProvider.Instance().SV_CMS_Advertise_Add(PortalConnect, objCMS_Advertise.Advertise_ID, objCMS_Advertise.Advertise_Name, objCMS_Advertise.ImgType, objCMS_Advertise.Images, objCMS_Advertise.IsWith, objCMS_Advertise.IsHeight, objCMS_Advertise.Target, objCMS_Advertise.IsURL, objCMS_Advertise.StartDate, objCMS_Advertise.EndDate, objCMS_Advertise.IsLang, objCMS_Advertise.IsActive, objCMS_Advertise.IsOrder, objCMS_Advertise.CreatedBy, objCMS_Advertise.UserName, objCMS_Advertise.UpdatedBy, objCMS_Advertise.UserUpdate, objCMS_Advertise.PageLoca_ID, objCMS_Advertise.PortalID, objCMS_Advertise.CategoryID)
    End Sub
    Public Sub SV_CMS_FAQ_Add(PortalConnect As String, obj As CMS_FAQInfo)
        DataProvider.Instance().SV_CMS_FAQ_Add(PortalConnect, obj.Id, obj.Name, obj.Summary, obj.Image, obj.StartDate, obj.EndDate, obj.AnswerUserId, obj.AnswerUserName, obj.IsUserDefault, obj.DefaultAnswerName, obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Sub SV_CMS_FAQAnswers_Add(PortalConnect As String, obj As CMS_FAQAnswersInfo)
        DataProvider.Instance().SV_CMS_FAQAnswers_Add(PortalConnect, obj.Id, obj.QuestionID, obj.Name, obj.Title, obj.Contents, obj.FileAttach, obj.SendDate, obj.Status, obj.IsPublic, obj.PortalId, obj.AnswerName, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Sub SV_CMS_FAQQuestions_Add(PortalConnect As String, obj As CMS_FAQQuestionsInfo)
        DataProvider.Instance().SV_CMS_FAQQuestions_Add(PortalConnect, obj.Id, obj.FAQID, obj.Name, obj.Contents, obj.FileAttach, obj.Adress, obj.Email, obj.Phone, obj.SendDate, obj.Status, obj.IsPublic, obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Sub SV_CMS_ConfigSystem_Add(PortalConnect As String, obj As CMS_ConfigSystemInfo)
        DataProvider.Instance().SV_CMS_ConfigSystem_Add(PortalConnect, obj.ID, obj.PortalID, obj.IsCMS, obj.IsLive, obj.LiveTitle, obj.LiveUrl, obj.LiveDes, obj.StartDate, obj.EndDate, obj.SiteMap, obj.IpPublic, obj.Analytics, obj.UpdatedBy, obj.UpdateName)
    End Sub
    Public Sub SV_CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
        DataProvider.Instance().SV_CMS_Setups_Add(PortalConnect, obj.ID, obj.SettingName, obj.SettingValue, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Sub SV_Update_CMS_Question_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Question_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_Answers_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Answers_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_Document_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Document_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_Advertise_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Advertise_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_WebLink_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_WebLink_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_NewsFeedback_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsFeedback_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_Update_CMS_NewsCategories_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsCategories_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_CMS_Infomation_Add(ByVal PortalConnect As String, obj As CMS_InfomationInfo)
        DataProvider.Instance().SV_CMS_Infomation_Add(PortalConnect, obj.NameH1, obj.NameH2, obj.NameH3, obj.ImagePath, obj.ImageRight, obj.Footer, obj.Infomation, obj.CreatedDate, obj.CreatedUser, obj.UpdateDate, obj.UpdateUser, obj.PortalId, obj.LanguageId)
    End Sub
    Public Sub SV_Update_CMS_MenuD_SendView(PortalConnect As String, MenuD_ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_MenuD_SendView(PortalConnect, MenuD_ID, SendView)
    End Sub
    Public Sub SV_Update_CMS_Infomation_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Infomation_SendView(PortalConnect, Id, SendView)
    End Sub
    Public Sub SV_CMS_NewsByTags_Add(ByVal PortalConnect As String, Id As Integer, newsId As Integer, tagName As String)
        DataProvider.Instance().SV_CMS_NewsByTags_Add(PortalConnect, Id, newsId, tagName, Now, Now)
    End Sub
    Public Sub SV_CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
        DataProvider.Instance().SV_CMS_NewsFeedback_Add(PortalConnect, obj.NewsFeedbackId, obj.ItemId, obj.FullName, obj.Email, obj.CreateDate,
                                                 obj.PhoneNumber, obj.Title, obj.Content, obj.Address, obj.IPTrack, obj.Status,
                                                 obj.Avatar, obj.Type, obj.PortalId, obj.LanguageId, obj.IsLike, obj.DisLike,
                                                 obj.ParentID, obj.IsRead, obj.UserRead, obj.DateRead, obj.IsPublic, obj.UserPublic, obj.DatePublic)
    End Sub
    Public Sub SV_CMS_NewsPapers_Add(ByVal PortalConnect As String, obj As CMS_NewsPapersInfo)
        DataProvider.Instance().SV_CMS_NewsPapers_Add(PortalConnect, obj.NewsPapers_ID, obj.NewsPapers_Number, obj.Category_ID, obj.PublicDate, obj.ImagePath, obj.IsYear, obj.IsPublic, obj.CreateDate, obj.UserName, obj.UpdateDate, obj.UpdateUser, obj.PortalID, obj.SendView)
    End Sub
    Public Sub SV_CMS_NewsPapersD_Add(ByVal PortalConnect As String, obj As CMS_NewsPapersDInfo)
        DataProvider.Instance().SV_CMS_NewsPapersD_Add(PortalConnect, obj.NewsPapersD_ID, obj.NewsPapers_ID, obj.PageNumber, obj.PhotoPath, obj.PhotoDes, obj.CreateDate, obj.UserName, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Sub SV_Update_CMS_NewsPapers_SendView(PortalConnect As String, newsPapers_ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsPapers_SendView(PortalConnect, newsPapers_ID, SendView)
    End Sub
    Public Sub SV_Update_CMS_NewsPapersD_SendView(PortalConnect As String, newsPapersD_ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_NewsPapersD_SendView(PortalConnect, newsPapersD_ID, SendView)
    End Sub
    Public Sub SV_Update_CMS_FAQ_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_FAQ_SendView(PortalConnect, ID, SendView)
    End Sub
    Public Sub SV_Update_CMS_FAQAnswers_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_FAQAnswers_SendView(PortalConnect, ID, SendView)

    End Sub
    Public Sub SV_Update_CMS_FAQQuestions_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_FAQQuestions_SendView(PortalConnect, ID, SendView)

    End Sub
    Public Sub SV_Update_CMS_ConfigSystem_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_ConfigSystem_SendView(PortalConnect, ID, SendView)

    End Sub
    Public Sub SV_Update_CMS_Setups_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        DataProvider.Instance().SV_Update_CMS_Setups_SendView(PortalConnect, ID, SendView)

    End Sub
#End Region
#Region "RPT"
    Public Function CMS_Reports_1(PortalConnect As String, PortalID As Integer, Lang As String, Top As String, FromDate As DateTime, ToDate As DateTime, Flag As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Reports_1(PortalConnect, PortalID, Lang, Top, FromDate, ToDate, Flag), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_Reports_2(PortalConnect As String, PortalID As Integer, Lang As String, UserID As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Reports_2(PortalConnect, PortalID, Lang, UserID, FromDate, ToDate), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_Reports_3(PortalConnect As String, PortalID As Integer, Lang As String, CategoryId As Integer, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Reports_3(PortalConnect, PortalID, Lang, CategoryId, FromDate, ToDate), GetType(CMS_NewsInfo))
    End Function

#End Region
#Region "CMS_DashBoard"
    Public Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_Admin(PortalConnect, year))
    End Function

#End Region
#Region "NewRss"
    Public Function NewRss_Get(PortalConnect As String, iD As String) As NewRssInfo
        Return CBO.FillObject(Of NewRssInfo)(DataProvider.Instance().NewRss_Get(PortalConnect, iD))
    End Function
    Public Function NewRss_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NewRss_List(PortalConnect, portalId), GetType(NewRssInfo))
    End Function
    Public Function NewRss_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NewRss_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(NewRssInfo))
    End Function
    Public Function NewRss_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NewRss_List_Home(PortalConnect, portalId, currPage, recodperpage), GetType(NewRssInfo))
    End Function

    Public Sub NewRss_Add(PortalConnect As String, obj As NewRssInfo)
        DataProvider.Instance().NewRss_Add(PortalConnect, obj.ID, obj.NewsSourceID, obj.Title, obj.Url, obj.Summary, obj.Content, obj.PortalId, obj.PubDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedBy, obj.UpdateName)
    End Sub
    Public Sub NewRss_Update(PortalConnect As String, obj As NewRssInfo)
        DataProvider.Instance().NewRss_Update(PortalConnect, obj.ID, obj.NewsSourceID, obj.Title, obj.Url, obj.Summary, obj.Content, obj.PortalId, obj.CreatedDate, obj.CreatedUser, obj.UpdatedBy, obj.UpdateName)
    End Sub
    Public Sub NewRss_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().NewRss_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "NewsSource"
    Public Function NewsSource_Get(PortalConnect As String, newsSourceID As String) As NewsSourceInfo
        Return CBO.FillObject(Of NewsSourceInfo)(DataProvider.Instance().NewsSource_Get(PortalConnect, newsSourceID))
    End Function
    Public Function NewsSource_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NewsSource_List(PortalConnect, portalId), GetType(NewsSourceInfo))
    End Function
    Public Function NewsSource_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().NewsSource_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(NewsSourceInfo))
    End Function

    Public Sub NewsSource_Add(PortalConnect As String, obj As NewsSourceInfo)
        DataProvider.Instance().NewsSource_Add(PortalConnect, obj.NewsSourceID, obj.Name, obj.Link, obj.PortalId, obj.CreatedDate, obj.CreatedUser, obj.UpdatedBy, obj.UpdateName)
    End Sub
    Public Sub NewsSource_Update(PortalConnect As String, obj As NewsSourceInfo)
        DataProvider.Instance().NewsSource_Update(PortalConnect, obj.NewsSourceID, obj.Name, obj.Link, obj.PortalId, obj.CreatedDate, obj.CreatedUser, obj.UpdatedBy, obj.UpdateName)
    End Sub
    Public Sub NewsSource_Delete(PortalConnect As String, newsSourceID As String)
        DataProvider.Instance().NewsSource_Delete(PortalConnect, newsSourceID)
    End Sub
#End Region
#Region "CMS_Business"
    Public Function CMS_Business_Get_All(strConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_Get_All(strConnect), GetType(TN_BusinessInfo))
    End Function
    Public Function CMS_JobUser_Get_All(strConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_Get_All(strConnect), GetType(TN_JobUserInfo))
    End Function
    Public Function CMS_Work_Get_All(strConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_Get_All(strConnect), GetType(TN_WorkInfo))
    End Function
    Public Function CMS_CategoryOld_All(strConnect As String, pid As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CategoryOld_All(strConnect, pid), GetType(TopicInfo))
    End Function
    Public Function CMS_News_ListCate(strConnect As String, cateID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_ListCate(strConnect, cateID), GetType(TN_NewsInfo))
    End Function
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
#Region "CMS_NhomBanner"
    Public Function CMS_NhomBanner_Get(PortalConnect As String, id As Integer) As CMS_NhomBannerInfo
        Return CBO.FillObject(Of CMS_NhomBannerInfo)(DataProvider.Instance().CMS_NhomBanner_Get(PortalConnect, id))
    End Function
    Public Function CMS_NhomBanner_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NhomBanner_List(PortalConnect), GetType(CMS_NhomBannerInfo))
    End Function
    Public Function CMS_NhomBanner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NhomBanner_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_NhomBannerInfo))
    End Function

    Public Function CMS_NhomBanner_Add(PortalConnect As String, obj As CMS_NhomBannerInfo) As Integer
        Return DataProvider.Instance().CMS_NhomBanner_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NhomBanner_Update(PortalConnect As String, obj As CMS_NhomBannerInfo)
        DataProvider.Instance().CMS_NhomBanner_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NhomBanner_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_NhomBanner_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_Banner"
    Public Function CMS_Banner_Get(PortalConnect As String, id As Integer) As CMS_BannerInfo
        Return CBO.FillObject(Of CMS_BannerInfo)(DataProvider.Instance().CMS_Banner_Get(PortalConnect, id))
    End Function
    Public Function CMS_Banner_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Banner_List(PortalConnect), GetType(CMS_BannerInfo))
    End Function
    Public Function CMS_Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Banner_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_BannerInfo))
    End Function

    Public Function CMS_Banner_Add(PortalConnect As String, obj As CMS_BannerInfo) As Integer
        Return DataProvider.Instance().CMS_Banner_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Banner_Update(PortalConnect As String, obj As CMS_BannerInfo)
        DataProvider.Instance().CMS_Banner_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Banner_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_Banner_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_BackUp"
    Public Function CMS_BackUp_Get(PortalConnect As String, id As Integer) As CMS_BackUpInfo
        Return CBO.FillObject(Of CMS_BackUpInfo)(DataProvider.Instance().CMS_BackUp_Get(PortalConnect, id))
    End Function
    Public Function CMS_BackUp_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BackUp_List(PortalConnect), GetType(CMS_BackUpInfo))
    End Function
    Public Function CMS_BackUp_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BackUp_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_BackUpInfo))
    End Function

    Public Function CMS_BackUp_Add(PortalConnect As String, obj As CMS_BackUpInfo) As Integer
        Return DataProvider.Instance().CMS_BackUp_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BackUp_Update(PortalConnect As String, obj As CMS_BackUpInfo)
        DataProvider.Instance().CMS_BackUp_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BackUp_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_BackUp_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_ThongBao"
    Public Function CMS_ThongBao_Get(PortalConnect As String, id As Integer) As CMS_ThongBaoInfo
        Return CBO.FillObject(Of CMS_ThongBaoInfo)(DataProvider.Instance().CMS_ThongBao_Get(PortalConnect, id))
    End Function
    Public Function CMS_ThongBao_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ThongBao_List(PortalConnect), GetType(CMS_ThongBaoInfo))
    End Function
    Public Function CMS_ThongBao_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional IsActive As Integer = -1) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ThongBao_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, IsActive), GetType(CMS_ThongBaoInfo))
    End Function

    Public Function CMS_ThongBao_Add(PortalConnect As String, obj As CMS_ThongBaoInfo) As Integer
        Return DataProvider.Instance().CMS_ThongBao_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ThongBao_Update(PortalConnect As String, obj As CMS_ThongBaoInfo)
        DataProvider.Instance().CMS_ThongBao_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ThongBao_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_ThongBao_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_NewsAudio"
    Public Function CMS_NewsAudio_Get(PortalConnect As String, iD As Integer) As CMS_NewsAudioInfo
        Return CBO.FillObject(Of CMS_NewsAudioInfo)(DataProvider.Instance().CMS_NewsAudio_Get(PortalConnect, iD))
    End Function
    Public Function CMS_NewsAudio_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsAudio_List(PortalConnect), GetType(CMS_NewsAudioInfo))
    End Function
    Public Function CMS_NewsAudio_ListByNewsID(PortalConnect As String, newsId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsAudio_ListByNewsID(PortalConnect, newsId), GetType(CMS_NewsAudioInfo))
    End Function

    Public Function CMS_NewsAudio_Add(PortalConnect As String, obj As CMS_NewsAudioInfo) As Integer
        Return DataProvider.Instance().CMS_NewsAudio_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsAudio_Update(PortalConnect As String, obj As CMS_NewsAudioInfo)
        DataProvider.Instance().CMS_NewsAudio_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsAudio_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_NewsAudio_Delete(PortalConnect, iD)
    End Sub
#End Region


End Class