Imports DotNetNuke.EPORTAL
Imports Microsoft.ApplicationBlocks.Data

Public Class SqlDataProvider
    Inherits DataProvider

#Region "CMS_Portal"
    Public Overrides Function CMS_Portal_Get(PortalConnect As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Portal_Get", portalID), IDataReader)
    End Function
    Public Overrides Function CMS_Portal_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Portal_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Portal_List_App(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Portal_List_App"), IDataReader)
    End Function
    Public Overrides Function CMS_Portal_List_App_Type(PortalConnect As String, type As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Portal_List_App_Type", type), IDataReader)
    End Function
    Public Overrides Function CMS_Portal_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Portal_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Portal_Add(PortalConnect As String, portalName As String, logo As String, tinhTP As String, quanHuyen As String, xaPhuong As String, duongPho As String, nguoiDaiDien As String, position_ID As String, website As String, email As String, mobile As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Portal_Add", portalName, logo, tinhTP, quanHuyen, xaPhuong, duongPho, flReg.GetNull(nguoiDaiDien), flReg.GetNull(position_ID), website, email, flReg.GetNull(mobile), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive), Integer)
    End Function
    Public Overrides Sub CMS_Portal_Update(PortalConnect As String, portalID As Integer, portalName As String, logo As String, tinhTP As String, quanHuyen As String, xaPhuong As String, duongPho As String, nguoiDaiDien As String, position_ID As String, website As String, email As String, mobile As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Portal_Update", portalID, portalName, logo, tinhTP, quanHuyen, xaPhuong, duongPho, flReg.GetNull(nguoiDaiDien), flReg.GetNull(position_ID), website, email, flReg.GetNull(mobile), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive)
    End Sub
    Public Overrides Sub CMS_Portal_Delete(PortalConnect As String, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Portal_Delete", portalID)
    End Sub
#End Region
#Region "CMS_Banking"
    Public Overrides Function CMS_Banking_Get(PortalConnect As String, banking_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Banking_Get", banking_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Banking_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Banking_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Banking_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Banking_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Banking_Add(PortalConnect As String, banking_ID As String, banking_Name As String, banking_Code As String, banking_Logo As String, banking_Website As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Banking_Add", banking_ID, banking_Name, banking_Code, banking_Logo, banking_Website, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Banking_Update(PortalConnect As String, banking_ID As String, banking_Name As String, banking_Code As String, banking_Logo As String, banking_Website As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Banking_Update", banking_ID, banking_Name, banking_Code, banking_Logo, banking_Website, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Banking_Delete(PortalConnect As String, banking_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Banking_Delete", banking_ID)
    End Sub
#End Region
#Region "CMS_Cannot"
    Public Overrides Function CMS_Cannot_Get(PortalConnect As String, cannot_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Cannot_Get", cannot_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Cannot_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Cannot_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Cannot_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Cannot_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Cannot_Add(PortalConnect As String, cannot_ID As String, cannot_Name As String, cannot_Code As String, cannot_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Cannot_Add", cannot_ID, cannot_Name, cannot_Code, cannot_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Cannot_Update(PortalConnect As String, cannot_ID As String, cannot_Name As String, cannot_Code As String, cannot_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Cannot_Update", cannot_ID, cannot_Name, cannot_Code, cannot_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Cannot_Delete(PortalConnect As String, cannot_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Cannot_Delete", cannot_ID)
    End Sub
#End Region
#Region "CMS_Career"
    Public Overrides Function CMS_Career_Get(PortalConnect As String, career_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Career_Get", career_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Career_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Career_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Career_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Career_Add(PortalConnect As String, career_ID As String, career_Name As String, career_Code As String, career_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Career_Add", career_ID, career_Name, career_Code, career_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Career_Update(PortalConnect As String, career_ID As String, career_Name As String, career_Code As String, career_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Career_Update", career_ID, career_Name, career_Code, career_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Career_Delete", career_ID)
    End Sub
#End Region
#Region "CMS_CauseOf"
    Public Overrides Function CMS_CauseOf_Get(PortalConnect As String, causeOf_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_CauseOf_Get", causeOf_ID), IDataReader)
    End Function
    Public Overrides Function CMS_CauseOf_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_CauseOf_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_CauseOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_CauseOf_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_CauseOf_Add(PortalConnect As String, causeOf_ID As String, causeOf_Name As String, causeOf_Code As String, causeOf_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_CauseOf_Add", causeOf_ID, causeOf_Name, causeOf_Code, causeOf_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_CauseOf_Update(PortalConnect As String, causeOf_ID As String, causeOf_Name As String, causeOf_Code As String, causeOf_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_CauseOf_Update", causeOf_ID, causeOf_Name, causeOf_Code, causeOf_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_CauseOf_Delete(PortalConnect As String, causeOf_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_CauseOf_Delete", causeOf_ID)
    End Sub
#End Region
#Region "CMS_ComType"
    Public Overrides Function CMS_ComType_Get(PortalConnect As String, comType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ComType_Get", comType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ComType_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ComType_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ComType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ComType_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_ComType_Add(PortalConnect As String, comType_ID As String, comtype_Name As String, comtype_Code As String, comtype_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_ComType_Add", comType_ID, comtype_Name, comtype_Code, comtype_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_ComType_Update(PortalConnect As String, comType_ID As String, comtype_Name As String, comtype_Code As String, comtype_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_ComType_Update", comType_ID, comtype_Name, comtype_Code, comtype_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_ComType_Delete(PortalConnect As String, comType_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_ComType_Delete", comType_ID)
    End Sub
#End Region
#Region "CMS_ContractType"
    Public Overrides Function CMS_ContractType_Get(PortalConnect As String, contractType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ContractType_Get", contractType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ContractType_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ContractType_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ContractType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_ContractType_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_ContractType_Add(PortalConnect As String, contractType_ID As String, contractType_Name As String, contractType_Code As String, contractType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_ContractType_Add", contractType_ID, contractType_Name, contractType_Code, contractType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_ContractType_Update(PortalConnect As String, contractType_ID As String, contractType_Name As String, contractType_Code As String, contractType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_ContractType_Update", contractType_ID, contractType_Name, contractType_Code, contractType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_ContractType_Delete(PortalConnect As String, contractType_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_ContractType_Delete", contractType_ID)
    End Sub
#End Region
#Region "CMS_DayOff"
    Public Overrides Function CMS_DayOff_Get(PortalConnect As String, dayOff_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DayOff_Get", dayOff_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DayOff_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DayOff_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DayOff_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DayOff_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_DayOff_Get_OffTime(PortalConnect As String, Dates As DateTime) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_DayOff_Get_OffTime", Dates), Integer)
    End Function
    Public Overrides Function CMS_DayOff_Get_Day_Month(PortalConnect As String, isDay As Integer, isMonth As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_DayOff_Get_Day_Month", isDay, isMonth), Integer)
    End Function
    Public Overrides Sub CMS_DayOff_Add(PortalConnect As String, dayOff_ID As String, dayOff_Name As String, isDay As Integer, isMonth As Integer, isYear As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_DayOff_Add", dayOff_ID, dayOff_Name, isDay, isMonth, isYear, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_DayOff_Update(PortalConnect As String, dayOff_ID As String, dayOff_Name As String, isDay As Integer, isMonth As Integer, isYear As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_DayOff_Update", dayOff_ID, dayOff_Name, isDay, isMonth, isYear, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_DayOff_Delete(PortalConnect As String, dayOff_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_DayOff_Delete", dayOff_ID)
    End Sub
#End Region
#Region "CMS_DecidedType"
    Public Overrides Function CMS_DecidedType_Get(PortalConnect As String, decidedType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DecidedType_Get", decidedType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DecidedType_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DecidedType_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DecidedType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_DecidedType_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_DecidedType_Add(PortalConnect As String, decidedType_ID As String, decidedType_Name As String, decidedType_Code As String, decidedType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_DecidedType_Add", decidedType_ID, decidedType_Name, decidedType_Code, decidedType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_DecidedType_Update(PortalConnect As String, decidedType_ID As String, decidedType_Name As String, decidedType_Code As String, decidedType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_DecidedType_Update", decidedType_ID, decidedType_Name, decidedType_Code, decidedType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_DecidedType_Delete(PortalConnect As String, decidedType_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_DecidedType_Delete", decidedType_ID)
    End Sub
#End Region
#Region "CMS_Field"
    Public Overrides Function CMS_Field_Get(PortalConnect As String, field_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Field_Get", field_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Field_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Field_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Field_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Field_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Field_Add(PortalConnect As String, field_ID As String, field_Name As String, field_Code As String, field_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Field_Add", field_ID, field_Name, field_Code, field_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Field_Update(PortalConnect As String, field_ID As String, field_Name As String, field_Code As String, field_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Field_Update", field_ID, field_Name, field_Code, field_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Field_Delete(PortalConnect As String, field_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Field_Delete", field_ID)
    End Sub
#End Region
#Region "CMS_FileAttch"
    Public Overrides Function CMS_FileAttch_Get(PortalConnect As String, fileAttch_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_FileAttch_Get", fileAttch_ID), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttch_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_FileAttch_List"), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_FileAttch_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_FileAttch_Add(PortalConnect As String, fileAttch_ID As String, document_ID As String, fileAttch_Name As String, fileAttch_Attch As String, isOrder As Integer, createdDate As DateTime, createdUser As String)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_FileAttch_Add", fileAttch_ID, document_ID, fileAttch_Name, fileAttch_Attch, isOrder, createdDate, createdUser)
    End Sub
    Public Overrides Sub CMS_FileAttch_Update(PortalConnect As String, fileAttch_ID As String, document_ID As String, fileAttch_Name As String, fileAttch_Attch As String, isOrder As Integer, createdDate As DateTime, createdUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_FileAttch_Update", fileAttch_ID, document_ID, fileAttch_Name, fileAttch_Attch, isOrder, createdDate, createdUser)
    End Sub
    Public Overrides Sub CMS_FileAttch_Delete(PortalConnect As String, fileAttch_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_FileAttch_Delete", fileAttch_ID)
    End Sub
#End Region
#Region "CMS_LaborType"
    Public Overrides Function CMS_LaborType_Get(PortalConnect As String, laborType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_LaborType_Get", laborType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_LaborType_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_LaborType_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_LaborType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_LaborType_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_LaborType_Add(PortalConnect As String, laborType_ID As String, laborType_Name As String, laborType_Code As String, laborType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_LaborType_Add", laborType_ID, laborType_Name, laborType_Code, laborType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_LaborType_Update(PortalConnect As String, laborType_ID As String, laborType_Name As String, laborType_Code As String, laborType_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_LaborType_Update", laborType_ID, laborType_Name, laborType_Code, laborType_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_LaborType_Delete(PortalConnect As String, laborType_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_LaborType_Delete", laborType_ID)
    End Sub
#End Region
#Region "CMS_Leaving"
    Public Overrides Function CMS_Leaving_Get(PortalConnect As String, leaving_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Leaving_Get", leaving_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Leaving_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Leaving_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Leaving_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Leaving_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Leaving_Add(PortalConnect As String, leaving_ID As String, leaving_Name As String, leaving_Code As String, leaving_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Leaving_Add", leaving_ID, leaving_Name, leaving_Code, leaving_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Leaving_Update(PortalConnect As String, leaving_ID As String, leaving_Name As String, leaving_Code As String, leaving_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Leaving_Update", leaving_ID, leaving_Name, leaving_Code, leaving_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Leaving_Delete(PortalConnect As String, leaving_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Leaving_Delete", leaving_ID)
    End Sub
#End Region
#Region "CMS_Location"
    Public Overrides Function CMS_Location_Get(PortalConnect As String, location_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Location_Get", location_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Location_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Location_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Location_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Location_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Location_Add(PortalConnect As String, location_ID As String, location_Name As String, location_Code As String, location_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Location_Add", location_ID, location_Name, location_Code, location_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Location_Update(PortalConnect As String, location_ID As String, location_Name As String, location_Code As String, location_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Location_Update", location_ID, location_Name, location_Code, location_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Location_Delete(PortalConnect As String, location_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Location_Delete", location_ID)
    End Sub
#End Region
#Region "CMS_PreCareer"
    Public Overrides Function CMS_PreCareer_Get(PortalConnect As String, preCareer_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreCareer_Get", preCareer_ID), IDataReader)
    End Function
    Public Overrides Function CMS_PreCareer_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreCareer_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_PreCareer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreCareer_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_PreCareer_Add(PortalConnect As String, preCareer_ID As String, preCareer_Name As String, preCareer_Code As String, preCareer_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_PreCareer_Add", preCareer_ID, preCareer_Name, preCareer_Code, preCareer_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_PreCareer_Update(PortalConnect As String, preCareer_ID As String, preCareer_Name As String, preCareer_Code As String, preCareer_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_PreCareer_Update", preCareer_ID, preCareer_Name, preCareer_Code, preCareer_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_PreCareer_Delete(PortalConnect As String, preCareer_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_PreCareer_Delete", preCareer_ID)
    End Sub
#End Region
#Region "CMS_PreIndu"
    Public Overrides Function CMS_PreIndu_Get(PortalConnect As String, preIndu_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreIndu_Get", preIndu_ID), IDataReader)
    End Function
    Public Overrides Function CMS_PreIndu_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreIndu_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_PreIndu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_PreIndu_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_PreIndu_Add(PortalConnect As String, preIndu_ID As String, preIndu_Name As String, preIndu_Code As String, preIndu_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_PreIndu_Add", preIndu_ID, preIndu_Name, preIndu_Code, preIndu_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_PreIndu_Update(PortalConnect As String, preIndu_ID As String, preIndu_Name As String, preIndu_Code As String, preIndu_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_PreIndu_Update", preIndu_ID, preIndu_Name, preIndu_Code, preIndu_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_PreIndu_Delete(PortalConnect As String, preIndu_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_PreIndu_Delete", preIndu_ID)
    End Sub
#End Region
#Region "CMS_Recruitment"
    Public Overrides Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Recruitment_Get", recruitment_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Recruitment_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Recruitment_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Recruitment_Add(PortalConnect As String, recruitment_ID As String, recruitment_Name As String, recruitment_Code As String, recruitment_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Recruitment_Add", recruitment_ID, recruitment_Name, recruitment_Code, recruitment_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Recruitment_Update(PortalConnect As String, recruitment_ID As String, recruitment_Name As String, recruitment_Code As String, recruitment_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Recruitment_Update", recruitment_ID, recruitment_Name, recruitment_Code, recruitment_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Recruitment_Delete", recruitment_ID)
    End Sub
#End Region
#Region "CMS_Salary"
    Public Overrides Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Salary_Get", salary_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Salary_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Salary_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Salary_Add(PortalConnect As String, salary_ID As String, salary_Name As String, salary_Price As Double, salary_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Salary_Add", salary_ID, salary_Name, salary_Price, salary_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Salary_Update(PortalConnect As String, salary_ID As String, salary_Name As String, salary_Price As Double, salary_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Salary_Update", salary_ID, salary_Name, salary_Price, salary_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Salary_Delete", salary_ID)
    End Sub
#End Region
#Region "CMS_SetNumber"
    Public Overrides Function CMS_SetNumber_Get(PortalConnect As String, setNumber_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_SetNumber_Get", setNumber_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SetNumber_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_SetNumber_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SetNumber_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_SetNumber_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_SetNumber_Update_Value(PortalConnect As String, tinhTP As String, isYear As Integer, pCMS_Number As Integer, gP_Number As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_SetNumber_Update_Value", tinhTP, isYear, pCMS_Number, gP_Number)
    End Sub
    Public Overrides Function CMS_SetNumber_Get_By_TinhTP_IsYear(PortalConnect As String, tinhTP As String, isYear As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_SetNumber_Get_By_TinhTP_IsYear", tinhTP, isYear), IDataReader)
    End Function
    Public Overrides Sub CMS_SetNumber_Add(PortalConnect As String, setNumber_ID As String, tinhTP As String, isYear As Integer, pCMS_Code As String, pCMS_Number As Integer, pCMS_Count As Integer, gP_Code As String, gP_Number As Integer, gP_Count As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_SetNumber_Add", setNumber_ID, tinhTP, isYear, pCMS_Code, pCMS_Number, pCMS_Count, flReg.GetNull(gP_Code), gP_Number, gP_Count, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser)
    End Sub
    Public Overrides Sub CMS_SetNumber_Update(PortalConnect As String, setNumber_ID As String, tinhTP As String, isYear As Integer, pCMS_Code As String, pCMS_Number As Integer, pCMS_Count As Integer, gP_Code As String, gP_Number As Integer, gP_Count As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_SetNumber_Update", setNumber_ID, tinhTP, isYear, pCMS_Code, pCMS_Number, pCMS_Count, flReg.GetNull(gP_Code), gP_Number, gP_Count, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser)
    End Sub
    Public Overrides Sub CMS_SetNumber_Delete(PortalConnect As String, setNumber_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_SetNumber_Delete", setNumber_ID)
    End Sub
#End Region
#Region "CMS_Skill"
    Public Overrides Function CMS_Skill_Get(PortalConnect As String, skill_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Skill_Get", skill_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Skill_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Skill_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Skill_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Skill_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Skill_Add(PortalConnect As String, skill_ID As String, skill_Name As String, skill_Code As String, skill_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Skill_Add", skill_ID, skill_Name, skill_Code, skill_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Skill_Update(PortalConnect As String, skill_ID As String, skill_Name As String, skill_Code As String, skill_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Skill_Update", skill_ID, skill_Name, skill_Code, skill_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Skill_Delete(PortalConnect As String, skill_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Skill_Delete", skill_ID)
    End Sub
#End Region
#Region "CMS_Specialized"
    Public Overrides Function CMS_Specialized_Get(PortalConnect As String, specialized_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Specialized_Get", specialized_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Specialized_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Specialized_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Specialized_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Specialized_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Specialized_Add(PortalConnect As String, specialized_ID As String, specialized_Name As String, specialized_Code As String, specialized_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Specialized_Add", specialized_ID, specialized_Name, specialized_Code, specialized_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Specialized_Update(PortalConnect As String, specialized_ID As String, specialized_Name As String, specialized_Code As String, specialized_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Specialized_Update", specialized_ID, specialized_Name, specialized_Code, specialized_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Specialized_Delete(PortalConnect As String, specialized_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Specialized_Delete", specialized_ID)
    End Sub
#End Region
#Region "CMS_Technical"
    Public Overrides Function CMS_Technical_Get(PortalConnect As String, technical_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technical_Get", technical_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Technical_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technical_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Technical_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technical_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Technical_Add(PortalConnect As String, technical_ID As String, technical_Name As String, technical_Code As String, technical_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Technical_Add", technical_ID, technical_Name, technical_Code, technical_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Technical_Update(PortalConnect As String, technical_ID As String, technical_Name As String, technical_Code As String, technical_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Technical_Update", technical_ID, technical_Name, technical_Code, technical_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Technical_Delete(PortalConnect As String, technical_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Technical_Delete", technical_ID)
    End Sub
#End Region
#Region "CMS_Technology"
    Public Overrides Function CMS_Technology_Get(PortalConnect As String, technology_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technology_Get", technology_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Technology_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technology_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Technology_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Technology_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Technology_Add(PortalConnect As String, technology_ID As String, technology_Name As String, technology_Code As String, technology_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Technology_Add", technology_ID, technology_Name, technology_Code, technology_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Technology_Update(PortalConnect As String, technology_ID As String, technology_Name As String, technology_Code As String, technology_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Technology_Update", technology_ID, technology_Name, technology_Code, technology_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Technology_Delete(PortalConnect As String, technology_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Technology_Delete", technology_ID)
    End Sub
#End Region
#Region "CMS_Terminated"
    Public Overrides Function CMS_Terminated_Get(PortalConnect As String, terminated_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Terminated_Get", terminated_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Terminated_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Terminated_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Terminated_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Terminated_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Terminated_Add(PortalConnect As String, terminated_ID As String, terminated_Name As String, terminated_Code As String, terminated_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Terminated_Add", terminated_ID, terminated_Name, terminated_Code, terminated_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Terminated_Update(PortalConnect As String, terminated_ID As String, terminated_Name As String, terminated_Code As String, terminated_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Terminated_Update", terminated_ID, terminated_Name, terminated_Code, terminated_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Terminated_Delete(PortalConnect As String, terminated_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Terminated_Delete", terminated_ID)
    End Sub
#End Region
#Region "CMS_Wage"
    Public Overrides Function CMS_Wage_Get(PortalConnect As String, wage_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Wage_Get", wage_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Wage_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Wage_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Wage_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Wage_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Wage_Add(PortalConnect As String, wage_ID As String, wage_Name As String, wage_Code As String, wage_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Wage_Add", wage_ID, wage_Name, wage_Code, wage_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Wage_Update(PortalConnect As String, wage_ID As String, wage_Name As String, wage_Code As String, wage_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Wage_Update", wage_ID, wage_Name, wage_Code, wage_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Wage_Delete(PortalConnect As String, wage_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Wage_Delete", wage_ID)
    End Sub
#End Region

    'DB_TrungTam
#Region "CMS_Branch"
    Public Overrides Function CMS_Branch_Get(PortalConnect As String, branch_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Branch_Get", branch_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Branch_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Branch_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Branch_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Banking_ID As String, PortalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Branch_List_Search", search, isOrder, currPage, recodperpage, Banking_ID, PortalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Branch_Add(PortalConnect As String, branch_ID As String, branch_Name As String, branch_Code As String, branch_Tel As String, branch_Address As String, tinhTP As String, banking_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Branch_Add", branch_ID, branch_Name, branch_Code, branch_Tel, branch_Address, tinhTP, banking_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Branch_Update(PortalConnect As String, branch_ID As String, branch_Name As String, branch_Code As String, branch_Tel As String, branch_Address As String, tinhTP As String, banking_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Branch_Update", branch_ID, branch_Name, branch_Code, branch_Tel, branch_Address, tinhTP, banking_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Function CMS_Branch_Get_By_CMS_Banking(PortalConnect As String, banking_ID As String, PortalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Branch_Get_By_CMS_Banking", banking_ID, PortalId), IDataReader)
    End Function
    Public Overrides Sub CMS_Branch_Delete(PortalConnect As String, branch_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Branch_Delete", branch_ID)
    End Sub
#End Region
#Region "CMS_Company"
    Public Overrides Function CMS_Company_Get(PortalConnect As String, company_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Company_Get", company_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Company_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Company_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Company_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Company_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Company_Add(PortalConnect As String, company_ID As String, company_Name As String, company_Code As String, company_Logo As String, company_Tel As String, company_Website As String, comType_ID As String, tinhTP As String, quanHuyen As String, xaPhuong As String, soNha As String, career_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Company_Add", company_ID, company_Name, company_Code, company_Logo, company_Tel, company_Website, comType_ID, tinhTP, quanHuyen, xaPhuong, soNha, career_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Company_Update(PortalConnect As String, company_ID As String, company_Name As String, company_Code As String, company_Logo As String, company_Tel As String, company_Website As String, comType_ID As String, tinhTP As String, quanHuyen As String, xaPhuong As String, soNha As String, career_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Company_Update", company_ID, company_Name, company_Code, company_Logo, company_Tel, company_Website, comType_ID, tinhTP, quanHuyen, xaPhuong, soNha, career_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Function CMS_Company_Get_By_CMS_ComType(PortalConnect As String, comType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Company_Get_By_CMS_ComType", comType_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Company_Delete(PortalConnect As String, company_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Company_Delete", company_ID)
    End Sub
#End Region
#Region "CMS_Course"
    Public Overrides Function CMS_Course_Get(PortalConnect As String, course_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Course_Get", course_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Course_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Course_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Course_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Training_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Course_List_Search", search, isOrder, currPage, recodperpage, Training_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Course_Gey_By_CMS_Training(PortalConnect As String, portalId As Integer, Training_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Course_Gey_By_CMS_Training", portalId, Training_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Course_Add(PortalConnect As String, course_ID As String, training_ID As String, course_Name As String, tuition As Double, isMonth As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Course_Add", course_ID, training_ID, course_Name, tuition, isMonth, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Course_Update(PortalConnect As String, course_ID As String, training_ID As String, course_Name As String, tuition As Double, isMonth As Integer, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Course_Update", course_ID, training_ID, course_Name, tuition, isMonth, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Course_Delete(PortalConnect As String, course_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Course_Delete", course_ID)
    End Sub
#End Region
#Region "CMS_Insurance"
    Public Overrides Function CMS_Insurance_Get(PortalConnect As String, insurance_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Insurance_Get", insurance_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Insurance_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Insurance_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Insurance_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Insurance_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_Insurance_Add(PortalConnect As String, insurance_ID As String, insurance_Code As String, insurance_Name As String, insurance_Address As String, insurance_Des As String, quanHuyen As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Insurance_Add", insurance_ID, insurance_Code, insurance_Name, insurance_Address, insurance_Des, quanHuyen, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Insurance_Update(PortalConnect As String, insurance_ID As String, insurance_Code As String, insurance_Name As String, insurance_Address As String, insurance_Des As String, quanHuyen As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Insurance_Update", insurance_ID, insurance_Code, insurance_Name, insurance_Address, insurance_Des, quanHuyen, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Insurance_Delete(PortalConnect As String, insurance_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Insurance_Delete", insurance_ID)
    End Sub
#End Region
#Region "CMS_Satellite"
    Public Overrides Function CMS_Satellite_Get_ByCode(PortalConnect As String, Satellite_Code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Satellite_Get_ByCode", PortalConnect, Satellite_Code), IDataReader)
    End Function
    Public Overrides Function CMS_Satellite_Get(PortalConnect As String, satellite_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Satellite_Get", satellite_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Satellite_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Satellite_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Satellite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Satellite_List_Search", PortalConnect, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Satellite_List_ToApp(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Satellite_List_ToApp", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_Satellite_Add(PortalConnect As String, satellite_ID As String, satellite_Name As String, satellite_Code As String, satellite_Address As String, satellite_Tel As String, tinhTP As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Satellite_Add", satellite_ID, satellite_Name, satellite_Code, satellite_Address, satellite_Tel, tinhTP, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Satellite_Update(PortalConnect As String, satellite_ID As String, satellite_Name As String, satellite_Code As String, satellite_Address As String, satellite_Tel As String, tinhTP As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Satellite_Update", satellite_ID, satellite_Name, satellite_Code, satellite_Address, satellite_Tel, tinhTP, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Satellite_Delete(PortalConnect As String, satellite_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Satellite_Delete", satellite_ID)
    End Sub
#End Region
#Region "CMS_Signer"
    Public Overrides Function CMS_Signer_Get(PortalConnect As String, signer_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Signer_Get", signer_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Signer_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Signer_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Signer_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Signer_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Signer_Add(PortalConnect As String, signer_ID As String, signer_Name As String, position_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Signer_Add", signer_ID, signer_Name, position_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Signer_Update(PortalConnect As String, signer_ID As String, signer_Name As String, position_ID As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Signer_Update", signer_ID, signer_Name, position_ID, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Signer_Delete(PortalConnect As String, signer_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Signer_Delete", signer_ID)
    End Sub
#End Region
#Region "CMS_Training"
    Public Overrides Function CMS_Training_Get(PortalConnect As String, training_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Training_Get", training_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Training_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Training_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Training_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Training_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Training_Add(PortalConnect As String, training_ID As String, training_Name As String, training_Address As String, training_Boss As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Training_Add", training_ID, training_Name, training_Address, training_Boss, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Training_Update(PortalConnect As String, training_ID As String, training_Name As String, training_Address As String, training_Boss As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Training_Update", training_ID, training_Name, training_Address, training_Boss, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Training_Delete(PortalConnect As String, training_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Training_Delete", training_ID)
    End Sub
#End Region
#Region "CMS_Unit"
    Public Overrides Function CMS_Unit_Get(PortalConnect As String, unit_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_Get", unit_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_List_Search", search, isOrder, currPage, recodperpage, PortalID), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_Parent_Search_Null", search, isOrder, PortalID), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_Parent_Search_ID(PortalConnect As String, search As String, isOrder As Integer, Parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_Parent_Search_ID", search, isOrder, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_List_Parent_NULL(PortalConnect As String, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_List_Parent_NULL", PortalID), IDataReader)
    End Function
    Public Overrides Function CMS_Unit_Get_By_CMS_Unit(PortalConnect As String, unit_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Unit_Get_By_CMS_Unit", unit_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Unit_Add(PortalConnect As String, unit_ID As String, parent_ID As String, unit_Name As String, unit_Des As String, unit_Logo As String, unit_Images As String, unit_Address As String, unit_Tel As String, unit_Email As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Unit_Add", unit_ID, flReg.GetNull(parent_ID), unit_Name, unit_Des, unit_Logo, unit_Images, unit_Address, unit_Tel, unit_Email, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Unit_Update(PortalConnect As String, unit_ID As String, parent_ID As String, unit_Name As String, unit_Des As String, unit_Logo As String, unit_Images As String, unit_Address As String, unit_Tel As String, unit_Email As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Unit_Update", unit_ID, flReg.GetNull(parent_ID), unit_Name, unit_Des, unit_Logo, unit_Images, unit_Address, unit_Tel, unit_Email, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Unit_Delete(PortalConnect As String, unit_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Unit_Delete", unit_ID)
    End Sub
#End Region
#Region "CMS_Recipients"
    Public Overrides Function CMS_Recipients_Get(PortalConnect As String, Recipients_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Recipients_Get", Recipients_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recipients_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Recipients_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Recipients_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_Recipients_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Recipients_Add(PortalConnect As String, Recipients_ID As String, Recipients_Name As String, Recipients_Code As String, Recipients_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_Recipients_Add", Recipients_ID, Recipients_Name, Recipients_Code, Recipients_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Recipients_Update(PortalConnect As String, Recipients_ID As String, Recipients_Name As String, Recipients_Code As String, Recipients_Des As String, isOrder As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Recipients_Update", Recipients_ID, Recipients_Name, Recipients_Code, Recipients_Des, isOrder, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, portalId)
    End Sub
    Public Overrides Sub CMS_Recipients_Delete(PortalConnect As String, Recipients_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_Recipients_Delete", Recipients_ID)
    End Sub
#End Region
#Region "EXE_ProSubsi"
    Public Overrides Sub EXE_ProSubsi_Update_TrangThai(PortalConnect As String, proSubsi_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_ProSubsi_Update_TrangThai", proSubsi_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Overrides Sub EXE_ProSubsi_Update_PhieuHen(PortalConnect As String, proSubsi_ID As String, NgayTraKetQua As DateTime, QRCode As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_ProSubsi_Update_PhieuHen", proSubsi_ID, NgayTraKetQua, QRCode)
    End Sub
    Public Overrides Function EXE_ProSubsi_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_ProSubsi_List_Search", Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), IDataReader)
    End Function
    Public Overrides Function EXE_ProSubsi_Get(PortalConnect As String, proSubsi_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_ProSubsi_Get", proSubsi_ID), IDataReader)
    End Function
    Public Overrides Function EXE_ProSubsi_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_ProSubsi_List", portalId), IDataReader)
    End Function
    Public Overrides Sub EXE_ProSubsi_Add(PortalConnect As String, obj As EXE_ProSubsiInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_ProSubsi_Add", obj.ProSubsi_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.SoTaiKhoan, obj.NganHang, obj.ChiNhanhNH, obj.TT_TinhTP, obj.TT_QuanHuyen, obj.TT_XaPhuong, obj.TT_DuongPho, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.NganhDT, obj.TrinhDo, flReg.GetNull(obj.NgayNghiViec), obj.ThangDong, obj.LoaiHD, obj.CongTy, obj.SoDKKD, obj.CT_TinhTP, obj.CT_QuanHuyen, obj.CT_XaPhuong, obj.CT_DuongPho, obj.NoiNhanTCTN, obj.NoiDKKCB, obj.NguyenNhanNV, obj.NgheTruocNghi, obj.NganhTruocNghi, obj.TenTepDK, obj.DuongDanDK, obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser), obj.IsType)
    End Sub
    Public Overrides Sub EXE_ProSubsi_Update(PortalConnect As String, obj As EXE_ProSubsiInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_ProSubsi_Update", obj.ProSubsi_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.SoTaiKhoan, obj.NganHang, obj.ChiNhanhNH, obj.TT_TinhTP, obj.TT_QuanHuyen, obj.TT_XaPhuong, obj.TT_DuongPho, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.NganhDT, obj.TrinhDo, flReg.GetNull(obj.NgayNghiViec), obj.ThangDong, obj.LoaiHD, obj.CongTy, obj.SoDKKD, obj.CT_TinhTP, obj.CT_QuanHuyen, obj.CT_XaPhuong, obj.CT_DuongPho, obj.NoiNhanTCTN, obj.NoiDKKCB, obj.NguyenNhanNV, obj.NgheTruocNghi, obj.NganhTruocNghi, obj.TenTepDK, obj.DuongDanDK, obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser), obj.IsType)
    End Sub
    Public Overrides Sub EXE_ProSubsi_Delete(PortalConnect As String, proSubsi_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_ProSubsi_Delete", proSubsi_ID)
    End Sub
    Public Overrides Function EXE_ProSubsi_Find(PortalConnect As String, noCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_ProSubsi_Find", noCode), IDataReader)
    End Function
#End Region
#Region "EXE_Apprentice"
    Public Overrides Function EXE_Apprentice_Find(PortalConnect As String, noCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Apprentice_Find", noCode), IDataReader)
    End Function
    Public Overrides Sub EXE_Apprentice_Update_TrangThai(PortalConnect As String, apprentice_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Apprentice_Update_TrangThai", apprentice_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Overrides Function EXE_Apprentice_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Apprentice_List_Search", Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), IDataReader)
    End Function
    Public Overrides Function EXE_Insurrance_Count_Add(PortalConnect As String, types As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_Insurrance_Count_Add", types), Integer)
    End Function
    Public Overrides Function EXE_Apprentice_Get(PortalConnect As String, apprentice_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Apprentice_Get", apprentice_ID), IDataReader)
    End Function
    Public Overrides Function EXE_Apprentice_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Apprentice_List", portalId), IDataReader)
    End Function
    Public Overrides Sub EXE_Apprentice_Add(PortalConnect As String, obj As EXE_ApprenticeInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_Apprentice_Add", obj.Apprentice_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.ThangDong, obj.ThangHuong, obj.QDH_So, flReg.GetNull(obj.QDH_TuNgay), flReg.GetNull(obj.QDH_DenNgay), obj.CoSoDT, obj.KhoaDT, obj.ThoiGianDT, obj.HocPhi, obj.TenTepDK, obj.DuongDanDK, obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub EXE_Apprentice_Update(PortalConnect As String, obj As EXE_ApprenticeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Apprentice_Update", obj.Apprentice_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.ThangDong, obj.ThangHuong, obj.QDH_So, flReg.GetNull(obj.QDH_TuNgay), flReg.GetNull(obj.QDH_DenNgay), obj.CoSoDT, obj.KhoaDT, obj.ThoiGianDT, obj.HocPhi, obj.TenTepDK, obj.DuongDanDK, obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub EXE_Apprentice_Delete(PortalConnect As String, apprentice_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Apprentice_Delete", apprentice_ID)
    End Sub
#End Region
#Region "EXE_Advisory"
    Public Overrides Function EXE_Advisory_Find(PortalConnect As String, noCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Advisory_Find", noCode), IDataReader)
    End Function
    Public Overrides Sub EXE_Advisory_Update_TrangThai(PortalConnect As String, advisory_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Advisory_Update_TrangThai", advisory_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Overrides Function EXE_Advisory_List_Search(PortalConnect As String, Search As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Advisory_List_Search", Search, IsOrder, currPage, recodperpage, portalId, trangThai, userName), IDataReader)
    End Function
    Public Overrides Function EXE_Advisory_Get(PortalConnect As String, advisory_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Advisory_Get", advisory_ID), IDataReader)
    End Function
    Public Overrides Function EXE_Advisory_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Advisory_List", portalId), IDataReader)
    End Function
    Public Overrides Sub EXE_Advisory_Add(PortalConnect As String, obj As EXE_AdvisoryInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_Advisory_Add", obj.Advisory_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.SoTaiKhoan, obj.NganHang, obj.ChiNhanhNH, obj.TT_TinhTP, obj.TT_QuanHuyen, obj.TT_XaPhuong, obj.TT_DuongPho, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.SucKhoe, obj.ChieuCao, obj.CanNang, obj.NgoaiNgu, obj.GiaoDucPT, obj.TinHoc, obj.ChuyenMonKT, obj.MucLuong, obj.LyDoNghi, obj.DaTimViecTai, obj.KyNangNghe, obj.KhaNangNoiTroi, obj.TuVan_ChinhSach, obj.TuVan_ViecLam, obj.TuVan_BHTN, obj.TuVan_Khac, flReg.GetNull(obj.GT_ViTri), flReg.GetNull(obj.GT_MucLuong), flReg.GetNull(obj.GT_CongViec), flReg.GetNull(obj.GT_TinhTP), flReg.GetNull(obj.GT_QuanHuyen), flReg.GetNull(obj.GT_LoaiHinh), flReg.GetNull(obj.GT_DieuKien), flReg.GetNull(obj.GT_Khac), obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub EXE_Advisory_Update(PortalConnect As String, obj As EXE_AdvisoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Advisory_Update", obj.Advisory_ID, obj.NoCode, obj.HoTen, flReg.GetNull(obj.NgaySinh), obj.GioiTinh, obj.SoCMND, flReg.GetNull(obj.NgayCap), obj.NoiCap, obj.SoBHXH, obj.Email, obj.DienThoai, obj.DanToc, obj.TonGiao, obj.SoTaiKhoan, obj.NganHang, obj.ChiNhanhNH, obj.TT_TinhTP, obj.TT_QuanHuyen, obj.TT_XaPhuong, obj.TT_DuongPho, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.SucKhoe, obj.ChieuCao, obj.CanNang, obj.NgoaiNgu, obj.GiaoDucPT, obj.TinHoc, obj.ChuyenMonKT, obj.MucLuong, obj.LyDoNghi, obj.DaTimViecTai, obj.KyNangNghe, obj.KhaNangNoiTroi, obj.TuVan_ChinhSach, obj.TuVan_ViecLam, obj.TuVan_BHTN, obj.TuVan_Khac, flReg.GetNull(obj.GT_ViTri), flReg.GetNull(obj.GT_MucLuong), flReg.GetNull(obj.GT_CongViec), flReg.GetNull(obj.GT_TinhTP), flReg.GetNull(obj.GT_QuanHuyen), flReg.GetNull(obj.GT_LoaiHinh), flReg.GetNull(obj.GT_DieuKien), flReg.GetNull(obj.GT_Khac), obj.PortalID, obj.TrangThai, flReg.GetNull(obj.NgayNopHS), flReg.GetNull(obj.NgayTiepNhan), obj.NguoiTiepNhan, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub EXE_Advisory_Delete(PortalConnect As String, advisory_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Advisory_Delete", advisory_ID)
    End Sub
#End Region
#Region "EXE_AdvisoryC"
    Public Overrides Function EXE_AdvisoryC_Get(PortalConnect As String, advisoryC_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryC_Get", advisoryC_ID), IDataReader)
    End Function
    Public Overrides Function EXE_AdvisoryC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryC_List"), IDataReader)
    End Function
    Public Overrides Sub EXE_AdvisoryC_Add(PortalConnect As String, obj As EXE_AdvisoryCInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_AdvisoryC_Add", obj.AdvisoryC_ID, obj.Advisory_ID, obj.Company, obj.TimeWork, obj.Location, obj.IsOrder)
    End Sub
    Public Overrides Sub EXE_AdvisoryC_Update(PortalConnect As String, obj As EXE_AdvisoryCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryC_Update", obj.AdvisoryC_ID, obj.Advisory_ID, obj.Company, obj.TimeWork, obj.Location, obj.IsOrder)
    End Sub
    Public Overrides Function EXE_AdvisoryC_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryC_Get_By_EXE_Advisory", advisory_ID), IDataReader)
    End Function
    Public Overrides Sub EXE_AdvisoryC_Delete(PortalConnect As String, advisoryC_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryC_Delete", advisoryC_ID)
    End Sub
    Public Overrides Sub EXE_AdvisoryC_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryC_Delete_By_EXE_Advisory", advisory_ID)
    End Sub
#End Region
#Region "EXE_AdvisoryS"
    Public Overrides Function EXE_AdvisoryS_Get(PortalConnect As String, advisoryS_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryS_Get", advisoryS_ID), IDataReader)
    End Function
    Public Overrides Function EXE_AdvisoryS_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryS_List"), IDataReader)
    End Function

    Public Overrides Sub EXE_AdvisoryS_Add(PortalConnect As String, obj As EXE_AdvisorySInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_AdvisoryS_Add", obj.AdvisoryS_ID, obj.Advisory_ID, obj.Specialized, obj.LevelName, obj.IsOrder)
    End Sub
    Public Overrides Sub EXE_AdvisoryS_Update(PortalConnect As String, obj As EXE_AdvisorySInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryS_Update", obj.AdvisoryS_ID, obj.Advisory_ID, obj.Specialized, obj.LevelName, obj.IsOrder)
    End Sub
    Public Overrides Function EXE_AdvisoryS_Get_By_EXE_Advisory(PortalConnect As String, advisory_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_AdvisoryS_Get_By_EXE_Advisory", advisory_ID), IDataReader)
    End Function
    Public Overrides Sub EXE_AdvisoryS_Delete(PortalConnect As String, advisoryS_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryS_Delete", advisoryS_ID)
    End Sub
    Public Overrides Sub EXE_AdvisoryS_Delete_By_EXE_Advisory(PortalConnect As String, advisory_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_AdvisoryS_Delete_By_EXE_Advisory", advisory_ID)
    End Sub
#End Region
#Region "EXE_Notification"
    Public Overrides Function EXE_Notification_Find(PortalConnect As String, noCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Notification_Find", noCode), IDataReader)
    End Function
    Public Overrides Sub EXE_Notification_Update_TrangThai(PortalConnect As String, notification_ID As String, trangThai As Integer, updatedDate As DateTime, updatedUser As String, des As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Notification_Update_TrangThai", notification_ID, trangThai, updatedDate, updatedUser, des)
    End Sub
    Public Overrides Function EXE_Notification_List_Search(PortalConnect As String, Search As String, currPage As Integer, recodperpage As Integer, portalId As Integer, trangThai As Integer, qD_VeTinh As String, nam As Integer, thang As Integer, ngay As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Notification_List_Search", Search, currPage, recodperpage, portalId, trangThai, qD_VeTinh, nam, thang, ngay, userName), IDataReader)
    End Function
    Public Overrides Function EXE_Notification_List_AppID(PortalConnect As String, currPage As Integer, recodperpage As Integer, Decide_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Notification_List_AppID", PortalConnect, currPage, recodperpage, Decide_ID), IDataReader)
    End Function
    Public Overrides Function EXE_Notification_Get(PortalConnect As String, notification_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Notification_Get", PortalConnect, notification_ID), IDataReader)
    End Function
    Public Overrides Function EXE_Notification_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_Notification_List", portalId), IDataReader)
    End Function
    Public Overrides Sub EXE_Notification_Add(PortalConnect As String, obj As EXE_NotificationInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_Notification_Add", obj.Notification_ID, obj.NoCode, obj.ThangHuong, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.SoCMND, obj.NgayCap, obj.NoiCap, obj.DienThoai, obj.Email, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.QD_So, obj.QD_Ngay, obj.QD_ThangHuong, obj.QD_TuNgay, obj.QD_DenNgay, obj.QD_TinhTP, obj.QD_VeTinh, obj.TinhTrang, obj.NeuCoVL, obj.TT_Khac, obj.PortalID, obj.TrangThai, obj.NgayNopHS, obj.NgayTiepNhan, obj.NguoiTiepNhan, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.Decide_ID)
    End Sub
    Public Overrides Sub EXE_Notification_Update(PortalConnect As String, obj As EXE_NotificationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Notification_Update", obj.Notification_ID, obj.NoCode, obj.ThangHuong, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.SoCMND, obj.NgayCap, obj.NoiCap, obj.DienThoai, obj.Email, obj.CO_TinhTP, obj.CO_QuanHuyen, obj.CO_XaPhuong, obj.CO_DuongPho, obj.QD_So, obj.QD_Ngay, obj.QD_ThangHuong, obj.QD_TuNgay, obj.QD_DenNgay, obj.QD_TinhTP, obj.QD_VeTinh, obj.TinhTrang, obj.NeuCoVL, obj.TT_Khac, obj.PortalID, obj.TrangThai, obj.NgayNopHS, obj.NgayTiepNhan, obj.NguoiTiepNhan, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub EXE_Notification_Delete(PortalConnect As String, notification_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_Notification_Delete", notification_ID)
    End Sub
#End Region
#Region "EXE_NotificationD"
    Public Overrides Function EXE_NotificationD_Get(PortalConnect As String, notificationD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NotificationD_Get", notificationD_ID), IDataReader)
    End Function
    Public Overrides Function EXE_NotificationD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NotificationD_List"), IDataReader)
    End Function
    Public Overrides Sub EXE_NotificationD_Add(PortalConnect As String, obj As EXE_NotificationDInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_NotificationD_Add", obj.NotificationD_ID, obj.Notification_ID, obj.TenDonVi, obj.DiaChi, obj.NguoiLienHe, obj.ViTriDuTuyen, obj.KetQua, obj.IsOrder)
    End Sub
    Public Overrides Sub EXE_NotificationD_Update(PortalConnect As String, obj As EXE_NotificationDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_NotificationD_Update", obj.NotificationD_ID, obj.Notification_ID, obj.TenDonVi, obj.DiaChi, obj.NguoiLienHe, obj.ViTriDuTuyen, obj.KetQua, obj.IsOrder)
    End Sub
    Public Overrides Function EXE_NotificationD_Get_By_EXE_Notification(PortalConnect As String, notification_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NotificationD_Get_By_EXE_Notification", notification_ID), IDataReader)
    End Function
    Public Overrides Sub EXE_NotificationD_Delete(PortalConnect As String, notificationD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_NotificationD_Delete", notificationD_ID)
    End Sub
#End Region
#Region "EXE_NumberAuto"
    Public Overrides Function EXE_NumberAuto_Check_Register(PortalConnect As String, dichVu As Integer, ngayNghiViec As DateTime, dienThoai As String, soBHXH As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_Check_Register", PortalConnect, dichVu, ngayNghiViec, dienThoai, soBHXH), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_Get(PortalConnect As String, numberAuto_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_Get", numberAuto_ID), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_List", portalId), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_Get_ToApp(PortalConnect As String, dienThoai As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_Get_ToApp", PortalConnect, dienThoai, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_List_IsOnline(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_List_IsOnline", portalId), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_List_Search(PortalConnect As String, veTinh As String, ngayDangKy As DateTime, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_List_Search", PortalConnect, veTinh, ngayDangKy, dichVu, search, currPage, recodperpage, userName), IDataReader)
    End Function
    Public Overrides Function EXE_NumberAuto_Add(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_NumberAuto_Add", obj.NumberAuto_ID, obj.NoCode, flReg.GetNull(obj.HoTen), obj.DienThoai, flReg.GetNull(obj.SoBHXH), flReg.GetNull(obj.NgaySinh), flReg.GetNull(obj.NgayNghiViec), obj.DichVu, obj.PortalID, flReg.GetNull(obj.VeTinhID), flReg.GetNull(obj.SangChieu), flReg.GetNull(obj.NgayDangKy), obj.TinhTrang, obj.CreatedDate, flReg.GetNull(obj.CreatedUser)), Integer)
    End Function
    Public Overrides Function EXE_NumberAuto_Add_Lite(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_NumberAuto_Add_Lite", obj.NumberAuto_ID, obj.NoCode, flReg.GetNull(obj.HoTen), obj.DienThoai, flReg.GetNull(obj.SoBHXH), flReg.GetNull(obj.NgaySinh), flReg.GetNull(obj.NgayNghiViec), obj.DichVu, obj.PortalID, flReg.GetNull(obj.VeTinhID), flReg.GetNull(obj.SangChieu), flReg.GetNull(obj.NgayDangKy), obj.TinhTrang, obj.CreatedDate, flReg.GetNull(obj.CreatedUser)), Integer)
    End Function
    Public Overrides Function EXE_NumberAuto_Add_Offline(PortalConnect As String, obj As EXE_NumberAutoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_NumberAuto_Add_Offline", obj.NumberAuto_ID, obj.NoCode, obj.DichVu, obj.PortalID, flReg.GetNull(obj.VeTinhID), flReg.GetNull(obj.SangChieu), flReg.GetNull(obj.NgayDangKy), obj.TinhTrang, obj.CreatedDate, flReg.GetNull(obj.CreatedUser)), Integer)
    End Function
    Public Overrides Sub EXE_NumberAuto_Delete(PortalConnect As String, numberAuto_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_NumberAuto_Delete", numberAuto_ID)
    End Sub
    Public Overrides Sub EXE_NumberAuto_Update_TinhTrang(PortalConnect As String, numberAuto_ID As String, tinhTrang As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_NumberAuto_Update_TinhTrang", numberAuto_ID, tinhTrang)
    End Sub
    Public Overrides Sub EXE_NumberAuto_Update_IsOnline(PortalConnect As String, numberAuto_ID As String, isOnline As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_NumberAuto_Update_IsOnline", numberAuto_ID, isOnline)
    End Sub
#End Region
#Region "CMS_DashBoard"
    Public Overrides Function CMS_DashBoard_Admin(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_DashBoard_Admin", portalId), IDataReader)
    End Function
#End Region
#Region "CMS_SettingAuto"
    Public Overrides Function CMS_SettingAuto_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingAuto_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SettingAuto_Get_ByPortal(PortalConnect As String, portal_ID As Integer, Satellite_ID As String, FlagType As Int16) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingAuto_Get_ByPortal", portal_ID, Satellite_ID, FlagType), IDataReader)
    End Function
    Public Overrides Function CMS_SettingAuto_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingAuto_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SettingAuto_List_Service(PortalConnect As String, Satellite_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingAuto_List_Service", Satellite_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SettingAuto_Add(PortalConnect As String, obj As CMS_SettingAutoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_SettingAuto_Add", obj.Satellite_ID, obj.Portal_ID, obj.NumDoor, obj.FlagType, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_SettingAuto_Update(PortalConnect As String, obj As CMS_SettingAutoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingAuto_Update", obj.ID, obj.Satellite_ID, obj.Portal_ID, obj.NumDoor, obj.FlagType, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_SettingAuto_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingAuto_Delete", iD)
    End Sub
#End Region
#Region "CMS_SettingDoor"
    Public Overrides Function CMS_SettingDoor_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_GetBy_Portal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_GetBy_Portal", Portal_ID, satellite_id, flagType, day, month, year), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_List_ByPortal(PortalConnect As String, Portal_ID As Integer, satellite_id As String, flagType As Integer, day As Integer, month As Integer, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_List_ByPortal", Portal_ID, satellite_id, flagType, day, month, year), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_List_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, months As Integer, years As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_List_To_App", PortalConnect, veTinhID, dichVu, fromDate, toDate, months, years), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_Select_To_App(PortalConnect As String, veTinhID As String, dichVu As Integer, fromDate As DateTime, toDate As DateTime, soBHXH As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingDoor_Select_To_App", PortalConnect, veTinhID, dichVu, fromDate, toDate, soBHXH), IDataReader)
    End Function
    Public Overrides Function CMS_SettingDoor_Add(PortalConnect As String, obj As CMS_SettingDoorInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_SettingDoor_Add", obj.Satellite_ID, obj.Portal_ID, obj.FlagType, obj.DayText, obj.DateSetting, obj.MonthSetting, obj.YearSetting, obj.NumDoor, obj.SAWelcome, obj.CHWelcome, obj.SARegister, obj.CHRegister, obj.SumExist, obj.Notes, obj.IsDayOff, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_SettingDoor_Update(PortalConnect As String, obj As CMS_SettingDoorInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingDoor_Update", obj.ID, obj.Satellite_ID, obj.Portal_ID, obj.DateSetting, obj.MonthSetting, obj.YearSetting, obj.NumDoor, obj.SAWelcome, obj.CHWelcome, obj.SARegister, obj.CHRegister, obj.SumExist, obj.Notes, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_SettingDoor_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingDoor_Delete", iD)
    End Sub
#End Region
#Region "CMS_SettingTime"
    Public Overrides Function CMS_SettingTime_Get(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingTime_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SettingTime_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingTime_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SettingTime_List_ByAutoID(PortalConnect As String, settingauto_id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_SettingTime_List_ByAutoID", settingauto_id), IDataReader)
    End Function

    Public Overrides Sub CMS_SettingTime_Add(PortalConnect As String, obj As CMS_SettingTimeInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_SettingTime_Add", obj.ID, obj.SettingAuto_ID, obj.FromTime, obj.ToTime, obj.IsMorning, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_SettingTime_Update(PortalConnect As String, obj As CMS_SettingTimeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingTime_Update", obj.ID, obj.SettingAuto_ID, obj.FromTime, obj.ToTime, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_SettingTime_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_SettingTime_Delete", iD)
    End Sub
#End Region
#Region "CMS_DoorTime"
    Public Overrides Function CMS_DoorTime_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_DoorTime_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_DoorTime_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "CMS_DoorTime_List"), IDataReader)
    End Function

    Public Overrides Function CMS_DoorTime_Add(PortalConnect As String, obj As CMS_DoorTimeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.InsuConnect, "CMS_DoorTime_Add", obj.SettingDoor_ID, obj.FromTime, obj.ToTime, obj.IsMorning, obj.SumWelCome, obj.SumRegister, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_DoorTime_Update(PortalConnect As String, obj As CMS_DoorTimeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_DoorTime_Update", obj.ID, obj.SettingDoor_ID, obj.FromTime, obj.ToTime, obj.IsMorning, obj.SumWelCome, obj.SumRegister, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_DoorTime_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "CMS_DoorTime_Delete", iD)
    End Sub
#End Region
#Region "CMS_Door"
    Public Overrides Function CMS_Door_List_Search(PortalConnect As String, portalID As Integer, veTinh As String, dichVu As Integer, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Door_List_Search", portalID, veTinh, dichVu, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Door_Get(PortalConnect As String, doorID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Door_Get", doorID), IDataReader)
    End Function
    Public Overrides Function CMS_Door_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmiConnect, "CMS_Door_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Door_Add(PortalConnect As String, obj As CMS_DoorInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmiConnect, "CMS_Door_Add", obj.DoorCode, obj.DoorName, obj.PortalID, obj.SatelliteID, obj.FlagService, obj.TinhTP, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_Door_Update(PortalConnect As String, obj As CMS_DoorInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Door_Update", obj.DoorID, obj.DoorCode, obj.DoorName, obj.PortalID, obj.SatelliteID, obj.FlagService, obj.TinhTP, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_Door_Delete(PortalConnect As String, doorID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmiConnect, "CMS_Door_Delete", doorID)
    End Sub
#End Region
#Region "EXE_FileAttch"
    Public Overrides Function EXE_FileAttch_Get(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_FileAttch_Get", iD), IDataReader)
    End Function
    Public Overrides Function EXE_FileAttch_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_FileAttch_List"), IDataReader)
    End Function
    Public Overrides Function EXE_FileAttch_List_By_IdKey(PortalConnect As String, IdKey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_FileAttch_List_By_IdKey", IdKey), IDataReader)
    End Function
    Public Overrides Sub EXE_FileAttch_Add(PortalConnect As String, obj As EXE_FileAttchInfo)
        SqlHelper.ExecuteScalar(flConnect.InsuConnect, "EXE_FileAttch_Add", obj.ID, obj.IdKey, flReg.GetNull(obj.Flags), flReg.GetNull(obj.FilePaths), flReg.GetNull(obj.FileName), obj.IsOrder)
    End Sub
    Public Overrides Sub EXE_FileAttch_Update(PortalConnect As String, obj As EXE_FileAttchInfo)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_FileAttch_Update", obj.ID, obj.IdKey, flReg.GetNull(obj.Flags), flReg.GetNull(obj.FilePaths), flReg.GetNull(obj.FileName), obj.IsOrder)
    End Sub
    Public Overrides Sub EXE_FileAttch_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.InsuConnect, "EXE_FileAttch_Delete", iD)
    End Sub
#End Region

#Region "REPORT"

    Public Overrides Function EXE_NumberAuto_Report(PortalConnect As String, typeId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.InsuConnect, "EXE_NumberAuto_Report", typeId), IDataReader)
    End Function

#End Region


End Class