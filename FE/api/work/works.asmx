<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim objControler As New WorkController
    Dim data As New Response
    Dim str, sAtr() As String
    Dim settings As New JsonSerializerSettings()
    Dim sVal As String, iCount As Integer, sAr() As String
    Private Function readstring(val As String) As Object
        If val = "undefined" Then
            Return Nothing
        Else
            Return val
        End If
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function xoaungvien(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_UngVien_Delete(pid, id)
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailJobUser(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JobUserInfo
        Dim str, sAtr() As String
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try

            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                objControler.CMS_JobUser_Update_View(pid, id)
                obj = objControler.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row chitieths'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/>"
                str += "</div></div></div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-md-8'>"
                str += "<div class='col-md-10 pd0'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Tên CV:&nbsp;" & obj.Title & "</span></div>"
                str += "<div class='col-md-12 pdl0 none'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ:&nbsp;" & flDic.Position_Name(pid, obj.LevelDesired) & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-money icon_16'></i><span class='pl_28'>Mức lương:&nbsp;" & flCheck.Salary_Name(pid, obj.Salary_ID) & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Nơi làm việc:&nbsp;" & flDic.RegionalName(pid, obj.TinhTP, obj.QuanHuyen) & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề:&nbsp;" & CareerMultiName(pid, obj.Career_ID) & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-age icon_16'></i><span class='pl_28'>Nhu cầu tìm việc:&nbsp;" & flCheck.Needs_Name(pid, obj.Needs_ID) & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Ngày đăng tin:&nbsp;" & flReg.ReadDate(obj.StartDate, False) & "</span></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-2'>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += " <div Class='col-md-4'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                If flCheck.CheckInJobView(pid, obj.JobUser_ID, us) Then
                    str += "<span title='Hồ sơ này đã được lưu vào hệ thống' class=""panel-saveuv""><i class=""fa fa-save""></i> Đã lưu hồ sơ</span>"
                Else
                    str += "<a class=""btn btn-white btn-save-job1"" onclick='LuuUngVien(" & pid & ",""" & obj.JobUser_ID & """);' title='Click để lưu lại hồ sơ này' class=""text_grey2"">"
                    str += "<span class=""line-icon""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Lưu hồ sơ</span></span></a>"
                End If
                str += "</div>"
                str += "<div class='clear'></div>"
                If flCheck.CheckInJobInvite(pid, obj.JobUser_ID, flCheck.Business_ID(pid, us)) Then
                    str += "<div class=""pdt15""> <span title='Hồ sơ đã mời' class='panel-moi'><i class=""fa fa-star pdr10"" ></i>Hồ sơ đã mời </span></div>"
                Else
                    str += "<div class=""pdt10""> <a class=""btn btn-white btn-save-job2 "" href=""/business/view/job-invite/jobid/" & id & " title=""Click để mời CV này"" class=""text_grey2"">"
                    str += "<span class=""line-icon ""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Mời ứng viên</span></span></a></div>"
                End If
                str += "<div class=""pdt10""><a class=""btn btn-white btn-save-job1"" onclick='danhsachden(" & pid & ",""" & obj.JobUser_ID & """);' title='Click để Danh sách đen hồ sơ này' class=""text_grey2"">"
                str += "<span class=""line-icon""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Danh sách đen</span></span></a></div>"

                str += "</div></div></div>"
                str += "<div class='clear'></div>"

                str += "<div class='contentjobuser'>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(pid, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(pid, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Mức lương đề xuất: " & flCheck.Salary_Name(0, obj.Salary_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-job-type icon_16'></i><span class='pl_28'>Trình độ học vấn: " & obj.Education.Replace(vbCrLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Kinh nghiệm làm việc: " & obj.CareerGoals.Replace(vbCrLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row none'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, obj.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                'str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin mục tiêu, kỹ năng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Mục tiêu nghề nghiệp: " & flReg.RemoveScript(obj.WorkExperience, False) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kỹ năng sở trường: " & flReg.RemoveScript(obj.SkillsForte, False) & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Private Function CareerMultiName(pid As String, id As String) As String
        CareerMultiName = ""
        Dim str() As String = id.Split(",")
        For i = 0 To str.Count - 1
            If String.IsNullOrEmpty(str(i)) = False Then
                CareerMultiName += flCheck.Career_Name(pid, str(i)) & IIf(i = str.Count - 1, "", ", ")
            End If
        Next
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function LuuUngVien1(pid As Integer, id As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim jInfo As New CMS_JobViewInfo
            jInfo.JobView_ID = flReg.GenKey()
            jInfo.IdKey = id
            jInfo.IdName = ""
            jInfo.UserName = username
            jInfo.CreateDate = Now
            jInfo.IsFlag = JobView.DoanhNghiepLuu
            objControler.CMS_JobView_Add(pid, jInfo)

            'obj = objControler.CMS_JobUser_Get(pid, id)
            'If IsNothing(obj) = False Then
            '    flFunction.PushNotification(pid, TypeNoti.NguoiLaoDong, obj.UserAdmin, "Mã hồ sơ " & "[" & flCheck.ReadCode(obj.ID) & "]" & "đã được " & flCheck.Business_Vn(pid, flCheck.Business_ID(pid, username)) & " lưu lại", "Hồ sơ <b>" & obj.Title & "</b> đã được doanh nghiệp " & flCheck.Business_Vn(pid, flCheck.Business_ID(pid, username)) & "lưu lại", obj.JobUser_ID, FlagNoti.HoSoCV)
            'End If
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "app")
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailJobUserwork(pid As String, id As String, gid As Integer, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JobUserInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objControler.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                SetTrangThaiUV(pid, gid, 1, 1, us)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                str += " <div class='col-md-8'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += " <div class='col-md-4'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                str += "</div>"


                str += "</div>"

                str += "<div class='clear'></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin việc làm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, obj.TinhTP, obj.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, obj.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(obj.StartDate, False) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, obj.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, obj.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, obj.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & obj.Education.Replace(vbLf, "") & "</div>"

                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & obj.CareerGoals.Replace(vbLf, "") & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin mục tiêu, kỹ năng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & obj.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & obj.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailJobUserworkGT(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JobUserInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objControler.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                'SetTrangThaiUV(pid, gid, 1, 1, us)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                str += " <div class='col-md-8'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += " <div class='col-md-4'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                str += "</div>"


                str += "</div>"

                str += "<div class='clear'></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin việc làm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, obj.TinhTP, obj.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, obj.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(obj.StartDate, False) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, obj.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, obj.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, obj.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & obj.Education.Replace(vbLf, "") & "</div>"

                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & obj.CareerGoals.Replace(vbLf, "") & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin mục tiêu, kỹ năng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & obj.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & obj.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailJobUserworkintro(pid As String, id As String, gid As Integer, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JobUserInfo
        Dim obj5 As New CMS_GTVLInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & pid & "_" & gid), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objControler.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_" & pid & "_" & gid, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                'SetTrangThaiUV(pid, gid, 1, 1, us)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                str += " <div class='col-md-8'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += " <div class='col-md-4'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                str += "</div>"
                str += "<div class='col-md-6'><input class=""IsView-" & obj.JobUser_ID & """ type=""checkbox"" value=""Đã xem"" checked=""" & obj5.IsView & """ disabled=""disabled"" id=""b1""><label class='pop-lab' for=""b1"">Đã xem</label></div>"
                str += "<div class='col-md-6'><input class=""IsContact-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" & pid & "','" & gid & "',this,'" & 2 & "','" & us & "');"" value=""Đã liên hệ"" " & IIf(obj5.IsContact = True, "checked='checked'", "") & " id=""b2""><label class='pop-lab' for=""b1"">Đã liên hệ</label></div>"
                str &= "<div class='col-md-6'><input class=""IsInterview-" & obj.JobUser_ID & """ type=""checkbox""  onchange=""setGTVL('" & pid & "','" & gid & "',this,'" & 3 & "','" & us & "');"" value=""Đã phỏng vấn"" " & IIf(obj5.IsInterview = True, "checked='checked'", "") & " id=""b3""><label class='pop-lab' for=""b1"">Đã phỏng vấn</label></div>"
                str &= "<div class='col-md-6'><input class=""IsTest-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" & pid & "','" & gid & "',this,'" & 4 & "','" & us & "');"" value=""Đã test"" " & IIf(obj5.IsTest = True, "checked='checked'", "") & " id=""b4""><label class='pop-lab' for=""b1"">Đã test</label></div>"
                str &= "<div class='col-md-6'><input class=""IsElect-" & obj.JobUser_ID & """ type=""checkbox""  onchange=""setGTVL('" & pid & "','" & gid & "',this,'" & 5 & "','" & us & "');"" value=""Trúng tuyển"" " & IIf(obj5.IsElect = True, "checked='checked'", "") & " id=""b5""><label class='pop-lab' for=""b1"">Trúng tuyển</label></div>"
                str &= "<div class='col-md-6'><input class=""IsCancel-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" & pid & "','" & gid & "',this,'" & 6 & "','" & us & "');"" value=""Từ chối"" " & IIf(obj5.IsCancel = True, "checked='checked'", "") & " id=""b6""><label class='pop-lab' for=""b6"">Từ chối</label></div>"


                str += "</div>"

                str += "<div class='clear'></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin việc làm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, obj.TinhTP, obj.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, obj.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(obj.StartDate, False) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, obj.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, obj.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, obj.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & obj.Education.Replace(vbLf, "") & "</div>"

                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & obj.CareerGoals.Replace(vbLf, "") & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin mục tiêu, kỹ năng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & obj.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & obj.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                Call objControler.CMS_GTVL_Update_Quick(pid, gid, True, obj5.IsContact, obj5.IsInterview, obj5.IsTest, obj5.IsElect, obj5.IsCancel, Now, us)

            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SetTrangThaiUV(pid As String, rid As String, isval As Boolean, isflag As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_RecruitmentInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Call objControler.CMS_GTVL_Update_Acess(pid, rid, isval, isflag, Now, username)
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function setGTVL(pid As String, rid As Integer, isval As Boolean, isflag As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_RecruitmentInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Call objControler.CMS_GTVL_Update_Acess(pid, rid, isval, isflag, Now, username)
            flCache.RemoveCache("CMS_JobUser_Get_" & pid & "_" & rid)
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function saveUV(pid As Integer, phien As String, dnghiep As String, email As String, tel As String, hten As String, nkm As String, nghe As String, cmon As String, dchi As String, gtinh As String, nsinh As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New CMS_UngVienInfo
            obj.UngVien_ID = flReg.GenKey()
            obj.Email = email.Trim()
            obj.Tel = tel.Trim()
            obj.TenDayDu = hten.Trim()
            obj.NguoiTimViec_ID = email.Trim
            obj.LoaiUngVien = LoaiUngVien.ChuaDangKy
            obj.NamKinhNghiem = flReg.WriteNumber(nkm)
            obj.NganhNghe = readstring(nghe)
            obj.ViTriUngTuyen = ""
            obj.TrinhDoChuyenMon = readstring(cmon)
            obj.NgaySinh = flReg.WriteDate(nsinh, False)
            obj.CreatedBy = Now
            obj.DiaChi = readstring(dchi)
            obj.GioiTinh = flReg.WriteStringLess(gtinh)
            obj.PhienGD_ID = phien
            objControler.CMS_UngVien_Add(pid, obj)
            data.data = obj.UngVien_ID
            If dnghiep <> "" Then
                Dim kbj As New CMS_DoanhNghiep_UngVienInfo
                kbj.DNUV_ID = flReg.GenKey()
                kbj.DoanhNghiep_ID = dnghiep
                kbj.PhienGD_ID = phien
                kbj.UngVien_ID = obj.UngVien_ID
                kbj.BanPhongVan = 1
                kbj.TinhTrangPhongVan = 0
                kbj.KetQuaPhongVan = 0
                kbj.ChiTietPhongVan = ""
                kbj.ThuTuPhongVan = 1
                For Each Ck As CMS_WorkInfo In objControler.CMS_TuyenDung_List_Search(pid, "", phien, flCheck.getBusiness_ID(pid, dnghiep), 1)
                    kbj.TuyenDung_ID = Ck.Work_ID
                    kbj.TuyenDungName = Ck.Title
                    Exit For
                Next
                kbj.ViTriDat = ""
                kbj.ViTriDatName = ""
                kbj.CreatedBy = Now
                kbj.UserName = UserInfo.Username
                kbj.UpdatedBy = flReg.DateNull()
                kbj.UserUpdate = ""
                'kbj.IStatus = False
                objControler.CMS_DoanhNghiep_UngVien_Add(pid, kbj)
            End If
        Catch ex As Exception
            data.data = "ER"
            flReg.BugLog(pid, ex.Message, "works")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function values(pid As Integer, isflag As String, tinhTp As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            data.data = WorkHome(pid, isflag, tinhTp)
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Function checkView(id As String) As String
        If IsNothing(sAr) = False Then
            For i As Integer = 0 To sAr.Length - 1
                If sAr(i) = id Then
                    Return "<div class=""txt-xem""><span class=""txt-daxem"">Đã xem</span></div>"
                End If
            Next
        End If
        Return ""
    End Function
    Private Function WorkHome(pid As Integer, isflag As Integer, tinhTp As String) As String
        sVal = "" : iCount = 1
        For Each Cr As CMS_WorkInfo In objControler.CMS_Work_List_Home(pid, isflag, 10, tinhTp)
            sVal += "<div class=""col-md-6"">"
            sVal += "<div class=""box-ct-wh"">"
            sVal += "<div class=""col-sm-3""><div class=""hm-work"">"
            sVal += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Cr.PortalID, Cr.Business_ID)) & """ alt=""Logo"" />"
            sVal += "</div></div>"
            sVal += "<div class=""col-sm-9"">"
            sVal += "<div class=""row-w-work""><a href=""/users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & Cr.Title & "</a></div>"
            sVal += "<div class=""row-w-bus"">" & flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID) & "</div>"
            sVal += "<div class=""row-w-add"">"
            sVal += "<div class=""col-sm-4 pdr0""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>" & flReg.Trimstr((flDic.RegionalName(Cr.PortalID, Cr.TinhTP, Cr.QuanHuyen) & "").Replace("Thành phố", "TP."), 50) & "</div>"
            sVal += "<div class=""col-sm-4 pdr0"" title=""Hạn nộp hồ sơ""><i class=""fa fa-calendar"" aria-hidden=""true""></i>" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
            sVal += "<div class=""col-sm-4 pdr0 w-bookmark"" title=""Kinh nghiệm""><i class=""fa fa-bookmark"" aria-hidden=""true""></i>" & flCheck.Experience_Name(Cr.PortalID, Cr.Experience_ID) & "</div>"
            sVal += "</div>"
            sVal += "</div>"
            sVal += "<div class=""clear""></div>"
            sVal += "</div>"
            sVal += "</div>"
            iCount += 1
            If (iCount Mod 2) Then sVal += "<div class=""clear""></div>"
        Next
        WorkHome = sVal & "<div class=""clear""></div>"
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