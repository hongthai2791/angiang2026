Public Class BC_NoiDungInfo
    Public Property BaoCaoID As String
    Public Property TenBaoCao As String
    Public Property Links As String
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime
    Public Property NgayNop As DateTime
End Class
Public Class BC_CauLDInfo
    Public Property ID As String
    Public Property TenBaoCao As String
    Public Property IsFlag As Integer

End Class
Public Class BC_BusinessInfo

#Region "Private Members"
    Private _doanhNghiep_ID As String = String.Empty
    Private _maDoanhNghiep As String = String.Empty
    Private _tenDoanhNghiep As String = String.Empty
    Private _taxCode As String = String.Empty
    Private _mobile As String = String.Empty
    Private _fax As String = String.Empty
    Private _email As String = String.Empty
    Private _website As String = String.Empty
    Private _tinhTrang As Integer
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _xaPhuong As String = String.Empty
    Private _tT_NT As String = String.Empty
    Private _soNha As String = String.Empty
    Private _khuCN_ID As String = String.Empty
    Private _loaiHinh_ID As String = String.Empty
    Private _nganhNghe As String = String.Empty
    Private _lD_TongSo As Integer
    Private _lD_NgoaiTinh As Integer
    Private _lD_TrucTiep As Integer
    Private _lD_Nu As Integer
    Private _lD_HD_Tong As Integer
    Private _lD_HD_Nu As Integer
    Private _lD_NuocNgoai_Tong As Integer
    Private _lD_NuocNgoai_Nu As Integer
    Private _lD_PhoThong As Integer
    Private _cMKT_Khong As Integer
    Private _cMKT_BangCap As Integer
    Private _cMKT_DaoTao As Integer
    Private _cMKT_SoCap As Integer
    Private _cMKT_TrungCap As Integer
    Private _cMKT_CaoDang As Integer
    Private _cMKT_DaiHoc As Integer
    Private _gDDT_KTXH As Integer
    Private _gDDT_KHTN As Integer
    Private _gDDT_KTCN As Integer
    Private _gDDT_NongNghiep As Integer
    Private _gDDT_YTe As Integer
    Private _gDDT_Khac As Integer
    Private _nhom_LanhDao As Integer
    Private _nhom_ChuyenMon As Integer
    Private _nhom_TroLy As Integer
    Private _nhom_DichVu As Integer
    Private _nhom_NongNghiep As Integer
    Private _nhom_ThuCong As Integer
    Private _nhom_Tho As Integer
    Private _nhom_DonGian As Integer
    Private _tL_BinhQuan As Integer
    Private _tL_ThapNhat As Integer
    Private _tL_CaoNhat As Integer
    Private _chia_Khong As Integer
    Private _chia_BangCap As Integer
    Private _chia_DaoTao As Integer
    Private _chia_SoCap As Integer
    Private _chia_TrungCap As Integer
    Private _chia_CaoDang As Integer
    Private _chia_DaiHoc As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalId As Integer
    Private _tbTuNgay As DateTime
    Private _tbDenNgay As DateTime
    Private _tbDaGui As Boolean
    Private _tbDaCapNhat As Boolean
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

    Public Property DoanhNghiep_ID() As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
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
    Public Property TenDoanhNghiep() As String
        Get
            Return _tenDoanhNghiep
        End Get
        Set(ByVal Value As String)
            _tenDoanhNghiep = Value
        End Set
    End Property
    Public Property TaxCode() As String
        Get
            Return _taxCode
        End Get
        Set(ByVal Value As String)
            _taxCode = Value
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
    Public Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal Value As String)
            _fax = Value
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
    Public Property Website() As String
        Get
            Return _website
        End Get
        Set(ByVal Value As String)
            _website = Value
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
    Public Property TT_NT() As String
        Get
            Return _tT_NT
        End Get
        Set(ByVal Value As String)
            _tT_NT = Value
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
    Public Property KhuCN_ID() As String
        Get
            Return _khuCN_ID
        End Get
        Set(ByVal Value As String)
            _khuCN_ID = Value
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
    Public Property NganhNghe() As String
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As String)
            _nganhNghe = Value
        End Set
    End Property
    Public Property LD_TongSo() As Integer
        Get
            Return _lD_TongSo
        End Get
        Set(ByVal Value As Integer)
            _lD_TongSo = Value
        End Set
    End Property
    Public Property LD_NgoaiTinh() As Integer
        Get
            Return _lD_NgoaiTinh
        End Get
        Set(ByVal Value As Integer)
            _lD_NgoaiTinh = Value
        End Set
    End Property
    Public Property LD_TrucTiep() As Integer
        Get
            Return _lD_TrucTiep
        End Get
        Set(ByVal Value As Integer)
            _lD_TrucTiep = Value
        End Set
    End Property
    Public Property LD_Nu() As Integer
        Get
            Return _lD_Nu
        End Get
        Set(ByVal Value As Integer)
            _lD_Nu = Value
        End Set
    End Property
    Public Property LD_HD_Tong() As Integer
        Get
            Return _lD_HD_Tong
        End Get
        Set(ByVal Value As Integer)
            _lD_HD_Tong = Value
        End Set
    End Property
    Public Property LD_HD_Nu() As Integer
        Get
            Return _lD_HD_Nu
        End Get
        Set(ByVal Value As Integer)
            _lD_HD_Nu = Value
        End Set
    End Property
    Public Property LD_NuocNgoai_Tong() As Integer
        Get
            Return _lD_NuocNgoai_Tong
        End Get
        Set(ByVal Value As Integer)
            _lD_NuocNgoai_Tong = Value
        End Set
    End Property
    Public Property LD_NuocNgoai_Nu() As Integer
        Get
            Return _lD_NuocNgoai_Nu
        End Get
        Set(ByVal Value As Integer)
            _lD_NuocNgoai_Nu = Value
        End Set
    End Property
    Public Property LD_PhoThong() As Integer
        Get
            Return _lD_PhoThong
        End Get
        Set(ByVal Value As Integer)
            _lD_PhoThong = Value
        End Set
    End Property
    Public Property CMKT_Khong() As Integer
        Get
            Return _cMKT_Khong
        End Get
        Set(ByVal Value As Integer)
            _cMKT_Khong = Value
        End Set
    End Property
    Public Property CMKT_BangCap() As Integer
        Get
            Return _cMKT_BangCap
        End Get
        Set(ByVal Value As Integer)
            _cMKT_BangCap = Value
        End Set
    End Property
    Public Property CMKT_DaoTao() As Integer
        Get
            Return _cMKT_DaoTao
        End Get
        Set(ByVal Value As Integer)
            _cMKT_DaoTao = Value
        End Set
    End Property
    Public Property CMKT_SoCap() As Integer
        Get
            Return _cMKT_SoCap
        End Get
        Set(ByVal Value As Integer)
            _cMKT_SoCap = Value
        End Set
    End Property
    Public Property CMKT_TrungCap() As Integer
        Get
            Return _cMKT_TrungCap
        End Get
        Set(ByVal Value As Integer)
            _cMKT_TrungCap = Value
        End Set
    End Property
    Public Property CMKT_CaoDang() As Integer
        Get
            Return _cMKT_CaoDang
        End Get
        Set(ByVal Value As Integer)
            _cMKT_CaoDang = Value
        End Set
    End Property
    Public Property CMKT_DaiHoc() As Integer
        Get
            Return _cMKT_DaiHoc
        End Get
        Set(ByVal Value As Integer)
            _cMKT_DaiHoc = Value
        End Set
    End Property
    Public Property GDDT_KTXH() As Integer
        Get
            Return _gDDT_KTXH
        End Get
        Set(ByVal Value As Integer)
            _gDDT_KTXH = Value
        End Set
    End Property
    Public Property GDDT_KHTN() As Integer
        Get
            Return _gDDT_KHTN
        End Get
        Set(ByVal Value As Integer)
            _gDDT_KHTN = Value
        End Set
    End Property
    Public Property GDDT_KTCN() As Integer
        Get
            Return _gDDT_KTCN
        End Get
        Set(ByVal Value As Integer)
            _gDDT_KTCN = Value
        End Set
    End Property
    Public Property GDDT_NongNghiep() As Integer
        Get
            Return _gDDT_NongNghiep
        End Get
        Set(ByVal Value As Integer)
            _gDDT_NongNghiep = Value
        End Set
    End Property
    Public Property GDDT_YTe() As Integer
        Get
            Return _gDDT_YTe
        End Get
        Set(ByVal Value As Integer)
            _gDDT_YTe = Value
        End Set
    End Property
    Public Property GDDT_Khac() As Integer
        Get
            Return _gDDT_Khac
        End Get
        Set(ByVal Value As Integer)
            _gDDT_Khac = Value
        End Set
    End Property
    Public Property Nhom_LanhDao() As Integer
        Get
            Return _nhom_LanhDao
        End Get
        Set(ByVal Value As Integer)
            _nhom_LanhDao = Value
        End Set
    End Property
    Public Property Nhom_ChuyenMon() As Integer
        Get
            Return _nhom_ChuyenMon
        End Get
        Set(ByVal Value As Integer)
            _nhom_ChuyenMon = Value
        End Set
    End Property
    Public Property Nhom_TroLy() As Integer
        Get
            Return _nhom_TroLy
        End Get
        Set(ByVal Value As Integer)
            _nhom_TroLy = Value
        End Set
    End Property
    Public Property Nhom_DichVu() As Integer
        Get
            Return _nhom_DichVu
        End Get
        Set(ByVal Value As Integer)
            _nhom_DichVu = Value
        End Set
    End Property
    Public Property Nhom_NongNghiep() As Integer
        Get
            Return _nhom_NongNghiep
        End Get
        Set(ByVal Value As Integer)
            _nhom_NongNghiep = Value
        End Set
    End Property
    Public Property Nhom_ThuCong() As Integer
        Get
            Return _nhom_ThuCong
        End Get
        Set(ByVal Value As Integer)
            _nhom_ThuCong = Value
        End Set
    End Property
    Public Property Nhom_Tho() As Integer
        Get
            Return _nhom_Tho
        End Get
        Set(ByVal Value As Integer)
            _nhom_Tho = Value
        End Set
    End Property
    Public Property Nhom_DonGian() As Integer
        Get
            Return _nhom_DonGian
        End Get
        Set(ByVal Value As Integer)
            _nhom_DonGian = Value
        End Set
    End Property
    Public Property TL_BinhQuan() As Integer
        Get
            Return _tL_BinhQuan
        End Get
        Set(ByVal Value As Integer)
            _tL_BinhQuan = Value
        End Set
    End Property
    Public Property TL_ThapNhat() As Integer
        Get
            Return _tL_ThapNhat
        End Get
        Set(ByVal Value As Integer)
            _tL_ThapNhat = Value
        End Set
    End Property
    Public Property TL_CaoNhat() As Integer
        Get
            Return _tL_CaoNhat
        End Get
        Set(ByVal Value As Integer)
            _tL_CaoNhat = Value
        End Set
    End Property
    Public Property Chia_Khong() As Integer
        Get
            Return _chia_Khong
        End Get
        Set(ByVal Value As Integer)
            _chia_Khong = Value
        End Set
    End Property
    Public Property Chia_BangCap() As Integer
        Get
            Return _chia_BangCap
        End Get
        Set(ByVal Value As Integer)
            _chia_BangCap = Value
        End Set
    End Property
    Public Property Chia_DaoTao() As Integer
        Get
            Return _chia_DaoTao
        End Get
        Set(ByVal Value As Integer)
            _chia_DaoTao = Value
        End Set
    End Property
    Public Property Chia_SoCap() As Integer
        Get
            Return _chia_SoCap
        End Get
        Set(ByVal Value As Integer)
            _chia_SoCap = Value
        End Set
    End Property
    Public Property Chia_TrungCap() As Integer
        Get
            Return _chia_TrungCap
        End Get
        Set(ByVal Value As Integer)
            _chia_TrungCap = Value
        End Set
    End Property
    Public Property Chia_CaoDang() As Integer
        Get
            Return _chia_CaoDang
        End Get
        Set(ByVal Value As Integer)
            _chia_CaoDang = Value
        End Set
    End Property
    Public Property Chia_DaiHoc() As Integer
        Get
            Return _chia_DaiHoc
        End Get
        Set(ByVal Value As Integer)
            _chia_DaiHoc = Value
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
    Public Property TbTuNgay() As DateTime
        Get
            Return _tbTuNgay
        End Get
        Set(ByVal Value As DateTime)
            _tbTuNgay = Value
        End Set
    End Property
    Public Property TbDenNgay() As DateTime
        Get
            Return _tbDenNgay
        End Get
        Set(ByVal Value As DateTime)
            _tbDenNgay = Value
        End Set
    End Property
    Public Property TbDaGui() As Boolean
        Get
            Return _tbDaGui
        End Get
        Set(ByVal Value As Boolean)
            _tbDaGui = Value
        End Set
    End Property
    Public Property TbDaCapNhat() As Boolean
        Get
            Return _tbDaCapNhat
        End Get
        Set(ByVal Value As Boolean)
            _tbDaCapNhat = Value
        End Set
    End Property
#End Region

End Class
Public Class BC_CareerInfo

#Region "Private Members"
    Private _Career_ID As Integer
    Private _Career_Code As String = String.Empty
    Private _Career_Name As String = String.Empty
    Private _Career_Des As String = String.Empty
    Private _Parent_ID As String
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

    Public Property Career_ID As Integer
        Get
            Return _Career_ID
        End Get
        Set(ByVal Value As Integer)
            _Career_ID = Value
        End Set
    End Property

    Public Property Career_Code As String
        Get
            Return _Career_Code
        End Get
        Set(ByVal Value As String)
            _Career_Code = Value
        End Set
    End Property
    Public Property Career_Name As String
        Get
            Return _Career_Name
        End Get
        Set(ByVal Value As String)
            _Career_Name = Value
        End Set
    End Property
    Public Property Career_Des As String
        Get
            Return _Career_Des
        End Get
        Set(ByVal Value As String)
            _Career_Des = Value
        End Set
    End Property
    Public Property Parent_ID As String
        Get
            Return _Parent_ID
        End Get
        Set(ByVal Value As String)
            _Parent_ID = Value
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
Public Class BC_IndustrialZoneInfo

#Region "Private Members"
    Private _industrialZone_ID As String = String.Empty
    Private _industrialZone_Name As String = String.Empty
    Private _industrialZone_Code As String = String.Empty
    Private _industrialZone_Des As String = String.Empty
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
Public Class BC_LDGiamInfo

#Region "Private Members"
    Public Property IsOrder As Integer
    Public Property BHTN As Boolean
    Private _lDGiam_ID As String = String.Empty
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _ngayNop As DateTime
    Private _hoTen As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _gioiTinh As Boolean
    Private _danToc As String = String.Empty
    Private _cMND As String = String.Empty
    Private _bHXH As String = String.Empty
    Private _cNKT As Boolean
    Private _cCN As Boolean
    Private _soCap As Boolean
    Private _trungCap As Boolean
    Private _caoDang As Boolean
    Private _daiHoc As Boolean
    Private _hD_0T As Boolean
    Private _hD_36T As Boolean
    Private _hD_12T As Boolean
    Private _hD_3T As Boolean
    Private _ngayHD As DateTime
    Private _ngayChamDut As DateTime
    Private _lD_NghiHuu As Boolean
    Private _lD_DonPhuong As Boolean
    Private _lD_CoCau As Boolean
    Private _lD_ChamDut As Boolean
    Private _lD_Khac As Boolean
    Private _trangThai As Integer
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

    Public Property LDGiam_ID As String
        Get
            Return _lDGiam_ID
        End Get
        Set(ByVal Value As String)
            _lDGiam_ID = Value
        End Set
    End Property

    Public Property ThongBao_ID As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
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
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Boolean)
            _gioiTinh = Value
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
    Public Property CMND As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property BHXH As String
        Get
            Return _bHXH
        End Get
        Set(ByVal Value As String)
            _bHXH = Value
        End Set
    End Property
    Public Property CNKT() As Boolean
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Boolean)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN() As Boolean
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Boolean)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap() As Boolean
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Boolean)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap() As Boolean
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Boolean)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang() As Boolean
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Boolean)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc() As Boolean
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Boolean)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T() As Boolean
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Boolean)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T() As Boolean
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Boolean)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T() As Boolean
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Boolean)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T() As Boolean
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Boolean)
            _hD_3T = Value
        End Set
    End Property
    Public Property NgayHD() As DateTime
        Get
            Return _ngayHD
        End Get
        Set(ByVal Value As DateTime)
            _ngayHD = Value
        End Set
    End Property
    Public Property NgayChamDut() As DateTime
        Get
            Return _ngayChamDut
        End Get
        Set(ByVal Value As DateTime)
            _ngayChamDut = Value
        End Set
    End Property
    Public Property LD_NghiHuu() As Boolean
        Get
            Return _lD_NghiHuu
        End Get
        Set(ByVal Value As Boolean)
            _lD_NghiHuu = Value
        End Set
    End Property
    Public Property LD_DonPhuong() As Boolean
        Get
            Return _lD_DonPhuong
        End Get
        Set(ByVal Value As Boolean)
            _lD_DonPhuong = Value
        End Set
    End Property
    Public Property LD_CoCau() As Boolean
        Get
            Return _lD_CoCau
        End Get
        Set(ByVal Value As Boolean)
            _lD_CoCau = Value
        End Set
    End Property
    Public Property LD_ChamDut() As Boolean
        Get
            Return _lD_ChamDut
        End Get
        Set(ByVal Value As Boolean)
            _lD_ChamDut = Value
        End Set
    End Property
    Public Property LD_Khac() As Boolean
        Get
            Return _lD_Khac
        End Get
        Set(ByVal Value As Boolean)
            _lD_Khac = Value
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
Public Class BC_LDHoanInfo

#Region "Private Members"
    Public Property IsOrder As Integer
    Private _lDHoan_ID As String = String.Empty
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _ngayNop As DateTime
    Private _hoTen As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _gioiTinh As Boolean
    Private _danToc As String = String.Empty
    Private _cMND As String = String.Empty
    Private _bHXH As String = String.Empty
    Private _cNKT As Boolean
    Private _cCN As Boolean
    Private _soCap As Boolean
    Private _trungCap As Boolean
    Private _caoDang As Boolean
    Private _daiHoc As Boolean
    Private _hD_0T As Boolean
    Private _hD_36T As Boolean
    Private _hD_12T As Boolean
    Private _hD_3T As Boolean
    Private _ngayHD As DateTime
    Private _bHTN As Boolean
    Private _hoanTu As DateTime
    Private _hoanDen As DateTime
    Private _trangThai As Integer
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

    Public Property LDHoan_ID As String
        Get
            Return _lDHoan_ID
        End Get
        Set(ByVal Value As String)
            _lDHoan_ID = Value
        End Set
    End Property

    Public Property ThongBao_ID As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
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
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Boolean)
            _gioiTinh = Value
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
    Public Property CMND As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property BHXH As String
        Get
            Return _bHXH
        End Get
        Set(ByVal Value As String)
            _bHXH = Value
        End Set
    End Property
    Public Property CNKT() As Boolean
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Boolean)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN() As Boolean
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Boolean)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap() As Boolean
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Boolean)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap() As Boolean
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Boolean)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang() As Boolean
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Boolean)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc() As Boolean
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Boolean)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T() As Boolean
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Boolean)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T() As Boolean
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Boolean)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T() As Boolean
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Boolean)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T() As Boolean
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Boolean)
            _hD_3T = Value
        End Set
    End Property
    Public Property NgayHD() As DateTime
        Get
            Return _ngayHD
        End Get
        Set(ByVal Value As DateTime)
            _ngayHD = Value
        End Set
    End Property
    Public Property BHTN() As Boolean
        Get
            Return _bHTN
        End Get
        Set(ByVal Value As Boolean)
            _bHTN = Value
        End Set
    End Property
    Public Property HoanTu() As DateTime
        Get
            Return _hoanTu
        End Get
        Set(ByVal Value As DateTime)
            _hoanTu = Value
        End Set
    End Property
    Public Property HoanDen() As DateTime
        Get
            Return _hoanDen
        End Get
        Set(ByVal Value As DateTime)
            _hoanDen = Value
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
Public Class BC_LDTangInfo

#Region "Private Members"
    Public Property IsOrder As Integer
    Private _lDTang_ID As String = String.Empty
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _ngayNop As DateTime
    Private _hoTen As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _gioiTinh As Boolean
    Private _danToc As String = String.Empty
    Private _cMND As String = String.Empty
    Private _bHXH As String = String.Empty
    Private _cNKT As Boolean
    Private _cCN As Boolean
    Private _soCap As Boolean
    Private _trungCap As Boolean
    Private _caoDang As Boolean
    Private _daiHoc As Boolean
    Private _hD_0T As Boolean
    Private _hD_36T As Boolean
    Private _hD_12T As Boolean
    Private _hD_3T As Boolean
    Private _ngayHD As DateTime
    Private _viTri As String = String.Empty
    Private _bHTN As Double
    Private _tG_BHTN As Double
    Private _trangThai As Integer
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

    Public Property LDTang_ID As String
        Get
            Return _lDTang_ID
        End Get
        Set(ByVal Value As String)
            _lDTang_ID = Value
        End Set
    End Property

    Public Property ThongBao_ID As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
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
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Boolean)
            _gioiTinh = Value
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
    Public Property CMND As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property BHXH As String
        Get
            Return _bHXH
        End Get
        Set(ByVal Value As String)
            _bHXH = Value
        End Set
    End Property
    Public Property CNKT() As Boolean
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Boolean)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN() As Boolean
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Boolean)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap() As Boolean
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Boolean)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap() As Boolean
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Boolean)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang() As Boolean
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Boolean)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc() As Boolean
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Boolean)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T() As Boolean
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Boolean)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T() As Boolean
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Boolean)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T() As Boolean
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Boolean)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T() As Boolean
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Boolean)
            _hD_3T = Value
        End Set
    End Property
    Public Property NgayHD() As DateTime
        Get
            Return _ngayHD
        End Get
        Set(ByVal Value As DateTime)
            _ngayHD = Value
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
    Public Property BHTN() As Double
        Get
            Return _bHTN
        End Get
        Set(ByVal Value As Double)
            _bHTN = Value
        End Set
    End Property
    Public Property TG_BHTN() As Double
        Get
            Return _tG_BHTN
        End Get
        Set(ByVal Value As Double)
            _tG_BHTN = Value
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
Public Class BC_TBCuoiKyInfo

#Region "Private Members"
    Public Property IsOrder As Integer
    Private _tBCuoiKy_ID As String = String.Empty
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _ngayNop As DateTime
    Private _thoiDiem As String = String.Empty
    Private _tongSoLD As Integer
    Private _tongSoNu As Integer
    Private _cNKT As Integer
    Private _cCN As Integer
    Private _soCap As Integer
    Private _trungCap As Integer
    Private _caoDang As Integer
    Private _daiHoc As Integer
    Private _hD_0T As Integer
    Private _hD_36T As Integer
    Private _hD_12T As Integer
    Private _hD_3T As Integer
    Private _bHTN As Integer
    Private _trangThai As Integer
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

    Public Property TBCuoiKy_ID As String
        Get
            Return _tBCuoiKy_ID
        End Get
        Set(ByVal Value As String)
            _tBCuoiKy_ID = Value
        End Set
    End Property

    Public Property ThongBao_ID As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
        End Set
    End Property
    Public Property ThoiDiem As String
        Get
            Return _thoiDiem
        End Get
        Set(ByVal Value As String)
            _thoiDiem = Value
        End Set
    End Property
    Public Property TongSoLD() As Integer
        Get
            Return _tongSoLD
        End Get
        Set(ByVal Value As Integer)
            _tongSoLD = Value
        End Set
    End Property
    Public Property TongSoNu() As Integer
        Get
            Return _tongSoNu
        End Get
        Set(ByVal Value As Integer)
            _tongSoNu = Value
        End Set
    End Property
    Public Property CNKT() As Integer
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Integer)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN() As Integer
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Integer)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap() As Integer
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Integer)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap() As Integer
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Integer)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang() As Integer
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Integer)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc() As Integer
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Integer)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T() As Integer
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Integer)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T() As Integer
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Integer)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T() As Integer
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Integer)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T() As Integer
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Integer)
            _hD_3T = Value
        End Set
    End Property
    Public Property BHTN() As Integer
        Get
            Return _bHTN
        End Get
        Set(ByVal Value As Integer)
            _bHTN = Value
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
Public Class BC_TBDauKyInfo

#Region "Private Members"
    Public Property IsOrder As Integer
    Private _tBDauKy_ID As String = String.Empty
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _ngayNop As DateTime
    Private _hoTen As String = String.Empty
    Private _ngaySinh As String = String.Empty
    Private _gioiTinh As Boolean
    Private _danToc As String = String.Empty
    Private _cMND As String = String.Empty
    Private _bHXH As String = String.Empty
    Private _cNKT As Boolean
    Private _cCN As Boolean
    Private _soCap As Boolean
    Private _trungCap As Boolean
    Private _caoDang As Boolean
    Private _daiHoc As Boolean
    Private _hD_0T As Boolean
    Private _hD_36T As Boolean
    Private _hD_12T As Boolean
    Private _hD_3T As Boolean
    Private _ngayHD As DateTime
    Private _viTri As String = String.Empty
    Private _bHTN As Double
    Private _tG_BHTN As Double
    Private _trangThai As Integer
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

    Public Property TBDauKy_ID As String
        Get
            Return _tBDauKy_ID
        End Get
        Set(ByVal Value As String)
            _tBDauKy_ID = Value
        End Set
    End Property

    Public Property ThongBao_ID As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
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
    Public Property NgaySinh As String
        Get
            Return _ngaySinh
        End Get
        Set(ByVal Value As String)
            _ngaySinh = Value
        End Set
    End Property
    Public Property GioiTinh() As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal Value As Boolean)
            _gioiTinh = Value
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
    Public Property CMND As String
        Get
            Return _cMND
        End Get
        Set(ByVal Value As String)
            _cMND = Value
        End Set
    End Property
    Public Property BHXH As String
        Get
            Return _bHXH
        End Get
        Set(ByVal Value As String)
            _bHXH = Value
        End Set
    End Property
    Public Property CNKT() As Boolean
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Boolean)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN() As Boolean
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Boolean)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap() As Boolean
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Boolean)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap() As Boolean
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Boolean)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang() As Boolean
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Boolean)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc() As Boolean
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Boolean)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T() As Boolean
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Boolean)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T() As Boolean
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Boolean)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T() As Boolean
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Boolean)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T() As Boolean
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Boolean)
            _hD_3T = Value
        End Set
    End Property
    Public Property NgayHD() As DateTime
        Get
            Return _ngayHD
        End Get
        Set(ByVal Value As DateTime)
            _ngayHD = Value
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
    Public Property BHTN() As Double
        Get
            Return _bHTN
        End Get
        Set(ByVal Value As Double)
            _bHTN = Value
        End Set
    End Property
    Public Property TG_BHTN() As Double
        Get
            Return _tG_BHTN
        End Get
        Set(ByVal Value As Double)
            _tG_BHTN = Value
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
Public Class BC_ThongBaoInfo

#Region "Private Members"
    Private _thongBao_ID As String = String.Empty
    Private _doanhNghiep_ID As String = String.Empty
    Private _business_Vn As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _xaPhuong As String = String.Empty
    Private _tT_NT As String = String.Empty
    Private _soNha As String = String.Empty
    Private _ngayThongBao As DateTime
    Private _createdDate As DateTime
    Private _ngayNop As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalId As Integer
    Private _Period_ID As Integer
    Private _years_ID As Integer
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
    Public Property NgayNop() As DateTime
        Get
            Return _ngayNop
        End Get
        Set(ByVal Value As DateTime)
            _ngayNop = Value
        End Set
    End Property
    Public Property ThongBao_ID() As String
        Get
            Return _thongBao_ID
        End Get
        Set(ByVal Value As String)
            _thongBao_ID = Value
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
    Public Property Business_Vn() As String
        Get
            Return _business_Vn
        End Get
        Set(ByVal Value As String)
            _business_Vn = Value
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
    Public Property TT_NT() As String
        Get
            Return _tT_NT
        End Get
        Set(ByVal Value As String)
            _tT_NT = Value
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
    Public Property NgayThongBao() As DateTime
        Get
            Return _ngayThongBao
        End Get
        Set(ByVal Value As DateTime)
            _ngayThongBao = Value
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
    Public Property Years_ID() As Integer
        Get
            Return _years_ID
        End Get
        Set(ByVal Value As Integer)
            _years_ID = Value
        End Set
    End Property
    Public Property Period_ID() As Integer
        Get
            Return _Period_ID
        End Get
        Set(ByVal Value As Integer)
            _Period_ID = Value
        End Set
    End Property
#End Region

End Class
Public Class BC_SendMailInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _fromDate As DateTime
    Private _toDate As DateTime
    Private _years_ID As Integer
    Private _contents As String = String.Empty
    Private _createDate As DateTime
    Private _userName As String = String.Empty
    Private _portalID As Integer
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

    Public Property ID() As String
        Get
            Return _iD
        End Get
        Set(ByVal Value As String)
            _iD = Value
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
    Public Property FromDate() As DateTime
        Get
            Return _fromDate
        End Get
        Set(ByVal Value As DateTime)
            _fromDate = Value
        End Set
    End Property
    Public Property ToDate() As DateTime
        Get
            Return _toDate
        End Get
        Set(ByVal Value As DateTime)
            _toDate = Value
        End Set
    End Property
    Public Property Years_ID() As Integer
        Get
            Return _years_ID
        End Get
        Set(ByVal Value As Integer)
            _years_ID = Value
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
    Public Property PortalID() As Integer
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Integer)
            _portalID = Value
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
