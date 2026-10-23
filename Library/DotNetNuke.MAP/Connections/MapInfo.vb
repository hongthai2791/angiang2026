Public Class CMS_GroupInfo

#Region "Private Members"
	Private _group_ID As Integer
	Private _asxh_ID As Integer
	Private _parentID As Integer
	Private _group_Code As String = String.Empty
	Private _group_Name As String = String.Empty
	Private _group_Des As String = String.Empty
	Private _GroupType As Int16
	Private _chartType As Integer
	Private _className As String = String.Empty
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isOrder As Integer
	Private _total As Integer
#End Region

#Region "Public Properties"
	Private _isHome As Boolean
	Public Property IsHome() As Boolean
		Get
			Return _isHome
		End Get
		Set(ByVal value As Boolean)
			_isHome = value
		End Set
	End Property
	Public Property GroupType As Int16
		Get
			Return _GroupType
		End Get
		Set(ByVal Value As Int16)
			_GroupType = Value
		End Set
	End Property
	Public Property ClassName As String
		Get
			Return _className
		End Get
		Set(ByVal Value As String)
			_className = Value
		End Set
	End Property
	Public Property ChartType As Integer
		Get
			Return _chartType
		End Get
		Set(ByVal Value As Integer)
			_chartType = Value
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

	Public Property ASXH_ID As Integer
		Get
			Return _asxh_ID
		End Get
		Set(ByVal Value As Integer)
			_asxh_ID = Value
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

	Public Property Group_ID As Integer
		Get
			Return _group_ID
		End Get
		Set(ByVal Value As Integer)
			_group_ID = Value
		End Set
	End Property

	Public Property Group_Code As String
		Get
			Return _group_Code
		End Get
		Set(ByVal Value As String)
			_group_Code = Value
		End Set
	End Property
	Public Property Group_Name As String
		Get
			Return _group_Name
		End Get
		Set(ByVal Value As String)
			_group_Name = Value
		End Set
	End Property
	Public Property Group_Des As String
		Get
			Return _group_Des
		End Get
		Set(ByVal Value As String)
			_group_Des = Value
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
Public Class CMS_TargetsInfo

#Region "Private Members"
	Private _tinhTP As Integer
	Private _quanhuyen As Integer
	Private _phuongxa As Integer
	Private _asxh_id As Integer
	Private _targets_ID As Integer
	Private _group_ID As Integer
	Private _targets_Code As String = String.Empty
	Private _targets_Name As String = String.Empty
	Private _Targets_Sort As String = String.Empty
	Private _targets_Des As String = String.Empty
	Private _targets_Src As String = String.Empty
	Private _Targets_Caculator As String = String.Empty
	Private _parent_ID As Integer
	Private _createdDate As DateTime
	Private _createdUser As String = String.Empty
	Private _updatedDate As DateTime
	Private _updatedUser As String = String.Empty
	Private _isOrder As Integer
	Private _isSum As Boolean
	Private _isHome As Boolean
	Private _IsChild As Boolean
	Private _IsMain As Boolean
	Private _IsGroup As Boolean
	Private _total As Integer
	Private _tempT_ID As Integer
	Private _temp_ID As Integer
	Private _unitType_ID As Integer
	Public Property ValGiaTri As Double
	Public Property ValDes As String
	Public Property IsActive As Boolean
#End Region

#Region "Public Properties"

	Public Property IsRegTar As Integer
	Public Property ValRegTar As String
	Public Property Targets_Caculator As String
		Get
			Return _Targets_Caculator
		End Get
		Set(ByVal Value As String)
			_Targets_Caculator = Value
		End Set
	End Property
	Public Property Targets_Src As String
		Get
			Return _targets_Src
		End Get
		Set(ByVal Value As String)
			_targets_Src = Value
		End Set
	End Property
	Public Property UnitTypeID As Integer
		Get
			Return _unitType_ID
		End Get
		Set(ByVal Value As Integer)
			_unitType_ID = Value
		End Set
	End Property

	Public Property ASXH_ID As Integer
		Get
			Return _asxh_id
		End Get
		Set(ByVal Value As Integer)
			_asxh_id = Value
		End Set
	End Property

	Public Property Quanhuyen As Integer
		Get
			Return _quanhuyen
		End Get
		Set(ByVal Value As Integer)
			_quanhuyen = Value
		End Set
	End Property

	Public Property Phuongxa As Integer
		Get
			Return _phuongxa
		End Get
		Set(ByVal Value As Integer)
			_phuongxa = Value
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
	Public Property TempT_ID As Integer
		Get
			Return _tempT_ID
		End Get
		Set(ByVal Value As Integer)
			_tempT_ID = Value
		End Set
	End Property
	Public Property Temp_ID As Integer
		Get
			Return _temp_ID
		End Get
		Set(ByVal Value As Integer)
			_temp_ID = Value
		End Set
	End Property
	Public Property Targets_ID As Integer
		Get
			Return _targets_ID
		End Get
		Set(ByVal Value As Integer)
			_targets_ID = Value
		End Set
	End Property
	Public Property Group_ID As Integer
		Get
			Return _group_ID
		End Get
		Set(ByVal Value As Integer)
			_group_ID = Value
		End Set
	End Property
	Public Property Targets_Code As String
		Get
			Return _targets_Code
		End Get
		Set(ByVal Value As String)
			_targets_Code = Value
		End Set
	End Property
	Public Property Targets_Name As String
		Get
			Return _targets_Name
		End Get
		Set(ByVal Value As String)
			_targets_Name = Value
		End Set
	End Property
	Public Property Targets_Sort As String
		Get
			Return _Targets_Sort
		End Get
		Set(ByVal Value As String)
			_Targets_Sort = Value
		End Set
	End Property
	Public Property Targets_Des As String
		Get
			Return _targets_Des
		End Get
		Set(ByVal Value As String)
			_targets_Des = Value
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
	Public Property IsOrder As Integer
		Get
			Return _isOrder
		End Get
		Set(ByVal Value As Integer)
			_isOrder = Value
		End Set
	End Property
	Public Property IsSum As Boolean
		Get
			Return _isSum
		End Get
		Set(ByVal Value As Boolean)
			_isSum = Value
		End Set
	End Property
	Public Property IsHome As Boolean
		Get
			Return _isHome
		End Get
		Set(ByVal Value As Boolean)
			_isHome = Value
		End Set
	End Property
	Public Property IsMain As Boolean
		Get
			Return _IsMain
		End Get
		Set(ByVal Value As Boolean)
			_IsMain = Value
		End Set
	End Property
	Public Property IsGroup As Boolean
		Get
			Return _IsGroup
		End Get
		Set(ByVal Value As Boolean)
			_IsGroup = Value
		End Set
	End Property
	Public Property IsChild As Boolean
		Get
			Return _IsChild
		End Get
		Set(ByVal Value As Boolean)
			_IsChild = Value
		End Set
	End Property
#End Region

End Class
Public Class BannerInfo
#Region "Private Members"
	Private _id As Integer
	Private _tenBanner As String = String.Empty
	Private _linkURL As String = String.Empty
	Private _hinhAnh As String = String.Empty
	Private _ghiChu As String = String.Empty
	Private _viTri As String = String.Empty
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

	Public Property TenBanner() As String
		Get
			Return _tenBanner
		End Get
		Set(ByVal Value As String)
			_tenBanner = Value
		End Set
	End Property
	Public Property LinkURL() As String
		Get
			Return _linkURL
		End Get
		Set(ByVal Value As String)
			_linkURL = Value
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
	Public Property ViTri() As String
		Get
			Return _viTri
		End Get
		Set(ByVal Value As String)
			_viTri = Value
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

Public Class LienKetInfo
#Region "Private Members"
	Private _id As Integer
	Private _tenLienKet As String = String.Empty
	Private _linkURL As String = String.Empty
	Private _hinhAnh As String = String.Empty
	Private _ghiChu As String = String.Empty
	Private _viTri As String = String.Empty
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

	Public Property TenLienKet() As String
		Get
			Return _tenLienKet
		End Get
		Set(ByVal Value As String)
			_tenLienKet = Value
		End Set
	End Property
	Public Property LinkURL() As String
		Get
			Return _linkURL
		End Get
		Set(ByVal Value As String)
			_linkURL = Value
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
	Public Property ViTri() As String
		Get
			Return _viTri
		End Get
		Set(ByVal Value As String)
			_viTri = Value
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

Public Class MauSacInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenMauSac As String = String.Empty
	Private _thuocTinh As String = String.Empty
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

	Public Property TenMauSac() As String
		Get
			Return _tenMauSac
		End Get
		Set(ByVal Value As String)
			_tenMauSac = Value
		End Set
	End Property
	Public Property ThuocTinh() As String
		Get
			Return _thuocTinh
		End Get
		Set(ByVal Value As String)
			_thuocTinh = Value
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

Public Class LopBanDoInfo

#Region "Private Members"
	Private _id As Integer
	Private _idMauSac As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _maThon As Integer
	Private _tenLop As String = String.Empty
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
	Private _thuocTinh As String = String.Empty
	Private _viDo As String = String.Empty
	Private _kinhDo As String = String.Empty
	Private _tenTinh As String = String.Empty
	Private _tenQuan As String = String.Empty
	Private _tenXa As String = String.Empty
	Private _tenThon As String = String.Empty
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

	Public Property IdMauSac() As Integer
		Get
			Return _idMauSac
		End Get
		Set(ByVal Value As Integer)
			_idMauSac = Value
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
	Public Property TenLop() As String
		Get
			Return _tenLop
		End Get
		Set(ByVal Value As String)
			_tenLop = Value
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
	Public Property ThuocTinh() As String
		Get
			Return _thuocTinh
		End Get
		Set(ByVal Value As String)
			_thuocTinh = Value
		End Set
	End Property
	Public Property ViDo() As String
		Get
			Return _viDo
		End Get
		Set(ByVal Value As String)
			_viDo = Value
		End Set
	End Property
	Public Property KinhDo() As String
		Get
			Return _kinhDo
		End Get
		Set(ByVal Value As String)
			_kinhDo = Value
		End Set
	End Property
	Public Property TenTinh() As String
		Get
			Return _tenTinh
		End Get
		Set(ByVal Value As String)
			_tenTinh = Value
		End Set
	End Property
	Public Property TenQuan() As String
		Get
			Return _tenQuan
		End Get
		Set(ByVal Value As String)
			_tenQuan = Value
		End Set
	End Property
	Public Property TenXa() As String
		Get
			Return _tenXa
		End Get
		Set(ByVal Value As String)
			_tenXa = Value
		End Set
	End Property
	Public Property TenThon() As String
		Get
			Return _tenThon
		End Get
		Set(ByVal Value As String)
			_tenThon = Value
		End Set
	End Property
#End Region

End Class

Public Class DiemLopInfo

#Region "Private Members"
	Private _id As Integer
	Private _idLop As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _maThon As Integer
	Private _tenDiemLop As String = String.Empty
	Private _toaDo As String = String.Empty
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
	Private _tenLop As String = String.Empty
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

	Public Property IdLop() As Integer
		Get
			Return _idLop
		End Get
		Set(ByVal Value As Integer)
			_idLop = Value
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
	Public Property TenDiemLop() As String
		Get
			Return _tenDiemLop
		End Get
		Set(ByVal Value As String)
			_tenDiemLop = Value
		End Set
	End Property
	Public Property ToaDo() As String
		Get
			Return _toaDo
		End Get
		Set(ByVal Value As String)
			_toaDo = Value
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
	Public Property TenLop() As String
		Get
			Return _tenLop
		End Get
		Set(ByVal Value As String)
			_tenLop = Value
		End Set
	End Property
#End Region

End Class

Public Class VungBanDoInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenVungBanDo As String = String.Empty
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

	Public Property TenVungBanDo() As String
		Get
			Return _tenVungBanDo
		End Get
		Set(ByVal Value As String)
			_tenVungBanDo = Value
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

Public Class BoCucInfo

#Region "Private Members"
	Private _id As Integer
	Private _idVungBanDo As Integer
	Private _tenBoCuc As String = String.Empty
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

	Public Property IdVungBanDo() As Integer
		Get
			Return _idVungBanDo
		End Get
		Set(ByVal Value As Integer)
			_idVungBanDo = Value
		End Set
	End Property
	Public Property TenBoCuc() As String
		Get
			Return _tenBoCuc
		End Get
		Set(ByVal Value As String)
			_tenBoCuc = Value
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

Public Class MAP_APIInfo

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
	Private _lichDongBo As String = String.Empty
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


Public Class MAP_APIHeaderInfo

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

Public Class MAP_LogsAPIInfo

#Region "Private Members"
	Private _id As Integer
	Private _idAPI As Integer
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

	Public Property IdAPI() As Integer
		Get
			Return _idAPI
		End Get
		Set(ByVal Value As Integer)
			_idAPI = Value
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

Public Class MAP_NhomMenuInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenMenu As String = String.Empty
	Private _linkURL As String = String.Empty
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

	Public Property TenMenu() As String
		Get
			Return _tenMenu
		End Get
		Set(ByVal Value As String)
			_tenMenu = Value
		End Set
	End Property
	Public Property LinkURL() As String
		Get
			Return _linkURL
		End Get
		Set(ByVal Value As String)
			_linkURL = Value
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

Public Class MAP_MenuInfo

#Region "Private Members"
	Private _id As Integer
	Private _idMenu As Integer
	Private _tenMenu As String = String.Empty
	Private _linkURL As String = String.Empty
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

	Public Property IdMenu() As Integer
		Get
			Return _idMenu
		End Get
		Set(ByVal Value As Integer)
			_idMenu = Value
		End Set
	End Property
	Public Property TenMenu() As String
		Get
			Return _tenMenu
		End Get
		Set(ByVal Value As String)
			_tenMenu = Value
		End Set
	End Property
	Public Property LinkURL() As String
		Get
			Return _linkURL
		End Get
		Set(ByVal Value As String)
			_linkURL = Value
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
Public Class HT_ThietLapInfo

#Region "Private Members"
	Private _id As Integer
	Private _maThietLap As String = String.Empty
	Private _tenThietLap As String = String.Empty
	Private _giaTri As String = String.Empty
	Private _giaTriMacDinh As String = String.Empty
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

	Public Property MaThietLap() As String
		Get
			Return _maThietLap
		End Get
		Set(ByVal Value As String)
			_maThietLap = Value
		End Set
	End Property
	Public Property TenThietLap() As String
		Get
			Return _tenThietLap
		End Get
		Set(ByVal Value As String)
			_tenThietLap = Value
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
	Public Property GiaTriMacDinh() As String
		Get
			Return _giaTriMacDinh
		End Get
		Set(ByVal Value As String)
			_giaTriMacDinh = Value
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

Public Class MapDoanhNghiepInfo

#Region "Private Members"
	Private _id As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _tenDoanhNghiep As String = String.Empty
	Private _email As String = String.Empty
	Private _hotline As String = String.Empty
	Private _viDo As String = String.Empty
	Private _kinhDo As String = String.Empty
	Private _tenTinh As String = String.Empty
	Private _tenQuan As String = String.Empty
	Private _tenXa As String = String.Empty
	Private _diaChi As String = String.Empty
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

	Public Property TenDoanhNghiep() As String
		Get
			Return _tenDoanhNghiep
		End Get
		Set(ByVal Value As String)
			_tenDoanhNghiep = Value
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
	Public Property Hotline() As String
		Get
			Return _hotline
		End Get
		Set(ByVal Value As String)
			_hotline = Value
		End Set
	End Property
	Public Property ViDo() As String
		Get
			Return _viDo
		End Get
		Set(ByVal Value As String)
			_viDo = Value
		End Set
	End Property
	Public Property KinhDo() As String
		Get
			Return _kinhDo
		End Get
		Set(ByVal Value As String)
			_kinhDo = Value
		End Set
	End Property
	Public Property TenTinh() As String
		Get
			Return _tenTinh
		End Get
		Set(ByVal Value As String)
			_tenTinh = Value
		End Set
	End Property
	Public Property TenQuan() As String
		Get
			Return _tenQuan
		End Get
		Set(ByVal Value As String)
			_tenQuan = Value
		End Set
	End Property
	Public Property TenXa() As String
		Get
			Return _tenXa
		End Get
		Set(ByVal Value As String)
			_tenXa = Value
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
#End Region

End Class

Public Class MapTuyenDungInfo

#Region "Private Members"
	Private _id As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _tenTuyenDung As String = String.Empty
	Private _email As String = String.Empty
	Private _hotline As String = String.Empty
	Private _viDo As String = String.Empty
	Private _kinhDo As String = String.Empty
	Private _tenTinh As String = String.Empty
	Private _tenQuan As String = String.Empty
	Private _tenXa As String = String.Empty
	Private _diaChi As String = String.Empty
	Private _mucLuong As String = String.Empty
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

	Public Property TenTuyenDung() As String
		Get
			Return _tenTuyenDung
		End Get
		Set(ByVal Value As String)
			_tenTuyenDung = Value
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
	Public Property Hotline() As String
		Get
			Return _hotline
		End Get
		Set(ByVal Value As String)
			_hotline = Value
		End Set
	End Property
	Public Property ViDo() As String
		Get
			Return _viDo
		End Get
		Set(ByVal Value As String)
			_viDo = Value
		End Set
	End Property
	Public Property KinhDo() As String
		Get
			Return _kinhDo
		End Get
		Set(ByVal Value As String)
			_kinhDo = Value
		End Set
	End Property
	Public Property TenTinh() As String
		Get
			Return _tenTinh
		End Get
		Set(ByVal Value As String)
			_tenTinh = Value
		End Set
	End Property
	Public Property TenQuan() As String
		Get
			Return _tenQuan
		End Get
		Set(ByVal Value As String)
			_tenQuan = Value
		End Set
	End Property
	Public Property TenXa() As String
		Get
			Return _tenXa
		End Get
		Set(ByVal Value As String)
			_tenXa = Value
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
	Public Property MucLuong() As String
		Get
			Return _mucLuong
		End Get
		Set(ByVal Value As String)
			_mucLuong = Value
		End Set
	End Property
#End Region

End Class


Public Class MAP_DATAInfo

#Region "Private Members"
	Private _id As Integer
	Private _targetID As Integer
	Private _targetCode As String = String.Empty
	Private _targetName As String = String.Empty
	Private _yearID As Integer
	Private _maTinh As Integer
	Private _maHuyen As Integer
	Private _maXa As Integer
	Private _maThon As Integer
	Private _data As Integer
	Private _groupId As Short
	Private _total As Integer
#End Region

#Region "Public Properties"
	Private _TenLop As String
	Public Property TenLop() As String
		Get
			Return _TenLop
		End Get
		Set(ByVal value As String)
			_TenLop = value
		End Set
	End Property
	Private _TenTinh As String
	Public Property TenTinh() As String
		Get
			Return _TenTinh
		End Get
		Set(ByVal value As String)
			_TenTinh = value
		End Set
	End Property
	Private _TenQuan As String
	Public Property TenQuan() As String
		Get
			Return _TenQuan
		End Get
		Set(ByVal value As String)
			_TenQuan = value
		End Set
	End Property
	Private _TenXa As String
	Public Property TenXa() As String
		Get
			Return _TenXa
		End Get
		Set(ByVal value As String)
			_TenXa = value
		End Set
	End Property
	Private _ViDo As String
	Public Property ViDo() As String
		Get
			Return _ViDo
		End Get
		Set(ByVal value As String)
			_ViDo = value
		End Set
	End Property
	Private _KinhDo As String
	Public Property KinhDo() As String
		Get
			Return _KinhDo
		End Get
		Set(ByVal value As String)
			_KinhDo = value
		End Set
	End Property
	Private _ThuocTinh As String
	Public Property ThuocTinh() As String
		Get
			Return _ThuocTinh
		End Get
		Set(ByVal value As String)
			_ThuocTinh = value
		End Set
	End Property
	Private _GhiChu As String
	Public Property GhiChu() As String
		Get
			Return _GhiChu
		End Get
		Set(ByVal value As String)
			_GhiChu = value
		End Set
	End Property

	Private _types As Integer
	Public Property Types() As Integer
		Get
			Return _types
		End Get
		Set(ByVal value As Integer)
			_types = value
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

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
			_id = Value
		End Set
	End Property

	Public Property TargetID() As Integer
		Get
			Return _targetID
		End Get
		Set(ByVal Value As Integer)
			_targetID = Value
		End Set
	End Property
	Public Property TargetCode() As String
		Get
			Return _targetCode
		End Get
		Set(ByVal Value As String)
			_targetCode = Value
		End Set
	End Property
	Public Property TargetName() As String
		Get
			Return _targetName
		End Get
		Set(ByVal Value As String)
			_targetName = Value
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
	Public Property Data() As Integer
		Get
			Return _data
		End Get
		Set(ByVal Value As Integer)
			_data = Value
		End Set
	End Property
	Public Property GroupId() As Short
		Get
			Return _groupId
		End Get
		Set(ByVal Value As Short)
			_groupId = Value
		End Set
	End Property
#End Region

End Class

Public Class MAP_DATA_BUSSINESSInfo

#Region "Private Members"
	Private _id As Integer
	Private _business_ID As String = String.Empty
	Private _business_Vn As String = String.Empty
	Private _tinhTP As String = String.Empty
	Private _quanHuyen As String = String.Empty
	Private _xaPhuong As String = String.Empty
	Private _description As String = String.Empty
	Private _taxCode As String = String.Empty
	Private _mobile As String = String.Empty
	Private _fax As String = String.Empty
	Private _website As String = String.Empty
	Private _email As String = String.Empty
	Private _address As String = String.Empty
	Private _lat As String = String.Empty
	Private _lng As String = String.Empty
	Private _total As Integer
	Private _toURL As String = String.Empty

#End Region

#Region "Public Properties"
	Public Property ToURL() As String
		Get
			Return _toURL
		End Get
		Set(ByVal value As String)
			_toURL = value
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
	Private _career_ID As String
	Public Property Career_ID() As String
		Get
			Return _career_ID
		End Get
		Set(ByVal value As String)
			_career_ID = value
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
	Public Property Description() As String
		Get
			Return _description
		End Get
		Set(ByVal Value As String)
			_description = Value
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
	Public Property Address() As String
		Get
			Return _address
		End Get
		Set(ByVal Value As String)
			_address = Value
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
#End Region

End Class

Public Class MAP_DATA_WORKInfo

#Region "Private Members"
	Private _id As Integer
	Private _work_ID As String = String.Empty
	Private _business_ID As String = String.Empty
	Private _title As String = String.Empty
	Private _salary_ID As String = String.Empty
	Private _quantity As Integer
	Private _experience_ID As String = String.Empty
	Private _gender As Integer
	Private _level_ID As String = String.Empty
	Private _tinhTP As String = String.Empty
	Private _quanHuyen As String = String.Empty
	Private _xaPhuong As String = String.Empty
	Private _typeOf_ID As String = String.Empty
	Private _career_ID As String = String.Empty
	Private _description As String = String.Empty
	Private _expiredDate As DateTime
	Private _startDate As DateTime
	Private _endDate As DateTime
	Private _isHot As Boolean
	Private _isUrgent As Boolean
	Private _lat As String = String.Empty
	Private _lng As String = String.Empty
	Private _total As Integer
#End Region

#Region "Public Properties"
	Private _toUrl As String
	Public Property ToUrl() As String
		Get
			Return _toUrl
		End Get
		Set(ByVal value As String)
			_toUrl = value
		End Set
	End Property
	Private _tenDoanhNghiep As String
	Public Property TenDoanhNghiep() As String
		Get
			Return _tenDoanhNghiep
		End Get
		Set(ByVal value As String)
			_tenDoanhNghiep = value
		End Set
	End Property
	Private _kinhNghiem As String
	Public Property KinhNghiem() As String
		Get
			Return _kinhNghiem
		End Get
		Set(ByVal value As String)
			_kinhNghiem = value
		End Set
	End Property
	Private _mucLuong As String
	Public Property MucLuong() As String
		Get
			Return _mucLuong
		End Get
		Set(ByVal value As String)
			_mucLuong = value
		End Set
	End Property
	Private _tenXa As String
	Public Property TenXa() As String
		Get
			Return _tenXa
		End Get
		Set(ByVal value As String)
			_tenXa = value
		End Set
	End Property
	Private _tenHuyen As String
	Public Property TenHuyen() As String
		Get
			Return _tenHuyen
		End Get
		Set(ByVal value As String)
			_tenHuyen = value
		End Set
	End Property
	Private _tenTinh As String
	Public Property TenTinh() As String
		Get
			Return _tenTinh
		End Get
		Set(ByVal value As String)
			_tenTinh = value
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

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
			_id = Value
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
	Public Property Business_ID() As String
		Get
			Return _business_ID
		End Get
		Set(ByVal Value As String)
			_business_ID = Value
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
	Public Property Salary_ID() As String
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
	Public Property Experience_ID() As String
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
	Public Property Level_ID() As String
		Get
			Return _level_ID
		End Get
		Set(ByVal Value As String)
			_level_ID = Value
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
	Public Property Description() As String
		Get
			Return _description
		End Get
		Set(ByVal Value As String)
			_description = Value
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
	Public Property IsHot() As Boolean
		Get
			Return _isHot
		End Get
		Set(ByVal Value As Boolean)
			_isHot = Value
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

Public Class MAP_DATALstInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenLop As String = String.Empty
	Private _maTinh As Integer
	Private _tenTinh As String = String.Empty
	Private _maHuyen As Integer
	Private _tenQuan As String = String.Empty
	Private _maXa As Integer
	Private _tenXa As String = String.Empty
	Private _maThon As Integer
	Private _tenThon As String = String.Empty
	Private _viDo As String = String.Empty
	Private _kinhDo As String = String.Empty
	Private _mauSac As String = String.Empty
	Private _ghiChu As String = String.Empty
	Private _soLieu As Integer
	Private _total As Integer
	Private _kieu As Integer
#End Region

#Region "Public Properties"
	Public Property TenLop() As String
		Get
			Return _tenLop
		End Get
		Set(ByVal value As String)
			_tenLop = value
		End Set
	End Property
	Public Property TenTinh() As String
		Get
			Return _tenTinh
		End Get
		Set(ByVal value As String)
			_tenTinh = value
		End Set
	End Property
	Public Property TenQuan() As String
		Get
			Return _tenQuan
		End Get
		Set(ByVal value As String)
			_tenQuan = value
		End Set
	End Property
	Public Property TenXa() As String
		Get
			Return _tenXa
		End Get
		Set(ByVal value As String)
			_tenXa = value
		End Set
	End Property
	Public Property TenThon() As String
		Get
			Return _tenThon
		End Get
		Set(ByVal value As String)
			_tenThon = value
		End Set
	End Property
	Public Property ViDo() As String
		Get
			Return _viDo
		End Get
		Set(ByVal value As String)
			_viDo = value
		End Set
	End Property
	Public Property KinhDo() As String
		Get
			Return _kinhDo
		End Get
		Set(ByVal value As String)
			_kinhDo = value
		End Set
	End Property
	Public Property MauSac() As String
		Get
			Return _mauSac
		End Get
		Set(ByVal value As String)
			_mauSac = value
		End Set
	End Property
	Public Property GhiChu() As String
		Get
			Return _ghiChu
		End Get
		Set(ByVal value As String)
			_ghiChu = value
		End Set
	End Property

	Private _types As Integer
	Public Property Types() As Integer
		Get
			Return _types
		End Get
		Set(ByVal value As Integer)
			_types = value
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

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal Value As Integer)
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
	Public Property SoLieu() As Integer
		Get
			Return _soLieu
		End Get
		Set(ByVal Value As Integer)
			_soLieu = Value
		End Set
	End Property
	Public Property Kieu() As Integer
		Get
			Return _kieu
		End Get
		Set(ByVal Value As Integer)
			_kieu = Value
		End Set
	End Property
#End Region

End Class

Public Class MAP_KyNhapLieuInfo

#Region "Private Members"
	Private _id As Integer
	Private _ten As String = String.Empty
	Private _ma As String = String.Empty
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

	Public Property Ten() As String
		Get
			Return _ten
		End Get
		Set(ByVal Value As String)
			_ten = Value
		End Set
	End Property
	Public Property Ma() As String
		Get
			Return _ma
		End Get
		Set(ByVal Value As String)
			_ma = Value
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
















