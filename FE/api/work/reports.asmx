<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim litList As String, n As Integer
    Dim ObjController As New WorkController()
    Dim arrTemp As New ArrayList
    Dim userControler As New UserController
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function getValue(pid As Integer, tp As String, px As String, fd As String, td As String, car As String, sal As String, key As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Select Case key
            Case "jobseeker"
                data.data = RPT_JobSeeker(pid, tp, px, fd, td, car, sal)
            Case "employer"
                data.data = RPT_Employer(pid, tp, px, fd, td, car, sal)
            Case "jobview"
                data.data = RPT_JobView(pid, tp, px, fd, td, car, sal)
            Case "salary"
                data.data = RPT_Salary(pid, tp, px, fd, td, car, sal)
            Case "career"
                data.data = RPT_Career(pid, tp, px, fd, td, car, sal)
            Case "work"
                data.data = RPT_Work(pid, tp, px, fd, td, car)
            Case "nganhnghe"
                data.data = RPT_NGANHNGHE(pid, tp, px, fd, td, car)
            Case "cmkt"
                data.data = RPT_CMKT(pid, tp, px, fd, td, car)
            Case "cmkt_nld"
                data.data = RPT_CMKT_NLD(pid, tp, px, fd, td, car)
            Case "loaihinhdn"
                data.data = RPT_LoaiHinhDN(pid, tp, px, fd, td, car)
            Case "tuvan"
                data.data = RPT_TUVAN(pid, "", tp, px, fd, td, car)
            Case Else
                data.data = ""
        End Select

        Return JsonConvert.SerializeObject(data, settings)

    End Function
    Public Function RPT_JobSeeker(pid As Integer, tp As String, px As String, fromd As String, tod As String, car As String, sal As String) As String
        Dim gt As String
        Dim ubj As New CMSUserPortalInfo
        arrTemp = ObjController.CMS_RPT_JobSeeker(pid, flReg.WriteNumber(tp), flReg.WriteNumber(px), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), car, sal)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='text-align:center;width:5%;' class='hdTitle'>STT</td>"
        litList += "<td style='width:15%;' class='hdTitle'>Hồ sơ xin việc</td>"
        'litList += "<td class='hdTitle'>Hồ sơ xin việc</td>"
        litList += "<td style='width:15%;' class='hdTitle'>Thông tin hồ sơ</td>"
        'litList += "<td style='width:11%;' class='hdTitle'>Ngày sinh</td>"
        litList += "<td style='width:13%;' class='hdTitle'>Địa chỉ</td>"
        litList += "<td style='width:9%;' class='hdTitle'>SĐT</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Trình độ</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Ngành nghề</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Mức lương</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_JobUserInfo In arrTemp
            If Cr.UserAdmin = "" Then
                Continue For
            End If
            ubj = New CMSUserPortalInfo
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            'litList += "<td style='width:15%;'>" & flReg.GetUserName(Cr.UserAdmin) & "</td>"
            litList += "<td >" & Cr.Title & "</td>"
            gt = flReg.GetPropertyName(pid, Cr.UserAdmin, "Gender")
            If gt = "" Then gt = 0
            ubj = flDnn.CMSUserPortal_Get_By_User("", Cr.UserAdmin, "work", 0)
            If IsNothing(ubj) = False Then
                litList += "<td style='width:15%;'> Họ tên: " & flReg.GetUserName(Cr.UserAdmin) & "<br/>Giới tính: " & flCheck.GioiTinh(ubj.Gender) & "<br/>Ngày sinh: " & flReg.ReadDate(ubj.DateOfBirth, False) & "</td>"
                'litList += "<td style='width:11%;'>" & flReg.ReadDate(ubj.DateOfBirth, False) & "</td>"
                litList += "<td style='width:13%;'>" & ubj.Address & "</td>"
            Else
                litList += "<td style='width:8%;'></td>"
                'litList += "<td style='width:11%;'></td>"
                litList += "<td style='width:13%;'></td>"
            End If

            litList += "<td style='width:9%;'>" & flReg.Telephone(pid, Cr.UserAdmin) & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Education_Name(pid, Cr.Level_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flCheck.Career_Name(pid, Cr.Career_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flCheck.Salary_Name(pid, Cr.Salary_ID) & "</td>"


            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_Employer(pid As Integer, tp As String, px As String, fromd As String, tod As String, car As String, sal As String) As String
        arrTemp = ObjController.CMS_RPT_Employer(pid, tp, px, flReg.RptDate(fromd, True), flReg.RptDate(tod, False), car, sal)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tin tuyển dụng</td>"
        litList += "<td style='width:20%;' class='hdTitle'>Doanh nghiệp tuyển dụng</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Số lượng tuyển</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Chức danh</td>"
        litList += "<td style='width:8%;' class='hdTitle'>Mức lương</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Ngành nghề</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Bằng cấp</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_WorkInfo In arrTemp
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Title & "</td>"
            litList += "<td style='width:20%;'>" & flReg.RemoveScript(flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID), False) & "</td>"
            litList += "<td style='width:10%;'>" & Cr.Quantity & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Position_Name(pid, Cr.LevelDesired_ID) & "</td>"
            litList += "<td style='width:8%;'>" & flCheck.Salary_Name(pid, Cr.Salary_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flCheck.Career_Name(pid, Cr.Career_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Education_Name(pid, Cr.Level_ID) & "</td>"
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_JobView(pid As Integer, tp As String, px As String, fromd As String, tod As String, car As String, sal As String) As String
        arrTemp = ObjController.CMS_RPT_Employer(pid, tp, px, flReg.RptDate(fromd, True), flReg.RptDate(tod, False), car, sal)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tin tuyển dụng</td>"
        litList += "<td style='width:20%;' class='hdTitle'>Doanh nghiệp tuyển dụng</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Số lượng tuyển</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Chức danh</td>"
        litList += "<td style='width:8%;' class='hdTitle'>Mức lương</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Ngành nghề</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Bằng cấp</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Lượt xem</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_WorkInfo In arrTemp
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Title & "</td>"
            litList += "<td style='width:20%;'>" & flReg.RemoveScript(flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID), False) & "</td>"
            litList += "<td style='width:10%;'>" & Cr.Quantity & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Position_Name(pid, Cr.LevelDesired_ID) & "</td>"
            litList += "<td style='width:8%;'>" & flCheck.Salary_Name(pid, Cr.Salary_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flCheck.Career_Name(pid, Cr.Career_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Education_Name(pid, Cr.Level_ID) & "</td>"
            litList += "<td style='width:10%;'>" & Cr.IsView & "</td>"
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_Salary(pid As Integer, tp As String, px As String, fromd As String, tod As String, car As String, sal As String) As String
        arrTemp = ObjController.CMS_RPT_Employer(pid, tp, px, flReg.RptDate(fromd, True), flReg.RptDate(tod, False), car, sal)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tin tuyển dụng</td>"
        litList += "<td style='width:20%;' class='hdTitle'>Doanh nghiệp tuyển dụng</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Số lượng tuyển</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Chức danh</td>"
        litList += "<td style='width:8%;' class='hdTitle'>Mức lương</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Bằng cấp</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_WorkInfo In arrTemp
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Title & "</td>"
            litList += "<td style='width:20%;'>" & flReg.RemoveScript(flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID), False) & "</td>"
            litList += "<td style='width:10%;'>" & Cr.Quantity & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Position_Name(pid, Cr.LevelDesired_ID) & "</td>"
            litList += "<td style='width:8%;'>" & flCheck.Salary_Name(pid, Cr.Salary_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Education_Name(pid, Cr.Level_ID) & "</td>"
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_Career(pid As Integer, tp As String, px As String, fromd As String, tod As String, car As String, sal As String) As String
        arrTemp = ObjController.CMS_RPT_Employer(pid, tp, px, flReg.RptDate(fromd, True), flReg.RptDate(tod, False), car, sal)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tin tuyển dụng</td>"
        litList += "<td style='width:20%;' class='hdTitle'>Doanh nghiệp tuyển dụng</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Số lượng tuyển</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Chức danh</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Ngành nghề</td>"
        litList += "<td style='width:10%;' class='hdTitle'>Bằng cấp</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_WorkInfo In arrTemp
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Title & "</td>"
            litList += "<td style='width:20%;'>" & flReg.RemoveHTML(flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID)) & "</td>"
            litList += "<td style='width:10%;'>" & Cr.Quantity & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Position_Name(pid, Cr.LevelDesired_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flCheck.Career_Name(pid, Cr.Career_ID) & "</td>"
            litList += "<td style='width:10%;'>" & flDic.Education_Name(pid, Cr.Level_ID) & "</td>"
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function

    Public Function RPT_Work(pid As Integer, tp As String, px As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_WorkInfo)
        lstBC = ObjController.CMS_RPT_Work(pid, tp, flReg.WriteNumber(px), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))
        Dim arrQuanHuyen = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, tp)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tên đơn vị</td>"
        litList += "<td class='hdTitle' style='text-align:center;'>Số lượng tuyển</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_RegionalXPInfo In arrQuanHuyen
            Dim item As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = Cr.Regional_ID).FirstOrDefault()
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Regional_Name & "</td>"
            If item IsNot Nothing Then
                litList += "<td style='text-align:center;'>" & item.SoLuong & "</td>"
            Else
                litList += "<td style='text-align:center;'>0</td>"
            End If
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_CMKT(pid As Integer, tp As String, px As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_WorkInfo)
        lstBC = ObjController.CMS_RPT_CMKT(pid, tp, flReg.WriteNumber(px), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))
        Dim arrBC = ObjController.CMS_Specialize_List(pid)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tên trình độ chuyên môn</td>"
        litList += "<td class='hdTitle' style='text-align:center;'>Số lượng tuyển</td>"
        litList += "</tr>"

        n = 1
        Dim itemChuaXacDinh As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = 0).FirstOrDefault()
        If itemChuaXacDinh IsNot Nothing Then
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td> Chưa cập nhật</td>"
            litList += "<td style='text-align:center;'>" & itemChuaXacDinh.SoLuong & "</td>"
            litList += "</tr>"
            n += 1
        End If
        For Each Cr As CMS_SpecializeInfo In arrBC
            Dim item As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = Cr.Specialize_ID).FirstOrDefault()
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Specialize_Name & "</td>"
            If item IsNot Nothing Then
                litList += "<td style='text-align:center;'>" & item.SoLuong & "</td>"
            Else
                litList += "<td style='text-align:center;'>0</td>"
            End If
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_NGANHNGHE(pid As Integer, tp As String, qh As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_WorkInfo)
        lstBC = ObjController.CMS_RPT_NGANHNGHE(pid, tp, flReg.WriteNumber(qh), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))
        Dim arrBC = ObjController.CMS_NgheCongViec_List(pid)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tên ngành nghề</td>"
        litList += "<td class='hdTitle' style='text-align:center;'>Số lượng</td>"
        litList += "</tr>"

        n = 1
        Dim itemChuaXacDinh As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "0" Or p.QuanHuyen = "").FirstOrDefault()
        If itemChuaXacDinh IsNot Nothing Then
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td> Chưa cập nhật</td>"
            litList += "<td style='text-align:center;'>" & itemChuaXacDinh.SoLuong & "</td>"
            litList += "</tr>"
            n += 1
        End If
        For Each Cr As CMS_NgheCongViecInfo In arrBC
            Dim item As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = Cr.Id).FirstOrDefault()
            If item IsNot Nothing Then
                litList += "<tr style='vertical-align:middle;'>"
                litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
                litList += "<td>" & Cr.Career_Name & "</td>"
                If item IsNot Nothing Then
                    litList += "<td style='text-align:center;'>" & item.SoLuong & "</td>"
                Else
                    litList += "<td style='text-align:center;'>0</td>"
                End If
                litList += "</tr>"
                n += 1
            End If
        Next
        litList += "</table>"
        Return litList
    End Function
    Public Function RPT_CMKT_NLD(pid As Integer, tp As String, px As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_WorkInfo)
        lstBC = ObjController.CMS_RPT_CMKT_NLD(pid, tp, flReg.WriteNumber(px), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))
        Dim arrBC = ObjController.CMS_Specialize_List(pid)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tên trình độ chuyên môn</td>"
        litList += "<td class='hdTitle' style='text-align:center;'>Số lượng tuyển</td>"
        litList += "</tr>"

        n = 1
        Dim itemChuaXacDinh As CMS_BC_WorkInfo = lstBC.Where(Function(p) flReg.WriteNumber(p.QuanHuyen) = "0" Or p.QuanHuyen = "").FirstOrDefault()
        If itemChuaXacDinh IsNot Nothing Then
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td> Chưa cập nhật</td>"
            litList += "<td style='text-align:center;'>" & itemChuaXacDinh.SoLuong & "</td>"
            litList += "</tr>"
            n += 1
        End If
        Dim itemXacDinh = lstBC.Where(Function(p) p.QuanHuyen <> "").Count()
        If itemXacDinh > 0 Then
            For Each Cr As CMS_SpecializeInfo In arrBC
                Dim item As CMS_BC_WorkInfo = lstBC.Where(Function(p) flReg.WriteNumber(p.QuanHuyen) = Cr.Specialize_ID).FirstOrDefault()
                litList += "<tr style='vertical-align:middle;'>"
                litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
                litList += "<td>" & Cr.Specialize_Name & "</td>"
                If item IsNot Nothing Then
                    litList += "<td style='text-align:center;'>" & item.SoLuong & "</td>"
                Else
                    litList += "<td style='text-align:center;'>0</td>"
                End If
                litList += "</tr>"
                n += 1
            Next
        End If
        litList += "</table>"
        Return litList
    End Function


    Public Function RPT_LoaiHinhDN(pid As Integer, tp As String, px As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_LoaiHinhDN)
        lstBC = ObjController.CMS_RPT_LoaiHinhDN(pid, tp, flReg.WriteNumber(px), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))
        Dim arrQuanHuyen = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, tp)
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tên đơn vị</td>"
        litList += "<td class='hdTitle' style='text-align:center;with:15%;'>Chưa cập nhật</td>"
        litList += "<td class='hdTitle' style='text-align:center;with:15%;'>Nhà nước</td>"
        litList += "<td class='hdTitle' style='text-align:center;with:15%;'>Ngoài nhà nước</td>"
        litList += "<td class='hdTitle' style='text-align:center;with:15%;'>Vốn nước ngoài</td>"
        litList += "<td class='hdTitle' style='text-align:center;with:15%;'>Khác</td>"
        litList += "</tr>"

        n = 1
        For Each Cr As CMS_RegionalXPInfo In arrQuanHuyen
            Dim item As CMS_BC_LoaiHinhDN = lstBC.Where(Function(p) flReg.WriteNumber(p.QuanHuyen) = Cr.Regional_ID).FirstOrDefault()
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>" & Cr.Regional_Name & "</td>"
            If item IsNot Nothing Then
                litList += "<td style='text-align:center;with:15%;'>" & flReg.WriteNumber(item.ChuaCapNhat) & "</td>"
                litList += "<td style='text-align:center;with:15%;'>" & flReg.WriteNumber(item.NhaNuoc) & "</td>"
                litList += "<td style='text-align:center;with:15%;'>" & flReg.WriteNumber(item.NgoaiNhaNuoc) & "</td>"
                litList += "<td style='text-align:center;with:15%;'>" & flReg.WriteNumber(item.ODA) & "</td>"
                litList += "<td style='text-align:center;with:15%;'>" & flReg.WriteNumber(item.Khac) & "</td>"
            Else
                litList += "<td style='text-align:center;with:15%;'>0</td>"
                litList += "<td style='text-align:center;with:15%;'>0</td>"
                litList += "<td style='text-align:center;with:15%;'>0</td>"
                litList += "<td style='text-align:center;with:15%;'>0</td>"
                litList += "<td style='text-align:center;with:15%;'>0</td>"
            End If
            litList += "</tr>"
            n += 1
        Next
        litList += "</table>"
        Return litList
    End Function

    Public Function RPT_TUVAN(pid As Integer, us As String, tp As String, qh As String, fromd As String, tod As String, kieuTime As String) As String
        Dim lstBC As List(Of CMS_BC_WorkInfo)
        lstBC = ObjController.CMS_RPT_TUVAN(pid, tp, flReg.WriteNumber(qh), flReg.RptDate(fromd, True), flReg.RptDate(tod, False), flReg.WriteNumber(kieuTime))

        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0'>"
        litList += "<tr style='color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;' class='hdTitle'>STT</td>"
        litList += "<td class='hdTitle'>Tư vấn</td>"
        litList += "<td class='hdTitle' style='text-align:center;'>Số lượng</td>"
        litList += "</tr>"

        n = 1
        Dim itemChuaXacDinh As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "0" Or p.QuanHuyen = "").FirstOrDefault()
        If itemChuaXacDinh IsNot Nothing Then
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
            litList += "<td>Chưa cập nhật</td>"
            litList += "<td style='text-align:center;'>" & itemChuaXacDinh.SoLuong & "</td>"
            litList += "</tr>"
            n += 1
        End If

        litList += "<tr style='vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
        litList += "<td>Lên lịch</td>"
        Dim item1 As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "1").FirstOrDefault()
        If item1 IsNot Nothing Then
            litList += "<td style='text-align:center;'>" & item1.SoLuong & "</td>"
        Else
            litList += "<td style='text-align:center;'>0</td>"
        End If
        litList += "</tr>"
        n += 1


        litList += "<tr style='vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
        litList += "<td>Dang diễn ra</td>"
        Dim item2 As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "2").FirstOrDefault()
        If item2 IsNot Nothing Then
            litList += "<td style='text-align:center;'>" & item2.SoLuong & "</td>"
        Else
            litList += "<td style='text-align:center;'>0</td>"
        End If
        litList += "</tr>"
        n += 1

        litList += "<tr style='vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
        litList += "<td>Đã hoàn thành</td>"
        Dim item3 As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "3").FirstOrDefault()
        If item3 IsNot Nothing Then
            litList += "<td style='text-align:center;'>" & item3.SoLuong & "</td>"
        Else
            litList += "<td style='text-align:center;'>0</td>"
        End If
        litList += "</tr>"
        n += 1

        litList += "<tr style='vertical-align:middle;'>"
        litList += "<td style='width:5%;text-align:center;'>" & n & "</td>"
        litList += "<td>Hủy</td>"
        Dim item4 As CMS_BC_WorkInfo = lstBC.Where(Function(p) p.QuanHuyen = "3").FirstOrDefault()
        If item4 IsNot Nothing Then
            litList += "<td style='text-align:center;'>" & item4.SoLuong & "</td>"
        Else
            litList += "<td style='text-align:center;'>0</td>"
        End If
        litList += "</tr>"
        n += 1

        litList += "</table>"
        Return litList
    End Function
End Class

Public Module Moduler
    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, Thread.CurrentPrincipal.Identity.Name)
                    Return If(user, New UserInfo())
                End If
                Return New UserInfo()
            ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                If HttpContext.Current.Request.IsAuthenticated Then
                    user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                    HttpContext.Current.Items("UserInfo") = user
                End If
            End If
            user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
            Return If(user, New UserInfo())
        End Get
    End Property
End Module