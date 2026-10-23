Imports DotNetNuke.Common.Utilities
Public Class Kengcontroller

#Region "CMS_Employee"
    Public Function CMS_Employee_List_Send(PortalConnect As String, businessID As Integer, deparmentCode As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Send(PortalConnect, businessID, deparmentCode), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_Permistion(PortalConnect As String, uID As Integer, eID As String, dID As String) As Integer
        Return DataProvider.Instance().CMS_Employee_Permistion(PortalConnect, uID, eID, dID)
    End Function
    Public Function CMS_Employee_Get(PortalConnect As String, employee_ID As String) As CMS_EmployeeInfo
        Return CBO.FillObject(Of CMS_EmployeeInfo)(DataProvider.Instance().CMS_Employee_Get(PortalConnect, employee_ID))
    End Function
    Public Function CMS_Employee_GetByCode(PortalConnect As String, uID As Integer, empCode As String) As CMS_EmployeeInfo
        Return CBO.FillObject(Of CMS_EmployeeInfo)(DataProvider.Instance().CMS_Employee_GetByCode(PortalConnect, uID, empCode))
    End Function
    Public Function CMS_Employee_Get_By_AppID(PortalConnect As String, uID As Integer, appID As String) As CMS_EmployeeInfo
        Return CBO.FillObject(Of CMS_EmployeeInfo)(DataProvider.Instance().CMS_Employee_Get_By_AppID(PortalConnect, uID, appID))
    End Function
    Public Function CMS_Employee_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List(PortalConnect), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Manager(PortalConnect As String, businessID As Integer, deparmentCode As String, isManager As Int16, currPage As Integer, recodperpage As Integer, Optional ByVal Search As String = "") As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Manager(PortalConnect, businessID, deparmentCode, isManager, currPage, recodperpage, Search), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Manager_Abs(PortalConnect As String, businessID As Integer, empCode As String, deparmentCode As String, currPage As Integer, recodperpage As Integer, Optional ByVal Search As String = "") As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Manager_Abs(PortalConnect, businessID, empCode, deparmentCode, currPage, recodperpage, Search), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_Add(PortalConnect As String, obj As CMS_EmployeeInfo) As String
        Return DataProvider.Instance().CMS_Employee_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Employee_Update(PortalConnect As String, obj As CMS_EmployeeInfo)
        DataProvider.Instance().CMS_Employee_Update(PortalConnect, obj)
    End Sub
    Public Function CMS_Employee_CountChat(PortalConnect As String, uID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Employee_CountChat(PortalConnect, uID, appID)
    End Function
    Public Function CMS_Employee_Update_Status(PortalConnect As String, obj As CMS_EmployeeInfo) As String
        Return DataProvider.Instance().CMS_Employee_Update_Status(PortalConnect, obj)
    End Function
    Public Sub CMS_Employee_Delete(PortalConnect As String, employee_ID As String)
        DataProvider.Instance().CMS_Employee_Delete(PortalConnect, employee_ID)
    End Sub
    Public Function CMS_Employee_Update_App(PortalConnect As String, EmployeeCode As String, BusinessID As Integer, DepartmentCode As String, AppID As String, AppLogo As String) As String
        Return DataProvider.Instance().CMS_Employee_Update_App(PortalConnect, EmployeeCode, BusinessID, DepartmentCode, AppID, AppLogo)
    End Function
    Public Function CMS_Employee_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, businessID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Search(PortalConnect, search, currPage, recodperpage, businessID), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_By_UID(PortalConnect As String, businessID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_By_UID(PortalConnect, businessID), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Group_Select(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, eID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Group_Select(PortalConnect, search, currPage, recodperpage, uID, eID), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Cache(PortalConnect As String, uID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Cache(PortalConnect, uID), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Chat(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Chat(PortalConnect, search, currPage, recodperpage, uID, appID), GetType(CMS_EmployeeInfo))
    End Function

    Public Function CMS_Employee_List_Admin(PortalConnect As String, search As String, businessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Admin(PortalConnect, search, businessID, IsStatus, yearID, monthID, DepartmentCode, currPage, recodperpage), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Admin_Eports(PortalConnect As String, search As String, businessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Admin_Eports(PortalConnect, search, businessID, IsStatus, yearID, monthID, DepartmentCode), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Select(PortalConnect As String, search As String, businessID As Integer, GroupID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Select(PortalConnect, search, businessID, GroupID, DepartmentCode, currPage, recodperpage), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_Employee_List_Group(PortalConnect As String, search As String, businessID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer, ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Employee_List_Group(PortalConnect, search, businessID, DepartmentCode, currPage, recodperpage, ID), GetType(CMS_EmployeeInfo))
    End Function
#End Region
#Region "CMS_Salary"
    Public Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As CMS_SalaryInfo
        Return CBO.FillObject(Of CMS_SalaryInfo)(DataProvider.Instance().CMS_Salary_Get(PortalConnect, salary_ID))
    End Function
    Public Function CMS_Salary_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List(PortalConnect), GetType(CMS_SalaryInfo))
    End Function
    Public Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List_Search(PortalConnect, search, isOrder, yearID, monthID, currPage, recodperpage, bID, DepartmentCode, isStatus), GetType(CMS_SalaryInfo))
    End Function
    Public Function CMS_Salary_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List_By_AppID(PortalConnect, BusinessID, EmployeeCode, DepartmentCode, currPage, recodperpage), GetType(CMS_SalaryInfo))
    End Function
    Public Sub CMS_Salary_Update_Sent(PortalConnect As String, salary_ID As String, IsSent As Boolean)
        DataProvider.Instance().CMS_Salary_Update_Sent(PortalConnect, salary_ID, IsSent)
    End Sub
    Public Function CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo) As String
        Return DataProvider.Instance().CMS_Salary_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().CMS_Salary_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        DataProvider.Instance().CMS_Salary_Delete(PortalConnect, salary_ID)
    End Sub

    Public Sub CMS_SendNotify_Sent(PortalConnect As String, sID As String, Type As String)
        DataProvider.Instance().CMS_SendNotify_Sent(PortalConnect, sID, Type)
    End Sub
#End Region
#Region "CMS_TimeKeep"
    Public Function CMS_TimeKeep_Get(PortalConnect As String, timeKeep_ID As String) As CMS_TimeKeepInfo
        Return CBO.FillObject(Of CMS_TimeKeepInfo)(DataProvider.Instance().CMS_TimeKeep_Get(PortalConnect, timeKeep_ID))
    End Function
    Public Function CMS_TimeKeep_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TimeKeep_List(PortalConnect), GetType(CMS_TimeKeepInfo))
    End Function
    Public Function CMS_TimeKeep_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TimeKeep_List_Search(PortalConnect, search, isOrder, yearID, monthID, currPage, recodperpage, bID, DepartmentCode, isStatus), GetType(CMS_TimeKeepInfo))
    End Function
    Public Function CMS_TimeKeep_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TimeKeep_List_By_AppID(PortalConnect, BusinessID, EmployeeCode, DepartmentCode, currPage, recodperpage), GetType(CMS_TimeKeepInfo))
    End Function
    Public Function CMS_TimeKeep_Add(PortalConnect As String, obj As CMS_TimeKeepInfo) As String
        Return DataProvider.Instance().CMS_TimeKeep_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TimeKeep_Update(PortalConnect As String, obj As CMS_TimeKeepInfo)
        DataProvider.Instance().CMS_TimeKeep_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TimeKeep_Update_Sent(PortalConnect As String, timeKeep_ID As String, IsSent As Boolean)
        DataProvider.Instance().CMS_TimeKeep_Update_Sent(PortalConnect, timeKeep_ID, IsSent)
    End Sub
    Public Sub CMS_TimeKeep_Delete(PortalConnect As String, timeKeep_ID As String)
        DataProvider.Instance().CMS_TimeKeep_Delete(PortalConnect, timeKeep_ID)
    End Sub
#End Region
#Region "CMS_TypeZoom"
    Public Function CMS_TypeZoom_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeZoom_List(PortalConnect), GetType(CMS_TypeZoomInfo))
    End Function
#End Region
#Region "CMS_Utility"
    Public Function CMS_Utility_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Utility_List(PortalConnect), GetType(CMS_UtilityInfo))
    End Function
#End Region
#Region "CMS_LeaveOfAbs"
    Public Function CMS_LeaveOfAbs_List_By_BusActive(PortalConnect As String, uID As Integer, month As Integer, years As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List_By_BusActive(PortalConnect, uID, month, years), GetType(CMS_LeaveOfAbsInfo))
    End Function
    Public Sub CMS_LeaveOfAbs_Update_By_BusActive(PortalConnect As String, uID As Integer, leaveOfAbs_ID As String)
        DataProvider.Instance().CMS_LeaveOfAbs_Update_By_BusActive(PortalConnect, uID, leaveOfAbs_ID)
    End Sub
    Public Function CMS_LeaveOfAbs_Get(PortalConnect As String, leaveOfAbs_ID As String) As CMS_LeaveOfAbsInfo
        Return CBO.FillObject(Of CMS_LeaveOfAbsInfo)(DataProvider.Instance().CMS_LeaveOfAbs_Get(PortalConnect, leaveOfAbs_ID))
    End Function
    Public Function CMS_LeaveOfAbs_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List(PortalConnect), GetType(CMS_LeaveOfAbsInfo))
    End Function
    Public Function CMS_LeaveOfAbs_List_Search(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer, appID As String, eID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List_Search(PortalConnect, uID, currPage, recodperpage, appID, eID), GetType(CMS_LeaveOfAbsInfo))
    End Function
    Public Function CMS_LeaveOfAbs_List_By_Receive(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List_By_Receive(PortalConnect, uID, currPage, recodperpage, appID), GetType(CMS_LeaveOfAbsInfo))
    End Function
    Public Function CMS_LeaveOfAbs_List_Search_Web(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List_Search_Web(PortalConnect, BusinessID, DepartmentCode, Thang, Nam, IsActive, key, currPage, recodperpage), GetType(CMS_LeaveOfAbsInfo))
    End Function
    Public Function CMS_LeaveOfAbs_List_Search_Web_export(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LeaveOfAbs_List_Search_Web_export(PortalConnect, BusinessID, DepartmentCode, Thang, Nam, IsActive, key), GetType(CMS_LeaveOfAbsInfo))
    End Function

    Public Sub CMS_LeaveOfAbs_Add(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
        DataProvider.Instance().CMS_LeaveOfAbs_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_LeaveOfAbs_Update(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
        DataProvider.Instance().CMS_LeaveOfAbs_Update(PortalConnect, obj)
    End Sub
    Public Function CMS_LeaveOfAbs_Active(PortalConnect As String, id As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
        Return DataProvider.Instance().CMS_LeaveOfAbs_Active(PortalConnect, id, isActive, activeUser, activeDate)
    End Function
    Public Function CMS_LeaveOfAbs_Active_New(PortalConnect As String, id As String, reason As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
        Return DataProvider.Instance().CMS_LeaveOfAbs_Active_New(PortalConnect, id, reason, isActive, activeUser, activeDate)
    End Function
    Public Sub CMS_LeaveOfAbs_Delete(PortalConnect As String, leaveOfAbs_ID As String)
        DataProvider.Instance().CMS_LeaveOfAbs_Delete(PortalConnect, leaveOfAbs_ID)
    End Sub
#End Region
#Region "CMS_Comment"
    Public Function CMS_Comment_Get(PortalConnect As String, comment_ID As Integer) As CMS_CommentInfo
        Return CBO.FillObject(Of CMS_CommentInfo)(DataProvider.Instance().CMS_Comment_Get(PortalConnect, comment_ID))
    End Function
    Public Function CMS_Comment_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Comment_List(PortalConnect), GetType(CMS_CommentInfo))
    End Function
    Public Function CMS_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Comment_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_CommentInfo))
    End Function

    Public Function CMS_Comment_Add(PortalConnect As String, obj As CMS_CommentInfo) As Integer
        Return DataProvider.Instance().CMS_Comment_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Comment_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Comment_Update(PortalConnect As String, obj As CMS_CommentInfo)
        DataProvider.Instance().CMS_Comment_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        DataProvider.Instance().CMS_Comment_Delete(PortalConnect, comment_ID)
    End Sub
#End Region
#Region "CMS_Likes"
    Public Function CMS_Likes_Get(PortalConnect As String, likesID As Integer) As CMS_LikesInfo
        Return CBO.FillObject(Of CMS_LikesInfo)(DataProvider.Instance().CMS_Likes_Get(PortalConnect, likesID))
    End Function
    Public Function CMS_Likes_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Likes_List(PortalConnect), GetType(CMS_LikesInfo))
    End Function
    Public Function CMS_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Likes_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_LikesInfo))
    End Function
    Public Function CMS_Likes_Add(PortalConnect As String, obj As CMS_LikesInfo) As Integer
        Return DataProvider.Instance().CMS_Likes_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Likes_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Likes_Update(PortalConnect As String, obj As CMS_LikesInfo)
        DataProvider.Instance().CMS_Likes_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        DataProvider.Instance().CMS_Likes_Delete(PortalConnect, appID, postID)
    End Sub
#End Region
#Region "CMS_Post"
    Public Function CMS_Post_Get(PortalConnect As String, post_ID As Integer) As CMS_PostInfo
        Return CBO.FillObject(Of CMS_PostInfo)(DataProvider.Instance().CMS_Post_Get(PortalConnect, post_ID))
    End Function
    Public Function CMS_Post_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Post_List(PortalConnect), GetType(CMS_PostInfo))
    End Function
    Public Function CMS_Post_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Post_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, appID), GetType(CMS_PostInfo))
    End Function
    Public Function CMS_Post_List_OnlyMe(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Post_List_OnlyMe(PortalConnect, search, currPage, recodperpage, appID), GetType(CMS_PostInfo))
    End Function
    Public Function CMS_Post_Add(PortalConnect As String, obj As CMS_PostInfo) As Integer
        Return DataProvider.Instance().CMS_Post_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Post_Update(PortalConnect As String, obj As CMS_PostInfo)
        DataProvider.Instance().CMS_Post_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Post_Delete(PortalConnect As String, post_ID As Integer)
        DataProvider.Instance().CMS_Post_Delete(PortalConnect, post_ID)
    End Sub
#End Region
#Region "CMS_SharePost"
    Public Function CMS_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_SharePostInfo
        Return CBO.FillObject(Of CMS_SharePostInfo)(DataProvider.Instance().CMS_SharePost_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_SharePost_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SharePost_List(PortalConnect), GetType(CMS_SharePostInfo))
    End Function
    Public Function CMS_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SharePost_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_SharePostInfo))
    End Function

    Public Function CMS_SharePost_Add(PortalConnect As String, obj As CMS_SharePostInfo) As Integer
        Return DataProvider.Instance().CMS_SharePost_Add(PortalConnect, obj)
    End Function
    Public Function CMS_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_SharePost_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_SharePost_Update(PortalConnect As String, obj As CMS_SharePostInfo)
        DataProvider.Instance().CMS_SharePost_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_SharePost_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_ShareUser"
    Public Function CMS_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_ShareUserInfo
        Return CBO.FillObject(Of CMS_ShareUserInfo)(DataProvider.Instance().CMS_ShareUser_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_ShareUser_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ShareUser_List(PortalConnect), GetType(CMS_ShareUserInfo))
    End Function
    Public Function CMS_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ShareUser_List_Search(PortalConnect, search, currPage, recodperpage, postID), GetType(CMS_ShareUserInfo))
    End Function
    Public Function CMS_ShareUser_Add(PortalConnect As String, obj As CMS_ShareUserInfo) As Integer
        Return DataProvider.Instance().CMS_ShareUser_Add(PortalConnect, obj)
    End Function
    Public Function CMS_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_ShareUser_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_ShareUser_Update(PortalConnect As String, obj As CMS_ShareUserInfo)
        DataProvider.Instance().CMS_ShareUser_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_ShareUser_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_FileAttach"
    Public Function CMS_FileAttach_Get(PortalConnect As String, attach_ID As String) As CMS_FileAttachInfo
        Return CBO.FillObject(Of CMS_FileAttachInfo)(DataProvider.Instance().CMS_FileAttach_Get(PortalConnect, attach_ID))
    End Function
    Public Function CMS_FileAttach_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttach_List(PortalConnect), GetType(CMS_FileAttachInfo))
    End Function
    Public Function CMS_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttach_List_ByIdKey(PortalConnect, idKey, type, top), GetType(CMS_FileAttachInfo))
    End Function
    Public Function CMS_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_FileAttach_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_FileAttachInfo))
    End Function

    Public Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
        DataProvider.Instance().CMS_FileAttach_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
        DataProvider.Instance().CMS_FileAttach_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        DataProvider.Instance().CMS_FileAttach_Delete(PortalConnect, attach_ID)
    End Sub
#End Region
#Region "CMS_RelationShip"
    Public Function CMS_RelationShip_Get_By_Friend(PortalConnect As String, appID As String, appFriend As String) As appFriend
        Return CBO.FillObject(Of appFriend)(DataProvider.Instance().CMS_RelationShip_Get_By_Friend(PortalConnect, appID, appFriend))
    End Function
    Public Function CMS_RelationShip_Get(PortalConnect As String, relationShip_ID As Integer) As CMS_RelationShipInfo
        Return CBO.FillObject(Of CMS_RelationShipInfo)(DataProvider.Instance().CMS_RelationShip_Get(PortalConnect, relationShip_ID))
    End Function
    Public Function CMS_RelationShip_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RelationShip_List(PortalConnect), GetType(CMS_RelationShipInfo))
    End Function
    Public Function CMS_RelationShip_List_Friend(PortalConnect As String, appID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RelationShip_List_Friend(PortalConnect, appID, currPage, recodperpage), GetType(CMS_RelationShipInfo))
    End Function
    Public Function CMS_RelationShip_List_FGroup(PortalConnect As String, appID As String, appFriend As String) As Integer
        Return DataProvider.Instance().CMS_RelationShip_List_FGroup(PortalConnect, appID, appFriend)
    End Function
    Public Function CMS_RelationShip_Get_By_App(PortalConnect As String, appID As String, appFriend As String) As Integer
        Return DataProvider.Instance().CMS_RelationShip_Get_By_App(PortalConnect, appID, appFriend)
    End Function
    Public Function CMS_RelationShip_Add(PortalConnect As String, obj As CMS_RelationShipInfo) As Integer
        Return DataProvider.Instance().CMS_RelationShip_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_RelationShip_Update(PortalConnect As String, relationShip_ID As Integer, status As Integer)
        DataProvider.Instance().CMS_RelationShip_Update(PortalConnect, relationShip_ID, status)
    End Sub
    Public Sub CMS_RelationShip_Delete(PortalConnect As String, relationShip_ID As Integer)
        DataProvider.Instance().CMS_RelationShip_Delete(PortalConnect, relationShip_ID)
    End Sub
#End Region
#Region "CMS_Chat"
    Public Function CMS_Chat_Get(PortalConnect As String, chat_ID As Integer) As CMS_ChatInfo
        Return CBO.FillObject(Of CMS_ChatInfo)(DataProvider.Instance().CMS_Chat_Get(PortalConnect, chat_ID))
    End Function
    Public Function CMS_Chat_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_List(PortalConnect), GetType(CMS_ChatInfo))
    End Function
    Public Function CMS_Chat_List_Search(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_List_Search(PortalConnect, fromAppID, toAppID, currPage, recodperpage), GetType(CMS_ChatInfo))
        Else
            CMS_Chat_List_Search = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Chat_List_Search", fromAppID, toAppID, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Chat_List_AppID(PortalConnect As String, fromAppID As String, toAppID As String, years As Integer, months As Integer, days As Integer, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_List_AppID(PortalConnect, fromAppID, toAppID, years, months, days, currPage, recodperpage), GetType(CMS_ChatInfo))
        Else
            CMS_Chat_List_AppID = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Chat_List_AppID", fromAppID, toAppID, years, months, days, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Chat_List_Group(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_List_Group(PortalConnect, fromAppID, toAppID, currPage, recodperpage), GetType(CMS_ChatInfo))
        Else
            CMS_Chat_List_Group = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Chat_List_Group", fromAppID, toAppID, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Chat_BoxList_AppID(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_BoxList_AppID(PortalConnect, fromAppID, toAppID, currPage, recodperpage), GetType(CMS_ChatInfo))
        Else
            CMS_Chat_BoxList_AppID = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Chat_BoxList_AppID", fromAppID, toAppID, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Chat_Group_BoxList_AppID(PortalConnect As String, appID As String, groupID As Integer, currPage As Integer, recodperpage As Integer, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Chat_Group_BoxList_AppID(PortalConnect, appID, groupID, currPage, recodperpage), GetType(CMS_ChatInfo))
        Else
            CMS_Chat_Group_BoxList_AppID = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Chat_Group_BoxList_AppID", appID, groupID, currPage, recodperpage).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Chat_Add(PortalConnect As String, obj As CMS_ChatInfo) As Integer
        Return DataProvider.Instance().CMS_Chat_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Chat_Update(PortalConnect As String, obj As CMS_ChatInfo)
        DataProvider.Instance().CMS_Chat_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Chat_Delete(PortalConnect As String, chat_ID As Integer)
        DataProvider.Instance().CMS_Chat_Delete(PortalConnect, chat_ID)
    End Sub
    Public Sub CMS_Chat_Update_Send(PortalConnect As String, chat_ID As Integer)
        DataProvider.Instance().CMS_Chat_Update_Send(PortalConnect, chat_ID)
    End Sub
    Public Sub CMS_Chat_Update_Status(PortalConnect As String, fromAppID As String, toAppID As String)
        DataProvider.Instance().CMS_Chat_Update_Status(PortalConnect, fromAppID, toAppID)
    End Sub
    Public Sub CMS_Chat_Update_Status_Group(PortalConnect As String, AppID As String, GroupID As Integer)
        DataProvider.Instance().CMS_Chat_Update_Status_Group(PortalConnect, AppID, GroupID)
    End Sub
#End Region
#Region "CMS_Department"
    Public Function CMS_Department_Get(PortalConnect As String, departmentID As Integer) As CMS_DepartmentInfo
        Return CBO.FillObject(Of CMS_DepartmentInfo)(DataProvider.Instance().CMS_Department_Get(PortalConnect, departmentID))
    End Function
    Public Function CMS_Department_Get_ID(PortalConnect As String, departmentCode As String) As CMS_DepartmentInfo
        Return CBO.FillObject(Of CMS_DepartmentInfo)(DataProvider.Instance().CMS_Department_Get_ID(PortalConnect, departmentCode))
    End Function
    Public Function CMS_Department_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List(PortalConnect), GetType(CMS_DepartmentInfo))
    End Function
    Public Function CMS_Department_List_ByParentID(PortalConnect As String, parent_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List_ByParentID(PortalConnect, parent_ID), GetType(CMS_DepartmentInfo))
    End Function
    Public Function CMS_Department_List_bID(PortalConnect As String, bID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List_bID(PortalConnect, bID), GetType(CMS_DepartmentInfo))
    End Function
    Public Function CMS_Department_List_BID_Parent(PortalConnect As String, bID As Integer, ParentID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List_BID_Parent(PortalConnect, bID, ParentID), GetType(CMS_DepartmentInfo))
    End Function
    Public Function CMS_Department_List_Search(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List_Search(PortalConnect, search, fullText, isOrder, currPage, recodperpage, UserName, Business_ID), GetType(CMS_DepartmentInfo))
    End Function
    Public Function CMS_Department_List_ParentNull(PortalConnect As String, search As String, fullText As String, Business_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Department_List_ParentNull(PortalConnect, search, fullText, Business_ID), GetType(CMS_DepartmentInfo))
    End Function

    Public Function CMS_Department_Add(PortalConnect As String, obj As CMS_DepartmentInfo) As Integer
        Return DataProvider.Instance().CMS_Department_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Department_Update(PortalConnect As String, obj As CMS_DepartmentInfo)
        DataProvider.Instance().CMS_Department_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Department_Delete(PortalConnect As String, departmentID As Integer)
        DataProvider.Instance().CMS_Department_Delete(PortalConnect, departmentID)
    End Sub
#End Region
#Region "CMS_UserHeart"
    Public Function CMS_UserHeart_Get(PortalConnect As String, iD As Integer) As CMS_UserHeartInfo
        Return CBO.FillObject(Of CMS_UserHeartInfo)(DataProvider.Instance().CMS_UserHeart_Get(PortalConnect, iD))
    End Function
    Public Function CMS_UserHeart_Get_App(PortalConnect As String, appID As String) As CMS_UserHeartInfo
        Return CBO.FillObject(Of CMS_UserHeartInfo)(DataProvider.Instance().CMS_UserHeart_Get_App(PortalConnect, appID))
    End Function
    Public Function CMS_UserHeart_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UserHeart_List(PortalConnect), GetType(CMS_UserHeartInfo))
    End Function
    Public Function CMS_UserHeart_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UserHeart_List_Search(PortalConnect, currPage, recodperpage, UserName), GetType(CMS_UserHeartInfo))
    End Function

    Public Function CMS_UserHeart_Add(PortalConnect As String, obj As CMS_UserHeartInfo) As Integer
        Return DataProvider.Instance().CMS_UserHeart_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_UserHeart_Update(PortalConnect As String, obj As CMS_UserHeartInfo)
        DataProvider.Instance().CMS_UserHeart_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_UserHearte_Update_Quick(PortalConnect As String, obj As CMS_UserHeartInfo)
        DataProvider.Instance().CMS_UserHearte_Update_Quick(PortalConnect, obj)
    End Sub
    Public Sub CMS_UserHeart_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_UserHeart_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_CateDetail"
    Public Function CMS_CateDetail_List_ByGroup(PortalConnect As String, GroupID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CateDetail_List_ByGroup(PortalConnect, GroupID), GetType(CMS_CateDetailInfo))
    End Function
    Public Function CMS_CateDetail_Get(PortalConnect As String, CateDetail_ID As Integer) As CMS_CateDetailInfo
        Return CBO.FillObject(Of CMS_CateDetailInfo)(DataProvider.Instance().CMS_CateDetail_Get(PortalConnect, CateDetail_ID))
    End Function

#End Region
#Region "CMS_Notify"
    Public Function CMS_Notify_Get(PortalConnect As String, iD As Integer) As CMS_NotifyInfo
        Return CBO.FillObject(Of CMS_NotifyInfo)(DataProvider.Instance().CMS_Notify_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Notify_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Notify_List(PortalConnect), GetType(CMS_NotifyInfo))
    End Function
    Public Function CMS_Notify_List_AppID(PortalConnect As String, appID As String, currPage As Integer, recodPage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Notify_List_AppID(PortalConnect, appID, currPage, recodPage), GetType(CMS_NotifyInfo))
    End Function
    Public Function CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo) As Integer
        Return DataProvider.Instance().CMS_Notify_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
        DataProvider.Instance().CMS_Notify_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Notify_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Notify_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Answer"
    Public Function CMS_Answer_Get(PortalConnect As String, answer_ID As String) As CMS_AnswerInfo
        Return CBO.FillObject(Of CMS_AnswerInfo)(DataProvider.Instance().CMS_Answer_Get(PortalConnect, answer_ID))
    End Function
    Public Function CMS_Answer_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Answer_List(PortalConnect), GetType(CMS_AnswerInfo))
    End Function
    Public Function CMS_Answer_Get_By_CMS_Question(PortalConnect As String, question_ID As String) As CMS_AnswerInfo
        Return CBO.FillObject(Of CMS_AnswerInfo)(DataProvider.Instance().CMS_Answer_Get_By_CMS_Question(PortalConnect, question_ID))
    End Function
    Public Function CMS_Answer_Get_By_Question_Home(PortalConnect As String, question_ID As String) As CMS_AnswerInfo
        Return CBO.FillObject(Of CMS_AnswerInfo)(DataProvider.Instance().CMS_Answer_Get_By_Question_Home(PortalConnect, question_ID))
    End Function
    Public Sub CMS_Answer_Add(PortalConnect As String, obj As CMS_AnswerInfo)
        DataProvider.Instance().CMS_Answer_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Answer_Update(PortalConnect As String, obj As CMS_AnswerInfo)
        DataProvider.Instance().CMS_Answer_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Answer_Delete(PortalConnect As String, answer_ID As String)
        DataProvider.Instance().CMS_Answer_Delete(PortalConnect, answer_ID)
    End Sub
#End Region
#Region "CMS_Question"
    Public Function CMS_Question_List_Month(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer, Years As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_Month(PortalConnect, UID, EID, DID, Flags, Years), GetType(APP.ValueInfo))
    End Function
    Public Function CMS_Question_List_Year(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_Year(PortalConnect, UID, EID, DID, Flags), GetType(APP.ValueInfo))
    End Function
    Public Function CMS_Question_Get(PortalConnect As String, question_ID As String) As CMS_QuestionInfo
        Return CBO.FillObject(Of CMS_QuestionInfo)(DataProvider.Instance().CMS_Question_Get(PortalConnect, question_ID))
    End Function
    Public Function CMS_Question_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List(PortalConnect), GetType(CMS_QuestionInfo))
    End Function
    Public Function CMS_Question_List_ForApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_ForApp(PortalConnect, uID, appID, curpage, recordPage, isType), GetType(CMS_QuestionInfo))
    End Function
    Public Function CMS_Question_List_GroupApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_GroupApp(PortalConnect, uID, appID, curpage, recordPage, isType), GetType(CMS_QuestionInfo))
    End Function
    Public Function CMS_Question_List_GroupApp_Details(PortalConnect As String, uID As Integer, appID As String, Months As Integer, Years As Integer, isType As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_GroupApp_Details(PortalConnect, uID, appID, Months, Years, isType), GetType(CMS_QuestionInfo))
    End Function
    Public Sub CMS_Question_Add(PortalConnect As String, obj As CMS_QuestionInfo)
        DataProvider.Instance().CMS_Question_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Question_Update(PortalConnect As String, obj As CMS_QuestionInfo)
        DataProvider.Instance().CMS_Question_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Question_Update_Status(PortalConnect As String, quesID As String, status As Integer)
        DataProvider.Instance().CMS_Question_Update_Status(PortalConnect, quesID, status)
    End Sub
    Public Sub CMS_Question_Delete(PortalConnect As String, question_ID As String)
        DataProvider.Instance().CMS_Question_Delete(PortalConnect, question_ID)
    End Sub
    Public Function CMS_Question_List_Search(PortalConnect As String, Key As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer, busID As Integer, years As String, months As String, types As Integer, status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_Search(PortalConnect, Key, DepartmentCode, currPage, recodperpage, busID, years, months, types, status), GetType(CMS_QuestionInfo))
    End Function
    Public Function CMS_Question_List_App(PortalConnect As String, EmployeeCode As String, DepartmentCode As String, busID As Integer, years As String, months As String, types As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Question_List_App(PortalConnect, EmployeeCode, DepartmentCode, busID, years, months, types), GetType(CMS_QuestionInfo))
    End Function
#End Region
#Region "CMS_Room"
    Public Function CMS_Room_Get(PortalConnect As String, roomID As Integer) As CMS_RoomInfo
        Return CBO.FillObject(Of CMS_RoomInfo)(DataProvider.Instance().CMS_Room_Get(PortalConnect, roomID))
    End Function
    Public Function CMS_Room_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Room_List(PortalConnect), GetType(CMS_RoomInfo))
    End Function
    Public Function CMS_Room_List_OnlyMe(PortalConnect As String, appID As String, flag As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Room_List_OnlyMe(PortalConnect, appID, flag, page, recod), GetType(CMS_RoomInfo))
    End Function
    Public Function CMS_Room_List_Search(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Room_List_Search(PortalConnect, key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), GetType(CMS_RoomInfo))
    End Function
    Public Function CMS_Room_List_App(PortalConnect As String, appID As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Room_List_App(PortalConnect, appID, key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), GetType(CMS_RoomInfo))
    End Function
    Public Function CMS_Room_List_Admin(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As Integer, gioiTinh As Integer, tienIch As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Room_List_Admin(PortalConnect, key, tinh, huyen, xa, giaTu, giaDen, loaiPhong, gioiTinh, tienIch, page, recod), GetType(CMS_RoomInfo))
    End Function
    Public Function CMS_Room_Add(PortalConnect As String, obj As CMS_RoomInfo) As Integer
        Return DataProvider.Instance().CMS_Room_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Room_Update(PortalConnect As String, obj As CMS_RoomInfo)
        DataProvider.Instance().CMS_Room_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Room_Delete(PortalConnect As String, roomID As Integer)
        DataProvider.Instance().CMS_Room_Delete(PortalConnect, roomID)
    End Sub
    Public Function CMS_Room_Update_Status(PortalConnect As String, RoomID As Integer, IsStatus As Integer, UpdateUser As String, UpdateDate As DateTime) As String
        Return DataProvider.Instance().CMS_Room_Update_Status(PortalConnect, RoomID, IsStatus, UpdateUser, UpdateDate)
    End Function
#End Region
#Region "CMS_RoomC"
    Public Function CMS_RoomC_Get(PortalConnect As String, iD As Integer) As CMS_RoomCInfo
        Return CBO.FillObject(Of CMS_RoomCInfo)(DataProvider.Instance().CMS_RoomC_Get(PortalConnect, iD))
    End Function
    Public Function CMS_RoomC_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomC_List(PortalConnect), GetType(CMS_RoomCInfo))
    End Function
    Public Function CMS_RoomC_List_Search(PortalConnect As String, roomID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomC_List_Search(PortalConnect, roomID, currPage, recodperpage), GetType(CMS_RoomCInfo))
    End Function
    Public Function CMS_RoomC_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomC_Get_By_CMS_Room(PortalConnect, roomID), GetType(CMS_RoomCInfo))
    End Function
    Public Sub CMS_RoomC_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        DataProvider.Instance().CMS_RoomC_Delete_By_CMS_Room(PortalConnect, roomID)
    End Sub

    Public Function CMS_RoomC_Add(PortalConnect As String, obj As CMS_RoomCInfo) As Integer
        Return DataProvider.Instance().CMS_RoomC_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_RoomC_Update(PortalConnect As String, obj As CMS_RoomCInfo)
        DataProvider.Instance().CMS_RoomC_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_RoomC_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_RoomC_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_RoomF"
    Public Function CMS_TypeZoom_Get(PortalConnect As String, id As Integer) As CMS_TypeZoomInfo
        Return CBO.FillObject(Of CMS_TypeZoomInfo)(DataProvider.Instance().CMS_TypeZoom_Get(PortalConnect, id))
    End Function
    Public Function CMS_Utility_Get(PortalConnect As String, id As Integer) As CMS_UtilityInfo
        Return CBO.FillObject(Of CMS_UtilityInfo)(DataProvider.Instance().CMS_Utility_Get(PortalConnect, id))
    End Function
    Public Function CMS_RoomF_Get(PortalConnect As String, attach_ID As String) As CMS_RoomFInfo
        Return CBO.FillObject(Of CMS_RoomFInfo)(DataProvider.Instance().CMS_RoomF_Get(PortalConnect, attach_ID))
    End Function
    Public Function CMS_RoomF_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomF_List(PortalConnect), GetType(CMS_RoomFInfo))
    End Function
    Public Function CMS_RoomF_Get_By_CMS_Room(PortalConnect As String, roomID As Integer, loaiPhong As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomF_Get_By_CMS_Room(PortalConnect, roomID, loaiPhong), GetType(CMS_RoomFInfo))
    End Function
    Public Function CMS_RoomF_Get_By_CMS_Room_ID(PortalConnect As String, roomID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomF_Get_By_CMS_Room_ID(PortalConnect, roomID), GetType(CMS_RoomFInfo))
    End Function
    Public Sub CMS_RoomF_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        DataProvider.Instance().CMS_RoomF_Delete_By_CMS_Room(PortalConnect, roomID)
    End Sub
    Public Sub CMS_RoomF_Add(PortalConnect As String, obj As CMS_RoomFInfo)
        DataProvider.Instance().CMS_RoomF_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_RoomF_Update(PortalConnect As String, obj As CMS_RoomFInfo)
        DataProvider.Instance().CMS_RoomF_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_RoomF_Delete(PortalConnect As String, attach_ID As String)
        DataProvider.Instance().CMS_RoomF_Delete(PortalConnect, attach_ID)
    End Sub
#End Region
#Region "CMS_RoomU"
    Public Function CMS_RoomU_Get(PortalConnect As String, iD As Integer) As CMS_RoomUInfo
        Return CBO.FillObject(Of CMS_RoomUInfo)(DataProvider.Instance().CMS_RoomU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_RoomU_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomU_List(PortalConnect), GetType(CMS_RoomUInfo))
    End Function
    Public Function CMS_RoomU_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RoomU_Get_By_CMS_Room(PortalConnect, roomID), GetType(CMS_RoomUInfo))
    End Function
    Public Sub CMS_RoomU_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
        DataProvider.Instance().CMS_RoomU_Delete_By_CMS_Room(PortalConnect, roomID)
    End Sub

    Public Function CMS_RoomU_Add(PortalConnect As String, obj As CMS_RoomUInfo) As Integer
        Return DataProvider.Instance().CMS_RoomU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_RoomU_Update(PortalConnect As String, obj As CMS_RoomUInfo)
        DataProvider.Instance().CMS_RoomU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_RoomU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_RoomU_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Fr_Notify"
    Public Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As CMS_Fr_NotifyInfo
        Return CBO.FillObject(Of CMS_Fr_NotifyInfo)(DataProvider.Instance().CMS_Fr_Notify_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_Notify_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Notify_List(PortalConnect), GetType(CMS_Fr_NotifyInfo))
    End Function
    Public Function CMS_Fr_Notify_List_AppID(PortalConnect As String, uID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Notify_List_AppID(PortalConnect, uID, appID, currPage, recodPage, flags), GetType(CMS_Fr_NotifyInfo))
    End Function
    Public Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Notify_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Notify_List_New(PortalConnect As String, uID As Integer, appID As String, flags As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Notify_List_New(PortalConnect, uID, appID, flags)
    End Function
    Public Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, uID As Integer, appID As String, flags As String)
        DataProvider.Instance().CMS_Fr_Notify_List_UnNew(PortalConnect, uID, appID, flags)
    End Sub
    Public Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
        DataProvider.Instance().CMS_Fr_Notify_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_Notify_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Fr_Comment"
    Public Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As CMS_Fr_CommentInfo
        Return CBO.FillObject(Of CMS_Fr_CommentInfo)(DataProvider.Instance().CMS_Fr_Comment_Get(PortalConnect, comment_ID))
    End Function
    Public Function CMS_Fr_Comment_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List(PortalConnect), GetType(CMS_Fr_CommentInfo))
    End Function
    Public Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional ByVal toList As Boolean = True) As Object
        If toList = True Then
            Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Comment_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_CommentInfo))
        Else
            CMS_Fr_Comment_List_Search = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(VBN.flConnect.KengConnect(PortalConnect), "CMS_Fr_Comment_List_Search", postID, currPage, recodperpage, UserName).Tables(0)
            SqlClient.SqlConnection.ClearAllPools()
        End If
    End Function
    Public Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Comment_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Comment_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
        DataProvider.Instance().CMS_Fr_Comment_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
        DataProvider.Instance().CMS_Fr_Comment_Update_Lock(PortalConnect, commentID, lock, lockUser)
    End Sub
    Public Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
        DataProvider.Instance().CMS_Fr_Comment_Delete(PortalConnect, comment_ID)
    End Sub
#End Region
#Region "CMS_Fr_Likes"
    Public Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As CMS_Fr_LikesInfo
        Return CBO.FillObject(Of CMS_Fr_LikesInfo)(DataProvider.Instance().CMS_Fr_Likes_Get(PortalConnect, likesID))
    End Function
    Public Function CMS_Fr_Likes_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Likes_List(PortalConnect), GetType(CMS_Fr_LikesInfo))
    End Function
    Public Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Likes_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_LikesInfo))
    End Function

    Public Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Likes_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_Likes_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
        DataProvider.Instance().CMS_Fr_Likes_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
        DataProvider.Instance().CMS_Fr_Likes_Delete(PortalConnect, appID, postID)
    End Sub
#End Region
#Region "CMS_Fr_Post"
    Public Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As CMS_Fr_PostInfo
        Return CBO.FillObject(Of CMS_Fr_PostInfo)(DataProvider.Instance().CMS_Fr_Post_Get(PortalConnect, post_ID))
    End Function
    Public Function CMS_Fr_Post_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List(PortalConnect), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Search(PortalConnect As String, uID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Search(PortalConnect, uID, search, isOrder, currPage, recodperpage, appID), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Group(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Group(PortalConnect, uID, GroupID, search, isOrder, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Group_Web(PortalConnect, uID, GroupID, search, isOrder, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_Admin(PortalConnect As String, uID As Integer, isLock As Integer, appID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_Admin(PortalConnect, uID, isLock, appID, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, uID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Post_List_OnlyMe(PortalConnect, appID, uID, search, currPage, recodperpage, appFriend), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Post_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
        DataProvider.Instance().CMS_Fr_Post_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
        DataProvider.Instance().CMS_Fr_Post_Update_Lock(PortalConnect, postID, lock, lockuser)
    End Sub
    Public Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
        DataProvider.Instance().CMS_Fr_Post_Delete(PortalConnect, post_ID)
    End Sub
#End Region
#Region "CMS_Fr_SharePost"
    Public Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_Fr_SharePostInfo
        Return CBO.FillObject(Of CMS_Fr_SharePostInfo)(DataProvider.Instance().CMS_Fr_SharePost_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_Fr_SharePost_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_SharePost_List(PortalConnect), GetType(CMS_Fr_SharePostInfo))
    End Function
    Public Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_SharePost_List_Search(PortalConnect, postID, currPage, recodperpage, UserName), GetType(CMS_Fr_SharePostInfo))
    End Function

    Public Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_SharePost_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_SharePost_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
        DataProvider.Instance().CMS_Fr_SharePost_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_Fr_SharePost_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_ShareUser"
    Public Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As CMS_Fr_ShareUserInfo
        Return CBO.FillObject(Of CMS_Fr_ShareUserInfo)(DataProvider.Instance().CMS_Fr_ShareUser_Get(PortalConnect, sharePost_ID))
    End Function
    Public Function CMS_Fr_ShareUser_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_ShareUser_List(PortalConnect), GetType(CMS_Fr_ShareUserInfo))
    End Function
    Public Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_ShareUser_List_Search(PortalConnect, search, currPage, recodperpage, postID), GetType(CMS_Fr_ShareUserInfo))
    End Function
    Public Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_ShareUser_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
        Return DataProvider.Instance().CMS_Fr_ShareUser_Count_ByPostID(PortalConnect, postID, appID)
    End Function
    Public Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
        DataProvider.Instance().CMS_Fr_ShareUser_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
        DataProvider.Instance().CMS_Fr_ShareUser_Delete(PortalConnect, sharePost_ID)
    End Sub
#End Region
#Region "CMS_Fr_FileAttach"
    Public Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As CMS_Fr_FileAttachInfo
        Return CBO.FillObject(Of CMS_Fr_FileAttachInfo)(DataProvider.Instance().CMS_Fr_FileAttach_Get(PortalConnect, attach_ID))
    End Function
    Public Function CMS_Fr_FileAttach_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List(PortalConnect), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List_ByIdKey(PortalConnect, idKey, type, top), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_FileAttach_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_Fr_FileAttachInfo))
    End Function
    Public Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        DataProvider.Instance().CMS_Fr_FileAttach_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
        DataProvider.Instance().CMS_Fr_FileAttach_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
        DataProvider.Instance().CMS_Fr_FileAttach_Delete(PortalConnect, attach_ID)
    End Sub
#End Region
#Region "CMS_Dash"

    Public Function CMS_DashBoard(PortalConnect As String, bussinessID As Integer, yearID As Integer) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard(PortalConnect, bussinessID, yearID))
    End Function
    Public Function CMS_DashBoard_LeaveOfAbs(PortalConnect As String, bussinessID As Integer, yearID As Integer) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_LeaveOfAbs(PortalConnect, bussinessID, yearID))
    End Function
#End Region
#Region "CMS_Calender"
    Public Function CMS_Calender_Get(PortalConnect As String, iD As Integer) As CMS_CalenderInfo
        Return CBO.FillObject(Of CMS_CalenderInfo)(DataProvider.Instance().CMS_Calender_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Calender_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Calender_List(PortalConnect), GetType(CMS_CalenderInfo))
    End Function
    Public Function CMS_Calender_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, busID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Calender_List_Search(PortalConnect, currPage, recodperpage, busID), GetType(CMS_CalenderInfo))
    End Function

    Public Function CMS_Calender_Add(PortalConnect As String, obj As CMS_CalenderInfo) As Integer
        Return DataProvider.Instance().CMS_Calender_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Calender_Update(PortalConnect As String, obj As CMS_CalenderInfo)
        DataProvider.Instance().CMS_Calender_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Calender_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Calender_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Dispute"
    Public Function CMS_LyDo_Get(PortalConnect As String, ID As Integer) As CMS_LyDoInfo
        Return CBO.FillObject(Of CMS_LyDoInfo)(DataProvider.Instance().CMS_LyDo_Get(PortalConnect, ID))
    End Function
    Public Function CMS_LyDo_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LyDo_List(PortalConnect), GetType(CMS_LyDoInfo))
    End Function
    Public Function CMS_Dispute_Get(PortalConnect As String, iD As Integer) As CMS_DisputeInfo
        Return CBO.FillObject(Of CMS_DisputeInfo)(DataProvider.Instance().CMS_Dispute_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Dispute_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Dispute_List(PortalConnect), GetType(CMS_DisputeInfo))
    End Function
    Public Function CMS_Dispute_List_Search(PortalConnect As String, search As String, uID As Integer, dID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Dispute_List_Search(PortalConnect, search, uID, dID, currPage, recodperpage), GetType(CMS_DisputeInfo))
    End Function
    Public Sub CMS_Dispute_Active(PortalConnect As String, iD As Integer, isSet As Integer, setUserName As String, setDate As DateTime)
        DataProvider.Instance().CMS_Dispute_Active(PortalConnect, iD, isSet, setUserName, setDate)
    End Sub
    Public Sub CMS_Dispute_Update_Active(PortalConnect As String, iD As Integer, SetActive As Integer, setUserName As String, setDate As DateTime)
        DataProvider.Instance().CMS_Dispute_Update_Active(PortalConnect, iD, SetActive, setUserName, setDate)
    End Sub
    Public Function CMS_Dispute_Add(PortalConnect As String, obj As CMS_DisputeInfo) As Integer
        Return DataProvider.Instance().CMS_Dispute_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Dispute_Update(PortalConnect As String, obj As CMS_DisputeInfo)
        DataProvider.Instance().CMS_Dispute_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Dispute_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Dispute_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Meeting"
    Public Function CMS_Meeting_Check_By_Reg(PortalConnect As String, uid As Integer, mR_ID As Integer, months As Integer, years As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_Check_By_Reg(PortalConnect, uid, mR_ID, months, years), GetType(MettingDayInfo))
    End Function
    Public Function CMS_Meeting_Get(PortalConnect As String, meeting_ID As Integer) As CMS_MeetingInfo
        Return CBO.FillObject(Of CMS_MeetingInfo)(DataProvider.Instance().CMS_Meeting_Get(PortalConnect, meeting_ID))
    End Function
    Public Function CMS_Meeting_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_List(PortalConnect), GetType(CMS_MeetingInfo))
    End Function
    Public Function CMS_Meeting_Get_By_Day(PortalConnect As String, uid As Integer, startDate As DateTime, endDate As DateTime, room_id As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_Get_By_Day(PortalConnect, uid, startDate, endDate, room_id), GetType(CMS_MeetingInfo))
    End Function
    Public Function CMS_Meeting_List_Search(PortalConnect As String, UID As Integer, DID As String, EID As String, MR_ID As String, MonthID As Integer, YearID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_List_Search(PortalConnect, UID, DID, EID, MR_ID, MonthID, YearID, currPage, recodperpage), GetType(CMS_MeetingInfo))
    End Function
    Public Function CMS_Meeting_Rpt_Group(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_Rpt_Group(PortalConnect, UID, ngay, thang, nam), GetType(CMS_MeetingRoomInfo))
    End Function
    Public Function CMS_Meeting_Rpt_List(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer, mrID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_Rpt_List(PortalConnect, UID, ngay, thang, nam, mrID), GetType(CMS_MeetingInfo))
    End Function
    Public Function CMS_Meeting_List_AppID(PortalConnect As String, UID As Integer, appID As String, EID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Meeting_List_AppID(PortalConnect, UID, appID, EID, currPage, recodperpage), GetType(CMS_MeetingInfo))
    End Function
    Public Function CMS_Meeting_Add(PortalConnect As String, obj As CMS_MeetingInfo) As Integer
        Return DataProvider.Instance().CMS_Meeting_Add(PortalConnect, obj)
    End Function
    Public Function CMS_Meeting_Get_FromHour(PortalConnect As String, mR_ID As Integer, toDate As DateTime) As DateTime
        Return DataProvider.Instance().CMS_Meeting_Get_FromHour(PortalConnect, mR_ID, toDate)
    End Function
    Public Sub CMS_Meeting_Update(PortalConnect As String, obj As CMS_MeetingInfo)
        DataProvider.Instance().CMS_Meeting_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Meeting_Delete(PortalConnect As String, meeting_ID As Integer)
        DataProvider.Instance().CMS_Meeting_Delete(PortalConnect, meeting_ID)
    End Sub
#End Region
#Region "CMS_MeetingRoom"
    Public Function CMS_MeetingRoom_Get(PortalConnect As String, mR_ID As Integer) As CMS_MeetingRoomInfo
        Return CBO.FillObject(Of CMS_MeetingRoomInfo)(DataProvider.Instance().CMS_MeetingRoom_Get(PortalConnect, mR_ID))
    End Function
    Public Function CMS_MeetingRoom_Get_Mrcode(PortalConnect As String, MrCode As String, UID As Integer) As CMS_MeetingRoomInfo
        Return CBO.FillObject(Of CMS_MeetingRoomInfo)(DataProvider.Instance().CMS_MeetingRoom_Get_Mrcode(PortalConnect, MrCode, UID))
    End Function

    Public Function CMS_MeetingRoom_List(PortalConnect As String, UID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MeetingRoom_List(PortalConnect, UID), GetType(CMS_MeetingRoomInfo))
    End Function
    Public Function CMS_MeetingRoom_List_Search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MeetingRoom_List_search(PortalConnect, search, UID, currPage, recodperpage), GetType(CMS_MeetingRoomInfo))
    End Function

    Public Function CMS_MeetingRoom_Add(PortalConnect As String, obj As CMS_MeetingRoomInfo) As Integer
        Return DataProvider.Instance().CMS_MeetingRoom_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MeetingRoom_Update(PortalConnect As String, obj As CMS_MeetingRoomInfo)
        DataProvider.Instance().CMS_MeetingRoom_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MeetingRoom_Delete(PortalConnect As String, mR_ID As Integer)
        DataProvider.Instance().CMS_MeetingRoom_Delete(PortalConnect, mR_ID)
    End Sub
#End Region
#Region "CMS_Mission"
    Public Function CMS_Mission_Get(PortalConnect As String, mission_ID As Integer) As CMS_MissionInfo
        Return CBO.FillObject(Of CMS_MissionInfo)(DataProvider.Instance().CMS_Mission_Get(PortalConnect, mission_ID))
    End Function
    Public Function CMS_Mission_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Mission_List(PortalConnect), GetType(CMS_MissionInfo))
    End Function
    Public Function CMS_Mission_List_Search(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Mission_List_Search(PortalConnect, UID, search, Status, yearID, MonthID, DiD, currPage, recodperpage), GetType(CMS_MissionInfo))
    End Function
    Public Function CMS_Mission_List_Search_export(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Mission_List_Search_export(PortalConnect, UID, search, Status, yearID, MonthID, DiD), GetType(CMS_MissionInfo))
    End Function
    Public Function CMS_Mission_List_AppID(PortalConnect As String, UID As Integer, appID As String, toEID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Mission_List_AppID(PortalConnect, UID, appID, toEID, currPage, recodperpage), GetType(CMS_MissionInfo))
    End Function
    Public Function CMS_Mission_List_Manager(PortalConnect As String, UID As Integer, manageID As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Mission_List_Manager(PortalConnect, UID, manageID, currPage, recodperpage), GetType(CMS_MissionInfo))
    End Function
    Public Function CMS_Mission_Add(PortalConnect As String, obj As CMS_MissionInfo) As Integer
        Return DataProvider.Instance().CMS_Mission_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Mission_Update_Manage(PortalConnect As String, Mission_ID As Integer, isActive As Boolean, userUpdate As String, dateUpdate As DateTime)
        DataProvider.Instance().CMS_Mission_Update_Manage(PortalConnect, Mission_ID, isActive, userUpdate, dateUpdate)
    End Sub
    Public Sub CMS_Mission_Update_First(PortalConnect As String, Mission_ID As Integer, FirstKm As Double, FirstDate As DateTime, FirstUser As String)
        DataProvider.Instance().CMS_Mission_Update_First(PortalConnect, Mission_ID, FirstKm, FirstDate, FirstUser)
    End Sub
    Public Sub CMS_Mission_Update_Last(PortalConnect As String, Mission_ID As Integer, lastKm As Double, lastDate As DateTime, lastUser As String)
        DataProvider.Instance().CMS_Mission_Update_Last(PortalConnect, Mission_ID, lastKm, lastDate, lastUser)
    End Sub
    Public Sub CMS_Mission_Update_Approval(PortalConnect As String, Mission_ID As Integer, IsApproval As Boolean, ApprovalDate As DateTime, ApprovalUser As String, CarID As String, DriverName As String, DriverPhone As String, DriverNumber As String)
        DataProvider.Instance().CMS_Mission_Update_Approval(PortalConnect, Mission_ID, IsApproval, ApprovalDate, ApprovalUser, CarID, DriverName, DriverPhone, DriverNumber)
    End Sub
    Public Sub CMS_Mission_Delete(PortalConnect As String, mission_ID As Integer)
        DataProvider.Instance().CMS_Mission_Delete(PortalConnect, mission_ID)
    End Sub
#End Region
#Region "CMS_MissionCar"
    Public Function CMS_MissionCar_Get(PortalConnect As String, car_ID As Integer) As CMS_MissionCarInfo
        Return CBO.FillObject(Of CMS_MissionCarInfo)(DataProvider.Instance().CMS_MissionCar_Get(PortalConnect, car_ID))
    End Function
    Public Function CMS_MissionCar_List(PortalConnect As String, UID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MissionCar_List(PortalConnect, UID), GetType(CMS_MissionCarInfo))
    End Function
    Public Function CMS_MissionCar_List_Search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MissionCar_List_search(PortalConnect, search, UID, currPage, recodperpage), GetType(CMS_MissionCarInfo))

    End Function
    Public Function CMS_MissionCar_List_UID(PortalConnect As String, UID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_MissionCar_List_UID(PortalConnect, UID), GetType(CMS_MissionCarInfo))
    End Function
    Public Function CMS_MissionCar_Add(PortalConnect As String, obj As CMS_MissionCarInfo) As Integer
        Return DataProvider.Instance().CMS_MissionCar_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_MissionCar_Update(PortalConnect As String, obj As CMS_MissionCarInfo)
        DataProvider.Instance().CMS_MissionCar_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_MissionCar_Delete(PortalConnect As String, car_ID As Integer)
        DataProvider.Instance().CMS_MissionCar_Delete(PortalConnect, car_ID)
    End Sub
#End Region
#Region "CMS_Group"
    Public Function CMS_Group_Get(PortalConnect As String, iD As Integer) As CMS_GroupInfo
        Return CBO.FillObject(Of CMS_GroupInfo)(DataProvider.Instance().CMS_Group_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Group_List_UID(PortalConnect As String, UID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_UID(PortalConnect, UID), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List(PortalConnect), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_List_Search(PortalConnect, search, currPage, recodperpage, UID), GetType(CMS_GroupInfo))
    End Function
    Public Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        DataProvider.Instance().CMS_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Group_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_GroupU"
    Public Function CMS_GroupU_List_Send(PortalConnect As String, GroupID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupU_List_Send(PortalConnect, GroupID), GetType(CMS_GroupUInfo))
    End Function
    Public Function CMS_GroupU_Get(PortalConnect As String, iD As Integer) As CMS_GroupUInfo
        Return CBO.FillObject(Of CMS_GroupUInfo)(DataProvider.Instance().CMS_GroupU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_GroupU_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupU_List(PortalConnect), GetType(CMS_GroupUInfo))
    End Function
    Public Function CMS_GroupU_Get_By_CMS_Group(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupU_Get_By_CMS_Group(PortalConnect, iD, currPage, recodperpage), GetType(CMS_GroupUInfo))
    End Function
    Public Function CMS_GroupU_List_Search(PortalConnect As String, search As String, GroupID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GroupU_List_Search(PortalConnect, search, GroupID, currPage, recodperpage), GetType(CMS_EmployeeInfo))
    End Function
    Public Function CMS_GroupU_count(PortalConnect As String, GroupID As Integer, UID As Integer) As Integer
        Return DataProvider.Instance().CMS_GroupU_count(PortalConnect, GroupID, UID)
    End Function

    Public Function CMS_GroupU_Add(PortalConnect As String, obj As CMS_GroupUInfo) As Integer
        Return DataProvider.Instance().CMS_GroupU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_GroupU_Update(PortalConnect As String, obj As CMS_GroupUInfo)
        DataProvider.Instance().CMS_GroupU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_GroupU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_GroupU_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Fr_Group"
    Public Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_Group_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List(PortalConnect), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List_AppID(PortalConnect, uID, appID, search, currPage, recodperpage), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_Group_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
        DataProvider.Instance().CMS_Fr_Group_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_Group_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Fr_Group_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_Group_List_TK(PortalConnect, uID, currPage, recodperpage), GetType(CMS_Fr_GroupInfo))
    End Function
    Public Function CMS_Fr_Group_TK(PortalConnect As String, uID As Integer, ID As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_TK(PortalConnect, uID, ID))
    End Function
    Public Function CMS_Fr_Group_ThongKe(PortalConnect As String, UID As Integer) As CMS_Fr_GroupInfo
        Return CBO.FillObject(Of CMS_Fr_GroupInfo)(DataProvider.Instance().CMS_Fr_Group_ThongKe(PortalConnect, UID))
    End Function
    Public Function CMS_Fr_NguoiDang(PortalConnect As String, UID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_NguoiDang(PortalConnect, UID, currPage, recodperpage), GetType(CMS_Fr_PostInfo))
    End Function
    Public Function CMS_Fr_GroupTV(PortalConnect As String, UID As Integer, ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupTV(PortalConnect, UID, ID), GetType(CMS_Fr_PostInfo))
    End Function
    Public Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)
        DataProvider.Instance().CMS_Fr_Group_Update_Lock(PortalConnect, ID, lock, lockuser)
    End Sub
#End Region
#Region "CMS_Fr_GroupU"
    Public Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As CMS_Fr_GroupUInfo
        Return CBO.FillObject(Of CMS_Fr_GroupUInfo)(DataProvider.Instance().CMS_Fr_GroupU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Fr_GroupU_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupU_List(PortalConnect), GetType(CMS_Fr_GroupUInfo))
    End Function
    Public Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect, iD, page, recod), GetType(CMS_Fr_GroupUInfo))
    End Function
    Public Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect, iD)
    End Sub
    Public Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
        Return DataProvider.Instance().CMS_Fr_GroupU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
        DataProvider.Instance().CMS_Fr_GroupU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Fr_GroupU_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_SalaryM"
    Public Function CMS_SalaryM_Get(PortalConnect As String, iD As Integer) As CMS_SalaryMInfo
        Return CBO.FillObject(Of CMS_SalaryMInfo)(DataProvider.Instance().CMS_SalaryM_Get(PortalConnect, iD))
    End Function
    Public Function CMS_SalaryM_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_SalaryM_List(PortalConnect), GetType(CMS_SalaryMInfo))
    End Function
    Public Function CMS_SalaryM_Add(PortalConnect As String, obj As CMS_SalaryMInfo) As Integer
        Return DataProvider.Instance().CMS_SalaryM_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_SalaryM_Update(PortalConnect As String, obj As CMS_SalaryMInfo)
        DataProvider.Instance().CMS_SalaryM_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_SalaryM_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_SalaryM_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_SalaryM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As CMS_SalaryMInfo
        Return CBO.FillObject(Of CMS_SalaryMInfo)(DataProvider.Instance().CMS_SalaryM_Get_By_UID(PortalConnect, UID, thang, nam))
    End Function
    Public Sub CMS_SalaryM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
        DataProvider.Instance().CMS_SalaryM_Update_Lock(PortalConnect, UID, thang, nam, isLock, lockDate, lockUser)
    End Sub
    Public Function CMS_SalaryM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As CMS_SalaryMInfo
        Return CBO.FillObject(Of CMS_SalaryMInfo)(DataProvider.Instance().CMS_SalaryM_Update_ThacMac(PortalConnect, UID, thang, nam, ThacMac))
    End Function
#End Region
#Region "CMS_TimeKeepM"
    Public Function CMS_TimeKeepM_Get(PortalConnect As String, iD As Integer) As CMS_TimeKeepMInfo
        Return CBO.FillObject(Of CMS_TimeKeepMInfo)(DataProvider.Instance().CMS_TimeKeepM_Get(PortalConnect, iD))
    End Function
    Public Function CMS_TimeKeepM_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TimeKeepM_List(PortalConnect), GetType(CMS_TimeKeepMInfo))
    End Function
    Public Function CMS_TimeKeepM_Add(PortalConnect As String, obj As CMS_TimeKeepMInfo) As Integer
        Return DataProvider.Instance().CMS_TimeKeepM_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_TimeKeepM_Update(PortalConnect As String, obj As CMS_TimeKeepMInfo)
        DataProvider.Instance().CMS_TimeKeepM_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TimeKeepM_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_TimeKeepM_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_TimeKeepM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As CMS_TimeKeepMInfo
        Return CBO.FillObject(Of CMS_TimeKeepMInfo)(DataProvider.Instance().CMS_TimeKeepM_Get_By_UID(PortalConnect, UID, thang, nam))
    End Function
    Public Function CMS_TimeKeepM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As CMS_TimeKeepMInfo
        Return CBO.FillObject(Of CMS_TimeKeepMInfo)(DataProvider.Instance().CMS_TimeKeepM_Update_ThacMac(PortalConnect, UID, thang, nam, ThacMac))
    End Function
    Public Sub CMS_TimeKeepM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
        DataProvider.Instance().CMS_TimeKeepM_Update_Lock(PortalConnect, UID, thang, nam, isLock, lockDate, lockUser)
    End Sub
#End Region
#Region "CMS_Group_Chat"
    Public Function CMS_Group_Chat_Get(PortalConnect As String, iD As Integer) As CMS_Group_ChatInfo
        Return CBO.FillObject(Of CMS_Group_ChatInfo)(DataProvider.Instance().CMS_Group_Chat_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Group_Chat_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_Chat_List(PortalConnect), GetType(CMS_Group_ChatInfo))
    End Function
    Public Function CMS_Group_Chat_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_Chat_List_AppID(PortalConnect, uID, appID, search, currPage, recodperpage), GetType(CMS_Group_ChatInfo))
    End Function
    Public Function CMS_Group_Chat_Add(PortalConnect As String, obj As CMS_Group_ChatInfo) As Integer
        Return DataProvider.Instance().CMS_Group_Chat_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_Chat_Update(PortalConnect As String, obj As CMS_Group_ChatInfo)
        DataProvider.Instance().CMS_Group_Chat_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_Chat_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Group_Chat_Delete(PortalConnect, iD)
    End Sub
    Public Function CMS_Group_Chat_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_Chat_List_TK(PortalConnect, uID, currPage, recodperpage), GetType(CMS_Group_ChatInfo))
    End Function
#End Region
#Region "CMS_Group_ChatU"
    Public Function CMS_Group_ChatU_Get(PortalConnect As String, iD As Integer) As CMS_Group_ChatUInfo
        Return CBO.FillObject(Of CMS_Group_ChatUInfo)(DataProvider.Instance().CMS_Group_ChatU_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Group_ChatU_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_ChatU_List(PortalConnect), GetType(CMS_Group_ChatUInfo))
    End Function
    Public Function CMS_Group_ChatU_Get_By_CMS_Group_Chat(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Group_ChatU_Get_By_CMS_Group_Chat(PortalConnect, iD, page, recod), GetType(CMS_Group_ChatUInfo))
    End Function
    Public Sub CMS_Group_ChatU_Delete_By_CMS_Group_Chat(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Group_ChatU_Delete_By_CMS_Group_Chat(PortalConnect, iD)
    End Sub
    Public Function CMS_Group_ChatU_Add(PortalConnect As String, obj As CMS_Group_ChatUInfo) As Integer
        Return DataProvider.Instance().CMS_Group_ChatU_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Group_ChatU_Update(PortalConnect As String, obj As CMS_Group_ChatUInfo)
        DataProvider.Instance().CMS_Group_ChatU_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Group_ChatU_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Group_ChatU_Delete(PortalConnect, iD)
    End Sub


#End Region



End Class