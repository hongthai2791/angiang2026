Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.EPORTAL", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMSCache"
    Public MustOverride Function CMSCache_Get_IP(PortalConnect As String, iP As String, PortalID As Integer) As IDataReader
    Public MustOverride Function CMSCache_Add(PortalConnect As String, CacheName As String, iP As String, PortalID As Integer) As Integer
#End Region
#Region "CMS_Settings"
    Public MustOverride Function CMS_Settings_Get_Value(PortalConnect As String, SubMod As String, setting_Key As String, setting_Page As String) As IDataReader
    Public MustOverride Sub CMS_Settings_Update(PortalConnect As String, setting_ID As String, SubMod As String, setting_Key As String, setting_Value As String, setting_Page As String, createdBy As DateTime, UserName As String, updatedBy As DateTime, updatedUser As String)

#End Region
#Region "System - DNN"
    Public MustOverride Function DNN_User_Check_Delete(portalid As Integer, UserName As String) As Boolean
    Public MustOverride Function DNN_User_Get_Property(PortalId As String, userName As String, proName As String) As String
    Public MustOverride Sub DNN_Resquest_Change_Password(PortalConnect As String, UserId As Integer, isChange As Boolean)
    Public MustOverride Function DNN_User_Get_Telephone(PortalId As String, userName As String) As String
    Public MustOverride Function DNN_UserConfig_List_By_Index_Role(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, WardID As Integer, subMod As String, RoleID As Integer) As IDataReader
    Public MustOverride Function DNN_UserConfig_List_By_Index(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, subMod As String) As IDataReader
    Public MustOverride Sub DNN_Tabs_UpdateSkin(PortalConnect As String, TabID As Integer, SkinSrc As String)
    Public MustOverride Function DNN_Users_List_BirthDay(PortalId As Integer, PropertyName As String) As IDataReader
    Public MustOverride Function AddTab(PortalConnect As String, contentItemID As Integer, portalID As Integer, tabOrder As Integer, uniqueId As Guid, versionGuid As Guid, defaultLanguageGuid As Guid, localizedVersionGuid As Guid, tabName As String, isVisible As Boolean, disableLink As Boolean, parentId As Integer, iconFile As String, IconFileLarge As String, title As String, description As String, keyWords As String, url As String, skinSrc As String, containerSrc As String, startDate As DateTime, endDate As DateTime, refreshInterval As Integer, pageHeadText As String, isSecure As Boolean, permanentRedirect As Boolean, siteMapPriority As Double, createdByUserID As Integer, cultureCode As String, isSystem As Boolean) As Integer
    Public MustOverride Function DNN_GetDesktopModulesID(PortalConnect As String, FriendlyName As String) As Integer
    Public MustOverride Function AddTabPermission(PortalConnect As String, tabID As Integer, permissionID As Integer, roleID As Integer, allowAccess As Boolean, userID As Integer, createdByUserID As Integer) As Integer
    Public MustOverride Sub DNN_Update_TabName_Set_ID(PortalConnect As String, TabID As Integer, TabName As String, PortalID As Integer)
    Public MustOverride Function DNN_ContentItems_Add(PortalConnect As String, content As String) As Integer
    Public MustOverride Sub DNN_TabHasBeenPublished(PortalConnect As String, tabID As Integer)
    Public MustOverride Sub DNN_ContentItems_Update_Tabid(PortalConnect As String, contentItemID As Integer, tabID As Integer)
    Public MustOverride Sub DeleteTabPermissionsByTabID(PortalConnect As String, tabID As Integer)
    Public MustOverride Function DNN_User_List_By_Role(portalid As Integer, RoleName As String, UserName As String) As IDataReader
    Public MustOverride Function RPT_User_List_By_Role(portalid As Integer, RoleName As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Sub DNN_TabModuleSettings_Add(PortalConnect As String, portalid As Integer, TabModuleID As Integer, SettingName As String, SettingValue As String, CreatedByUserID As Integer, CreatedOnDate As DateTime, LastModifiedByUserID As Integer, LastModifiedOnDate As DateTime)
    Public MustOverride Function DNN_Tabs_Get_TabPath(PortalConnect As String, TabPath As String, portalid As Integer) As Integer
    Public MustOverride Function DNN_Categories_Portal_List_All(PortalID As Integer, LanguageId As String) As IDataReader
    Public MustOverride Function DNN_Tabs_Get(TabID As Integer, PortalID As Integer) As String
    Public MustOverride Function DNN_Tabs_List_TabPath(PortalConnect As String, TabID As Integer, PortalID As Integer) As String
    Public MustOverride Function DNN_Portal_Get_By_ID(PortalID As Integer) As IDataReader
    Public MustOverride Function DNN_Tabs_Get_By_ParentID(PortalConnect As String, ParentId As String) As IDataReader
    Public MustOverride Function DNN_Tabs_Get_Parent_IsNull(PortalConnect As String, PortalID As Integer, cms As Boolean, tabname As String) As IDataReader
    Public MustOverride Function DNN_User_Get_By_ID(PortalId As Integer, UserId As Integer) As IDataReader
    Public MustOverride Function DNN_Portal_List_Lang(lang As String) As IDataReader
    Public MustOverride Function DNN_Portal_Get_By_UserID(UserName As String) As IDataReader
    Public MustOverride Function DNN_GetPortalLocalizations_PortalIDExt(portalID As String) As IDataReader
    Public MustOverride Function DNN_TabModuleSettings_Get_Value_Module(TabModuleID As String, ModuleTitle As String) As IDataReader
    Public MustOverride Function DNN_TabModuleSettings_Get_Value(PortalConect As String, PortalId As Integer, TabModuleID As String, SettingName As String) As IDataReader
    Public MustOverride Function DNN_TabModuleSettings_Get_ModuleTitle(PortalId As Integer, ModuleTitle As String) As IDataReader
    Public MustOverride Function DNN_TabModuleSettings_Get_Control(PortalConnect As String, PortalId As Integer, Control As String) As IDataReader
    Public MustOverride Function DNN_GetDesktopModules_By_FriendlyName(FriendlyName As String) As IDataReader
    Public MustOverride Function DNN_PortalID_Get_By_ParentID(ParentId As Integer) As IDataReader
    Public MustOverride Function DNN_UserConfig_List_By_Category(PortalId As Integer) As IDataReader
    Public MustOverride Function DNN_UserConfig_List_By_Search(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As IDataReader
    Public MustOverride Function DNN_UserConfig_List_By_Roles(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, rolesID As String, isOrder As Integer) As IDataReader
    Public MustOverride Function DNN_User_Get_Email(Email As String) As IDataReader
    Public MustOverride Function DNN_PortalID_Get_Parent_IsNull(PortalId As Integer, IsCMS As Boolean) As IDataReader
    Public MustOverride Function DNN_User_Get(PortalId As Integer, UserName As String) As IDataReader
    Public MustOverride Function DNN_User_GetAll(portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function DNN_User_List_Search(portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub DNN_Tabs_Delete(PortalConnect As String, PortalId As Integer, TabID As Integer)
    Public MustOverride Sub DNN_Update_TabName_Set_ID(TabID As Integer, TabName As String, PortalID As Integer)
    Public MustOverride Sub DNN_Update_TabName(PortalConnect As String, TabID As Integer, TabName As String, TabTitle As String, Description As String, ParentID As Integer, TabPath As String, PortalID As Integer)
    Public MustOverride Function DNN_User_List_By_UserName(PortalId As Integer, UserName As String) As IDataReader
    Public MustOverride Function DNN_Files_Get_By_FileName(PortalId As Integer, FileName As String) As IDataReader
    Public MustOverride Function DNN_Files_Get_By_FileID(FileID As String) As IDataReader
    Public MustOverride Function DNN_GetRestPassWord(RestPassWordId As String, IsLang As String) As IDataReader
    Public MustOverride Sub DNN_AddRestPassWord(RestPassWordId As String, PortalID As String, Username As String, Email As String, EndDate As String)
    Public MustOverride Sub DNN_UpdateRestPassWord(RestPassWordId As String)
    Public MustOverride Function DNN_CountMessage(UserId As String) As IDataReader
    Public MustOverride Function DNN_LogHistory(UserId As String, currPage As String, recodperpage As String) As IDataReader
    Public MustOverride Sub DNN_User_Lock(UserId As String, IsDelete As Boolean, PortalId As Integer)
    Public MustOverride Sub DNN_User_DeleteLock(UserId As String, IsDelete As Boolean, PortalId As Integer)
    Public MustOverride Function DNN_UserConfig_List_By_SearchBanBe(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, UserName As String) As IDataReader
#End Region
#Region "CMSConnection"
    Public MustOverride Function CMSInConn_Get_PortalID(PortalID As Integer) As String
    Public MustOverride Function CMSTpConn_Get_TinhTP(TinhTP As Integer, IdKey As String) As String
    Public MustOverride Function CMSConn_Get_By_SqlCode(PortalID As Integer, sqlCode As String) As String
    Public MustOverride Function CMSConnection_List_By_PortalID(PortalID As Integer) As IDataReader
    Public MustOverride Function CMSConnection_Get(PortalID As Integer) As IDataReader
#End Region
#Region "CMSUserPortal"
    Public MustOverride Function DNN_UserPortals_Add(PortalID As Integer, FromPortal As Integer, ToPortal As Integer, UserName As String) As String
    Public MustOverride Function AddUserPortal(PortalID As Integer, UserID As Integer) As Integer
    Public MustOverride Sub DeleteUserPortal(UserID As Integer, PortalID As Integer)
    Public MustOverride Function CMSUserPortal_Get_By_User(PortalConnect As String, userName As String, subMod As String, PortalID As Integer) As IDataReader
    Public MustOverride Function CMSUserPortal_Get_By_CCCD(PortalConnect As String, CCCD As String) As IDataReader
    Public MustOverride Function CMSUserPortal_List_User(PortalConnect As String, subMod As String, PortalID As Integer, displayName As String, gender As Integer, levelID As String, needID As String, roleID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMSUserPortal_List(userID As String) As IDataReader
    Public MustOverride Function CMSUserPortal_Add(obj As CMSUserPortalInfo) As Integer
    Public MustOverride Sub CMSUserPortal_Delete(userName As String, subMod As String, PortalID As Integer)
    Public MustOverride Sub CMSUserPortal_Add_Roles(PortalID As Integer, userName As String, subMod As String, rolesID As String)
#End Region
#Region "CMSCookie"
    Public MustOverride Function CMSCookie_Get_Token(idKey As String) As IDataReader
    Public MustOverride Function CMSCookie_Get(idKey As String) As IDataReader
    Public MustOverride Function CMSCookie_List() As IDataReader
    Public MustOverride Sub CMSCookie_Add(idKey As String, idValue As String, userName As String, crtVal As String, crtDate As DateTime)
    Public MustOverride Sub CMSCookie_Update(idKey As String, idValue As String)
    Public MustOverride Sub CMSCookie_Delete(idKey As String)

#End Region
#Region "NextPage"
    Public MustOverride Function DNN_NextPageJs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
    Public MustOverride Function DNN_NextPageVs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
    Public MustOverride Function DNN_NextPage(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, hrefPage As String) As String
#End Region
#Region "CMS_UserConfig"
    Public MustOverride Function CMS_UserConfig_Get_By_UserName_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_UserConfig_Get_By_UserName(PortalConnect As String, subMod As String, UserName As String, TinhTP As String) As IDataReader
    Public MustOverride Function CMS_UserConfig_Get_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As String) As IDataReader
    Public MustOverride Function CMS_UserConfig_Get(PortalConnect As String, userConfig_ID As Integer) As IDataReader
    Public MustOverride Function CMS_UserConfig_List(PortalConnect As String, subMod As String, portalId As Integer, TinhTP As Integer) As IDataReader
    Public MustOverride Sub CMS_UserConfig_Add(PortalConnect As String, subMod As String, userName As String, moduleSrc As String, portalID As Integer, TinhTP As Integer)
    Public MustOverride Sub CMS_UserConfig_Update(PortalConnect As String, subMod As String, userConfig_ID As Integer, userName As String, moduleSrc As String, portalID As Integer, TinhTP As Integer)
    Public MustOverride Sub CMS_UserConfig_Delete(PortalConnect As String, userConfig_ID As Integer)
    Public MustOverride Sub CMS_UserConfig_Delete_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As Integer)
#End Region
#Region "CMS_Module"
    Public MustOverride Function CMS_Module_List_Menu_Top(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String, tinhTP As String) As IDataReader
    Public MustOverride Function CMS_Module_List_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
    Public MustOverride Function CMS_Module_Get_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
    Public MustOverride Function CMS_Module_List_Parent(PortalConnect As String, subMod As String) As IDataReader
    Public MustOverride Function CMS_Module_List_Menu(PortalConnect As String, subMod As String, VaiTro As String, tinhTP As String) As IDataReader
    Public MustOverride Function CMS_Module_List_Security(PortalConnect As String, subMod As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_Module_List_By_User(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String, tinhTP As String) As IDataReader
    Public MustOverride Function CMS_Module_List_By_Admin(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
    Public MustOverride Function CMS_Module_List_By_Host(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
    Public MustOverride Function CMS_Module_List(PortalConnect As String, subMod As String) As IDataReader
    Public MustOverride Sub CMS_Module_Add(PortalConnect As String, subMod As String, module_ID As String, moduleSrc As String, moduleName As String, isAdmin As Boolean, isUser As Boolean, status As Boolean, ctlView As String, ctlEdit As String, img As String, isOrder As Integer, Parent_ID As String)
    Public MustOverride Sub CMS_Module_Delete(PortalConnect As String, module_ID As String)
    Public MustOverride Function CMS_Module_Get(PortalConnect As String, subMod As String, module_Src As String) As IDataReader
#End Region
#Region "CMS_Regional"

    Public MustOverride Function SV_Regional_Get_By_IdKey(PortalConnect As String, Regional_Code As String) As String
    Public MustOverride Function CMS_Regional_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
    Public MustOverride Function CMS_Regional_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
    Public MustOverride Function CMS_Regional_Get_By_Code(PortalConnect As String, code As String) As IDataReader
    Public MustOverride Function CMS_Regional_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Regional_List_Parent_Null(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Regional_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_Get_By_CMS_Regional(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Regional_Add(PortalConnect As String, obj As CMS_RegionalInfo) As Integer
    Public MustOverride Sub CMS_Regional_Update(PortalConnect As String, obj As CMS_RegionalInfo)
    Public MustOverride Sub CMS_Regional_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
    Public MustOverride Sub CMS_Regional_Delete(PortalConnect As String, regional_ID As Integer)
#End Region
#Region "CMS_Nation"
    Public MustOverride Function CMS_Nation_Get_By_Name(PortalConnect As String, Nation_Name As String) As IDataReader

    Public MustOverride Function CMS_Nation_Get(PortalConnect As String, nation_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Nation_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Nation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Nation_Add(PortalConnect As String, obj As CMS_NationInfo) As Integer
    Public MustOverride Sub CMS_Nation_Update(PortalConnect As String, obj As CMS_NationInfo)
    Public MustOverride Sub CMS_Nation_Delete(PortalConnect As String, nation_ID As Integer)
#End Region
#Region "CMS_National"
    Public MustOverride Function CMS_National_Get(PortalConnect As String, national_ID As Integer) As IDataReader
    Public MustOverride Function CMS_National_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_National_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_National_Add(PortalConnect As String, obj As CMS_NationalInfo) As Integer
    Public MustOverride Sub CMS_National_Update(PortalConnect As String, obj As CMS_NationalInfo)
    Public MustOverride Sub CMS_National_Delete(PortalConnect As String, national_ID As Integer)
#End Region
#Region "CMS_Position"
    Public MustOverride Function CMS_Position_Get_By_Name(PortalConnect As String, Position_Name As String) As IDataReader

    Public MustOverride Function CMS_Position_Get(PortalConnect As String, position_ID As Integer) As IDataReader

    Public MustOverride Function SV_Position_Get_By_IdKey(PortalConnect As String, position_Code As Integer) As String
    Public MustOverride Function CMS_Position_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Position_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer
    Public MustOverride Function SV_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer

    Public MustOverride Sub CMS_Position_Update(PortalConnect As String, obj As CMS_PositionInfo)
    Public MustOverride Sub CMS_Position_Delete(PortalConnect As String, position_ID As Integer)
#End Region
#Region "CMS_Religion"
    Public MustOverride Function CMS_Religion_Get_By_Name(PortalConnect As String, Religion_Name As String) As IDataReader
    Public MustOverride Function CMS_Religion_Get(PortalConnect As String, religion_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Religion_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Religion_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Religion_Add(PortalConnect As String, obj As CMS_ReligionInfo) As Integer
    Public MustOverride Sub CMS_Religion_Update(PortalConnect As String, obj As CMS_ReligionInfo)
    Public MustOverride Sub CMS_Religion_Delete(PortalConnect As String, religion_ID As Integer)
#End Region
#Region "CMS_Roles"

    Public MustOverride Function CMS_Roles_Get(PortalConnect As String, roles_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Roles_Check_Code(PortalConnect As String, SubMod_ID As Integer, roles_ID As Integer, Roles_Code As String) As Integer
    Public MustOverride Function CMS_Roles_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Roles_List_Search(PortalConnect As String, search As String, SubMod_ID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Roles_Add(PortalConnect As String, obj As CMS_RolesInfo) As Integer
    Public MustOverride Sub CMS_Roles_Update(PortalConnect As String, obj As CMS_RolesInfo)
    Public MustOverride Function CMS_Roles_Get_By_CMS_SubMod(PortalConnect As String, subMod_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Roles_Get_By_SubMod_Code(PortalConnect As String, subMod_ID As Integer, roleCode As String) As IDataReader

    Public MustOverride Sub CMS_Roles_Delete(PortalConnect As String, roles_ID As Integer)
#End Region
#Region "CMS_SubMod"
    Public MustOverride Function CMS_SubMod_Get_By_Path(PortalConnect As String, subMod_Path As String) As IDataReader
    Public MustOverride Function CMS_SubMod_Get(PortalConnect As String, subMod_ID As Integer) As IDataReader
    Public MustOverride Function CMS_SubMod_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SubMod_ListActive(PortalConnect As String, isActive As Int16) As IDataReader
    Public MustOverride Function CMS_SubMod_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_SubMod_Add(PortalConnect As String, obj As CMS_SubModInfo) As Integer
    Public MustOverride Sub CMS_SubMod_Update(PortalConnect As String, obj As CMS_SubModInfo)
    Public MustOverride Sub CMS_SubMod_Delete(PortalConnect As String, subMod_ID As Integer)
#End Region
#Region "CMS_Language"
    Public MustOverride Function CMS_Language_Get(PortalConnect As String, Language_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Language_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Language_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Language_Add(PortalConnect As String, obj As CMS_LanguageInfo) As Integer
    Public MustOverride Sub CMS_Language_Update(PortalConnect As String, obj As CMS_LanguageInfo)
    Public MustOverride Sub CMS_Language_Delete(PortalConnect As String, Language_ID As Integer)
#End Region
#Region "CMS_Education"
    Public MustOverride Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As IDataReader
    Public MustOverride Function SV_Education_Get_By_IdKey(PortalConnect As String, education_Code As String) As String
    Public MustOverride Function CMS_Education_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
    Public MustOverride Function SV_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
    Public MustOverride Sub CMS_Education_Update(PortalConnect As String, obj As CMS_EducationInfo)
    Public MustOverride Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
#End Region
#Region "CMS_Relation"
    Public MustOverride Function CMS_Relation_Get_By_Name(PortalConnect As String, Relation_Name As String) As IDataReader
    Public MustOverride Function CMS_Relation_Get(PortalConnect As String, Relation_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Relation_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Relation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Relation_Add(PortalConnect As String, obj As CMS_RelationInfo) As Integer
    Public MustOverride Sub CMS_Relation_Update(PortalConnect As String, obj As CMS_RelationInfo)
    Public MustOverride Sub CMS_Relation_Delete(PortalConnect As String, Relation_ID As Integer)
#End Region
#Region "CMS_Buglog"
    Public MustOverride Function CMS_Buglog_Get(PortalConnect As String, buglog_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Buglog_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Buglog_Add(PortalConnect As String, Contents As String, TabName As String) As Integer
    Public MustOverride Sub CMS_Buglog_Update(PortalConnect As String, obj As CMS_BuglogInfo)
    Public MustOverride Function CMS_Buglog_List_By_TabName(PortalConnect As String, TabName As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_Buglog_Update_Resolve(PortalConnect As String, Buglog_ID As Integer, Resolve As String)
    Public MustOverride Sub CMS_Buglog_Delete(PortalConnect As String, buglog_ID As Integer)
#End Region
#Region "CMS_ActiveDomain"
    Public MustOverride Function CMS_ActiveDomain_Get(PortalConnect As String, domain_ID As Integer) As IDataReader
    Public MustOverride Function CMS_ActiveDomain_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ActiveDomain_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, tinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_ActiveDomain_Check_Active(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, domain As String) As IDataReader
    Public MustOverride Function CMS_ActiveDomain_Add(PortalConnect As String, obj As CMS_ActiveDomainInfo) As Integer
    Public MustOverride Sub CMS_ActiveDomain_Update(PortalConnect As String, obj As CMS_ActiveDomainInfo)
    Public MustOverride Sub CMS_ActiveDomain_Delete(PortalConnect As String, domain_ID As Integer)
#End Region
#Region "CMS_Area"
    Public MustOverride Function CMS_Area_Get(PortalConnect As String, Area_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Area_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Area_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Area_Add(PortalConnect As String, obj As CMS_AreaInfo) As Integer
    Public MustOverride Sub CMS_Area_Update(PortalConnect As String, obj As CMS_AreaInfo)
    Public MustOverride Sub CMS_Area_Delete(PortalConnect As String, Area_ID As Integer)
#End Region
#Region "CMS_Place"
    Public MustOverride Function CMS_Place_Get_By_Name(PortalConnect As String, Place_Name As String) As IDataReader
    Public MustOverride Function CMS_Place_Get(PortalConnect As String, Place_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Place_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Place_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Place_Add(PortalConnect As String, Place_Name As String, Place_Code As String, Place_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer) As Integer
    Public MustOverride Sub CMS_Place_Update(PortalConnect As String, Place_ID As Integer, Place_Name As String, Place_Code As String, Place_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Place_Delete(PortalConnect As String, Place_ID As Integer)
#End Region
#Region "CMS_ConfigTP"
    Public MustOverride Function CMS_ConfigTP_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_ConfigTP_Get_By_TinhTP(PortalConnect As String, TinhTP As Integer, PortalAlias As String) As IDataReader
    Public MustOverride Function CMS_ConfigTP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_ConfigTP_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ConfigTP_Add(PortalConnect As String, obj As CMS_ConfigTPInfo) As Integer
    Public MustOverride Sub CMS_ConfigTP_Update(PortalConnect As String, obj As CMS_ConfigTPInfo)
    Public MustOverride Sub CMS_ConfigTP_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function TP_ChuyenDoi_Get(PortalConnect As String, ID As Integer) As Integer
#End Region
#Region "CMS_DayOff"

    Public MustOverride Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As IDataReader
    Public MustOverride Function CMS_DayOff_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_DayOff_Add(PortalConnect As String, obj As CMS_DayOffInfo)
    Public MustOverride Sub CMS_DayOff_Update(PortalConnect As String, obj As CMS_DayOffInfo)
    Public MustOverride Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
    Public MustOverride Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer
    Public MustOverride Function CMS_OffTime_Get_By_Dates(PortalConnect As String, Dates As DateTime) As Integer
    Public MustOverride Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_DayOff_Update_Quick(PortalConnect As String, dayOff_ID As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Function CMS_DayOff_TinhNgay(PortalConnect As String, Dates As DateTime, soNgay As Integer) As DateTime

#End Region
#Region "CMS_API"
    Public MustOverride Function CMS_API_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_API_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_API_Add(PortalConnect As String, obj As CMS_APIInfo) As Integer
    Public MustOverride Sub CMS_API_Update(PortalConnect As String, obj As CMS_APIInfo)
    Public MustOverride Sub CMS_API_Delete(PortalConnect As String, id As Integer, userId As String)
#End Region
#Region "CMS_APIHeader"
    Public MustOverride Function CMS_APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
    'Public MustOverride Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    Public MustOverride Function CMS_APIHeader_Add(PortalConnect As String, obj As CMS_APIHeaderInfo) As Integer
    Public MustOverride Sub CMS_APIHeader_Update(PortalConnect As String, obj As CMS_APIHeaderInfo)
    Public MustOverride Sub CMS_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
    Public MustOverride Function CMS_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)

#End Region

#Region "CMS_RegionalTP"

    Public MustOverride Sub CMS_RegionalTP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
    Public MustOverride Function CMS_RegionalTP_Backup_List_Parent_Null(PortalConnect As String, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
    Public MustOverride Function CMS_RegionalTP_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Get_By_Code(PortalConnect As String, code As String) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_List_Parent_Null(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTP_Add(PortalConnect As String, obj As CMS_RegionalTPInfo) As Integer
    Public MustOverride Sub CMS_RegionalTP_Update(PortalConnect As String, obj As CMS_RegionalTPInfo)
    Public MustOverride Sub CMS_RegionalTP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
    Public MustOverride Sub CMS_RegionalTP_Delete(PortalConnect As String, regional_ID As Integer)

#End Region
#Region "CMS_RegionalQH"
    Public MustOverride Sub CMS_RegionalQH_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)

    Public MustOverride Function CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
    Public MustOverride Function CMS_RegionalQH_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Get_By_Code(PortalConnect As String, code As String) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalQH_Add(PortalConnect As String, obj As CMS_RegionalQHInfo) As Integer
    Public MustOverride Sub CMS_RegionalQH_Update(PortalConnect As String, obj As CMS_RegionalQHInfo)
    Public MustOverride Sub CMS_RegionalQH_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
    Public MustOverride Sub CMS_RegionalQH_Delete(PortalConnect As String, regional_ID As Integer)
#End Region
#Region "CMS_RegionalXP"
    Public MustOverride Sub CMS_RegionalXP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)

    Public MustOverride Function CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
    Public MustOverride Function CMS_RegionalXP_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Get_By_Code(PortalConnect As String, code As String) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalXP_Add(PortalConnect As String, obj As CMS_RegionalXPInfo) As Integer
    Public MustOverride Sub CMS_RegionalXP_Update(PortalConnect As String, obj As CMS_RegionalXPInfo)
    Public MustOverride Sub CMS_RegionalXP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
    Public MustOverride Sub CMS_RegionalXP_Delete(PortalConnect As String, regional_ID As Integer)
#End Region
#Region "CMS_RegionalTO"
    Public MustOverride Sub CMS_RegionalTO_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)

    Public MustOverride Function CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
    Public MustOverride Function CMS_RegionalTO_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Get_By_Code(PortalConnect As String, code As String) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_List_ByTinhHuyenXa(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, maThon As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RegionalTO_Add(PortalConnect As String, obj As CMS_RegionalTOInfo) As Integer
    Public MustOverride Sub CMS_RegionalTO_Update(PortalConnect As String, obj As CMS_RegionalTOInfo)
    Public MustOverride Sub CMS_RegionalTO_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
    Public MustOverride Sub CMS_RegionalTO_Delete(PortalConnect As String, regional_ID As Integer)
#End Region
#Region "CMS_DanhMucChung"
    Public MustOverride Function CMS_DanhMuc_List(portalId As Integer, tenDanhMuc As String) As IDataReader
    Public MustOverride Function CMS_DanhMuc_Get(portalId As Integer, tenDanhMuc As String, id As Integer) As IDataReader

    Public MustOverride Function CMS_DanhMuc_List_Search(PortalConnect As String, tenDanhMuc As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_DanhMuc_Add(PortalConnect As String, tenDanhMuc As String, code As String, name As String, desc As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_DanhMuc_Update(PortalConnect As String, tenDanhMuc As String, id As Integer, code As String, name As String, desc As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_DanhMuc_Delete(PortalConnect As String, tenDanhMuc As String, id As Integer)
#End Region
#Region "CMS_TypeEco"
    Public MustOverride Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As IDataReader
    Public MustOverride Function CMS_TypeEco_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_TypeEco_Add(PortalConnect As String, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_TypeEco_Update(PortalConnect As String, typeEco_ID As Integer, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
    Public MustOverride Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_Method"
    Public MustOverride Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Method_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Method_Add(PortalConnect As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Method_Update(PortalConnect As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
    Public MustOverride Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMSUserExtra"
    Public MustOverride Function CMSUserExtra_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMSUserExtra_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMSUserExtra_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMSUserExtra_Add(PortalConnect As String, obj As CMSUserExtraInfo) As Integer
    Public MustOverride Sub CMSUserExtra_Update(PortalConnect As String, obj As CMSUserExtraInfo)
    Public MustOverride Sub CMSUserExtra_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMSUserExtra_Get_By_User(PortalConnect As String, userName As String, PortalID As Integer) As IDataReader
#End Region

#Region "CMS_KhuCongNghiep"

    Public MustOverride Function CMS_KhuCongNghiep_Get(PortalConnect As String, industrialZone_ID As String) As IDataReader
    Public MustOverride Function CMS_KhuCongNghiep_List(PortalConnect As String, parentId As String) As IDataReader
    Public MustOverride Function CMS_KhuCongNghiep_List_ByTP(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, parentId As String) As IDataReader
    Public MustOverride Function CMS_KhuCongNghiep_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_KhuCongNghiep_Add(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_KhuCongNghiep_Update(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_KhuCongNghiep_Delete(PortalConnect As String, industrialZone_ID As String)
    Public MustOverride Sub CMS_KhuCongNghiep_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)

#End Region
End Class
