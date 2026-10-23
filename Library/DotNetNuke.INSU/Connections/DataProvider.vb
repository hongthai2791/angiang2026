Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.INSU", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_Portal"
    Public MustOverride Function CMS_Portal_Get(PortalConnect As String, portalID As Integer) As IDataReader
    Public MustOverride Function CMS_Portal_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Portal_List_App_Type(PortalConnect As String, type As String) As IDataReader
    Public MustOverride Function CMS_Portal_List_App(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Portal_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Portal_Add(PortalConnect As String, portalName As String, logo As String, tinhTP As String, quanHuyen As String, xaPhuong As String, duongPho As String, nguoiDaiDien As String, position_ID As String, website As String, email As String, mobile As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean) As Integer
    Public MustOverride Sub CMS_Portal_Update(PortalConnect As String, portalID As Integer, portalName As String, logo As String, tinhTP As String, quanHuyen As String, xaPhuong As String, duongPho As String, nguoiDaiDien As String, position_ID As String, website As String, email As String, mobile As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean)
    Public MustOverride Sub CMS_Portal_Delete(PortalConnect As String, portalID As Integer)
#End Region
#Region "CMS_Banking"
    Public MustOverride Function CMS_Banking_Get(PortalConnect As String, banking_ID As String) As IDataReader
    Public MustOverride Function CMS_Banking_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Banking_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Banking_Add(PortalConnect As String, banking_ID As String, banking_Name As String, banking_Code As String, banking_Logo As String, banking_Website As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Banking_Update(PortalConnect As String, banking_ID As String, banking_Name As String, banking_Code As String, banking_Logo As String, banking_Website As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Banking_Delete(PortalConnect As String, banking_ID As String)
#End Region
#Region "CMS_Branch"
    Public MustOverride Function CMS_Branch_Get(PortalConnect As String, branch_ID As String) As IDataReader
    Public MustOverride Function CMS_Branch_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Branch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Banking_ID As String, PortalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Branch_Add(PortalConnect As String, branch_ID As String, branch_Name As String, branch_Code As String, branch_Tel As String, branch_Address As String, tinhTP As String, banking_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Branch_Update(PortalConnect As String, branch_ID As String, branch_Name As String, branch_Code As String, branch_Tel As String, branch_Address As String, tinhTP As String, banking_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Function CMS_Branch_Get_By_CMS_Banking(PortalConnect As String, banking_ID As String, PortalId As Integer) As IDataReader
    Public MustOverride Sub CMS_Branch_Delete(PortalConnect As String, branch_ID As String)
#End Region
#Region "CMS_Cannot"
    Public MustOverride Function CMS_Cannot_Get(PortalConnect As String, cannot_ID As String) As IDataReader
    Public MustOverride Function CMS_Cannot_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Cannot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Cannot_Add(PortalConnect As String, cannot_ID As String, cannot_Name As String, cannot_Code As String, cannot_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Cannot_Update(PortalConnect As String, cannot_ID As String, cannot_Name As String, cannot_Code As String, cannot_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Cannot_Delete(PortalConnect As String, cannot_ID As String)
#End Region
#Region "CMS_Career"
    Public MustOverride Function CMS_Career_Get(PortalConnect As String, career_ID As String) As IDataReader
    Public MustOverride Function CMS_Career_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Career_Add(PortalConnect As String, career_ID As String, career_Name As String, career_Code As String, career_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Career_Update(PortalConnect As String, career_ID As String, career_Name As String, career_Code As String, career_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
#End Region
#Region "CMS_CauseOf"
    Public MustOverride Function CMS_CauseOf_Get(PortalConnect As String, causeOf_ID As String) As IDataReader
    Public MustOverride Function CMS_CauseOf_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_CauseOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_CauseOf_Add(PortalConnect As String, causeOf_ID As String, causeOf_Name As String, causeOf_Code As String, causeOf_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_CauseOf_Update(PortalConnect As String, causeOf_ID As String, causeOf_Name As String, causeOf_Code As String, causeOf_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_CauseOf_Delete(PortalConnect As String, causeOf_ID As String)
#End Region
#Region "CMS_Company"
    Public MustOverride Function CMS_Company_Get(PortalConnect As String, company_ID As String) As IDataReader
    Public MustOverride Function CMS_Company_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Company_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Company_Add(PortalConnect As String, company_ID As String, company_Name As String, company_Code As String, company_Logo As String, company_Tel As String, company_Website As String, comType_ID As String, tinhTP As String, quanHuyen As String, xaPhuong As String, soNha As String, career_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Company_Update(PortalConnect As String, company_ID As String, company_Name As String, company_Code As String, company_Logo As String, company_Tel As String, company_Website As String, comType_ID As String, tinhTP As String, quanHuyen As String, xaPhuong As String, soNha As String, career_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Function CMS_Company_Get_By_CMS_ComType(PortalConnect As String, comType_ID As String) As IDataReader
    Public MustOverride Sub CMS_Company_Delete(PortalConnect As String, company_ID As String)
#End Region
#Region "CMS_ComType"
    Public MustOverride Function CMS_ComType_Get(PortalConnect As String, comType_ID As String) As IDataReader
    Public MustOverride Function CMS_ComType_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ComType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_ComType_Add(PortalConnect As String, comType_ID As String, comtype_Name As String, comtype_Code As String, comtype_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_ComType_Update(PortalConnect As String, comType_ID As String, comtype_Name As String, comtype_Code As String, comtype_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_ComType_Delete(PortalConnect As String, comType_ID As String)
#End Region
#Region "CMS_ContractType"
    Public MustOverride Function CMS_ContractType_Get(PortalConnect As String, contractType_ID As String) As IDataReader
    Public MustOverride Function CMS_ContractType_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_ContractType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_ContractType_Add(PortalConnect As String, contractType_ID As String, contractType_Name As String, contractType_Code As String, contractType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_ContractType_Update(PortalConnect As String, contractType_ID As String, contractType_Name As String, contractType_Code As String, contractType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_ContractType_Delete(PortalConnect As String, contractType_ID As String)
#End Region
#Region "CMS_Course"
    Public MustOverride Function CMS_Course_Get(PortalConnect As String, course_ID As String) As IDataReader
    Public MustOverride Function CMS_Course_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Course_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Training_ID As String) As IDataReader
    Public MustOverride Function CMS_Course_Gey_By_CMS_Training(PortalConnect As String, portalId As Integer, Training_ID As String) As IDataReader
    Public MustOverride Sub CMS_Course_Add(PortalConnect As String, course_ID As String, training_ID As String, course_Name As String, tuition As Double, isMonth As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Course_Update(PortalConnect As String, course_ID As String, training_ID As String, course_Name As String, tuition As Double, isMonth As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Course_Delete(PortalConnect As String, course_ID As String)
#End Region
#Region "CMS_DayOff"
    Public MustOverride Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As IDataReader
    Public MustOverride Function CMS_DayOff_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_DayOff_Get_OffTime(PortalConnect As String, Dates As DateTime) As Integer
    Public MustOverride Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer

    Public MustOverride Sub CMS_DayOff_Add(PortalConnect As String, dayOff_ID As String, dayOff_Name As String, isDay As Integer, isMonth As Integer, isYear As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_DayOff_Update(PortalConnect As String, dayOff_ID As String, dayOff_Name As String, isDay As Integer, isMonth As Integer, isYear As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
#End Region
#Region "CMS_DecidedType"
    Public MustOverride Function CMS_DecidedType_Get(PortalConnect As String, decidedType_ID As String) As IDataReader
    Public MustOverride Function CMS_DecidedType_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_DecidedType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_DecidedType_Add(PortalConnect As String, decidedType_ID As String, decidedType_Name As String, decidedType_Code As String, decidedType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_DecidedType_Update(PortalConnect As String, decidedType_ID As String, decidedType_Name As String, decidedType_Code As String, decidedType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_DecidedType_Delete(PortalConnect As String, decidedType_ID As String)
#End Region
#Region "CMS_Field"
    Public MustOverride Function CMS_Field_Get(PortalConnect As String, field_ID As String) As IDataReader
    Public MustOverride Function CMS_Field_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Field_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Field_Add(PortalConnect As String, field_ID As String, field_Name As String, field_Code As String, field_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Field_Update(PortalConnect As String, field_ID As String, field_Name As String, field_Code As String, field_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Field_Delete(PortalConnect As String, field_ID As String)
#End Region
#Region "CMS_FileAttch"
    Public MustOverride Function CMS_FileAttch_Get(PortalConnect As String, fileAttch_ID As String) As IDataReader
    Public MustOverride Function CMS_FileAttch_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_FileAttch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_FileAttch_Add(PortalConnect As String, fileAttch_ID As String, document_ID As String, fileAttch_Name As String, fileAttch_Attch As String, isOrder As Integer, createdDate As DateTime, createdUser As String)
    Public MustOverride Sub CMS_FileAttch_Update(PortalConnect As String, fileAttch_ID As String, document_ID As String, fileAttch_Name As String, fileAttch_Attch As String, isOrder As Integer, createdDate As DateTime, createdUser As String)
    Public MustOverride Sub CMS_FileAttch_Delete(PortalConnect As String, fileAttch_ID As String)
#End Region
#Region "CMS_Insurance"
    Public MustOverride Function CMS_Insurance_Get(PortalConnect As String, insurance_ID As String) As IDataReader
    Public MustOverride Function CMS_Insurance_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Insurance_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Insurance_Add(PortalConnect As String, insurance_ID As String, insurance_Code As String, insurance_Name As String, insurance_Address As String, insurance_Des As String, quanHuyen As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Insurance_Update(PortalConnect As String, insurance_ID As String, insurance_Code As String, insurance_Name As String, insurance_Address As String, insurance_Des As String, quanHuyen As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Insurance_Delete(PortalConnect As String, insurance_ID As String)
#End Region
#Region "CMS_LaborType"
    Public MustOverride Function CMS_LaborType_Get(PortalConnect As String, laborType_ID As String) As IDataReader
    Public MustOverride Function CMS_LaborType_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_LaborType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_LaborType_Add(PortalConnect As String, laborType_ID As String, laborType_Name As String, laborType_Code As String, laborType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_LaborType_Update(PortalConnect As String, laborType_ID As String, laborType_Name As String, laborType_Code As String, laborType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_LaborType_Delete(PortalConnect As String, laborType_ID As String)
#End Region
#Region "CMS_Leaving"
    Public MustOverride Function CMS_Leaving_Get(PortalConnect As String, leaving_ID As String) As IDataReader
    Public MustOverride Function CMS_Leaving_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Leaving_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Leaving_Add(PortalConnect As String, leaving_ID As String, leaving_Name As String, leaving_Code As String, leaving_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Leaving_Update(PortalConnect As String, leaving_ID As String, leaving_Name As String, leaving_Code As String, leaving_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Leaving_Delete(PortalConnect As String, leaving_ID As String)
#End Region
#Region "CMS_Location"
    Public MustOverride Function CMS_Location_Get(PortalConnect As String, location_ID As String) As IDataReader
    Public MustOverride Function CMS_Location_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Location_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Location_Add(PortalConnect As String, location_ID As String, location_Name As String, location_Code As String, location_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Location_Update(PortalConnect As String, location_ID As String, location_Name As String, location_Code As String, location_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Location_Delete(PortalConnect As String, location_ID As String)
#End Region
#Region "CMS_PreCareer"
    Public MustOverride Function CMS_PreCareer_Get(PortalConnect As String, preCareer_ID As String) As IDataReader
    Public MustOverride Function CMS_PreCareer_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_PreCareer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_PreCareer_Add(PortalConnect As String, preCareer_ID As String, preCareer_Name As String, preCareer_Code As String, preCareer_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_PreCareer_Update(PortalConnect As String, preCareer_ID As String, preCareer_Name As String, preCareer_Code As String, preCareer_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_PreCareer_Delete(PortalConnect As String, preCareer_ID As String)
#End Region
#Region "CMS_PreIndu"
    Public MustOverride Function CMS_PreIndu_Get(PortalConnect As String, preIndu_ID As String) As IDataReader
    Public MustOverride Function CMS_PreIndu_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_PreIndu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_PreIndu_Add(PortalConnect As String, preIndu_ID As String, preIndu_Name As String, preIndu_Code As String, preIndu_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_PreIndu_Update(PortalConnect As String, preIndu_ID As String, preIndu_Name As String, preIndu_Code As String, preIndu_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_PreIndu_Delete(PortalConnect As String, preIndu_ID As String)
#End Region
#Region "CMS_Recruitment"
    Public MustOverride Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Recruitment_Add(PortalConnect As String, recruitment_ID As String, recruitment_Name As String, recruitment_Code As String, recruitment_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Recruitment_Update(PortalConnect As String, recruitment_ID As String, recruitment_Name As String, recruitment_Code As String, recruitment_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
#End Region
#Region "CMS_Salary"
    Public MustOverride Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
    Public MustOverride Function CMS_Salary_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Salary_Add(PortalConnect As String, salary_ID As String, salary_Name As String, salary_Price As Double, salary_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Salary_Update(PortalConnect As String, salary_ID As String, salary_Name As String, salary_Price As Double, salary_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
#End Region
#Region "CMS_Satellite"

    Public MustOverride Function CMS_Satellite_Get_ByCode(PortalConnect As String, Satellite_Code As String) As IDataReader
    Public MustOverride Function CMS_Satellite_Get(PortalConnect As String, satellite_ID As String) As IDataReader
    Public MustOverride Function CMS_Satellite_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Satellite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Satellite_List_ToApp(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_Satellite_Add(PortalConnect As String, satellite_ID As String, satellite_Name As String, satellite_Code As String, satellite_Address As String, satellite_Tel As String, tinhTP As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Satellite_Update(PortalConnect As String, satellite_ID As String, satellite_Name As String, satellite_Code As String, satellite_Address As String, satellite_Tel As String, tinhTP As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Satellite_Delete(PortalConnect As String, satellite_ID As String)
#End Region
#Region "CMS_SetNumber"
    Public MustOverride Function CMS_SetNumber_Get(PortalConnect As String, setNumber_ID As String) As IDataReader
    Public MustOverride Function CMS_SetNumber_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SetNumber_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_SetNumber_Get_By_TinhTP_IsYear(PortalConnect As String, tinhTP As String, isYear As Integer) As IDataReader
    Public MustOverride Sub CMS_SetNumber_Update_Value(PortalConnect As String, tinhTP As String, isYear As Integer, pCMS_Number As Integer, gP_Number As Integer)
    Public MustOverride Sub CMS_SetNumber_Add(PortalConnect As String, setNumber_ID As String, tinhTP As String, isYear As Integer, pCMS_Code As String, pCMS_Number As Integer, pCMS_Count As Integer, gP_Code As String, gP_Number As Integer, gP_Count As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_SetNumber_Update(PortalConnect As String, setNumber_ID As String, tinhTP As String, isYear As Integer, pCMS_Code As String, pCMS_Number As Integer, pCMS_Count As Integer, gP_Code As String, gP_Number As Integer, gP_Count As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_SetNumber_Delete(PortalConnect As String, setNumber_ID As String)
#End Region
#Region "CMS_Signer"
    Public MustOverride Function CMS_Signer_Get(PortalConnect As String, signer_ID As String) As IDataReader
    Public MustOverride Function CMS_Signer_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Signer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Signer_Add(PortalConnect As String, signer_ID As String, signer_Name As String, position_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Signer_Update(PortalConnect As String, signer_ID As String, signer_Name As String, position_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Signer_Delete(PortalConnect As String, signer_ID As String)
#End Region
#Region "CMS_Skill"
    Public MustOverride Function CMS_Skill_Get(PortalConnect As String, skill_ID As String) As IDataReader
    Public MustOverride Function CMS_Skill_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Skill_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Skill_Add(PortalConnect As String, skill_ID As String, skill_Name As String, skill_Code As String, skill_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Skill_Update(PortalConnect As String, skill_ID As String, skill_Name As String, skill_Code As String, skill_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Skill_Delete(PortalConnect As String, skill_ID As String)
#End Region
#Region "CMS_Specialized"
    Public MustOverride Function CMS_Specialized_Get(PortalConnect As String, specialized_ID As String) As IDataReader
    Public MustOverride Function CMS_Specialized_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Specialized_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Specialized_Add(PortalConnect As String, specialized_ID As String, specialized_Name As String, specialized_Code As String, specialized_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Specialized_Update(PortalConnect As String, specialized_ID As String, specialized_Name As String, specialized_Code As String, specialized_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Specialized_Delete(PortalConnect As String, specialized_ID As String)
#End Region
#Region "CMS_Technical"
    Public MustOverride Function CMS_Technical_Get(PortalConnect As String, technical_ID As String) As IDataReader
    Public MustOverride Function CMS_Technical_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Technical_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Technical_Add(PortalConnect As String, technical_ID As String, technical_Name As String, technical_Code As String, technical_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Technical_Update(PortalConnect As String, technical_ID As String, technical_Name As String, technical_Code As String, technical_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Technical_Delete(PortalConnect As String, technical_ID As String)
#End Region
#Region "CMS_Technology"
    Public MustOverride Function CMS_Technology_Get(PortalConnect As String, technology_ID As String) As IDataReader
    Public MustOverride Function CMS_Technology_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Technology_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Technology_Add(PortalConnect As String, technology_ID As String, technology_Name As String, technology_Code As String, technology_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Technology_Update(PortalConnect As String, technology_ID As String, technology_Name As String, technology_Code As String, technology_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Technology_Delete(PortalConnect As String, technology_ID As String)
#End Region
#Region "CMS_Terminated"
    Public MustOverride Function CMS_Terminated_Get(PortalConnect As String, terminated_ID As String) As IDataReader
    Public MustOverride Function CMS_Terminated_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Terminated_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Terminated_Add(PortalConnect As String, terminated_ID As String, terminated_Name As String, terminated_Code As String, terminated_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Terminated_Update(PortalConnect As String, terminated_ID As String, terminated_Name As String, terminated_Code As String, terminated_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Terminated_Delete(PortalConnect As String, terminated_ID As String)
#End Region
#Region "CMS_Training"
    Public MustOverride Function CMS_Training_Get(PortalConnect As String, training_ID As String) As IDataReader
    Public MustOverride Function CMS_Training_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Training_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Training_Add(PortalConnect As String, training_ID As String, training_Name As String, training_Address As String, training_Boss As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Training_Update(PortalConnect As String, training_ID As String, training_Name As String, training_Address As String, training_Boss As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Training_Delete(PortalConnect As String, training_ID As String)
#End Region
#Region "CMS_Unit"
    Public MustOverride Function CMS_Unit_Get(PortalConnect As String, unit_ID As String) As IDataReader
    Public MustOverride Function CMS_Unit_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Unit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, PortalID As Integer) As IDataReader
    Public MustOverride Function CMS_Unit_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer, PortalID As Integer) As IDataReader
    Public MustOverride Function CMS_Unit_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String) As IDataReader
    Public MustOverride Function CMS_Unit_List_Parent_NULL(PortalConnect As String, PortalID As Integer) As IDataReader
    Public MustOverride Function CMS_Unit_Get_By_CMS_Unit(PortalConnect As String, unit_ID As String) As IDataReader
    Public MustOverride Sub CMS_Unit_Add(PortalConnect As String, unit_ID As String, parent_ID As String, unit_Name As String, unit_Des As String, unit_Logo As String, unit_Images As String, unit_Address As String, unit_Tel As String, unit_Email As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Unit_Update(PortalConnect As String, unit_ID As String, parent_ID As String, unit_Name As String, unit_Des As String, unit_Logo As String, unit_Images As String, unit_Address As String, unit_Tel As String, unit_Email As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Unit_Delete(PortalConnect As String, unit_ID As String)
#End Region
#Region "CMS_Wage"
    Public MustOverride Function CMS_Wage_Get(PortalConnect As String, wage_ID As String) As IDataReader
    Public MustOverride Function CMS_Wage_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Wage_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Wage_Add(PortalConnect As String, wage_ID As String, wage_Name As String, wage_Code As String, wage_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Wage_Update(PortalConnect As String, wage_ID As String, wage_Name As String, wage_Code As String, wage_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Wage_Delete(PortalConnect As String, wage_ID As String)
#End Region
#Region "CMS_Recipients"
	Public MustOverride Function CMS_Recipients_Get(PortalConnect As String, Recipients_ID As String) As IDataReader
    Public MustOverride Function CMS_Recipients_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Recipients_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Recipients_Add(PortalConnect As String, Recipients_ID As String, Recipients_Name As String, Recipients_Code As String, Recipients_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Recipients_Update(PortalConnect As String, Recipients_ID As String, Recipients_Name As String, Recipients_Code As String, Recipients_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
    Public MustOverride Sub CMS_Recipients_Delete(PortalConnect As String, Recipients_ID As String)
#End Region
#Region "EXE_ProSubsi"
    Public MustOverride Function EXE_ProSubsi_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
    Public MustOverride Function EXE_ProSubsi_Find(PortalConnect As String, noCode As String) As IDataReader
    Public MustOverride Function EXE_ProSubsi_Get(PortalConnect As String, proSubsi_ID As String) As IDataReader
    Public MustOverride Function EXE_ProSubsi_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub EXE_ProSubsi_Add(PortalConnect As String, obj As EXE_ProSubsiInfo)
    Public MustOverride Sub EXE_ProSubsi_Update(PortalConnect As String, obj As EXE_ProSubsiInfo)
    Public MustOverride Sub EXE_ProSubsi_Delete(PortalConnect As String, proSubsi_ID As String)
    Public MustOverride Sub EXE_ProSubsi_Update_TrangThai(PortalConnect As String, proSubsi_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
    Public MustOverride Sub EXE_ProSubsi_Update_PhieuHen(PortalConnect As String, proSubsi_ID As String, NgayTraKetQua As DateTime, QRCode As String)
#End Region
#Region "EXE_Apprentice"
    Public MustOverride Function EXE_Apprentice_Find(PortalConnect As String, noCode As String) As IDataReader
    Public MustOverride Function EXE_Apprentice_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
    Public MustOverride Function EXE_Apprentice_Get(PortalConnect As String, apprentice_ID As String) As IDataReader
    Public MustOverride Function EXE_Apprentice_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub EXE_Apprentice_Add(PortalConnect As String, obj As EXE_ApprenticeInfo)
    Public MustOverride Sub EXE_Apprentice_Update(PortalConnect As String, obj As EXE_ApprenticeInfo)
    Public MustOverride Sub EXE_Apprentice_Delete(PortalConnect As String, apprentice_ID As String)
    Public MustOverride Sub EXE_Apprentice_Update_TrangThai(PortalConnect As String, apprentice_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
#End Region
#Region "EXE_Advisory"
    Public MustOverride Function EXE_Advisory_Find(PortalConnect As String, noCode As String) As IDataReader
    Public MustOverride Function EXE_Advisory_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
    Public MustOverride Sub EXE_Advisory_Update_TrangThai(PortalConnect As String, advisory_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
    Public MustOverride Function EXE_Insurrance_Count_Add(PortalConnect As String, types As Integer) As Integer
    Public MustOverride Function EXE_Advisory_Get(PortalConnect As String, advisory_ID As String) As IDataReader
    Public MustOverride Function EXE_Advisory_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub EXE_Advisory_Add(PortalConnect As String, obj As EXE_AdvisoryInfo)
    Public MustOverride Sub EXE_Advisory_Update(PortalConnect As String, obj As EXE_AdvisoryInfo)
    Public MustOverride Sub EXE_Advisory_Delete(PortalConnect As String, advisory_ID As String)
#End Region
#Region "EXE_AdvisoryC"
    Public MustOverride Function EXE_AdvisoryC_Get(PortalConnect As String, advisoryC_ID As String) As IDataReader
    Public MustOverride Function EXE_AdvisoryC_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub EXE_AdvisoryC_Add(PortalConnect As String, obj As EXE_AdvisoryCInfo)
    Public MustOverride Sub EXE_AdvisoryC_Update(PortalConnect As String, obj As EXE_AdvisoryCInfo)
    Public MustOverride Function EXE_AdvisoryC_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As IDataReader
    Public MustOverride Sub EXE_AdvisoryC_Delete(PortalConnect As String, advisoryC_ID As String)
    Public MustOverride Sub EXE_AdvisoryC_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
#End Region
#Region "EXE_AdvisoryS"
    Public MustOverride Function EXE_AdvisoryS_Get(PortalConnect As String, advisoryS_ID As String) As IDataReader
    Public MustOverride Function EXE_AdvisoryS_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub EXE_AdvisoryS_Add(PortalConnect As String, obj As EXE_AdvisorySInfo)
    Public MustOverride Sub EXE_AdvisoryS_Update(PortalConnect As String, obj As EXE_AdvisorySInfo)
    Public MustOverride Function EXE_AdvisoryS_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As IDataReader
    Public MustOverride Sub EXE_AdvisoryS_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
    Public MustOverride Sub EXE_AdvisoryS_Delete(PortalConnect As String, advisoryS_ID As String)
#End Region
#Region "EXE_Notification"
    Public MustOverride Function EXE_Notification_Find(PortalConnect As String, noCode As String) As IDataReader
    Public MustOverride Sub EXE_Notification_Update_TrangThai(PortalConnect As String, notification_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
    Public MustOverride Function EXE_Notification_List_AppID(PortalConnect As String, currPage As Integer, recodperpage As Integer, Decide_ID As String) As IDataReader
    Public MustOverride Function EXE_Notification_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, qD_VeTinh As String, nam As Integer, thang As Integer, ngay As Integer, userName As String) As IDataReader
    Public MustOverride Function EXE_Notification_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function EXE_Notification_Get(PortalConnect As String, notification_ID As String) As IDataReader
    Public MustOverride Sub EXE_Notification_Add(PortalConnect As String, obj As EXE_NotificationInfo)
    Public MustOverride Sub EXE_Notification_Update(PortalConnect As String, obj As EXE_NotificationInfo)
    Public MustOverride Sub EXE_Notification_Delete(PortalConnect As String, notification_ID As String)
#End Region
#Region "EXE_NotificationD"
    Public MustOverride Function EXE_NotificationD_Get(PortalConnect As String, notificationD_ID As String) As IDataReader
    Public MustOverride Function EXE_NotificationD_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub EXE_NotificationD_Add(PortalConnect As String, obj As EXE_NotificationDInfo)
    Public MustOverride Sub EXE_NotificationD_Update(PortalConnect As String, obj As EXE_NotificationDInfo)
    Public MustOverride Function EXE_NotificationD_Get_By_EXE_Notification(PortalConnect As String, notification_ID As String) As IDataReader
    Public MustOverride Sub EXE_NotificationD_Delete(PortalConnect As String, notificationD_ID As String)
#End Region
#Region "EXE_NumberAuto"
    Public MustOverride Function EXE_NumberAuto_Check_Register(PortalConnect As String, dichVu As Integer, ngayNghiViec As DateTime, dienThoai As String, soBHXH As String) As IDataReader
    Public MustOverride Function EXE_NumberAuto_List_Search(PortalConnect As String, veTinh As String, ngayDangKy As DateTime, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer, userName As String) As IDataReader
    Public MustOverride Function EXE_NumberAuto_Get(PortalConnect As String, numberAuto_ID As String) As IDataReader
    Public MustOverride Function EXE_NumberAuto_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function EXE_NumberAuto_List_IsOnline(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function EXE_NumberAuto_Add(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
    Public MustOverride Function EXE_NumberAuto_Add_Lite(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
    Public MustOverride Function EXE_NumberAuto_Add_Offline(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
    Public MustOverride Sub EXE_NumberAuto_Delete(PortalConnect As String, numberAuto_ID As String)
    Public MustOverride Sub EXE_NumberAuto_Update_TinhTrang(PortalConnect As String, numberAuto_ID As String, tinhTrang As Integer)
    Public MustOverride Sub EXE_NumberAuto_Update_IsOnline(PortalConnect As String, numberAuto_ID As String, isOnline As Boolean)
    Public MustOverride Function EXE_NumberAuto_Get_ToApp(PortalConnect As String, dienThoai As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_DashBoard"
    Public MustOverride Function CMS_DashBoard_Admin(PortalConnect As String, portalId As Integer) As IDataReader
#End Region
#Region "CMS_SettingAuto"
    Public MustOverride Function CMS_SettingAuto_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_SettingAuto_Get_ByPortal(PortalConnect As String, portal_ID As Integer, Satellite_ID As String, FlagType As Int16) As IDataReader
    Public MustOverride Function CMS_SettingAuto_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SettingAuto_List_Service(PortalConnect As String, Satellite_ID As String) As IDataReader

    Public MustOverride Function CMS_SettingAuto_Add(PortalConnect As String, obj As CMS_SettingAutoInfo) As Integer
    Public MustOverride Sub CMS_SettingAuto_Update(PortalConnect As String, obj As CMS_SettingAutoInfo)
    Public MustOverride Sub CMS_SettingAuto_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SettingDoor"
    Public MustOverride Function CMS_SettingDoor_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_SettingDoor_GetBy_Portal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As IDataReader
    Public MustOverride Function CMS_SettingDoor_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SettingDoor_List_ByPortal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As IDataReader
    Public MustOverride Function CMS_SettingDoor_List_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, months As Integer, years As Integer) As IDataReader
    Public MustOverride Function CMS_SettingDoor_Select_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, soBHXH As String) As IDataReader
    Public MustOverride Function CMS_SettingDoor_Add(PortalConnect As String, obj As CMS_SettingDoorInfo) As Integer
    Public MustOverride Sub CMS_SettingDoor_Update(PortalConnect As String, obj As CMS_SettingDoorInfo)
    Public MustOverride Sub CMS_SettingDoor_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SettingTime"
    Public MustOverride Function CMS_SettingTime_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function CMS_SettingTime_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SettingTime_List_ByAutoID(PortalConnect As String, settingauto_id As Integer) As IDataReader

    Public MustOverride Sub CMS_SettingTime_Add(PortalConnect As String, obj As CMS_SettingTimeInfo)
    Public MustOverride Sub CMS_SettingTime_Update(PortalConnect As String, obj As CMS_SettingTimeInfo)
    Public MustOverride Sub CMS_SettingTime_Delete(PortalConnect As String, iD As String)
#End Region
#Region "CMS_DoorTime"
    Public MustOverride Function CMS_DoorTime_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_DoorTime_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_DoorTime_Add(PortalConnect As String, obj As CMS_DoorTimeInfo) As Integer
    Public MustOverride Sub CMS_DoorTime_Update(PortalConnect As String, obj As CMS_DoorTimeInfo)
    Public MustOverride Sub CMS_DoorTime_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Door"
    Public MustOverride Function CMS_Door_List_Search(PortalConnect As String, portalID As Integer, veTinh As String, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Function CMS_Door_Get(PortalConnect As String, doorID As Integer) As IDataReader
    Public MustOverride Function CMS_Door_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_Door_Add(PortalConnect As String, obj As CMS_DoorInfo) As Integer
    Public MustOverride Sub CMS_Door_Update(PortalConnect As String, obj As CMS_DoorInfo)
    Public MustOverride Sub CMS_Door_Delete(PortalConnect As String, doorID As Integer)
#End Region
#Region "EXE_FileAttch"
    Public MustOverride Function EXE_FileAttch_Get(PortalConnect As String, iD As String) As IDataReader
    Public MustOverride Function EXE_FileAttch_List(PortalConnect As String) As IDataReader
    Public MustOverride Function EXE_FileAttch_List_By_IdKey(PortalConnect As String, IdKey As String) As IDataReader
    Public MustOverride Sub EXE_FileAttch_Add(PortalConnect As String, obj As EXE_FileAttchInfo)
    Public MustOverride Sub EXE_FileAttch_Update(PortalConnect As String, obj As EXE_FileAttchInfo)
    Public MustOverride Sub EXE_FileAttch_Delete(PortalConnect As String, iD As String)
#End Region
#Region "REPORT"
    Public MustOverride Function EXE_NumberAuto_Report(PortalConnect As String, typeId As Integer) As IDataReader

#End Region

End Class
