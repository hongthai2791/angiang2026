Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.CMS", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

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
#Region "CMS_Authors"
    Public MustOverride Function CMS_Authors_Get(PortalConnect As String, authors_ID As String) As IDataReader
    Public MustOverride Function CMS_Authors_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Authors_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Authors_Add(PortalConnect As String, obj As CMS_AuthorsInfo)
    Public MustOverride Sub CMS_Authors_Update(PortalConnect As String, obj As CMS_AuthorsInfo)
    Public MustOverride Sub CMS_Authors_Delete(PortalConnect As String, authors_ID As String)
#End Region
#Region "CMS_Calendar"
    Public MustOverride Function CMS_Calendar_Get(PortalConnect As String, calendar_ID As String) As IDataReader
    Public MustOverride Function CMS_Calendar_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Calendar_Add(PortalConnect As String, obj As CMS_CalendarInfo)
    Public MustOverride Sub CMS_Calendar_Update(PortalConnect As String, obj As CMS_CalendarInfo)
    Public MustOverride Sub CMS_Calendar_Delete(PortalConnect As String, calendar_ID As String)
#End Region
#Region "CMS_ConfigSystem"
    Public MustOverride Function CMS_ConfigSystem_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ConfigSystem_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ConfigSystem_Get_PortalID(PortalConnect As String, PortalID As Integer) As IDataReader
    Public MustOverride Sub CMS_ConfigSystem_Add(PortalConnect As String, obj As CMS_ConfigSystemInfo)
    Public MustOverride Sub CMS_ConfigSystem_Update(PortalConnect As String, obj As CMS_ConfigSystemInfo)
    Public MustOverride Sub CMS_ConfigSystem_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_DocUnit"
    Public MustOverride Function CMS_DocUnit_Get(PortalConnect As String, docField_ID As String) As IDataReader
    Public MustOverride Function CMS_DocUnit_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DocUnit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_DocUnit_Add(PortalConnect As String, obj As CMS_DocUnitInfo)
    Public MustOverride Sub CMS_DocUnit_Update(PortalConnect As String, obj As CMS_DocUnitInfo)
    Public MustOverride Sub CMS_DocUnit_Delete(PortalConnect As String, docField_ID As String)
#End Region
#Region "CMS_DocField"
    Public MustOverride Function CMS_DocField_Get(PortalConnect As String, docField_ID As String) As IDataReader
    Public MustOverride Function CMS_DocField_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DocField_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_DocField_Add(PortalConnect As String, obj As CMS_DocFieldInfo)
    Public MustOverride Sub CMS_DocField_Update(PortalConnect As String, obj As CMS_DocFieldInfo)
    Public MustOverride Sub CMS_DocField_Delete(PortalConnect As String, docField_ID As String)
#End Region
#Region "CMS_DocType"
    Public MustOverride Function CMS_DocType_Get(PortalConnect As String, docType_ID As String) As IDataReader
    Public MustOverride Function CMS_DocType_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DocType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_DocType_Add(PortalConnect As String, obj As CMS_DocTypeInfo)
    Public MustOverride Sub CMS_DocType_Update(PortalConnect As String, obj As CMS_DocTypeInfo)
    Public MustOverride Sub CMS_DocType_Delete(PortalConnect As String, docType_ID As String)
#End Region
#Region "CMS_Document"
    Public MustOverride Function CMS_Document_Get(PortalConnect As String, document_ID As String) As IDataReader
    Public MustOverride Function CMS_Document_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Document_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, docGroup_ID As String) As IDataReader
    Public MustOverride Function CMS_Document_List_Home(PortalConnect As String, search As String, DocType_ID As String, docFiled_ID As String, docUnit_ID As String, docGroup_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_Document_Add(PortalConnect As String, obj As CMS_DocumentInfo)
    Public MustOverride Sub CMS_Document_Update(PortalConnect As String, obj As CMS_DocumentInfo)
    Public MustOverride Sub CMS_Document_Delete(PortalConnect As String, document_ID As String)
    Public MustOverride Sub CMS_Document_Update_IsDownload(PortalConnect As String, document_ID As String)
    Public MustOverride Sub CMS_Document_Update_IsActive(PortalConnect As String, document_ID As String, IsActive As Boolean, UpdatedBy As DateTime, UpdateName As String)
    Public MustOverride Function CMS_Document_ListCheck_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, isActive As Boolean) As IDataReader

#End Region
#Region "CMS_DocGroup"
    Public MustOverride Function CMS_DocGroup_List_Parent_NULL(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DocGroup_Get(PortalConnect As String, docGroupID As String) As IDataReader
    Public MustOverride Function CMS_DocGroup_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_DocGroup_Add(PortalConnect As String, obj As CMS_DocGroupInfo)
    Public MustOverride Sub CMS_DocGroup_Update(PortalConnect As String, obj As CMS_DocGroupInfo)
    Public MustOverride Function CMS_DocGroup_Get_By_CMS_DocGroup(PortalConnect As String, docGroupID As String) As IDataReader
    Public MustOverride Sub CMS_DocGroup_Delete_By_CMS_DocGroup(PortalConnect As String, docGroupID As String)
    Public MustOverride Sub CMS_DocGroup_Delete(PortalConnect As String, docGroupID As String)
#End Region
#Region "CMS_Events"
    Public MustOverride Function CMS_Events_Get(PortalConnect As String, event_ID As String) As IDataReader
    Public MustOverride Function CMS_Events_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Events_Add(PortalConnect As String, obj As CMS_EventsInfo)
    Public MustOverride Sub CMS_Events_Update(PortalConnect As String, obj As CMS_EventsInfo)
    Public MustOverride Sub CMS_Events_Delete(PortalConnect As String, event_ID As String)
#End Region
#Region "CMS_Field"
    Public MustOverride Function CMS_Field_Get(PortalConnect As String, field_ID As String) As IDataReader
    Public MustOverride Function CMS_Field_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Field_Add(PortalConnect As String, obj As CMS_FieldInfo)
    Public MustOverride Sub CMS_Field_Update(PortalConnect As String, obj As CMS_FieldInfo)
    Public MustOverride Sub CMS_Field_Delete(PortalConnect As String, field_ID As String)
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
#Region "CMS_NewsPapers"
    Public MustOverride Function CMS_NewsPapers_Get(PortalConnect As String, newsPapers_ID As String) As IDataReader
    Public MustOverride Function CMS_NewsPapers_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_NewsPapers_Add(PortalConnect As String, obj As CMS_NewsPapersInfo)
    Public MustOverride Sub CMS_NewsPapers_Update(PortalConnect As String, obj As CMS_NewsPapersInfo)
    Public MustOverride Sub CMS_NewsPapers_Delete(PortalConnect As String, newsPapers_ID As String)
#End Region
#Region "CMS_NewsPapersD"
    Public MustOverride Function CMS_NewsPapersD_Get(PortalConnect As String, newsPapersD_ID As String) As IDataReader
    Public MustOverride Function CMS_NewsPapersD_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_NewsPapersD_Add(PortalConnect As String, obj As CMS_NewsPapersDInfo)
    Public MustOverride Sub CMS_NewsPapersD_Update(PortalConnect As String, obj As CMS_NewsPapersDInfo)
    Public MustOverride Function CMS_NewsPapersD_Get_By_CMS_NewsPapers(PortalConnect As String, newsPapers_ID As String) As IDataReader
    Public MustOverride Sub CMS_NewsPapersD_Delete(PortalConnect As String, newsPapersD_ID As String)
#End Region
#Region "CMS_NewsRoy"
    Public MustOverride Function CMS_NewsRoy_Get(PortalConnect As String, newsRoy_ID As String) As IDataReader
    Public MustOverride Function CMS_NewsRoy_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_NewsRoy_Add(PortalConnect As String, obj As CMS_NewsRoyInfo)
    Public MustOverride Sub CMS_NewsRoy_Update(PortalConnect As String, obj As CMS_NewsRoyInfo)
    Public MustOverride Function CMS_NewsRoy_Get_By_CMS_News(PortalConnect As String, newId As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsRoy_Delete(PortalConnect As String, newsRoy_ID As String)
#End Region
#Region "CMS_Notify"
    Public MustOverride Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As IDataReader
    Public MustOverride Function CMS_Notify_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo)
    Public MustOverride Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
    Public MustOverride Sub CMS_Notify_Delete(PortalConnect As String, notify_ID As String)
#End Region
#Region "CMS_PageLocal"
    Public MustOverride Function CMS_PageLocal_Get(PortalConnect As String, pageLocalID As Integer) As IDataReader
    Public MustOverride Function CMS_PageLocal_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_PageLocal_Add(PortalConnect As String, obj As CMS_PageLocalInfo)
    Public MustOverride Sub CMS_PageLocal_Update(PortalConnect As String, obj As CMS_PageLocalInfo)
    Public MustOverride Sub CMS_PageLocal_Delete(PortalConnect As String, pageLocalID As Integer)
#End Region
#Region "CMS_PenName"
    Public MustOverride Function CMS_PenName_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_PenName_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_PenName_Add(PortalConnect As String, obj As CMS_PenNameInfo)
    Public MustOverride Sub CMS_PenName_Update(PortalConnect As String, obj As CMS_PenNameInfo)
    Public MustOverride Sub CMS_PenName_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Setups"
    Public MustOverride Function CMS_Setups_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function CMS_Setups_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Setups_Get_By_Name(PortalConnect As String, settingName As String) As IDataReader
    Public MustOverride Sub CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
    Public MustOverride Sub CMS_Setups_Update(PortalConnect As String, obj As CMS_SetupsInfo)
    Public MustOverride Sub CMS_Setups_Delete(PortalConnect As String, iD As String)
#End Region
#Region "CMS_SiteMap"
    Public MustOverride Function CMS_SiteMap_Get(PortalConnect As String, siteMap_ID As String) As IDataReader
    Public MustOverride Function CMS_SiteMap_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_SiteMap_Add(PortalConnect As String, obj As CMS_SiteMapInfo)
    Public MustOverride Sub CMS_SiteMap_Update(PortalConnect As String, obj As CMS_SiteMapInfo)
    Public MustOverride Sub CMS_SiteMap_Delete(PortalConnect As String, siteMap_ID As String)
#End Region
#Region "CMS_Block"
    Public MustOverride Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As IDataReader
    Public MustOverride Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As IDataReader
#End Region
#Region "CMS_Contact"
    Public MustOverride Function CMS_Contact_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Contact_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_Contact_Update_Status(PortalConnect As String, Optional id As Integer = 1, Optional status As Boolean = 1)
    Public MustOverride Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PortalId As Integer, Status As Integer, PageSize As Integer, PageIndex As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Contact_Add(PortalConnect As String, obj As CMS_ContactInfo) As Integer
    Public MustOverride Sub CMS_Contact_Update(PortalConnect As String, obj As CMS_ContactInfo)
    Public MustOverride Sub CMS_Contact_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Departments"
    Public MustOverride Function CMS_Departments_NguoiDung_Get_By_UserId(PortalConnect As String, UserId As String, PortalId As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_GetByParentId(PortalConnect As String, PortalId As Integer, ParentId As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Departments_NguoiDung_GetByNguoiDung(PortalConnect As String, Nguoidung As String, PortalId As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_NguoiDung_Get_ChucVu(PortalConnect As String, UserId As String, chucVu As String) As String
    Public MustOverride Function CMS_Departments_Add(PortalConnect As String, obj As CMS_DepartmentsInfo) As Integer
    Public MustOverride Sub CMS_Departments_Update(PortalConnect As String, obj As CMS_DepartmentsInfo)
    Public MustOverride Sub CMS_Departments_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Departments_ChucVu"
    Public MustOverride Function CMS_Departments_ChucVu_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_ChucVu_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_Departments_ChucVu_Add(PortalConnect As String, obj As CMS_Departments_ChucVuInfo) As Integer
    Public MustOverride Sub CMS_Departments_ChucVu_Update(PortalConnect As String, obj As CMS_Departments_ChucVuInfo)
    Public MustOverride Sub CMS_Departments_ChucVu_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Departments_NguoiDung"
    Public MustOverride Function CMS_Departments_NguoiDung_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_NguoiDung_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(PortalConnect As String, U_Id As String, DepartmentId As Integer, PortalId As Integer) As IDataReader
    Public MustOverride Function CMS_Departments_NguoiDung_List_UserID(PortalConnect As String, UserId As String, PortalId As Integer) As IDataReader

    Public MustOverride Function CMS_Departments_NguoiDung_Add(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo) As Integer
    Public MustOverride Sub CMS_Departments_NguoiDung_Update(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo)
    Public MustOverride Sub CMS_Departments_NguoiDung_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_DMNhuanBut"
    Public MustOverride Function CMS_DMNhuanBut_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_DMNhuanBut_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DMNhuanBut_Get_By_Type(PortalConnect As String, Type As Integer, Month As Integer, Year As Integer) As IDataReader
    Public MustOverride Function CMS_DMNhuanBut_List_Search(PortalConnect As String, search As String, isOrder As Integer, Months As Integer, Years As Integer) As IDataReader

    Public MustOverride Function CMS_DMNhuanBut_Add(PortalConnect As String, obj As CMS_DMNhuanButInfo) As Integer
    Public MustOverride Sub CMS_DMNhuanBut_Update(PortalConnect As String, obj As CMS_DMNhuanButInfo)
    Public MustOverride Sub CMS_DMNhuanBut_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_FAQ"
    Public MustOverride Function CMS_FAQ_Get(PortalConnect As String, id As String) As IDataReader
    Public MustOverride Function CMS_FAQ_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_FAQ_Add(PortalConnect As String, obj As CMS_FAQInfo) As Integer
    Public MustOverride Sub CMS_FAQ_Update(PortalConnect As String, obj As CMS_FAQInfo)
    Public MustOverride Sub CMS_FAQ_Delete(PortalConnect As String, id As String)
#End Region
#Region "CMS_FAQAnswers"
    Public MustOverride Function CMS_FAQAnswers_Get(PortalConnect As String, id As String) As IDataReader
    Public MustOverride Function CMS_FAQAnswers_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_FAQAnswers_Add(PortalConnect As String, obj As CMS_FAQAnswersInfo) As Integer
    Public MustOverride Sub CMS_FAQAnswers_Update(PortalConnect As String, obj As CMS_FAQAnswersInfo)
    Public MustOverride Sub CMS_FAQAnswers_Delete(PortalConnect As String, id As String)
#End Region
#Region "CMS_FAQQuestions"
    Public MustOverride Function CMS_FAQQuestions_Get(PortalConnect As String, id As String) As IDataReader
    Public MustOverride Function CMS_FAQQuestions_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_FAQQuestions_List_Search(PortalConnect As String, search As String, fAQID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Status As Integer) As IDataReader
    Public MustOverride Function CMS_FAQQuestions_Add(PortalConnect As String, obj As CMS_FAQQuestionsInfo) As Integer
    Public MustOverride Sub CMS_FAQQuestions_Update(PortalConnect As String, obj As CMS_FAQQuestionsInfo)
    Public MustOverride Sub CMS_FAQQuestions_Update_Answer(PortalConnect As String, Id As Integer, ContentAnswer As String, AnswerName As String, AnswerUser As String, AnswerDate As DateTime)
    Public MustOverride Sub CMS_FAQQuestions_Update_Status(PortalConnect As String, Id As Integer, Status As Integer)
    Public MustOverride Sub CMS_FAQQuestions_Delete(PortalConnect As String, id As String)
#End Region
#Region "CMS_Media"
    Public MustOverride Function CMS_Media_List_Home(PortalConnect As String, PortalId As Integer, LanguageId As String, Id As String, type As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_Media_Search_Home(PortalConnect As String, PortalId As Integer, LanguageId As String, datefrom As Date, dateto As Date, key As String, categoryid As Integer, PageIndex As Integer, PageSize As Integer, arrPhongBan As String, uid As Integer, isImage As Boolean, type As Integer) As IDataReader
    Public MustOverride Function CMS_Media_List_Select(PortalConnect As String, datefrom As Date, dateto As Date, title As String, danhmuc As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, Type As Integer, Settings As Integer) As IDataReader
    Public MustOverride Function CMS_Media_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Media_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Media_Get_By_News_ID(PortalConnect As String, newsid As Integer) As IDataReader
    Public MustOverride Function CMS_Media_List_Search(PortalConnect As String, Status As Integer, UserName As String, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Media_Admin_Search_Count(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Media_Admin_Search(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, TrangThai As Integer, PageIndex As Integer, PageSize As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Sub CMS_Media_GuiDuyet(PortalConnect As String, id As Integer, TrangThai As Integer, UserId As String, DateUpdate As DateTime)
    Public MustOverride Sub CMS_Media_Duyet(PortalConnect As String, id As Integer, Trangthai As Integer, DateUpdate As DateTime, UserAprrove As String)
    Public MustOverride Sub CMS_Media_Delete_Update(PortalConnect As String, IsDelete As Boolean, DeleteDate As Date, DeleteUser As String, Id As Integer)
    Public MustOverride Function CMS_Media_Add(PortalConnect As String, obj As CMS_MediaInfo) As Integer
    Public MustOverride Sub CMS_Media_Update(PortalConnect As String, obj As CMS_MediaInfo)
    Public MustOverride Sub CMS_Media_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_News"

    Public MustOverride Function CMS_News_List_ToApp(PortalConnect As String, PortalID As Integer, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, isImages As Boolean, WBID As String) As IDataReader
    Public MustOverride Function CMS_News_List_MostView(PortalConnect As Integer, PortalId As Integer, top As Integer) As IDataReader
    Public MustOverride Function CMS_News_Search_Home(PortalConnect As Integer, PortalId As Integer, tags As String, datefrom As Date, dateto As Date, categoryid As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean, key As String, advanced As Integer) As IDataReader
    Public MustOverride Function CMS_News_Search_HomeMobile(PortalConnect As Integer, PortalId As Integer, categoryid As Integer, PageIndex As Integer, PageSize As Integer, key As String, status As Integer) As IDataReader
    Public MustOverride Function CMS_Notification(PortalID As Integer, IsLang As String, Table As String, Status As Integer, isStep As Boolean, WfID As Integer, WF_RETURN As Integer, UserName As String, cateAll As Boolean) As Integer
    Public MustOverride Function CMS_News_List_UserName(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_News_ListAdmin_Count(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, UserName As String, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_News_ListAdmin_Search(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Function CMS_News_ListAdmin_Progress(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, Status As Integer, UserId As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, ToUrl As String, fromDate As DateTime, toDate As DateTime) As IDataReader
    Public MustOverride Sub CMS_News_Update_Tags_Media(PortalConnect As String, NewID As Integer, Tags As String)
    Public MustOverride Function CMS_News_List_GetLink(PortalConnect As String, datefrom As DateTime, dateto As DateTime, title As String, categoryid As Integer, PortalId As Integer, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Sub CMS_News_Update_Visible(PortalConnect As String, NewId As Integer, IsVisible As Boolean)
    Public MustOverride Sub CMS_News_Update_IsMobile(PortalConnect As String, NewId As Integer, IsMobile As Boolean)
    Public MustOverride Function CMS_NewsByCategory_GetByNewsId(PortalConnect As String, PortalID As Integer, LanguageId As String, newsId As Integer) As IDataReader
    Public MustOverride Function CMS_BackWF_News(PortalConnect As String, NewsID As Integer) As IDataReader
    Public MustOverride Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As IDataReader
    Public MustOverride Sub CMS_Update_View(PortalConnect As String, IdKey As String, ID As Integer)
    Public MustOverride Function CMS_News_Get(PortalConnect As String, newId As Integer) As IDataReader
    Public MustOverride Function CMS_News_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_News_HomeBlock(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As IDataReader
    Public MustOverride Function CMS_News_HomeMobile(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As IDataReader
    Public MustOverride Function CMS_News_SameCate(PortalConnect As String, PortalId As Integer, newid As Integer, catid As Integer, count As Integer) As IDataReader
    Public MustOverride Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean) As IDataReader
    Public MustOverride Function CMS_News_List_Search(PortalConnect As String, Status As Integer, WfID As Integer, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, UserName As String, isStep As Boolean, isImages As Boolean, WF_RETURN As Integer, cateAll As Boolean) As IDataReader
    Public MustOverride Function CMS_News_List_Search_All(PortalConnect As String, Search As String, categoryid As Integer, PortalID As Integer, PageIndex As Integer, PageSize As Integer, isImages As Boolean) As IDataReader
    Public MustOverride Sub CMS_News_Update_Lock(PortalConnect As String, NewId As Integer, lock As Boolean, UserId As String)
    Public MustOverride Function CMS_News_GetLocks(PortalConnect As String, PortalId As Integer, LanguageId As String, Search As String, Optional newsid As Integer = 0) As IDataReader
    Public MustOverride Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
    Public MustOverride Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
    Public MustOverride Sub CMS_News_Delete(PortalConnect As String, newId As Integer)
    Public MustOverride Sub CMS_News_Update_Status(PortalConnect As String, newid As Integer, Status As Integer, UserId As String, publisedDate As DateTime)
#End Region
#Region "CMS_News_NB"
    Public MustOverride Function CMS_News_NB_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_News_NB_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_News_NB_Get_By_NewsID(PortalConnect As String, newsID As Integer, Type As Integer) As IDataReader

    Public MustOverride Function CMS_News_NB_Add(PortalConnect As String, obj As CMS_News_NBInfo) As Integer
    Public MustOverride Sub CMS_News_NB_Update(PortalConnect As String, obj As CMS_News_NBInfo)
    Public MustOverride Sub CMS_News_NB_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_News_NBDetail"
    Public MustOverride Function CMS_News_NBDetail_Get(PortalConnect As String, detail_ID As Integer) As IDataReader
    Public MustOverride Function CMS_News_NBDetail_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_News_NBDetail_List_By_NewsNBID(PortalConnect As String, NewsNB_ID As Integer) As IDataReader
    Public MustOverride Function CMS_News_NBDetail_Get_By_NB_DM_ID(PortalConnect As String, NB_ID As Integer, DM_ID As Integer) As IDataReader

    Public MustOverride Function CMS_News_NBDetail_Add(PortalConnect As String, obj As CMS_News_NBDetailInfo) As Integer
    Public MustOverride Sub CMS_News_NBDetail_Update(PortalConnect As String, obj As CMS_News_NBDetailInfo)
    Public MustOverride Function CMS_News_NBDetail_Get_By_CMS_News_NB(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub CMS_News_NBDetail_Delete(PortalConnect As String, detail_ID As Integer)
#End Region
#Region "CMS_News_Process"
    Public MustOverride Function CMS_News_Process_GetByNewsId(PortalConnect As String, ItemId As Integer, Type As Integer) As IDataReader

    Public MustOverride Function CMS_News_Process_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_News_Process_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(PortalConnect As String, NewsID As Integer, UserId As String, isActive As Boolean)
    Public MustOverride Sub CMS_News_Update_Tags(PortalConnect As String, NewID As Integer, Tags As String)
    Public MustOverride Function CMS_News_Process_Add(PortalConnect As String, obj As CMS_News_ProcessInfo) As Integer
    Public MustOverride Sub CMS_News_Process_Update(PortalConnect As String, obj As CMS_News_ProcessInfo)
    Public MustOverride Sub CMS_News_Process_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_News_UserProcess"
    Public MustOverride Function CMS_News_UserProcess_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_News_UserProcess_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_News_UserProcess_Add(PortalConnect As String, obj As CMS_News_UserProcessInfo) As Integer
    Public MustOverride Sub CMS_News_UserProcess_Update(PortalConnect As String, obj As CMS_News_UserProcessInfo)
    Public MustOverride Sub CMS_News_UserProcess_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_News_UserWF"
    Public MustOverride Function CMS_News_UserWF_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_News_UserWF_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_News_UserWF_GetByPhongBanId(PortalConnect As String, LoaiWF As LoaiWF, phongbanID As Integer) As IDataReader

    Public MustOverride Function CMS_News_UserWF_Add(PortalConnect As String, obj As CMS_News_UserWFInfo) As Integer
    Public MustOverride Sub CMS_News_UserWF_Update(PortalConnect As String, obj As CMS_News_UserWFInfo)
    Public MustOverride Sub CMS_News_UserWF_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_News_Version"
    Public MustOverride Function CMS_News_Version_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_News_Version_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_News_CheckChange_Get_NewsID(PortalConnect As String, NewID As Integer) As IDataReader
    Public MustOverride Function CMS_News_Version_Add(PortalConnect As String, obj As CMS_News_VersionInfo) As Integer
    Public MustOverride Sub CMS_News_Version_Update(PortalConnect As String, obj As CMS_News_VersionInfo)
    Public MustOverride Sub CMS_News_Version_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_NewsByCategory"
    Public MustOverride Function CMS_NewsByCategory_Get(PortalConnect As String, id As Long) As IDataReader
    Public MustOverride Function CMS_NewsByCategory_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsByCategory_Add(PortalConnect As String, NewsId As Integer, CategoryId As Integer, IsMainCategory As Boolean, NewsStatusId As Integer, portalId As Integer, LanguageId As String, isHotCate As Boolean) As Integer
    Public MustOverride Sub CMS_NewsByCategory_Update(PortalConnect As String, obj As CMS_NewsByCategoryInfo)
    Public MustOverride Sub CMS_NewsByCategory_Delete(PortalConnect As String, id As Long)
#End Region
#Region "CMS_NewsByMedia"
    Public MustOverride Sub CMS_NewsByMedia_Delete_By_MediaID(PortalConnect As String, MediaID As Integer)
    Public MustOverride Function CMS_NewsByMedia_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_NewsByMedia_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NewsByMedia_GetByNewsId(PortalConnect As String, newsId As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsByMedia_DeleteByNewsId(PortalConnect As String, NewsId As Integer)
    Public MustOverride Function CMS_NewsByMedia_Add(PortalConnect As String, obj As CMS_NewsByMediaInfo) As Integer
    Public MustOverride Sub CMS_NewsByMedia_Update(PortalConnect As String, obj As CMS_NewsByMediaInfo)
    Public MustOverride Sub CMS_NewsByMedia_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_NewsByTags"
    Public MustOverride Function CMS_NewsByTags_Get(PortalConnect As String, id As Long) As IDataReader
    Public MustOverride Function CMS_NewsByTags_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NewsByTags_Add(PortalConnect As String, newsId As Integer, tagName As String, createdDate As DateTime, updatedDate As DateTime) As Integer
    Public MustOverride Function CMS_NewsByTags_Get_By_NewsID(PortalConnect As Integer, NewsID As Integer, top As Integer) As IDataReader

    Public MustOverride Sub CMS_NewsByTags_Update(PortalConnect As String, obj As CMS_NewsByTagsInfo)
    Public MustOverride Sub CMS_NewsByTags_Delete(PortalConnect As String, id As Long)
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
#Region "CMS_NewsCategoriesPermission"
    Public MustOverride Function CMS_NewsCategoriesPermission_Get(PortalConnect As String, id As Long) As IDataReader
    Public MustOverride Function CMS_NewsCategoriesPermission_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_NewsCategoriesPermission_Delete_Category(PortalConnect As String, userId As String, categoryId As Integer)

    Public MustOverride Function CMS_NewsCategoriesPermission_Add(PortalConnect As String, userId As String, categoryId As Integer, permissionType As Integer) As Integer
    Public MustOverride Sub CMS_NewsCategoriesPermission_Update(PortalConnect As String, obj As CMS_NewsCategoriesPermissionInfo)
    Public MustOverride Sub CMS_NewsCategoriesPermission_Delete(PortalConnect As String, id As Long)
#End Region
#Region "CMS_NewsFeedback"
    Public MustOverride Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, NewsId As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader

    Public MustOverride Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
    Public MustOverride Function CMS_NewsFeedback_List_Search(PortalConnect As String, NewsId As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader

    Public MustOverride Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, IsFeed As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
    Public MustOverride Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
    Public MustOverride Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
#End Region
#Region "CMS_NewsFeedBack_History"
    Public MustOverride Function CMS_NewsFeedBack_History_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedBack_History_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NewsFeedBack_History_Get_By_NewsFeedback(PortalConnect As String, newsFeedbackId As Integer) As IDataReader

    Public MustOverride Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
    Public MustOverride Sub CMS_NewsFeedBack_History_Update(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo)
    Public MustOverride Function CMS_NewsFeedBack_History_Get_By_CMS_NewsFeedback(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsFeedBack_History_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_NewsStatus"
    Public MustOverride Function CMS_NewsStatus_Get(PortalConnect As String, newsStatusId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsStatus_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_NewsStatus_Add(PortalConnect As String, obj As CMS_NewsStatusInfo) As Integer
    Public MustOverride Sub CMS_NewsStatus_Update(PortalConnect As String, obj As CMS_NewsStatusInfo)
    Public MustOverride Sub CMS_NewsStatus_Delete(PortalConnect As String, newsStatusId As Integer)
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
#Region "SQL_Service_Add"
    Public MustOverride Sub SV_CMS_Document_Add(PortalConnect As String, document_ID As String, document_Name As String, docType As String, providerName As String, filedName As String, contents As String, noCode As String, signerName As String, promDate As DateTime, effectDate As DateTime, endDate As DateTime, fileName As String, fileSource As String, isURL As String, isDownload As Integer, isActive As Boolean, isOrder As Integer, createdBy As DateTime, userName As String, updatedBy As DateTime, updateName As String, portalID As Integer)
    Public MustOverride Sub SV_CMS_MenuD_Add(PortalConnect As String, menuD_ID As String, menuD_Name As String, menu_ID As String, parent_ID As String, url As String, backColor As String, isOrder As Integer, portalId As Integer, createdDate As DateTime, createdUser As String, updateDate As DateTime, updateUser As String)
    Public MustOverride Sub SV_CMS_Answers_Add(PortalConnect As String, answer_ID As String, question_ID As String, fullName As String, contents As String, fileName As String, fileAttach As String, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String, publishedDate As DateTime, publishedUser As String, isPublic As Boolean)
    Public MustOverride Sub SV_CMS_WebLink_Add(PortalConnect As String, id As Integer, name As String, orderNo As Integer, url As String, image As String, description As String, portalId As Integer, languageId As String, viewType As Integer, UserName As String, Createdate As DateTime)
    Public MustOverride Sub SV_CMS_NewsCategories_Add(PortalConnect As String, categoryid As Integer, categoryname As String, description As String, TabID As Integer, isactive As Integer, CreateDate As DateTime, PortalId As Integer, LanguageId As String, ParentId As Integer, OrderNumber As Integer, Type As Integer, TabPath As String, TabMobileID As Integer)
    Public MustOverride Sub SV_CMS_NewsFeedback_Add(PortalConnect As String, NewsFeedbackId As Integer, itemId As Integer, fullName As String, email As String, createDate As DateTime, phoneNumber As String, title As String, content As String, address As String, iPTrack As String, status As Integer, avatar As String, type As String, portalId As Integer, languageId As String, isLike As Integer, disLike As Integer, parentID As Integer, isRead As Boolean, userRead As String, dateRead As DateTime, isPublic As Boolean, userPublic As String, datePublic As DateTime)
    Public MustOverride Sub SV_CMS_News_Add(PortalConnect As String, NewId As Integer, CategoryId As Integer, Introduction As String, Title As String, ImagePath As String, Summary As String, Content As String, isActive As Boolean, Hotcat As Boolean, IsCare As Boolean, isRead As Integer, Status As Integer, Unit As Short, NewsKind As Short, Type As Short, TypeUrl As String, Links As String, Tags As String, IsImage As Boolean, Note As String, SourceInfo As Short, IsEdited As Boolean, EditedUser As String, EditedTime As DateTime, VoteCount As Integer, ViewCount As Integer, IsArchived As Boolean, ArchivedDate As DateTime, Credit As Integer, Createdate As DateTime, ApprovalRequestDate As DateTime, ApprovalDate As DateTime, ApprovalUser As String, ReturnedDate As DateTime, ReturnedUser As String, CancelPublishDate As DateTime, CancelPublishUser As String, PublishedDate As DateTime, PublishedUser As String, UserId As String, WriterName As String, WriterFullName As String, NumberNews As String, NotePrices As String, LanguageId As String, PortalId As Integer, ToUrl As String, GetFromPortal As Integer, GetFromNewId As Integer, SendName As String, SendView As Boolean)
    Public MustOverride Sub SV_CMS_NewsByCategory_Add(PortalConnect As String, id As Long, newsId As Long, categoryId As Integer, isMainCategory As Boolean, newsStatusId As Integer, portalID As Integer, languageId As String)
    Public MustOverride Sub SV_CMS_NewsByMedia_Add(PortalConnect As String, id As Integer, newsId As Integer, mediaId As Integer)
    Public MustOverride Sub SV_CMS_Media_Add(PortalConnect As String, id As Integer, categoryId As Integer, name As String, summary As String, avatar As String, mediaUrl As String, folders As String, contents As String, viewCount As Integer, status As Integer, type As Short, isYoutube As Boolean, isHot As Boolean, isFTP As Boolean, tags As String, note As String, createdDate As DateTime, publishedDate As DateTime, approvalDate As DateTime, createdUser As String, approvalUser As String, publishedUser As String, portalId As Integer, languageId As String, sTT As Integer, isHome As Boolean, isPage As Boolean, toUrl As String)
    Public MustOverride Sub SV_CMS_FAQ_Add(PortalConnect As String, id As String, name As String, summary As String, image As String, startDate As DateTime, endDate As DateTime, answerUserId As String, answerUserName As String, isUserDefault As Boolean, defaultAnswerName As String, portalId As Integer, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
    Public MustOverride Sub SV_CMS_FAQAnswers_Add(PortalConnect As String, id As String, questionID As String, name As String, title As String, contents As String, fileAttach As String, sendDate As DateTime, status As Integer, isPublic As Boolean, portalId As Integer, answerName As String, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
    Public MustOverride Sub SV_CMS_FAQQuestions_Add(PortalConnect As String, id As String, fAQID As String, name As String, contents As String, fileAttach As String, adress As String, email As String, phone As String, sendDate As DateTime, status As Integer, isPublic As Boolean, portalId As Integer, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
    Public MustOverride Sub SV_CMS_ConfigSystem_Add(PortalConnect As String, iD As Integer, portalID As Integer, isCMS As Boolean, isLive As Boolean, liveTitle As String, liveUrl As String, liveDes As String, startDate As DateTime, endDate As DateTime, siteMap As String, IpPublic As String, Analytics As String, updatedBy As DateTime, updateName As String)
    Public MustOverride Sub SV_CMS_Setups_Add(PortalConnect As String, iD As String, settingName As String, settingValue As String, createdBy As DateTime, userName As String, updatedBy As DateTime, updatedUser As String, portalID As Integer)
    Public MustOverride Sub SV_Update_CMS_Event_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_News_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Question_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_NewsByCategory_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_NewsByMedia_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Media_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_CMS_Advertise_Add(PortalConnect As String, advertise_ID As String, advertise_Name As String, imgType As Integer, images As String, isWith As String, isHeight As String, target As String, isURL As String, startDate As DateTime, endDate As DateTime, isLang As String, isActive As Boolean, isOrder As Integer, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String, pageLoca_ID As String, portalID As Integer, CategoryID As String)
    Public MustOverride Sub SV_Update_CMS_Advertise_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Document_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Answers_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_WebLink_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_NewsFeedback_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_NewsCategories_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Infomation_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_MenuD_SendView(PortalConnect As String, MenuD_ID As String, SendView As Boolean)
    Public MustOverride Sub SV_CMS_Infomation_Add(PortalConnect As String, nameH1 As String, nameH2 As String, nameH3 As String, imagePath As String, imageRight As String, footer As String, infomation As String, createdDate As DateTime, createdUser As String, updateDate As DateTime, updateUser As String, portalId As Integer, languageId As String)
    Public MustOverride Sub SV_CMS_NewsByTags_Add(PortalConnect As String, Id As Integer, newsId As Integer, tagName As String, createdDate As DateTime, updatedDate As DateTime)
    Public MustOverride Sub SV_CMS_NewsPapers_Add(PortalConnect As String, newsPapers_ID As String, newsPapers_Number As Integer, category_ID As Integer, publicDate As DateTime, imagePath As String, isYear As Integer, isPublic As Boolean, createDate As DateTime, userName As String, updateDate As DateTime, updateUser As String, portalID As Integer, sendView As Boolean)
    Public MustOverride Sub SV_CMS_NewsPapersD_Add(PortalConnect As String, newsPapersD_ID As String, newsPapers_ID As String, pageNumber As Integer, photoPath As String, photoDes As String, createDate As DateTime, userName As String, updateDate As DateTime, updateUser As String)
    Public MustOverride Sub SV_Update_CMS_NewsPapers_SendView(PortalConnect As String, newsPapers_ID As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_NewsPapersD_SendView(PortalConnect As String, newsPapersD_ID As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_FAQ_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_FAQAnswers_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_FAQQuestions_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_ConfigSystem_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
    Public MustOverride Sub SV_Update_CMS_Setups_SendView(PortalConnect As String, Id As String, SendView As Boolean)
    Public MustOverride Function SV_CMS_ListError(PortalConnect As String, Type As Integer) As IDataReader

#End Region
#Region "RPT"
    Public MustOverride Function CMS_Reports_1(PortalConnect As String, PortalID As Integer, Lang As String, Top As String, FromDate As DateTime, ToDate As DateTime, Flag As String) As IDataReader
    Public MustOverride Function CMS_Reports_2(PortalConnect As String, PortalID As Integer, Lang As String, UserID As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Function CMS_Reports_3(PortalConnect As String, PortalID As Integer, Lang As String, CategoryId As Integer, FromDate As DateTime, ToDate As DateTime) As IDataReader

#End Region
#Region "CMS_DashBoard"
    Public MustOverride Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
#End Region
#Region "NewRss"
    Public MustOverride Function NewRss_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function NewRss_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function NewRss_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function NewRss_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Sub NewRss_Add(PortalConnect As String, iD As String, newsSourceID As String, title As String, url As String, summary As String, content As String, portalId As Integer, pubDate As String, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
    Public MustOverride Sub NewRss_Update(PortalConnect As String, iD As String, newsSourceID As String, title As String, url As String, summary As String, content As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
    Public MustOverride Sub NewRss_Delete(PortalConnect As String, iD As String)
#End Region
#Region "NewsSource"
    Public MustOverride Function NewsSource_Get(PortalConnect As String, newsSourceID As String) As IDataReader
    Public MustOverride Function NewsSource_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function NewsSource_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub NewsSource_Add(PortalConnect As String, newsSourceID As String, name As String, link As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
    Public MustOverride Sub NewsSource_Update(PortalConnect As String, newsSourceID As String, name As String, link As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
    Public MustOverride Sub NewsSource_Delete(PortalConnect As String, newsSourceID As String)
#End Region
#Region "CMS_Business"
    Public MustOverride Function CMS_Business_Get_All(strConnect As String) As IDataReader
    Public MustOverride Function CMS_JobUser_Get_All(strConnect As String) As IDataReader
    Public MustOverride Function CMS_Work_Get_All(strConnect As String) As IDataReader
    Public MustOverride Function CMS_CategoryOld_All(strConnect As String, pid As Integer) As IDataReader
    Public MustOverride Function CMS_News_ListCate(strConnect As String, cateID As String) As IDataReader

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
#Region "CMS_NhomBanner"
    Public MustOverride Function CMS_NhomBanner_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_NhomBanner_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NhomBanner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_NhomBanner_Add(PortalConnect As String, obj As CMS_NhomBannerInfo) As Integer
    Public MustOverride Sub CMS_NhomBanner_Update(PortalConnect As String, obj As CMS_NhomBannerInfo)
    Public MustOverride Sub CMS_NhomBanner_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_Banner"
    Public MustOverride Function CMS_Banner_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Banner_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Banner_Add(PortalConnect As String, obj As CMS_BannerInfo) As Integer
    Public MustOverride Sub CMS_Banner_Update(PortalConnect As String, obj As CMS_BannerInfo)
    Public MustOverride Sub CMS_Banner_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_BackUp"
    Public MustOverride Function CMS_BackUp_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_BackUp_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BackUp_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_BackUp_Add(PortalConnect As String, obj As CMS_BackUpInfo) As Integer
    Public MustOverride Sub CMS_BackUp_Update(PortalConnect As String, obj As CMS_BackUpInfo)
    Public MustOverride Sub CMS_BackUp_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_ThongBao"
    Public MustOverride Function CMS_ThongBao_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_ThongBao_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ThongBao_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional IsActive As Integer = -1) As IDataReader

    Public MustOverride Function CMS_ThongBao_Add(PortalConnect As String, obj As CMS_ThongBaoInfo) As Integer
    Public MustOverride Sub CMS_ThongBao_Update(PortalConnect As String, obj As CMS_ThongBaoInfo)
    Public MustOverride Sub CMS_ThongBao_Delete(PortalConnect As String, id As Integer)
#End Region

#Region "CMS_NewsAudio"
    Public MustOverride Function CMS_NewsAudio_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_NewsAudio_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NewsAudio_ListByNewsID(PortalConnect As String, newsId As Integer) As IDataReader

    Public MustOverride Function CMS_NewsAudio_Add(PortalConnect As String, obj As CMS_NewsAudioInfo) As Integer
    Public MustOverride Sub CMS_NewsAudio_Update(PortalConnect As String, obj As CMS_NewsAudioInfo)
    Public MustOverride Sub CMS_NewsAudio_Delete(PortalConnect As String, iD As Integer)
#End Region

End Class