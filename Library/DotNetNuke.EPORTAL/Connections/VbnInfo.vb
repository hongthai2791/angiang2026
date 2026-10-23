Imports DotNetNuke.Common.Utilities
Public Class DnnInfo

#Region "Private Members"
	Private _paneName As String = String.Empty
	Private _userID As Integer
	Private _fileID As Integer
	Private _folder As String = String.Empty
	Private _fileName As String = String.Empty
	Private _desktopModuleID As Integer
	Private _restPassWordId As String = String.Empty
	Private _portalID As Integer
	Private _username As String = String.Empty
	Private _email As String = String.Empty
	Private _endDate As DateTime
	Private _isReset As Boolean
	Private _startReset As DateTime
	Private _hTTPAlias As String = String.Empty
	Private _portalName As String = String.Empty
	Private _tabid As Integer
	Private _tabName As String = String.Empty
	Private _title As String = String.Empty
	Private _description As String = String.Empty
	Private _tabModuleID As Integer
	Private _TabPath As String = String.Empty
	Private _moduleOrder As Integer
	Private _moduleTitle As String = String.Empty
	Private _settingValue As String = String.Empty
	Private _lastName As String = String.Empty
	Private _firstName As String = String.Empty
	Private _displayName As String = String.Empty
	Private _fullName As String = String.Empty
	Private _createdOnDate As DateTime
	Private _DateOfBirth As DateTime
	Private _total As Integer
	Private _rowNum As Integer
	Private _isDeleted As Boolean
	Private _isDeletedUser As Boolean
	Private _telephone As String = String.Empty
	Private _Position As String = String.Empty
	Private _Provinder As String = String.Empty
	Private _KeyValue As String = String.Empty
	Private _SettingName As String = String.Empty
	Private _address As String = String.Empty
    Private _IsSex As Integer
    Private _ProvinID As Integer
#End Region

#Region "Public Properties"
    Public Property Address As String
		Get
			Return _address
		End Get
		Set(ByVal Value As String)
			_address = Value
		End Set
	End Property
	Public Property DateOfBirth As DateTime
		Get
			Return _DateOfBirth
		End Get
		Set(ByVal Value As DateTime)
			_DateOfBirth = Value
		End Set
	End Property
	Public Property PaneName As String
		Get
			Return _paneName
		End Get
		Set(ByVal Value As String)
			_paneName = Value
		End Set
	End Property
    Public Property IsSex As Integer
        Get
            Return _IsSex
        End Get
        Set(ByVal Value As Integer)
            _IsSex = Value
        End Set
    End Property
    Public Property ProvinID As Integer
        Get
            Return _ProvinID
        End Get
        Set(ByVal Value As Integer)
            _ProvinID = Value
        End Set
    End Property
    Public Property SettingName As String
		Get
			Return _SettingName
		End Get
		Set(ByVal Value As String)
			_SettingName = Value
		End Set
	End Property
	Public Property TabPath As String
		Get
			Return _TabPath
		End Get
		Set(ByVal Value As String)
			_TabPath = Value
		End Set
	End Property
	Public Property KeyValue As String
		Get
			Return _KeyValue
		End Get
		Set(ByVal Value As String)
			_KeyValue = Value
		End Set
	End Property
	Public Property Provinder As String
		Get
			Return _Provinder
		End Get
		Set(ByVal Value As String)
			_Provinder = Value
		End Set
	End Property
	Public Property Position As String
		Get
			Return _Position
		End Get
		Set(ByVal Value As String)
			_Position = Value
		End Set
	End Property
	Public Property Telephone As String
		Get
			Return _telephone
		End Get
		Set(ByVal Value As String)
			_telephone = Value
		End Set
	End Property
	Public Property IsDeleted As Boolean
		Get
			Return _isDeleted
		End Get
		Set(ByVal Value As Boolean)
			_isDeleted = Value
		End Set
	End Property
	Public Property IsDeletedUser As Boolean
		Get
			Return _isDeletedUser
		End Get
		Set(ByVal Value As Boolean)
			_isDeletedUser = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
	Public Property RowNum As Integer
		Get
			Return _rowNum
		End Get
		Set(ByVal Value As Integer)
			_rowNum = Value
		End Set
	End Property
	Public Property UserID As Integer
		Get
			Return _userID
		End Get
		Set(ByVal Value As Integer)
			_userID = Value
		End Set
	End Property
	Public Property FileID As Integer
		Get
			Return _fileID
		End Get
		Set(ByVal Value As Integer)
			_fileID = Value
		End Set
	End Property
	Public Property Folder As String
		Get
			Return _folder
		End Get
		Set(ByVal Value As String)
			_folder = Value
		End Set
	End Property
	Public Property FullName As String
		Get
			Return _fullName
		End Get
		Set(ByVal Value As String)
			_fullName = Value
		End Set
	End Property
	Public Property FileName As String
		Get
			Return _fileName
		End Get
		Set(ByVal Value As String)
			_fileName = Value
		End Set
	End Property
	Public Property DesktopModuleID As Integer
		Get
			Return _desktopModuleID
		End Get
		Set(ByVal Value As Integer)
			_desktopModuleID = Value
		End Set
	End Property
	Public Property RestPassWordId As String
		Get
			Return _restPassWordId
		End Get
		Set(ByVal Value As String)
			_restPassWordId = Value
		End Set
	End Property
	Public Property PortalID As Integer
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Integer)
			_portalID = Value
		End Set
	End Property
	Public Property Username As String
		Get
			Return _username
		End Get
		Set(ByVal Value As String)
			_username = Value
		End Set
	End Property
	Public Property Email As String
		Get
			Return _email
		End Get
		Set(ByVal Value As String)
			_email = Value
		End Set
	End Property
	Public Property EndDate() As DateTime
		Get
			Return _endDate
		End Get
		Set(ByVal Value As DateTime)
			_endDate = Value
		End Set
	End Property
	Public Property IsReset() As Boolean
		Get
			Return _isReset
		End Get
		Set(ByVal Value As Boolean)
			_isReset = Value
		End Set
	End Property
	Public Property StartReset() As DateTime
		Get
			Return _startReset
		End Get
		Set(ByVal Value As DateTime)
			_startReset = Value
		End Set
	End Property
	Public Property HTTPAlias As String
		Get
			Return _hTTPAlias
		End Get
		Set(ByVal Value As String)
			_hTTPAlias = Value
		End Set
	End Property
	Public Property PortalName As String
		Get
			Return _portalName
		End Get
		Set(ByVal Value As String)
			_portalName = Value
		End Set
	End Property
	Public Property Tabid As Integer
		Get
			Return _tabid
		End Get
		Set(ByVal Value As Integer)
			_tabid = Value
		End Set
	End Property
	Public Property TabName As String
		Get
			Return _tabName
		End Get
		Set(ByVal Value As String)
			_tabName = Value
		End Set
	End Property
	Public Property Title As String
		Get
			Return _title
		End Get
		Set(ByVal Value As String)
			_title = Value
		End Set
	End Property
	Public Property Description As String
		Get
			Return _description
		End Get
		Set(ByVal Value As String)
			_description = Value
		End Set
	End Property
	Public Property TabModuleID As Integer
		Get
			Return _tabModuleID
		End Get
		Set(ByVal Value As Integer)
			_tabModuleID = Value
		End Set
	End Property
	Public Property ModuleOrder As Integer
		Get
			Return _moduleOrder
		End Get
		Set(ByVal Value As Integer)
			_moduleOrder = Value
		End Set
	End Property
	Public Property ModuleTitle As String
		Get
			Return _moduleTitle
		End Get
		Set(ByVal Value As String)
			_moduleTitle = Value
		End Set
	End Property
	Public Property SettingValue As String
		Get
			Return _settingValue
		End Get
		Set(ByVal Value As String)
			_settingValue = Value
		End Set
	End Property
	Public Property LastName As String
		Get
			Return _lastName
		End Get
		Set(ByVal Value As String)
			_lastName = Value
		End Set
	End Property
	Public Property FirstName As String
		Get
			Return _firstName
		End Get
		Set(ByVal Value As String)
			_firstName = Value
		End Set
	End Property
	Public Property DisplayName As String
		Get
			Return _displayName
		End Get
		Set(ByVal Value As String)
			_displayName = Value
		End Set
	End Property
	Public Property CreatedOnDate() As DateTime
		Get
			Return _createdOnDate
		End Get
		Set(ByVal Value As DateTime)
			_createdOnDate = Value
		End Set
	End Property
#End Region

End Class
Public Class CMSConnectionInfo
	Public Property ID As Integer
	Public Property PortalID As Integer
	Public Property DnnConnect As String
	Public Property DnnFrontEnd As String
	Public Property WebDomain As String
	Public Property Skin_Src As String
	Public Property Container_Src As String

End Class
Public Class CMS_SettingsInfo

#Region "Private Members"
	Private _setting_ID As String = String.Empty
	Private _setting_Key As String = String.Empty
	Private _setting_Value As String = String.Empty
	Private _SubMod As String = String.Empty
	Private _setting_Page As String = String.Empty
	Private _createdBy As DateTime
	Private _userName As String = String.Empty
	Private _updatedBy As DateTime
	Private _updatedUser As String = String.Empty
#End Region

#Region "Public Properties"
	Public Property SubMod As String
		Get
			Return _SubMod
		End Get
		Set(ByVal Value As String)
			_SubMod = Value
		End Set
	End Property
	Public Property Setting_ID As String
		Get
			Return _setting_ID
		End Get
		Set(ByVal Value As String)
			_setting_ID = Value
		End Set
	End Property
	Public Property Setting_Key As String
		Get
			Return _setting_Key
		End Get
		Set(ByVal Value As String)
			_setting_Key = Value
		End Set
	End Property
	Public Property Setting_Value As String
		Get
			Return _setting_Value
		End Get
		Set(ByVal Value As String)
			_setting_Value = Value
		End Set
	End Property
	Public Property Setting_Page As String
		Get
			Return _setting_Page
		End Get
		Set(ByVal Value As String)
			_setting_Page = Value
		End Set
	End Property
	Public Property CreatedBy() As DateTime
		Get
			Return _createdBy
		End Get
		Set(ByVal Value As DateTime)
			_createdBy = Value
		End Set
	End Property
	Public Property UserName As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property UpdatedBy() As DateTime
		Get
			Return _updatedBy
		End Get
		Set(ByVal Value As DateTime)
			_updatedBy = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
#End Region

End Class
Public Class CMSCookieInfo

#Region "Private Members"
	Private _idKey As String = String.Empty
	Private _idValue As String = String.Empty
	Private _userName As String = String.Empty
	Private _crtVal As String = String.Empty
	Private _crtDate As DateTime
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property IdKey As String
		Get
			Return _idKey
		End Get
		Set(ByVal Value As String)
			_idKey = Value
		End Set
	End Property

	Public Property IdValue As String
		Get
			Return _idValue
		End Get
		Set(ByVal Value As String)
			_idValue = Value
		End Set
	End Property
	Public Property UserName As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property CrtVal As String
		Get
			Return _crtVal
		End Get
		Set(ByVal Value As String)
			_crtVal = Value
		End Set
	End Property
	Public Property CrtDate() As DateTime
		Get
			Return _crtDate
		End Get
		Set(ByVal Value As DateTime)
			_crtDate = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_ModuleInfo

#Region "Private Members"
	Private _module_ID As String = String.Empty
	Private _moduleSrc As String = String.Empty
	Private _moduleName As String = String.Empty
	Private _subMod As String = String.Empty
	Private _isAdmin As Boolean
	Private _isUser As Boolean
	Private _status As Boolean
	Private _ctlView As String = String.Empty
	Private _ctlEdit As String = String.Empty
	Private _img As String = String.Empty
	Private _isOrder As Integer
	Private _setup As Boolean
	Private _parent_ID As String = String.Empty
	Private _total As Integer
	Private _isDelete As Boolean
#End Region

#Region "Public Properties"
	Public Property SubMod As String
		Get
			Return _subMod
		End Get
		Set(ByVal Value As String)
			_subMod = Value
		End Set
	End Property
	Public Property IsDelete() As Boolean
		Get
			Return _isDelete
		End Get
		Set(ByVal Value As Boolean)
			_isDelete = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Module_ID As String
		Get
			Return _module_ID
		End Get
		Set(ByVal Value As String)
			_module_ID = Value
		End Set
	End Property

	Public Property ModuleSrc As String
		Get
			Return _moduleSrc
		End Get
		Set(ByVal Value As String)
			_moduleSrc = Value
		End Set
	End Property
	Public Property ModuleName As String
		Get
			Return _moduleName
		End Get
		Set(ByVal Value As String)
			_moduleName = Value
		End Set
	End Property
	Public Property IsAdmin() As Boolean
		Get
			Return _isAdmin
		End Get
		Set(ByVal Value As Boolean)
			_isAdmin = Value
		End Set
	End Property
	Public Property IsUser() As Boolean
		Get
			Return _isUser
		End Get
		Set(ByVal Value As Boolean)
			_isUser = Value
		End Set
	End Property
	Public Property Status() As Boolean
		Get
			Return _status
		End Get
		Set(ByVal Value As Boolean)
			_status = Value
		End Set
	End Property
	Public Property ctlView As String
		Get
			Return _ctlView
		End Get
		Set(ByVal Value As String)
			_ctlView = Value
		End Set
	End Property
	Public Property ctlEdit As String
		Get
			Return _ctlEdit
		End Get
		Set(ByVal Value As String)
			_ctlEdit = Value
		End Set
	End Property
	Public Property Img As String
		Get
			Return _img
		End Get
		Set(ByVal Value As String)
			_img = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property Setup() As Boolean
		Get
			Return _setup
		End Get
		Set(ByVal Value As Boolean)
			_setup = Value
		End Set
	End Property
	Public Property Parent_ID As String
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As String)
			_parent_ID = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_UserConfigInfo

#Region "Private Members"
	Private _userConfig_ID As Integer
	Private _subMod As String = String.Empty
	Private _userName As String = String.Empty
	Private _moduleSrc As String = String.Empty
	Private _portalID As Integer
	Private _tinhTP As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"
	Public Property SubMod As String
		Get
			Return _subMod
		End Get
		Set(ByVal Value As String)
			_subMod = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
	Public Property UserConfig_ID As Integer
		Get
			Return _userConfig_ID
		End Get
		Set(ByVal Value As Integer)
			_userConfig_ID = Value
		End Set
	End Property
	Public Property UserName As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property ModuleSrc As String
		Get
			Return _moduleSrc
		End Get
		Set(ByVal Value As String)
			_moduleSrc = Value
		End Set
	End Property
	Public Property PortalID As Integer
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Integer)
			_portalID = Value
		End Set
	End Property
	Public Property TinhTP As Integer
		Get
			Return _tinhTP
		End Get
		Set(ByVal Value As Integer)
			_tinhTP = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RolesInfo

#Region "Private Members"
	Private _roles_ID As Integer
	Private _subMod_ID As Integer
	Private _roles_Name As String = String.Empty
	Private _roles_Code As String = String.Empty
	Private _roles_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Roles_ID As Integer
		Get
			Return _roles_ID
		End Get
		Set(ByVal Value As Integer)
			_roles_ID = Value
		End Set
	End Property

	Public Property SubMod_ID As Integer
		Get
			Return _subMod_ID
		End Get
		Set(ByVal Value As Integer)
			_subMod_ID = Value
		End Set
	End Property
	Public Property Roles_Code As String
		Get
			Return _roles_Code
		End Get
		Set(ByVal Value As String)
			_roles_Code = Value
		End Set
	End Property
	Public Property Roles_Name As String
		Get
			Return _roles_Name
		End Get
		Set(ByVal Value As String)
			_roles_Name = Value
		End Set
	End Property
	Public Property Roles_Des As String
		Get
			Return _roles_Des
		End Get
		Set(ByVal Value As String)
			_roles_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_SubModInfo

#Region "Private Members"
	Private _subMod_ID As Integer
	Private _subMod_Path As String = String.Empty
	Private _subMod_Name As String = String.Empty
	Private _subMod_Img As String = String.Empty
	Private _subMod_Order As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property SubMod_PID As Integer
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property SubMod_ID As Integer
		Get
			Return _subMod_ID
		End Get
		Set(ByVal Value As Integer)
			_subMod_ID = Value
		End Set
	End Property

	Public Property SubMod_Path As String
		Get
			Return _subMod_Path
		End Get
		Set(ByVal Value As String)
			_subMod_Path = Value
		End Set
	End Property
	Public Property SubMod_Name As String
		Get
			Return _subMod_Name
		End Get
		Set(ByVal Value As String)
			_subMod_Name = Value
		End Set
	End Property
	Public Property SubMod_Img As String
		Get
			Return _subMod_Img
		End Get
		Set(ByVal Value As String)
			_subMod_Img = Value
		End Set
	End Property
	Public Property SubMod_Order As Integer
		Get
			Return _subMod_Order
		End Get
		Set(ByVal Value As Integer)
			_subMod_Order = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_NationInfo

#Region "Private Members"
	Private _nation_ID As Integer
	Private _nation_Code As String = String.Empty
	Private _nation_Name As String = String.Empty
	Private _nation_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Nation_ID As Integer
		Get
			Return _nation_ID
		End Get
		Set(ByVal Value As Integer)
			_nation_ID = Value
		End Set
	End Property

	Public Property Nation_Code As String
		Get
			Return _nation_Code
		End Get
		Set(ByVal Value As String)
			_nation_Code = Value
		End Set
	End Property
	Public Property Nation_Name As String
		Get
			Return _nation_Name
		End Get
		Set(ByVal Value As String)
			_nation_Name = Value
		End Set
	End Property
	Public Property Nation_Des As String
		Get
			Return _nation_Des
		End Get
		Set(ByVal Value As String)
			_nation_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_NationalInfo

#Region "Private Members"
	Private _national_ID As Integer
	Private _national_Code As String = String.Empty
	Private _national_Name As String = String.Empty
	Private _national_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property National_ID As Integer
		Get
			Return _national_ID
		End Get
		Set(ByVal Value As Integer)
			_national_ID = Value
		End Set
	End Property

	Public Property National_Code As String
		Get
			Return _national_Code
		End Get
		Set(ByVal Value As String)
			_national_Code = Value
		End Set
	End Property
	Public Property National_Name As String
		Get
			Return _national_Name
		End Get
		Set(ByVal Value As String)
			_national_Name = Value
		End Set
	End Property
	Public Property National_Des As String
		Get
			Return _national_Des
		End Get
		Set(ByVal Value As String)
			_national_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_PositionInfo

#Region "Private Members"
	Private _position_ID As Integer
	Private _position_Code As String = String.Empty
	Private _position_Name As String = String.Empty
	Private _position_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
    Private _total As Integer
    Private _id As Integer
#End Region

#Region "Public Properties"

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Position_ID As Integer
		Get
			Return _position_ID
		End Get
		Set(ByVal Value As Integer)
			_position_ID = Value
		End Set
	End Property

	Public Property Position_Code As String
		Get
			Return _position_Code
		End Get
		Set(ByVal Value As String)
			_position_Code = Value
		End Set
	End Property
	Public Property Position_Name As String
		Get
			Return _position_Name
		End Get
		Set(ByVal Value As String)
			_position_Name = Value
		End Set
	End Property
	Public Property Position_Des As String
		Get
			Return _position_Des
		End Get
		Set(ByVal Value As String)
			_position_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RegionalInfo

#Region "Private Members"
	Private _regional_ID As Integer
	Private _regional_Code As String = String.Empty
	Private _regional_Name As String = String.Empty
	Private _regional_Des As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _deletedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
	Private _areaID As Integer
#End Region

#Region "Public Properties"
	Public Property DeletedDate As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property

	Public Property AreaID As Integer
		Get
			Return _areaID
		End Get
		Set(ByVal Value As Integer)
			_areaID = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Regional_ID As Integer
		Get
			Return _regional_ID
		End Get
		Set(ByVal Value As Integer)
			_regional_ID = Value
		End Set
	End Property

	Public Property Regional_Code As String
		Get
			Return _regional_Code
		End Get
		Set(ByVal Value As String)
			_regional_Code = Value
		End Set
	End Property
	Public Property Regional_Name As String
		Get
			Return _regional_Name
		End Get
		Set(ByVal Value As String)
			_regional_Name = Value
		End Set
	End Property
	Public Property Regional_Des As String
		Get
			Return _regional_Des
		End Get
		Set(ByVal Value As String)
			_regional_Des = Value
		End Set
	End Property
	Public Property Parent_ID As Integer
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As Integer)
			_parent_ID = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_ReligionInfo

#Region "Private Members"
	Private _religion_ID As Integer
	Private _religion_Code As String = String.Empty
	Private _religion_Name As String = String.Empty
	Private _religion_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Religion_ID As Integer
		Get
			Return _religion_ID
		End Get
		Set(ByVal Value As Integer)
			_religion_ID = Value
		End Set
	End Property

	Public Property Religion_Code As String
		Get
			Return _religion_Code
		End Get
		Set(ByVal Value As String)
			_religion_Code = Value
		End Set
	End Property
	Public Property Religion_Name As String
		Get
			Return _religion_Name
		End Get
		Set(ByVal Value As String)
			_religion_Name = Value
		End Set
	End Property
	Public Property Religion_Des As String
		Get
			Return _religion_Des
		End Get
		Set(ByVal Value As String)
			_religion_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_LanguageInfo

#Region "Private Members"
	Private _Language_ID As Integer
	Private _Language_Code As String = String.Empty
	Private _Language_Name As String = String.Empty
	Private _Language_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Language_ID As Integer
		Get
			Return _Language_ID
		End Get
		Set(ByVal Value As Integer)
			_Language_ID = Value
		End Set
	End Property

	Public Property Language_Code As String
		Get
			Return _Language_Code
		End Get
		Set(ByVal Value As String)
			_Language_Code = Value
		End Set
	End Property
	Public Property Language_Name As String
		Get
			Return _Language_Name
		End Get
		Set(ByVal Value As String)
			_Language_Name = Value
		End Set
	End Property
	Public Property Language_Des As String
		Get
			Return _Language_Des
		End Get
		Set(ByVal Value As String)
			_Language_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_EducationInfo

#Region "Private Members"
	Private _Education_ID As Integer
	Private _Education_Code As String = String.Empty
	Private _Education_Name As String = String.Empty
	Private _Education_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
    Private _total As Integer
    Private _idSend As Integer
#End Region

#Region "Public Properties"

    Public Property IdSend As Integer
        Get
            Return _idSend
        End Get
        Set(ByVal Value As Integer)
            _idSend = Value
        End Set
    End Property
    Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Education_ID As Integer
		Get
			Return _Education_ID
		End Get
		Set(ByVal Value As Integer)
			_Education_ID = Value
		End Set
	End Property

	Public Property Education_Code As String
		Get
			Return _Education_Code
		End Get
		Set(ByVal Value As String)
			_Education_Code = Value
		End Set
	End Property
	Public Property Education_Name As String
		Get
			Return _Education_Name
		End Get
		Set(ByVal Value As String)
			_Education_Name = Value
		End Set
	End Property
	Public Property Education_Des As String
		Get
			Return _Education_Des
		End Get
		Set(ByVal Value As String)
			_Education_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RelationInfo

#Region "Private Members"
	Private _Relation_ID As Integer
	Private _Relation_Code As String = String.Empty
	Private _Relation_Name As String = String.Empty
	Private _Relation_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Relation_ID As Integer
		Get
			Return _Relation_ID
		End Get
		Set(ByVal Value As Integer)
			_Relation_ID = Value
		End Set
	End Property

	Public Property Relation_Code As String
		Get
			Return _Relation_Code
		End Get
		Set(ByVal Value As String)
			_Relation_Code = Value
		End Set
	End Property
	Public Property Relation_Name As String
		Get
			Return _Relation_Name
		End Get
		Set(ByVal Value As String)
			_Relation_Name = Value
		End Set
	End Property
	Public Property Relation_Des As String
		Get
			Return _Relation_Des
		End Get
		Set(ByVal Value As String)
			_Relation_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMSCacheInfo

#Region "Private Members"
	Private _id As Integer
	Private _CacheName As String = String.Empty
	Private _iP As String = String.Empty
	Private _portalID As Integer
#End Region

#Region "Public Properties"
	Public Property PortalID As Integer
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Integer)
			_portalID = Value
		End Set
	End Property
	Public Property Id As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
			_id = Value
		End Set
	End Property
	Public Property CacheName As String
		Get
			Return _CacheName
		End Get
		Set(ByVal Value As String)
			_CacheName = Value
		End Set
	End Property
	Public Property IP As String
		Get
			Return _iP
		End Get
		Set(ByVal Value As String)
			_iP = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_BuglogInfo

#Region "Private Members"
	Private _buglog_ID As Integer
	Private _contents As String = String.Empty
	Private _resolve As String = String.Empty
	Private _createDate As DateTime
	Private _tabName As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"
	Public Property Resolve As String
		Get
			Return _resolve
		End Get
		Set(ByVal Value As String)
			_resolve = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Buglog_ID As Integer
		Get
			Return _buglog_ID
		End Get
		Set(ByVal Value As Integer)
			_buglog_ID = Value
		End Set
	End Property

	Public Property Contents As String
		Get
			Return _contents
		End Get
		Set(ByVal Value As String)
			_contents = Value
		End Set
	End Property
	Public Property CreateDate() As DateTime
		Get
			Return _createDate
		End Get
		Set(ByVal Value As DateTime)
			_createDate = Value
		End Set
	End Property
	Public Property TabName As String
		Get
			Return _tabName
		End Get
		Set(ByVal Value As String)
			_tabName = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_ActiveDomainInfo

#Region "Private Members"
	Private _domain_ID As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _domainName As String = String.Empty
	Private _ghiChu As String = String.Empty
	Private _activeDate As DateTime
	Private _expriteDate As DateTime
	Private _isActive As Boolean
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
	Public Property Domain_ID() As Integer
		Get
			Return _domain_ID
		End Get
		Set(ByVal Value As Integer)
			_domain_ID = Value
		End Set
	End Property
	Public Property MaTinh() As Integer
		Get
			Return _maTinh
		End Get
		Set(ByVal Value As Integer)
			_maTinh = Value
		End Set
	End Property
	Public Property MaHuyen() As Integer
		Get
			Return _maHuyen
		End Get
		Set(ByVal Value As Integer)
			_maHuyen = Value
		End Set
	End Property
	Public Property DomainName() As String
		Get
			Return _domainName
		End Get
		Set(ByVal Value As String)
			_domainName = Value
		End Set
	End Property
	Public Property GhiChu() As String
		Get
			Return _ghiChu
		End Get
		Set(ByVal Value As String)
			_ghiChu = Value
		End Set
	End Property
	Public Property ActiveDate() As DateTime
		Get
			Return _activeDate
		End Get
		Set(ByVal Value As DateTime)
			_activeDate = Value
		End Set
	End Property
	Public Property ExpriteDate() As DateTime
		Get
			Return _expriteDate
		End Get
		Set(ByVal Value As DateTime)
			_expriteDate = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser() As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser() As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_AreaInfo

#Region "Private Members"
	Private _Area_ID As Integer
	Private _Area_Code As String = String.Empty
	Private _Area_Name As String = String.Empty
	Private _Area_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Area_ID As Integer
		Get
			Return _Area_ID
		End Get
		Set(ByVal Value As Integer)
			_Area_ID = Value
		End Set
	End Property

	Public Property Area_Code As String
		Get
			Return _Area_Code
		End Get
		Set(ByVal Value As String)
			_Area_Code = Value
		End Set
	End Property
	Public Property Area_Name As String
		Get
			Return _Area_Name
		End Get
		Set(ByVal Value As String)
			_Area_Name = Value
		End Set
	End Property
	Public Property Area_Des As String
		Get
			Return _Area_Des
		End Get
		Set(ByVal Value As String)
			_Area_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_PlaceInfo

#Region "Private Members"
	Private _Place_ID As Integer
	Private _Place_Name As String = String.Empty
	Private _Place_Code As String = String.Empty
	Private _Place_Des As String = String.Empty
	Private _isOrder As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _portalId As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Place_ID() As Integer
		Get
			Return _Place_ID
		End Get
		Set(ByVal Value As Integer)
			_Place_ID = Value
		End Set
	End Property

	Public Property Place_Name() As String
		Get
			Return _Place_Name
		End Get
		Set(ByVal Value As String)
			_Place_Name = Value
		End Set
	End Property
	Public Property Place_Code() As String
		Get
			Return _Place_Code
		End Get
		Set(ByVal Value As String)
			_Place_Code = Value
		End Set
	End Property
	Public Property Place_Des() As String
		Get
			Return _Place_Des
		End Get
		Set(ByVal Value As String)
			_Place_Des = Value
		End Set
	End Property
	Public Property IsOrder() As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser() As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser() As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property PortalId() As Integer
		Get
			Return _portalId
		End Get
		Set(ByVal Value As Integer)
			_portalId = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_ConfigTPInfo

#Region "Private Members"
	Private _iD As Integer
	Private _tinhTP As Integer
	Private _PortalLogo As String = String.Empty
	Private _portalName As String = String.Empty
	Private _portalImg As String = String.Empty
	Private _portalAlias As String = String.Empty
	Private _portalDes As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"
	Public Property PortalDes As String
		Get
			Return _portalDes
		End Get
		Set(ByVal Value As String)
			_portalDes = Value
		End Set
	End Property
	Public Property ID As Integer
		Get
			Return _iD
		End Get
		Set(ByVal Value As Integer)
			_iD = Value
		End Set
	End Property
	Public Property TinhTP As Integer
		Get
			Return _tinhTP
		End Get
		Set(ByVal Value As Integer)
			_tinhTP = Value
		End Set
	End Property
	Public Property PortalName As String
		Get
			Return _portalName
		End Get
		Set(ByVal Value As String)
			_portalName = Value
		End Set
	End Property
	Public Property PortalLogo As String
		Get
			Return _PortalLogo
		End Get
		Set(ByVal Value As String)
			_PortalLogo = Value
		End Set
	End Property
	Public Property PortalImg As String
		Get
			Return _portalImg
		End Get
		Set(ByVal Value As String)
			_portalImg = Value
		End Set
	End Property
	Public Property PortalAlias As String
		Get
			Return _portalAlias
		End Get
		Set(ByVal Value As String)
			_portalAlias = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_DayOffInfo

#Region "Private Members"
	Private _dayOff_ID As String = String.Empty
	Private _dayOff_Name As String = String.Empty
	Private _isDay As Integer
	Private _isMonth As Integer
	Private _isYear As Integer
	Private _isOrder As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _total As Integer
#End Region

#Region "Public Properties"
	Public Property DayOff_ID As String
		Get
			Return _dayOff_ID
		End Get
		Set(ByVal Value As String)
			_dayOff_ID = Value
		End Set
	End Property
	Public Property DayOff_Name As String
		Get
			Return _dayOff_Name
		End Get
		Set(ByVal Value As String)
			_dayOff_Name = Value
		End Set
	End Property
	Public Property IsDay As Integer
		Get
			Return _isDay
		End Get
		Set(ByVal Value As Integer)
			_isDay = Value
		End Set
	End Property
	Public Property IsMonth As Integer
		Get
			Return _isMonth
		End Get
		Set(ByVal Value As Integer)
			_isMonth = Value
		End Set
	End Property
	Public Property IsYear As Integer
		Get
			Return _isYear
		End Get
		Set(ByVal Value As Integer)
			_isYear = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property CreatedDate As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
#End Region

End Class
Public Class CMSUserPortalInfo

#Region "Private Members"
	Private _iD As Integer
	Private _UserID As Integer
	Private _userName As String = String.Empty
	Private _subMod As String = String.Empty
	Private _provinID As String = String.Empty
	Private _districtID As String = String.Empty
	Private _wardID As String = String.Empty
	Private _rolesID As String = String.Empty
	Private _portalID As Integer
	Private _gender As Integer
	Private _dateOfBirth As DateTime
	Private _address As String = String.Empty
	Private _email As String = String.Empty
	Private _telephone As String = String.Empty
	Private _displayName As String = String.Empty
	Private _isStatus As Integer
	Private _isWork As Integer
	Private _total As Integer
	Private _CMND As String = String.Empty

#End Region

#Region "Public Properties"
	Public Property UserID As Integer
		Get
			Return _UserID
		End Get
		Set(ByVal Value As Integer)
			_UserID = Value
		End Set
	End Property
	Public Property ID As Integer
		Get
			Return _iD
		End Get
		Set(ByVal Value As Integer)
			_iD = Value
		End Set
	End Property
	Public Property UserName As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property CMND As String
		Get
			Return _CMND
		End Get
		Set(ByVal Value As String)
			_CMND = Value
		End Set
	End Property
	Public Property SubMod As String
		Get
			Return _subMod
		End Get
		Set(ByVal Value As String)
			_subMod = Value
		End Set
	End Property
	Public Property ProvinID As String
		Get
			Return _provinID
		End Get
		Set(ByVal Value As String)
			_provinID = Value
		End Set
	End Property
	Public Property DistrictID As String
		Get
			Return _districtID
		End Get
		Set(ByVal Value As String)
			_districtID = Value
		End Set
	End Property
	Public Property WardID As String
		Get
			Return _wardID
		End Get
		Set(ByVal Value As String)
			_wardID = Value
		End Set
	End Property
	Public Property RolesID As String
		Get
			Return _rolesID
		End Get
		Set(ByVal Value As String)
			_rolesID = Value
		End Set
	End Property
	Public Property PortalID As Integer
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Integer)
			_portalID = Value
		End Set
	End Property
	Public Property Gender As Integer
		Get
			Return _gender
		End Get
		Set(ByVal Value As Integer)
			_gender = Value
		End Set
	End Property
	Public Property DateOfBirth As DateTime
		Get
			Return _dateOfBirth
		End Get
		Set(ByVal Value As DateTime)
			_dateOfBirth = Value
		End Set
	End Property
	Public Property Address As String
		Get
			Return _address
		End Get
		Set(ByVal Value As String)
			_address = Value
		End Set
	End Property
	Public Property Email As String
		Get
			Return _email
		End Get
		Set(ByVal Value As String)
			_email = Value
		End Set
	End Property
	Public Property Telephone As String
		Get
			Return _telephone
		End Get
		Set(ByVal Value As String)
			_telephone = Value
		End Set
	End Property
	Public Property DisplayName As String
		Get
			Return _displayName
		End Get
		Set(ByVal Value As String)
			_displayName = Value
		End Set
	End Property
	Public Property IsStatus As Integer
		Get
			Return _isStatus
		End Get
		Set(ByVal Value As Integer)
			_isStatus = Value
		End Set
	End Property
	Public Property IsWork As Integer
		Get
			Return _isWork
		End Get
		Set(ByVal Value As Integer)
			_isWork = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
#End Region

End Class


Public Class EventLogInfo

#Region "Private Members"
	Private _logEventID As Long
	Private _logGUID As String = String.Empty
	Private _logTypeKey As String = String.Empty
	Private _logConfigID As Integer
	Private _logUserID As Integer
	Private _logUserName As String = String.Empty
	Private _logPortalID As Integer
	Private _logPortalName As String = String.Empty
	Private _logCreateDate As DateTime
	Private _logServerName As String = String.Empty
	Private _logNotificationPending As Boolean
	Private _exceptionHash As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property LogEventID() As Long
		Get
			Return _logEventID
		End Get
		Set(ByVal Value As Long)
			_logEventID = Value
		End Set
	End Property

	Public Property LogGUID() As String
		Get
			Return _logGUID
		End Get
		Set(ByVal Value As String)
			_logGUID = Value
		End Set
	End Property
	Public Property LogTypeKey() As String
		Get
			Return _logTypeKey
		End Get
		Set(ByVal Value As String)
			_logTypeKey = Value
		End Set
	End Property
	Public Property LogConfigID() As Integer
		Get
			Return _logConfigID
		End Get
		Set(ByVal Value As Integer)
			_logConfigID = Value
		End Set
	End Property
	Public Property LogUserID() As Integer
		Get
			Return _logUserID
		End Get
		Set(ByVal Value As Integer)
			_logUserID = Value
		End Set
	End Property
	Public Property LogUserName() As String
		Get
			Return _logUserName
		End Get
		Set(ByVal Value As String)
			_logUserName = Value
		End Set
	End Property
	Public Property LogPortalID() As Integer
		Get
			Return _logPortalID
		End Get
		Set(ByVal Value As Integer)
			_logPortalID = Value
		End Set
	End Property
	Public Property LogPortalName() As String
		Get
			Return _logPortalName
		End Get
		Set(ByVal Value As String)
			_logPortalName = Value
		End Set
	End Property
	Public Property LogCreateDate() As DateTime
		Get
			Return _logCreateDate
		End Get
		Set(ByVal Value As DateTime)
			_logCreateDate = Value
		End Set
	End Property
	Public Property LogServerName() As String
		Get
			Return _logServerName
		End Get
		Set(ByVal Value As String)
			_logServerName = Value
		End Set
	End Property
	Public Property LogNotificationPending() As Boolean
		Get
			Return _logNotificationPending
		End Get
		Set(ByVal Value As Boolean)
			_logNotificationPending = Value
		End Set
	End Property
	Public Property ExceptionHash() As String
		Get
			Return _exceptionHash
		End Get
		Set(ByVal Value As String)
			_exceptionHash = Value
		End Set
	End Property
#End Region

End Class

Public Class CMS_APIInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenAPI As String = String.Empty
	Private _linkAPI As String = String.Empty
	Private _author As String = String.Empty
	Private _body As String = String.Empty
	Private _ghiChu As String = String.Empty
	Private _kieuAPI As String = String.Empty
	Private _ghiDuLieu As Boolean
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _isDelete As Boolean
	Private _deletedUser As String = String.Empty
	Private _deletedDate As DateTime
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _total As Integer
	Private _lichDongBo As String = String.Empty
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
			_id = Value
		End Set
	End Property

	Public Property TenAPI() As String
		Get
			Return _tenAPI
		End Get
		Set(ByVal Value As String)
			_tenAPI = Value
		End Set
	End Property
	Public Property LinkAPI() As String
		Get
			Return _linkAPI
		End Get
		Set(ByVal Value As String)
			_linkAPI = Value
		End Set
	End Property
	Public Property Author() As String
		Get
			Return _author
		End Get
		Set(ByVal Value As String)
			_author = Value
		End Set
	End Property
	Public Property Body() As String
		Get
			Return _body
		End Get
		Set(ByVal Value As String)
			_body = Value
		End Set
	End Property
	Public Property GhiChu() As String
		Get
			Return _ghiChu
		End Get
		Set(ByVal Value As String)
			_ghiChu = Value
		End Set
	End Property
	Public Property KieuAPI() As String
		Get
			Return _kieuAPI
		End Get
		Set(ByVal Value As String)
			_kieuAPI = Value
		End Set
	End Property
	Public Property GhiDuLieu() As Boolean
		Get
			Return _ghiDuLieu
		End Get
		Set(ByVal Value As Boolean)
			_ghiDuLieu = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder() As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property IsDelete() As Boolean
		Get
			Return _isDelete
		End Get
		Set(ByVal Value As Boolean)
			_isDelete = Value
		End Set
	End Property
	Public Property DeletedUser() As String
		Get
			Return _deletedUser
		End Get
		Set(ByVal Value As String)
			_deletedUser = Value
		End Set
	End Property
	Public Property DeletedDate() As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser() As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser() As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property LichDongBo() As String
		Get
			Return _lichDongBo
		End Get
		Set(ByVal Value As String)
			_lichDongBo = Value
		End Set
	End Property
#End Region

End Class

Public Class CMS_APIHeaderInfo

#Region "Private Members"
	Private _id As Integer
	Private _idAPI As Integer
	Private _aPIKey As String = String.Empty
	Private _aPIValue As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _isDelete As Boolean
	Private _deletedUser As String = String.Empty
	Private _deletedDate As DateTime
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _total As Integer
	Private _tenAPI As String = String.Empty
	Private _lichDongBo As String = String.Empty
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
			_id = Value
		End Set
	End Property

	Public Property IdAPI() As Integer
		Get
			Return _idAPI
		End Get
		Set(ByVal Value As Integer)
			_idAPI = Value
		End Set
	End Property
	Public Property APIKey() As String
		Get
			Return _aPIKey
		End Get
		Set(ByVal Value As String)
			_aPIKey = Value
		End Set
	End Property
	Public Property APIValue() As String
		Get
			Return _aPIValue
		End Get
		Set(ByVal Value As String)
			_aPIValue = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder() As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property IsDelete() As Boolean
		Get
			Return _isDelete
		End Get
		Set(ByVal Value As Boolean)
			_isDelete = Value
		End Set
	End Property
	Public Property DeletedUser() As String
		Get
			Return _deletedUser
		End Get
		Set(ByVal Value As String)
			_deletedUser = Value
		End Set
	End Property
	Public Property DeletedDate() As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser() As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser() As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property TenAPI() As String
		Get
			Return _tenAPI
		End Get
		Set(ByVal Value As String)
			_tenAPI = Value
		End Set
	End Property
	Public Property LichDongBo() As String
		Get
			Return _lichDongBo
		End Get
		Set(ByVal Value As String)
			_lichDongBo = Value
		End Set
	End Property
#End Region

End Class

Public Class CMS_RegionalTPInfo

#Region "Private Members"
	Private _regional_ID As Integer
	Private _regional_Code As String = String.Empty
	Private _regional_Name As String = String.Empty
	Private _regional_Des As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _deletedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
	Private _areaID As Integer
#End Region

#Region "Public Properties"
	Public Property DeletedDate As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property

	Public Property AreaID As Integer
		Get
			Return _areaID
		End Get
		Set(ByVal Value As Integer)
			_areaID = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Regional_ID As Integer
		Get
			Return _regional_ID
		End Get
		Set(ByVal Value As Integer)
			_regional_ID = Value
		End Set
	End Property

	Public Property Regional_Code As String
		Get
			Return _regional_Code
		End Get
		Set(ByVal Value As String)
			_regional_Code = Value
		End Set
	End Property
	Public Property Regional_Name As String
		Get
			Return _regional_Name
		End Get
		Set(ByVal Value As String)
			_regional_Name = Value
		End Set
	End Property
	Public Property Regional_Des As String
		Get
			Return _regional_Des
		End Get
		Set(ByVal Value As String)
			_regional_Des = Value
		End Set
	End Property
	Public Property Parent_ID As Integer
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As Integer)
			_parent_ID = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RegionalQHInfo

#Region "Private Members"
	Private _regional_ID As Integer
	Private _regional_Code As String = String.Empty
	Private _regional_Name As String = String.Empty
	Private _regional_Des As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _deletedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
	Private _areaID As Integer
#End Region

#Region "Public Properties"
	Public Property DeletedDate As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property

	Public Property AreaID As Integer
		Get
			Return _areaID
		End Get
		Set(ByVal Value As Integer)
			_areaID = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Regional_ID As Integer
		Get
			Return _regional_ID
		End Get
		Set(ByVal Value As Integer)
			_regional_ID = Value
		End Set
	End Property

	Public Property Regional_Code As String
		Get
			Return _regional_Code
		End Get
		Set(ByVal Value As String)
			_regional_Code = Value
		End Set
	End Property
	Public Property Regional_Name As String
		Get
			Return _regional_Name
		End Get
		Set(ByVal Value As String)
			_regional_Name = Value
		End Set
	End Property
	Public Property Regional_Des As String
		Get
			Return _regional_Des
		End Get
		Set(ByVal Value As String)
			_regional_Des = Value
		End Set
	End Property
	Public Property Parent_ID As Integer
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As Integer)
			_parent_ID = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RegionalXPInfo

#Region "Private Members"
	Private _regional_ID As Integer
	Private _regional_Code As String = String.Empty
	Private _regional_Name As String = String.Empty
	Private _regional_Des As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _deletedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
	Private _areaID As Integer
	Private _maTinh As Integer
#End Region

#Region "Public Properties"
	Public Property MaTinh As Integer
		Get
			Return _maTinh
		End Get
		Set(ByVal Value As Integer)
			_maTinh = Value
		End Set
	End Property
	Public Property DeletedDate As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property
	Public Property AreaID As Integer
		Get
			Return _areaID
		End Get
		Set(ByVal Value As Integer)
			_areaID = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
	Public Property Regional_ID As Integer
		Get
			Return _regional_ID
		End Get
		Set(ByVal Value As Integer)
			_regional_ID = Value
		End Set
	End Property
	Public Property Regional_Code As String
		Get
			Return _regional_Code
		End Get
		Set(ByVal Value As String)
			_regional_Code = Value
		End Set
	End Property
	Public Property Regional_Name As String
		Get
			Return _regional_Name
		End Get
		Set(ByVal Value As String)
			_regional_Name = Value
		End Set
	End Property
	Public Property Regional_Des As String
		Get
			Return _regional_Des
		End Get
		Set(ByVal Value As String)
			_regional_Des = Value
		End Set
	End Property
	Public Property Parent_ID As Integer
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As Integer)
			_parent_ID = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class
Public Class CMS_RegionalTOInfo

#Region "Private Members"
	Private _regional_ID As Integer
	Private _regional_Code As String = String.Empty
	Private _regional_Name As String = String.Empty
	Private _regional_Des As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _deletedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
	Private _areaID As Integer
	Private _maHuyen As Integer
	Private _maTinh As Integer
#End Region

#Region "Public Properties"
	Public Property MaTinh As Integer
		Get
			Return _maTinh
		End Get
		Set(ByVal Value As Integer)
			_maTinh = Value
		End Set
	End Property
	Public Property MaHuyen As Integer
		Get
			Return _maHuyen
		End Get
		Set(ByVal Value As Integer)
			_maHuyen = Value
		End Set
	End Property
	Public Property DeletedDate As DateTime
		Get
			Return _deletedDate
		End Get
		Set(ByVal Value As DateTime)
			_deletedDate = Value
		End Set
	End Property
	Public Property AreaID As Integer
		Get
			Return _areaID
		End Get
		Set(ByVal Value As Integer)
			_areaID = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property
	Public Property Regional_ID As Integer
		Get
			Return _regional_ID
		End Get
		Set(ByVal Value As Integer)
			_regional_ID = Value
		End Set
	End Property
	Public Property Regional_Code As String
		Get
			Return _regional_Code
		End Get
		Set(ByVal Value As String)
			_regional_Code = Value
		End Set
	End Property
	Public Property Regional_Name As String
		Get
			Return _regional_Name
		End Get
		Set(ByVal Value As String)
			_regional_Name = Value
		End Set
	End Property
	Public Property Regional_Des As String
		Get
			Return _regional_Des
		End Get
		Set(ByVal Value As String)
			_regional_Des = Value
		End Set
	End Property
	Public Property Parent_ID As Integer
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As Integer)
			_parent_ID = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region
End Class
Public Class CMS_DanhMucInfo

#Region "Private Members"
	Private _ID As Integer
	Private _Name As String = String.Empty
	Private _Code As String = String.Empty
	Private _Des As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _createdBy As DateTime
	Private _userName As String = String.Empty
	Private _updatedBy As DateTime
	Private _CreatedUser As String = String.Empty
	Private _CreatedDate As DateTime
	Private _userUpdate As String = String.Empty
	Private _UpdatedDate As DateTime
	Private _UpdatedUser As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property ID As Integer
		Get
			Return _ID
		End Get
		Set(ByVal Value As Integer)
			_ID = Value
		End Set
	End Property

	Public Property Name As String
		Get
			Return _Name
		End Get
		Set(ByVal Value As String)
			_Name = Value
		End Set
	End Property
	Public Property Code As String
		Get
			Return _Code
		End Get
		Set(ByVal Value As String)
			_Code = Value
		End Set
	End Property
	Public Property Des As String
		Get
			Return _Des
		End Get
		Set(ByVal Value As String)
			_Des = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder() As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property CreatedBy() As DateTime
		Get
			Return _createdBy
		End Get
		Set(ByVal Value As DateTime)
			_createdBy = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _CreatedDate
		End Get
		Set(ByVal Value As DateTime)
			_CreatedDate = Value
		End Set
	End Property
	Public Property UserName As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _CreatedUser
		End Get
		Set(ByVal Value As String)
			_CreatedUser = Value
		End Set
	End Property
	Public Property UpdatedBy() As DateTime
		Get
			Return _updatedBy
		End Get
		Set(ByVal Value As DateTime)
			_updatedBy = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _UpdatedDate
		End Get
		Set(ByVal Value As DateTime)
			_UpdatedDate = Value
		End Set
	End Property
	Public Property UserUpdate As String
		Get
			Return _userUpdate
		End Get
		Set(ByVal Value As String)
			_userUpdate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _UpdatedUser
		End Get
		Set(ByVal Value As String)
			_UpdatedUser = Value
		End Set
	End Property
#End Region

End Class
'Public Class CMS_TypeEcoInfo

'#Region "Private Members"
'	Private _typeEco_ID As Integer
'	Private _typeEco_Code As String = String.Empty
'	Private _typeEco_Name As String = String.Empty
'	Private _typeEco_Des As String = String.Empty
'	Private _createdDate As DateTime
'	Private _createdUser As String = String.Empty
'	Private _updatedDate As DateTime
'	Private _updatedUser As String = String.Empty
'	Private _isActive As Boolean
'	Private _isOrder As Integer
'	Private _total As Integer
'#End Region

'#Region "Public Properties"

'	Public Property Total As Integer
'		Get
'			Return _total
'		End Get
'		Set(ByVal Value As Integer)
'			_total = Value
'		End Set
'	End Property

'	Public Property TypeEco_ID() As Integer
'		Get
'			Return _typeEco_ID
'		End Get
'		Set(ByVal Value As Integer)
'			_typeEco_ID = Value
'		End Set
'	End Property

'	Public Property TypeEco_Code() As String
'		Get
'			Return _typeEco_Code
'		End Get
'		Set(ByVal Value As String)
'			_typeEco_Code = Value
'		End Set
'	End Property
'	Public Property TypeEco_Name() As String
'		Get
'			Return _typeEco_Name
'		End Get
'		Set(ByVal Value As String)
'			_typeEco_Name = Value
'		End Set
'	End Property
'	Public Property TypeEco_Des() As String
'		Get
'			Return _typeEco_Des
'		End Get
'		Set(ByVal Value As String)
'			_typeEco_Des = Value
'		End Set
'	End Property
'	Public Property CreatedDate() As DateTime
'		Get
'			Return _createdDate
'		End Get
'		Set(ByVal Value As DateTime)
'			_createdDate = Value
'		End Set
'	End Property
'	Public Property CreatedUser() As String
'		Get
'			Return _createdUser
'		End Get
'		Set(ByVal Value As String)
'			_createdUser = Value
'		End Set
'	End Property
'	Public Property UpdatedDate() As DateTime
'		Get
'			Return _updatedDate
'		End Get
'		Set(ByVal Value As DateTime)
'			_updatedDate = Value
'		End Set
'	End Property
'	Public Property UpdatedUser() As String
'		Get
'			Return _updatedUser
'		End Get
'		Set(ByVal Value As String)
'			_updatedUser = Value
'		End Set
'	End Property
'	Public Property IsActive() As Boolean
'		Get
'			Return _isActive
'		End Get
'		Set(ByVal Value As Boolean)
'			_isActive = Value
'		End Set
'	End Property
'	Public Property IsOrder() As Integer
'		Get
'			Return _isOrder
'		End Get
'		Set(ByVal Value As Integer)
'			_isOrder = Value
'		End Set
'	End Property
'#End Region

'End Class

Public Class CMS_MethodInfo

#Region "Private Members"
	Private _method_ID As Integer
	Private _method_Code As String = String.Empty
	Private _method_Name As String = String.Empty
	Private _method_Des As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property Method_ID() As Integer
		Get
			Return _method_ID
		End Get
		Set(ByVal Value As Integer)
			_method_ID = Value
		End Set
	End Property

	Public Property Method_Code() As String
		Get
			Return _method_Code
		End Get
		Set(ByVal Value As String)
			_method_Code = Value
		End Set
	End Property
	Public Property Method_Name() As String
		Get
			Return _method_Name
		End Get
		Set(ByVal Value As String)
			_method_Name = Value
		End Set
	End Property
	Public Property Method_Des() As String
		Get
			Return _method_Des
		End Get
		Set(ByVal Value As String)
			_method_Des = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser() As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser() As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property IsOrder() As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
#End Region

End Class


Public Class CMSUserExtraInfo

#Region "Private Members"
	Private _iD As Integer
	Private _userName As String = String.Empty
	Private _nganhDaoTao As String = String.Empty
	Private _nganhDaoTaoKhac As String = String.Empty
	Private _trinhDoKhac1 As String = String.Empty
	Private _trinhDoKhac2 As String = String.Empty
	Private _kyNangNghe As String = String.Empty
	Private _kyNangNgheBac As String = String.Empty
	Private _ngoaiNgu1 As String = String.Empty
	Private _ngoaiNgu1ChungChi As String = String.Empty
	Private _ngoaiNgu2 As String = String.Empty
	Private _ngoaiNgu2ChungChi As String = String.Empty
	Private _trinhDoTinHoc As String = String.Empty
	Private _trinhDoTinHocKhac As String = String.Empty
	Private _kinhNghiem As String = String.Empty
	Private _kyNangMem As String = String.Empty
	Private _kyNangMemKhac As String = String.Empty
	Private _portalID As Integer
	Private _nganHang As String = String.Empty
	Private _bHXH As String = String.Empty
	Private _danToc As String = String.Empty
	Private _tonGiao As String = String.Empty
	Private _address2 As String = String.Empty
	Private _provinID2 As String = String.Empty
	Private _districtID2 As String = String.Empty
	Private _wardID2 As String = String.Empty
	Private _uniqueId As String = String.Empty
	Private _levelId As String = String.Empty
	Private _trinhDoChuyenMon As String = String.Empty
	Private _trinhDoChuyenMonKhac As String = String.Empty
	Private _ngoaiNgu1KN As String = String.Empty
	Private _ngoaiNgu2KN As String = String.Empty
	Private _trinhDoTinHocKN As String = String.Empty
	Private _trinhDoTinHocKhacKN As String = String.Empty
	Private _daLamViecNN As String = String.Empty
	Private _lienHeKhac As String = String.Empty
	Private _dTUuTien As String = String.Empty
	Private _dTUuTienKhac As String = String.Empty
	Private _dKDichVu As String = String.Empty
	Private _dKDichVuKhac As String = String.Empty
	Private _nhuCauLamViec As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property NhuCauLamViec As String
		Get
			Return _nhuCauLamViec
		End Get
		Set(ByVal Value As String)
			_nhuCauLamViec = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property ID() As Integer
		Get
			Return _iD
		End Get
		Set(ByVal Value As Integer)
			_iD = Value
		End Set
	End Property

	Public Property UserName() As String
		Get
			Return _userName
		End Get
		Set(ByVal Value As String)
			_userName = Value
		End Set
	End Property
	Public Property NganhDaoTao() As String
		Get
			Return _nganhDaoTao
		End Get
		Set(ByVal Value As String)
			_nganhDaoTao = Value
		End Set
	End Property
	Public Property NganhDaoTaoKhac() As String
		Get
			Return _nganhDaoTaoKhac
		End Get
		Set(ByVal Value As String)
			_nganhDaoTaoKhac = Value
		End Set
	End Property
	Public Property TrinhDoKhac1() As String
		Get
			Return _trinhDoKhac1
		End Get
		Set(ByVal Value As String)
			_trinhDoKhac1 = Value
		End Set
	End Property
	Public Property TrinhDoKhac2() As String
		Get
			Return _trinhDoKhac2
		End Get
		Set(ByVal Value As String)
			_trinhDoKhac2 = Value
		End Set
	End Property
	Public Property KyNangNghe() As String
		Get
			Return _kyNangNghe
		End Get
		Set(ByVal Value As String)
			_kyNangNghe = Value
		End Set
	End Property
	Public Property KyNangNgheBac() As String
		Get
			Return _kyNangNgheBac
		End Get
		Set(ByVal Value As String)
			_kyNangNgheBac = Value
		End Set
	End Property
	Public Property NgoaiNgu1() As String
		Get
			Return _ngoaiNgu1
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu1 = Value
		End Set
	End Property
	Public Property NgoaiNgu1ChungChi() As String
		Get
			Return _ngoaiNgu1ChungChi
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu1ChungChi = Value
		End Set
	End Property
	Public Property NgoaiNgu2() As String
		Get
			Return _ngoaiNgu2
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu2 = Value
		End Set
	End Property
	Public Property NgoaiNgu2ChungChi() As String
		Get
			Return _ngoaiNgu2ChungChi
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu2ChungChi = Value
		End Set
	End Property
	Public Property TrinhDoTinHoc() As String
		Get
			Return _trinhDoTinHoc
		End Get
		Set(ByVal Value As String)
			_trinhDoTinHoc = Value
		End Set
	End Property
	Public Property TrinhDoTinHocKhac() As String
		Get
			Return _trinhDoTinHocKhac
		End Get
		Set(ByVal Value As String)
			_trinhDoTinHocKhac = Value
		End Set
	End Property
	Public Property KinhNghiem() As String
		Get
			Return _kinhNghiem
		End Get
		Set(ByVal Value As String)
			_kinhNghiem = Value
		End Set
	End Property
	Public Property KyNangMem() As String
		Get
			Return _kyNangMem
		End Get
		Set(ByVal Value As String)
			_kyNangMem = Value
		End Set
	End Property
	Public Property KyNangMemKhac() As String
		Get
			Return _kyNangMemKhac
		End Get
		Set(ByVal Value As String)
			_kyNangMemKhac = Value
		End Set
	End Property
	Public Property PortalID() As Integer
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Integer)
			_portalID = Value
		End Set
	End Property
	Public Property NganHang() As String
		Get
			Return _nganHang
		End Get
		Set(ByVal Value As String)
			_nganHang = Value
		End Set
	End Property
	Public Property BHXH() As String
		Get
			Return _bHXH
		End Get
		Set(ByVal Value As String)
			_bHXH = Value
		End Set
	End Property
	Public Property DanToc() As String
		Get
			Return _danToc
		End Get
		Set(ByVal Value As String)
			_danToc = Value
		End Set
	End Property
	Public Property TonGiao() As String
		Get
			Return _tonGiao
		End Get
		Set(ByVal Value As String)
			_tonGiao = Value
		End Set
	End Property
	Public Property Address2() As String
		Get
			Return _address2
		End Get
		Set(ByVal Value As String)
			_address2 = Value
		End Set
	End Property
	Public Property ProvinID2() As String
		Get
			Return _provinID2
		End Get
		Set(ByVal Value As String)
			_provinID2 = Value
		End Set
	End Property
	Public Property DistrictID2() As String
		Get
			Return _districtID2
		End Get
		Set(ByVal Value As String)
			_districtID2 = Value
		End Set
	End Property
	Public Property WardID2() As String
		Get
			Return _wardID2
		End Get
		Set(ByVal Value As String)
			_wardID2 = Value
		End Set
	End Property
	Public Property UniqueId() As String
		Get
			Return _uniqueId
		End Get
		Set(ByVal Value As String)
			_uniqueId = Value
		End Set
	End Property
	Public Property LevelId() As String
		Get
			Return _levelId
		End Get
		Set(ByVal Value As String)
			_levelId = Value
		End Set
	End Property
	Public Property TrinhDoChuyenMon() As String
		Get
			Return _trinhDoChuyenMon
		End Get
		Set(ByVal Value As String)
			_trinhDoChuyenMon = Value
		End Set
	End Property
	Public Property TrinhDoChuyenMonKhac() As String
		Get
			Return _trinhDoChuyenMonKhac
		End Get
		Set(ByVal Value As String)
			_trinhDoChuyenMonKhac = Value
		End Set
	End Property
	Public Property NgoaiNgu1KN() As String
		Get
			Return _ngoaiNgu1KN
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu1KN = Value
		End Set
	End Property
	Public Property NgoaiNgu2KN() As String
		Get
			Return _ngoaiNgu2KN
		End Get
		Set(ByVal Value As String)
			_ngoaiNgu2KN = Value
		End Set
	End Property
	Public Property TrinhDoTinHocKN() As String
		Get
			Return _trinhDoTinHocKN
		End Get
		Set(ByVal Value As String)
			_trinhDoTinHocKN = Value
		End Set
	End Property
	Public Property TrinhDoTinHocKhacKN() As String
		Get
			Return _trinhDoTinHocKhacKN
		End Get
		Set(ByVal Value As String)
			_trinhDoTinHocKhacKN = Value
		End Set
	End Property
	Public Property DaLamViecNN() As String
		Get
			Return _daLamViecNN
		End Get
		Set(ByVal Value As String)
			_daLamViecNN = Value
		End Set
	End Property
	Public Property LienHeKhac() As String
		Get
			Return _lienHeKhac
		End Get
		Set(ByVal Value As String)
			_lienHeKhac = Value
		End Set
	End Property
	Public Property DTUuTien() As String
		Get
			Return _dTUuTien
		End Get
		Set(ByVal Value As String)
			_dTUuTien = Value
		End Set
	End Property
	Public Property DTUuTienKhac() As String
		Get
			Return _dTUuTienKhac
		End Get
		Set(ByVal Value As String)
			_dTUuTienKhac = Value
		End Set
	End Property
	Public Property DKDichVu() As String
		Get
			Return _dKDichVu
		End Get
		Set(ByVal Value As String)
			_dKDichVu = Value
		End Set
	End Property
	Public Property DKDichVuKhac() As String
		Get
			Return _dKDichVuKhac
		End Get
		Set(ByVal Value As String)
			_dKDichVuKhac = Value
		End Set
	End Property
#End Region

End Class


Public Class CMS_KhuCongNghiepInfo

#Region "Private Members"
	Private _industrialZone_ID As String = String.Empty
	Private _industrialZone_Name As String = String.Empty
	Private _industrialZone_Code As String = String.Empty
	Private _industrialZone_Des As String = String.Empty
	Private _parent_ID As String = String.Empty
	Private _isOrder As Integer
	Private _tinhTP As Integer
	Private _quanHuyen As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isActive As Boolean
	Private _portalId As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"

	Public Property TinhTP As Integer
		Get
			Return _tinhTP
		End Get
		Set(ByVal Value As Integer)
			_tinhTP = Value
		End Set
	End Property
	Public Property QuanHuyen As Integer
		Get
			Return _quanHuyen
		End Get
		Set(ByVal Value As Integer)
			_quanHuyen = Value
		End Set
	End Property
	Public Property Total As Integer
		Get
			Return _total
		End Get
		Set(ByVal Value As Integer)
			_total = Value
		End Set
	End Property

	Public Property IndustrialZone_ID As String
		Get
			Return _industrialZone_ID
		End Get
		Set(ByVal Value As String)
			_industrialZone_ID = Value
		End Set
	End Property

	Public Property IndustrialZone_Name As String
		Get
			Return _industrialZone_Name
		End Get
		Set(ByVal Value As String)
			_industrialZone_Name = Value
		End Set
	End Property
	Public Property IndustrialZone_Code As String
		Get
			Return _industrialZone_Code
		End Get
		Set(ByVal Value As String)
			_industrialZone_Code = Value
		End Set
	End Property
	Public Property IndustrialZone_Des As String
		Get
			Return _industrialZone_Des
		End Get
		Set(ByVal Value As String)
			_industrialZone_Des = Value
		End Set
	End Property
	Public Property Parent_ID As String
		Get
			Return _parent_ID
		End Get
		Set(ByVal Value As String)
			_parent_ID = Value
		End Set
	End Property
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
		End Set
	End Property
	Public Property CreatedUser As String
		Get
			Return _createdUser
		End Get
		Set(ByVal Value As String)
			_createdUser = Value
		End Set
	End Property
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
		End Set
	End Property
	Public Property UpdatedUser As String
		Get
			Return _updatedUser
		End Get
		Set(ByVal Value As String)
			_updatedUser = Value
		End Set
	End Property
	Public Property IsActive() As Boolean
		Get
			Return _isActive
		End Get
		Set(ByVal Value As Boolean)
			_isActive = Value
		End Set
	End Property
	Public Property PortalId As Integer
		Get
			Return _portalId
		End Get
		Set(ByVal Value As Integer)
			_portalId = Value
		End Set
	End Property
#End Region

End Class


Public Class fileSaveInfo
	Public Property fileName As String
	Public Property filePath As String
	Public Property directory As String

End Class

Public Class ReportInfo
	Public Property Ten As String
	Public Property SoLuong As Integer
End Class