Imports DotNetNuke.EPORTAL
Imports Microsoft.ApplicationBlocks.Data
Public Class SqlDataProvider
    Inherits DataProvider
#Region "CMS_Group"
    Public Overrides Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Group_Get", group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Group_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Group_List_By_ParentID", asxh_id, parentid), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Group_List_Parent_Null", asxh_id, groupType), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Group_List_Search", asxh_id, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Group_Count_Parent", group_ID), Integer)
    End Function

    Public Overrides Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Group_Add", obj.Group_Code, obj.ASXH_ID, obj.ParentID, obj.Group_Name, obj.Group_Des, obj.GroupType, obj.ChartType, obj.ClassName, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Group_Update", obj.Group_ID, obj.Group_Code, obj.ASXH_ID, obj.ParentID, obj.Group_Name, obj.Group_Des, obj.GroupType, obj.ChartType, obj.ClassName, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Group_Delete", group_ID)
    End Sub
#End Region
#Region "CMS_UnitType"
    Public Overrides Function CMS_UnitType_Get(PortalConnect As String, unitType_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_UnitType_Get", unitType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UnitType_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_UnitType_List"), IDataReader)
    End Function

    Public Overrides Function CMS_UnitType_Add(PortalConnect As String, obj As CMS_UnitTypeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_UnitType_Add", obj.UnitType_Code, obj.UnitType_Name, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_UnitType_Update(PortalConnect As String, obj As CMS_UnitTypeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_UnitType_Update", obj.UnitType_ID, obj.UnitType_Code, obj.UnitType_Name, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Function CMS_UnitType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_UnitType_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_UnitType_Delete(PortalConnect As String, unitType_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_UnitType_Delete", unitType_ID)
    End Sub
#End Region
#Region "CMS_Data"
    Public Overrides Function CMS_Data_Get(PortalConnect As String, data_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Data_Get", data_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Data_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Data_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Data_Add(PortalConnect As String, obj As CMS_DataInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Data_Add", obj.Report_ID, obj.Targets_ID, obj.Targets_Code, obj.Unit_ID, obj.GiaTri, obj.IsDes, obj.IsCenter), Integer)
    End Function
    Public Overrides Function CMS_Data_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Data_Get_By_Years", tinhTp, groupID, targetID, yearID), Double)
    End Function
    Public Overrides Function CMS_Data_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Data_Delete_By_Years", tinhTp, groupID, targetID, yearID), Double)
    End Function
    Public Overrides Function CMS_Data_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Data_Get_By_CMS_Report", report_ID, tinhTP, groupID, yearID), IDataReader)
    End Function
    Public Overrides Sub CMS_Data_List_Report(PortalConnect As String, Temp_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Data_List_Report", Temp_ID)
    End Sub
    Public Overrides Function CMS_Data_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, ASXH_ID As Integer, Group_ID As Integer, Years_ID As Integer, Period_ID As Integer, Unit_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Data_Get_By_Years_SumData", TinhTP, ASXH_ID, Group_ID, Years_ID, Period_ID, Unit_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Data_Delete(PortalConnect As String, data_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Data_Delete", data_ID)
    End Sub
    Public Overrides Function CMS_Data_Get_By_Year_Code(PortalConnect As String, tinhTP As Integer, Targets_Code As String, years As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Data_Get_By_Year_Code", tinhTP, Targets_Code, years), Integer)
    End Function
    Public Overrides Sub CMS_Data_Update_SoLieu(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Data_Update_SoLieu", report_ID, tinhTP, groupID, yearID)
    End Sub
#End Region
#Region "CMS_Report"
    Public Overrides Function CMS_Report_Unit(PortalConnect As String, tempID As Integer, isSend As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_Unit", tempID, isSend), IDataReader)
    End Function
    Public Overrides Function CMS_Report_List_Years(PortalConnect As String, tinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_List_Years", tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Report_List_Period(PortalConnect As String, tinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_List_Period", tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Report_List_Search(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Level_ID As Integer, Years_ID As Integer, search As String, Status As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_List_Search", TinhTP, QuanHuyen, XaPhuong, ASXH_ID, Group_ID, Level_ID, Years_ID, search, Status, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Report_Get_ByTarget(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer, Period_ID As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Report_Get_ByTarget", TinhTP, QuanHuyen, XaPhuong, ASXH_ID, Group_ID, Target_ID, Years_ID, Period_ID), String)
    End Function
    Public Overrides Function CMS_Report_List_ByTem(PortalConnect As String, TempID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_List_ByTem", TempID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Report_Get(PortalConnect As String, report_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_Get", report_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Report_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Report_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Report_Add(PortalConnect As String, obj As CMS_ReportInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Report_Add", obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ASXH_ID, obj.Group_ID, obj.Temp_ID, obj.Temp_Name, obj.Level_ID, obj.Unit_ID, obj.Period_ID, obj.Years_ID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Report_Update(PortalConnect As String, obj As CMS_ReportInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Report_Update", obj.Report_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ASXH_ID, obj.Group_ID, obj.Temp_ID, obj.Temp_Name, obj.Level_ID, obj.Unit_ID, obj.Period_ID, obj.Years_ID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Report_Return(PortalConnect As String, reportID As Integer, ngaytralai As DateTime, nguoitralai As String, lydotralai As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Report_Return", reportID, ngaytralai, nguoitralai, lydotralai)
    End Sub
    Public Overrides Sub CMS_Report_Update_Send(PortalConnect As String, Report_ID As Integer, SendDate As DateTime, SendUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Report_Update_Send", Report_ID, SendDate, SendUser)
    End Sub
    Public Overrides Sub CMS_Report_Delete(PortalConnect As String, report_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Report_Delete", report_ID)
    End Sub
#End Region
#Region "CMS_Targets"
    Public Overrides Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_By_Group_Parent", group_ID, ParentID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Get_By_CMS_Temp_Parent_NULL", temp_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Get_By_CMS_Temp_Parent_ID", temp_ID, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_By_Group_ID", group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Get", targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Targets_Get_ByCode", targets_code), Integer)
    End Function
    Public Overrides Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_TinhTP", TinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Targets_Count_TinhTP", TinhTP)
    End Function
    Public Overrides Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentID As Integer) As String
        Return SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Targets_GenCode", maTinh, maHuyen, maXa, asxh_id, group_id, targetID, parentID)
    End Function
    Public Overrides Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Sys_CopyTarget", TinhTP1, TinhTP2, CreatedUser, CreatedDate)
    End Function
    Public Overrides Function CMS_Targets_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_IsGroup(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_IsGroup"), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_ByCateTar", GroupID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_Search", search, isOrder, currPage, recodperpage, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_Parent_Null", tinhTP, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_Parent_Null_ByRegTar", tinhTP, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Parent_Search_Null", search, isOrder), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Parent_Search_ID", tinhTp, quanhuyen, phuongxa, search, asxh_id, group_id, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_Analytic", tinhTp, search, group_id, Parent_ID, isMain), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_List_Select", tinhTp, asxh_id, group_id), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Get_By_CMS_Targets", Targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Targets_Get_By_CMS_Targets_ByRegTar", tinhTp, Targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Targets_Add", obj.TinhTP, obj.Quanhuyen, obj.Phuongxa, obj.ASXH_ID, obj.Group_ID, obj.Targets_Code, obj.Targets_Name, obj.Targets_Sort, obj.Targets_Des, obj.Targets_Src, obj.Targets_Caculator, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsSum, obj.IsHome, obj.IsChild, obj.IsGroup, obj.IsMain, obj.UnitTypeID), Integer)
    End Function
    Public Overrides Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Targets_Update", obj.Targets_ID, obj.TinhTP, obj.Quanhuyen, obj.Phuongxa, obj.ASXH_ID, obj.Group_ID, obj.Targets_Code, obj.Targets_Name, obj.Targets_Sort, obj.Targets_Des, obj.Targets_Src, obj.Targets_Caculator, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsSum, obj.IsHome, obj.IsChild, obj.IsGroup, obj.IsMain, obj.UnitTypeID)
    End Sub
    Public Overrides Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Targets_Delete", targets_ID)
    End Sub
#End Region
#Region "CMS_Analytic"
    Public Overrides Function CMS_Analytic_Get(PortalConnect As String, analtyic_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Analytic_Get", analtyic_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Analytic_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Analytic_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Analytic_List_ByTarget(PortalConnect As String, TargetID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Analytic_List_ByTarget", TargetID), IDataReader)
    End Function
    Public Overrides Function CMS_Analytic_List_ReportTarget(PortalConnect As String, TargetID As Integer, ValCT As Double) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Analytic_List_ReportTarget", TargetID, ValCT), IDataReader)
    End Function

    Public Overrides Sub CMS_Analytic_Add(PortalConnect As String, analtyic_ID As String, targets_ID As Integer, valueFrom As Double, valueTo As Double, contents As String, solution As String, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Analytic_Add", analtyic_ID, targets_ID, valueFrom, valueTo, contents, solution, isFlag, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser)
    End Sub
    Public Overrides Sub CMS_Analytic_Update(PortalConnect As String, analtyic_ID As String, targets_ID As Integer, valueFrom As Double, valueTo As Double, contents As String, solution As String, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Analytic_Update", analtyic_ID, targets_ID, valueFrom, valueTo, contents, solution, isFlag, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser)
    End Sub
    Public Overrides Sub CMS_Analytic_Delete(PortalConnect As String, analtyic_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Analytic_Delete", analtyic_ID)
    End Sub
#End Region
#Region "DashBoard"
    Public Overrides Function CMS_DashBoard(PortalConnect As String, tinh As Integer, asxh As Integer, group As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DashBoard", tinh, asxh, group, year), IDataReader)
    End Function
#End Region
#Region "GetDataAnaly"
    Public Overrides Function CMS_Data_ListByYear(PortalConnect As String, TinhTp As Integer, Group_ID As Integer, Target_ID As Integer, YearFrom As Integer, YearTo As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Data_ListByYear", TinhTp, Group_ID, Target_ID, YearFrom, YearTo), IDataReader)
    End Function
#End Region
#Region "CMS_Scene"
    Public Overrides Function CMS_Scene_Get(PortalConnect As String, scene_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Scene_Get", scene_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Scene_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Scene_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Scene_List_ByTinhTP(PortalConnect As String, tinhTp As Integer, typeScene As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Scene_List_ByTinhTP", tinhTp, typeScene), IDataReader)
    End Function

    Public Overrides Function CMS_Scene_Add(PortalConnect As String, obj As CMS_SceneInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Scene_Add", obj.Scene_ID, obj.YearID, obj.Data, obj.TinhTP, obj.TypeScene), Integer)
    End Function
    Public Overrides Function CMS_Scene_GetData(PortalConnect As String, YearID As Integer, TinhTp As Integer, TypeScene As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Scene_GetData", YearID, TinhTp, TypeScene), Double)
    End Function
    Public Overrides Sub CMS_Scene_Update(PortalConnect As String, obj As CMS_SceneInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Scene_Update", obj.Scene_ID, obj.YearID, obj.Data, obj.TinhTP, obj.TypeScene)
    End Sub
    Public Overrides Sub CMS_Scene_Delete(PortalConnect As String, scene_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Scene_Delete", scene_ID)
    End Sub
#End Region
#Region "CMS_DataSave"
    Public Overrides Function CMS_DataSave_Get(PortalConnect As String, data_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataSave_Get", data_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DataSave_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataSave_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DataSave_Add(PortalConnect As String, obj As CMS_DataSaveInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_DataSave_Add", obj.Report_ID, obj.TinhTP, obj.GroupID, obj.YearID, obj.Targets_ID, obj.Targets_Code, obj.GiaTri, obj.GiaTri2, obj.GiaTri3), Integer)
    End Function
    Public Overrides Function CMS_DataSave_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_DataSave_Get_By_Years", tinhTp, groupID, targetID, yearID), Double)
    End Function
    Public Overrides Function CMS_DataSave_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_DataSave_Delete_By_Years", tinhTp, groupID, targetID, yearID), Double)
    End Function
    Public Overrides Function CMS_DataSave_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataSave_Get_By_CMS_Report", report_ID, tinhTP, groupID, yearID), IDataReader)
    End Function
    Public Overrides Sub CMS_DataSave_List_Report(PortalConnect As String, Temp_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_DataSave_List_Report", Temp_ID)
    End Sub
    Public Overrides Function CMS_DataSave_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Years_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataSave_Get_By_Years_SumData", TinhTP, Group_ID, Years_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_DataSave_Delete(PortalConnect As String, data_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_DataSave_Delete", data_ID)
    End Sub
#End Region
#Region "CMS_ReportSave"

    Public Overrides Function CMS_ReportSave_Get_ByTarget(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_ReportSave_Get_ByTarget", TinhTP, Group_ID, Target_ID, Years_ID), String)
    End Function
    Public Overrides Function CMS_ReportSave_List_Years(PortalConnect As String, tinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_ReportSave_List_Years", tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_ReportSave_Get(PortalConnect As String, report_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_ReportSave_Get", report_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ReportSave_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_ReportSave_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ReportSave_Add(PortalConnect As String, obj As CMS_ReportSaveInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_ReportSave_Add", obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_ReportSave_Update(PortalConnect As String, obj As CMS_ReportSaveInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_ReportSave_Update", obj.Report_ID, obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_ReportSave_Delete(PortalConnect As String, report_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_ReportSave_Delete", report_ID)
    End Sub
#End Region
#Region "CMS_FileAttach"
    Public Overrides Function CMS_FileAttach_Get(PortalConnect As String, attch_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_FileAttach_Get", attch_ID), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttach_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_FileAttach_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttach_List_By_IdKey(PortalConnect As String, portalId As Integer, idKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_FileAttach_List_By_IdKey", portalId, idKey), IDataReader)
    End Function
    Public Overrides Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_FileAttach_Add", obj.Attch_ID, obj.IDKey, obj.FileAttch_Name, obj.FileAttch_Attch, obj.FileAttch_Des, obj.PortalID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_FileAttach_Update", obj.Attch_ID, obj.IDKey, obj.FileAttch_Name, obj.FileAttch_Attch, obj.FileAttch_Des, obj.PortalID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_FileAttach_Delete(PortalConnect As String, attch_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_FileAttach_Delete", attch_ID)
    End Sub
    Public Overrides Sub CMS_FileAttach_Delete_By_IdKey(PortalConnect As String, idKey As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_FileAttach_Delete_By_IdKey", idKey)
    End Sub
#End Region
#Region "CMS_Magazine"
    Public Overrides Function CMS_Magazine_Get(PortalConnect As String, magazine_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Magazine_Get", magazine_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Magazine_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Magazine_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Magazine_List_Active(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Magazine_List_Active"), IDataReader)
    End Function

    Public Overrides Function CMS_Magazine_Add(PortalConnect As String, obj As CMS_MagazineInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Magazine_Add", obj.Magazine_Name, obj.Magazine_Des, obj.Magazine_Type, obj.Magazine_Img, obj.Magazine_FileName, obj.Magazine_FileAtt, obj.GroupID, obj.YearID, obj.IsOrder, obj.IsActive, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Magazine_Update(PortalConnect As String, obj As CMS_MagazineInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Magazine_Update", obj.Magazine_ID, obj.Magazine_Name, obj.Magazine_Des, obj.Magazine_Type, obj.Magazine_Img, obj.Magazine_FileName, obj.Magazine_FileAtt, obj.GroupID, obj.YearID, obj.IsOrder, obj.IsActive, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Magazine_Delete(PortalConnect As String, magazine_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Magazine_Delete", magazine_ID)
    End Sub
#End Region
#Region "CMS_MagazineData"
    Public Overrides Function CMS_MagazineData_Get(PortalConnect As String, magazineData_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_MagazineData_Get", magazineData_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MagazineData_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_MagazineData_List"), IDataReader)
    End Function

    Public Overrides Function CMS_MagazineData_Add(PortalConnect As String, obj As CMS_MagazineDataInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_MagazineData_Add", obj.Magazine_ID, obj.GroupID, obj.TargetID, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_MagazineData_Update(PortalConnect As String, obj As CMS_MagazineDataInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_MagazineData_Update", obj.MagazineData_ID, obj.Magazine_ID, obj.GroupID, obj.TargetID, obj.IsOrder)
    End Sub
    Public Overrides Function CMS_MagazineData_Get_By_CMS_Magazine(PortalConnect As String, magazine_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_MagazineData_Get_By_CMS_Magazine", magazine_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_MagazineData_Delete(PortalConnect As String, magazineData_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_MagazineData_Delete", magazineData_ID)
    End Sub
#End Region
#Region "CMS_TypeScene"
    Public Overrides Function CMS_TypeScene_Get(PortalConnect As String, typeScene_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TypeScene_Get", typeScene_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeScene_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TypeScene_List"), IDataReader)
    End Function

    Public Overrides Function CMS_TypeScene_Add(PortalConnect As String, obj As CMS_TypeSceneInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_TypeScene_Add", obj.TypeScene_Name, obj.TypeScene_Des), Integer)
    End Function
    Public Overrides Sub CMS_TypeScene_Update(PortalConnect As String, obj As CMS_TypeSceneInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TypeScene_Update", obj.TypeScene_ID, obj.TypeScene_Name, obj.TypeScene_Des)
    End Sub
    Public Overrides Sub CMS_TypeScene_Delete(PortalConnect As String, typeScene_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TypeScene_Delete", typeScene_ID)
    End Sub
#End Region
#Region "CMS_Config"
    Public Overrides Function CMS_Config_Get(PortalConnect As String, config_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Config_Get", config_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Config_Get_ByTinhTP(PortalConnect As String, tinhTP As Integer, configValue As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Config_Get_ByTinhTP", tinhTP, configValue), IDataReader)
    End Function
    Public Overrides Function CMS_Config_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_Config_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Config_Add(PortalConnect As String, obj As CMS_ConfigInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_Config_Add", obj.Config_ID, obj.TinhTP, obj.Config_Name, obj.Config_Value, obj.Notes, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.Popula, obj.LogoDv, obj.Year1, obj.Year2, obj.txtSoNam)
    End Sub
    Public Overrides Sub CMS_Config_Update(PortalConnect As String, obj As CMS_ConfigInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Config_Update", obj.Config_ID, obj.TinhTP, obj.Config_Name, obj.Config_Value, obj.Notes, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.Popula, obj.LogoDv, obj.Year1, obj.Year2, obj.txtSoNam)
    End Sub
    Public Overrides Sub CMS_Config_Delete(PortalConnect As String, config_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_Config_Delete", config_ID)
    End Sub
#End Region
#Region "CMS_RegTar"
    Public Overrides Function CMS_RegTar_Get(PortalConnect As String, regTar_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_RegTar_Get", regTar_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RegTar_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_RegTar_List"), IDataReader)
    End Function
    Public Overrides Function CMS_RegTar_Get_By_Data(PortalConnect As String, Targets_ID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_RegTar_Get_By_Data", Targets_ID, tinhTP, quanHuyen, xaPhuong), IDataReader)
    End Function
    Public Overrides Function CMS_RegTar_Get_By_Targets_Code(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, Targets_Code As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_RegTar_Get_By_Targets_Code", tinhTP, quanHuyen, xaPhuong, Targets_Code), Integer)
    End Function
    Public Overrides Function CMS_RegTar_Get_By_Temp_Drap(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer, tempID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_RegTar_Get_By_Temp_Drap", tinhTP, quanHuyen, xaPhuong, groupID, asxhID, ParentId, tempID), IDataReader)
    End Function
    Public Overrides Function CMS_RegTar_Get_By_Temp(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_RegTar_Get_By_Temp", tinhTP, quanHuyen, xaPhuong, groupID, asxhID, ParentId), IDataReader)
    End Function
    Public Overrides Sub CMS_RegTar_Add(PortalConnect As String, obj As CMS_RegTarInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_RegTar_Add", obj.RegTar_ID, obj.Targets_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.Targets_Code)
    End Sub
    Public Overrides Sub CMS_RegTar_Update(PortalConnect As String, obj As CMS_RegTarInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_RegTar_Update", obj.RegTar_ID, obj.Targets_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.Targets_Code)
    End Sub
    Public Overrides Sub CMS_RegTar_Delete(PortalConnect As String, regTar_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_RegTar_Delete", regTar_ID)
    End Sub
    Public Overrides Sub CMS_RegTar_Delete_Target(PortalConnect As String, TinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, targerID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_RegTar_Delete_Target", TinhTP, quanHuyen, xaPhuong, targerID)
    End Sub
#End Region
#Region "CMS_InDataRow"
    Public Overrides Function CMS_InDataRow_Get(PortalConnect As String, dataRow_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRow_Get", dataRow_ID), IDataReader)
    End Function
    Public Overrides Function CMS_InDataRow_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRow_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_InDataRow_Delete_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRow_Delete_By_CMS_InputRpt", inputRpt_ID)
    End Sub
    Public Overrides Sub CMS_InDataRow_Add(PortalConnect As String, obj As CMS_InDataRowInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InDataRow_Add", obj.DataRow_ID, obj.InputRpt_ID, obj.InputRptC_ID, obj.NoiDung, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_InDataRow_Update(PortalConnect As String, obj As CMS_InDataRowInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRow_Update", obj.DataRow_ID, obj.InputRpt_ID, obj.InputRptC_ID, obj.NoiDung, obj.IsOrder)
    End Sub
    Public Overrides Function CMS_InDataRow_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRow_Get_By_CMS_InputRpt", inputRpt_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_InDataRow_Delete(PortalConnect As String, dataRow_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRow_Delete", dataRow_ID)
    End Sub
#End Region
#Region "CMS_InputRptC"
    Public Overrides Function CMS_InputRptC_Get(PortalConnect As String, inputRptC_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRptC_Get", inputRptC_ID), IDataReader)
    End Function

    Public Overrides Function CMS_InputRptC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRptC_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_InputRptC_Add(PortalConnect As String, obj As CMS_InputRptCInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InputRptC_Add", obj.InputRptC_ID, obj.InputRpt_ID, obj.Targets_ID, obj.Column_Name, obj.IsOrder, obj.ColType, obj.ExColum, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_InputRptC_Update(PortalConnect As String, obj As CMS_InputRptCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InputRptC_Update", obj.InputRptC_ID, obj.InputRpt_ID, obj.Targets_ID, obj.Column_Name, obj.IsOrder, obj.ColType, obj.ExColum, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Function CMS_InputRptC_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, colType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRptC_Get_By_CMS_InputRpt", inputRpt_ID, colType), IDataReader)
    End Function
    Public Overrides Sub CMS_InputRptC_Delete(PortalConnect As String, inputRptC_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InputRptC_Delete", inputRptC_ID)
    End Sub



#End Region
#Region "CMS_TempRptC"
    Public Overrides Function CMS_TempRptC_Get(PortalConnect As String, tempRptC_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRptC_Get", tempRptC_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TempRptC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRptC_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_TempRptC_Add(PortalConnect As String, obj As CMS_TempRptCInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_TempRptC_Add", obj.TempRptC_ID, obj.TempRpt_ID, obj.Targets_ID, obj.Column_Name, obj.IsOrder, obj.ColType, obj.ExColum, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_TempRptC_Update(PortalConnect As String, obj As CMS_TempRptCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TempRptC_Update", obj.TempRptC_ID, obj.TempRpt_ID, obj.Targets_ID, obj.Column_Name, obj.IsOrder, obj.ColType, obj.ExColum, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Function CMS_TempRptC_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer, colType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRptC_Get_By_CMS_TempRpt", tempRpt_ID, colType), IDataReader)
    End Function
    Public Overrides Sub CMS_TempRptC_Delete(PortalConnect As String, tempRptC_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TempRptC_Delete", tempRptC_ID)
    End Sub
#End Region
#Region "CMS_InDataRowC"
    Public Overrides Function CMS_InDataRowC_Get(PortalConnect As String, dataRowC_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRowC_Get", dataRowC_ID), IDataReader)
    End Function
    Public Overrides Function CMS_InDataRowC_Get_Data(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetCol_ID As Integer, targetRow_ID As Integer, cateCol_ID As Integer, cateRow_ID As Integer, dataType As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InDataRowC_Get_Data", tinhTp, yearID, groupID, targetCol_ID, targetRow_ID, cateCol_ID, cateRow_ID, dataType), Double)
    End Function
    Public Overrides Function CMS_InDataRowC_Get_Data_Simple(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InDataRowC_Get_Data_Simple", tinhTp, yearID, groupID, targetRow_ID, cateRow_ID), Double)
    End Function
    Public Overrides Function CMS_InDataRowC_Get_Data_Adv(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer, targetCol_ID As Integer, cateCol_ID As Integer) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InDataRowC_Get_Data_Adv", tinhTp, yearID, groupID, targetRow_ID, cateRow_ID, targetCol_ID, cateCol_ID), Double)
    End Function
    Public Overrides Function CMS_InDataRowC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRowC_List"), IDataReader)
    End Function
    Public Overrides Function CMS_InDataRowC_Add(PortalConnect As String, obj As CMS_InDataRowCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InDataRowC_Add", obj.DataRow_ID, obj.InputRpt_ID, obj.InputRptC_ID, obj.Targets_ID, obj.ColType, obj.GiaTri_Text, obj.GiaTri_So, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_InDataRowC_Update(PortalConnect As String, obj As CMS_InDataRowCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRowC_Update", obj.DataRowC_ID, obj.DataRow_ID, obj.InputRpt_ID, obj.InputRptC_ID, obj.Targets_ID, obj.ColType, obj.GiaTri_Text, obj.GiaTri_So, obj.IsOrder)
    End Sub
    Public Overrides Function CMS_InDataRowC_Get_By_CMS_InputRpt(PortalConnect As String, InputRpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRowC_Get_By_CMS_InputRpt", InputRpt_ID), IDataReader)
    End Function
    Public Overrides Function CMS_InDataRowC_Get_By_CMS_InDataRow(PortalConnect As String, dataRow_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InDataRowC_Get_By_CMS_InDataRow", dataRow_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_InDataRowC_Delete(PortalConnect As String, dataRowC_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRowC_Delete", dataRowC_ID)
    End Sub
    Public Overrides Sub CMS_InDataRowC_Delete_Value(PortalConnect As String, dataRow_ID As String, inputRptC_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InDataRowC_Delete_Value", dataRow_ID, inputRptC_ID)
    End Sub

#End Region
#Region "CMS_InputRpt"
    Public Overrides Function CMS_InputRpt_Get(PortalConnect As String, inputRpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRpt_Get", inputRpt_ID), IDataReader)
    End Function
    Public Overrides Function CMS_InputRpt_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRpt_List"), IDataReader)
    End Function
    Public Overrides Function CMS_InputRpt_List_Search(PortalConnect As String, search As String, tinhTP As Integer, Group_ID As Integer, Years_ID As Integer, TrangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRpt_List_Search", search, tinhTP, Group_ID, Years_ID, TrangThai, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function CMS_InputRpt_Add(PortalConnect As String, obj As CMS_InputRptInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_InputRpt_Add", obj.TempRpt_ID, obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.Temp_Name, obj.Temp_Des, obj.CreatedDate, obj.CreatedUser, obj.TrangThai, obj.SendDate, obj.SendUser, obj.UpdatedDate, obj.UpdatedUser, obj.ReturnDate, obj.ReturnUser, obj.ReturnReason), Integer)
    End Function
    Public Overrides Sub CMS_InputRpt_Update(PortalConnect As String, obj As CMS_InputRptInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InputRpt_Update", obj.InputRpt_ID, obj.TempRpt_ID, obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.Temp_Name, obj.Temp_Des, obj.CreatedDate, obj.CreatedUser, obj.TrangThai, obj.SendDate, obj.SendUser, obj.UpdatedDate, obj.UpdatedUser, obj.ReturnDate, obj.ReturnUser, obj.ReturnReason)
    End Sub
    Public Overrides Function CMS_InputRpt_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_InputRpt_Get_By_CMS_TempRpt", tempRpt_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_InputRpt_Delete(PortalConnect As String, inputRpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_InputRpt_Delete", inputRpt_ID)
    End Sub
#End Region
#Region "CMS_TempRpt"
    Public Overrides Function CMS_TempRpt_Get(PortalConnect As String, tempRpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRpt_Get", tempRpt_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TempRpt_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRpt_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TempRpt_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Group_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_TempRpt_List_Search", search, isOrder, currPage, recodperpage, Group_ID), IDataReader)
    End Function

    Public Overrides Function CMS_TempRpt_Add(PortalConnect As String, obj As CMS_TempRptInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_TempRpt_Add", obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.Temp_Name, obj.Temp_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_TempRpt_Update(PortalConnect As String, obj As CMS_TempRptInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TempRpt_Update", obj.TempRpt_ID, obj.TinhTP, obj.Group_ID, obj.Years_ID, obj.Temp_Name, obj.Temp_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_TempRpt_Delete(PortalConnect As String, tempRpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_TempRpt_Delete", tempRpt_ID)
    End Sub
#End Region

#Region "CMS_CateTar"
    Public Overrides Function CMS_CateTar_Get_ByCode(PortalConnect As String, iD As Integer, targetID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_CateTar_Get_ByCode", iD, targetID), IDataReader)
    End Function
    Public Overrides Function CMS_CateTar_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_CateTar_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CateTar_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_CateTar_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CateTar_List_ByTarget(PortalConnect As String, target_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_CateTar_List_ByTarget", target_ID), IDataReader)
    End Function
    Public Overrides Function CMS_CateTar_Check_ByTarget(PortalConnect As String, target_ID As Integer) As Boolean
        Return SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_CateTar_Check_ByTarget", target_ID)
    End Function

    Public Overrides Function CMS_CateTar_Add(PortalConnect As String, obj As CMS_CateTarInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_CateTar_Add", obj.ID, obj.Target_ID, obj.CodeCateTar, obj.CateName, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_CateTar_Update(PortalConnect As String, obj As CMS_CateTarInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_CateTar_Update", obj.ID, obj.Target_ID, obj.CodeCateTar, obj.CateName, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_CateTar_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_CateTar_Delete", iD)
    End Sub
#End Region

#Region "CMS_DataCaculator"
    Public Overrides Function CMS_DataCaculator_Get(PortalConnect As String, dataCaculator_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataCaculator_Get", dataCaculator_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DataCaculator_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "CMS_DataCaculator_List"), IDataReader)
    End Function

    Public Overrides Function CMS_DataCaculator_Add(PortalConnect As String, obj As CMS_DataCaculatorInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "CMS_DataCaculator_Add", obj.TinhTP, obj.GroupID, obj.YearID, obj.Targets_ID, obj.Targets_Code, obj.Unit_ID, obj.GiaTri, obj.GiaTri2), Integer)
    End Function
    Public Overrides Sub CMS_DataCaculator_Update(PortalConnect As String, obj As CMS_DataCaculatorInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_DataCaculator_Update", obj.DataCaculator_ID, obj.TinhTP, obj.GroupID, obj.YearID, obj.Targets_ID, obj.Targets_Code, obj.Unit_ID, obj.GiaTri, obj.GiaTri2)
    End Sub
    Public Overrides Sub CMS_DataCaculator_Delete(PortalConnect As String, dataCaculator_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "CMS_DataCaculator_Delete", dataCaculator_ID)
    End Sub
#End Region
#Region "RPT_DataChart"
    Public Overrides Function RPT_DataChart_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "RPT_DataChart_Get", iD), IDataReader)
    End Function
    Public Overrides Function RPT_DataChart_GetCValue(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer, isPercent As Boolean) As Double
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "RPT_DataChart_GetCValue", TinhTP, GroupID, TargetID, CodeCateTar, YearID, isPercent), Double)
    End Function
    Public Overrides Function RPT_DataChart_List(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "RPT_DataChart_List", TinhTP, GroupID, TargetID, CodeCateTar, YearID), IDataReader)
    End Function

    Public Overrides Function RPT_DataChart_Add(PortalConnect As String, obj As RPT_DataChartInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "RPT_DataChart_Add", obj.CName, obj.CValue, obj.CPercent, obj.TinhTP, obj.GroupID, obj.TargetID, obj.CodeCateTar, obj.YearID), Integer)
    End Function
    Public Overrides Sub RPT_DataChart_Update(PortalConnect As String, obj As RPT_DataChartInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "RPT_DataChart_Update", obj.ID, obj.CName, obj.CValue, obj.TinhTP, obj.GroupID, obj.TargetID, obj.CodeCateTar, obj.YearID)
    End Sub
    Public Overrides Sub RPT_DataChart_Update_Percent(PortalConnect As String, CTotal As Double, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "RPT_DataChart_Update_Percent", CTotal, TinhTP, GroupID, TargetID, CodeCateTar, YearID)
    End Sub
    Public Overrides Sub RPT_DataChart_Delete(PortalConnect As String, TinhTP As Integer, GroupID As Integer, YearID As Integer, tarID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "RPT_DataChart_Delete", TinhTP, GroupID, YearID, tarID)
    End Sub
#End Region
#Region "FromCungLD"
    Public Overrides Function PTDB_LayDuLieuTuCungLD(PortalConnect As String, tinhTP As Integer, yearID As Integer, grType As Integer) As IDataReader
        'Select Case grType
        '    Case NhomCung.LDCVL
        '        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "PTDB_LDCVL", tinhTP, yearID), IDataReader)
        '    Case NhomCung.LLLD
        '        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "PTDB_LLLD", tinhTP, yearID), IDataReader)
        '    Case NhomCung.TTTN
        '        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "PTDB_TTTN", tinhTP, yearID), IDataReader)
        '    Case Else
        '        Return CType(SqlHelper.ExecuteReader(flConnect.CungConnect, "PTDB_DSTren15", tinhTP, yearID), IDataReader)
        'End Select
    End Function
#End Region

#Region "InputNLD"
    Public Overrides Function InputNLD_Get(iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD_Get", iD), IDataReader)
    End Function
    Public Overrides Function InputNLD_List(portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD_List", portalId), IDataReader)
    End Function
    Public Overrides Function InputNLD_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD_List_Search", search, maTinh, maHuyen, maXa, thang, nam, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Sub InputNLD_Add(obj As InputNLDInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "InputNLD_Add", obj.ID, obj.MaDoiTuong, obj.MaPhieuTuDong, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.DTUT_NKT, obj.DTUT_HN, obj.DTUT_DTTS, obj.NCVL, obj.NTN, obj.KTGHDKT, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.TonGiao, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.MaNganhDT, obj.ChuyenNganhDT, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.CongViecDangLam, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.CongViecThamGia, obj.ThoiGianThatNghiep, obj.LyDoKhongThamGia, obj.GhiChu, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag, obj.KhuVuc, obj.CMND, obj.JoinHDKT, obj.UnJoinHDKT, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DTUT, obj.DTUT_Khac, obj.NN1_Ten, obj.NN1_Loai, obj.NN1_MD, obj.NN2_Ten, obj.NN2_Loai, obj.NN2_MD, obj.TH1_Ten, obj.TH1_Loai, obj.TH1_MD, obj.TH2_Ten, obj.TH2_Loai, obj.TH2_MD, obj.KyNangMem, obj.KyNangMemKhac, obj.MaNganhNghe, obj.LoaiHopDong, obj.CoThamGiaBHXH, obj.LoaiBHXH, obj.ThuNhapBQ, obj.SoGioLamViecChinh, obj.SoGioLamTatCa, obj.CoSSLamThem, obj.ViTriCoPhuHop, obj.KenhTimViec, obj.KenhKhac, obj.CoNCTimViec, obj.LyDoThatNghiep, obj.LyDoTNKhac, obj.TN_CoNCTimViec, obj.KenhTimViecTN, obj.KenhTNKhac, obj.KinhNghiem, obj.ChucVu, obj.ChucVuKhac, obj.DiaBanLamViec, obj.TinhLamViec, obj.HuyenLamViec, obj.LHDMongMuon, obj.LoaiLamViec, obj.HinhThucLamViec, obj.MucDichMongMuon, obj.MucLuongMongMuon, obj.CheDoPhucLoi, obj.CheDoKhac, obj.DuKienLamViec, obj.SoThangDuKien, obj.HinhThucTuyenDung, obj.NhuCauXuatKhau, obj.TenNuocXuatKhau, obj.MucLuongXuatKhau, obj.DeXuatKienNghi, obj.ThangKhaoSat, obj.NamKhaoSat, obj.NganhNgheMongMuon, obj.CVMongMuon, obj.CVMongMuonCuThe, obj.MaCVMongMuon, obj.KinhNghiemLV)
    End Sub
    Public Overrides Sub InputNLD_Update(obj As InputNLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputNLD_Update", obj.ID, obj.MaDoiTuong, obj.MaPhieuTuDong, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.DTUT_NKT, obj.DTUT_HN, obj.DTUT_DTTS, obj.NCVL, obj.NTN, obj.KTGHDKT, obj.SoThuTu, obj.HoTen, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.TonGiao, obj.QuanHe, obj.NgaySinh, obj.TrinhDoGD, obj.TrinhDoCM, obj.MaNganhDT, obj.ChuyenNganhDT, obj.LinhVucDT, obj.HinhThuc, obj.LoaiHinhKT, obj.NoiLamViec, obj.NganhNghe, obj.CongViecDangLam, obj.DiaChiLamViec, obj.NuocLamViec, obj.LoaiThatNghiep, obj.CongViecThamGia, obj.ThoiGianThatNghiep, obj.LyDoKhongThamGia, obj.GhiChu, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag, obj.KhuVuc, obj.CMND, obj.JoinHDKT, obj.UnJoinHDKT, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DTUT, obj.DTUT_Khac, obj.NN1_Ten, obj.NN1_Loai, obj.NN1_MD, obj.NN2_Ten, obj.NN2_Loai, obj.NN2_MD, obj.TH1_Ten, obj.TH1_Loai, obj.TH1_MD, obj.TH2_Ten, obj.TH2_Loai, obj.TH2_MD, obj.KyNangMem, obj.KyNangMemKhac, obj.MaNganhNghe, obj.LoaiHopDong, obj.CoThamGiaBHXH, obj.LoaiBHXH, obj.ThuNhapBQ, obj.SoGioLamViecChinh, obj.SoGioLamTatCa, obj.CoSSLamThem, obj.ViTriCoPhuHop, obj.KenhTimViec, obj.KenhKhac, obj.CoNCTimViec, obj.LyDoThatNghiep, obj.LyDoTNKhac, obj.TN_CoNCTimViec, obj.KenhTimViecTN, obj.KenhTNKhac, obj.KinhNghiem, obj.ChucVu, obj.ChucVuKhac, obj.DiaBanLamViec, obj.TinhLamViec, obj.HuyenLamViec, obj.LHDMongMuon, obj.LoaiLamViec, obj.HinhThucLamViec, obj.MucDichMongMuon, obj.MucLuongMongMuon, obj.CheDoPhucLoi, obj.CheDoKhac, obj.DuKienLamViec, obj.SoThangDuKien, obj.HinhThucTuyenDung, obj.NhuCauXuatKhau, obj.TenNuocXuatKhau, obj.MucLuongXuatKhau, obj.DeXuatKienNghi, obj.ThangKhaoSat, obj.NamKhaoSat, obj.NganhNgheMongMuon, obj.CVMongMuon, obj.CVMongMuonCuThe, obj.MaCVMongMuon, obj.KinhNghiemLV)
    End Sub
    Public Overrides Sub InputNLD_Delete(iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputNLD_Delete", iD)
    End Sub
    Public Overrides Sub InputNLD_Update_Quick(iD As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputNLD_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region

#Region "InputDN"
    Public Overrides Function InputDN_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputDN_Get", doanhNghiep_ID), IDataReader)
    End Function
    Public Overrides Function InputDN_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputDN_List"), IDataReader)
    End Function
    Public Overrides Function InputDN_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, maTinh As String, maHuyen As String, thangKhaoSat As Integer, namKhaoSat As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputDN_List_Search", search, isOrder, currPage, recodperpage, maTinh, maHuyen, thangKhaoSat, namKhaoSat), IDataReader)
    End Function
    Public Overrides Sub InputDN_Add(PortalConnect As String, obj As InputDNInfo)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "InputDN_Add", obj.DoanhNghiep_ID, obj.ThangKhaoSat, obj.NamKhaoSat, obj.MaDoanhNghiep, obj.TenDoanhNghiep, obj.MaSDDKD, obj.LoaiHinh, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DiaChi, obj.KCNKKT, obj.SoDienThoai, obj.Email, obj.Website, obj.NamThanhLap, obj.NganhSanXuat, obj.QuyMo, obj.TongSoLaoDong, obj.TongSoLaoDongNu, obj.SoLDNgoaiTinh, obj.SoLDNgoaiTinhNu, obj.SoLDTrucTiep, obj.SoLDTrucTiepNu, obj.SoLDGianTiep, obj.SoLDGianTiepNu, obj.SoLDDaKyHopDong, obj.SoLDDaKyHopDongNu, obj.SoLDBHXH, obj.SoLDBHXHNu, obj.SoLDTren35, obj.SoLDTren35Nu, obj.SoLDNguoiNN, obj.SoLDNguoiNNNu, obj.SoLDTHPT, obj.SoLDTHPTNU, obj.SoLDTDKhongCo, obj.SoLDTDKhongCoNu, obj.SoLDTDCongNhan, obj.SoLDTDCongNhanNu, obj.SoLDTDDaoTao, obj.SoLDTDDaoTaoNu, obj.SoLDTDSoCap, obj.SoLDTDSoCapNu, obj.SoLDTDTrungCap, obj.SoLDTDTrungCapNu, obj.SoLDTDCaoDang, obj.SoLDTDCaoDangNu, obj.SoLDTDDaiHoc, obj.SoLDTDDaiHocNu, obj.SoLDLVChuongTrinh, obj.SoLDLVChuongTrinhNu, obj.SoLDLVKhoaHoc, obj.SoLDLVKhoaHocNu, obj.SoLDLVNgheThuat, obj.SoLDLVNgheThuatNu, obj.SoLDLVNhanVan, obj.SoLDLVNhanVanNu, obj.SoLDLVKhoaHocXH, obj.SoLDLVKhoaHocXHNu, obj.SoLDLVBaoTri, obj.SoLDLVBaoTriNu, obj.SoLDLVKinhDoanh, obj.SoLDLVKinhDoanhNu, obj.SoLDLVPhapLuat, obj.SoLDLVPhapLuatNu, obj.SoLDLVKhoaHocSS, obj.SoLDLVKhoaHocSSNu, obj.SoLDLVKhoaHocTN, obj.SoLDLVKhoaHocTNNu, obj.SoLDLVToan, obj.SoLDLVToanNu, obj.SoLDLVMayTinh, obj.SoLDLVMayTinhNu, obj.SoLDLVCongNghe, obj.SoLDLVCongNgheNu, obj.SoLDLVKyThuat, obj.SoLDLVKyThuatNu, obj.SoLDLVSanXuat, obj.SoLDLVSanXuatNu, obj.SoLDLVKienTruc, obj.SoLDLVKienTrucNu, obj.SoLDLVNongLam, obj.SoLDLVNongLamNu, obj.SoLDLVThuY, obj.SoLDLVThuYNu, obj.SoLDLVSucKhoe, obj.SoLDLVSucKhoeNu, obj.SoLDLVDichVuXH, obj.SoLDLVDichVuXHNu, obj.SoLDLVDuLich, obj.SoLDLVDuLichNu, obj.SoLDLVDichVuVT, obj.SoLDLVDichVuVTNu, obj.SoLDLVMoiTruong, obj.SoLDLVMoiTruongNu, obj.SoLDLVAnNinh, obj.SoLDLVAnNinhNu, obj.SoLDLVKhac, obj.SoLDLVKhacNu, obj.SoLDNNLanhDao, obj.SoLDNNLanhDaoNu, obj.SoLDNNKyThuatBC, obj.SoLDNNKyThuatBCNu, obj.SoLDNNKyThuatBT, obj.SoLDNNKyThuatBTNu, obj.SoLDNNNhanVienNghe, obj.SoLDNNNhanVienNgheNu, obj.SoLDNNNhanVienDV, obj.SoLDNNNhanVienDVNu, obj.SoLDNNLaoDongCoKT, obj.SoLDNNLaoDongCoKTNu, obj.SoLDNNThoThuCong, obj.SoLDNNThoThuCongNu, obj.SoLDNNThoKyThuat, obj.SoLDNNThoKyThuatNu, obj.SoLDNNLaoDongPT, obj.SoLDNNLaoDongPTNu, obj.SoLDTDTiengAnh, obj.SoLDTDTiengAnhNu, obj.SoLDTDTiengTrung, obj.SoLDTDTiengTrungNu, obj.SoLDTDTiengNhat, obj.SoLDTDTiengNhatNu, obj.SoLDTDTiengKhac, obj.SoLDTDTiengKhacNu, obj.SoLDTDTinHocCB, obj.SoLDTDTinHocCBNu, obj.SoLDTDTinHocNC, obj.SoLDTDTinHocNCNu, obj.SoLDTDTinHocNC2, obj.SoLDTDTinHocNC2Nu, obj.TienLuongBinhQuan, obj.TienLuongThapNhat, obj.TienLuongCaoNhat, obj.DanhGia11KN, obj.DanhGia11MD, obj.DanhGia12KN, obj.DanhGia12MD, obj.DanhGia13KN, obj.DanhGia13MD, obj.DanhGia21KN, obj.DanhGia21MD, obj.DanhGia22KN, obj.DanhGia22MD, obj.DanhGia23KN, obj.DanhGia23MD, obj.DanhGia31KN, obj.DanhGia31MD, obj.DanhGia32KN, obj.DanhGia32MD, obj.DanhGia33KN, obj.DanhGia33MD, obj.DanhGia41KN, obj.DanhGia41MD, obj.DanhGia42KN, obj.DanhGia42MD, obj.DanhGia43KN, obj.DanhGia43MD, obj.DanhGia51KN, obj.DanhGia51MD, obj.DanhGia52KN, obj.DanhGia52MD, obj.DanhGia53KN, obj.DanhGia53MD, obj.DanhGia61KN, obj.DanhGia61MD, obj.DanhGia62KN, obj.DanhGia62MD, obj.DanhGia63KN, obj.DanhGia63MD, obj.DanhGia71KN, obj.DanhGia71MD, obj.DanhGia72KN, obj.DanhGia72MD, obj.DanhGia73KN, obj.DanhGia73MD, obj.DanhGia81KN, obj.DanhGia81MD, obj.DanhGia82KN, obj.DanhGia82MD, obj.DanhGia83KN, obj.DanhGia83MD, obj.DanhGia91KN, obj.DanhGia91MD, obj.DanhGia92KN, obj.DanhGia92MD, obj.DanhGia93KN, obj.DanhGia93MD, obj.NhuCauNNNongLam, obj.NhuCauNNNongLamNu, obj.NhuCauNNCongNghiep, obj.NhuCauNNCongNghiepNu, obj.NhuCauNNThuongMai, obj.NhuCauNNThuongMaiNu, obj.NhuCauTDLanhDao, obj.NhuCauTDLanhDaoNu, obj.NhuCauTDSoCap, obj.NhuCauTDSoCapNu, obj.NhuCauTDTrungCap, obj.NhuCauTDTrungCapNu, obj.NhuCauTDCaoDang, obj.NhuCauTDCaoDangNu, obj.NhuCauTDDaiHoc, obj.NhuCauTDDaiHocNu, obj.NhuCauLDNNLanhDao, obj.NhuCauTDNNLanhDaoNu, obj.NhuCauTDNNChuyenMonBC, obj.NhuCauTDNNChuyenMonBCNu, obj.NhuCauTDNNChuyenMocBT, obj.NhuCauTDNNChuyenMonBTNu, obj.NhuCauTDNNNhanVienNN, obj.NhuCauTDNNNhanVienNNNu, obj.NhuCauTDNNNhanVienDV, obj.NhuCauTDNNNhanVienDVNu, obj.NhuCauTDNNLaoDongKT, obj.NhuCauTDNNLaoDongKTNu, obj.NhuCauTDNNThoTC, obj.NhuCauTDNNThoTCNu, obj.NhuCauTDNNThoKT, obj.NhuCauTDNNThoKTNu, obj.NhuCauTDNNLaoDongPT, obj.NhuCauTDNNLaoDongPTNu, obj.NhuCauTDTDTiengAnh, obj.NhuCauTDTDTiengAnhNu, obj.NhuCauTDTDTiengTrung, obj.NhuCauTDTDTiengTrungNu, obj.NhuCauTDTDTiengHN, obj.NhuCauTDTDTiengHNNu, obj.NhuCauTDTDTiengKhac, obj.NhuCauTDTDTiengKhacNu, obj.NhuCauTDTDTinHocCB, obj.NhuCauTDTDTinHocCBNu, obj.NhuCauTDTDTinHocNC, obj.NhuCauTDTDTinHocNCNu, obj.NhuCauTDTDTinHocNC2, obj.NhuCauTDTDTinHocNC2Nu, obj.NhuCauTDMLThoaThuan, obj.NhuCauTDMLThoaThuanNu, obj.NhuCauTDML3, obj.NhuCauTDML3Nu, obj.NhuCauTDML5, obj.NhuCauTDML5Nu, obj.NhuCauTDML7, obj.NhuCauTDML7Nu, obj.NhuCauTDML10, obj.NhuCauTDML10Nu, obj.NhuCauTDML15, obj.NhuCauTDML15Nu, obj.NhuCauTBKNChua, obj.NhuCauTBKNChuaNu, obj.NhuCauTBKN1, obj.NhuCauTBKN1Nu, obj.NhuCauTBKN3, obj.NhuCauTBKN3Nu, obj.NhuCauTBKN5, obj.NhuCauTBKN5Nu, obj.NhuCauTBKN10, obj.NhuCauTBKN10Nu, obj.KhoKhanTDLD, obj.KhoKhanPhiaLD, obj.KhoKhanPhiaDN, obj.KhoKhanPhiaDNKhac, obj.NhomTrinhDoCMKT, obj.NhomNgheKTD, obj.HinhThucTuyenDung, obj.HinhThucTuyenDungKhac, obj.TungLienKet, obj.DaHopTac, obj.DaHopTacKhac, obj.KhoKhanVuongMac, obj.KhuyenNghi, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub InputDN_Update(PortalConnect As String, obj As InputDNInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputDN_Update", obj.DoanhNghiep_ID, obj.ThangKhaoSat, obj.NamKhaoSat, obj.MaDoanhNghiep, obj.TenDoanhNghiep, obj.MaSDDKD, obj.LoaiHinh, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DiaChi, obj.KCNKKT, obj.SoDienThoai, obj.Email, obj.Website, obj.NamThanhLap, obj.NganhSanXuat, obj.QuyMo, obj.TongSoLaoDong, obj.TongSoLaoDongNu, obj.SoLDNgoaiTinh, obj.SoLDNgoaiTinhNu, obj.SoLDTrucTiep, obj.SoLDTrucTiepNu, obj.SoLDGianTiep, obj.SoLDGianTiepNu, obj.SoLDDaKyHopDong, obj.SoLDDaKyHopDongNu, obj.SoLDBHXH, obj.SoLDBHXHNu, obj.SoLDTren35, obj.SoLDTren35Nu, obj.SoLDNguoiNN, obj.SoLDNguoiNNNu, obj.SoLDTHPT, obj.SoLDTHPTNU, obj.SoLDTDKhongCo, obj.SoLDTDKhongCoNu, obj.SoLDTDCongNhan, obj.SoLDTDCongNhanNu, obj.SoLDTDDaoTao, obj.SoLDTDDaoTaoNu, obj.SoLDTDSoCap, obj.SoLDTDSoCapNu, obj.SoLDTDTrungCap, obj.SoLDTDTrungCapNu, obj.SoLDTDCaoDang, obj.SoLDTDCaoDangNu, obj.SoLDTDDaiHoc, obj.SoLDTDDaiHocNu, obj.SoLDLVChuongTrinh, obj.SoLDLVChuongTrinhNu, obj.SoLDLVKhoaHoc, obj.SoLDLVKhoaHocNu, obj.SoLDLVNgheThuat, obj.SoLDLVNgheThuatNu, obj.SoLDLVNhanVan, obj.SoLDLVNhanVanNu, obj.SoLDLVKhoaHocXH, obj.SoLDLVKhoaHocXHNu, obj.SoLDLVBaoTri, obj.SoLDLVBaoTriNu, obj.SoLDLVKinhDoanh, obj.SoLDLVKinhDoanhNu, obj.SoLDLVPhapLuat, obj.SoLDLVPhapLuatNu, obj.SoLDLVKhoaHocSS, obj.SoLDLVKhoaHocSSNu, obj.SoLDLVKhoaHocTN, obj.SoLDLVKhoaHocTNNu, obj.SoLDLVToan, obj.SoLDLVToanNu, obj.SoLDLVMayTinh, obj.SoLDLVMayTinhNu, obj.SoLDLVCongNghe, obj.SoLDLVCongNgheNu, obj.SoLDLVKyThuat, obj.SoLDLVKyThuatNu, obj.SoLDLVSanXuat, obj.SoLDLVSanXuatNu, obj.SoLDLVKienTruc, obj.SoLDLVKienTrucNu, obj.SoLDLVNongLam, obj.SoLDLVNongLamNu, obj.SoLDLVThuY, obj.SoLDLVThuYNu, obj.SoLDLVSucKhoe, obj.SoLDLVSucKhoeNu, obj.SoLDLVDichVuXH, obj.SoLDLVDichVuXHNu, obj.SoLDLVDuLich, obj.SoLDLVDuLichNu, obj.SoLDLVDichVuVT, obj.SoLDLVDichVuVTNu, obj.SoLDLVMoiTruong, obj.SoLDLVMoiTruongNu, obj.SoLDLVAnNinh, obj.SoLDLVAnNinhNu, obj.SoLDLVKhac, obj.SoLDLVKhacNu, obj.SoLDNNLanhDao, obj.SoLDNNLanhDaoNu, obj.SoLDNNKyThuatBC, obj.SoLDNNKyThuatBCNu, obj.SoLDNNKyThuatBT, obj.SoLDNNKyThuatBTNu, obj.SoLDNNNhanVienNghe, obj.SoLDNNNhanVienNgheNu, obj.SoLDNNNhanVienDV, obj.SoLDNNNhanVienDVNu, obj.SoLDNNLaoDongCoKT, obj.SoLDNNLaoDongCoKTNu, obj.SoLDNNThoThuCong, obj.SoLDNNThoThuCongNu, obj.SoLDNNThoKyThuat, obj.SoLDNNThoKyThuatNu, obj.SoLDNNLaoDongPT, obj.SoLDNNLaoDongPTNu, obj.SoLDTDTiengAnh, obj.SoLDTDTiengAnhNu, obj.SoLDTDTiengTrung, obj.SoLDTDTiengTrungNu, obj.SoLDTDTiengNhat, obj.SoLDTDTiengNhatNu, obj.SoLDTDTiengKhac, obj.SoLDTDTiengKhacNu, obj.SoLDTDTinHocCB, obj.SoLDTDTinHocCBNu, obj.SoLDTDTinHocNC, obj.SoLDTDTinHocNCNu, obj.SoLDTDTinHocNC2, obj.SoLDTDTinHocNC2Nu, obj.TienLuongBinhQuan, obj.TienLuongThapNhat, obj.TienLuongCaoNhat, obj.DanhGia11KN, obj.DanhGia11MD, obj.DanhGia12KN, obj.DanhGia12MD, obj.DanhGia13KN, obj.DanhGia13MD, obj.DanhGia21KN, obj.DanhGia21MD, obj.DanhGia22KN, obj.DanhGia22MD, obj.DanhGia23KN, obj.DanhGia23MD, obj.DanhGia31KN, obj.DanhGia31MD, obj.DanhGia32KN, obj.DanhGia32MD, obj.DanhGia33KN, obj.DanhGia33MD, obj.DanhGia41KN, obj.DanhGia41MD, obj.DanhGia42KN, obj.DanhGia42MD, obj.DanhGia43KN, obj.DanhGia43MD, obj.DanhGia51KN, obj.DanhGia51MD, obj.DanhGia52KN, obj.DanhGia52MD, obj.DanhGia53KN, obj.DanhGia53MD, obj.DanhGia61KN, obj.DanhGia61MD, obj.DanhGia62KN, obj.DanhGia62MD, obj.DanhGia63KN, obj.DanhGia63MD, obj.DanhGia71KN, obj.DanhGia71MD, obj.DanhGia72KN, obj.DanhGia72MD, obj.DanhGia73KN, obj.DanhGia73MD, obj.DanhGia81KN, obj.DanhGia81MD, obj.DanhGia82KN, obj.DanhGia82MD, obj.DanhGia83KN, obj.DanhGia83MD, obj.DanhGia91KN, obj.DanhGia91MD, obj.DanhGia92KN, obj.DanhGia92MD, obj.DanhGia93KN, obj.DanhGia93MD, obj.NhuCauNNNongLam, obj.NhuCauNNNongLamNu, obj.NhuCauNNCongNghiep, obj.NhuCauNNCongNghiepNu, obj.NhuCauNNThuongMai, obj.NhuCauNNThuongMaiNu, obj.NhuCauTDLanhDao, obj.NhuCauTDLanhDaoNu, obj.NhuCauTDSoCap, obj.NhuCauTDSoCapNu, obj.NhuCauTDTrungCap, obj.NhuCauTDTrungCapNu, obj.NhuCauTDCaoDang, obj.NhuCauTDCaoDangNu, obj.NhuCauTDDaiHoc, obj.NhuCauTDDaiHocNu, obj.NhuCauLDNNLanhDao, obj.NhuCauTDNNLanhDaoNu, obj.NhuCauTDNNChuyenMonBC, obj.NhuCauTDNNChuyenMonBCNu, obj.NhuCauTDNNChuyenMocBT, obj.NhuCauTDNNChuyenMonBTNu, obj.NhuCauTDNNNhanVienNN, obj.NhuCauTDNNNhanVienNNNu, obj.NhuCauTDNNNhanVienDV, obj.NhuCauTDNNNhanVienDVNu, obj.NhuCauTDNNLaoDongKT, obj.NhuCauTDNNLaoDongKTNu, obj.NhuCauTDNNThoTC, obj.NhuCauTDNNThoTCNu, obj.NhuCauTDNNThoKT, obj.NhuCauTDNNThoKTNu, obj.NhuCauTDNNLaoDongPT, obj.NhuCauTDNNLaoDongPTNu, obj.NhuCauTDTDTiengAnh, obj.NhuCauTDTDTiengAnhNu, obj.NhuCauTDTDTiengTrung, obj.NhuCauTDTDTiengTrungNu, obj.NhuCauTDTDTiengHN, obj.NhuCauTDTDTiengHNNu, obj.NhuCauTDTDTiengKhac, obj.NhuCauTDTDTiengKhacNu, obj.NhuCauTDTDTinHocCB, obj.NhuCauTDTDTinHocCBNu, obj.NhuCauTDTDTinHocNC, obj.NhuCauTDTDTinHocNCNu, obj.NhuCauTDTDTinHocNC2, obj.NhuCauTDTDTinHocNC2Nu, obj.NhuCauTDMLThoaThuan, obj.NhuCauTDMLThoaThuanNu, obj.NhuCauTDML3, obj.NhuCauTDML3Nu, obj.NhuCauTDML5, obj.NhuCauTDML5Nu, obj.NhuCauTDML7, obj.NhuCauTDML7Nu, obj.NhuCauTDML10, obj.NhuCauTDML10Nu, obj.NhuCauTDML15, obj.NhuCauTDML15Nu, obj.NhuCauTBKNChua, obj.NhuCauTBKNChuaNu, obj.NhuCauTBKN1, obj.NhuCauTBKN1Nu, obj.NhuCauTBKN3, obj.NhuCauTBKN3Nu, obj.NhuCauTBKN5, obj.NhuCauTBKN5Nu, obj.NhuCauTBKN10, obj.NhuCauTBKN10Nu, obj.KhoKhanTDLD, obj.KhoKhanPhiaLD, obj.KhoKhanPhiaDN, obj.KhoKhanPhiaDNKhac, obj.NhomTrinhDoCMKT, obj.NhomNgheKTD, obj.HinhThucTuyenDung, obj.HinhThucTuyenDungKhac, obj.TungLienKet, obj.DaHopTac, obj.DaHopTacKhac, obj.KhoKhanVuongMac, obj.KhuyenNghi, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub InputDN_Delete(PortalConnect As String, doanhNghiep_ID As String, userId As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputDN_Delete", doanhNghiep_ID, userId)
    End Sub
    Public Overrides Function InputDN_CheckMaPhieu(MaPhieu As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "InputDN_CheckMaPhieu", MaPhieu), Integer)
    End Function
#End Region

#Region "InputNLD2024"
    Public Overrides Function InputNLD2024_Get(iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD2024_Get", iD), IDataReader)
    End Function
    Public Overrides Function InputNLD2024_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD2024_List"), IDataReader)
    End Function
    Public Overrides Function InputNLD2024_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "InputNLD2024_List_Search", search, maTinh, maHuyen, maXa, thang, nam, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Sub InputNLD2024_Add(obj As InputNLD2024Info)
        SqlHelper.ExecuteScalar(flConnect.AnalyConnect, "InputNLD2024_Add", obj.ID, obj.ThangKhaoSat, obj.NamKhaoSat, obj.MaPhieuTuDong, obj.SoThuTu, obj.HoTen, obj.CCCD, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DoiTuongUuTien, obj.DoiTuongUuTienKhac, obj.TrinhDoHocVan, obj.TrinhDoCMKyThuat, obj.ChuyenNganhDT, obj.TrinhDoNN1, obj.ChungChiNN1, obj.KhaNangNN1, obj.TrinhDoNN2, obj.ChungChiNN2, obj.KhaNangNN2, obj.TrinhDoTHVP, obj.KhaNangTHVP, obj.TrinhDoTHKhac, obj.KhaNangTHKhac, obj.KyNangMem, obj.KyNangMemKhac, obj.DaTungDiLam, obj.DaTungDiLamNote, obj.MucLuong, obj.ViTriViecLam, obj.ViTriCongViec, obj.KenhTimKiem, obj.KenhTimKiemKhac, obj.LamViecONN, obj.LamViecONNNote, obj.TinhTrangViecLam, obj.TinhTrangViecLamNote, obj.NguyenNhanCTVL, obj.NguyenNhanCTVLKhac, obj.LyDoPGDVL, obj.LyDoPGDVLKhac, obj.SuDungWeb, obj.WebBoCuc, obj.WebNoiDung, obj.WebKhac, obj.KienNghiPhucVu, obj.DiaDiemMongMuon, obj.ThoiGianToChuc, obj.ThoiGianToChucKhac, obj.TungThamGia, obj.NhuCauViecLam, obj.LoaiHinhDN, obj.MongMuonLamViec, obj.TenCongViec, obj.MoTaCongViec, obj.KinhNghiemCongViec, obj.KinhNghiemBLCongViec, obj.ChucVuMongMuon, obj.ChucVuMongMuonKhac, obj.DiaBanMongMuon, obj.DiaBanMaTinh, obj.DiaBanMaHuyen, obj.LoaiHopDong, obj.DapUngCongViec, obj.HinhThucLamViec, obj.MucDinhLamViec, obj.MucLuongMongMuon, obj.CheDoPhucLoi, obj.CheDoPhucLoiKhac, obj.DuKienLamViec, obj.DuKienLamViecSau, obj.HinhThucTuyenDung, obj.NhuCauXKLD, obj.NhuCauXKLDNuoc, obj.CongViecMongMuonXKLD, obj.CongViecMongMuonXKLDNote, obj.MucLuongXKLD, obj.NhuCauHocNghe, obj.NhuCauHocNgheNote, obj.ThoiGianHocNghe, obj.NhuCauNguyenVongKhac, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag, obj.NgayCapNhat, obj.TinhTrangViecLamDetail)
    End Sub
    Public Overrides Sub InputNLD2024_Update(obj As InputNLD2024Info)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputNLD2024_Update", obj.ID, obj.ThangKhaoSat, obj.NamKhaoSat, obj.MaPhieuTuDong, obj.SoThuTu, obj.HoTen, obj.CCCD, obj.NamSinh, obj.GioiTinh, obj.DanToc, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.MaTinh_HT, obj.MaHuyen_HT, obj.MaXa_HT, obj.MaThon_HT, obj.DiaChi_HT, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DoiTuongUuTien, obj.DoiTuongUuTienKhac, obj.TrinhDoHocVan, obj.TrinhDoCMKyThuat, obj.ChuyenNganhDT, obj.TrinhDoNN1, obj.ChungChiNN1, obj.KhaNangNN1, obj.TrinhDoNN2, obj.ChungChiNN2, obj.KhaNangNN2, obj.TrinhDoTHVP, obj.KhaNangTHVP, obj.TrinhDoTHKhac, obj.KhaNangTHKhac, obj.KyNangMem, obj.KyNangMemKhac, obj.DaTungDiLam, obj.DaTungDiLamNote, obj.MucLuong, obj.ViTriViecLam, obj.ViTriCongViec, obj.KenhTimKiem, obj.KenhTimKiemKhac, obj.LamViecONN, obj.LamViecONNNote, obj.TinhTrangViecLam, obj.TinhTrangViecLamNote, obj.NguyenNhanCTVL, obj.NguyenNhanCTVLKhac, obj.LyDoPGDVL, obj.LyDoPGDVLKhac, obj.SuDungWeb, obj.WebBoCuc, obj.WebNoiDung, obj.WebKhac, obj.KienNghiPhucVu, obj.DiaDiemMongMuon, obj.ThoiGianToChuc, obj.ThoiGianToChucKhac, obj.TungThamGia, obj.NhuCauViecLam, obj.LoaiHinhDN, obj.MongMuonLamViec, obj.TenCongViec, obj.MoTaCongViec, obj.KinhNghiemCongViec, obj.KinhNghiemBLCongViec, obj.ChucVuMongMuon, obj.ChucVuMongMuonKhac, obj.DiaBanMongMuon, obj.DiaBanMaTinh, obj.DiaBanMaHuyen, obj.LoaiHopDong, obj.DapUngCongViec, obj.HinhThucLamViec, obj.MucDinhLamViec, obj.MucLuongMongMuon, obj.CheDoPhucLoi, obj.CheDoPhucLoiKhac, obj.DuKienLamViec, obj.DuKienLamViecSau, obj.HinhThucTuyenDung, obj.NhuCauXKLD, obj.NhuCauXKLDNuoc, obj.CongViecMongMuonXKLD, obj.CongViecMongMuonXKLDNote, obj.MucLuongXKLD, obj.NhuCauHocNghe, obj.NhuCauHocNgheNote, obj.ThoiGianHocNghe, obj.NhuCauNguyenVongKhac, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsDelete, obj.DeletedDate, obj.DeletedUser, obj.PortalID, obj.IsFlag, obj.NgayCapNhat, obj.TinhTrangViecLamDetail)
    End Sub
    Public Overrides Sub InputNLD2024_Delete(iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "InputNLD2024_Delete", iD)
    End Sub
#End Region
#Region "HT_DisplayHome"
    Public Overrides Function HT_DisplayHome_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "HT_DisplayHome_Get", iD), IDataReader)
    End Function
    Public Overrides Function HT_DisplayHome_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "HT_DisplayHome_List"), IDataReader)
    End Function
    Public Overrides Function HT_DisplayHome_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.AnalyConnect, "HT_DisplayHome_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub HT_DisplayHome_Add(obj As HT_DisplayHomeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "HT_DisplayHome_Add", obj.GroupName, obj.GroupID, obj.TargetName, obj.TargetID, obj.IsTable, obj.IsChart, obj.TypeChart, obj.IsOrder, obj.IsActive, obj.YearFrom, obj.YearTo, obj.TotalYear, obj.Method)
    End Sub
    Public Overrides Sub HT_DisplayHome_Update(obj As HT_DisplayHomeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "HT_DisplayHome_Update", obj.ID, obj.GroupName, obj.GroupID, obj.TargetName, obj.TargetID, obj.IsTable, obj.IsChart, obj.TypeChart, obj.IsOrder, obj.IsActive, obj.YearFrom, obj.YearTo, obj.TotalYear, obj.Method)
    End Sub
    Public Overrides Sub HT_DisplayHome_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "HT_DisplayHome_Delete", iD)
    End Sub
    Public Overrides Sub HT_DisplayHome_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.AnalyConnect, "HT_DisplayHome_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region




End Class