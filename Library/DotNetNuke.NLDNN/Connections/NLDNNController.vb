Imports DotNetNuke.Common.Utilities
Public Class NLDNNController

#Region "CMS_Provide_History"
    Public Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As CMS_Provide_HistoryInfo
        Return CBO.FillObject(Of CMS_Provide_HistoryInfo)(DataProvider.Instance().CMS_Provide_History_Get(tpConnect, history_ID))
    End Function
    Public Function CMS_Provide_History_List(tpConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_History_List(tpConnect), GetType(CMS_Provide_HistoryInfo))
    End Function

    Public Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        DataProvider.Instance().CMS_Provide_History_Add(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        DataProvider.Instance().CMS_Provide_History_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)
        DataProvider.Instance().CMS_Provide_History_Delete(tpConnect, history_ID)
    End Sub
    Public Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, quanHuyen As Integer, maXa As Integer, maDvi As Integer) As CMS_Provide_HistoryInfo
        Return CBO.FillObject(Of CMS_Provide_HistoryInfo)(DataProvider.Instance().CMS_Provide_History_Get_Send(tpConnect, tinhTP, quanHuyen, maXa, maDvi))
    End Function
#End Region
#Region "CMS_NLD"
    Public Sub CMS_NLD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        DataProvider.Instance().CMS_NLD_Backup(tpConnect, matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Function CMS_NLD_Get(PortalConnect As String, nguoiLD_ID As String) As CMS_NLDInfo
        Return CBO.FillObject(Of CMS_NLDInfo)(DataProvider.Instance().CMS_NLD_Get(PortalConnect, nguoiLD_ID))
    End Function
    Public Function CMS_NLD_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NLD_List(PortalConnect, portalId), GetType(CMS_NLDInfo))
    End Function

    Public Function CMS_NLD_Add(PortalConnect As String, obj As CMS_NLDInfo) As Integer
        Return DataProvider.Instance().CMS_NLD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NLD_Update(PortalConnect As String, obj As CMS_NLDInfo)
        DataProvider.Instance().CMS_NLD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NLD_Delete(PortalConnect As String, nguoiLD_ID As Integer)
        DataProvider.Instance().CMS_NLD_Delete(PortalConnect, nguoiLD_ID)
    End Sub
    Public Sub CMS_NLD_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_NLD_Update_Quick(PortalConnect, nguoiLD_ID, isActive, isOrder)
    End Sub
    Public Function CMS_NLD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, yearCreated As Integer, quocTich As String, gioiTinh As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NLD_List_Search(tpConnect, search, matinh, mahuyen, maxa, mathon, isOrder, year, currPage, recodperpage, IsNow, yearCreated, quocTich, gioiTinh), GetType(CMS_NLDInfo))
    End Function
#End Region
#Region "CMS_NLD_Backup"
    Public Function CMS_NLD_Backup_Get(PortalConnect As String, nguoiLD_ID As Integer) As CMS_NLD_BackupInfo
        Return CBO.FillObject(Of CMS_NLD_BackupInfo)(DataProvider.Instance().CMS_NLD_Backup_Get(PortalConnect, nguoiLD_ID))
    End Function
    Public Function CMS_NLD_Backup_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NLD_Backup_List(PortalConnect, portalId), GetType(CMS_NLD_BackupInfo))
    End Function

    Public Function CMS_NLD_Backup_Add(PortalConnect As String, obj As CMS_NLD_BackupInfo) As Integer
        Return DataProvider.Instance().CMS_NLD_Backup_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NLD_Backup_Update(PortalConnect As String, obj As CMS_NLD_BackupInfo)
        DataProvider.Instance().CMS_NLD_Backup_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NLD_Backup_Delete(PortalConnect As String, nguoiLD_ID As Integer)
        DataProvider.Instance().CMS_NLD_Backup_Delete(PortalConnect, nguoiLD_ID)
    End Sub
    Public Sub CMS_NLD_Backup_Update_Quick(PortalConnect As String, nguoiLD_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_NLD_Backup_Update_Quick(PortalConnect, nguoiLD_ID, isActive, isOrder)
    End Sub
    Public Sub CMS_NLD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        DataProvider.Instance().CMS_NLD_Update_Delete(tpConnect, id, isDelete, deleteDate, deleteUser)
    End Sub
#End Region
#Region "CMS_Provide_Config"

    Public Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List_Search(tpConnect, tinhTP, isActive, currPage, recodperpage, UserName), GetType(CMS_Provide_ConfigInfo))
    End Function
    Public Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, isActive As Boolean) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get_Active(tpConnect, TinhTP, isActive))
    End Function
    Public Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get(tpConnect, proConfig_ID))
    End Function
    Public Function CMS_Provide_Config_Get_Value(tpConnect As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get_Value(tpConnect, tinhTP, QuanHuyen, PhuongXa, ThonTo, proconfig_value))
    End Function
    Public Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
        DataProvider.Instance().CMS_Provide_Config_Update_Active(tpConnect, proConfig_ID, active)
    End Sub
    Public Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List(tpConnect, portalId), GetType(CMS_Provide_ConfigInfo))
    End Function
    Public Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List_ByTinh(tpConnect, tinhTP), GetType(CMS_Provide_ConfigInfo))
    End Function

    Public Sub CMS_Provide_Config_Add(tpConnect As String, obj As CMS_Provide_ConfigInfo)
        DataProvider.Instance().CMS_Provide_Config_Add(tpConnect, obj.ProConfig_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ThonTo, obj.ProConfig_Name, obj.ProConfig_Value, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub CMS_Provide_Config_Update(tpConnect As String, obj As CMS_Provide_ConfigInfo)
        DataProvider.Instance().CMS_Provide_Config_Update(tpConnect, obj.ProConfig_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ThonTo, obj.ProConfig_Name, obj.ProConfig_Value, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId)
    End Sub
    Public Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
        DataProvider.Instance().CMS_Provide_Config_Delete(tpConnect, proConfig_ID)
    End Sub
#End Region
#Region "DM_ChuyenMonDT"
    Public Function DM_ChuyenMonDT_Get(PortalConnect As String, iD As Integer) As DM_ChuyenMonDTInfo
        Return CBO.FillObject(Of DM_ChuyenMonDTInfo)(DataProvider.Instance().DM_ChuyenMonDT_Get(PortalConnect, iD))
    End Function
    Public Function DM_ChuyenMonDT_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_ChuyenMonDT_List(PortalConnect), GetType(DM_ChuyenMonDTInfo))
    End Function

    Public Function DM_ChuyenMonDT_Add(PortalConnect As String, obj As DM_ChuyenMonDTInfo) As Integer
        Return DataProvider.Instance().DM_ChuyenMonDT_Add(PortalConnect, obj)
    End Function
    Public Sub DM_ChuyenMonDT_Update(PortalConnect As String, obj As DM_ChuyenMonDTInfo)
        DataProvider.Instance().DM_ChuyenMonDT_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_ChuyenMonDT_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_ChuyenMonDT_Delete(PortalConnect, iD)
    End Sub
    Public Sub DM_ChuyenMonDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DM_ChuyenMonDT_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_HinhThucLV"
    Public Function DM_HinhThucLV_Get(PortalConnect As String, iD As Integer) As DM_HinhThucLVInfo
        Return CBO.FillObject(Of DM_HinhThucLVInfo)(DataProvider.Instance().DM_HinhThucLV_Get(PortalConnect, iD))
    End Function
    Public Function DM_HinhThucLV_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_HinhThucLV_List(PortalConnect), GetType(DM_HinhThucLVInfo))
    End Function

    Public Function DM_HinhThucLV_Add(PortalConnect As String, obj As DM_HinhThucLVInfo) As Integer
        Return DataProvider.Instance().DM_HinhThucLV_Add(PortalConnect, obj)
    End Function
    Public Sub DM_HinhThucLV_Update(PortalConnect As String, obj As DM_HinhThucLVInfo)
        DataProvider.Instance().DM_HinhThucLV_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_HinhThucLV_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_HinhThucLV_Delete(PortalConnect, iD)
    End Sub
    Public Sub DM_HinhThucLV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DM_HinhThucLV_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_NgheCongViec"
    Public Function DM_NgheCongViec_Get(PortalConnect As String, iD As Integer) As DM_NgheCongViecInfo
        Return CBO.FillObject(Of DM_NgheCongViecInfo)(DataProvider.Instance().DM_NgheCongViec_Get(PortalConnect, iD))
    End Function
    Public Function DM_NgheCongViec_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_NgheCongViec_List(PortalConnect), GetType(DM_NgheCongViecInfo))
    End Function

    Public Function DM_NgheCongViec_Add(PortalConnect As String, obj As DM_NgheCongViecInfo) As Integer
        Return DataProvider.Instance().DM_NgheCongViec_Add(PortalConnect, obj)
    End Function
    Public Sub DM_NgheCongViec_Update(PortalConnect As String, obj As DM_NgheCongViecInfo)
        DataProvider.Instance().DM_NgheCongViec_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_NgheCongViec_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_NgheCongViec_Delete(PortalConnect, iD)
    End Sub
    Public Sub DM_NgheCongViec_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DM_NgheCongViec_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_TrinhDoDT"
    Public Function DM_TrinhDoDT_Get(PortalConnect As String, iD As Integer) As DM_TrinhDoDTInfo
        Return CBO.FillObject(Of DM_TrinhDoDTInfo)(DataProvider.Instance().DM_TrinhDoDT_Get(PortalConnect, iD))
    End Function
    Public Function DM_TrinhDoDT_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_TrinhDoDT_List(PortalConnect), GetType(DM_TrinhDoDTInfo))
    End Function

    Public Function DM_TrinhDoDT_Add(PortalConnect As String, obj As DM_TrinhDoDTInfo) As Integer
        Return DataProvider.Instance().DM_TrinhDoDT_Add(PortalConnect, obj)
    End Function
    Public Sub DM_TrinhDoDT_Update(PortalConnect As String, obj As DM_TrinhDoDTInfo)
        DataProvider.Instance().DM_TrinhDoDT_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_TrinhDoDT_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_TrinhDoDT_Delete(PortalConnect, iD)
    End Sub
    Public Sub DM_TrinhDoDT_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DM_TrinhDoDT_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "DM_ViTriCV"
    Public Function DM_ViTriCV_Get(PortalConnect As String, iD As Integer) As DM_ViTriCVInfo
        Return CBO.FillObject(Of DM_ViTriCVInfo)(DataProvider.Instance().DM_ViTriCV_Get(PortalConnect, iD))
    End Function
    Public Function DM_ViTriCV_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DM_ViTriCV_List(PortalConnect), GetType(DM_ViTriCVInfo))
    End Function

    Public Function DM_ViTriCV_Add(PortalConnect As String, obj As DM_ViTriCVInfo) As Integer
        Return DataProvider.Instance().DM_ViTriCV_Add(PortalConnect, obj)
    End Function
    Public Sub DM_ViTriCV_Update(PortalConnect As String, obj As DM_ViTriCVInfo)
        DataProvider.Instance().DM_ViTriCV_Update(PortalConnect, obj)
    End Sub
    Public Sub DM_ViTriCV_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().DM_ViTriCV_Delete(PortalConnect, iD)
    End Sub
    Public Sub DM_ViTriCV_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DM_ViTriCV_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region

#Region "REPORT CHART"

    Public Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As ChartInfo
        Return CBO.FillObject(Of ChartInfo)(DataProvider.Instance().CMS_Chart_Data(tpConnect, tp, qh, xp, year, isNow, maBC))
    End Function
    Public Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chart_DataHC(tpConnect, tp, qh, ids, year, isNow, maBC), GetType(ChartInfo))
    End Function
#End Region

End Class
