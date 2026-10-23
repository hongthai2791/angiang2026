Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.CUNG", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region
#Region "CMS_CareerCLD"
    Public MustOverride Function CMS_CareerCLD_Get(PortalConnect As String, CareerCLD_ID As Integer) As IDataReader
    Public MustOverride Function CMS_CareerCLD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CareerCLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_CareerCLD_Add(PortalConnect As String, obj As CMS_CareerCLDInfo) As Integer
    Public MustOverride Sub CMS_CareerCLD_Update(PortalConnect As String, obj As CMS_CareerCLDInfo)
    Public MustOverride Sub CMS_CareerCLD_Delete(PortalConnect As String, CareerCLD_ID As Integer)
#End Region
#Region "CMS_Provide_Book"
    Public MustOverride Function CMS_Provide_Book_Get(PortalConnect As String, book_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_Book_List(PortalConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Sub CMS_Provide_Book_Add(PortalConnect As String, obj As CMS_Provide_BookInfo)
    Public MustOverride Sub CMS_Provide_Book_Update(PortalConnect As String, obj As CMS_Provide_BookInfo)
    Public MustOverride Sub CMS_Provide_Book_Delete(PortalConnect As String, book_ID As String)
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
#Region "CMS_Reason"
    Public MustOverride Function CMS_Reason_Get(PortalConnect As String, reason_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Reason_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Reason_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Reason_Add(PortalConnect As String, reason_Code As String, reason_Name As String, reason_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Reason_Update(PortalConnect As String, reason_ID As Integer, reason_Code As String, reason_Name As String, reason_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Reason_Delete(PortalConnect As String, reason_ID As Integer)
    Public MustOverride Sub CMS_Reason_Update_Quick(PortalConnect As String, reason_ID As Integer, isActive As Boolean, isOrder As Integer)
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
#Region "CMS_Education"
    Public MustOverride Function CMS_Education_Get(PortalConnect As String, Education_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Education_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Education_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_Education_Add(PortalConnect As String, Education_Code As String, Education_Name As String, Education_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_Education_Update(PortalConnect As String, Education_ID As Integer, Education_Code As String, Education_Name As String, Education_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_Education_Delete(PortalConnect As String, Education_ID As Integer)
    Public MustOverride Sub CMS_Education_Update_Quick(PortalConnect As String, Education_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_LoaiSo"
    Public MustOverride Function CMS_LoaiSo_Get(PortalConnect As String, LoaiSo_ID As Integer) As IDataReader
    Public MustOverride Function CMS_LoaiSo_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_LoaiSo_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_LoaiSo_Add(PortalConnect As String, LoaiSo_Code As String, LoaiSo_Name As String, isActive As Boolean, isOrder As Integer, isDeleted As Boolean) As Integer
    Public MustOverride Sub CMS_LoaiSo_Update(PortalConnect As String, LoaiSo_ID As Integer, LoaiSo_Code As String, LoaiSo_Name As String, isActive As Boolean, isOrder As Integer, isDeleted As Boolean)
    Public MustOverride Sub CMS_LoaiSo_Delete(PortalConnect As String, LoaiSo_ID As Integer)
    Public MustOverride Sub CMS_LoaiSo_Update_Quick(PortalConnect As String, LoaiSo_ID As Integer, isActive As Boolean, isOrder As Integer)
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
#Region "CMS_TypeUnemploy"
    Public MustOverride Function CMS_TypeUnemploy_Get(PortalConnect As String, TypeUnemploy_ID As Integer) As IDataReader
    Public MustOverride Function CMS_TypeUnemploy_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_TypeUnemploy_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader

    Public MustOverride Function CMS_TypeUnemploy_Add(PortalConnect As String, TypeUnemploy_Code As String, TypeUnemploy_Name As String, TypeUnemploy_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer) As Integer
    Public MustOverride Sub CMS_TypeUnemploy_Update(PortalConnect As String, TypeUnemploy_ID As Integer, TypeUnemploy_Code As String, TypeUnemploy_Name As String, TypeUnemploy_Des As String, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, isActive As Boolean, isOrder As Integer)
    Public MustOverride Sub CMS_TypeUnemploy_Delete(PortalConnect As String, TypeUnemploy_ID As Integer)
    Public MustOverride Sub CMS_TypeUnemploy_Update_Quick(PortalConnect As String, TypeUnemploy_ID As Integer, isActive As Boolean, isOrder As Integer)
#End Region
#Region "CMS_HoGD"
    Public MustOverride Function CMS_HoGD_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_Backup_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_List_Menu(tpConnect As String, id As String, key As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_GenMaHo(tpConnect As String, matinh As String, mahuyen As String, maxa As String, mathon As String) As Integer
    Public MustOverride Function CMS_HoGD_Get(tpConnect As String, id As String) As IDataReader
    Public MustOverride Function CMS_HoGD_List(tpConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_List_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_List_Search_Deleted(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean) As IDataReader
    Public MustOverride Function CMS_HoGD_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, loaiHo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, Optional ByVal IsDuplicate As Boolean = False) As IDataReader
    Public MustOverride Function CMS_HoGD_Add(tpConnect As String, obj As CMS_HoGDInfo) As Integer
    Public MustOverride Sub CMS_HoGD_Update(tpConnect As String, obj As CMS_HoGDInfo)
    Public MustOverride Sub CMS_HoGD_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
    Public MustOverride Sub CMS_HoGD_Backup_Update_BienDong(tpConnect As String, ID As String, loaiBienDong As Integer, yearID As Integer)
    Public MustOverride Sub CMS_HoGD_Update_BienDong(tpConnect As String, id As String, loaiBienDong As Integer)
    Public MustOverride Sub CMS_HoGD_Update_Move(tpConnect As String, id As String, chuyen As Integer)
    Public MustOverride Sub CMS_HoGD_Update_SoNhanKhau(tpConnect As String, id As String, soNhanKhau As Integer)
    Public MustOverride Sub CMS_HoGD_Update_SoSo(tpConnect As String, id As String, idSo As Integer)
    Public MustOverride Sub CMS_HoGD_Update_Name(tpConnect As String, id As String, Ten As String, type As Integer)
    Public MustOverride Function CMS_HoGD_Update_MaHo(tpConnect As String, id As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String) As String
    Public MustOverride Sub CMS_HoGD_Update_Merger(tpConnect As String, ID As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, diachi As String, idSo As String)
    Public MustOverride Sub CMS_HoGD_Delete(tpConnect As String, id As String)
    Public MustOverride Sub CMS_HoGD_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
    Public MustOverride Function CMS_HoGD_RecoveryData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer) As Integer
#End Region
#Region "CMS_HoGD_Khau"

    Public MustOverride Function CMS_HoGD_Khau_List_Fix(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, errType As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Sub CMS_HoGD_Khau_Backup(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, yearid As Integer, username As String)
    Public MustOverride Function CMS_HoGD_Khau_CheckCCCD(tpConnect As String, cmnd As String, Id As String) As IDataReader
    Public MustOverride Function CMS_HoGD_GenMaThanhVien(tpConnect As String, idHo As String) As Integer
    Public MustOverride Function CMS_HoGD_Khau_Get(tpConnect As String, id As String) As IDataReader
    Public MustOverride Function CMS_HoGD_Khau_List(tpConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_Khau_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String) As IDataReader
    Public MustOverride Function CMS_HoGD_Khau_List_Search(tpConnect As String, search As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, isOrder As Integer, year As Integer, idSo As Integer, currPage As Integer, recodperpage As Integer, IsNow As Boolean, Optional ByVal yearCreated As Integer = 0) As IDataReader

    Public MustOverride Function CMS_HoGD_Khau_Backup_List_ByIDHo(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, idHo As String, yearID As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_Khau_Backup_Get_By_YearID(tpConnect As String, id As String, yearID As Integer) As IDataReader

    Public MustOverride Sub CMS_HoGD_Khau_Add(tpConnect As String, obj As CMS_HoGD_KhauInfo)
    Public MustOverride Sub CMS_HoGD_Khau_Update(tpConnect As String, obj As CMS_HoGD_KhauInfo)
    Public MustOverride Sub CMS_HoGD_Khau_Update_Delete(tpConnect As String, id As String, isDelete As Boolean, deleteDate As DateTime, deleteUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer)
    Public MustOverride Sub CMS_HoGD_Khau_Backup_Update_BienDong(tpConnect As String, idHo As String, idTv As String, loaiBienDong As Integer, yearID As Integer)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_TDHV(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_TDGD(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_CMKT(tpConnect As String, id As String, valKey As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_CVLTN(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_CVLKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_TNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_KVLKTNKHDKT(tpConnect As String, id As String, valKey As Integer, valKey2 As Integer, valKey3 As Integer, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Fix_NganhNghe(tpConnect As String, id As String, valKey As String, updatedDate As DateTime, updatedUser As String)
    Public MustOverride Sub CMS_HoGD_Khau_Delete(tpConnect As String, id As String)
#End Region
#Region "CMS_Provide_History"
    Public MustOverride Function CMS_Provide_History_Get(tpConnect As String, history_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_History_List(tpConnect As String) As IDataReader

    Public MustOverride Sub CMS_Provide_History_Add(tpConnect As String, obj As CMS_Provide_HistoryInfo)
    Public MustOverride Sub CMS_Provide_History_Update(tpConnect As String, obj As CMS_Provide_HistoryInfo)
    Public MustOverride Sub CMS_Provide_History_Delete(tpConnect As String, history_ID As String)

    Public MustOverride Function CMS_Provide_History_Get_Send(tpConnect As String, tinhTP As Integer, huyen As Integer, xa As Integer, maDvi As Integer) As IDataReader
#End Region
#Region "CMS_Provide_Config"
    Public MustOverride Function CMS_Provide_Config_List_Search(tpConnect As String, tinhTP As Integer, isActive As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get_Active(tpConnect As String, TinhTP As Integer, isActive As Boolean) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get_Value(tpConnect As String, TinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proconfig_value As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_Get(tpConnect As String, proConfig_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_Config_List(tpConnect As String, portalId As Integer) As IDataReader
    Public MustOverride Function CMS_Provide_Config_List_ByTinh(tpConnect As String, tinh As Integer) As IDataReader
    Public MustOverride Sub CMS_Provide_Config_Update_Active(tpConnect As String, proConfig_ID As String, active As Boolean)
    Public MustOverride Sub CMS_Provide_Config_Add(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, isOrder As Integer)
    Public MustOverride Sub CMS_Provide_Config_Update(tpConnect As String, proConfig_ID As String, tinhTP As Integer, QuanHuyen As Integer, PhuongXa As Integer, ThonTo As Integer, proConfig_Name As String, proConfig_Value As String, isActive As Boolean, isLock As Boolean, isFlag As Integer, createdDate As DateTime, createdUser As String, updatedDate As DateTime, updatedUser As String, portalId As Integer, isOrder As Integer)
    Public MustOverride Sub CMS_Provide_Config_Delete(tpConnect As String, proConfig_ID As String)
#End Region
#Region "CMS_Provide_BienDongKhau"
    Public MustOverride Function CMS_Provide_BienDongKhau_Get(tpConnect As String, bienDong_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_BienDongKhau_List(tpConnect As String) As IDataReader

    Public MustOverride Sub CMS_Provide_BienDongKhau_Add(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
    Public MustOverride Sub CMS_Provide_BienDongKhau_Update(tpConnect As String, obj As CMS_Provide_BienDongKhauInfo)
    Public MustOverride Sub CMS_Provide_BienDongKhau_Delete(tpConnect As String, bienDong_ID As String)
#End Region
#Region "CMS_Provide_BienDongHo"
    Public MustOverride Function CMS_Provide_BienDongHo_Get(tpConnect As String, bienDong_ID As String) As IDataReader
    Public MustOverride Function CMS_Provide_BienDongHo_List(tpConnect As String) As IDataReader

    Public MustOverride Sub CMS_Provide_BienDongHo_Add(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
    Public MustOverride Sub CMS_Provide_BienDongHo_Update(tpConnect As String, obj As CMS_Provide_BienDongHoInfo)
    Public MustOverride Sub CMS_Provide_BienDongHo_Delete(tpConnect As String, bienDong_ID As String)
#End Region
#Region "CMS_HoGD_Backup"
    Public MustOverride Function CMS_HoGD_Backup_Get(tpConnect As String, idBackup As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_Backup_List(tpConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_HoGD_Backup_Add(tpConnect As String, obj As CMS_HoGD_BackupInfo) As Integer
    Public MustOverride Sub CMS_HoGD_Backup_Update(tpConnect As String, obj As CMS_HoGD_BackupInfo)
    Public MustOverride Sub CMS_HoGD_Backup_Delete(tpConnect As String, idBackup As Integer)
#End Region
#Region "CMS_HoGD_Khau_Backup"
    Public MustOverride Function CMS_HoGD_Khau_Backup_Get(tpConnect As String, idBackup As Integer) As IDataReader
    Public MustOverride Function CMS_HoGD_Khau_Backup_List(tpConnect As String, portalId As Integer) As IDataReader

    Public MustOverride Function CMS_HoGD_Khau_Backup_Add(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo) As Integer
    Public MustOverride Sub CMS_HoGD_Khau_Backup_Update(tpConnect As String, obj As CMS_HoGD_Khau_BackupInfo)
    Public MustOverride Sub CMS_HoGD_Khau_Backup_Delete(tpConnect As String, idBackup As Integer)
#End Region
#Region "Report-CungLD"
    Public MustOverride Sub CMS_BCTH_ClearData(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer)
    Public MustOverride Function CMS_CungLD_Report0(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report0_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Function CMS_CungLD_Report1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Sub CMS_CungLD_Report2_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Function CMS_CungLD_Report2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Function CMS_CungLD_Report3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report3_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Sub CMS_CungLD_Report4_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Function CMS_CungLD_Report4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Function CMS_CungLD_Report5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
    Public MustOverride Function CMS_CungLD_Report5_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report5_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Sub CMS_CungLD_Report5_1_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, dotuoiTu As Integer, doTuoiDen As Integer)
    Public MustOverride Function CMS_CungLD_Report6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report6_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Sub CMS_CungLD_Report7_TH(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, madonvi As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Function CMS_CungLD_Report7(tpConnect As String, phanloai As Integer, matinh As Integer, mahuyen As Integer, maxa As Integer, madonvi As Integer, year As Integer) As IDataReader
    Public MustOverride Function CMS_CungLD_Report8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function CMS_CungLD_Report9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, dotuoiTu As Integer, doTuoiDen As Integer, curPage As Integer, pageSize As Integer) As IDataReader
    Public MustOverride Sub CMS_CungLD_Report9_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean)
    Public MustOverride Sub CMS_CungLD_Report10_TH(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, isNow As Boolean, typeData As Integer)
    Public MustOverride Function CMS_CungLD_Report10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, mathon As Integer, year As Integer, typeData As Integer) As IDataReader
    Public MustOverride Function CMS_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_1(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16)

    Public MustOverride Function CMS_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_2(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_3(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_4(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_5(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_6(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_7(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_8(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_9(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH1_10(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH11a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH12a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH13a(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH11a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH12a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH13a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH14a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH15a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH16a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH17a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH18a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH19a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH20a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH21a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH22a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH23a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH24a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH25a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH26a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH27a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, sqlTb As String, isFlag As Int16, level As Integer) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH28a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, sqlTb As String, isFlag As Int16, level As Integer)

    Public MustOverride Function CMS_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isFlag As Int16, level As Integer, parentID As String) As IDataReader
    Public MustOverride Sub RUN_Report_BCTH29a_CVL(tpConnect As String, matinh As Integer, mahuyen As Integer, maxa As Integer, year As Integer, isNow As Boolean, isFlag As Int16, strRow As String, level As Integer, parentID As String)

    Public MustOverride Function CMS_CungLD_CustomReport(tpConnect As String, matinh As Int16, maHuyen As Integer, maXa As Integer, levelHC As Integer, rowID As Integer, colID As String, isNow As Boolean, years As Integer, typeRow As Int16, typeCol As Int16, option1 As String, option2 As String) As IDataReader
#End Region
#Region "CMS_CungLD"
    Public MustOverride Function CMS_CungLD_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function CMS_CungLD_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_CungLD_Add(PortalConnect As String, obj As CMS_CungLDInfo) As Integer
    Public MustOverride Sub CMS_CungLD_Update(PortalConnect As String, obj As CMS_CungLDInfo)
    Public MustOverride Sub CMS_CungLD_Delete(PortalConnect As String, iD As Integer)
    Public MustOverride Function CMS_CungLD_List_Search(PortalConnect As String, search As String, isOrder As Integer, currPage As Integer, recodperpage As Integer, UserName As String) As IDataReader


#End Region
#Region "CMS_Age"
    Public MustOverride Function CMS_Age_Get(PortalConnect As String, age_ID As Integer) As IDataReader
    Public MustOverride Function CMS_Age_List(PortalConnect As String) As IDataReader
    Public MustOverride Function CMS_Age_Add(PortalConnect As String, obj As CMS_AgeInfo) As Integer
    Public MustOverride Sub CMS_Age_Update(PortalConnect As String, obj As CMS_AgeInfo)
    Public MustOverride Sub CMS_Age_Delete(PortalConnect As String, age_ID As Integer)
#End Region
#Region "TH27_M01"
    Public MustOverride Function TH27_M01_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function TH27_M01_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TH27_M01_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function TH27_M01_Add(PortalConnect As String, obj As TH27_M01Info) As Integer
    Public MustOverride Sub TH27_M01_Update(PortalConnect As String, obj As TH27_M01Info)
    Public MustOverride Sub TH27_M01_Delete(PortalConnect As String, iD As Integer)

#End Region
#Region "TH27_M02"
    Public MustOverride Function TH27_M02_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function TH27_M02_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TH27_M02_List_Search(PortalConnect As String, tinhTP As Integer, quanHuyen As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function TH27_M02_Add(PortalConnect As String, obj As TH27_M02Info) As Integer
    Public MustOverride Sub TH27_M02_Update(PortalConnect As String, obj As TH27_M02Info)
    Public MustOverride Sub TH27_M02_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "TH27_M03"
    Public MustOverride Function TH27_M03_Get(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Function TH27_M03_List(PortalConnect As String) As IDataReader
    Public MustOverride Function TH27_M03_List_Search(PortalConnect As String, tinhTP As Integer, years As Integer, currPage As Integer, recodperpage As Integer) As IDataReader
    Public MustOverride Function TH27_M03_Add(PortalConnect As String, obj As TH27_M03Info) As Integer
    Public MustOverride Sub TH27_M03_Update(PortalConnect As String, obj As TH27_M03Info)
    Public MustOverride Sub TH27_M03_Delete(PortalConnect As String, iD As Integer)
#End Region
#Region "TH27_M01_A"
    Public MustOverride Sub RPT_TH27_M01_A_RUN(PortalConnect As String, m01ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer)
    Public MustOverride Sub TH27_M01_A_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M01_A_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M01_B"
    Public MustOverride Sub RPT_TH27_M01_B_RUN(PortalConnect As String, m01ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, maThon As Integer, tenThon As String, years As Integer)
    Public MustOverride Sub TH27_M01_B_Delete_By_TH27_M01(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M01_B_Get_By_TH27_M01(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M02_A"
    Public MustOverride Sub RPT_TH27_M02_A_RUN(PortalConnect As String, m02ID As Integer, years As Integer, tinhTP As Integer, quanHuyen As Integer)
    Public MustOverride Function TH27_M02_A_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
    Public MustOverride Sub TH27_M02_A_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
#End Region
#Region "TH27_M02_B"
    Public MustOverride Sub RPT_TH27_M02_B_RUN(PortalConnect As String, m02ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, xaPhuong As Integer, tenXaPhuong As String, years As Integer)
    Public MustOverride Sub TH27_M02_B_Delete_By_TH27_M02(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M02_B_Get_By_TH27_M02(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M03_A"
    Public MustOverride Sub RPT_TH27_M03_A_RUN(PortalConnect As String, m03ID As Integer, years As Integer, tinhTP As Integer)
    Public MustOverride Sub TH27_M03_A_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M03_A_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "TH27_M03_B"
    Public MustOverride Sub RPT_TH27_M03_B_RUN(PortalConnect As String, m03ID As Integer, sTT As Integer, tinhTP As Integer, quanHuyen As Integer, tenQuanHuyen As String, years As Integer)
    Public MustOverride Sub TH27_M03_B_Delete_By_TH27_M03(PortalConnect As String, iD As Integer)
    Public MustOverride Function TH27_M03_B_Get_By_TH27_M03(PortalConnect As String, iD As Integer) As IDataReader
#End Region
#Region "API"
    Public MustOverride Function API_CungLD_01(PortalConnect As String, tp As Integer, qh As Integer, xp As Integer, tto As Integer, year As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function API_CungLD_02(PortalConnect As String, tp As Integer, maHo As String, loaiHo As Integer, year As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function API_CungLD_03(PortalConnect As String, tp As Integer, gt As Integer, cmkt As Integer, tdgd As Integer, tinhtrang As Integer, year As Integer, isNow As Boolean) As IDataReader
#End Region

#Region "REPORT CHART"
    Public MustOverride Function CMS_Report13(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function CMS_Report13_1(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean) As IDataReader
    Public MustOverride Function CMS_Chart_Data(tpConnect As String, tp As Integer, qh As Integer, xp As Integer, year As Integer, isNow As Boolean, maBC As String) As IDataReader
    Public MustOverride Function CMS_Chart_DataHC(tpConnect As String, tp As Integer, qh As Integer, ids As String, year As Integer, isNow As Boolean, maBC As String) As IDataReader

#End Region
End Class
