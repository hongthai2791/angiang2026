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
    Private _isActive As Boolean
#End Region

#Region "Public Properties"
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
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
Public Class CMS_YearsInfo

#Region "Private Members"
    Private _years_ID As Integer
    Private _years_Name As Integer
    Private _years_Des As String = String.Empty
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

    Public Property Years_ID As Integer
        Get
            Return _years_ID
        End Get
        Set(ByVal Value As Integer)
            _years_ID = Value
        End Set
    End Property

    Public Property Years_Name As Integer
        Get
            Return _years_Name
        End Get
        Set(ByVal Value As Integer)
            _years_Name = Value
        End Set
    End Property
    Public Property Years_Des As String
        Get
            Return _years_Des
        End Get
        Set(ByVal Value As String)
            _years_Des = Value
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
Public Class CMS_DataInfo

#Region "Private Members"
    Private _data_ID As Integer
    Private _report_ID As Integer
    Private _targets_ID As Integer
    Private _targets_Code As String = String.Empty
    Private _unit_ID As Integer
    Private _giaTri As Double
    Private _isDes As String = String.Empty
    Private _isCenter As Boolean
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

    Public Property Data_ID As Integer
        Get
            Return _data_ID
        End Get
        Set(ByVal Value As Integer)
            _data_ID = Value
        End Set
    End Property

    Public Property Report_ID As Integer
        Get
            Return _report_ID
        End Get
        Set(ByVal Value As Integer)
            _report_ID = Value
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
    Public Property Targets_Code As String
        Get
            Return _targets_Code
        End Get
        Set(ByVal Value As String)
            _targets_Code = Value
        End Set
    End Property
    Public Property Unit_ID As Integer
        Get
            Return _unit_ID
        End Get
        Set(ByVal Value As Integer)
            _unit_ID = Value
        End Set
    End Property
    Public Property GiaTri As Double
        Get
            Return _giaTri
        End Get
        Set(ByVal Value As Double)
            _giaTri = Value
        End Set
    End Property
    Public Property IsDes As String
        Get
            Return _isDes
        End Get
        Set(ByVal Value As String)
            _isDes = Value
        End Set
    End Property
    Public Property IsCenter As Boolean
        Get
            Return _isCenter
        End Get
        Set(ByVal Value As Boolean)
            _isCenter = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ReportInfo

#Region "Private Members"
    Private _report_ID As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _phuongXa As Integer
    Private _aSXH_ID As Integer
    Private _group_ID As Integer
    Private _temp_ID As Integer
    Private _level_ID As Integer
    Private _unit_ID As Integer
    Private _period_ID As Integer
    Private _years_ID As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isSend As Boolean
    Private _sendDate As DateTime
    Private _sendUser As String = String.Empty
    Private _total As Integer
    Private _Temp_Name As String = String.Empty
    Private _lydoTraLai As String = String.Empty
    Private _ngayTraLai As DateTime
    Private _nguoiTraLai As String = String.Empty
#End Region

#Region "Public Properties"
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
    Public Property NgayTraLai As DateTime
        Get
            Return _ngayTraLai
        End Get
        Set(ByVal Value As DateTime)
            _ngayTraLai = Value
        End Set
    End Property
    Public Property NguoiTraLai As String
        Get
            Return _nguoiTraLai
        End Get
        Set(ByVal Value As String)
            _nguoiTraLai = Value
        End Set
    End Property
    Public Property LyDoTraLai As String
        Get
            Return _lydoTraLai
        End Get
        Set(ByVal Value As String)
            _lydoTraLai = Value
        End Set
    End Property

    Public Property Temp_Name As String
        Get
            Return _Temp_Name
        End Get
        Set(ByVal Value As String)
            _Temp_Name = Value
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
    Public Property Report_ID As Integer
        Get
            Return _report_ID
        End Get
        Set(ByVal Value As Integer)
            _report_ID = Value
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
    Public Property ASXH_ID As Integer
        Get
            Return _aSXH_ID
        End Get
        Set(ByVal Value As Integer)
            _aSXH_ID = Value
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
    Public Property Temp_ID As Integer
        Get
            Return _temp_ID
        End Get
        Set(ByVal Value As Integer)
            _temp_ID = Value
        End Set
    End Property
    Public Property Level_ID As Integer
        Get
            Return _level_ID
        End Get
        Set(ByVal Value As Integer)
            _level_ID = Value
        End Set
    End Property
    Public Property Unit_ID As Integer
        Get
            Return _unit_ID
        End Get
        Set(ByVal Value As Integer)
            _unit_ID = Value
        End Set
    End Property
    Public Property Period_ID As Integer
        Get
            Return _period_ID
        End Get
        Set(ByVal Value As Integer)
            _period_ID = Value
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
    Public Property IsSend As Boolean
        Get
            Return _isSend
        End Get
        Set(ByVal Value As Boolean)
            _isSend = Value
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
    Public Property SendUser As String
        Get
            Return _sendUser
        End Get
        Set(ByVal Value As String)
            _sendUser = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_AnalyticInfo

#Region "Private Members"
    Private _analtyic_ID As String = String.Empty
    Private _targets_ID As Integer
    Private _valueFrom As Double
    Private _valueTo As Double
    Private _contents As String = String.Empty
    Private _solution As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _isFlag As Integer
#End Region

#Region "Public Properties"

    Public Property Solution() As String
        Get
            Return _solution
        End Get
        Set(ByVal Value As String)
            _solution = Value
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


    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

    Public Property Analtyic_ID() As String
        Get
            Return _analtyic_ID
        End Get
        Set(ByVal Value As String)
            _analtyic_ID = Value
        End Set
    End Property

    Public Property Targets_ID() As Integer
        Get
            Return _targets_ID
        End Get
        Set(ByVal Value As Integer)
            _targets_ID = Value
        End Set
    End Property
    Public Property ValueFrom() As Double
        Get
            Return _valueFrom
        End Get
        Set(ByVal Value As Double)
            _valueFrom = Value
        End Set
    End Property
    Public Property ValueTo() As Double
        Get
            Return _valueTo
        End Get
        Set(ByVal Value As Double)
            _valueTo = Value
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
Public Class CMS_UnitTypeInfo

#Region "Private Members"
    Private _unitType_ID As Integer
    Private _unitType_Code As String = String.Empty
    Private _unitType_Name As String = String.Empty
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

    Public Property UnitType_ID As Integer
        Get
            Return _unitType_ID
        End Get
        Set(ByVal Value As Integer)
            _unitType_ID = Value
        End Set
    End Property

    Public Property UnitType_Code As String
        Get
            Return _unitType_Code
        End Get
        Set(ByVal Value As String)
            _unitType_Code = Value
        End Set
    End Property
    Public Property UnitType_Name As String
        Get
            Return _unitType_Name
        End Get
        Set(ByVal Value As String)
            _unitType_Name = Value
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
#End Region

End Class
Public Class CMS_DashBoardInfo

#Region "Private Members"
    Private _TongSoChiTieu As Integer
    Private _TongSoBaoCaoTinh As Integer
    Private _TongSoBaoCaoDVi As Integer
    Private _TongSoDonVi As Integer
#End Region

#Region "Public Properties"

    Public Property TongSoChiTieu As Integer
        Get
            Return _TongSoChiTieu
        End Get
        Set(ByVal Value As Integer)
            _TongSoChiTieu = Value
        End Set
    End Property

    Public Property TongSoBaoCaoTinh As Integer
        Get
            Return _TongSoBaoCaoTinh
        End Get
        Set(ByVal Value As Integer)
            _TongSoBaoCaoTinh = Value
        End Set
    End Property
    Public Property TongSoBaoCaoDvi As Integer
        Get
            Return _TongSoBaoCaoDVi
        End Get
        Set(ByVal Value As Integer)
            _TongSoBaoCaoDVi = Value
        End Set
    End Property

    Public Property TongSoDonVi As Integer
        Get
            Return _TongSoDonVi
        End Get
        Set(ByVal Value As Integer)
            _TongSoDonVi = Value
        End Set
    End Property

#End Region

End Class
Public Class DataAnalyInfo

#Region "Private Members"
    Private _STT As Double
    Private _YearID As Double
    Private _Data1 As Double
    Private _Data2 As Double
    Private _Data3 As Double
    Private _Data4 As Double
    Private _Data5 As Double
    Private _Data6 As Double
    Private _Data7 As Double
    Private _Data8 As Double
    Private _Data9 As Double
    Private _Data10 As Double
    Private _Data11 As Double
    Private _IsFlag As Integer
#End Region

#Region "Public Properties"
    Public Property Data11 As Double
        Get
            Return _Data11
        End Get
        Set(ByVal Value As Double)
            _Data11 = Value
        End Set
    End Property
    Public Property Data3 As Double
        Get
            Return _Data3
        End Get
        Set(ByVal Value As Double)
            _Data3 = Value
        End Set
    End Property
    Public Property Data4 As Double
        Get
            Return _Data4
        End Get
        Set(ByVal Value As Double)
            _Data4 = Value
        End Set
    End Property
    Public Property Data5 As Double
        Get
            Return _Data5
        End Get
        Set(ByVal Value As Double)
            _Data5 = Value
        End Set
    End Property
    Public Property Data6 As Double
        Get
            Return _Data6
        End Get
        Set(ByVal Value As Double)
            _Data6 = Value
        End Set
    End Property
    Public Property Data10 As Double
        Get
            Return _Data10
        End Get
        Set(ByVal Value As Double)
            _Data10 = Value
        End Set
    End Property
    Public Property Data9 As Double
        Get
            Return _Data9
        End Get
        Set(ByVal Value As Double)
            _Data9 = Value
        End Set
    End Property
    Public Property Data8 As Double
        Get
            Return _Data8
        End Get
        Set(ByVal Value As Double)
            _Data8 = Value
        End Set
    End Property
    Public Property Data7 As Double
        Get
            Return _Data7
        End Get
        Set(ByVal Value As Double)
            _Data7 = Value
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
    Public Property YearID As Double
        Get
            Return _YearID
        End Get
        Set(ByVal Value As Double)
            _YearID = Value
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
    Public Property Data1 As Double
        Get
            Return _Data1
        End Get
        Set(ByVal Value As Double)
            _Data1 = Value
        End Set
    End Property

    Public Property Data2 As Double
        Get
            Return _Data2
        End Get
        Set(ByVal Value As Double)
            _Data2 = Value
        End Set
    End Property
#End Region
End Class
Public Class CMS_SceneInfo

#Region "Private Members"
    Private _scene_ID As String
    Private _yearID As Integer
    Private _data As Double
    Private _tinhTP As Integer
    Private _total As Integer
    Private _TypeScene As Integer

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

    Public Property Scene_ID() As String
        Get
            Return _scene_ID
        End Get
        Set(ByVal Value As String)
            _scene_ID = Value
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
    Public Property Data() As Double
        Get
            Return _data
        End Get
        Set(ByVal Value As Double)
            _data = Value
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
    Public Property TypeScene() As Integer
        Get
            Return _TypeScene
        End Get
        Set(ByVal Value As Integer)
            _TypeScene = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ReportSaveInfo

#Region "Private Members"
    Private _report_ID As Integer
    Private _tinhTP As Integer
    Private _group_ID As Integer
    Private _years_ID As Integer
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
    Public Property Report_ID As Integer
        Get
            Return _report_ID
        End Get
        Set(ByVal Value As Integer)
            _report_ID = Value
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
    Public Property Group_ID As Integer
        Get
            Return _group_ID
        End Get
        Set(ByVal Value As Integer)
            _group_ID = Value
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
Public Class CMS_DataSaveInfo

#Region "Private Members"
    Private _data_ID As Integer
    Private _report_ID As Integer
    Private _tinhTP As Integer
    Private _groupID As Integer
    Private _yearID As Integer
    Private _targets_ID As Integer
    Private _targets_Code As String = String.Empty
    Private _giaTri As Double
    Private _giaTri2 As Double
    Private _giaTri3 As Double
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
    Public Property TinhTP As Integer
        Get
            Return _tinhTP
        End Get
        Set(ByVal Value As Integer)
            _tinhTP = Value
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
    Public Property YearID As Integer
        Get
            Return _yearID
        End Get
        Set(ByVal Value As Integer)
            _yearID = Value
        End Set
    End Property

    Public Property Data_ID As Integer
        Get
            Return _data_ID
        End Get
        Set(ByVal Value As Integer)
            _data_ID = Value
        End Set
    End Property

    Public Property Report_ID As Integer
        Get
            Return _report_ID
        End Get
        Set(ByVal Value As Integer)
            _report_ID = Value
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
    Public Property Targets_Code As String
        Get
            Return _targets_Code
        End Get
        Set(ByVal Value As String)
            _targets_Code = Value
        End Set
    End Property
    Public Property GiaTri As Double
        Get
            Return _giaTri
        End Get
        Set(ByVal Value As Double)
            _giaTri = Value
        End Set
    End Property
    Public Property GiaTri2 As Double
        Get
            Return _giaTri2
        End Get
        Set(ByVal Value As Double)
            _giaTri2 = Value
        End Set
    End Property
    Public Property GiaTri3 As Double
        Get
            Return _giaTri3
        End Get
        Set(ByVal Value As Double)
            _giaTri3 = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_FileAttachInfo

#Region "Private Members"
    Private _attch_ID As String = String.Empty
    Private _iDKey As String = String.Empty
    Private _fileAttch_Name As String = String.Empty
    Private _fileAttch_Attch As String = String.Empty
    Private _fileAttch_Des As String = String.Empty
    Private _portalID As Integer
    Private _isOrder As Integer
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

    Public Property Attch_ID() As String
        Get
            Return _attch_ID
        End Get
        Set(ByVal Value As String)
            _attch_ID = Value
        End Set
    End Property

    Public Property IDKey() As String
        Get
            Return _iDKey
        End Get
        Set(ByVal Value As String)
            _iDKey = Value
        End Set
    End Property
    Public Property FileAttch_Name() As String
        Get
            Return _fileAttch_Name
        End Get
        Set(ByVal Value As String)
            _fileAttch_Name = Value
        End Set
    End Property
    Public Property FileAttch_Attch() As String
        Get
            Return _fileAttch_Attch
        End Get
        Set(ByVal Value As String)
            _fileAttch_Attch = Value
        End Set
    End Property
    Public Property FileAttch_Des() As String
        Get
            Return _fileAttch_Des
        End Get
        Set(ByVal Value As String)
            _fileAttch_Des = Value
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
#End Region

End Class
Public Class CMS_MagazineInfo

#Region "Private Members"
    Private _magazine_ID As Integer
    Private _magazine_Name As String = String.Empty
    Private _magazine_Des As String = String.Empty
    Private _magazine_Type As Integer
    Private _magazine_Img As String = String.Empty
    Private _magazine_FileName As String = String.Empty
    Private _magazine_FileAtt As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _isOrder As Integer
    Private _isActive As Boolean
    Private _groupID As String
    Private _YearID As Integer
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
    Public Property GroupID As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
        End Set
    End Property
    Public Property YearID As Integer
        Get
            Return _YearID
        End Get
        Set(ByVal Value As Integer)
            _YearID = Value
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

    Public Property Magazine_ID() As Integer
        Get
            Return _magazine_ID
        End Get
        Set(ByVal Value As Integer)
            _magazine_ID = Value
        End Set
    End Property

    Public Property Magazine_Name() As String
        Get
            Return _magazine_Name
        End Get
        Set(ByVal Value As String)
            _magazine_Name = Value
        End Set
    End Property
    Public Property Magazine_Des() As String
        Get
            Return _magazine_Des
        End Get
        Set(ByVal Value As String)
            _magazine_Des = Value
        End Set
    End Property
    Public Property Magazine_Type() As Integer
        Get
            Return _magazine_Type
        End Get
        Set(ByVal Value As Integer)
            _magazine_Type = Value
        End Set
    End Property
    Public Property Magazine_Img() As String
        Get
            Return _magazine_Img
        End Get
        Set(ByVal Value As String)
            _magazine_Img = Value
        End Set
    End Property
    Public Property Magazine_FileName() As String
        Get
            Return _magazine_FileName
        End Get
        Set(ByVal Value As String)
            _magazine_FileName = Value
        End Set
    End Property
    Public Property Magazine_FileAtt() As String
        Get
            Return _magazine_FileAtt
        End Get
        Set(ByVal Value As String)
            _magazine_FileAtt = Value
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
Public Class CMS_MagazineDataInfo

#Region "Private Members"
    Private _magazineData_ID As Integer
    Private _magazine_ID As Integer
    Private _groupID As Integer
    Private _targetID As Integer
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

    Public Property MagazineData_ID() As Integer
        Get
            Return _magazineData_ID
        End Get
        Set(ByVal Value As Integer)
            _magazineData_ID = Value
        End Set
    End Property

    Public Property Magazine_ID() As Integer
        Get
            Return _magazine_ID
        End Get
        Set(ByVal Value As Integer)
            _magazine_ID = Value
        End Set
    End Property
    Public Property GroupID() As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
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
Public Class CMS_TypeSceneInfo

#Region "Private Members"
    Private _typeScene_ID As Integer
    Private _typeScene_Name As String = String.Empty
    Private _typeScene_Des As String = String.Empty
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

    Public Property TypeScene_ID() As Integer
        Get
            Return _typeScene_ID
        End Get
        Set(ByVal Value As Integer)
            _typeScene_ID = Value
        End Set
    End Property

    Public Property TypeScene_Name() As String
        Get
            Return _typeScene_Name
        End Get
        Set(ByVal Value As String)
            _typeScene_Name = Value
        End Set
    End Property
    Public Property TypeScene_Des() As String
        Get
            Return _typeScene_Des
        End Get
        Set(ByVal Value As String)
            _typeScene_Des = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_ConfigInfo

#Region "Private Members"
    Private _config_ID As String = String.Empty
    Private _tinhTP As Integer
    Private _config_Name As String = String.Empty
    Private _config_Value As String = String.Empty
    Private _notes As String = String.Empty
    Private _isActive As Boolean
    Private _isLock As Boolean
    Private _isFlag As Integer
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _portalId As Integer
    Private _total As Integer
    Private _Popula As Integer
    Private _LogoDv As String = String.Empty
    Private _Year1 As Integer
    Private _Year2 As Integer
    Private _txtSoNam As Integer
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

    Public Property Config_ID() As String
        Get
            Return _config_ID
        End Get
        Set(ByVal Value As String)
            _config_ID = Value
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
    Public Property Config_Name() As String
        Get
            Return _config_Name
        End Get
        Set(ByVal Value As String)
            _config_Name = Value
        End Set
    End Property
    Public Property Config_Value() As String
        Get
            Return _config_Value
        End Get
        Set(ByVal Value As String)
            _config_Value = Value
        End Set
    End Property
    Public Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal Value As String)
            _notes = Value
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
    Public Property Popula() As Integer
        Get
            Return _Popula
        End Get
        Set(ByVal Value As Integer)
            _Popula = Value
        End Set
    End Property
    Public Property LogoDv() As String
        Get
            Return _LogoDv
        End Get
        Set(ByVal Value As String)
            _LogoDv = Value
        End Set
    End Property
    Public Property Year1 As Integer
        Get
            Return _Year1
        End Get
        Set(ByVal Value As Integer)
            _Year1 = Value
        End Set
    End Property
    Public Property Year2 As Integer
        Get
            Return _Year2
        End Get
        Set(ByVal Value As Integer)
            _Year2 = Value
        End Set
    End Property
    Public Property txtSoNam As Integer
        Get
            Return _txtSoNam
        End Get
        Set(ByVal Value As Integer)
            _txtSoNam = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_RegTarInfo

#Region "Private Members"
    Private _regTar_ID As String = String.Empty
    Private _targets_ID As Integer
    Private _tinhTP As Integer
    Private _quanHuyen As Integer
    Private _phuongXa As Integer
    Private _targets_Code As String = String.Empty
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
    Public Property RegTar_ID As String
        Get
            Return _regTar_ID
        End Get
        Set(ByVal Value As String)
            _regTar_ID = Value
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
    Public Property PhuongXa As Integer
        Get
            Return _phuongXa
        End Get
        Set(ByVal Value As Integer)
            _phuongXa = Value
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
#End Region

End Class
Public Class CMS_InDataRowInfo

#Region "Private Members"
    Private _dataRow_ID As String = String.Empty
    Private _inputRpt_ID As Integer
    Private _inputRptC_ID As String = String.Empty
    Private _noiDung As String = String.Empty
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

    Public Property DataRow_ID() As String
        Get
            Return _dataRow_ID
        End Get
        Set(ByVal Value As String)
            _dataRow_ID = Value
        End Set
    End Property

    Public Property InputRpt_ID() As Integer
        Get
            Return _inputRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _inputRpt_ID = Value
        End Set
    End Property
    Public Property InputRptC_ID() As String
        Get
            Return _inputRptC_ID
        End Get
        Set(ByVal Value As String)
            _inputRptC_ID = Value
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
Public Class CMS_InDataRowCInfo

#Region "Private Members"
    Private _dataRowC_ID As Integer
    Private _dataRow_ID As String = String.Empty
    Private _inputRpt_ID As Integer
    Private _inputRptC_ID As String = String.Empty
    Private _targets_ID As Integer
    Private _colType As Integer
    Private _giaTri_Text As String = String.Empty
    Private _giaTri_So As Double
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

    Public Property DataRowC_ID() As Integer
        Get
            Return _dataRowC_ID
        End Get
        Set(ByVal Value As Integer)
            _dataRowC_ID = Value
        End Set
    End Property

    Public Property DataRow_ID() As String
        Get
            Return _dataRow_ID
        End Get
        Set(ByVal Value As String)
            _dataRow_ID = Value
        End Set
    End Property
    Public Property InputRpt_ID() As Integer
        Get
            Return _inputRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _inputRpt_ID = Value
        End Set
    End Property
    Public Property InputRptC_ID() As String
        Get
            Return _inputRptC_ID
        End Get
        Set(ByVal Value As String)
            _inputRptC_ID = Value
        End Set
    End Property
    Public Property Targets_ID() As Integer
        Get
            Return _targets_ID
        End Get
        Set(ByVal Value As Integer)
            _targets_ID = Value
        End Set
    End Property
    Public Property ColType() As Integer
        Get
            Return _colType
        End Get
        Set(ByVal Value As Integer)
            _colType = Value
        End Set
    End Property
    Public Property GiaTri_Text() As String
        Get
            Return _giaTri_Text
        End Get
        Set(ByVal Value As String)
            _giaTri_Text = Value
        End Set
    End Property
    Public Property GiaTri_So() As Double
        Get
            Return _giaTri_So
        End Get
        Set(ByVal Value As Double)
            _giaTri_So = Value
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
Public Class CMS_InputRptInfo

#Region "Private Members"
    Private _inputRpt_ID As Integer
    Private _tempRpt_ID As Integer
    Private _tinhTP As Integer
    Private _group_ID As Integer
    Private _years_ID As Integer
    Private _temp_Name As String = String.Empty
    Private _temp_Des As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _trangThai As Integer
    Private _sendDate As DateTime
    Private _sendUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _returnDate As DateTime
    Private _returnUser As String = String.Empty
    Private _returnReason As String = String.Empty
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

    Public Property InputRpt_ID() As Integer
        Get
            Return _inputRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _inputRpt_ID = Value
        End Set
    End Property

    Public Property TempRpt_ID() As Integer
        Get
            Return _tempRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _tempRpt_ID = Value
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
    Public Property Group_ID() As Integer
        Get
            Return _group_ID
        End Get
        Set(ByVal Value As Integer)
            _group_ID = Value
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
    Public Property Temp_Name() As String
        Get
            Return _temp_Name
        End Get
        Set(ByVal Value As String)
            _temp_Name = Value
        End Set
    End Property
    Public Property Temp_Des() As String
        Get
            Return _temp_Des
        End Get
        Set(ByVal Value As String)
            _temp_Des = Value
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
    Public Property TrangThai() As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal Value As Integer)
            _trangThai = Value
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
    Public Property SendUser() As String
        Get
            Return _sendUser
        End Get
        Set(ByVal Value As String)
            _sendUser = Value
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
    Public Property ReturnDate() As DateTime
        Get
            Return _returnDate
        End Get
        Set(ByVal Value As DateTime)
            _returnDate = Value
        End Set
    End Property
    Public Property ReturnUser() As String
        Get
            Return _returnUser
        End Get
        Set(ByVal Value As String)
            _returnUser = Value
        End Set
    End Property
    Public Property ReturnReason() As String
        Get
            Return _returnReason
        End Get
        Set(ByVal Value As String)
            _returnReason = Value
        End Set
    End Property
#End Region

End Class
Public Class CMS_InputRptCInfo

#Region "Private Members"
    Private _inputRptC_ID As String = String.Empty
    Private _inputRpt_ID As Integer
    Private _targets_ID As Integer
    Private _column_Name As String = String.Empty
    Private _isOrder As Integer
    Private _colType As Integer
    Private _exColum As Integer
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

    Public Property InputRptC_ID() As String
        Get
            Return _inputRptC_ID
        End Get
        Set(ByVal Value As String)
            _inputRptC_ID = Value
        End Set
    End Property

    Public Property InputRpt_ID() As Integer
        Get
            Return _inputRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _inputRpt_ID = Value
        End Set
    End Property
    Public Property Targets_ID() As Integer
        Get
            Return _targets_ID
        End Get
        Set(ByVal Value As Integer)
            _targets_ID = Value
        End Set
    End Property
    Public Property Column_Name() As String
        Get
            Return _column_Name
        End Get
        Set(ByVal Value As String)
            _column_Name = Value
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
    Public Property ColType() As Integer
        Get
            Return _colType
        End Get
        Set(ByVal Value As Integer)
            _colType = Value
        End Set
    End Property
    Public Property ExColum() As Integer
        Get
            Return _exColum
        End Get
        Set(ByVal Value As Integer)
            _exColum = Value
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
Public Class CMS_TempRptInfo

#Region "Private Members"
    Private _tempRpt_ID As Integer
    Private _tinhTP As Integer
    Private _group_ID As Integer
    Private _years_ID As Integer
    Private _temp_Name As String = String.Empty
    Private _temp_Des As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _total As Integer
    Private _isOrder As Integer
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

    Public Property TempRpt_ID() As Integer
        Get
            Return _tempRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _tempRpt_ID = Value
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
    Public Property Group_ID() As Integer
        Get
            Return _group_ID
        End Get
        Set(ByVal Value As Integer)
            _group_ID = Value
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
    Public Property Temp_Name() As String
        Get
            Return _temp_Name
        End Get
        Set(ByVal Value As String)
            _temp_Name = Value
        End Set
    End Property
    Public Property Temp_Des() As String
        Get
            Return _temp_Des
        End Get
        Set(ByVal Value As String)
            _temp_Des = Value
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
Public Class CMS_TempRptCInfo

#Region "Private Members"
    Private _tempRptC_ID As String = String.Empty
    Private _tempRpt_ID As Integer
    Private _targets_ID As Integer
    Private _column_Name As String = String.Empty
    Private _isOrder As Integer
    Private _colType As Integer
    Private _exColum As Integer
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

    Public Property TempRptC_ID() As String
        Get
            Return _tempRptC_ID
        End Get
        Set(ByVal Value As String)
            _tempRptC_ID = Value
        End Set
    End Property

    Public Property TempRpt_ID() As Integer
        Get
            Return _tempRpt_ID
        End Get
        Set(ByVal Value As Integer)
            _tempRpt_ID = Value
        End Set
    End Property
    Public Property Targets_ID() As Integer
        Get
            Return _targets_ID
        End Get
        Set(ByVal Value As Integer)
            _targets_ID = Value
        End Set
    End Property
    Public Property Column_Name() As String
        Get
            Return _column_Name
        End Get
        Set(ByVal Value As String)
            _column_Name = Value
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
    Public Property ColType() As Integer
        Get
            Return _colType
        End Get
        Set(ByVal Value As Integer)
            _colType = Value
        End Set
    End Property
    Public Property ExColum() As Integer
        Get
            Return _exColum
        End Get
        Set(ByVal Value As Integer)
            _exColum = Value
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

Public Class CMS_CateTarInfo

#Region "Private Members"
    Private _iD As String
    Private _target_ID As Integer
    Private _codeCateTar As String = String.Empty
    Private _cateName As String = String.Empty
    Private _total As Integer
    Private _IsOrder As Integer
#End Region

#Region "Public Properties"

    Public Property IsOrder As Integer
        Get
            Return _IsOrder
        End Get
        Set(ByVal Value As Integer)
            _IsOrder = Value
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

    Public Property Target_ID() As Integer
        Get
            Return _target_ID
        End Get
        Set(ByVal Value As Integer)
            _target_ID = Value
        End Set
    End Property
    Public Property CodeCateTar() As String
        Get
            Return _codeCateTar
        End Get
        Set(ByVal Value As String)
            _codeCateTar = Value
        End Set
    End Property
    Public Property CateName() As String
        Get
            Return _cateName
        End Get
        Set(ByVal Value As String)
            _cateName = Value
        End Set
    End Property
#End Region

End Class

Public Class CMS_DataCaculatorInfo

#Region "Private Members"
    Private _dataCaculator_ID As Integer
    Private _tinhTP As Integer
    Private _groupID As Integer
    Private _yearID As Integer
    Private _targets_ID As Integer
    Private _targets_Code As String = String.Empty
    Private _unit_ID As Integer
    Private _giaTri As Double
    Private _giaTri2 As Double
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

    Public Property DataCaculator_ID() As Integer
        Get
            Return _dataCaculator_ID
        End Get
        Set(ByVal Value As Integer)
            _dataCaculator_ID = Value
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
    Public Property GroupID() As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
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
    Public Property Targets_ID() As Integer
        Get
            Return _targets_ID
        End Get
        Set(ByVal Value As Integer)
            _targets_ID = Value
        End Set
    End Property
    Public Property Targets_Code() As String
        Get
            Return _targets_Code
        End Get
        Set(ByVal Value As String)
            _targets_Code = Value
        End Set
    End Property
    Public Property Unit_ID() As Integer
        Get
            Return _unit_ID
        End Get
        Set(ByVal Value As Integer)
            _unit_ID = Value
        End Set
    End Property
    Public Property GiaTri() As Double
        Get
            Return _giaTri
        End Get
        Set(ByVal Value As Double)
            _giaTri = Value
        End Set
    End Property
    Public Property GiaTri2() As Double
        Get
            Return _giaTri2
        End Get
        Set(ByVal Value As Double)
            _giaTri2 = Value
        End Set
    End Property
#End Region

End Class

Public Class RPT_DataChartInfo

#Region "Private Members"
    Private _iD As Integer
    Private _cName As String = String.Empty
    Private _cValue As Double
    Private _cPercent As Double
    Private _tinhTP As Integer
    Private _groupID As Integer
    Private _targetID As Integer
    Private _codeCateTar As String = String.Empty
    Private _yearID As Integer
    Private _total As Integer
#End Region

#Region "Public Properties"

    Public Property CPercent As Double
        Get
            Return _cPercent
        End Get
        Set(ByVal Value As Double)
            _cPercent = Value
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

    Public Property CName() As String
        Get
            Return _cName
        End Get
        Set(ByVal Value As String)
            _cName = Value
        End Set
    End Property
    Public Property CValue() As Double
        Get
            Return _cValue
        End Get
        Set(ByVal Value As Double)
            _cValue = Value
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
    Public Property GroupID() As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
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
    Public Property CodeCateTar() As String
        Get
            Return _codeCateTar
        End Get
        Set(ByVal Value As String)
            _codeCateTar = Value
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
#End Region

End Class

Public Class RptCungInfo

#Region "Private Members"
    Public Property DS01 As Integer
    Public Property DS02 As Integer
    Public Property DS03 As Integer
    Public Property DS04 As Integer
    Public Property DS05 As Integer
    Public Property DS06 As Integer
    Public Property DS07 As Integer
    Public Property DS08 As Integer
    Public Property DS09 As Integer
    Public Property DS10 As Integer
    Public Property DS11 As Integer
    Public Property DS12 As Integer
    Public Property DS13 As Integer
    Public Property DS14 As Integer
    Public Property DS15 As Integer
    Public Property DS16 As Integer
    Public Property DS17 As Integer
    Public Property DS18 As Integer
    Public Property DS19 As Integer
    Public Property DS20 As Integer
    Public Property DS21 As Integer
    Public Property DS22 As Integer
    Public Property DS23 As Integer
    Public Property DS24 As Integer
    Public Property DS25 As Integer
    Public Property DS26 As Integer
    Public Property DS27 As Integer
    Public Property DS28 As Integer
    Public Property DS29 As Integer
    Public Property DS30 As Integer
#End Region
End Class
Public Class InputNLDInfo

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _maDoiTuong As String = String.Empty
    Private _maPhieuTuDong As Integer
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _maTinh_HT As Integer
    Private _maHuyen_HT As Integer
    Private _maXa_HT As Integer
    Private _maThon_HT As Integer
    Private _diaChi_HT As String = String.Empty
    Private _dTUT_NKT As Boolean
    Private _dTUT_HN As Boolean
    Private _dTUT_DTTS As Boolean
    Private _nCVL As Boolean
    Private _nTN As Boolean
    Private _kTGHDKT As Boolean
    Private _soThuTu As Integer
    Private _hoTen As String = String.Empty
    Private _namSinh As Short
    Private _gioiTinh As Short
    Private _danToc As String = String.Empty
    Private _tonGiao As Integer
    Private _quanHe As String = String.Empty
    Private _ngaySinh As DateTime
    Private _trinhDoGD As Short
    Private _trinhDoCM As Short
    Private _maNganhDT As String = String.Empty
    Private _chuyenNganhDT As String = String.Empty
    Private _linhVucDT As Short
    Private _hinhThuc As Short
    Private _loaiHinhKT As Short
    Private _noiLamViec As Short
    Private _nganhNghe As String = String.Empty
    Private _congViecDangLam As String = String.Empty
    Private _diaChiLamViec As String = String.Empty
    Private _nuocLamViec As Integer
    Private _loaiThatNghiep As Short
    Private _congViecThamGia As Short
    Private _thoiGianThatNghiep As String = String.Empty
    Private _lyDoKhongThamGia As Short
    Private _ghiChu As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Byte
    Private _isFlag As Byte
    Private _khuVuc As Integer
    Private _cMND As String = String.Empty
    Private _joinHDKT As Integer
    Private _unJoinHDKT As Integer
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _lienHeKhac As String = String.Empty
    Private _dTUT As String = String.Empty
    Private _dTUT_Khac As String = String.Empty
    Private _nN1_Ten As String = String.Empty
    Private _nN1_Loai As String = String.Empty
    Private _nN1_MD As Byte
    Private _nN2_Ten As String = String.Empty
    Private _nN2_Loai As String = String.Empty
    Private _nN2_MD As Byte
    Private _tH1_Ten As String = String.Empty
    Private _tH1_Loai As String = String.Empty
    Private _tH1_MD As Byte
    Private _tH2_Ten As String = String.Empty
    Private _tH2_Loai As String = String.Empty
    Private _tH2_MD As Byte
    Private _kyNangMem As String = String.Empty
    Private _kyNangMemKhac As String = String.Empty
    Private _maNganhNghe As String = String.Empty
    Private _loaiHopDong As Integer
    Private _coThamGiaBHXH As Boolean
    Private _loaiBHXH As Byte
    Private _thuNhapBQ As Double
    Private _soGioLamViecChinh As Double
    Private _soGioLamTatCa As Double
    Private _coSSLamThem As Boolean
    Private _viTriCoPhuHop As Boolean
    Private _kenhTimViec As String = String.Empty
    Private _kenhKhac As String = String.Empty
    Private _coNCTimViec As Boolean
    Private _lyDoThatNghiep As Integer
    Private _lyDoTNKhac As String = String.Empty
    Private _tN_CoNCTimViec As Boolean
    Private _kenhTimViecTN As Integer
    Private _kenhTNKhac As String = String.Empty
    Private _kinhNghiem As Integer
    Private _chucVu As Integer
    Private _chucVuKhac As String = String.Empty
    Private _diaBanLamViec As String = String.Empty
    Private _tinhLamViec As Integer
    Private _huyenLamViec As Integer
    Private _lHDMongMuon As Integer
    Private _loaiLamViec As String = String.Empty
    Private _hinhThucLamViec As Integer
    Private _mucDichMongMuon As Integer
    Private _mucLuongMongMuon As Integer
    Private _cheDoPhucLoi As String = String.Empty
    Private _cheDoKhac As String = String.Empty
    Private _duKienLamViec As Byte
    Private _soThangDuKien As Integer
    Private _hinhThucTuyenDung As Integer
    Private _nhuCauXuatKhau As Byte
    Private _tenNuocXuatKhau As String = String.Empty
    Private _mucLuongXuatKhau As Double
    Private _deXuatKienNghi As String = String.Empty
    Private _thangKhaoSat As Integer
    Private _namKhaoSat As Integer
    Private _nganhNgheMongMuon As String = String.Empty
    Private _cVMongMuon As String = String.Empty
    Private _cVMongMuonCuThe As String = String.Empty
    Private _maCVMongMuon As String = String.Empty
    Private _kinhNghiemLV As String = String.Empty
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

    Public Property MaDoiTuong() As String
        Get
            Return _maDoiTuong
        End Get
        Set(ByVal Value As String)
            _maDoiTuong = Value
        End Set
    End Property
    Public Property MaPhieuTuDong() As Integer
        Get
            Return _maPhieuTuDong
        End Get
        Set(ByVal Value As Integer)
            _maPhieuTuDong = Value
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
    Public Property MaTinh_HT() As Integer
        Get
            Return _maTinh_HT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_HT = Value
        End Set
    End Property
    Public Property MaHuyen_HT() As Integer
        Get
            Return _maHuyen_HT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_HT = Value
        End Set
    End Property
    Public Property MaXa_HT() As Integer
        Get
            Return _maXa_HT
        End Get
        Set(ByVal Value As Integer)
            _maXa_HT = Value
        End Set
    End Property
    Public Property MaThon_HT() As Integer
        Get
            Return _maThon_HT
        End Get
        Set(ByVal Value As Integer)
            _maThon_HT = Value
        End Set
    End Property
    Public Property DiaChi_HT() As String
        Get
            Return _diaChi_HT
        End Get
        Set(ByVal Value As String)
            _diaChi_HT = Value
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
    Public Property DTUT_HN() As Boolean
        Get
            Return _dTUT_HN
        End Get
        Set(ByVal Value As Boolean)
            _dTUT_HN = Value
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
    Public Property NCVL() As Boolean
        Get
            Return _nCVL
        End Get
        Set(ByVal Value As Boolean)
            _nCVL = Value
        End Set
    End Property
    Public Property NTN() As Boolean
        Get
            Return _nTN
        End Get
        Set(ByVal Value As Boolean)
            _nTN = Value
        End Set
    End Property
    Public Property KTGHDKT() As Boolean
        Get
            Return _kTGHDKT
        End Get
        Set(ByVal Value As Boolean)
            _kTGHDKT = Value
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
    Public Property TonGiao() As Integer
        Get
            Return _tonGiao
        End Get
        Set(ByVal Value As Integer)
            _tonGiao = Value
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
    Public Property MaNganhDT() As String
        Get
            Return _maNganhDT
        End Get
        Set(ByVal Value As String)
            _maNganhDT = Value
        End Set
    End Property
    Public Property ChuyenNganhDT() As String
        Get
            Return _chuyenNganhDT
        End Get
        Set(ByVal Value As String)
            _chuyenNganhDT = Value
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
    Public Property CongViecDangLam() As String
        Get
            Return _congViecDangLam
        End Get
        Set(ByVal Value As String)
            _congViecDangLam = Value
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
    Public Property ThoiGianThatNghiep() As String
        Get
            Return _thoiGianThatNghiep
        End Get
        Set(ByVal Value As String)
            _thoiGianThatNghiep = Value
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
    Public Property IsFlag() As Byte
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Byte)
            _isFlag = Value
        End Set
    End Property
    Public Property KhuVuc() As Integer
        Get
            Return _khuVuc
        End Get
        Set(ByVal Value As Integer)
            _khuVuc = Value
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
    Public Property JoinHDKT() As Integer
        Get
            Return _joinHDKT
        End Get
        Set(ByVal Value As Integer)
            _joinHDKT = Value
        End Set
    End Property
    Public Property UnJoinHDKT() As Integer
        Get
            Return _unJoinHDKT
        End Get
        Set(ByVal Value As Integer)
            _unJoinHDKT = Value
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
    Public Property DTUT() As String
        Get
            Return _dTUT
        End Get
        Set(ByVal Value As String)
            _dTUT = Value
        End Set
    End Property
    Public Property DTUT_Khac() As String
        Get
            Return _dTUT_Khac
        End Get
        Set(ByVal Value As String)
            _dTUT_Khac = Value
        End Set
    End Property
    Public Property NN1_Ten() As String
        Get
            Return _nN1_Ten
        End Get
        Set(ByVal Value As String)
            _nN1_Ten = Value
        End Set
    End Property
    Public Property NN1_Loai() As String
        Get
            Return _nN1_Loai
        End Get
        Set(ByVal Value As String)
            _nN1_Loai = Value
        End Set
    End Property
    Public Property NN1_MD() As Byte
        Get
            Return _nN1_MD
        End Get
        Set(ByVal Value As Byte)
            _nN1_MD = Value
        End Set
    End Property
    Public Property NN2_Ten() As String
        Get
            Return _nN2_Ten
        End Get
        Set(ByVal Value As String)
            _nN2_Ten = Value
        End Set
    End Property
    Public Property NN2_Loai() As String
        Get
            Return _nN2_Loai
        End Get
        Set(ByVal Value As String)
            _nN2_Loai = Value
        End Set
    End Property
    Public Property NN2_MD() As Byte
        Get
            Return _nN2_MD
        End Get
        Set(ByVal Value As Byte)
            _nN2_MD = Value
        End Set
    End Property
    Public Property TH1_Ten() As String
        Get
            Return _tH1_Ten
        End Get
        Set(ByVal Value As String)
            _tH1_Ten = Value
        End Set
    End Property
    Public Property TH1_Loai() As String
        Get
            Return _tH1_Loai
        End Get
        Set(ByVal Value As String)
            _tH1_Loai = Value
        End Set
    End Property
    Public Property TH1_MD() As Byte
        Get
            Return _tH1_MD
        End Get
        Set(ByVal Value As Byte)
            _tH1_MD = Value
        End Set
    End Property
    Public Property TH2_Ten() As String
        Get
            Return _tH2_Ten
        End Get
        Set(ByVal Value As String)
            _tH2_Ten = Value
        End Set
    End Property
    Public Property TH2_Loai() As String
        Get
            Return _tH2_Loai
        End Get
        Set(ByVal Value As String)
            _tH2_Loai = Value
        End Set
    End Property
    Public Property TH2_MD() As Byte
        Get
            Return _tH2_MD
        End Get
        Set(ByVal Value As Byte)
            _tH2_MD = Value
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
    Public Property KyNangMemKhac() As String
        Get
            Return _kyNangMemKhac
        End Get
        Set(ByVal Value As String)
            _kyNangMemKhac = Value
        End Set
    End Property
    Public Property MaNganhNghe() As String
        Get
            Return _maNganhNghe
        End Get
        Set(ByVal Value As String)
            _maNganhNghe = Value
        End Set
    End Property
    Public Property LoaiHopDong() As Integer
        Get
            Return _loaiHopDong
        End Get
        Set(ByVal Value As Integer)
            _loaiHopDong = Value
        End Set
    End Property
    Public Property CoThamGiaBHXH() As Boolean
        Get
            Return _coThamGiaBHXH
        End Get
        Set(ByVal Value As Boolean)
            _coThamGiaBHXH = Value
        End Set
    End Property
    Public Property LoaiBHXH() As Byte
        Get
            Return _loaiBHXH
        End Get
        Set(ByVal Value As Byte)
            _loaiBHXH = Value
        End Set
    End Property
    Public Property ThuNhapBQ() As Double
        Get
            Return _thuNhapBQ
        End Get
        Set(ByVal Value As Double)
            _thuNhapBQ = Value
        End Set
    End Property
    Public Property SoGioLamViecChinh() As Double
        Get
            Return _soGioLamViecChinh
        End Get
        Set(ByVal Value As Double)
            _soGioLamViecChinh = Value
        End Set
    End Property
    Public Property SoGioLamTatCa() As Double
        Get
            Return _soGioLamTatCa
        End Get
        Set(ByVal Value As Double)
            _soGioLamTatCa = Value
        End Set
    End Property
    Public Property CoSSLamThem() As Boolean
        Get
            Return _coSSLamThem
        End Get
        Set(ByVal Value As Boolean)
            _coSSLamThem = Value
        End Set
    End Property
    Public Property ViTriCoPhuHop() As Boolean
        Get
            Return _viTriCoPhuHop
        End Get
        Set(ByVal Value As Boolean)
            _viTriCoPhuHop = Value
        End Set
    End Property
    Public Property KenhTimViec() As String
        Get
            Return _kenhTimViec
        End Get
        Set(ByVal Value As String)
            _kenhTimViec = Value
        End Set
    End Property
    Public Property KenhKhac() As String
        Get
            Return _kenhKhac
        End Get
        Set(ByVal Value As String)
            _kenhKhac = Value
        End Set
    End Property
    Public Property CoNCTimViec() As Boolean
        Get
            Return _coNCTimViec
        End Get
        Set(ByVal Value As Boolean)
            _coNCTimViec = Value
        End Set
    End Property
    Public Property LyDoThatNghiep() As Integer
        Get
            Return _lyDoThatNghiep
        End Get
        Set(ByVal Value As Integer)
            _lyDoThatNghiep = Value
        End Set
    End Property
    Public Property LyDoTNKhac() As String
        Get
            Return _lyDoTNKhac
        End Get
        Set(ByVal Value As String)
            _lyDoTNKhac = Value
        End Set
    End Property
    Public Property TN_CoNCTimViec() As Boolean
        Get
            Return _tN_CoNCTimViec
        End Get
        Set(ByVal Value As Boolean)
            _tN_CoNCTimViec = Value
        End Set
    End Property
    Public Property KenhTimViecTN() As Integer
        Get
            Return _kenhTimViecTN
        End Get
        Set(ByVal Value As Integer)
            _kenhTimViecTN = Value
        End Set
    End Property
    Public Property KenhTNKhac() As String
        Get
            Return _kenhTNKhac
        End Get
        Set(ByVal Value As String)
            _kenhTNKhac = Value
        End Set
    End Property
    Public Property KinhNghiem() As Integer
        Get
            Return _kinhNghiem
        End Get
        Set(ByVal Value As Integer)
            _kinhNghiem = Value
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
    Public Property ChucVuKhac() As String
        Get
            Return _chucVuKhac
        End Get
        Set(ByVal Value As String)
            _chucVuKhac = Value
        End Set
    End Property
    Public Property DiaBanLamViec() As String
        Get
            Return _diaBanLamViec
        End Get
        Set(ByVal Value As String)
            _diaBanLamViec = Value
        End Set
    End Property
    Public Property TinhLamViec() As Integer
        Get
            Return _tinhLamViec
        End Get
        Set(ByVal Value As Integer)
            _tinhLamViec = Value
        End Set
    End Property
    Public Property HuyenLamViec() As Integer
        Get
            Return _huyenLamViec
        End Get
        Set(ByVal Value As Integer)
            _huyenLamViec = Value
        End Set
    End Property
    Public Property LHDMongMuon() As Integer
        Get
            Return _lHDMongMuon
        End Get
        Set(ByVal Value As Integer)
            _lHDMongMuon = Value
        End Set
    End Property
    Public Property LoaiLamViec() As String
        Get
            Return _loaiLamViec
        End Get
        Set(ByVal Value As String)
            _loaiLamViec = Value
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
    Public Property MucDichMongMuon() As Integer
        Get
            Return _mucDichMongMuon
        End Get
        Set(ByVal Value As Integer)
            _mucDichMongMuon = Value
        End Set
    End Property
    Public Property MucLuongMongMuon() As Integer
        Get
            Return _mucLuongMongMuon
        End Get
        Set(ByVal Value As Integer)
            _mucLuongMongMuon = Value
        End Set
    End Property
    Public Property CheDoPhucLoi() As String
        Get
            Return _cheDoPhucLoi
        End Get
        Set(ByVal Value As String)
            _cheDoPhucLoi = Value
        End Set
    End Property
    Public Property CheDoKhac() As String
        Get
            Return _cheDoKhac
        End Get
        Set(ByVal Value As String)
            _cheDoKhac = Value
        End Set
    End Property
    Public Property DuKienLamViec() As Byte
        Get
            Return _duKienLamViec
        End Get
        Set(ByVal Value As Byte)
            _duKienLamViec = Value
        End Set
    End Property
    Public Property SoThangDuKien() As Integer
        Get
            Return _soThangDuKien
        End Get
        Set(ByVal Value As Integer)
            _soThangDuKien = Value
        End Set
    End Property
    Public Property HinhThucTuyenDung() As Integer
        Get
            Return _hinhThucTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _hinhThucTuyenDung = Value
        End Set
    End Property
    Public Property NhuCauXuatKhau() As Byte
        Get
            Return _nhuCauXuatKhau
        End Get
        Set(ByVal Value As Byte)
            _nhuCauXuatKhau = Value
        End Set
    End Property
    Public Property TenNuocXuatKhau() As String
        Get
            Return _tenNuocXuatKhau
        End Get
        Set(ByVal Value As String)
            _tenNuocXuatKhau = Value
        End Set
    End Property
    Public Property MucLuongXuatKhau() As Double
        Get
            Return _mucLuongXuatKhau
        End Get
        Set(ByVal Value As Double)
            _mucLuongXuatKhau = Value
        End Set
    End Property
    Public Property DeXuatKienNghi() As String
        Get
            Return _deXuatKienNghi
        End Get
        Set(ByVal Value As String)
            _deXuatKienNghi = Value
        End Set
    End Property
    Public Property ThangKhaoSat() As Integer
        Get
            Return _thangKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _thangKhaoSat = Value
        End Set
    End Property
    Public Property NamKhaoSat() As Integer
        Get
            Return _namKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _namKhaoSat = Value
        End Set
    End Property
    Public Property NganhNgheMongMuon() As String
        Get
            Return _nganhNgheMongMuon
        End Get
        Set(ByVal Value As String)
            _nganhNgheMongMuon = Value
        End Set
    End Property
    Public Property CVMongMuon() As String
        Get
            Return _cVMongMuon
        End Get
        Set(ByVal Value As String)
            _cVMongMuon = Value
        End Set
    End Property
    Public Property CVMongMuonCuThe() As String
        Get
            Return _cVMongMuonCuThe
        End Get
        Set(ByVal Value As String)
            _cVMongMuonCuThe = Value
        End Set
    End Property
    Public Property MaCVMongMuon() As String
        Get
            Return _maCVMongMuon
        End Get
        Set(ByVal Value As String)
            _maCVMongMuon = Value
        End Set
    End Property
    Public Property KinhNghiemLV() As String
        Get
            Return _kinhNghiemLV
        End Get
        Set(ByVal Value As String)
            _kinhNghiemLV = Value
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
#End Region

#Region "Public Properties"

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

Public Class InputDNInfo

#Region "Private Members"
    Private _doanhNghiep_ID As String = String.Empty
    Private _thangKhaoSat As Integer
    Private _namKhaoSat As Integer
    Private _maDoanhNghiep As String = String.Empty
    Private _tenDoanhNghiep As String = String.Empty
    Private _maSDDKD As String = String.Empty
    Private _loaiHinh As Integer
    Private _tinhTP As String = String.Empty
    Private _quanHuyen As String = String.Empty
    Private _xaPhuong As String = String.Empty
    Private _diaChi As String = String.Empty
    Private _kCNKKT As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _website As String = String.Empty
    Private _namThanhLap As Integer
    Private _nganhSanXuat As String = String.Empty
    Private _quyMo As Integer
    Private _tongSoLaoDong As Integer
    Private _tongSoLaoDongNu As Integer
    Private _soLDNgoaiTinh As Integer
    Private _soLDNgoaiTinhNu As Integer
    Private _soLDTrucTiep As Integer
    Private _soLDTrucTiepNu As Integer
    Private _soLDGianTiep As Integer
    Private _soLDGianTiepNu As Integer
    Private _soLDDaKyHopDong As Integer
    Private _soLDDaKyHopDongNu As Integer
    Private _soLDBHXH As Integer
    Private _soLDBHXHNu As Integer
    Private _soLDTren35 As Integer
    Private _soLDTren35Nu As Integer
    Private _soLDNguoiNN As Integer
    Private _soLDNguoiNNNu As Integer
    Private _soLDTHPT As Integer
    Private _soLDTHPTNU As Integer
    Private _soLDTDKhongCo As Integer
    Private _soLDTDKhongCoNu As Integer
    Private _soLDTDCongNhan As Integer
    Private _soLDTDCongNhanNu As Integer
    Private _soLDTDDaoTao As Integer
    Private _soLDTDDaoTaoNu As Integer
    Private _soLDTDSoCap As Integer
    Private _soLDTDSoCapNu As Integer
    Private _soLDTDTrungCap As Integer
    Private _soLDTDTrungCapNu As Integer
    Private _soLDTDCaoDang As Integer
    Private _soLDTDCaoDangNu As Integer
    Private _soLDTDDaiHoc As Integer
    Private _soLDTDDaiHocNu As Integer
    Private _soLDLVChuongTrinh As Integer
    Private _soLDLVChuongTrinhNu As Integer
    Private _soLDLVKhoaHoc As Integer
    Private _soLDLVKhoaHocNu As Integer
    Private _soLDLVNgheThuat As Integer
    Private _soLDLVNgheThuatNu As Integer
    Private _soLDLVNhanVan As Integer
    Private _soLDLVNhanVanNu As Integer
    Private _soLDLVKhoaHocXH As Integer
    Private _soLDLVKhoaHocXHNu As Integer
    Private _soLDLVBaoTri As Integer
    Private _soLDLVBaoTriNu As Integer
    Private _soLDLVKinhDoanh As Integer
    Private _soLDLVKinhDoanhNu As Integer
    Private _soLDLVPhapLuat As Integer
    Private _soLDLVPhapLuatNu As Integer
    Private _soLDLVKhoaHocSS As Integer
    Private _soLDLVKhoaHocSSNu As Integer
    Private _soLDLVKhoaHocTN As Integer
    Private _soLDLVKhoaHocTNNu As Integer
    Private _soLDLVToan As Integer
    Private _soLDLVToanNu As Integer
    Private _soLDLVMayTinh As Integer
    Private _soLDLVMayTinhNu As Integer
    Private _soLDLVCongNghe As Integer
    Private _soLDLVCongNgheNu As Integer
    Private _soLDLVKyThuat As Integer
    Private _soLDLVKyThuatNu As Integer
    Private _soLDLVSanXuat As Integer
    Private _soLDLVSanXuatNu As Integer
    Private _soLDLVKienTruc As Integer
    Private _soLDLVKienTrucNu As Integer
    Private _soLDLVNongLam As Integer
    Private _soLDLVNongLamNu As Integer
    Private _soLDLVThuY As Integer
    Private _soLDLVThuYNu As Integer
    Private _soLDLVSucKhoe As Integer
    Private _soLDLVSucKhoeNu As Integer
    Private _soLDLVDichVuXH As Integer
    Private _soLDLVDichVuXHNu As Integer
    Private _soLDLVDuLich As Integer
    Private _soLDLVDuLichNu As Integer
    Private _soLDLVDichVuVT As Integer
    Private _soLDLVDichVuVTNu As Integer
    Private _soLDLVMoiTruong As Integer
    Private _soLDLVMoiTruongNu As Integer
    Private _soLDLVAnNinh As Integer
    Private _soLDLVAnNinhNu As Integer
    Private _soLDLVKhac As Integer
    Private _soLDLVKhacNu As Integer
    Private _soLDNNLanhDao As Integer
    Private _soLDNNLanhDaoNu As Integer
    Private _soLDNNKyThuatBC As Integer
    Private _soLDNNKyThuatBCNu As Integer
    Private _soLDNNKyThuatBT As Integer
    Private _soLDNNKyThuatBTNu As Integer
    Private _soLDNNNhanVienNghe As Integer
    Private _soLDNNNhanVienNgheNu As Integer
    Private _soLDNNNhanVienDV As Integer
    Private _soLDNNNhanVienDVNu As Integer
    Private _soLDNNLaoDongCoKT As Integer
    Private _soLDNNLaoDongCoKTNu As Integer
    Private _soLDNNThoThuCong As Integer
    Private _soLDNNThoThuCongNu As Integer
    Private _soLDNNThoKyThuat As Integer
    Private _soLDNNThoKyThuatNu As Integer
    Private _soLDNNLaoDongPT As Integer
    Private _soLDNNLaoDongPTNu As Integer
    Private _soLDTDTiengAnh As Integer
    Private _soLDTDTiengAnhNu As Integer
    Private _soLDTDTiengTrung As Integer
    Private _soLDTDTiengTrungNu As Integer
    Private _soLDTDTiengNhat As Integer
    Private _soLDTDTiengNhatNu As Integer
    Private _soLDTDTiengKhac As Integer
    Private _soLDTDTiengKhacNu As Integer
    Private _soLDTDTinHocCB As Integer
    Private _soLDTDTinHocCBNu As Integer
    Private _soLDTDTinHocNC As Integer
    Private _soLDTDTinHocNCNu As Integer
    Private _soLDTDTinHocNC2 As Integer
    Private _soLDTDTinHocNC2Nu As Integer
    Private _tienLuongBinhQuan As Double
    Private _tienLuongThapNhat As Double
    Private _tienLuongCaoNhat As Double
    Private _danhGia11KN As Integer
    Private _danhGia11MD As Integer
    Private _danhGia12KN As Integer
    Private _danhGia12MD As Integer
    Private _danhGia13KN As Integer
    Private _danhGia13MD As Integer
    Private _danhGia21KN As Integer
    Private _danhGia21MD As Integer
    Private _danhGia22KN As Integer
    Private _danhGia22MD As Integer
    Private _danhGia23KN As Integer
    Private _danhGia23MD As Integer
    Private _danhGia31KN As Integer
    Private _danhGia31MD As Integer
    Private _danhGia32KN As Integer
    Private _danhGia32MD As Integer
    Private _danhGia33KN As Integer
    Private _danhGia33MD As Integer
    Private _danhGia41KN As Integer
    Private _danhGia41MD As Integer
    Private _danhGia42KN As Integer
    Private _danhGia42MD As Integer
    Private _danhGia43KN As Integer
    Private _danhGia43MD As Integer
    Private _danhGia51KN As Integer
    Private _danhGia51MD As Integer
    Private _danhGia52KN As Integer
    Private _danhGia52MD As Integer
    Private _danhGia53KN As Integer
    Private _danhGia53MD As Integer
    Private _danhGia61KN As Integer
    Private _danhGia61MD As Integer
    Private _danhGia62KN As Integer
    Private _danhGia62MD As Integer
    Private _danhGia63KN As Integer
    Private _danhGia63MD As Integer
    Private _danhGia71KN As Integer
    Private _danhGia71MD As Integer
    Private _danhGia72KN As Integer
    Private _danhGia72MD As Integer
    Private _danhGia73KN As Integer
    Private _danhGia73MD As Integer
    Private _danhGia81KN As Integer
    Private _danhGia81MD As Integer
    Private _danhGia82KN As Integer
    Private _danhGia82MD As Integer
    Private _danhGia83KN As Integer
    Private _danhGia83MD As Integer
    Private _danhGia91KN As Integer
    Private _danhGia91MD As Integer
    Private _danhGia92KN As Integer
    Private _danhGia92MD As Integer
    Private _danhGia93KN As Integer
    Private _danhGia93MD As Integer
    Private _nhuCauNNNongLam As Integer
    Private _nhuCauNNNongLamNu As Integer
    Private _nhuCauNNCongNghiep As Integer
    Private _nhuCauNNCongNghiepNu As Integer
    Private _nhuCauNNThuongMai As Integer
    Private _nhuCauNNThuongMaiNu As Integer
    Private _nhuCauTDLanhDao As Integer
    Private _nhuCauTDLanhDaoNu As Integer
    Private _nhuCauTDSoCap As Integer
    Private _nhuCauTDSoCapNu As Integer
    Private _nhuCauTDTrungCap As Integer
    Private _nhuCauTDTrungCapNu As Integer
    Private _nhuCauTDCaoDang As Integer
    Private _nhuCauTDCaoDangNu As Integer
    Private _nhuCauTDDaiHoc As Integer
    Private _nhuCauTDDaiHocNu As Integer
    Private _nhuCauLDNNLanhDao As Integer
    Private _nhuCauTDNNLanhDaoNu As Integer
    Private _nhuCauTDNNChuyenMonBC As Integer
    Private _nhuCauTDNNChuyenMonBCNu As Integer
    Private _nhuCauTDNNChuyenMocBT As Integer
    Private _nhuCauTDNNChuyenMonBTNu As Integer
    Private _nhuCauTDNNNhanVienNN As Integer
    Private _nhuCauTDNNNhanVienNNNu As Integer
    Private _nhuCauTDNNNhanVienDV As Integer
    Private _nhuCauTDNNNhanVienDVNu As Integer
    Private _nhuCauTDNNLaoDongKT As Integer
    Private _nhuCauTDNNLaoDongKTNu As Integer
    Private _nhuCauTDNNThoTC As Integer
    Private _nhuCauTDNNThoTCNu As Integer
    Private _nhuCauTDNNThoKT As Integer
    Private _nhuCauTDNNThoKTNu As Integer
    Private _nhuCauTDNNLaoDongPT As Integer
    Private _nhuCauTDNNLaoDongPTNu As Integer
    Private _nhuCauTDTDTiengAnh As Integer
    Private _nhuCauTDTDTiengAnhNu As Integer
    Private _nhuCauTDTDTiengTrung As Integer
    Private _nhuCauTDTDTiengTrungNu As Integer
    Private _nhuCauTDTDTiengHN As Integer
    Private _nhuCauTDTDTiengHNNu As Integer
    Private _nhuCauTDTDTiengKhac As Integer
    Private _nhuCauTDTDTiengKhacNu As Integer
    Private _nhuCauTDTDTinHocCB As Integer
    Private _nhuCauTDTDTinHocCBNu As Integer
    Private _nhuCauTDTDTinHocNC As Integer
    Private _nhuCauTDTDTinHocNCNu As Integer
    Private _nhuCauTDTDTinHocNC2 As Integer
    Private _nhuCauTDTDTinHocNC2Nu As Integer
    Private _nhuCauTDMLThoaThuan As Integer
    Private _nhuCauTDMLThoaThuanNu As Integer
    Private _nhuCauTDML3 As Integer
    Private _nhuCauTDML3Nu As Integer
    Private _nhuCauTDML5 As Integer
    Private _nhuCauTDML5Nu As Integer
    Private _nhuCauTDML7 As Integer
    Private _nhuCauTDML7Nu As Integer
    Private _nhuCauTDML10 As Integer
    Private _nhuCauTDML10Nu As Integer
    Private _nhuCauTDML15 As Integer
    Private _nhuCauTDML15Nu As Integer
    Private _nhuCauTBKNChua As Integer
    Private _nhuCauTBKNChuaNu As Integer
    Private _nhuCauTBKN1 As Integer
    Private _nhuCauTBKN1Nu As Integer
    Private _nhuCauTBKN3 As Integer
    Private _nhuCauTBKN3Nu As Integer
    Private _nhuCauTBKN5 As Integer
    Private _nhuCauTBKN5Nu As Integer
    Private _nhuCauTBKN10 As Integer
    Private _nhuCauTBKN10Nu As Integer
    Private _khoKhanTDLD As Boolean
    Private _khoKhanPhiaLD As String = String.Empty
    Private _khoKhanPhiaDN As String = String.Empty
    Private _khoKhanPhiaDNKhac As String = String.Empty
    Private _nhomTrinhDoCMKT As String = String.Empty
    Private _nhomNgheKTD As String = String.Empty
    Private _hinhThucTuyenDung As String = String.Empty
    Private _hinhThucTuyenDungKhac As String = String.Empty
    Private _tungLienKet As Boolean
    Private _daHopTac As String = String.Empty
    Private _daHopTacKhac As String = String.Empty
    Private _khoKhanVuongMac As String = String.Empty
    Private _khuyenNghi As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
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

    Public Property DoanhNghiep_ID() As String
        Get
            Return _doanhNghiep_ID
        End Get
        Set(ByVal Value As String)
            _doanhNghiep_ID = Value
        End Set
    End Property

    Public Property ThangKhaoSat() As Integer
        Get
            Return _thangKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _thangKhaoSat = Value
        End Set
    End Property
    Public Property NamKhaoSat() As Integer
        Get
            Return _namKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _namKhaoSat = Value
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
    Public Property MaSDDKD() As String
        Get
            Return _maSDDKD
        End Get
        Set(ByVal Value As String)
            _maSDDKD = Value
        End Set
    End Property
    Public Property LoaiHinh() As Integer
        Get
            Return _loaiHinh
        End Get
        Set(ByVal Value As Integer)
            _loaiHinh = Value
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
    Public Property DiaChi() As String
        Get
            Return _diaChi
        End Get
        Set(ByVal Value As String)
            _diaChi = Value
        End Set
    End Property
    Public Property KCNKKT() As String
        Get
            Return _kCNKKT
        End Get
        Set(ByVal Value As String)
            _kCNKKT = Value
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
    Public Property Website() As String
        Get
            Return _website
        End Get
        Set(ByVal Value As String)
            _website = Value
        End Set
    End Property
    Public Property NamThanhLap() As Integer
        Get
            Return _namThanhLap
        End Get
        Set(ByVal Value As Integer)
            _namThanhLap = Value
        End Set
    End Property
    Public Property NganhSanXuat() As String
        Get
            Return _nganhSanXuat
        End Get
        Set(ByVal Value As String)
            _nganhSanXuat = Value
        End Set
    End Property
    Public Property QuyMo() As Integer
        Get
            Return _quyMo
        End Get
        Set(ByVal Value As Integer)
            _quyMo = Value
        End Set
    End Property
    Public Property TongSoLaoDong() As Integer
        Get
            Return _tongSoLaoDong
        End Get
        Set(ByVal Value As Integer)
            _tongSoLaoDong = Value
        End Set
    End Property
    Public Property TongSoLaoDongNu() As Integer
        Get
            Return _tongSoLaoDongNu
        End Get
        Set(ByVal Value As Integer)
            _tongSoLaoDongNu = Value
        End Set
    End Property
    Public Property SoLDNgoaiTinh() As Integer
        Get
            Return _soLDNgoaiTinh
        End Get
        Set(ByVal Value As Integer)
            _soLDNgoaiTinh = Value
        End Set
    End Property
    Public Property SoLDNgoaiTinhNu() As Integer
        Get
            Return _soLDNgoaiTinhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNgoaiTinhNu = Value
        End Set
    End Property
    Public Property SoLDTrucTiep() As Integer
        Get
            Return _soLDTrucTiep
        End Get
        Set(ByVal Value As Integer)
            _soLDTrucTiep = Value
        End Set
    End Property
    Public Property SoLDTrucTiepNu() As Integer
        Get
            Return _soLDTrucTiepNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTrucTiepNu = Value
        End Set
    End Property
    Public Property SoLDGianTiep() As Integer
        Get
            Return _soLDGianTiep
        End Get
        Set(ByVal Value As Integer)
            _soLDGianTiep = Value
        End Set
    End Property
    Public Property SoLDGianTiepNu() As Integer
        Get
            Return _soLDGianTiepNu
        End Get
        Set(ByVal Value As Integer)
            _soLDGianTiepNu = Value
        End Set
    End Property
    Public Property SoLDDaKyHopDong() As Integer
        Get
            Return _soLDDaKyHopDong
        End Get
        Set(ByVal Value As Integer)
            _soLDDaKyHopDong = Value
        End Set
    End Property
    Public Property SoLDDaKyHopDongNu() As Integer
        Get
            Return _soLDDaKyHopDongNu
        End Get
        Set(ByVal Value As Integer)
            _soLDDaKyHopDongNu = Value
        End Set
    End Property
    Public Property SoLDBHXH() As Integer
        Get
            Return _soLDBHXH
        End Get
        Set(ByVal Value As Integer)
            _soLDBHXH = Value
        End Set
    End Property
    Public Property SoLDBHXHNu() As Integer
        Get
            Return _soLDBHXHNu
        End Get
        Set(ByVal Value As Integer)
            _soLDBHXHNu = Value
        End Set
    End Property
    Public Property SoLDTren35() As Integer
        Get
            Return _soLDTren35
        End Get
        Set(ByVal Value As Integer)
            _soLDTren35 = Value
        End Set
    End Property
    Public Property SoLDTren35Nu() As Integer
        Get
            Return _soLDTren35Nu
        End Get
        Set(ByVal Value As Integer)
            _soLDTren35Nu = Value
        End Set
    End Property
    Public Property SoLDNguoiNN() As Integer
        Get
            Return _soLDNguoiNN
        End Get
        Set(ByVal Value As Integer)
            _soLDNguoiNN = Value
        End Set
    End Property
    Public Property SoLDNguoiNNNu() As Integer
        Get
            Return _soLDNguoiNNNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNguoiNNNu = Value
        End Set
    End Property
    Public Property SoLDTHPT() As Integer
        Get
            Return _soLDTHPT
        End Get
        Set(ByVal Value As Integer)
            _soLDTHPT = Value
        End Set
    End Property
    Public Property SoLDTHPTNU() As Integer
        Get
            Return _soLDTHPTNU
        End Get
        Set(ByVal Value As Integer)
            _soLDTHPTNU = Value
        End Set
    End Property
    Public Property SoLDTDKhongCo() As Integer
        Get
            Return _soLDTDKhongCo
        End Get
        Set(ByVal Value As Integer)
            _soLDTDKhongCo = Value
        End Set
    End Property
    Public Property SoLDTDKhongCoNu() As Integer
        Get
            Return _soLDTDKhongCoNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDKhongCoNu = Value
        End Set
    End Property
    Public Property SoLDTDCongNhan() As Integer
        Get
            Return _soLDTDCongNhan
        End Get
        Set(ByVal Value As Integer)
            _soLDTDCongNhan = Value
        End Set
    End Property
    Public Property SoLDTDCongNhanNu() As Integer
        Get
            Return _soLDTDCongNhanNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDCongNhanNu = Value
        End Set
    End Property
    Public Property SoLDTDDaoTao() As Integer
        Get
            Return _soLDTDDaoTao
        End Get
        Set(ByVal Value As Integer)
            _soLDTDDaoTao = Value
        End Set
    End Property
    Public Property SoLDTDDaoTaoNu() As Integer
        Get
            Return _soLDTDDaoTaoNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDDaoTaoNu = Value
        End Set
    End Property
    Public Property SoLDTDSoCap() As Integer
        Get
            Return _soLDTDSoCap
        End Get
        Set(ByVal Value As Integer)
            _soLDTDSoCap = Value
        End Set
    End Property
    Public Property SoLDTDSoCapNu() As Integer
        Get
            Return _soLDTDSoCapNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDSoCapNu = Value
        End Set
    End Property
    Public Property SoLDTDTrungCap() As Integer
        Get
            Return _soLDTDTrungCap
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTrungCap = Value
        End Set
    End Property
    Public Property SoLDTDTrungCapNu() As Integer
        Get
            Return _soLDTDTrungCapNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTrungCapNu = Value
        End Set
    End Property
    Public Property SoLDTDCaoDang() As Integer
        Get
            Return _soLDTDCaoDang
        End Get
        Set(ByVal Value As Integer)
            _soLDTDCaoDang = Value
        End Set
    End Property
    Public Property SoLDTDCaoDangNu() As Integer
        Get
            Return _soLDTDCaoDangNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDCaoDangNu = Value
        End Set
    End Property
    Public Property SoLDTDDaiHoc() As Integer
        Get
            Return _soLDTDDaiHoc
        End Get
        Set(ByVal Value As Integer)
            _soLDTDDaiHoc = Value
        End Set
    End Property
    Public Property SoLDTDDaiHocNu() As Integer
        Get
            Return _soLDTDDaiHocNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDDaiHocNu = Value
        End Set
    End Property
    Public Property SoLDLVChuongTrinh() As Integer
        Get
            Return _soLDLVChuongTrinh
        End Get
        Set(ByVal Value As Integer)
            _soLDLVChuongTrinh = Value
        End Set
    End Property
    Public Property SoLDLVChuongTrinhNu() As Integer
        Get
            Return _soLDLVChuongTrinhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVChuongTrinhNu = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHoc() As Integer
        Get
            Return _soLDLVKhoaHoc
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHoc = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocNu() As Integer
        Get
            Return _soLDLVKhoaHocNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocNu = Value
        End Set
    End Property
    Public Property SoLDLVNgheThuat() As Integer
        Get
            Return _soLDLVNgheThuat
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNgheThuat = Value
        End Set
    End Property
    Public Property SoLDLVNgheThuatNu() As Integer
        Get
            Return _soLDLVNgheThuatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNgheThuatNu = Value
        End Set
    End Property
    Public Property SoLDLVNhanVan() As Integer
        Get
            Return _soLDLVNhanVan
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNhanVan = Value
        End Set
    End Property
    Public Property SoLDLVNhanVanNu() As Integer
        Get
            Return _soLDLVNhanVanNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNhanVanNu = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocXH() As Integer
        Get
            Return _soLDLVKhoaHocXH
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocXH = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocXHNu() As Integer
        Get
            Return _soLDLVKhoaHocXHNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocXHNu = Value
        End Set
    End Property
    Public Property SoLDLVBaoTri() As Integer
        Get
            Return _soLDLVBaoTri
        End Get
        Set(ByVal Value As Integer)
            _soLDLVBaoTri = Value
        End Set
    End Property
    Public Property SoLDLVBaoTriNu() As Integer
        Get
            Return _soLDLVBaoTriNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVBaoTriNu = Value
        End Set
    End Property
    Public Property SoLDLVKinhDoanh() As Integer
        Get
            Return _soLDLVKinhDoanh
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKinhDoanh = Value
        End Set
    End Property
    Public Property SoLDLVKinhDoanhNu() As Integer
        Get
            Return _soLDLVKinhDoanhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKinhDoanhNu = Value
        End Set
    End Property
    Public Property SoLDLVPhapLuat() As Integer
        Get
            Return _soLDLVPhapLuat
        End Get
        Set(ByVal Value As Integer)
            _soLDLVPhapLuat = Value
        End Set
    End Property
    Public Property SoLDLVPhapLuatNu() As Integer
        Get
            Return _soLDLVPhapLuatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVPhapLuatNu = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocSS() As Integer
        Get
            Return _soLDLVKhoaHocSS
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocSS = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocSSNu() As Integer
        Get
            Return _soLDLVKhoaHocSSNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocSSNu = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocTN() As Integer
        Get
            Return _soLDLVKhoaHocTN
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocTN = Value
        End Set
    End Property
    Public Property SoLDLVKhoaHocTNNu() As Integer
        Get
            Return _soLDLVKhoaHocTNNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhoaHocTNNu = Value
        End Set
    End Property
    Public Property SoLDLVToan() As Integer
        Get
            Return _soLDLVToan
        End Get
        Set(ByVal Value As Integer)
            _soLDLVToan = Value
        End Set
    End Property
    Public Property SoLDLVToanNu() As Integer
        Get
            Return _soLDLVToanNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVToanNu = Value
        End Set
    End Property
    Public Property SoLDLVMayTinh() As Integer
        Get
            Return _soLDLVMayTinh
        End Get
        Set(ByVal Value As Integer)
            _soLDLVMayTinh = Value
        End Set
    End Property
    Public Property SoLDLVMayTinhNu() As Integer
        Get
            Return _soLDLVMayTinhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVMayTinhNu = Value
        End Set
    End Property
    Public Property SoLDLVCongNghe() As Integer
        Get
            Return _soLDLVCongNghe
        End Get
        Set(ByVal Value As Integer)
            _soLDLVCongNghe = Value
        End Set
    End Property
    Public Property SoLDLVCongNgheNu() As Integer
        Get
            Return _soLDLVCongNgheNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVCongNgheNu = Value
        End Set
    End Property
    Public Property SoLDLVKyThuat() As Integer
        Get
            Return _soLDLVKyThuat
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKyThuat = Value
        End Set
    End Property
    Public Property SoLDLVKyThuatNu() As Integer
        Get
            Return _soLDLVKyThuatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKyThuatNu = Value
        End Set
    End Property
    Public Property SoLDLVSanXuat() As Integer
        Get
            Return _soLDLVSanXuat
        End Get
        Set(ByVal Value As Integer)
            _soLDLVSanXuat = Value
        End Set
    End Property
    Public Property SoLDLVSanXuatNu() As Integer
        Get
            Return _soLDLVSanXuatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVSanXuatNu = Value
        End Set
    End Property
    Public Property SoLDLVKienTruc() As Integer
        Get
            Return _soLDLVKienTruc
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKienTruc = Value
        End Set
    End Property
    Public Property SoLDLVKienTrucNu() As Integer
        Get
            Return _soLDLVKienTrucNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKienTrucNu = Value
        End Set
    End Property
    Public Property SoLDLVNongLam() As Integer
        Get
            Return _soLDLVNongLam
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNongLam = Value
        End Set
    End Property
    Public Property SoLDLVNongLamNu() As Integer
        Get
            Return _soLDLVNongLamNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVNongLamNu = Value
        End Set
    End Property
    Public Property SoLDLVThuY() As Integer
        Get
            Return _soLDLVThuY
        End Get
        Set(ByVal Value As Integer)
            _soLDLVThuY = Value
        End Set
    End Property
    Public Property SoLDLVThuYNu() As Integer
        Get
            Return _soLDLVThuYNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVThuYNu = Value
        End Set
    End Property
    Public Property SoLDLVSucKhoe() As Integer
        Get
            Return _soLDLVSucKhoe
        End Get
        Set(ByVal Value As Integer)
            _soLDLVSucKhoe = Value
        End Set
    End Property
    Public Property SoLDLVSucKhoeNu() As Integer
        Get
            Return _soLDLVSucKhoeNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVSucKhoeNu = Value
        End Set
    End Property
    Public Property SoLDLVDichVuXH() As Integer
        Get
            Return _soLDLVDichVuXH
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDichVuXH = Value
        End Set
    End Property
    Public Property SoLDLVDichVuXHNu() As Integer
        Get
            Return _soLDLVDichVuXHNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDichVuXHNu = Value
        End Set
    End Property
    Public Property SoLDLVDuLich() As Integer
        Get
            Return _soLDLVDuLich
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDuLich = Value
        End Set
    End Property
    Public Property SoLDLVDuLichNu() As Integer
        Get
            Return _soLDLVDuLichNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDuLichNu = Value
        End Set
    End Property
    Public Property SoLDLVDichVuVT() As Integer
        Get
            Return _soLDLVDichVuVT
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDichVuVT = Value
        End Set
    End Property
    Public Property SoLDLVDichVuVTNu() As Integer
        Get
            Return _soLDLVDichVuVTNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVDichVuVTNu = Value
        End Set
    End Property
    Public Property SoLDLVMoiTruong() As Integer
        Get
            Return _soLDLVMoiTruong
        End Get
        Set(ByVal Value As Integer)
            _soLDLVMoiTruong = Value
        End Set
    End Property
    Public Property SoLDLVMoiTruongNu() As Integer
        Get
            Return _soLDLVMoiTruongNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVMoiTruongNu = Value
        End Set
    End Property
    Public Property SoLDLVAnNinh() As Integer
        Get
            Return _soLDLVAnNinh
        End Get
        Set(ByVal Value As Integer)
            _soLDLVAnNinh = Value
        End Set
    End Property
    Public Property SoLDLVAnNinhNu() As Integer
        Get
            Return _soLDLVAnNinhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVAnNinhNu = Value
        End Set
    End Property
    Public Property SoLDLVKhac() As Integer
        Get
            Return _soLDLVKhac
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhac = Value
        End Set
    End Property
    Public Property SoLDLVKhacNu() As Integer
        Get
            Return _soLDLVKhacNu
        End Get
        Set(ByVal Value As Integer)
            _soLDLVKhacNu = Value
        End Set
    End Property
    Public Property SoLDNNLanhDao() As Integer
        Get
            Return _soLDNNLanhDao
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLanhDao = Value
        End Set
    End Property
    Public Property SoLDNNLanhDaoNu() As Integer
        Get
            Return _soLDNNLanhDaoNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLanhDaoNu = Value
        End Set
    End Property
    Public Property SoLDNNKyThuatBC() As Integer
        Get
            Return _soLDNNKyThuatBC
        End Get
        Set(ByVal Value As Integer)
            _soLDNNKyThuatBC = Value
        End Set
    End Property
    Public Property SoLDNNKyThuatBCNu() As Integer
        Get
            Return _soLDNNKyThuatBCNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNKyThuatBCNu = Value
        End Set
    End Property
    Public Property SoLDNNKyThuatBT() As Integer
        Get
            Return _soLDNNKyThuatBT
        End Get
        Set(ByVal Value As Integer)
            _soLDNNKyThuatBT = Value
        End Set
    End Property
    Public Property SoLDNNKyThuatBTNu() As Integer
        Get
            Return _soLDNNKyThuatBTNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNKyThuatBTNu = Value
        End Set
    End Property
    Public Property SoLDNNNhanVienNghe() As Integer
        Get
            Return _soLDNNNhanVienNghe
        End Get
        Set(ByVal Value As Integer)
            _soLDNNNhanVienNghe = Value
        End Set
    End Property
    Public Property SoLDNNNhanVienNgheNu() As Integer
        Get
            Return _soLDNNNhanVienNgheNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNNhanVienNgheNu = Value
        End Set
    End Property
    Public Property SoLDNNNhanVienDV() As Integer
        Get
            Return _soLDNNNhanVienDV
        End Get
        Set(ByVal Value As Integer)
            _soLDNNNhanVienDV = Value
        End Set
    End Property
    Public Property SoLDNNNhanVienDVNu() As Integer
        Get
            Return _soLDNNNhanVienDVNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNNhanVienDVNu = Value
        End Set
    End Property
    Public Property SoLDNNLaoDongCoKT() As Integer
        Get
            Return _soLDNNLaoDongCoKT
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLaoDongCoKT = Value
        End Set
    End Property
    Public Property SoLDNNLaoDongCoKTNu() As Integer
        Get
            Return _soLDNNLaoDongCoKTNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLaoDongCoKTNu = Value
        End Set
    End Property
    Public Property SoLDNNThoThuCong() As Integer
        Get
            Return _soLDNNThoThuCong
        End Get
        Set(ByVal Value As Integer)
            _soLDNNThoThuCong = Value
        End Set
    End Property
    Public Property SoLDNNThoThuCongNu() As Integer
        Get
            Return _soLDNNThoThuCongNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNThoThuCongNu = Value
        End Set
    End Property
    Public Property SoLDNNThoKyThuat() As Integer
        Get
            Return _soLDNNThoKyThuat
        End Get
        Set(ByVal Value As Integer)
            _soLDNNThoKyThuat = Value
        End Set
    End Property
    Public Property SoLDNNThoKyThuatNu() As Integer
        Get
            Return _soLDNNThoKyThuatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNThoKyThuatNu = Value
        End Set
    End Property
    Public Property SoLDNNLaoDongPT() As Integer
        Get
            Return _soLDNNLaoDongPT
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLaoDongPT = Value
        End Set
    End Property
    Public Property SoLDNNLaoDongPTNu() As Integer
        Get
            Return _soLDNNLaoDongPTNu
        End Get
        Set(ByVal Value As Integer)
            _soLDNNLaoDongPTNu = Value
        End Set
    End Property
    Public Property SoLDTDTiengAnh() As Integer
        Get
            Return _soLDTDTiengAnh
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengAnh = Value
        End Set
    End Property
    Public Property SoLDTDTiengAnhNu() As Integer
        Get
            Return _soLDTDTiengAnhNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengAnhNu = Value
        End Set
    End Property
    Public Property SoLDTDTiengTrung() As Integer
        Get
            Return _soLDTDTiengTrung
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengTrung = Value
        End Set
    End Property
    Public Property SoLDTDTiengTrungNu() As Integer
        Get
            Return _soLDTDTiengTrungNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengTrungNu = Value
        End Set
    End Property
    Public Property SoLDTDTiengNhat() As Integer
        Get
            Return _soLDTDTiengNhat
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengNhat = Value
        End Set
    End Property
    Public Property SoLDTDTiengNhatNu() As Integer
        Get
            Return _soLDTDTiengNhatNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengNhatNu = Value
        End Set
    End Property
    Public Property SoLDTDTiengKhac() As Integer
        Get
            Return _soLDTDTiengKhac
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengKhac = Value
        End Set
    End Property
    Public Property SoLDTDTiengKhacNu() As Integer
        Get
            Return _soLDTDTiengKhacNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTiengKhacNu = Value
        End Set
    End Property
    Public Property SoLDTDTinHocCB() As Integer
        Get
            Return _soLDTDTinHocCB
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocCB = Value
        End Set
    End Property
    Public Property SoLDTDTinHocCBNu() As Integer
        Get
            Return _soLDTDTinHocCBNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocCBNu = Value
        End Set
    End Property
    Public Property SoLDTDTinHocNC() As Integer
        Get
            Return _soLDTDTinHocNC
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocNC = Value
        End Set
    End Property
    Public Property SoLDTDTinHocNCNu() As Integer
        Get
            Return _soLDTDTinHocNCNu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocNCNu = Value
        End Set
    End Property
    Public Property SoLDTDTinHocNC2() As Integer
        Get
            Return _soLDTDTinHocNC2
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocNC2 = Value
        End Set
    End Property
    Public Property SoLDTDTinHocNC2Nu() As Integer
        Get
            Return _soLDTDTinHocNC2Nu
        End Get
        Set(ByVal Value As Integer)
            _soLDTDTinHocNC2Nu = Value
        End Set
    End Property
    Public Property TienLuongBinhQuan() As Double
        Get
            Return _tienLuongBinhQuan
        End Get
        Set(ByVal Value As Double)
            _tienLuongBinhQuan = Value
        End Set
    End Property
    Public Property TienLuongThapNhat() As Double
        Get
            Return _tienLuongThapNhat
        End Get
        Set(ByVal Value As Double)
            _tienLuongThapNhat = Value
        End Set
    End Property
    Public Property TienLuongCaoNhat() As Double
        Get
            Return _tienLuongCaoNhat
        End Get
        Set(ByVal Value As Double)
            _tienLuongCaoNhat = Value
        End Set
    End Property
    Public Property DanhGia11KN() As Integer
        Get
            Return _danhGia11KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia11KN = Value
        End Set
    End Property
    Public Property DanhGia11MD() As Integer
        Get
            Return _danhGia11MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia11MD = Value
        End Set
    End Property
    Public Property DanhGia12KN() As Integer
        Get
            Return _danhGia12KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia12KN = Value
        End Set
    End Property
    Public Property DanhGia12MD() As Integer
        Get
            Return _danhGia12MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia12MD = Value
        End Set
    End Property
    Public Property DanhGia13KN() As Integer
        Get
            Return _danhGia13KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia13KN = Value
        End Set
    End Property
    Public Property DanhGia13MD() As Integer
        Get
            Return _danhGia13MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia13MD = Value
        End Set
    End Property
    Public Property DanhGia21KN() As Integer
        Get
            Return _danhGia21KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia21KN = Value
        End Set
    End Property
    Public Property DanhGia21MD() As Integer
        Get
            Return _danhGia21MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia21MD = Value
        End Set
    End Property
    Public Property DanhGia22KN() As Integer
        Get
            Return _danhGia22KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia22KN = Value
        End Set
    End Property
    Public Property DanhGia22MD() As Integer
        Get
            Return _danhGia22MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia22MD = Value
        End Set
    End Property
    Public Property DanhGia23KN() As Integer
        Get
            Return _danhGia23KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia23KN = Value
        End Set
    End Property
    Public Property DanhGia23MD() As Integer
        Get
            Return _danhGia23MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia23MD = Value
        End Set
    End Property
    Public Property DanhGia31KN() As Integer
        Get
            Return _danhGia31KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia31KN = Value
        End Set
    End Property
    Public Property DanhGia31MD() As Integer
        Get
            Return _danhGia31MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia31MD = Value
        End Set
    End Property
    Public Property DanhGia32KN() As Integer
        Get
            Return _danhGia32KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia32KN = Value
        End Set
    End Property
    Public Property DanhGia32MD() As Integer
        Get
            Return _danhGia32MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia32MD = Value
        End Set
    End Property
    Public Property DanhGia33KN() As Integer
        Get
            Return _danhGia33KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia33KN = Value
        End Set
    End Property
    Public Property DanhGia33MD() As Integer
        Get
            Return _danhGia33MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia33MD = Value
        End Set
    End Property
    Public Property DanhGia41KN() As Integer
        Get
            Return _danhGia41KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia41KN = Value
        End Set
    End Property
    Public Property DanhGia41MD() As Integer
        Get
            Return _danhGia41MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia41MD = Value
        End Set
    End Property
    Public Property DanhGia42KN() As Integer
        Get
            Return _danhGia42KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia42KN = Value
        End Set
    End Property
    Public Property DanhGia42MD() As Integer
        Get
            Return _danhGia42MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia42MD = Value
        End Set
    End Property
    Public Property DanhGia43KN() As Integer
        Get
            Return _danhGia43KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia43KN = Value
        End Set
    End Property
    Public Property DanhGia43MD() As Integer
        Get
            Return _danhGia43MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia43MD = Value
        End Set
    End Property
    Public Property DanhGia51KN() As Integer
        Get
            Return _danhGia51KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia51KN = Value
        End Set
    End Property
    Public Property DanhGia51MD() As Integer
        Get
            Return _danhGia51MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia51MD = Value
        End Set
    End Property
    Public Property DanhGia52KN() As Integer
        Get
            Return _danhGia52KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia52KN = Value
        End Set
    End Property
    Public Property DanhGia52MD() As Integer
        Get
            Return _danhGia52MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia52MD = Value
        End Set
    End Property
    Public Property DanhGia53KN() As Integer
        Get
            Return _danhGia53KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia53KN = Value
        End Set
    End Property
    Public Property DanhGia53MD() As Integer
        Get
            Return _danhGia53MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia53MD = Value
        End Set
    End Property
    Public Property DanhGia61KN() As Integer
        Get
            Return _danhGia61KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia61KN = Value
        End Set
    End Property
    Public Property DanhGia61MD() As Integer
        Get
            Return _danhGia61MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia61MD = Value
        End Set
    End Property
    Public Property DanhGia62KN() As Integer
        Get
            Return _danhGia62KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia62KN = Value
        End Set
    End Property
    Public Property DanhGia62MD() As Integer
        Get
            Return _danhGia62MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia62MD = Value
        End Set
    End Property
    Public Property DanhGia63KN() As Integer
        Get
            Return _danhGia63KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia63KN = Value
        End Set
    End Property
    Public Property DanhGia63MD() As Integer
        Get
            Return _danhGia63MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia63MD = Value
        End Set
    End Property
    Public Property DanhGia71KN() As Integer
        Get
            Return _danhGia71KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia71KN = Value
        End Set
    End Property
    Public Property DanhGia71MD() As Integer
        Get
            Return _danhGia71MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia71MD = Value
        End Set
    End Property
    Public Property DanhGia72KN() As Integer
        Get
            Return _danhGia72KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia72KN = Value
        End Set
    End Property
    Public Property DanhGia72MD() As Integer
        Get
            Return _danhGia72MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia72MD = Value
        End Set
    End Property
    Public Property DanhGia73KN() As Integer
        Get
            Return _danhGia73KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia73KN = Value
        End Set
    End Property
    Public Property DanhGia73MD() As Integer
        Get
            Return _danhGia73MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia73MD = Value
        End Set
    End Property
    Public Property DanhGia81KN() As Integer
        Get
            Return _danhGia81KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia81KN = Value
        End Set
    End Property
    Public Property DanhGia81MD() As Integer
        Get
            Return _danhGia81MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia81MD = Value
        End Set
    End Property
    Public Property DanhGia82KN() As Integer
        Get
            Return _danhGia82KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia82KN = Value
        End Set
    End Property
    Public Property DanhGia82MD() As Integer
        Get
            Return _danhGia82MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia82MD = Value
        End Set
    End Property
    Public Property DanhGia83KN() As Integer
        Get
            Return _danhGia83KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia83KN = Value
        End Set
    End Property
    Public Property DanhGia83MD() As Integer
        Get
            Return _danhGia83MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia83MD = Value
        End Set
    End Property
    Public Property DanhGia91KN() As Integer
        Get
            Return _danhGia91KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia91KN = Value
        End Set
    End Property
    Public Property DanhGia91MD() As Integer
        Get
            Return _danhGia91MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia91MD = Value
        End Set
    End Property
    Public Property DanhGia92KN() As Integer
        Get
            Return _danhGia92KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia92KN = Value
        End Set
    End Property
    Public Property DanhGia92MD() As Integer
        Get
            Return _danhGia92MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia92MD = Value
        End Set
    End Property
    Public Property DanhGia93KN() As Integer
        Get
            Return _danhGia93KN
        End Get
        Set(ByVal Value As Integer)
            _danhGia93KN = Value
        End Set
    End Property
    Public Property DanhGia93MD() As Integer
        Get
            Return _danhGia93MD
        End Get
        Set(ByVal Value As Integer)
            _danhGia93MD = Value
        End Set
    End Property
    Public Property NhuCauNNNongLam() As Integer
        Get
            Return _nhuCauNNNongLam
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNNongLam = Value
        End Set
    End Property
    Public Property NhuCauNNNongLamNu() As Integer
        Get
            Return _nhuCauNNNongLamNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNNongLamNu = Value
        End Set
    End Property
    Public Property NhuCauNNCongNghiep() As Integer
        Get
            Return _nhuCauNNCongNghiep
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNCongNghiep = Value
        End Set
    End Property
    Public Property NhuCauNNCongNghiepNu() As Integer
        Get
            Return _nhuCauNNCongNghiepNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNCongNghiepNu = Value
        End Set
    End Property
    Public Property NhuCauNNThuongMai() As Integer
        Get
            Return _nhuCauNNThuongMai
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNThuongMai = Value
        End Set
    End Property
    Public Property NhuCauNNThuongMaiNu() As Integer
        Get
            Return _nhuCauNNThuongMaiNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauNNThuongMaiNu = Value
        End Set
    End Property
    Public Property NhuCauTDLanhDao() As Integer
        Get
            Return _nhuCauTDLanhDao
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDLanhDao = Value
        End Set
    End Property
    Public Property NhuCauTDLanhDaoNu() As Integer
        Get
            Return _nhuCauTDLanhDaoNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDLanhDaoNu = Value
        End Set
    End Property
    Public Property NhuCauTDSoCap() As Integer
        Get
            Return _nhuCauTDSoCap
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDSoCap = Value
        End Set
    End Property
    Public Property NhuCauTDSoCapNu() As Integer
        Get
            Return _nhuCauTDSoCapNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDSoCapNu = Value
        End Set
    End Property
    Public Property NhuCauTDTrungCap() As Integer
        Get
            Return _nhuCauTDTrungCap
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTrungCap = Value
        End Set
    End Property
    Public Property NhuCauTDTrungCapNu() As Integer
        Get
            Return _nhuCauTDTrungCapNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTrungCapNu = Value
        End Set
    End Property
    Public Property NhuCauTDCaoDang() As Integer
        Get
            Return _nhuCauTDCaoDang
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDCaoDang = Value
        End Set
    End Property
    Public Property NhuCauTDCaoDangNu() As Integer
        Get
            Return _nhuCauTDCaoDangNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDCaoDangNu = Value
        End Set
    End Property
    Public Property NhuCauTDDaiHoc() As Integer
        Get
            Return _nhuCauTDDaiHoc
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDDaiHoc = Value
        End Set
    End Property
    Public Property NhuCauTDDaiHocNu() As Integer
        Get
            Return _nhuCauTDDaiHocNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDDaiHocNu = Value
        End Set
    End Property
    Public Property NhuCauLDNNLanhDao() As Integer
        Get
            Return _nhuCauLDNNLanhDao
        End Get
        Set(ByVal Value As Integer)
            _nhuCauLDNNLanhDao = Value
        End Set
    End Property
    Public Property NhuCauTDNNLanhDaoNu() As Integer
        Get
            Return _nhuCauTDNNLanhDaoNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNLanhDaoNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNChuyenMonBC() As Integer
        Get
            Return _nhuCauTDNNChuyenMonBC
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNChuyenMonBC = Value
        End Set
    End Property
    Public Property NhuCauTDNNChuyenMonBCNu() As Integer
        Get
            Return _nhuCauTDNNChuyenMonBCNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNChuyenMonBCNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNChuyenMocBT() As Integer
        Get
            Return _nhuCauTDNNChuyenMocBT
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNChuyenMocBT = Value
        End Set
    End Property
    Public Property NhuCauTDNNChuyenMonBTNu() As Integer
        Get
            Return _nhuCauTDNNChuyenMonBTNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNChuyenMonBTNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNNhanVienNN() As Integer
        Get
            Return _nhuCauTDNNNhanVienNN
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNNhanVienNN = Value
        End Set
    End Property
    Public Property NhuCauTDNNNhanVienNNNu() As Integer
        Get
            Return _nhuCauTDNNNhanVienNNNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNNhanVienNNNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNNhanVienDV() As Integer
        Get
            Return _nhuCauTDNNNhanVienDV
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNNhanVienDV = Value
        End Set
    End Property
    Public Property NhuCauTDNNNhanVienDVNu() As Integer
        Get
            Return _nhuCauTDNNNhanVienDVNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNNhanVienDVNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNLaoDongKT() As Integer
        Get
            Return _nhuCauTDNNLaoDongKT
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNLaoDongKT = Value
        End Set
    End Property
    Public Property NhuCauTDNNLaoDongKTNu() As Integer
        Get
            Return _nhuCauTDNNLaoDongKTNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNLaoDongKTNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNThoTC() As Integer
        Get
            Return _nhuCauTDNNThoTC
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNThoTC = Value
        End Set
    End Property
    Public Property NhuCauTDNNThoTCNu() As Integer
        Get
            Return _nhuCauTDNNThoTCNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNThoTCNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNThoKT() As Integer
        Get
            Return _nhuCauTDNNThoKT
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNThoKT = Value
        End Set
    End Property
    Public Property NhuCauTDNNThoKTNu() As Integer
        Get
            Return _nhuCauTDNNThoKTNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNThoKTNu = Value
        End Set
    End Property
    Public Property NhuCauTDNNLaoDongPT() As Integer
        Get
            Return _nhuCauTDNNLaoDongPT
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNLaoDongPT = Value
        End Set
    End Property
    Public Property NhuCauTDNNLaoDongPTNu() As Integer
        Get
            Return _nhuCauTDNNLaoDongPTNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDNNLaoDongPTNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengAnh() As Integer
        Get
            Return _nhuCauTDTDTiengAnh
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengAnh = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengAnhNu() As Integer
        Get
            Return _nhuCauTDTDTiengAnhNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengAnhNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengTrung() As Integer
        Get
            Return _nhuCauTDTDTiengTrung
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengTrung = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengTrungNu() As Integer
        Get
            Return _nhuCauTDTDTiengTrungNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengTrungNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengHN() As Integer
        Get
            Return _nhuCauTDTDTiengHN
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengHN = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengHNNu() As Integer
        Get
            Return _nhuCauTDTDTiengHNNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengHNNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengKhac() As Integer
        Get
            Return _nhuCauTDTDTiengKhac
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengKhac = Value
        End Set
    End Property
    Public Property NhuCauTDTDTiengKhacNu() As Integer
        Get
            Return _nhuCauTDTDTiengKhacNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTiengKhacNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocCB() As Integer
        Get
            Return _nhuCauTDTDTinHocCB
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocCB = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocCBNu() As Integer
        Get
            Return _nhuCauTDTDTinHocCBNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocCBNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocNC() As Integer
        Get
            Return _nhuCauTDTDTinHocNC
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocNC = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocNCNu() As Integer
        Get
            Return _nhuCauTDTDTinHocNCNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocNCNu = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocNC2() As Integer
        Get
            Return _nhuCauTDTDTinHocNC2
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocNC2 = Value
        End Set
    End Property
    Public Property NhuCauTDTDTinHocNC2Nu() As Integer
        Get
            Return _nhuCauTDTDTinHocNC2Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDTDTinHocNC2Nu = Value
        End Set
    End Property
    Public Property NhuCauTDMLThoaThuan() As Integer
        Get
            Return _nhuCauTDMLThoaThuan
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDMLThoaThuan = Value
        End Set
    End Property
    Public Property NhuCauTDMLThoaThuanNu() As Integer
        Get
            Return _nhuCauTDMLThoaThuanNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDMLThoaThuanNu = Value
        End Set
    End Property
    Public Property NhuCauTDML3() As Integer
        Get
            Return _nhuCauTDML3
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML3 = Value
        End Set
    End Property
    Public Property NhuCauTDML3Nu() As Integer
        Get
            Return _nhuCauTDML3Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML3Nu = Value
        End Set
    End Property
    Public Property NhuCauTDML5() As Integer
        Get
            Return _nhuCauTDML5
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML5 = Value
        End Set
    End Property
    Public Property NhuCauTDML5Nu() As Integer
        Get
            Return _nhuCauTDML5Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML5Nu = Value
        End Set
    End Property
    Public Property NhuCauTDML7() As Integer
        Get
            Return _nhuCauTDML7
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML7 = Value
        End Set
    End Property
    Public Property NhuCauTDML7Nu() As Integer
        Get
            Return _nhuCauTDML7Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML7Nu = Value
        End Set
    End Property
    Public Property NhuCauTDML10() As Integer
        Get
            Return _nhuCauTDML10
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML10 = Value
        End Set
    End Property
    Public Property NhuCauTDML10Nu() As Integer
        Get
            Return _nhuCauTDML10Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML10Nu = Value
        End Set
    End Property
    Public Property NhuCauTDML15() As Integer
        Get
            Return _nhuCauTDML15
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML15 = Value
        End Set
    End Property
    Public Property NhuCauTDML15Nu() As Integer
        Get
            Return _nhuCauTDML15Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTDML15Nu = Value
        End Set
    End Property
    Public Property NhuCauTBKNChua() As Integer
        Get
            Return _nhuCauTBKNChua
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKNChua = Value
        End Set
    End Property
    Public Property NhuCauTBKNChuaNu() As Integer
        Get
            Return _nhuCauTBKNChuaNu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKNChuaNu = Value
        End Set
    End Property
    Public Property NhuCauTBKN1() As Integer
        Get
            Return _nhuCauTBKN1
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN1 = Value
        End Set
    End Property
    Public Property NhuCauTBKN1Nu() As Integer
        Get
            Return _nhuCauTBKN1Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN1Nu = Value
        End Set
    End Property
    Public Property NhuCauTBKN3() As Integer
        Get
            Return _nhuCauTBKN3
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN3 = Value
        End Set
    End Property
    Public Property NhuCauTBKN3Nu() As Integer
        Get
            Return _nhuCauTBKN3Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN3Nu = Value
        End Set
    End Property
    Public Property NhuCauTBKN5() As Integer
        Get
            Return _nhuCauTBKN5
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN5 = Value
        End Set
    End Property
    Public Property NhuCauTBKN5Nu() As Integer
        Get
            Return _nhuCauTBKN5Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN5Nu = Value
        End Set
    End Property
    Public Property NhuCauTBKN10() As Integer
        Get
            Return _nhuCauTBKN10
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN10 = Value
        End Set
    End Property
    Public Property NhuCauTBKN10Nu() As Integer
        Get
            Return _nhuCauTBKN10Nu
        End Get
        Set(ByVal Value As Integer)
            _nhuCauTBKN10Nu = Value
        End Set
    End Property
    Public Property KhoKhanTDLD() As Boolean
        Get
            Return _khoKhanTDLD
        End Get
        Set(ByVal Value As Boolean)
            _khoKhanTDLD = Value
        End Set
    End Property
    Public Property KhoKhanPhiaLD() As String
        Get
            Return _khoKhanPhiaLD
        End Get
        Set(ByVal Value As String)
            _khoKhanPhiaLD = Value
        End Set
    End Property
    Public Property KhoKhanPhiaDN() As String
        Get
            Return _khoKhanPhiaDN
        End Get
        Set(ByVal Value As String)
            _khoKhanPhiaDN = Value
        End Set
    End Property
    Public Property KhoKhanPhiaDNKhac() As String
        Get
            Return _khoKhanPhiaDNKhac
        End Get
        Set(ByVal Value As String)
            _khoKhanPhiaDNKhac = Value
        End Set
    End Property
    Public Property NhomTrinhDoCMKT() As String
        Get
            Return _nhomTrinhDoCMKT
        End Get
        Set(ByVal Value As String)
            _nhomTrinhDoCMKT = Value
        End Set
    End Property
    Public Property NhomNgheKTD() As String
        Get
            Return _nhomNgheKTD
        End Get
        Set(ByVal Value As String)
            _nhomNgheKTD = Value
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
    Public Property HinhThucTuyenDungKhac() As String
        Get
            Return _hinhThucTuyenDungKhac
        End Get
        Set(ByVal Value As String)
            _hinhThucTuyenDungKhac = Value
        End Set
    End Property
    Public Property TungLienKet() As Boolean
        Get
            Return _tungLienKet
        End Get
        Set(ByVal Value As Boolean)
            _tungLienKet = Value
        End Set
    End Property
    Public Property DaHopTac() As String
        Get
            Return _daHopTac
        End Get
        Set(ByVal Value As String)
            _daHopTac = Value
        End Set
    End Property
    Public Property DaHopTacKhac() As String
        Get
            Return _daHopTacKhac
        End Get
        Set(ByVal Value As String)
            _daHopTacKhac = Value
        End Set
    End Property
    Public Property KhoKhanVuongMac() As String
        Get
            Return _khoKhanVuongMac
        End Get
        Set(ByVal Value As String)
            _khoKhanVuongMac = Value
        End Set
    End Property
    Public Property KhuyenNghi() As String
        Get
            Return _khuyenNghi
        End Get
        Set(ByVal Value As String)
            _khuyenNghi = Value
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

Public Class InputNLD2024Info

#Region "Private Members"
    Private _iD As String = String.Empty
    Private _thangKhaoSat As Integer
    Private _namKhaoSat As Integer
    Private _maPhieuTuDong As String = String.Empty
    Private _soThuTu As Integer
    Private _hoTen As String = String.Empty
    Private _cCCD As String = String.Empty
    Private _namSinh As DateTime
    Private _gioiTinh As Short
    Private _danToc As String = String.Empty
    Private _maTinh As Integer
    Private _maHuyen As Integer
    Private _maXa As Integer
    Private _maThon As Integer
    Private _maTinh_HT As Integer
    Private _maHuyen_HT As Integer
    Private _maXa_HT As Integer
    Private _maThon_HT As Integer
    Private _diaChi_HT As String = String.Empty
    Private _soDienThoai As String = String.Empty
    Private _email As String = String.Empty
    Private _lienHeKhac As String = String.Empty
    Private _doiTuongUuTien As String = String.Empty
    Private _doiTuongUuTienKhac As String = String.Empty
    Private _trinhDoHocVan As Short
    Private _trinhDoCMKyThuat As Integer
    Private _chuyenNganhDT As String = String.Empty
    Private _trinhDoNN1 As String = String.Empty
    Private _chungChiNN1 As String = String.Empty
    Private _khaNangNN1 As Integer
    Private _trinhDoNN2 As String = String.Empty
    Private _chungChiNN2 As String = String.Empty
    Private _khaNangNN2 As Integer
    Private _trinhDoTHVP As String = String.Empty
    Private _khaNangTHVP As Integer
    Private _trinhDoTHKhac As String = String.Empty
    Private _khaNangTHKhac As Integer
    Private _kyNangMem As String = String.Empty
    Private _kyNangMemKhac As String = String.Empty
    Private _daTungDiLam As Boolean
    Private _daTungDiLamNote As String = String.Empty
    Private _mucLuong As Integer
    Private _viTriViecLam As Integer
    Private _viTriCongViec As Boolean
    Private _kenhTimKiem As String = String.Empty
    Private _kenhTimKiemKhac As String = String.Empty
    Private _lamViecONN As Boolean
    Private _lamViecONNNote As String = String.Empty
    Private _tinhTrangViecLam As Integer
    Private _tinhTrangViecLamNote As String = String.Empty
    Private _nguyenNhanCTVL As String = String.Empty
    Private _nguyenNhanCTVLKhac As String = String.Empty
    Private _lyDoPGDVL As String = String.Empty
    Private _lyDoPGDVLKhac As String = String.Empty
    Private _suDungWeb As Short
    Private _webBoCuc As String = String.Empty
    Private _webNoiDung As String = String.Empty
    Private _webKhac As String = String.Empty
    Private _kienNghiPhucVu As String = String.Empty
    Private _diaDiemMongMuon As Boolean
    Private _thoiGianToChuc As Short
    Private _thoiGianToChucKhac As String = String.Empty
    Private _tungThamGia As Boolean
    Private _nhuCauViecLam As Boolean
    Private _loaiHinhDN As Short
    Private _mongMuonLamViec As String = String.Empty
    Private _tenCongViec As String = String.Empty
    Private _moTaCongViec As String = String.Empty
    Private _kinhNghiemCongViec As Boolean
    Private _kinhNghiemBLCongViec As Short
    Private _chucVuMongMuon As Integer
    Private _chucVuMongMuonKhac As String = String.Empty
    Private _diaBanMongMuon As Short
    Private _diaBanMaTinh As Integer
    Private _diaBanMaHuyen As Integer
    Private _loaiHopDong As Integer
    Private _dapUngCongViec As Integer
    Private _hinhThucLamViec As Boolean
    Private _mucDinhLamViec As Short
    Private _mucLuongMongMuon As Integer
    Private _cheDoPhucLoi As String = String.Empty
    Private _cheDoPhucLoiKhac As String = String.Empty
    Private _duKienLamViec As Boolean
    Private _duKienLamViecSau As Short
    Private _hinhThucTuyenDung As Integer
    Private _nhuCauXKLD As Boolean
    Private _nhuCauXKLDNuoc As Integer
    Private _congViecMongMuonXKLD As String = String.Empty
    Private _congViecMongMuonXKLDNote As String = String.Empty
    Private _mucLuongXKLD As Double
    Private _nhuCauHocNghe As Boolean
    Private _nhuCauHocNgheNote As String = String.Empty
    Private _thoiGianHocNghe As Boolean
    Private _nhuCauNguyenVongKhac As String = String.Empty
    Private _createdDate As DateTime
    Private _createdUser As String = String.Empty
    Private _updatedDate As DateTime
    Private _updatedUser As String = String.Empty
    Private _isDelete As Boolean
    Private _deletedDate As DateTime
    Private _deletedUser As String = String.Empty
    Private _portalID As Byte
    Private _isFlag As Byte
    Private _total As Integer
    Private _ngayCapNhat As DateTime
    Private _tinhTrangViecLamDetail As String = String.Empty
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

    Public Property ThangKhaoSat() As Integer
        Get
            Return _thangKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _thangKhaoSat = Value
        End Set
    End Property
    Public Property NamKhaoSat() As Integer
        Get
            Return _namKhaoSat
        End Get
        Set(ByVal Value As Integer)
            _namKhaoSat = Value
        End Set
    End Property
    Public Property MaPhieuTuDong() As String
        Get
            Return _maPhieuTuDong
        End Get
        Set(ByVal Value As String)
            _maPhieuTuDong = Value
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
    Public Property CCCD() As String
        Get
            Return _cCCD
        End Get
        Set(ByVal Value As String)
            _cCCD = Value
        End Set
    End Property
    Public Property NamSinh() As DateTime
        Get
            Return _namSinh
        End Get
        Set(ByVal Value As DateTime)
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
    Public Property MaTinh_HT() As Integer
        Get
            Return _maTinh_HT
        End Get
        Set(ByVal Value As Integer)
            _maTinh_HT = Value
        End Set
    End Property
    Public Property MaHuyen_HT() As Integer
        Get
            Return _maHuyen_HT
        End Get
        Set(ByVal Value As Integer)
            _maHuyen_HT = Value
        End Set
    End Property
    Public Property MaXa_HT() As Integer
        Get
            Return _maXa_HT
        End Get
        Set(ByVal Value As Integer)
            _maXa_HT = Value
        End Set
    End Property
    Public Property MaThon_HT() As Integer
        Get
            Return _maThon_HT
        End Get
        Set(ByVal Value As Integer)
            _maThon_HT = Value
        End Set
    End Property
    Public Property DiaChi_HT() As String
        Get
            Return _diaChi_HT
        End Get
        Set(ByVal Value As String)
            _diaChi_HT = Value
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
    Public Property DoiTuongUuTien() As String
        Get
            Return _doiTuongUuTien
        End Get
        Set(ByVal Value As String)
            _doiTuongUuTien = Value
        End Set
    End Property
    Public Property DoiTuongUuTienKhac() As String
        Get
            Return _doiTuongUuTienKhac
        End Get
        Set(ByVal Value As String)
            _doiTuongUuTienKhac = Value
        End Set
    End Property
    Public Property TrinhDoHocVan() As Short
        Get
            Return _trinhDoHocVan
        End Get
        Set(ByVal Value As Short)
            _trinhDoHocVan = Value
        End Set
    End Property
    Public Property TrinhDoCMKyThuat() As Integer
        Get
            Return _trinhDoCMKyThuat
        End Get
        Set(ByVal Value As Integer)
            _trinhDoCMKyThuat = Value
        End Set
    End Property
    Public Property ChuyenNganhDT() As String
        Get
            Return _chuyenNganhDT
        End Get
        Set(ByVal Value As String)
            _chuyenNganhDT = Value
        End Set
    End Property
    Public Property TrinhDoNN1() As String
        Get
            Return _trinhDoNN1
        End Get
        Set(ByVal Value As String)
            _trinhDoNN1 = Value
        End Set
    End Property
    Public Property ChungChiNN1() As String
        Get
            Return _chungChiNN1
        End Get
        Set(ByVal Value As String)
            _chungChiNN1 = Value
        End Set
    End Property
    Public Property KhaNangNN1() As Integer
        Get
            Return _khaNangNN1
        End Get
        Set(ByVal Value As Integer)
            _khaNangNN1 = Value
        End Set
    End Property
    Public Property TrinhDoNN2() As String
        Get
            Return _trinhDoNN2
        End Get
        Set(ByVal Value As String)
            _trinhDoNN2 = Value
        End Set
    End Property
    Public Property ChungChiNN2() As String
        Get
            Return _chungChiNN2
        End Get
        Set(ByVal Value As String)
            _chungChiNN2 = Value
        End Set
    End Property
    Public Property KhaNangNN2() As Integer
        Get
            Return _khaNangNN2
        End Get
        Set(ByVal Value As Integer)
            _khaNangNN2 = Value
        End Set
    End Property
    Public Property TrinhDoTHVP() As String
        Get
            Return _trinhDoTHVP
        End Get
        Set(ByVal Value As String)
            _trinhDoTHVP = Value
        End Set
    End Property
    Public Property KhaNangTHVP() As Integer
        Get
            Return _khaNangTHVP
        End Get
        Set(ByVal Value As Integer)
            _khaNangTHVP = Value
        End Set
    End Property
    Public Property TrinhDoTHKhac() As String
        Get
            Return _trinhDoTHKhac
        End Get
        Set(ByVal Value As String)
            _trinhDoTHKhac = Value
        End Set
    End Property
    Public Property KhaNangTHKhac() As Integer
        Get
            Return _khaNangTHKhac
        End Get
        Set(ByVal Value As Integer)
            _khaNangTHKhac = Value
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
    Public Property KyNangMemKhac() As String
        Get
            Return _kyNangMemKhac
        End Get
        Set(ByVal Value As String)
            _kyNangMemKhac = Value
        End Set
    End Property
    Public Property DaTungDiLam() As Boolean
        Get
            Return _daTungDiLam
        End Get
        Set(ByVal Value As Boolean)
            _daTungDiLam = Value
        End Set
    End Property
    Public Property DaTungDiLamNote() As String
        Get
            Return _daTungDiLamNote
        End Get
        Set(ByVal Value As String)
            _daTungDiLamNote = Value
        End Set
    End Property
    Public Property MucLuong() As Integer
        Get
            Return _mucLuong
        End Get
        Set(ByVal Value As Integer)
            _mucLuong = Value
        End Set
    End Property
    Public Property ViTriViecLam() As Integer
        Get
            Return _viTriViecLam
        End Get
        Set(ByVal Value As Integer)
            _viTriViecLam = Value
        End Set
    End Property
    Public Property ViTriCongViec() As Boolean
        Get
            Return _viTriCongViec
        End Get
        Set(ByVal Value As Boolean)
            _viTriCongViec = Value
        End Set
    End Property
    Public Property KenhTimKiem() As String
        Get
            Return _kenhTimKiem
        End Get
        Set(ByVal Value As String)
            _kenhTimKiem = Value
        End Set
    End Property
    Public Property KenhTimKiemKhac() As String
        Get
            Return _kenhTimKiemKhac
        End Get
        Set(ByVal Value As String)
            _kenhTimKiemKhac = Value
        End Set
    End Property
    Public Property LamViecONN() As Boolean
        Get
            Return _lamViecONN
        End Get
        Set(ByVal Value As Boolean)
            _lamViecONN = Value
        End Set
    End Property
    Public Property LamViecONNNote() As String
        Get
            Return _lamViecONNNote
        End Get
        Set(ByVal Value As String)
            _lamViecONNNote = Value
        End Set
    End Property
    Public Property TinhTrangViecLam() As Integer
        Get
            Return _tinhTrangViecLam
        End Get
        Set(ByVal Value As Integer)
            _tinhTrangViecLam = Value
        End Set
    End Property
    Public Property TinhTrangViecLamNote() As String
        Get
            Return _tinhTrangViecLamNote
        End Get
        Set(ByVal Value As String)
            _tinhTrangViecLamNote = Value
        End Set
    End Property
    Public Property NguyenNhanCTVL() As String
        Get
            Return _nguyenNhanCTVL
        End Get
        Set(ByVal Value As String)
            _nguyenNhanCTVL = Value
        End Set
    End Property
    Public Property NguyenNhanCTVLKhac() As String
        Get
            Return _nguyenNhanCTVLKhac
        End Get
        Set(ByVal Value As String)
            _nguyenNhanCTVLKhac = Value
        End Set
    End Property
    Public Property LyDoPGDVL() As String
        Get
            Return _lyDoPGDVL
        End Get
        Set(ByVal Value As String)
            _lyDoPGDVL = Value
        End Set
    End Property
    Public Property LyDoPGDVLKhac() As String
        Get
            Return _lyDoPGDVLKhac
        End Get
        Set(ByVal Value As String)
            _lyDoPGDVLKhac = Value
        End Set
    End Property
    Public Property SuDungWeb() As Short
        Get
            Return _suDungWeb
        End Get
        Set(ByVal Value As Short)
            _suDungWeb = Value
        End Set
    End Property
    Public Property WebBoCuc() As String
        Get
            Return _webBoCuc
        End Get
        Set(ByVal Value As String)
            _webBoCuc = Value
        End Set
    End Property
    Public Property WebNoiDung() As String
        Get
            Return _webNoiDung
        End Get
        Set(ByVal Value As String)
            _webNoiDung = Value
        End Set
    End Property
    Public Property WebKhac() As String
        Get
            Return _webKhac
        End Get
        Set(ByVal Value As String)
            _webKhac = Value
        End Set
    End Property
    Public Property KienNghiPhucVu() As String
        Get
            Return _kienNghiPhucVu
        End Get
        Set(ByVal Value As String)
            _kienNghiPhucVu = Value
        End Set
    End Property
    Public Property DiaDiemMongMuon() As Boolean
        Get
            Return _diaDiemMongMuon
        End Get
        Set(ByVal Value As Boolean)
            _diaDiemMongMuon = Value
        End Set
    End Property
    Public Property ThoiGianToChuc() As Short
        Get
            Return _thoiGianToChuc
        End Get
        Set(ByVal Value As Short)
            _thoiGianToChuc = Value
        End Set
    End Property
    Public Property ThoiGianToChucKhac() As String
        Get
            Return _thoiGianToChucKhac
        End Get
        Set(ByVal Value As String)
            _thoiGianToChucKhac = Value
        End Set
    End Property
    Public Property TungThamGia() As Boolean
        Get
            Return _tungThamGia
        End Get
        Set(ByVal Value As Boolean)
            _tungThamGia = Value
        End Set
    End Property
    Public Property NhuCauViecLam() As Boolean
        Get
            Return _nhuCauViecLam
        End Get
        Set(ByVal Value As Boolean)
            _nhuCauViecLam = Value
        End Set
    End Property
    Public Property LoaiHinhDN() As Short
        Get
            Return _loaiHinhDN
        End Get
        Set(ByVal Value As Short)
            _loaiHinhDN = Value
        End Set
    End Property
    Public Property MongMuonLamViec() As String
        Get
            Return _mongMuonLamViec
        End Get
        Set(ByVal Value As String)
            _mongMuonLamViec = Value
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
    Public Property KinhNghiemCongViec() As Boolean
        Get
            Return _kinhNghiemCongViec
        End Get
        Set(ByVal Value As Boolean)
            _kinhNghiemCongViec = Value
        End Set
    End Property
    Public Property KinhNghiemBLCongViec() As Short
        Get
            Return _kinhNghiemBLCongViec
        End Get
        Set(ByVal Value As Short)
            _kinhNghiemBLCongViec = Value
        End Set
    End Property
    Public Property ChucVuMongMuon() As Integer
        Get
            Return _chucVuMongMuon
        End Get
        Set(ByVal Value As Integer)
            _chucVuMongMuon = Value
        End Set
    End Property
    Public Property ChucVuMongMuonKhac() As String
        Get
            Return _chucVuMongMuonKhac
        End Get
        Set(ByVal Value As String)
            _chucVuMongMuonKhac = Value
        End Set
    End Property
    Public Property DiaBanMongMuon() As Short
        Get
            Return _diaBanMongMuon
        End Get
        Set(ByVal Value As Short)
            _diaBanMongMuon = Value
        End Set
    End Property
    Public Property DiaBanMaTinh() As Integer
        Get
            Return _diaBanMaTinh
        End Get
        Set(ByVal Value As Integer)
            _diaBanMaTinh = Value
        End Set
    End Property
    Public Property DiaBanMaHuyen() As Integer
        Get
            Return _diaBanMaHuyen
        End Get
        Set(ByVal Value As Integer)
            _diaBanMaHuyen = Value
        End Set
    End Property
    Public Property LoaiHopDong() As Integer
        Get
            Return _loaiHopDong
        End Get
        Set(ByVal Value As Integer)
            _loaiHopDong = Value
        End Set
    End Property
    Public Property DapUngCongViec() As Integer
        Get
            Return _dapUngCongViec
        End Get
        Set(ByVal Value As Integer)
            _dapUngCongViec = Value
        End Set
    End Property
    Public Property HinhThucLamViec() As Boolean
        Get
            Return _hinhThucLamViec
        End Get
        Set(ByVal Value As Boolean)
            _hinhThucLamViec = Value
        End Set
    End Property
    Public Property MucDinhLamViec() As Short
        Get
            Return _mucDinhLamViec
        End Get
        Set(ByVal Value As Short)
            _mucDinhLamViec = Value
        End Set
    End Property
    Public Property MucLuongMongMuon() As Integer
        Get
            Return _mucLuongMongMuon
        End Get
        Set(ByVal Value As Integer)
            _mucLuongMongMuon = Value
        End Set
    End Property
    Public Property CheDoPhucLoi() As String
        Get
            Return _cheDoPhucLoi
        End Get
        Set(ByVal Value As String)
            _cheDoPhucLoi = Value
        End Set
    End Property
    Public Property CheDoPhucLoiKhac() As String
        Get
            Return _cheDoPhucLoiKhac
        End Get
        Set(ByVal Value As String)
            _cheDoPhucLoiKhac = Value
        End Set
    End Property
    Public Property DuKienLamViec() As Boolean
        Get
            Return _duKienLamViec
        End Get
        Set(ByVal Value As Boolean)
            _duKienLamViec = Value
        End Set
    End Property
    Public Property DuKienLamViecSau() As Short
        Get
            Return _duKienLamViecSau
        End Get
        Set(ByVal Value As Short)
            _duKienLamViecSau = Value
        End Set
    End Property
    Public Property HinhThucTuyenDung() As Integer
        Get
            Return _hinhThucTuyenDung
        End Get
        Set(ByVal Value As Integer)
            _hinhThucTuyenDung = Value
        End Set
    End Property
    Public Property NhuCauXKLD() As Boolean
        Get
            Return _nhuCauXKLD
        End Get
        Set(ByVal Value As Boolean)
            _nhuCauXKLD = Value
        End Set
    End Property
    Public Property NhuCauXKLDNuoc() As Integer
        Get
            Return _nhuCauXKLDNuoc
        End Get
        Set(ByVal Value As Integer)
            _nhuCauXKLDNuoc = Value
        End Set
    End Property
    Public Property CongViecMongMuonXKLD() As String
        Get
            Return _congViecMongMuonXKLD
        End Get
        Set(ByVal Value As String)
            _congViecMongMuonXKLD = Value
        End Set
    End Property
    Public Property CongViecMongMuonXKLDNote() As String
        Get
            Return _congViecMongMuonXKLDNote
        End Get
        Set(ByVal Value As String)
            _congViecMongMuonXKLDNote = Value
        End Set
    End Property
    Public Property MucLuongXKLD() As Double
        Get
            Return _mucLuongXKLD
        End Get
        Set(ByVal Value As Double)
            _mucLuongXKLD = Value
        End Set
    End Property
    Public Property NhuCauHocNghe() As Boolean
        Get
            Return _nhuCauHocNghe
        End Get
        Set(ByVal Value As Boolean)
            _nhuCauHocNghe = Value
        End Set
    End Property
    Public Property NhuCauHocNgheNote() As String
        Get
            Return _nhuCauHocNgheNote
        End Get
        Set(ByVal Value As String)
            _nhuCauHocNgheNote = Value
        End Set
    End Property
    Public Property ThoiGianHocNghe() As Boolean
        Get
            Return _thoiGianHocNghe
        End Get
        Set(ByVal Value As Boolean)
            _thoiGianHocNghe = Value
        End Set
    End Property
    Public Property NhuCauNguyenVongKhac() As String
        Get
            Return _nhuCauNguyenVongKhac
        End Get
        Set(ByVal Value As String)
            _nhuCauNguyenVongKhac = Value
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
    Public Property PortalID() As Byte
        Get
            Return _portalID
        End Get
        Set(ByVal Value As Byte)
            _portalID = Value
        End Set
    End Property
    Public Property IsFlag() As Byte
        Get
            Return _isFlag
        End Get
        Set(ByVal Value As Byte)
            _isFlag = Value
        End Set
    End Property
    Public Property NgayCapNhat() As DateTime
        Get
            Return _ngayCapNhat
        End Get
        Set(ByVal Value As DateTime)
            _ngayCapNhat = Value
        End Set
    End Property
    Public Property TinhTrangViecLamDetail() As String
        Get
            Return _tinhTrangViecLamDetail
        End Get
        Set(ByVal Value As String)
            _tinhTrangViecLamDetail = Value
        End Set
    End Property
#End Region

End Class

Public Class HT_DisplayHomeInfo

#Region "Private Members"
    Private _iD As Integer
    Private _groupID As Integer
    Private _GroupName As String
    Private _targetID As Integer
    Private _isTable As Boolean
    Private _isChart As Boolean
    Private _typeChart As Short
    Private _isOrder As Integer
    Private _isActive As Boolean
    Private _total As Integer
    Private _TargetName As String
    Private _YearFrom As Integer
    Private _YearTo As Integer
    Private _TotalYear As Integer
    Private _Method As Integer
#End Region

#Region "Public Properties"

    Public Property Method As Integer
        Get
            Return _Method
        End Get
        Set(ByVal Value As Integer)
            _Method = Value
        End Set
    End Property

    Public Property TotalYear As Integer
        Get
            Return _TotalYear
        End Get
        Set(ByVal Value As Integer)
            _TotalYear = Value
        End Set
    End Property

    Public Property YearTo As Integer
        Get
            Return _YearTo
        End Get
        Set(ByVal Value As Integer)
            _YearTo = Value
        End Set
    End Property

    Public Property YearFrom As Integer
        Get
            Return _YearFrom
        End Get
        Set(ByVal Value As Integer)
            _YearFrom = Value
        End Set
    End Property
    Public Property GroupName As String
        Get
            Return _GroupName
        End Get
        Set(ByVal Value As String)
            _GroupName = Value
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

    Public Property GroupID() As Integer
        Get
            Return _groupID
        End Get
        Set(ByVal Value As Integer)
            _groupID = Value
        End Set
    End Property
    Public Property TargetName() As String
        Get
            Return _TargetName
        End Get
        Set(ByVal Value As String)
            _TargetName = Value
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
    Public Property IsTable() As Boolean
        Get
            Return _isTable
        End Get
        Set(ByVal Value As Boolean)
            _isTable = Value
        End Set
    End Property
    Public Property IsChart() As Boolean
        Get
            Return _isChart
        End Get
        Set(ByVal Value As Boolean)
            _isChart = Value
        End Set
    End Property
    Public Property TypeChart() As Short
        Get
            Return _typeChart
        End Get
        Set(ByVal Value As Short)
            _typeChart = Value
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








