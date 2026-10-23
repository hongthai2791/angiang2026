Imports DotNetNuke
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Security.Permissions
Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Services.Log.EventLog
Imports DotNetNuke.Entities.Modules.Definitions
Imports DotNetNuke.Services.Localization
Imports DotNetNuke.Common.Utilities

Public Class AutoTabID

	Dim objPer As TabPermissionInfo
	Dim desktopModuleId As Integer
    Dim TabModuleID As Integer, str() As String

#Region "Function"
    Public Sub SkinCon_Src(PortalConnect As Integer, drSkin As DropDownList, drContainer As DropDownList)
        drSkin.Items.Clear() : drContainer.Items.Clear()

        For Each Cr As CMSConnectionInfo In flDnn.CMSConnection_List_By_PortalID(PortalConnect)
            drContainer.Items.Add(New ListItem(Cr.Container_Src, Cr.Container_Src))

            Dim allFiles() As System.IO.FileInfo
            Dim dirinfo As IO.DirectoryInfo = New IO.DirectoryInfo(Web.HttpContext.Current.Server.MapPath("/Portals/_default/Skins/" & Cr.Skin_Src))
            allFiles = dirinfo.GetFiles()
            For i As Integer = 0 To allFiles.Length - 1
                If flReg.GetFileType(allFiles(i).Name, ".").ToLower = "ascx" Then
                    drSkin.Items.Add(New ListItem("[G]Skins/" & Cr.Skin_Src & "/" & allFiles(i).Name, "[G]Skins/" & Cr.Skin_Src & "/" & allFiles(i).Name))
                End If
            Next
            drSkin.SelectedValue = "[G]Skins/" & Cr.Skin_Src & "/Default.ascx"
        Next
    End Sub
    Public Sub Module_Title(dr As DropDownList)
        dr.Items.Clear()
        dr.Items.Add(New ListItem("News Viewer", "AddModule"))
    End Sub
    Public Sub PermissionUser(PortalConnect As String, tabID As Integer)
        Try
            flDnn.DeleteTabPermissionsByTabID(PortalConnect, tabID)
        Catch ex As Exception
        End Try
        Try
            objPer = New TabPermissionInfo()
            objPer.PermissionID = 4
            objPer.PermissionKey = "EDIT"
            objPer.PermissionName = "Edit Tab"
            objPer.AllowAccess = True
            objPer.RoleID = 0
            objPer.TabID = tabID

            flDnn.AddTabPermission(PortalConnect, objPer)

            objPer = New TabPermissionInfo()
            objPer.PermissionID = 3
            objPer.PermissionKey = "VIEW"
            objPer.PermissionName = "View Tab"
            objPer.AllowAccess = True
            objPer.TabID = tabID
            objPer.RoleID = -1
            flDnn.AddTabPermission(PortalConnect, objPer)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DoAddNewModule(PortalId As Integer, ByVal tabID As Integer, ByVal moduleName As String,
                              ByVal desktopModuleId As Integer, ByVal paneName As String, ByVal Location As Integer,
                              ByVal permissionType As Integer, ByVal align As String)
        Dim objTabPermissions As TabPermissionCollection = PortalSettings.Current.ActiveTab.TabPermissions
        Dim objPermissionController = New PermissionController()
        Dim objModules As ModuleController = New ModuleController()
        Dim EventLog As New EventLogController()
        Try
            Dim desktopModule As New DesktopModuleInfo
            If Not DesktopModuleController.GetDesktopModules(PortalId).TryGetValue(desktopModuleId, desktopModule) Then
                Throw New ArgumentException("desktopModuleId")
            End If
        Catch ex As Exception

        End Try

        For Each objModuleDefinition As ModuleDefinitionInfo In ModuleDefinitionController.GetModuleDefinitionsByDesktopModuleID(desktopModuleId).Values
            Dim objModule = New ModuleInfo()
            objModule.Initialize(PortalSettings.Current.ActiveTab.PortalID)

            objModule.PortalID = PortalSettings.Current.ActiveTab.PortalID
            objModule.TabID = tabID
            objModule.ModuleOrder = Location
            objModule.ModuleTitle = If(String.IsNullOrEmpty(moduleName), objModuleDefinition.FriendlyName, moduleName)
            objModule.PaneName = paneName
            objModule.ModuleDefID = objModuleDefinition.ModuleDefID
            If objModuleDefinition.DefaultCacheTime > 0 Then
                objModule.CacheTime = objModuleDefinition.DefaultCacheTime
                If PortalSettings.Current.DefaultModuleId > Null.NullInteger AndAlso PortalSettings.Current.DefaultTabId > Null.NullInteger Then
                    Dim defaultModule As ModuleInfo = objModules.GetModule(PortalSettings.Current.DefaultModuleId, PortalSettings.Current.DefaultTabId, True)
                    If (defaultModule IsNot Nothing) Then
                        objModule.CacheTime = defaultModule.CacheTime
                    End If
                End If
            End If
            Select Case permissionType
                Case 0
                    objModule.InheritViewPermissions = True
                    Exit Select
                Case 1
                    objModule.InheritViewPermissions = False
                    Exit Select
            End Select
            Dim arrSystemModuleViewPermissions As ArrayList = objPermissionController.GetPermissionByCodeAndKey("SYSTEM_MODULE_DEFINITION", "VIEW")
            For Each objTabPermission As TabPermissionInfo In objTabPermissions
                If objTabPermission.PermissionKey = "VIEW" AndAlso permissionType = 0 Then
                    Continue For
                End If
                Dim arrSystemModulePermissions As ArrayList = objPermissionController.GetPermissionByCodeAndKey("SYSTEM_MODULE_DEFINITION", objTabPermission.PermissionKey)
                Dim j As Integer
                For j = 0 To arrSystemModulePermissions.Count - 1
                    Dim objSystemModulePermission = DirectCast(arrSystemModulePermissions(j), PermissionInfo)
                    If objSystemModulePermission.PermissionKey = "VIEW" AndAlso permissionType = 1 AndAlso objTabPermission.PermissionKey <> "EDIT" Then
                        Continue For
                    End If
                    Dim objModulePermission As ModulePermissionInfo = AddModulePermission(objModule, objSystemModulePermission, objTabPermission.RoleID, objTabPermission.UserID, objTabPermission.AllowAccess)
                    If objModulePermission.PermissionKey = "EDIT" AndAlso objModulePermission.AllowAccess Then
                        AddModulePermission(objModule, DirectCast(arrSystemModuleViewPermissions(0), PermissionInfo), objModulePermission.RoleID, objModulePermission.UserID, True)
                    End If
                Next
                If objTabPermission.PermissionKey = "EDIT" Then
                    Dim arrCustomModulePermissions As ArrayList = objPermissionController.GetPermissionsByModuleDefID(objModule.ModuleDefID)
                    For j = 0 To arrCustomModulePermissions.Count - 1
                        Dim objCustomModulePermission = DirectCast(arrCustomModulePermissions(j), PermissionInfo)
                        AddModulePermission(objModule, objCustomModulePermission, objTabPermission.RoleID, objTabPermission.UserID, objTabPermission.AllowAccess)
                    Next
                End If
            Next
            If PortalSettings.Current.ContentLocalizationEnabled Then
                Dim defaultLocale As Locale = LocaleController.Instance.GetDefaultLocale(PortalSettings.Current.PortalId)
                If New Entities.Tabs.TabController().GetTabByCulture(objModule.TabID, PortalSettings.Current.PortalId, defaultLocale) IsNot Nothing Then
                    objModule.CultureCode = defaultLocale.Code
                Else
                    objModule.CultureCode = PortalSettings.Current.CultureCode
                End If
            Else
                objModule.CultureCode = Null.NullString
            End If
            objModule.AllTabs = False
            objModule.Alignment = align
            TabModuleID = objModules.AddModule(objModule)
        Next
    End Sub
    Private Function AddModulePermission(ByVal objModule As ModuleInfo, ByVal permission As PermissionInfo, ByVal roleId As Integer, ByVal userId As Integer, ByVal allowAccess As Boolean) As ModulePermissionInfo
        Dim objModulePermission As ModulePermissionInfo = New ModulePermissionInfo()
        objModulePermission.ModuleID = objModule.ModuleID
        objModulePermission.PermissionID = permission.PermissionID
        objModulePermission.RoleID = roleId
        objModulePermission.UserID = userId
        objModulePermission.PermissionKey = permission.PermissionKey
        objModulePermission.AllowAccess = allowAccess

        If Not objModule.ModulePermissions.Contains(objModulePermission) Then
            objModule.ModulePermissions.Add(objModulePermission)
        End If
        Return objModulePermission
    End Function
    Public Function InsertModule(portalID As Integer, ByVal tabID As Integer, moduleName As String) As Integer
        desktopModuleId = flDnn.DNN_GetDesktopModulesID(portalID, moduleName)
        TabModuleID = 0
        Call DoAddNewModule(portalID, tabID, moduleName, desktopModuleId, "ContentPane", 1, 0, "")
        Return TabModuleID
    End Function 'Save Module home
    Public Function InsertTab(PortalConnect As String, PortalId As Integer, ByVal Title As String, Description As String, ByVal tabName As String, ByVal TabParentID As Integer, SkinSrc As String, ContainerSrc As String) As Integer
        Try
            Dim tab = New DotNetNuke.Entities.Tabs.TabInfo()
            tab.ContentItemId = flDnn.DNN_ContentItems_Add(PortalConnect, Title)
            tab.PortalID = PortalId
            tab.TabName = tabName.ToLower
            tab.ParentId = TabParentID
            tab.Title = Title
            tab.Description = Description
            tab.KeyWords = Title
            tab.IsVisible = False
            tab.DisableLink = False
            tab.IconFile = ""
            tab.IconFileLarge = ""
            tab.IsDeleted = False
            tab.Url = ""
            tab.SkinSrc = SkinSrc
            tab.ContainerSrc = ContainerSrc
            tab.CultureCode = ""
            tab.Level = 0
            tab.TabPath = flDnn.GetTabPath(PortalConnect, TabParentID, PortalId) & "//" & tab.TabName

            tab.StartDate = Nothing
            tab.EndDate = Nothing
            tab.RefreshInterval = -1
            tab.SiteMapPriority = 0.5
            tab.PageHeadText = ""
            tab.IsSecure = False
            tab.PermanentRedirect = False
            tab.TabID = flDnn.AddTab(PortalConnect, tab)
            flDnn.DNN_ContentItems_Update_Tabid(PortalConnect, tab.ContentItemId, tab.TabID)
            flDnn.DNN_TabHasBeenPublished(PortalConnect, tab.TabID)

            Call PermissionUser(PortalConnect, tab.TabID)
            Return tab.TabID
        Catch ex As Exception
            Return 0
        End Try
    End Function '

#End Region

End Class

