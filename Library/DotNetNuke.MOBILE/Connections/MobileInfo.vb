Public Class CMS_AppInfo

#Region "Private Members"
	Private _appKey As String = String.Empty
	Private _appID As String = String.Empty
	Private _avatar As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _hoVaTen As String = String.Empty
    Private _history As String = String.Empty
    Private _gioiTinh As Integer
    Private _ngaySinh As String = String.Empty
    Private _createDate As DateTime
    Private _isSystem As Integer
    Private _portalID As Integer
    Private _total As Integer
    Private _isPoint As Double
    Private _usPoint As Double
    Private _isLevel As Integer
#End Region

#Region "Public Properties"
    Public Property TinhTP As Integer
    Public Property QuanHuyen As Integer
    Public Property History As String
        Get
            Return _history
        End Get
        Set(ByVal Value As String)
            _history = Value
        End Set
    End Property
    Public Property IsPoint As Double
        Get
            Return _isPoint
        End Get
        Set(ByVal Value As Double)
            _isPoint = Value
        End Set
    End Property
    Public Property UsPoint As Double
        Get
            Return _usPoint
        End Get
        Set(ByVal Value As Double)
            _usPoint = Value
        End Set
    End Property
    Public Property IsLevel As Integer
        Get
            Return _isLevel
        End Get
        Set(ByVal Value As Integer)
            _isLevel = Value
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
    Public Property AppKey As String
        Get
            Return _appKey
        End Get
        Set(ByVal Value As String)
            _appKey = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property Avatar As String
        Get
            Return _avatar
        End Get
        Set(ByVal Value As String)
            _avatar = Value
        End Set
    End Property
    Public Property HoVaTen As String
        Get
            Return _hoVaTen
        End Get
        Set(ByVal Value As String)
            _hoVaTen = Value
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
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property IsSystem As Integer
        Get
            Return _isSystem
        End Get
        Set(ByVal Value As Integer)
            _isSystem = Value
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
Public Class CMS_AppLogInfo

#Region "Private Members"
    Private _iD As Integer
    Private _token As String = String.Empty
    Private _appID As String = String.Empty
    Private _logDate As DateTime
    Private _logEnd As DateTime
    Private _isSystem As Integer
    Private _location As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Token As String
        Get
            Return _token
        End Get
        Set(ByVal Value As String)
            _token = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property LogDate As DateTime
        Get
            Return _logDate
        End Get
        Set(ByVal Value As DateTime)
            _logDate = Value
        End Set
    End Property
    Public Property LogEnd As DateTime
        Get
            Return _logEnd
        End Get
        Set(ByVal Value As DateTime)
            _logEnd = Value
        End Set
    End Property
    Public Property IsSystem As Integer
        Get
            Return _isSystem
        End Get
        Set(ByVal Value As Integer)
            _isSystem = Value
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
Public Class CMS_CategoryInfo

#Region "Private Members"
    Private _categoryID As Integer
    Private _categoryName As String = String.Empty
    Private _description As String = String.Empty
    Private _isActive As Boolean
    Private _isApp As Boolean
    Private _portalID As Integer
    Private _parentId As Integer
    Private _orders As Integer
    Private _isType As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _total As Integer
    Private _tabPath As String = String.Empty
    Private _tabID As Integer
    Private _imagePath As String = String.Empty
#End Region

#Region "Public Properties"
    Public Property TabID() As Integer
        Get
            Return _tabID
        End Get
        Set(ByVal Value As Integer)
            _tabID = Value
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
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property CategoryID As Integer
        Get
            Return _categoryID
        End Get
        Set(ByVal Value As Integer)
            _categoryID = Value
        End Set
    End Property
    Public Property CategoryName As String
        Get
            Return _categoryName
        End Get
        Set(ByVal Value As String)
            _categoryName = Value
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
    Public Property IsApp As Boolean
        Get
            Return _isApp
        End Get
        Set(ByVal Value As Boolean)
            _isApp = Value
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
    Public Property PortalID As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property ParentId As Integer
        Get
            Return _parentId
        End Get
        Set(ByVal Value As Integer)
            _parentId = Value
        End Set
    End Property
    Public Property Orders As Integer
        Get
            Return _orders
        End Get
        Set(ByVal Value As Integer)
            _orders = Value
        End Set
    End Property
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
Public Class CMS_FCMInfo

#Region "Private Members"
    Private _iD As Integer
    Private _token As String = String.Empty
    Private _appID As String = String.Empty
    Private _isSystem As Integer
    Private _portalID As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Token As String
        Get
            Return _token
        End Get
        Set(ByVal Value As String)
            _token = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property IsSystem As Integer
        Get
            Return _isSystem
        End Get
        Set(ByVal Value As Integer)
            _isSystem = Value
        End Set
    End Property
    Public Property PortalID As String
        Get
            Return _portalID
        End Get
        Set(ByVal Value As String)
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
Public Class CMS_NewsInfo

#Region "Private Members"
    Private _newsID As Integer
    Private _portalID As Integer
    Private _cateID As Integer
    Private _introduction As String = String.Empty
    Private _titles As String = String.Empty
    Private _toUrl As String = String.Empty
    Private _imagePath As String = String.Empty
    Private _summary As String = String.Empty
    Private _contents As String = String.Empty
    Private _isActive As Boolean
    Private _status As Short
    Private _links As String = String.Empty
    Private _tags As String = String.Empty
    Private _writerName As String = String.Empty
    Private _isApp As Boolean
    Private _isOrder As Integer
    Private _isLike As Integer
    Private _isView As Integer
    Private _publishedDate As DateTime
    Private _publishedUser As String = String.Empty
    Private _cancelPublishDate As DateTime
    Private _cancelPublishUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _isHot As Boolean
    Private _isCare As Boolean
    Private _isList As Boolean
#End Region

#Region "Public Properties"

    Public Property TabPath As String
    Public Property CateName As String
    Public Property NewsID As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
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
    Public Property IsCare() As Boolean
        Get
            Return _isCare
        End Get
        Set(ByVal Value As Boolean)
            _isCare = Value
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
    Public Property CateID As Integer
        Get
            Return _cateID
        End Get
        Set(ByVal Value As Integer)
            _cateID = Value
        End Set
    End Property
    Public Property Introduction As String
        Get
            Return _introduction
        End Get
        Set(ByVal Value As String)
            _introduction = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property ToUrl As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property ImagePath As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property Summary As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
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
    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property IsApp As Boolean
        Get
            Return _isApp
        End Get
        Set(ByVal Value As Boolean)
            _isApp = Value
        End Set
    End Property
    Public Property Status As Short
        Get
            Return _status
        End Get
        Set(ByVal Value As Short)
            _status = Value
        End Set
    End Property
    Public Property Links As String
        Get
            Return _links
        End Get
        Set(ByVal Value As String)
            _links = Value
        End Set
    End Property
    Public Property Tags As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property WriterName As String
        Get
            Return _writerName
        End Get
        Set(ByVal Value As String)
            _writerName = Value
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
    Public Property IsLike As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
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
    Public Property IsList As Boolean
        Get
            Return _isList
        End Get
        Set(ByVal Value As Boolean)
            _isList = Value
        End Set
    End Property
    Public Property PublishedDate As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property PublishedUser As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
        End Set
    End Property
    Public Property CancelPublishDate As DateTime
        Get
            Return _cancelPublishDate
        End Get
        Set(ByVal Value As DateTime)
            _cancelPublishDate = Value
        End Set
    End Property
    Public Property CancelPublishUser As String
        Get
            Return _cancelPublishUser
        End Get
        Set(ByVal Value As String)
            _cancelPublishUser = Value
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
Public Class CMS_NewsTagInfo

#Region "Private Members"
    Private _iD As Integer
    Private _newsID As Integer
    Private _tagName As String = String.Empty
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property NewsID As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
        End Set
    End Property
    Public Property TagName As String
        Get
            Return _tagName
        End Get
        Set(ByVal Value As String)
            _tagName = Value
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
Public Class CMS_NewVersionInfo

#Region "Private Members"
    Private _version_ID As Integer
    Private _version_Name As String = String.Empty
    Private _newsID As Integer
    Private _portalID As Integer
    Private _cateID As Integer
    Private _introduction As String = String.Empty
    Private _titles As String = String.Empty
    Private _toUrl As String = String.Empty
    Private _imagePath As String = String.Empty
    Private _summary As String = String.Empty
    Private _contents As String = String.Empty
    Private _isActive As Boolean
    Private _status As Short
    Private _links As String = String.Empty
    Private _tags As String = String.Empty
    Private _writerName As String = String.Empty
    Private _isLike As Integer
    Private _isView As Integer
    Private _publishedDate As DateTime
    Private _publishedUser As String = String.Empty
    Private _cancelPublishDate As DateTime
    Private _cancelPublishUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _isHot As Boolean
    Private _isCare As Boolean
#End Region

#Region "Public Properties"
    Public Property IsHot() As Boolean
        Get
            Return _isHot
        End Get
        Set(ByVal Value As Boolean)
            _isHot = Value
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
    Public Property Version_ID As Integer
        Get
            Return _version_ID
        End Get
        Set(ByVal Value As Integer)
            _version_ID = Value
        End Set
    End Property
    Public Property Version_Name As String
        Get
            Return _version_Name
        End Get
        Set(ByVal Value As String)
            _version_Name = Value
        End Set
    End Property
    Public Property NewsID As Integer
        Get
            Return _newsID
        End Get
        Set(ByVal Value As Integer)
            _newsID = Value
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
    Public Property CateID As Integer
        Get
            Return _cateID
        End Get
        Set(ByVal Value As Integer)
            _cateID = Value
        End Set
    End Property
    Public Property Introduction As String
        Get
            Return _introduction
        End Get
        Set(ByVal Value As String)
            _introduction = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property ToUrl As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property ImagePath As String
        Get
            Return _imagePath
        End Get
        Set(ByVal Value As String)
            _imagePath = Value
        End Set
    End Property
    Public Property Summary As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
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
    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property Status As Short
        Get
            Return _status
        End Get
        Set(ByVal Value As Short)
            _status = Value
        End Set
    End Property
    Public Property Links As String
        Get
            Return _links
        End Get
        Set(ByVal Value As String)
            _links = Value
        End Set
    End Property
    Public Property Tags As String
        Get
            Return _tags
        End Get
        Set(ByVal Value As String)
            _tags = Value
        End Set
    End Property
    Public Property WriterName As String
        Get
            Return _writerName
        End Get
        Set(ByVal Value As String)
            _writerName = Value
        End Set
    End Property
    Public Property IsLike As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
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
    Public Property PublishedDate As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property PublishedUser As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
        End Set
    End Property
    Public Property CancelPublishDate As DateTime
        Get
            Return _cancelPublishDate
        End Get
        Set(ByVal Value As DateTime)
            _cancelPublishDate = Value
        End Set
    End Property
    Public Property CancelPublishUser As String
        Get
            Return _cancelPublishUser
        End Get
        Set(ByVal Value As String)
            _cancelPublishUser = Value
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
Public Class CMS_PortalsInfo

#Region "Private Members"
    Private _iD As Integer
    Private _names As String = String.Empty
    Private _Des As String = String.Empty
    Private _android As Integer
    Private _iOS As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property A_Version As String
    Public Property I_Version As String
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Names As String
        Get
            Return _names
        End Get
        Set(ByVal Value As String)
            _names = Value
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
    Public Property Android As Integer
        Get
            Return _android
        End Get
        Set(ByVal Value As Integer)
            _android = Value
        End Set
    End Property
    Public Property IOS As Integer
        Get
            Return _iOS
        End Get
        Set(ByVal Value As Integer)
            _iOS = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
Public Class CMS_VideoInfo

#Region "Private Members"
    Private _videoID As Integer
    Private _portalID As Integer
    Private _cateID As Integer
    Private _titles As String = String.Empty
    Private _toUrl As String = String.Empty
    Private _images As String = String.Empty
    Private _summary As String = String.Empty
    Private _Writer As String = String.Empty
    Private _isYoutube As Boolean
    Private _mediaUrl As String = String.Empty
    Private _isView As Integer
    Private _isLike As Integer
    Private _status As Integer
    Private _publishedDate As DateTime
    Private _publishedUser As String = String.Empty
    Private _cancelPublishDate As DateTime
    Private _cancelPublishUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _CateName As String = String.Empty
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _isBad As Integer
#End Region

#Region "Public Properties"
    Public Property TabPath As String
    Public Property IsBad As Integer
        Get
            Return _isBad
        End Get
        Set(ByVal Value As Integer)
            _isBad = Value
        End Set
    End Property
    Public Property CateName As String
        Get
            Return _CateName
        End Get
        Set(ByVal Value As String)
            _CateName = Value
        End Set
    End Property
    Public Property VideoID As Integer
        Get
            Return _videoID
        End Get
        Set(ByVal Value As Integer)
            _videoID = Value
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
    Public Property CateID As Integer
        Get
            Return _cateID
        End Get
        Set(ByVal Value As Integer)
            _cateID = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property ToUrl As String
        Get
            Return _toUrl
        End Get
        Set(ByVal Value As String)
            _toUrl = Value
        End Set
    End Property
    Public Property Images As String
        Get
            Return _images
        End Get
        Set(ByVal Value As String)
            _images = Value
        End Set
    End Property
    Public Property Summary As String
        Get
            Return _summary
        End Get
        Set(ByVal Value As String)
            _summary = Value
        End Set
    End Property
    Public Property Writer As String
        Get
            Return _Writer
        End Get
        Set(ByVal Value As String)
            _Writer = Value
        End Set
    End Property
    Public Property IsYoutube As Boolean
        Get
            Return _isYoutube
        End Get
        Set(ByVal Value As Boolean)
            _isYoutube = Value
        End Set
    End Property
    Public Property MediaUrl As String
        Get
            Return _mediaUrl
        End Get
        Set(ByVal Value As String)
            _mediaUrl = Value
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
    Public Property IsLike As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
        End Set
    End Property
    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property PublishedDate As DateTime
        Get
            Return _publishedDate
        End Get
        Set(ByVal Value As DateTime)
            _publishedDate = Value
        End Set
    End Property
    Public Property PublishedUser As String
        Get
            Return _publishedUser
        End Get
        Set(ByVal Value As String)
            _publishedUser = Value
        End Set
    End Property
    Public Property CancelPublishDate As DateTime
        Get
            Return _cancelPublishDate
        End Get
        Set(ByVal Value As DateTime)
            _cancelPublishDate = Value
        End Set
    End Property
    Public Property CancelPublishUser As String
        Get
            Return _cancelPublishUser
        End Get
        Set(ByVal Value As String)
            _cancelPublishUser = Value
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
Public Class CMS_GroupInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _des As String = String.Empty
    Private _CreateDate As DateTime
    Private _createUser As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
    Private _isActive As Boolean
#End Region

#Region "Public Properties"
    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
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
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Des As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _CreateDate
        End Get
        Set(ByVal Value As DateTime)
            _CreateDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
Public Class CMS_GroupDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _groupID As Integer
    Private _name As String = String.Empty
    Private _images As String = String.Empty
    Private _icon As String = String.Empty
    Private _CreateDate As DateTime
    Private _createUser As String = String.Empty
    Private _isLike As Integer
    Private _portalID As Integer
    Private _total As Integer
    Private _writer As String = String.Empty
    Private _isActive As Boolean
    Private _isBad As Integer
#End Region

#Region "Public Properties"
    Public Property IsBad As Integer
        Get
            Return _isBad
        End Get
        Set(ByVal Value As Integer)
            _isBad = Value
        End Set
    End Property
    Public Property Images As String
        Get
            Return _images
        End Get
        Set(ByVal Value As String)
            _images = Value
        End Set
    End Property
    Public Property Icon As String
        Get
            Return _icon
        End Get
        Set(ByVal Value As String)
            _icon = Value
        End Set
    End Property
    Public Property Writer As String
        Get
            Return _writer
        End Get
        Set(ByVal Value As String)
            _writer = Value
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
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property GroupID As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _CreateDate
        End Get
        Set(ByVal Value As DateTime)
            _CreateDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property IsLike As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
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
Public Class CMS_ChapterInfo

#Region "Private Members"
    Private _iD As Integer
    Private _storyID As Integer
    Private _name As String = String.Empty
    Private _contents As String = String.Empty
    Private _isView As Integer
    Private _isPublic As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property StoryName As String
    Public Property Pages As Integer
    Public Property IsComment As Integer
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property StoryID As Integer
        Get
            Return _storyID
        End Get
        Set(ByVal Value As Integer)
            _storyID = Value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
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
    Public Property IsView As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
        End Set
    End Property
    Public Property IsPublic As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
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
Public Class CMS_StoryInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _logo As String = String.Empty
    Private _hotCate As Boolean
    Private _description As String = String.Empty
    Private _author As String = String.Empty
    Private _status As Integer
    Private _source As String = String.Empty
    Private _isView As Integer
    Private _IsLike As Integer
    Private _isComment As Integer
    Private _isPublic As Boolean
    Private _isChapter As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Chapter As Integer
    Public Property IsLike As Integer
        Get
            Return _IsLike
        End Get
        Set(ByVal Value As Integer)
            _IsLike = Value
        End Set
    End Property
    Public Property IsChapter As Integer
        Get
            Return _isChapter
        End Get
        Set(ByVal Value As Integer)
            _isChapter = Value
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
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
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
    Public Property HotCate As Boolean
        Get
            Return _hotCate
        End Get
        Set(ByVal Value As Boolean)
            _hotCate = Value
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
    Public Property Author As String
        Get
            Return _author
        End Get
        Set(ByVal Value As String)
            _author = Value
        End Set
    End Property
    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
    Public Property Source As String
        Get
            Return _source
        End Get
        Set(ByVal Value As String)
            _source = Value
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
    Public Property IsComment As Integer
        Get
            Return _isComment
        End Get
        Set(ByVal Value As Integer)
            _isComment = Value
        End Set
    End Property
    Public Property IsPublic As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
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
Public Class CMS_StoryCInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _des As String = String.Empty
    Private _logo As String = String.Empty
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Des As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
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
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_TokenInfo

    Public Property PortalID As Integer
    Public Property Status As Integer
    Public Property Token As String = String.Empty
    Public Property AppID As String = String.Empty


End Class
Public Class CMS_StoryFBInfo

#Region "Private Members"
    Private _iD As Integer
    Private _storyID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _writer As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _total As Integer
    Private _isLock As Boolean
#End Region

#Region "Public Properties"
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
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
    Public Property StoryID As Integer
        Get
            Return _storyID
        End Get
        Set(ByVal Value As Integer)
            _storyID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property Writer As String
        Get
            Return _writer
        End Get
        Set(ByVal Value As String)
            _writer = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
Public Class CMS_StoryPInfo

#Region "Private Members"
    Private _iD As Integer
    Private _storyID As Integer
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property StoryID As Integer
        Get
            Return _storyID
        End Get
        Set(ByVal Value As Integer)
            _storyID = Value
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
Public Class CMS_StoryDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _storyID As Integer
    Private _CateID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property StoryID As Integer
        Get
            Return _storyID
        End Get
        Set(ByVal Value As Integer)
            _storyID = Value
        End Set
    End Property
    Public Property CateID As Integer
        Get
            Return _CateID
        End Get
        Set(ByVal Value As Integer)
            _CateID = Value
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
Public Class CMS_AdMobInfo

#Region "Private Members"
    Private _iD As Integer
    Private _a_Version As String = String.Empty
    Private _a_ID As String = String.Empty
    Private _a_BieuNgu As String = String.Empty
    Private _a_TangThuong As String = String.Empty
    Private _a_NangCao As String = String.Empty
    Private _a_Testing As Boolean
    Private _i_Version As String = String.Empty
    Private _i_ID As String = String.Empty
    Private _i_BieuNgu As String = String.Empty
    Private _i_TangThuong As String = String.Empty
    Private _i_NangCao As String = String.Empty
    Private _i_Testing As Boolean
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property A_LinkUp As String
    Public Property I_LinkUp As String
    Public Property Description As String

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property A_Version As String
        Get
            Return _a_Version
        End Get
        Set(ByVal Value As String)
            _a_Version = Value
        End Set
    End Property
    Public Property A_ID As String
        Get
            Return _a_ID
        End Get
        Set(ByVal Value As String)
            _a_ID = Value
        End Set
    End Property
    Public Property A_BieuNgu As String
        Get
            Return _a_BieuNgu
        End Get
        Set(ByVal Value As String)
            _a_BieuNgu = Value
        End Set
    End Property
    Public Property A_TangThuong As String
        Get
            Return _a_TangThuong
        End Get
        Set(ByVal Value As String)
            _a_TangThuong = Value
        End Set
    End Property
    Public Property A_NangCao As String
        Get
            Return _a_NangCao
        End Get
        Set(ByVal Value As String)
            _a_NangCao = Value
        End Set
    End Property
    Public Property A_Testing As Boolean
        Get
            Return _a_Testing
        End Get
        Set(ByVal Value As Boolean)
            _a_Testing = Value
        End Set
    End Property
    Public Property I_Version As String
        Get
            Return _i_Version
        End Get
        Set(ByVal Value As String)
            _i_Version = Value
        End Set
    End Property
    Public Property I_ID As String
        Get
            Return _i_ID
        End Get
        Set(ByVal Value As String)
            _i_ID = Value
        End Set
    End Property
    Public Property I_BieuNgu As String
        Get
            Return _i_BieuNgu
        End Get
        Set(ByVal Value As String)
            _i_BieuNgu = Value
        End Set
    End Property
    Public Property I_TangThuong As String
        Get
            Return _i_TangThuong
        End Get
        Set(ByVal Value As String)
            _i_TangThuong = Value
        End Set
    End Property
    Public Property I_NangCao As String
        Get
            Return _i_NangCao
        End Get
        Set(ByVal Value As String)
            _i_NangCao = Value
        End Set
    End Property
    Public Property I_Testing As Boolean
        Get
            Return _i_Testing
        End Get
        Set(ByVal Value As Boolean)
            _i_Testing = Value
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
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_AdvertiseInfo

#Region "Private Members"
    Private _advertise_ID As String = String.Empty
    Private _advertise_Name As String = String.Empty
    Private _images As String = String.Empty
    Private _target As String = String.Empty
    Private _OpenLink As String = String.Empty
    Private _isURL As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _IsClick As Integer
#End Region

#Region "Public Properties"
    Public Property IsClick As Integer
        Get
            Return _IsClick
        End Get
        Set(ByVal Value As Integer)
            _IsClick = Value
        End Set
    End Property
    Public Property Advertise_ID As String
        Get
            Return _advertise_ID
        End Get
        Set(ByVal Value As String)
            _advertise_ID = Value
        End Set
    End Property
    Public Property Advertise_Name As String
        Get
            Return _advertise_Name
        End Get
        Set(ByVal Value As String)
            _advertise_Name = Value
        End Set
    End Property
    Public Property Images As String
        Get
            Return _images
        End Get
        Set(ByVal Value As String)
            _images = Value
        End Set
    End Property
    Public Property OpenLink As String
        Get
            Return _OpenLink
        End Get
        Set(ByVal Value As String)
            _OpenLink = Value
        End Set
    End Property
    Public Property Target As String
        Get
            Return _target
        End Get
        Set(ByVal Value As String)
            _target = Value
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
Public Class CMS_AdvertisePInfo

#Region "Private Members"
    Private _iD As Integer
    Private _advertise_ID As String = String.Empty
    Private _PortalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Advertise_ID As String
        Get
            Return _advertise_ID
        End Get
        Set(ByVal Value As String)
            _advertise_ID = Value
        End Set
    End Property
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
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
Public Class CMS_AdvertiseLInfo

#Region "Private Members"
    Private _iD As Integer
    Private _advertise_ID As String = String.Empty
    Private _PageLocal As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Advertise_ID As String
        Get
            Return _advertise_ID
        End Get
        Set(ByVal Value As String)
            _advertise_ID = Value
        End Set
    End Property
    Public Property PageLocal As Integer
        Get
            Return _PageLocal
        End Get
        Set(ByVal Value As Integer)
            _PageLocal = Value
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
Public Class CMS_NotifyInfo

#Region "Private Members"
    Private _notify_ID As String = String.Empty
    Private _titles As String = String.Empty
    Private _contents As String = String.Empty
    Private _types As Integer
    Private _startDay As Integer
    Private _IsActive As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _sendDate As DateTime
    Private _PortalID As Integer
#End Region

#Region "Public Properties"
    Public Property SendDate As DateTime
        Get
            Return _sendDate
        End Get
        Set(ByVal Value As DateTime)
            _sendDate = Value
        End Set
    End Property
    Public Property Notify_ID As String
        Get
            Return _notify_ID
        End Get
        Set(ByVal Value As String)
            _notify_ID = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
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
    Public Property Types As Integer
        Get
            Return _types
        End Get
        Set(ByVal Value As Integer)
            _types = Value
        End Set
    End Property
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
        End Set
    End Property
    Public Property StartDay As Integer
        Get
            Return _startDay
        End Get
        Set(ByVal Value As Integer)
            _startDay = Value
        End Set
    End Property
    Public Property IsActive As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal Value As Boolean)
            _IsActive = Value
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
Public Class CMS_NotiLogInfo

#Region "Private Members"
    Private _notiLog_ID As Integer
    Private _notify_ID As String = String.Empty
    Private _logName As String = String.Empty
    Private _logDate As DateTime
    Private _logUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property FcmID As Integer
    Public Property NotiLog_ID As Integer
        Get
            Return _notiLog_ID
        End Get
        Set(ByVal Value As Integer)
            _notiLog_ID = Value
        End Set
    End Property
    Public Property Notify_ID As String
        Get
            Return _notify_ID
        End Get
        Set(ByVal Value As String)
            _notify_ID = Value
        End Set
    End Property
    Public Property LogName As String
        Get
            Return _logName
        End Get
        Set(ByVal Value As String)
            _logName = Value
        End Set
    End Property
    Public Property LogDate As DateTime
        Get
            Return _logDate
        End Get
        Set(ByVal Value As DateTime)
            _logDate = Value
        End Set
    End Property
    Public Property LogUser As String
        Get
            Return _logUser
        End Get
        Set(ByVal Value As String)
            _logUser = Value
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
Public Class CMS_NotiSendInfo

#Region "Private Members"
    Private _notiSend_ID As Integer
    Private _notify_ID As String = String.Empty
    Private _titles As String = String.Empty
    Private _contents As String = String.Empty
    Private _appID As String = String.Empty
    Private _sendDate As DateTime
    Private _readDate As DateTime
    Private _createdDate As DateTime
    Private _total As Integer
    Private _tinhTrang As Integer
    Private _IdKey As String = String.Empty
    Private _PortalID As Integer
#End Region

#Region "Public Properties"
    Public Property Logo As String
    Public Property FwSend As String
    Public Property Flags As String
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
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
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property IdKey As String
        Get
            Return _IdKey
        End Get
        Set(ByVal Value As String)
            _IdKey = Value
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
    Public Property NotiSend_ID As Integer
        Get
            Return _notiSend_ID
        End Get
        Set(ByVal Value As Integer)
            _notiSend_ID = Value
        End Set
    End Property
    Public Property Notify_ID As String
        Get
            Return _notify_ID
        End Get
        Set(ByVal Value As String)
            _notify_ID = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property SendDate As DateTime
        Get
            Return _sendDate
        End Get
        Set(ByVal Value As DateTime)
            _sendDate = Value
        End Set
    End Property
    Public Property ReadDate As DateTime
        Get
            Return _readDate
        End Get
        Set(ByVal Value As DateTime)
            _readDate = Value
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
Public Class CMS_RegEmailInfo

    Public Property RegEmail_ID As String
    Public Property RegEmail As String
    Public Property RegDate As DateTime
    Public Property Total As Integer

End Class
Public Class CMS_Fr_CommentInfo

#Region "Private Members"
    Private _logo As String = String.Empty
    Private _comment_ID As Integer
    Private _post_ID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _total As Integer
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _reply As String = String.Empty
    Private _lockedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
#End Region

#Region "Public Properties"
    Public Property imgComment As String = ""
    Public Property Logo() As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
        End Set
    End Property
    Public Property Reply As String
        Get
            Return _reply
        End Get
        Set(ByVal Value As String)
            _reply = Value
        End Set
    End Property
    Public Property comment_ID As Integer
        Get
            Return _comment_ID
        End Get
        Set(ByVal Value As Integer)
            _comment_ID = Value
        End Set
    End Property
    Public Property Post_ID As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property contents As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property DeletedDate As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_Fr_FileAttachInfo

#Region "Private Members"
    Private _attach_ID As String = String.Empty
    Private _idKey As String = String.Empty
    Private _fileAttach As String = String.Empty
    Private _fileType As Integer
    Private _isOrder As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Attach_ID As String
        Get
            Return _attach_ID
        End Get
        Set(ByVal Value As String)
            _attach_ID = Value
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
    Public Property FileAttach As String
        Get
            Return _fileAttach
        End Get
        Set(ByVal Value As String)
            _fileAttach = Value
        End Set
    End Property
    Public Property FileType As Integer
        Get
            Return _fileType
        End Get
        Set(ByVal Value As Integer)
            _fileType = Value
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
Public Class CMS_Fr_LikesInfo

#Region "Private Members"
    Private _likesID As Integer
    Private _appID As String = String.Empty
    Private _postID As Integer
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property LikesID As Integer
        Get
            Return _likesID
        End Get
        Set(ByVal Value As Integer)
            _likesID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property PostID As Integer
        Get
            Return _postID
        End Get
        Set(ByVal Value As Integer)
            _postID = Value
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
Public Class CMS_Fr_NotifyInfo

#Region "Private Members"
    Private _iD As Integer
    Private _PortalID As Integer
    Private _fromApp As String = String.Empty
    Private _toApp As String = String.Empty
    Private _contents As String = String.Empty
    Private _createdDate As DateTime
    Private _toLink As String = String.Empty
    Private _idKey As String = String.Empty
    Private _flags As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AllPublic As Boolean
    Public Property IsNew As Integer
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
        End Set
    End Property
    Public Property FromApp As String
        Get
            Return _fromApp
        End Get
        Set(ByVal Value As String)
            _fromApp = Value
        End Set
    End Property
    Public Property ToApp As String
        Get
            Return _toApp
        End Get
        Set(ByVal Value As String)
            _toApp = Value
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
    Public Property CreatedDate As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
        End Set
    End Property
    Public Property ToLink As String
        Get
            Return _toLink
        End Get
        Set(ByVal Value As String)
            _toLink = Value
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
Public Class CMS_Fr_PostInfo

#Region "Private Members"
    Private _post_ID As Integer
    Private _PortalID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _publicAll As Boolean
    Private _onlyMe As Boolean
    Private _friends As Boolean
    Private _isLike As Integer
    Private _isComment As Integer
    Private _isShare As Integer
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _lockedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _postShareID As Integer
    Private _total As Integer
    Private _isType As Integer
#End Region

#Region "Public Properties"
    Public Property BaiDang As Integer
    Public Property BaiKhoa As Integer
    Public Property BrithDay As String
    Public Property imgTop As String
    Public Property groupID As Integer
    Public Property groupType As Integer
    Public Property groupLogo As String
    Public Property groupName As String
    Public Property HoVaTen As String
    Public Property Avatar As String
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
        End Set
    End Property
    Public Property Post_ID As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property CreatedDate As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
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
    Public Property PublicAll As Boolean
        Get
            Return _publicAll
        End Get
        Set(ByVal Value As Boolean)
            _publicAll = Value
        End Set
    End Property
    Public Property OnlyMe As Boolean
        Get
            Return _onlyMe
        End Get
        Set(ByVal Value As Boolean)
            _onlyMe = Value
        End Set
    End Property
    Public Property Friends As Boolean
        Get
            Return _friends
        End Get
        Set(ByVal Value As Boolean)
            _friends = Value
        End Set
    End Property
    Public Property IsLike As Integer
        Get
            Return _isLike
        End Get
        Set(ByVal Value As Integer)
            _isLike = Value
        End Set
    End Property
    Public Property IsComment As Integer
        Get
            Return _isComment
        End Get
        Set(ByVal Value As Integer)
            _isComment = Value
        End Set
    End Property
    Public Property IsShare As Integer
        Get
            Return _isShare
        End Get
        Set(ByVal Value As Integer)
            _isShare = Value
        End Set
    End Property
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property DeletedDate As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
        End Set
    End Property
    Public Property PostShareID As Integer
        Get
            Return _postShareID
        End Get
        Set(ByVal Value As Integer)
            _postShareID = Value
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
Public Class CMS_Fr_SharePostInfo

#Region "Private Members"
    Private _sharePost_ID As Integer
    Private _post_ID As Integer
    Private _shareAppID As String = String.Empty
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property SharePost_ID As Integer
        Get
            Return _sharePost_ID
        End Get
        Set(ByVal Value As Integer)
            _sharePost_ID = Value
        End Set
    End Property
    Public Property Post_ID As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property ShareAppID As String
        Get
            Return _shareAppID
        End Get
        Set(ByVal Value As String)
            _shareAppID = Value
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
Public Class CMS_Fr_ShareUserInfo

#Region "Private Members"
    Private _shareUser_ID As Integer
    Private _post_ID As Integer
    Private _shareAppID As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ShareUser_ID As Integer
        Get
            Return _shareUser_ID
        End Get
        Set(ByVal Value As Integer)
            _shareUser_ID = Value
        End Set
    End Property
    Public Property Post_ID As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property ShareAppID As String
        Get
            Return _shareAppID
        End Get
        Set(ByVal Value As String)
            _shareAppID = Value
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
Public Class CMS_Fr_GroupInfo

#Region "Private Members"
    Private _iD As Integer
    Private _isType As Integer
    Private _isYear As Integer
    Private _PortalID As Integer
    Private _eID As String = String.Empty
    Private _appID As String = String.Empty
    Private _name As String = String.Empty
    Private _logo As String = String.Empty
    Private _des As String = String.Empty
    Private _isStatus As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _isLock As Boolean
#End Region

#Region "Public Properties"
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property Totalbaiviet As Integer
    Public Property Totalnguoidang As Integer
    Public Property Totalgroup As Integer
    Public Property Totalbikhoa As Integer
    Public Property pTotal As Integer
    Public Property uTotal As Integer
    Public Property isUse As Integer

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
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
    Public Property PortalID As Integer
        Get
            Return _PortalID
        End Get
        Set(ByVal Value As Integer)
            _PortalID = Value
        End Set
    End Property
    Public Property EID As String
        Get
            Return _eID
        End Get
        Set(ByVal Value As String)
            _eID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
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
    Public Property Des As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
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
Public Class CMS_Fr_GroupUInfo

#Region "Private Members"
    Private _iD As Integer
    Private _groupID As Integer
    Private _appID As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _isLock As Boolean
#End Region

#Region "Public Properties"
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property IsBoss As Boolean
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property GroupID As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
Public Class CMS_FoodInfo

#Region "Private Members"
    Private _portalID As Integer
    Private _logo As String = String.Empty
    Private _iD As Integer
    Private _foodC_ID As Integer
    Private _name As String = String.Empty
    Private _trophic As String = String.Empty
    Private _pregnantStatus As Byte
    Private _pregnantDes As String = String.Empty
    Private _postpartumStatus As Byte
    Private _postpartumDes As String = String.Empty
    Private _breastfeedingStatus As Byte
    Private _breastfeedingDes As String = String.Empty
    Private _babyStatus As Byte
    Private _babyDes As String = String.Empty
    Private _isPublic As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Nguon As String = ""
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
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

    Public Property FoodC_ID() As Integer
        Get
            Return _foodC_ID
        End Get
        Set(ByVal Value As Integer)
            _foodC_ID = Value
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
    Public Property Trophic() As String
        Get
            Return _trophic
        End Get
        Set(ByVal Value As String)
            _trophic = Value
        End Set
    End Property
    Public Property PregnantStatus() As Byte
        Get
            Return _pregnantStatus
        End Get
        Set(ByVal Value As Byte)
            _pregnantStatus = Value
        End Set
    End Property
    Public Property PregnantDes() As String
        Get
            Return _pregnantDes
        End Get
        Set(ByVal Value As String)
            _pregnantDes = Value
        End Set
    End Property
    Public Property PostpartumStatus() As Byte
        Get
            Return _postpartumStatus
        End Get
        Set(ByVal Value As Byte)
            _postpartumStatus = Value
        End Set
    End Property
    Public Property PostpartumDes() As String
        Get
            Return _postpartumDes
        End Get
        Set(ByVal Value As String)
            _postpartumDes = Value
        End Set
    End Property
    Public Property BreastfeedingStatus() As Byte
        Get
            Return _breastfeedingStatus
        End Get
        Set(ByVal Value As Byte)
            _breastfeedingStatus = Value
        End Set
    End Property
    Public Property BreastfeedingDes() As String
        Get
            Return _breastfeedingDes
        End Get
        Set(ByVal Value As String)
            _breastfeedingDes = Value
        End Set
    End Property
    Public Property BabyStatus() As Byte
        Get
            Return _babyStatus
        End Get
        Set(ByVal Value As Byte)
            _babyStatus = Value
        End Set
    End Property
    Public Property BabyDes() As String
        Get
            Return _babyDes
        End Get
        Set(ByVal Value As String)
            _babyDes = Value
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
Public Class CMS_FoodCInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _des As String = String.Empty
    Private _logo As String = String.Empty
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
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

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Des() As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
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
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
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
#End Region

End Class
Public Class CMS_ClinicInfo

#Region "Private Members"
    Private _portalID As Integer
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _description As String = String.Empty
    Private _workTime As String = String.Empty
    Private _doctors As String = String.Empty
    Private _hospital As String = String.Empty
    Private _mobile As String = String.Empty
    Private _isActie As Boolean
    Private _isRepu As Boolean
    Private _isType As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _duongPho As String = String.Empty
    Private _latitude As Double
    Private _longitude As Double
    Private _logo As String = String.Empty
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property km_New As Double
    Public Property rAVG As Double
    Public Property rMyApp As Integer
    Public Property rTotal As Integer
    Public Property cTotal As Integer
    Public Property r5 As Integer
    Public Property r4 As Integer
    Public Property r3 As Integer
    Public Property r2 As Integer
    Public Property r1 As Integer
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
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
    Public Property WorkTime As String
        Get
            Return _workTime
        End Get
        Set(ByVal Value As String)
            _workTime = Value
        End Set
    End Property
    Public Property Doctors As String
        Get
            Return _doctors
        End Get
        Set(ByVal Value As String)
            _doctors = Value
        End Set
    End Property
    Public Property Hospital As String
        Get
            Return _hospital
        End Get
        Set(ByVal Value As String)
            _hospital = Value
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
    Public Property IsActie As Boolean
        Get
            Return _isActie
        End Get
        Set(ByVal Value As Boolean)
            _isActie = Value
        End Set
    End Property
    Public Property IsRepu As Boolean
        Get
            Return _isRepu
        End Get
        Set(ByVal Value As Boolean)
            _isRepu = Value
        End Set
    End Property
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
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
    Public Property QuanHuyen As Integer
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As Integer)
            _quanHuyen = Value
        End Set
    End Property
    Public Property XaPhuong As Integer
        Get
            Return _xaPhuong
        End Get
        Set(ByVal Value As Integer)
            _xaPhuong = Value
        End Set
    End Property
    Public Property DuongPho As String
        Get
            Return _duongPho
        End Get
        Set(ByVal Value As String)
            _duongPho = Value
        End Set
    End Property
    Public Property Latitude As Double
        Get
            Return _latitude
        End Get
        Set(ByVal Value As Double)
            _latitude = Value
        End Set
    End Property
    Public Property Longitude As Double
        Get
            Return _longitude
        End Get
        Set(ByVal Value As Double)
            _longitude = Value
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
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_CrushInfo
#Region "Private Members"
    Private _iD As Integer
    Private _appID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _logo As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _namSinh As Integer
    Private _gioiTinh As String = String.Empty
    Private _portalID As Integer
    Private _isReg As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer

#End Region
#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property Logo As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
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
    Public Property NamSinh As Integer
        Get
            Return _namSinh
        End Get
        Set(ByVal Value As Integer)
            _namSinh = Value
        End Set
    End Property
    Public Property GioiTinh As String
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As String)
            _gioiTinh = Value
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
    Public Property IsReg As Boolean
        Get
            Return _isReg
        End Get
        Set(ByVal Value As Boolean)
            _isReg = Value
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
Public Class CMS_CookingInfo

#Region "Private Members"
    Private _iD As Integer
    Private _isView As Integer
    Private _portalID As Integer
    Private _logo As String = String.Empty
    Private _name As String = String.Empty
    Private _cookTime As Short
    Private _difficultLevel As String
    Private _mealType As String
    Private _cookingType As String
    Private _tasteType As String
    Private _spiceType As String
    Private _material As String = String.Empty
    Private _making As String = String.Empty
    Private _isPublic As Boolean
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
    Public Property IsView As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
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
    Public Property Logo() As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
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
    Public Property CookTime() As Short
        Get
            Return _cookTime
        End Get
        Set(ByVal Value As Short)
            _cookTime = Value
        End Set
    End Property
    Public Property DifficultLevel() As String
        Get
            Return _difficultLevel
        End Get
        Set(ByVal Value As String)
            _difficultLevel = Value
        End Set
    End Property
    Public Property SpiceType() As String
        Get
            Return _spiceType
        End Get
        Set(ByVal Value As String)
            _spiceType = Value
        End Set
    End Property
    Public Property MealType() As String
        Get
            Return _mealType
        End Get
        Set(ByVal Value As String)
            _mealType = Value
        End Set
    End Property
    Public Property CookingType() As String
        Get
            Return _cookingType
        End Get
        Set(ByVal Value As String)
            _cookingType = Value
        End Set
    End Property
    Public Property TasteType() As String
        Get
            Return _tasteType
        End Get
        Set(ByVal Value As String)
            _tasteType = Value
        End Set
    End Property
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal Value As String)
            _material = Value
        End Set
    End Property
    Public Property Making() As String
        Get
            Return _making
        End Get
        Set(ByVal Value As String)
            _making = Value
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
Public Class CMS_CookingCInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _des As String = String.Empty
    Private _logo As String = String.Empty
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
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

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property Des() As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
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
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
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
#End Region

End Class
Public Class CMS_CookingOInfo

#Region "Private Members"
    Private _iD As Integer
    Private _cookingID As Integer
    Private _cateID As Integer
    Private _total As Integer
    Private _cateName As String
#End Region

#Region "Public Properties"
    Public Property CateName() As String
        Get
            Return _cateName
        End Get
        Set(ByVal Value As String)
            _cateName = Value
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

    Public Property CookingID() As Integer
        Get
            Return _cookingID
        End Get
        Set(ByVal Value As Integer)
            _cookingID = Value
        End Set
    End Property
    Public Property CateID() As Integer
        Get
            Return _cateID
        End Get
        Set(ByVal Value As Integer)
            _cateID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_CookingDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _name As String = String.Empty
    Private _isType As Integer
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_BabyHeightInfo

#Region "Private Members"
    Private _iD As Integer
    Private _month As Integer
    Private _lowerLimit As Double
    Private _normal As Double
    Private _upperLimit As Double
    Private _isSex As Double
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Month As Integer
        Get
            Return _month
        End Get
        Set(ByVal Value As Integer)
            _month = Value
        End Set
    End Property
    Public Property LowerLimit As Double
        Get
            Return _lowerLimit
        End Get
        Set(ByVal Value As Double)
            _lowerLimit = Value
        End Set
    End Property
    Public Property Normal As Double
        Get
            Return _normal
        End Get
        Set(ByVal Value As Double)
            _normal = Value
        End Set
    End Property
    Public Property UpperLimit As Double
        Get
            Return _upperLimit
        End Get
        Set(ByVal Value As Double)
            _upperLimit = Value
        End Set
    End Property
    Public Property IsSex As Double
        Get
            Return _isSex
        End Get
        Set(ByVal Value As Double)
            _isSex = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_BabyWeightInfo

#Region "Private Members"
    Private _iD As Integer
    Private _month As Integer
    Private _underWeight As Double
    Private _riskUnderWeight As Double
    Private _normal As Double
    Private _riskOverWeight As Double
    Private _overWeight As Double
    Private _isSex As Integer
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Month As Integer
        Get
            Return _month
        End Get
        Set(ByVal Value As Integer)
            _month = Value
        End Set
    End Property
    Public Property UnderWeight As Double
        Get
            Return _underWeight
        End Get
        Set(ByVal Value As Double)
            _underWeight = Value
        End Set
    End Property
    Public Property RiskUnderWeight As Double
        Get
            Return _riskUnderWeight
        End Get
        Set(ByVal Value As Double)
            _riskUnderWeight = Value
        End Set
    End Property
    Public Property Normal As Double
        Get
            Return _normal
        End Get
        Set(ByVal Value As Double)
            _normal = Value
        End Set
    End Property
    Public Property RiskOverWeight As Double
        Get
            Return _riskOverWeight
        End Get
        Set(ByVal Value As Double)
            _riskOverWeight = Value
        End Set
    End Property
    Public Property OverWeight As Double
        Get
            Return _overWeight
        End Get
        Set(ByVal Value As Double)
            _overWeight = Value
        End Set
    End Property
    Public Property IsSex As Integer
        Get
            Return _isSex
        End Get
        Set(ByVal Value As Integer)
            _isSex = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ClinicRInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _clinicID As Integer
    Private _isRate As Integer
    Private _createdUser As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedUser As String = String.Empty
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property ClinicID As Integer
        Get
            Return _clinicID
        End Get
        Set(ByVal Value As Integer)
            _clinicID = Value
        End Set
    End Property
    Public Property IsRate As Integer
        Get
            Return _isRate
        End Get
        Set(ByVal Value As Integer)
            _isRate = Value
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
    Public Property CreatedDate As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ClinicCInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _clinicID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _reply As String = String.Empty
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _lockedDate As DateTime
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _total As Integer
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property ClinicID As Integer
        Get
            Return _clinicID
        End Get
        Set(ByVal Value As Integer)
            _clinicID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property Reply As String
        Get
            Return _reply
        End Get
        Set(ByVal Value As String)
            _reply = Value
        End Set
    End Property
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
    Public Property DeletedDate As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_MuiTiemInfo

#Region "Private Members"
    Private _iD As Integer
    Private _vacXin_ID As Integer
    Private _muiTiem As Integer
    Private _thangTuoi As String = String.Empty
    Private _moTa As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property tinhTrang As Integer
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property VacXin_ID As Integer
        Get
            Return _vacXin_ID
        End Get
        Set(ByVal Value As Integer)
            _vacXin_ID = Value
        End Set
    End Property
    Public Property MuiTiem As Integer
        Get
            Return _muiTiem
        End Get
        Set(ByVal Value As Integer)
            _muiTiem = Value
        End Set
    End Property
    Public Property ThangTuoi As String
        Get
            Return _thangTuoi
        End Get
        Set(ByVal Value As String)
            _thangTuoi = Value
        End Set
    End Property
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_VacXinInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenVacXin As String = String.Empty
    Private _tiemPhong As String = String.Empty
    Private _denLichTiem As String = String.Empty
    Private _benh As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _phanUngPhu As String = String.Empty
    Private _batBuoc As Boolean
    Private _portalID As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ThangTuoi As String
    Public Property Mtotal As Integer
    Public Property trangThai As Integer
    Public Property mui1 As Integer
    Public Property mui2 As Integer
    Public Property mui3 As Integer
    Public Property mui4 As Integer
    Public Property mui5 As Integer
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property TenVacXin As String
        Get
            Return _tenVacXin
        End Get
        Set(ByVal Value As String)
            _tenVacXin = Value
        End Set
    End Property
    Public Property TiemPhong As String
        Get
            Return _tiemPhong
        End Get
        Set(ByVal Value As String)
            _tiemPhong = Value
        End Set
    End Property
    Public Property DenLichTiem As String
        Get
            Return _denLichTiem
        End Get
        Set(ByVal Value As String)
            _denLichTiem = Value
        End Set
    End Property
    Public Property Benh As String
        Get
            Return _benh
        End Get
        Set(ByVal Value As String)
            _benh = Value
        End Set
    End Property
    Public Property NoiDung As String
        Get
            Return _noiDung
        End Get
        Set(ByVal Value As String)
            _noiDung = Value
        End Set
    End Property
    Public Property PhanUngPhu As String
        Get
            Return _phanUngPhu
        End Get
        Set(ByVal Value As String)
            _phanUngPhu = Value
        End Set
    End Property
    Public Property BatBuoc As Boolean
        Get
            Return _batBuoc
        End Get
        Set(ByVal Value As Boolean)
            _batBuoc = Value
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
#End Region

End Class
Public Class CMS_DoanHinhInfo

#Region "Private Members"
    Private _isActive As Boolean
    Private _iD As Integer
    Private _tenCauHoi As String = String.Empty
    Private _hinhAnh As String = String.Empty
    Private _dapAn As String = String.Empty
    Private _soKyTu As Integer
    Private _phimNhap As String = String.Empty
    Private _mucDo As Integer
    Private _soDiem As Integer
    Private _moDapAn As Integer
    Private _moChuCai As Integer
    Private _boChuCai As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property KyTuSai As String
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property TenCauHoi As String
        Get
            Return _tenCauHoi
        End Get
        Set(ByVal Value As String)
            _tenCauHoi = Value
        End Set
    End Property
    Public Property HinhAnh As String
        Get
            Return _hinhAnh
        End Get
        Set(ByVal Value As String)
            _hinhAnh = Value
        End Set
    End Property
    Public Property DapAn As String
        Get
            Return _dapAn
        End Get
        Set(ByVal Value As String)
            _dapAn = Value
        End Set
    End Property
    Public Property SoKyTu As Integer
        Get
            Return _soKyTu
        End Get
        Set(ByVal Value As Integer)
            _soKyTu = Value
        End Set
    End Property
    Public Property PhimNhap As String
        Get
            Return _phimNhap
        End Get
        Set(ByVal Value As String)
            _phimNhap = Value
        End Set
    End Property
    Public Property MucDo As Integer
        Get
            Return _mucDo
        End Get
        Set(ByVal Value As Integer)
            _mucDo = Value
        End Set
    End Property
    Public Property SoDiem As Integer
        Get
            Return _soDiem
        End Get
        Set(ByVal Value As Integer)
            _soDiem = Value
        End Set
    End Property
    Public Property MoDapAn As Integer
        Get
            Return _moDapAn
        End Get
        Set(ByVal Value As Integer)
            _moDapAn = Value
        End Set
    End Property
    Public Property MoChuCai As Integer
        Get
            Return _moChuCai
        End Get
        Set(ByVal Value As Integer)
            _moChuCai = Value
        End Set
    End Property
    Public Property BoChuCai As Integer
        Get
            Return _boChuCai
        End Get
        Set(ByVal Value As Integer)
            _boChuCai = Value
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
Public Class CMS_GameImgInfo

#Region "Private Members"
    Private _iD As Integer
    Private _appID As String = String.Empty
    Private _isLevel As Integer
    Private _dePoint As Integer
    Private _adPoint As Integer
    Private _isCup As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property PortalID As Integer
    Public Property AppName As String = ""
    Public Property AppLogo As String = ""
    Public Property AppMobile As String = ""
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property IsLevel As Integer
        Get
            Return _isLevel
        End Get
        Set(ByVal Value As Integer)
            _isLevel = Value
        End Set
    End Property
    Public Property DePoint As Integer
        Get
            Return _dePoint
        End Get
        Set(ByVal Value As Integer)
            _dePoint = Value
        End Set
    End Property
    Public Property AdPoint As Integer
        Get
            Return _adPoint
        End Get
        Set(ByVal Value As Integer)
            _adPoint = Value
        End Set
    End Property
    Public Property IsCup As Integer
        Get
            Return _isCup
        End Get
        Set(ByVal Value As Integer)
            _isCup = Value
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
Public Class CMS_TreEmInfo

#Region "Private Members"
    Private _iD As Integer
    Private _treEmiD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _logo As String = String.Empty
    Private _tenBe As String = String.Empty
    Private _tenONha As String = String.Empty
    Private _trangThai As Integer
    Private _ngaySinh As DateTime
    Private _ngayDuSinh As DateTime
    Private _gioiTinh As Integer
    Private _ghiChu As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property soKB As Integer
    Public Property chieuCao As String
    Public Property canNang As String
    Public Property groupID As Integer
    Public Property tuoi As Integer
    Public Property tuan As Integer
    Public Property thangTuoi As Integer
    Public Property tuanTuoi As Integer
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime
    Public Property TreEmiD As Integer
        Get
            Return _treEmiD
        End Get
        Set(ByVal Value As Integer)
            _treEmiD = Value
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property TenBe As String
        Get
            Return _tenBe
        End Get
        Set(ByVal Value As String)
            _tenBe = Value
        End Set
    End Property
    Public Property TenONha As String
        Get
            Return _tenONha
        End Get
        Set(ByVal Value As String)
            _tenONha = Value
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
    Public Property NgaySinh As DateTime
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As DateTime)
            _ngaySinh = Value
        End Set
    End Property
    Public Property NgayDuSinh As DateTime
        Get
            Return _ngayDuSinh
        End Get
        Set(ByVal Value As DateTime)
            _ngayDuSinh = Value
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
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_Fr_PostGroupInfo

#Region "Private Members"
    Private _postGroup_ID As Integer
    Private _post_ID As Integer
    Private _groupID As Integer
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property groupName As String
    Public Property groupLogo As String
    Public Property PostGroup_ID As Integer
        Get
            Return _postGroup_ID
        End Get
        Set(ByVal Value As Integer)
            _postGroup_ID = Value
        End Set
    End Property
    Public Property Post_ID As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property GroupID As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
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
Public Class CMS_TiemChungInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _treEm_ID As Integer
    Private _vacXin_ID As Integer
    Private _muiTiem As Integer
    Private _ngayTiem As DateTime
    Private _trangThai As Integer
    Private _total As Integer
    Private _appID As String
    Private _loGo As String
#End Region

#Region "Public Properties"
    Public Property Logo As String
        Get
            Return _logo
        End Get
        Set(ByVal Value As String)
            _logo = Value
        End Set
    End Property
    Public Property tiemPhong As String
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property TreEm_ID As Integer
        Get
            Return _treEm_ID
        End Get
        Set(ByVal Value As Integer)
            _treEm_ID = Value
        End Set
    End Property
    Public Property VacXin_ID As Integer
        Get
            Return _vacXin_ID
        End Get
        Set(ByVal Value As Integer)
            _vacXin_ID = Value
        End Set
    End Property
    Public Property MuiTiem As Integer
        Get
            Return _muiTiem
        End Get
        Set(ByVal Value As Integer)
            _muiTiem = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property NgayTiem As DateTime
        Get
            Return _ngayTiem
        End Get
        Set(ByVal Value As DateTime)
            _ngayTiem = Value
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
#End Region

End Class
Public Class CMS_MocRangInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _tEID As Integer
    Private _ngayMoc As DateTime
    Private _rangSo As Integer
    Private _trangThai As Integer
    Private _hinhAnh As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property TEID As Integer
        Get
            Return _tEID
        End Get
        Set(ByVal Value As Integer)
            _tEID = Value
        End Set
    End Property
    Public Property NgayMoc As DateTime
        Get
            Return _ngayMoc
        End Get
        Set(ByVal Value As DateTime)
            _ngayMoc = Value
        End Set
    End Property
    Public Property RangSo As Integer
        Get
            Return _rangSo
        End Get
        Set(ByVal Value As Integer)
            _rangSo = Value
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
    Public Property HinhAnh As String
        Get
            Return _hinhAnh
        End Get
        Set(ByVal Value As String)
            _hinhAnh = Value
        End Set
    End Property
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
Public Class CMS_KhamThaiInfo

#Region "Private Members"
    Private _iD As Integer
    Private _thaiTuan As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property tinhTrang As Integer
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property ThaiTuan As String
        Get
            Return _thaiTuan
        End Get
        Set(ByVal Value As String)
            _thaiTuan = Value
        End Set
    End Property
    Public Property NoiDung As String
        Get
            Return _noiDung
        End Get
        Set(ByVal Value As String)
            _noiDung = Value
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
Public Class CMS_KhamThaiDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _treEm_ID As Integer
    Private _khamThai_ID As Integer
    Private _ngayKham As DateTime
    Private _trangThai As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ThaiTuan As String
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property TreEm_ID As Integer
        Get
            Return _treEm_ID
        End Get
        Set(ByVal Value As Integer)
            _treEm_ID = Value
        End Set
    End Property
    Public Property KhamThai_ID As Integer
        Get
            Return _khamThai_ID
        End Get
        Set(ByVal Value As Integer)
            _khamThai_ID = Value
        End Set
    End Property
    Public Property NgayKham As DateTime
        Get
            Return _ngayKham
        End Get
        Set(ByVal Value As DateTime)
            _ngayKham = Value
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
Public Class CMS_AnhBeInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _treEm_ID As Integer
    Private _ngayDang As DateTime
    Private _ghiChu As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property TreEm_ID As Integer
        Get
            Return _treEm_ID
        End Get
        Set(ByVal Value As Integer)
            _treEm_ID = Value
        End Set
    End Property
    Public Property NgayDang As DateTime
        Get
            Return _ngayDang
        End Get
        Set(ByVal Value As DateTime)
            _ngayDang = Value
        End Set
    End Property
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
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
Public Class CMS_AnhBeDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _aID As Integer
    Private _hinhAnh As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property AID As Integer
        Get
            Return _aID
        End Get
        Set(ByVal Value As Integer)
            _aID = Value
        End Set
    End Property
    Public Property hinhAnh As String
        Get
            Return _hinhAnh
        End Get
        Set(ByVal Value As String)
            _hinhAnh = Value
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
Public Class CMS_TheoDoiTEInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _thangTuan As Integer
    Private _isType As Integer
    Private _tEID As Integer
    Private _chieuCao As Double
    Private _canNang As Double
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
        End Set
    End Property
    Public Property ThangTuan As Integer
        Get
            Return _thangTuan
        End Get
        Set(ByVal Value As Integer)
            _thangTuan = Value
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
    Public Property PortalID As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property TEID As Integer
        Get
            Return _tEID
        End Get
        Set(ByVal Value As Integer)
            _tEID = Value
        End Set
    End Property
    Public Property ChieuCao As Double
        Get
            Return _chieuCao
        End Get
        Set(ByVal Value As Double)
            _chieuCao = Value
        End Set
    End Property
    Public Property CanNang As Double
        Get
            Return _canNang
        End Get
        Set(ByVal Value As Double)
            _canNang = Value
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
Public Class CMS_CuDapInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _tEID As Integer
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property LanDem As Integer
    Public Property CuDap As Integer
    Public Property dap1 As Integer
    Public Property dap2 As Integer
    Public Property dap3 As Integer
    Public Property mCD As Integer
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property TEID As Integer
        Get
            Return _tEID
        End Get
        Set(ByVal Value As Integer)
            _tEID = Value
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
Public Class CMS_CuDapDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _cuDap_ID As Integer
    Private _gioDem As String = String.Empty
    Private _phutDem As String = String.Empty
    Private _total As Integer
    Private _lanDem As Integer
    Private _Loai As Integer
#End Region

#Region "Public Properties"
    Public Property LanDem As Integer
        Get
            Return _lanDem
        End Get
        Set(ByVal Value As Integer)
            _lanDem = Value
        End Set
    End Property
    Public Property Loai As Integer
        Get
            Return _Loai
        End Get
        Set(ByVal Value As Integer)
            _Loai = Value
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
    Public Property CuDap_ID As Integer
        Get
            Return _cuDap_ID
        End Get
        Set(ByVal Value As Integer)
            _cuDap_ID = Value
        End Set
    End Property
    Public Property GioDem As String
        Get
            Return _gioDem
        End Get
        Set(ByVal Value As String)
            _gioDem = Value
        End Set
    End Property
    Public Property PhutDem As String
        Get
            Return _phutDem
        End Get
        Set(ByVal Value As String)
            _phutDem = Value
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
Public Class CMS_SurveyRInfo

#Region "Private Members"
    Private _reply_ID As Integer
    Private _survey_ID As Integer
    Private _titles As String = String.Empty
    Private _isOrder As Integer
    Private _isActive As Boolean
    Private _isReply As Integer
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

    Public Property Reply_ID As Integer
        Get
            Return _reply_ID
        End Get
        Set(ByVal Value As Integer)
            _reply_ID = Value
        End Set
    End Property

    Public Property Survey_ID As Integer
        Get
            Return _survey_ID
        End Get
        Set(ByVal Value As Integer)
            _survey_ID = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
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
    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property IsReply As Integer
        Get
            Return _isReply
        End Get
        Set(ByVal Value As Integer)
            _isReply = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_SurveyInfo

#Region "Private Members"
    Private _survey_ID As Integer
    Private _titles As String = String.Empty
    Private _contents As String = String.Empty
    Private _loGo As String = String.Empty
    Private _isType As Integer
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _portalID As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property TotalVote As Integer
    Public Property appReply As String
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property Survey_ID As Integer
        Get
            Return _survey_ID
        End Get
        Set(ByVal Value As Integer)
            _survey_ID = Value
        End Set
    End Property

    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
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
    Public Property LoGo As String
        Get
            Return _loGo
        End Get
        Set(ByVal Value As String)
            _loGo = Value
        End Set
    End Property
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
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
    Public Property PortalID As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
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
#End Region

End Class
Public Class CMS_SurveyUInfo

#Region "Private Members"
    Private _iD As Integer
    Private _survey_ID As Integer
    Private _appID As String = String.Empty
    Private _portalID As Integer
    Private _replyID As String = String.Empty
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property Survey_ID As Integer
        Get
            Return _survey_ID
        End Get
        Set(ByVal Value As Integer)
            _survey_ID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property ReplyID As String
        Get
            Return _replyID
        End Get
        Set(ByVal Value As String)
            _replyID = Value
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
Public Class CMS_KhamBenhInfo

#Region "Private Members"
    Private _iD As Integer
    Private _soKB_ID As Integer
    Private _ngayKham As DateTime
    Private _trieuChung As String = String.Empty
    Private _chuanDoan As String = String.Empty
    Private _donThuoc As String = String.Empty
    Private _chiPhi As Double
    Private _ghiChu As String = String.Empty
    Private _createDate As DateTime
    Private _updateDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property SoKB_ID As Integer
        Get
            Return _soKB_ID
        End Get
        Set(ByVal Value As Integer)
            _soKB_ID = Value
        End Set
    End Property
    Public Property NgayKham As DateTime
        Get
            Return _ngayKham
        End Get
        Set(ByVal Value As DateTime)
            _ngayKham = Value
        End Set
    End Property
    Public Property TrieuChung As String
        Get
            Return _trieuChung
        End Get
        Set(ByVal Value As String)
            _trieuChung = Value
        End Set
    End Property
    Public Property ChuanDoan As String
        Get
            Return _chuanDoan
        End Get
        Set(ByVal Value As String)
            _chuanDoan = Value
        End Set
    End Property
    Public Property DonThuoc As String
        Get
            Return _donThuoc
        End Get
        Set(ByVal Value As String)
            _donThuoc = Value
        End Set
    End Property
    Public Property ChiPhi As Double
        Get
            Return _chiPhi
        End Get
        Set(ByVal Value As Double)
            _chiPhi = Value
        End Set
    End Property
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
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
Public Class CMS_SoKBInfo

#Region "Private Members"
    Private _tEID As Integer
    Private _iD As Integer
    Private _appID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _hinhAnh As String = String.Empty
    Private _tienSu As String = String.Empty
    Private _manCam As String = String.Empty
    Private _createDate As DateTime
    Private _updateDate As DateTime
    Private _portalID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property TEID As Integer
        Get
            Return _tEID
        End Get
        Set(ByVal Value As Integer)
            _tEID = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property HinhAnh As String
        Get
            Return _hinhAnh
        End Get
        Set(ByVal Value As String)
            _hinhAnh = Value
        End Set
    End Property
    Public Property TienSu As String
        Get
            Return _tienSu
        End Get
        Set(ByVal Value As String)
            _tienSu = Value
        End Set
    End Property
    Public Property ManCam As String
        Get
            Return _manCam
        End Get
        Set(ByVal Value As String)
            _manCam = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
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
Public Class CMS_ProductInfo

#Region "Private Members"
    Private _iD As Integer
    Private _nhomSP As Integer
    Private _brand_ID As Integer
    Private _maSP As String = String.Empty
    Private _CongDung As String = String.Empty
    Private _tenSP As String = String.Empty
    Private _anhDaiDien As String = String.Empty
    Private _giaBan As Double
    Private _giaKM As Double
    Private _sales As Double
    Private _dVT As String = String.Empty
    Private _vAT As Double
    Private _tichDiem As Double
    Private _thuocTinh As String = String.Empty
    Private _moTa As String = String.Empty
    Private _isShop As Integer
    Private _isView As Integer
    Private _isComment As Integer
    Private _isShare As Integer
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _lockedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property rAVG As Double
    Public Property rMyApp As Integer
    Public Property rTotal As Integer
    Public Property cTotal As Integer
    Public Property r5 As Integer
    Public Property r4 As Integer
    Public Property r3 As Integer
    Public Property r2 As Integer
    Public Property r1 As Integer
    Public Property CongDung As String
        Get
            Return _CongDung
        End Get
        Set(ByVal Value As String)
            _CongDung = Value
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
    Public Property NhomSP As Integer
        Get
            Return _nhomSP
        End Get
        Set(ByVal Value As Integer)
            _nhomSP = Value
        End Set
    End Property
    Public Property Brand_ID As Integer
        Get
            Return _brand_ID
        End Get
        Set(ByVal Value As Integer)
            _brand_ID = Value
        End Set
    End Property
    Public Property MaSP As String
        Get
            Return _maSP
        End Get
        Set(ByVal Value As String)
            _maSP = Value
        End Set
    End Property
    Public Property TenSP As String
        Get
            Return _tenSP
        End Get
        Set(ByVal Value As String)
            _tenSP = Value
        End Set
    End Property
    Public Property AnhDaiDien As String
        Get
            Return _anhDaiDien
        End Get
        Set(ByVal Value As String)
            _anhDaiDien = Value
        End Set
    End Property
    Public Property GiaBan As Double
        Get
            Return _giaBan
        End Get
        Set(ByVal Value As Double)
            _giaBan = Value
        End Set
    End Property
    Public Property GiaKM As Double
        Get
            Return _giaKM
        End Get
        Set(ByVal Value As Double)
            _giaKM = Value
        End Set
    End Property
    Public Property Sales As Double
        Get
            Return _sales
        End Get
        Set(ByVal Value As Double)
            _sales = Value
        End Set
    End Property
    Public Property DVT As String
        Get
            Return _dVT
        End Get
        Set(ByVal Value As String)
            _dVT = Value
        End Set
    End Property
    Public Property TichDiem As Double
        Get
            Return _tichDiem
        End Get
        Set(ByVal Value As Double)
            _tichDiem = Value
        End Set
    End Property
    Public Property VAT As Double
        Get
            Return _vAT
        End Get
        Set(ByVal Value As Double)
            _vAT = Value
        End Set
    End Property
    Public Property ThuocTinh As String
        Get
            Return _thuocTinh
        End Get
        Set(ByVal Value As String)
            _thuocTinh = Value
        End Set
    End Property
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property IsShop As Integer
        Get
            Return _isShop
        End Get
        Set(ByVal Value As Integer)
            _isShop = Value
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
    Public Property IsComment As Integer
        Get
            Return _isComment
        End Get
        Set(ByVal Value As Integer)
            _isComment = Value
        End Set
    End Property
    Public Property IsShare As Integer
        Get
            Return _isShare
        End Get
        Set(ByVal Value As Integer)
            _isShare = Value
        End Set
    End Property
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property DeletedDate As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
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
    Public Property PortalID As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_ProductBrandInfo

#Region "Private Members"
    Private _iD As Integer
    Private _thuongHieu As String = String.Empty
    Private _xuatXu As String = String.Empty
    Private _anhDaiDien As String = String.Empty
    Private _moTa As String = String.Empty
    Private _QuiUoc As String = String.Empty
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property QuiUoc As String
        Get
            Return _QuiUoc
        End Get
        Set(ByVal Value As String)
            _QuiUoc = Value
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
    Public Property ThuongHieu As String
        Get
            Return _thuongHieu
        End Get
        Set(ByVal Value As String)
            _thuongHieu = Value
        End Set
    End Property
    Public Property XuatXu As String
        Get
            Return _xuatXu
        End Get
        Set(ByVal Value As String)
            _xuatXu = Value
        End Set
    End Property
    Public Property AnhDaiDien As String
        Get
            Return _anhDaiDien
        End Get
        Set(ByVal Value As String)
            _anhDaiDien = Value
        End Set
    End Property
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_ProductGroupInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenNhom As String = String.Empty
    Private _anhDaiDien As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _parentID As Integer
    Private _portalID As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property TenNhom As String
        Get
            Return _tenNhom
        End Get
        Set(ByVal Value As String)
            _tenNhom = Value
        End Set
    End Property
    Public Property AnhDaiDien As String
        Get
            Return _anhDaiDien
        End Get
        Set(ByVal Value As String)
            _anhDaiDien = Value
        End Set
    End Property
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
        End Set
    End Property
    Public Property ParentID As Integer
        Get
            Return _parentID
        End Get
        Set(ByVal Value As Integer)
            _parentID = Value
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
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_ProductImgInfo

#Region "Private Members"
    Private _iD As Integer
    Private _productID As Integer
    Private _paths As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property ProductID As Integer
        Get
            Return _productID
        End Get
        Set(ByVal Value As Integer)
            _productID = Value
        End Set
    End Property
    Public Property Paths As String
        Get
            Return _paths
        End Get
        Set(ByVal Value As String)
            _paths = Value
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
Public Class CMS_ProductRateInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _appID As String = String.Empty
    Private _productID As Integer
    Private _isRate As Decimal
    Private _createdUser As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property ProductID As Integer
        Get
            Return _productID
        End Get
        Set(ByVal Value As Integer)
            _productID = Value
        End Set
    End Property
    Public Property IsRate As Decimal
        Get
            Return _isRate
        End Get
        Set(ByVal Value As Decimal)
            _isRate = Value
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
    Public Property CreatedDate As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
Public Class CMS_ProductCommentInfo

#Region "Private Members"
    Private _iD As Integer
    Private _productID As Integer
    Private _appID As String = String.Empty
    Private _logo As String = String.Empty
    Private _contents As String = String.Empty
    Private _reply As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _lockedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property ProductID As Integer
        Get
            Return _productID
        End Get
        Set(ByVal Value As Integer)
            _productID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property Contents As String
        Get
            Return _contents
        End Get
        Set(ByVal Value As String)
            _contents = Value
        End Set
    End Property
    Public Property Reply As String
        Get
            Return _reply
        End Get
        Set(ByVal Value As String)
            _reply = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
        End Set
    End Property
    Public Property IsLock As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property DeletedDate As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
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
Public Class CMS_ShopByInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maDonHang As String = String.Empty
    Private _appID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _mobile As String = String.Empty
    Private _telephone As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _ghiChu As String = String.Empty
    Private _tongTien As Double
    Private _tongVAT As Double
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _portalID As Integer
    Private _ghTinhTrang As Integer
    Private _ghDonViVC As Integer
    Private _ghNgayGiao As DateTime
    Private _ghNguoiGiao As String = String.Empty
    Private _ghMaVC As String = String.Empty
    Private _ghCuocVC As Double
    Private _ghCOD As Boolean
    Private _ghTienThuHo As Double
    Private _ghGhiChu As String = String.Empty
    Private _lyDoHuyDon As String = String.Empty
    Private _nguoiHuyDon As String = String.Empty
    Private _ngayHuyDon As DateTime
    Private _voucherID As Integer
    Private _voucherPrice As Double
    Private _upPoint As Integer
    Private _AddPoint As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property TenDonVi As String
    Public Property AddPoint As Integer
        Get
            Return _AddPoint
        End Get
        Set(ByVal Value As Integer)
            _AddPoint = Value
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
    Public Property MaDonHang As String
        Get
            Return _maDonHang
        End Get
        Set(ByVal Value As String)
            _maDonHang = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property Mobile As String
        Get
            Return _mobile
        End Get
        Set(ByVal Value As String)
            _mobile = Value
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
    Public Property DiaChi As String
        Get
            Return _diaChi
        End Get
        Set(ByVal Value As String)
            _diaChi = Value
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
    Public Property QuanHuyen As Integer
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As Integer)
            _quanHuyen = Value
        End Set
    End Property
    Public Property GhiChu As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
        End Set
    End Property
    Public Property TongTien As Double
        Get
            Return _tongTien
        End Get
        Set(ByVal Value As Double)
            _tongTien = Value
        End Set
    End Property
    Public Property TongVAT As Double
        Get
            Return _tongVAT
        End Get
        Set(ByVal Value As Double)
            _tongVAT = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
    Public Property GhTinhTrang As Integer
        Get
            Return _ghTinhTrang
        End Get
        Set(ByVal Value As Integer)
            _ghTinhTrang = Value
        End Set
    End Property
    Public Property GhDonViVC As Integer
        Get
            Return _ghDonViVC
        End Get
        Set(ByVal Value As Integer)
            _ghDonViVC = Value
        End Set
    End Property
    Public Property GhNgayGiao As DateTime
        Get
            Return _ghNgayGiao
        End Get
        Set(ByVal Value As DateTime)
            _ghNgayGiao = Value
        End Set
    End Property
    Public Property GhNguoiGiao As String
        Get
            Return _ghNguoiGiao
        End Get
        Set(ByVal Value As String)
            _ghNguoiGiao = Value
        End Set
    End Property
    Public Property GhMaVC As String
        Get
            Return _ghMaVC
        End Get
        Set(ByVal Value As String)
            _ghMaVC = Value
        End Set
    End Property
    Public Property GhCuocVC As Double
        Get
            Return _ghCuocVC
        End Get
        Set(ByVal Value As Double)
            _ghCuocVC = Value
        End Set
    End Property
    Public Property GhCOD As Boolean
        Get
            Return _ghCOD
        End Get
        Set(ByVal Value As Boolean)
            _ghCOD = Value
        End Set
    End Property
    Public Property GhTienThuHo As Double
        Get
            Return _ghTienThuHo
        End Get
        Set(ByVal Value As Double)
            _ghTienThuHo = Value
        End Set
    End Property
    Public Property GhGhiChu As String
        Get
            Return _ghGhiChu
        End Get
        Set(ByVal Value As String)
            _ghGhiChu = Value
        End Set
    End Property
    Public Property LyDoHuyDon As String
        Get
            Return _lyDoHuyDon
        End Get
        Set(ByVal Value As String)
            _lyDoHuyDon = Value
        End Set
    End Property
    Public Property NguoiHuyDon As String
        Get
            Return _nguoiHuyDon
        End Get
        Set(ByVal Value As String)
            _nguoiHuyDon = Value
        End Set
    End Property
    Public Property NgayHuyDon As DateTime
        Get
            Return _ngayHuyDon
        End Get
        Set(ByVal Value As DateTime)
            _ngayHuyDon = Value
        End Set
    End Property
    Public Property VoucherID As Integer
        Get
            Return _voucherID
        End Get
        Set(ByVal Value As Integer)
            _voucherID = Value
        End Set
    End Property
    Public Property VoucherPrice As Double
        Get
            Return _voucherPrice
        End Get
        Set(ByVal Value As Double)
            _voucherPrice = Value
        End Set
    End Property
    Public Property UpPoint As Integer
        Get
            Return _upPoint
        End Get
        Set(ByVal Value As Integer)
            _upPoint = Value
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
Public Class CMS_ShopProInfo

#Region "Private Members"
    Private _iD As Integer
    Private _shopBy_ID As Integer
    Private _product_ID As Integer
    Private _donGia As Double
    Private _soLuong As Double
    Private _vAT As Double
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property maSP As String = ""
    Public Property tenSP As String = ""
    Public Property anhDaiDien As String = ""
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property ShopBy_ID As Integer
        Get
            Return _shopBy_ID
        End Get
        Set(ByVal Value As Integer)
            _shopBy_ID = Value
        End Set
    End Property
    Public Property Product_ID As Integer
        Get
            Return _product_ID
        End Get
        Set(ByVal Value As Integer)
            _product_ID = Value
        End Set
    End Property
    Public Property DonGia As Double
        Get
            Return _donGia
        End Get
        Set(ByVal Value As Double)
            _donGia = Value
        End Set
    End Property
    Public Property SoLuong As Double
        Get
            Return _soLuong
        End Get
        Set(ByVal Value As Double)
            _soLuong = Value
        End Set
    End Property
    Public Property VAT As Double
        Get
            Return _vAT
        End Get
        Set(ByVal Value As Double)
            _vAT = Value
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
Public Class CMS_ImageNInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portailID As Integer
    Private _cateID As Integer
    Private _titles As String = String.Empty
    Private _des As String = String.Empty
    Private _logo As String = String.Empty
    Private _isActive As Boolean
    Private _isOder As Integer
    Private _createDated As DateTime
    Private _createUser As String = String.Empty
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property PortailID As Integer
        Get
            Return _portailID
        End Get
        Set(ByVal Value As Integer)
            _portailID = Value
        End Set
    End Property
    Public Property CateID As Integer
        Get
            Return _cateID
        End Get
        Set(ByVal Value As Integer)
            _cateID = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property Des As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
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
    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property
    Public Property IsOder As Integer
        Get
            Return _isOder
        End Get
        Set(ByVal Value As Integer)
            _isOder = Value
        End Set
    End Property
    Public Property CreateDated As DateTime
        Get
            Return _createDated
        End Get
        Set(ByVal Value As DateTime)
            _createDated = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ImageDInfo

#Region "Private Members"
    Private _iD As String
    Private _portalID As Integer
    Private _img_ID As Integer
    Private _fileAttach As String = String.Empty
    Private _des As String = String.Empty
    Private _url As String = String.Empty
    Private _fileType As Integer
    Private _isOrder As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property titles As String
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property ID As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
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
    Public Property Img_ID As Integer
        Get
            Return _img_ID
        End Get
        Set(ByVal Value As Integer)
            _img_ID = Value
        End Set
    End Property
    Public Property FileAttach As String
        Get
            Return _fileAttach
        End Get
        Set(ByVal Value As String)
            _fileAttach = Value
        End Set
    End Property
    Public Property Des As String
        Get
            Return _des
        End Get
        Set(ByVal Value As String)
            _des = Value
        End Set
    End Property
    Public Property Url As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property
    Public Property FileType As Integer
        Get
            Return _fileType
        End Get
        Set(ByVal Value As Integer)
            _fileType = Value
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
Public Class CMS_ChuyenGiaInfo

#Region "Private Members"
    Private _id As Integer

    Private _loGo As String = String.Empty
    Private _ten As String = String.Empty
    Private _chucDanh As String = String.Empty
    Private _chucVu As String = String.Empty
    Private _gioiThieu As String = String.Empty
    Private _quaTrinhCongTac As String = String.Empty
    Private _thuTu As Integer
    Private _portalId As Integer
    Private _createDate As DateTime
    Private _createUser As String = String.Empty
    Private _updateDate As DateTime
    Private _updateUser As String = String.Empty
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

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property Ten As String
        Get
            Return _ten
        End Get
        Set(ByVal Value As String)
            _ten = Value
        End Set
    End Property
    Public Property LoGo As String
        Get
            Return _loGo
        End Get
        Set(ByVal Value As String)
            _loGo = Value
        End Set
    End Property
    Public Property ChucDanh As String
        Get
            Return _chucDanh
        End Get
        Set(ByVal Value As String)
            _chucDanh = Value
        End Set
    End Property
    Public Property ChucVu As String
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As String)
            _chucVu = Value
        End Set
    End Property
    Public Property GioiThieu As String
        Get
            Return _gioiThieu
        End Get
        Set(ByVal Value As String)
            _gioiThieu = Value
        End Set
    End Property
    Public Property QuaTrinhCongTac As String
        Get
            Return _quaTrinhCongTac
        End Get
        Set(ByVal Value As String)
            _quaTrinhCongTac = Value
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
    Public Property PortalId As Integer
        Get
            Return _portalId
        End Get
        Set(ByVal Value As Integer)
            _portalId = Value
        End Set
    End Property
    Public Property CreateDate As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
        End Set
    End Property
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
        End Set
    End Property
    Public Property UpdateDate As DateTime
        Get
            Return _updateDate
        End Get
        Set(ByVal Value As DateTime)
            _updateDate = Value
        End Set
    End Property
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_VanChuyenInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenDonVi As String = String.Empty
    Private _moTa As String = String.Empty
    Private _ngayTao As DateTime
    Private _nguoiTao As String = String.Empty
    Private _ngayThayDoi As DateTime
    Private _nguoiThayDoi As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property TenDonVi As String
        Get
            Return _tenDonVi
        End Get
        Set(ByVal Value As String)
            _tenDonVi = Value
        End Set
    End Property
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property NgayTao As DateTime
        Get
            Return _ngayTao
        End Get
        Set(ByVal Value As DateTime)
            _ngayTao = Value
        End Set
    End Property
    Public Property NguoiTao As String
        Get
            Return _nguoiTao
        End Get
        Set(ByVal Value As String)
            _nguoiTao = Value
        End Set
    End Property
    Public Property NgayThayDoi As DateTime
        Get
            Return _ngayThayDoi
        End Get
        Set(ByVal Value As DateTime)
            _ngayThayDoi = Value
        End Set
    End Property
    Public Property NguoiThayDoi As String
        Get
            Return _nguoiThayDoi
        End Get
        Set(ByVal Value As String)
            _nguoiThayDoi = Value
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
Public Class CMS_VoucherInfo

#Region "Private Members"
    Private _iD As Integer
    Private _brandID As Integer
    Private _anhDaiDien As String = String.Empty
    Private _moTa As String = String.Empty
    Private _diemDoi As Double
    Private _dieuKien As Double
    Private _mucGiam As Double
    Private _soLuong As Integer
    Private _daPhat As Integer
    Private _tuNgay As DateTime
    Private _denNgay As DateTime
    Private _portalID As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property BrandID As Integer
        Get
            Return _brandID
        End Get
        Set(ByVal Value As Integer)
            _brandID = Value
        End Set
    End Property
    Public Property AnhDaiDien As String
        Get
            Return _anhDaiDien
        End Get
        Set(ByVal Value As String)
            _anhDaiDien = Value
        End Set
    End Property
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property DiemDoi As Double
        Get
            Return _diemDoi
        End Get
        Set(ByVal Value As Double)
            _diemDoi = Value
        End Set
    End Property
    Public Property DieuKien As Double
        Get
            Return _dieuKien
        End Get
        Set(ByVal Value As Double)
            _dieuKien = Value
        End Set
    End Property
    Public Property MucGiam As Double
        Get
            Return _mucGiam
        End Get
        Set(ByVal Value As Double)
            _mucGiam = Value
        End Set
    End Property
    Public Property SoLuong As Integer
        Get
            Return _soLuong
        End Get
        Set(ByVal Value As Integer)
            _soLuong = Value
        End Set
    End Property
    Public Property DaPhat As Integer
        Get
            Return _daPhat
        End Get
        Set(ByVal Value As Integer)
            _daPhat = Value
        End Set
    End Property
    Public Property TuNgay As DateTime
        Get
            Return _tuNgay
        End Get
        Set(ByVal Value As DateTime)
            _tuNgay = Value
        End Set
    End Property
    Public Property DenNgay As DateTime
        Get
            Return _denNgay
        End Get
        Set(ByVal Value As DateTime)
            _denNgay = Value
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
Public Class CMS_VoucherAppInfo

#Region "Private Members"
    Private _iD As Integer
    Private _portalID As Integer
    Private _voucherID As Integer
    Private _appID As String = String.Empty
    Private _suDung As Boolean
    Private _isSend As Boolean
    Private _fromApp As String = String.Empty
    Private _fromDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _ngayDung As DateTime
    Private _donHang As Integer
#End Region

#Region "Public Properties"
    Public Property IsPoint As Double
    Public Property UsPoint As Double
    Public Property IsLevel As Integer
    Public Property brandID As Integer
    Public Property DienThoai As String
    Public Property Avatar As String
    Public Property NgayDangKy As DateTime
    Public Property HoVaTen As String
    Public Property anhDaiDien As String = ""
    Public Property diemDoi As Double
    Public Property dieuKien As Double
    Public Property mucGiam As Double
    Public Property tuNgay As DateTime
    Public Property denNgay As DateTime
    Public Property NgayDung As DateTime
        Get
            Return _ngayDung
        End Get
        Set(ByVal Value As DateTime)
            _ngayDung = Value
        End Set
    End Property
    Public Property DonHang As Integer
        Get
            Return _donHang
        End Get
        Set(ByVal Value As Integer)
            _donHang = Value
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
    Public Property PortalID As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
        End Set
    End Property
    Public Property VoucherID As Integer
        Get
            Return _voucherID
        End Get
        Set(ByVal Value As Integer)
            _voucherID = Value
        End Set
    End Property
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property SuDung As Boolean
        Get
            Return _suDung
        End Get
        Set(ByVal Value As Boolean)
            _suDung = Value
        End Set
    End Property
    Public Property IsSend As Boolean
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Boolean)
            _isSend = Value
        End Set
    End Property
    Public Property FromApp As String
        Get
            Return _fromApp
        End Get
        Set(ByVal Value As String)
            _fromApp = Value
        End Set
    End Property
    Public Property FromDate As DateTime
        Get
            Return _fromDate
        End Get
        Set(ByVal Value As DateTime)
            _fromDate = Value
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
Public Class CMS_NewsVoteInfo

#Region "Private Members"
    Private _newsV_ID As Integer
    Private _newsID As Integer
    Private _votes As Integer
    Private _iP As String = String.Empty
    Private _total As Integer
    Private _voteDate As DateTime
#End Region

#Region "Public Properties"

    Public Property VoteDate As DateTime
        Get
            Return _voteDate
        End Get
        Set(ByVal Value As DateTime)
            _voteDate = Value
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

    Public Property NewsV_ID() As Integer
        Get
            Return _newsV_ID
        End Get
        Set(ByVal Value As Integer)
            _newsV_ID = Value
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
    Public Property Votes() As Integer
        Get
            Return _votes
        End Get
        Set(ByVal Value As Integer)
            _votes = Value
        End Set
    End Property
    Public Property IP() As String
        Get
            Return _iP
        End Get
        Set(ByVal Value As String)
            _iP = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_MetaSEOInfo

#Region "Private Members"
    Private _iD As Integer
    Private _iDKey As String = String.Empty
    Private _titles As String = String.Empty
    Private _metaDes As String = String.Empty
    Private _metaKeyWord As String = String.Empty
    Private _isIndex As Boolean
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
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property IDKey As String
        Get
            Return _iDKey
        End Get
        Set(ByVal Value As String)
            _iDKey = Value
        End Set
    End Property
    Public Property Titles As String
        Get
            Return _titles
        End Get
        Set(ByVal Value As String)
            _titles = Value
        End Set
    End Property
    Public Property MetaDes As String
        Get
            Return _metaDes
        End Get
        Set(ByVal Value As String)
            _metaDes = Value
        End Set
    End Property
    Public Property MetaKeyWord As String
        Get
            Return _metaKeyWord
        End Get
        Set(ByVal Value As String)
            _metaKeyWord = Value
        End Set
    End Property
    Public Property IsIndex As Boolean
        Get
            Return _isIndex
        End Get
        Set(ByVal Value As Boolean)
            _isIndex = Value
        End Set
    End Property
#End Region

End Class
