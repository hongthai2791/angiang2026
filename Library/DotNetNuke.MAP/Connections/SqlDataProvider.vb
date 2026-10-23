Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.EPORTAL
Public Class SqlDataProvider
    Inherits DataProvider

#Region "CMS_Group"
    Public Overrides Function CMS_Group_Get(PortalConnect As String, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Group_Get", group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Group_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_By_ParentID(PortalConnect As String, asxh_id As Integer, parentid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Group_List_By_ParentID", asxh_id, parentid), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Parent_Null(PortalConnect As String, asxh_id As Integer, groupType As Int16) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Group_List_Parent_Null", asxh_id, groupType), IDataReader)
    End Function
    Public Overrides Function CMS_Group_List_Search(PortalConnect As String, asxh_id As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Group_List_Search", asxh_id, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function CMS_Group_Count_Parent(PortalConnect As String, group_ID As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Group_Count_Parent", group_ID), Integer)
    End Function

    Public Overrides Function CMS_Group_Add(PortalConnect As String, obj As CMS_GroupInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Group_Add", obj.Group_Code, obj.ASXH_ID, obj.ParentID, obj.Group_Name, obj.Group_Des, obj.GroupType, obj.ChartType, obj.ClassName, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder), Integer)
    End Function
    Public Overrides Sub CMS_Group_Update(PortalConnect As String, obj As CMS_GroupInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Group_Update", obj.Group_ID, obj.Group_Code, obj.ASXH_ID, obj.ParentID, obj.Group_Name, obj.Group_Des, obj.GroupType, obj.ChartType, obj.ClassName, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder)
    End Sub
    Public Overrides Sub CMS_Group_Update_IsHome(PortalConnect As String, groupId As Integer, isHome As Boolean)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Group_Update_IsHome", groupId, isHome)
    End Sub
    Public Overrides Sub CMS_Group_Delete(PortalConnect As String, group_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Group_Delete", group_ID)
    End Sub
#End Region

#Region "CMS_Targets"
    Public Overrides Function CMS_Targets_List_By_Group_Parent(PortalConnect As String, group_ID As Integer, ParentID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_By_Group_Parent", group_ID, ParentID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Temp_Parent_NULL(PortalConnect As String, temp_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get_By_CMS_Temp_Parent_NULL", temp_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Temp_Parent_ID(PortalConnect As String, temp_ID As Integer, Parent_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get_By_CMS_Temp_Parent_ID", temp_ID, Parent_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_By_Group_ID(PortalConnect As String, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_By_Group_ID", group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get(PortalConnect As String, targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get", targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_ByCode(PortalConnect As String, targets_code As String) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Targets_Get_ByCode", targets_code), Integer)
    End Function
    Public Overrides Function CMS_Targets_List_TinhTP(PortalConnect As String, TinhTP As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_TinhTP", TinhTP), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Count_TinhTP(PortalConnect As String, TinhTP As Integer) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Targets_Count_TinhTP", TinhTP)
    End Function
    Public Overrides Function CMS_Targets_GenCode(PortalConnect As String, maTinh As Integer, maHuyen As Integer, maXa As Integer, asxh_id As Integer, group_id As Integer, targetID As Integer, parentID As Integer) As String
        Return SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Targets_GenCode", maTinh, maHuyen, maXa, asxh_id, group_id, targetID, parentID)
    End Function
    Public Overrides Function CMS_Sys_CopyTarget(PortalConnect As String, TinhTP1 As Integer, TinhTP2 As Integer, CreatedUser As String, CreatedDate As DateTime) As Integer
        Return SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Sys_CopyTarget", TinhTP1, TinhTP2, CreatedUser, CreatedDate)
    End Function
    Public Overrides Function CMS_Targets_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List"), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_IsGroup(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_IsGroup"), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_ByCateTar(PortalConnect As String, GroupID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_ByCateTar", GroupID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Search", search, isOrder, currPage, recodperpage, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Parent_Null(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Parent_Null", tinhTP, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Parent_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Parent_Foreign", tinhTp, quanHuyen, phuongXa, thonTo, yearId), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Parent_Null_ByRegTar(PortalConnect As String, tinhTP As Integer, group_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Parent_Null_ByRegTar", tinhTP, group_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Parent_Search_Null(PortalConnect As String, search As String, isOrder As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Parent_Search_Null", search, isOrder), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Parent_Search_ID(PortalConnect As String, tinhTp As Integer, quanhuyen As Integer, phuongxa As Integer, search As String, asxh_id As Integer, group_id As Integer, Parent_ID As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Parent_Search_ID", tinhTp, quanhuyen, phuongxa, search, asxh_id, group_id, Parent_ID, currPage, recodperpage), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Analytic(PortalConnect As String, tinhTp As Integer, search As String, group_id As Integer, Parent_ID As Integer, isMain As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Analytic", tinhTp, search, group_id, Parent_ID, isMain), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_List_Select(PortalConnect As String, tinhTp As Integer, asxh_id As Integer, group_id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_List_Select", tinhTp, asxh_id, group_id), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Targets(PortalConnect As String, Targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get_By_CMS_Targets", Targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Targets_Foreign(PortalConnect As String, tinhTp As Integer, quanHuyen As Integer, phuongXa As Integer, thonTo As Integer, yearId As Integer, Targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get_By_CMS_Targets_Foreign", tinhTp, quanHuyen, phuongXa, thonTo, yearId, Targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Get_By_CMS_Targets_ByRegTar(PortalConnect As String, tinhTp As Integer, Targets_ID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Targets_Get_By_CMS_Targets_ByRegTar", tinhTp, Targets_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Targets_Add(PortalConnect As String, obj As CMS_TargetsInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Targets_Add", obj.TinhTP, obj.Quanhuyen, obj.Phuongxa, obj.ASXH_ID, obj.Group_ID, obj.Targets_Code, obj.Targets_Name, obj.Targets_Sort, obj.Targets_Des, obj.Targets_Src, obj.Targets_Caculator, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsSum, obj.IsHome, obj.IsChild, obj.IsGroup, obj.IsMain, obj.UnitTypeID), Integer)
    End Function
    Public Overrides Sub CMS_Targets_Update(PortalConnect As String, obj As CMS_TargetsInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Targets_Update", obj.Targets_ID, obj.TinhTP, obj.Quanhuyen, obj.Phuongxa, obj.ASXH_ID, obj.Group_ID, obj.Targets_Code, obj.Targets_Name, obj.Targets_Sort, obj.Targets_Des, obj.Targets_Src, obj.Targets_Caculator, flReg.GetNull(obj.Parent_ID), obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdatedDate), obj.UpdatedUser, obj.IsOrder, obj.IsSum, obj.IsHome, obj.IsChild, obj.IsGroup, obj.IsMain, obj.UnitTypeID)
    End Sub
    Public Overrides Sub CMS_Targets_Delete(PortalConnect As String, targets_ID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Targets_Delete", targets_ID)
    End Sub
#End Region
#Region "Banner"
    Public Overrides Function Banner_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "Banner_Get", id), IDataReader)
    End Function
    Public Overrides Function Banner_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "Banner_List"), IDataReader)
    End Function
    Public Overrides Function Banner_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "Banner_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function Banner_Add(PortalConnect As String, obj As BannerInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "Banner_Add", obj.TenBanner, obj.LinkURL, obj.HinhAnh, obj.GhiChu, obj.ViTri, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub Banner_Update(PortalConnect As String, obj As BannerInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "Banner_Update", obj.Id, obj.TenBanner, obj.LinkURL, obj.HinhAnh, obj.GhiChu, obj.ViTri, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub Banner_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "Banner_Delete", id)
    End Sub
#End Region
#Region "LienKet"
    Public Overrides Function LienKet_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LienKet_Get", id), IDataReader)
    End Function
    Public Overrides Function LienKet_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LienKet_List"), IDataReader)
    End Function
    Public Overrides Function LienKet_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LienKet_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function LienKet_Add(PortalConnect As String, obj As LienKetInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "LienKet_Add", obj.TenLienKet, obj.LinkURL, obj.HinhAnh, obj.GhiChu, obj.ViTri, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub LienKet_Update(PortalConnect As String, obj As LienKetInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "LienKet_Update", obj.Id, obj.TenLienKet, obj.LinkURL, obj.HinhAnh, obj.GhiChu, obj.ViTri, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub LienKet_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "LienKet_Delete", id)
    End Sub
#End Region
#Region "MauSac"
    Public Overrides Function MauSac_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MauSac_Get", id), IDataReader)
    End Function
    Public Overrides Function MauSac_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MauSac_List"), IDataReader)
    End Function
    Public Overrides Function MauSac_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MauSac_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MauSac_Add(PortalConnect As String, obj As MauSacInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MauSac_Add", obj.TenMauSac, obj.ThuocTinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MauSac_Update(PortalConnect As String, obj As MauSacInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MauSac_Update", obj.Id, obj.TenMauSac, obj.ThuocTinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MauSac_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MauSac_Delete", id)
    End Sub
#End Region
#Region "LopBanDo"
    Public Overrides Function LopBanDo_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LopBanDo_Get", id), IDataReader)
    End Function
    Public Overrides Function LopBanDo_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LopBanDo_List"), IDataReader)
    End Function
    Public Overrides Function LopBanDo_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LopBanDo_List_Search", MaTinh, MaHuyen, MaXa, MaThon, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function LopBanDo_Add(PortalConnect As String, obj As LopBanDoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "LopBanDo_Add", obj.IdMauSac, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.TenLop, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.ViDo, obj.KinhDo, obj.TenTinh, obj.TenQuan, obj.TenXa, obj.TenThon), Integer)
    End Function
    Public Overrides Sub LopBanDo_Update(PortalConnect As String, obj As LopBanDoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "LopBanDo_Update", obj.Id, obj.IdMauSac, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.TenLop, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.ViDo, obj.KinhDo, obj.TenTinh, obj.TenQuan, obj.TenXa, obj.TenThon)
    End Sub
    Public Overrides Sub LopBanDo_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "LopBanDo_Delete", id)
    End Sub
    Public Overrides Sub LopBanDo_DeleteMauSac(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "LopBanDo_DeleteMauSac", id)
    End Sub
    Public Overrides Function LopBanDo_List_ById(PortalConnect As String, IdStr As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LopBanDo_List_ById", IdStr), IDataReader)
    End Function
    Public Overrides Function LopBanDo_List_Search_By(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, TargetGroup As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "LopBanDo_List_Search_By", MaTinh, MaHuyen, MaXa, MaThon, TargetGroup), IDataReader)
    End Function
    Public Overrides Function Map_List_Search_ByDoanhNghiep(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "Map_List_Search_ByDoanhNghiep", MaTinh, MaHuyen, MaXa), IDataReader)
    End Function
    Public Overrides Function Map_List_Search_ByTuyenDung(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "Map_List_Search_ByTuyenDung", MaTinh, MaHuyen, MaXa), IDataReader)
    End Function
#End Region
#Region "DiemLop"
    Public Overrides Function DiemLop_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DiemLop_Get", id), IDataReader)
    End Function
    Public Overrides Function DiemLop_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DiemLop_List"), IDataReader)
    End Function
    Public Overrides Function DiemLop_List_Search(PortalConnect As String, MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThon As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DiemLop_List_Search", MaTinh, MaHuyen, MaXa, MaThon, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function DiemLop_Add(PortalConnect As String, obj As DiemLopInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "DiemLop_Add", obj.IdLop, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.TenDiemLop, obj.ToaDo, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub DiemLop_Update(PortalConnect As String, obj As DiemLopInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "DiemLop_Update", obj.Id, obj.IdLop, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.TenDiemLop, obj.ToaDo, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub DiemLop_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "DiemLop_Delete", id)
    End Sub
#End Region
#Region "VungBanDo"
    Public Overrides Function VungBanDo_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "VungBanDo_Get", id), IDataReader)
    End Function
    Public Overrides Function VungBanDo_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "VungBanDo_List"), IDataReader)
    End Function
    Public Overrides Function VungBanDo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "VungBanDo_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function VungBanDo_Add(PortalConnect As String, obj As VungBanDoInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "VungBanDo_Add", obj.TenVungBanDo, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub VungBanDo_Update(PortalConnect As String, obj As VungBanDoInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "VungBanDo_Update", obj.Id, obj.TenVungBanDo, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub VungBanDo_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "VungBanDo_Delete", id)
    End Sub
#End Region
#Region "BoCuc"
    Public Overrides Function BoCuc_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "BoCuc_Get", id), IDataReader)
    End Function
    Public Overrides Function BoCuc_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "BoCuc_List"), IDataReader)
    End Function
    Public Overrides Function BoCuc_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "BoCuc_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function BoCuc_Add(PortalConnect As String, obj As BoCucInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "BoCuc_Add", obj.IdVungBanDo, obj.TenBoCuc, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub BoCuc_Update(PortalConnect As String, obj As BoCucInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "BoCuc_Update", obj.Id, obj.IdVungBanDo, obj.TenBoCuc, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub BoCuc_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "BoCuc_Delete", id)
    End Sub
#End Region
#Region "MAP_API"
    Public Overrides Function MAP_API_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_API_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_API_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_API_List"), IDataReader)
    End Function
    Public Overrides Function MAP_API_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_API_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Function MAP_API_Add(PortalConnect As String, obj As MAP_APIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().MapConnect, "MAP_API_Add", obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_API_Update(PortalConnect As String, obj As MAP_APIInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "MAP_API_Update", obj.Id, obj.TenAPI, obj.LinkAPI, obj.Author, obj.Body, obj.GhiChu, obj.KieuAPI, obj.GhiDuLieu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_API_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "MAP_API_Delete", id, userId)
    End Sub
#End Region
#Region "MAP_APIHeader"
    Public Overrides Function MAP_APIHeader_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_APIHeader_Get", id), IDataReader)
    End Function
    'Public Overrides Function APIHeader_List(PortalConnect As String, idAPI As Integer) As IDataReader
    '    Return CType(SqlHelper.ExecuteReader(New flConnect().ChatbotConnect, "APIHeader_List", idAPI), IDataReader)
    'End Function

    Public Overrides Function MAP_APIHeader_Add(PortalConnect As String, obj As MAP_APIHeaderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().MapConnect, "MAP_APIHeader_Add", obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_APIHeader_Update(PortalConnect As String, obj As MAP_APIHeaderInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "MAP_APIHeader_Update", obj.Id, obj.IdAPI, obj.APIKey, obj.APIValue, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_APIHeader_Delete(PortalConnect As String, id As Integer, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "MAP_APIHeader_Delete", id, userId)
    End Sub
    Public Overrides Function MAP_APIHeader_List_Search(PortalConnect As String, idAPI As Integer, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "MAP_APIHeader_List_Search", idAPI, search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function
    Public Overrides Sub MAP_APIHeader_LichDongBo(PortalConnect As String, id As String, lichDongBo As String, userId As String)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "MAP_APIHeader_LichDongBo", id, lichDongBo, userId)
    End Sub
#End Region
#Region "MAP_LogsAPI"
    Public Overrides Function MAP_LogsAPI_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_LogsAPI_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_LogsAPI_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_LogsAPI_List"), IDataReader)
    End Function
    Public Overrides Function MAP_LogsAPI_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_LogsAPI_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MAP_LogsAPI_Add(PortalConnect As String, obj As MAP_LogsAPIInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_LogsAPI_Add", obj.IdAPI, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_LogsAPI_Update(PortalConnect As String, obj As MAP_LogsAPIInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_LogsAPI_Update", obj.Id, obj.IdAPI, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_LogsAPI_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_LogsAPI_Delete", id)
    End Sub
#End Region
#Region "MAP_NhomMenu"
    Public Overrides Function MAP_NhomMenu_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_NhomMenu_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_NhomMenu_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_NhomMenu_List"), IDataReader)
    End Function
    Public Overrides Function MAP_NhomMenu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_NhomMenu_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MAP_NhomMenu_Add(PortalConnect As String, obj As MAP_NhomMenuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_NhomMenu_Add", obj.TenMenu, obj.LinkURL, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_NhomMenu_Update(PortalConnect As String, obj As MAP_NhomMenuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_NhomMenu_Update", obj.Id, obj.TenMenu, obj.LinkURL, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_NhomMenu_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_NhomMenu_Delete", id)
    End Sub
#End Region
#Region "MAP_Menu"
    Public Overrides Function MAP_Menu_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_Menu_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_Menu_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_Menu_List"), IDataReader)
    End Function
    Public Overrides Function MAP_Menu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_Menu_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MAP_Menu_Add(PortalConnect As String, obj As MAP_MenuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_Menu_Add", obj.IdMenu, obj.TenMenu, obj.LinkURL, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_Menu_Update(PortalConnect As String, obj As MAP_MenuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_Menu_Update", obj.Id, obj.IdMenu, obj.TenMenu, obj.LinkURL, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_Menu_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_Menu_Delete", id)
    End Sub
#End Region
#Region "HT_ThietLap"
    Public Overrides Function HT_ThietLap_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(New flConnect().MapConnect, "HT_ThietLap_Get", id), IDataReader)
    End Function

    Public Overrides Function HT_ThietLap_Add(PortalConnect As String, obj As HT_ThietLapInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(New flConnect().MapConnect, "HT_ThietLap_Add", obj.MaThietLap, obj.TenThietLap, obj.GiaTri, obj.GiaTriMacDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub HT_ThietLap_Update(PortalConnect As String, obj As HT_ThietLapInfo)
        SqlHelper.ExecuteNonQuery(New flConnect().MapConnect, "HT_ThietLap_Update", obj.Id, obj.MaThietLap, obj.TenThietLap, obj.GiaTri, obj.GiaTriMacDinh, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
#End Region

#Region "CMS_Advertise"
    Public Overrides Function CMS_Advertise_Get_By_Category(PortalConnect As String, PageLoca_ID As String, CategoryID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_Get_By_Category", PageLoca_ID, CategoryID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_Get(PortalConnect As String, advertise_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_Get", advertise_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Home(PortalConnect As String, PortalID As Integer, pageLocaID As String, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_List_Home", PortalID, pageLocaID, Top), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Update_Quick(PortalConnect As String, advertise_ID As String, isActive As Boolean, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Advertise_Update_Quick", advertise_ID, isActive, isOrder)
    End Sub
    Public Overrides Function CMS_Advertise_Get_By_CMS_PageLoca(PortalConnect As String, pageLoca_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_Get_By_CMS_PageLoca", pageLoca_ID), IDataReader)
    End Function
    Public Overrides Function CMS_Advertise_List_Search(PortalConnect As String, portalID As Integer, isLang As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, pageLoca_ID As String, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Advertise_List_Search", portalID, isLang, search, isOrder, currPage, recodperpage, pageLoca_ID, UserName), IDataReader)
    End Function
    Public Overrides Sub CMS_Advertise_Add(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Advertise_Add", obj.Advertise_ID, obj.Advertise_Name, obj.ImgType, obj.Images, obj.IsWith, obj.IsHeight, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsLang, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.PageLoca_ID, obj.PortalID, obj.CategoryID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Advertise_Update(PortalConnect As String, obj As CMS_AdvertiseInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Advertise_Update", obj.Advertise_ID, obj.Advertise_Name, obj.ImgType, obj.Images, obj.IsWith, obj.IsHeight, obj.Target, obj.IsURL, flReg.GetNull(obj.StartDate), flReg.GetNull(obj.EndDate), obj.IsLang, obj.IsActive, obj.IsOrder, obj.CreatedBy, obj.UserName, flReg.GetNull(obj.UpdatedBy), obj.UserUpdate, obj.PageLoca_ID, obj.PortalID, obj.CategoryID, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Advertise_Delete(PortalConnect As String, advertise_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Advertise_Delete", advertise_ID)
    End Sub
#End Region
#Region "CMS_Menu"
    Public Overrides Function CMS_Menu_Get(PortalConnect As String, menuID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Menu_Get", menuID), IDataReader)
    End Function
    Public Overrides Function CMS_Menu_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Menu_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Menu_Add(PortalConnect As String, obj As CMS_MenuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Menu_Add", obj.MenuName, obj.IsOrder, obj.PortalId), Integer)
    End Function
    Public Overrides Sub CMS_Menu_Update(PortalConnect As String, obj As CMS_MenuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Menu_Update", obj.MenuID, obj.MenuName, obj.IsOrder, obj.PortalId)
    End Sub
    Public Overrides Sub CMS_Menu_Delete(PortalConnect As String, menuID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Menu_Delete", menuID)
    End Sub
#End Region
#Region "CMS_MenuD"
    Public Overrides Function CMS_MenuD_Get(PortalConnect As String, menuD_ID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_MenuD_Get", menuD_ID), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_MenuD_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_MenuID(PortalConnect As String, menuID As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_MenuD_List_By_MenuID", menuID, portalId), IDataReader)
    End Function
    Public Overrides Function CMS_MenuD_List_By_ParentID(PortalConnect As String, paID As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_MenuD_List_By_ParentID", paID), IDataReader)
    End Function
    Public Overrides Sub CMS_MenuD_Update_Quick(PortalConnect As String, menuD_ID As String, parent_ID As String, isOrder As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_MenuD_Update_Quick", menuD_ID, parent_ID, isOrder)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete_By_MenuID(PortalConnect As String, menu_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_MenuD_Delete_By_MenuID", menu_ID)
    End Sub
    Public Overrides Sub CMS_MenuD_Add(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_MenuD_Add", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Update(PortalConnect As String, obj As CMS_MenuDInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_MenuD_Update", obj.MenuD_ID, obj.MenuD_Name, obj.Menu_ID, obj.Parent_ID, obj.Url, obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.SendView)
    End Sub
    Public Overrides Sub CMS_MenuD_Delete(PortalConnect As String, menuD_ID As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_MenuD_Delete", menuD_ID)
    End Sub
#End Region
#Region "CMS_Infomation"
    Public Overrides Function CMS_Infomation_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Infomation_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_Infomation_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_Infomation_List", portalId), IDataReader)
    End Function

    Public Overrides Function CMS_Infomation_Add(PortalConnect As String, obj As CMS_InfomationInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_Infomation_Add", flReg.GetNull(obj.NameH1), flReg.GetNull(obj.NameH2), flReg.GetNull(obj.NameH3), obj.ImagePath, obj.ImageRight, obj.Footer, obj.Infomation, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalId, obj.LanguageId, obj.SendView), Integer)
    End Function
    Public Overrides Sub CMS_Infomation_Update(PortalConnect As String, obj As CMS_InfomationInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Infomation_Update", obj.Id, flReg.GetNull(obj.NameH1), flReg.GetNull(obj.NameH2), flReg.GetNull(obj.NameH3), obj.ImagePath, obj.ImageRight, obj.Footer, obj.Infomation, flReg.GetNull(obj.CreatedDate), obj.CreatedUser, flReg.GetNull(obj.UpdateDate), obj.UpdateUser, obj.PortalId, obj.LanguageId, obj.SendView)
    End Sub
    Public Overrides Sub CMS_Infomation_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_Infomation_Delete", id)
    End Sub
#End Region

#Region "DM_Slider"
    Public Overrides Function DM_Slider_Get(PortalConnect As String, iD As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DM_Slider_Get", iD), IDataReader)
    End Function
    Public Overrides Function DM_Slider_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DM_Slider_List"), IDataReader)
    End Function
    Public Overrides Function DM_Slider_List_Home(PortalConnect As String, Top As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DM_Slider_List_Home", Top), IDataReader)
    End Function

    Public Overrides Function DM_Slider_Add(PortalConnect As String, obj As DM_SliderInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "DM_Slider_Add", obj.TieuDe, obj.TieuDePhu, obj.MoTa, obj.LienKet, obj.ThuTu, obj.HoatDong, obj.Avatar), Integer)
    End Function
    Public Overrides Sub DM_Slider_Update(PortalConnect As String, obj As DM_SliderInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "DM_Slider_Update", obj.ID, obj.TieuDe, obj.TieuDePhu, obj.MoTa, obj.LienKet, obj.ThuTu, obj.HoatDong, obj.Avatar)
    End Sub
    Public Overrides Sub DM_Slider_Delete(PortalConnect As String, iD As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "DM_Slider_Delete", iD)
    End Sub
    Public Overrides Function DM_Slider_List_Search(PortalConnect As String, search As String, currPage As Integer, recodperpage As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "DM_Slider_List_Search", search, currPage, recodperpage), IDataReader)
    End Function
#End Region

#Region "CMS_WebLink"
    Public Overrides Function CMS_WebLink_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_WebLink_Get", id), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_WebLink_List", portalId), IDataReader)
    End Function
    Public Overrides Sub CMS_WebLink_Update_Order(PortalConnect As String, Id As Integer, OrderNo As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_WebLink_Update_Order", Id, OrderNo)
    End Sub
    Public Overrides Function CMS_WebLink_List_Search(PortalConnect As String, Name As String, ViewType As Integer, PortalId As Integer, LanguageId As String, PageSize As Integer, PageIndex As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_WebLink_List_Search", Name, ViewType, PortalId, LanguageId, PageSize, PageIndex), IDataReader)
    End Function
    Public Overrides Function CMS_WebLink_Add(PortalConnect As String, obj As CMS_WebLinkInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_WebLink_Add", flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate)), Integer)
    End Function
    Public Overrides Sub CMS_WebLink_Update(PortalConnect As String, obj As CMS_WebLinkInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_WebLink_Update", obj.Id, flReg.GetNull(obj.Name), flReg.GetNull(obj.OrderNo), flReg.GetNull(obj.Url), flReg.GetNull(obj.Image), flReg.GetNull(obj.Description), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.LanguageId), flReg.GetNull(obj.ViewCount), obj.ViewType, obj.SendView, flReg.GetNull(obj.UserName), flReg.GetNull(obj.Createdate))
    End Sub
    Public Overrides Sub CMS_WebLink_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_WebLink_Delete", id)
    End Sub
#End Region

#Region "CMS_NewsCategories"
    Public Overrides Function CMS_NewsCategories_List_By_Parent(PortalConnect As String, Parentid As Integer, PortalId As Integer, LanguageId As String, Type As Integer) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_List_By_Parent", Parentid, PortalId, LanguageId, Type)
    End Function
    Public Overrides Sub CMS_NewsCategories_UpdateTabId(PortalConnect As String, categoryid As Integer, tabid As Integer, TabPath As String)
        SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_UpdateTabId", categoryid, tabid, TabPath)
    End Sub
    Public Overrides Sub CMS_NewsCategories_Update_Order(PortalConnect As String, categoryid As Integer, OrderNumber As Integer)
        SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Update_Order", categoryid, OrderNumber)
    End Sub
    Public Overrides Function CMS_NewsCategories_ByParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0, Optional Search As String = "") As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_ByParentId", PortalId, LanguageId, Type, ParentId, Search)
    End Function
    Public Overrides Function CMS_NewsCategoriesPermission_Get_By_Category(PortalConnect As String, userId As String, categoryId As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, ("CMS_NewsCategoriesPermission_Get_By_Category"), userId, categoryId), Integer)
    End Function
    Public Overrides Function CMS_NewsCategories_List_All(PortalConnect As String, PortalId As Integer, LanguageId As String, Optional Type As Integer = 1) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_List_All", PortalId, LanguageId, Type)
    End Function
    Public Overrides Sub CMS_NewsByCategory_Delete_By_NewsID(PortalConnect As String, NewsId As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_NewsByCategory_Delete_By_NewsID", NewsId, PortalConnect)
    End Sub
    Public Overrides Function CMS_NewsCategories_Get_By_ParentId(PortalConnect As String, PortalId As Integer, LanguageId As String, UserID As String, Optional Type As Integer = 1, Optional ParentId As Integer = 0) As IDataReader
        Return SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get_By_ParentId", PortalId, LanguageId, UserID, Type, ParentId)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_By_TabID_Parent(PortalConnect As String, TabId As Integer, Parent As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get_By_TabID_Parent", TabId, Parent), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_ID_By_TabMobileID(PortalConnect As String, TabId As Integer, Parent As Boolean) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get_ID_By_TabMobileID", TabId, Parent), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_TabPath(PortalConnect As String, categoryid As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get_TabPath", categoryid), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get_By_TabID(PortalConnect As String, tabID As Integer, portalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get_By_TabID", tabID, portalID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Get(PortalConnect As String, categoryID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_Get", categoryID), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_List(PortalConnect As String, portalId As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_NewsCategories_List", portalId), IDataReader)
    End Function
    Public Overrides Function CMS_NewsCategories_Add(PortalConnect As String, obj As CMS_NewsCategoriesInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_NewsCategories_Add", obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.TabID), flReg.GetNull(obj.TabMobileID), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.OrderNumber), flReg.GetNull(obj.Type), flReg.GetNull(obj.LanguageId), obj.SendView, flReg.GetNull(obj.TabPath)), Integer)
    End Function
    Public Overrides Sub CMS_NewsCategories_Update(PortalConnect As String, obj As CMS_NewsCategoriesInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_NewsCategories_Update", obj.CategoryID, obj.CategoryName, flReg.GetNull(obj.Description), flReg.GetNull(obj.TabID), flReg.GetNull(obj.TabMobileID), flReg.GetNull(obj.IsActive), flReg.GetNull(obj.CreateDate), flReg.GetNull(obj.PortalId), flReg.GetNull(obj.ParentId), flReg.GetNull(obj.OrderNumber), flReg.GetNull(obj.Type), flReg.GetNull(obj.LanguageId), obj.SendView, flReg.GetNull(obj.TabPath))
    End Sub
    Public Overrides Sub CMS_NewsCategories_Delete(PortalConnect As String, categoryID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_NewsCategories_Delete", categoryID)
    End Sub
#End Region
#Region "MAP_DATA"
    Public Overrides Function MAP_DATA_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_GetData(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_DATA_GetData", tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, types), Integer)
    End Function
    Public Overrides Function MAP_DATA_ListData_By_List(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, color As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_ListData_By_List", tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, color), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_ListData_ForMap(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String, thonTo As String, yearId As Integer, targetCode As String, types As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_ListData_ForMap", tinhTp, quanHuyen, phuongXa, thonTo, yearId, targetCode, types), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_List"), IDataReader)
    End Function

    Public Overrides Function MAP_DATA_Add(PortalConnect As String, obj As MAP_DATAInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_DATA_Add", obj.TargetID, obj.TargetCode, obj.TargetName, obj.YearID, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.Data, obj.GroupId, obj.Types), Integer)
    End Function
    Public Overrides Sub MAP_DATA_Update(PortalConnect As String, obj As MAP_DATAInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_Update", obj.Id, obj.TargetID, obj.TargetCode, obj.TargetName, obj.YearID, obj.MaTinh, obj.MaHuyen, obj.MaXa, obj.MaThon, obj.Data, obj.GroupId)
    End Sub
    Public Overrides Sub MAP_DATA_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_Delete", id)
    End Sub
#End Region
#Region "MAP_DATA_BUSSINESS"
    Public Overrides Function MAP_DATA_BUSSINESS_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_BUSSINESS_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_BUSSINESS_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_BUSSINESS_List"), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_BUSSINESS_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_BUSSINESS_List_Search", key, currPage, recordPerPage, tinhTp, quanHuyen, phuongXa), IDataReader)
    End Function

    Public Overrides Function MAP_DATA_BUSSINESS_Add(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_DATA_BUSSINESS_Add", obj.Business_ID, obj.Business_Vn, obj.TinhTP, obj.QuanHuyen, obj.Description, obj.TaxCode, obj.Mobile, obj.Fax, obj.Website, obj.Email, obj.Address, obj.Lat, obj.Lng, obj.LoaiHinh_ID, obj.Career_ID, obj.ToURL), Integer)
    End Function
    Public Overrides Sub MAP_DATA_BUSSINESS_Update(PortalConnect As String, obj As MAP_DATA_BUSSINESSInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_BUSSINESS_Update", obj.Id, obj.Business_ID, obj.Business_Vn, obj.TinhTP, obj.QuanHuyen, obj.Description, obj.TaxCode, obj.Mobile, obj.Fax, obj.Website, obj.Email, obj.Address, obj.Lat, obj.Lng)
    End Sub
    Public Overrides Sub MAP_DATA_BUSSINESS_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_BUSSINESS_Delete", id)
    End Sub
    Public Overrides Sub MAP_DATA_BUSSINESS_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_BUSSINESS_Delete_ByHC", tinhTp, quanHuyen, phuongXa)
    End Sub
#End Region
#Region "MAP_DATA_WORK"
    Public Overrides Sub MAP_DATA_WORK_Delete_ByHC(PortalConnect As String, tinhTp As String, quanHuyen As String, phuongXa As String)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_WORK_Delete_ByHC", tinhTp, quanHuyen, phuongXa)
    End Sub
    Public Overrides Function MAP_DATA_WORK_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_WORK_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_WORK_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_WORK_List"), IDataReader)
    End Function
    Public Overrides Function MAP_DATA_WORK_List_Search(PortalConnect As String, key As String, currPage As Integer, recordPerPage As Integer, tinhTp As String, quanHuyen As String, phuongXa As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_DATA_WORK_List_Search", key, currPage, recordPerPage, tinhTp, quanHuyen, phuongXa), IDataReader)
    End Function

    Public Overrides Function MAP_DATA_WORK_Add(PortalConnect As String, obj As MAP_DATA_WORKInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_DATA_WORK_Add", obj.Work_ID, obj.Business_ID, obj.Title, obj.Salary_ID, obj.Quantity, obj.Experience_ID, obj.Gender, obj.Level_ID, obj.TinhTP, obj.QuanHuyen, obj.TypeOf_ID, obj.Career_ID, obj.Description, obj.ExpiredDate, obj.StartDate, obj.EndDate, obj.IsHot, obj.IsUrgent, obj.Lat, obj.Lng, obj.TenTinh, obj.TenHuyen, obj.TenXa, obj.MucLuong, obj.KinhNghiem, obj.TenDoanhNghiep, obj.ToUrl), Integer)
    End Function
    Public Overrides Sub MAP_DATA_WORK_Update(PortalConnect As String, obj As MAP_DATA_WORKInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_WORK_Update", obj.Id, obj.Work_ID, obj.Business_ID, obj.Title, obj.Salary_ID, obj.Quantity, obj.Experience_ID, obj.Gender, obj.Level_ID, obj.TinhTP, obj.QuanHuyen, obj.TypeOf_ID, obj.Career_ID, obj.Description, obj.ExpiredDate, obj.StartDate, obj.EndDate, obj.IsHot, obj.IsUrgent, obj.Lat, obj.Lng)
    End Sub
    Public Overrides Sub MAP_DATA_WORK_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_DATA_WORK_Delete", id)
    End Sub
#End Region

#Region "CMS_PageLocal"
    Public Overrides Function CMS_PageLocal_Get(PortalConnect As String, pageLocalID As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_PageLocal_Get", pageLocalID), IDataReader)
    End Function
    Public Overrides Function CMS_PageLocal_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "CMS_PageLocal_List"), IDataReader)
    End Function

    Public Overrides Sub CMS_PageLocal_Add(PortalConnect As String, obj As CMS_PageLocalInfo)
        SqlHelper.ExecuteScalar(flConnect.MapConnect, "CMS_PageLocal_Add", obj.PageLocalID, obj.PageLocal_Name, obj.IsOrder, flReg.GetNull(obj.ImagePath))
    End Sub
    Public Overrides Sub CMS_PageLocal_Update(PortalConnect As String, obj As CMS_PageLocalInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_PageLocal_Update", obj.PageLocalID, obj.PageLocal_Name, obj.IsOrder, flReg.GetNull(obj.ImagePath))
    End Sub
    Public Overrides Sub CMS_PageLocal_Delete(PortalConnect As String, pageLocalID As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "CMS_PageLocal_Delete", pageLocalID)
    End Sub
#End Region

#Region "MAP_KyNhapLieu"
    Public Overrides Function MAP_KyNhapLieu_Get(PortalConnect As String, id As Integer) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_KyNhapLieu_Get", id), IDataReader)
    End Function
    Public Overrides Function MAP_KyNhapLieu_List(PortalConnect As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_KyNhapLieu_List"), IDataReader)
    End Function
    Public Overrides Function MAP_KyNhapLieu_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.MapConnect, "MAP_KyNhapLieu_List_Search", search, isOrder, currPage, recodperpage, UserName), IDataReader)
    End Function

    Public Overrides Function MAP_KyNhapLieu_Add(PortalConnect As String, obj As MAP_KyNhapLieuInfo) As Integer
        Return CType(SqlHelper.ExecuteScalar(flConnect.MapConnect, "MAP_KyNhapLieu_Add", obj.Ma, obj.Ten, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser), Integer)
    End Function
    Public Overrides Sub MAP_KyNhapLieu_Update(PortalConnect As String, obj As MAP_KyNhapLieuInfo)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_KyNhapLieu_Update", obj.Id, obj.Ma, obj.Ten, obj.GhiChu, obj.IsActive, obj.IsOrder, obj.IsDelete, obj.DeletedUser, obj.DeletedDate, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser)
    End Sub
    Public Overrides Sub MAP_KyNhapLieu_Delete(PortalConnect As String, id As Integer)
        SqlHelper.ExecuteNonQuery(flConnect.MapConnect, "MAP_KyNhapLieu_Delete", id)
    End Sub
#End Region


End Class