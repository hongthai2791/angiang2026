Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.VBN
Public Class SqlDataProvider
    Inherits DataProvider
#Region "CMS_Employee"
    Public Overrides Function CMS_Employee_List_Send(PortalConnect As String, businessID As Integer, deparmentCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Send", businessID, deparmentCode), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_Get(PortalConnect As String, employee_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_Get", employee_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_GetByCode(PortalConnect As String, uID As Integer, empCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_GetByCode", uID, empCode), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_Get_By_AppID(PortalConnect As String, uID As Integer, AppID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_Get_By_AppID", uID, AppID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Manager(PortalConnect As String, businessID As Integer, deparmentCode As String, isManager As Int16, currPage As Integer, recodperpage As Integer, Search As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Manager", businessID, deparmentCode, isManager, currPage, recodperpage, Search), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Manager_Abs(PortalConnect As String, businessID As Integer, empCode As String, deparmentCode As String, currPage As Integer, recodperpage As Integer, Optional ByVal Search As String = "") As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Manager_Abs", businessID, empCode, deparmentCode, currPage, recodperpage, Search), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_Permistion(PortalConnect As String, uID As Integer, eID As String, dID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Employee_Permistion", uID, eID, dID), Integer)
    End Function
    Public Overrides Function CMS_Employee_Add(PortalConnect As String, obj As CMS_EmployeeInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Employee_Add", obj.Employee_ID, obj.EmployeeCode, obj.EmployeeName, obj.Status, obj.BusinessID, obj.DepartmentCode, obj.IsManager, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.AppLogo, obj.AppID, obj.YearID, obj.MonthID, obj.ChucDanh), String)
    End Function

    Public Overrides Sub CMS_Employee_Update(PortalConnect As String, obj As CMS_EmployeeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Employee_Update", obj.Employee_ID, obj.EmployeeCode, obj.EmployeeName, obj.Status, obj.BusinessID, obj.DepartmentCode, obj.IsManager, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.AppLogo, obj.AppID, obj.ChucDanh)
    End Sub
    Public Overrides Sub CMS_Employee_Delete(PortalConnect As String, employee_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Employee_Delete", employee_ID)
    End Sub
    Public Overrides Function CMS_Employee_Update_Status(PortalConnect As String, obj As CMS_EmployeeInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Employee_Update_Status", obj.EmployeeCode, obj.BusinessID, obj.DepartmentCode, obj.Status), String)
    End Function
    Public Overrides Function CMS_Employee_Update_App(PortalConnect As String, EmployeeCode As String, BusinessID As Integer, DepartmentCode As String, AppID As String, AppLogo As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Employee_Update_App", EmployeeCode, BusinessID, DepartmentCode, AppID, AppLogo), String)
    End Function
    Public Overrides Function CMS_Employee_List_Group_Select(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, eID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Group_Select", search, currPage, recodperpage, uID, eID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Cache(PortalConnect As String, uID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Cache", uID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, businessID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Search", search, currPage, recodperpage, businessID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_By_UID(PortalConnect As String, businessID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_By_UID", businessID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Chat(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Chat", search, currPage, recodperpage, uID, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Admin(PortalConnect As String, search As String, businessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Admin", search, businessID, IsStatus, yearID, monthID, DepartmentCode, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Admin_Eports(PortalConnect As String, search As String, businessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Admin_Eports", search, businessID, IsStatus, yearID, monthID, DepartmentCode), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Select(PortalConnect As String, search As String, businessID As Integer, GroupID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Select", search, businessID, GroupID, DepartmentCode, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Employee_List_Group(PortalConnect As String, search As String, businessID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Employee_List_Group", search, businessID, DepartmentCode, currPage, recodperpage, ID), IDataReader)
    End Function
#End Region
#Region "CMS_Salary"
    Public Overrides Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Salary_Get", salary_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Salary_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Salary_List_Search", search, isOrder, yearID, monthID, currPage, recodperpage, bID, DepartmentCode, isStatus), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Salary_List_By_AppID", BusinessID, EmployeeCode, DepartmentCode, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Salary_Add", obj.Salary_ID, obj.YearID, obj.MonthID, obj.EmployeeCode, obj.DepartmentCode, obj.BusinessID, flReg.GetNull(obj.ChucDanh), flReg.GetNull(obj.LuongThang), flReg.GetNull(obj.GioLamThem), flReg.GetNull(obj.TroCapDem), flReg.GetNull(obj.PhuCap), flReg.GetNull(obj.DCTang), flReg.GetNull(obj.DCGiam), flReg.GetNull(obj.DMVS), flReg.GetNull(obj.BaoHiem), flReg.GetNull(obj.PhiCongDoan), flReg.GetNull(obj.ThuePIT), flReg.GetNull(obj.ThucLinh), flReg.GetNull(obj.IsOrder), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsSent), String)
    End Function
    Public Overrides Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Salary_Update", obj.Salary_ID, obj.YearID, obj.MonthID, obj.EmployeeCode, obj.DepartmentCode, obj.BusinessID, flReg.GetNull(obj.ChucDanh), flReg.GetNull(obj.LuongThang), flReg.GetNull(obj.GioLamThem), flReg.GetNull(obj.TroCapDem), flReg.GetNull(obj.PhuCap), flReg.GetNull(obj.DCTang), flReg.GetNull(obj.DCGiam), flReg.GetNull(obj.DMVS), flReg.GetNull(obj.BaoHiem), flReg.GetNull(obj.PhiCongDoan), flReg.GetNull(obj.ThuePIT), flReg.GetNull(obj.ThucLinh), flReg.GetNull(obj.IsOrder), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsSent)
    End Sub
    Public Overrides Sub CMS_Salary_Update_Sent(PortalConnect As String, salary_ID As String, IsSent As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Salary_Update_Sent", salary_ID, IsSent)
    End Sub
    Public Overrides Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Salary_Delete", salary_ID)
    End Sub
    Public Overrides Sub CMS_SendNotify_Sent(PortalConnect As String, sID As String, Type As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SendNotify_Sent", sID, Type)
    End Sub

#End Region
#Region "CMS_TimeKeep"
    Public Overrides Function CMS_TimeKeep_Get(PortalConnect As String, timeKeep_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_Get", timeKeep_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeep_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeep_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_List_Search", search, isOrder, yearID, monthID, currPage, recodperpage, bID, DepartmentCode, isStatus), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeep_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_List_By_AppID", BusinessID, EmployeeCode, DepartmentCode, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeep_Add(PortalConnect As String, obj As CMS_TimeKeepInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_Add", obj.TimeKeep_ID, obj.YearID, obj.MonthID, obj.EmployeeCode, flReg.GetNull(obj.EmployeeName), obj.DepartmentCode, obj.BusinessID, flReg.GetNull(obj.NCTT), flReg.GetNull(obj.PhepP), flReg.GetNull(obj.DacBietSP), flReg.GetNull(obj.KLRo), flReg.GetNull(obj.OTNgay), flReg.GetNull(obj.OTDem), flReg.GetNull(obj.GioCaDem), flReg.GetNull(obj.VMRS), flReg.GetNull(obj.NghiLe), flReg.GetNull(obj.SoACN), flReg.GetNull(obj.SoACD), flReg.GetNull(obj.NgayPhepCL), flReg.GetNull(obj.IsOrder), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsSent), String)
    End Function
    Public Overrides Sub CMS_TimeKeep_Update(PortalConnect As String, obj As CMS_TimeKeepInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_Update", obj.TimeKeep_ID, obj.YearID, obj.MonthID, obj.EmployeeCode, flReg.GetNull(obj.EmployeeName), obj.DepartmentCode, obj.BusinessID, flReg.GetNull(obj.NCTT), flReg.GetNull(obj.PhepP), flReg.GetNull(obj.DacBietSP), flReg.GetNull(obj.KLRo), flReg.GetNull(obj.OTNgay), flReg.GetNull(obj.OTDem), flReg.GetNull(obj.GioCaDem), flReg.GetNull(obj.VMRS), flReg.GetNull(obj.NghiLe), flReg.GetNull(obj.SoACN), flReg.GetNull(obj.SoACD), flReg.GetNull(obj.NgayPhepCL), flReg.GetNull(obj.IsOrder), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsSent)
    End Sub
    Public Overrides Sub CMS_TimeKeep_Update_Sent(PortalConnect As String, timeKeep_ID As String, IsSent As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_Update_Sent", timeKeep_ID, IsSent)
    End Sub
    Public Overrides Sub CMS_TimeKeep_Delete(PortalConnect As String, timeKeep_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeep_Delete", timeKeep_ID)
    End Sub
#End Region
#Region "CMS_TypeZoom"
    Public Overrides Function CMS_TypeZoom_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TypeZoom_List"), IDataReader)
    End Function
#End Region
#Region "CMS_Utility"
    Public Overrides Function CMS_Utility_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Utility_List"), IDataReader)
    End Function
#End Region
#Region "CMS_LeaveOfAbs"
    Public Overrides Function CMS_LeaveOfAbs_Get(PortalConnect As String, leaveOfAbs_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Get", leaveOfAbs_ID), IDataReader)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List"), IDataReader)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_List_Search(PortalConnect As String, uid As Integer, currPage As Integer, recodperpage As Integer, appID As String, eID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List_Search", uid, currPage, recodperpage, appID, eID), IDataReader)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_List_By_BusActive(PortalConnect As String, uID As Integer, month As Integer, years As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List_By_BusActive", uID, month, years), IDataReader)
    End Function
    Public Overrides Sub CMS_LeaveOfAbs_Update_By_BusActive(PortalConnect As String, uID As Integer, leaveOfAbs_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Update_By_BusActive", uID, leaveOfAbs_ID)
    End Sub
    Public Overrides Function CMS_LeaveOfAbs_List_By_Receive(PortalConnect As String, uid As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List_By_Receive", uid, currPage, recodperpage, appID), IDataReader)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_List_Search_Web(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List_Search_Web", BusinessID, DepartmentCode, Thang, Nam, IsActive, key, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_List_Search_Web_export(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_List_Search_Web_export", BusinessID, DepartmentCode, Thang, Nam, IsActive, key), IDataReader)
    End Function
    Public Overrides Sub CMS_LeaveOfAbs_Add(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
        SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Add", obj.LeaveOfAbs_ID, obj.BusinessID, flReg.GetNull(obj.BusinessName), obj.EmployeeCode, flReg.GetNull(obj.DepartmentCode), obj.AppID, flReg.GetNull(obj.FromDate), flReg.GetNull(obj.ToDate), obj.Reason, flReg.GetNull(obj.Comments), flReg.GetNull(obj.ReceiveName), flReg.GetNull(obj.ReceiveDep), flReg.GetNull(obj.NotiName), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate), obj.IsActive, flReg.GetNull(obj.ActiveUser), flReg.GetNull(obj.ActiveDate))
    End Sub
    Public Overrides Sub CMS_LeaveOfAbs_Update(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Update", obj.LeaveOfAbs_ID, obj.BusinessID, flReg.GetNull(obj.BusinessName), obj.EmployeeCode, flReg.GetNull(obj.DepartmentCode), obj.AppID, flReg.GetNull(obj.FromDate), flReg.GetNull(obj.ToDate), obj.Reason, flReg.GetNull(obj.Comments), flReg.GetNull(obj.ReceiveName), flReg.GetNull(obj.NotiName), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate), obj.IsActive, flReg.GetNull(obj.ActiveUser), flReg.GetNull(obj.ActiveDate))
    End Sub
    Public Overrides Function CMS_LeaveOfAbs_Active_New(PortalConnect As String, id As String, reason As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Active_New", id, reason, isActive, activeUser, activeDate), Integer)
    End Function
    Public Overrides Function CMS_LeaveOfAbs_Active(PortalConnect As String, id As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Active", id, isActive, activeUser, activeDate), Integer)
    End Function
    Public Overrides Sub CMS_LeaveOfAbs_Delete(PortalConnect As String, leaveOfAbs_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_LeaveOfAbs_Delete", leaveOfAbs_ID)
    End Sub
#End Region
#Region "CMS_Comment"
    Public Overrides Function CMS_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Comment_Get", comment_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Comment_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Comment_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Comment_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Comment_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Function CMS_Comment_Add(PortalConnect As String, obj As CMS_CommentInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Comment_Add", obj.Post_ID, obj.AppID, obj.Contents, obj.CreatedDate, obj.UpdatedDate), Integer)
    End Function
    Public Overrides Sub CMS_Comment_Update(PortalConnect As String, obj As CMS_CommentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Comment_Update", obj.Comment_ID, obj.Post_ID, obj.AppID, obj.Contents, obj.CreatedDate, obj.UpdatedDate)
    End Sub
    Public Overrides Sub CMS_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Comment_Delete", comment_ID)
    End Sub
#End Region
#Region "CMS_Likes"
    Public Overrides Function CMS_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Likes_Get", likesID), IDataReader)
    End Function
    Public Overrides Function CMS_Likes_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Likes_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Likes_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Likes_Add(PortalConnect As String, obj As CMS_LikesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Likes_Add", obj.AppID, obj.PostID, obj.CreatedDate), Integer)
    End Function
    Public Overrides Function CMS_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Likes_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Likes_Update(PortalConnect As String, obj As CMS_LikesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Likes_Update", obj.LikesID, obj.AppID, obj.PostID, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Likes_Delete", appID, postID)
    End Sub
#End Region
#Region "CMS_Post"
    Public Overrides Function CMS_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Post_Get", post_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Post_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Post_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Post_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Post_List_Search", search, isOrder, currPage, recodperpage, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Post_List_OnlyMe(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Post_List_OnlyMe", search, currPage, recodperpage, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Post_Add(PortalConnect As String, obj As CMS_PostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Post_Add", obj.AppID, obj.Contents, obj.CreatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends, obj.PostShareID), Integer)
    End Function
    Public Overrides Sub CMS_Post_Update(PortalConnect As String, obj As CMS_PostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Post_Update", obj.Post_ID, obj.AppID, obj.Contents, obj.CreatedDate, obj.UpdatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends)
    End Sub
    Public Overrides Sub CMS_Post_Delete(PortalConnect As String, post_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Post_Delete", post_ID)
    End Sub
#End Region
#Region "CMS_SharePost"
    Public Overrides Function CMS_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SharePost_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SharePost_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SharePost_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SharePost_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_SharePost_Add(PortalConnect As String, obj As CMS_SharePostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_SharePost_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_SharePost_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_SharePost_Update(PortalConnect As String, obj As CMS_SharePostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SharePost_Update", obj.SharePost_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SharePost_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_ShareUser"
    Public Overrides Function CMS_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ShareUser_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_List_Search", search, currPage, recodperpage, postID), IDataReader)
    End Function

    Public Overrides Function CMS_ShareUser_Add(PortalConnect As String, obj As CMS_ShareUserInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_ShareUser_Update(PortalConnect As String, obj As CMS_ShareUserInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_Update", obj.ShareUser_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_ShareUser_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_FileAttach"
    Public Overrides Function CMS_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_Get", attach_ID), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttach_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_List"), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_List_ByIdKey", idKey, type, top), IDataReader)
    End Function
    Public Overrides Function CMS_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
        SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_Add", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_Update", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_FileAttach_Delete", attach_ID)
    End Sub
#End Region
#Region "CMS_RelationShip"
    Public Overrides Function CMS_RelationShip_Get_By_Friend(PortalConnect As String, appID As String, appFriend As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Get_By_Friend", appID, appFriend), IDataReader)
    End Function
    Public Overrides Function CMS_RelationShip_Get(PortalConnect As String, relationShip_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Get", relationShip_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RelationShip_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_List"), IDataReader)
    End Function
    Public Overrides Function CMS_RelationShip_List_Friend(PortalConnect As String, appID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_List_Friend", appID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RelationShip_List_FGroup(PortalConnect As String, appID As String, appFriend As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_List_FGroup", appID, appFriend), Integer)
    End Function
    Public Overrides Function CMS_RelationShip_Get_By_App(PortalConnect As String, appID As String, appFriend As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Get_By_App", appID, appFriend), Integer)
    End Function
    Public Overrides Function CMS_RelationShip_Add(PortalConnect As String, obj As CMS_RelationShipInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Add", obj.AppID_One, obj.AppID_Two, obj.Status, obj.Action_AppID, obj.CreatedDate), Integer)
    End Function
    Public Overrides Sub CMS_RelationShip_Update(PortalConnect As String, relationShip_ID As Integer, status As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Update", relationShip_ID, status)
    End Sub
    Public Overrides Sub CMS_RelationShip_Delete(PortalConnect As String, relationShip_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RelationShip_Delete", relationShip_ID)
    End Sub
#End Region
#Region "CMS_Chat"
    Public Overrides Function CMS_Chat_Get(PortalConnect As String, chat_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_Get", chat_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_List_Search(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_List_Search", fromAppID, toAppID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_List_AppID(PortalConnect As String, fromAppID As String, toAppID As String, years As Integer, months As Integer, days As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_List_AppID", fromAppID, toAppID, years, months, days, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_List_Group(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_List_Group", fromAppID, toAppID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_Group_BoxList_AppID(PortalConnect As String, appID As String, groupID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_Group_BoxList_AppID", appID, groupID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_BoxList_AppID(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Chat_BoxList_AppID", fromAppID, toAppID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Chat_Add(PortalConnect As String, obj As CMS_ChatInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Chat_Add", obj.FromAppID, obj.ToAppID, obj.Contents, obj.IsStatus, obj.CreatedDate, obj.IsFile, obj.GroupID), Integer)
    End Function
    Public Overrides Function CMS_Employee_CountChat(PortalConnect As String, uID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Employee_CountChat", uID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Chat_Update(PortalConnect As String, obj As CMS_ChatInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Chat_Update", obj.Chat_ID, obj.FromAppID, obj.ToAppID, obj.Contents, obj.IsStatus, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_Chat_Delete(PortalConnect As String, chat_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Chat_Delete", chat_ID)
    End Sub
    Public Overrides Sub CMS_Chat_Update_Send(PortalConnect As String, chat_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Chat_Update_Send", chat_ID)
    End Sub
    Public Overrides Sub CMS_Chat_Update_Status(PortalConnect As String, fromAppID As String, toAppID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Chat_Update_Status", fromAppID, toAppID)
    End Sub
    Public Overrides Sub CMS_Chat_Update_Status_Group(PortalConnect As String, AppID As String, GroupID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Chat_Update_Status_Group", AppID, GroupID)
    End Sub
#End Region
#Region "CMS_Department"
    Public Overrides Function CMS_Department_Get(PortalConnect As String, departmentID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_Get", departmentID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_Get_ID(PortalConnect As String, departmentCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_Get_ID", departmentCode), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List_ByParentID(PortalConnect As String, parent_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List_ByParentID", parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List_bID(PortalConnect As String, bID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List_bID", bID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List_Search(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List_Search", search, fullText, isOrder, currPage, recodperpage, UserName, Business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List_ParentNull(PortalConnect As String, search As String, fullText As String, Business_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List_ParentNull", search, fullText, Business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_List_BID_Parent(PortalConnect As String, bID As Integer, ParentID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Department_List_BID_Parent", bID, ParentID), IDataReader)
    End Function
    Public Overrides Function CMS_Department_Add(PortalConnect As String, obj As CMS_DepartmentInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Department_Add", obj.DepartmentCode, obj.Parent_ID, obj.Business_ID, obj.DepartmentName, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Department_Update(PortalConnect As String, obj As CMS_DepartmentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Department_Update", obj.DepartmentID, obj.DepartmentCode, obj.Parent_ID, obj.Business_ID, obj.DepartmentName, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Department_Delete(PortalConnect As String, departmentID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Department_Delete", departmentID)
    End Sub
#End Region
#Region "CMS_UserHeart"
    Public Overrides Function CMS_UserHeart_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_UserHeart_Get_App(PortalConnect As String, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_Get_App", appID), IDataReader)
    End Function
    Public Overrides Function CMS_UserHeart_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_List"), IDataReader)
    End Function
    Public Overrides Function CMS_UserHeart_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_List_Search", currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_UserHeart_Add(PortalConnect As String, obj As CMS_UserHeartInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_Add", obj.AppID, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.MoiQT, flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.DuongPho), obj.GioiThieu, obj.ThuNhap, obj.NgheNghiep, obj.CongTy, obj.ChieuCao, obj.DangVoc, obj.TonGiao, obj.MauToc, obj.MauMat, obj.NhomMau, obj.CacMoiQH, obj.ConCai, obj.HutThuoc, obj.UongRB, obj.CheDoAn, obj.HocVan, obj.TinhCach, obj.PhongCachTT, obj.SoThich, obj.TuVi, obj.AnhDaiDien, obj.GhiChu, obj.ViTri, obj.IsOnline, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_UserHeart_Update(PortalConnect As String, obj As CMS_UserHeartInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_Update", obj.ID, obj.AppID, obj.HoTen, obj.NgaySinh, obj.GioiTinh, flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.DuongPho), obj.GioiThieu, obj.NgheNghiep, obj.CongTy, obj.ChieuCao, obj.DangVoc, obj.TonGiao, obj.MauToc, obj.MauMat, obj.NhomMau, obj.CacMoiQH, obj.ConCai, obj.HutThuoc, obj.UongRB, obj.CheDoAn, obj.HocVan, obj.TinhCach, obj.PhongCachTT, obj.SoThich, obj.TuVi, obj.AnhDaiDien, obj.GhiChu, obj.ViTri, obj.IsOnline, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate))
    End Sub
    Public Overrides Sub CMS_UserHearte_Update_Quick(PortalConnect As String, obj As CMS_UserHeartInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_UserHearte_Update_Quick", obj.AppID, obj.GhiChu)
    End Sub
    Public Overrides Sub CMS_UserHeart_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_UserHeart_Delete", iD)
    End Sub
#End Region
#Region "CMS_CateDetail"
    Public Overrides Function CMS_CateDetail_List_ByGroup(PortalConnect As String, GroupId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_CateDetail_List_ByGroup", GroupId), IDataReader)
    End Function
    Public Overrides Function CMS_CateDetail_Get(PortalConnect As String, CateDetail_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_CateDetail_Get", CateDetail_ID), IDataReader)
    End Function
#End Region
#Region "CMS_Answer"
    Public Overrides Function CMS_Answer_Get(PortalConnect As String, answer_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Answer_Get", answer_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Answer_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Answer_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_Answer_Add(PortalConnect As String, obj As CMS_AnswerInfo)
        SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Answer_Add", obj.Answer_ID, obj.Question_ID, obj.HoVaTen, obj.Contents, obj.Status, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Answer_Update(PortalConnect As String, obj As CMS_AnswerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Answer_Update", obj.Answer_ID, obj.Question_ID, obj.HoVaTen, obj.Contents, obj.Status, obj.CreatedDate, flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Function CMS_Answer_Get_By_Question_Home(PortalConnect As String, question_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Answer_Get_By_Question_Home", question_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Answer_Get_By_CMS_Question(PortalConnect As String, question_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Answer_Get_By_CMS_Question", question_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Answer_Delete(PortalConnect As String, answer_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Answer_Delete", answer_ID)
    End Sub
#End Region
#Region "CMS_Notify"
    Public Overrides Function CMS_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Notify_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Notify_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_List_AppID(PortalConnect As String, appID As String, currPage As Integer, recodPage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Notify_List_AppID", appID, currPage, recodPage), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Notify_Add", obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags)), Integer)
    End Function
    Public Overrides Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Notify_Update", obj.ID, obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags))
    End Sub
    Public Overrides Sub CMS_Notify_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Notify_Delete", iD)
    End Sub
#End Region
#Region "CMS_Question"
    Public Overrides Function CMS_Question_List_Month(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer, Years As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_Month", UID, EID, DID, Flags, Years), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_Year(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_Year", UID, EID, DID, Flags), IDataReader)
    End Function
    Public Overrides Function CMS_Question_Get(PortalConnect As String, question_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_Get", question_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_GroupApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_GroupApp", uID, appID, curpage, recordPage, isType), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_GroupApp_Details(PortalConnect As String, uID As Integer, appID As String, Months As Integer, Years As Integer, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_GroupApp_Details", uID, appID, Months, Years, isType), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_ForApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_ForApp", uID, appID, curpage, recordPage, isType), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_Search(PortalConnect As String, Key As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer, busID As Integer, years As String, months As String, types As Integer, status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_Search", Key, DepartmentCode, currPage, recodperpage, busID, years, months, types, status), IDataReader)
    End Function
    Public Overrides Function CMS_Question_List_App(PortalConnect As String, EmployeeCode As String, DepartmentCode As String, busID As Integer, years As String, months As String, types As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Question_List_App", EmployeeCode, DepartmentCode, busID, years, months, types), IDataReader)
    End Function
    Public Overrides Sub CMS_Question_Add(PortalConnect As String, obj As CMS_QuestionInfo)
        SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Question_Add", obj.Question_ID, obj.AppID, flReg.GetNull(obj.BusinessID), flReg.GetNull(obj.BusinessName), flReg.GetNull(obj.DepartmentCode), flReg.GetNull(obj.EmployeeCode), flReg.GetNull(obj.Years), flReg.GetNull(obj.Months), obj.Contents, flReg.GetNull(obj.Frequent), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsType), obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Question_Update(PortalConnect As String, obj As CMS_QuestionInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Question_Update", obj.Question_ID, obj.AppID, flReg.GetNull(obj.BusinessID), flReg.GetNull(obj.BusinessName), flReg.GetNull(obj.DepartmentCode), flReg.GetNull(obj.EmployeeCode), flReg.GetNull(obj.Years), flReg.GetNull(obj.Months), obj.Contents, flReg.GetNull(obj.Frequent), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsType), obj.CreatedDate, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Question_Update_Status(PortalConnect As String, quesID As String, status As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Question_Update_Status", quesID, status)
    End Sub
    Public Overrides Sub CMS_Question_Delete(PortalConnect As String, question_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Question_Delete", question_ID)
    End Sub
#End Region
#Region "CMS_Room"
    Public Overrides Function CMS_Room_Get(PortalConnect As String, roomID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_Get", roomID), IDataReader)
    End Function
    Public Overrides Function CMS_Room_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Room_List_OnlyMe(PortalConnect As String, appID As String, flag As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_List_OnlyMe", appID, flag, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Room_List_Search(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_List_Search", key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Room_List_App(PortalConnect As String, appID As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_List_App", appID, key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Room_List_Admin(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As Integer, gioiTinh As Integer, tienIch As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Room_List_Admin", key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), IDataReader)
    End Function
    Public Overrides Function CMS_Room_Add(PortalConnect As String, obj As CMS_RoomInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Room_Add", obj.AppID, obj.TieuDe, flReg.GetNull(obj.NoiDung), flReg.GetNull(obj.LoaiPhong), flReg.GetNull(obj.SoPhong), flReg.GetNull(obj.SucChua), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.DienTich), flReg.GetNull(obj.GiaPhong), flReg.GetNull(obj.DatCoc), flReg.GetNull(obj.TienDien), flReg.GetNull(obj.TienNuoc), flReg.GetNull(obj.TienMang), flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.DuongPho), flReg.GetNull(obj.DienThoaiLH), flReg.GetNull(obj.GioMoCua), flReg.GetNull(obj.GioDongCua), obj.IsStatus, flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate)), Integer)
    End Function
    Public Overrides Sub CMS_Room_Update(PortalConnect As String, obj As CMS_RoomInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Room_Update", obj.RoomID, obj.AppID, obj.TieuDe, flReg.GetNull(obj.NoiDung), flReg.GetNull(obj.LoaiPhong), flReg.GetNull(obj.SoPhong), flReg.GetNull(obj.SucChua), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.DienTich), flReg.GetNull(obj.GiaPhong), flReg.GetNull(obj.DatCoc), flReg.GetNull(obj.TienDien), flReg.GetNull(obj.TienNuoc), flReg.GetNull(obj.TienMang), flReg.GetNull(obj.TinhTP), flReg.GetNull(obj.QuanHuyen), flReg.GetNull(obj.XaPhuong), flReg.GetNull(obj.DuongPho), flReg.GetNull(obj.DienThoaiLH), flReg.GetNull(obj.GioMoCua), flReg.GetNull(obj.GioDongCua), obj.IsStatus, flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate))
    End Sub
    Public Overrides Sub CMS_Room_Delete(PortalConnect As String, roomID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Room_Delete", roomID)
    End Sub
    Public Overrides Function CMS_Room_Update_Status(PortalConnect As String, RoomID As Integer, IsStatus As Integer, UpdateUser As String, UpdateDate As DateTime) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Room_Update_Status", RoomID, IsStatus, UpdateUser, UpdateDate), String)
    End Function
#End Region
#Region "CMS_RoomC"
    Public Overrides Function CMS_RoomC_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_RoomC_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomC_List"), IDataReader)
    End Function
    Public Overrides Function CMS_RoomC_List_Search(PortalConnect As String, roomID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomC_List_Search", roomID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_RoomC_Add(PortalConnect As String, obj As CMS_RoomCInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Add", obj.RoomID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate), Integer)
    End Function
    Public Overrides Sub CMS_RoomC_Update(PortalConnect As String, obj As CMS_RoomCInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Update", obj.ID, obj.RoomID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate)
    End Sub
    Public Overrides Function CMS_RoomC_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Get_By_CMS_Room", roomID), IDataReader)
    End Function
    Public Overrides Sub CMS_RoomC_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Delete_By_CMS_Room", roomID)
    End Sub
    Public Overrides Sub CMS_RoomC_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomC_Delete", iD)
    End Sub
#End Region
#Region "CMS_RoomF"
    Public Overrides Function CMS_TypeZoom_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TypeZoom_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Utility_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Utility_Get", id), IDataReader)
    End Function

    Public Overrides Function CMS_RoomF_Get(PortalConnect As String, attach_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Get", attach_ID), IDataReader)
    End Function
    Public Overrides Function CMS_RoomF_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomF_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_RoomF_Add(PortalConnect As String, obj As CMS_RoomFInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Add", obj.Attach_ID, obj.RoomID, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_RoomF_Update(PortalConnect As String, obj As CMS_RoomFInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Update", obj.Attach_ID, obj.RoomID, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Function CMS_RoomF_Get_By_CMS_Room(PortalConnect As String, roomID As Integer, loaiPhong As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Get_By_CMS_Room", roomID, loaiPhong), IDataReader)
    End Function
    Public Overrides Function CMS_RoomF_Get_By_CMS_Room_ID(PortalConnect As String, roomID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Get_By_CMS_Room_ID", roomID), IDataReader)
    End Function
    Public Overrides Sub CMS_RoomF_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Delete_By_CMS_Room", roomID)
    End Sub
    Public Overrides Sub CMS_RoomF_Delete(PortalConnect As String, attach_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomF_Delete", attach_ID)
    End Sub
#End Region
#Region "CMS_RoomU"
    Public Overrides Function CMS_RoomU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_RoomU_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomU_List"), IDataReader)
    End Function

    Public Overrides Function CMS_RoomU_Add(PortalConnect As String, obj As CMS_RoomUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Add", flReg.GetNull(obj.RoomID), flReg.GetNull(obj.UtilityID)), Integer)
    End Function
    Public Overrides Sub CMS_RoomU_Update(PortalConnect As String, obj As CMS_RoomUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Update", obj.ID, flReg.GetNull(obj.RoomID), flReg.GetNull(obj.UtilityID))
    End Sub
    Public Overrides Function CMS_RoomU_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Get_By_CMS_Room", roomID), IDataReader)
    End Function
    Public Overrides Sub CMS_RoomU_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Delete_By_CMS_Room", roomID)
    End Sub
    Public Overrides Sub CMS_RoomU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_RoomU_Delete", iD)
    End Sub
#End Region
#Region "CMS_Fr_Notify"
    Public Overrides Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Notify_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Notify_List_AppID(PortalConnect As String, uID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_List_AppID", uID, appID, currPage, recodPage, flags), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Notify_List_New(PortalConnect As String, uID As Integer, appID As String, flags As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_List_New", uID, appID, flags), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, uID As Integer, appID As String, flags As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_List_UnNew", uID, appID, flags)
    End Sub
    Public Overrides Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_Add", obj.UID, obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags), obj.AllPublic), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_Update", obj.UID, obj.ID, obj.FromApp, obj.ToApp, obj.Contents, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.ToLink), flReg.GetNull(obj.IdKey), flReg.GetNull(obj.Flags))
    End Sub
    Public Overrides Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Notify_Delete", iD)
    End Sub
#End Region
#Region "CMS_Fr_Comment"
    Public Overrides Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Get", comment_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Add", obj.Post_ID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate, obj.UpdatedDate), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Update", obj.Comment_ID, obj.Post_ID, obj.AppID, obj.Contents, obj.Reply, obj.CreatedDate, obj.UpdatedDate)
    End Sub
    Public Overrides Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Update_Lock", commentID, lock, lockUser)
    End Sub
    Public Overrides Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_Delete", comment_ID)
    End Sub
#End Region
#Region "CMS_Fr_Likes"
    Public Overrides Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_Get", likesID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Likes_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_Add", obj.AppID, obj.PostID, obj.CreatedDate), Integer)
    End Function
    Public Overrides Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_Update", obj.LikesID, obj.AppID, obj.PostID, obj.CreatedDate)
    End Sub
    Public Overrides Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Likes_Delete", appID, postID)
    End Sub
#End Region
#Region "CMS_Fr_Post"
    Public Overrides Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_Get", post_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Search(PortalConnect As String, uID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List_Search", uID, search, isOrder, currPage, recodperpage, appID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Group(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List_Group", uID, GroupID, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List_Group_Web", uID, GroupID, search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_Admin(PortalConnect As String, uID As Integer, isLock As Integer, appID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List_Admin", uID, isLock, appID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, uID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_List_OnlyMe", appID, uID, search, currPage, recodperpage, appFriend), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_Add", obj.GroupID, obj.UID, obj.AppID, obj.Contents, obj.CreatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends, obj.PostShareID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_Update", obj.UID, obj.Post_ID, obj.AppID, obj.Contents, obj.CreatedDate, obj.UpdatedDate, obj.PublicAll, obj.OnlyMe, obj.Friends)
    End Sub
    Public Overrides Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_Update_Lock", postID, lock, lockuser)
    End Sub
    Public Overrides Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Post_Delete", post_ID)
    End Sub
#End Region
#Region "CMS_Fr_SharePost"
    Public Overrides Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_SharePost_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_List_Search", postID, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_Update", obj.SharePost_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_SharePost_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_ShareUser"
    Public Overrides Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_Get", sharePost_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_List_Search", search, currPage, recodperpage, postID), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_Add", obj.Post_ID, obj.ShareAppID), Integer)
    End Function
    Public Overrides Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_Count_ByPostID", postID, appID), Integer)
    End Function
    Public Overrides Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_Update", obj.ShareUser_ID, obj.Post_ID, obj.ShareAppID)
    End Sub
    Public Overrides Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_ShareUser_Delete", sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_FileAttach"
    Public Overrides Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_Get", attach_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_List_ByIdKey", idKey, type, top), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_Add", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_Update", obj.Attach_ID, obj.IdKey, obj.FileAttach, obj.FileType, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_FileAttach_Delete", attach_ID)
    End Sub
#End Region
#Region "CMS_Dash"
    Public Overrides Function CMS_DashBoard(PortalConnect As String, bussinessID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_DashBoard", bussinessID, yearID), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_LeaveOfAbs(PortalConnect As String, bussinessID As Integer, yearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_DashBoard_LeaveOfAbs", bussinessID, yearID), IDataReader)
    End Function
#End Region
#Region "CMS_Calender"
    Public Overrides Function CMS_Calender_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Calender_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Calender_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Calender_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Calender_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, BusID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Calender_List_Search", currPage, recodperpage, BusID), IDataReader)
    End Function

    Public Overrides Function CMS_Calender_Add(PortalConnect As String, obj As CMS_CalenderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Calender_Add", obj.BusID, obj.CalName, obj.Years, obj.Calender, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Calender_Update(PortalConnect As String, obj As CMS_CalenderInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Calender_Update", obj.ID, obj.BusID, obj.CalName, obj.Years, obj.Calender, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Calender_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Calender_Delete", iD)
    End Sub
#End Region
#Region "CMS_Dispute"
    Public Overrides Function CMS_LyDo_Get(PortalConnect As String, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LyDo_Get", ID), IDataReader)
    End Function
    Public Overrides Function CMS_LyDo_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_LyDo_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Dispute_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Dispute_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Dispute_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Dispute_List_Search(PortalConnect As String, search As String, uID As Integer, dID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Dispute_List_Search", search, uID, dID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Dispute_Active(PortalConnect As String, iD As Integer, isSet As Integer, setUserName As String, setDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Active", iD, isSet, setUserName, setDate)
    End Sub
    Public Overrides Sub CMS_Dispute_Update_Active(PortalConnect As String, iD As Integer, SetActive As Integer, setUserName As String, setDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Update_Active", iD, SetActive, setUserName, setDate)
    End Sub
    Public Overrides Function CMS_Dispute_Add(PortalConnect As String, obj As CMS_DisputeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Add", obj.UID, obj.EID, flReg.GetNull(obj.DID), flReg.GetNull(obj.FromApp), flReg.GetNull(obj.ToApp), flReg.GetNull(obj.SetActive), flReg.GetNull(obj.SetUserName), flReg.GetNull(obj.SetDatetime)), Integer)
    End Function
    Public Overrides Sub CMS_Dispute_Update(PortalConnect As String, obj As CMS_DisputeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Update", obj.ID, obj.UID, obj.EID, flReg.GetNull(obj.DID), flReg.GetNull(obj.FromApp), flReg.GetNull(obj.ToApp), flReg.GetNull(obj.SetActive), flReg.GetNull(obj.SetUserName), flReg.GetNull(obj.SetDatetime))
    End Sub
    Public Overrides Sub CMS_Dispute_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Dispute_Delete", iD)
    End Sub
#End Region
#Region "CMS_Meeting"
    Public Overrides Function CMS_Meeting_Check_By_Reg(PortalConnect As String, uid As Integer, mR_ID As Integer, months As Integer, years As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Check_By_Reg", uid, mR_ID, months, years), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_Get(PortalConnect As String, meeting_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Get", meeting_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_Get_By_Day(PortalConnect As String, uid As Integer, startDate As DateTime, endDate As DateTime, room_id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Get_By_Day", uid, startDate, endDate, room_id), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_List_Search(PortalConnect As String, UID As Integer, DID As String, EID As String, MR_ID As String, MonthID As Integer, YearID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_List_Search", UID, DID, EID, MR_ID, MonthID, YearID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_List_AppID(PortalConnect As String, UID As Integer, appID As String, EID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_List_AppID", UID, appID, EID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_Get_FromHour(PortalConnect As String, mR_ID As Integer, toDate As DateTime) As DateTime
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Get_FromHour", mR_ID, toDate), DateTime)
    End Function
    Public Overrides Function CMS_Meeting_Rpt_Group(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Rpt_Group", UID, ngay, thang, nam), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_Rpt_List(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer, mrID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Rpt_List", UID, ngay, thang, nam, mrID), IDataReader)
    End Function
    Public Overrides Function CMS_Meeting_Add(PortalConnect As String, obj As CMS_MeetingInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Add", obj.AppID, obj.UID, obj.DID, obj.EID, obj.MR_ID, obj.MeetingName, obj.LeaderName, obj.StartDate, obj.EndDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Meeting_Update(PortalConnect As String, obj As CMS_MeetingInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Update", obj.AppID, obj.Meeting_ID, obj.UID, obj.DID, obj.EID, obj.MR_ID, obj.MeetingName, obj.LeaderName, obj.StartDate, obj.EndDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Meeting_Delete(PortalConnect As String, meeting_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Meeting_Delete", meeting_ID)
    End Sub
#End Region
#Region "CMS_MeetingRoom"
    Public Overrides Function CMS_MeetingRoom_Get(PortalConnect As String, mR_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_Get", mR_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MeetingRoom_Get_Mrcode(PortalConnect As String, MrCode As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_Get_Mrcode", MrCode, UID), IDataReader)
    End Function
    Public Overrides Function CMS_MeetingRoom_List(PortalConnect As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_List", UID), IDataReader)
    End Function
    Public Overrides Function CMS_MeetingRoom_List_search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_List_search", search, UID, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function CMS_MeetingRoom_Add(PortalConnect As String, obj As CMS_MeetingRoomInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_Add", obj.UID, obj.MR_Code, obj.MR_Name, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.MR_Des, obj.MR_Address), Integer)
    End Function
    Public Overrides Sub CMS_MeetingRoom_Update(PortalConnect As String, obj As CMS_MeetingRoomInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_Update", obj.MR_ID, obj.UID, obj.MR_Code, obj.MR_Name, obj.IsOrder, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.MR_Des, obj.MR_Address)
    End Sub
    Public Overrides Sub CMS_MeetingRoom_Delete(PortalConnect As String, mR_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_MeetingRoom_Delete", mR_ID)
    End Sub
#End Region
#Region "CMS_Mission"
    Public Overrides Function CMS_Mission_Get(PortalConnect As String, mission_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_Get", mission_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_List_AppID(PortalConnect As String, UID As Integer, appID As String, ToEID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_List_AppID", UID, appID, ToEID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_List_Manager(PortalConnect As String, UID As Integer, manageID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_List_Manager", UID, manageID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_List_Search(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_List_Search", UID, search, Status, yearID, MonthID, DiD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_List_Search_export(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Mission_List_Search_export", UID, search, Status, yearID, MonthID, DiD), IDataReader)
    End Function
    Public Overrides Function CMS_Mission_Add(PortalConnect As String, obj As CMS_MissionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Mission_Add", obj.AppID, obj.UID, obj.DID, obj.EID, flReg.GetNull(obj.ToEID), flReg.GetNull(obj.ToDID), obj.Mission_Purpose, obj.Mission_Departure, obj.Mission_Arrival, obj.StartDate, obj.EndDate, flReg.GetNull(obj.IsTimeKeep), flReg.GetNull(obj.ReCar), flReg.GetNull(obj.ManageID), flReg.GetNull(obj.ManageDep), obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Mission_Update_Manage(PortalConnect As String, Mission_ID As Integer, isActive As Boolean, userUpdate As String, dateUpdate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Mission_Update_Manage", Mission_ID, isActive, userUpdate, dateUpdate)
    End Sub
    Public Overrides Sub CMS_Mission_Update_First(PortalConnect As String, Mission_ID As Integer, FirstKm As Double, FirstDate As DateTime, FirstUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Mission_Update_First", Mission_ID, FirstKm, FirstDate, FirstUser)
    End Sub
    Public Overrides Sub CMS_Mission_Update_Last(PortalConnect As String, Mission_ID As Integer, lastKm As Double, lastDate As DateTime, lastUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Mission_Update_Last", Mission_ID, lastKm, lastDate, lastUser)
    End Sub
    Public Overrides Sub CMS_Mission_Update_Approval(PortalConnect As String, Mission_ID As Integer, IsApproval As Boolean, ApprovalDate As DateTime, ApprovalUser As String, CarID As String, DriverName As String, DriverPhone As String, DriverNumber As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Mission_Update_Approval", Mission_ID, IsApproval, ApprovalDate, ApprovalUser, CarID, DriverName, DriverPhone, DriverNumber)
    End Sub
    Public Overrides Sub CMS_Mission_Delete(PortalConnect As String, mission_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Mission_Delete", mission_ID)
    End Sub
#End Region
#Region "CMS_MissionCar"
    Public Overrides Function CMS_MissionCar_Get(PortalConnect As String, car_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_Get", car_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MissionCar_List(PortalConnect As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_List", UID), IDataReader)
    End Function
    Public Overrides Function CMS_MissionCar_List_search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_List_search", search, UID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_MissionCar_List_UID(PortalConnect As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_List_UID", UID), IDataReader)
    End Function
    Public Overrides Function CMS_MissionCar_Add(PortalConnect As String, obj As CMS_MissionCarInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_Add", obj.UID, obj.Car_Name, obj.Car_Des, flReg.GetNull(obj.Car_BKS), flReg.GetNull(obj.Car_Manu), flReg.GetNull(obj.Car_Number), flReg.GetNull(obj.DriverName), flReg.GetNull(obj.DriverPhone), obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_MissionCar_Update(PortalConnect As String, obj As CMS_MissionCarInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_Update", obj.Car_ID, obj.UID, obj.Car_Name, obj.Car_Des, flReg.GetNull(obj.Car_BKS), flReg.GetNull(obj.Car_Manu), flReg.GetNull(obj.Car_Number), flReg.GetNull(obj.DriverName), flReg.GetNull(obj.DriverPhone), obj.IsOrder, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_MissionCar_Delete(PortalConnect As String, car_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_MissionCar_Delete", car_ID)
    End Sub
#End Region
#Region "CMS_Group"
    Public Overrides Function CMS_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_List_Search", search, currPage, recodperpage, UID), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_UID(PortalConnect As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_List_UID", UID), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Group_Add", obj.UID, obj.Name, obj.Des, obj.IsStatus, obj.CreatedDate, obj.UpdatedDate, obj.CreatedUser, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_Update", obj.ID, obj.UID, obj.Name, obj.Des, obj.IsStatus, obj.CreatedDate, obj.UpdatedDate, obj.CreatedUser, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_Delete", iD)
    End Sub
#End Region
#Region "CMS_GroupU"
    Public Overrides Function CMS_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_GroupU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_GroupU_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_GroupU_List"), IDataReader)
    End Function
    Public Overrides Function CMS_GroupU_List_Search(PortalConnect As String, search As String, GroupId As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_GroupU_List_Search", search, GroupId, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_GroupU_count(PortalConnect As String, GroupId As Integer, UID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_GroupU_count", GroupId, UID), Integer)
    End Function
    Public Overrides Function CMS_GroupU_List_Send(PortalConnect As String, GroupID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_GroupU_List_Send", GroupID), IDataReader)
    End Function
    Public Overrides Function CMS_GroupU_Add(PortalConnect As String, obj As CMS_GroupUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_GroupU_Add", obj.GroupID, obj.AppID, obj.DepCode, obj.EmpCode, obj.AppName, obj.AppLogo), Integer)
    End Function
    Public Overrides Sub CMS_GroupU_Update(PortalConnect As String, obj As CMS_GroupUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_GroupU_Update", obj.ID, obj.GroupID, obj.AppID, obj.DepCode, obj.EmpCode, obj.AppName, obj.AppLogo)
    End Sub
    Public Overrides Function CMS_GroupU_Get_By_CMS_Group(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_GroupU_Get_By_CMS_Group", iD, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_GroupU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_GroupU_Delete", iD)
    End Sub
#End Region
#Region "CMS_Fr_Group"
    Public Overrides Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_List_AppID", uID, appID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_Add", obj.UID, obj.EID, obj.AppID, obj.Name, flReg.GetNull(obj.Logo), flReg.GetNull(obj.Des), obj.IsStatus, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_Update", obj.ID, obj.UID, obj.EID, obj.AppID, obj.Name, flReg.GetNull(obj.Logo), flReg.GetNull(obj.Des), obj.IsStatus, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_Delete", iD)
    End Sub
    Public Overrides Function CMS_Fr_Group_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_List_TK", uID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_TK(PortalConnect As String, uID As Integer, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_TK", uID, ID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_Group_ThongKe(PortalConnect As String, UID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_ThongKe", UID), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_NguoiDang(PortalConnect As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_NguoiDang", UID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_GroupTV(PortalConnect As String, UID As Integer, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupTV", UID, ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_Group_Update_Lock", ID, lock, lockuser)
    End Sub
#End Region
#Region "CMS_Fr_GroupU"
    Public Overrides Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Fr_GroupU_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_List"), IDataReader)
    End Function

    Public Overrides Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Add", obj.GroupID, obj.EID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), obj.IsBoss), Integer)
    End Function
    Public Overrides Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Update", obj.ID, obj.GroupID, obj.EID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser))
    End Sub
    Public Overrides Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Get_By_CMS_Fr_Group", iD, page, recod), IDataReader)
    End Function
    Public Overrides Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Delete_By_CMS_Fr_Group", iD)
    End Sub
    Public Overrides Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Fr_GroupU_Delete", iD)
    End Sub
#End Region
#Region "CMS_SalaryM"
    Public Overrides Function CMS_SalaryM_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_SalaryM_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_List"), IDataReader)
    End Function
    Public Overrides Function CMS_SalaryM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Get_By_UID", UID, thang, nam), IDataReader)
    End Function
    Public Overrides Function CMS_SalaryM_Add(PortalConnect As String, obj As CMS_SalaryMInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Add", obj.UID, obj.Months, obj.Years, obj.IsLock, obj.LockDate, obj.LockUser, obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Sub CMS_SalaryM_Update(PortalConnect As String, obj As CMS_SalaryMInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Update", obj.ID, obj.UID, obj.Months, obj.Years, obj.IsLock, obj.LockDate, obj.LockUser, obj.CreatedDate, obj.CreatedUser)
    End Sub
    Public Overrides Sub CMS_SalaryM_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Delete", iD)
    End Sub
    Public Overrides Sub CMS_SalaryM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Update_Lock", UID, thang, nam, isLock, lockDate, lockUser)
    End Sub
    Public Overrides Function CMS_SalaryM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_SalaryM_Update_ThacMac", UID, thang, nam, ThacMac), IDataReader)
    End Function
#End Region
#Region "CMS_TimeKeepM"
    Public Overrides Function CMS_TimeKeepM_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeepM_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeepM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Get_By_UID", UID, thang, nam), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeepM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Update_ThacMac", UID, thang, nam, ThacMac), IDataReader)
    End Function
    Public Overrides Function CMS_TimeKeepM_Add(PortalConnect As String, obj As CMS_TimeKeepMInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Add", obj.UID, obj.Months, obj.Years, obj.IsLock, obj.LockDate, obj.LockUser, obj.CreatedDate, obj.CreatedUser, obj.ThacMac), Integer)
    End Function
    Public Overrides Sub CMS_TimeKeepM_Update(PortalConnect As String, obj As CMS_TimeKeepMInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Update", obj.ID, obj.UID, obj.Months, obj.Years, obj.IsLock, obj.LockDate, obj.LockUser, obj.CreatedDate, obj.CreatedUser, obj.ThacMac)
    End Sub
    Public Overrides Sub CMS_TimeKeepM_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Delete", iD)
    End Sub
    Public Overrides Sub CMS_TimeKeepM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_TimeKeepM_Update_Lock", UID, thang, nam, isLock, lockDate, lockUser)
    End Sub
#End Region
#Region "CMS_Group_Chat"
    Public Overrides Function CMS_Group_Chat_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Chat_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Chat_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_List_AppID", uID, appID, search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Chat_Add(PortalConnect As String, obj As CMS_Group_ChatInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_Add", obj.UID, obj.EID, obj.AppID, obj.Name, flReg.GetNull(obj.Logo), obj.IsStatus, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser)), Integer)
    End Function
    Public Overrides Sub CMS_Group_Chat_Update(PortalConnect As String, obj As CMS_Group_ChatInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_Update", obj.ID, obj.UID, obj.EID, obj.AppID, obj.Name, flReg.GetNull(obj.Logo), obj.IsStatus, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), flReg.GetNull(obj.UpdatedUser))
    End Sub
    Public Overrides Sub CMS_Group_Chat_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_Delete", iD)
    End Sub
    Public Overrides Function CMS_Group_Chat_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_Chat_List_TK", uID, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_Group_ChatU"
    Public Overrides Function CMS_Group_ChatU_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Group_ChatU_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Group_ChatU_Add(PortalConnect As String, obj As CMS_Group_ChatUInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Add", obj.GroupID, obj.EID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser),obj.IsBoss), Integer)
    End Function
    Public Overrides Sub CMS_Group_ChatU_Update(PortalConnect As String, obj As CMS_Group_ChatUInfo)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Update", obj.ID, obj.GroupID, obj.EID, obj.AppID, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser))
    End Sub
    Public Overrides Function CMS_Group_ChatU_Get_By_CMS_Group_Chat(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Get_By_CMS_Group_Chat", iD, page, recod), IDataReader)
    End Function
    Public Overrides Sub CMS_Group_ChatU_Delete_By_CMS_Group_Chat(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Delete_By_CMS_Group_Chat", iD)
    End Sub
    Public Overrides Sub CMS_Group_ChatU_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.KengConnect(PortalConnect), "CMS_Group_ChatU_Delete", iD)
    End Sub



#End Region



End Class