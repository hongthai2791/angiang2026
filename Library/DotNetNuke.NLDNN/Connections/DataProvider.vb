Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.NLDNN", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_Provide_History"
    Public MustOverride Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_History_List(tpConnect As String) As IDataReader

    Public MustOverride Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
    Public MustOverride Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
    Public MustOverride Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)

    Public MustOverride Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, huyen As Integer, xa As Integer, maDvi As Integer) As IDataReader
#End Region
#Region "CMS_NLD"
    Public MustOverride Sub CMS_NLD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)

    Public MustOverride Function CMS_NLD_Get(PortalConnect As String, nguoiLD_ID As String) As IDataReader
    Public MustOverride Function CMS_NLD_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_NLD_Add(PortalConnect As String, obj As CMS_NLDInfo) As Integer
    Public MustOverride Sub CMS_NLD_Update(PortalConnect As String, obj As CMS_NLDInfo)
    Public MustOverride Sub CMS_NLD_Delete(PortalConnect As String, nguoiLD_ID As Integer)
    Public MustOverride Sub CMS_NLD_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_NLD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
    Public MustOverride Function CMS_NLD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, yearCreated As Integer, quocTich As String, gioiTinh As Integer) As IDataReader

#End Region
#Region "CMS_NLD_Backup"
    Public MustOverride Function CMS_NLD_Backup_Get(PortalConnect As String, nguoiLD_ID As Integer) As IDataReader
    Public MustOverride Function CMS_NLD_Backup_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_NLD_Backup_Add(PortalConnect As String, obj As CMS_NLD_BackupInfo) As Integer
    Public MustOverride Sub CMS_NLD_Backup_Update(PortalConnect As String, obj As CMS_NLD_BackupInfo)
    Public MustOverride Sub CMS_NLD_Backup_Delete(PortalConnect As String, nguoiLD_ID As Integer)
    Public MustOverride Sub CMS_NLD_Backup_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_Provide_Config"
    Public MustOverride Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, isActive As Boolean) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get_Value(tpConnect As String, TinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinh As Integer) As IDataReader
    Public MustOverride Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
    Public MustOverride Sub CMS_Provide_Config_Add(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub CMS_Provide_Config_Update(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer)
    Public MustOverride Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
#End Region
#Region "DM_ChuyenMonDT"
    Public MustOverride Function DM_ChuyenMonDT_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_ChuyenMonDT_List(PortalConnect As String) As IDataReader

    Public MustOverride Function DM_ChuyenMonDT_Add(PortalConnect As String, obj As DM_ChuyenMonDTInfo) As Integer
    Public MustOverride Sub DM_ChuyenMonDT_Update(PortalConnect As String, obj As DM_ChuyenMonDTInfo)
    Public MustOverride Sub DM_ChuyenMonDT_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub DM_ChuyenMonDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DM_HinhThucLV"
    Public MustOverride Function DM_HinhThucLV_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_HinhThucLV_List(PortalConnect As String) As IDataReader

    Public MustOverride Function DM_HinhThucLV_Add(PortalConnect As String, obj As DM_HinhThucLVInfo) As Integer
    Public MustOverride Sub DM_HinhThucLV_Update(PortalConnect As String, obj As DM_HinhThucLVInfo)
    Public MustOverride Sub DM_HinhThucLV_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub DM_HinhThucLV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DM_NgheCongViec"
    Public MustOverride Function DM_NgheCongViec_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_NgheCongViec_List(PortalConnect As String) As IDataReader

    Public MustOverride Function DM_NgheCongViec_Add(PortalConnect As String, obj As DM_NgheCongViecInfo) As Integer
    Public MustOverride Sub DM_NgheCongViec_Update(PortalConnect As String, obj As DM_NgheCongViecInfo)
    Public MustOverride Sub DM_NgheCongViec_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub DM_NgheCongViec_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DM_TrinhDoDT"
    Public MustOverride Function DM_TrinhDoDT_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_TrinhDoDT_List(PortalConnect As String) As IDataReader

    Public MustOverride Function DM_TrinhDoDT_Add(PortalConnect As String, obj As DM_TrinhDoDTInfo) As Integer
    Public MustOverride Sub DM_TrinhDoDT_Update(PortalConnect As String, obj As DM_TrinhDoDTInfo)
    Public MustOverride Sub DM_TrinhDoDT_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub DM_TrinhDoDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DM_ViTriCV"
    Public MustOverride Function DM_ViTriCV_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function DM_ViTriCV_List(PortalConnect As String) As IDataReader

    Public MustOverride Function DM_ViTriCV_Add(PortalConnect As String, obj As DM_ViTriCVInfo) As Integer
    Public MustOverride Sub DM_ViTriCV_Update(PortalConnect As String, obj As DM_ViTriCVInfo)
    Public MustOverride Sub DM_ViTriCV_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub DM_ViTriCV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "REPORT CHART"
    Public MustOverride Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
    Public MustOverride Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader

#End Region
End Class
