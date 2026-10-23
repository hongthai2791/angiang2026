Imports DotNetNuke.Common.Utilities
Public Class DnnInfo

#Region "Private Members"
    Private _userID As String
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
    Private _paneName As String = String.Empty
    Private _moduleOrder As Integer
    Private _moduleTitle As String = String.Empty
    Private _settingValue As String = String.Empty
    Private _lastName As String = String.Empty
    Private _firstName As String = String.Empty
    Private _displayName As String = String.Empty
    Private _fullName As String = String.Empty
    Private _createdOnDate As DateTime
    Private _total As Integer
    Private _rowNum As Integer
    Private _isDeleted As Boolean
    Private _TabPath As String = String.Empty
#End Region

#Region "Public Properties"
    Public Property IsDeleted As Boolean
        Get
            Return _isDeleted
        End Get
        Set(ByVal Value As Boolean)
            _isDeleted = Value
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
    Public Property UserID() As String
        Get
            Return _userID
        End Get
        Set(ByVal Value As String)
            _userID = Value
        End Set
    End Property
    Public Property FileID() As Integer
        Get
            Return _fileID
        End Get
        Set(ByVal Value As Integer)
            _fileID = Value
        End Set
    End Property
    Public Property Folder() As String
        Get
            Return _folder
        End Get
        Set(ByVal Value As String)
            _folder = Value
        End Set
    End Property
    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal Value As String)
            _fullName = Value
        End Set
    End Property
    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal Value As String)
            _fileName = Value
        End Set
    End Property
    Public Property DesktopModuleID() As Integer
        Get
            Return _desktopModuleID
        End Get
        Set(ByVal Value As Integer)
            _desktopModuleID = Value
        End Set
    End Property
    Public Property RestPassWordId() As String
        Get
            Return _restPassWordId
        End Get
        Set(ByVal Value As String)
            _restPassWordId = Value
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
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal Value As String)
            _username = Value
        End Set
    End Property
    Public Property Email() As String
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
    Public Property HTTPAlias() As String
        Get
            Return _hTTPAlias
        End Get
        Set(ByVal Value As String)
            _hTTPAlias = Value
        End Set
    End Property
    Public Property PortalName() As String
        Get
            Return _portalName
        End Get
        Set(ByVal Value As String)
            _portalName = Value
        End Set
    End Property
    Public Property Tabid() As Integer
        Get
            Return _tabid
        End Get
        Set(ByVal Value As Integer)
            _tabid = Value
        End Set
    End Property
    Public Property TabName() As String
        Get
            Return _tabName
        End Get
        Set(ByVal Value As String)
            _tabName = Value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal Value As String)
            _title = Value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal Value As String)
            _description = Value
        End Set
    End Property
    Public Property TabModuleID() As Integer
        Get
            Return _tabModuleID
        End Get
        Set(ByVal Value As Integer)
            _tabModuleID = Value
        End Set
    End Property
    Public Property PaneName() As String
        Get
            Return _paneName
        End Get
        Set(ByVal Value As String)
            _paneName = Value
        End Set
    End Property
    Public Property ModuleOrder() As Integer
        Get
            Return _moduleOrder
        End Get
        Set(ByVal Value As Integer)
            _moduleOrder = Value
        End Set
    End Property
    Public Property ModuleTitle() As String
        Get
            Return _moduleTitle
        End Get
        Set(ByVal Value As String)
            _moduleTitle = Value
        End Set
    End Property
    Public Property SettingValue() As String
        Get
            Return _settingValue
        End Get
        Set(ByVal Value As String)
            _settingValue = Value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal Value As String)
            _lastName = Value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal Value As String)
            _firstName = Value
        End Set
    End Property
    Public Property DisplayName() As String
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
Public Class CMS_PortalInfo

#Region "Private Members"
    Private _portalID As Integer
    Private _portalName As String = String.Empty
    Private _logo As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _xaPhuong As String = String.Empty
    Private _duongPho As String = String.Empty
    Private _nguoiDaiDien As String = String.Empty
    Private _position_ID As String = String.Empty
    Private _website As String = String.Empty
    Private _email As String = String.Empty
    Private _mobile As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isActive As Boolean
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

    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property

    Public Property PortalName() As String
        Get
            Return _portalName
        End Get
        Set(ByVal Value As String)
            _portalName = Value
        End Set
    End Property
    Public Property Logo() As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
        End Set
    End Property
    Public Property TinhTP() As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
        End Set
    End Property
    Public Property QuanHuyen() As String
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As String)
            _quanHuyen = Value
        End Set
    End Property
    Public Property XaPhuong() As String
        Get
            Return _xaPhuong
        End Get
        Set(ByVal Value As String)
            _xaPhuong = Value
        End Set
    End Property
    Public Property DuongPho() As String
        Get
            Return _duongPho
        End Get
        Set(ByVal Value As String)
            _duongPho = Value
        End Set
    End Property
    Public Property NguoiDaiDien() As String
        Get
            Return _nguoiDaiDien
        End Get
        Set(ByVal Value As String)
            _nguoiDaiDien = Value
        End Set
    End Property
    Public Property Position_ID() As String
        Get
            Return _position_ID
        End Get
        Set(ByVal Value As String)
            _position_ID = Value
        End Set
    End Property
    Public Property Website() As String
        Get
            Return _website
        End Get
        Set(ByVal Value As String)
            _website = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property
    Public Property Mobile() As String
        Get
            Return _mobile
        End Get
        Set(ByVal Value As String)
            _mobile = Value
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
#End Region

End Class
Public Class CMSConnectionInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _connection As String = String.Empty
    Private _HTTPAlias As String = String.Empty
    Private _Skin_Src As String = String.Empty
    Private _Container_Src As String = String.Empty
#End Region

#Region "Public Properties"
    Public Property Skin_Src As String
        Get
            Return _Skin_Src
        End Get
        Set(ByVal Value As String)
            _Skin_Src = Value
        End Set
    End Property
    Public Property Container_Src As String
        Get
            Return _Container_Src
        End Get
        Set(ByVal Value As String)
            _Container_Src = Value
        End Set
    End Property
    Public Property HTTPAlias As String
        Get
            Return _HTTPAlias
        End Get
        Set(ByVal Value As String)
            _HTTPAlias = Value
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
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property Connection() As String
        Get
            Return _connection
        End Get
        Set(ByVal Value As String)
            _connection = Value
        End Set
    End Property
#End Region

End Class
Public Class CMSUserPortalInfo

#Region "Private Members"
    Private _id As Integer
    Private _userID As String = String.Empty
    Private _portalID As Integer
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

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _userID
        End Get
        Set(ByVal Value As String)
            _userID = Value
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
#End Region

End Class
Public Class CMSDelFile

#Region "Private Members"
    Private _delFile_ID As String
    Private _filePath As String
    Private _userDel As String = String.Empty
    Private _dateDel As DateTime
    Private _portalID As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property DelFile_ID As String
        Get
            Return _delFile_ID
        End Get
        Set(ByVal Value As String)
            _delFile_ID = Value
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
    Public Property FilePath As String
        Get
            Return _filePath
        End Get
        Set(ByVal Value As String)
            _filePath = Value
        End Set
    End Property
    Public Property UserDel() As String
        Get
            Return _userDel
        End Get
        Set(ByVal Value As String)
            _userDel = Value
        End Set
    End Property


    Public Property DateDel() As DateTime
        Get
            Return _dateDel
        End Get
        Set(ByVal Value As DateTime)
            _dateDel = Value
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

    Public Property IdKey() As String
        Get
            Return _idKey
        End Get
        Set(ByVal Value As String)
            _idKey = Value
        End Set
    End Property

    Public Property IdValue() As String
        Get
            Return _idValue
        End Get
        Set(ByVal Value As String)
            _idValue = Value
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
    Public Property CrtVal() As String
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
Public Class CMS_BankingInfo

#Region "Private Members"
    Private _banking_ID As String = String.Empty
    Private _banking_Name As String = String.Empty
    Private _banking_Code As String = String.Empty
    Private _banking_Logo As String = String.Empty
    Private _banking_Website As String = String.Empty
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

    Public Property Banking_ID() As String
        Get
            Return _banking_ID
        End Get
        Set(ByVal Value As String)
            _banking_ID = Value
        End Set
    End Property

    Public Property Banking_Name() As String
        Get
            Return _banking_Name
        End Get
        Set(ByVal Value As String)
            _banking_Name = Value
        End Set
    End Property
    Public Property Banking_Code() As String
        Get
            Return _banking_Code
        End Get
        Set(ByVal Value As String)
            _banking_Code = Value
        End Set
    End Property
    Public Property Banking_Logo() As String
        Get
            Return _banking_Logo
        End Get
        Set(ByVal Value As String)
            _banking_Logo = Value
        End Set
    End Property
    Public Property Banking_Website() As String
        Get
            Return _banking_Website
        End Get
        Set(ByVal Value As String)
            _banking_Website = Value
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
Public Class CMS_BranchInfo

#Region "Private Members"
    Private _branch_ID As String = String.Empty
    Private _branch_Name As String = String.Empty
    Private _branch_Code As String = String.Empty
    Private _branch_Tel As String = String.Empty
    Private _branch_Address As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _banking_ID As String = String.Empty
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

    Public Property Branch_ID() As String
        Get
            Return _branch_ID
        End Get
        Set(ByVal Value As String)
            _branch_ID = Value
        End Set
    End Property

    Public Property Branch_Name() As String
        Get
            Return _branch_Name
        End Get
        Set(ByVal Value As String)
            _branch_Name = Value
        End Set
    End Property
    Public Property Branch_Code() As String
        Get
            Return _branch_Code
        End Get
        Set(ByVal Value As String)
            _branch_Code = Value
        End Set
    End Property
    Public Property Branch_Tel() As String
        Get
            Return _branch_Tel
        End Get
        Set(ByVal Value As String)
            _branch_Tel = Value
        End Set
    End Property
    Public Property Branch_Address() As String
        Get
            Return _branch_Address
        End Get
        Set(ByVal Value As String)
            _branch_Address = Value
        End Set
    End Property
    Public Property TinhTP() As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
        End Set
    End Property
    Public Property Banking_ID() As String
        Get
            Return _banking_ID
        End Get
        Set(ByVal Value As String)
            _banking_ID = Value
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
Public Class CMS_CannotInfo

#Region "Private Members"
    Private _cannot_ID As String = String.Empty
    Private _cannot_Name As String = String.Empty
    Private _cannot_Code As String = String.Empty
    Private _cannot_Des As String = String.Empty
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

    Public Property Cannot_ID() As String
        Get
            Return _cannot_ID
        End Get
        Set(ByVal Value As String)
            _cannot_ID = Value
        End Set
    End Property

    Public Property Cannot_Name() As String
        Get
            Return _cannot_Name
        End Get
        Set(ByVal Value As String)
            _cannot_Name = Value
        End Set
    End Property
    Public Property Cannot_Code() As String
        Get
            Return _cannot_Code
        End Get
        Set(ByVal Value As String)
            _cannot_Code = Value
        End Set
    End Property
    Public Property Cannot_Des() As String
        Get
            Return _cannot_Des
        End Get
        Set(ByVal Value As String)
            _cannot_Des = Value
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
Public Class CMS_CareerInfo

#Region "Private Members"
    Private _career_ID As String = String.Empty
    Private _career_Name As String = String.Empty
    Private _career_Code As String = String.Empty
    Private _career_Des As String = String.Empty
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

    Public Property Career_ID() As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
        End Set
    End Property

    Public Property Career_Name() As String
        Get
            Return _career_Name
        End Get
        Set(ByVal Value As String)
            _career_Name = Value
        End Set
    End Property
    Public Property Career_Code() As String
        Get
            Return _career_Code
        End Get
        Set(ByVal Value As String)
            _career_Code = Value
        End Set
    End Property
    Public Property Career_Des() As String
        Get
            Return _career_Des
        End Get
        Set(ByVal Value As String)
            _career_Des = Value
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
Public Class CMS_CauseOfInfo

#Region "Private Members"
    Private _causeOf_ID As String = String.Empty
    Private _causeOf_Name As String = String.Empty
    Private _causeOf_Code As String = String.Empty
    Private _causeOf_Des As String = String.Empty
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

    Public Property CauseOf_ID() As String
        Get
            Return _causeOf_ID
        End Get
        Set(ByVal Value As String)
            _causeOf_ID = Value
        End Set
    End Property

    Public Property CauseOf_Name() As String
        Get
            Return _causeOf_Name
        End Get
        Set(ByVal Value As String)
            _causeOf_Name = Value
        End Set
    End Property
    Public Property CauseOf_Code() As String
        Get
            Return _causeOf_Code
        End Get
        Set(ByVal Value As String)
            _causeOf_Code = Value
        End Set
    End Property
    Public Property CauseOf_Des() As String
        Get
            Return _causeOf_Des
        End Get
        Set(ByVal Value As String)
            _causeOf_Des = Value
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
Public Class CMS_CompanyInfo

#Region "Private Members"
    Private _company_ID As String = String.Empty
    Private _company_Name As String = String.Empty
    Private _company_Code As String = String.Empty
    Private _company_Logo As String = String.Empty
    Private _company_Tel As String = String.Empty
    Private _company_Website As String = String.Empty
    Private _comType_ID As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _xaPhuong As String = String.Empty
    Private _soNha As String = String.Empty
    Private _career_ID As String = String.Empty
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

    Public Property Company_ID() As String
        Get
            Return _company_ID
        End Get
        Set(ByVal Value As String)
            _company_ID = Value
        End Set
    End Property

    Public Property Company_Name() As String
        Get
            Return _company_Name
        End Get
        Set(ByVal Value As String)
            _company_Name = Value
        End Set
    End Property
    Public Property Company_Code() As String
        Get
            Return _company_Code
        End Get
        Set(ByVal Value As String)
            _company_Code = Value
        End Set
    End Property
    Public Property Company_Logo() As String
        Get
            Return _company_Logo
        End Get
        Set(ByVal Value As String)
            _company_Logo = Value
        End Set
    End Property
    Public Property Company_Tel() As String
        Get
            Return _company_Tel
        End Get
        Set(ByVal Value As String)
            _company_Tel = Value
        End Set
    End Property
    Public Property Company_Website() As String
        Get
            Return _company_Website
        End Get
        Set(ByVal Value As String)
            _company_Website = Value
        End Set
    End Property
    Public Property ComType_ID() As String
        Get
            Return _comType_ID
        End Get
        Set(ByVal Value As String)
            _comType_ID = Value
        End Set
    End Property
    Public Property TinhTP() As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
        End Set
    End Property
    Public Property QuanHuyen() As String
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As String)
            _quanHuyen = Value
        End Set
    End Property
    Public Property XaPhuong() As String
        Get
            Return _xaPhuong
        End Get
        Set(ByVal Value As String)
            _xaPhuong = Value
        End Set
    End Property
    Public Property SoNha() As String
        Get
            Return _soNha
        End Get
        Set(ByVal Value As String)
            _soNha = Value
        End Set
    End Property
    Public Property Career_ID() As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
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
Public Class CMS_ComTypeInfo

#Region "Private Members"
    Private _comType_ID As String = String.Empty
    Private _comtype_Name As String = String.Empty
    Private _comtype_Code As String = String.Empty
    Private _comtype_Des As String = String.Empty
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

    Public Property ComType_ID() As String
        Get
            Return _comType_ID
        End Get
        Set(ByVal Value As String)
            _comType_ID = Value
        End Set
    End Property

    Public Property Comtype_Name() As String
        Get
            Return _comtype_Name
        End Get
        Set(ByVal Value As String)
            _comtype_Name = Value
        End Set
    End Property
    Public Property Comtype_Code() As String
        Get
            Return _comtype_Code
        End Get
        Set(ByVal Value As String)
            _comtype_Code = Value
        End Set
    End Property
    Public Property Comtype_Des() As String
        Get
            Return _comtype_Des
        End Get
        Set(ByVal Value As String)
            _comtype_Des = Value
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
Public Class CMS_ContractTypeInfo

#Region "Private Members"
    Private _contractType_ID As String = String.Empty
    Private _contractType_Name As String = String.Empty
    Private _contractType_Code As String = String.Empty
    Private _contractType_Des As String = String.Empty
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

    Public Property ContractType_ID() As String
        Get
            Return _contractType_ID
        End Get
        Set(ByVal Value As String)
            _contractType_ID = Value
        End Set
    End Property

    Public Property ContractType_Name() As String
        Get
            Return _contractType_Name
        End Get
        Set(ByVal Value As String)
            _contractType_Name = Value
        End Set
    End Property
    Public Property ContractType_Code() As String
        Get
            Return _contractType_Code
        End Get
        Set(ByVal Value As String)
            _contractType_Code = Value
        End Set
    End Property
    Public Property ContractType_Des() As String
        Get
            Return _contractType_Des
        End Get
        Set(ByVal Value As String)
            _contractType_Des = Value
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
Public Class CMS_CourseInfo

#Region "Private Members"
    Private _course_ID As String = String.Empty
    Private _training_ID As String = String.Empty
    Private _course_Name As String = String.Empty
    Private _tuition As Double
    Private _isMonth As Integer
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

    Public Property Course_ID() As String
        Get
            Return _course_ID
        End Get
        Set(ByVal Value As String)
            _course_ID = Value
        End Set
    End Property

    Public Property Training_ID() As String
        Get
            Return _training_ID
        End Get
        Set(ByVal Value As String)
            _training_ID = Value
        End Set
    End Property
    Public Property Course_Name() As String
        Get
            Return _course_Name
        End Get
        Set(ByVal Value As String)
            _course_Name = Value
        End Set
    End Property
    Public Property Tuition() As Double
        Get
            Return _tuition
        End Get
        Set(ByVal Value As Double)
            _tuition = Value
        End Set
    End Property
    Public Property IsMonth() As Integer
        Get
            Return _isMonth
        End Get
        Set(ByVal Value As Integer)
            _isMonth = Value
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

    Public Property DayOff_ID() As String
        Get
            Return _dayOff_ID
        End Get
        Set(ByVal Value As String)
            _dayOff_ID = Value
        End Set
    End Property

    Public Property DayOff_Name() As String
        Get
            Return _dayOff_Name
        End Get
        Set(ByVal Value As String)
            _dayOff_Name = Value
        End Set
    End Property
    Public Property IsDay() As Integer
        Get
            Return _isDay
        End Get
        Set(ByVal Value As Integer)
            _isDay = Value
        End Set
    End Property
    Public Property IsMonth() As Integer
        Get
            Return _isMonth
        End Get
        Set(ByVal Value As Integer)
            _isMonth = Value
        End Set
    End Property
    Public Property IsYear() As Integer
        Get
            Return _isYear
        End Get
        Set(ByVal Value As Integer)
            _isYear = Value
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
Public Class CMS_DecidedTypeInfo

#Region "Private Members"
    Private _decidedType_ID As String = String.Empty
    Private _decidedType_Name As String = String.Empty
    Private _decidedType_Code As String = String.Empty
    Private _decidedType_Des As String = String.Empty
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

    Public Property DecidedType_ID() As String
        Get
            Return _decidedType_ID
        End Get
        Set(ByVal Value As String)
            _decidedType_ID = Value
        End Set
    End Property

    Public Property DecidedType_Name() As String
        Get
            Return _decidedType_Name
        End Get
        Set(ByVal Value As String)
            _decidedType_Name = Value
        End Set
    End Property
    Public Property DecidedType_Code() As String
        Get
            Return _decidedType_Code
        End Get
        Set(ByVal Value As String)
            _decidedType_Code = Value
        End Set
    End Property
    Public Property DecidedType_Des() As String
        Get
            Return _decidedType_Des
        End Get
        Set(ByVal Value As String)
            _decidedType_Des = Value
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
Public Class CMS_FieldInfo

#Region "Private Members"
    Private _field_ID As String = String.Empty
    Private _field_Name As String = String.Empty
    Private _field_Code As String = String.Empty
    Private _field_Des As String = String.Empty
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

    Public Property Field_ID() As String
        Get
            Return _field_ID
        End Get
        Set(ByVal Value As String)
            _field_ID = Value
        End Set
    End Property

    Public Property Field_Name() As String
        Get
            Return _field_Name
        End Get
        Set(ByVal Value As String)
            _field_Name = Value
        End Set
    End Property
    Public Property Field_Code() As String
        Get
            Return _field_Code
        End Get
        Set(ByVal Value As String)
            _field_Code = Value
        End Set
    End Property
    Public Property Field_Des() As String
        Get
            Return _field_Des
        End Get
        Set(ByVal Value As String)
            _field_Des = Value
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
Public Class CMS_FileAttchInfo

#Region "Private Members"
    Private _fileAttch_ID As String = String.Empty
    Private _document_ID As String = String.Empty
    Private _fileAttch_Name As String = String.Empty
    Private _fileAttch_Attch As String = String.Empty
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
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

    Public Property FileAttch_ID() As String
        Get
            Return _fileAttch_ID
        End Get
        Set(ByVal Value As String)
            _fileAttch_ID = Value
        End Set
    End Property

    Public Property Document_ID() As String
        Get
            Return _document_ID
        End Get
        Set(ByVal Value As String)
            _document_ID = Value
        End Set
    End Property
    Public Property FileAttch_Name() As String
        Get
            Return _fileAttch_Name
        End Get
        Set(ByVal Value As String)
            _fileAttch_Name = Value
        End Set
    End Property
    Public Property FileAttch_Attch() As String
        Get
            Return _fileAttch_Attch
        End Get
        Set(ByVal Value As String)
            _fileAttch_Attch = Value
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
#End Region

End Class
Public Class CMS_InsuranceInfo

#Region "Private Members"
    Private _insurance_ID As String = String.Empty
    Private _insurance_Code As String = String.Empty
    Private _insurance_Name As String = String.Empty
    Private _insurance_Address As String = String.Empty
    Private _insurance_Des As String = String.Empty
    Private _quanHuyen As String = String.Empty
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

    Public Property Insurance_ID() As String
        Get
            Return _insurance_ID
        End Get
        Set(ByVal Value As String)
            _insurance_ID = Value
        End Set
    End Property

    Public Property Insurance_Code() As String
        Get
            Return _insurance_Code
        End Get
        Set(ByVal Value As String)
            _insurance_Code = Value
        End Set
    End Property
    Public Property Insurance_Name() As String
        Get
            Return _insurance_Name
        End Get
        Set(ByVal Value As String)
            _insurance_Name = Value
        End Set
    End Property
    Public Property Insurance_Address() As String
        Get
            Return _insurance_Address
        End Get
        Set(ByVal Value As String)
            _insurance_Address = Value
        End Set
    End Property
    Public Property Insurance_Des() As String
        Get
            Return _insurance_Des
        End Get
        Set(ByVal Value As String)
            _insurance_Des = Value
        End Set
    End Property
    Public Property QuanHuyen() As String
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As String)
            _quanHuyen = Value
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
Public Class CMS_LaborTypeInfo

#Region "Private Members"
    Private _laborType_ID As String = String.Empty
    Private _laborType_Name As String = String.Empty
    Private _laborType_Code As String = String.Empty
    Private _laborType_Des As String = String.Empty
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

    Public Property LaborType_ID() As String
        Get
            Return _laborType_ID
        End Get
        Set(ByVal Value As String)
            _laborType_ID = Value
        End Set
    End Property

    Public Property LaborType_Name() As String
        Get
            Return _laborType_Name
        End Get
        Set(ByVal Value As String)
            _laborType_Name = Value
        End Set
    End Property
    Public Property LaborType_Code() As String
        Get
            Return _laborType_Code
        End Get
        Set(ByVal Value As String)
            _laborType_Code = Value
        End Set
    End Property
    Public Property LaborType_Des() As String
        Get
            Return _laborType_Des
        End Get
        Set(ByVal Value As String)
            _laborType_Des = Value
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
Public Class CMS_LanguageInfo

#Region "Private Members"
    Private _language_ID As String = String.Empty
    Private _language_Name As String = String.Empty
    Private _language_Code As String = String.Empty
    Private _language_Des As String = String.Empty
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

    Public Property Language_ID() As String
        Get
            Return _language_ID
        End Get
        Set(ByVal Value As String)
            _language_ID = Value
        End Set
    End Property

    Public Property Language_Name() As String
        Get
            Return _language_Name
        End Get
        Set(ByVal Value As String)
            _language_Name = Value
        End Set
    End Property
    Public Property Language_Code() As String
        Get
            Return _language_Code
        End Get
        Set(ByVal Value As String)
            _language_Code = Value
        End Set
    End Property
    Public Property Language_Des() As String
        Get
            Return _language_Des
        End Get
        Set(ByVal Value As String)
            _language_Des = Value
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
Public Class CMS_LeavingInfo

#Region "Private Members"
    Private _leaving_ID As String = String.Empty
    Private _leaving_Name As String = String.Empty
    Private _leaving_Code As String = String.Empty
    Private _leaving_Des As String = String.Empty
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

    Public Property Leaving_ID() As String
        Get
            Return _leaving_ID
        End Get
        Set(ByVal Value As String)
            _leaving_ID = Value
        End Set
    End Property

    Public Property Leaving_Name() As String
        Get
            Return _leaving_Name
        End Get
        Set(ByVal Value As String)
            _leaving_Name = Value
        End Set
    End Property
    Public Property Leaving_Code() As String
        Get
            Return _leaving_Code
        End Get
        Set(ByVal Value As String)
            _leaving_Code = Value
        End Set
    End Property
    Public Property Leaving_Des() As String
        Get
            Return _leaving_Des
        End Get
        Set(ByVal Value As String)
            _leaving_Des = Value
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
Public Class CMS_LocationInfo

#Region "Private Members"
    Private _location_ID As String = String.Empty
    Private _location_Name As String = String.Empty
    Private _location_Code As String = String.Empty
    Private _location_Des As String = String.Empty
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

    Public Property Location_ID() As String
        Get
            Return _location_ID
        End Get
        Set(ByVal Value As String)
            _location_ID = Value
        End Set
    End Property

    Public Property Location_Name() As String
        Get
            Return _location_Name
        End Get
        Set(ByVal Value As String)
            _location_Name = Value
        End Set
    End Property
    Public Property Location_Code() As String
        Get
            Return _location_Code
        End Get
        Set(ByVal Value As String)
            _location_Code = Value
        End Set
    End Property
    Public Property Location_Des() As String
        Get
            Return _location_Des
        End Get
        Set(ByVal Value As String)
            _location_Des = Value
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
Public Class CMS_ModuleInfo

#Region "Private Members"
    Private _module_ID As String = String.Empty
    Private _moduleSrc As String = String.Empty
    Private _moduleName As String = String.Empty
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

    Public Property Module_ID() As String
        Get
            Return _module_ID
        End Get
        Set(ByVal Value As String)
            _module_ID = Value
        End Set
    End Property

    Public Property ModuleSrc() As String
        Get
            Return _moduleSrc
        End Get
        Set(ByVal Value As String)
            _moduleSrc = Value
        End Set
    End Property
    Public Property ModuleName() As String
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
    Public Property ctlView() As String
        Get
            Return _ctlView
        End Get
        Set(ByVal Value As String)
            _ctlView = Value
        End Set
    End Property
    Public Property ctlEdit() As String
        Get
            Return _ctlEdit
        End Get
        Set(ByVal Value As String)
            _ctlEdit = Value
        End Set
    End Property
    Public Property Img() As String
        Get
            Return _img
        End Get
        Set(ByVal Value As String)
            _img = Value
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
    Public Property Setup() As Boolean
        Get
            Return _setup
        End Get
        Set(ByVal Value As Boolean)
            _setup = Value
        End Set
    End Property
    Public Property Parent_ID() As String
        Get
            Return _parent_ID
        End Get
        Set(ByVal Value As String)
            _parent_ID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NationInfo

#Region "Private Members"
    Private _nation_ID As String = String.Empty
    Private _nation_Name As String = String.Empty
    Private _nation_Code As String = String.Empty
    Private _nation_Des As String = String.Empty
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

    Public Property Nation_ID() As String
        Get
            Return _nation_ID
        End Get
        Set(ByVal Value As String)
            _nation_ID = Value
        End Set
    End Property

    Public Property Nation_Name() As String
        Get
            Return _nation_Name
        End Get
        Set(ByVal Value As String)
            _nation_Name = Value
        End Set
    End Property
    Public Property Nation_Code() As String
        Get
            Return _nation_Code
        End Get
        Set(ByVal Value As String)
            _nation_Code = Value
        End Set
    End Property
    Public Property Nation_Des() As String
        Get
            Return _nation_Des
        End Get
        Set(ByVal Value As String)
            _nation_Des = Value
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
Public Class CMS_NationalInfo

#Region "Private Members"
    Private _national_ID As String = String.Empty
    Private _national_Name As String = String.Empty
    Private _national_Code As String = String.Empty
    Private _national_Des As String = String.Empty
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

    Public Property National_ID() As String
        Get
            Return _national_ID
        End Get
        Set(ByVal Value As String)
            _national_ID = Value
        End Set
    End Property

    Public Property National_Name() As String
        Get
            Return _national_Name
        End Get
        Set(ByVal Value As String)
            _national_Name = Value
        End Set
    End Property
    Public Property National_Code() As String
        Get
            Return _national_Code
        End Get
        Set(ByVal Value As String)
            _national_Code = Value
        End Set
    End Property
    Public Property National_Des() As String
        Get
            Return _national_Des
        End Get
        Set(ByVal Value As String)
            _national_Des = Value
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
Public Class CMS_PositionInfo

#Region "Private Members"
    Private _position_ID As String = String.Empty
    Private _position_Name As String = String.Empty
    Private _position_Code As String = String.Empty
    Private _position_Des As String = String.Empty
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

    Public Property Position_ID() As String
        Get
            Return _position_ID
        End Get
        Set(ByVal Value As String)
            _position_ID = Value
        End Set
    End Property

    Public Property Position_Name() As String
        Get
            Return _position_Name
        End Get
        Set(ByVal Value As String)
            _position_Name = Value
        End Set
    End Property
    Public Property Position_Code() As String
        Get
            Return _position_Code
        End Get
        Set(ByVal Value As String)
            _position_Code = Value
        End Set
    End Property
    Public Property Position_Des() As String
        Get
            Return _position_Des
        End Get
        Set(ByVal Value As String)
            _position_Des = Value
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
Public Class CMS_PreCareerInfo

#Region "Private Members"
    Private _preCareer_ID As String = String.Empty
    Private _preCareer_Name As String = String.Empty
    Private _preCareer_Code As String = String.Empty
    Private _preCareer_Des As String = String.Empty
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

    Public Property PreCareer_ID() As String
        Get
            Return _preCareer_ID
        End Get
        Set(ByVal Value As String)
            _preCareer_ID = Value
        End Set
    End Property

    Public Property PreCareer_Name() As String
        Get
            Return _preCareer_Name
        End Get
        Set(ByVal Value As String)
            _preCareer_Name = Value
        End Set
    End Property
    Public Property PreCareer_Code() As String
        Get
            Return _preCareer_Code
        End Get
        Set(ByVal Value As String)
            _preCareer_Code = Value
        End Set
    End Property
    Public Property PreCareer_Des() As String
        Get
            Return _preCareer_Des
        End Get
        Set(ByVal Value As String)
            _preCareer_Des = Value
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
Public Class CMS_PreInduInfo

#Region "Private Members"
    Private _preIndu_ID As String = String.Empty
    Private _preIndu_Name As String = String.Empty
    Private _preIndu_Code As String = String.Empty
    Private _preIndu_Des As String = String.Empty
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

    Public Property PreIndu_ID() As String
        Get
            Return _preIndu_ID
        End Get
        Set(ByVal Value As String)
            _preIndu_ID = Value
        End Set
    End Property

    Public Property PreIndu_Name() As String
        Get
            Return _preIndu_Name
        End Get
        Set(ByVal Value As String)
            _preIndu_Name = Value
        End Set
    End Property
    Public Property PreIndu_Code() As String
        Get
            Return _preIndu_Code
        End Get
        Set(ByVal Value As String)
            _preIndu_Code = Value
        End Set
    End Property
    Public Property PreIndu_Des() As String
        Get
            Return _preIndu_Des
        End Get
        Set(ByVal Value As String)
            _preIndu_Des = Value
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
Public Class CMS_RecruitmentInfo

#Region "Private Members"
    Private _recruitment_ID As String = String.Empty
    Private _recruitment_Name As String = String.Empty
    Private _recruitment_Code As String = String.Empty
    Private _recruitment_Des As String = String.Empty
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

    Public Property Recruitment_ID() As String
        Get
            Return _recruitment_ID
        End Get
        Set(ByVal Value As String)
            _recruitment_ID = Value
        End Set
    End Property

    Public Property Recruitment_Name() As String
        Get
            Return _recruitment_Name
        End Get
        Set(ByVal Value As String)
            _recruitment_Name = Value
        End Set
    End Property
    Public Property Recruitment_Code() As String
        Get
            Return _recruitment_Code
        End Get
        Set(ByVal Value As String)
            _recruitment_Code = Value
        End Set
    End Property
    Public Property Recruitment_Des() As String
        Get
            Return _recruitment_Des
        End Get
        Set(ByVal Value As String)
            _recruitment_Des = Value
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
Public Class CMS_RegionalInfo

#Region "Private Members"
    Private _regional_ID As String = String.Empty
    Private _regional_Name As String = String.Empty
    Private _regional_Code As String = String.Empty
    Private _regional_Des As String = String.Empty
    Private _parent_ID As String = String.Empty
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

    Public Property Regional_ID() As String
        Get
            Return _regional_ID
        End Get
        Set(ByVal Value As String)
            _regional_ID = Value
        End Set
    End Property

    Public Property Regional_Name() As String
        Get
            Return _regional_Name
        End Get
        Set(ByVal Value As String)
            _regional_Name = Value
        End Set
    End Property
    Public Property Regional_Code() As String
        Get
            Return _regional_Code
        End Get
        Set(ByVal Value As String)
            _regional_Code = Value
        End Set
    End Property
    Public Property Regional_Des() As String
        Get
            Return _regional_Des
        End Get
        Set(ByVal Value As String)
            _regional_Des = Value
        End Set
    End Property
    Public Property Parent_ID() As String
        Get
            Return _parent_ID
        End Get
        Set(ByVal Value As String)
            _parent_ID = Value
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
Public Class CMS_ReligionInfo

#Region "Private Members"
    Private _religion_ID As String = String.Empty
    Private _religion_Name As String = String.Empty
    Private _religion_Code As String = String.Empty
    Private _religion_Des As String = String.Empty
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

    Public Property Religion_ID() As String
        Get
            Return _religion_ID
        End Get
        Set(ByVal Value As String)
            _religion_ID = Value
        End Set
    End Property

    Public Property Religion_Name() As String
        Get
            Return _religion_Name
        End Get
        Set(ByVal Value As String)
            _religion_Name = Value
        End Set
    End Property
    Public Property Religion_Code() As String
        Get
            Return _religion_Code
        End Get
        Set(ByVal Value As String)
            _religion_Code = Value
        End Set
    End Property
    Public Property Religion_Des() As String
        Get
            Return _religion_Des
        End Get
        Set(ByVal Value As String)
            _religion_Des = Value
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
Public Class CMS_SalaryInfo

#Region "Private Members"
    Private _salary_ID As String = String.Empty
    Private _salary_Name As String = String.Empty
    Private _salary_Price As Double
    Private _salary_Des As String = String.Empty
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

    Public Property Salary_ID() As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property

    Public Property Salary_Name() As String
        Get
            Return _salary_Name
        End Get
        Set(ByVal Value As String)
            _salary_Name = Value
        End Set
    End Property
    Public Property Salary_Price() As Double
        Get
            Return _salary_Price
        End Get
        Set(ByVal Value As Double)
            _salary_Price = Value
        End Set
    End Property
    Public Property Salary_Des() As String
        Get
            Return _salary_Des
        End Get
        Set(ByVal Value As String)
            _salary_Des = Value
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
Public Class CMS_SatelliteInfo

#Region "Private Members"
    Private _satellite_ID As String = String.Empty
    Private _satellite_Name As String = String.Empty
    Private _satellite_Code As String = String.Empty
    Private _satellite_Address As String = String.Empty
    Private _satellite_Tel As String = String.Empty
    Private _tinhTP As String = String.Empty
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

    Public Property Satellite_ID() As String
        Get
            Return _satellite_ID
        End Get
        Set(ByVal Value As String)
            _satellite_ID = Value
        End Set
    End Property

    Public Property Satellite_Name() As String
        Get
            Return _satellite_Name
        End Get
        Set(ByVal Value As String)
            _satellite_Name = Value
        End Set
    End Property
    Public Property Satellite_Code() As String
        Get
            Return _satellite_Code
        End Get
        Set(ByVal Value As String)
            _satellite_Code = Value
        End Set
    End Property
    Public Property Satellite_Address() As String
        Get
            Return _satellite_Address
        End Get
        Set(ByVal Value As String)
            _satellite_Address = Value
        End Set
    End Property
    Public Property Satellite_Tel() As String
        Get
            Return _satellite_Tel
        End Get
        Set(ByVal Value As String)
            _satellite_Tel = Value
        End Set
    End Property
    Public Property TinhTP() As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
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
Public Class CMS_SetNumberInfo

#Region "Private Members"
    Private _setNumber_ID As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _isYear As Integer
    Private _pCMS_Code As String = String.Empty
    Private _pCMS_Number As Integer
    Private _pCMS_Count As Integer
    Private _gP_Code As String = String.Empty
    Private _gP_Number As Integer
    Private _gP_Count As Integer
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

    Public Property SetNumber_ID() As String
        Get
            Return _setNumber_ID
        End Get
        Set(ByVal Value As String)
            _setNumber_ID = Value
        End Set
    End Property

    Public Property TinhTP() As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
        End Set
    End Property
    Public Property IsYear() As Integer
        Get
            Return _isYear
        End Get
        Set(ByVal Value As Integer)
            _isYear = Value
        End Set
    End Property
    Public Property PCMS_Code() As String
        Get
            Return _pCMS_Code
        End Get
        Set(ByVal Value As String)
            _pCMS_Code = Value
        End Set
    End Property
    Public Property PCMS_Number() As Integer
        Get
            Return _pCMS_Number
        End Get
        Set(ByVal Value As Integer)
            _pCMS_Number = Value
        End Set
    End Property
    Public Property PCMS_Count() As Integer
        Get
            Return _pCMS_Count
        End Get
        Set(ByVal Value As Integer)
            _pCMS_Count = Value
        End Set
    End Property
    Public Property GP_Code() As String
        Get
            Return _gP_Code
        End Get
        Set(ByVal Value As String)
            _gP_Code = Value
        End Set
    End Property
    Public Property GP_Number() As Integer
        Get
            Return _gP_Number
        End Get
        Set(ByVal Value As Integer)
            _gP_Number = Value
        End Set
    End Property
    Public Property GP_Count() As Integer
        Get
            Return _gP_Count
        End Get
        Set(ByVal Value As Integer)
            _gP_Count = Value
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
Public Class CMS_SignerInfo

#Region "Private Members"
    Private _signer_ID As String = String.Empty
    Private _signer_Name As String = String.Empty
    Private _position_ID As String = String.Empty
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

    Public Property Signer_ID() As String
        Get
            Return _signer_ID
        End Get
        Set(ByVal Value As String)
            _signer_ID = Value
        End Set
    End Property

    Public Property Signer_Name() As String
        Get
            Return _signer_Name
        End Get
        Set(ByVal Value As String)
            _signer_Name = Value
        End Set
    End Property
    Public Property Position_ID() As String
        Get
            Return _position_ID
        End Get
        Set(ByVal Value As String)
            _position_ID = Value
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
Public Class CMS_SkillInfo

#Region "Private Members"
    Private _skill_ID As String = String.Empty
    Private _skill_Name As String = String.Empty
    Private _skill_Code As String = String.Empty
    Private _skill_Des As String = String.Empty
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

    Public Property Skill_ID() As String
        Get
            Return _skill_ID
        End Get
        Set(ByVal Value As String)
            _skill_ID = Value
        End Set
    End Property

    Public Property Skill_Name() As String
        Get
            Return _skill_Name
        End Get
        Set(ByVal Value As String)
            _skill_Name = Value
        End Set
    End Property
    Public Property Skill_Code() As String
        Get
            Return _skill_Code
        End Get
        Set(ByVal Value As String)
            _skill_Code = Value
        End Set
    End Property
    Public Property Skill_Des() As String
        Get
            Return _skill_Des
        End Get
        Set(ByVal Value As String)
            _skill_Des = Value
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
Public Class CMS_SpecializedInfo

#Region "Private Members"
    Private _specialized_ID As String = String.Empty
    Private _specialized_Name As String = String.Empty
    Private _specialized_Code As String = String.Empty
    Private _specialized_Des As String = String.Empty
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

    Public Property Specialized_ID() As String
        Get
            Return _specialized_ID
        End Get
        Set(ByVal Value As String)
            _specialized_ID = Value
        End Set
    End Property

    Public Property Specialized_Name() As String
        Get
            Return _specialized_Name
        End Get
        Set(ByVal Value As String)
            _specialized_Name = Value
        End Set
    End Property
    Public Property Specialized_Code() As String
        Get
            Return _specialized_Code
        End Get
        Set(ByVal Value As String)
            _specialized_Code = Value
        End Set
    End Property
    Public Property Specialized_Des() As String
        Get
            Return _specialized_Des
        End Get
        Set(ByVal Value As String)
            _specialized_Des = Value
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
Public Class CMS_TechnicalInfo

#Region "Private Members"
    Private _technical_ID As String = String.Empty
    Private _technical_Name As String = String.Empty
    Private _technical_Code As String = String.Empty
    Private _technical_Des As String = String.Empty
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

    Public Property Technical_ID() As String
        Get
            Return _technical_ID
        End Get
        Set(ByVal Value As String)
            _technical_ID = Value
        End Set
    End Property

    Public Property Technical_Name() As String
        Get
            Return _technical_Name
        End Get
        Set(ByVal Value As String)
            _technical_Name = Value
        End Set
    End Property
    Public Property Technical_Code() As String
        Get
            Return _technical_Code
        End Get
        Set(ByVal Value As String)
            _technical_Code = Value
        End Set
    End Property
    Public Property Technical_Des() As String
        Get
            Return _technical_Des
        End Get
        Set(ByVal Value As String)
            _technical_Des = Value
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
Public Class CMS_TechnologyInfo

#Region "Private Members"
    Private _technology_ID As String = String.Empty
    Private _technology_Name As String = String.Empty
    Private _technology_Code As String = String.Empty
    Private _technology_Des As String = String.Empty
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

    Public Property Technology_ID() As String
        Get
            Return _technology_ID
        End Get
        Set(ByVal Value As String)
            _technology_ID = Value
        End Set
    End Property

    Public Property Technology_Name() As String
        Get
            Return _technology_Name
        End Get
        Set(ByVal Value As String)
            _technology_Name = Value
        End Set
    End Property
    Public Property Technology_Code() As String
        Get
            Return _technology_Code
        End Get
        Set(ByVal Value As String)
            _technology_Code = Value
        End Set
    End Property
    Public Property Technology_Des() As String
        Get
            Return _technology_Des
        End Get
        Set(ByVal Value As String)
            _technology_Des = Value
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
Public Class CMS_TerminatedInfo

#Region "Private Members"
    Private _terminated_ID As String = String.Empty
    Private _terminated_Name As String = String.Empty
    Private _terminated_Code As String = String.Empty
    Private _terminated_Des As String = String.Empty
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

    Public Property Terminated_ID() As String
        Get
            Return _terminated_ID
        End Get
        Set(ByVal Value As String)
            _terminated_ID = Value
        End Set
    End Property

    Public Property Terminated_Name() As String
        Get
            Return _terminated_Name
        End Get
        Set(ByVal Value As String)
            _terminated_Name = Value
        End Set
    End Property
    Public Property Terminated_Code() As String
        Get
            Return _terminated_Code
        End Get
        Set(ByVal Value As String)
            _terminated_Code = Value
        End Set
    End Property
    Public Property Terminated_Des() As String
        Get
            Return _terminated_Des
        End Get
        Set(ByVal Value As String)
            _terminated_Des = Value
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
Public Class CMS_TrainingInfo

#Region "Private Members"
    Private _training_ID As String = String.Empty
    Private _training_Name As String = String.Empty
    Private _training_Address As String = String.Empty
    Private _training_Boss As String = String.Empty
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

    Public Property Training_ID() As String
        Get
            Return _training_ID
        End Get
        Set(ByVal Value As String)
            _training_ID = Value
        End Set
    End Property

    Public Property Training_Name() As String
        Get
            Return _training_Name
        End Get
        Set(ByVal Value As String)
            _training_Name = Value
        End Set
    End Property
    Public Property Training_Address() As String
        Get
            Return _training_Address
        End Get
        Set(ByVal Value As String)
            _training_Address = Value
        End Set
    End Property
    Public Property Training_Boss() As String
        Get
            Return _training_Boss
        End Get
        Set(ByVal Value As String)
            _training_Boss = Value
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
Public Class CMS_UnitInfo

#Region "Private Members"
    Private _unit_ID As String = String.Empty
    Private _parent_ID As String = String.Empty
    Private _unit_Name As String = String.Empty
    Private _unit_Des As String = String.Empty
    Private _unit_Logo As String = String.Empty
    Private _unit_Images As String = String.Empty
    Private _unit_Address As String = String.Empty
    Private _unit_Tel As String = String.Empty
    Private _unit_Email As String = String.Empty
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

    Public Property Unit_ID() As String
        Get
            Return _unit_ID
        End Get
        Set(ByVal Value As String)
            _unit_ID = Value
        End Set
    End Property

    Public Property Parent_ID() As String
        Get
            Return _parent_ID
        End Get
        Set(ByVal Value As String)
            _parent_ID = Value
        End Set
    End Property
    Public Property Unit_Name() As String
        Get
            Return _unit_Name
        End Get
        Set(ByVal Value As String)
            _unit_Name = Value
        End Set
    End Property
    Public Property Unit_Des() As String
        Get
            Return _unit_Des
        End Get
        Set(ByVal Value As String)
            _unit_Des = Value
        End Set
    End Property
    Public Property Unit_Logo() As String
        Get
            Return _unit_Logo
        End Get
        Set(ByVal Value As String)
            _unit_Logo = Value
        End Set
    End Property
    Public Property Unit_Images() As String
        Get
            Return _unit_Images
        End Get
        Set(ByVal Value As String)
            _unit_Images = Value
        End Set
    End Property
    Public Property Unit_Address() As String
        Get
            Return _unit_Address
        End Get
        Set(ByVal Value As String)
            _unit_Address = Value
        End Set
    End Property
    Public Property Unit_Tel() As String
        Get
            Return _unit_Tel
        End Get
        Set(ByVal Value As String)
            _unit_Tel = Value
        End Set
    End Property
    Public Property Unit_Email() As String
        Get
            Return _unit_Email
        End Get
        Set(ByVal Value As String)
            _unit_Email = Value
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
Public Class CMS_UserConfigInfo

#Region "Private Members"
    Private _userConfig_ID As Integer
    Private _userName As String = String.Empty
    Private _moduleSrc As String = String.Empty
    Private _isNews As Boolean
    Private _isActive As Boolean
    Private _isAdmin As Boolean
    Private _isSuper As Boolean
    Private _portalID As Integer
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

    Public Property UserConfig_ID() As Integer
        Get
            Return _userConfig_ID
        End Get
        Set(ByVal Value As Integer)
            _userConfig_ID = Value
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
    Public Property ModuleSrc() As String
        Get
            Return _moduleSrc
        End Get
        Set(ByVal Value As String)
            _moduleSrc = Value
        End Set
    End Property
    Public Property IsNews() As Boolean
        Get
            Return _isNews
        End Get
        Set(ByVal Value As Boolean)
            _isNews = Value
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
    Public Property IsAdmin() As Boolean
        Get
            Return _isAdmin
        End Get
        Set(ByVal Value As Boolean)
            _isAdmin = Value
        End Set
    End Property
    Public Property IsSuper() As Boolean
        Get
            Return _isSuper
        End Get
        Set(ByVal Value As Boolean)
            _isSuper = Value
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
#End Region

End Class
Public Class CMS_RolesInfo

#Region "Private Members"
    Private _Roles_ID As Integer
    Private _Roles_Name As String = String.Empty
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

    Public Property Roles_ID() As Integer
        Get
            Return _Roles_ID
        End Get
        Set(ByVal Value As Integer)
            _Roles_ID = Value
        End Set
    End Property

    Public Property Roles_Name() As String
        Get
            Return _Roles_Name
        End Get
        Set(ByVal Value As String)
            _Roles_Name = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_WageInfo

#Region "Private Members"
    Private _wage_ID As String = String.Empty
    Private _wage_Name As String = String.Empty
    Private _wage_Code As String = String.Empty
    Private _wage_Des As String = String.Empty
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

    Public Property Wage_ID() As String
        Get
            Return _wage_ID
        End Get
        Set(ByVal Value As String)
            _wage_ID = Value
        End Set
    End Property

    Public Property Wage_Name() As String
        Get
            Return _wage_Name
        End Get
        Set(ByVal Value As String)
            _wage_Name = Value
        End Set
    End Property
    Public Property Wage_Code() As String
        Get
            Return _wage_Code
        End Get
        Set(ByVal Value As String)
            _wage_Code = Value
        End Set
    End Property
    Public Property Wage_Des() As String
        Get
            Return _wage_Des
        End Get
        Set(ByVal Value As String)
            _wage_Des = Value
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
Public Class CMS_RecipientsInfo

#Region "Private Members"
	Private _Recipients_ID As String = String.Empty
	Private _Recipients_Name As String = String.Empty
	Private _Recipients_Code As String = String.Empty
	Private _Recipients_Des As String = String.Empty
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

	Public Property Recipients_ID() As String
		Get
			Return _Recipients_ID
		End Get
		Set(ByVal Value As String)
			_Recipients_ID = Value
		End Set
	End Property

	Public Property Recipients_Name() As String
		Get
			Return _Recipients_Name
		End Get
		Set(ByVal Value As String)
			_Recipients_Name = Value
		End Set
	End Property
	Public Property Recipients_Code() As String
		Get
			Return _Recipients_Code
		End Get
		Set(ByVal Value As String)
			_Recipients_Code = Value
		End Set
	End Property
	Public Property Recipients_Des() As String
		Get
			Return _Recipients_Des
		End Get
		Set(ByVal Value As String)
			_Recipients_Des = Value
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
Public Class EXE_AdvisoryInfo

#Region "Private Members"
    Private _advisory_ID As String = String.Empty
    Private _noCode As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _soCMND As String = String.Empty
    Private _ngayCap As DateTime
    Private _noiCap As String = String.Empty
    Private _soBHXH As String = String.Empty
    Private _email As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _danToc As String = String.Empty
    Private _tonGiao As String = String.Empty
    Private _soTaiKhoan As String = String.Empty
    Private _nganHang As String = String.Empty
    Private _chiNhanhNH As String = String.Empty
    Private _tT_TinhTP As String = String.Empty
    Private _tT_QuanHuyen As String = String.Empty
    Private _tT_XaPhuong As String = String.Empty
    Private _tT_DuongPho As String = String.Empty
    Private _cO_TinhTP As String = String.Empty
    Private _cO_QuanHuyen As String = String.Empty
    Private _cO_XaPhuong As String = String.Empty
    Private _cO_DuongPho As String = String.Empty
    Private _sucKhoe As String = String.Empty
    Private _chieuCao As String = String.Empty
    Private _canNang As String = String.Empty
    Private _ngoaiNgu As String = String.Empty
    Private _giaoDucPT As String = String.Empty
    Private _tinHoc As String = String.Empty
    Private _chuyenMonKT As String = String.Empty
    Private _mucLuong As String = String.Empty
    Private _lyDoNghi As String = String.Empty
    Private _daTimViecTai As String = String.Empty
    Private _kyNangNghe As String = String.Empty
    Private _khaNangNoiTroi As String = String.Empty
    Private _tuVan_ChinhSach As Boolean
    Private _tuVan_ViecLam As Boolean
    Private _tuVan_BHTN As Boolean
    Private _tuVan_Khac As Boolean
    Private _gT_ViTri As String = String.Empty
    Private _gT_MucLuong As String = String.Empty
    Private _gT_CongViec As String = String.Empty
    Private _gT_TinhTP As Integer
    Private _gT_QuanHuyen As Integer
    Private _gT_LoaiHinh As String = String.Empty
    Private _gT_DieuKien As String = String.Empty
    Private _gT_Khac As String = String.Empty
    Private _portalID As Integer
    Private _trangThai As Integer
    Private _ngayNopHS As DateTime
    Private _ngayTiepNhan As DateTime
    Private _nguoiTiepNhan As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer


    Private _returnDate As DateTime
    Private _returnUser As String = String.Empty
    Private _returnDes As String = String.Empty
#End Region

#Region "Public Properties"

    Public Property ReturnDate() As DateTime
        Get
            Return _returnDate
        End Get
        Set(ByVal Value As DateTime)
            _returnDate = Value
        End Set
    End Property
    Public Property ReturnUser() As String
        Get
            Return _returnUser
        End Get
        Set(ByVal Value As String)
            _returnUser = Value
        End Set
    End Property
    Public Property ReturnDes() As String
        Get
            Return _returnDes
        End Get
        Set(ByVal Value As String)
            _returnDes = Value
        End Set
    End Property
    Public Property Advisory_ID As String
        Get
            Return _advisory_ID
        End Get
        Set(ByVal Value As String)
            _advisory_ID = Value
        End Set
    End Property
    Public Property NoCode As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property HoTen As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property NgaySinh As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh As Integer
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Integer)
            _gioiTinh = Value
        End Set
    End Property
    Public Property SoCMND As String
        Get
            Return _soCMND
        End Get
        Set(ByVal Value As String)
            _soCMND = Value
        End Set
    End Property
    Public Property NgayCap As DateTime
        Get
            Return _ngayCap
        End Get
        Set(ByVal Value As DateTime)
            _ngayCap = Value
        End Set
    End Property
    Public Property NoiCap As String
        Get
            Return _noiCap
        End Get
        Set(ByVal Value As String)
            _noiCap = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _soBHXH
        End Get
        Set(ByVal Value As String)
            _soBHXH = Value
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
    Public Property DienThoai As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property DanToc As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
        End Set
    End Property
    Public Property TonGiao As String
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As String)
            _tonGiao = Value
        End Set
    End Property
    Public Property SoTaiKhoan As String
        Get
            Return _soTaiKhoan
        End Get
        Set(ByVal Value As String)
            _soTaiKhoan = Value
        End Set
    End Property
    Public Property NganHang As String
        Get
            Return _nganHang
        End Get
        Set(ByVal Value As String)
            _nganHang = Value
        End Set
    End Property
    Public Property ChiNhanhNH As String
        Get
            Return _chiNhanhNH
        End Get
        Set(ByVal Value As String)
            _chiNhanhNH = Value
        End Set
    End Property
    Public Property TT_TinhTP As String
        Get
            Return _tT_TinhTP
        End Get
        Set(ByVal Value As String)
            _tT_TinhTP = Value
        End Set
    End Property
    Public Property TT_QuanHuyen As String
        Get
            Return _tT_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _tT_QuanHuyen = Value
        End Set
    End Property
    Public Property TT_XaPhuong As String
        Get
            Return _tT_XaPhuong
        End Get
        Set(ByVal Value As String)
            _tT_XaPhuong = Value
        End Set
    End Property
    Public Property TT_DuongPho As String
        Get
            Return _tT_DuongPho
        End Get
        Set(ByVal Value As String)
            _tT_DuongPho = Value
        End Set
    End Property
    Public Property CO_TinhTP As String
        Get
            Return _cO_TinhTP
        End Get
        Set(ByVal Value As String)
            _cO_TinhTP = Value
        End Set
    End Property
    Public Property CO_QuanHuyen As String
        Get
            Return _cO_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _cO_QuanHuyen = Value
        End Set
    End Property
    Public Property CO_XaPhuong As String
        Get
            Return _cO_XaPhuong
        End Get
        Set(ByVal Value As String)
            _cO_XaPhuong = Value
        End Set
    End Property
    Public Property CO_DuongPho As String
        Get
            Return _cO_DuongPho
        End Get
        Set(ByVal Value As String)
            _cO_DuongPho = Value
        End Set
    End Property
    Public Property SucKhoe As String
        Get
            Return _sucKhoe
        End Get
        Set(ByVal Value As String)
            _sucKhoe = Value
        End Set
    End Property
    Public Property ChieuCao As String
        Get
            Return _chieuCao
        End Get
        Set(ByVal Value As String)
            _chieuCao = Value
        End Set
    End Property
    Public Property CanNang As String
        Get
            Return _canNang
        End Get
        Set(ByVal Value As String)
            _canNang = Value
        End Set
    End Property
    Public Property NgoaiNgu As String
        Get
            Return _ngoaiNgu
        End Get
        Set(ByVal Value As String)
            _ngoaiNgu = Value
        End Set
    End Property
    Public Property GiaoDucPT As String
        Get
            Return _giaoDucPT
        End Get
        Set(ByVal Value As String)
            _giaoDucPT = Value
        End Set
    End Property
    Public Property TinHoc As String
        Get
            Return _tinHoc
        End Get
        Set(ByVal Value As String)
            _tinHoc = Value
        End Set
    End Property
    Public Property ChuyenMonKT As String
        Get
            Return _chuyenMonKT
        End Get
        Set(ByVal Value As String)
            _chuyenMonKT = Value
        End Set
    End Property
    Public Property MucLuong As String
        Get
            Return _mucLuong
        End Get
        Set(ByVal Value As String)
            _mucLuong = Value
        End Set
    End Property
    Public Property LyDoNghi As String
        Get
            Return _lyDoNghi
        End Get
        Set(ByVal Value As String)
            _lyDoNghi = Value
        End Set
    End Property
    Public Property DaTimViecTai As String
        Get
            Return _daTimViecTai
        End Get
        Set(ByVal Value As String)
            _daTimViecTai = Value
        End Set
    End Property
    Public Property KyNangNghe As String
        Get
            Return _kyNangNghe
        End Get
        Set(ByVal Value As String)
            _kyNangNghe = Value
        End Set
    End Property
    Public Property KhaNangNoiTroi As String
        Get
            Return _khaNangNoiTroi
        End Get
        Set(ByVal Value As String)
            _khaNangNoiTroi = Value
        End Set
    End Property
    Public Property TuVan_ChinhSach As Boolean
        Get
            Return _tuVan_ChinhSach
        End Get
        Set(ByVal Value As Boolean)
            _tuVan_ChinhSach = Value
        End Set
    End Property
    Public Property TuVan_ViecLam As Boolean
        Get
            Return _tuVan_ViecLam
        End Get
        Set(ByVal Value As Boolean)
            _tuVan_ViecLam = Value
        End Set
    End Property
    Public Property TuVan_BHTN As Boolean
        Get
            Return _tuVan_BHTN
        End Get
        Set(ByVal Value As Boolean)
            _tuVan_BHTN = Value
        End Set
    End Property
    Public Property TuVan_Khac As Boolean
        Get
            Return _tuVan_Khac
        End Get
        Set(ByVal Value As Boolean)
            _tuVan_Khac = Value
        End Set
    End Property
    Public Property GT_ViTri As String
        Get
            Return _gT_ViTri
        End Get
        Set(ByVal Value As String)
            _gT_ViTri = Value
        End Set
    End Property
    Public Property GT_MucLuong As String
        Get
            Return _gT_MucLuong
        End Get
        Set(ByVal Value As String)
            _gT_MucLuong = Value
        End Set
    End Property
    Public Property GT_CongViec As String
        Get
            Return _gT_CongViec
        End Get
        Set(ByVal Value As String)
            _gT_CongViec = Value
        End Set
    End Property
    Public Property GT_TinhTP As Integer
        Get
            Return _gT_TinhTP
        End Get
        Set(ByVal Value As Integer)
            _gT_TinhTP = Value
        End Set
    End Property
    Public Property GT_QuanHuyen As Integer
        Get
            Return _gT_QuanHuyen
        End Get
        Set(ByVal Value As Integer)
            _gT_QuanHuyen = Value
        End Set
    End Property
    Public Property GT_LoaiHinh As String
        Get
            Return _gT_LoaiHinh
        End Get
        Set(ByVal Value As String)
            _gT_LoaiHinh = Value
        End Set
    End Property
    Public Property GT_DieuKien As String
        Get
            Return _gT_DieuKien
        End Get
        Set(ByVal Value As String)
            _gT_DieuKien = Value
        End Set
    End Property
    Public Property GT_Khac As String
        Get
            Return _gT_Khac
        End Get
        Set(ByVal Value As String)
            _gT_Khac = Value
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
    Public Property TrangThai As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Integer)
            _trangThai = Value
        End Set
    End Property
    Public Property NgayNopHS As DateTime
        Get
            Return _ngayNopHS
        End Get
        Set(ByVal Value As DateTime)
            _ngayNopHS = Value
        End Set
    End Property
    Public Property NgayTiepNhan As DateTime
        Get
            Return _ngayTiepNhan
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiepNhan = Value
        End Set
    End Property
    Public Property NguoiTiepNhan As String
        Get
            Return _nguoiTiepNhan
        End Get
        Set(ByVal Value As String)
            _nguoiTiepNhan = Value
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
Public Class EXE_AdvisoryCInfo

#Region "Private Members"
    Private _advisoryC_ID As String = String.Empty
    Private _advisory_ID As String = String.Empty
    Private _company As String = String.Empty
    Private _timeWork As String = String.Empty
    Private _location As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AdvisoryC_ID As String
        Get
            Return _advisoryC_ID
        End Get
        Set(ByVal Value As String)
            _advisoryC_ID = Value
        End Set
    End Property
    Public Property Advisory_ID As String
        Get
            Return _advisory_ID
        End Get
        Set(ByVal Value As String)
            _advisory_ID = Value
        End Set
    End Property
    Public Property Company As String
        Get
            Return _company
        End Get
        Set(ByVal Value As String)
            _company = Value
        End Set
    End Property
    Public Property TimeWork As String
        Get
            Return _timeWork
        End Get
        Set(ByVal Value As String)
            _timeWork = Value
        End Set
    End Property
    Public Property Location As String
        Get
            Return _location
        End Get
        Set(ByVal Value As String)
            _location = Value
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
Public Class EXE_AdvisorySInfo

#Region "Private Members"
    Private _advisoryS_ID As String = String.Empty
    Private _advisory_ID As String = String.Empty
    Private _specialized As String = String.Empty
    Private _levelName As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AdvisoryS_ID As String
        Get
            Return _advisoryS_ID
        End Get
        Set(ByVal Value As String)
            _advisoryS_ID = Value
        End Set
    End Property
    Public Property Advisory_ID As String
        Get
            Return _advisory_ID
        End Get
        Set(ByVal Value As String)
            _advisory_ID = Value
        End Set
    End Property
    Public Property Specialized As String
        Get
            Return _specialized
        End Get
        Set(ByVal Value As String)
            _specialized = Value
        End Set
    End Property
    Public Property LevelName As String
        Get
            Return _levelName
        End Get
        Set(ByVal Value As String)
            _levelName = Value
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
Public Class EXE_ApprenticeInfo

#Region "Private Members"
    Private _apprentice_ID As String = String.Empty
    Private _noCode As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _soCMND As String = String.Empty
    Private _ngayCap As DateTime
    Private _noiCap As String = String.Empty
    Private _soBHXH As String = String.Empty
    Private _email As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _danToc As String = String.Empty
    Private _tonGiao As String = String.Empty
    Private _cO_TinhTP As String = String.Empty
    Private _cO_QuanHuyen As String = String.Empty
    Private _cO_XaPhuong As String = String.Empty
    Private _cO_DuongPho As String = String.Empty
    Private _thangDong As Double
    Private _thangHuong As Double
    Private _qDH_So As String = String.Empty
    Private _qDH_TuNgay As DateTime
    Private _qDH_DenNgay As DateTime
    Private _coSoDT As String = String.Empty
    Private _khoaDT As String = String.Empty
    Private _thoiGianDT As Double
    Private _hocPhi As Double
    Private _tenTepDK As String = String.Empty
    Private _duongDanDK As String = String.Empty
    Private _portalID As Integer
    Private _trangThai As Integer
    Private _ngayNopHS As DateTime
    Private _ngayTiepNhan As DateTime
    Private _nguoiTiepNhan As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer


    Private _returnDate As DateTime
    Private _returnUser As String = String.Empty
    Private _returnDes As String = String.Empty
#End Region

#Region "Public Properties"

    Public Property ReturnDate() As DateTime
        Get
            Return _returnDate
        End Get
        Set(ByVal Value As DateTime)
            _returnDate = Value
        End Set
    End Property
    Public Property ReturnUser() As String
        Get
            Return _returnUser
        End Get
        Set(ByVal Value As String)
            _returnUser = Value
        End Set
    End Property
    Public Property ReturnDes() As String
        Get
            Return _returnDes
        End Get
        Set(ByVal Value As String)
            _returnDes = Value
        End Set
    End Property
    Public Property Apprentice_ID As String
        Get
            Return _apprentice_ID
        End Get
        Set(ByVal Value As String)
            _apprentice_ID = Value
        End Set
    End Property
    Public Property NoCode As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property HoTen As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property NgaySinh As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh As Integer
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Integer)
            _gioiTinh = Value
        End Set
    End Property
    Public Property SoCMND As String
        Get
            Return _soCMND
        End Get
        Set(ByVal Value As String)
            _soCMND = Value
        End Set
    End Property
    Public Property NgayCap As DateTime
        Get
            Return _ngayCap
        End Get
        Set(ByVal Value As DateTime)
            _ngayCap = Value
        End Set
    End Property
    Public Property NoiCap As String
        Get
            Return _noiCap
        End Get
        Set(ByVal Value As String)
            _noiCap = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _soBHXH
        End Get
        Set(ByVal Value As String)
            _soBHXH = Value
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
    Public Property DienThoai As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property DanToc As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
        End Set
    End Property
    Public Property TonGiao As String
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As String)
            _tonGiao = Value
        End Set
    End Property
    Public Property CO_TinhTP As String
        Get
            Return _cO_TinhTP
        End Get
        Set(ByVal Value As String)
            _cO_TinhTP = Value
        End Set
    End Property
    Public Property CO_QuanHuyen As String
        Get
            Return _cO_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _cO_QuanHuyen = Value
        End Set
    End Property
    Public Property CO_XaPhuong As String
        Get
            Return _cO_XaPhuong
        End Get
        Set(ByVal Value As String)
            _cO_XaPhuong = Value
        End Set
    End Property
    Public Property CO_DuongPho As String
        Get
            Return _cO_DuongPho
        End Get
        Set(ByVal Value As String)
            _cO_DuongPho = Value
        End Set
    End Property
    Public Property ThangDong As Double
        Get
            Return _thangDong
        End Get
        Set(ByVal Value As Double)
            _thangDong = Value
        End Set
    End Property
    Public Property ThangHuong As Double
        Get
            Return _thangHuong
        End Get
        Set(ByVal Value As Double)
            _thangHuong = Value
        End Set
    End Property
    Public Property QDH_So As String
        Get
            Return _qDH_So
        End Get
        Set(ByVal Value As String)
            _qDH_So = Value
        End Set
    End Property
    Public Property QDH_TuNgay As DateTime
        Get
            Return _qDH_TuNgay
        End Get
        Set(ByVal Value As DateTime)
            _qDH_TuNgay = Value
        End Set
    End Property
    Public Property QDH_DenNgay As DateTime
        Get
            Return _qDH_DenNgay
        End Get
        Set(ByVal Value As DateTime)
            _qDH_DenNgay = Value
        End Set
    End Property
    Public Property CoSoDT As String
        Get
            Return _coSoDT
        End Get
        Set(ByVal Value As String)
            _coSoDT = Value
        End Set
    End Property
    Public Property KhoaDT As String
        Get
            Return _khoaDT
        End Get
        Set(ByVal Value As String)
            _khoaDT = Value
        End Set
    End Property
    Public Property ThoiGianDT As Double
        Get
            Return _thoiGianDT
        End Get
        Set(ByVal Value As Double)
            _thoiGianDT = Value
        End Set
    End Property
    Public Property HocPhi As Double
        Get
            Return _hocPhi
        End Get
        Set(ByVal Value As Double)
            _hocPhi = Value
        End Set
    End Property
    Public Property TenTepDK As String
        Get
            Return _tenTepDK
        End Get
        Set(ByVal Value As String)
            _tenTepDK = Value
        End Set
    End Property
    Public Property DuongDanDK As String
        Get
            Return _duongDanDK
        End Get
        Set(ByVal Value As String)
            _duongDanDK = Value
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
    Public Property TrangThai As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Integer)
            _trangThai = Value
        End Set
    End Property
    Public Property NgayNopHS As DateTime
        Get
            Return _ngayNopHS
        End Get
        Set(ByVal Value As DateTime)
            _ngayNopHS = Value
        End Set
    End Property
    Public Property NgayTiepNhan As DateTime
        Get
            Return _ngayTiepNhan
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiepNhan = Value
        End Set
    End Property
    Public Property NguoiTiepNhan As String
        Get
            Return _nguoiTiepNhan
        End Get
        Set(ByVal Value As String)
            _nguoiTiepNhan = Value
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
Public Class EXE_ProSubsiInfo

#Region "Private Members"
    Private _proSubsi_ID As String = String.Empty
    Private _noCode As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _soCMND As String = String.Empty
    Private _ngayCap As DateTime
    Private _noiCap As String = String.Empty
    Private _soBHXH As String = String.Empty
    Private _email As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _danToc As String = String.Empty
    Private _tonGiao As String = String.Empty
    Private _soTaiKhoan As String = String.Empty
    Private _nganHang As String = String.Empty
    Private _chiNhanhNH As String = String.Empty
    Private _tT_TinhTP As String = String.Empty
    Private _tT_QuanHuyen As String = String.Empty
    Private _tT_XaPhuong As String = String.Empty
    Private _tT_DuongPho As String = String.Empty
    Private _cO_TinhTP As String = String.Empty
    Private _cO_QuanHuyen As String = String.Empty
    Private _cO_XaPhuong As String = String.Empty
    Private _cO_DuongPho As String = String.Empty
    Private _nganhDT As String = String.Empty
    Private _trinhDo As String = String.Empty
    Private _ngayNghiViec As DateTime
    Private _thangDong As Double
    Private _loaiHD As String = String.Empty
    Private _congTy As String = String.Empty
    Private _soDKKD As String = String.Empty
    Private _cT_TinhTP As String = String.Empty
    Private _cT_QuanHuyen As String = String.Empty
    Private _cT_XaPhuong As String = String.Empty
    Private _cT_DuongPho As String = String.Empty
    Private _noiNhanTCTN As String = String.Empty
    Private _noiDKKCB As String = String.Empty
    Private _nguyenNhanNV As String = String.Empty
    Private _ngheTruocNghi As String = String.Empty
    Private _nganhTruocNghi As String = String.Empty
    Private _tenTepDK As String = String.Empty
    Private _duongDanDK As String = String.Empty
    Private _portalID As Integer
    Private _trangThai As Integer
    Private _ngayNopHS As DateTime
    Private _ngayTiepNhan As DateTime
    Private _nguoiTiepNhan As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer

    Private _returnDate As DateTime
    Private _returnUser As String = String.Empty
    Private _returnDes As String = String.Empty
    Private _MaPhieuHen As String = String.Empty
    Private _QRCode As String = String.Empty
    Private _NgayTraKetQua As DateTime
#End Region

#Region "Public Properties"

    Public Property MaPhieuHen() As String
        Get
            Return _MaPhieuHen
        End Get
        Set(ByVal value As String)
            _MaPhieuHen = value
        End Set
    End Property

    Public Property QRCode() As String
        Get
            Return _QRCode
        End Get
        Set(ByVal value As String)
            _QRCode = value
        End Set
    End Property

    Public Property NgayTraKetQua() As DateTime
        Get
            Return _NgayTraKetQua
        End Get
        Set(ByVal value As DateTime)
            _NgayTraKetQua = value
        End Set
    End Property
    Private _isType As Integer
    Public Property IsType() As Integer
        Get
            Return _isType
        End Get
        Set(ByVal value As Integer)
            _isType = value
        End Set
    End Property
    Public Property ReturnDate() As DateTime
        Get
            Return _returnDate
        End Get
        Set(ByVal Value As DateTime)
            _returnDate = Value
        End Set
    End Property
    Public Property ReturnUser() As String
        Get
            Return _returnUser
        End Get
        Set(ByVal Value As String)
            _returnUser = Value
        End Set
    End Property
    Public Property ReturnDes() As String
        Get
            Return _returnDes
        End Get
        Set(ByVal Value As String)
            _returnDes = Value
        End Set
    End Property
    Public Property ProSubsi_ID As String
        Get
            Return _proSubsi_ID
        End Get
        Set(ByVal Value As String)
            _proSubsi_ID = Value
        End Set
    End Property
    Public Property NoCode As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property HoTen As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property NgaySinh As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh As Integer
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Integer)
            _gioiTinh = Value
        End Set
    End Property
    Public Property SoCMND As String
        Get
            Return _soCMND
        End Get
        Set(ByVal Value As String)
            _soCMND = Value
        End Set
    End Property
    Public Property NgayCap As DateTime
        Get
            Return _ngayCap
        End Get
        Set(ByVal Value As DateTime)
            _ngayCap = Value
        End Set
    End Property
    Public Property NoiCap As String
        Get
            Return _noiCap
        End Get
        Set(ByVal Value As String)
            _noiCap = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _soBHXH
        End Get
        Set(ByVal Value As String)
            _soBHXH = Value
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
    Public Property DienThoai As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property DanToc As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
        End Set
    End Property
    Public Property TonGiao As String
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As String)
            _tonGiao = Value
        End Set
    End Property
    Public Property SoTaiKhoan As String
        Get
            Return _soTaiKhoan
        End Get
        Set(ByVal Value As String)
            _soTaiKhoan = Value
        End Set
    End Property
    Public Property NganHang As String
        Get
            Return _nganHang
        End Get
        Set(ByVal Value As String)
            _nganHang = Value
        End Set
    End Property
    Public Property ChiNhanhNH As String
        Get
            Return _chiNhanhNH
        End Get
        Set(ByVal Value As String)
            _chiNhanhNH = Value
        End Set
    End Property
    Public Property TT_TinhTP As String
        Get
            Return _tT_TinhTP
        End Get
        Set(ByVal Value As String)
            _tT_TinhTP = Value
        End Set
    End Property
    Public Property TT_QuanHuyen As String
        Get
            Return _tT_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _tT_QuanHuyen = Value
        End Set
    End Property
    Public Property TT_XaPhuong As String
        Get
            Return _tT_XaPhuong
        End Get
        Set(ByVal Value As String)
            _tT_XaPhuong = Value
        End Set
    End Property
    Public Property TT_DuongPho As String
        Get
            Return _tT_DuongPho
        End Get
        Set(ByVal Value As String)
            _tT_DuongPho = Value
        End Set
    End Property
    Public Property CO_TinhTP As String
        Get
            Return _cO_TinhTP
        End Get
        Set(ByVal Value As String)
            _cO_TinhTP = Value
        End Set
    End Property
    Public Property CO_QuanHuyen As String
        Get
            Return _cO_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _cO_QuanHuyen = Value
        End Set
    End Property
    Public Property CO_XaPhuong As String
        Get
            Return _cO_XaPhuong
        End Get
        Set(ByVal Value As String)
            _cO_XaPhuong = Value
        End Set
    End Property
    Public Property CO_DuongPho As String
        Get
            Return _cO_DuongPho
        End Get
        Set(ByVal Value As String)
            _cO_DuongPho = Value
        End Set
    End Property
    Public Property NganhDT As String
        Get
            Return _nganhDT
        End Get
        Set(ByVal Value As String)
            _nganhDT = Value
        End Set
    End Property
    Public Property TrinhDo As String
        Get
            Return _trinhDo
        End Get
        Set(ByVal Value As String)
            _trinhDo = Value
        End Set
    End Property
    Public Property NgayNghiViec As DateTime
        Get
            Return _ngayNghiViec
        End Get
        Set(ByVal Value As DateTime)
            _ngayNghiViec = Value
        End Set
    End Property
    Public Property ThangDong As Double
        Get
            Return _thangDong
        End Get
        Set(ByVal Value As Double)
            _thangDong = Value
        End Set
    End Property
    Public Property LoaiHD As String
        Get
            Return _loaiHD
        End Get
        Set(ByVal Value As String)
            _loaiHD = Value
        End Set
    End Property
    Public Property CongTy As String
        Get
            Return _congTy
        End Get
        Set(ByVal Value As String)
            _congTy = Value
        End Set
    End Property
    Public Property SoDKKD As String
        Get
            Return _soDKKD
        End Get
        Set(ByVal Value As String)
            _soDKKD = Value
        End Set
    End Property
    Public Property CT_TinhTP As String
        Get
            Return _cT_TinhTP
        End Get
        Set(ByVal Value As String)
            _cT_TinhTP = Value
        End Set
    End Property
    Public Property CT_QuanHuyen As String
        Get
            Return _cT_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _cT_QuanHuyen = Value
        End Set
    End Property
    Public Property CT_XaPhuong As String
        Get
            Return _cT_XaPhuong
        End Get
        Set(ByVal Value As String)
            _cT_XaPhuong = Value
        End Set
    End Property
    Public Property CT_DuongPho As String
        Get
            Return _cT_DuongPho
        End Get
        Set(ByVal Value As String)
            _cT_DuongPho = Value
        End Set
    End Property
    Public Property NoiNhanTCTN As String
        Get
            Return _noiNhanTCTN
        End Get
        Set(ByVal Value As String)
            _noiNhanTCTN = Value
        End Set
    End Property
    Public Property NoiDKKCB As String
        Get
            Return _noiDKKCB
        End Get
        Set(ByVal Value As String)
            _noiDKKCB = Value
        End Set
    End Property
    Public Property NguyenNhanNV As String
        Get
            Return _nguyenNhanNV
        End Get
        Set(ByVal Value As String)
            _nguyenNhanNV = Value
        End Set
    End Property
    Public Property NgheTruocNghi As String
        Get
            Return _ngheTruocNghi
        End Get
        Set(ByVal Value As String)
            _ngheTruocNghi = Value
        End Set
    End Property
    Public Property NganhTruocNghi As String
        Get
            Return _nganhTruocNghi
        End Get
        Set(ByVal Value As String)
            _nganhTruocNghi = Value
        End Set
    End Property
    Public Property TenTepDK As String
        Get
            Return _tenTepDK
        End Get
        Set(ByVal Value As String)
            _tenTepDK = Value
        End Set
    End Property
    Public Property DuongDanDK As String
        Get
            Return _duongDanDK
        End Get
        Set(ByVal Value As String)
            _duongDanDK = Value
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
    Public Property TrangThai As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Integer)
            _trangThai = Value
        End Set
    End Property
    Public Property NgayNopHS As DateTime
        Get
            Return _ngayNopHS
        End Get
        Set(ByVal Value As DateTime)
            _ngayNopHS = Value
        End Set
    End Property
    Public Property NgayTiepNhan As DateTime
        Get
            Return _ngayTiepNhan
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiepNhan = Value
        End Set
    End Property
    Public Property NguoiTiepNhan As String
        Get
            Return _nguoiTiepNhan
        End Get
        Set(ByVal Value As String)
            _nguoiTiepNhan = Value
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
Public Class EXE_NotificationInfo

#Region "Private Members"
    Private _notification_ID As String = String.Empty
    Private _decide_ID As String = String.Empty
    Private _noCode As String = String.Empty
    Private _thangHuong As Integer
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _soCMND As String = String.Empty
    Private _ngayCap As DateTime
    Private _noiCap As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _cO_TinhTP As String = String.Empty
    Private _cO_QuanHuyen As String = String.Empty
    Private _cO_XaPhuong As String = String.Empty
    Private _cO_DuongPho As String = String.Empty
    Private _qD_So As String = String.Empty
    Private _qD_Ngay As DateTime
    Private _qD_ThangHuong As Integer
    Private _qD_TuNgay As DateTime
    Private _qD_DenNgay As DateTime
    Private _qD_TinhTP As String = String.Empty
    Private _tinhTrang As Integer
    Private _neuCoVL As String = String.Empty
    Private _tT_Khac As String = String.Empty
    Private _portalID As Integer
    Private _trangThai As Integer
    Private _ngayNopHS As DateTime
    Private _ngayTiepNhan As DateTime
    Private _nguoiTiepNhan As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _returnDate As DateTime
    Private _returnUser As String = String.Empty
    Private _returnDes As String = String.Empty
    Private _QD_VeTinh As String
#End Region

#Region "Public Properties"
    Public Property QD_VeTinh As String
        Get
            Return _QD_VeTinh
        End Get
        Set(ByVal Value As String)
            _QD_VeTinh = Value
        End Set
    End Property
    Public Property Decide_ID As String
        Get
            Return _decide_ID
        End Get
        Set(ByVal Value As String)
            _decide_ID = Value
        End Set
    End Property
    Public Property ReturnDate() As DateTime
        Get
            Return _returnDate
        End Get
        Set(ByVal Value As DateTime)
            _returnDate = Value
        End Set
    End Property
    Public Property ReturnUser() As String
        Get
            Return _returnUser
        End Get
        Set(ByVal Value As String)
            _returnUser = Value
        End Set
    End Property
    Public Property ReturnDes() As String
        Get
            Return _returnDes
        End Get
        Set(ByVal Value As String)
            _returnDes = Value
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
    Public Property Notification_ID() As String
        Get
            Return _notification_ID
        End Get
        Set(ByVal Value As String)
            _notification_ID = Value
        End Set
    End Property
    Public Property NoCode() As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property ThangHuong() As Integer
        Get
            Return _thangHuong
        End Get
        Set(ByVal Value As Integer)
            _thangHuong = Value
        End Set
    End Property
    Public Property HoTen() As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property NgaySinh() As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Integer
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Integer)
            _gioiTinh = Value
        End Set
    End Property
    Public Property SoCMND() As String
        Get
            Return _soCMND
        End Get
        Set(ByVal Value As String)
            _soCMND = Value
        End Set
    End Property
    Public Property NgayCap() As DateTime
        Get
            Return _ngayCap
        End Get
        Set(ByVal Value As DateTime)
            _ngayCap = Value
        End Set
    End Property
    Public Property NoiCap() As String
        Get
            Return _noiCap
        End Get
        Set(ByVal Value As String)
            _noiCap = Value
        End Set
    End Property
    Public Property DienThoai() As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property
    Public Property CO_TinhTP() As String
        Get
            Return _cO_TinhTP
        End Get
        Set(ByVal Value As String)
            _cO_TinhTP = Value
        End Set
    End Property
    Public Property CO_QuanHuyen() As String
        Get
            Return _cO_QuanHuyen
        End Get
        Set(ByVal Value As String)
            _cO_QuanHuyen = Value
        End Set
    End Property
    Public Property CO_XaPhuong() As String
        Get
            Return _cO_XaPhuong
        End Get
        Set(ByVal Value As String)
            _cO_XaPhuong = Value
        End Set
    End Property
    Public Property CO_DuongPho() As String
        Get
            Return _cO_DuongPho
        End Get
        Set(ByVal Value As String)
            _cO_DuongPho = Value
        End Set
    End Property
    Public Property QD_So() As String
        Get
            Return _qD_So
        End Get
        Set(ByVal Value As String)
            _qD_So = Value
        End Set
    End Property
    Public Property QD_Ngay() As DateTime
        Get
            Return _qD_Ngay
        End Get
        Set(ByVal Value As DateTime)
            _qD_Ngay = Value
        End Set
    End Property
    Public Property QD_ThangHuong() As Integer
        Get
            Return _qD_ThangHuong
        End Get
        Set(ByVal Value As Integer)
            _qD_ThangHuong = Value
        End Set
    End Property
    Public Property QD_TuNgay() As DateTime
        Get
            Return _qD_TuNgay
        End Get
        Set(ByVal Value As DateTime)
            _qD_TuNgay = Value
        End Set
    End Property
    Public Property QD_DenNgay() As DateTime
        Get
            Return _qD_DenNgay
        End Get
        Set(ByVal Value As DateTime)
            _qD_DenNgay = Value
        End Set
    End Property
    Public Property QD_TinhTP() As String
        Get
            Return _qD_TinhTP
        End Get
        Set(ByVal Value As String)
            _qD_TinhTP = Value
        End Set
    End Property
    Public Property TinhTrang() As Integer
        Get
            Return _tinhTrang
        End Get
        Set(ByVal Value As Integer)
            _tinhTrang = Value
        End Set
    End Property
    Public Property NeuCoVL() As String
        Get
            Return _neuCoVL
        End Get
        Set(ByVal Value As String)
            _neuCoVL = Value
        End Set
    End Property
    Public Property TT_Khac() As String
        Get
            Return _tT_Khac
        End Get
        Set(ByVal Value As String)
            _tT_Khac = Value
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
    Public Property TrangThai() As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Integer)
            _trangThai = Value
        End Set
    End Property
    Public Property NgayNopHS() As DateTime
        Get
            Return _ngayNopHS
        End Get
        Set(ByVal Value As DateTime)
            _ngayNopHS = Value
        End Set
    End Property
    Public Property NgayTiepNhan() As DateTime
        Get
            Return _ngayTiepNhan
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiepNhan = Value
        End Set
    End Property
    Public Property NguoiTiepNhan() As String
        Get
            Return _nguoiTiepNhan
        End Get
        Set(ByVal Value As String)
            _nguoiTiepNhan = Value
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
Public Class EXE_NotificationDInfo

#Region "Private Members"
    Private _notificationD_ID As String = String.Empty
    Private _notification_ID As String = String.Empty
    Private _tenDonVi As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _nguoiLienHe As String = String.Empty
    Private _viTriDuTuyen As String = String.Empty
    Private _ketQua As String = String.Empty
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

    Public Property NotificationD_ID() As String
        Get
            Return _notificationD_ID
        End Get
        Set(ByVal Value As String)
            _notificationD_ID = Value
        End Set
    End Property

    Public Property Notification_ID() As String
        Get
            Return _notification_ID
        End Get
        Set(ByVal Value As String)
            _notification_ID = Value
        End Set
    End Property
    Public Property TenDonVi() As String
        Get
            Return _tenDonVi
        End Get
        Set(ByVal Value As String)
            _tenDonVi = Value
        End Set
    End Property
    Public Property DiaChi() As String
        Get
            Return _diaChi
        End Get
        Set(ByVal Value As String)
            _diaChi = Value
        End Set
    End Property
    Public Property NguoiLienHe() As String
        Get
            Return _nguoiLienHe
        End Get
        Set(ByVal Value As String)
            _nguoiLienHe = Value
        End Set
    End Property
    Public Property ViTriDuTuyen() As String
        Get
            Return _viTriDuTuyen
        End Get
        Set(ByVal Value As String)
            _viTriDuTuyen = Value
        End Set
    End Property
    Public Property KetQua() As String
        Get
            Return _ketQua
        End Get
        Set(ByVal Value As String)
            _ketQua = Value
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
Public Class EXE_NumberAutoInfo

#Region "Private Members"
    Private _numberAuto_ID As String = String.Empty
    Private _noCode As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _soBHXH As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _ngayNghiViec As DateTime
    Private _dichVu As Integer
    Private _thuTu As Integer
    Private _portalID As Integer
    Private _veTinhID As String = String.Empty
    Private _sangChieu As String = String.Empty
    Private _timeAutoID As Integer
    Private _gioDangKy As String = String.Empty
    Private _ngayDangKy As DateTime
    Private _tinhTrang As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _isOnline As Boolean
#End Region

#Region "Public Properties"
    Public Property IsOnline As Boolean
        Get
            Return _isOnline
        End Get
        Set(ByVal Value As Boolean)
            _isOnline = Value
        End Set
    End Property
    Public Property NumberAuto_ID As String
        Get
            Return _numberAuto_ID
        End Get
        Set(ByVal Value As String)
            _numberAuto_ID = Value
        End Set
    End Property
    Public Property NoCode As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property HoTen As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property DienThoai As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _soBHXH
        End Get
        Set(ByVal Value As String)
            _soBHXH = Value
        End Set
    End Property
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property NgayNghiViec As DateTime
        Get
            Return _ngayNghiViec
        End Get
        Set(ByVal Value As DateTime)
            _ngayNghiViec = Value
        End Set
    End Property
    Public Property DichVu As Integer
        Get
            Return _dichVu
        End Get
        Set(ByVal Value As Integer)
            _dichVu = Value
        End Set
    End Property
    Public Property ThuTu As Integer
        Get
            Return _thuTu
        End Get
        Set(ByVal Value As Integer)
            _thuTu = Value
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
    Public Property VeTinhID As String
        Get
            Return _veTinhID
        End Get
        Set(ByVal Value As String)
            _veTinhID = Value
        End Set
    End Property
    Public Property SangChieu As String
        Get
            Return _sangChieu
        End Get
        Set(ByVal Value As String)
            _sangChieu = Value
        End Set
    End Property
    Public Property TimeAutoID As Integer
        Get
            Return _timeAutoID
        End Get
        Set(ByVal Value As Integer)
            _timeAutoID = Value
        End Set
    End Property
    Public Property GioDangKy As String
        Get
            Return _gioDangKy
        End Get
        Set(ByVal Value As String)
            _gioDangKy = Value
        End Set
    End Property
    Public Property NgayDangKy As DateTime
        Get
            Return _ngayDangKy
        End Get
        Set(ByVal Value As DateTime)
            _ngayDangKy = Value
        End Set
    End Property
    Public Property TinhTrang As Integer
        Get
            Return _tinhTrang
        End Get
        Set(ByVal Value As Integer)
            _tinhTrang = Value
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
Public Class CMS_DashInfo
#Region "Private Members"
    Private _dashNum1 As String = String.Empty
    Private _dashNum2 As String = String.Empty
    Private _dashNum3 As String = String.Empty
    Private _dashNum4 As String = String.Empty
    Private _dashNum5 As String = String.Empty
    Private _dashNum6 As String = String.Empty
    Private _dashNum7 As String = String.Empty
    Private _dashNum8 As String = String.Empty
#End Region
#Region "Public Properties"
    Public Property DashNum8 As String
        Get
            Return _dashNum8
        End Get
        Set(ByVal Value As String)
            _dashNum8 = Value
        End Set
    End Property
    Public Property DashNum5 As String
        Get
            Return _dashNum5
        End Get
        Set(ByVal Value As String)
            _dashNum5 = Value
        End Set
    End Property
    Public Property DashNum6 As String
        Get
            Return _dashNum6
        End Get
        Set(ByVal Value As String)
            _dashNum6 = Value
        End Set
    End Property
    Public Property DashNum7 As String
        Get
            Return _dashNum7
        End Get
        Set(ByVal Value As String)
            _dashNum7 = Value
        End Set
    End Property
    Public Property DashNum3 As String
        Get
            Return _dashNum3
        End Get
        Set(ByVal Value As String)
            _dashNum3 = Value
        End Set
    End Property
    Public Property DashNum4 As String
        Get
            Return _dashNum4
        End Get
        Set(ByVal Value As String)
            _dashNum4 = Value
        End Set
    End Property
    Public Property DashNum2 As String
        Get
            Return _dashNum2
        End Get
        Set(ByVal Value As String)
            _dashNum2 = Value
        End Set
    End Property
    Public Property DashNum1 As String
        Get
            Return _dashNum1
        End Get
        Set(ByVal Value As String)
            _dashNum1 = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_SettingAutoInfo

#Region "Private Members"
    Private _iD As Integer
    Private _satellite_ID As String = String.Empty
    Private _portal_ID As Integer
    Private _numDoor As Integer
    Private _flagType As Integer
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Satellite_ID() As String
        Get
            Return _satellite_ID
        End Get
        Set(ByVal Value As String)
            _satellite_ID = Value
        End Set
    End Property
    Public Property Portal_ID() As Integer
        Get
            Return _portal_ID
        End Get
        Set(ByVal Value As Integer)
            _portal_ID = Value
        End Set
    End Property
    Public Property NumDoor() As Integer
        Get
            Return _numDoor
        End Get
        Set(ByVal Value As Integer)
            _numDoor = Value
        End Set
    End Property
    Public Property FlagType() As Integer
        Get
            Return _flagType
        End Get
        Set(ByVal Value As Integer)
            _flagType = Value
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
Public Class CMS_SettingDoorInfo

#Region "Private Members"
    Private _iD As Integer
    Private _satellite_ID As String = String.Empty
    Private _portal_ID As Integer
    Private _FlagType As Integer
    Private _DayText As String
    Private _dateSetting As Integer
    Private _MonthSetting As Integer
    Private _YearSetting As Integer
    Private _numDoor As Integer
    Private _saWelcome As Integer
    Private _chWelcome As Integer
    Private _sumWelcome As Integer
    Private _saRegister As Integer
    Private _chRegister As Integer
    Private _sumExist As Integer
    Private _notes As String = String.Empty
    Private _isDayOff As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property SumWelcome As Integer
        Get
            Return _sumWelcome
        End Get
        Set(ByVal Value As Integer)
            _sumWelcome = Value
        End Set
    End Property
    Public Property IsDayOff As Boolean
        Get
            Return _isDayOff
        End Get
        Set(ByVal Value As Boolean)
            _isDayOff = Value
        End Set
    End Property
    Public Property DayText As String
        Get
            Return _DayText
        End Get
        Set(ByVal Value As String)
            _DayText = Value
        End Set
    End Property
    Public Property CHWelcome As Integer
        Get
            Return _chWelcome
        End Get
        Set(ByVal Value As Integer)
            _chWelcome = Value
        End Set
    End Property
    Public Property CHRegister As Integer
        Get
            Return _chRegister
        End Get
        Set(ByVal Value As Integer)
            _chRegister = Value
        End Set
    End Property
    Public Property FlagType As Integer
        Get
            Return _FlagType
        End Get
        Set(ByVal Value As Integer)
            _FlagType = Value
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

    Public Property Satellite_ID() As String
        Get
            Return _satellite_ID
        End Get
        Set(ByVal Value As String)
            _satellite_ID = Value
        End Set
    End Property
    Public Property Portal_ID() As Integer
        Get
            Return _portal_ID
        End Get
        Set(ByVal Value As Integer)
            _portal_ID = Value
        End Set
    End Property
    Public Property MonthSetting() As Integer
        Get
            Return _MonthSetting
        End Get
        Set(ByVal Value As Integer)
            _MonthSetting = Value
        End Set
    End Property
    Public Property YearSetting() As Integer
        Get
            Return _YearSetting
        End Get
        Set(ByVal Value As Integer)
            _YearSetting = Value
        End Set
    End Property
    Public Property DateSetting() As Integer
        Get
            Return _dateSetting
        End Get
        Set(ByVal Value As Integer)
            _dateSetting = Value
        End Set
    End Property
    Public Property NumDoor() As Integer
        Get
            Return _numDoor
        End Get
        Set(ByVal Value As Integer)
            _numDoor = Value
        End Set
    End Property
    Public Property SAWelcome() As Integer
        Get
            Return _saWelcome
        End Get
        Set(ByVal Value As Integer)
            _saWelcome = Value
        End Set
    End Property
    Public Property SARegister() As Integer
        Get
            Return _saRegister
        End Get
        Set(ByVal Value As Integer)
            _saRegister = Value
        End Set
    End Property
    Public Property SumExist() As Integer
        Get
            Return _sumExist
        End Get
        Set(ByVal Value As Integer)
            _sumExist = Value
        End Set
    End Property
    Public Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal Value As String)
            _notes = Value
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
Public Class CMS_SettingTimeInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _settingAuto_ID As Integer
    Private _fromTime As TimeSpan
    Private _toTime As TimeSpan
    Private _isMorning As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property IsMorning As Integer
        Get
            Return _isMorning
        End Get
        Set(ByVal Value As Integer)
            _isMorning = Value
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

    Public Property ID() As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
        End Set
    End Property

    Public Property SettingAuto_ID() As Integer
        Get
            Return _settingAuto_ID
        End Get
        Set(ByVal Value As Integer)
            _settingAuto_ID = Value
        End Set
    End Property
    Public Property FromTime() As TimeSpan
        Get
            Return _fromTime
        End Get
        Set(ByVal Value As TimeSpan)
            _fromTime = Value
        End Set
    End Property
    Public Property ToTime() As TimeSpan
        Get
            Return _toTime
        End Get
        Set(ByVal Value As TimeSpan)
            _toTime = Value
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
Public Class CMS_DoorTimeInfo

#Region "Private Members"
    Private _iD As Integer
    Private _settingDoor_ID As Integer
    Private _fromTime As TimeSpan
    Private _toTime As TimeSpan
    Private _isMorning As Boolean
    Private _sumWelCome As Integer
    Private _sumRegister As Integer
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property SettingDoor_ID() As Integer
        Get
            Return _settingDoor_ID
        End Get
        Set(ByVal Value As Integer)
            _settingDoor_ID = Value
        End Set
    End Property
    Public Property FromTime() As TimeSpan
        Get
            Return _fromTime
        End Get
        Set(ByVal Value As TimeSpan)
            _fromTime = Value
        End Set
    End Property
    Public Property ToTime() As TimeSpan
        Get
            Return _toTime
        End Get
        Set(ByVal Value As TimeSpan)
            _toTime = Value
        End Set
    End Property
    Public Property IsMorning() As Boolean
        Get
            Return _isMorning
        End Get
        Set(ByVal Value As Boolean)
            _isMorning = Value
        End Set
    End Property
    Public Property SumWelCome() As Integer
        Get
            Return _sumWelCome
        End Get
        Set(ByVal Value As Integer)
            _sumWelCome = Value
        End Set
    End Property
    Public Property SumRegister() As Integer
        Get
            Return _sumRegister
        End Get
        Set(ByVal Value As Integer)
            _sumRegister = Value
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
Public Class CMS_DoorInfo

#Region "Private Members"
    Private _doorID As Integer
    Private _doorCode As String = String.Empty
    Private _doorName As String = String.Empty
    Private _portalID As Integer
    Private _satelliteID As String = String.Empty
    Private _flagService As Integer
    Private _tinhTP As Integer
    Private _isOrder As Integer
    Private _isActive As Boolean
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

    Public Property DoorID() As Integer
        Get
            Return _doorID
        End Get
        Set(ByVal Value As Integer)
            _doorID = Value
        End Set
    End Property

    Public Property DoorCode() As String
        Get
            Return _doorCode
        End Get
        Set(ByVal Value As String)
            _doorCode = Value
        End Set
    End Property
    Public Property DoorName() As String
        Get
            Return _doorName
        End Get
        Set(ByVal Value As String)
            _doorName = Value
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
    Public Property SatelliteID() As String
        Get
            Return _satelliteID
        End Get
        Set(ByVal Value As String)
            _satelliteID = Value
        End Set
    End Property
    Public Property FlagService() As Integer
        Get
            Return _flagService
        End Get
        Set(ByVal Value As Integer)
            _flagService = Value
        End Set
    End Property
    Public Property TinhTP() As Integer
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As Integer)
            _tinhTP = Value
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
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
#End Region

End Class
Public Class EXE_FileAttchInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _idKey As String = String.Empty
    Private _flags As String = String.Empty
    Private _filePaths As String = String.Empty
    Private _fileName As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
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
    Public Property Flags As String
        Get
            Return _flags
        End Get
        Set(ByVal Value As String)
            _flags = Value
        End Set
    End Property
    Public Property FilePaths As String
        Get
            Return _filePaths
        End Get
        Set(ByVal Value As String)
            _filePaths = Value
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
    Public Property IsOrder As Integer
        Get
            Return _isOrder
        End Get
        Set(ByVal Value As Integer)
            _isOrder = Value
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

Public Class EXE_PhieuHenInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maPhieuHen As String = String.Empty
    Private _iDKey As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _soCMND As String = String.Empty
    Private _qRCode As String = String.Empty
    Private _ngayTraKetQua As DateTime
    Private _ngayTiepNhan As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property MaPhieuHen() As String
        Get
            Return _maPhieuHen
        End Get
        Set(ByVal Value As String)
            _maPhieuHen = Value
        End Set
    End Property
    Public Property IDKey() As String
        Get
            Return _iDKey
        End Get
        Set(ByVal Value As String)
            _iDKey = Value
        End Set
    End Property
    Public Property HoTen() As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property NgaySinh() As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Integer
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Integer)
            _gioiTinh = Value
        End Set
    End Property
    Public Property SoCMND() As String
        Get
            Return _soCMND
        End Get
        Set(ByVal Value As String)
            _soCMND = Value
        End Set
    End Property
    Public Property QRCode() As String
        Get
            Return _qRCode
        End Get
        Set(ByVal Value As String)
            _qRCode = Value
        End Set
    End Property
    Public Property NgayTraKetQua() As DateTime
        Get
            Return _ngayTraKetQua
        End Get
        Set(ByVal Value As DateTime)
            _ngayTraKetQua = Value
        End Set
    End Property
    Public Property NgayTiepNhan() As DateTime
        Get
            Return _ngayTiepNhan
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiepNhan = Value
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
#End Region

End Class






