Imports Microsoft.ApplicationBlocks.Data

Public Class SqlDataProvider
    Inherits DataProvider
#Region "System - DNN"
    Public Overrides Sub DNN_Resquest_Change_Password(PortalConnect As String, UserId As Integer, isChange As Boolean)
        SqlHelper.ExecuteDataset(PortalConnect, "DNN_Resquest_Change_Password", UserId, isChange)
    End Sub
    Public Overrides Function DNN_UserConfig_List_By_Index_Role(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, WardID As Integer, subMod As String, RoleID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_Index_Role", PortalId, ProvinID, DistrictID, WardID, subMod, RoleID), IDataReader)
    End Function
    Public Overrides Function DNN_User_Get_Telephone(PortalId As String, userName As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_User_Get_Telephone", userName), String)
    End Function
    Public Overrides Function DNN_User_Get_Property(PortalId As String, userName As String, proName As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_User_Get_Property", userName, proName), String)
    End Function
    Public Overrides Function DNN_UserConfig_List_By_Roles(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, rolesID As String, isOrder As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_Roles", PortalId, subMod, Search, currPage, recodperpage, rolesID, isOrder), IDataReader)
    End Function
    Public Overrides Function DNN_UserConfig_List_By_Index(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, subMod As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_Index", PortalId, ProvinID, DistrictID, subMod), IDataReader)
    End Function
    Public Overrides Sub DNN_Tabs_UpdateSkin(PortalConnect As String, TabID As Integer, ByVal SkinSrc As String)
        SqlHelper.ExecuteDataset(PortalConnect, "DNN_Tabs_UpdateSkin", TabID, SkinSrc)
    End Sub
    Public Overrides Function DNN_Users_List_BirthDay(PortalId As Integer, PropertyName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Users_List_BirthDay", PortalId, PropertyName), IDataReader)
    End Function
    Public Overrides Function AddTab(PortalConnect As String, contentItemID As Integer, portalID As Integer, tabOrder As Integer, uniqueId As Guid, versionGuid As Guid, defaultLanguageGuid As Guid, localizedVersionGuid As Guid, tabName As String, isVisible As Boolean, disableLink As Boolean, parentId As Integer, iconFile As String, IconFileLarge As String, title As String, description As String, keyWords As String, url As String, skinSrc As String, containerSrc As String, startDate As DateTime, endDate As DateTime, refreshInterval As Integer, pageHeadText As String, isSecure As Boolean, permanentRedirect As Boolean, siteMapPriority As Double, createdByUserID As Integer, cultureCode As String, isSystem As Boolean) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "AddTab", contentItemID, portalID, tabOrder, uniqueId, versionGuid, defaultLanguageGuid, localizedVersionGuid, tabName, isVisible, disableLink, flReg.GetNull(parentId), flReg.GetNull(iconFile), flReg.GetNull(IconFileLarge), flReg.GetNull(title), flReg.GetNull(description), flReg.GetNull(keyWords), flReg.GetNull(url), flReg.GetNull(skinSrc), flReg.GetNull(containerSrc), flReg.GetNull(startDate), flReg.GetNull(endDate), refreshInterval, flReg.GetNull(pageHeadText), isSecure, permanentRedirect, siteMapPriority, createdByUserID, cultureCode, isSystem), Integer)
    End Function
    Public Overrides Function DNN_GetDesktopModulesID(PortalConnect As String, FriendlyName As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "DNN_GetDesktopModulesByFriendlyName", FriendlyName), Integer)
    End Function
    Public Overrides Function AddTabPermission(PortalConnect As String, tabID As Integer, permissionID As Integer, roleID As Integer, allowAccess As Boolean, userID As Integer, createdByUserID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "AddTabPermission", tabID, permissionID, roleID, allowAccess, flReg.GetNull(userID), flReg.GetNull(createdByUserID)), Integer)
    End Function
    Public Overrides Function DNN_ContentItems_Add(PortalConnect As String, content As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "DNN_ContentItems_Add", content), Integer)
    End Function
    Public Overrides Sub DNN_ContentItems_Update_Tabid(PortalConnect As String, contentItemID As Integer, tabID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DNN_ContentItems_Update_Tabid", contentItemID, tabID)
    End Sub
    Public Overrides Sub DeleteTabPermissionsByTabID(PortalConnect As String, tabID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DeleteTabPermissionsByTabID", tabID)
    End Sub
    Public Overrides Sub DNN_TabHasBeenPublished(PortalConnect As String, tabID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DNN_TabHasBeenPublished", tabID)
    End Sub
    Public Overrides Sub DNN_Update_TabName_Set_ID(PortalConnect As String, TabID As Integer, TabName As String, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DNN_Update_TabName_Set_ID", TabID, TabName, PortalID)
    End Sub
    Public Overrides Function DNN_User_List_By_Role(portalid As Integer, RoleName As String, UserName As String) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_List_By_Role", portalid, RoleName, UserName)
    End Function
    Public Overrides Function RPT_User_List_By_Role(portalid As Integer, RoleName As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "RPT_User_List_By_Role", portalid, RoleName, FromDate, ToDate)
    End Function
    Public Overrides Sub DNN_TabModuleSettings_Add(PortalConnect As String, portalid As Integer, TabModuleID As Integer, SettingName As String, SettingValue As String, CreatedByUserID As Integer, CreatedOnDate As DateTime, LastModifiedByUserID As Integer, LastModifiedOnDate As DateTime)
        SqlHelper.ExecuteScalar(PortalConnect, "DNN_TabModuleSettings_Add", TabModuleID, SettingName, SettingValue, CreatedByUserID, CreatedOnDate, LastModifiedByUserID, LastModifiedOnDate)
    End Sub
    Public Overrides Function DNN_Tabs_Get_TabPath(PortalConnect As String, TabPath As String, portalid As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "DNN_Tabs_Get_TabPath", TabPath, portalid), Integer)
    End Function
    Public Overrides Function DNN_Categories_Portal_List_All(PortalID As Integer, LanguageId As String) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Categories_Portal_List_All", PortalID, LanguageId)
    End Function
    Public Overrides Function DNN_Tabs_Get(TabID As Integer, PortalID As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_Tabs_Get", TabID, PortalID), String)
    End Function
    Public Overrides Function DNN_Tabs_List_TabPath(PortalConnect As String, TabID As Integer, PortalID As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "DNN_Tabs_List_TabPath", TabID, PortalID), String)
    End Function
    Public Overrides Function DNN_Tabs_Get_By_ParentID(PortalConnect As String, ParentId As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "DNN_Tabs_Get_By_ParentID", ParentId), IDataReader)
    End Function
    Public Overrides Function DNN_Tabs_Get_Parent_IsNull(PortalConnect As String, PortalID As Integer, cms As Boolean, tabname As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "DNN_Tabs_Get_Parent_IsNull", PortalID, cms, tabname), IDataReader)
    End Function
    Public Overrides Function DNN_Portal_Get_By_ID(PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Portal_Get_By_ID", PortalID), IDataReader)
    End Function
    Public Overrides Function DNN_User_Get_By_ID(PortalId As Integer, UserId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_Get_By_ID", PortalId, UserId), IDataReader)
    End Function
    Public Overrides Function DNN_Portal_List_Lang(lang As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Portal_List_Lang", lang), IDataReader)
    End Function
    Public Overrides Function DNN_Portal_Get_By_UserID(UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Portal_Get_By_UserID", UserName), IDataReader)
    End Function
    Public Overrides Function DNN_GetPortalLocalizations_PortalIDExt(portalID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "GetPortalLocalizations_PortalIDExt", portalID), IDataReader)
    End Function
    Public Overrides Function DNN_TabModuleSettings_Get_Value_Module(TabModuleID As String, ModuleTitle As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_TabModuleSettings_Get_Value_Module", TabModuleID, ModuleTitle), IDataReader)
    End Function
    Public Overrides Function DNN_TabModuleSettings_Get_Value(PortalConnect As String, PortalId As Integer, TabModuleID As String, SettingName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "DNN_TabModuleSettings_Get_Value", TabModuleID, SettingName), IDataReader)
    End Function
    Public Overrides Function DNN_TabModuleSettings_Get_Control(PortalConnect As String, PortalId As Integer, Control As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "DNN_TabModuleSettings_Get_Control", PortalId, Control), IDataReader)
    End Function
    Public Overrides Function DNN_TabModuleSettings_Get_ModuleTitle(PortalId As Integer, ModuleTitle As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_TabModuleSettings_Get_ModuleTitle", PortalId, ModuleTitle), IDataReader)
    End Function
    Public Overrides Sub DNN_Update_TabName(PortalConnect As String, TabID As Integer, TabName As String, TabTitle As String, Description As String, ParentID As Integer, TabPath As String, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DNN_Update_TabName", TabID, TabName, TabTitle, Description, ParentID, TabPath, PortalID)
    End Sub
    Public Overrides Sub DNN_Update_TabName_Set_ID(TabID As Integer, TabName As String, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DNN_Update_TabName_Set_ID", TabID, TabName, PortalID)
    End Sub
    Public Overrides Function DNN_GetDesktopModules_By_FriendlyName(FriendlyName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_GetDesktopModules_By_FriendlyName", FriendlyName), IDataReader)
    End Function
    Public Overrides Function DNN_PortalID_Get_By_ParentID(ParentId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_PortalID_Get_By_ParentID", ParentId), IDataReader)
    End Function
    Public Overrides Function DNN_UserConfig_List_By_Search(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_Search", PortalId, subMod, Search, currPage, recodperpage, roleID, tinhTP, quanHuyen, xaPhuong), IDataReader)
    End Function
    Public Overrides Function DNN_UserConfig_List_By_Category(PortalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_Category", PortalId), IDataReader)
    End Function
    Public Overrides Function DNN_PortalID_Get_Parent_IsNull(PortalId As Integer, IsCMS As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_PortalID_Get_Parent_IsNull", PortalId, IsCMS), IDataReader)
    End Function
    Public Overrides Function DNN_User_Get(PortalId As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_Get", PortalId, UserName), IDataReader)
    End Function
    Public Overrides Function DNN_User_Check_Delete(PortalID As Integer, UserName As String) As Boolean
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_User_Check_Delete", PortalID, UserName), Boolean)
    End Function
    Public Overrides Function DNN_User_Get_Email(Email As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_Get_Email", Email), IDataReader)
    End Function
    Public Overrides Function DNN_User_GetAll(portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_GetAll", portalID, IsDeleted, IsSuperUser, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function DNN_User_List_Search(portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_List_Search", portalID, IsDeleted, IsSuperUser, IsOrder, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub DNN_Tabs_Delete(PortalConnect As String, PortalId As Integer, TabID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "DNN_Tabs_Delete", PortalId, TabID)
    End Sub
    Public Overrides Function DNN_User_List_By_UserName(PortalId As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_User_List_By_UserName", PortalId, UserName), IDataReader)
    End Function
    Public Overrides Function DNN_Files_Get_By_FileName(PortalId As Integer, FileName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Files_Get_By_FileName", PortalId, FileName), IDataReader)
    End Function
    Public Overrides Function DNN_Files_Get_By_FileID(FileID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_Files_Get_By_FileID", FileID), IDataReader)
    End Function
    Public Overrides Function DNN_GetRestPassWord(RestPassWordId As String, IsLang As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_GetRestPassWord", RestPassWordId, IsLang), IDataReader)
    End Function
    Public Overrides Sub DNN_AddRestPassWord(RestPassWordId As String, PortalID As String, Username As String, Email As String, EndDate As String)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DNN_AddRestPassWord", RestPassWordId, PortalID, Username, Email, EndDate)
    End Sub
    Public Overrides Sub DNN_UpdateRestPassWord(RestPassWordId As String)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DNN_UpdateRestPassWord", RestPassWordId)
    End Sub
    Public Overrides Function DNN_CountMessage(UserId As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_CountMessage", UserId), IDataReader)
    End Function
    Public Overrides Function DNN_LogHistory(UserId As String, currPage As String, recodperpage As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_LogHistory", UserId, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub DNN_User_Lock(UserId As String, IsDelete As Boolean, PortalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DNN_User_Lock", UserId, IsDelete, PortalId)
    End Sub
    Public Overrides Sub DNN_User_DeleteLock(UserId As String, IsDelete As Boolean, PortalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DNN_User_DeleteLock", UserId, IsDelete, PortalId)
    End Sub
    Public Overrides Function DNN_UserConfig_List_By_SearchBanBe(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "DNN_UserConfig_List_By_SearchBanBe", PortalId, subMod, Search, currPage, recodperpage, roleID, tinhTP, quanHuyen, xaPhuong, userName), IDataReader)
    End Function
#End Region
#Region "CMS_Settings"
    Public Overrides Function CMS_Settings_Get_Value(PortalConnect As String, SubMod As String, setting_Key As String, setting_Page As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Settings_Get_Value", SubMod, setting_Key, setting_Page), IDataReader)
    End Function
    Public Overrides Sub CMS_Settings_Update(PortalConnect As String, setting_ID As String, SubMod As String, setting_Key As String, setting_Value As String, setting_Page As String, createdBy As DateTime, UserName As String, updatedBy As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(PortalConnect, "CMS_Settings_Update", setting_ID, SubMod, setting_Key, setting_Value, setting_Page, createdBy, UserName, flReg.DateNull(updatedBy), updatedUser)
    End Sub

#End Region
#Region "CMSConnection"
    Public Overrides Function CMSInConn_Get_PortalID(PortalID As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSInConn_Get_PortalID", PortalID), String)
    End Function
    Public Overrides Function CMSTpConn_Get_TinhTP(TinhTP As Integer, IdKey As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSTpConn_Get_TinhTP", TinhTP, IdKey), String)
    End Function
    Public Overrides Function CMSConnection_Get(PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSConnection_Get", PortalID), IDataReader)
    End Function
    Public Overrides Function CMSConnection_List_By_PortalID(PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSConnection_List_By_PortalID", PortalID), IDataReader)
    End Function
    Public Overrides Function CMSConn_Get_By_SqlCode(PortalID As Integer, sqlCode As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSConn_Get_By_SqlCode", PortalID, sqlCode), String)
    End Function
#End Region
#Region "CMSCookie"
    Public Overrides Function CMSCookie_Get(idKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSCookie_Get", idKey), IDataReader)
    End Function
    Public Overrides Function CMSCookie_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSCookie_List"), IDataReader)
    End Function
    Public Overrides Function CMSCookie_Get_Token(idKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSCookie_Get_Token", idKey), IDataReader)
    End Function
    Public Overrides Sub CMSCookie_Add(idKey As String, idValue As String, userName As String, crtVal As String, crtDate As DateTime)
        SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSCookie_Add", idKey, idValue, userName, crtVal, crtDate)
    End Sub
    Public Overrides Sub CMSCookie_Update(idKey As String, idValue As String)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSCookie_Update", idKey, idValue)
    End Sub
    Public Overrides Sub CMSCookie_Delete(idKey As String)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSCookie_Delete", idKey)
    End Sub
#End Region
#Region "CMSUserPortal"
    Public Overrides Function DNN_UserPortals_Add(PortalID As Integer, FromPortal As Integer, ToPortal As Integer, UserName As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_UserPortals_Add", FromPortal, ToPortal, UserName)
    End Function
    Public Overrides Function AddUserPortal(PortalID As Integer, UserID As Integer) As Integer
        Return CInt(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "AddUserPortal", PortalID, UserID))
    End Function
    Public Overrides Sub DeleteUserPortal(UserID As Integer, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "DeleteUserPortal", UserID, PortalID)
    End Sub
    Public Overrides Function CMSUserPortal_List_User(PortalConnect As String, subMod As String, PortalID As Integer, displayName As String, gender As Integer, levelID As String, needID As String, roleID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        If PortalConnect <> "" Then
            Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMSUserPortal_List_User", subMod, PortalID, displayName, gender, levelID, needID, roleID, currPage, recodperpage), IDataReader)
        Else
            Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserPortal_List_User", subMod, PortalID, displayName, gender, levelID, needID, roleID, currPage, recodperpage), IDataReader)
        End If
    End Function
    Public Overrides Function CMSUserPortal_List(userID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserPortal_List", userID), IDataReader)
    End Function
    Public Overrides Function CMSUserPortal_Get_By_User(PortalConnect As String, userName As String, subMod As String, PortalID As Integer) As IDataReader
        If PortalConnect <> "" Then
            Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMSUserPortal_Get_By_User", userName, subMod, PortalID), IDataReader)
        Else
            Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserPortal_Get_By_User", userName, subMod, PortalID), IDataReader)
        End If
    End Function
    Public Overrides Function CMSUserPortal_Get_By_CCCD(PortalConnect As String, CCCD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserPortal_Get_By_CCCD", CCCD), IDataReader)
    End Function
    Public Overrides Function CMSUserPortal_Add(obj As CMSUserPortalInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSUserPortal_Add", obj.UserName, flReg.GetNull(obj.SubMod), flReg.GetNull(obj.ProvinID), flReg.GetNull(obj.DistrictID), flReg.GetNull(obj.WardID), flReg.GetNull(obj.RolesID), flReg.GetNull(obj.PortalID), flReg.GetNull(obj.Gender), flReg.GetNull(obj.DateOfBirth), flReg.GetNull(obj.Address), flReg.GetNull(obj.Email), flReg.GetNull(obj.Telephone), flReg.GetNull(obj.DisplayName), flReg.GetNull(obj.IsStatus), flReg.GetNull(obj.IsWork), flReg.GetNull(obj.CMND)), Integer)
    End Function
    Public Overrides Sub CMSUserPortal_Delete(userName As String, subMod As String, PortalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSUserPortal_Delete", userName, subMod, PortalID)
    End Sub
    Public Overrides Sub CMSUserPortal_Add_Roles(PortalID As Integer, userName As String, subMod As String, rolesID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSUserPortal_Add_Roles", PortalID, userName, subMod, rolesID)
    End Sub
#End Region
#Region "NextPage"
    Public Overrides Function DNN_NextPageJs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_NextPageJs", intTotal, recodperPage, currPage, Pagesize, functions), String)
    End Function
    Public Overrides Function DNN_NextPageVs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_NextPageVs", intTotal, recodperPage, currPage, Pagesize, functions), String)
    End Function

    Public Overrides Function DNN_NextPage(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, hrefPage As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "DNN_NextPage", intTotal, recodperPage, currPage, Pagesize, hrefPage), String)
    End Function
#End Region
#Region "CMS_Module"
    Public Overrides Function CMS_Module_List_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_Parent_ID", subMod, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_Menu_Top(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_Menu_Top", subMod, VaiTro, Parent_ID, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Module_Get_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_Get_Parent_ID", subMod, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_Parent(PortalConnect As String, subMod As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_Parent", subMod), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_Menu(PortalConnect As String, subMod As String, VaiTro As String, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_Menu", subMod, VaiTro, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_Security(PortalConnect As String, subMod As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_Security", subMod, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_By_User(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_By_User", subMod, VaiTro, Parent_ID, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_By_Admin(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_By_Admin", subMod, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List_By_Host(PortalConnect As String, subMod As String, Parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List_By_Host", subMod, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Module_Get(PortalConnect As String, subMod As String, module_Src As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_Get", subMod, module_Src), IDataReader)
    End Function
    Public Overrides Function CMS_Module_List(PortalConnect As String, subMod As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_Module_List", subMod), IDataReader)
    End Function
    Public Overrides Sub CMS_Module_Add(PortalConnect As String, subMod As String, module_ID As String, moduleSrc As String, moduleName As String, isAdmin As Boolean, isUser As Boolean, status As Boolean, ctlView As String, ctlEdit As String, img As String, isOrder As Integer, Parent_ID As String)
        SqlHelper.ExecuteScalar(PortalConnect, "CMS_Module_Add", module_ID, subMod, moduleSrc, moduleName, isAdmin, isUser, status, ctlView, ctlEdit, img, isOrder, flReg.GetNull(Parent_ID))
    End Sub
    Public Overrides Sub CMS_Module_Delete(PortalConnect As String, module_ID As String)
        SqlHelper.ExecuteNonQuery(PortalConnect, "CMS_Module_Delete", module_ID)
    End Sub
#End Region
#Region "CMS_UserConfig"
    Public Overrides Function CMS_UserConfig_Get_By_UserName_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_UserConfig_Get_By_UserName_ModuleSrc", subMod, UserName, ModuleSrc, TinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_UserConfig_Get_By_UserName(PortalConnect As String, subMod As String, UserName As String, TinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_UserConfig_Get_By_UserName", subMod, UserName, TinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_UserConfig_Get_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_UserConfig_Get_By_ModuleSrc", subMod, UserName, ModuleSrc, TinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_UserConfig_Get(PortalConnect As String, userConfig_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_UserConfig_Get", userConfig_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UserConfig_List(PortalConnect As String, subMod As String, portalId As Integer, TinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMS_UserConfig_List", subMod, portalId, TinhTP), IDataReader)
    End Function
    Public Overrides Sub CMS_UserConfig_Add(PortalConnect As String, subMod As String, userName As String, moduleSrc As String, portalID As Integer, TinhTP As Integer)
        SqlHelper.ExecuteScalar(PortalConnect, "CMS_UserConfig_Add", subMod, userName, moduleSrc, portalID, TinhTP)
    End Sub
    Public Overrides Sub CMS_UserConfig_Update(PortalConnect As String, subMod As String, userConfig_ID As Integer, userName As String, moduleSrc As String, portalID As Integer, TinhTP As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "CMS_UserConfig_Update", userConfig_ID, subMod, userName, moduleSrc, portalID, TinhTP)
    End Sub
    Public Overrides Sub CMS_UserConfig_Delete(PortalConnect As String, userConfig_ID As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "CMS_UserConfig_Delete", userConfig_ID)
    End Sub
    Public Overrides Sub CMS_UserConfig_Delete_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As Integer)
        SqlHelper.ExecuteNonQuery(PortalConnect, "CMS_UserConfig_Delete_By_ModuleSrc", subMod, UserName, ModuleSrc, TinhTP)
    End Sub
#End Region
#Region "CMS_Nation"
    Public Overrides Function CMS_Nation_Get_By_Name(PortalConnect As String, Nation_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Nation_Get_By_Name", Nation_Name), IDataReader)
    End Function
    Public Overrides Function CMS_Nation_Get(PortalConnect As String, nation_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Nation_Get", nation_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Nation_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Nation_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Nation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Nation_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Nation_Add(PortalConnect As String, obj As CMS_NationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Nation_Add", obj.Nation_Code, obj.Nation_Name, obj.Nation_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Nation_Update(PortalConnect As String, obj As CMS_NationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Nation_Update", obj.Nation_ID, obj.Nation_Code, obj.Nation_Name, obj.Nation_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Nation_Delete(PortalConnect As String, nation_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Nation_Delete", nation_ID)
    End Sub
#End Region
#Region "CMS_National"
    Public Overrides Function CMS_National_Get(PortalConnect As String, national_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_National_Get", national_ID), IDataReader)
    End Function
    Public Overrides Function CMS_National_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_National_List"), IDataReader)
    End Function
    Public Overrides Function CMS_National_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_National_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_National_Add(PortalConnect As String, obj As CMS_NationalInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_National_Add", obj.National_Code, obj.National_Name, obj.National_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_National_Update(PortalConnect As String, obj As CMS_NationalInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_National_Update", obj.National_ID, obj.National_Code, obj.National_Name, obj.National_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_National_Delete(PortalConnect As String, national_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_National_Delete", national_ID)
    End Sub
#End Region
#Region "CMS_Position"
    Public Overrides Function CMS_Position_Get_By_Name(PortalConnect As String, Position_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Position_Get_By_Name", Position_Name), IDataReader)
    End Function
    Public Overrides Function CMS_Position_Get(PortalConnect As String, position_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Position_Get", position_ID), IDataReader)
    End Function
    Public Overrides Function SV_Position_Get_By_IdKey(PortalConnect As String, position_Code As Integer) As String
        Return SqlHelper.ExecuteScalar(flConnect.DmConnect, "SV_Position_Get_By_IdKey", position_Code)
    End Function
    Public Overrides Function CMS_Position_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Position_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Position_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Position_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Position_Add", obj.Position_Code, obj.Position_Name, obj.Position_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Function SV_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "SV_Position_Add", obj.Position_Code, obj.Position_Name, obj.Position_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.ID), Integer)
    End Function
    Public Overrides Sub CMS_Position_Update(PortalConnect As String, obj As CMS_PositionInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Position_Update", obj.Position_ID, obj.Position_Code, obj.Position_Name, obj.Position_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Position_Delete(PortalConnect As String, position_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Position_Delete", position_ID)
    End Sub
#End Region
#Region "CMS_Religion"
    Public Overrides Function CMS_Religion_Get_By_Name(PortalConnect As String, Religion_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Religion_Get_By_Name", Religion_Name), IDataReader)
    End Function

    Public Overrides Function CMS_Religion_Get(PortalConnect As String, religion_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Religion_Get", religion_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Religion_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Religion_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Religion_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Religion_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Religion_Add(PortalConnect As String, obj As CMS_ReligionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Religion_Add", obj.Religion_Code, obj.Religion_Name, obj.Religion_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Religion_Update(PortalConnect As String, obj As CMS_ReligionInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Religion_Update", obj.Religion_ID, obj.Religion_Code, obj.Religion_Name, obj.Religion_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Religion_Delete(PortalConnect As String, religion_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Religion_Delete", religion_ID)
    End Sub
#End Region
#Region "CMS_Regional"
    Public Overrides Function SV_Regional_Get_By_IdKey(PortalConnect As String, Regional_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.DmConnect, "SV_Regional_Get_By_IdKey", Regional_Code)
    End Function
    Public Overrides Function CMS_Regional_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Regional_Get_Name_Parent", parentID, Regional_Name), Integer)
    End Function
    Public Overrides Function CMS_Regional_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Get_By_Name", Regional_Name), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Get_By_Code(PortalConnect As String, code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Get_By_Code", code), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Get", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_List_Parent_Null(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_List_Parent_Null"), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Parent_Search_Null", search, isOrder), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Parent_Search_ID_Deleted", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Get_By_CMS_Regional(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Regional_Get_By_CMS_Regional", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Regional_Add(PortalConnect As String, obj As CMS_RegionalInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Regional_Add", obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Regional_Update(PortalConnect As String, obj As CMS_RegionalInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Regional_Update", obj.Regional_ID, obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Regional_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Regional_Update_Delete", regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Overrides Sub CMS_Regional_Delete(PortalConnect As String, regional_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Regional_Delete", regional_ID)
    End Sub
#End Region
#Region "CMS_Roles"
    Public Overrides Function CMS_Roles_Get(PortalConnect As String, roles_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Roles_Get", roles_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Roles_Check_Code(PortalConnect As String, SubMod_ID As Integer, roles_ID As Integer, Roles_Code As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Roles_Check_Code", SubMod_ID, roles_ID, Roles_Code), Integer)
    End Function
    Public Overrides Function CMS_Roles_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Roles_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Roles_List_Search(PortalConnect As String, search As String, SubMod_ID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Roles_List_Search", search, SubMod_ID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Roles_Add(PortalConnect As String, obj As CMS_RolesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Roles_Add", obj.SubMod_ID, obj.Roles_Code, obj.Roles_Name, obj.Roles_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Roles_Update(PortalConnect As String, obj As CMS_RolesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Roles_Update", obj.Roles_ID, obj.SubMod_ID, obj.Roles_Code, obj.Roles_Name, obj.Roles_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Function CMS_Roles_Get_By_CMS_SubMod(PortalConnect As String, subMod_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Roles_Get_By_CMS_SubMod", subMod_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Roles_Get_By_SubMod_Code(PortalConnect As String, subMod_ID As Integer, roleCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Roles_Get_By_SubMod_Code", subMod_ID, roleCode), IDataReader)
    End Function
    Public Overrides Sub CMS_Roles_Delete(PortalConnect As String, roles_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Roles_Delete", roles_ID)
    End Sub
#End Region
#Region "CMS_SubMod"
    Public Overrides Function CMS_SubMod_Get_By_Path(PortalConnect As String, subMod_Path As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_SubMod_Get_By_Path", subMod_Path), IDataReader)
    End Function
    Public Overrides Function CMS_SubMod_Get(PortalConnect As String, subMod_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_SubMod_Get", subMod_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SubMod_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_SubMod_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SubMod_ListActive(PortalConnect As String, isActive As Int16) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_SubMod_ListActive", isActive), IDataReader)
    End Function
    Public Overrides Function CMS_SubMod_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_SubMod_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_SubMod_Add(PortalConnect As String, obj As CMS_SubModInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_SubMod_Add", obj.SubMod_Path, obj.SubMod_Name, obj.SubMod_Img, obj.SubMod_Order), Integer)
    End Function
    Public Overrides Sub CMS_SubMod_Update(PortalConnect As String, obj As CMS_SubModInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_SubMod_Update", obj.SubMod_ID, obj.SubMod_Path, obj.SubMod_Name, obj.SubMod_Img, obj.SubMod_Order)
    End Sub
    Public Overrides Sub CMS_SubMod_Delete(PortalConnect As String, subMod_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_SubMod_Delete", subMod_ID)
    End Sub
#End Region
#Region "CMS_Language"
    Public Overrides Function CMS_Language_Get(PortalConnect As String, Language_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Language_Get", Language_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Language_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Language_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Language_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Language_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Language_Add(PortalConnect As String, obj As CMS_LanguageInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Language_Add", obj.Language_Code, obj.Language_Name, obj.Language_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Language_Update(PortalConnect As String, obj As CMS_LanguageInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Language_Update", obj.Language_ID, obj.Language_Code, obj.Language_Name, obj.Language_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Language_Delete(PortalConnect As String, Language_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Language_Delete", Language_ID)
    End Sub
#End Region
#Region "CMS_Education"
    Public Overrides Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Education_Get", Education_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Education_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Education_List"), IDataReader)
    End Function
    Public Overrides Function SV_Education_Get_By_IdKey(PortalConnect As String, education_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.DmConnect, "SV_Education_Get_By_IdKey", education_Code)
    End Function
    Public Overrides Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Education_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Education_Add", obj.Education_Code, obj.Education_Name, obj.Education_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Function SV_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "SV_Education_Add", obj.Education_Code, obj.Education_Name, obj.Education_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.IdSend), Integer)
    End Function
    Public Overrides Sub CMS_Education_Update(PortalConnect As String, obj As CMS_EducationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Education_Update", obj.Education_ID, obj.Education_Code, obj.Education_Name, obj.Education_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Education_Delete", Education_ID)
    End Sub
#End Region
#Region "CMSCache"
    Public Overrides Function CMSCache_Get_IP(PortalConnect As String, iP As String, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMSCache_Get_IP", iP, PortalID), IDataReader)
    End Function
    Public Overrides Function CMSCache_Add(PortalConnect As String, CacheName As String, iP As String, PortalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(PortalConnect, "CMSCache_Add", CacheName, iP, PortalID), Integer)
    End Function
#End Region
#Region "CMS_Buglog"
    Public Overrides Function CMS_Buglog_Get(PortalConnect As String, buglog_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Buglog_Get", buglog_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Buglog_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Buglog_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Buglog_Add(PortalConnect As String, Contents As String, TabName As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Buglog_Add", Contents, Now, TabName), Integer)
    End Function
    Public Overrides Sub CMS_Buglog_Update(PortalConnect As String, obj As CMS_BuglogInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Buglog_Update", obj.Buglog_ID, obj.Contents, obj.CreateDate, obj.TabName)
    End Sub
    Public Overrides Sub CMS_Buglog_Delete(PortalConnect As String, buglog_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Buglog_Delete", buglog_ID)
    End Sub
    Public Overrides Function CMS_Buglog_List_By_TabName(PortalConnect As String, TabName As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Buglog_List_By_TabName", TabName, iD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Buglog_Update_Resolve(PortalConnect As String, Buglog_ID As Integer, Resolve As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Buglog_Update_Resolve", Buglog_ID, Resolve)
    End Sub

#End Region
#Region "CMS_Relation"
    Public Overrides Function CMS_Relation_Get_By_Name(PortalConnect As String, Relation_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Relation_Get_By_Name", Relation_Name), IDataReader)
    End Function
    Public Overrides Function CMS_Relation_Get(PortalConnect As String, Relation_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Relation_Get", Relation_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Relation_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Relation_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Relation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Relation_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Relation_Add(PortalConnect As String, obj As CMS_RelationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Relation_Add", obj.Relation_Code, obj.Relation_Name, obj.Relation_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Relation_Update(PortalConnect As String, obj As CMS_RelationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Relation_Update", obj.Relation_ID, obj.Relation_Code, obj.Relation_Name, obj.Relation_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Relation_Delete(PortalConnect As String, Relation_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Relation_Delete", Relation_ID)
    End Sub
#End Region
#Region "CMS_ActiveDomain"
    Public Overrides Function CMS_ActiveDomain_Get(PortalConnect As String, domain_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ActiveDomain_Get", domain_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ActiveDomain_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ActiveDomain_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ActiveDomain_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, tinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ActiveDomain_List_Search", search, isOrder, currPage, recodperpage, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_ActiveDomain_Check_Active(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, domain As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ActiveDomain_Check_Active", tinhTP, quanHuyen, domain), IDataReader)
    End Function
    Public Overrides Function CMS_ActiveDomain_Add(PortalConnect As String, obj As CMS_ActiveDomainInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_ActiveDomain_Add", obj.MaTinh, obj.MaHuyen, obj.DomainName, obj.GhiChu, obj.ActiveDate, obj.ExpriteDate, obj.IsActive, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_ActiveDomain_Update(PortalConnect As String, obj As CMS_ActiveDomainInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_ActiveDomain_Update", obj.Domain_ID, obj.MaTinh, obj.MaHuyen, obj.DomainName, obj.GhiChu, obj.ActiveDate, obj.ExpriteDate, obj.IsActive, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_ActiveDomain_Delete(PortalConnect As String, domain_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_ActiveDomain_Delete", domain_ID)
    End Sub
#End Region
#Region "CMS_Area"
    Public Overrides Function CMS_Area_Get(PortalConnect As String, Area_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Area_Get", Area_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Area_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Area_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Area_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Area_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Area_Add(PortalConnect As String, obj As CMS_AreaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Area_Add", obj.Area_Code, obj.Area_Name, obj.Area_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Area_Update(PortalConnect As String, obj As CMS_AreaInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Area_Update", obj.Area_ID, obj.Area_Code, obj.Area_Name, obj.Area_Des, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Area_Delete(PortalConnect As String, Area_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Area_Delete", Area_ID)
    End Sub
#End Region
#Region "CMS_Place"
    Public Overrides Function CMS_Place_Get_By_Name(PortalConnect As String, Place_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Place_Get_By_Name", Place_Name), IDataReader)
    End Function
    Public Overrides Function CMS_Place_Get(PortalConnect As String, Place_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Place_Get", Place_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Place_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Place_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Place_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Place_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Place_Add(PortalConnect As String, Place_Name As String, Place_Code As String, Place_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Place_Add", Place_Name, Place_Code, Place_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId), Integer)
    End Function
    Public Overrides Sub CMS_Place_Update(PortalConnect As String, Place_ID As Integer, Place_Name As String, Place_Code As String, Place_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Place_Update", Place_ID, Place_Name, Place_Code, Place_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Place_Delete(PortalConnect As String, Place_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Place_Delete", Place_ID)
    End Sub
#End Region
#Region "CMS_ConfigTP"
    Public Overrides Function CMS_ConfigTP_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ConfigTP_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ConfigTP_Get_By_TinhTP(PortalConnect As String, TinhTP As Integer, PortalAlias As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ConfigTP_Get_By_TinhTP", TinhTP, PortalAlias), IDataReader)
    End Function
    Public Overrides Function CMS_ConfigTP_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ConfigTP_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ConfigTP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_ConfigTP_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function TP_ChuyenDoi_Get(PortalConnect As String, ID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "TP_ChuyenDoi_Get", ID), Integer)
    End Function
    Public Overrides Function CMS_ConfigTP_Add(PortalConnect As String, obj As CMS_ConfigTPInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_ConfigTP_Add", flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.PortalLogo), flReg.GetNull(obj.PortalName), flReg.GetNull(obj.PortalImg), flReg.GetNull(obj.PortalAlias), flReg.GetNull(obj.PortalDes)), Integer)
    End Function
    Public Overrides Sub CMS_ConfigTP_Update(PortalConnect As String, obj As CMS_ConfigTPInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_ConfigTP_Update", obj.ID, flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.PortalLogo), flReg.GetNull(obj.PortalName), flReg.GetNull(obj.PortalImg), flReg.GetNull(obj.PortalAlias), flReg.GetNull(obj.PortalDes))
    End Sub
    Public Overrides Sub CMS_ConfigTP_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_ConfigTP_Delete", iD)
    End Sub
#End Region
#Region "CMS_DayOff"
    Public Overrides Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_DayOff_Get", dayOff_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DayOff_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_DayOff_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_DayOff_Add(PortalConnect As String, obj As CMS_DayOffInfo)
        SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_DayOff_Add", obj.DayOff_ID, obj.DayOff_Name, obj.IsDay, obj.IsMonth, obj.IsYear, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_DayOff_Update(PortalConnect As String, obj As CMS_DayOffInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_DayOff_Update", obj.DayOff_ID, obj.DayOff_Name, obj.IsDay, obj.IsMonth, obj.IsYear, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_DayOff_Delete", dayOff_ID)
    End Sub
    Public Overrides Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_DayOff_Get_Day_Month", isDay, isMonth), Integer)
    End Function
    Public Overrides Function CMS_OffTime_Get_By_Dates(PortalConnect As String, Dates As DateTime) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_OffTime_Get_By_Dates", Dates), Integer)
    End Function
    Public Overrides Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_DayOff_List_Search", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_DayOff_Update_Quick(PortalConnect As String, dayOff_ID As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_DayOff_Update_Quick", dayOff_ID, isActive, isOrder)
    End Sub
    Public Overrides Function CMS_DayOff_TinhNgay(PortalConnect As String, Dates As DateTime, soNgay As Integer) As DateTime
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_DayOff_TinhNgay", Dates, soNgay), DateTime)
    End Function
#End Region
#Region "CMS_API"
    Public Overrides Function CMS_API_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_API_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_API_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_API_List"), IDataReader)
    End Function
    Public Overrides Function CMS_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_API_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_API_Add(PortalConnect As String, obj As CMS_APIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().DmConnect, "CMS_API_Add", obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_API_Update(PortalConnect As String, obj As CMS_APIInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().DmConnect, "CMS_API_Update", obj.Id, obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_API_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().DmConnect, "CMS_API_Delete", id, userId)
    End Sub
#End Region
#Region "CMS_APIHeader"
    Public Overrides Function CMS_APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_APIHeader_Get", id), IDataReader)
    End Function
    'Public Overrides Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    '    Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APIHeader_List", idAPI), IDataReader)
    'End Function

    Public Overrides Function CMS_APIHeader_Add(PortalConnect As String, obj As CMS_APIHeaderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().DmConnect, "CMS_APIHeader_Add", obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_APIHeader_Update(PortalConnect As String, obj As CMS_APIHeaderInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().DmConnect, "CMS_APIHeader_Update", obj.Id, obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().DmConnect, "CMS_APIHeader_Delete", id, userId)
    End Sub
    Public Overrides Function CMS_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_APIHeader_List_Search", idAPI, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().DmConnect, "CMS_APIHeader_LichDongBo", id, lichDongBo, userId)
    End Sub
#End Region

#Region "CMS_RegionalTP"
    Public Overrides Sub CMS_RegionalTP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTP_Backup_Add", maTinh, yearID)
    End Sub
    Public Overrides Function CMS_RegionalTP_Backup_List_Parent_Null(PortalConnect As String, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Backup_List_Parent_Null", yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Backup_Get", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalTP_Get_Name_Parent", parentID, Regional_Name), Integer)
    End Function
    Public Overrides Function CMS_RegionalTP_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Get_By_Name", Regional_Name), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Get_By_Code(PortalConnect As String, code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Get_By_Code", code), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Get", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_List_Parent_Null(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_List_Parent_Null"), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTP_Parent_Search_ID_Deleted", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTP_Add(PortalConnect As String, obj As CMS_RegionalTPInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalTP_Add", obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_RegionalTP_Update(PortalConnect As String, obj As CMS_RegionalTPInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTP_Update", obj.Regional_ID, obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_RegionalTP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTP_Update_Delete", regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Overrides Sub CMS_RegionalTP_Delete(PortalConnect As String, regional_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTP_Delete", regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalQH"
    Public Overrides Sub CMS_RegionalQH_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalQH_Backup_Add", maTinh, yearID)
    End Sub
    Public Overrides Function CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Backup_Get", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalQH_Get_Name_Parent", parentID, Regional_Name), Integer)
    End Function
    Public Overrides Function CMS_RegionalQH_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Get_By_Name", Regional_Name), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Get_By_Code(PortalConnect As String, code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Get_By_Code", code), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Get", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Parent_Search_ID_Deleted", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalQH_Get_By_CMS_RegionalTP", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalQH_Add(PortalConnect As String, obj As CMS_RegionalQHInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalQH_Add", obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_RegionalQH_Update(PortalConnect As String, obj As CMS_RegionalQHInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalQH_Update", obj.Regional_ID, obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_RegionalQH_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalQH_Update_Delete", regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Overrides Sub CMS_RegionalQH_Delete(PortalConnect As String, regional_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalQH_Delete", regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalXP"
    Public Overrides Sub CMS_RegionalXP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalXP_Backup_Add", maTinh, yearID)
    End Sub
    Public Overrides Function CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Backup_Get", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalXP_Get_Name_Parent", parentID, Regional_Name), Integer)
    End Function
    Public Overrides Function CMS_RegionalXP_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Get_By_Name", Regional_Name), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Get_By_Code(PortalConnect As String, code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Get_By_Code", code), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Get", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Parent_Search_ID_Deleted", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalXP_Get_By_CMS_RegionalQH", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalXP_Add(PortalConnect As String, obj As CMS_RegionalXPInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalXP_Add", obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.MaTinh), Integer)
    End Function
    Public Overrides Sub CMS_RegionalXP_Update(PortalConnect As String, obj As CMS_RegionalXPInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalXP_Update", obj.Regional_ID, obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.MaTinh)
    End Sub
    Public Overrides Sub CMS_RegionalXP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalXP_Update_Delete", regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Overrides Sub CMS_RegionalXP_Delete(PortalConnect As String, regional_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalXP_Delete", regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalTO"
    Public Overrides Sub CMS_RegionalTO_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTO_Backup_Add", maTinh, yearID)
    End Sub
    Public Overrides Function CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Backup_Get", regional_ID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalTO_Get_Name_Parent", parentID, Regional_Name), Integer)
    End Function
    Public Overrides Function CMS_RegionalTO_Get_By_Name(PortalConnect As String, Regional_Name As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Get_By_Name", Regional_Name), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Get_By_Code(PortalConnect As String, code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Get_By_Code", code), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Get(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Get", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_List_ByTinhHuyenXa(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, maThon As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_List_ByTinhHuyenXa", maTinh, maHuyen, maXa, maThon), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Parent_Search_ID", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Parent_Search_ID_Deleted", search, isOrder, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_RegionalTO_Get_By_CMS_RegionalXP", regional_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegionalTO_Add(PortalConnect As String, obj As CMS_RegionalTOInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_RegionalTO_Add", obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.MaTinh, obj.MaHuyen), Integer)
    End Function
    Public Overrides Sub CMS_RegionalTO_Update(PortalConnect As String, obj As CMS_RegionalTOInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTO_Update", obj.Regional_ID, obj.Regional_Code, obj.Regional_Name, obj.Regional_Des, obj.AreaID, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsActive, obj.IsOrder, obj.MaTinh, obj.MaHuyen)
    End Sub
    Public Overrides Sub CMS_RegionalTO_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTO_Update_Delete", regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Overrides Sub CMS_RegionalTO_Delete(PortalConnect As String, regional_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_RegionalTO_Delete", regional_ID)
    End Sub
#End Region
#Region "CMS_DanhMucChung"
    Public Overrides Function CMS_DanhMuc_List(portalId As Integer, tenDanhMuc As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, tenDanhMuc & "_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DanhMuc_Get(portalId As Integer, tenDanhMuc As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, tenDanhMuc & "_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_DanhMuc_List_Search(PortalConnect As String, tenDanhMuc As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, tenDanhMuc & "_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_DanhMuc_Add(PortalConnect As String, tenDanhMuc As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, tenDanhMuc & "_Add", method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_DanhMuc_Update(PortalConnect As String, tenDanhMuc As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, tenDanhMuc & "_Update", method_ID, method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_DanhMuc_Delete(PortalConnect As String, tenDanhMuc As String, method_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, tenDanhMuc & "_Delete", method_ID)
    End Sub

#End Region
#Region "CMS_TypeEco"
    Public Overrides Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_Get", typeEco_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_TypeEco_Add(PortalConnect As String, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_TypeEco_Add", typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_TypeEco_Update(PortalConnect As String, typeEco_ID As Integer, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Update", typeEco_ID, typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Delete", typeEco_ID)
    End Sub
    Public Overrides Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Update_Quick", typeEco_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Method"
    Public Overrides Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_Get", method_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Method_Add(PortalConnect As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Method_Add", method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Method_Update(PortalConnect As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Update", method_ID, method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Delete", method_ID)
    End Sub
    Public Overrides Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Update_Quick", method_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMSUserExtra"
    Public Overrides Function CMSUserExtra_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserExtra_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMSUserExtra_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserExtra_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMSUserExtra_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserExtra_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMSUserExtra_Add(PortalConnect As String, obj As CMSUserExtraInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DnnSqlServer, "CMSUserExtra_Add", obj.UserName, obj.NganhDaoTao, obj.NganhDaoTaoKhac, obj.TrinhDoKhac1, obj.TrinhDoKhac2, obj.KyNangNghe, obj.KyNangNgheBac, obj.NgoaiNgu1, obj.NgoaiNgu1ChungChi, obj.NgoaiNgu2, obj.NgoaiNgu2ChungChi, obj.TrinhDoTinHoc, obj.TrinhDoTinHocKhac, obj.KinhNghiem, obj.KyNangMem, obj.KyNangMemKhac, obj.PortalID, obj.NganHang, obj.BHXH, obj.DanToc, obj.TonGiao, obj.Address2, obj.ProvinID2, obj.DistrictID2, obj.WardID2, obj.UniqueId, obj.LevelId, obj.TrinhDoChuyenMon, obj.TrinhDoChuyenMonKhac, obj.NgoaiNgu1KN, obj.NgoaiNgu2KN, obj.TrinhDoTinHocKN, obj.TrinhDoTinHocKhacKN, obj.DaLamViecNN, obj.LienHeKhac, obj.DTUuTien, obj.DTUuTienKhac, obj.DKDichVu, obj.DKDichVuKhac, obj.NhuCauLamViec), Integer)
    End Function
    Public Overrides Sub CMSUserExtra_Update(PortalConnect As String, obj As CMSUserExtraInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSUserExtra_Update", obj.ID, obj.UserName, obj.NganhDaoTao, obj.NganhDaoTaoKhac, obj.TrinhDoKhac1, obj.TrinhDoKhac2, obj.KyNangNghe, obj.KyNangNgheBac, obj.NgoaiNgu1, obj.NgoaiNgu1ChungChi, obj.NgoaiNgu2, obj.NgoaiNgu2ChungChi, obj.TrinhDoTinHoc, obj.TrinhDoTinHocKhac, obj.KinhNghiem, obj.KyNangMem, obj.KyNangMemKhac, obj.PortalID, obj.NganHang, obj.BHXH, obj.DanToc, obj.TonGiao, obj.Address2, obj.ProvinID2, obj.DistrictID2, obj.WardID2, obj.UniqueId, obj.LevelId, obj.TrinhDoChuyenMon, obj.TrinhDoChuyenMonKhac, obj.NgoaiNgu1KN, obj.NgoaiNgu2KN, obj.TrinhDoTinHocKN, obj.TrinhDoTinHocKhacKN, obj.DaLamViecNN, obj.LienHeKhac, obj.DTUuTien, obj.DTUuTienKhac, obj.DKDichVu, obj.DKDichVuKhac, obj.NhuCauLamViec)
    End Sub
    Public Overrides Sub CMSUserExtra_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DnnSqlServer, "CMSUserExtra_Delete", iD)
    End Sub
    Public Overrides Function CMSUserExtra_Get_By_User(PortalConnect As String, userName As String, PortalID As Integer) As IDataReader
        If PortalConnect <> "" Then
            Return CType(SqlHelper.ExecuteReader(PortalConnect, "CMSUserExtra_Get_By_User", userName, PortalID), IDataReader)
        Else
            Return CType(SqlHelper.ExecuteReader(flConnect.DnnSqlServer, "CMSUserExtra_Get_By_User", userName, PortalID), IDataReader)
        End If
    End Function
#End Region

#Region "CMS_KhuCongNghiep"
    Public Overrides Function CMS_KhuCongNghiep_Get(PortalConnect As String, industrialZone_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_KhuCongNghiep_Get", industrialZone_ID), IDataReader)
    End Function
    Public Overrides Function CMS_KhuCongNghiep_List(PortalConnect As String, parentId As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_KhuCongNghiep_List", parentId), IDataReader)
    End Function
    Public Overrides Function CMS_KhuCongNghiep_List_ByTP(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, parentId As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_KhuCongNghiep_List_ByTP", tinhTP, quanHuyen, parentId), IDataReader)
    End Function
    Public Overrides Function CMS_KhuCongNghiep_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_KhuCongNghiep_List_Search", search, isOrder, parent_ID, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Sub CMS_KhuCongNghiep_Add(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_KhuCongNghiep_Add", industrialZone_ID, tinhTP, quanHuyen, industrialZone_Name, industrialZone_Code, industrialZone_Des, flReg.GetNull(parent_ID), isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_KhuCongNghiep_Update(PortalConnect As String, industrialZone_ID As String, tinhTP As Integer, quanHuyen As Integer, industrialZone_Name As String, industrialZone_Code As String, industrialZone_Des As String, parent_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_KhuCongNghiep_Update", industrialZone_ID, tinhTP, quanHuyen, industrialZone_Name, industrialZone_Code, industrialZone_Des, flReg.GetNull(parent_ID), isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_KhuCongNghiep_Delete(PortalConnect As String, industrialZone_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_KhuCongNghiep_Delete", industrialZone_ID)
    End Sub
    Public Overrides Sub CMS_KhuCongNghiep_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_KhuCongNghiep_Update_Quick", industrialZone_ID, isActive, isOrder)
    End Sub
#End Region

End Class