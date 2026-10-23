 <%@ WebService Language="VB" Class="common" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports DotNetNuke.CUNG
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication
Imports DotNetNuke.Security.Roles
<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class AuthHeader
    Inherits SoapHeader
    Public userLogin As String
    Public password As String
End Class
Public Class common
    Inherits System.Web.Services.WebService
    Public Authentication As AuthHeader
    Dim workCtl As New WorkController
    Dim cmsCtl As New CmsController
    Dim pid As Integer = 0
    Dim arr As New ArrayList
    Dim strCache As String = ""
#Region "Chart"

    Private Function ValuessFromDropdown(dr As DropDownList) As String
        ValuessFromDropdown = ""
        For Each item As ListItem In dr.Items
            If String.IsNullOrEmpty(item.Value) = False And item.Value.ToString() <> "0" Then
                ValuessFromDropdown += "" & item.Value & ","
            End If
        Next
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ChartData(type As String, tinhTp As String, quanHuyen As String, yearId As String) As String

        Dim isNow As Boolean = True
        Dim drQuanHuyen As New DropDownList
        Dim drPhuongXa As New DropDownList
        Call flDic.LoadRegionalQH(pid, drQuanHuyen, tinhTp, "--- Quận/huyện ---", "QH")
        If quanHuyen <> "" Then
            Call flDic.LoadRegionalXP(pid, drPhuongXa, quanHuyen, "--- Phường/xã ---", "XP")
        End If

        Dim arrData As New ArrayList
        Dim cInfo As New ChartMobileInfo
        Select Case type
            Case "1" 'co viec lam
                If quanHuyen = 0 Then
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drQuanHuyen), yearId, isNow, "2")
                        For Each item As ListItem In drQuanHuyen.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                Else
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drPhuongXa), yearId, isNow, "2")
                        For Each item As ListItem In drPhuongXa.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                End If
            Case "2" 'that nghiep
                If quanHuyen = 0 Then
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drQuanHuyen), yearId, isNow, "3")
                        For Each item As ListItem In drQuanHuyen.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                Else
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drPhuongXa), yearId, isNow, "3")
                        For Each item As ListItem In drPhuongXa.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                End If
            Case "3" 'hoat dong kinh te
                If quanHuyen = 0 Then
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drQuanHuyen), yearId, isNow, "11")
                        For Each item As ListItem In drQuanHuyen.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                Else
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drPhuongXa), yearId, isNow, "11")
                        For Each item As ListItem In drPhuongXa.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                End If
            Case "4" 'ko hoat dong kinh te
                If quanHuyen = 0 Then
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drQuanHuyen), yearId, isNow, "5")
                        For Each item As ListItem In drQuanHuyen.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                Else
                    For Each rpt As ChartInfo In New CungController().CMS_Chart_DataHC(flReg.WebConfig("tp"), tinhTp, quanHuyen, ValuessFromDropdown(drPhuongXa), yearId, isNow, "5")
                        For Each item As ListItem In drPhuongXa.Items
                            If item.Value = rpt.ID Then
                                cInfo = New ChartMobileInfo
                                cInfo.Name = item.Text
                                cInfo.Data = rpt.Num1
                                arrData.Add(cInfo)
                            End If
                        Next
                    Next
                End If
        End Select
        Return JsonConvert.SerializeObject(ConvertListAPI(arrData, False), SettingAPI())
    End Function
#End Region
#Region "Home"

    Private Function LinkNganhNghe(id As String, idN As String) As String
        LinkNganhNghe = flCache.GetCache("LinkNganhNghe_" & idN & "_" & id) & ""
        If LinkNganhNghe = "" Then
            Dim Str = id.Split(",")
            Dim careInfo As CMS_CareerInfo
            For i As Integer = 0 To Str.Length - 1
                careInfo = workCtl.CMS_Career_Get(pid, Str(i))
                If IsNothing(careInfo) = False Then
                    LinkNganhNghe += "<a href=""" & WORK.flCheck.GetHomeLinkJob(careInfo.Career_Name, careInfo.Career_Code) & """ class=""job_value text_pink"">" & careInfo.Career_Name & "</a>, "
                End If
            Next
            If LinkNganhNghe <> "" Then LinkNganhNghe = LinkNganhNghe.Substring(0, LinkNganhNghe.LastIndexOf(","))
            flCache.SetCache("LinkNganhNghe_" & idN & "_" & id, LinkNganhNghe, SecondCache.M1)
        End If
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function AppSetting() As String
        Dim obj = New AppConfig
        obj.MaDonVi = flReg.WebConfig("TinhTP")
        obj.FullName = flReg.WebConfig("TenDonVi")
        obj.ShortName = flReg.WebConfig("TenVietTat")
        obj.MainDomain = flReg.WebConfig("TenMien")
        obj.FileDomain = flReg.WebConfig("FileDomain")
        obj.Email = flReg.WebConfig("Email")
        Return JsonConvert.SerializeObject(ConvertObjectAPI(obj), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeWorksList(flag As Integer, top As Integer) As String
        strCache = "APP_Home_WorksList_" & flag
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = workCtl.CMS_Work_List_Home(pid, flag, top, "")
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Dim arrTmp As New ArrayList
        For Each cr As CMS_WorkInfo In arr
            cr.ImageURL = flReg.ImgSRC(WORK.flCheck.Business_Logo(cr.PortalID, cr.Business_ID))
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
            cr.HinhThucLamViec = WORK.flCheck.TypeOf_Name(pid, cr.TypeOf_ID)
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.NganhNghe = LinkNganhNghe(cr.Career_ID, cr.ID)
            cr.ChucVu = flDic.Position_Name(pid, cr.LevelDesired_ID)
            cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
            cr.GioiTinh = WORK.flCheck.GioiTinh(cr.Gender)
            cr.ViTriTuyenDung = WORK.flCheck.JobPlace_Name(pid, cr.JobPlace)
            arrTmp.Add(cr)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arrTmp), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeNewsList(flag As Integer, top As Integer) As String
        strCache = "APP_HomeNewsList_" & flag
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = cmsCtl.CMS_News_HomeMobile(pid, pid, flag, "", 0, top, False)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeSlideList(top As Integer) As String
        strCache = "APP_HomeSlideList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = cmsCtl.DM_Slider_List_Home(pid, top)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeVideosList(top As Integer) As String
        strCache = "APP_HomeVideosList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = cmsCtl.CMS_Media_List_Home(pid, pid, flConnect.IsLang, 3668, mediaType.Video, 1, top)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeJobUserList(top As Integer) As String
        strCache = "APP_HomeJobUserList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = workCtl.CMS_JobUser_List_Home(pid, "", 1, top, "", "", "", "0")
            For Each cr As CMS_JobUserInfo In arr
                cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
                cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
                cr.NgayDangTin = flReg.ReadDate(cr.EndDate, False)
                cr.TrinhDoChuyenMon = flDic.Education_Name(pid, cr.Level_ID)
                cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
                cr.NganhNghe = CareerMultiName(cr.Career_ID)
                cr.NhuCaulamViec = WORK.flCheck.Needs_Name(pid, cr.Needs_ID)
                cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
                cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
            Next
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeBusinessList(top As Integer) As String
        strCache = "APP_HomeBusinessList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = workCtl.CMS_Business_List_Home(pid, pid, 1, top)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeDocumentList(top As Integer) As String
        strCache = "APP_HomeDocumentList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = cmsCtl.CMS_Document_List_Home(pid, "", "", "", "", "", 1, top)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeAdvertiseList(top As Integer) As String
        strCache = "APP_HomeAdvertiseList_" & top
        arr = CacheList(strCache)
        If arr.Count <= 0 Then
            arr = cmsCtl.CMS_Advertise_List_Home(pid, pid, 1, top)
            flCache.SetCache(strCache, arr, SecondCache.M2)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GioiThieuTrungTam() As String
        Dim wInfo As CMS_NewsCategoriesInfo
        strCache = "WEB_GioiThieuTrungTam"
        wInfo = flCache.GetCache(strCache)
        If wInfo Is Nothing Then
            wInfo = cmsCtl.CMS_NewsCategories_Get(pid, 3676)
            flCache.SetCache(strCache, wInfo, SecondCache.M2)
        End If
        If wInfo IsNot Nothing Then
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo.Description), SettingAPI())
        Else
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo), SettingAPI())
        End If
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CoCauToChucTrungTam() As String
        Dim wInfo As CMS_NewsCategoriesInfo
        strCache = "WEB_CoCauToChucTrungTam"
        wInfo = flCache.GetCache(strCache)
        If wInfo Is Nothing Then
            wInfo = cmsCtl.CMS_NewsCategories_Get(pid, 3706)
            flCache.SetCache(strCache, wInfo, SecondCache.M2)
        End If
        If wInfo IsNot Nothing Then
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo.Description), SettingAPI())
        Else
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo), SettingAPI())
        End If
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BanDoTrungTam() As String
        Dim wInfo As CMS_NewsCategoriesInfo
        strCache = "WEB_BanDoTrungTam"
        wInfo = flCache.GetCache(strCache)
        If wInfo Is Nothing Then
            wInfo = cmsCtl.CMS_NewsCategories_Get(pid, 3707)
            flCache.SetCache(strCache, wInfo, SecondCache.M2)
        End If
        If wInfo IsNot Nothing Then
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo.Description), SettingAPI())
        Else
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo), SettingAPI())
        End If
    End Function
#End Region
#Region "News"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsSearch(tuKhoa As String, chuyenMuc As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        arr = cmsCtl.CMS_News_List_Search_All(pid, tuKhoa, chuyenMuc, pid, soTrangHienTai, soBanGhiTrenTrang, False)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NewsDetail(id As String) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cmsCtl.CMS_News_Get(pid, id)), SettingAPI())
    End Function
#End Region
#Region "FAQ"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FAQQuestionSearch(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        Dim arr As New ArrayList
        Dim aswInfo As CMS_FAQAnswersInfo
        For Each cr As CMS_FAQQuestionsInfo In New CmsController().CMS_FAQQuestions_List_Search(pid, tuKhoa, "", 1, soTrangHienTai, soBanGhiTrenTrang, "", QuestionStatus.DaDuyet)
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
    Public Function FAQAddQuestion(hoTen As String, email As String, phone As String, noiDung As String) As String
        Dim objInfo As New CMS_FAQQuestionsInfo
        Dim objController As New CmsController
        objInfo.Name = hoTen & ""
        objInfo.Email = email
        objInfo.Phone = phone
        objInfo.Contents = flReg.RemoveScript(noiDung)
        objInfo.PortalId = pid
        objInfo.UpdateDate = Now
        objInfo.SendDate = Now
        objInfo.CreateDate = Now
        objInfo.Status = 0
        objInfo.FAQID = ""
        objInfo.IsPublic = False
        objController.CMS_FAQQuestions_Add(pid, objInfo)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(objInfo), SettingAPI())
    End Function
#End Region
#Region "Work"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkSearch(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, tuKhoa As String, viTri As String, mucLuong As String, kinhNghiem As String, nganhNghe As String, trinhDo As String, gioiTinh As Integer, tinhTp As Integer) As String
        arr = workCtl.CMS_Work_List_Pages(pid, soTrangHienTai, soBanGhiTrenTrang, nganhNghe, tinhTp, trinhDo, viTri, mucLuong, kinhNghiem, gioiTinh, tuKhoa, 0)
        For Each cr As CMS_WorkInfo In arr
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
            cr.HanNopHoSo = flReg.ReadDate(cr.EndDate, False)
            cr.HinhThucLamViec = WORK.flCheck.TypeOf_Name(pid, cr.TypeOf_ID)
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.NganhNghe = LinkNganhNghe(cr.Career_ID, cr.ID)
            cr.ChucVu = flDic.Position_Name(pid, cr.LevelDesired_ID)
            cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
            cr.GioiTinh = WORK.flCheck.GioiTinh(cr.Gender)
            cr.ViTriTuyenDung = WORK.flCheck.JobPlace_Name(pid, cr.JobPlace)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function WorkDetail(id As String) As String
        Dim cr As CMS_WorkInfo = workCtl.CMS_Work_Get_ID(pid, id)
        If IsNothing(cr) = False Then
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
            cr.HanNopHoSo = flReg.ReadDate(cr.EndDate, False)
            cr.HinhThucLamViec = WORK.flCheck.TypeOf_Name(pid, cr.TypeOf_ID)
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.NganhNghe = LinkNganhNghe(cr.Career_ID, cr.ID)
            cr.ChucVu = flDic.Position_Name(pid, cr.LevelDesired_ID)
            cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
            cr.GioiTinh = WORK.flCheck.GioiTinh(cr.Gender)
            cr.ViTriTuyenDung = WORK.flCheck.JobPlace_Name(pid, cr.JobPlace)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function BussinessDetail(id As String) As String
        Dim cr As CMS_BusinessInfo = workCtl.CMS_Business_Get_ID(pid, id)
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cr), SettingAPI())
    End Function

#End Region
#Region "JobUser"

    Private Function CareerMultiName(id As String) As String
        CareerMultiName = ""
        Dim str() As String = id.Split(",")
        For i = 0 To str.Count - 1
            If String.IsNullOrEmpty(str(i)) = False Then
                CareerMultiName += WORK.flCheck.Career_Name(pid, str(i)) & IIf(i = str.Count - 1, "", ", ")
            End If
        Next
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserSearch(tuKhoa As String, kieuSapXep As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, doanhNghiep As String, mucLuong As String, kinhNghiem As String, tinhTp As String, quanHuyen As String) As String
        arr = workCtl.CMS_JobUser_List_Search(pid, tuKhoa, kieuSapXep, soTrangHienTai, soBanGhiTrenTrang, "true", doanhNghiep, mucLuong, kinhNghiem, tinhTp, quanHuyen)
        For Each cr As CMS_JobUserInfo In arr
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
            cr.NgayDangTin = flReg.ReadDate(cr.EndDate, False)
            cr.TrinhDoChuyenMon = flDic.Education_Name(pid, cr.Level_ID)
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.NganhNghe = CareerMultiName(cr.Career_ID)
            cr.NhuCaulamViec = WORK.flCheck.Needs_Name(pid, cr.Needs_ID)
            cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserDetail(id As String) As String
        Dim cr As CMS_JobUserInfo = workCtl.CMS_JobUser_Get_ID(pid, id)
        If IsNothing(cr) = False Then
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.BangCap = flDic.Education_Name(pid, cr.Level_ID)
            cr.NgayDangTin = flReg.ReadDate(cr.EndDate, False)
            cr.TrinhDoChuyenMon = flDic.Education_Name(pid, cr.Level_ID)
            cr.MucLuong = WORK.flCheck.Salary_Name(pid, cr.Salary_ID)
            cr.NganhNghe = CareerMultiName(cr.Career_ID)
            cr.NhuCaulamViec = WORK.flCheck.Needs_Name(pid, cr.Needs_ID)
            cr.TenTinhTP = flDic.RegionalName(pid, cr.TinhTP, "")
            cr.SoNamKinhNghiem = WORK.flCheck.Experience_Name(pid, cr.Experience_ID)
        End If
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cr), SettingAPI())
    End Function

#End Region
#Region "DoanhNghiep"


#End Region
#Region "Media"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VideoList(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        arr = cmsCtl.CMS_Media_List_Home(pid, pid, flConnect.IsLang, "", mediaType.Video, soTrangHienTai, soBanGhiTrenTrang)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function VideoDetail(id As String) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cmsCtl.CMS_Media_Get(pid, id)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function AlbumList(soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, tuKhoa As String) As String
        arr = New ArrayList
        Dim drCate As New DropDownList
        Call CMS.flFunction.LoadCategories(drCate, pid, "admin", CategoryType.Album)
        For Each Cr As CMS_NewsInfo In cmsCtl.CMS_News_List_Search_All(pid, tuKhoa, drCate.SelectedValue, pid, soTrangHienTai, soBanGhiTrenTrang, True)
            For Each Ck As CMS_MediaInfo In New CmsController().CMS_Media_Get_By_News_ID(Cr.PortalId, Cr.NewId)
                arr.Add(Ck)
            Next
        Next
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function AlbumDetail(id As Integer) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(cmsCtl.CMS_Media_Get(pid, id)), SettingAPI())
    End Function
#End Region
#Region "VanBan"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DocumentList(tuKhoa As String, linhVucVanBan As String, loaiVanBan As String, coQuanBanHanh As String, nhomVanBan As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        Dim nvb As String = ""
        If nhomVanBan = "1" Then
            nvb = flReg.SettingValue(flConnect.DmConnect, "cms", "DOC_LIST_GROUP", "van-ban")
        Else
            nvb = flReg.SettingValue(flConnect.DmConnect, "cms", "DOC_LIST_GROUP", "van-ban-quy-pham-phap-luat")
        End If
        arr = cmsCtl.CMS_Document_List_Home(pid, tuKhoa, linhVucVanBan, loaiVanBan, coQuanBanHanh, nvb, soTrangHienTai, soBanGhiTrenTrang)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region

#Region "ThanhVien"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangNhap(userName As String, passWord As String) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(LoginUser(userName, passWord)), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DangKy(hoDem As String, ten As String, email As String, soDienThoai As String, passWord As String, role As Int16) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(CreateUser(hoDem, ten, email, soDienThoai, passWord, role)), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ThongTinTaiKhoan(userName As String, passWord As String) As String
        Return JsonConvert.SerializeObject(ConvertObjectAPI(DetailUser(userName, passWord)), SettingAPI())
    End Function

    Private Function DetailUser(usName As String, passWord As String) As UserApp
        Dim objUS = New UserController().ValidateUser(pid, usName, passWord, "DNN", GetPortalSettings.PortalName, AuthenticationLoginBase.GetIPAddress(), Status)
        Dim obj = New UserController().GetUser(pid, objUS.UserID)
        Dim usApp As New UserApp
        If IsNothing(obj) = False Then
            usApp.FullName = obj.DisplayName
            usApp.Email = obj.Email
            usApp.PhoneNumber = obj.Profile.Telephone
            usApp.Avatar = obj.Profile.Photo
        End If
        Dim ubj = flDnn.CMSUserPortal_Get_By_User("", obj.Username, "work", 0)
        If IsNothing(ubj) = False Then
            usApp.Address = ubj.Address
            usApp.DateOfBirth = flReg.ReadDate(ubj.DateOfBirth, False)
            usApp.Gender = ubj.Gender
            usApp.PhoneNumber = ubj.Telephone
            usApp.CCCD = ubj.CMND
            usApp.Address = ubj.Address
        End If
        Return usApp
    End Function
#End Region
#Region "DanhMuc"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachChuyenMuc() As String
        If IsNothing(flCache.GetCache("NewsCategories_Get_By_ParentId" & pid & "admin" & CategoryType.News)) = True Then
            arr = cmsCtl.CMS_NewsCategories_Get_By_ParentId(pid, pid, flConnect.IsLang, "admin", CategoryType.News, 0)
            flCache.SetCache("NewsCategories_Get_By_ParentId" & pid & "admin" & CategoryType.News, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("NewsCategories_Get_By_ParentId" & pid & "admin" & CategoryType.News), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachTinhTP() As String
        If IsNothing(flCache.GetCache("CMS_RegionalTP_List_" & pid)) Then
            arr = flDnn.CMS_Regional_List_Parent_Null(pid)
            flCache.SetCache("CMS_RegionalTP_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_RegionalTP_List_" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function TenTinhTP(id As String) As String
        Dim wInfo = flDnn.CMS_Regional_Get(pid, id)
        If wInfo IsNot Nothing Then
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo.Regional_Name), SettingAPI())
        Else
            Return JsonConvert.SerializeObject(ConvertObjectAPI(wInfo), SettingAPI())
        End If
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachQuanHuyen(tinhTp As String) As String
        If IsNothing(flCache.GetCache("CMS_RegionalQH_List_" & pid & tinhTp)) Then
            arr = flDnn.CMS_Regional_Get_By_CMS_Regional(pid, tinhTp)
            flCache.SetCache("CMS_RegionalQH_List_" & pid & tinhTp, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_RegionalQH_List_" & pid & tinhTp), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachMucLuong() As String
        If IsNothing(flCache.GetCache("CMS_Salary_List_" & pid)) Then
            arr = workCtl.CMS_Salary_List(pid)
            flCache.SetCache("CMS_Salary_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_Salary_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachKinhNghiem() As String

        If IsNothing(flCache.GetCache("CMS_Experience_List_" & pid)) Then
            arr = workCtl.CMS_Experience_List(pid)
            flCache.SetCache("CMS_Experience_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_Experience_List_" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachTinhChatCongViec() As String
        If IsNothing(flCache.GetCache("CMS_TypeOf_List_" & pid)) Then
            arr = workCtl.CMS_TypeOf_List(pid)
            flCache.SetCache("CMS_TypeOf_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_TypeOf_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachViTriTuyenDung() As String
        If IsNothing(flCache.GetCache("CMS_JobPlace_List_" & pid)) Then
            arr = workCtl.CMS_JobPlace_List_parent(pid)
            flCache.SetCache("CMS_JobPlace_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_JobPlace_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachDoanhNghiep(tinhTp As String, quanHuyen As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer) As String
        arr = workCtl.CMS_Business_List_By_TinhTP(pid, pid, tinhTp, quanHuyen, soTrangHienTai, soBanGhiTrenTrang)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachGioiTinh() As String
        Dim arr As New ArrayList
        Dim objGT As New GioiTinhInfo
        objGT.Name = "Nam"
        objGT.ID = 1
        arr.Add(objGT)
        objGT = New GioiTinhInfo
        objGT.Name = "Nữ"
        objGT.ID = 0
        arr.Add(objGT)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachTrinhDo() As String
        If IsNothing(flCache.GetCache("CMS_Education_List_" & pid)) Then
            arr = flDnn.CMS_Education_List(pid)
            flCache.SetCache("CMS_Education_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_Education_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachLinhVucVanBan() As String
        If IsNothing(flCache.GetCache("CMS_DocField_List_" & pid)) Then
            arr = cmsCtl.CMS_DocField_List(pid, pid)
            flCache.SetCache("CMS_DocField_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_DocField_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachLoaiVanBan() As String
        If IsNothing(flCache.GetCache("CMS_DocType_List_" & pid)) Then
            arr = cmsCtl.CMS_DocType_List(pid, pid)
            flCache.SetCache("CMS_DocType_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_DocType_List_" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachCoQuanBanHanh() As String
        If IsNothing(flCache.GetCache("CMS_DocUnit_List_" & pid)) Then
            arr = cmsCtl.CMS_DocUnit_List(pid, pid)
            flCache.SetCache("CMS_DocUnit_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_DocUnit_List_" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachChucVu() As String
        If IsNothing(flCache.GetCache("CMS_Position_List_" & pid)) Then
            arr = flDnn.CMS_Position_List(pid)
            flCache.SetCache("CMS_Position_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_Position_List_" & pid), ArrayList)
        End If

        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachNhuCau() As String
        If IsNothing(flCache.GetCache("CMS_Needs_List_" & pid)) Then
            arr = workCtl.CMS_Needs_List(pid)
            flCache.SetCache("CMS_Needs_List_" & pid, arr, SecondCache.M2)
        Else
            arr = CType(flCache.GetCache("CMS_Needs_List_" & pid), ArrayList)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhSachNganhNghe() As String
        arr = workCtl.CMS_Career_List(pid)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhMucVeTinh() As String
        arr = New INSU.InsuController().CMS_Satellite_List(pid, flReg.WebConfig("TinhTP"))
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhMucTuVan() As String
        Dim arr As New ArrayList
        Dim dmc As New DanhMucChungBHTN
        dmc.Id = 1
        dmc.Name = "Tư vấn việc làm"
        arr.Add(dmc)
        dmc = New DanhMucChungBHTN
        dmc.Id = 21
        dmc.Name = "Tư vấn học nghề"
        arr.Add(dmc)
        dmc = New DanhMucChungBHTN
        dmc.Id = 3
        dmc.Name = "Khác"
        arr.Add(dmc)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DanhMucTrangThaiHoSo() As String
        'DangSoan = -1
        'DaNop = 0
        'TiepNhan
        'TraLai
        Dim arr As New ArrayList
        Dim dmc As New DanhMucChungBHTN
        dmc.Id = -1
        dmc.Name = "Đang soạn"
        arr.Add(dmc)
        dmc = New DanhMucChungBHTN
        dmc.Id = 0
        dmc.Name = "Đã nộp"
        arr.Add(dmc)
        dmc = New DanhMucChungBHTN
        dmc.Id = 1
        dmc.Name = "Tiếp nhận"
        arr.Add(dmc)
        dmc = New DanhMucChungBHTN
        dmc.Id = 2
        dmc.Name = "Trả lại"
        arr.Add(dmc)
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region
#Region "Common"

    Private Function CreateUser(hoDem As String, ten As String, email As String, soDienThoai As String, passWord As String, role As Int16) As UserApp
        Dim usApp As New UserApp
        Try
            Dim ctlRole As New RoleController
            Dim roInfo As New RoleInfo
            Dim objUser As New UserInfo()
            objUser.AffiliateID = Null.NullInteger
            objUser.Username = email.Trim
            objUser.Email = email.Trim
            objUser.LastName = ten.Trim
            objUser.FirstName = hoDem.Trim
            objUser.DisplayName = hoDem.Trim & " " & ten.Trim
            objUser.IsSuperUser = False
            objUser.PortalID = pid
            objUser.Membership.Password = passWord
            objUser.Membership.Approved = True
            objUser.Membership.UpdatePassword = False
            objUser.Membership.IsDeleted = False
            objUser.Profile.Country = ""
            objUser.Profile.Street = ""
            objUser.Profile.City = ""
            objUser.Profile.Region = ""
            objUser.Profile.PostalCode = ""
            objUser.Profile.Unit = ""
            objUser.Profile.Telephone = soDienThoai
            objUser.Profile.FirstName = objUser.FirstName
            objUser.Profile.LastName = objUser.LastName
            Dim objCreateStatus As UserCreateStatus = UserController.CreateUser(objUser)

            If objCreateStatus = UserCreateStatus.Success Then
                Dim obj As New CMSUserPortalInfo
                obj.PortalID = 0
                obj.UserName = objUser.Username
                obj.DisplayName = objUser.DisplayName
                obj.Email = objUser.Email
                obj.SubMod = "work"
                obj.ProvinID = flReg.WebConfig("TinhTP")
                obj.DistrictID = 0
                obj.WardID = 0
                obj.Telephone = soDienThoai
                If role = 1 Then
                    obj.RolesID = flReg.GetRolesID("work", "Doanh nghiep")
                    roInfo = ctlRole.GetRoleByName(pid, "business")
                Else
                    obj.RolesID = flReg.GetRolesID("work", "Nguoi lao dong")
                    roInfo = ctlRole.GetRoleByName(pid, "users")
                End If
                flDnn.CMSUserPortal_Add(obj)
                If IsNothing(roInfo) = False Then
                    ctlRole.AddUserRole(pid, objUser.UserID, roInfo.RoleID, Null.NullDate, Null.NullDate)
                End If

                usApp.UserID = objUser.PasswordResetToken.ToString
                usApp.UserName = objUser.Username
                If objUser.IsInRole("business") Then
                    usApp.Role = "bussiness"
                ElseIf objUser.IsInRole("cms") Then
                    usApp.Role = "cms"
                ElseIf objUser.IsInRole("users") Then
                    usApp.Role = "users"
                Else
                    usApp.Role = ""
                End If
                usApp.Message = "Đăng ký tài khoản thành công"

            Else
                usApp.UserID = 0
                usApp.UserName = ""
                usApp.Role = ""
                usApp.Message = "Không thể tạo được tài khoản"
            End If
        Catch ex As Exception
            usApp.UserID = 0
            usApp.Role = ""
            usApp.UserName = ""
            usApp.Message = "Không thể tạo được tài khoản, vui lòng thử lại sau ít phút hoặc liên hệ Ban quản trị"
        End Try
        Return usApp
    End Function
    Private Function ReadErCreateUser(erCode As Integer) As String
        Select Case erCode
            Case UserCreateStatus.UsernameAlreadyExists, UserCreateStatus.DuplicateEmail, UserCreateStatus.DuplicateUserName
                ReadErCreateUser = "Email đã tồn tại trong hệ thống. Vui lòng sử dụng địa chỉ email khác hoặc sử dụng chức năng quên mật khẩu"
            Case UserCreateStatus.UserAlreadyRegistered
                ReadErCreateUser = "Tài khoản đã được đăng ký nhưng chưa được kích hoạt. Vui lòng liên hệ quản trị hoặc kiểm tra hòm thư của bạn"
            Case UserCreateStatus.InvalidEmail, UserCreateStatus.InvalidUserName
                ReadErCreateUser = "Email không hợp lệ"
            Case UserCreateStatus.UnexpectedError, UserCreateStatus.UserRejected
                ReadErCreateUser = String.Format("[{0}] Hệ thống đang bận, vui lòng thử lại sau ít phút", erCode)
            Case UserCreateStatus.BannedPasswordUsed
                ReadErCreateUser = "Tài khoản của bạn đã bị khóa, vui lòng liên hệ quản trị hệ thống"
            Case Else
                ReadErCreateUser = String.Format("[{0}] Hệ thống đang bận, vui lòng thử lại sau ít phút", erCode)
        End Select
    End Function
    Private Function LoginUser(usName As String, passWord As String) As UserApp
        Dim usApp As New UserApp
        Try
            Dim obj = UserController.ValidateUser(pid, usName, passWord, "DNN", GetPortalSettings.PortalName, AuthenticationLoginBase.GetIPAddress(), Status)
            If Status = UserLoginStatus.LOGIN_SUCCESS OrElse Status = UserLoginStatus.LOGIN_SUPERUSER Then
                UserController.UserLogin(pid, obj, GetPortalSettings.PortalName, AuthenticationLoginBase.GetIPAddress(), False)
                'Dim eventArgs As New UserAuthenticatedEventArgs(obj, usName, Status, "DNN")
                'eventArgs.Authenticated = True
                usApp.UserID = obj.PasswordResetToken.ToString
                usApp.UserName = obj.Username
                If obj.IsInRole("business") Then
                    usApp.Role = "bussiness"
                ElseIf obj.IsInRole("cms") Then
                    usApp.Role = "cms"
                ElseIf obj.IsInRole("users") Then
                    usApp.Role = "users"
                Else
                    usApp.Role = ""
                End If
                usApp.Message = "Đăng nhập thành công"
                Return usApp
            ElseIf Status = UserLoginStatus.LOGIN_USERLOCKEDOUT Then
                usApp.UserID = 0
                usApp.UserName = ""
                usApp.Role = ""
                usApp.Message = "Tài khoản bị khóa, vui lòng thử lại sau 10 phút"
                Return usApp
            Else
                usApp.UserID = 0
                usApp.UserName = ""
                usApp.Role = ""
                usApp.Message = "Tài khoản không hợp lệ, vui lòng kiểm tra lại thông tin"
                Return usApp
            End If
        Catch ex As Exception
            usApp.UserID = 0
            usApp.Role = ""
            usApp.UserName = ""
            usApp.Message = "Tài khoản không hợp lệ, vui lòng kiểm tra lại thông tin"
            Return usApp
        End Try
    End Function
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
            'CacheList =
            If IsNothing(flCache.GetCache(strCache)) = False Then
                CacheList = CType(flCache.GetCache(strCache), ArrayList)
            End If
        Catch ex As Exception
            Return CacheList
        End Try
    End Function
    Private Function ConvertListAPI(body As ArrayList, Optional checkAuthor As Boolean = True) As Response
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            'If checkAuthor Then
            '    If Authentication.userLogin <> flReg.WebConfig("API_USER") Or Authentication.password <> flReg.WebConfig("API_PASS") Then
            '        data.data = "Failed to connect to api, check your permissions again!"
            '        data.message = "Error"
            '        data.status = ServiceStatus.FAILED
            '        Return data
            '    End If
            'End If
            If body.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = body
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"

        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Return data

    End Function
    Private Function ConvertObjectAPI(body As Object, Optional checkAuthor As Boolean = True) As Response
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            'If checkAuthor Then
            '    If Authentication.userLogin <> flReg.WebConfig("API_USER") Or Authentication.password <> flReg.WebConfig("API_PASS") Then
            '        data.data = "Failed to connect to api, check your permissions again!"
            '        data.message = "Error"
            '        data.status = ServiceStatus.FAILED
            '        Return data
            '    End If
            'End If
            If body IsNot Nothing Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = body
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"

        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Return data

    End Function
    Private Function SettingAPI() As JsonSerializerSettings
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Return settings
    End Function

    Public Class ChartMobileInfo

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Private _data As String
        Public Property Data() As String
            Get
                Return _data
            End Get
            Set(ByVal value As String)
                _data = value
            End Set
        End Property
    End Class
    Public Class GioiTinhInfo

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Private _id As String
        Public Property ID() As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property
    End Class
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
        Private _fullName As String
        Public Property FullName() As String
            Get
                Return _fullName
            End Get
            Set(ByVal value As String)
                _fullName = value
            End Set
        End Property
        Private _Email As String
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property
        Private _PhoneNumber As String
        Public Property PhoneNumber() As String
            Get
                Return _PhoneNumber
            End Get
            Set(ByVal value As String)
                _PhoneNumber = value
            End Set
        End Property
        Private _CCCD As String
        Public Property CCCD() As String
            Get
                Return _CCCD
            End Get
            Set(ByVal value As String)
                _CCCD = value
            End Set
        End Property
        Private _Address As String
        Public Property Address() As String
            Get
                Return _Address
            End Get
            Set(ByVal value As String)
                _Address = value
            End Set
        End Property
        Private _DateOfBirth As String
        Public Property DateOfBirth() As String
            Get
                Return _DateOfBirth
            End Get
            Set(ByVal value As String)
                _DateOfBirth = value
            End Set
        End Property
        Private _Avatar As String
        Public Property Avatar() As String
            Get
                Return _Avatar
            End Get
            Set(ByVal value As String)
                _Avatar = value
            End Set
        End Property
        Private _Gender As String
        Public Property Gender() As String
            Get
                Return _Gender
            End Get
            Set(ByVal value As String)
                _Gender = value
            End Set
        End Property
    End Class
    Public Class AppConfig
        Private _maDonVi As String
        Public Property MaDonVi() As String
            Get
                Return _maDonVi
            End Get
            Set(ByVal value As String)
                _maDonVi = value
            End Set
        End Property
        Private _FullName As String
        Public Property FullName() As String
            Get
                Return _FullName
            End Get
            Set(ByVal value As String)
                _FullName = value
            End Set
        End Property
        Private _ShortName As String
        Public Property ShortName() As String
            Get
                Return _ShortName
            End Get
            Set(ByVal value As String)
                _ShortName = value
            End Set
        End Property
        Private _MainDomain As String
        Public Property MainDomain() As String
            Get
                Return _MainDomain
            End Get
            Set(ByVal value As String)
                _MainDomain = value
            End Set
        End Property
        Private _fileDomain As String
        Public Property FileDomain() As String
            Get
                Return _fileDomain
            End Get
            Set(ByVal value As String)
                _fileDomain = value
            End Set
        End Property
        Private _Email As String
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property
    End Class
#End Region

End Class

