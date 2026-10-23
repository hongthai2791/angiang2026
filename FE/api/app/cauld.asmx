 <%@ WebService Language="VB" Class="Cauld" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports DotNetNuke.Services.Log.EventLog
Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication
Imports DotNetNuke.Security.Roles
<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class AuthHeader
    Inherits SoapHeader
    Public userRole As String
    Public userId As String
End Class
Public Class Cauld
    Inherits System.Web.Services.WebService
    Public Authentication As AuthHeader
    Dim objCtl As New CauController
    Dim pid As Integer = 0
    Dim arr As New ArrayList
    Dim strCache As String = ""
    Dim obj As New UserInfo
    Dim ubj As New EPORTAL.CMSUserPortalInfo
    Dim userControler As New UserController
    Dim maDonVi As Integer = flReg.WebConfig("TinhTP")


#Region "DanhMuc"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_TinhTP() As String
        If IsNothing(flCache.GetCache("CMS_RegionalTP_List_Parent_Null" & pid)) Then
            arr = flDnn.CMS_RegionalTP_List_Parent_Null(pid)
            flCache.SetCache("CMS_RegionalTP_List_Parent_Null" & pid, arr)
        Else
            arr = CType(flCache.GetCache("CMS_RegionalTP_List_Parent_Null" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_QuanHuyen(tinhTp As String) As String
        If IsNothing(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP" & pid & tinhTp)) Then
            arr = flDnn.CMS_RegionalQH_Get_By_CMS_RegionalTP(pid, tinhTp)
            flCache.SetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP" & pid & tinhTp, arr)
        Else
            arr = CType(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP" & pid & tinhTp), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_PhuongXa(quanHuyen As String) As String
        If IsNothing(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH" & pid & quanHuyen)) Then
            arr = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, quanHuyen)
            flCache.SetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH" & pid & quanHuyen, arr)
        Else
            arr = CType(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH" & pid & quanHuyen), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_KhuCN(tinhTp As String) As String
        If IsNothing(flCache.GetCache("BC_IndustrialZone_List_ByTP" & pid & tinhTp)) Then
            arr = objCtl.BC_IndustrialZone_List_ByTP(pid, tinhTp, 0, "")
            flCache.SetCache("BC_IndustrialZone_List_ByTP" & pid & tinhTp, arr)
        Else
            arr = CType(flCache.GetCache("BC_IndustrialZone_List_ByTP" & pid & tinhTp), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_LoaiHinh() As String
        If IsNothing(flCache.GetCache("BC_CompanyType_List" & pid)) Then
            arr = objCtl.BC_CompanyType_List(pid)
            flCache.SetCache("BC_CompanyType_List" & pid, arr)
        Else
            arr = CType(flCache.GetCache("BC_CompanyType_List" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_NganhNghe() As String
        If IsNothing(flCache.GetCache("BC_Career_Get_By_BC_Career" & pid)) Then
            arr = objCtl.BC_Career_Get_By_BC_Career(pid, 0)
            flCache.SetCache("BC_Career_Get_By_BC_Career" & pid, arr)
        Else
            arr = CType(flCache.GetCache("BC_Career_Get_By_BC_Career" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DM_QuyMoLD() As String
        Dim arr As New ArrayList
        Dim dmc As New DanhMucChung
        dmc.Id = 1
        dmc.Name = "< 10"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 2
        dmc.Name = "10 - 50"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 3
        dmc.Name = "51 - 100"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 4
        dmc.Name = "101 - 200"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 5
        dmc.Name = "201 - 500"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 6
        dmc.Name = "501 - 1.000"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 7
        dmc.Name = "1.001 - 3.000"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 8
        dmc.Name = "3.001 - 10.000"
        arr.Add(dmc)
        dmc = New DanhMucChung
        dmc.Id = 9
        dmc.Name = "> 10.000"
        arr.Add(dmc)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CauLD_ThemMoi(tenDoanhNghiep As String, taxCode As String,
                                  loaiHinh_ID As String, tinhTp As String, quanHuyen As String, xaPhuong As String,
                                  soNha As String, khuCN As String, mobile As String, email As String, nganhNghe As String,
                                  sanPhamChinh As String, quyMoLaoDong As String, ld_TongSo As String, ld_Nu As String,
                                  ld_BHXH As String, ld_BHXH_Nu As String, ld_TREN35 As String, ld_TREN35_Nu As String, vt_NhaQuanLy As String,
                                  vt_NhaQuanLy_Nu As String, vt_CMKT_Cao As String, vt_CMKT_Cao_Nu As String, vt_CMKT_Trung As String, vt_CMKT_Trung_Nu As String,
                                 vt_CMKT_Khac As String, vt_CMKT_Khac_Nu As String, laoDong6Thang As String,
                                  nctd_17 As String, nctd_17_Nu As String, nctd_21 As String, nctd_21_Nu As String,
                                   nctd_22 As String, nctd_22_Nu As String, nctd_23 As String, nctd_23_Nu As String,
                                   nctd_24 As String, nctd_24_Nu As String, nctd_25 As String, nctd_25_Nu As String,
                                   nctd_26 As String, nctd_26_Nu As String, nctd_31 As String, nctd_31_Nu As String,
                                   nctd_32 As String, nctd_32_Nu As String, nctd_33 As String, nctd_33_Nu As String,
                                   nctd_34 As String, nctd_34_Nu As String, nctd_35 As String, nctd_35_Nu As String,
                                   nctd_36 As String, nctd_36_Nu As String, nctd_41 As String, nctd_41_Nu As String,
                                   nctd_42 As String, nctd_42_Nu As String, nctd_43 As String, nctd_43_Nu As String,
                                   nctd_44 As String, nctd_44_Nu As String, nctd_51 As String, nctd_51_Nu As String,
                                   nctd_52 As String, nctd_52_Nu As String, nctd_53 As String, nctd_53_Nu As String,
                                   nctd_54 As String, nctd_54_Nu As String, nctd_61 As String, nctd_61_Nu As String,
                                   nctd_62 As String, nctd_62_Nu As String, nctd_63 As String, nctd_63_Nu As String,
                                   nctd_71 As String, nctd_71_Nu As String, nctd_72 As String, nctd_72_Nu As String,
                                   nctd_73 As String, nctd_73_Nu As String, nctd_74 As String, nctd_74_Nu As String,
                                   nctd_75 As String, nctd_75_Nu As String, nctd_81 As String, nctd_81_Nu As String,
                                   nctd_82 As String, nctd_82_Nu As String, nctd_83 As String, nctd_83_Nu As String,
                                   nctd_91 As String, nctd_91_Nu As String, nctd_92 As String, nctd_92_Nu As String,
                                   nctd_93 As String, nctd_93_Nu As String, nctd_94 As String, nctd_94_Nu As String,
                                   nctd_95 As String, nctd_95_Nu As String, nctd_96 As String, nctd_96_Nu As String) As String

        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objDN As WORK.CMS_BusinessInfo = New WORK.WorkController().CMS_Business_Get(pid, busID)

        Dim objCau = New BC_BusinessInfo
        If objDN IsNot Nothing Then
            objCau.DoanhNghiep_ID = busID
            objCau.TenDoanhNghiep = objDN.Business_Vn
            objCau.TaxCode = objDN.TaxCode
            objCau.MaDoanhNghiep = ""
            objCau.Mobile = objDN.Mobile
            objCau.Fax = objDN.Fax
            objCau.Email = objDN.Email
            objCau.Website = objDN.Website
            objCau.TinhTrang = 1
            objCau.TinhTP = objDN.TinhTP
            objCau.QuanHuyen = objDN.QuanHuyen
            objCau.XaPhuong = xaPhuong
            objCau.TT_NT = ""
            objCau.SoNha = soNha
            objCau.KhuCN_ID = khuCN
            objCau.LoaiHinh_ID = loaiHinh_ID
            objCau.NganhNghe = flReg.WriteNumber(nganhNghe)
            objCau.LD_TongSo = flReg.WriteNumber(ld_TongSo)
            objCau.LD_NgoaiTinh = 0
            objCau.LD_TrucTiep = 0
            objCau.LD_Nu = flReg.WriteNumber(ld_Nu)
            objCau.LD_HD_Tong = 0
            objCau.LD_HD_Nu = 0
            objCau.LD_NuocNgoai_Tong = 0
            objCau.LD_NuocNgoai_Nu = 0
            objCau.LD_PhoThong = 0
            objCau.CMKT_Khong = 0
            objCau.CMKT_BangCap = 0
            objCau.CMKT_DaoTao = 0
            objCau.CMKT_SoCap = 0
            objCau.CMKT_TrungCap = 0
            objCau.CMKT_CaoDang = 0
            objCau.CMKT_DaiHoc = 0
            objCau.GDDT_KTXH = 0
            objCau.GDDT_KHTN = 0
            objCau.GDDT_KTCN = 0
            objCau.GDDT_NongNghiep = 0
            objCau.GDDT_YTe = 0
            objCau.GDDT_Khac = 0
            objCau.Nhom_LanhDao = 0
            objCau.Nhom_ChuyenMon = 0
            objCau.Nhom_TroLy = 0
            objCau.Nhom_DichVu = 0
            objCau.Nhom_NongNghiep = 0
            objCau.Nhom_ThuCong = 0
            objCau.Nhom_Tho = 0
            objCau.Nhom_DonGian = 0
            objCau.TL_BinhQuan = 0
            objCau.TL_ThapNhat = 0
            objCau.TL_CaoNhat = 0
            objCau.Chia_Khong = 0
            objCau.Chia_BangCap = 0
            objCau.Chia_DaoTao = 0
            objCau.Chia_SoCap = 0
            objCau.Chia_TrungCap = 0
            objCau.Chia_CaoDang = 0
            objCau.Chia_DaiHoc = 0
            objCau.SanPhamChinh = sanPhamChinh
            objCau.QuyMoLaoDong = flReg.WriteNumber(quyMoLaoDong)
            objCau.LD_NgoaiTinh_Nu = 0
            objCau.LD_TrucTiep_Nu = 0
            objCau.LD_GianTiep = 0
            objCau.LD_GianTiep_Nu = 0
            objCau.LD_BHXH = flReg.WriteNumber(ld_BHXH)
            objCau.LD_BHXH_Nu = flReg.WriteNumber(ld_BHXH_Nu)
            objCau.LD_TREN35 = flReg.WriteNumber(ld_TREN35)
            objCau.LD_TREN35_Nu = flReg.WriteNumber(ld_TREN35_Nu)
            objCau.LD_PhoThong_Nu = 0
            objCau.VT_NhaQuanLy = flReg.WriteNumber(vt_NhaQuanLy)
            objCau.VT_NhaQuanLy_Nu = flReg.WriteNumber(vt_NhaQuanLy_Nu)
            objCau.VT_CMKT_Cao = flReg.WriteNumber(vt_CMKT_Cao)
            objCau.VT_CMKT_Cao_Nu = flReg.WriteNumber(vt_CMKT_Cao_Nu)
            objCau.VT_CMKT_Trung = flReg.WriteNumber(vt_CMKT_Trung)
            objCau.VT_CMKT_Trung_Nu = flReg.WriteNumber(vt_CMKT_Trung_Nu)
            objCau.VT_CMKT_Khac = flReg.WriteNumber(vt_CMKT_Khac)
            objCau.VT_CMKT_Khac_Nu = flReg.WriteNumber(vt_CMKT_Khac_Nu)
            objCau.CMKT_Khong_Nu = 0
            objCau.CMKT_BangCap_Nu = 0
            objCau.CMKT_DaoTao_Nu = 0
            objCau.CMKT_SoCap_Nu = 0
            objCau.CMKT_TrungCap_Nu = 0
            objCau.CMKT_CaoDang_Nu = 0
            objCau.CMKT_DaiHoc_Nu = 0
            objCau.GDDT_KTXH_Nu = 0
            objCau.GDDT_KHTN_Nu = 0
            objCau.GDDT_KTCN_Nu = 0
            objCau.GDDT_NongNghiep_Nu = 0
            objCau.GDDT_YTe_Nu = 0
            objCau.GDDT_Khac_Nu = 0
            objCau.C8_17 = 0
            objCau.C8_21 = 0
            objCau.C8_22 = 0
            objCau.C8_26 = 0
            objCau.C8_31 = 0
            objCau.C8_32 = 0
            objCau.C8_33 = 0
            objCau.C8_34 = 0
            objCau.C8_35 = 0
            objCau.C8_36 = 0
            objCau.C8_41 = 0
            objCau.C8_42 = 0
            objCau.C8_43 = 0
            objCau.C8_44 = 0
            objCau.C8_51 = 0
            objCau.C8_52 = 0
            objCau.C8_53 = 0
            objCau.C8_54 = 0
            objCau.C8_61 = 0
            objCau.C8_62 = 0
            objCau.C8_63 = 0
            objCau.C8_71 = 0
            objCau.C8_72 = 0
            objCau.C8_73 = 0
            objCau.C8_74 = 0
            objCau.C8_75 = 0
            objCau.C8_81 = 0
            objCau.C8_82 = 0
            objCau.C8_83 = 0
            objCau.C8_91 = 0
            objCau.C8_92 = 0
            objCau.C8_93 = 0
            objCau.C8_94 = 0
            objCau.C8_95 = 0
            objCau.C8_96 = 0
            objCau.C8_17_Nu = 0
            objCau.C8_21_Nu = 0
            objCau.C8_22_Nu = 0
            objCau.C8_23_Nu = 0
            objCau.C8_24_Nu = 0
            objCau.C8_25_Nu = 0
            objCau.C8_26_Nu = 0
            objCau.C8_31_Nu = 0
            objCau.C8_32_Nu = 0
            objCau.C8_33_Nu = 0
            objCau.C8_34_Nu = 0
            objCau.C8_35_Nu = 0
            objCau.C8_36_Nu = 0
            objCau.C8_41_Nu = 0
            objCau.C8_42_Nu = 0
            objCau.C8_43_Nu = 0
            objCau.C8_44_Nu = 0
            objCau.C8_51_Nu = 0
            objCau.C8_52_Nu = 0
            objCau.C8_53_Nu = 0
            objCau.C8_54_Nu = 0
            objCau.C8_61_Nu = 0
            objCau.C8_62_Nu = 0
            objCau.C8_63_Nu = 0
            objCau.C8_71_Nu = 0
            objCau.C8_72_Nu = 0
            objCau.C8_73_Nu = 0
            objCau.C8_74_Nu = 0
            objCau.C8_75_Nu = 0
            objCau.C8_81_Nu = 0
            objCau.C8_82_Nu = 0
            objCau.C8_83_Nu = 0
            objCau.C8_91_Nu = 0
            objCau.C8_92_Nu = 0
            objCau.C8_93_Nu = 0
            objCau.C8_94_Nu = 0
            objCau.C8_95_Nu = 0
            objCau.C8_96_Nu = 0
            objCau.C11_17 = flReg.WriteNumber(nctd_17)
            objCau.C11_21 = flReg.WriteNumber(nctd_21)
            objCau.C11_22 = flReg.WriteNumber(nctd_22)
            objCau.C11_23 = flReg.WriteNumber(nctd_23)
            objCau.C11_24 = flReg.WriteNumber(nctd_24)
            objCau.C11_25 = flReg.WriteNumber(nctd_25)
            objCau.C11_26 = flReg.WriteNumber(nctd_26)
            objCau.C11_31 = flReg.WriteNumber(nctd_31)
            objCau.C11_32 = flReg.WriteNumber(nctd_32)
            objCau.C11_33 = flReg.WriteNumber(nctd_33)
            objCau.C11_34 = flReg.WriteNumber(nctd_34)
            objCau.C11_35 = flReg.WriteNumber(nctd_35)
            objCau.C11_36 = flReg.WriteNumber(nctd_36)
            objCau.C11_41 = flReg.WriteNumber(nctd_41)
            objCau.C11_42 = flReg.WriteNumber(nctd_42)
            objCau.C11_43 = flReg.WriteNumber(nctd_43)
            objCau.C11_44 = flReg.WriteNumber(nctd_44)
            objCau.C11_51 = flReg.WriteNumber(nctd_51)
            objCau.C11_52 = flReg.WriteNumber(nctd_52)
            objCau.C11_53 = flReg.WriteNumber(nctd_53)
            objCau.C11_54 = flReg.WriteNumber(nctd_54)
            objCau.C11_61 = flReg.WriteNumber(nctd_61)
            objCau.C11_62 = flReg.WriteNumber(nctd_62)
            objCau.C11_63 = flReg.WriteNumber(nctd_63)
            objCau.C11_71 = flReg.WriteNumber(nctd_71)
            objCau.C11_72 = flReg.WriteNumber(nctd_72)
            objCau.C11_73 = flReg.WriteNumber(nctd_73)
            objCau.C11_74 = flReg.WriteNumber(nctd_74)
            objCau.C11_75 = flReg.WriteNumber(nctd_75)
            objCau.C11_81 = flReg.WriteNumber(nctd_81)
            objCau.C11_82 = flReg.WriteNumber(nctd_82)
            objCau.C11_83 = flReg.WriteNumber(nctd_83)
            objCau.C11_91 = flReg.WriteNumber(nctd_91)
            objCau.C11_92 = flReg.WriteNumber(nctd_92)
            objCau.C11_93 = flReg.WriteNumber(nctd_93)
            objCau.C11_94 = flReg.WriteNumber(nctd_94)
            objCau.C11_95 = flReg.WriteNumber(nctd_95)
            objCau.C11_96 = flReg.WriteNumber(nctd_96)
            objCau.C11_17_Nu = flReg.WriteNumber(nctd_17_Nu)
            objCau.C11_21_Nu = flReg.WriteNumber(nctd_21_Nu)
            objCau.C11_22_Nu = flReg.WriteNumber(nctd_22_Nu)
            objCau.C11_23_Nu = flReg.WriteNumber(nctd_23_Nu)
            objCau.C11_24_Nu = flReg.WriteNumber(nctd_24_Nu)
            objCau.C11_25_Nu = flReg.WriteNumber(nctd_25_Nu)
            objCau.C11_26_Nu = flReg.WriteNumber(nctd_26_Nu)
            objCau.C11_31_Nu = flReg.WriteNumber(nctd_31_Nu)
            objCau.C11_32_Nu = flReg.WriteNumber(nctd_32_Nu)
            objCau.C11_33_Nu = flReg.WriteNumber(nctd_33_Nu)
            objCau.C11_34_Nu = flReg.WriteNumber(nctd_34_Nu)
            objCau.C11_35_Nu = flReg.WriteNumber(nctd_35_Nu)
            objCau.C11_36_Nu = flReg.WriteNumber(nctd_36_Nu)
            objCau.C11_41_Nu = flReg.WriteNumber(nctd_41_Nu)
            objCau.C11_42_Nu = flReg.WriteNumber(nctd_42_Nu)
            objCau.C11_43_Nu = flReg.WriteNumber(nctd_43_Nu)
            objCau.C11_44_Nu = flReg.WriteNumber(nctd_44_Nu)
            objCau.C11_51_Nu = flReg.WriteNumber(nctd_51_Nu)
            objCau.C11_52_Nu = flReg.WriteNumber(nctd_52_Nu)
            objCau.C11_53_Nu = flReg.WriteNumber(nctd_53_Nu)
            objCau.C11_54_Nu = flReg.WriteNumber(nctd_54_Nu)
            objCau.C11_61_Nu = flReg.WriteNumber(nctd_61_Nu)
            objCau.C11_62_Nu = flReg.WriteNumber(nctd_62_Nu)
            objCau.C11_63_Nu = flReg.WriteNumber(nctd_63_Nu)
            objCau.C11_71_Nu = flReg.WriteNumber(nctd_71_Nu)
            objCau.C11_72_Nu = flReg.WriteNumber(nctd_72_Nu)
            objCau.C11_73_Nu = flReg.WriteNumber(nctd_73_Nu)
            objCau.C11_74_Nu = flReg.WriteNumber(nctd_74_Nu)
            objCau.C11_75_Nu = flReg.WriteNumber(nctd_75_Nu)
            objCau.C11_81_Nu = flReg.WriteNumber(nctd_81_Nu)
            objCau.C11_82_Nu = flReg.WriteNumber(nctd_82_Nu)
            objCau.C11_83_Nu = flReg.WriteNumber(nctd_83_Nu)
            objCau.C11_91_Nu = flReg.WriteNumber(nctd_91_Nu)
            objCau.C11_92_Nu = flReg.WriteNumber(nctd_92_Nu)
            objCau.C11_93_Nu = flReg.WriteNumber(nctd_93_Nu)
            objCau.C11_94_Nu = flReg.WriteNumber(nctd_94_Nu)
            objCau.C11_95_Nu = flReg.WriteNumber(nctd_95_Nu)
            objCau.C11_96_Nu = flReg.WriteNumber(nctd_96_Nu)
            objCau.C10_LaoDong = flReg.WriteNumber(laoDong6Thang)
            objCau.Chia_Khong_Nu = 0
            objCau.Chia_BangCap_Nu = 0
            objCau.Chia_DaoTao_Nu = 0
            objCau.Chia_SoCap_Nu = 0
            objCau.Chia_TrungCap_Nu = 0
            objCau.Chia_CaoDang_Nu = 0
            objCau.Chia_DaiHoc_Nu = 0

            objCau.PortalId = pid
            objCau.CreatedDate = Now
            objCau.CreatedUser = obj.Username
            objCtl.BC_Business_Add(pid, objCau)
        Else
            objCau = New BC_BusinessInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objCau), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CauLD_ChinhSua(id As String, tenDoanhNghiep As String, taxCode As String,
                                  loaiHinh_ID As String, tinhTp As String, quanHuyen As String, xaPhuong As String,
                                  soNha As String, khuCN As String, mobile As String, email As String, nganhNghe As String,
                                  sanPhamChinh As String, quyMoLaoDong As String, ld_TongSo As String, ld_Nu As String,
                                  ld_BHXH As String, ld_BHXH_Nu As String, ld_TREN35 As String, ld_TREN35_Nu As String, vt_NhaQuanLy As String,
                                  vt_NhaQuanLy_Nu As String, vt_CMKT_Cao As String, vt_CMKT_Cao_Nu As String, vt_CMKT_Trung As String, vt_CMKT_Trung_Nu As String,
                                 vt_CMKT_Khac As String, vt_CMKT_Khac_Nu As String, laoDong6Thang As String,
                                  nctd_17 As String, nctd_17_Nu As String, nctd_21 As String, nctd_21_Nu As String,
                                   nctd_22 As String, nctd_22_Nu As String, nctd_23 As String, nctd_23_Nu As String,
                                   nctd_24 As String, nctd_24_Nu As String, nctd_25 As String, nctd_25_Nu As String,
                                   nctd_26 As String, nctd_26_Nu As String, nctd_31 As String, nctd_31_Nu As String,
                                   nctd_32 As String, nctd_32_Nu As String, nctd_33 As String, nctd_33_Nu As String,
                                   nctd_34 As String, nctd_34_Nu As String, nctd_35 As String, nctd_35_Nu As String,
                                   nctd_36 As String, nctd_36_Nu As String, nctd_41 As String, nctd_41_Nu As String,
                                   nctd_42 As String, nctd_42_Nu As String, nctd_43 As String, nctd_43_Nu As String,
                                   nctd_44 As String, nctd_44_Nu As String, nctd_51 As String, nctd_51_Nu As String,
                                   nctd_52 As String, nctd_52_Nu As String, nctd_53 As String, nctd_53_Nu As String,
                                   nctd_54 As String, nctd_54_Nu As String, nctd_61 As String, nctd_61_Nu As String,
                                   nctd_62 As String, nctd_62_Nu As String, nctd_63 As String, nctd_63_Nu As String,
                                   nctd_71 As String, nctd_71_Nu As String, nctd_72 As String, nctd_72_Nu As String,
                                   nctd_73 As String, nctd_73_Nu As String, nctd_74 As String, nctd_74_Nu As String,
                                   nctd_75 As String, nctd_75_Nu As String, nctd_81 As String, nctd_81_Nu As String,
                                   nctd_82 As String, nctd_82_Nu As String, nctd_83 As String, nctd_83_Nu As String,
                                   nctd_91 As String, nctd_91_Nu As String, nctd_92 As String, nctd_92_Nu As String,
                                   nctd_93 As String, nctd_93_Nu As String, nctd_94 As String, nctd_94_Nu As String,
                                   nctd_95 As String, nctd_95_Nu As String, nctd_96 As String, nctd_96_Nu As String) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objDN As WORK.CMS_BusinessInfo = New WORK.WorkController().CMS_Business_Get(pid, busID)

        Dim objCau = New BC_BusinessInfo
        If objDN IsNot Nothing Then
            objCau.DoanhNghiep_ID = busID
            objCau.TenDoanhNghiep = objDN.Business_Vn
            objCau.TaxCode = objDN.TaxCode
            objCau.MaDoanhNghiep = ""
            objCau.Mobile = objDN.Mobile
            objCau.Fax = objDN.Fax
            objCau.Email = objDN.Email
            objCau.Website = objDN.Website
            objCau.TinhTrang = 1
            objCau.TinhTP = objDN.TinhTP
            objCau.QuanHuyen = objDN.QuanHuyen
            objCau.XaPhuong = xaPhuong
            objCau.TT_NT = ""
            objCau.SoNha = soNha
            objCau.KhuCN_ID = khuCN
            objCau.LoaiHinh_ID = loaiHinh_ID
            objCau.NganhNghe = flReg.WriteNumber(nganhNghe)
            objCau.LD_TongSo = flReg.WriteNumber(ld_TongSo)
            objCau.LD_NgoaiTinh = 0
            objCau.LD_TrucTiep = 0
            objCau.LD_Nu = flReg.WriteNumber(ld_Nu)
            objCau.LD_HD_Tong = 0
            objCau.LD_HD_Nu = 0
            objCau.LD_NuocNgoai_Tong = 0
            objCau.LD_NuocNgoai_Nu = 0
            objCau.LD_PhoThong = 0
            objCau.CMKT_Khong = 0
            objCau.CMKT_BangCap = 0
            objCau.CMKT_DaoTao = 0
            objCau.CMKT_SoCap = 0
            objCau.CMKT_TrungCap = 0
            objCau.CMKT_CaoDang = 0
            objCau.CMKT_DaiHoc = 0
            objCau.GDDT_KTXH = 0
            objCau.GDDT_KHTN = 0
            objCau.GDDT_KTCN = 0
            objCau.GDDT_NongNghiep = 0
            objCau.GDDT_YTe = 0
            objCau.GDDT_Khac = 0
            objCau.Nhom_LanhDao = 0
            objCau.Nhom_ChuyenMon = 0
            objCau.Nhom_TroLy = 0
            objCau.Nhom_DichVu = 0
            objCau.Nhom_NongNghiep = 0
            objCau.Nhom_ThuCong = 0
            objCau.Nhom_Tho = 0
            objCau.Nhom_DonGian = 0
            objCau.TL_BinhQuan = 0
            objCau.TL_ThapNhat = 0
            objCau.TL_CaoNhat = 0
            objCau.Chia_Khong = 0
            objCau.Chia_BangCap = 0
            objCau.Chia_DaoTao = 0
            objCau.Chia_SoCap = 0
            objCau.Chia_TrungCap = 0
            objCau.Chia_CaoDang = 0
            objCau.Chia_DaiHoc = 0
            objCau.SanPhamChinh = sanPhamChinh
            objCau.QuyMoLaoDong = flReg.WriteNumber(quyMoLaoDong)
            objCau.LD_NgoaiTinh_Nu = 0
            objCau.LD_TrucTiep_Nu = 0
            objCau.LD_GianTiep = 0
            objCau.LD_GianTiep_Nu = 0
            objCau.LD_BHXH = flReg.WriteNumber(ld_BHXH)
            objCau.LD_BHXH_Nu = flReg.WriteNumber(ld_BHXH_Nu)
            objCau.LD_TREN35 = flReg.WriteNumber(ld_TREN35)
            objCau.LD_TREN35_Nu = flReg.WriteNumber(ld_TREN35_Nu)
            objCau.LD_PhoThong_Nu = 0
            objCau.VT_NhaQuanLy = flReg.WriteNumber(vt_NhaQuanLy)
            objCau.VT_NhaQuanLy_Nu = flReg.WriteNumber(vt_NhaQuanLy_Nu)
            objCau.VT_CMKT_Cao = flReg.WriteNumber(vt_CMKT_Cao)
            objCau.VT_CMKT_Cao_Nu = flReg.WriteNumber(vt_CMKT_Cao_Nu)
            objCau.VT_CMKT_Trung = flReg.WriteNumber(vt_CMKT_Trung)
            objCau.VT_CMKT_Trung_Nu = flReg.WriteNumber(vt_CMKT_Trung_Nu)
            objCau.VT_CMKT_Khac = flReg.WriteNumber(vt_CMKT_Khac)
            objCau.VT_CMKT_Khac_Nu = flReg.WriteNumber(vt_CMKT_Khac_Nu)
            objCau.CMKT_Khong_Nu = 0
            objCau.CMKT_BangCap_Nu = 0
            objCau.CMKT_DaoTao_Nu = 0
            objCau.CMKT_SoCap_Nu = 0
            objCau.CMKT_TrungCap_Nu = 0
            objCau.CMKT_CaoDang_Nu = 0
            objCau.CMKT_DaiHoc_Nu = 0
            objCau.GDDT_KTXH_Nu = 0
            objCau.GDDT_KHTN_Nu = 0
            objCau.GDDT_KTCN_Nu = 0
            objCau.GDDT_NongNghiep_Nu = 0
            objCau.GDDT_YTe_Nu = 0
            objCau.GDDT_Khac_Nu = 0
            objCau.C8_17 = 0
            objCau.C8_21 = 0
            objCau.C8_22 = 0
            objCau.C8_26 = 0
            objCau.C8_31 = 0
            objCau.C8_32 = 0
            objCau.C8_33 = 0
            objCau.C8_34 = 0
            objCau.C8_35 = 0
            objCau.C8_36 = 0
            objCau.C8_41 = 0
            objCau.C8_42 = 0
            objCau.C8_43 = 0
            objCau.C8_44 = 0
            objCau.C8_51 = 0
            objCau.C8_52 = 0
            objCau.C8_53 = 0
            objCau.C8_54 = 0
            objCau.C8_61 = 0
            objCau.C8_62 = 0
            objCau.C8_63 = 0
            objCau.C8_71 = 0
            objCau.C8_72 = 0
            objCau.C8_73 = 0
            objCau.C8_74 = 0
            objCau.C8_75 = 0
            objCau.C8_81 = 0
            objCau.C8_82 = 0
            objCau.C8_83 = 0
            objCau.C8_91 = 0
            objCau.C8_92 = 0
            objCau.C8_93 = 0
            objCau.C8_94 = 0
            objCau.C8_95 = 0
            objCau.C8_96 = 0
            objCau.C8_17_Nu = 0
            objCau.C8_21_Nu = 0
            objCau.C8_22_Nu = 0
            objCau.C8_23_Nu = 0
            objCau.C8_24_Nu = 0
            objCau.C8_25_Nu = 0
            objCau.C8_26_Nu = 0
            objCau.C8_31_Nu = 0
            objCau.C8_32_Nu = 0
            objCau.C8_33_Nu = 0
            objCau.C8_34_Nu = 0
            objCau.C8_35_Nu = 0
            objCau.C8_36_Nu = 0
            objCau.C8_41_Nu = 0
            objCau.C8_42_Nu = 0
            objCau.C8_43_Nu = 0
            objCau.C8_44_Nu = 0
            objCau.C8_51_Nu = 0
            objCau.C8_52_Nu = 0
            objCau.C8_53_Nu = 0
            objCau.C8_54_Nu = 0
            objCau.C8_61_Nu = 0
            objCau.C8_62_Nu = 0
            objCau.C8_63_Nu = 0
            objCau.C8_71_Nu = 0
            objCau.C8_72_Nu = 0
            objCau.C8_73_Nu = 0
            objCau.C8_74_Nu = 0
            objCau.C8_75_Nu = 0
            objCau.C8_81_Nu = 0
            objCau.C8_82_Nu = 0
            objCau.C8_83_Nu = 0
            objCau.C8_91_Nu = 0
            objCau.C8_92_Nu = 0
            objCau.C8_93_Nu = 0
            objCau.C8_94_Nu = 0
            objCau.C8_95_Nu = 0
            objCau.C8_96_Nu = 0
            objCau.C11_17 = flReg.WriteNumber(nctd_17)
            objCau.C11_21 = flReg.WriteNumber(nctd_21)
            objCau.C11_22 = flReg.WriteNumber(nctd_22)
            objCau.C11_23 = flReg.WriteNumber(nctd_23)
            objCau.C11_24 = flReg.WriteNumber(nctd_24)
            objCau.C11_25 = flReg.WriteNumber(nctd_25)
            objCau.C11_26 = flReg.WriteNumber(nctd_26)
            objCau.C11_31 = flReg.WriteNumber(nctd_31)
            objCau.C11_32 = flReg.WriteNumber(nctd_32)
            objCau.C11_33 = flReg.WriteNumber(nctd_33)
            objCau.C11_34 = flReg.WriteNumber(nctd_34)
            objCau.C11_35 = flReg.WriteNumber(nctd_35)
            objCau.C11_36 = flReg.WriteNumber(nctd_36)
            objCau.C11_41 = flReg.WriteNumber(nctd_41)
            objCau.C11_42 = flReg.WriteNumber(nctd_42)
            objCau.C11_43 = flReg.WriteNumber(nctd_43)
            objCau.C11_44 = flReg.WriteNumber(nctd_44)
            objCau.C11_51 = flReg.WriteNumber(nctd_51)
            objCau.C11_52 = flReg.WriteNumber(nctd_52)
            objCau.C11_53 = flReg.WriteNumber(nctd_53)
            objCau.C11_54 = flReg.WriteNumber(nctd_54)
            objCau.C11_61 = flReg.WriteNumber(nctd_61)
            objCau.C11_62 = flReg.WriteNumber(nctd_62)
            objCau.C11_63 = flReg.WriteNumber(nctd_63)
            objCau.C11_71 = flReg.WriteNumber(nctd_71)
            objCau.C11_72 = flReg.WriteNumber(nctd_72)
            objCau.C11_73 = flReg.WriteNumber(nctd_73)
            objCau.C11_74 = flReg.WriteNumber(nctd_74)
            objCau.C11_75 = flReg.WriteNumber(nctd_75)
            objCau.C11_81 = flReg.WriteNumber(nctd_81)
            objCau.C11_82 = flReg.WriteNumber(nctd_82)
            objCau.C11_83 = flReg.WriteNumber(nctd_83)
            objCau.C11_91 = flReg.WriteNumber(nctd_91)
            objCau.C11_92 = flReg.WriteNumber(nctd_92)
            objCau.C11_93 = flReg.WriteNumber(nctd_93)
            objCau.C11_94 = flReg.WriteNumber(nctd_94)
            objCau.C11_95 = flReg.WriteNumber(nctd_95)
            objCau.C11_96 = flReg.WriteNumber(nctd_96)
            objCau.C11_17_Nu = flReg.WriteNumber(nctd_17_Nu)
            objCau.C11_21_Nu = flReg.WriteNumber(nctd_21_Nu)
            objCau.C11_22_Nu = flReg.WriteNumber(nctd_22_Nu)
            objCau.C11_23_Nu = flReg.WriteNumber(nctd_23_Nu)
            objCau.C11_24_Nu = flReg.WriteNumber(nctd_24_Nu)
            objCau.C11_25_Nu = flReg.WriteNumber(nctd_25_Nu)
            objCau.C11_26_Nu = flReg.WriteNumber(nctd_26_Nu)
            objCau.C11_31_Nu = flReg.WriteNumber(nctd_31_Nu)
            objCau.C11_32_Nu = flReg.WriteNumber(nctd_32_Nu)
            objCau.C11_33_Nu = flReg.WriteNumber(nctd_33_Nu)
            objCau.C11_34_Nu = flReg.WriteNumber(nctd_34_Nu)
            objCau.C11_35_Nu = flReg.WriteNumber(nctd_35_Nu)
            objCau.C11_36_Nu = flReg.WriteNumber(nctd_36_Nu)
            objCau.C11_41_Nu = flReg.WriteNumber(nctd_41_Nu)
            objCau.C11_42_Nu = flReg.WriteNumber(nctd_42_Nu)
            objCau.C11_43_Nu = flReg.WriteNumber(nctd_43_Nu)
            objCau.C11_44_Nu = flReg.WriteNumber(nctd_44_Nu)
            objCau.C11_51_Nu = flReg.WriteNumber(nctd_51_Nu)
            objCau.C11_52_Nu = flReg.WriteNumber(nctd_52_Nu)
            objCau.C11_53_Nu = flReg.WriteNumber(nctd_53_Nu)
            objCau.C11_54_Nu = flReg.WriteNumber(nctd_54_Nu)
            objCau.C11_61_Nu = flReg.WriteNumber(nctd_61_Nu)
            objCau.C11_62_Nu = flReg.WriteNumber(nctd_62_Nu)
            objCau.C11_63_Nu = flReg.WriteNumber(nctd_63_Nu)
            objCau.C11_71_Nu = flReg.WriteNumber(nctd_71_Nu)
            objCau.C11_72_Nu = flReg.WriteNumber(nctd_72_Nu)
            objCau.C11_73_Nu = flReg.WriteNumber(nctd_73_Nu)
            objCau.C11_74_Nu = flReg.WriteNumber(nctd_74_Nu)
            objCau.C11_75_Nu = flReg.WriteNumber(nctd_75_Nu)
            objCau.C11_81_Nu = flReg.WriteNumber(nctd_81_Nu)
            objCau.C11_82_Nu = flReg.WriteNumber(nctd_82_Nu)
            objCau.C11_83_Nu = flReg.WriteNumber(nctd_83_Nu)
            objCau.C11_91_Nu = flReg.WriteNumber(nctd_91_Nu)
            objCau.C11_92_Nu = flReg.WriteNumber(nctd_92_Nu)
            objCau.C11_93_Nu = flReg.WriteNumber(nctd_93_Nu)
            objCau.C11_94_Nu = flReg.WriteNumber(nctd_94_Nu)
            objCau.C11_95_Nu = flReg.WriteNumber(nctd_95_Nu)
            objCau.C11_96_Nu = flReg.WriteNumber(nctd_96_Nu)
            objCau.C10_LaoDong = flReg.WriteNumber(laoDong6Thang)
            objCau.Chia_Khong_Nu = 0
            objCau.Chia_BangCap_Nu = 0
            objCau.Chia_DaoTao_Nu = 0
            objCau.Chia_SoCap_Nu = 0
            objCau.Chia_TrungCap_Nu = 0
            objCau.Chia_CaoDang_Nu = 0
            objCau.Chia_DaiHoc_Nu = 0

            objCau.PortalId = pid
            objCau.CreatedDate = Now
            objCau.CreatedUser = obj.Username

            objCau.PortalId = pid
            objCau.UpdatedDate = Now
            objCau.UpdatedUser = obj.Username
        Else
            objCau = New BC_BusinessInfo
        End If
        objCtl.BC_Business_Update_ByID(pid, objCau)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objCau), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CauLD_Xoa(ID As String) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        objCtl.BC_Business_Delete_ByID(pid, ID)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New BC_BusinessInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CauLD_DanhSach(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        Dim yearID As String = 0
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        If flReg.WriteNumber(flCache.GetCache("BC_KyNhapLieu_Years_" & maDonVi)) > 0 Then
            yearID = flCache.GetCache("BC_KyNhapLieu_Years_" & maDonVi)
        Else
            yearID = Now.Year
        End If
        arr = objCtl.BC_Business_List_Search(pid, tuKhoa, soTrangHienTai, soBanGhiTrenTrang, "", "", "", busID, "", -1, yearID, 0, 0)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region
#Region "Common"

    Private Function DayText(ByVal num As Integer) As String
        Select Case num
            Case 1
                Return "T2"
            Case 2
                Return "T3"
            Case 3
                Return "T4"
            Case 4
                Return "T5"
            Case 5
                Return "T6"
            Case 6
                Return "T7"
            Case Else
                Return "CN"
        End Select
    End Function
    Private Function getNull(val As String) As String
        If val = "null" Or val = "undefined" Then
            Return ""
        Else
            Return val.Trim()
        End If
    End Function
    Private Function CacheList(strCache As String) As ArrayList
        CacheList = New ArrayList
        Try
            CacheList = flCache.GetCache(strCache)
            If CacheList.Count >= 0 Then
                CacheList = CType(flCache.GetCache(strCache), ArrayList)
            End If
        Catch ex As Exception
            Return CacheList
        End Try
    End Function

    Private Sub HostUser()
        'Authentication = New AuthHeader
        'Authentication.userId = "C1EDC13A-0B0A-401C-B0B1-001CFBF40D28"
    End Sub

    Private Function GetUser(userID As String) As UserInfo
        Try
            'userID = "C1EDC13A-0B0A-401C-B0B1-001CFBF40D28"
            strCache = "APP_GetUserByPasswordResetToken" & userID
            obj = flCache.GetCache(strCache)
            If obj Is Nothing Then
                obj = UserController.GetUserByPasswordResetToken(pid, userID)
                flCache.SetCache(strCache, obj)
            End If
            Return obj
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function ConvertListAPI(body As ArrayList) As Response
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            If obj Is Nothing Then
                data.data = "Failed to connect to api, check your permissions again!"
                data.message = "Error"
                data.status = ServiceStatus.FAILED
                Return data
            End If

            If body.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = body
            'data.status = ServiceStatus.SUCCESS
            data.message = "Success"

        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
            LogException(ex)
        End Try
        Return data

    End Function
    Private Function ConvertObjectAPI(body As Object, Optional ByVal mes As String = "Success") As Response
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            If obj Is Nothing Then
                data.data = "Failed to connect to api, check your permissions again!"
                data.message = "Error"
                data.status = ServiceStatus.FAILED
                Return data
            End If

            If body IsNot Nothing Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = body
            'data.status = ServiceStatus.SUCCESS
            data.message = mes

        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
            LogException(ex)
        End Try
        Return data

    End Function
    Private Function SettingAPI() As JsonSerializerSettings
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Return settings
    End Function
    Public Class UserApp
        Private _userID As String
        Public Property UserID() As String
            Get
                Return _userID
            End Get
            Set(ByVal value As String)
                _userID = value
            End Set
        End Property
        Private _userName As String
        Public Property UserName() As String
            Get
                Return _userName
            End Get
            Set(ByVal value As String)
                _userName = value
            End Set
        End Property
        Private _Message As String
        Public Property Message() As String
            Get
                Return _Message
            End Get
            Set(ByVal value As String)
                _Message = value
            End Set
        End Property
        Private _Role As String
        Public Property Role() As String
            Get
                Return _Role
            End Get
            Set(ByVal value As String)
                _Role = value
            End Set
        End Property
    End Class

    Public Class DanhMucChung
        Public Property Id As Integer
        Public Property Name As String
    End Class
#End Region
End Class