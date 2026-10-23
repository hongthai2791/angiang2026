
Public Class CMS_NLDInfo

#Region "Private Members"
	Private _nguoiLD_ID As String
	Private _maNLD As String = String.Empty
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _maThon As Integer
	Private _hoTen As String = String.Empty
	Private _ngaySinh As DateTime
	Private _gioiTinh As Integer
	Private _quocTich As String = String.Empty
	Private _hoChieu As String = String.Empty
	Private _coQuanCap As String = String.Empty
	Private _ngayCapHC As DateTime
	Private _thoiHanHC As DateTime
	Private _trinhDoCM As Integer
	Private _viTriCV As Integer
	Private _chuyenMonDT As Integer
	Private _chuyenMonDT_Khac As String = String.Empty
	Private _lVTuNgay As DateTime
	Private _lVDenNgay As DateTime
	Private _noiLamViec As String = String.Empty
	Private _diaDiemLV As String = String.Empty
	Private _chucDanh As String = String.Empty
	Private _soGP As String = String.Empty
	Private _ngayCP As DateTime
	Private _doanhNghiep_ID As String = String.Empty
	Private _tenDoanhNghiep As String = String.Empty
	Private _maDoanhNghiep As String = String.Empty
	Private _tinhTP As Integer
	Private _quanHuyen As Integer
	Private _xaPhuong As Integer
	Private _loaiHinh_ID As String = String.Empty
	Private _ngheCongViec As Integer
	Private _ngheCongViec_Khac As String = String.Empty
	Private _hinhThucLamViec As Integer
	Private _hinhThucLamViec_Khac As String = String.Empty
	Private _createdUser As String = String.Empty
	Private _createdDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _isDelete As Boolean
	Private _deletedDate As DateTime
	Private _deletedUser As String = String.Empty
	Private _portalID As Byte
	Private _trangThai As Integer
	Private _total As Integer
	Private _ChucDanhCV As String = String.Empty
	Private _TinhTrangCP As Integer
#End Region

#Region "Public Properties"

	Public Property ChucDanhCV As String
		Get
			Return _ChucDanhCV
		End Get
		Set(ByVal Value As String)
			_ChucDanhCV = Value
		End Set
	End Property
	Public Property TinhTrangCP As Integer
		Get
			Return _TinhTrangCP
		End Get
		Set(ByVal Value As Integer)
			_TinhTrangCP = Value
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

	Public Property NguoiLD_ID() As String
		Get
			Return _nguoiLD_ID
		End Get
		Set(ByVal Value As String)
			_nguoiLD_ID = Value
		End Set
	End Property

	Public Property MaNLD() As String
		Get
			Return _maNLD
		End Get
		Set(ByVal Value As String)
			_maNLD = Value
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
	Public Property QuocTich() As String
		Get
			Return _quocTich
		End Get
		Set(ByVal Value As String)
			_quocTich = Value
		End Set
	End Property
	Public Property HoChieu() As String
		Get
			Return _hoChieu
		End Get
		Set(ByVal Value As String)
			_hoChieu = Value
		End Set
	End Property
	Public Property CoQuanCap() As String
		Get
			Return _coQuanCap
		End Get
		Set(ByVal Value As String)
			_coQuanCap = Value
		End Set
	End Property
	Public Property NgayCapHC() As DateTime
		Get
			Return _ngayCapHC
		End Get
		Set(ByVal Value As DateTime)
			_ngayCapHC = Value
		End Set
	End Property
	Public Property ThoiHanHC() As DateTime
		Get
			Return _thoiHanHC
		End Get
		Set(ByVal Value As DateTime)
			_thoiHanHC = Value
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
	Public Property ViTriCV() As Integer
		Get
			Return _viTriCV
		End Get
		Set(ByVal Value As Integer)
			_viTriCV = Value
		End Set
	End Property
	Public Property ChuyenMonDT() As Integer
		Get
			Return _chuyenMonDT
		End Get
		Set(ByVal Value As Integer)
			_chuyenMonDT = Value
		End Set
	End Property
	Public Property ChuyenMonDT_Khac() As String
		Get
			Return _chuyenMonDT_Khac
		End Get
		Set(ByVal Value As String)
			_chuyenMonDT_Khac = Value
		End Set
	End Property
	Public Property LVTuNgay() As DateTime
		Get
			Return _lVTuNgay
		End Get
		Set(ByVal Value As DateTime)
			_lVTuNgay = Value
		End Set
	End Property
	Public Property LVDenNgay() As DateTime
		Get
			Return _lVDenNgay
		End Get
		Set(ByVal Value As DateTime)
			_lVDenNgay = Value
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
	Public Property DiaDiemLV() As String
		Get
			Return _diaDiemLV
		End Get
		Set(ByVal Value As String)
			_diaDiemLV = Value
		End Set
	End Property
	Public Property ChucDanh() As String
		Get
			Return _chucDanh
		End Get
		Set(ByVal Value As String)
			_chucDanh = Value
		End Set
	End Property
	Public Property SoGP() As String
		Get
			Return _soGP
		End Get
		Set(ByVal Value As String)
			_soGP = Value
		End Set
	End Property
	Public Property NgayCP() As DateTime
		Get
			Return _ngayCP
		End Get
		Set(ByVal Value As DateTime)
			_ngayCP = Value
		End Set
	End Property
	Public Property DoanhNghiep_ID() As String
		Get
			Return _doanhNghiep_ID
		End Get
		Set(ByVal Value As String)
			_doanhNghiep_ID = Value
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
	Public Property MaDoanhNghiep() As String
		Get
			Return _maDoanhNghiep
		End Get
		Set(ByVal Value As String)
			_maDoanhNghiep = Value
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
	Public Property LoaiHinh_ID() As String
		Get
			Return _loaiHinh_ID
		End Get
		Set(ByVal Value As String)
			_loaiHinh_ID = Value
		End Set
	End Property
	Public Property NgheCongViec() As Integer
		Get
			Return _ngheCongViec
		End Get
		Set(ByVal Value As Integer)
			_ngheCongViec = Value
		End Set
	End Property
	Public Property NgheCongViec_Khac() As String
		Get
			Return _ngheCongViec_Khac
		End Get
		Set(ByVal Value As String)
			_ngheCongViec_Khac = Value
		End Set
	End Property
	Public Property HinhThucLamViec() As Integer
		Get
			Return _hinhThucLamViec
		End Get
		Set(ByVal Value As Integer)
			_hinhThucLamViec = Value
		End Set
	End Property
	Public Property HinhThucLamViec_Khac() As String
		Get
			Return _hinhThucLamViec_Khac
		End Get
		Set(ByVal Value As String)
			_hinhThucLamViec_Khac = Value
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
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
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
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
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
	Public Property PortalID() As Byte
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Byte)
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
#End Region

End Class

Public Class CMS_NLD_BackupInfo

#Region "Private Members"
	Private _nguoiLD_ID As String
	Private _iD_NLD As Integer
	Private _maNLD As String = String.Empty
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _maThon As Integer
	Private _hoTen As String = String.Empty
	Private _ngaySinh As DateTime
	Private _gioiTinh As Integer
	Private _quocTich As String = String.Empty
	Private _hoChieu As String = String.Empty
	Private _coQuanCap As String = String.Empty
	Private _ngayCapHC As DateTime
	Private _thoiHanHC As DateTime
	Private _trinhDoCM As Integer
	Private _viTriCV As Integer
	Private _chuyenMonDT As Integer
	Private _chuyenMonDT_Khac As String = String.Empty
	Private _lVTuNgay As DateTime
	Private _lVDenNgay As DateTime
	Private _noiLamViec As String = String.Empty
	Private _diaDiemLV As String = String.Empty
	Private _chucDanh As String = String.Empty
	Private _soGP As String = String.Empty
	Private _ngayCP As DateTime
	Private _doanhNghiep_ID As String = String.Empty
	Private _tenDoanhNghiep As String = String.Empty
	Private _maDoanhNghiep As String = String.Empty
	Private _tinhTP As Integer
	Private _quanHuyen As Integer
	Private _xaPhuong As Integer
	Private _loaiHinh_ID As Integer
	Private _ngheCongViec As Integer
	Private _ngheCongViec_Khac As String = String.Empty
	Private _hinhThucLamViec As Integer
	Private _hinhThucLamViec_Khac As String = String.Empty
	Private _createdUser As String = String.Empty
	Private _createdDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _isDelete As Boolean
	Private _deletedDate As DateTime
	Private _deletedUser As String = String.Empty
	Private _portalID As Byte
	Private _trangThai As Integer
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

	Public Property NguoiLD_ID() As String
		Get
			Return _nguoiLD_ID
		End Get
		Set(ByVal Value As String)
			_nguoiLD_ID = Value
		End Set
	End Property

	Public Property ID_NLD() As Integer
		Get
			Return _iD_NLD
		End Get
		Set(ByVal Value As Integer)
			_iD_NLD = Value
		End Set
	End Property
	Public Property MaNLD() As String
		Get
			Return _maNLD
		End Get
		Set(ByVal Value As String)
			_maNLD = Value
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
	Public Property QuocTich() As String
		Get
			Return _quocTich
		End Get
		Set(ByVal Value As String)
			_quocTich = Value
		End Set
	End Property
	Public Property HoChieu() As String
		Get
			Return _hoChieu
		End Get
		Set(ByVal Value As String)
			_hoChieu = Value
		End Set
	End Property
	Public Property CoQuanCap() As String
		Get
			Return _coQuanCap
		End Get
		Set(ByVal Value As String)
			_coQuanCap = Value
		End Set
	End Property
	Public Property NgayCapHC() As DateTime
		Get
			Return _ngayCapHC
		End Get
		Set(ByVal Value As DateTime)
			_ngayCapHC = Value
		End Set
	End Property
	Public Property ThoiHanHC() As DateTime
		Get
			Return _thoiHanHC
		End Get
		Set(ByVal Value As DateTime)
			_thoiHanHC = Value
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
	Public Property ViTriCV() As Integer
		Get
			Return _viTriCV
		End Get
		Set(ByVal Value As Integer)
			_viTriCV = Value
		End Set
	End Property
	Public Property ChuyenMonDT() As Integer
		Get
			Return _chuyenMonDT
		End Get
		Set(ByVal Value As Integer)
			_chuyenMonDT = Value
		End Set
	End Property
	Public Property ChuyenMonDT_Khac() As String
		Get
			Return _chuyenMonDT_Khac
		End Get
		Set(ByVal Value As String)
			_chuyenMonDT_Khac = Value
		End Set
	End Property
	Public Property LVTuNgay() As DateTime
		Get
			Return _lVTuNgay
		End Get
		Set(ByVal Value As DateTime)
			_lVTuNgay = Value
		End Set
	End Property
	Public Property LVDenNgay() As DateTime
		Get
			Return _lVDenNgay
		End Get
		Set(ByVal Value As DateTime)
			_lVDenNgay = Value
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
	Public Property DiaDiemLV() As String
		Get
			Return _diaDiemLV
		End Get
		Set(ByVal Value As String)
			_diaDiemLV = Value
		End Set
	End Property
	Public Property ChucDanh() As String
		Get
			Return _chucDanh
		End Get
		Set(ByVal Value As String)
			_chucDanh = Value
		End Set
	End Property
	Public Property SoGP() As String
		Get
			Return _soGP
		End Get
		Set(ByVal Value As String)
			_soGP = Value
		End Set
	End Property
	Public Property NgayCP() As DateTime
		Get
			Return _ngayCP
		End Get
		Set(ByVal Value As DateTime)
			_ngayCP = Value
		End Set
	End Property
	Public Property DoanhNghiep_ID() As String
		Get
			Return _doanhNghiep_ID
		End Get
		Set(ByVal Value As String)
			_doanhNghiep_ID = Value
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
	Public Property MaDoanhNghiep() As String
		Get
			Return _maDoanhNghiep
		End Get
		Set(ByVal Value As String)
			_maDoanhNghiep = Value
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
	Public Property LoaiHinh_ID() As Integer
		Get
			Return _loaiHinh_ID
		End Get
		Set(ByVal Value As Integer)
			_loaiHinh_ID = Value
		End Set
	End Property
	Public Property NgheCongViec() As Integer
		Get
			Return _ngheCongViec
		End Get
		Set(ByVal Value As Integer)
			_ngheCongViec = Value
		End Set
	End Property
	Public Property NgheCongViec_Khac() As String
		Get
			Return _ngheCongViec_Khac
		End Get
		Set(ByVal Value As String)
			_ngheCongViec_Khac = Value
		End Set
	End Property
	Public Property HinhThucLamViec() As Integer
		Get
			Return _hinhThucLamViec
		End Get
		Set(ByVal Value As Integer)
			_hinhThucLamViec = Value
		End Set
	End Property
	Public Property HinhThucLamViec_Khac() As String
		Get
			Return _hinhThucLamViec_Khac
		End Get
		Set(ByVal Value As String)
			_hinhThucLamViec_Khac = Value
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
	Public Property CreatedDate() As DateTime
		Get
			Return _createdDate
		End Get
		Set(ByVal Value As DateTime)
			_createdDate = Value
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
	Public Property UpdatedDate() As DateTime
		Get
			Return _updatedDate
		End Get
		Set(ByVal Value As DateTime)
			_updatedDate = Value
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
	Public Property PortalID() As Byte
		Get
			Return _portalID
		End Get
		Set(ByVal Value As Byte)
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
#End Region

End Class

Public Class CMS_Provide_ConfigInfo

#Region "Private Members"
	Private _proConfig_ID As String = String.Empty
	Private _tinhTP As Integer
	Private _quanHuyen As Integer
	Private _phuongXa As Integer
	Private _thonTo As Integer
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

	Public Property ProConfig_ID() As String
		Get
			Return _proConfig_ID
		End Get
		Set(ByVal Value As String)
			_proConfig_ID = Value
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

Public Class DM_ChuyenMonDTInfo

#Region "Private Members"
	Private _iD As Integer
	Private _code As String = String.Empty
	Private _name As String = String.Empty
	Private _des As String = String.Empty
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
	Public Property Des() As String
		Get
			Return _des
		End Get
		Set(ByVal Value As String)
			_des = Value
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

Public Class DM_HinhThucLVInfo

#Region "Private Members"
	Private _iD As Integer
	Private _code As String = String.Empty
	Private _name As String = String.Empty
	Private _des As String = String.Empty
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
	Public Property Des() As String
		Get
			Return _des
		End Get
		Set(ByVal Value As String)
			_des = Value
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

Public Class DM_NgheCongViecInfo

#Region "Private Members"
	Private _iD As Integer
	Private _code As String = String.Empty
	Private _name As String = String.Empty
	Private _des As String = String.Empty
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
	Public Property Des() As String
		Get
			Return _des
		End Get
		Set(ByVal Value As String)
			_des = Value
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

Public Class DM_TrinhDoDTInfo

#Region "Private Members"
	Private _iD As Integer
	Private _code As String = String.Empty
	Private _name As String = String.Empty
	Private _des As String = String.Empty
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
	Public Property Des() As String
		Get
			Return _des
		End Get
		Set(ByVal Value As String)
			_des = Value
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

Public Class DM_ViTriCVInfo

#Region "Private Members"
	Private _iD As Integer
	Private _code As String = String.Empty
	Private _name As String = String.Empty
	Private _des As String = String.Empty
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
	Public Property Des() As String
		Get
			Return _des
		End Get
		Set(ByVal Value As String)
			_des = Value
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

Public Class ChartInfo
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