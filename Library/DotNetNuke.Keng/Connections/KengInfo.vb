Public Class CMS_EmployeeInfo

#Region "Private Members"
    Private _chucDanh As String = String.Empty
    Private _employee_ID As String = String.Empty
    Private _employeeCode As String = String.Empty
    Private _appID As String = String.Empty
    Private _appLogo As String = String.Empty
    Private _employeeName As String = String.Empty
    Private _status As Boolean
    Private _isManager As Boolean
    Private _businessID As Integer
    Private _departmentCode As String = String.Empty
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _yearID As Integer
    Private _monthID As Integer
    Private _GroupID As Integer
#End Region

#Region "Public Properties"
    Public Property IsNew As Integer
    Public Property ID As Integer
    Public Property IsGroup As Integer
    Public Property IsUsers As Integer
    Public Property ChatDate As DateTime
    Public Property GroupID As Integer
        Get
            Return _GroupID
        End Get
        Set(ByVal Value As Integer)
            _GroupID = Value
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
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property AppLogo As String
        Get
            Return _appLogo
        End Get
        Set(ByVal Value As String)
            _appLogo = Value
        End Set
    End Property
    Public Property DepartmentCode As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
        End Set
    End Property

    Public Property IsManager As Boolean
        Get
            Return _isManager
        End Get
        Set(ByVal Value As Boolean)
            _isManager = Value
        End Set
    End Property

    Public Property YearID As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
        End Set
    End Property
    Public Property MonthID As Integer
        Get
            Return _monthID
        End Get
        Set(ByVal Value As Integer)
            _monthID = Value
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

    Public Property Employee_ID() As String
        Get
            Return _employee_ID
        End Get
        Set(ByVal Value As String)
            _employee_ID = Value
        End Set
    End Property

    Public Property EmployeeCode() As String
        Get
            Return _employeeCode
        End Get
        Set(ByVal Value As String)
            _employeeCode = Value
        End Set
    End Property
    Public Property EmployeeName() As String
        Get
            Return _employeeName
        End Get
        Set(ByVal Value As String)
            _employeeName = Value
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
    Public Property BusinessID() As Integer
        Get
            Return _businessID
        End Get
        Set(ByVal Value As Integer)
            _businessID = Value
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
Public Class CMS_TypeZoomInfo

    Public Property iD As Integer
    Public Property name As String = String.Empty
    Public Property isActive As Boolean

End Class
Public Class CMS_UtilityInfo
    Public Property iD As Integer
    Public Property name As String = String.Empty
    Public Property isActive As Boolean

End Class
Public Class CMS_LeaveOfAbsInfo

#Region "Private Members"
    Private _leaveOfAbs_ID As String = String.Empty
    Private _businessID As Integer
    Private _businessName As String = String.Empty
    Private _NotiName As String = String.Empty
    Private _employeeCode As String = String.Empty
    Private _employeeName As String = String.Empty
    Private _departmentCode As String = String.Empty
    Private _appID As String = String.Empty
    Private _appLogo As String = String.Empty
    Private _fromDate As DateTime
    Private _toDate As DateTime
    Private _reason As String = String.Empty
    Private _comments As String = String.Empty
    Private _receiveName As String = String.Empty
    Private _receiveDep As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _isActive As Integer
    Private _activeUser As String = String.Empty
    'Private _unActiveDate As DateTime
    'Private _acCancelDate As DateTime
    Private _activeDate As DateTime
    'Private _cancelDate As DateTime
    'Private _cancelSendDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property ReCount As Integer
    Public Property UnActive As Integer
    Public Property ReasonUnActive As String
    Public Property UnActiveDate As DateTime
    Public Property ReasonCancel As String
    Public Property CancelDate As DateTime
    Public Property ReasonUnCancel As String
    Public Property UnCancelDate As DateTime
    Public Property AcCancelDate As DateTime
    Public Property CancelSendReason As String
    Public Property CancelSendDate As DateTime

    Public Property ReceiveDep As String
        Get
            Return _receiveDep
        End Get
        Set(ByVal Value As String)
            _receiveDep = Value
        End Set
    End Property
    Public Property NotiName As String
        Get
            Return _NotiName
        End Get
        Set(ByVal Value As String)
            _NotiName = Value
        End Set
    End Property
    Public Property AppLogo As String
        Get
            Return _appLogo
        End Get
        Set(ByVal Value As String)
            _appLogo = Value
        End Set
    End Property
    Public Property LeaveOfAbs_ID As String
        Get
            Return _leaveOfAbs_ID
        End Get
        Set(ByVal Value As String)
            _leaveOfAbs_ID = Value
        End Set
    End Property
    Public Property BusinessID As Integer
        Get
            Return _businessID
        End Get
        Set(ByVal Value As Integer)
            _businessID = Value
        End Set
    End Property
    Public Property BusinessName As String
        Get
            Return _businessName
        End Get
        Set(ByVal Value As String)
            _businessName = Value
        End Set
    End Property
    Public Property EmployeeCode As String
        Get
            Return _employeeCode
        End Get
        Set(ByVal Value As String)
            _employeeCode = Value
        End Set
    End Property
    Public Property EmployeeName As String
        Get
            Return _employeeName
        End Get
        Set(ByVal Value As String)
            _employeeName = Value
        End Set
    End Property
    Public Property DepartmentCode As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
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
    Public Property FromDate As DateTime
        Get
            Return _fromDate
        End Get
        Set(ByVal Value As DateTime)
            _fromDate = Value
        End Set
    End Property
    Public Property ToDate As DateTime
        Get
            Return _toDate
        End Get
        Set(ByVal Value As DateTime)
            _toDate = Value
        End Set
    End Property
    Public Property Reason As String
        Get
            Return _reason
        End Get
        Set(ByVal Value As String)
            _reason = Value
        End Set
    End Property
    Public Property Comments As String
        Get
            Return _comments
        End Get
        Set(ByVal Value As String)
            _comments = Value
        End Set
    End Property
    Public Property ReceiveName As String
        Get
            Return _receiveName
        End Get
        Set(ByVal Value As String)
            _receiveName = Value
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
    'Public Property CancelDate As DateTime
    '    Get
    '        Return _cancelDate
    '    End Get
    '    Set(ByVal Value As DateTime)
    '        _cancelDate = Value
    '    End Set
    'End Property
    'Public Property UnActiveDate As DateTime
    '    Get
    '        Return _unActiveDate
    '    End Get
    '    Set(ByVal Value As DateTime)
    '        _unActiveDate = Value
    '    End Set
    'End Property
    'Public Property AcCancelDate As DateTime
    '    Get
    '        Return _acCancelDate
    '    End Get
    '    Set(ByVal Value As DateTime)
    '        _acCancelDate = Value
    '    End Set
    'End Property
    'Public Property CancelSendDate As DateTime
    '    Get
    '        Return _cancelSendDate
    '    End Get
    '    Set(ByVal Value As DateTime)
    '        _cancelSendDate = Value
    '    End Set
    'End Property
    Public Property IsActive As Integer
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Integer)
            _isActive = Value
        End Set
    End Property
    Public Property ActiveUser As String
        Get
            Return _activeUser
        End Get
        Set(ByVal Value As String)
            _activeUser = Value
        End Set
    End Property
    Public Property ActiveDate As DateTime
        Get
            Return _activeDate
        End Get
        Set(ByVal Value As DateTime)
            _activeDate = Value
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
Public Class CMS_CommentInfo

#Region "Private Members"
    Private _comment_ID As Integer
    Private _post_ID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
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

    Public Property Comment_ID() As Integer
        Get
            Return _comment_ID
        End Get
        Set(ByVal Value As Integer)
            _comment_ID = Value
        End Set
    End Property

    Public Property Post_ID() As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property AppID() As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
Public Class CMS_LikesInfo

#Region "Private Members"
    Private _likesID As Integer
    Private _appID As String = String.Empty
    Private _postID As Integer
    Private _createdDate As DateTime
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

    Public Property LikesID() As Integer
        Get
            Return _likesID
        End Get
        Set(ByVal Value As Integer)
            _likesID = Value
        End Set
    End Property

    Public Property AppID() As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property PostID() As Integer
        Get
            Return _postID
        End Get
        Set(ByVal Value As Integer)
            _postID = Value
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
#End Region

End Class
Public Class CMS_PostInfo

#Region "Private Members"
    Private _post_ID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _publicAll As Boolean
    Private _onlyMe As Boolean
    Private _friends As Boolean
    Private _isLock As Boolean
    Private _lockedUser As String = String.Empty
    Private _lockedDate As DateTime
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _total As Integer
    Private _isLike As Integer
    Private _isComment As Integer
    Private _isShare As Integer
    Private _PostShareID As Integer
#End Region

#Region "Public Properties"
    Public Property PostShareID As Integer
        Get
            Return _PostShareID
        End Get
        Set(ByVal Value As Integer)
            _PostShareID = Value
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
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property Post_ID() As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property

    Public Property AppID() As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
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
    Public Property PublicAll() As Boolean
        Get
            Return _publicAll
        End Get
        Set(ByVal Value As Boolean)
            _publicAll = Value
        End Set
    End Property
    Public Property OnlyMe() As Boolean
        Get
            Return _onlyMe
        End Get
        Set(ByVal Value As Boolean)
            _onlyMe = Value
        End Set
    End Property
    Public Property Friends() As Boolean
        Get
            Return _friends
        End Get
        Set(ByVal Value As Boolean)
            _friends = Value
        End Set
    End Property
    Public Property IsLock() As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
        End Set
    End Property
    Public Property LockedUser() As String
        Get
            Return _lockedUser
        End Get
        Set(ByVal Value As String)
            _lockedUser = Value
        End Set
    End Property
    Public Property LockedDate() As DateTime
        Get
            Return _lockedDate
        End Get
        Set(ByVal Value As DateTime)
            _lockedDate = Value
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
    Public Property DeletedDate() As DateTime
        Get
            Return _deletedDate
        End Get
        Set(ByVal Value As DateTime)
            _deletedDate = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_SharePostInfo

#Region "Private Members"
    Private _sharePost_ID As Integer
    Private _post_ID As Integer
    Private _shareAppID As String = String.Empty
    Private _createdDate As DateTime
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
    Public Property CreatedDate() As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
        End Set
    End Property

    Public Property SharePost_ID() As Integer
        Get
            Return _sharePost_ID
        End Get
        Set(ByVal Value As Integer)
            _sharePost_ID = Value
        End Set
    End Property

    Public Property Post_ID() As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property ShareAppID() As String
        Get
            Return _shareAppID
        End Get
        Set(ByVal Value As String)
            _shareAppID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ShareUserInfo

#Region "Private Members"
    Private _shareUser_ID As Integer
    Private _post_ID As Integer
    Private _shareAppID As String = String.Empty
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

    Public Property ShareUser_ID() As Integer
        Get
            Return _shareUser_ID
        End Get
        Set(ByVal Value As Integer)
            _shareUser_ID = Value
        End Set
    End Property

    Public Property Post_ID() As Integer
        Get
            Return _post_ID
        End Get
        Set(ByVal Value As Integer)
            _post_ID = Value
        End Set
    End Property
    Public Property ShareAppID() As String
        Get
            Return _shareAppID
        End Get
        Set(ByVal Value As String)
            _shareAppID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FileAttachInfo

#Region "Private Members"
    Private _attach_ID As String = String.Empty
    Private _idKey As String = String.Empty
    Private _fileAttach As String = String.Empty
    Private _fileType As Integer
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

    Public Property Attach_ID() As String
        Get
            Return _attach_ID
        End Get
        Set(ByVal Value As String)
            _attach_ID = Value
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
    Public Property FileAttach() As String
        Get
            Return _fileAttach
        End Get
        Set(ByVal Value As String)
            _fileAttach = Value
        End Set
    End Property
    Public Property FileType() As Integer
        Get
            Return _fileType
        End Get
        Set(ByVal Value As Integer)
            _fileType = Value
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
Public Class CMS_RelationShipInfo

#Region "Private Members"
    Private _relationShip_ID As Integer
    Private _appID_One As String = String.Empty
    Private _appID_Two As String = String.Empty
    Private _status As Integer
    Private _action_AppID As String = String.Empty
    Private _total As Integer
    Private _createdDate As DateTime
#End Region

#Region "Public Properties"

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
    Public Property RelationShip_ID() As Integer
        Get
            Return _relationShip_ID
        End Get
        Set(ByVal Value As Integer)
            _relationShip_ID = Value
        End Set
    End Property
    Public Property AppID_One() As String
        Get
            Return _appID_One
        End Get
        Set(ByVal Value As String)
            _appID_One = Value
        End Set
    End Property
    Public Property AppID_Two() As String
        Get
            Return _appID_Two
        End Get
        Set(ByVal Value As String)
            _appID_Two = Value
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
    Public Property Action_AppID() As String
        Get
            Return _action_AppID
        End Get
        Set(ByVal Value As String)
            _action_AppID = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ChatInfo

#Region "Private Members"
    Private _chat_ID As Integer
    Private _fromAppID As String = String.Empty
    Private _toAppID As String = String.Empty
    Private _contents As String = String.Empty
    Private _isStatus As Integer
    Private _createdDate As DateTime
    Private _total As Integer
    Private _isFile As String
    Private _GroupID As Integer
#End Region

#Region "Public Properties"
    Public Property IsFile As String
        Get
            Return _isFile
        End Get
        Set(ByVal Value As String)
            _isFile = Value
        End Set
    End Property
    Public Property GroupID As Integer
        Get
            Return _GroupID
        End Get
        Set(ByVal Value As Integer)
            _GroupID = Value
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

    Public Property Chat_ID() As Integer
        Get
            Return _chat_ID
        End Get
        Set(ByVal Value As Integer)
            _chat_ID = Value
        End Set
    End Property

    Public Property FromAppID() As String
        Get
            Return _fromAppID
        End Get
        Set(ByVal Value As String)
            _fromAppID = Value
        End Set
    End Property
    Public Property ToAppID() As String
        Get
            Return _toAppID
        End Get
        Set(ByVal Value As String)
            _toAppID = Value
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
    Public Property IsStatus() As Integer
        Get
            Return _isStatus
        End Get
        Set(ByVal Value As Integer)
            _isStatus = Value
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
#End Region

End Class
Public Class CMS_DepartmentInfo

#Region "Private Members"
    Private _departmentID As Integer
    Private _departmentCode As String = String.Empty
    Private _business_ID As Integer
    Private _departmentName As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
    Private _Parent_ID As Integer
#End Region

#Region "Public Properties"

    Public Property Parent_ID As Integer
        Get
            Return _Parent_ID
        End Get
        Set(ByVal Value As Integer)
            _Parent_ID = Value
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

    Public Property DepartmentID() As Integer
        Get
            Return _departmentID
        End Get
        Set(ByVal Value As Integer)
            _departmentID = Value
        End Set
    End Property

    Public Property DepartmentCode() As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
        End Set
    End Property
    Public Property Business_ID() As Integer
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As Integer)
            _business_ID = Value
        End Set
    End Property
    Public Property DepartmentName() As String
        Get
            Return _departmentName
        End Get
        Set(ByVal Value As String)
            _departmentName = Value
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
Public Class CMS_UserHeartInfo

#Region "Private Members"
    Private _iD As Integer
    Private _appID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Boolean
    Private _moiQT As Boolean
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _duongPho As String = String.Empty
    Private _gioiThieu As String = String.Empty
    Private _thuNhap As Integer
    Private _ngheNghiep As String = String.Empty
    Private _congTy As String = String.Empty
    Private _chieuCao As Integer
    Private _dangVoc As Integer
    Private _tonGiao As Integer
    Private _mauToc As Integer
    Private _mauMat As Integer
    Private _nhomMau As Integer
    Private _cacMoiQH As Integer
    Private _conCai As Integer
    Private _hutThuoc As Integer
    Private _uongRB As Integer
    Private _cheDoAn As String = String.Empty
    Private _hocVan As Integer
    Private _tinhCach As String = String.Empty
    Private _phongCachTT As String = String.Empty
    Private _soThich As String = String.Empty
    Private _tuVi As String = String.Empty
    Private _anhDaiDien As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _viTri As String = String.Empty
    Private _isOnline As Boolean
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property lastComment As String

    Public Property ThuNhap As Integer
        Get
            Return _thuNhap
        End Get
        Set(ByVal Value As Integer)
            _thuNhap = Value
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
    Public Property GioiTinh As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Boolean)
            _gioiTinh = Value
        End Set
    End Property
    Public Property MoiQT As Boolean
        Get
            Return _moiQT
        End Get
        Set(ByVal Value As Boolean)
            _moiQT = Value
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
    Public Property GioiThieu As String
        Get
            Return _gioiThieu
        End Get
        Set(ByVal Value As String)
            _gioiThieu = Value
        End Set
    End Property
    Public Property NgheNghiep As String
        Get
            Return _ngheNghiep
        End Get
        Set(ByVal Value As String)
            _ngheNghiep = Value
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
    Public Property ChieuCao As Integer
        Get
            Return _chieuCao
        End Get
        Set(ByVal Value As Integer)
            _chieuCao = Value
        End Set
    End Property
    Public Property DangVoc As Integer
        Get
            Return _dangVoc
        End Get
        Set(ByVal Value As Integer)
            _dangVoc = Value
        End Set
    End Property
    Public Property TonGiao As Integer
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As Integer)
            _tonGiao = Value
        End Set
    End Property
    Public Property MauToc As Integer
        Get
            Return _mauToc
        End Get
        Set(ByVal Value As Integer)
            _mauToc = Value
        End Set
    End Property
    Public Property MauMat As Integer
        Get
            Return _mauMat
        End Get
        Set(ByVal Value As Integer)
            _mauMat = Value
        End Set
    End Property
    Public Property NhomMau As Integer
        Get
            Return _nhomMau
        End Get
        Set(ByVal Value As Integer)
            _nhomMau = Value
        End Set
    End Property
    Public Property CacMoiQH As Integer
        Get
            Return _cacMoiQH
        End Get
        Set(ByVal Value As Integer)
            _cacMoiQH = Value
        End Set
    End Property
    Public Property ConCai As Integer
        Get
            Return _conCai
        End Get
        Set(ByVal Value As Integer)
            _conCai = Value
        End Set
    End Property
    Public Property HutThuoc As Integer
        Get
            Return _hutThuoc
        End Get
        Set(ByVal Value As Integer)
            _hutThuoc = Value
        End Set
    End Property
    Public Property UongRB As Integer
        Get
            Return _uongRB
        End Get
        Set(ByVal Value As Integer)
            _uongRB = Value
        End Set
    End Property
    Public Property CheDoAn As String
        Get
            Return _cheDoAn
        End Get
        Set(ByVal Value As String)
            _cheDoAn = Value
        End Set
    End Property
    Public Property HocVan As Integer
        Get
            Return _hocVan
        End Get
        Set(ByVal Value As Integer)
            _hocVan = Value
        End Set
    End Property
    Public Property TinhCach As String
        Get
            Return _tinhCach
        End Get
        Set(ByVal Value As String)
            _tinhCach = Value
        End Set
    End Property
    Public Property PhongCachTT As String
        Get
            Return _phongCachTT
        End Get
        Set(ByVal Value As String)
            _phongCachTT = Value
        End Set
    End Property
    Public Property SoThich As String
        Get
            Return _soThich
        End Get
        Set(ByVal Value As String)
            _soThich = Value
        End Set
    End Property
    Public Property TuVi As String
        Get
            Return _tuVi
        End Get
        Set(ByVal Value As String)
            _tuVi = Value
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
    Public Property ViTri As String
        Get
            Return _viTri
        End Get
        Set(ByVal Value As String)
            _viTri = Value
        End Set
    End Property
    Public Property IsOnline As Boolean
        Get
            Return _isOnline
        End Get
        Set(ByVal Value As Boolean)
            _isOnline = Value
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
Public Class CMS_CateDetailInfo

#Region "Private Members"
    Private _cateDetail_ID As Integer
    Private _cateGroup_ID As Integer
    Private _cateDetail_Name As String = String.Empty
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

    Public Property CateDetail_ID() As Integer
        Get
            Return _cateDetail_ID
        End Get
        Set(ByVal Value As Integer)
            _cateDetail_ID = Value
        End Set
    End Property

    Public Property CateGroup_ID() As Integer
        Get
            Return _cateGroup_ID
        End Get
        Set(ByVal Value As Integer)
            _cateGroup_ID = Value
        End Set
    End Property
    Public Property CateDetail_Name() As String
        Get
            Return _cateDetail_Name
        End Get
        Set(ByVal Value As String)
            _cateDetail_Name = Value
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
Public Class CMS_QuestionInfo

#Region "Private Members"
    Private _question_ID As String = String.Empty
    Private _appID As String = String.Empty
    Private _businessID As Integer
    Private _businessName As String = String.Empty
    Private _departmentCode As String = String.Empty
    Private _employeeCode As String = String.Empty
    Private _years As String = String.Empty
    Private _months As String = String.Empty
    Private _contents As String = String.Empty
    Private _frequent As Boolean
    Private _status As Integer
    Private _isType As Integer
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property EmployeeName As String
    Public Property AppLogo As String
    Public Property An_Contents As String
    Public Property AnDate As DateTime
    Public Property Answer As String
    Public Property Question_ID As String
        Get
            Return _question_ID
        End Get
        Set(ByVal Value As String)
            _question_ID = Value
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
    Public Property BusinessID As Integer
        Get
            Return _businessID
        End Get
        Set(ByVal Value As Integer)
            _businessID = Value
        End Set
    End Property
    Public Property BusinessName As String
        Get
            Return _businessName
        End Get
        Set(ByVal Value As String)
            _businessName = Value
        End Set
    End Property
    Public Property DepartmentCode As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
        End Set
    End Property
    Public Property EmployeeCode As String
        Get
            Return _employeeCode
        End Get
        Set(ByVal Value As String)
            _employeeCode = Value
        End Set
    End Property
    Public Property Years As String
        Get
            Return _years
        End Get
        Set(ByVal Value As String)
            _years = Value
        End Set
    End Property
    Public Property Months As String
        Get
            Return _months
        End Get
        Set(ByVal Value As String)
            _months = Value
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
    Public Property Frequent As Boolean
        Get
            Return _frequent
        End Get
        Set(ByVal Value As Boolean)
            _frequent = Value
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
    Public Property IsType As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
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
Public Class CMS_NotifyInfo

#Region "Private Members"
    Private _iD As Integer
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
Public Class CMS_AnswerInfo

#Region "Private Members"
    Private _answer_ID As String = String.Empty
    Private _question_ID As String = String.Empty
    Private _contents As String = String.Empty
    Private _hoVaTen As String = String.Empty
    Private _status As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property HoVaTen As String
        Get
            Return _hoVaTen
        End Get
        Set(ByVal Value As String)
            _hoVaTen = Value
        End Set
    End Property
    Public Property Answer_ID As String
        Get
            Return _answer_ID
        End Get
        Set(ByVal Value As String)
            _answer_ID = Value
        End Set
    End Property
    Public Property Question_ID As String
        Get
            Return _question_ID
        End Get
        Set(ByVal Value As String)
            _question_ID = Value
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
    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
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
Public Class CMS_RoomInfo

#Region "Private Members"
    Private _roomID As Integer
    Private _appID As String = String.Empty
    Private _tieuDe As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _loaiPhong As Integer
    Private _soPhong As Integer
    Private _sucChua As Integer
    Private _gioiTinh As Integer
    Private _dienTich As Double
    Private _giaPhong As String = String.Empty
    Private _datCoc As String = String.Empty
    Private _tienDien As String = String.Empty
    Private _tienNuoc As String = String.Empty
    Private _tienMang As String = String.Empty
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _duongPho As String = String.Empty
    Private _dienThoaiLH As String = String.Empty
    Private _gioMoCua As String = String.Empty
    Private _gioDongCua As String = String.Empty
    Private _isStatus As Integer
    Private _createUser As String = String.Empty
    Private _createDate As DateTime
    Private _updateUser As String = String.Empty
    Private _updateDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property RoomID As Integer
        Get
            Return _roomID
        End Get
        Set(ByVal Value As Integer)
            _roomID = Value
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
    Public Property TieuDe As String
        Get
            Return _tieuDe
        End Get
        Set(ByVal Value As String)
            _tieuDe = Value
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
    Public Property LoaiPhong As Integer
        Get
            Return _loaiPhong
        End Get
        Set(ByVal Value As Integer)
            _loaiPhong = Value
        End Set
    End Property
    Public Property SoPhong As Integer
        Get
            Return _soPhong
        End Get
        Set(ByVal Value As Integer)
            _soPhong = Value
        End Set
    End Property
    Public Property SucChua As Integer
        Get
            Return _sucChua
        End Get
        Set(ByVal Value As Integer)
            _sucChua = Value
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
    Public Property DienTich As Double
        Get
            Return _dienTich
        End Get
        Set(ByVal Value As Double)
            _dienTich = Value
        End Set
    End Property
    Public Property GiaPhong As String
        Get
            Return _giaPhong
        End Get
        Set(ByVal Value As String)
            _giaPhong = Value
        End Set
    End Property
    Public Property DatCoc As String
        Get
            Return _datCoc
        End Get
        Set(ByVal Value As String)
            _datCoc = Value
        End Set
    End Property
    Public Property TienDien As String
        Get
            Return _tienDien
        End Get
        Set(ByVal Value As String)
            _tienDien = Value
        End Set
    End Property
    Public Property TienNuoc As String
        Get
            Return _tienNuoc
        End Get
        Set(ByVal Value As String)
            _tienNuoc = Value
        End Set
    End Property
    Public Property TienMang As String
        Get
            Return _tienMang
        End Get
        Set(ByVal Value As String)
            _tienMang = Value
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
    Public Property DienThoaiLH As String
        Get
            Return _dienThoaiLH
        End Get
        Set(ByVal Value As String)
            _dienThoaiLH = Value
        End Set
    End Property
    Public Property GioMoCua As String
        Get
            Return _gioMoCua
        End Get
        Set(ByVal Value As String)
            _gioMoCua = Value
        End Set
    End Property
    Public Property GioDongCua As String
        Get
            Return _gioDongCua
        End Get
        Set(ByVal Value As String)
            _gioDongCua = Value
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
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
    Public Property UpdateUser As String
        Get
            Return _updateUser
        End Get
        Set(ByVal Value As String)
            _updateUser = Value
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
Public Class CMS_RoomCInfo

#Region "Private Members"
    Private _iD As Integer
    Private _roomID As Integer
    Private _appID As String = String.Empty
    Private _contents As String = String.Empty
    Private _createdDate As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Reply As String
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property RoomID As Integer
        Get
            Return _roomID
        End Get
        Set(ByVal Value As Integer)
            _roomID = Value
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
Public Class CMS_RoomFInfo

#Region "Private Members"
    Private _attach_ID As String = String.Empty
    Private _roomID As Integer
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
    Public Property RoomID As Integer
        Get
            Return _roomID
        End Get
        Set(ByVal Value As Integer)
            _roomID = Value
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
Public Class CMS_RoomUInfo

#Region "Private Members"
    Private _iD As Integer
    Private _roomID As Integer
    Private _utilityID As Integer
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
    Public Property RoomID As Integer
        Get
            Return _roomID
        End Get
        Set(ByVal Value As Integer)
            _roomID = Value
        End Set
    End Property
    Public Property UtilityID As Integer
        Get
            Return _utilityID
        End Get
        Set(ByVal Value As Integer)
            _utilityID = Value
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
Public Class CMS_Fr_CommentInfo

#Region "Private Members"
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
    Public Property Reply As String
        Get
            Return _reply
        End Get
        Set(ByVal Value As String)
            _reply = Value
        End Set
    End Property
    Public Property Comment_ID As Integer
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
    Private _uID As Integer
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
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
    Private _uID As Integer
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
    Private _GroupID As Integer
#End Region

#Region "Public Properties"
    Public Property BaiDang As Integer
    Public Property BaiKhoa As Integer
    Public Property BrithDay As String
    Public Property imgTop As String
    Public Property groupLogo As String
    Public Property groupName As String
    Public Property GroupID As Integer
        Get
            Return _GroupID
        End Get
        Set(ByVal Value As Integer)
            _GroupID = Value
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
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
Public Class CMS_DashInfo
    Public Property TotalDs1 As Double
    Public Property TotalDs2 As Double
    Public Property TotalDs3 As Double
    Public Property TotalDs4 As Double
    Public Property TotalDs5 As Double
    Public Property TotalDs6 As Double
    Public Property TotalDs7 As Double
    Public Property TotalDs8 As Double
    Public Property TotalDs9 As Double
    Public Property TotalDs10 As Double
    Public Property TotalDs11 As Double
    Public Property TotalDs12 As Double
    Public Property TotalDd1 As Double
    Public Property TotalDd2 As Double
    Public Property TotalDd3 As Double
    Public Property TotalDd4 As Double
    Public Property TotalDd5 As Double
    Public Property TotalDd6 As Double
    Public Property TotalDd7 As Double
    Public Property TotalDd8 As Double
    Public Property TotalDd9 As Double
    Public Property TotalDd10 As Double
    Public Property TotalDd11 As Double
    Public Property TotalDd12 As Double
End Class
Public Class CMS_CalenderInfo

#Region "Private Members"
    Private _iD As Integer
    Private _busID As Integer
    Private _calName As String = String.Empty
    Private _years As Integer
    Private _calender As String = String.Empty
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property BusID As Integer
        Get
            Return _busID
        End Get
        Set(ByVal Value As Integer)
            _busID = Value
        End Set
    End Property
    Public Property CalName As String
        Get
            Return _calName
        End Get
        Set(ByVal Value As String)
            _calName = Value
        End Set
    End Property
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
        End Set
    End Property
    Public Property Calender As String
        Get
            Return _calender
        End Get
        Set(ByVal Value As String)
            _calender = Value
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
Public Class CMS_SalaryInfo

#Region "Private Members"
    Private _salary_ID As String = String.Empty
    Private _yearID As Integer
    Private _monthID As Integer
    Private _employeeCode As String = String.Empty
    Private _departmentCode As String = String.Empty
    Private _businessID As Integer
    Private _chucDanh As String = String.Empty
    Private _luongThang As Double
    Private _gioLamThem As Double
    Private _troCapDem As Double
    Private _phuCap As Double
    Private _dCTang As Double
    Private _dCGiam As Double
    Private _dMVS As Double
    Private _baoHiem As Double
    Private _phiCongDoan As Double
    Private _thuePIT As Double
    Private _thucLinh As Double
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isSent As Boolean
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AppID As String
    Public Property IsLock As Boolean
    Public Property Salary_ID As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property
    Public Property YearID As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
        End Set
    End Property
    Public Property MonthID As Integer
        Get
            Return _monthID
        End Get
        Set(ByVal Value As Integer)
            _monthID = Value
        End Set
    End Property
    Public Property EmployeeCode As String
        Get
            Return _employeeCode
        End Get
        Set(ByVal Value As String)
            _employeeCode = Value
        End Set
    End Property
    Public Property DepartmentCode As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
        End Set
    End Property
    Public Property BusinessID As Integer
        Get
            Return _businessID
        End Get
        Set(ByVal Value As Integer)
            _businessID = Value
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
    Public Property LuongThang As Double
        Get
            Return _luongThang
        End Get
        Set(ByVal Value As Double)
            _luongThang = Value
        End Set
    End Property
    Public Property GioLamThem As Double
        Get
            Return _gioLamThem
        End Get
        Set(ByVal Value As Double)
            _gioLamThem = Value
        End Set
    End Property
    Public Property TroCapDem As Double
        Get
            Return _troCapDem
        End Get
        Set(ByVal Value As Double)
            _troCapDem = Value
        End Set
    End Property
    Public Property PhuCap As Double
        Get
            Return _phuCap
        End Get
        Set(ByVal Value As Double)
            _phuCap = Value
        End Set
    End Property
    Public Property DCTang As Double
        Get
            Return _dCTang
        End Get
        Set(ByVal Value As Double)
            _dCTang = Value
        End Set
    End Property
    Public Property DCGiam As Double
        Get
            Return _dCGiam
        End Get
        Set(ByVal Value As Double)
            _dCGiam = Value
        End Set
    End Property
    Public Property DMVS As Double
        Get
            Return _dMVS
        End Get
        Set(ByVal Value As Double)
            _dMVS = Value
        End Set
    End Property
    Public Property BaoHiem As Double
        Get
            Return _baoHiem
        End Get
        Set(ByVal Value As Double)
            _baoHiem = Value
        End Set
    End Property
    Public Property PhiCongDoan As Double
        Get
            Return _phiCongDoan
        End Get
        Set(ByVal Value As Double)
            _phiCongDoan = Value
        End Set
    End Property
    Public Property ThuePIT As Double
        Get
            Return _thuePIT
        End Get
        Set(ByVal Value As Double)
            _thuePIT = Value
        End Set
    End Property
    Public Property ThucLinh As Double
        Get
            Return _thucLinh
        End Get
        Set(ByVal Value As Double)
            _thucLinh = Value
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
    Public Property IsSent As Boolean
        Get
            Return _isSent
        End Get
        Set(ByVal Value As Boolean)
            _isSent = Value
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
Public Class CMS_TimeKeepInfo

#Region "Private Members"
    Private _timeKeep_ID As String = String.Empty
    Private _yearID As Integer
    Private _monthID As Integer
    Private _employeeCode As String = String.Empty
    Private _employeeName As String = String.Empty
    Private _departmentCode As String = String.Empty
    Private _businessID As Integer
    Private _nCTT As Double
    Private _phepP As Double
    Private _dacBietSP As Double
    Private _kLRo As Double
    Private _oTNgay As Double
    Private _oTDem As Double
    Private _gioCaDem As Double
    Private _vMRS As Double
    Private _NghiLe As Double
    Private _SoACN As Double
    Private _SoACD As Double
    Private _NgayPhepCL As Double
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isSent As Boolean
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property IsLock As Boolean
    Public Property AppID As String
    Public Property TimeKeep_ID As String
        Get
            Return _timeKeep_ID
        End Get
        Set(ByVal Value As String)
            _timeKeep_ID = Value
        End Set
    End Property
    Public Property YearID As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
        End Set
    End Property
    Public Property MonthID As Integer
        Get
            Return _monthID
        End Get
        Set(ByVal Value As Integer)
            _monthID = Value
        End Set
    End Property
    Public Property EmployeeCode As String
        Get
            Return _employeeCode
        End Get
        Set(ByVal Value As String)
            _employeeCode = Value
        End Set
    End Property
    Public Property EmployeeName As String
        Get
            Return _employeeName
        End Get
        Set(ByVal Value As String)
            _employeeName = Value
        End Set
    End Property
    Public Property DepartmentCode As String
        Get
            Return _departmentCode
        End Get
        Set(ByVal Value As String)
            _departmentCode = Value
        End Set
    End Property
    Public Property BusinessID As Integer
        Get
            Return _businessID
        End Get
        Set(ByVal Value As Integer)
            _businessID = Value
        End Set
    End Property
    Public Property NCTT As Double
        Get
            Return _nCTT
        End Get
        Set(ByVal Value As Double)
            _nCTT = Value
        End Set
    End Property
    Public Property PhepP As Double
        Get
            Return _phepP
        End Get
        Set(ByVal Value As Double)
            _phepP = Value
        End Set
    End Property
    Public Property DacBietSP As Double
        Get
            Return _dacBietSP
        End Get
        Set(ByVal Value As Double)
            _dacBietSP = Value
        End Set
    End Property
    Public Property KLRo As Double
        Get
            Return _kLRo
        End Get
        Set(ByVal Value As Double)
            _kLRo = Value
        End Set
    End Property
    Public Property OTNgay As Double
        Get
            Return _oTNgay
        End Get
        Set(ByVal Value As Double)
            _oTNgay = Value
        End Set
    End Property
    Public Property OTDem As Double
        Get
            Return _oTDem
        End Get
        Set(ByVal Value As Double)
            _oTDem = Value
        End Set
    End Property
    Public Property GioCaDem As Double
        Get
            Return _gioCaDem
        End Get
        Set(ByVal Value As Double)
            _gioCaDem = Value
        End Set
    End Property
    Public Property VMRS As Double
        Get
            Return _vMRS
        End Get
        Set(ByVal Value As Double)
            _vMRS = Value
        End Set
    End Property
    Public Property NghiLe As Double
        Get
            Return _NghiLe
        End Get
        Set(ByVal Value As Double)
            _NghiLe = Value
        End Set
    End Property
    Public Property SoACN As Double
        Get
            Return _SoACN
        End Get
        Set(ByVal Value As Double)
            _SoACN = Value
        End Set
    End Property
    Public Property SoACD As Double
        Get
            Return _SoACD
        End Get
        Set(ByVal Value As Double)
            _SoACD = Value
        End Set
    End Property
    Public Property NgayPhepCL As Double
        Get
            Return _NgayPhepCL
        End Get
        Set(ByVal Value As Double)
            _NgayPhepCL = Value
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
    Public Property IsSent As Boolean
        Get
            Return _isSent
        End Get
        Set(ByVal Value As Boolean)
            _isSent = Value
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
Public Class CMS_DisputeInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
    Private _eID As String = String.Empty
    Private _dID As String = String.Empty
    Private _fromApp As String = String.Empty
    Private _toApp As String = String.Empty
    Private _setActive As Integer
    Private _setUserName As String = String.Empty
    Private _setDatetime As DateTime
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AppLogo As String
    Public Property EmployeeName As String
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
    Public Property DID As String
        Get
            Return _dID
        End Get
        Set(ByVal Value As String)
            _dID = Value
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
    Public Property SetActive As Integer
        Get
            Return _setActive
        End Get
        Set(ByVal Value As Integer)
            _setActive = Value
        End Set
    End Property
    Public Property SetUserName As String
        Get
            Return _setUserName
        End Get
        Set(ByVal Value As String)
            _setUserName = Value
        End Set
    End Property
    Public Property SetDatetime As DateTime
        Get
            Return _setDatetime
        End Get
        Set(ByVal Value As DateTime)
            _setDatetime = Value
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
Public Class CMS_LyDoInfo
    Public Property iD As String
    Public Property lyDo As String
End Class
Public Class CMS_MeetingInfo

#Region "Private Members"
    Private _meeting_ID As Integer
    Private _uID As Integer
    Private _appID As String = String.Empty
    Private _dID As String = String.Empty
    Private _eID As String = String.Empty
    Private _mR_ID As String = String.Empty
    Private _meetingName As String = String.Empty
    Private _LeaderName As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property AppID As String
        Get
            Return _appID
        End Get
        Set(ByVal Value As String)
            _appID = Value
        End Set
    End Property
    Public Property LeaderName As String
        Get
            Return _LeaderName
        End Get
        Set(ByVal Value As String)
            _LeaderName = Value
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

    Public Property Meeting_ID() As Integer
        Get
            Return _meeting_ID
        End Get
        Set(ByVal Value As Integer)
            _meeting_ID = Value
        End Set
    End Property

    Public Property UID() As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property DID() As String
        Get
            Return _dID
        End Get
        Set(ByVal Value As String)
            _dID = Value
        End Set
    End Property
    Public Property EID() As String
        Get
            Return _eID
        End Get
        Set(ByVal Value As String)
            _eID = Value
        End Set
    End Property
    Public Property MR_ID() As String
        Get
            Return _mR_ID
        End Get
        Set(ByVal Value As String)
            _mR_ID = Value
        End Set
    End Property
    Public Property MeetingName() As String
        Get
            Return _meetingName
        End Get
        Set(ByVal Value As String)
            _meetingName = Value
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
Public Class CMS_MeetingRoomInfo

#Region "Private Members"
    Private _mR_ID As Integer
    Private _uID As Integer
    Private _mR_Address As String = String.Empty
    Private _mR_Code As String = String.Empty
    Private _mR_Des As String = String.Empty
    Private _mR_Name As String = String.Empty
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

    Public Property MR_ID() As Integer
        Get
            Return _mR_ID
        End Get
        Set(ByVal Value As Integer)
            _mR_ID = Value
        End Set
    End Property

    Public Property UID() As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property MR_Code() As String
        Get
            Return _mR_Code
        End Get
        Set(ByVal Value As String)
            _mR_Code = Value
        End Set
    End Property
    Public Property MR_Address As String
        Get
            Return _mR_Address
        End Get
        Set(ByVal Value As String)
            _mR_Address = Value
        End Set
    End Property
    Public Property MR_Des As String
        Get
            Return _mR_Des
        End Get
        Set(ByVal Value As String)
            _mR_Des = Value
        End Set
    End Property
    Public Property MR_Name() As String
        Get
            Return _mR_Name
        End Get
        Set(ByVal Value As String)
            _mR_Name = Value
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
Public Class CMS_MissionInfo

#Region "Private Members"
    Private _mission_ID As Integer
    Private _uID As Integer
    Private _dID As String = String.Empty
    Private _AppID As String = String.Empty
    Private _driverName As String = String.Empty
    Private _driverPhone As String = String.Empty
    Private _driverNumber As String = String.Empty
    Private _eID As String = String.Empty
    Private _toEID As String = String.Empty
    Private _toDID As String = String.Empty
    Private _mission_Purpose As String = String.Empty
    Private _mission_Departure As String = String.Empty
    Private _mission_Arrival As String = String.Empty
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _isTimeKeep As Boolean
    Private _reCar As Integer
    Private _manageID As String = String.Empty
    Private _manageDep As String = String.Empty
    Private _manageActive As Boolean
    Private _manageAcDate As DateTime
    Private _isApproval As Boolean
    Private _approvalDate As DateTime
    Private _approvalUser As String = String.Empty
    Private _carID As Integer
    Private _firstKm As Double
    Private _firstDate As DateTime
    Private _firstUser As String = String.Empty
    Private _lastKm As Double
    Private _lastDate As DateTime
    Private _lastUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property UnActive As Integer
    Public Property IsDeleted As Integer
    Public Property MaCount As Integer
    Public Property AppID As String
        Get
            Return _AppID
        End Get
        Set(ByVal Value As String)
            _AppID = Value
        End Set
    End Property
    Public Property Mission_ID As Integer
        Get
            Return _mission_ID
        End Get
        Set(ByVal Value As Integer)
            _mission_ID = Value
        End Set
    End Property
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property DID As String
        Get
            Return _dID
        End Get
        Set(ByVal Value As String)
            _dID = Value
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
    Public Property ToEID As String
        Get
            Return _toEID
        End Get
        Set(ByVal Value As String)
            _toEID = Value
        End Set
    End Property
    Public Property ToDID As String
        Get
            Return _toDID
        End Get
        Set(ByVal Value As String)
            _toDID = Value
        End Set
    End Property
    Public Property Mission_Purpose As String
        Get
            Return _mission_Purpose
        End Get
        Set(ByVal Value As String)
            _mission_Purpose = Value
        End Set
    End Property
    Public Property Mission_Departure As String
        Get
            Return _mission_Departure
        End Get
        Set(ByVal Value As String)
            _mission_Departure = Value
        End Set
    End Property
    Public Property Mission_Arrival As String
        Get
            Return _mission_Arrival
        End Get
        Set(ByVal Value As String)
            _mission_Arrival = Value
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
    Public Property IsTimeKeep As Boolean
        Get
            Return _isTimeKeep
        End Get
        Set(ByVal Value As Boolean)
            _isTimeKeep = Value
        End Set
    End Property
    Public Property ReCar As Integer
        Get
            Return _reCar
        End Get
        Set(ByVal Value As Integer)
            _reCar = Value
        End Set
    End Property
    Public Property ManageID As String
        Get
            Return _manageID
        End Get
        Set(ByVal Value As String)
            _manageID = Value
        End Set
    End Property
    Public Property ManageDep As String
        Get
            Return _manageDep
        End Get
        Set(ByVal Value As String)
            _manageDep = Value
        End Set
    End Property
    Public Property ManageActive As Boolean
        Get
            Return _manageActive
        End Get
        Set(ByVal Value As Boolean)
            _manageActive = Value
        End Set
    End Property
    Public Property ManageAcDate As DateTime
        Get
            Return _manageAcDate
        End Get
        Set(ByVal Value As DateTime)
            _manageAcDate = Value
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
    Public Property ApprovalDate As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property CarID As Integer
        Get
            Return _carID
        End Get
        Set(ByVal Value As Integer)
            _carID = Value
        End Set
    End Property
    Public Property DriverName As String
        Get
            Return _driverName
        End Get
        Set(ByVal Value As String)
            _driverName = Value
        End Set
    End Property
    Public Property DriverPhone As String
        Get
            Return _driverPhone
        End Get
        Set(ByVal Value As String)
            _driverPhone = Value
        End Set
    End Property
    Public Property DriverNumber As String
        Get
            Return _driverNumber
        End Get
        Set(ByVal Value As String)
            _driverNumber = Value
        End Set
    End Property
    Public Property FirstKm As Double
        Get
            Return _firstKm
        End Get
        Set(ByVal Value As Double)
            _firstKm = Value
        End Set
    End Property
    Public Property FirstDate As DateTime
        Get
            Return _firstDate
        End Get
        Set(ByVal Value As DateTime)
            _firstDate = Value
        End Set
    End Property
    Public Property FirstUser As String
        Get
            Return _firstUser
        End Get
        Set(ByVal Value As String)
            _firstUser = Value
        End Set
    End Property
    Public Property LastKm As Double
        Get
            Return _lastKm
        End Get
        Set(ByVal Value As Double)
            _lastKm = Value
        End Set
    End Property
    Public Property LastDate As DateTime
        Get
            Return _lastDate
        End Get
        Set(ByVal Value As DateTime)
            _lastDate = Value
        End Set
    End Property
    Public Property LastUser As String
        Get
            Return _lastUser
        End Get
        Set(ByVal Value As String)
            _lastUser = Value
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
Public Class CMS_GroupInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
    Private _name As String = String.Empty
    Private _des As String = String.Empty
    Private _isStatus As Integer
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _createdUser As String = String.Empty
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
    Public Property UpdatedDate As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
Public Class CMS_GroupUInfo

#Region "Private Members"
    Private _iD As Integer
    Private _groupID As Integer
    Private _appID As String = String.Empty
    Private _depCode As String = String.Empty
    Private _empCode As String = String.Empty
    Private _appName As String = String.Empty
    Private _appLogo As String = String.Empty
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
    Public Property DepCode As String
        Get
            Return _depCode
        End Get
        Set(ByVal Value As String)
            _depCode = Value
        End Set
    End Property
    Public Property EmpCode As String
        Get
            Return _empCode
        End Get
        Set(ByVal Value As String)
            _empCode = Value
        End Set
    End Property
    Public Property AppName As String
        Get
            Return _appName
        End Get
        Set(ByVal Value As String)
            _appName = Value
        End Set
    End Property
    Public Property AppLogo As String
        Get
            Return _appLogo
        End Get
        Set(ByVal Value As String)
            _appLogo = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_MissionCarInfo

#Region "Private Members"
    Private _car_ID As Integer
    Private _uID As Integer
    Private _car_Name As String = String.Empty
    Private _car_Des As String = String.Empty
    Private _car_BKS As String = String.Empty
    Private _car_Manu As String = String.Empty
    Private _car_Number As Integer
    Private _driverName As String = String.Empty
    Private _driverPhone As String = String.Empty
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property Car_ID As Integer
        Get
            Return _car_ID
        End Get
        Set(ByVal Value As Integer)
            _car_ID = Value
        End Set
    End Property
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property Car_Name As String
        Get
            Return _car_Name
        End Get
        Set(ByVal Value As String)
            _car_Name = Value
        End Set
    End Property
    Public Property Car_Des As String
        Get
            Return _car_Des
        End Get
        Set(ByVal Value As String)
            _car_Des = Value
        End Set
    End Property
    Public Property Car_BKS As String
        Get
            Return _car_BKS
        End Get
        Set(ByVal Value As String)
            _car_BKS = Value
        End Set
    End Property
    Public Property Car_Manu As String
        Get
            Return _car_Manu
        End Get
        Set(ByVal Value As String)
            _car_Manu = Value
        End Set
    End Property
    Public Property Car_Number As Integer
        Get
            Return _car_Number
        End Get
        Set(ByVal Value As Integer)
            _car_Number = Value
        End Set
    End Property
    Public Property DriverName As String
        Get
            Return _driverName
        End Get
        Set(ByVal Value As String)
            _driverName = Value
        End Set
    End Property
    Public Property DriverPhone As String
        Get
            Return _driverPhone
        End Get
        Set(ByVal Value As String)
            _driverPhone = Value
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
Public Class CMS_Fr_GroupInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
    Private _eID As String = String.Empty
    Private _appID As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
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
Public Class MettingDayInfo
    Public Property StartDay As Integer
    Public Property EndDay As Integer
End Class
Public Class CMS_Group_ChatInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
    Private _eID As String = String.Empty
    Private _appID As String = String.Empty
    Private _name As String = String.Empty
    Private _logo As String = String.Empty
    Private _isStatus As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Public Property IsUsers As Integer
    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
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
Public Class CMS_Group_ChatUInfo

#Region "Private Members"
    Private _iD As Integer
    Private _groupID As Integer
    Private _eID As String = String.Empty
    Private _appID As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
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
Public Class CMS_SalaryMInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
    Private _months As Integer
    Private _years As Integer
    Private _isLock As Boolean
    Private _lockDate As DateTime
    Private _lockUser As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _total As Integer
    Private _thacMac As String = String.Empty

#End Region

#Region "Public Properties"
    Public Property ThacMac As String
        Get
            Return _thacMac
        End Get
        Set(ByVal Value As String)
            _thacMac = Value
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

    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property Months As Integer
        Get
            Return _months
        End Get
        Set(ByVal Value As Integer)
            _months = Value
        End Set
    End Property
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
    Public Property LockDate As DateTime
        Get
            Return _lockDate
        End Get
        Set(ByVal Value As DateTime)
            _lockDate = Value
        End Set
    End Property
    Public Property LockUser As String
        Get
            Return _lockUser
        End Get
        Set(ByVal Value As String)
            _lockUser = Value
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
#End Region

End Class
Public Class CMS_TimeKeepMInfo

#Region "Private Members"
    Private _iD As Integer
    Private _uID As Integer
    Private _months As Integer
    Private _years As Integer
    Private _isLock As Boolean
    Private _lockDate As DateTime
    Private _lockUser As String = String.Empty
    Private _thacMac As String = String.Empty
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property UID As Integer
        Get
            Return _uID
        End Get
        Set(ByVal Value As Integer)
            _uID = Value
        End Set
    End Property
    Public Property Months As Integer
        Get
            Return _months
        End Get
        Set(ByVal Value As Integer)
            _months = Value
        End Set
    End Property
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
    Public Property LockDate As DateTime
        Get
            Return _lockDate
        End Get
        Set(ByVal Value As DateTime)
            _lockDate = Value
        End Set
    End Property
    Public Property LockUser As String
        Get
            Return _lockUser
        End Get
        Set(ByVal Value As String)
            _lockUser = Value
        End Set
    End Property
    Public Property ThacMac As String
        Get
            Return _thacMac
        End Get
        Set(ByVal Value As String)
            _thacMac = Value
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
#End Region

End Class
