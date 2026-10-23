Imports DotNetNuke.Common.Utilities
Imports System.Net.Mail
Imports DotNetNuke.Entities.Host
Imports System.Net.Mime
Imports System.Net
Imports DotNetNuke.Entities.Controllers
Imports DotNetNuke.Entities.Portals
Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.Entities.Users.Membership
Imports DotNetNuke.Entities.Users
Imports System.IO
Imports Microsoft.SqlServer

Public Class flDnn
    Shared arrTemp As New ArrayList
    Shared Str(), str1() As String

#Region "Common"

    Public Shared Function ExecuteReader(ByVal connectString As String, ByVal procname As String, ParamArray params() As Object) As SqlClient.SqlDataReader
        Return EPORTALHelper.ExecuteReader(connectString, procname, params)
    End Function
    Public Shared Function ExecuteDataset(ByVal connectString As String, ByVal procname As String, ParamArray params() As Object) As DataSet
        Return EPORTALHelper.ExecuteDataset(connectString, procname, params)
    End Function
    Public Shared Function ExecuteNonQuery(ByVal connectString As String, ByVal procname As String, ParamArray params() As Object) As Integer
        Return EPORTALHelper.ExecuteNonQuery(connectString, procname, params)
    End Function
    Public Shared Function ExecuteScalar(ByVal connectString As String, ByVal procname As String, ParamArray params() As Object) As Object
        Return EPORTALHelper.ExecuteScalar(connectString, procname, params)
    End Function

    Public Shared Function ExecuteSQLText(ByVal connectString As String, ByVal sql As String) As DataSet
        Return EPORTALHelper.ExecuteSQLText(connectString, sql)
    End Function

    Public Shared Function ExecuteNonQueryWithTimeout(ByVal connectString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As Integer
        Return EPORTALHelper.ExecuteNonQueryWithTimeout(connectString, procname, timeout, params)
    End Function
    Public Shared Function ExecuteScalarWithTimeout(ByVal connectString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As Object
        Return EPORTALHelper.ExecuteScalarWithTimeout(connectString, procname, timeout, params)
    End Function
    Public Shared Function ExecuteDatasetWithTimeout(ByVal connectString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As DataSet
        Return EPORTALHelper.ExecuteDatasetWithTimeout(connectString, procname, timeout, params)
    End Function
    Public Shared Function ExecuteDatasetConnect(ByVal connect As String, ByVal procname As String, ParamArray params() As Object) As DataSet
        Return EPORTALHelper.ExecuteDataset(connect, procname, params)
    End Function
#End Region
#Region "CMSCache"
    Public Shared Function CMSCache_Get_IP(PortalConnect As String, iP As String, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSCache_Get_IP(PortalConnect, iP, PortalID), GetType(CMSCacheInfo))
    End Function
    Public Shared Function CMSCache_Add(PortalConnect As String, CacheName As String, iP As String, PortalID As Integer) As Integer
        Return DataProvider.Instance().CMSCache_Add(PortalConnect, CacheName, iP, PortalID)
    End Function
#End Region
#Region "DNN"
    Public Shared Function DNN_User_Check_Delete(portalid As Integer, UserName As String) As Boolean
        Return DataProvider.Instance.DNN_User_Check_Delete(portalid, UserName)
    End Function
    Public Shared Sub DNN_Resquest_Change_Password(PortalConnect As String, UserId As Integer, isChange As Boolean)
        DataProvider.Instance().DNN_Resquest_Change_Password(PortalConnect, UserId, isChange)
    End Sub
    Public Shared Function DNN_User_Get_Telephone(PortalId As String, userName As String) As String
        Return DataProvider.Instance.DNN_User_Get_Telephone(PortalId, userName)
    End Function
    Public Shared Function DNN_User_Get_Property(PortalId As String, userName As String, proName As String) As String
        Return DataProvider.Instance.DNN_User_Get_Property(PortalId, userName, proName)
    End Function
    Public Shared Function DNN_UserConfig_List_By_Index(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, subMod As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_Index(PortalId, ProvinID, DistrictID, subMod), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_UserConfig_List_By_Index_Role(PortalId As Integer, ProvinID As Integer, DistrictID As Integer, WardID As Integer, subMod As String, RoleID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_Index_Role(PortalId, ProvinID, DistrictID, WardID, subMod, RoleID), GetType(DnnInfo))
    End Function
    Public Shared Sub DNN_Tabs_UpdateSkin(PortalConnect As String, TabID As Integer, SkinSrc As String)
        DataProvider.Instance().DNN_Tabs_UpdateSkin(PortalConnect, TabID, SkinSrc)
    End Sub
    Public Shared Function DNN_Users_List_BirthDay(PortalId As Integer, PropertyName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_Users_List_BirthDay(PortalId, PropertyName), GetType(DnnInfo))
    End Function
    Public Shared Function AddTab(PortalConnect As String, obj As DotNetNuke.Entities.Tabs.TabInfo) As Integer
        Return DataProvider.Instance().AddTab(PortalConnect, obj.ContentItemId, obj.PortalID, obj.TabOrder, obj.UniqueId, obj.VersionGuid, obj.DefaultLanguageGuid, obj.LocalizedVersionGuid, obj.TabName, obj.IsVisible, obj.DisableLink, obj.ParentId, obj.IconFile, obj.IconFileLarge, obj.Title, obj.Description, obj.KeyWords, obj.Url, obj.SkinSrc, obj.ContainerSrc, obj.StartDate, obj.EndDate, obj.RefreshInterval, obj.PageHeadText, obj.IsSecure, obj.PermanentRedirect, obj.SiteMapPriority, obj.CreatedByUserID, obj.CultureCode, obj.IsSystem)
    End Function
    Public Shared Sub DeleteTabPermissionsByTabID(PortalConnect As String, tabid As Integer)
        DataProvider.Instance().DeleteTabPermissionsByTabID(PortalConnect, tabid)
    End Sub
    Public Shared Function DNN_ContentItems_Add(PortalConnect As String, content As String) As Integer
        Return DataProvider.Instance().DNN_ContentItems_Add(PortalConnect, content)
    End Function
    Public Shared Sub DNN_ContentItems_Update_Tabid(PortalConnect As String, contentItemID As Integer, tabID As Integer)
        DataProvider.Instance().DNN_ContentItems_Update_Tabid(PortalConnect, contentItemID, tabID)
    End Sub
    Public Shared Sub DNN_Update_TabName_Set_ID(PortalConnect As String, TabID As Integer, TabName As String, PortalID As Integer)
        DataProvider.Instance().DNN_Update_TabName_Set_ID(PortalConnect, TabID, TabName, PortalID)
    End Sub
    Public Shared Sub DNN_TabHasBeenPublished(PortalConnect As String, tabID As Integer)
        DataProvider.Instance().DNN_TabHasBeenPublished(PortalConnect, tabID)
    End Sub
    Public Shared Function AddTabPermission(PortalConnect As String, obj As DotNetNuke.Security.Permissions.TabPermissionInfo) As Integer
        Return DataProvider.Instance().AddTabPermission(PortalConnect, obj.TabID, obj.PermissionID, obj.RoleID, obj.AllowAccess, obj.UserID, obj.CreatedByUserID)
    End Function
    Public Shared Function DNN_GetDesktopModulesID(PortalConnect As String, FriendlyName As String) As Integer
        Return DataProvider.Instance().DNN_GetDesktopModulesID(PortalConnect, FriendlyName)
    End Function
    Public Shared Function DNN_SendMail(ByVal toMail As String, subject As String,
                                        ByVal Body As String,
                                        Optional ByVal fileAttach As String = "",
                                        Optional ByVal fileName As String = "",
                                        Optional ByVal Port As Integer = 587,
                                        Optional ByVal fromMail As String = "default",
                                        Optional ByVal ccMail As String = "",
                                        Optional ByVal bccMail As String = "") As Boolean
        Try
            Dim message As New MailMessage
            message.From = New MailAddress(IIf(fromMail = "default", Host.SMTPUsername, fromMail))
            message.To.Add(toMail)
            If ccMail <> "" Then message.CC.Add(ccMail)
            If bccMail <> "" Then message.Bcc.Add(bccMail)
            message.Subject = subject
            Str = fileAttach.Split(";") : str1 = fileName.Split(";")
            For i As Integer = 0 To Str.Length - 1
                If Str(i) & "" <> "" Then
                    Dim Data As Attachment = New Attachment(Str(i), MediaTypeNames.Application.Octet)
                    Dim disposition As ContentDisposition = Data.ContentDisposition
                    disposition.CreationDate = System.IO.File.GetCreationTime(Str(i))
                    disposition.ModificationDate = System.IO.File.GetLastWriteTime(Str(i))
                    disposition.ReadDate = System.IO.File.GetLastAccessTime(Str(i))
                    disposition.FileName = str1(i)
                    message.Attachments.Add(Data)
                End If
            Next
            message.IsBodyHtml = True
            message.Body = Body
            Dim smtpClient As New SmtpClient
            smtpClient.Host = Host.SMTPServer
            smtpClient.Port = Port
            smtpClient.EnableSsl = True

            smtpClient.Credentials = New NetworkCredential(Host.SMTPUsername, HostController.Instance.GetEncryptedString("SMTPPassword", Config.GetDecryptionkey()))
            smtpClient.Send(message)
            message.Attachments.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function DNN_User_List_By_Role(portalid As Integer, RoleName As String, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.DNN_User_List_By_Role(portalid, RoleName, UserName), GetType(DnnInfo))
    End Function
    Public Shared Function RPT_User_List_By_Role(portalid As Integer, RoleName As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.RPT_User_List_By_Role(portalid, RoleName, FromDate, ToDate), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Portal_List_Lang(ByVal LanguageId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.DNN_Portal_List_Lang(LanguageId), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Tabs_Get_By_ParentID(PortalConnect As String, ParentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_Tabs_Get_By_ParentID(PortalConnect, ParentId), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Tabs_Get_Parent_IsNull(PortalConnect As String, PortalID As Integer, Optional ByVal cms As Boolean = False, Optional ByVal tabname As String = "") As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_Tabs_Get_Parent_IsNull(PortalConnect, PortalID, cms, tabname), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Portal_Get_By_UserID(PortalId As Integer, UserId As String) As DnnInfo
        Return CBO.FillObject(Of DnnInfo)(DataProvider.Instance().DNN_User_Get_By_ID(PortalId, UserId))
    End Function
    Public Shared Function DNN_Portal_Get_By_ID(PortalId As Integer) As DnnInfo
        Return CBO.FillObject(Of DnnInfo)(DataProvider.Instance().DNN_Portal_Get_By_ID(PortalId))
    End Function
    Public Shared Function DNN_User_Get_By_ID(PortalId As Integer, UserId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_User_Get_By_ID(PortalId, UserId), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Portal_Get_By_UserID(ByVal UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.DNN_Portal_Get_By_UserID(UserName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_GetPortalLocalizations_PortalIDExt(ByVal portalID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.DNN_GetPortalLocalizations_PortalIDExt(portalID), GetType(DnnInfo))
    End Function
    Private Shared Function DNN_TabModuleSettings_Get_Values(PortalConnect As String, PortalId As Integer, TabModuleID As String, SettingName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_TabModuleSettings_Get_Value(PortalConnect, PortalId, TabModuleID, SettingName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_TabModuleSettings_Get_Value(PortalConnect As String, PortalId As Integer, TabModuleID As String, SettingName As String) As String
        arrTemp = DNN_TabModuleSettings_Get_Values(PortalConnect, PortalId, TabModuleID, SettingName)
        For Each Ci As DnnInfo In arrTemp
            Return Ci.SettingValue
        Next
        Return ""
    End Function
    Public Shared Function DNN_TabModuleSettings_Get_Value_Module(ByVal TabModuleID As String, ModuleTitle As String) As String
        arrTemp = DNN_TabModuleSettings_Get_Value_Modules(TabModuleID, ModuleTitle)
        For Each Ci As DnnInfo In arrTemp
            Return Ci.SettingValue
        Next
        Return ""
    End Function
    Private Shared Function DNN_TabModuleSettings_Get_Value_Modules(ByVal TabModuleID As String, ModuleTitle As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_TabModuleSettings_Get_Value_Module(TabModuleID, ModuleTitle), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_TabModuleSettings_Get_ModuleTitle(PortalId As Integer, ModuleTitle As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_TabModuleSettings_Get_ModuleTitle(PortalId, ModuleTitle), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_TabModuleSettings_Get_Control(PortalConnect As String, PortalId As Integer, Control As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_TabModuleSettings_Get_Control(PortalConnect, PortalId, Control), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_GetDesktopModules_By_FriendlyName(ByVal FriendlyName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_GetDesktopModules_By_FriendlyName(FriendlyName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_PortalID_Get_By_ParentID(ByVal ParentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_PortalID_Get_By_ParentID(ParentId), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_UserConfig_List_By_Roles(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, rolesID As String, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_Roles(PortalId, subMod, Search, currPage, recodperpage, rolesID, isOrder), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_UserConfig_List_By_Search(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_Search(PortalId, subMod, Search, currPage, recodperpage, roleID, tinhTP, quanHuyen, xaPhuong), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_UserConfig_List_By_Category(PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_Category(PortalId), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_PortalID_Get_Parent_IsNull(PortalId As Integer, IsCMS As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_PortalID_Get_Parent_IsNull(PortalId, IsCMS), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_User_Get(PortalId As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_User_Get(PortalId, UserName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_User_Get_UserName(PortalId As Integer, UserName As String) As DnnInfo
        Return CBO.FillObject(Of DnnInfo)(DataProvider.Instance().DNN_User_Get(PortalId, UserName))
    End Function
    Public Shared Function DNN_User_Get_Email(email As String) As DnnInfo
        Return CBO.FillObject(Of DnnInfo)(DataProvider.Instance().DNN_User_Get_Email(email))
    End Function
    Public Shared Function DNN_User_GetAll(ByVal portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_User_GetAll(portalID, IsDeleted, IsSuperUser, currPage, recodperpage), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_User_List_Search(ByVal portalID As Integer, IsDeleted As Boolean, IsSuperUser As Boolean, IsOrder As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_User_List_Search(portalID, IsDeleted, IsSuperUser, IsOrder, search, currPage, recodperpage), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_User_List_By_UserName(PortalId As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_User_List_By_UserName(PortalId, UserName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Files_Get_By_FileName(PortalId As Integer, FileName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_Files_Get_By_FileName(PortalId, FileName), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_Files_Get_By_FileID(ByVal FileID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_Files_Get_By_FileID(FileID), GetType(DnnInfo))
    End Function
    Public Shared Sub DNN_AddRestPassWord(RestPassWordId As String, PortalID As String, Username As String, Email As String, EndDate As String)
        DataProvider.Instance().DNN_AddRestPassWord(RestPassWordId, PortalID, Username, Email, EndDate)
    End Sub
    Public Shared Function DNN_GetRestPassWord(ByVal RestPassWordId As String, IsLang As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_GetRestPassWord(RestPassWordId, IsLang), GetType(DnnInfo))
    End Function
    Public Shared Sub DNN_Update_TabName(PortalConnect As String, TabID As Integer, TabName As String, TabTitle As String, Description As String, ParentID As Integer, TabPath As String, PortalID As Integer)
        DataProvider.Instance().DNN_Update_TabName(PortalConnect, TabID, TabName, TabTitle, Description, ParentID, TabPath, PortalID)
    End Sub
    Public Shared Sub DNN_Update_TabName_Set_ID(TabID As Integer, TabName As String, PortalID As Integer)
        DataProvider.Instance().DNN_Update_TabName_Set_ID(TabID, TabName, PortalID)
    End Sub
    Public Shared Sub DNN_Tabs_Delete(PortalConnect As String, PortalId As Integer, TabID As Integer)
        DataProvider.Instance().DNN_Tabs_Delete(PortalConnect, PortalId, TabID)
    End Sub
    Public Shared Sub DNN_TabModuleSettings_Add(PortalConnect As String, portalid As Integer, TabModuleID As Integer, SettingName As String, SettingValue As String, CreatedByUserID As Integer, CreatedOnDate As DateTime, LastModifiedByUserID As Integer, LastModifiedOnDate As DateTime)
        DataProvider.Instance().DNN_TabModuleSettings_Add(PortalConnect, portalid, TabModuleID, SettingName, SettingValue, CreatedByUserID, CreatedOnDate, LastModifiedByUserID, LastModifiedOnDate)
    End Sub
    Public Shared Sub DNN_UpdateRestPassWord(ByVal RestPassWordId As String)
        DataProvider.Instance().DNN_UpdateRestPassWord(RestPassWordId)
    End Sub
    Public Shared Function DNN_CountMessage(ByVal userID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_CountMessage(userID), GetType(DnnInfo))
    End Function
    Public Shared Function DNN_LogHistory(ByVal userID As Integer, currPage As String, recodperpage As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_LogHistory(userID, currPage, recodperpage), GetType(EventLogInfo))
    End Function
    Public Shared Sub DNN_User_Lock(UserID As Integer, IsDelete As Boolean, PortalId As Integer)
        DataProvider.Instance().DNN_User_Lock(UserID, IsDelete, PortalId)
    End Sub
    Public Shared Sub DNN_User_DeleteLock(UserID As Integer, IsDelete As Boolean, PortalId As Integer)
        DataProvider.Instance().DNN_User_DeleteLock(UserID, IsDelete, PortalId)
    End Sub
    Public Shared Function GetTabName(tabid As Integer, portalid As Integer) As String
        Return DataProvider.Instance.DNN_Tabs_Get(tabid, portalid)
    End Function
    Public Shared Function GetTabPath(PortalConnect As String, tabid As Integer, portalid As Integer) As String
        Return DataProvider.Instance.DNN_Tabs_List_TabPath(PortalConnect, tabid, portalid)
    End Function
    Public Shared Function DNN_Tabs_Get_TabPath(PortalConnect As String, TabPath As String, portalid As Integer) As Integer
        Return DataProvider.Instance.DNN_Tabs_Get_TabPath(PortalConnect, TabPath, portalid)
    End Function
    Public Shared Function DNN_UserConfig_List_By_SearchBanBe(PortalId As Integer, subMod As String, Search As String, currPage As Integer, recodperpage As Integer, roleID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DNN_UserConfig_List_By_SearchBanBe(PortalId, subMod, Search, currPage, recodperpage, roleID, tinhTP, quanHuyen, xaPhuong, userName), GetType(DnnInfo))
    End Function
#End Region
#Region "CMS_Module"
    Public Shared Function CMS_Module_List_Menu_Top(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Menu_Top(PortalConnect, subMod, VaiTro, Parent_ID, flReg.ProvinND(0, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_List_Menu(PortalConnect As String, subMod As String, VaiTro As String) As ArrayList
        If VaiTro = "-10" Then 'member pages site
            Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Menu(PortalConnect, subMod, VaiTro, flReg.WebConfig("TinhTP")), GetType(CMS_ModuleInfo))
        Else
            Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Menu(PortalConnect, subMod, VaiTro, flReg.ProvinND(0, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)), GetType(CMS_ModuleInfo))
        End If
    End Function
    Public Shared Function CMS_Module_List_Security(PortalConnect As String, subMod As String, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Security(PortalConnect, subMod, UserName), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_Get(PortalConnect As String, subMod As String, module_Src As String) As CMS_ModuleInfo
        Return CBO.FillObject(Of CMS_ModuleInfo)(DataProvider.Instance().CMS_Module_Get(PortalConnect, subMod, module_Src))
    End Function
    Public Shared Function CMS_Module_List_By_User(PortalConnect As String, subMod As String, VaiTro As String, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_By_User(PortalConnect, subMod, VaiTro, Parent_ID, flReg.ProvinND(0, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_List_By_Admin(PortalConnect As String, subMod As String, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_By_Admin(PortalConnect, subMod, Parent_ID), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_List_By_Host(PortalConnect As String, subMod As String, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_By_Host(PortalConnect, subMod, Parent_ID), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_List_Parent(PortalConnect As String, subMod As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Parent(PortalConnect, subMod), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_List(PortalConnect As String, subMod As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List(PortalConnect, subMod), GetType(CMS_ModuleInfo))
    End Function
    Public Shared Function CMS_Module_Get_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As CMS_ModuleInfo
        Return CBO.FillObject(Of CMS_ModuleInfo)(DataProvider.Instance().CMS_Module_Get_Parent_ID(PortalConnect, subMod, Parent_ID))
    End Function
    Public Shared Function CMS_Module_List_Parent_ID(PortalConnect As String, subMod As String, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Module_List_Parent_ID(PortalConnect, subMod, Parent_ID), GetType(CMS_ModuleInfo))
    End Function
#End Region
#Region "CMS_Settings"
    Public Shared Function CMS_Settings_Get_Value(ByVal PortalConnect As String, SubMod As String, setting_Key As String, setting_Page As String) As CMS_SettingsInfo
        Return CBO.FillObject(Of CMS_SettingsInfo)(DataProvider.Instance().CMS_Settings_Get_Value(PortalConnect, SubMod, setting_Key, setting_Page))
    End Function
    Public Shared Sub CMS_Settings_Update(ByVal PortalConnect As String, SubMod As String, setting_Key As String, Setting_Value As String, setting_Page As String, UserName As String)
        flCache.RemoveCache(setting_Key & "_" & SubMod & "_" & setting_Page)
        DataProvider.Instance().CMS_Settings_Update(PortalConnect, flReg.GenKey(), SubMod, setting_Key, Setting_Value, setting_Page, Now, UserName, Now, UserName)
    End Sub

#End Region
#Region "CMS_UserConfig"
    Public Shared Sub CMS_UserConfig_Delete_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, TinhTP As Integer)
        DataProvider.Instance().CMS_UserConfig_Delete_By_ModuleSrc(PortalConnect, subMod, UserName, ModuleSrc, TinhTP)
    End Sub
    Public Shared Function CMS_UserConfig_Get_By_UserName(PortalConnect As String, subMod As String, UserName As String) As CMS_UserConfigInfo
        Return CBO.FillObject(Of CMS_UserConfigInfo)(DataProvider.Instance().CMS_UserConfig_Get_By_UserName(PortalConnect, subMod, UserName, flReg.WriteNumber(flReg.WebConfig("TinhTP"))))
    End Function
    Public Shared Function CMS_UserConfig_Get_By_UserName_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String) As CMS_UserConfigInfo
        Return CBO.FillObject(Of CMS_UserConfigInfo)(DataProvider.Instance().CMS_UserConfig_Get_By_UserName_ModuleSrc(PortalConnect, subMod, UserName, ModuleSrc, flReg.WriteNumber(flReg.WebConfig("TinhTP"))))
    End Function
    Public Shared Function CMS_UserConfig_Get_By_ModuleSrc(PortalConnect As String, subMod As String, UserName As String, ModuleSrc As String, tinhTP As String) As CMS_UserConfigInfo
        Return CBO.FillObject(Of CMS_UserConfigInfo)(DataProvider.Instance().CMS_UserConfig_Get_By_ModuleSrc(PortalConnect, subMod, UserName, ModuleSrc, tinhTP))
    End Function
    Public Shared Function CMS_UserConfig_Get(PortalConnect As String, userConfig_ID As Integer) As CMS_UserConfigInfo
        Return CBO.FillObject(Of CMS_UserConfigInfo)(DataProvider.Instance().CMS_UserConfig_Get(PortalConnect, userConfig_ID))
    End Function
    Public Shared Function CMS_UserConfig_List(PortalConnect As String, subMod As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UserConfig_List(PortalConnect, subMod, portalId, flReg.WriteNumber(flReg.WebConfig("TinhTP"))), GetType(CMS_UserConfigInfo))
    End Function
    Public Shared Sub CMS_UserConfig_Add(PortalConnect As String, obj As CMS_UserConfigInfo)
        DataProvider.Instance().CMS_UserConfig_Add(PortalConnect, obj.SubMod, obj.UserName, obj.ModuleSrc, obj.PortalID, obj.TinhTP)
    End Sub
    Public Shared Sub CMS_UserConfig_Update(PortalConnect As String, obj As CMS_UserConfigInfo)
        DataProvider.Instance().CMS_UserConfig_Update(PortalConnect, obj.SubMod, obj.UserConfig_ID, obj.UserName, obj.ModuleSrc, obj.PortalID, obj.TinhTP)
    End Sub
    Public Shared Sub CMS_UserConfig_Delete(PortalConnect As String, userConfig_ID As Integer)
        DataProvider.Instance().CMS_UserConfig_Delete(PortalConnect, userConfig_ID)
    End Sub

#End Region
#Region "NextPage"
    Public Shared Function DNN_NextPageJs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
        Return DataProvider.Instance().DNN_NextPageJs(intTotal, recodperPage, currPage, Pagesize, functions)
    End Function
    Public Shared Function DNN_NextPageVs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
        Return DataProvider.Instance().DNN_NextPageVs(intTotal, recodperPage, currPage, Pagesize, functions)
    End Function
    Public Shared Function DNN_NextPage(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, hrefPage As String) As String
        Return DataProvider.Instance().DNN_NextPage(intTotal, recodperPage, currPage, Pagesize, hrefPage)
    End Function
#End Region
#Region "CMS_Roles"
    Public Shared Function CMS_Roles_Get(PortalConnect As String, roles_ID As Integer) As CMS_RolesInfo
        Return CBO.FillObject(Of CMS_RolesInfo)(DataProvider.Instance().CMS_Roles_Get(PortalConnect, roles_ID))
    End Function
    Public Shared Function CMS_Roles_Check_Code(PortalConnect As String, SubMod_ID As Integer, roles_ID As Integer, Roles_Code As String) As Integer
        Return DataProvider.Instance().CMS_Roles_Check_Code(PortalConnect, SubMod_ID, roles_ID, Roles_Code)
    End Function

    Public Shared Function CMS_Roles_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Roles_List(PortalConnect), GetType(CMS_RolesInfo))
    End Function
    Public Shared Function CMS_Roles_Get_By_CMS_SubMod(PortalConnect As String, subMod_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Roles_Get_By_CMS_SubMod(PortalConnect, subMod_ID), GetType(CMS_RolesInfo))
    End Function
    Public Shared Function CMS_Roles_Get_By_SubMod_Code(PortalConnect As String, subMod_ID As Integer, roleCode As String) As CMS_RolesInfo
        Return CBO.FillObject(Of CMS_RolesInfo)(DataProvider.Instance().CMS_Roles_Get_By_SubMod_Code(PortalConnect, subMod_ID, roleCode))
    End Function
    Public Shared Function CMS_Roles_List_Search(PortalConnect As String, search As String, SubMod_ID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Roles_List_Search(PortalConnect, search, SubMod_ID, currPage, recodperpage, UserName), GetType(CMS_RolesInfo))
    End Function

    Public Shared Function CMS_Roles_Add(PortalConnect As String, obj As CMS_RolesInfo) As Integer
        Return DataProvider.Instance().CMS_Roles_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Roles_Update(PortalConnect As String, obj As CMS_RolesInfo)
        DataProvider.Instance().CMS_Roles_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Roles_Delete(PortalConnect As String, roles_ID As Integer)
        DataProvider.Instance().CMS_Roles_Delete(PortalConnect, roles_ID)
    End Sub
#End Region
#Region "CMS_SubMod"
    Public Shared Function CMS_SubMod_Get_By_Path(PortalConnect As String, subMod_Path As String) As CMS_SubModInfo
        Return CBO.FillObject(Of CMS_SubModInfo)(DataProvider.Instance().CMS_SubMod_Get_By_Path(PortalConnect, subMod_Path))
    End Function
    Public Shared Function CMS_SubMod_Get(PortalConnect As String, subMod_ID As Integer) As CMS_SubModInfo
        Return CBO.FillObject(Of CMS_SubModInfo)(DataProvider.Instance().CMS_SubMod_Get(PortalConnect, subMod_ID))
    End Function
    Public Shared Function CMS_SubMod_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SubMod_List(PortalConnect), GetType(CMS_SubModInfo))
    End Function
    Public Shared Function CMS_SubMod_ListActive(PortalConnect As String, isActive As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SubMod_ListActive(PortalConnect, isActive), GetType(CMS_SubModInfo))
    End Function
    Public Shared Function CMS_SubMod_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SubMod_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SubModInfo))
    End Function

    Public Shared Function CMS_SubMod_Add(PortalConnect As String, obj As CMS_SubModInfo) As Integer
        Return DataProvider.Instance().CMS_SubMod_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_SubMod_Update(PortalConnect As String, obj As CMS_SubModInfo)
        DataProvider.Instance().CMS_SubMod_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_SubMod_Delete(PortalConnect As String, subMod_ID As Integer)
        DataProvider.Instance().CMS_SubMod_Delete(PortalConnect, subMod_ID)
    End Sub
#End Region
#Region "CMSCookie"
    Public Shared Function CMSCookie_Get_Token(ByVal idKey As String) As CMSCookieInfo
        Return CBO.FillObject(Of CMSCookieInfo)(DataProvider.Instance().CMSCookie_Get_Token(idKey))
    End Function
    Public Shared Function CMSCookie_Get(ByVal idKey As String) As CMSCookieInfo
        Return CBO.FillObject(Of CMSCookieInfo)(DataProvider.Instance().CMSCookie_Get(idKey))
    End Function
    Public Shared Function CMSCookie_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSCookie_List(), GetType(CMSCookieInfo))
    End Function
    Public Shared Sub CMSCookie_Add(ByVal obj As CMSCookieInfo)
        DataProvider.Instance().CMSCookie_Add(obj.IdKey, obj.IdValue, obj.UserName, obj.CrtVal, obj.CrtDate)
    End Sub
    Public Shared Sub CMSCookie_Update(ByVal obj As CMSCookieInfo)
        DataProvider.Instance().CMSCookie_Update(obj.IdKey, obj.IdValue)
    End Sub
    Public Shared Sub CMSCookie_Delete(ByVal idKey As String)
        DataProvider.Instance().CMSCookie_Delete(idKey)
    End Sub
#End Region
#Region "CMSConnection"
    Public Shared Function CMSInConn_Get_PortalID(PortalID As Integer) As String
        Return DataProvider.Instance().CMSInConn_Get_PortalID(PortalID)
    End Function
    Public Shared Function CMSConnection_Get(portalID As Integer) As CMSConnectionInfo
        Return CBO.FillObject(Of CMSConnectionInfo)(DataProvider.Instance().CMSConnection_Get(portalID))
    End Function
    Public Shared Function CMSConnection_List_By_PortalID(portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSConnection_List_By_PortalID(portalID), GetType(CMSConnectionInfo))
    End Function
    Public Shared Function CMSTpConn_Get_TinhTP(TinhTP As Integer, IdKey As String) As String
        Return DataProvider.Instance().CMSTpConn_Get_TinhTP(TinhTP, IdKey)
    End Function
    Public Shared Function CMSConn_Get_By_SqlCode(PortalID As Integer, sqlCode As String) As String
        Return DataProvider.Instance().CMSConn_Get_By_SqlCode(PortalID, sqlCode)
    End Function

#End Region
#Region "CMSUserPortal"
    Public Shared Function DNN_UserPortals_Add(ByVal PortalID As Integer, FromPortal As Integer, ToPortal As Integer, UserName As String) As String
        Return DataProvider.Instance.DNN_UserPortals_Add(PortalID, FromPortal, ToPortal, UserName)
    End Function
    Public Shared Function AddUserPortal(ByVal PortalID As Integer, UserID As Integer) As Integer
        Return DataProvider.Instance.AddUserPortal(PortalID, UserID)
    End Function
    Public Shared Sub DeleteUserPortal(ByVal UserID As Integer, PortalID As Integer)
        DataProvider.Instance.DeleteUserPortal(UserID, PortalID)
    End Sub
    Public Shared Function CMSUserPortal_List(ByVal userID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSUserPortal_List(userID), GetType(CMSUserPortalInfo))
    End Function
    Public Shared Function CMSUserPortal_List_User(portalConnect As String, subMod As String, PortalID As Integer, displayName As String, gender As Integer, levelID As String, needID As String, roleID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSUserPortal_List_User(portalConnect, subMod, PortalID, displayName, gender, levelID, needID, roleID, currPage, recodperpage), GetType(CMSUserPortalInfo))
    End Function
    Public Shared Function CMSUserPortal_Get_By_User(portalConnect As String, userName As String, subMod As String, PortalID As Integer) As CMSUserPortalInfo
        Return CBO.FillObject(Of CMSUserPortalInfo)(DataProvider.Instance().CMSUserPortal_Get_By_User(portalConnect, userName, subMod, PortalID))
    End Function
    Public Shared Function CMSUserPortal_Get_By_CCCD(portalConnect As String, CCCD As String) As CMSUserPortalInfo
        Return CBO.FillObject(Of CMSUserPortalInfo)(DataProvider.Instance().CMSUserPortal_Get_By_CCCD(portalConnect, CCCD))
    End Function
    Public Shared Function CMSUserPortal_Get_By_User(PortalConnect As String, userName As String, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSUserPortal_Get_By_User(PortalConnect, userName, "", PortalID), GetType(CMSUserPortalInfo))
    End Function
    Public Shared Function CMSUserPortal_Add(obj As CMSUserPortalInfo) As Integer
        Return DataProvider.Instance().CMSUserPortal_Add(obj)
    End Function
    Public Shared Sub CMSUserPortal_Delete(userName As String, subMod As String, PortalID As Integer)
        DataProvider.Instance().CMSUserPortal_Delete(userName, subMod, PortalID)
    End Sub
    Public Shared Sub CMSUserPortal_Add_Roles(PortalID As Integer, userName As String, subMod As String, rolesID As String)
        DataProvider.Instance().CMSUserPortal_Add_Roles(PortalID, userName, subMod, rolesID)
    End Sub
#End Region
#Region "CMS_Regional"
    Public Shared Function SV_Regional_Get_By_IdKey(PortalConnect As String, Regional_Code As String) As String
        Return DataProvider.Instance().SV_Regional_Get_By_IdKey(PortalConnect, Regional_Code)
    End Function
    Public Shared Function CMS_Regional_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return DataProvider.Instance().CMS_Regional_Get_Name_Parent(PortalConnect, parentID, Regional_Name)
    End Function
    Public Shared Function CMS_Regional_Get_By_Name(PortalConnect As String, Regional_Name As String) As CMS_RegionalInfo
        Return CBO.FillObject(Of CMS_RegionalInfo)(DataProvider.Instance().CMS_Regional_Get_By_Name(PortalConnect, Regional_Name))
    End Function
    Public Shared Function CMS_Regional_Get_By_Code(PortalConnect As String, code As String) As CMS_RegionalInfo
        Return CBO.FillObject(Of CMS_RegionalInfo)(DataProvider.Instance().CMS_Regional_Get_By_Code(PortalConnect, code))
    End Function
    Public Shared Function CMS_Regional_Get(PortalConnect As String, regional_ID As Integer) As CMS_RegionalInfo
        Return CBO.FillObject(Of CMS_RegionalInfo)(DataProvider.Instance().CMS_Regional_Get(PortalConnect, regional_ID))
    End Function
    Public Shared Function CMS_Regional_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_List(PortalConnect, portalId), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_Parent_Search_Null(PortalConnect, search, isOrder), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_Parent_Search_ID_Deleted(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_List_Parent_Null(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_List_Parent_Null(PortalConnect), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_Get_By_CMS_Regional(PortalConnect As String, regional_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Regional_Get_By_CMS_Regional(PortalConnect, regional_ID), GetType(CMS_RegionalInfo))
    End Function
    Public Shared Function CMS_Regional_Add(PortalConnect As String, obj As CMS_RegionalInfo) As Integer
        Return DataProvider.Instance().CMS_Regional_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Regional_Update(PortalConnect As String, obj As CMS_RegionalInfo)
        DataProvider.Instance().CMS_Regional_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Regional_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        DataProvider.Instance().CMS_Regional_Update_Delete(PortalConnect, regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Shared Sub CMS_Regional_Delete(PortalConnect As String, regional_ID As Integer)
        DataProvider.Instance().CMS_Regional_Delete(PortalConnect, regional_ID)
    End Sub
#End Region
#Region "CMS_Nation"
    Public Shared Function CMS_Nation_Get_By_Name(PortalConnect As String, Nation_Name As String) As CMS_NationInfo
        Return CBO.FillObject(Of CMS_NationInfo)(DataProvider.Instance().CMS_Nation_Get_By_Name(PortalConnect, Nation_Name))
    End Function
    Public Shared Function CMS_Nation_Get(PortalConnect As String, nation_ID As Integer) As CMS_NationInfo
        Return CBO.FillObject(Of CMS_NationInfo)(DataProvider.Instance().CMS_Nation_Get(PortalConnect, nation_ID))
    End Function
    Public Shared Function CMS_Nation_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Nation_List(PortalConnect), GetType(CMS_NationInfo))
    End Function
    Public Shared Function CMS_Nation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Nation_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_NationInfo))
    End Function
    Public Shared Function CMS_Nation_Add(PortalConnect As String, obj As CMS_NationInfo) As Integer
        Return DataProvider.Instance().CMS_Nation_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Nation_Update(PortalConnect As String, obj As CMS_NationInfo)
        DataProvider.Instance().CMS_Nation_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Nation_Delete(PortalConnect As String, nation_ID As Integer)
        DataProvider.Instance().CMS_Nation_Delete(PortalConnect, nation_ID)
    End Sub
#End Region
#Region "CMS_National"
    Public Shared Function CMS_National_Get(PortalConnect As String, national_ID As Integer) As CMS_NationalInfo
        Return CBO.FillObject(Of CMS_NationalInfo)(DataProvider.Instance().CMS_National_Get(PortalConnect, national_ID))
    End Function
    Public Shared Function CMS_National_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_National_List(PortalConnect), GetType(CMS_NationalInfo))
    End Function
    Public Shared Function CMS_National_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_National_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_NationalInfo))
    End Function
    Public Shared Function CMS_National_Add(PortalConnect As String, obj As CMS_NationalInfo) As Integer
        Return DataProvider.Instance().CMS_National_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_National_Update(PortalConnect As String, obj As CMS_NationalInfo)
        DataProvider.Instance().CMS_National_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_National_Delete(PortalConnect As String, national_ID As Integer)
        DataProvider.Instance().CMS_National_Delete(PortalConnect, national_ID)
    End Sub
#End Region
#Region "CMS_Position"
    Public Shared Function CMS_Position_Get_By_Name(PortalConnect As String, Position_Name As String) As CMS_PositionInfo
        Return CBO.FillObject(Of CMS_PositionInfo)(DataProvider.Instance().CMS_Position_Get_By_Name(PortalConnect, Position_Name))
    End Function
    Public Shared Function CMS_Position_Get(PortalConnect As String, position_ID As Integer) As CMS_PositionInfo
        Return CBO.FillObject(Of CMS_PositionInfo)(DataProvider.Instance().CMS_Position_Get(PortalConnect, position_ID))
    End Function
    Public Shared Function SV_Position_Get_By_IdKey(PortalConnect As String, position_Code As Integer) As String
        Return DataProvider.Instance().SV_Position_Get_By_IdKey(PortalConnect, position_Code)
    End Function
    Public Shared Function CMS_Position_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Position_List(PortalConnect), GetType(CMS_PositionInfo))
    End Function
    Public Shared Function CMS_Position_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Position_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PositionInfo))
    End Function

    Public Shared Function CMS_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer
        Return DataProvider.Instance().CMS_Position_Add(PortalConnect, obj)
    End Function
    Public Shared Function SV_Position_Add(PortalConnect As String, obj As CMS_PositionInfo) As Integer
        Return DataProvider.Instance().SV_Position_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Position_Update(PortalConnect As String, obj As CMS_PositionInfo)
        DataProvider.Instance().CMS_Position_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Position_Delete(PortalConnect As String, position_ID As Integer)
        DataProvider.Instance().CMS_Position_Delete(PortalConnect, position_ID)
    End Sub
#End Region
#Region "CMS_Religion"
    Public Shared Function CMS_Religion_Get_By_Name(PortalConnect As String, Religion_Name As String) As CMS_ReligionInfo
        Return CBO.FillObject(Of CMS_ReligionInfo)(DataProvider.Instance().CMS_Religion_Get_By_Name(PortalConnect, Religion_Name))
    End Function
    Public Shared Function CMS_Religion_Get(PortalConnect As String, religion_ID As Integer) As CMS_ReligionInfo
        Return CBO.FillObject(Of CMS_ReligionInfo)(DataProvider.Instance().CMS_Religion_Get(PortalConnect, religion_ID))
    End Function
    Public Shared Function CMS_Religion_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Religion_List(PortalConnect), GetType(CMS_ReligionInfo))
    End Function
    Public Shared Function CMS_Religion_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Religion_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ReligionInfo))
    End Function
    Public Shared Function CMS_Religion_Add(PortalConnect As String, obj As CMS_ReligionInfo) As Integer
        Return DataProvider.Instance().CMS_Religion_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Religion_Update(PortalConnect As String, obj As CMS_ReligionInfo)
        DataProvider.Instance().CMS_Religion_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Religion_Delete(PortalConnect As String, religion_ID As Integer)
        DataProvider.Instance().CMS_Religion_Delete(PortalConnect, religion_ID)
    End Sub
#End Region
#Region "CMS_Language"
    Public Shared Function CMS_Language_Get(PortalConnect As String, Language_ID As Integer) As CMS_LanguageInfo
        Return CBO.FillObject(Of CMS_LanguageInfo)(DataProvider.Instance().CMS_Language_Get(PortalConnect, Language_ID))
    End Function
    Public Shared Function CMS_Language_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Language_List(PortalConnect), GetType(CMS_LanguageInfo))
    End Function
    Public Shared Function CMS_Language_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Language_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LanguageInfo))
    End Function
    Public Shared Function CMS_Language_Add(PortalConnect As String, obj As CMS_LanguageInfo) As Integer
        Return DataProvider.Instance().CMS_Language_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Language_Update(PortalConnect As String, obj As CMS_LanguageInfo)
        DataProvider.Instance().CMS_Language_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Language_Delete(PortalConnect As String, Language_ID As Integer)
        DataProvider.Instance().CMS_Language_Delete(PortalConnect, Language_ID)
    End Sub
#End Region
#Region "CMS_Education"
    Public Shared Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As CMS_EducationInfo
        Return CBO.FillObject(Of CMS_EducationInfo)(DataProvider.Instance().CMS_Education_Get(PortalConnect, Education_ID))
    End Function
    Public Shared Function SV_Education_Get_By_IdKey(PortalConnect As String, education_Code As String) As String
        Return DataProvider.Instance().SV_Education_Get_By_IdKey(PortalConnect, education_Code)
    End Function
    Public Shared Function CMS_Education_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Education_List(PortalConnect), GetType(CMS_EducationInfo))
    End Function
    Public Shared Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Education_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_EducationInfo))
    End Function
    Public Shared Function SV_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
        Return DataProvider.Instance().SV_Education_Add(PortalConnect, obj)
    End Function
    Public Shared Function CMS_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
        Return DataProvider.Instance().CMS_Education_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Education_Update(PortalConnect As String, obj As CMS_EducationInfo)
        DataProvider.Instance().CMS_Education_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
        DataProvider.Instance().CMS_Education_Delete(PortalConnect, Education_ID)
    End Sub
#End Region
#Region "CMS_Buglog"
    Public Shared Function CMS_Buglog_Get(PortalConnect As String, buglog_ID As Integer) As CMS_BuglogInfo
        Return CBO.FillObject(Of CMS_BuglogInfo)(DataProvider.Instance().CMS_Buglog_Get(PortalConnect, buglog_ID))
    End Function
    Public Shared Function CMS_Buglog_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Buglog_List(PortalConnect), GetType(CMS_BuglogInfo))
    End Function
    Public Shared Function CMS_Buglog_Add(PortalConnect As String, Contents As String, TabName As String) As Integer
        Return DataProvider.Instance().CMS_Buglog_Add(PortalConnect, Contents, TabName)
    End Function
    Public Shared Sub CMS_Buglog_Update(PortalConnect As String, obj As CMS_BuglogInfo)
        DataProvider.Instance().CMS_Buglog_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Buglog_Delete(PortalConnect As String, buglog_ID As Integer)
        DataProvider.Instance().CMS_Buglog_Delete(PortalConnect, buglog_ID)
    End Sub
    Public Shared Function CMS_Buglog_List_By_TabName(PortalConnect As String, TabName As String, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Buglog_List_By_TabName(PortalConnect, TabName, iD, currPage, recodperpage), GetType(CMS_BuglogInfo))
    End Function
    Public Shared Sub CMS_Buglog_Update_Resolve(PortalConnect As String, Buglog_ID As Integer, Resolve As String)
        DataProvider.Instance().CMS_Buglog_Update_Resolve(PortalConnect, Buglog_ID, Resolve)
    End Sub
#End Region
#Region "CMS_Relation"
    Public Shared Function CMS_Relation_Get_By_Name(PortalConnect As String, Relation_Name As String) As CMS_RelationInfo
        Return CBO.FillObject(Of CMS_RelationInfo)(DataProvider.Instance().CMS_Relation_Get_By_Name(PortalConnect, Relation_Name))
    End Function
    Public Shared Function CMS_Relation_Get(PortalConnect As String, Relation_ID As Integer) As CMS_RelationInfo
        Return CBO.FillObject(Of CMS_RelationInfo)(DataProvider.Instance().CMS_Relation_Get(PortalConnect, Relation_ID))
    End Function
    Public Shared Function CMS_Relation_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Relation_List(PortalConnect), GetType(CMS_RelationInfo))
    End Function
    Public Shared Function CMS_Relation_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Relation_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RelationInfo))
    End Function
    Public Shared Function CMS_Relation_Add(PortalConnect As String, obj As CMS_RelationInfo) As Integer
        Return DataProvider.Instance().CMS_Relation_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Relation_Update(PortalConnect As String, obj As CMS_RelationInfo)
        DataProvider.Instance().CMS_Relation_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Relation_Delete(PortalConnect As String, Relation_ID As Integer)
        DataProvider.Instance().CMS_Relation_Delete(PortalConnect, Relation_ID)
    End Sub
#End Region
#Region "CMS_ActiveDomain"
    Public Shared Function CMS_ActiveDomain_Get(PortalConnect As String, domain_ID As Integer) As CMS_ActiveDomainInfo
        Return CBO.FillObject(Of CMS_ActiveDomainInfo)(DataProvider.Instance().CMS_ActiveDomain_Get(PortalConnect, domain_ID))
    End Function
    Public Shared Function CMS_ActiveDomain_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ActiveDomain_List(PortalConnect), GetType(CMS_ActiveDomainInfo))
    End Function
    Public Shared Function CMS_ActiveDomain_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ActiveDomain_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, tinhTP), GetType(CMS_ActiveDomainInfo))
    End Function
    Public Shared Function CMS_ActiveDomain_Check_Active(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, domain As String) As CMS_ActiveDomainInfo
        Return CBO.FillObject(Of CMS_ActiveDomainInfo)(DataProvider.Instance().CMS_ActiveDomain_Check_Active(PortalConnect, tinhTP, quanHuyen, domain))
    End Function
    Public Shared Function CMS_ActiveDomain_Add(PortalConnect As String, obj As CMS_ActiveDomainInfo) As Integer
        Return DataProvider.Instance().CMS_ActiveDomain_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_ActiveDomain_Update(PortalConnect As String, obj As CMS_ActiveDomainInfo)
        DataProvider.Instance().CMS_ActiveDomain_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_ActiveDomain_Delete(PortalConnect As String, domain_ID As Integer)
        DataProvider.Instance().CMS_ActiveDomain_Delete(PortalConnect, domain_ID)
    End Sub
#End Region
#Region "CMS_Area"
    Public Shared Function CMS_Area_Get(PortalConnect As String, Area_ID As Integer) As CMS_AreaInfo
        Return CBO.FillObject(Of CMS_AreaInfo)(DataProvider.Instance().CMS_Area_Get(PortalConnect, Area_ID))
    End Function
    Public Shared Function CMS_Area_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Area_List(PortalConnect), GetType(CMS_AreaInfo))
    End Function
    Public Shared Function CMS_Area_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Area_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_AreaInfo))
    End Function
    Public Shared Function CMS_Area_Add(PortalConnect As String, obj As CMS_AreaInfo) As Integer
        Return DataProvider.Instance().CMS_Area_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_Area_Update(PortalConnect As String, obj As CMS_AreaInfo)
        DataProvider.Instance().CMS_Area_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_Area_Delete(PortalConnect As String, Area_ID As Integer)
        DataProvider.Instance().CMS_Area_Delete(PortalConnect, Area_ID)
    End Sub
#End Region
#Region "CMS_Place"
    Public Shared Function CMS_Place_Get_By_Name(PortalConnect As String, Place_Name As String) As CMS_PlaceInfo
        Return CBO.FillObject(Of CMS_PlaceInfo)(DataProvider.Instance().CMS_Place_Get_By_Name(PortalConnect, Place_Name))
    End Function
    Public Shared Function CMS_Place_Get(PortalConnect As String, Place_ID As Integer) As CMS_PlaceInfo
        Return CBO.FillObject(Of CMS_PlaceInfo)(DataProvider.Instance().CMS_Place_Get(PortalConnect, Place_ID))
    End Function
    Public Shared Function CMS_Place_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Place_List(PortalConnect, portalId), GetType(CMS_PlaceInfo))
    End Function
    Public Shared Function CMS_Place_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Place_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PlaceInfo))
    End Function
    Public Shared Function CMS_Place_Add(PortalConnect As String, obj As CMS_PlaceInfo) As Integer
        Return DataProvider.Instance().CMS_Place_Add(PortalConnect, obj.Place_Name, obj.Place_Code, obj.Place_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Function
    Public Shared Sub CMS_Place_Update(PortalConnect As String, obj As CMS_PlaceInfo)
        DataProvider.Instance().CMS_Place_Update(PortalConnect, obj.Place_ID, obj.Place_Name, obj.Place_Code, obj.Place_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Shared Sub CMS_Place_Delete(PortalConnect As String, Place_ID As Integer)
        DataProvider.Instance().CMS_Place_Delete(PortalConnect, Place_ID)
    End Sub
#End Region
#Region "CMS_ConfigTP"
    Public Shared Function CMS_ConfigTP_Get(PortalConnect As String, iD As Integer) As CMS_ConfigTPInfo
        Return CBO.FillObject(Of CMS_ConfigTPInfo)(DataProvider.Instance().CMS_ConfigTP_Get(PortalConnect, iD))
    End Function
    Public Shared Function CMS_ConfigTP_Get_By_TinhTP(PortalConnect As String, TinhTP As Integer, PortalAlias As String) As CMS_ConfigTPInfo
        Return CBO.FillObject(Of CMS_ConfigTPInfo)(DataProvider.Instance().CMS_ConfigTP_Get_By_TinhTP(PortalConnect, TinhTP, PortalAlias))
    End Function
    Public Shared Function CMS_ConfigTP_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ConfigTP_List(PortalConnect), GetType(CMS_ConfigTPInfo))
    End Function
    Public Shared Function CMS_ConfigTP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ConfigTP_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ConfigTPInfo))
    End Function
    Public Shared Function CMS_ConfigTP_Add(PortalConnect As String, obj As CMS_ConfigTPInfo) As Integer
        Return DataProvider.Instance().CMS_ConfigTP_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_ConfigTP_Update(PortalConnect As String, obj As CMS_ConfigTPInfo)
        DataProvider.Instance().CMS_ConfigTP_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_ConfigTP_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_ConfigTP_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_DayOff"
    Public Shared Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As CMS_DayOffInfo
        Return CBO.FillObject(Of CMS_DayOffInfo)(DataProvider.Instance().CMS_DayOff_Get(PortalConnect, dayOff_ID))
    End Function
    Public Shared Function CMS_DayOff_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DayOff_List(PortalConnect), GetType(CMS_DayOffInfo))
    End Function
    Public Shared Sub CMS_DayOff_Add(PortalConnect As String, obj As CMS_DayOffInfo)
        DataProvider.Instance().CMS_DayOff_Add(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_DayOff_Update(PortalConnect As String, obj As CMS_DayOffInfo)
        DataProvider.Instance().CMS_DayOff_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
        DataProvider.Instance().CMS_DayOff_Delete(PortalConnect, dayOff_ID)
    End Sub
    Public Shared Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer
        Return DataProvider.Instance().CMS_DayOff_Get_Day_Month(PortalConnect, isDay, isMonth)
    End Function
    Public Shared Function TP_ChuyenDoi_Get(PortalConnect As String, ID As Integer) As Integer
        Return DataProvider.Instance().TP_ChuyenDoi_Get(PortalConnect, ID)
    End Function
    Public Shared Function CMS_OffTime_Get_By_Dates(PortalConnect As String, Dates As DateTime) As Integer
        Return DataProvider.Instance().CMS_OffTime_Get_By_Dates(PortalConnect, Dates)
    End Function
    Public Shared Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DayOff_List_Search(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_DayOffInfo))
    End Function
    Public Shared Sub CMS_DayOff_Update_Quick(PortalConnect As String, dayOff_ID As String, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_DayOff_Update_Quick(PortalConnect, dayOff_ID, isActive, isOrder)
    End Sub
    Public Shared Function CMS_DayOff_TinhNgay(PortalConnect As String, Dates As DateTime, soNgay As Integer) As DateTime
        Return DataProvider.Instance().CMS_DayOff_TinhNgay(PortalConnect, Dates, soNgay)
    End Function
#End Region
#Region "CMS_API"
    Public Shared Function CMS_API_Get(PortalConnect As String, id As Integer) As CMS_APIInfo
        Return CBO.FillObject(Of CMS_APIInfo)(DataProvider.Instance().CMS_API_Get(PortalConnect, id))
    End Function
    Public Shared Function CMS_API_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_API_List(PortalConnect), GetType(CMS_APIInfo))
    End Function
    Public Shared Function CMS_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_API_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_APIInfo))
    End Function

    Public Shared Function CMS_API_Add(PortalConnect As String, obj As CMS_APIInfo) As Integer
        Return DataProvider.Instance().CMS_API_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_API_Update(PortalConnect As String, obj As CMS_APIInfo)
        DataProvider.Instance().CMS_API_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_API_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().CMS_API_Delete(PortalConnect, id, userId)
    End Sub
#End Region
#Region "CMS_APIHeader"
    Public Shared Function CMS_APIHeader_Get(PortalConnect As String, id As Integer) As CMS_APIHeaderInfo
        Return CBO.FillObject(Of CMS_APIHeaderInfo)(DataProvider.Instance().CMS_APIHeader_Get(PortalConnect, id))
    End Function
    'Public Shared Function APIHeader_List(PortalConnect As String, idAPI As Integer) As ArrayList
    '    Return CBO.FillCollection(DataProvider.Instance().APIHeader_List(PortalConnect, idAPI), GetType(APIHeaderInfo))
    'End Function

    Public Shared Function CMS_APIHeader_Add(PortalConnect As String, obj As CMS_APIHeaderInfo) As Integer
        Return DataProvider.Instance().CMS_APIHeader_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_APIHeader_Update(PortalConnect As String, obj As CMS_APIHeaderInfo)
        DataProvider.Instance().CMS_APIHeader_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        DataProvider.Instance().CMS_APIHeader_Delete(PortalConnect, id, userId)
    End Sub
    Public Shared Function CMS_APIHeader_List(PortalConnect As String, idAPI As Integer) As List(Of CMS_APIHeaderInfo)
        Return CBO.FillCollection(Of CMS_APIHeaderInfo)(SqlHelper.ExecuteReader(New flConnect().DmConnect, "CMS_APIHeader_List", idAPI))
    End Function
    Public Shared Function CMS_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_APIHeader_List_Search(PortalConnect, idAPI, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_APIHeaderInfo))
    End Function
    Public Shared Sub CMS_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)
        DataProvider.Instance().CMS_APIHeader_LichDongBo(PortalConnect, id, lichDongBo, userId)
    End Sub
#End Region
#Region "Other"
    Public Shared Function UpdatePassword(pid As Integer, userInfo As UserInfo, txtOldPassword As String, txtNewPassword As String, txtNewConfirm As String) As String
        If txtNewPassword <> txtNewConfirm Then
            Return "Mật khẩu không khớp"
        End If

        If Not UserController.ValidatePassword(txtNewPassword) Then
            Return "Mật khẩu không hợp lệ"
        End If

        If String.IsNullOrEmpty(txtOldPassword) Then
            Return "Mật khẩu cũ không hợp lệ"
        End If

        If txtNewPassword = txtOldPassword Then
            Return "Mật khẩu cũ và mật khẩu mới phải khác nhau"
        End If

        Dim settings = New MembershipPasswordSettings(pid)

        If settings.EnableBannedList Then
            Dim m = New MembershipPasswordController()

            If m.FoundBannedPassword(txtNewPassword) OrElse userInfo.Username = txtNewPassword Then
                Return "Tài khoản đang bị khóa, không thể thay đổi mật khẩu"
            End If
        End If

        Try
            UserController.ChangePassword(userInfo, txtOldPassword, txtNewPassword)
            Return "Đổi mật khẩu thành công"
        Catch exc As Exception
            Return "Có lỗi khi đổi mật khẩu"
        End Try
    End Function
    Public Shared Function ResetPassword(pid As Integer, email As String)
        Try
            Dim _user As DnnInfo = flDnn.DNN_User_Get_UserName(pid, email)
            If IsNothing(_user) = False Then
                Dim RestPassWordId As String = Guid.NewGuid.ToString()
                Dim strEndDate As DateTime = DateTime.Now.AddMinutes(15)
                Dim HTTPAlias As String = flReg.UrlAlias() & "/kich-hoat-tai-khoan/rs/" & RestPassWordId
                Dim Str As String = ""
                Str += "<div style=""font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;"">" & vbCrLf
                Str += "<div style="" padding:5px;padding-bottom:10px;""> Bạn < span style=""font-weight: bold"">[DisplayName]</span> thân mến,</div>" & vbCrLf
                Str += " <div style=""padding5px;"">bạn vừa yêu cầu gợi ý lấy lại mật khẩu tại <span style=""color: green; font-weight: bold;"">[PortalName]</span></div>" & vbCrLf
                Str += "<div style=""padding:5px;"">Tên tài khoản: <strong>[Username]</strong></div>" & vbCrLf
                Str += " <div style=""padding:5px;"">Địa chỉ email: <strong>[Email]</strong></div>" & vbCrLf
                Str += " <div style=""padding:5px;"">Click <a style=""font-weight:bold;"" href=""[HTTPAlias]"">vào đây</a> để lấy lại mật khẩu.</div>" & vbCrLf
                Str += " <div style=""padding:5px;"">Có giá trị đến hết ngày: <strong>[EndDate]</strong></div>" & vbCrLf
                Str += " <div style=""padding:15px 5px;"">Trân trọng,</div>" & vbCrLf
                Str += " <div style="" padding:5px;font-weight: bold; color: green"">Ban quản trị</div>" & vbCrLf
                Str += " <div style="" padding:5px;font-style:italic"">*Chú ý: nếu bạn không yêu cầu gợi ý lấy lại mật khẩu, hãy bỏ qua thư này.</div>" & vbCrLf
                Str += "</div>" & vbCrLf

                Dim subject As String = String.Format("Lấy lại mật khẩu")
                Str = Str.Replace("[DisplayName]", _user.DisplayName)
                Str = Str.Replace("[PortalName]", flReg.WebConfig("TenDonVi"))
                Str = Str.Replace("[HTTPAlias]", HTTPAlias)
                Str = Str.Replace("[Username]", email)
                Str = Str.Replace("[Email]", email)
                Str = Str.Replace("[EndDate]", strEndDate.ToString())

                flDnn.DNN_AddRestPassWord(RestPassWordId, pid, _user.Username, _user.Email, strEndDate)
                flDnn.DNN_SendMail(_user.Email, subject, Str)
                Return "Khôi phục mật khẩu thành công, vui lòng kiểm tra hòm thư của bạn"
            Else
                Return "Email không hợp lệ"
            End If
        Catch ex As Exception
            Return "Có lỗi không thể gửi thư khôi phục mật khẩu"
        End Try
    End Function
#End Region

#Region "CMS_RegionalTP"
    Public Shared Sub CMS_RegionalTP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        DataProvider.Instance().CMS_RegionalTP_Backup_Add(PortalConnect, maTinh, yearID)
    End Sub
    Public Shared Function CMS_RegionalTP_Backup_List_Parent_Null(PortalConnect As String, yearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTP_Backup_List_Parent_Null(PortalConnect, yearID), GetType(CMS_RegionalTPInfo))
    End Function
    Public Shared Function CMS_RegionalTP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As CMS_RegionalTPInfo
        Return CBO.FillObject(Of CMS_RegionalTPInfo)(DataProvider.Instance().CMS_RegionalTP_Backup_Get(PortalConnect, regional_ID, yearID))
    End Function
    Public Shared Function CMS_RegionalTP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return DataProvider.Instance().CMS_RegionalTP_Get_Name_Parent(PortalConnect, parentID, Regional_Name)
    End Function
    Public Shared Function CMS_RegionalTP_Get_By_Name(PortalConnect As String, Regional_Name As String) As CMS_RegionalTPInfo
        Return CBO.FillObject(Of CMS_RegionalTPInfo)(DataProvider.Instance().CMS_RegionalTP_Get_By_Name(PortalConnect, Regional_Name))
    End Function
    Public Shared Function CMS_RegionalTP_Get_By_Code(PortalConnect As String, code As String) As CMS_RegionalTPInfo
        Return CBO.FillObject(Of CMS_RegionalTPInfo)(DataProvider.Instance().CMS_RegionalTP_Get_By_Code(PortalConnect, code))
    End Function
    Public Shared Function CMS_RegionalTP_Get(PortalConnect As String, regional_ID As Integer) As CMS_RegionalTPInfo
        Return CBO.FillObject(Of CMS_RegionalTPInfo)(DataProvider.Instance().CMS_RegionalTP_Get(PortalConnect, regional_ID))
    End Function
    Public Shared Function CMS_RegionalTP_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTP_List(PortalConnect, portalId), GetType(CMS_RegionalTPInfo))
    End Function
    Public Shared Function CMS_RegionalTP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTP_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalTPInfo))
    End Function
    Public Shared Function CMS_RegionalTP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTP_Parent_Search_ID_Deleted(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalTPInfo))
    End Function
    Public Shared Function CMS_RegionalTP_List_Parent_Null(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTP_List_Parent_Null(PortalConnect), GetType(CMS_RegionalTPInfo))
    End Function
    Public Shared Function CMS_RegionalTP_Add(PortalConnect As String, obj As CMS_RegionalTPInfo) As Integer
        Return DataProvider.Instance().CMS_RegionalTP_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_RegionalTP_Update(PortalConnect As String, obj As CMS_RegionalTPInfo)
        DataProvider.Instance().CMS_RegionalTP_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_RegionalTP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        DataProvider.Instance().CMS_RegionalTP_Update_Delete(PortalConnect, regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Shared Sub CMS_RegionalTP_Delete(PortalConnect As String, regional_ID As Integer)
        DataProvider.Instance().CMS_RegionalTP_Delete(PortalConnect, regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalQH"
    Public Shared Sub CMS_RegionalQH_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        DataProvider.Instance().CMS_RegionalQH_Backup_Add(PortalConnect, maTinh, yearID)
    End Sub
    Public Shared Function CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & regional_ID & "_" & yearID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP(PortalConnect, regional_ID, yearID), GetType(CMS_RegionalQHInfo))
            flCache.SetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & regional_ID & "_" & yearID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & regional_ID & "_" & yearID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalQH_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As CMS_RegionalQHInfo
        Return CBO.FillObject(Of CMS_RegionalQHInfo)(DataProvider.Instance().CMS_RegionalQH_Backup_Get(PortalConnect, regional_ID, yearID))
    End Function
    Public Shared Function CMS_RegionalQH_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return DataProvider.Instance().CMS_RegionalQH_Get_Name_Parent(PortalConnect, parentID, Regional_Name)
    End Function
    Public Shared Function CMS_RegionalQH_Get_By_Name(PortalConnect As String, Regional_Name As String) As CMS_RegionalQHInfo
        Return CBO.FillObject(Of CMS_RegionalQHInfo)(DataProvider.Instance().CMS_RegionalQH_Get_By_Name(PortalConnect, Regional_Name))
    End Function
    Public Shared Function CMS_RegionalQH_Get_By_Code(PortalConnect As String, code As String) As CMS_RegionalQHInfo
        Return CBO.FillObject(Of CMS_RegionalQHInfo)(DataProvider.Instance().CMS_RegionalQH_Get_By_Code(PortalConnect, code))
    End Function
    Public Shared Function CMS_RegionalQH_Get(PortalConnect As String, regional_ID As Integer) As CMS_RegionalQHInfo
        Return CBO.FillObject(Of CMS_RegionalQHInfo)(DataProvider.Instance().CMS_RegionalQH_Get(PortalConnect, regional_ID))
    End Function
    Public Shared Function CMS_RegionalQH_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalQH_List(PortalConnect, portalId), GetType(CMS_RegionalQHInfo))
    End Function
    Public Shared Function CMS_RegionalQH_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalQH_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalQHInfo))
    End Function
    Public Shared Function CMS_RegionalQH_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalQH_Parent_Search_ID_Deleted(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalQHInfo))
    End Function
    Public Shared Function CMS_RegionalQH_Get_By_CMS_RegionalTP(PortalConnect As String, regional_ID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & regional_ID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalQH_Get_By_CMS_RegionalTP(PortalConnect, regional_ID), GetType(CMS_RegionalQHInfo))
            flCache.SetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & regional_ID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & regional_ID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalQH_Add(PortalConnect As String, obj As CMS_RegionalQHInfo) As Integer
        Return DataProvider.Instance().CMS_RegionalQH_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_RegionalQH_Update(PortalConnect As String, obj As CMS_RegionalQHInfo)
        DataProvider.Instance().CMS_RegionalQH_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_RegionalQH_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        DataProvider.Instance().CMS_RegionalQH_Update_Delete(PortalConnect, regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Shared Sub CMS_RegionalQH_Delete(PortalConnect As String, regional_ID As Integer)
        DataProvider.Instance().CMS_RegionalQH_Delete(PortalConnect, regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalXP"
    Public Shared Sub CMS_RegionalXP_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        DataProvider.Instance().CMS_RegionalXP_Backup_Add(PortalConnect, maTinh, yearID)
    End Sub
    Public Shared Function CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer, yearID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & regional_ID & "_" & yearID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH(PortalConnect, regional_ID, yearID), GetType(CMS_RegionalXPInfo))
            flCache.SetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & regional_ID & "_" & yearID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & regional_ID & "_" & yearID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalXP_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As CMS_RegionalXPInfo
        Return CBO.FillObject(Of CMS_RegionalXPInfo)(DataProvider.Instance().CMS_RegionalXP_Backup_Get(PortalConnect, regional_ID, yearID))
    End Function
    Public Shared Function CMS_RegionalXP_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return DataProvider.Instance().CMS_RegionalXP_Get_Name_Parent(PortalConnect, parentID, Regional_Name)
    End Function
    Public Shared Function CMS_RegionalXP_Get_By_Name(PortalConnect As String, Regional_Name As String) As CMS_RegionalXPInfo
        Return CBO.FillObject(Of CMS_RegionalXPInfo)(DataProvider.Instance().CMS_RegionalXP_Get_By_Name(PortalConnect, Regional_Name))
    End Function
    Public Shared Function CMS_RegionalXP_Get_By_Code(PortalConnect As String, code As String) As CMS_RegionalXPInfo
        Return CBO.FillObject(Of CMS_RegionalXPInfo)(DataProvider.Instance().CMS_RegionalXP_Get_By_Code(PortalConnect, code))
    End Function
    Public Shared Function CMS_RegionalXP_Get(PortalConnect As String, regional_ID As Integer) As CMS_RegionalXPInfo
        Return CBO.FillObject(Of CMS_RegionalXPInfo)(DataProvider.Instance().CMS_RegionalXP_Get(PortalConnect, regional_ID))
    End Function
    Public Shared Function CMS_RegionalXP_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_List(PortalConnect, portalId), GetType(CMS_RegionalXPInfo))
    End Function
    Public Shared Function CMS_RegionalXP_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RegionalXPInfo))
    End Function
    Public Shared Function CMS_RegionalXP_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalXPInfo))
    End Function
    Public Shared Function CMS_RegionalXP_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_Parent_Search_ID_Deleted(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalXPInfo))
    End Function
    Public Shared Function CMS_RegionalXP_Get_By_CMS_RegionalQH(PortalConnect As String, regional_ID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & regional_ID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalXP_Get_By_CMS_RegionalQH(PortalConnect, regional_ID), GetType(CMS_RegionalXPInfo))
            flCache.SetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & regional_ID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & regional_ID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalXP_Add(PortalConnect As String, obj As CMS_RegionalXPInfo) As Integer
        Return DataProvider.Instance().CMS_RegionalXP_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_RegionalXP_Update(PortalConnect As String, obj As CMS_RegionalXPInfo)
        DataProvider.Instance().CMS_RegionalXP_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_RegionalXP_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        DataProvider.Instance().CMS_RegionalXP_Update_Delete(PortalConnect, regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Shared Sub CMS_RegionalXP_Delete(PortalConnect As String, regional_ID As Integer)
        DataProvider.Instance().CMS_RegionalXP_Delete(PortalConnect, regional_ID)
    End Sub
#End Region
#Region "CMS_RegionalTO"
    Public Shared Sub CMS_RegionalTO_Backup_Add(PortalConnect As String, maTinh As Integer, yearID As Integer)
        DataProvider.Instance().CMS_RegionalTO_Backup_Add(PortalConnect, maTinh, yearID)
    End Sub
    Public Shared Function CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer, yearID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & regional_ID & "_" & yearID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP(PortalConnect, regional_ID, yearID), GetType(CMS_RegionalTOInfo))
            flCache.SetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & regional_ID & "_" & yearID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & regional_ID & "_" & yearID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalTO_Backup_Get(PortalConnect As String, regional_ID As Integer, yearID As Integer) As CMS_RegionalTOInfo
        Return CBO.FillObject(Of CMS_RegionalTOInfo)(DataProvider.Instance().CMS_RegionalTO_Backup_Get(PortalConnect, regional_ID, yearID))
    End Function
    Public Shared Function CMS_RegionalTO_Get_Name_Parent(PortalConnect As String, parentID As String, Regional_Name As String) As Integer
        Return DataProvider.Instance().CMS_RegionalTO_Get_Name_Parent(PortalConnect, parentID, Regional_Name)
    End Function
    Public Shared Function CMS_RegionalTO_Get_By_Name(PortalConnect As String, Regional_Name As String) As CMS_RegionalTOInfo
        Return CBO.FillObject(Of CMS_RegionalTOInfo)(DataProvider.Instance().CMS_RegionalTO_Get_By_Name(PortalConnect, Regional_Name))
    End Function
    Public Shared Function CMS_RegionalTO_Get_By_Code(PortalConnect As String, code As String) As CMS_RegionalTOInfo
        Return CBO.FillObject(Of CMS_RegionalTOInfo)(DataProvider.Instance().CMS_RegionalTO_Get_By_Code(PortalConnect, code))
    End Function
    Public Shared Function CMS_RegionalTO_Get(PortalConnect As String, regional_ID As Integer) As CMS_RegionalTOInfo
        Return CBO.FillObject(Of CMS_RegionalTOInfo)(DataProvider.Instance().CMS_RegionalTO_Get(PortalConnect, regional_ID))
    End Function
    Public Shared Function CMS_RegionalTO_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_List(PortalConnect, portalId), GetType(CMS_RegionalTOInfo))
    End Function
    Public Shared Function CMS_RegionalTO_List_ByTinhHuyenXa(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, maThon As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_List_ByTinhHuyenXa(PortalConnect, maTinh, maHuyen, maXa, maThon), GetType(CMS_RegionalTOInfo))
    End Function
    Public Shared Function CMS_RegionalTO_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RegionalTOInfo))
    End Function
    Public Shared Function CMS_RegionalTO_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalTOInfo))
    End Function
    Public Shared Function CMS_RegionalTO_Parent_Search_ID_Deleted(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_Parent_Search_ID_Deleted(PortalConnect, search, isOrder, Parent_ID, currPage, recodperpage), GetType(CMS_RegionalTOInfo))
    End Function
    Public Shared Function CMS_RegionalTO_Get_By_CMS_RegionalXP(PortalConnect As String, regional_ID As Integer) As ArrayList
        If IsNothing(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & regional_ID)) = True Then
            arrTemp = CBO.FillCollection(DataProvider.Instance().CMS_RegionalTO_Get_By_CMS_RegionalXP(PortalConnect, regional_ID), GetType(CMS_RegionalTOInfo))
            flCache.SetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & regional_ID, arrTemp, SecondCache.M60)
        Else
            arrTemp = CType(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & regional_ID), ArrayList)
        End If
        Return arrTemp
    End Function
    Public Shared Function CMS_RegionalTO_Add(PortalConnect As String, obj As CMS_RegionalTOInfo) As Integer
        Return DataProvider.Instance().CMS_RegionalTO_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMS_RegionalTO_Update(PortalConnect As String, obj As CMS_RegionalTOInfo)
        DataProvider.Instance().CMS_RegionalTO_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMS_RegionalTO_Update_Delete(PortalConnect As String, regional_ID As Integer, deletedDate As DateTime, deletedUser As String, IsDelete As Boolean)
        DataProvider.Instance().CMS_RegionalTO_Update_Delete(PortalConnect, regional_ID, deletedDate, deletedUser, IsDelete)
    End Sub
    Public Shared Sub CMS_RegionalTO_Delete(PortalConnect As String, regional_ID As Integer)
        DataProvider.Instance().CMS_RegionalTO_Delete(PortalConnect, regional_ID)
    End Sub
#End Region
#Region "CMS_DanhMucChung"
    Public Shared Function CMS_DanhMuc_List(portalId As Integer, tenDanhMuc As String, Optional ByVal isCache As Boolean = True) As ArrayList
        If isCache Then
            Dim arrData = flCache.GetCache(tenDanhMuc & "_List_" & portalId)
            If IsNothing(arrData) = False Then
                Return arrData
            Else
                arrData = CBO.FillCollection(DataProvider.Instance().CMS_DanhMuc_List(portalId, tenDanhMuc), GetType(CMS_DanhMucInfo))
                flCache.SetCache(tenDanhMuc & "_List_" & portalId, arrData)
                Return arrData
            End If
        Else
            Return CBO.FillCollection(DataProvider.Instance().CMS_DanhMuc_List(portalId, tenDanhMuc), GetType(CMS_DanhMucInfo))
        End If
    End Function
    Public Shared Function CMS_DanhMuc_Get(portalId As Integer, tenDanhMuc As String, id As Integer) As CMS_DanhMucInfo
        Return CBO.FillObject(Of CMS_DanhMucInfo)(DataProvider.Instance().CMS_DanhMuc_Get(portalId, tenDanhMuc, id))
    End Function

    Public Shared Function CMS_DanhMuc_List_Search(PortalConnect As String, tenDanhMuc As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DanhMuc_List_Search(PortalConnect, tenDanhMuc, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DanhMucInfo))
    End Function

    Public Shared Function CMS_DanhMuc_Add(PortalConnect As String, tenDanhMuc As String, obj As CMS_DanhMucInfo) As Integer
        Return DataProvider.Instance().CMS_DanhMuc_Add(PortalConnect, tenDanhMuc, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Shared Sub CMS_DanhMuc_Update(PortalConnect As String, tenDanhMuc As String, obj As CMS_DanhMucInfo)
        DataProvider.Instance().CMS_DanhMuc_Update(PortalConnect, tenDanhMuc, obj.ID, obj.Code, obj.Name, obj.Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Shared Sub CMS_DanhMuc_Delete(PortalConnect As String, tenDanhMuc As String, id As Integer)
        DataProvider.Instance().CMS_DanhMuc_Delete(PortalConnect, tenDanhMuc, id)
    End Sub

#End Region
#Region "CMS_TypeEco"
    'Public Shared Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As CMS_TypeEcoInfo
    '    Return CBO.FillObject(Of CMS_TypeEcoInfo)(DataProvider.Instance().CMS_TypeEco_Get(PortalConnect, typeEco_ID))
    'End Function
    'Public Shared Function CMS_TypeEco_List(PortalConnect As String) As ArrayList
    '    Return CBO.FillCollection(DataProvider.Instance().CMS_TypeEco_List(PortalConnect), GetType(CMS_TypeEcoInfo))
    'End Function
    'Public Shared Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
    '    Return CBO.FillCollection(DataProvider.Instance().CMS_TypeEco_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TypeEcoInfo))
    'End Function

    'Public Shared Function CMS_TypeEco_Add(PortalConnect As String, obj As CMS_TypeEcoInfo) As Integer
    '    Return DataProvider.Instance().CMS_TypeEco_Add(PortalConnect, obj.TypeEco_Code, obj.TypeEco_Name, obj.TypeEco_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    'End Function
    'Public Shared Sub CMS_TypeEco_Update(PortalConnect As String, obj As CMS_TypeEcoInfo)
    '    DataProvider.Instance().CMS_TypeEco_Update(PortalConnect, obj.TypeEco_ID, obj.TypeEco_Code, obj.TypeEco_Name, obj.TypeEco_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    'End Sub
    'Public Shared Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
    '    DataProvider.Instance().CMS_TypeEco_Delete(PortalConnect, typeEco_ID)
    'End Sub
    'Public Shared Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
    '    DataProvider.Instance().CMS_TypeEco_Update_Quick(PortalConnect, typeEco_ID, isActive, isOrder)
    'End Sub
#End Region
#Region "CMS_Method"
    Public Shared Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As CMS_MethodInfo
        Return CBO.FillObject(Of CMS_MethodInfo)(DataProvider.Instance().CMS_Method_Get(PortalConnect, method_ID))
    End Function
    Public Shared Function CMS_Method_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Method_List(PortalConnect), GetType(CMS_MethodInfo))
    End Function
    Public Shared Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Method_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_MethodInfo))
    End Function

    Public Shared Function CMS_Method_Add(PortalConnect As String, obj As CMS_MethodInfo) As Integer
        Return DataProvider.Instance().CMS_Method_Add(PortalConnect, obj.Method_Code, obj.Method_Name, obj.Method_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Shared Sub CMS_Method_Update(PortalConnect As String, obj As CMS_MethodInfo)
        DataProvider.Instance().CMS_Method_Update(PortalConnect, obj.Method_ID, obj.Method_Code, obj.Method_Name, obj.Method_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Shared Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
        DataProvider.Instance().CMS_Method_Delete(PortalConnect, method_ID)
    End Sub
    Public Shared Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Method_Update_Quick(PortalConnect, method_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMSUserExtra"
    Public Shared Function CMSUserExtra_Get(PortalConnect As String, iD As Integer) As CMSUserExtraInfo
        Return CBO.FillObject(Of CMSUserExtraInfo)(DataProvider.Instance().CMSUserExtra_Get(PortalConnect, iD))
    End Function
    Public Shared Function CMSUserExtra_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSUserExtra_List(PortalConnect, portalId), GetType(CMSUserExtraInfo))
    End Function
    Public Shared Function CMSUserExtra_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMSUserExtra_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMSUserExtraInfo))
    End Function

    Public Shared Function CMSUserExtra_Add(PortalConnect As String, obj As CMSUserExtraInfo) As Integer
        Return DataProvider.Instance().CMSUserExtra_Add(PortalConnect, obj)
    End Function
    Public Shared Sub CMSUserExtra_Update(PortalConnect As String, obj As CMSUserExtraInfo)
        DataProvider.Instance().CMSUserExtra_Update(PortalConnect, obj)
    End Sub
    Public Shared Sub CMSUserExtra_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMSUserExtra_Delete(PortalConnect, iD)
    End Sub
    Public Shared Function CMSUserExtra_Get_By_User(portalConnect As String, userName As String, PortalID As Integer) As CMSUserExtraInfo
        Return CBO.FillObject(Of CMSUserExtraInfo)(DataProvider.Instance().CMSUserExtra_Get_By_User(portalConnect, userName, PortalID))
    End Function
#End Region
#Region "CMS_KhuCongNghiep"

    Public Shared Function CMS_KhuCongNghiep_Get(PortalConnect As String, industrialZone_ID As String) As CMS_KhuCongNghiepInfo
        Return CBO.FillObject(Of CMS_KhuCongNghiepInfo)(DataProvider.Instance().CMS_KhuCongNghiep_Get(PortalConnect, industrialZone_ID))
    End Function
    Public Shared Function CMS_KhuCongNghiep_List(PortalConnect As String, parentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhuCongNghiep_List(PortalConnect, parentId), GetType(CMS_KhuCongNghiepInfo))
    End Function
    Public Shared Function CMS_KhuCongNghiep_List_ByTP(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, parentId As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhuCongNghiep_List_ByTP(PortalConnect, tinhTp, quanHuyen, parentId), GetType(CMS_KhuCongNghiepInfo))
    End Function
    Public Shared Function CMS_KhuCongNghiep_List_Search(PortalConnect As String, search As String, isOrder As Integer, parent_ID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_KhuCongNghiep_List_Search(PortalConnect, search, isOrder, parent_ID, currPage, recodperpage), GetType(CMS_KhuCongNghiepInfo))
    End Function

    Public Shared Sub CMS_KhuCongNghiep_Add(PortalConnect As String, obj As CMS_KhuCongNghiepInfo)
        DataProvider.Instance().CMS_KhuCongNghiep_Add(PortalConnect, obj.IndustrialZone_ID, obj.TinhTP, obj.QuanHuyen, obj.IndustrialZone_Name, obj.IndustrialZone_Code, obj.IndustrialZone_Des, obj.Parent_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub

    Public Shared Sub CMS_KhuCongNghiep_Update(PortalConnect As String, obj As CMS_KhuCongNghiepInfo)
        DataProvider.Instance().CMS_KhuCongNghiep_Update(PortalConnect, obj.IndustrialZone_ID, obj.TinhTP, obj.QuanHuyen, obj.IndustrialZone_Name, obj.IndustrialZone_Code, obj.IndustrialZone_Des, obj.Parent_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Shared Sub CMS_KhuCongNghiep_Delete(PortalConnect As String, industrialZone_ID As String)
        DataProvider.Instance().CMS_KhuCongNghiep_Delete(PortalConnect, industrialZone_ID)
    End Sub
    Public Shared Sub CMS_KhuCongNghiep_Update_Quick(PortalConnect As String, industrialZone_ID As String, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_KhuCongNghiep_Update_Quick(PortalConnect, industrialZone_ID, isActive, isOrder)
    End Sub
#End Region


End Class
