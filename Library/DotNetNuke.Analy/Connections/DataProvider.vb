Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing
    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.ANALY", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_Data"
    Public MustOverride Function CMS_Data_Get(PortalConnect As String, data_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Data_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Data_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, ASXH_ID As Integer, Group_ID As Integer, Years_ID As Integer, Period_ID As Integer, Unit_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Data_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_Data_Add(PortalConnect As String, obj As CMS_DataInfo) As Integer
    Public MustOverride Function CMS_Data_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
    Public MustOverride Function CMS_Data_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
    Public MustOverride Sub CMS_Data_Delete(PortalConnect As String, data_ID As Integer)
    Public MustOverride Sub CMS_Data_List_Report(PortalConnect As String, Temp_ID As Integer)
    Public MustOverride Function CMS_Data_Get_By_Year_Code(PortalConnect As String, tinhTP As Integer, Targets_Code As String, years As Integer) As Integer
    Public MustOverride Sub CMS_Data_Update_SoLieu(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer)
#End Region
#Region "CMS_UnitType"
    Public MustOverride Function CMS_UnitType_Get(PortalConnect As String, unitType_ID As Integer) As IDataReader
    Public MustOverride Function CMS_UnitType_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_UnitType_Add(PortalConnect As String, obj As CMS_UnitTypeInfo) As Integer
    Public MustOverride Sub CMS_UnitType_Update(PortalConnect As String, obj As CMS_UnitTypeInfo)
    Public MustOverride Sub CMS_UnitType_Delete(PortalConnect As String, unitType_ID As Integer)
    Public MustOverride Function CMS_UnitType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

#End Region
#Region "CMS_Report"
    Public MustOverride Function CMS_Report_Unit(PortalConnect As String, tempid As Integer, isSend As Integer) As IDataReader
    Public MustOverride Function CMS_Report_List_Years(PortalConnect As String, tinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_Report_List_Period(PortalConnect As String, tinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_Report_Get(PortalConnect As String, report_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Report_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_Report_Return(PortalConnect As String, reportID As Integer, ngaytralai As DateTime, nguoitralai As String, lydotralai As String)
    Public MustOverride Function CMS_Report_List_ByTem(PortalConnect As String, TempID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Report_Get_ByTarget(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer, Period_ID As Integer) As String
    Public MustOverride Function CMS_Report_List_Search(PortalConnect As String, TinhTP As Integer, QuanHuyen As Integer, XaPhuong As Integer, ASXH_ID As Integer, Group_ID As Integer, Level_ID As Integer, Years_ID As Integer, search As String, Status As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Report_Add(PortalConnect As String, obj As CMS_ReportInfo) As Integer
    Public MustOverride Sub CMS_Report_Update(PortalConnect As String, obj As CMS_ReportInfo)
    Public MustOverride Sub CMS_Report_Update_Send(PortalConnect As String, Report_ID As Integer, SendDate As DateTime, SendUser As String)
    Public MustOverride Sub CMS_Report_Delete(PortalConnect As String, report_ID As Integer)
#End Region
#Region "CMS_Group"
    Public MustOverride Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As IDataReader
    Public MustOverride Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
    Public MustOverride Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
    Public MustOverride Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
    Public MustOverride Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
#End Region
#Region "CMS_Targets"
    Public MustOverride Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
    Public MustOverride Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Targets_List_IsGroup(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
    Public MustOverride Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentID As Integer) As String
    Public MustOverride Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
    Public MustOverride Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As IDataReader
    Public MustOverride Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
    Public MustOverride Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
    Public MustOverride Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
    Public MustOverride Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As IDataReader


#End Region
#Region "CMS_Analytic"
    Public MustOverride Function CMS_Analytic_Get(PortalConnect As String, analtyic_ID As String) As IDataReader
    Public MustOverride Function CMS_Analytic_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Analytic_List_ByTarget(PortalConnect As String, TargetID As Integer) As IDataReader
    Public MustOverride Function CMS_Analytic_List_ReportTarget(PortalConnect As String, TargetID As Integer, ValCT As Double) As IDataReader

    Public MustOverride Sub CMS_Analytic_Add(PortalConnect As String, analtyic_ID As String, targets_ID As Integer, valueFrom As Double, valueTo As Double, contents As String, solution As String, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_Analytic_Update(PortalConnect As String, analtyic_ID As String, targets_ID As Integer, valueFrom As Double, valueTo As Double, contents As String, solution As String, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_Analytic_Delete(PortalConnect As String, analtyic_ID As String)
#End Region
#Region "CMS_DashBoard"
    Public MustOverride Function CMS_DashBoard(PortalConnect As String, tinh As Integer, asxh As Integer, group As Integer, year As Integer) As IDataReader
#End Region
#Region "GetDataAnaly"
    Public MustOverride Function CMS_Data_ListByYear(PortalConnect As String, TinhTp As Integer, Group_ID As Integer, Target_ID As Integer, YearFrom As Integer, YearTo As Integer) As IDataReader
#End Region
#Region "CMS_Scene"
    Public MustOverride Function CMS_Scene_Get(PortalConnect As String, scene_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Scene_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Scene_List_ByTinhTP(PortalConnect As String, tinhTp As Integer, typeScene As Integer) As IDataReader

    Public MustOverride Function CMS_Scene_Add(PortalConnect As String, obj As CMS_SceneInfo) As Integer
    Public MustOverride Function CMS_Scene_GetData(PortalConnect As String, YearID As Integer, TinhTp As Integer, TypeScene As Integer) As Double
    Public MustOverride Sub CMS_Scene_Update(PortalConnect As String, obj As CMS_SceneInfo)
    Public MustOverride Sub CMS_Scene_Delete(PortalConnect As String, scene_ID As Integer)
#End Region
#Region "CMS_DataSave"
    Public MustOverride Function CMS_DataSave_Get(PortalConnect As String, data_ID As Integer) As IDataReader
    Public MustOverride Function CMS_DataSave_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DataSave_Get_By_Years_SumData(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Years_ID As Integer) As IDataReader
    Public MustOverride Function CMS_DataSave_Get_By_CMS_Report(PortalConnect As String, report_ID As Integer, tinhTP As Integer, groupID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_DataSave_Add(PortalConnect As String, obj As CMS_DataSaveInfo) As Integer
    Public MustOverride Function CMS_DataSave_Get_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
    Public MustOverride Function CMS_DataSave_Delete_By_Years(PortalConnect As String, tinhTp As Integer, groupID As Integer, targetID As Integer, yearID As Integer) As Double
    Public MustOverride Sub CMS_DataSave_Delete(PortalConnect As String, data_ID As Integer)
    Public MustOverride Sub CMS_DataSave_List_Report(PortalConnect As String, Temp_ID As Integer)

#End Region
#Region "CMS_ReportSave"
    Public MustOverride Function CMS_ReportSave_Get_ByTarget(PortalConnect As String, TinhTP As Integer, Group_ID As Integer, Target_ID As Integer, Years_ID As Integer) As String
    Public MustOverride Function CMS_ReportSave_List_Years(PortalConnect As String, tinhTP As Integer) As IDataReader
    Public MustOverride Function CMS_ReportSave_Get(PortalConnect As String, report_ID As Integer) As IDataReader
    Public MustOverride Function CMS_ReportSave_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ReportSave_Add(PortalConnect As String, obj As CMS_ReportSaveInfo) As Integer
    Public MustOverride Sub CMS_ReportSave_Update(PortalConnect As String, obj As CMS_ReportSaveInfo)
    Public MustOverride Sub CMS_ReportSave_Delete(PortalConnect As String, report_ID As Integer)
#End Region
#Region "CMS_FileAttach"
    Public MustOverride Function CMS_FileAttach_Get(PortalConnect As String, attch_ID As String) As IDataReader
    Public MustOverride Function CMS_FileAttach_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_FileAttach_List_By_IdKey(PortalConnect As String, portalId As Integer, idKey As String) As IDataReader

    Public MustOverride Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
    Public MustOverride Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
    Public MustOverride Sub CMS_FileAttach_Delete(PortalConnect As String, attch_ID As String)
    Public MustOverride Sub CMS_FileAttach_Delete_By_IdKey(PortalConnect As String, idKey As String)
#End Region
#Region "CMS_Magazine"
    Public MustOverride Function CMS_Magazine_Get(PortalConnect As String, magazine_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Magazine_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Magazine_List_Active(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_Magazine_Add(PortalConnect As String, obj As CMS_MagazineInfo) As Integer
    Public MustOverride Sub CMS_Magazine_Update(PortalConnect As String, obj As CMS_MagazineInfo)
    Public MustOverride Sub CMS_Magazine_Delete(PortalConnect As String, magazine_ID As Integer)
#End Region
#Region "CMS_MagazineData"
    Public MustOverride Function CMS_MagazineData_Get(PortalConnect As String, magazineData_ID As Integer) As IDataReader
    Public MustOverride Function CMS_MagazineData_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_MagazineData_Add(PortalConnect As String, obj As CMS_MagazineDataInfo) As Integer
    Public MustOverride Sub CMS_MagazineData_Update(PortalConnect As String, obj As CMS_MagazineDataInfo)
    Public MustOverride Function CMS_MagazineData_Get_By_CMS_Magazine(PortalConnect As String, magazine_ID As Integer) As IDataReader
    Public MustOverride Sub CMS_MagazineData_Delete(PortalConnect As String, magazineData_ID As Integer)
#End Region
#Region "CMS_TypeScene"
    Public MustOverride Function CMS_TypeScene_Get(PortalConnect As String, typeScene_ID As Integer) As IDataReader
    Public MustOverride Function CMS_TypeScene_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_TypeScene_Add(PortalConnect As String, obj As CMS_TypeSceneInfo) As Integer
    Public MustOverride Sub CMS_TypeScene_Update(PortalConnect As String, obj As CMS_TypeSceneInfo)
    Public MustOverride Sub CMS_TypeScene_Delete(PortalConnect As String, typeScene_ID As Integer)
#End Region
#Region "CMS_Config"
    Public MustOverride Function CMS_Config_Get_ByTinhTP(PortalConnect As String, tinhTP As Integer, configValue As Integer) As IDataReader
    Public MustOverride Function CMS_Config_Get(PortalConnect As String, config_ID As String) As IDataReader
    Public MustOverride Function CMS_Config_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Config_Add(PortalConnect As String, obj As CMS_ConfigInfo)
    Public MustOverride Sub CMS_Config_Update(PortalConnect As String, obj As CMS_ConfigInfo)
    Public MustOverride Sub CMS_Config_Delete(PortalConnect As String, config_ID As String)
#End Region
#Region "CMS_RegTar"
    Public MustOverride Function CMS_RegTar_Get(PortalConnect As String, regTar_ID As String) As IDataReader
    Public MustOverride Function CMS_RegTar_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_RegTar_Get_By_Targets_Code(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, Targets_Code As String) As Integer
    Public MustOverride Function CMS_RegTar_Get_By_Data(PortalConnect As String, Targets_ID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer) As IDataReader
    Public MustOverride Function CMS_RegTar_Get_By_Temp(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer) As IDataReader
    Public MustOverride Function CMS_RegTar_Get_By_Temp_Drap(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, groupID As Integer, asxhID As Integer, ParentId As Integer, tempID As Integer) As IDataReader
    Public MustOverride Sub CMS_RegTar_Add(PortalConnect As String, obj As CMS_RegTarInfo)
    Public MustOverride Sub CMS_RegTar_Update(PortalConnect As String, obj As CMS_RegTarInfo)
    Public MustOverride Sub CMS_RegTar_Delete(PortalConnect As String, regTar_ID As String)
    Public MustOverride Sub CMS_RegTar_Delete_Target(PortalConnect As String, TinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, targerID As Integer)
#End Region
#Region "CMS_InDataRow"
    Public MustOverride Function CMS_InDataRow_Get(PortalConnect As String, dataRow_ID As String) As IDataReader
    Public MustOverride Function CMS_InDataRow_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_InDataRow_Add(PortalConnect As String, obj As CMS_InDataRowInfo)
    Public MustOverride Sub CMS_InDataRow_Update(PortalConnect As String, obj As CMS_InDataRowInfo)
    Public MustOverride Function CMS_InDataRow_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_InDataRow_Delete(PortalConnect As String, dataRow_ID As String)
    Public MustOverride Sub CMS_InDataRow_Delete_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer)

#End Region
#Region "CMS_InputRptC"
    Public MustOverride Function CMS_InputRptC_Get(PortalConnect As String, inputRptC_ID As String) As IDataReader
    Public MustOverride Function CMS_InputRptC_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_InputRptC_Add(PortalConnect As String, obj As CMS_InputRptCInfo)
    Public MustOverride Sub CMS_InputRptC_Update(PortalConnect As String, obj As CMS_InputRptCInfo)
    Public MustOverride Function CMS_InputRptC_Get_By_CMS_InputRpt(PortalConnect As String, inputRpt_ID As Integer, colType As Integer) As IDataReader
    Public MustOverride Sub CMS_InputRptC_Delete(PortalConnect As String, inputRptC_ID As String)
#End Region
#Region "CMS_TempRptC"
    Public MustOverride Function CMS_TempRptC_Get(PortalConnect As String, tempRptC_ID As String) As IDataReader
    Public MustOverride Function CMS_TempRptC_List(PortalConnect As String) As IDataReader

    Public MustOverride Sub CMS_TempRptC_Add(PortalConnect As String, obj As CMS_TempRptCInfo)
    Public MustOverride Sub CMS_TempRptC_Update(PortalConnect As String, obj As CMS_TempRptCInfo)
    Public MustOverride Function CMS_TempRptC_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer, colType As Integer) As IDataReader
    Public MustOverride Sub CMS_TempRptC_Delete(PortalConnect As String, tempRptC_ID As String)
#End Region
#Region "CMS_InDataRowC"
    Public MustOverride Function CMS_InDataRowC_Get(PortalConnect As String, dataRowC_ID As Integer) As IDataReader
    Public MustOverride Function CMS_InDataRowC_Get_Data(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetCol_ID As Integer, targetRow_ID As Integer, cateCol_ID As Integer, cateRow_ID As Integer, dataType As Integer) As Double
    Public MustOverride Function CMS_InDataRowC_Get_Data_Simple(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer) As Double
    Public MustOverride Function CMS_InDataRowC_Get_Data_Adv(PortalConnect As String, tinhTp As Integer, yearID As Integer, groupID As Integer, targetRow_ID As Integer, cateRow_ID As Integer, targetCol_ID As Integer, cateCol_ID As Integer) As Double
    Public MustOverride Function CMS_InDataRowC_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_InDataRowC_Add(PortalConnect As String, obj As CMS_InDataRowCInfo) As Integer
    Public MustOverride Sub CMS_InDataRowC_Update(PortalConnect As String, obj As CMS_InDataRowCInfo)
    Public MustOverride Function CMS_InDataRowC_Get_By_CMS_InputRpt(PortalConnect As String, InputRpt_ID As Integer) As IDataReader
    Public MustOverride Function CMS_InDataRowC_Get_By_CMS_InDataRow(PortalConnect As String, dataRow_ID As String) As IDataReader
    Public MustOverride Sub CMS_InDataRowC_Delete(PortalConnect As String, dataRowC_ID As Integer)
    Public MustOverride Sub CMS_InDataRowC_Delete_Value(PortalConnect As String, dataRow_ID As String, inputRptC_ID As String)
#End Region
#Region "CMS_InputRpt"
    Public MustOverride Function CMS_InputRpt_Get(PortalConnect As String, inputRpt_ID As Integer) As IDataReader
    Public MustOverride Function CMS_InputRpt_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_InputRpt_List_Search(PortalConnect As String, search As String, tinhTp As Integer, Group_ID As Integer, Years_ID As Integer, TrangThai As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Function CMS_InputRpt_Add(PortalConnect As String, obj As CMS_InputRptInfo) As Integer
    Public MustOverride Sub CMS_InputRpt_Update(PortalConnect As String, obj As CMS_InputRptInfo)
    Public MustOverride Function CMS_InputRpt_Get_By_CMS_TempRpt(PortalConnect As String, tempRpt_ID As Integer) As IDataReader
    Public MustOverride Sub CMS_InputRpt_Delete(PortalConnect As String, inputRpt_ID As Integer)
#End Region
#Region "CMS_TempRpt"
    Public MustOverride Function CMS_TempRpt_Get(PortalConnect As String, tempRpt_ID As Integer) As IDataReader
    Public MustOverride Function CMS_TempRpt_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TempRpt_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Group_ID As String) As IDataReader

    Public MustOverride Function CMS_TempRpt_Add(PortalConnect As String, obj As CMS_TempRptInfo) As Integer
    Public MustOverride Sub CMS_TempRpt_Update(PortalConnect As String, obj As CMS_TempRptInfo)
    Public MustOverride Sub CMS_TempRpt_Delete(PortalConnect As String, tempRpt_ID As Integer)
#End Region
#Region "CMS_CateTar"
    Public MustOverride Function CMS_CateTar_Get_ByCode(PortalConnect As String, iD As Integer, targetID As Integer) As IDataReader
    Public MustOverride Function CMS_CateTar_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CateTar_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CateTar_List_ByTarget(PortalConnect As String, target_ID As Integer) As IDataReader
    Public MustOverride Function CMS_CateTar_Check_ByTarget(PortalConnect As String, target_ID As Integer) As Boolean

    Public MustOverride Function CMS_CateTar_Add(PortalConnect As String, obj As CMS_CateTarInfo) As Integer
    Public MustOverride Sub CMS_CateTar_Update(PortalConnect As String, obj As CMS_CateTarInfo)
    Public MustOverride Sub CMS_CateTar_Delete(PortalConnect As String, iD As String)
#End Region
#Region "CMS_DataCaculator"
    Public MustOverride Function CMS_DataCaculator_Get(PortalConnect As String, dataCaculator_ID As Integer) As IDataReader
    Public MustOverride Function CMS_DataCaculator_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_DataCaculator_Add(PortalConnect As String, obj As CMS_DataCaculatorInfo) As Integer
    Public MustOverride Sub CMS_DataCaculator_Update(PortalConnect As String, obj As CMS_DataCaculatorInfo)
    Public MustOverride Sub CMS_DataCaculator_Delete(PortalConnect As String, dataCaculator_ID As Integer)
#End Region
#Region "RPT_DataChart"
    Public MustOverride Function RPT_DataChart_GetCValue(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer, isPercent As Boolean) As Double
    Public MustOverride Function RPT_DataChart_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function RPT_DataChart_List(PortalConnect As String, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer) As IDataReader

    Public MustOverride Function RPT_DataChart_Add(PortalConnect As String, obj As RPT_DataChartInfo) As Integer
    Public MustOverride Sub RPT_DataChart_Update(PortalConnect As String, obj As RPT_DataChartInfo)
    Public MustOverride Sub RPT_DataChart_Update_Percent(PortalConnect As String, CTotal As Double, TinhTP As Integer, GroupID As Integer, TargetID As Integer, CodeCateTar As String, YearID As Integer)
    Public MustOverride Sub RPT_DataChart_Delete(PortalConnect As String, TinhTP As Integer, GroupID As Integer, YearID As Integer, tarID As Integer)
#End Region
#Region "FromCungLD"

    Public MustOverride Function PTDB_LayDuLieuTuCungLD(PortalConnect As String, tinhTP As Integer, yearID As Integer, grType As Integer) As IDataReader
#End Region

#Region "InputNLD"
    Public MustOverride Function InputNLD_Get(iD As String) As IDataReader
    Public MustOverride Function InputNLD_List(portalId As Integer) As IDataReader
    Public MustOverride Function InputNLD_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub InputNLD_Add(obj As InputNLDInfo)
    Public MustOverride Sub InputNLD_Update(obj As InputNLDInfo)
    Public MustOverride Sub InputNLD_Delete(iD As String)
    Public MustOverride Sub InputNLD_Update_Quick(iD As String, isActive As Boolean, isOrder As Integer)
#End Region

#Region "InputDN"
    Public MustOverride Function InputDN_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
    Public MustOverride Function InputDN_List(PortalConnect As String) As IDataReader
    Public MustOverride Function InputDN_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, maTinh As String, maHuyen As String, thangKhaoSat As Integer, namKhaoSat As Integer) As IDataReader
    Public MustOverride Sub InputDN_Add(PortalConnect As String, obj As InputDNInfo)
    Public MustOverride Sub InputDN_Update(PortalConnect As String, obj As InputDNInfo)
    Public MustOverride Sub InputDN_Delete(PortalConnect As String, doanhNghiep_ID As String, userId As String)
    Public MustOverride Function InputDN_CheckMaPhieu(MaPhieu As String) As Integer
#End Region

#Region "InputNLD2024"
    Public MustOverride Function InputNLD2024_Get(iD As String) As IDataReader
    Public MustOverride Function InputNLD2024_List() As IDataReader
    Public MustOverride Function InputNLD2024_List_Search(search As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, thang As Integer, nam As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub InputNLD2024_Add(obj As InputNLD2024Info)
    Public MustOverride Sub InputNLD2024_Update(obj As InputNLD2024Info)
    Public MustOverride Sub InputNLD2024_Delete(iD As String)
#End Region
#Region "HT_DisplayHome"
    Public MustOverride Function HT_DisplayHome_Get(iD As Integer) As IDataReader
    Public MustOverride Function HT_DisplayHome_List() As IDataReader
    Public MustOverride Function HT_DisplayHome_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub HT_DisplayHome_Add(obj As HT_DisplayHomeInfo)
    Public MustOverride Sub HT_DisplayHome_Update(obj As HT_DisplayHomeInfo)
    Public MustOverride Sub HT_DisplayHome_Delete(iD As Integer)
    Public MustOverride Sub HT_DisplayHome_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

End Class
