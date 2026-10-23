Imports System.Data.SqlClient
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK.DTNGHE_KetQuaDaoTaoInfo
Imports Microsoft.ApplicationBlocks.Data
Public Class SqlDataProvider
    Inherits DataProvider

#Region "CMS_Counter"
    Public Overrides Function CMS_Counter_Get(PortalConnect As String, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Counter_Get", portalID), IDataReader)
    End Function
#End Region
#Region "CMS_Business"
    Public Overrides Function CMS_Business_Get_ToApp(tinhTP As Integer, business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_Get", business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_Get_ID", ID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_Check_TaxCode(PortalConnect As String, business_ID As String, taxCode As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_Check_TaxCode", business_ID, taxCode), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_By_TinhTP(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_By_TinhTP", portalId, tinhTP, quanHuyen, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Function CMS_Business_List_LatLng(tinhTP As Integer, quanHuyen As String, xaPhuong As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_LatLng", tinhTP, quanHuyen, xaPhuong), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_By_TinhTP_ToApp(tinhTP As Integer, quanHuyen As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_By_TinhTP_ToApp", tinhTP, quanHuyen), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_By_TinhTP_IsSent(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isSent As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_By_TinhTP_IsSent", portalId, tinhTP, quanHuyen, isSent), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isOffline As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_By_TinhTP_IsOffline", portalId, tinhTP, quanHuyen, isOffline), IDataReader)
    End Function
    Public Overrides Function CMS_Business_Get_UserAdmin(PortalConnect As String, UserAdmin As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_Get_UserAdmin", UserAdmin), IDataReader)
    End Function
    Public Overrides Function CMS_Business_Get(PortalConnect As String, business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_Get", business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_Approval(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, isActive As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_Approval", search, fullText, currPage, recodperpage, tinhTp, quanHuyen, isActive), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_Active(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isActive As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_Active", search, fullText, currPage, recodperpage, tinhTp, quanHuyen, phuongXa, isActive), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_Search", search, isOrder, currPage, recodperpage, UserName, tinhTp, quanHuyen), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, quanHuyen As String, WBID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_ToApp", search, isOrder, currPage, recodperpage, tinhTP, quanHuyen, WBID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_SVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_SVL", search, currPage, recodperpage, PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_NotJoinPhienGD(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_NotJoinPhienGD", search, currPage, recodperpage, PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Business_List_SVL_QT(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_SVL_QT", search, currPage, recodperpage, PhienGD_ID, Status), IDataReader)
    End Function
    Public Overrides Function CMS_Business_Check(PortalConnect As String, obj As CMS_BusinessInfo) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Business_Check", obj.Business_ID, obj.Business_Vn, obj.Business_En,
                                obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.Logo, obj.Description, obj.TaxCode, obj.Mobile, obj.Fax, obj.Website, obj.Email, obj.Address,
                                obj.ContactUser, obj.ContactMobile, obj.ContactEmail, obj.CreatedDate, obj.CreatedUser,
                                flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsApproval, obj.ApprovalUser, flReg.GetNull(obj.ApprovalDate), obj.PortalId, obj.Scale), String)
    End Function
    Public Overrides Sub CMS_Business_Add(PortalConnect As String, obj As CMS_BusinessInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Business_Add", obj.Business_ID, obj.Business_Vn, obj.Business_En, obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.Logo, obj.Description, obj.TaxCode, obj.Mobile, obj.Career_ID, obj.LoaiHinh_ID, obj.Fax, obj.Website, obj.Email, obj.Address, obj.ContactUser, obj.ContactMobile, obj.ContactEmail, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate, obj.PortalId, obj.Scale, obj.Types, obj.KCN, obj.KCN_ID, obj.SanPhamChinh, obj.QuyMoLaoDong, obj.ContactChucVu, obj.ContactLHKhac, obj.DichVuDangKy, obj.DichVuDangKyKhac, obj.SoLD6ThangToi)
    End Sub
    Public Overrides Sub CMS_Business_Add_All(PortalConnect As String, obj As CMS_BusinessInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Business_Add_All", obj.Business_ID, obj.Business_Vn, obj.Business_En,
                                obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.Logo, obj.Description, obj.TaxCode, obj.Mobile, obj.Fax, obj.Website, obj.Email, obj.Address,
                                obj.ContactUser, obj.ContactMobile, obj.ContactEmail, obj.CreatedDate, obj.CreatedUser,
                                flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsApproval, obj.ApprovalUser, flReg.GetNull(obj.ApprovalDate), obj.PortalId, obj.Scale)
    End Sub
    Public Overrides Sub SV_Business_Add(PortalConnect As String, business_ID As String, business_Vn As String, business_En As String, business_Sort As String, tinhTp As String, quanHuyen As String, logo As String, description As String, taxCode As String, mobile As String, fax As String, website As String, email As String, address As String, contactUser As String, contactMobile As String, contactEmail As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, portalId As Integer, Scale As String, idSend As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Business_Add", business_ID, business_Vn, business_En,
                                business_Sort, tinhTp, quanHuyen, logo, description, taxCode, mobile, fax, website, email, address,
                                contactUser, contactMobile, contactEmail, createdDate, createdUser,
                                flReg.GetNull(updatedDate), updatedUser, isApproval, approvalUser, flReg.GetNull(approvalDate), portalId, Scale, idSend)
    End Sub
    Public Overrides Sub CMS_Business_Update(PortalConnect As String, obj As CMS_BusinessInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update", obj.Business_ID, obj.Business_Vn, obj.Business_En, obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.XaPhuong, obj.Logo, obj.Description, obj.TaxCode, obj.Mobile, obj.Career_ID, obj.LoaiHinh_ID, obj.Fax, obj.Website, obj.Email, obj.Address, obj.ContactUser, obj.ContactMobile, obj.ContactEmail, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsApproval, obj.ApprovalUser, obj.ApprovalDate, obj.PortalId, obj.Scale, obj.Types, obj.KCN, obj.KCN_ID, obj.SanPhamChinh, obj.QuyMoLaoDong, obj.ContactChucVu, obj.ContactLHKhac, obj.DichVuDangKy, obj.DichVuDangKyKhac, obj.SoLD6ThangToi)
    End Sub
    Public Overrides Sub CMS_Business_Delete(PortalConnect As String, business_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Delete", business_ID)
    End Sub
    Public Overrides Sub CMS_Business_Update_Quick(PortalConnect As String, business_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update_Quick", business_ID, isApproval, approvalUser, approvalDate)
    End Sub
    Public Overrides Sub CMS_Business_Update_IsSent(PortalConnect As String, business_ID As String, isSent As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update_IsSent", business_ID, isSent)
    End Sub
    Public Overrides Sub CMS_Business_Update_LatLng(PortalConnect As String, business_ID As String, lat As String, lng As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update_LatLng", business_ID, lat, lng)
    End Sub
    Public Overrides Sub CMS_Business_Update_IsOffline(PortalConnect As String, business_ID As String, isOffline As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update_IsOffline", business_ID, isOffline)
    End Sub
    Public Overrides Function CMS_Business_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_Home", portalId, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function SV_Business_Get_By_IdKey(PortalConnect As String, portalId As Integer, idSend As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Business_Get_By_IdKey", portalId, idSend)
    End Function
    Public Overrides Function CMS_Business_List_View_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_View_Home", search, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_SendMail_Check(PortalConnect As String, Business_ID As String, PhienGD_ID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_SendMail_Check", Business_ID, PhienGD_ID), Integer)
    End Function
    Public Overrides Sub CMS_Business_Update_TinCay(PortalConnect As String, business_ID As String, tinCay As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Business_Update_TinCay", business_ID, tinCay)
    End Sub
    Public Overrides Function CMS_Business_List_TinCay(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String, isActive As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_List_TinCay", search, fullText, currPage, recodperpage, tinhTp, quanHuyen, phuongXa, isActive), IDataReader)
    End Function
    Public Overrides Function CMS_Business_by_NLD(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, tinhTp As String, quanHuyen As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Business_by_NLD", search, isOrder, currPage, recodperpage, UserName, tinhTp, quanHuyen), IDataReader)
    End Function
#End Region
#Region "CMS_BusUser"
    Public Overrides Sub CMS_BusUser_Update_Admin(PortalConnect As String, UserAdmin As String, business_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusUser_Update_Admin", UserAdmin, business_ID)
    End Sub
    Public Overrides Function CMS_BusUser_Get_Business_User(PortalConnect As String, business_ID As String, UserAdmin As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusUser_Get_Business_User", business_ID, UserAdmin), IDataReader)
    End Function
    Public Overrides Function CMS_BusUser_Get(PortalConnect As String, busUser_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusUser_Get", busUser_ID), IDataReader)
    End Function
    Public Overrides Function CMS_BusUser_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusUser_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_BusUser_Add(PortalConnect As String, obj As CMS_BusUserInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_BusUser_Add", obj.BusUser_ID, obj.Business_ID, obj.UserAdmin, obj.IsAdmin, obj.IsActive, obj.CreatedDate, obj.UpdatedDate, obj.ApprovalUser, obj.ApprovalDate)
    End Sub
    Public Overrides Sub CMS_BusUser_Update(PortalConnect As String, obj As CMS_BusUserInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusUser_Update", obj.BusUser_ID, obj.Business_ID, obj.UserAdmin, obj.IsAdmin, obj.IsActive, obj.CreatedDate, obj.UpdatedDate, obj.ApprovalUser, obj.ApprovalDate)
    End Sub
    Public Overrides Function CMS_BusUser_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusUser_Get_By_CMS_Business", business_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_BusUser_Delete(PortalConnect As String, busUser_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusUser_Delete", busUser_ID)
    End Sub
    Public Overrides Sub CMS_BusUser_Update_Active(PortalConnect As String, UserAdmin As String, IsActive As Boolean, ApprovalUser As String, ApprovalDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusUser_Update_Active", UserAdmin, IsActive, ApprovalUser, ApprovalDate)
    End Sub
    Public Overrides Sub CMS_BusUser_Delete_By_UnAdmin(PortalConnect As String, busUser_ID As String, UserAdmin As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusUser_Delete_By_UnAdmin", busUser_ID, UserAdmin)
    End Sub
    Public Overrides Sub CMS_BusUser_Add_Import(PortalConnect As String, obj As CMS_BusUserInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_BusUser_Add_Import", obj.BusUser_ID, obj.Business_ID, obj.UserAdmin, obj.IsActive, obj.IsAdmin, obj.CreatedDate, obj.UpdatedDate, obj.ApprovalUser, obj.ApprovalDate)
    End Sub

#End Region
#Region "CMS_ProfileSave"
    Public Overrides Function CMS_ProfileSave_Get(PortalConnect As String, profileSave_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ProfileSave_Get", profileSave_ID), IDataReader)
    End Function
    Public Overrides Function CMS_ProfileSave_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ProfileSave_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ProfileSave_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ProfileSave_List_Search", search, isOrder, currPage, recodperpage, UserName, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status), IDataReader)
    End Function
    Public Overrides Sub CMS_ProfileSave_Add(PortalConnect As String, profileSave_ID As String, jobUser_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, business_ID As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_ProfileSave_Add", profileSave_ID, jobUser_ID, isContact, isInterview, isTest, isElect, userName, createDate, flReg.GetNull(updatedDate), updatedUser, business_ID)
    End Sub
    Public Overrides Sub CMS_ProfileSave_Update(PortalConnect As String, profileSave_ID As String, jobUser_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, business_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ProfileSave_Update", profileSave_ID, jobUser_ID, isContact, isInterview, isTest, isElect, userName, createDate, flReg.GetNull(updatedDate), updatedUser, business_ID)
    End Sub
    Public Overrides Sub CMS_ProfileSave_Delete(PortalConnect As String, profileSave_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ProfileSave_Delete", profileSave_ID)
    End Sub
    Public Overrides Sub CMS_ProfileSave_Update_Quick(PortalConnect As String, profileSave_ID As String, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ProfileSave_Update_Quick", profileSave_ID, isContact, isInterview, isTest, isElect, flReg.GetNull(updatedDate), updatedUser)
    End Sub
#End Region
#Region "CMS_Recruitment"
    Public Overrides Function CMS_Recruitment_List_UserName(PortalConnect As String, work_ID As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_UserName", work_ID, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_Get(PortalConnect As String, recruitment_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_Get", recruitment_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Send(PortalConnect As String, search As String, fullText As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Send", search, fullText, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Search", search, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search_HSUT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Search_HSUT", search, isOrder, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search_GT(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Search_GT", search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, FromDate, ToDate, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search_GTAG(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Search_GTAG", search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, FromDate, ToDate, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Recruitment_List_Search_QT(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Recruitment_List_Search_QT", search, isOrder, currPage, recodperpage, UserName, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_Recruitment_Add(PortalConnect As String, recruitment_ID As String, work_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, JobUser_ID As String, IsInvite As Boolean)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Recruitment_Add", recruitment_ID, work_ID, isView, isContact, isInterview, isTest, isElect, isCancel, userName, createDate, flReg.GetNull(updatedDate), updatedUser, JobUser_ID, IsInvite)
    End Sub
    Public Overrides Sub CMS_Recruitment_Update(PortalConnect As String, recruitment_ID As String, work_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, userName As String, createDate As DateTime, updatedDate As DateTime, updatedUser As String, JobUser_ID As String, IsInvite As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Recruitment_Update", recruitment_ID, work_ID, isView, isContact, isInterview, isTest, isElect, isCancel, userName, createDate, flReg.GetNull(updatedDate), updatedUser, JobUser_ID, IsInvite)
    End Sub
    Public Overrides Sub CMS_Recruitment_Delete(PortalConnect As String, recruitment_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Recruitment_Delete", recruitment_ID)
    End Sub
    Public Overrides Sub CMS_Recruitment_Update_Quick(PortalConnect As String, recruitment_ID As String, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Recruitment_Update_Quick", recruitment_ID, isView, isContact, isInterview, isTest, isElect, isCancel, updatedDate, updatedUser)
    End Sub

#End Region
#Region "CMS_Work"

    Public Overrides Sub CMS_Work_Update_IsOffline(PortalConnect As String, work_ID As String, isOffline As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_IsOffline", work_ID, isOffline)
    End Sub
    Public Overrides Function CMS_Work_List_By_TinhTP_IsOffline(PortalConnect As String, portalId As Integer, tinhTP As String, quanHuyen As String, isOffline As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_By_TinhTP_IsOffline", portalId, tinhTP, quanHuyen, isOffline), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_Home(PortalConnect As String, IsFlag As Integer, Top As Integer, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_Home", IsFlag, Top, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Work_Get_ToApp(tinhTP As Integer, work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_Get", work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_LatLng(tinhTP As Integer, quanHuyen As String, phuongXa As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_LatLng", tinhTP, quanHuyen, phuongXa), IDataReader)
    End Function
    Public Overrides Function CMS_Work_Get(PortalConnect As String, work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_Get", work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Work_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_Get_ID", ID), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_Career(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_Career", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_Pages(PortalConnect As String, currPage As Integer, recodperpage As Integer, CareerID As String, TinhTP As Integer, EducationID As String, JobPlaceID As String, SalaryID As String, Experienceid As String, Genner As Integer, Title As String, Flag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_Pages", currPage, recodperpage, CareerID, TinhTP, EducationID, JobPlaceID, SalaryID, Experienceid, Genner, Title, Flag), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_Search", search, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, TinhTP, quanHuyen, status), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_Invite(PortalConnect As String, search As String, isFlag As Integer, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_Invite", search, isFlag, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, status), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_ToApp(tinhTP As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, Business_ID As String, Salary_ID As String, Experience_ID As String, quanHuyen As String, status As Integer, wbID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_ToApp", search, isOrder, currPage, recodperpage, Business_ID, Salary_ID, Experience_ID, tinhTP, quanHuyen, status, wbID), IDataReader)
    End Function
    Public Overrides Sub CMS_Work_Add(PortalConnect As String, work_ID As String, business_ID As String, title As String,
                                     salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer,
                                     level_ID As String, TinhTP As String, quanhuyen As String, phuongXa As String, typeOf_ID As String,
                                     career_ID As String, description As String, requirement As String, benefit As String,
                                     requirementsProfile As String, expiredDate As DateTime, submissionSend As String, startDate As DateTime,
                                     endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String,
                                     contactEmail As String, contactDes As String, isHot As Boolean, isGhim As Boolean, isFast As Boolean, IsUrgent As Boolean,
                                     isApproval As Boolean, Ages As String, WorkTime As String, approvalUser As String, approvalDate As DateTime, isDelete As Boolean,
                                     deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String,
                                     updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, isFlag As Integer, JobPlace As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Work_Add", work_ID, business_ID, title, salary_ID, quantity,
                                experience_ID, gender, level_ID, TinhTP, quanhuyen, phuongXa, typeOf_ID, career_ID, description, requirement, benefit,
                                requirementsProfile, flReg.GetNull(expiredDate), submissionSend, flReg.GetNull(startDate), flReg.GetNull(endDate), contactUser, contactAddress, contactMobile,
                                contactEmail, contactDes, isHot, isGhim, isFast, IsUrgent, isApproval, Ages, WorkTime, approvalUser, flReg.GetNull(approvalDate), isDelete, deletedUser,
                                flReg.GetNull(deletedDate), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalID, LevelDesired_ID, isFlag, JobPlace)
    End Sub
    Public Overrides Sub SV_Work_Add(PortalConnect As String, work_ID As String, business_ID As String, title As String,
                                     salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer,
                                     level_ID As String, TinhTP As String, quanhuyen As String, typeOf_ID As String,
                                     career_ID As String, description As String, requirement As String, benefit As String,
                                     requirementsProfile As String, expiredDate As DateTime, submissionSend As String, startDate As DateTime,
                                     endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String,
                                     contactEmail As String, contactDes As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean,
                                     isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean,
                                     deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String,
                                     updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, isFlag As Integer, JobPlace As String, IdSend As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Work_Add", work_ID, business_ID, title, salary_ID, quantity,
                                experience_ID, gender, level_ID, TinhTP, quanhuyen, typeOf_ID, career_ID, description, requirement, benefit,
                                requirementsProfile, expiredDate, submissionSend, startDate, endDate, contactUser, contactAddress, contactMobile,
                                contactEmail, contactDes, isHot, isFast, IsUrgent, isApproval, approvalUser, flReg.GetNull(approvalDate), isDelete, deletedUser,
                                flReg.GetNull(deletedDate), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalID, LevelDesired_ID, isFlag, JobPlace, IdSend)
    End Sub
    Public Overrides Sub CMS_Work_Update(PortalConnect As String, work_ID As String, business_ID As String, title As String,
                                     salary_ID As String, quantity As Integer, experience_ID As String, gender As Integer,
                                     level_ID As String, TinhTP As String, quanhuyen As String, phuongXa As String, typeOf_ID As String,
                                     career_ID As String, description As String, requirement As String, benefit As String,
                                     requirementsProfile As String, expiredDate As DateTime, submissionSend As String, startDate As DateTime,
                                     endDate As DateTime, contactUser As String, contactAddress As String, contactMobile As String,
                                     contactEmail As String, contactDes As String, isHot As Boolean, isGhim As Boolean, isFast As Boolean, IsUrgent As Boolean,
                                     isApproval As Boolean, Ages As String, WorkTime As String, approvalUser As String, approvalDate As DateTime, isDelete As Boolean,
                                     deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String,
                                     updatedDate As DateTime, updatedUser As String, portalID As Integer, LevelDesired_ID As String, JobPlace As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Work_Update", work_ID, business_ID, title, salary_ID, quantity,
                                experience_ID, gender, level_ID, TinhTP, quanhuyen, phuongXa, typeOf_ID, career_ID, description, requirement, benefit,
                                requirementsProfile, flReg.GetNull(expiredDate), submissionSend, flReg.GetNull(startDate), flReg.GetNull(endDate), contactUser, contactAddress, contactMobile,
                                contactEmail, contactDes, isHot, isGhim, isFast, IsUrgent, isApproval, Ages, WorkTime, approvalUser, flReg.GetNull(approvalDate), isDelete, deletedUser,
                                flReg.GetNull(deletedDate), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalID, LevelDesired_ID, JobPlace)
    End Sub
    Public Overrides Sub CMS_Work_Delete(PortalConnect As String, work_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Delete", work_ID)
    End Sub
    Public Overrides Function CMS_Work_Get_By_CMS_Business(PortalConnect As String, business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_Get_By_CMS_Business", business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Work_List_By_Business_Home(PortalConnect As String, business_ID As String, portalID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_By_Business_Home", business_ID, portalID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Work_Update_Delete(PortalConnect As String, work_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_Delete", work_ID, isDelete, DeletedUser, DeletedDate)
    End Sub
    Public Overrides Sub CMS_Work_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_Quick", work_ID, isHot, isFast, IsUrgent, isApproval, approvalUser, approvalDate)
    End Sub
    Public Overrides Sub CMS_Work_Update_View(PortalConnect As String, work_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_View", work_ID)
    End Sub
    Public Overrides Sub CMS_Work_Update_Sent(PortalConnect As String, work_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_Sent", work_ID)
    End Sub
    Public Overrides Sub CMS_Work_Update_LatLng(PortalConnect As String, work_ID As String, lat As String, lng As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Work_Update_LatLng", work_ID, lat, lng)
    End Sub
#End Region
#Region "CMS_JobUser"
    Public Overrides Function CMS_JUser_List_GTVL(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JUser_List_GTVL", search, currPage, recodperpage, Career_ID, Salary_ID, Experience_ID, tinhTP, quanHuyen, work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_Get_ID", ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_Get(PortalConnect As String, jobUser_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_Get", jobUser_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_List_SendMail(PortalConnect As String, IdKey As String, Flag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List_SendMail", IdKey, Flag), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List_Search", search, isOrder, currPage, recodperpage, UserName, Career_ID, Salary_ID, Experience_ID, tinhTP, quanHuyen), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_List_Home(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Salary_ID As String, Experience_ID As String, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List_Home", search, currPage, recodperpage, Career_ID, Salary_ID, Experience_ID, tinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_List_Home_BKUV(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, Career_ID As String, Level_ID As String, LevelDesired As String, Salary_ID As String, Experience_ID As String, tinhTP As String, GioiTinh As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List_Home_BKUV", search, currPage, recodperpage, Career_ID, Level_ID, LevelDesired, Salary_ID, Experience_ID, tinhTP, GioiTinh), IDataReader)
    End Function
    Public Overrides Sub CMS_JobUser_Add(PortalConnect As String, jobUser_ID As String, title As String, career_ID As String, currentLevel As String, levelDesired As String, tinhTP As String, quanHuyen As String, experience_ID As String, level_ID As String, salary_ID As String, needs_ID As String, education As String, careerGoals As String, WorkExperience As String, skillsForte As String, userAdmin As String, startDate As DateTime, endDate As DateTime, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobUser_Add", jobUser_ID, title, career_ID, currentLevel, levelDesired, tinhTP, quanHuyen, experience_ID, level_ID, salary_ID, needs_ID, education, careerGoals, WorkExperience, skillsForte, userAdmin, startDate, endDate, isApproval, approvalUser, flReg.GetNull(approvalDate), isDelete, deletedUser, flReg.GetNull(deletedDate), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalID)
    End Sub
    Public Overrides Sub CMS_JobUser_AddFromBTHN(PortalConnect As String, obj As CMS_JobUserInfo, objJ As CMS_JobUserBHTNInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobUser_AddFromBTHN", objJ.BHTN_ID, objJ.HoTen, objJ.NgaySinh, objJ.GioiTinh, objJ.Email, objJ.SoDienThoai, obj.JobUser_ID, obj.Title, obj.Career_ID, obj.CurrentLevel, obj.LevelDesired, obj.TinhTP, obj.QuanHuyen, obj.Experience_ID, obj.Level_ID, obj.Salary_ID, obj.Needs_ID, obj.Education, obj.CareerGoals, obj.WorkExperience, obj.SkillsForte, obj.UserAdmin, obj.StartDate, obj.EndDate, obj.IsApproval, obj.ApprovalUser, flReg.GetNull(obj.ApprovalDate), obj.IsDelete, obj.DeletedUser, flReg.GetNull(obj.DeletedDate), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_JobUser_Update(PortalConnect As String, jobUser_ID As String, title As String, career_ID As String, currentLevel As String, levelDesired As String, tinhTP As String, quanHuyen As String, experience_ID As String, level_ID As String, salary_ID As String, needs_ID As String, education As String, careerGoals As String, WorkExperience As String, skillsForte As String, userAdmin As String, startDate As DateTime, endDate As DateTime, isApproval As Boolean, approvalUser As String, approvalDate As DateTime, isDelete As Boolean, deletedUser As String, deletedDate As DateTime, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUser_Update", jobUser_ID, title, career_ID, currentLevel, levelDesired, tinhTP, quanHuyen, experience_ID, level_ID, salary_ID, needs_ID, education, careerGoals, WorkExperience, skillsForte, userAdmin, startDate, endDate, isApproval, approvalUser, flReg.GetNull(approvalDate), isDelete, deletedUser, flReg.GetNull(deletedDate), createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, portalID)
    End Sub
    Public Overrides Sub CMS_JobUser_Delete(PortalConnect As String, jobUser_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUser_Delete", jobUser_ID)
    End Sub
    Public Overrides Sub CMS_JobUser_Update_Quick(PortalConnect As String, JobUser_ID As String, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUser_Update_Quick", JobUser_ID, isApproval, approvalUser, approvalDate)
    End Sub
    Public Overrides Sub CMS_JobUser_Update_Delete(PortalConnect As String, JobUser_ID As String, isDelete As Boolean, DeletedUser As String, DeletedDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUser_Update_Delete", JobUser_ID, isDelete, DeletedUser, DeletedDate)
    End Sub
    Public Overrides Function CMS_JobUser_List_UserName(PortalConnect As String, portalID As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUser_List_UserName", portalID, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_JobUser_Update_View(PortalConnect As String, JobUser_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUser_Update_View", JobUser_ID)
    End Sub
#End Region
#Region "CMS_JobView"

    Public Overrides Function CMS_JobView_Check(PortalConnect As String, idKey As String, usName As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobView_Check", idKey, usName), Integer)
    End Function
    Public Overrides Function CMS_JobView_Get(PortalConnect As String, jobView_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobView_Get", jobView_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobView_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobView_List"), IDataReader)
    End Function
    Public Overrides Function CMS_JobView_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, IsFlag As Integer, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobView_List_Search", search, isOrder, currPage, recodperpage, UserName, IsFlag, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID), IDataReader)
    End Function

    Public Overrides Sub CMS_JobView_Add(PortalConnect As String, jobView_ID As String, idKey As String, isFlag As Integer, userName As String, createDate As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobView_Add", jobView_ID, idKey, isFlag, userName, createDate)
    End Sub
    Public Overrides Sub CMS_JobView_Update(PortalConnect As String, jobView_ID As String, idKey As String, isFlag As Integer, userName As String, createDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobView_Update", jobView_ID, idKey, isFlag, userName, createDate)
    End Sub
    Public Overrides Sub CMS_JobView_Delete(PortalConnect As String, jobView_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobView_Delete", jobView_ID)
    End Sub
#End Region
#Region "CMS_JobInvite"
    Public Overrides Function CMS_WorkInvite_Check(PortalConnect As String, WorkID As String, BusID As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_WorkInvite_Check", WorkID, BusID), Integer)
    End Function
    Public Overrides Function CMS_JobInvite_Check(PortalConnect As String, idKey As String, usName As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobInvite_Check", idKey, usName), Integer)
    End Function
    Public Overrides Function CMS_JobInvite_Get(PortalConnect As String, JobInvite_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobInvite_Get", JobInvite_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobInvite_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobInvite_List"), IDataReader)
    End Function
    Public Overrides Function CMS_JobInvite_List_ByIdKey(PortalConnect As String, idKey As String, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobInvite_List_ByIdKey", idKey, userName), IDataReader)
    End Function
    Public Overrides Function CMS_JobInvite_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobInvite_List_Search", search, isOrder, currPage, recodperpage, IsFlag, Business_ID, TypeOf_ID, Experience_ID, Salary_ID, Career_ID, tinhTP, quanHuyen), IDataReader)
    End Function
    Public Overrides Function CMS_JobInvite_List_Search_users(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, IsFlag As Integer, Business_ID As String, TypeOf_ID As String, Experience_ID As String, Salary_ID As String, Career_ID As String, tinhTP As String, quanHuyen As String, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobInvite_List_Search_users", search, isOrder, currPage, recodperpage, IsFlag, Business_ID, TypeOf_ID, Experience_ID, Salary_ID, Career_ID, tinhTP, quanHuyen, userName), IDataReader)
    End Function

    Public Overrides Sub CMS_JobInvite_Add(PortalConnect As String, JobInvite_ID As String, WorkID As String, JobID As String, BusID As String, UserName As String, createDate As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobInvite_Add", JobInvite_ID, WorkID, JobID, BusID, UserName, createDate)
    End Sub
    Public Overrides Sub CMS_JobInvite_Update(PortalConnect As String, JobInvite_ID As String, WorkID As String, JobID As String, BusID As String, UserName As String, createDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobInvite_Update", JobInvite_ID, WorkID, JobID, BusID, UserName, createDate)
    End Sub
    Public Overrides Sub CMS_JobInvite_Delete(PortalConnect As String, JobInvite_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobInvite_Delete", JobInvite_ID)
    End Sub
    Public Overrides Function CMS_JobInvite_Update_Status(PortalConnect As String, JobInvite_ID As String, IsStatus As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobInvite_Update_Status", JobInvite_ID, IsStatus), String)
    End Function
#End Region
#Region "CMS_DoanhNghiep"
    Public Overrides Function CMS_Work_List_By_PhienGD(PortalConnect As String, PhienGD_ID As String, Career_ID As String, Position_ID As String, Level_ID As String, IsOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_By_PhienGD", PhienGD_ID, Career_ID, Position_ID, Level_ID, IsOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_List_Home(PortalConnect As String, Career_ID As String, Search As String, IsOrder As Integer, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_List_Home", Career_ID, Search, IsOrder, PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_Get(PortalConnect As String, doanhNghiep_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_Get", doanhNghiep_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_List_Search", search, currPage, recodperpage, PhienGD_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_DoanhNghiep_Add(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_DoanhNghiep_Add", doanhNghiep_ID, phienGD_ID, business_ID, soBan, flReg.GetNull(gioBatDau), flReg.GetNull(gioKetThuc), tinhTrangThamGia, fileDinhKem, createdBy, userName, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_Update(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Update", doanhNghiep_ID, phienGD_ID, business_ID, soBan, flReg.GetNull(gioBatDau), flReg.GetNull(gioKetThuc), tinhTrangThamGia, fileDinhKem, createdBy, userName, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_Replace(PortalConnect As String, doanhNghiep_ID As String, phienGD_ID As String, business_ID As String, soBan As Integer, gioBatDau As DateTime, gioKetThuc As DateTime, tinhTrangThamGia As Integer, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Replace", doanhNghiep_ID, phienGD_ID, business_ID, soBan, flReg.GetNull(gioBatDau), flReg.GetNull(gioKetThuc), tinhTrangThamGia, fileDinhKem, createdBy, userName, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_Delete(PortalConnect As String, doanhNghiep_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Delete", doanhNghiep_ID)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_Update_Quick(PortalConnect As String, phienGD_ID As String, business_ID As String, soBan As Integer, tinhTrangThamGia As Integer, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Update_Quick", phienGD_ID, business_ID, soBan, tinhTrangThamGia, updatedBy, userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_Delete_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Delete_Business_ID", phienGD_ID, business_ID)
    End Sub
    Public Overrides Function CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect As String, phienGD_ID As String, business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_Get_By_Business_ID", phienGD_ID, business_ID), IDataReader)
    End Function
#End Region
#Region "CMS_DoanhNghiep_UngVien"
    Public Overrides Function CMS_Work_List_TuyenDungName(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, doanhnghiep_id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Work_List_TuyenDungName", phienGD_ID, UngViend_ID, doanhnghiep_id), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(PortalConnect As String, phienGD_ID As String, UngViend_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID", phienGD_ID, UngViend_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_TinhTrang(PortalConnect As String, PhienGiaoDich_ID As String, TuyenDung_ID As String, NguoiTimViec_ID As String, IsInvite As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_TinhTrang", PhienGiaoDich_ID, TuyenDung_ID, NguoiTimViec_ID, IsInvite), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_Business(PortalConnect As String, phienGD_ID As String, BusinessID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_Business", phienGD_ID, BusinessID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_Business_MoiUV(PortalConnect As String, phienGD_ID As String, BusinessID As String, IsStatus As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_Business_MoiUV", phienGD_ID, BusinessID, IsStatus), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien(PortalConnect As String, phienGD_ID As String, BusinessID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien", phienGD_ID, BusinessID), IDataReader)
    End Function

    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_PhienGD(PortalConnect As String, phienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_PhienGD", phienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get_By_UserName(PortalConnect As String, phienGD_ID As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get_By_UserName", phienGD_ID, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_Get(PortalConnect As String, dNUV_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Get", dNUV_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DoanhNghiep_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_DoanhNghiep_Update_KetQua(PortalConnect As String, dNUV_ID As String, ketQuaPhongVan As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_Update_KetQua", dNUV_ID, ketQuaPhongVan, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_Add(PortalConnect As String, dNUV_ID As String, DoanhNghiep_ID As String, phienGD_ID As String, ungVien_ID As String, banPhongVan As Integer, tinhTrangPhongVan As Integer, ketQuaPhongVan As Integer, chiTietPhongVan As String, thuTuPhongVan As Integer, tuyenDung_ID As String, tuyenDungName As String, viTriDat As String, viTriDatName As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Add", dNUV_ID, DoanhNghiep_ID, phienGD_ID, ungVien_ID, banPhongVan, tinhTrangPhongVan, ketQuaPhongVan, chiTietPhongVan, thuTuPhongVan, tuyenDung_ID, tuyenDungName, viTriDat, viTriDatName, createdBy, userName, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_Update(PortalConnect As String, dNUV_ID As String, DoanhNghiep_ID As String, phienGD_ID As String, ungVien_ID As String, banPhongVan As Integer, tinhTrangPhongVan As Integer, ketQuaPhongVan As Integer, chiTietPhongVan As String, thuTuPhongVan As Integer, tuyenDung_ID As String, tuyenDungName As String, viTriDat As String, viTriDatName As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Update", dNUV_ID, DoanhNghiep_ID, phienGD_ID, ungVien_ID, banPhongVan, tinhTrangPhongVan, ketQuaPhongVan, chiTietPhongVan, thuTuPhongVan, tuyenDung_ID, tuyenDungName, viTriDat, viTriDatName, createdBy, userName, flReg.GetNull(updatedBy), userUpdate)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_Update_Status(PortalConnect As String, DNUV_ID As String, IsStatus As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Update_Status", DNUV_ID, IsStatus)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_Delete(PortalConnect As String, dNUV_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Delete", dNUV_ID)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_RoiBan(PortalConnect As String, phienGD_ID As String, UngViend_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_RoiBan", phienGD_ID, UngViend_ID)
    End Sub
    Public Overrides Sub CMS_DoanhNghiep_UngVien_Update_DoanhNghiep(PortalConnect As String, phienGD_ID As String, UngViend_ID As String, DoanhNghiep_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DoanhNghiep_UngVien_Update_DoanhNghiep", phienGD_ID, UngViend_ID, DoanhNghiep_ID)
    End Sub
#End Region
#Region "CMS_PhienGiaoDich"
    Public Overrides Function CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat(PortalConnect As String, portalId As Integer) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat", portalId), String)
    End Function
    Public Overrides Function CMS_ThongKeBaoCao_SanVL(PortalConnect As String, phienGD_ID As String, Business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ThongKeBaoCao_SanVL", phienGD_ID, Business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_PhienGiaoDich_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_PhienGiaoDich_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_PhienGiaoDich_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_PhienGiaoDich_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_PhienGiaoDich_List_Search_Member(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_PhienGiaoDich_List_Search_Member", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_PhienGiaoDich_Get(PortalConnect As String, phienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_PhienGiaoDich_Get", phienGD_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_PhienGiaoDich_Add(PortalConnect As String, phienGD_ID As String, tenPhien As String, TinhTP As String, diaDiem As String, thoiGian_BatDau As DateTime, thoiGian_KetThuc As DateTime, isActive As Boolean, loaiPhien As Integer, hotline As String, email As String, moTa As String, ketQua As String, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String, portalId As Integer)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_PhienGiaoDich_Add", phienGD_ID, tenPhien, TinhTP, diaDiem, thoiGian_BatDau, thoiGian_KetThuc, isActive, loaiPhien, hotline, email, moTa, ketQua, fileDinhKem, createdBy, userName, flReg.GetNull(updatedBy), userUpdate, portalId)
    End Sub
    Public Overrides Sub CMS_PhienGiaoDich_Update(PortalConnect As String, phienGD_ID As String, tenPhien As String, TinhTP As String, diaDiem As String, thoiGian_BatDau As DateTime, thoiGian_KetThuc As DateTime, isActive As Boolean, loaiPhien As Integer, hotline As String, email As String, moTa As String, ketQua As String, fileDinhKem As String, createdBy As DateTime, userName As String, updatedBy As DateTime, userUpdate As String, portalId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_PhienGiaoDich_Update", phienGD_ID, tenPhien, TinhTP, diaDiem, thoiGian_BatDau, thoiGian_KetThuc, isActive, loaiPhien, hotline, email, moTa, ketQua, fileDinhKem, createdBy, userName, flReg.GetNull(updatedBy), userUpdate, portalId)
    End Sub
    Public Overrides Sub CMS_PhienGiaoDich_Delete(PortalConnect As String, phienGD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_PhienGiaoDich_Delete", phienGD_ID)
    End Sub
#End Region
#Region "CMS_TuyenDung"
    Public Overrides Function CMS_TuyenDung_List_By_PhienGD(PortalConnect As String, phienGD_ID As String, Business_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_List_By_PhienGD", phienGD_ID, Business_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TuyenDung_Get_ByWork(PortalConnect As String, doanhNghiep_ID As String, work_ID As String, phienGDID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_Get_ByWork", doanhNghiep_ID, work_ID, phienGDID), IDataReader)
    End Function
    Public Overrides Function CMS_TuyenDung_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_TuyenDung_Get_By_UserName", work_ID, doanhNghiep_ID, UserName), String)
    End Function
    Public Overrides Function CMS_TuyenDung_Get(PortalConnect As String, tuyenDung_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_Get", tuyenDung_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TuyenDung_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TuyenDung_List_Search(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_List_Search", search, PhienGD_ID, Business_ID, IsFlag), IDataReader)
    End Function
    Public Overrides Function CMS_TuyenDung_List_Search_VL(PortalConnect As String, search As String, PhienGD_ID As String, Business_ID As String, IsFlag As Integer, IsApproval As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TuyenDung_List_Search_VL", search, PhienGD_ID, Business_ID, IsFlag, IsApproval), IDataReader)
    End Function
    Public Overrides Function CMS_Job_ID_Member(PortalConnect As String, UngVien_ID As String, Work_ID As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Job_ID_Member", UngVien_ID, Work_ID), String)
    End Function

    Public Overrides Sub CMS_TuyenDung_Add(PortalConnect As String, tuyenDung_ID As String, doanhNghiep_ID As String, work_ID As String, phienGD_ID As String, createdBy As DateTime, userName As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_TuyenDung_Add", tuyenDung_ID, doanhNghiep_ID, work_ID, phienGD_ID, createdBy, userName)
    End Sub
    Public Overrides Sub CMS_TuyenDung_Update(PortalConnect As String, tuyenDung_ID As String, doanhNghiep_ID As String, work_ID As String, phienGD_ID As String, createdBy As DateTime, userName As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_TuyenDung_Update", tuyenDung_ID, doanhNghiep_ID, work_ID, phienGD_ID, createdBy, userName)
    End Sub
    Public Overrides Sub CMS_TuyenDung_Delete(PortalConnect As String, tuyenDung_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_TuyenDung_Delete", tuyenDung_ID)
    End Sub
#End Region
#Region "CMS_UngVien"
    Public Overrides Function CMS_UngVien_CheckByUserName(PortalConnect As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_CheckByUserName", UserName), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_Get_By_UserName(PortalConnect As String, UserName As String, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_Get_By_UserName", UserName, PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_Get(PortalConnect As String, ungVien_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_Get", ungVien_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_List"), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_List_PhienGD_ID(PortalConnect As String, PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_List_PhienGD_ID", PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UngVien_Get_PhienGD_ID(PortalConnect As String, PhienGD_ID As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UngVien_Get_PhienGD_ID", PhienGD_ID, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_UngVien_Add(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_UngVien_Add", ungVien_ID, nguoiTimViec_ID, loaiUngVien, tenDayDu, flReg.GetNull(ngaySinh), flReg.GetNull(gioiTinh), diaChi, email, tel, nganhNghe, trinhDoChuyenMon, namKinhNghiem, viTriUngTuyen, nhuCauLamViec, phienGD_ID, createdBy)
    End Sub
    Public Overrides Sub CMS_UngVien_Update(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_UngVien_Update", ungVien_ID, nguoiTimViec_ID, loaiUngVien, tenDayDu, flReg.GetNull(ngaySinh), flReg.GetNull(gioiTinh), diaChi, email, tel, nganhNghe, trinhDoChuyenMon, namKinhNghiem, viTriUngTuyen, nhuCauLamViec, phienGD_ID, createdBy)
    End Sub
    Public Overrides Sub CMS_UngVien_Replace(PortalConnect As String, ungVien_ID As String, nguoiTimViec_ID As String, loaiUngVien As Integer, tenDayDu As String, ngaySinh As DateTime, gioiTinh As Integer, diaChi As String, email As String, tel As String, nganhNghe As String, trinhDoChuyenMon As String, namKinhNghiem As String, viTriUngTuyen As String, nhuCauLamViec As String, phienGD_ID As String, createdBy As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_UngVien_Replace", ungVien_ID, nguoiTimViec_ID, loaiUngVien, tenDayDu, flReg.GetNull(ngaySinh), flReg.GetNull(gioiTinh), diaChi, email, tel, nganhNghe, trinhDoChuyenMon, namKinhNghiem, viTriUngTuyen, nhuCauLamViec, phienGD_ID, createdBy)
    End Sub
    Public Overrides Sub CMS_UngVien_Delete(PortalConnect As String, ungVien_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_UngVien_Delete", ungVien_ID)
    End Sub
#End Region
#Region "CMS_UserWork"
    Public Overrides Function CMS_UserWork_Check(PortalConnect As String, UngVienID As String, WorkID As String) As Boolean
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_UserWork_Check", UngVienID, WorkID)
    End Function
    Public Overrides Function CMS_UserWork_Get(PortalConnect As String, userWork_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UserWork_Get", userWork_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UserWork_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UserWork_List"), IDataReader)
    End Function
    Public Overrides Function CMS_UserWork_List_Search(PortalConnect As String, work_ID As String, doanhNghiep_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_UserWork_List_Search", work_ID, doanhNghiep_ID), IDataReader)
    End Function
    Public Overrides Function CMS_UserWork_Get_By_UserName(PortalConnect As String, work_ID As String, doanhNghiep_ID As String, UserName As String) As String
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_UserWork_Get_By_UserName", work_ID, doanhNghiep_ID, UserName), String)
    End Function

    Public Overrides Sub CMS_UserWork_Add(PortalConnect As String, userWork_ID As String, ungVien_ID As String, work_ID As String, Job_ID As String, doanhNghiep_ID As String, createdBy As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_UserWork_Add", userWork_ID, ungVien_ID, work_ID, Job_ID, doanhNghiep_ID, createdBy)
    End Sub
    Public Overrides Sub CMS_UserWork_Update(PortalConnect As String, userWork_ID As String, ungVien_ID As String, work_ID As String, doanhNghiep_ID As String, createdBy As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_UserWork_Update", userWork_ID, ungVien_ID, work_ID, doanhNghiep_ID, createdBy)
    End Sub
    Public Overrides Sub CMS_UserWork_Delete(PortalConnect As String, userWork_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_UserWork_Delete", userWork_ID)
    End Sub
#End Region
#Region "CMS_RegEmail"
    Public Overrides Sub CMS_RegEmail_Add(PortalConnect As String, RegEmail_ID As String, RegEmail As String, RegDate As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_RegEmail_Add", RegEmail_ID, RegEmail, RegDate)
    End Sub
    Public Overrides Function CMS_RegEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RegEmail_List", currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_ConEmail_Add(PortalConnect As String, ConEmail_ID As String, SendDate As DateTime, Contents As String, UserName As String)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_ConEmail_Add", ConEmail_ID, SendDate, Contents, UserName)
    End Sub
    Public Overrides Function CMS_ConEmail_List(PortalConnect As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ConEmail_List", currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_Career"
    Public Overrides Function CMS_Career_List_Home(PortalConnect As String, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_List_Home", top), IDataReader)
    End Function
    Public Overrides Function CMS_Career_List_Job(PortalConnect As String, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_List_Job", top), IDataReader)
    End Function
    Public Overrides Function CMS_Career_Get_ID(PortalConnect As String, ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_Get_ID", ID), IDataReader)
    End Function
    Public Overrides Function CMS_Career_Get(PortalConnect As String, career_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_Get", career_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Career_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_List"), IDataReader)
    End Function
    Public Overrides Function SV_Career_Get_By_IdKey(PortalConnect As String, career_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Career_Get_By_IdKey", career_Code)
    End Function
    Public Overrides Function CMS_Career_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Career_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Career_Add", obj.Career_ID, obj.Career_Name, obj.Career_Code, obj.Career_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub SV_Career_Add(PortalConnect As String, obj As CMS_CareerInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Career_Add", obj.Career_ID, obj.Career_Name, obj.Career_Code, obj.Career_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.ID)
    End Sub
    Public Overrides Sub CMS_Career_Update(PortalConnect As String, obj As CMS_CareerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Career_Update", obj.Career_ID, obj.Career_Name, obj.Career_Code, obj.Career_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Career_Delete(PortalConnect As String, career_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Career_Delete", career_ID)
    End Sub
#End Region
#Region "CMS_Experience"
    Public Overrides Function CMS_Experience_Get(PortalConnect As String, experience_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Experience_Get", experience_ID), IDataReader)
    End Function
    Public Overrides Function SV_Experience_Get_By_IdKey(PortalConnect As String, experienceCode As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Experience_Get_By_IdKey", experienceCode)
    End Function
    Public Overrides Function CMS_Experience_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Experience_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Experience_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Experience_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Experience_Add", obj.Experience_ID, obj.Experience_Name, obj.Experience_Code, obj.Experience_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub SV_Experience_Add(PortalConnect As String, obj As CMS_ExperienceInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Experience_Add", obj.Experience_ID, obj.Experience_Name, obj.Experience_Code, obj.Experience_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.IdSend)
    End Sub
    Public Overrides Sub CMS_Experience_Update(PortalConnect As String, obj As CMS_ExperienceInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Experience_Update", obj.Experience_ID, obj.Experience_Name, obj.Experience_Code, obj.Experience_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Experience_Delete(PortalConnect As String, experience_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Experience_Delete", experience_ID)
    End Sub
#End Region
#Region "CMS_JobPlace"
    Public Overrides Function CMS_JobPlace_Get(PortalConnect As String, jobPlace_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_Get", jobPlace_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobPlace_Get_Code(PortalConnect As String, jobPlace_Code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_Get", jobPlace_Code), IDataReader)
    End Function
    Public Overrides Function CMS_JobPlace_Get_Parents(PortalConnect As String, parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_Get_Code", parent_ID), IDataReader)
    End Function
    Public Overrides Function SV_JobPlace_Get_By_IdKey(PortalConnect As String, jobPlace_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_JobPlace_Get_By_IdKey", jobPlace_Code)
    End Function
    Public Overrides Function CMS_JobPlace_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_List"), IDataReader)
    End Function
    Public Overrides Function CMS_JobPlace_List_parent(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_List_parent"), IDataReader)
    End Function
    Public Overrides Function CMS_JobPlace_List_parent_ID(PortalConnect As String, parent_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_List_parent_ID", parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobPlace_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobPlace_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_JobPlace_Add(PortalConnect As String, obj As CMS_JobPlaceInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobPlace_Add", obj.JobPlace_ID, obj.Parent_ID, obj.JobPlace_Name, obj.JobPlace_Code, obj.JobPlace_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_JobPlace_Update(PortalConnect As String, obj As CMS_JobPlaceInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobPlace_Update", obj.JobPlace_ID, obj.Parent_ID, obj.JobPlace_Name, obj.JobPlace_Code, obj.JobPlace_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_JobPlace_Delete(PortalConnect As String, jobPlace_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobPlace_Delete", jobPlace_ID)
    End Sub
#End Region
#Region "CMS_Needs"
    Public Overrides Function CMS_Needs_Get(PortalConnect As String, needs_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Needs_Get", needs_ID), IDataReader)
    End Function
    Public Overrides Function SV_Needs_Get_By_IdKey(PortalConnect As String, needs_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Needs_Get_By_IdKey", needs_Code)
    End Function
    Public Overrides Function CMS_Needs_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Needs_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Needs_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Needs_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Needs_Add", obj.Needs_ID, obj.Needs_Name, obj.Needs_Code, obj.Needs_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub SV_Needs_Add(PortalConnect As String, obj As CMS_NeedsInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Needs_Add", obj.Needs_ID, obj.Needs_Name, obj.Needs_Code, obj.Needs_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.IdSend)
    End Sub
    Public Overrides Sub CMS_Needs_Update(PortalConnect As String, obj As CMS_NeedsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Needs_Update", obj.Needs_ID, obj.Needs_Name, obj.Needs_Code, obj.Needs_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Needs_Delete(PortalConnect As String, needs_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Needs_Delete", needs_ID)
    End Sub
#End Region
#Region "CMS_TypeOf"
    Public Overrides Function CMS_TypeOf_Get(PortalConnect As String, typeOf_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TypeOf_Get", typeOf_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeOf_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TypeOf_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TypeOf_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_TypeOf_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_TypeOf_Add", obj.TypeOf_ID, obj.TypeOf_Name, obj.TypeOf_Code, obj.TypeOf_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub SV_TypeOf_Add(PortalConnect As String, obj As CMS_TypeOfInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_TypeOf_Add", obj.TypeOf_ID, obj.TypeOf_Name, obj.TypeOf_Code, obj.TypeOf_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.IdSend)
    End Sub
    Public Overrides Sub CMS_TypeOf_Update(PortalConnect As String, obj As CMS_TypeOfInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_TypeOf_Update", obj.TypeOf_ID, obj.TypeOf_Name, obj.TypeOf_Code, obj.TypeOf_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_TypeOf_Delete(PortalConnect As String, typeOf_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_TypeOf_Delete", typeOf_ID)
    End Sub
    Public Overrides Function SV_TypeOf_Get_By_IdKey(PortalConnect As String, typeOf_Code As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_TypeOf_Get_By_IdKey", typeOf_Code)
    End Function
#End Region
#Region "CMS_Salary"
    Public Overrides Function CMS_Salary_Get(PortalConnect As String, salary_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Salary_Get", salary_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Salary_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Salary_List"), IDataReader)
    End Function
    Public Overrides Function SV_Salary_Get_By_IdKey(PortalConnect As String, salaryCode As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Salary_Get_By_IdKey", salaryCode)
    End Function
    Public Overrides Function CMS_Salary_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Salary_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub CMS_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Salary_Add", obj.Salary_ID, obj.Salary_Name, obj.Salary_Code, obj.Salary_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub SV_Salary_Add(PortalConnect As String, obj As CMS_SalaryInfo)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SV_Salary_Add", obj.Salary_ID, obj.Salary_Name, obj.Salary_Code, obj.Salary_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate, obj.IdSend)
    End Sub
    Public Overrides Sub CMS_Salary_Update(PortalConnect As String, obj As CMS_SalaryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Salary_Update", obj.Salary_ID, obj.Salary_Name, obj.Salary_Code, obj.Salary_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Salary_Delete(PortalConnect As String, salary_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Salary_Delete", salary_ID)
    End Sub
#End Region
#Region "RPT"
    Public Overrides Function CMS_RPT_JobSeeker(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_JobSeeker", tinhTP, quanHuyen, FromDate, ToDate, Car, Sal), IDataReader)
    End Function
    Public Overrides Function CMS_RPT_Employer(PortalConnect As String, tinhTP As String, quanHuyen As String, FromDate As DateTime, ToDate As DateTime, Car As String, Sal As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_Employer", tinhTP, quanHuyen, FromDate, ToDate, Car, Sal), IDataReader)
    End Function
    Public Overrides Function CMS_RPT_SanVL2(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_SanVL2", FromDate, ToDate), IDataReader)
    End Function
    Public Overrides Function CMS_RPT_SanVL1(PortalConnect As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_RPT_SanVL1", FromDate, ToDate), IDataReader)
    End Function
    Public Overrides Function CMS_EventLog_List_By_MonthYear(PortalConnect As String, logMonth As Integer, logYear As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_EventLog_List_By_MonthYear", logMonth, logYear, portalID), IDataReader)
    End Function
#End Region
#Region "RPT_Data"
    Public Overrides Function RPT_Data_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Data_Get", iD), IDataReader)
    End Function
    Public Overrides Function RPT_Data_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Data_List"), IDataReader)
    End Function

    Public Overrides Function RPT_Data_Add(PortalConnect As String, rpt_ID As Integer, cot_ID As Integer, dong_ID As Integer, giaTri As String, isOrder As Integer, isFlag As Integer, IsCenter As Boolean) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "RPT_Data_Add", rpt_ID, cot_ID, dong_ID, giaTri, isOrder, isFlag, IsCenter), Integer)
    End Function
    Public Overrides Sub RPT_Data_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, cot_ID As Integer, dong_ID As Integer, giaTri As String, isOrder As Integer, isFlag As Integer, IsCenter As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Data_Update", iD, rpt_ID, cot_ID, dong_ID, giaTri, isOrder, isFlag, IsCenter)
    End Sub
    Public Overrides Function RPT_Data_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Data_Get_By_RPT_Reports", rpt_ID), IDataReader)
    End Function
    Public Overrides Sub RPT_Data_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Data_Delete_By_RPT_Reports", rpt_ID)
    End Sub
    Public Overrides Sub RPT_Data_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Data_Delete", iD)
    End Sub
#End Region
#Region "RPT_Label"
    Public Overrides Function RPT_Label_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Label_Get", iD), IDataReader)
    End Function
    Public Overrides Function RPT_Label_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Label_List"), IDataReader)
    End Function

    Public Overrides Function RPT_Label_Add(PortalConnect As String, rpt_ID As Integer, cot_ID As Integer, tieuDe As String, rowspan As Integer, colspan As Integer, isOrder As Integer, isRows As Integer, IsColumn As Integer, width As String, IsData As Boolean, IsFlag As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "RPT_Label_Add", rpt_ID, cot_ID, tieuDe, rowspan, colspan, isOrder, isRows, IsColumn, width, IsData, IsFlag), Integer)
    End Function
    Public Overrides Sub RPT_Label_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, cot_ID As Integer, tieuDe As String, rowspan As Integer, colspan As Integer, isOrder As Integer, isRows As Integer, IsColumn As Integer, width As String, IsData As Boolean, IsFlag As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Label_Update", iD, rpt_ID, cot_ID, tieuDe, rowspan, colspan, isOrder, isRows, IsColumn, width, IsData, IsFlag)
    End Sub
    Public Overrides Function RPT_Label_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer, isRows As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Label_Get_By_RPT_Reports", rpt_ID, isRows), IDataReader)
    End Function
    Public Overrides Sub RPT_Label_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Label_Delete", iD)
    End Sub
    Public Overrides Sub RPT_Label_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Label_Delete_By_RPT_Reports", rpt_ID)
    End Sub
#End Region
#Region "RPT_Reports"
    Public Overrides Function RPT_Reports_Get_Rpt(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Reports_Get_Rpt", tinhTP, quanHuyen, xaPhuong, thonTo, namBC), IDataReader)
    End Function
    Public Overrides Function RPT_Reports_Get(PortalConnect As String, rpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Reports_Get", rpt_ID), IDataReader)
    End Function
    Public Overrides Function RPT_Reports_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Reports_List"), IDataReader)
    End Function

    Public Overrides Function RPT_Reports_Add(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer, Other As String, Rpt_Type As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "RPT_Reports_Add", tinhTP, quanHuyen, xaPhuong, thonTo, namBC, Other, Rpt_Type), Integer)
    End Function
    Public Overrides Sub RPT_Reports_Update(PortalConnect As String, rpt_ID As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, thonTo As Integer, namBC As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Reports_Update", rpt_ID, tinhTP, quanHuyen, xaPhuong, thonTo, namBC)
    End Sub
    Public Overrides Sub RPT_Reports_Delete(PortalConnect As String, rpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Reports_Delete", rpt_ID)
    End Sub
#End Region
#Region "RPT_Rows"
    Public Overrides Function RPT_Rows_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Rows_Get", iD), IDataReader)
    End Function
    Public Overrides Function RPT_Rows_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Rows_List"), IDataReader)
    End Function
    Public Overrides Function RPT_Rows_Add(PortalConnect As String, rpt_ID As Integer, STT As String, dong_ID As Integer, tieuDe As String, isOrder As Integer, IsBold As Boolean, IsFlag As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "RPT_Rows_Add", rpt_ID, STT, dong_ID, tieuDe, isOrder, IsBold, IsFlag), Integer)
    End Function
    Public Overrides Sub RPT_Rows_Update(PortalConnect As String, iD As Integer, rpt_ID As Integer, dong_ID As Integer, tieuDe As String, isOrder As Integer, IsBold As Boolean, IsFlag As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Rows_Update", iD, rpt_ID, dong_ID, tieuDe, isOrder, IsBold, IsFlag)
    End Sub
    Public Overrides Function RPT_Rows_Get_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "RPT_Rows_Get_By_RPT_Reports", rpt_ID), IDataReader)
    End Function
    Public Overrides Sub RPT_Rows_Delete_By_RPT_Reports(PortalConnect As String, rpt_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Rows_Delete_By_RPT_Reports", rpt_ID)
    End Sub
    Public Overrides Sub RPT_Rows_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "RPT_Rows_Delete", iD)
    End Sub
#End Region
#Region "CMS_DashBoard"
    Public Overrides Function CMS_DashBoard_Admin_6Thang(PortalConnect As String, Num1 As Date, Num2 As Date, Num3 As Date, Num4 As Date, Num5 As Date, Num6 As Date) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_Admin_6Thang", Num1, Num2, Num3, Num4, Num5, Num6), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_User(PortalConnect As String, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_User", userName), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_Admin", year), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_Business(PortalConnect As String, userName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_Business", userName), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_Business_Moi(PortalConnect As String, BusID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_Business_Moi", BusID), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_User_ListJob(PortalConnect As String, userName As String, career_id As String, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_User_ListJob", userName, career_id, top), IDataReader)
    End Function
    Public Overrides Function CMS_DashBoard_Business_ListJob(PortalConnect As String, Business_ID As String, top As Integer, CareerID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DashBoard_Business_ListJob", Business_ID, top, CareerID), IDataReader)
    End Function
#End Region
#Region "CMS_WorkCareer"
    Public Overrides Function CMS_WorkCareer_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkCareer_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_WorkCareer_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkCareer_List"), IDataReader)
    End Function
    Public Overrides Function CMS_WorkCareer_Add(PortalConnect As String, obj As CMS_WorkCareerInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_WorkCareer_Add", obj.Work_ID, obj.Career_ID), Integer)
    End Function
    Public Overrides Sub CMS_WorkCareer_Update(PortalConnect As String, obj As CMS_WorkCareerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkCareer_Update", obj.ID, obj.Work_ID, obj.Career_ID)
    End Sub
    Public Overrides Function CMS_WorkCareer_Get_By_CMS_Work(PortalConnect As String, work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkCareer_Get_By_CMS_Work", work_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_WorkCareer_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkCareer_Delete", iD)
    End Sub
    Public Overrides Sub CMS_WorkCareer_Delete_By_CMS_Work(PortalConnect As String, work_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkCareer_Delete_By_CMS_Work", work_ID)
    End Sub
#End Region
#Region "CMS_Search"
    Public Overrides Function CMS_Search_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Search_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Search_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_Search_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Search_Add(PortalConnect As String, obj As CMS_SearchInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_Search_Add", flReg.GetNull(obj.TuKhoa), obj.TinhTP, flReg.GetNull(obj.NganhNghe), flReg.GetNull(obj.ViTri), flReg.GetNull(obj.MucLuong), flReg.GetNull(obj.TrinhDo), flReg.GetNull(obj.KinhNghiem), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.ChucVu)), Integer)
    End Function
    Public Overrides Sub CMS_Search_Update(PortalConnect As String, obj As CMS_SearchInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Search_Update", obj.ID, flReg.GetNull(obj.TuKhoa), obj.TinhTP, flReg.GetNull(obj.NganhNghe), flReg.GetNull(obj.ViTri), flReg.GetNull(obj.MucLuong), flReg.GetNull(obj.TrinhDo), flReg.GetNull(obj.KinhNghiem), flReg.GetNull(obj.GioiTinh), flReg.GetNull(obj.ChucVu))
    End Sub
    Public Overrides Sub CMS_Search_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_Search_Delete", iD)
    End Sub
#End Region
#Region "CMS_EventLog"
    Public Overrides Function CMS_EventLog_Get(PortalConnect As String, evenLog_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_EventLog_Get", evenLog_ID), IDataReader)
    End Function
    Public Overrides Function CMS_EventLog_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_EventLog_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_EventLog_Add(PortalConnect As String, obj As CMS_EventLogInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_EventLog_Add", obj.LogDay, obj.LogMonth, obj.LogYear, obj.LogView, obj.PortalID), Integer)
    End Function
    Public Overrides Sub CMS_EventLog_Update(PortalConnect As String, obj As CMS_EventLogInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_EventLog_Update", obj.EvenLog_ID, obj.LogDay, obj.LogMonth, obj.LogYear, obj.LogView, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_EventLog_Delete(PortalConnect As String, evenLog_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_EventLog_Delete", evenLog_ID)
    End Sub
#End Region
#Region "CMS_SystemStatistic"

    Public Overrides Function CMS_System_Statistic(PortalConnect As String, tinhTP As Integer, fromDate As DateTime, toDate As DateTime, isTotal As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_System_Statistic", PortalConnect, tinhTP, fromDate, toDate, isTotal), IDataReader)
    End Function
#End Region
#Region "CMS_NewsFeedback"
    Public Overrides Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, ItemId As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_NewsFeedback_List_By_NewsID", ItemId, Status, type, PortalId, LanguageId, PageIndex, PageSize)
    End Function
    Public Overrides Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_NewsFeedback_Get", newsFeedbackId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_NewsFeedback_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_NewsFeedback_Update_Status", newsFeedbackId, status)
    End Sub
    Public Overrides Function CMS_NewsFeedback_List_Search(PortalConnect As String, ItemId As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_NewsFeedback_List_Search", ItemId, Status, type, PortalId, LanguageId, PageIndex, PageSize)
    End Function
    Public Overrides Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, idFeed As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_NewsFeedback_Get_By_FBID", idFeed), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_NewsFeedback_Add", flReg.GetNull(obj.ItemId), flReg.GetNull(obj.FullName), flReg.GetNull(obj.Email), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PhoneNumber), flReg.GetNull(obj.Title), flReg.GetNull(obj.Content), flReg.GetNull(obj.Address), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Status), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.Type), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IsLike), flReg.GetNull(obj.DisLike), flReg.GetNull(obj.ParentID), flReg.GetNull(obj.IsRead), flReg.GetNull(obj.UserRead), flReg.GetNull(obj.DateRead), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.UserPublic), flReg.GetNull(obj.DatePublic), obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_NewsFeedback_Update", obj.NewsFeedbackId, flReg.GetNull(obj.ItemId), flReg.GetNull(obj.FullName), flReg.GetNull(obj.Email), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PhoneNumber), flReg.GetNull(obj.Title), flReg.GetNull(obj.Content), flReg.GetNull(obj.Address), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Status), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.Type), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IsLike), flReg.GetNull(obj.DisLike), flReg.GetNull(obj.ParentID), flReg.GetNull(obj.IsRead), flReg.GetNull(obj.UserRead), flReg.GetNull(obj.DateRead), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.UserPublic), flReg.GetNull(obj.DatePublic), obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_NewsFeedback_Delete", newsFeedbackId)
    End Sub
#End Region
#Region "CMS_NewsFeedBack_History"
    Public Overrides Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_NewsFeedBack_History_Add", obj.NewFB_ID, obj.Contents, obj.UserName, obj.CreateDate), Integer)
    End Function
#End Region
#Region "CMS_SendMail"
    Public Overrides Sub CMS_SendMail_Add(PortalConnect As String, DoanhNghiep_ID As String, PhienGD_ID As String, NgayGui As DateTime)
        SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_SendMail_Add", DoanhNghiep_ID, PhienGD_ID, NgayGui)
    End Sub
#End Region
#Region "CMS_GTVL"
    Public Overrides Function CMS_GTVL_Add(PortalConnect As String, obj As CMS_GTVLInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_GTVL_Add", obj.Work_ID, obj.JobUser_ID, obj.CreatedDate, obj.CreatedUser), Integer)
    End Function
    Public Overrides Function CMS_GTVL_List(PortalConnect As String, search As String, fullText As String, currPage As Integer, recodperpage As Integer, Gender As String, Business_ID As String, Experience_ID As String, tinhTP As String, quanHuyen As String, Salary_ID As String, Career_ID As String, Status As Integer, Work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_GTVL_List", search, fullText, currPage, recodperpage, Gender, Business_ID, Experience_ID, tinhTP, quanHuyen, Salary_ID, Career_ID, Status, Work_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_GTVL_Update_Quick(PortalConnect As String, ID As Integer, isView As Boolean, isContact As Boolean, isInterview As Boolean, isTest As Boolean, isElect As Boolean, isCancel As Boolean, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_GTVL_Update_Quick", ID, isView, isContact, isInterview, isTest, isElect, isCancel, updatedDate, updatedUser)
    End Sub
    Public Overrides Sub CMS_GTVL_Update_Acess(PortalConnect As String, ID As Integer, isval As Boolean, isflag As Integer, updatedDate As DateTime, updatedUser As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_GTVL_Update_Acess", ID, isval, isflag, updatedDate, updatedUser)
    End Sub
#End Region
#Region "BHTN"
    Public Overrides Function Off_Count_Hosodangky(PortalConnect As String, portalID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flReg.WebConfig("BHTNConnect"), "Off_Count_Hosodangky", portalID), Integer)
    End Function
    Public Overrides Function CMS_JobUserBHTN_List_Search(ByVal Keyword As String, ByVal Trinhdo As Integer, ByVal Vitri As Integer, ByVal Mucluong As Integer, ByVal Nganhnghe As Integer, ByVal portalID As Integer, ByVal fromRow As Integer, ByVal toRow As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flReg.WebConfig("BHTNConnect"), "Off_Getall_Hosodangky_ChuyenTuvan", Keyword, Trinhdo, Vitri, Mucluong, Nganhnghe, portalID, fromRow, toRow), IDataReader)
    End Function
    Public Overrides Function Off_GTVL_TrinhDoDaoTao_GetAll(ByVal idHoSo As Guid) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flReg.WebConfig("BHTNConnect"), "Off_GTVL_TrinhDoDaoTao_GetAll", idHoSo), IDataReader)
    End Function
    Public Overrides Function Off_GTVL_QuaTrinhLamViec_GetAll(ByVal idHoSo As Guid) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flReg.WebConfig("BHTNConnect"), "Off_GTVL_QuaTrinhLamViec_GetAll", idHoSo), IDataReader)
    End Function
    Public Overrides Function DanhMucChungBHTN_List(ByVal loai As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flReg.WebConfig("BHTNDanhMuc"), "Off_DanhMuc_GetAll", loai, False), IDataReader)
    End Function
    Public Overrides Function GetHoSoBHTN(ByVal portalBHTN As Integer, ByVal sosoBHXH As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flReg.WebConfig("BHTNConnect"), "Off_GetAll_Nguoilaodong_BHTN_ByID", sosoBHXH, portalBHTN), IDataReader)
    End Function

#End Region
#Region "ND23_PLI"
    Public Overrides Function ND23_PLI_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLI_Get", iD), IDataReader)
    End Function
    Public Overrides Function ND23_PLI_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLI_List"), IDataReader)
    End Function
    Public Overrides Function ND23_PLI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLI_List_Search", search, isOrder, currPage, recodperpage, UserName, YearID), IDataReader)
    End Function

    Public Overrides Function ND23_PLI_Add(PortalConnect As String, obj As ND23_PLIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "ND23_PLI_Add", obj.Code, obj.HoTen, obj.CMND, obj.SoBHXH, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.TonGiao, obj.MaTinh_TT, obj.MaHuyen_TT, obj.MaXa_TT, obj.DiaChi_TT, obj.MaTinh_HN, obj.MaHuyen_HN, obj.MaXa_HN, obj.DiaChi_HN, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DTUT_NKT, obj.DTUT_DTTS, obj.DTUT_HN, obj.DTUT_BODOI, obj.DTUT_KHAC, obj.DTUT_KHAC_TEXT, obj.TDHV_CTH, obj.TDHV_TH, obj.TDHV_THCS, obj.TDHV_THPT, obj.TDCM_CQDT, obj.TDCM_CNKTKB, obj.TDCM_SOCAP, obj.TDCM_TRUNGCAP, obj.TDCM_CAODANG, obj.TDCM_DH, obj.TDCM_THS, obj.TDCM_TS, obj.TDCM_KHAC, obj.TDCMK_CQDT, obj.TDCMK_CNKTKB, obj.TDCMK_SOCAP, obj.TDCMK_TRUNGCAP, obj.TDCMK_CAODANG, obj.TDCMK_DH, obj.TDCMK_THS, obj.TDCMK_TS1, obj.TDCMK_KHAC, obj.TDCM_KHAC1, obj.TDCM_KHAC2, obj.TDKNN, obj.BAC_NGHE, obj.TDNN1, obj.TDNN1_CC, obj.TDNN1_MUCDO, obj.TDNN2, obj.TDNN2_CC, obj.TDNN2_MUCDO, obj.TDTH, obj.TDTH_CC, obj.TDTH_MUCDO, obj.TDTHK, obj.TDTHK_CC, obj.TDTHK_MUCDO, obj.KNM_GT, obj.KNM_TT, obj.KNM_QLTG, obj.KNM_QLNS, obj.KNM_THBC, obj.KNM_THICHUNG, obj.KNM_LVNHOM, obj.KNM_LVDOCLAP, obj.KNM_CHIUAPLUC, obj.KNM_THEODOI, obj.KNM_TUDUYPB, obj.KNM_KHAC, obj.KNM_KHAC_TEXT, obj.KNLV1_TENDV, obj.KNLV1_CHUCVU, obj.KNLV1_CV, obj.KNLV1_TG, obj.KNLV2_TENDV, obj.KNLV2_CHUCVU, obj.KNLV2_CV, obj.KNLV2_TG, obj.KNLV3_TENDV, obj.KNLV3_CHUCVU, obj.KNLV3_CV, obj.KNLV3_TG, obj.LVNN, obj.LVNN_TEXT, obj.DKDV_CSPL, obj.DKDV_TVVL, obj.DKDV_TVDTN, obj.DKDV_TVL, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId), Integer)
    End Function
    Public Overrides Sub ND23_PLI_Update(PortalConnect As String, obj As ND23_PLIInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLI_Update", obj.ID, obj.Code, obj.HoTen, obj.CMND, obj.SoBHXH, obj.NgaySinh, obj.GioiTinh, obj.DanToc, obj.TonGiao, obj.MaTinh_TT, obj.MaHuyen_TT, obj.MaXa_TT, obj.DiaChi_TT, obj.MaTinh_HN, obj.MaHuyen_HN, obj.MaXa_HN, obj.DiaChi_HN, obj.SoDienThoai, obj.Email, obj.LienHeKhac, obj.DTUT_NKT, obj.DTUT_DTTS, obj.DTUT_HN, obj.DTUT_BODOI, obj.DTUT_KHAC, obj.DTUT_KHAC_TEXT, obj.TDHV_CTH, obj.TDHV_TH, obj.TDHV_THCS, obj.TDHV_THPT, obj.TDCM_CQDT, obj.TDCM_CNKTKB, obj.TDCM_SOCAP, obj.TDCM_TRUNGCAP, obj.TDCM_CAODANG, obj.TDCM_DH, obj.TDCM_THS, obj.TDCM_TS, obj.TDCM_KHAC, obj.TDCMK_CQDT, obj.TDCMK_CNKTKB, obj.TDCMK_SOCAP, obj.TDCMK_TRUNGCAP, obj.TDCMK_CAODANG, obj.TDCMK_DH, obj.TDCMK_THS, obj.TDCMK_TS1, obj.TDCMK_KHAC, obj.TDCM_KHAC1, obj.TDCM_KHAC2, obj.TDKNN, obj.BAC_NGHE, obj.TDNN1, obj.TDNN1_CC, obj.TDNN1_MUCDO, obj.TDNN2, obj.TDNN2_CC, obj.TDNN2_MUCDO, obj.TDTH, obj.TDTH_CC, obj.TDTH_MUCDO, obj.TDTHK, obj.TDTHK_CC, obj.TDTHK_MUCDO, obj.KNM_GT, obj.KNM_TT, obj.KNM_QLTG, obj.KNM_QLNS, obj.KNM_THBC, obj.KNM_THICHUNG, obj.KNM_LVNHOM, obj.KNM_LVDOCLAP, obj.KNM_CHIUAPLUC, obj.KNM_THEODOI, obj.KNM_TUDUYPB, obj.KNM_KHAC, obj.KNM_KHAC_TEXT, obj.KNLV1_TENDV, obj.KNLV1_CHUCVU, obj.KNLV1_CV, obj.KNLV1_TG, obj.KNLV2_TENDV, obj.KNLV2_CHUCVU, obj.KNLV2_CV, obj.KNLV2_TG, obj.KNLV3_TENDV, obj.KNLV3_CHUCVU, obj.KNLV3_CV, obj.KNLV3_TG, obj.LVNN, obj.LVNN_TEXT, obj.DKDV_CSPL, obj.DKDV_TVVL, obj.DKDV_TVDTN, obj.DKDV_TVL, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId)
    End Sub
    Public Overrides Sub ND23_PLI_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLI_Delete", iD)
    End Sub
    Public Overrides Sub ND23_PLI_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLI_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIA"
    Public Overrides Function ND23_PLIA_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIA_Get", iD), IDataReader)
    End Function
    Public Overrides Function ND23_PLIA_Get_ByPLID(PortalConnect As String, PLID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIA_Get_ByPLID", PLID), IDataReader)
    End Function
    Public Overrides Function ND23_PLIA_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIA_List"), IDataReader)
    End Function
    Public Overrides Function ND23_PLIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIA_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function ND23_PLIA_Add(PortalConnect As String, obj As ND23_PLIAInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "ND23_PLIA_Add", obj.Code, obj.IDPLI, obj.CMND, obj.VLMM, obj.LHDN_NN, obj.LHDN_NGNN, obj.LHDN_VDTNN, obj.TenCongViec, obj.MoTaCongViec, obj.MaNghe, obj.MN_CAP1, obj.MN_CAP2, obj.MN_CAP3, obj.MN_CAP4, obj.CV_NV, obj.CV_QL, obj.CV_LD, obj.CV_KHAC, obj.CV_KHAC_TEXT, obj.KN_KC, obj.KN_DUOI1NAM, obj.KN_1DEN2NAM, obj.KN_2DEN5NAM, obj.KN_TREN5NAM, obj.NLVUT1_TINH, obj.NLVUT1_QHKCN, obj.NLVUT2_TINH, obj.NLVUT2_QHKCN, obj.LHD_KXD, obj.LHD_DUOI12T, obj.LHD_12DEN36, obj.KNDU_LC, obj.KNDU_CT, obj.KNDU_BP, obj.HTLV_TTG, obj.HTLV_BTG, obj.MDLV_LD, obj.MDLV_TT, obj.MDLV_LT, obj.ML_THANG, obj.ML_DUOI5, obj.ML_5DEN10, obj.ML_10DEN20, obj.ML_20DEN50, obj.ML_TREN50, obj.ML_NGAY, obj.ML_NGAY_TEXT, obj.ML_GIO, obj.ML_GIO_TEXT, obj.ML_THOATHUAN, obj.ML_HOAHONG, obj.HTA_1BUA, obj.HTA_2BUA, obj.HTA_3BUA, obj.HTA_TIEN, obj.PC_BHXH, obj.PC_BHNT, obj.PC_THOIVIEC, obj.PC_NHATRE, obj.PC_XE, obj.PC_HOTRODILAI, obj.PC_KTXH, obj.PC_HTNO, obj.PC_DAOTAO, obj.PC_NKT, obj.PC_CHTT, obj.PC_KHAC, obj.PC_KHAC_TEXT, obj.NLV_TN, obj.NLV_NT, obj.NLV_HH, obj.TLN_DUOI5, obj.TLN_5DEN20, obj.TLN_TREN20, obj.DILAI_KC, obj.DILAI_TB, obj.DILAI_NHIEU, obj.NGHENOI_KCT, obj.NGHENOI_CB, obj.NGHENOI_QT, obj.THILUC_BT, obj.THILUC_CHITIET, obj.THAOTACTAY_VL, obj.THAOTACTAY_VN, obj.THAOTACTAY_VRN, obj.DUNGTAY_2TAY, obj.DUNGTAY_DKC2TAY, obj.DUNGTAY_1TAY, obj.DUNGTAY_TRAI, obj.DUNGTAY_PHAI, obj.SANSANG_LVN, obj.SANSANG_LVS, obj.SANSANG_LVS_TEXT, obj.HTTD_TT, obj.HTTD_DT, obj.HTTD_PV, obj.HTTD_CV, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub ND23_PLIA_Update(PortalConnect As String, obj As ND23_PLIAInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIA_Update", obj.ID, obj.Code, obj.IDPLI, obj.CMND, obj.VLMM, obj.LHDN_NN, obj.LHDN_NGNN, obj.LHDN_VDTNN, obj.TenCongViec, obj.MoTaCongViec, obj.MaNghe, obj.MN_CAP1, obj.MN_CAP2, obj.MN_CAP3, obj.MN_CAP4, obj.CV_NV, obj.CV_QL, obj.CV_LD, obj.CV_KHAC, obj.CV_KHAC_TEXT, obj.KN_KC, obj.KN_DUOI1NAM, obj.KN_1DEN2NAM, obj.KN_2DEN5NAM, obj.KN_TREN5NAM, obj.NLVUT1_TINH, obj.NLVUT1_QHKCN, obj.NLVUT2_TINH, obj.NLVUT2_QHKCN, obj.LHD_KXD, obj.LHD_DUOI12T, obj.LHD_12DEN36, obj.KNDU_LC, obj.KNDU_CT, obj.KNDU_BP, obj.HTLV_TTG, obj.HTLV_BTG, obj.MDLV_LD, obj.MDLV_TT, obj.MDLV_LT, obj.ML_THANG, obj.ML_DUOI5, obj.ML_5DEN10, obj.ML_10DEN20, obj.ML_20DEN50, obj.ML_TREN50, obj.ML_NGAY, obj.ML_NGAY_TEXT, obj.ML_GIO, obj.ML_GIO_TEXT, obj.ML_THOATHUAN, obj.ML_HOAHONG, obj.HTA_1BUA, obj.HTA_2BUA, obj.HTA_3BUA, obj.HTA_TIEN, obj.PC_BHXH, obj.PC_BHNT, obj.PC_THOIVIEC, obj.PC_NHATRE, obj.PC_XE, obj.PC_HOTRODILAI, obj.PC_KTXH, obj.PC_HTNO, obj.PC_DAOTAO, obj.PC_NKT, obj.PC_CHTT, obj.PC_KHAC, obj.PC_KHAC_TEXT, obj.NLV_TN, obj.NLV_NT, obj.NLV_HH, obj.TLN_DUOI5, obj.TLN_5DEN20, obj.TLN_TREN20, obj.DILAI_KC, obj.DILAI_TB, obj.DILAI_NHIEU, obj.NGHENOI_KCT, obj.NGHENOI_CB, obj.NGHENOI_QT, obj.THILUC_BT, obj.THILUC_CHITIET, obj.THAOTACTAY_VL, obj.THAOTACTAY_VN, obj.THAOTACTAY_VRN, obj.DUNGTAY_2TAY, obj.DUNGTAY_DKC2TAY, obj.DUNGTAY_1TAY, obj.DUNGTAY_TRAI, obj.DUNGTAY_PHAI, obj.SANSANG_LVN, obj.SANSANG_LVS, obj.SANSANG_LVS_TEXT, obj.HTTD_TT, obj.HTTD_DT, obj.HTTD_PV, obj.HTTD_CV, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub ND23_PLIA_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIA_Delete", iD)
    End Sub
    Public Overrides Sub ND23_PLIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIA_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLII"
    Public Overrides Function ND23_PLII_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLII_Get", iD), IDataReader)
    End Function
    Public Overrides Function ND23_PLII_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLII_List"), IDataReader)
    End Function
    Public Overrides Function ND23_PLII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLII_List_Search", search, isOrder, currPage, recodperpage, UserName, YearId), IDataReader)
    End Function

    Public Overrides Function ND23_PLII_Add(PortalConnect As String, obj As ND23_PLIIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "ND23_PLII_Add", obj.Code, obj.TenTapThe, obj.SoLuong, obj.NguoiDaiDien, obj.DiaChiLH, obj.SDT_LL, obj.EMAIL_LL, obj.KHAC_LL, obj.DKDV_CSPL, obj.DKDV_TVVL, obj.DKDV_TVDTN, obj.DKDV_TVL, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId), Integer)
    End Function
    Public Overrides Sub ND23_PLII_Update(PortalConnect As String, obj As ND23_PLIIInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLII_Update", obj.ID, obj.Code, obj.TenTapThe, obj.SoLuong, obj.NguoiDaiDien, obj.DiaChiLH, obj.SDT_LL, obj.EMAIL_LL, obj.KHAC_LL, obj.DKDV_CSPL, obj.DKDV_TVVL, obj.DKDV_TVDTN, obj.DKDV_TVL, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId)
    End Sub
    Public Overrides Sub ND23_PLII_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLII_Delete", iD)
    End Sub
    Public Overrides Sub ND23_PLII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLII_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIII"
    Public Overrides Function ND23_PLIII_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIII_Get", iD), IDataReader)
    End Function
    Public Overrides Function ND23_PLIII_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIII_List"), IDataReader)
    End Function
    Public Overrides Function ND23_PLIII_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIII_List_Search", search, isOrder, currPage, recodperpage, UserName, YearId), IDataReader)
    End Function

    Public Overrides Function ND23_PLIII_Add(PortalConnect As String, obj As ND23_PLIIIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "ND23_PLIII_Add", obj.TenTapThe, obj.Code, obj.CANHAN, obj.DOANHNGHIEP, obj.MST, obj.LHDN_NN, obj.LHDN_NGNN, obj.LHDN_VDTNN, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.DiaChi, obj.KCN, obj.KCN_TEN, obj.SDT, obj.EMAIL, obj.NGANH_NLNN, obj.NGANH_KHAIKHOANG, obj.NGANH_CNCHEBIEN, obj.NGANH_XAYDUNG, obj.NGANH_SXPP, obj.NGANH_CCNUOC, obj.NGANH_VANTAI, obj.NGANH_DVLTANUONG, obj.NGANH_TTTT, obj.NGANH_TCBHNH, obj.NGANH_BDS, obj.NGANH_KHCN, obj.NGANH__HCDV, obj.NGANH_GDDT, obj.NGANH_YTE, obj.NGANH_NGHETHUAT, obj.NGANH_BANLE, obj.NGANH_DANGDOAN, obj.NGANH_GIUPVIEC, obj.NGANH_KHAC, obj.NGANH_QUOCTE, obj.SANPHAMCHINH, obj.QUYMO_DUOI10, obj.QUYMO_10DEN50, obj.QUYMO_51DEN100, obj.QUYMO_101DEN200, obj.QUYMO_202DEN500, obj.QUYMO_500DEN1K, obj.QUYMO_1KDEN3K, obj.QUYMO_3KDEN10K, obj.QUYMO_TREN10K, obj.SOLD_6THANGTOI, obj.NLH_HOTEN, obj.NLH_CHUCVU, obj.NLH_SDT, obj.NLH_LHK, obj.DKDV_CSPL, obj.DKDV_TVTUYENLD, obj.DKDV_TVSDLD, obj.DKDV_DKGTCULD, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId), Integer)
    End Function
    Public Overrides Sub ND23_PLIII_Update(PortalConnect As String, obj As ND23_PLIIIInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIII_Update", obj.ID, obj.TenTapThe, obj.Code, obj.CANHAN, obj.DOANHNGHIEP, obj.MST, obj.LHDN_NN, obj.LHDN_NGNN, obj.LHDN_VDTNN, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.DiaChi, obj.KCN, obj.KCN_TEN, obj.SDT, obj.EMAIL, obj.NGANH_NLNN, obj.NGANH_KHAIKHOANG, obj.NGANH_CNCHEBIEN, obj.NGANH_XAYDUNG, obj.NGANH_SXPP, obj.NGANH_CCNUOC, obj.NGANH_VANTAI, obj.NGANH_DVLTANUONG, obj.NGANH_TTTT, obj.NGANH_TCBHNH, obj.NGANH_BDS, obj.NGANH_KHCN, obj.NGANH__HCDV, obj.NGANH_GDDT, obj.NGANH_YTE, obj.NGANH_NGHETHUAT, obj.NGANH_BANLE, obj.NGANH_DANGDOAN, obj.NGANH_GIUPVIEC, obj.NGANH_KHAC, obj.NGANH_QUOCTE, obj.SANPHAMCHINH, obj.QUYMO_DUOI10, obj.QUYMO_10DEN50, obj.QUYMO_51DEN100, obj.QUYMO_101DEN200, obj.QUYMO_202DEN500, obj.QUYMO_500DEN1K, obj.QUYMO_1KDEN3K, obj.QUYMO_3KDEN10K, obj.QUYMO_TREN10K, obj.SOLD_6THANGTOI, obj.NLH_HOTEN, obj.NLH_CHUCVU, obj.NLH_SDT, obj.NLH_LHK, obj.DKDV_CSPL, obj.DKDV_TVTUYENLD, obj.DKDV_TVSDLD, obj.DKDV_DKGTCULD, obj.DKDV_KHAC, obj.DKDV_KHAC_TEXT, obj.ThoiGianDangKy, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId)
    End Sub
    Public Overrides Sub ND23_PLIII_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIII_Delete", iD)
    End Sub
    Public Overrides Sub ND23_PLIII_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIII_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "ND23_PLIIIA"
    Public Overrides Function ND23_PLIIIA_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIIIA_Get", iD), IDataReader)
    End Function
    Public Overrides Function ND23_PLIIIA_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIIIA_List"), IDataReader)
    End Function
    Public Overrides Function ND23_PLIIIA_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "ND23_PLIIIA_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function ND23_PLIIIA_Add(PortalConnect As String, obj As ND23_PLIIIAInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "ND23_PLIIIA_Add", obj.Code, obj.MST, obj.IDPLIII, obj.TenCongViec, obj.SoLuong, obj.MoTaCongViec, obj.MaNghe, obj.MN_CAP1, obj.MN_CAP2, obj.MN_CAP3, obj.MN_CAP4, obj.CV_NV, obj.CV_QL, obj.CV_LD, obj.CV_KHAC, obj.CV_KHAC_TEXT, obj.TDHV_CTH, obj.TDHV_TH, obj.TDHV_THCS, obj.TDHV_THPT, obj.TDCM_CQDT, obj.TDCM_CNKTKB, obj.TDCM_SOCAP, obj.TDCM_TRUNGCAP, obj.TDCM_CAODANG, obj.TDCM_DH, obj.TDCM_THS, obj.TDCM_TS, obj.TDCM_KHAC, obj.TDCM_KHAC1, obj.TDCM_KHAC2, obj.TDKNN, obj.BAC_NGHE, obj.TDNN1, obj.TDNN1_CC, obj.TDNN1_MUCDO, obj.TDNN2, obj.TDNN2_CC, obj.TDNN2_MUCDO, obj.TDTH, obj.TDTH_CC, obj.TDTH_MUCDO, obj.TDTHK, obj.TDTHK_CC, obj.TDTHK_MUCDO, obj.KNM_GT, obj.KNM_TT, obj.KNM_QLTG, obj.KNM_QLNS, obj.KNM_THBC, obj.KNM_THICHUNG, obj.KNM_LVNHOM, obj.KNM_LVDOCLAP, obj.KNM_CHIUAPLUC, obj.KNM_THEODOI, obj.KNM_TUDUYPB, obj.KNM_KHAC, obj.KNM_KHAC_TEXT, obj.KN_KC, obj.KN_DUOI1NAM, obj.KN_1DEN2NAM, obj.KN_2DEN5NAM, obj.KN_TREN5NAM, obj.NLVUT_TINH, obj.NLVUT_QHKCN, obj.LHD_KXD, obj.LHD_DUOI12T, obj.LHD_12DEN36, obj.KNDU_LC, obj.KNDU_CT, obj.KNDU_BP, obj.HTLV_TTG, obj.HTLV_BTG, obj.MDLV_LD, obj.MDLV_TT, obj.MDLV_LT, obj.ML_THANG, obj.ML_DUOI5, obj.ML_5DEN10, obj.ML_10DEN20, obj.ML_20DEN50, obj.ML_TREN50, obj.ML_NGAY, obj.ML_NGAY_TEXT, obj.ML_GIO, obj.ML_GIO_TEXT, obj.ML_THOATHUAN, obj.ML_HOAHONG, obj.HTA_1BUA, obj.HTA_2BUA, obj.HTA_3BUA, obj.HTA_TIEN, obj.PC_BHXH, obj.PC_BHNT, obj.PC_THOIVIEC, obj.PC_NHATRE, obj.PC_XE, obj.PC_HOTRODILAI, obj.PC_KTXH, obj.PC_HTNO, obj.PC_DAOTAO, obj.PC_NKT, obj.PC_CHTT, obj.PC_KHAC, obj.PC_KHAC_TEXT, obj.NLV_TN, obj.NLV_NT, obj.NLV_HH, obj.TLN_DUOI5, obj.TLN_5DEN20, obj.TLN_TREN20, obj.DILAI_KC, obj.DILAI_TB, obj.DILAI_NHIEU, obj.NGHENOI_KCT, obj.NGHENOI_CB, obj.NGHENOI_QT, obj.THILUC_BT, obj.THILUC_CHITIET, obj.THAOTACTAY_VL, obj.THAOTACTAY_VN, obj.THAOTACTAY_VRN, obj.DUNGTAY_2TAY, obj.DUNGTAY_DKC2TAY, obj.DUNGTAY_1TAY, obj.DUNGTAY_TRAI, obj.DUNGTAY_PHAI, obj.DTUT_NKT, obj.DTUT_DTTS, obj.DTUT_HN, obj.DTUT_BODOI, obj.DTUT_KHAC, obj.DTUT_KHAC_TEXT, obj.HTTD_TT, obj.HTTD_DT, obj.HTTD_PV, obj.HTTD_CV, obj.ThoiHanTD, obj.MongMuon_TV, obj.MongMuon_GTVL, obj.MongMuon_CULD, obj.NLHTD_HOTEN, obj.NLHTD_CHUCVU, obj.NLHTD_SDT, obj.NLHTD_EMAIL, obj.NLHTD_LHK, obj.PUSH_SMS, obj.PUSH_EMAIL, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub ND23_PLIIIA_Update(PortalConnect As String, obj As ND23_PLIIIAInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIIIA_Update", obj.ID, obj.Code, obj.MST, obj.IDPLIII, obj.TenCongViec, obj.SoLuong, obj.MoTaCongViec, obj.MaNghe, obj.MN_CAP1, obj.MN_CAP2, obj.MN_CAP3, obj.MN_CAP4, obj.CV_NV, obj.CV_QL, obj.CV_LD, obj.CV_KHAC, obj.CV_KHAC_TEXT, obj.TDHV_CTH, obj.TDHV_TH, obj.TDHV_THCS, obj.TDHV_THPT, obj.TDCM_CQDT, obj.TDCM_CNKTKB, obj.TDCM_SOCAP, obj.TDCM_TRUNGCAP, obj.TDCM_CAODANG, obj.TDCM_DH, obj.TDCM_THS, obj.TDCM_TS, obj.TDCM_KHAC, obj.TDCM_KHAC1, obj.TDCM_KHAC2, obj.TDKNN, obj.BAC_NGHE, obj.TDNN1, obj.TDNN1_CC, obj.TDNN1_MUCDO, obj.TDNN2, obj.TDNN2_CC, obj.TDNN2_MUCDO, obj.TDTH, obj.TDTH_CC, obj.TDTH_MUCDO, obj.TDTHK, obj.TDTHK_CC, obj.TDTHK_MUCDO, obj.KNM_GT, obj.KNM_TT, obj.KNM_QLTG, obj.KNM_QLNS, obj.KNM_THBC, obj.KNM_THICHUNG, obj.KNM_LVNHOM, obj.KNM_LVDOCLAP, obj.KNM_CHIUAPLUC, obj.KNM_THEODOI, obj.KNM_TUDUYPB, obj.KNM_KHAC, obj.KNM_KHAC_TEXT, obj.KN_KC, obj.KN_DUOI1NAM, obj.KN_1DEN2NAM, obj.KN_2DEN5NAM, obj.KN_TREN5NAM, obj.NLVUT_TINH, obj.NLVUT_QHKCN, obj.LHD_KXD, obj.LHD_DUOI12T, obj.LHD_12DEN36, obj.KNDU_LC, obj.KNDU_CT, obj.KNDU_BP, obj.HTLV_TTG, obj.HTLV_BTG, obj.MDLV_LD, obj.MDLV_TT, obj.MDLV_LT, obj.ML_THANG, obj.ML_DUOI5, obj.ML_5DEN10, obj.ML_10DEN20, obj.ML_20DEN50, obj.ML_TREN50, obj.ML_NGAY, obj.ML_NGAY_TEXT, obj.ML_GIO, obj.ML_GIO_TEXT, obj.ML_THOATHUAN, obj.ML_HOAHONG, obj.HTA_1BUA, obj.HTA_2BUA, obj.HTA_3BUA, obj.HTA_TIEN, obj.PC_BHXH, obj.PC_BHNT, obj.PC_THOIVIEC, obj.PC_NHATRE, obj.PC_XE, obj.PC_HOTRODILAI, obj.PC_KTXH, obj.PC_HTNO, obj.PC_DAOTAO, obj.PC_NKT, obj.PC_CHTT, obj.PC_KHAC, obj.PC_KHAC_TEXT, obj.NLV_TN, obj.NLV_NT, obj.NLV_HH, obj.TLN_DUOI5, obj.TLN_5DEN20, obj.TLN_TREN20, obj.DILAI_KC, obj.DILAI_TB, obj.DILAI_NHIEU, obj.NGHENOI_KCT, obj.NGHENOI_CB, obj.NGHENOI_QT, obj.THILUC_BT, obj.THILUC_CHITIET, obj.THAOTACTAY_VL, obj.THAOTACTAY_VN, obj.THAOTACTAY_VRN, obj.DUNGTAY_2TAY, obj.DUNGTAY_DKC2TAY, obj.DUNGTAY_1TAY, obj.DUNGTAY_TRAI, obj.DUNGTAY_PHAI, obj.DTUT_NKT, obj.DTUT_DTTS, obj.DTUT_HN, obj.DTUT_BODOI, obj.DTUT_KHAC, obj.DTUT_KHAC_TEXT, obj.HTTD_TT, obj.HTTD_DT, obj.HTTD_PV, obj.HTTD_CV, obj.ThoiHanTD, obj.MongMuon_TV, obj.MongMuon_GTVL, obj.MongMuon_CULD, obj.NLHTD_HOTEN, obj.NLHTD_CHUCVU, obj.NLHTD_SDT, obj.NLHTD_EMAIL, obj.NLHTD_LHK, obj.PUSH_SMS, obj.PUSH_EMAIL, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub ND23_PLIIIA_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIIIA_Delete", iD)
    End Sub
    Public Overrides Sub ND23_PLIIIA_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "ND23_PLIIIA_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_JobHistory"
    Public Overrides Function CMS_JobHistory_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobHistory_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_JobHistory_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobHistory_List"), IDataReader)
    End Function
    Public Overrides Function CMS_JobHistory_List_ByJobUserID(PortalConnect As String, jobUserID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobHistory_List_ByJobUserID", jobUserID), IDataReader)
    End Function

    Public Overrides Function CMS_JobHistory_Add(PortalConnect As String, obj As CMS_JobHistoryInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobHistory_Add", obj.JobUserID, obj.HisName, obj.HisDate, obj.UserName), Integer)
    End Function
    Public Overrides Sub CMS_JobHistory_Update(PortalConnect As String, obj As CMS_JobHistoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobHistory_Update", obj.ID, obj.JobUserID, obj.HisName, obj.HisDate, obj.UserName)
    End Sub
    Public Overrides Sub CMS_JobHistory_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobHistory_Delete", iD)
    End Sub
    Public Overrides Sub CMS_JobHistory_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobHistory_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_JobUserRefer"
    Public Overrides Function CMS_JobUserRefer_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUserRefer_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_JobUserRefer_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUserRefer_List"), IDataReader)
    End Function
    Public Overrides Function CMS_JobUserRefer_List_ByJobUserID(PortalConnect As String, jobUserID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUserRefer_List_ByJobUserID", jobUserID), IDataReader)
    End Function

    Public Overrides Function CMS_JobUserRefer_Add(PortalConnect As String, obj As CMS_JobUserReferInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobUserRefer_Add", obj.JobUserID, obj.HoTen, obj.ChucVu, obj.NoiCongTac, obj.SoDienThoai, obj.Email, obj.MoiQuanHe), Integer)
    End Function
    Public Overrides Sub CMS_JobUserRefer_Update(PortalConnect As String, obj As CMS_JobUserReferInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUserRefer_Update", obj.ID, obj.JobUserID, obj.HoTen, obj.ChucVu, obj.NoiCongTac, obj.SoDienThoai, obj.Email, obj.MoiQuanHe)
    End Sub
    Public Overrides Sub CMS_JobUserRefer_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUserRefer_Delete", iD)
    End Sub
    Public Overrides Sub CMS_JobUserRefer_Update_Quick(PortalConnect As String, iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_JobUserRefer_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region


#Region "CMS_Trainning"
    Public Overrides Function CMS_Trainning_Get(PortalConnect As String, trainning_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Trainning_Get", trainning_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Trainning_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Trainning_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Trainning_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Trainning_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Trainning_Add(PortalConnect As String, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Trainning_Add", trainning_Code, trainning_Name, trainning_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Trainning_Update(PortalConnect As String, trainning_ID As Integer, trainning_Code As String, trainning_Name As String, trainning_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Trainning_Update", trainning_ID, trainning_Code, trainning_Name, trainning_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Trainning_Delete(PortalConnect As String, trainning_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Trainning_Delete", trainning_ID)
    End Sub
    Public Overrides Sub CMS_Trainning_Update_Quick(PortalConnect As String, trainning_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Trainning_Update_Quick", trainning_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_TypeEco"
    Public Overrides Function CMS_TypeEco_Get(PortalConnect As String, typeEco_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_Get", typeEco_ID), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_List"), IDataReader)
    End Function
    Public Overrides Function CMS_TypeEco_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_TypeEco_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_TypeEco_Add(PortalConnect As String, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_TypeEco_Add", typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_TypeEco_Update(PortalConnect As String, typeEco_ID As Integer, typeEco_Code As String, typeEco_Name As String, typeEco_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Update", typeEco_ID, typeEco_Code, typeEco_Name, typeEco_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_TypeEco_Delete(PortalConnect As String, typeEco_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Delete", typeEco_ID)
    End Sub
    Public Overrides Sub CMS_TypeEco_Update_Quick(PortalConnect As String, typeEco_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_TypeEco_Update_Quick", typeEco_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_WorkJoin"
    Public Overrides Function CMS_WorkJoin_Get(PortalConnect As String, workJoin_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_WorkJoin_Get", workJoin_ID), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_WorkJoin_List"), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_WorkJoin_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_WorkJoin_Add(PortalConnect As String, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_WorkJoin_Add", workJoin_Code, workJoin_Name, workJoin_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_WorkJoin_Update(PortalConnect As String, workJoin_ID As Integer, workJoin_Code As String, workJoin_Name As String, workJoin_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_WorkJoin_Update", workJoin_ID, workJoin_Code, workJoin_Name, workJoin_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_WorkJoin_Delete(PortalConnect As String, workJoin_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_WorkJoin_Delete", workJoin_ID)
    End Sub
    Public Overrides Sub CMS_WorkJoin_Update_Quick(PortalConnect As String, workJoin_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_WorkJoin_Update_Quick", workJoin_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_Specialize"
    Public Overrides Function CMS_Specialize_Get(PortalConnect As String, specialize_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Specialize_Get", specialize_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_GetByCode(PortalConnect As String, specialize_code As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Specialize_GetByCode", specialize_code), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Specialize_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Specialize_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Specialize_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Specialize_Add(PortalConnect As String, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Specialize_Add", specialize_Code, specialize_Name, specialize_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Specialize_Update(PortalConnect As String, specialize_ID As Integer, specialize_Code As String, specialize_Name As String, specialize_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Specialize_Update", specialize_ID, specialize_Code, specialize_Name, specialize_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Specialize_Delete(PortalConnect As String, specialize_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Specialize_Delete", specialize_ID)
    End Sub
    Public Overrides Sub CMS_Specialize_Update_Quick(PortalConnect As String, specialize_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Specialize_Update_Quick", specialize_ID, isActive, isOrder)
    End Sub
#End Region

#Region "CMS_CareerCLD"
    Public Overrides Function CMS_CareerCLD_Get(PortalConnect As String, CareerCLD_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_CareerCLD_Get", CareerCLD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_CareerCLD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_CareerCLD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_CareerCLD_Add(PortalConnect As String, obj As CMS_CareerCLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_CareerCLD_Add", obj.CareerCLD_Name, obj.CareerCLD_Code, obj.CareerCLD_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate), Integer)
    End Function
    Public Overrides Sub CMS_CareerCLD_Update(PortalConnect As String, obj As CMS_CareerCLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_CareerCLD_Update", obj.CareerCLD_ID, obj.CareerCLD_Name, obj.CareerCLD_Code, obj.CareerCLD_Des, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_CareerCLD_Delete(PortalConnect As String, CareerCLD_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_CareerCLD_Delete", CareerCLD_ID)
    End Sub
#End Region
#Region "CMS_Method"
    Public Overrides Function CMS_Method_Get(PortalConnect As String, method_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_Get", method_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Method_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_Method_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Method_Add(PortalConnect As String, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_Method_Add", method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder), Integer)
    End Function
    Public Overrides Sub CMS_Method_Update(PortalConnect As String, method_ID As Integer, method_Code As String, method_Name As String, method_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Update", method_ID, method_Code, method_Name, method_Des, createdDate, createdUser, flReg.GetNull(updatedDate), updatedUser, isActive, isOrder)
    End Sub
    Public Overrides Sub CMS_Method_Delete(PortalConnect As String, method_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Delete", method_ID)
    End Sub
    Public Overrides Sub CMS_Method_Update_Quick(PortalConnect As String, method_ID As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_Method_Update_Quick", method_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_BanBe"
    Public Overrides Function CMS_BanBe_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_BanBe_Add(PortalConnect As String, obj As CMS_BanBeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_BanBe_Add", obj.UserName, obj.UserNameBanBe, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_BanBe_Update(PortalConnect As String, obj As CMS_BanBeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BanBe_Update", obj.Id, obj.UserName, obj.UserNameBanBe, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_BanBe_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BanBe_Delete", id)
    End Sub
#End Region
#Region "CMS_WorkExtend"
    Public Overrides Function CMS_WorkExtend_Get(PortalConnect As String, work_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkExtend_Get", work_ID), IDataReader)
    End Function
    Public Overrides Function CMS_WorkExtend_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkExtend_List"), IDataReader)
    End Function
    Public Overrides Function CMS_WorkExtend_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Business_ID As String, Salary_ID As String, Experience_ID As String, TinhTP As String, quanHuyen As String, status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkExtend_List_Search", search, isOrder, currPage, recodperpage, UserName, Business_ID, Salary_ID, Experience_ID, TinhTP, quanHuyen, status), IDataReader)
    End Function
    Public Overrides Function CMS_WorkExtend_Add(PortalConnect As String, obj As CMS_WorkExtendInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_WorkExtend_Add", obj.Id, obj.Work_ID, obj.Business_ID, obj.IsApproval, obj.IsHot, obj.IsFast, obj.IsUrgent, obj.IsGhim, obj.StartDate, obj.EndDate, obj.Title, obj.Quantity, obj.ExpiredDate, obj.TinhTP, obj.QuanHuyen, obj.Salary_ID, obj.Experience_ID, obj.SubmissionSend, obj.Level_ID, obj.JobPlace_ID, obj.Gender_ID, obj.Ages, obj.TypeOf_ID, obj.Career_ID, obj.WorkTime, obj.Description, obj.Benefit, obj.MaNghe_Id, obj.MaNgheCap1, obj.MaNgheCap2, obj.MaNgheCap3, obj.MaNgheCap4, obj.LevelDesired, obj.Requirement, obj.RequirementsProfile, obj.TrinhDoHocVan, obj.TrinhDoChuyenMon, obj.ChuyenNganhDaoTao, obj.TrinhDoKhac, obj.TrinhDoKhac2, obj.KyNangNghe, obj.KyNangNgheBac, obj.NgoaiNgu1, obj.NgoaiNgu1ChungChi, obj.TrinhDoNgoaiNgu1, obj.NgoaiNgu2, obj.NgoaiNgu1ChungChi2, obj.TrinhDoNgoaiNgu2, obj.TrinhDoTinHoc, obj.TrinhDoTinHoc_KhaNang, obj.TrinhDoTinHoc_Khac, obj.TrinhDoTinHoc_Khac_KhaNang, obj.KyNangMem, obj.YeuCauKinhNghiem, obj.ContractType_Option, obj.IsLamCa, obj.IsDiCongTac, obj.IsDiBietPhai, obj.HinhThucLamViec, obj.MucDich_ID, obj.KieuLuong, obj.Salary_Option, obj.Salary_Text, obj.IsHoaHong, obj.HinhThucNop, obj.HoTroAn, obj.PhucLoi, obj.XeDuaDon, obj.HoTro, obj.PhucLoiKhac, obj.NoiLamViec, obj.NoiLamViecTrongLuong, obj.NoiLamViecDiLai, obj.NoiLamViecNgheNoi, obj.NoiLamViecThiLuc, obj.NoiLamViecThaoTacBangTay, obj.NoiLamViecDung2Tay, obj.DoiTuongUuTien, obj.HinhThucTuyenDung, obj.ThoiHanTuyenDung, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.LevelDesiredOther, obj.IsThoaThuan, obj.MongMuonDN, obj.KyNangMemKhac, obj.IsEmail, obj.IsSMS, obj.ChucVuUser, obj.HoTroAnTien, obj.KCN, obj.KCN_ID), Integer)
    End Function
    Public Overrides Sub CMS_WorkExtend_Update(PortalConnect As String, obj As CMS_WorkExtendInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkExtend_Update", obj.Work_ID, obj.Id, obj.Business_ID, obj.IsApproval, obj.IsHot, obj.IsFast, obj.IsUrgent, obj.IsGhim, obj.StartDate, obj.EndDate, obj.Title, obj.Quantity, obj.ExpiredDate, obj.TinhTP, obj.QuanHuyen, obj.Salary_ID, obj.Experience_ID, obj.SubmissionSend, obj.Level_ID, obj.JobPlace_ID, obj.Gender_ID, obj.Ages, obj.TypeOf_ID, obj.Career_ID, obj.WorkTime, obj.Description, obj.Benefit, obj.MaNghe_Id, obj.MaNgheCap1, obj.MaNgheCap2, obj.MaNgheCap3, obj.MaNgheCap4, obj.LevelDesired, obj.Requirement, obj.RequirementsProfile, obj.TrinhDoHocVan, obj.TrinhDoChuyenMon, obj.ChuyenNganhDaoTao, obj.TrinhDoKhac, obj.TrinhDoKhac2, obj.KyNangNghe, obj.KyNangNgheBac, obj.NgoaiNgu1, obj.NgoaiNgu1ChungChi, obj.TrinhDoNgoaiNgu1, obj.NgoaiNgu2, obj.NgoaiNgu1ChungChi2, obj.TrinhDoNgoaiNgu2, obj.TrinhDoTinHoc, obj.TrinhDoTinHoc_KhaNang, obj.TrinhDoTinHoc_Khac, obj.TrinhDoTinHoc_Khac_KhaNang, obj.KyNangMem, obj.YeuCauKinhNghiem, obj.ContractType_Option, obj.IsLamCa, obj.IsDiCongTac, obj.IsDiBietPhai, obj.HinhThucLamViec, obj.MucDich_ID, obj.KieuLuong, obj.Salary_Option, obj.Salary_Text, obj.IsHoaHong, obj.HinhThucNop, obj.HoTroAn, obj.PhucLoi, obj.XeDuaDon, obj.HoTro, obj.PhucLoiKhac, obj.NoiLamViec, obj.NoiLamViecTrongLuong, obj.NoiLamViecDiLai, obj.NoiLamViecNgheNoi, obj.NoiLamViecThiLuc, obj.NoiLamViecThaoTacBangTay, obj.NoiLamViecDung2Tay, obj.DoiTuongUuTien, obj.HinhThucTuyenDung, obj.ThoiHanTuyenDung, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.LevelDesiredOther, obj.IsThoaThuan, obj.MongMuonDN, obj.KyNangMemKhac, obj.IsEmail, obj.IsSMS, obj.ChucVuUser, obj.HoTroAnTien, obj.KCN, obj.KCN_ID)
    End Sub
    Public Overrides Sub CMS_WorkExtend_Delete(PortalConnect As String, work_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkExtend_Delete", work_ID)
    End Sub
    Public Overrides Sub CMS_WorkExtend_Update_Quick(PortalConnect As String, work_ID As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, isApproval As Boolean, approvalUser As String, approvalDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkExtend_Update_Quick", work_ID, isHot, isFast, IsUrgent, isApproval, approvalUser, approvalDate)
    End Sub
#End Region
#Region "Add list data to database"
    Public Overrides Sub CMS_Excute_DataTable(PortalConnect As String, procName As String, items As DataTable)
        Dim ds As DataSet = New DataSet()
        Dim connection As New SqlConnection(flConnect.WorkConnect)
        Try
            Dim command As New SqlCommand(procName, connection)
            command.CommandType = CommandType.StoredProcedure

            connection.Open()
            command.Parameters.AddWithValue("@data", items)
            command.CommandTimeout = 360
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        Finally
            If connection IsNot Nothing Then
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End If
        End Try
    End Sub
#End Region
#Region "Mapping data"
    Public Overrides Function MAPWork_GetByMapId(Of T As IMappingInfo)(PortalConnect As String, id As String, Optional customTableName As String = "") As IDataReader
        Dim info As T = Activator.CreateInstance(Of T)()
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, info.GetSQLProcedureName("_GetByMapId", customTableName:=customTableName), id), IDataReader)
    End Function
    Public Overrides Sub MAPWork_DeleteByMapId(Of T As IMappingInfo)(PortalConnect As String, id As String, Optional customTableName As String = "")
        Dim info As T = Activator.CreateInstance(Of T)()
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, info.GetSQLProcedureName("_Delete", customTableName), id)
    End Sub
#End Region
#Region "CMS_JobUserExtra"
    Public Overrides Function CMS_JobUserExtra_Get(PortalConnect As String, jobUser_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobUserExtra_Get", jobUser_ID), IDataReader)
    End Function
    Public Overrides Function CMS_JobUserExtra_Add(PortalConnect As String, obj As CMS_JobUserExtraInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobUserExtra_Add", obj.ID, obj.JobUser_ID, obj.Career_ID, obj.TinhTP2, obj.QuanHuyen2, obj.TextSanSangLamViec, obj.Description, obj.IsLamCa, obj.IsDiCongTac, obj.IsDiBietPhai, obj.IsHoaHong, obj.PhucLoiKhacText, obj.Salary_Option, obj.Salary_Text, obj.LoaiHinhDoanhNghiep, obj.HoTroAn, obj.PhucLoi, obj.XeDuaDon, obj.PhucLoiKhac, obj.NoiLamViec, obj.NoiLamViecTrongLuong, obj.NoiLamViecDiLai, obj.NoiLamViecNgheNoi, obj.NoiLamViecThiLuc, obj.NoiLamViecThaoTacBangTay, obj.NoiLamViecDung2Tay, obj.HinhThucTuyenDung, obj.ContractType_Option, obj.TypeOf_ID, obj.MucDich, obj.SanSangLamViec, obj.MaNgheCap1, obj.MaNgheCap2, obj.MaNgheCap3, obj.MaNgheCap4, obj.LevelDesiredOther, obj.IsThoaThuan, obj.TrinhDoChuyenMon, obj.KCN_ID, obj.KCN_ID2), Integer)
    End Function
#End Region
#Region "CMS_NgheCongViec"
    Public Overrides Function CMS_NgheCongViec_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_NgheCongViec_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NgheCongViec_Get(PortalConnect As String, career_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_NgheCongViec_Get", career_ID), IDataReader)
    End Function
#End Region
#Region "CMS_WorkReport"
    Public Overrides Function CMS_WorkReport_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkReport_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_WorkReport_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkReport_List"), IDataReader)
    End Function
    Public Overrides Function CMS_WorkReport_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_WorkReport_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_WorkReport_Add(PortalConnect As String, obj As CMS_WorkReportInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_WorkReport_Add", obj.Work_ID, obj.Work_Title, obj.Work_Url, obj.TieuDe, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_WorkReport_Update(PortalConnect As String, obj As CMS_WorkReportInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkReport_Update", obj.ID, obj.Work_ID, obj.Work_Title, obj.Work_Url, obj.TieuDe, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_WorkReport_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_WorkReport_Delete", iD)
    End Sub
#End Region
#Region "CMS_BusinessFollow"
    Public Overrides Function CMS_BusinessFollow_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusinessFollow_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_BusinessFollow_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusinessFollow_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BusinessFollow_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BusinessFollow_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_BusinessFollow_Add(PortalConnect As String, obj As CMS_BusinessFollowInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_BusinessFollow_Add", obj.Business_ID, obj.Business_Vn, obj.Business_Url, obj.TieuDe, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_BusinessFollow_Update(PortalConnect As String, obj As CMS_BusinessFollowInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusinessFollow_Update", obj.ID, obj.Business_ID, obj.Business_Vn, obj.Business_Url, obj.TieuDe, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_BusinessFollow_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BusinessFollow_Delete", iD)
    End Sub
#End Region
#Region "CMS_BanBe_TinNhan"
    Public Overrides Function CMS_BanBe_TinNhan_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_TinNhan_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_TinNhan_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_TinNhan_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_TinNhan_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_TinNhan_List_Search", search, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_TinNhan_Details(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, UserNameBanBe As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_BanBe_TinNhan_Details", search, isOrder, currPage, recodperpage, UserName, UserNameBanBe), IDataReader)
    End Function
    Public Overrides Function CMS_BanBe_TinNhan_Add(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_BanBe_TinNhan_Add", obj.UserName, obj.UserNameBanBe, obj.NoiDung, obj.FileURL, obj.LoaiTinNhan, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_BanBe_TinNhan_Update(PortalConnect As String, obj As CMS_BanBe_TinNhanInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BanBe_TinNhan_Update", obj.Id, obj.UserName, obj.UserNameBanBe, obj.NoiDung, obj.FileURL, obj.LoaiTinNhan, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_BanBe_TinNhan_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_BanBe_TinNhan_Delete", id)
    End Sub
#End Region
#Region "CMS_LoaiTuVan"
    Public Overrides Function CMS_LoaiTuVan_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LoaiTuVan_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_LoaiTuVan_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LoaiTuVan_List"), IDataReader)
    End Function
    Public Overrides Function CMS_LoaiTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LoaiTuVan_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_LoaiTuVan_Add(PortalConnect As String, obj As CMS_LoaiTuVanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_LoaiTuVan_Add", obj.TenLoaiTuVan, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_LoaiTuVan_Update(PortalConnect As String, obj As CMS_LoaiTuVanInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_LoaiTuVan_Update", obj.ID, obj.TenLoaiTuVan, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_LoaiTuVan_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_LoaiTuVan_Delete", iD)
    End Sub
#End Region
#Region "CMS_CaTuVan"
    Public Overrides Function CMS_CaTuVan_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVan_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVan_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVan_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVan_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVan_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_CaTuVan_Add(PortalConnect As String, obj As CMS_CaTuVanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_CaTuVan_Add", obj.IDLoaiTuVan, obj.TenCaTuVan, obj.ThoiGianDuKien, obj.ThoiGianThucTe, obj.ThoiLuongCaTuVan, obj.DiaDiem, obj.HinhThuc, obj.MoTa, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_CaTuVan_Update(PortalConnect As String, obj As CMS_CaTuVanInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVan_Update", obj.ID, obj.IDLoaiTuVan, obj.TenCaTuVan, obj.ThoiGianDuKien, obj.ThoiGianThucTe, obj.ThoiLuongCaTuVan, obj.DiaDiem, obj.HinhThuc, obj.MoTa, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_CaTuVan_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVan_Delete", iD)
    End Sub
#End Region
#Region "CMS_DonHangXKLD"
    Public Overrides Function CMS_DonHangXKLD_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangXKLD_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_DonHangXKLD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangXKLD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DonHangXKLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangXKLD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_DonHangXKLD_Add(PortalConnect As String, obj As CMS_DonHangXKLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_DonHangXKLD_Add", obj.TenDonHang, obj.NganhNghe, obj.DiaDiem, obj.MoTa, obj.NgayBatDau, obj.MucLuong, obj.SoLuong, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_DonHangXKLD_Update(PortalConnect As String, obj As CMS_DonHangXKLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DonHangXKLD_Update", obj.ID, obj.TenDonHang, obj.NganhNghe, obj.DiaDiem, obj.MoTa, obj.NgayBatDau, obj.MucLuong, obj.SoLuong, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_DonHangXKLD_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DonHangXKLD_Delete", iD)
    End Sub
    Public Overrides Sub CMS_DonHangNLD_Update_Introduce(PortalConnect As String, iD As Integer, isIntroduce As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DonHangNLD_Update_Introduce", iD, isIntroduce)
    End Sub
#End Region
#Region "CMS_DonHangNLD"
    Public Overrides Function CMS_DonHangNLD_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangNLD_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_DonHangNLD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangNLD_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DonHangNLD_List_Search(PortalConnect As String, idDonHangXKLD As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_DonHangNLD_List_Search", idDonHangXKLD, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_DonHangNLD_Add(PortalConnect As String, obj As CMS_DonHangNLDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_DonHangNLD_Add", obj.IdDonHangXKLD, obj.UserId, obj.UserName, obj.HoTen, obj.SoDienThoai, obj.CCCD, obj.NgaySinh, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_DonHangNLD_Update(PortalConnect As String, obj As CMS_DonHangNLDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DonHangNLD_Update", obj.Id, obj.IdDonHangXKLD, obj.UserId, obj.UserName, obj.HoTen, obj.SoDienThoai, obj.CCCD, obj.NgaySinh, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_DonHangNLD_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_DonHangNLD_Delete", id)
    End Sub
#End Region
#Region "CMS_CaTuVanCN"
    Public Overrides Function CMS_CaTuVanCN_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanCN_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVanCN_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanCN_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVanCN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanCN_List_Search", idCaTuVan, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_CaTuVanCN_Add(PortalConnect As String, obj As CMS_CaTuVanCNInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_CaTuVanCN_Add", obj.IdCaTuVan, obj.HoTen, obj.GioiTinh, obj.NgaySinh, obj.CCCD, obj.NoiOHT, obj.ThoiGianThucTe, obj.ThoiLuongCaTuVan, obj.SoLuong, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_CaTuVanCN_Update(PortalConnect As String, obj As CMS_CaTuVanCNInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVanCN_Update", obj.ID, obj.IdCaTuVan, obj.HoTen, obj.GioiTinh, obj.NgaySinh, obj.CCCD, obj.NoiOHT, obj.ThoiGianThucTe, obj.ThoiLuongCaTuVan, obj.SoLuong, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_CaTuVanCN_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVanCN_Delete", iD)
    End Sub
#End Region
#Region "CMS_CaTuVanDN"
    Public Overrides Function CMS_CaTuVanDN_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanDN_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVanDN_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanDN_List"), IDataReader)
    End Function
    Public Overrides Function CMS_CaTuVanDN_List_Search(PortalConnect As String, idCaTuVan As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_CaTuVanDN_List_Search", idCaTuVan, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_CaTuVanDN_Add(PortalConnect As String, obj As CMS_CaTuVanDNInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_CaTuVanDN_Add", obj.IdCaTuVan, obj.TenDoanhNghiep, obj.MST, obj.DiaChi, obj.TenNguoiDD, obj.DiaChiNguoiDD, obj.SDTNguoiDD, obj.EmailNguoiDD, obj.LienHeKhacNguoiDD, obj.ThoiLuongCaTuVan, obj.SoLuong, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_CaTuVanDN_Update(PortalConnect As String, obj As CMS_CaTuVanDNInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVanDN_Update", obj.ID, obj.IdCaTuVan, obj.TenDoanhNghiep, obj.MST, obj.DiaChi, obj.TenNguoiDD, obj.DiaChiNguoiDD, obj.SDTNguoiDD, obj.EmailNguoiDD, obj.LienHeKhacNguoiDD, obj.ThoiLuongCaTuVan, obj.SoLuong, obj.MoTa, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_CaTuVanDN_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_CaTuVanDN_Delete", iD)
    End Sub
#End Region
#Region "CMS_ChuDe"
    Public Overrides Function CMS_ChuDe_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ChuDe_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_ChuDe_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ChuDe_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_ChuDe_Add(PortalConnect As String, obj As CMS_ChuDeInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_ChuDe_Add", obj.UserName, obj.NoiDung, obj.FileURL, obj.SoLike, obj.SoShare, obj.SoBinhLuan, obj.LoaiChuDe, obj.IsReport, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_ChuDe_Update(PortalConnect As String, obj As CMS_ChuDeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ChuDe_Update", obj.Id, obj.UserName, obj.NoiDung, obj.FileURL, obj.SoLike, obj.SoShare, obj.SoBinhLuan, obj.LoaiChuDe, obj.IsReport, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_ChuDe_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ChuDe_Delete", id)
    End Sub
    Public Overrides Sub CMS_ChuDe_Update_Quick(PortalConnect As String, id As Integer, isActive As Boolean, isLoai As Integer, userName As String)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ChuDe_Update_Quick", id, isActive, isLoai, userName)
    End Sub
#End Region
#Region "CMS_ChuDe_BinhLuan"
    Public Overrides Function CMS_ChuDe_BinhLuan_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ChuDe_BinhLuan_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_ChuDe_BinhLuan_List_Search(PortalConnect As String, idChuDe As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_ChuDe_BinhLuan_List_Search", idChuDe, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_ChuDe_BinhLuan_Add(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_ChuDe_BinhLuan_Add", obj.IdChuDe, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_ChuDe_BinhLuan_Update(PortalConnect As String, obj As CMS_ChuDe_BinhLuanInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ChuDe_BinhLuan_Update", obj.Id, obj.IdChuDe, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_ChuDe_BinhLuan_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_ChuDe_BinhLuan_Delete", id)
    End Sub
#End Region
#Region "CMS_VanPhongGD"
    Public Overrides Function CMS_VanPhongGD_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_VanPhongGD_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_VanPhongGD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_VanPhongGD_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_VanPhongGD_Add(PortalConnect As String, obj As CMS_VanPhongGDInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_VanPhongGD_Add", obj.TenVanPhong, obj.DiaChi, obj.SoDienThoai, obj.Email, obj.LichLamViec, obj.MoTa, obj.FileDinhKem, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_VanPhongGD_Update(PortalConnect As String, obj As CMS_VanPhongGDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_VanPhongGD_Update", obj.Id, obj.TenVanPhong, obj.DiaChi, obj.SoDienThoai, obj.Email, obj.LichLamViec, obj.MoTa, obj.FileDinhKem, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_VanPhongGD_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_VanPhongGD_Delete", id)
    End Sub
#End Region
#Region "DTNGHE_Diem"
    Public Overrides Function DTNGHE_Diem_Get(maDiem As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_Diem_Get", maDiem), IDataReader)
    End Function
    Public Overrides Function DTNGHE_Diem_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_Diem_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_Diem_ListByHocVien(hvID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_Diem_ListByHocVien", hvID), IDataReader)
    End Function
    Public Overrides Function DTNGHE_Diem_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_Diem_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DTNGHE_Diem_Add(obj As DTNGHE_DiemInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_Diem_Add", obj.MaHocVien, obj.MonHoc, obj.DiemSo, obj.GhiChu, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub DTNGHE_Diem_Update(obj As DTNGHE_DiemInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_Diem_Update", obj.ID, obj.MaHocVien, obj.MonHoc, obj.DiemSo, obj.GhiChu, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub DTNGHE_Diem_Delete(maDiem As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_Diem_Delete", maDiem)
    End Sub
    Public Overrides Sub DTNGHE_Diem_Update_Quick(maDiem As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_Diem_Update_Quick", maDiem, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_HocVien"
    Public Overrides Function DTNGHE_HocVien_Get(maHocVien As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_HocVien_Get", maHocVien), IDataReader)
    End Function
    Public Overrides Function DTNGHE_HocVien_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_HocVien_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_HocVien_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_HocVien_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function


    Public Overrides Function DTNGHE_HocVien_Add(obj As DTNGHE_HocVienInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_HocVien_Add", obj.MaHocVien, obj.HoTen, obj.NgaySinh, obj.SoDienThoai, obj.MaLopHoc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.SoCCCD, obj.Email, obj.GioiTinh, obj.DiaChi, obj.TrinhDoHocVan, obj.TrinhDoChuyenMon, obj.NgheDaoTaoHV, obj.ThoiGianDaoTaoHV, obj.NgayKhaiGiang, obj.KetQuaDaoTao, obj.GhiChu), Integer)
    End Function
    Public Overrides Sub DTNGHE_HocVien_Update(obj As DTNGHE_HocVienInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_HocVien_Update", obj.ID, obj.MaHocVien, obj.HoTen, obj.NgaySinh, obj.SoDienThoai, obj.MaLopHoc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.SoCCCD, obj.Email, obj.GioiTinh, obj.DiaChi, obj.TrinhDoHocVan, obj.TrinhDoChuyenMon, obj.NgheDaoTaoHV, obj.ThoiGianDaoTaoHV, obj.NgayKhaiGiang, obj.KetQuaDaoTao, obj.GhiChu)
    End Sub
    Public Overrides Sub DTNGHE_HocVien_Delete(maHocVien As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_HocVien_Delete", maHocVien)
    End Sub
    Public Overrides Sub DTNGHE_HocVien_Update_Quick(maHocVien As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_HocVien_Update_Quick", maHocVien, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_LopHoc"
    Public Overrides Function DTNGHE_LopHoc_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_LopHoc_Get", iD), IDataReader)
    End Function
    Public Overrides Function DTNGHE_LopHoc_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_LopHoc_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_LopHoc_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_LopHoc_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DTNGHE_LopHoc_Add(obj As DTNGHE_LopHocInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_LopHoc_Add", obj.MaLopHoc, obj.TenLopHoc, obj.NgheDaoTao, obj.NgayKhaiGiang, obj.NgayKetThuc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.TenGiangVien, obj.ThongTinLienHeGV, obj.DiaDiemHoc, obj.DonViChuTri, obj.ThoiGianDaoTao, obj.KinhPhi, obj.SoLuongToiDa, obj.TrangThai, obj.GhiChu), Integer)
    End Function
    Public Overrides Sub DTNGHE_LopHoc_Update(obj As DTNGHE_LopHocInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_LopHoc_Update", obj.ID, obj.MaLopHoc, obj.TenLopHoc, obj.NgheDaoTao, obj.NgayKhaiGiang, obj.NgayKetThuc, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.TenGiangVien, obj.ThongTinLienHeGV, obj.DiaDiemHoc, obj.DonViChuTri, obj.ThoiGianDaoTao, obj.KinhPhi, obj.SoLuongToiDa, obj.TrangThai, obj.GhiChu)
    End Sub
    Public Overrides Sub DTNGHE_LopHoc_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_LopHoc_Delete", iD)
    End Sub
    Public Overrides Sub DTNGHE_LopHoc_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_LopHoc_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_NgheDaoTao"
    Public Overrides Function DTNGHE_NgheDaoTao_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_Get", iD), IDataReader)
    End Function
    Public Overrides Function DTNGHE_NgheDaoTao_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_NgheDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DTNGHE_NgheDaoTao_Add(obj As DTNGHE_NgheDaoTaoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_Add", obj.Code, obj.Name, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub DTNGHE_NgheDaoTao_Update(obj As DTNGHE_NgheDaoTaoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_Update", obj.ID, obj.Code, obj.Name, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub DTNGHE_NgheDaoTao_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_Delete", iD)
    End Sub
    Public Overrides Sub DTNGHE_NgheDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_NgheDaoTao_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_ThoiGianDaoTao"
    Public Overrides Function DTNGHE_ThoiGianDaoTao_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_Get", iD), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThoiGianDaoTao_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThoiGianDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DTNGHE_ThoiGianDaoTao_Add(obj As DTNGHE_ThoiGianDaoTaoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_Add", obj.Code, obj.Name, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub DTNGHE_ThoiGianDaoTao_Update(obj As DTNGHE_ThoiGianDaoTaoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_Update", obj.ID, obj.Code, obj.Name, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub DTNGHE_ThoiGianDaoTao_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_Delete", iD)
    End Sub
    Public Overrides Sub DTNGHE_ThoiGianDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_ThoiGianDaoTao_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region
#Region "DTNGHE_KetQuaDaoTao"
    Public Overrides Function DTNGHE_KetQuaDaoTao_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_Get", iD), IDataReader)
    End Function
    Public Overrides Function DTNGHE_KetQuaDaoTao_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_List"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_KetQuaDaoTao_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DTNGHE_KetQuaDaoTao_Add(obj As DTNGHE_KetQuaDaoTaoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_Add", obj.Code, obj.Name, obj.IsOrder, obj.IsActive), Integer)
    End Function
    Public Overrides Sub DTNGHE_KetQuaDaoTao_Update(obj As DTNGHE_KetQuaDaoTaoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_Update", obj.ID, obj.Code, obj.Name, obj.IsOrder, obj.IsActive)
    End Sub
    Public Overrides Sub DTNGHE_KetQuaDaoTao_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_Delete", iD)
    End Sub
    Public Overrides Sub DTNGHE_KetQuaDaoTao_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "DTNGHE_KetQuaDaoTao_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region

#Region "DTNGHE_BAOCAO"
    Public Overrides Function DTNGHE_ThongKe_LopHoc_TheoNghe() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_LopHoc_TheoNghe"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_LopHoc_TheoThoiGian() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_LopHoc_TheoThoiGian"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_HocVien_TheoKetQua() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_HocVien_TheoKetQua"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_HocVien_TheoNghe() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_HocVien_TheoNghe"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_HocVien_TheoThoiGian() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_HocVien_TheoThoiGian"), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang", viewType, year, month), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_HocVien_TheoNgayKhaiGiang(viewType As String, year As Integer, month As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_HocVien_TheoNgayKhaiGiang", viewType, year, month), IDataReader)
    End Function
    Public Overrides Function DTNGHE_ThongKe_LichHen() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "DTNGHE_ThongKe_LichHen"), IDataReader)
    End Function
#End Region

#Region "SVL_BAOCAO"
    Public Overrides Function SVL_ThongKe_DN_TheoNghe(PhienGD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "SVL_ThongKe_DN_TheoNghe", PhienGD_ID), IDataReader)
    End Function
    Public Overrides Function SVL_ThongKe_DN_TheoQuyMo(PhienGD_ID As String, QuyMo_ID As Int16) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SVL_ThongKe_DN_TheoQuyMo", PhienGD_ID, QuyMo_ID)
    End Function
    Public Overrides Function SVL_ThongKe_NLD_TheoNhuCauVL(PhienGD_ID As String, NhuCau_ID As Int16) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.WorkConnect, "SVL_ThongKe_NLD_TheoNhuCauVL", PhienGD_ID, NhuCau_ID)
    End Function
#End Region
#Region "CMS_LichHen"
    Public Overrides Function CMS_LichHen_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LichHen_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_LichHen_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LichHen_List"), IDataReader)
    End Function
    Public Overrides Function CMS_LichHen_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_LichHen_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_LichHen_Add(obj As CMS_LichHenInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_LichHen_Add", obj.HoVaTen, obj.SoDienThoai, obj.ViTri, obj.NgayPhongVan, obj.GioPhongVan, obj.GoogleMeeting, obj.HinhThuc, obj.MoTa, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_LichHen_Update(obj As CMS_LichHenInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_LichHen_Update", obj.ID, obj.HoVaTen, obj.SoDienThoai, obj.ViTri, obj.NgayPhongVan, obj.GioPhongVan, obj.GoogleMeeting, obj.HinhThuc, obj.MoTa, obj.TrangThai, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_LichHen_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "CMS_LichHen_Delete", iD)
    End Sub
#End Region
#Region "CMS_JobFollow"
    Public Overrides Function CMS_JobFollow_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "CMS_JobFollow_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_JobFollow_Add(obj As CMS_JobFollowInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "CMS_JobFollow_Add", obj.Business_ID, obj.Business_Vn, obj.Business_En, obj.Business_Sort, obj.TinhTP, obj.QuanHuyen, obj.Mobile, obj.Email, obj.Address, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function

#End Region
#Region "XKL_DangKy"
    Public Overrides Function XKL_DangKy_Get(iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "XKL_DangKy_Get", iD), IDataReader)
    End Function
    Public Overrides Function XKL_DangKy_List() As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "XKL_DangKy_List"), IDataReader)
    End Function
    Public Overrides Function XKL_DangKy_List_Search(search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, YearId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect, "XKL_DangKy_List_Search", search, isOrder, currPage, recodperpage, UserName, YearId), IDataReader)
    End Function

    Public Overrides Function XKL_DangKy_Add(obj As XKL_DangKyInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.WorkConnect, "XKL_DangKy_Add", obj.QuocGia, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.CCCD, obj.NgayCap, obj.NoiCap, obj.DanToc, obj.LoaiDT_XS, obj.LoaiDT_CS, obj.LoaiDT_Khac, obj.LoaiDT_Khac_Txt, obj.TDVH, obj.TayNghe, obj.SoThangLamViec, obj.BangCap, obj.NgheNghiep, obj.TinhTP, obj.PhuongXa, obj.ThonTo, obj.DiaChi, obj.DienThoai, obj.DienThoai_Khac, obj.Email, obj.ChieuCao, obj.CanNang, obj.MuMau, obj.ThiLuc_1, obj.ThiLuc_2, obj.ThuanTay_1, obj.ThuanTay_2, obj.VetXamTro, obj.TinhTrangHonNhan, obj.Cha_HoTen, obj.Cha_Tuoi, obj.Cha_NgheNghiep, obj.Me_HoTen, obj.Me_Tuoi, obj.Me_NgheNghiep, obj.GhiChu, obj.SignDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId), Integer)
    End Function
    Public Overrides Sub XKL_DangKy_Update(obj As XKL_DangKyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "XKL_DangKy_Update", obj.ID, obj.QuocGia, obj.HoTen, obj.NgaySinh, obj.GioiTinh, obj.CCCD, obj.NgayCap, obj.NoiCap, obj.DanToc, obj.LoaiDT_XS, obj.LoaiDT_CS, obj.LoaiDT_Khac, obj.LoaiDT_Khac_Txt, obj.TDVH, obj.TayNghe, obj.SoThangLamViec, obj.BangCap, obj.NgheNghiep, obj.TinhTP, obj.PhuongXa, obj.ThonTo, obj.DiaChi, obj.DienThoai, obj.DienThoai_Khac, obj.Email, obj.ChieuCao, obj.CanNang, obj.MuMau, obj.ThiLuc_1, obj.ThiLuc_2, obj.ThuanTay_1, obj.ThuanTay_2, obj.VetXamTro, obj.TinhTrangHonNhan, obj.Cha_HoTen, obj.Cha_Tuoi, obj.Cha_NgheNghiep, obj.Me_HoTen, obj.Me_Tuoi, obj.Me_NgheNghiep, obj.GhiChu, obj.SignDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.YearId)
    End Sub
    Public Overrides Sub XKL_DangKy_Delete(iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "XKL_DangKy_Delete", iD)
    End Sub
    Public Overrides Sub XKL_DangKy_Update_Quick(iD As Integer, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.WorkConnect, "XKL_DangKy_Update_Quick", iD, isActive, isOrder)
    End Sub
#End Region



End Class

