Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing
    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.Mobile", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_App"
    Public MustOverride Function CMS_App_Get_By_AppID(PortalConnect As String, PortalID As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_App_Get(PortalConnect As String, appKey As String) As IDataReader
    Public MustOverride Function CMS_App_List_Find(PortalConnect As String, PortalID As Integer, search As String) As IDataReader
    Public MustOverride Function CMS_App_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_App_List_Search(PortalConnect As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Sub CMS_App_Add(PortalConnect As String, obj As CMS_AppInfo)
    Public MustOverride Sub CMS_App_Update(PortalConnect As String, obj As CMS_AppInfo)
    Public MustOverride Sub CMS_App_Change(PortalConnect As String, AppID As String, NewID As String, PortalID As String)
    Public MustOverride Sub CMS_App_Delete(PortalConnect As String, appKey As String)
    Public MustOverride Sub CMS_App_Remove(PortalConnect As String, appID As String, PortalID As Integer)

    Public MustOverride Function CMS_App_Check(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
    Public MustOverride Sub CMS_App_Update_Point(PortalConnect As String, appID As String, point As Integer, history As String, portalID As Integer)
#End Region
#Region "CMS_News"
    Public MustOverride Function CMS_News_Get(PortalConnect As String, newsID As Integer) As IDataReader
    Public MustOverride Function CMS_News_List(PortalConnect As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_AppFind(PortalConnect As String, portalID As Integer, search As String, cateID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Search_Top_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Search_Block_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, IsFlag As Integer, Status As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Search_Top_View(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Search_Cate_web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
    Public MustOverride Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
    Public MustOverride Sub CMS_News_Delete(PortalConnect As String, newsID As Integer)
    Public MustOverride Sub CMS_News_Update_Status(PortalConnect As String, NewsID As Integer, Status As Integer, UserName As String, update As DateTime)
    Public MustOverride Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
    Public MustOverride Sub CMS_News_Update_Like(PortalConnect As String, newsID As Integer)
    Public MustOverride Sub CMS_News_Update_View(PortalConnect As String, newsID As Integer)
    Public MustOverride Sub CMS_News_Update_Contents(PortalConnect As String, newsID As Integer, Contents As String)
    Public MustOverride Sub CMS_News_Update_Tags(PortalConnect As String, NewsID As Integer, Tags As String)
    Public MustOverride Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Home_Cate(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As IDataReader


#End Region
#Region "CMS_NewsTag"
    Public MustOverride Function CMS_NewsTag_Get(PortalConnect As String, iD As Long) As IDataReader
    Public MustOverride Function CMS_NewsTag_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NewsTag_Add(PortalConnect As String, obj As CMS_NewsTagInfo) As Integer
    Public MustOverride Sub CMS_NewsTag_Update(PortalConnect As String, obj As CMS_NewsTagInfo)
    Public MustOverride Function CMS_NewsTag_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsTag_Delete(PortalConnect As String, iD As Long)
#End Region
#Region "CMS_NewVersion"
    Public MustOverride Function CMS_NewVersion_Get(PortalConnect As String, version_ID As Integer) As IDataReader
    Public MustOverride Function CMS_NewVersion_Add(PortalConnect As String, obj As CMS_NewVersionInfo) As Integer
    Public MustOverride Function CMS_NewVersion_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As IDataReader
    Public MustOverride Sub CMS_NewVersion_Delete(PortalConnect As String, version_ID As Integer)
#End Region
#Region "CMS_Video"
    Public MustOverride Function CMS_Video_Get(PortalConnect As String, video_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Video_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Video_List_App(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_Video_List_Home(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_Video_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As IDataReader
    Public MustOverride Function CMS_Video_Add(PortalConnect As String, obj As CMS_VideoInfo) As Integer
    Public MustOverride Sub CMS_Video_Update(PortalConnect As String, obj As CMS_VideoInfo)
    Public MustOverride Sub CMS_Video_Delete(PortalConnect As String, video_ID As Integer)
    Public MustOverride Sub CMS_Video_Update_Like(PortalConnect As String, VideoID As Integer, isLike As Integer)
    Public MustOverride Sub CMS_Video_Update_Bad(PortalConnect As String, VideoID As Integer, isBad As Integer)
    Public MustOverride Sub CMS_Video_Update_View(PortalConnect As String, VideoID As Integer)
    Public MustOverride Sub CMS_Video_Update_Status(PortalConnect As String, VideoID As Integer, Status As Integer, UserName As String, update As DateTime)
#End Region
#Region "CMS_AppLog"
    Public MustOverride Function CMS_AppLog_Get(PortalConnect As String, token As String, appID As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_AppLog_Get_Login(PortalConnect As String, appID As String, token As String, isSystem As Integer, portalID As Integer) As Integer
    Public MustOverride Function CMS_AppLog_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_AppLog_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_AppLog_ListToken(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_AppLog_Add(PortalConnect As String, obj As CMS_AppLogInfo) As Integer
    Public MustOverride Sub CMS_AppLog_Update_LogEnd(PortalConnect As String, token As String, appID As String, logEnd As DateTime, portalID As Integer)
    Public MustOverride Sub CMS_AppLog_Delete(PortalConnect As String, id As String, appID As String)
#End Region
#Region "CMS_FCM"
    Public MustOverride Function CMS_FCM_Get(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_FCM_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_FCM_Add(PortalConnect As String, obj As CMS_FCMInfo) As Integer
    Public MustOverride Sub CMS_FCM_Delete(PortalConnect As String, token As String, appID As String, isSystem As Integer, portalID As Integer)
#End Region
#Region "CMS_Portals"
    Public MustOverride Function CMS_Portals_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Portals_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Portals_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Portals_Add(PortalConnect As String, obj As CMS_PortalsInfo) As Integer
    Public MustOverride Sub CMS_Portals_Update(PortalConnect As String, obj As CMS_PortalsInfo)
    Public MustOverride Sub CMS_Portals_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Category"
    Public MustOverride Function CMS_Category_Get_By_ParentId(PortalConnect As String, PortalId As Integer, isType As Integer, ParentId As Integer) As IDataReader
    Public MustOverride Function CMS_Category_Get_By_ParentId_Null(PortalConnect As String, PortalId As Integer, isType As Integer) As IDataReader
    Public MustOverride Function CMS_Category_Get(PortalConnect As String, categoryID As Integer) As IDataReader
    Public MustOverride Function CMS_Category_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Category_Add(PortalConnect As String, obj As CMS_CategoryInfo) As Integer
    Public MustOverride Sub CMS_Category_Update(PortalConnect As String, obj As CMS_CategoryInfo)
    Public MustOverride Sub CMS_Category_Delete(PortalConnect As String, categoryID As Integer)
    Public MustOverride Sub CMS_Category_Update_Order(PortalConnect As String, categoryid As Integer, Orders As Integer)
    Public MustOverride Function CMS_Category_Get_TabPath(PortalConnect As String, categoryid As Integer) As IDataReader
    Public MustOverride Function CMS_Category_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1) As IDataReader
    Public MustOverride Function CMS_Category_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_Category_Get_By_TabPath(PortalConnect As String, TabPath As String, tabID As Integer, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_Category_List_App(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer, parentID As Integer, isType As Integer) As IDataReader


#End Region
#Region "CMS_Group"
    Public MustOverride Function CMS_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
    Public MustOverride Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
    Public MustOverride Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_GroupD"
    Public MustOverride Function CMS_GroupD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_GroupD_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_GroupD_Add(PortalConnect As String, obj As CMS_GroupDInfo) As Integer
    Public MustOverride Sub CMS_GroupD_Update(PortalConnect As String, obj As CMS_GroupDInfo)
    Public MustOverride Function CMS_GroupD_Get_By_CMS_Group(PortalConnect As String, portalID As Integer, GroupiD As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_GroupD_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_GroupD_Update_Active(PortalConnect As String, iD As Integer, isActive As Boolean)
    Public MustOverride Sub CMS_GroupD_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
    Public MustOverride Sub CMS_GroupD_Update_Bad(PortalConnect As String, iD As Integer, isBad As Integer)
    Public MustOverride Function CMS_GroupD_List_Search(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_GroupD_List_App(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_GroupD_Update_Refresh(PortalConnect As String, iD As Integer, RefreshFrom As DateTime, RefreshTo As DateTime, RefreshUser As String)

#End Region
#Region "CMS_Chapter"
    Public MustOverride Function CMS_Chapter_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Chapter_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Chapter_Add(PortalConnect As String, obj As CMS_ChapterInfo) As Integer
    Public MustOverride Sub CMS_Chapter_Update(PortalConnect As String, obj As CMS_ChapterInfo)
    Public MustOverride Function CMS_Chapter_Get_By_CMS_Story(CMS_Chapter_List_By_App As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chapter_Frist_Page(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Chapter_Next_Page(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chapter_Download(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Chapter_List_By_App(PortalConnect As String, iD As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_Chapter_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Chapter_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Chapter_Update_View(PortalConnect As String, iD As Integer, storyID As Integer)
#End Region
#Region "CMS_Story"
    Public MustOverride Function CMS_Story_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Story_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Story_Add(PortalConnect As String, obj As CMS_StoryInfo) As Integer
    Public MustOverride Sub CMS_Story_Update(PortalConnect As String, obj As CMS_StoryInfo)
    Public MustOverride Sub CMS_Story_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Story_List_App(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Story_List_Search(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, tacGia As String, Order As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Story_List_By_Author(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_Story_Update_View(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Story_Update_HotCate(PortalConnect As String, iD As Integer, hotCate As Boolean)
    Public MustOverride Sub CMS_Story_Update_Public(PortalConnect As String, iD As Integer, isPublic As Boolean)
    Public MustOverride Sub CMS_Story_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
    Public MustOverride Function CMS_Story_List_Other(PortalConnect As String, portalID As Integer, Search As String, StoryID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader


#End Region
#Region "CMS_StoryFB"
    Public MustOverride Function CMS_StoryFB_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_StoryFB_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_StoryFB_Add(PortalConnect As String, obj As CMS_StoryFBInfo) As Integer
    Public MustOverride Sub CMS_StoryFB_Update(PortalConnect As String, obj As CMS_StoryFBInfo)
    Public MustOverride Function CMS_StoryFB_Get_By_CMS_Story(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_StoryFB_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_StoryFB_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_StoryFB_Update_Lock(PortalConnect As String, iD As Integer, isLock As Integer)
#End Region
#Region "CMS_StoryC"
    Public MustOverride Function CMS_StoryC_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_StoryC_List(PortalConnect As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_StoryC_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_StoryC_Add(PortalConnect As String, obj As CMS_StoryCInfo) As Integer
    Public MustOverride Sub CMS_StoryC_Update(PortalConnect As String, obj As CMS_StoryCInfo)
    Public MustOverride Sub CMS_StoryC_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_StoryP"
    Public MustOverride Function CMS_StoryP_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_StoryP_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_StoryP_Add(PortalConnect As String, obj As CMS_StoryPInfo) As Integer
    Public MustOverride Sub CMS_StoryP_Update(PortalConnect As String, obj As CMS_StoryPInfo)
    Public MustOverride Function CMS_StoryP_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_StoryP_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_StoryP_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_StoryD"
    Public MustOverride Function CMS_StoryD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_StoryD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_StoryD_Add(PortalConnect As String, obj As CMS_StoryDInfo) As Integer
    Public MustOverride Sub CMS_StoryD_Update(PortalConnect As String, obj As CMS_StoryDInfo)
    Public MustOverride Function CMS_StoryD_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_StoryD_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_StoryD_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_AdMob"
    Public MustOverride Function CMS_AdMob_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_AdMob_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_AdMob_List_Search(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_AdMob_Add(PortalConnect As String, obj As CMS_AdMobInfo) As Integer
    Public MustOverride Sub CMS_AdMob_Update(PortalConnect As String, obj As CMS_AdMobInfo)
    Public MustOverride Function CMS_AdMob_Get_By_CMS_Portals(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_AdMob_Delete_By_CMS_Portals(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_AdMob_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Advertise"
    Public MustOverride Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As IDataReader
    Public MustOverride Function CMS_Advertise_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Advertise_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PortalID As Integer) As IDataReader
    Public MustOverride Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Function CMS_Advertise_List_Home_Local(PortalConnect As String, PortalID As Integer, Top As Integer, pageLocal As Integer) As IDataReader
    Public MustOverride Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, Top As Integer) As IDataReader
    Public MustOverride Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
    Public MustOverride Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
    Public MustOverride Sub CMS_Advertise_Update_Click(PortalConnect As String, advertise_ID As String)
    Public MustOverride Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
#End Region
#Region "CMS_AdvertiseP"
    Public MustOverride Function CMS_AdvertiseP_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_AdvertiseP_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_AdvertiseP_Add(PortalConnect As String, obj As CMS_AdvertisePInfo) As Integer
    Public MustOverride Sub CMS_AdvertiseP_Update(PortalConnect As String, obj As CMS_AdvertisePInfo)
    Public MustOverride Function CMS_AdvertiseP_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As IDataReader
    Public MustOverride Sub CMS_AdvertiseP_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_AdvertiseP_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String)

#End Region
#Region "CMS_AdvertiseL"
    Public MustOverride Function CMS_AdvertiseL_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_AdvertiseL_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_AdvertiseL_Add(PortalConnect As String, obj As CMS_AdvertiseLInfo) As Integer
    Public MustOverride Sub CMS_AdvertiseL_Update(PortalConnect As String, obj As CMS_AdvertiseLInfo)
    Public MustOverride Function CMS_AdvertiseL_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As IDataReader
    Public MustOverride Sub CMS_AdvertiseL_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_AdvertiseL_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String, pageLocal As Integer)

#End Region
#Region "CMS_Notify"
    Public MustOverride Function CMS_Notify_Get_PortalID(PortalConnect As String, PortalID As Integer, types As Integer) As IDataReader
    Public MustOverride Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As IDataReader
    Public MustOverride Function CMS_Notify_List_Search(PortalConnect As String, search As String, PortalID As Integer, types As Integer, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Notify_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo)
    Public MustOverride Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
    Public MustOverride Sub CMS_Notify_Update_Active(PortalConnect As String, notify_ID As String, isActive As Boolean)
    Public MustOverride Sub CMS_Notify_Delete(PortalConnect As String, notify_ID As String)
    Public MustOverride Function CMS_Notify_Send_Notifycation(PortalConnect As String, PortalID As Integer, startDay As Integer, NotifyID As String, sendList As String) As IDataReader
#End Region
#Region "CMS_NotiLog"
    Public MustOverride Function CMS_NotiLog_Get(PortalConnect As String, notiLog_ID As Integer) As IDataReader
    Public MustOverride Function CMS_NotiLog_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NotiLog_Add(PortalConnect As String, obj As CMS_NotiLogInfo) As Integer
    Public MustOverride Sub CMS_NotiLog_Update(PortalConnect As String, obj As CMS_NotiLogInfo)
    Public MustOverride Function CMS_NotiLog_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As IDataReader
    Public MustOverride Sub CMS_NotiLog_Delete(PortalConnect As String, notiLog_ID As Integer)
#End Region
#Region "CMS_NotiSend"
    Public MustOverride Sub CMS_NotiSend_Register(PortalConnect As String, appID As String, portalID As Integer)
    Public MustOverride Function CMS_NotiSend_Get(PortalConnect As String, notiSend_ID As Integer) As IDataReader
    Public MustOverride Function CMS_NotiSend_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NotiSend_Add(PortalConnect As String, obj As CMS_NotiSendInfo) As Integer
    Public MustOverride Sub CMS_NotiSend_Update(PortalConnect As String, obj As CMS_NotiSendInfo)
    Public MustOverride Function CMS_NotiSend_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As IDataReader
    Public MustOverride Sub CMS_NotiSend_Delete(PortalConnect As String, notiSend_ID As Integer)
    Public MustOverride Function CMS_NotiSend_List_Search(PortalConnect As String, Notify_ID As String, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime, tinhTrang As Integer) As IDataReader
    Public MustOverride Sub CMS_NotiSend_Update_TinhTrang_Flag(PortalConnect As String, portalID As Integer, flags As String, idKey As String)
    Public MustOverride Sub CMS_NotiSend_Update_TinhTrang(PortalConnect As String, notiSend_ID As Integer, tinhTrang As Integer)
    Public MustOverride Sub CMS_NotiSend_Update_TinhTrang_Read(PortalConnect As String, portalID As Integer, appID As String, tinhTrang As Integer)
    Public MustOverride Function CMS_NotiSend_List_By_AppID(PortalConnect As String, AppID As String, types As Integer, IdKey As String, currPage As Integer, recodperpage As Integer, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_NotiSend_List_By_AppID_News(PortalConnect As String, AppID As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_NotiSend_UnRead_AppID(PortalConnect As String, appID As String, portalID As Integer) As Integer

#End Region
#Region "CMS_Setups"
    Public MustOverride Function CMS_Setups_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function CMS_Setups_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Setups_Get_By_Name(PortalConnect As String, settingName As String) As IDataReader
    Public MustOverride Sub CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
    Public MustOverride Sub CMS_Setups_Update(PortalConnect As String, obj As CMS_SetupsInfo)
    Public MustOverride Sub CMS_Setups_Delete(PortalConnect As String, iD As String)
#End Region
#Region "CMS_Block"
    Public MustOverride Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As IDataReader
    Public MustOverride Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As IDataReader
#End Region
#Region "CMS_RegEmail"
    Public MustOverride Function CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime) As String
    Public MustOverride Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_Fr_Notify"
    Public MustOverride Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
    Public MustOverride Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
    Public MustOverride Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Fr_Notify_List_New(PortalConnect As String, PortalID As Integer, appID As String, flags As String) As Integer
    Public MustOverride Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, PortalID As Integer, appID As String, flags As String)
    Public MustOverride Sub CMS_Fr_Notify_ReadAll(PortalConnect As String, PortalID As Integer, appID As String)
#End Region
#Region "CMS_Fr_Comment"
    Public MustOverride Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List_Admin(PortalConnect As String, postID As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List_Top(PortalConnect As String, postID As Integer, Top As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
    Public MustOverride Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
    Public MustOverride Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
    Public MustOverride Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
#End Region
#Region "CMS_Fr_Likes"
    Public MustOverride Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Likes_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
    Public MustOverride Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
    Public MustOverride Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
#End Region
#Region "CMS_Fr_Post"
    Public MustOverride Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Search(PortalConnect As String, PortalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Group(PortalConnect As String, PortalID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, PortalID As Integer, GroupID As Integer, AppID As String, lock As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_By_AppTE(PortalConnect As String, PortalID As Integer, appID As String, teID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_By_App(PortalConnect As String, PortalID As Integer, appID As String, isOder As Integer, search As String, GroupID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Admin(PortalConnect As String, PortalID As Integer, GroupID As Integer, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Admin_lock(PortalConnect As String, PortalID As Integer, appID As String, isLock As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
    Public MustOverride Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
    Public MustOverride Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
    Public MustOverride Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
    Public MustOverride Sub CMS_Fr_Post_Update_IsBad(PortalConnect As String, post_ID As Integer)

#End Region
#Region "CMS_Fr_SharePost"
    Public MustOverride Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_SharePost_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
    Public MustOverride Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
    Public MustOverride Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_Fr_ShareUser"
    Public MustOverride Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
    Public MustOverride Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
    Public MustOverride Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_Fr_FileAttach"
    Public MustOverride Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
    Public MustOverride Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
    Public MustOverride Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
#End Region
#Region "CMS_Fr_Group"
    Public MustOverride Function CMS_Fr_Group_Get_By_AppID(PortalConnect As String, iD As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Group_List_ByIsType(PortalConnect As String, isType As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
    Public MustOverride Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
    Public MustOverride Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Fr_Group_List_TK(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_TK(PortalConnect As String, PortalID As Integer, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_ThongKe(PortalConnect As String, PortalID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_NguoiDang(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_App_List_Admin(PortalConnect As String, PortalID As Integer, Search As String, isOrder As Integer, isSystem As Integer, tinhTP As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_GroupTV(PortalConnect As String, PortalID As Integer, ID As Integer) As IDataReader
    Public MustOverride Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)
    Public MustOverride Function CMS_AppID_List_Group_Select(PortalConnect As String, PortalID As Integer, gID As String, AppID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader



#End Region
#Region "CMS_Fr_GroupU"
    Public MustOverride Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_GroupU_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
    Public MustOverride Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
    Public MustOverride Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_GroupU_Get_By_Group(PortalConnect As String, GroupID As Integer, AppID As String) As IDataReader
    Public MustOverride Sub CMS_Fr_GroupU_Remove_AppID(PortalConnect As String, groupID As Integer, appID As String)
    Public MustOverride Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Fr_GroupU_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer)

#End Region
#Region "CMS_Contact"
    Public MustOverride Function CMS_Contact_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Contact_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_Contact_Update_Status(PortalConnect As String, Optional id As Integer = 1, Optional status As Boolean = 1)
    Public MustOverride Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PageIndex As Integer, PageSize As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Contact_Add(PortalConnect As String, obj As CMS_ContactInfo) As Integer
    Public MustOverride Sub CMS_Contact_Update(PortalConnect As String, obj As CMS_ContactInfo)
    Public MustOverride Sub CMS_Contact_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Food"
    Public MustOverride Function CMS_Food_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Food_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Food_List_App(PortalConnect As String, portalID As Integer, search As String, category As Integer, currPage As Integer, recodperpage As Integer, trangThai As String, giaiDoan As Integer) As IDataReader
    Public MustOverride Function CMS_Food_Add(PortalConnect As String, obj As CMS_FoodInfo) As Integer
    Public MustOverride Sub CMS_Food_Update(PortalConnect As String, obj As CMS_FoodInfo)
    Public MustOverride Sub CMS_Food_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Food_List_Search(PortalConnect As String, portalID As Integer, FoodIC As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_FoodC"
    Public MustOverride Function CMS_FoodC_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_FoodC_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_FoodC_Add(PortalConnect As String, obj As CMS_FoodCInfo) As Integer
    Public MustOverride Sub CMS_FoodC_Update(PortalConnect As String, obj As CMS_FoodCInfo)
    Public MustOverride Sub CMS_FoodC_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_FoodC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_Clinic"
    Public MustOverride Function CMS_Clinic_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Clinic_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Clinic_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Clinic_Add(PortalConnect As String, obj As CMS_ClinicInfo) As Integer
    Public MustOverride Sub CMS_Clinic_Update(PortalConnect As String, obj As CMS_ClinicInfo)
    Public MustOverride Sub CMS_Clinic_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Clinic_List_Search(PortalConnect As String, PotarID As Integer, IsOder As Integer, TinhTP As Integer, QuanHuyen As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Clinic_List_By_App(PortalConnect As String, PotarID As Integer, IsType As Integer, search As String, TinhTP As Integer, QuanHuyen As Integer, duongPho As String, hot As Boolean, latitude As Double, longitude As Double, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Clinic_List_By_Near(PortalConnect As String, PotarID As Integer, AppID As String, isType As Integer, Latitude As Double, Longitude As Double) As IDataReader

#End Region
#Region "CMS_Crush"
    Public MustOverride Function CMS_Crush_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Crush_Check(PortalConnect As String, appID As String, dienThoai As String) As Integer
    Public MustOverride Function CMS_Crush_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Crush_Add(PortalConnect As String, obj As CMS_CrushInfo) As Integer
    Public MustOverride Sub CMS_Crush_Update(PortalConnect As String, obj As CMS_CrushInfo)
    Public MustOverride Sub CMS_Crush_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Crush_List_By_App(PortalConnect As String, portalId As Integer, AppiD As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Crush_List_By_App_Follower(PortalConnect As String, portalId As Integer, AppiD As String, DienThoai As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Crush_check_Login(PortalConnect As String, PortalID As Integer, AppID As String) As Integer



#End Region
#Region "CMS_Cooking"
    Public MustOverride Function CMS_Cooking_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Cooking_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Cooking_Add(PortalConnect As String, obj As CMS_CookingInfo) As Integer
    Public MustOverride Sub CMS_Cooking_Update(PortalConnect As String, obj As CMS_CookingInfo)
    Public MustOverride Sub CMS_Cooking_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Cooking_List_Search(PortalConnect As String, portalId As Integer, giD As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Cooking_List_By_App(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer, fromTime As Integer, toTime As Integer, cateID As Integer, difficultLevel As String, mealType As String, cookingType As String, tasteType As String) As IDataReader
    Public MustOverride Function CMS_CookingD_List_By_App(PortalConnect As String, isType As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_Cooking_Update_View(PortalConnect As String, ID As Integer)
    Public MustOverride Function CMS_CookingD_List_By_Type(PortalConnect As String, IsType As Integer) As IDataReader



#End Region
#Region "CMS_CookingC"
    Public MustOverride Function CMS_CookingC_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CookingC_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_CookingC_Add(PortalConnect As String, obj As CMS_CookingCInfo) As Integer
    Public MustOverride Sub CMS_CookingC_Update(PortalConnect As String, obj As CMS_CookingCInfo)
    Public MustOverride Sub CMS_CookingC_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_CookingC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_CookingO"

    Public MustOverride Function CMS_CookingO_Get_By_CMS_Cooking(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CookingO_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CookingO_Add(PortalConnect As String, obj As CMS_CookingOInfo) As Integer
    Public MustOverride Sub CMS_CookingO_Update(PortalConnect As String, obj As CMS_CookingOInfo)
    Public MustOverride Sub CMS_CookingO_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_CookingO_List_Cooking(PortalConnect As String, CookingId As Integer) As IDataReader


#End Region
#Region "CMS_BabyHeight"
    Public MustOverride Function CMS_BabyHeight_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_BabyHeight_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BabyHeight_List_By_Sex(PortalConnect As String, isSex As Integer) As IDataReader

    Public MustOverride Function CMS_BabyHeight_Add(PortalConnect As String, obj As CMS_BabyHeightInfo) As Integer
    Public MustOverride Sub CMS_BabyHeight_Update(PortalConnect As String, obj As CMS_BabyHeightInfo)
    Public MustOverride Sub CMS_BabyHeight_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_BabyHeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As IDataReader

#End Region
#Region "CMS_BabyWeight"
    Public MustOverride Function CMS_BabyWeight_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_BabyWeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As IDataReader
    Public MustOverride Function CMS_BabyWeight_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BabyWeight_List_By_Sex(PortalConnect As String, isSex As Integer) As IDataReader
    Public MustOverride Function CMS_BabyWeight_Add(PortalConnect As String, obj As CMS_BabyWeightInfo) As Integer
    Public MustOverride Sub CMS_BabyWeight_Update(PortalConnect As String, obj As CMS_BabyWeightInfo)
    Public MustOverride Sub CMS_BabyWeight_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ClinicR"
    Public MustOverride Function CMS_ClinicR_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ClinicR_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ClinicR_Add(PortalConnect As String, obj As CMS_ClinicRInfo) As Integer
    Public MustOverride Sub CMS_ClinicR_Update(PortalConnect As String, obj As CMS_ClinicRInfo)
    Public MustOverride Sub CMS_ClinicR_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ClinicC"
    Public MustOverride Function CMS_ClinicC_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ClinicC_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_ClinicC_Add(PortalConnect As String, obj As CMS_ClinicCInfo) As Integer
    Public MustOverride Sub CMS_ClinicC_Update(PortalConnect As String, obj As CMS_ClinicCInfo)
    Public MustOverride Sub CMS_ClinicC_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_ClinicC_List_By_App(PortalConnect As String, portalId As Integer, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_MuiTiem"
    Public MustOverride Function CMS_MuiTiem_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_MuiTiem_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_MuiTiem_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
    Public MustOverride Function CMS_MuiTiem_Add(PortalConnect As String, obj As CMS_MuiTiemInfo) As Integer
    Public MustOverride Sub CMS_MuiTiem_Update(PortalConnect As String, obj As CMS_MuiTiemInfo)
    Public MustOverride Function CMS_MuiTiem_Get_By_CMS_VacXin(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_MuiTiem_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_VacXin"
    Public MustOverride Function CMS_VacXin_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_VacXin_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_VacXin_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
    Public MustOverride Function CMS_VacXin_Add(PortalConnect As String, obj As CMS_VacXinInfo) As Integer
    Public MustOverride Sub CMS_VacXin_Update(PortalConnect As String, obj As CMS_VacXinInfo)
    Public MustOverride Sub CMS_VacXin_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Vacxin_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_VacXin_Get_TE(PortalConnect As String, mID As Integer, vxID As Integer, muiTiemID As Integer, teID As Integer) As IDataReader

#End Region
#Region "CMS_DoanHinh"
    Public MustOverride Function CMS_DoanHinh_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_DoanHinh_Get_By_App(PortalConnect As String, miD As Integer, level As Integer) As IDataReader
    Public MustOverride Function CMS_DoanHinh_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DoanHinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_DoanHinh_Add(PortalConnect As String, obj As CMS_DoanHinhInfo) As Integer
    Public MustOverride Sub CMS_DoanHinh_Update(PortalConnect As String, obj As CMS_DoanHinhInfo)
    Public MustOverride Sub CMS_DoanHinh_Update_Quick(PortalConnect As String, iD As Integer, mucDo As Integer, soDiem As Integer, moDapAn As Integer, moChuCai As Integer, boChuCai As Integer)
    Public MustOverride Sub CMS_DoanHinh_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_DoanHinh_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_GameImg"
    Public MustOverride Function CMS_GameImg_List_By_AppID(PortalConnect As String, portalId As Integer, isOrder As Integer) As IDataReader
    Public MustOverride Function CMS_GameImg_Get_By_AppID(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_GameImg_Get_By_Level(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
    Public MustOverride Function CMS_GameImg_Add(PortalConnect As String, obj As CMS_GameImgInfo) As Integer
    Public MustOverride Sub CMS_GameImg_Update_Level(PortalConnect As String, appID As String, isLevel As Integer, adPoint As Integer, portalID As Integer)
    Public MustOverride Sub CMS_GameImg_Update_DePoint(PortalConnect As String, appID As String, dePoint As Integer, portalID As Integer)
    Public MustOverride Sub CMS_GameImg_Update_Point(PortalConnect As String, appID As String, Point As Integer, portalID As Integer)
    Public MustOverride Sub CMS_GameImg_Update_Cup(PortalConnect As String, appID As String, isCup As Integer, portalID As Integer)
#End Region
#Region "CMS_TreEm"
    Public MustOverride Function CMS_TreEm_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_TreEm_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_TreEm_List_By_App(PortalConnect As String, portalId As Integer, AppID As String) As IDataReader
    Public MustOverride Function CMS_TreEm_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_TreEm_List_Search_Web(PortalConnect As String, PortalID As Integer, AppID As String, isOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Function CMS_TreEm_Add(PortalConnect As String, obj As CMS_TreEmInfo) As Integer
    Public MustOverride Sub CMS_TreEm_Update(PortalConnect As String, obj As CMS_TreEmInfo)
    Public MustOverride Sub CMS_TreEm_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Fr_PostGroup"
    Public MustOverride Function CMS_Fr_PostGroup_List_By_App(PortalConnect As String, portalId As Integer, postID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_PostGroup_Get(PortalConnect As String, postGroup_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_PostGroup_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_PostGroup_List_By_Post(PortalConnect As String, portalId As Integer, postID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_PostGroup_Add(PortalConnect As String, obj As CMS_Fr_PostGroupInfo) As Integer
    Public MustOverride Sub CMS_Fr_PostGroup_Update(PortalConnect As String, obj As CMS_Fr_PostGroupInfo)
    Public MustOverride Sub CMS_Fr_PostGroup_Delete(PortalConnect As String, postGroup_ID As Integer)
    Public MustOverride Sub CMS_Fr_PostGroup_Delete_Group(PortalConnect As String, post_ID As Integer, groupID As String, portalID As Integer)
    Public MustOverride Function CMS_Fr_PostGroup_Get_By_AppID(PortalConnect As String, postID As Integer, appID As String, groupID As Integer) As IDataReader

#End Region
#Region "CMS_TiemChung"
    Public MustOverride Function CMS_TiemChung_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_TiemChung_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_TiemChung_Add(PortalConnect As String, obj As CMS_TiemChungInfo) As Integer
    Public MustOverride Function CMS_TiemChung_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, vxID As Integer, muiTiem As Integer) As IDataReader
    Public MustOverride Sub CMS_TiemChung_Update(PortalConnect As String, iD As Integer, ngayTiem As DateTime, trangThai As Integer, LoGo As String)
    Public MustOverride Sub CMS_TiemChung_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_MocRang"
    Public MustOverride Function CMS_MocRang_Get(PortalConnect As String, appID As String, teID As Integer, rangSo As Integer) As IDataReader
    Public MustOverride Function CMS_MocRang_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_MocRang_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, teID As Integer) As IDataReader
    Public MustOverride Function CMS_MocRang_Add(PortalConnect As String, obj As CMS_MocRangInfo) As Integer
    Public MustOverride Sub CMS_MocRang_Update(PortalConnect As String, obj As CMS_MocRangInfo)
    Public MustOverride Sub CMS_MocRang_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_KhamThai"
    Public MustOverride Function CMS_KhamThai_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_KhamThai_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_KhamThai_Add(PortalConnect As String, obj As CMS_KhamThaiInfo) As Integer
    Public MustOverride Sub CMS_KhamThai_Update(PortalConnect As String, obj As CMS_KhamThaiInfo)
    Public MustOverride Sub CMS_KhamThai_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_KhamThai_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
#End Region
#Region "CMS_KhamThaiD"
    Public MustOverride Function CMS_KhamThaiD_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, ktID As Integer) As IDataReader
    Public MustOverride Function CMS_KhamThaiD_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_KhamThaiD_Add(PortalConnect As String, obj As CMS_KhamThaiDInfo) As Integer
    Public MustOverride Sub CMS_KhamThaiD_Update(PortalConnect As String, iD As Integer, ngayKham As DateTime, trangThai As Integer)
    Public MustOverride Sub CMS_KhamThaiD_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_AnhBe"
    Public MustOverride Function CMS_AnhBe_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_AnhBe_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, find As String, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_AnhBe_Add(PortalConnect As String, obj As CMS_AnhBeInfo) As Integer
    Public MustOverride Sub CMS_AnhBe_Update(PortalConnect As String, obj As CMS_AnhBeInfo)
    Public MustOverride Sub CMS_AnhBe_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_AnhBeD"
    Public MustOverride Function CMS_AnhBeD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_AnhBeD_Add(PortalConnect As String, obj As CMS_AnhBeDInfo) As Integer
    Public MustOverride Sub CMS_AnhBeD_Update(PortalConnect As String, obj As CMS_AnhBeDInfo)
    Public MustOverride Function CMS_AnhBeD_Get_By_CMS_AnhBe(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_AnhBeD_Delete_By_CMS_AnhBe(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_AnhBeD_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_TheoDoiTE"
    Public MustOverride Function CMS_TheoDoiTE_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_TheoDoiTE_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, isType As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_TheoDoiTE_Add(PortalConnect As String, obj As CMS_TheoDoiTEInfo) As Integer
    Public MustOverride Sub CMS_TheoDoiTE_Update(PortalConnect As String, obj As CMS_TheoDoiTEInfo)
    Public MustOverride Sub CMS_TheoDoiTE_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_CuDap"
    Public MustOverride Function CMS_CuDap_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CuDap_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_CuDap_Add(PortalConnect As String, obj As CMS_CuDapInfo) As String
    Public MustOverride Sub CMS_CuDap_Update(PortalConnect As String, obj As CMS_CuDapInfo)
    Public MustOverride Sub CMS_CuDap_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_CuDapD"
    Public MustOverride Function CMS_CuDapD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CuDapD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CuDapD_Add(PortalConnect As String, obj As CMS_CuDapDInfo) As Integer
    Public MustOverride Sub CMS_CuDapD_Update(PortalConnect As String, obj As CMS_CuDapDInfo)
    Public MustOverride Function CMS_CuDapD_List_By_CID(PortalConnect As String, ciD As Integer) As IDataReader
    Public MustOverride Function CMS_CuDapD_List_By_LanDem(PortalConnect As String, ciD As Integer, lanDem As Integer) As IDataReader
    Public MustOverride Sub CMS_CuDapD_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SurveyR"
    Public MustOverride Function CMS_SurveyR_Get(PortalConnect As String, reply_ID As Integer) As IDataReader
    Public MustOverride Function CMS_SurveyR_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SurveyR_List_Search(PortalConnect As String, SvID As Integer) As IDataReader

    Public MustOverride Function CMS_SurveyR_Add(PortalConnect As String, obj As CMS_SurveyRInfo) As Integer
    Public MustOverride Sub CMS_SurveyR_Update(PortalConnect As String, obj As CMS_SurveyRInfo)
    Public MustOverride Function CMS_SurveyR_Get_By_CMS_Survey(PortalConnect As String, survey_ID As Integer) As IDataReader
    Public MustOverride Sub CMS_SurveyR_Delete(PortalConnect As String, reply_ID As Integer)
    Public MustOverride Sub CMS_SurveyR_Update_Reply(PortalConnect As String, reply_ID As Integer)
#End Region
#Region "CMS_Survey"
    Public MustOverride Function CMS_Survey_Get(PortalConnect As String, survey_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Survey_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Survey_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Survey_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, find As String, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_Survey_Add(PortalConnect As String, obj As CMS_SurveyInfo) As Integer
    Public MustOverride Sub CMS_Survey_Update(PortalConnect As String, obj As CMS_SurveyInfo)
    Public MustOverride Sub CMS_Survey_Delete(PortalConnect As String, survey_ID As Integer)
#End Region
#Region "CMS_SurveyU"
    Public MustOverride Function CMS_SurveyU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_SurveyU_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_SurveyU_Add(PortalConnect As String, obj As CMS_SurveyUInfo) As Integer
    Public MustOverride Sub CMS_SurveyU_Update(PortalConnect As String, obj As CMS_SurveyUInfo)
    Public MustOverride Sub CMS_SurveyU_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_KhamBenh"
    Public MustOverride Function CMS_KhamBenh_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_KhamBenh_Add(PortalConnect As String, obj As CMS_KhamBenhInfo) As Integer
    Public MustOverride Sub CMS_KhamBenh_Update(PortalConnect As String, obj As CMS_KhamBenhInfo)
    Public MustOverride Function CMS_KhamBenh_Get_By_CMS_SoKB(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Sub CMS_KhamBenh_Delete_By_CMS_SoKB(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_KhamBenh_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SoKB"
    Public MustOverride Function CMS_SoKB_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_SoKB_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_SoKB_Add(PortalConnect As String, obj As CMS_SoKBInfo) As Integer
    Public MustOverride Sub CMS_SoKB_Update(PortalConnect As String, obj As CMS_SoKBInfo)
    Public MustOverride Sub CMS_SoKB_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Product"

    Public MustOverride Function CMS_Product_List_By_ID(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function CMS_Product_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Product_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Product_Get_ByCount(PortalConnect As String, brandID As Integer, iD As Integer) As Integer
    Public MustOverride Function CMS_Product_List_ShopBy(PortalConnect As String, piD As Integer, groupID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Product_List_Brand(PortalConnect As String, piD As Integer, brandID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Product_List_Search(PortalConnect As String, piD As Integer, groupID As Integer, brandID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Product_Add(PortalConnect As String, obj As CMS_ProductInfo) As Integer
    Public MustOverride Sub CMS_Product_Update(PortalConnect As String, obj As CMS_ProductInfo)
    Public MustOverride Sub CMS_Product_Update_IsView(PortalConnect As String, proID As Integer)
    Public MustOverride Sub CMS_Product_Update_IsShare(PortalConnect As String, proID As Integer)
    Public MustOverride Sub CMS_Product_Update_IsLock(PortalConnect As String, proID As Integer, isLock As Boolean, lockedDate As DateTime, lockedUser As String)
    Public MustOverride Sub CMS_Product_Update_IsDelete(PortalConnect As String, proID As Integer, isDel As Boolean, delDate As DateTime, delUser As String)
    Public MustOverride Function CMS_Product_Get_By_CMS_ProductGroup(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Product_Get_By_CMS_ProductBrand(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_Product_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ProductBrand"
    Public MustOverride Function CMS_ProductBrand_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ProductBrand_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ProductBrand_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_ProductBrand_Add(PortalConnect As String, obj As CMS_ProductBrandInfo) As Integer
    Public MustOverride Sub CMS_ProductBrand_Update(PortalConnect As String, obj As CMS_ProductBrandInfo)
    Public MustOverride Sub CMS_ProductBrand_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ProductGroup"
    Public MustOverride Function CMS_ProductGroup_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ProductGroup_List_By_ParentID(PortalConnect As String, portalId As Integer, parentID As Integer) As IDataReader
    Public MustOverride Function CMS_ProductGroup_Add(PortalConnect As String, obj As CMS_ProductGroupInfo) As Integer
    Public MustOverride Sub CMS_ProductGroup_Update(PortalConnect As String, obj As CMS_ProductGroupInfo)
    Public MustOverride Sub CMS_ProductGroup_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ProductImg"
    Public MustOverride Function CMS_ProductImg_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ProductImg_Add(PortalConnect As String, obj As CMS_ProductImgInfo) As Integer
    Public MustOverride Sub CMS_ProductImg_Update(PortalConnect As String, obj As CMS_ProductImgInfo)
    Public MustOverride Function CMS_ProductImg_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_ProductImg_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_ProductImg_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ProductRate"
    Public MustOverride Function CMS_ProductRate_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ProductRate_Add(PortalConnect As String, obj As CMS_ProductRateInfo) As Integer
    Public MustOverride Sub CMS_ProductRate_Update(PortalConnect As String, obj As CMS_ProductRateInfo)
    Public MustOverride Function CMS_ProductRate_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_ProductRate_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_ProductRate_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ProductComment"
    Public MustOverride Function CMS_ProductComment_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ProductComment_List_Search(PortalConnect As String, productID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_ProductComment_Add(PortalConnect As String, obj As CMS_ProductCommentInfo) As Integer
    Public MustOverride Sub CMS_ProductComment_Update(PortalConnect As String, obj As CMS_ProductCommentInfo)
    Public MustOverride Function CMS_ProductComment_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_ProductComment_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ShopBy"
    Public MustOverride Function CMS_ShopBy_Count(PortalConnect As String, portalID As Integer) As Integer
    Public MustOverride Function CMS_ShopBy_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ShopBy_Add(PortalConnect As String, obj As CMS_ShopByInfo) As String
    Public MustOverride Sub CMS_ShopBy_Update(PortalConnect As String, obj As CMS_ShopByInfo)
    Public MustOverride Sub CMS_ShopBy_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_ShopBy_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, tinhTP As Integer, quanHuyen As Integer, tinhTrang As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_ShopBy_List_AppID(PortalConnect As String, portalId As Integer, search As String, appID As String, currPage As Integer, recodperpage As Integer, trangThai As Integer) As IDataReader
    Public MustOverride Sub CMS_ShopBy_Update_TinhTrang(PortalConnect As String, iD As Integer, tinhTrang As Integer, lyDoHuy As String, nguoiHuy As String, ngayHuy As DateTime)
#End Region
#Region "CMS_ShopPro"
    Public MustOverride Function CMS_ShopPro_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ShopPro_Add(PortalConnect As String, obj As CMS_ShopProInfo) As Integer
    Public MustOverride Sub CMS_ShopPro_Update(PortalConnect As String, obj As CMS_ShopProInfo)
    Public MustOverride Function CMS_ShopPro_Get_By_CMS_ShopBy(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_ShopPro_Delete_By_CMS_ShopBy(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_ShopPro_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Menu"
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
#Region "CMS_ImageN"
    Public MustOverride Function CMS_ImageN_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ImageN_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ImageN_List_Search(PortalConnect As String, PortalId As Integer, CateId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Function CMS_ImageN_Add(PortalConnect As String, obj As CMS_ImageNInfo) As Integer
    Public MustOverride Sub CMS_ImageN_Update(PortalConnect As String, obj As CMS_ImageNInfo)
    Public MustOverride Sub CMS_ImageN_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ImageD"
    Public MustOverride Function CMS_ImageD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ImageD_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ImageD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_ImageD_Add(PortalConnect As String, obj As CMS_ImageDInfo)
    Public MustOverride Sub CMS_ImageD_Update(PortalConnect As String, obj As CMS_ImageDInfo)
    Public MustOverride Sub CMS_ImageD_Delete(PortalConnect As String, iD As String)
    Public MustOverride Function CMS_ImageD_List_ByImageN(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
    Public MustOverride Function CMS_ImageD_List_Cate(PortalConnect As String, portalId As Integer, ID As Integer, type As Integer) As IDataReader

#End Region
#Region "CMS_ChuyenGia"
    Public MustOverride Function CMS_ChuyenGia_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_ChuyenGia_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ChuyenGia_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_ChuyenGia_List_Search_Top(PortalConnect As String, PortalID As Integer, Top As Integer) As IDataReader

    Public MustOverride Function CMS_ChuyenGia_Add(PortalConnect As String, obj As CMS_ChuyenGiaInfo) As Integer
    Public MustOverride Sub CMS_ChuyenGia_Update(PortalConnect As String, obj As CMS_ChuyenGiaInfo)
    Public MustOverride Sub CMS_ChuyenGia_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_VanChuyen"
    Public MustOverride Function CMS_VanChuyen_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_VanChuyen_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_VanChuyen_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_VanChuyen_Add(PortalConnect As String, obj As CMS_VanChuyenInfo) As Integer
    Public MustOverride Sub CMS_VanChuyen_Update(PortalConnect As String, obj As CMS_VanChuyenInfo)
    Public MustOverride Sub CMS_VanChuyen_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SiteMap"
    Public MustOverride Function CMS_SiteMap_Get(PortalConnect As String, siteMap_ID As String) As IDataReader
    Public MustOverride Function CMS_SiteMap_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_SiteMap_Add(PortalConnect As String, obj As CMS_SiteMapInfo)
    Public MustOverride Sub CMS_SiteMap_Update(PortalConnect As String, obj As CMS_SiteMapInfo)
    Public MustOverride Sub CMS_SiteMap_Delete(PortalConnect As String, siteMap_ID As String)
#End Region
#Region "CMS_Voucher"
    Public MustOverride Function CMS_Voucher_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Voucher_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Voucher_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, brandID As Integer) As IDataReader
    Public MustOverride Function CMS_Voucher_Add(PortalConnect As String, obj As CMS_VoucherInfo) As Integer
    Public MustOverride Sub CMS_Voucher_Update(PortalConnect As String, obj As CMS_VoucherInfo)
    Public MustOverride Sub CMS_Voucher_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_VoucherApp"
    Public MustOverride Function CMS_VoucherApp_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_VoucherApp_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, voucherID As Integer) As IDataReader
    Public MustOverride Function CMS_VoucherApp_List_AppID(PortalConnect As String, portalID As Integer, appID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_VoucherApp_Add(PortalConnect As String, obj As CMS_VoucherAppInfo) As Integer
    Public MustOverride Sub CMS_VoucherApp_Update(PortalConnect As String, obj As CMS_VoucherAppInfo)
    Public MustOverride Sub CMS_VoucherApp_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_VoucherApp_Update_SuDung(PortalConnect As String, PortalID As Integer, voucherID As Integer, appID As String, suDung As Boolean, ngayDung As DateTime, donHang As Integer)

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
#Region "CMS_NewsVote"
    Public MustOverride Function CMS_NewsVote_Get_NID(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsVote_Add(PortalConnect As String, obj As CMS_NewsVoteInfo) As Integer
    Public MustOverride Sub CMS_NewsVote_Delete(PortalConnect As String, newsV_ID As Integer)
#End Region
#Region "CMS_MetaSEO"
    Public MustOverride Function CMS_MetaSEO_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_MetaSEO_Get_IDKey(PortalConnect As String, iDKey As String) As IDataReader
    Public MustOverride Function CMS_MetaSEO_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_MetaSEO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_MetaSEO_Add(PortalConnect As String, obj As CMS_MetaSEOInfo) As Integer
    Public MustOverride Sub CMS_MetaSEO_Update(PortalConnect As String, obj As CMS_MetaSEOInfo)
    Public MustOverride Sub CMS_MetaSEO_Delete(PortalConnect As String, iD As Integer)
#End Region

End Class
