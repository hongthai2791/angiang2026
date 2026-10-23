Public MustInherit Class DataProvider
#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing
    Shared Sub New()
        CreateProvider()
    End Sub
    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.Keng", ""), DataProvider)
    End Sub
    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_Employee"
    Public MustOverride Function CMS_Employee_GetByCode(PortalConnect As String, uID As Integer, empCode As String) As IDataReader
    Public MustOverride Function CMS_Employee_Get_By_AppID(PortalConnect As String, uID As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Employee_Get(PortalConnect As String, employee_ID As String) As IDataReader
    Public MustOverride Function CMS_Employee_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Employee_List_Manager_Abs(PortalConnect As String, businessID As Integer, empCode As String, deparmentCode As String, currPage As Integer, recodperpage As Integer, Optional ByVal Search As String = "") As IDataReader
    Public MustOverride Function CMS_Employee_List_Manager(PortalConnect As String, businessID As Integer, deparmentCode As String, isManager As Int16, currPage As Integer, recodperpage As Integer, Search As String) As IDataReader
    Public MustOverride Function CMS_Employee_Permistion(PortalConnect As String, uID As Integer, eID As String, dID As String) As Integer
    Public MustOverride Function CMS_Employee_Add(PortalConnect As String, obj As CMS_EmployeeInfo) As String
    Public MustOverride Sub CMS_Employee_Update(PortalConnect As String, obj As CMS_EmployeeInfo)
    Public MustOverride Function CMS_Employee_Update_Status(PortalConnect As String, obj As CMS_EmployeeInfo) As String
    Public MustOverride Sub CMS_Employee_Delete(PortalConnect As String, employee_ID As String)
    Public MustOverride Function CMS_Employee_List_Send(PortalConnect As String, businessID As Integer, deparmentCode As String) As IDataReader
    Public MustOverride Function CMS_Employee_Update_App(PortalConnect As String, EmployeeCode As String, BusinessID As Integer, DepartmentCode As String, AppID As String, AppLogo As String) As String
    Public MustOverride Function CMS_Employee_List_Group_Select(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, eID As String) As IDataReader
    Public MustOverride Function CMS_Employee_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, BusinessID As Integer) As IDataReader
    Public MustOverride Function CMS_Employee_List_By_UID(PortalConnect As String, BusinessID As Integer) As IDataReader
    Public MustOverride Function CMS_Employee_List_Chat(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, uID As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Employee_List_Admin(PortalConnect As String, search As String, BusinessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Employee_List_Admin_Eports(PortalConnect As String, search As String, BusinessID As Integer, IsStatus As Integer, yearID As Integer, monthID As Integer, DepartmentCode As String) As IDataReader
    Public MustOverride Function CMS_Employee_List_Select(PortalConnect As String, search As String, BusinessID As Integer, GroupID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Employee_List_Group(PortalConnect As String, search As String, BusinessID As Integer, DepartmentCode As String, currPage As Integer, recodperpage As Integer, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Employee_List_Cache(PortalConnect As String, BusinessID As Integer) As IDataReader

#End Region
#Region "CMS_Salary"

    Public MustOverride Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
    Public MustOverride Function CMS_Salary_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As Integer) As IDataReader
    Public MustOverride Function CMS_Salary_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo) As String
    Public MustOverride Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
    Public MustOverride Sub CMS_Salary_Update_Sent(PortalConnect As String, salary_ID As String, IsSent As Boolean)
    Public MustOverride Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
    Public MustOverride Sub CMS_SendNotify_Sent(PortalConnect As String, sID As String, Type As String)

#End Region
#Region "CMS_TimeKeep"
    Public MustOverride Function CMS_TimeKeep_Get(PortalConnect As String, timeKeep_ID As String) As IDataReader
    Public MustOverride Function CMS_TimeKeep_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TimeKeep_List_Search(PortalConnect As String, search As String, isOrder As Integer, yearID As Integer, monthID As Integer, currPage As Integer, recodperpage As Integer, bID As Integer, DepartmentCode As String, isStatus As Integer) As IDataReader
    Public MustOverride Function CMS_TimeKeep_List_By_AppID(PortalConnect As String, BusinessID As Integer, EmployeeCode As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_TimeKeep_Add(PortalConnect As String, obj As CMS_TimeKeepInfo) As String
    Public MustOverride Sub CMS_TimeKeep_Update(PortalConnect As String, obj As CMS_TimeKeepInfo)
    Public MustOverride Sub CMS_TimeKeep_Delete(PortalConnect As String, timeKeep_ID As String)
    Public MustOverride Sub CMS_TimeKeep_Update_Sent(PortalConnect As String, timeKeep_ID As String, IsSent As Boolean)
#End Region
#Region "CMS_TypeZoom"
    Public MustOverride Function CMS_TypeZoom_List(PortalConnect As String) As IDataReader
#End Region
#Region "CMS_Utility"
    Public MustOverride Function CMS_Utility_List(PortalConnect As String) As IDataReader
#End Region
#Region "CMS_LeaveOfAbs"
    Public MustOverride Function CMS_LeaveOfAbs_List_By_BusActive(PortalConnect As String, uID As Integer, month As Integer, years As Integer) As IDataReader
    Public MustOverride Sub CMS_LeaveOfAbs_Update_By_BusActive(PortalConnect As String, uID As Integer, leaveOfAbs_ID As String)
    Public MustOverride Function CMS_LeaveOfAbs_Get(PortalConnect As String, leaveOfAbs_ID As String) As IDataReader
    Public MustOverride Function CMS_LeaveOfAbs_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_LeaveOfAbs_List_By_Receive(PortalConnect As String, uid As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_LeaveOfAbs_List_Search(PortalConnect As String, uid As Integer, currPage As Integer, recodperpage As Integer, appID As String, eID As String) As IDataReader
    Public MustOverride Function CMS_LeaveOfAbs_List_Search_Web(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_LeaveOfAbs_List_Search_Web_export(PortalConnect As String, BusinessID As Integer, DepartmentCode As String, Thang As String, Nam As String, IsActive As Integer, key As String) As IDataReader
    Public MustOverride Sub CMS_LeaveOfAbs_Add(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
    Public MustOverride Sub CMS_LeaveOfAbs_Update(PortalConnect As String, obj As CMS_LeaveOfAbsInfo)
    Public MustOverride Function CMS_LeaveOfAbs_Active_New(PortalConnect As String, id As String, reason As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
    Public MustOverride Function CMS_LeaveOfAbs_Active(PortalConnect As String, id As String, isActive As Integer, activeUser As String, activeDate As DateTime) As Integer
    Public MustOverride Sub CMS_LeaveOfAbs_Delete(PortalConnect As String, leaveOfAbs_ID As String)
#End Region
#Region "CMS_Comment"
    Public MustOverride Function CMS_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Comment_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Function CMS_Comment_Add(PortalConnect As String, obj As CMS_CommentInfo) As Integer
    Public MustOverride Sub CMS_Comment_Update(PortalConnect As String, obj As CMS_CommentInfo)
    Public MustOverride Sub CMS_Comment_Delete(PortalConnect As String, comment_ID As Integer)
#End Region
#Region "CMS_Likes"
    Public MustOverride Function CMS_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
    Public MustOverride Function CMS_Likes_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Likes_Add(PortalConnect As String, obj As CMS_LikesInfo) As Integer
    Public MustOverride Function CMS_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Likes_Update(PortalConnect As String, obj As CMS_LikesInfo)
    Public MustOverride Sub CMS_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
#End Region
#Region "CMS_Post"
    Public MustOverride Function CMS_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Post_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Post_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Post_List_OnlyMe(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Post_Add(PortalConnect As String, obj As CMS_PostInfo) As Integer
    Public MustOverride Sub CMS_Post_Update(PortalConnect As String, obj As CMS_PostInfo)
    Public MustOverride Sub CMS_Post_Delete(PortalConnect As String, post_ID As Integer)
#End Region
#Region "CMS_SharePost"
    Public MustOverride Function CMS_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_SharePost_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_SharePost_Add(PortalConnect As String, obj As CMS_SharePostInfo) As Integer
    Public MustOverride Function CMS_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_SharePost_Update(PortalConnect As String, obj As CMS_SharePostInfo)
    Public MustOverride Sub CMS_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_ShareUser"
    Public MustOverride Function CMS_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_ShareUser_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
    Public MustOverride Function CMS_ShareUser_Add(PortalConnect As String, obj As CMS_ShareUserInfo) As Integer
    Public MustOverride Function CMS_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_ShareUser_Update(PortalConnect As String, obj As CMS_ShareUserInfo)
    Public MustOverride Sub CMS_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_FileAttach"
    Public MustOverride Function CMS_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
    Public MustOverride Function CMS_FileAttach_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
    Public MustOverride Function CMS_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_FileAttach_Add(PortalConnect As String, obj As CMS_FileAttachInfo)
    Public MustOverride Sub CMS_FileAttach_Update(PortalConnect As String, obj As CMS_FileAttachInfo)
    Public MustOverride Sub CMS_FileAttach_Delete(PortalConnect As String, attach_ID As String)
#End Region
#Region "CMS_RelationShip"

    Public MustOverride Function CMS_RelationShip_Get_By_Friend(PortalConnect As String, appID As String, appFriend As String) As IDataReader
    Public MustOverride Function CMS_RelationShip_Get(PortalConnect As String, relationShip_ID As Integer) As IDataReader
    Public MustOverride Function CMS_RelationShip_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_RelationShip_List_Friend(PortalConnect As String, appID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RelationShip_List_FGroup(PortalConnect As String, appID As String, appFriend As String) As Integer
    Public MustOverride Function CMS_RelationShip_Get_By_App(PortalConnect As String, appID As String, appFriend As String) As Integer
    Public MustOverride Function CMS_RelationShip_Add(PortalConnect As String, obj As CMS_RelationShipInfo) As Integer
    Public MustOverride Sub CMS_RelationShip_Update(PortalConnect As String, relationShip_ID As Integer, status As Integer)
    Public MustOverride Sub CMS_RelationShip_Delete(PortalConnect As String, relationShip_ID As Integer)
#End Region
#Region "CMS_Chat"
    Public MustOverride Function CMS_Chat_Get(PortalConnect As String, chat_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Chat_List_Search(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_List_AppID(PortalConnect As String, fromAppID As String, toAppID As String, years As Integer, months As Integer, days As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_List_Group(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_Group_BoxList_AppID(PortalConnect As String, appID As String, groupID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_BoxList_AppID(PortalConnect As String, fromAppID As String, toAppID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Chat_Add(PortalConnect As String, obj As CMS_ChatInfo) As Integer
    Public MustOverride Function CMS_Employee_CountChat(PortalConnect As String, uID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Chat_Update(PortalConnect As String, obj As CMS_ChatInfo)
    Public MustOverride Sub CMS_Chat_Delete(PortalConnect As String, chat_ID As Integer)
    Public MustOverride Sub CMS_Chat_Update_Send(PortalConnect As String, chat_ID As Integer)
    Public MustOverride Sub CMS_Chat_Update_Status(PortalConnect As String, fromAppID As String, toAppID As String)
    Public MustOverride Sub CMS_Chat_Update_Status_Group(PortalConnect As String, AppID As String, GroupID As Integer)
#End Region
#Region "CMS_Department"
    Public MustOverride Function CMS_Department_Get(PortalConnect As String, departmentID As Integer) As IDataReader
    Public MustOverride Function CMS_Department_Get_ID(PortalConnect As String, departmentCode As String) As IDataReader
    Public MustOverride Function CMS_Department_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Department_List_ByParentID(PortalConnect As String, parent_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Department_List_bID(PortalConnect As String, bId As Integer) As IDataReader
    Public MustOverride Function CMS_Department_List_Search(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Department_List_ParentNull(PortalConnect As String, search As String, fullText As String, Business_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Department_List_BID_Parent(PortalConnect As String, bID As Integer, ParentID As Integer) As IDataReader
    Public MustOverride Function CMS_Department_Add(PortalConnect As String, obj As CMS_DepartmentInfo) As Integer
    Public MustOverride Sub CMS_Department_Update(PortalConnect As String, obj As CMS_DepartmentInfo)
    Public MustOverride Sub CMS_Department_Delete(PortalConnect As String, departmentID As Integer)
#End Region
#Region "CMS_UserHeart"
    Public MustOverride Function CMS_UserHeart_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_UserHeart_Get_App(PortalConnect As String, appID As String) As IDataReader
    Public MustOverride Function CMS_UserHeart_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_UserHeart_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_UserHeart_Add(PortalConnect As String, obj As CMS_UserHeartInfo) As Integer
    Public MustOverride Sub CMS_UserHeart_Update(PortalConnect As String, obj As CMS_UserHeartInfo)
    Public MustOverride Sub CMS_UserHearte_Update_Quick(PortalConnect As String, obj As CMS_UserHeartInfo)
    Public MustOverride Sub CMS_UserHeart_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_CateDetail"
    Public MustOverride Function CMS_CateDetail_List_ByGroup(PortalConnect As String, GroupID As Integer) As IDataReader
    Public MustOverride Function CMS_CateDetail_Get(PortalConnect As String, CateDetail_ID As Integer) As IDataReader
#End Region
#Region "CMS_Notify"
    Public MustOverride Function CMS_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Notify_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Notify_List_AppID(PortalConnect As String, appID As String, currPage As Integer, recodPage As Integer) As IDataReader
    Public MustOverride Function CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo) As Integer
    Public MustOverride Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
    Public MustOverride Sub CMS_Notify_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Answer"
    Public MustOverride Function CMS_Answer_Get(PortalConnect As String, answer_ID As String) As IDataReader
    Public MustOverride Function CMS_Answer_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_Answer_Add(PortalConnect As String, obj As CMS_AnswerInfo)
    Public MustOverride Sub CMS_Answer_Update(PortalConnect As String, obj As CMS_AnswerInfo)
    Public MustOverride Function CMS_Answer_Get_By_Question_Home(PortalConnect As String, question_ID As String) As IDataReader
    Public MustOverride Function CMS_Answer_Get_By_CMS_Question(PortalConnect As String, question_ID As String) As IDataReader
    Public MustOverride Sub CMS_Answer_Delete(PortalConnect As String, answer_ID As String)
#End Region
#Region "CMS_Question"
    Public MustOverride Function CMS_Question_List_Month(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer, Years As Integer) As IDataReader
    Public MustOverride Function CMS_Question_List_Year(PortalConnect As String, UID As Integer, EID As String, DID As String, Flags As Integer) As IDataReader
    Public MustOverride Function CMS_Question_Get(PortalConnect As String, question_ID As String) As IDataReader
    Public MustOverride Function CMS_Question_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Question_List_ForApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As IDataReader
    Public MustOverride Function CMS_Question_List_GroupApp(PortalConnect As String, uID As Integer, appID As String, curpage As Integer, recordPage As Integer, isType As Integer) As IDataReader
    Public MustOverride Function CMS_Question_List_GroupApp_Details(PortalConnect As String, uID As Integer, appID As String, Months As Integer, Years As Integer, isType As Integer) As IDataReader
    Public MustOverride Function CMS_Question_List_Search(PortalConnect As String, Key As String, DepartmentCode As String, currPage As Integer, recodperpage As Integer, busID As Integer, years As String, months As String, types As Integer, status As Integer) As IDataReader
    Public MustOverride Function CMS_Question_List_App(PortalConnect As String, EmployeeCode As String, DepartmentCode As String, busID As Integer, years As String, months As String, types As Integer) As IDataReader
    Public MustOverride Sub CMS_Question_Add(PortalConnect As String, obj As CMS_QuestionInfo)
    Public MustOverride Sub CMS_Question_Update(PortalConnect As String, obj As CMS_QuestionInfo)
    Public MustOverride Sub CMS_Question_Update_Status(PortalConnect As String, quesID As String, status As Integer)
    Public MustOverride Sub CMS_Question_Delete(PortalConnect As String, question_ID As String)
#End Region
#Region "CMS_Room"
    Public MustOverride Function CMS_Room_Get(PortalConnect As String, roomID As Integer) As IDataReader
    Public MustOverride Function CMS_Room_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Room_List_OnlyMe(PortalConnect As String, appID As String, flag As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_Room_List_Search(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_Room_List_App(PortalConnect As String, appID As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As String, gioiTinh As String, tienIch As String, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Function CMS_Room_List_Admin(PortalConnect As String, key As String, tinh As Integer, huyen As Integer, xa As Integer, giaTu As Double, giaDen As Double, loaiPhong As Integer, gioiTinh As Integer, tienIch As Integer, page As Integer, recod As Integer) As IDataReader

    Public MustOverride Function CMS_Room_Add(PortalConnect As String, obj As CMS_RoomInfo) As Integer
    Public MustOverride Sub CMS_Room_Update(PortalConnect As String, obj As CMS_RoomInfo)
    Public MustOverride Sub CMS_Room_Delete(PortalConnect As String, roomID As Integer)
    Public MustOverride Function CMS_Room_Update_Status(PortalConnect As String, RoomID As Integer, IsStatus As Integer, UpdateUser As String, UpdateDate As DateTime) As String

#End Region
#Region "CMS_RoomC"
    Public MustOverride Function CMS_RoomC_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_RoomC_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_RoomC_List_Search(PortalConnect As String, roomID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_RoomC_Add(PortalConnect As String, obj As CMS_RoomCInfo) As Integer
    Public MustOverride Sub CMS_RoomC_Update(PortalConnect As String, obj As CMS_RoomCInfo)
    Public MustOverride Function CMS_RoomC_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As IDataReader
    Public MustOverride Sub CMS_RoomC_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
    Public MustOverride Sub CMS_RoomC_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_RoomF"
    Public MustOverride Function CMS_TypeZoom_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_Utility_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_RoomF_Get(PortalConnect As String, attach_ID As String) As IDataReader
    Public MustOverride Function CMS_RoomF_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_RoomF_Add(PortalConnect As String, obj As CMS_RoomFInfo)
    Public MustOverride Sub CMS_RoomF_Update(PortalConnect As String, obj As CMS_RoomFInfo)
    Public MustOverride Function CMS_RoomF_Get_By_CMS_Room(PortalConnect As String, roomID As Integer, loaiPhong As String) As IDataReader
    Public MustOverride Function CMS_RoomF_Get_By_CMS_Room_ID(PortalConnect As String, roomID As Integer) As IDataReader
    Public MustOverride Sub CMS_RoomF_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
    Public MustOverride Sub CMS_RoomF_Delete(PortalConnect As String, attach_ID As String)
#End Region
#Region "CMS_RoomU"
    Public MustOverride Function CMS_RoomU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_RoomU_List(PortalConnect As String) As IDataReader

    Public MustOverride Function CMS_RoomU_Add(PortalConnect As String, obj As CMS_RoomUInfo) As Integer
    Public MustOverride Sub CMS_RoomU_Update(PortalConnect As String, obj As CMS_RoomUInfo)
    Public MustOverride Function CMS_RoomU_Get_By_CMS_Room(PortalConnect As String, roomID As Integer) As IDataReader
    Public MustOverride Sub CMS_RoomU_Delete_By_CMS_Room(PortalConnect As String, roomID As Integer)
    Public MustOverride Sub CMS_RoomU_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Fr_Notify"
    Public MustOverride Function CMS_Fr_Notify_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_List_AppID(PortalConnect As String, uID As Integer, appID As String, currPage As Integer, recodPage As Integer, flags As String) As IDataReader
    Public MustOverride Function CMS_Fr_Notify_Add(PortalConnect As String, obj As CMS_Fr_NotifyInfo) As Integer
    Public MustOverride Sub CMS_Fr_Notify_Update(PortalConnect As String, obj As CMS_Fr_NotifyInfo)
    Public MustOverride Sub CMS_Fr_Notify_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Fr_Notify_List_New(PortalConnect As String, uID As Integer, appID As String, flags As String) As Integer
    Public MustOverride Sub CMS_Fr_Notify_List_UnNew(PortalConnect As String, uID As Integer, appID As String, flags As String)
#End Region
#Region "CMS_Fr_Comment"
    Public MustOverride Function CMS_Fr_Comment_Get(PortalConnect As String, comment_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Comment_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Fr_Comment_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Function CMS_Fr_Comment_Add(PortalConnect As String, obj As CMS_Fr_CommentInfo) As Integer
    Public MustOverride Sub CMS_Fr_Comment_Update(PortalConnect As String, obj As CMS_Fr_CommentInfo)
    Public MustOverride Sub CMS_Fr_Comment_Update_Lock(PortalConnect As String, commentID As Integer, lock As Integer, lockUser As String)
    Public MustOverride Sub CMS_Fr_Comment_Delete(PortalConnect As String, comment_ID As Integer)
#End Region
#Region "CMS_Fr_Likes"
    Public MustOverride Function CMS_Fr_Likes_Get(PortalConnect As String, likesID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Likes_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Likes_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Fr_Likes_Add(PortalConnect As String, obj As CMS_Fr_LikesInfo) As Integer
    Public MustOverride Function CMS_Fr_Likes_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_Likes_Update(PortalConnect As String, obj As CMS_Fr_LikesInfo)
    Public MustOverride Sub CMS_Fr_Likes_Delete(PortalConnect As String, appID As String, postID As Integer)
#End Region
#Region "CMS_Fr_Post"
    Public MustOverride Function CMS_Fr_Post_Get(PortalConnect As String, post_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Search(PortalConnect As String, uID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, appID As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Group(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_Group_Web(PortalConnect As String, uID As Integer, GroupID As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Function CMS_Fr_Post_List_Admin(PortalConnect As String, uID As Integer, isLock As Integer, appID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Post_List_OnlyMe(PortalConnect As String, appID As String, uID As Integer, search As String, currPage As Integer, recodperpage As Integer, appFriend As String) As IDataReader
    Public MustOverride Function CMS_Fr_Post_Add(PortalConnect As String, obj As CMS_Fr_PostInfo) As Integer
    Public MustOverride Sub CMS_Fr_Post_Update(PortalConnect As String, obj As CMS_Fr_PostInfo)
    Public MustOverride Sub CMS_Fr_Post_Update_Lock(PortalConnect As String, postID As Integer, lock As Integer, lockuser As String)
    Public MustOverride Sub CMS_Fr_Post_Delete(PortalConnect As String, post_ID As Integer)
#End Region
#Region "CMS_Fr_SharePost"
    Public MustOverride Function CMS_Fr_SharePost_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_SharePost_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_SharePost_List_Search(PortalConnect As String, postID As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Fr_SharePost_Add(PortalConnect As String, obj As CMS_Fr_SharePostInfo) As Integer
    Public MustOverride Function CMS_Fr_SharePost_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_SharePost_Update(PortalConnect As String, obj As CMS_Fr_SharePostInfo)
    Public MustOverride Sub CMS_Fr_SharePost_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_Fr_ShareUser"
    Public MustOverride Function CMS_Fr_ShareUser_Get(PortalConnect As String, sharePost_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, postID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_ShareUser_Add(PortalConnect As String, obj As CMS_Fr_ShareUserInfo) As Integer
    Public MustOverride Function CMS_Fr_ShareUser_Count_ByPostID(PortalConnect As String, postID As Integer, appID As String) As Integer
    Public MustOverride Sub CMS_Fr_ShareUser_Update(PortalConnect As String, obj As CMS_Fr_ShareUserInfo)
    Public MustOverride Sub CMS_Fr_ShareUser_Delete(PortalConnect As String, sharePost_ID As Integer)
#End Region
#Region "CMS_Fr_FileAttach"
    Public MustOverride Function CMS_Fr_FileAttach_Get(PortalConnect As String, attach_ID As String) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List_ByIdKey(PortalConnect As String, idKey As String, type As Integer, top As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_FileAttach_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Fr_FileAttach_Add(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
    Public MustOverride Sub CMS_Fr_FileAttach_Update(PortalConnect As String, obj As CMS_Fr_FileAttachInfo)
    Public MustOverride Sub CMS_Fr_FileAttach_Delete(PortalConnect As String, attach_ID As String)
#End Region
#Region "CMS_Dash"
    Public MustOverride Function CMS_DashBoard(PortalConnect As String, bussinessID As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_DashBoard_LeaveOfAbs(PortalConnect As String, bussinessID As Integer, yearID As Integer) As IDataReader
#End Region
#Region "CMS_Calender"
    Public MustOverride Function CMS_Calender_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Calender_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Calender_List_Search(PortalConnect As String, currPage As Integer, recodperpage As Integer, BusID As Integer) As IDataReader

    Public MustOverride Function CMS_Calender_Add(PortalConnect As String, obj As CMS_CalenderInfo) As Integer
    Public MustOverride Sub CMS_Calender_Update(PortalConnect As String, obj As CMS_CalenderInfo)
    Public MustOverride Sub CMS_Calender_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Dispute"
    Public MustOverride Function CMS_LyDo_Get(PortalConnect As String, ID As Integer) As IDataReader
    Public MustOverride Function CMS_LyDo_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Dispute_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Dispute_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Dispute_List_Search(PortalConnect As String, search As String, uID As Integer, dID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Dispute_Add(PortalConnect As String, obj As CMS_DisputeInfo) As Integer
    Public MustOverride Sub CMS_Dispute_Update(PortalConnect As String, obj As CMS_DisputeInfo)
    Public MustOverride Sub CMS_Dispute_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Dispute_Active(PortalConnect As String, iD As Integer, isSet As Integer, setUserName As String, setDate As DateTime)
    Public MustOverride Sub CMS_Dispute_Update_Active(PortalConnect As String, iD As Integer, SetActive As Integer, setUserName As String, setDate As DateTime)

#End Region
#Region "CMS_Meeting"
    Public MustOverride Function CMS_Meeting_Get_FromHour(PortalConnect As String, mR_ID As Integer, toDate As DateTime) As DateTime
    Public MustOverride Function CMS_Meeting_Get(PortalConnect As String, meeting_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Meeting_Check_By_Reg(PortalConnect As String, uid As Integer, mR_ID As Integer, months As Integer, years As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_Get_By_Day(PortalConnect As String, uid As Integer, startDate As DateTime, endDate As DateTime, room_id As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_List_Search(PortalConnect As String, UID As Integer, DID As String, EID As String, MR_ID As String, MonthID As Integer, YearID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_List_AppID(PortalConnect As String, UID As Integer, appID As String, EID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_Add(PortalConnect As String, obj As CMS_MeetingInfo) As Integer
    Public MustOverride Sub CMS_Meeting_Update(PortalConnect As String, obj As CMS_MeetingInfo)
    Public MustOverride Sub CMS_Meeting_Delete(PortalConnect As String, meeting_ID As Integer)
    Public MustOverride Function CMS_Meeting_Rpt_Group(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer) As IDataReader
    Public MustOverride Function CMS_Meeting_Rpt_List(PortalConnect As String, UID As Integer, ngay As Integer, thang As Integer, nam As Integer, mrID As Integer) As IDataReader

#End Region
#Region "CMS_MeetingRoom"
    Public MustOverride Function CMS_MeetingRoom_Get(PortalConnect As String, mR_ID As Integer) As IDataReader
    Public MustOverride Function CMS_MeetingRoom_Get_Mrcode(PortalConnect As String, MrCode As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_MeetingRoom_List(PortalConnect As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_MeetingRoom_List_search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_MeetingRoom_Add(PortalConnect As String, obj As CMS_MeetingRoomInfo) As Integer
    Public MustOverride Sub CMS_MeetingRoom_Update(PortalConnect As String, obj As CMS_MeetingRoomInfo)
    Public MustOverride Sub CMS_MeetingRoom_Delete(PortalConnect As String, mR_ID As Integer)
#End Region
#Region "CMS_Mission"
    Public MustOverride Function CMS_Mission_Get(PortalConnect As String, mission_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Mission_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Mission_List_AppID(PortalConnect As String, UID As Integer, AppID As String, ToEID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Mission_List_Manager(PortalConnect As String, UID As Integer, manageID As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Mission_List_Search(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Mission_List_Search_export(PortalConnect As String, UID As Integer, search As String, Status As Integer, yearID As Integer, MonthID As Integer, DiD As String) As IDataReader
    Public MustOverride Function CMS_Mission_Add(PortalConnect As String, obj As CMS_MissionInfo) As Integer
    Public MustOverride Sub CMS_Mission_Update_Manage(PortalConnect As String, Mission_ID As Integer, isActive As Boolean, userUpdate As String, dateUpdate As DateTime)
    Public MustOverride Sub CMS_Mission_Update_First(PortalConnect As String, Mission_ID As Integer, FirstKm As Double, FirstDate As DateTime, FirstUser As String)
    Public MustOverride Sub CMS_Mission_Update_Last(PortalConnect As String, Mission_ID As Integer, lastKm As Double, lastDate As DateTime, lastUser As String)
    Public MustOverride Sub CMS_Mission_Update_Approval(PortalConnect As String, Mission_ID As Integer, IsApproval As Boolean, ApprovalDate As DateTime, ApprovalUser As String, CarID As String, DriverName As String, DriverPhone As String, DriverNumber As String)
    Public MustOverride Sub CMS_Mission_Delete(PortalConnect As String, mission_ID As Integer)
#End Region
#Region "CMS_MissionCar"
    Public MustOverride Function CMS_MissionCar_Get(PortalConnect As String, car_ID As Integer) As IDataReader
    Public MustOverride Function CMS_MissionCar_List(PortalConnect As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_MissionCar_List_search(PortalConnect As String, search As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_MissionCar_List_UID(PortalConnect As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_MissionCar_Add(PortalConnect As String, obj As CMS_MissionCarInfo) As Integer
    Public MustOverride Sub CMS_MissionCar_Update(PortalConnect As String, obj As CMS_MissionCarInfo)
    Public MustOverride Sub CMS_MissionCar_Delete(PortalConnect As String, car_ID As Integer)
#End Region
#Region "CMS_Group"
    Public MustOverride Function CMS_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Group_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_List_UID(PortalConnect As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
    Public MustOverride Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
    Public MustOverride Sub CMS_Group_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_GroupU"
    Public MustOverride Function CMS_GroupU_List_Send(PortalConnect As String, GroupID As Integer) As IDataReader
    Public MustOverride Function CMS_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_GroupU_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_GroupU_List_Search(PortalConnect As String, search As String, GroupID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_GroupU_count(PortalConnect As String, GroupID As Integer, UID As Integer) As Integer
    Public MustOverride Function CMS_GroupU_Add(PortalConnect As String, obj As CMS_GroupUInfo) As Integer
    Public MustOverride Sub CMS_GroupU_Update(PortalConnect As String, obj As CMS_GroupUInfo)
    Public MustOverride Function CMS_GroupU_Get_By_CMS_Group(PortalConnect As String, iD As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_GroupU_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_Fr_Group"
    Public MustOverride Function CMS_Fr_Group_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_Group_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_Add(PortalConnect As String, obj As CMS_Fr_GroupInfo) As Integer
    Public MustOverride Sub CMS_Fr_Group_Update(PortalConnect As String, obj As CMS_Fr_GroupInfo)
    Public MustOverride Sub CMS_Fr_Group_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Fr_Group_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_TK(PortalConnect As String, uID As Integer, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_Group_ThongKe(PortalConnect As String, UID As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_NguoiDang(PortalConnect As String, UID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_GroupTV(PortalConnect As String, UID As Integer, ID As Integer) As IDataReader
    Public MustOverride Sub CMS_Fr_Group_Update_Lock(PortalConnect As String, ID As Integer, lock As Integer, lockuser As String)


#End Region
#Region "CMS_Fr_GroupU"
    Public MustOverride Function CMS_Fr_GroupU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Fr_GroupU_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Fr_GroupU_Add(PortalConnect As String, obj As CMS_Fr_GroupUInfo) As Integer
    Public MustOverride Sub CMS_Fr_GroupU_Update(PortalConnect As String, obj As CMS_Fr_GroupUInfo)
    Public MustOverride Function CMS_Fr_GroupU_Get_By_CMS_Fr_Group(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Sub CMS_Fr_GroupU_Delete_By_CMS_Fr_Group(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Fr_GroupU_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_SalaryM"
    Public MustOverride Function CMS_SalaryM_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_SalaryM_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_SalaryM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As IDataReader
    Public MustOverride Function CMS_SalaryM_Add(PortalConnect As String, obj As CMS_SalaryMInfo) As Integer
    Public MustOverride Sub CMS_SalaryM_Update(PortalConnect As String, obj As CMS_SalaryMInfo)
    Public MustOverride Sub CMS_SalaryM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
    Public MustOverride Sub CMS_SalaryM_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_SalaryM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As IDataReader

#End Region
#Region "CMS_TimeKeepM"
    Public MustOverride Function CMS_TimeKeepM_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_TimeKeepM_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TimeKeepM_Get_By_UID(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer) As IDataReader
    Public MustOverride Function CMS_TimeKeepM_Add(PortalConnect As String, obj As CMS_TimeKeepMInfo) As Integer
    Public MustOverride Sub CMS_TimeKeepM_Update(PortalConnect As String, obj As CMS_TimeKeepMInfo)
    Public MustOverride Function CMS_TimeKeepM_Update_ThacMac(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, ThacMac As String) As IDataReader
    Public MustOverride Sub CMS_TimeKeepM_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_TimeKeepM_Update_Lock(PortalConnect As String, UID As Integer, thang As Integer, nam As Integer, isLock As Boolean, lockDate As DateTime, lockUser As String)
#End Region
#Region "CMS_Group_Chat"
    Public MustOverride Function CMS_Group_Chat_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Group_Chat_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Group_Chat_List_AppID(PortalConnect As String, uID As Integer, appID As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Group_Chat_Add(PortalConnect As String, obj As CMS_Group_ChatInfo) As Integer
    Public MustOverride Sub CMS_Group_Chat_Update(PortalConnect As String, obj As CMS_Group_ChatInfo)
    Public MustOverride Sub CMS_Group_Chat_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_Group_Chat_List_TK(PortalConnect As String, uID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_Group_ChatU"
    Public MustOverride Function CMS_Group_ChatU_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Group_ChatU_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Group_ChatU_Add(PortalConnect As String, obj As CMS_Group_ChatUInfo) As Integer
    Public MustOverride Sub CMS_Group_ChatU_Update(PortalConnect As String, obj As CMS_Group_ChatUInfo)
    Public MustOverride Function CMS_Group_ChatU_Get_By_CMS_Group_Chat(PortalConnect As String, iD As Integer, page As Integer, recod As Integer) As IDataReader
    Public MustOverride Sub CMS_Group_ChatU_Delete_By_CMS_Group_Chat(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_Group_ChatU_Delete(PortalConnect As String, iD As Integer)
#End Region


End Class
