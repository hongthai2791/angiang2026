Public Class CMS_CounterInfo
#Region "Private Members"
    Private _portalID As Integer
    Private _counter As Integer
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
    Public Property Counter() As Integer
        Get
            Return _counter
        End Get
        Set(ByVal Value As Integer)
            _counter = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_BusinessInfo
#Region "Private Members"
    Private _career_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _business_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _business_En As String = String.Empty
    Private _business_Sort As String = String.Empty
    Private _QuanHuyen As String = String.Empty
    Private _XaPhuong As String = String.Empty
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
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isApproval As Boolean
    Private _approvalUser As String = String.Empty
    Private _approvalDate As DateTime
    Private _portalId As Integer
    Private _total As Integer
    Private _Scale As String = String.Empty
    Private _SoBan As Integer
    Private _TinhTrang As Integer
    Private _SoLuongTuyenDung As Integer
    Private _SoLuongUngVien As Integer
    Private _IdSend As String = String.Empty
    Private _TinhTP As String = String.Empty
    Private _PhuongXa As String = String.Empty
    Private _IsInvite As String
    Private _lat As String = String.Empty
    Private _lng As String = String.Empty
    Private _types As Integer
    Private _kCN As Boolean
    Private _kCN_ID As String = String.Empty
    Private _sanPhamChinh As String = String.Empty
    Private _quyMoLaoDong As Integer
    Private _contactChucVu As String = String.Empty
    Private _contactLHKhac As String = String.Empty
    Private _DichVuDangKy As String = String.Empty
    Private _DichVuDangKyKhac As String = String.Empty
    Private _SoLD6ThangToi As String = String.Empty
    Private _isTinCay As Boolean
#End Region
#Region "Public Properties"

    Public Property SoLD6ThangToi() As String
        Get
            Return _SoLD6ThangToi
        End Get
        Set(ByVal Value As String)
            _SoLD6ThangToi = Value
        End Set
    End Property
    Public Property DichVuDangKy() As String
        Get
            Return _DichVuDangKy
        End Get
        Set(ByVal Value As String)
            _DichVuDangKy = Value
        End Set
    End Property
    Public Property DichVuDangKyKhac() As String
        Get
            Return _DichVuDangKyKhac
        End Get
        Set(ByVal Value As String)
            _DichVuDangKyKhac = Value
        End Set
    End Property
    Public Property Lat() As String
        Get
            Return _lat
        End Get
        Set(ByVal Value As String)
            _lat = Value
        End Set
    End Property
    Public Property Lng() As String
        Get
            Return _lng
        End Get
        Set(ByVal Value As String)
            _lng = Value
        End Set
    End Property
    Public Property Types() As Integer
        Get
            Return _types
        End Get
        Set(ByVal Value As Integer)
            _types = Value
        End Set
    End Property
    Public Property KCN() As Boolean
        Get
            Return _kCN
        End Get
        Set(ByVal Value As Boolean)
            _kCN = Value
        End Set
    End Property
    Public Property KCN_ID() As String
        Get
            Return _kCN_ID
        End Get
        Set(ByVal Value As String)
            _kCN_ID = Value
        End Set
    End Property
    Public Property SanPhamChinh() As String
        Get
            Return _sanPhamChinh
        End Get
        Set(ByVal Value As String)
            _sanPhamChinh = Value
        End Set
    End Property
    Public Property QuyMoLaoDong() As Integer
        Get
            Return _quyMoLaoDong
        End Get
        Set(ByVal Value As Integer)
            _quyMoLaoDong = Value
        End Set
    End Property
    Public Property ContactChucVu() As String
        Get
            Return _contactChucVu
        End Get
        Set(ByVal Value As String)
            _contactChucVu = Value
        End Set
    End Property
    Public Property ContactLHKhac() As String
        Get
            Return _contactLHKhac
        End Get
        Set(ByVal Value As String)
            _contactLHKhac = Value
        End Set
    End Property
    Private _loaiHinh_ID As String
    Public Property LoaiHinh_ID() As String
        Get
            Return _loaiHinh_ID
        End Get
        Set(ByVal value As String)
            _loaiHinh_ID = value
        End Set
    End Property
    Public Property PhuongXa As String
        Get
            Return _PhuongXa
        End Get
        Set(ByVal Value As String)
            _PhuongXa = Value
        End Set
    End Property
    Public Property ID As Integer
    Public Property Status As Integer
    Public Property Career_ID As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
        End Set
    End Property
    Public Property IsInvite As String
        Get
            Return _IsInvite
        End Get
        Set(ByVal Value As String)
            _IsInvite = Value
        End Set
    End Property
    Public Property UserAdmin As String
    Public Property TinhTP As String
        Get
            Return _TinhTP
        End Get
        Set(ByVal Value As String)
            _TinhTP = Value
        End Set
    End Property
    Public Property IdSend As String
        Get
            Return _IdSend
        End Get
        Set(ByVal Value As String)
            _IdSend = Value
        End Set
    End Property
    Public Property SoLuongUngVien() As Integer
        Get
            Return _SoLuongUngVien
        End Get
        Set(ByVal Value As Integer)
            _SoLuongUngVien = Value
        End Set
    End Property
    Public Property SoLuongTuyenDung() As Integer
        Get
            Return _SoLuongTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _SoLuongTuyenDung = Value
        End Set
    End Property
    Public Property TinhTrang As Integer
        Get
            Return _TinhTrang
        End Get
        Set(ByVal Value As Integer)
            _TinhTrang = Value
        End Set
    End Property
    Public Property SoBan As Integer
        Get
            Return _SoBan
        End Get
        Set(ByVal Value As Integer)
            _SoBan = Value
        End Set
    End Property
    Public Property DoanhNghiep_ID As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
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
    Public Property Scale As String
        Get
            Return _Scale
        End Get
        Set(ByVal Value As String)
            _Scale = Value
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
    Public Property QuanHuyen As String
        Get
            Return _QuanHuyen
        End Get
        Set(ByVal Value As String)
            _QuanHuyen = Value
        End Set
    End Property
    Public Property XaPhuong As String
        Get
            Return _XaPhuong
        End Get
        Set(ByVal Value As String)
            _XaPhuong = Value
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
    Public Property IsAdmin As Boolean
    Public Property IsActive As Boolean
    Public Property IsApproval() As Boolean
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
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property IsTinCay() As Boolean
        Get
            Return _isTinCay
        End Get
        Set(ByVal Value As Boolean)
            _isTinCay = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_BusUserInfo
#Region "Private Members"
    Private _busUser_ID As String = String.Empty
    Private _business_ID As String = String.Empty
    Private _userAdmin As String = String.Empty
    Private _isActive As Boolean
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _approvalUser As String = String.Empty
    Private _approvalDate As DateTime
    Private _total As Integer
#End Region
#Region "Public Properties"
    Public Property IsAdmin As Boolean
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property
    Public Property BusUser_ID() As String
        Get
            Return _busUser_ID
        End Get
        Set(ByVal Value As String)
            _busUser_ID = Value
        End Set
    End Property
    Public Property Business_ID() As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
        End Set
    End Property
    Public Property UserAdmin() As String
        Get
            Return _userAdmin
        End Get
        Set(ByVal Value As String)
            _userAdmin = Value
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
    Public Property UpdatedDate() As DateTime
        Get
            Return _updatedDate
        End Get
        Set(ByVal Value As DateTime)
            _updatedDate = Value
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
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_ProfileSaveInfo
#Region "Private Members"
    Private _business_ID As String = String.Empty
    Private _profileSave_ID As String = String.Empty
    Private _jobUser_ID As String = String.Empty
    Private _isContact As Boolean
    Private _isInterview As Boolean
    Private _isTest As Boolean
    Private _isElect As Boolean
    Private _userName As String = String.Empty
    Private _createDate As DateTime
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _UserAdmin As String = String.Empty
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
    Public Property UserAdmin As String
        Get
            Return _UserAdmin
        End Get
        Set(ByVal Value As String)
            _UserAdmin = Value
        End Set
    End Property
    Public Property ProfileSave_ID As String
        Get
            Return _profileSave_ID
        End Get
        Set(ByVal Value As String)
            _profileSave_ID = Value
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
    Public Property IsContact() As Boolean
        Get
            Return _isContact
        End Get
        Set(ByVal Value As Boolean)
            _isContact = Value
        End Set
    End Property
    Public Property IsInterview() As Boolean
        Get
            Return _isInterview
        End Get
        Set(ByVal Value As Boolean)
            _isInterview = Value
        End Set
    End Property
    Public Property IsTest() As Boolean
        Get
            Return _isTest
        End Get
        Set(ByVal Value As Boolean)
            _isTest = Value
        End Set
    End Property
    Public Property IsElect() As Boolean
        Get
            Return _isElect
        End Get
        Set(ByVal Value As Boolean)
            _isElect = Value
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
    Public Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal Value As DateTime)
            _createDate = Value
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
#End Region
End Class
Public Class CMS_RecruitmentInfo
#Region "Private Members"
    Private _recruitment_ID As String = String.Empty
    Private _wID As Integer
    Private _ID As Integer
    Private _work_ID As String = String.Empty
    Private _isView As Boolean
    Private _isContact As Boolean
    Private _isInterview As Boolean
    Private _isTest As Boolean
    Private _isElect As Boolean
    Private _isCancel As Boolean
    Private _userName As String = String.Empty
    Private _createDate As DateTime
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _ctotal As Integer
    Private _JobUser_ID As String = String.Empty
    Private _Salary_ID As String = String.Empty
    Private _Business_ID As String = String.Empty
    Private _isInvite As Boolean
    Private _createdUser As String = String.Empty
#End Region
#Region "Public Properties"
    Public Property jID As Integer
    Public Property NgayNopHS As String
    Public Property TenDN As String
    Public Property IsClass As Integer
    Public Property STT As String
    Public Property UserAdmin As String
    Public Property W_Title As String
    Public Property Title As String
    Public Property LuotXem As Integer
    Public Property Quantity As Double
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property
    Public Property wID As Integer
        Get
            Return _wID
        End Get
        Set(ByVal Value As Integer)
            _wID = Value
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
    Public Property IsInvite As Boolean
        Get
            Return _isInvite
        End Get
        Set(ByVal Value As Boolean)
            _isInvite = Value
        End Set
    End Property
    Public Property JobUser_ID As String
        Get
            Return _JobUser_ID
        End Get
        Set(ByVal Value As String)
            _JobUser_ID = Value
        End Set
    End Property
    Public Property Business_ID As String
        Get
            Return _Business_ID
        End Get
        Set(ByVal Value As String)
            _Business_ID = Value
        End Set
    End Property
    Public Property Recruitment_ID As String
        Get
            Return _recruitment_ID
        End Get
        Set(ByVal Value As String)
            _recruitment_ID = Value
        End Set
    End Property
    Public Property Salary_ID As String
        Get
            Return _Salary_ID
        End Get
        Set(ByVal Value As String)
            _Salary_ID = Value
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
    Public Property IsView() As Boolean
        Get
            Return _isView
        End Get
        Set(ByVal Value As Boolean)
            _isView = Value
        End Set
    End Property
    Public Property IsContact() As Boolean
        Get
            Return _isContact
        End Get
        Set(ByVal Value As Boolean)
            _isContact = Value
        End Set
    End Property
    Public Property IsInterview() As Boolean
        Get
            Return _isInterview
        End Get
        Set(ByVal Value As Boolean)
            _isInterview = Value
        End Set
    End Property
    Public Property IsTest() As Boolean
        Get
            Return _isTest
        End Get
        Set(ByVal Value As Boolean)
            _isTest = Value
        End Set
    End Property
    Public Property IsElect() As Boolean
        Get
            Return _isElect
        End Get
        Set(ByVal Value As Boolean)
            _isElect = Value
        End Set
    End Property
    Public Property IsCancel() As Boolean
        Get
            Return _isCancel
        End Get
        Set(ByVal Value As Boolean)
            _isCancel = Value
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
            Return _createdUser
        End Get
        Set(ByVal Value As String)
            _createdUser = Value
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
    Public Property Ctotal As Integer
        Get
            Return _ctotal
        End Get
        Set(ByVal Value As Integer)
            _ctotal = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_WorkInfo
#Region "Private Members"
    Private _workTime As String = String.Empty
    Private _ages As String = String.Empty
    Private _work_ID As String = String.Empty
    Private _tuyenDung_ID As String = String.Empty
    Private _DoanhNghiep_ID As String = String.Empty
    Private _business_ID As String = String.Empty
    Private _title As String = String.Empty
    Private _salary_ID As String = String.Empty
    Private _quantity As Integer
    Private _ketQuaPhongVan As Integer
    Private _experience_ID As String = String.Empty
    Private _gender As Integer
    Private _level_ID As String = String.Empty
    Private _TinhTP As String = String.Empty
    Private _QuanHuyen As String = String.Empty
    Private _PhuongXa As String = String.Empty
    Private _TypeOf_ID As String = String.Empty
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
    Private _isGhim As Boolean
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
    Private _portalID As Integer
    Private _total As Integer
    Private _isView As Integer
    Private _isSend As Integer
    Private _LevelDesired_ID As String
    Private _IsFlag As Integer
    Private _jobPlace As String
    Private _Business_Vn As String
    Private _IdSend As String = String.Empty
    Private _ungVien_ID As String = String.Empty
    Private _IsInvite As Boolean
#End Region
#Region "Public Properties"
    Public Property KieuLuong As String
    Public Property Salary_Option As String
    Public Property Salary_Text As String
    Public Property YeuCauKinhNghiem As String

    Private _Lat As String
    Public Property Lat As String
        Get
            Return _Lat
        End Get
        Set(ByVal Value As String)
            _Lat = Value
        End Set
    End Property
    Private _Lng As String
    Public Property Lng As String
        Get
            Return _Lng
        End Get
        Set(ByVal Value As String)
            _Lng = Value
        End Set
    End Property
    Public Property LuotXem As String
    Public Property ImageURL As String
    Public Property TenTinhTP As String
    Public Property HanNopHoSo As String
    Public Property MucLuong As String
    Public Property BangCap As String
    Public Property NganhNghe As String
    Public Property ViTriTuyenDung As String
    Public Property HinhThucLamViec As String
    Public Property ChucVu As String
    Public Property SoNamKinhNghiem As String
    Public Property GioiTinh As String
    Public Property parent_ID As String
    Public Property GTVL As Integer
    Public Property ID As Integer
    Public Property Ages As String
        Get
            Return _ages
        End Get
        Set(ByVal Value As String)
            _ages = Value
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
    Public Property UngVien_ID As String
        Get
            Return _ungVien_ID
        End Get
        Set(ByVal Value As String)
            _ungVien_ID = Value
        End Set
    End Property
    Public Property IsInvite As String
        Get
            Return _IsInvite
        End Get
        Set(ByVal Value As String)
            _IsInvite = Value
        End Set
    End Property
    Public Property TinhTP As String
        Get
            Return _TinhTP
        End Get
        Set(ByVal Value As String)
            _TinhTP = Value
        End Set
    End Property
    Public Property IdSend As String
        Get
            Return _IdSend
        End Get
        Set(ByVal Value As String)
            _IdSend = Value
        End Set
    End Property
    Public Property TuyenDung_ID As String
        Get
            Return _tuyenDung_ID
        End Get
        Set(ByVal Value As String)
            _tuyenDung_ID = Value
        End Set
    End Property
    Public Property DoanhNghiep_ID As String
        Get
            Return _DoanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _DoanhNghiep_ID = Value
        End Set
    End Property
    Public Property Business_Vn As String
        Get
            Return _Business_Vn
        End Get
        Set(ByVal Value As String)
            _Business_Vn = Value
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
    Public Property KetQuaPhongVan() As Integer
        Get
            Return _ketQuaPhongVan
        End Get
        Set(ByVal Value As Integer)
            _ketQuaPhongVan = Value
        End Set
    End Property
    Public Property LevelDesired_ID As String
        Get
            Return _LevelDesired_ID
        End Get
        Set(ByVal Value As String)
            _LevelDesired_ID = Value
        End Set
    End Property
    Public Property IsFlag() As Integer
        Get
            Return _IsFlag
        End Get
        Set(ByVal Value As Integer)
            _IsFlag = Value
        End Set
    End Property
    Public Property IsView() As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
        End Set
    End Property
    Public Property IsSend() As Integer
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Integer)
            _isSend = Value
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
    Public Property Quantity() As Integer
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
    Public Property Gender() As Integer
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
    Public Property QuanHuyen As String
        Get
            Return _QuanHuyen
        End Get
        Set(ByVal Value As String)
            _QuanHuyen = Value
        End Set
    End Property
    Public Property PhuongXa As String
        Get
            Return _PhuongXa
        End Get
        Set(ByVal Value As String)
            _PhuongXa = Value
        End Set
    End Property
    Public Property TypeOf_ID As String
        Get
            Return _TypeOf_ID
        End Get
        Set(ByVal Value As String)
            _TypeOf_ID = Value
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
    Public Property ExpiredDate() As DateTime
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
    Public Property IsHot() As Boolean
        Get
            Return _isHot
        End Get
        Set(ByVal Value As Boolean)
            _isHot = Value
        End Set
    End Property
    Public Property IsGhim As Boolean
        Get
            Return _isGhim
        End Get
        Set(ByVal Value As Boolean)
            _isGhim = Value
        End Set
    End Property
    Public Property IsFast() As Boolean
        Get
            Return _isFast
        End Get
        Set(ByVal Value As Boolean)
            _isFast = Value
        End Set
    End Property
    Public Property IsUrgent() As Boolean
        Get
            Return _isUrgent
        End Get
        Set(ByVal Value As Boolean)
            _isUrgent = Value
        End Set
    End Property
    Public Property IsApproval() As Boolean
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
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property DeletedUser As String
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
Public Class CMS_JobUserInfo
#Region "Private Members"
    Private _jobUser_ID As String = String.Empty
    Private _title As String = String.Empty
    Private _career_ID As String = String.Empty
    Private _currentLevel As String = String.Empty
    Private _levelDesired As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
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
    Private _isPause As Boolean
    Private _IsTemp As Boolean
    Private _IsBHTN As Boolean
#End Region
#Region "Public Properties"
    Public Property TenTinhTP As String
    Public Property HanNopHoSo As String
    Public Property MucLuong As String
    Public Property BangCap As String
    Public Property NganhNghe As String
    Public Property NgayDangTin As String
    Public Property TrinhDoChuyenMon As String
    Public Property ChucVu As String
    Public Property SoNamKinhNghiem As String
    Public Property GioiTinh As String
    Public Property NhuCaulamViec As String
    Public Property UserAdminText As String
    Public Property IsBHTN As Boolean
        Get
            Return _IsBHTN
        End Get
        Set(ByVal Value As Boolean)
            _IsBHTN = Value
        End Set
    End Property
    Public Property ID As Integer
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property
    Public Property IsPause As Boolean
        Get
            Return _isPause
        End Get
        Set(ByVal Value As Boolean)
            _isPause = Value
        End Set
    End Property
    Public Property IsTemp As Boolean
        Get
            Return _IsTemp
        End Get
        Set(ByVal Value As Boolean)
            _IsTemp = Value
        End Set
    End Property
    Public Property JobUser_ID() As String
        Get
            Return _jobUser_ID
        End Get
        Set(ByVal Value As String)
            _jobUser_ID = Value
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
    Public Property Career_ID() As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
        End Set
    End Property
    Public Property CurrentLevel() As String
        Get
            Return _currentLevel
        End Get
        Set(ByVal Value As String)
            _currentLevel = Value
        End Set
    End Property
    Public Property LevelDesired() As String
        Get
            Return _levelDesired
        End Get
        Set(ByVal Value As String)
            _levelDesired = Value
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
    Public Property Experience_ID() As String
        Get
            Return _experience_ID
        End Get
        Set(ByVal Value As String)
            _experience_ID = Value
        End Set
    End Property
    Public Property Level_ID() As String
        Get
            Return _level_ID
        End Get
        Set(ByVal Value As String)
            _level_ID = Value
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
    Public Property Needs_ID() As String
        Get
            Return _needs_ID
        End Get
        Set(ByVal Value As String)
            _needs_ID = Value
        End Set
    End Property
    Public Property Education() As String
        Get
            Return _education
        End Get
        Set(ByVal Value As String)
            _education = Value
        End Set
    End Property
    Public Property CareerGoals() As String
        Get
            Return _careerGoals
        End Get
        Set(ByVal Value As String)
            _careerGoals = Value
        End Set
    End Property
    Public Property WorkExperience() As String
        Get
            Return _workExperience
        End Get
        Set(ByVal Value As String)
            _workExperience = Value
        End Set
    End Property
    Public Property SkillsForte() As String
        Get
            Return _skillsForte
        End Get
        Set(ByVal Value As String)
            _skillsForte = Value
        End Set
    End Property
    Public Property UserAdmin() As String
        Get
            Return _userAdmin
        End Get
        Set(ByVal Value As String)
            _userAdmin = Value
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
    Public Property IsApproval() As Boolean
        Get
            Return _isApproval
        End Get
        Set(ByVal Value As Boolean)
            _isApproval = Value
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
    Public Property ApprovalDate() As DateTime
        Get
            Return _approvalDate
        End Get
        Set(ByVal Value As DateTime)
            _approvalDate = Value
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
    Public Property IsView() As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
        End Set
    End Property
    Public Property IsSend() As Integer
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Integer)
            _isSend = Value
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
Public Class CMS_JobUserBHTNInfo
#Region "Private Members"
    Private _iD As Integer
    Private _jobUser_ID As Integer
    Private _bHTN_ID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _gioiTinh As String = String.Empty
    Private _email As String = String.Empty
    Private _soDienThoai As String = String.Empty
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
    Public Property JobUser_ID() As Integer
        Get
            Return _jobUser_ID
        End Get
        Set(ByVal Value As Integer)
            _jobUser_ID = Value
        End Set
    End Property
    Public Property BHTN_ID() As String
        Get
            Return _bHTN_ID
        End Get
        Set(ByVal Value As String)
            _bHTN_ID = Value
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
    Public Property NgaySinh() As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As String
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As String)
            _gioiTinh = Value
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
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
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
Public Class CMS_GTVLInfo
#Region "Private Members"
    Private _iD As Integer
    Private _work_ID As String = String.Empty
    Private _jobUser_ID As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _isView As Boolean
    Private _isContact As Boolean
    Private _isInterview As Boolean
    Private _isTest As Boolean
    Private _isElect As Boolean
    Private _isCancel As Boolean
    Private _total As Integer
    Private _Business_ID As String = String.Empty
    Private _Salary_ID As String = String.Empty
    Private _ctotal As Integer
    Private _expiredDate As DateTime
#End Region
#Region "Public Properties"
    Public Property wID As Integer
    Public Property STT As String
    Public Property UserAdmin As String
    Public Property W_Title As String
    Public Property Title As String
    Public Property LuotXem As Integer
    Public Property Quantity As Double
    Public Property JobPlace As String
    Public Property Business_Vn As String
    Public Property Address As String
    Public Property ContactUser As String
    Public Property ContactMobile As String
    Public Property Gender As Integer
    Public Property Ages As String
    Public Property Level_ID As String
    Public Property Career_ID As String
    Public Property Experience_ID As String
    Public Property WorkTime As String
    Public Property TinhTP As String
    Public Property NgayGT As DateTime
    Public Property jID As Integer



    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
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
    Public Property ExpiredDate As DateTime
        Get
            Return _expiredDate
        End Get
        Set(ByVal Value As DateTime)
            _expiredDate = Value
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
    Public Property Business_ID As String
        Get
            Return _Business_ID
        End Get
        Set(ByVal Value As String)
            _Business_ID = Value
        End Set
    End Property
    Public Property Salary_ID As String
        Get
            Return _Salary_ID
        End Get
        Set(ByVal Value As String)
            _Salary_ID = Value
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
    Public Property IsView() As Boolean
        Get
            Return _isView
        End Get
        Set(ByVal Value As Boolean)
            _isView = Value
        End Set
    End Property
    Public Property IsContact() As Boolean
        Get
            Return _isContact
        End Get
        Set(ByVal Value As Boolean)
            _isContact = Value
        End Set
    End Property
    Public Property IsInterview() As Boolean
        Get
            Return _isInterview
        End Get
        Set(ByVal Value As Boolean)
            _isInterview = Value
        End Set
    End Property
    Public Property IsTest() As Boolean
        Get
            Return _isTest
        End Get
        Set(ByVal Value As Boolean)
            _isTest = Value
        End Set
    End Property
    Public Property IsElect() As Boolean
        Get
            Return _isElect
        End Get
        Set(ByVal Value As Boolean)
            _isElect = Value
        End Set
    End Property
    Public Property IsCancel() As Boolean
        Get
            Return _isCancel
        End Get
        Set(ByVal Value As Boolean)
            _isCancel = Value
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
    Public Property CreatedDate() As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal Value As DateTime)
            _createdDate = Value
        End Set
    End Property
    Public Property Ctotal As Integer
        Get
            Return _ctotal
        End Get
        Set(ByVal Value As Integer)
            _ctotal = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_SendMailInfo
#Region "Private Members"
    Private _DoanhNghiep_ID As String = String.Empty
    Private _PhienGD_ID As String = String.Empty
    Private _NgayGui As DateTime
#End Region
#Region "Public Properties"
    Public Property ID As Integer
    Public Property DoanhNghiep_ID() As String
        Get
            Return _DoanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _DoanhNghiep_ID = Value
        End Set
    End Property
    Public Property PhienGD_ID() As String
        Get
            Return _PhienGD_ID
        End Get
        Set(ByVal Value As String)
            _PhienGD_ID = Value
        End Set
    End Property
    Public Property NgayGui() As DateTime
        Get
            Return _NgayGui
        End Get
        Set(ByVal Value As DateTime)
            _NgayGui = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_JobViewInfo
#Region "Private Members"
    Private _jobView_ID As String = String.Empty
    Private _idKey As String = String.Empty
    Private _idName As String = String.Empty
    Private _isFlag As Integer
    Private _userName As String = String.Empty
    Private _createDate As DateTime
    Private _total As Integer
#End Region
#Region "Public Properties"
    Public Property ID As String
    Public Property Title As String
    Public Property TenDN As String
    Public Property NgayThucHien As String
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property
    Public Property JobView_ID As String
        Get
            Return _jobView_ID
        End Get
        Set(ByVal Value As String)
            _jobView_ID = Value
        End Set
    End Property
    Public Property IdName As String
        Get
            Return _idName
        End Get
        Set(ByVal Value As String)
            _idName = Value
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
    Public Property IsFlag() As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
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
Public Class CMS_JobInviteInfo
#Region "Private Members"
    Private _JobInvite_ID As String = String.Empty
    Private _workID As String = String.Empty
    Private _JobID As String = String.Empty
    Private _BusID As String = String.Empty
    Private _UserName As String = String.Empty
    Private _createDate As DateTime
    Private _total As Integer
    Private _IsStatus As Integer
#End Region
#Region "Public Properties"
    Public Property IsStatus As Integer
        Get
            Return _IsStatus
        End Get
        Set(ByVal Value As Integer)
            _IsStatus = Value
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
    Public Property JobInvite_ID As String
        Get
            Return _JobInvite_ID
        End Get
        Set(ByVal Value As String)
            _JobInvite_ID = Value
        End Set
    End Property
    Public Property UserName As String
        Get
            Return _UserName
        End Get
        Set(ByVal Value As String)
            _UserName = Value
        End Set
    End Property
    Public Property WorkID As String
        Get
            Return _workID
        End Get
        Set(ByVal Value As String)
            _workID = Value
        End Set
    End Property
    Public Property JobID As String
        Get
            Return _JobID
        End Get
        Set(ByVal Value As String)
            _JobID = Value
        End Set
    End Property
    Public Property BusID As String
        Get
            Return _BusID
        End Get
        Set(ByVal Value As String)
            _BusID = Value
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
Public Class CMS_ThongKeInfo
    Private _DonViTD As Integer
    Private _HoSoUV As Integer
    Private _HoSoTD As Integer
    Private _LogView As Integer
    Private _UngVien As Integer
    Private _DoanhNghiep As Integer
    Private _TinTuyenDung As Integer
    Private _PhongVan As Integer
    Private _DuocPhongVan As Integer
    Private _PhongVanTC As Integer
    Private _ViecTrong As Integer
    Public Property LogView As Integer
        Get
            Return _LogView
        End Get
        Set(ByVal Value As Integer)
            _LogView = Value
        End Set
    End Property
    Public Property UngVien As Integer
        Get
            Return _UngVien
        End Get
        Set(ByVal Value As Integer)
            _UngVien = Value
        End Set
    End Property
    Public Property DoanhNghiep As Integer
        Get
            Return _DoanhNghiep
        End Get
        Set(ByVal Value As Integer)
            _DoanhNghiep = Value
        End Set
    End Property
    Public Property TinTuyenDung As Integer
        Get
            Return _TinTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _TinTuyenDung = Value
        End Set
    End Property
    Public Property PhongVan As Integer
        Get
            Return _PhongVan
        End Get
        Set(ByVal Value As Integer)
            _PhongVan = Value
        End Set
    End Property
    Public Property DuocPhongVan As Integer
        Get
            Return _DuocPhongVan
        End Get
        Set(ByVal Value As Integer)
            _DuocPhongVan = Value
        End Set
    End Property
    Public Property PhongVanTC As Integer
        Get
            Return _PhongVanTC
        End Get
        Set(ByVal Value As Integer)
            _PhongVanTC = Value
        End Set
    End Property
    Public Property ViecTrong As Integer
        Get
            Return _ViecTrong
        End Get
        Set(ByVal Value As Integer)
            _ViecTrong = Value
        End Set
    End Property
    Public Property DonViTD As Integer
        Get
            Return _DonViTD
        End Get
        Set(ByVal Value As Integer)
            _DonViTD = Value
        End Set
    End Property
    Public Property HoSoUV As Integer
        Get
            Return _HoSoUV
        End Get
        Set(ByVal Value As Integer)
            _HoSoUV = Value
        End Set
    End Property
    Public Property HoSoTD As Integer
        Get
            Return _HoSoTD
        End Get
        Set(ByVal Value As Integer)
            _HoSoTD = Value
        End Set
    End Property
End Class
Public Class CMS_EventLogInfo
    Private _evenLog_ID As Integer
    Private _logDay As Integer
    Private _logMonth As Integer
    Private _logYear As Integer
    Private _logView As Integer
    Private _portalID As Integer
    Public Property EvenLog_ID() As Integer
        Get
            Return _evenLog_ID
        End Get
        Set(ByVal Value As Integer)
            _evenLog_ID = Value
        End Set
    End Property
    Public Property LogDay As Integer
        Get
            Return _logDay
        End Get
        Set(ByVal Value As Integer)
            _logDay = Value
        End Set
    End Property
    Public Property LogMonth As Integer
        Get
            Return _logMonth
        End Get
        Set(ByVal Value As Integer)
            _logMonth = Value
        End Set
    End Property
    Public Property LogYear As Integer
        Get
            Return _logYear
        End Get
        Set(ByVal Value As Integer)
            _logYear = Value
        End Set
    End Property
    Public Property LogView As Integer
        Get
            Return _logView
        End Get
        Set(ByVal Value As Integer)
            _logView = Value
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
End Class
Public Class CMS_DoanhNghiepInfo
#Region "Private Members"
    Private _doanhNghiep_ID As String = String.Empty
    Private _phienGD_ID As String = String.Empty
    Private _business_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _soBan As Integer
    Private _gioBatDau As DateTime
    Private _gioKetThuc As DateTime
    Private _tinhTrangThamGia As Integer
    Private _fileDinhKem As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _total As Integer
    Private _logo As String = String.Empty
    Private _UserAdmin As String = String.Empty
    Private _SoLuongUngVien As Integer
    Private _SoLuongTuyenDung As Integer
#End Region
#Region "Public Properties"
    Public Property SoLuongTuyenDung() As Integer
        Get
            Return _SoLuongTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _SoLuongTuyenDung = Value
        End Set
    End Property
    Public Property SoLuongUngVien() As Integer
        Get
            Return _SoLuongUngVien
        End Get
        Set(ByVal Value As Integer)
            _SoLuongUngVien = Value
        End Set
    End Property
    Public Property UserAdmin As String
        Get
            Return _UserAdmin
        End Get
        Set(ByVal Value As String)
            _UserAdmin = Value
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
    Public Property Logo As String
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
    Public Property DoanhNghiep_ID As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
        End Set
    End Property
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
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
    Public Property SoBan() As Integer
        Get
            Return _soBan
        End Get
        Set(ByVal Value As Integer)
            _soBan = Value
        End Set
    End Property
    Public Property GioBatDau() As DateTime
        Get
            Return _gioBatDau
        End Get
        Set(ByVal Value As DateTime)
            _gioBatDau = Value
        End Set
    End Property
    Public Property GioKetThuc() As DateTime
        Get
            Return _gioKetThuc
        End Get
        Set(ByVal Value As DateTime)
            _gioKetThuc = Value
        End Set
    End Property
    Public Property TinhTrangThamGia() As Integer
        Get
            Return _tinhTrangThamGia
        End Get
        Set(ByVal Value As Integer)
            _tinhTrangThamGia = Value
        End Set
    End Property
    Public Property FileDinhKem As String
        Get
            Return _fileDinhKem
        End Get
        Set(ByVal Value As String)
            _fileDinhKem = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_DoanhNghiep_UngVienInfo
#Region "Private Members"
    Private _JobUser_ID As String = String.Empty
    Private _IsInvite As Boolean
    Private _dNUV_ID As String = String.Empty
    Private _phienGD_ID As String = String.Empty
    Private _UngVien_ID As String = String.Empty
    Private _banPhongVan As Integer
    Private _tinhTrangPhongVan As Integer
    Private _ketQuaPhongVan As Integer
    Private _chiTietPhongVan As String = String.Empty
    Private _thuTuPhongVan As Integer
    Private _tuyenDung_ID As String = String.Empty
    Private _tuyenDungName As String = String.Empty
    Private _viTriDat As String = String.Empty
    Private _viTriDatName As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _total As Integer
    Private _gioiTinh As Integer
    Private _ho_Dem As String = String.Empty
    Private _ten As String = String.Empty
    Private _tenDayDu As String = String.Empty
    Private _ngaySinh As DateTime
    Private _noiSinh As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _email As String = String.Empty
    Private _tel As String = String.Empty
    Private _nganhNghe As String = String.Empty
    Private _trinhDoChuyenMon As String = String.Empty
    Private _namKinhNghiem As String = String.Empty
    Private _QuanTam As Integer
    Private _loaiUngVien As Integer
    Private _DoanhNghiep_ID As String = String.Empty
    Private _Work_ID As String = String.Empty
    Private _NguoiTimViec_ID As String = String.Empty
    Private _Business_Vn As String = String.Empty
    Private _IsStatus As Integer
#End Region
#Region "Public Properties"
    Public Property IsOder As Integer
    Public Property Stt As Integer
    Public Property W_Work_ID As String
    Public Property IsInvite As Boolean
        Get
            Return _IsInvite
        End Get
        Set(ByVal Value As Boolean)
            _IsInvite = Value
        End Set
    End Property
    Public Property Business_Vn As String
        Get
            Return _Business_Vn
        End Get
        Set(ByVal Value As String)
            _Business_Vn = Value
        End Set
    End Property
    Public Property NguoiTimViec_ID As String
        Get
            Return _NguoiTimViec_ID
        End Get
        Set(ByVal Value As String)
            _NguoiTimViec_ID = Value
        End Set
    End Property
    Public Property JobUser_ID As String
        Get
            Return _JobUser_ID
        End Get
        Set(ByVal Value As String)
            _JobUser_ID = Value
        End Set
    End Property
    Public Property Work_ID As String
        Get
            Return _Work_ID
        End Get
        Set(ByVal Value As String)
            _Work_ID = Value
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
    Public Property LoaiUngVien() As Integer
        Get
            Return _loaiUngVien
        End Get
        Set(ByVal Value As Integer)
            _loaiUngVien = Value
        End Set
    End Property
    Public Property QuanTam() As Integer
        Get
            Return _QuanTam
        End Get
        Set(ByVal Value As Integer)
            _QuanTam = Value
        End Set
    End Property
    Public Property DoanhNghiep_ID As String
        Get
            Return _DoanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _DoanhNghiep_ID = Value
        End Set
    End Property
    Public Property Ho_Dem As String
        Get
            Return _ho_Dem
        End Get
        Set(ByVal Value As String)
            _ho_Dem = Value
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
    Public Property TenDayDu As String
        Get
            Return _tenDayDu
        End Get
        Set(ByVal Value As String)
            _tenDayDu = Value
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
    Public Property NoiSinh As String
        Get
            Return _noiSinh
        End Get
        Set(ByVal Value As String)
            _noiSinh = Value
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
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property
    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(ByVal Value As String)
            _tel = Value
        End Set
    End Property
    Public Property NganhNghe As String
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As String)
            _nganhNghe = Value
        End Set
    End Property
    Public Property TrinhDoChuyenMon As String
        Get
            Return _trinhDoChuyenMon
        End Get
        Set(ByVal Value As String)
            _trinhDoChuyenMon = Value
        End Set
    End Property
    Public Property NamKinhNghiem As String
        Get
            Return _namKinhNghiem
        End Get
        Set(ByVal Value As String)
            _namKinhNghiem = Value
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
    Public Property DNUV_ID As String
        Get
            Return _dNUV_ID
        End Get
        Set(ByVal Value As String)
            _dNUV_ID = Value
        End Set
    End Property
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
        End Set
    End Property
    Public Property UngVien_ID As String
        Get
            Return _UngVien_ID
        End Get
        Set(ByVal Value As String)
            _UngVien_ID = Value
        End Set
    End Property
    Public Property BanPhongVan() As Integer
        Get
            Return _banPhongVan
        End Get
        Set(ByVal Value As Integer)
            _banPhongVan = Value
        End Set
    End Property
    Public Property TinhTrangPhongVan() As Integer
        Get
            Return _tinhTrangPhongVan
        End Get
        Set(ByVal Value As Integer)
            _tinhTrangPhongVan = Value
        End Set
    End Property
    Public Property KetQuaPhongVan() As Integer
        Get
            Return _ketQuaPhongVan
        End Get
        Set(ByVal Value As Integer)
            _ketQuaPhongVan = Value
        End Set
    End Property
    Public Property ChiTietPhongVan As String
        Get
            Return _chiTietPhongVan
        End Get
        Set(ByVal Value As String)
            _chiTietPhongVan = Value
        End Set
    End Property
    Public Property ThuTuPhongVan() As Integer
        Get
            Return _thuTuPhongVan
        End Get
        Set(ByVal Value As Integer)
            _thuTuPhongVan = Value
        End Set
    End Property
    Public Property TuyenDung_ID As String
        Get
            Return _tuyenDung_ID
        End Get
        Set(ByVal Value As String)
            _tuyenDung_ID = Value
        End Set
    End Property
    Public Property TuyenDungName As String
        Get
            Return _tuyenDungName
        End Get
        Set(ByVal Value As String)
            _tuyenDungName = Value
        End Set
    End Property
    Public Property ViTriDat As String
        Get
            Return _viTriDat
        End Get
        Set(ByVal Value As String)
            _viTriDat = Value
        End Set
    End Property
    Public Property ViTriDatName As String
        Get
            Return _viTriDatName
        End Get
        Set(ByVal Value As String)
            _viTriDatName = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
    Public Property IsStatus() As Integer
        Get
            Return _IsStatus
        End Get
        Set(ByVal Value As Integer)
            _IsStatus = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_PhienGiaoDichInfo
#Region "Private Members"
    Private _TinhTP As String = String.Empty
    Private _phienGD_ID As String = String.Empty
    Private _tenPhien As String = String.Empty
    Private _diaDiem As String = String.Empty
    Private _thoiGian_BatDau As DateTime
    Private _thoiGian_KetThuc As DateTime
    Private _isActive As Boolean
    Private _loaiPhien As Integer
    Private _hotline As String = String.Empty
    Private _email As String = String.Empty
    Private _moTa As String = String.Empty
    Private _ketQua As String = String.Empty
    Private _fileDinhKem As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _portalId As Integer
    Private _total As Integer
#End Region
#Region "Public Properties"
    Public Property TinhTP As String
        Get
            Return _TinhTP
        End Get
        Set(ByVal Value As String)
            _TinhTP = Value
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
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
        End Set
    End Property
    Public Property TenPhien As String
        Get
            Return _tenPhien
        End Get
        Set(ByVal Value As String)
            _tenPhien = Value
        End Set
    End Property
    Public Property DiaDiem As String
        Get
            Return _diaDiem
        End Get
        Set(ByVal Value As String)
            _diaDiem = Value
        End Set
    End Property
    Public Property ThoiGian_BatDau() As DateTime
        Get
            Return _thoiGian_BatDau
        End Get
        Set(ByVal Value As DateTime)
            _thoiGian_BatDau = Value
        End Set
    End Property
    Public Property ThoiGian_KetThuc() As DateTime
        Get
            Return _thoiGian_KetThuc
        End Get
        Set(ByVal Value As DateTime)
            _thoiGian_KetThuc = Value
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
    Public Property LoaiPhien() As Integer
        Get
            Return _loaiPhien
        End Get
        Set(ByVal Value As Integer)
            _loaiPhien = Value
        End Set
    End Property
    Public Property Hotline As String
        Get
            Return _hotline
        End Get
        Set(ByVal Value As String)
            _hotline = Value
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
    Public Property MoTa As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
        End Set
    End Property
    Public Property KetQua As String
        Get
            Return _ketQua
        End Get
        Set(ByVal Value As String)
            _ketQua = Value
        End Set
    End Property
    Public Property FileDinhKem As String
        Get
            Return _fileDinhKem
        End Get
        Set(ByVal Value As String)
            _fileDinhKem = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
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
Public Class CMS_TuyenDungInfo
#Region "Private Members"
    Private _tuyenDung_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _work_ID As String = String.Empty
    Private _phienGD_ID As String = String.Empty
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
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
    Public Property TuyenDung_ID As String
        Get
            Return _tuyenDung_ID
        End Get
        Set(ByVal Value As String)
            _tuyenDung_ID = Value
        End Set
    End Property
    Public Property DoanhNghiep_ID As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
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
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
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
#End Region
End Class
Public Class CMS_UngVienInfo
#Region "Private Members"
    Private _ungVien_ID As String = String.Empty
    Private _DoanhNghiep_ID As String = String.Empty
    Private _nguoiTimViec_ID As String = String.Empty
    Private _loaiUngVien As Integer
    Private _GioiTinh As Integer
    Private _tenDayDu As String = String.Empty
    Private _ngaySinh As DateTime
    Private _diaChi As String = String.Empty
    Private _email As String = String.Empty
    Private _tel As String = String.Empty
    Private _nganhNghe As String = String.Empty
    Private _trinhDoChuyenMon As String = String.Empty
    Private _namKinhNghiem As String = String.Empty
    Private _viTriUngTuyen As String = String.Empty
    Private _nhuCauLamViec As String = String.Empty
    Private _phienGD_ID As String = String.Empty
    Private _createdBy As DateTime
    Private _total As Integer
    Private _Business_Vn As String = String.Empty
    Private _ketQuaPhongVan As Integer
    Private _isInvite As Boolean
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
    Public Property IsInvite As Boolean
        Get
            Return _isInvite
        End Get
        Set(ByVal Value As Boolean)
            _isInvite = Value
        End Set
    End Property
    Public Property KetQuaPhongVan As Integer
        Get
            Return _ketQuaPhongVan
        End Get
        Set(ByVal Value As Integer)
            _ketQuaPhongVan = Value
        End Set
    End Property
    Public Property DoanhNghiep_ID As String
        Get
            Return _DoanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _DoanhNghiep_ID = Value
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
    Public Property Business_Vn As String
        Get
            Return _Business_Vn
        End Get
        Set(ByVal Value As String)
            _Business_Vn = Value
        End Set
    End Property
    Public Property UngVien_ID As String
        Get
            Return _ungVien_ID
        End Get
        Set(ByVal Value As String)
            _ungVien_ID = Value
        End Set
    End Property
    Public Property NguoiTimViec_ID As String
        Get
            Return _nguoiTimViec_ID
        End Get
        Set(ByVal Value As String)
            _nguoiTimViec_ID = Value
        End Set
    End Property
    Public Property LoaiUngVien() As Integer
        Get
            Return _loaiUngVien
        End Get
        Set(ByVal Value As Integer)
            _loaiUngVien = Value
        End Set
    End Property
    Public Property TenDayDu As String
        Get
            Return _tenDayDu
        End Get
        Set(ByVal Value As String)
            _tenDayDu = Value
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
    Public Property GioiTinh As Integer
        Get
            Return _GioiTinh
        End Get
        Set(ByVal Value As Integer)
            _GioiTinh = Value
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
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property
    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(ByVal Value As String)
            _tel = Value
        End Set
    End Property
    Public Property NganhNghe As String
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As String)
            _nganhNghe = Value
        End Set
    End Property
    Public Property TrinhDoChuyenMon As String
        Get
            Return _trinhDoChuyenMon
        End Get
        Set(ByVal Value As String)
            _trinhDoChuyenMon = Value
        End Set
    End Property
    Public Property NamKinhNghiem As String
        Get
            Return _namKinhNghiem
        End Get
        Set(ByVal Value As String)
            _namKinhNghiem = Value
        End Set
    End Property
    Public Property ViTriUngTuyen As String
        Get
            Return _viTriUngTuyen
        End Get
        Set(ByVal Value As String)
            _viTriUngTuyen = Value
        End Set
    End Property
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
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
#End Region
End Class
Public Class CMS_ThongKeBaoCaoInfo
#Region "Private Members"
    Private _phienGD_ID As String = String.Empty
    Private _soBan As Integer
    Private _ThamGia As Integer
    Private _DNThamGia As Integer
    Private _Dat As Integer
    Private _KhongDat As Integer
    Private _GapLai As Integer
    Private _TrungTuyen As Integer
    Private _ViecLam As Integer
    Private _dndagioithieu As Integer
    Private _dnchuagioithieu As Integer
    Private _uvchuagioithieu As Integer
    Private _uvdagioithieu As Integer
    Private _sotintuyendung As Integer
    Private _soluongcantuyen As Integer
    Private _soNam As Integer
    Private _soNu As Integer
    Private _so0Nam As Integer
    Private _so1Nam As Integer
    Private _so2Nam As Integer
    Private _so3Nam As Integer
    Private _so4Nam As Integer
    Private _so5Nam As Integer
    Private _soKYC As Integer
    Private _ngaydienra As DateTime
#End Region
#Region "Public Properties"
    Public Property SoKYC As Integer
        Get
            Return _soKYC
        End Get
        Set(ByVal Value As Integer)
            _soKYC = Value
        End Set
    End Property
    Public Property So3Nam As Integer
        Get
            Return _so3Nam
        End Get
        Set(ByVal Value As Integer)
            _so3Nam = Value
        End Set
    End Property
    Public Property So4Nam As Integer
        Get
            Return _so4Nam
        End Get
        Set(ByVal Value As Integer)
            _so4Nam = Value
        End Set
    End Property
    Public Property So5Nam As Integer
        Get
            Return _so5Nam
        End Get
        Set(ByVal Value As Integer)
            _so5Nam = Value
        End Set
    End Property
    Public Property So2Nam As Integer
        Get
            Return _so2Nam
        End Get
        Set(ByVal Value As Integer)
            _so2Nam = Value
        End Set
    End Property
    Public Property So1Nam As Integer
        Get
            Return _so1Nam
        End Get
        Set(ByVal Value As Integer)
            _so1Nam = Value
        End Set
    End Property
    Public Property So0Nam As Integer
        Get
            Return _so0Nam
        End Get
        Set(ByVal Value As Integer)
            _so0Nam = Value
        End Set
    End Property
    Public Property SoNu As Integer
        Get
            Return _soNu
        End Get
        Set(ByVal Value As Integer)
            _soNu = Value
        End Set
    End Property
    Public Property SoNam As Integer
        Get
            Return _soNam
        End Get
        Set(ByVal Value As Integer)
            _soNam = Value
        End Set
    End Property
    Public Property Soluongcantuyen As Integer
        Get
            Return _soluongcantuyen
        End Get
        Set(ByVal Value As Integer)
            _soluongcantuyen = Value
        End Set
    End Property
    Public Property Sotintuyendung As Integer
        Get
            Return _sotintuyendung
        End Get
        Set(ByVal Value As Integer)
            _sotintuyendung = Value
        End Set
    End Property
    Public Property DNThamGia As Integer
        Get
            Return _DNThamGia
        End Get
        Set(ByVal Value As Integer)
            _DNThamGia = Value
        End Set
    End Property
    Public Property NgayDienRa As DateTime
        Get
            Return _ngaydienra
        End Get
        Set(ByVal Value As DateTime)
            _ngaydienra = Value
        End Set
    End Property
    Public Property Uvdagioithieu As Integer
        Get
            Return _uvdagioithieu
        End Get
        Set(ByVal Value As Integer)
            _uvdagioithieu = Value
        End Set
    End Property
    Public Property Uvchuagioithieu As Integer
        Get
            Return _uvchuagioithieu
        End Get
        Set(ByVal Value As Integer)
            _uvchuagioithieu = Value
        End Set
    End Property
    Public Property Dnchuagioithieu As Integer
        Get
            Return _dnchuagioithieu
        End Get
        Set(ByVal Value As Integer)
            _dnchuagioithieu = Value
        End Set
    End Property
    Public Property Dndagioithieu As Integer
        Get
            Return _dndagioithieu
        End Get
        Set(ByVal Value As Integer)
            _dndagioithieu = Value
        End Set
    End Property
    Public Property ViecLam As Integer
        Get
            Return _ViecLam
        End Get
        Set(ByVal Value As Integer)
            _ViecLam = Value
        End Set
    End Property
    Public Property ThamGia As Integer
        Get
            Return _ThamGia
        End Get
        Set(ByVal Value As Integer)
            _ThamGia = Value
        End Set
    End Property
    Public Property Dat As Integer
        Get
            Return _Dat
        End Get
        Set(ByVal Value As Integer)
            _Dat = Value
        End Set
    End Property
    Public Property KhongDat As Integer
        Get
            Return _KhongDat
        End Get
        Set(ByVal Value As Integer)
            _KhongDat = Value
        End Set
    End Property
    Public Property GapLai As Integer
        Get
            Return _GapLai
        End Get
        Set(ByVal Value As Integer)
            _GapLai = Value
        End Set
    End Property
    Public Property TrungTuyen As Integer
        Get
            Return _TrungTuyen
        End Get
        Set(ByVal Value As Integer)
            _TrungTuyen = Value
        End Set
    End Property
    Public Property SoBan As Integer
        Get
            Return _soBan
        End Get
        Set(ByVal Value As Integer)
            _soBan = Value
        End Set
    End Property
    Public Property PhienGD_ID As String
        Get
            Return _phienGD_ID
        End Get
        Set(ByVal Value As String)
            _phienGD_ID = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_UserWorkInfo
#Region "Private Members"
    Private _userWork_ID As String = String.Empty
    Private _ungVien_ID As String = String.Empty
    Private _work_ID As String = String.Empty
    Private _JobID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _createdBy As DateTime
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
    Public Property UserWork_ID As String
        Get
            Return _userWork_ID
        End Get
        Set(ByVal Value As String)
            _userWork_ID = Value
        End Set
    End Property
    Public Property UngVien_ID As String
        Get
            Return _ungVien_ID
        End Get
        Set(ByVal Value As String)
            _ungVien_ID = Value
        End Set
    End Property
    Public Property Job_ID As String
        Get
            Return _JobID
        End Get
        Set(ByVal Value As String)
            _JobID = Value
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
    Public Property DoanhNghiep_ID As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
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
#End Region
End Class
Public Class CMS_RegEmailInfo
    Public Property RegEmail_ID As String
    Public Property RegEmail As String
    Public Property RegDate As DateTime
    Public Property Total As Integer
End Class
Public Class CMS_ConEmailInfo
    Public Property ConEmail_ID As String
    Public Property Contents As String
    Public Property UserName As String
    Public Property SendDate As DateTime
    Public Property Total As Integer
End Class
Public Class CMS_VideoInfo
#Region "Private Members"
    Private _video_ID As String = String.Empty
    Private _topic_ID As String = String.Empty
    Private _video_Name As String = String.Empty
    Private _isType As Integer
    Private _toUrl As String = String.Empty
    Private _dupTitle As String = String.Empty
    Private _images As String = String.Empty
    Private _videoUrl As String = String.Empty
    Private _summary As String = String.Empty
    Private _contents As String = String.Empty
    Private _isView As Integer
    Private _isLike As Integer
    Private _isPublic As Boolean
    Private _userPublic As String = String.Empty
    Private _datePublic As DateTime
    Private _userName As String = String.Empty
    Private _createdBy As DateTime
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _portalId As Integer
    Private _isLang As String = String.Empty
    Private _total As Integer
    Public Property Topic_Name As String
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
    Public Property Video_ID As String
        Get
            Return _video_ID
        End Get
        Set(ByVal Value As String)
            _video_ID = Value
        End Set
    End Property
    Public Property Topic_ID As String
        Get
            Return _topic_ID
        End Get
        Set(ByVal Value As String)
            _topic_ID = Value
        End Set
    End Property
    Public Property Video_Name As String
        Get
            Return _video_Name
        End Get
        Set(ByVal Value As String)
            _video_Name = Value
        End Set
    End Property
    Public Property IsType() As Integer
        Get
            Return _isType
        End Get
        Set(ByVal Value As Integer)
            _isType = Value
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
    Public Property DupTitle As String
        Get
            Return _dupTitle
        End Get
        Set(ByVal Value As String)
            _dupTitle = Value
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
    Public Property VideoUrl As String
        Get
            Return _videoUrl
        End Get
        Set(ByVal Value As String)
            _videoUrl = Value
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
    Public Property IsView() As Integer
        Get
            Return _isView
        End Get
        Set(ByVal Value As Integer)
            _isView = Value
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
    Public Property IsPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal Value As Boolean)
            _isPublic = Value
        End Set
    End Property
    Public Property UserPublic As String
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
    Public Property UserName As String
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
    Public Property UpdatedBy() As DateTime
        Get
            Return _updatedBy
        End Get
        Set(ByVal Value As DateTime)
            _updatedBy = Value
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
    Public Property PortalId() As Integer
        Get
            Return _portalId
        End Get
        Set(ByVal Value As Integer)
            _portalId = Value
        End Set
    End Property
    Public Property IsLang As String
        Get
            Return _isLang
        End Get
        Set(ByVal Value As String)
            _isLang = Value
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
    Private _career_Logo As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _total As Integer
#End Region
#Region "Public Properties"
    Public Property Career_Logo As String
        Get
            Return _career_Logo
        End Get
        Set(ByVal Value As String)
            _career_Logo = Value
        End Set
    End Property
    Public Property ID As Integer
    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
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
    Public Property Career_Name As String
        Get
            Return _career_Name
        End Get
        Set(ByVal Value As String)
            _career_Name = Value
        End Set
    End Property
    Public Property Career_Code As String
        Get
            Return _career_Code
        End Get
        Set(ByVal Value As String)
            _career_Code = Value
        End Set
    End Property
    Public Property Career_Des As String
        Get
            Return _career_Des
        End Get
        Set(ByVal Value As String)
            _career_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_ExperienceInfo
#Region "Private Members"
    Private _experience_ID As String = String.Empty
    Private _experience_Name As String = String.Empty
    Private _experience_Code As String = String.Empty
    Private _experience_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
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
    Public Property Experience_ID As String
        Get
            Return _experience_ID
        End Get
        Set(ByVal Value As String)
            _experience_ID = Value
        End Set
    End Property
    Public Property Experience_Name As String
        Get
            Return _experience_Name
        End Get
        Set(ByVal Value As String)
            _experience_Name = Value
        End Set
    End Property
    Public Property Experience_Code As String
        Get
            Return _experience_Code
        End Get
        Set(ByVal Value As String)
            _experience_Code = Value
        End Set
    End Property
    Public Property Experience_Des As String
        Get
            Return _experience_Des
        End Get
        Set(ByVal Value As String)
            _experience_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_JobPlaceInfo
#Region "Private Members"
    Private _parent_ID As String = String.Empty
    Private _jobPlace_ID As String = String.Empty
    Private _jobPlace_Name As String = String.Empty
    Private _jobPlace_Code As String = String.Empty
    Private _jobPlace_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _total As Integer
#End Region
#Region "Public Properties"
    Public Property Parent_ID As String
        Get
            Return _parent_ID
        End Get
        Set(ByVal Value As String)
            _parent_ID = Value
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
    Public Property JobPlace_ID As String
        Get
            Return _jobPlace_ID
        End Get
        Set(ByVal Value As String)
            _jobPlace_ID = Value
        End Set
    End Property
    Public Property JobPlace_Name As String
        Get
            Return _jobPlace_Name
        End Get
        Set(ByVal Value As String)
            _jobPlace_Name = Value
        End Set
    End Property
    Public Property JobPlace_Code As String
        Get
            Return _jobPlace_Code
        End Get
        Set(ByVal Value As String)
            _jobPlace_Code = Value
        End Set
    End Property
    Public Property JobPlace_Des As String
        Get
            Return _jobPlace_Des
        End Get
        Set(ByVal Value As String)
            _jobPlace_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_NeedsInfo
#Region "Private Members"
    Private _needs_ID As String = String.Empty
    Private _needs_Name As String = String.Empty
    Private _needs_Code As String = String.Empty
    Private _needs_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
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
    Public Property Needs_ID As String
        Get
            Return _needs_ID
        End Get
        Set(ByVal Value As String)
            _needs_ID = Value
        End Set
    End Property
    Public Property Needs_Name As String
        Get
            Return _needs_Name
        End Get
        Set(ByVal Value As String)
            _needs_Name = Value
        End Set
    End Property
    Public Property Needs_Code As String
        Get
            Return _needs_Code
        End Get
        Set(ByVal Value As String)
            _needs_Code = Value
        End Set
    End Property
    Public Property Needs_Des As String
        Get
            Return _needs_Des
        End Get
        Set(ByVal Value As String)
            _needs_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_SalaryInfo
#Region "Private Members"
    Private _salary_ID As String = String.Empty
    Private _salary_Name As String = String.Empty
    Private _salary_Code As String = String.Empty
    Private _salary_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
    Private _total As Integer
    Private _idSend As Integer
#End Region
#Region "Public Properties"
    Public Property IdSend As Integer
        Get
            Return IdSend
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
    Public Property Salary_ID As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property
    Public Property Salary_Name As String
        Get
            Return _salary_Name
        End Get
        Set(ByVal Value As String)
            _salary_Name = Value
        End Set
    End Property
    Public Property Salary_Code As String
        Get
            Return _salary_Code
        End Get
        Set(ByVal Value As String)
            _salary_Code = Value
        End Set
    End Property
    Public Property Salary_Des As String
        Get
            Return _salary_Des
        End Get
        Set(ByVal Value As String)
            _salary_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_TypeOfInfo
#Region "Private Members"
    Private _typeOf_ID As String = String.Empty
    Private _typeOf_Name As String = String.Empty
    Private _typeOf_Code As String = String.Empty
    Private _typeOf_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdBy As DateTime
    Private _userName As String = String.Empty
    Private _updatedBy As DateTime
    Private _userUpdate As String = String.Empty
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
    Public Property TypeOf_ID As String
        Get
            Return _typeOf_ID
        End Get
        Set(ByVal Value As String)
            _typeOf_ID = Value
        End Set
    End Property
    Public Property TypeOf_Name As String
        Get
            Return _typeOf_Name
        End Get
        Set(ByVal Value As String)
            _typeOf_Name = Value
        End Set
    End Property
    Public Property TypeOf_Code As String
        Get
            Return _typeOf_Code
        End Get
        Set(ByVal Value As String)
            _typeOf_Code = Value
        End Set
    End Property
    Public Property TypeOf_Des As String
        Get
            Return _typeOf_Des
        End Get
        Set(ByVal Value As String)
            _typeOf_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region
End Class
Public Class RPT_DataInfo
#Region "Private Members"
    Private _iD As Integer
    Private _rpt_ID As Integer
    Private _cot_ID As Integer
    Private _dong_ID As Integer
    Private _giaTri As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
    Private _isFlag As Integer
    Private _IsCenter As Boolean
#End Region
#Region "Public Properties"
    Public Property IsCenter As Boolean
        Get
            Return _IsCenter
        End Get
        Set(ByVal Value As Boolean)
            _IsCenter = Value
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
    Public Property IsFlag() As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
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
    Public Property Rpt_ID() As Integer
        Get
            Return _rpt_ID
        End Get
        Set(ByVal Value As Integer)
            _rpt_ID = Value
        End Set
    End Property
    Public Property Cot_ID() As Integer
        Get
            Return _cot_ID
        End Get
        Set(ByVal Value As Integer)
            _cot_ID = Value
        End Set
    End Property
    Public Property Dong_ID() As Integer
        Get
            Return _dong_ID
        End Get
        Set(ByVal Value As Integer)
            _dong_ID = Value
        End Set
    End Property
    Public Property GiaTri() As String
        Get
            Return _giaTri
        End Get
        Set(ByVal Value As String)
            _giaTri = Value
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
Public Class RPT_LabelInfo
#Region "Private Members"
    Private _iD As Integer
    Private _rpt_ID As Integer
    Private _cot_ID As Integer
    Private _tieuDe As String = String.Empty
    Private _rowspan As Integer
    Private _colspan As Integer
    Private _IsColumn As Integer
    Private _isOrder As Integer
    Private _IsFlag As Integer
    Private _isRows As Integer
    Private _width As String = String.Empty
    Private _total As Integer
    Private _IsData As Boolean
#End Region
#Region "Public Properties"
    Public Property IsColumn As Integer
        Get
            Return _IsColumn
        End Get
        Set(ByVal Value As Integer)
            _IsColumn = Value
        End Set
    End Property
    Public Property IsFlag As Integer
        Get
            Return _IsFlag
        End Get
        Set(ByVal Value As Integer)
            _IsFlag = Value
        End Set
    End Property
    Public Property IsData As Boolean
        Get
            Return _IsData
        End Get
        Set(ByVal Value As Boolean)
            _IsData = Value
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
    Public Property Rpt_ID() As Integer
        Get
            Return _rpt_ID
        End Get
        Set(ByVal Value As Integer)
            _rpt_ID = Value
        End Set
    End Property
    Public Property Cot_ID() As Integer
        Get
            Return _cot_ID
        End Get
        Set(ByVal Value As Integer)
            _cot_ID = Value
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
    Public Property Rowspan() As Integer
        Get
            Return _rowspan
        End Get
        Set(ByVal Value As Integer)
            _rowspan = Value
        End Set
    End Property
    Public Property Colspan() As Integer
        Get
            Return _colspan
        End Get
        Set(ByVal Value As Integer)
            _colspan = Value
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
    Public Property IsRows() As Integer
        Get
            Return _isRows
        End Get
        Set(ByVal Value As Integer)
            _isRows = Value
        End Set
    End Property
    Public Property Width() As String
        Get
            Return _width
        End Get
        Set(ByVal Value As String)
            _width = Value
        End Set
    End Property
#End Region
End Class
Public Class RPT_ReportsInfo
#Region "Private Members"
    Private _rpt_ID As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _thonTo As Integer
    Private _namBC As Integer
    Private _total As Integer
    Private _Other As String
    Private _Rpt_Type As String
#End Region
#Region "Public Properties"
    Public Property Other As String
        Get
            Return _Other
        End Get
        Set(ByVal Value As String)
            _Other = Value
        End Set
    End Property
    Public Property Rpt_Type As String
        Get
            Return _Rpt_Type
        End Get
        Set(ByVal Value As String)
            _Rpt_Type = Value
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
    Public Property Rpt_ID() As Integer
        Get
            Return _rpt_ID
        End Get
        Set(ByVal Value As Integer)
            _rpt_ID = Value
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
    Public Property QuanHuyen() As Integer
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As Integer)
            _quanHuyen = Value
        End Set
    End Property
    Public Property XaPhuong() As Integer
        Get
            Return _xaPhuong
        End Get
        Set(ByVal Value As Integer)
            _xaPhuong = Value
        End Set
    End Property
    Public Property ThonTo() As Integer
        Get
            Return _thonTo
        End Get
        Set(ByVal Value As Integer)
            _thonTo = Value
        End Set
    End Property
    Public Property NamBC() As Integer
        Get
            Return _namBC
        End Get
        Set(ByVal Value As Integer)
            _namBC = Value
        End Set
    End Property
#End Region
End Class
Public Class RPT_RowsInfo
#Region "Private Members"
    Private _iD As Integer
    Private _rpt_ID As Integer
    Private _dong_ID As Integer
    Private _tieuDe As String = String.Empty
    Private _STT As String = String.Empty
    Private _isOrder As Integer
    Private _total As Integer
    Private _IsBold As Boolean
    Private _IsFlag As Integer
#End Region
#Region "Public Properties"
    Public Property STT() As String
        Get
            Return _STT
        End Get
        Set(ByVal Value As String)
            _STT = Value
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
    Public Property IsBold() As Boolean
        Get
            Return _IsBold
        End Get
        Set(ByVal Value As Boolean)
            _IsBold = Value
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
    Public Property IsFlag() As Integer
        Get
            Return _IsFlag
        End Get
        Set(ByVal Value As Integer)
            _IsFlag = Value
        End Set
    End Property
    Public Property Rpt_ID() As Integer
        Get
            Return _rpt_ID
        End Get
        Set(ByVal Value As Integer)
            _rpt_ID = Value
        End Set
    End Property
    Public Property Dong_ID() As Integer
        Get
            Return _dong_ID
        End Get
        Set(ByVal Value As Integer)
            _dong_ID = Value
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
Public Class CMS_DashInfo
#Region "Private Members"
    Private _vldang As String = String.Empty
    Private _vlungtuyen As String = String.Empty
    Private _vldaluu As String = String.Empty
    Private _vldamoi As String = String.Empty
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
    Public Property DashNum8 As String
        Get
            Return _dashNum8
        End Get
        Set(ByVal Value As String)
            _dashNum8 = Value
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
    Public Property VLDang As String
        Get
            Return _vldang
        End Get
        Set(ByVal Value As String)
            _vldang = Value
        End Set
    End Property
    Public Property VLUngTuyen As String
        Get
            Return _vlungtuyen
        End Get
        Set(ByVal Value As String)
            _vlungtuyen = Value
        End Set
    End Property
    Public Property VLDaLuu As String
        Get
            Return _vldaluu
        End Get
        Set(ByVal Value As String)
            _vldaluu = Value
        End Set
    End Property
    Public Property Vldamoi As String
        Get
            Return _vldamoi
        End Get
        Set(ByVal Value As String)
            _vldamoi = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_WorkCareerInfo
#Region "Private Members"
    Private _iD As Integer
    Private _work_ID As String = String.Empty
    Private _career_ID As String = String.Empty
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
    Public Property Work_ID As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
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
Public Class CMS_SearchInfo
#Region "Private Members"
    Private _iD As Integer
    Private _tuKhoa As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _nganhNghe As String = String.Empty
    Private _viTri As String = String.Empty
    Private _mucLuong As String = String.Empty
    Private _trinhDo As String = String.Empty
    Private _kinhNghiem As String = String.Empty
    Private _gioiTinh As String = String.Empty
    Private _chucVu As String = String.Empty
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
    Public Property TuKhoa As String
        Get
            Return _tuKhoa
        End Get
        Set(ByVal Value As String)
            _tuKhoa = Value
        End Set
    End Property
    Public Property TinhTP As String
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As String)
            _tinhTP = Value
        End Set
    End Property
    Public Property NganhNghe As String
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As String)
            _nganhNghe = Value
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
    Public Property MucLuong As String
        Get
            Return _mucLuong
        End Get
        Set(ByVal Value As String)
            _mucLuong = Value
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
    Public Property KinhNghiem As String
        Get
            Return _kinhNghiem
        End Get
        Set(ByVal Value As String)
            _kinhNghiem = Value
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
    Public Property ChucVu As String
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As String)
            _chucVu = Value
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
Public Class CMS_SysStatisticInfo
#Region "Private Members"
    Private _portalID As Integer
    Private _TongSoTruyCap As Integer
    Private _HoSoTimViec As Integer
    Private _NhaTuyenDung As Integer
    Private _TinTuyenDung As Integer
#End Region
#Region "Public Properties"
    Public Property TongSoTruyCap As Integer
        Get
            Return _TongSoTruyCap
        End Get
        Set(ByVal Value As Integer)
            _TongSoTruyCap = Value
        End Set
    End Property
    Public Property HoSoTimViec() As Integer
        Get
            Return _HoSoTimViec
        End Get
        Set(ByVal Value As Integer)
            _HoSoTimViec = Value
        End Set
    End Property
    Public Property TinTuyenDung() As Integer
        Get
            Return _TinTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _TinTuyenDung = Value
        End Set
    End Property
    Public Property NhaTuyenDung() As Integer
        Get
            Return _NhaTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _NhaTuyenDung = Value
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
    Private _work_ID As String = String.Empty
#End Region
#Region "Public Properties"
    'Public Property ID As Integer
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
    Public Property Work_ID As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
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
Public Class HoSoBHTNInfo
    Public Property IdNghe() As Integer
    Public Property GTVLKhac() As String
    Public Property DieuKienLamViec() As String
    Public Property TrinhDoNgoaiNgu() As String
    Public Property TrinhDoTinHoc() As String
    Public Property KhaNangNoiTroi() As String
    Public Property Kynangnghe() As String
    Public Property GTVLNoiLamViecMongmuon_TenTinh() As String
    Public Property GTVLNoiLamViecMongmuon_TenHuyen() As String
    Public Property Kinhnghiemlamviec() As String
    Public Property IDGTVLNganhngheMongmuon() As Integer
    Public Property GTVLMucLuong() As String
    Public Property GTVLNganhngheMongmuon() As String
    Public Property GTVLViTri() As String
    Public Property Id() As Guid
    Public Property HoTen() As String
    Public Property NgaySinh() As String
    Public Property GioiTinh() As Boolean
    Public Property CMND() As String
    Public Property NgayCapCMND() As DateTime
    Public Property SoSoBHXH() As String
    Public Property NoiCapCMND() As String
    Public Property Email() As String
    Public Property SDT() As String
    Public Property TonGiao() As String
    Public Property DanToc() As String
    Public Property GDPhoThong() As String
    Public Property TrinhDoCMKT() As String
    Public Property Xeploai As Integer
    Public Property Donvidaotao As String
    Public Property Chuyennganhdaotao As String
    Public Property DiaChiMongMuon_full As String
    Public Property Tuoi As Integer
    Public Property Sinhnam As Integer
    Public Property Gioitinh_Name As String
    Public Property Loailaodong_Name As String
    Public Property TotalRow As Integer
End Class
Public Class HoSoBHTN_QTDaoTao
    Public Property DonViDaoTao As String
    Public Property ChuyenNganhDaoTao As String
    Public Property TrinhDoDaoTao As String
    Public Property ThoiGianDaoTao As String
End Class
Public Class HoSoBHTN_QTLamViec
    Public Property TenDonVi As String
    Public Property ThoiGianLamViec As String
    Public Property ViTriDaLam As String
End Class
Public Class DanhMucChungBHTN
    Public Property Id As Integer
    Public Property Name As String
    Public Property Code As String
    Public Property Order As Integer
    Public Property Status As Boolean
    Public Property Portalid As Integer
    Property IsDeleted As Boolean
End Class

Public Class ND23_PLIInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _cMND As String = String.Empty
    Private _SoBHXH As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _danToc As Integer
    Private _tonGiao As Integer
    Private _maTinh_TT As Integer
    Private _maHuyen_TT As Integer
    Private _maXa_TT As Integer
    Private _diaChi_TT As String = String.Empty
    Private _maTinh_HN As Integer
    Private _maHuyen_HN As Integer
    Private _maXa_HN As Integer
    Private _diaChi_HN As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _lienHeKhac As String = String.Empty
    Private _dTUT_NKT As Boolean
    Private _dTUT_DTTS As Boolean
    Private _dTUT_HN As Boolean
    Private _dTUT_BODOI As Boolean
    Private _dTUT_KHAC As Boolean
    Private _dTUT_KHAC_TEXT As String = String.Empty
    Private _tDHV_CTH As Boolean
    Private _tDHV_TH As Boolean
    Private _tDHV_THCS As Boolean
    Private _tDHV_THPT As Boolean
    Private _tDCM_CQDT As Boolean
    Private _tDCM_CNKTKB As Boolean
    Private _tDCM_SOCAP As Boolean
    Private _tDCM_TRUNGCAP As Boolean
    Private _tDCM_CAODANG As Boolean
    Private _tDCM_DH As Boolean
    Private _tDCM_THS As Boolean
    Private _tDCM_TS As Boolean
    Private _tDCM_KHAC As String = String.Empty
    Private _tDCMK_CQDT As Boolean
    Private _tDCMK_CNKTKB As Boolean
    Private _tDCMK_SOCAP As Boolean
    Private _tDCMK_TRUNGCAP As Boolean
    Private _tDCMK_CAODANG As Boolean
    Private _tDCMK_DH As Boolean
    Private _tDCMK_THS As Boolean
    Private _tDCMK_TS1 As Boolean
    Private _tDCMK_KHAC As String = String.Empty
    Private _tDCM_KHAC1 As String = String.Empty
    Private _tDCM_KHAC2 As String = String.Empty
    Private _tDKNN As String = String.Empty
    Private _bAC_NGHE As String = String.Empty
    Private _tDNN1 As String = String.Empty
    Private _tDNN1_CC As String = String.Empty
    Private _tDNN1_MUCDO As Byte
    Private _tDNN2 As String = String.Empty
    Private _tDNN2_CC As String = String.Empty
    Private _tDNN2_MUCDO As Byte
    Private _tDTH As Boolean
    Private _tDTH_CC As String = String.Empty
    Private _tDTH_MUCDO As Byte
    Private _tDTHK As Boolean
    Private _tDTHK_CC As String = String.Empty
    Private _tDTHK_MUCDO As Byte
    Private _kNM_GT As Boolean
    Private _kNM_TT As Boolean
    Private _kNM_QLTG As Boolean
    Private _kNM_QLNS As Boolean
    Private _kNM_THBC As Boolean
    Private _kNM_THICHUNG As Boolean
    Private _kNM_LVNHOM As Boolean
    Private _kNM_LVDOCLAP As Boolean
    Private _kNM_CHIUAPLUC As Boolean
    Private _kNM_THEODOI As Boolean
    Private _kNM_TUDUYPB As Boolean
    Private _kNM_KHAC As Boolean
    Private _kNM_KHAC_TEXT As String = String.Empty
    Private _kNLV1_TENDV As String = String.Empty
    Private _kNLV1_CHUCVU As String = String.Empty
    Private _kNLV1_CV As String = String.Empty
    Private _kNLV1_TG As String = String.Empty
    Private _kNLV2_TENDV As String = String.Empty
    Private _kNLV2_CHUCVU As String = String.Empty
    Private _kNLV2_CV As String = String.Empty
    Private _kNLV2_TG As String = String.Empty
    Private _kNLV3_TENDV As String = String.Empty
    Private _kNLV3_CHUCVU As String = String.Empty
    Private _kNLV3_CV As String = String.Empty
    Private _kNLV3_TG As String = String.Empty
    Private _lVNN As Boolean
    Private _lVNN_TEXT As String = String.Empty
    Private _dKDV_CSPL As Boolean
    Private _dKDV_TVVL As Boolean
    Private _dKDV_TVDTN As Boolean
    Private _dKDV_TVL As Boolean
    Private _dKDV_KHAC As Boolean
    Private _dKDV_KHAC_TEXT As String = String.Empty
    Private _thoiGianDangKy As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property SoBHXH() As String
        Get
            Return _SoBHXH
        End Get
        Set(ByVal value As String)
            _SoBHXH = value
        End Set
    End Property
    Private _YearId As Integer
    Public Property YearId() As Integer
        Get
            Return _YearId
        End Get
        Set(ByVal value As Integer)
            _YearId = value
        End Set
    End Property
    Public Property ThoiGianDangKy As DateTime
        Get
            Return _thoiGianDangKy
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianDangKy = Value
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
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
    Public Property CMND() As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
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
    Public Property DanToc() As Integer
        Get
            Return _danToc
        End Get
        Set(ByVal Value As Integer)
            _danToc = Value
        End Set
    End Property
    Public Property TonGiao() As Integer
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As Integer)
            _tonGiao = Value
        End Set
    End Property
    Public Property MaTinh_TT() As Integer
        Get
            Return _maTinh_TT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_TT = Value
        End Set
    End Property
    Public Property MaHuyen_TT() As Integer
        Get
            Return _maHuyen_TT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_TT = Value
        End Set
    End Property
    Public Property MaXa_TT() As Integer
        Get
            Return _maXa_TT
        End Get
        Set(ByVal Value As Integer)
            _maXa_TT = Value
        End Set
    End Property
    Public Property DiaChi_TT() As String
        Get
            Return _diaChi_TT
        End Get
        Set(ByVal Value As String)
            _diaChi_TT = Value
        End Set
    End Property
    Public Property MaTinh_HN() As Integer
        Get
            Return _maTinh_HN
        End Get
        Set(ByVal Value As Integer)
            _maTinh_HN = Value
        End Set
    End Property
    Public Property MaHuyen_HN() As Integer
        Get
            Return _maHuyen_HN
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_HN = Value
        End Set
    End Property
    Public Property MaXa_HN() As Integer
        Get
            Return _maXa_HN
        End Get
        Set(ByVal Value As Integer)
            _maXa_HN = Value
        End Set
    End Property
    Public Property DiaChi_HN() As String
        Get
            Return _diaChi_HN
        End Get
        Set(ByVal Value As String)
            _diaChi_HN = Value
        End Set
    End Property
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
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
    Public Property LienHeKhac() As String
        Get
            Return _lienHeKhac
        End Get
        Set(ByVal Value As String)
            _lienHeKhac = Value
        End Set
    End Property
    Public Property DTUT_NKT() As Boolean
        Get
            Return _dTUT_NKT
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_NKT = Value
        End Set
    End Property
    Public Property DTUT_DTTS() As Boolean
        Get
            Return _dTUT_DTTS
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_DTTS = Value
        End Set
    End Property
    Public Property DTUT_HN() As Boolean
        Get
            Return _dTUT_HN
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_HN = Value
        End Set
    End Property
    Public Property DTUT_BODOI() As Boolean
        Get
            Return _dTUT_BODOI
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_BODOI = Value
        End Set
    End Property
    Public Property DTUT_KHAC() As Boolean
        Get
            Return _dTUT_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_KHAC = Value
        End Set
    End Property
    Public Property DTUT_KHAC_TEXT() As String
        Get
            Return _dTUT_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _dTUT_KHAC_TEXT = Value
        End Set
    End Property
    Public Property TDHV_CTH() As Boolean
        Get
            Return _tDHV_CTH
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_CTH = Value
        End Set
    End Property
    Public Property TDHV_TH() As Boolean
        Get
            Return _tDHV_TH
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_TH = Value
        End Set
    End Property
    Public Property TDHV_THCS() As Boolean
        Get
            Return _tDHV_THCS
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_THCS = Value
        End Set
    End Property
    Public Property TDHV_THPT() As Boolean
        Get
            Return _tDHV_THPT
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_THPT = Value
        End Set
    End Property
    Public Property TDCM_CQDT() As Boolean
        Get
            Return _tDCM_CQDT
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CQDT = Value
        End Set
    End Property
    Public Property TDCM_CNKTKB() As Boolean
        Get
            Return _tDCM_CNKTKB
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CNKTKB = Value
        End Set
    End Property
    Public Property TDCM_SOCAP() As Boolean
        Get
            Return _tDCM_SOCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_SOCAP = Value
        End Set
    End Property
    Public Property TDCM_TRUNGCAP() As Boolean
        Get
            Return _tDCM_TRUNGCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_TRUNGCAP = Value
        End Set
    End Property
    Public Property TDCM_CAODANG() As Boolean
        Get
            Return _tDCM_CAODANG
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CAODANG = Value
        End Set
    End Property
    Public Property TDCM_DH() As Boolean
        Get
            Return _tDCM_DH
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_DH = Value
        End Set
    End Property
    Public Property TDCM_THS() As Boolean
        Get
            Return _tDCM_THS
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_THS = Value
        End Set
    End Property
    Public Property TDCM_TS() As Boolean
        Get
            Return _tDCM_TS
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_TS = Value
        End Set
    End Property
    Public Property TDCM_KHAC() As String
        Get
            Return _tDCM_KHAC
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC = Value
        End Set
    End Property
    Public Property TDCMK_CQDT() As Boolean
        Get
            Return _tDCMK_CQDT
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_CQDT = Value
        End Set
    End Property
    Public Property TDCMK_CNKTKB() As Boolean
        Get
            Return _tDCMK_CNKTKB
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_CNKTKB = Value
        End Set
    End Property
    Public Property TDCMK_SOCAP() As Boolean
        Get
            Return _tDCMK_SOCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_SOCAP = Value
        End Set
    End Property
    Public Property TDCMK_TRUNGCAP() As Boolean
        Get
            Return _tDCMK_TRUNGCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_TRUNGCAP = Value
        End Set
    End Property
    Public Property TDCMK_CAODANG() As Boolean
        Get
            Return _tDCMK_CAODANG
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_CAODANG = Value
        End Set
    End Property
    Public Property TDCMK_DH() As Boolean
        Get
            Return _tDCMK_DH
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_DH = Value
        End Set
    End Property
    Public Property TDCMK_THS() As Boolean
        Get
            Return _tDCMK_THS
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_THS = Value
        End Set
    End Property
    Public Property TDCMK_TS1() As Boolean
        Get
            Return _tDCMK_TS1
        End Get
        Set(ByVal Value As Boolean)
            _tDCMK_TS1 = Value
        End Set
    End Property
    Public Property TDCMK_KHAC() As String
        Get
            Return _tDCMK_KHAC
        End Get
        Set(ByVal Value As String)
            _tDCMK_KHAC = Value
        End Set
    End Property
    Public Property TDCM_KHAC1() As String
        Get
            Return _tDCM_KHAC1
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC1 = Value
        End Set
    End Property
    Public Property TDCM_KHAC2() As String
        Get
            Return _tDCM_KHAC2
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC2 = Value
        End Set
    End Property
    Public Property TDKNN() As String
        Get
            Return _tDKNN
        End Get
        Set(ByVal Value As String)
            _tDKNN = Value
        End Set
    End Property
    Public Property BAC_NGHE() As String
        Get
            Return _bAC_NGHE
        End Get
        Set(ByVal Value As String)
            _bAC_NGHE = Value
        End Set
    End Property
    Public Property TDNN1() As String
        Get
            Return _tDNN1
        End Get
        Set(ByVal Value As String)
            _tDNN1 = Value
        End Set
    End Property
    Public Property TDNN1_CC() As String
        Get
            Return _tDNN1_CC
        End Get
        Set(ByVal Value As String)
            _tDNN1_CC = Value
        End Set
    End Property
    Public Property TDNN1_MUCDO() As Byte
        Get
            Return _tDNN1_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDNN1_MUCDO = Value
        End Set
    End Property
    Public Property TDNN2() As String
        Get
            Return _tDNN2
        End Get
        Set(ByVal Value As String)
            _tDNN2 = Value
        End Set
    End Property
    Public Property TDNN2_CC() As String
        Get
            Return _tDNN2_CC
        End Get
        Set(ByVal Value As String)
            _tDNN2_CC = Value
        End Set
    End Property
    Public Property TDNN2_MUCDO() As Byte
        Get
            Return _tDNN2_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDNN2_MUCDO = Value
        End Set
    End Property
    Public Property TDTH() As Boolean
        Get
            Return _tDTH
        End Get
        Set(ByVal Value As Boolean)
            _tDTH = Value
        End Set
    End Property
    Public Property TDTH_CC() As String
        Get
            Return _tDTH_CC
        End Get
        Set(ByVal Value As String)
            _tDTH_CC = Value
        End Set
    End Property
    Public Property TDTH_MUCDO() As Byte
        Get
            Return _tDTH_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDTH_MUCDO = Value
        End Set
    End Property
    Public Property TDTHK() As Boolean
        Get
            Return _tDTHK
        End Get
        Set(ByVal Value As Boolean)
            _tDTHK = Value
        End Set
    End Property
    Public Property TDTHK_CC() As String
        Get
            Return _tDTHK_CC
        End Get
        Set(ByVal Value As String)
            _tDTHK_CC = Value
        End Set
    End Property
    Public Property TDTHK_MUCDO() As Byte
        Get
            Return _tDTHK_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDTHK_MUCDO = Value
        End Set
    End Property
    Public Property KNM_GT() As Boolean
        Get
            Return _kNM_GT
        End Get
        Set(ByVal Value As Boolean)
            _kNM_GT = Value
        End Set
    End Property
    Public Property KNM_TT() As Boolean
        Get
            Return _kNM_TT
        End Get
        Set(ByVal Value As Boolean)
            _kNM_TT = Value
        End Set
    End Property
    Public Property KNM_QLTG() As Boolean
        Get
            Return _kNM_QLTG
        End Get
        Set(ByVal Value As Boolean)
            _kNM_QLTG = Value
        End Set
    End Property
    Public Property KNM_QLNS() As Boolean
        Get
            Return _kNM_QLNS
        End Get
        Set(ByVal Value As Boolean)
            _kNM_QLNS = Value
        End Set
    End Property
    Public Property KNM_THBC() As Boolean
        Get
            Return _kNM_THBC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THBC = Value
        End Set
    End Property
    Public Property KNM_THICHUNG() As Boolean
        Get
            Return _kNM_THICHUNG
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THICHUNG = Value
        End Set
    End Property
    Public Property KNM_LVNHOM() As Boolean
        Get
            Return _kNM_LVNHOM
        End Get
        Set(ByVal Value As Boolean)
            _kNM_LVNHOM = Value
        End Set
    End Property
    Public Property KNM_LVDOCLAP() As Boolean
        Get
            Return _kNM_LVDOCLAP
        End Get
        Set(ByVal Value As Boolean)
            _kNM_LVDOCLAP = Value
        End Set
    End Property
    Public Property KNM_CHIUAPLUC() As Boolean
        Get
            Return _kNM_CHIUAPLUC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_CHIUAPLUC = Value
        End Set
    End Property
    Public Property KNM_THEODOI() As Boolean
        Get
            Return _kNM_THEODOI
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THEODOI = Value
        End Set
    End Property
    Public Property KNM_TUDUYPB() As Boolean
        Get
            Return _kNM_TUDUYPB
        End Get
        Set(ByVal Value As Boolean)
            _kNM_TUDUYPB = Value
        End Set
    End Property
    Public Property KNM_KHAC() As Boolean
        Get
            Return _kNM_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_KHAC = Value
        End Set
    End Property
    Public Property KNM_KHAC_TEXT() As String
        Get
            Return _kNM_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _kNM_KHAC_TEXT = Value
        End Set
    End Property
    Public Property KNLV1_TENDV() As String
        Get
            Return _kNLV1_TENDV
        End Get
        Set(ByVal Value As String)
            _kNLV1_TENDV = Value
        End Set
    End Property
    Public Property KNLV1_CHUCVU() As String
        Get
            Return _kNLV1_CHUCVU
        End Get
        Set(ByVal Value As String)
            _kNLV1_CHUCVU = Value
        End Set
    End Property
    Public Property KNLV1_CV() As String
        Get
            Return _kNLV1_CV
        End Get
        Set(ByVal Value As String)
            _kNLV1_CV = Value
        End Set
    End Property
    Public Property KNLV1_TG() As String
        Get
            Return _kNLV1_TG
        End Get
        Set(ByVal Value As String)
            _kNLV1_TG = Value
        End Set
    End Property
    Public Property KNLV2_TENDV() As String
        Get
            Return _kNLV2_TENDV
        End Get
        Set(ByVal Value As String)
            _kNLV2_TENDV = Value
        End Set
    End Property
    Public Property KNLV2_CHUCVU() As String
        Get
            Return _kNLV2_CHUCVU
        End Get
        Set(ByVal Value As String)
            _kNLV2_CHUCVU = Value
        End Set
    End Property
    Public Property KNLV2_CV() As String
        Get
            Return _kNLV2_CV
        End Get
        Set(ByVal Value As String)
            _kNLV2_CV = Value
        End Set
    End Property
    Public Property KNLV2_TG() As String
        Get
            Return _kNLV2_TG
        End Get
        Set(ByVal Value As String)
            _kNLV2_TG = Value
        End Set
    End Property
    Public Property KNLV3_TENDV() As String
        Get
            Return _kNLV3_TENDV
        End Get
        Set(ByVal Value As String)
            _kNLV3_TENDV = Value
        End Set
    End Property
    Public Property KNLV3_CHUCVU() As String
        Get
            Return _kNLV3_CHUCVU
        End Get
        Set(ByVal Value As String)
            _kNLV3_CHUCVU = Value
        End Set
    End Property
    Public Property KNLV3_CV() As String
        Get
            Return _kNLV3_CV
        End Get
        Set(ByVal Value As String)
            _kNLV3_CV = Value
        End Set
    End Property
    Public Property KNLV3_TG() As String
        Get
            Return _kNLV3_TG
        End Get
        Set(ByVal Value As String)
            _kNLV3_TG = Value
        End Set
    End Property
    Public Property LVNN() As Boolean
        Get
            Return _lVNN
        End Get
        Set(ByVal Value As Boolean)
            _lVNN = Value
        End Set
    End Property
    Public Property LVNN_TEXT() As String
        Get
            Return _lVNN_TEXT
        End Get
        Set(ByVal Value As String)
            _lVNN_TEXT = Value
        End Set
    End Property
    Public Property DKDV_CSPL() As Boolean
        Get
            Return _dKDV_CSPL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_CSPL = Value
        End Set
    End Property
    Public Property DKDV_TVVL() As Boolean
        Get
            Return _dKDV_TVVL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVVL = Value
        End Set
    End Property
    Public Property DKDV_TVDTN() As Boolean
        Get
            Return _dKDV_TVDTN
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVDTN = Value
        End Set
    End Property
    Public Property DKDV_TVL() As Boolean
        Get
            Return _dKDV_TVL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVL = Value
        End Set
    End Property
    Public Property DKDV_KHAC() As Boolean
        Get
            Return _dKDV_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_KHAC = Value
        End Set
    End Property
    Public Property DKDV_KHAC_TEXT() As String
        Get
            Return _dKDV_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _dKDV_KHAC_TEXT = Value
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
Public Class ND23_PLIAInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _iDPLI As Integer
    Private _cMND As String = String.Empty
    Private _vLMM As String = String.Empty
    Private _lHDN_NN As Boolean
    Private _lHDN_NGNN As Boolean
    Private _lHDN_VDTNN As Boolean
    Private _tenCongViec As String = String.Empty
    Private _moTaCongViec As String = String.Empty
    Private _maNghe As String = String.Empty
    Private _mN_CAP1 As String = String.Empty
    Private _mN_CAP2 As String = String.Empty
    Private _mN_CAP3 As String = String.Empty
    Private _mN_CAP4 As String = String.Empty
    Private _cV_NV As Boolean
    Private _cV_QL As Boolean
    Private _cV_LD As Boolean
    Private _cV_KHAC As Boolean
    Private _cV_KHAC_TEXT As String = String.Empty
    Private _kN_KC As Boolean
    Private _kN_DUOI1NAM As Boolean
    Private _kN_1DEN2NAM As Boolean
    Private _kN_2DEN5NAM As Boolean
    Private _kN_TREN5NAM As Boolean
    Private _nLVUT1_TINH As String = String.Empty
    Private _nLVUT1_QHKCN As String = String.Empty
    Private _nLVUT2_TINH As String = String.Empty
    Private _nLVUT2_QHKCN As String = String.Empty
    Private _lHD_KXD As Boolean
    Private _lHD_DUOI12T As Boolean
    Private _lHD_12DEN36 As Boolean
    Private _kNDU_LC As Boolean
    Private _kNDU_CT As Boolean
    Private _kNDU_BP As Boolean
    Private _hTLV_TTG As Boolean
    Private _hTLV_BTG As Boolean
    Private _mDLV_LD As Boolean
    Private _mDLV_TT As Boolean
    Private _mDLV_LT As Boolean
    Private _mL_THANG As String = String.Empty
    Private _mL_DUOI5 As Boolean
    Private _mL_5DEN10 As Boolean
    Private _mL_10DEN20 As Boolean
    Private _mL_20DEN50 As Boolean
    Private _mL_TREN50 As Boolean
    Private _mL_NGAY As Boolean
    Private _mL_NGAY_TEXT As String = String.Empty
    Private _mL_GIO As Boolean
    Private _mL_GIO_TEXT As String = String.Empty
    Private _mL_THOATHUAN As Boolean
    Private _mL_HOAHONG As Boolean
    Private _hTA_1BUA As Boolean
    Private _hTA_2BUA As Boolean
    Private _hTA_3BUA As Boolean
    Private _hTA_TIEN As Boolean
    Private _pC_BHXH As Boolean
    Private _pC_BHNT As Boolean
    Private _pC_THOIVIEC As Boolean
    Private _pC_NHATRE As Boolean
    Private _pC_XE As Boolean
    Private _pC_HOTRODILAI As Boolean
    Private _pC_KTXH As Boolean
    Private _pC_HTNO As Boolean
    Private _pC_DAOTAO As Boolean
    Private _pC_NKT As Boolean
    Private _pC_CHTT As Boolean
    Private _pC_KHAC As Boolean
    Private _pC_KHAC_TEXT As String = String.Empty
    Private _nLV_TN As Boolean
    Private _nLV_NT As Boolean
    Private _nLV_HH As Boolean
    Private _tLN_DUOI5 As Boolean
    Private _tLN_5DEN20 As Boolean
    Private _tLN_TREN20 As Boolean
    Private _dILAI_KC As Boolean
    Private _dILAI_TB As Boolean
    Private _dILAI_NHIEU As Boolean
    Private _nGHENOI_KCT As Boolean
    Private _nGHENOI_CB As Boolean
    Private _nGHENOI_QT As Boolean
    Private _tHILUC_BT As Boolean
    Private _tHILUC_CHITIET As Boolean
    Private _tHAOTACTAY_VL As Boolean
    Private _tHAOTACTAY_VN As Boolean
    Private _tHAOTACTAY_VRN As Boolean
    Private _dUNGTAY_2TAY As Boolean
    Private _dUNGTAY_DKC2TAY As Boolean
    Private _dUNGTAY_1TAY As Boolean
    Private _dUNGTAY_TRAI As Boolean
    Private _dUNGTAY_PHAI As Boolean
    Private _sANSANG_LVN As Boolean
    Private _sANSANG_LVS As Boolean
    Private _sANSANG_LVS_TEXT As String = String.Empty
    Private _hTTD_TT As Boolean
    Private _hTTD_DT As Boolean
    Private _hTTD_PV As Boolean
    Private _hTTD_CV As Boolean
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
        End Set
    End Property
    Public Property IDPLI() As Integer
        Get
            Return _iDPLI
        End Get
        Set(ByVal Value As Integer)
            _iDPLI = Value
        End Set
    End Property
    Public Property CMND() As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property VLMM() As String
        Get
            Return _vLMM
        End Get
        Set(ByVal Value As String)
            _vLMM = Value
        End Set
    End Property
    Public Property LHDN_NN() As Boolean
        Get
            Return _lHDN_NN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_NN = Value
        End Set
    End Property
    Public Property LHDN_NGNN() As Boolean
        Get
            Return _lHDN_NGNN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_NGNN = Value
        End Set
    End Property
    Public Property LHDN_VDTNN() As Boolean
        Get
            Return _lHDN_VDTNN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_VDTNN = Value
        End Set
    End Property
    Public Property TenCongViec() As String
        Get
            Return _tenCongViec
        End Get
        Set(ByVal Value As String)
            _tenCongViec = Value
        End Set
    End Property
    Public Property MoTaCongViec() As String
        Get
            Return _moTaCongViec
        End Get
        Set(ByVal Value As String)
            _moTaCongViec = Value
        End Set
    End Property
    Public Property MaNghe() As String
        Get
            Return _maNghe
        End Get
        Set(ByVal Value As String)
            _maNghe = Value
        End Set
    End Property
    Public Property MN_CAP1() As String
        Get
            Return _mN_CAP1
        End Get
        Set(ByVal Value As String)
            _mN_CAP1 = Value
        End Set
    End Property
    Public Property MN_CAP2() As String
        Get
            Return _mN_CAP2
        End Get
        Set(ByVal Value As String)
            _mN_CAP2 = Value
        End Set
    End Property
    Public Property MN_CAP3() As String
        Get
            Return _mN_CAP3
        End Get
        Set(ByVal Value As String)
            _mN_CAP3 = Value
        End Set
    End Property
    Public Property MN_CAP4() As String
        Get
            Return _mN_CAP4
        End Get
        Set(ByVal Value As String)
            _mN_CAP4 = Value
        End Set
    End Property
    Public Property CV_NV() As Boolean
        Get
            Return _cV_NV
        End Get
        Set(ByVal Value As Boolean)
            _cV_NV = Value
        End Set
    End Property
    Public Property CV_QL() As Boolean
        Get
            Return _cV_QL
        End Get
        Set(ByVal Value As Boolean)
            _cV_QL = Value
        End Set
    End Property
    Public Property CV_LD() As Boolean
        Get
            Return _cV_LD
        End Get
        Set(ByVal Value As Boolean)
            _cV_LD = Value
        End Set
    End Property
    Public Property CV_KHAC() As Boolean
        Get
            Return _cV_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _cV_KHAC = Value
        End Set
    End Property
    Public Property CV_KHAC_TEXT() As String
        Get
            Return _cV_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _cV_KHAC_TEXT = Value
        End Set
    End Property
    Public Property KN_KC() As Boolean
        Get
            Return _kN_KC
        End Get
        Set(ByVal Value As Boolean)
            _kN_KC = Value
        End Set
    End Property
    Public Property KN_DUOI1NAM() As Boolean
        Get
            Return _kN_DUOI1NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_DUOI1NAM = Value
        End Set
    End Property
    Public Property KN_1DEN2NAM() As Boolean
        Get
            Return _kN_1DEN2NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_1DEN2NAM = Value
        End Set
    End Property
    Public Property KN_2DEN5NAM() As Boolean
        Get
            Return _kN_2DEN5NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_2DEN5NAM = Value
        End Set
    End Property
    Public Property KN_TREN5NAM() As Boolean
        Get
            Return _kN_TREN5NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_TREN5NAM = Value
        End Set
    End Property
    Public Property NLVUT1_TINH() As String
        Get
            Return _nLVUT1_TINH
        End Get
        Set(ByVal Value As String)
            _nLVUT1_TINH = Value
        End Set
    End Property
    Public Property NLVUT1_QHKCN() As String
        Get
            Return _nLVUT1_QHKCN
        End Get
        Set(ByVal Value As String)
            _nLVUT1_QHKCN = Value
        End Set
    End Property
    Public Property NLVUT2_TINH() As String
        Get
            Return _nLVUT2_TINH
        End Get
        Set(ByVal Value As String)
            _nLVUT2_TINH = Value
        End Set
    End Property
    Public Property NLVUT2_QHKCN() As String
        Get
            Return _nLVUT2_QHKCN
        End Get
        Set(ByVal Value As String)
            _nLVUT2_QHKCN = Value
        End Set
    End Property
    Public Property LHD_KXD() As Boolean
        Get
            Return _lHD_KXD
        End Get
        Set(ByVal Value As Boolean)
            _lHD_KXD = Value
        End Set
    End Property
    Public Property LHD_DUOI12T() As Boolean
        Get
            Return _lHD_DUOI12T
        End Get
        Set(ByVal Value As Boolean)
            _lHD_DUOI12T = Value
        End Set
    End Property
    Public Property LHD_12DEN36() As Boolean
        Get
            Return _lHD_12DEN36
        End Get
        Set(ByVal Value As Boolean)
            _lHD_12DEN36 = Value
        End Set
    End Property
    Public Property KNDU_LC() As Boolean
        Get
            Return _kNDU_LC
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_LC = Value
        End Set
    End Property
    Public Property KNDU_CT() As Boolean
        Get
            Return _kNDU_CT
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_CT = Value
        End Set
    End Property
    Public Property KNDU_BP() As Boolean
        Get
            Return _kNDU_BP
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_BP = Value
        End Set
    End Property
    Public Property HTLV_TTG() As Boolean
        Get
            Return _hTLV_TTG
        End Get
        Set(ByVal Value As Boolean)
            _hTLV_TTG = Value
        End Set
    End Property
    Public Property HTLV_BTG() As Boolean
        Get
            Return _hTLV_BTG
        End Get
        Set(ByVal Value As Boolean)
            _hTLV_BTG = Value
        End Set
    End Property
    Public Property MDLV_LD() As Boolean
        Get
            Return _mDLV_LD
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_LD = Value
        End Set
    End Property
    Public Property MDLV_TT() As Boolean
        Get
            Return _mDLV_TT
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_TT = Value
        End Set
    End Property
    Public Property MDLV_LT() As Boolean
        Get
            Return _mDLV_LT
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_LT = Value
        End Set
    End Property
    Public Property ML_THANG() As String
        Get
            Return _mL_THANG
        End Get
        Set(ByVal Value As String)
            _mL_THANG = Value
        End Set
    End Property
    Public Property ML_DUOI5() As Boolean
        Get
            Return _mL_DUOI5
        End Get
        Set(ByVal Value As Boolean)
            _mL_DUOI5 = Value
        End Set
    End Property
    Public Property ML_5DEN10() As Boolean
        Get
            Return _mL_5DEN10
        End Get
        Set(ByVal Value As Boolean)
            _mL_5DEN10 = Value
        End Set
    End Property
    Public Property ML_10DEN20() As Boolean
        Get
            Return _mL_10DEN20
        End Get
        Set(ByVal Value As Boolean)
            _mL_10DEN20 = Value
        End Set
    End Property
    Public Property ML_20DEN50() As Boolean
        Get
            Return _mL_20DEN50
        End Get
        Set(ByVal Value As Boolean)
            _mL_20DEN50 = Value
        End Set
    End Property
    Public Property ML_TREN50() As Boolean
        Get
            Return _mL_TREN50
        End Get
        Set(ByVal Value As Boolean)
            _mL_TREN50 = Value
        End Set
    End Property
    Public Property ML_NGAY() As Boolean
        Get
            Return _mL_NGAY
        End Get
        Set(ByVal Value As Boolean)
            _mL_NGAY = Value
        End Set
    End Property
    Public Property ML_NGAY_TEXT() As String
        Get
            Return _mL_NGAY_TEXT
        End Get
        Set(ByVal Value As String)
            _mL_NGAY_TEXT = Value
        End Set
    End Property
    Public Property ML_GIO() As Boolean
        Get
            Return _mL_GIO
        End Get
        Set(ByVal Value As Boolean)
            _mL_GIO = Value
        End Set
    End Property
    Public Property ML_GIO_TEXT() As String
        Get
            Return _mL_GIO_TEXT
        End Get
        Set(ByVal Value As String)
            _mL_GIO_TEXT = Value
        End Set
    End Property
    Public Property ML_THOATHUAN() As Boolean
        Get
            Return _mL_THOATHUAN
        End Get
        Set(ByVal Value As Boolean)
            _mL_THOATHUAN = Value
        End Set
    End Property
    Public Property ML_HOAHONG() As Boolean
        Get
            Return _mL_HOAHONG
        End Get
        Set(ByVal Value As Boolean)
            _mL_HOAHONG = Value
        End Set
    End Property
    Public Property HTA_1BUA() As Boolean
        Get
            Return _hTA_1BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_1BUA = Value
        End Set
    End Property
    Public Property HTA_2BUA() As Boolean
        Get
            Return _hTA_2BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_2BUA = Value
        End Set
    End Property
    Public Property HTA_3BUA() As Boolean
        Get
            Return _hTA_3BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_3BUA = Value
        End Set
    End Property
    Public Property HTA_TIEN() As Boolean
        Get
            Return _hTA_TIEN
        End Get
        Set(ByVal Value As Boolean)
            _hTA_TIEN = Value
        End Set
    End Property
    Public Property PC_BHXH() As Boolean
        Get
            Return _pC_BHXH
        End Get
        Set(ByVal Value As Boolean)
            _pC_BHXH = Value
        End Set
    End Property
    Public Property PC_BHNT() As Boolean
        Get
            Return _pC_BHNT
        End Get
        Set(ByVal Value As Boolean)
            _pC_BHNT = Value
        End Set
    End Property
    Public Property PC_THOIVIEC() As Boolean
        Get
            Return _pC_THOIVIEC
        End Get
        Set(ByVal Value As Boolean)
            _pC_THOIVIEC = Value
        End Set
    End Property
    Public Property PC_NHATRE() As Boolean
        Get
            Return _pC_NHATRE
        End Get
        Set(ByVal Value As Boolean)
            _pC_NHATRE = Value
        End Set
    End Property
    Public Property PC_XE() As Boolean
        Get
            Return _pC_XE
        End Get
        Set(ByVal Value As Boolean)
            _pC_XE = Value
        End Set
    End Property
    Public Property PC_HOTRODILAI() As Boolean
        Get
            Return _pC_HOTRODILAI
        End Get
        Set(ByVal Value As Boolean)
            _pC_HOTRODILAI = Value
        End Set
    End Property
    Public Property PC_KTXH() As Boolean
        Get
            Return _pC_KTXH
        End Get
        Set(ByVal Value As Boolean)
            _pC_KTXH = Value
        End Set
    End Property
    Public Property PC_HTNO() As Boolean
        Get
            Return _pC_HTNO
        End Get
        Set(ByVal Value As Boolean)
            _pC_HTNO = Value
        End Set
    End Property
    Public Property PC_DAOTAO() As Boolean
        Get
            Return _pC_DAOTAO
        End Get
        Set(ByVal Value As Boolean)
            _pC_DAOTAO = Value
        End Set
    End Property
    Public Property PC_NKT() As Boolean
        Get
            Return _pC_NKT
        End Get
        Set(ByVal Value As Boolean)
            _pC_NKT = Value
        End Set
    End Property
    Public Property PC_CHTT() As Boolean
        Get
            Return _pC_CHTT
        End Get
        Set(ByVal Value As Boolean)
            _pC_CHTT = Value
        End Set
    End Property
    Public Property PC_KHAC() As Boolean
        Get
            Return _pC_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _pC_KHAC = Value
        End Set
    End Property
    Public Property PC_KHAC_TEXT() As String
        Get
            Return _pC_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _pC_KHAC_TEXT = Value
        End Set
    End Property
    Public Property NLV_TN() As Boolean
        Get
            Return _nLV_TN
        End Get
        Set(ByVal Value As Boolean)
            _nLV_TN = Value
        End Set
    End Property
    Public Property NLV_NT() As Boolean
        Get
            Return _nLV_NT
        End Get
        Set(ByVal Value As Boolean)
            _nLV_NT = Value
        End Set
    End Property
    Public Property NLV_HH() As Boolean
        Get
            Return _nLV_HH
        End Get
        Set(ByVal Value As Boolean)
            _nLV_HH = Value
        End Set
    End Property
    Public Property TLN_DUOI5() As Boolean
        Get
            Return _tLN_DUOI5
        End Get
        Set(ByVal Value As Boolean)
            _tLN_DUOI5 = Value
        End Set
    End Property
    Public Property TLN_5DEN20() As Boolean
        Get
            Return _tLN_5DEN20
        End Get
        Set(ByVal Value As Boolean)
            _tLN_5DEN20 = Value
        End Set
    End Property
    Public Property TLN_TREN20() As Boolean
        Get
            Return _tLN_TREN20
        End Get
        Set(ByVal Value As Boolean)
            _tLN_TREN20 = Value
        End Set
    End Property
    Public Property DILAI_KC() As Boolean
        Get
            Return _dILAI_KC
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_KC = Value
        End Set
    End Property
    Public Property DILAI_TB() As Boolean
        Get
            Return _dILAI_TB
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_TB = Value
        End Set
    End Property
    Public Property DILAI_NHIEU() As Boolean
        Get
            Return _dILAI_NHIEU
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_NHIEU = Value
        End Set
    End Property
    Public Property NGHENOI_KCT() As Boolean
        Get
            Return _nGHENOI_KCT
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_KCT = Value
        End Set
    End Property
    Public Property NGHENOI_CB() As Boolean
        Get
            Return _nGHENOI_CB
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_CB = Value
        End Set
    End Property
    Public Property NGHENOI_QT() As Boolean
        Get
            Return _nGHENOI_QT
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_QT = Value
        End Set
    End Property
    Public Property THILUC_BT() As Boolean
        Get
            Return _tHILUC_BT
        End Get
        Set(ByVal Value As Boolean)
            _tHILUC_BT = Value
        End Set
    End Property
    Public Property THILUC_CHITIET() As Boolean
        Get
            Return _tHILUC_CHITIET
        End Get
        Set(ByVal Value As Boolean)
            _tHILUC_CHITIET = Value
        End Set
    End Property
    Public Property THAOTACTAY_VL() As Boolean
        Get
            Return _tHAOTACTAY_VL
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VL = Value
        End Set
    End Property
    Public Property THAOTACTAY_VN() As Boolean
        Get
            Return _tHAOTACTAY_VN
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VN = Value
        End Set
    End Property
    Public Property THAOTACTAY_VRN() As Boolean
        Get
            Return _tHAOTACTAY_VRN
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VRN = Value
        End Set
    End Property
    Public Property DUNGTAY_2TAY() As Boolean
        Get
            Return _dUNGTAY_2TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_2TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_DKC2TAY() As Boolean
        Get
            Return _dUNGTAY_DKC2TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_DKC2TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_1TAY() As Boolean
        Get
            Return _dUNGTAY_1TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_1TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_TRAI() As Boolean
        Get
            Return _dUNGTAY_TRAI
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_TRAI = Value
        End Set
    End Property
    Public Property DUNGTAY_PHAI() As Boolean
        Get
            Return _dUNGTAY_PHAI
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_PHAI = Value
        End Set
    End Property
    Public Property SANSANG_LVN() As Boolean
        Get
            Return _sANSANG_LVN
        End Get
        Set(ByVal Value As Boolean)
            _sANSANG_LVN = Value
        End Set
    End Property
    Public Property SANSANG_LVS() As Boolean
        Get
            Return _sANSANG_LVS
        End Get
        Set(ByVal Value As Boolean)
            _sANSANG_LVS = Value
        End Set
    End Property
    Public Property SANSANG_LVS_TEXT() As String
        Get
            Return _sANSANG_LVS_TEXT
        End Get
        Set(ByVal Value As String)
            _sANSANG_LVS_TEXT = Value
        End Set
    End Property
    Public Property HTTD_TT() As Boolean
        Get
            Return _hTTD_TT
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_TT = Value
        End Set
    End Property
    Public Property HTTD_DT() As Boolean
        Get
            Return _hTTD_DT
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_DT = Value
        End Set
    End Property
    Public Property HTTD_PV() As Boolean
        Get
            Return _hTTD_PV
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_PV = Value
        End Set
    End Property
    Public Property HTTD_CV() As Boolean
        Get
            Return _hTTD_CV
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_CV = Value
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
Public Class ND23_PLIIInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _tenTapThe As String = String.Empty
    Private _soLuong As Integer
    Private _nguoiDaiDien As String = String.Empty
    Private _diaChiLH As String = String.Empty
    Private _sDT_LL As String = String.Empty
    Private _eMAIL_LL As String = String.Empty
    Private _kHAC_LL As String = String.Empty
    Private _dKDV_CSPL As Boolean
    Private _dKDV_TVVL As Boolean
    Private _dKDV_TVDTN As Boolean
    Private _dKDV_TVL As Boolean
    Private _dKDV_KHAC As Boolean
    Private _dKDV_KHAC_TEXT As String = String.Empty
    Private _thoiGianDangKy As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Private _YearId As Integer
    Public Property YearId() As Integer
        Get
            Return _YearId
        End Get
        Set(ByVal value As Integer)
            _YearId = value
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
        End Set
    End Property
    Public Property TenTapThe() As String
        Get
            Return _tenTapThe
        End Get
        Set(ByVal Value As String)
            _tenTapThe = Value
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
    Public Property NguoiDaiDien() As String
        Get
            Return _nguoiDaiDien
        End Get
        Set(ByVal Value As String)
            _nguoiDaiDien = Value
        End Set
    End Property
    Public Property DiaChiLH() As String
        Get
            Return _diaChiLH
        End Get
        Set(ByVal Value As String)
            _diaChiLH = Value
        End Set
    End Property
    Public Property SDT_LL() As String
        Get
            Return _sDT_LL
        End Get
        Set(ByVal Value As String)
            _sDT_LL = Value
        End Set
    End Property
    Public Property EMAIL_LL() As String
        Get
            Return _eMAIL_LL
        End Get
        Set(ByVal Value As String)
            _eMAIL_LL = Value
        End Set
    End Property
    Public Property KHAC_LL() As String
        Get
            Return _kHAC_LL
        End Get
        Set(ByVal Value As String)
            _kHAC_LL = Value
        End Set
    End Property
    Public Property DKDV_CSPL() As Boolean
        Get
            Return _dKDV_CSPL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_CSPL = Value
        End Set
    End Property
    Public Property DKDV_TVVL() As Boolean
        Get
            Return _dKDV_TVVL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVVL = Value
        End Set
    End Property
    Public Property DKDV_TVDTN() As Boolean
        Get
            Return _dKDV_TVDTN
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVDTN = Value
        End Set
    End Property
    Public Property DKDV_TVL() As Boolean
        Get
            Return _dKDV_TVL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVL = Value
        End Set
    End Property
    Public Property DKDV_KHAC() As Boolean
        Get
            Return _dKDV_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_KHAC = Value
        End Set
    End Property
    Public Property DKDV_KHAC_TEXT() As String
        Get
            Return _dKDV_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _dKDV_KHAC_TEXT = Value
        End Set
    End Property
    Public Property ThoiGianDangKy() As DateTime
        Get
            Return _thoiGianDangKy
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianDangKy = Value
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
Public Class ND23_PLIIIInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _TenTapThe As String = String.Empty
    Private _cANHAN As Boolean
    Private _dOANHNGHIEP As Boolean
    Private _mST As String = String.Empty
    Private _lHDN_NN As Boolean
    Private _lHDN_NGNN As Boolean
    Private _lHDN_VDTNN As Boolean
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _diaChi As String = String.Empty
    Private _kCN As Boolean
    Private _kCN_TEN As String = String.Empty
    Private _sDT As String = String.Empty
    Private _eMAIL As String = String.Empty
    Private _nGANH_NLNN As Boolean
    Private _nGANH_KHAIKHOANG As Boolean
    Private _nGANH_CNCHEBIEN As Boolean
    Private _nGANH_XAYDUNG As Boolean
    Private _nGANH_SXPP As Boolean
    Private _nGANH_CCNUOC As Boolean
    Private _nGANH_VANTAI As Boolean
    Private _nGANH_DVLTANUONG As Boolean
    Private _nGANH_TTTT As Boolean
    Private _nGANH_TCBHNH As Boolean
    Private _nGANH_BDS As Boolean
    Private _nGANH_KHCN As Boolean
    Private _nGANH__HCDV As Boolean
    Private _nGANH_GDDT As Boolean
    Private _nGANH_YTE As Boolean
    Private _nGANH_NGHETHUAT As Boolean
    Private _nGANH_BANLE As Boolean
    Private _nGANH_DANGDOAN As Boolean
    Private _nGANH_GIUPVIEC As Boolean
    Private _nGANH_KHAC As Boolean
    Private _nGANH_QUOCTE As Boolean
    Private _sANPHAMCHINH As String = String.Empty
    Private _qUYMO_DUOI10 As Boolean
    Private _qUYMO_10DEN50 As Boolean
    Private _qUYMO_51DEN100 As Boolean
    Private _qUYMO_101DEN200 As Boolean
    Private _qUYMO_202DEN500 As Boolean
    Private _qUYMO_500DEN1K As Boolean
    Private _qUYMO_1KDEN3K As Boolean
    Private _qUYMO_3KDEN10K As Boolean
    Private _qUYMO_TREN10K As Boolean
    Private _sOLD_6THANGTOI As Integer
    Private _nLH_HOTEN As String = String.Empty
    Private _nLH_CHUCVU As String = String.Empty
    Private _nLH_SDT As String = String.Empty
    Private _nLH_LHK As String = String.Empty
    Private _dKDV_CSPL As Boolean
    Private _dKDV_TVTUYENLD As Boolean
    Private _dKDV_TVSDLD As Boolean
    Private _dKDV_DKGTCULD As Boolean
    Private _dKDV_KHAC As Boolean
    Private _dKDV_KHAC_TEXT As String = String.Empty
    Private _thoiGianDangKy As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Private _YearId As Integer
    Public Property YearId() As Integer
        Get
            Return _YearId
        End Get
        Set(ByVal value As Integer)
            _YearId = value
        End Set
    End Property
    Public Property TenTapThe As String
        Get
            Return _TenTapThe
        End Get
        Set(ByVal Value As String)
            _TenTapThe = Value
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
        End Set
    End Property
    Public Property CANHAN() As Boolean
        Get
            Return _cANHAN
        End Get
        Set(ByVal Value As Boolean)
            _cANHAN = Value
        End Set
    End Property
    Public Property DOANHNGHIEP() As Boolean
        Get
            Return _dOANHNGHIEP
        End Get
        Set(ByVal Value As Boolean)
            _dOANHNGHIEP = Value
        End Set
    End Property
    Public Property MST() As String
        Get
            Return _mST
        End Get
        Set(ByVal Value As String)
            _mST = Value
        End Set
    End Property
    Public Property LHDN_NN() As Boolean
        Get
            Return _lHDN_NN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_NN = Value
        End Set
    End Property
    Public Property LHDN_NGNN() As Boolean
        Get
            Return _lHDN_NGNN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_NGNN = Value
        End Set
    End Property
    Public Property LHDN_VDTNN() As Boolean
        Get
            Return _lHDN_VDTNN
        End Get
        Set(ByVal Value As Boolean)
            _lHDN_VDTNN = Value
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
    Public Property MaXa() As Integer
        Get
            Return _maXa
        End Get
        Set(ByVal Value As Integer)
            _maXa = Value
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
    Public Property KCN() As Boolean
        Get
            Return _kCN
        End Get
        Set(ByVal Value As Boolean)
            _kCN = Value
        End Set
    End Property
    Public Property KCN_TEN() As String
        Get
            Return _kCN_TEN
        End Get
        Set(ByVal Value As String)
            _kCN_TEN = Value
        End Set
    End Property
    Public Property SDT() As String
        Get
            Return _sDT
        End Get
        Set(ByVal Value As String)
            _sDT = Value
        End Set
    End Property
    Public Property EMAIL() As String
        Get
            Return _eMAIL
        End Get
        Set(ByVal Value As String)
            _eMAIL = Value
        End Set
    End Property
    Public Property NGANH_NLNN() As Boolean
        Get
            Return _nGANH_NLNN
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_NLNN = Value
        End Set
    End Property
    Public Property NGANH_KHAIKHOANG() As Boolean
        Get
            Return _nGANH_KHAIKHOANG
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_KHAIKHOANG = Value
        End Set
    End Property
    Public Property NGANH_CNCHEBIEN() As Boolean
        Get
            Return _nGANH_CNCHEBIEN
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_CNCHEBIEN = Value
        End Set
    End Property
    Public Property NGANH_XAYDUNG() As Boolean
        Get
            Return _nGANH_XAYDUNG
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_XAYDUNG = Value
        End Set
    End Property
    Public Property NGANH_SXPP() As Boolean
        Get
            Return _nGANH_SXPP
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_SXPP = Value
        End Set
    End Property
    Public Property NGANH_CCNUOC() As Boolean
        Get
            Return _nGANH_CCNUOC
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_CCNUOC = Value
        End Set
    End Property
    Public Property NGANH_VANTAI() As Boolean
        Get
            Return _nGANH_VANTAI
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_VANTAI = Value
        End Set
    End Property
    Public Property NGANH_DVLTANUONG() As Boolean
        Get
            Return _nGANH_DVLTANUONG
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_DVLTANUONG = Value
        End Set
    End Property
    Public Property NGANH_TTTT() As Boolean
        Get
            Return _nGANH_TTTT
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_TTTT = Value
        End Set
    End Property
    Public Property NGANH_TCBHNH() As Boolean
        Get
            Return _nGANH_TCBHNH
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_TCBHNH = Value
        End Set
    End Property
    Public Property NGANH_BDS() As Boolean
        Get
            Return _nGANH_BDS
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_BDS = Value
        End Set
    End Property
    Public Property NGANH_KHCN() As Boolean
        Get
            Return _nGANH_KHCN
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_KHCN = Value
        End Set
    End Property
    Public Property NGANH__HCDV() As Boolean
        Get
            Return _nGANH__HCDV
        End Get
        Set(ByVal Value As Boolean)
            _nGANH__HCDV = Value
        End Set
    End Property
    Public Property NGANH_GDDT() As Boolean
        Get
            Return _nGANH_GDDT
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_GDDT = Value
        End Set
    End Property
    Public Property NGANH_YTE() As Boolean
        Get
            Return _nGANH_YTE
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_YTE = Value
        End Set
    End Property
    Public Property NGANH_NGHETHUAT() As Boolean
        Get
            Return _nGANH_NGHETHUAT
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_NGHETHUAT = Value
        End Set
    End Property
    Public Property NGANH_BANLE() As Boolean
        Get
            Return _nGANH_BANLE
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_BANLE = Value
        End Set
    End Property
    Public Property NGANH_DANGDOAN() As Boolean
        Get
            Return _nGANH_DANGDOAN
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_DANGDOAN = Value
        End Set
    End Property
    Public Property NGANH_GIUPVIEC() As Boolean
        Get
            Return _nGANH_GIUPVIEC
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_GIUPVIEC = Value
        End Set
    End Property
    Public Property NGANH_KHAC() As Boolean
        Get
            Return _nGANH_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_KHAC = Value
        End Set
    End Property
    Public Property NGANH_QUOCTE() As Boolean
        Get
            Return _nGANH_QUOCTE
        End Get
        Set(ByVal Value As Boolean)
            _nGANH_QUOCTE = Value
        End Set
    End Property
    Public Property SANPHAMCHINH() As String
        Get
            Return _sANPHAMCHINH
        End Get
        Set(ByVal Value As String)
            _sANPHAMCHINH = Value
        End Set
    End Property
    Public Property QUYMO_DUOI10() As Boolean
        Get
            Return _qUYMO_DUOI10
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_DUOI10 = Value
        End Set
    End Property
    Public Property QUYMO_10DEN50() As Boolean
        Get
            Return _qUYMO_10DEN50
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_10DEN50 = Value
        End Set
    End Property
    Public Property QUYMO_51DEN100() As Boolean
        Get
            Return _qUYMO_51DEN100
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_51DEN100 = Value
        End Set
    End Property
    Public Property QUYMO_101DEN200() As Boolean
        Get
            Return _qUYMO_101DEN200
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_101DEN200 = Value
        End Set
    End Property
    Public Property QUYMO_202DEN500() As Boolean
        Get
            Return _qUYMO_202DEN500
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_202DEN500 = Value
        End Set
    End Property
    Public Property QUYMO_500DEN1K() As Boolean
        Get
            Return _qUYMO_500DEN1K
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_500DEN1K = Value
        End Set
    End Property
    Public Property QUYMO_1KDEN3K() As Boolean
        Get
            Return _qUYMO_1KDEN3K
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_1KDEN3K = Value
        End Set
    End Property
    Public Property QUYMO_3KDEN10K() As Boolean
        Get
            Return _qUYMO_3KDEN10K
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_3KDEN10K = Value
        End Set
    End Property
    Public Property QUYMO_TREN10K() As Boolean
        Get
            Return _qUYMO_TREN10K
        End Get
        Set(ByVal Value As Boolean)
            _qUYMO_TREN10K = Value
        End Set
    End Property
    Public Property SOLD_6THANGTOI() As Integer
        Get
            Return _sOLD_6THANGTOI
        End Get
        Set(ByVal Value As Integer)
            _sOLD_6THANGTOI = Value
        End Set
    End Property
    Public Property NLH_HOTEN() As String
        Get
            Return _nLH_HOTEN
        End Get
        Set(ByVal Value As String)
            _nLH_HOTEN = Value
        End Set
    End Property
    Public Property NLH_CHUCVU() As String
        Get
            Return _nLH_CHUCVU
        End Get
        Set(ByVal Value As String)
            _nLH_CHUCVU = Value
        End Set
    End Property
    Public Property NLH_SDT() As String
        Get
            Return _nLH_SDT
        End Get
        Set(ByVal Value As String)
            _nLH_SDT = Value
        End Set
    End Property
    Public Property NLH_LHK() As String
        Get
            Return _nLH_LHK
        End Get
        Set(ByVal Value As String)
            _nLH_LHK = Value
        End Set
    End Property
    Public Property DKDV_CSPL() As Boolean
        Get
            Return _dKDV_CSPL
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_CSPL = Value
        End Set
    End Property
    Public Property DKDV_TVTUYENLD() As Boolean
        Get
            Return _dKDV_TVTUYENLD
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVTUYENLD = Value
        End Set
    End Property
    Public Property DKDV_TVSDLD() As Boolean
        Get
            Return _dKDV_TVSDLD
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_TVSDLD = Value
        End Set
    End Property
    Public Property DKDV_DKGTCULD() As Boolean
        Get
            Return _dKDV_DKGTCULD
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_DKGTCULD = Value
        End Set
    End Property
    Public Property DKDV_KHAC() As Boolean
        Get
            Return _dKDV_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _dKDV_KHAC = Value
        End Set
    End Property
    Public Property DKDV_KHAC_TEXT() As String
        Get
            Return _dKDV_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _dKDV_KHAC_TEXT = Value
        End Set
    End Property
    Public Property ThoiGianDangKy() As DateTime
        Get
            Return _thoiGianDangKy
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianDangKy = Value
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
Public Class ND23_PLIIIAInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _mST As String = String.Empty
    Private _iDPLIII As Integer
    Private _tenCongViec As String = String.Empty
    Private _soLuong As Integer
    Private _moTaCongViec As String = String.Empty
    Private _maNghe As String = String.Empty
    Private _mN_CAP1 As String = String.Empty
    Private _mN_CAP2 As String = String.Empty
    Private _mN_CAP3 As String = String.Empty
    Private _mN_CAP4 As String = String.Empty
    Private _cV_NV As Boolean
    Private _cV_QL As Boolean
    Private _cV_LD As Boolean
    Private _cV_KHAC As Boolean
    Private _cV_KHAC_TEXT As String = String.Empty
    Private _tDHV_CTH As Boolean
    Private _tDHV_TH As Boolean
    Private _tDHV_THCS As Boolean
    Private _tDHV_THPT As Boolean
    Private _tDCM_CQDT As Boolean
    Private _tDCM_CNKTKB As Boolean
    Private _tDCM_SOCAP As Boolean
    Private _tDCM_TRUNGCAP As Boolean
    Private _tDCM_CAODANG As Boolean
    Private _tDCM_DH As Boolean
    Private _tDCM_THS As Boolean
    Private _tDCM_TS As Boolean
    Private _tDCM_KHAC As String = String.Empty
    Private _tDCM_KHAC1 As String = String.Empty
    Private _tDCM_KHAC2 As String = String.Empty
    Private _tDKNN As String = String.Empty
    Private _bAC_NGHE As String = String.Empty
    Private _tDNN1 As String = String.Empty
    Private _tDNN1_CC As String = String.Empty
    Private _tDNN1_MUCDO As Byte
    Private _tDNN2 As String = String.Empty
    Private _tDNN2_CC As String = String.Empty
    Private _tDNN2_MUCDO As Byte
    Private _tDTH As Boolean
    Private _tDTH_CC As String = String.Empty
    Private _tDTH_MUCDO As Byte
    Private _tDTHK As Boolean
    Private _tDTHK_CC As String = String.Empty
    Private _tDTHK_MUCDO As Byte
    Private _kNM_GT As Boolean
    Private _kNM_TT As Boolean
    Private _kNM_QLTG As Boolean
    Private _kNM_QLNS As Boolean
    Private _kNM_THBC As Boolean
    Private _kNM_THICHUNG As Boolean
    Private _kNM_LVNHOM As Boolean
    Private _kNM_LVDOCLAP As Boolean
    Private _kNM_CHIUAPLUC As Boolean
    Private _kNM_THEODOI As Boolean
    Private _kNM_TUDUYPB As Boolean
    Private _kNM_KHAC As Boolean
    Private _kNM_KHAC_TEXT As String = String.Empty
    Private _kN_KC As Boolean
    Private _kN_DUOI1NAM As Boolean
    Private _kN_1DEN2NAM As Boolean
    Private _kN_2DEN5NAM As Boolean
    Private _kN_TREN5NAM As Boolean
    Private _nLVUT_TINH As String = String.Empty
    Private _nLVUT_QHKCN As String = String.Empty
    Private _lHD_KXD As Boolean
    Private _lHD_DUOI12T As Boolean
    Private _lHD_12DEN36 As Boolean
    Private _kNDU_LC As Boolean
    Private _kNDU_CT As Boolean
    Private _kNDU_BP As Boolean
    Private _hTLV_TTG As Boolean
    Private _hTLV_BTG As Boolean
    Private _mDLV_LD As Boolean
    Private _mDLV_TT As Boolean
    Private _mDLV_LT As Boolean
    Private _mL_THANG As String = String.Empty
    Private _mL_DUOI5 As Boolean
    Private _mL_5DEN10 As Boolean
    Private _mL_10DEN20 As Boolean
    Private _mL_20DEN50 As Boolean
    Private _mL_TREN50 As Boolean
    Private _mL_NGAY As Boolean
    Private _mL_NGAY_TEXT As String = String.Empty
    Private _mL_GIO As Boolean
    Private _mL_GIO_TEXT As String = String.Empty
    Private _mL_THOATHUAN As Boolean
    Private _mL_HOAHONG As Boolean
    Private _hTA_1BUA As Boolean
    Private _hTA_2BUA As Boolean
    Private _hTA_3BUA As Boolean
    Private _hTA_TIEN As Boolean
    Private _pC_BHXH As Boolean
    Private _pC_BHNT As Boolean
    Private _pC_THOIVIEC As Boolean
    Private _pC_NHATRE As Boolean
    Private _pC_XE As Boolean
    Private _pC_HOTRODILAI As Boolean
    Private _pC_KTXH As Boolean
    Private _pC_HTNO As Boolean
    Private _pC_DAOTAO As Boolean
    Private _pC_NKT As Boolean
    Private _pC_CHTT As Boolean
    Private _pC_KHAC As Boolean
    Private _pC_KHAC_TEXT As String = String.Empty
    Private _nLV_TN As Boolean
    Private _nLV_NT As Boolean
    Private _nLV_HH As Boolean
    Private _tLN_DUOI5 As Boolean
    Private _tLN_5DEN20 As Boolean
    Private _tLN_TREN20 As Boolean
    Private _dILAI_KC As Boolean
    Private _dILAI_TB As Boolean
    Private _dILAI_NHIEU As Boolean
    Private _nGHENOI_KCT As Boolean
    Private _nGHENOI_CB As Boolean
    Private _nGHENOI_QT As Boolean
    Private _tHILUC_BT As Boolean
    Private _tHILUC_CHITIET As Boolean
    Private _tHAOTACTAY_VL As Boolean
    Private _tHAOTACTAY_VN As Boolean
    Private _tHAOTACTAY_VRN As Boolean
    Private _dUNGTAY_2TAY As Boolean
    Private _dUNGTAY_DKC2TAY As Boolean
    Private _dUNGTAY_1TAY As Boolean
    Private _dUNGTAY_TRAI As Boolean
    Private _dUNGTAY_PHAI As Boolean
    Private _dTUT_NKT As Boolean
    Private _dTUT_DTTS As Boolean
    Private _dTUT_HN As Boolean
    Private _dTUT_BODOI As Boolean
    Private _dTUT_KHAC As Boolean
    Private _dTUT_KHAC_TEXT As String = String.Empty
    Private _hTTD_TT As Boolean
    Private _hTTD_DT As Boolean
    Private _hTTD_PV As Boolean
    Private _hTTD_CV As Boolean
    Private _thoiHanTD As DateTime
    Private _mongMuon_TV As Boolean
    Private _mongMuon_GTVL As Boolean
    Private _mongMuon_CULD As Boolean
    Private _nLHTD_HOTEN As String = String.Empty
    Private _nLHTD_CHUCVU As String = String.Empty
    Private _nLHTD_SDT As String = String.Empty
    Private _nLHTD_EMAIL As String = String.Empty
    Private _nLHTD_LHK As String = String.Empty
    Private _pUSH_SMS As Boolean
    Private _pUSH_EMAIL As Boolean
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
        End Set
    End Property
    Public Property MST() As String
        Get
            Return _mST
        End Get
        Set(ByVal Value As String)
            _mST = Value
        End Set
    End Property
    Public Property IDPLIII() As Integer
        Get
            Return _iDPLIII
        End Get
        Set(ByVal Value As Integer)
            _iDPLIII = Value
        End Set
    End Property
    Public Property TenCongViec() As String
        Get
            Return _tenCongViec
        End Get
        Set(ByVal Value As String)
            _tenCongViec = Value
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
    Public Property MoTaCongViec() As String
        Get
            Return _moTaCongViec
        End Get
        Set(ByVal Value As String)
            _moTaCongViec = Value
        End Set
    End Property
    Public Property MaNghe() As String
        Get
            Return _maNghe
        End Get
        Set(ByVal Value As String)
            _maNghe = Value
        End Set
    End Property
    Public Property MN_CAP1() As String
        Get
            Return _mN_CAP1
        End Get
        Set(ByVal Value As String)
            _mN_CAP1 = Value
        End Set
    End Property
    Public Property MN_CAP2() As String
        Get
            Return _mN_CAP2
        End Get
        Set(ByVal Value As String)
            _mN_CAP2 = Value
        End Set
    End Property
    Public Property MN_CAP3() As String
        Get
            Return _mN_CAP3
        End Get
        Set(ByVal Value As String)
            _mN_CAP3 = Value
        End Set
    End Property
    Public Property MN_CAP4() As String
        Get
            Return _mN_CAP4
        End Get
        Set(ByVal Value As String)
            _mN_CAP4 = Value
        End Set
    End Property
    Public Property CV_NV() As Boolean
        Get
            Return _cV_NV
        End Get
        Set(ByVal Value As Boolean)
            _cV_NV = Value
        End Set
    End Property
    Public Property CV_QL() As Boolean
        Get
            Return _cV_QL
        End Get
        Set(ByVal Value As Boolean)
            _cV_QL = Value
        End Set
    End Property
    Public Property CV_LD() As Boolean
        Get
            Return _cV_LD
        End Get
        Set(ByVal Value As Boolean)
            _cV_LD = Value
        End Set
    End Property
    Public Property CV_KHAC() As Boolean
        Get
            Return _cV_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _cV_KHAC = Value
        End Set
    End Property
    Public Property CV_KHAC_TEXT() As String
        Get
            Return _cV_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _cV_KHAC_TEXT = Value
        End Set
    End Property
    Public Property TDHV_CTH() As Boolean
        Get
            Return _tDHV_CTH
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_CTH = Value
        End Set
    End Property
    Public Property TDHV_TH() As Boolean
        Get
            Return _tDHV_TH
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_TH = Value
        End Set
    End Property
    Public Property TDHV_THCS() As Boolean
        Get
            Return _tDHV_THCS
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_THCS = Value
        End Set
    End Property
    Public Property TDHV_THPT() As Boolean
        Get
            Return _tDHV_THPT
        End Get
        Set(ByVal Value As Boolean)
            _tDHV_THPT = Value
        End Set
    End Property
    Public Property TDCM_CQDT() As Boolean
        Get
            Return _tDCM_CQDT
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CQDT = Value
        End Set
    End Property
    Public Property TDCM_CNKTKB() As Boolean
        Get
            Return _tDCM_CNKTKB
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CNKTKB = Value
        End Set
    End Property
    Public Property TDCM_SOCAP() As Boolean
        Get
            Return _tDCM_SOCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_SOCAP = Value
        End Set
    End Property
    Public Property TDCM_TRUNGCAP() As Boolean
        Get
            Return _tDCM_TRUNGCAP
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_TRUNGCAP = Value
        End Set
    End Property
    Public Property TDCM_CAODANG() As Boolean
        Get
            Return _tDCM_CAODANG
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_CAODANG = Value
        End Set
    End Property
    Public Property TDCM_DH() As Boolean
        Get
            Return _tDCM_DH
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_DH = Value
        End Set
    End Property
    Public Property TDCM_THS() As Boolean
        Get
            Return _tDCM_THS
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_THS = Value
        End Set
    End Property
    Public Property TDCM_TS() As Boolean
        Get
            Return _tDCM_TS
        End Get
        Set(ByVal Value As Boolean)
            _tDCM_TS = Value
        End Set
    End Property
    Public Property TDCM_KHAC() As String
        Get
            Return _tDCM_KHAC
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC = Value
        End Set
    End Property
    Public Property TDCM_KHAC1() As String
        Get
            Return _tDCM_KHAC1
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC1 = Value
        End Set
    End Property
    Public Property TDCM_KHAC2() As String
        Get
            Return _tDCM_KHAC2
        End Get
        Set(ByVal Value As String)
            _tDCM_KHAC2 = Value
        End Set
    End Property
    Public Property TDKNN() As String
        Get
            Return _tDKNN
        End Get
        Set(ByVal Value As String)
            _tDKNN = Value
        End Set
    End Property
    Public Property BAC_NGHE() As String
        Get
            Return _bAC_NGHE
        End Get
        Set(ByVal Value As String)
            _bAC_NGHE = Value
        End Set
    End Property
    Public Property TDNN1() As String
        Get
            Return _tDNN1
        End Get
        Set(ByVal Value As String)
            _tDNN1 = Value
        End Set
    End Property
    Public Property TDNN1_CC() As String
        Get
            Return _tDNN1_CC
        End Get
        Set(ByVal Value As String)
            _tDNN1_CC = Value
        End Set
    End Property
    Public Property TDNN1_MUCDO() As Byte
        Get
            Return _tDNN1_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDNN1_MUCDO = Value
        End Set
    End Property
    Public Property TDNN2() As String
        Get
            Return _tDNN2
        End Get
        Set(ByVal Value As String)
            _tDNN2 = Value
        End Set
    End Property
    Public Property TDNN2_CC() As String
        Get
            Return _tDNN2_CC
        End Get
        Set(ByVal Value As String)
            _tDNN2_CC = Value
        End Set
    End Property
    Public Property TDNN2_MUCDO() As Byte
        Get
            Return _tDNN2_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDNN2_MUCDO = Value
        End Set
    End Property
    Public Property TDTH() As Boolean
        Get
            Return _tDTH
        End Get
        Set(ByVal Value As Boolean)
            _tDTH = Value
        End Set
    End Property
    Public Property TDTH_CC() As String
        Get
            Return _tDTH_CC
        End Get
        Set(ByVal Value As String)
            _tDTH_CC = Value
        End Set
    End Property
    Public Property TDTH_MUCDO() As Byte
        Get
            Return _tDTH_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDTH_MUCDO = Value
        End Set
    End Property
    Public Property TDTHK() As Boolean
        Get
            Return _tDTHK
        End Get
        Set(ByVal Value As Boolean)
            _tDTHK = Value
        End Set
    End Property
    Public Property TDTHK_CC() As String
        Get
            Return _tDTHK_CC
        End Get
        Set(ByVal Value As String)
            _tDTHK_CC = Value
        End Set
    End Property
    Public Property TDTHK_MUCDO() As Byte
        Get
            Return _tDTHK_MUCDO
        End Get
        Set(ByVal Value As Byte)
            _tDTHK_MUCDO = Value
        End Set
    End Property
    Public Property KNM_GT() As Boolean
        Get
            Return _kNM_GT
        End Get
        Set(ByVal Value As Boolean)
            _kNM_GT = Value
        End Set
    End Property
    Public Property KNM_TT() As Boolean
        Get
            Return _kNM_TT
        End Get
        Set(ByVal Value As Boolean)
            _kNM_TT = Value
        End Set
    End Property
    Public Property KNM_QLTG() As Boolean
        Get
            Return _kNM_QLTG
        End Get
        Set(ByVal Value As Boolean)
            _kNM_QLTG = Value
        End Set
    End Property
    Public Property KNM_QLNS() As Boolean
        Get
            Return _kNM_QLNS
        End Get
        Set(ByVal Value As Boolean)
            _kNM_QLNS = Value
        End Set
    End Property
    Public Property KNM_THBC() As Boolean
        Get
            Return _kNM_THBC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THBC = Value
        End Set
    End Property
    Public Property KNM_THICHUNG() As Boolean
        Get
            Return _kNM_THICHUNG
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THICHUNG = Value
        End Set
    End Property
    Public Property KNM_LVNHOM() As Boolean
        Get
            Return _kNM_LVNHOM
        End Get
        Set(ByVal Value As Boolean)
            _kNM_LVNHOM = Value
        End Set
    End Property
    Public Property KNM_LVDOCLAP() As Boolean
        Get
            Return _kNM_LVDOCLAP
        End Get
        Set(ByVal Value As Boolean)
            _kNM_LVDOCLAP = Value
        End Set
    End Property
    Public Property KNM_CHIUAPLUC() As Boolean
        Get
            Return _kNM_CHIUAPLUC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_CHIUAPLUC = Value
        End Set
    End Property
    Public Property KNM_THEODOI() As Boolean
        Get
            Return _kNM_THEODOI
        End Get
        Set(ByVal Value As Boolean)
            _kNM_THEODOI = Value
        End Set
    End Property
    Public Property KNM_TUDUYPB() As Boolean
        Get
            Return _kNM_TUDUYPB
        End Get
        Set(ByVal Value As Boolean)
            _kNM_TUDUYPB = Value
        End Set
    End Property
    Public Property KNM_KHAC() As Boolean
        Get
            Return _kNM_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _kNM_KHAC = Value
        End Set
    End Property
    Public Property KNM_KHAC_TEXT() As String
        Get
            Return _kNM_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _kNM_KHAC_TEXT = Value
        End Set
    End Property
    Public Property KN_KC() As Boolean
        Get
            Return _kN_KC
        End Get
        Set(ByVal Value As Boolean)
            _kN_KC = Value
        End Set
    End Property
    Public Property KN_DUOI1NAM() As Boolean
        Get
            Return _kN_DUOI1NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_DUOI1NAM = Value
        End Set
    End Property
    Public Property KN_1DEN2NAM() As Boolean
        Get
            Return _kN_1DEN2NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_1DEN2NAM = Value
        End Set
    End Property
    Public Property KN_2DEN5NAM() As Boolean
        Get
            Return _kN_2DEN5NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_2DEN5NAM = Value
        End Set
    End Property
    Public Property KN_TREN5NAM() As Boolean
        Get
            Return _kN_TREN5NAM
        End Get
        Set(ByVal Value As Boolean)
            _kN_TREN5NAM = Value
        End Set
    End Property
    Public Property NLVUT_TINH() As String
        Get
            Return _nLVUT_TINH
        End Get
        Set(ByVal Value As String)
            _nLVUT_TINH = Value
        End Set
    End Property
    Public Property NLVUT_QHKCN() As String
        Get
            Return _nLVUT_QHKCN
        End Get
        Set(ByVal Value As String)
            _nLVUT_QHKCN = Value
        End Set
    End Property
    Public Property LHD_KXD() As Boolean
        Get
            Return _lHD_KXD
        End Get
        Set(ByVal Value As Boolean)
            _lHD_KXD = Value
        End Set
    End Property
    Public Property LHD_DUOI12T() As Boolean
        Get
            Return _lHD_DUOI12T
        End Get
        Set(ByVal Value As Boolean)
            _lHD_DUOI12T = Value
        End Set
    End Property
    Public Property LHD_12DEN36() As Boolean
        Get
            Return _lHD_12DEN36
        End Get
        Set(ByVal Value As Boolean)
            _lHD_12DEN36 = Value
        End Set
    End Property
    Public Property KNDU_LC() As Boolean
        Get
            Return _kNDU_LC
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_LC = Value
        End Set
    End Property
    Public Property KNDU_CT() As Boolean
        Get
            Return _kNDU_CT
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_CT = Value
        End Set
    End Property
    Public Property KNDU_BP() As Boolean
        Get
            Return _kNDU_BP
        End Get
        Set(ByVal Value As Boolean)
            _kNDU_BP = Value
        End Set
    End Property
    Public Property HTLV_TTG() As Boolean
        Get
            Return _hTLV_TTG
        End Get
        Set(ByVal Value As Boolean)
            _hTLV_TTG = Value
        End Set
    End Property
    Public Property HTLV_BTG() As Boolean
        Get
            Return _hTLV_BTG
        End Get
        Set(ByVal Value As Boolean)
            _hTLV_BTG = Value
        End Set
    End Property
    Public Property MDLV_LD() As Boolean
        Get
            Return _mDLV_LD
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_LD = Value
        End Set
    End Property
    Public Property MDLV_TT() As Boolean
        Get
            Return _mDLV_TT
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_TT = Value
        End Set
    End Property
    Public Property MDLV_LT() As Boolean
        Get
            Return _mDLV_LT
        End Get
        Set(ByVal Value As Boolean)
            _mDLV_LT = Value
        End Set
    End Property
    Public Property ML_THANG() As String
        Get
            Return _mL_THANG
        End Get
        Set(ByVal Value As String)
            _mL_THANG = Value
        End Set
    End Property
    Public Property ML_DUOI5() As Boolean
        Get
            Return _mL_DUOI5
        End Get
        Set(ByVal Value As Boolean)
            _mL_DUOI5 = Value
        End Set
    End Property
    Public Property ML_5DEN10() As Boolean
        Get
            Return _mL_5DEN10
        End Get
        Set(ByVal Value As Boolean)
            _mL_5DEN10 = Value
        End Set
    End Property
    Public Property ML_10DEN20() As Boolean
        Get
            Return _mL_10DEN20
        End Get
        Set(ByVal Value As Boolean)
            _mL_10DEN20 = Value
        End Set
    End Property
    Public Property ML_20DEN50() As Boolean
        Get
            Return _mL_20DEN50
        End Get
        Set(ByVal Value As Boolean)
            _mL_20DEN50 = Value
        End Set
    End Property
    Public Property ML_TREN50() As Boolean
        Get
            Return _mL_TREN50
        End Get
        Set(ByVal Value As Boolean)
            _mL_TREN50 = Value
        End Set
    End Property
    Public Property ML_NGAY() As Boolean
        Get
            Return _mL_NGAY
        End Get
        Set(ByVal Value As Boolean)
            _mL_NGAY = Value
        End Set
    End Property
    Public Property ML_NGAY_TEXT() As String
        Get
            Return _mL_NGAY_TEXT
        End Get
        Set(ByVal Value As String)
            _mL_NGAY_TEXT = Value
        End Set
    End Property
    Public Property ML_GIO() As Boolean
        Get
            Return _mL_GIO
        End Get
        Set(ByVal Value As Boolean)
            _mL_GIO = Value
        End Set
    End Property
    Public Property ML_GIO_TEXT() As String
        Get
            Return _mL_GIO_TEXT
        End Get
        Set(ByVal Value As String)
            _mL_GIO_TEXT = Value
        End Set
    End Property
    Public Property ML_THOATHUAN() As Boolean
        Get
            Return _mL_THOATHUAN
        End Get
        Set(ByVal Value As Boolean)
            _mL_THOATHUAN = Value
        End Set
    End Property
    Public Property ML_HOAHONG() As Boolean
        Get
            Return _mL_HOAHONG
        End Get
        Set(ByVal Value As Boolean)
            _mL_HOAHONG = Value
        End Set
    End Property
    Public Property HTA_1BUA() As Boolean
        Get
            Return _hTA_1BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_1BUA = Value
        End Set
    End Property
    Public Property HTA_2BUA() As Boolean
        Get
            Return _hTA_2BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_2BUA = Value
        End Set
    End Property
    Public Property HTA_3BUA() As Boolean
        Get
            Return _hTA_3BUA
        End Get
        Set(ByVal Value As Boolean)
            _hTA_3BUA = Value
        End Set
    End Property
    Public Property HTA_TIEN() As Boolean
        Get
            Return _hTA_TIEN
        End Get
        Set(ByVal Value As Boolean)
            _hTA_TIEN = Value
        End Set
    End Property
    Public Property PC_BHXH() As Boolean
        Get
            Return _pC_BHXH
        End Get
        Set(ByVal Value As Boolean)
            _pC_BHXH = Value
        End Set
    End Property
    Public Property PC_BHNT() As Boolean
        Get
            Return _pC_BHNT
        End Get
        Set(ByVal Value As Boolean)
            _pC_BHNT = Value
        End Set
    End Property
    Public Property PC_THOIVIEC() As Boolean
        Get
            Return _pC_THOIVIEC
        End Get
        Set(ByVal Value As Boolean)
            _pC_THOIVIEC = Value
        End Set
    End Property
    Public Property PC_NHATRE() As Boolean
        Get
            Return _pC_NHATRE
        End Get
        Set(ByVal Value As Boolean)
            _pC_NHATRE = Value
        End Set
    End Property
    Public Property PC_XE() As Boolean
        Get
            Return _pC_XE
        End Get
        Set(ByVal Value As Boolean)
            _pC_XE = Value
        End Set
    End Property
    Public Property PC_HOTRODILAI() As Boolean
        Get
            Return _pC_HOTRODILAI
        End Get
        Set(ByVal Value As Boolean)
            _pC_HOTRODILAI = Value
        End Set
    End Property
    Public Property PC_KTXH() As Boolean
        Get
            Return _pC_KTXH
        End Get
        Set(ByVal Value As Boolean)
            _pC_KTXH = Value
        End Set
    End Property
    Public Property PC_HTNO() As Boolean
        Get
            Return _pC_HTNO
        End Get
        Set(ByVal Value As Boolean)
            _pC_HTNO = Value
        End Set
    End Property
    Public Property PC_DAOTAO() As Boolean
        Get
            Return _pC_DAOTAO
        End Get
        Set(ByVal Value As Boolean)
            _pC_DAOTAO = Value
        End Set
    End Property
    Public Property PC_NKT() As Boolean
        Get
            Return _pC_NKT
        End Get
        Set(ByVal Value As Boolean)
            _pC_NKT = Value
        End Set
    End Property
    Public Property PC_CHTT() As Boolean
        Get
            Return _pC_CHTT
        End Get
        Set(ByVal Value As Boolean)
            _pC_CHTT = Value
        End Set
    End Property
    Public Property PC_KHAC() As Boolean
        Get
            Return _pC_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _pC_KHAC = Value
        End Set
    End Property
    Public Property PC_KHAC_TEXT() As String
        Get
            Return _pC_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _pC_KHAC_TEXT = Value
        End Set
    End Property
    Public Property NLV_TN() As Boolean
        Get
            Return _nLV_TN
        End Get
        Set(ByVal Value As Boolean)
            _nLV_TN = Value
        End Set
    End Property
    Public Property NLV_NT() As Boolean
        Get
            Return _nLV_NT
        End Get
        Set(ByVal Value As Boolean)
            _nLV_NT = Value
        End Set
    End Property
    Public Property NLV_HH() As Boolean
        Get
            Return _nLV_HH
        End Get
        Set(ByVal Value As Boolean)
            _nLV_HH = Value
        End Set
    End Property
    Public Property TLN_DUOI5() As Boolean
        Get
            Return _tLN_DUOI5
        End Get
        Set(ByVal Value As Boolean)
            _tLN_DUOI5 = Value
        End Set
    End Property
    Public Property TLN_5DEN20() As Boolean
        Get
            Return _tLN_5DEN20
        End Get
        Set(ByVal Value As Boolean)
            _tLN_5DEN20 = Value
        End Set
    End Property
    Public Property TLN_TREN20() As Boolean
        Get
            Return _tLN_TREN20
        End Get
        Set(ByVal Value As Boolean)
            _tLN_TREN20 = Value
        End Set
    End Property
    Public Property DILAI_KC() As Boolean
        Get
            Return _dILAI_KC
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_KC = Value
        End Set
    End Property
    Public Property DILAI_TB() As Boolean
        Get
            Return _dILAI_TB
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_TB = Value
        End Set
    End Property
    Public Property DILAI_NHIEU() As Boolean
        Get
            Return _dILAI_NHIEU
        End Get
        Set(ByVal Value As Boolean)
            _dILAI_NHIEU = Value
        End Set
    End Property
    Public Property NGHENOI_KCT() As Boolean
        Get
            Return _nGHENOI_KCT
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_KCT = Value
        End Set
    End Property
    Public Property NGHENOI_CB() As Boolean
        Get
            Return _nGHENOI_CB
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_CB = Value
        End Set
    End Property
    Public Property NGHENOI_QT() As Boolean
        Get
            Return _nGHENOI_QT
        End Get
        Set(ByVal Value As Boolean)
            _nGHENOI_QT = Value
        End Set
    End Property
    Public Property THILUC_BT() As Boolean
        Get
            Return _tHILUC_BT
        End Get
        Set(ByVal Value As Boolean)
            _tHILUC_BT = Value
        End Set
    End Property
    Public Property THILUC_CHITIET() As Boolean
        Get
            Return _tHILUC_CHITIET
        End Get
        Set(ByVal Value As Boolean)
            _tHILUC_CHITIET = Value
        End Set
    End Property
    Public Property THAOTACTAY_VL() As Boolean
        Get
            Return _tHAOTACTAY_VL
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VL = Value
        End Set
    End Property
    Public Property THAOTACTAY_VN() As Boolean
        Get
            Return _tHAOTACTAY_VN
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VN = Value
        End Set
    End Property
    Public Property THAOTACTAY_VRN() As Boolean
        Get
            Return _tHAOTACTAY_VRN
        End Get
        Set(ByVal Value As Boolean)
            _tHAOTACTAY_VRN = Value
        End Set
    End Property
    Public Property DUNGTAY_2TAY() As Boolean
        Get
            Return _dUNGTAY_2TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_2TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_DKC2TAY() As Boolean
        Get
            Return _dUNGTAY_DKC2TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_DKC2TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_1TAY() As Boolean
        Get
            Return _dUNGTAY_1TAY
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_1TAY = Value
        End Set
    End Property
    Public Property DUNGTAY_TRAI() As Boolean
        Get
            Return _dUNGTAY_TRAI
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_TRAI = Value
        End Set
    End Property
    Public Property DUNGTAY_PHAI() As Boolean
        Get
            Return _dUNGTAY_PHAI
        End Get
        Set(ByVal Value As Boolean)
            _dUNGTAY_PHAI = Value
        End Set
    End Property
    Public Property DTUT_NKT() As Boolean
        Get
            Return _dTUT_NKT
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_NKT = Value
        End Set
    End Property
    Public Property DTUT_DTTS() As Boolean
        Get
            Return _dTUT_DTTS
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_DTTS = Value
        End Set
    End Property
    Public Property DTUT_HN() As Boolean
        Get
            Return _dTUT_HN
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_HN = Value
        End Set
    End Property
    Public Property DTUT_BODOI() As Boolean
        Get
            Return _dTUT_BODOI
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_BODOI = Value
        End Set
    End Property
    Public Property DTUT_KHAC() As Boolean
        Get
            Return _dTUT_KHAC
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_KHAC = Value
        End Set
    End Property
    Public Property DTUT_KHAC_TEXT() As String
        Get
            Return _dTUT_KHAC_TEXT
        End Get
        Set(ByVal Value As String)
            _dTUT_KHAC_TEXT = Value
        End Set
    End Property
    Public Property HTTD_TT() As Boolean
        Get
            Return _hTTD_TT
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_TT = Value
        End Set
    End Property
    Public Property HTTD_DT() As Boolean
        Get
            Return _hTTD_DT
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_DT = Value
        End Set
    End Property
    Public Property HTTD_PV() As Boolean
        Get
            Return _hTTD_PV
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_PV = Value
        End Set
    End Property
    Public Property HTTD_CV() As Boolean
        Get
            Return _hTTD_CV
        End Get
        Set(ByVal Value As Boolean)
            _hTTD_CV = Value
        End Set
    End Property
    Public Property ThoiHanTD() As DateTime
        Get
            Return _thoiHanTD
        End Get
        Set(ByVal Value As DateTime)
            _thoiHanTD = Value
        End Set
    End Property
    Public Property MongMuon_TV() As Boolean
        Get
            Return _mongMuon_TV
        End Get
        Set(ByVal Value As Boolean)
            _mongMuon_TV = Value
        End Set
    End Property
    Public Property MongMuon_GTVL() As Boolean
        Get
            Return _mongMuon_GTVL
        End Get
        Set(ByVal Value As Boolean)
            _mongMuon_GTVL = Value
        End Set
    End Property
    Public Property MongMuon_CULD() As Boolean
        Get
            Return _mongMuon_CULD
        End Get
        Set(ByVal Value As Boolean)
            _mongMuon_CULD = Value
        End Set
    End Property
    Public Property NLHTD_HOTEN() As String
        Get
            Return _nLHTD_HOTEN
        End Get
        Set(ByVal Value As String)
            _nLHTD_HOTEN = Value
        End Set
    End Property
    Public Property NLHTD_CHUCVU() As String
        Get
            Return _nLHTD_CHUCVU
        End Get
        Set(ByVal Value As String)
            _nLHTD_CHUCVU = Value
        End Set
    End Property
    Public Property NLHTD_SDT() As String
        Get
            Return _nLHTD_SDT
        End Get
        Set(ByVal Value As String)
            _nLHTD_SDT = Value
        End Set
    End Property
    Public Property NLHTD_EMAIL() As String
        Get
            Return _nLHTD_EMAIL
        End Get
        Set(ByVal Value As String)
            _nLHTD_EMAIL = Value
        End Set
    End Property
    Public Property NLHTD_LHK() As String
        Get
            Return _nLHTD_LHK
        End Get
        Set(ByVal Value As String)
            _nLHTD_LHK = Value
        End Set
    End Property
    Public Property PUSH_SMS() As Boolean
        Get
            Return _pUSH_SMS
        End Get
        Set(ByVal Value As Boolean)
            _pUSH_SMS = Value
        End Set
    End Property
    Public Property PUSH_EMAIL() As Boolean
        Get
            Return _pUSH_EMAIL
        End Get
        Set(ByVal Value As Boolean)
            _pUSH_EMAIL = Value
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

Public Class CMS_JobHistoryInfo

#Region "Private Members"
    Private _iD As Integer
    Private _jobUserID As String = String.Empty
    Private _hisName As String = String.Empty
    Private _hisDate As DateTime
    Private _userName As String = String.Empty
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

    Public Property JobUserID() As String
        Get
            Return _jobUserID
        End Get
        Set(ByVal Value As String)
            _jobUserID = Value
        End Set
    End Property
    Public Property HisName() As String
        Get
            Return _hisName
        End Get
        Set(ByVal Value As String)
            _hisName = Value
        End Set
    End Property
    Public Property HisDate() As DateTime
        Get
            Return _hisDate
        End Get
        Set(ByVal Value As DateTime)
            _hisDate = Value
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
#End Region

End Class

Public Class CMS_JobUserReferInfo

#Region "Private Members"
    Private _iD As Integer
    Private _jobUserID As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _chucVu As String = String.Empty
    Private _noiCongTac As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _moiQuanHe As String = String.Empty
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

    Public Property JobUserID() As String
        Get
            Return _jobUserID
        End Get
        Set(ByVal Value As String)
            _jobUserID = Value
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
    Public Property ChucVu() As String
        Get
            Return _chucVu
        End Get
        Set(ByVal Value As String)
            _chucVu = Value
        End Set
    End Property
    Public Property NoiCongTac() As String
        Get
            Return _noiCongTac
        End Get
        Set(ByVal Value As String)
            _noiCongTac = Value
        End Set
    End Property
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
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
    Public Property MoiQuanHe() As String
        Get
            Return _moiQuanHe
        End Get
        Set(ByVal Value As String)
            _moiQuanHe = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_SpecializeInfo

#Region "Private Members"
    Private _specialize_ID As Integer
    Private _specialize_Code As String = String.Empty
    Private _specialize_Name As String = String.Empty
    Private _specialize_Des As String = String.Empty
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

    Public Property Specialize_ID() As Integer
        Get
            Return _specialize_ID
        End Get
        Set(ByVal Value As Integer)
            _specialize_ID = Value
        End Set
    End Property

    Public Property Specialize_Code() As String
        Get
            Return _specialize_Code
        End Get
        Set(ByVal Value As String)
            _specialize_Code = Value
        End Set
    End Property
    Public Property Specialize_Name() As String
        Get
            Return _specialize_Name
        End Get
        Set(ByVal Value As String)
            _specialize_Name = Value
        End Set
    End Property
    Public Property Specialize_Des() As String
        Get
            Return _specialize_Des
        End Get
        Set(ByVal Value As String)
            _specialize_Des = Value
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
Public Class CMS_TrainningInfo

#Region "Private Members"
    Private _trainning_ID As Integer
    Private _trainning_Code As String = String.Empty
    Private _trainning_Name As String = String.Empty
    Private _trainning_Des As String = String.Empty
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

    Public Property Trainning_ID() As Integer
        Get
            Return _trainning_ID
        End Get
        Set(ByVal Value As Integer)
            _trainning_ID = Value
        End Set
    End Property

    Public Property Trainning_Code() As String
        Get
            Return _trainning_Code
        End Get
        Set(ByVal Value As String)
            _trainning_Code = Value
        End Set
    End Property
    Public Property Trainning_Name() As String
        Get
            Return _trainning_Name
        End Get
        Set(ByVal Value As String)
            _trainning_Name = Value
        End Set
    End Property
    Public Property Trainning_Des() As String
        Get
            Return _trainning_Des
        End Get
        Set(ByVal Value As String)
            _trainning_Des = Value
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
Public Class CMS_TypeEcoInfo

#Region "Private Members"
    Private _typeEco_ID As Integer
    Private _typeEco_Code As String = String.Empty
    Private _typeEco_Name As String = String.Empty
    Private _typeEco_Des As String = String.Empty
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

    Public Property TypeEco_ID() As Integer
        Get
            Return _typeEco_ID
        End Get
        Set(ByVal Value As Integer)
            _typeEco_ID = Value
        End Set
    End Property

    Public Property TypeEco_Code() As String
        Get
            Return _typeEco_Code
        End Get
        Set(ByVal Value As String)
            _typeEco_Code = Value
        End Set
    End Property
    Public Property TypeEco_Name() As String
        Get
            Return _typeEco_Name
        End Get
        Set(ByVal Value As String)
            _typeEco_Name = Value
        End Set
    End Property
    Public Property TypeEco_Des() As String
        Get
            Return _typeEco_Des
        End Get
        Set(ByVal Value As String)
            _typeEco_Des = Value
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
Public Class CMS_WorkJoinInfo

#Region "Private Members"
    Private _workJoin_ID As Integer
    Private _workJoin_Code As String = String.Empty
    Private _workJoin_Name As String = String.Empty
    Private _workJoin_Des As String = String.Empty
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

    Public Property WorkJoin_ID() As Integer
        Get
            Return _workJoin_ID
        End Get
        Set(ByVal Value As Integer)
            _workJoin_ID = Value
        End Set
    End Property

    Public Property WorkJoin_Code() As String
        Get
            Return _workJoin_Code
        End Get
        Set(ByVal Value As String)
            _workJoin_Code = Value
        End Set
    End Property
    Public Property WorkJoin_Name() As String
        Get
            Return _workJoin_Name
        End Get
        Set(ByVal Value As String)
            _workJoin_Name = Value
        End Set
    End Property
    Public Property WorkJoin_Des() As String
        Get
            Return _workJoin_Des
        End Get
        Set(ByVal Value As String)
            _workJoin_Des = Value
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


Public Class CMS_CareerCLDInfo

#Region "Private Members"
    Private _CareerCLD_ID As Integer
    Private _CareerCLD_Name As String = String.Empty
    Private _CareerCLD_Code As String = String.Empty
    Private _CareerCLD_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
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

    Public Property CareerCLD_ID As Integer
        Get
            Return _CareerCLD_ID
        End Get
        Set(ByVal Value As Integer)
            _CareerCLD_ID = Value
        End Set
    End Property

    Public Property CareerCLD_Name As String
        Get
            Return _CareerCLD_Name
        End Get
        Set(ByVal Value As String)
            _CareerCLD_Name = Value
        End Set
    End Property
    Public Property CareerCLD_Code As String
        Get
            Return _CareerCLD_Code
        End Get
        Set(ByVal Value As String)
            _CareerCLD_Code = Value
        End Set
    End Property
    Public Property CareerCLD_Des As String
        Get
            Return _CareerCLD_Des
        End Get
        Set(ByVal Value As String)
            _CareerCLD_Des = Value
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
    Public Property UserUpdate As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal Value As String)
            _userUpdate = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_BanBeInfo

#Region "Private Members"
    Private _id As Integer
    Private _userName As String = String.Empty
    Private _userNameBanBe As String = String.Empty
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

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property UserNameBanBe() As String
        Get
            Return _userNameBanBe
        End Get
        Set(ByVal Value As String)
            _userNameBanBe = Value
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

Public Class CMS_WorkExtendInfo

#Region "Private Members"
    Private _work_ID As String = String.Empty
    Private _id As Integer
    Private _business_ID As String = String.Empty
    Private _isApproval As Boolean
    Private _isHot As Boolean
    Private _isFast As Boolean
    Private _isUrgent As Boolean
    Private _isGhim As Boolean
    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _title As String = String.Empty
    Private _quantity As Integer
    Private _expiredDate As DateTime
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _salary_ID As String = String.Empty
    Private _experience_ID As String = String.Empty
    Private _submissionSend As String = String.Empty
    Private _level_ID As String = String.Empty
    Private _jobPlace_ID As String = String.Empty
    Private _gender_ID As String = String.Empty
    Private _ages As String = String.Empty
    Private _typeOf_ID As String = String.Empty
    Private _career_ID As String = String.Empty
    Private _workTime As String = String.Empty
    Private _description As String = String.Empty
    Private _benefit As String = String.Empty
    Private _maNghe_Id As String = String.Empty
    Private _maNgheCap1 As String = String.Empty
    Private _maNgheCap2 As String = String.Empty
    Private _maNgheCap3 As String = String.Empty
    Private _maNgheCap4 As String = String.Empty
    Private _levelDesired As String = String.Empty
    Private _requirement As String = String.Empty
    Private _requirementsProfile As String = String.Empty
    Private _trinhDoHocVan As String = String.Empty
    Private _trinhDoChuyenMon As String = String.Empty
    Private _chuyenNganhDaoTao As String = String.Empty
    Private _trinhDoKhac As String = String.Empty
    Private _trinhDoKhac2 As String = String.Empty
    Private _kyNangNghe As String = String.Empty
    Private _kyNangNgheBac As String = String.Empty
    Private _ngoaiNgu1 As String = String.Empty
    Private _ngoaiNgu1ChungChi As String = String.Empty
    Private _trinhDoNgoaiNgu1 As String = String.Empty
    Private _ngoaiNgu2 As String = String.Empty
    Private _ngoaiNgu1ChungChi2 As String = String.Empty
    Private _trinhDoNgoaiNgu2 As String = String.Empty
    Private _trinhDoTinHoc As String = String.Empty
    Private _trinhDoTinHoc_KhaNang As String = String.Empty
    Private _trinhDoTinHoc_Khac As String = String.Empty
    Private _trinhDoTinHoc_Khac_KhaNang As String = String.Empty
    Private _kyNangMem As String = String.Empty
    Private _yeuCauKinhNghiem As String = String.Empty
    Private _contractType_Option As String = String.Empty
    Private _isLamCa As Boolean
    Private _isDiCongTac As Boolean
    Private _isDiBietPhai As Boolean
    Private _hinhThucLamViec As String = String.Empty
    Private _mucDich_ID As String = String.Empty
    Private _kieuLuong As String = String.Empty
    Private _salary_Option As String = String.Empty
    Private _salary_Text As String = String.Empty
    Private _isHoaHong As Boolean
    Private _hinhThucNop As String = String.Empty
    Private _hoTroAn As String = String.Empty
    Private _phucLoi As String = String.Empty
    Private _xeDuaDon As String = String.Empty
    Private _hoTro As String = String.Empty
    Private _phucLoiKhac As String = String.Empty
    Private _noiLamViec As String = String.Empty
    Private _noiLamViecTrongLuong As String = String.Empty
    Private _noiLamViecDiLai As String = String.Empty
    Private _noiLamViecNgheNoi As String = String.Empty
    Private _noiLamViecThiLuc As String = String.Empty
    Private _noiLamViecThaoTacBangTay As String = String.Empty
    Private _noiLamViecDung2Tay As String = String.Empty
    Private _doiTuongUuTien As String = String.Empty
    Private _hinhThucTuyenDung As String = String.Empty
    Private _thoiHanTuyenDung As DateTime
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _levelDesiredOther As String = String.Empty
    Private _isThoaThuan As Boolean
    Private _mongMuonDN As String = String.Empty
    Private _kyNangMemKhac As String = String.Empty
    Private _isSMS As Boolean
    Private _isEmail As Boolean
    Private _chucVuUser As String = String.Empty
    Private _hoTroAnTien As String = String.Empty
    Private _kCN As Boolean
    Private _kCN_ID As String = String.Empty
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

    Public Property Work_ID() As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
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
    Public Property Business_ID() As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
        End Set
    End Property
    Public Property IsApproval() As Boolean
        Get
            Return _isApproval
        End Get
        Set(ByVal Value As Boolean)
            _isApproval = Value
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
    Public Property IsFast() As Boolean
        Get
            Return _isFast
        End Get
        Set(ByVal Value As Boolean)
            _isFast = Value
        End Set
    End Property
    Public Property IsUrgent() As Boolean
        Get
            Return _isUrgent
        End Get
        Set(ByVal Value As Boolean)
            _isUrgent = Value
        End Set
    End Property
    Public Property IsGhim() As Boolean
        Get
            Return _isGhim
        End Get
        Set(ByVal Value As Boolean)
            _isGhim = Value
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
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal Value As String)
            _title = Value
        End Set
    End Property
    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal Value As Integer)
            _quantity = Value
        End Set
    End Property
    Public Property ExpiredDate() As DateTime
        Get
            Return _expiredDate
        End Get
        Set(ByVal Value As DateTime)
            _expiredDate = Value
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
    Public Property Salary_ID() As String
        Get
            Return _salary_ID
        End Get
        Set(ByVal Value As String)
            _salary_ID = Value
        End Set
    End Property
    Public Property Experience_ID() As String
        Get
            Return _experience_ID
        End Get
        Set(ByVal Value As String)
            _experience_ID = Value
        End Set
    End Property
    Public Property SubmissionSend() As String
        Get
            Return _submissionSend
        End Get
        Set(ByVal Value As String)
            _submissionSend = Value
        End Set
    End Property
    Public Property Level_ID() As String
        Get
            Return _level_ID
        End Get
        Set(ByVal Value As String)
            _level_ID = Value
        End Set
    End Property
    Public Property JobPlace_ID() As String
        Get
            Return _jobPlace_ID
        End Get
        Set(ByVal Value As String)
            _jobPlace_ID = Value
        End Set
    End Property
    Public Property Gender_ID() As String
        Get
            Return _gender_ID
        End Get
        Set(ByVal Value As String)
            _gender_ID = Value
        End Set
    End Property
    Public Property Ages() As String
        Get
            Return _ages
        End Get
        Set(ByVal Value As String)
            _ages = Value
        End Set
    End Property
    Public Property TypeOf_ID() As String
        Get
            Return _typeOf_ID
        End Get
        Set(ByVal Value As String)
            _typeOf_ID = Value
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
    Public Property WorkTime() As String
        Get
            Return _workTime
        End Get
        Set(ByVal Value As String)
            _workTime = Value
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
    Public Property Benefit() As String
        Get
            Return _benefit
        End Get
        Set(ByVal Value As String)
            _benefit = Value
        End Set
    End Property
    Public Property MaNghe_Id() As String
        Get
            Return _maNghe_Id
        End Get
        Set(ByVal Value As String)
            _maNghe_Id = Value
        End Set
    End Property
    Public Property MaNgheCap1() As String
        Get
            Return _maNgheCap1
        End Get
        Set(ByVal Value As String)
            _maNgheCap1 = Value
        End Set
    End Property
    Public Property MaNgheCap2() As String
        Get
            Return _maNgheCap2
        End Get
        Set(ByVal Value As String)
            _maNgheCap2 = Value
        End Set
    End Property
    Public Property MaNgheCap3() As String
        Get
            Return _maNgheCap3
        End Get
        Set(ByVal Value As String)
            _maNgheCap3 = Value
        End Set
    End Property
    Public Property MaNgheCap4() As String
        Get
            Return _maNgheCap4
        End Get
        Set(ByVal Value As String)
            _maNgheCap4 = Value
        End Set
    End Property
    Public Property LevelDesired() As String
        Get
            Return _levelDesired
        End Get
        Set(ByVal Value As String)
            _levelDesired = Value
        End Set
    End Property
    Public Property Requirement() As String
        Get
            Return _requirement
        End Get
        Set(ByVal Value As String)
            _requirement = Value
        End Set
    End Property
    Public Property RequirementsProfile() As String
        Get
            Return _requirementsProfile
        End Get
        Set(ByVal Value As String)
            _requirementsProfile = Value
        End Set
    End Property
    Public Property TrinhDoHocVan() As String
        Get
            Return _trinhDoHocVan
        End Get
        Set(ByVal Value As String)
            _trinhDoHocVan = Value
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
    Public Property ChuyenNganhDaoTao() As String
        Get
            Return _chuyenNganhDaoTao
        End Get
        Set(ByVal Value As String)
            _chuyenNganhDaoTao = Value
        End Set
    End Property
    Public Property TrinhDoKhac() As String
        Get
            Return _trinhDoKhac
        End Get
        Set(ByVal Value As String)
            _trinhDoKhac = Value
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
    Public Property TrinhDoNgoaiNgu1() As String
        Get
            Return _trinhDoNgoaiNgu1
        End Get
        Set(ByVal Value As String)
            _trinhDoNgoaiNgu1 = Value
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
    Public Property NgoaiNgu1ChungChi2() As String
        Get
            Return _ngoaiNgu1ChungChi2
        End Get
        Set(ByVal Value As String)
            _ngoaiNgu1ChungChi2 = Value
        End Set
    End Property
    Public Property TrinhDoNgoaiNgu2() As String
        Get
            Return _trinhDoNgoaiNgu2
        End Get
        Set(ByVal Value As String)
            _trinhDoNgoaiNgu2 = Value
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
    Public Property TrinhDoTinHoc_KhaNang() As String
        Get
            Return _trinhDoTinHoc_KhaNang
        End Get
        Set(ByVal Value As String)
            _trinhDoTinHoc_KhaNang = Value
        End Set
    End Property
    Public Property TrinhDoTinHoc_Khac() As String
        Get
            Return _trinhDoTinHoc_Khac
        End Get
        Set(ByVal Value As String)
            _trinhDoTinHoc_Khac = Value
        End Set
    End Property
    Public Property TrinhDoTinHoc_Khac_KhaNang() As String
        Get
            Return _trinhDoTinHoc_Khac_KhaNang
        End Get
        Set(ByVal Value As String)
            _trinhDoTinHoc_Khac_KhaNang = Value
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
    Public Property YeuCauKinhNghiem() As String
        Get
            Return _yeuCauKinhNghiem
        End Get
        Set(ByVal Value As String)
            _yeuCauKinhNghiem = Value
        End Set
    End Property
    Public Property ContractType_Option() As String
        Get
            Return _contractType_Option
        End Get
        Set(ByVal Value As String)
            _contractType_Option = Value
        End Set
    End Property
    Public Property IsLamCa() As Boolean
        Get
            Return _isLamCa
        End Get
        Set(ByVal Value As Boolean)
            _isLamCa = Value
        End Set
    End Property
    Public Property IsDiCongTac() As Boolean
        Get
            Return _isDiCongTac
        End Get
        Set(ByVal Value As Boolean)
            _isDiCongTac = Value
        End Set
    End Property
    Public Property IsDiBietPhai() As Boolean
        Get
            Return _isDiBietPhai
        End Get
        Set(ByVal Value As Boolean)
            _isDiBietPhai = Value
        End Set
    End Property
    Public Property HinhThucLamViec() As String
        Get
            Return _hinhThucLamViec
        End Get
        Set(ByVal Value As String)
            _hinhThucLamViec = Value
        End Set
    End Property
    Public Property MucDich_ID() As String
        Get
            Return _mucDich_ID
        End Get
        Set(ByVal Value As String)
            _mucDich_ID = Value
        End Set
    End Property
    Public Property KieuLuong() As String
        Get
            Return _kieuLuong
        End Get
        Set(ByVal Value As String)
            _kieuLuong = Value
        End Set
    End Property
    Public Property Salary_Option() As String
        Get
            Return _salary_Option
        End Get
        Set(ByVal Value As String)
            _salary_Option = Value
        End Set
    End Property
    Public Property Salary_Text() As String
        Get
            Return _salary_Text
        End Get
        Set(ByVal Value As String)
            _salary_Text = Value
        End Set
    End Property
    Public Property IsHoaHong() As Boolean
        Get
            Return _isHoaHong
        End Get
        Set(ByVal Value As Boolean)
            _isHoaHong = Value
        End Set
    End Property
    Public Property HinhThucNop() As String
        Get
            Return _hinhThucNop
        End Get
        Set(ByVal Value As String)
            _hinhThucNop = Value
        End Set
    End Property
    Public Property HoTroAn() As String
        Get
            Return _hoTroAn
        End Get
        Set(ByVal Value As String)
            _hoTroAn = Value
        End Set
    End Property
    Public Property PhucLoi() As String
        Get
            Return _phucLoi
        End Get
        Set(ByVal Value As String)
            _phucLoi = Value
        End Set
    End Property
    Public Property XeDuaDon() As String
        Get
            Return _xeDuaDon
        End Get
        Set(ByVal Value As String)
            _xeDuaDon = Value
        End Set
    End Property
    Public Property HoTro() As String
        Get
            Return _hoTro
        End Get
        Set(ByVal Value As String)
            _hoTro = Value
        End Set
    End Property
    Public Property PhucLoiKhac() As String
        Get
            Return _phucLoiKhac
        End Get
        Set(ByVal Value As String)
            _phucLoiKhac = Value
        End Set
    End Property
    Public Property NoiLamViec() As String
        Get
            Return _noiLamViec
        End Get
        Set(ByVal Value As String)
            _noiLamViec = Value
        End Set
    End Property
    Public Property NoiLamViecTrongLuong() As String
        Get
            Return _noiLamViecTrongLuong
        End Get
        Set(ByVal Value As String)
            _noiLamViecTrongLuong = Value
        End Set
    End Property
    Public Property NoiLamViecDiLai() As String
        Get
            Return _noiLamViecDiLai
        End Get
        Set(ByVal Value As String)
            _noiLamViecDiLai = Value
        End Set
    End Property
    Public Property NoiLamViecNgheNoi() As String
        Get
            Return _noiLamViecNgheNoi
        End Get
        Set(ByVal Value As String)
            _noiLamViecNgheNoi = Value
        End Set
    End Property
    Public Property NoiLamViecThiLuc() As String
        Get
            Return _noiLamViecThiLuc
        End Get
        Set(ByVal Value As String)
            _noiLamViecThiLuc = Value
        End Set
    End Property
    Public Property NoiLamViecThaoTacBangTay() As String
        Get
            Return _noiLamViecThaoTacBangTay
        End Get
        Set(ByVal Value As String)
            _noiLamViecThaoTacBangTay = Value
        End Set
    End Property
    Public Property NoiLamViecDung2Tay() As String
        Get
            Return _noiLamViecDung2Tay
        End Get
        Set(ByVal Value As String)
            _noiLamViecDung2Tay = Value
        End Set
    End Property
    Public Property DoiTuongUuTien() As String
        Get
            Return _doiTuongUuTien
        End Get
        Set(ByVal Value As String)
            _doiTuongUuTien = Value
        End Set
    End Property
    Public Property HinhThucTuyenDung() As String
        Get
            Return _hinhThucTuyenDung
        End Get
        Set(ByVal Value As String)
            _hinhThucTuyenDung = Value
        End Set
    End Property
    Public Property ThoiHanTuyenDung() As DateTime
        Get
            Return _thoiHanTuyenDung
        End Get
        Set(ByVal Value As DateTime)
            _thoiHanTuyenDung = Value
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
    Public Property LevelDesiredOther() As String
        Get
            Return _levelDesiredOther
        End Get
        Set(ByVal Value As String)
            _levelDesiredOther = Value
        End Set
    End Property
    Public Property IsThoaThuan() As Boolean
        Get
            Return _isThoaThuan
        End Get
        Set(ByVal Value As Boolean)
            _isThoaThuan = Value
        End Set
    End Property
    Public Property MongMuonDN() As String
        Get
            Return _mongMuonDN
        End Get
        Set(ByVal Value As String)
            _mongMuonDN = Value
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
    Public Property IsEmail() As Boolean
        Get
            Return _isEmail
        End Get
        Set(ByVal Value As Boolean)
            _isEmail = Value
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
    Public Property ChucVuUser() As String
        Get
            Return _chucVuUser
        End Get
        Set(ByVal Value As String)
            _chucVuUser = Value
        End Set
    End Property
    Public Property HoTroAnTien() As String
        Get
            Return _hoTroAnTien
        End Get
        Set(ByVal Value As String)
            _hoTroAnTien = Value
        End Set
    End Property
    Public Property KCN() As Boolean
        Get
            Return _kCN
        End Get
        Set(ByVal Value As Boolean)
            _kCN = Value
        End Set
    End Property
    Public Property KCN_ID() As String
        Get
            Return _kCN_ID
        End Get
        Set(ByVal Value As String)
            _kCN_ID = Value
        End Set
    End Property
#End Region

End Class

#Region "MAP_ExperienceInfo"
Public Class MAP_ExperienceInfo : Inherits MappingInfo
    Public Property TenDonVi As String
    Public Property ChucVu As String
    Public Property CongViecChinh As String
    Public Property FromDate As DateTime = DateTime.Now
    Public Property ToDate As DateTime = DateTime.Now
End Class

Public Class MappingInfo
    Implements IMappingInfo
    Public Property UserName As String Implements IMappingInfo.UserName

    Public Overridable Sub SetId(val As String) Implements IMappingInfo.SetId
        Return
    End Sub

    Public Overridable Function GetId() As Object Implements IMappingInfo.GetId
        Return ""
    End Function

    Public Overridable Function GetSQLProcedureName(suffix As String, Optional customTableName As String = "") As String Implements IMappingInfo.GetSQLProcedureName
        If Not String.IsNullOrEmpty(customTableName) Then
            Return $"{customTableName}{suffix}"
        End If
        Return Me.GetType().Name.Replace("Info", suffix)
    End Function
End Class
Public Interface IMappingInfo
    Property UserName As String
    Function GetId()
    Sub SetId(val As String)
    Function GetSQLProcedureName(suffix As String, Optional customTableName As String = "") As String
End Interface

#End Region


Public Class CMS_JobUserExtraInfo

#Region "Private Members"
    Private _jobUser_ID As String = String.Empty
    Private _iD As Integer
    Private _career_ID As String = String.Empty
    Private _tinhTP2 As String = String.Empty
    Private _quanHuyen2 As String = String.Empty
    Private _textSanSangLamViec As String = String.Empty
    Private _description As String = String.Empty
    Private _isLamCa As Boolean
    Private _isDiCongTac As Boolean
    Private _isDiBietPhai As Boolean
    Private _isHoaHong As Boolean
    Private _phucLoiKhacText As String = String.Empty
    Private _salary_Option As String = String.Empty
    Private _salary_Text As String = String.Empty
    Private _loaiHinhDoanhNghiep As String = String.Empty
    Private _hoTroAn As String = String.Empty
    Private _phucLoi As String = String.Empty
    Private _xeDuaDon As String = String.Empty
    Private _phucLoiKhac As String = String.Empty
    Private _noiLamViec As String = String.Empty
    Private _noiLamViecTrongLuong As String = String.Empty
    Private _noiLamViecDiLai As String = String.Empty
    Private _noiLamViecNgheNoi As String = String.Empty
    Private _noiLamViecThiLuc As String = String.Empty
    Private _noiLamViecThaoTacBangTay As String = String.Empty
    Private _noiLamViecDung2Tay As String = String.Empty
    Private _hinhThucTuyenDung As String = String.Empty
    Private _contractType_Option As String = String.Empty
    Private _typeOf_ID As String = String.Empty
    Private _mucDich As String = String.Empty
    Private _sanSangLamViec As String = String.Empty
    Private _maNgheCap1 As String = String.Empty
    Private _maNgheCap2 As String = String.Empty
    Private _maNgheCap3 As String = String.Empty
    Private _maNgheCap4 As String = String.Empty
    Private _levelDesiredOther As String = String.Empty
    Private _trinhDoChuyenMon As String = String.Empty
    Private _kcn_Id As String = String.Empty
    Private _kcn_Id2 As String = String.Empty
    Private _isThoaThuan As Boolean
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

    Public Property JobUser_ID() As String
        Get
            Return _jobUser_ID
        End Get
        Set(ByVal Value As String)
            _jobUser_ID = Value
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
    Public Property Career_ID() As String
        Get
            Return _career_ID
        End Get
        Set(ByVal Value As String)
            _career_ID = Value
        End Set
    End Property
    Public Property TinhTP2() As String
        Get
            Return _tinhTP2
        End Get
        Set(ByVal Value As String)
            _tinhTP2 = Value
        End Set
    End Property
    Public Property QuanHuyen2() As String
        Get
            Return _quanHuyen2
        End Get
        Set(ByVal Value As String)
            _quanHuyen2 = Value
        End Set
    End Property
    Public Property TextSanSangLamViec() As String
        Get
            Return _textSanSangLamViec
        End Get
        Set(ByVal Value As String)
            _textSanSangLamViec = Value
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
    Public Property IsLamCa() As Boolean
        Get
            Return _isLamCa
        End Get
        Set(ByVal Value As Boolean)
            _isLamCa = Value
        End Set
    End Property
    Public Property IsDiCongTac() As Boolean
        Get
            Return _isDiCongTac
        End Get
        Set(ByVal Value As Boolean)
            _isDiCongTac = Value
        End Set
    End Property
    Public Property IsDiBietPhai() As Boolean
        Get
            Return _isDiBietPhai
        End Get
        Set(ByVal Value As Boolean)
            _isDiBietPhai = Value
        End Set
    End Property
    Public Property IsHoaHong() As Boolean
        Get
            Return _isHoaHong
        End Get
        Set(ByVal Value As Boolean)
            _isHoaHong = Value
        End Set
    End Property
    Public Property PhucLoiKhacText() As String
        Get
            Return _phucLoiKhacText
        End Get
        Set(ByVal Value As String)
            _phucLoiKhacText = Value
        End Set
    End Property
    Public Property Salary_Option() As String
        Get
            Return _salary_Option
        End Get
        Set(ByVal Value As String)
            _salary_Option = Value
        End Set
    End Property
    Public Property Salary_Text() As String
        Get
            Return _salary_Text
        End Get
        Set(ByVal Value As String)
            _salary_Text = Value
        End Set
    End Property
    Public Property LoaiHinhDoanhNghiep() As String
        Get
            Return _loaiHinhDoanhNghiep
        End Get
        Set(ByVal Value As String)
            _loaiHinhDoanhNghiep = Value
        End Set
    End Property
    Public Property HoTroAn() As String
        Get
            Return _hoTroAn
        End Get
        Set(ByVal Value As String)
            _hoTroAn = Value
        End Set
    End Property
    Public Property PhucLoi() As String
        Get
            Return _phucLoi
        End Get
        Set(ByVal Value As String)
            _phucLoi = Value
        End Set
    End Property
    Public Property XeDuaDon() As String
        Get
            Return _xeDuaDon
        End Get
        Set(ByVal Value As String)
            _xeDuaDon = Value
        End Set
    End Property
    Public Property PhucLoiKhac() As String
        Get
            Return _phucLoiKhac
        End Get
        Set(ByVal Value As String)
            _phucLoiKhac = Value
        End Set
    End Property
    Public Property NoiLamViec() As String
        Get
            Return _noiLamViec
        End Get
        Set(ByVal Value As String)
            _noiLamViec = Value
        End Set
    End Property
    Public Property NoiLamViecTrongLuong() As String
        Get
            Return _noiLamViecTrongLuong
        End Get
        Set(ByVal Value As String)
            _noiLamViecTrongLuong = Value
        End Set
    End Property
    Public Property NoiLamViecDiLai() As String
        Get
            Return _noiLamViecDiLai
        End Get
        Set(ByVal Value As String)
            _noiLamViecDiLai = Value
        End Set
    End Property
    Public Property NoiLamViecNgheNoi() As String
        Get
            Return _noiLamViecNgheNoi
        End Get
        Set(ByVal Value As String)
            _noiLamViecNgheNoi = Value
        End Set
    End Property
    Public Property NoiLamViecThiLuc() As String
        Get
            Return _noiLamViecThiLuc
        End Get
        Set(ByVal Value As String)
            _noiLamViecThiLuc = Value
        End Set
    End Property
    Public Property NoiLamViecThaoTacBangTay() As String
        Get
            Return _noiLamViecThaoTacBangTay
        End Get
        Set(ByVal Value As String)
            _noiLamViecThaoTacBangTay = Value
        End Set
    End Property
    Public Property NoiLamViecDung2Tay() As String
        Get
            Return _noiLamViecDung2Tay
        End Get
        Set(ByVal Value As String)
            _noiLamViecDung2Tay = Value
        End Set
    End Property
    Public Property HinhThucTuyenDung() As String
        Get
            Return _hinhThucTuyenDung
        End Get
        Set(ByVal Value As String)
            _hinhThucTuyenDung = Value
        End Set
    End Property
    Public Property ContractType_Option() As String
        Get
            Return _contractType_Option
        End Get
        Set(ByVal Value As String)
            _contractType_Option = Value
        End Set
    End Property
    Public Property TypeOf_ID() As String
        Get
            Return _typeOf_ID
        End Get
        Set(ByVal Value As String)
            _typeOf_ID = Value
        End Set
    End Property
    Public Property MucDich() As String
        Get
            Return _mucDich
        End Get
        Set(ByVal Value As String)
            _mucDich = Value
        End Set
    End Property
    Public Property SanSangLamViec() As String
        Get
            Return _sanSangLamViec
        End Get
        Set(ByVal Value As String)
            _sanSangLamViec = Value
        End Set
    End Property
    Public Property MaNgheCap1() As String
        Get
            Return _maNgheCap1
        End Get
        Set(ByVal Value As String)
            _maNgheCap1 = Value
        End Set
    End Property
    Public Property MaNgheCap2() As String
        Get
            Return _maNgheCap2
        End Get
        Set(ByVal Value As String)
            _maNgheCap2 = Value
        End Set
    End Property
    Public Property MaNgheCap3() As String
        Get
            Return _maNgheCap3
        End Get
        Set(ByVal Value As String)
            _maNgheCap3 = Value
        End Set
    End Property
    Public Property MaNgheCap4() As String
        Get
            Return _maNgheCap4
        End Get
        Set(ByVal Value As String)
            _maNgheCap4 = Value
        End Set
    End Property
    Public Property LevelDesiredOther() As String
        Get
            Return _levelDesiredOther
        End Get
        Set(ByVal Value As String)
            _levelDesiredOther = Value
        End Set
    End Property
    Public Property IsThoaThuan() As Boolean
        Get
            Return _isThoaThuan
        End Get
        Set(ByVal Value As Boolean)
            _isThoaThuan = Value
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
    Public Property KCN_ID() As String
        Get
            Return _kcn_Id
        End Get
        Set(ByVal Value As String)
            _kcn_Id = Value
        End Set
    End Property
    Public Property KCN_ID2() As String
        Get
            Return _kcn_Id2
        End Get
        Set(ByVal Value As String)
            _kcn_Id2 = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_NgheCongViecInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _career_Code As String = String.Empty
    Private _career_Name As String = String.Empty
    Private _career_Des As String = String.Empty
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
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

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
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
    Public Property Career_Name() As String
        Get
            Return _career_Name
        End Get
        Set(ByVal Value As String)
            _career_Name = Value
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


Public Class CMS_WorkReportInfo

#Region "Private Members"
    Private _iD As Integer
    Private _work_ID As String = String.Empty
    Private _work_Title As String = String.Empty
    Private _work_Url As String = String.Empty
    Private _tieuDe As String = String.Empty
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Work_ID() As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
        End Set
    End Property
    Public Property Work_Title() As String
        Get
            Return _work_Title
        End Get
        Set(ByVal Value As String)
            _work_Title = Value
        End Set
    End Property
    Public Property Work_Url() As String
        Get
            Return _work_Url
        End Get
        Set(ByVal Value As String)
            _work_Url = Value
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
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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

Public Class CMS_WorkSaveInfo

#Region "Private Members"
    Private _iD As Integer
    Private _work_ID As String = String.Empty
    Private _work_Title As String = String.Empty
    Private _work_Url As String = String.Empty
    Private _tieuDe As String = String.Empty
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Work_ID() As String
        Get
            Return _work_ID
        End Get
        Set(ByVal Value As String)
            _work_ID = Value
        End Set
    End Property
    Public Property Work_Title() As String
        Get
            Return _work_Title
        End Get
        Set(ByVal Value As String)
            _work_Title = Value
        End Set
    End Property
    Public Property Work_Url() As String
        Get
            Return _work_Url
        End Get
        Set(ByVal Value As String)
            _work_Url = Value
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
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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

Public Class CMS_BusinessFollowInfo

#Region "Private Members"
    Private _iD As Integer
    Private _business_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _business_Url As String = String.Empty
    Private _tieuDe As String = String.Empty
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Business_ID() As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
        End Set
    End Property
    Public Property Business_Vn() As String
        Get
            Return _business_Vn
        End Get
        Set(ByVal Value As String)
            _business_Vn = Value
        End Set
    End Property
    Public Property Business_Url() As String
        Get
            Return _business_Url
        End Get
        Set(ByVal Value As String)
            _business_Url = Value
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
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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


Public Class CMS_BanBe_TinNhanInfo

#Region "Private Members"
    Private _id As Integer
    Private _userName As String = String.Empty
    Private _userNameBanBe As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _fileURL As String = String.Empty
    Private _loaiTinNhan As Short
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

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
        End Set
    End Property
    Public Property UserNameBanBe() As String
        Get
            Return _userNameBanBe
        End Get
        Set(ByVal Value As String)
            _userNameBanBe = Value
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
    Public Property FileURL() As String
        Get
            Return _fileURL
        End Get
        Set(ByVal Value As String)
            _fileURL = Value
        End Set
    End Property
    Public Property LoaiTinNhan() As Short
        Get
            Return _loaiTinNhan
        End Get
        Set(ByVal Value As Short)
            _loaiTinNhan = Value
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

Public Class CMS_BC_WorkInfo
#Region "Private Members"
    Private _id As Integer
    Private _quanHuyen As String = String.Empty
    Private _soLuong As Double
#End Region
#Region "Public Properties"
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
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
    Public Property SoLuong() As Double
        Get
            Return _soLuong
        End Get
        Set(ByVal Value As Double)
            _soLuong = Value
        End Set
    End Property
#End Region
End Class

Public Class CMS_BC_LoaiHinhDN
#Region "Private Members"
    Private _quanHuyen As String = String.Empty
    Private _chuaCapNhat As Double
    Private _nhaNuoc As Double
    Private _ngoaiNhaNuoc As Double
    Private _oda As Double
    Private _khac As Double
#End Region
#Region "Public Properties"
    Public Property QuanHuyen() As String
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As String)
            _quanHuyen = Value
        End Set
    End Property
    Public Property ChuaCapNhat() As Double
        Get
            Return _chuaCapNhat
        End Get
        Set(ByVal Value As Double)
            _chuaCapNhat = Value
        End Set
    End Property
    Public Property NhaNuoc() As Double
        Get
            Return _nhaNuoc
        End Get
        Set(ByVal Value As Double)
            _nhaNuoc = Value
        End Set
    End Property
    Public Property NgoaiNhaNuoc() As Double
        Get
            Return _ngoaiNhaNuoc
        End Get
        Set(ByVal Value As Double)
            _ngoaiNhaNuoc = Value
        End Set
    End Property
    Public Property ODA() As Double
        Get
            Return _oda
        End Get
        Set(ByVal Value As Double)
            _oda = Value
        End Set
    End Property
    Public Property Khac() As Double
        Get
            Return _khac
        End Get
        Set(ByVal Value As Double)
            _khac = Value
        End Set
    End Property
#End Region
End Class


Public Class CMS_LoaiTuVanInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenLoaiTuVan As String = String.Empty
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property TenLoaiTuVan() As String
        Get
            Return _tenLoaiTuVan
        End Get
        Set(ByVal Value As String)
            _tenLoaiTuVan = Value
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

Public Class CMS_CaTuVanInfo

#Region "Private Members"
    Private _iD As Integer
    Private _iDLoaiTuVan As Integer
    Private _tenCaTuVan As String = String.Empty
    Private _thoiGianDuKien As DateTime
    Private _thoiGianThucTe As DateTime
    Private _thoiLuongCaTuVan As Integer
    Private _diaDiem As String = String.Empty
    Private _hinhThuc As Short
    Private _moTa As String = String.Empty
    Private _trangThai As Short
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property
    Public Property IDLoaiTuVan() As Integer
        Get
            Return _iDLoaiTuVan
        End Get
        Set(ByVal Value As Integer)
            _iDLoaiTuVan = Value
        End Set
    End Property
    Public Property TenCaTuVan() As String
        Get
            Return _tenCaTuVan
        End Get
        Set(ByVal Value As String)
            _tenCaTuVan = Value
        End Set
    End Property
    Public Property ThoiGianDuKien() As DateTime
        Get
            Return _thoiGianDuKien
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianDuKien = Value
        End Set
    End Property
    Public Property ThoiGianThucTe() As DateTime
        Get
            Return _thoiGianThucTe
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianThucTe = Value
        End Set
    End Property
    Public Property ThoiLuongCaTuVan() As Integer
        Get
            Return _thoiLuongCaTuVan
        End Get
        Set(ByVal Value As Integer)
            _thoiLuongCaTuVan = Value
        End Set
    End Property
    Public Property DiaDiem() As String
        Get
            Return _diaDiem
        End Get
        Set(ByVal Value As String)
            _diaDiem = Value
        End Set
    End Property
    Public Property HinhThuc() As Short
        Get
            Return _hinhThuc
        End Get
        Set(ByVal Value As Short)
            _hinhThuc = Value
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
    Public Property TrangThai() As Short
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Short)
            _trangThai = Value
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

Public Class CMS_DonHangXKLDInfo

#Region "Private Members"
    Private _iD As Integer
    Private _tenDonHang As String = String.Empty
    Private _nganhNghe As String = String.Empty
    Private _diaDiem As String = String.Empty
    Private _moTa As String = String.Empty
    Private _ngayBatDau As DateTime
    Private _mucLuong As String = String.Empty
    Private _soLuong As Integer
    Private _trangThai As Short
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _totalNguoiThieu As Integer
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
    Public Property TotalNguoiThieu As Integer
        Get
            Return _totalNguoiThieu
        End Get
        Set(ByVal Value As Integer)
            _totalNguoiThieu = Value
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

    Public Property TenDonHang() As String
        Get
            Return _tenDonHang
        End Get
        Set(ByVal Value As String)
            _tenDonHang = Value
        End Set
    End Property
    Public Property NganhNghe() As String
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As String)
            _nganhNghe = Value
        End Set
    End Property
    Public Property DiaDiem() As String
        Get
            Return _diaDiem
        End Get
        Set(ByVal Value As String)
            _diaDiem = Value
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
    Public Property NgayBatDau() As DateTime
        Get
            Return _ngayBatDau
        End Get
        Set(ByVal Value As DateTime)
            _ngayBatDau = Value
        End Set
    End Property
    Public Property MucLuong() As String
        Get
            Return _mucLuong
        End Get
        Set(ByVal Value As String)
            _mucLuong = Value
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
    Public Property TrangThai() As Short
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Short)
            _trangThai = Value
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

Public Class CMS_DonHangNLDInfo

#Region "Private Members"
    Private _id As Integer
    Private _idDonHangXKLD As Integer
    Private _userId As Integer
    Private _userName As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _cCCD As String = String.Empty
    Private _ngaySinh As DateTime
    Private _isActive As Boolean
    Private _isOrder As Integer
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isIntroduce As Boolean
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

    Public Property UserId() As Integer
        Get
            Return _userId
        End Get
        Set(ByVal Value As Integer)
            _userId = Value
        End Set
    End Property
    Public Property IdDonHangXKLD() As Integer
        Get
            Return _idDonHangXKLD
        End Get
        Set(ByVal Value As Integer)
            _idDonHangXKLD = Value
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
    Public Property HoTen() As String
        Get
            Return _hoTen
        End Get
        Set(ByVal Value As String)
            _hoTen = Value
        End Set
    End Property
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
        End Set
    End Property
    Public Property CCCD() As String
        Get
            Return _cCCD
        End Get
        Set(ByVal Value As String)
            _cCCD = Value
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
    Public Property IsIntroduce() As Boolean
        Get
            Return _isIntroduce
        End Get
        Set(ByVal Value As Boolean)
            _isIntroduce = Value
        End Set
    End Property
#End Region

End Class


Public Class CMS_CaTuVanCNInfo

#Region "Private Members"
    Private _iD As Integer
    Private _idCaTuVan As Integer
    Private _hoTen As String = String.Empty
    Private _gioiTinh As Short
    Private _ngaySinh As DateTime
    Private _cCCD As String = String.Empty
    Private _noiOHT As String = String.Empty
    Private _thoiGianThucTe As DateTime
    Private _thoiLuongCaTuVan As Integer
    Private _soLuong As Integer
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property IdCaTuVan() As Integer
        Get
            Return _idCaTuVan
        End Get
        Set(ByVal Value As Integer)
            _idCaTuVan = Value
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
    Public Property GioiTinh() As Short
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Short)
            _gioiTinh = Value
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
    Public Property CCCD() As String
        Get
            Return _cCCD
        End Get
        Set(ByVal Value As String)
            _cCCD = Value
        End Set
    End Property
    Public Property NoiOHT() As String
        Get
            Return _noiOHT
        End Get
        Set(ByVal Value As String)
            _noiOHT = Value
        End Set
    End Property
    Public Property ThoiGianThucTe() As DateTime
        Get
            Return _thoiGianThucTe
        End Get
        Set(ByVal Value As DateTime)
            _thoiGianThucTe = Value
        End Set
    End Property
    Public Property ThoiLuongCaTuVan() As Integer
        Get
            Return _thoiLuongCaTuVan
        End Get
        Set(ByVal Value As Integer)
            _thoiLuongCaTuVan = Value
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
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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

Public Class CMS_CaTuVanDNInfo

#Region "Private Members"
    Private _iD As Integer
    Private _idCaTuVan As Integer
    Private _tenDoanhNghiep As String = String.Empty
    Private _mST As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _tenNguoiDD As String = String.Empty
    Private _diaChiNguoiDD As String = String.Empty
    Private _sDTNguoiDD As String = String.Empty
    Private _emailNguoiDD As String = String.Empty
    Private _lienHeKhacNguoiDD As String = String.Empty
    Private _thoiLuongCaTuVan As Integer
    Private _soLuong As Integer
    Private _moTa As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property IdCaTuVan() As Integer
        Get
            Return _idCaTuVan
        End Get
        Set(ByVal Value As Integer)
            _idCaTuVan = Value
        End Set
    End Property
    Public Property TenDoanhNghiep() As String
        Get
            Return _tenDoanhNghiep
        End Get
        Set(ByVal Value As String)
            _tenDoanhNghiep = Value
        End Set
    End Property
    Public Property MST() As String
        Get
            Return _mST
        End Get
        Set(ByVal Value As String)
            _mST = Value
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
    Public Property TenNguoiDD() As String
        Get
            Return _tenNguoiDD
        End Get
        Set(ByVal Value As String)
            _tenNguoiDD = Value
        End Set
    End Property
    Public Property DiaChiNguoiDD() As String
        Get
            Return _diaChiNguoiDD
        End Get
        Set(ByVal Value As String)
            _diaChiNguoiDD = Value
        End Set
    End Property
    Public Property SDTNguoiDD() As String
        Get
            Return _sDTNguoiDD
        End Get
        Set(ByVal Value As String)
            _sDTNguoiDD = Value
        End Set
    End Property
    Public Property EmailNguoiDD() As String
        Get
            Return _emailNguoiDD
        End Get
        Set(ByVal Value As String)
            _emailNguoiDD = Value
        End Set
    End Property
    Public Property LienHeKhacNguoiDD() As String
        Get
            Return _lienHeKhacNguoiDD
        End Get
        Set(ByVal Value As String)
            _lienHeKhacNguoiDD = Value
        End Set
    End Property
    Public Property ThoiLuongCaTuVan() As Integer
        Get
            Return _thoiLuongCaTuVan
        End Get
        Set(ByVal Value As Integer)
            _thoiLuongCaTuVan = Value
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
    Public Property MoTa() As String
        Get
            Return _moTa
        End Get
        Set(ByVal Value As String)
            _moTa = Value
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

Public Class CMS_ChuDeInfo

#Region "Private Members"
    Private _id As Integer
    Private _userName As String = String.Empty
    Private _noiDung As String = String.Empty
    Private _fileURL As String = String.Empty
    Private _soLike As Integer
    Private _soShare As Integer
    Private _soBinhLuan As Integer
    Private _loaiChuDe As Short
    Private _isReport As Boolean
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

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal Value As String)
            _userName = Value
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
    Public Property FileURL() As String
        Get
            Return _fileURL
        End Get
        Set(ByVal Value As String)
            _fileURL = Value
        End Set
    End Property
    Public Property SoLike() As Integer
        Get
            Return _soLike
        End Get
        Set(ByVal Value As Integer)
            _soLike = Value
        End Set
    End Property
    Public Property SoShare() As Integer
        Get
            Return _soShare
        End Get
        Set(ByVal Value As Integer)
            _soShare = Value
        End Set
    End Property
    Public Property SoBinhLuan() As Integer
        Get
            Return _soBinhLuan
        End Get
        Set(ByVal Value As Integer)
            _soBinhLuan = Value
        End Set
    End Property
    Public Property LoaiChuDe() As Short
        Get
            Return _loaiChuDe
        End Get
        Set(ByVal Value As Short)
            _loaiChuDe = Value
        End Set
    End Property
    Public Property IsReport() As Boolean
        Get
            Return _isReport
        End Get
        Set(ByVal Value As Boolean)
            _isReport = Value
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


Public Class CMS_ChuDe_BinhLuanInfo

#Region "Private Members"
    Private _id As Integer
    Private _idChuDe As Integer
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

    Public Property IdChuDe() As Integer
        Get
            Return _idChuDe
        End Get
        Set(ByVal Value As Integer)
            _idChuDe = Value
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
#End Region

End Class


Public Class CMS_VanPhongGDInfo

#Region "Private Members"
    Private _id As Integer
    Private _tenVanPhong As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _lichLamViec As String = String.Empty
    Private _moTa As String = String.Empty
    Private _fileDinhKem As String = String.Empty
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

    Public Property TenVanPhong() As String
        Get
            Return _tenVanPhong
        End Get
        Set(ByVal Value As String)
            _tenVanPhong = Value
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
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
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
    Public Property LichLamViec() As String
        Get
            Return _lichLamViec
        End Get
        Set(ByVal Value As String)
            _lichLamViec = Value
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
    Public Property FileDinhKem() As String
        Get
            Return _fileDinhKem
        End Get
        Set(ByVal Value As String)
            _fileDinhKem = Value
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

Public Class DTNGHE_DiemInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maHocVien As String = String.Empty
    Private _monHoc As String = String.Empty
    Private _diemSo As Double
    Private _ghiChu As String = String.Empty
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

    Public Property MaHocVien() As String
        Get
            Return _maHocVien
        End Get
        Set(ByVal Value As String)
            _maHocVien = Value
        End Set
    End Property
    Public Property MonHoc() As String
        Get
            Return _monHoc
        End Get
        Set(ByVal Value As String)
            _monHoc = Value
        End Set
    End Property
    Public Property DiemSo() As Double
        Get
            Return _diemSo
        End Get
        Set(ByVal Value As Double)
            _diemSo = Value
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

Public Class DTNGHE_HocVienInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maHocVien As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _ngayKhaiGiang As DateTime
    Private _soDienThoai As String = String.Empty
    Private _maLopHoc As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _soCCCD As String = String.Empty
    Private _email As String = String.Empty
    Private _gioiTinh As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _trinhDoHocVan As String = String.Empty
    Private _trinhDoChuyenMon As String = String.Empty
    Private _ngheDaoTaoHV As String = String.Empty
    Private _thoiGianDaoTaoHV As String = String.Empty
    Private _ketQuaDaoTao As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property NgayKhaiGiang() As DateTime
        Get
            Return _ngayKhaiGiang
        End Get
        Set(ByVal Value As DateTime)
            _ngayKhaiGiang = Value
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

    Public Property MaHocVien() As String
        Get
            Return _maHocVien
        End Get
        Set(ByVal Value As String)
            _maHocVien = Value
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
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
        End Set
    End Property
    Public Property MaLopHoc() As Integer
        Get
            Return _maLopHoc
        End Get
        Set(ByVal Value As Integer)
            _maLopHoc = Value
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
    Public Property SoCCCD() As String
        Get
            Return _soCCCD
        End Get
        Set(ByVal Value As String)
            _soCCCD = Value
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
    Public Property GioiTinh() As String
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As String)
            _gioiTinh = Value
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
    Public Property TrinhDoHocVan() As String
        Get
            Return _trinhDoHocVan
        End Get
        Set(ByVal Value As String)
            _trinhDoHocVan = Value
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
    Public Property NgheDaoTaoHV() As String
        Get
            Return _ngheDaoTaoHV
        End Get
        Set(ByVal Value As String)
            _ngheDaoTaoHV = Value
        End Set
    End Property
    Public Property ThoiGianDaoTaoHV() As String
        Get
            Return _thoiGianDaoTaoHV
        End Get
        Set(ByVal Value As String)
            _thoiGianDaoTaoHV = Value
        End Set
    End Property
    Public Property KetQuaDaoTao() As String
        Get
            Return _ketQuaDaoTao
        End Get
        Set(ByVal Value As String)
            _ketQuaDaoTao = Value
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
#End Region

End Class

Public Class DTNGHE_LopHocInfo

#Region "Private Members"
    Private _iD As Integer
    Private _maLopHoc As String = String.Empty
    Private _tenLopHoc As String = String.Empty
    Private _ngheDaoTao As String = String.Empty
    Private _ngayKhaiGiang As DateTime
    Private _ngayKetThuc As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _tenGiangVien As String = String.Empty
    Private _thongTinLienHeGV As String = String.Empty
    Private _diaDiemHoc As String = String.Empty
    Private _donViChuTri As String = String.Empty
    Private _thoiGianDaoTao As String = String.Empty
    Private _kinhPhi As Decimal
    Private _soLuongToiDa As Integer
    Private _trangThai As Integer
    Private _ghiChu As String = String.Empty
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

    Public Property MaLopHoc() As String
        Get
            Return _maLopHoc
        End Get
        Set(ByVal Value As String)
            _maLopHoc = Value
        End Set
    End Property
    Public Property TenLopHoc() As String
        Get
            Return _tenLopHoc
        End Get
        Set(ByVal Value As String)
            _tenLopHoc = Value
        End Set
    End Property
    Public Property NgheDaoTao() As String
        Get
            Return _ngheDaoTao
        End Get
        Set(ByVal Value As String)
            _ngheDaoTao = Value
        End Set
    End Property
    Public Property NgayKhaiGiang() As DateTime
        Get
            Return _ngayKhaiGiang
        End Get
        Set(ByVal Value As DateTime)
            _ngayKhaiGiang = Value
        End Set
    End Property
    Public Property NgayKetThuc() As DateTime
        Get
            Return _ngayKetThuc
        End Get
        Set(ByVal Value As DateTime)
            _ngayKetThuc = Value
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
    Public Property TenGiangVien() As String
        Get
            Return _tenGiangVien
        End Get
        Set(ByVal Value As String)
            _tenGiangVien = Value
        End Set
    End Property
    Public Property ThongTinLienHeGV() As String
        Get
            Return _thongTinLienHeGV
        End Get
        Set(ByVal Value As String)
            _thongTinLienHeGV = Value
        End Set
    End Property
    Public Property DiaDiemHoc() As String
        Get
            Return _diaDiemHoc
        End Get
        Set(ByVal Value As String)
            _diaDiemHoc = Value
        End Set
    End Property
    Public Property DonViChuTri() As String
        Get
            Return _donViChuTri
        End Get
        Set(ByVal Value As String)
            _donViChuTri = Value
        End Set
    End Property
    Public Property ThoiGianDaoTao() As String
        Get
            Return _thoiGianDaoTao
        End Get
        Set(ByVal Value As String)
            _thoiGianDaoTao = Value
        End Set
    End Property
    Public Property KinhPhi() As Decimal
        Get
            Return _kinhPhi
        End Get
        Set(ByVal Value As Decimal)
            _kinhPhi = Value
        End Set
    End Property
    Public Property SoLuongToiDa() As Integer
        Get
            Return _soLuongToiDa
        End Get
        Set(ByVal Value As Integer)
            _soLuongToiDa = Value
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
    Public Property GhiChu() As String
        Get
            Return _ghiChu
        End Get
        Set(ByVal Value As String)
            _ghiChu = Value
        End Set
    End Property
#End Region

End Class

Public Class DTNGHE_NgheDaoTaoInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _name As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
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

Public Class DTNGHE_ThoiGianDaoTaoInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _name As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
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


Public Class DTNGHE_KetQuaDaoTaoInfo

#Region "Private Members"
    Private _iD As Integer
    Private _code As String = String.Empty
    Private _name As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            _code = Value
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
Public Class DTNGHE_ThongKeInfo
    Public Property Ten As String
    Public Property SoLuong As Integer
End Class

Public Class CMS_LichHenInfo

#Region "Private Members"
    Private _iD As Integer
    Private _hoVaTen As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _viTri As String = String.Empty
    Private _ngayPhongVan As DateTime
    Private _gioPhongVan As String = String.Empty
    Private _googleMeeting As String = String.Empty
    Private _hinhThuc As Short
    Private _moTa As String = String.Empty
    Private _trangThai As Short
    Private _isDelete As Boolean
    Private _deletedUser As String = String.Empty
    Private _deletedDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _nhacLich As String = String.Empty
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

    Public Property HoVaTen() As String
        Get
            Return _hoVaTen
        End Get
        Set(ByVal Value As String)
            _hoVaTen = Value
        End Set
    End Property
    Public Property SoDienThoai() As String
        Get
            Return _soDienThoai
        End Get
        Set(ByVal Value As String)
            _soDienThoai = Value
        End Set
    End Property
    Public Property ViTri() As String
        Get
            Return _viTri
        End Get
        Set(ByVal Value As String)
            _viTri = Value
        End Set
    End Property
    Public Property NgayPhongVan() As DateTime
        Get
            Return _ngayPhongVan
        End Get
        Set(ByVal Value As DateTime)
            _ngayPhongVan = Value
        End Set
    End Property
    Public Property GioPhongVan() As String
        Get
            Return _gioPhongVan
        End Get
        Set(ByVal Value As String)
            _gioPhongVan = Value
        End Set
    End Property
    Public Property GoogleMeeting() As String
        Get
            Return _googleMeeting
        End Get
        Set(ByVal Value As String)
            _googleMeeting = Value
        End Set
    End Property
    Public Property HinhThuc() As Short
        Get
            Return _hinhThuc
        End Get
        Set(ByVal Value As Short)
            _hinhThuc = Value
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
    Public Property TrangThai() As Short
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Short)
            _trangThai = Value
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
    Public Property NhacLich() As String
        Get
            Return _nhacLich
        End Get
        Set(ByVal Value As String)
            _nhacLich = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_JobFollowInfo

#Region "Private Members"
    Private _iD As Integer
    Private _business_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _business_En As String = String.Empty
    Private _business_Sort As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _mobile As String = String.Empty
    Private _email As String = String.Empty
    Private _address As String = String.Empty
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

    Public Property ID() As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property Business_ID() As String
        Get
            Return _business_ID
        End Get
        Set(ByVal Value As String)
            _business_ID = Value
        End Set
    End Property
    Public Property Business_Vn() As String
        Get
            Return _business_Vn
        End Get
        Set(ByVal Value As String)
            _business_Vn = Value
        End Set
    End Property
    Public Property Business_En() As String
        Get
            Return _business_En
        End Get
        Set(ByVal Value As String)
            _business_En = Value
        End Set
    End Property
    Public Property Business_Sort() As String
        Get
            Return _business_Sort
        End Get
        Set(ByVal Value As String)
            _business_Sort = Value
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
    Public Property Mobile() As String
        Get
            Return _mobile
        End Get
        Set(ByVal Value As String)
            _mobile = Value
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
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal Value As String)
            _address = Value
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


Public Class XKL_DangKyInfo

#Region "Private Members"
    Private _iD As Integer
    Private _quocGia As String = String.Empty
    Private _hoTen As String = String.Empty
    Private _ngaySinh As DateTime
    Private _gioiTinh As Integer
    Private _cCCD As String = String.Empty
    Private _ngayCap As DateTime
    Private _noiCap As String = String.Empty
    Private _danToc As Integer
    Private _loaiDT_XS As Boolean
    Private _loaiDT_CS As Boolean
    Private _loaiDT_Khac As Boolean
    Private _loaiDT_Khac_Txt As String = String.Empty
    Private _tDVH As Integer
    Private _tayNghe As String = String.Empty
    Private _soThangLamViec As Integer
    Private _bangCap As Integer
    Private _ngheNghiep As String = String.Empty
    Private _tinhTP As Integer
    Private _phuongXa As Integer
    Private _thonTo As Integer
    Private _diaChi As String = String.Empty
    Private _dienThoai As String = String.Empty
    Private _dienThoai_Khac As String = String.Empty
    Private _email As String = String.Empty
    Private _chieuCao As Integer
    Private _canNang As Decimal
    Private _muMau As Boolean
    Private _thiLuc_1 As Integer
    Private _thiLuc_2 As Integer
    Private _thuanTay_1 As Boolean
    Private _thuanTay_2 As Boolean
    Private _vetXamTro As Boolean
    Private _tinhTrangHonNhan As Boolean
    Private _cha_HoTen As String = String.Empty
    Private _cha_Tuoi As Integer
    Private _cha_NgheNghiep As String = String.Empty
    Private _me_HoTen As String = String.Empty
    Private _me_Tuoi As Integer
    Private _me_NgheNghiep As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _signDate As DateTime
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
#End Region

#Region "Public Properties"
    Private _yearId As String
    Public Property YearId() As String
        Get
            Return _yearId
        End Get
        Set(ByVal value As String)
            _yearId = value
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

    Public Property QuocGia() As String
        Get
            Return _quocGia
        End Get
        Set(ByVal Value As String)
            _quocGia = Value
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
    Public Property CCCD() As String
        Get
            Return _cCCD
        End Get
        Set(ByVal Value As String)
            _cCCD = Value
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
    Public Property DanToc() As Integer
        Get
            Return _danToc
        End Get
        Set(ByVal Value As Integer)
            _danToc = Value
        End Set
    End Property
    Public Property LoaiDT_XS() As Boolean
        Get
            Return _loaiDT_XS
        End Get
        Set(ByVal Value As Boolean)
            _loaiDT_XS = Value
        End Set
    End Property
    Public Property LoaiDT_CS() As Boolean
        Get
            Return _loaiDT_CS
        End Get
        Set(ByVal Value As Boolean)
            _loaiDT_CS = Value
        End Set
    End Property
    Public Property LoaiDT_Khac() As Boolean
        Get
            Return _loaiDT_Khac
        End Get
        Set(ByVal Value As Boolean)
            _loaiDT_Khac = Value
        End Set
    End Property
    Public Property LoaiDT_Khac_Txt() As String
        Get
            Return _loaiDT_Khac_Txt
        End Get
        Set(ByVal Value As String)
            _loaiDT_Khac_Txt = Value
        End Set
    End Property
    Public Property TDVH() As Integer
        Get
            Return _tDVH
        End Get
        Set(ByVal Value As Integer)
            _tDVH = Value
        End Set
    End Property
    Public Property TayNghe() As String
        Get
            Return _tayNghe
        End Get
        Set(ByVal Value As String)
            _tayNghe = Value
        End Set
    End Property
    Public Property SoThangLamViec() As Integer
        Get
            Return _soThangLamViec
        End Get
        Set(ByVal Value As Integer)
            _soThangLamViec = Value
        End Set
    End Property
    Public Property BangCap() As Integer
        Get
            Return _bangCap
        End Get
        Set(ByVal Value As Integer)
            _bangCap = Value
        End Set
    End Property
    Public Property NgheNghiep() As String
        Get
            Return _ngheNghiep
        End Get
        Set(ByVal Value As String)
            _ngheNghiep = Value
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
    Public Property PhuongXa() As Integer
        Get
            Return _phuongXa
        End Get
        Set(ByVal Value As Integer)
            _phuongXa = Value
        End Set
    End Property
    Public Property ThonTo() As Integer
        Get
            Return _thonTo
        End Get
        Set(ByVal Value As Integer)
            _thonTo = Value
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
    Public Property DienThoai() As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal Value As String)
            _dienThoai = Value
        End Set
    End Property
    Public Property DienThoai_Khac() As String
        Get
            Return _dienThoai_Khac
        End Get
        Set(ByVal Value As String)
            _dienThoai_Khac = Value
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
    Public Property ChieuCao() As Integer
        Get
            Return _chieuCao
        End Get
        Set(ByVal Value As Integer)
            _chieuCao = Value
        End Set
    End Property
    Public Property CanNang() As Decimal
        Get
            Return _canNang
        End Get
        Set(ByVal Value As Decimal)
            _canNang = Value
        End Set
    End Property
    Public Property MuMau() As Boolean
        Get
            Return _muMau
        End Get
        Set(ByVal Value As Boolean)
            _muMau = Value
        End Set
    End Property
    Public Property ThiLuc_1() As Integer
        Get
            Return _thiLuc_1
        End Get
        Set(ByVal Value As Integer)
            _thiLuc_1 = Value
        End Set
    End Property
    Public Property ThiLuc_2() As Integer
        Get
            Return _thiLuc_2
        End Get
        Set(ByVal Value As Integer)
            _thiLuc_2 = Value
        End Set
    End Property
    Public Property ThuanTay_1() As Boolean
        Get
            Return _thuanTay_1
        End Get
        Set(ByVal Value As Boolean)
            _thuanTay_1 = Value
        End Set
    End Property
    Public Property ThuanTay_2() As Boolean
        Get
            Return _thuanTay_2
        End Get
        Set(ByVal Value As Boolean)
            _thuanTay_2 = Value
        End Set
    End Property
    Public Property VetXamTro() As Boolean
        Get
            Return _vetXamTro
        End Get
        Set(ByVal Value As Boolean)
            _vetXamTro = Value
        End Set
    End Property
    Public Property TinhTrangHonNhan() As Boolean
        Get
            Return _tinhTrangHonNhan
        End Get
        Set(ByVal Value As Boolean)
            _tinhTrangHonNhan = Value
        End Set
    End Property
    Public Property Cha_HoTen() As String
        Get
            Return _cha_HoTen
        End Get
        Set(ByVal Value As String)
            _cha_HoTen = Value
        End Set
    End Property
    Public Property Cha_Tuoi() As Integer
        Get
            Return _cha_Tuoi
        End Get
        Set(ByVal Value As Integer)
            _cha_Tuoi = Value
        End Set
    End Property
    Public Property Cha_NgheNghiep() As String
        Get
            Return _cha_NgheNghiep
        End Get
        Set(ByVal Value As String)
            _cha_NgheNghiep = Value
        End Set
    End Property
    Public Property Me_HoTen() As String
        Get
            Return _me_HoTen
        End Get
        Set(ByVal Value As String)
            _me_HoTen = Value
        End Set
    End Property
    Public Property Me_Tuoi() As Integer
        Get
            Return _me_Tuoi
        End Get
        Set(ByVal Value As Integer)
            _me_Tuoi = Value
        End Set
    End Property
    Public Property Me_NgheNghiep() As String
        Get
            Return _me_NgheNghiep
        End Get
        Set(ByVal Value As String)
            _me_NgheNghiep = Value
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
    Public Property SignDate() As DateTime
        Get
            Return _signDate
        End Get
        Set(ByVal Value As DateTime)
            _signDate = Value
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












