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
    Private _ID As String = String.Empty
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
    Private _nganhNghe As Integer
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

    Public Property ID As String
        Get
            Return _ID
        End Get
        Set(ByVal Value As String)
            _ID = Value
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
    Public Property TinhTrang As Integer
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
    Public Property NganhNghe() As Integer
        Get
            Return _nganhNghe
        End Get
        Set(ByVal Value As Integer)
            _nganhNghe = Value
        End Set
    End Property
    Public Property LD_NgoaiTinh As Integer
    Public Property LD_TrucTiep As Integer
    Public Property LD_Nu As Integer
    Public Property LD_HD_Tong As Integer
    Public Property LD_HD_Nu As Integer
    Public Property LD_NuocNgoai_Tong As Integer
    Public Property LD_NuocNgoai_Nu As Integer
    Public Property LD_PhoThong As Integer
    Public Property CMKT_Khong As Integer
    Public Property CMKT_BangCap As Integer
    Public Property CMKT_DaoTao As Integer
    Public Property CMKT_SoCap As Integer

    Public Property CMKT_TrungCap As Integer

    Public Property CMKT_CaoDang As Integer

    Public Property CMKT_DaiHoc As Integer

    Public Property GDDT_KTXH As Integer

    Public Property GDDT_KHTN As Integer

    Public Property GDDT_KTCN As Integer

    Public Property GDDT_NongNghiep As Integer

    Public Property GDDT_YTe As Integer

    Public Property GDDT_Khac As Integer

    Public Property Nhom_LanhDao As Integer

    Public Property Nhom_ChuyenMon As Integer

    Public Property Nhom_TroLy As Integer

    Public Property Nhom_DichVu As Integer

    Public Property Nhom_NongNghiep As Integer

    Public Property Nhom_ThuCong As Integer

    Public Property Nhom_Tho As Integer

    Public Property Nhom_DonGian As Integer

    Public Property TL_BinhQuan As Integer

    Public Property TL_ThapNhat As Integer

    Public Property TL_CaoNhat As Integer

    Public Property Chia_Khong As Integer

    Public Property Chia_BangCap As Integer

    Public Property Chia_DaoTao As Integer

    Public Property Chia_SoCap As Integer

    Public Property Chia_TrungCap As Integer

    Public Property Chia_CaoDang As Integer

    Public Property Chia_DaiHoc As Integer

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
    Public Property PortalId As Integer
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
    Public Property SanPhamChinh As String
    Public Property QuyMoLaoDong As Integer
    Public Property LD_NgoaiTinh_Nu As Integer
    Public Property LD_TrucTiep_Nu As Integer
    Public Property LD_GianTiep As Integer
    Public Property LD_GianTiep_Nu As Integer
    Public Property LD_BHXH As Integer
    Public Property LD_BHXH_Nu As Integer
    Public Property LD_TREN35 As Integer
    Public Property LD_TREN35_Nu As Integer
    Public Property LD_PhoThong_Nu As Integer
    Public Property VT_NhaQuanLy As Integer
    Public Property VT_NhaQuanLy_Nu As Integer
    Public Property VT_CMKT_Cao As Integer
    Public Property VT_CMKT_Cao_Nu As Integer
    Public Property VT_CMKT_Trung As Integer
    Public Property VT_CMKT_Trung_Nu As Integer
    Public Property VT_CMKT_Khac As Integer
    Public Property VT_CMKT_Khac_Nu As Integer
    Public Property CMKT_Khong_Nu As Integer
    Public Property CMKT_BangCap_Nu As Integer
    Public Property CMKT_DaoTao_Nu As Integer
    Public Property CMKT_SoCap_Nu As Integer
    Public Property CMKT_TrungCap_Nu As Integer
    Public Property CMKT_CaoDang_Nu As Integer
    Public Property CMKT_DaiHoc_Nu As Integer
    Public Property GDDT_KTXH_Nu As Integer
    Public Property GDDT_KHTN_Nu As Integer
    Public Property GDDT_KTCN_Nu As Integer
    Public Property GDDT_NongNghiep_Nu As Integer
    Public Property GDDT_YTe_Nu As Integer
    Public Property GDDT_Khac_Nu As Integer
    Public Property C8_17 As Integer
    Public Property C8_21 As Integer
    Public Property C8_22 As Integer
    Public Property C8_23 As Integer
    Public Property C8_24 As Integer
    Public Property C8_25 As Integer
    Public Property C8_26 As Integer
    Public Property C8_31 As Integer
    Public Property C8_32 As Integer
    Public Property C8_33 As Integer
    Public Property C8_34 As Integer
    Public Property C8_35 As Integer
    Public Property C8_36 As Integer
    Public Property C8_41 As Integer
    Public Property C8_42 As Integer
    Public Property C8_43 As Integer
    Public Property C8_44 As Integer
    Public Property C8_51 As Integer
    Public Property C8_52 As Integer
    Public Property C8_53 As Integer
    Public Property C8_54 As Integer
    Public Property C8_61 As Integer
    Public Property C8_62 As Integer
    Public Property C8_63 As Integer
    Public Property C8_71 As Integer
    Public Property C8_72 As Integer
    Public Property C8_73 As Integer
    Public Property C8_74 As Integer
    Public Property C8_75 As Integer
    Public Property C8_81 As Integer
    Public Property C8_82 As Integer
    Public Property C8_83 As Integer
    Public Property C8_91 As Integer
    Public Property C8_92 As Integer
    Public Property C8_93 As Integer
    Public Property C8_94 As Integer
    Public Property C8_95 As Integer
    Public Property C8_96 As Integer
    Public Property C8_17_Nu As Integer
    Public Property C8_21_Nu As Integer
    Public Property C8_22_Nu As Integer
    Public Property C8_23_Nu As Integer
    Public Property C8_24_Nu As Integer
    Public Property C8_25_Nu As Integer
    Public Property C8_26_Nu As Integer
    Public Property C8_31_Nu As Integer
    Public Property C8_32_Nu As Integer
    Public Property C8_33_Nu As Integer
    Public Property C8_34_Nu As Integer
    Public Property C8_35_Nu As Integer
    Public Property C8_36_Nu As Integer
    Public Property C8_41_Nu As Integer
    Public Property C8_42_Nu As Integer
    Public Property C8_43_Nu As Integer
    Public Property C8_44_Nu As Integer
    Public Property C8_51_Nu As Integer
    Public Property C8_52_Nu As Integer
    Public Property C8_53_Nu As Integer
    Public Property C8_54_Nu As Integer
    Public Property C8_61_Nu As Integer
    Public Property C8_62_Nu As Integer
    Public Property C8_63_Nu As Integer
    Public Property C8_71_Nu As Integer
    Public Property C8_72_Nu As Integer
    Public Property C8_73_Nu As Integer
    Public Property C8_74_Nu As Integer
    Public Property C8_75_Nu As Integer
    Public Property C8_81_Nu As Integer
    Public Property C8_82_Nu As Integer
    Public Property C8_83_Nu As Integer
    Public Property C8_91_Nu As Integer
    Public Property C8_92_Nu As Integer
    Public Property C8_93_Nu As Integer
    Public Property C8_94_Nu As Integer
    Public Property C8_95_Nu As Integer
    Public Property C8_96_Nu As Integer
    Public Property C11_17 As Integer
    Public Property C11_21 As Integer
    Public Property C11_22 As Integer
    Public Property C11_23 As Integer
    Public Property C11_24 As Integer
    Public Property C11_25 As Integer
    Public Property C11_26 As Integer
    Public Property C11_31 As Integer
    Public Property C11_32 As Integer
    Public Property C11_33 As Integer
    Public Property C11_34 As Integer
    Public Property C11_35 As Integer
    Public Property C11_36 As Integer
    Public Property C11_41 As Integer
    Public Property C11_42 As Integer
    Public Property C11_43 As Integer
    Public Property C11_44 As Integer
    Public Property C11_51 As Integer
    Public Property C11_52 As Integer
    Public Property C11_53 As Integer
    Public Property C11_54 As Integer
    Public Property C11_61 As Integer
    Public Property C11_62 As Integer
    Public Property C11_63 As Integer
    Public Property C11_71 As Integer
    Public Property C11_72 As Integer
    Public Property C11_73 As Integer
    Public Property C11_74 As Integer
    Public Property C11_75 As Integer
    Public Property C11_81 As Integer
    Public Property C11_82 As Integer
    Public Property C11_83 As Integer
    Public Property C11_91 As Integer
    Public Property C11_92 As Integer
    Public Property C11_93 As Integer
    Public Property C11_94 As Integer
    Public Property C11_95 As Integer
    Public Property C11_96 As Integer
    Public Property C11_17_Nu As Integer
    Public Property C11_21_Nu As Integer
    Public Property C11_22_Nu As Integer
    Public Property C11_23_Nu As Integer
    Public Property C11_24_Nu As Integer
    Public Property C11_25_Nu As Integer
    Public Property C11_26_Nu As Integer
    Public Property C11_31_Nu As Integer
    Public Property C11_32_Nu As Integer
    Public Property C11_33_Nu As Integer
    Public Property C11_34_Nu As Integer
    Public Property C11_35_Nu As Integer
    Public Property C11_36_Nu As Integer
    Public Property C11_41_Nu As Integer
    Public Property C11_42_Nu As Integer
    Public Property C11_43_Nu As Integer
    Public Property C11_44_Nu As Integer
    Public Property C11_51_Nu As Integer
    Public Property C11_52_Nu As Integer
    Public Property C11_53_Nu As Integer
    Public Property C11_54_Nu As Integer
    Public Property C11_61_Nu As Integer
    Public Property C11_62_Nu As Integer
    Public Property C11_63_Nu As Integer
    Public Property C11_71_Nu As Integer
    Public Property C11_72_Nu As Integer
    Public Property C11_73_Nu As Integer
    Public Property C11_74_Nu As Integer
    Public Property C11_75_Nu As Integer
    Public Property C11_81_Nu As Integer
    Public Property C11_82_Nu As Integer
    Public Property C11_83_Nu As Integer
    Public Property C11_91_Nu As Integer
    Public Property C11_92_Nu As Integer
    Public Property C11_93_Nu As Integer
    Public Property C11_94_Nu As Integer
    Public Property C11_95_Nu As Integer
    Public Property C11_96_Nu As Integer
    Public Property C10_LaoDong As Integer
    Public Property Chia_Khong_Nu As Integer
    Public Property Chia_BangCap_Nu As Integer
    Public Property Chia_DaoTao_Nu As Integer
    Public Property Chia_SoCap_Nu As Integer
    Public Property Chia_TrungCap_Nu As Integer
    Public Property Chia_CaoDang_Nu As Integer
    Public Property Chia_DaiHoc_Nu As Integer
    Public Property C10_LaoDong_NhaNuoc As Integer
    Public Property C10_LaoDong_NgoaiNuoc As Integer
    Public Property C10_LaoDong_VonNN As Integer
    Public Property C10_LaoDong_DonViNN As Integer
    Public Property C10_LaoDong_HoKD As Integer
    Public Property C10_LaoDong_CaNhan As Integer
    Public Property TongSoDN As Integer
    Public Property LD_TongSo As Integer
    Public Property KT_TongSoDN As Integer
    Public Property KT_LD_TongSo As Integer
    Public Property KT_LD_Nu As Integer
    Public Property KT_LD_TREN35 As Integer
    Public Property KT_LD_BHXH As Integer
    Public Property KT_VT_NhaQuanLy As Integer
    Public Property KT_VT_CMKT_Cao As Integer
    Public Property KT_VT_CMKT_Trung As Integer
    Public Property KT_VT_CMKT_Khac As Integer
    Public Property KT_C10_LaoDong As Integer
    Public Property KT_C10_LaoDong_NhaNuoc As Integer
    Public Property KT_C10_LaoDong_NgoaiNuoc As Integer
    Public Property KT_C10_LaoDong_VonNN As Integer
    Public Property KT_C10_LaoDong_DonViNN As Integer
    Public Property KT_C10_LaoDong_HoKD As Integer
    Public Property KT_C10_LaoDong_CaNhan As Integer
    Public Property KT_C11_17 As Integer
    Public Property KT_C11_21 As Integer
    Public Property KT_C11_22 As Integer
    Public Property KT_C11_23 As Integer
    Public Property KT_C11_24 As Integer
    Public Property KT_C11_25 As Integer
    Public Property KT_C11_26 As Integer
    Public Property KT_C11_31 As Integer
    Public Property KT_C11_32 As Integer
    Public Property KT_C11_33 As Integer
    Public Property KT_C11_34 As Integer
    Public Property KT_C11_35 As Integer
    Public Property KT_C11_36 As Integer
    Public Property KT_C11_41 As Integer
    Public Property KT_C11_42 As Integer
    Public Property KT_C11_43 As Integer
    Public Property KT_C11_44 As Integer
    Public Property KT_C11_51 As Integer
    Public Property KT_C11_52 As Integer
    Public Property KT_C11_53 As Integer
    Public Property KT_C11_54 As Integer
    Public Property KT_C11_61 As Integer
    Public Property KT_C11_62 As Integer
    Public Property KT_C11_63 As Integer
    Public Property KT_C11_71 As Integer
    Public Property KT_C11_72 As Integer
    Public Property KT_C11_73 As Integer
    Public Property KT_C11_74 As Integer
    Public Property KT_C11_75 As Integer
    Public Property KT_C11_81 As Integer
    Public Property KT_C11_82 As Integer
    Public Property KT_C11_83 As Integer
    Public Property KT_C11_91 As Integer
    Public Property KT_C11_92 As Integer
    Public Property KT_C11_93 As Integer
    Public Property KT_C11_94 As Integer
    Public Property KT_C11_95 As Integer
    Public Property KT_C11_96 As Integer
    Public Property KT_LD_NuocNgoai_Tong As Integer

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
    Public Property TrangThai As Integer
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
    Public Property TrangThai As Integer
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
    Public Property TrangThai As Integer
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
    Public Property TongSoLD As Integer
        Get
            Return _tongSoLD
        End Get
        Set(ByVal Value As Integer)
            _tongSoLD = Value
        End Set
    End Property
    Public Property TongSoNu As Integer
        Get
            Return _tongSoNu
        End Get
        Set(ByVal Value As Integer)
            _tongSoNu = Value
        End Set
    End Property
    Public Property CNKT As Integer
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Integer)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN As Integer
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Integer)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap As Integer
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Integer)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap As Integer
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Integer)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang As Integer
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Integer)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc As Integer
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Integer)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T As Integer
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Integer)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T As Integer
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Integer)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T As Integer
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Integer)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T As Integer
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Integer)
            _hD_3T = Value
        End Set
    End Property
    Public Property BHTN As Integer
        Get
            Return _bHTN
        End Get
        Set(ByVal Value As Integer)
            _bHTN = Value
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
    Public Property TrangThai As Integer
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
    Public Property PortalId As Integer
        Get
            Return _portalId
        End Get
        Set(ByVal Value As Integer)
            _portalId = Value
        End Set
    End Property
    Public Property Years_ID As Integer
        Get
            Return _years_ID
        End Get
        Set(ByVal Value As Integer)
            _years_ID = Value
        End Set
    End Property
    Public Property Period_ID As Integer
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

    Public Property IsLock As Boolean
    Public Property IsActive As Boolean
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
    Public Property Years_ID As Integer
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
    Public Property PortalID As Integer
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
Public Class BC_BackupInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _tinhTP As String = String.Empty
    Private _years As Integer
    Private _isData As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
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
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(ByVal Value As Integer)
            _years = Value
        End Set
    End Property
    Public Property IsData As Integer
        Get
            Return _isData
        End Get
        Set(ByVal Value As Integer)
            _isData = Value
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
Public Class Rpt_CauInfo
    Public Property TongSo As String
    Public Property STT As String
    Public Property cot2 As String
    Public Property cot3 As String
    Public Property cot4 As String
    Public Property cot5 As String
    Public Property cot6 As String
    Public Property cot7 As String
    Public Property cot8 As String
    Public Property cot9 As String
    Public Property cot10 As String
    Public Property cot11 As String
    Public Property cot12 As String
    Public Property cot13 As String
    Public Property cot14 As String
    Public Property cot15 As String
    Public Property cot16 As String
    Public Property cot17 As String
    Public Property cot18 As String
    Public Property cot19 As String
    Public Property cot20 As String
    Public Property cot21 As String
    Public Property cot22 As String
    Public Property cot23 As String
    Public Property cot24 As String
    Public Property cot25 As String
    Public Property cot26 As String
    Public Property cot27 As String
    Public Property cot28 As String
    Public Property cot29 As String
    Public Property cot30 As String
    Public Property cot31 As String
    Public Property cot32 As String
    Public Property cot33 As String
    Public Property cot34 As String
    Public Property cot35 As String
    Public Property cot36 As String
    Public Property cot37 As String
    Public Property cot38 As String
    Public Property cot39 As String
    Public Property cot40 As String
    Public Property cot41 As String
    Public Property cot42 As String
    Public Property cot43 As String
    Public Property cot44 As String
    Public Property cot45 As String
    Public Property cot46 As String
    Public Property cot47 As String
    Public Property cot48 As String
    Public Property cot49 As String
    Public Property cot50 As String
    Public Property TenXa As String
    Public Property TongsoDN As String
    Public Property SoLDTrucTiep As String
    Public Property SoLDGianTiep As String
    Public Property LDQuaDT As String
    Public Property LDKyHD As String
End Class
Public Class CMS_IndustrialInfo

#Region "Private Members"
    Private _IndustrialZone_ID As String = String.Empty
    Private _IndustrialZone_Name As String = String.Empty
    Private _IndustrialZone_Code As String = String.Empty
    Private _IndustrialZone_Des As String = String.Empty
    Private _Parent_ID As String = String.Empty
    Private _IsOrder As Integer
    Private _createDate As DateTime
    Private _updatedDate As DateTime
    Private _createUser As String = String.Empty
    Private _updatedUser As String = String.Empty
    Private _IsActive As Boolean
    Private _PortalId As Integer
    Private _TinhIP As Integer
    Private _QuanHuyen As String = String.Empty
    Private _PhuongXa As String = String.Empty
#End Region

#Region "Public Properties"
    Public Property IndustrialZone_ID As String
        Get
            Return _IndustrialZone_ID
        End Get
        Set(ByVal Value As String)
            _IndustrialZone_ID = Value
        End Set
    End Property
    Public Property IndustrialZone_Name As String
        Get
            Return _IndustrialZone_Name
        End Get
        Set(ByVal Value As String)
            _IndustrialZone_Name = Value
        End Set
    End Property
    Public Property IndustrialZone_Code As String
        Get
            Return _IndustrialZone_Code
        End Get
        Set(ByVal Value As String)
            _IndustrialZone_Code = Value
        End Set
    End Property
    Public Property IndustrialZone_Des As String
        Get
            Return _IndustrialZone_Des
        End Get
        Set(ByVal Value As String)
            _IndustrialZone_Des = Value
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
    Public Property IsOrder As Integer
        Get
            Return _IsOrder
        End Get
        Set(ByVal Value As Integer)
            _IsOrder = Value
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
    Public Property CreateUser As String
        Get
            Return _createUser
        End Get
        Set(ByVal Value As String)
            _createUser = Value
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
            Return _IsActive
        End Get
        Set(ByVal Value As Boolean)
            _IsActive = Value
        End Set
    End Property
    Public Property PortalId As Integer
        Get
            Return _PortalId
        End Get
        Set(ByVal Value As Integer)
            _PortalId = Value
        End Set
    End Property
    Public Property TinhIP As Integer
        Get
            Return _TinhIP
        End Get
        Set(ByVal Value As Integer)
            _TinhIP = Value
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
#End Region

End Class
Public Class BC_CompanyTypeInfo

#Region "Private Members"
    Private _iD As Integer
    Private _MaLoaiHinh As String = String.Empty
    Private _TenLoaiHinh As String = String.Empty
    Private _STT As Integer
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
    Public Property MaLoaiHinh As String
        Get
            Return _MaLoaiHinh
        End Get
        Set(ByVal Value As String)
            _MaLoaiHinh = Value
        End Set
    End Property
    Public Property TenLoaiHinh As String
        Get
            Return _TenLoaiHinh
        End Get
        Set(ByVal Value As String)
            _TenLoaiHinh = Value
        End Set
    End Property
    Public Property STT As Integer
        Get
            Return _STT
        End Get
        Set(ByVal Value As Integer)
            _STT = Value
        End Set
    End Property
#End Region

End Class
Public Class BC_PhieuDTInfo

#Region "Private Members"
    Private _iD As Integer
    Private _isYears As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _xaPhuong As Integer
    Private _tenXP As String = String.Empty
    Private _phieuDT As String = String.Empty
    Private _paths As String = String.Empty
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
    Public Property IsYears As Integer
        Get
            Return _isYears
        End Get
        Set(ByVal Value As Integer)
            _isYears = Value
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
    Public Property TenXP As String
        Get
            Return _tenXP
        End Get
        Set(ByVal Value As String)
            _tenXP = Value
        End Set
    End Property
    Public Property PhieuDT As String
        Get
            Return _phieuDT
        End Get
        Set(ByVal Value As String)
            _phieuDT = Value
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
    Private _kT_TT As Integer
    Private _kT_GT As Integer
    Private _kT_DT As Integer
    Private _kT_KHD As Integer
    Private _kBC_Tong As Integer
    Private _kBC_TT As Integer
    Private _kBC_GT As Integer
    Private _kBC_DT As Integer
    Private _kBC_KHD As Integer
    Private _dNM_Tong As Integer
    Private _dNM_LD As Integer
    Private _dNM_KHD As Integer
    Private _dNM_DT As Integer
    Private _dND_Tong As Integer
    Private _dND_LD As Integer
    Private _dND_KHD As Integer
    Private _dND_DT As Integer
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
    Public Property KT_TT As Integer
        Get
            Return _kT_TT
        End Get
        Set(ByVal Value As Integer)
            _kT_TT = Value
        End Set
    End Property
    Public Property KT_GT As Integer
        Get
            Return _kT_GT
        End Get
        Set(ByVal Value As Integer)
            _kT_GT = Value
        End Set
    End Property
    Public Property KT_DT As Integer
        Get
            Return _kT_DT
        End Get
        Set(ByVal Value As Integer)
            _kT_DT = Value
        End Set
    End Property
    Public Property KT_KHD As Integer
        Get
            Return _kT_KHD
        End Get
        Set(ByVal Value As Integer)
            _kT_KHD = Value
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
    Public Property KBC_TT As Integer
        Get
            Return _kBC_TT
        End Get
        Set(ByVal Value As Integer)
            _kBC_TT = Value
        End Set
    End Property
    Public Property KBC_GT As Integer
        Get
            Return _kBC_GT
        End Get
        Set(ByVal Value As Integer)
            _kBC_GT = Value
        End Set
    End Property
    Public Property KBC_DT As Integer
        Get
            Return _kBC_DT
        End Get
        Set(ByVal Value As Integer)
            _kBC_DT = Value
        End Set
    End Property
    Public Property KBC_KHD As Integer
        Get
            Return _kBC_KHD
        End Get
        Set(ByVal Value As Integer)
            _kBC_KHD = Value
        End Set
    End Property
    Public Property DNM_Tong As Integer
        Get
            Return _dNM_Tong
        End Get
        Set(ByVal Value As Integer)
            _dNM_Tong = Value
        End Set
    End Property
    Public Property DNM_LD As Integer
        Get
            Return _dNM_LD
        End Get
        Set(ByVal Value As Integer)
            _dNM_LD = Value
        End Set
    End Property
    Public Property DNM_KHD As Integer
        Get
            Return _dNM_KHD
        End Get
        Set(ByVal Value As Integer)
            _dNM_KHD = Value
        End Set
    End Property
    Public Property DNM_DT As Integer
        Get
            Return _dNM_DT
        End Get
        Set(ByVal Value As Integer)
            _dNM_DT = Value
        End Set
    End Property
    Public Property DND_Tong As Integer
        Get
            Return _dND_Tong
        End Get
        Set(ByVal Value As Integer)
            _dND_Tong = Value
        End Set
    End Property
    Public Property DND_LD As Integer
        Get
            Return _dND_LD
        End Get
        Set(ByVal Value As Integer)
            _dND_LD = Value
        End Set
    End Property
    Public Property DND_KHD As Integer
        Get
            Return _dND_KHD
        End Get
        Set(ByVal Value As Integer)
            _dND_KHD = Value
        End Set
    End Property
    Public Property DND_DT As Integer
        Get
            Return _dND_DT
        End Get
        Set(ByVal Value As Integer)
            _dND_DT = Value
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
    Private _kT_TT As Integer
    Private _kT_GT As Integer
    Private _kT_DT As Integer
    Private _kT_KHD As Integer
    Private _kBC_Tong As Integer
    Private _kBC_TT As Integer
    Private _kBC_GT As Integer
    Private _kBC_DT As Integer
    Private _kBC_KHD As Integer
    Private _dNM_Tong As Integer
    Private _dNM_LD As Integer
    Private _dNM_KHD As Integer
    Private _dNM_DT As Integer
    Private _dND_Tong As Integer
    Private _dND_LD As Integer
    Private _dND_KHD As Integer
    Private _dND_DT As Integer
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
    Public Property KT_TT As Integer
        Get
            Return _kT_TT
        End Get
        Set(ByVal Value As Integer)
            _kT_TT = Value
        End Set
    End Property
    Public Property KT_GT As Integer
        Get
            Return _kT_GT
        End Get
        Set(ByVal Value As Integer)
            _kT_GT = Value
        End Set
    End Property
    Public Property KT_DT As Integer
        Get
            Return _kT_DT
        End Get
        Set(ByVal Value As Integer)
            _kT_DT = Value
        End Set
    End Property
    Public Property KT_KHD As Integer
        Get
            Return _kT_KHD
        End Get
        Set(ByVal Value As Integer)
            _kT_KHD = Value
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
    Public Property KBC_TT As Integer
        Get
            Return _kBC_TT
        End Get
        Set(ByVal Value As Integer)
            _kBC_TT = Value
        End Set
    End Property
    Public Property KBC_GT As Integer
        Get
            Return _kBC_GT
        End Get
        Set(ByVal Value As Integer)
            _kBC_GT = Value
        End Set
    End Property
    Public Property KBC_DT As Integer
        Get
            Return _kBC_DT
        End Get
        Set(ByVal Value As Integer)
            _kBC_DT = Value
        End Set
    End Property
    Public Property KBC_KHD As Integer
        Get
            Return _kBC_KHD
        End Get
        Set(ByVal Value As Integer)
            _kBC_KHD = Value
        End Set
    End Property
    Public Property DNM_Tong As Integer
        Get
            Return _dNM_Tong
        End Get
        Set(ByVal Value As Integer)
            _dNM_Tong = Value
        End Set
    End Property
    Public Property DNM_LD As Integer
        Get
            Return _dNM_LD
        End Get
        Set(ByVal Value As Integer)
            _dNM_LD = Value
        End Set
    End Property
    Public Property DNM_KHD As Integer
        Get
            Return _dNM_KHD
        End Get
        Set(ByVal Value As Integer)
            _dNM_KHD = Value
        End Set
    End Property
    Public Property DNM_DT As Integer
        Get
            Return _dNM_DT
        End Get
        Set(ByVal Value As Integer)
            _dNM_DT = Value
        End Set
    End Property
    Public Property DND_Tong As Integer
        Get
            Return _dND_Tong
        End Get
        Set(ByVal Value As Integer)
            _dND_Tong = Value
        End Set
    End Property
    Public Property DND_LD As Integer
        Get
            Return _dND_LD
        End Get
        Set(ByVal Value As Integer)
            _dND_LD = Value
        End Set
    End Property
    Public Property DND_KHD As Integer
        Get
            Return _dND_KHD
        End Get
        Set(ByVal Value As Integer)
            _dND_KHD = Value
        End Set
    End Property
    Public Property DND_DT As Integer
        Get
            Return _dND_DT
        End Get
        Set(ByVal Value As Integer)
            _dND_DT = Value
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
Public Class BC_TBLDTang_THInfo

#Region "Private Members"
    Private _iD As Integer
    Private _quanHuyen As Integer
    Private _yearsID As Integer
    Private _periodID As Integer
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

    Public Property QuanHuyen As Integer
        Get
            Return _quanHuyen
        End Get
        Set(ByVal Value As Integer)
            _quanHuyen = Value
        End Set
    End Property
    Public Property YearsID As Integer
        Get
            Return _yearsID
        End Get
        Set(ByVal Value As Integer)
            _yearsID = Value
        End Set
    End Property
    Public Property PeriodID As Integer
        Get
            Return _periodID
        End Get
        Set(ByVal Value As Integer)
            _periodID = Value
        End Set
    End Property
    Public Property TongSoLD As Integer
        Get
            Return _tongSoLD
        End Get
        Set(ByVal Value As Integer)
            _tongSoLD = Value
        End Set
    End Property
    Public Property TongSoNu As Integer
        Get
            Return _tongSoNu
        End Get
        Set(ByVal Value As Integer)
            _tongSoNu = Value
        End Set
    End Property
    Public Property CNKT As Integer
        Get
            Return _cNKT
        End Get
        Set(ByVal Value As Integer)
            _cNKT = Value
        End Set
    End Property
    Public Property CCN As Integer
        Get
            Return _cCN
        End Get
        Set(ByVal Value As Integer)
            _cCN = Value
        End Set
    End Property
    Public Property SoCap As Integer
        Get
            Return _soCap
        End Get
        Set(ByVal Value As Integer)
            _soCap = Value
        End Set
    End Property
    Public Property TrungCap As Integer
        Get
            Return _trungCap
        End Get
        Set(ByVal Value As Integer)
            _trungCap = Value
        End Set
    End Property
    Public Property CaoDang As Integer
        Get
            Return _caoDang
        End Get
        Set(ByVal Value As Integer)
            _caoDang = Value
        End Set
    End Property
    Public Property DaiHoc As Integer
        Get
            Return _daiHoc
        End Get
        Set(ByVal Value As Integer)
            _daiHoc = Value
        End Set
    End Property
    Public Property HD_0T As Integer
        Get
            Return _hD_0T
        End Get
        Set(ByVal Value As Integer)
            _hD_0T = Value
        End Set
    End Property
    Public Property HD_36T As Integer
        Get
            Return _hD_36T
        End Get
        Set(ByVal Value As Integer)
            _hD_36T = Value
        End Set
    End Property
    Public Property HD_12T As Integer
        Get
            Return _hD_12T
        End Get
        Set(ByVal Value As Integer)
            _hD_12T = Value
        End Set
    End Property
    Public Property HD_3T As Integer
        Get
            Return _hD_3T
        End Get
        Set(ByVal Value As Integer)
            _hD_3T = Value
        End Set
    End Property
#End Region

End Class
Public Class apiBusinessInfo
    Public Property doanhNghiep_ID As String = ""
    Public Property maDoanhNghiep As String = ""
    Public Property tenDoanhNghiep As String = ""
    Public Property taxCode As String = ""
    Public Property mobile As String = ""
    Public Property fax As String = ""
    Public Property email As String = ""
    Public Property website As String = ""
    Public Property tinhTrang As Integer
    Public Property tinhTP As String = ""
    Public Property quanHuyen As String = ""
    Public Property xaPhuong As String = ""
    Public Property tT_NT As String = ""
    Public Property soNha As String = ""
    Public Property khuCN As String = ""
    Public Property loaiHinh As String = ""
    Public Property nganhNghe As String = ""
    Public Property lD_TongSo As Integer
    Public Property lD_NgoaiTinh As Integer
    Public Property lD_TrucTiep As Integer
    Public Property lD_Nu As Integer
    Public Property lD_HD_Tong As Integer
    Public Property lD_HD_Nu As Integer
    Public Property lD_NuocNgoai_Tong As Integer
    Public Property lD_NuocNgoai_Nu As Integer
    Public Property lD_PhoThong As Integer
    Public Property cMKT_Khong As Integer
    Public Property cMKT_BangCap As Integer
    Public Property cMKT_DaoTao As Integer
    Public Property cMKT_SoCap As Integer
    Public Property cMKT_TrungCap As Integer
    Public Property cMKT_CaoDang As Integer
    Public Property cMKT_DaiHoc As Integer
    Public Property gDDT_KTXH As Integer
    Public Property gDDT_KHTN As Integer
    Public Property gDDT_KTCN As Integer
    Public Property gDDT_NongNghiep As Integer
    Public Property gDDT_YTe As Integer
    Public Property gDDT_Khac As Integer
    Public Property nhom_LanhDao As Integer
    Public Property nhom_ChuyenMon As Integer
    Public Property nhom_TroLy As Integer
    Public Property nhom_DichVu As Integer
    Public Property nhom_NongNghiep As Integer
    Public Property nhom_ThuCong As Integer
    Public Property nhom_Tho As Integer
    Public Property nhom_DonGian As Integer
    Public Property tL_BinhQuan As Integer
    Public Property tL_ThapNhat As Integer
    Public Property tL_CaoNhat As Integer
    Public Property chia_Khong As Integer
    Public Property chia_BangCap As Integer
    Public Property chia_DaoTao As Integer
    Public Property chia_SoCap As Integer
    Public Property chia_TrungCap As Integer
    Public Property chia_CaoDang As Integer
    Public Property chia_DaiHoc As Integer
End Class
Public Class apiIndustrialZoneInfo
    Public Property industrialZone_ID As String = ""
    Public Property industrialZone_Name As String = ""
    Public Property industrialZone_Code As String = ""
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

Public Class ThongKeInfo
    Public Property Ten As String
    Public Property SoLuong As Integer
End Class