Imports DotNetNuke.Common.Utilities
Public Class AnalyController

#Region "CMS_Group"
    Public Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As CMS_GroupInfo
        Return CBO.FillObject(Of CMS_GroupInfo)(DataProvider.Instance().CMS_Group_Get(PortalConnect, group_ID))
    End Function
    Public Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
        Return DataProvider.Instance().CMS_Group_Count_Parent(PortalConnect, group_ID)
    End Function
    Public Function CMS_Group_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List(PortalConnect), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_By_ParentID(PortalConnect, asxh_id, parentID), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Parent_Null(PortalConnect, asxh_id, groupType), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Search(PortalConnect, asxh_id, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_GroupInfo))
    End Function

    Public Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        DataProvider.Instance().CMS_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
        DataProvider.Instance().CMS_Group_Delete(PortalConnect, group_ID)
    End Sub
#End Region
#Region "CMS_UnitType"
    Public Function CMS_UnitType_Get(PortalConnect As String, unitType_ID As Integer) As CMS_UnitTypeInfo
        Return CBO.FillObject(Of CMS_UnitTypeInfo)(DataProvider.Instance().CMS_UnitType_Get(PortalConnect, unitType_ID))
    End Function
    Public Function CMS_UnitType_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UnitType_List(PortalConnect), GetType(CMS_UnitTypeInfo))
    End Function

    Public Function CMS_UnitType_Add(PortalConnect As String, obj As CMS_UnitTypeInfo) As Integer
        Return DataProvider.Instance().CMS_UnitType_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_UnitType_Update(PortalConnect As String, obj As CMS_UnitTypeInfo)
        DataProvider.Instance().CMS_UnitType_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_UnitType_Delete(PortalConnect As String, unitType_ID As Integer)
        DataProvider.Instance().CMS_UnitType_Delete(PortalConnect, unitType_ID)
    End Sub
    Public Function CMS_UnitType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UnitType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_UnitTypeInfo))
    End Function
#End Region
#Region "CMS_Data"
    Public Function CMS_Data_Get(PortalConnect As String, data_ID As Integer) As CMS_DataInfo
        Return CBO.FillObject(Of CMS_DataInfo)(DataProvider.Instance().CMS_Data_Get(PortalConnect, data_ID))
    End Function
    Public Function CMS_Data_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Data_List(PortalConnect), GetType(CMS_DataInfo))
    End Function
    Public Function CMS_Data_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Data_Get_By_CMS_Report(PortalConnect, report_ID, tinhTP, groupID, yearID), GetType(CMS_DataInfo))
    End Function
    Public Function CMS_Data_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, ASXH_ID As Integer, Group_ID As Integer, Years_ID As Integer, Period_ID As Integer, Unit_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Data_Get_By_Years_SumData(PortalConnect, TinhTP, ASXH_ID, Group_ID, Years_ID, Period_ID, Unit_ID), GetType(CMS_DataInfo))
    End Function
    Public Sub CMS_Data_List_Report(PortalConnect As String, Temp_ID As Integer)
        DataProvider.Instance().CMS_Data_List_Report(PortalConnect, Temp_ID)
    End Sub
	Public Function CMS_Data_Add(PortalConnect As String, obj As CMS_DataInfo) As Integer
		Return DataProvider.Instance().CMS_Data_Add(PortalConnect, obj)
	End Function
	Public Function CMS_Data_Get_By_Year_Code(PortalConnect As String, tinhTP As Integer, Targets_Code As String, years As Integer) As Integer
		Return DataProvider.Instance().CMS_Data_Get_By_Year_Code(PortalConnect, tinhTP, Targets_Code, years)
	End Function

	Public Function CMS_Data_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return DataProvider.Instance().CMS_Data_Get_By_Years(PortalConnect, tinhTp, groupID, targetID, yearID)
    End Function
    Public Function CMS_Data_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return DataProvider.Instance().CMS_Data_Delete_By_Years(PortalConnect, tinhTp, groupID, targetID, yearID)
    End Function
    Public Sub CMS_Data_Delete(PortalConnect As String, data_ID As Integer)
        DataProvider.Instance().CMS_Data_Delete(PortalConnect, data_ID)
    End Sub
    Public Sub CMS_Data_Update_SoLieu(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer)
        DataProvider.Instance().CMS_Data_Update_SoLieu(PortalConnect, report_ID, tinhTP, groupID, yearID)
    End Sub
#End Region
#Region "CMS_Report"
    Public Function CMS_Report_Unit(PortalConnect As String, tempID As Integer, isSend As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_Unit(PortalConnect, tempID, isSend), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_List_Period(PortalConnect As String, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_List_Period(PortalConnect, tinhTP), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_List_Years(PortalConnect As String, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_List_Years(PortalConnect, tinhTP), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_Get(PortalConnect As String, report_ID As Integer) As CMS_ReportInfo
        Return CBO.FillObject(Of CMS_ReportInfo)(DataProvider.Instance().CMS_Report_Get(PortalConnect, report_ID))
    End Function
    Public Function CMS_Report_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_List(PortalConnect), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_List_Search(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Level_ID As Integer, Years_ID As Integer, search As String, Status As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_List_Search(PortalConnect, TinhTP, QuanHuyen, XaPhuong, ASXH_ID, Group_ID, Level_ID, Years_ID, search, Status, currPage, recodperpage), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_Get_ByTarget(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer, Period_ID As Integer) As String
        Return DataProvider.Instance().CMS_Report_Get_ByTarget(PortalConnect, TinhTP, QuanHuyen, XaPhuong, ASXH_ID, Group_ID, Target_ID, Years_ID, Period_ID)
    End Function
    Public Function CMS_Report_List_ByTem(PortalConnect As String, TempID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_List_ByTem(PortalConnect, TempID, currPage, recodperpage), GetType(CMS_ReportInfo))
    End Function
    Public Function CMS_Report_Add(PortalConnect As String, obj As CMS_ReportInfo) As Integer
        Return DataProvider.Instance().CMS_Report_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Report_Update(PortalConnect As String, obj As CMS_ReportInfo)
        DataProvider.Instance().CMS_Report_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Report_Return(PortalConnect As String, reportID As Integer, ngaytralai As DateTime, nguoitralai As String, lydotralai As String)
        DataProvider.Instance().CMS_Report_Return(PortalConnect, reportID, ngaytralai, nguoitralai, lydotralai)
    End Sub
    Public Sub CMS_Report_Update_Send(PortalConnect As String, Report_ID As Integer, SendDate As DateTime, SendUser As String)
        DataProvider.Instance().CMS_Report_Update_Send(PortalConnect, Report_ID, SendDate, SendUser)
    End Sub
    Public Sub CMS_Report_Delete(PortalConnect As String, report_ID As Integer)
        DataProvider.Instance().CMS_Report_Delete(PortalConnect, report_ID)
    End Sub
#End Region
#Region "CMS_Targets"
    Public Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_By_Group_Parent(PortalConnect, group_ID, ParentID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_By_Group_ID(PortalConnect, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As CMS_TargetsInfo
        Return CBO.FillObject(Of CMS_TargetsInfo)(DataProvider.Instance().CMS_Targets_Get(PortalConnect, targets_ID))
    End Function
    Public Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
        Return DataProvider.Instance().CMS_Targets_Get_ByCode(PortalConnect, targets_code)
    End Function
    Public Function CMS_Targets_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List(PortalConnect), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_IsGroup(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_IsGroup(PortalConnect), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_ByCateTar(PortalConnect, GroupID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_TinhTP(PortalConnect, TinhTP), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
        Return DataProvider.Instance().CMS_Targets_Count_TinhTP(PortalConnect, TinhTP)
    End Function
    Public Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentId As Integer) As String
        Return DataProvider.Instance().CMS_Targets_GenCode(PortalConnect, maTinh, maHuyen, maXa, asxh_id, group_id, targetID, parentId)
    End Function
    Public Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
        Return DataProvider.Instance().CMS_Sys_CopyTarget(PortalConnect, TinhTP1, TinhTP2, CreatedUser, CreatedDate)
    End Function
    Public Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Parent_Search_Null(PortalConnect, search, isOrder), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Parent_Search_ID(PortalConnect, tinhTp, quanhuyen, phuongxa, search, asxh_id, group_id, Parent_ID, currPage, recodperpage), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Analytic(PortalConnect, tinhTp, search, group_id, Parent_ID, isMain), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Select(PortalConnect, tinhTp, asxh_id, group_id), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Parent_Null(PortalConnect, tinhTP, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect, tinhTP, group_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Targets(PortalConnect, Targets_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect, tinhTp, Targets_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
        Return DataProvider.Instance().CMS_Targets_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
        DataProvider.Instance().CMS_Targets_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
        DataProvider.Instance().CMS_Targets_Delete(PortalConnect, targets_ID)
    End Sub

    Public Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect, temp_ID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect, temp_ID, Parent_ID), GetType(CMS_TargetsInfo))
    End Function
#End Region
#Region "CMS_Analytic"
    Public Function CMS_Analytic_Get(PortalConnect As String, analtyic_ID As String) As CMS_AnalyticInfo
        Return CBO.FillObject(Of CMS_AnalyticInfo)(DataProvider.Instance().CMS_Analytic_Get(PortalConnect, analtyic_ID))
    End Function
    Public Function CMS_Analytic_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Analytic_List(PortalConnect), GetType(CMS_AnalyticInfo))
    End Function
    Public Function CMS_Analytic_List_ByTarget(PortalConnect As String, TargetID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Analytic_List_ByTarget(PortalConnect, TargetID), GetType(CMS_AnalyticInfo))
    End Function
    Public Function CMS_Analytic_List_ReportTarget(PortalConnect As String, TargetID As Integer, ValCT As Double) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Analytic_List_ReportTarget(PortalConnect, TargetID, ValCT), GetType(CMS_AnalyticInfo))
    End Function

    Public Sub CMS_Analytic_Add(PortalConnect As String, obj As CMS_AnalyticInfo)
        DataProvider.Instance().CMS_Analytic_Add(PortalConnect, obj.Analtyic_ID, obj.Targets_ID, obj.ValueFrom, obj.ValueTo, obj.Contents, obj.Solution, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Sub CMS_Analytic_Update(PortalConnect As String, obj As CMS_AnalyticInfo)
        DataProvider.Instance().CMS_Analytic_Update(PortalConnect, obj.Analtyic_ID, obj.Targets_ID, obj.ValueFrom, obj.ValueTo, obj.Contents, obj.Solution, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Sub CMS_Analytic_Delete(PortalConnect As String, analtyic_ID As String)
        DataProvider.Instance().CMS_Analytic_Delete(PortalConnect, analtyic_ID)
    End Sub
#End Region
#Region "CMS_DashBoard"
    Public Function CMS_DashBoard(PortalConnect As String, tinh As Integer, asxh As Integer, group As Integer, year As Integer) As CMS_DashBoardInfo
        Return CBO.FillObject(Of CMS_DashBoardInfo)(DataProvider.Instance().CMS_DashBoard(PortalConnect, tinh, asxh, group, year))
    End Function
#End Region
#Region "GetDataAnaly"
    Public Function CMS_Data_ListByYear(PortalConnect As String, TinhTp As Integer, Group_ID As Integer, Target_ID As Integer, YearFrom As Integer, YearTo As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Data_ListByYear(PortalConnect, TinhTp, Group_ID, Target_ID, YearFrom, YearTo), GetType(DataAnalyInfo))
    End Function
#End Region
#Region "CMS_Scene"
    Public Function CMS_Scene_Get(PortalConnect As String, scene_ID As Integer) As CMS_SceneInfo
        Return CBO.FillObject(Of CMS_SceneInfo)(DataProvider.Instance().CMS_Scene_Get(PortalConnect, scene_ID))
    End Function
    Public Function CMS_Scene_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Scene_List(PortalConnect), GetType(CMS_SceneInfo))
    End Function
    Public Function CMS_Scene_List_ByTinhTP(PortalConnect As String, tinhTp As Integer, typeScene As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Scene_List_ByTinhTP(PortalConnect, tinhTp, typeScene), GetType(CMS_SceneInfo))
    End Function
    Public Function CMS_Scene_GetData(PortalConnect As String, YearID As Integer, TinhTp As Integer, TypeScene As Integer) As Double
        Return DataProvider.Instance().CMS_Scene_GetData(PortalConnect, YearID, TinhTp, TypeScene)
    End Function
    Public Function CMS_Scene_Add(PortalConnect As String, obj As CMS_SceneInfo) As Integer
        Return DataProvider.Instance().CMS_Scene_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Scene_Update(PortalConnect As String, obj As CMS_SceneInfo)
        DataProvider.Instance().CMS_Scene_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Scene_Delete(PortalConnect As String, scene_ID As Integer)
        DataProvider.Instance().CMS_Scene_Delete(PortalConnect, scene_ID)
    End Sub
#End Region
#Region "CMS_DataSave"
    Public Function CMS_DataSave_Get(PortalConnect As String, data_ID As Integer) As CMS_DataSaveInfo
        Return CBO.FillObject(Of CMS_DataSaveInfo)(DataProvider.Instance().CMS_DataSave_Get(PortalConnect, data_ID))
    End Function
    Public Function CMS_DataSave_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DataSave_List(PortalConnect), GetType(CMS_DataSaveInfo))
    End Function
    Public Function CMS_DataSave_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DataSave_Get_By_CMS_Report(PortalConnect, report_ID, tinhTP, groupID, yearID), GetType(CMS_DataSaveInfo))
    End Function
    Public Function CMS_DataSave_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Years_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DataSave_Get_By_Years_SumData(PortalConnect, TinhTP, Group_ID, Years_ID), GetType(CMS_DataSaveInfo))
    End Function
    Public Sub CMS_DataSave_List_Report(PortalConnect As String, Temp_ID As Integer)
        DataProvider.Instance().CMS_DataSave_List_Report(PortalConnect, Temp_ID)
    End Sub
    Public Function CMS_DataSave_Add(PortalConnect As String, obj As CMS_DataSaveInfo) As Integer
        Return DataProvider.Instance().CMS_DataSave_Add(PortalConnect, obj)
    End Function
    Public Function CMS_DataSave_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return DataProvider.Instance().CMS_DataSave_Get_By_Years(PortalConnect, tinhTp, groupID, targetID, yearID)
    End Function
    Public Function CMS_DataSave_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return DataProvider.Instance().CMS_DataSave_Delete_By_Years(PortalConnect, tinhTp, groupID, targetID, yearID)
    End Function
    Public Sub CMS_DataSave_Delete(PortalConnect As String, data_ID As Integer)
        DataProvider.Instance().CMS_DataSave_Delete(PortalConnect, data_ID)
    End Sub
#End Region
#Region "CMS_ReportSave"
    Public Function CMS_ReportSave_Get_ByTarget(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer) As String
        Return DataProvider.Instance().CMS_ReportSave_Get_ByTarget(PortalConnect, TinhTP, Group_ID, Target_ID, Years_ID)
    End Function
    Public Function CMS_ReportSave_List_Years(PortalConnect As String, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ReportSave_List_Years(PortalConnect, tinhTP), GetType(CMS_ReportSaveInfo))
    End Function
    Public Function CMS_ReportSave_Get(PortalConnect As String, report_ID As Integer) As CMS_ReportSaveInfo
        Return CBO.FillObject(Of CMS_ReportSaveInfo)(DataProvider.Instance().CMS_ReportSave_Get(PortalConnect, report_ID))
    End Function
    Public Function CMS_ReportSave_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ReportSave_List(PortalConnect), GetType(CMS_ReportSaveInfo))
    End Function
    Public Function CMS_ReportSave_Add(PortalConnect As String, obj As CMS_ReportSaveInfo) As Integer
        Return DataProvider.Instance().CMS_ReportSave_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ReportSave_Update(PortalConnect As String, obj As CMS_ReportSaveInfo)
        DataProvider.Instance().CMS_ReportSave_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ReportSave_Delete(PortalConnect As String, report_ID As Integer)
        DataProvider.Instance().CMS_ReportSave_Delete(PortalConnect, report_ID)
    End Sub
#End Region
#Region "CMS_FileAttach"
	Public Function CMS_FileAttach_Get(PortalConnect As String, attch_ID As String) As CMS_FileAttachInfo
        Return CBO.FillObject(Of CMS_FileAttachInfo)(DataProvider.Instance().CMS_FileAttach_Get(PortalConnect, attch_ID))
    End Function
    Public Function CMS_FileAttach_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttach_List(PortalConnect, portalId), GetType(CMS_FileAttachInfo))
    End Function
    Public Function CMS_FileAttach_List_By_IdKey(PortalConnect As String, portalId As Integer, idKey As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttach_List_By_IdKey(PortalConnect, portalId, idKey), GetType(CMS_FileAttachInfo))
    End Function

    Public Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
        DataProvider.Instance().CMS_FileAttach_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
        DataProvider.Instance().CMS_FileAttach_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FileAttach_Delete(PortalConnect As String, attch_ID As String)
        DataProvider.Instance().CMS_FileAttach_Delete(PortalConnect, attch_ID)
    End Sub
    Public Sub CMS_FileAttach_Delete_By_IdKey(PortalConnect As String, idKey As String)
        DataProvider.Instance().CMS_FileAttach_Delete_By_IdKey(PortalConnect, idKey)
    End Sub
#End Region
#Region "CMS_Magazine"
	Public Function CMS_Magazine_Get(PortalConnect As String, magazine_ID As Integer) As CMS_MagazineInfo
        Return CBO.FillObject(Of CMS_MagazineInfo)(DataProvider.Instance().CMS_Magazine_Get(PortalConnect, magazine_ID))
    End Function
    Public Function CMS_Magazine_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Magazine_List(PortalConnect), GetType(CMS_MagazineInfo))
    End Function
    Public Function CMS_Magazine_List_Active(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Magazine_List_Active(PortalConnect), GetType(CMS_MagazineInfo))
    End Function

    Public Function CMS_Magazine_Add(PortalConnect As String, obj As CMS_MagazineInfo) As Integer
        Return DataProvider.Instance().CMS_Magazine_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Magazine_Update(PortalConnect As String, obj As CMS_MagazineInfo)
        DataProvider.Instance().CMS_Magazine_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Magazine_Delete(PortalConnect As String, magazine_ID As Integer)
        DataProvider.Instance().CMS_Magazine_Delete(PortalConnect, magazine_ID)
    End Sub
#End Region
#Region "CMS_MagazineData"
    Public Function CMS_MagazineData_Get(PortalConnect As String, magazineData_ID As Integer) As CMS_MagazineDataInfo
        Return CBO.FillObject(Of CMS_MagazineDataInfo)(DataProvider.Instance().CMS_MagazineData_Get(PortalConnect, magazineData_ID))
    End Function
    Public Function CMS_MagazineData_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MagazineData_List(PortalConnect), GetType(CMS_MagazineDataInfo))
    End Function
    Public Function CMS_MagazineData_Get_By_CMS_Magazine(PortalConnect As String, magazine_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MagazineData_Get_By_CMS_Magazine(PortalConnect, magazine_ID), GetType(CMS_MagazineDataInfo))
    End Function

    Public Function CMS_MagazineData_Add(PortalConnect As String, obj As CMS_MagazineDataInfo) As Integer
        Return DataProvider.Instance().CMS_MagazineData_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MagazineData_Update(PortalConnect As String, obj As CMS_MagazineDataInfo)
        DataProvider.Instance().CMS_MagazineData_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MagazineData_Delete(PortalConnect As String, magazineData_ID As Integer)
        DataProvider.Instance().CMS_MagazineData_Delete(PortalConnect, magazineData_ID)
    End Sub
#End Region
#Region "CMS_TypeScene"
	Public Function CMS_TypeScene_Get(PortalConnect As String, typeScene_ID As Integer) As CMS_TypeSceneInfo
        Return CBO.FillObject(Of CMS_TypeSceneInfo)(DataProvider.Instance().CMS_TypeScene_Get(PortalConnect, typeScene_ID))
    End Function
    Public Function CMS_TypeScene_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeScene_List(PortalConnect), GetType(CMS_TypeSceneInfo))
    End Function

    Public Function CMS_TypeScene_Add(PortalConnect As String, obj As CMS_TypeSceneInfo) As Integer
        Return DataProvider.Instance().CMS_TypeScene_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TypeScene_Update(PortalConnect As String, obj As CMS_TypeSceneInfo)
        DataProvider.Instance().CMS_TypeScene_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TypeScene_Delete(PortalConnect As String, typeScene_ID As Integer)
        DataProvider.Instance().CMS_TypeScene_Delete(PortalConnect, typeScene_ID)
    End Sub
#End Region
#Region "CMS_Config"
    Public Function CMS_Config_Get(PortalConnect As String, config_ID As String) As CMS_ConfigInfo
        Return CBO.FillObject(Of CMS_ConfigInfo)(DataProvider.Instance().CMS_Config_Get(PortalConnect, config_ID))
    End Function
    Public Function CMS_Config_Get_ByTinhTP(PortalConnect As String, tinhTP As Integer, configValue As Integer) As CMS_ConfigInfo
        Return CBO.FillObject(Of CMS_ConfigInfo)(DataProvider.Instance().CMS_Config_Get_ByTinhTP(PortalConnect, tinhTP, configValue))
    End Function
    Public Function CMS_Config_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Config_List(PortalConnect, portalId), GetType(CMS_ConfigInfo))
    End Function

    Public Sub CMS_Config_Add(PortalConnect As String, obj As CMS_ConfigInfo)
        DataProvider.Instance().CMS_Config_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Config_Update(PortalConnect As String, obj As CMS_ConfigInfo)
        DataProvider.Instance().CMS_Config_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Config_Delete(PortalConnect As String, config_ID As String)
        DataProvider.Instance().CMS_Config_Delete(PortalConnect, config_ID)
    End Sub
#End Region
#Region "CMS_RegTar"
    Public Function CMS_RegTar_Get(PortalConnect As String, regTar_ID As String) As CMS_RegTarInfo
        Return CBO.FillObject(Of CMS_RegTarInfo)(DataProvider.Instance().CMS_RegTar_Get(PortalConnect, regTar_ID))
    End Function
    Public Function CMS_RegTar_Get_By_Data(PortalConnect As String, Targets_ID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As CMS_RegTarInfo
        Return CBO.FillObject(Of CMS_RegTarInfo)(DataProvider.Instance().CMS_RegTar_Get_By_Data(PortalConnect, Targets_ID, tinhTP, quanHuyen, xaPhuong))
    End Function
    Public Function CMS_RegTar_Get_By_Targets_Code(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, Targets_Code As String) As Integer
        Return DataProvider.Instance().CMS_RegTar_Get_By_Targets_Code(PortalConnect, tinhTP, quanHuyen, xaPhuong, Targets_Code)
    End Function
    Public Function CMS_RegTar_Get_By_Data(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegTar_Get_By_Data(PortalConnect, -1, tinhTP, quanHuyen, xaPhuong), GetType(CMS_RegTarInfo))
    End Function
    Public Function CMS_RegTar_Get_By_Temp(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegTar_Get_By_Temp(PortalConnect, tinhTP, quanHuyen, xaPhuong, groupID, asxhID, ParentId), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_RegTar_Get_By_Temp_Drap(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer, tempID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegTar_Get_By_Temp_Drap(PortalConnect, tinhTP, quanHuyen, xaPhuong, groupID, asxhID, ParentId, tempID), GetType(CMS_TargetsInfo))
    End Function
    Public Function CMS_RegTar_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegTar_List(PortalConnect), GetType(CMS_RegTarInfo))
    End Function

    Public Sub CMS_RegTar_Add(PortalConnect As String, obj As CMS_RegTarInfo)
        DataProvider.Instance().CMS_RegTar_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_RegTar_Update(PortalConnect As String, obj As CMS_RegTarInfo)
        DataProvider.Instance().CMS_RegTar_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_RegTar_Delete(PortalConnect As String, regTar_ID As String)
        DataProvider.Instance().CMS_RegTar_Delete(PortalConnect, regTar_ID)
    End Sub
    Public Sub CMS_RegTar_Delete_Target(PortalConnect As String, TinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, targerID As Integer)
        DataProvider.Instance().CMS_RegTar_Delete_Target(PortalConnect, TinhTP, quanHuyen, xaPhuong, targerID)
    End Sub
#End Region
#Region "CMS_InDataRow"
    Public Function CMS_InDataRow_Get(PortalConnect As String, dataRow_ID As String) As CMS_InDataRowInfo
        Return CBO.FillObject(Of CMS_InDataRowInfo)(DataProvider.Instance().CMS_InDataRow_Get(PortalConnect, dataRow_ID))
    End Function
    Public Function CMS_InDataRow_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InDataRow_List(PortalConnect), GetType(CMS_InDataRowInfo))
    End Function
    Public Function CMS_InDataRow_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InDataRow_Get_By_CMS_InputRpt(PortalConnect, inputRpt_ID, currPage, recodperpage), GetType(CMS_InDataRowInfo))
    End Function
    Public Sub CMS_InDataRow_Delete_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer)
        DataProvider.Instance().CMS_InDataRow_Delete_By_CMS_InputRpt(PortalConnect, inputRpt_ID)
    End Sub
    Public Sub CMS_InDataRow_Add(PortalConnect As String, obj As CMS_InDataRowInfo)
        DataProvider.Instance().CMS_InDataRow_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_InDataRow_Update(PortalConnect As String, obj As CMS_InDataRowInfo)
        DataProvider.Instance().CMS_InDataRow_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_InDataRow_Delete(PortalConnect As String, dataRow_ID As String)
        DataProvider.Instance().CMS_InDataRow_Delete(PortalConnect, dataRow_ID)
    End Sub
#End Region
#Region "CMS_InputRptC"
    Public Function CMS_InputRptC_Get(PortalConnect As String, inputRptC_ID As String) As CMS_InputRptCInfo
        Return CBO.FillObject(Of CMS_InputRptCInfo)(DataProvider.Instance().CMS_InputRptC_Get(PortalConnect, inputRptC_ID))
    End Function
    Public Function CMS_InputRptC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InputRptC_List(PortalConnect), GetType(CMS_InputRptCInfo))
    End Function
    Public Function CMS_InputRptC_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, Optional ByVal colType As Integer = 0) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InputRptC_Get_By_CMS_InputRpt(PortalConnect, inputRpt_ID, colType), GetType(CMS_InputRptCInfo))
    End Function

    Public Sub CMS_InputRptC_Add(PortalConnect As String, obj As CMS_InputRptCInfo)
        DataProvider.Instance().CMS_InputRptC_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_InputRptC_Update(PortalConnect As String, obj As CMS_InputRptCInfo)
        DataProvider.Instance().CMS_InputRptC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_InputRptC_Delete(PortalConnect As String, inputRptC_ID As String)
        DataProvider.Instance().CMS_InputRptC_Delete(PortalConnect, inputRptC_ID)
    End Sub
#End Region
#Region "CMS_TempRptC"
    Public Function CMS_TempRptC_Get(PortalConnect As String, tempRptC_ID As String) As CMS_TempRptCInfo
        Return CBO.FillObject(Of CMS_TempRptCInfo)(DataProvider.Instance().CMS_TempRptC_Get(PortalConnect, tempRptC_ID))
    End Function
    Public Function CMS_TempRptC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TempRptC_List(PortalConnect), GetType(CMS_TempRptCInfo))
    End Function
    Public Function CMS_TempRptC_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer, Optional ByVal colType As Integer = 0) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TempRptC_Get_By_CMS_TempRpt(PortalConnect, tempRpt_ID, colType), GetType(CMS_TempRptCInfo))
    End Function

    Public Sub CMS_TempRptC_Add(PortalConnect As String, obj As CMS_TempRptCInfo)
        DataProvider.Instance().CMS_TempRptC_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_TempRptC_Update(PortalConnect As String, obj As CMS_TempRptCInfo)
        DataProvider.Instance().CMS_TempRptC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TempRptC_Delete(PortalConnect As String, tempRptC_ID As String)
        DataProvider.Instance().CMS_TempRptC_Delete(PortalConnect, tempRptC_ID)
    End Sub
#End Region
#Region "CMS_InDataRowC"
    Public Function CMS_InDataRowC_Get(PortalConnect As String, dataRowC_ID As Integer) As CMS_InDataRowCInfo
        Return CBO.FillObject(Of CMS_InDataRowCInfo)(DataProvider.Instance().CMS_InDataRowC_Get(PortalConnect, dataRowC_ID))
    End Function
    Public Function CMS_InDataRowC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InDataRowC_List(PortalConnect), GetType(CMS_InDataRowCInfo))
    End Function
    Public Function CMS_InDataRowC_Get_Data(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetCol_ID As Integer, targetRow_ID As Integer, cateCol_ID As Integer, cateRow_ID As Integer, dataType As Integer) As Double
        Return DataProvider.Instance().CMS_InDataRowC_Get_Data(PortalConnect, tinhTp, yearID, groupID, targetCol_ID, targetRow_ID, cateCol_ID, cateRow_ID, dataType)
    End Function
    Public Function CMS_InDataRowC_Get_Data_Simple(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer) As Double
        Return DataProvider.Instance().CMS_InDataRowC_Get_Data_Simple(PortalConnect, tinhTp, yearID, groupID, targetRow_ID, cateRow_ID)
    End Function
    Public Function CMS_InDataRowC_Get_Data_Adv(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer, targetCol_ID As Integer, cateCol_ID As Integer) As Double
        Return DataProvider.Instance().CMS_InDataRowC_Get_Data_Adv(PortalConnect, tinhTp, yearID, groupID, targetRow_ID, cateRow_ID, targetCol_ID, cateCol_ID)
    End Function
    Public Function CMS_InDataRowC_Get_By_CMS_InDataRow(PortalConnect As String, dataRow_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InDataRowC_Get_By_CMS_InDataRow(PortalConnect, dataRow_ID), GetType(CMS_InDataRowCInfo))
    End Function
    Public Function CMS_InDataRowC_Get_By_CMS_InputRpt(PortalConnect As String, InputRpt_ID As Integer, Optional arrList As Boolean = True) As Object
        If arrList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_InDataRowC_Get_By_CMS_InputRpt(PortalConnect, InputRpt_ID), GetType(CMS_InDataRowCInfo))
        Else
            CMS_InDataRowC_Get_By_CMS_InputRpt = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(EPORTAL.flConnect.AnalyConnect(PortalConnect), "CMS_InDataRowC_Get_By_CMS_InputRpt", InputRpt_ID).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_InDataRowC_Add(PortalConnect As String, obj As CMS_InDataRowCInfo) As Integer
        Return DataProvider.Instance().CMS_InDataRowC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_InDataRowC_Update(PortalConnect As String, obj As CMS_InDataRowCInfo)
        DataProvider.Instance().CMS_InDataRowC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_InDataRowC_Delete(PortalConnect As String, dataRowC_ID As Integer)
        DataProvider.Instance().CMS_InDataRowC_Delete(PortalConnect, dataRowC_ID)
    End Sub
    Public Sub CMS_InDataRowC_Delete_Value(PortalConnect As String, dataRow_ID As String, inputRptC_ID As String)
        DataProvider.Instance().CMS_InDataRowC_Delete_Value(PortalConnect, dataRow_ID, inputRptC_ID)
    End Sub
#End Region
#Region "CMS_InputRpt"
    Public Function CMS_InputRpt_Get(PortalConnect As String, inputRpt_ID As Integer) As CMS_InputRptInfo
        Return CBO.FillObject(Of CMS_InputRptInfo)(DataProvider.Instance().CMS_InputRpt_Get(PortalConnect, inputRpt_ID))
    End Function
    Public Function CMS_InputRpt_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InputRpt_List(PortalConnect), GetType(CMS_InputRptInfo))
    End Function
    Public Function CMS_InputRpt_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InputRpt_Get_By_CMS_TempRpt(PortalConnect, tempRpt_ID), GetType(CMS_InputRptInfo))
    End Function
    Public Function CMS_InputRpt_List_Search(PortalConnect As String, search As String, tinhTp As Integer, Group_ID As Integer, Years_ID As Integer, TrangThai As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_InputRpt_List_Search(PortalConnect, search, tinhTp, Group_ID, Years_ID, TrangThai, currPage, recodperpage), GetType(CMS_InputRptInfo))
    End Function

    Public Function CMS_InputRpt_Add(PortalConnect As String, obj As CMS_InputRptInfo) As Integer
        Return DataProvider.Instance().CMS_InputRpt_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_InputRpt_Update(PortalConnect As String, obj As CMS_InputRptInfo)
        DataProvider.Instance().CMS_InputRpt_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_InputRpt_Delete(PortalConnect As String, inputRpt_ID As Integer)
        DataProvider.Instance().CMS_InputRpt_Delete(PortalConnect, inputRpt_ID)
    End Sub
#End Region
#Region "CMS_TempRpt"
    Public Function CMS_TempRpt_Get(PortalConnect As String, tempRpt_ID As Integer) As CMS_TempRptInfo
        Return CBO.FillObject(Of CMS_TempRptInfo)(DataProvider.Instance().CMS_TempRpt_Get(PortalConnect, tempRpt_ID))
    End Function
    Public Function CMS_TempRpt_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TempRpt_List(PortalConnect), GetType(CMS_TempRptInfo))
    End Function
    Public Function CMS_TempRpt_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Group_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TempRpt_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, Group_ID), GetType(CMS_TempRptInfo))
    End Function

    Public Function CMS_TempRpt_Add(PortalConnect As String, obj As CMS_TempRptInfo) As Integer
        Return DataProvider.Instance().CMS_TempRpt_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TempRpt_Update(PortalConnect As String, obj As CMS_TempRptInfo)
        DataProvider.Instance().CMS_TempRpt_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TempRpt_Delete(PortalConnect As String, tempRpt_ID As Integer)
        DataProvider.Instance().CMS_TempRpt_Delete(PortalConnect, tempRpt_ID)
    End Sub
#End Region
#Region "CMS_CateTar"
    Public Function CMS_CateTar_Get_ByCode(PortalConnect As String, iD As Integer, targetID As Integer) As CMS_CateTarInfo
        Return CBO.FillObject(Of CMS_CateTarInfo)(DataProvider.Instance().CMS_CateTar_Get_ByCode(PortalConnect, iD, targetID))
    End Function
    Public Function CMS_CateTar_Get(PortalConnect As String, iD As Integer) As CMS_CateTarInfo
        Return CBO.FillObject(Of CMS_CateTarInfo)(DataProvider.Instance().CMS_CateTar_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CateTar_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CateTar_List(PortalConnect), GetType(CMS_CateTarInfo))
    End Function
    Public Function CMS_CateTar_List_ByTarget(PortalConnect As String, target_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CateTar_List_ByTarget(PortalConnect, target_ID), GetType(CMS_CateTarInfo))
    End Function
    Public Function CMS_CateTar_Check_ByTarget(PortalConnect As String, target_ID As Integer) As Boolean
        Return DataProvider.Instance().CMS_CateTar_Check_ByTarget(PortalConnect, target_ID)
    End Function
    Public Function CMS_CateTar_Add(PortalConnect As String, obj As CMS_CateTarInfo) As Integer
        Return DataProvider.Instance().CMS_CateTar_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CateTar_Update(PortalConnect As String, obj As CMS_CateTarInfo)
        DataProvider.Instance().CMS_CateTar_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CateTar_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().CMS_CateTar_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_DataCaculator"
    Public Function CMS_DataCaculator_Get(PortalConnect As String, dataCaculator_ID As Integer) As CMS_DataCaculatorInfo
        Return CBO.FillObject(Of CMS_DataCaculatorInfo)(DataProvider.Instance().CMS_DataCaculator_Get(PortalConnect, dataCaculator_ID))
    End Function
    Public Function CMS_DataCaculator_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DataCaculator_List(PortalConnect), GetType(CMS_DataCaculatorInfo))
    End Function

    Public Function CMS_DataCaculator_Add(PortalConnect As String, obj As CMS_DataCaculatorInfo) As Integer
        Return DataProvider.Instance().CMS_DataCaculator_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DataCaculator_Update(PortalConnect As String, obj As CMS_DataCaculatorInfo)
        DataProvider.Instance().CMS_DataCaculator_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DataCaculator_Delete(PortalConnect As String, dataCaculator_ID As Integer)
        DataProvider.Instance().CMS_DataCaculator_Delete(PortalConnect, dataCaculator_ID)
    End Sub
#End Region

#Region "RPT_DataChart"
    Public Function RPT_DataChart_GetCValue(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer, isPercent As Boolean) As Double
        Return DataProvider.Instance().RPT_DataChart_GetCValue(PortalConnect, TinhTP, GroupID, TargetID, CodeCateTar, YearID, isPercent)
    End Function
    Public Function RPT_DataChart_Get(PortalConnect As String, iD As Integer) As RPT_DataChartInfo
        Return CBO.FillObject(Of RPT_DataChartInfo)(DataProvider.Instance().RPT_DataChart_Get(PortalConnect, iD))
    End Function
    Public Function RPT_DataChart_List(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_DataChart_List(PortalConnect, TinhTP, GroupID, TargetID, CodeCateTar, YearID), GetType(RPT_DataChartInfo))
    End Function

    Public Function RPT_DataChart_Add(PortalConnect As String, obj As RPT_DataChartInfo) As Integer
        Return DataProvider.Instance().RPT_DataChart_Add(PortalConnect, obj)
    End Function
    Public Sub RPT_DataChart_Update(PortalConnect As String, obj As RPT_DataChartInfo)
        DataProvider.Instance().RPT_DataChart_Update(PortalConnect, obj)
    End Sub
    Public Sub RPT_DataChart_Update_Percent(PortalConnect As String, CTotal As Double, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer)
        DataProvider.Instance().RPT_DataChart_Update_Percent(PortalConnect, CTotal, TinhTP, GroupID, TargetID, CodeCateTar, YearID)
    End Sub
    Public Sub RPT_DataChart_Delete(PortalConnect As String, TinhTP As Integer, GroupID As Integer, YearID As Integer, tarID As Integer)
        DataProvider.Instance().RPT_DataChart_Delete(PortalConnect, TinhTP, GroupID, YearID, tarID)
    End Sub
#End Region

#Region "FromCungLD"
    Public Function PTDB_LayDuLieuTuCungLD(PortalConnect As String, tinhTP As Integer, yearID As Integer, grType As Integer) As RptCungInfo
        Return CBO.FillObject(Of RptCungInfo)(DataProvider.Instance().PTDB_LayDuLieuTuCungLD(PortalConnect, tinhTP, yearID, grType))
    End Function
#End Region

#Region "InputNLD"
    Public Function InputNLD_Get(iD As String) As InputNLDInfo
        Return CBO.FillObject(Of InputNLDInfo)(DataProvider.Instance().InputNLD_Get(iD))
    End Function
    Public Function InputNLD_List(portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputNLD_List(portalId), GetType(InputNLDInfo))
    End Function
    Public Function InputNLD_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputNLD_List_Search(search, maTinh, maHuyen, maXa, thang, nam, currPage, recodperpage), GetType(InputNLDInfo))
    End Function

    Public Sub InputNLD_Add(obj As InputNLDInfo)
        DataProvider.Instance().InputNLD_Add(obj)
    End Sub
    Public Sub InputNLD_Update(obj As InputNLDInfo)
        DataProvider.Instance().InputNLD_Update(obj)
    End Sub
    Public Sub InputNLD_Delete(iD As String)
        DataProvider.Instance().InputNLD_Delete(iD)
    End Sub
    Public Sub InputNLD_Update_Quick(iD As String, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().InputNLD_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region

#Region "InputDN"
    Public Function InputDN_Get(PortalConnect As String, doanhNghiep_ID As String) As InputDNInfo
        Return CBO.FillObject(Of InputDNInfo)(DataProvider.Instance().InputDN_Get(PortalConnect, doanhNghiep_ID))
    End Function
    Public Function InputDN_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputDN_List(PortalConnect), GetType(InputDNInfo))
    End Function
    Public Function InputDN_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, maTinh As String, maHuyen As String, thangKhaoSat As Integer, namKhaoSat As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputDN_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, maTinh, maHuyen, thangKhaoSat, namKhaoSat), GetType(InputDNInfo))
    End Function

    Public Sub InputDN_Add(PortalConnect As String, obj As InputDNInfo)
        DataProvider.Instance().InputDN_Add(PortalConnect, obj)
    End Sub
    Public Sub InputDN_Update(PortalConnect As String, obj As InputDNInfo)
        DataProvider.Instance().InputDN_Update(PortalConnect, obj)
    End Sub
    Public Sub InputDN_Delete(PortalConnect As String, doanhNghiep_ID As String, userId As String)
        DataProvider.Instance().InputDN_Delete(PortalConnect, doanhNghiep_ID, userId)
    End Sub
    Public Function InputDN_CheckMaPhieu(MaPhieu As String) As Integer
        Return DataProvider.Instance().InputDN_CheckMaPhieu(MaPhieu)
    End Function
#End Region

#Region "InputNLD2024"
    Public Function InputNLD2024_Get(iD As String) As InputNLD2024Info
        Return CBO.FillObject(Of InputNLD2024Info)(DataProvider.Instance().InputNLD2024_Get(iD))
    End Function
    Public Function InputNLD2024_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputNLD2024_List(), GetType(InputNLD2024Info))
    End Function
    Public Function InputNLD2024_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().InputNLD2024_List_Search(search, maTinh, maHuyen, maXa, thang, nam, currPage, recodperpage), GetType(InputNLD2024Info))
    End Function
    Public Sub InputNLD2024_Add(obj As InputNLD2024Info)
        DataProvider.Instance().InputNLD2024_Add(obj)
    End Sub
    Public Sub InputNLD2024_Update(obj As InputNLD2024Info)
        DataProvider.Instance().InputNLD2024_Update(obj)
    End Sub
    Public Sub InputNLD2024_Delete(iD As String)
        DataProvider.Instance().InputNLD2024_Delete(iD)
    End Sub
#End Region

#Region "HT_DisplayHome"
    Public Function HT_DisplayHome_Get(iD As Integer) As HT_DisplayHomeInfo
        Return CBO.FillObject(Of HT_DisplayHomeInfo)(DataProvider.Instance().HT_DisplayHome_Get(iD))
    End Function
    Public Function HT_DisplayHome_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().HT_DisplayHome_List(), GetType(HT_DisplayHomeInfo))
    End Function
    Public Function HT_DisplayHome_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().HT_DisplayHome_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(HT_DisplayHomeInfo))
    End Function

    Public Sub HT_DisplayHome_Add(obj As HT_DisplayHomeInfo)
        DataProvider.Instance().HT_DisplayHome_Add(obj)
    End Sub
    Public Sub HT_DisplayHome_Update(obj As HT_DisplayHomeInfo)
        DataProvider.Instance().HT_DisplayHome_Update(obj)
    End Sub
    Public Sub HT_DisplayHome_Delete(iD As Integer)
        DataProvider.Instance().HT_DisplayHome_Delete(iD)
    End Sub
    Public Sub HT_DisplayHome_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().HT_DisplayHome_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region


End Class