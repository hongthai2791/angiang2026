Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.VBN
Public Class SqlDataProvider
    Inherits DataProvider
#Region "CMS_App"
    Public Overrides Function CMS_App_Get_By_AppID(PortalConnect As String, PortalID As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_Get_By_AppID", PortalID, appID), IDataReader)
    End Function
    Public Overrides Function CMS_App_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_List"), IDataReader)
    End Function
    Public Overrides Function CMS_App_List_Search(PortalConnect As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_List_Search", PortalID, search, currPage, recodperpage, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_App_Get(PortalConnect As String, appKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_Get", appKey), IDataReader)
    End Function
    Public Overrides Sub CMS_App_Add(PortalConnect As String, obj As CMS_AppInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Add", obj.AppKey, obj.AppID, flReg.GetNull(obj.Avatar), flReg.GetNull(obj.HoVaTen), flReg.GetNull(obj.DienThoai), obj.GioiTinh, flReg.GetNull(obj.NgaySinh), flReg.GetNull(obj.CreateDate), obj.IsSystem, obj.PortalID, obj.TinhTP, obj.QuanHuyen)
    End Sub
    Public Overrides Function CMS_App_List_Find(PortalConnect As String, PortalID As Integer, search As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_List_Find", PortalID, search), IDataReader)
    End Function
    Public Overrides Sub CMS_App_Delete(PortalConnect As String, appKey As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Delete", appKey)
    End Sub
    Public Overrides Sub CMS_App_Remove(PortalConnect As String, AppID As String, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Remove", AppID, PortalID)
    End Sub
    Public Overrides Sub CMS_App_Update(PortalConnect As String, obj As CMS_AppInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Update", obj.AppID, flReg.GetNull(obj.Avatar), flReg.GetNull(obj.HoVaTen), flReg.GetNull(obj.DienThoai), obj.GioiTinh, flReg.GetNull(obj.NgaySinh), obj.PortalID, obj.TinhTP, obj.QuanHuyen)
    End Sub
    Public Overrides Sub CMS_App_Update_Point(PortalConnect As String, appID As String, point As Integer, history As String, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Update_Point", appID, point, history, portalID)
    End Sub
    Public Overrides Sub CMS_App_Change(PortalConnect As String, AppID As String, NewID As String, PortalID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_App_Change", AppID, NewID, PortalID)
    End Sub
    Public Overrides Function CMS_App_Check(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_App_Check", AppID, PortalID), Integer)
    End Function
#End Region
#Region "CMS_News"
    Public Overrides Function CMS_News_List_AppFind(PortalConnect As String, portalID As Integer, search As String, cateID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_AppFind", portalID, search, cateID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Tags(PortalConnect As String, NewsID As Integer, Tags As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update_Tags", NewsID, Tags)
    End Sub
    Public Overrides Function CMS_News_Get(PortalConnect As String, newsID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_Get", newsID), IDataReader)
    End Function
    Public Overrides Function CMS_News_List(PortalConnect As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List", portalID), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Contents(PortalConnect As String, newsID As Integer, Contents As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update_Contents", newsID, Contents)
    End Sub
    Public Overrides Function CMS_News_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Search", portalID, Title, CateID, PageIndex, PageSize, FromDate, ToDate, Status), IDataReader)
    End Function
    Public Overrides Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_News_Add", obj.PortalID, obj.CateID, flReg.GetNull(obj.Introduction), obj.Titles, obj.ToUrl, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Contents), obj.IsActive, obj.Status, flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.WriterName, obj.IsApp, obj.IsCare, obj.IsHot, obj.IsLike, obj.IsView, flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update", obj.NewsID, obj.PortalID, obj.CateID, flReg.GetNull(obj.Introduction), obj.Titles, obj.ToUrl, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Contents), obj.IsActive, obj.Status, flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.WriterName, obj.IsApp, obj.IsCare, obj.IsHot, obj.IsLike, obj.IsView, flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_News_Update_Status(PortalConnect As String, NewsID As Integer, Status As Integer, UserName As String, update As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update_Status", NewsID, Status, UserName, update)
    End Sub
    Public Overrides Sub CMS_News_Delete(PortalConnect As String, newsID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Delete", newsID)
    End Sub
    Public Overrides Sub CMS_News_Update_Like(PortalConnect As String, newsID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update_Like", newsID)
    End Sub
    Public Overrides Sub CMS_News_Update_View(PortalConnect As String, newsID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_News_Update_View", newsID)

    End Sub
    Public Overrides Function CMS_News_List_Search_Top_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Search_Top_Web", portalID, Top, CateID, Status), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Search_Block_Web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, IsFlag As Integer, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Search_Block_Web", portalID, Top, CateID, IsFlag, Status), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Search_Top_View(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Search_Top_View", portalID, Top, CateID, Status), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Search_Cate_web(PortalConnect As String, portalID As Integer, Top As Integer, CateID As Integer, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Search_Cate_web", portalID, Top, CateID, Status), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Home", NewsID, CategoryId, PortalId, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Home_Cate(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_News_List_Home_Cate", NewsID, CategoryId, PortalId, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_News", PortalID, IsLang, top)
    End Function

#End Region
#Region "CMS_NewsTag"
    Public Overrides Function CMS_NewsTag_Get(PortalConnect As String, iD As Long) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_NewsTag_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NewsTag_Add(PortalConnect As String, obj As CMS_NewsTagInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_Add", obj.NewsID, flReg.GetNull(obj.TagName), flReg.GetNull(obj.CreatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_NewsTag_Update(PortalConnect As String, obj As CMS_NewsTagInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_Update", obj.ID, obj.NewsID, flReg.GetNull(obj.TagName), flReg.GetNull(obj.CreatedDate))
    End Sub
    Public Overrides Function CMS_NewsTag_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_Get_By_CMS_News", newsID), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsTag_Delete(PortalConnect As String, iD As Long)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NewsTag_Delete", iD)
    End Sub
#End Region
#Region "CMS_NewVersion"
    Public Overrides Function CMS_NewVersion_Get(PortalConnect As String, version_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewVersion_Get", version_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NewVersion_Add(PortalConnect As String, obj As CMS_NewVersionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NewVersion_Add", flReg.GetNull(obj.Version_Name), obj.NewsID, obj.PortalID, obj.CateID, flReg.GetNull(obj.Introduction), obj.Titles, obj.ToUrl, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Contents), obj.IsActive, obj.Status, flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.WriterName, obj.IsCare, obj.IsHot, obj.IsLike, obj.IsView, flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Function CMS_NewVersion_Get_By_CMS_News(PortalConnect As String, newsID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewVersion_Get_By_CMS_News", newsID), IDataReader)
    End Function
    Public Overrides Sub CMS_NewVersion_Delete(PortalConnect As String, version_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NewVersion_Delete", version_ID)
    End Sub
#End Region
#Region "CMS_Video"
    Public Overrides Function CMS_Video_List_Search(PortalConnect As String, portalID As Integer, Title As String, CateID As Integer, PageIndex As Integer, PageSize As Integer, FromDate As DateTime, ToDate As DateTime, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Video_List_Search", portalID, Title, CateID, PageIndex, PageSize, FromDate, ToDate, Status), IDataReader)
    End Function
    Public Overrides Function CMS_Video_List_App(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Video_List_App", portalID, CateID, Title, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Function CMS_Video_List_Home(PortalConnect As String, portalID As Integer, CateID As Integer, Title As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Video_List_Home", portalID, CateID, Title, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Function CMS_Video_Get(PortalConnect As String, VideoID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Video_Get", VideoID), IDataReader)
    End Function
    Public Overrides Function CMS_Video_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Video_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Video_Add(PortalConnect As String, obj As CMS_VideoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Video_Add", obj.PortalID, obj.CateID, obj.Titles, obj.ToUrl, obj.Images, obj.Summary, obj.Writer, obj.IsYoutube, obj.MediaUrl, obj.IsView, obj.IsLike, obj.Status, flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Video_Update(PortalConnect As String, obj As CMS_VideoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Update", obj.VideoID, obj.PortalID, obj.CateID, obj.Titles, obj.ToUrl, obj.Images, obj.Summary, obj.Writer, obj.IsYoutube, obj.MediaUrl, obj.IsView, obj.IsLike, obj.Status, flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Video_Delete(PortalConnect As String, VideoID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Delete", VideoID)
    End Sub
    Public Overrides Sub CMS_Video_Update_Status(PortalConnect As String, VideoID As Integer, Status As Integer, UserName As String, update As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Update_Status", VideoID, Status, UserName, update)
    End Sub
    Public Overrides Sub CMS_Video_Update_Like(PortalConnect As String, VideoID As Integer, isLike As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Update_Like", VideoID, isLike)
    End Sub
    Public Overrides Sub CMS_Video_Update_Bad(PortalConnect As String, VideoID As Integer, isBad As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Update_Bad", VideoID, isBad)
    End Sub
    Public Overrides Sub CMS_Video_Update_View(PortalConnect As String, VideoID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Video_Update_View", VideoID)
    End Sub
#End Region
#Region "CMS_AppLog"
    Public Overrides Function CMS_AppLog_ListToken(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_ListToken", appID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_AppLog_Get(PortalConnect As String, token As String, appID As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_Get", token, appID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_AppLog_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_List"), IDataReader)
    End Function
    Public Overrides Function CMS_AppLog_Add(PortalConnect As String, obj As CMS_AppLogInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_Add", obj.Token, obj.AppID, obj.IsSystem, flReg.GetNull(obj.LogDate), flReg.GetNull(obj.Location), obj.PortalID), Integer)
    End Function
    Public Overrides Function CMS_AppLog_Get_Login(PortalConnect As String, appID As String, token As String, isSystem As Integer, portalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_Get_Login", appID, token, isSystem, portalID), Integer)
    End Function
    Public Overrides Sub CMS_AppLog_Update_LogEnd(PortalConnect As String, token As String, appID As String, logEnd As DateTime, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_Update_LogEnd", token, appID, logEnd, portalID)
    End Sub
    Public Overrides Sub CMS_AppLog_Delete(PortalConnect As String, id As String, appID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_Delete", id, appID)
    End Sub
    Public Overrides Function CMS_AppLog_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AppLog_List_Search", portalID, search, currPage, recodperpage, fromDate, toDate), IDataReader)
    End Function
#End Region
#Region "CMS_FCM"
    Public Overrides Function CMS_FCM_Get(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_FCM_Get", appID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_FCM_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_FCM_List"), IDataReader)
    End Function
    Public Overrides Function CMS_FCM_Add(PortalConnect As String, obj As CMS_FCMInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_FCM_Add", obj.Token, obj.AppID, obj.IsSystem, obj.PortalID), Integer)
    End Function
    Public Overrides Sub CMS_FCM_Delete(PortalConnect As String, token As String, appID As String, isSystem As Integer, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_FCM_Delete", token, appID, isSystem, portalID)
    End Sub
#End Region
#Region "CMS_Category"
    Public Overrides Function CMS_Category_Get_By_ParentId(PortalConnect As String, PortalId As Integer, isType As Integer, ParentId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get_By_ParentId", PortalId, isType, ParentId), IDataReader)
    End Function
    Public Overrides Function CMS_Category_Get_By_ParentId_Null(PortalConnect As String, PortalId As Integer, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get_By_ParentId_Null", PortalId, isType), IDataReader)
    End Function
    Public Overrides Sub CMS_Category_Update_Order(PortalConnect As String, categoryid As Integer, OrderNumber As Integer)
        SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Update_Order", categoryid, OrderNumber)
    End Sub
    Public Overrides Function CMS_Category_Get(PortalConnect As String, categoryID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get", categoryID), IDataReader)
    End Function
    Public Overrides Function CMS_Category_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_Category_Delete(PortalConnect As String, categoryID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Category_Delete", categoryID)
    End Sub
    Public Overrides Function CMS_Category_Add(PortalConnect As String, obj As CMS_CategoryInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Category_Add", obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.PortalID), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.Orders), flReg.GetNull(obj.IsType), flReg.GetNull(obj.CreateDate), obj.CreateUser, obj.TabPath, obj.TabID, obj.ImagePath, obj.IsApp), Integer)
    End Function
    Public Overrides Sub CMS_Category_Update(PortalConnect As String, obj As CMS_CategoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Category_Update", obj.CategoryID, obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.PortalID), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.Orders), flReg.GetNull(obj.IsType), flReg.GetNull(obj.CreateDate), obj.CreateUser, obj.TabPath, obj.TabID, obj.ImagePath, obj.IsApp)
    End Sub
    Public Overrides Function CMS_Category_Get_TabPath(PortalConnect As String, categoryid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get_TabPath", categoryid), IDataReader)
    End Function
    Public Overrides Function CMS_Category_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_List_All", PortalId, LanguageId, Type)
    End Function
    Public Overrides Function CMS_Category_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get_By_TabID", tabID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_Category_Get_By_TabPath(PortalConnect As String, TabPath As String, tabID As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_Get_By_TabPath", TabPath, tabID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_Category_List_App(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer, parentID As Integer, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Category_List_App", portalID, currPage, recodperpage, parentID, isType), IDataReader)
    End Function

#End Region
#Region "CMS_Portals"
    Public Overrides Function CMS_Portals_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Portals_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Portals_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Portals_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Portals_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Portals_List_Search", search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Portals_Add(PortalConnect As String, obj As CMS_PortalsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Portals_Add", obj.Names, obj.Des, obj.Android, obj.IOS, obj.CreateDate, obj.CreateUser), Integer)
    End Function
    Public Overrides Sub CMS_Portals_Update(PortalConnect As String, obj As CMS_PortalsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Portals_Update", obj.ID, obj.Names, obj.Des)
    End Sub
    Public Overrides Sub CMS_Portals_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Portals_Delete", iD)
    End Sub
#End Region
#Region "CMS_Group"
    Public Overrides Function CMS_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Group_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Group_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Group_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Group_Add", obj.Name, obj.Des, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.PortalID), obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Group_Update", obj.ID, obj.Name, obj.Des, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.PortalID), obj.IsActive)
    End Sub
    Public Overrides Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Group_Delete", iD)
    End Sub
#End Region
#Region "CMS_GroupD"
    Public Overrides Sub CMS_GroupD_Update_Bad(PortalConnect As String, iD As Integer, isBad As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Update_Bad", iD, isBad)
    End Sub
    Public Overrides Function CMS_GroupD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_GroupD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_GroupD_Add(PortalConnect As String, obj As CMS_GroupDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Add", obj.GroupID, flReg.GetNull(obj.Images), obj.Name, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.Icon), obj.IsLike, flReg.GetNull(obj.PortalID), obj.Writer, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_GroupD_Update(PortalConnect As String, obj As CMS_GroupDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Update", obj.ID, obj.GroupID, flReg.GetNull(obj.Images), obj.Name, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.Icon), obj.IsLike, flReg.GetNull(obj.PortalID), obj.Writer, obj.IsActive)
    End Sub
    Public Overrides Function CMS_GroupD_Get_By_CMS_Group(PortalConnect As String, portalID As Integer, GroupiD As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Get_By_CMS_Group", portalID, GroupiD, isActive, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_GroupD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Delete", iD)
    End Sub
    Public Overrides Sub CMS_GroupD_Update_Refresh(PortalConnect As String, iD As Integer, RefreshFrom As DateTime, RefreshTo As DateTime, RefreshUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Update_Refresh", iD, RefreshFrom, RefreshTo, RefreshUser)
    End Sub
    Public Overrides Sub CMS_GroupD_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Update_Like", iD, isLike)
    End Sub
    Public Overrides Sub CMS_GroupD_Update_Active(PortalConnect As String, iD As Integer, isActive As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_Update_Active", iD, isActive)
    End Sub
    Public Overrides Function CMS_GroupD_List_Search(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, trangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_List_Search", portalId, search, order, groupiD, trangThai, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_GroupD_List_App(PortalConnect As String, portalId As Integer, search As String, order As Integer, groupiD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GroupD_List_App", portalId, search, order, groupiD, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_Chapter"
    Public Overrides Function CMS_Chapter_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_Add(PortalConnect As String, obj As CMS_ChapterInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Add", obj.StoryID, obj.Name, obj.Contents, obj.IsView, obj.IsPublic, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Chapter_Update(PortalConnect As String, obj As CMS_ChapterInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Update", obj.ID, obj.StoryID, obj.Name, obj.Contents, obj.IsView, obj.IsPublic, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Function CMS_Chapter_List_By_App(PortalConnect As String, iD As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_List_By_App", iD, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_Next_Page(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Next_Page", iD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_Frist_Page(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Frist_Page", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_Download(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Download", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Chapter_Get_By_CMS_Story(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Get_By_CMS_Story", iD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Chapter_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Delete_By_CMS_Story", iD)
    End Sub
    Public Overrides Sub CMS_Chapter_Update_View(PortalConnect As String, iD As Integer, storyID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Update_View", iD, storyID)
    End Sub
    Public Overrides Sub CMS_Chapter_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Chapter_Delete", iD)
    End Sub
#End Region
#Region "CMS_Story"
    Public Overrides Function CMS_Story_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Story_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Story_List_Search(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, tacGia As String, Order As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_List_Search", portalID, search, theLoai, tacGia, Order, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Story_List_App(PortalConnect As String, portalID As Integer, search As String, theLoai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_List_App", portalID, search, theLoai, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Story_Add(PortalConnect As String, obj As CMS_StoryInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Story_Add", flReg.GetNull(obj.Name), flReg.GetNull(obj.Logo), flReg.GetNull(obj.Description), flReg.GetNull(obj.Author), obj.Status, flReg.GetNull(obj.Source), obj.IsView, obj.IsComment, obj.IsPublic, obj.IsChapter, obj.HotCate, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Function CMS_Story_List_Other(PortalConnect As String, portalID As Integer, Search As String, StoryID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_List_Other", portalID, Search, StoryID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Story_Update(PortalConnect As String, obj As CMS_StoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Update", obj.ID, flReg.GetNull(obj.Name), flReg.GetNull(obj.Logo), flReg.GetNull(obj.Description), flReg.GetNull(obj.Author), obj.Status, flReg.GetNull(obj.Source), obj.IsView, obj.IsComment, obj.IsPublic, obj.IsChapter, obj.HotCate, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Story_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Delete", iD)
    End Sub
    Public Overrides Sub CMS_Story_Update_View(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Update_View", iD)
    End Sub
    Public Overrides Sub CMS_Story_Update_Public(PortalConnect As String, iD As Integer, isPublic As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Update_Public", iD, isPublic)
    End Sub
    Public Overrides Sub CMS_Story_Update_HotCate(PortalConnect As String, iD As Integer, hotCate As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Update_HotCate", iD, hotCate)
    End Sub
    Public Overrides Function CMS_Story_List_By_Author(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Story_List_By_Author"), IDataReader)
    End Function
    Public Overrides Sub CMS_Story_Update_Like(PortalConnect As String, iD As Integer, isLike As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Story_Update_Like", iD, isLike)
    End Sub
#End Region
#Region "CMS_StoryC"
    Public Overrides Function CMS_StoryC_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_StoryC_List(PortalConnect As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_List", portalID), IDataReader)
    End Function
    Public Overrides Function CMS_StoryC_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_List_Search", search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_StoryC_Add(PortalConnect As String, obj As CMS_StoryCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_Add", obj.Name, flReg.GetNull(obj.Des), flReg.GetNull(obj.Logo), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser)), Integer)
    End Function
    Public Overrides Sub CMS_StoryC_Update(PortalConnect As String, obj As CMS_StoryCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_Update", obj.ID, obj.Name, flReg.GetNull(obj.Des), flReg.GetNull(obj.Logo), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser))
    End Sub
    Public Overrides Sub CMS_StoryC_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryC_Delete", iD)
    End Sub
#End Region
#Region "CMS_StoryFB"
    Public Overrides Function CMS_StoryFB_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_StoryFB_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_List"), IDataReader)
    End Function
    Public Overrides Function CMS_StoryFB_Get_By_CMS_Story(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Get_By_CMS_Story", iD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_StoryFB_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Delete_By_CMS_Story", iD)
    End Sub
    Public Overrides Sub CMS_StoryFB_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Delete", iD)
    End Sub
    Public Overrides Function CMS_StoryFB_Add(PortalConnect As String, obj As CMS_StoryFBInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Add", obj.StoryID, obj.AppID, obj.Contents, obj.Writer, obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), obj.IsLock), Integer)
    End Function
    Public Overrides Sub CMS_StoryFB_Update(PortalConnect As String, obj As CMS_StoryFBInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Update", obj.ID, obj.StoryID, obj.AppID, obj.Contents, obj.Writer, obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), obj.IsLock)
    End Sub
    Public Overrides Sub CMS_StoryFB_Update_Lock(PortalConnect As String, iD As Integer, isLock As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryFB_Update_Lock", iD, isLock)
    End Sub
#End Region
#Region "CMS_StoryP"
    Public Overrides Function CMS_StoryP_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_StoryP_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_List"), IDataReader)
    End Function

    Public Overrides Function CMS_StoryP_Add(PortalConnect As String, obj As CMS_StoryPInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Add", obj.StoryID, obj.PortalID), Integer)
    End Function
    Public Overrides Sub CMS_StoryP_Update(PortalConnect As String, obj As CMS_StoryPInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Update", obj.ID, obj.StoryID, obj.PortalID)
    End Sub
    Public Overrides Function CMS_StoryP_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Get_By_CMS_Story", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_StoryP_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Delete_By_CMS_Story", iD)
    End Sub
    Public Overrides Sub CMS_StoryP_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryP_Delete", iD)
    End Sub
#End Region
#Region "CMS_StoryD"
    Public Overrides Function CMS_StoryD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_StoryD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_List"), IDataReader)
    End Function

    Public Overrides Function CMS_StoryD_Add(PortalConnect As String, obj As CMS_StoryDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Add", obj.StoryID, obj.CateID), Integer)
    End Function
    Public Overrides Sub CMS_StoryD_Update(PortalConnect As String, obj As CMS_StoryDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Update", obj.ID, obj.StoryID, obj.CateID)
    End Sub
    Public Overrides Function CMS_StoryD_Get_By_CMS_Story(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Get_By_CMS_Story", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_StoryD_Delete_By_CMS_Story(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Delete_By_CMS_Story", iD)
    End Sub
    Public Overrides Sub CMS_StoryD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_StoryD_Delete", iD)
    End Sub
#End Region
#Region "CMS_AdMob"
    Public Overrides Function CMS_AdMob_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_AdMob_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_AdMob_List_Search(PortalConnect As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_List_Search", portalID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_AdMob_Add(PortalConnect As String, obj As CMS_AdMobInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Add", obj.A_LinkUp, obj.A_Version, flReg.GetNull(obj.A_ID), flReg.GetNull(obj.A_BieuNgu), flReg.GetNull(obj.A_TangThuong), flReg.GetNull(obj.A_NangCao), flReg.GetNull(obj.A_Testing), obj.I_LinkUp, obj.I_Version, flReg.GetNull(obj.I_ID), flReg.GetNull(obj.I_BieuNgu), flReg.GetNull(obj.I_TangThuong), flReg.GetNull(obj.I_NangCao), flReg.GetNull(obj.I_Testing), obj.PortalID, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), obj.Description), Integer)
    End Function
    Public Overrides Sub CMS_AdMob_Update(PortalConnect As String, obj As CMS_AdMobInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Update", obj.ID, obj.A_LinkUp, obj.A_Version, flReg.GetNull(obj.A_ID), flReg.GetNull(obj.A_BieuNgu), flReg.GetNull(obj.A_TangThuong), flReg.GetNull(obj.A_NangCao), flReg.GetNull(obj.A_Testing), obj.I_LinkUp, obj.I_Version, flReg.GetNull(obj.I_ID), flReg.GetNull(obj.I_BieuNgu), flReg.GetNull(obj.I_TangThuong), flReg.GetNull(obj.I_NangCao), flReg.GetNull(obj.I_Testing), obj.PortalID, flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), obj.Description)
    End Sub
    Public Overrides Function CMS_AdMob_Get_By_CMS_Portals(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Get_By_CMS_Portals", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_AdMob_Delete_By_CMS_Portals(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Delete_By_CMS_Portals", iD)
    End Sub
    Public Overrides Sub CMS_AdMob_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdMob_Delete", iD)
    End Sub
#End Region
#Region "CMS_Advertise"
    Public Overrides Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Get", advertise_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_List_Search", search, currPage, recodperpage, PortalID), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Add", obj.Advertise_ID, obj.Advertise_Name, obj.Images, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsActive, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.OpenLink)
    End Sub
    Public Overrides Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Update", obj.Advertise_ID, obj.Advertise_Name, obj.Images, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsActive, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.OpenLink)
    End Sub
    Public Overrides Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Delete", advertise_ID)
    End Sub
    Public Overrides Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_List_Home", PortalID, Top), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Home_Local(PortalConnect As String, PortalID As Integer, Top As Integer, pageLocal As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_List_Home_Local", PortalID, Top, pageLocal), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Update_Quick", advertise_ID, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Advertise_Update_Click(PortalConnect As String, advertise_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Advertise_Update_Click", advertise_ID)
    End Sub
#End Region
#Region "CMS_AdvertiseP"
    Public Overrides Sub CMS_AdvertiseP_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Delete_By_CMS_Advertise", advertise_ID)
    End Sub
    Public Overrides Function CMS_AdvertiseP_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_AdvertiseP_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_List"), IDataReader)
    End Function
    Public Overrides Function CMS_AdvertiseP_Add(PortalConnect As String, obj As CMS_AdvertisePInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Add", obj.Advertise_ID, obj.PortalID), Integer)
    End Function
    Public Overrides Sub CMS_AdvertiseP_Update(PortalConnect As String, obj As CMS_AdvertisePInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Update", obj.ID, obj.Advertise_ID, obj.PortalID)
    End Sub
    Public Overrides Function CMS_AdvertiseP_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Get_By_CMS_Advertise", advertise_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_AdvertiseP_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseP_Delete", iD)
    End Sub
#End Region
#Region "CMS_AdvertiseL"
    Public Overrides Sub CMS_AdvertiseL_Delete_By_CMS_Advertise(PortalConnect As String, advertise_ID As String, pageLocal As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Delete_By_CMS_Advertise", advertise_ID, pageLocal)
    End Sub
    Public Overrides Function CMS_AdvertiseL_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_AdvertiseL_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_List"), IDataReader)
    End Function
    Public Overrides Function CMS_AdvertiseL_Add(PortalConnect As String, obj As CMS_AdvertiseLInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Add", obj.Advertise_ID, obj.PageLocal), Integer)
    End Function
    Public Overrides Sub CMS_AdvertiseL_Update(PortalConnect As String, obj As CMS_AdvertiseLInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Update", obj.ID, obj.Advertise_ID, obj.PageLocal)
    End Sub
    Public Overrides Function CMS_AdvertiseL_Get_By_CMS_Advertise(PortalConnect As String, advertise_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Get_By_CMS_Advertise", advertise_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_AdvertiseL_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AdvertiseL_Delete", iD)
    End Sub
#End Region
#Region "CMS_Notify"
    Public Overrides Function CMS_Notify_List_Search(PortalConnect As String, search As String, PortalID As Integer, types As Integer, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Notify_List_Search", search, PortalID, types, currPage, recodperpage, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_Get_PortalID(PortalConnect As String, PortalID As Integer, types As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Get_PortalID", PortalID, types), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Get", notify_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Notify_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo)
        SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Add", obj.Notify_ID, obj.Titles, obj.Contents, obj.Types, obj.PortalID, obj.StartDay, obj.IsActive, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser), flReg.GetNull(obj.SendDate))
    End Sub
    Public Overrides Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Update", obj.Notify_ID, obj.Titles, obj.Contents, obj.Types, obj.PortalID, obj.StartDay, obj.IsActive, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser), flReg.GetNull(obj.SendDate))
    End Sub
    Public Overrides Sub CMS_Notify_Delete(PortalConnect As String, notify_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Delete", notify_ID)
    End Sub
    Public Overrides Sub CMS_Notify_Update_Active(PortalConnect As String, notify_ID As String, isActive As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Update_Active", notify_ID, isActive)
    End Sub
    Public Overrides Function CMS_Notify_Send_Notifycation(PortalConnect As String, PortalID As Integer, startDay As Integer, NotifyID As String, sendList As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Notify_Send_Notifycation", PortalID, startDay, NotifyID, sendList), IDataReader)
    End Function
    Public Overrides Sub CMS_Fr_Notify_ReadAll(PortalConnect As String, PortalID As Integer, AppID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_ReadAll", PortalID, AppID)
    End Sub
#End Region
#Region "CMS_NotiLog"
    Public Overrides Function CMS_NotiLog_Get(PortalConnect As String, notiLog_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_Get", notiLog_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NotiLog_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NotiLog_Add(PortalConnect As String, obj As CMS_NotiLogInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_Add", obj.Notify_ID, obj.LogName, obj.LogDate, obj.LogUser, obj.FcmID), Integer)
    End Function
    Public Overrides Sub CMS_NotiLog_Update(PortalConnect As String, obj As CMS_NotiLogInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_Update", obj.NotiLog_ID, obj.Notify_ID, obj.LogName, obj.LogDate, obj.LogUser)
    End Sub
    Public Overrides Function CMS_NotiLog_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_Get_By_CMS_Notify", notify_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_NotiLog_Delete(PortalConnect As String, notiLog_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiLog_Delete", notiLog_ID)
    End Sub
#End Region
#Region "CMS_NotiSend"
    Public Overrides Sub CMS_NotiSend_Register(PortalConnect As String, appID As String, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Register", appID, portalID)
    End Sub
    Public Overrides Function CMS_NotiSend_Get(PortalConnect As String, notiSend_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Get", notiSend_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NotiSend_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NotiSend_Add(PortalConnect As String, obj As CMS_NotiSendInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Add", obj.Notify_ID, obj.Titles, obj.Contents, obj.AppID, obj.CreatedDate, obj.SendDate, flReg.GetNull(obj.ReadDate), obj.TinhTrang, obj.IdKey, obj.Logo, flReg.GetNull(obj.Flags), obj.PortalID), Integer)
    End Function
    Public Overrides Sub CMS_NotiSend_Update(PortalConnect As String, obj As CMS_NotiSendInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Update", obj.NotiSend_ID, obj.Notify_ID, obj.Titles, obj.Contents, obj.AppID, obj.CreatedDate, obj.SendDate, flReg.GetNull(obj.ReadDate), obj.TinhTrang, obj.IdKey, obj.Logo, obj.PortalID)
    End Sub
    Public Overrides Function CMS_NotiSend_Get_By_CMS_Notify(PortalConnect As String, notify_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Get_By_CMS_Notify", notify_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_NotiSend_Delete(PortalConnect As String, notiSend_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Delete", notiSend_ID)
    End Sub
    Public Overrides Function CMS_NotiSend_List_Search(PortalConnect As String, Notify_ID As String, search As String, currPage As Integer, recodperpage As Integer, fromDate As DateTime, toDate As DateTime, tinhTrang As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_List_Search", Notify_ID, search, currPage, recodperpage, fromDate, toDate, tinhTrang), IDataReader)
    End Function
    Public Overrides Sub CMS_NotiSend_Update_TinhTrang_Flag(PortalConnect As String, portalID As Integer, flags As String, idKey As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Update_TinhTrang_Flag", portalID, flags, idKey)
    End Sub
    Public Overrides Sub CMS_NotiSend_Update_TinhTrang(PortalConnect As String, notiSend_ID As Integer, tinhTrang As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Update_TinhTrang", notiSend_ID, tinhTrang)
    End Sub
    Public Overrides Sub CMS_NotiSend_Update_TinhTrang_Read(PortalConnect As String, portalID As Integer, appID As String, tinhTrang As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_Update_TinhTrang_Read", portalID, appID, tinhTrang)
    End Sub
    Public Overrides Function CMS_NotiSend_List_By_AppID(PortalConnect As String, AppID As String, types As Integer, IdKey As String, currPage As Integer, recodperpage As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_List_By_AppID", AppID, types, IdKey, currPage, recodperpage, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_NotiSend_List_By_AppID_News(PortalConnect As String, AppID As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_List_By_AppID_News", AppID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_NotiSend_UnRead_AppID(PortalConnect As String, appID As String, portalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NotiSend_UnRead_AppID", appID, portalID), Integer)
    End Function

#End Region
#Region "CMS_Setups"
    Public Overrides Function CMS_Setups_Get(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Setups_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Setups_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Setups_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Setups_Get_By_Name(PortalConnect As String, settingName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Setups_Get_By_Name", settingName), IDataReader)
    End Function
    Public Overrides Sub CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
        SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Setups_Add", obj.ID, obj.SettingName, obj.SettingValue, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdatedUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Setups_Update(PortalConnect As String, obj As CMS_SetupsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Setups_Update", obj.ID, obj.SettingName, obj.SettingValue, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdatedUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Setups_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Setups_Delete", iD)
    End Sub
#End Region
#Region "CMS_Block"
    Public Overrides Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Block_Get_By_Key", idkey), IDataReader)
    End Function

    Public Overrides Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Block_List_By_Flag", flag), IDataReader)
    End Function
#End Region
#Region "CMS_RegEmail"
    Public Overrides Function CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_RegEmail_Add", RegEmail_ID, RegEmail, RegDate), String)
    End Function
    Public Overrides Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_RegEmail_List", currPage, recodperpage), IDataReader)
    End Function

#End Region
#Region "CMS_Fr_Notify"
    Public Overrides Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Notify_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Notify_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_List_AppID", PortalID, appID, currPage, recodPage, flags), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Notify_List_New(PortalConnect As String, PortalID As Integer, appID As String, flags As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_List_New", PortalID, appID, flags), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, PortalID As Integer, appID As String, flags As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_List_UnNew", PortalID, appID, flags)
    End Sub
    Public Overrides Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_Add", obj.PortalID, obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags), obj.AllPublic), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_Update", obj.PortalID, obj.ID, obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags))
    End Sub
    Public Overrides Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Notify_Delete", iD)
    End Sub
#End Region
#Region "CMS_Fr_Comment"
    Public Overrides Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Get", comment_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List_Admin(PortalConnect As String, postID As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_List_Admin", postID, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List_Top(PortalConnect As String, postID As Integer, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_List_Top", postID, Top), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Add", obj.Post_ID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate, obj.UpdatedDate), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Update", obj.Comment_ID, obj.Post_ID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate, obj.UpdatedDate)
    End Sub
    Public Overrides Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Update_Lock", commentID, lock, lockUser)
    End Sub
    Public Overrides Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Comment_Delete", comment_ID)
    End Sub
#End Region
#Region "CMS_Fr_Likes"
    Public Overrides Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_Get", likesID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Likes_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_Add", obj.AppID, obj.PostID, obj.CreatedDate), Integer)
    End Function
    Public Overrides Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_Update", obj.LikesID, obj.AppID, obj.PostID, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Likes_Delete", appID, postID)
    End Sub
#End Region
#Region "CMS_Fr_Post"
    Public Overrides Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Get", post_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Search(PortalConnect As String, PortalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_Search", PortalID, search, isOrder, currPage, recodperpage, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Group(PortalConnect As String, PortalID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_Group", PortalID, GroupID, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, PortalID As Integer, GroupID As Integer, AppID As String, lock As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_Group_Web", PortalID, GroupID, AppID, lock, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_By_App(PortalConnect As String, PortalID As Integer, appID As String, isOder As Integer, search As String, GroupID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_By_App", PortalID, appID, isOder, search, GroupID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_By_AppTE(PortalConnect As String, PortalID As Integer, appID As String, teID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_By_AppTE", PortalID, appID, teID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Admin(PortalConnect As String, PortalID As Integer, GroupID As Integer, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_Admin", PortalID, GroupID, IsOrder, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Admin_lock(PortalConnect As String, PortalID As Integer, appID As String, isLock As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_Admin_lock", PortalID, appID, isLock, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, PortalID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_List_OnlyMe", appID, PortalID, search, currPage, recodperpage, appFriend), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Add", obj.PortalID, obj.AppID, obj.Contents, obj.CreatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends, obj.PostShareID, obj.IsType), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Update", obj.PortalID, obj.Post_ID, obj.AppID, obj.Contents, obj.CreatedDate, obj.UpdatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends, obj.IsType)
    End Sub
    Public Overrides Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Update_Lock", postID, lock, lockuser)
    End Sub
    Public Overrides Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Delete", post_ID)
    End Sub
    Public Overrides Sub CMS_Fr_Post_Update_IsBad(PortalConnect As String, post_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Post_Update_IsBad", post_ID)
    End Sub
#End Region
#Region "CMS_Fr_SharePost"
    Public Overrides Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_SharePost_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_Update", obj.SharePost_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_SharePost_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_ShareUser"
    Public Overrides Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_List_Search", search, currPage, recodperpage, postID), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_Update", obj.ShareUser_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ShareUser_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_FileAttach"
    Public Overrides Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_Get", attach_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_List_ByIdKey", idKey, type, top), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_Add", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_Update", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_FileAttach_Delete", attach_ID)
    End Sub
#End Region
#Region "CMS_Fr_Group"
    Public Overrides Function CMS_Fr_Group_Get_By_AppID(PortalConnect As String, iD As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Get_By_AppID", iD, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_List_ByIsType(PortalConnect As String, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_List_ByIsType", isType), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_List_AppID(PortalConnect As String, PortalID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_List_AppID", PortalID, appID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Add", obj.PortalID, obj.Name, flReg.GetNull(obj.Logo), flReg.GetNull(obj.Des), obj.IsStatus, obj.IsType, obj.IsYear, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Update", obj.ID, obj.PortalID, obj.EID, obj.AppID, obj.Name, flReg.GetNull(obj.Logo), flReg.GetNull(obj.Des), obj.IsStatus, obj.IsType, obj.IsYear, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Delete", iD)
    End Sub
    Public Overrides Function CMS_Fr_Group_List_TK(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_List_TK", PortalID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_TK(PortalConnect As String, PortalID As Integer, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_TK", PortalID, ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_ThongKe(PortalConnect As String, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_ThongKe", PortalID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_NguoiDang(PortalConnect As String, PortalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_NguoiDang", PortalID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_App_List_Admin(PortalConnect As String, PortalID As Integer, Search As String, isOrder As Integer, isSystem As Integer, tinhTP As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_App_List_Admin", PortalID, Search, isOrder, isSystem, tinhTP, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_GroupTV(PortalConnect As String, PortalID As Integer, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupTV", PortalID, ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_Group_Update_Lock", ID, lock, lockuser)
    End Sub
    Public Overrides Function CMS_AppID_List_Group_Select(PortalConnect As String, PortalID As Integer, gID As String, aPPID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AppID_List_Group_Select", PortalID, gID, aPPID, search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_Fr_GroupU"
    Public Overrides Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_GroupU_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_List"), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Add", obj.GroupID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), obj.IsBoss, obj.IsLock), Integer)
    End Function
    Public Overrides Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Update", obj.ID, obj.GroupID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), obj.IsLock)
    End Sub
    Public Overrides Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Get_By_CMS_Fr_Group", iD, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_GroupU_Get_By_Group(PortalConnect As String, GroupID As Integer, AppID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Get_By_Group", GroupID, AppID), IDataReader)
    End Function
    Public Overrides Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Delete_By_CMS_Fr_Group", iD)
    End Sub
    Public Overrides Sub CMS_Fr_GroupU_Remove_AppID(PortalConnect As String, groupID As Integer, appID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Remove_AppID", groupID, appID)
    End Sub
    Public Overrides Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Delete", iD)
    End Sub
    Public Overrides Sub CMS_Fr_GroupU_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_GroupU_Update_Lock", ID, lock)
    End Sub
#End Region
#Region "CMS_Contact"
    Public Overrides Function CMS_Contact_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Contact_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Contact_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Contact_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_Contact_Update_Status(PortalConnect As String, Optional id As Integer = 1, Optional status As Boolean = 1)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Contact_Update_Status", id, status)
    End Sub
    Public Overrides Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PageIndex As Integer, PageSize As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Contact_List_Search", Search, PageIndex, PageSize, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_Contact_Add(PortalConnect As String, obj As CMS_ContactInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Contact_Add", obj.FullName, obj.Email, obj.Tel, obj.Contents, obj.CreatedDate), Integer)
    End Function
    Public Overrides Sub CMS_Contact_Update(PortalConnect As String, obj As CMS_ContactInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Contact_Update", obj.Id, obj.FullName, obj.Email, obj.Tel, obj.Contents, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_Contact_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Contact_Delete", id)
    End Sub
#End Region
#Region "CMS_Food"
    Public Overrides Function CMS_Food_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Food_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Food_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Food_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Food_List_App(PortalConnect As String, portalID As Integer, search As String, category As Integer, currPage As Integer, recodperpage As Integer, trangThai As String, giaiDoan As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Food_List_App", portalID, search, category, currPage, recodperpage, trangThai, giaiDoan), IDataReader)
    End Function

    Public Overrides Function CMS_Food_Add(PortalConnect As String, obj As CMS_FoodInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Food_Add", obj.FoodC_ID, obj.PortalID, obj.Logo, obj.Name, obj.Trophic, obj.PregnantStatus, obj.PregnantDes, obj.PostpartumStatus, obj.PostpartumDes, obj.BreastfeedingStatus, obj.BreastfeedingDes, obj.BabyStatus, obj.BabyDes, obj.IsPublic, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Food_Update(PortalConnect As String, obj As CMS_FoodInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Food_Update", obj.ID, obj.FoodC_ID, obj.PortalID, obj.Logo, obj.Name, obj.Trophic, obj.PregnantStatus, obj.PregnantDes, obj.PostpartumStatus, obj.PostpartumDes, obj.BreastfeedingStatus, obj.BreastfeedingDes, obj.BabyStatus, obj.BabyDes, obj.IsPublic, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Food_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Food_Delete", iD)
    End Sub
    Public Overrides Function CMS_Food_List_Search(PortalConnect As String, portalID As Integer, FoocID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Food_List_Search", portalID, FoocID, search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_FoodC"
    Public Overrides Function CMS_FoodC_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_FoodC_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_FoodC_Add(PortalConnect As String, obj As CMS_FoodCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_Add", obj.Name, obj.Des, obj.Logo, obj.PortalID, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser), Integer)
    End Function
    Public Overrides Sub CMS_FoodC_Update(PortalConnect As String, obj As CMS_FoodCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_Update", obj.ID, obj.Name, obj.Des, obj.Logo, obj.PortalID, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Overrides Sub CMS_FoodC_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_Delete", iD)
    End Sub
    Public Overrides Function CMS_FoodC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_FoodC_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_Clinic"
    Public Overrides Function CMS_Clinic_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Clinic_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_Get_By_App", portalID, appID, iD), IDataReader)
    End Function
    Public Overrides Function CMS_Clinic_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Clinic_Add(PortalConnect As String, obj As CMS_ClinicInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_Add", obj.PortalID, obj.Name, obj.Description, obj.WorkTime, obj.Doctors, obj.Hospital, obj.Mobile, obj.IsActie, obj.IsType, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DuongPho, obj.Latitude, obj.Longitude, obj.Logo, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser, obj.IsRepu), Integer)
    End Function
    Public Overrides Sub CMS_Clinic_Update(PortalConnect As String, obj As CMS_ClinicInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_Update", obj.PortalID, obj.ID, obj.Name, obj.Description, obj.WorkTime, obj.Doctors, obj.Hospital, obj.Mobile, obj.IsActie, obj.IsType, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DuongPho, obj.Latitude, obj.Longitude, obj.Logo, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser, obj.IsRepu)
    End Sub
    Public Overrides Sub CMS_Clinic_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_Delete", iD)
    End Sub
    Public Overrides Function CMS_Clinic_List_Search(PortalConnect As String, PotarID As Integer, IsOder As Integer, TinhTP As Integer, QuanHuyen As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_List_Search", PotarID, IsOder, TinhTP, QuanHuyen, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Clinic_List_By_App(PortalConnect As String, PotarID As Integer, IsType As Integer, search As String, TinhTP As Integer, QuanHuyen As Integer, duongPho As String, hot As Boolean, latitude As Double, longitude As Double, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_List_By_App", PotarID, IsType, search, TinhTP, QuanHuyen, duongPho, hot, latitude, longitude, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Clinic_List_By_Near(PortalConnect As String, PotarID As Integer, AppID As String, isType As Integer, Latitude As Double, Longitude As Double) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Clinic_List_By_Near", PotarID, AppID, isType, Latitude, Longitude), IDataReader)
    End Function
#End Region
#Region "CMS_Crush"
    Public Overrides Function CMS_Crush_Check(PortalConnect As String, appID As String, dienThoai As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Crush_Check", appID, dienThoai), Integer)
    End Function
    Public Overrides Function CMS_Crush_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Crush_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Crush_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Crush_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Crush_Add(PortalConnect As String, obj As CMS_CrushInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Crush_Add", obj.AppID, obj.HoTen, flReg.GetNull(obj.Logo), flReg.GetNull(obj.DienThoai), flReg.GetNull(obj.NamSinh), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.PortalID), obj.IsReg, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Crush_Update(PortalConnect As String, obj As CMS_CrushInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Crush_Update", obj.ID, obj.AppID, obj.HoTen, flReg.GetNull(obj.Logo), flReg.GetNull(obj.DienThoai), flReg.GetNull(obj.NamSinh), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.PortalID), obj.IsReg, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Crush_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Crush_Delete", iD)
    End Sub
    Public Overrides Function CMS_Crush_List_By_App(PortalConnect As String, PotarID As Integer, AppID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Crush_List_By_App", PotarID, AppID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Crush_List_By_App_Follower(PortalConnect As String, PotarID As Integer, AppID As String, DiebThoai As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Crush_List_By_App_Follower", PotarID, AppID, DiebThoai, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Crush_check_Login(PortalConnect As String, PortalID As Integer, AppID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Crush_check_Login", PortalID, AppID), Integer)
    End Function

#End Region
#Region "CMS_Cooking"
    Public Overrides Function CMS_Cooking_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Cooking_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Cooking_Add(PortalConnect As String, obj As CMS_CookingInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_Add", obj.PortalID, obj.Logo, obj.Name, obj.CookTime, obj.DifficultLevel, obj.MealType, obj.CookingType, obj.TasteType, obj.SpiceType, obj.Material, obj.Making, obj.IsPublic, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Cooking_Update(PortalConnect As String, obj As CMS_CookingInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_Update", obj.ID, obj.PortalID, obj.Logo, obj.Name, obj.CookTime, obj.DifficultLevel, obj.MealType, obj.CookingType, obj.TasteType, obj.SpiceType, obj.Material, obj.Making, obj.IsPublic, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Cooking_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_Delete", iD)
    End Sub
    Public Overrides Function CMS_Cooking_List_Search(PortalConnect As String, portalId As Integer, gID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_List_Search", portalId, gID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Cooking_List_By_App(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer, fromTime As Integer, toTime As Integer, cateID As Integer, difficultLevel As String, mealType As String, cookingType As String, tasteType As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_List_By_App", portalId, search, currPage, recodperpage, fromTime, toTime, cateID, difficultLevel, mealType, cookingType, tasteType), IDataReader)
    End Function
    Public Overrides Function CMS_CookingD_List_By_App(PortalConnect As String, isType As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingD_List_By_App", isType, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Cooking_Update_View(PortalConnect As String, ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Cooking_Update_View", ID)
    End Sub
    Public Overrides Function CMS_CookingD_List_By_Type(PortalConnect As String, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingD_List_By_Type", isType), IDataReader)
    End Function
#End Region
#Region "CMS_CookingC"
    Public Overrides Function CMS_CookingC_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CookingC_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_CookingC_Add(PortalConnect As String, obj As CMS_CookingCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_Add", obj.Name, obj.Des, obj.Logo, obj.PortalID, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser), Integer)
    End Function
    Public Overrides Sub CMS_CookingC_Update(PortalConnect As String, obj As CMS_CookingCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_Update", obj.ID, obj.Name, obj.Des, obj.Logo, obj.PortalID, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Overrides Sub CMS_CookingC_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_Delete", iD)
    End Sub
    Public Overrides Function CMS_CookingC_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingC_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_CookingO"
    Public Overrides Function CMS_CookingO_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CookingO_Add(PortalConnect As String, obj As CMS_CookingOInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_Add", obj.CookingID, obj.CateID), Integer)
    End Function
    Public Overrides Sub CMS_CookingO_Update(PortalConnect As String, obj As CMS_CookingOInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_Update", obj.ID, obj.CookingID, obj.CateID)
    End Sub
    Public Overrides Sub CMS_CookingO_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_Delete", iD)
    End Sub
    Public Overrides Function CMS_CookingO_Get_By_CMS_Cooking(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_Get_By_CMS_Cooking", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CookingO_List_Cooking(PortalConnect As String, CookingId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CookingO_List_Cooking", CookingId), IDataReader)
    End Function
#End Region
#Region "CMS_BabyHeight"
    Public Overrides Function CMS_BabyHeight_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_BabyHeight_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BabyHeight_List_By_Sex(PortalConnect As String, isSex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_List_By_Sex", isSex), IDataReader)
    End Function
    Public Overrides Function CMS_BabyHeight_Add(PortalConnect As String, obj As CMS_BabyHeightInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_Add", obj.Month, obj.LowerLimit, obj.Normal, obj.UpperLimit, obj.IsSex), Integer)
    End Function
    Public Overrides Sub CMS_BabyHeight_Update(PortalConnect As String, obj As CMS_BabyHeightInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_Update", obj.ID, obj.Month, obj.LowerLimit, obj.Normal, obj.UpperLimit, obj.IsSex)
    End Sub
    Public Overrides Sub CMS_BabyHeight_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_Delete", iD)
    End Sub
    Public Overrides Function CMS_BabyHeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyHeight_Get_By_App", month, IsSex), IDataReader)
    End Function
#End Region
#Region "CMS_BabyWeight"
    Public Overrides Function CMS_BabyWeight_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_BabyWeight_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BabyWeight_Get_By_App(PortalConnect As String, month As Integer, IsSex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_Get_By_App", month, IsSex), IDataReader)
    End Function
    Public Overrides Function CMS_BabyWeight_List_By_Sex(PortalConnect As String, isSex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_List_By_Sex", isSex), IDataReader)
    End Function
    Public Overrides Function CMS_BabyWeight_Add(PortalConnect As String, obj As CMS_BabyWeightInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_Add", obj.Month, obj.UnderWeight, obj.RiskUnderWeight, obj.Normal, obj.RiskOverWeight, obj.OverWeight, obj.IsSex), Integer)
    End Function
    Public Overrides Sub CMS_BabyWeight_Update(PortalConnect As String, obj As CMS_BabyWeightInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_Update", obj.ID, obj.Month, obj.UnderWeight, obj.RiskUnderWeight, obj.Normal, obj.RiskOverWeight, obj.OverWeight, obj.IsSex)
    End Sub
    Public Overrides Sub CMS_BabyWeight_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_BabyWeight_Delete", iD)
    End Sub
#End Region
#Region "CMS_ClinicC"
    Public Overrides Function CMS_ClinicC_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ClinicC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_List"), IDataReader)
    End Function

    Public Overrides Function CMS_ClinicC_Add(PortalConnect As String, obj As CMS_ClinicCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_Add", obj.PortalID, obj.ClinicID, obj.AppID, obj.Contents, obj.Reply, obj.IsLock, obj.LockedUser, obj.LockedDate, obj.CreatedDate, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate), Integer)
    End Function
    Public Overrides Sub CMS_ClinicC_Update(PortalConnect As String, obj As CMS_ClinicCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_Update", obj.PortalID, obj.ID, obj.ClinicID, obj.AppID, obj.Contents, obj.Reply, obj.IsLock, obj.LockedUser, obj.LockedDate, obj.CreatedDate, obj.UpdatedDate, obj.IsDelete, obj.DeletedDate)
    End Sub
    Public Overrides Sub CMS_ClinicC_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_Delete", iD)
    End Sub
    Public Overrides Function CMS_ClinicC_List_By_App(PortalConnect As String, portalId As Integer, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ClinicC_List_By_App", portalId, iD, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_ClinicR"
    Public Overrides Function CMS_ClinicR_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ClinicR_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ClinicR_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ClinicR_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_ClinicR_Add(PortalConnect As String, obj As CMS_ClinicRInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ClinicR_Add", obj.PortalID, obj.AppID, obj.ClinicID, obj.IsRate, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate), Integer)
    End Function
    Public Overrides Sub CMS_ClinicR_Update(PortalConnect As String, obj As CMS_ClinicRInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ClinicR_Update", obj.ID, obj.PortalID, obj.AppID, obj.ClinicID, obj.IsRate, obj.CreatedUser, obj.CreatedDate, obj.UpdatedUser, obj.UpdatedDate)
    End Sub
    Public Overrides Sub CMS_ClinicR_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ClinicR_Delete", iD)
    End Sub

#End Region
#Region "CMS_MuiTiem"
    Public Overrides Function CMS_MuiTiem_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_MuiTiem_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_List"), IDataReader)
    End Function

    Public Overrides Function CMS_MuiTiem_Add(PortalConnect As String, obj As CMS_MuiTiemInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_Add", obj.VacXin_ID, obj.MuiTiem, obj.ThangTuoi, obj.MoTa), Integer)
    End Function
    Public Overrides Sub CMS_MuiTiem_Update(PortalConnect As String, obj As CMS_MuiTiemInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_Update", obj.ID, obj.VacXin_ID, obj.MuiTiem, obj.ThangTuoi, obj.MoTa)
    End Sub
    Public Overrides Function CMS_MuiTiem_Get_By_CMS_VacXin(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_Get_By_CMS_VacXin", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_MuiTiem_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_Delete", iD)
    End Sub
    Public Overrides Function CMS_MuiTiem_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MuiTiem_List_By_App", mID, appID, teID), IDataReader)
    End Function
#End Region
#Region "CMS_VacXin"
    Public Overrides Function CMS_VacXin_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_VacXin_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_VacXin_Get_TE(PortalConnect As String, mID As Integer, vxID As Integer, muiTiemID As Integer, teID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_Get_TE", mID, vxID, muiTiemID, teID), IDataReader)
    End Function
    Public Overrides Function CMS_VacXin_Add(PortalConnect As String, obj As CMS_VacXinInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_Add", obj.TenVacXin, obj.TiemPhong, obj.DenLichTiem, obj.Benh, obj.NoiDung, obj.PhanUngPhu, obj.BatBuoc, obj.PortalID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_VacXin_Update(PortalConnect As String, obj As CMS_VacXinInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_Update", obj.ID, obj.TenVacXin, obj.TiemPhong, obj.DenLichTiem, obj.Benh, obj.NoiDung, obj.PhanUngPhu, obj.BatBuoc, obj.PortalID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_VacXin_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_Delete", iD)
    End Sub
    Public Overrides Function CMS_VacXin_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_VacXin_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VacXin_List_By_App", mID, appID, teID), IDataReader)
    End Function



#End Region
#Region "CMS_DoanHinh"
    Public Overrides Function CMS_DoanHinh_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_DoanHinh_Get_By_App(PortalConnect As String, miD As Integer, level As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Get_By_App", miD, level), IDataReader)
    End Function
    Public Overrides Function CMS_DoanHinh_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DoanHinh_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_DoanHinh_Update_Quick(PortalConnect As String, iD As Integer, mucDo As Integer, soDiem As Integer, moDapAn As Integer, moChuCai As Integer, boChuCai As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Update_Quick", iD, mucDo, soDiem, moDapAn, moChuCai, boChuCai)
    End Sub
    Public Overrides Function CMS_DoanHinh_Add(PortalConnect As String, obj As CMS_DoanHinhInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Add", obj.TenCauHoi, obj.HinhAnh, obj.DapAn, obj.SoKyTu, obj.PhimNhap, obj.KyTuSai, obj.MucDo, obj.SoDiem, obj.MoDapAn, obj.MoChuCai, obj.BoChuCai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalID, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_DoanHinh_Update(PortalConnect As String, obj As CMS_DoanHinhInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Update", obj.ID, obj.TenCauHoi, obj.HinhAnh, obj.DapAn, obj.SoKyTu, obj.PhimNhap, obj.KyTuSai, obj.MucDo, obj.SoDiem, obj.MoDapAn, obj.MoChuCai, obj.BoChuCai, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalID, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_DoanHinh_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_Delete", iD)
    End Sub
    Public Overrides Function CMS_DoanHinh_List_Search(PortalConnect As String, portalID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_DoanHinh_List_Search", portalID, search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_GameImg"
    Public Overrides Function CMS_GameImg_List_By_AppID(PortalConnect As String, portalId As Integer, isOrder As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_List_By_AppID", portalId, isOrder), IDataReader)
    End Function
    Public Overrides Function CMS_GameImg_Get_By_AppID(PortalConnect As String, appID As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Get_By_AppID", appID, portalID), IDataReader)
    End Function
    Public Overrides Sub CMS_GameImg_Update_Level(PortalConnect As String, appID As String, isLevel As Integer, adPoint As Integer, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Update_Level", appID, isLevel, adPoint, portalID)
    End Sub
    Public Overrides Sub CMS_GameImg_Update_DePoint(PortalConnect As String, appID As String, dePoint As Integer, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Update_DePoint", appID, dePoint, portalID)
    End Sub
    Public Overrides Sub CMS_GameImg_Update_Point(PortalConnect As String, appID As String, Point As Integer, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Update_Point", appID, Point, portalID)
    End Sub
    Public Overrides Sub CMS_GameImg_Update_Cup(PortalConnect As String, appID As String, isCup As Integer, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Update_Cup", appID, isCup, portalID)
    End Sub
    Public Overrides Function CMS_GameImg_Add(PortalConnect As String, obj As CMS_GameImgInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Add", obj.AppID, obj.IsLevel, obj.DePoint, obj.AdPoint, obj.IsCup, obj.PortalID), Integer)
    End Function
    Public Overrides Function CMS_GameImg_Get_By_Level(PortalConnect As String, AppID As String, PortalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_GameImg_Get_By_Level", AppID, PortalID), Integer)
    End Function

#End Region
#Region "CMS_TreEm"
    Public Overrides Function CMS_TreEm_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_TreEm_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_TreEm_List_By_App(PortalConnect As String, portalId As Integer, AppID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_List_By_App", portalId, AppID), IDataReader)
    End Function
    Public Overrides Function CMS_TreEm_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_TreEm_List_Search_Web(PortalConnect As String, PortalID As Integer, AppID As String, isOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_List_Search_Web", PortalID, AppID, isOrder, search, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function CMS_TreEm_Add(PortalConnect As String, obj As CMS_TreEmInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_Add", obj.PortalID, obj.AppID, obj.Logo, obj.TenBe, obj.TenONha, obj.TrangThai, obj.NgaySinh, obj.NgayDuSinh, obj.GioiTinh, obj.GhiChu, obj.CreatedDate, obj.UpdatedDate), Integer)
    End Function
    Public Overrides Sub CMS_TreEm_Update(PortalConnect As String, obj As CMS_TreEmInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_Update", obj.ID, obj.PortalID, obj.AppID, obj.Logo, obj.TenBe, obj.TenONha, obj.TrangThai, obj.NgaySinh, obj.NgayDuSinh, obj.GioiTinh, obj.GhiChu, obj.CreatedDate, obj.UpdatedDate)
    End Sub
    Public Overrides Sub CMS_TreEm_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TreEm_Delete", iD)
    End Sub
#End Region
#Region "CMS_Fr_PostGroup"
    Public Overrides Function CMS_Fr_PostGroup_Get_By_AppID(PortalConnect As String, postID As Integer, appID As String, groupID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Get_By_AppID", postID, appID, groupID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_PostGroup_List_By_App(PortalConnect As String, portalId As Integer, postID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_List_By_App", portalId, postID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_PostGroup_Get(PortalConnect As String, postGroup_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Get", postGroup_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_PostGroup_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_PostGroup_List_By_Post(PortalConnect As String, portalId As Integer, postID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_List_By_Post", portalId, postID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_PostGroup_Add(PortalConnect As String, obj As CMS_Fr_PostGroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Add", obj.Post_ID, obj.GroupID, flReg.GetNull(obj.PortalID)), Integer)
    End Function
    Public Overrides Sub CMS_Fr_PostGroup_Update(PortalConnect As String, obj As CMS_Fr_PostGroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Update", obj.PostGroup_ID, obj.Post_ID, obj.GroupID, flReg.GetNull(obj.PortalID))
    End Sub
    Public Overrides Sub CMS_Fr_PostGroup_Delete(PortalConnect As String, postGroup_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Delete", postGroup_ID)
    End Sub
    Public Overrides Sub CMS_Fr_PostGroup_Delete_Group(PortalConnect As String, post_ID As Integer, groupID As String, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Fr_PostGroup_Delete_Group", post_ID, groupID, portalID)
    End Sub
#End Region
#Region "CMS_TiemChung"
    Public Overrides Function CMS_TiemChung_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, vxID As Integer, muiTiem As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_Get", mID, appID, teID, vxID, muiTiem), IDataReader)
    End Function
    Public Overrides Function CMS_TiemChung_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_TiemChung_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_TiemChung_Add(PortalConnect As String, obj As CMS_TiemChungInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_Add", obj.PortalID, obj.AppID, obj.TreEm_ID, obj.VacXin_ID, obj.MuiTiem, obj.NgayTiem, obj.TrangThai, obj.Logo), Integer)
    End Function
    Public Overrides Sub CMS_TiemChung_Update(PortalConnect As String, iD As Integer, ngayTiem As DateTime, trangThai As Integer, LoGo As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_Update", iD, ngayTiem, trangThai, LoGo)
    End Sub
    Public Overrides Sub CMS_TiemChung_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TiemChung_Delete", iD)
    End Sub
#End Region
#Region "CMS_MocRang"
    Public Overrides Function CMS_MocRang_Get(PortalConnect As String, appID As String, teID As Integer, rangSo As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_Get", appID, teID, rangSo), IDataReader)
    End Function
    Public Overrides Function CMS_MocRang_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MocRang_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, teID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_List_By_AppID", portalId, appID, teID), IDataReader)
    End Function
    Public Overrides Function CMS_MocRang_Add(PortalConnect As String, obj As CMS_MocRangInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_Add", obj.PortalID, obj.AppID, obj.TEID, obj.NgayMoc, obj.RangSo, obj.TrangThai, flReg.GetNull(obj.HinhAnh), flReg.GetNull(obj.GhiChu), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_MocRang_Update(PortalConnect As String, obj As CMS_MocRangInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_Update", obj.PortalID, obj.AppID, obj.TEID, obj.NgayMoc, obj.RangSo, obj.TrangThai, flReg.GetNull(obj.HinhAnh), flReg.GetNull(obj.GhiChu), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate))
    End Sub
    Public Overrides Sub CMS_MocRang_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MocRang_Delete", iD)
    End Sub
#End Region
#Region "CMS_KhamThai"
    Public Overrides Function CMS_KhamThai_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_KhamThai_List_By_App(PortalConnect As String, mID As Integer, appID As String, teID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_List_By_App", mID, appID, teID), IDataReader)
    End Function
    Public Overrides Function CMS_KhamThai_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_List"), IDataReader)
    End Function
    Public Overrides Function CMS_KhamThai_Add(PortalConnect As String, obj As CMS_KhamThaiInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_Add", obj.ThaiTuan, obj.NoiDung), Integer)
    End Function
    Public Overrides Sub CMS_KhamThai_Update(PortalConnect As String, obj As CMS_KhamThaiInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_Update", obj.ID, obj.ThaiTuan, obj.NoiDung)
    End Sub
    Public Overrides Sub CMS_KhamThai_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamThai_Delete", iD)
    End Sub
#End Region
#Region "CMS_KhamThaiD"
    Public Overrides Function CMS_KhamThaiD_Get(PortalConnect As String, mID As Integer, appID As String, teID As Integer, ktID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamThaiD_Get", mID, appID, teID, ktID), IDataReader)
    End Function
    Public Overrides Function CMS_KhamThaiD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamThaiD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_KhamThaiD_Add(PortalConnect As String, obj As CMS_KhamThaiDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_KhamThaiD_Add", obj.PortalID, obj.AppID, obj.TreEm_ID, obj.KhamThai_ID, obj.NgayKham, obj.TrangThai), Integer)
    End Function
    Public Overrides Sub CMS_KhamThaiD_Update(PortalConnect As String, iD As Integer, ngayKham As DateTime, trangThai As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamThaiD_Update", iD, ngayKham, trangThai)
    End Sub
    Public Overrides Sub CMS_KhamThaiD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamThaiD_Delete", iD)
    End Sub
#End Region
#Region "CMS_AnhBe"
    Public Overrides Function CMS_AnhBe_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AnhBe_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_AnhBe_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, find As String, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AnhBe_List_By_AppID", mID, appID, teID, find, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_AnhBe_Add(PortalConnect As String, obj As CMS_AnhBeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AnhBe_Add", obj.PortalID, obj.AppID, obj.TreEm_ID, flReg.GetNull(obj.NgayDang), flReg.GetNull(obj.GhiChu)), Integer)
    End Function
    Public Overrides Sub CMS_AnhBe_Update(PortalConnect As String, obj As CMS_AnhBeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AnhBe_Update", obj.ID, obj.PortalID, obj.AppID, obj.TreEm_ID, flReg.GetNull(obj.NgayDang), flReg.GetNull(obj.GhiChu))
    End Sub
    Public Overrides Sub CMS_AnhBe_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AnhBe_Delete", iD)
    End Sub
#End Region
#Region "CMS_AnhBeD"
    Public Overrides Function CMS_AnhBeD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_AnhBeD_Add(PortalConnect As String, obj As CMS_AnhBeDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Add", flReg.GetNull(obj.AID), flReg.GetNull(obj.hinhAnh)), Integer)
    End Function
    Public Overrides Sub CMS_AnhBeD_Update(PortalConnect As String, obj As CMS_AnhBeDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Update", obj.ID, flReg.GetNull(obj.AID), flReg.GetNull(obj.hinhAnh))
    End Sub
    Public Overrides Function CMS_AnhBeD_Get_By_CMS_AnhBe(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Get_By_CMS_AnhBe", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_AnhBeD_Delete_By_CMS_AnhBe(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Delete_By_CMS_AnhBe", iD)
    End Sub
    Public Overrides Sub CMS_AnhBeD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_AnhBeD_Delete", iD)
    End Sub
#End Region
#Region "CMS_TheoDoiTE"
    Public Overrides Function CMS_TheoDoiTE_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_TheoDoiTE_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, isType As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_List_By_AppID", mID, appID, teID, isType, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_TheoDoiTE_Add(PortalConnect As String, obj As CMS_TheoDoiTEInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_Add", obj.PortalID, obj.AppID, obj.TEID, flReg.GetNull(obj.ChieuCao), flReg.GetNull(obj.CanNang), obj.ThangTuan, obj.CreatedDate, obj.IsType), Integer)
    End Function
    Public Overrides Sub CMS_TheoDoiTE_Update(PortalConnect As String, obj As CMS_TheoDoiTEInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_Update", obj.ID, obj.PortalID, obj.AppID, obj.TEID, flReg.GetNull(obj.ChieuCao), flReg.GetNull(obj.CanNang), obj.ThangTuan, obj.CreatedDate, obj.IsType)
    End Sub
    Public Overrides Sub CMS_TheoDoiTE_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_TheoDoiTE_Delete", iD)
    End Sub
#End Region
#Region "CMS_CuDap"
    Public Overrides Function CMS_CuDap_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDap_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CuDap_List_By_AppID(PortalConnect As String, mID As Integer, appID As String, teID As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDap_List_By_AppID", mID, appID, teID, page, recod), IDataReader)
    End Function

    Public Overrides Function CMS_CuDap_Add(PortalConnect As String, obj As CMS_CuDapInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_CuDap_Add", obj.PortalID, obj.AppID, obj.TEID, obj.CreatedDate), String)
    End Function
    Public Overrides Sub CMS_CuDap_Update(PortalConnect As String, obj As CMS_CuDapInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CuDap_Update", obj.ID, obj.PortalID, obj.AppID, obj.TEID, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_CuDap_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CuDap_Delete", iD)
    End Sub
#End Region
#Region "CMS_CuDapD"
    Public Overrides Function CMS_CuDapD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CuDapD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CuDapD_Add(PortalConnect As String, obj As CMS_CuDapDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_Add", flReg.GetNull(obj.CuDap_ID), flReg.GetNull(obj.GioDem), flReg.GetNull(obj.PhutDem), obj.Loai, flReg.GetNull(obj.LanDem)), Integer)
    End Function
    Public Overrides Sub CMS_CuDapD_Update(PortalConnect As String, obj As CMS_CuDapDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_Update", obj.ID, flReg.GetNull(obj.CuDap_ID), flReg.GetNull(obj.GioDem), flReg.GetNull(obj.PhutDem), obj.Loai, flReg.GetNull(obj.LanDem))
    End Sub
    Public Overrides Function CMS_CuDapD_List_By_CID(PortalConnect As String, ciD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_List_By_CID", ciD), IDataReader)
    End Function
    Public Overrides Function CMS_CuDapD_List_By_LanDem(PortalConnect As String, ciD As Integer, lanDem As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_List_By_LanDem", ciD, lanDem), IDataReader)
    End Function
    Public Overrides Sub CMS_CuDapD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_CuDapD_Delete", iD)
    End Sub
#End Region
#Region "CMS_SurveyR"
    Public Overrides Function CMS_SurveyR_Get(PortalConnect As String, reply_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Get", reply_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SurveyR_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SurveyR_List_Search(PortalConnect As String, SvID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_List_Search", SvID), IDataReader)
    End Function
    Public Overrides Sub CMS_SurveyR_Update_Reply(PortalConnect As String, reply_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Update_Reply", reply_ID)
    End Sub
    Public Overrides Function CMS_SurveyR_Add(PortalConnect As String, obj As CMS_SurveyRInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Add", obj.Survey_ID, obj.Titles, obj.IsOrder, obj.IsActive, obj.IsReply), Integer)
    End Function
    Public Overrides Sub CMS_SurveyR_Update(PortalConnect As String, obj As CMS_SurveyRInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Update", obj.Reply_ID, obj.Survey_ID, obj.Titles, obj.IsOrder, obj.IsActive, obj.IsReply)
    End Sub
    Public Overrides Function CMS_SurveyR_Get_By_CMS_Survey(PortalConnect As String, survey_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Get_By_CMS_Survey", survey_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_SurveyR_Delete(PortalConnect As String, reply_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SurveyR_Delete", reply_ID)
    End Sub
#End Region
#Region "CMS_Survey"
    Public Overrides Function CMS_Survey_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Survey_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Survey_Get(PortalConnect As String, survey_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Survey_Get", survey_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Survey_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Survey_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Survey_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String, find As String, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Survey_List_By_AppID", portalId, appID, find, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Survey_Add(PortalConnect As String, obj As CMS_SurveyInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Survey_Add", obj.Titles, obj.Contents, obj.LoGo, obj.IsType, obj.StartDate, obj.EndDate, obj.IsActive, obj.IsOrder, obj.PortalID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Survey_Update(PortalConnect As String, obj As CMS_SurveyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Survey_Update", obj.Survey_ID, obj.Titles, obj.Contents, obj.LoGo, obj.IsType, obj.StartDate, obj.EndDate, obj.IsActive, obj.IsOrder, obj.PortalID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Survey_Delete(PortalConnect As String, survey_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Survey_Delete", survey_ID)
    End Sub
#End Region
#Region "CMS_SurveyU"
    Public Overrides Function CMS_SurveyU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SurveyU_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SurveyU_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_SurveyU_Add(PortalConnect As String, obj As CMS_SurveyUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_SurveyU_Add", obj.Survey_ID, obj.AppID, obj.PortalID, obj.ReplyID, flReg.GetNull(obj.CreatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_SurveyU_Update(PortalConnect As String, obj As CMS_SurveyUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SurveyU_Update", obj.ID, obj.Survey_ID, obj.AppID, obj.PortalID, obj.ReplyID, flReg.GetNull(obj.CreatedDate))
    End Sub
    Public Overrides Sub CMS_SurveyU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SurveyU_Delete", iD)
    End Sub
#End Region
#Region "CMS_KhamBenh"
    Public Overrides Function CMS_KhamBenh_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_KhamBenh_Add(PortalConnect As String, obj As CMS_KhamBenhInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Add", obj.SoKB_ID, flReg.GetNull(obj.NgayKham), flReg.GetNull(obj.TrieuChung), flReg.GetNull(obj.ChuanDoan), flReg.GetNull(obj.DonThuoc), flReg.GetNull(obj.ChiPhi), flReg.GetNull(obj.GhiChu), obj.CreateDate, obj.UpdateDate), Integer)
    End Function
    Public Overrides Sub CMS_KhamBenh_Update(PortalConnect As String, obj As CMS_KhamBenhInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Update", obj.ID, obj.SoKB_ID, flReg.GetNull(obj.NgayKham), flReg.GetNull(obj.TrieuChung), flReg.GetNull(obj.ChuanDoan), flReg.GetNull(obj.DonThuoc), flReg.GetNull(obj.ChiPhi), flReg.GetNull(obj.GhiChu), obj.CreateDate, obj.UpdateDate)
    End Sub
    Public Overrides Function CMS_KhamBenh_Get_By_CMS_SoKB(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Get_By_CMS_SoKB", iD, page, recod), IDataReader)
    End Function
    Public Overrides Sub CMS_KhamBenh_Delete_By_CMS_SoKB(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Delete_By_CMS_SoKB", iD)
    End Sub
    Public Overrides Sub CMS_KhamBenh_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_KhamBenh_Delete", iD)
    End Sub
#End Region
#Region "CMS_SoKB"
    Public Overrides Function CMS_SoKB_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SoKB_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SoKB_List_By_AppID(PortalConnect As String, portalId As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_SoKB_List_By_AppID", portalId, appID), IDataReader)
    End Function
    Public Overrides Function CMS_SoKB_Add(PortalConnect As String, obj As CMS_SoKBInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_SoKB_Add", flReg.GetNull(obj.TEID), obj.AppID, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.HinhAnh, flReg.GetNull(obj.TienSu), flReg.GetNull(obj.ManCam), obj.CreateDate, obj.UpdateDate, flReg.GetNull(obj.PortalID)), Integer)
    End Function
    Public Overrides Sub CMS_SoKB_Update(PortalConnect As String, obj As CMS_SoKBInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SoKB_Update", obj.ID, flReg.GetNull(obj.TEID), obj.AppID, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.HinhAnh, flReg.GetNull(obj.TienSu), flReg.GetNull(obj.ManCam), obj.CreateDate, obj.UpdateDate, flReg.GetNull(obj.PortalID))
    End Sub
    Public Overrides Sub CMS_SoKB_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_SoKB_Delete", iD)
    End Sub
#End Region
#Region "CMS_Product"
    Public Overrides Function CMS_Product_List_By_ID(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_List_By_ID", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Product_Get_By_App(PortalConnect As String, portalID As Integer, appID As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_Get_By_App", portalID, appID, iD), IDataReader)
    End Function
    Public Overrides Function CMS_Product_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Product_Get_ByCount(PortalConnect As String, brandID As Integer, iD As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Product_Get_ByCount", brandID, iD), Integer)
    End Function
    Public Overrides Function CMS_Product_List_ShopBy(PortalConnect As String, piD As Integer, groupID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_List_ShopBy", piD, groupID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Product_List_Brand(PortalConnect As String, piD As Integer, brandID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_List_Brand", piD, brandID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Product_List_Search(PortalConnect As String, portalId As Integer, groupID As Integer, brandID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_List_Search", portalId, groupID, brandID, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Product_Add(PortalConnect As String, obj As CMS_ProductInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Product_Add", flReg.GetNull(obj.NhomSP), flReg.GetNull(obj.Brand_ID), flReg.GetNull(obj.MaSP), flReg.GetNull(obj.TenSP), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.CongDung), flReg.GetNull(obj.GiaBan), flReg.GetNull(obj.GiaKM), flReg.GetNull(obj.Sales), flReg.GetNull(obj.DVT), obj.VAT, obj.TichDiem, flReg.GetNull(obj.ThuocTinh), flReg.GetNull(obj.MoTa), obj.PortalID, obj.CreateDate, obj.CreateUser, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser)), Integer)
    End Function
    Public Overrides Sub CMS_Product_Update(PortalConnect As String, obj As CMS_ProductInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Update", obj.ID, flReg.GetNull(obj.NhomSP), flReg.GetNull(obj.Brand_ID), flReg.GetNull(obj.MaSP), flReg.GetNull(obj.TenSP), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.CongDung), flReg.GetNull(obj.GiaBan), flReg.GetNull(obj.GiaKM), flReg.GetNull(obj.Sales), flReg.GetNull(obj.DVT), obj.VAT, obj.TichDiem, flReg.GetNull(obj.ThuocTinh), flReg.GetNull(obj.MoTa), obj.PortalID, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser))
    End Sub
    Public Overrides Function CMS_Product_Get_By_CMS_ProductGroup(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_Get_By_CMS_ProductGroup", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Product_Get_By_CMS_ProductBrand(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Product_Get_By_CMS_ProductBrand", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_Product_Update_IsView(PortalConnect As String, proID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Update_IsView", proID)
    End Sub
    Public Overrides Sub CMS_Product_Update_IsShare(PortalConnect As String, proID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Update_IsShare", proID)
    End Sub
    Public Overrides Sub CMS_Product_Update_IsLock(PortalConnect As String, proID As Integer, isLock As Boolean, lockedDate As DateTime, lockedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Update_IsLock", proID, isLock, lockedDate, lockedUser)
    End Sub
    Public Overrides Sub CMS_Product_Update_IsDelete(PortalConnect As String, proID As Integer, isDel As Boolean, delDate As DateTime, delUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Update_IsDelete", proID, isDel, delDate, delUser)
    End Sub
    Public Overrides Sub CMS_Product_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Product_Delete", iD)
    End Sub
#End Region
#Region "CMS_ProductBrand"
    Public Overrides Function CMS_ProductBrand_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ProductBrand_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_List_Search", portalId, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_ProductBrand_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ProductBrand_Add(PortalConnect As String, obj As CMS_ProductBrandInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_Add", flReg.GetNull(obj.ThuongHieu), flReg.GetNull(obj.XuatXu), flReg.GetNull(obj.QuiUoc), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.MoTa), obj.PortalID, obj.CreateDate, obj.CreateUser, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser)), Integer)
    End Function
    Public Overrides Sub CMS_ProductBrand_Update(PortalConnect As String, obj As CMS_ProductBrandInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_Update", obj.ID, flReg.GetNull(obj.ThuongHieu), flReg.GetNull(obj.XuatXu), flReg.GetNull(obj.QuiUoc), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.MoTa), obj.PortalID, obj.CreateDate, obj.CreateUser, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser))
    End Sub
    Public Overrides Sub CMS_ProductBrand_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductBrand_Delete", iD)
    End Sub
#End Region
#Region "CMS_ProductGroup"
    Public Overrides Function CMS_ProductGroup_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductGroup_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ProductGroup_List_By_ParentID(PortalConnect As String, portalId As Integer, parentID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductGroup_List_By_ParentID", portalId, parentID), IDataReader)
    End Function
    Public Overrides Function CMS_ProductGroup_Add(PortalConnect As String, obj As CMS_ProductGroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ProductGroup_Add", flReg.GetNull(obj.TenNhom), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.GhiChu), flReg.GetNull(obj.ParentID), obj.PortalID, obj.CreateDate, obj.CreateUser, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser)), Integer)
    End Function
    Public Overrides Sub CMS_ProductGroup_Update(PortalConnect As String, obj As CMS_ProductGroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductGroup_Update", obj.ID, flReg.GetNull(obj.TenNhom), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.GhiChu), flReg.GetNull(obj.ParentID), obj.PortalID, obj.CreateDate, obj.CreateUser, flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser))
    End Sub
    Public Overrides Sub CMS_ProductGroup_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductGroup_Delete", iD)
    End Sub
#End Region
#Region "CMS_ProductImg"
    Public Overrides Function CMS_ProductImg_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ProductImg_Add(PortalConnect As String, obj As CMS_ProductImgInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Add", flReg.GetNull(obj.ProductID), flReg.GetNull(obj.Paths)), Integer)
    End Function
    Public Overrides Sub CMS_ProductImg_Update(PortalConnect As String, obj As CMS_ProductImgInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Update", obj.ID, flReg.GetNull(obj.ProductID), flReg.GetNull(obj.Paths))
    End Sub
    Public Overrides Function CMS_ProductImg_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Get_By_CMS_Product", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_ProductImg_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Delete_By_CMS_Product", iD)
    End Sub
    Public Overrides Sub CMS_ProductImg_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductImg_Delete", iD)
    End Sub
#End Region
#Region "CMS_ProductRate"
    Public Overrides Function CMS_ProductRate_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ProductRate_Add(PortalConnect As String, obj As CMS_ProductRateInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Add", obj.PortalID, obj.AppID, obj.ProductID, obj.IsRate, obj.CreatedUser, obj.CreatedDate, flReg.GetNull(obj.UpdatedUser), flReg.GetNull(obj.UpdatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_ProductRate_Update(PortalConnect As String, obj As CMS_ProductRateInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Update", obj.ID, obj.PortalID, obj.AppID, obj.ProductID, obj.IsRate, obj.CreatedUser, obj.CreatedDate, flReg.GetNull(obj.UpdatedUser), flReg.GetNull(obj.UpdatedDate))
    End Sub
    Public Overrides Function CMS_ProductRate_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Get_By_CMS_Product", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_ProductRate_Delete_By_CMS_Product(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Delete_By_CMS_Product", iD)
    End Sub
    Public Overrides Sub CMS_ProductRate_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductRate_Delete", iD)
    End Sub
#End Region
#Region "CMS_ProductComment"
    Public Overrides Function CMS_ProductComment_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ProductComment_List_Search(PortalConnect As String, productID As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_List_Search", productID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_ProductComment_Add(PortalConnect As String, obj As CMS_ProductCommentInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_Add", obj.ProductID, obj.AppID, flReg.GetNull(obj.Logo), obj.Contents, flReg.GetNull(obj.Reply), obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.IsLock), flReg.GetNull(obj.LockedUser), flReg.GetNull(obj.LockedDate), obj.IsDelete, flReg.GetNull(obj.DeletedDate)), Integer)
    End Function
    Public Overrides Sub CMS_ProductComment_Update(PortalConnect As String, obj As CMS_ProductCommentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_Update", obj.ID, obj.ProductID, obj.AppID, flReg.GetNull(obj.Logo), obj.Contents, flReg.GetNull(obj.Reply), obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.IsLock), flReg.GetNull(obj.LockedUser), flReg.GetNull(obj.LockedDate), obj.IsDelete, flReg.GetNull(obj.DeletedDate))
    End Sub
    Public Overrides Function CMS_ProductComment_Get_By_CMS_Product(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_Get_By_CMS_Product", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_ProductComment_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ProductComment_Delete", iD)
    End Sub
#End Region
#Region "CMS_ShopBy"
    Public Overrides Function CMS_ShopBy_Count(PortalConnect As String, portalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Count", portalID), Integer)
    End Function
    Public Overrides Function CMS_ShopBy_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Get", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_ShopBy_Update(PortalConnect As String, obj As CMS_ShopByInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Update", obj.ID, flReg.GetNull(obj.GhDonViVC), flReg.GetNull(obj.GhNgayGiao), flReg.GetNull(obj.GhNguoiGiao), flReg.GetNull(obj.GhMaVC), flReg.GetNull(obj.GhCuocVC), obj.GhCOD, flReg.GetNull(obj.GhTienThuHo), flReg.GetNull(obj.GhGhiChu), obj.UpdatedDate)
    End Sub
    Public Overrides Function CMS_ShopBy_Add(PortalConnect As String, obj As CMS_ShopByInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Add", obj.MaDonHang, obj.AppID, obj.HoTen, obj.Mobile, obj.Telephone, obj.DiaChi, obj.TinhTP, obj.QuanHuyen, obj.GhiChu, obj.TongTien, obj.TongVAT, obj.CreatedDate, obj.UpdatedDate, obj.PortalID, obj.VoucherID, obj.VoucherPrice, obj.UpPoint, obj.AddPoint), String)
    End Function
    Public Overrides Sub CMS_ShopBy_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Delete", iD)
    End Sub
    Public Overrides Function CMS_ShopBy_List_Search(PortalConnect As String, portalId As Integer, search As String, isOrder As Integer, tinhTP As Integer, quanHuyen As Integer, tinhTrang As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_List_Search", portalId, search, isOrder, tinhTP, quanHuyen, tinhTrang, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_ShopBy_List_AppID(PortalConnect As String, portalId As Integer, search As String, appID As String, currPage As Integer, recodperpage As Integer, trangThai As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_List_AppID", portalId, search, appID, currPage, recodperpage, trangThai), IDataReader)
    End Function
    Public Overrides Sub CMS_ShopBy_Update_TinhTrang(PortalConnect As String, iD As Integer, tinhTrang As Integer, lyDoHuy As String, nguoiHuy As String, ngayHuy As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopBy_Update_TinhTrang", iD, tinhTrang, lyDoHuy, nguoiHuy, ngayHuy)
    End Sub
#End Region
#Region "CMS_ShopPro"
    Public Overrides Function CMS_ShopPro_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ShopPro_Add(PortalConnect As String, obj As CMS_ShopProInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Add", obj.ShopBy_ID, obj.Product_ID, obj.DonGia, obj.SoLuong, obj.VAT), Integer)
    End Function
    Public Overrides Sub CMS_ShopPro_Update(PortalConnect As String, obj As CMS_ShopProInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Update", obj.ID, obj.ShopBy_ID, obj.Product_ID, obj.DonGia, obj.SoLuong, obj.VAT)
    End Sub
    Public Overrides Function CMS_ShopPro_Get_By_CMS_ShopBy(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Get_By_CMS_ShopBy", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_ShopPro_Delete_By_CMS_ShopBy(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Delete_By_CMS_ShopBy", iD)
    End Sub
    Public Overrides Sub CMS_ShopPro_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ShopPro_Delete", iD)
    End Sub
#End Region
#Region "CMS_Menu"
    Public Overrides Function CMS_Menu_Get(PortalConnect As String, menuID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Menu_Get", menuID), IDataReader)
    End Function
    Public Overrides Function CMS_Menu_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Menu_List", portalId), IDataReader)
    End Function
#End Region
#Region "CMS_MenuD"
    Public Overrides Function CMS_MenuD_Get(PortalConnect As String, menuD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Get", menuD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_MenuID(PortalConnect As String, menuID As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_List_By_MenuID", menuID, portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_ParentID(PortalConnect As String, paID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_List_By_ParentID", paID), IDataReader)
    End Function
    Public Overrides Sub CMS_MenuD_Update_Quick(PortalConnect As String, menuD_ID As String, parent_ID As String, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Update_Quick", menuD_ID, parent_ID, isOrder)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete_By_MenuID(PortalConnect As String, menu_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Delete_By_MenuID", menu_ID)
    End Sub
    Public Overrides Sub CMS_MenuD_Add(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Add", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Update(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Update", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete(PortalConnect As String, menuD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MenuD_Delete", menuD_ID)
    End Sub
#End Region
#Region "CMS_ImageN"
    Public Overrides Function CMS_ImageN_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ImageN_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ImageN_List_Search(PortalConnect As String, PortalId As Integer, CateId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_List_Search", PortalId, CateId, search, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function CMS_ImageN_Add(PortalConnect As String, obj As CMS_ImageNInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_Add", obj.PortailID, obj.CateID, obj.Titles, obj.Des, obj.Logo, obj.IsActive, obj.IsOder, obj.CreateDated, obj.CreateUser), Integer)
    End Function
    Public Overrides Sub CMS_ImageN_Update(PortalConnect As String, obj As CMS_ImageNInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_Update", obj.ID, obj.PortailID, obj.CateID, obj.Titles, obj.Des, obj.Logo, obj.IsActive, obj.IsOder, obj.CreateDated, obj.CreateUser)
    End Sub
    Public Overrides Sub CMS_ImageN_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ImageN_Delete", iD)
    End Sub
#End Region
#Region "CMS_ImageD"
    Public Overrides Function CMS_ImageD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ImageD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ImageD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_ImageD_Add(PortalConnect As String, obj As CMS_ImageDInfo)
        SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_Add", obj.ID, obj.PortalID, obj.Img_ID, obj.FileAttach, obj.Des, obj.Url, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_ImageD_Update(PortalConnect As String, obj As CMS_ImageDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_Update", obj.ID, obj.PortalID, obj.Img_ID, obj.FileAttach, obj.Des, obj.Url, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_ImageD_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_Delete", iD)
    End Sub
    Public Overrides Function CMS_ImageD_List_ByImageN(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_List_ByImageN", idKey, type, top), IDataReader)
    End Function
    Public Overrides Function CMS_ImageD_List_Cate(PortalConnect As String, portalId As Integer, Id As Integer, type As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ImageD_List_Cate", portalId, Id, type), IDataReader)
    End Function
#End Region
#Region "CMS_ChuyenGia"
    Public Overrides Function CMS_ChuyenGia_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_ChuyenGia_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ChuyenGia_List_Search(PortalConnect As String, portalId As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_List_Search", portalId, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_ChuyenGia_List_Search_Top(PortalConnect As String, PortalID As Integer, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_List_Search_Top", PortalID, Top), IDataReader)
    End Function

    Public Overrides Function CMS_ChuyenGia_Add(PortalConnect As String, obj As CMS_ChuyenGiaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_Add", obj.Ten, obj.ChucDanh, obj.LoGo, obj.ChucVu, obj.GioiThieu, obj.QuaTrinhCongTac, obj.ThuTu, obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser), Integer)
    End Function
    Public Overrides Sub CMS_ChuyenGia_Update(PortalConnect As String, obj As CMS_ChuyenGiaInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_Update", obj.Id, obj.Ten, obj.ChucDanh, obj.LoGo, obj.ChucVu, obj.GioiThieu, obj.QuaTrinhCongTac, obj.ThuTu, obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
    End Sub
    Public Overrides Sub CMS_ChuyenGia_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_ChuyenGia_Delete", id)
    End Sub
#End Region
#Region "CMS_VanChuyen"
    Public Overrides Function CMS_VanChuyen_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_VanChuyen_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_List"), IDataReader)
    End Function
    Public Overrides Function CMS_VanChuyen_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_List_Search", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_VanChuyen_Add(PortalConnect As String, obj As CMS_VanChuyenInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_Add", flReg.GetNull(obj.TenDonVi), flReg.GetNull(obj.MoTa), flReg.GetNull(obj.NgayTao), flReg.GetNull(obj.NguoiTao), flReg.GetNull(obj.NgayThayDoi), flReg.GetNull(obj.NguoiThayDoi)), Integer)
    End Function
    Public Overrides Sub CMS_VanChuyen_Update(PortalConnect As String, obj As CMS_VanChuyenInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_Update", obj.ID, flReg.GetNull(obj.TenDonVi), flReg.GetNull(obj.MoTa), flReg.GetNull(obj.NgayTao), flReg.GetNull(obj.NguoiTao), flReg.GetNull(obj.NgayThayDoi), flReg.GetNull(obj.NguoiThayDoi))
    End Sub
    Public Overrides Sub CMS_VanChuyen_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VanChuyen_Delete", iD)
    End Sub
#End Region
#Region "CMS_SiteMap"
    Public Overrides Function CMS_SiteMap_Get(PortalConnect As String, siteMap_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_Get", siteMap_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SiteMap_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_SiteMap_Add(PortalConnect As String, obj As CMS_SiteMapInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_Add", obj.SiteMap_ID, obj.SiteMap_Name, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdateBy), flReg.GetNull(obj.UserUpdate), obj.IsOrder, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_SiteMap_Update(PortalConnect As String, obj As CMS_SiteMapInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_Update", obj.SiteMap_ID, obj.SiteMap_Name, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdateBy), flReg.GetNull(obj.UserUpdate), obj.IsOrder, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_SiteMap_Delete(PortalConnect As String, siteMap_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect(PortalConnect), "CMS_SiteMap_Delete", siteMap_ID)
    End Sub
#End Region
#Region "CMS_Voucher"
    Public Overrides Function CMS_Voucher_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Voucher_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Voucher_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, brandID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_List_Search", portalID, search, isOrder, currPage, recodperpage, brandID), IDataReader)
    End Function
    Public Overrides Function CMS_Voucher_Add(PortalConnect As String, obj As CMS_VoucherInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_Add", flReg.GetNull(obj.BrandID), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.MoTa), obj.DiemDoi, obj.DieuKien, obj.MucGiam, obj.SoLuong, obj.DaPhat, obj.TuNgay, obj.DenNgay, obj.PortalID, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Voucher_Update(PortalConnect As String, obj As CMS_VoucherInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_Update", obj.ID, flReg.GetNull(obj.BrandID), flReg.GetNull(obj.AnhDaiDien), flReg.GetNull(obj.MoTa), obj.DiemDoi, obj.DieuKien, obj.MucGiam, obj.SoLuong, obj.DaPhat, obj.TuNgay, obj.DenNgay, obj.PortalID, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Voucher_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_Voucher_Delete", iD)
    End Sub
#End Region
#Region "CMS_VoucherApp"
    Public Overrides Function CMS_VoucherApp_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_VoucherApp_List_AppID(PortalConnect As String, portalID As Integer, appID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_List_AppID", portalID, appID, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_VoucherApp_List_Search(PortalConnect As String, portalID As Integer, search As String, isOrder As Integer, voucherID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_List_Search", portalID, search, isOrder, voucherID), IDataReader)
    End Function

    Public Overrides Function CMS_VoucherApp_Add(PortalConnect As String, obj As CMS_VoucherAppInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_Add", obj.PortalID, obj.VoucherID, obj.AppID, obj.SuDung, obj.IsSend, flReg.GetNull(obj.FromApp), flReg.GetNull(obj.FromDate), obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Sub CMS_VoucherApp_Update(PortalConnect As String, obj As CMS_VoucherAppInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_Update", obj.ID, obj.PortalID, obj.VoucherID, obj.AppID, obj.SuDung, obj.IsSend, flReg.GetNull(obj.FromApp), flReg.GetNull(obj.FromDate), obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_VoucherApp_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_Delete", iD)
    End Sub
    Public Overrides Sub CMS_VoucherApp_Update_SuDung(PortalConnect As String, PortalID As Integer, voucherID As Integer, appID As String, suDung As Boolean, ngayDung As DateTime, donHang As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_VoucherApp_Update_SuDung", PortalID, voucherID, appID, suDung, ngayDung, donHang)
    End Sub
#End Region
#Region "CMS_WebLink"
    Public Overrides Function CMS_WebLink_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_WebLink_Update_Order(PortalConnect As String, Id As Integer, OrderNo As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_Update_Order", Id, OrderNo)
    End Sub
    Public Overrides Function CMS_WebLink_List_Search(PortalConnect As String, Name As String, ViewType As Integer, PortalId As Integer, LanguageId As String, PageSize As Integer, PageIndex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_List_Search", Name, ViewType, PortalId, LanguageId, PageSize, PageIndex), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_Add(PortalConnect As String, obj As CMS_WebLinkInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_Add", flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate)), Integer)
    End Function
    Public Overrides Sub CMS_WebLink_Update(PortalConnect As String, obj As CMS_WebLinkInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_Update", obj.Id, flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate))
    End Sub
    Public Overrides Sub CMS_WebLink_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_WebLink_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsVote"
    Public Overrides Function CMS_NewsVote_Get_NID(PortalConnect As String, nid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_NewsVote_Get_NID", nid), IDataReader)
    End Function
    Public Overrides Function CMS_NewsVote_Add(PortalConnect As String, obj As CMS_NewsVoteInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_NewsVote_Add", obj.NewsID, obj.Votes, obj.IP, obj.VoteDate), Integer)
    End Function
    Public Overrides Sub CMS_NewsVote_Delete(PortalConnect As String, newsV_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_NewsVote_Delete", newsV_ID)
    End Sub
#End Region
#Region "CMS_MetaSEO"
    Public Overrides Function CMS_MetaSEO_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_MetaSEO_Get_IDKey(PortalConnect As String, iDKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_Get_IDKey", iDKey), IDataReader)
    End Function
    Public Overrides Function CMS_MetaSEO_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_List"), IDataReader)
    End Function
    Public Overrides Function CMS_MetaSEO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_MetaSEO_Add(PortalConnect As String, obj As CMS_MetaSEOInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_Add", obj.IDKey, obj.Titles, obj.MetaDes, obj.MetaKeyWord, obj.IsIndex), Integer)
    End Function
    Public Overrides Sub CMS_MetaSEO_Update(PortalConnect As String, obj As CMS_MetaSEOInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_Update", obj.ID, obj.IDKey, obj.Titles, obj.MetaDes, obj.MetaKeyWord, obj.IsIndex)
    End Sub
    Public Overrides Sub CMS_MetaSEO_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MobileConnect(PortalConnect), "CMS_MetaSEO_Delete", iD)
    End Sub

#End Region


End Class