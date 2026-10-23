Imports DotNetNuke.Common.Utilities

Public Class InsuController

#Region "CMS_Portal"
    Public Function CMS_Portal_Get(PortalConnect As String, portalID As Integer) As CMS_PortalInfo
        Return CBO.FillObject(Of CMS_PortalInfo)(DataProvider.Instance().CMS_Portal_Get(PortalConnect, portalID))
    End Function
    Public Function CMS_Portal_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portal_List(PortalConnect), GetType(CMS_PortalInfo))
    End Function
    Public Function CMS_Portal_List_App(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portal_List_App(PortalConnect), GetType(CMS_PortalInfo))
    End Function
    Public Function CMS_Portal_List_App_Type(PortalConnect As String, type As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portal_List_App_Type(PortalConnect, type), GetType(CMS_PortalInfo))
    End Function
    Public Function CMS_Portal_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Portal_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PortalInfo))
    End Function

    Public Function CMS_Portal_Add(PortalConnect As String, obj As CMS_PortalInfo) As Integer
        Return DataProvider.Instance().CMS_Portal_Add(PortalConnect, obj.PortalName, obj.Logo, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DuongPho, obj.NguoiDaiDien, obj.Position_ID, obj.Website, obj.Email, obj.Mobile, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive)
    End Function
    Public Sub CMS_Portal_Update(PortalConnect As String, obj As CMS_PortalInfo)
        DataProvider.Instance().CMS_Portal_Update(PortalConnect, obj.PortalID, obj.PortalName, obj.Logo, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.DuongPho, obj.NguoiDaiDien, obj.Position_ID, obj.Website, obj.Email, obj.Mobile, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive)
    End Sub
    Public Sub CMS_Portal_Delete(PortalConnect As String, portalID As Integer)
        DataProvider.Instance().CMS_Portal_Delete(PortalConnect, portalID)
    End Sub
#End Region
#Region "CMS_Banking"
    Public Function CMS_Banking_Get(PortalConnect As String, banking_ID As String) As CMS_BankingInfo
        Return CBO.FillObject(Of CMS_BankingInfo)(DataProvider.Instance().CMS_Banking_Get(PortalConnect, banking_ID))
    End Function
    Public Function CMS_Banking_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Banking_List(PortalConnect, portalId), GetType(CMS_BankingInfo))
    End Function
    Public Function CMS_Banking_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Banking_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_BankingInfo))
    End Function
    Public Sub CMS_Banking_Add(PortalConnect As String, obj As CMS_BankingInfo)
        DataProvider.Instance().CMS_Banking_Add(PortalConnect, obj.Banking_ID, obj.Banking_Name, obj.Banking_Code, obj.Banking_Logo, obj.Banking_Website, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Banking_Update(PortalConnect As String, obj As CMS_BankingInfo)
        DataProvider.Instance().CMS_Banking_Update(PortalConnect, obj.Banking_ID, obj.Banking_Name, obj.Banking_Code, obj.Banking_Logo, obj.Banking_Website, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Banking_Delete(PortalConnect As String, banking_ID As String)
        DataProvider.Instance().CMS_Banking_Delete(PortalConnect, banking_ID)
    End Sub
#End Region
#Region "CMS_Branch"
    Public Function CMS_Branch_Get(PortalConnect As String, branch_ID As String) As CMS_BranchInfo
        Return CBO.FillObject(Of CMS_BranchInfo)(DataProvider.Instance().CMS_Branch_Get(PortalConnect, branch_ID))
    End Function
    Public Function CMS_Branch_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Branch_List(PortalConnect, portalId), GetType(CMS_BranchInfo))
    End Function
    Public Function CMS_Branch_Get_By_CMS_Banking(PortalConnect As String, banking_ID As String, PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Branch_Get_By_CMS_Banking(PortalConnect, banking_ID, PortalId), GetType(CMS_BranchInfo))
    End Function
    Public Function CMS_Branch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Banking_ID As String, PortalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Branch_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, Banking_ID, PortalId), GetType(CMS_BranchInfo))
    End Function

    Public Sub CMS_Branch_Add(PortalConnect As String, obj As CMS_BranchInfo)
        DataProvider.Instance().CMS_Branch_Add(PortalConnect, obj.Branch_ID, obj.Branch_Name, obj.Branch_Code, obj.Branch_Tel, obj.Branch_Address, obj.TinhTP, obj.Banking_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Branch_Update(PortalConnect As String, obj As CMS_BranchInfo)
        DataProvider.Instance().CMS_Branch_Update(PortalConnect, obj.Branch_ID, obj.Branch_Name, obj.Branch_Code, obj.Branch_Tel, obj.Branch_Address, obj.TinhTP, obj.Banking_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Branch_Delete(PortalConnect As String, branch_ID As String)
        DataProvider.Instance().CMS_Branch_Delete(PortalConnect, branch_ID)
    End Sub
#End Region
#Region "CMS_Cannot"
    Public Function CMS_Cannot_Get(PortalConnect As String, cannot_ID As String) As CMS_CannotInfo
        Return CBO.FillObject(Of CMS_CannotInfo)(DataProvider.Instance().CMS_Cannot_Get(PortalConnect, cannot_ID))
    End Function
    Public Function CMS_Cannot_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Cannot_List(PortalConnect, portalId), GetType(CMS_CannotInfo))
    End Function
    Public Function CMS_Cannot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Cannot_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CannotInfo))
    End Function

    Public Sub CMS_Cannot_Add(PortalConnect As String, obj As CMS_CannotInfo)
        DataProvider.Instance().CMS_Cannot_Add(PortalConnect, obj.Cannot_ID, obj.Cannot_Name, obj.Cannot_Code, obj.Cannot_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Cannot_Update(PortalConnect As String, obj As CMS_CannotInfo)
        DataProvider.Instance().CMS_Cannot_Update(PortalConnect, obj.Cannot_ID, obj.Cannot_Name, obj.Cannot_Code, obj.Cannot_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Cannot_Delete(PortalConnect As String, cannot_ID As String)
        DataProvider.Instance().CMS_Cannot_Delete(PortalConnect, cannot_ID)
    End Sub
#End Region
#Region "CMS_Career"
    Public Function CMS_Career_Get(PortalConnect As String, career_ID As String) As CMS_CareerInfo
        Return CBO.FillObject(Of CMS_CareerInfo)(DataProvider.Instance().CMS_Career_Get(PortalConnect, career_ID))
    End Function
    Public Function CMS_Career_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List(PortalConnect, portalId), GetType(CMS_CareerInfo))
    End Function
    Public Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CareerInfo))
    End Function

    Public Sub CMS_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
        DataProvider.Instance().CMS_Career_Add(PortalConnect, obj.Career_ID, obj.Career_Name, obj.Career_Code, obj.Career_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Career_Update(PortalConnect As String, obj As CMS_CareerInfo)
        DataProvider.Instance().CMS_Career_Update(PortalConnect, obj.Career_ID, obj.Career_Name, obj.Career_Code, obj.Career_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
        DataProvider.Instance().CMS_Career_Delete(PortalConnect, career_ID)
    End Sub
#End Region
#Region "CMS_CauseOf"
    Public Function CMS_CauseOf_Get(PortalConnect As String, causeOf_ID As String) As CMS_CauseOfInfo
        Return CBO.FillObject(Of CMS_CauseOfInfo)(DataProvider.Instance().CMS_CauseOf_Get(PortalConnect, causeOf_ID))
    End Function
    Public Function CMS_CauseOf_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CauseOf_List(PortalConnect, portalId), GetType(CMS_CauseOfInfo))
    End Function
    Public Function CMS_CauseOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CauseOf_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CauseOfInfo))
    End Function

    Public Sub CMS_CauseOf_Add(PortalConnect As String, obj As CMS_CauseOfInfo)
        DataProvider.Instance().CMS_CauseOf_Add(PortalConnect, obj.CauseOf_ID, obj.CauseOf_Name, obj.CauseOf_Code, obj.CauseOf_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_CauseOf_Update(PortalConnect As String, obj As CMS_CauseOfInfo)
        DataProvider.Instance().CMS_CauseOf_Update(PortalConnect, obj.CauseOf_ID, obj.CauseOf_Name, obj.CauseOf_Code, obj.CauseOf_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_CauseOf_Delete(PortalConnect As String, causeOf_ID As String)
        DataProvider.Instance().CMS_CauseOf_Delete(PortalConnect, causeOf_ID)
    End Sub
#End Region
#Region "CMS_Company"
    Public Function CMS_Company_Get(PortalConnect As String, company_ID As String) As CMS_CompanyInfo
        Return CBO.FillObject(Of CMS_CompanyInfo)(DataProvider.Instance().CMS_Company_Get(PortalConnect, company_ID))
    End Function
    Public Function CMS_Company_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Company_List(PortalConnect, portalId), GetType(CMS_CompanyInfo))
    End Function
    Public Function CMS_Company_Get_By_CMS_ComType(PortalConnect As String, comType_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Company_Get_By_CMS_ComType(PortalConnect, comType_ID), GetType(CMS_CompanyInfo))
    End Function
    Public Function CMS_Company_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Company_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CompanyInfo))
    End Function

    Public Sub CMS_Company_Add(PortalConnect As String, obj As CMS_CompanyInfo)
        DataProvider.Instance().CMS_Company_Add(PortalConnect, obj.Company_ID, obj.Company_Name, obj.Company_Code, obj.Company_Logo, obj.Company_Tel, obj.Company_Website, obj.ComType_ID, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.SoNha, obj.Career_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Company_Update(PortalConnect As String, obj As CMS_CompanyInfo)
        DataProvider.Instance().CMS_Company_Update(PortalConnect, obj.Company_ID, obj.Company_Name, obj.Company_Code, obj.Company_Logo, obj.Company_Tel, obj.Company_Website, obj.ComType_ID, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.SoNha, obj.Career_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Company_Delete(PortalConnect As String, company_ID As String)
        DataProvider.Instance().CMS_Company_Delete(PortalConnect, company_ID)
    End Sub
#End Region
#Region "CMS_ComType"
    Public Function CMS_ComType_Get(PortalConnect As String, comType_ID As String) As CMS_ComTypeInfo
        Return CBO.FillObject(Of CMS_ComTypeInfo)(DataProvider.Instance().CMS_ComType_Get(PortalConnect, comType_ID))
    End Function
    Public Function CMS_ComType_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ComType_List(PortalConnect, portalId), GetType(CMS_ComTypeInfo))
    End Function
    Public Function CMS_ComType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ComType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ComTypeInfo))
    End Function

    Public Sub CMS_ComType_Add(PortalConnect As String, obj As CMS_ComTypeInfo)
        DataProvider.Instance().CMS_ComType_Add(PortalConnect, obj.ComType_ID, obj.Comtype_Name, obj.Comtype_Code, obj.Comtype_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_ComType_Update(PortalConnect As String, obj As CMS_ComTypeInfo)
        DataProvider.Instance().CMS_ComType_Update(PortalConnect, obj.ComType_ID, obj.Comtype_Name, obj.Comtype_Code, obj.Comtype_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_ComType_Delete(PortalConnect As String, comType_ID As String)
        DataProvider.Instance().CMS_ComType_Delete(PortalConnect, comType_ID)
    End Sub
#End Region
#Region "CMS_ContractType"
    Public Function CMS_ContractType_Get(PortalConnect As String, contractType_ID As String) As CMS_ContractTypeInfo
        Return CBO.FillObject(Of CMS_ContractTypeInfo)(DataProvider.Instance().CMS_ContractType_Get(PortalConnect, contractType_ID))
    End Function
    Public Function CMS_ContractType_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ContractType_List(PortalConnect, portalId), GetType(CMS_ContractTypeInfo))
    End Function
    Public Function CMS_ContractType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ContractType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ContractTypeInfo))
    End Function

    Public Sub CMS_ContractType_Add(PortalConnect As String, obj As CMS_ContractTypeInfo)
        DataProvider.Instance().CMS_ContractType_Add(PortalConnect, obj.ContractType_ID, obj.ContractType_Name, obj.ContractType_Code, obj.ContractType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_ContractType_Update(PortalConnect As String, obj As CMS_ContractTypeInfo)
        DataProvider.Instance().CMS_ContractType_Update(PortalConnect, obj.ContractType_ID, obj.ContractType_Name, obj.ContractType_Code, obj.ContractType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_ContractType_Delete(PortalConnect As String, contractType_ID As String)
        DataProvider.Instance().CMS_ContractType_Delete(PortalConnect, contractType_ID)
    End Sub
#End Region
#Region "CMS_Course"
    Public Function CMS_Course_Get(PortalConnect As String, course_ID As String) As CMS_CourseInfo
        Return CBO.FillObject(Of CMS_CourseInfo)(DataProvider.Instance().CMS_Course_Get(PortalConnect, course_ID))
    End Function
    Public Function CMS_Course_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Course_List(PortalConnect, portalId), GetType(CMS_CourseInfo))
    End Function
    Public Function CMS_Course_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Training_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Course_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, Training_ID), GetType(CMS_CourseInfo))
    End Function
    Public Function CMS_Course_Gey_By_CMS_Training(PortalConnect As String, portalId As Integer, Training_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Course_Gey_By_CMS_Training(PortalConnect, portalId, Training_ID), GetType(CMS_CourseInfo))
    End Function
    Public Sub CMS_Course_Add(PortalConnect As String, obj As CMS_CourseInfo)
        DataProvider.Instance().CMS_Course_Add(PortalConnect, obj.Course_ID, obj.Training_ID, obj.Course_Name, obj.Tuition, obj.IsMonth, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Course_Update(PortalConnect As String, obj As CMS_CourseInfo)
        DataProvider.Instance().CMS_Course_Update(PortalConnect, obj.Course_ID, obj.Training_ID, obj.Course_Name, obj.Tuition, obj.IsMonth, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Course_Delete(PortalConnect As String, course_ID As String)
        DataProvider.Instance().CMS_Course_Delete(PortalConnect, course_ID)
    End Sub
#End Region
#Region "CMS_DayOff"
    Public Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As CMS_DayOffInfo
        Return CBO.FillObject(Of CMS_DayOffInfo)(DataProvider.Instance().CMS_DayOff_Get(PortalConnect, dayOff_ID))
    End Function
    Public Function CMS_DayOff_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DayOff_List(PortalConnect, portalId), GetType(CMS_DayOffInfo))
    End Function
    Public Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DayOff_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DayOffInfo))
    End Function
    Public Function CMS_DayOff_Get_OffTime(PortalConnect As String, Dates As DateTime) As Integer
        Return DataProvider.Instance().CMS_DayOff_Get_OffTime(PortalConnect, Dates)
    End Function
    Public Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer
        Return DataProvider.Instance().CMS_DayOff_Get_Day_Month(PortalConnect, isDay, isMonth)
    End Function
    Public Sub CMS_DayOff_Add(PortalConnect As String, obj As CMS_DayOffInfo)
        DataProvider.Instance().CMS_DayOff_Add(PortalConnect, obj.DayOff_ID, obj.DayOff_Name, obj.IsDay, obj.IsMonth, obj.IsYear, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_DayOff_Update(PortalConnect As String, obj As CMS_DayOffInfo)
        DataProvider.Instance().CMS_DayOff_Update(PortalConnect, obj.DayOff_ID, obj.DayOff_Name, obj.IsDay, obj.IsMonth, obj.IsYear, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
        DataProvider.Instance().CMS_DayOff_Delete(PortalConnect, dayOff_ID)
    End Sub
#End Region
#Region "CMS_DecidedType"
    Public Function CMS_DecidedType_Get(PortalConnect As String, decidedType_ID As String) As CMS_DecidedTypeInfo
        Return CBO.FillObject(Of CMS_DecidedTypeInfo)(DataProvider.Instance().CMS_DecidedType_Get(PortalConnect, decidedType_ID))
    End Function
    Public Function CMS_DecidedType_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DecidedType_List(PortalConnect, portalId), GetType(CMS_DecidedTypeInfo))
    End Function
    Public Function CMS_DecidedType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DecidedType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DecidedTypeInfo))
    End Function

    Public Sub CMS_DecidedType_Add(PortalConnect As String, obj As CMS_DecidedTypeInfo)
        DataProvider.Instance().CMS_DecidedType_Add(PortalConnect, obj.DecidedType_ID, obj.DecidedType_Name, obj.DecidedType_Code, obj.DecidedType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_DecidedType_Update(PortalConnect As String, obj As CMS_DecidedTypeInfo)
        DataProvider.Instance().CMS_DecidedType_Update(PortalConnect, obj.DecidedType_ID, obj.DecidedType_Name, obj.DecidedType_Code, obj.DecidedType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_DecidedType_Delete(PortalConnect As String, decidedType_ID As String)
        DataProvider.Instance().CMS_DecidedType_Delete(PortalConnect, decidedType_ID)
    End Sub
#End Region
#Region "CMS_Field"
    Public Function CMS_Field_Get(PortalConnect As String, field_ID As String) As CMS_FieldInfo
        Return CBO.FillObject(Of CMS_FieldInfo)(DataProvider.Instance().CMS_Field_Get(PortalConnect, field_ID))
    End Function
    Public Function CMS_Field_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Field_List(PortalConnect, portalId), GetType(CMS_FieldInfo))
    End Function
    Public Function CMS_Field_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Field_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_FieldInfo))
    End Function

    Public Sub CMS_Field_Add(PortalConnect As String, obj As CMS_FieldInfo)
        DataProvider.Instance().CMS_Field_Add(PortalConnect, obj.Field_ID, obj.Field_Name, obj.Field_Code, obj.Field_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Field_Update(PortalConnect As String, obj As CMS_FieldInfo)
        DataProvider.Instance().CMS_Field_Update(PortalConnect, obj.Field_ID, obj.Field_Name, obj.Field_Code, obj.Field_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Field_Delete(PortalConnect As String, field_ID As String)
        DataProvider.Instance().CMS_Field_Delete(PortalConnect, field_ID)
    End Sub
#End Region
#Region "CMS_FileAttch"
    Public Function CMS_FileAttch_Get(PortalConnect As String, fileAttch_ID As String) As CMS_FileAttchInfo
        Return CBO.FillObject(Of CMS_FileAttchInfo)(DataProvider.Instance().CMS_FileAttch_Get(PortalConnect, fileAttch_ID))
    End Function
    Public Function CMS_FileAttch_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttch_List(PortalConnect), GetType(CMS_FileAttchInfo))
    End Function
    Public Function CMS_FileAttch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttch_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_FileAttchInfo))
    End Function

    Public Sub CMS_FileAttch_Add(PortalConnect As String, obj As CMS_FileAttchInfo)
        DataProvider.Instance().CMS_FileAttch_Add(PortalConnect, obj.FileAttch_ID, obj.Document_ID, obj.FileAttch_Name, obj.FileAttch_Attch, obj.IsOrder, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Sub CMS_FileAttch_Update(PortalConnect As String, obj As CMS_FileAttchInfo)
        DataProvider.Instance().CMS_FileAttch_Update(PortalConnect, obj.FileAttch_ID, obj.Document_ID, obj.FileAttch_Name, obj.FileAttch_Attch, obj.IsOrder, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Sub CMS_FileAttch_Delete(PortalConnect As String, fileAttch_ID As String)
        DataProvider.Instance().CMS_FileAttch_Delete(PortalConnect, fileAttch_ID)
    End Sub
#End Region
#Region "CMS_Insurance"
    Public Function CMS_Insurance_Get(PortalConnect As String, insurance_ID As String) As CMS_InsuranceInfo
        Return CBO.FillObject(Of CMS_InsuranceInfo)(DataProvider.Instance().CMS_Insurance_Get(PortalConnect, insurance_ID))
    End Function
    Public Function CMS_Insurance_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Insurance_List(PortalConnect, portalId), GetType(CMS_InsuranceInfo))
    End Function
    Public Function CMS_Insurance_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Insurance_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_InsuranceInfo))
    End Function
    Public Sub CMS_Insurance_Add(PortalConnect As String, obj As CMS_InsuranceInfo)
        DataProvider.Instance().CMS_Insurance_Add(PortalConnect, obj.Insurance_ID, obj.Insurance_Code, obj.Insurance_Name, obj.Insurance_Address, obj.Insurance_Des, obj.QuanHuyen, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Insurance_Update(PortalConnect As String, obj As CMS_InsuranceInfo)
        DataProvider.Instance().CMS_Insurance_Update(PortalConnect, obj.Insurance_ID, obj.Insurance_Code, obj.Insurance_Name, obj.Insurance_Address, obj.Insurance_Des, obj.QuanHuyen, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Insurance_Delete(PortalConnect As String, insurance_ID As String)
        DataProvider.Instance().CMS_Insurance_Delete(PortalConnect, insurance_ID)
    End Sub
#End Region
#Region "CMS_LaborType"
    Public Function CMS_LaborType_Get(PortalConnect As String, laborType_ID As String) As CMS_LaborTypeInfo
        Return CBO.FillObject(Of CMS_LaborTypeInfo)(DataProvider.Instance().CMS_LaborType_Get(PortalConnect, laborType_ID))
    End Function
    Public Function CMS_LaborType_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LaborType_List(PortalConnect, portalId), GetType(CMS_LaborTypeInfo))
    End Function
    Public Function CMS_LaborType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LaborType_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LaborTypeInfo))
    End Function

    Public Sub CMS_LaborType_Add(PortalConnect As String, obj As CMS_LaborTypeInfo)
        DataProvider.Instance().CMS_LaborType_Add(PortalConnect, obj.LaborType_ID, obj.LaborType_Name, obj.LaborType_Code, obj.LaborType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_LaborType_Update(PortalConnect As String, obj As CMS_LaborTypeInfo)
        DataProvider.Instance().CMS_LaborType_Update(PortalConnect, obj.LaborType_ID, obj.LaborType_Name, obj.LaborType_Code, obj.LaborType_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_LaborType_Delete(PortalConnect As String, laborType_ID As String)
        DataProvider.Instance().CMS_LaborType_Delete(PortalConnect, laborType_ID)
    End Sub
#End Region
#Region "CMS_Leaving"
    Public Function CMS_Leaving_Get(PortalConnect As String, leaving_ID As String) As CMS_LeavingInfo
        Return CBO.FillObject(Of CMS_LeavingInfo)(DataProvider.Instance().CMS_Leaving_Get(PortalConnect, leaving_ID))
    End Function
    Public Function CMS_Leaving_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Leaving_List(PortalConnect, portalId), GetType(CMS_LeavingInfo))
    End Function
    Public Function CMS_Leaving_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Leaving_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LeavingInfo))
    End Function

    Public Sub CMS_Leaving_Add(PortalConnect As String, obj As CMS_LeavingInfo)
        DataProvider.Instance().CMS_Leaving_Add(PortalConnect, obj.Leaving_ID, obj.Leaving_Name, obj.Leaving_Code, obj.Leaving_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Leaving_Update(PortalConnect As String, obj As CMS_LeavingInfo)
        DataProvider.Instance().CMS_Leaving_Update(PortalConnect, obj.Leaving_ID, obj.Leaving_Name, obj.Leaving_Code, obj.Leaving_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Leaving_Delete(PortalConnect As String, leaving_ID As String)
        DataProvider.Instance().CMS_Leaving_Delete(PortalConnect, leaving_ID)
    End Sub
#End Region
#Region "CMS_Location"
    Public Function CMS_Location_Get(PortalConnect As String, location_ID As String) As CMS_LocationInfo
        Return CBO.FillObject(Of CMS_LocationInfo)(DataProvider.Instance().CMS_Location_Get(PortalConnect, location_ID))
    End Function
    Public Function CMS_Location_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Location_List(PortalConnect, portalId), GetType(CMS_LocationInfo))
    End Function
    Public Function CMS_Location_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Location_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LocationInfo))
    End Function

    Public Sub CMS_Location_Add(PortalConnect As String, obj As CMS_LocationInfo)
        DataProvider.Instance().CMS_Location_Add(PortalConnect, obj.Location_ID, obj.Location_Name, obj.Location_Code, obj.Location_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Location_Update(PortalConnect As String, obj As CMS_LocationInfo)
        DataProvider.Instance().CMS_Location_Update(PortalConnect, obj.Location_ID, obj.Location_Name, obj.Location_Code, obj.Location_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Location_Delete(PortalConnect As String, location_ID As String)
        DataProvider.Instance().CMS_Location_Delete(PortalConnect, location_ID)
    End Sub
#End Region
#Region "CMS_PreCareer"
    Public Function CMS_PreCareer_Get(PortalConnect As String, preCareer_ID As String) As CMS_PreCareerInfo
        Return CBO.FillObject(Of CMS_PreCareerInfo)(DataProvider.Instance().CMS_PreCareer_Get(PortalConnect, preCareer_ID))
    End Function
    Public Function CMS_PreCareer_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PreCareer_List(PortalConnect, portalId), GetType(CMS_PreCareerInfo))
    End Function
    Public Function CMS_PreCareer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PreCareer_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PreCareerInfo))
    End Function

    Public Sub CMS_PreCareer_Add(PortalConnect As String, obj As CMS_PreCareerInfo)
        DataProvider.Instance().CMS_PreCareer_Add(PortalConnect, obj.PreCareer_ID, obj.PreCareer_Name, obj.PreCareer_Code, obj.PreCareer_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_PreCareer_Update(PortalConnect As String, obj As CMS_PreCareerInfo)
        DataProvider.Instance().CMS_PreCareer_Update(PortalConnect, obj.PreCareer_ID, obj.PreCareer_Name, obj.PreCareer_Code, obj.PreCareer_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_PreCareer_Delete(PortalConnect As String, preCareer_ID As String)
        DataProvider.Instance().CMS_PreCareer_Delete(PortalConnect, preCareer_ID)
    End Sub
#End Region
#Region "CMS_PreIndu"
    Public Function CMS_PreIndu_Get(PortalConnect As String, preIndu_ID As String) As CMS_PreInduInfo
        Return CBO.FillObject(Of CMS_PreInduInfo)(DataProvider.Instance().CMS_PreIndu_Get(PortalConnect, preIndu_ID))
    End Function
    Public Function CMS_PreIndu_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PreIndu_List(PortalConnect, portalId), GetType(CMS_PreInduInfo))
    End Function
    Public Function CMS_PreIndu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PreIndu_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PreInduInfo))
    End Function

    Public Sub CMS_PreIndu_Add(PortalConnect As String, obj As CMS_PreInduInfo)
        DataProvider.Instance().CMS_PreIndu_Add(PortalConnect, obj.PreIndu_ID, obj.PreIndu_Name, obj.PreIndu_Code, obj.PreIndu_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_PreIndu_Update(PortalConnect As String, obj As CMS_PreInduInfo)
        DataProvider.Instance().CMS_PreIndu_Update(PortalConnect, obj.PreIndu_ID, obj.PreIndu_Name, obj.PreIndu_Code, obj.PreIndu_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_PreIndu_Delete(PortalConnect As String, preIndu_ID As String)
        DataProvider.Instance().CMS_PreIndu_Delete(PortalConnect, preIndu_ID)
    End Sub
#End Region
#Region "CMS_Recruitment"
    Public Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As CMS_RecruitmentInfo
        Return CBO.FillObject(Of CMS_RecruitmentInfo)(DataProvider.Instance().CMS_Recruitment_Get(PortalConnect, recruitment_ID))
    End Function
    Public Function CMS_Recruitment_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List(PortalConnect, portalId), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RecruitmentInfo))
    End Function

    Public Sub CMS_Recruitment_Add(PortalConnect As String, obj As CMS_RecruitmentInfo)
        DataProvider.Instance().CMS_Recruitment_Add(PortalConnect, obj.Recruitment_ID, obj.Recruitment_Name, obj.Recruitment_Code, obj.Recruitment_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Recruitment_Update(PortalConnect As String, obj As CMS_RecruitmentInfo)
        DataProvider.Instance().CMS_Recruitment_Update(PortalConnect, obj.Recruitment_ID, obj.Recruitment_Name, obj.Recruitment_Code, obj.Recruitment_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
        DataProvider.Instance().CMS_Recruitment_Delete(PortalConnect, recruitment_ID)
    End Sub
#End Region
#Region "CMS_Salary"
    Public Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As CMS_SalaryInfo
        Return CBO.FillObject(Of CMS_SalaryInfo)(DataProvider.Instance().CMS_Salary_Get(PortalConnect, salary_ID))
    End Function
    Public Function CMS_Salary_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List(PortalConnect, portalId), GetType(CMS_SalaryInfo))
    End Function
    Public Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SalaryInfo))
    End Function

    Public Sub CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().CMS_Salary_Add(PortalConnect, obj.Salary_ID, obj.Salary_Name, obj.Salary_Price, obj.Salary_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().CMS_Salary_Update(PortalConnect, obj.Salary_ID, obj.Salary_Name, obj.Salary_Price, obj.Salary_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        DataProvider.Instance().CMS_Salary_Delete(PortalConnect, salary_ID)
    End Sub
#End Region
#Region "CMS_Satellite"
    Public Function CMS_Satellite_Get_ByCode(PortalConnect As String, Satellite_Code As String) As CMS_SatelliteInfo
        Return CBO.FillObject(Of CMS_SatelliteInfo)(DataProvider.Instance().CMS_Satellite_Get_ByCode(PortalConnect, Satellite_Code))
    End Function
    Public Function CMS_Satellite_Get(PortalConnect As String, satellite_ID As String) As CMS_SatelliteInfo
        Return CBO.FillObject(Of CMS_SatelliteInfo)(DataProvider.Instance().CMS_Satellite_Get(PortalConnect, satellite_ID))
    End Function
    Public Function CMS_Satellite_List_ToApp(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Satellite_List_ToApp(PortalConnect, portalId), GetType(CMS_SatelliteInfo))
    End Function
    Public Function CMS_Satellite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Satellite_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SatelliteInfo))
    End Function
    Public Function CMS_Satellite_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Satellite_List(PortalConnect, portalId), GetType(CMS_SatelliteInfo))
    End Function
    Public Sub CMS_Satellite_Add(PortalConnect As String, obj As CMS_SatelliteInfo)
        DataProvider.Instance().CMS_Satellite_Add(PortalConnect, obj.Satellite_ID, obj.Satellite_Name, obj.Satellite_Code, obj.Satellite_Address, obj.Satellite_Tel, obj.TinhTP, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Satellite_Update(PortalConnect As String, obj As CMS_SatelliteInfo)
        DataProvider.Instance().CMS_Satellite_Update(PortalConnect, obj.Satellite_ID, obj.Satellite_Name, obj.Satellite_Code, obj.Satellite_Address, obj.Satellite_Tel, obj.TinhTP, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Satellite_Delete(PortalConnect As String, satellite_ID As String)
        DataProvider.Instance().CMS_Satellite_Delete(PortalConnect, satellite_ID)
    End Sub
#End Region
#Region "CMS_SetNumber"
    Public Function CMS_SetNumber_Get(PortalConnect As String, setNumber_ID As String) As CMS_SetNumberInfo
        Return CBO.FillObject(Of CMS_SetNumberInfo)(DataProvider.Instance().CMS_SetNumber_Get(PortalConnect, setNumber_ID))
    End Function
    Public Function CMS_SetNumber_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SetNumber_List(PortalConnect), GetType(CMS_SetNumberInfo))
    End Function
    Public Function CMS_SetNumber_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SetNumber_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SetNumberInfo))
    End Function
    Public Function CMS_SetNumber_Get_By_TinhTP_IsYear(PortalConnect As String, tinhTP As String, isYear As Integer) As CMS_SetNumberInfo
        Return CBO.FillObject(Of CMS_SetNumberInfo)(DataProvider.Instance().CMS_SetNumber_Get_By_TinhTP_IsYear(PortalConnect, tinhTP, isYear))
    End Function
    Public Sub CMS_SetNumber_Update_Value(PortalConnect As String, tinhTP As String, isYear As Integer, pCMS_Number As Integer, gP_Number As Integer)
        DataProvider.Instance().CMS_SetNumber_Update_Value(PortalConnect, tinhTP, isYear, pCMS_Number, gP_Number)
    End Sub
    Public Sub CMS_SetNumber_Add(PortalConnect As String, obj As CMS_SetNumberInfo)
        DataProvider.Instance().CMS_SetNumber_Add(PortalConnect, obj.SetNumber_ID, obj.TinhTP, obj.IsYear, obj.PCMS_Code, obj.PCMS_Number, obj.PCMS_Count, obj.GP_Code, obj.GP_Number, obj.GP_Count, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Sub CMS_SetNumber_Update(PortalConnect As String, obj As CMS_SetNumberInfo)
        DataProvider.Instance().CMS_SetNumber_Update(PortalConnect, obj.SetNumber_ID, obj.TinhTP, obj.IsYear, obj.PCMS_Code, obj.PCMS_Number, obj.PCMS_Count, obj.GP_Code, obj.GP_Number, obj.GP_Count, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Sub CMS_SetNumber_Delete(PortalConnect As String, setNumber_ID As String)
        DataProvider.Instance().CMS_SetNumber_Delete(PortalConnect, setNumber_ID)
    End Sub
#End Region
#Region "CMS_Signer"
    Public Function CMS_Signer_Get(PortalConnect As String, signer_ID As String) As CMS_SignerInfo
        Return CBO.FillObject(Of CMS_SignerInfo)(DataProvider.Instance().CMS_Signer_Get(PortalConnect, signer_ID))
    End Function
    Public Function CMS_Signer_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Signer_List(PortalConnect, portalId), GetType(CMS_SignerInfo))
    End Function
    Public Function CMS_Signer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Signer_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SignerInfo))
    End Function

    Public Sub CMS_Signer_Add(PortalConnect As String, obj As CMS_SignerInfo)
        DataProvider.Instance().CMS_Signer_Add(PortalConnect, obj.Signer_ID, obj.Signer_Name, obj.Position_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Signer_Update(PortalConnect As String, obj As CMS_SignerInfo)
        DataProvider.Instance().CMS_Signer_Update(PortalConnect, obj.Signer_ID, obj.Signer_Name, obj.Position_ID, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Signer_Delete(PortalConnect As String, signer_ID As String)
        DataProvider.Instance().CMS_Signer_Delete(PortalConnect, signer_ID)
    End Sub
#End Region
#Region "CMS_Skill"
    Public Function CMS_Skill_Get(PortalConnect As String, skill_ID As String) As CMS_SkillInfo
        Return CBO.FillObject(Of CMS_SkillInfo)(DataProvider.Instance().CMS_Skill_Get(PortalConnect, skill_ID))
    End Function
    Public Function CMS_Skill_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Skill_List(PortalConnect, portalId), GetType(CMS_SkillInfo))
    End Function
    Public Function CMS_Skill_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Skill_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SkillInfo))
    End Function

    Public Sub CMS_Skill_Add(PortalConnect As String, obj As CMS_SkillInfo)
        DataProvider.Instance().CMS_Skill_Add(PortalConnect, obj.Skill_ID, obj.Skill_Name, obj.Skill_Code, obj.Skill_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Skill_Update(PortalConnect As String, obj As CMS_SkillInfo)
        DataProvider.Instance().CMS_Skill_Update(PortalConnect, obj.Skill_ID, obj.Skill_Name, obj.Skill_Code, obj.Skill_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Skill_Delete(PortalConnect As String, skill_ID As String)
        DataProvider.Instance().CMS_Skill_Delete(PortalConnect, skill_ID)
    End Sub
#End Region
#Region "CMS_Specialized"
    Public Function CMS_Specialized_Get(PortalConnect As String, specialized_ID As String) As CMS_SpecializedInfo
        Return CBO.FillObject(Of CMS_SpecializedInfo)(DataProvider.Instance().CMS_Specialized_Get(PortalConnect, specialized_ID))
    End Function
    Public Function CMS_Specialized_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Specialized_List(PortalConnect, portalId), GetType(CMS_SpecializedInfo))
    End Function
    Public Function CMS_Specialized_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Specialized_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SpecializedInfo))
    End Function

    Public Sub CMS_Specialized_Add(PortalConnect As String, obj As CMS_SpecializedInfo)
        DataProvider.Instance().CMS_Specialized_Add(PortalConnect, obj.Specialized_ID, obj.Specialized_Name, obj.Specialized_Code, obj.Specialized_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Specialized_Update(PortalConnect As String, obj As CMS_SpecializedInfo)
        DataProvider.Instance().CMS_Specialized_Update(PortalConnect, obj.Specialized_ID, obj.Specialized_Name, obj.Specialized_Code, obj.Specialized_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Specialized_Delete(PortalConnect As String, specialized_ID As String)
        DataProvider.Instance().CMS_Specialized_Delete(PortalConnect, specialized_ID)
    End Sub
#End Region
#Region "CMS_Technical"
    Public Function CMS_Technical_Get(PortalConnect As String, technical_ID As String) As CMS_TechnicalInfo
        Return CBO.FillObject(Of CMS_TechnicalInfo)(DataProvider.Instance().CMS_Technical_Get(PortalConnect, technical_ID))
    End Function
    Public Function CMS_Technical_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Technical_List(PortalConnect, portalId), GetType(CMS_TechnicalInfo))
    End Function
    Public Function CMS_Technical_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Technical_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TechnicalInfo))
    End Function

    Public Sub CMS_Technical_Add(PortalConnect As String, obj As CMS_TechnicalInfo)
        DataProvider.Instance().CMS_Technical_Add(PortalConnect, obj.Technical_ID, obj.Technical_Name, obj.Technical_Code, obj.Technical_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Technical_Update(PortalConnect As String, obj As CMS_TechnicalInfo)
        DataProvider.Instance().CMS_Technical_Update(PortalConnect, obj.Technical_ID, obj.Technical_Name, obj.Technical_Code, obj.Technical_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Technical_Delete(PortalConnect As String, technical_ID As String)
        DataProvider.Instance().CMS_Technical_Delete(PortalConnect, technical_ID)
    End Sub
#End Region
#Region "CMS_Technology"
    Public Function CMS_Technology_Get(PortalConnect As String, technology_ID As String) As CMS_TechnologyInfo
        Return CBO.FillObject(Of CMS_TechnologyInfo)(DataProvider.Instance().CMS_Technology_Get(PortalConnect, technology_ID))
    End Function
    Public Function CMS_Technology_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Technology_List(PortalConnect, portalId), GetType(CMS_TechnologyInfo))
    End Function
    Public Function CMS_Technology_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Technology_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TechnologyInfo))
    End Function

    Public Sub CMS_Technology_Add(PortalConnect As String, obj As CMS_TechnologyInfo)
        DataProvider.Instance().CMS_Technology_Add(PortalConnect, obj.Technology_ID, obj.Technology_Name, obj.Technology_Code, obj.Technology_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Technology_Update(PortalConnect As String, obj As CMS_TechnologyInfo)
        DataProvider.Instance().CMS_Technology_Update(PortalConnect, obj.Technology_ID, obj.Technology_Name, obj.Technology_Code, obj.Technology_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Technology_Delete(PortalConnect As String, technology_ID As String)
        DataProvider.Instance().CMS_Technology_Delete(PortalConnect, technology_ID)
    End Sub
#End Region
#Region "CMS_Terminated"
    Public Function CMS_Terminated_Get(PortalConnect As String, terminated_ID As String) As CMS_TerminatedInfo
        Return CBO.FillObject(Of CMS_TerminatedInfo)(DataProvider.Instance().CMS_Terminated_Get(PortalConnect, terminated_ID))
    End Function
    Public Function CMS_Terminated_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Terminated_List(PortalConnect, portalId), GetType(CMS_TerminatedInfo))
    End Function
    Public Function CMS_Terminated_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Terminated_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TerminatedInfo))
    End Function

    Public Sub CMS_Terminated_Add(PortalConnect As String, obj As CMS_TerminatedInfo)
        DataProvider.Instance().CMS_Terminated_Add(PortalConnect, obj.Terminated_ID, obj.Terminated_Name, obj.Terminated_Code, obj.Terminated_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Terminated_Update(PortalConnect As String, obj As CMS_TerminatedInfo)
        DataProvider.Instance().CMS_Terminated_Update(PortalConnect, obj.Terminated_ID, obj.Terminated_Name, obj.Terminated_Code, obj.Terminated_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Terminated_Delete(PortalConnect As String, terminated_ID As String)
        DataProvider.Instance().CMS_Terminated_Delete(PortalConnect, terminated_ID)
    End Sub
#End Region
#Region "CMS_Training"
    Public Function CMS_Training_Get(PortalConnect As String, training_ID As String) As CMS_TrainingInfo
        Return CBO.FillObject(Of CMS_TrainingInfo)(DataProvider.Instance().CMS_Training_Get(PortalConnect, training_ID))
    End Function
    Public Function CMS_Training_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Training_List(PortalConnect, portalId), GetType(CMS_TrainingInfo))
    End Function
    Public Function CMS_Training_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Training_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TrainingInfo))
    End Function

    Public Sub CMS_Training_Add(PortalConnect As String, obj As CMS_TrainingInfo)
        DataProvider.Instance().CMS_Training_Add(PortalConnect, obj.Training_ID, obj.Training_Name, obj.Training_Address, obj.Training_Boss, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Training_Update(PortalConnect As String, obj As CMS_TrainingInfo)
        DataProvider.Instance().CMS_Training_Update(PortalConnect, obj.Training_ID, obj.Training_Name, obj.Training_Address, obj.Training_Boss, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Training_Delete(PortalConnect As String, training_ID As String)
        DataProvider.Instance().CMS_Training_Delete(PortalConnect, training_ID)
    End Sub
#End Region
#Region "CMS_Unit"
    Public Function CMS_Unit_Get(PortalConnect As String, unit_ID As String) As CMS_UnitInfo
        Return CBO.FillObject(Of CMS_UnitInfo)(DataProvider.Instance().CMS_Unit_Get(PortalConnect, unit_ID))
    End Function
    Public Function CMS_Unit_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_List(PortalConnect, portalId), GetType(CMS_UnitInfo))
    End Function
    Public Function CMS_Unit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, PortalID), GetType(CMS_UnitInfo))
    End Function
    Public Function CMS_Unit_Get_By_CMS_Unit(PortalConnect As String, unit_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_Get_By_CMS_Unit(PortalConnect, unit_ID), GetType(CMS_UnitInfo))
    End Function
    Public Function CMS_Unit_List_Parent_NULL(PortalConnect As String, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_List_Parent_NULL(PortalConnect, PortalID), GetType(CMS_UnitInfo))
    End Function
    Public Function CMS_Unit_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer, PortalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_Parent_Search_Null(PortalConnect, search, isOrder, PortalID), GetType(CMS_UnitInfo))
    End Function
    Public Function CMS_Unit_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Unit_Parent_Search_ID(PortalConnect, search, isOrder, Parent_ID), GetType(CMS_UnitInfo))
    End Function
    Public Sub CMS_Unit_Add(PortalConnect As String, obj As CMS_UnitInfo)
        DataProvider.Instance().CMS_Unit_Add(PortalConnect, obj.Unit_ID, obj.Parent_ID, obj.Unit_Name, obj.Unit_Des, obj.Unit_Logo, obj.Unit_Images, obj.Unit_Address, obj.Unit_Tel, obj.Unit_Email, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Unit_Update(PortalConnect As String, obj As CMS_UnitInfo)
        DataProvider.Instance().CMS_Unit_Update(PortalConnect, obj.Unit_ID, obj.Parent_ID, obj.Unit_Name, obj.Unit_Des, obj.Unit_Logo, obj.Unit_Images, obj.Unit_Address, obj.Unit_Tel, obj.Unit_Email, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Unit_Delete(PortalConnect As String, unit_ID As String)
        DataProvider.Instance().CMS_Unit_Delete(PortalConnect, unit_ID)
    End Sub
#End Region
#Region "CMS_Wage"
    Public Function CMS_Wage_Get(PortalConnect As String, wage_ID As String) As CMS_WageInfo
        Return CBO.FillObject(Of CMS_WageInfo)(DataProvider.Instance().CMS_Wage_Get(PortalConnect, wage_ID))
    End Function
    Public Function CMS_Wage_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Wage_List(PortalConnect, portalId), GetType(CMS_WageInfo))
    End Function
    Public Function CMS_Wage_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Wage_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_WageInfo))
    End Function

    Public Sub CMS_Wage_Add(PortalConnect As String, obj As CMS_WageInfo)
        DataProvider.Instance().CMS_Wage_Add(PortalConnect, obj.Wage_ID, obj.Wage_Name, obj.Wage_Code, obj.Wage_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Wage_Update(PortalConnect As String, obj As CMS_WageInfo)
        DataProvider.Instance().CMS_Wage_Update(PortalConnect, obj.Wage_ID, obj.Wage_Name, obj.Wage_Code, obj.Wage_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Wage_Delete(PortalConnect As String, wage_ID As String)
        DataProvider.Instance().CMS_Wage_Delete(PortalConnect, wage_ID)
    End Sub
#End Region
#Region "CMS_Recipients"
    Public Function CMS_Recipients_Get(PortalConnect As String, Recipients_ID As String) As CMS_RecipientsInfo
        Return CBO.FillObject(Of CMS_RecipientsInfo)(DataProvider.Instance().CMS_Recipients_Get(PortalConnect, Recipients_ID))
    End Function
    Public Function CMS_Recipients_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recipients_List(PortalConnect, portalId), GetType(CMS_RecipientsInfo))
    End Function
    Public Function CMS_Recipients_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recipients_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_RecipientsInfo))
    End Function

    Public Sub CMS_Recipients_Add(PortalConnect As String, obj As CMS_RecipientsInfo)
        DataProvider.Instance().CMS_Recipients_Add(PortalConnect, obj.Recipients_ID, obj.Recipients_Name, obj.Recipients_Code, obj.Recipients_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Recipients_Update(PortalConnect As String, obj As CMS_RecipientsInfo)
        DataProvider.Instance().CMS_Recipients_Update(PortalConnect, obj.Recipients_ID, obj.Recipients_Name, obj.Recipients_Code, obj.Recipients_Des, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.PortalId)
    End Sub
    Public Sub CMS_Recipients_Delete(PortalConnect As String, Recipients_ID As String)
        DataProvider.Instance().CMS_Recipients_Delete(PortalConnect, Recipients_ID)
    End Sub
#End Region
#Region "EXE_ProSubsi"
    Public Function EXE_ProSubsi_Find(PortalConnect As String, noCode As String) As EXE_ProSubsiInfo
        Return CBO.FillObject(Of EXE_ProSubsiInfo)(DataProvider.Instance().EXE_ProSubsi_Find(PortalConnect, noCode))
    End Function
    Public Sub EXE_ProSubsi_Update_TrangThai(PortalConnect As String, proSubsi_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        DataProvider.Instance().EXE_ProSubsi_Update_TrangThai(PortalConnect, proSubsi_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Sub EXE_ProSubsi_Update_PhieuHen(PortalConnect As String, proSubsi_ID As String, NgayTraKetQua As DateTime, QRCode As String)
        DataProvider.Instance().EXE_ProSubsi_Update_PhieuHen(PortalConnect, proSubsi_ID, NgayTraKetQua, QRCode)
    End Sub
    Public Function EXE_ProSubsi_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_ProSubsi_List_Search(PortalConnect, Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), GetType(EXE_ProSubsiInfo))
    End Function
    Public Function EXE_ProSubsi_Get(PortalConnect As String, proSubsi_ID As String) As EXE_ProSubsiInfo
        Return CBO.FillObject(Of EXE_ProSubsiInfo)(DataProvider.Instance().EXE_ProSubsi_Get(PortalConnect, proSubsi_ID))
    End Function
    Public Function EXE_ProSubsi_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_ProSubsi_List(PortalConnect, portalId), GetType(EXE_ProSubsiInfo))
    End Function
    Public Sub EXE_ProSubsi_Add(PortalConnect As String, obj As EXE_ProSubsiInfo)
        DataProvider.Instance().EXE_ProSubsi_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_ProSubsi_Update(PortalConnect As String, obj As EXE_ProSubsiInfo)
        DataProvider.Instance().EXE_ProSubsi_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_ProSubsi_Delete(PortalConnect As String, proSubsi_ID As String)
        DataProvider.Instance().EXE_ProSubsi_Delete(PortalConnect, proSubsi_ID)
    End Sub
#End Region
#Region "EXE_Apprentice"
    Public Function EXE_Apprentice_Find(PortalConnect As String, noCode As String) As EXE_ApprenticeInfo
        Return CBO.FillObject(Of EXE_ApprenticeInfo)(DataProvider.Instance().EXE_Apprentice_Find(PortalConnect, noCode))
    End Function
    Public Sub EXE_Apprentice_Update_TrangThai(PortalConnect As String, apprentice_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        DataProvider.Instance().EXE_Apprentice_Update_TrangThai(PortalConnect, apprentice_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Function EXE_Apprentice_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Apprentice_List_Search(PortalConnect, Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), GetType(EXE_ApprenticeInfo))
    End Function
    Public Function EXE_Apprentice_Get(PortalConnect As String, apprentice_ID As String) As EXE_ApprenticeInfo
        Return CBO.FillObject(Of EXE_ApprenticeInfo)(DataProvider.Instance().EXE_Apprentice_Get(PortalConnect, apprentice_ID))
    End Function
    Public Function EXE_Apprentice_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Apprentice_List(PortalConnect, portalId), GetType(EXE_ApprenticeInfo))
    End Function
    Public Sub EXE_Apprentice_Add(PortalConnect As String, obj As EXE_ApprenticeInfo)
        DataProvider.Instance().EXE_Apprentice_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_Apprentice_Update(PortalConnect As String, obj As EXE_ApprenticeInfo)
        DataProvider.Instance().EXE_Apprentice_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_Apprentice_Delete(PortalConnect As String, apprentice_ID As String)
        DataProvider.Instance().EXE_Apprentice_Delete(PortalConnect, apprentice_ID)
    End Sub
#End Region
#Region "EXE_Advisory"
    Public Function EXE_Advisory_Find(PortalConnect As String, noCode As String) As EXE_AdvisoryInfo
        Return CBO.FillObject(Of EXE_AdvisoryInfo)(DataProvider.Instance().EXE_Advisory_Find(PortalConnect, noCode))
    End Function
    Public Sub EXE_Advisory_Update_TrangThai(PortalConnect As String, advisory_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        DataProvider.Instance().EXE_Advisory_Update_TrangThai(PortalConnect, advisory_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Function EXE_Advisory_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Advisory_List_Search(PortalConnect, Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), GetType(EXE_AdvisoryInfo))
    End Function
    Public Function EXE_Insurrance_Count_Add(PortalConnect As String, types As Integer) As Integer
        Return DataProvider.Instance().EXE_Insurrance_Count_Add(PortalConnect, types)
    End Function
    Public Function EXE_Advisory_Get(PortalConnect As String, advisory_ID As String) As EXE_AdvisoryInfo
        Return CBO.FillObject(Of EXE_AdvisoryInfo)(DataProvider.Instance().EXE_Advisory_Get(PortalConnect, advisory_ID))
    End Function
    Public Function EXE_Advisory_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Advisory_List(PortalConnect, portalId), GetType(EXE_AdvisoryInfo))
    End Function
    Public Sub EXE_Advisory_Add(PortalConnect As String, obj As EXE_AdvisoryInfo)
        DataProvider.Instance().EXE_Advisory_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_Advisory_Update(PortalConnect As String, obj As EXE_AdvisoryInfo)
        DataProvider.Instance().EXE_Advisory_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_Advisory_Delete(PortalConnect As String, advisory_ID As String)
        DataProvider.Instance().EXE_Advisory_Delete(PortalConnect, advisory_ID)
    End Sub
#End Region
#Region "EXE_AdvisoryC"
    Public Function EXE_AdvisoryC_Get(PortalConnect As String, advisoryC_ID As String) As EXE_AdvisoryCInfo
        Return CBO.FillObject(Of EXE_AdvisoryCInfo)(DataProvider.Instance().EXE_AdvisoryC_Get(PortalConnect, advisoryC_ID))
    End Function
    Public Function EXE_AdvisoryC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_AdvisoryC_List(PortalConnect), GetType(EXE_AdvisoryCInfo))
    End Function
    Public Function EXE_AdvisoryC_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_AdvisoryC_Get_By_EXE_Advisory(PortalConnect, advisory_ID), GetType(EXE_AdvisoryCInfo))
    End Function
    Public Sub EXE_AdvisoryC_Add(PortalConnect As String, obj As EXE_AdvisoryCInfo)
        DataProvider.Instance().EXE_AdvisoryC_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_AdvisoryC_Update(PortalConnect As String, obj As EXE_AdvisoryCInfo)
        DataProvider.Instance().EXE_AdvisoryC_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_AdvisoryC_Delete(PortalConnect As String, advisoryC_ID As String)
        DataProvider.Instance().EXE_AdvisoryC_Delete(PortalConnect, advisoryC_ID)
    End Sub
    Public Sub EXE_AdvisoryC_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
        DataProvider.Instance().EXE_AdvisoryC_Delete_By_EXE_Advisory(PortalConnect, advisory_ID)
    End Sub
#End Region
#Region "EXE_AdvisoryS"
    Public Function EXE_AdvisoryS_Get(PortalConnect As String, advisoryS_ID As String) As EXE_AdvisorySInfo
        Return CBO.FillObject(Of EXE_AdvisorySInfo)(DataProvider.Instance().EXE_AdvisoryS_Get(PortalConnect, advisoryS_ID))
    End Function
    Public Function EXE_AdvisoryS_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_AdvisoryS_List(PortalConnect), GetType(EXE_AdvisorySInfo))
    End Function
    Public Function EXE_AdvisoryS_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_AdvisoryS_Get_By_EXE_Advisory(PortalConnect, advisory_ID), GetType(EXE_AdvisorySInfo))
    End Function
    Public Sub EXE_AdvisoryS_Add(PortalConnect As String, obj As EXE_AdvisorySInfo)
        DataProvider.Instance().EXE_AdvisoryS_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_AdvisoryS_Update(PortalConnect As String, obj As EXE_AdvisorySInfo)
        DataProvider.Instance().EXE_AdvisoryS_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_AdvisoryS_Delete(PortalConnect As String, advisoryS_ID As String)
        DataProvider.Instance().EXE_AdvisoryS_Delete(PortalConnect, advisoryS_ID)
    End Sub
    Public Sub EXE_AdvisoryS_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
        DataProvider.Instance().EXE_AdvisoryS_Delete_By_EXE_Advisory(PortalConnect, advisory_ID)
    End Sub
#End Region
#Region "EXE_Notification"
    Public Function EXE_Notification_Find(PortalConnect As String, noCode As String) As EXE_NotificationInfo
        Return CBO.FillObject(Of EXE_NotificationInfo)(DataProvider.Instance().EXE_Notification_Find(PortalConnect, noCode))
    End Function
    Public Sub EXE_Notification_Update_TrangThai(PortalConnect As String, notification_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        DataProvider.Instance().EXE_Notification_Update_TrangThai(PortalConnect, notification_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Function EXE_Notification_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, qD_VeTinh As String, nam As Integer, thang As Integer, ngay As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Notification_List_Search(PortalConnect, Search, currPage, recodperpage, portalId, trangThai, qD_VeTinh, nam, thang, ngay, userName), GetType(EXE_NotificationInfo))
    End Function
    Public Function EXE_Notification_List_AppID(PortalConnect As String, currPage As Integer, recodperpage As Integer, Decide_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Notification_List_AppID(PortalConnect, currPage, recodperpage, Decide_ID), GetType(EXE_NotificationInfo))
    End Function
    Public Function EXE_Notification_Get(PortalConnect As String, notification_ID As String) As EXE_NotificationInfo
        Return CBO.FillObject(Of EXE_NotificationInfo)(DataProvider.Instance().EXE_Notification_Get(PortalConnect, notification_ID))
    End Function
    Public Function EXE_Notification_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_Notification_List(PortalConnect, portalId), GetType(EXE_NotificationInfo))
    End Function
    Public Sub EXE_Notification_Add(PortalConnect As String, obj As EXE_NotificationInfo)
        DataProvider.Instance().EXE_Notification_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_Notification_Update(PortalConnect As String, obj As EXE_NotificationInfo)
        DataProvider.Instance().EXE_Notification_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_Notification_Delete(PortalConnect As String, notification_ID As String)
        DataProvider.Instance().EXE_Notification_Delete(PortalConnect, notification_ID)
    End Sub
#End Region
#Region "EXE_NotificationD"
    Public Function EXE_NotificationD_Get(PortalConnect As String, notificationD_ID As String) As EXE_NotificationDInfo
        Return CBO.FillObject(Of EXE_NotificationDInfo)(DataProvider.Instance().EXE_NotificationD_Get(PortalConnect, notificationD_ID))
    End Function
    Public Function EXE_NotificationD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NotificationD_List(PortalConnect), GetType(EXE_NotificationDInfo))
    End Function
    Public Function EXE_NotificationD_Get_By_EXE_Notification(PortalConnect As String, notification_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NotificationD_Get_By_EXE_Notification(PortalConnect, notification_ID), GetType(EXE_NotificationDInfo))
    End Function

    Public Sub EXE_NotificationD_Add(PortalConnect As String, obj As EXE_NotificationDInfo)
        DataProvider.Instance().EXE_NotificationD_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_NotificationD_Update(PortalConnect As String, obj As EXE_NotificationDInfo)
        DataProvider.Instance().EXE_NotificationD_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_NotificationD_Delete(PortalConnect As String, notificationD_ID As String)
        DataProvider.Instance().EXE_NotificationD_Delete(PortalConnect, notificationD_ID)
    End Sub
#End Region
#Region "EXE_NumberAuto"
    Public Function EXE_NumberAuto_Check_Register(PortalConnect As String, dichVu As Integer, ngayNghiViec As DateTime, dienThoai As String, soBHXH As String) As EXE_NumberAutoInfo
        Return CBO.FillObject(Of EXE_NumberAutoInfo)(DataProvider.Instance().EXE_NumberAuto_Check_Register(PortalConnect, dichVu, ngayNghiViec, dienThoai, soBHXH))
    End Function
    Public Function EXE_NumberAuto_List_Search(PortalConnect As String, veTinh As String, ngayDangKy As DateTime, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NumberAuto_List_Search(PortalConnect, veTinh, ngayDangKy, dichVu, search, currPage, recodperpage, userName), GetType(EXE_NumberAutoInfo))
    End Function
    Public Sub EXE_NumberAuto_Update_TinhTrang(PortalConnect As String, numberAuto_ID As String, tinhTrang As Integer)
        DataProvider.Instance().EXE_NumberAuto_Update_TinhTrang(PortalConnect, numberAuto_ID, tinhTrang)
    End Sub
    Public Sub EXE_NumberAuto_Update_IsOnline(PortalConnect As String, numberAuto_ID As String, isOnline As Boolean)
        DataProvider.Instance().EXE_NumberAuto_Update_IsOnline(PortalConnect, numberAuto_ID, isOnline)
    End Sub
    Public Function EXE_NumberAuto_Get(PortalConnect As String, numberAuto_ID As String) As EXE_NumberAutoInfo
        Return CBO.FillObject(Of EXE_NumberAutoInfo)(DataProvider.Instance().EXE_NumberAuto_Get(PortalConnect, numberAuto_ID))
    End Function
    Public Function EXE_NumberAuto_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NumberAuto_List(PortalConnect, portalId), GetType(EXE_NumberAutoInfo))
    End Function
    Public Function EXE_NumberAuto_Get_ToApp(PortalConnect As String, dienThoai As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NumberAuto_Get_ToApp(PortalConnect, dienThoai, currPage, recodperpage), GetType(EXE_NumberAutoInfo))
    End Function
    Public Function EXE_NumberAuto_List_IsOnline(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NumberAuto_List_IsOnline(PortalConnect, portalId), GetType(EXE_NumberAutoInfo))
    End Function
    Public Function EXE_NumberAuto_Add(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return DataProvider.Instance().EXE_NumberAuto_Add(PortalConnect, obj)
    End Function
    Public Function EXE_NumberAuto_Add_Lite(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return DataProvider.Instance().EXE_NumberAuto_Add_Lite(PortalConnect, obj)
    End Function
    Public Function EXE_NumberAuto_Add_Offline(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return DataProvider.Instance().EXE_NumberAuto_Add_Offline(PortalConnect, obj)
    End Function
    Public Sub EXE_NumberAuto_Delete(PortalConnect As String, numberAuto_ID As String)
        DataProvider.Instance().EXE_NumberAuto_Delete(PortalConnect, numberAuto_ID)
    End Sub
#End Region
#Region "CMS_DashBoard"
    Public Function CMS_DashBoard_Admin(PortalConnect As String, portalId As Integer) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_Admin(PortalConnect, portalId))
    End Function
#End Region
#Region "CMS_SettingAuto"
    Public Function CMS_SettingAuto_Get(PortalConnect As String, iD As Integer) As CMS_SettingAutoInfo
        Return CBO.FillObject(Of CMS_SettingAutoInfo)(DataProvider.Instance().CMS_SettingAuto_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SettingAuto_Get_ByPortal(PortalConnect As String, portal_ID As Integer, Satellite_ID As String, FlagType As Int16) As CMS_SettingAutoInfo
        Return CBO.FillObject(Of CMS_SettingAutoInfo)(DataProvider.Instance().CMS_SettingAuto_Get_ByPortal(PortalConnect, portal_ID, Satellite_ID, FlagType))
    End Function
    Public Function CMS_SettingAuto_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingAuto_List(PortalConnect), GetType(CMS_SettingAutoInfo))
    End Function
    Public Function CMS_SettingAuto_List_Service(PortalConnect As String, Satellite_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingAuto_List_Service(PortalConnect, Satellite_ID), GetType(CMS_SettingAutoInfo))
    End Function

    Public Function CMS_SettingAuto_Add(PortalConnect As String, obj As CMS_SettingAutoInfo) As Integer
        Return DataProvider.Instance().CMS_SettingAuto_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SettingAuto_Update(PortalConnect As String, obj As CMS_SettingAutoInfo)
        DataProvider.Instance().CMS_SettingAuto_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SettingAuto_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_SettingAuto_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SettingDoor"
    Public Function CMS_SettingDoor_Get(PortalConnect As String, iD As Integer) As CMS_SettingDoorInfo
        Return CBO.FillObject(Of CMS_SettingDoorInfo)(DataProvider.Instance().CMS_SettingDoor_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SettingDoor_GetBy_Portal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As CMS_SettingDoorInfo
        Return CBO.FillObject(Of CMS_SettingDoorInfo)(DataProvider.Instance().CMS_SettingDoor_GetBy_Portal(PortalConnect, Portal_ID, satellite_id, flagType, day, month, year))
    End Function
    Public Function CMS_SettingDoor_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingDoor_List(PortalConnect), GetType(CMS_SettingDoorInfo))
    End Function
    Public Function CMS_SettingDoor_List_ByPortal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingDoor_List_ByPortal(PortalConnect, Portal_ID, satellite_id, flagType, day, month, year), GetType(CMS_SettingDoorInfo))
    End Function
    Public Function CMS_SettingDoor_List_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, months As Integer, years As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingDoor_List_To_App(PortalConnect, veTinhID, dichVu, fromDate, toDate, months, years), GetType(CMS_SettingDoorInfo))
    End Function
    Public Function CMS_SettingDoor_Select_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, soBHXH As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingDoor_Select_To_App(PortalConnect, veTinhID, dichVu, fromDate, toDate, soBHXH), GetType(CMS_SettingDoorInfo))
    End Function
    Public Function CMS_SettingDoor_Add(PortalConnect As String, obj As CMS_SettingDoorInfo) As Integer
        Return DataProvider.Instance().CMS_SettingDoor_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SettingDoor_Update(PortalConnect As String, obj As CMS_SettingDoorInfo)
        DataProvider.Instance().CMS_SettingDoor_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SettingDoor_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_SettingDoor_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SettingTime"
    Public Function CMS_SettingTime_Get(PortalConnect As String, iD As String) As CMS_SettingTimeInfo
        Return CBO.FillObject(Of CMS_SettingTimeInfo)(DataProvider.Instance().CMS_SettingTime_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SettingTime_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingTime_List(PortalConnect), GetType(CMS_SettingTimeInfo))
    End Function
    Public Function CMS_SettingTime_List_ByAutoID(PortalConnect As String, settingauto_id As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SettingTime_List_ByAutoID(PortalConnect, settingauto_id), GetType(CMS_SettingTimeInfo))
    End Function

    Public Sub CMS_SettingTime_Add(PortalConnect As String, obj As CMS_SettingTimeInfo)
        DataProvider.Instance().CMS_SettingTime_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_SettingTime_Update(PortalConnect As String, obj As CMS_SettingTimeInfo)
        DataProvider.Instance().CMS_SettingTime_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SettingTime_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().CMS_SettingTime_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_DoorTime"
    Public Function CMS_DoorTime_Get(PortalConnect As String, iD As Integer) As CMS_DoorTimeInfo
        Return CBO.FillObject(Of CMS_DoorTimeInfo)(DataProvider.Instance().CMS_DoorTime_Get(PortalConnect, iD))
    End Function
    Public Function CMS_DoorTime_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoorTime_List(PortalConnect), GetType(CMS_DoorTimeInfo))
    End Function

    Public Function CMS_DoorTime_Add(PortalConnect As String, obj As CMS_DoorTimeInfo) As Integer
        Return DataProvider.Instance().CMS_DoorTime_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DoorTime_Update(PortalConnect As String, obj As CMS_DoorTimeInfo)
        DataProvider.Instance().CMS_DoorTime_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DoorTime_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_DoorTime_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Door"
    Public Function CMS_Door_List_Search(PortalConnect As String, portalID As Integer, veTinh As String, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Door_List_Search(PortalConnect, portalID, veTinh, dichVu, search, currPage, recodperpage), GetType(CMS_DoorInfo))
    End Function
    Public Function CMS_Door_Get(PortalConnect As String, doorID As Integer) As CMS_DoorInfo
        Return CBO.FillObject(Of CMS_DoorInfo)(DataProvider.Instance().CMS_Door_Get(PortalConnect, doorID))
    End Function
    Public Function CMS_Door_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Door_List(PortalConnect, portalId), GetType(CMS_DoorInfo))
    End Function

    Public Function CMS_Door_Add(PortalConnect As String, obj As CMS_DoorInfo) As Integer
        Return DataProvider.Instance().CMS_Door_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Door_Update(PortalConnect As String, obj As CMS_DoorInfo)
        DataProvider.Instance().CMS_Door_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Door_Delete(PortalConnect As String, doorID As Integer)
        DataProvider.Instance().CMS_Door_Delete(PortalConnect, doorID)
    End Sub
#End Region
#Region "EXE_FileAttch"
    Public Function EXE_FileAttch_Get(PortalConnect As String, iD As String) As EXE_FileAttchInfo
        Return CBO.FillObject(Of EXE_FileAttchInfo)(DataProvider.Instance().EXE_FileAttch_Get(PortalConnect, iD))
    End Function
    Public Function EXE_FileAttch_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_FileAttch_List(PortalConnect), GetType(EXE_FileAttchInfo))
    End Function
    Public Function EXE_FileAttch_List_By_IdKey(PortalConnect As String, IdKey As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_FileAttch_List_By_IdKey(PortalConnect, IdKey), GetType(EXE_FileAttchInfo))
    End Function
    Public Sub EXE_FileAttch_Add(PortalConnect As String, obj As EXE_FileAttchInfo)
        DataProvider.Instance().EXE_FileAttch_Add(PortalConnect, obj)
    End Sub
    Public Sub EXE_FileAttch_Update(PortalConnect As String, obj As EXE_FileAttchInfo)
        DataProvider.Instance().EXE_FileAttch_Update(PortalConnect, obj)
    End Sub
    Public Sub EXE_FileAttch_Delete(PortalConnect As String, iD As String)
        DataProvider.Instance().EXE_FileAttch_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "REPORT"
    Public Function EXE_NumberAuto_Report(PortalConnect As String, typeId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().EXE_NumberAuto_Report(PortalConnect, typeId), GetType(EPORTAL.ReportInfo))
    End Function
#End Region


End Class