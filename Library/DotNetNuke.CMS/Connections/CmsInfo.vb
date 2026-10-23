Public Class CMS_AdvertiseInfo

#Region "Private Members"
    Private _advertise_ID As String = String.Empty
    Private _advertise_Name As String = String.Empty
    Private _imgType As Integer
    Private _images As String = String.Empty
    Private _isWith As String = String.Empty
    Private _isHeight As String = String.Empty
    Private _target As String = String.Empty
    Private _isURL As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isLang As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _pageLoca_ID As String = String.Empty
    Private _portalID As Integer
    Private _categoryID As String = String.Empty
    Private _sendView As Boolean
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

    Public Property Advertise_ID() As String
        Get
            Return _advertise_ID
        End Get
        Set(ByVal Value As String)
            _advertise_ID = Value
        End Set
    End Property

    Public Property Advertise_Name() As String
        Get
            Return _advertise_Name
        End Get
        Set(ByVal Value As String)
            _advertise_Name = Value
        End Set
    End Property
    Public Property ImgType() As Integer
        Get
            Return _imgType
        End Get
        Set(ByVal Value As Integer)
            _imgType = Value
        End Set
    End Property
    Public Property Images() As String
        Get
            Return _images
        End Get
        Set(ByVal Value As String)
            _images = Value
        End Set
    End Property
    Public Property IsWith() As String
        Get
            Return _isWith
        End Get
        Set(ByVal Value As String)
            _isWith = Value
        End Set
    End Property
    Public Property IsHeight() As String
        Get
            Return _isHeight
        End Get
        Set(ByVal Value As String)
            _isHeight = Value
        End Set
    End Property
    Public Property Target() As String
        Get
            Return _target
        End Get
        Set(ByVal Value As String)
            _target = Value
        End Set
    End Property
    Public Property IsURL() As String
        Get
            Return _isURL
        End Get
        Set(ByVal Value As String)
            _isURL = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property IsLang() As String
        Get
            Return _isLang
        End Get
        Set(ByVal Value As String)
            _isLang = Value
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
    Public Property UserName() As String
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
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
    Public Property PageLoca_ID() As String
        Get
            Return _pageLoca_ID
        End Get
        Set(ByVal Value As String)
            _pageLoca_ID = Value
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
    Public Property CategoryID() As String
        Get
            Return _categoryID
        End Get
        Set(ByVal Value As String)
            _categoryID = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_AuthorsInfo

#Region "Private Members"
    Private _authors_ID As String = String.Empty
    Private _penName As String = String.Empty
    Private _fullName As String = String.Empty
    Private _indentify As String = String.Empty
    Private _birthDay As DateTime
    Private _address As String = String.Empty
    Private _email As String = String.Empty
    Private _phone As String = String.Empty
    Private _regions As Integer
    Private _portalID As Integer
    Private _registerUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _tenTK As String = String.Empty
    Private _soTK As String = String.Empty
    Private _diaChiCN As String = String.Empty
    Private _nganHang As String = String.Empty
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

    Public Property Authors_ID() As String
        Get
            Return _authors_ID
        End Get
        Set(ByVal Value As String)
            _authors_ID = Value
        End Set
    End Property

    Public Property PenName() As String
        Get
            Return _penName
        End Get
        Set(ByVal Value As String)
            _penName = Value
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
    Public Property Indentify() As String
        Get
            Return _indentify
        End Get
        Set(ByVal Value As String)
            _indentify = Value
        End Set
    End Property
    Public Property BirthDay() As DateTime
        Get
            Return _birthDay
        End Get
        Set(ByVal Value As DateTime)
            _birthDay = Value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
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
    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal Value As String)
            _phone = Value
        End Set
    End Property
    Public Property Regions() As Integer
        Get
            Return _regions
        End Get
        Set(ByVal Value As Integer)
            _regions = Value
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
    Public Property RegisterUser() As String
        Get
            Return _registerUser
        End Get
        Set(ByVal Value As String)
            _registerUser = Value
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
    Public Property TenTK() As String
        Get
            Return _tenTK
        End Get
        Set(ByVal Value As String)
            _tenTK = Value
        End Set
    End Property
    Public Property SoTK() As String
        Get
            Return _soTK
        End Get
        Set(ByVal Value As String)
            _soTK = Value
        End Set
    End Property
    Public Property DiaChiCN() As String
        Get
            Return _diaChiCN
        End Get
        Set(ByVal Value As String)
            _diaChiCN = Value
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
#End Region

End Class
Public Class CMS_BlockInfo

#Region "Private Members"
    Private _block_ID As Integer
    Private _block_Key As String = String.Empty
    Private _block_Name As String = String.Empty
    Private _block_Img As String = String.Empty
    Private _block_Flag As Integer
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

    Public Property Block_ID() As Integer
        Get
            Return _block_ID
        End Get
        Set(ByVal Value As Integer)
            _block_ID = Value
        End Set
    End Property

    Public Property Block_Key() As String
        Get
            Return _block_Key
        End Get
        Set(ByVal Value As String)
            _block_Key = Value
        End Set
    End Property
    Public Property Block_Name() As String
        Get
            Return _block_Name
        End Get
        Set(ByVal Value As String)
            _block_Name = Value
        End Set
    End Property
    Public Property Block_Img() As String
        Get
            Return _block_Img
        End Get
        Set(ByVal Value As String)
            _block_Img = Value
        End Set
    End Property
    Public Property Block_Flag() As Integer
        Get
            Return _block_Flag
        End Get
        Set(ByVal Value As Integer)
            _block_Flag = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_CalendarInfo

#Region "Private Members"
    Private _calendar_ID As String = String.Empty
    Private _calendarName As String = String.Empty
    Private _morning As String = String.Empty
    Private _night As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _isLang As String = String.Empty
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

    Public Property Calendar_ID() As String
        Get
            Return _calendar_ID
        End Get
        Set(ByVal Value As String)
            _calendar_ID = Value
        End Set
    End Property

    Public Property CalendarName() As String
        Get
            Return _calendarName
        End Get
        Set(ByVal Value As String)
            _calendarName = Value
        End Set
    End Property
    Public Property Morning() As String
        Get
            Return _morning
        End Get
        Set(ByVal Value As String)
            _morning = Value
        End Set
    End Property
    Public Property Night() As String
        Get
            Return _night
        End Get
        Set(ByVal Value As String)
            _night = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property CreatedBy() As DateTime
        Get
            Return _createdBy
        End Get
        Set(ByVal Value As DateTime)
            _createdBy = Value
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
    Public Property IsLang() As String
        Get
            Return _isLang
        End Get
        Set(ByVal Value As String)
            _isLang = Value
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
Public Class CMS_ChucVuInfo

#Region "Private Members"
    Private _id As Integer
    Private _chucVu As String = String.Empty
    Private _moTa As String = String.Empty
    Private _nguoiTao As Integer
    Private _ngayTao As DateTime
    Private _isActive As Boolean
    Private _orderNumber As Integer
    Private _portalId As Integer
    Private _moduleId As Integer
    Private _languageId As String = String.Empty
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

    Public Property ChucVu() As String
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As String)
            _chucVu = Value
        End Set
    End Property
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property NguoiTao() As Integer
        Get
            Return _nguoiTao
        End Get
        Set(ByVal Value As Integer)
            _nguoiTao = Value
        End Set
    End Property
    Public Property NgayTao() As DateTime
        Get
            Return _ngayTao
        End Get
        Set(ByVal Value As DateTime)
            _ngayTao = Value
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
    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal Value As Integer)
            _orderNumber = Value
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
    Public Property ModuleId() As Integer
        Get
            Return _moduleId
        End Get
        Set(ByVal Value As Integer)
            _moduleId = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ConfigSystemInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _isCMS As Boolean
    Private _isLive As Boolean
    Private _liveTitle As String = String.Empty
    Private _liveUrl As String = String.Empty
    Private _liveDes As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _siteMap As String = String.Empty
    Private _ipPublic As String = String.Empty
    Private _analytics As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
    Private _sendView As Boolean
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

    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property IsCMS() As Boolean
        Get
            Return _isCMS
        End Get
        Set(ByVal Value As Boolean)
            _isCMS = Value
        End Set
    End Property
    Public Property IsLive() As Boolean
        Get
            Return _isLive
        End Get
        Set(ByVal Value As Boolean)
            _isLive = Value
        End Set
    End Property
    Public Property LiveTitle() As String
        Get
            Return _liveTitle
        End Get
        Set(ByVal Value As String)
            _liveTitle = Value
        End Set
    End Property
    Public Property LiveUrl() As String
        Get
            Return _liveUrl
        End Get
        Set(ByVal Value As String)
            _liveUrl = Value
        End Set
    End Property
    Public Property LiveDes() As String
        Get
            Return _liveDes
        End Get
        Set(ByVal Value As String)
            _liveDes = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property SiteMap() As String
        Get
            Return _siteMap
        End Get
        Set(ByVal Value As String)
            _siteMap = Value
        End Set
    End Property
    Public Property IpPublic() As String
        Get
            Return _ipPublic
        End Get
        Set(ByVal Value As String)
            _ipPublic = Value
        End Set
    End Property
    Public Property Analytics() As String
        Get
            Return _analytics
        End Get
        Set(ByVal Value As String)
            _analytics = Value
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
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ContactInfo

#Region "Private Members"
    Private _id As Integer
    Private _fullName As String = String.Empty
    Private _email As String = String.Empty
    Private _tel As String = String.Empty
    Private _address As String = String.Empty
    Private _subject As String = String.Empty
    Private _contents As String = String.Empty
    Private _status As Boolean
    Private _createdDate As DateTime
    Private _portalId As Integer
    Private _languageId As String = String.Empty
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

    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal Value As String)
            _fullName = Value
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
    Public Property Tel() As String
        Get
            Return _tel
        End Get
        Set(ByVal Value As String)
            _tel = Value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
        End Set
    End Property
    Public Property Subject() As String
        Get
            Return _subject
        End Get
        Set(ByVal Value As String)
            _subject = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
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
    Public Property CreatedDate() As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_DepartmentsInfo

#Region "Private Members"
    Private _id As Integer
    Private _tenPhongBan As String = String.Empty
    Private _parentId As Integer
    Private _moTa As String = String.Empty
    Private _nguoiTao As Integer
    Private _ngayTao As DateTime
    Private _isActive As Boolean
    Private _orderNumber As Integer
    Private _portalId As Integer
    Private _moduleId As Integer
    Private _avatar As String = String.Empty
    Private _tenVietTat As String = String.Empty
    Private _languageId As String = String.Empty
    Private _isSub As Boolean
    Private _isGroup As Boolean
    Private _isUrl As String = String.Empty
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

    Public Property TenPhongBan() As String
        Get
            Return _tenPhongBan
        End Get
        Set(ByVal Value As String)
            _tenPhongBan = Value
        End Set
    End Property
    Public Property ParentId() As Integer
        Get
            Return _parentId
        End Get
        Set(ByVal Value As Integer)
            _parentId = Value
        End Set
    End Property
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property NguoiTao() As Integer
        Get
            Return _nguoiTao
        End Get
        Set(ByVal Value As Integer)
            _nguoiTao = Value
        End Set
    End Property
    Public Property NgayTao() As DateTime
        Get
            Return _ngayTao
        End Get
        Set(ByVal Value As DateTime)
            _ngayTao = Value
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
    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal Value As Integer)
            _orderNumber = Value
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
    Public Property ModuleId() As Integer
        Get
            Return _moduleId
        End Get
        Set(ByVal Value As Integer)
            _moduleId = Value
        End Set
    End Property
    Public Property Avatar() As String
        Get
            Return _avatar
        End Get
        Set(ByVal Value As String)
            _avatar = Value
        End Set
    End Property
    Public Property TenVietTat() As String
        Get
            Return _tenVietTat
        End Get
        Set(ByVal Value As String)
            _tenVietTat = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property IsSub() As Boolean
        Get
            Return _isSub
        End Get
        Set(ByVal Value As Boolean)
            _isSub = Value
        End Set
    End Property
    Public Property IsGroup() As Boolean
        Get
            Return _isGroup
        End Get
        Set(ByVal Value As Boolean)
            _isGroup = Value
        End Set
    End Property
    Public Property IsUrl() As String
        Get
            Return _isUrl
        End Get
        Set(ByVal Value As String)
            _isUrl = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_Departments_ChucVuInfo

#Region "Private Members"
    Private _id As Integer
    Private _phongBan As Integer
    Private _chucVu As Integer
    Private _isDefault As Boolean
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

    Public Property PhongBan() As Integer
        Get
            Return _phongBan
        End Get
        Set(ByVal Value As Integer)
            _phongBan = Value
        End Set
    End Property
    Public Property ChucVu() As Integer
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As Integer)
            _chucVu = Value
        End Set
    End Property
    Public Property IsDefault() As Boolean
        Get
            Return _isDefault
        End Get
        Set(ByVal Value As Boolean)
            _isDefault = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_Departments_NguoiDungInfo

#Region "Private Members"
    Private _id As Integer
    Private _phongBan As Integer
    Private _chucVu As Integer
    Private _userId As String = String.Empty
    Private _laNguoiKy As Boolean
    Private _laNguoiNhanVB As Boolean
    Private _laLanhDao As Boolean
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

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property PhongBan() As Integer
        Get
            Return _phongBan
        End Get
        Set(ByVal Value As Integer)
            _phongBan = Value
        End Set
    End Property
    Public Property ChucVu() As Integer
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As Integer)
            _chucVu = Value
        End Set
    End Property
    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal Value As String)
            _userId = Value
        End Set
    End Property
    Public Property LaNguoiKy() As Boolean
        Get
            Return _laNguoiKy
        End Get
        Set(ByVal Value As Boolean)
            _laNguoiKy = Value
        End Set
    End Property
    Public Property LaNguoiNhanVB() As Boolean
        Get
            Return _laNguoiNhanVB
        End Get
        Set(ByVal Value As Boolean)
            _laNguoiNhanVB = Value
        End Set
    End Property
    Public Property LaLanhDao() As Boolean
        Get
            Return _laLanhDao
        End Get
        Set(ByVal Value As Boolean)
            _laLanhDao = Value
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
Public Class CMS_DMNhuanButInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maDM As String = String.Empty
    Private _heSo As Integer
    Private _soLuong As Integer
    Private _donGia As Double
    Private _price As Double
    Private _description As String = String.Empty
    Private _orders As Integer
    Private _type As Integer
    Private _active As Boolean
    Private _month As Integer
    Private _year As Integer
    Private _createUser As String = String.Empty
    Private _createDate As DateTime
    Private _updateUser As String = String.Empty
    Private _updateDate As DateTime
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

    Public Property MaDM() As String
        Get
            Return _maDM
        End Get
        Set(ByVal Value As String)
            _maDM = Value
        End Set
    End Property
    Public Property HeSo() As Integer
        Get
            Return _heSo
        End Get
        Set(ByVal Value As Integer)
            _heSo = Value
        End Set
    End Property
    Public Property SoLuong() As Integer
        Get
            Return _soLuong
        End Get
        Set(ByVal Value As Integer)
            _soLuong = Value
        End Set
    End Property
    Public Property DonGia() As Double
        Get
            Return _donGia
        End Get
        Set(ByVal Value As Double)
            _donGia = Value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal Value As Double)
            _price = Value
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
    Public Property Orders() As Integer
        Get
            Return _orders
        End Get
        Set(ByVal Value As Integer)
            _orders = Value
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return _type
        End Get
        Set(ByVal Value As Integer)
            _type = Value
        End Set
    End Property
    Public Property Active() As Boolean
        Get
            Return _active
        End Get
        Set(ByVal Value As Boolean)
            _active = Value
        End Set
    End Property
    Public Property Month() As Integer
        Get
            Return _month
        End Get
        Set(ByVal Value As Integer)
            _month = Value
        End Set
    End Property
    Public Property Year() As Integer
        Get
            Return _year
        End Get
        Set(ByVal Value As Integer)
            _year = Value
        End Set
    End Property
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_DocFieldInfo

#Region "Private Members"
    Private _docField_ID As String = String.Empty
    Private _docField_Name As String = String.Empty
    Private _docField_Des As String = String.Empty
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
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

    Public Property DocField_ID() As String
        Get
            Return _docField_ID
        End Get
        Set(ByVal Value As String)
            _docField_ID = Value
        End Set
    End Property

    Public Property DocField_Name() As String
        Get
            Return _docField_Name
        End Get
        Set(ByVal Value As String)
            _docField_Name = Value
        End Set
    End Property
    Public Property DocField_Des() As String
        Get
            Return _docField_Des
        End Get
        Set(ByVal Value As String)
            _docField_Des = Value
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
    Public Property UserName() As String
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
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
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
Public Class CMS_DocTypeInfo

#Region "Private Members"
    Private _docType_ID As String = String.Empty
    Private _docType_Name As String = String.Empty
    Private _docType_Des As String = String.Empty
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
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

    Public Property DocType_ID() As String
        Get
            Return _docType_ID
        End Get
        Set(ByVal Value As String)
            _docType_ID = Value
        End Set
    End Property

    Public Property DocType_Name() As String
        Get
            Return _docType_Name
        End Get
        Set(ByVal Value As String)
            _docType_Name = Value
        End Set
    End Property
    Public Property DocType_Des() As String
        Get
            Return _docType_Des
        End Get
        Set(ByVal Value As String)
            _docType_Des = Value
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
    Public Property UserName() As String
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
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
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
Public Class CMS_DocUnitInfo

#Region "Private Members"
    Private _DocUnit_ID As String = String.Empty
    Private _DocUnit_Name As String = String.Empty
    Private _DocUnit_Des As String = String.Empty
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
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

    Public Property DocUnit_ID() As String
        Get
            Return _DocUnit_ID
        End Get
        Set(ByVal Value As String)
            _DocUnit_ID = Value
        End Set
    End Property

    Public Property DocUnit_Name() As String
        Get
            Return _DocUnit_Name
        End Get
        Set(ByVal Value As String)
            _DocUnit_Name = Value
        End Set
    End Property
    Public Property DocUnit_Des() As String
        Get
            Return _DocUnit_Des
        End Get
        Set(ByVal Value As String)
            _DocUnit_Des = Value
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
    Public Property UserName() As String
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
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
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
Public Class CMS_EventsInfo

#Region "Private Members"
    Private _event_ID As String = String.Empty
    Private _eventName As String = String.Empty
    Private _provinder_ID As String = String.Empty
    Private _bossName As String = String.Empty
    Private _contents As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _address As String = String.Empty
    Private _ownerName As String = String.Empty
    Private _otherUser As String = String.Empty
    Private _important As Boolean
    Private _isSMS As Boolean
    Private _isMail As Boolean
    Private _isMobile As Boolean
    Private _sendTime As Integer
    Private _isRepeat As Boolean
    Private _repeatMonth As Boolean
    Private _repeatDay As Integer
    Private _startRepeat As DateTime
    Private _endRepeat As DateTime
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _isLang As String = String.Empty
    Private _portalID As Integer
    Private _leaderName As String = String.Empty
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

    Public Property Event_ID() As String
        Get
            Return _event_ID
        End Get
        Set(ByVal Value As String)
            _event_ID = Value
        End Set
    End Property

    Public Property EventName() As String
        Get
            Return _eventName
        End Get
        Set(ByVal Value As String)
            _eventName = Value
        End Set
    End Property
    Public Property Provinder_ID() As String
        Get
            Return _provinder_ID
        End Get
        Set(ByVal Value As String)
            _provinder_ID = Value
        End Set
    End Property
    Public Property BossName() As String
        Get
            Return _bossName
        End Get
        Set(ByVal Value As String)
            _bossName = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
        End Set
    End Property
    Public Property OwnerName() As String
        Get
            Return _ownerName
        End Get
        Set(ByVal Value As String)
            _ownerName = Value
        End Set
    End Property
    Public Property OtherUser() As String
        Get
            Return _otherUser
        End Get
        Set(ByVal Value As String)
            _otherUser = Value
        End Set
    End Property
    Public Property Important() As Boolean
        Get
            Return _important
        End Get
        Set(ByVal Value As Boolean)
            _important = Value
        End Set
    End Property
    Public Property IsSMS() As Boolean
        Get
            Return _isSMS
        End Get
        Set(ByVal Value As Boolean)
            _isSMS = Value
        End Set
    End Property
    Public Property IsMail() As Boolean
        Get
            Return _isMail
        End Get
        Set(ByVal Value As Boolean)
            _isMail = Value
        End Set
    End Property
    Public Property IsMobile() As Boolean
        Get
            Return _isMobile
        End Get
        Set(ByVal Value As Boolean)
            _isMobile = Value
        End Set
    End Property
    Public Property SendTime() As Integer
        Get
            Return _sendTime
        End Get
        Set(ByVal Value As Integer)
            _sendTime = Value
        End Set
    End Property
    Public Property IsRepeat() As Boolean
        Get
            Return _isRepeat
        End Get
        Set(ByVal Value As Boolean)
            _isRepeat = Value
        End Set
    End Property
    Public Property RepeatMonth() As Boolean
        Get
            Return _repeatMonth
        End Get
        Set(ByVal Value As Boolean)
            _repeatMonth = Value
        End Set
    End Property
    Public Property RepeatDay() As Integer
        Get
            Return _repeatDay
        End Get
        Set(ByVal Value As Integer)
            _repeatDay = Value
        End Set
    End Property
    Public Property StartRepeat() As DateTime
        Get
            Return _startRepeat
        End Get
        Set(ByVal Value As DateTime)
            _startRepeat = Value
        End Set
    End Property
    Public Property EndRepeat() As DateTime
        Get
            Return _endRepeat
        End Get
        Set(ByVal Value As DateTime)
            _endRepeat = Value
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
    Public Property UserName() As String
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
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
    Public Property IsLang() As String
        Get
            Return _isLang
        End Get
        Set(ByVal Value As String)
            _isLang = Value
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
    Public Property LeaderName() As String
        Get
            Return _leaderName
        End Get
        Set(ByVal Value As String)
            _leaderName = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FAQInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _name As String = String.Empty
    Private _summary As String = String.Empty
    Private _image As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _answerUserId As String = String.Empty
    Private _answerUserName As String = String.Empty
    Private _isUserDefault As Boolean
    Private _defaultAnswerName As String = String.Empty
    Private _portalId As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _sendView As Boolean
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

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Summary() As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Image() As String
        Get
            Return _image
        End Get
        Set(ByVal Value As String)
            _image = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property AnswerUserId() As String
        Get
            Return _answerUserId
        End Get
        Set(ByVal Value As String)
            _answerUserId = Value
        End Set
    End Property
    Public Property AnswerUserName() As String
        Get
            Return _answerUserName
        End Get
        Set(ByVal Value As String)
            _answerUserName = Value
        End Set
    End Property
    Public Property IsUserDefault() As Boolean
        Get
            Return _isUserDefault
        End Get
        Set(ByVal Value As Boolean)
            _isUserDefault = Value
        End Set
    End Property
    Public Property DefaultAnswerName() As String
        Get
            Return _defaultAnswerName
        End Get
        Set(ByVal Value As String)
            _defaultAnswerName = Value
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
    Public Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FAQAnswersInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _questionID As String = String.Empty
    Private _name As String = String.Empty
    Private _title As String = String.Empty
    Private _contents As String = String.Empty
    Private _fileAttach As String = String.Empty
    Private _sendDate As DateTime
    Private _status As Integer
    Private _isPublic As Boolean
    Private _portalId As Integer
    Private _answerName As String = String.Empty
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _sendView As Boolean
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

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
        End Set
    End Property

    Public Property QuestionID() As String
        Get
            Return _questionID
        End Get
        Set(ByVal Value As String)
            _questionID = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
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
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property FileAttach() As String
        Get
            Return _fileAttach
        End Get
        Set(ByVal Value As String)
            _fileAttach = Value
        End Set
    End Property
    Public Property SendDate() As DateTime
        Get
            Return _sendDate
        End Get
        Set(ByVal Value As DateTime)
            _sendDate = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
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
    Public Property AnswerName() As String
        Get
            Return _answerName
        End Get
        Set(ByVal Value As String)
            _answerName = Value
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
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FAQQuestionsInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _fAQID As String = String.Empty
    Private _name As String = String.Empty
    Private _contents As String = String.Empty
    Private _fileAttach As String = String.Empty
    Private _adress As String = String.Empty
    Private _email As String = String.Empty
    Private _phone As String = String.Empty
    Private _sendDate As DateTime
    Private _status As Integer
    Private _isPublic As Boolean
    Private _portalId As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _sendView As Boolean
    Private _total As Integer

#End Region

#Region "Public Properties"
    Private _ContentAnswer As String
    Public Property ContentAnswer() As String
        Get
            Return _ContentAnswer
        End Get
        Set(ByVal value As String)
            _ContentAnswer = value
        End Set
    End Property
    Private _AnswerName As String
    Public Property AnswerName() As String
        Get
            Return _AnswerName
        End Get
        Set(ByVal value As String)
            _AnswerName = value
        End Set
    End Property
    Private _AnswerUser As String
    Public Property AnswerUser() As String
        Get
            Return _AnswerUser
        End Get
        Set(ByVal value As String)
            _AnswerUser = value
        End Set
    End Property
    Private _AnswerDate As DateTime
    Public Property AnswerDate() As DateTime
        Get
            Return _AnswerDate
        End Get
        Set(ByVal value As DateTime)
            _AnswerDate = value
        End Set
    End Property
    Public Property TrangThai As String
    Public Property AnswerOb As CMS_FAQAnswersInfo
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
        End Set
    End Property

    Public Property FAQID() As String
        Get
            Return _fAQID
        End Get
        Set(ByVal Value As String)
            _fAQID = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property FileAttach() As String
        Get
            Return _fileAttach
        End Get
        Set(ByVal Value As String)
            _fileAttach = Value
        End Set
    End Property
    Public Property Adress() As String
        Get
            Return _adress
        End Get
        Set(ByVal Value As String)
            _adress = Value
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
    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal Value As String)
            _phone = Value
        End Set
    End Property
    Public Property SendDate() As DateTime
        Get
            Return _sendDate
        End Get
        Set(ByVal Value As DateTime)
            _sendDate = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
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
    Public Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FieldInfo

#Region "Private Members"
    Private _field_ID As String = String.Empty
    Private _fieldName As String = String.Empty
    Private _fieldDes As String = String.Empty
    Private _isOrder As Integer
    Private _isActive As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
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

    Public Property Field_ID() As String
        Get
            Return _field_ID
        End Get
        Set(ByVal Value As String)
            _field_ID = Value
        End Set
    End Property

    Public Property FieldName() As String
        Get
            Return _fieldName
        End Get
        Set(ByVal Value As String)
            _fieldName = Value
        End Set
    End Property
    Public Property FieldDes() As String
        Get
            Return _fieldDes
        End Get
        Set(ByVal Value As String)
            _fieldDes = Value
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
Public Class CMS_InfomationInfo

#Region "Private Members"
    Private _id As Integer
    Private _nameH1 As String = String.Empty
    Private _nameH2 As String = String.Empty
    Private _nameH3 As String = String.Empty
    Private _imagePath As String = String.Empty
    Private _imageRight As String = String.Empty
    Private _footer As String = String.Empty
    Private _infomation As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _portalId As Integer
    Private _languageId As String = String.Empty
    Private _sendView As Boolean
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

    Public Property NameH1() As String
        Get
            Return _nameH1
        End Get
        Set(ByVal Value As String)
            _nameH1 = Value
        End Set
    End Property
    Public Property NameH2() As String
        Get
            Return _nameH2
        End Get
        Set(ByVal Value As String)
            _nameH2 = Value
        End Set
    End Property
    Public Property NameH3() As String
        Get
            Return _nameH3
        End Get
        Set(ByVal Value As String)
            _nameH3 = Value
        End Set
    End Property
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property ImageRight() As String
        Get
            Return _imageRight
        End Get
        Set(ByVal Value As String)
            _imageRight = Value
        End Set
    End Property
    Public Property Footer() As String
        Get
            Return _footer
        End Get
        Set(ByVal Value As String)
            _footer = Value
        End Set
    End Property
    Public Property Infomation() As String
        Get
            Return _infomation
        End Get
        Set(ByVal Value As String)
            _infomation = Value
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
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_MediaInfo

#Region "Private Members"
    Private _id As Integer
    Private _categoryId As Integer
    Private _name As String = String.Empty
    Private _summary As String = String.Empty
    Private _avatar As String = String.Empty
    Private _mediaUrl As String = String.Empty
    Private _folders As String = String.Empty
    Private _contents As String = String.Empty
    Private _viewCount As Integer
    Private _status As Integer
    Private _type As Short
    Private _isYoutube As Boolean
    Private _isHot As Boolean
    Private _isFTP As Boolean
    Private _tags As String = String.Empty
    Private _note As String = String.Empty
    Private _createdDate As DateTime
    Private _publishedDate As DateTime
    Private _approvalDate As DateTime
    Private _createdUser As String = String.Empty
    Private _approvalUser As String = String.Empty
    Private _publishedUser As String = String.Empty
    Private _portalId As Integer
    Private _languageId As String = String.Empty
    Private _sTT As Integer
    Private _isHome As Boolean
    Private _isPage As Boolean
    Private _toUrl As String = String.Empty
    Private _sendView As Boolean
    Private _isDelete As Boolean
    Private _deleteDate As DateTime
    Private _deleteUser As String = String.Empty
    Private _writerName As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property CategoryName As String
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

    Public Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal Value As Integer)
            _categoryId = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Summary() As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Avatar() As String
        Get
            Return _avatar
        End Get
        Set(ByVal Value As String)
            _avatar = Value
        End Set
    End Property
    Public Property MediaUrl() As String
        Get
            Return _mediaUrl
        End Get
        Set(ByVal Value As String)
            _mediaUrl = Value
        End Set
    End Property
    Public Property Folders() As String
        Get
            Return _folders
        End Get
        Set(ByVal Value As String)
            _folders = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property ViewCount() As Integer
        Get
            Return _viewCount
        End Get
        Set(ByVal Value As Integer)
            _viewCount = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property Type() As Short
        Get
            Return _type
        End Get
        Set(ByVal Value As Short)
            _type = Value
        End Set
    End Property
    Public Property IsYoutube() As Boolean
        Get
            Return _isYoutube
        End Get
        Set(ByVal Value As Boolean)
            _isYoutube = Value
        End Set
    End Property
    Public Property IsHot() As Boolean
        Get
            Return _isHot
        End Get
        Set(ByVal Value As Boolean)
            _isHot = Value
        End Set
    End Property
    Public Property IsFTP() As Boolean
        Get
            Return _isFTP
        End Get
        Set(ByVal Value As Boolean)
            _isFTP = Value
        End Set
    End Property
    Public Property Tags() As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return _note
        End Get
        Set(ByVal Value As String)
            _note = Value
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
    Public Property PublishedDate() As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property ApprovalUser() As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property PublishedUser() As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property STT() As Integer
        Get
            Return _sTT
        End Get
        Set(ByVal Value As Integer)
            _sTT = Value
        End Set
    End Property
    Public Property IsHome() As Boolean
        Get
            Return _isHome
        End Get
        Set(ByVal Value As Boolean)
            _isHome = Value
        End Set
    End Property
    Public Property IsPage() As Boolean
        Get
            Return _isPage
        End Get
        Set(ByVal Value As Boolean)
            _isPage = Value
        End Set
    End Property
    Public Property ToUrl() As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
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
    Public Property DeleteDate() As DateTime
        Get
            Return _deleteDate
        End Get
        Set(ByVal Value As DateTime)
            _deleteDate = Value
        End Set
    End Property
    Public Property DeleteUser() As String
        Get
            Return _deleteUser
        End Get
        Set(ByVal Value As String)
            _deleteUser = Value
        End Set
    End Property
    Public Property WriterName() As String
        Get
            Return _writerName
        End Get
        Set(ByVal Value As String)
            _writerName = Value
        End Set
    End Property
#End Region

End Class
Partial Public Class CMS_MenuInfo

#Region "Private Members"
    Private _id As Integer
    Private _parentId As Integer
    Private _name As String = String.Empty
    Private _isUsed As Integer
    Private _iconUrl As String = String.Empty
    Private _title As String = String.Empty
    Private _contents As String = String.Empty
    Private _tabId As Integer
    Private _url As String = String.Empty
    Private _levelNo As Integer
    Private _orderNo As Integer
    Private _portalId As Integer
    Private _languageId As String = String.Empty
    Private _params As String = String.Empty
    Private _sortColumn As String = String.Empty
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal id As Integer, ByVal parentId As Integer, ByVal name As String, ByVal isUsed As Integer, ByVal iconUrl As String, ByVal title As String, ByVal contents As String, ByVal tabId As Integer, ByVal url As String, ByVal levelNo As Integer, ByVal orderNo As Integer, ByVal portalId As Integer, ByVal languageId As String, ByVal params As String)
        Me.Id = id
        Me.ParentId = parentId
        Me.Name = name
        Me.IsUsed = isUsed
        Me.IconUrl = iconUrl
        Me.Title = title
        Me.Contents = contents
        Me.TabId = tabId
        Me.Url = url
        Me.LevelNo = levelNo
        Me.OrderNo = orderNo
        Me.PortalId = portalId
        Me.LanguageId = languageId
        Me.Params = params
    End Sub
#End Region

#Region "Public Properties"
    Public Property MenuName As String
    Public Property IsOrder As String
    Public Property MenuID As String
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    Public Property ParentId() As Integer
        Get
            Return _parentId
        End Get
        Set(ByVal Value As Integer)
            _parentId = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property IsUsed() As Integer
        Get
            Return _isUsed
        End Get
        Set(ByVal Value As Integer)
            _isUsed = Value
        End Set
    End Property
    Public Property IconUrl() As String
        Get
            Return _iconUrl
        End Get
        Set(ByVal Value As String)
            _iconUrl = Value
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
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property TabId() As Integer
        Get
            Return _tabId
        End Get
        Set(ByVal Value As Integer)
            _tabId = Value
        End Set
    End Property
    Public Property Url() As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property
    Public Property LevelNo() As Integer
        Get
            Return _levelNo
        End Get
        Set(ByVal Value As Integer)
            _levelNo = Value
        End Set
    End Property
    Public Property OrderNo() As Integer
        Get
            Return _orderNo
        End Get
        Set(ByVal Value As Integer)
            _orderNo = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property Params() As String
        Get
            Return _params
        End Get
        Set(ByVal Value As String)
            _params = Value
        End Set
    End Property
    Public Property SortColumn() As String
        Get
            Return _sortColumn
        End Get
        Set(ByVal Value As String)
            _sortColumn = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_MenuDInfo

#Region "Private Members"
    Private _menuD_ID As String = String.Empty
    Private _menuD_Name As String = String.Empty
    Private _menu_ID As String = String.Empty
    Private _parent_ID As String = String.Empty
    Private _url As String = String.Empty
    Private _backColor As String = String.Empty
    Private _isOrder As Integer
    Private _portalId As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _sendView As Boolean
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

    Public Property MenuD_ID() As String
        Get
            Return _menuD_ID
        End Get
        Set(ByVal Value As String)
            _menuD_ID = Value
        End Set
    End Property

    Public Property MenuD_Name() As String
        Get
            Return _menuD_Name
        End Get
        Set(ByVal Value As String)
            _menuD_Name = Value
        End Set
    End Property
    Public Property Menu_ID() As String
        Get
            Return _menu_ID
        End Get
        Set(ByVal Value As String)
            _menu_ID = Value
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
    Public Property Url() As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property
    Public Property BackColor() As String
        Get
            Return _backColor
        End Get
        Set(ByVal Value As String)
            _backColor = Value
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
    Public Property PortalId() As Integer
        Get
            Return _portalId
        End Get
        Set(ByVal Value As Integer)
            _portalId = Value
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
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsInfo

#Region "Private Members"
    Private _newId As Integer
    Private _categoryId As Integer
    Private _introduction As String = String.Empty
    Private _title As String = String.Empty
    Private _imagePath As String = String.Empty
    Private _summary As String = String.Empty
    Private _content As String = String.Empty
    Private _isActive As Boolean
    Private _hotcat As Boolean
    Private _isCare As Boolean
    Private _isRead As Integer
    Private _status As Short
    Private _unit As Short
    Private _newsKind As Short
    Private _type As Short
    Private _typeUrl As String = String.Empty
    Private _links As String = String.Empty
    Private _tags As String = String.Empty
    Private _isImage As Boolean
    Private _note As String = String.Empty
    Private _sourceInfo As Short
    Private _isEdited As Boolean
    Private _editedUser As String = String.Empty
    Private _editedTime As DateTime
    Private _voteCount As Integer
    Private _viewCount As Integer
    Private _isArchived As Boolean
    Private _archivedDate As DateTime
    Private _credit As Integer
    Private _createdate As DateTime
    Private _approvalRequestDate As DateTime
    Private _approvalDate As DateTime
    Private _approvalUser As String = String.Empty
    Private _returnedDate As DateTime
    Private _returnedUser As String = String.Empty
    Private _cancelPublishDate As DateTime
    Private _cancelPublishUser As String = String.Empty
    Private _publishedDate As DateTime
    Private _publishedUser As String = String.Empty
    Private _userId As String = String.Empty
    Private _writerName As String = String.Empty
    Private _writerFullName As String = String.Empty
    Private _numberNews As String = String.Empty
    Private _notePrices As String = String.Empty
    Private _languageId As String = String.Empty
    Private _portalId As Integer
    Private _toUrl As String = String.Empty
    Private _getFromPortal As Integer
    Private _getFromNewId As Integer
    Private _sendName As String = String.Empty
    Private _sendView As Boolean
    Private _total As Integer
    Private _NewDay As Integer
    Private _IsMobile As Boolean
#End Region

#Region "Public Properties"
    Public Property CategoryParentName As String
    Public Property CategoryName As String
    Public Property IsMobile As Boolean
        Get
            Return _IsMobile
        End Get
        Set(ByVal Value As Boolean)
            _IsMobile = Value
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
    Public Property NewDay() As Integer
        Get
            Return _NewDay
        End Get
        Set(ByVal Value As Integer)
            _NewDay = Value
        End Set
    End Property
    Public Property NewId() As Integer
        Get
            Return _newId
        End Get
        Set(ByVal Value As Integer)
            _newId = Value
        End Set
    End Property
    Public Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal Value As Integer)
            _categoryId = Value
        End Set
    End Property
    Public Property Introduction() As String
        Get
            Return _introduction
        End Get
        Set(ByVal Value As String)
            _introduction = Value
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
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property Summary() As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Content() As String
        Get
            Return _content
        End Get
        Set(ByVal Value As String)
            _content = Value
        End Set
    End Property
    Public Property isActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property Hotcat() As Boolean
        Get
            Return _hotcat
        End Get
        Set(ByVal Value As Boolean)
            _hotcat = Value
        End Set
    End Property
    Public Property IsCare() As Boolean
        Get
            Return _isCare
        End Get
        Set(ByVal Value As Boolean)
            _isCare = Value
        End Set
    End Property
    Public Property isRead() As Integer
        Get
            Return _isRead
        End Get
        Set(ByVal Value As Integer)
            _isRead = Value
        End Set
    End Property
    Public Property Status() As Short
        Get
            Return _status
        End Get
        Set(ByVal Value As Short)
            _status = Value
        End Set
    End Property
    Public Property Unit() As Short
        Get
            Return _unit
        End Get
        Set(ByVal Value As Short)
            _unit = Value
        End Set
    End Property
    Public Property NewsKind() As Short
        Get
            Return _newsKind
        End Get
        Set(ByVal Value As Short)
            _newsKind = Value
        End Set
    End Property
    Public Property Type() As Short
        Get
            Return _type
        End Get
        Set(ByVal Value As Short)
            _type = Value
        End Set
    End Property
    Public Property TypeUrl() As String
        Get
            Return _typeUrl
        End Get
        Set(ByVal Value As String)
            _typeUrl = Value
        End Set
    End Property
    Public Property Links() As String
        Get
            Return _links
        End Get
        Set(ByVal Value As String)
            _links = Value
        End Set
    End Property
    Public Property Tags() As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property IsImage() As Boolean
        Get
            Return _isImage
        End Get
        Set(ByVal Value As Boolean)
            _isImage = Value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return _note
        End Get
        Set(ByVal Value As String)
            _note = Value
        End Set
    End Property
    Public Property SourceInfo() As Short
        Get
            Return _sourceInfo
        End Get
        Set(ByVal Value As Short)
            _sourceInfo = Value
        End Set
    End Property
    Public Property IsEdited() As Boolean
        Get
            Return _isEdited
        End Get
        Set(ByVal Value As Boolean)
            _isEdited = Value
        End Set
    End Property
    Public Property EditedUser() As String
        Get
            Return _editedUser
        End Get
        Set(ByVal Value As String)
            _editedUser = Value
        End Set
    End Property
    Public Property EditedTime() As DateTime
        Get
            Return _editedTime
        End Get
        Set(ByVal Value As DateTime)
            _editedTime = Value
        End Set
    End Property
    Public Property VoteCount() As Integer
        Get
            Return _voteCount
        End Get
        Set(ByVal Value As Integer)
            _voteCount = Value
        End Set
    End Property
    Public Property ViewCount() As Integer
        Get
            Return _viewCount
        End Get
        Set(ByVal Value As Integer)
            _viewCount = Value
        End Set
    End Property
    Public Property IsArchived() As Boolean
        Get
            Return _isArchived
        End Get
        Set(ByVal Value As Boolean)
            _isArchived = Value
        End Set
    End Property
    Public Property ArchivedDate() As DateTime
        Get
            Return _archivedDate
        End Get
        Set(ByVal Value As DateTime)
            _archivedDate = Value
        End Set
    End Property
    Public Property Credit() As Integer
        Get
            Return _credit
        End Get
        Set(ByVal Value As Integer)
            _credit = Value
        End Set
    End Property
    Public Property Createdate() As DateTime
        Get
            Return _createdate
        End Get
        Set(ByVal Value As DateTime)
            _createdate = Value
        End Set
    End Property
    Public Property ApprovalRequestDate() As DateTime
        Get
            Return _approvalRequestDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalRequestDate = Value
        End Set
    End Property
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
        End Set
    End Property
    Public Property ApprovalUser() As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property ReturnedDate() As DateTime
        Get
            Return _returnedDate
        End Get
        Set(ByVal Value As DateTime)
            _returnedDate = Value
        End Set
    End Property
    Public Property ReturnedUser() As String
        Get
            Return _returnedUser
        End Get
        Set(ByVal Value As String)
            _returnedUser = Value
        End Set
    End Property
    Public Property CancelPublishDate() As DateTime
        Get
            Return _cancelPublishDate
        End Get
        Set(ByVal Value As DateTime)
            _cancelPublishDate = Value
        End Set
    End Property
    Public Property CancelPublishUser() As String
        Get
            Return _cancelPublishUser
        End Get
        Set(ByVal Value As String)
            _cancelPublishUser = Value
        End Set
    End Property
    Public Property PublishedDate() As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property PublishedUser() As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
        End Set
    End Property
    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal Value As String)
            _userId = Value
        End Set
    End Property
    Public Property WriterName() As String
        Get
            Return _writerName
        End Get
        Set(ByVal Value As String)
            _writerName = Value
        End Set
    End Property
    Public Property WriterFullName() As String
        Get
            Return _writerFullName
        End Get
        Set(ByVal Value As String)
            _writerFullName = Value
        End Set
    End Property
    Public Property NumberNews() As String
        Get
            Return _numberNews
        End Get
        Set(ByVal Value As String)
            _numberNews = Value
        End Set
    End Property
    Public Property NotePrices() As String
        Get
            Return _notePrices
        End Get
        Set(ByVal Value As String)
            _notePrices = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
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
    Public Property ToUrl() As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property GetFromPortal() As Integer
        Get
            Return _getFromPortal
        End Get
        Set(ByVal Value As Integer)
            _getFromPortal = Value
        End Set
    End Property
    Public Property GetFromNewId() As Integer
        Get
            Return _getFromNewId
        End Get
        Set(ByVal Value As Integer)
            _getFromNewId = Value
        End Set
    End Property
    Public Property SendName() As String
        Get
            Return _sendName
        End Get
        Set(ByVal Value As String)
            _sendName = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_NBInfo

#Region "Private Members"
    Private _iD As Integer
    Private _newsID As Integer
    Private _dM_ID As Integer
    Private _price As Double
    Private _createUser As String = String.Empty
    Private _createDate As DateTime
    Private _updateUser As String = String.Empty
    Private _updateDate As DateTime
    Private _type As Integer
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

    Public Property NewsID() As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
        End Set
    End Property
    Public Property DM_ID() As Integer
        Get
            Return _dM_ID
        End Get
        Set(ByVal Value As Integer)
            _dM_ID = Value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal Value As Double)
            _price = Value
        End Set
    End Property
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return _type
        End Get
        Set(ByVal Value As Integer)
            _type = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_NBDetailInfo

#Region "Private Members"
    Private _detail_ID As Integer
    Private _newsNB_ID As Integer
    Private _iD As Integer
    Private _maDM As String = String.Empty
    Private _heSo As Integer
    Private _soLuong As Integer
    Private _donGia As Double
    Private _price As Double
    Private _createUser As String = String.Empty
    Private _createDate As DateTime
    Private _updateUser As String = String.Empty
    Private _updateDate As DateTime
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

    Public Property Detail_ID() As Integer
        Get
            Return _detail_ID
        End Get
        Set(ByVal Value As Integer)
            _detail_ID = Value
        End Set
    End Property

    Public Property NewsNB_ID() As Integer
        Get
            Return _newsNB_ID
        End Get
        Set(ByVal Value As Integer)
            _newsNB_ID = Value
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
    Public Property MaDM() As String
        Get
            Return _maDM
        End Get
        Set(ByVal Value As String)
            _maDM = Value
        End Set
    End Property
    Public Property HeSo() As Integer
        Get
            Return _heSo
        End Get
        Set(ByVal Value As Integer)
            _heSo = Value
        End Set
    End Property
    Public Property SoLuong() As Integer
        Get
            Return _soLuong
        End Get
        Set(ByVal Value As Integer)
            _soLuong = Value
        End Set
    End Property
    Public Property DonGia() As Double
        Get
            Return _donGia
        End Get
        Set(ByVal Value As Double)
            _donGia = Value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal Value As Double)
            _price = Value
        End Set
    End Property
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_ProcessInfo

#Region "Private Members"
    Private _iD As Integer
    Private _itemID As Integer
    Private _statusID As Integer
    Private _processName As String = String.Empty
    Private _comment As String = String.Empty
    Private _byUser As String = String.Empty
    Private _toUser As String = String.Empty
    Private _createDate As DateTime
    Private _versionId As Integer
    Private _iPTrack As String = String.Empty
    Private _type As Byte
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

    Public Property ItemID() As Integer
        Get
            Return _itemID
        End Get
        Set(ByVal Value As Integer)
            _itemID = Value
        End Set
    End Property
    Public Property StatusID() As Integer
        Get
            Return _statusID
        End Get
        Set(ByVal Value As Integer)
            _statusID = Value
        End Set
    End Property
    Public Property ProcessName() As String
        Get
            Return _processName
        End Get
        Set(ByVal Value As String)
            _processName = Value
        End Set
    End Property
    Public Property Comment() As String
        Get
            Return _comment
        End Get
        Set(ByVal Value As String)
            _comment = Value
        End Set
    End Property
    Public Property ByUser() As String
        Get
            Return _byUser
        End Get
        Set(ByVal Value As String)
            _byUser = Value
        End Set
    End Property
    Public Property ToUser() As String
        Get
            Return _toUser
        End Get
        Set(ByVal Value As String)
            _toUser = Value
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
    Public Property VersionId() As Integer
        Get
            Return _versionId
        End Get
        Set(ByVal Value As Integer)
            _versionId = Value
        End Set
    End Property
    Public Property IPTrack() As String
        Get
            Return _iPTrack
        End Get
        Set(ByVal Value As String)
            _iPTrack = Value
        End Set
    End Property
    Public Property Type() As Byte
        Get
            Return _type
        End Get
        Set(ByVal Value As Byte)
            _type = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_UserProcessInfo

#Region "Private Members"
    Private _iD As Integer
    Private _userID As String = String.Empty
    Private _newsID As Integer
    Private _status As Short
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _isActive As Byte
    Private _type As Integer
    Private _positionID As Integer
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

    Public Property UserID() As String
        Get
            Return _userID
        End Get
        Set(ByVal Value As String)
            _userID = Value
        End Set
    End Property
    Public Property NewsID() As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
        End Set
    End Property
    Public Property Status() As Short
        Get
            Return _status
        End Get
        Set(ByVal Value As Short)
            _status = Value
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
    Public Property isActive() As Byte
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Byte)
            _isActive = Value
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return _type
        End Get
        Set(ByVal Value As Integer)
            _type = Value
        End Set
    End Property
    Public Property PositionID() As Integer
        Get
            Return _positionID
        End Get
        Set(ByVal Value As Integer)
            _positionID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_UserWFInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenLuong As String = String.Empty
    Private _phongBan As Integer
    Private _nguoiGui As String = String.Empty
    Private _nguoiNhan As String = String.Empty
    Private _trangThaiDich As Short
    Private _loaiWF As Short
    Private _isDefault As Boolean
    Private _moTa As String = String.Empty
    Private _nguoiTao As String = String.Empty
    Private _ngayTao As DateTime
    Private _isActive As Boolean
    Private _orderNumber As Integer
    Private _portalId As Integer
    Private _moduleId As Integer
    Private _languageId As String = String.Empty
    Private _iconSmall As String = String.Empty
    Private _iconLarge As String = String.Empty
    Private _positionID As Integer
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

    Public Property TenLuong() As String
        Get
            Return _tenLuong
        End Get
        Set(ByVal Value As String)
            _tenLuong = Value
        End Set
    End Property
    Public Property PhongBan() As Integer
        Get
            Return _phongBan
        End Get
        Set(ByVal Value As Integer)
            _phongBan = Value
        End Set
    End Property
    Public Property NguoiGui() As String
        Get
            Return _nguoiGui
        End Get
        Set(ByVal Value As String)
            _nguoiGui = Value
        End Set
    End Property
    Public Property NguoiNhan() As String
        Get
            Return _nguoiNhan
        End Get
        Set(ByVal Value As String)
            _nguoiNhan = Value
        End Set
    End Property
    Public Property TrangThaiDich() As Short
        Get
            Return _trangThaiDich
        End Get
        Set(ByVal Value As Short)
            _trangThaiDich = Value
        End Set
    End Property
    Public Property LoaiWF() As Short
        Get
            Return _loaiWF
        End Get
        Set(ByVal Value As Short)
            _loaiWF = Value
        End Set
    End Property
    Public Property IsDefault() As Boolean
        Get
            Return _isDefault
        End Get
        Set(ByVal Value As Boolean)
            _isDefault = Value
        End Set
    End Property
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property NguoiTao() As String
        Get
            Return _nguoiTao
        End Get
        Set(ByVal Value As String)
            _nguoiTao = Value
        End Set
    End Property
    Public Property NgayTao() As DateTime
        Get
            Return _ngayTao
        End Get
        Set(ByVal Value As DateTime)
            _ngayTao = Value
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
    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal Value As Integer)
            _orderNumber = Value
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
    Public Property ModuleId() As Integer
        Get
            Return _moduleId
        End Get
        Set(ByVal Value As Integer)
            _moduleId = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property IconSmall() As String
        Get
            Return _iconSmall
        End Get
        Set(ByVal Value As String)
            _iconSmall = Value
        End Set
    End Property
    Public Property IconLarge() As String
        Get
            Return _iconLarge
        End Get
        Set(ByVal Value As String)
            _iconLarge = Value
        End Set
    End Property
    Public Property PositionID() As Integer
        Get
            Return _positionID
        End Get
        Set(ByVal Value As Integer)
            _positionID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_News_VersionInfo

#Region "Private Members"
    Private _iD As Integer
    Private _createdUser As String = String.Empty
    Private _newId As Integer
    Private _categoryId As Integer
    Private _introduction As String = String.Empty
    Private _title As String = String.Empty
    Private _imagePath As String = String.Empty
    Private _summary As String = String.Empty
    Private _content As String = String.Empty
    Private _isActive As Boolean
    Private _hotcat As Boolean
    Private _isCare As Boolean
    Private _isRead As Integer
    Private _status As Short
    Private _unit As Short
    Private _newsKind As Short
    Private _type As Short
    Private _typeUrl As String = String.Empty
    Private _links As String = String.Empty
    Private _tags As String = String.Empty
    Private _isImage As Boolean
    Private _note As String = String.Empty
    Private _sourceInfo As Short
    Private _isEdited As Boolean
    Private _editedUser As String = String.Empty
    Private _editedTime As DateTime
    Private _voteCount As Integer
    Private _viewCount As Integer
    Private _isArchived As Boolean
    Private _archivedDate As DateTime
    Private _credit As Integer
    Private _createdate As DateTime
    Private _approvalRequestDate As DateTime
    Private _approvalDate As DateTime
    Private _approvalUser As String = String.Empty
    Private _returnedDate As DateTime
    Private _returnedUser As String = String.Empty
    Private _cancelPublishDate As DateTime
    Private _cancelPublishUser As String = String.Empty
    Private _publishedDate As DateTime
    Private _publishedUser As String = String.Empty
    Private _userId As String = String.Empty
    Private _writerName As String = String.Empty
    Private _writerFullName As String = String.Empty
    Private _numberNews As String = String.Empty
    Private _notePrices As String = String.Empty
    Private _languageId As String = String.Empty
    Private _portalId As Integer
    Private _toUrl As String = String.Empty
    Private _getFromPortal As Integer
    Private _getFromNewId As Integer
    Private _sendName As String = String.Empty
    Private _sendView As Boolean
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property CategoryParentName As String
    Public Property CategoryName As String
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
    Public Property CreatedUser() As String
        Get
            Return _createdUser
        End Get
        Set(ByVal Value As String)
            _createdUser = Value
        End Set
    End Property
    Public Property NewId() As Integer
        Get
            Return _newId
        End Get
        Set(ByVal Value As Integer)
            _newId = Value
        End Set
    End Property
    Public Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal Value As Integer)
            _categoryId = Value
        End Set
    End Property
    Public Property Introduction() As String
        Get
            Return _introduction
        End Get
        Set(ByVal Value As String)
            _introduction = Value
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
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property Summary() As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Content() As String
        Get
            Return _content
        End Get
        Set(ByVal Value As String)
            _content = Value
        End Set
    End Property
    Public Property isActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property Hotcat() As Boolean
        Get
            Return _hotcat
        End Get
        Set(ByVal Value As Boolean)
            _hotcat = Value
        End Set
    End Property
    Public Property IsCare() As Boolean
        Get
            Return _isCare
        End Get
        Set(ByVal Value As Boolean)
            _isCare = Value
        End Set
    End Property
    Public Property isRead() As Integer
        Get
            Return _isRead
        End Get
        Set(ByVal Value As Integer)
            _isRead = Value
        End Set
    End Property
    Public Property Status() As Short
        Get
            Return _status
        End Get
        Set(ByVal Value As Short)
            _status = Value
        End Set
    End Property
    Public Property Unit() As Short
        Get
            Return _unit
        End Get
        Set(ByVal Value As Short)
            _unit = Value
        End Set
    End Property
    Public Property NewsKind() As Short
        Get
            Return _newsKind
        End Get
        Set(ByVal Value As Short)
            _newsKind = Value
        End Set
    End Property
    Public Property Type() As Short
        Get
            Return _type
        End Get
        Set(ByVal Value As Short)
            _type = Value
        End Set
    End Property
    Public Property TypeUrl() As String
        Get
            Return _typeUrl
        End Get
        Set(ByVal Value As String)
            _typeUrl = Value
        End Set
    End Property
    Public Property Links() As String
        Get
            Return _links
        End Get
        Set(ByVal Value As String)
            _links = Value
        End Set
    End Property
    Public Property Tags() As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property IsImage() As Boolean
        Get
            Return _isImage
        End Get
        Set(ByVal Value As Boolean)
            _isImage = Value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return _note
        End Get
        Set(ByVal Value As String)
            _note = Value
        End Set
    End Property
    Public Property SourceInfo() As Short
        Get
            Return _sourceInfo
        End Get
        Set(ByVal Value As Short)
            _sourceInfo = Value
        End Set
    End Property
    Public Property IsEdited() As Boolean
        Get
            Return _isEdited
        End Get
        Set(ByVal Value As Boolean)
            _isEdited = Value
        End Set
    End Property
    Public Property EditedUser() As String
        Get
            Return _editedUser
        End Get
        Set(ByVal Value As String)
            _editedUser = Value
        End Set
    End Property
    Public Property EditedTime() As DateTime
        Get
            Return _editedTime
        End Get
        Set(ByVal Value As DateTime)
            _editedTime = Value
        End Set
    End Property
    Public Property VoteCount() As Integer
        Get
            Return _voteCount
        End Get
        Set(ByVal Value As Integer)
            _voteCount = Value
        End Set
    End Property
    Public Property ViewCount() As Integer
        Get
            Return _viewCount
        End Get
        Set(ByVal Value As Integer)
            _viewCount = Value
        End Set
    End Property
    Public Property IsArchived() As Boolean
        Get
            Return _isArchived
        End Get
        Set(ByVal Value As Boolean)
            _isArchived = Value
        End Set
    End Property
    Public Property ArchivedDate() As DateTime
        Get
            Return _archivedDate
        End Get
        Set(ByVal Value As DateTime)
            _archivedDate = Value
        End Set
    End Property
    Public Property Credit() As Integer
        Get
            Return _credit
        End Get
        Set(ByVal Value As Integer)
            _credit = Value
        End Set
    End Property
    Public Property Createdate() As DateTime
        Get
            Return _createdate
        End Get
        Set(ByVal Value As DateTime)
            _createdate = Value
        End Set
    End Property
    Public Property ApprovalRequestDate() As DateTime
        Get
            Return _approvalRequestDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalRequestDate = Value
        End Set
    End Property
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
        End Set
    End Property
    Public Property ApprovalUser() As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property ReturnedDate() As DateTime
        Get
            Return _returnedDate
        End Get
        Set(ByVal Value As DateTime)
            _returnedDate = Value
        End Set
    End Property
    Public Property ReturnedUser() As String
        Get
            Return _returnedUser
        End Get
        Set(ByVal Value As String)
            _returnedUser = Value
        End Set
    End Property
    Public Property CancelPublishDate() As DateTime
        Get
            Return _cancelPublishDate
        End Get
        Set(ByVal Value As DateTime)
            _cancelPublishDate = Value
        End Set
    End Property
    Public Property CancelPublishUser() As String
        Get
            Return _cancelPublishUser
        End Get
        Set(ByVal Value As String)
            _cancelPublishUser = Value
        End Set
    End Property
    Public Property PublishedDate() As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property PublishedUser() As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
        End Set
    End Property
    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal Value As String)
            _userId = Value
        End Set
    End Property
    Public Property WriterName() As String
        Get
            Return _writerName
        End Get
        Set(ByVal Value As String)
            _writerName = Value
        End Set
    End Property
    Public Property WriterFullName() As String
        Get
            Return _writerFullName
        End Get
        Set(ByVal Value As String)
            _writerFullName = Value
        End Set
    End Property
    Public Property NumberNews() As String
        Get
            Return _numberNews
        End Get
        Set(ByVal Value As String)
            _numberNews = Value
        End Set
    End Property
    Public Property NotePrices() As String
        Get
            Return _notePrices
        End Get
        Set(ByVal Value As String)
            _notePrices = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
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
    Public Property ToUrl() As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property GetFromPortal() As Integer
        Get
            Return _getFromPortal
        End Get
        Set(ByVal Value As Integer)
            _getFromPortal = Value
        End Set
    End Property
    Public Property GetFromNewId() As Integer
        Get
            Return _getFromNewId
        End Get
        Set(ByVal Value As Integer)
            _getFromNewId = Value
        End Set
    End Property
    Public Property SendName() As String
        Get
            Return _sendName
        End Get
        Set(ByVal Value As String)
            _sendName = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsByCategoryInfo

#Region "Private Members"
    Private _id As Long
    Private _newsId As Long
    Private _categoryId As Integer
    Private _isMainCategory As Boolean
    Private _newsStatusId As Integer
    Private _portalID As Integer
    Private _languageId As String = String.Empty
    Private _sendView As Boolean
    Private _isHotCate As Boolean
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

    Public Property Id() As Long
        Get
            Return _id
        End Get
        Set(ByVal Value As Long)
            _id = Value
        End Set
    End Property

    Public Property NewsId() As Long
        Get
            Return _newsId
        End Get
        Set(ByVal Value As Long)
            _newsId = Value
        End Set
    End Property
    Public Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal Value As Integer)
            _categoryId = Value
        End Set
    End Property
    Public Property IsMainCategory() As Boolean
        Get
            Return _isMainCategory
        End Get
        Set(ByVal Value As Boolean)
            _isMainCategory = Value
        End Set
    End Property
    Public Property NewsStatusId() As Integer
        Get
            Return _newsStatusId
        End Get
        Set(ByVal Value As Integer)
            _newsStatusId = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
    Public Property IsHotCate() As Boolean
        Get
            Return _isHotCate
        End Get
        Set(ByVal Value As Boolean)
            _isHotCate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsByMediaInfo

#Region "Private Members"
    Private _id As Integer
    Private _newsId As Integer
    Private _mediaId As Integer
    Private _sendView As Boolean
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

    Public Property NewsId() As Integer
        Get
            Return _newsId
        End Get
        Set(ByVal Value As Integer)
            _newsId = Value
        End Set
    End Property
    Public Property MediaId() As Integer
        Get
            Return _mediaId
        End Get
        Set(ByVal Value As Integer)
            _mediaId = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsByTagsInfo

#Region "Private Members"
    Private _id As Long
    Private _newsId As Integer
    Private _tagName As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
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

    Public Property Id() As Long
        Get
            Return _id
        End Get
        Set(ByVal Value As Long)
            _id = Value
        End Set
    End Property

    Public Property NewsId() As Integer
        Get
            Return _newsId
        End Get
        Set(ByVal Value As Integer)
            _newsId = Value
        End Set
    End Property
    Public Property TagName() As String
        Get
            Return _tagName
        End Get
        Set(ByVal Value As String)
            _tagName = Value
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
    Public Property UpdatedDate() As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsCategoriesInfo

#Region "Private Members"
    Private _categoryID As Integer
    Private _categoryName As String = String.Empty
    Private _description As String = String.Empty
    Private _tabID As Integer
    Private _tabMobileID As Integer
    Private _isActive As Boolean
    Private _createDate As DateTime
    Private _portalId As Integer
    Private _parentId As Integer
    Private _orderNumber As Integer
    Private _type As Byte
    Private _languageId As String = String.Empty
    Private _sendView As Boolean
    Private _tabPath As String = String.Empty
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

    Public Property CategoryID() As Integer
        Get
            Return _categoryID
        End Get
        Set(ByVal Value As Integer)
            _categoryID = Value
        End Set
    End Property

    Public Property CategoryName() As String
        Get
            Return _categoryName
        End Get
        Set(ByVal Value As String)
            _categoryName = Value
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
    Public Property TabID() As Integer
        Get
            Return _tabID
        End Get
        Set(ByVal Value As Integer)
            _tabID = Value
        End Set
    End Property
    Public Property TabMobileID() As Integer
        Get
            Return _tabMobileID
        End Get
        Set(ByVal Value As Integer)
            _tabMobileID = Value
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
    Public Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
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
    Public Property ParentId() As Integer
        Get
            Return _parentId
        End Get
        Set(ByVal Value As Integer)
            _parentId = Value
        End Set
    End Property
    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal Value As Integer)
            _orderNumber = Value
        End Set
    End Property
    Public Property Type() As Byte
        Get
            Return _type
        End Get
        Set(ByVal Value As Byte)
            _type = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
    Public Property TabPath() As String
        Get
            Return _tabPath
        End Get
        Set(ByVal Value As String)
            _tabPath = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsCategoriesPermissionInfo

#Region "Private Members"
    Private _id As Long
    Private _userId As String = String.Empty
    Private _categoryId As Integer
    Private _roleId As Integer
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

    Public Property Id() As Long
        Get
            Return _id
        End Get
        Set(ByVal Value As Long)
            _id = Value
        End Set
    End Property

    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal Value As String)
            _userId = Value
        End Set
    End Property
    Public Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal Value As Integer)
            _categoryId = Value
        End Set
    End Property
    Public Property RoleId() As Integer
        Get
            Return _roleId
        End Get
        Set(ByVal Value As Integer)
            _roleId = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsFeedbackInfo

#Region "Private Members"
    Private _newsFeedbackId As Integer
    Private _itemId As Integer
    Private _fullName As String = String.Empty
    Private _email As String = String.Empty
    Private _createDate As DateTime
    Private _phoneNumber As String = String.Empty
    Private _title As String = String.Empty
    Private _content As String = String.Empty
    Private _address As String = String.Empty
    Private _iPTrack As String = String.Empty
    Private _status As Integer
    Private _avatar As String = String.Empty
    Private _type As String = String.Empty
    Private _portalId As Integer
    Private _languageId As String = String.Empty
    Private _isLike As Integer
    Private _disLike As Integer
    Private _parentID As Integer
    Private _isRead As Boolean
    Private _userRead As String = String.Empty
    Private _dateRead As DateTime
    Private _isPublic As Boolean
    Private _userPublic As String = String.Empty
    Private _datePublic As DateTime
    Private _sendView As Boolean
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property CategoryId As Integer
    Public Property ToUrl As String
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property NewsFeedbackId() As Integer
        Get
            Return _newsFeedbackId
        End Get
        Set(ByVal Value As Integer)
            _newsFeedbackId = Value
        End Set
    End Property

    Public Property ItemId() As Integer
        Get
            Return _itemId
        End Get
        Set(ByVal Value As Integer)
            _itemId = Value
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

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
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
    Public Property PhoneNumber() As String
        Get
            Return _phoneNumber
        End Get
        Set(ByVal Value As String)
            _phoneNumber = Value
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
    Public Property Content() As String
        Get
            Return _content
        End Get
        Set(ByVal Value As String)
            _content = Value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
        End Set
    End Property
    Public Property IPTrack() As String
        Get
            Return _iPTrack
        End Get
        Set(ByVal Value As String)
            _iPTrack = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property Avatar() As String
        Get
            Return _avatar
        End Get
        Set(ByVal Value As String)
            _avatar = Value
        End Set
    End Property
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal Value As String)
            _type = Value
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
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property IsLike() As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
        End Set
    End Property
    Public Property DisLike() As Integer
        Get
            Return _disLike
        End Get
        Set(ByVal Value As Integer)
            _disLike = Value
        End Set
    End Property
    Public Property ParentID() As Integer
        Get
            Return _parentID
        End Get
        Set(ByVal Value As Integer)
            _parentID = Value
        End Set
    End Property
    Public Property IsRead() As Boolean
        Get
            Return _isRead
        End Get
        Set(ByVal Value As Boolean)
            _isRead = Value
        End Set
    End Property
    Public Property UserRead() As String
        Get
            Return _userRead
        End Get
        Set(ByVal Value As String)
            _userRead = Value
        End Set
    End Property
    Public Property DateRead() As DateTime
        Get
            Return _dateRead
        End Get
        Set(ByVal Value As DateTime)
            _dateRead = Value
        End Set
    End Property
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
        End Set
    End Property
    Public Property UserPublic() As String
        Get
            Return _userPublic
        End Get
        Set(ByVal Value As String)
            _userPublic = Value
        End Set
    End Property
    Public Property DatePublic() As DateTime
        Get
            Return _datePublic
        End Get
        Set(ByVal Value As DateTime)
            _datePublic = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsFeedBack_HistoryInfo

#Region "Private Members"
    Private _iD As Integer
    Private _newFB_ID As Integer
    Private _contents As String = String.Empty
    Private _userName As String = String.Empty
    Private _createDate As DateTime
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

    Public Property NewFB_ID() As Integer
        Get
            Return _newFB_ID
        End Get
        Set(ByVal Value As Integer)
            _newFB_ID = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
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
    Public Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsPapersInfo

#Region "Private Members"
    Private _newsPapers_ID As String = String.Empty
    Private _newsPapers_Number As Integer
    Private _category_ID As Integer
    Private _publicDate As DateTime
    Private _imagePath As String = String.Empty
    Private _isYear As Integer
    Private _isPublic As Boolean
    Private _createDate As DateTime
    Private _userName As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _portalID As Integer
    Private _sendView As Boolean
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

    Public Property NewsPapers_ID() As String
        Get
            Return _newsPapers_ID
        End Get
        Set(ByVal Value As String)
            _newsPapers_ID = Value
        End Set
    End Property

    Public Property NewsPapers_Number() As Integer
        Get
            Return _newsPapers_Number
        End Get
        Set(ByVal Value As Integer)
            _newsPapers_Number = Value
        End Set
    End Property
    Public Property Category_ID() As Integer
        Get
            Return _category_ID
        End Get
        Set(ByVal Value As Integer)
            _category_ID = Value
        End Set
    End Property
    Public Property PublicDate() As DateTime
        Get
            Return _publicDate
        End Get
        Set(ByVal Value As DateTime)
            _publicDate = Value
        End Set
    End Property
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
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
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
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
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsPapersDInfo

#Region "Private Members"
    Private _newsPapersD_ID As String = String.Empty
    Private _newsPapers_ID As String = String.Empty
    Private _pageNumber As Integer
    Private _photoPath As String = String.Empty
    Private _photoDes As String = String.Empty
    Private _createDate As DateTime
    Private _userName As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _sendView As Boolean
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

    Public Property NewsPapersD_ID() As String
        Get
            Return _newsPapersD_ID
        End Get
        Set(ByVal Value As String)
            _newsPapersD_ID = Value
        End Set
    End Property

    Public Property NewsPapers_ID() As String
        Get
            Return _newsPapers_ID
        End Get
        Set(ByVal Value As String)
            _newsPapers_ID = Value
        End Set
    End Property
    Public Property PageNumber() As Integer
        Get
            Return _pageNumber
        End Get
        Set(ByVal Value As Integer)
            _pageNumber = Value
        End Set
    End Property
    Public Property PhotoPath() As String
        Get
            Return _photoPath
        End Get
        Set(ByVal Value As String)
            _photoPath = Value
        End Set
    End Property
    Public Property PhotoDes() As String
        Get
            Return _photoDes
        End Get
        Set(ByVal Value As String)
            _photoDes = Value
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
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsRoyInfo

#Region "Private Members"
    Private _newsRoy_ID As String = String.Empty
    Private _newsID As Integer
    Private _authorName As String = String.Empty
    Private _isMoney As Double
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
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

    Public Property NewsRoy_ID() As String
        Get
            Return _newsRoy_ID
        End Get
        Set(ByVal Value As String)
            _newsRoy_ID = Value
        End Set
    End Property

    Public Property NewsID() As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
        End Set
    End Property
    Public Property AuthorName() As String
        Get
            Return _authorName
        End Get
        Set(ByVal Value As String)
            _authorName = Value
        End Set
    End Property
    Public Property IsMoney() As Double
        Get
            Return _isMoney
        End Get
        Set(ByVal Value As Double)
            _isMoney = Value
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
    Public Property UserName() As String
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
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_NewsStatusInfo

#Region "Private Members"
    Private _newsStatusId As Integer
    Private _statusName As String = String.Empty
    Private _description As String = String.Empty
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

    Public Property NewsStatusId() As Integer
        Get
            Return _newsStatusId
        End Get
        Set(ByVal Value As Integer)
            _newsStatusId = Value
        End Set
    End Property

    Public Property StatusName() As String
        Get
            Return _statusName
        End Get
        Set(ByVal Value As String)
            _statusName = Value
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
#End Region

End Class
Public Class CMS_NotifyInfo

#Region "Private Members"
    Private _notify_ID As String = String.Empty
    Private _notify_Name As String = String.Empty
    Private _provinder_ID As String = String.Empty
    Private _files_Name As String = String.Empty
    Private _files_Attch As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isActive As Boolean
    Private _isPublicAll As Boolean
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
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

    Public Property Notify_ID() As String
        Get
            Return _notify_ID
        End Get
        Set(ByVal Value As String)
            _notify_ID = Value
        End Set
    End Property

    Public Property Notify_Name() As String
        Get
            Return _notify_Name
        End Get
        Set(ByVal Value As String)
            _notify_Name = Value
        End Set
    End Property
    Public Property Provinder_ID() As String
        Get
            Return _provinder_ID
        End Get
        Set(ByVal Value As String)
            _provinder_ID = Value
        End Set
    End Property
    Public Property Files_Name() As String
        Get
            Return _files_Name
        End Get
        Set(ByVal Value As String)
            _files_Name = Value
        End Set
    End Property
    Public Property Files_Attch() As String
        Get
            Return _files_Attch
        End Get
        Set(ByVal Value As String)
            _files_Attch = Value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
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
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property IsPublicAll() As Boolean
        Get
            Return _isPublicAll
        End Get
        Set(ByVal Value As Boolean)
            _isPublicAll = Value
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
    Public Property UserName() As String
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
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_PageLocalInfo

#Region "Private Members"
    Private _pageLocalID As Integer
    Private _pageLocal_Name As String = String.Empty
    Private _isOrder As Integer
    Private _imagePath As String = String.Empty
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

    Public Property PageLocalID() As Integer
        Get
            Return _pageLocalID
        End Get
        Set(ByVal Value As Integer)
            _pageLocalID = Value
        End Set
    End Property

    Public Property PageLocal_Name() As String
        Get
            Return _pageLocal_Name
        End Get
        Set(ByVal Value As String)
            _pageLocal_Name = Value
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
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_PenNameInfo

#Region "Private Members"
    Private _id As Integer
    Private _userName As String = String.Empty
    Private _penName As String = String.Empty
    Private _isActive As Boolean
    Private _createUser As String = String.Empty
    Private _createDate As DateTime
    Private _updateUser As String = String.Empty
    Private _updateDate As DateTime
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

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property PenName() As String
        Get
            Return _penName
        End Get
        Set(ByVal Value As String)
            _penName = Value
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
    Public Property CreateUser() As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
    Public Property UpdateUser() As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
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
Public Class CMS_SettingsInfo

#Region "Private Members"
    Private _setting_ID As String = String.Empty
    Private _setting_Key As String = String.Empty
    Private _setting_Value As String = String.Empty
    Private _setting_Page As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
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

    Public Property Setting_ID() As String
        Get
            Return _setting_ID
        End Get
        Set(ByVal Value As String)
            _setting_ID = Value
        End Set
    End Property

    Public Property Setting_Key() As String
        Get
            Return _setting_Key
        End Get
        Set(ByVal Value As String)
            _setting_Key = Value
        End Set
    End Property
    Public Property Setting_Value() As String
        Get
            Return _setting_Value
        End Get
        Set(ByVal Value As String)
            _setting_Value = Value
        End Set
    End Property
    Public Property Setting_Page() As String
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
    Public Property UserName() As String
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
Public Class CMS_SetupsInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _settingName As String = String.Empty
    Private _settingValue As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalID As Integer
    Private _sendView As Boolean
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

    Public Property ID() As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
        End Set
    End Property

    Public Property SettingName() As String
        Get
            Return _settingName
        End Get
        Set(ByVal Value As String)
            _settingName = Value
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
    Public Property CreatedBy() As DateTime
        Get
            Return _createdBy
        End Get
        Set(ByVal Value As DateTime)
            _createdBy = Value
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
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
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_SiteMapInfo

#Region "Private Members"
    Private _siteMap_ID As String = String.Empty
    Private _siteMap_Name As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updateBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _isOrder As Integer
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

    Public Property SiteMap_ID() As String
        Get
            Return _siteMap_ID
        End Get
        Set(ByVal Value As String)
            _siteMap_ID = Value
        End Set
    End Property

    Public Property SiteMap_Name() As String
        Get
            Return _siteMap_Name
        End Get
        Set(ByVal Value As String)
            _siteMap_Name = Value
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
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property UpdateBy() As DateTime
        Get
            Return _updateBy
        End Get
        Set(ByVal Value As DateTime)
            _updateBy = Value
        End Set
    End Property
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
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
Public Class CMS_WebLinkInfo

#Region "Private Members"
    Private _id As Integer
    Private _name As String = String.Empty
    Private _orderNo As Integer
    Private _url As String = String.Empty
    Private _image As String = String.Empty
    Private _description As String = String.Empty
    Private _portalId As Integer
    Private _languageId As String = String.Empty
    Private _viewCount As Integer
    Private _viewType As Integer
    Private _sendView As Boolean
    Private _userName As String = String.Empty
    Private _createdate As DateTime
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

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property OrderNo() As Integer
        Get
            Return _orderNo
        End Get
        Set(ByVal Value As Integer)
            _orderNo = Value
        End Set
    End Property
    Public Property Url() As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property
    Public Property Image() As String
        Get
            Return _image
        End Get
        Set(ByVal Value As String)
            _image = Value
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
    Public Property PortalId() As Integer
        Get
            Return _portalId
        End Get
        Set(ByVal Value As Integer)
            _portalId = Value
        End Set
    End Property
    Public Property LanguageId() As String
        Get
            Return _languageId
        End Get
        Set(ByVal Value As String)
            _languageId = Value
        End Set
    End Property
    Public Property ViewCount() As Integer
        Get
            Return _viewCount
        End Get
        Set(ByVal Value As Integer)
            _viewCount = Value
        End Set
    End Property
    Public Property ViewType() As Integer
        Get
            Return _viewType
        End Get
        Set(ByVal Value As Integer)
            _viewType = Value
        End Set
    End Property
    Public Property SendView() As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
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
    Public Property Createdate() As DateTime
        Get
            Return _createdate
        End Get
        Set(ByVal Value As DateTime)
            _createdate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_TongHopInfo
#Region "Private Members"
    Private _TongHop As Integer
    Private _DangSoan As Integer
    Private _ChoDuyet As Integer
    Private _TraLai As Integer
    Private _ChoXuatBan As Integer
    Private _DaXuatBan As Integer
    Private _NgungXuatBan As Integer
#End Region
#Region "Public Properties"
    Public Property NgungXuatBan As Integer
        Get
            Return _NgungXuatBan
        End Get
        Set(ByVal Value As Integer)
            _NgungXuatBan = Value
        End Set
    End Property
    Public Property DaXuatBan As Integer
        Get
            Return _DaXuatBan
        End Get
        Set(ByVal Value As Integer)
            _DaXuatBan = Value
        End Set
    End Property
    Public Property ChoXuatBan As Integer
        Get
            Return _ChoXuatBan
        End Get
        Set(ByVal Value As Integer)
            _ChoXuatBan = Value
        End Set
    End Property
    Public Property TraLai As Integer
        Get
            Return _TraLai
        End Get
        Set(ByVal Value As Integer)
            _TraLai = Value
        End Set
    End Property
    Public Property ChoDuyet As Integer
        Get
            Return _ChoDuyet
        End Get
        Set(ByVal Value As Integer)
            _ChoDuyet = Value
        End Set
    End Property
    Public Property DangSoan As Integer
        Get
            Return _DangSoan
        End Get
        Set(ByVal Value As Integer)
            _DangSoan = Value
        End Set
    End Property
    Public Property TongHop As Integer
        Get
            Return _TongHop
        End Get
        Set(ByVal Value As Integer)
            _TongHop = Value
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
#End Region
#Region "Public Properties"
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
Public Class CMS_DocGroupInfo

#Region "Private Members"
    Private _docGroupID As String = String.Empty
    Private _docGroup_Name As String = String.Empty
    Private _docGroup_Des As String = String.Empty
    Private _parentID As String = String.Empty
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property DocGroupID As String
        Get
            Return _docGroupID
        End Get
        Set(ByVal Value As String)
            _docGroupID = Value
        End Set
    End Property
    Public Property DocGroup_Name As String
        Get
            Return _docGroup_Name
        End Get
        Set(ByVal Value As String)
            _docGroup_Name = Value
        End Set
    End Property
    Public Property DocGroup_Des As String
        Get
            Return _docGroup_Des
        End Get
        Set(ByVal Value As String)
            _docGroup_Des = Value
        End Set
    End Property
    Public Property ParentID As String
        Get
            Return _parentID
        End Get
        Set(ByVal Value As String)
            _parentID = Value
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
    Public Property CreatedBy As DateTime
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
    Public Property UpdatedBy As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UpdateName As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
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
Public Class CMS_DocumentInfo

#Region "Private Members"
    Private _document_ID As String = String.Empty
    Private _document_Name As String = String.Empty
    Private _docType_ID As String = String.Empty
    Private _docField_ID As String = String.Empty
    Private _docGroup_ID As String = String.Empty
    Private _docUnit_ID As String = String.Empty
    Private _docUnit_Name As String = String.Empty
    Private _contents As String = String.Empty
    Private _noCode As String = String.Empty
    Private _signerName As String = String.Empty
    Private _promDate As DateTime
    Private _effectDate As DateTime
    Private _endDate As DateTime
    Private _fileName As String = String.Empty
    Private _fileSource As String = String.Empty
    Private _isURL As String = String.Empty
    Private _isDownload As Integer
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
    Private _portalID As Integer
    Private _sendView As Boolean
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Document_ID As String
        Get
            Return _document_ID
        End Get
        Set(ByVal Value As String)
            _document_ID = Value
        End Set
    End Property
    Public Property Document_Name As String
        Get
            Return _document_Name
        End Get
        Set(ByVal Value As String)
            _document_Name = Value
        End Set
    End Property
    Public Property DocType_ID As String
        Get
            Return _docType_ID
        End Get
        Set(ByVal Value As String)
            _docType_ID = Value
        End Set
    End Property
    Public Property DocField_ID As String
        Get
            Return _docField_ID
        End Get
        Set(ByVal Value As String)
            _docField_ID = Value
        End Set
    End Property
    Public Property DocGroup_ID As String
        Get
            Return _docGroup_ID
        End Get
        Set(ByVal Value As String)
            _docGroup_ID = Value
        End Set
    End Property
    Public Property DocUnit_ID As String
        Get
            Return _docUnit_ID
        End Get
        Set(ByVal Value As String)
            _docUnit_ID = Value
        End Set
    End Property
    Public Property DocUnit_Name As String
        Get
            Return _docUnit_Name
        End Get
        Set(ByVal Value As String)
            _docUnit_Name = Value
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
    Public Property NoCode As String
        Get
            Return _noCode
        End Get
        Set(ByVal Value As String)
            _noCode = Value
        End Set
    End Property
    Public Property SignerName As String
        Get
            Return _signerName
        End Get
        Set(ByVal Value As String)
            _signerName = Value
        End Set
    End Property
    Public Property PromDate As DateTime
        Get
            Return _promDate
        End Get
        Set(ByVal Value As DateTime)
            _promDate = Value
        End Set
    End Property
    Public Property EffectDate As DateTime
        Get
            Return _effectDate
        End Get
        Set(ByVal Value As DateTime)
            _effectDate = Value
        End Set
    End Property
    Public Property EndDate As DateTime
        Get
            Return _endDate
        End Get
        Set(ByVal Value As DateTime)
            _endDate = Value
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
    Public Property FileSource As String
        Get
            Return _fileSource
        End Get
        Set(ByVal Value As String)
            _fileSource = Value
        End Set
    End Property
    Public Property IsURL As String
        Get
            Return _isURL
        End Get
        Set(ByVal Value As String)
            _isURL = Value
        End Set
    End Property
    Public Property IsDownload As Integer
        Get
            Return _isDownload
        End Get
        Set(ByVal Value As Integer)
            _isDownload = Value
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
    Public Property IsOrder As Integer
        Get
            Return _isOrder
        End Get
        Set(ByVal Value As Integer)
            _isOrder = Value
        End Set
    End Property
    Public Property CreatedBy As DateTime
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
    Public Property UpdatedBy As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UpdateName As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
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
    Public Property SendView As Boolean
        Get
            Return _sendView
        End Get
        Set(ByVal Value As Boolean)
            _sendView = Value
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
Public Class NewRssInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _newsSourceID As String = String.Empty
    Private _title As String = String.Empty
    Private _url As String = String.Empty
    Private _summary As String = String.Empty
    Private _content As String = String.Empty
    Private _portalId As Integer
    Private _pubDate As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
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

    Public Property ID() As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
        End Set
    End Property

    Public Property NewsSourceID() As String
        Get
            Return _newsSourceID
        End Get
        Set(ByVal Value As String)
            _newsSourceID = Value
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
    Public Property Url() As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property
    Public Property Summary() As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Content() As String
        Get
            Return _content
        End Get
        Set(ByVal Value As String)
            _content = Value
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
    Public Property PubDate() As String
        Get
            Return _pubDate
        End Get
        Set(ByVal Value As String)
            _pubDate = Value
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
        End Set
    End Property
#End Region

End Class

Public Class NewsSourceInfo

#Region "Private Members"
    Private _newsSourceID As String = String.Empty
    Private _name As String = String.Empty
    Private _link As String = String.Empty
    Private _portalId As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedBy As DateTime
    Private _updateName As String = String.Empty
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

    Public Property NewsSourceID() As String
        Get
            Return _newsSourceID
        End Get
        Set(ByVal Value As String)
            _newsSourceID = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Link() As String
        Get
            Return _link
        End Get
        Set(ByVal Value As String)
            _link = Value
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UpdateName() As String
        Get
            Return _updateName
        End Get
        Set(ByVal Value As String)
            _updateName = Value
        End Set
    End Property
#End Region

End Class

Public Class TN_BusinessInfo

#Region "Private Members"
    Private _business_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _business_En As String = String.Empty
    Private _business_Sort As String = String.Empty
    Private _regional_ID As String = String.Empty
    Private _logo As String = String.Empty
    Private _description As String = String.Empty
    Private _taxCode As String = String.Empty
    Private _mobile As String = String.Empty
    Private _fax As String = String.Empty
    Private _website As String = String.Empty
    Private _email As String = String.Empty
    Private _address As String = String.Empty
    Private _contactUser As String = String.Empty
    Private _contactMobile As String = String.Empty
    Private _contactEmail As String = String.Empty
    Private _userAdmin As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isApproval As Boolean
    Private _approvalUser As String = String.Empty
    Private _approvalDate As DateTime
    Private _portalId As Integer
    Private _scale As String = String.Empty
    Private _idSend As String = String.Empty
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

    Public Property Business_ID As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
        End Set
    End Property

    Public Property Business_Vn As String
        Get
            Return _business_Vn
        End Get
        Set(ByVal Value As String)
            _business_Vn = Value
        End Set
    End Property
    Public Property Business_En As String
        Get
            Return _business_En
        End Get
        Set(ByVal Value As String)
            _business_En = Value
        End Set
    End Property
    Public Property Business_Sort As String
        Get
            Return _business_Sort
        End Get
        Set(ByVal Value As String)
            _business_Sort = Value
        End Set
    End Property
    Public Property Regional_ID As String
        Get
            Return _regional_ID
        End Get
        Set(ByVal Value As String)
            _regional_ID = Value
        End Set
    End Property
    Public Property Logo As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
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
    Public Property TaxCode As String
        Get
            Return _taxCode
        End Get
        Set(ByVal Value As String)
            _taxCode = Value
        End Set
    End Property
    Public Property Mobile As String
        Get
            Return _mobile
        End Get
        Set(ByVal Value As String)
            _mobile = Value
        End Set
    End Property
    Public Property Fax As String
        Get
            Return _fax
        End Get
        Set(ByVal Value As String)
            _fax = Value
        End Set
    End Property
    Public Property Website As String
        Get
            Return _website
        End Get
        Set(ByVal Value As String)
            _website = Value
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
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
        End Set
    End Property
    Public Property ContactUser As String
        Get
            Return _contactUser
        End Get
        Set(ByVal Value As String)
            _contactUser = Value
        End Set
    End Property
    Public Property ContactMobile As String
        Get
            Return _contactMobile
        End Get
        Set(ByVal Value As String)
            _contactMobile = Value
        End Set
    End Property
    Public Property ContactEmail As String
        Get
            Return _contactEmail
        End Get
        Set(ByVal Value As String)
            _contactEmail = Value
        End Set
    End Property
    Public Property UserAdmin As String
        Get
            Return _userAdmin
        End Get
        Set(ByVal Value As String)
            _userAdmin = Value
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
    Public Property IsApproval As Boolean
        Get
            Return _isApproval
        End Get
        Set(ByVal Value As Boolean)
            _isApproval = Value
        End Set
    End Property
    Public Property ApprovalUser As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property ApprovalDate As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property Scale As String
        Get
            Return _scale
        End Get
        Set(ByVal Value As String)
            _scale = Value
        End Set
    End Property
    Public Property IdSend As String
        Get
            Return _idSend
        End Get
        Set(ByVal Value As String)
            _idSend = Value
        End Set
    End Property
#End Region

End Class
Public Class TN_JobUserInfo

#Region "Private Members"
    Private _jobUser_ID As String = String.Empty
    Private _title As String = String.Empty
    Private _career_ID As String = String.Empty
    Private _currentLevel As String = String.Empty
    Private _levelDesired As String = String.Empty
    Private _regional_ID As String = String.Empty
    Private _experience_ID As String = String.Empty
    Private _level_ID As String = String.Empty
    Private _salary_ID As String = String.Empty
    Private _needs_ID As String = String.Empty
    Private _education As String = String.Empty
    Private _careerGoals As String = String.Empty
    Private _workExperience As String = String.Empty
    Private _skillsForte As String = String.Empty
    Private _userAdmin As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isApproval As Boolean
    Private _approvalUser As String = String.Empty
    Private _approvalDate As DateTime
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isView As Integer
    Private _isSend As Integer
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

    Public Property JobUser_ID As String
        Get
            Return _jobUser_ID
        End Get
        Set(ByVal Value As String)
            _jobUser_ID = Value
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
    Public Property Career_ID As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
        End Set
    End Property
    Public Property CurrentLevel As String
        Get
            Return _currentLevel
        End Get
        Set(ByVal Value As String)
            _currentLevel = Value
        End Set
    End Property
    Public Property LevelDesired As String
        Get
            Return _levelDesired
        End Get
        Set(ByVal Value As String)
            _levelDesired = Value
        End Set
    End Property
    Public Property Regional_ID As String
        Get
            Return _regional_ID
        End Get
        Set(ByVal Value As String)
            _regional_ID = Value
        End Set
    End Property
    Public Property Experience_ID As String
        Get
            Return _experience_ID
        End Get
        Set(ByVal Value As String)
            _experience_ID = Value
        End Set
    End Property
    Public Property Level_ID As String
        Get
            Return _level_ID
        End Get
        Set(ByVal Value As String)
            _level_ID = Value
        End Set
    End Property
    Public Property Salary_ID As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property
    Public Property Needs_ID As String
        Get
            Return _needs_ID
        End Get
        Set(ByVal Value As String)
            _needs_ID = Value
        End Set
    End Property
    Public Property Education As String
        Get
            Return _education
        End Get
        Set(ByVal Value As String)
            _education = Value
        End Set
    End Property
    Public Property CareerGoals As String
        Get
            Return _careerGoals
        End Get
        Set(ByVal Value As String)
            _careerGoals = Value
        End Set
    End Property
    Public Property WorkExperience As String
        Get
            Return _workExperience
        End Get
        Set(ByVal Value As String)
            _workExperience = Value
        End Set
    End Property
    Public Property SkillsForte As String
        Get
            Return _skillsForte
        End Get
        Set(ByVal Value As String)
            _skillsForte = Value
        End Set
    End Property
    Public Property UserAdmin As String
        Get
            Return _userAdmin
        End Get
        Set(ByVal Value As String)
            _userAdmin = Value
        End Set
    End Property
    Public Property StartDate As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
        End Set
    End Property
    Public Property EndDate As DateTime
        Get
            Return _endDate
        End Get
        Set(ByVal Value As DateTime)
            _endDate = Value
        End Set
    End Property
    Public Property IsApproval As Boolean
        Get
            Return _isApproval
        End Get
        Set(ByVal Value As Boolean)
            _isApproval = Value
        End Set
    End Property
    Public Property ApprovalUser As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property ApprovalDate As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
        End Set
    End Property
    Public Property IsDelete As Boolean
        Get
            Return _isDelete
        End Get
        Set(ByVal Value As Boolean)
            _isDelete = Value
        End Set
    End Property
    Public Property DeletedUser As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
    Public Property IsView As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
        End Set
    End Property
    Public Property IsSend As Integer
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Integer)
            _isSend = Value
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
#End Region

End Class


Public Class TN_WorkInfo

#Region "Private Members"
    Private _work_ID As String = String.Empty
    Private _business_ID As String = String.Empty
    Private _title As String = String.Empty
    Private _salary_ID As String = String.Empty
    Private _quantity As Integer
    Private _experience_ID As String = String.Empty
    Private _gender As Integer
    Private _level_ID As String = String.Empty
    Private _regional_ID As String = String.Empty
    Private _typeOf_ID As String = String.Empty
    Private _career_ID As String = String.Empty
    Private _description As String = String.Empty
    Private _requirement As String = String.Empty
    Private _benefit As String = String.Empty
    Private _requirementsProfile As String = String.Empty
    Private _expiredDate As DateTime
    Private _submissionSend As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _contactUser As String = String.Empty
    Private _contactAddress As String = String.Empty
    Private _contactMobile As String = String.Empty
    Private _contactEmail As String = String.Empty
    Private _contactDes As String = String.Empty
    Private _isHot As Boolean
    Private _isFast As Boolean
    Private _isUrgent As Boolean
    Private _isApproval As Boolean
    Private _approvalUser As String = String.Empty
    Private _approvalDate As DateTime
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isView As Integer
    Private _isSend As Integer
    Private _portalID As Integer
    Private _levelDesired_ID As String = String.Empty
    Private _isFlag As Integer
    Private _jobPlace As String = String.Empty
    Private _idSend As String = String.Empty
    Private _iD As Integer
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

    Public Property Work_ID As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
        End Set
    End Property

    Public Property Business_ID As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
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
    Public Property Salary_ID As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property
    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal Value As Integer)
            _quantity = Value
        End Set
    End Property
    Public Property Experience_ID As String
        Get
            Return _experience_ID
        End Get
        Set(ByVal Value As String)
            _experience_ID = Value
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
    Public Property Level_ID As String
        Get
            Return _level_ID
        End Get
        Set(ByVal Value As String)
            _level_ID = Value
        End Set
    End Property
    Public Property Regional_ID As String
        Get
            Return _regional_ID
        End Get
        Set(ByVal Value As String)
            _regional_ID = Value
        End Set
    End Property
    Public Property TypeOf_ID As String
        Get
            Return _typeOf_ID
        End Get
        Set(ByVal Value As String)
            _typeOf_ID = Value
        End Set
    End Property
    Public Property Career_ID As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
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
    Public Property Requirement As String
        Get
            Return _requirement
        End Get
        Set(ByVal Value As String)
            _requirement = Value
        End Set
    End Property
    Public Property Benefit As String
        Get
            Return _benefit
        End Get
        Set(ByVal Value As String)
            _benefit = Value
        End Set
    End Property
    Public Property RequirementsProfile As String
        Get
            Return _requirementsProfile
        End Get
        Set(ByVal Value As String)
            _requirementsProfile = Value
        End Set
    End Property
    Public Property ExpiredDate As DateTime
        Get
            Return _expiredDate
        End Get
        Set(ByVal Value As DateTime)
            _expiredDate = Value
        End Set
    End Property
    Public Property SubmissionSend As String
        Get
            Return _submissionSend
        End Get
        Set(ByVal Value As String)
            _submissionSend = Value
        End Set
    End Property
    Public Property StartDate As DateTime
        Get
            Return _startDate
        End Get
        Set(ByVal Value As DateTime)
            _startDate = Value
        End Set
    End Property
    Public Property EndDate As DateTime
        Get
            Return _endDate
        End Get
        Set(ByVal Value As DateTime)
            _endDate = Value
        End Set
    End Property
    Public Property ContactUser As String
        Get
            Return _contactUser
        End Get
        Set(ByVal Value As String)
            _contactUser = Value
        End Set
    End Property
    Public Property ContactAddress As String
        Get
            Return _contactAddress
        End Get
        Set(ByVal Value As String)
            _contactAddress = Value
        End Set
    End Property
    Public Property ContactMobile As String
        Get
            Return _contactMobile
        End Get
        Set(ByVal Value As String)
            _contactMobile = Value
        End Set
    End Property
    Public Property ContactEmail As String
        Get
            Return _contactEmail
        End Get
        Set(ByVal Value As String)
            _contactEmail = Value
        End Set
    End Property
    Public Property ContactDes As String
        Get
            Return _contactDes
        End Get
        Set(ByVal Value As String)
            _contactDes = Value
        End Set
    End Property
    Public Property IsHot As Boolean
        Get
            Return _isHot
        End Get
        Set(ByVal Value As Boolean)
            _isHot = Value
        End Set
    End Property
    Public Property IsFast As Boolean
        Get
            Return _isFast
        End Get
        Set(ByVal Value As Boolean)
            _isFast = Value
        End Set
    End Property
    Public Property IsUrgent As Boolean
        Get
            Return _isUrgent
        End Get
        Set(ByVal Value As Boolean)
            _isUrgent = Value
        End Set
    End Property
    Public Property IsApproval As Boolean
        Get
            Return _isApproval
        End Get
        Set(ByVal Value As Boolean)
            _isApproval = Value
        End Set
    End Property
    Public Property ApprovalUser As String
        Get
            Return _approvalUser
        End Get
        Set(ByVal Value As String)
            _approvalUser = Value
        End Set
    End Property
    Public Property ApprovalDate As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
        End Set
    End Property
    Public Property IsDelete As Boolean
        Get
            Return _isDelete
        End Get
        Set(ByVal Value As Boolean)
            _isDelete = Value
        End Set
    End Property
    Public Property DeletedUser As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
    Public Property IsView As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
        End Set
    End Property
    Public Property IsSend As Integer
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Integer)
            _isSend = Value
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
    Public Property LevelDesired_ID As String
        Get
            Return _levelDesired_ID
        End Get
        Set(ByVal Value As String)
            _levelDesired_ID = Value
        End Set
    End Property
    Public Property IsFlag As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
        End Set
    End Property
    Public Property JobPlace As String
        Get
            Return _jobPlace
        End Get
        Set(ByVal Value As String)
            _jobPlace = Value
        End Set
    End Property
    Public Property IdSend As String
        Get
            Return _idSend
        End Get
        Set(ByVal Value As String)
            _idSend = Value
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
#End Region

End Class

Public Class TopicInfo
    Private _Topic_ID As String
    Public Property Topic_ID() As String
        Get
            Return _Topic_ID
        End Get
        Set(ByVal value As String)
            _Topic_ID = value
        End Set
    End Property
    Private _Topic_Name As String
    Public Property Topic_Name() As String
        Get
            Return _Topic_Name
        End Get
        Set(ByVal value As String)
            _Topic_Name = value
        End Set
    End Property
End Class

Public Class TN_NewsInfo

#Region "Private Members"
    Private _news_ID As String = String.Empty
    Private _topic_ID As String = String.Empty
    Private _news_Name As String = String.Empty
    Private _toUrl As String = String.Empty
    Private _dupTitle As String = String.Empty
    Private _linkUrl As String = String.Empty
    Private _isHot As Boolean
    Private _isStatus As Integer
    Private _isComents As Boolean
    Private _images As String = String.Empty
    Private _newType As Integer
    Private _contents As String = String.Empty
    Private _details As String = String.Empty
    Private _userWriter As String = String.Empty
    Private _viewSource As String = String.Empty
    Private _tags As String = String.Empty
    Private _tagsName As String = String.Empty
    Private _isVisitor As Integer
    Private _isLike As Integer
    Private _isOrder As Integer
    Private _title As String = String.Empty
    Private _keywords As String = String.Empty
    Private _description As String = String.Empty
    Private _newsRelate As String = String.Empty
    Private _otherTopic As String = String.Empty
    Private _userName As String = String.Empty
    Private _createdBy As DateTime
    Private _isEdited As Boolean
    Private _userEdited As String = String.Empty
    Private _dateEdited As DateTime
    Private _isPublic As Boolean
    Private _userPublic As String = String.Empty
    Private _datePublic As DateTime
    Private _isLang As String = String.Empty
    Private _portalID As Integer
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _eN_Name As String = String.Empty
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

    Public Property News_ID() As String
        Get
            Return _news_ID
        End Get
        Set(ByVal Value As String)
            _news_ID = Value
        End Set
    End Property

    Public Property Topic_ID() As String
        Get
            Return _topic_ID
        End Get
        Set(ByVal Value As String)
            _topic_ID = Value
        End Set
    End Property
    Public Property News_Name() As String
        Get
            Return _news_Name
        End Get
        Set(ByVal Value As String)
            _news_Name = Value
        End Set
    End Property
    Public Property ToUrl() As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property DupTitle() As String
        Get
            Return _dupTitle
        End Get
        Set(ByVal Value As String)
            _dupTitle = Value
        End Set
    End Property
    Public Property LinkUrl() As String
        Get
            Return _linkUrl
        End Get
        Set(ByVal Value As String)
            _linkUrl = Value
        End Set
    End Property
    Public Property IsHot() As Boolean
        Get
            Return _isHot
        End Get
        Set(ByVal Value As Boolean)
            _isHot = Value
        End Set
    End Property
    Public Property IsStatus() As Integer
        Get
            Return _isStatus
        End Get
        Set(ByVal Value As Integer)
            _isStatus = Value
        End Set
    End Property
    Public Property IsComents() As Boolean
        Get
            Return _isComents
        End Get
        Set(ByVal Value As Boolean)
            _isComents = Value
        End Set
    End Property
    Public Property Images() As String
        Get
            Return _images
        End Get
        Set(ByVal Value As String)
            _images = Value
        End Set
    End Property
    Public Property NewType() As Integer
        Get
            Return _newType
        End Get
        Set(ByVal Value As Integer)
            _newType = Value
        End Set
    End Property
    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property Details() As String
        Get
            Return _details
        End Get
        Set(ByVal Value As String)
            _details = Value
        End Set
    End Property
    Public Property UserWriter() As String
        Get
            Return _userWriter
        End Get
        Set(ByVal Value As String)
            _userWriter = Value
        End Set
    End Property
    Public Property ViewSource() As String
        Get
            Return _viewSource
        End Get
        Set(ByVal Value As String)
            _viewSource = Value
        End Set
    End Property
    Public Property Tags() As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property TagsName() As String
        Get
            Return _tagsName
        End Get
        Set(ByVal Value As String)
            _tagsName = Value
        End Set
    End Property
    Public Property IsVisitor() As Integer
        Get
            Return _isVisitor
        End Get
        Set(ByVal Value As Integer)
            _isVisitor = Value
        End Set
    End Property
    Public Property IsLike() As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
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
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal Value As String)
            _title = Value
        End Set
    End Property
    Public Property Keywords() As String
        Get
            Return _keywords
        End Get
        Set(ByVal Value As String)
            _keywords = Value
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
    Public Property NewsRelate() As String
        Get
            Return _newsRelate
        End Get
        Set(ByVal Value As String)
            _newsRelate = Value
        End Set
    End Property
    Public Property OtherTopic() As String
        Get
            Return _otherTopic
        End Get
        Set(ByVal Value As String)
            _otherTopic = Value
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
    Public Property CreatedBy() As DateTime
        Get
            Return _createdBy
        End Get
        Set(ByVal Value As DateTime)
            _createdBy = Value
        End Set
    End Property
    Public Property IsEdited() As Boolean
        Get
            Return _isEdited
        End Get
        Set(ByVal Value As Boolean)
            _isEdited = Value
        End Set
    End Property
    Public Property UserEdited() As String
        Get
            Return _userEdited
        End Get
        Set(ByVal Value As String)
            _userEdited = Value
        End Set
    End Property
    Public Property DateEdited() As DateTime
        Get
            Return _dateEdited
        End Get
        Set(ByVal Value As DateTime)
            _dateEdited = Value
        End Set
    End Property
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
        End Set
    End Property
    Public Property UserPublic() As String
        Get
            Return _userPublic
        End Get
        Set(ByVal Value As String)
            _userPublic = Value
        End Set
    End Property
    Public Property DatePublic() As DateTime
        Get
            Return _datePublic
        End Get
        Set(ByVal Value As DateTime)
            _datePublic = Value
        End Set
    End Property
    Public Property IsLang() As String
        Get
            Return _isLang
        End Get
        Set(ByVal Value As String)
            _isLang = Value
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
        End Set
    End Property
    Public Property UserUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
    Public Property EN_Name() As String
        Get
            Return _eN_Name
        End Get
        Set(ByVal Value As String)
            _eN_Name = Value
        End Set
    End Property
#End Region

End Class

Public Class DM_SliderInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tieuDe As String = String.Empty
    Private _tieuDePhu As String = String.Empty
    Private _moTa As String = String.Empty
    Private _lienKet As String = String.Empty
    Private _avatar As String = String.Empty
    Private _thuTu As Integer
    Private _hoatDong As Boolean
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

    Public Property TieuDe() As String
        Get
            Return _tieuDe
        End Get
        Set(ByVal Value As String)
            _tieuDe = Value
        End Set
    End Property

    Public Property TieuDePhu() As String
        Get
            Return _tieuDePhu
        End Get
        Set(ByVal Value As String)
            _tieuDePhu = Value
        End Set
    End Property
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property LienKet() As String
        Get
            Return _lienKet
        End Get
        Set(ByVal Value As String)
            _lienKet = Value
        End Set
    End Property
    Public Property ThuTu() As Integer
        Get
            Return _thuTu
        End Get
        Set(ByVal Value As Integer)
            _thuTu = Value
        End Set
    End Property
    Public Property HoatDong() As Boolean
        Get
            Return _hoatDong
        End Get
        Set(ByVal Value As Boolean)
            _hoatDong = Value
        End Set
    End Property
    Public Property Avatar() As String
        Get
            Return _avatar
        End Get
        Set(ByVal Value As String)
            _avatar = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_NhomBannerInfo

#Region "Private Members"
    Private _id As Integer
    Private _tenNhomBanner As String = String.Empty
    Private _ghiChu As String = String.Empty
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

    Public Property TenNhomBanner() As String
        Get
            Return _tenNhomBanner
        End Get
        Set(ByVal Value As String)
            _tenNhomBanner = Value
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
#End Region

End Class


Public Class CMS_BannerInfo

#Region "Private Members"
    Private _id As Integer
    Private _idNhomBanner As Integer
    Private _tenBanner As String = String.Empty
    Private _hinhAnh As String = String.Empty
    Private _ghiChu As String = String.Empty
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

    Public Property IdNhomBanner() As Integer
        Get
            Return _idNhomBanner
        End Get
        Set(ByVal Value As Integer)
            _idNhomBanner = Value
        End Set
    End Property
    Public Property TenBanner() As String
        Get
            Return _tenBanner
        End Get
        Set(ByVal Value As String)
            _tenBanner = Value
        End Set
    End Property
    Public Property HinhAnh() As String
        Get
            Return _hinhAnh
        End Get
        Set(ByVal Value As String)
            _hinhAnh = Value
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
#End Region

End Class

Public Class CMS_BackUpInfo

#Region "Private Members"
    Private _id As Integer
    Private _tenBackup As String = String.Empty
    Private _heThongBackup As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isWriteLog As Boolean
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

    Public Property TenBackup() As String
        Get
            Return _tenBackup
        End Get
        Set(ByVal Value As String)
            _tenBackup = Value
        End Set
    End Property
    Public Property HeThongBackup() As String
        Get
            Return _heThongBackup
        End Get
        Set(ByVal Value As String)
            _heThongBackup = Value
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
    Public Property IsWriteLog() As Boolean
        Get
            Return _isWriteLog
        End Get
        Set(ByVal Value As Boolean)
            _isWriteLog = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_ThongBaoInfo

#Region "Private Members"
    Private _id As Integer
    Private _tenThongBao As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isRead As Boolean
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

    Public Property TenThongBao() As String
        Get
            Return _tenThongBao
        End Get
        Set(ByVal Value As String)
            _tenThongBao = Value
        End Set
    End Property
    Public Property NoiDung() As String
        Get
            Return _noiDung
        End Get
        Set(ByVal Value As String)
            _noiDung = Value
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
    Public Property IsRead() As Boolean
        Get
            Return _isRead
        End Get
        Set(ByVal Value As Boolean)
            _isRead = Value
        End Set
    End Property
#End Region

End Class


Public Class CMS_NewsAudioInfo

#Region "Private Members"
    Private _iD As Integer
    Private _newsId As Integer
    Private _audioName As String = String.Empty
    Private _audioCode As String = String.Empty
    Private _audioPath As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
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

    Public Property NewsId() As Integer
        Get
            Return _newsId
        End Get
        Set(ByVal Value As Integer)
            _newsId = Value
        End Set
    End Property
    Public Property AudioName() As String
        Get
            Return _audioName
        End Get
        Set(ByVal Value As String)
            _audioName = Value
        End Set
    End Property
    Public Property AudioCode() As String
        Get
            Return _audioCode
        End Get
        Set(ByVal Value As String)
            _audioCode = Value
        End Set
    End Property
    Public Property AudioPath() As String
        Get
            Return _audioPath
        End Get
        Set(ByVal Value As String)
            _audioPath = Value
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








