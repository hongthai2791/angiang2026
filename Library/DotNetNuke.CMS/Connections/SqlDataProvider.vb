Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
    Inherits DataProvider
#Region "CMS_Advertise"
    Public Overrides Function CMS_Advertise_Get_By_Category(PortalConnect As String, PageLoca_ID As String, CategoryID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_Get_By_Category", PageLoca_ID, CategoryID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_Get", advertise_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, pageLocaID As String, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_List_Home", PortalID, pageLocaID, Top), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Advertise_Update_Quick", advertise_ID, isActive, isOrder)
    End Sub
    Public Overrides Function CMS_Advertise_Get_By_CMS_PageLoca(PortalConnect As String, pageLoca_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_Get_By_CMS_PageLoca", pageLoca_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Search(PortalConnect As String, portalID As Integer, isLang As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, pageLoca_ID As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Advertise_List_Search", portalID, isLang, search, isOrder, currPage, recodperpage, pageLoca_ID, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Advertise_Add", obj.Advertise_ID, obj.Advertise_Name, obj.ImgType, obj.Images, obj.IsWith, obj.IsHeight, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsLang, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.PageLoca_ID, obj.PortalID, obj.CategoryID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Advertise_Update", obj.Advertise_ID, obj.Advertise_Name, obj.ImgType, obj.Images, obj.IsWith, obj.IsHeight, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsLang, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.PageLoca_ID, obj.PortalID, obj.CategoryID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Advertise_Delete", advertise_ID)
    End Sub
#End Region
#Region "CMS_Authors"
    Public Overrides Function CMS_Authors_Get(PortalConnect As String, authors_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Authors_Get", authors_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Authors_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Authors_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Authors_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Authors_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_Authors_Add(PortalConnect As String, obj As CMS_AuthorsInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Authors_Add", obj.Authors_ID, obj.PenName, obj.FullName, obj.Indentify, obj.BirthDay, obj.Address, obj.Email, obj.Phone, obj.Regions, obj.PortalID, flReg.GetNull(obj.RegisterUser), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, flReg.GetNull(obj.TenTK), flReg.GetNull(obj.SoTK), flReg.GetNull(obj.DiaChiCN), flReg.GetNull(obj.NganHang))
    End Sub
    Public Overrides Sub CMS_Authors_Update(PortalConnect As String, obj As CMS_AuthorsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Authors_Update", obj.Authors_ID, obj.PenName, obj.FullName, obj.Indentify, obj.BirthDay, obj.Address, obj.Email, obj.Phone, obj.Regions, obj.PortalID, flReg.GetNull(obj.RegisterUser), flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, flReg.GetNull(obj.TenTK), flReg.GetNull(obj.SoTK), flReg.GetNull(obj.DiaChiCN), flReg.GetNull(obj.NganHang))
    End Sub
    Public Overrides Sub CMS_Authors_Delete(PortalConnect As String, authors_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Authors_Delete", authors_ID)
    End Sub
#End Region
#Region "CMS_ConfigSystem"
    Public Overrides Function CMS_ConfigSystem_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ConfigSystem_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_ConfigSystem_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ConfigSystem_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_ConfigSystem_Get_PortalID(PortalConnect As String, PortalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ConfigSystem_Get_PortalID", PortalID), IDataReader)
    End Function
    Public Overrides Sub CMS_ConfigSystem_Add(PortalConnect As String, obj As CMS_ConfigSystemInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_ConfigSystem_Add", obj.ID, obj.PortalID, obj.IsCMS, obj.IsLive, obj.LiveTitle, obj.LiveUrl, obj.LiveDes, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.SiteMap, obj.IpPublic, flReg.GetNull(obj.Analytics), obj.UpdatedBy, obj.UpdateName, obj.SendView)
    End Sub
    Public Overrides Sub CMS_ConfigSystem_Update(PortalConnect As String, obj As CMS_ConfigSystemInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_ConfigSystem_Update", obj.ID, obj.PortalID, obj.IsCMS, obj.IsLive, obj.LiveTitle, obj.LiveUrl, obj.LiveDes, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.SiteMap, obj.IpPublic, flReg.GetNull(obj.Analytics), obj.UpdatedBy, obj.UpdateName, obj.SendView)
    End Sub
    Public Overrides Sub CMS_ConfigSystem_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_ConfigSystem_Delete", iD)
    End Sub
#End Region
#Region "CMS_DocField"
    Public Overrides Function CMS_DocField_Get(PortalConnect As String, docField_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocField_Get", docField_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DocField_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocField_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DocField_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocField_List_Search", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_DocField_Add(PortalConnect As String, obj As CMS_DocFieldInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_DocField_Add", obj.DocField_ID, obj.DocField_Name, obj.DocField_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocField_Update(PortalConnect As String, obj As CMS_DocFieldInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocField_Update", obj.DocField_ID, obj.DocField_Name, obj.DocField_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocField_Delete(PortalConnect As String, docField_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocField_Delete", docField_ID)
    End Sub
#End Region
#Region "CMS_DocUnit"
    Public Overrides Function CMS_DocUnit_Get(PortalConnect As String, DocUnit_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocUnit_Get", DocUnit_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DocUnit_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocUnit_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DocUnit_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocUnit_List_Search", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_DocUnit_Add(PortalConnect As String, obj As CMS_DocUnitInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_DocUnit_Add", obj.DocUnit_ID, obj.DocUnit_Name, obj.DocUnit_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocUnit_Update(PortalConnect As String, obj As CMS_DocUnitInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocUnit_Update", obj.DocUnit_ID, obj.DocUnit_Name, obj.DocUnit_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocUnit_Delete(PortalConnect As String, DocUnit_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocUnit_Delete", DocUnit_ID)
    End Sub
#End Region
#Region "CMS_DocType"
    Public Overrides Function CMS_DocType_Get(PortalConnect As String, docType_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocType_Get", docType_ID), IDataReader)
    End Function
    Public Overrides Function CMS_DocType_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocType_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_DocType_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocType_List_Search", search, isOrder, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_DocType_Add(PortalConnect As String, obj As CMS_DocTypeInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_DocType_Add", obj.DocType_ID, obj.DocType_Name, obj.DocType_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocType_Update(PortalConnect As String, obj As CMS_DocTypeInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocType_Update", obj.DocType_ID, obj.DocType_Name, obj.DocType_Des, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocType_Delete(PortalConnect As String, docType_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocType_Delete", docType_ID)
    End Sub
#End Region
#Region "CMS_Document"
    Public Overrides Function CMS_Document_Get(PortalConnect As String, document_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Document_Get", document_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Document_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Document_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Document_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, docGroup_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Document_List_Search", search, isOrder, currPage, recodperpage, docType_ID, docField_ID, docGroup_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Document_List_Home(PortalConnect As String, search As String, docType_ID As String, docFiled_ID As String, docUnit_ID As String, docGroup_ID As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Document_List_Home", search, docType_ID, docFiled_ID, docUnit_ID, docGroup_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Sub CMS_Document_Add(PortalConnect As String, obj As CMS_DocumentInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Document_Add", obj.Document_ID, obj.Document_Name, obj.DocType_ID, obj.DocField_ID, obj.DocGroup_ID, obj.DocUnit_ID, obj.DocUnit_Name, obj.Contents, obj.NoCode, obj.SignerName, flReg.GetNull(obj.PromDate), obj.EffectDate, flReg.GetNull(obj.EndDate), obj.FileName, obj.FileSource, obj.IsURL, obj.IsDownload, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Document_Update(PortalConnect As String, obj As CMS_DocumentInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Document_Update", obj.Document_ID, obj.Document_Name, obj.DocType_ID, obj.DocField_ID, obj.DocGroup_ID, obj.DocUnit_ID, obj.DocUnit_Name, obj.Contents, obj.NoCode, obj.SignerName, flReg.GetNull(obj.PromDate), obj.EffectDate, flReg.GetNull(obj.EndDate), obj.FileName, obj.FileSource, obj.IsURL, obj.IsDownload, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Document_Update_IsDownload(PortalConnect As String, document_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Document_Update_IsDownload", document_ID)
    End Sub
    Public Overrides Sub CMS_Document_Update_IsActive(PortalConnect As String, document_ID As String, IsActive As Boolean, UpdatedBy As DateTime, UpdateName As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Document_Update_IsActive", document_ID, IsActive, UpdatedBy, UpdateName)
    End Sub
    Public Overrides Sub CMS_Document_Delete(PortalConnect As String, document_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Document_Delete", document_ID)
    End Sub
    Public Overrides Function CMS_Document_ListCheck_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, docType_ID As String, docField_ID As String, isActive As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Document_ListCheck_Search", search, isOrder, currPage, recodperpage, docType_ID, docField_ID, isActive), IDataReader)
    End Function
#End Region
#Region "CMS_DocGroup"
    Public Overrides Function CMS_DocGroup_List_Parent_NULL(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocGroup_List_Parent_NULL"), IDataReader)
    End Function
    Public Overrides Function CMS_DocGroup_Get(PortalConnect As String, docGroupID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocGroup_Get", docGroupID), IDataReader)
    End Function
    Public Overrides Function CMS_DocGroup_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocGroup_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_DocGroup_Add(PortalConnect As String, obj As CMS_DocGroupInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_DocGroup_Add", obj.DocGroupID, obj.DocGroup_Name, obj.DocGroup_Des, flReg.GetNull(obj.ParentID), obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_DocGroup_Update(PortalConnect As String, obj As CMS_DocGroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocGroup_Update", obj.DocGroupID, obj.DocGroup_Name, obj.DocGroup_Des, flReg.GetNull(obj.ParentID), obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdateName, obj.PortalID)
    End Sub
    Public Overrides Function CMS_DocGroup_Get_By_CMS_DocGroup(PortalConnect As String, docGroupID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DocGroup_Get_By_CMS_DocGroup", docGroupID), IDataReader)
    End Function
    Public Overrides Sub CMS_DocGroup_Delete_By_CMS_DocGroup(PortalConnect As String, docGroupID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocGroup_Delete_By_CMS_DocGroup", docGroupID)
    End Sub
    Public Overrides Sub CMS_DocGroup_Delete(PortalConnect As String, docGroupID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DocGroup_Delete", docGroupID)
    End Sub
#End Region
#Region "CMS_Events"
    Public Overrides Function CMS_Events_Get(PortalConnect As String, event_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Events_Get", event_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Events_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Events_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Events_Add(PortalConnect As String, obj As CMS_EventsInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Events_Add", obj.Event_ID, obj.EventName, obj.Provinder_ID, obj.BossName, obj.Contents, obj.StartDate, flReg.GetNull(obj.EndDate), obj.Address, obj.OwnerName, obj.OtherUser, obj.Important, obj.IsSMS, obj.IsMail, obj.IsMobile, obj.SendTime, obj.IsRepeat, obj.RepeatMonth, obj.RepeatDay, flReg.GetNull(obj.StartRepeat), flReg.GetNull(obj.EndRepeat), obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.IsLang, obj.PortalID, flReg.GetNull(obj.LeaderName))
    End Sub
    Public Overrides Sub CMS_Events_Update(PortalConnect As String, obj As CMS_EventsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Events_Update", obj.Event_ID, obj.EventName, obj.Provinder_ID, obj.BossName, obj.Contents, obj.StartDate, flReg.GetNull(obj.EndDate), obj.Address, obj.OwnerName, obj.OtherUser, obj.Important, obj.IsSMS, obj.IsMail, obj.IsMobile, obj.SendTime, obj.IsRepeat, obj.RepeatMonth, obj.RepeatDay, flReg.GetNull(obj.StartRepeat), flReg.GetNull(obj.EndRepeat), obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.IsLang, obj.PortalID, flReg.GetNull(obj.LeaderName))
    End Sub
    Public Overrides Sub CMS_Events_Delete(PortalConnect As String, event_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Events_Delete", event_ID)
    End Sub
#End Region
#Region "CMS_Field"
    Public Overrides Function CMS_Field_Get(PortalConnect As String, field_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Field_Get", field_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Field_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Field_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Field_Add(PortalConnect As String, obj As CMS_FieldInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Field_Add", obj.Field_ID, obj.FieldName, obj.FieldDes, obj.IsOrder, obj.IsActive, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Field_Update(PortalConnect As String, obj As CMS_FieldInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Field_Update", obj.Field_ID, obj.FieldName, obj.FieldDes, obj.IsOrder, obj.IsActive, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Field_Delete(PortalConnect As String, field_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Field_Delete", field_ID)
    End Sub
#End Region
#Region "CMS_NewsPapers"
    Public Overrides Function CMS_NewsPapers_Get(PortalConnect As String, newsPapers_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsPapers_Get", newsPapers_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsPapers_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsPapers_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_NewsPapers_Add(PortalConnect As String, obj As CMS_NewsPapersInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsPapers_Add", obj.NewsPapers_ID, obj.NewsPapers_Number, obj.Category_ID, obj.PublicDate, obj.ImagePath, obj.IsYear, obj.IsPublic, obj.CreateDate, obj.UserName, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsPapers_Update(PortalConnect As String, obj As CMS_NewsPapersInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsPapers_Update", obj.NewsPapers_ID, obj.NewsPapers_Number, obj.Category_ID, obj.PublicDate, obj.ImagePath, obj.IsYear, obj.IsPublic, obj.CreateDate, obj.UserName, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsPapers_Delete(PortalConnect As String, newsPapers_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsPapers_Delete", newsPapers_ID)
    End Sub
#End Region
#Region "CMS_NewsPapersD"
    Public Overrides Function CMS_NewsPapersD_Get(PortalConnect As String, newsPapersD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsPapersD_Get", newsPapersD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsPapersD_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsPapersD_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_NewsPapersD_Add(PortalConnect As String, obj As CMS_NewsPapersDInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsPapersD_Add", obj.NewsPapersD_ID, obj.NewsPapers_ID, obj.PageNumber, obj.PhotoPath, obj.PhotoDes, obj.CreateDate, obj.UserName, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsPapersD_Update(PortalConnect As String, obj As CMS_NewsPapersDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsPapersD_Update", obj.NewsPapersD_ID, obj.NewsPapers_ID, obj.PageNumber, obj.PhotoPath, obj.PhotoDes, obj.CreateDate, obj.UserName, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Function CMS_NewsPapersD_Get_By_CMS_NewsPapers(PortalConnect As String, newsPapers_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsPapersD_Get_By_CMS_NewsPapers", newsPapers_ID), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsPapersD_Delete(PortalConnect As String, newsPapersD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsPapersD_Delete", newsPapersD_ID)
    End Sub
#End Region
#Region "CMS_NewsRoy"
    Public Overrides Function CMS_NewsRoy_Get(PortalConnect As String, newsRoy_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsRoy_Get", newsRoy_ID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsRoy_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsRoy_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_NewsRoy_Add(PortalConnect As String, obj As CMS_NewsRoyInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsRoy_Add", obj.NewsRoy_ID, obj.NewsID, obj.AuthorName, obj.IsMoney, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_NewsRoy_Update(PortalConnect As String, obj As CMS_NewsRoyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsRoy_Update", obj.NewsRoy_ID, obj.NewsID, obj.AuthorName, obj.IsMoney, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate)
    End Sub
    Public Overrides Function CMS_NewsRoy_Get_By_CMS_News(PortalConnect As String, newId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsRoy_Get_By_CMS_News", newId), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsRoy_Delete(PortalConnect As String, newsRoy_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsRoy_Delete", newsRoy_ID)
    End Sub
#End Region
#Region "CMS_Notify"
    Public Overrides Function CMS_Notify_Get(PortalConnect As String, notify_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Notify_Get", notify_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Notify_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Notify_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_Notify_Add(PortalConnect As String, obj As CMS_NotifyInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Notify_Add", obj.Notify_ID, obj.Notify_Name, obj.Provinder_ID, obj.Files_Name, obj.Files_Attch, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsActive, obj.IsPublicAll, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Notify_Update(PortalConnect As String, obj As CMS_NotifyInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Notify_Update", obj.Notify_ID, obj.Notify_Name, obj.Provinder_ID, obj.Files_Name, obj.Files_Attch, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsActive, obj.IsPublicAll, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate)
    End Sub
    Public Overrides Sub CMS_Notify_Delete(PortalConnect As String, notify_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Notify_Delete", notify_ID)
    End Sub
#End Region
#Region "CMS_PageLocal"
    Public Overrides Function CMS_PageLocal_Get(PortalConnect As String, pageLocalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_PageLocal_Get", pageLocalID), IDataReader)
    End Function
    Public Overrides Function CMS_PageLocal_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_PageLocal_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_PageLocal_Add(PortalConnect As String, obj As CMS_PageLocalInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_PageLocal_Add", obj.PageLocalID, obj.PageLocal_Name, obj.IsOrder, flReg.GetNull(obj.ImagePath))
    End Sub
    Public Overrides Sub CMS_PageLocal_Update(PortalConnect As String, obj As CMS_PageLocalInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_PageLocal_Update", obj.PageLocalID, obj.PageLocal_Name, obj.IsOrder, flReg.GetNull(obj.ImagePath))
    End Sub
    Public Overrides Sub CMS_PageLocal_Delete(PortalConnect As String, pageLocalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_PageLocal_Delete", pageLocalID)
    End Sub
#End Region
#Region "CMS_PenName"
    Public Overrides Function CMS_PenName_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_PenName_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_PenName_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_PenName_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_PenName_Add(PortalConnect As String, obj As CMS_PenNameInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_PenName_Add", obj.Id, obj.UserName, obj.PenName, obj.IsActive, obj.CreateUser, obj.CreateDate, obj.UpdateUser, flReg.GetNull(obj.UpdateDate), obj.PortalID)
    End Sub
    Public Overrides Sub CMS_PenName_Update(PortalConnect As String, obj As CMS_PenNameInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_PenName_Update", obj.Id, obj.UserName, obj.PenName, obj.IsActive, obj.CreateUser, obj.CreateDate, obj.UpdateUser, flReg.GetNull(obj.UpdateDate), obj.PortalID)
    End Sub
    Public Overrides Sub CMS_PenName_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_PenName_Delete", id)
    End Sub
#End Region
#Region "CMS_Setups"
    Public Overrides Function CMS_Setups_Get(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Setups_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_Setups_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Setups_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Setups_Get_By_Name(PortalConnect As String, settingName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Setups_Get_By_Name", settingName), IDataReader)
    End Function
    Public Overrides Sub CMS_Setups_Add(PortalConnect As String, obj As CMS_SetupsInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Setups_Add", obj.ID, obj.SettingName, obj.SettingValue, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdatedUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Setups_Update(PortalConnect As String, obj As CMS_SetupsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Setups_Update", obj.ID, obj.SettingName, obj.SettingValue, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UpdatedUser, obj.PortalID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Setups_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Setups_Delete", iD)
    End Sub
#End Region
#Region "CMS_SiteMap"
    Public Overrides Function CMS_SiteMap_Get(PortalConnect As String, siteMap_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_SiteMap_Get", siteMap_ID), IDataReader)
    End Function
    Public Overrides Function CMS_SiteMap_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_SiteMap_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_SiteMap_Add(PortalConnect As String, obj As CMS_SiteMapInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_SiteMap_Add", obj.SiteMap_ID, obj.SiteMap_Name, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdateBy), flReg.GetNull(obj.UserUpdate), obj.IsOrder, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_SiteMap_Update(PortalConnect As String, obj As CMS_SiteMapInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_SiteMap_Update", obj.SiteMap_ID, obj.SiteMap_Name, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdateBy), flReg.GetNull(obj.UserUpdate), obj.IsOrder, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_SiteMap_Delete(PortalConnect As String, siteMap_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_SiteMap_Delete", siteMap_ID)
    End Sub
#End Region
#Region "CMS_Calendar"
    Public Overrides Function CMS_Calendar_Get(PortalConnect As String, calendar_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Calendar_Get", calendar_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Calendar_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Calendar_List", portalId), IDataReader)
    End Function

    Public Overrides Sub CMS_Calendar_Add(PortalConnect As String, obj As CMS_CalendarInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Calendar_Add", obj.Calendar_ID, obj.CalendarName, obj.Morning, obj.Night, obj.StartDate, flReg.GetNull(obj.EndDate), obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.IsLang, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Calendar_Update(PortalConnect As String, obj As CMS_CalendarInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Calendar_Update", obj.Calendar_ID, obj.CalendarName, obj.Morning, obj.Night, obj.StartDate, flReg.GetNull(obj.EndDate), obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.IsLang, obj.PortalID)
    End Sub
    Public Overrides Sub CMS_Calendar_Delete(PortalConnect As String, calendar_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Calendar_Delete", calendar_ID)
    End Sub
#End Region
#Region "CMS_Menu"
    Public Overrides Function CMS_Menu_Get(PortalConnect As String, menuID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Menu_Get", menuID), IDataReader)
    End Function
    Public Overrides Function CMS_Menu_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Menu_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Menu_Add(PortalConnect As String, obj As CMS_MenuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Menu_Add", obj.MenuName, obj.IsOrder, obj.PortalId), Integer)
    End Function
    Public Overrides Sub CMS_Menu_Update(PortalConnect As String, obj As CMS_MenuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Menu_Update", obj.MenuID, obj.MenuName, obj.IsOrder, obj.PortalId)
    End Sub
    Public Overrides Sub CMS_Menu_Delete(PortalConnect As String, menuID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Menu_Delete", menuID)
    End Sub
#End Region
#Region "CMS_MenuD"
    Public Overrides Function CMS_MenuD_Get(PortalConnect As String, menuD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_MenuD_Get", menuD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_MenuD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_MenuID(PortalConnect As String, menuID As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_MenuD_List_By_MenuID", menuID, portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_ParentID(PortalConnect As String, paID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_MenuD_List_By_ParentID", paID), IDataReader)
    End Function
    Public Overrides Sub CMS_MenuD_Update_Quick(PortalConnect As String, menuD_ID As String, parent_ID As String, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_MenuD_Update_Quick", menuD_ID, parent_ID, isOrder)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete_By_MenuID(PortalConnect As String, menu_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_MenuD_Delete_By_MenuID", menu_ID)
    End Sub
    Public Overrides Sub CMS_MenuD_Add(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_MenuD_Add", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Update(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_MenuD_Update", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete(PortalConnect As String, menuD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_MenuD_Delete", menuD_ID)
    End Sub
#End Region
#Region "CMS_Block"
    Public Overrides Function CMS_Block_Get_By_Key(PortalConnect As String, idkey As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Block_Get_By_Key", idkey), IDataReader)
    End Function

    Public Overrides Function CMS_Block_List_By_Flag(PortalConnect As String, flag As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Block_List_By_Flag", flag), IDataReader)
    End Function
#End Region
#Region "CMS_Contact"
    Public Overrides Function CMS_Contact_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Contact_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Contact_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Contact_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_Contact_Update_Status(PortalConnect As String, Optional id As Integer = 1, Optional status As Boolean = 1)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Contact_Update_Status", id, status)
    End Sub
    Public Overrides Function CMS_Contact_List_Search(PortalConnect As String, Search As String, PortalId As Integer, Status As Integer, PageSize As Integer, PageIndex As Integer, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Contact_List_Search", Search, PortalId, Status, PageSize, PageIndex, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_Contact_Add(PortalConnect As String, obj As CMS_ContactInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Contact_Add", obj.FullName, obj.Email, obj.Tel, obj.Address, obj.Subject, obj.Contents, obj.Status, obj.CreatedDate, obj.PortalId, obj.LanguageId), Integer)
    End Function
    Public Overrides Sub CMS_Contact_Update(PortalConnect As String, obj As CMS_ContactInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Contact_Update", obj.Id, obj.FullName, obj.Email, obj.Tel, obj.Address, obj.Subject, obj.Contents, obj.Status, obj.CreatedDate, obj.PortalId, obj.LanguageId)
    End Sub
    Public Overrides Sub CMS_Contact_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Contact_Delete", id)
    End Sub
#End Region
#Region "CMS_Departments"
    Public Overrides Function CMS_Departments_NguoiDung_Get_By_UserId(PortalConnect As String, UserId As String, PortalId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Get_By_UserId", UserId, PortalId)
    End Function
    Public Overrides Function CMS_Departments_GetByParentId(PortalConnect As String, PortalId As Integer, ParentId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_GetByParentId", PortalId, ParentId)
    End Function

    Public Overrides Function CMS_Departments_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Departments_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_List", PortalConnect), IDataReader)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_GetByNguoiDung(PortalConnect As String, Nguoidung As String, PortalId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_GetByNguoiDung", Nguoidung, PortalId)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_Get_ChucVu(PortalConnect As String, UserId As String, chucVu As String) As String
        Return SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Get_ChucVu", PortalConnect, UserId, chucVu)
    End Function
    Public Overrides Function CMS_Departments_Add(PortalConnect As String, obj As CMS_DepartmentsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Departments_Add", obj.TenPhongBan, flReg.GetNull(obj.ParentId), flReg.GetNull(obj.MoTa), obj.NguoiTao, obj.NgayTao, obj.IsActive, obj.OrderNumber, flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ModuleId), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.TenVietTat), flReg.GetNull(obj.LanguageId), obj.IsSub, obj.IsGroup, flReg.GetNull(obj.IsUrl)), Integer)
    End Function
    Public Overrides Sub CMS_Departments_Update(PortalConnect As String, obj As CMS_DepartmentsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_Update", obj.Id, obj.TenPhongBan, flReg.GetNull(obj.ParentId), flReg.GetNull(obj.MoTa), obj.NguoiTao, obj.NgayTao, obj.IsActive, obj.OrderNumber, flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ModuleId), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.TenVietTat), flReg.GetNull(obj.LanguageId), obj.IsSub, obj.IsGroup, flReg.GetNull(obj.IsUrl))
    End Sub
    Public Overrides Sub CMS_Departments_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_Delete", id)
    End Sub
#End Region
#Region "CMS_Departments_ChucVu"
    Public Overrides Function CMS_Departments_ChucVu_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_ChucVu_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Departments_ChucVu_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_ChucVu_List"), IDataReader)
    End Function

    Public Overrides Function CMS_Departments_ChucVu_Add(PortalConnect As String, obj As CMS_Departments_ChucVuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Departments_ChucVu_Add", obj.PhongBan, obj.ChucVu, obj.IsDefault), Integer)
    End Function
    Public Overrides Sub CMS_Departments_ChucVu_Update(PortalConnect As String, obj As CMS_Departments_ChucVuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_ChucVu_Update", obj.Id, obj.PhongBan, obj.ChucVu, obj.IsDefault)
    End Sub
    Public Overrides Sub CMS_Departments_ChucVu_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_ChucVu_Delete", id)
    End Sub
#End Region
#Region "CMS_Departments_NguoiDung"
    Public Overrides Function CMS_Departments_NguoiDung_List_UserID(PortalConnect As String, UserId As String, PortalId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_List_UserID", UserId, PortalId)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(PortalConnect As String, U_Id As String, DepartmentId As Integer, PortalId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId", U_Id, DepartmentId, PortalId)
    End Function
    Public Overrides Function CMS_Departments_NguoiDung_Add(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Add", obj.PhongBan, obj.ChucVu, obj.UserId, obj.LaNguoiKy, obj.LaNguoiNhanVB, obj.LaLanhDao, obj.PortalId), Integer)
    End Function
    Public Overrides Sub CMS_Departments_NguoiDung_Update(PortalConnect As String, obj As CMS_Departments_NguoiDungInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Update", obj.Id, obj.PhongBan, obj.ChucVu, obj.UserId, obj.LaNguoiKy, obj.LaNguoiNhanVB, obj.LaLanhDao, obj.PortalId)
    End Sub
    Public Overrides Sub CMS_Departments_NguoiDung_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Departments_NguoiDung_Delete", id)
    End Sub
#End Region
#Region "CMS_DMNhuanBut"
    Public Overrides Function CMS_DMNhuanBut_List_Search(PortalConnect As String, search As String, isOrder As Integer, Months As Integer, Years As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DMNhuanBut_List_Search", search, isOrder, Months, Years), IDataReader)
    End Function
    Public Overrides Function CMS_DMNhuanBut_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DMNhuanBut_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_DMNhuanBut_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DMNhuanBut_List"), IDataReader)
    End Function
    Public Overrides Function CMS_DMNhuanBut_Get_By_Type(PortalConnect As String, Type As Integer, Month As Integer, Year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DMNhuanBut_Get_By_Type", Type, Month, Year), IDataReader)
    End Function
    Public Overrides Function CMS_DMNhuanBut_Add(PortalConnect As String, obj As CMS_DMNhuanButInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_DMNhuanBut_Add", flReg.GetNull(obj.MaDM), flReg.GetNull(obj.HeSo), flReg.GetNull(obj.SoLuong), flReg.GetNull(obj.DonGia), flReg.GetNull(obj.Price), flReg.GetNull(obj.Description), flReg.GetNull(obj.Orders), flReg.GetNull(obj.Type), flReg.GetNull(obj.Active), flReg.GetNull(obj.Month), flReg.GetNull(obj.Year), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate)), Integer)
    End Function
    Public Overrides Sub CMS_DMNhuanBut_Update(PortalConnect As String, obj As CMS_DMNhuanButInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DMNhuanBut_Update", obj.ID, flReg.GetNull(obj.MaDM), flReg.GetNull(obj.HeSo), flReg.GetNull(obj.SoLuong), flReg.GetNull(obj.DonGia), flReg.GetNull(obj.Price), flReg.GetNull(obj.Description), flReg.GetNull(obj.Orders), flReg.GetNull(obj.Type), flReg.GetNull(obj.Active), flReg.GetNull(obj.Month), flReg.GetNull(obj.Year), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate))
    End Sub
    Public Overrides Sub CMS_DMNhuanBut_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_DMNhuanBut_Delete", iD)
    End Sub
#End Region
#Region "CMS_FAQ"
    Public Overrides Function CMS_FAQ_Get(PortalConnect As String, id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQ_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_FAQ_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQ_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_FAQ_Add(PortalConnect As String, obj As CMS_FAQInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_FAQ_Add", flReg.GetNull(obj.Name), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Image), flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), flReg.GetNull(obj.AnswerUserId), flReg.GetNull(obj.AnswerUserName), flReg.GetNull(obj.IsUserDefault), flReg.GetNull(obj.DefaultAnswerName), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.SendView)), Integer)
    End Function
    Public Overrides Sub CMS_FAQ_Update(PortalConnect As String, obj As CMS_FAQInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQ_Update", obj.Id, flReg.GetNull(obj.Name), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Image), flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), flReg.GetNull(obj.AnswerUserId), flReg.GetNull(obj.AnswerUserName), flReg.GetNull(obj.IsUserDefault), flReg.GetNull(obj.DefaultAnswerName), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.SendView))
    End Sub
    Public Overrides Sub CMS_FAQ_Delete(PortalConnect As String, id As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQ_Delete", id)
    End Sub
#End Region
#Region "CMS_FAQAnswers"
    Public Overrides Function CMS_FAQAnswers_Get(PortalConnect As String, id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQAnswers_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_FAQAnswers_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQAnswers_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_FAQAnswers_Add(PortalConnect As String, obj As CMS_FAQAnswersInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_FAQAnswers_Add", obj.QuestionID, flReg.GetNull(obj.Name), flReg.GetNull(obj.Title), flReg.GetNull(obj.Contents), flReg.GetNull(obj.FileAttach), flReg.GetNull(obj.SendDate), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.AnswerName), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.SendView)), Integer)
    End Function
    Public Overrides Sub CMS_FAQAnswers_Update(PortalConnect As String, obj As CMS_FAQAnswersInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQAnswers_Update", obj.Id, obj.QuestionID, flReg.GetNull(obj.Name), flReg.GetNull(obj.Title), flReg.GetNull(obj.Contents), flReg.GetNull(obj.FileAttach), flReg.GetNull(obj.SendDate), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.AnswerName), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.SendView))
    End Sub
    Public Overrides Sub CMS_FAQAnswers_Delete(PortalConnect As String, id As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQAnswers_Delete", id)
    End Sub
#End Region
#Region "CMS_FAQQuestions"
    Public Overrides Function CMS_FAQQuestions_Get(PortalConnect As String, id As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQQuestions_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_FAQQuestions_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQQuestions_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_FAQQuestions_List_Search(PortalConnect As String, search As String, fAQID As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_FAQQuestions_List_Search", search, isOrder, currPage, recodperpage, UserName, Status), IDataReader)
    End Function
    Public Overrides Function CMS_FAQQuestions_Add(PortalConnect As String, obj As CMS_FAQQuestionsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_FAQQuestions_Add", flReg.GetNull(obj.FAQID), flReg.GetNull(obj.Name), flReg.GetNull(obj.Contents), flReg.GetNull(obj.FileAttach), flReg.GetNull(obj.Adress), flReg.GetNull(obj.Email), flReg.GetNull(obj.Phone), flReg.GetNull(obj.SendDate), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser)), Integer)
    End Function
    Public Overrides Sub CMS_FAQQuestions_Update(PortalConnect As String, obj As CMS_FAQQuestionsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQQuestions_Update", obj.Id, flReg.GetNull(obj.FAQID), flReg.GetNull(obj.Name), flReg.GetNull(obj.Contents), flReg.GetNull(obj.FileAttach), flReg.GetNull(obj.Adress), flReg.GetNull(obj.Email), flReg.GetNull(obj.Phone), flReg.GetNull(obj.SendDate), flReg.GetNull(obj.Status), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.UpdateUser))
    End Sub
    Public Overrides Sub CMS_FAQQuestions_Update_Answer(PortalConnect As String, Id As Integer, ContentAnswer As String, AnswerName As String, AnswerUser As String, AnswerDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQQuestions_Update_Answer", Id, ContentAnswer, AnswerName, AnswerUser, AnswerDate)
    End Sub
    Public Overrides Sub CMS_FAQQuestions_Update_Status(PortalConnect As String, Id As Integer, Status As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQQuestions_Update_Status", Id, Status)
    End Sub
    Public Overrides Sub CMS_FAQQuestions_Delete(PortalConnect As String, id As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_FAQQuestions_Delete", id)
    End Sub
#End Region
#Region "CMS_Media"
    Public Overrides Function CMS_Media_List_Home(PortalConnect As String, PortalId As Integer, LanguageId As String, Id As String, type As Integer, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_List_Home", PortalId, LanguageId, Id, type, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Function CMS_Media_Search_Home(PortalConnect As String, PortalId As Integer, LanguageId As String, datefrom As Date, dateto As Date, key As String, categoryid As Integer, PageIndex As Integer, PageSize As Integer, arrPhongBan As String, uid As Integer, isImage As Boolean, type As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_Search_Home", PortalId, LanguageId, datefrom, dateto, key, categoryid, PageIndex, PageSize, arrPhongBan, uid, isImage, type), IDataReader)
    End Function
    Public Overrides Sub CMS_Media_Delete_Update(PortalConnect As String, IsDelete As Boolean, DeleteDate As Date, DeleteUser As String, Id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Media_Delete_Update", IsDelete, DeleteDate, DeleteUser, Id)
    End Sub
    Public Overrides Function CMS_Media_List_Search(PortalConnect As String, Status As Integer, UserName As String, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_List_Search", Status, UserName, PortalID, IsLang, categoryid, title, PageIndex, PageSize, Type, Flag, FromDate, ToDate), IDataReader)
    End Function
    Public Overrides Function CMS_Media_Admin_Search_Count(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_Admin_Search_Count", title, danhmuc, PortalId, UserName, Type, Flag, FromDate, ToDate)
    End Function
    Public Overrides Function CMS_Media_Admin_Search(PortalConnect As String, title As String, danhmuc As Integer, PortalId As Integer, TrangThai As Integer, PageIndex As Integer, PageSize As Integer, UserName As String, Type As Integer, Flag As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_Admin_Search", title, danhmuc, PortalId, TrangThai, PageIndex, PageSize, UserName, Type, Flag, FromDate, ToDate), IDataReader)
    End Function
    Public Overrides Sub CMS_Media_GuiDuyet(PortalConnect As String, id As Integer, Trangthai As Integer, UserId As String, DateUpdate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Media_Guiduyet", id, Trangthai, UserId, DateUpdate)
    End Sub
    Public Overrides Sub CMS_Media_Duyet(PortalConnect As String, id As Integer, Trangthai As Integer, DateUpdate As DateTime, UserAprrove As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Media_Duyet", id, Trangthai, DateUpdate, UserAprrove)
    End Sub
    Public Overrides Function CMS_Media_List_Select(PortalConnect As String, datefrom As Date, dateto As Date, title As String, danhmuc As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, Type As Integer, Settings As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_List_Select", datefrom, dateto, title, danhmuc, PortalId, PageIndex, PageSize, Type, Settings), IDataReader)
    End Function
    Public Overrides Function CMS_Media_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Media_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Media_Get_By_News_ID(PortalConnect As String, newsid As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Media_Get_By_News_ID", newsid)
    End Function
    Public Overrides Function CMS_Media_Add(PortalConnect As String, obj As CMS_MediaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Media_Add", obj.CategoryId, obj.Name, flReg.GetNull(obj.Summary), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.MediaUrl), flReg.GetNull(obj.Folders), flReg.GetNull(obj.Contents), flReg.GetNull(obj.ViewCount), flReg.GetNull(obj.Status), flReg.GetNull(obj.Type), flReg.GetNull(obj.IsYoutube), flReg.GetNull(obj.IsHot), flReg.GetNull(obj.IsFTP), flReg.GetNull(obj.Tags), flReg.GetNull(obj.Note), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), obj.STT, flReg.GetNull(obj.IsHome), flReg.GetNull(obj.IsPage), flReg.GetNull(obj.ToUrl), obj.SendView, obj.IsDelete, flReg.GetNull(obj.DeleteDate), flReg.GetNull(obj.DeleteUser), flReg.GetNull(obj.WriterName)), Integer)
    End Function
    Public Overrides Sub CMS_Media_Update(PortalConnect As String, obj As CMS_MediaInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Media_Update", obj.Id, obj.CategoryId, obj.Name, flReg.GetNull(obj.Summary), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.MediaUrl), flReg.GetNull(obj.Folders), flReg.GetNull(obj.Contents), flReg.GetNull(obj.ViewCount), flReg.GetNull(obj.Status), flReg.GetNull(obj.Type), flReg.GetNull(obj.IsYoutube), flReg.GetNull(obj.IsHot), flReg.GetNull(obj.IsFTP), flReg.GetNull(obj.Tags), flReg.GetNull(obj.Note), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.PublishedUser), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), obj.STT, flReg.GetNull(obj.IsHome), flReg.GetNull(obj.IsPage), flReg.GetNull(obj.ToUrl), obj.SendView, obj.IsDelete, flReg.GetNull(obj.DeleteDate), flReg.GetNull(obj.DeleteUser), flReg.GetNull(obj.WriterName))
    End Sub
    Public Overrides Sub CMS_Media_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Media_Delete", id)
    End Sub
#End Region
#Region "CMS_News"
    Public Overrides Function CMS_News_List_ToApp(PortalConnect As String, PortalID As Integer, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, isImages As Boolean, WBID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_ToApp", PortalID, categoryid, title, PageIndex, PageSize, Flag, fromDate, toDate, isImages, WBID), IDataReader)
    End Function

    Public Overrides Function CMS_News_List_MostView(PortalConnect As Integer, PortalId As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_MostView", PortalId, top), IDataReader)
    End Function
    Public Overrides Function CMS_News_Search_Home(PortalConnect As Integer, PortalId As Integer, tags As String, datefrom As Date, dateto As Date, categoryid As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean, key As String, advanced As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Search_Home", PortalId, tags, datefrom, dateto, categoryid, PageIndex, PageSize, isImage, key, advanced), IDataReader)
    End Function
    Public Overrides Function CMS_News_Search_HomeMobile(PortalConnect As Integer, PortalId As Integer, categoryid As Integer, PageIndex As Integer, PageSize As Integer, key As String, status As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Search_HomeMobile", PortalId, categoryid, PageIndex, PageSize, key, status), IDataReader)
    End Function
    Public Overrides Function CMS_News_HomeBlock(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_HomeBlock", PortalId, IsFlag, NewId, CategoryId, Top, IsImage), IDataReader)
    End Function
    Public Overrides Function CMS_News_HomeMobile(PortalConnect As String, PortalId As Integer, IsFlag As Integer, NewId As String, CategoryId As Integer, Top As Integer, IsImage As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_HomeMobile", PortalId, IsFlag, NewId, CategoryId, Top, IsImage), IDataReader)
    End Function
    Public Overrides Function CMS_News_SameCate(PortalConnect As String, PortalId As Integer, newid As Integer, catid As Integer, count As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_SameCate", PortalId, newid, catid, count), IDataReader)
    End Function
    Public Overrides Function CMS_Notification(PortalID As Integer, IsLang As String, Table As String, Status As Integer, isStep As Boolean, WfID As Integer, WF_RETURN As Integer, UserName As String, cateAll As Boolean) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.CmsConnect(PortalID), "CMS_Notification", PortalID, IsLang, Table, Status, isStep, WfID, WF_RETURN, UserName, cateAll)
    End Function
    Public Overrides Function CMS_News_List_UserName(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_UserName", PortalConnect), IDataReader)
    End Function
    Public Overrides Function CMS_News_ListAdmin_Count(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, UserName As String, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_ListAdmin_Count", title, categoryid, PortalId, LanguageId, UserName, isImage, IsActive, Flag, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Tags_Media(PortalConnect As String, NewID As Integer, Tags As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Update_Tags_Media", NewID, Tags)
    End Sub
    Public Overrides Function CMS_News_ListAdmin_Search(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_ListAdmin_Search", title, categoryid, PortalId, LanguageId, Status, UserName, PageIndex, PageSize, isImage, IsActive, Flag, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_News_ListAdmin_Progress(PortalConnect As String, title As String, categoryid As Integer, PortalId As Integer, LanguageId As String, Status As Integer, UserId As String, PageIndex As Integer, PageSize As Integer, isImage As Boolean, IsActive As Boolean, Flag As String, ToUrl As String, fromDate As DateTime, toDate As DateTime) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_ListAdmin_Progress", title, categoryid, PortalId, LanguageId, Status, UserId, PageIndex, PageSize, isImage, IsActive, Flag, ToUrl, fromDate, toDate), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_GetLink(PortalConnect As String, datefrom As DateTime, dateto As DateTime, title As String, categoryid As Integer, PortalId As Integer, Status As Integer, UserName As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_GetLink", datefrom, dateto, title, categoryid, PortalId, Status, UserName, PageIndex, PageSize), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Visible(PortalConnect As String, NewId As Integer, IsVisible As Boolean)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Update_Visible", NewId, IsVisible)
    End Sub
    Public Overrides Sub CMS_News_Update_IsMobile(PortalConnect As String, NewId As Integer, IsMobile As Boolean)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Update_IsMobile", NewId, IsMobile)
    End Sub
    Public Overrides Sub CMS_News_Update_Tags(PortalConnect As String, NewID As Integer, Tags As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Update_Tags", NewID, Tags)
    End Sub
    Public Overrides Function CMS_NewsByCategory_GetByNewsId(PortalConnect As String, PortalID As Integer, LanguageId As String, newsId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByCategory_GetByNewsId", PortalID, LanguageId, newsId)
    End Function
    Public Overrides Function CMS_SiteMap_News(PortalConnect As String, PortalID As Integer, IsLang As String, top As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_SiteMap_News", PortalID, IsLang, top)
    End Function
    Public Overrides Function CMS_BackWF_News(PortalConnect As String, NewsID As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_BackWF_News", NewsID)
    End Function
    Public Overrides Sub CMS_Update_View(PortalConnect As String, IdKey As String, ID As Integer)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Update_View", IdKey, ID)
    End Sub
    Public Overrides Function CMS_News_Get(PortalConnect As String, newId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Get", newId), IDataReader)
    End Function
    Public Overrides Function CMS_News_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Status(PortalConnect As String, newid As Integer, Status As Integer, UserId As String, publisedDate As DateTime)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Update_Status", newid, Status, UserId, publisedDate)
    End Sub
    Public Overrides Function CMS_News_List_Search(PortalConnect As String, Status As Integer, WfID As Integer, PortalID As Integer, IsLang As String, categoryid As Integer, title As String, PageIndex As Integer, PageSize As Integer, Flag As String, fromDate As DateTime, toDate As DateTime, UserName As String, isStep As Boolean, isImages As Boolean, WF_RETURN As Integer, cateAll As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_Search", Status, WfID, PortalID, IsLang, categoryid, title, PageIndex, PageSize, Flag, fromDate, toDate, UserName, isStep, isImages, WF_RETURN, cateAll), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Search_All(PortalConnect As String, Search As String, categoryid As Integer, PortalID As Integer, PageIndex As Integer, PageSize As Integer, isImages As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_Search_All", Search, categoryid, PortalID, PageIndex, PageSize, isImages), IDataReader)
    End Function
    Public Overrides Function CMS_News_List_Home(PortalConnect As String, NewsID As String, CategoryId As Integer, PortalId As Integer, PageIndex As Integer, PageSize As Integer, isImage As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_List_Home", NewsID, CategoryId, PortalId, PageIndex, PageSize, isImage), IDataReader)
    End Function
    Public Overrides Sub CMS_News_Update_Lock(PortalConnect As String, NewId As Integer, lock As Boolean, UserId As String)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Update_Lock", NewId, lock, UserId)
    End Sub
    Public Overrides Function CMS_News_GetLocks(PortalConnect As String, PortalId As Integer, LanguageId As String, Search As String, Optional newsid As Integer = 0) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_GetLocks", PortalId, LanguageId, Search, newsid), IDataReader)
    End Function
    Public Overrides Function CMS_News_Add(PortalConnect As String, obj As CMS_NewsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_Add", flReg.GetNull(obj.CategoryId), flReg.GetNull(obj.Introduction), obj.Title, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Content), obj.isActive, obj.Hotcat, obj.IsCare, obj.isRead, obj.Status, flReg.GetNull(obj.Unit), obj.NewsKind, obj.Type, flReg.GetNull(obj.TypeUrl), flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.IsImage, flReg.GetNull(obj.Note), flReg.GetNull(obj.SourceInfo), obj.IsEdited, flReg.GetNull(obj.EditedUser), flReg.GetNull(obj.EditedTime), obj.VoteCount, obj.ViewCount, flReg.GetNull(obj.IsArchived), flReg.GetNull(obj.ArchivedDate), obj.Credit, obj.Createdate, flReg.GetNull(obj.ApprovalRequestDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.ReturnedDate), flReg.GetNull(obj.ReturnedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), obj.UserId, obj.WriterName, obj.WriterFullName, flReg.GetNull(obj.NumberNews), flReg.GetNull(obj.NotePrices), flReg.GetNull(obj.LanguageId), obj.PortalId, flReg.GetNull(obj.ToUrl), flReg.GetNull(obj.GetFromPortal), flReg.GetNull(obj.GetFromNewId), obj.SendName, obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_News_Update(PortalConnect As String, obj As CMS_NewsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Update", obj.NewId, flReg.GetNull(obj.CategoryId), flReg.GetNull(obj.Introduction), obj.Title, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Content), obj.isActive, obj.Hotcat, obj.IsCare, obj.isRead, obj.Status, flReg.GetNull(obj.Unit), obj.NewsKind, obj.Type, flReg.GetNull(obj.TypeUrl), flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.IsImage, flReg.GetNull(obj.Note), flReg.GetNull(obj.SourceInfo), obj.IsEdited, flReg.GetNull(obj.EditedUser), flReg.GetNull(obj.EditedTime), obj.VoteCount, obj.ViewCount, flReg.GetNull(obj.IsArchived), flReg.GetNull(obj.ArchivedDate), obj.Credit, obj.Createdate, flReg.GetNull(obj.ApprovalRequestDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.ReturnedDate), flReg.GetNull(obj.ReturnedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), obj.UserId, obj.WriterName, obj.WriterFullName, flReg.GetNull(obj.NumberNews), flReg.GetNull(obj.NotePrices), flReg.GetNull(obj.LanguageId), obj.PortalId, flReg.GetNull(obj.ToUrl), flReg.GetNull(obj.GetFromPortal), flReg.GetNull(obj.GetFromNewId), obj.SendName, obj.SendView, obj.IsMobile)
    End Sub
    Public Overrides Sub CMS_News_Delete(PortalConnect As String, newId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Delete", newId)
    End Sub
#End Region
#Region "CMS_News_NB"
    Public Overrides Function CMS_News_NB_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NB_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_News_NB_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NB_List"), IDataReader)
    End Function
    Public Overrides Function CMS_News_NB_Get_By_NewsID(PortalConnect As String, newsID As Integer, Type As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NB_Get_By_NewsID", newsID, Type), IDataReader)
    End Function
    Public Overrides Function CMS_News_NB_Add(PortalConnect As String, obj As CMS_News_NBInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_NB_Add", flReg.GetNull(obj.NewsID), flReg.GetNull(obj.DM_ID), flReg.GetNull(obj.Price), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.Type)), Integer)
    End Function
    Public Overrides Sub CMS_News_NB_Update(PortalConnect As String, obj As CMS_News_NBInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_NB_Update", obj.ID, flReg.GetNull(obj.NewsID), flReg.GetNull(obj.DM_ID), flReg.GetNull(obj.Price), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate), flReg.GetNull(obj.Type))
    End Sub
    Public Overrides Sub CMS_News_NB_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_NB_Delete", iD)
    End Sub
#End Region
#Region "CMS_News_NBDetail"
    Public Overrides Function CMS_News_NBDetail_Get(PortalConnect As String, detail_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NBDetail_Get", detail_ID), IDataReader)
    End Function
    Public Overrides Function CMS_News_NBDetail_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NBDetail_List"), IDataReader)
    End Function
    Public Overrides Function CMS_News_NBDetail_Get_By_NB_DM_ID(PortalConnect As String, NB_ID As Integer, DM_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NBDetail_Get_By_NB_DM_ID", NB_ID, DM_ID), IDataReader)
    End Function

    Public Overrides Function CMS_News_NBDetail_List_By_NewsNBID(PortalConnect As String, NewsNB_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NBDetail_List_By_NewsNBID", NewsNB_ID), IDataReader)
    End Function
    Public Overrides Function CMS_News_NBDetail_Add(PortalConnect As String, obj As CMS_News_NBDetailInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_NBDetail_Add", flReg.GetNull(obj.NewsNB_ID), flReg.GetNull(obj.ID), flReg.GetNull(obj.MaDM), flReg.GetNull(obj.HeSo), flReg.GetNull(obj.SoLuong), flReg.GetNull(obj.DonGia), flReg.GetNull(obj.Price), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate)), Integer)
    End Function
    Public Overrides Sub CMS_News_NBDetail_Update(PortalConnect As String, obj As CMS_News_NBDetailInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_NBDetail_Update", obj.Detail_ID, flReg.GetNull(obj.NewsNB_ID), flReg.GetNull(obj.ID), flReg.GetNull(obj.MaDM), flReg.GetNull(obj.HeSo), flReg.GetNull(obj.SoLuong), flReg.GetNull(obj.DonGia), flReg.GetNull(obj.Price), flReg.GetNull(obj.CreateUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.UpdateUser), flReg.GetNull(obj.UpdateDate))
    End Sub
    Public Overrides Function CMS_News_NBDetail_Get_By_CMS_News_NB(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_NBDetail_Get_By_CMS_News_NB", iD), IDataReader)
    End Function
    Public Overrides Sub CMS_News_NBDetail_Delete(PortalConnect As String, detail_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_NBDetail_Delete", detail_ID)
    End Sub
#End Region
#Region "CMS_News_Process"
    Public Overrides Function CMS_News_Process_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Process_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_News_Process_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Process_List"), IDataReader)
    End Function
    Public Overrides Function CMS_News_Process_GetByNewsId(PortalConnect As String, ItemId As Integer, Type As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Process_GetByNewsId", ItemId, Type)
    End Function
    Public Overrides Function CMS_News_Process_Add(PortalConnect As String, obj As CMS_News_ProcessInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_Process_Add", obj.ItemID, obj.StatusID, flReg.GetNull(obj.ProcessName), flReg.GetNull(obj.Comment), flReg.GetNull(obj.ByUser), flReg.GetNull(obj.ToUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.VersionId), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Type)), Integer)
    End Function
    Public Overrides Sub CMS_News_Process_Update(PortalConnect As String, obj As CMS_News_ProcessInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Process_Update", obj.ID, obj.ItemID, obj.StatusID, flReg.GetNull(obj.ProcessName), flReg.GetNull(obj.Comment), flReg.GetNull(obj.ByUser), flReg.GetNull(obj.ToUser), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.VersionId), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Type))
    End Sub
    Public Overrides Sub CMS_News_Process_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Process_Delete", iD)
    End Sub
#End Region
#Region "CMS_News_UserProcess"
    Public Overrides Function CMS_News_UserProcess_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_UserProcess_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_News_UserProcess_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_UserProcess_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(PortalConnect As String, NewsID As Integer, UserId As String, isActive As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId", NewsID, UserId, isActive)
    End Sub
    Public Overrides Function CMS_News_UserProcess_Add(PortalConnect As String, obj As CMS_News_UserProcessInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_UserProcess_Add", obj.UserID, obj.NewsID, obj.Status, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.isActive), flReg.GetNull(obj.Type), flReg.GetNull(obj.PositionID)), Integer)
    End Function
    Public Overrides Sub CMS_News_UserProcess_Update(PortalConnect As String, obj As CMS_News_UserProcessInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_UserProcess_Update", obj.ID, obj.UserID, obj.NewsID, obj.Status, flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.CreatedUser), flReg.GetNull(obj.isActive), flReg.GetNull(obj.Type), flReg.GetNull(obj.PositionID))
    End Sub
    Public Overrides Sub CMS_News_UserProcess_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_UserProcess_Delete", iD)
    End Sub
#End Region
#Region "CMS_News_UserWF"
    Public Overrides Function CMS_News_UserWF_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_UserWF_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_News_UserWF_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_UserWF_List", PortalConnect), IDataReader)
    End Function
    Public Overrides Function CMS_News_UserWF_GetByPhongBanId(PortalConnect As String, LoaiWF As LoaiWF, phongbanID As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_UserWF_GetByPhongBanId", LoaiWF, phongbanID)
    End Function
    Public Overrides Function CMS_News_UserWF_Add(PortalConnect As String, obj As CMS_News_UserWFInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_UserWF_Add", obj.TenLuong, flReg.GetNull(obj.PhongBan), obj.NguoiGui, flReg.GetNull(obj.NguoiNhan), flReg.GetNull(obj.TrangThaiDich), obj.LoaiWF, flReg.GetNull(obj.IsDefault), flReg.GetNull(obj.MoTa), obj.NguoiTao, obj.NgayTao, obj.IsActive, obj.OrderNumber, flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ModuleId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IconSmall), flReg.GetNull(obj.IconLarge), flReg.GetNull(obj.PositionID)), Integer)
    End Function
    Public Overrides Sub CMS_News_UserWF_Update(PortalConnect As String, obj As CMS_News_UserWFInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_UserWF_Update", obj.ID, obj.TenLuong, flReg.GetNull(obj.PhongBan), obj.NguoiGui, flReg.GetNull(obj.NguoiNhan), flReg.GetNull(obj.TrangThaiDich), obj.LoaiWF, flReg.GetNull(obj.IsDefault), flReg.GetNull(obj.MoTa), obj.NguoiTao, obj.NgayTao, obj.IsActive, obj.OrderNumber, flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ModuleId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IconSmall), flReg.GetNull(obj.IconLarge), flReg.GetNull(obj.PositionID))
    End Sub
    Public Overrides Sub CMS_News_UserWF_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_UserWF_Delete", iD)
    End Sub
#End Region
#Region "CMS_News_Version"
    Public Overrides Function CMS_News_Version_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Version_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_News_Version_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_Version_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_News_CheckChange_Get_NewsID(PortalConnect As String, NewID As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_News_CheckChange_Get_NewsID", NewID)
    End Function
    Public Overrides Function CMS_News_Version_Add(PortalConnect As String, obj As CMS_News_VersionInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_News_Version_Add", obj.CreatedUser, obj.NewId, flReg.GetNull(obj.CategoryId), flReg.GetNull(obj.Introduction), obj.Title, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Content), obj.isActive, obj.Hotcat, obj.IsCare, flReg.GetNull(obj.isRead), obj.Status, flReg.GetNull(obj.Unit), flReg.GetNull(obj.NewsKind), flReg.GetNull(obj.Type), flReg.GetNull(obj.TypeUrl), flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.IsImage, flReg.GetNull(obj.Note), flReg.GetNull(obj.SourceInfo), flReg.GetNull(obj.IsEdited), flReg.GetNull(obj.EditedUser), flReg.GetNull(obj.EditedTime), flReg.GetNull(obj.VoteCount), flReg.GetNull(obj.ViewCount), flReg.GetNull(obj.IsArchived), flReg.GetNull(obj.ArchivedDate), flReg.GetNull(obj.Credit), flReg.GetNull(obj.Createdate), flReg.GetNull(obj.ApprovalRequestDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.ReturnedDate), flReg.GetNull(obj.ReturnedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), obj.UserId, obj.WriterName, obj.WriterFullName, flReg.GetNull(obj.NumberNews), flReg.GetNull(obj.NotePrices), flReg.GetNull(obj.LanguageId), obj.PortalId, flReg.GetNull(obj.ToUrl), flReg.GetNull(obj.GetFromPortal), flReg.GetNull(obj.GetFromNewId), obj.SendName, obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_News_Version_Update(PortalConnect As String, obj As CMS_News_VersionInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Version_Update", obj.ID, obj.CreatedUser, obj.NewId, flReg.GetNull(obj.CategoryId), flReg.GetNull(obj.Introduction), obj.Title, flReg.GetNull(obj.ImagePath), flReg.GetNull(obj.Summary), flReg.GetNull(obj.Content), obj.isActive, obj.Hotcat, obj.IsCare, flReg.GetNull(obj.isRead), obj.Status, flReg.GetNull(obj.Unit), flReg.GetNull(obj.NewsKind), flReg.GetNull(obj.Type), flReg.GetNull(obj.TypeUrl), flReg.GetNull(obj.Links), flReg.GetNull(obj.Tags), obj.IsImage, flReg.GetNull(obj.Note), flReg.GetNull(obj.SourceInfo), flReg.GetNull(obj.IsEdited), flReg.GetNull(obj.EditedUser), flReg.GetNull(obj.EditedTime), flReg.GetNull(obj.VoteCount), flReg.GetNull(obj.ViewCount), flReg.GetNull(obj.IsArchived), flReg.GetNull(obj.ArchivedDate), flReg.GetNull(obj.Credit), flReg.GetNull(obj.Createdate), flReg.GetNull(obj.ApprovalRequestDate), flReg.GetNull(obj.ApprovalDate), flReg.GetNull(obj.ApprovalUser), flReg.GetNull(obj.ReturnedDate), flReg.GetNull(obj.ReturnedUser), flReg.GetNull(obj.CancelPublishDate), flReg.GetNull(obj.CancelPublishUser), flReg.GetNull(obj.PublishedDate), flReg.GetNull(obj.PublishedUser), obj.UserId, obj.WriterName, obj.WriterFullName, flReg.GetNull(obj.NumberNews), flReg.GetNull(obj.NotePrices), flReg.GetNull(obj.LanguageId), obj.PortalId, flReg.GetNull(obj.ToUrl), flReg.GetNull(obj.GetFromPortal), flReg.GetNull(obj.GetFromNewId), obj.SendName, obj.SendView)
    End Sub
    Public Overrides Sub CMS_News_Version_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_News_Version_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsByCategory"
    Public Overrides Function CMS_NewsByCategory_Get(PortalConnect As String, id As Long) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByCategory_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByCategory_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByCategory_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByCategory_Add(PortalConnect As String, NewsId As Integer, CategoryId As Integer, IsMainCategory As Boolean, NewsStatusId As Integer, portalId As Integer, LanguageId As String, isHotCate As Boolean) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsByCategory_Add", flReg.GetNull(NewsId), flReg.GetNull(CategoryId), flReg.GetNull(IsMainCategory), NewsStatusId, portalId, flReg.GetNull(LanguageId), isHotCate), Integer)
    End Function
    Public Overrides Sub CMS_NewsByCategory_Update(PortalConnect As String, obj As CMS_NewsByCategoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByCategory_Update", obj.Id, flReg.GetNull(obj.NewsId), flReg.GetNull(obj.CategoryId), flReg.GetNull(obj.IsMainCategory), obj.NewsStatusId, obj.PortalID, flReg.GetNull(obj.LanguageId), obj.SendView, obj.IsHotCate)
    End Sub
    Public Overrides Sub CMS_NewsByCategory_Delete(PortalConnect As String, id As Long)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByCategory_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsByMedia"
    Public Overrides Sub CMS_NewsByMedia_Delete_By_MediaID(PortalConnect As String, MediaID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByMedia_Delete_By_MediaID", MediaID)
    End Sub
    Public Overrides Function CMS_NewsByMedia_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByMedia_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByMedia_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByMedia_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByMedia_GetByNewsId(PortalConnect As String, newsId As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByMedia_GetByNewsId", newsId)
    End Function
    Public Overrides Sub CMS_NewsByMedia_DeleteByNewsId(PortalConnect As String, NewsId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByMedia_DeleteByNewsId", NewsId)
    End Sub
    Public Overrides Function CMS_NewsByMedia_Add(PortalConnect As String, obj As CMS_NewsByMediaInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsByMedia_Add", obj.NewsId, obj.MediaId, obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_NewsByMedia_Update(PortalConnect As String, obj As CMS_NewsByMediaInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByMedia_Update", obj.Id, obj.NewsId, obj.MediaId, obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsByMedia_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByMedia_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsByTags"
    Public Overrides Function CMS_NewsByTags_Get(PortalConnect As String, id As Long) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByTags_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByTags_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByTags_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByTags_Get_By_NewsID(PortalConnect As Integer, NewsID As Integer, top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsByTags_Get_By_NewsID", NewsID, top), IDataReader)
    End Function
    Public Overrides Function CMS_NewsByTags_Add(PortalConnect As String, newsId As Integer, tagName As String, createdDate As DateTime, updatedDate As DateTime) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsByTags_Add", newsId, flReg.GetNull(tagName), flReg.GetNull(createdDate), flReg.GetNull(updatedDate)), Integer)
    End Function
    Public Overrides Sub CMS_NewsByTags_Update(PortalConnect As String, obj As CMS_NewsByTagsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByTags_Update", obj.Id, obj.NewsId, flReg.GetNull(obj.TagName), flReg.GetNull(obj.CreatedDate), flReg.GetNull(obj.UpdatedDate))
    End Sub
    Public Overrides Sub CMS_NewsByTags_Delete(PortalConnect As String, id As Long)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByTags_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsCategories"
    Public Overrides Function CMS_NewsCategories_List_By_Parent(PortalConnect As String, Parentid As Integer, PortalId As Integer, LanguageId As String, Type As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_List_By_Parent", Parentid, PortalId, LanguageId, Type)
    End Function
    Public Overrides Sub CMS_NewsCategories_UpdateTabId(PortalConnect As String, categoryid As Integer, tabid As Integer, TabPath As String)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_UpdateTabId", categoryid, tabid, TabPath)
    End Sub
    Public Overrides Sub CMS_NewsCategories_Update_Order(PortalConnect As String, categoryid As Integer, OrderNumber As Integer)
        SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Update_Order", categoryid, OrderNumber)
    End Sub
    Public Overrides Function CMS_NewsCategories_ByParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0, Optional Search As String = "") As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_ByParentId", PortalId, LanguageId, Type, ParentId, Search)
    End Function
    Public Overrides Function CMS_NewsCategoriesPermission_Get_By_Category(PortalConnect As String, userId As String, categoryId As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, ("CMS_NewsCategoriesPermission_Get_By_Category"), userId, categoryId), Integer)
    End Function
    Public Overrides Function CMS_NewsCategories_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_List_All", PortalId, LanguageId, Type)
    End Function
    Public Overrides Sub CMS_NewsByCategory_Delete_By_NewsID(PortalConnect As String, NewsId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsByCategory_Delete_By_NewsID", NewsId, PortalConnect)
    End Sub
    Public Overrides Function CMS_NewsCategories_Get_By_ParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, UserID As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get_By_ParentId", PortalId, LanguageId, UserID, Type, ParentId)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_By_TabID_Parent(PortalConnect As String, TabId As Integer, Parent As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get_By_TabID_Parent", TabId, Parent), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_ID_By_TabMobileID(PortalConnect As String, TabId As Integer, Parent As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get_ID_By_TabMobileID", TabId, Parent), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_TabPath(PortalConnect As String, categoryid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get_TabPath", categoryid), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get_By_TabID", tabID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get(PortalConnect As String, categoryID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_Get", categoryID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategories_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Add(PortalConnect As String, obj As CMS_NewsCategoriesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsCategories_Add", obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.TabID), flReg.GetNull(obj.TabMobileID), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.OrderNumber), flReg.GetNull(obj.Type), flReg.GetNull(obj.LanguageId), obj.SendView, flReg.GetNull(obj.TabPath)), Integer)
    End Function
    Public Overrides Sub CMS_NewsCategories_Update(PortalConnect As String, obj As CMS_NewsCategoriesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsCategories_Update", obj.CategoryID, obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.TabID), flReg.GetNull(obj.TabMobileID), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.OrderNumber), flReg.GetNull(obj.Type), flReg.GetNull(obj.LanguageId), obj.SendView, flReg.GetNull(obj.TabPath))
    End Sub
    Public Overrides Sub CMS_NewsCategories_Delete(PortalConnect As String, categoryID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsCategories_Delete", categoryID)
    End Sub
#End Region
#Region "CMS_NewsCategoriesPermission"
    Public Overrides Function CMS_NewsCategoriesPermission_Get(PortalConnect As String, id As Long) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategoriesPermission_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategoriesPermission_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsCategoriesPermission_List"), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsCategoriesPermission_Delete_Category(PortalConnect As String, userId As String, categoryId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, ("CMS_NewsCategoriesPermission_Delete_Category"), userId, categoryId)
    End Sub
    Public Overrides Function CMS_NewsCategoriesPermission_Add(PortalConnect As String, userId As String, categoryId As Integer, permissionType As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsCategoriesPermission_Add", userId, categoryId, permissionType), Integer)
    End Function
    Public Overrides Sub CMS_NewsCategoriesPermission_Update(PortalConnect As String, obj As CMS_NewsCategoriesPermissionInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsCategoriesPermission_Update", obj.Id, obj.UserId, obj.CategoryId, obj.RoleId)
    End Sub
    Public Overrides Sub CMS_NewsCategoriesPermission_Delete(PortalConnect As String, id As Long)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsCategoriesPermission_Delete", id)
    End Sub
#End Region
#Region "CMS_NewsFeedback"
    Public Overrides Function CMS_NewsFeedback_List_By_NewsID(PortalConnect As String, ItemId As Integer, Status As String, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedback_List_By_NewsID", ItemId, Status, type, PortalId, LanguageId, PageIndex, PageSize)
    End Function
    Public Overrides Function CMS_NewsFeedback_Get(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedback_Get", newsFeedbackId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedback_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedback_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsFeedback_Update_Status(PortalConnect As String, newsFeedbackId As Integer, status As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsFeedback_Update_Status", newsFeedbackId, status)
    End Sub
    Public Overrides Function CMS_NewsFeedback_List_Search(PortalConnect As String, ItemId As Integer, Status As Integer, type As Integer, PortalId As Integer, LanguageId As String, PageIndex As Integer, PageSize As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedback_List_Search", ItemId, Status, type, PortalId, LanguageId, PageIndex, PageSize)
    End Function
    Public Overrides Function CMS_NewsFeedback_Get_By_FBID(PortalConnect As String, idFeed As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedback_Get_By_FBID", idFeed), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedback_Add(PortalConnect As String, obj As CMS_NewsFeedbackInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsFeedback_Add", flReg.GetNull(obj.ItemId), flReg.GetNull(obj.FullName), flReg.GetNull(obj.Email), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PhoneNumber), flReg.GetNull(obj.Title), flReg.GetNull(obj.Content), flReg.GetNull(obj.Address), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Status), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.Type), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IsLike), flReg.GetNull(obj.DisLike), flReg.GetNull(obj.ParentID), flReg.GetNull(obj.IsRead), flReg.GetNull(obj.UserRead), flReg.GetNull(obj.DateRead), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.UserPublic), flReg.GetNull(obj.DatePublic), obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_NewsFeedback_Update(PortalConnect As String, obj As CMS_NewsFeedbackInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsFeedback_Update", obj.NewsFeedbackId, flReg.GetNull(obj.ItemId), flReg.GetNull(obj.FullName), flReg.GetNull(obj.Email), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PhoneNumber), flReg.GetNull(obj.Title), flReg.GetNull(obj.Content), flReg.GetNull(obj.Address), flReg.GetNull(obj.IPTrack), flReg.GetNull(obj.Status), flReg.GetNull(obj.Avatar), flReg.GetNull(obj.Type), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.IsLike), flReg.GetNull(obj.DisLike), flReg.GetNull(obj.ParentID), flReg.GetNull(obj.IsRead), flReg.GetNull(obj.UserRead), flReg.GetNull(obj.DateRead), flReg.GetNull(obj.IsPublic), flReg.GetNull(obj.UserPublic), flReg.GetNull(obj.DatePublic), obj.SendView)
    End Sub
    Public Overrides Sub CMS_NewsFeedback_Delete(PortalConnect As String, newsFeedbackId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsFeedback_Delete", newsFeedbackId)
    End Sub
#End Region
#Region "CMS_NewsFeedBack_History"
    Public Overrides Function CMS_NewsFeedBack_History_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedBack_History_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedBack_History_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedBack_History_Get_By_NewsFeedback(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Get_By_NewsFeedback", newsFeedbackId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsFeedBack_History_Add(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Add", obj.NewFB_ID, obj.Contents, obj.UserName, obj.CreateDate), Integer)
    End Function
    Public Overrides Sub CMS_NewsFeedBack_History_Update(PortalConnect As String, obj As CMS_NewsFeedBack_HistoryInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Update", obj.ID, obj.NewFB_ID, obj.Contents, obj.UserName, obj.CreateDate)
    End Sub
    Public Overrides Function CMS_NewsFeedBack_History_Get_By_CMS_NewsFeedback(PortalConnect As String, newsFeedbackId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Get_By_CMS_NewsFeedback", newsFeedbackId), IDataReader)
    End Function
    Public Overrides Sub CMS_NewsFeedBack_History_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsFeedBack_History_Delete", iD)
    End Sub
#End Region
#Region "CMS_NewsStatus"
    Public Overrides Function CMS_NewsStatus_Get(PortalConnect As String, newsStatusId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsStatus_Get", newsStatusId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsStatus_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NewsStatus_List"), IDataReader)
    End Function

    Public Overrides Function CMS_NewsStatus_Add(PortalConnect As String, obj As CMS_NewsStatusInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NewsStatus_Add", obj.StatusName, flReg.GetNull(obj.Description)), Integer)
    End Function
    Public Overrides Sub CMS_NewsStatus_Update(PortalConnect As String, obj As CMS_NewsStatusInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsStatus_Update", obj.NewsStatusId, obj.StatusName, flReg.GetNull(obj.Description))
    End Sub
    Public Overrides Sub CMS_NewsStatus_Delete(PortalConnect As String, newsStatusId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NewsStatus_Delete", newsStatusId)
    End Sub
#End Region
#Region "CMS_WebLink"
    Public Overrides Function CMS_WebLink_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_WebLink_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_WebLink_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_WebLink_Update_Order(PortalConnect As String, Id As Integer, OrderNo As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_WebLink_Update_Order", Id, OrderNo)
    End Sub
    Public Overrides Function CMS_WebLink_List_Search(PortalConnect As String, Name As String, ViewType As Integer, PortalId As Integer, LanguageId As String, PageSize As Integer, PageIndex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_WebLink_List_Search", Name, ViewType, PortalId, LanguageId, PageSize, PageIndex), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_Add(PortalConnect As String, obj As CMS_WebLinkInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_WebLink_Add", flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate)), Integer)
    End Function
    Public Overrides Sub CMS_WebLink_Update(PortalConnect As String, obj As CMS_WebLinkInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_WebLink_Update", obj.Id, flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate))
    End Sub
    Public Overrides Sub CMS_WebLink_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_WebLink_Delete", id)
    End Sub
#End Region
#Region "CMS_Infomation"
    Public Overrides Function CMS_Infomation_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Infomation_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Infomation_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Infomation_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Infomation_Add(PortalConnect As String, obj As CMS_InfomationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Infomation_Add", flReg.GetNull(obj.NameH1), flReg.GetNull(obj.NameH2), flReg.GetNull(obj.NameH3), obj.ImagePath, obj.ImageRight, obj.Footer, obj.Infomation, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalId, obj.LanguageId, obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_Infomation_Update(PortalConnect As String, obj As CMS_InfomationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Infomation_Update", obj.Id, flReg.GetNull(obj.NameH1), flReg.GetNull(obj.NameH2), flReg.GetNull(obj.NameH3), obj.ImagePath, obj.ImageRight, obj.Footer, obj.Infomation, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalId, obj.LanguageId, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Infomation_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Infomation_Delete", id)
    End Sub
#End Region
#Region "SQL_Service_Add"
    Public Overrides Sub SV_CMS_Answers_Add(PortalConnect As String, answer_ID As String, question_ID As String, fullName As String, contents As String, fileName As String, fileAttach As String, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String, publishedDate As DateTime, publishedUser As String, isPublic As Boolean)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_Answers_Add", answer_ID, question_ID, flReg.DeCode64(fullName), flReg.DeCode64(contents), fileName, fileAttach, flReg.GetNull(createDate), createUser, flReg.GetNull(updateDate), updateUser, flReg.GetNull(publishedDate), publishedUser, isPublic)
    End Sub
    Public Overrides Sub SV_CMS_WebLink_Add(PortalConnect As String, id As Integer, name As String, orderNo As Integer, url As String, image As String, description As String, portalId As Integer, languageId As String, viewType As Integer, UserName As String, Createdate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_WebLink_Add", id, flReg.DeCode64(name), orderNo, flReg.DeCode64(url), image, flReg.DeCode64(description), portalId, languageId, viewType, UserName, Createdate)
    End Sub
    Public Overrides Sub SV_CMS_NewsCategories_Add(PortalConnect As String, categoryid As Integer, categoryname As String, description As String, TabID As Integer, isactive As Integer, CreateDate As DateTime, PortalId As Integer, LanguageId As String, ParentId As Integer, OrderNumber As Integer, Type As Integer, TabPath As String, TabMobileID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_NewsCategories_Add", categoryid, flReg.DeCode64(categoryname), flReg.DeCode64(description), TabID, isactive, CreateDate, PortalId, LanguageId, ParentId, OrderNumber, Type, TabPath, TabMobileID)
    End Sub
    Public Overrides Sub SV_CMS_Document_Add(PortalConnect As String, document_ID As String, document_Name As String, docType As String, providerName As String, filedName As String, contents As String, noCode As String, signerName As String, promDate As DateTime, effectDate As DateTime, endDate As DateTime, fileName As String, fileSource As String, isURL As String, isDownload As Integer, isActive As Boolean, isOrder As Integer, createdBy As DateTime, userName As String, updatedBy As DateTime, updateName As String, portalID As Integer)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_Document_Add", document_ID, flReg.DeCode64(document_Name), docType, flReg.DeCode64(providerName), flReg.DeCode64(filedName), flReg.DeCode64(contents), noCode, signerName, flReg.DateNull(promDate), effectDate, flReg.DateNull(endDate), fileName, flReg.DeCode64(fileSource), isURL, isDownload, isActive, isOrder, createdBy, userName, flReg.DateNull(updatedBy), updateName, portalID)
    End Sub
    Public Overrides Sub SV_CMS_MenuD_Add(PortalConnect As String, menuD_ID As String, menuD_Name As String, menu_ID As String, parent_ID As String, url As String, backColor As String, isOrder As Integer, portalId As Integer, createdDate As DateTime, createdUser As String, updateDate As DateTime, updateUser As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_MenuD_Add", menuD_ID, flReg.DeCode64(menuD_Name), menu_ID, parent_ID, flReg.DeCode64(url), backColor, isOrder, portalId, createdDate, createdUser, flReg.GetNull(updateDate), updateUser)
    End Sub
    Public Overrides Function SV_CMS_ListError(PortalConnect As String, Type As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "SV_CMS_ListError", Type), IDataReader)
    End Function
    Public Overrides Sub SV_CMS_NewsFeedback_Add(PortalConnect As String, NewsFeedbackId As Integer, itemId As Integer, fullName As String, email As String, createDate As DateTime, phoneNumber As String, title As String, content As String, address As String, iPTrack As String, status As Integer, avatar As String, type As String, portalId As Integer, languageId As String, isLike As Integer, disLike As Integer, parentID As Integer, isRead As Boolean, userRead As String, dateRead As DateTime, isPublic As Boolean, userPublic As String, datePublic As DateTime)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_NewsFeedback_Add", NewsFeedbackId, itemId, flReg.DeCode64(fullName), flReg.DeCode64(email),
                                createDate, phoneNumber, flReg.DeCode64(title), flReg.DeCode64(content), flReg.DeCode64(address), flReg.DeCode64(iPTrack),
                                status, flReg.DeCode64(avatar), type, portalId, languageId, isLike, disLike, flReg.GetNull(parentID), isRead, userRead,
                                flReg.GetNull(dateRead), isPublic, userPublic, flReg.GetNull(datePublic))
    End Sub
    Public Overrides Sub SV_CMS_News_Add(PortalConnect As String, NewId As Integer, CategoryId As Integer, Introduction As String, Title As String, ImagePath As String, Summary As String, Content As String, isActive As Boolean, Hotcat As Boolean, IsCare As Boolean, isRead As Integer, Status As Integer, Unit As Short, NewsKind As Short, Type As Short, TypeUrl As String, Links As String, Tags As String, IsImage As Boolean, Note As String, SourceInfo As Short, IsEdited As Boolean, EditedUser As String, EditedTime As DateTime, VoteCount As Integer, ViewCount As Integer, IsArchived As Boolean, ArchivedDate As DateTime, Credit As Integer, Createdate As DateTime, ApprovalRequestDate As DateTime, ApprovalDate As DateTime, ApprovalUser As String, ReturnedDate As DateTime, ReturnedUser As String, CancelPublishDate As DateTime, CancelPublishUser As String, PublishedDate As DateTime, PublishedUser As String, UserId As String, WriterName As String, WriterFullName As String, NumberNews As String, NotePrices As String, LanguageId As String, PortalId As Integer, ToUrl As String, GetFromPortal As Integer, GetFromNewId As Integer, SendName As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_News_Add", NewId, CategoryId, flReg.DeCode64(Introduction), flReg.DeCode64(Title), flReg.DeCode64(ImagePath), flReg.DeCode64(Summary), flReg.DeCode64(Content), isActive, Hotcat, IsCare, isRead, Status, Unit, NewsKind, Type, TypeUrl, flReg.DeCode64(Links), flReg.DeCode64(Tags), IsImage, Note, SourceInfo, IsEdited, EditedUser, EditedTime, VoteCount, ViewCount, IsArchived, ArchivedDate, Credit, Createdate, ApprovalRequestDate, ApprovalDate, ApprovalUser, ReturnedDate, ReturnedUser, CancelPublishDate, CancelPublishUser, PublishedDate, PublishedUser, UserId, WriterName, WriterFullName, NumberNews, NotePrices, LanguageId, PortalId, flReg.DeCode64(ToUrl), GetFromPortal, GetFromNewId, SendName, SendView)
    End Sub
    Public Overrides Sub SV_CMS_NewsByCategory_Add(PortalConnect As String, id As Long, newsId As Long, categoryId As Integer, isMainCategory As Boolean, newsStatusId As Integer, portalID As Integer, languageId As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_NewsByCategory_Add", id, newsId, categoryId, isMainCategory, newsStatusId, portalID, languageId)
    End Sub
    Public Overrides Sub SV_CMS_NewsByMedia_Add(PortalConnect As String, id As Integer, newsId As Integer, mediaId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_NewsByMedia_Add", id, newsId, mediaId)
    End Sub
    Public Overrides Sub SV_CMS_Media_Add(PortalConnect As String, id As Integer, categoryId As Integer, name As String, summary As String, avatar As String, mediaUrl As String, folders As String, contents As String, viewCount As Integer, status As Integer, type As Short, isYoutube As Boolean, isHot As Boolean, isFTP As Boolean, tags As String, note As String, createdDate As DateTime, publishedDate As DateTime, approvalDate As DateTime, createdUser As String, approvalUser As String, publishedUser As String, portalId As Integer, languageId As String, sTT As Integer, isHome As Boolean, isPage As Boolean, toUrl As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_Media_Add", id, categoryId, flReg.DeCode64(name),
                                  flReg.DeCode64(summary), flReg.DeCode64(avatar), flReg.DeCode64(mediaUrl), folders, flReg.DeCode64(contents),
                                  viewCount, status, type, isYoutube, isHot, isFTP, tags, note, flReg.GetNull(createdDate),
                                  flReg.GetNull(publishedDate), flReg.GetNull(approvalDate), createdUser, approvalUser, publishedUser, portalId, languageId, sTT, isHome, isPage, flReg.DeCode64(toUrl))
    End Sub
    Public Overrides Sub SV_CMS_FAQ_Add(PortalConnect As String, id As String, name As String, summary As String, image As String, startDate As DateTime, endDate As DateTime, answerUserId As String, answerUserName As String, isUserDefault As Boolean, defaultAnswerName As String, portalId As Integer, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_FAQ_Add", id, flReg.DeCode64(name), flReg.DeCode64(summary), flReg.DeCode64(image),
                                flReg.GetNull(startDate), flReg.GetNull(endDate), flReg.GetNull(answerUserId), flReg.DeCode64(answerUserName),
                                flReg.GetNull(isUserDefault), flReg.DeCode64(defaultAnswerName), flReg.GetNull(portalId), flReg.GetNull(createDate),
                                flReg.GetNull(createUser), flReg.GetNull(updateDate), flReg.GetNull(updateUser))
    End Sub
    Public Overrides Sub SV_CMS_FAQAnswers_Add(PortalConnect As String, id As String, questionID As String, name As String, title As String, contents As String, fileAttach As String, sendDate As DateTime, status As Integer, isPublic As Boolean, portalId As Integer, answerName As String, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_FAQAnswers_Add", id, questionID, flReg.DeCode64(name),
                                flReg.DeCode64(title), flReg.DeCode64(contents), flReg.GetNull(fileAttach), flReg.GetNull(sendDate), flReg.GetNull(status), flReg.GetNull(isPublic),
                                flReg.GetNull(portalId), flReg.DeCode64(answerName), flReg.GetNull(createDate), flReg.GetNull(createUser), flReg.GetNull(updateDate),
                                flReg.GetNull(updateUser))
    End Sub
    Public Overrides Sub SV_CMS_FAQQuestions_Add(PortalConnect As String, id As String, fAQID As String, name As String, contents As String, fileAttach As String, adress As String, email As String, phone As String, sendDate As DateTime, status As Integer, isPublic As Boolean, portalId As Integer, createDate As DateTime, createUser As String, updateDate As DateTime, updateUser As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_FAQQuestions_Add", id, flReg.GetNull(fAQID), flReg.DeCode64(name), flReg.DeCode64(contents),
                                flReg.DeCode64(fileAttach), flReg.DeCode64(adress), flReg.DeCode64(email), flReg.GetNull(phone), flReg.GetNull(sendDate),
                                flReg.GetNull(status), flReg.GetNull(isPublic), flReg.GetNull(portalId), flReg.GetNull(createDate), flReg.GetNull(createUser),
                                flReg.GetNull(updateDate), flReg.GetNull(updateUser))
    End Sub
    Public Overrides Sub SV_CMS_ConfigSystem_Add(PortalConnect As String, iD As Integer, portalID As Integer, isCMS As Boolean, isLive As Boolean, liveTitle As String, liveUrl As String, liveDes As String, startDate As DateTime, endDate As DateTime, siteMap As String, IpPublic As String, Analytics As String, updatedBy As DateTime, updateName As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_ConfigSystem_Add", iD, portalID, isCMS, isLive, flReg.DeCode64(liveTitle), flReg.DeCode64(liveUrl), flReg.DeCode64(liveDes), flReg.GetNull(startDate), flReg.GetNull(endDate), flReg.DeCode64(siteMap), flReg.DeCode64(IpPublic), flReg.DeCode64(Analytics), updatedBy, updateName)
    End Sub
    Public Overrides Sub SV_CMS_Setups_Add(PortalConnect As String, iD As String, settingName As String, settingValue As String, createdBy As DateTime, userName As String, updatedBy As DateTime, updatedUser As String, portalID As Integer)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_Setups_Add", iD, flReg.DeCode64(settingName), flReg.DeCode64(settingValue), createdBy, userName, flReg.GetNull(updatedBy), updatedUser, portalID)
    End Sub
    Public Overrides Sub SV_Update_CMS_Event_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Event_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_News_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_News_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_Question_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Question_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_Document_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Document_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_Answers_SendView(PortalConnect As String, Id As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Answers_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsByCategory_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsByCategory_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsByMedia_SendView(PortalConnect As String, Id As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsByMedia_SendView", Id, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_Media_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Media_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_CMS_Advertise_Add(PortalConnect As String, advertise_ID As String, advertise_Name As String, imgType As Integer, images As String, isWith As String,
                                          isHeight As String, target As String, isURL As String, startDate As DateTime, endDate As DateTime,
                                          isLang As String, isActive As Boolean, isOrder As Integer, createdBy As DateTime, userName As String,
                                          updatedBy As DateTime, userUpdate As String, pageLoca_ID As String, portalID As Integer, CategoryID As String)

        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_Advertise_Add", advertise_ID,
                                  flReg.DeCode64(advertise_Name), imgType, flReg.DeCode64(images), isWith, isHeight,
                                  target, flReg.DeCode64(isURL), flReg.DateNull(startDate),
                                  flReg.DateNull(endDate), isLang, isActive, isOrder, createdBy, userName,
                                  flReg.DateNull(updatedBy), userUpdate, pageLoca_ID, portalID, CategoryID)
    End Sub
    Public Overrides Sub SV_Update_CMS_Advertise_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Advertise_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_WebLink_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_WebLink_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsFeedback_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsFeedback_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsCategories_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsCategories_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_CMS_Infomation_Add(PortalConnect As String, nameH1 As String, nameH2 As String, nameH3 As String, imagePath As String, imageRight As String, footer As String, infomation As String, createdDate As DateTime, createdUser As String, updateDate As DateTime, updateUser As String, portalId As Integer, languageId As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_Infomation_Add", flReg.DeCode64(nameH1), flReg.DeCode64(nameH2), flReg.DeCode64(nameH3), flReg.DeCode64(imagePath), flReg.DeCode64(imageRight), flReg.DeCode64(footer), flReg.DeCode64(infomation), flReg.GetNull(createdDate), createdUser, flReg.GetNull(updateDate), updateUser, portalId, languageId)
    End Sub
    Public Overrides Sub SV_Update_CMS_Infomation_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Infomation_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_MenuD_SendView(PortalConnect As String, MenuD_ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_MenuD_SendView", MenuD_ID, SendView)
    End Sub
    Public Overrides Sub SV_CMS_NewsByTags_Add(PortalConnect As String, Id As Integer, newsId As Integer, tagName As String, createdDate As DateTime, updatedDate As DateTime)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_CMS_NewsByTags_Add", Id, newsId, tagName, createdDate, flReg.DateNull(updatedDate))
    End Sub
    Public Overrides Sub SV_CMS_NewsPapers_Add(PortalConnect As String, newsPapers_ID As String, newsPapers_Number As Integer, category_ID As Integer, publicDate As DateTime, imagePath As String, isYear As Integer, isPublic As Boolean, createDate As DateTime, userName As String, updateDate As DateTime, updateUser As String, portalID As Integer, sendView As Boolean)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_NewsPapers_Add", newsPapers_ID, flReg.DeCode64(newsPapers_Number), category_ID, publicDate, flReg.DeCode64(imagePath), isYear, isPublic, createDate, userName, flReg.DateNull(updateDate), updateUser, portalID, sendView)
    End Sub
    Public Overrides Sub SV_CMS_NewsPapersD_Add(PortalConnect As String, newsPapersD_ID As String, newsPapers_ID As String, pageNumber As Integer, photoPath As String, photoDes As String, createDate As DateTime, userName As String, updateDate As DateTime, updateUser As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "SV_CMS_NewsPapersD_Add", newsPapersD_ID, newsPapers_ID, pageNumber, flReg.DeCode64(photoPath), flReg.DeCode64(photoDes), createDate, userName, flReg.DateNull(updateDate), updateUser)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsPapers_SendView(PortalConnect As String, newsPapers_ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsPapers_SendView", newsPapers_ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_NewsPapersD_SendView(PortalConnect As String, newsPapersD_ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_NewsPapersD_SendView", newsPapersD_ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_FAQ_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_FAQ_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_FAQAnswers_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_FAQAnswers_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_FAQQuestions_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_FAQQuestions_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_ConfigSystem_SendView(PortalConnect As String, ID As Integer, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_ConfigSystem_SendView", ID, SendView)
    End Sub
    Public Overrides Sub SV_Update_CMS_Setups_SendView(PortalConnect As String, ID As String, SendView As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "SV_Update_CMS_Setups_SendView", ID, SendView)
    End Sub
#End Region
#Region "RPT"
    Public Overrides Function CMS_Reports_1(PortalConnect As String, PortalID As Integer, Lang As String, Top As String, FromDate As DateTime, ToDate As DateTime, Flag As String) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Reports_1", PortalID, Lang, Top, FromDate, ToDate, Flag)
    End Function
    Public Overrides Function CMS_Reports_2(PortalConnect As String, PortalID As Integer, Lang As String, UserID As String, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Reports_2", PortalID, Lang, UserID, FromDate, ToDate)
    End Function
    Public Overrides Function CMS_Reports_3(PortalConnect As String, PortalID As Integer, Lang As String, CategoryId As Integer, FromDate As DateTime, ToDate As DateTime) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Reports_3", PortalID, Lang, CategoryId, FromDate, ToDate)
    End Function

#End Region
#Region "CMS_DashBoard"
    Public Overrides Function CMS_DashBoard_Admin(PortalConnect As String, year As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_DashBoard_Admin", year), IDataReader)
    End Function
#End Region
#Region "NewRss"
    Public Overrides Function NewRss_Get(PortalConnect As String, iD As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewRss_Get", iD), IDataReader)
    End Function
    Public Overrides Function NewRss_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewRss_List", portalId), IDataReader)
    End Function
    Public Overrides Function NewRss_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewRss_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function NewRss_List_Home(PortalConnect As String, portalId As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewRss_List_Home", portalId, currPage, recodperpage), IDataReader)
    End Function

    Public Overrides Sub NewRss_Add(PortalConnect As String, iD As String, newsSourceID As String, title As String, url As String, summary As String, content As String, portalId As Integer, pubDate As String, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "NewRss_Add", iD, flReg.GetNull(newsSourceID), flReg.GetNull(title), flReg.GetNull(url), flReg.GetNull(summary), flReg.GetNull(content), flReg.GetNull(portalId), flReg.GetNull(pubDate), flReg.GetNull(createdDate), flReg.GetNull(createdUser), flReg.GetNull(updatedBy), flReg.GetNull(updateName))
    End Sub
    Public Overrides Sub NewRss_Update(PortalConnect As String, iD As String, newsSourceID As String, title As String, url As String, summary As String, content As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "NewRss_Update", iD, flReg.GetNull(newsSourceID), flReg.GetNull(title), flReg.GetNull(url), flReg.GetNull(summary), flReg.GetNull(content), flReg.GetNull(portalId), flReg.GetNull(createdDate), flReg.GetNull(createdUser), flReg.GetNull(updatedBy), flReg.GetNull(updateName))
    End Sub
    Public Overrides Sub NewRss_Delete(PortalConnect As String, iD As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "NewRss_Delete", iD)
    End Sub
#End Region
#Region "NewsSource"
    Public Overrides Function NewsSource_Get(PortalConnect As String, newsSourceID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewsSource_Get", newsSourceID), IDataReader)
    End Function
    Public Overrides Function NewsSource_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewsSource_List", portalId), IDataReader)
    End Function
    Public Overrides Function NewsSource_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "NewsSource_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Sub NewsSource_Add(PortalConnect As String, newsSourceID As String, name As String, link As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
        SqlHelper.ExecuteScalar(flConnect.CmsConnect, "NewsSource_Add", newsSourceID, flReg.GetNull(name), flReg.GetNull(link), flReg.GetNull(portalId), flReg.GetNull(createdDate), flReg.GetNull(createdUser), flReg.GetNull(updatedBy), flReg.GetNull(updateName))
    End Sub
    Public Overrides Sub NewsSource_Update(PortalConnect As String, newsSourceID As String, name As String, link As String, portalId As Integer, createdDate As DateTime, createdUser As String, updatedBy As DateTime, updateName As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "NewsSource_Update", newsSourceID, flReg.GetNull(name), flReg.GetNull(link), flReg.GetNull(portalId), flReg.GetNull(createdDate), flReg.GetNull(createdUser), flReg.GetNull(updatedBy), flReg.GetNull(updateName))
    End Sub
    Public Overrides Sub NewsSource_Delete(PortalConnect As String, newsSourceID As String)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "NewsSource_Delete", newsSourceID)
    End Sub
#End Region
#Region "CMS_Business"
    Public Overrides Function CMS_Business_Get_All(strConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(strConnect, "CMS_Business_Get_All"), IDataReader)
    End Function
    Public Overrides Function CMS_JobUser_Get_All(strConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(strConnect, "CMS_JobUser_Get_All"), IDataReader)
    End Function
    Public Overrides Function CMS_Work_Get_All(strConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(strConnect, "CMS_Work_Get_All"), IDataReader)
    End Function
    Public Overrides Function CMS_CategoryOld_All(strConnect As String, pid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(strConnect, "TN_Topic_List", pid), IDataReader)
    End Function
    Public Overrides Function CMS_News_ListCate(strConnect As String, cateID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(strConnect, "TN_News_Get_By_TN_Topic", cateID), IDataReader)
    End Function
#End Region
#Region "DM_Slider"
    Public Overrides Function DM_Slider_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "DM_Slider_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_Slider_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "DM_Slider_List"), IDataReader)
    End Function
    Public Overrides Function DM_Slider_List_Home(PortalConnect As String, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "DM_Slider_List_Home", Top), IDataReader)
    End Function

    Public Overrides Function DM_Slider_Add(PortalConnect As String, obj As DM_SliderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "DM_Slider_Add", obj.TieuDe, obj.TieuDePhu, obj.MoTa, obj.LienKet, obj.ThuTu, obj.HoatDong, obj.Avatar), Integer)
    End Function
    Public Overrides Sub DM_Slider_Update(PortalConnect As String, obj As DM_SliderInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "DM_Slider_Update", obj.ID, obj.TieuDe, obj.TieuDePhu, obj.MoTa, obj.LienKet, obj.ThuTu, obj.HoatDong, obj.Avatar)
    End Sub
    Public Overrides Sub DM_Slider_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "DM_Slider_Delete", iD)
    End Sub
    Public Overrides Function DM_Slider_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "DM_Slider_List_Search", search, currPage, recodperpage), IDataReader)
    End Function
#End Region
#Region "CMS_NhomBanner"
    Public Overrides Function CMS_NhomBanner_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NhomBanner_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_NhomBanner_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NhomBanner_List"), IDataReader)
    End Function
    Public Overrides Function CMS_NhomBanner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_NhomBanner_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_NhomBanner_Add(PortalConnect As String, obj As CMS_NhomBannerInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_NhomBanner_Add", obj.Id, obj.TenNhomBanner, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_NhomBanner_Update(PortalConnect As String, obj As CMS_NhomBannerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NhomBanner_Update", obj.Id, obj.TenNhomBanner, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_NhomBanner_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_NhomBanner_Delete", id)
    End Sub
#End Region
#Region "CMS_Banner"
    Public Overrides Function CMS_Banner_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Banner_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Banner_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Banner_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_Banner_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_Banner_Add(PortalConnect As String, obj As CMS_BannerInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_Banner_Add", obj.Id, obj.IdNhomBanner, obj.TenBanner, obj.HinhAnh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub CMS_Banner_Update(PortalConnect As String, obj As CMS_BannerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Banner_Update", obj.Id, obj.IdNhomBanner, obj.TenBanner, obj.HinhAnh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub CMS_Banner_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_Banner_Delete", id)
    End Sub
#End Region
#Region "CMS_BackUp"
    Public Overrides Function CMS_BackUp_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_BackUp_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_BackUp_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_BackUp_List"), IDataReader)
    End Function
    Public Overrides Function CMS_BackUp_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.DmConnect, "CMS_BackUp_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function CMS_BackUp_Add(PortalConnect As String, obj As CMS_BackUpInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.DmConnect, "CMS_BackUp_Add", obj.TenBackup, obj.HeThongBackup, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsWriteLog), Integer)
    End Function
    Public Overrides Sub CMS_BackUp_Update(PortalConnect As String, obj As CMS_BackUpInfo)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_BackUp_Update", obj.Id, obj.TenBackup, obj.HeThongBackup, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsWriteLog)
    End Sub
    Public Overrides Sub CMS_BackUp_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.DmConnect, "CMS_BackUp_Delete", id)
    End Sub
#End Region
#Region "CMS_ThongBao"
    Public Overrides Function CMS_ThongBao_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ThongBao_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_ThongBao_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ThongBao_List"), IDataReader)
    End Function
    Public Overrides Function CMS_ThongBao_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String, Optional IsActive As Integer = -1) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.CmsConnect, "CMS_ThongBao_List_Search", search, isOrder, currPage, recodperpage, UserName, IsActive), IDataReader)
    End Function

    Public Overrides Function CMS_ThongBao_Add(PortalConnect As String, obj As CMS_ThongBaoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.CmsConnect, "CMS_ThongBao_Add", obj.TenThongBao, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsRead), Integer)
    End Function
    Public Overrides Sub CMS_ThongBao_Update(PortalConnect As String, obj As CMS_ThongBaoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_ThongBao_Update", obj.Id, obj.TenThongBao, obj.NoiDung, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsRead)
    End Sub
    Public Overrides Sub CMS_ThongBao_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.CmsConnect, "CMS_ThongBao_Delete", id)
    End Sub
#End Region

#Region "CMS_NewsAudio"
    Public Overrides Function CMS_NewsAudio_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_Get", iD), IDataReader)
    End Function
    Public Overrides Function CMS_NewsAudio_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_List"), IDataReader)
    End Function

    Public Overrides Function CMS_NewsAudio_ListByNewsID(PortalConnect As String, newsId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_ListByNewsID", newsId), IDataReader)
    End Function

    Public Overrides Function CMS_NewsAudio_Add(PortalConnect As String, obj As CMS_NewsAudioInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_Add", obj.NewsId, obj.AudioName, obj.AudioCode, obj.AudioPath, obj.IsActive), Integer)
    End Function
    Public Overrides Sub CMS_NewsAudio_Update(PortalConnect As String, obj As CMS_NewsAudioInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_Update", obj.ID, obj.NewsId, obj.AudioName, obj.AudioCode, obj.AudioPath, obj.IsActive)
    End Sub
    Public Overrides Sub CMS_NewsAudio_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect(PortalConnect), "CMS_NewsAudio_Delete", iD)
    End Sub
#End Region






End Class