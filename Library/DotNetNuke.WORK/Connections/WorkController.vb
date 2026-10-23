Imports System.Runtime.CompilerServices
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK.DTNGHE_KetQuaDaoTaoInfo
Imports Microsoft.ApplicationBlocks.Data
Public Class WorkController
#Region "CMS_Counter"
    Public Function CMS_Counter_Get(PortalConnect As String, portalID As Integer) As CMS_CounterInfo
        Return CBO.FillObject(Of CMS_CounterInfo)(DataProvider.Instance().CMS_Counter_Get(PortalConnect, portalID))
    End Function
#End Region
#Region "CMS_Business"
    Public Function CMS_Business_Get_ID(PortalConnect As String, ID As Integer) As CMS_BusinessInfo
        Return CBO.FillObject(Of CMS_BusinessInfo)(DataProvider.Instance().CMS_Business_Get_ID(PortalConnect, ID))
    End Function
    Public Function CMS_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As CMS_BusinessInfo
        Return CBO.FillObject(Of CMS_BusinessInfo)(DataProvider.Instance().CMS_Business_Check_TaxCode(PortalConnect, business_ID, taxCode))
    End Function
    Public Function CMS_Business_Get_UserAdmin(PortalConnect As String, UserAdmin As String) As CMS_BusinessInfo
        Return CBO.FillObject(Of CMS_BusinessInfo)(DataProvider.Instance().CMS_Business_Get_UserAdmin(PortalConnect, UserAdmin))
    End Function
    Public Function CMS_Business_Get(PortalConnect As String, business_ID As String) As CMS_BusinessInfo
        Return CBO.FillObject(Of CMS_BusinessInfo)(DataProvider.Instance().CMS_Business_Get(PortalConnect, business_ID))
    End Function
    Public Function CMS_Business_Get_ToApp(tinhTP As Integer, business_ID As String) As CMS_BusinessInfo
        Return CBO.FillObject(Of CMS_BusinessInfo)(DataProvider.Instance().CMS_Business_Get_ToApp(tinhTP, business_ID))
    End Function
    Public Function CMS_Business_List_LatLng(tinhTP As Integer, quanHuyen As String, phuongXa As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_LatLng(tinhTP, quanHuyen, phuongXa), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_By_TinhTP(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_By_TinhTP(PortalConnect, portalId, tinhTP, quanHuyen, currPage, recodperpage), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_By_TinhTP_ToApp(tinhTP As Integer, quanHuyen As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_By_TinhTP_ToApp(tinhTP, quanHuyen), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_By_TinhTP_IsSent(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isSent As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_By_TinhTP_IsSent(PortalConnect, portalId, tinhTP, quanHuyen, isSent), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isOffline As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_By_TinhTP_IsOffline(PortalConnect, portalId, tinhTP, quanHuyen, isOffline), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List(PortalConnect, portalId), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, tinhTp, quanHuyen), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_Active(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isActive As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_Active(PortalConnect, search, fullText, currPage, recodperpage, tinhTp, quanHuyen, phuongXa, isActive), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_Approval(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, isActive As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_Approval(PortalConnect, search, fullText, currPage, recodperpage, tinhTp, quanHuyen, isActive), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, quanHuyen As String, WBID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_ToApp(tinhTP, search, isOrder, currPage, recodperpage, quanHuyen, WBID), GetType(CMS_BusinessInfo))
    End Function

    Public Function CMS_Business_List_SVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_SVL(PortalConnect, search, currPage, recodperpage, PhienGD_ID), GetType(CMS_BusinessInfo))
    End Function

    Public Function CMS_Business_List_NotJoinPhienGD(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_NotJoinPhienGD(PortalConnect, search, currPage, recodperpage, PhienGD_ID), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_SVL_QT(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_SVL_QT(PortalConnect, search, currPage, recodperpage, PhienGD_ID, Status), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_Check(PortalConnect As String, obj As CMS_BusinessInfo) As String
        Return DataProvider.Instance().CMS_Business_Check(PortalConnect, obj)
    End Function
    Public Sub CMS_Business_Add(PortalConnect As String, obj As CMS_BusinessInfo)
        DataProvider.Instance().CMS_Business_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Business_Add_All(PortalConnect As String, obj As CMS_BusinessInfo)
        DataProvider.Instance().CMS_Business_Add_All(PortalConnect, obj)
    End Sub
    Public Sub SV_Business_Add(PortalConnect As String, obj As CMS_BusinessInfo)
        DataProvider.Instance().SV_Business_Add(PortalConnect, obj.Business_ID, obj.Business_Vn, obj.Business_En, obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.Logo, obj.Description, obj.TaxCode, obj.Mobile, obj.Fax, obj.Website, obj.Email, obj.Address, obj.ContactUser, obj.ContactMobile, obj.ContactEmail, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate, obj.PortalId, obj.Scale, obj.IdSend)
    End Sub
    Public Function SV_Business_Get_By_IdKey(PortalConnect As String, portalId As Integer, idSend As String)
        Return DataProvider.Instance().SV_Business_Get_By_IdKey(PortalConnect, portalId, idSend)
    End Function
    Public Sub CMS_Business_Update(PortalConnect As String, obj As CMS_BusinessInfo)
        DataProvider.Instance().CMS_Business_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Business_Delete(PortalConnect As String, business_ID As String)
        DataProvider.Instance().CMS_Business_Delete(PortalConnect, business_ID)
    End Sub
    Public Sub CMS_Business_Update_Quick(PortalConnect As String, business_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        DataProvider.Instance().CMS_Business_Update_Quick(PortalConnect, business_ID, isApproval, approvalUser, approvalDate)
    End Sub
    Public Sub CMS_Business_Update_IsSent(PortalConnect As String, business_ID As String, isApproval As Boolean)
        DataProvider.Instance().CMS_Business_Update_IsSent(PortalConnect, business_ID, isApproval)
    End Sub
    Public Sub CMS_Business_Update_LatLng(PortalConnect As String, business_ID As String, lat As String, lng As String)
        DataProvider.Instance().CMS_Business_Update_LatLng(PortalConnect, business_ID, lat, lng)
    End Sub
    Public Sub CMS_Business_Update_IsOffline(PortalConnect As String, business_ID As String, isOffline As Boolean)
        DataProvider.Instance().CMS_Business_Update_IsOffline(PortalConnect, business_ID, isOffline)
    End Sub
    Public Function CMS_Business_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_Home(PortalConnect, portalId, currPage, recodperpage), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_List_View_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_View_Home(PortalConnect, search, currPage, recodperpage), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_SendMail_Check(PortalConnect As String, Business_ID As String, PhienGD_ID As String) As Integer
        Return DataProvider.Instance().CMS_SendMail_Check(PortalConnect, Business_ID, PhienGD_ID)
    End Function
    Public Sub CMS_Business_Update_TinCay(PortalConnect As String, business_ID As String, tinCay As Boolean)
        DataProvider.Instance().CMS_Business_Update_TinCay(PortalConnect, business_ID, tinCay)
    End Sub
    Public Function CMS_Business_List_TinCay(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isTinCay As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_List_TinCay(PortalConnect, search, fullText, currPage, recodperpage, tinhTp, quanHuyen, phuongXa, isTinCay), GetType(CMS_BusinessInfo))
    End Function
    Public Function CMS_Business_by_NLD(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Business_by_NLD(PortalConnect, search, isOrder, currPage, recodperpage, UserName, tinhTp, quanHuyen), GetType(CMS_BusinessInfo))
    End Function
#End Region
#Region "CMS_BusUser"
    Public Function CMS_BusUser_Get_Business_User(PortalConnect As String, business_ID As String, UserAdmin As String) As CMS_BusUserInfo
        Return CBO.FillObject(Of CMS_BusUserInfo)(DataProvider.Instance().CMS_BusUser_Get_Business_User(PortalConnect, business_ID, UserAdmin))
    End Function
    Public Function CMS_BusUser_Get(PortalConnect As String, busUser_ID As String) As CMS_BusUserInfo
        Return CBO.FillObject(Of CMS_BusUserInfo)(DataProvider.Instance().CMS_BusUser_Get(PortalConnect, busUser_ID))
    End Function
    Public Function CMS_BusUser_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BusUser_List(PortalConnect), GetType(CMS_BusUserInfo))
    End Function
    Public Function CMS_BusUser_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BusUser_Get_By_CMS_Business(PortalConnect, business_ID), GetType(CMS_BusUserInfo))
    End Function
    Public Sub CMS_BusUser_Add(PortalConnect As String, obj As CMS_BusUserInfo)
        DataProvider.Instance().CMS_BusUser_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_BusUser_Update(PortalConnect As String, obj As CMS_BusUserInfo)
        DataProvider.Instance().CMS_BusUser_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BusUser_Delete(PortalConnect As String, busUser_ID As String)
        DataProvider.Instance().CMS_BusUser_Delete(PortalConnect, busUser_ID)
    End Sub
    Public Sub CMS_BusUser_Update_Active(PortalConnect As String, UserAdmin As String, IsActive As Boolean, ApprovalUser As String, ApprovalDate As DateTime)
        DataProvider.Instance().CMS_BusUser_Update_Active(PortalConnect, UserAdmin, IsActive, ApprovalUser, ApprovalDate)
    End Sub
    Public Sub CMS_BusUser_Update_Admin(PortalConnect As String, UserAdmin As String, business_ID As String)
        DataProvider.Instance().CMS_BusUser_Update_Admin(PortalConnect, UserAdmin, business_ID)
    End Sub
    Public Sub CMS_BusUser_Delete_By_UnAdmin(PortalConnect As String, busUser_ID As String, UserAdmin As String)
        DataProvider.Instance().CMS_BusUser_Delete_By_UnAdmin(PortalConnect, busUser_ID, UserAdmin)
    End Sub
    Public Sub CMS_BusUser_Add_Import(PortalConnect As String, obj As CMS_BusUserInfo)
        DataProvider.Instance().CMS_BusUser_Add_Import(PortalConnect, obj)
    End Sub
#End Region
#Region "CMS_ProfileSave"

    Public Function CMS_ProfileSave_Get(PortalConnect As String, profileSave_ID As String) As CMS_ProfileSaveInfo
        Return CBO.FillObject(Of CMS_ProfileSaveInfo)(DataProvider.Instance().CMS_ProfileSave_Get(PortalConnect, profileSave_ID))
    End Function
    Public Function CMS_ProfileSave_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProfileSave_List(PortalConnect), GetType(CMS_ProfileSaveInfo))
    End Function
    Public Function CMS_ProfileSave_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ProfileSave_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status), GetType(CMS_ProfileSaveInfo))
    End Function
    Public Sub CMS_ProfileSave_Add(PortalConnect As String, obj As CMS_ProfileSaveInfo)
        DataProvider.Instance().CMS_ProfileSave_Add(PortalConnect, obj.ProfileSave_ID, obj.JobUser_ID, obj.IsContact, obj.IsInterview, obj.IsTest, obj.IsElect, obj.UserName, obj.CreateDate, obj.UpdatedDate, obj.UpdatedUser, obj.Business_ID)
    End Sub
    Public Sub CMS_ProfileSave_Update(PortalConnect As String, obj As CMS_ProfileSaveInfo)
        DataProvider.Instance().CMS_ProfileSave_Update(PortalConnect, obj.ProfileSave_ID, obj.JobUser_ID, obj.IsContact, obj.IsInterview, obj.IsTest, obj.IsElect, obj.UserName, obj.CreateDate, obj.UpdatedDate, obj.UpdatedUser, obj.Business_ID)
    End Sub
    Public Sub CMS_ProfileSave_Delete(PortalConnect As String, profileSave_ID As String)
        DataProvider.Instance().CMS_ProfileSave_Delete(PortalConnect, profileSave_ID)
    End Sub
    Public Sub CMS_ProfileSave_Update_Quick(PortalConnect As String, profileSave_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_ProfileSave_Update_Quick(PortalConnect, profileSave_ID, isContact, isInterview, isTest, isElect, updatedDate, updatedUser)
    End Sub
#End Region
#Region "CMS_Recruitment"
    Public Function CMS_Recruitment_List_UserName(PortalConnect As String, work_ID As String, UserName As String) As CMS_RecruitmentInfo
        Return CBO.FillObject(Of CMS_RecruitmentInfo)(DataProvider.Instance().CMS_Recruitment_List_UserName(PortalConnect, work_ID, UserName))
    End Function
    Public Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As CMS_RecruitmentInfo
        Return CBO.FillObject(Of CMS_RecruitmentInfo)(DataProvider.Instance().CMS_Recruitment_Get(PortalConnect, recruitment_ID))
    End Function
    Public Function CMS_Recruitment_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List(PortalConnect), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search_QT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search_QT(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search_HSUT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search_HSUT(PortalConnect, search, isOrder, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search_GT(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search_GT(PortalConnect, search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, FromDate, ToDate, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_RecruitmentInfo))
    End Function
    Public Function CMS_Recruitment_List_Search_GTAG(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Search_GTAG(PortalConnect, search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, FromDate, ToDate, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_GTVLInfo))
    End Function
    Public Function CMS_Recruitment_List_Send(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Recruitment_List_Send(PortalConnect, search, fullText, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_RecruitmentInfo))
    End Function
    Public Sub CMS_Recruitment_Add(PortalConnect As String, obj As CMS_RecruitmentInfo)
        DataProvider.Instance().CMS_Recruitment_Add(PortalConnect, obj.Recruitment_ID, obj.Work_ID, obj.IsView, obj.IsContact, obj.IsInterview, obj.IsTest, obj.IsElect, obj.IsCancel, obj.UserName, obj.CreateDate, obj.UpdatedDate, obj.UpdatedUser, obj.JobUser_ID, obj.IsInvite)
    End Sub
    Public Sub CMS_Recruitment_Update(PortalConnect As String, obj As CMS_RecruitmentInfo)
        DataProvider.Instance().CMS_Recruitment_Update(PortalConnect, obj.Recruitment_ID, obj.Work_ID, obj.IsView, obj.IsContact, obj.IsInterview, obj.IsTest, obj.IsElect, obj.IsCancel, obj.UserName, obj.CreateDate, obj.UpdatedDate, obj.UpdatedUser, obj.JobUser_ID, obj.IsInvite)
    End Sub
    Public Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
        DataProvider.Instance().CMS_Recruitment_Delete(PortalConnect, recruitment_ID)
    End Sub
    Public Sub CMS_Recruitment_Update_Quick(PortalConnect As String, recruitment_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_Recruitment_Update_Quick(PortalConnect, recruitment_ID, isView, isContact, isInterview, isTest, isElect, isCancel, updatedDate, updatedUser)
    End Sub

#End Region
#Region "CMS_Work"

    Public Sub CMS_Work_Update_IsOffline(PortalConnect As String, work_ID As String, isOffline As Boolean)
        DataProvider.Instance().CMS_Work_Update_IsOffline(PortalConnect, work_ID, isOffline)
    End Sub
    Public Function CMS_Work_Get(PortalConnect As String, work_ID As String) As CMS_WorkInfo
        Return CBO.FillObject(Of CMS_WorkInfo)(DataProvider.Instance().CMS_Work_Get(PortalConnect, work_ID))
    End Function
    Public Function CMS_Work_Get_ToApp(tinhTP As Integer, work_ID As String) As CMS_WorkInfo
        Return CBO.FillObject(Of CMS_WorkInfo)(DataProvider.Instance().CMS_Work_Get_ToApp(tinhTP, work_ID))
    End Function
    Public Function CMS_Work_List_LatLng(tinhTP As Integer, quanHuyen As String, phuongXa As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_LatLng(tinhTP, quanHuyen, phuongXa), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_Get_ID(PortalConnect As String, ID As Integer) As CMS_WorkInfo
        Return CBO.FillObject(Of CMS_WorkInfo)(DataProvider.Instance().CMS_Work_Get_ID(PortalConnect, ID))
    End Function
    Public Function CMS_Work_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List(PortalConnect, portalId), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_Career(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_Career(PortalConnect, portalId), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_Get_By_CMS_Business(PortalConnect, business_ID), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_By_Business_Home(PortalConnect As String, business_ID As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_By_Business_Home(PortalConnect, business_ID, portalID, currPage, recodperpage), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isOffline As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_By_TinhTP_IsOffline(PortalConnect, portalId, tinhTP, quanHuyen, isOffline), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, TinhTP, quanHuyen, status), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_Invite(PortalConnect As String, search As String, isFlag As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_Invite(PortalConnect, search, isFlag, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, status), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Business_ID As String, Salary_ID As String, Experience_ID As String, quanHuyen As String, status As Integer, wbID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_ToApp(tinhTP, search, isOrder, currPage, recodperpage, Business_ID, Salary_ID, Experience_ID, quanHuyen, status, wbID), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_Pages(PortalConnect As String, currPage As Integer, recodperpage As Integer, CareerID As String, TinhTP As Integer, EducationID As String, JobPlaceID As String, SalaryID As String, Experienceid As String, Genner As Integer, Title As String, Flag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_Pages(PortalConnect, currPage, recodperpage, CareerID, TinhTP, EducationID, JobPlaceID, SalaryID, Experienceid, Genner, Title, Flag), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Work_List_Home(PortalConnect As String, IsFlag As Integer, Top As Integer, tinhTP As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_Home(PortalConnect, IsFlag, Top, tinhTP), GetType(CMS_WorkInfo))
    End Function
    Public Sub CMS_Work_Add(PortalConnect As String, obj As CMS_WorkInfo)
        DataProvider.Instance().CMS_Work_Add(PortalConnect, obj.Work_ID, obj.Business_ID, obj.Title, obj.Salary_ID, obj.Quantity,
                                            obj.Experience_ID, obj.Gender, obj.Level_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.TypeOf_ID,
                                            obj.Career_ID, obj.Description, obj.Requirement, obj.Benefit, obj.RequirementsProfile,
                                            obj.ExpiredDate, obj.SubmissionSend, obj.StartDate, obj.EndDate, obj.ContactUser,
                                            obj.ContactAddress, obj.ContactMobile, obj.ContactEmail, obj.ContactDes, obj.IsHot, obj.IsGhim,
                                            obj.IsFast, obj.IsUrgent, obj.IsApproval, obj.Ages, obj.WorkTime, obj.ApprovalUser, obj.ApprovalDate,
                                            obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser,
                                            obj.UpdatedDate, obj.UpdatedUser, obj.PortalID, obj.LevelDesired_ID, obj.IsFlag, obj.JobPlace)
    End Sub
    Public Sub SV_Work_Add(PortalConnect As String, obj As CMS_WorkInfo)
        DataProvider.Instance().SV_Work_Add(PortalConnect, obj.Work_ID, obj.Business_ID, obj.Title, obj.Salary_ID, obj.Quantity,
                                            obj.Experience_ID, obj.Gender, obj.Level_ID, obj.TinhTP, obj.QuanHuyen, obj.TypeOf_ID,
                                            obj.Career_ID, obj.Description, obj.Requirement, obj.Benefit, obj.RequirementsProfile,
                                            obj.ExpiredDate, obj.SubmissionSend, obj.StartDate, obj.EndDate, obj.ContactUser,
                                            obj.ContactAddress, obj.ContactMobile, obj.ContactEmail, obj.ContactDes, obj.IsHot,
                                            obj.IsFast, obj.IsUrgent, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate,
                                            obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser,
                                            obj.UpdatedDate, obj.UpdatedUser, obj.PortalID, obj.LevelDesired_ID, obj.IsFlag, obj.JobPlace, obj.IdSend)
    End Sub
    Public Sub CMS_Work_Update(PortalConnect As String, obj As CMS_WorkInfo)
        DataProvider.Instance().CMS_Work_Update(PortalConnect, obj.Work_ID, obj.Business_ID, obj.Title, obj.Salary_ID, obj.Quantity,
                                               obj.Experience_ID, obj.Gender, obj.Level_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.TypeOf_ID, obj.Career_ID,
                                               obj.Description, obj.Requirement, obj.Benefit, obj.RequirementsProfile, obj.ExpiredDate,
                                               obj.SubmissionSend, obj.StartDate, obj.EndDate, obj.ContactUser, obj.ContactAddress,
                                               obj.ContactMobile, obj.ContactEmail, obj.ContactDes, obj.IsHot, obj.IsGhim, obj.IsFast, obj.IsUrgent,
                                               obj.IsApproval, obj.Ages, obj.WorkTime, obj.ApprovalUser, obj.ApprovalDate, obj.IsDelete, obj.DeletedUser,
                                               obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser,
                                               obj.PortalID, obj.LevelDesired_ID, obj.JobPlace)
    End Sub
    Public Sub CMS_Work_Delete(PortalConnect As String, work_ID As String)
        DataProvider.Instance().CMS_Work_Delete(PortalConnect, work_ID)
    End Sub
    Public Sub CMS_Work_Update_Delete(PortalConnect As String, work_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
        DataProvider.Instance().CMS_Work_Update_Delete(PortalConnect, work_ID, isDelete, DeletedUser, DeletedDate)
    End Sub
    Public Sub CMS_Work_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        DataProvider.Instance().CMS_Work_Update_Quick(PortalConnect, work_ID, isHot, isFast, IsUrgent, isApproval, approvalUser, approvalDate)
    End Sub
    Public Sub CMS_Work_Update_View(PortalConnect As String, work_ID As String)
        DataProvider.Instance().CMS_Work_Update_View(PortalConnect, work_ID)
    End Sub
    Public Sub CMS_Work_Update_Sent(PortalConnect As String, work_ID As String)
        DataProvider.Instance().CMS_Work_Update_Sent(PortalConnect, work_ID)
    End Sub
    Public Sub CMS_Work_Update_LatLng(PortalConnect As String, work_ID As String, lat As String, lng As String)
        DataProvider.Instance().CMS_Work_Update_LatLng(PortalConnect, work_ID, lat, lng)
    End Sub
#End Region
#Region "CMS_JobUser"
    Public Function CMS_JUser_List_GTVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JUser_List_GTVL(PortalConnect, search, currPage, recodperpage, Career_ID, Salary_ID, Experience_ID, tinhTP, quanHuyen, Work_ID), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_JobUser_List_SendMail(PortalConnect As String, IdKey As String, Flag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List_SendMail(PortalConnect, IdKey, Flag), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_JobUser_Get(PortalConnect As String, jobUser_ID As String) As CMS_JobUserInfo
        Return CBO.FillObject(Of CMS_JobUserInfo)(DataProvider.Instance().CMS_JobUser_Get(PortalConnect, jobUser_ID))
    End Function
    Public Function CMS_JobUser_Get_ID(PortalConnect As String, ID As Integer) As CMS_JobUserInfo
        Return CBO.FillObject(Of CMS_JobUserInfo)(DataProvider.Instance().CMS_JobUser_Get_ID(PortalConnect, ID))
    End Function
    Public Function CMS_JobUser_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List(PortalConnect, portalId), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_JobUser_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Career_ID, Salary_ID, Experience_ID, tinhTP, quanHuyen), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_JobUser_List_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List_Home(PortalConnect, search, currPage, recodperpage, Career_ID, Salary_ID, Experience_ID, tinhTP), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_JobUser_List_Home_BKUV(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Level_ID As String, LevelDesired As String, Salary_ID As String, Experience_ID As String, tinhTP As String, gioiTinh As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List_Home_BKUV(PortalConnect, search, currPage, recodperpage, Career_ID, Level_ID, LevelDesired, Salary_ID, Experience_ID, tinhTP, gioiTinh), GetType(CMS_JobUserInfo))
    End Function
    Public Sub CMS_JobUser_Add(PortalConnect As String, obj As CMS_JobUserInfo)
        DataProvider.Instance().CMS_JobUser_Add(PortalConnect, obj.JobUser_ID, obj.Title, obj.Career_ID, obj.CurrentLevel, obj.LevelDesired, obj.TinhTP, obj.QuanHuyen, obj.Experience_ID, obj.Level_ID, obj.Salary_ID, obj.Needs_ID, obj.Education, obj.CareerGoals, obj.WorkExperience, obj.SkillsForte, obj.UserAdmin, obj.StartDate, obj.EndDate, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Sub CMS_JobUser_AddFromBTHN(PortalConnect As String, obj As CMS_JobUserInfo, objJ As CMS_JobUserBHTNInfo)
        DataProvider.Instance().CMS_JobUser_AddFromBTHN(PortalConnect, obj, objJ)
    End Sub
    Public Sub CMS_JobUser_Update(PortalConnect As String, obj As CMS_JobUserInfo)
        DataProvider.Instance().CMS_JobUser_Update(PortalConnect, obj.JobUser_ID, obj.Title, obj.Career_ID, obj.CurrentLevel, obj.LevelDesired, obj.TinhTP, obj.QuanHuyen, obj.Experience_ID, obj.Level_ID, obj.Salary_ID, obj.Needs_ID, obj.Education, obj.CareerGoals, obj.WorkExperience, obj.SkillsForte, obj.UserAdmin, obj.StartDate, obj.EndDate, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Sub CMS_JobUser_Delete(PortalConnect As String, jobUser_ID As String)
        DataProvider.Instance().CMS_JobUser_Delete(PortalConnect, jobUser_ID)
    End Sub
    Public Sub CMS_JobUser_Update_Quick(PortalConnect As String, JobUser_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        DataProvider.Instance().CMS_JobUser_Update_Quick(PortalConnect, JobUser_ID, isApproval, approvalUser, approvalDate)
    End Sub
    Public Sub CMS_JobUser_Update_Delete(PortalConnect As String, JobUser_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
        DataProvider.Instance().CMS_JobUser_Update_Delete(PortalConnect, JobUser_ID, isDelete, DeletedUser, DeletedDate)
    End Sub
    Public Function CMS_JobUser_List_UserName(PortalConnect As String, portalID As Integer, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUser_List_UserName(PortalConnect, portalID, userName), GetType(CMS_JobUserInfo))
    End Function
    Public Sub CMS_JobUser_Update_View(PortalConnect As String, JobUser_ID As String)
        DataProvider.Instance().CMS_JobUser_Update_View(PortalConnect, JobUser_ID)
    End Sub
#End Region
#Region "CMS_JobView"

    Public Function CMS_JobView_Check(PortalConnect As String, idKey As String, usName As String) As Integer
        Return DataProvider.Instance().CMS_JobView_Check(PortalConnect, idKey, usName)
    End Function
    Public Function CMS_JobView_Get(PortalConnect As String, jobView_ID As String) As CMS_JobViewInfo
        Return CBO.FillObject(Of CMS_JobViewInfo)(DataProvider.Instance().CMS_JobView_Get(PortalConnect, jobView_ID))
    End Function
    Public Function CMS_JobView_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobView_List(PortalConnect), GetType(CMS_JobViewInfo))
    End Function
    Public Function CMS_JobView_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, IsFlag As Integer, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobView_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, IsFlag, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID), GetType(CMS_JobViewInfo))
    End Function

    Public Sub CMS_JobView_Add(PortalConnect As String, obj As CMS_JobViewInfo)
        DataProvider.Instance().CMS_JobView_Add(PortalConnect, obj.JobView_ID, obj.IdKey, obj.IsFlag, obj.UserName, obj.CreateDate)
    End Sub
    Public Sub CMS_JobView_Update(PortalConnect As String, obj As CMS_JobViewInfo)
        DataProvider.Instance().CMS_JobView_Update(PortalConnect, obj.JobView_ID, obj.IdKey, obj.IsFlag, obj.UserName, obj.CreateDate)
    End Sub
    Public Sub CMS_JobView_Delete(PortalConnect As String, jobView_ID As String)
        DataProvider.Instance().CMS_JobView_Delete(PortalConnect, jobView_ID)
    End Sub
#End Region
#Region "CMS_JobInvite"
    Public Function CMS_WorkInvite_Check(PortalConnect As String, WorkID As String, BusID As String) As Integer
        Return DataProvider.Instance().CMS_WorkInvite_Check(PortalConnect, WorkID, BusID)
    End Function
    Public Function CMS_JobInvite_Check(PortalConnect As String, idKey As String, usName As String) As Integer
        Return DataProvider.Instance().CMS_JobInvite_Check(PortalConnect, idKey, usName)
    End Function
    Public Function CMS_JobInvite_Get(PortalConnect As String, JobInvite_ID As String) As CMS_JobInviteInfo
        Return CBO.FillObject(Of CMS_JobInviteInfo)(DataProvider.Instance().CMS_JobInvite_Get(PortalConnect, JobInvite_ID))
    End Function
    Public Function CMS_JobInvite_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobInvite_List(PortalConnect), GetType(CMS_JobInviteInfo))
    End Function
    Public Function CMS_JobInvite_List_ByIdKey(PortalConnect As String, idKey As String, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobInvite_List_ByIdKey(PortalConnect, idKey, userName), GetType(CMS_JobInviteInfo))
    End Function
    Public Function CMS_JobInvite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobInvite_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, IsFlag, Business_ID, TypeOf_ID, Experience_ID, Salary_ID, Career_ID, tinhTP, quanHuyen), GetType(CMS_JobInviteInfo))
    End Function
    Public Function CMS_JobInvite_List_Search_users(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String, userName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobInvite_List_Search_users(PortalConnect, search, isOrder, currPage, recodperpage, IsFlag, Business_ID, TypeOf_ID, Experience_ID, Salary_ID, Career_ID, tinhTP, quanHuyen, userName), GetType(CMS_JobInviteInfo))
    End Function

    Public Sub CMS_JobInvite_Add(PortalConnect As String, obj As CMS_JobInviteInfo)
        DataProvider.Instance().CMS_JobInvite_Add(PortalConnect, obj.JobInvite_ID, obj.WorkID, obj.JobID, obj.BusID, obj.UserName, obj.CreateDate)
    End Sub
    Public Sub CMS_JobInvite_Update(PortalConnect As String, obj As CMS_JobInviteInfo)
        DataProvider.Instance().CMS_JobInvite_Update(PortalConnect, obj.JobInvite_ID, obj.WorkID, obj.JobID, obj.BusID, obj.UserName, obj.CreateDate)
    End Sub
    Public Sub CMS_JobInvite_Delete(PortalConnect As String, JobInvite_ID As String)
        DataProvider.Instance().CMS_JobInvite_Delete(PortalConnect, JobInvite_ID)
    End Sub
    Public Function CMS_JobInvite_Update_Status(PortalConnect As String, JobInvite_ID As String, IsStatus As Integer) As String
        Return DataProvider.Instance().CMS_JobInvite_Update_Status(PortalConnect, JobInvite_ID, IsStatus)
    End Function
#End Region
#Region "CMS_DoanhNghiep"
    Public Function CMS_Work_List_By_PhienGD(PortalConnect As String, PhienGD_ID As String, Career_ID As String, Position_ID As String, Level_ID As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_By_PhienGD(PortalConnect, PhienGD_ID, Career_ID, Position_ID, Level_ID, IsOrder, currPage, recodperpage), GetType(CMS_WorkInfo))
    End Function

    Public Function CMS_DoanhNghiep_List_Home(PortalConnect As String, Career_ID As String, Search As String, IsOrder As Integer, PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_List_Home(PortalConnect, Career_ID, Search, IsOrder, PhienGD_ID), GetType(CMS_DoanhNghiepInfo))
    End Function
    Public Function CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String) As CMS_DoanhNghiepInfo
        Return CBO.FillObject(Of CMS_DoanhNghiepInfo)(DataProvider.Instance().CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect, phienGD_ID, business_ID))
    End Function

    Public Function CMS_DoanhNghiep_Get(PortalConnect As String, doanhNghiep_ID As String) As CMS_DoanhNghiepInfo
        Return CBO.FillObject(Of CMS_DoanhNghiepInfo)(DataProvider.Instance().CMS_DoanhNghiep_Get(PortalConnect, doanhNghiep_ID))
    End Function
    Public Function CMS_DoanhNghiep_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_List(PortalConnect), GetType(CMS_DoanhNghiepInfo))
    End Function
    Public Function CMS_DoanhNghiep_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_List_Search(PortalConnect, search, currPage, recodperpage, PhienGD_ID), GetType(CMS_BusinessInfo))
    End Function

    Public Sub CMS_DoanhNghiep_Add(PortalConnect As String, obj As CMS_DoanhNghiepInfo)
        DataProvider.Instance().CMS_DoanhNghiep_Add(PortalConnect, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.Business_ID, obj.SoBan, obj.GioBatDau, obj.GioKetThuc, obj.TinhTrangThamGia, obj.FileDinhKem, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_Update(PortalConnect As String, obj As CMS_DoanhNghiepInfo)
        DataProvider.Instance().CMS_DoanhNghiep_Update(PortalConnect, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.Business_ID, obj.SoBan, obj.GioBatDau, obj.GioKetThuc, obj.TinhTrangThamGia, obj.FileDinhKem, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_Replace(PortalConnect As String, obj As CMS_DoanhNghiepInfo)
        DataProvider.Instance().CMS_DoanhNghiep_Replace(PortalConnect, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.Business_ID, obj.SoBan, obj.GioBatDau, obj.GioKetThuc, obj.TinhTrangThamGia, obj.FileDinhKem, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_Delete(PortalConnect As String, doanhNghiep_ID As String)
        DataProvider.Instance().CMS_DoanhNghiep_Delete(PortalConnect, doanhNghiep_ID)
    End Sub
    Public Sub CMS_DoanhNghiep_Update_Quick(PortalConnect As String, phienGD_ID As String, business_ID As String, soBan As Integer, tinhTrangThamGia As Integer, updatedBy As DateTime, userUpdate As String)
        DataProvider.Instance().CMS_DoanhNghiep_Update_Quick(PortalConnect, phienGD_ID, business_ID, soBan, tinhTrangThamGia, updatedBy, userUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_Delete_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String)
        DataProvider.Instance().CMS_DoanhNghiep_Delete_Business_ID(PortalConnect, phienGD_ID, business_ID)
    End Sub
#End Region
#Region "CMS_DoanhNghiep_UngVien"
    Public Function CMS_Work_List_TuyenDungName(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, doanhnghiep_id As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Work_List_TuyenDungName(PortalConnect, phienGD_ID, UngViend_ID, doanhnghiep_id), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien(PortalConnect As String, phienGD_ID As String, BusinessID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien(PortalConnect, phienGD_ID, BusinessID), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function

    Public Function CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(PortalConnect As String, phienGD_ID As String, UngViend_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(PortalConnect, phienGD_ID, UngViend_ID), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_TinhTrang(PortalConnect As String, PhienGiaoDich_ID As String, TuyenDung_ID As String, NguoiTimViec_ID As String, IsInvite As Boolean) As CMS_DoanhNghiep_UngVienInfo
        Return CBO.FillObject(Of CMS_DoanhNghiep_UngVienInfo)(DataProvider.Instance().CMS_DoanhNghiep_UngVien_TinhTrang(PortalConnect, PhienGiaoDich_ID, TuyenDung_ID, NguoiTimViec_ID, IsInvite))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_Get_By_PhienGD(PortalConnect As String, phienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_PhienGD(PortalConnect, phienGD_ID), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function

    Public Function CMS_DoanhNghiep_UngVien_Get_By_UserName(PortalConnect As String, phienGD_ID As String, UserName As String) As CMS_DoanhNghiep_UngVienInfo
        Return CBO.FillObject(Of CMS_DoanhNghiep_UngVienInfo)(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_UserName(PortalConnect, phienGD_ID, UserName))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_Get_By_Business(PortalConnect As String, phienGD_ID As String, BusinessID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_Business(PortalConnect, phienGD_ID, BusinessID), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_Get_By_Business_MoiUV(PortalConnect As String, phienGD_ID As String, BusinessID As String, IsStatus As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get_By_Business_MoiUV(PortalConnect, phienGD_ID, BusinessID, IsStatus), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_Get(PortalConnect As String, dNUV_ID As String) As CMS_DoanhNghiep_UngVienInfo
        Return CBO.FillObject(Of CMS_DoanhNghiep_UngVienInfo)(DataProvider.Instance().CMS_DoanhNghiep_UngVien_Get(PortalConnect, dNUV_ID))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_List(PortalConnect), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Function CMS_DoanhNghiep_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DoanhNghiep_UngVien_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DoanhNghiep_UngVienInfo))
    End Function
    Public Sub CMS_DoanhNghiep_Update_KetQua(PortalConnect As String, dNUV_ID As String, ketQuaPhongVan As String, updatedBy As DateTime, userUpdate As String)
        DataProvider.Instance().CMS_DoanhNghiep_Update_KetQua(PortalConnect, dNUV_ID, ketQuaPhongVan, flReg.DateNull(updatedBy), userUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_Add(PortalConnect As String, obj As CMS_DoanhNghiep_UngVienInfo)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_Add(PortalConnect, obj.DNUV_ID, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.UngVien_ID, obj.BanPhongVan, obj.TinhTrangPhongVan, obj.KetQuaPhongVan, obj.ChiTietPhongVan, obj.ThuTuPhongVan, obj.TuyenDung_ID, obj.TuyenDungName, obj.ViTriDat, obj.ViTriDatName, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_Update(PortalConnect As String, obj As CMS_DoanhNghiep_UngVienInfo)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_Update(PortalConnect, obj.DNUV_ID, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.UngVien_ID, obj.BanPhongVan, obj.TinhTrangPhongVan, obj.KetQuaPhongVan, obj.ChiTietPhongVan, obj.ThuTuPhongVan, obj.TuyenDung_ID, obj.TuyenDungName, obj.ViTriDat, obj.ViTriDatName, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_Update_Status(PortalConnect As String, DNUV_ID As String, IsStatus As Boolean)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_Update_Status(PortalConnect, DNUV_ID, IsStatus)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_Delete(PortalConnect As String, dNUV_ID As String)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_Delete(PortalConnect, dNUV_ID)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_RoiBan(PortalConnect As String, phienGD_ID As String, UngViend_ID As String)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_RoiBan(PortalConnect, phienGD_ID, UngViend_ID)
    End Sub
    Public Sub CMS_DoanhNghiep_UngVien_Update_DoanhNghiep(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, DoanhNghiep_ID As String)
        DataProvider.Instance().CMS_DoanhNghiep_UngVien_Update_DoanhNghiep(PortalConnect, phienGD_ID, UngViend_ID, DoanhNghiep_ID)
    End Sub
#End Region
#Region "CMS_PhienGiaoDich"
    Public Function CMS_ThongKeBaoCao_SanVL(PortalConnect As String, phienGD_ID As String, Optional ByVal Business_ID As String = "") As CMS_ThongKeBaoCaoInfo
        Return CBO.FillObject(Of CMS_ThongKeBaoCaoInfo)(DataProvider.Instance().CMS_ThongKeBaoCao_SanVL(PortalConnect, phienGD_ID, Business_ID))
    End Function
    Public Function CMS_PhienGiaoDich_Get(PortalConnect As String, phienGD_ID As String) As CMS_PhienGiaoDichInfo
        Return CBO.FillObject(Of CMS_PhienGiaoDichInfo)(DataProvider.Instance().CMS_PhienGiaoDich_Get(PortalConnect, phienGD_ID))
    End Function
    Public Function CMS_PhienGiaoDich_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PhienGiaoDich_List(PortalConnect, portalId), GetType(CMS_PhienGiaoDichInfo))
    End Function
    Public Function CMS_PhienGiaoDich_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PhienGiaoDich_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_PhienGiaoDichInfo))
    End Function
    Public Function CMS_PhienGiaoDich_List_Search_Member(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_PhienGiaoDich_List_Search_Member(PortalConnect, search, isOrder, currPage, recodperpage), GetType(CMS_PhienGiaoDichInfo))
    End Function
    Public Function CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat(PortalConnect As String, portalId As String) As String
        Return DataProvider.Instance().CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat(PortalConnect, portalId)
    End Function

    Public Sub CMS_PhienGiaoDich_Add(PortalConnect As String, obj As CMS_PhienGiaoDichInfo)
        DataProvider.Instance().CMS_PhienGiaoDich_Add(PortalConnect, obj.PhienGD_ID, obj.TenPhien, obj.TinhTP, obj.DiaDiem, obj.ThoiGian_BatDau, obj.ThoiGian_KetThuc, obj.IsActive, obj.LoaiPhien, obj.Hotline, obj.Email, obj.MoTa, obj.KetQua, obj.FileDinhKem, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.PortalId)
    End Sub
    Public Sub CMS_PhienGiaoDich_Update(PortalConnect As String, obj As CMS_PhienGiaoDichInfo)
        DataProvider.Instance().CMS_PhienGiaoDich_Update(PortalConnect, obj.PhienGD_ID, obj.TenPhien, obj.TinhTP, obj.DiaDiem, obj.ThoiGian_BatDau, obj.ThoiGian_KetThuc, obj.IsActive, obj.LoaiPhien, obj.Hotline, obj.Email, obj.MoTa, obj.KetQua, obj.FileDinhKem, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.PortalId)
    End Sub
    Public Sub CMS_PhienGiaoDich_Delete(PortalConnect As String, phienGD_ID As String)
        DataProvider.Instance().CMS_PhienGiaoDich_Delete(PortalConnect, phienGD_ID)
    End Sub
#End Region
#Region "CMS_TuyenDung"
    Public Function CMS_TuyenDung_List_By_PhienGD(PortalConnect As String, PhienGD_ID As String, business_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TuyenDung_List_By_PhienGD(PortalConnect, PhienGD_ID, business_ID), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_TuyenDung_Get(PortalConnect As String, tuyenDung_ID As String) As CMS_TuyenDungInfo
        Return CBO.FillObject(Of CMS_TuyenDungInfo)(DataProvider.Instance().CMS_TuyenDung_Get(PortalConnect, tuyenDung_ID))
    End Function
    Public Function CMS_TuyenDung_Get_ByWork(PortalConnect As String, businessID As String, workID As String, phiengdID As String) As CMS_TuyenDungInfo
        Return CBO.FillObject(Of CMS_TuyenDungInfo)(DataProvider.Instance().CMS_TuyenDung_Get_ByWork(PortalConnect, businessID, workID, phiengdID))
    End Function
    Public Function CMS_TuyenDung_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TuyenDung_List(PortalConnect), GetType(CMS_TuyenDungInfo))
    End Function
    Public Function CMS_TuyenDung_List_Search(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TuyenDung_List_Search(PortalConnect, search, PhienGD_ID, Business_ID, IsFlag), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_TuyenDung_List_Search_Vl(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer, IsApproval As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TuyenDung_List_Search_VL(PortalConnect, search, PhienGD_ID, Business_ID, IsFlag, IsApproval), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_Job_ID_Member(PortalConnect As String, UngVien_ID As String, Work_ID As String) As String
        Return DataProvider.Instance().CMS_Job_ID_Member(PortalConnect, UngVien_ID, Work_ID)
    End Function
    Public Function CMS_TuyenDung_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
        Return DataProvider.Instance().CMS_TuyenDung_Get_By_UserName(PortalConnect, work_ID, doanhNghiep_ID, UserName)
    End Function
    Public Sub CMS_TuyenDung_Add(PortalConnect As String, obj As CMS_TuyenDungInfo)
        DataProvider.Instance().CMS_TuyenDung_Add(PortalConnect, obj.TuyenDung_ID, obj.DoanhNghiep_ID, obj.Work_ID, obj.PhienGD_ID, obj.CreatedBy, obj.UserName)
    End Sub
    Public Sub CMS_TuyenDung_Update(PortalConnect As String, obj As CMS_TuyenDungInfo)
        DataProvider.Instance().CMS_TuyenDung_Update(PortalConnect, obj.TuyenDung_ID, obj.DoanhNghiep_ID, obj.Work_ID, obj.PhienGD_ID, obj.CreatedBy, obj.UserName)
    End Sub
    Public Sub CMS_TuyenDung_Delete(PortalConnect As String, tuyenDung_ID As String)
        DataProvider.Instance().CMS_TuyenDung_Delete(PortalConnect, tuyenDung_ID)
    End Sub
#End Region
#Region "CMS_UngVien"

    Public Function CMS_UngVien_CheckByUserName(PortalConnect As String, UserName As String) As CMS_UngVienInfo
        Return CBO.FillObject(Of CMS_UngVienInfo)(DataProvider.Instance().CMS_UngVien_CheckByUserName(PortalConnect, UserName))
    End Function
    Public Function CMS_UngVien_Get_By_UserName(PortalConnect As String, UserName As String, PhienGD_ID As String) As CMS_UngVienInfo
        Return CBO.FillObject(Of CMS_UngVienInfo)(DataProvider.Instance().CMS_UngVien_Get_By_UserName(PortalConnect, UserName, PhienGD_ID))
    End Function
    Public Function CMS_UngVien_Get(PortalConnect As String, ungVien_ID As String) As CMS_UngVienInfo
        Return CBO.FillObject(Of CMS_UngVienInfo)(DataProvider.Instance().CMS_UngVien_Get(PortalConnect, ungVien_ID))
    End Function
    Public Function CMS_UngVien_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UngVien_List(PortalConnect), GetType(CMS_UngVienInfo))
    End Function
    Public Function CMS_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UngVien_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_UngVienInfo))
    End Function
    Public Function CMS_UngVien_List_PhienGD_ID(PortalConnect As String, PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UngVien_List_PhienGD_ID(PortalConnect, PhienGD_ID), GetType(CMS_UngVienInfo))
    End Function
    Public Function CMS_UngVien_Get_PhienGD_ID(PortalConnect As String, PhienGD_ID As String, UserName As String) As CMS_UngVienInfo
        Return CBO.FillObject(Of CMS_UngVienInfo)(DataProvider.Instance().CMS_UngVien_Get_PhienGD_ID(PortalConnect, PhienGD_ID, UserName))
    End Function

    Public Sub CMS_UngVien_Add(PortalConnect As String, obj As CMS_UngVienInfo)
        DataProvider.Instance().CMS_UngVien_Add(PortalConnect, obj.UngVien_ID, obj.NguoiTimViec_ID, obj.LoaiUngVien, obj.TenDayDu, obj.NgaySinh, obj.GioiTinh, obj.DiaChi, obj.Email, obj.Tel, obj.NganhNghe, obj.TrinhDoChuyenMon, obj.NamKinhNghiem, obj.ViTriUngTuyen, obj.NhuCauLamViec, obj.PhienGD_ID, obj.CreatedBy)
    End Sub
    Public Sub CMS_UngVien_Update(PortalConnect As String, obj As CMS_UngVienInfo)
        DataProvider.Instance().CMS_UngVien_Update(PortalConnect, obj.UngVien_ID, obj.NguoiTimViec_ID, obj.LoaiUngVien, obj.TenDayDu, obj.NgaySinh, obj.GioiTinh, obj.DiaChi, obj.Email, obj.Tel, obj.NganhNghe, obj.TrinhDoChuyenMon, obj.NamKinhNghiem, obj.ViTriUngTuyen, obj.NhuCauLamViec, obj.PhienGD_ID, obj.CreatedBy)
    End Sub
    Public Sub CMS_UngVien_Replace(PortalConnect As String, obj As CMS_UngVienInfo)
        DataProvider.Instance().CMS_UngVien_Replace(PortalConnect, obj.UngVien_ID, obj.NguoiTimViec_ID, obj.LoaiUngVien, obj.TenDayDu, obj.NgaySinh, obj.GioiTinh, obj.DiaChi, obj.Email, obj.Tel, obj.NganhNghe, obj.TrinhDoChuyenMon, obj.NamKinhNghiem, obj.ViTriUngTuyen, obj.NhuCauLamViec, obj.PhienGD_ID, obj.CreatedBy)
    End Sub
    Public Sub CMS_UngVien_Delete(PortalConnect As String, ungVien_ID As String)
        DataProvider.Instance().CMS_UngVien_Delete(PortalConnect, ungVien_ID)
    End Sub
#End Region
#Region "CMS_UserWork"

    Public Function CMS_UserWork_Get(PortalConnect As String, userWork_ID As String) As CMS_UserWorkInfo
        Return CBO.FillObject(Of CMS_UserWorkInfo)(DataProvider.Instance().CMS_UserWork_Get(PortalConnect, userWork_ID))
    End Function
    Public Function CMS_UserWork_Check(PortalConnect As String, UngVienID As String, WorkID As String) As Boolean
        Return DataProvider.Instance().CMS_UserWork_Check(PortalConnect, UngVienID, WorkID)
    End Function
    Public Function CMS_UserWork_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UserWork_List(PortalConnect), GetType(CMS_UserWorkInfo))
    End Function
    Public Function CMS_UserWork_List_Search(PortalConnect As String, work_ID As String, doanhNghiep_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_UserWork_List_Search(PortalConnect, work_ID, doanhNghiep_ID), GetType(CMS_UngVienInfo))
    End Function
    Public Function CMS_UserWork_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
        Return DataProvider.Instance().CMS_UserWork_Get_By_UserName(PortalConnect, work_ID, doanhNghiep_ID, UserName)
    End Function

    Public Sub CMS_UserWork_Add(PortalConnect As String, obj As CMS_UserWorkInfo)
        DataProvider.Instance().CMS_UserWork_Add(PortalConnect, obj.UserWork_ID, obj.UngVien_ID, obj.Work_ID, obj.Job_ID, obj.DoanhNghiep_ID, obj.CreatedBy)
    End Sub
    Public Sub CMS_UserWork_Update(PortalConnect As String, obj As CMS_UserWorkInfo)
        DataProvider.Instance().CMS_UserWork_Update(PortalConnect, obj.UserWork_ID, obj.UngVien_ID, obj.Work_ID, obj.DoanhNghiep_ID, obj.CreatedBy)
    End Sub
    Public Sub CMS_UserWork_Delete(PortalConnect As String, userWork_ID As String)
        DataProvider.Instance().CMS_UserWork_Delete(PortalConnect, userWork_ID)
    End Sub
#End Region
#Region "CMS_RegEmail"
    Public Sub CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime)
        DataProvider.Instance().CMS_RegEmail_Add(PortalConnect, RegEmail_ID, RegEmail, RegDate)
    End Sub
    Public Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RegEmail_List(PortalConnect, currPage, recodperpage), GetType(CMS_RegEmailInfo))
    End Function
    Public Sub CMS_ConEmail_Add(PortalConnect As String, ConEmail_ID As String, SendDate As DateTime, Contents As String, UserName As String)
        DataProvider.Instance().CMS_ConEmail_Add(PortalConnect, ConEmail_ID, SendDate, Contents, UserName)
    End Sub
    Public Function CMS_ConEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ConEmail_List(PortalConnect, currPage, recodperpage), GetType(CMS_ConEmailInfo))
    End Function
#End Region
#Region "CMS_Career"
    Public Function CMS_Career_Get_ID(PortalConnect As String, ID As Integer) As CMS_CareerInfo
        Return CBO.FillObject(Of CMS_CareerInfo)(DataProvider.Instance().CMS_Career_Get_ID(PortalConnect, ID))
    End Function
    Public Function CMS_Career_List_Job(PortalConnect As String, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List_Job(PortalConnect, top), GetType(CMS_CareerInfo))
    End Function
    Public Function CMS_Career_List_Home(PortalConnect As String, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List_Home(PortalConnect, top), GetType(CMS_CareerInfo))
    End Function
    Public Function CMS_Career_Get(PortalConnect As String, career_ID As String) As CMS_CareerInfo
        Return CBO.FillObject(Of CMS_CareerInfo)(DataProvider.Instance().CMS_Career_Get(PortalConnect, career_ID))
    End Function
    Public Function CMS_Career_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List(PortalConnect), GetType(CMS_CareerInfo))
    End Function
    Public Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Career_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CareerInfo))
    End Function
    Public Sub CMS_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
        DataProvider.Instance().CMS_Career_Add(PortalConnect, obj)
    End Sub
    Public Sub SV_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
        DataProvider.Instance().SV_Career_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Career_Update(PortalConnect As String, obj As CMS_CareerInfo)
        DataProvider.Instance().CMS_Career_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
        DataProvider.Instance().CMS_Career_Delete(PortalConnect, career_ID)
    End Sub
    Public Function SV_Career_Get_By_IdKey(PortalConnect As String, career_Code As String) As String
        Return DataProvider.Instance().SV_Career_Get_By_IdKey(PortalConnect, career_Code)
    End Function
#End Region
#Region "CMS_Experience"
    Public Function CMS_Experience_Get(PortalConnect As String, experience_ID As String) As CMS_ExperienceInfo
        Return CBO.FillObject(Of CMS_ExperienceInfo)(DataProvider.Instance().CMS_Experience_Get(PortalConnect, experience_ID))
    End Function
    Public Function CMS_Experience_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Experience_List(PortalConnect), GetType(CMS_ExperienceInfo))
    End Function
    Public Function SV_Experience_Get_By_IdKey(PortalConnect As String, experienceCode As String) As String
        Return DataProvider.Instance().SV_Experience_Get_By_IdKey(PortalConnect, experienceCode)
    End Function
    Public Function CMS_Experience_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Experience_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ExperienceInfo))
    End Function

    Public Sub CMS_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
        DataProvider.Instance().CMS_Experience_Add(PortalConnect, obj)
    End Sub
    Public Sub SV_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
        DataProvider.Instance().SV_Experience_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Experience_Update(PortalConnect As String, obj As CMS_ExperienceInfo)
        DataProvider.Instance().CMS_Experience_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Experience_Delete(PortalConnect As String, experience_ID As String)
        DataProvider.Instance().CMS_Experience_Delete(PortalConnect, experience_ID)
    End Sub
#End Region
#Region "CMS_JobPlace"
    Public Function CMS_JobPlace_Get_Parents(PortalConnect As String, parent_ID As String) As CMS_JobPlaceInfo
        Return CBO.FillObject(Of CMS_JobPlaceInfo)(DataProvider.Instance().CMS_JobPlace_Get_Parents(PortalConnect, parent_ID))
    End Function
    Public Function CMS_JobPlace_Get_Code(PortalConnect As String, jobPlace_Code As String) As CMS_JobPlaceInfo
        Return CBO.FillObject(Of CMS_JobPlaceInfo)(DataProvider.Instance().CMS_JobPlace_Get(PortalConnect, jobPlace_Code))
    End Function
    Public Function CMS_JobPlace_Get(PortalConnect As String, jobPlace_ID As String) As CMS_JobPlaceInfo
        Return CBO.FillObject(Of CMS_JobPlaceInfo)(DataProvider.Instance().CMS_JobPlace_Get(PortalConnect, jobPlace_ID))
    End Function
    Public Function SV_JobPlace_Get_By_IdKey(PortalConnect As String, jobPlace_Code As String) As String
        Return DataProvider.Instance().SV_JobPlace_Get_By_IdKey(PortalConnect, jobPlace_Code)
    End Function
    Public Function CMS_JobPlace_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobPlace_List(PortalConnect), GetType(CMS_JobPlaceInfo))
    End Function
    Public Function CMS_JobPlace_List_parent(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobPlace_List_parent(PortalConnect), GetType(CMS_JobPlaceInfo))
    End Function
    Public Function CMS_JobPlace_List_parent_ID(PortalConnect As String, parent_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobPlace_List_parent_ID(PortalConnect, parent_ID), GetType(CMS_JobPlaceInfo))
    End Function
    Public Function CMS_JobPlace_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobPlace_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_JobPlaceInfo))
    End Function

    Public Sub CMS_JobPlace_Add(PortalConnect As String, obj As CMS_JobPlaceInfo)
        DataProvider.Instance().CMS_JobPlace_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_JobPlace_Update(PortalConnect As String, obj As CMS_JobPlaceInfo)
        DataProvider.Instance().CMS_JobPlace_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_JobPlace_Delete(PortalConnect As String, jobPlace_ID As String)
        DataProvider.Instance().CMS_JobPlace_Delete(PortalConnect, jobPlace_ID)
    End Sub
#End Region
#Region "CMS_Needs"
    Public Function SV_Needs_Get_By_IdKey(PortalConnect As String, needs_Code As String) As String
        Return DataProvider.Instance().SV_Needs_Get_By_IdKey(PortalConnect, needs_Code)
    End Function
    Public Function CMS_Needs_Get(PortalConnect As String, needs_ID As String) As CMS_NeedsInfo
        Return CBO.FillObject(Of CMS_NeedsInfo)(DataProvider.Instance().CMS_Needs_Get(PortalConnect, needs_ID))
    End Function
    Public Function CMS_Needs_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Needs_List(PortalConnect), GetType(CMS_NeedsInfo))
    End Function
    Public Function CMS_Needs_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Needs_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_NeedsInfo))
    End Function

    Public Sub CMS_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
        DataProvider.Instance().CMS_Needs_Add(PortalConnect, obj)
    End Sub
    Public Sub SV_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
        DataProvider.Instance().SV_Needs_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Needs_Update(PortalConnect As String, obj As CMS_NeedsInfo)
        DataProvider.Instance().CMS_Needs_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Needs_Delete(PortalConnect As String, needs_ID As String)
        DataProvider.Instance().CMS_Needs_Delete(PortalConnect, needs_ID)
    End Sub
#End Region
#Region "CMS_Salary"
    Public Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As CMS_SalaryInfo
        Return CBO.FillObject(Of CMS_SalaryInfo)(DataProvider.Instance().CMS_Salary_Get(PortalConnect, salary_ID))
    End Function
    Public Function CMS_Salary_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List(PortalConnect), GetType(CMS_SalaryInfo))
    End Function
    Public Function SV_Salary_Get_By_IdKey(PortalConnect As String, salaryCode As String) As String
        Return DataProvider.Instance().SV_Salary_Get_By_IdKey(PortalConnect, salaryCode)
    End Function
    Public Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Salary_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SalaryInfo))
    End Function
    Public Sub CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().CMS_Salary_Add(PortalConnect, obj)
    End Sub
    Public Sub SV_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().SV_Salary_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
        DataProvider.Instance().CMS_Salary_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        DataProvider.Instance().CMS_Salary_Delete(PortalConnect, salary_ID)
    End Sub
#End Region
#Region "CMS_TypeOf"
    Public Function CMS_TypeOf_Get(PortalConnect As String, typeOf_ID As String) As CMS_TypeOfInfo
        Return CBO.FillObject(Of CMS_TypeOfInfo)(DataProvider.Instance().CMS_TypeOf_Get(PortalConnect, typeOf_ID))
    End Function
    Public Function CMS_TypeOf_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeOf_List(PortalConnect), GetType(CMS_TypeOfInfo))
    End Function
    Public Function CMS_TypeOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeOf_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TypeOfInfo))
    End Function

    Public Sub CMS_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
        DataProvider.Instance().CMS_TypeOf_Add(PortalConnect, obj)
    End Sub
    Public Sub SV_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
        DataProvider.Instance().SV_TypeOf_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_TypeOf_Update(PortalConnect As String, obj As CMS_TypeOfInfo)
        DataProvider.Instance().CMS_TypeOf_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_TypeOf_Delete(PortalConnect As String, typeOf_ID As String)
        DataProvider.Instance().CMS_TypeOf_Delete(PortalConnect, typeOf_ID)
    End Sub
    Public Function SV_TypeOf_Get_By_IdKey(PortalConnect As String, typeOf_Code As String) As String
        Return DataProvider.Instance().SV_TypeOf_Get_By_IdKey(PortalConnect, typeOf_Code)
    End Function
#End Region
#Region "RPT"
    Public Function CMS_RPT_JobSeeker(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RPT_JobSeeker(PortalConnect, tinhTP, quanHuyen, FromDate, ToDate, Car, Sal), GetType(CMS_JobUserInfo))
    End Function
    Public Function CMS_RPT_Employer(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RPT_Employer(PortalConnect, tinhTP, quanHuyen, FromDate, ToDate, Car, Sal), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_RPT_SanVL2(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RPT_SanVL2(PortalConnect, FromDate, ToDate), GetType(CMS_ThongKeBaoCaoInfo))
    End Function
    Public Function CMS_RPT_SanVL1(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_RPT_SanVL1(PortalConnect, FromDate, ToDate), GetType(CMS_ThongKeBaoCaoInfo))
    End Function
    Public Function CMS_EventLog_List_By_MonthYear(PortalConnect As String, logMonth As Integer, logYear As Integer, portalID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_EventLog_List_By_MonthYear(PortalConnect, logMonth, logYear, portalID), GetType(CMS_EventLogInfo))
    End Function
    Public Shared Function CMS_RPT_Work(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_Work", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_CMKT(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_CMKT", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_TUVAN(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_TUVAN", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_NGANHNGHE(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_NGANHNGHE", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_CMKT_NLD(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_CMKT_NLD", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_LoaiHinhDN(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_LoaiHinhDN)
        Return CBO.FillCollection(Of CMS_BC_LoaiHinhDN)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_LoaiHinhDN", tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
    Public Shared Function CMS_RPT_TUVAN(PortalConnect As String, userName As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, KieuTime As String) As List(Of CMS_BC_WorkInfo)
        Return CBO.FillCollection(Of CMS_BC_WorkInfo)(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_TUVAN", userName, tinhTP, quanHuyen, FromDate, ToDate, KieuTime))
    End Function
#End Region
#Region "RPT_Data"
    Public Function RPT_Data_Get(PortalConnect As String, iD As Integer) As RPT_DataInfo
        Return CBO.FillObject(Of RPT_DataInfo)(DataProvider.Instance().RPT_Data_Get(PortalConnect, iD))
    End Function
    Public Function RPT_Data_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Data_List(PortalConnect), GetType(RPT_DataInfo))
    End Function
    Public Function RPT_Data_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Data_Get_By_RPT_Reports(PortalConnect, rpt_ID), GetType(RPT_DataInfo))
    End Function

    Public Function RPT_Data_Add(PortalConnect As String, obj As RPT_DataInfo) As Integer
        Return DataProvider.Instance().RPT_Data_Add(PortalConnect, obj.Rpt_ID, obj.Cot_ID, obj.Dong_ID, obj.GiaTri, obj.IsOrder, obj.IsFlag, obj.IsCenter)
    End Function
    Public Sub RPT_Data_Update(PortalConnect As String, obj As RPT_DataInfo)
        DataProvider.Instance().RPT_Data_Update(PortalConnect, obj.ID, obj.Rpt_ID, obj.Cot_ID, obj.Dong_ID, obj.GiaTri, obj.IsOrder, obj.IsFlag, obj.IsCenter)
    End Sub
    Public Sub RPT_Data_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        DataProvider.Instance().RPT_Data_Delete_By_RPT_Reports(PortalConnect, rpt_ID)
    End Sub
    Public Sub RPT_Data_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().RPT_Data_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "RPT_Label"
    Public Function RPT_Label_Get(PortalConnect As String, iD As Integer) As RPT_LabelInfo
        Return CBO.FillObject(Of RPT_LabelInfo)(DataProvider.Instance().RPT_Label_Get(PortalConnect, iD))
    End Function
    Public Function RPT_Label_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Label_List(PortalConnect), GetType(RPT_LabelInfo))
    End Function
    Public Function RPT_Label_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer, isRows As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Label_Get_By_RPT_Reports(PortalConnect, rpt_ID, isRows), GetType(RPT_LabelInfo))
    End Function

    Public Function RPT_Label_Add(PortalConnect As String, obj As RPT_LabelInfo) As Integer
        Return DataProvider.Instance().RPT_Label_Add(PortalConnect, obj.Rpt_ID, obj.Cot_ID, obj.TieuDe, obj.Rowspan, obj.Colspan, obj.IsOrder, obj.IsRows, obj.IsColumn, obj.Width, obj.IsData, obj.IsFlag)
    End Function
    Public Sub RPT_Label_Update(PortalConnect As String, obj As RPT_LabelInfo)
        DataProvider.Instance().RPT_Label_Update(PortalConnect, obj.ID, obj.Rpt_ID, obj.Cot_ID, obj.TieuDe, obj.Rowspan, obj.Colspan, obj.IsOrder, obj.IsRows, obj.IsColumn, obj.Width, obj.IsData, obj.IsFlag)
    End Sub
    Public Sub RPT_Label_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().RPT_Label_Delete(PortalConnect, iD)
    End Sub
    Public Sub RPT_Label_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        DataProvider.Instance().RPT_Label_Delete_By_RPT_Reports(PortalConnect, rpt_ID)
    End Sub
#End Region
#Region "RPT_Reports"
    Public Function RPT_Reports_Get(PortalConnect As String, rpt_ID As Integer) As RPT_ReportsInfo
        Return CBO.FillObject(Of RPT_ReportsInfo)(DataProvider.Instance().RPT_Reports_Get(PortalConnect, rpt_ID))
    End Function
    Public Function RPT_Reports_Get_Rpt(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer) As RPT_ReportsInfo
        Return CBO.FillObject(Of RPT_ReportsInfo)(DataProvider.Instance().RPT_Reports_Get_Rpt(PortalConnect, tinhTP, quanHuyen, xaPhuong, thonTo, namBC))
    End Function
    Public Function RPT_Reports_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Reports_List(PortalConnect), GetType(RPT_ReportsInfo))
    End Function

    Public Function RPT_Reports_Add(PortalConnect As String, obj As RPT_ReportsInfo) As Integer
        Return DataProvider.Instance().RPT_Reports_Add(PortalConnect, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.ThonTo, obj.NamBC, obj.Other, obj.Rpt_Type)
    End Function
    Public Sub RPT_Reports_Update(PortalConnect As String, obj As RPT_ReportsInfo)
        DataProvider.Instance().RPT_Reports_Update(PortalConnect, obj.Rpt_ID, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.ThonTo, obj.NamBC)
    End Sub
    Public Sub RPT_Reports_Delete(PortalConnect As String, rpt_ID As Integer)
        DataProvider.Instance().RPT_Reports_Delete(PortalConnect, rpt_ID)
    End Sub
#End Region
#Region "RPT_Rows"
    Public Function RPT_Rows_Get(PortalConnect As String, iD As Integer) As RPT_RowsInfo
        Return CBO.FillObject(Of RPT_RowsInfo)(DataProvider.Instance().RPT_Rows_Get(PortalConnect, iD))
    End Function
    Public Function RPT_Rows_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Rows_List(PortalConnect), GetType(RPT_RowsInfo))
    End Function
    Public Function RPT_Rows_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().RPT_Rows_Get_By_RPT_Reports(PortalConnect, rpt_ID), GetType(RPT_RowsInfo))
    End Function
    Public Function RPT_Rows_Add(PortalConnect As String, obj As RPT_RowsInfo) As Integer
        Return DataProvider.Instance().RPT_Rows_Add(PortalConnect, obj.Rpt_ID, obj.STT, obj.Dong_ID, obj.TieuDe, obj.IsOrder, obj.IsBold, obj.IsFlag)
    End Function
    Public Sub RPT_Rows_Update(PortalConnect As String, obj As RPT_RowsInfo)
        DataProvider.Instance().RPT_Rows_Update(PortalConnect, obj.ID, obj.Rpt_ID, obj.Dong_ID, obj.TieuDe, obj.IsOrder, obj.IsBold, obj.IsFlag)
    End Sub
    Public Sub RPT_Rows_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        DataProvider.Instance().RPT_Rows_Delete_By_RPT_Reports(PortalConnect, rpt_ID)
    End Sub
    Public Sub RPT_Rows_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().RPT_Rows_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_DashBoard"
    Public Function CMS_DashBoard_Admin_6Thang(PortalConnect As String, Num1 As Date, Num2 As Date, Num3 As Date, Num4 As Date, Num5 As Date, Num6 As Date) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DashBoard_Admin_6Thang(PortalConnect, Num1, Num2, Num3, Num4, Num5, Num6), GetType(CMS_DashInfo))
    End Function
    Public Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_Admin(PortalConnect, year))
    End Function
    Public Function CMS_DashBoard_User(PortalConnect As String, userName As String) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_User(PortalConnect, userName))
    End Function
    Public Function CMS_DashBoard_Business(PortalConnect As String, userName As String) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_Business(PortalConnect, userName))
    End Function
    Public Function CMS_DashBoard_Business_Moi(PortalConnect As String, BusID As String) As CMS_DashInfo
        Return CBO.FillObject(Of CMS_DashInfo)(DataProvider.Instance().CMS_DashBoard_Business_Moi(PortalConnect, BusID))
    End Function
    Public Function CMS_DashBoard_User_ListJob(PortalConnect As String, userName As String, career_id As String, top As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DashBoard_User_ListJob(PortalConnect, userName, career_id, top), GetType(CMS_WorkInfo))
    End Function
    Public Function CMS_DashBoard_Business_ListJob(PortalConnect As String, Business_ID As String, top As Integer, CareerID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DashBoard_Business_ListJob(PortalConnect, Business_ID, top, CareerID), GetType(CMS_JobUserInfo))
    End Function
#End Region
#Region "CMS_WorkCareer"
    Public Function CMS_WorkCareer_Get(PortalConnect As String, iD As Integer) As CMS_WorkCareerInfo
        Return CBO.FillObject(Of CMS_WorkCareerInfo)(DataProvider.Instance().CMS_WorkCareer_Get(PortalConnect, iD))
    End Function
    Public Function CMS_WorkCareer_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkCareer_List(PortalConnect), GetType(CMS_WorkCareerInfo))
    End Function
    Public Function CMS_WorkCareer_Get_By_CMS_Work(PortalConnect As String, work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkCareer_Get_By_CMS_Work(PortalConnect, work_ID), GetType(CMS_WorkCareerInfo))
    End Function

    Public Function CMS_WorkCareer_Add(PortalConnect As String, obj As CMS_WorkCareerInfo) As Integer
        Return DataProvider.Instance().CMS_WorkCareer_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_WorkCareer_Update(PortalConnect As String, obj As CMS_WorkCareerInfo)
        DataProvider.Instance().CMS_WorkCareer_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_WorkCareer_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_WorkCareer_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_WorkCareer_Delete_By_CMS_Work(PortalConnect As String, work_ID As String)
        DataProvider.Instance().CMS_WorkCareer_Delete_By_CMS_Work(PortalConnect, work_ID)
    End Sub
#End Region
#Region "CMS_Search"
    Public Function CMS_Search_Get(PortalConnect As String, iD As Integer) As CMS_SearchInfo
        Return CBO.FillObject(Of CMS_SearchInfo)(DataProvider.Instance().CMS_Search_Get(PortalConnect, iD))
    End Function
    Public Function CMS_Search_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Search_List(PortalConnect), GetType(CMS_SearchInfo))
    End Function
    Public Function CMS_Search_Add(PortalConnect As String, obj As CMS_SearchInfo) As Integer
        Return DataProvider.Instance().CMS_Search_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Search_Update(PortalConnect As String, obj As CMS_SearchInfo)
        DataProvider.Instance().CMS_Search_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Search_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_Search_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_EventLog"
    Public Function CMS_EventLog_Get(PortalConnect As String, evenLog_ID As Integer) As CMS_EventLogInfo
        Return CBO.FillObject(Of CMS_EventLogInfo)(DataProvider.Instance().CMS_EventLog_Get(PortalConnect, evenLog_ID))
    End Function
    Public Function CMS_EventLog_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_EventLog_List(PortalConnect, portalId), GetType(CMS_EventLogInfo))
    End Function
    Public Function CMS_EventLog_Add(PortalConnect As String, obj As CMS_EventLogInfo) As Integer
        Return DataProvider.Instance().CMS_EventLog_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_EventLog_Update(PortalConnect As String, obj As CMS_EventLogInfo)
        DataProvider.Instance().CMS_EventLog_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_EventLog_Delete(PortalConnect As String, evenLog_ID As Integer)
        DataProvider.Instance().CMS_EventLog_Delete(PortalConnect, evenLog_ID)
    End Sub
#End Region
#Region "CMS_SystemStatistic"
    Public Function CMS_System_Statistic(PortalConnect As String, tinhTP As Integer, fromDate As DateTime, toDate As DateTime, isTotal As Boolean) As CMS_SysStatisticInfo
        Return CBO.FillObject(Of CMS_SysStatisticInfo)(DataProvider.Instance().CMS_System_Statistic(PortalConnect, tinhTP, fromDate, toDate, isTotal))
    End Function
#End Region
#Region "CMS_NewsFeedback"
    Public Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, ID As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsFeedback_List_By_NewsID(PortalConnect, ID, Status, type, PortalId, LanguageId, PageIndex, PageSize), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As CMS_NewsFeedbackInfo
        Return CBO.FillObject(Of CMS_NewsFeedbackInfo)(DataProvider.Instance().CMS_NewsFeedback_Get(PortalConnect, newsFeedbackId))
    End Function
    Public Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedback_List(PortalConnect, portalId), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
        DataProvider.Instance().CMS_NewsFeedback_Update_Status(PortalConnect, newsFeedbackId, status)
    End Sub
    Public Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, idFeed As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NewsFeedback_Get_By_FBID(PortalConnect, idFeed), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_List_Search(PortalConnect As String, ID As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance.CMS_NewsFeedback_List_Search(PortalConnect, ID, Status, type, PortalId, LanguageId, PageIndex, PageSize), GetType(CMS_NewsFeedbackInfo))
    End Function
    Public Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
        Return DataProvider.Instance().CMS_NewsFeedback_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
        DataProvider.Instance().CMS_NewsFeedback_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
        DataProvider.Instance().CMS_NewsFeedback_Delete(PortalConnect, newsFeedbackId)
    End Sub
#End Region
#Region "CMS_NewsFeedBack_History"
    Public Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
        Return DataProvider.Instance().CMS_NewsFeedBack_History_Add(PortalConnect, obj)
    End Function
#End Region
#Region "CMS_SendMail"
    Public Sub CMS_SendMail_Add(PortalConnect As String, obj As CMS_SendMailInfo)
        DataProvider.Instance().CMS_SendMail_Add(PortalConnect, obj.DoanhNghiep_ID, obj.PhienGD_ID, obj.NgayGui)
    End Sub
#End Region
#Region "CMS_GTVL"
    Public Function CMS_GTVL_Add(PortalConnect As String, obj As CMS_GTVLInfo) As Integer
        Return DataProvider.Instance().CMS_GTVL_Add(PortalConnect, obj)
    End Function
    Public Function CMS_GTVL_List(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_GTVL_List(PortalConnect, search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), GetType(CMS_GTVLInfo))
    End Function
    Public Sub CMS_GTVL_Update_Quick(PortalConnect As String, ID As Integer, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_GTVL_Update_Quick(PortalConnect, ID, isView, isContact, isInterview, isTest, isElect, isCancel, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_GTVL_Update_Acess(PortalConnect As String, ID As Integer, isval As Boolean, isflag As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_GTVL_Update_Acess(PortalConnect, ID, isval, isflag, updatedDate, updatedUser)
    End Sub
#End Region
#Region "BHTN"
    Public Function Off_Count_Hosodangky(PortalConnect As String, portalID As Integer) As Integer
        Return DataProvider.Instance().Off_Count_Hosodangky(PortalConnect, portalID)
    End Function
    Public Function CMS_JobUserBHTN_List_Search(ByVal Keyword As String, ByVal Trinhdo As Integer, ByVal Vitri As Integer, ByVal Mucluong As Integer, ByVal Nganhnghe As Integer, portalID As Integer, ByVal fromRow As Integer, ByVal toRow As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUserBHTN_List_Search(Keyword, Trinhdo, Vitri, Mucluong, Nganhnghe, portalID, fromRow, toRow), GetType(HoSoBHTNInfo))
    End Function

    Public Function DanhMucChungBHTN_List(ByVal loai As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DanhMucChungBHTN_List(loai), GetType(DanhMucChungBHTN))
    End Function
    Public Function Off_GTVL_QuaTrinhLamViec_GetAll(ByVal idHoSo As Guid) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Off_GTVL_QuaTrinhLamViec_GetAll(idHoSo), GetType(HoSoBHTN_QTLamViec))
    End Function
    Public Function Off_GTVL_TrinhDoDaoTao_GetAll(ByVal idHoSo As Guid) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().Off_GTVL_TrinhDoDaoTao_GetAll(idHoSo), GetType(HoSoBHTN_QTDaoTao))
    End Function

    Public Function GetHoSoBHTN(ByVal portalBHTN As Integer, ByVal sosoBHXH As String) As HoSoBHTNInfo
        Return CBO.FillObject(Of HoSoBHTNInfo)(DataProvider.Instance().GetHoSoBHTN(portalBHTN, sosoBHXH))
    End Function
#End Region

#Region "ND23_PLI"
    Public Function ND23_PLI_Get(PortalConnect As String, iD As Integer) As ND23_PLIInfo
        Return CBO.FillObject(Of ND23_PLIInfo)(DataProvider.Instance().ND23_PLI_Get(PortalConnect, iD))
    End Function
    Public Function ND23_PLI_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLI_List(PortalConnect), GetType(ND23_PLIInfo))
    End Function
    Public Function ND23_PLI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLI_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, YearId), GetType(ND23_PLIInfo))
    End Function

    Public Function ND23_PLI_Add(PortalConnect As String, obj As ND23_PLIInfo) As Integer
        Return DataProvider.Instance().ND23_PLI_Add(PortalConnect, obj)
    End Function
    Public Sub ND23_PLI_Update(PortalConnect As String, obj As ND23_PLIInfo)
        DataProvider.Instance().ND23_PLI_Update(PortalConnect, obj)
    End Sub
    Public Sub ND23_PLI_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().ND23_PLI_Delete(PortalConnect, iD)
    End Sub
    Public Sub ND23_PLI_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().ND23_PLI_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIA"
    Public Function ND23_PLIA_Get(PortalConnect As String, iD As Integer) As ND23_PLIAInfo
        Return CBO.FillObject(Of ND23_PLIAInfo)(DataProvider.Instance().ND23_PLIA_Get(PortalConnect, iD))
    End Function
    Public Function ND23_PLIA_Get_ByPLID(PortalConnect As String, PLID As Integer) As ND23_PLIAInfo
        Return CBO.FillObject(Of ND23_PLIAInfo)(DataProvider.Instance().ND23_PLIA_Get_ByPLID(PortalConnect, PLID))
    End Function
    Public Function ND23_PLIA_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIA_List(PortalConnect), GetType(ND23_PLIAInfo))
    End Function
    Public Function ND23_PLIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIA_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(ND23_PLIAInfo))
    End Function

    Public Function ND23_PLIA_Add(PortalConnect As String, obj As ND23_PLIAInfo) As Integer
        Return DataProvider.Instance().ND23_PLIA_Add(PortalConnect, obj)
    End Function
    Public Sub ND23_PLIA_Update(PortalConnect As String, obj As ND23_PLIAInfo)
        DataProvider.Instance().ND23_PLIA_Update(PortalConnect, obj)
    End Sub
    Public Sub ND23_PLIA_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().ND23_PLIA_Delete(PortalConnect, iD)
    End Sub
    Public Sub ND23_PLIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().ND23_PLIA_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLII"
    Public Function ND23_PLII_Get(PortalConnect As String, iD As Integer) As ND23_PLIIInfo
        Return CBO.FillObject(Of ND23_PLIIInfo)(DataProvider.Instance().ND23_PLII_Get(PortalConnect, iD))
    End Function
    Public Function ND23_PLII_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLII_List(PortalConnect), GetType(ND23_PLIIInfo))
    End Function
    Public Function ND23_PLII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLII_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, YearId), GetType(ND23_PLIIInfo))
    End Function

    Public Function ND23_PLII_Add(PortalConnect As String, obj As ND23_PLIIInfo) As Integer
        Return DataProvider.Instance().ND23_PLII_Add(PortalConnect, obj)
    End Function
    Public Sub ND23_PLII_Update(PortalConnect As String, obj As ND23_PLIIInfo)
        DataProvider.Instance().ND23_PLII_Update(PortalConnect, obj)
    End Sub
    Public Sub ND23_PLII_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().ND23_PLII_Delete(PortalConnect, iD)
    End Sub
    Public Sub ND23_PLII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().ND23_PLII_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIII"
    Public Function ND23_PLIII_Get(PortalConnect As String, iD As Integer) As ND23_PLIIIInfo
        Return CBO.FillObject(Of ND23_PLIIIInfo)(DataProvider.Instance().ND23_PLIII_Get(PortalConnect, iD))
    End Function
    Public Function ND23_PLIII_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIII_List(PortalConnect), GetType(ND23_PLIIIInfo))
    End Function
    Public Function ND23_PLIII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIII_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, YearId), GetType(ND23_PLIIIInfo))
    End Function

    Public Function ND23_PLIII_Add(PortalConnect As String, obj As ND23_PLIIIInfo) As Integer
        Return DataProvider.Instance().ND23_PLIII_Add(PortalConnect, obj)
    End Function
    Public Sub ND23_PLIII_Update(PortalConnect As String, obj As ND23_PLIIIInfo)
        DataProvider.Instance().ND23_PLIII_Update(PortalConnect, obj)
    End Sub
    Public Sub ND23_PLIII_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().ND23_PLIII_Delete(PortalConnect, iD)
    End Sub
    Public Sub ND23_PLIII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().ND23_PLIII_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIIIA"
    Public Function ND23_PLIIIA_Get(PortalConnect As String, iD As Integer) As ND23_PLIIIAInfo
        Return CBO.FillObject(Of ND23_PLIIIAInfo)(DataProvider.Instance().ND23_PLIIIA_Get(PortalConnect, iD))
    End Function
    Public Function ND23_PLIIIA_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIIIA_List(PortalConnect), GetType(ND23_PLIIIAInfo))
    End Function
    Public Function ND23_PLIIIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().ND23_PLIIIA_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(ND23_PLIIIAInfo))
    End Function

    Public Function ND23_PLIIIA_Add(PortalConnect As String, obj As ND23_PLIIIAInfo) As Integer
        Return DataProvider.Instance().ND23_PLIIIA_Add(PortalConnect, obj)
    End Function
    Public Sub ND23_PLIIIA_Update(PortalConnect As String, obj As ND23_PLIIIAInfo)
        DataProvider.Instance().ND23_PLIIIA_Update(PortalConnect, obj)
    End Sub
    Public Sub ND23_PLIIIA_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().ND23_PLIIIA_Delete(PortalConnect, iD)
    End Sub
    Public Sub ND23_PLIIIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().ND23_PLIIIA_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_JobHistory"
    Public Function CMS_JobHistory_Get(PortalConnect As String, iD As Integer) As CMS_JobHistoryInfo
        Return CBO.FillObject(Of CMS_JobHistoryInfo)(DataProvider.Instance().CMS_JobHistory_Get(PortalConnect, iD))
    End Function
    Public Function CMS_JobHistory_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobHistory_List(PortalConnect), GetType(CMS_JobHistoryInfo))
    End Function
    Public Function CMS_JobHistory_List_ByJobUserID(PortalConnect As String, jobUserID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobHistory_List_ByJobUserID(PortalConnect, jobUserID), GetType(CMS_JobHistoryInfo))
    End Function

    Public Function CMS_JobHistory_Add(PortalConnect As String, obj As CMS_JobHistoryInfo) As Integer
        Return DataProvider.Instance().CMS_JobHistory_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_JobHistory_Update(PortalConnect As String, obj As CMS_JobHistoryInfo)
        DataProvider.Instance().CMS_JobHistory_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_JobHistory_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_JobHistory_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_JobHistory_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_JobHistory_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_JobUserRefer"
    Public Function CMS_JobUserRefer_Get(PortalConnect As String, iD As Integer) As CMS_JobUserReferInfo
        Return CBO.FillObject(Of CMS_JobUserReferInfo)(DataProvider.Instance().CMS_JobUserRefer_Get(PortalConnect, iD))
    End Function
    Public Function CMS_JobUserRefer_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUserRefer_List(PortalConnect), GetType(CMS_JobUserReferInfo))
    End Function
    Public Function CMS_JobUserRefer_List_ByJobUserID(PortalConnect As String, jobUserID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobUserRefer_List_ByJobUserID(PortalConnect, jobUserID), GetType(CMS_JobUserReferInfo))
    End Function

    Public Function CMS_JobUserRefer_Add(PortalConnect As String, obj As CMS_JobUserReferInfo) As Integer
        Return DataProvider.Instance().CMS_JobUserRefer_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_JobUserRefer_Update(PortalConnect As String, obj As CMS_JobUserReferInfo)
        DataProvider.Instance().CMS_JobUserRefer_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_JobUserRefer_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_JobUserRefer_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_JobUserRefer_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_JobUserRefer_Update_Quick(PortalConnect, iD, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_CareerCLD"
    Public Function CMS_CareerCLD_Get(PortalConnect As String, CareerCLD_ID As Integer) As CMS_CareerCLDInfo
        Return CBO.FillObject(Of CMS_CareerCLDInfo)(DataProvider.Instance().CMS_CareerCLD_Get(PortalConnect, CareerCLD_ID))
    End Function
    Public Function CMS_CareerCLD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CareerCLD_List(PortalConnect), GetType(CMS_CareerCLDInfo))
    End Function
    Public Function CMS_CareerCLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CareerCLD_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CareerCLDInfo))
    End Function
    Public Function CMS_CareerCLD_Add(PortalConnect As String, obj As CMS_CareerCLDInfo) As Integer
        Return DataProvider.Instance().CMS_CareerCLD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CareerCLD_Update(PortalConnect As String, obj As CMS_CareerCLDInfo)
        DataProvider.Instance().CMS_CareerCLD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CareerCLD_Delete(PortalConnect As String, CareerCLD_ID As Integer)
        DataProvider.Instance().CMS_CareerCLD_Delete(PortalConnect, CareerCLD_ID)
    End Sub
#End Region
#Region "CMS_Method"
    Public Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As CMS_MethodInfo
        Return CBO.FillObject(Of CMS_MethodInfo)(DataProvider.Instance().CMS_Method_Get(PortalConnect, method_ID))
    End Function
    Public Function CMS_Method_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Method_List(PortalConnect), GetType(CMS_MethodInfo))
    End Function
    Public Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Method_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_MethodInfo))
    End Function

    Public Function CMS_Method_Add(PortalConnect As String, obj As CMS_MethodInfo) As Integer
        Return DataProvider.Instance().CMS_Method_Add(PortalConnect, obj.Method_Code, obj.Method_Name, obj.Method_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_Method_Update(PortalConnect As String, obj As CMS_MethodInfo)
        DataProvider.Instance().CMS_Method_Update(PortalConnect, obj.Method_ID, obj.Method_Code, obj.Method_Name, obj.Method_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
        DataProvider.Instance().CMS_Method_Delete(PortalConnect, method_ID)
    End Sub
    Public Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Method_Update_Quick(PortalConnect, method_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_Specialize"
    Public Function CMS_Specialize_Get(PortalConnect As String, specialize_ID As Integer) As CMS_SpecializeInfo
        Return CBO.FillObject(Of CMS_SpecializeInfo)(DataProvider.Instance().CMS_Specialize_Get(PortalConnect, specialize_ID))
    End Function
    Public Function CMS_Specialize_GetByCode(PortalConnect As String, specialize_code As String) As CMS_SpecializeInfo
        Return CBO.FillObject(Of CMS_SpecializeInfo)(DataProvider.Instance().CMS_Specialize_GetByCode(PortalConnect, specialize_code))
    End Function
    Public Function CMS_Specialize_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Specialize_List(PortalConnect), GetType(CMS_SpecializeInfo))
    End Function
    Public Function CMS_Specialize_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Specialize_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_SpecializeInfo))
    End Function

    Public Function CMS_Specialize_Add(PortalConnect As String, obj As CMS_SpecializeInfo) As Integer
        Return DataProvider.Instance().CMS_Specialize_Add(PortalConnect, obj.Specialize_Code, obj.Specialize_Name, obj.Specialize_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_Specialize_Update(PortalConnect As String, obj As CMS_SpecializeInfo)
        DataProvider.Instance().CMS_Specialize_Update(PortalConnect, obj.Specialize_ID, obj.Specialize_Code, obj.Specialize_Name, obj.Specialize_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_Specialize_Delete(PortalConnect As String, specialize_ID As Integer)
        DataProvider.Instance().CMS_Specialize_Delete(PortalConnect, specialize_ID)
    End Sub
    Public Sub CMS_Specialize_Update_Quick(PortalConnect As String, specialize_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Specialize_Update_Quick(PortalConnect, specialize_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_TypeEco"
    Public Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As CMS_TypeEcoInfo
        Return CBO.FillObject(Of CMS_TypeEcoInfo)(DataProvider.Instance().CMS_TypeEco_Get(PortalConnect, typeEco_ID))
    End Function
    Public Function CMS_TypeEco_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeEco_List(PortalConnect), GetType(CMS_TypeEcoInfo))
    End Function
    Public Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeEco_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TypeEcoInfo))
    End Function

    Public Function CMS_TypeEco_Add(PortalConnect As String, obj As CMS_TypeEcoInfo) As Integer
        Return DataProvider.Instance().CMS_TypeEco_Add(PortalConnect, obj.TypeEco_Code, obj.TypeEco_Name, obj.TypeEco_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_TypeEco_Update(PortalConnect As String, obj As CMS_TypeEcoInfo)
        DataProvider.Instance().CMS_TypeEco_Update(PortalConnect, obj.TypeEco_ID, obj.TypeEco_Code, obj.TypeEco_Name, obj.TypeEco_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
        DataProvider.Instance().CMS_TypeEco_Delete(PortalConnect, typeEco_ID)
    End Sub
    Public Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_TypeEco_Update_Quick(PortalConnect, typeEco_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_WorkJoin"
    Public Function CMS_WorkJoin_Get(PortalConnect As String, workJoin_ID As Integer) As CMS_WorkJoinInfo
        Return CBO.FillObject(Of CMS_WorkJoinInfo)(DataProvider.Instance().CMS_WorkJoin_Get(PortalConnect, workJoin_ID))
    End Function
    Public Function CMS_WorkJoin_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkJoin_List(PortalConnect), GetType(CMS_WorkJoinInfo))
    End Function
    Public Function CMS_WorkJoin_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkJoin_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_WorkJoinInfo))
    End Function
    Public Function CMS_WorkJoin_Add(PortalConnect As String, obj As CMS_WorkJoinInfo) As Integer
        Return DataProvider.Instance().CMS_WorkJoin_Add(PortalConnect, obj.WorkJoin_Code, obj.WorkJoin_Name, obj.WorkJoin_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_WorkJoin_Update(PortalConnect As String, obj As CMS_WorkJoinInfo)
        DataProvider.Instance().CMS_WorkJoin_Update(PortalConnect, obj.WorkJoin_ID, obj.WorkJoin_Code, obj.WorkJoin_Name, obj.WorkJoin_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_WorkJoin_Delete(PortalConnect As String, workJoin_ID As Integer)
        DataProvider.Instance().CMS_WorkJoin_Delete(PortalConnect, workJoin_ID)
    End Sub
    Public Sub CMS_WorkJoin_Update_Quick(PortalConnect As String, workJoin_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_WorkJoin_Update_Quick(PortalConnect, workJoin_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_Trainning"
    Public Function CMS_Trainning_Get(PortalConnect As String, trainning_ID As Integer) As CMS_TrainningInfo
        Return CBO.FillObject(Of CMS_TrainningInfo)(DataProvider.Instance().CMS_Trainning_Get(PortalConnect, trainning_ID))
    End Function
    Public Function CMS_Trainning_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Trainning_List(PortalConnect), GetType(CMS_TrainningInfo))
    End Function
    Public Function CMS_Trainning_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Trainning_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TrainningInfo))
    End Function

    Public Function CMS_Trainning_Add(PortalConnect As String, obj As CMS_TrainningInfo) As Integer
        Return DataProvider.Instance().CMS_Trainning_Add(PortalConnect, obj.Trainning_Code, obj.Trainning_Name, obj.Trainning_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_Trainning_Update(PortalConnect As String, obj As CMS_TrainningInfo)
        DataProvider.Instance().CMS_Trainning_Update(PortalConnect, obj.Trainning_ID, obj.Trainning_Code, obj.Trainning_Name, obj.Trainning_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_Trainning_Delete(PortalConnect As String, trainning_ID As Integer)
        DataProvider.Instance().CMS_Trainning_Delete(PortalConnect, trainning_ID)
    End Sub
    Public Sub CMS_Trainning_Update_Quick(PortalConnect As String, trainning_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Trainning_Update_Quick(PortalConnect, trainning_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_BanBe"
    Public Function CMS_BanBe_Get(PortalConnect As String, id As Integer) As CMS_BanBeInfo
        Return CBO.FillObject(Of CMS_BanBeInfo)(DataProvider.Instance().CMS_BanBe_Get(PortalConnect, id))
    End Function
    Public Function CMS_BanBe_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BanBe_List(PortalConnect), GetType(CMS_BanBeInfo))
    End Function
    Public Function CMS_BanBe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BanBe_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_BanBeInfo))
    End Function

    Public Function CMS_BanBe_Add(PortalConnect As String, obj As CMS_BanBeInfo) As Integer
        Return DataProvider.Instance().CMS_BanBe_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BanBe_Update(PortalConnect As String, obj As CMS_BanBeInfo)
        DataProvider.Instance().CMS_BanBe_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BanBe_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_BanBe_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_WorkExtend"
    Public Function CMS_WorkExtend_Get(PortalConnect As String, work_ID As String) As CMS_WorkExtendInfo
        Return CBO.FillObject(Of CMS_WorkExtendInfo)(DataProvider.Instance().CMS_WorkExtend_Get(PortalConnect, work_ID))
    End Function
    Public Function CMS_WorkExtend_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkExtend_List(PortalConnect), GetType(CMS_WorkExtendInfo))
    End Function
    Public Function CMS_WorkExtend_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkExtend_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, TinhTP, quanHuyen, status), GetType(CMS_WorkInfo))
    End Function

    Public Function CMS_WorkExtend_Add(PortalConnect As String, obj As CMS_WorkExtendInfo) As Integer
        Return DataProvider.Instance().CMS_WorkExtend_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_WorkExtend_Update(PortalConnect As String, obj As CMS_WorkExtendInfo)
        DataProvider.Instance().CMS_WorkExtend_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_WorkExtend_Delete(PortalConnect As String, work_ID As String)
        DataProvider.Instance().CMS_WorkExtend_Delete(PortalConnect, work_ID)
    End Sub
    Public Sub CMS_WorkExtend_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        DataProvider.Instance().CMS_WorkExtend_Update_Quick(PortalConnect, work_ID, isHot, isFast, IsUrgent, isApproval, approvalUser, approvalDate)
    End Sub
#End Region
#Region "Mapping data"
    ''' <summary>
    ''' Lấy danh sách id trong bảng mapping theo id của bảng chính. Dùng cho các vị trí cho phép chọn nhiều.
    ''' </summary>
    ''' <typeparam name="T">Class entity đang map, có tên giống với tên bảng trong database</typeparam>
    ''' <param name="PortalConnect"></param>
    ''' <param name="id">Id của bảng dữ liệu chính (Map_Id)</param>
    ''' <param name="customTableName">Tên bảng tự định nghĩa, dùng trong trường hợp tên bảng khác tên class entity trong WorkInfo</param>
    ''' <returns></returns>
    Public Function MAPWork_GetAllByMapId(Of T As {IMappingInfo})(PortalConnect As String, id As String, Optional customTableName As String = "") As String
        Dim rs = CBO.FillCollection(DataProvider.Instance().MAPWork_GetByMapId(Of T)(PortalConnect, id, customTableName), GetType(T))
        Dim kq = String.Join(",", rs.Cast(Of T).Select(Function(item) item.GetId()))
        Return kq
    End Function

    ''' <summary>
    ''' Lấy danh sách trong bảng mapping theo id của bảng chính. Dùng cho các vị trí cho phép chọn nhiều.
    ''' </summary>
    ''' <typeparam name="T">Class entity đang map, có tên giống với tên bảng trong database</typeparam>
    ''' <param name="PortalConnect"></param>
    ''' <param name="id">Id của bảng dữ liệu chính (Map_Id)</param>
    ''' <param name="customTableName">Tên bảng tự định nghĩa, dùng trong trường hợp tên bảng khác tên class entity trong WorkInfo</param>
    ''' <returns></returns>
    Public Function MAPWork_GetAllByMapId_ToArrayList(Of T As {IMappingInfo})(PortalConnect As String, id As String, Optional customTableName As String = "") As IEnumerable(Of T)
        Dim rs = CBO.FillCollection(DataProvider.Instance().MAPWork_GetByMapId(Of T)(PortalConnect, id, customTableName), GetType(T)).Cast(Of T)
        Return rs
    End Function

    ''' <summary>
    ''' Lấy id trong bảng mapping theo id của bảng chính. Dùng cho các vị trí chọn 1.
    ''' </summary>
    ''' <typeparam name="T">Class entity đang map, có tên giống với tên bảng trong database</typeparam>
    ''' <param name="PortalConnect"></param>
    ''' <param name="id">Id của bảng dữ liệu chính (Map_Id)</param>
    ''' <param name="customTableName">Tên bảng tự định nghĩa, dùng trong trường hợp tên bảng khác tên class entity trong WorkInfo</param>
    ''' <returns></returns>
    Public Function MAPWork_GetByMapId(Of T As {IMappingInfo})(PortalConnect As String, id As String, Optional customTableName As String = "") As String
        Dim rs = CBO.FillObject(Of T)(DataProvider.Instance().MAPWork_GetByMapId(Of T)(PortalConnect, id, customTableName))
        If rs IsNot Nothing Then
            Return rs.GetId()
        End If
        Return String.Empty
    End Function

    ''' <summary>
    ''' Thêm dữ liệu vào bảng mapping.
    ''' </summary>
    ''' <typeparam name="T">Class entity đang map, có tên giống với tên bảng trong database</typeparam>
    ''' <param name="PortalConnect"></param>
    ''' <param name="items">Danh sách items của bảng danh mục cần thêm</param>
    ''' <param name="customTableName">Tên bảng tự định nghĩa, dùng trong trường hợp tên bảng khác tên class entity trong WorkInfo</param>
    Public Sub MAPWork_Add(Of T As {IMappingInfo})(PortalConnect As String, items As DataTable, Optional customTableName As String = "")
        Dim info = Activator.CreateInstance(Of T)
        DataProvider.Instance().CMS_Excute_DataTable(PortalConnect, info.GetSQLProcedureName("_Add", customTableName), items)
    End Sub

    ''' <summary>
    ''' Xóa dữ liệu trong bảng mapping theo id của bảng chính.
    ''' </summary>
    ''' <typeparam name="T">Class entity đang map, có tên giống với tên bảng trong database</typeparam>
    ''' <param name="PortalConnect"></param>
    ''' <param name="id">Id của bảng dữ liệu chính (Map_Id)</param>
    ''' <param name="customTableName">Tên bảng tự định nghĩa, dùng trong trường hợp tên bảng khác tên class entity trong WorkInfo</param>
    Public Sub MAPWork_Delete(Of T As {IMappingInfo})(PortalConnect As String, id As String, Optional customTableName As String = "")
        DataProvider.Instance().MAPWork_DeleteByMapId(Of T)(PortalConnect, id, customTableName)
    End Sub
#End Region

#Region "CMS_JobUserExtra"
    Public Function CMS_JobUserExtra_Get(PortalConnect As String, jobUser_ID As String) As CMS_JobUserExtraInfo
        Return CBO.FillObject(Of CMS_JobUserExtraInfo)(DataProvider.Instance().CMS_JobUserExtra_Get(PortalConnect, jobUser_ID))
    End Function
    Public Function CMS_JobUserExtra_Add(PortalConnect As String, obj As CMS_JobUserExtraInfo) As Integer
        Return DataProvider.Instance().CMS_JobUserExtra_Add(PortalConnect, obj)
    End Function
#End Region
#Region "CMS_NgheCongViec"
    Public Function CMS_NgheCongViec_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_NgheCongViec_List(PortalConnect), GetType(CMS_NgheCongViecInfo))
    End Function
    Public Function CMS_NgheCongViec_Get(PortalConnect As String, career_ID As String) As CMS_NgheCongViecInfo
        Return CBO.FillObject(Of CMS_NgheCongViecInfo)(DataProvider.Instance().CMS_NgheCongViec_Get(PortalConnect, career_ID))
    End Function
#End Region

#Region "CMS_WorkReport"
    Public Function CMS_WorkReport_Get(PortalConnect As String, iD As Integer) As CMS_WorkReportInfo
        Return CBO.FillObject(Of CMS_WorkReportInfo)(DataProvider.Instance().CMS_WorkReport_Get(PortalConnect, iD))
    End Function
    Public Function CMS_WorkReport_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkReport_List(PortalConnect), GetType(CMS_WorkReportInfo))
    End Function
    Public Function CMS_WorkReport_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_WorkReport_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_WorkReportInfo))
    End Function

    Public Function CMS_WorkReport_Add(PortalConnect As String, obj As CMS_WorkReportInfo) As Integer
        Return DataProvider.Instance().CMS_WorkReport_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_WorkReport_Update(PortalConnect As String, obj As CMS_WorkReportInfo)
        DataProvider.Instance().CMS_WorkReport_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_WorkReport_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_WorkReport_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_BusinessFollow"
    Public Function CMS_BusinessFollow_Get(PortalConnect As String, iD As Integer) As CMS_BusinessFollowInfo
        Return CBO.FillObject(Of CMS_BusinessFollowInfo)(DataProvider.Instance().CMS_BusinessFollow_Get(PortalConnect, iD))
    End Function
    Public Function CMS_BusinessFollow_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BusinessFollow_List(PortalConnect), GetType(CMS_BusinessFollowInfo))
    End Function
    Public Function CMS_BusinessFollow_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BusinessFollow_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_BusinessFollowInfo))
    End Function

    Public Function CMS_BusinessFollow_Add(PortalConnect As String, obj As CMS_BusinessFollowInfo) As Integer
        Return DataProvider.Instance().CMS_BusinessFollow_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BusinessFollow_Update(PortalConnect As String, obj As CMS_BusinessFollowInfo)
        DataProvider.Instance().CMS_BusinessFollow_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BusinessFollow_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_BusinessFollow_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_BanBe_TinNhan"
    Public Function CMS_BanBe_TinNhan_Get(PortalConnect As String, id As Integer) As CMS_BanBe_TinNhanInfo
        Return CBO.FillObject(Of CMS_BanBe_TinNhanInfo)(DataProvider.Instance().CMS_BanBe_TinNhan_Get(PortalConnect, id))
    End Function
    Public Function CMS_BanBe_TinNhan_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BanBe_TinNhan_List(PortalConnect), GetType(CMS_BanBe_TinNhanInfo))
    End Function
    Public Function CMS_BanBe_TinNhan_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BanBe_TinNhan_List_Search(PortalConnect, search, currPage, recodperpage, UserName), GetType(CMS_BanBe_TinNhanInfo))
    End Function
    Public Function CMS_BanBe_TinNhan_Details(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, UserNameBanBe As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_BanBe_TinNhan_Details(PortalConnect, search, isOrder, currPage, recodperpage, UserName, UserNameBanBe), GetType(CMS_BanBe_TinNhanInfo))
    End Function
    Public Function CMS_BanBe_TinNhan_Add(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo) As Integer
        Return DataProvider.Instance().CMS_BanBe_TinNhan_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_BanBe_TinNhan_Update(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo)
        DataProvider.Instance().CMS_BanBe_TinNhan_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_BanBe_TinNhan_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_BanBe_TinNhan_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_LoaiTuVan"
    Public Function CMS_LoaiTuVan_Get(PortalConnect As String, iD As Integer) As CMS_LoaiTuVanInfo
        Return CBO.FillObject(Of CMS_LoaiTuVanInfo)(DataProvider.Instance().CMS_LoaiTuVan_Get(PortalConnect, iD))
    End Function
    Public Function CMS_LoaiTuVan_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LoaiTuVan_List(PortalConnect), GetType(CMS_LoaiTuVanInfo))
    End Function
    Public Function CMS_LoaiTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LoaiTuVan_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LoaiTuVanInfo))
    End Function

    Public Function CMS_LoaiTuVan_Add(PortalConnect As String, obj As CMS_LoaiTuVanInfo) As Integer
        Return DataProvider.Instance().CMS_LoaiTuVan_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_LoaiTuVan_Update(PortalConnect As String, obj As CMS_LoaiTuVanInfo)
        DataProvider.Instance().CMS_LoaiTuVan_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_LoaiTuVan_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_LoaiTuVan_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_CaTuVan"
    Public Function CMS_CaTuVan_Get(PortalConnect As String, iD As Integer) As CMS_CaTuVanInfo
        Return CBO.FillObject(Of CMS_CaTuVanInfo)(DataProvider.Instance().CMS_CaTuVan_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CaTuVan_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVan_List(PortalConnect), GetType(CMS_CaTuVanInfo))
    End Function
    Public Function CMS_CaTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVan_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CaTuVanInfo))
    End Function

    Public Function CMS_CaTuVan_Add(PortalConnect As String, obj As CMS_CaTuVanInfo) As Integer
        Return DataProvider.Instance().CMS_CaTuVan_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CaTuVan_Update(PortalConnect As String, obj As CMS_CaTuVanInfo)
        DataProvider.Instance().CMS_CaTuVan_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CaTuVan_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CaTuVan_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_DonHangXKLD"
    Public Function CMS_DonHangXKLD_Get(PortalConnect As String, iD As Integer) As CMS_DonHangXKLDInfo
        Return CBO.FillObject(Of CMS_DonHangXKLDInfo)(DataProvider.Instance().CMS_DonHangXKLD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_DonHangXKLD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DonHangXKLD_List(PortalConnect), GetType(CMS_DonHangXKLDInfo))
    End Function
    Public Function CMS_DonHangXKLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DonHangXKLD_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DonHangXKLDInfo))
    End Function

    Public Function CMS_DonHangXKLD_Add(PortalConnect As String, obj As CMS_DonHangXKLDInfo) As Integer
        Return DataProvider.Instance().CMS_DonHangXKLD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DonHangXKLD_Update(PortalConnect As String, obj As CMS_DonHangXKLDInfo)
        DataProvider.Instance().CMS_DonHangXKLD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DonHangXKLD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_DonHangXKLD_Delete(PortalConnect, iD)
    End Sub
    Public Sub CMS_DonHangNLD_Update_Introduce(PortalConnect As String, iD As Integer, isIntroduce As Boolean)
        DataProvider.Instance().CMS_DonHangNLD_Update_Introduce(PortalConnect, iD, isIntroduce)
    End Sub
#End Region

#Region "CMS_DonHangNLD"
    Public Function CMS_DonHangNLD_Get(PortalConnect As String, id As Integer) As CMS_DonHangNLDInfo
        Return CBO.FillObject(Of CMS_DonHangNLDInfo)(DataProvider.Instance().CMS_DonHangNLD_Get(PortalConnect, id))
    End Function
    Public Function CMS_DonHangNLD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DonHangNLD_List(PortalConnect), GetType(CMS_DonHangNLDInfo))
    End Function
    Public Function CMS_DonHangNLD_List_Search(PortalConnect As String, idDonHangXKLD As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_DonHangNLD_List_Search(PortalConnect, idDonHangXKLD, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_DonHangNLDInfo))
    End Function

    Public Function CMS_DonHangNLD_Add(PortalConnect As String, obj As CMS_DonHangNLDInfo) As Integer
        Return DataProvider.Instance().CMS_DonHangNLD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_DonHangNLD_Update(PortalConnect As String, obj As CMS_DonHangNLDInfo)
        DataProvider.Instance().CMS_DonHangNLD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_DonHangNLD_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_DonHangNLD_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_CaTuVanCN"
    Public Function CMS_CaTuVanCN_Get(PortalConnect As String, iD As Integer) As CMS_CaTuVanCNInfo
        Return CBO.FillObject(Of CMS_CaTuVanCNInfo)(DataProvider.Instance().CMS_CaTuVanCN_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CaTuVanCN_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVanCN_List(PortalConnect), GetType(CMS_CaTuVanCNInfo))
    End Function
    Public Function CMS_CaTuVanCN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVanCN_List_Search(PortalConnect, idCaTuVan, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CaTuVanCNInfo))
    End Function

    Public Function CMS_CaTuVanCN_Add(PortalConnect As String, obj As CMS_CaTuVanCNInfo) As Integer
        Return DataProvider.Instance().CMS_CaTuVanCN_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CaTuVanCN_Update(PortalConnect As String, obj As CMS_CaTuVanCNInfo)
        DataProvider.Instance().CMS_CaTuVanCN_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CaTuVanCN_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CaTuVanCN_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_CaTuVanDN"
    Public Function CMS_CaTuVanDN_Get(PortalConnect As String, iD As Integer) As CMS_CaTuVanDNInfo
        Return CBO.FillObject(Of CMS_CaTuVanDNInfo)(DataProvider.Instance().CMS_CaTuVanDN_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CaTuVanDN_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVanDN_List(PortalConnect), GetType(CMS_CaTuVanDNInfo))
    End Function
    Public Function CMS_CaTuVanDN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CaTuVanDN_List_Search(PortalConnect, idCaTuVan, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CaTuVanDNInfo))
    End Function

    Public Function CMS_CaTuVanDN_Add(PortalConnect As String, obj As CMS_CaTuVanDNInfo) As Integer
        Return DataProvider.Instance().CMS_CaTuVanDN_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CaTuVanDN_Update(PortalConnect As String, obj As CMS_CaTuVanDNInfo)
        DataProvider.Instance().CMS_CaTuVanDN_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CaTuVanDN_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CaTuVanDN_Delete(PortalConnect, iD)
    End Sub
#End Region

#Region "CMS_ChuDe"
    Public Function CMS_ChuDe_Get(PortalConnect As String, id As Integer) As CMS_ChuDeInfo
        Return CBO.FillObject(Of CMS_ChuDeInfo)(DataProvider.Instance().CMS_ChuDe_Get(PortalConnect, id))
    End Function
    Public Function CMS_ChuDe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ChuDe_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ChuDeInfo))
    End Function
    Public Function CMS_ChuDe_Add(PortalConnect As String, obj As CMS_ChuDeInfo) As Integer
        Return DataProvider.Instance().CMS_ChuDe_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ChuDe_Update(PortalConnect As String, obj As CMS_ChuDeInfo)
        DataProvider.Instance().CMS_ChuDe_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ChuDe_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_ChuDe_Delete(PortalConnect, id)
    End Sub
    Public Sub CMS_ChuDe_Update_Quick(PortalConnect As String, id As Integer, isActive As Boolean, isLoai As Integer, userName As String)
        DataProvider.Instance().CMS_ChuDe_Update_Quick(PortalConnect, id, isActive, isLoai, userName)
    End Sub
#End Region

#Region "CMS_ChuDe_BinhLuan"
    Public Function CMS_ChuDe_BinhLuan_Get(PortalConnect As String, id As Integer) As CMS_ChuDe_BinhLuanInfo
        Return CBO.FillObject(Of CMS_ChuDe_BinhLuanInfo)(DataProvider.Instance().CMS_ChuDe_BinhLuan_Get(PortalConnect, id))
    End Function
    Public Function CMS_ChuDe_BinhLuan_List_Search(PortalConnect As String, idChuDe As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_ChuDe_BinhLuan_List_Search(PortalConnect, idChuDe, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ChuDe_BinhLuanInfo))
    End Function
    Public Function CMS_ChuDe_BinhLuan_Add(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo) As Integer
        Return DataProvider.Instance().CMS_ChuDe_BinhLuan_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_ChuDe_BinhLuan_Update(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo)
        DataProvider.Instance().CMS_ChuDe_BinhLuan_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_ChuDe_BinhLuan_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_ChuDe_BinhLuan_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "CMS_VanPhongGD"
    Public Function CMS_VanPhongGD_Get(PortalConnect As String, id As Integer) As CMS_VanPhongGDInfo
        Return CBO.FillObject(Of CMS_VanPhongGDInfo)(DataProvider.Instance().CMS_VanPhongGD_Get(PortalConnect, id))
    End Function
    Public Function CMS_VanPhongGD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_VanPhongGD_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_VanPhongGDInfo))
    End Function

    Public Function CMS_VanPhongGD_Add(PortalConnect As String, obj As CMS_VanPhongGDInfo) As Integer
        Return DataProvider.Instance().CMS_VanPhongGD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_VanPhongGD_Update(PortalConnect As String, obj As CMS_VanPhongGDInfo)
        DataProvider.Instance().CMS_VanPhongGD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_VanPhongGD_Delete(PortalConnect As String, id As Integer)
        DataProvider.Instance().CMS_VanPhongGD_Delete(PortalConnect, id)
    End Sub
#End Region

#Region "DTNGHE_Diem"
    Public Function DTNGHE_Diem_Get(maDiem As Integer) As DTNGHE_DiemInfo
        Return CBO.FillObject(Of DTNGHE_DiemInfo)(DataProvider.Instance().DTNGHE_Diem_Get(maDiem))
    End Function
    Public Function DTNGHE_Diem_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_Diem_List(), GetType(DTNGHE_DiemInfo))
    End Function
    Public Function DTNGHE_Diem_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_Diem_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_DiemInfo))
    End Function

    Public Function DTNGHE_Diem_Add(obj As DTNGHE_DiemInfo) As Integer
        Return DataProvider.Instance().DTNGHE_Diem_Add(obj)
    End Function
    Public Sub DTNGHE_Diem_Update(obj As DTNGHE_DiemInfo)
        DataProvider.Instance().DTNGHE_Diem_Update(obj)
    End Sub
    Public Sub DTNGHE_Diem_Delete(maDiem As Integer)
        DataProvider.Instance().DTNGHE_Diem_Delete(maDiem)
    End Sub
    Public Sub DTNGHE_Diem_Update_Quick(maDiem As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_Diem_Update_Quick(maDiem, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_HocVien"
    Public Function DTNGHE_HocVien_Get(maHocVien As Integer) As DTNGHE_HocVienInfo
        Return CBO.FillObject(Of DTNGHE_HocVienInfo)(DataProvider.Instance().DTNGHE_HocVien_Get(maHocVien))
    End Function
    Public Function DTNGHE_HocVien_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_HocVien_List(), GetType(DTNGHE_HocVienInfo))
    End Function
    Public Function DTNGHE_Diem_ListByHocVien(hvID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_Diem_ListByHocVien(hvID), GetType(DTNGHE_DiemInfo))
    End Function
    Public Function DTNGHE_HocVien_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_HocVien_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_HocVienInfo))
    End Function

    Public Function DTNGHE_HocVien_Add(obj As DTNGHE_HocVienInfo) As Integer
        Return DataProvider.Instance().DTNGHE_HocVien_Add(obj)
    End Function
    Public Sub DTNGHE_HocVien_Update(obj As DTNGHE_HocVienInfo)
        DataProvider.Instance().DTNGHE_HocVien_Update(obj)
    End Sub
    Public Sub DTNGHE_HocVien_Delete(maHocVien As Integer)
        DataProvider.Instance().DTNGHE_HocVien_Delete(maHocVien)
    End Sub
    Public Sub DTNGHE_HocVien_Update_Quick(maHocVien As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_HocVien_Update_Quick(maHocVien, isActive, isOrder)
    End Sub
#End Region

#Region "DTNGHE_LopHoc"
    Public Function DTNGHE_LopHoc_Get(iD As Integer) As DTNGHE_LopHocInfo
        Return CBO.FillObject(Of DTNGHE_LopHocInfo)(DataProvider.Instance().DTNGHE_LopHoc_Get(iD))
    End Function
    Public Function DTNGHE_LopHoc_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_LopHoc_List(), GetType(DTNGHE_LopHocInfo))
    End Function
    Public Function DTNGHE_LopHoc_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_LopHoc_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_LopHocInfo))
    End Function

    Public Function DTNGHE_LopHoc_Add(obj As DTNGHE_LopHocInfo) As Integer
        Return DataProvider.Instance().DTNGHE_LopHoc_Add(obj)
    End Function
    Public Sub DTNGHE_LopHoc_Update(obj As DTNGHE_LopHocInfo)
        DataProvider.Instance().DTNGHE_LopHoc_Update(obj)
    End Sub
    Public Sub DTNGHE_LopHoc_Delete(iD As Integer)
        DataProvider.Instance().DTNGHE_LopHoc_Delete(iD)
    End Sub
    Public Sub DTNGHE_LopHoc_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_LopHoc_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region

#Region "DTNGHE_NgheDaoTao"
    Public Function DTNGHE_NgheDaoTao_Get(iD As Integer) As DTNGHE_NgheDaoTaoInfo
        Return CBO.FillObject(Of DTNGHE_NgheDaoTaoInfo)(DataProvider.Instance().DTNGHE_NgheDaoTao_Get(iD))
    End Function
    Public Function DTNGHE_NgheDaoTao_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_NgheDaoTao_List(), GetType(DTNGHE_NgheDaoTaoInfo))
    End Function
    Public Function DTNGHE_NgheDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_NgheDaoTao_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_NgheDaoTaoInfo))
    End Function

    Public Function DTNGHE_NgheDaoTao_Add(obj As DTNGHE_NgheDaoTaoInfo) As Integer
        Return DataProvider.Instance().DTNGHE_NgheDaoTao_Add(obj)
    End Function
    Public Sub DTNGHE_NgheDaoTao_Update(obj As DTNGHE_NgheDaoTaoInfo)
        DataProvider.Instance().DTNGHE_NgheDaoTao_Update(obj)
    End Sub
    Public Sub DTNGHE_NgheDaoTao_Delete(iD As Integer)
        DataProvider.Instance().DTNGHE_NgheDaoTao_Delete(iD)
    End Sub
    Public Sub DTNGHE_NgheDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_NgheDaoTao_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region


#Region "DTNGHE_ThoiGianDaoTao"
    Public Function DTNGHE_ThoiGianDaoTao_Get(iD As Integer) As DTNGHE_ThoiGianDaoTaoInfo
        Return CBO.FillObject(Of DTNGHE_ThoiGianDaoTaoInfo)(DataProvider.Instance().DTNGHE_ThoiGianDaoTao_Get(iD))
    End Function
    Public Function DTNGHE_ThoiGianDaoTao_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThoiGianDaoTao_List(), GetType(DTNGHE_ThoiGianDaoTaoInfo))
    End Function
    Public Function DTNGHE_ThoiGianDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThoiGianDaoTao_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_ThoiGianDaoTaoInfo))
    End Function

    Public Function DTNGHE_ThoiGianDaoTao_Add(obj As DTNGHE_ThoiGianDaoTaoInfo) As Integer
        Return DataProvider.Instance().DTNGHE_ThoiGianDaoTao_Add(obj)
    End Function
    Public Sub DTNGHE_ThoiGianDaoTao_Update(obj As DTNGHE_ThoiGianDaoTaoInfo)
        DataProvider.Instance().DTNGHE_ThoiGianDaoTao_Update(obj)
    End Sub
    Public Sub DTNGHE_ThoiGianDaoTao_Delete(iD As Integer)
        DataProvider.Instance().DTNGHE_ThoiGianDaoTao_Delete(iD)
    End Sub
    Public Sub DTNGHE_ThoiGianDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_ThoiGianDaoTao_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region

#Region "DTNGHE_KetQuaDaoTao"
    Public Function DTNGHE_KetQuaDaoTao_Get(iD As Integer) As DTNGHE_KetQuaDaoTaoInfo
        Return CBO.FillObject(Of DTNGHE_KetQuaDaoTaoInfo)(DataProvider.Instance().DTNGHE_KetQuaDaoTao_Get(iD))
    End Function
    Public Function DTNGHE_KetQuaDaoTao_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_KetQuaDaoTao_List(), GetType(DTNGHE_KetQuaDaoTaoInfo))
    End Function
    Public Function DTNGHE_KetQuaDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_KetQuaDaoTao_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(DTNGHE_KetQuaDaoTaoInfo))
    End Function

    Public Function DTNGHE_KetQuaDaoTao_Add(obj As DTNGHE_KetQuaDaoTaoInfo) As Integer
        Return DataProvider.Instance().DTNGHE_KetQuaDaoTao_Add(obj)
    End Function
    Public Sub DTNGHE_KetQuaDaoTao_Update(obj As DTNGHE_KetQuaDaoTaoInfo)
        DataProvider.Instance().DTNGHE_KetQuaDaoTao_Update(obj)
    End Sub
    Public Sub DTNGHE_KetQuaDaoTao_Delete(iD As Integer)
        DataProvider.Instance().DTNGHE_KetQuaDaoTao_Delete(iD)
    End Sub
    Public Sub DTNGHE_KetQuaDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().DTNGHE_KetQuaDaoTao_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_BAOCAO"
    Public Function DTNGHE_ThongKe_LopHoc_TheoNghe() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_LopHoc_TheoNghe(), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_LopHoc_TheoThoiGian() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_LopHoc_TheoThoiGian(), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_HocVien_TheoKetQua() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_HocVien_TheoKetQua(), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_HocVien_TheoNghe() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_HocVien_TheoNghe(), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_HocVien_TheoThoiGian() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_HocVien_TheoThoiGian(), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang(viewType, year, month), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_HocVien_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_HocVien_TheoNgayKhaiGiang(viewType, year, month), GetType(DTNGHE_ThongKeInfo))
    End Function
    Public Function DTNGHE_ThongKe_LichHen() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().DTNGHE_ThongKe_LichHen(), GetType(DTNGHE_ThongKeInfo))
    End Function
#End Region
#Region "SVL_BAOCAO"

    Public Function SVL_ThongKe_DN_TheoNghe(PhienGD_ID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().SVL_ThongKe_DN_TheoNghe(PhienGD_ID), GetType(ReportInfo))
    End Function

    Public Function SVL_ThongKe_DN_TheoQuyMo(PhienGD_ID As String, QuyMo_ID As Int16) As Integer
        Return DataProvider.Instance().SVL_ThongKe_DN_TheoQuyMo(PhienGD_ID, QuyMo_ID)
    End Function

    Public Function SVL_ThongKe_NLD_TheoNhuCauVL(PhienGD_ID As String, NhuCau_ID As Int16) As Integer
        Return DataProvider.Instance().SVL_ThongKe_NLD_TheoNhuCauVL(PhienGD_ID, NhuCau_ID)
    End Function
#End Region

#Region "CMS_LichHen"
    Public Function CMS_LichHen_Get(iD As Integer) As CMS_LichHenInfo
        Return CBO.FillObject(Of CMS_LichHenInfo)(DataProvider.Instance().CMS_LichHen_Get(iD))
    End Function
    Public Function CMS_LichHen_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LichHen_List(), GetType(CMS_LichHenInfo))
    End Function
    Public Function CMS_LichHen_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LichHen_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LichHenInfo))
    End Function
    Public Function CMS_LichHen_Add(obj As CMS_LichHenInfo) As Integer
        Return DataProvider.Instance().CMS_LichHen_Add(obj)
    End Function
    Public Sub CMS_LichHen_Update(obj As CMS_LichHenInfo)
        DataProvider.Instance().CMS_LichHen_Update(obj)
    End Sub
    Public Sub CMS_LichHen_Delete(iD As Integer)
        DataProvider.Instance().CMS_LichHen_Delete(iD)
    End Sub
#End Region

#Region "CMS_JobFollow"
    Public Function CMS_JobFollow_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_JobFollow_List_Search(search, isOrder, currPage, recodperpage, UserName), GetType(CMS_JobFollowInfo))
    End Function
    Public Function CMS_JobFollow_Add(obj As CMS_JobFollowInfo) As Integer
        Return DataProvider.Instance().CMS_JobFollow_Add(obj)
    End Function

#End Region


#Region "XKL_DangKy"
    Public Function XKL_DangKy_Get(iD As Integer) As XKL_DangKyInfo
        Return CBO.FillObject(Of XKL_DangKyInfo)(DataProvider.Instance().XKL_DangKy_Get(iD))
    End Function
    Public Function XKL_DangKy_List() As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().XKL_DangKy_List(), GetType(XKL_DangKyInfo))
    End Function
    Public Function XKL_DangKy_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().XKL_DangKy_List_Search(search, isOrder, currPage, recodperpage, UserName, YearId), GetType(XKL_DangKyInfo))
    End Function

    Public Function XKL_DangKy_Add(obj As XKL_DangKyInfo) As Integer
        Return DataProvider.Instance().XKL_DangKy_Add(obj)
    End Function
    Public Sub XKL_DangKy_Update(obj As XKL_DangKyInfo)
        DataProvider.Instance().XKL_DangKy_Update(obj)
    End Sub
    Public Sub XKL_DangKy_Delete(iD As Integer)
        DataProvider.Instance().XKL_DangKy_Delete(iD)
    End Sub
    Public Sub XKL_DangKy_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().XKL_DangKy_Update_Quick(iD, isActive, isOrder)
    End Sub
#End Region


End Class
