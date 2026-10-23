 <%@ WebService Language="VB" Class="common" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports DotNetNuke.CHATBOT
Imports DotNetNuke.INSU
Imports DotNetNuke.CMS
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
Public Class common
    Inherits System.Web.Services.WebService
    Public Authentication As AuthHeader
    Dim workCtl As New WorkController
    Dim cmsCtl As New CmsController
    Dim insuCtl As New InsuController
    Dim pid As Integer = 0
    Dim arr As New ArrayList
    Dim strCache As String = ""
    Dim obj As New UserInfo
    Dim ubj As New EPORTAL.CMSUserPortalInfo
    Dim userControler As New UserController
    Dim maDonVi As Integer = flReg.WebConfig("TinhTP")
#Region "NEWS"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsSearch(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = cmsCtl.CMS_News_Search_HomeMobile(pid, pid, -1, soTrangHienTai, soBanGhiTrenTrang, tuKhoa, NewsStatus.DaXuatBan)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsSend(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = cmsCtl.CMS_News_Search_HomeMobile(pid, pid, -1, soTrangHienTai, soBanGhiTrenTrang, tuKhoa, NewsStatus.ChoXuatBan)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsUpdateIsMobile(id As Integer, isVisible As Int16) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objNews = cmsCtl.CMS_News_Get(pid, id)
        If obj IsNot Nothing Then
            If objNews IsNot Nothing Then
                cmsCtl.CMS_News_Update_IsMobile(pid, id, isVisible)
            End If
        Else
            objNews = New CMS_NewsInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objNews), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsUpdateApprove(id As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objNews = cmsCtl.CMS_News_Get(pid, id)
        If obj IsNot Nothing Then
            If objNews IsNot Nothing Then
                cmsCtl.CMS_News_Update_Status(pid, id, NewsStatus.DaXuatBan, obj.Username, DateTime.Now)
            End If
        Else
            objNews = New CMS_NewsInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objNews), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function EventSearch(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = cmsCtl.CMS_News_Search_HomeMobile(pid, pid, 3705, soTrangHienTai, soBanGhiTrenTrang, tuKhoa, NewsStatus.DaXuatBan)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SlideSearch(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = cmsCtl.DM_Slider_List_Search(pid, "", soTrangHienTai, soBanGhiTrenTrang)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SlideUpdateIsMobile(id As Integer, isVisible As Int16) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objSlide = cmsCtl.DM_Slider_Get(pid, id)
        If obj IsNot Nothing Then
            If objSlide IsNot Nothing Then
                If isVisible = 1 Then
                    objSlide.HoatDong = True
                End If
                If isVisible = 0 Then
                    objSlide.HoatDong = False
                End If
                cmsCtl.DM_Slider_Update(pid, objSlide)
            End If
        Else
            objSlide = New DM_SliderInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objSlide), SettingAPI())
    End Function
#End Region
#Region "NLD"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyTuVan_ThemMoi(hoTen As String, ngaySinh As String, gioiTinh As String, soCMND As String, noiCap As String, ngayCap As String, soBHXH As String, email As String, soDienThoai As String, danToc As String, tonGiao As String, DVTV As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_ProSubsiInfo
        If obj IsNot Nothing Then
            objTV = New EXE_ProSubsiInfo
            objTV.HoTen = hoTen.ToUpper.Trim()
            objTV.NgaySinh = flReg.WriteDate(ngaySinh, False)
            objTV.GioiTinh = flReg.WriteNumber(gioiTinh)
            objTV.SoCMND = soCMND
            objTV.NgayCap = flReg.WriteDate(ngayCap, False)
            objTV.NoiCap = noiCap
            objTV.SoBHXH = soBHXH
            objTV.Email = email
            objTV.DienThoai = soDienThoai
            objTV.DanToc = danToc
            objTV.TonGiao = tonGiao
            objTV.SoTaiKhoan = ""
            objTV.NganHang = ""
            objTV.ChiNhanhNH = ""
            objTV.TT_TinhTP = ""
            objTV.TT_QuanHuyen = ""
            objTV.TT_XaPhuong = ""
            objTV.TT_DuongPho = ""
            objTV.CO_TinhTP = ""
            objTV.CO_QuanHuyen = ""
            objTV.CO_XaPhuong = ""
            objTV.CO_DuongPho = ""
            objTV.NganhDT = ""
            objTV.TrinhDo = ""
            objTV.NgayNghiViec = flReg.DateNull
            objTV.ThangDong = 0
            objTV.LoaiHD = ""
            objTV.CongTy = ""
            objTV.SoDKKD = ""
            objTV.CT_TinhTP = ""
            objTV.CT_QuanHuyen = ""
            objTV.CT_XaPhuong = ""
            objTV.CT_DuongPho = ""
            objTV.NoiNhanTCTN = ""
            objTV.NoiDKKCB = ""
            objTV.NguyenNhanNV = ""
            objTV.NgheTruocNghi = ""
            objTV.NganhTruocNghi = ""
            objTV.PortalID = maDonVi
            objTV.TrangThai = TrangThaiHS.DangSoan
            objTV.NgayNopHS = Now
            objTV.NgayTiepNhan = flReg.DateNull
            objTV.NguoiTiepNhan = ""
            objTV.CreatedDate = Now
            objTV.CreatedUser = obj.Username
            objTV.IsType = flReg.WriteNumber(DVTV)
            objTV.ProSubsi_ID = flReg.GenKey()
            objTV.NoCode = INSU.flCheck.NoCode(maDonVi, ProType.TCTN)
            objTV.UpdatedDate = flReg.DateNull
            objTV.UpdatedUser = ""
            insuCtl.EXE_ProSubsi_Add(maDonVi, objTV)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyTuVan_ChiTiet(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_ProSubsiInfo
        objTV = insuCtl.EXE_ProSubsi_Get(pid, id)
        If objTV Is Nothing Then
            objTV = New EXE_ProSubsiInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyTuVan_NopHoSo(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_ProSubsiInfo
        objTV = insuCtl.EXE_ProSubsi_Get(pid, id)
        If objTV IsNot Nothing Then
            insuCtl.EXE_ProSubsi_Update_TrangThai(maDonVi, id, TrangThaiHS.DaNop, Now, obj.Username, "")
        Else
            objTV = New EXE_ProSubsiInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyTuVan_CapNhat(id As String, hoTen As String, ngaySinh As String, gioiTinh As String, soCMND As String, noiCap As String, ngayCap As String, soBHXH As String, email As String, soDienThoai As String, danToc As String, tonGiao As String, DVTV As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_ProSubsiInfo
        If obj IsNot Nothing Then
            objTV = New EXE_ProSubsiInfo
            objTV.ProSubsi_ID = id
            objTV.HoTen = hoTen.ToUpper.Trim()
            objTV.NgaySinh = flReg.WriteDate(ngaySinh, False)
            objTV.GioiTinh = flReg.WriteNumber(gioiTinh)
            objTV.SoCMND = soCMND
            objTV.NgayCap = flReg.WriteDate(ngayCap, False)
            objTV.NoiCap = noiCap
            objTV.SoBHXH = soBHXH
            objTV.Email = email
            objTV.DienThoai = soDienThoai
            objTV.DanToc = danToc
            objTV.TonGiao = tonGiao
            objTV.SoTaiKhoan = ""
            objTV.NganHang = ""
            objTV.ChiNhanhNH = ""
            objTV.TT_TinhTP = ""
            objTV.TT_QuanHuyen = ""
            objTV.TT_XaPhuong = ""
            objTV.TT_DuongPho = ""
            objTV.CO_TinhTP = ""
            objTV.CO_QuanHuyen = ""
            objTV.CO_XaPhuong = ""
            objTV.CO_DuongPho = ""
            objTV.NganhDT = ""
            objTV.TrinhDo = ""
            objTV.NgayNghiViec = flReg.DateNull
            objTV.ThangDong = 0
            objTV.LoaiHD = ""
            objTV.CongTy = ""
            objTV.SoDKKD = ""
            objTV.CT_TinhTP = ""
            objTV.CT_QuanHuyen = ""
            objTV.CT_XaPhuong = ""
            objTV.CT_DuongPho = ""
            objTV.NoiNhanTCTN = ""
            objTV.NoiDKKCB = ""
            objTV.NguyenNhanNV = ""
            objTV.NgheTruocNghi = ""
            objTV.NganhTruocNghi = ""
            objTV.PortalID = maDonVi
            objTV.TrangThai = TrangThaiHS.DangSoan
            objTV.NgayNopHS = Now
            objTV.NgayTiepNhan = flReg.DateNull
            objTV.NguoiTiepNhan = ""
            objTV.CreatedDate = Now
            objTV.CreatedUser = obj.Username
            objTV.IsType = flReg.WriteNumber(DVTV)
            objTV.ProSubsi_ID = flReg.GenKey()
            objTV.NoCode = INSU.flCheck.NoCode(maDonVi, ProType.TCTN)
            objTV.UpdatedDate = flReg.DateNull
            objTV.UpdatedUser = ""
            insuCtl.EXE_ProSubsi_Update(maDonVi, objTV)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachDangKyTuVan(tuKhoa As String, trangThai As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = insuCtl.EXE_ProSubsi_List_Search(pid, tuKhoa, 0, soTrangHienTai, soBanGhiTrenTrang, maDonVi, trangThai, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HuyDangKyTuVan(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            insuCtl.EXE_ProSubsi_Delete(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New EXE_ProSubsiInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyGTVL_ThemMoi(hoTen As String, ngaySinh As String, gioiTinh As String, soCMND As String, noiCap As String, ngayCap As String, soBHXH As String, email As String, soDienThoai As String, danToc As String, tonGiao As String, viTri As String, mucLuong As String, congViec As String, tinhTp_NLV As String, quanHuyen_NLV As String, loaiHinh As String, dieuKienLamViec As String, khac As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_AdvisoryInfo
        If obj IsNot Nothing Then
            objTV = New EXE_AdvisoryInfo
            objTV.HoTen = hoTen.ToUpper.Trim()
            objTV.NgaySinh = flReg.WriteDate(ngaySinh, False)
            objTV.GioiTinh = flReg.WriteNumber(gioiTinh)
            objTV.SoCMND = soCMND
            objTV.NgayCap = flReg.WriteDate(ngayCap, False)
            objTV.NoiCap = noiCap
            objTV.SoBHXH = soBHXH
            objTV.Email = email
            objTV.DienThoai = soDienThoai
            objTV.DanToc = danToc
            objTV.TonGiao = tonGiao
            objTV.SoTaiKhoan = ""
            objTV.NganHang = ""
            objTV.ChiNhanhNH = ""
            objTV.TT_TinhTP = ""
            objTV.TT_QuanHuyen = ""
            objTV.TT_XaPhuong = ""
            objTV.TT_DuongPho = ""
            objTV.CO_TinhTP = ""
            objTV.CO_QuanHuyen = ""
            objTV.CO_XaPhuong = ""
            objTV.CO_DuongPho = ""
            objTV.PortalID = maDonVi
            objTV.TrangThai = TrangThaiHS.DangSoan
            objTV.NgayNopHS = Now
            objTV.NgayTiepNhan = flReg.DateNull
            objTV.NguoiTiepNhan = ""
            objTV.CreatedDate = Now
            objTV.CreatedUser = obj.Username
            objTV.NoCode = INSU.flCheck.NoCode(maDonVi, ProType.TCTN)
            objTV.UpdatedDate = flReg.DateNull
            objTV.UpdatedUser = ""
            insuCtl.EXE_Advisory_Add(maDonVi, objTV)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyGTVL_ChiTiet(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_AdvisoryInfo
        objTV = insuCtl.EXE_Advisory_Get(pid, id)
        If objTV Is Nothing Then
            objTV = New EXE_AdvisoryInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyGTVL_NopHoSo(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_AdvisoryInfo
        objTV = insuCtl.EXE_Advisory_Get(pid, id)
        If objTV IsNot Nothing Then
            insuCtl.EXE_Advisory_Update_TrangThai(maDonVi, id, TrangThaiHS.DaNop, Now, obj.Username, "")
        Else
            objTV = New EXE_AdvisoryInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyGTVL_CapNhat(id As String, hoTen As String, ngaySinh As String, gioiTinh As String, soCMND As String, noiCap As String, ngayCap As String, soBHXH As String, email As String, soDienThoai As String, danToc As String, tonGiao As String, viTri As String, mucLuong As String, congViec As String, tinhTp_NLV As String, quanHuyen_NLV As String, loaiHinh As String, dieuKienLamViec As String, khac As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_AdvisoryInfo
        If obj IsNot Nothing Then
            objTV = New EXE_AdvisoryInfo
            objTV.Advisory_ID = id
            objTV.HoTen = hoTen.ToUpper.Trim()
            objTV.NgaySinh = flReg.WriteDate(ngaySinh, False)
            objTV.GioiTinh = flReg.WriteNumber(gioiTinh)
            objTV.SoCMND = soCMND
            objTV.NgayCap = flReg.WriteDate(ngayCap, False)
            objTV.NoiCap = noiCap
            objTV.SoBHXH = soBHXH
            objTV.Email = email
            objTV.DienThoai = soDienThoai
            objTV.DanToc = danToc
            objTV.TonGiao = tonGiao
            objTV.SoTaiKhoan = ""
            objTV.NganHang = ""
            objTV.ChiNhanhNH = ""
            objTV.TT_TinhTP = ""
            objTV.TT_QuanHuyen = ""
            objTV.TT_XaPhuong = ""
            objTV.TT_DuongPho = ""
            objTV.CO_TinhTP = ""
            objTV.CO_QuanHuyen = ""
            objTV.CO_XaPhuong = ""
            objTV.CO_DuongPho = ""
            objTV.PortalID = maDonVi
            objTV.TrangThai = TrangThaiHS.DangSoan
            objTV.NgayNopHS = Now
            objTV.NgayTiepNhan = flReg.DateNull
            objTV.NguoiTiepNhan = ""
            objTV.CreatedDate = Now
            objTV.CreatedUser = obj.Username
            objTV.NoCode = INSU.flCheck.NoCode(maDonVi, ProType.TCTN)
            objTV.UpdatedDate = flReg.DateNull
            objTV.UpdatedUser = ""
            insuCtl.EXE_Advisory_Update(maDonVi, objTV)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachDangKyGTVL(tuKhoa As String, trangThai As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = insuCtl.EXE_Advisory_List_Search(pid, tuKhoa, 0, soTrangHienTai, soBanGhiTrenTrang, maDonVi, trangThai, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HuyDangKyGTVL(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            insuCtl.EXE_ProSubsi_Delete(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New EXE_ProSubsiInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyLaySo(hoTen As String, soDienThoai As String, veTinh As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim kqDangKy = SaveData(hoTen, soDienThoai, veTinh, 1)
        If kqDangKy = 1 Then
            Return JsonConvert.SerializeObject(ConvertObjectAPI(objLs, "Lấy số thành công"), SettingAPI())
        Else
            Return JsonConvert.SerializeObject(ConvertObjectAPI(objLs, "Lấy số thất bại, vui lòng thử lại hoặc liên hệ quản trị hệ thống"), SettingAPI())
        End If
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKyLaySo_ChiTiet(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New EXE_ProSubsiInfo
        objTV = insuCtl.EXE_ProSubsi_Get(pid, id)
        If objTV Is Nothing Then
            objTV = New EXE_ProSubsiInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
    Dim objLs = New EXE_NumberAutoInfo
    Private Function SaveData(hoten As String, dienThoai As String, veTinh As String, dichVu As Integer) As Integer
        Try
            SaveData = 0
            objLs = New EXE_NumberAutoInfo
            objLs.NumberAuto_ID = flReg.GenKey()
            objLs.NoCode = INSU.flCheck.NoCode(flReg.WebConfig("TinhTP"), ProType.DKXH)
            objLs.HoTen = hoten
            objLs.DienThoai = dienThoai
            objLs.NgayDangKy = Now
            objLs.DichVu = dichVu
            objLs.PortalID = flReg.WebConfig("TinhTP")
            objLs.VeTinhID = veTinh
            objLs.CreatedDate = Now
            objLs.CreatedUser = obj.Username
            insuCtl.EXE_NumberAuto_Add(flReg.WebConfig("TinhTP"), objLs)
            SaveData = 1
        Catch ex As Exception
            SaveData = 0
        End Try
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachDangKyLaySo(tuKhoa As String, veTinh As String, ngayDangKy As String, dichVu As String, soTrangHienTai As String, soBanGhiTrenTrang As String) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = insuCtl.EXE_NumberAuto_List_Search(flReg.WebConfig("TinhTP"), veTinh, flReg.WriteDate(ngayDangKy, False), dichVu, tuKhoa, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HuyDangKyLaySo(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            insuCtl.EXE_ProSubsi_Delete(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New EXE_ProSubsiInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserSearch(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, doanhNghiep As String, mucLuong As String, kinhNghiem As String, tinhTp As String, quanHuyen As String) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_JobUser_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, doanhNghiep, mucLuong, kinhNghiem, tinhTp, quanHuyen)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserAdd(tieuDe As String, ngayDangTu As String, ngayDangDen As String, nganhNghe As String, tinhTp As String, quanHuyen As String, chucVuHienTai As String, chucVuMongMuon As String, soNamKinhNghiem As String, trinhDo As String, mucLuong As String, nhuCau As String, trinhDoHocVan As String, kinhNghiemLV As String, mucTieu As String, kyNang As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objJob = New CMS_JobUserInfo
        If obj IsNot Nothing Then
            objJob.Title = tieuDe
            objJob.Career_ID = nganhNghe
            objJob.CurrentLevel = chucVuHienTai
            objJob.LevelDesired = chucVuMongMuon
            objJob.TinhTP = tinhTp
            objJob.QuanHuyen = quanHuyen

            objJob.Experience_ID = soNamKinhNghiem
            objJob.Level_ID = trinhDo
            objJob.Salary_ID = mucLuong
            objJob.Needs_ID = nhuCau
            objJob.Education = trinhDoHocVan
            objJob.CareerGoals = mucTieu
            objJob.WorkExperience = kinhNghiemLV
            objJob.SkillsForte = kyNang
            objJob.UserAdmin = obj.Username
            objJob.StartDate = flReg.WriteDate(ngayDangTu, False)
            objJob.EndDate = flReg.WriteDate(ngayDangDen, False)
            objJob.IsDelete = False
            objJob.DeletedUser = ""
            objJob.DeletedDate = flReg.DateNull
            objJob.IsApproval = False
            objJob.ApprovalUser = ""
            objJob.ApprovalDate = Now
            objJob.PortalID = pid
            objJob.JobUser_ID = flReg.GenKey()
            objJob.CreatedDate = Now
            objJob.CreatedUser = obj.Username
            objJob.UpdatedDate = flReg.DateNull
            objJob.UpdatedUser = ""
            workCtl.CMS_JobUser_Add(pid, objJob)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objJob), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserReferUpdate(jobUserID As String, id As Integer, hoTen As String, chucVu As String, noiCongTac As String, soDienThoai As String, email As String, moiQuanHe As String) As String
        GetUser(Authentication.userId)
        Dim objData1 = New CMS_JobUserReferInfo
        objData1.ID = id
        objData1.JobUserID = jobUserID
        objData1.HoTen = hoTen
        objData1.ChucVu = chucVu
        objData1.NoiCongTac = noiCongTac
        objData1.SoDienThoai = soDienThoai
        objData1.Email = email
        objData1.MoiQuanHe = moiQuanHe
        workCtl.CMS_JobUserRefer_Update(pid, objData1)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objData1), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserReferAdd(jobUserID As String, hoTen As String, chucVu As String, noiCongTac As String, soDienThoai As String, email As String, moiQuanHe As String) As String
        GetUser(Authentication.userId)
        Dim objData1 = New CMS_JobUserReferInfo
        objData1.ID = 0
        objData1.JobUserID = jobUserID
        objData1.HoTen = hoTen
        objData1.ChucVu = chucVu
        objData1.NoiCongTac = noiCongTac
        objData1.SoDienThoai = soDienThoai
        objData1.Email = email
        objData1.MoiQuanHe = moiQuanHe
        workCtl.CMS_JobUserRefer_Add(pid, objData1)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objData1), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserReferDelete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_JobUserRefer_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_JobUserReferInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserReferList(jobUserID As String) As String
        GetUser(Authentication.userId)
        Return JsonConvert.SerializeObject(ConvertListAPI(workCtl.CMS_JobUserRefer_List_ByJobUserID(pid, jobUserID)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserListByUserName(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        arr = workCtl.CMS_JobUser_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, "", "", "", "0", "0")
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserHistoryList(jobUserID As String) As String
        GetUser(Authentication.userId)
        Return JsonConvert.SerializeObject(ConvertListAPI(workCtl.CMS_JobHistory_List_ByJobUserID(pid, jobUserID)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkViewList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, doanhNghiep As String, mucLuong As String, kinhNghiem As String, tinhTp As String, quanHuyen As String) As String
        GetUser(Authentication.userId)
        arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, JobView.NLD_DaXem, "", "", "0", "", "", "")
        Dim objw As CMS_WorkInfo
        For Each cr As CMS_JobViewInfo In arr
            objw = workCtl.CMS_Work_Get(pid, cr.IdKey)
            If objw IsNot Nothing Then
                cr.Title = objw.Title
                cr.ID = objw.ID
            End If
            cr.NgayThucHien = flReg.ReadDate(cr.CreateDate, False)
            cr.TenDN = WORK.flCheck.Business_Name("", pid, cr.IdName, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkSaveList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, JobView.NguoiTimViecLuu, "", "", "0", "", "", "")
        Dim objw As CMS_WorkInfo
        For Each cr As CMS_JobViewInfo In arr
            objw = workCtl.CMS_Work_Get(pid, cr.IdKey)
            If objw IsNot Nothing Then
                cr.Title = objw.Title
                cr.ID = objw.ID
            End If
            cr.NgayThucHien = flReg.ReadDate(cr.CreateDate, False)
            cr.TenDN = WORK.flCheck.Business_Name("", pid, cr.IdName, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkSendList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        arr = workCtl.CMS_Recruitment_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, "", "", "", "0", "", "", "", -1, "")
        Dim objw As CMS_WorkInfo
        For Each cr As WORK.CMS_RecruitmentInfo In arr
            objw = workCtl.CMS_Work_Get(pid, cr.Work_ID)
            If objw IsNot Nothing Then
                cr.W_Title = objw.Title
                cr.ID = objw.ID
            End If
            cr.TenDN = WORK.flCheck.Business_Name("", pid, cr.Business_ID, False)
            cr.NgayNopHS = flReg.ReadDate(cr.CreateDate, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserSend(jobUserID As String, workID As String) As String
        GetUser(Authentication.userId)
        Dim reInfo = New WORK.CMS_RecruitmentInfo
        reInfo.Recruitment_ID = flReg.GenKey()
        reInfo.JobUser_ID = jobUserID
        reInfo.Work_ID = workID
        reInfo.IsView = 0
        reInfo.IsContact = 0
        reInfo.IsCancel = 0
        reInfo.IsElect = 0
        reInfo.IsInterview = 0
        reInfo.IsTest = 0
        reInfo.CreateDate = Now
        reInfo.UserName = obj.Username
        reInfo.UpdatedUser = obj.Username
        reInfo.UpdatedDate = flReg.DateNull
        workCtl.CMS_Recruitment_Add(pid, reInfo)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserUpdate(jobUserID As String, tieuDe As String, ngayDangTu As String, ngayDangDen As String, nganhNghe As String, tinhTp As String, quanHuyen As String, chucVuHienTai As String, chucVuMongMuon As String, soNamKinhNghiem As String, trinhDo As String, mucLuong As String, nhuCau As String, trinhDoHocVan As String, kinhNghiemLV As String, mucTieu As String, kyNang As String) As String
        GetUser(Authentication.userId)
        Dim objJob = New CMS_JobUserInfo
        If obj IsNot Nothing Then
            objJob.Title = tieuDe
            objJob.Career_ID = nganhNghe
            objJob.CurrentLevel = chucVuHienTai
            objJob.LevelDesired = chucVuMongMuon
            objJob.TinhTP = tinhTp
            objJob.QuanHuyen = quanHuyen

            objJob.Experience_ID = soNamKinhNghiem
            objJob.Level_ID = trinhDo
            objJob.Salary_ID = mucLuong
            objJob.Needs_ID = nhuCau
            objJob.Education = trinhDoHocVan
            objJob.CareerGoals = mucTieu
            objJob.WorkExperience = kinhNghiemLV
            objJob.SkillsForte = kyNang
            objJob.UserAdmin = obj.Username
            objJob.StartDate = flReg.WriteDate(ngayDangTu, False)
            objJob.EndDate = flReg.WriteDate(ngayDangDen, False)
            objJob.IsDelete = False
            objJob.DeletedUser = ""
            objJob.DeletedDate = flReg.DateNull
            objJob.IsApproval = False
            objJob.ApprovalUser = ""
            objJob.ApprovalDate = Now
            objJob.PortalID = pid
            objJob.JobUser_ID = jobUserID
            objJob.CreatedDate = Now
            objJob.CreatedUser = obj.Username
            objJob.UpdatedDate = Now
            objJob.UpdatedUser = obj.Username
            workCtl.CMS_JobUser_Update(pid, objJob)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region
#Region "DN"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkAdd(tieuDe As String, mucLuong As String, soLuong As Integer, kinhNghiem As String, doTuoi As String, chucVu As String, gioiTinh As String, trinhdoCM As String, tinhTP As String, tinhChatCV As String, viTriTuyenDung As String, nganhNghe As String, thoiGianLV As String, mota As String, yeuCauCV As String, quyenLoi As String, yeuCauHoSo As String, hanNopHoSo As String, hinhThucNop As String, dangTuNgay As String, dangDenNgay As String, tenNguoiLH As String, diaChiNguoiLH As String, dienThoaiNguoiLH As String, emailNguoiLH As String, ghiChu As String, tinNoiBat As Int16, dauThongTinDN As Int16, dangGap As Int16) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objW = New CMS_WorkInfo
        If String.IsNullOrEmpty(busID) = False Then
            objW.Title = tieuDe
            objW.Business_ID = busID
            objW.Salary_ID = mucLuong
            objW.Quantity = flReg.WriteNumber(soLuong)
            objW.Experience_ID = kinhNghiem
            objW.Gender = flReg.WriteNumber(gioiTinh)
            objW.Level_ID = trinhdoCM

            objW.TinhTP = tinhTP
            objW.TypeOf_ID = tinhChatCV
            objW.JobPlace = viTriTuyenDung
            objW.Career_ID = nganhNghe
            objW.Description = mota
            objW.Requirement = yeuCauCV
            objW.Benefit = quyenLoi
            objW.RequirementsProfile = yeuCauHoSo
            objW.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objW.SubmissionSend = hinhThucNop
            objW.StartDate = flReg.WriteDate(dangTuNgay, False)
            objW.EndDate = flReg.WriteDate(dangDenNgay, False)
            objW.ContactUser = tenNguoiLH
            objW.ContactAddress = diaChiNguoiLH
            objW.ContactMobile = dienThoaiNguoiLH
            objW.ContactEmail = emailNguoiLH
            objW.ContactDes = ghiChu
            objW.IsHot = flReg.ToBoolean(tinNoiBat)
            objW.IsFast = flReg.ToBoolean(dauThongTinDN)
            objW.IsUrgent = flReg.ToBoolean(dangGap)
            objW.LevelDesired_ID = chucVu
            objW.Ages = doTuoi
            objW.WorkTime = thoiGianLV
            objW.IsDelete = False
            objW.DeletedUser = ""
            objW.DeletedDate = flReg.DateNull
            objW.IsApproval = False
            objW.ApprovalUser = ""
            objW.ApprovalDate = flReg.DateNull
            objW.PortalID = pid
            objW.IsFlag = WorkFlag.WebFrom
            objW.Work_ID = flReg.GenKey()
            objW.CreatedDate = Now
            objW.CreatedUser = obj.Username
            objW.UpdatedDate = flReg.DateNull
            workCtl.CMS_Work_Add(pid, objW)
        Else
            objW = New CMS_WorkInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkUpdate(work_ID As String, tieuDe As String, mucLuong As String, soLuong As Integer, kinhNghiem As String, doTuoi As String, chucVu As String, gioiTinh As String, trinhdoCM As String, tinhTP As String, tinhChatCV As String, viTriTuyenDung As String, nganhNghe As String, thoiGianLV As String, mota As String, yeuCauCV As String, quyenLoi As String, yeuCauHoSo As String, hanNopHoSo As String, hinhThucNop As String, dangTuNgay As String, dangDenNgay As String, tenNguoiLH As String, diaChiNguoiLH As String, dienThoaiNguoiLH As String, emailNguoiLH As String, ghiChu As String, tinNoiBat As Int16, dauThongTinDN As Int16, dangGap As Int16) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objW = New CMS_WorkInfo
        If String.IsNullOrEmpty(busID) = False Then
            objW.Work_ID = work_ID
            objW.Title = tieuDe
            objW.Business_ID = busID
            objW.Salary_ID = mucLuong
            objW.Quantity = flReg.WriteNumber(soLuong)
            objW.Experience_ID = kinhNghiem
            objW.Gender = flReg.WriteNumber(gioiTinh)
            objW.Level_ID = trinhdoCM

            objW.TinhTP = tinhTP
            objW.TypeOf_ID = tinhChatCV
            objW.JobPlace = viTriTuyenDung
            objW.Career_ID = nganhNghe
            objW.Description = mota
            objW.Requirement = yeuCauCV
            objW.Benefit = quyenLoi
            objW.RequirementsProfile = yeuCauHoSo
            objW.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objW.SubmissionSend = hinhThucNop
            objW.StartDate = flReg.WriteDate(dangTuNgay, False)
            objW.EndDate = flReg.WriteDate(dangDenNgay, False)
            objW.ContactUser = tenNguoiLH
            objW.ContactAddress = diaChiNguoiLH
            objW.ContactMobile = dienThoaiNguoiLH
            objW.ContactEmail = emailNguoiLH
            objW.ContactDes = ghiChu
            objW.IsHot = flReg.ToBoolean(tinNoiBat)
            objW.IsFast = flReg.ToBoolean(dauThongTinDN)
            objW.IsUrgent = flReg.ToBoolean(dangGap)
            objW.LevelDesired_ID = chucVu
            objW.Ages = doTuoi
            objW.WorkTime = thoiGianLV
            objW.IsDelete = False
            objW.DeletedUser = ""
            objW.DeletedDate = flReg.DateNull
            objW.IsApproval = False
            objW.ApprovalUser = ""
            objW.ApprovalDate = flReg.DateNull
            objW.PortalID = pid
            objW.IsFlag = WorkFlag.WebFrom
            objW.Work_ID = flReg.GenKey()
            objW.CreatedDate = flReg.DateNull
            objW.CreatedUser = ""
            objW.UpdatedDate = Now
            objW.UpdatedUser = obj.Username
            workCtl.CMS_Work_Update(pid, objW)
        Else
            objW = New CMS_WorkInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkDelete(workId As String) As String
        GetUser(Authentication.userId)
        workCtl.CMS_Work_Delete(pid, workId)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_WorkInfo()), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkSearchByUserName(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, mucLuong As String, kinhNghiem As String, tinhTp As String, quanHuyen As String) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        arr = workCtl.CMS_Work_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, busID, mucLuong, kinhNghiem, tinhTp, quanHuyen, -1)
        For Each cr As CMS_WorkInfo In arr
            cr.TenTinhTP = flDic.Regional_Name(pid, cr.TinhTP)
            cr.HanNopHoSo = flReg.ReadDate(cr.EndDate, False)
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ProfileSave(jobUserID As String, title As String) As String
        GetUser(Authentication.userId)
        Dim jInfo As New CMS_JobViewInfo
        jInfo.JobView_ID = flReg.GenKey()
        jInfo.IdKey = jobUserID
        jInfo.IdName = title
        jInfo.UserName = WORK.flCheck.Business_ID(pid, obj.Username)
        jInfo.CreateDate = Now
        jInfo.IsFlag = JobView.DoanhNghiepLuu
        workCtl.CMS_JobView_Add(pid, jInfo)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(jInfo), SettingAPI())

    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ProfileViewList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "true", JobView.DN_DaXem, busID, "", "0", "", "", "")
        For Each cr As CMS_JobViewInfo In arr
            cr.Title = WORK.flCheck.JobUser_Name("", pid, cr.IdKey, False)
            cr.NgayThucHien = flReg.ReadDate(cr.CreateDate, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ProfileSaveList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "true", JobView.DoanhNghiepLuu, busID, "", "0", "", "", "")
        For Each cr As CMS_JobViewInfo In arr
            cr.Title = WORK.flCheck.JobUser_Name("", pid, cr.IdKey, False)
            cr.NgayThucHien = flReg.ReadDate(cr.CreateDate, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ProfileBlackList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "true", JobView.DN_DanhSachDen, busID, "", "0", "", "", "")
        For Each cr As CMS_JobViewInfo In arr
            cr.Title = WORK.flCheck.JobUser_Name("", pid, cr.IdKey, False)
            cr.NgayThucHien = flReg.ReadDate(cr.CreateDate, False)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ProfileSendList(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        arr = New ArrayList
        Dim wInfo As CMS_WorkInfo
        Dim jInfo As CMS_JobUserInfo
        If String.IsNullOrEmpty(busID) = False Then

            Dim totalCV As Integer = 0
            Dim i = 1 : Dim j As Integer : Dim ctotal = 0
            For Each Cr As WORK.CMS_RecruitmentInfo In workCtl.CMS_Recruitment_List_Send(pid, tuKhoa, flReg.RemoveScript(tuKhoa), kieuSapXep, soTrangHienTai,
                                                       soBanGhiTrenTrang, "", "-1", busID, "",
                                                        "", "", "", "", "-1", "")
                wInfo = workCtl.CMS_Work_Get(pid, Cr.Work_ID)
                If wInfo IsNot Nothing Then
                    Cr.wID = wInfo.ID
                End If
                Cr.STT = i
                arr.Add(Cr)
                j = 1
                For Each Cj As WORK.CMS_RecruitmentInfo In workCtl.CMS_Recruitment_List_Send(pid, tuKhoa, tuKhoa, kieuSapXep, soTrangHienTai,
                                                        soBanGhiTrenTrang, "", "-1", busID, "",
                                                        "", "", "", "", "-1", Cr.Work_ID)
                    jInfo = workCtl.CMS_JobUser_Get(pid, Cr.JobUser_ID)
                    If jInfo IsNot Nothing Then
                        Cr.jID = jInfo.ID
                    End If

                    Cj.STT = i & "." & j
                    arr.Add(Cj)

                    j += 1
                    ctotal += 1
                    totalCV += 1
                Next
                Cr.Ctotal = ctotal
                ctotal = 0
                i += 1

            Next
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())

    End Function
    Private Sub SaveWorkCarrer(workID As String, careerID As String)
        workCtl.CMS_WorkCareer_Delete_By_CMS_Work(pid, workID)
        Dim Str = careerID.Split(",")
        Dim wcInfo As New CMS_WorkCareerInfo
        For i As Integer = 0 To Str.Length - 1
            If Str(i) <> "" Then
                wcInfo = New CMS_WorkCareerInfo
                wcInfo.Career_ID = Str(i)
                wcInfo.Work_ID = workID
                workCtl.CMS_WorkCareer_Add(pid, wcInfo)
            End If
        Next
    End Sub
#End Region
#Region "ADMIN"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChangePassword(matKhauHienTai As String, matKhauMoi As String, matKhauXacNhan As String) As String
        GetUser(Authentication.userId)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj, flDnn.UpdatePassword(pid, obj, matKhauHienTai, matKhauMoi, matKhauXacNhan)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function LockAccount() As String
        GetUser(Authentication.userId)
        flDnn.DNN_User_Lock(obj.UserID, True, pid)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function UnLockAccount() As String
        GetUser(Authentication.userId)
        flDnn.DNN_User_Lock(obj.UserID, False, pid)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ResetPassword() As String
        GetUser(Authentication.userId)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj, flDnn.ResetPassword(pid, obj.Email)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function LogHistory(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        arr = flDnn.DNN_LogHistory(obj.UserID, soTrangHienTai, soBanGhiTrenTrang)
        For Each cr As EventLogInfo In arr
            If cr.LogTypeKey = "LOGIN_SUCCESS" Then
                cr.LogTypeKey = "Đăng nhập thành công"
            ElseIf cr.LogTypeKey = "LOGIN_FAILURE" Then
                cr.LogTypeKey = "Đăng nhập thất bại"
            Else
                cr.LogTypeKey = ""
            End If
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    '<WebMethod()>
    '<SoapHeader("Authentication")>
    '<ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    'Public Function LogHistory(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
    '    'GetUser(Authentication.userId)
    '    Call flReg.SetContentResponse()
    '    Dim data = New Response
    '    data.status = ServiceStatus.NODATA
    '    data.message = "Error"
    '    Try
    '        'If obj Is Nothing Then
    '        '    data.data = "Failed to connect to api, check your permissions again!"
    '        '    data.message = "Error"
    '        '    data.status = ServiceStatus.FAILED
    '        'Else

    '        Dim lst As List(Of LogInfo) = New EventLogController().GetLogs(pid, "LOGIN_FAILURE", soBanGhiTrenTrang, soTrangHienTai, 1000)
    '        lst.AddRange(New EventLogController().GetLogs(pid, "LOGIN_SUCCESS", soBanGhiTrenTrang, soTrangHienTai, 1000))
    '        If lst.Count > 0 Then
    '            data.status = ServiceStatus.SUCCESS
    '        Else
    '            data.status = ServiceStatus.NODATA
    '        End If
    '        data.data = lst
    '        data.status = ServiceStatus.SUCCESS
    '        data.message = "Success"
    '        'End If
    '    Catch ex As Exception
    '        data.message = ex.Message
    '        data.status = ServiceStatus.FAILED
    '    End Try

    '    Return JsonConvert.SerializeObject(data, SettingAPI())

    'End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FAQAddQuestion(hoTen As String, email As String, phone As String, noiDung As String) As String
        GetUser(Authentication.userId)
        Dim objInfo As New CMS_FAQQuestionsInfo
        objInfo.Name = hoTen & ""
        objInfo.Email = email
        objInfo.Phone = phone
        objInfo.Contents = flReg.RemoveScript(noiDung)
        objInfo.PortalId = pid
        objInfo.UpdateDate = Now
        objInfo.SendDate = Now
        objInfo.CreateDate = Now
        objInfo.CreateUser = obj.Username
        objInfo.Status = QuestionStatus.DaGui
        objInfo.FAQID = ""
        objInfo.IsPublic = False
        cmsCtl.CMS_FAQQuestions_Add(pid, objInfo)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FAQQuestionSearch(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        arr = New ArrayList
        Dim aswInfo As CMS_FAQAnswersInfo
        For Each cr As CMS_FAQQuestionsInfo In New CmsController().CMS_FAQQuestions_List_Search(pid, tuKhoa, "", 1, soTrangHienTai, soBanGhiTrenTrang, obj.Username, QuestionStatus.DaDuyet)
            cr.TrangThai = CMS.flCheck.FAQ_StatusName(cr.Status)
            aswInfo = New CmsController().CMS_FAQAnswers_Get(pid, cr.Id)
            If aswInfo IsNot Nothing Then
                cr.AnswerOb = aswInfo
            End If
            cr.Contents = flReg.RemoveScript(cr.Contents, False)
            arr.Add(cr)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function UserUpdate(hoTen As String, email As String, dienThoai As String, ngaySinh As String, gioiTinh As Integer, cmnd As String, diaChi As String, anhDaiDien As String) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            obj.DisplayName = hoTen
            obj.Email = email
            obj.Profile.Telephone = dienThoai
            obj.Profile.Photo = flReg.FileID(anhDaiDien, True, pid)
            obj.PortalID = pid
            DotNetNuke.Entities.Profile.ProfileController.UpdateUserProfile(obj)
            UserController.UpdateUser(pid, obj)

            ubj = flDnn.CMSUserPortal_Get_By_User("", obj.Username, "work", 0)
            ubj.UserName = obj.Username
            ubj.Telephone = dienThoai
            ubj.DisplayName = hoTen
            ubj.Email = email

            ubj.Address = diaChi
            ubj.DateOfBirth = flReg.WriteDate(ngaySinh, False)
            ubj.Gender = gioiTinh
            ubj.CMND = cmnd
            flDnn.CMSUserPortal_Add(ubj)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj), SettingAPI())
    End Function
#End Region
#Region "ChatBot"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_DanhSachHoiThoai(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, trangThai As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = flChatBot.HoiThoai_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, trangThai)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_ChiTietHoiThoai(idHoiThoai As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = flChatBot.TinHoiThoai_List(pid, idHoiThoai)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_DanhDauSao(idHoiThoai As String, soSao As Integer) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            If getNull(idHoiThoai) <> "" Then
                _arr = flChatBot.HoiThoai_Sao(pid, idHoiThoai, obj.Username, soSao)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_XoaHoiThoai(idHoiThoai As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            If getNull(idHoiThoai) <> "" Then
                _arr = flChatBot.HoiThoai_Delete(pid, idHoiThoai, obj.Username)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_ThemCauMau(cauMau As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            If flReg.getStringNullHtml(cauMau) <> "" Then
                Dim item As New CauMauInfo
                item.TenCauMau = cauMau.Trim
                item.GhiChu = "Từ app mobile"
                item.IsOrder = 50
                item.IdThucThe = 0 '' Chưa dán thực thể
                item.CreatedDate = Now
                item.CreatedUser = UserInfo.Username
                item.UpdatedUser = UserInfo.Username
                item.UpdatedDate = Now
                item.DeletedDate = Now
                item.IsActive = True
                _arr = flChatBot.CauMau_Add(pid, item)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChatBot_MaNhung() As String
        GetUser(Authentication.userId)
        Dim _arr As Object = Nothing
        If obj IsNot Nothing Then
            Dim listThietLapGT As List(Of HT_ThietLapInfo)
            listThietLapGT = flChatBot.HT_ThietLap_List(pid)
            If listThietLapGT.Count() > 0 Then
                Dim item = listThietLapGT.Where(Function(x) x.MaThietLap = flMaThietLap.APPCHAT).ToList()
                If item.Count > 0 Then
                    _arr = listThietLapGT.Find(Function(x) x.MaThietLap = flMaThietLap.APPCHAT).GiaTri
                Else
                    _arr = Nothing
                End If
            Else
                _arr = Nothing
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
#End Region

#Region "CMS_BanBe"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BanBe_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_BanBe_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BanBe_HuyKetBan(id As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            If id > 0 Then
                workCtl.CMS_BanBe_Delete(pid, id)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(Nothing), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BanBe_GuiKetBan(userNameBanBe As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            If userNameBanBe <> "" Then
                Dim item = New CMS_BanBeInfo
                item.UserName = obj.Username
                item.UserNameBanBe = userNameBanBe
                item.IsActive = 1
                item.IsOrder = Now.ToString("ss")
                item.CreatedDate = Now
                item.CreatedUser = obj.Username
                item.UpdatedUser = ""
                item.UpdatedDate = Now
                item.DeletedDate = Now
                _arr = workCtl.CMS_BanBe_Add(pid, item)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())

    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BanBe_ChiTiet(id As Integer) As String
        GetUser(Authentication.userId)
        Dim objBB As New CMS_BanBeInfo
        If obj IsNot Nothing Then
            objBB = workCtl.CMS_BanBe_Get(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objBB), SettingAPI())
    End Function
#End Region

#Region "CMS_BanBe_TinNhan"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function TinNhan_DanhSach(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_BanBe_TinNhan_List_Search(pid, tuKhoa, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function TinNhan_ChiTiet(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, userNameBanBe As String) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_BanBe_TinNhan_Details(pid, tuKhoa, 0, soTrangHienTai, soBanGhiTrenTrang, obj.Username, userNameBanBe)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function TinNhan_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            If id > 0 Then
                workCtl.CMS_BanBe_TinNhan_Delete(pid, id)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(Nothing), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function TinNhan_Add(noiDung As String, fileURL As String, userNameBanBe As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            If userNameBanBe <> "" Then
                Dim item = New CMS_BanBe_TinNhanInfo
                item.UserName = obj.Username
                item.UserNameBanBe = userNameBanBe
                item.NoiDung = noiDung
                item.FileURL = fileURL
                item.LoaiTinNhan = IIf(fileURL <> "", 2, 1) '' 1: tin nhắn text, 2: Hình ảnh
                item.IsActive = 1
                item.IsOrder = Now.ToString("ss")
                item.CreatedDate = Now
                item.CreatedUser = obj.Username
                item.UpdatedUser = ""
                item.UpdatedDate = Now
                item.DeletedDate = Now
                _arr = workCtl.CMS_BanBe_TinNhan_Add(pid, item)
            End If
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
#End Region

#Region "Thông báo"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ThongBao_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, trangThai As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = cmsCtl.CMS_ThongBao_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "", trangThai)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ThongBao_ChiTiet(id As Integer) As String
        GetUser(Authentication.userId)
        Dim objThongBao As New CMS_ThongBaoInfo
        If obj IsNot Nothing Then
            objThongBao = cmsCtl.CMS_ThongBao_Get(pid, id)
            objThongBao.IsRead = 1
            Call cmsCtl.CMS_ThongBao_Update(pid, objThongBao)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objThongBao), SettingAPI())
    End Function
#End Region

#Region "NĐ23"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ND23_Work_Add(tieuDe As String, mucLuong As String, soLuong As Integer, kinhNghiem As String, doTuoi As String, chucVu As String, gioiTinh As String, trinhdoCM As String, tinhTP As String, tinhChatCV As String, viTriTuyenDung As String, nganhNghe As String, thoiGianLV As String, mota As String, yeuCauCV As String, quyenLoi As String, yeuCauHoSo As String, hanNopHoSo As String, hinhThucNop As String, dangTuNgay As String, dangDenNgay As String, tenNguoiLH As String, diaChiNguoiLH As String, dienThoaiNguoiLH As String, emailNguoiLH As String, ghiChu As String, tinNoiBat As Int16, dauThongTinDN As Int16, dangGap As Int16, quanHuyen As String, hinhthuclamviec As String, jobPlace_ID As String, gender_ID As String, maNghe_Id As String, maNgheCap1 As String, maNgheCap2 As String, maNgheCap3 As String, maNgheCap4 As String, LevelDesired As String, trinhDoHocVan As String, trinhDoChuyenMon As String, chuyenNganhDaoTao As String, trinhDoKhac As String, trinhDoKhac2 As String, kyNangNghe As String, kyNangNgheBac As String, ngoaiNgu1 As String, ngoaiNgu1ChungChi As String, trinhDoNgoaiNgu1 As String, ngoaiNgu2 As String, ngoaiNgu1ChungChi2 As String, trinhDoNgoaiNgu2 As String, trinhDoTinHoc As String, trinhDoTinHoc_KhaNang As String, trinhDoTinHoc_Khac As String, trinhDoTinHoc_Khac_KhaNang As String, kyNangMem As String, yeuCauKinhNghiem As String, contractType_Option As String, lamCa As String, diCongTac As String, diBietPhai As String, mucDich_ID As String, kieuLuong As String, salary_Option As String, salary_Text As String, hoaHong As String, hoTroAn As String, phucLoi As String, xeDuaDon As String, hoTro As String, phucLoiKhac As String, noiLamViec As String, noiLamViecTrongLuong As String, noiLamViecDiLai As String, noiLamViecNgheNoi As String, noiLamViecThiLuc As String, noiLamViecThaoTacBangTay As String, noiLamViecDung2Tay As String, doiTuongUuTien As String, hinhThucTuyenDung As String, thoiHanTuyenDung As String, levelDesiredOther As String, thoaThuan As String, mongMuonDN As String) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objW = New CMS_WorkInfo
        Dim objExtend = New CMS_WorkExtendInfo
        If String.IsNullOrEmpty(busID) = False Then
            objW.Title = tieuDe
            objW.Business_ID = busID
            objW.Salary_ID = mucLuong
            objW.Quantity = flReg.WriteNumber(soLuong)
            objW.Experience_ID = kinhNghiem
            objW.Gender = flReg.WriteNumber(gioiTinh)
            objW.Level_ID = trinhdoCM

            objW.TinhTP = tinhTP
            objW.TypeOf_ID = tinhChatCV
            objW.JobPlace = viTriTuyenDung
            objW.Career_ID = nganhNghe
            objW.Description = mota
            objW.Requirement = yeuCauCV
            objW.Benefit = quyenLoi
            objW.RequirementsProfile = yeuCauHoSo
            objW.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objW.SubmissionSend = hinhThucNop
            objW.StartDate = flReg.WriteDate(dangTuNgay, False)
            objW.EndDate = flReg.WriteDate(dangDenNgay, False)
            objW.ContactUser = tenNguoiLH
            objW.ContactAddress = diaChiNguoiLH
            objW.ContactMobile = dienThoaiNguoiLH
            objW.ContactEmail = emailNguoiLH
            objW.ContactDes = ghiChu
            objW.IsHot = flReg.ToBoolean(tinNoiBat)
            objW.IsFast = flReg.ToBoolean(dauThongTinDN)
            objW.IsUrgent = flReg.ToBoolean(dangGap)
            objW.LevelDesired_ID = chucVu
            objW.Ages = doTuoi
            objW.WorkTime = thoiGianLV
            objW.IsDelete = False
            objW.DeletedUser = ""
            objW.DeletedDate = flReg.DateNull
            objW.IsApproval = False
            objW.ApprovalUser = ""
            objW.ApprovalDate = flReg.DateNull
            objW.PortalID = pid
            objW.IsFlag = WorkFlag.WebFrom
            objW.Work_ID = flReg.GenKey()
            objW.CreatedDate = Now
            objW.CreatedUser = obj.Username
            objW.UpdatedDate = flReg.DateNull
            workCtl.CMS_Work_Add(pid, objW)

            '' Work Extend
            objExtend.Work_ID = objW.Work_ID
            objExtend.Business_ID = busID
            objExtend.IsApproval = False
            objExtend.IsHot = False
            objExtend.IsFast = False
            objExtend.IsUrgent = False
            objExtend.IsGhim = False
            objExtend.StartDate = flReg.WriteDate(dangTuNgay, False)
            objExtend.EndDate = flReg.WriteDate(dangDenNgay, False)
            objExtend.Title = tieuDe
            objExtend.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objExtend.TinhTP = tinhTP
            objExtend.QuanHuyen = quanHuyen
            objExtend.Salary_ID = mucLuong
            objExtend.Experience_ID = kinhNghiem
            objExtend.SubmissionSend = hinhThucNop
            objExtend.Level_ID = trinhdoCM
            objExtend.Ages = doTuoi
            objExtend.TypeOf_ID = tinhChatCV
            objExtend.Career_ID = nganhNghe
            objExtend.WorkTime = thoiGianLV
            objExtend.Description = mota
            objExtend.Benefit = quyenLoi
            objExtend.Requirement = yeuCauCV
            objExtend.RequirementsProfile = yeuCauHoSo
            objExtend.HinhThucLamViec = hinhthuclamviec

            objExtend.JobPlace_ID = jobPlace_ID
            objExtend.Gender_ID = gender_ID
            objExtend.MaNghe_Id = maNghe_Id
            objExtend.MaNgheCap1 = maNgheCap1
            objExtend.MaNgheCap2 = maNgheCap2
            objExtend.MaNgheCap3 = maNgheCap3
            objExtend.MaNgheCap4 = maNgheCap4
            objExtend.LevelDesired = LevelDesired
            objExtend.TrinhDoHocVan = trinhDoHocVan
            objExtend.TrinhDoChuyenMon = trinhDoChuyenMon
            objExtend.ChuyenNganhDaoTao = chuyenNganhDaoTao
            objExtend.TrinhDoKhac = trinhDoKhac
            objExtend.TrinhDoKhac2 = trinhDoKhac2
            objExtend.KyNangNghe = kyNangNghe
            objExtend.KyNangNgheBac = kyNangNgheBac
            objExtend.NgoaiNgu1 = ngoaiNgu1
            objExtend.NgoaiNgu1ChungChi = ngoaiNgu1ChungChi
            objExtend.TrinhDoNgoaiNgu1 = trinhDoNgoaiNgu1
            objExtend.NgoaiNgu2 = ngoaiNgu2
            objExtend.NgoaiNgu1ChungChi2 = ngoaiNgu1ChungChi2
            objExtend.TrinhDoNgoaiNgu2 = trinhDoNgoaiNgu2
            objExtend.TrinhDoTinHoc = trinhDoTinHoc
            objExtend.TrinhDoTinHoc_KhaNang = trinhDoTinHoc_KhaNang
            objExtend.TrinhDoTinHoc_Khac = trinhDoTinHoc_Khac
            objExtend.TrinhDoTinHoc_Khac_KhaNang = trinhDoTinHoc_Khac_KhaNang
            objExtend.KyNangMem = kyNangMem
            objExtend.YeuCauKinhNghiem = yeuCauKinhNghiem
            objExtend.ContractType_Option = contractType_Option
            objExtend.IsLamCa = flReg.ToBoolean(lamCa)
            objExtend.IsDiCongTac = flReg.ToBoolean(diCongTac)
            objExtend.IsDiBietPhai = flReg.ToBoolean(diBietPhai)
            objExtend.MucDich_ID = mucDich_ID
            objExtend.KieuLuong = kieuLuong
            objExtend.Salary_Option = salary_Option
            objExtend.Salary_Text = salary_Text
            objExtend.IsHoaHong = flReg.ToBoolean(hoaHong)
            objExtend.HinhThucNop = hinhThucNop
            objExtend.HoTroAn = hoTroAn
            objExtend.PhucLoi = phucLoi
            objExtend.XeDuaDon = xeDuaDon
            objExtend.HoTro = hoTro
            objExtend.PhucLoiKhac = phucLoiKhac
            objExtend.NoiLamViec = noiLamViec
            objExtend.NoiLamViecTrongLuong = noiLamViecTrongLuong
            objExtend.NoiLamViecDiLai = noiLamViecDiLai
            objExtend.NoiLamViecNgheNoi = noiLamViecNgheNoi
            objExtend.NoiLamViecThiLuc = noiLamViecThiLuc
            objExtend.NoiLamViecThaoTacBangTay = noiLamViecThaoTacBangTay
            objExtend.NoiLamViecDung2Tay = noiLamViecDung2Tay
            objExtend.DoiTuongUuTien = doiTuongUuTien
            objExtend.HinhThucTuyenDung = hinhThucTuyenDung
            objExtend.ThoiHanTuyenDung = thoiHanTuyenDung
            objExtend.LevelDesiredOther = levelDesiredOther
            objExtend.IsThoaThuan = flReg.ToBoolean(thoaThuan)
            objExtend.MongMuonDN = mongMuonDN
            objExtend.CreatedDate = Now
            objExtend.UpdatedDate = Now
            objExtend.DeletedDate = flReg.DateNull
            objExtend.CreatedUser = obj.Username
            objExtend.UpdatedUser = obj.Username
            objExtend.DeletedUser = ""
            workCtl.CMS_WorkExtend_Add(pid, objExtend)
        Else
            objW = New CMS_WorkInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ND23_Work_Update(workId As String, tieuDe As String, mucLuong As String, soLuong As Integer, kinhNghiem As String, doTuoi As String, chucVu As String, gioiTinh As String, trinhdoCM As String, tinhTP As String, tinhChatCV As String, viTriTuyenDung As String, nganhNghe As String, thoiGianLV As String, mota As String, yeuCauCV As String, quyenLoi As String, yeuCauHoSo As String, hanNopHoSo As String, hinhThucNop As String, dangTuNgay As String, dangDenNgay As String, tenNguoiLH As String, diaChiNguoiLH As String, dienThoaiNguoiLH As String, emailNguoiLH As String, ghiChu As String, tinNoiBat As Int16, dauThongTinDN As Int16, dangGap As Int16, quanHuyen As String, hinhthuclamviec As String, jobPlace_ID As String, gender_ID As String, maNghe_Id As String, maNgheCap1 As String, maNgheCap2 As String, maNgheCap3 As String, maNgheCap4 As String, LevelDesired As String, trinhDoHocVan As String, trinhDoChuyenMon As String, chuyenNganhDaoTao As String, trinhDoKhac As String, trinhDoKhac2 As String, kyNangNghe As String, kyNangNgheBac As String, ngoaiNgu1 As String, ngoaiNgu1ChungChi As String, trinhDoNgoaiNgu1 As String, ngoaiNgu2 As String, ngoaiNgu1ChungChi2 As String, trinhDoNgoaiNgu2 As String, trinhDoTinHoc As String, trinhDoTinHoc_KhaNang As String, trinhDoTinHoc_Khac As String, trinhDoTinHoc_Khac_KhaNang As String, kyNangMem As String, yeuCauKinhNghiem As String, contractType_Option As String, lamCa As String, diCongTac As String, diBietPhai As String, mucDich_ID As String, kieuLuong As String, salary_Option As String, salary_Text As String, hoaHong As String, hoTroAn As String, phucLoi As String, xeDuaDon As String, hoTro As String, phucLoiKhac As String, noiLamViec As String, noiLamViecTrongLuong As String, noiLamViecDiLai As String, noiLamViecNgheNoi As String, noiLamViecThiLuc As String, noiLamViecThaoTacBangTay As String, noiLamViecDung2Tay As String, doiTuongUuTien As String, hinhThucTuyenDung As String, thoiHanTuyenDung As String, levelDesiredOther As String, thoaThuan As String, mongMuonDN As String) As String
        GetUser(Authentication.userId)
        Dim busID As String = WORK.flCheck.Business_ID(pid, obj.Username)
        Dim objW = New CMS_WorkInfo
        Dim objExtend = New CMS_WorkExtendInfo
        If String.IsNullOrEmpty(busID) = False Then
            objW.Work_ID = workId
            objW.Title = tieuDe
            objW.Business_ID = busID
            objW.Salary_ID = mucLuong
            objW.Quantity = flReg.WriteNumber(soLuong)
            objW.Experience_ID = kinhNghiem
            objW.Gender = flReg.WriteNumber(gioiTinh)
            objW.Level_ID = trinhdoCM

            objW.TinhTP = tinhTP
            objW.TypeOf_ID = tinhChatCV
            objW.JobPlace = viTriTuyenDung
            objW.Career_ID = nganhNghe
            objW.Description = mota
            objW.Requirement = yeuCauCV
            objW.Benefit = quyenLoi
            objW.RequirementsProfile = yeuCauHoSo
            objW.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objW.SubmissionSend = hinhThucNop
            objW.StartDate = flReg.WriteDate(dangTuNgay, False)
            objW.EndDate = flReg.WriteDate(dangDenNgay, False)
            objW.ContactUser = tenNguoiLH
            objW.ContactAddress = diaChiNguoiLH
            objW.ContactMobile = dienThoaiNguoiLH
            objW.ContactEmail = emailNguoiLH
            objW.ContactDes = ghiChu
            objW.IsHot = flReg.ToBoolean(tinNoiBat)
            objW.IsFast = flReg.ToBoolean(dauThongTinDN)
            objW.IsUrgent = flReg.ToBoolean(dangGap)
            objW.LevelDesired_ID = chucVu
            objW.Ages = doTuoi
            objW.WorkTime = thoiGianLV
            objW.IsDelete = False
            objW.DeletedUser = ""
            objW.DeletedDate = flReg.DateNull
            objW.IsApproval = False
            objW.ApprovalUser = ""
            objW.ApprovalDate = flReg.DateNull
            objW.PortalID = pid
            objW.IsFlag = WorkFlag.WebFrom
            objW.Work_ID = flReg.GenKey()
            objW.CreatedDate = Now
            objW.CreatedUser = obj.Username
            objW.UpdatedDate = flReg.DateNull
            workCtl.CMS_Work_Update(pid, objW)

            '' Work Extend
            objExtend.Work_ID = objW.Work_ID
            objExtend.Business_ID = busID
            objExtend.IsApproval = False
            objExtend.IsHot = False
            objExtend.IsFast = False
            objExtend.IsUrgent = False
            objExtend.IsGhim = False
            objExtend.StartDate = flReg.WriteDate(dangTuNgay, False)
            objExtend.EndDate = flReg.WriteDate(dangDenNgay, False)
            objExtend.Title = tieuDe
            objExtend.ExpiredDate = flReg.WriteDate(hanNopHoSo, False)
            objExtend.TinhTP = tinhTP
            objExtend.QuanHuyen = quanHuyen
            objExtend.Salary_ID = mucLuong
            objExtend.Experience_ID = kinhNghiem
            objExtend.SubmissionSend = hinhThucNop
            objExtend.Level_ID = trinhdoCM
            objExtend.Ages = doTuoi
            objExtend.TypeOf_ID = tinhChatCV
            objExtend.Career_ID = nganhNghe
            objExtend.WorkTime = thoiGianLV
            objExtend.Description = mota
            objExtend.Benefit = quyenLoi
            objExtend.Requirement = yeuCauCV
            objExtend.RequirementsProfile = yeuCauHoSo
            objExtend.HinhThucLamViec = hinhthuclamviec

            objExtend.JobPlace_ID = jobPlace_ID
            objExtend.Gender_ID = gender_ID
            objExtend.MaNghe_Id = maNghe_Id
            objExtend.MaNgheCap1 = maNgheCap1
            objExtend.MaNgheCap2 = maNgheCap2
            objExtend.MaNgheCap3 = maNgheCap3
            objExtend.MaNgheCap4 = maNgheCap4
            objExtend.LevelDesired = LevelDesired
            objExtend.TrinhDoHocVan = trinhDoHocVan
            objExtend.TrinhDoChuyenMon = trinhDoChuyenMon
            objExtend.ChuyenNganhDaoTao = chuyenNganhDaoTao
            objExtend.TrinhDoKhac = trinhDoKhac
            objExtend.TrinhDoKhac2 = trinhDoKhac2
            objExtend.KyNangNghe = kyNangNghe
            objExtend.KyNangNgheBac = kyNangNgheBac
            objExtend.NgoaiNgu1 = ngoaiNgu1
            objExtend.NgoaiNgu1ChungChi = ngoaiNgu1ChungChi
            objExtend.TrinhDoNgoaiNgu1 = trinhDoNgoaiNgu1
            objExtend.NgoaiNgu2 = ngoaiNgu2
            objExtend.NgoaiNgu1ChungChi2 = ngoaiNgu1ChungChi2
            objExtend.TrinhDoNgoaiNgu2 = trinhDoNgoaiNgu2
            objExtend.TrinhDoTinHoc = trinhDoTinHoc
            objExtend.TrinhDoTinHoc_KhaNang = trinhDoTinHoc_KhaNang
            objExtend.TrinhDoTinHoc_Khac = trinhDoTinHoc_Khac
            objExtend.TrinhDoTinHoc_Khac_KhaNang = trinhDoTinHoc_Khac_KhaNang
            objExtend.KyNangMem = kyNangMem
            objExtend.YeuCauKinhNghiem = yeuCauKinhNghiem
            objExtend.ContractType_Option = contractType_Option
            objExtend.IsLamCa = flReg.ToBoolean(lamCa)
            objExtend.IsDiCongTac = flReg.ToBoolean(diCongTac)
            objExtend.IsDiBietPhai = flReg.ToBoolean(diBietPhai)
            objExtend.MucDich_ID = mucDich_ID
            objExtend.KieuLuong = kieuLuong
            objExtend.Salary_Option = salary_Option
            objExtend.Salary_Text = salary_Text
            objExtend.IsHoaHong = flReg.ToBoolean(hoaHong)
            objExtend.HinhThucNop = hinhThucNop
            objExtend.HoTroAn = hoTroAn
            objExtend.PhucLoi = phucLoi
            objExtend.XeDuaDon = xeDuaDon
            objExtend.HoTro = hoTro
            objExtend.PhucLoiKhac = phucLoiKhac
            objExtend.NoiLamViec = noiLamViec
            objExtend.NoiLamViecTrongLuong = noiLamViecTrongLuong
            objExtend.NoiLamViecDiLai = noiLamViecDiLai
            objExtend.NoiLamViecNgheNoi = noiLamViecNgheNoi
            objExtend.NoiLamViecThiLuc = noiLamViecThiLuc
            objExtend.NoiLamViecThaoTacBangTay = noiLamViecThaoTacBangTay
            objExtend.NoiLamViecDung2Tay = noiLamViecDung2Tay
            objExtend.DoiTuongUuTien = doiTuongUuTien
            objExtend.HinhThucTuyenDung = hinhThucTuyenDung
            objExtend.ThoiHanTuyenDung = thoiHanTuyenDung
            objExtend.LevelDesiredOther = levelDesiredOther
            objExtend.IsThoaThuan = flReg.ToBoolean(thoaThuan)
            objExtend.MongMuonDN = mongMuonDN
            objExtend.CreatedDate = Now
            objExtend.UpdatedDate = Now
            objExtend.DeletedDate = flReg.DateNull
            objExtend.CreatedUser = obj.Username
            objExtend.UpdatedUser = obj.Username
            objExtend.DeletedUser = ""
            workCtl.CMS_WorkExtend_Add(pid, objExtend)
        Else
            objW = New CMS_WorkInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ND23_Work_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_Work_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_WorkInfo), SettingAPI())
    End Function
#End Region
#Region "Chủ đề"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_ChiTiet(id As Integer) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDeInfo
        If obj IsNot Nothing Then
            objW = workCtl.CMS_ChuDe_Get(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_ChuDe_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Add(noiDung As String, fileURL As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            Dim item = New CMS_ChuDeInfo
            item.UserName = obj.Username
            item.NoiDung = noiDung
            item.FileURL = fileURL
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            _arr = workCtl.CMS_ChuDe_Add(pid, item)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Update(idChuDe As String, noiDung As String, fileURL As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDeInfo
        If obj IsNot Nothing Then
            Dim item = New CMS_ChuDeInfo
            item.Id = flReg.WriteNumber(idChuDe)
            item.UserName = obj.Username
            item.NoiDung = noiDung
            item.FileURL = fileURL
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            workCtl.CMS_ChuDe_Update(pid, item)
        Else
            objW = New CMS_ChuDeInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Like(idChuDe As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDeInfo
        If obj IsNot Nothing Then
            workCtl.CMS_ChuDe_Update_Quick(pid, flReg.WriteNumber(idChuDe), True, 1, obj.Username)
        Else
            objW = New CMS_ChuDeInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Share(idChuDe As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDeInfo
        If obj IsNot Nothing Then
            workCtl.CMS_ChuDe_Update_Quick(pid, flReg.WriteNumber(idChuDe), True, 2, obj.Username)
        Else
            objW = New CMS_ChuDeInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Report(idChuDe As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDeInfo
        If obj IsNot Nothing Then
            workCtl.CMS_ChuDe_Update_Quick(pid, flReg.WriteNumber(idChuDe), True, 2, obj.Username)
        Else
            objW = New CMS_ChuDeInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_ChuDe_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_ChuDeInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_BinhLuan_DanhSach(idChuDe As String, tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_ChuDe_BinhLuan_List_Search(pid, flReg.WriteNumber(idChuDe), tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_BinhLuan_Add(idChuDe As String, noiDung As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            Dim item = New CMS_ChuDe_BinhLuanInfo
            item.IdChuDe = flReg.WriteNumber(idChuDe)
            item.NoiDung = noiDung
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            _arr = workCtl.CMS_ChuDe_BinhLuan_Add(pid, item)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_BinhLuan_Update(id As String, noiDung As String, fileURL As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_ChuDe_BinhLuanInfo
        If obj IsNot Nothing Then
            Dim item = New CMS_ChuDe_BinhLuanInfo
            item.Id = flReg.WriteNumber(id)
            item.NoiDung = noiDung
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            workCtl.CMS_ChuDe_BinhLuan_Update(pid, item)
        Else
            objW = New CMS_ChuDe_BinhLuanInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChuDe_BinhLuan_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_ChuDe_BinhLuan_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_ChuDe_BinhLuanInfo), SettingAPI())
    End Function
#End Region

#Region "Văn phòng giao dịch"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VanPhongGD_ChiTiet(id As Integer) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_VanPhongGDInfo
        If obj IsNot Nothing Then
            objW = workCtl.CMS_VanPhongGD_Get(pid, id)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VanPhongGD_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_ChuDe_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "")
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VanPhongGD_Add(tenVanPhong As String, diaChi As String, soDienThoai As String, email As String, lichLamViec As String, moTa As String, fileDinhKem As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            Dim item = New CMS_VanPhongGDInfo
            item.TenVanPhong = tenVanPhong
            item.DiaChi = diaChi
            item.SoDienThoai = soDienThoai
            item.Email = email
            item.LichLamViec = lichLamViec
            item.MoTa = moTa
            item.FileDinhKem = fileDinhKem
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            _arr = workCtl.CMS_VanPhongGD_Add(pid, item)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VanPhongGD_Update(id As String, tenVanPhong As String, diaChi As String, soDienThoai As String, email As String, lichLamViec As String, moTa As String, fileDinhKem As String) As String
        GetUser(Authentication.userId)
        Dim objW = New CMS_VanPhongGDInfo
        If obj IsNot Nothing Then
            Dim item = New CMS_VanPhongGDInfo
            item.Id = id
            item.TenVanPhong = tenVanPhong
            item.DiaChi = diaChi
            item.SoDienThoai = soDienThoai
            item.Email = email
            item.LichLamViec = lichLamViec
            item.MoTa = moTa
            item.FileDinhKem = fileDinhKem
            item.IsActive = 1
            item.IsOrder = Now.ToString("ss")
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            workCtl.CMS_VanPhongGD_Update(pid, item)
        Else
            objW = New CMS_VanPhongGDInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objW), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VanPhongGD_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_VanPhongGD_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_VanPhongGDInfo), SettingAPI())
    End Function
#End Region
#Region "WorkReport"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkReport_Add(workId As String, workTitle As String, workUrl As String, tieuDe As String, moTa As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            Dim item = New CMS_WorkReportInfo
            item.Work_ID = flReg.WriteNumber(workId)
            item.Work_Title = workTitle
            item.Work_Url = workUrl
            item.TieuDe = tieuDe
            item.MoTa = moTa
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            _arr = workCtl.CMS_WorkReport_Add(pid, item)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkReport_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_WorkReport_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region
#Region "CMS_BusinessFollow"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BusinessFollow_Add(businessID As String, businessTitle As String, businessUrl As String, tieuDe As String, moTa As String) As String
        GetUser(Authentication.userId)
        Dim _arr As Integer = 0
        If obj IsNot Nothing Then
            Dim item = New CMS_BusinessFollowInfo
            item.Business_ID = flReg.WriteNumber(businessID)
            item.Business_Vn = businessTitle
            item.Business_Url = businessUrl
            item.TieuDe = tieuDe
            item.MoTa = moTa
            item.CreatedDate = Now
            item.CreatedUser = obj.Username
            item.UpdatedUser = ""
            item.UpdatedDate = Now
            item.DeletedDate = Now
            _arr = workCtl.CMS_BusinessFollow_Add(pid, item)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(_arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BusinessFollow_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_BusinessFollow_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BusinessFollow_ChiTiet(id As String) As String
        HostUser()
        GetUser(Authentication.userId)
        Dim objTV As New CMS_BusinessFollowInfo
        objTV = workCtl.CMS_BusinessFollow_Get(pid, id)
        If objTV Is Nothing Then
            objTV = New CMS_BusinessFollowInfo
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objTV), SettingAPI())
    End Function
#End Region
#Region "CMS_JobView"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobView_DanhSach(tuKhoa As String, kieuSapXep As Integer, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_JobView_List_Search(pid, tuKhoa.Trim, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, obj.Username, JobView.NguoiTimViecLuu, "", "", "0", "", "", "")
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobView_Delete(id As Integer) As String
        GetUser(Authentication.userId)
        workCtl.CMS_JobView_Delete(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(New CMS_JobViewInfo), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobView_Save(jobUserID As String, title As String) As String
        GetUser(Authentication.userId)
        Dim jInfo As New CMS_JobViewInfo
        jInfo.JobView_ID = flReg.GenKey()
        jInfo.IdKey = jobUserID
        jInfo.IdName = title
        jInfo.UserName = WORK.flCheck.Business_ID(pid, obj.Username)
        jInfo.CreateDate = Now
        jInfo.IsFlag = JobView.DoanhNghiepLuu
        workCtl.CMS_JobView_Add(pid, jInfo)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(jInfo), SettingAPI())
    End Function
#End Region

#Region "Common"
    'Private Function UpdateUserInfo(usID As String, hoTen As String, email As String, dienThoai As String, ngaySinh As String, gioiTinh As Integer, cmnd As String, diaChi As String, anhDaiDien As String)
    '    Try


    '        'flCache.RemoveCache("CMSUserPortal_Get_By_User_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getNgaySinh_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getDiaChi_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getGioiTinh_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getTelephone_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getEmail_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getHoTen_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("getCMND_" & pid & "_" & obj.Username)
    '        'flCache.RemoveCache("PhotoURLFile_" & obj.Username & "_" & pid)
    '        'flCache.RemoveCache("Telephone_" & obj.Username)

    '    Catch ex As Exception
    '    End Try
    'End Function

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
#End Region
End Class