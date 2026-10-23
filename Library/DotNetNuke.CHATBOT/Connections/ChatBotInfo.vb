Public Class BotInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenBot As String = String.Empty
	Private _tenChatBot As String = String.Empty
	Private _logo As String = String.Empty
	Private _soYHieu As Integer
	Private _soTrichDan As Integer
	Private _ghiChu As String = String.Empty
	Private _loaiBot As Short
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

	Public Property TenBot() As String
		Get
			Return _tenBot
		End Get
		Set(ByVal Value As String)
			_tenBot = Value
		End Set
	End Property
	Public Property TenChatBot() As String
		Get
			Return _tenChatBot
		End Get
		Set(ByVal Value As String)
			_tenChatBot = Value
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
	Public Property SoYHieu() As Integer
		Get
			Return _soYHieu
		End Get
		Set(ByVal Value As Integer)
			_soYHieu = Value
		End Set
	End Property
	Public Property SoTrichDan() As Integer
		Get
			Return _soTrichDan
		End Get
		Set(ByVal Value As Integer)
			_soTrichDan = Value
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
	Public Property LoaiBot() As Short
		Get
			Return _loaiBot
		End Get
		Set(ByVal Value As Short)
			_loaiBot = Value
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
Public Class BienInfo

#Region "Private Members"
	Private _id As Integer
	Private _idThucThe As Integer
	Private _tenBien As String = String.Empty
	Private _keyBien As String = String.Empty
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
	Private _tenThucThe As String = String.Empty
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

	Public Property IdThucThe() As Integer
		Get
			Return _idThucThe
		End Get
		Set(ByVal Value As Integer)
			_idThucThe = Value
		End Set
	End Property
	Public Property TenBien() As String
		Get
			Return _tenBien
		End Get
		Set(ByVal Value As String)
			_tenBien = Value
		End Set
	End Property
	Public Property KeyBien() As String
		Get
			Return _keyBien
		End Get
		Set(ByVal Value As String)
			_keyBien = Value
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
	Public Property TenThucThe() As String
		Get
			Return _tenThucThe
		End Get
		Set(ByVal Value As String)
			_tenThucThe = Value
		End Set
	End Property
#End Region

End Class
Public Class BoBienInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBien As String = String.Empty
	Private _tenBoBien As String = String.Empty
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

	Public Property IdBien() As String
		Get
			Return _idBien
		End Get
		Set(ByVal Value As String)
			_idBien = Value
		End Set
	End Property
	Public Property TenBoBien() As String
		Get
			Return _tenBoBien
		End Get
		Set(ByVal Value As String)
			_tenBoBien = Value
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
Public Class CaiDatBaoMatInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _idAdress As String = String.Empty
	Private _note As String = String.Empty
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

	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property
	Public Property IdAdress() As String
		Get
			Return _idAdress
		End Get
		Set(ByVal Value As String)
			_idAdress = Value
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
Public Class CauMauInfo

#Region "Private Members"
	Private _id As Integer
	Private _idThucThe As Integer
	Private _tenCauMau As String = String.Empty
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
	Private _tenThucThe As String = String.Empty
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

	Public Property IdThucThe() As Integer
		Get
			Return _idThucThe
		End Get
		Set(ByVal Value As Integer)
			_idThucThe = Value
		End Set
	End Property
	Public Property TenCauMau() As String
		Get
			Return _tenCauMau
		End Get
		Set(ByVal Value As String)
			_tenCauMau = Value
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
	Public Property TenThucThe() As String
		Get
			Return _tenThucThe
		End Get
		Set(ByVal Value As String)
			_tenThucThe = Value
		End Set
	End Property
#End Region

End Class
Public Class KichBanInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _idNhomKichBan As Integer
	Private _idNhomTuKhoa As Integer
	Private _idYDinh As Integer
	Private _tenKichBan As String = String.Empty
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
	Private _tenNhom As String
	Private _tenYDinh As String
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

	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property

	Public Property IdNhomKichBan() As Integer
		Get
			Return _idNhomKichBan
		End Get
		Set(ByVal Value As Integer)
			_idNhomKichBan = Value
		End Set
	End Property
	Public Property IdNhomTuKhoa() As Integer
		Get
			Return _idNhomTuKhoa
		End Get
		Set(ByVal Value As Integer)
			_idNhomTuKhoa = Value
		End Set
	End Property
	Public Property IdYDinh() As Integer
		Get
			Return _idYDinh
		End Get
		Set(ByVal Value As Integer)
			_idYDinh = Value
		End Set
	End Property
	Public Property TenKichBan() As String
		Get
			Return _tenKichBan
		End Get
		Set(ByVal Value As String)
			_tenKichBan = Value
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
	Public Property TenNhom() As String
		Get
			Return _tenNhom
		End Get
		Set(ByVal Value As String)
			_tenNhom = Value
		End Set
	End Property
	Public Property TenYDinh() As String
		Get
			Return _tenYDinh
		End Get
		Set(ByVal Value As String)
			_tenYDinh = Value
		End Set
	End Property
#End Region

End Class
Public Class MauEmailInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBoBien As Integer
	Private _tenMauEmail As String = String.Empty
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

	Public Property IdBoBien() As Integer
		Get
			Return _idBoBien
		End Get
		Set(ByVal Value As Integer)
			_idBoBien = Value
		End Set
	End Property

	Public Property TenMauEmail() As String
		Get
			Return _tenMauEmail
		End Get
		Set(ByVal Value As String)
			_tenMauEmail = Value
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
Public Class NhomKichBanInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _tenNhomKichBan As String = String.Empty
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property
	Public Property TenNhomKichBan() As String
		Get
			Return _tenNhomKichBan
		End Get
		Set(ByVal Value As String)
			_tenNhomKichBan = Value
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
Public Class NhomTuKhoaInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _tenNhom As String = String.Empty
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property
	Public Property TenNhom() As String
		Get
			Return _tenNhom
		End Get
		Set(ByVal Value As String)
			_tenNhom = Value
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
Public Class TapTinInfo

#Region "Private Members"
	Private _id As Integer
	Private _idThuMuc As Integer
	Private _tenTapTin As String = String.Empty
	Private _url As String = String.Empty
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

	Public Property IdThuMuc() As Integer
		Get
			Return _idThuMuc
		End Get
		Set(ByVal Value As Integer)
			_idThuMuc = Value
		End Set
	End Property
	Public Property TenTapTin() As String
		Get
			Return _tenTapTin
		End Get
		Set(ByVal Value As String)
			_tenTapTin = Value
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
Public Class ThucTheInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenThucThe As String = String.Empty
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
	Private _color As String = String.Empty
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

	Public Property TenThucThe() As String
		Get
			Return _tenThucThe
		End Get
		Set(ByVal Value As String)
			_tenThucThe = Value
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
	Public Property Color() As String
		Get
			Return _color
		End Get
		Set(ByVal Value As String)
			_color = Value
		End Set
	End Property
#End Region

End Class
Public Class ThuMucInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenThuMuc As String = String.Empty
	Private _url As String = String.Empty
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

	Public Property TenThuMuc() As String
		Get
			Return _tenThuMuc
		End Get
		Set(ByVal Value As String)
			_tenThuMuc = Value
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
Public Class TinNhanInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _idKichBan As Integer
	Private _idKichBanLienKet As Integer
	Private _idNhomTuKhoa As String = String.Empty
	Private _idBoBien As Integer
	Private _idBien As Integer
	Private _tenTinNhan As String = String.Empty
	Private _noiDung As String = String.Empty
	Private _hinhAnh As String = String.Empty
	Private _url As String = String.Empty
	Private _viTri As String = String.Empty
	Private _thoiGian As DateTime
	Private _thoiGianString As String = String.Empty
	Private _tapTin As String = String.Empty
	Private _kieuHienThi As Short
	Private _phanLoai As Short
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
	Private _tenPhanLoai As String = String.Empty
	Private _noiDungButton As String = String.Empty
	Private _noiDungSlide As String = String.Empty
	Private _tenKichBan As String = String.Empty
	Private _isDanhMay As Boolean
	Private _idAPI As Integer
	Private _isCall As Boolean
	Private _kieuTapTin As String = String.Empty
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property

	Public Property IdKichBan() As Integer
		Get
			Return _idKichBan
		End Get
		Set(ByVal Value As Integer)
			_idKichBan = Value
		End Set
	End Property
	Public Property IdKichBanLienKet() As Integer
		Get
			Return _idKichBanLienKet
		End Get
		Set(ByVal Value As Integer)
			_idKichBanLienKet = Value
		End Set
	End Property
	Public Property IdNhomTuKhoa() As String
		Get
			Return _idNhomTuKhoa
		End Get
		Set(ByVal Value As String)
			_idNhomTuKhoa = Value
		End Set
	End Property
	Public Property IdBoBien() As Integer
		Get
			Return _idBoBien
		End Get
		Set(ByVal Value As Integer)
			_idBoBien = Value
		End Set
	End Property
	Public Property IdBien() As Integer
		Get
			Return _idBien
		End Get
		Set(ByVal Value As Integer)
			_idBien = Value
		End Set
	End Property
	Public Property TenTinNhan() As String
		Get
			Return _tenTinNhan
		End Get
		Set(ByVal Value As String)
			_tenTinNhan = Value
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
	Public Property HinhAnh() As String
		Get
			Return _hinhAnh
		End Get
		Set(ByVal Value As String)
			_hinhAnh = Value
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
	Public Property ViTri() As String
		Get
			Return _viTri
		End Get
		Set(ByVal Value As String)
			_viTri = Value
		End Set
	End Property
	Public Property ThoiGian() As DateTime
		Get
			Return _thoiGian
		End Get
		Set(ByVal Value As DateTime)
			_thoiGian = Value
		End Set
	End Property
	Public Property ThoiGianString() As String
		Get
			Return _thoiGianString
		End Get
		Set(ByVal Value As String)
			_thoiGianString = Value
		End Set
	End Property
	Public Property TapTin() As String
		Get
			Return _tapTin
		End Get
		Set(ByVal Value As String)
			_tapTin = Value
		End Set
	End Property
	Public Property KieuHienThi() As Short
		Get
			Return _kieuHienThi
		End Get
		Set(ByVal Value As Short)
			_kieuHienThi = Value
		End Set
	End Property
	Public Property PhanLoai() As Short
		Get
			Return _phanLoai
		End Get
		Set(ByVal Value As Short)
			_phanLoai = Value
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
	Public Property TenPhanLoai() As String
		Get
			Return _tenPhanLoai
		End Get
		Set(ByVal Value As String)
			_tenPhanLoai = Value
		End Set
	End Property
	Public Property NoiDungButton() As String
		Get
			Return _noiDungButton
		End Get
		Set(ByVal Value As String)
			_noiDungButton = Value
		End Set
	End Property
	Public Property NoiDungSlide() As String
		Get
			Return _noiDungSlide
		End Get
		Set(ByVal Value As String)
			_noiDungSlide = Value
		End Set
	End Property
	Public Property TenKichBan() As String
		Get
			Return _tenKichBan
		End Get
		Set(ByVal Value As String)
			_tenKichBan = Value
		End Set
	End Property
	Public Property IsDanhMay() As Boolean
		Get
			Return _isDanhMay
		End Get
		Set(ByVal Value As Boolean)
			_isDanhMay = Value
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
	Public Property IsCall() As Boolean
		Get
			Return _isCall
		End Get
		Set(ByVal Value As Boolean)
			_isCall = Value
		End Set
	End Property
	Public Property KieuTapTin() As String
		Get
			Return _kieuTapTin
		End Get
		Set(ByVal Value As String)
			_kieuTapTin = Value
		End Set
	End Property
#End Region

End Class
Public Class TuDongNghiaInfo

#Region "Private Members"
	Private _id As Integer
	Private _idThucThe As Integer
	Private _tenTuDongNghia As String = String.Empty
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

	Public Property IdThucThe() As Integer
		Get
			Return _idThucThe
		End Get
		Set(ByVal Value As Integer)
			_idThucThe = Value
		End Set
	End Property

	Public Property TenTuDongNghia() As String
		Get
			Return _tenTuDongNghia
		End Get
		Set(ByVal Value As String)
			_tenTuDongNghia = Value
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
Public Class TuKhoaInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _idNhomTuKhoa As Integer
	Private _tenTuKhoa As String = String.Empty
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property
	Public Property IdNhomTuKhoa() As Integer
		Get
			Return _idNhomTuKhoa
		End Get
		Set(ByVal Value As Integer)
			_idNhomTuKhoa = Value
		End Set
	End Property
	Public Property TenTuKhoa() As String
		Get
			Return _tenTuKhoa
		End Get
		Set(ByVal Value As String)
			_tenTuKhoa = Value
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
Public Class YDinhInfo

#Region "Private Members"
	Private _id As Integer
	Private _tenYDinh As String = String.Empty
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

	Public Property TenYDinh() As String
		Get
			Return _tenYDinh
		End Get
		Set(ByVal Value As String)
			_tenYDinh = Value
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
Public Class TinNhanSubInfo

#Region "Private Members"
	Private _id As Integer
	Private _idTinNhan As Integer
	Private _idKichBan As Integer
	Private _tenTinNhanSub As String = String.Empty
	Private _url As String = String.Empty
	Private _logo As String = String.Empty
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
	Private _idYDinh As Integer
	Private _idTuKhoa As Integer
	Private _phanLoai As Short
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

	Public Property IdTinNhan() As Integer
		Get
			Return _idTinNhan
		End Get
		Set(ByVal Value As Integer)
			_idTinNhan = Value
		End Set
	End Property
	Public Property IdKichBan() As Integer
		Get
			Return _idKichBan
		End Get
		Set(ByVal Value As Integer)
			_idKichBan = Value
		End Set
	End Property
	Public Property TenTinNhanSub() As String
		Get
			Return _tenTinNhanSub
		End Get
		Set(ByVal Value As String)
			_tenTinNhanSub = Value
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
	Public Property Logo() As String
		Get
			Return _logo
		End Get
		Set(ByVal Value As String)
			_logo = Value
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
	Public Property IdYDinh() As Integer
		Get
			Return _idYDinh
		End Get
		Set(ByVal Value As Integer)
			_idYDinh = Value
		End Set
	End Property
	Public Property IdTuKhoa() As Integer
		Get
			Return _idTuKhoa
		End Get
		Set(ByVal Value As Integer)
			_idTuKhoa = Value
		End Set
	End Property
	Public Property PhanLoai() As Short
		Get
			Return _phanLoai
		End Get
		Set(ByVal Value As Short)
			_phanLoai = Value
		End Set
	End Property
#End Region

End Class
Public Class EmailInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBoBien As Integer
	Private _idMauEmail As Integer
	Private _tenEmail As String = String.Empty
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

	Public Property IdBoBien() As Integer
		Get
			Return _idBoBien
		End Get
		Set(ByVal Value As Integer)
			_idBoBien = Value
		End Set
	End Property
	Public Property IdMauEmail() As Integer
		Get
			Return _idMauEmail
		End Get
		Set(ByVal Value As Integer)
			_idMauEmail = Value
		End Set
	End Property
	Public Property TenEmail() As String
		Get
			Return _tenEmail
		End Get
		Set(ByVal Value As String)
			_tenEmail = Value
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

Public Class DaoTaoInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _tenTuKhoa As String = String.Empty
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
	Private _rowNum As Integer
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

	Public Property RowNum As Integer
		Get
			Return _rowNum
		End Get
		Set(ByVal Value As Integer)
			_rowNum = Value
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property

	Public Property TenTuKhoa() As String
		Get
			Return _tenTuKhoa
		End Get
		Set(ByVal Value As String)
			_tenTuKhoa = Value
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

Public Class APIInfo

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
#End Region

End Class

Public Class APIHeaderInfo

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
#End Region

End Class

Public Class HoiThoaiInfo

#Region "Private Members"
	Private _id As Integer
	Private _idBot As Integer
	Private _tenHoiThoai As String = String.Empty
	Private _ydinh As String = String.Empty
	Private _danhDauSao As Short
	Private _trangThai As Short
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
	Public Property IdBot() As Integer
		Get
			Return _idBot
		End Get
		Set(ByVal Value As Integer)
			_idBot = Value
		End Set
	End Property

	Public Property TenHoiThoai() As String
		Get
			Return _tenHoiThoai
		End Get
		Set(ByVal Value As String)
			_tenHoiThoai = Value
		End Set
	End Property
	Public Property Ydinh() As String
		Get
			Return _ydinh
		End Get
		Set(ByVal Value As String)
			_ydinh = Value
		End Set
	End Property
	Public Property DanhDauSao() As Short
		Get
			Return _danhDauSao
		End Get
		Set(ByVal Value As Short)
			_danhDauSao = Value
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

Public Class TinHoiThoaiInfo

#Region "Private Members"
	Private _id As Integer
	Private _idHoiThoai As Integer
	Private _noiDungHTML As String = String.Empty
	Private _noiDungText As String = String.Empty
	Private _type As Short
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

	Public Property IdHoiThoai() As Integer
		Get
			Return _idHoiThoai
		End Get
		Set(ByVal Value As Integer)
			_idHoiThoai = Value
		End Set
	End Property
	Public Property NoiDungHTML() As String
		Get
			Return _noiDungHTML
		End Get
		Set(ByVal Value As String)
			_noiDungHTML = Value
		End Set
	End Property
	Public Property NoiDungText() As String
		Get
			Return _noiDungText
		End Get
		Set(ByVal Value As String)
			_noiDungText = Value
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

Public Class CHATBOT_DashInfo
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

Public Class APISyncInfo

#Region "Private Members"
	Private _id As Integer
	Private _idAPI As Integer
	Private _tenAPISync As String = String.Empty
	Private _kieuDongBo As Short
	Private _thoiGian As Short
	Private _ngayBatDau As DateTime
	Private _ngayKetThuc As DateTime
	Private _lichSu As String = String.Empty
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
	Public Property TenAPISync() As String
		Get
			Return _tenAPISync
		End Get
		Set(ByVal Value As String)
			_tenAPISync = Value
		End Set
	End Property
	Public Property KieuDongBo() As Short
		Get
			Return _kieuDongBo
		End Get
		Set(ByVal Value As Short)
			_kieuDongBo = Value
		End Set
	End Property
	Public Property ThoiGian() As Short
		Get
			Return _thoiGian
		End Get
		Set(ByVal Value As Short)
			_thoiGian = Value
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
	Public Property NgayKetThuc() As DateTime
		Get
			Return _ngayKetThuc
		End Get
		Set(ByVal Value As DateTime)
			_ngayKetThuc = Value
		End Set
	End Property
	Public Property LichSu() As String
		Get
			Return _lichSu
		End Get
		Set(ByVal Value As String)
			_lichSu = Value
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












