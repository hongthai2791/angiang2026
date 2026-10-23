Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.WORK", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_Counter"
    Public MustOverride Function CMS_Counter_Get(PortalConnect As String, portalID As Integer) As IDataReader
#End Region
#Region "CMS_Business"
    Public MustOverride Function CMS_Business_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As IDataReader
    Public MustOverride Function CMS_Business_List_By_TinhTP(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Business_List_By_TinhTP_ToApp(tinhTP As Integer, quanHuyen As String) As IDataReader
    Public MustOverride Function CMS_Business_List_LatLng(tinhTP As Integer, quanHuyen As String, phuongXa As String) As IDataReader
    Public MustOverride Function CMS_Business_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isSent As Boolean) As IDataReader
    Public MustOverride Function CMS_Business_List_By_TinhTP_IsSent(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isSent As Boolean) As IDataReader

    Public MustOverride Function CMS_Business_Get_UserAdmin(PortalConnect As String, UserAdmin As String) As IDataReader
    Public MustOverride Function CMS_Business_Get(PortalConnect As String, business_ID As String) As IDataReader
    Public MustOverride Function CMS_Business_Get_ToApp(tinhTP As Integer, business_ID As String) As IDataReader
    Public MustOverride Function CMS_Business_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Business_List_Approval(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, isActive As Boolean) As IDataReader
    Public MustOverride Function CMS_Business_List_Active(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isActive As Boolean) As IDataReader
    Public MustOverride Function CMS_Business_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As IDataReader
    Public MustOverride Sub CMS_Business_Add(PortalConnect As String, obj As CMS_BusinessInfo)
    Public MustOverride Sub CMS_Business_Add_All(PortalConnect As String, obj As CMS_BusinessInfo)
    Public MustOverride Sub SV_Business_Add(PortalConnect As String, business_ID As String, business_Vn As String, business_En As String, business_Sort As String, tinhTp As String, quanHuyen As String, logo As String, description As String, taxCode As String, mobile As String, fax As String, website As String, email As String, address As String, contactUser As String, contactMobile As String, contactEmail As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, portalId As Integer, Scale As String, idSend As String)
    Public MustOverride Function CMS_Business_Check(PortalConnect As String, obj As CMS_BusinessInfo) As String
    Public MustOverride Sub CMS_Business_Update(PortalConnect As String, obj As CMS_BusinessInfo)
    Public MustOverride Sub CMS_Business_Delete(PortalConnect As String, business_ID As String)
    Public MustOverride Function SV_Business_Get_By_IdKey(PortalConnect As String, portalId As Integer, idSend As String) As String
    Public MustOverride Sub CMS_Business_Update_Quick(PortalConnect As String, business_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
    Public MustOverride Sub CMS_Business_Update_IsSent(PortalConnect As String, business_ID As String, isSent As Boolean)
    Public MustOverride Sub CMS_Business_Update_LatLng(PortalConnect As String, business_ID As String, lat As String, lng As String)
    Public MustOverride Sub CMS_Business_Update_IsOffline(PortalConnect As String, business_ID As String, isOffline As Boolean)

    Public MustOverride Function CMS_Business_List_SVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_Business_List_NotJoinPhienGD(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_Business_List_SVL_QT(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String, Status As Integer) As IDataReader
    Public MustOverride Function CMS_Business_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_Business_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, quanHuyen As String, WBID As String) As IDataReader
    Public MustOverride Function CMS_Business_List_View_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_SendMail_Check(PortalConnect As String, Business_ID As String, PhienGD_ID As String) As Integer
    Public MustOverride Sub CMS_Business_Update_TinCay(PortalConnect As String, business_ID As String, tinCay As Boolean)
    Public MustOverride Function CMS_Business_List_TinCay(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isActive As Boolean) As IDataReader
    Public MustOverride Function CMS_Business_by_NLD(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As IDataReader

#End Region
#Region "CMS_BusUser"
    Public MustOverride Sub CMS_BusUser_Update_Admin(PortalConnect As String, UserAdmin As String, business_ID As String)
    Public MustOverride Function CMS_BusUser_Get_Business_User(PortalConnect As String, business_ID As String, UserAdmin As String) As IDataReader
    Public MustOverride Function CMS_BusUser_Get(PortalConnect As String, busUser_ID As String) As IDataReader
    Public MustOverride Function CMS_BusUser_List(PortalConnect As String) As IDataReader
    Public MustOverride Sub CMS_BusUser_Add(PortalConnect As String, obj As CMS_BusUserInfo)
    Public MustOverride Sub CMS_BusUser_Update(PortalConnect As String, obj As CMS_BusUserInfo)
    Public MustOverride Function CMS_BusUser_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As IDataReader
    Public MustOverride Sub CMS_BusUser_Delete(PortalConnect As String, busUser_ID As String)
    Public MustOverride Sub CMS_BusUser_Update_Active(PortalConnect As String, UserAdmin As String, IsActive As Boolean, ApprovalUser As String, ApprovalDate As DateTime)
    Public MustOverride Sub CMS_BusUser_Delete_By_UnAdmin(PortalConnect As String, busUser_ID As String, UserAdmin As String)
    Public MustOverride Sub CMS_BusUser_Add_Import(PortalConnect As String, obj As CMS_BusUserInfo)

#End Region
#Region "CMS_ProfileSave"
    Public MustOverride Function CMS_ProfileSave_Get(PortalConnect As String, profileSave_ID As String) As IDataReader
    Public MustOverride Function CMS_ProfileSave_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_ProfileSave_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer) As IDataReader
    Public MustOverride Sub CMS_ProfileSave_Add(PortalConnect As String, profileSave_ID As String, jobUser_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, business_ID As String)
    Public MustOverride Sub CMS_ProfileSave_Update(PortalConnect As String, profileSave_ID As String, jobUser_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, business_ID As String)
    Public MustOverride Sub CMS_ProfileSave_Delete(PortalConnect As String, profileSave_ID As String)
    Public MustOverride Sub CMS_ProfileSave_Update_Quick(PortalConnect As String, profileSave_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, updatedDate As DateTime, updatedUser As String)

#End Region
#Region "CMS_Recruitment"

    Public MustOverride Function CMS_Recruitment_List_UserName(PortalConnect As String, work_ID As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Send(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search_GT(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search_GTAG(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search_HSUT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_Recruitment_List_Search_QT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Sub CMS_Recruitment_Add(PortalConnect As String, recruitment_ID As String, work_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, JobUser_ID As String, IsInvite As Boolean)
    Public MustOverride Sub CMS_Recruitment_Update(PortalConnect As String, recruitment_ID As String, work_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, JobUser_ID As String, IsInvite As Boolean)
    Public MustOverride Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
    Public MustOverride Sub CMS_Recruitment_Update_Quick(PortalConnect As String, recruitment_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)

#End Region
#Region "CMS_Work"
    Public MustOverride Sub CMS_Work_Update_IsOffline(PortalConnect As String, work_ID As String, isOffline As Boolean)
    Public MustOverride Function CMS_Work_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isOffline As Boolean) As IDataReader
    Public MustOverride Function CMS_Work_List_Pages(PortalConnect As String, currPage As Integer, recodperpage As Integer, CareerID As String, TinhTP As Integer, EducationID As String, JobPlaceID As String, SalaryID As String, Experienceid As String, Genner As Integer, Title As String, Flag As Integer) As IDataReader
    Public MustOverride Function CMS_Work_List_Career(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Work_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Work_Get(PortalConnect As String, work_ID As String) As IDataReader
    Public MustOverride Function CMS_Work_Get_ToApp(tinhTP As Integer, work_ID As String) As IDataReader
    Public MustOverride Function CMS_Work_List_LatLng(tinhTP As Integer, quanHuyen As String, xaPhuong As String) As IDataReader
    Public MustOverride Function CMS_Work_List_Home(PortalConnect As String, IsFlag As Integer, Top As Integer, tinhTP As String) As IDataReader
    Public MustOverride Function CMS_Work_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Work_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Business_ID As String, Salary_ID As String, Experience_ID As String, quanHuyen As String, status As Integer, wbID As String) As IDataReader
    Public MustOverride Function CMS_Work_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As IDataReader
    Public MustOverride Function CMS_Work_List_Invite(PortalConnect As String, search As String, isFlag As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, status As Integer) As IDataReader
    Public MustOverride Sub CMS_Work_Add(PortalConnect As String, work_ID As String, business_ID As String, title As String, salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer, level_ID As String, TinhTP As String, quanhuyen As String, phuongXa As String, typeOf_ID As String, career_ID As String, description As String, requirement As String, benefit As String, requirementsProfile As String, expiredDate As DateTime,
                                         submissionSend As String, startDate As DateTime, endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String, contactEmail As String, contactDes As String, isHot As Boolean, isGhim As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, Ages As String, WorkTime As String, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime,
                                         createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, isFlag As Integer, JobPlace As String)
    Public MustOverride Sub SV_Work_Add(PortalConnect As String, work_ID As String, business_ID As String, title As String, salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer, level_ID As String, TinhTP As String, quanhuyen As String, typeOf_ID As String, career_ID As String, description As String, requirement As String, benefit As String, requirementsProfile As String, expiredDate As DateTime,
                                         submissionSend As String, startDate As DateTime, endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String, contactEmail As String, contactDes As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime,
                                         createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, isFlag As Integer, JobPlace As String, IdSend As String)
    Public MustOverride Sub CMS_Work_Update(PortalConnect As String, work_ID As String, business_ID As String, title As String, salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer, level_ID As String, TinhTP As String, quanhuyen As String, phuongXa As String, typeOf_ID As String, career_ID As String, description As String, requirement As String, benefit As String, requirementsProfile As String, expiredDate As DateTime,
                                            submissionSend As String, startDate As DateTime, endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String, contactEmail As String, contactDes As String, isHot As Boolean, isGhim As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, Ages As String, WorkTime As String, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime,
                                            createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, JobPlace As String)
    Public MustOverride Sub CMS_Work_Delete(PortalConnect As String, work_ID As String)
    Public MustOverride Function CMS_Work_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As IDataReader
    Public MustOverride Function CMS_Work_List_By_Business_Home(PortalConnect As String, business_ID As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_Work_Update_Delete(PortalConnect As String, work_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
    Public MustOverride Sub CMS_Work_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
    Public MustOverride Sub CMS_Work_Update_View(PortalConnect As String, work_ID As String)
    Public MustOverride Sub CMS_Work_Update_Sent(PortalConnect As String, work_ID As String)
    Public MustOverride Sub CMS_Work_Update_LatLng(PortalConnect As String, work_ID As String, lat As String, lng As String)
#End Region
#Region "CMS_JobUser"
    Public MustOverride Function CMS_JUser_List_GTVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Work_ID As String) As IDataReader
    Public MustOverride Function CMS_JobUser_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
    Public MustOverride Function CMS_JobUser_List_SendMail(PortalConnect As String, IdKey As String, Flag As Integer) As IDataReader
    Public MustOverride Function CMS_JobUser_Get(PortalConnect As String, jobUser_ID As String) As IDataReader
    Public MustOverride Function CMS_JobUser_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_JobUser_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String) As IDataReader
    Public MustOverride Function CMS_JobUser_List_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String) As IDataReader
    Public MustOverride Function CMS_JobUser_List_Home_BKUV(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Level_ID As String, LevelDesired As String, Salary_ID As String, Experience_ID As String, tinhTP As String, GioiTinh As String) As IDataReader
    Public MustOverride Sub CMS_JobUser_Add(PortalConnect As String, jobUser_ID As String, title As String, career_ID As String, currentLevel As String, levelDesired As String, tinhTP As String, quanHuyen As String, experience_ID As String, level_ID As String, salary_ID As String, needs_ID As String, education As String, careerGoals As String, WorkExperience As String, skillsForte As String, userAdmin As String, startDate As DateTime, endDate As DateTime, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer)
    Public MustOverride Sub CMS_JobUser_AddFromBTHN(PortalConnect As String, obj As CMS_JobUserInfo, objJ As CMS_JobUserBHTNInfo)
    Public MustOverride Sub CMS_JobUser_Update(PortalConnect As String, jobUser_ID As String, title As String, career_ID As String, currentLevel As String, levelDesired As String, tinhTP As String, quanHuyen As String, experience_ID As String, level_ID As String, salary_ID As String, needs_ID As String, education As String, careerGoals As String, WorkExperience As String, skillsForte As String, userAdmin As String, startDate As DateTime, endDate As DateTime, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer)
    Public MustOverride Sub CMS_JobUser_Delete(PortalConnect As String, jobUser_ID As String)
    Public MustOverride Sub CMS_JobUser_Update_Quick(PortalConnect As String, jobUser_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
    Public MustOverride Sub CMS_JobUser_Update_Delete(PortalConnect As String, work_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
    Public MustOverride Function CMS_JobUser_List_UserName(PortalConnect As String, portalID As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_JobUser_Update_View(PortalConnect As String, jobUser_ID As String)
#End Region
#Region "CMS_JobView"
    Public MustOverride Function CMS_JobView_Check(PortalConnect As String, idKey As String, usName As String) As Integer
    Public MustOverride Function CMS_JobView_Get(PortalConnect As String, jobView_ID As String) As IDataReader
    Public MustOverride Function CMS_JobView_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobView_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, IsFlag As Integer, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String) As IDataReader
    Public MustOverride Sub CMS_JobView_Add(PortalConnect As String, jobView_ID As String, idKey As String, isFlag As Integer, userName As String, createDate As DateTime)
    Public MustOverride Sub CMS_JobView_Update(PortalConnect As String, jobView_ID As String, idKey As String, isFlag As Integer, userName As String, createDate As DateTime)
    Public MustOverride Sub CMS_JobView_Delete(PortalConnect As String, jobView_ID As String)

#End Region
#Region "CMS_JobInvite"
    Public MustOverride Function CMS_WorkInvite_Check(PortalConnect As String, WorkID As String, BusID As String) As Integer
    Public MustOverride Function CMS_JobInvite_Check(PortalConnect As String, idKey As String, usName As String) As Integer
    Public MustOverride Function CMS_JobInvite_Get(PortalConnect As String, JobInvite_ID As String) As IDataReader
    Public MustOverride Function CMS_JobInvite_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobInvite_List_ByIdKey(PortalConnect As String, idKey As String, userName As String) As IDataReader
    Public MustOverride Function CMS_JobInvite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String) As IDataReader
    Public MustOverride Function CMS_JobInvite_List_Search_users(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String, userName As String) As IDataReader
    Public MustOverride Sub CMS_JobInvite_Add(PortalConnect As String, JobInvite_ID As String, WorkID As String, JobID As String, BusID As String, UserName As String, createDate As DateTime)
    Public MustOverride Sub CMS_JobInvite_Update(PortalConnect As String, JobInvite_ID As String, WorkID As String, JobID As String, BusID As String, UserName As String, createDate As DateTime)
    Public MustOverride Sub CMS_JobInvite_Delete(PortalConnect As String, JobInvite_ID As String)
    Public MustOverride Function CMS_JobInvite_Update_Status(PortalConnect As String, JobInvite_ID As String, IsStatus As Integer) As String


#End Region
#Region "CMS_DoanhNghiep"
    Public MustOverride Function CMS_Work_List_By_PhienGD(PortalConnect As String, PhienGD_ID As String, Career_ID As String, Position_ID As String, Level_ID As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_List_Home(PortalConnect As String, Career_ID As String, Search As String, IsOrder As Integer, PhienGD_ID As String) As IDataReader

    Public MustOverride Sub CMS_DoanhNghiep_Add(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_Replace(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_Update(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_Delete(PortalConnect As String, doanhNghiep_ID As String)
    Public MustOverride Sub CMS_DoanhNghiep_Update_Quick(PortalConnect As String, phienGD_ID As String, business_ID As String, soBan As Integer, tinhTrangThamGia As Integer, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_Delete_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String)

#End Region
#Region "CMS_DoanhNghiep_UngVien"
    Public MustOverride Function CMS_DoanhNghiep_UngVien_TinhTrang(PortalConnect As String, PhienGiaoDich_ID As String, TuyenDung_ID As String, NguoiTimViec_ID As String, IsInvite As Boolean) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(PortalConnect As String, phienGD_ID As String, UngViend_ID As String) As IDataReader
    Public MustOverride Function CMS_Work_List_TuyenDungName(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, doanhnghiep_id As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien(PortalConnect As String, phienGD_ID As String, BusinessID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_Business(PortalConnect As String, phienGD_ID As String, BusinessID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_Business_MoiUV(PortalConnect As String, phienGD_ID As String, BusinessID As String, IsStatus As Integer) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_UserName(PortalConnect As String, phienGD_ID As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get(PortalConnect As String, dNUV_ID As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_DoanhNghiep_UngVien_Get_By_PhienGD(PortalConnect As String, phienGD_ID As String) As IDataReader

    Public MustOverride Sub CMS_DoanhNghiep_UngVien_Add(PortalConnect As String, dNUV_ID As String, DoanhNghiep_ID As String, phienGD_ID As String, ungVien_ID As String, banPhongVan As Integer, tinhTrangPhongVan As Integer, ketQuaPhongVan As Integer, chiTietPhongVan As String, thuTuPhongVan As Integer, tuyenDung_ID As String, tuyenDungName As String, viTriDat As String, viTriDatName As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_UngVien_Update(PortalConnect As String, dNUV_ID As String, DoanhNghiep_ID As String, phienGD_ID As String, ungVien_ID As String, banPhongVan As Integer, tinhTrangPhongVan As Integer, ketQuaPhongVan As Integer, chiTietPhongVan As String, thuTuPhongVan As Integer, tuyenDung_ID As String, tuyenDungName As String, viTriDat As String, viTriDatName As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
    Public MustOverride Sub CMS_DoanhNghiep_UngVien_Delete(PortalConnect As String, dNUV_ID As String)
    Public MustOverride Sub CMS_DoanhNghiep_UngVien_RoiBan(PortalConnect As String, phienGD_ID As String, UngViend_ID As String)
    Public MustOverride Sub CMS_DoanhNghiep_UngVien_Update_DoanhNghiep(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, DoanhNghiep_ID As String)
    Public MustOverride Sub CMS_DoanhNghiep_UngVien_Update_Status(PortalConnect As String, DNUV_ID As String, IsStatus As Boolean)
    Public MustOverride Sub CMS_DoanhNghiep_Update_KetQua(PortalConnect As String, dNUV_ID As String, ketQuaPhongVan As String, updatedBy As DateTime, userUpdate As String)

#End Region
#Region "CMS_PhienGiaoDich"

    Public MustOverride Function CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat(PortalConnect As String, portalId As Integer) As String
    Public MustOverride Function CMS_ThongKeBaoCao_SanVL(PortalConnect As String, phienGD_ID As String, Business_ID As String) As IDataReader
    Public MustOverride Function CMS_PhienGiaoDich_Get(PortalConnect As String, phienGD_ID As String) As IDataReader

    Public MustOverride Function CMS_PhienGiaoDich_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_PhienGiaoDich_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_PhienGiaoDich_List_Search_Member(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader

    Public MustOverride Sub CMS_PhienGiaoDich_Add(PortalConnect As String, phienGD_ID As String, tenPhien As String, TinhTP As String, diaDiem As String, thoiGian_BatDau As DateTime, thoiGian_KetThuc As DateTime, isActive As Boolean, loaiPhien As Integer, hotline As String, email As String, moTa As String, ketQua As String, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String, portalId As Integer)
    Public MustOverride Sub CMS_PhienGiaoDich_Update(PortalConnect As String, phienGD_ID As String, tenPhien As String, TinhTP As String, diaDiem As String, thoiGian_BatDau As DateTime, thoiGian_KetThuc As DateTime, isActive As Boolean, loaiPhien As Integer, hotline As String, email As String, moTa As String, ketQua As String, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String, portalId As Integer)
    Public MustOverride Sub CMS_PhienGiaoDich_Delete(PortalConnect As String, phienGD_ID As String)

#End Region
#Region "CMS_TuyenDung"
    Public MustOverride Function CMS_TuyenDung_Get(PortalConnect As String, tuyenDung_ID As String) As IDataReader
    Public MustOverride Function CMS_TuyenDung_Get_ByWork(PortalConnect As String, Business_ID As String, workID As String, phienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_TuyenDung_List_By_PhienGD(PortalConnect As String, phienGD_ID As String, Business_ID As String) As IDataReader
    Public MustOverride Function CMS_TuyenDung_List_Search(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer) As IDataReader
    Public MustOverride Function CMS_TuyenDung_List_Search_VL(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer, IsApproval As Boolean) As IDataReader
    Public MustOverride Function CMS_Job_ID_Member(PortalConnect As String, UngVien_ID As String, Work_ID As String) As String
    Public MustOverride Function CMS_TuyenDung_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TuyenDung_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
    Public MustOverride Sub CMS_TuyenDung_Add(PortalConnect As String, tuyenDung_ID As String, doanhNghiep_ID As String, work_ID As String, phienGD_ID As String, createdBy As DateTime, userName As String)
    Public MustOverride Sub CMS_TuyenDung_Update(PortalConnect As String, tuyenDung_ID As String, doanhNghiep_ID As String, work_ID As String, phienGD_ID As String, createdBy As DateTime, userName As String)
    Public MustOverride Sub CMS_TuyenDung_Delete(PortalConnect As String, tuyenDung_ID As String)

#End Region
#Region "CMS_UngVien"
    Public MustOverride Function CMS_UngVien_CheckByUserName(PortalConnect As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_UngVien_Get_By_UserName(PortalConnect As String, UserName As String, PhienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_UngVien_Get(PortalConnect As String, ungVien_ID As String) As IDataReader
    Public MustOverride Function CMS_UngVien_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_UngVien_List_PhienGD_ID(PortalConnect As String, PhienGD_ID As String) As IDataReader
    Public MustOverride Function CMS_UngVien_Get_PhienGD_ID(PortalConnect As String, PhienGD_ID As String, UserName As String) As IDataReader

    Public MustOverride Sub CMS_UngVien_Add(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
    Public MustOverride Sub CMS_UngVien_Update(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
    Public MustOverride Sub CMS_UngVien_Replace(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
    Public MustOverride Sub CMS_UngVien_Delete(PortalConnect As String, ungVien_ID As String)

#End Region
#Region "CMS_UserWork"

    Public MustOverride Function CMS_UserWork_Check(PortalConnect As String, UngVienID As String, WorkID As String) As Boolean
    Public MustOverride Function CMS_UserWork_Get(PortalConnect As String, userWork_ID As String) As IDataReader
    Public MustOverride Function CMS_UserWork_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_UserWork_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
    Public MustOverride Function CMS_UserWork_List_Search(PortalConnect As String, work_ID As String, doanhNghiep_ID As String) As IDataReader
    Public MustOverride Sub CMS_UserWork_Add(PortalConnect As String, userWork_ID As String, ungVien_ID As String, work_ID As String, Job_ID As String, doanhNghiep_ID As String, createdBy As DateTime)
    Public MustOverride Sub CMS_UserWork_Update(PortalConnect As String, userWork_ID As String, ungVien_ID As String, work_ID As String, doanhNghiep_ID As String, createdBy As DateTime)
    Public MustOverride Sub CMS_UserWork_Delete(PortalConnect As String, userWork_ID As String)

#End Region
#Region "CMS_RegEmail"
    Public MustOverride Sub CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime)
    Public MustOverride Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_ConEmail_Add(PortalConnect As String, ConEmail_ID As String, SendDate As DateTime, Contents As String, UserName As String)
    Public MustOverride Function CMS_ConEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader

#End Region
#Region "CMS_Career"
    Public MustOverride Function CMS_Career_List_Home(PortalConnect As String, top As Integer) As IDataReader
    Public MustOverride Function CMS_Career_List_Job(PortalConnect As String, top As Integer) As IDataReader
    Public MustOverride Function CMS_Career_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
    Public MustOverride Function CMS_Career_Get(PortalConnect As String, career_ID As String) As IDataReader
    Public MustOverride Function CMS_Career_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
    Public MustOverride Sub SV_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
    Public MustOverride Sub CMS_Career_Update(PortalConnect As String, obj As CMS_CareerInfo)
    Public MustOverride Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
    Public MustOverride Function SV_Career_Get_By_IdKey(PortalConnect As String, career_Code As String) As String
#End Region
#Region "CMS_Experience"
    Public MustOverride Function SV_Experience_Get_By_IdKey(PortalConnect As String, experienceCode As String) As String
    Public MustOverride Function CMS_Experience_Get(PortalConnect As String, experience_ID As String) As IDataReader
    Public MustOverride Function CMS_Experience_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Experience_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
    Public MustOverride Sub SV_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
    Public MustOverride Sub CMS_Experience_Update(PortalConnect As String, obj As CMS_ExperienceInfo)
    Public MustOverride Sub CMS_Experience_Delete(PortalConnect As String, experience_ID As String)
#End Region
#Region "CMS_JobPlace"
    Public MustOverride Function SV_JobPlace_Get_By_IdKey(PortalConnect As String, jobPlace_Code As String) As String
    Public MustOverride Function CMS_JobPlace_Get_Code(PortalConnect As String, jobPlace_Code As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_Get(PortalConnect As String, jobPlace_ID As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_Get_Parents(PortalConnect As String, parent_ID As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_List_parent(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_List_parent_ID(PortalConnect As String, parent_ID As String) As IDataReader
    Public MustOverride Function CMS_JobPlace_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_JobPlace_Add(PortalConnect As String, obj As CMS_JobPlaceInfo)
    Public MustOverride Sub CMS_JobPlace_Update(PortalConnect As String, obj As CMS_JobPlaceInfo)
    Public MustOverride Sub CMS_JobPlace_Delete(PortalConnect As String, jobPlace_ID As String)
#End Region
#Region "CMS_Needs"
    Public MustOverride Function SV_Needs_Get_By_IdKey(PortalConnect As String, needs_Code As String) As String
    Public MustOverride Function CMS_Needs_Get(PortalConnect As String, needs_ID As String) As IDataReader
    Public MustOverride Function CMS_Needs_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Needs_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
    Public MustOverride Sub SV_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
    Public MustOverride Sub CMS_Needs_Update(PortalConnect As String, obj As CMS_NeedsInfo)
    Public MustOverride Sub CMS_Needs_Delete(PortalConnect As String, needs_ID As String)
#End Region
#Region "CMS_Salary"
    Public MustOverride Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
    Public MustOverride Function CMS_Salary_List(PortalConnect As String) As IDataReader
    Public MustOverride Function SV_Salary_Get_By_IdKey(PortalConnect As String, salaryCode As String) As String
    Public MustOverride Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Sub CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
    Public MustOverride Sub SV_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
    Public MustOverride Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
    Public MustOverride Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
#End Region
#Region "CMS_TypeOf"
    Public MustOverride Function CMS_TypeOf_Get(PortalConnect As String, typeOf_ID As String) As IDataReader
    Public MustOverride Function CMS_TypeOf_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TypeOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Sub CMS_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
    Public MustOverride Sub SV_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
    Public MustOverride Sub CMS_TypeOf_Update(PortalConnect As String, obj As CMS_TypeOfInfo)
    Public MustOverride Sub CMS_TypeOf_Delete(PortalConnect As String, typeOf_ID As String)
    Public MustOverride Function SV_TypeOf_Get_By_IdKey(PortalConnect As String, typeOf_Code As String) As String
#End Region
#Region "RPT"
    Public MustOverride Function CMS_RPT_JobSeeker(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As IDataReader
    Public MustOverride Function CMS_RPT_Employer(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As IDataReader
    Public MustOverride Function CMS_RPT_SanVL2(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Function CMS_RPT_SanVL1(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
    Public MustOverride Function CMS_EventLog_List_By_MonthYear(PortalConnect As String, logMonth As Integer, logYear As Integer, portalID As Integer) As IDataReader
#End Region
#Region "RPT_Data"
    Public MustOverride Function RPT_Data_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function RPT_Data_List(PortalConnect As String) As IDataReader
    Public MustOverride Function RPT_Data_Add(PortalConnect As String, rpt_ID As Integer, cot_ID As Integer, dong_ID As Integer, giaTri As String, isOrder As Integer, isFlag As Integer, IsCenter As Boolean) As Integer
    Public MustOverride Sub RPT_Data_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, cot_ID As Integer, dong_ID As Integer, giaTri As String, isOrder As Integer, isFlag As Integer, IsCenter As Boolean)
    Public MustOverride Function RPT_Data_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As IDataReader
    Public MustOverride Sub RPT_Data_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
    Public MustOverride Sub RPT_Data_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "RPT_Label"
    Public MustOverride Function RPT_Label_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function RPT_Label_List(PortalConnect As String) As IDataReader
    Public MustOverride Function RPT_Label_Add(PortalConnect As String, rpt_ID As Integer, cot_ID As Integer, tieuDe As String, rowspan As Integer, colspan As Integer, isOrder As Integer, isRows As Integer, IsColumn As Integer, width As String, IsData As Boolean, IsFlag As Integer) As Integer
    Public MustOverride Sub RPT_Label_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, cot_ID As Integer, tieuDe As String, rowspan As Integer, colspan As Integer, isOrder As Integer, isRows As Integer, IsColumn As Integer, width As String, IsData As Boolean, IsFlag As Integer)
    Public MustOverride Function RPT_Label_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer, isRows As Integer) As IDataReader
    Public MustOverride Sub RPT_Label_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
    Public MustOverride Sub RPT_Label_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "RPT_Reports"
    Public MustOverride Function RPT_Reports_Get_Rpt(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer) As IDataReader
    Public MustOverride Function RPT_Reports_Get(PortalConnect As String, rpt_ID As Integer) As IDataReader
    Public MustOverride Function RPT_Reports_List(PortalConnect As String) As IDataReader
    Public MustOverride Function RPT_Reports_Add(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer, Other As String, Rpt_Type As String) As Integer
    Public MustOverride Sub RPT_Reports_Update(PortalConnect As String, rpt_ID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer)
    Public MustOverride Sub RPT_Reports_Delete(PortalConnect As String, rpt_ID As Integer)
#End Region
#Region "RPT_Rows"
    Public MustOverride Function RPT_Rows_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function RPT_Rows_List(PortalConnect As String) As IDataReader
    Public MustOverride Function RPT_Rows_Add(PortalConnect As String, rpt_ID As Integer, STT As String, dong_ID As Integer, tieuDe As String, isOrder As Integer, IsBold As Boolean, IsFlag As Integer) As Integer
    Public MustOverride Sub RPT_Rows_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, dong_ID As Integer, tieuDe As String, isOrder As Integer, IsBold As Boolean, IsFlag As Integer)
    Public MustOverride Function RPT_Rows_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As IDataReader
    Public MustOverride Sub RPT_Rows_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
    Public MustOverride Sub RPT_Rows_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_DashBoard"
    Public MustOverride Function CMS_DashBoard_Admin_6Thang(PortalConnect As String, Num1 As Date, Num2 As Date, Num3 As Date, Num4 As Date, Num5 As Date, Num6 As Date) As IDataReader
    Public MustOverride Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
    Public MustOverride Function CMS_DashBoard_Business(PortalConnect As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_DashBoard_Business_Moi(PortalConnect As String, BusID As String) As IDataReader
    Public MustOverride Function CMS_DashBoard_User(PortalConnect As String, UserName As String) As IDataReader
    Public MustOverride Function CMS_DashBoard_User_ListJob(PortalConnect As String, UserName As String, career_id As String, top As Integer) As IDataReader
    Public MustOverride Function CMS_DashBoard_Business_ListJob(PortalConnect As String, Business_ID As String, top As Integer, CareerID As String) As IDataReader
#End Region
#Region "CMS_WorkCareer"
    Public MustOverride Function CMS_WorkCareer_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_WorkCareer_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_WorkCareer_Add(PortalConnect As String, obj As CMS_WorkCareerInfo) As Integer
    Public MustOverride Sub CMS_WorkCareer_Update(PortalConnect As String, obj As CMS_WorkCareerInfo)
    Public MustOverride Function CMS_WorkCareer_Get_By_CMS_Work(PortalConnect As String, work_ID As String) As IDataReader
    Public MustOverride Sub CMS_WorkCareer_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_WorkCareer_Delete_By_CMS_Work(PortalConnect As String, work_ID As String)
#End Region
#Region "CMS_Search"
    Public MustOverride Function CMS_Search_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_Search_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Search_Add(PortalConnect As String, obj As CMS_SearchInfo) As Integer
    Public MustOverride Sub CMS_Search_Update(PortalConnect As String, obj As CMS_SearchInfo)
    Public MustOverride Sub CMS_Search_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_EventLog"
    Public MustOverride Function CMS_EventLog_Get(PortalConnect As String, evenLog_ID As Integer) As IDataReader
    Public MustOverride Function CMS_EventLog_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_EventLog_Add(PortalConnect As String, obj As CMS_EventLogInfo) As Integer
    Public MustOverride Sub CMS_EventLog_Update(PortalConnect As String, obj As CMS_EventLogInfo)
    Public MustOverride Sub CMS_EventLog_Delete(PortalConnect As String, evenLog_ID As Integer)
#End Region
#Region "CMS_SystemStatistic"

    Public MustOverride Function CMS_System_Statistic(PortalConnect As String, tinhTP As Integer, fromDate As DateTime, toDate As DateTime, isTotal As Boolean) As IDataReader
#End Region
#Region "CMS_NewsFeedback"
    Public MustOverride Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, ID As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
    Public MustOverride Function CMS_NewsFeedback_List_Search(PortalConnect As String, ID As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, IsFeed As Integer) As IDataReader
    Public MustOverride Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
    Public MustOverride Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
    Public MustOverride Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
#End Region
#Region "CMS_NewsFeedBack_History"
    Public MustOverride Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
#End Region
#Region "CMS_SendMail"
    Public MustOverride Sub CMS_SendMail_Add(PortalConnect As String, DoanhNghiep_ID As String, PhienGD_ID As String, NgayGui As DateTime)
#End Region
#Region "CMS_GTVL"
    Public MustOverride Function CMS_GTVL_Add(PortalConnect As String, obj As CMS_GTVLInfo) As Integer
    Public MustOverride Function CMS_GTVL_List(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
    Public MustOverride Sub CMS_GTVL_Update_Quick(PortalConnect As String, ID As Integer, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_GTVL_Update_Acess(PortalConnect As String, ID As Integer, isval As Boolean, isflag As Integer, updatedDate As DateTime, updatedUser As String)

#End Region
#Region "BHTN"
    Public MustOverride Function Off_Count_Hosodangky(PortalConnect As String, portalID As Integer) As Integer
    Public MustOverride Function CMS_JobUserBHTN_List_Search(ByVal Keyword As String, ByVal Trinhdo As Integer, ByVal Vitri As Integer, ByVal Mucluong As Integer, ByVal Nganhnghe As Integer, ByVal portalID As Integer, ByVal fromRow As Integer, ByVal toRow As Integer) As IDataReader
    Public MustOverride Function Off_GTVL_TrinhDoDaoTao_GetAll(ByVal idHoSo As Guid) As IDataReader
    Public MustOverride Function Off_GTVL_QuaTrinhLamViec_GetAll(ByVal idHoSo As Guid) As IDataReader
    Public MustOverride Function DanhMucChungBHTN_List(ByVal loai As String) As IDataReader
    Public MustOverride Function GetHoSoBHTN(ByVal portalBHTN As Integer, ByVal sosoBHXH As String) As IDataReader
#End Region
#Region "ND23_PLI"
    Public MustOverride Function ND23_PLI_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function ND23_PLI_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ND23_PLI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader

    Public MustOverride Function ND23_PLI_Add(PortalConnect As String, obj As ND23_PLIInfo) As Integer
    Public MustOverride Sub ND23_PLI_Update(PortalConnect As String, obj As ND23_PLIInfo)
    Public MustOverride Sub ND23_PLI_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub ND23_PLI_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "ND23_PLIA"
    Public MustOverride Function ND23_PLIA_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function ND23_PLIA_Get_ByPLID(PortalConnect As String, PLID As Integer) As IDataReader
    Public MustOverride Function ND23_PLIA_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ND23_PLIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function ND23_PLIA_Add(PortalConnect As String, obj As ND23_PLIAInfo) As Integer
    Public MustOverride Sub ND23_PLIA_Update(PortalConnect As String, obj As ND23_PLIAInfo)
    Public MustOverride Sub ND23_PLIA_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub ND23_PLIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "ND23_PLII"
    Public MustOverride Function ND23_PLII_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function ND23_PLII_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ND23_PLII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader

    Public MustOverride Function ND23_PLII_Add(PortalConnect As String, obj As ND23_PLIIInfo) As Integer
    Public MustOverride Sub ND23_PLII_Update(PortalConnect As String, obj As ND23_PLIIInfo)
    Public MustOverride Sub ND23_PLII_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub ND23_PLII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "ND23_PLIII"
    Public MustOverride Function ND23_PLIII_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function ND23_PLIII_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ND23_PLIII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader

    Public MustOverride Function ND23_PLIII_Add(PortalConnect As String, obj As ND23_PLIIIInfo) As Integer
    Public MustOverride Sub ND23_PLIII_Update(PortalConnect As String, obj As ND23_PLIIIInfo)
    Public MustOverride Sub ND23_PLIII_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub ND23_PLIII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "ND23_PLIIIA"
    Public MustOverride Function ND23_PLIIIA_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function ND23_PLIIIA_List(PortalConnect As String) As IDataReader
    Public MustOverride Function ND23_PLIIIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function ND23_PLIIIA_Add(PortalConnect As String, obj As ND23_PLIIIAInfo) As Integer
    Public MustOverride Sub ND23_PLIIIA_Update(PortalConnect As String, obj As ND23_PLIIIAInfo)
    Public MustOverride Sub ND23_PLIIIA_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub ND23_PLIIIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_JobHistory"
    Public MustOverride Function CMS_JobHistory_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_JobHistory_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobHistory_List_ByJobUserID(PortalConnect As String, jobUserrID As String) As IDataReader

    Public MustOverride Function CMS_JobHistory_Add(PortalConnect As String, obj As CMS_JobHistoryInfo) As Integer
    Public MustOverride Sub CMS_JobHistory_Update(PortalConnect As String, obj As CMS_JobHistoryInfo)
    Public MustOverride Sub CMS_JobHistory_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_JobHistory_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_JobUserRefer"
    Public MustOverride Function CMS_JobUserRefer_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_JobUserRefer_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_JobUserRefer_List_ByJobUserID(PortalConnect As String, jobUserID As String) As IDataReader

    Public MustOverride Function CMS_JobUserRefer_Add(PortalConnect As String, obj As CMS_JobUserReferInfo) As Integer
    Public MustOverride Sub CMS_JobUserRefer_Update(PortalConnect As String, obj As CMS_JobUserReferInfo)
    Public MustOverride Sub CMS_JobUserRefer_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_JobUserRefer_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "CMS_CareerCLD"
    Public MustOverride Function CMS_CareerCLD_Get(PortalConnect As String, CareerCLD_ID As Integer) As IDataReader
    Public MustOverride Function CMS_CareerCLD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CareerCLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_CareerCLD_Add(PortalConnect As String, obj As CMS_CareerCLDInfo) As Integer
    Public MustOverride Sub CMS_CareerCLD_Update(PortalConnect As String, obj As CMS_CareerCLDInfo)
    Public MustOverride Sub CMS_CareerCLD_Delete(PortalConnect As String, CareerCLD_ID As Integer)
#End Region

#Region "CMS_Method"
    Public MustOverride Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Method_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Method_Add(PortalConnect As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Method_Update(PortalConnect As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
    Public MustOverride Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "CMS_Specialize"
    Public MustOverride Function CMS_Specialize_GetByCode(PortalConnect As String, specialize_code As String) As IDataReader
    Public MustOverride Function CMS_Specialize_Get(PortalConnect As String, specialize_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Specialize_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Specialize_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Specialize_Add(PortalConnect As String, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Specialize_Update(PortalConnect As String, specialize_ID As Integer, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Specialize_Delete(PortalConnect As String, specialize_ID As Integer)
    Public MustOverride Sub CMS_Specialize_Update_Quick(PortalConnect As String, specialize_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "CMS_Trainning"
    Public MustOverride Function CMS_Trainning_Get(PortalConnect As String, trainning_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Trainning_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Trainning_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Trainning_Add(PortalConnect As String, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Trainning_Update(PortalConnect As String, trainning_ID As Integer, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Trainning_Delete(PortalConnect As String, trainning_ID As Integer)
    Public MustOverride Sub CMS_Trainning_Update_Quick(PortalConnect As String, trainning_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_TypeEco"
    Public MustOverride Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As IDataReader
    Public MustOverride Function CMS_TypeEco_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_TypeEco_Add(PortalConnect As String, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_TypeEco_Update(PortalConnect As String, typeEco_ID As Integer, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
    Public MustOverride Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_WorkJoin"
    Public MustOverride Function CMS_WorkJoin_Get(PortalConnect As String, workJoin_ID As Integer) As IDataReader
    Public MustOverride Function CMS_WorkJoin_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_WorkJoin_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_WorkJoin_Add(PortalConnect As String, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_WorkJoin_Update(PortalConnect As String, workJoin_ID As Integer, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_WorkJoin_Delete(PortalConnect As String, workJoin_ID As Integer)
    Public MustOverride Sub CMS_WorkJoin_Update_Quick(PortalConnect As String, workJoin_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_BanBe"
    Public MustOverride Function CMS_BanBe_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_BanBe_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BanBe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_BanBe_Add(PortalConnect As String, obj As CMS_BanBeInfo) As Integer
    Public MustOverride Sub CMS_BanBe_Update(PortalConnect As String, obj As CMS_BanBeInfo)
    Public MustOverride Sub CMS_BanBe_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_WorkExtend"
    Public MustOverride Function CMS_WorkExtend_Get(PortalConnect As String, work_ID As String) As IDataReader
    Public MustOverride Function CMS_WorkExtend_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_WorkExtend_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As IDataReader
    Public MustOverride Function CMS_WorkExtend_Add(PortalConnect As String, obj As CMS_WorkExtendInfo) As Integer
    Public MustOverride Sub CMS_WorkExtend_Update(PortalConnect As String, obj As CMS_WorkExtendInfo)
    Public MustOverride Sub CMS_WorkExtend_Delete(PortalConnect As String, work_ID As String)
    Public MustOverride Sub CMS_WorkExtend_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
#End Region
#Region "Add list data to database"
    Public MustOverride Sub CMS_Excute_DataTable(PortalConnect As String, procName As String, items As DataTable)
#End Region
#Region "Mapping data"
    Public MustOverride Function MAPWork_GetByMapId(Of T As IMappingInfo)(PortalConnect As String, id As String, Optional customTableName As String = "") As IDataReader
    Public MustOverride Sub MAPWork_DeleteByMapId(Of T As IMappingInfo)(PortalConnect As String, id As String, Optional customTableName As String = "")
#End Region
#Region "CMS_JobUserExtra"
    Public MustOverride Function CMS_JobUserExtra_Get(PortalConnect As String, jobUser_ID As String) As IDataReader
    Public MustOverride Function CMS_JobUserExtra_Add(PortalConnect As String, obj As CMS_JobUserExtraInfo) As Integer
#End Region


#Region "CMS_NgheCongViec"
    Public MustOverride Function CMS_NgheCongViec_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_NgheCongViec_Get(PortalConnect As String, career_ID As String) As IDataReader
#End Region
#Region "CMS_WorkReport"
    Public MustOverride Function CMS_WorkReport_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_WorkReport_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_WorkReport_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_WorkReport_Add(PortalConnect As String, obj As CMS_WorkReportInfo) As Integer
    Public MustOverride Sub CMS_WorkReport_Update(PortalConnect As String, obj As CMS_WorkReportInfo)
    Public MustOverride Sub CMS_WorkReport_Delete(PortalConnect As String, iD As Integer)
#End Region

#Region "CMS_BusinessFollow"
    Public MustOverride Function CMS_BusinessFollow_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_BusinessFollow_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BusinessFollow_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_BusinessFollow_Add(PortalConnect As String, obj As CMS_BusinessFollowInfo) As Integer
    Public MustOverride Sub CMS_BusinessFollow_Update(PortalConnect As String, obj As CMS_BusinessFollowInfo)
    Public MustOverride Sub CMS_BusinessFollow_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_BanBe_TinNhan"
    Public MustOverride Function CMS_BanBe_TinNhan_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_BanBe_TinNhan_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_BanBe_TinNhan_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_BanBe_TinNhan_Details(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, UserNameBanBe As String) As IDataReader

    Public MustOverride Function CMS_BanBe_TinNhan_Add(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo) As Integer
    Public MustOverride Sub CMS_BanBe_TinNhan_Update(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo)
    Public MustOverride Sub CMS_BanBe_TinNhan_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_LoaiTuVan"
    Public MustOverride Function CMS_LoaiTuVan_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_LoaiTuVan_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_LoaiTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_LoaiTuVan_Add(PortalConnect As String, obj As CMS_LoaiTuVanInfo) As Integer
    Public MustOverride Sub CMS_LoaiTuVan_Update(PortalConnect As String, obj As CMS_LoaiTuVanInfo)
    Public MustOverride Sub CMS_LoaiTuVan_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_CaTuVan"
    Public MustOverride Function CMS_CaTuVan_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CaTuVan_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CaTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_CaTuVan_Add(PortalConnect As String, obj As CMS_CaTuVanInfo) As Integer
    Public MustOverride Sub CMS_CaTuVan_Update(PortalConnect As String, obj As CMS_CaTuVanInfo)
    Public MustOverride Sub CMS_CaTuVan_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_DonHangXKLD"
    Public MustOverride Function CMS_DonHangXKLD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_DonHangXKLD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DonHangXKLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_DonHangXKLD_Add(PortalConnect As String, obj As CMS_DonHangXKLDInfo) As Integer
    Public MustOverride Sub CMS_DonHangXKLD_Update(PortalConnect As String, obj As CMS_DonHangXKLDInfo)
    Public MustOverride Sub CMS_DonHangXKLD_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Sub CMS_DonHangNLD_Update_Introduce(PortalConnect As String, iD As Integer, isIntroduce As Boolean)
#End Region
#Region "CMS_DonHangNLD"
    Public MustOverride Function CMS_DonHangNLD_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_DonHangNLD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_DonHangNLD_List_Search(PortalConnect As String, idDonHangXKLD As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_DonHangNLD_Add(PortalConnect As String, obj As CMS_DonHangNLDInfo) As Integer
    Public MustOverride Sub CMS_DonHangNLD_Update(PortalConnect As String, obj As CMS_DonHangNLDInfo)
    Public MustOverride Sub CMS_DonHangNLD_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_CaTuVanCN"
    Public MustOverride Function CMS_CaTuVanCN_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CaTuVanCN_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CaTuVanCN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_CaTuVanCN_Add(PortalConnect As String, obj As CMS_CaTuVanCNInfo) As Integer
    Public MustOverride Sub CMS_CaTuVanCN_Update(PortalConnect As String, obj As CMS_CaTuVanCNInfo)
    Public MustOverride Sub CMS_CaTuVanCN_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_CaTuVanDN"
    Public MustOverride Function CMS_CaTuVanDN_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CaTuVanDN_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CaTuVanDN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_CaTuVanDN_Add(PortalConnect As String, obj As CMS_CaTuVanDNInfo) As Integer
    Public MustOverride Sub CMS_CaTuVanDN_Update(PortalConnect As String, obj As CMS_CaTuVanDNInfo)
    Public MustOverride Sub CMS_CaTuVanDN_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "CMS_ChuDe"
    Public MustOverride Function CMS_ChuDe_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_ChuDe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_ChuDe_Add(PortalConnect As String, obj As CMS_ChuDeInfo) As Integer
    Public MustOverride Sub CMS_ChuDe_Update(PortalConnect As String, obj As CMS_ChuDeInfo)
    Public MustOverride Sub CMS_ChuDe_Delete(PortalConnect As String, id As Integer)
    Public MustOverride Sub CMS_ChuDe_Update_Quick(PortalConnect As String, id As Integer, isActive As Boolean, isLoai As Integer, userName As String)
#End Region
#Region "CMS_ChuDe_BinhLuan"
    Public MustOverride Function CMS_ChuDe_BinhLuan_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_ChuDe_BinhLuan_List_Search(PortalConnect As String, idChuDe As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_ChuDe_BinhLuan_Add(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo) As Integer
    Public MustOverride Sub CMS_ChuDe_BinhLuan_Update(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo)
    Public MustOverride Sub CMS_ChuDe_BinhLuan_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "CMS_VanPhongGD"
    Public MustOverride Function CMS_VanPhongGD_Get(PortalConnect As String, id As Integer) As IDataReader
    Public MustOverride Function CMS_VanPhongGD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_VanPhongGD_Add(PortalConnect As String, obj As CMS_VanPhongGDInfo) As Integer
    Public MustOverride Sub CMS_VanPhongGD_Update(PortalConnect As String, obj As CMS_VanPhongGDInfo)
    Public MustOverride Sub CMS_VanPhongGD_Delete(PortalConnect As String, id As Integer)
#End Region
#Region "DTNGHE_Diem"
    Public MustOverride Function DTNGHE_Diem_Get(maDiem As Integer) As IDataReader
    Public MustOverride Function DTNGHE_Diem_List() As IDataReader
    Public MustOverride Function DTNGHE_Diem_ListByHocVien(hvID As Integer) As IDataReader
    Public MustOverride Function DTNGHE_Diem_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_Diem_Add(obj As DTNGHE_DiemInfo) As Integer
    Public MustOverride Sub DTNGHE_Diem_Update(obj As DTNGHE_DiemInfo)
    Public MustOverride Sub DTNGHE_Diem_Delete(maDiem As Integer)
    Public MustOverride Sub DTNGHE_Diem_Update_Quick(maDiem As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DTNGHE_HocVien"
    Public MustOverride Function DTNGHE_HocVien_Get(maHocVien As Integer) As IDataReader
    Public MustOverride Function DTNGHE_HocVien_List() As IDataReader
    Public MustOverride Function DTNGHE_HocVien_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_HocVien_Add(obj As DTNGHE_HocVienInfo) As Integer
    Public MustOverride Sub DTNGHE_HocVien_Update(obj As DTNGHE_HocVienInfo)
    Public MustOverride Sub DTNGHE_HocVien_Delete(maHocVien As Integer)
    Public MustOverride Sub DTNGHE_HocVien_Update_Quick(maHocVien As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DTNGHE_LopHoc"
    Public MustOverride Function DTNGHE_LopHoc_Get(iD As Integer) As IDataReader
    Public MustOverride Function DTNGHE_LopHoc_List() As IDataReader
    Public MustOverride Function DTNGHE_LopHoc_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_LopHoc_Add(obj As DTNGHE_LopHocInfo) As Integer
    Public MustOverride Sub DTNGHE_LopHoc_Update(obj As DTNGHE_LopHocInfo)
    Public MustOverride Sub DTNGHE_LopHoc_Delete(iD As Integer)
    Public MustOverride Sub DTNGHE_LopHoc_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DTNGHE_NgheDaoTao"
    Public MustOverride Function DTNGHE_NgheDaoTao_Get(iD As Integer) As IDataReader
    Public MustOverride Function DTNGHE_NgheDaoTao_List() As IDataReader
    Public MustOverride Function DTNGHE_NgheDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_NgheDaoTao_Add(obj As DTNGHE_NgheDaoTaoInfo) As Integer
    Public MustOverride Sub DTNGHE_NgheDaoTao_Update(obj As DTNGHE_NgheDaoTaoInfo)
    Public MustOverride Sub DTNGHE_NgheDaoTao_Delete(iD As Integer)
    Public MustOverride Sub DTNGHE_NgheDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "DTNGHE_ThoiGianDaoTao"
    Public MustOverride Function DTNGHE_ThoiGianDaoTao_Get(iD As Integer) As IDataReader
    Public MustOverride Function DTNGHE_ThoiGianDaoTao_List() As IDataReader
    Public MustOverride Function DTNGHE_ThoiGianDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_ThoiGianDaoTao_Add(obj As DTNGHE_ThoiGianDaoTaoInfo) As Integer
    Public MustOverride Sub DTNGHE_ThoiGianDaoTao_Update(obj As DTNGHE_ThoiGianDaoTaoInfo)
    Public MustOverride Sub DTNGHE_ThoiGianDaoTao_Delete(iD As Integer)
    Public MustOverride Sub DTNGHE_ThoiGianDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "DTNGHE_KetQuaDaoTao"
    Public MustOverride Function DTNGHE_KetQuaDaoTao_Get(iD As Integer) As IDataReader
    Public MustOverride Function DTNGHE_KetQuaDaoTao_List() As IDataReader
    Public MustOverride Function DTNGHE_KetQuaDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function DTNGHE_KetQuaDaoTao_Add(obj As DTNGHE_KetQuaDaoTaoInfo) As Integer
    Public MustOverride Sub DTNGHE_KetQuaDaoTao_Update(obj As DTNGHE_KetQuaDaoTaoInfo)
    Public MustOverride Sub DTNGHE_KetQuaDaoTao_Delete(iD As Integer)
    Public MustOverride Sub DTNGHE_KetQuaDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

#Region "DTNGHE_BAOCAO"
    Public MustOverride Function DTNGHE_ThongKe_LopHoc_TheoNghe() As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_LopHoc_TheoThoiGian() As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_HocVien_TheoKetQua() As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_HocVien_TheoNghe() As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_HocVien_TheoThoiGian() As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_HocVien_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As IDataReader
    Public MustOverride Function DTNGHE_ThongKe_LichHen() As IDataReader

#End Region
#Region "SVL_BAOCAO"
    Public MustOverride Function SVL_ThongKe_DN_TheoNghe(PhienGD_ID As String) As IDataReader
    Public MustOverride Function SVL_ThongKe_DN_TheoQuyMo(PhienGD_ID As String, QuyMo_ID As Int16) As Integer
    Public MustOverride Function SVL_ThongKe_NLD_TheoNhuCauVL(PhienGD_ID As String, QuyMo_ID As Int16) As Integer
#End Region
#Region "CMS_LichHen"
    Public MustOverride Function CMS_LichHen_Get(iD As Integer) As IDataReader
    Public MustOverride Function CMS_LichHen_List() As IDataReader
    Public MustOverride Function CMS_LichHen_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_LichHen_Add(obj As CMS_LichHenInfo) As Integer
    Public MustOverride Sub CMS_LichHen_Update(obj As CMS_LichHenInfo)
    Public MustOverride Sub CMS_LichHen_Delete(iD As Integer)
#End Region
#Region "CMS_JobFollow"
    Public MustOverride Function CMS_JobFollow_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_JobFollow_Add(obj As CMS_JobFollowInfo) As Integer
#End Region
#Region "XKL_DangKy"
    Public MustOverride Function XKL_DangKy_Get(iD As Integer) As IDataReader
    Public MustOverride Function XKL_DangKy_List() As IDataReader
    Public MustOverride Function XKL_DangKy_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader

    Public MustOverride Function XKL_DangKy_Add(obj As XKL_DangKyInfo) As Integer
    Public MustOverride Sub XKL_DangKy_Update(obj As XKL_DangKyInfo)
    Public MustOverride Sub XKL_DangKy_Delete(iD As Integer)
    Public MustOverride Sub XKL_DangKy_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
#End Region

End Class
