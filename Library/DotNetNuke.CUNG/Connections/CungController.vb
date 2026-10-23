Imports DotNetNuke.Common.Utilities
Public Class CungController

#Region "CMS_Provide_Book"
    Public Function CMS_Provide_Book_Get(PortalConnect As String, book_ID As String) As CMS_Provide_BookInfo
        Return CBO.FillObject(Of CMS_Provide_BookInfo)(DataProvider.Instance().CMS_Provide_Book_Get(PortalConnect, book_ID))
    End Function
    Public Function CMS_Provide_Book_List(PortalConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Book_List(PortalConnect, portalId), GetType(CMS_Provide_BookInfo))
    End Function

    Public Sub CMS_Provide_Book_Add(PortalConnect As String, obj As CMS_Provide_BookInfo)
        DataProvider.Instance().CMS_Provide_Book_Add(PortalConnect, obj)
    End Sub
    Public Sub CMS_Provide_Book_Update(PortalConnect As String, obj As CMS_Provide_BookInfo)
        DataProvider.Instance().CMS_Provide_Book_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Provide_Book_Delete(PortalConnect As String, book_ID As String)
        DataProvider.Instance().CMS_Provide_Book_Delete(PortalConnect, book_ID)
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
#Region "CMS_Reason"
    Public Function CMS_Reason_Get(PortalConnect As String, reason_ID As Integer) As CMS_ReasonInfo
        Return CBO.FillObject(Of CMS_ReasonInfo)(DataProvider.Instance().CMS_Reason_Get(PortalConnect, reason_ID))
    End Function
    Public Function CMS_Reason_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Reason_List(PortalConnect), GetType(CMS_ReasonInfo))
    End Function
    Public Function CMS_Reason_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Reason_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_ReasonInfo))
    End Function

    Public Function CMS_Reason_Add(PortalConnect As String, obj As CMS_ReasonInfo) As Integer
        Return DataProvider.Instance().CMS_Reason_Add(PortalConnect, obj.Reason_Code, obj.Reason_Name, obj.Reason_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_Reason_Update(PortalConnect As String, obj As CMS_ReasonInfo)
        DataProvider.Instance().CMS_Reason_Update(PortalConnect, obj.Reason_ID, obj.Reason_Code, obj.Reason_Name, obj.Reason_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_Reason_Delete(PortalConnect As String, reason_ID As Integer)
        DataProvider.Instance().CMS_Reason_Delete(PortalConnect, reason_ID)
    End Sub
    Public Sub CMS_Reason_Update_Quick(PortalConnect As String, reason_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Reason_Update_Quick(PortalConnect, reason_ID, isActive, isOrder)
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
#Region "CMS_Education"
    Public Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As CMS_EducationInfo
        Return CBO.FillObject(Of CMS_EducationInfo)(DataProvider.Instance().CMS_Education_Get(PortalConnect, Education_ID))
    End Function
    Public Function CMS_Education_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Education_List(PortalConnect), GetType(CMS_EducationInfo))
    End Function
    Public Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Education_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_EducationInfo))
    End Function

    Public Function CMS_Education_Add(PortalConnect As String, obj As CMS_EducationInfo) As Integer
        Return DataProvider.Instance().CMS_Education_Add(PortalConnect, obj.Education_Code, obj.Education_Name, obj.Education_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_Education_Update(PortalConnect As String, obj As CMS_EducationInfo)
        DataProvider.Instance().CMS_Education_Update(PortalConnect, obj.Education_ID, obj.Education_Code, obj.Education_Name, obj.Education_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
        DataProvider.Instance().CMS_Education_Delete(PortalConnect, Education_ID)
    End Sub
    Public Sub CMS_Education_Update_Quick(PortalConnect As String, Education_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_Education_Update_Quick(PortalConnect, Education_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_LoaiSo"
    Public Function CMS_LoaiSo_Get(PortalConnect As String, LoaiSo_ID As Integer) As CMS_LoaiSoInfo
        Return CBO.FillObject(Of CMS_LoaiSoInfo)(DataProvider.Instance().CMS_LoaiSo_Get(PortalConnect, LoaiSo_ID))
    End Function
    Public Function CMS_LoaiSo_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LoaiSo_List(PortalConnect), GetType(CMS_LoaiSoInfo))
    End Function
    Public Function CMS_LoaiSo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_LoaiSo_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_LoaiSoInfo))
    End Function

    Public Function CMS_LoaiSo_Add(PortalConnect As String, obj As CMS_LoaiSoInfo) As Integer
        Return DataProvider.Instance().CMS_LoaiSo_Add(PortalConnect, obj.Code, obj.Name, obj.IsActive, obj.IsOrder, obj.IsDeleted)
    End Function
    Public Sub CMS_LoaiSo_Update(PortalConnect As String, obj As CMS_LoaiSoInfo)
        DataProvider.Instance().CMS_LoaiSo_Update(PortalConnect, obj.ID, obj.Code, obj.Name, obj.IsActive, obj.IsOrder, obj.IsDeleted)
    End Sub
    Public Sub CMS_LoaiSo_Delete(PortalConnect As String, LoaiSo_ID As Integer)
        DataProvider.Instance().CMS_LoaiSo_Delete(PortalConnect, LoaiSo_ID)
    End Sub
    Public Sub CMS_LoaiSo_Update_Quick(PortalConnect As String, LoaiSo_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_LoaiSo_Update_Quick(PortalConnect, LoaiSo_ID, isActive, isOrder)
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
#Region "CMS_TypeUnemploy"
    Public Function CMS_TypeUnemploy_Get(PortalConnect As String, TypeUnemploy_ID As Integer) As CMS_TypeUnemployInfo
        Return CBO.FillObject(Of CMS_TypeUnemployInfo)(DataProvider.Instance().CMS_TypeUnemploy_Get(PortalConnect, TypeUnemploy_ID))
    End Function
    Public Function CMS_TypeUnemploy_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeUnemploy_List(PortalConnect), GetType(CMS_TypeUnemployInfo))
    End Function
    Public Function CMS_TypeUnemploy_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_TypeUnemploy_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_TypeUnemployInfo))
    End Function

    Public Function CMS_TypeUnemploy_Add(PortalConnect As String, obj As CMS_TypeUnemployInfo) As Integer
        Return DataProvider.Instance().CMS_TypeUnemploy_Add(PortalConnect, obj.TypeUnemploy_Code, obj.TypeUnemploy_Name, obj.TypeUnemploy_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Function
    Public Sub CMS_TypeUnemploy_Update(PortalConnect As String, obj As CMS_TypeUnemployInfo)
        DataProvider.Instance().CMS_TypeUnemploy_Update(PortalConnect, obj.TypeUnemploy_ID, obj.TypeUnemploy_Code, obj.TypeUnemploy_Name, obj.TypeUnemploy_Des, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.IsActive, obj.IsOrder)
    End Sub
    Public Sub CMS_TypeUnemploy_Delete(PortalConnect As String, TypeUnemploy_ID As Integer)
        DataProvider.Instance().CMS_TypeUnemploy_Delete(PortalConnect, TypeUnemploy_ID)
    End Sub
    Public Sub CMS_TypeUnemploy_Update_Quick(PortalConnect As String, TypeUnemploy_ID As Integer, isActive As Boolean, isOrder As Integer)
        DataProvider.Instance().CMS_TypeUnemploy_Update_Quick(PortalConnect, TypeUnemploy_ID, isActive, isOrder)
    End Sub
#End Region
#Region "CMS_Provide_BienDongKhau"
    Public Function CMS_Provide_BienDongKhau_Get(tpConnect As String, bienDong_ID As String) As CMS_Provide_BienDongKhauInfo
        Return CBO.FillObject(Of CMS_Provide_BienDongKhauInfo)(DataProvider.Instance().CMS_Provide_BienDongKhau_Get(tpConnect, bienDong_ID))
    End Function
    Public Function CMS_Provide_BienDongKhau_List(tpConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_BienDongKhau_List(tpConnect), GetType(CMS_Provide_BienDongKhauInfo))
    End Function

    Public Sub CMS_Provide_BienDongKhau_Add(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
        DataProvider.Instance().CMS_Provide_BienDongKhau_Add(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_BienDongKhau_Update(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
        DataProvider.Instance().CMS_Provide_BienDongKhau_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_BienDongKhau_Delete(tpConnect As String, bienDong_ID As String)
        DataProvider.Instance().CMS_Provide_BienDongKhau_Delete(tpConnect, bienDong_ID)
    End Sub
#End Region
#Region "CMS_Provide_BienDongHo"
    Public Function CMS_Provide_BienDongHo_Get(tpConnect As String, bienDong_ID As String) As CMS_Provide_BienDongHoInfo
        Return CBO.FillObject(Of CMS_Provide_BienDongHoInfo)(DataProvider.Instance().CMS_Provide_BienDongHo_Get(tpConnect, bienDong_ID))
    End Function
    Public Function CMS_Provide_BienDongHo_List(tpConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_BienDongHo_List(tpConnect), GetType(CMS_Provide_BienDongHoInfo))
    End Function

    Public Sub CMS_Provide_BienDongHo_Add(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
        DataProvider.Instance().CMS_Provide_BienDongHo_Add(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_BienDongHo_Update(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
        DataProvider.Instance().CMS_Provide_BienDongHo_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_BienDongHo_Delete(tpConnect As String, bienDong_ID As String)
        DataProvider.Instance().CMS_Provide_BienDongHo_Delete(tpConnect, bienDong_ID)
    End Sub
#End Region
#Region "CMS_HoGD"
    Public Function CMS_HoGD_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As CMS_HoGD_BackupInfo
        Return CBO.FillObject(Of CMS_HoGD_BackupInfo)(DataProvider.Instance().CMS_HoGD_Backup_Get_By_YearID(tpConnect, id, yearID))
    End Function
    Public Function CMS_HoGD_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_List_Menu(tpConnect, id, key, matinh, mahuyen, maxa, mathon), GetType(CMS_HoGDInfo))
    End Function
    Public Function CMS_HoGD_Backup_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Backup_List_Menu(tpConnect, id, key, matinh, mahuyen, maxa, mathon, yearID), GetType(CMS_HoGD_BackupInfo))
    End Function
    Public Function CMS_HoGD_GenMaHo(tpConnect As String, matinh As String, mahuyen As String, maxa As String, mathon As String) As Integer
        Return DataProvider.Instance().CMS_HoGD_GenMaHo(tpConnect, matinh, mahuyen, maxa, mathon)
    End Function
    Public Function CMS_HoGD_Get(tpConnect As String, id As String) As CMS_HoGDInfo
        Return CBO.FillObject(Of CMS_HoGDInfo)(DataProvider.Instance().CMS_HoGD_Get(tpConnect, id))
    End Function
    Public Function CMS_HoGD_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_List(tpConnect, portalId), GetType(CMS_HoGDInfo))
    End Function
    Public Function CMS_HoGD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, Optional ByVal IsDuplicate As Boolean = False) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_List_Search(tpConnect, search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, loaiHo, currPage, recodperpage, IsNow, IsDuplicate), GetType(CMS_HoGDInfo))
    End Function
    Public Function CMS_HoGD_List_Search_Deleted(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_List_Search_Deleted(tpConnect, search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, loaiHo, currPage, recodperpage, IsNow), GetType(CMS_HoGDInfo))
    End Function
    Public Function CMS_HoGD_List_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_List_Backup(tpConnect, matinh, mahuyen, maxa, mathon, currPage, recodperpage), GetType(CMS_HoGDInfo))
    End Function
    Public Function CMS_HoGD_Add(tpConnect As String, obj As CMS_HoGDInfo) As Integer
        Return DataProvider.Instance().CMS_HoGD_Add(tpConnect, obj)
    End Function
    Public Sub CMS_HoGD_Update(tpConnect As String, obj As CMS_HoGDInfo)
        DataProvider.Instance().CMS_HoGD_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_HoGD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        DataProvider.Instance().CMS_HoGD_Update_Delete(tpConnect, id, isDelete, deleteDate, deleteUser)
    End Sub
    Public Sub CMS_HoGD_Update_BienDong(tpConnect As String, ID As String, loaiBienDong As Integer)
        DataProvider.Instance().CMS_HoGD_Update_BienDong(tpConnect, ID, loaiBienDong)
    End Sub
    Public Sub CMS_HoGD_Backup_Update_BienDong(tpConnect As String, ID As String, loaiBienDong As Integer, yearID As Integer)
        DataProvider.Instance().CMS_HoGD_Backup_Update_BienDong(tpConnect, ID, loaiBienDong, yearID)
    End Sub
    Public Sub CMS_HoGD_Update_SoNhanKhau(tpConnect As String, ID As String, soNhanKhau As Integer)
        DataProvider.Instance().CMS_HoGD_Update_SoNhanKhau(tpConnect, ID, soNhanKhau)
    End Sub
    Public Sub CMS_HoGD_Update_SoSo(tpConnect As String, ID As String, IdSo As Integer)
        DataProvider.Instance().CMS_HoGD_Update_SoSo(tpConnect, ID, IdSo)
    End Sub
    Public Sub CMS_HoGD_Update_Name(tpConnect As String, ID As String, Ten As String, type As Integer)
        DataProvider.Instance().CMS_HoGD_Update_Name(tpConnect, ID, Ten, type)
    End Sub
    Public Function CMS_HoGD_Update_MaHo(tpConnect As String, index As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, IdHo As String) As String
        Return DataProvider.Instance().CMS_HoGD_Update_MaHo(tpConnect, index, matinh, mahuyen, maxa, mathon, IdHo)
    End Function
    Public Sub CMS_HoGD_Update_Move(tpConnect As String, ID As String, chuyen As Integer)
        DataProvider.Instance().CMS_HoGD_Update_Move(tpConnect, ID, chuyen)
    End Sub
    Public Sub CMS_HoGD_Update_Merger(tpConnect As String, ID As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, diachi As String, idSo As String)
        DataProvider.Instance().CMS_HoGD_Update_Merger(tpConnect, ID, matinh, mahuyen, maxa, mathon, diachi, idSo)
    End Sub

    Public Sub CMS_HoGD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        DataProvider.Instance().CMS_HoGD_Backup(tpConnect, matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Function CMS_HoGD_RecoveryData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer) As Integer
        Return DataProvider.Instance().CMS_HoGD_RecoveryData(tpConnect, matinh, mahuyen, maxa, mathon, yearid)
    End Function
#End Region
#Region "CMS_HoGD_Khau"
    Public Function CMS_HoGD_Khau_List_Fix(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, errType As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_List_Fix(tpConnect, matinh, mahuyen, maxa, mathon, errType, currPage, recodperpage), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Sub CMS_HoGD_Khau_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
        DataProvider.Instance().CMS_HoGD_Khau_Backup(tpConnect, matinh, mahuyen, maxa, mathon, yearid, username)
    End Sub
    Public Function CMS_HoGD_Khau_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As CMS_HoGD_Khau_BackupInfo
        Return CBO.FillObject(Of CMS_HoGD_Khau_BackupInfo)(DataProvider.Instance().CMS_HoGD_Khau_Backup_Get_By_YearID(tpConnect, id, yearID))
    End Function
    Public Function CMS_HoGD_Khau_Get(tpConnect As String, id As String) As CMS_HoGD_KhauInfo
        Return CBO.FillObject(Of CMS_HoGD_KhauInfo)(DataProvider.Instance().CMS_HoGD_Khau_Get(tpConnect, id))
    End Function
    Public Function CMS_HoGD_Khau_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_List_ByIDHo(tpConnect, matinh, mahuyen, maxa, mathon, idHo), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Function CMS_HoGD_Khau_Backup_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String, yearID As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_Backup_List_ByIDHo(tpConnect, matinh, mahuyen, maxa, mathon, idHo, yearID), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Function CMS_HoGD_Khau_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_List(tpConnect, portalId), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Function CMS_HoGD_Khau_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, Optional ByVal yearCreated As Integer = 0) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_List_Search(tpConnect, search, matinh, mahuyen, maxa, mathon, isOrder, year, idSo, currPage, recodperpage, IsNow, yearCreated), GetType(CMS_HoGD_KhauInfo))
    End Function

    Public Sub CMS_HoGD_Khau_Add(tpConnect As String, obj As CMS_HoGD_KhauInfo)
        DataProvider.Instance().CMS_HoGD_Khau_Add(tpConnect, obj)
    End Sub
    Public Sub CMS_HoGD_Khau_Update(tpConnect As String, obj As CMS_HoGD_KhauInfo)
        DataProvider.Instance().CMS_HoGD_Khau_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_HoGD_Khau_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Update_Delete(tpConnect, id, isDelete, deleteDate, deleteUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer)
        DataProvider.Instance().CMS_HoGD_Khau_Update_BienDong(tpConnect, idHo, idTv, loaiBienDong)
    End Sub
    Public Sub CMS_HoGD_Khau_Backup_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer, yearID As Integer)
        DataProvider.Instance().CMS_HoGD_Khau_Backup_Update_BienDong(tpConnect, idHo, idTv, loaiBienDong, yearID)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_TDHV(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_TDHV(tpConnect, id, valKey, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_NganhNghe(tpConnect As String, id As String, valKey As String, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_NganhNghe(tpConnect, id, valKey, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_CMKT(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_CMKT(tpConnect, id, valKey, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_CVLTN(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_CVLTN(tpConnect, id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_CVLKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_CVLKHDKT(tpConnect, id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_TNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_TNKHDKT(tpConnect, id, valKey, valKey2, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_KVLKTNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, valKey3 As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_KVLKTNKHDKT(tpConnect, id, valKey, valKey2, valKey3, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Fix_TDGD(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
        DataProvider.Instance().CMS_HoGD_Khau_Fix_TDGD(tpConnect, id, valKey, updatedDate, updatedUser)
    End Sub
    Public Sub CMS_HoGD_Khau_Delete(tpConnect As String, id As String)
        DataProvider.Instance().CMS_HoGD_Khau_Delete(tpConnect, id)
    End Sub
    Public Function CMS_HoGD_GenMaThanhVien(tpConnect As String, idHo As String) As Integer
        Return DataProvider.Instance().CMS_HoGD_GenMaThanhVien(tpConnect, idHo)
    End Function
    Public Function CMS_HoGD_Khau_CheckCCCD(tpConnect As String, cmnd As String, Id As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_CheckCCCD(tpConnect, cmnd, Id), GetType(CMS_HoGD_KhauInfo))
    End Function
#End Region
#Region "CMS_Provide_History"
    Public Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As CMS_Provide_HistoryInfo
        Return CBO.FillObject(Of CMS_Provide_HistoryInfo)(DataProvider.Instance().CMS_Provide_History_Get(tpConnect, history_ID))
    End Function
    Public Function CMS_Provide_History_List(tpConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_History_List(tpConnect), GetType(CMS_Provide_HistoryInfo))
    End Function

    Public Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        DataProvider.Instance().CMS_Provide_History_Add(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
        DataProvider.Instance().CMS_Provide_History_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)
        DataProvider.Instance().CMS_Provide_History_Delete(tpConnect, history_ID)
    End Sub
    Public Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, quanHuyen As Integer, maXa As Integer, maDvi As Integer) As CMS_Provide_HistoryInfo
        Return CBO.FillObject(Of CMS_Provide_HistoryInfo)(DataProvider.Instance().CMS_Provide_History_Get_Send(tpConnect, tinhTP, quanHuyen, maXa, maDvi))
    End Function
#End Region
#Region "CMS_HoGD_Backup"
    Public Function CMS_HoGD_Backup_Get(tpConnect As String, idBackup As Integer) As CMS_HoGD_BackupInfo
        Return CBO.FillObject(Of CMS_HoGD_BackupInfo)(DataProvider.Instance().CMS_HoGD_Backup_Get(tpConnect, idBackup))
    End Function
    Public Function CMS_HoGD_Backup_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Backup_List(tpConnect, portalId), GetType(CMS_HoGD_BackupInfo))
    End Function

    Public Function CMS_HoGD_Backup_Add(tpConnect As String, obj As CMS_HoGD_BackupInfo) As Integer
        Return DataProvider.Instance().CMS_HoGD_Backup_Add(tpConnect, obj)
    End Function
    Public Sub CMS_HoGD_Backup_Update(tpConnect As String, obj As CMS_HoGD_BackupInfo)
        DataProvider.Instance().CMS_HoGD_Backup_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_HoGD_Backup_Delete(tpConnect As String, idBackup As Integer)
        DataProvider.Instance().CMS_HoGD_Backup_Delete(tpConnect, idBackup)
    End Sub
#End Region
#Region "CMS_HoGD_Khau_Backup"
    Public Function CMS_HoGD_Khau_Backup_Get(tpConnect As String, idBackup As Integer) As CMS_HoGD_Khau_BackupInfo
        Return CBO.FillObject(Of CMS_HoGD_Khau_BackupInfo)(DataProvider.Instance().CMS_HoGD_Khau_Backup_Get(tpConnect, idBackup))
    End Function
    Public Function CMS_HoGD_Khau_Backup_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_HoGD_Khau_Backup_List(tpConnect, portalId), GetType(CMS_HoGD_Khau_BackupInfo))
    End Function

    Public Function CMS_HoGD_Khau_Backup_Add(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo) As Integer
        Return DataProvider.Instance().CMS_HoGD_Khau_Backup_Add(tpConnect, obj)
    End Function
    Public Sub CMS_HoGD_Khau_Backup_Update(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo)
        DataProvider.Instance().CMS_HoGD_Khau_Backup_Update(tpConnect, obj)
    End Sub
    Public Sub CMS_HoGD_Khau_Backup_Delete(tpConnect As String, idBackup As Integer)
        DataProvider.Instance().CMS_HoGD_Khau_Backup_Delete(tpConnect, idBackup)
    End Sub
#End Region
#Region "CMS_Provide_Config"

    Public Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List_Search(tpConnect, tinhTP, isActive, currPage, recodperpage, UserName), GetType(CMS_Provide_ConfigInfo))
    End Function
    Public Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, isActive As Boolean) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get_Active(tpConnect, TinhTP, isActive))
    End Function
    Public Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get(tpConnect, proConfig_ID))
    End Function
    Public Function CMS_Provide_Config_Get_Value(tpConnect As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As CMS_Provide_ConfigInfo
        Return CBO.FillObject(Of CMS_Provide_ConfigInfo)(DataProvider.Instance().CMS_Provide_Config_Get_Value(tpConnect, tinhTP, QuanHuyen, PhuongXa, ThonTo, proconfig_value))
    End Function
    Public Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
        DataProvider.Instance().CMS_Provide_Config_Update_Active(tpConnect, proConfig_ID, active)
    End Sub
    Public Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List(tpConnect, portalId), GetType(CMS_Provide_ConfigInfo))
    End Function
    Public Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinhTP As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Provide_Config_List_ByTinh(tpConnect, tinhTP), GetType(CMS_Provide_ConfigInfo))
    End Function

    Public Sub CMS_Provide_Config_Add(tpConnect As String, obj As CMS_Provide_ConfigInfo)
        DataProvider.Instance().CMS_Provide_Config_Add(tpConnect, obj.ProConfig_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ThonTo, obj.ProConfig_Name, obj.ProConfig_Value, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.isOrder)
    End Sub
    Public Sub CMS_Provide_Config_Update(tpConnect As String, obj As CMS_Provide_ConfigInfo)
        DataProvider.Instance().CMS_Provide_Config_Update(tpConnect, obj.ProConfig_ID, obj.TinhTP, obj.QuanHuyen, obj.PhuongXa, obj.ThonTo, obj.ProConfig_Name, obj.ProConfig_Value, obj.IsActive, obj.IsLock, obj.IsFlag, obj.CreatedDate, obj.CreatedUser, obj.UpdatedDate, obj.UpdatedUser, obj.PortalId, obj.isOrder)
    End Sub
    Public Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
        DataProvider.Instance().CMS_Provide_Config_Delete(tpConnect, proConfig_ID)
    End Sub
#End Region
#Region "Report-CungLD"
    Public Sub CMS_BCTH_ClearData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer)
        DataProvider.Instance().CMS_BCTH_ClearData(tpConnect, matinh, mahuyen, maxa, mathon, year, typeData)
    End Sub

    Public Function CMS_CungLD_Report0(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report0(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(BC_DSInfo))
    End Function
    Public Sub CMS_CungLD_Report0_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report0_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Function CMS_CungLD_Report1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report1(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(BC_DSInfo))
    End Function
    Public Sub CMS_CungLD_Report1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report1_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Function CMS_CungLD_Report2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report2(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(BC_DSInfo))
    End Function
    Public Sub CMS_CungLD_Report2_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report2_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Function CMS_CungLD_Report3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report3(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(BC_DSInfo))
    End Function
    Public Sub CMS_CungLD_Report3_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report3_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Sub CMS_CungLD_Report4_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report4_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Function CMS_CungLD_Report4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report4(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(BC_DSInfo))
    End Function
    Public Function CMS_CungLD_Report5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As CMS_CungLDReportInfo
        Return CBO.FillObject(Of CMS_CungLDReportInfo)(DataProvider.Instance().CMS_CungLD_Report5(tpConnect, matinh, mahuyen, maxa, mathon, year))
    End Function
    Public Function CMS_CungLD_Report5_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As RPT_05_1Info
        Return CBO.FillObject(Of RPT_05_1Info)(DataProvider.Instance().CMS_CungLD_Report5_1(tpConnect, matinh, mahuyen, maxa, mathon, year))
    End Function
    Public Sub CMS_CungLD_Report5_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report5_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Sub CMS_CungLD_Report5_1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, dotuoiTu As Integer, doTuoiDen As Integer)
        DataProvider.Instance().CMS_CungLD_Report5_1_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow, dotuoiTu, doTuoiDen)
    End Sub
    Public Function CMS_CungLD_Report6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As ReportInfo
        Return CBO.FillObject(Of ReportInfo)(DataProvider.Instance().CMS_CungLD_Report6(tpConnect, matinh, mahuyen, maxa, mathon, year))
    End Function
    Public Sub CMS_CungLD_Report6_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report6_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Sub CMS_CungLD_Report7_TH(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, maThon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report7_TH(tpConnect, phanloai, matinh, mahuyen, maxa, maThon, year, isNow)
    End Sub
    Public Function CMS_CungLD_Report7(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, madonvi As Integer, year As Integer) As ReportInfo
        Return CBO.FillObject(Of ReportInfo)(DataProvider.Instance().CMS_CungLD_Report7(tpConnect, phanloai, matinh, mahuyen, maxa, madonvi, year))
    End Function
    Public Function CMS_CungLD_Report8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report8(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize, isNow), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Function CMS_CungLD_Report9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_Report9(tpConnect, matinh, mahuyen, maxa, mathon, year, dotuoiTu, doTuoiDen, curPage, pageSize), GetType(CMS_HoGD_KhauInfo))
    End Function
    Public Sub CMS_CungLD_Report9_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
        DataProvider.Instance().CMS_CungLD_Report9_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow)
    End Sub
    Public Sub CMS_CungLD_Report10_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, typeData As Integer)
        DataProvider.Instance().CMS_CungLD_Report10_TH(tpConnect, matinh, mahuyen, maxa, mathon, year, isNow, typeData)
    End Sub
    Public Function CMS_CungLD_Report10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer) As ReportInfo
        Return CBO.FillObject(Of ReportInfo)(DataProvider.Instance().CMS_CungLD_Report10(tpConnect, matinh, mahuyen, maxa, mathon, year, typeData))
    End Function
    Public Function CMS_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_1(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16)
        DataProvider.Instance().RUN_Report_BCTH1_1(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag)
    End Sub
    Public Function CMS_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_2(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH1_2(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub
    Public Function CMS_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_3(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH1_3(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_4(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH1_4(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_5(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH1_5(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_6(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH1_6(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_7(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH1_7(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_8(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH1_8(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_9(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH1_9(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH1_10(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH1_10(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH11a(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH11a(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH12a(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH12a(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH13a(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH13a(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH11a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH11a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH12a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH12a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH13a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH13a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH14a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH14a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH15a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH15a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH16a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH16a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH17a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH17a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH18a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH18a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH19a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH19a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH20a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH20a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub

    Public Function CMS_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH21a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH21a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH22a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH22a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH23a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH23a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH24a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH24a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH25a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH25a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH26a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH26a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH27a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Int16)
        DataProvider.Instance().RUN_Report_BCTH27a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Int16) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH28a_CVL(tpConnect, matinh, mahuyen, maxa, year, sqlTb, isFlag, level), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)
        DataProvider.Instance().RUN_Report_BCTH28a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, sqlTb, isFlag, level)
    End Sub
    Public Function CMS_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isFlag As Int16, level As Int16, parentID As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report_BCTH29a_CVL(tpConnect, matinh, mahuyen, maxa, year, isFlag, level, parentID), GetType(ReportInfo))
    End Function
    Public Sub RUN_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, isFlag As Int16, strRow As String, level As Int16, parentID As String)
        DataProvider.Instance().RUN_Report_BCTH29a_CVL(tpConnect, matinh, mahuyen, maxa, year, isNow, isFlag, strRow, level, parentID)
    End Sub

    Public Function CMS_CungLD_CustomReport(tpConnect As String, matinh As Int16, maHuyen As Integer, maXa As Integer, levelHC As Integer, rowID As Integer, colID As String, isNow As Boolean, years As Integer, typeRow As Int16, typeCol As Int16, option1 As String, option2 As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_CustomReport(tpConnect, matinh, maHuyen, maXa, levelHC, rowID, colID, isNow, years, typeRow, typeCol, option1, option2), GetType(CustomRptValue))
    End Function

#End Region
#Region "CMS_CungLD"
    Public Function CMS_CungLD_Get(PortalConnect As String, iD As Integer) As CMS_CungLDInfo
        Return CBO.FillObject(Of CMS_CungLDInfo)(DataProvider.Instance().CMS_CungLD_Get(PortalConnect, iD))
    End Function
    Public Function CMS_CungLD_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_List(PortalConnect), GetType(CMS_CungLDInfo))
    End Function
    Public Function CMS_CungLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_CungLD_List_Search(PortalConnect, search, isOrder, currPage, recodperpage, UserName), GetType(CMS_CungLDInfo))
    End Function
    Public Function CMS_CungLD_Add(PortalConnect As String, obj As CMS_CungLDInfo) As Integer
        Return DataProvider.Instance().CMS_CungLD_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_CungLD_Update(PortalConnect As String, obj As CMS_CungLDInfo)
        DataProvider.Instance().CMS_CungLD_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_CungLD_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().CMS_CungLD_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "CMS_Age"
    Public Function CMS_Age_Get(PortalConnect As String, age_ID As Integer) As CMS_AgeInfo
        Return CBO.FillObject(Of CMS_AgeInfo)(DataProvider.Instance().CMS_Age_Get(PortalConnect, age_ID))
    End Function
    Public Function CMS_Age_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Age_List(PortalConnect), GetType(CMS_AgeInfo))
    End Function

    Public Function CMS_Age_Add(PortalConnect As String, obj As CMS_AgeInfo) As Integer
        Return DataProvider.Instance().CMS_Age_Add(PortalConnect, obj)
    End Function
    Public Sub CMS_Age_Update(PortalConnect As String, obj As CMS_AgeInfo)
        DataProvider.Instance().CMS_Age_Update(PortalConnect, obj)
    End Sub
    Public Sub CMS_Age_Delete(PortalConnect As String, age_ID As Integer)
        DataProvider.Instance().CMS_Age_Delete(PortalConnect, age_ID)
    End Sub
#End Region
#Region "TH27_M01"
    Public Function TH27_M01_Get(PortalConnect As String, iD As Integer) As TH27_M01Info
        Return CBO.FillObject(Of TH27_M01Info)(DataProvider.Instance().TH27_M01_Get(PortalConnect, iD))
    End Function
    Public Function TH27_M01_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M01_List(PortalConnect), GetType(TH27_M01Info))
    End Function
    Public Function TH27_M01_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M01_List_Search(PortalConnect, tinhTP, quanHuyen, xaPhuong, years, currPage, recodperpage), GetType(TH27_M01Info))
    End Function
    Public Function TH27_M01_Add(PortalConnect As String, obj As TH27_M01Info) As Integer
        Return DataProvider.Instance().TH27_M01_Add(PortalConnect, obj)
    End Function
    Public Sub TH27_M01_Update(PortalConnect As String, obj As TH27_M01Info)
        DataProvider.Instance().TH27_M01_Update(PortalConnect, obj)
    End Sub
    Public Sub TH27_M01_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M01_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M01_A"
    Public Sub RPT_TH27_M01_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer)
        DataProvider.Instance().RPT_TH27_M01_A_RUN(PortalConnect, m01ID, years, tinhTP, quanHuyen, xaPhuong)
    End Sub
    Public Function TH27_M01_A_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M01_A_Get_By_TH27_M01(PortalConnect, iD), GetType(TH27_M01_AInfo))
    End Function
    Public Sub TH27_M01_A_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M01_A_Delete_By_TH27_M01(PortalConnect, iD)
    End Sub

#End Region
#Region "TH27_M01_B"
    Public Sub RPT_TH27_M01_B_RUN(PortalConnect As String, m01ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, maThon As Integer, tenThon As String, years As Integer)
        DataProvider.Instance().RPT_TH27_M01_B_RUN(PortalConnect, m01ID, sTT, tinhTP, quanHuyen, xaPhuong, maThon, tenThon, years)
    End Sub
    Public Function TH27_M01_B_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M01_B_Get_By_TH27_M01(PortalConnect, iD), GetType(TH27_M01_BInfo))
    End Function
    Public Sub TH27_M01_B_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M01_B_Delete_By_TH27_M01(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M02"
    Public Function TH27_M02_Get(PortalConnect As String, iD As Integer) As TH27_M02Info
        Return CBO.FillObject(Of TH27_M02Info)(DataProvider.Instance().TH27_M02_Get(PortalConnect, iD))
    End Function
    Public Function TH27_M02_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_List(PortalConnect), GetType(TH27_M02Info))
    End Function
    Public Function TH27_M02_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_List_Search(PortalConnect, tinhTP, quanHuyen, years, currPage, recodperpage), GetType(TH27_M02Info))
    End Function
    Public Function TH27_M02_Add(PortalConnect As String, obj As TH27_M02Info) As Integer
        Return DataProvider.Instance().TH27_M02_Add(PortalConnect, obj)
    End Function
    Public Sub TH27_M02_Update(PortalConnect As String, obj As TH27_M02Info)
        DataProvider.Instance().TH27_M02_Update(PortalConnect, obj)
    End Sub
    Public Sub TH27_M02_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M02_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M02_A"
    Public Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
        DataProvider.Instance().RPT_TH27_M02_A_RUN(PortalConnect, m01ID, years, tinhTP, quanHuyen)
    End Sub
    Public Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_A_Get_By_TH27_M02(PortalConnect, iD), GetType(TH27_M02_AInfo))
    End Function
    Public Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M02_A_Delete_By_TH27_M02(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M02_B"
    Public Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
        DataProvider.Instance().RPT_TH27_M02_B_RUN(PortalConnect, m02ID, sTT, tinhTP, quanHuyen, xaPhuong, tenXaPhuong, years)
    End Sub
    Public Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M02_B_Get_By_TH27_M02(PortalConnect, iD), GetType(TH27_M02_BInfo))
    End Function
    Public Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M02_B_Delete_By_TH27_M02(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M03"
    Public Function TH27_M03_Get(PortalConnect As String, iD As Integer) As TH27_M03Info
        Return CBO.FillObject(Of TH27_M03Info)(DataProvider.Instance().TH27_M03_Get(PortalConnect, iD))
    End Function
    Public Function TH27_M03_List(PortalConnect As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_List(PortalConnect), GetType(TH27_M03Info))
    End Function
    Public Function TH27_M03_List_Search(PortalConnect As String, tinhTP As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_List_Search(PortalConnect, tinhTP, years, currPage, recodperpage), GetType(TH27_M03Info))
    End Function
    Public Function TH27_M03_Add(PortalConnect As String, obj As TH27_M03Info) As Integer
        Return DataProvider.Instance().TH27_M03_Add(PortalConnect, obj)
    End Function
    Public Sub TH27_M03_Update(PortalConnect As String, obj As TH27_M03Info)
        DataProvider.Instance().TH27_M03_Update(PortalConnect, obj)
    End Sub
    Public Sub TH27_M03_Delete(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M03_Delete(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M03_A"
    Public Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer)
        DataProvider.Instance().RPT_TH27_M03_A_RUN(PortalConnect, m01ID, years, tinhTP)
    End Sub
    Public Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_A_Get_By_TH27_M03(PortalConnect, iD), GetType(TH27_M03_AInfo))
    End Function
    Public Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M03_A_Delete_By_TH27_M03(PortalConnect, iD)
    End Sub
#End Region
#Region "TH27_M03_B"
    Public Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
        DataProvider.Instance().RPT_TH27_M03_B_RUN(PortalConnect, m02ID, sTT, tinhTP, quanHuyen, tenQuanHuyen, years)
    End Sub
    Public Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().TH27_M03_B_Get_By_TH27_M03(PortalConnect, iD), GetType(TH27_M03_BInfo))
    End Function
    Public Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
        DataProvider.Instance().TH27_M03_B_Delete_By_TH27_M03(PortalConnect, iD)
    End Sub
#End Region
#Region "API"
    Public Function API_CungLD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, tto As Integer, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_CungLD_01(PortalConnect, tp, qh, xp, tto, year, isNow), GetType(apiHoGDInfo))
    End Function
    Public Function API_CungLD_02(PortalConnect As String, tp As Integer, maHo As String, loaiHo As Integer, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_CungLD_02(PortalConnect, tp, maHo, loaiHo, year, isNow), GetType(apiHoGDInfo))
    End Function
    Public Function API_CungLD_03(PortalConnect As String, tp As Integer, gt As Integer, cmkt As Integer, tdgd As Integer, tinhtrang As Integer, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().API_CungLD_03(PortalConnect, tp, gt, cmkt, tdgd, tinhtrang, year, isNow), GetType(apiHoGD_KhauInfo))
    End Function
#End Region
#Region "REPORT CHART"

    Public Function CMS_Report13(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report13(tpConnect, tp, qh, xp, year, isNow), GetType(ChartInfo))
    End Function
    Public Function CMS_Report13_1(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Report13_1(tpConnect, tp, qh, xp, year, isNow), GetType(ChartInfo))
    End Function
    Public Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As ChartInfo
        Return CBO.FillObject(Of ChartInfo)(DataProvider.Instance().CMS_Chart_Data(tpConnect, tp, qh, xp, year, isNow, maBC))
    End Function
    Public Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As ArrayList
        Return CBO.FillCollection(DataProvider.Instance().CMS_Chart_DataHC(tpConnect, tp, qh, ids, year, isNow, maBC), GetType(ChartInfo))
    End Function
#End Region
End Class
