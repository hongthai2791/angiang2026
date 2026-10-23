Imports DotNetNuke.Common.Utilities
Public Class MobileController

#Region "CMS_App"
    Public Function CMS_App_Get_By_AppID(PortalConnect As String, PortalID As Integer, appID As String) As CMS_AppInfo
        Return CBO.FillObject(Of CMS_AppInfo)(DataProvider.Instance().CMS_App_Get_By_AppID(PortalConnect, PortalID, appID))
    End Function
    Public Function CMS_App_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_App_List(PortalConnect), GetType(CMS_AppInfo))
    End Function
    Public Function CMS_App_List_Search(PortalConnect As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_App_List_Search(PortalConnect, PortalID, search, currPage, recodperpage, fromDate, toDate), GetType(CMS_AppInfo))
    End Function
    Public Function CMS_App_Get(PortalConnect As String, appKey As String) As CMS_AppInfo
        Return CBO.FillObject(Of CMS_AppInfo)(DataProvider.Instance().CMS_App_Get(PortalConnect, appKey))
    End Function
    Public Sub CMS_App_Add(PortalConnect As String, obj As CMS_AppInfo)
        DataProvider.Instance().CMS_App_Add(PortalConnect, obj)
    End Sub
    Public Function CMS_App_List_Find(PortalConnect As String, PortalID As Integer, search As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_App_List_Find(PortalConnect, PortalID, search), GetType(CMS_AppInfo))
    End Function
    Public Sub CMS_App_Delete(PortalConnect As String, appKey As String)
        DataProvider.Instance().CMS_App_Delete(PortalConnect, appKey)
    End Sub
    Public Sub CMS_App_Remove(PortalConnect As String, appID As String, PortalID As Integer)
        DataProvider.Instance().CMS_App_Remove(PortalConnect, appID, PortalID)
    End Sub
    Public Sub CMS_App_Update(PortalConnect As String, obj As CMS_AppInfo)
        DataProvider.Instance().CMS_App_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_App_Change(PortalConnect As String, AppID As String, NewID As String, PortalID As String)
        DataProvider.Instance().CMS_App_Change(PortalConnect, AppID, NewID, PortalID)
    End Sub
    Public Function CMS_App_Check(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
        Return DataProvider.Instance().CMS_App_Check(PortalConnect, AppID, PortalID)
    End Function
    Public Sub CMS_App_Update_Point(PortalConnect As String, appID As String, point As Integer, history As String, portalID As Integer)
        DataProvider.Instance().CMS_App_Update_Point(PortalConnect, appID, point, history, portalID)
    End Sub
#End Region
#Region "CMS_News"
    Public Function CMS_News_List_AppFind(PortalConnect As String, portalID As Integer, search As String, cateID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_AppFind(PortalConnect, portalID, search, cateID, currPage, recodperpage), GetType(CMS_NewsInfo))
    End Function
    Public Sub CMS_News_Update_Tags(PortalConnect As String, NewsID As Integer, Tags As String)
        DataProvider.Instance().CMS_News_Update_Tags(PortalConnect, NewsID, Tags)
    End Sub
    Public Function CMS_News_Get(PortalConnect As String, newsID As Integer) As CMS_NewsInfo
        Return CBO.FillObject(Of CMS_NewsInfo)(DataProvider.Instance().CMS_News_Get(PortalConnect, newsID))
    End Function
    Public Function CMS_News_List(PortalConnect As String, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List(PortalConnect, portalID), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search(PortalConnect, portalID, Title, CateID, PageIndex, PageSize, FromDate, ToDate, Status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
        Return DataProvider.Instance().CMS_News_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
        DataProvider.Instance().CMS_News_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_News_Update_Contents(PortalConnect As String, newsID As Integer, Contents As String)
        DataProvider.Instance().CMS_News_Update_Contents(PortalConnect, newsID, Contents)
    End Sub
    Public Sub CMS_News_Update_Status(PortalConnect As String, NewsID As Integer, Status As Integer, UserName As String, update As DateTime)
        DataProvider.Instance().CMS_News_Update_Status(PortalConnect, NewsID, Status, UserName, update)
    End Sub
    Public Sub CMS_News_Delete(PortalConnect As String, newsID As Integer)
        DataProvider.Instance().CMS_News_Delete(PortalConnect, newsID)
    End Sub
    Public Sub CMS_News_Update_Like(PortalConnect As String, newsID As Integer)
        DataProvider.Instance().CMS_News_Update_Like(PortalConnect, newsID)
    End Sub
    Public Sub CMS_News_Update_View(PortalConnect As String, newsID As Integer)
        DataProvider.Instance().CMS_News_Update_View(PortalConnect, newsID)
    End Sub

    Public Function CMS_News_List_Search_Top_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search_Top_Web(PortalConnect, portalID, Top, CateID, Status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Search_Block_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, IsFlag As Integer, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search_Block_Web(PortalConnect, portalID, Top, CateID, IsFlag, Status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Search_Top_View(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search_Top_View(PortalConnect, portalID, Top, CateID, Status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Search_Cate_web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Search_Cate_web(PortalConnect, portalID, Top, CateID, Status), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Home(PortalConnect, NewsID, CategoryId, PortalId, PageIndex, PageSize), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_News_List_Home_Cate(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_News_List_Home_Cate(PortalConnect, NewsID, CategoryId, PortalId, PageIndex, PageSize), GetType(CMS_NewsInfo))
    End Function
    Public Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_SiteMap_News(PortalConnect, PortalID, IsLang, top), GetType(CMS_NewsInfo))
    End Function

#End Region
#Region "CMS_NewsTag"
    Public Function CMS_NewsTag_Get(PortalConnect As String, iD As Long) As CMS_NewsTagInfo
        Return CBO.FillObject(Of CMS_NewsTagInfo)(DataProvider.Instance().CMS_NewsTag_Get(PortalConnect, iD))
    End Function
    Public Function CMS_NewsTag_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsTag_List(PortalConnect), GetType(CMS_NewsTagInfo))
    End Function
    Public Function CMS_NewsTag_Add(PortalConnect As String, obj As CMS_NewsTagInfo) As Integer
        Return DataProvider.Instance().CMS_NewsTag_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsTag_Update(PortalConnect As String, obj As CMS_NewsTagInfo)
        DataProvider.Instance().CMS_NewsTag_Update(PortalConnect, obj)
    End Sub
    Public Function CMS_NewsTag_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsTag_Get_By_CMS_News(PortalConnect, newsID), GetType(CMS_NewsTagInfo))
    End Function
    Public Sub CMS_NewsTag_Delete(PortalConnect As String, iD As Long)
        DataProvider.Instance().CMS_NewsTag_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_NewVersion"
    Public Function CMS_NewVersion_Get(PortalConnect As String, version_ID As Integer) As CMS_NewVersionInfo
        Return CBO.FillObject(Of CMS_NewVersionInfo)(DataProvider.Instance().CMS_NewVersion_Get(PortalConnect, version_ID))
    End Function
    Public Function CMS_NewVersion_Add(PortalConnect As String, obj As CMS_NewVersionInfo) As Integer
        Return DataProvider.Instance().CMS_NewVersion_Add(PortalConnect, obj)
    End Function
    Public Function CMS_NewVersion_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewVersion_Get_By_CMS_News(PortalConnect, newsID), GetType(CMS_NewVersionInfo))
    End Function
    Public Sub CMS_NewVersion_Delete(PortalConnect As String, version_ID As Integer)
        DataProvider.Instance().CMS_NewVersion_Delete(PortalConnect, version_ID)
    End Sub
#End Region
#Region "CMS_Video"
    Public Function CMS_Video_List_App(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Video_List_App(PortalConnect, portalID, CateID, Title, PageIndex, PageSize), GetType(CMS_VideoInfo))
    End Function
    Public Function CMS_Video_List_Home(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Video_List_Home(PortalConnect, portalID, CateID, Title, PageIndex, PageSize), GetType(CMS_VideoInfo))
    End Function
    Public Function CMS_Video_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Video_List_Search(PortalConnect, portalID, Title, CateID, PageIndex, PageSize, FromDate, ToDate, Status), GetType(CMS_VideoInfo))
    End Function
    Public Function CMS_Video_Get(PortalConnect As String, VideoID As Integer) As CMS_VideoInfo
        Return CBO.FillObject(Of CMS_VideoInfo)(DataProvider.Instance().CMS_Video_Get(PortalConnect, VideoID))
    End Function
    Public Function CMS_Video_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Video_List(PortalConnect), GetType(CMS_VideoInfo))
    End Function
    Public Function CMS_Video_Add(PortalConnect As String, obj As CMS_VideoInfo) As Integer
        Return DataProvider.Instance().CMS_Video_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Video_Update(PortalConnect As String, obj As CMS_VideoInfo)
        DataProvider.Instance().CMS_Video_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Video_Delete(PortalConnect As String, VideoID As Integer)
        DataProvider.Instance().CMS_Video_Delete(PortalConnect, VideoID)
    End Sub
    Public Sub CMS_Video_Update_Status(PortalConnect As String, VideoID As Integer, Status As Integer, UserName As String, update As DateTime)
        DataProvider.Instance().CMS_Video_Update_Status(PortalConnect, VideoID, Status, UserName, update)
    End Sub
    Public Sub CMS_Video_Update_Like(PortalConnect As String, VideoID As Integer, isLike As Integer)
        DataProvider.Instance().CMS_Video_Update_Like(PortalConnect, VideoID, isLike)
    End Sub
    Public Sub CMS_Video_Update_Bad(PortalConnect As String, VideoID As Integer, isBad As Integer)
        DataProvider.Instance().CMS_Video_Update_Bad(PortalConnect, VideoID, isBad)
    End Sub
    Public Sub CMS_Video_Update_View(PortalConnect As String, VideoID As Integer)
        DataProvider.Instance().CMS_Video_Update_View(PortalConnect, VideoID)
    End Sub
#End Region
#Region "CMS_AppLog"
    Public Function CMS_AppLog_ListToken(PortalConnect As String, appID As String, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AppLog_ListToken(PortalConnect, appID, portalID), GetType(CMS_AppLogInfo))
    End Function
    Public Function CMS_AppLog_Get(PortalConnect As String, token As String, appID As String, portalID As Integer) As CMS_AppLogInfo
        Return CBO.FillObject(Of CMS_AppLogInfo)(DataProvider.Instance().CMS_AppLog_Get(PortalConnect, token, appID, portalID))
    End Function
    Public Function CMS_AppLog_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AppLog_List(PortalConnect), GetType(CMS_AppLogInfo))
    End Function
    Public Function CMS_AppLog_Add(PortalConnect As String, obj As CMS_AppLogInfo) As Integer
        Return DataProvider.Instance().CMS_AppLog_Add(PortalConnect, obj)
    End Function
    Public Function CMS_AppLog_Get_Login(PortalConnect As String, appID As String, token As String, isSystem As Integer, portalID As Integer) As Integer
        Return DataProvider.Instance().CMS_AppLog_Get_Login(PortalConnect, appID, token, isSystem, portalID)
    End Function
    Public Sub CMS_AppLog_Update_LogEnd(PortalConnect As String, token As String, appID As String, logEnd As DateTime, portalID As Integer)
        DataProvider.Instance().CMS_AppLog_Update_LogEnd(PortalConnect, token, appID, logEnd, portalID)
    End Sub
    Public Sub CMS_AppLog_Delete(PortalConnect As String, id As String, appID As String)
        DataProvider.Instance().CMS_AppLog_Delete(PortalConnect, id, appID)
    End Sub
    Public Function CMS_AppLog_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AppLog_List_Search(PortalConnect, portalID, search, currPage, recodperpage, fromDate, toDate), GetType(CMS_AppLogInfo))
    End Function
#End Region
#Region "CMS_FCM"
    Public Function CMS_FCM_Get(PortalConnect As String, appID As String, portalID As Integer) As CMS_FCMInfo
        Return CBO.FillObject(Of CMS_FCMInfo)(DataProvider.Instance().CMS_FCM_Get(PortalConnect, appID, portalID))
    End Function
    Public Function CMS_FCM_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FCM_List(PortalConnect), GetType(CMS_FCMInfo))
    End Function
    Public Function CMS_FCM_Add(PortalConnect As String, obj As CMS_FCMInfo) As Integer
        Return DataProvider.Instance().CMS_FCM_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_FCM_Delete(PortalConnect As String, token As String, appID As String, isSystem As Integer, portalID As Integer)
        DataProvider.Instance().CMS_FCM_Delete(PortalConnect, token, appID, isSystem, portalID)
    End Sub
#End Region
#Region "CMS_Category"
    Public Function CMS_Category_Get_By_ParentId(PortalConnect As String, PortalId As Integer, isType As Integer, ParentId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Category_Get_By_ParentId(PortalConnect, PortalId, isType, ParentId), GetType(CMS_CategoryInfo))
    End Function
    Public Function CMS_Category_Get_By_ParentId_Null(PortalConnect As String, PortalId As Integer, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Category_Get_By_ParentId_Null(PortalConnect, PortalId, isType), GetType(CMS_CategoryInfo))
    End Function
    Public Sub CMS_Category_Update_Order(PortalConnect As String, categoryid As Integer, OrderNumber As Integer)
        DataProvider.Instance().CMS_Category_Update_Order(PortalConnect, categoryid, OrderNumber)
    End Sub
    Public Function CMS_Category_Get(PortalConnect As String, categoryID As Integer) As CMS_CategoryInfo
        Return CBO.FillObject(Of CMS_CategoryInfo)(DataProvider.Instance().CMS_Category_Get(PortalConnect, categoryID))
    End Function
    Public Function CMS_Category_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Category_List(PortalConnect, portalId), GetType(CMS_CategoryInfo))
    End Function
    Public Sub CMS_Category_Delete(PortalConnect As String, categoryID As Integer)
        DataProvider.Instance().CMS_Category_Delete(PortalConnect, categoryID)
    End Sub
    Public Function CMS_Category_Add(PortalConnect As String, obj As CMS_CategoryInfo) As Integer
        Return DataProvider.Instance().CMS_Category_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Category_Update(PortalConnect As String, obj As CMS_CategoryInfo)
        DataProvider.Instance().CMS_Category_Update(PortalConnect, obj)
    End Sub
    Public Function CMS_Category_Get_TabPath(ByVal PortalConnect As String, categoryid As Integer) As CMS_CategoryInfo
        Return CBO.FillObject(Of CMS_CategoryInfo)(DataProvider.Instance().CMS_Category_Get_TabPath(PortalConnect, categoryid))
    End Function
    Public Function CMS_Category_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional ByVal Type As Integer = 1) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_Category_List_All(PortalConnect, PortalId, LanguageId, Type), GetType(CMS_CategoryInfo))
    End Function
    Public Function CMS_Category_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As CMS_CategoryInfo
        Return CBO.FillObject(Of CMS_CategoryInfo)(DataProvider.Instance().CMS_Category_Get_By_TabID(PortalConnect, tabID, portalID))
    End Function
    Public Function CMS_Category_Get_By_TabPath(PortalConnect As String, TabPath As String, tabID As Integer, portalID As Integer) As CMS_CategoryInfo
        Return CBO.FillObject(Of CMS_CategoryInfo)(DataProvider.Instance().CMS_Category_Get_By_TabPath(PortalConnect, TabPath, tabID, portalID))
    End Function
    Public Function CMS_Category_List_App(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer, parentID As Integer, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Category_List_App(PortalConnect, portalID, currPage, recodperpage, parentID, isType), GetType(CMS_CategoryInfo))
    End Function
#End Region
#Region "CMS_Portals"
    Public Function CMS_Portals_Get(PortalConnect As String, iD As Integer) As CMS_PortalsInfo
        Return CBO.FillObject(Of CMS_PortalsInfo)(DataProvider.Instance().CMS_Portals_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Portals_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portals_List(PortalConnect), GetType(CMS_PortalsInfo))
    End Function
    Public Function CMS_Portals_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portals_List_Search(PortalConnect, search, currPage, recodperpage), GetType(CMS_PortalsInfo))
    End Function
    Public Function CMS_Portals_Add(PortalConnect As String, obj As CMS_PortalsInfo) As Integer
        Return DataProvider.Instance().CMS_Portals_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Portals_Update(PortalConnect As String, obj As CMS_PortalsInfo)
        DataProvider.Instance().CMS_Portals_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Portals_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Portals_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Group"
    Public Function CMS_Group_Get(PortalConnect As String, iD As Integer) As CMS_GroupInfo
        Return CBO.FillObject(Of CMS_GroupInfo)(DataProvider.Instance().CMS_Group_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Group_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List(PortalConnect, portalId), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        DataProvider.Instance().CMS_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Group_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_GroupD"
    Public Function CMS_GroupD_Get(PortalConnect As String, iD As Integer) As CMS_GroupDInfo
        Return CBO.FillObject(Of CMS_GroupDInfo)(DataProvider.Instance().CMS_GroupD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_GroupD_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupD_List(PortalConnect, portalId), GetType(CMS_GroupDInfo))
    End Function
    Public Function CMS_GroupD_Get_By_CMS_Group(PortalConnect As String, portalID As Integer, groupiD As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupD_Get_By_CMS_Group(PortalConnect, portalID, groupiD, isActive, currPage, recodperpage), GetType(CMS_GroupDInfo))
    End Function
    Public Function CMS_GroupD_Add(PortalConnect As String, obj As CMS_GroupDInfo) As Integer
        Return DataProvider.Instance().CMS_GroupD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_GroupD_Update(PortalConnect As String, obj As CMS_GroupDInfo)
        DataProvider.Instance().CMS_GroupD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_GroupD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_GroupD_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_GroupD_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
        DataProvider.Instance().CMS_GroupD_Update_Like(PortalConnect, iD, isLike)
    End Sub
    Public Sub CMS_GroupD_Update_Bad(PortalConnect As String, iD As Integer, isBad As Integer)
        DataProvider.Instance().CMS_GroupD_Update_Bad(PortalConnect, iD, isBad)
    End Sub
    Public Sub CMS_GroupD_Update_Active(PortalConnect As String, iD As Integer, isActive As Boolean)
        DataProvider.Instance().CMS_GroupD_Update_Active(PortalConnect, iD, isActive)
    End Sub
    Public Function CMS_GroupD_List_Search(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupD_List_Search(PortalConnect, portalId, search, order, groupiD, trangThai, currPage, recodperpage), GetType(CMS_GroupDInfo))
    End Function
    Public Function CMS_GroupD_List_App(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupD_List_App(PortalConnect, portalId, search, order, groupiD, currPage, recodperpage), GetType(CMS_GroupDInfo))
    End Function
    Public Sub CMS_GroupD_Update_Refresh(PortalConnect As String, iD As Integer, RefreshFrom As DateTime, RefreshTo As DateTime, RefreshUser As String)
        DataProvider.Instance().CMS_GroupD_Update_Refresh(PortalConnect, iD, RefreshFrom, RefreshTo, RefreshUser)
    End Sub
#End Region
#Region "CMS_Chapter"
    Public Function CMS_Chapter_Get(PortalConnect As String, iD As Integer) As CMS_ChapterInfo
        Return CBO.FillObject(Of CMS_ChapterInfo)(DataProvider.Instance().CMS_Chapter_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Chapter_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_List(PortalConnect), GetType(CMS_ChapterInfo))
    End Function
    Public Function CMS_Chapter_Get_By_CMS_Story(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_Get_By_CMS_Story(PortalConnect, iD, currPage, recodperpage), GetType(CMS_ChapterInfo))
    End Function
    Public Sub CMS_Chapter_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Chapter_Delete_By_CMS_Story(PortalConnect, iD)
    End Sub
    Public Function CMS_Chapter_List_By_App(PortalConnect As String, iD As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_List_By_App(PortalConnect, iD, search, currPage, recodperpage), GetType(CMS_ChapterInfo))
    End Function
    Public Function CMS_Chapter_Next_Page(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_Next_Page(PortalConnect, iD, currPage, recodperpage), GetType(CMS_ChapterInfo))
    End Function
    Public Function CMS_Chapter_Frist_Page(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_Frist_Page(PortalConnect, iD), GetType(CMS_ChapterInfo))
    End Function
    Public Function CMS_Chapter_Download(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chapter_Download(PortalConnect, iD), GetType(CMS_ChapterInfo))
    End Function
    Public Function CMS_Chapter_Add(PortalConnect As String, obj As CMS_ChapterInfo) As Integer
        Return DataProvider.Instance().CMS_Chapter_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Chapter_Update(PortalConnect As String, obj As CMS_ChapterInfo)
        DataProvider.Instance().CMS_Chapter_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Chapter_Update_View(PortalConnect As String, iD As Integer, storyID As Integer)
        DataProvider.Instance().CMS_Chapter_Update_View(PortalConnect, iD, storyID)
    End Sub
    Public Sub CMS_Chapter_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Chapter_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Story"
    Public Function CMS_Story_Get(PortalConnect As String, iD As Integer) As CMS_StoryInfo
        Return CBO.FillObject(Of CMS_StoryInfo)(DataProvider.Instance().CMS_Story_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Story_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Story_List(PortalConnect), GetType(CMS_StoryInfo))
    End Function
    Public Function CMS_Story_List_Search(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, tacGia As String, Order As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Story_List_Search(PortalConnect, portalID, search, theLoai, tacGia, Order, currPage, recodperpage), GetType(CMS_StoryInfo))
    End Function
    Public Function CMS_Story_List_App(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Story_List_App(PortalConnect, portalID, search, theLoai, currPage, recodperpage), GetType(CMS_StoryInfo))
    End Function
    Public Function CMS_Story_List_Other(PortalConnect As String, portalID As Integer, Search As String, StoryID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Story_List_Other(PortalConnect, portalID, Search, StoryID, currPage, recodperpage), GetType(CMS_StoryInfo))
    End Function
    Public Function CMS_Story_Add(PortalConnect As String, obj As CMS_StoryInfo) As Integer
        Return DataProvider.Instance().CMS_Story_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Story_Update(PortalConnect As String, obj As CMS_StoryInfo)
        DataProvider.Instance().CMS_Story_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Story_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Story_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_Story_Update_View(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Story_Update_View(PortalConnect, iD)
    End Sub
    Public Sub CMS_Story_Update_Public(PortalConnect As String, iD As Integer, isPublic As Boolean)
        DataProvider.Instance().CMS_Story_Update_Public(PortalConnect, iD, isPublic)
    End Sub
    Public Sub CMS_Story_Update_HotCate(PortalConnect As String, iD As Integer, hotCate As Boolean)
        DataProvider.Instance().CMS_Story_Update_HotCate(PortalConnect, iD, hotCate)
    End Sub
    Public Function CMS_Story_List_By_Author(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Story_List_By_Author(PortalConnect), GetType(CMS_StoryInfo))
    End Function
    Public Sub CMS_Story_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
        DataProvider.Instance().CMS_Story_Update_Like(PortalConnect, iD, isLike)
    End Sub
#End Region
#Region "CMS_StoryC"
    Public Function CMS_StoryC_Get(PortalConnect As String, iD As Integer) As CMS_StoryCInfo
        Return CBO.FillObject(Of CMS_StoryCInfo)(DataProvider.Instance().CMS_StoryC_Get(PortalConnect, iD))
    End Function
    Public Function CMS_StoryC_List(PortalConnect As String, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryC_List(PortalConnect, portalID), GetType(CMS_StoryCInfo))
    End Function
    Public Function CMS_StoryC_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryC_List_Search(PortalConnect, search, currPage, recodperpage), GetType(CMS_StoryCInfo))
    End Function
    Public Function CMS_StoryC_Add(PortalConnect As String, obj As CMS_StoryCInfo) As Integer
        Return DataProvider.Instance().CMS_StoryC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_StoryC_Update(PortalConnect As String, obj As CMS_StoryCInfo)
        DataProvider.Instance().CMS_StoryC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_StoryC_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryC_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_StoryFB"
    Public Function CMS_StoryFB_Get(PortalConnect As String, iD As Integer) As CMS_StoryFBInfo
        Return CBO.FillObject(Of CMS_StoryFBInfo)(DataProvider.Instance().CMS_StoryFB_Get(PortalConnect, iD))
    End Function
    Public Function CMS_StoryFB_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryFB_List(PortalConnect), GetType(CMS_StoryFBInfo))
    End Function
    Public Function CMS_StoryFB_Get_By_CMS_Story(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryFB_Get_By_CMS_Story(PortalConnect, iD, currPage, recodperpage), GetType(CMS_StoryFBInfo))
    End Function
    Public Sub CMS_StoryFB_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryFB_Delete_By_CMS_Story(PortalConnect, iD)
    End Sub
    Public Function CMS_StoryFB_Add(PortalConnect As String, obj As CMS_StoryFBInfo) As Integer
        Return DataProvider.Instance().CMS_StoryFB_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_StoryFB_Update(PortalConnect As String, obj As CMS_StoryFBInfo)
        DataProvider.Instance().CMS_StoryFB_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_StoryFB_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryFB_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_StoryFB_Update_Lock(PortalConnect As String, iD As Integer, isLock As Integer)
        DataProvider.Instance().CMS_StoryFB_Update_Lock(PortalConnect, iD, isLock)
    End Sub
#End Region
#Region "CMS_StoryP"
    Public Function CMS_StoryP_Get(PortalConnect As String, iD As Integer) As CMS_StoryPInfo
        Return CBO.FillObject(Of CMS_StoryPInfo)(DataProvider.Instance().CMS_StoryP_Get(PortalConnect, iD))
    End Function
    Public Function CMS_StoryP_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryP_List(PortalConnect), GetType(CMS_StoryPInfo))
    End Function
    Public Function CMS_StoryP_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryP_Get_By_CMS_Story(PortalConnect, iD), GetType(CMS_StoryPInfo))
    End Function
    Public Sub CMS_StoryP_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryP_Delete_By_CMS_Story(PortalConnect, iD)
    End Sub
    Public Function CMS_StoryP_Add(PortalConnect As String, obj As CMS_StoryPInfo) As Integer
        Return DataProvider.Instance().CMS_StoryP_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_StoryP_Update(PortalConnect As String, obj As CMS_StoryPInfo)
        DataProvider.Instance().CMS_StoryP_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_StoryP_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryP_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_StoryD"
    Public Function CMS_StoryD_Get(PortalConnect As String, iD As Integer) As CMS_StoryDInfo
        Return CBO.FillObject(Of CMS_StoryDInfo)(DataProvider.Instance().CMS_StoryD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_StoryD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryD_List(PortalConnect), GetType(CMS_StoryDInfo))
    End Function
    Public Function CMS_StoryD_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_StoryD_Get_By_CMS_Story(PortalConnect, iD), GetType(CMS_StoryDInfo))
    End Function
    Public Sub CMS_StoryD_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryD_Delete_By_CMS_Story(PortalConnect, iD)
    End Sub
    Public Function CMS_StoryD_Add(PortalConnect As String, obj As CMS_StoryDInfo) As Integer
        Return DataProvider.Instance().CMS_StoryD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_StoryD_Update(PortalConnect As String, obj As CMS_StoryDInfo)
        DataProvider.Instance().CMS_StoryD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_StoryD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_StoryD_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_AdMob"
    Public Function CMS_AdMob_Get(PortalConnect As String, iD As Integer) As CMS_AdMobInfo
        Return CBO.FillObject(Of CMS_AdMobInfo)(DataProvider.Instance().CMS_AdMob_Get(PortalConnect, iD))
    End Function
    Public Function CMS_AdMob_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdMob_List(PortalConnect, portalId), GetType(CMS_AdMobInfo))
    End Function
    Public Function CMS_AdMob_Get_By_CMS_Portals(PortalConnect As String, iD As Integer) As CMS_AdMobInfo
        Return CBO.FillObject(Of CMS_AdMobInfo)(DataProvider.Instance().CMS_AdMob_Get_By_CMS_Portals(PortalConnect, iD))
    End Function
    Public Sub CMS_AdMob_Delete_By_CMS_Portals(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AdMob_Delete_By_CMS_Portals(PortalConnect, iD)
    End Sub
    Public Function CMS_AdMob_List_Search(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdMob_List_Search(PortalConnect, portalID, currPage, recodperpage), GetType(CMS_AdMobInfo))
    End Function
    Public Function CMS_AdMob_Add(PortalConnect As String, obj As CMS_AdMobInfo) As Integer
        Return DataProvider.Instance().CMS_AdMob_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_AdMob_Update(PortalConnect As String, obj As CMS_AdMobInfo)
        DataProvider.Instance().CMS_AdMob_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_AdMob_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AdMob_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Advertise"
    Public Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As CMS_AdvertiseInfo
        Return CBO.FillObject(Of CMS_AdvertiseInfo)(DataProvider.Instance().CMS_Advertise_Get(PortalConnect, advertise_ID))
    End Function
    Public Function CMS_Advertise_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List(PortalConnect), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List_Search(PortalConnect, search, currPage, recodperpage, PortalID), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, Top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List_Home(PortalConnect, PortalID, Top), GetType(CMS_AdvertiseInfo))
    End Function
    Public Function CMS_Advertise_List_Home_Local(PortalConnect As String, PortalID As Integer, Top As Integer, pageLocal As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Advertise_List_Home_Local(PortalConnect, PortalID, Top, pageLocal), GetType(CMS_AdvertiseInfo))
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
    Public Sub CMS_Advertise_Update_Click(PortalConnect As String, advertise_ID As String)
        DataProvider.Instance().CMS_Advertise_Update_Click(PortalConnect, advertise_ID)
    End Sub

#End Region
#Region "CMS_AdvertiseP"
    Public Function CMS_AdvertiseP_Get(PortalConnect As String, iD As Integer) As CMS_AdvertisePInfo
        Return CBO.FillObject(Of CMS_AdvertisePInfo)(DataProvider.Instance().CMS_AdvertiseP_Get(PortalConnect, iD))
    End Function
    Public Function CMS_AdvertiseP_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdvertiseP_List(PortalConnect), GetType(CMS_AdvertisePInfo))
    End Function
    Public Function CMS_AdvertiseP_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdvertiseP_Get_By_CMS_Advertise(PortalConnect, advertise_ID), GetType(CMS_AdvertisePInfo))
    End Function
    Public Sub CMS_AdvertiseP_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String)
        DataProvider.Instance().CMS_AdvertiseP_Delete_By_CMS_Advertise(PortalConnect, advertise_ID)
    End Sub
    Public Function CMS_AdvertiseP_Add(PortalConnect As String, obj As CMS_AdvertisePInfo) As Integer
        Return DataProvider.Instance().CMS_AdvertiseP_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_AdvertiseP_Update(PortalConnect As String, obj As CMS_AdvertisePInfo)
        DataProvider.Instance().CMS_AdvertiseP_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_AdvertiseP_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AdvertiseP_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_AdvertiseL"
    Public Function CMS_AdvertiseL_Get(PortalConnect As String, iD As Integer) As CMS_AdvertiseLInfo
        Return CBO.FillObject(Of CMS_AdvertiseLInfo)(DataProvider.Instance().CMS_AdvertiseL_Get(PortalConnect, iD))
    End Function
    Public Function CMS_AdvertiseL_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdvertiseL_List(PortalConnect), GetType(CMS_AdvertiseLInfo))
    End Function
    Public Function CMS_AdvertiseL_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AdvertiseL_Get_By_CMS_Advertise(PortalConnect, advertise_ID), GetType(CMS_AdvertiseLInfo))
    End Function
    Public Sub CMS_AdvertiseL_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String, pageLocal As Integer)
        DataProvider.Instance().CMS_AdvertiseL_Delete_By_CMS_Advertise(PortalConnect, advertise_ID, pageLocal)
    End Sub
    Public Function CMS_AdvertiseL_Add(PortalConnect As String, obj As CMS_AdvertiseLInfo) As Integer
        Return DataProvider.Instance().CMS_AdvertiseL_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_AdvertiseL_Update(PortalConnect As String, obj As CMS_AdvertiseLInfo)
        DataProvider.Instance().CMS_AdvertiseL_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_AdvertiseL_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AdvertiseL_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Notify"
    Public Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As CMS_NotifyInfo
        Return CBO.FillObject(Of CMS_NotifyInfo)(DataProvider.Instance().CMS_Notify_Get(PortalConnect, notify_ID))
    End Function
    Public Function CMS_Notify_Get_PortalID(PortalConnect As String, PortalID As Integer, types As Integer) As CMS_NotifyInfo
        Return CBO.FillObject(Of CMS_NotifyInfo)(DataProvider.Instance().CMS_Notify_Get_PortalID(PortalConnect, PortalID, types))
    End Function
    Public Function CMS_Notify_List_Search(PortalConnect As String, search As String, PortalID As Integer, types As Integer, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Notify_List_Search(PortalConnect, search, PortalID, types, currPage, recodperpage, fromDate, toDate), GetType(CMS_NotifyInfo))
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
    Public Sub CMS_Notify_Update_Active(PortalConnect As String, notify_ID As String, isActive As Boolean)
        DataProvider.Instance().CMS_Notify_Update_Active(PortalConnect, notify_ID, isActive)
    End Sub
    Public Function CMS_Notify_Send_Notifycation(PortalConnect As String, PortalID As Integer, startDay As Integer, NotifyID As String, sendList As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Notify_Send_Notifycation(PortalConnect, PortalID, startDay, NotifyID, sendList), GetType(CMS_NotiSendInfo))
    End Function
#End Region
#Region "CMS_NotiLog"
    Public Function CMS_NotiLog_Get(PortalConnect As String, notiLog_ID As Integer) As CMS_NotiLogInfo
        Return CBO.FillObject(Of CMS_NotiLogInfo)(DataProvider.Instance().CMS_NotiLog_Get(PortalConnect, notiLog_ID))
    End Function
    Public Function CMS_NotiLog_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiLog_List(PortalConnect), GetType(CMS_NotiLogInfo))
    End Function
    Public Function CMS_NotiLog_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiLog_Get_By_CMS_Notify(PortalConnect, notify_ID), GetType(CMS_NotiLogInfo))
    End Function
    Public Function CMS_NotiLog_Add(PortalConnect As String, obj As CMS_NotiLogInfo) As Integer
        Return DataProvider.Instance().CMS_NotiLog_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NotiLog_Update(PortalConnect As String, obj As CMS_NotiLogInfo)
        DataProvider.Instance().CMS_NotiLog_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NotiLog_Delete(PortalConnect As String, notiLog_ID As Integer)
        DataProvider.Instance().CMS_NotiLog_Delete(PortalConnect, notiLog_ID)
    End Sub
#End Region
#Region "CMS_NotiSend"

    Public Function CMS_NotiSend_Get(PortalConnect As String, notiSend_ID As Integer) As CMS_NotiSendInfo
        Return CBO.FillObject(Of CMS_NotiSendInfo)(DataProvider.Instance().CMS_NotiSend_Get(PortalConnect, notiSend_ID))
    End Function
    Public Function CMS_NotiSend_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiSend_List(PortalConnect), GetType(CMS_NotiSendInfo))
    End Function
    Public Function CMS_NotiSend_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiSend_Get_By_CMS_Notify(PortalConnect, notify_ID), GetType(CMS_NotiSendInfo))
    End Function
    Public Function CMS_NotiSend_List_By_AppID(PortalConnect As String, AppID As String, types As Integer, IdKey As String, currPage As Integer, recodperpage As Integer, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiSend_List_By_AppID(PortalConnect, AppID, types, IdKey, currPage, recodperpage, portalID), GetType(CMS_NotiSendInfo))
    End Function
    Public Function CMS_NotiSend_List_By_AppID_News(PortalConnect As String, AppID As String, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiSend_List_By_AppID_News(PortalConnect, AppID, portalID), GetType(CMS_NotiSendInfo))
    End Function
    Public Function CMS_NotiSend_Add(PortalConnect As String, obj As CMS_NotiSendInfo) As Integer
        Return DataProvider.Instance().CMS_NotiSend_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NotiSend_Update(PortalConnect As String, obj As CMS_NotiSendInfo)
        DataProvider.Instance().CMS_NotiSend_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NotiSend_Delete(PortalConnect As String, notiSend_ID As Integer)
        DataProvider.Instance().CMS_NotiSend_Delete(PortalConnect, notiSend_ID)
    End Sub
    Public Function CMS_NotiSend_List_Search(PortalConnect As String, Notify_ID As String, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime, tinhTrang As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NotiSend_List_Search(PortalConnect, Notify_ID, search, currPage, recodperpage, fromDate, toDate, tinhTrang), GetType(CMS_NotiSendInfo))
    End Function
    Public Sub CMS_NotiSend_Update_TinhTrang(PortalConnect As String, notiSend_ID As Integer, tinhTrang As Integer)
        DataProvider.Instance().CMS_NotiSend_Update_TinhTrang(PortalConnect, notiSend_ID, tinhTrang)
    End Sub
    Public Sub CMS_NotiSend_Update_TinhTrang_Read(PortalConnect As String, portalID As Integer, appID As String, tinhTrang As Integer)
        DataProvider.Instance().CMS_NotiSend_Update_TinhTrang_Read(PortalConnect, portalID, appID, tinhTrang)
    End Sub
    Public Sub CMS_NotiSend_Update_TinhTrang_Flag(PortalConnect As String, portalID As Integer, flags As String, idKey As String)
        DataProvider.Instance().CMS_NotiSend_Update_TinhTrang_Flag(PortalConnect, portalID, flags, idKey)
    End Sub
    Public Function CMS_NotiSend_UnRead_AppID(PortalConnect As String, appID As String, portalID As Integer) As Integer
        Return DataProvider.Instance().CMS_NotiSend_UnRead_AppID(PortalConnect, appID, portalID)
    End Function
    Public Sub CMS_NotiSend_Register(PortalConnect As String, appID As String, portalID As Integer)
        DataProvider.Instance().CMS_NotiSend_Register(PortalConnect, appID, portalID)
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
    'Public Function CMS_ConfigSystem_Get_PortalID(PortalConnect As String, PortalID As Integer) As CMS_ConfigSystemInfo
    '    Return CBO.FillObject(Of CMS_ConfigSystemInfo)(DataProvider.Instance().CMS_ConfigSystem_Get_PortalID(PortalConnect, PortalID))
    'End Function
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
#Region "CMS_Block"
    Public Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Block_List_By_Flag(PortalConnect, flag), GetType(CMS_BlockInfo))
    End Function
    Public Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As CMS_BlockInfo
        Return CBO.FillObject(Of CMS_BlockInfo)(DataProvider.Instance().CMS_Block_Get_By_Key(PortalConnect, idkey))
    End Function
#End Region
#Region "CMS_RegEmail"
    Public Function CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime) As String
        Return DataProvider.Instance().CMS_RegEmail_Add(PortalConnect, RegEmail_ID, RegEmail, RegDate)
    End Function

    Public Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegEmail_List(PortalConnect, currPage, recodperpage), GetType(CMS_RegEmailInfo))
    End Function

#End Region
#Region "CMS_Fr_Notify"
    Public Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As CMS_Fr_NotifyInfo
        Return CBO.FillObject(Of CMS_Fr_NotifyInfo)(DataProvider.Instance().CMS_Fr_Notify_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_Notify_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Notify_List(PortalConnect), GetType(CMS_Fr_NotifyInfo))
    End Function
    Public Function CMS_Fr_Notify_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Notify_List_AppID(PortalConnect, PortalID, appID, currPage, recodPage, flags), GetType(CMS_Fr_NotifyInfo))
    End Function
    Public Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Notify_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Notify_List_New(PortalConnect As String, PortalID As Integer, appID As String, flags As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Notify_List_New(PortalConnect, PortalID, appID, flags)
    End Function
    Public Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, PortalID As Integer, appID As String, flags As String)
        DataProvider.Instance().CMS_Fr_Notify_List_UnNew(PortalConnect, PortalID, appID, flags)
    End Sub
    Public Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
        DataProvider.Instance().CMS_Fr_Notify_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_Notify_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_Fr_Notify_ReadAll(PortalConnect As String, PortalID As Integer, appID As String)
        DataProvider.Instance().CMS_Fr_Notify_ReadAll(PortalConnect, PortalID, appID)
    End Sub
#End Region
#Region "CMS_Fr_Comment"
    Public Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As CMS_Fr_CommentInfo
        Return CBO.FillObject(Of CMS_Fr_CommentInfo)(DataProvider.Instance().CMS_Fr_Comment_Get(PortalConnect, comment_ID))
    End Function
    Public Function CMS_Fr_Comment_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List(PortalConnect), GetType(CMS_Fr_CommentInfo))
    End Function
    Public Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_CommentInfo))
        Else
            CMS_Fr_Comment_List_Search = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_List_Search", postID, currPage, recodperpage, UserName).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Fr_Comment_List_Admin(PortalConnect As String, postID As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List_Admin(PortalConnect, postID, isOrder, currPage, recodperpage, UserName), GetType(CMS_Fr_CommentInfo))
    End Function
    Public Function CMS_Fr_Comment_List_Top(PortalConnect As String, postID As Integer, Top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List_Top(PortalConnect, postID, Top), GetType(CMS_Fr_CommentInfo))
    End Function
    Public Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Comment_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Comment_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
        DataProvider.Instance().CMS_Fr_Comment_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
        DataProvider.Instance().CMS_Fr_Comment_Update_Lock(PortalConnect, commentID, lock, lockUser)
    End Sub
    Public Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        DataProvider.Instance().CMS_Fr_Comment_Delete(PortalConnect, comment_ID)
    End Sub
#End Region
#Region "CMS_Fr_Likes"
    Public Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As CMS_Fr_LikesInfo
        Return CBO.FillObject(Of CMS_Fr_LikesInfo)(DataProvider.Instance().CMS_Fr_Likes_Get(PortalConnect, likesID))
    End Function
    Public Function CMS_Fr_Likes_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Likes_List(PortalConnect), GetType(CMS_Fr_LikesInfo))
    End Function
    Public Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Likes_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_LikesInfo))
    End Function

    Public Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Likes_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Likes_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
        DataProvider.Instance().CMS_Fr_Likes_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        DataProvider.Instance().CMS_Fr_Likes_Delete(PortalConnect, appID, postID)
    End Sub
#End Region
#Region "CMS_Fr_Post"
    Public Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As CMS_Fr_PostInfo
        Return CBO.FillObject(Of CMS_Fr_PostInfo)(DataProvider.Instance().CMS_Fr_Post_Get(PortalConnect, post_ID))
    End Function
    Public Function CMS_Fr_Post_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List(PortalConnect), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Search(PortalConnect As String, PortalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Search(PortalConnect, PortalID, search, isOrder, currPage, recodperpage, appID), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Group(PortalConnect As String, PortalID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Group(PortalConnect, PortalID, GroupID, search, isOrder, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, PortalID As Integer, GroupID As Integer, AppID As String, lock As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Group_Web(PortalConnect, PortalID, GroupID, AppID, lock, search, isOrder, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_By_App(PortalConnect As String, PortalID As Integer, appID As String, isOder As Integer, search As String, GroupID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_By_App(PortalConnect, PortalID, appID, isOder, search, GroupID, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_By_AppTE(PortalConnect As String, PortalID As Integer, appID As String, teID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_By_AppTE(PortalConnect, PortalID, appID, teID, search, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Admin(PortalConnect As String, PortalID As Integer, GroupID As Integer, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Admin(PortalConnect, PortalID, GroupID, IsOrder, search, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Admin_lock(PortalConnect As String, PortalID As Integer, appID As String, isLock As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Admin_lock(PortalConnect, PortalID, appID, isLock, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_OnlyMe(PortalConnect, appID, PortalID, search, currPage, recodperpage, appFriend), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Post_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
        DataProvider.Instance().CMS_Fr_Post_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
        DataProvider.Instance().CMS_Fr_Post_Update_Lock(PortalConnect, postID, lock, lockuser)
    End Sub
    Public Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
        DataProvider.Instance().CMS_Fr_Post_Delete(PortalConnect, post_ID)
    End Sub
    Public Sub CMS_Fr_Post_Update_IsBad(PortalConnect As String, post_ID As Integer)
        DataProvider.Instance().CMS_Fr_Post_Update_IsBad(PortalConnect, post_ID)
    End Sub
#End Region
#Region "CMS_Fr_SharePost"
    Public Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_Fr_SharePostInfo
        Return CBO.FillObject(Of CMS_Fr_SharePostInfo)(DataProvider.Instance().CMS_Fr_SharePost_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_Fr_SharePost_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_SharePost_List(PortalConnect), GetType(CMS_Fr_SharePostInfo))
    End Function
    Public Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_SharePost_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_SharePostInfo))
    End Function

    Public Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_SharePost_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_SharePost_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
        DataProvider.Instance().CMS_Fr_SharePost_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_Fr_SharePost_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_ShareUser"
    Public Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_Fr_ShareUserInfo
        Return CBO.FillObject(Of CMS_Fr_ShareUserInfo)(DataProvider.Instance().CMS_Fr_ShareUser_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_Fr_ShareUser_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_ShareUser_List(PortalConnect), GetType(CMS_Fr_ShareUserInfo))
    End Function
    Public Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_ShareUser_List_Search(PortalConnect, search, currPage, recodperpage, postID), GetType(CMS_Fr_ShareUserInfo))
    End Function
    Public Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_ShareUser_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_ShareUser_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
        DataProvider.Instance().CMS_Fr_ShareUser_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_Fr_ShareUser_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_FileAttach"
    Public Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As CMS_Fr_FileAttachInfo
        Return CBO.FillObject(Of CMS_Fr_FileAttachInfo)(DataProvider.Instance().CMS_Fr_FileAttach_Get(PortalConnect, attach_ID))
    End Function
    Public Function CMS_Fr_FileAttach_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List(PortalConnect), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List_ByIdKey(PortalConnect, idKey, type, top), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        DataProvider.Instance().CMS_Fr_FileAttach_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        DataProvider.Instance().CMS_Fr_FileAttach_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        DataProvider.Instance().CMS_Fr_FileAttach_Delete(PortalConnect, attach_ID)
    End Sub
#End Region
#Region "CMS_Fr_Group"
    Public Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_Group_Get_By_AppID(PortalConnect As String, iD As Integer, appID As String) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_Get_By_AppID(PortalConnect, iD, appID))
    End Function
    Public Function CMS_Fr_Group_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List(PortalConnect), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_List_ByIsType(PortalConnect As String, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List_ByIsType(PortalConnect, isType), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List_AppID(PortalConnect, PortalID, appID, search, currPage, recodperpage), GetType(CMS_Fr_GroupInfo))
        Else
            CMS_Fr_Group_List_AppID = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_List_AppID", PortalID, appID, search, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
        DataProvider.Instance().CMS_Fr_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_Group_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Fr_Group_List_TK(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List_TK(PortalConnect, PortalID, currPage, recodperpage), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_TK(PortalConnect As String, PortalID As Integer, ID As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_TK(PortalConnect, PortalID, ID))
    End Function
    Public Function CMS_Fr_Group_ThongKe(PortalConnect As String, PortalID As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_ThongKe(PortalConnect, PortalID))
    End Function
    Public Function CMS_Fr_NguoiDang(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_NguoiDang(PortalConnect, PortalID, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_App_List_Admin(PortalConnect As String, PortalID As Integer, Search As String, isOrder As Integer, isSystem As Integer, tinhTP As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_App_List_Admin(PortalConnect, PortalID, Search, isOrder, isSystem, tinhTP, currPage, recodperpage), GetType(CMS_AppInfo))
    End Function
    Public Function CMS_Fr_GroupTV(PortalConnect As String, PortalID As Integer, ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupTV(PortalConnect, PortalID, ID), GetType(CMS_Fr_PostInfo))
    End Function
    Public Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)
        DataProvider.Instance().CMS_Fr_Group_Update_Lock(PortalConnect, ID, lock, lockuser)
    End Sub
    Public Function CMS_AppID_List_Group_Select(PortalConnect As String, PortalID As Integer, gID As String, AppID As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AppID_List_Group_Select(PortalConnect, PortalID, gID, AppID, search, currPage, recodperpage), GetType(CMS_Fr_GroupInfo))
    End Function
#End Region
#Region "CMS_Fr_GroupU"
    Public Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As CMS_Fr_GroupUInfo
        Return CBO.FillObject(Of CMS_Fr_GroupUInfo)(DataProvider.Instance().CMS_Fr_GroupU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_GroupU_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupU_List(PortalConnect), GetType(CMS_Fr_GroupUInfo))
    End Function
    Public Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect, iD, page, recod), GetType(CMS_Fr_GroupUInfo))
    End Function
    Public Function CMS_Fr_GroupU_Get_By_Group(PortalConnect As String, GroupID As Integer, AppID As String) As CMS_Fr_GroupUInfo
        Return CBO.FillObject(Of CMS_Fr_GroupUInfo)(DataProvider.Instance().CMS_Fr_GroupU_Get_By_Group(PortalConnect, GroupID, AppID))
    End Function
    Public Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect, iD)
    End Sub
    Public Sub CMS_Fr_GroupU_Remove_AppID(PortalConnect As String, groupID As Integer, appID As String)
        DataProvider.Instance().CMS_Fr_GroupU_Remove_AppID(PortalConnect, groupID, appID)
    End Sub
    Public Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_GroupU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
        DataProvider.Instance().CMS_Fr_GroupU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_GroupU_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_Fr_GroupU_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer)
        DataProvider.Instance().CMS_Fr_GroupU_Update_Lock(PortalConnect, ID, lock)
    End Sub
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
    Public Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PageIndex As Integer, PageSize As Integer, fromDate As DateTime, toDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Contact_List_Search(PortalConnect, Search, PageIndex, PageSize, fromDate, toDate), GetType(CMS_ContactInfo))
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
#Region "CMS_Food"
    Public Function CMS_Food_Get(PortalConnect As String, iD As Integer) As CMS_FoodInfo
        Return CBO.FillObject(Of CMS_FoodInfo)(DataProvider.Instance().CMS_Food_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Food_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Food_List(PortalConnect), GetType(CMS_FoodInfo))
    End Function
    Public Function CMS_Food_List_App(PortalConnect As String, portalID As Integer, search As String, category As Integer, currPage As Integer, recodperpage As Integer, trangThai As String, giaiDoan As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Food_List_App(PortalConnect, portalID, search, category, currPage, recodperpage, trangThai, giaiDoan), GetType(CMS_FoodInfo))
    End Function

    Public Function CMS_Food_Add(PortalConnect As String, obj As CMS_FoodInfo) As Integer
        Return DataProvider.Instance().CMS_Food_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Food_Update(PortalConnect As String, obj As CMS_FoodInfo)
        DataProvider.Instance().CMS_Food_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Food_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Food_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Food_List_Search(PortalConnect As String, portalID As Integer, FoodID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Food_List_Search(PortalConnect, portalID, FoodID, search, currPage, recodperpage), GetType(CMS_FoodInfo))
    End Function
#End Region
#Region "CMS_FoodC"
    Public Function CMS_FoodC_Get(PortalConnect As String, iD As Integer) As CMS_FoodCInfo
        Return CBO.FillObject(Of CMS_FoodCInfo)(DataProvider.Instance().CMS_FoodC_Get(PortalConnect, iD))
    End Function
    Public Function CMS_FoodC_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FoodC_List(PortalConnect, portalId), GetType(CMS_FoodCInfo))
    End Function

    Public Function CMS_FoodC_Add(PortalConnect As String, obj As CMS_FoodCInfo) As Integer
        Return DataProvider.Instance().CMS_FoodC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_FoodC_Update(PortalConnect As String, obj As CMS_FoodCInfo)
        DataProvider.Instance().CMS_FoodC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FoodC_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_FoodC_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_FoodC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FoodC_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_FoodCInfo))
    End Function
#End Region
#Region "CMS_Clinic"
    Public Function CMS_Clinic_Get(PortalConnect As String, iD As Integer) As CMS_ClinicInfo
        Return CBO.FillObject(Of CMS_ClinicInfo)(DataProvider.Instance().CMS_Clinic_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Clinic_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As CMS_ClinicInfo
        Return CBO.FillObject(Of CMS_ClinicInfo)(DataProvider.Instance().CMS_Clinic_Get_By_App(PortalConnect, portalID, appID, iD))
    End Function
    Public Function CMS_Clinic_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Clinic_List(PortalConnect), GetType(CMS_ClinicInfo))
    End Function

    Public Function CMS_Clinic_Add(PortalConnect As String, obj As CMS_ClinicInfo) As Integer
        Return DataProvider.Instance().CMS_Clinic_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Clinic_Update(PortalConnect As String, obj As CMS_ClinicInfo)
        DataProvider.Instance().CMS_Clinic_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Clinic_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Clinic_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Clinic_List_Search(PortalConnect As String, PotarID As Integer, IsOder As Integer, TinhTP As Integer, QuanHuyen As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Clinic_List_Search(PortalConnect, PotarID, IsOder, TinhTP, QuanHuyen, search, currPage, recodperpage), GetType(CMS_ClinicInfo))
    End Function
    Public Function CMS_Clinic_List_By_App(PortalConnect As String, PotarID As Integer, IsType As Integer, search As String, TinhTP As Integer, QuanHuyen As Integer, duongPho As String, hot As Boolean, latitude As Double, longitude As Double, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Clinic_List_By_App(PortalConnect, PotarID, IsType, search, TinhTP, QuanHuyen, duongPho, hot, latitude, longitude, currPage, recodperpage), GetType(CMS_ClinicInfo))
    End Function
    Public Function CMS_Clinic_List_By_Near(PortalConnect As String, PotarID As Integer, AppID As String, isType As Integer, Latitude As Double, Longitude As Double) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Clinic_List_By_Near(PortalConnect, PotarID, AppID, isType, Latitude, Longitude), GetType(CMS_ClinicInfo))
    End Function
#End Region
#Region "CMS_Crush"
    Public Function CMS_Crush_Get(PortalConnect As String, iD As Integer) As CMS_CrushInfo
        Return CBO.FillObject(Of CMS_CrushInfo)(DataProvider.Instance().CMS_Crush_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Crush_Check(PortalConnect As String, appID As String, dienThoai As String) As Integer
        Return DataProvider.Instance().CMS_Crush_Check(PortalConnect, appID, dienThoai)
    End Function
    Public Function CMS_Crush_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Crush_List(PortalConnect, portalId), GetType(CMS_CrushInfo))
    End Function
    Public Function CMS_Crush_Add(PortalConnect As String, obj As CMS_CrushInfo) As Integer
        Return DataProvider.Instance().CMS_Crush_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Crush_Update(PortalConnect As String, obj As CMS_CrushInfo)
        DataProvider.Instance().CMS_Crush_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Crush_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Crush_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Crush_List_By_App(PortalConnect As String, PotarID As Integer, AppID As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Crush_List_By_App(PortalConnect, PotarID, AppID, search, currPage, recodperpage), GetType(CMS_CrushInfo))
    End Function
    Public Function CMS_Crush_List_By_App_Follower(PortalConnect As String, PotarID As Integer, AppID As String, DienThoai As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Crush_List_By_App_Follower(PortalConnect, PotarID, AppID, DienThoai, currPage, recodperpage), GetType(CMS_CrushInfo))
    End Function
    Public Function CMS_Crush_check_Login(PortalConnect As String, PortalID As Integer, AppID As String) As Integer
        Return DataProvider.Instance().CMS_Crush_check_Login(PortalConnect, PortalID, AppID)
    End Function

#End Region
#Region "CMS_Cooking"
    Public Function CMS_Cooking_Get(PortalConnect As String, iD As Integer) As CMS_CookingInfo
        Return CBO.FillObject(Of CMS_CookingInfo)(DataProvider.Instance().CMS_Cooking_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Cooking_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Cooking_List(PortalConnect, portalId), GetType(CMS_CookingInfo))
    End Function
    Public Function CMS_Cooking_Add(PortalConnect As String, obj As CMS_CookingInfo) As Integer
        Return DataProvider.Instance().CMS_Cooking_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Cooking_Update(PortalConnect As String, obj As CMS_CookingInfo)
        DataProvider.Instance().CMS_Cooking_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Cooking_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Cooking_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Cooking_List_Search(PortalConnect As String, portalId As Integer, gID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Cooking_List_Search(PortalConnect, portalId, gID, search, currPage, recodperpage), GetType(CMS_CookingInfo))
    End Function
    Public Function CMS_Cooking_List_By_App(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer, fromTime As Integer, toTime As Integer, cateID As Integer, difficultLevel As String, mealType As String, cookingType As String, tasteType As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Cooking_List_By_App(PortalConnect, portalId, search, currPage, recodperpage, fromTime, toTime, cateID, difficultLevel, mealType, cookingType, tasteType), GetType(CMS_CookingInfo))
    End Function
    Public Function CMS_CookingD_List_By_App(PortalConnect As String, isType As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingD_List_By_App(PortalConnect, isType, search, currPage, recodperpage), GetType(CMS_CookingDInfo))
    End Function
    Public Sub CMS_Cooking_Update_View(PortalConnect As String, ID As Integer)
        DataProvider.Instance().CMS_Cooking_Update_View(PortalConnect, ID)
    End Sub
    Public Function CMS_CookingD_List_By_Type(PortalConnect As String, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingD_List_By_Type(PortalConnect, isType), GetType(CMS_CookingDInfo))
    End Function
#End Region
#Region "CMS_CookingC"
    Public Function CMS_CookingC_Get(PortalConnect As String, iD As Integer) As CMS_CookingCInfo
        Return CBO.FillObject(Of CMS_CookingCInfo)(DataProvider.Instance().CMS_CookingC_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CookingC_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingC_List(PortalConnect, portalId), GetType(CMS_CookingCInfo))
    End Function

    Public Function CMS_CookingC_Add(PortalConnect As String, obj As CMS_CookingCInfo) As Integer
        Return DataProvider.Instance().CMS_CookingC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CookingC_Update(PortalConnect As String, obj As CMS_CookingCInfo)
        DataProvider.Instance().CMS_CookingC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CookingC_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CookingC_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_CookingC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingC_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_CookingCInfo))
    End Function
#End Region
#Region "CMS_CookingO"
    Public Function CMS_CookingO_Get(PortalConnect As String, iD As Integer) As CMS_CookingOInfo
        Return CBO.FillObject(Of CMS_CookingOInfo)(DataProvider.Instance().CMS_CookingO_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CookingO_Get_By_CMS_Cooking(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingO_Get_By_CMS_Cooking(PortalConnect, iD), GetType(CookingOInfo))
    End Function

    Public Function CMS_CookingO_Add(PortalConnect As String, obj As CMS_CookingOInfo) As Integer
        Return DataProvider.Instance().CMS_CookingO_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CookingO_Update(PortalConnect As String, obj As CMS_CookingOInfo)
        DataProvider.Instance().CMS_CookingO_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CookingO_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CookingO_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_CookingO_List_Cooking(PortalConnect As String, CookingId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CookingO_List_Cooking(PortalConnect, CookingId), GetType(CMS_CookingOInfo))
    End Function
#End Region
#Region "CMS_BabyHeight"
    Public Function CMS_BabyHeight_Get(PortalConnect As String, iD As Integer) As CMS_BabyHeightInfo
        Return CBO.FillObject(Of CMS_BabyHeightInfo)(DataProvider.Instance().CMS_BabyHeight_Get(PortalConnect, iD))
    End Function
    Public Function CMS_BabyHeight_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BabyHeight_List(PortalConnect), GetType(CMS_BabyHeightInfo))
    End Function
    Public Function CMS_BabyHeight_List_By_Sex(PortalConnect As String, isSex As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BabyHeight_List_By_Sex(PortalConnect, isSex), GetType(CMS_BabyHeightInfo))
    End Function
    Public Function CMS_BabyHeight_Add(PortalConnect As String, obj As CMS_BabyHeightInfo) As Integer
        Return DataProvider.Instance().CMS_BabyHeight_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BabyHeight_Update(PortalConnect As String, obj As CMS_BabyHeightInfo)
        DataProvider.Instance().CMS_BabyHeight_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BabyHeight_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_BabyHeight_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_BabyHeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As CMS_BabyHeightInfo
        Return CBO.FillObject(Of CMS_BabyHeightInfo)(DataProvider.Instance().CMS_BabyHeight_Get_By_App(PortalConnect, month, IsSex))
    End Function
#End Region
#Region "CMS_BabyWeight"
    Public Function CMS_BabyWeight_Get(PortalConnect As String, iD As Integer) As CMS_BabyWeightInfo
        Return CBO.FillObject(Of CMS_BabyWeightInfo)(DataProvider.Instance().CMS_BabyWeight_Get(PortalConnect, iD))
    End Function
    Public Function CMS_BabyWeight_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BabyWeight_List(PortalConnect), GetType(CMS_BabyWeightInfo))
    End Function
    Public Function CMS_BabyWeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As CMS_BabyWeightInfo
        Return CBO.FillObject(Of CMS_BabyWeightInfo)(DataProvider.Instance().CMS_BabyWeight_Get_By_App(PortalConnect, month, IsSex))
    End Function
    Public Function CMS_BabyWeight_List_By_Sex(PortalConnect As String, isSex As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BabyWeight_List_By_Sex(PortalConnect, isSex), GetType(CMS_BabyWeightInfo))
    End Function
    Public Function CMS_BabyWeight_Add(PortalConnect As String, obj As CMS_BabyWeightInfo) As Integer
        Return DataProvider.Instance().CMS_BabyWeight_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BabyWeight_Update(PortalConnect As String, obj As CMS_BabyWeightInfo)
        DataProvider.Instance().CMS_BabyWeight_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BabyWeight_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_BabyWeight_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ClinicC"
    Public Function CMS_ClinicC_Get(PortalConnect As String, iD As Integer) As CMS_ClinicCInfo
        Return CBO.FillObject(Of CMS_ClinicCInfo)(DataProvider.Instance().CMS_ClinicC_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ClinicC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ClinicC_List(PortalConnect), GetType(CMS_ClinicCInfo))
    End Function

    Public Function CMS_ClinicC_Add(PortalConnect As String, obj As CMS_ClinicCInfo) As Integer
        Return DataProvider.Instance().CMS_ClinicC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ClinicC_Update(PortalConnect As String, obj As CMS_ClinicCInfo)
        DataProvider.Instance().CMS_ClinicC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ClinicC_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ClinicC_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_ClinicC_List_By_App(PortalConnect As String, portalId As Integer, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ClinicC_List_By_App(PortalConnect, portalId, iD, currPage, recodperpage), GetType(CMS_ClinicCInfo))
    End Function
#End Region
#Region "CMS_ClinicR"
    Public Function CMS_ClinicR_Get(PortalConnect As String, iD As Integer) As CMS_ClinicRInfo
        Return CBO.FillObject(Of CMS_ClinicRInfo)(DataProvider.Instance().CMS_ClinicR_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ClinicR_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ClinicR_List(PortalConnect, portalId), GetType(CMS_ClinicRInfo))
    End Function

    Public Function CMS_ClinicR_Add(PortalConnect As String, obj As CMS_ClinicRInfo) As Integer
        Return DataProvider.Instance().CMS_ClinicR_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ClinicR_Update(PortalConnect As String, obj As CMS_ClinicRInfo)
        DataProvider.Instance().CMS_ClinicR_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ClinicR_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ClinicR_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_MuiTiem"
    Public Function CMS_MuiTiem_Get(PortalConnect As String, iD As Integer) As CMS_MuiTiemInfo
        Return CBO.FillObject(Of CMS_MuiTiemInfo)(DataProvider.Instance().CMS_MuiTiem_Get(PortalConnect, iD))
    End Function
    Public Function CMS_MuiTiem_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MuiTiem_List(PortalConnect), GetType(CMS_MuiTiemInfo))
    End Function
    Public Function CMS_MuiTiem_Get_By_CMS_VacXin(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MuiTiem_Get_By_CMS_VacXin(PortalConnect, iD), GetType(CMS_MuiTiemInfo))
    End Function

    Public Function CMS_MuiTiem_Add(PortalConnect As String, obj As CMS_MuiTiemInfo) As Integer
        Return DataProvider.Instance().CMS_MuiTiem_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MuiTiem_Update(PortalConnect As String, obj As CMS_MuiTiemInfo)
        DataProvider.Instance().CMS_MuiTiem_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MuiTiem_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_MuiTiem_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_MuiTiem_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MuiTiem_List_By_App(PortalConnect, mID, appID, teID), GetType(CMS_MuiTiemInfo))
    End Function
#End Region
#Region "CMS_VacXin"
    Public Function CMS_VacXin_Get_TE(PortalConnect As String, mID As Integer, vxID As Integer, muiTiemID As Integer, teID As Integer) As CMS_VacXinInfo
        Return CBO.FillObject(Of CMS_VacXinInfo)(DataProvider.Instance().CMS_VacXin_Get_TE(PortalConnect, mID, vxID, muiTiemID, teID))
    End Function
    Public Function CMS_VacXin_Get(PortalConnect As String, iD As Integer) As CMS_VacXinInfo
        Return CBO.FillObject(Of CMS_VacXinInfo)(DataProvider.Instance().CMS_VacXin_Get(PortalConnect, iD))
    End Function
    Public Function CMS_VacXin_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VacXin_List(PortalConnect, portalId), GetType(CMS_VacXinInfo))
    End Function
    Public Function CMS_VacXin_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VacXin_List_By_App(PortalConnect, mID, appID, teID), GetType(CMS_VacXinInfo))
    End Function
    Public Function CMS_VacXin_Add(PortalConnect As String, obj As CMS_VacXinInfo) As Integer
        Return DataProvider.Instance().CMS_VacXin_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_VacXin_Update(PortalConnect As String, obj As CMS_VacXinInfo)
        DataProvider.Instance().CMS_VacXin_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_VacXin_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_VacXin_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Vacxin_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Vacxin_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_VacXinInfo))
    End Function
#End Region
#Region "CMS_DoanHinh"
    Public Function CMS_DoanHinh_Get(PortalConnect As String, iD As Integer) As CMS_DoanHinhInfo
        Return CBO.FillObject(Of CMS_DoanHinhInfo)(DataProvider.Instance().CMS_DoanHinh_Get(PortalConnect, iD))
    End Function
    Public Function CMS_DoanHinh_Get_By_App(PortalConnect As String, miD As Integer, level As Integer) As CMS_DoanHinhInfo
        Return CBO.FillObject(Of CMS_DoanHinhInfo)(DataProvider.Instance().CMS_DoanHinh_Get_By_App(PortalConnect, miD, level))
    End Function
    Public Function CMS_DoanHinh_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanHinh_List(PortalConnect, portalId), GetType(CMS_DoanHinhInfo))
    End Function
    Public Function CMS_DoanHinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanHinh_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DoanHinhInfo))
    End Function

    Public Function CMS_DoanHinh_Add(PortalConnect As String, obj As CMS_DoanHinhInfo) As Integer
        Return DataProvider.Instance().CMS_DoanHinh_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DoanHinh_Update(PortalConnect As String, obj As CMS_DoanHinhInfo)
        DataProvider.Instance().CMS_DoanHinh_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DoanHinh_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_DoanHinh_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_DoanHinh_Update_Quick(PortalConnect As String, iD As Integer, mucDo As Integer, soDiem As Integer, moDapAn As Integer, moChuCai As Integer, boChuCai As Integer)
        DataProvider.Instance().CMS_DoanHinh_Update_Quick(PortalConnect, iD, mucDo, soDiem, moDapAn, moChuCai, boChuCai)
    End Sub
    Public Function CMS_DoanHinh_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanHinh_List_Search(PortalConnect, portalID, search, currPage, recodperpage), GetType(CMS_DoanHinhInfo))
    End Function
#End Region
#Region "CMS_GameImg"
    Public Function CMS_GameImg_List_By_AppID(PortalConnect As String, portalId As Integer, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GameImg_List_By_AppID(PortalConnect, portalId, isOrder), GetType(CMS_GameImgInfo))
    End Function
    Public Function CMS_GameImg_Get_By_AppID(PortalConnect As String, appID As String, portalID As Integer) As CMS_GameImgInfo
        Return CBO.FillObject(Of CMS_GameImgInfo)(DataProvider.Instance().CMS_GameImg_Get_By_AppID(PortalConnect, appID, portalID))
    End Function
    Public Sub CMS_GameImg_Update_Level(PortalConnect As String, appID As String, isLevel As Integer, adPoint As Integer, portalID As Integer)
        DataProvider.Instance().CMS_GameImg_Update_Level(PortalConnect, appID, isLevel, adPoint, portalID)
    End Sub
    Public Sub CMS_GameImg_Update_DePoint(PortalConnect As String, appID As String, dePoint As Integer, portalID As Integer)
        DataProvider.Instance().CMS_GameImg_Update_DePoint(PortalConnect, appID, dePoint, portalID)
    End Sub
    Public Sub CMS_GameImg_Update_Point(PortalConnect As String, appID As String, Point As Integer, portalID As Integer)
        DataProvider.Instance().CMS_GameImg_Update_Point(PortalConnect, appID, Point, portalID)
    End Sub
    Public Sub CMS_GameImg_Update_Cup(PortalConnect As String, appID As String, isCup As Integer, portalID As Integer)
        DataProvider.Instance().CMS_GameImg_Update_Cup(PortalConnect, appID, isCup, portalID)
    End Sub
    Public Function CMS_GameImg_Add(PortalConnect As String, obj As CMS_GameImgInfo) As Integer
        Return DataProvider.Instance().CMS_GameImg_Add(PortalConnect, obj)
    End Function
    Public Function CMS_GameImg_Get_By_Level(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
        Return DataProvider.Instance().CMS_GameImg_Get_By_Level(PortalConnect, AppID, PortalID)
    End Function
#End Region
#Region "CMS_TreEm"
    Public Function CMS_TreEm_Get(PortalConnect As String, iD As Integer) As CMS_TreEmInfo
        Return CBO.FillObject(Of CMS_TreEmInfo)(DataProvider.Instance().CMS_TreEm_Get(PortalConnect, iD))
    End Function
    Public Function CMS_TreEm_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TreEm_List(PortalConnect, portalId), GetType(CMS_TreEmInfo))
    End Function
    Public Function CMS_TreEm_List_By_App(PortalConnect As String, portalId As Integer, AppId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TreEm_List_By_App(PortalConnect, portalId, AppId), GetType(CMS_TreEmInfo))
    End Function
    Public Function CMS_TreEm_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TreEm_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TreEmInfo))
    End Function
    Public Function CMS_TreEm_List_Search_Web(PortalConnect As String, PortalID As Integer, AppID As String, isOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TreEm_List_Search_Web(PortalConnect, PortalID, AppID, isOrder, search, currPage, recodperpage), GetType(CMS_TreEmInfo))
    End Function

    Public Function CMS_TreEm_Add(PortalConnect As String, obj As CMS_TreEmInfo) As Integer
        Return DataProvider.Instance().CMS_TreEm_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TreEm_Update(PortalConnect As String, obj As CMS_TreEmInfo)
        DataProvider.Instance().CMS_TreEm_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TreEm_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_TreEm_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Fr_PostGroup"
    Public Function CMS_Fr_PostGroup_List_By_App(PortalConnect As String, portalId As Integer, postID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_PostGroup_List_By_App(PortalConnect, portalId, postID, search, currPage, recodperpage), GetType(CMS_Fr_PostGroupInfo))
    End Function
    Public Function CMS_Fr_PostGroup_Get_By_AppID(PortalConnect As String, postID As Integer, appID As String, groupID As Integer) As CMS_Fr_PostGroupInfo
        Return CBO.FillObject(Of CMS_Fr_PostGroupInfo)(DataProvider.Instance().CMS_Fr_PostGroup_Get_By_AppID(PortalConnect, postID, appID, groupID))
    End Function

    Public Function CMS_Fr_PostGroup_Get(PortalConnect As String, postGroup_ID As Integer) As CMS_Fr_PostGroupInfo
        Return CBO.FillObject(Of CMS_Fr_PostGroupInfo)(DataProvider.Instance().CMS_Fr_PostGroup_Get(PortalConnect, postGroup_ID))
    End Function
    Public Function CMS_Fr_PostGroup_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_PostGroup_List(PortalConnect, portalId), GetType(CMS_Fr_PostGroupInfo))
    End Function
    Public Function CMS_Fr_PostGroup_List_By_Post(PortalConnect As String, portalId As Integer, postID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_PostGroup_List_By_Post(PortalConnect, portalId, postID), GetType(CMS_Fr_PostGroupInfo))
    End Function
    Public Function CMS_Fr_PostGroup_Add(PortalConnect As String, obj As CMS_Fr_PostGroupInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_PostGroup_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_PostGroup_Update(PortalConnect As String, obj As CMS_Fr_PostGroupInfo)
        DataProvider.Instance().CMS_Fr_PostGroup_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_PostGroup_Delete(PortalConnect As String, postGroup_ID As Integer)
        DataProvider.Instance().CMS_Fr_PostGroup_Delete(PortalConnect, postGroup_ID)
    End Sub
    Public Sub CMS_Fr_PostGroup_Delete_Group(PortalConnect As String, post_ID As Integer, groupID As String, portalID As Integer)
        DataProvider.Instance().CMS_Fr_PostGroup_Delete_Group(PortalConnect, post_ID, groupID, portalID)
    End Sub
#End Region
#Region "CMS_TiemChung"
    Public Function CMS_TiemChung_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, vxID As Integer, muiTiem As Integer) As CMS_TiemChungInfo
        Return CBO.FillObject(Of CMS_TiemChungInfo)(DataProvider.Instance().CMS_TiemChung_Get(PortalConnect, mID, appID, teID, vxID, muiTiem))
    End Function
    Public Function CMS_TiemChung_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TiemChung_List(PortalConnect, portalId), GetType(CMS_TiemChungInfo))
    End Function
    Public Function CMS_TiemChung_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TiemChung_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TiemChungInfo))
    End Function
    Public Function CMS_TiemChung_Add(PortalConnect As String, obj As CMS_TiemChungInfo) As Integer
        Return DataProvider.Instance().CMS_TiemChung_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TiemChung_Update(PortalConnect As String, iD As Integer, ngayTiem As DateTime, trangThai As Integer, LoGo As String)
        DataProvider.Instance().CMS_TiemChung_Update(PortalConnect, iD, ngayTiem, trangThai, LoGo)
    End Sub
    Public Sub CMS_TiemChung_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_TiemChung_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_MocRang"
    Public Function CMS_MocRang_Get(PortalConnect As String, appID As String, teID As Integer, rangSo As Integer) As CMS_MocRangInfo
        Return CBO.FillObject(Of CMS_MocRangInfo)(DataProvider.Instance().CMS_MocRang_Get(PortalConnect, appID, teID, rangSo))
    End Function
    Public Function CMS_MocRang_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MocRang_List(PortalConnect, portalId), GetType(CMS_MocRangInfo))
    End Function
    Public Function CMS_MocRang_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, teID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MocRang_List_By_AppID(PortalConnect, portalId, appID, teID), GetType(CMS_MocRangInfo))
    End Function
    Public Function CMS_MocRang_Add(PortalConnect As String, obj As CMS_MocRangInfo) As Integer
        Return DataProvider.Instance().CMS_MocRang_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MocRang_Update(PortalConnect As String, obj As CMS_MocRangInfo)
        DataProvider.Instance().CMS_MocRang_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MocRang_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_MocRang_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_KhamThai"
    Public Function CMS_KhamThai_Get(PortalConnect As String, iD As Integer) As CMS_KhamThaiInfo
        Return CBO.FillObject(Of CMS_KhamThaiInfo)(DataProvider.Instance().CMS_KhamThai_Get(PortalConnect, iD))
    End Function
    Public Function CMS_KhamThai_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhamThai_List(PortalConnect), GetType(CMS_KhamThaiInfo))
    End Function
    Public Function CMS_KhamThai_Add(PortalConnect As String, obj As CMS_KhamThaiInfo) As Integer
        Return DataProvider.Instance().CMS_KhamThai_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_KhamThai_Update(PortalConnect As String, obj As CMS_KhamThaiInfo)
        DataProvider.Instance().CMS_KhamThai_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_KhamThai_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_KhamThai_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_KhamThai_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhamThai_List_By_App(PortalConnect, mID, appID, teID), GetType(CMS_KhamThaiInfo))
    End Function
#End Region
#Region "CMS_KhamThaiD"
    Public Function CMS_KhamThaiD_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, ktID As Integer) As CMS_KhamThaiDInfo
        Return CBO.FillObject(Of CMS_KhamThaiDInfo)(DataProvider.Instance().CMS_KhamThaiD_Get(PortalConnect, mID, appID, teID, ktID))
    End Function
    Public Function CMS_KhamThaiD_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhamThaiD_List(PortalConnect, portalId), GetType(CMS_KhamThaiDInfo))
    End Function
    Public Function CMS_KhamThaiD_Add(PortalConnect As String, obj As CMS_KhamThaiDInfo) As Integer
        Return DataProvider.Instance().CMS_KhamThaiD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_KhamThaiD_Update(PortalConnect As String, iD As Integer, ngayKham As DateTime, trangThai As Integer)
        DataProvider.Instance().CMS_KhamThaiD_Update(PortalConnect, iD, ngayKham, trangThai)
    End Sub
    Public Sub CMS_KhamThaiD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_KhamThaiD_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_AnhBe"
    Public Function CMS_AnhBe_Get(PortalConnect As String, iD As Integer) As CMS_AnhBeInfo
        Return CBO.FillObject(Of CMS_AnhBeInfo)(DataProvider.Instance().CMS_AnhBe_Get(PortalConnect, iD))
    End Function
    Public Function CMS_AnhBe_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, find As String, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AnhBe_List_By_AppID(PortalConnect, mID, appID, teID, find, page, recod), GetType(CMS_AnhBeInfo))
    End Function

    Public Function CMS_AnhBe_Add(PortalConnect As String, obj As CMS_AnhBeInfo) As Integer
        Return DataProvider.Instance().CMS_AnhBe_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_AnhBe_Update(PortalConnect As String, obj As CMS_AnhBeInfo)
        DataProvider.Instance().CMS_AnhBe_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_AnhBe_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AnhBe_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_AnhBeD"
    Public Function CMS_AnhBeD_Get(PortalConnect As String, iD As Integer) As CMS_AnhBeDInfo
        Return CBO.FillObject(Of CMS_AnhBeDInfo)(DataProvider.Instance().CMS_AnhBeD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_AnhBeD_Get_By_CMS_AnhBe(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_AnhBeD_Get_By_CMS_AnhBe(PortalConnect, iD), GetType(CMS_AnhBeDInfo))
    End Function
    Public Sub CMS_AnhBeD_Delete_By_CMS_AnhBe(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AnhBeD_Delete_By_CMS_AnhBe(PortalConnect, iD)
    End Sub
    Public Function CMS_AnhBeD_Add(PortalConnect As String, obj As CMS_AnhBeDInfo) As Integer
        Return DataProvider.Instance().CMS_AnhBeD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_AnhBeD_Update(PortalConnect As String, obj As CMS_AnhBeDInfo)
        DataProvider.Instance().CMS_AnhBeD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_AnhBeD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_AnhBeD_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_TheoDoiTE"
    Public Function CMS_TheoDoiTE_Get(PortalConnect As String, iD As Integer) As CMS_TheoDoiTEInfo
        Return CBO.FillObject(Of CMS_TheoDoiTEInfo)(DataProvider.Instance().CMS_TheoDoiTE_Get(PortalConnect, iD))
    End Function
    Public Function CMS_TheoDoiTE_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, isType As Integer, page As Integer, recod As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_TheoDoiTE_List_By_AppID(PortalConnect, mID, appID, teID, isType, page, recod), GetType(CMS_TheoDoiTEInfo))
        Else
            CMS_TheoDoiTE_List_By_AppID = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_List_By_AppID", mID, appID, teID, isType, page, recod).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_TheoDoiTE_Add(PortalConnect As String, obj As CMS_TheoDoiTEInfo) As Integer
        Return DataProvider.Instance().CMS_TheoDoiTE_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TheoDoiTE_Update(PortalConnect As String, obj As CMS_TheoDoiTEInfo)
        DataProvider.Instance().CMS_TheoDoiTE_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TheoDoiTE_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_TheoDoiTE_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_CuDap"
    Public Function CMS_CuDap_Get(PortalConnect As String, iD As Integer) As CMS_CuDapInfo
        Return CBO.FillObject(Of CMS_CuDapInfo)(DataProvider.Instance().CMS_CuDap_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CuDap_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CuDap_List_By_AppID(PortalConnect, mID, appID, teID, page, recod), GetType(CMS_CuDapInfo))
    End Function
    Public Function CMS_CuDap_Add(PortalConnect As String, obj As CMS_CuDapInfo) As String
        Return DataProvider.Instance().CMS_CuDap_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CuDap_Update(PortalConnect As String, obj As CMS_CuDapInfo)
        DataProvider.Instance().CMS_CuDap_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CuDap_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CuDap_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_CuDapD"
    Public Function CMS_CuDapD_Get(PortalConnect As String, iD As Integer) As CMS_CuDapDInfo
        Return CBO.FillObject(Of CMS_CuDapDInfo)(DataProvider.Instance().CMS_CuDapD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CuDapD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CuDapD_List(PortalConnect), GetType(CMS_CuDapDInfo))
    End Function
    Public Function CMS_CuDapD_List_By_CID(PortalConnect As String, ciD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CuDapD_List_By_CID(PortalConnect, ciD), GetType(CMS_CuDapDInfo))
    End Function
    Public Function CMS_CuDapD_List_By_LanDem(PortalConnect As String, ciD As Integer, lanDem As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CuDapD_List_By_LanDem(PortalConnect, ciD, lanDem), GetType(CMS_CuDapDInfo))
    End Function
    Public Function CMS_CuDapD_Add(PortalConnect As String, obj As CMS_CuDapDInfo) As Integer
        Return DataProvider.Instance().CMS_CuDapD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CuDapD_Update(PortalConnect As String, obj As CMS_CuDapDInfo)
        DataProvider.Instance().CMS_CuDapD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CuDapD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CuDapD_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SurveyR"
    Public Function CMS_SurveyR_Get(PortalConnect As String, reply_ID As Integer) As CMS_SurveyRInfo
        Return CBO.FillObject(Of CMS_SurveyRInfo)(DataProvider.Instance().CMS_SurveyR_Get(PortalConnect, reply_ID))
    End Function
    Public Function CMS_SurveyR_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SurveyR_List(PortalConnect), GetType(CMS_SurveyRInfo))
    End Function
    Public Function CMS_SurveyR_Get_By_CMS_Survey(PortalConnect As String, survey_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SurveyR_Get_By_CMS_Survey(PortalConnect, survey_ID), GetType(CMS_SurveyRInfo))
    End Function
    Public Function CMS_SurveyR_List_Search(PortalConnect As String, SvID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SurveyR_List_Search(PortalConnect, SvID), GetType(CMS_SurveyRInfo))
    End Function
    Public Sub CMS_SurveyR_Update_Reply(PortalConnect As String, reply_ID As Integer)
        DataProvider.Instance().CMS_SurveyR_Update_Reply(PortalConnect, reply_ID)
    End Sub
    Public Function CMS_SurveyR_Add(PortalConnect As String, obj As CMS_SurveyRInfo) As Integer
        Return DataProvider.Instance().CMS_SurveyR_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SurveyR_Update(PortalConnect As String, obj As CMS_SurveyRInfo)
        DataProvider.Instance().CMS_SurveyR_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SurveyR_Delete(PortalConnect As String, reply_ID As Integer)
        DataProvider.Instance().CMS_SurveyR_Delete(PortalConnect, reply_ID)
    End Sub
#End Region
#Region "CMS_Survey"
    Public Function CMS_Survey_Get(PortalConnect As String, survey_ID As Integer) As CMS_SurveyInfo
        Return CBO.FillObject(Of CMS_SurveyInfo)(DataProvider.Instance().CMS_Survey_Get(PortalConnect, survey_ID))
    End Function
    Public Function CMS_Survey_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Survey_List(PortalConnect, portalId), GetType(CMS_SurveyInfo))
    End Function
    Public Function CMS_Survey_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Survey_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_SurveyInfo))
    End Function
    Public Function CMS_Survey_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, find As String, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Survey_List_By_AppID(PortalConnect, portalId, appID, find, page, recod), GetType(CMS_SurveyInfo))
    End Function
    Public Function CMS_Survey_Add(PortalConnect As String, obj As CMS_SurveyInfo) As Integer
        Return DataProvider.Instance().CMS_Survey_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Survey_Update(PortalConnect As String, obj As CMS_SurveyInfo)
        DataProvider.Instance().CMS_Survey_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Survey_Delete(PortalConnect As String, survey_ID As Integer)
        DataProvider.Instance().CMS_Survey_Delete(PortalConnect, survey_ID)
    End Sub
#End Region
#Region "CMS_SurveyU"
    Public Function CMS_SurveyU_Get(PortalConnect As String, iD As Integer) As CMS_SurveyUInfo
        Return CBO.FillObject(Of CMS_SurveyUInfo)(DataProvider.Instance().CMS_SurveyU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SurveyU_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SurveyU_List(PortalConnect, portalId), GetType(CMS_SurveyUInfo))
    End Function
    Public Function CMS_SurveyU_Add(PortalConnect As String, obj As CMS_SurveyUInfo) As Integer
        Return DataProvider.Instance().CMS_SurveyU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SurveyU_Update(PortalConnect As String, obj As CMS_SurveyUInfo)
        DataProvider.Instance().CMS_SurveyU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SurveyU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_SurveyU_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_KhamBenh"
    Public Function CMS_KhamBenh_Get(PortalConnect As String, iD As Integer) As CMS_KhamBenhInfo
        Return CBO.FillObject(Of CMS_KhamBenhInfo)(DataProvider.Instance().CMS_KhamBenh_Get(PortalConnect, iD))
    End Function
    Public Function CMS_KhamBenh_Get_By_CMS_SoKB(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhamBenh_Get_By_CMS_SoKB(PortalConnect, iD, page, recod), GetType(CMS_KhamBenhInfo))
    End Function
    Public Sub CMS_KhamBenh_Delete_By_CMS_SoKB(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_KhamBenh_Delete_By_CMS_SoKB(PortalConnect, iD)
    End Sub

    Public Function CMS_KhamBenh_Add(PortalConnect As String, obj As CMS_KhamBenhInfo) As Integer
        Return DataProvider.Instance().CMS_KhamBenh_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_KhamBenh_Update(PortalConnect As String, obj As CMS_KhamBenhInfo)
        DataProvider.Instance().CMS_KhamBenh_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_KhamBenh_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_KhamBenh_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SoKB"
    Public Function CMS_SoKB_Get(PortalConnect As String, iD As Integer) As CMS_SoKBInfo
        Return CBO.FillObject(Of CMS_SoKBInfo)(DataProvider.Instance().CMS_SoKB_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SoKB_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SoKB_List_By_AppID(PortalConnect, portalId, appID), GetType(CMS_SoKBInfo))
    End Function
    Public Function CMS_SoKB_Add(PortalConnect As String, obj As CMS_SoKBInfo) As Integer
        Return DataProvider.Instance().CMS_SoKB_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SoKB_Update(PortalConnect As String, obj As CMS_SoKBInfo)
        DataProvider.Instance().CMS_SoKB_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SoKB_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_SoKB_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Product"

    Public Function CMS_Product_List_By_ID(PortalConnect As String, iD As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_List_By_ID(PortalConnect, iD), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As CMS_ProductInfo
        Return CBO.FillObject(Of CMS_ProductInfo)(DataProvider.Instance().CMS_Product_Get_By_App(PortalConnect, portalID, appID, iD))
    End Function
    Public Function CMS_Product_Get(PortalConnect As String, iD As Integer) As CMS_ProductInfo
        Return CBO.FillObject(Of CMS_ProductInfo)(DataProvider.Instance().CMS_Product_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Product_Get_By_CMS_ProductGroup(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_Get_By_CMS_ProductGroup(PortalConnect, iD), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_Get_By_CMS_ProductBrand(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_Get_By_CMS_ProductBrand(PortalConnect, iD), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_List_ShopBy(PortalConnect As String, piD As Integer, groupID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_List_ShopBy(PortalConnect, piD, groupID, search, currPage, recodperpage), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_List_Brand(PortalConnect As String, piD As Integer, brandID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_List_Brand(PortalConnect, piD, brandID, search, currPage, recodperpage), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_List_Search(PortalConnect As String, portalId As Integer, groupId As Integer, brandID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Product_List_Search(PortalConnect, portalId, groupId, brandID, search, isOrder, currPage, recodperpage), GetType(CMS_ProductInfo))
    End Function
    Public Function CMS_Product_Get_ByCount(PortalConnect As String, brandID As Integer, iD As Integer) As Integer
        Return DataProvider.Instance().CMS_Product_Get_ByCount(PortalConnect, brandID, iD)
    End Function
    Public Function CMS_Product_Add(PortalConnect As String, obj As CMS_ProductInfo) As Integer
        Return DataProvider.Instance().CMS_Product_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Product_Update(PortalConnect As String, obj As CMS_ProductInfo)
        DataProvider.Instance().CMS_Product_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Product_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Product_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_Product_Update_IsView(PortalConnect As String, proID As Integer)
        DataProvider.Instance().CMS_Product_Update_IsView(PortalConnect, proID)
    End Sub
    Public Sub CMS_Product_Update_IsShare(PortalConnect As String, proID As Integer)
        DataProvider.Instance().CMS_Product_Update_IsShare(PortalConnect, proID)
    End Sub
    Public Sub CMS_Product_Update_IsLock(PortalConnect As String, proID As Integer, isLock As Boolean, lockedDate As DateTime, lockedUser As String)
        DataProvider.Instance().CMS_Product_Update_IsLock(PortalConnect, proID, isLock, lockedDate, lockedUser)
    End Sub
    Public Sub CMS_Product_Update_IsDelete(PortalConnect As String, proID As Integer, isDel As Boolean, delDate As DateTime, delUser As String)
        DataProvider.Instance().CMS_Product_Update_IsDelete(PortalConnect, proID, isDel, delDate, delUser)
    End Sub
#End Region
#Region "CMS_ProductBrand"
    Public Function CMS_ProductBrand_Get(PortalConnect As String, iD As Integer) As CMS_ProductBrandInfo
        Return CBO.FillObject(Of CMS_ProductBrandInfo)(DataProvider.Instance().CMS_ProductBrand_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ProductBrand_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductBrand_List_Search(PortalConnect, portalId, search, isOrder, currPage, recodperpage), GetType(CMS_ProductBrandInfo))
    End Function
    Public Function CMS_ProductBrand_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductBrand_List(PortalConnect, portalId), GetType(CMS_ProductBrandInfo))
    End Function
    Public Function CMS_ProductBrand_Add(PortalConnect As String, obj As CMS_ProductBrandInfo) As Integer
        Return DataProvider.Instance().CMS_ProductBrand_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ProductBrand_Update(PortalConnect As String, obj As CMS_ProductBrandInfo)
        DataProvider.Instance().CMS_ProductBrand_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ProductBrand_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductBrand_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ProductGroup"
    Public Function CMS_ProductGroup_Get(PortalConnect As String, iD As Integer) As CMS_ProductGroupInfo
        Return CBO.FillObject(Of CMS_ProductGroupInfo)(DataProvider.Instance().CMS_ProductGroup_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ProductGroup_List_By_ParentID(PortalConnect As String, portalId As Integer, parentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductGroup_List_By_ParentID(PortalConnect, portalId, parentID), GetType(CMS_ProductGroupInfo))
    End Function
    Public Function CMS_ProductGroup_Add(PortalConnect As String, obj As CMS_ProductGroupInfo) As Integer
        Return DataProvider.Instance().CMS_ProductGroup_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ProductGroup_Update(PortalConnect As String, obj As CMS_ProductGroupInfo)
        DataProvider.Instance().CMS_ProductGroup_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ProductGroup_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductGroup_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ProductImg"
    Public Function CMS_ProductImg_Get(PortalConnect As String, iD As Integer) As CMS_ProductImgInfo
        Return CBO.FillObject(Of CMS_ProductImgInfo)(DataProvider.Instance().CMS_ProductImg_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ProductImg_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductImg_Get_By_CMS_Product(PortalConnect, iD), GetType(CMS_ProductImgInfo))
    End Function
    Public Sub CMS_ProductImg_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductImg_Delete_By_CMS_Product(PortalConnect, iD)
    End Sub
    Public Function CMS_ProductImg_Add(PortalConnect As String, obj As CMS_ProductImgInfo) As Integer
        Return DataProvider.Instance().CMS_ProductImg_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ProductImg_Update(PortalConnect As String, obj As CMS_ProductImgInfo)
        DataProvider.Instance().CMS_ProductImg_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ProductImg_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductImg_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ProductRate"
    Public Function CMS_ProductRate_Get(PortalConnect As String, iD As Integer) As CMS_ProductRateInfo
        Return CBO.FillObject(Of CMS_ProductRateInfo)(DataProvider.Instance().CMS_ProductRate_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ProductRate_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductRate_Get_By_CMS_Product(PortalConnect, iD), GetType(CMS_ProductRateInfo))
    End Function
    Public Sub CMS_ProductRate_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductRate_Delete_By_CMS_Product(PortalConnect, iD)
    End Sub
    Public Function CMS_ProductRate_Add(PortalConnect As String, obj As CMS_ProductRateInfo) As Integer
        Return DataProvider.Instance().CMS_ProductRate_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ProductRate_Update(PortalConnect As String, obj As CMS_ProductRateInfo)
        DataProvider.Instance().CMS_ProductRate_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ProductRate_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductRate_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ProductComment"
    Public Function CMS_ProductComment_Get(PortalConnect As String, iD As Integer) As CMS_ProductCommentInfo
        Return CBO.FillObject(Of CMS_ProductCommentInfo)(DataProvider.Instance().CMS_ProductComment_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ProductComment_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductComment_Get_By_CMS_Product(PortalConnect, iD), GetType(CMS_ProductCommentInfo))
    End Function
    Public Function CMS_ProductComment_List_Search(PortalConnect As String, productID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProductComment_List_Search(PortalConnect, productID, search, currPage, recodperpage), GetType(CMS_ProductCommentInfo))
    End Function
    Public Function CMS_ProductComment_Add(PortalConnect As String, obj As CMS_ProductCommentInfo) As Integer
        Return DataProvider.Instance().CMS_ProductComment_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ProductComment_Update(PortalConnect As String, obj As CMS_ProductCommentInfo)
        DataProvider.Instance().CMS_ProductComment_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ProductComment_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ProductComment_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ShopBy"
    Public Function CMS_ShopBy_Count(PortalConnect As String, portalID As Integer) As Integer
        Return DataProvider.Instance().CMS_ShopBy_Count(PortalConnect, portalID)
    End Function
    Public Function CMS_ShopBy_Get(PortalConnect As String, iD As Integer) As CMS_ShopByInfo
        Return CBO.FillObject(Of CMS_ShopByInfo)(DataProvider.Instance().CMS_ShopBy_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ShopBy_Add(PortalConnect As String, obj As CMS_ShopByInfo) As String
        Return DataProvider.Instance().CMS_ShopBy_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ShopBy_Update(PortalConnect As String, obj As CMS_ShopByInfo)
        DataProvider.Instance().CMS_ShopBy_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ShopBy_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ShopBy_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_ShopBy_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, tinhTP As Integer, quanHuyen As Integer, tinhTrang As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ShopBy_List_Search(PortalConnect, portalId, search, isOrder, tinhTP, quanHuyen, tinhTrang, currPage, recodperpage), GetType(CMS_ShopByInfo))
    End Function
    Public Function CMS_ShopBy_List_AppID(PortalConnect As String, portalId As Integer, search As String, appID As String, currPage As Integer, recodperpage As Integer, trangThai As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ShopBy_List_AppID(PortalConnect, portalId, search, appID, currPage, recodperpage, trangThai), GetType(CMS_ShopByInfo))
    End Function
    Public Sub CMS_ShopBy_Update_TinhTrang(PortalConnect As String, iD As Integer, tinhTrang As Integer, lyDoHuy As String, nguoiHuy As String, ngayHuy As DateTime)
        DataProvider.Instance().CMS_ShopBy_Update_TinhTrang(PortalConnect, iD, tinhTrang, lyDoHuy, nguoiHuy, ngayHuy)
    End Sub
#End Region
#Region "CMS_ShopPro"
    Public Function CMS_ShopPro_Get(PortalConnect As String, iD As Integer) As CMS_ShopProInfo
        Return CBO.FillObject(Of CMS_ShopProInfo)(DataProvider.Instance().CMS_ShopPro_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ShopPro_Get_By_CMS_ShopBy(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ShopPro_Get_By_CMS_ShopBy(PortalConnect, iD), GetType(CMS_ShopProInfo))
    End Function
    Public Sub CMS_ShopPro_Delete_By_CMS_ShopBy(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ShopPro_Delete_By_CMS_ShopBy(PortalConnect, iD)
    End Sub
    Public Function CMS_ShopPro_Add(PortalConnect As String, obj As CMS_ShopProInfo) As Integer
        Return DataProvider.Instance().CMS_ShopPro_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ShopPro_Update(PortalConnect As String, obj As CMS_ShopProInfo)
        DataProvider.Instance().CMS_ShopPro_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ShopPro_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ShopPro_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Menu"
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
#Region "CMS_ImageN"
    Public Function CMS_ImageN_Get(PortalConnect As String, iD As Integer) As CMS_ImageNInfo
        Return CBO.FillObject(Of CMS_ImageNInfo)(DataProvider.Instance().CMS_ImageN_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ImageN_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageN_List(PortalConnect), GetType(CMS_ImageNInfo))
    End Function
    Public Function CMS_ImageN_List_Search(PortalConnect As String, portalID As Integer, cateID As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageN_List_Search(PortalConnect, portalID, cateID, search, currPage, recodperpage), GetType(CMS_ImageNInfo))
    End Function

    Public Function CMS_ImageN_Add(PortalConnect As String, obj As CMS_ImageNInfo) As Integer
        Return DataProvider.Instance().CMS_ImageN_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ImageN_Update(PortalConnect As String, obj As CMS_ImageNInfo)
        DataProvider.Instance().CMS_ImageN_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ImageN_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ImageN_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_ImageD"
    Public Function CMS_ImageD_Get(PortalConnect As String, iD As Integer) As CMS_ImageDInfo
        Return CBO.FillObject(Of CMS_ImageDInfo)(DataProvider.Instance().CMS_ImageD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_ImageD_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageD_List(PortalConnect, portalId), GetType(CMS_ImageDInfo))
    End Function
    Public Function CMS_ImageD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageD_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ImageDInfo))
    End Function
    Public Sub CMS_ImageD_Add(PortalConnect As String, obj As CMS_ImageDInfo)
        DataProvider.Instance().CMS_ImageD_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_ImageD_Update(PortalConnect As String, obj As CMS_ImageDInfo)
        DataProvider.Instance().CMS_ImageD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ImageD_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().CMS_ImageD_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_ImageD_List_ByImageN(PortalConnect As String, idKey As String, type As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageD_List_ByImageN(PortalConnect, idKey, type, top), GetType(CMS_ImageDInfo))
    End Function
    Public Function CMS_ImageD_List_Cate(PortalConnect As String, portalId As Integer, ID As Integer, type As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ImageD_List_Cate(PortalConnect, portalId, ID, type), GetType(CMS_ImageDInfo))
    End Function
#End Region
#Region "CMS_ChuyenGia"
    Public Function CMS_ChuyenGia_Get(PortalConnect As String, id As Integer) As CMS_ChuyenGiaInfo
        Return CBO.FillObject(Of CMS_ChuyenGiaInfo)(DataProvider.Instance().CMS_ChuyenGia_Get(PortalConnect, id))
    End Function
    Public Function CMS_ChuyenGia_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ChuyenGia_List(PortalConnect, portalId), GetType(CMS_ChuyenGiaInfo))
    End Function
    Public Function CMS_ChuyenGia_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ChuyenGia_List_Search(PortalConnect, portalId, search, currPage, recodperpage), GetType(CMS_ChuyenGiaInfo))
    End Function
    Public Function CMS_ChuyenGia_List_Search_Top(PortalConnect As String, PortalID As Integer, Top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ChuyenGia_List_Search_Top(PortalConnect, PortalID, Top), GetType(CMS_ChuyenGiaInfo))
    End Function

    Public Function CMS_ChuyenGia_Add(PortalConnect As String, obj As CMS_ChuyenGiaInfo) As Integer
        Return DataProvider.Instance().CMS_ChuyenGia_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ChuyenGia_Update(PortalConnect As String, obj As CMS_ChuyenGiaInfo)
        DataProvider.Instance().CMS_ChuyenGia_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ChuyenGia_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_ChuyenGia_Delete(PortalConnect, id)
    End Sub
#End Region
#Region "CMS_VanChuyen"
    Public Function CMS_VanChuyen_Get(PortalConnect As String, iD As Integer) As CMS_VanChuyenInfo
        Return CBO.FillObject(Of CMS_VanChuyenInfo)(DataProvider.Instance().CMS_VanChuyen_Get(PortalConnect, iD))
    End Function
    Public Function CMS_VanChuyen_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VanChuyen_List(PortalConnect), GetType(CMS_VanChuyenInfo))
    End Function
    Public Function CMS_VanChuyen_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VanChuyen_List_Search(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_VanChuyenInfo))
    End Function

    Public Function CMS_VanChuyen_Add(PortalConnect As String, obj As CMS_VanChuyenInfo) As Integer
        Return DataProvider.Instance().CMS_VanChuyen_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_VanChuyen_Update(PortalConnect As String, obj As CMS_VanChuyenInfo)
        DataProvider.Instance().CMS_VanChuyen_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_VanChuyen_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_VanChuyen_Delete(PortalConnect, iD)
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
#Region "CMS_Voucher"
    Public Function CMS_Voucher_Get(PortalConnect As String, iD As Integer) As CMS_VoucherInfo
        Return CBO.FillObject(Of CMS_VoucherInfo)(DataProvider.Instance().CMS_Voucher_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Voucher_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Voucher_List(PortalConnect, portalId), GetType(CMS_VoucherInfo))
    End Function
    Public Function CMS_Voucher_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, brandID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Voucher_List_Search(PortalConnect, portalID, search, isOrder, currPage, recodperpage, brandID), GetType(CMS_VoucherInfo))
    End Function
    Public Function CMS_Voucher_Add(PortalConnect As String, obj As CMS_VoucherInfo) As Integer
        Return DataProvider.Instance().CMS_Voucher_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Voucher_Update(PortalConnect As String, obj As CMS_VoucherInfo)
        DataProvider.Instance().CMS_Voucher_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Voucher_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Voucher_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_VoucherApp"
    Public Function CMS_VoucherApp_Get(PortalConnect As String, iD As Integer) As CMS_VoucherAppInfo
        Return CBO.FillObject(Of CMS_VoucherAppInfo)(DataProvider.Instance().CMS_VoucherApp_Get(PortalConnect, iD))
    End Function
    Public Function CMS_VoucherApp_List_AppID(PortalConnect As String, portalID As Integer, appID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VoucherApp_List_AppID(PortalConnect, portalID, appID, isOrder, currPage, recodperpage), GetType(CMS_VoucherAppInfo))
    End Function
    Public Function CMS_VoucherApp_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, voucherID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VoucherApp_List_Search(PortalConnect, portalID, search, isOrder, voucherID), GetType(CMS_VoucherAppInfo))
    End Function
    Public Function CMS_VoucherApp_Add(PortalConnect As String, obj As CMS_VoucherAppInfo) As Integer
        Return DataProvider.Instance().CMS_VoucherApp_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_VoucherApp_Update(PortalConnect As String, obj As CMS_VoucherAppInfo)
        DataProvider.Instance().CMS_VoucherApp_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_VoucherApp_Update_SuDung(PortalConnect As String, PortalID As Integer, voucherID As Integer, appID As String, suDung As Boolean, ngayDung As DateTime, donHang As Integer)
        DataProvider.Instance().CMS_VoucherApp_Update_SuDung(PortalConnect, PortalID, voucherID, appID, suDung, ngayDung, donHang)
    End Sub
    Public Sub CMS_VoucherApp_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_VoucherApp_Delete(PortalConnect, iD)
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
#Region "CMS_NewsVote"
    Public Function CMS_NewsVote_Get_NID(PortalConnect As String, nid As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsVote_Get_NID(PortalConnect, nid), GetType(CMS_NewsVoteInfo))
    End Function
    Public Function CMS_NewsVote_Add(PortalConnect As String, obj As CMS_NewsVoteInfo) As Integer
        Return DataProvider.Instance().CMS_NewsVote_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsVote_Delete(PortalConnect As String, newsV_ID As Integer)
        DataProvider.Instance().CMS_NewsVote_Delete(PortalConnect, newsV_ID)
    End Sub
#End Region
#Region "CMS_MetaSEO"
    Public Function CMS_MetaSEO_Get(PortalConnect As String, iD As Integer) As CMS_MetaSEOInfo
        Return CBO.FillObject(Of CMS_MetaSEOInfo)(DataProvider.Instance().CMS_MetaSEO_Get(PortalConnect, iD))
    End Function
    Public Function CMS_MetaSEO_Get_IDKey(PortalConnect As String, iDKey As String) As CMS_MetaSEOInfo
        Return CBO.FillObject(Of CMS_MetaSEOInfo)(DataProvider.Instance().CMS_MetaSEO_Get_IDKey(PortalConnect, iDKey))
    End Function
    Public Function CMS_MetaSEO_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MetaSEO_List(PortalConnect), GetType(CMS_MetaSEOInfo))
    End Function
    Public Function CMS_MetaSEO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MetaSEO_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_MetaSEOInfo))
    End Function

    Public Function CMS_MetaSEO_Add(PortalConnect As String, obj As CMS_MetaSEOInfo) As Integer
        Return DataProvider.Instance().CMS_MetaSEO_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MetaSEO_Update(PortalConnect As String, obj As CMS_MetaSEOInfo)
        DataProvider.Instance().CMS_MetaSEO_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MetaSEO_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_MetaSEO_Delete(PortalConnect, iD)
    End Sub
#End Region

End Class
