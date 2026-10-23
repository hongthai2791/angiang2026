Public Class CMS_HoGDInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _maHo As String = String.Empty
    Private _tenChuHo As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _soNhanKhau As Integer
    Private _loaiHo As String = String.Empty
    Private _idSo As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
    Private _totalKhau As Integer
    Private _loaiBienDong As Integer
    Private _isNew As Boolean
    Private _chuyenden As Integer
#End Region

#Region "Public Properties"
    Public Property ChuyenDen As Integer
        Get
            Return _chuyenden
        End Get
        Set(ByVal Value As Integer)
            _chuyenden = Value
        End Set
    End Property
    Public Property IsNew As Boolean
        Get
            Return _isNew
        End Get
        Set(ByVal Value As Boolean)
            _isNew = Value
        End Set
    End Property
    Public Property TotalKhau As Integer
        Get
            Return _totalKhau
        End Get
        Set(ByVal Value As Integer)
            _totalKhau = Value
        End Set
    End Property
    Public Property LoaiBienDong As Integer
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As Integer)
            _loaiBienDong = Value
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
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property MaHo() As String
        Get
            Return _maHo
        End Get
        Set(ByVal Value As String)
            _maHo = Value
        End Set
    End Property
    Public Property TenChuHo() As String
        Get
            Return _tenChuHo
        End Get
        Set(ByVal Value As String)
            _tenChuHo = Value
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
    Public Property SoNhanKhau() As Integer
        Get
            Return _soNhanKhau
        End Get
        Set(ByVal Value As Integer)
            _soNhanKhau = Value
        End Set
    End Property
    Public Property LoaiHo() As String
        Get
            Return _loaiHo
        End Get
        Set(ByVal Value As String)
            _loaiHo = Value
        End Set
    End Property
    Public Property IdSo() As String
        Get
            Return _idSo
        End Get
        Set(ByVal Value As String)
            _idSo = Value
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
    Public Property DeletedUser() As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
Public Class CMS_HoGD_KhauInfo

#Region "Private Members"
    Private _id As String = String.Empty
    Private _maDoiTuong As String = String.Empty
    Private _cMND As String = String.Empty
    Private _idHo As String = String.Empty
    Private _maHo As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _maTinh_HT As Integer
    Private _maHuyen_HT As Integer
    Private _maXa_HT As Integer
    Private _maThon_HT As Integer
    Private _diaChi_HT As String
    Private _maTinh_TT As Integer
    Private _maHuyen_TT As Integer
    Private _maXa_TT As Integer
    Private _maThon_TT As Integer
    Private _diaChi_TT As String
    Private _DTUT_NKT As Integer
    Private _DTUT_HN As Integer
    Private _DTUT_DTTS As Integer
    Private _DTUT_CN As Integer
    Private _DTUT_THUHOI As Integer
    Private _DTUT_NCC As Integer
    Private _NCVL As Integer
    Private _NTN As Integer
    Private _KTGHDKT As Integer
    Private _soThuTu As Integer
    Private _hoTen As String = String.Empty
    Private _namSinh As Integer
    Private _gioiTinh As Integer
    Private _danToc As String = String.Empty
    Private _quanHe As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _trinhDoGD As String = String.Empty
    Private _trinhDoCM As String = String.Empty
    Private _linhVucDT As String = String.Empty
    Private _hinhThuc As String = String.Empty
    Private _loaiHinhKT As String = String.Empty
    Private _noiLamViec As Integer
    Private _nganhNghe As Integer
    Private _diaChiLamViec As String = String.Empty
    Private _nuocLamViec As Integer
    Private _loaiThatNghiep As String = String.Empty
    Private _thoiGianThatNghiep As String = String.Empty
    Private _lyDoKhongThamGia As String = String.Empty
    Private _ghiChu As String = String.Empty
    Private _loaiBienDong As String = String.Empty
    Private _catChet As Boolean
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Integer
    Private _total As Integer
    Private _CongViecThamGia As Integer
    Private _chuyenden As Integer
    Private _isNew As Boolean
    Private _khuVuc As Integer
    Private _JoinHDKT As Integer
    Private _UnJoinHDKT As Integer
    Private _CongViecDangLam As String = String.Empty
    Private _SoDienThoai As String = String.Empty
    Private _SoBHXH As String = String.Empty
    Private _ThamGiaBHXH As Boolean
    Private _ThamGiaBHXH_Loai As Integer
    Private _HDLD As Integer
    Private _LoaiHDLD As Integer
    Private _ThoiGianHDLD As DateTime

    Private _DoanhNghiepLamViec As String = String.Empty
    Private _LoaiHinhKT_DN As Integer

    Private _maTinh_NLV As String = String.Empty
    Private _maHuyen_NLV As String = String.Empty
    Private _maXa_NLV As String = String.Empty
    Private _maThon_NLV As String = String.Empty
    Private _diaChi_NLV As String
    Private _IsDCTT As Boolean
    Private _IsDCHT As Boolean
#End Region

#Region "Public Properties"

    Public Property IsDCHT As Boolean
        Get
            Return _IsDCHT
        End Get
        Set(ByVal Value As Boolean)
            _IsDCHT = Value
        End Set
    End Property
    Public Property IsDCTT As Boolean
        Get
            Return _IsDCTT
        End Get
        Set(ByVal Value As Boolean)
            _IsDCTT = Value
        End Set
    End Property
    Public Property ThoiGianHDLD As DateTime
        Get
            Return _ThoiGianHDLD
        End Get
        Set(ByVal Value As DateTime)
            _ThoiGianHDLD = Value
        End Set
    End Property
    Public Property ThamGiaBHXH As Boolean
        Get
            Return _ThamGiaBHXH
        End Get
        Set(ByVal Value As Boolean)
            _ThamGiaBHXH = Value
        End Set
    End Property
    Public Property ThamGiaBHXH_Loai As Integer
        Get
            Return _ThamGiaBHXH_Loai
        End Get
        Set(ByVal Value As Integer)
            _ThamGiaBHXH_Loai = Value
        End Set
    End Property
    Public Property HDLD As Integer
        Get
            Return _HDLD
        End Get
        Set(ByVal Value As Integer)
            _HDLD = Value
        End Set
    End Property
    Public Property LoaiHDLD As Integer
        Get
            Return _LoaiHDLD
        End Get
        Set(ByVal Value As Integer)
            _LoaiHDLD = Value
        End Set
    End Property
    Public Property LoaiHinhKT_DN As Integer
        Get
            Return _LoaiHinhKT_DN
        End Get
        Set(ByVal Value As Integer)
            _LoaiHinhKT_DN = Value
        End Set
    End Property
    Public Property DoanhNghiepLamViec As String
        Get
            Return _DoanhNghiepLamViec
        End Get
        Set(ByVal Value As String)
            _DoanhNghiepLamViec = Value
        End Set
    End Property
    Public Property DiaChi_NLV As String
        Get
            Return _diaChi_NLV
        End Get
        Set(ByVal Value As String)
            _diaChi_NLV = Value
        End Set
    End Property
    Public Property MaTinh_NLV As String
        Get
            Return _maTinh_NLV
        End Get
        Set(ByVal Value As String)
            _maTinh_NLV = Value
        End Set
    End Property
    Public Property MaHuyen_NLV As String
        Get
            Return _maHuyen_NLV
        End Get
        Set(ByVal Value As String)
            _maHuyen_NLV = Value
        End Set
    End Property
    Public Property MaXa_NLV As String
        Get
            Return _maXa_NLV
        End Get
        Set(ByVal Value As String)
            _maXa_NLV = Value
        End Set
    End Property
    Public Property MaThon_NLV As String
        Get
            Return _maThon_NLV
        End Get
        Set(ByVal Value As String)
            _maThon_NLV = Value
        End Set
    End Property
    Public Property DTUT_CN As Integer
        Get
            Return _DTUT_CN
        End Get
        Set(ByVal Value As Integer)
            _DTUT_CN = Value
        End Set
    End Property
    Public Property DTUT_THUHOI As Integer
        Get
            Return _DTUT_THUHOI
        End Get
        Set(ByVal Value As Integer)
            _DTUT_THUHOI = Value
        End Set
    End Property
    Public Property DTUT_NCC As Integer
        Get
            Return _DTUT_NCC
        End Get
        Set(ByVal Value As Integer)
            _DTUT_NCC = Value
        End Set
    End Property
    Public Property SoDienThoai As String
        Get
            Return _SoDienThoai
        End Get
        Set(ByVal Value As String)
            _SoDienThoai = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _SoBHXH
        End Get
        Set(ByVal Value As String)
            _SoBHXH = Value
        End Set
    End Property
    Public Property TGKT As String
    Public Property DTUT As String
    Public Property IdBackup As Integer
    Public Property CongViecDangLam As String
        Get
            Return _CongViecDangLam
        End Get
        Set(ByVal Value As String)
            _CongViecDangLam = Value
        End Set
    End Property
    Public Property DiaChi_HT As String
        Get
            Return _diaChi_HT
        End Get
        Set(ByVal Value As String)
            _diaChi_HT = Value
        End Set
    End Property
    Public Property DiaChi_TT As String
        Get
            Return _diaChi_TT
        End Get
        Set(ByVal Value As String)
            _diaChi_TT = Value
        End Set
    End Property
    Public Property KTGHDKT As Integer
        Get
            Return _KTGHDKT
        End Get
        Set(ByVal Value As Integer)
            _KTGHDKT = Value
        End Set
    End Property
    Public Property NTN As Integer
        Get
            Return _NTN
        End Get
        Set(ByVal Value As Integer)
            _NTN = Value
        End Set
    End Property
    Public Property NCVL As Integer
        Get
            Return _NCVL
        End Get
        Set(ByVal Value As Integer)
            _NCVL = Value
        End Set
    End Property
    Public Property MaTinh_HT As Integer
        Get
            Return _maTinh_HT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_HT = Value
        End Set
    End Property
    Public Property MaHuyen_HT As Integer
        Get
            Return _maHuyen_HT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_HT = Value
        End Set
    End Property
    Public Property MaXa_HT As Integer
        Get
            Return _maXa_HT
        End Get
        Set(ByVal Value As Integer)
            _maXa_HT = Value
        End Set
    End Property
    Public Property MaThon_HT As Integer
        Get
            Return _maThon_HT
        End Get
        Set(ByVal Value As Integer)
            _maThon_HT = Value
        End Set
    End Property
    Public Property MaTinh_TT As Integer
        Get
            Return _maTinh_TT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_TT = Value
        End Set
    End Property
    Public Property MaHuyen_TT As Integer
        Get
            Return _maHuyen_TT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_TT = Value
        End Set
    End Property
    Public Property MaXa_TT As Integer
        Get
            Return _maXa_TT
        End Get
        Set(ByVal Value As Integer)
            _maXa_TT = Value
        End Set
    End Property
    Public Property MaThon_TT As Integer
        Get
            Return _maThon_TT
        End Get
        Set(ByVal Value As Integer)
            _maThon_TT = Value
        End Set
    End Property
    Public Property DTUT_NKT As Integer
        Get
            Return _DTUT_NKT
        End Get
        Set(ByVal Value As Integer)
            _DTUT_NKT = Value
        End Set
    End Property
    Public Property DTUT_HN As Integer
        Get
            Return _DTUT_HN
        End Get
        Set(ByVal Value As Integer)
            _DTUT_HN = Value
        End Set
    End Property
    Public Property DTUT_DTTS As Integer
        Get
            Return _DTUT_DTTS
        End Get
        Set(ByVal Value As Integer)
            _DTUT_DTTS = Value
        End Set
    End Property
    Public Property JoinHDKT As Integer
        Get
            Return _JoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _JoinHDKT = Value
        End Set
    End Property
    Public Property UnJoinHDKT As Integer
        Get
            Return _UnJoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _UnJoinHDKT = Value
        End Set
    End Property
    Public Property KhuVuc As Integer
        Get
            Return _khuVuc
        End Get
        Set(ByVal Value As Integer)
            _khuVuc = Value
        End Set
    End Property
    Public Property IsNew As Integer
        Get
            Return _isNew
        End Get
        Set(ByVal Value As Integer)
            _isNew = Value
        End Set
    End Property
    Public Property ChuyenDen As Integer
        Get
            Return _chuyenden
        End Get
        Set(ByVal Value As Integer)
            _chuyenden = Value
        End Set
    End Property
    Public Property CongViecThamGia As Integer
        Get
            Return _CongViecThamGia
        End Get
        Set(ByVal Value As Integer)
            _CongViecThamGia = Value
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
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
        End Set
    End Property
    Public Property MaDoiTuong() As String
        Get
            Return _maDoiTuong
        End Get
        Set(ByVal Value As String)
            _maDoiTuong = Value
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
    Public Property IdHo() As String
        Get
            Return _idHo
        End Get
        Set(ByVal Value As String)
            _idHo = Value
        End Set
    End Property
    Public Property MaHo() As String
        Get
            Return _maHo
        End Get
        Set(ByVal Value As String)
            _maHo = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property SoThuTu() As Integer
        Get
            Return _soThuTu
        End Get
        Set(ByVal Value As Integer)
            _soThuTu = Value
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
    Public Property NamSinh() As Integer
        Get
            Return _namSinh
        End Get
        Set(ByVal Value As Integer)
            _namSinh = Value
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
    Public Property DanToc() As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
        End Set
    End Property
    Public Property QuanHe() As String
        Get
            Return _quanHe
        End Get
        Set(ByVal Value As String)
            _quanHe = Value
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
    Public Property TrinhDoGD() As String
        Get
            Return _trinhDoGD
        End Get
        Set(ByVal Value As String)
            _trinhDoGD = Value
        End Set
    End Property
    Public Property TrinhDoCM() As String
        Get
            Return _trinhDoCM
        End Get
        Set(ByVal Value As String)
            _trinhDoCM = Value
        End Set
    End Property
    Public Property LinhVucDT() As String
        Get
            Return _linhVucDT
        End Get
        Set(ByVal Value As String)
            _linhVucDT = Value
        End Set
    End Property
    Public Property HinhThuc() As String
        Get
            Return _hinhThuc
        End Get
        Set(ByVal Value As String)
            _hinhThuc = Value
        End Set
    End Property
    Public Property LoaiHinhKT() As String
        Get
            Return _loaiHinhKT
        End Get
        Set(ByVal Value As String)
            _loaiHinhKT = Value
        End Set
    End Property
    Public Property NoiLamViec() As Integer
        Get
            Return _noiLamViec
        End Get
        Set(ByVal Value As Integer)
            _noiLamViec = Value
        End Set
    End Property
    Public Property NganhNghe() As Integer
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As Integer)
            _nganhNghe = Value
        End Set
    End Property
    Public Property DiaChiLamViec() As String
        Get
            Return _diaChiLamViec
        End Get
        Set(ByVal Value As String)
            _diaChiLamViec = Value
        End Set
    End Property
    Public Property NuocLamViec() As Integer
        Get
            Return _nuocLamViec
        End Get
        Set(ByVal Value As Integer)
            _nuocLamViec = Value
        End Set
    End Property
    Public Property LoaiThatNghiep() As String
        Get
            Return _loaiThatNghiep
        End Get
        Set(ByVal Value As String)
            _loaiThatNghiep = Value
        End Set
    End Property
    Public Property ThoiGianThatNghiep() As String
        Get
            Return _thoiGianThatNghiep
        End Get
        Set(ByVal Value As String)
            _thoiGianThatNghiep = Value
        End Set
    End Property
    Public Property LyDoKhongThamGia() As String
        Get
            Return _lyDoKhongThamGia
        End Get
        Set(ByVal Value As String)
            _lyDoKhongThamGia = Value
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
    Public Property LoaiBienDong() As String
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As String)
            _loaiBienDong = Value
        End Set
    End Property
    Public Property CatChet() As Boolean
        Get
            Return _catChet
        End Get
        Set(ByVal Value As Boolean)
            _catChet = Value
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
    Public Property DeletedUser() As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
Public Class CMS_Provide_ConfigInfo

#Region "Private Members"
    Private _proConfig_ID As String = String.Empty
    Private _proConfig_Name As String = String.Empty
    Private _proConfig_Value As String = String.Empty
    Private _isActive As Boolean
    Private _isLock As Boolean
    Private _isFlag As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalId As Integer
    Private _total As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _phuongXa As Integer
    Private _thonTo As Integer
    Private _isOrder As Integer
#End Region

#Region "Public Properties"

    Public Property IsOrder As Integer
        Get
            Return _isOrder
        End Get
        Set(ByVal Value As Integer)
            _isOrder = Value
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
    Public Property PhuongXa As Integer
        Get
            Return _phuongXa
        End Get
        Set(ByVal Value As Integer)
            _phuongXa = Value
        End Set
    End Property
    Public Property ThonTo As Integer
        Get
            Return _thonTo
        End Get
        Set(ByVal Value As Integer)
            _thonTo = Value
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

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property ProConfig_ID() As String
        Get
            Return _proConfig_ID
        End Get
        Set(ByVal Value As String)
            _proConfig_ID = Value
        End Set
    End Property

    Public Property ProConfig_Name() As String
        Get
            Return _proConfig_Name
        End Get
        Set(ByVal Value As String)
            _proConfig_Name = Value
        End Set
    End Property
    Public Property ProConfig_Value() As String
        Get
            Return _proConfig_Value
        End Get
        Set(ByVal Value As String)
            _proConfig_Value = Value
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
    Public Property IsLock() As Boolean
        Get
            Return _isLock
        End Get
        Set(ByVal Value As Boolean)
            _isLock = Value
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
Public Class CMS_Provide_BookInfo

#Region "Private Members"
    Private _book_ID As String = String.Empty
    Private _book_Code As String = String.Empty
    Private _book_Name As String = String.Empty
    Private _year As Integer
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
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

    Public Property Book_ID() As String
        Get
            Return _book_ID
        End Get
        Set(ByVal Value As String)
            _book_ID = Value
        End Set
    End Property

    Public Property Book_Code() As String
        Get
            Return _book_Code
        End Get
        Set(ByVal Value As String)
            _book_Code = Value
        End Set
    End Property
    Public Property Book_Name() As String
        Get
            Return _book_Name
        End Get
        Set(ByVal Value As String)
            _book_Name = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
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
    Public Property DeletedUser() As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
Public Class CMS_ReasonInfo

#Region "Private Members"
    Private _reason_ID As Integer
    Private _reason_Code As String = String.Empty
    Private _reason_Name As String = String.Empty
    Private _reason_Des As String = String.Empty
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

    Public Property Reason_ID() As Integer
        Get
            Return _reason_ID
        End Get
        Set(ByVal Value As Integer)
            _reason_ID = Value
        End Set
    End Property

    Public Property Reason_Code() As String
        Get
            Return _reason_Code
        End Get
        Set(ByVal Value As String)
            _reason_Code = Value
        End Set
    End Property
    Public Property Reason_Name() As String
        Get
            Return _reason_Name
        End Get
        Set(ByVal Value As String)
            _reason_Name = Value
        End Set
    End Property
    Public Property Reason_Des() As String
        Get
            Return _reason_Des
        End Get
        Set(ByVal Value As String)
            _reason_Des = Value
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

    Public Property Education_ID() As Integer
        Get
            Return _Education_ID
        End Get
        Set(ByVal Value As Integer)
            _Education_ID = Value
        End Set
    End Property

    Public Property Education_Code() As String
        Get
            Return _Education_Code
        End Get
        Set(ByVal Value As String)
            _Education_Code = Value
        End Set
    End Property
    Public Property Education_Name() As String
        Get
            Return _Education_Name
        End Get
        Set(ByVal Value As String)
            _Education_Name = Value
        End Set
    End Property
    Public Property Education_Des() As String
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
Public Class CMS_LoaiSoInfo

#Region "Private Members"
    Private _ID As Integer
    Private _Code As String = String.Empty
    Private _Name As String = String.Empty
    Private _isActive As Boolean
    Private _isDeleted As Boolean
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
            Return _ID
        End Get
        Set(ByVal Value As Integer)
            _ID = Value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(ByVal Value As String)
            _Code = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
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
    Public Property IsDeleted() As Boolean
        Get
            Return _isDeleted
        End Get
        Set(ByVal Value As Boolean)
            _isDeleted = Value
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
Public Class CMS_TypeUnemployInfo

#Region "Private Members"
    Private _TypeUnemploy_ID As Integer
    Private _TypeUnemploy_Code As String = String.Empty
    Private _TypeUnemploy_Name As String = String.Empty
    Private _TypeUnemploy_Des As String = String.Empty
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

    Public Property TypeUnemploy_ID() As Integer
        Get
            Return _TypeUnemploy_ID
        End Get
        Set(ByVal Value As Integer)
            _TypeUnemploy_ID = Value
        End Set
    End Property

    Public Property TypeUnemploy_Code() As String
        Get
            Return _TypeUnemploy_Code
        End Get
        Set(ByVal Value As String)
            _TypeUnemploy_Code = Value
        End Set
    End Property
    Public Property TypeUnemploy_Name() As String
        Get
            Return _TypeUnemploy_Name
        End Get
        Set(ByVal Value As String)
            _TypeUnemploy_Name = Value
        End Set
    End Property
    Public Property TypeUnemploy_Des() As String
        Get
            Return _TypeUnemploy_Des
        End Get
        Set(ByVal Value As String)
            _TypeUnemploy_Des = Value
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
Public Class CMS_Provide_BienDongKhauInfo

#Region "Private Members"
    Private _bienDong_ID As String = String.Empty
    Private _idKey As String = String.Empty
    Private _idPa As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThonTo As Integer
    Private _loaiBienDong As Integer
    Private _giaTriBDMoi As Integer
    Private _giaTriBDCu As Integer
    Private _isFlag As Integer
    Private _yearID As Integer
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

    Public Property BienDong_ID() As String
        Get
            Return _bienDong_ID
        End Get
        Set(ByVal Value As String)
            _bienDong_ID = Value
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
    Public Property IdPa() As String
        Get
            Return _idPa
        End Get
        Set(ByVal Value As String)
            _idPa = Value
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
    Public Property MaThonTo() As Integer
        Get
            Return _maThonTo
        End Get
        Set(ByVal Value As Integer)
            _maThonTo = Value
        End Set
    End Property
    Public Property LoaiBienDong() As Integer
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As Integer)
            _loaiBienDong = Value
        End Set
    End Property
    Public Property GiaTriBDMoi() As Integer
        Get
            Return _giaTriBDMoi
        End Get
        Set(ByVal Value As Integer)
            _giaTriBDMoi = Value
        End Set
    End Property
    Public Property GiaTriBDCu() As Integer
        Get
            Return _giaTriBDCu
        End Get
        Set(ByVal Value As Integer)
            _giaTriBDCu = Value
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
    Public Property YearID() As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
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
Public Class CMS_Provide_BienDongHoInfo

#Region "Private Members"
    Private _bienDong_ID As String = String.Empty
    Private _idKey As String = String.Empty
    Private _idPa As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThonTo As Integer
    Private _loaiBienDong As Integer
    Private _giaTriBDMoi As Integer
    Private _giaTriBDCu As Integer
    Private _isFlag As Integer
    Private _yearID As Integer
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

    Public Property BienDong_ID() As String
        Get
            Return _bienDong_ID
        End Get
        Set(ByVal Value As String)
            _bienDong_ID = Value
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
    Public Property IdPa() As String
        Get
            Return _idPa
        End Get
        Set(ByVal Value As String)
            _idPa = Value
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
    Public Property MaThonTo() As Integer
        Get
            Return _maThonTo
        End Get
        Set(ByVal Value As Integer)
            _maThonTo = Value
        End Set
    End Property
    Public Property LoaiBienDong() As Integer
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As Integer)
            _loaiBienDong = Value
        End Set
    End Property
    Public Property GiaTriBDMoi() As Integer
        Get
            Return _giaTriBDMoi
        End Get
        Set(ByVal Value As Integer)
            _giaTriBDMoi = Value
        End Set
    End Property
    Public Property GiaTriBDCu() As Integer
        Get
            Return _giaTriBDCu
        End Get
        Set(ByVal Value As Integer)
            _giaTriBDCu = Value
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
    Public Property YearID() As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
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
Public Class CMS_Provide_HistoryInfo

#Region "Private Members"
    Private _history_ID As String = String.Empty
    Private _history_Name As String = String.Empty
    Private _history_Des As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _isFlag As Integer
    Private _totalHoAdd As Integer
    Private _totalKhauAdd As Integer
    Private _totalHo As Integer
    Private _totalKhau As Integer
    Private _yearID As Integer
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

    Public Property History_ID() As String
        Get
            Return _history_ID
        End Get
        Set(ByVal Value As String)
            _history_ID = Value
        End Set
    End Property

    Public Property History_Name() As String
        Get
            Return _history_Name
        End Get
        Set(ByVal Value As String)
            _history_Name = Value
        End Set
    End Property
    Public Property History_Des() As String
        Get
            Return _history_Des
        End Get
        Set(ByVal Value As String)
            _history_Des = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
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
    Public Property TotalHoAdd() As Integer
        Get
            Return _totalHoAdd
        End Get
        Set(ByVal Value As Integer)
            _totalHoAdd = Value
        End Set
    End Property
    Public Property TotalKhauAdd() As Integer
        Get
            Return _totalKhauAdd
        End Get
        Set(ByVal Value As Integer)
            _totalKhauAdd = Value
        End Set
    End Property
    Public Property TotalHo() As Integer
        Get
            Return _totalHo
        End Get
        Set(ByVal Value As Integer)
            _totalHo = Value
        End Set
    End Property
    Public Property TotalKhau() As Integer
        Get
            Return _totalKhau
        End Get
        Set(ByVal Value As Integer)
            _totalKhau = Value
        End Set
    End Property
    Public Property YearID() As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
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
Public Class CMS_HoGD_BackupInfo

#Region "Private Members"
    Private _idBackup As Integer
    Private _id As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _maHo As String = String.Empty
    Private _tenChuHo As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _soNhanKhau As Integer
    Private _loaiHo As String = String.Empty
    Private _idSo As String = String.Empty
    Private _loaiBienDong As Integer
    Private _yearID As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Integer
    Private _isFlag As Integer
    Private _total As Integer
    Private _khuVuc As Integer
    Private _JoinHDKT As Integer
    Private _UnJoinHDKT As Integer
#End Region

#Region "Public Properties"
    Public Property IsNew As Boolean
    Public Property KhuVuc As Integer
        Get
            Return _khuVuc
        End Get
        Set(ByVal Value As Integer)
            _khuVuc = Value
        End Set
    End Property
    Public Property JoinHDKT As Integer
        Get
            Return _JoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _JoinHDKT = Value
        End Set
    End Property
    Public Property UnJoinHDKT As Integer
        Get
            Return _UnJoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _UnJoinHDKT = Value
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
    Public Property IdBackup() As Integer
        Get
            Return _idBackup
        End Get
        Set(ByVal Value As Integer)
            _idBackup = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property MaHo() As String
        Get
            Return _maHo
        End Get
        Set(ByVal Value As String)
            _maHo = Value
        End Set
    End Property
    Public Property TenChuHo() As String
        Get
            Return _tenChuHo
        End Get
        Set(ByVal Value As String)
            _tenChuHo = Value
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
    Public Property SoNhanKhau() As Integer
        Get
            Return _soNhanKhau
        End Get
        Set(ByVal Value As Integer)
            _soNhanKhau = Value
        End Set
    End Property
    Public Property LoaiHo() As String
        Get
            Return _loaiHo
        End Get
        Set(ByVal Value As String)
            _loaiHo = Value
        End Set
    End Property
    Public Property IdSo() As String
        Get
            Return _idSo
        End Get
        Set(ByVal Value As String)
            _idSo = Value
        End Set
    End Property
    Public Property LoaiBienDong() As Integer
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As Integer)
            _loaiBienDong = Value
        End Set
    End Property
    Public Property YearID() As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
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
    Public Property DeletedUser() As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
    Public Property IsFlag() As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_HoGD_Khau_BackupInfo

#Region "Private Members"
    Private _idBackup As Integer
    Private _id As String = String.Empty
    Private _maDoiTuong As String = String.Empty
    Private _cMND As String = String.Empty
    Private _idHo As String = String.Empty
    Private _maHo As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _soThuTu As Integer
    Private _hoTen As String = String.Empty
    Private _namSinh As Integer
    Private _gioiTinh As Integer
    Private _danToc As String = String.Empty
    Private _quanHe As String = String.Empty
    Private _ngaySinh As DateTime
    Private _trinhDoGD As Integer
    Private _trinhDoCM As Integer
    Private _linhVucDT As Integer
    Private _hinhThuc As Integer
    Private _loaiHinhKT As Integer
    Private _noiLamViec As Integer
    Private _nganhNghe As String = String.Empty
    Private _diaChiLamViec As String = String.Empty
    Private _nuocLamViec As Integer
    Private _loaiThatNghiep As Integer
    Private _congViecThamGia As Integer
    Private _thoiGianThatNghiep As String = String.Empty
    Private _lyDoKhongThamGia As Integer
    Private _ghiChu As String = String.Empty
    Private _loaiBienDong As Integer
    Private _catChet As Boolean
    Private _year As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Integer
    Private _isFlag As Integer
    Private _total As Integer
    Private _khuVuc As Integer
    Private _JoinHDKT As Integer
    Private _UnJoinHDKT As Integer
#End Region

#Region "Public Properties"
    Public Property IsNew As Boolean
    Public Property ChuyenDen As Integer
    Public Property KhuVuc As Integer
        Get
            Return _khuVuc
        End Get
        Set(ByVal Value As Integer)
            _khuVuc = Value
        End Set
    End Property
    Public Property JoinHDKT As Integer
        Get
            Return _JoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _JoinHDKT = Value
        End Set
    End Property
    Public Property UnJoinHDKT As Integer
        Get
            Return _UnJoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _UnJoinHDKT = Value
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
    Public Property IdBackup() As Integer
        Get
            Return _idBackup
        End Get
        Set(ByVal Value As Integer)
            _idBackup = Value
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
    Public Property MaDoiTuong() As String
        Get
            Return _maDoiTuong
        End Get
        Set(ByVal Value As String)
            _maDoiTuong = Value
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
    Public Property IdHo() As String
        Get
            Return _idHo
        End Get
        Set(ByVal Value As String)
            _idHo = Value
        End Set
    End Property
    Public Property MaHo() As String
        Get
            Return _maHo
        End Get
        Set(ByVal Value As String)
            _maHo = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property SoThuTu() As Integer
        Get
            Return _soThuTu
        End Get
        Set(ByVal Value As Integer)
            _soThuTu = Value
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
    Public Property NamSinh() As Integer
        Get
            Return _namSinh
        End Get
        Set(ByVal Value As Integer)
            _namSinh = Value
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
    Public Property DanToc() As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
        End Set
    End Property
    Public Property QuanHe() As String
        Get
            Return _quanHe
        End Get
        Set(ByVal Value As String)
            _quanHe = Value
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
    Public Property TrinhDoGD() As Integer
        Get
            Return _trinhDoGD
        End Get
        Set(ByVal Value As Integer)
            _trinhDoGD = Value
        End Set
    End Property
    Public Property TrinhDoCM() As Integer
        Get
            Return _trinhDoCM
        End Get
        Set(ByVal Value As Integer)
            _trinhDoCM = Value
        End Set
    End Property
    Public Property LinhVucDT() As Integer
        Get
            Return _linhVucDT
        End Get
        Set(ByVal Value As Integer)
            _linhVucDT = Value
        End Set
    End Property
    Public Property HinhThuc() As Integer
        Get
            Return _hinhThuc
        End Get
        Set(ByVal Value As Integer)
            _hinhThuc = Value
        End Set
    End Property
    Public Property LoaiHinhKT() As Integer
        Get
            Return _loaiHinhKT
        End Get
        Set(ByVal Value As Integer)
            _loaiHinhKT = Value
        End Set
    End Property
    Public Property NoiLamViec() As Integer
        Get
            Return _noiLamViec
        End Get
        Set(ByVal Value As Integer)
            _noiLamViec = Value
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
    Public Property DiaChiLamViec() As String
        Get
            Return _diaChiLamViec
        End Get
        Set(ByVal Value As String)
            _diaChiLamViec = Value
        End Set
    End Property
    Public Property NuocLamViec() As Integer
        Get
            Return _nuocLamViec
        End Get
        Set(ByVal Value As Integer)
            _nuocLamViec = Value
        End Set
    End Property
    Public Property LoaiThatNghiep() As Integer
        Get
            Return _loaiThatNghiep
        End Get
        Set(ByVal Value As Integer)
            _loaiThatNghiep = Value
        End Set
    End Property
    Public Property CongViecThamGia() As Integer
        Get
            Return _congViecThamGia
        End Get
        Set(ByVal Value As Integer)
            _congViecThamGia = Value
        End Set
    End Property
    Public Property ThoiGianThatNghiep() As String
        Get
            Return _thoiGianThatNghiep
        End Get
        Set(ByVal Value As String)
            _thoiGianThatNghiep = Value
        End Set
    End Property
    Public Property LyDoKhongThamGia() As Integer
        Get
            Return _lyDoKhongThamGia
        End Get
        Set(ByVal Value As Integer)
            _lyDoKhongThamGia = Value
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
    Public Property LoaiBienDong() As Integer
        Get
            Return _loaiBienDong
        End Get
        Set(ByVal Value As Integer)
            _loaiBienDong = Value
        End Set
    End Property
    Public Property CatChet() As Boolean
        Get
            Return _catChet
        End Get
        Set(ByVal Value As Boolean)
            _catChet = Value
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
    Public Property DeletedUser() As String
        Get
            Return _deletedUser
        End Get
        Set(ByVal Value As String)
            _deletedUser = Value
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
    Public Property IsFlag() As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_CungLDReportInfo

#Region "Private Members"
    Private _ds15KyTruoc As Integer
    Private _ds15KyBC As Integer
    Private _thamgiaKTKyTruoc As Integer
    Private _thamgiaKTKyBC As Integer
    Private _cvlNamKyTruoc As Integer
    Private _cvlNamKyBC As Integer
    Private _cvlNuKyTruoc As Integer
    Private _cvlNuKyBC As Integer
    Private _cvlNNKyTruoc As Integer
    Private _cvlNNKyBC As Integer
    Private _cvlCNXDKyTruoc As Integer
    Private _cvlCNXDKyBC As Integer
    Private _cvlTMDVKyTruoc As Integer
    Private _cvlTMDVKyBC As Integer
    Private _tnNamKyTruoc As Integer
    Private _tnNamKyBC As Integer
    Private _tnNuKyTruoc As Integer
    Private _tnNuKyBC As Integer
    Private _ktg1KyTruoc As Integer
    Private _ktg1KyBC As Integer
    Private _ktg2KyTruoc As Integer
    Private _ktg2KyBC As Integer
    Private _ktg3KyTruoc As Integer
    Private _ktg3KyBC As Integer
    Private _ktg4KyTruoc As Integer
    Private _ktg4KyBC As Integer
    Private _ktg5KyTruoc As Integer
    Private _ktg5KyBC As Integer
    Private _ktg6KyTruoc As Integer
    Private _ktg6KyBC As Integer
    Private _ktg7KyTruoc As Integer
    Private _ktg7KyBC As Integer
    Private _ktg8KyTruoc As Integer
    Private _ktg8KyBC As Integer
    Private _total As Integer
    Private _stt As Integer
    Private _name As String
#End Region

#Region "Public Properties"
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property STT As Integer
        Get
            Return _stt
        End Get
        Set(ByVal Value As Integer)
            _stt = Value
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
    Public Property Ds15KyTruoc() As Integer
        Get
            Return _ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ds15KyTruoc = Value
        End Set
    End Property
    Public Property Ds15KyBC() As Integer
        Get
            Return _ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _ds15KyBC = Value
        End Set
    End Property
    Public Property ThamgiaKTKyTruoc() As Integer
        Get
            Return _thamgiaKTKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _thamgiaKTKyTruoc = Value
        End Set
    End Property
    Public Property ThamgiaKTKyBC() As Integer
        Get
            Return _thamgiaKTKyBC
        End Get
        Set(ByVal Value As Integer)
            _thamgiaKTKyBC = Value
        End Set
    End Property
    Public Property CvlNamKyTruoc() As Integer
        Get
            Return _cvlNamKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cvlNamKyTruoc = Value
        End Set
    End Property
    Public Property CvlNamKyBC() As Integer
        Get
            Return _cvlNamKyBC
        End Get
        Set(ByVal Value As Integer)
            _cvlNamKyBC = Value
        End Set
    End Property
    Public Property CvlNuKyTruoc() As Integer
        Get
            Return _cvlNuKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cvlNuKyTruoc = Value
        End Set
    End Property
    Public Property CvlNuKyBC() As Integer
        Get
            Return _cvlNuKyBC
        End Get
        Set(ByVal Value As Integer)
            _cvlNuKyBC = Value
        End Set
    End Property
    Public Property CvlNNKyTruoc() As Integer
        Get
            Return _cvlNNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cvlNNKyTruoc = Value
        End Set
    End Property
    Public Property CvlNNKyBC() As Integer
        Get
            Return _cvlNNKyBC
        End Get
        Set(ByVal Value As Integer)
            _cvlNNKyBC = Value
        End Set
    End Property
    Public Property CvlCNXDKyTruoc() As Integer
        Get
            Return _cvlCNXDKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cvlCNXDKyTruoc = Value
        End Set
    End Property
    Public Property CvlCNXDKyBC() As Integer
        Get
            Return _cvlCNXDKyBC
        End Get
        Set(ByVal Value As Integer)
            _cvlCNXDKyBC = Value
        End Set
    End Property
    Public Property CvlTMDVKyTruoc() As Integer
        Get
            Return _cvlTMDVKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cvlTMDVKyTruoc = Value
        End Set
    End Property
    Public Property CvlTMDVKyBC() As Integer
        Get
            Return _cvlTMDVKyBC
        End Get
        Set(ByVal Value As Integer)
            _cvlTMDVKyBC = Value
        End Set
    End Property
    Public Property TnNamKyTruoc() As Integer
        Get
            Return _tnNamKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tnNamKyTruoc = Value
        End Set
    End Property
    Public Property TnNamKyBC() As Integer
        Get
            Return _tnNamKyBC
        End Get
        Set(ByVal Value As Integer)
            _tnNamKyBC = Value
        End Set
    End Property
    Public Property TnNuKyTruoc() As Integer
        Get
            Return _tnNuKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tnNuKyTruoc = Value
        End Set
    End Property
    Public Property TnNuKyBC() As Integer
        Get
            Return _tnNuKyBC
        End Get
        Set(ByVal Value As Integer)
            _tnNuKyBC = Value
        End Set
    End Property
    Public Property Ktg1KyTruoc() As Integer
        Get
            Return _ktg1KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg1KyTruoc = Value
        End Set
    End Property
    Public Property Ktg1KyBC() As Integer
        Get
            Return _ktg1KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg1KyBC = Value
        End Set
    End Property
    Public Property Ktg2KyTruoc() As Integer
        Get
            Return _ktg2KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg2KyTruoc = Value
        End Set
    End Property
    Public Property Ktg2KyBC() As Integer
        Get
            Return _ktg2KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg2KyBC = Value
        End Set
    End Property
    Public Property Ktg3KyTruoc() As Integer
        Get
            Return _ktg3KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg3KyTruoc = Value
        End Set
    End Property
    Public Property Ktg3KyBC() As Integer
        Get
            Return _ktg3KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg3KyBC = Value
        End Set
    End Property
    Public Property Ktg4KyTruoc() As Integer
        Get
            Return _ktg4KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg4KyTruoc = Value
        End Set
    End Property
    Public Property Ktg4KyBC() As Integer
        Get
            Return _ktg4KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg4KyBC = Value
        End Set
    End Property
    Public Property Ktg5KyTruoc() As Integer
        Get
            Return _ktg5KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg5KyTruoc = Value
        End Set
    End Property
    Public Property Ktg5KyBC() As Integer
        Get
            Return _ktg5KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg5KyBC = Value
        End Set
    End Property
    Public Property Ktg6KyTruoc() As Integer
        Get
            Return _ktg6KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg6KyTruoc = Value
        End Set
    End Property
    Public Property Ktg6KyBC() As Integer
        Get
            Return _ktg6KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg6KyBC = Value
        End Set
    End Property
    Public Property Ktg7KyTruoc() As Integer
        Get
            Return _ktg7KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg7KyTruoc = Value
        End Set
    End Property
    Public Property Ktg7KyBC() As Integer
        Get
            Return _ktg7KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg7KyBC = Value
        End Set
    End Property
    Public Property Ktg8KyTruoc() As Integer
        Get
            Return _ktg8KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ktg8KyTruoc = Value
        End Set
    End Property
    Public Property Ktg8KyBC() As Integer
        Get
            Return _ktg8KyBC
        End Get
        Set(ByVal Value As Integer)
            _ktg8KyBC = Value
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
Public Class BC_DSInfo

#Region "Private Members"
    Private _idTV As String = String.Empty
    Private _idHo As String = String.Empty
    Private _maHo As String = String.Empty
    Private _HoTenHo As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _hoTen As String = String.Empty
    Private _namSinh As Short
    Private _gioiTinh As Short
    Private _danToc As String = String.Empty
    Private _ngaySinh As DateTime
    Private _createdDate As DateTime
    Private _updatedDate As DateTime
    Private _trinhDoGD As Short
    Private _trinhDoCM As Short
    Private _linhVucDT As Short
    Private _hinhThuc As Short
    Private _loaiHinhKT As Short
    Private _noiLamViec As Short
    Private _NuocLamViec As Short
    Private _nganhNghe As String = String.Empty
    Private _diaChiLamViec As String = String.Empty
    Private _loaiThatNghiep As Short
    Private _thoiGianThatNghiep As String
    Private _congViecThamGia As Short
    Private _lyDoKhongThamGia As Short
    Private _yearID As Short
    Private _total As Integer
    Private _NCVL As Boolean
    Private _NTN As Boolean
    Private _KTGHDKT As Boolean
    Private _maTinh_HT As Integer
    Private _maHuyen_HT As Integer
    Private _maXa_HT As Integer
    Private _maThon_HT As Integer
    Private _diaChi_HT As String
    Private _maTinh_TT As Integer
    Private _maHuyen_TT As Integer
    Private _maXa_TT As Integer
    Private _maThon_TT As Integer
    Private _diaChi_TT As String
    Private _DTUT_NKT As Integer
    Private _DTUT_HN As Integer
    Private _DTUT_DTTS As Integer
    Private _DTUT_CN As Integer
    Private _DTUT_THUHOI As Integer
    Private _DTUT_NCC As Integer

    Private _cMND As String = String.Empty
    Private _SoBHXH As String = String.Empty

#End Region

#Region "Public Properties"

    Public Property DTUT_CN As Integer
        Get
            Return _DTUT_CN
        End Get
        Set(ByVal Value As Integer)
            _DTUT_CN = Value
        End Set
    End Property
    Public Property DTUT_THUHOI As Integer
        Get
            Return _DTUT_THUHOI
        End Get
        Set(ByVal Value As Integer)
            _DTUT_THUHOI = Value
        End Set
    End Property
    Public Property DTUT_NCC As Integer
        Get
            Return _DTUT_NCC
        End Get
        Set(ByVal Value As Integer)
            _DTUT_NCC = Value
        End Set
    End Property
    Public Property CMND As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property SoBHXH As String
        Get
            Return _SoBHXH
        End Get
        Set(ByVal Value As String)
            _SoBHXH = Value
        End Set
    End Property

    Public Property DiaChi_HT As String
        Get
            Return _diaChi_HT
        End Get
        Set(ByVal Value As String)
            _diaChi_HT = Value
        End Set
    End Property
    Public Property DiaChi_TT As String
        Get
            Return _diaChi_TT
        End Get
        Set(ByVal Value As String)
            _diaChi_TT = Value
        End Set
    End Property

    Public Property MaTinh_HT As Integer
        Get
            Return _maTinh_HT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_HT = Value
        End Set
    End Property
    Public Property MaHuyen_HT As Integer
        Get
            Return _maHuyen_HT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_HT = Value
        End Set
    End Property
    Public Property MaXa_HT As Integer
        Get
            Return _maXa_HT
        End Get
        Set(ByVal Value As Integer)
            _maXa_HT = Value
        End Set
    End Property
    Public Property MaThon_HT As Integer
        Get
            Return _maThon_HT
        End Get
        Set(ByVal Value As Integer)
            _maThon_HT = Value
        End Set
    End Property
    Public Property MaTinh_TT As Integer
        Get
            Return _maTinh_TT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_TT = Value
        End Set
    End Property
    Public Property MaHuyen_TT As Integer
        Get
            Return _maHuyen_TT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_TT = Value
        End Set
    End Property
    Public Property MaXa_TT As Integer
        Get
            Return _maXa_TT
        End Get
        Set(ByVal Value As Integer)
            _maXa_TT = Value
        End Set
    End Property
    Public Property MaThon_TT As Integer
        Get
            Return _maThon_TT
        End Get
        Set(ByVal Value As Integer)
            _maThon_TT = Value
        End Set
    End Property
    Public Property DTUT_NKT As Integer
        Get
            Return _DTUT_NKT
        End Get
        Set(ByVal Value As Integer)
            _DTUT_NKT = Value
        End Set
    End Property
    Public Property DTUT_HN As Integer
        Get
            Return _DTUT_HN
        End Get
        Set(ByVal Value As Integer)
            _DTUT_HN = Value
        End Set
    End Property
    Public Property DTUT_DTTS As Integer
        Get
            Return _DTUT_DTTS
        End Get
        Set(ByVal Value As Integer)
            _DTUT_DTTS = Value
        End Set
    End Property
    Public Property KTGHDKT As Boolean
        Get
            Return _KTGHDKT
        End Get
        Set(ByVal Value As Boolean)
            _KTGHDKT = Value
        End Set
    End Property
    Public Property NCVL As Boolean
        Get
            Return _NCVL
        End Get
        Set(ByVal Value As Boolean)
            _NCVL = Value
        End Set
    End Property
    Public Property NTN As Boolean
        Get
            Return _NTN
        End Get
        Set(ByVal Value As Boolean)
            _NTN = Value
        End Set
    End Property
    Public Property NuocLamViec As Short
        Get
            Return _NuocLamViec
        End Get
        Set(ByVal Value As Short)
            _NuocLamViec = Value
        End Set
    End Property
    Public Property HoTenHo As String
        Get
            Return _HoTenHo
        End Get
        Set(ByVal Value As String)
            _HoTenHo = Value
        End Set
    End Property
    Public Property ThoiGianThatNghiep As String
        Get
            Return _thoiGianThatNghiep
        End Get
        Set(ByVal Value As String)
            _thoiGianThatNghiep = Value
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

    Public Property IdTV() As String
        Get
            Return _idTV
        End Get
        Set(ByVal Value As String)
            _idTV = Value
        End Set
    End Property

    Public Property IdHo() As String
        Get
            Return _idHo
        End Get
        Set(ByVal Value As String)
            _idHo = Value
        End Set
    End Property
    Public Property MaHo() As String
        Get
            Return _maHo
        End Get
        Set(ByVal Value As String)
            _maHo = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
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
    Public Property NamSinh() As Short
        Get
            Return _namSinh
        End Get
        Set(ByVal Value As Short)
            _namSinh = Value
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
    Public Property DanToc() As String
        Get
            Return _danToc
        End Get
        Set(ByVal Value As String)
            _danToc = Value
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
    Public Property TrinhDoGD() As Short
        Get
            Return _trinhDoGD
        End Get
        Set(ByVal Value As Short)
            _trinhDoGD = Value
        End Set
    End Property
    Public Property TrinhDoCM() As Short
        Get
            Return _trinhDoCM
        End Get
        Set(ByVal Value As Short)
            _trinhDoCM = Value
        End Set
    End Property
    Public Property LinhVucDT() As Short
        Get
            Return _linhVucDT
        End Get
        Set(ByVal Value As Short)
            _linhVucDT = Value
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
    Public Property LoaiHinhKT() As Short
        Get
            Return _loaiHinhKT
        End Get
        Set(ByVal Value As Short)
            _loaiHinhKT = Value
        End Set
    End Property
    Public Property NoiLamViec() As Short
        Get
            Return _noiLamViec
        End Get
        Set(ByVal Value As Short)
            _noiLamViec = Value
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
    Public Property DiaChiLamViec() As String
        Get
            Return _diaChiLamViec
        End Get
        Set(ByVal Value As String)
            _diaChiLamViec = Value
        End Set
    End Property
    Public Property LoaiThatNghiep() As Short
        Get
            Return _loaiThatNghiep
        End Get
        Set(ByVal Value As Short)
            _loaiThatNghiep = Value
        End Set
    End Property
    Public Property CongViecThamGia() As Short
        Get
            Return _congViecThamGia
        End Get
        Set(ByVal Value As Short)
            _congViecThamGia = Value
        End Set
    End Property
    Public Property LyDoKhongThamGia() As Short
        Get
            Return _lyDoKhongThamGia
        End Get
        Set(ByVal Value As Short)
            _lyDoKhongThamGia = Value
        End Set
    End Property
    Public Property YearID() As Short
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Short)
            _yearID = Value
        End Set
    End Property
#End Region

End Class
Public Class BC_TongHopInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _RegionID As Integer
    Private _yearID As Integer
    Private _banDau As Integer
    Private _thayDoi As Integer
    Private _themMoi As Integer
    Private _bienDong As Integer
    Private _khac As Integer
    Private _value1 As Integer
    Private _value2 As Integer
    Private _total As Integer
    Private _typeData As Integer
#End Region

#Region "Public Properties"
    Public Property RegionID As Integer
        Get
            Return _RegionID
        End Get
        Set(ByVal Value As Integer)
            _RegionID = Value
        End Set
    End Property
    Public Property TypeData As Integer
        Get
            Return _typeData
        End Get
        Set(ByVal Value As Integer)
            _typeData = Value
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property YearID() As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
        End Set
    End Property
    Public Property BanDau() As Integer
        Get
            Return _banDau
        End Get
        Set(ByVal Value As Integer)
            _banDau = Value
        End Set
    End Property
    Public Property ThayDoi() As Integer
        Get
            Return _thayDoi
        End Get
        Set(ByVal Value As Integer)
            _thayDoi = Value
        End Set
    End Property
    Public Property ThemMoi() As Integer
        Get
            Return _themMoi
        End Get
        Set(ByVal Value As Integer)
            _themMoi = Value
        End Set
    End Property
    Public Property BienDong() As Integer
        Get
            Return _bienDong
        End Get
        Set(ByVal Value As Integer)
            _bienDong = Value
        End Set
    End Property
    Public Property Khac() As Integer
        Get
            Return _khac
        End Get
        Set(ByVal Value As Integer)
            _khac = Value
        End Set
    End Property
    Public Property Value1() As Integer
        Get
            Return _value1
        End Get
        Set(ByVal Value As Integer)
            _value1 = Value
        End Set
    End Property
    Public Property Value2() As Integer
        Get
            Return _value2
        End Get
        Set(ByVal Value As Integer)
            _value2 = Value
        End Set
    End Property
#End Region

End Class
Public Class ReportInfo

#Region "Private Members"
    Public Property IsLevel As Integer
    Public Property Regional_ID As Integer
    Public Property Regional_Name As String
    Private _STT As Double = 0
    Private _ColName As String
    Private _Value1 As Double = 0
    Private _Value2 As Double = 0
    Private _Value3 As Double = 0
    Private _Value4 As Double = 0
    Private _Value5 As Double = 0
    Private _Value6 As Double = 0
    Private _Value7 As Double = 0
    Private _Value8 As Double = 0
    Private _Value9 As Double = 0
    Private _Value10 As Double = 0
    Private _Value11 As Double = 0
    Private _Value12 As Double = 0
    Private _Value13 As Double = 0
    Private _Value14 As Double = 0
    Private _Value15 As Double = 0
    Private _Value16 As Double = 0
    Private _Value17 As Double = 0
    Private _Value18 As Double = 0
    Private _Value19 As Double = 0
    Private _Value20 As Double = 0
    Private _Value21 As Double = 0
    Private _Value22 As Double = 0
    Private _Value23 As Double = 0
    Private _Value24 As Double = 0
    Private _Sum1 As Double = 0
    Private _Sum2 As Double = 0
    Private _Sum3 As Double = 0
    Private _Sum4 As Double = 0
    Private _Sum5 As Double = 0
    Private _Sum6 As Double = 0
    Private _Sum7 As Double = 0
    Private _Sum8 As Double = 0
    Private _Sum9 As Double = 0
    Private _Sum10 As Double = 0
    Private _Sum11 As Double = 0
    Private _Sum12 As Double = 0
    Private _Sum13 As Double = 0
    Private _Sum14 As Double = 0
    Private _Sum15 As Double = 0
    Private _Sum16 As Double = 0
    Private _Sum17 As Double = 0
    Private _Sum18 As Double = 0
    Private _Sum19 As Double = 0
    Private _Sum20 As Double = 0
    Private _Sum21 As Double = 0
    Private _Sum22 As Double = 0
    Private _Sum23 As Double = 0
    Private _Sum24 As Double = 0
#End Region

#Region "Public Properties"
    Public Property ColName As String
        Get
            Return _ColName
        End Get
        Set(ByVal Value As String)
            _ColName = Value
        End Set
    End Property
    Public Property STT As Double
        Get
            Return _STT
        End Get
        Set(ByVal Value As Double)
            _STT = Value
        End Set
    End Property

    Public Property Sum23 As Double
        Get
            Return _Sum23
        End Get
        Set(ByVal Value As Double)
            _Sum23 = Value
        End Set
    End Property
    Public Property Sum24 As Double
        Get
            Return _Sum24
        End Get
        Set(ByVal Value As Double)
            _Sum24 = Value
        End Set
    End Property
    Public Property Sum22 As Double
        Get
            Return _Sum22
        End Get
        Set(ByVal Value As Double)
            _Sum22 = Value
        End Set
    End Property
    Public Property Sum21 As Double
        Get
            Return _Sum21
        End Get
        Set(ByVal Value As Double)
            _Sum21 = Value
        End Set
    End Property
    Public Property Sum20 As Double
        Get
            Return _Sum20
        End Get
        Set(ByVal Value As Double)
            _Sum20 = Value
        End Set
    End Property
    Public Property Sum19 As Double
        Get
            Return _Sum19
        End Get
        Set(ByVal Value As Double)
            _Sum19 = Value
        End Set
    End Property
    Public Property Sum18 As Double
        Get
            Return _Sum18
        End Get
        Set(ByVal Value As Double)
            _Sum18 = Value
        End Set
    End Property
    Public Property Sum17 As Double
        Get
            Return _Sum17
        End Get
        Set(ByVal Value As Double)
            _Sum17 = Value
        End Set
    End Property
    Public Property Sum16 As Double
        Get
            Return _Sum16
        End Get
        Set(ByVal Value As Double)
            _Sum16 = Value
        End Set
    End Property
    Public Property Sum15 As Double
        Get
            Return _Sum15
        End Get
        Set(ByVal Value As Double)
            _Sum15 = Value
        End Set
    End Property
    Public Property Sum14 As Double
        Get
            Return _Sum14
        End Get
        Set(ByVal Value As Double)
            _Sum14 = Value
        End Set
    End Property
    Public Property Sum13 As Double
        Get
            Return _Sum13
        End Get
        Set(ByVal Value As Double)
            _Sum13 = Value
        End Set
    End Property
    Public Property Sum12 As Double
        Get
            Return _Sum12
        End Get
        Set(ByVal Value As Double)
            _Sum12 = Value
        End Set
    End Property
    Public Property Sum11 As Double
        Get
            Return _Sum11
        End Get
        Set(ByVal Value As Double)
            _Sum11 = Value
        End Set
    End Property
    Public Property Sum10 As Double
        Get
            Return _Sum10
        End Get
        Set(ByVal Value As Double)
            _Sum10 = Value
        End Set
    End Property
    Public Property Sum9 As Double
        Get
            Return _Sum9
        End Get
        Set(ByVal Value As Double)
            _Sum9 = Value
        End Set
    End Property
    Public Property Sum8 As Double
        Get
            Return _Sum8
        End Get
        Set(ByVal Value As Double)
            _Sum8 = Value
        End Set
    End Property
    Public Property Sum7 As Double
        Get
            Return _Sum7
        End Get
        Set(ByVal Value As Double)
            _Sum7 = Value
        End Set
    End Property
    Public Property Sum6 As Double
        Get
            Return _Sum6
        End Get
        Set(ByVal Value As Double)
            _Sum6 = Value
        End Set
    End Property
    Public Property Sum5 As Double
        Get
            Return _Sum5
        End Get
        Set(ByVal Value As Double)
            _Sum5 = Value
        End Set
    End Property
    Public Property Sum1 As Double
        Get
            Return _Sum1
        End Get
        Set(ByVal Value As Double)
            _Sum1 = Value
        End Set
    End Property
    Public Property Sum2 As Double
        Get
            Return _Sum2
        End Get
        Set(ByVal Value As Double)
            _Sum2 = Value
        End Set
    End Property
    Public Property Sum3 As Double
        Get
            Return _Sum3
        End Get
        Set(ByVal Value As Double)
            _Sum3 = Value
        End Set
    End Property
    Public Property Sum4 As Double
        Get
            Return _Sum4
        End Get
        Set(ByVal Value As Double)
            _Sum4 = Value
        End Set
    End Property
    Public Property Value23 As Double
        Get
            Return _Value23
        End Get
        Set(ByVal Value As Double)
            _Value23 = Value
        End Set
    End Property
    Public Property Value24 As Double
        Get
            Return _Value24
        End Get
        Set(ByVal Value As Double)
            _Value24 = Value
        End Set
    End Property
    Public Property Value22 As Double
        Get
            Return _Value22
        End Get
        Set(ByVal Value As Double)
            _Value22 = Value
        End Set
    End Property
    Public Property Value21 As Double
        Get
            Return _Value21
        End Get
        Set(ByVal Value As Double)
            _Value21 = Value
        End Set
    End Property
    Public Property Value20 As Double
        Get
            Return _Value20
        End Get
        Set(ByVal Value As Double)
            _Value20 = Value
        End Set
    End Property
    Public Property Value19 As Double
        Get
            Return _Value19
        End Get
        Set(ByVal Value As Double)
            _Value19 = Value
        End Set
    End Property
    Public Property Value18 As Double
        Get
            Return _Value18
        End Get
        Set(ByVal Value As Double)
            _Value18 = Value
        End Set
    End Property
    Public Property Value17 As Double
        Get
            Return _Value17
        End Get
        Set(ByVal Value As Double)
            _Value17 = Value
        End Set
    End Property
    Public Property Value16 As Double
        Get
            Return _Value16
        End Get
        Set(ByVal Value As Double)
            _Value16 = Value
        End Set
    End Property
    Public Property Value15 As Double
        Get
            Return _Value15
        End Get
        Set(ByVal Value As Double)
            _Value15 = Value
        End Set
    End Property
    Public Property Value14 As Double
        Get
            Return _Value14
        End Get
        Set(ByVal Value As Double)
            _Value14 = Value
        End Set
    End Property
    Public Property Value13 As Double
        Get
            Return _Value13
        End Get
        Set(ByVal Value As Double)
            _Value13 = Value
        End Set
    End Property
    Public Property Value12 As Double
        Get
            Return _Value12
        End Get
        Set(ByVal Value As Double)
            _Value12 = Value
        End Set
    End Property
    Public Property Value11 As Double
        Get
            Return _Value11
        End Get
        Set(ByVal Value As Double)
            _Value11 = Value
        End Set
    End Property
    Public Property Value10 As Double
        Get
            Return _Value10
        End Get
        Set(ByVal Value As Double)
            _Value10 = Value
        End Set
    End Property
    Public Property Value9 As Double
        Get
            Return _Value9
        End Get
        Set(ByVal Value As Double)
            _Value9 = Value
        End Set
    End Property
    Public Property Value8 As Double
        Get
            Return _Value8
        End Get
        Set(ByVal Value As Double)
            _Value8 = Value
        End Set
    End Property
    Public Property Value7 As Double
        Get
            Return _Value7
        End Get
        Set(ByVal Value As Double)
            _Value7 = Value
        End Set
    End Property
    Public Property Value6 As Double
        Get
            Return _Value6
        End Get
        Set(ByVal Value As Double)
            _Value6 = Value
        End Set
    End Property
    Public Property Value5 As Double
        Get
            Return _Value5
        End Get
        Set(ByVal Value As Double)
            _Value5 = Value
        End Set
    End Property
    Public Property Value1 As Double
        Get
            Return _Value1
        End Get
        Set(ByVal Value As Double)
            _Value1 = Value
        End Set
    End Property
    Public Property Value2 As Double
        Get
            Return _Value2
        End Get
        Set(ByVal Value As Double)
            _Value2 = Value
        End Set
    End Property
    Public Property Value3 As Double
        Get
            Return _Value3
        End Get
        Set(ByVal Value As Double)
            _Value3 = Value
        End Set
    End Property
    Public Property Value4 As Double
        Get
            Return _Value4
        End Get
        Set(ByVal Value As Double)
            _Value4 = Value
        End Set
    End Property

#End Region

End Class
Public Class CustomRpt
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _Type As String
    Public Property Type() As Int16
        Get
            Return _Type
        End Get
        Set(ByVal value As Int16)
            _Type = value
        End Set
    End Property
    Private _ValSum As String
    Public Property ValSum() As Integer
        Get
            Return _ValSum
        End Get
        Set(ByVal value As Integer)
            _ValSum = value
        End Set
    End Property
End Class
Public Class CustomRptValue
    Private _CCol As Integer
    Public Property CCol() As Integer
        Get
            Return _CCol
        End Get
        Set(ByVal value As Integer)
            _CCol = value
        End Set
    End Property
    Private _RCol As String
    Public Property RCol() As String
        Get
            Return _RCol
        End Get
        Set(ByVal value As String)
            _RCol = value
        End Set
    End Property

    Private _CID As String
    Public Property CID() As String
        Get
            Return _CID
        End Get
        Set(ByVal value As String)
            _CID = value
        End Set
    End Property
    Private _RID As String
    Public Property RID() As String
        Get
            Return _RID
        End Get
        Set(ByVal value As String)
            _RID = value
        End Set
    End Property
    Private _IDW As String
    Public Property IDW() As String
        Get
            Return _IDW
        End Get
        Set(ByVal value As String)
            _IDW = value
        End Set
    End Property
    Private _ColName As Double
    Public Property ColName() As Double
        Get
            Return _ColName
        End Get
        Set(ByVal value As Double)
            _ColName = value
        End Set
    End Property
    Private _ColSum As Double
    Public Property ColSum() As Double
        Get
            Return _ColSum
        End Get
        Set(ByVal value As Double)
            _ColSum = value
        End Set
    End Property
End Class
Public Class CMS_CungLDInfo
#Region "Private Members"
    Private _iD As Integer
    Private _maBC As String = String.Empty
    Private _tenVietTat As String = String.Empty
    Private _tenBaoCao As String = String.Empty
    Private _moTa As String = String.Empty
    Private _isFlag As Integer
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

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(ByVal Value As Integer)
            _iD = Value
        End Set
    End Property

    Public Property MaBC As String
        Get
            Return _maBC
        End Get
        Set(ByVal Value As String)
            _maBC = Value
        End Set
    End Property
    Public Property TenBaoCao As String
        Get
            Return _tenBaoCao
        End Get
        Set(ByVal Value As String)
            _tenBaoCao = Value
        End Set
    End Property
    Public Property TenVietTat As String
        Get
            Return _tenVietTat
        End Get
        Set(ByVal Value As String)
            _tenVietTat = Value
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
    Public Property IsFlag As Integer
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Integer)
            _isFlag = Value
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
#End Region

End Class
Public Class CMS_AgeInfo

#Region "Private Members"
    Private _age_ID As Integer
    Private _age_Code As String = String.Empty
    Private _age_Name As String = String.Empty
    Private _ageMin As Short
    Private _ageMax As Short
    Private _ageType As Byte
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

    Public Property Age_ID() As Integer
        Get
            Return _age_ID
        End Get
        Set(ByVal Value As Integer)
            _age_ID = Value
        End Set
    End Property

    Public Property Age_Code() As String
        Get
            Return _age_Code
        End Get
        Set(ByVal Value As String)
            _age_Code = Value
        End Set
    End Property
    Public Property Age_Name() As String
        Get
            Return _age_Name
        End Get
        Set(ByVal Value As String)
            _age_Name = Value
        End Set
    End Property
    Public Property AgeMin() As Short
        Get
            Return _ageMin
        End Get
        Set(ByVal Value As Short)
            _ageMin = Value
        End Set
    End Property
    Public Property AgeMax() As Short
        Get
            Return _ageMax
        End Get
        Set(ByVal Value As Short)
            _ageMax = Value
        End Set
    End Property
    Public Property AgeType() As Byte
        Get
            Return _ageType
        End Get
        Set(ByVal Value As Byte)
            _ageType = Value
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
Public Class TH27_M01Info

#Region "Private Members"
    Private _iD As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _maBC As String = String.Empty
    Private _tenBC As String = String.Empty
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
    Public Property MaBC As String
        Get
            Return _maBC
        End Get
        Set(ByVal Value As String)
            _maBC = Value
        End Set
    End Property
    Public Property TenBC As String
        Get
            Return _tenBC
        End Get
        Set(ByVal Value As String)
            _tenBC = Value
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
Public Class TH27_M01_AInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m01_ID As Integer
    Private _iDKEY As String = String.Empty
    Private _tT As String = String.Empty
    Private _chiTieu As String = String.Empty
    Private _donVi As String = String.Empty
    Private _kyTruoc As Integer
    Private _tangTrongKy As Integer
    Private _giamTrongKy As Integer
    Private _kyBaoCao As Integer
    Private _flags As String = String.Empty
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
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
    Public Property M01_ID As Integer
        Get
            Return _m01_ID
        End Get
        Set(ByVal Value As Integer)
            _m01_ID = Value
        End Set
    End Property
    Public Property IDKEY As String
        Get
            Return _iDKEY
        End Get
        Set(ByVal Value As String)
            _iDKEY = Value
        End Set
    End Property
    Public Property TT As String
        Get
            Return _tT
        End Get
        Set(ByVal Value As String)
            _tT = Value
        End Set
    End Property
    Public Property ChiTieu As String
        Get
            Return _chiTieu
        End Get
        Set(ByVal Value As String)
            _chiTieu = Value
        End Set
    End Property
    Public Property DonVi As String
        Get
            Return _donVi
        End Get
        Set(ByVal Value As String)
            _donVi = Value
        End Set
    End Property
    Public Property KyTruoc As Integer
        Get
            Return _kyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kyTruoc = Value
        End Set
    End Property
    Public Property TangTrongKy As Integer
        Get
            Return _tangTrongKy
        End Get
        Set(ByVal Value As Integer)
            _tangTrongKy = Value
        End Set
    End Property
    Public Property GiamTrongKy As Integer
        Get
            Return _giamTrongKy
        End Get
        Set(ByVal Value As Integer)
            _giamTrongKy = Value
        End Set
    End Property
    Public Property KyBaoCao As Integer
        Get
            Return _kyBaoCao
        End Get
        Set(ByVal Value As Integer)
            _kyBaoCao = Value
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
Public Class TH27_M01_BInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m01_ID As Integer
    Private _sTT As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _maThon As Integer
    Private _tenThon As String = String.Empty
    Private _kT_TongSo As Integer
    Private _kT_CVL As Integer
    Private _kT_TN As Integer
    Private _kT_KTG As Integer
    Private _kBC_Tong As Integer
    Private _kBC_CVL As Integer
    Private _kBC_TN As Integer
    Private _kBC_KTG As Integer
    Private _tA_CVL As Integer
    Private _tA_CD As Integer
    Private _tA_TN_CVL As Integer
    Private _tA_KHD_CVL As Integer
    Private _tA_TN As Integer
    Private _tA_KTG As Integer
    Private _gA_CVL As Integer
    Private _gA_CD As Integer
    Private _gA_CVL_TN As Integer
    Private _gA_CVL_KHD As Integer
    Private _gA_TN As Integer
    Private _gA_KTG As Integer
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
    Public Property M01_ID As Integer
        Get
            Return _m01_ID
        End Get
        Set(ByVal Value As Integer)
            _m01_ID = Value
        End Set
    End Property
    Public Property STT As Integer
        Get
            Return _sTT
        End Get
        Set(ByVal Value As Integer)
            _sTT = Value
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
    Public Property MaThon As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property TenThon As String
        Get
            Return _tenThon
        End Get
        Set(ByVal Value As String)
            _tenThon = Value
        End Set
    End Property
    Public Property KT_TongSo As Integer
        Get
            Return _kT_TongSo
        End Get
        Set(ByVal Value As Integer)
            _kT_TongSo = Value
        End Set
    End Property
    Public Property KT_CVL As Integer
        Get
            Return _kT_CVL
        End Get
        Set(ByVal Value As Integer)
            _kT_CVL = Value
        End Set
    End Property
    Public Property KT_TN As Integer
        Get
            Return _kT_TN
        End Get
        Set(ByVal Value As Integer)
            _kT_TN = Value
        End Set
    End Property
    Public Property KT_KTG As Integer
        Get
            Return _kT_KTG
        End Get
        Set(ByVal Value As Integer)
            _kT_KTG = Value
        End Set
    End Property
    Public Property KBC_Tong As Integer
        Get
            Return _kBC_Tong
        End Get
        Set(ByVal Value As Integer)
            _kBC_Tong = Value
        End Set
    End Property
    Public Property KBC_CVL As Integer
        Get
            Return _kBC_CVL
        End Get
        Set(ByVal Value As Integer)
            _kBC_CVL = Value
        End Set
    End Property
    Public Property KBC_TN As Integer
        Get
            Return _kBC_TN
        End Get
        Set(ByVal Value As Integer)
            _kBC_TN = Value
        End Set
    End Property
    Public Property KBC_KTG As Integer
        Get
            Return _kBC_KTG
        End Get
        Set(ByVal Value As Integer)
            _kBC_KTG = Value
        End Set
    End Property
    Public Property TA_CVL As Integer
        Get
            Return _tA_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_CVL = Value
        End Set
    End Property
    Public Property TA_CD As Integer
        Get
            Return _tA_CD
        End Get
        Set(ByVal Value As Integer)
            _tA_CD = Value
        End Set
    End Property
    Public Property TA_TN_CVL As Integer
        Get
            Return _tA_TN_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_TN_CVL = Value
        End Set
    End Property
    Public Property TA_KHD_CVL As Integer
        Get
            Return _tA_KHD_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_KHD_CVL = Value
        End Set
    End Property
    Public Property TA_TN As Integer
        Get
            Return _tA_TN
        End Get
        Set(ByVal Value As Integer)
            _tA_TN = Value
        End Set
    End Property
    Public Property TA_KTG As Integer
        Get
            Return _tA_KTG
        End Get
        Set(ByVal Value As Integer)
            _tA_KTG = Value
        End Set
    End Property
    Public Property GA_CVL As Integer
        Get
            Return _gA_CVL
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL = Value
        End Set
    End Property
    Public Property GA_CD As Integer
        Get
            Return _gA_CD
        End Get
        Set(ByVal Value As Integer)
            _gA_CD = Value
        End Set
    End Property
    Public Property GA_CVL_TN As Integer
        Get
            Return _gA_CVL_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_TN = Value
        End Set
    End Property
    Public Property GA_CVL_KHD As Integer
        Get
            Return _gA_CVL_KHD
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_KHD = Value
        End Set
    End Property
    Public Property GA_TN As Integer
        Get
            Return _gA_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_TN = Value
        End Set
    End Property
    Public Property GA_KTG As Integer
        Get
            Return _gA_KTG
        End Get
        Set(ByVal Value As Integer)
            _gA_KTG = Value
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
Public Class TH27_M02Info

#Region "Private Members"
    Private _iD As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _maBC As String = String.Empty
    Private _tenBC As String = String.Empty
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
    Public Property MaBC As String
        Get
            Return _maBC
        End Get
        Set(ByVal Value As String)
            _maBC = Value
        End Set
    End Property
    Public Property TenBC As String
        Get
            Return _tenBC
        End Get
        Set(ByVal Value As String)
            _tenBC = Value
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
Public Class TH27_M02_AInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m02_ID As Integer
    Private _iDKEY As String = String.Empty
    Private _tT As String = String.Empty
    Private _chiTieu As String = String.Empty
    Private _donVi As String = String.Empty
    Private _kyTruoc As Integer
    Private _tangTrongKy As Integer
    Private _giamTrongKy As Integer
    Private _kyBaoCao As Integer
    Private _flags As String = String.Empty
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
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
    Public Property M02_ID As Integer
        Get
            Return _m02_ID
        End Get
        Set(ByVal Value As Integer)
            _m02_ID = Value
        End Set
    End Property
    Public Property IDKEY As String
        Get
            Return _iDKEY
        End Get
        Set(ByVal Value As String)
            _iDKEY = Value
        End Set
    End Property
    Public Property TT As String
        Get
            Return _tT
        End Get
        Set(ByVal Value As String)
            _tT = Value
        End Set
    End Property
    Public Property ChiTieu As String
        Get
            Return _chiTieu
        End Get
        Set(ByVal Value As String)
            _chiTieu = Value
        End Set
    End Property
    Public Property DonVi As String
        Get
            Return _donVi
        End Get
        Set(ByVal Value As String)
            _donVi = Value
        End Set
    End Property
    Public Property KyTruoc As Integer
        Get
            Return _kyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kyTruoc = Value
        End Set
    End Property
    Public Property TangTrongKy As Integer
        Get
            Return _tangTrongKy
        End Get
        Set(ByVal Value As Integer)
            _tangTrongKy = Value
        End Set
    End Property
    Public Property GiamTrongKy As Integer
        Get
            Return _giamTrongKy
        End Get
        Set(ByVal Value As Integer)
            _giamTrongKy = Value
        End Set
    End Property
    Public Property KyBaoCao As Integer
        Get
            Return _kyBaoCao
        End Get
        Set(ByVal Value As Integer)
            _kyBaoCao = Value
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
Public Class TH27_M02_BInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m02_ID As Integer
    Private _sTT As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _tenXaPhuong As String = String.Empty
    Private _kT_TongSo As Integer
    Private _kT_CVL As Integer
    Private _kT_TN As Integer
    Private _kT_KTG As Integer
    Private _kBC_Tong As Integer
    Private _kBC_CVL As Integer
    Private _kBC_TN As Integer
    Private _kBC_KTG As Integer
    Private _tA_CVL As Integer
    Private _tA_CD As Integer
    Private _tA_TN_CVL As Integer
    Private _tA_KHD_CVL As Integer
    Private _tA_TN As Integer
    Private _tA_KTG As Integer
    Private _gA_CVL As Integer
    Private _gA_CD As Integer
    Private _gA_CVL_TN As Integer
    Private _gA_CVL_KHD As Integer
    Private _gA_TN As Integer
    Private _gA_KTG As Integer
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
    Public Property M02_ID As Integer
        Get
            Return _m02_ID
        End Get
        Set(ByVal Value As Integer)
            _m02_ID = Value
        End Set
    End Property
    Public Property STT As Integer
        Get
            Return _sTT
        End Get
        Set(ByVal Value As Integer)
            _sTT = Value
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
    Public Property TenXaPhuong As String
        Get
            Return _tenXaPhuong
        End Get
        Set(ByVal Value As String)
            _tenXaPhuong = Value
        End Set
    End Property
    Public Property KT_TongSo As Integer
        Get
            Return _kT_TongSo
        End Get
        Set(ByVal Value As Integer)
            _kT_TongSo = Value
        End Set
    End Property
    Public Property KT_CVL As Integer
        Get
            Return _kT_CVL
        End Get
        Set(ByVal Value As Integer)
            _kT_CVL = Value
        End Set
    End Property
    Public Property KT_TN As Integer
        Get
            Return _kT_TN
        End Get
        Set(ByVal Value As Integer)
            _kT_TN = Value
        End Set
    End Property
    Public Property KT_KTG As Integer
        Get
            Return _kT_KTG
        End Get
        Set(ByVal Value As Integer)
            _kT_KTG = Value
        End Set
    End Property
    Public Property KBC_Tong As Integer
        Get
            Return _kBC_Tong
        End Get
        Set(ByVal Value As Integer)
            _kBC_Tong = Value
        End Set
    End Property
    Public Property KBC_CVL As Integer
        Get
            Return _kBC_CVL
        End Get
        Set(ByVal Value As Integer)
            _kBC_CVL = Value
        End Set
    End Property
    Public Property KBC_TN As Integer
        Get
            Return _kBC_TN
        End Get
        Set(ByVal Value As Integer)
            _kBC_TN = Value
        End Set
    End Property
    Public Property KBC_KTG As Integer
        Get
            Return _kBC_KTG
        End Get
        Set(ByVal Value As Integer)
            _kBC_KTG = Value
        End Set
    End Property
    Public Property TA_CVL As Integer
        Get
            Return _tA_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_CVL = Value
        End Set
    End Property
    Public Property TA_CD As Integer
        Get
            Return _tA_CD
        End Get
        Set(ByVal Value As Integer)
            _tA_CD = Value
        End Set
    End Property
    Public Property TA_TN_CVL As Integer
        Get
            Return _tA_TN_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_TN_CVL = Value
        End Set
    End Property
    Public Property TA_KHD_CVL As Integer
        Get
            Return _tA_KHD_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_KHD_CVL = Value
        End Set
    End Property
    Public Property TA_TN As Integer
        Get
            Return _tA_TN
        End Get
        Set(ByVal Value As Integer)
            _tA_TN = Value
        End Set
    End Property
    Public Property TA_KTG As Integer
        Get
            Return _tA_KTG
        End Get
        Set(ByVal Value As Integer)
            _tA_KTG = Value
        End Set
    End Property
    Public Property GA_CVL As Integer
        Get
            Return _gA_CVL
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL = Value
        End Set
    End Property
    Public Property GA_CD As Integer
        Get
            Return _gA_CD
        End Get
        Set(ByVal Value As Integer)
            _gA_CD = Value
        End Set
    End Property
    Public Property GA_CVL_TN As Integer
        Get
            Return _gA_CVL_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_TN = Value
        End Set
    End Property
    Public Property GA_CVL_KHD As Integer
        Get
            Return _gA_CVL_KHD
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_KHD = Value
        End Set
    End Property
    Public Property GA_TN As Integer
        Get
            Return _gA_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_TN = Value
        End Set
    End Property
    Public Property GA_KTG As Integer
        Get
            Return _gA_KTG
        End Get
        Set(ByVal Value As Integer)
            _gA_KTG = Value
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
Public Class TH27_M03Info

#Region "Private Members"
    Private _iD As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _maBC As String = String.Empty
    Private _tenBC As String = String.Empty
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
    Public Property MaBC As String
        Get
            Return _maBC
        End Get
        Set(ByVal Value As String)
            _maBC = Value
        End Set
    End Property
    Public Property TenBC As String
        Get
            Return _tenBC
        End Get
        Set(ByVal Value As String)
            _tenBC = Value
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
Public Class TH27_M03_AInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m03_ID As Integer
    Private _iDKEY As String = String.Empty
    Private _tT As String = String.Empty
    Private _chiTieu As String = String.Empty
    Private _donVi As String = String.Empty
    Private _kyTruoc As Integer
    Private _tangTrongKy As Integer
    Private _giamTrongKy As Integer
    Private _kyBaoCao As Integer
    Private _flags As String = String.Empty
    Private _years As Integer
    Private _tinhTP As Integer
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
    Public Property M03_ID As Integer
        Get
            Return _m03_ID
        End Get
        Set(ByVal Value As Integer)
            _m03_ID = Value
        End Set
    End Property
    Public Property IDKEY As String
        Get
            Return _iDKEY
        End Get
        Set(ByVal Value As String)
            _iDKEY = Value
        End Set
    End Property
    Public Property TT As String
        Get
            Return _tT
        End Get
        Set(ByVal Value As String)
            _tT = Value
        End Set
    End Property
    Public Property ChiTieu As String
        Get
            Return _chiTieu
        End Get
        Set(ByVal Value As String)
            _chiTieu = Value
        End Set
    End Property
    Public Property DonVi As String
        Get
            Return _donVi
        End Get
        Set(ByVal Value As String)
            _donVi = Value
        End Set
    End Property
    Public Property KyTruoc As Integer
        Get
            Return _kyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kyTruoc = Value
        End Set
    End Property
    Public Property TangTrongKy As Integer
        Get
            Return _tangTrongKy
        End Get
        Set(ByVal Value As Integer)
            _tangTrongKy = Value
        End Set
    End Property
    Public Property GiamTrongKy As Integer
        Get
            Return _giamTrongKy
        End Get
        Set(ByVal Value As Integer)
            _giamTrongKy = Value
        End Set
    End Property
    Public Property KyBaoCao As Integer
        Get
            Return _kyBaoCao
        End Get
        Set(ByVal Value As Integer)
            _kyBaoCao = Value
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
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
Public Class TH27_M03_BInfo

#Region "Private Members"
    Private _iD As Integer
    Private _m03_ID As Integer
    Private _sTT As Integer
    Private _years As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _tenQuanHuyen As String = String.Empty
    Private _kT_TongSo As Integer
    Private _kT_CVL As Integer
    Private _kT_TN As Integer
    Private _kT_KTG As Integer
    Private _kBC_Tong As Integer
    Private _kBC_CVL As Integer
    Private _kBC_TN As Integer
    Private _kBC_KTG As Integer
    Private _tA_CVL As Integer
    Private _tA_CD As Integer
    Private _tA_TN_CVL As Integer
    Private _tA_KHD_CVL As Integer
    Private _tA_TN As Integer
    Private _tA_KTG As Integer
    Private _gA_CVL As Integer
    Private _gA_CD As Integer
    Private _gA_CVL_TN As Integer
    Private _gA_CVL_KHD As Integer
    Private _gA_TN As Integer
    Private _gA_KTG As Integer
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
    Public Property M03_ID As Integer
        Get
            Return _m03_ID
        End Get
        Set(ByVal Value As Integer)
            _m03_ID = Value
        End Set
    End Property
    Public Property STT As Integer
        Get
            Return _sTT
        End Get
        Set(ByVal Value As Integer)
            _sTT = Value
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
    Public Property TenQuanHuyen As String
        Get
            Return _tenQuanHuyen
        End Get
        Set(ByVal Value As String)
            _tenQuanHuyen = Value
        End Set
    End Property
    Public Property KT_TongSo As Integer
        Get
            Return _kT_TongSo
        End Get
        Set(ByVal Value As Integer)
            _kT_TongSo = Value
        End Set
    End Property
    Public Property KT_CVL As Integer
        Get
            Return _kT_CVL
        End Get
        Set(ByVal Value As Integer)
            _kT_CVL = Value
        End Set
    End Property
    Public Property KT_TN As Integer
        Get
            Return _kT_TN
        End Get
        Set(ByVal Value As Integer)
            _kT_TN = Value
        End Set
    End Property
    Public Property KT_KTG As Integer
        Get
            Return _kT_KTG
        End Get
        Set(ByVal Value As Integer)
            _kT_KTG = Value
        End Set
    End Property
    Public Property KBC_Tong As Integer
        Get
            Return _kBC_Tong
        End Get
        Set(ByVal Value As Integer)
            _kBC_Tong = Value
        End Set
    End Property
    Public Property KBC_CVL As Integer
        Get
            Return _kBC_CVL
        End Get
        Set(ByVal Value As Integer)
            _kBC_CVL = Value
        End Set
    End Property
    Public Property KBC_TN As Integer
        Get
            Return _kBC_TN
        End Get
        Set(ByVal Value As Integer)
            _kBC_TN = Value
        End Set
    End Property
    Public Property KBC_KTG As Integer
        Get
            Return _kBC_KTG
        End Get
        Set(ByVal Value As Integer)
            _kBC_KTG = Value
        End Set
    End Property
    Public Property TA_CVL As Integer
        Get
            Return _tA_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_CVL = Value
        End Set
    End Property
    Public Property TA_CD As Integer
        Get
            Return _tA_CD
        End Get
        Set(ByVal Value As Integer)
            _tA_CD = Value
        End Set
    End Property
    Public Property TA_TN_CVL As Integer
        Get
            Return _tA_TN_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_TN_CVL = Value
        End Set
    End Property
    Public Property TA_KHD_CVL As Integer
        Get
            Return _tA_KHD_CVL
        End Get
        Set(ByVal Value As Integer)
            _tA_KHD_CVL = Value
        End Set
    End Property
    Public Property TA_TN As Integer
        Get
            Return _tA_TN
        End Get
        Set(ByVal Value As Integer)
            _tA_TN = Value
        End Set
    End Property
    Public Property TA_KTG As Integer
        Get
            Return _tA_KTG
        End Get
        Set(ByVal Value As Integer)
            _tA_KTG = Value
        End Set
    End Property
    Public Property GA_CVL As Integer
        Get
            Return _gA_CVL
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL = Value
        End Set
    End Property
    Public Property GA_CD As Integer
        Get
            Return _gA_CD
        End Get
        Set(ByVal Value As Integer)
            _gA_CD = Value
        End Set
    End Property
    Public Property GA_CVL_TN As Integer
        Get
            Return _gA_CVL_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_TN = Value
        End Set
    End Property
    Public Property GA_CVL_KHD As Integer
        Get
            Return _gA_CVL_KHD
        End Get
        Set(ByVal Value As Integer)
            _gA_CVL_KHD = Value
        End Set
    End Property
    Public Property GA_TN As Integer
        Get
            Return _gA_TN
        End Get
        Set(ByVal Value As Integer)
            _gA_TN = Value
        End Set
    End Property
    Public Property GA_KTG As Integer
        Get
            Return _gA_KTG
        End Get
        Set(ByVal Value As Integer)
            _gA_KTG = Value
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
Public Class apiHoGDInfo
    Public Property id As String = ""
    Public Property tinhTP As String = ""
    Public Property quanHuyen As String = ""
    Public Property xaPhuong As String = ""
    Public Property thonTo As String = ""
    Public Property maHo As String = ""
    Public Property tenChuHo As String = ""
    Public Property diaChi As String = ""
    Public Property soNhanKhau As Integer
    Public Property loaiHo As String = ""
    Public Property idSo As String = ""
    Public Property loaiBienDong As String = ""
    Public Property chuyenden As String = ""

End Class
Public Class apiHoGD_KhauInfo
    Public Property id As String = ""
    Public Property maDoiTuong As String = ""
    Public Property cMND As String = ""
    Public Property idHo As String = ""
    Public Property maHo As String = ""
    Public Property tinhTP As String = ""
    Public Property quanHuyen As String = ""
    Public Property xaPhuong As String = ""
    Public Property thonTo As String = ""
    Public Property soThuTu As Integer
    Public Property hoTen As String = ""
    Public Property namSinh As Integer
    Public Property gioiTinh As String = ""
    Public Property danToc As String = ""
    Public Property quanHe As String = ""
    Public Property ngaySinh As String = ""
    Public Property trinhDoGD As String = ""
    Public Property trinhDoCM As String = ""
    Public Property linhVucDT As String = ""
    Public Property hinhThuc As String = ""
    Public Property loaiHinhKT As String = ""
    Public Property noiLamViec As String = ""
    Public Property nganhNghe As String = ""
    Public Property diaChiLamViec As String = ""
    Public Property nuocLamViec As String = ""
    Public Property loaiThatNghiep As String = ""
    Public Property thoiGianThatNghiep As String = ""
    Public Property lyDoKhongThamGia As String = ""
    Public Property loaiBienDong As String = ""
    Public Property CongViecThamGia As String = ""
    Public Property chuyenden As String = ""
End Class

Public Class RPT_05_1Info

#Region "Private Members"
    Private _iD As Integer
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _years As Integer
    Private _ds15KyTruoc As Integer
    Private _ds15KyBC As Integer
    Private _kV1_Ds15KyTruoc As Integer
    Private _kV1_Ds15KyBC As Integer
    Private _kV2_Ds15KyTruoc As Integer
    Private _kV2_Ds15KyBC As Integer
    Private _gT1_Ds15KyTruoc As Integer
    Private _gT1_Ds15KyBC As Integer
    Private _gT2_Ds15KyTruoc As Integer
    Private _gT2_Ds15KyBC As Integer
    Private _cVLKyTruoc As Integer
    Private _cVLKyBC As Integer
    Private _kV1_CVLKyTruoc As Integer
    Private _kV1_CVLKyBC As Integer
    Private _kV2_CVLKyTruoc As Integer
    Private _kV2_CVLKyBC As Integer
    Private _tDCM1_CVLKyTruoc As Integer
    Private _tDCM1_CVLKyBC As Integer
    Private _tDCM2_CVLKyTruoc As Integer
    Private _tDCM2_CVLKyBC As Integer
    Private _tDCM3_CVLKyTruoc As Integer
    Private _tDCM3_CVLKyBC As Integer
    Private _tDCM4_CVLKyTruoc As Integer
    Private _tDCM4_CVLKyBC As Integer
    Private _tDCM5_CVLKyTruoc As Integer
    Private _tDCM5_CVLKyBC As Integer
    Private _tDCM6_CVLKyTruoc As Integer
    Private _tDCM6_CVLKyBC As Integer
    Private _tDCM7_CVLKyTruoc As Integer
    Private _tDCM7_CVLKyBC As Integer
    Private _tDCM8_CVLKyTruoc As Integer
    Private _tDCM8_CVLKyBC As Integer
    Private _vTVL1_CVLKyTruoc As Integer
    Private _vTVL1_CVLKyBC As Integer
    Private _vTVL2_CVLKyTruoc As Integer
    Private _vTVL2_CVLKyBC As Integer
    Private _vTVL3_CVLKyTruoc As Integer
    Private _vTVL3_CVLKyBC As Integer
    Private _vTVL4_CVLKyTruoc As Integer
    Private _vTVL4_CVLKyBC As Integer
    Private _vTVL5_CVLKyTruoc As Integer
    Private _vTVL5_CVLKyBC As Integer
    Private _tNKyTruoc As Integer
    Private _tNKyBC As Integer
    Private _kV1_TNKyTruoc As Integer
    Private _kV1_TNKyBC As Integer
    Private _kV2_TNKyTruoc As Integer
    Private _kV2_TNKyBC As Integer
    Private _tDCM1_TNKyTruoc As Integer
    Private _tDCM1_TNKyBC As Integer
    Private _tDCM2_TNKyTruoc As Integer
    Private _tDCM2_TNKyBC As Integer
    Private _tDCM3_TNKyTruoc As Integer
    Private _tDCM3_TNKyBC As Integer
    Private _tDCM4_TNKyTruoc As Integer
    Private _tDCM4_TNKyBC As Integer
    Private _tDCM5_TNKyTruoc As Integer
    Private _tDCM5_TNKyBC As Integer
    Private _tDCM6_TNKyTruoc As Integer
    Private _tDCM6_TNKyBC As Integer
    Private _tDCM7_TNKyTruoc As Integer
    Private _tDCM7_TNKyBC As Integer
    Private _tDCM8_TNKyTruoc As Integer
    Private _tDCM8_TNKyBC As Integer
    Private _tGTN1_TNKyTruoc As Integer
    Private _tGTN1_TNKyBC As Integer
    Private _tGTN2_TNKyTruoc As Integer
    Private _tGTN2_TNKyBC As Integer
    Private _tGTN3_TNKyTruoc As Integer
    Private _tGTN3_TNKyBC As Integer
    Private _kTGKyTruoc As Integer
    Private _kTGKyBC As Integer
    Private _dH_KTGKyTruoc As Integer
    Private _dH_KTGKyBC As Integer
    Private _hT_KTGKyTruoc As Integer
    Private _hT_KTGKyBC As Integer
    Private _nT_KTGKyTruoc As Integer
    Private _nT_KTGKyBC As Integer
    Private _kT_KTGKyTruoc As Integer
    Private _kT_KTGKyBC As Integer
    Private _kHAC_KTGKyTruoc As Integer
    Private _kHAC_KTGKyBC As Integer
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
    Public Property MaThon() As Integer
        Get
            Return _maThon
        End Get
        Set(ByVal Value As Integer)
            _maThon = Value
        End Set
    End Property
    Public Property Years() As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
        End Set
    End Property
    Public Property Ds15KyTruoc() As Integer
        Get
            Return _ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _ds15KyTruoc = Value
        End Set
    End Property
    Public Property Ds15KyBC() As Integer
        Get
            Return _ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _ds15KyBC = Value
        End Set
    End Property
    Public Property KV1_Ds15KyTruoc() As Integer
        Get
            Return _kV1_Ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV1_Ds15KyTruoc = Value
        End Set
    End Property
    Public Property KV1_Ds15KyBC() As Integer
        Get
            Return _kV1_Ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _kV1_Ds15KyBC = Value
        End Set
    End Property
    Public Property KV2_Ds15KyTruoc() As Integer
        Get
            Return _kV2_Ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV2_Ds15KyTruoc = Value
        End Set
    End Property
    Public Property KV2_Ds15KyBC() As Integer
        Get
            Return _kV2_Ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _kV2_Ds15KyBC = Value
        End Set
    End Property
    Public Property GT1_Ds15KyTruoc() As Integer
        Get
            Return _gT1_Ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _gT1_Ds15KyTruoc = Value
        End Set
    End Property
    Public Property GT1_Ds15KyBC() As Integer
        Get
            Return _gT1_Ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _gT1_Ds15KyBC = Value
        End Set
    End Property
    Public Property GT2_Ds15KyTruoc() As Integer
        Get
            Return _gT2_Ds15KyTruoc
        End Get
        Set(ByVal Value As Integer)
            _gT2_Ds15KyTruoc = Value
        End Set
    End Property
    Public Property GT2_Ds15KyBC() As Integer
        Get
            Return _gT2_Ds15KyBC
        End Get
        Set(ByVal Value As Integer)
            _gT2_Ds15KyBC = Value
        End Set
    End Property
    Public Property CVLKyTruoc() As Integer
        Get
            Return _cVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _cVLKyTruoc = Value
        End Set
    End Property
    Public Property CVLKyBC() As Integer
        Get
            Return _cVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _cVLKyBC = Value
        End Set
    End Property
    Public Property KV1_CVLKyTruoc() As Integer
        Get
            Return _kV1_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV1_CVLKyTruoc = Value
        End Set
    End Property
    Public Property KV1_CVLKyBC() As Integer
        Get
            Return _kV1_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _kV1_CVLKyBC = Value
        End Set
    End Property
    Public Property KV2_CVLKyTruoc() As Integer
        Get
            Return _kV2_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV2_CVLKyTruoc = Value
        End Set
    End Property
    Public Property KV2_CVLKyBC() As Integer
        Get
            Return _kV2_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _kV2_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM1_CVLKyTruoc() As Integer
        Get
            Return _tDCM1_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM1_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM1_CVLKyBC() As Integer
        Get
            Return _tDCM1_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM1_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM2_CVLKyTruoc() As Integer
        Get
            Return _tDCM2_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM2_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM2_CVLKyBC() As Integer
        Get
            Return _tDCM2_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM2_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM3_CVLKyTruoc() As Integer
        Get
            Return _tDCM3_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM3_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM3_CVLKyBC() As Integer
        Get
            Return _tDCM3_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM3_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM4_CVLKyTruoc() As Integer
        Get
            Return _tDCM4_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM4_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM4_CVLKyBC() As Integer
        Get
            Return _tDCM4_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM4_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM5_CVLKyTruoc() As Integer
        Get
            Return _tDCM5_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM5_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM5_CVLKyBC() As Integer
        Get
            Return _tDCM5_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM5_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM6_CVLKyTruoc() As Integer
        Get
            Return _tDCM6_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM6_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM6_CVLKyBC() As Integer
        Get
            Return _tDCM6_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM6_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM7_CVLKyTruoc() As Integer
        Get
            Return _tDCM7_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM7_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM7_CVLKyBC() As Integer
        Get
            Return _tDCM7_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM7_CVLKyBC = Value
        End Set
    End Property
    Public Property TDCM8_CVLKyTruoc() As Integer
        Get
            Return _tDCM8_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM8_CVLKyTruoc = Value
        End Set
    End Property
    Public Property TDCM8_CVLKyBC() As Integer
        Get
            Return _tDCM8_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM8_CVLKyBC = Value
        End Set
    End Property
    Public Property VTVL1_CVLKyTruoc() As Integer
        Get
            Return _vTVL1_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _vTVL1_CVLKyTruoc = Value
        End Set
    End Property
    Public Property VTVL1_CVLKyBC() As Integer
        Get
            Return _vTVL1_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _vTVL1_CVLKyBC = Value
        End Set
    End Property
    Public Property VTVL2_CVLKyTruoc() As Integer
        Get
            Return _vTVL2_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _vTVL2_CVLKyTruoc = Value
        End Set
    End Property
    Public Property VTVL2_CVLKyBC() As Integer
        Get
            Return _vTVL2_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _vTVL2_CVLKyBC = Value
        End Set
    End Property
    Public Property VTVL3_CVLKyTruoc() As Integer
        Get
            Return _vTVL3_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _vTVL3_CVLKyTruoc = Value
        End Set
    End Property
    Public Property VTVL3_CVLKyBC() As Integer
        Get
            Return _vTVL3_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _vTVL3_CVLKyBC = Value
        End Set
    End Property
    Public Property VTVL4_CVLKyTruoc() As Integer
        Get
            Return _vTVL4_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _vTVL4_CVLKyTruoc = Value
        End Set
    End Property
    Public Property VTVL4_CVLKyBC() As Integer
        Get
            Return _vTVL4_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _vTVL4_CVLKyBC = Value
        End Set
    End Property
    Public Property VTVL5_CVLKyTruoc() As Integer
        Get
            Return _vTVL5_CVLKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _vTVL5_CVLKyTruoc = Value
        End Set
    End Property
    Public Property VTVL5_CVLKyBC() As Integer
        Get
            Return _vTVL5_CVLKyBC
        End Get
        Set(ByVal Value As Integer)
            _vTVL5_CVLKyBC = Value
        End Set
    End Property
    Public Property TNKyTruoc() As Integer
        Get
            Return _tNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tNKyTruoc = Value
        End Set
    End Property
    Public Property TNKyBC() As Integer
        Get
            Return _tNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tNKyBC = Value
        End Set
    End Property
    Public Property KV1_TNKyTruoc() As Integer
        Get
            Return _kV1_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV1_TNKyTruoc = Value
        End Set
    End Property
    Public Property KV1_TNKyBC() As Integer
        Get
            Return _kV1_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _kV1_TNKyBC = Value
        End Set
    End Property
    Public Property KV2_TNKyTruoc() As Integer
        Get
            Return _kV2_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kV2_TNKyTruoc = Value
        End Set
    End Property
    Public Property KV2_TNKyBC() As Integer
        Get
            Return _kV2_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _kV2_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM1_TNKyTruoc() As Integer
        Get
            Return _tDCM1_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM1_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM1_TNKyBC() As Integer
        Get
            Return _tDCM1_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM1_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM2_TNKyTruoc() As Integer
        Get
            Return _tDCM2_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM2_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM2_TNKyBC() As Integer
        Get
            Return _tDCM2_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM2_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM3_TNKyTruoc() As Integer
        Get
            Return _tDCM3_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM3_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM3_TNKyBC() As Integer
        Get
            Return _tDCM3_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM3_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM4_TNKyTruoc() As Integer
        Get
            Return _tDCM4_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM4_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM4_TNKyBC() As Integer
        Get
            Return _tDCM4_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM4_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM5_TNKyTruoc() As Integer
        Get
            Return _tDCM5_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM5_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM5_TNKyBC() As Integer
        Get
            Return _tDCM5_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM5_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM6_TNKyTruoc() As Integer
        Get
            Return _tDCM6_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM6_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM6_TNKyBC() As Integer
        Get
            Return _tDCM6_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM6_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM7_TNKyTruoc() As Integer
        Get
            Return _tDCM7_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM7_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM7_TNKyBC() As Integer
        Get
            Return _tDCM7_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM7_TNKyBC = Value
        End Set
    End Property
    Public Property TDCM8_TNKyTruoc() As Integer
        Get
            Return _tDCM8_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tDCM8_TNKyTruoc = Value
        End Set
    End Property
    Public Property TDCM8_TNKyBC() As Integer
        Get
            Return _tDCM8_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tDCM8_TNKyBC = Value
        End Set
    End Property
    Public Property TGTN1_TNKyTruoc() As Integer
        Get
            Return _tGTN1_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tGTN1_TNKyTruoc = Value
        End Set
    End Property
    Public Property TGTN1_TNKyBC() As Integer
        Get
            Return _tGTN1_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tGTN1_TNKyBC = Value
        End Set
    End Property
    Public Property TGTN2_TNKyTruoc() As Integer
        Get
            Return _tGTN2_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tGTN2_TNKyTruoc = Value
        End Set
    End Property
    Public Property TGTN2_TNKyBC() As Integer
        Get
            Return _tGTN2_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tGTN2_TNKyBC = Value
        End Set
    End Property
    Public Property TGTN3_TNKyTruoc() As Integer
        Get
            Return _tGTN3_TNKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _tGTN3_TNKyTruoc = Value
        End Set
    End Property
    Public Property TGTN3_TNKyBC() As Integer
        Get
            Return _tGTN3_TNKyBC
        End Get
        Set(ByVal Value As Integer)
            _tGTN3_TNKyBC = Value
        End Set
    End Property
    Public Property KTGKyTruoc() As Integer
        Get
            Return _kTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kTGKyTruoc = Value
        End Set
    End Property
    Public Property KTGKyBC() As Integer
        Get
            Return _kTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _kTGKyBC = Value
        End Set
    End Property
    Public Property DH_KTGKyTruoc() As Integer
        Get
            Return _dH_KTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _dH_KTGKyTruoc = Value
        End Set
    End Property
    Public Property DH_KTGKyBC() As Integer
        Get
            Return _dH_KTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _dH_KTGKyBC = Value
        End Set
    End Property
    Public Property HT_KTGKyTruoc() As Integer
        Get
            Return _hT_KTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _hT_KTGKyTruoc = Value
        End Set
    End Property
    Public Property HT_KTGKyBC() As Integer
        Get
            Return _hT_KTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _hT_KTGKyBC = Value
        End Set
    End Property
    Public Property NT_KTGKyTruoc() As Integer
        Get
            Return _nT_KTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _nT_KTGKyTruoc = Value
        End Set
    End Property
    Public Property NT_KTGKyBC() As Integer
        Get
            Return _nT_KTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _nT_KTGKyBC = Value
        End Set
    End Property
    Public Property KT_KTGKyTruoc() As Integer
        Get
            Return _kT_KTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kT_KTGKyTruoc = Value
        End Set
    End Property
    Public Property KT_KTGKyBC() As Integer
        Get
            Return _kT_KTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _kT_KTGKyBC = Value
        End Set
    End Property
    Public Property KHAC_KTGKyTruoc() As Integer
        Get
            Return _kHAC_KTGKyTruoc
        End Get
        Set(ByVal Value As Integer)
            _kHAC_KTGKyTruoc = Value
        End Set
    End Property
    Public Property KHAC_KTGKyBC() As Integer
        Get
            Return _kHAC_KTGKyBC
        End Get
        Set(ByVal Value As Integer)
            _kHAC_KTGKyBC = Value
        End Set
    End Property
#End Region

End Class
Public Class ChartInfo
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Private _TotalNum1 As String = "0"
    Public Property TotalNum1() As String
        Get
            Return _TotalNum1
        End Get
        Set(ByVal value As String)
            _TotalNum1 = value
        End Set
    End Property
    Private _TotalNum2 As String = "0"
    Public Property TotalNum2() As String
        Get
            Return _TotalNum2
        End Get
        Set(ByVal value As String)
            _TotalNum2 = value
        End Set
    End Property
    Private _TotalNum3 As String = "0"
    Public Property TotalNum3() As String
        Get
            Return _TotalNum3
        End Get
        Set(ByVal value As String)
            _TotalNum3 = value
        End Set
    End Property
    Private _TotalNum4 As String = "0"
    Public Property TotalNum4() As String
        Get
            Return _TotalNum4
        End Get
        Set(ByVal value As String)
            _TotalNum4 = value
        End Set
    End Property
    Private _Num1 As String = "0"
    Public Property Num1() As String
        Get
            Return _Num1
        End Get
        Set(ByVal value As String)
            _Num1 = value
        End Set
    End Property
    Private _Num6 As String = "0"
    Public Property Num6() As String
        Get
            Return _Num6
        End Get
        Set(ByVal value As String)
            _Num6 = value
        End Set
    End Property
    Private _Num2 As String = "0"
    Public Property Num2() As String
        Get
            Return _Num2
        End Get
        Set(ByVal value As String)
            _Num2 = value
        End Set
    End Property
    Private _Num3 As String = "0"
    Public Property Num3() As String
        Get
            Return _Num3
        End Get
        Set(ByVal value As String)
            _Num3 = value
        End Set
    End Property
    Private _Num4 As String = "0"
    Public Property Num4() As String
        Get
            Return _Num4
        End Get
        Set(ByVal value As String)
            _Num4 = value
        End Set
    End Property
    Private _Num5 As String = "0"
    Public Property Num5() As String
        Get
            Return _Num5
        End Get
        Set(ByVal value As String)
            _Num5 = value
        End Set
    End Property
End Class




