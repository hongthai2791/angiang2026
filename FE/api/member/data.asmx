<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim strVal, ltContent, sColor As String
    Dim str, sAtr() As String
    Dim strNew(), strOld(), strEx() As String
    Dim objController As New WorkController
    Dim objWork As New CMS_WorkInfo
    Dim objJobUs As New CMS_JobUserInfo
    Dim busInfo As New CMS_BusinessInfo
    Dim arrTemp As New ArrayList
    Dim i As Integer = 1
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailUngVien(pid As String, id As String, rid As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JobUserInfo
        Dim obj5 As New CMS_RecruitmentInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_UngVien" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objController.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_UngVien" & pid & "_" & id, obj, SecondCache.M5)
            End If
            obj5 = objController.CMS_Recruitment_Get(pid, rid)

            If IsNothing(obj) = False Then
                objController.CMS_JobUser_Update_View(pid, id)
                str += "<div id='detailJobUs'>"
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div>"

                str += "</div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-sm-7'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class=""fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-sm-5'>"
                str += "<div class='col-md-6'><input class=""IsView-" & obj.JobUser_ID & """ type=""checkbox"" value=""Đã xem"" checked=""" & obj5.IsView & """ disabled=""disabled"" id=""b1""><label class='pop-lab' for=""b1"">Đã xem</label></div>"
                str += "<div class='col-md-6'><input class=""IsContact-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setTrangThaiUV('" + pid + "','" + rid + "',this,'2','" & username & "');"" value=""Đã liên hệ"" " & IIf(obj5.IsContact = True, "checked='checked'", "") & " id=""b2""><label class='pop-lab' for=""b1"">Đã liên hệ</label></div>"
                str += "<div class='col-md-6'><input class=""IsInterview-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setTrangThaiUV('" + pid + "','" + rid + "',this,'3','" & username & "');"" value=""Đã phỏng vấn"" " & IIf(obj5.IsInterview = True, "checked='checked'", "") & " id=""b3""><label class='pop-lab' for=""b1"">Đã phỏng vấn</label></div>"
                str += "<div class='col-md-6'><input class=""IsTest-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setTrangThaiUV('" + pid + "','" + rid + "',this,'4','" & username & "');"" value=""Đã test"" " & IIf(obj5.IsTest = True, "checked='checked'", "") & " id=""b4""><label class='pop-lab' for=""b1"">Đã test</label></div>"
                str += "<div class='col-md-6'><input class=""IsElect-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setTrangThaiUV('" + pid + "','" + rid + "',this,'5','" & username & "');"" value=""Trúng tuyển"" " & IIf(obj5.IsElect = True, "checked='checked'", "") & " id=""b5""><label class='pop-lab' for=""b1"">Trúng tuyển</label></div>"
                str += "<div class='col-md-6'><input class=""IsCancel-" & obj.JobUser_ID & """ type=""checkbox"" onchange=""setTrangThaiUV('" + pid + "','" + rid + "',this,'6','" & username & "');"" value=""Từ chối"" " & IIf(obj5.IsCancel = True, "checked='checked'", "") & " id=""b6""><label class='pop-lab' for=""b6"">Từ chối</label></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã CV ứng viên:&nbsp;</span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(obj.ID) & "</b>&nbsp;&nbsp;"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<div class='col-xs-10'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin việc làm</span>"
                str += "</div>"
                str += "<div class='col-xs-2' style='margin-top:-5px;'>"
                str += "</div>"
                str += "<div class='clear'></div>"

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
                str += "</div>"
                Call objController.CMS_Recruitment_Update_Quick(pid, rid, True, obj5.IsContact, obj5.IsInterview, obj5.IsTest, obj5.IsElect, obj5.IsCancel, Now, username)

            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Detailvieclam(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj1 As New CMS_WorkInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj1 = CType(flCache.GetCache("CMS_Work_Get" & pid & "_" & id), CMS_WorkInfo)
            If IsNothing(obj1) Then
                obj1 = objController.CMS_Work_Get(pid, id)
                flCache.SetCache("CMS_Work_Get" & pid & "_" & id, obj1, SecondCache.M5)
            End If
            If IsNothing(obj1) = False Then
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                busInfo = objController.CMS_Business_Get(pid, flCheck.Business_ID(pid, obj1.CreatedUser))
                If IsNothing(busInfo) = False Then
                    With busInfo
                        str += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(0, obj1.Business_ID), 150, 100) & """ alt='" & busInfo.Business_Vn & "'/>"
                    End With
                End If
                str += "</div></div></div>"
                str += "<div class='col-md-10'>"
                str += "<div class='col-md-7'>"
                str += "<h4 class='title_details3 pdl5'>" & obj1.Title & "</h4>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>" & flDic.RegionalName(0, obj1.TinhTP, obj1.QuanHuyen).Replace("Thành phố", "TP.") & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Hạn nộp: <b>" & flReg.ReadDate(obj1.ExpiredDate, False) & "</b></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã tin tuyển dụng: </span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(obj1.ID) & "</b></div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin tuyển dụng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Mức lương: " & IIf(obj1.Salary_ID = "", "Thỏa thuận", flCheck.Salary_Name(0, obj1.Salary_ID)) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm làm việc: " & IIf(obj1.Experience_ID = "", "Không yêu cầu", flCheck.Experience_Name(0, obj1.Experience_ID)) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Số lượng tuyển: " & obj1.Quantity & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-gender icon_16'></i><span class='pl_28'>Giới tính: " & flCheck.GioiTinh(obj1.Gender) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-address icon_16'></i><span class='pl_28'>Vị trí tuyển dụng: " & flCheck.JobPlace_Name(0, obj1.JobPlace) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, obj1.LevelDesired_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj1.Level_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Tính chất công việc: " & flCheck.TypeOf_Name(0, obj1.TypeOf_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, obj1.Career_ID) & "</div>"
                If obj1.SubmissionSend = "1" Then
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp: Nộp trực tiếp</div>"

                ElseIf obj1.SubmissionSend = "2" Then
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp: Nộp qua Email</div>"

                Else
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp:" & obj1.SubmissionSend & "</div>"
                End If

                str += "</div></div></div>"
                str += "<div Class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin yêu cầu</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Mô tả công việc: </br>&nbsp&nbsp" & obj1.Description.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quyền lợi người lao động: </br>&nbsp&nbsp" & obj1.Benefit.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Yêu cầu công việc: </br>&nbsp&nbsp" & obj1.Requirement.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Yêu cầu hồ sơ: </br>&nbsp&nbsp" & obj1.RequirementsProfile.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin liên hệ</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                busInfo = objController.CMS_Business_Get(pid, flCheck.Business_ID(pid, obj1.CreatedUser))
                If IsNothing(busInfo) = False Then
                    With busInfo
                        str += "<div class='col-md-12 wd-row'>Đơn vị: <b>" & busInfo.Business_Vn & "</b></div>"
                    End With
                End If
                str += "<div class='col-md-12 wd-row'>Địa chỉ: " & flCheck.Business_Address(0, obj1.Business_ID) & "</div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-4 wd-row'>Người liên hệ: " & obj1.ContactUser & "</div>"
                str += "<div class='col-md-3 wd-row'>Điện thoại: " & obj1.ContactMobile & "</div>"
                str += "<div class='col-md-5 wd-row'>Email liên hệ: " & obj1.ContactEmail & "</div>"
                str += "<div class='clear'></div>"
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
    Public Function DetailUngVien1(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objJobUs = CType(flCache.GetCache("CMS_JobUser_Get_1" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(objJobUs) Then
                objJobUs = objController.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_1" & pid & "_" & id, objJobUs, SecondCache.M5)
            End If
            If IsNothing(objJobUs) = False Then
                objController.CMS_JobUser_Update_View(pid, id)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(objJobUs.PortalID, objJobUs.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(objJobUs.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & objJobUs.Title & "</span></span></div>"
                str += "<div class='col-md-8'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, objJobUs.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, objJobUs.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, objJobUs.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, objJobUs.UserAdmin) & "</div>"
                str += "</div>"
                str += "<div class='col-md-4'>"
                str += "<div class='col-md-12'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã CV:&nbsp;</span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(objJobUs.ID) & "</b>&nbsp;&nbsp;"
                str += "</div>"
                str += "<div class='clear'></div>"
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
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, objJobUs.TinhTP, objJobUs.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, objJobUs.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(objJobUs.StartDate, False) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, objJobUs.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, objJobUs.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, objJobUs.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & flCheck.Experience_Name(0, objJobUs.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, objJobUs.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & objJobUs.Education.Replace(vbLf, "") & "</div>"

                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Yêu cầu hồ sơ: " & objJobUs.CareerGoals.Replace(vbLf, "") & "</div>"
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
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & objJobUs.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & objJobUs.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GetDetailJob(pid As String, idWork As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj1 As New CMS_WorkInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj1 = CType(flCache.GetCache("CMS_Work_Get" & pid & "_" & idWork), CMS_WorkInfo)
            If IsNothing(obj1) Then
                obj1 = objController.CMS_Work_Get(pid, idWork)
                flCache.SetCache("CMS_Work_Get" & pid & "_" & idWork, obj1, SecondCache.M5)
            End If
            If IsNothing(obj1) = False Then
                ltContent += "<div class='col-md-12'>"
                ltContent += "<div class='detail-jobuser'>"
                ltContent += "<div class='row'>"
                ltContent += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                busInfo = objController.CMS_Business_Get(pid, flCheck.Business_ID(pid, obj1.CreatedUser))
                If IsNothing(busInfo) = False Then
                    With busInfo
                        ltContent += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(0, obj1.Business_ID), 150, 100) & """ alt='" & busInfo.Business_Vn & "'/>"
                    End With
                End If
                ltContent += "</div></div></div>"
                ltContent += "<div class='col-md-10'>"
                ltContent += "<div class='col-md-7'>"
                ltContent += "<h4 class='title_details3 pdl5'>" & obj1.Title & "</h4>"
                ltContent += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>" & flDic.RegionalName(0, obj1.TinhTP, obj1.QuanHuyen).Replace("Thành phố", "TP.") & "</span></div>"
                ltContent += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Hạn nộp: <b>" & flReg.ReadDate(obj1.ExpiredDate, False) & "</b></div>"
                ltContent += "<div class='col-md-12 pdl0'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã tin tuyển dụng: </span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(obj1.ID) & "</b></div>"
                ltContent += "</div>"
                ltContent += "<div class='clear'></div>"
                ltContent += "</div></div></div>"
                ltContent += "<div class='clear'></div>"
                ltContent += "<div class='col-md-12'>"
                ltContent += "<div class='detail-jobuser'>"
                ltContent += "<div class='row'>"
                ltContent += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin tuyển dụng</span>"
                ltContent += "</div>"
                ltContent += "<div class='row pdt10'>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Mức lương: " & IIf(obj1.Salary_ID = "", "Thỏa thuận", flCheck.Salary_Name(0, obj1.Salary_ID)) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm làm việc: " & IIf(obj1.Experience_ID = "", "Không yêu cầu", flCheck.Experience_Name(0, obj1.Experience_ID)) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Số lượng tuyển: " & obj1.Quantity & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-gender icon_16'></i><span class='pl_28'>Giới tính: " & flCheck.GioiTinh(obj1.Gender) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-address icon_16'></i><span class='pl_28'>Vị trí tuyển dụng: " & flCheck.JobPlace_Name(0, obj1.JobPlace) & "</div>"

                ltContent += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, obj1.LevelDesired_ID) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj1.Level_ID) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Tính chất công việc: " & flCheck.TypeOf_Name(0, obj1.TypeOf_ID) & "</div>"
                ltContent += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, obj1.Career_ID) & "</div>"
                If obj1.SubmissionSend = "1" Then
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp: Nộp trực tiếp</div>"

                ElseIf obj1.SubmissionSend = "2" Then
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp: Nộp qua Email</div>"

                Else
                    str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp:" & obj1.SubmissionSend & "</div>"
                End If

                ltContent += "</div></div></div>"
                ltContent += "<div Class='clear'></div>"
                ltContent += "<div class='col-md-12'>"
                ltContent += "<div class='detail-jobuser'>"
                ltContent += "<div class='row'>"
                ltContent += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin yêu cầu</span>"
                ltContent += "</div>"
                ltContent += "<div class='row pdt10'>"
                ltContent += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Mô tả công việc: </br>&nbsp&nbsp" & obj1.Description.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                ltContent += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quyền lợi người lao động: </br>&nbsp&nbsp" & obj1.Benefit.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                ltContent += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Yêu cầu công việc: </br>&nbsp&nbsp" & obj1.Requirement.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                ltContent += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Yêu cầu hồ sơ: </br>&nbsp&nbsp" & obj1.RequirementsProfile.Replace(vbLf, "<br/>&nbsp&nbsp") & "</div>"
                ltContent += " </div>"
                ltContent += "</div>"
                ltContent += "</div>"
                ltContent += "<div class='clear'></div>"

                ltContent += "<div class='col-md-12'>"
                ltContent += "<div class='detail-jobuser'>"
                ltContent += "<div class='row'>"
                ltContent += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin liên hệ</span>"
                ltContent += "</div>"
                ltContent += "<div class='row pdt10'>"
                busInfo = objController.CMS_Business_Get(pid, flCheck.Business_ID(pid, obj1.CreatedUser))
                If IsNothing(busInfo) = False Then
                    With busInfo
                        ltContent += "<div class='col-md-12 wd-row'>Đơn vị: <b>" & busInfo.Business_Vn & "</b></div>"
                    End With
                End If
                ltContent += "<div class='col-md-12 wd-row'>Địa chỉ: " & flCheck.Business_Address(0, obj1.Business_ID) & "</div>"
                ltContent += "<div class='clear'></div>"
                ltContent += "<div class='col-md-4 wd-row'>Người liên hệ: " & obj1.ContactUser & "</div>"
                ltContent += "<div class='col-md-3 wd-row'>Điện thoại: " & obj1.ContactMobile & "</div>"
                ltContent += "<div class='col-md-5 wd-row'>Email liên hệ: " & obj1.ContactEmail & "</div>"
                ltContent += "<div class='clear'></div>"
                ltContent += "</div>"
                ltContent += "</div>"
                ltContent += "</div>"
                ltContent += "<div class='clear'></div>"
            Else
                ltContent = "Không có dữ liệu được tìm thấy"
            End If
            strVal = "<div class=""modal-header"">"
            strVal += "<button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>"
            strVal += "<div class=""modal-title"" id=""modalTitle"">Thông tin chi tiết công việc</div>"
            strVal += "</div>"

            data.Data = strVal & "<div class=""modal-body"" id=""modalBody"">" & ltContent & "</div>"
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailBusiness(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj3 As New CMS_BusinessInfo

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj3 = CType(flCache.GetCache("CMS_Business_Get" & pid & "_" & id), CMS_BusinessInfo)
            If IsNothing(obj3) Then
                obj3 = objController.CMS_Business_Get(pid, id)
                flCache.SetCache("CMS_Business_Get" & pid & "_" & id, obj3, SecondCache.M5)
            End If
            If IsNothing(obj3) = False Then
                Str += "<div class='col-md-12'>"
                Str += "<div class='detail-jobuser'>"
                Str += "<div class='row'>"
                Str += "<div class='col-md-2 txt-center box-dn-img'><img src=""" & flReg.ImgSRC(flCheck.Business_Logo(pid, obj3.Business_ID), 140, 100) & """ alt='" & obj3.Business_Vn & "'/></div>"
                Str += "<div class='col-md-10'>"
                str += "<div class='col-sm-12 pdbt10'>MST: <span class='TaxCode'>" & obj3.TaxCode & "</span></div>"
                str += "<div class='col-sm-12 pdbt10'>DN: <span class='title_details3'>" & obj3.Business_Vn & "</span></div>"
                Str += "<div class='col-sm-12'>ĐC: " & obj3.Address & "</div>"
                Str += "</div>"
                Str += "<div class='clear'></div>"
                Str += "</div></div>"
                Str += "<div class='clear'></div>"
                Str += "</div>"

                Str += "<div class='col-md-12'>"
                Str += "<div class='detail-jobuser'>"
                Str += "<div class='row'>"
                Str += "<div class='clear'></div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Tỉnh/Thành phố: " & flDic.RegionalName(pid, obj3.TinhTP, "") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quận/Huyện: " & flDic.RegionalName(pid, "", obj3.QuanHuyen) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: <b>" & obj3.Mobile & "</b></div>"
                Str += "<div class='col-md-6 wd-row'><i class='icon-address icon_16'></i><span class='pl_28'>Số Fax: " & obj3.Fax & "</div>"
                Str += "<div class='col-md-6 wd-row'><i class='fa fa-envelope-square iconcolor'></i><span class='pl_15'>Email: " & obj3.Email & "</div>"
                Str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Website: " & obj3.Website & "</div>"
                Str += "<div class='col-md-12 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Quy mô đơn vị: " & obj3.Scale & "</div>"
                Str += "<div class='col-md-12 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Giới thiệu: " & obj3.Description & "</div>"
                Str += "</div></div></div>"
                Str += "<div class='clear'></div>"

                Str += "<div class='col-md-12'>"
                Str += "<div class='detail-jobuser'>"
                Str += "<div class='row'>"
                Str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin liên hệ</span>"
                Str += "</div>"
                Str += "<div class='row pdt10'>"
                Str += "<div class='col-md-12 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Họ và tên: <b>" & obj3.ContactUser & "</b></div>"
                Str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số điệ thoại: <b>" & obj3.ContactMobile & "</b></div>"
                Str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Địa chỉ Email liên hệ: <b>" & obj3.ContactEmail & "</b></div>"
                Str += "</div></div></div>"
                Str += "<div class='clear'></div>"

            Else
                Str = "Không có dữ liệu được tìm thấy"

            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GetDetailJobUser(pid As String, jobUser As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If jobUser <> "" Then
                objJobUs = objController.CMS_JobUser_Get(pid, jobUser)
                If IsNothing(objJobUs) = False Then
                    With objJobUs
                        ltContent += "<legend>Thông tin ứng tuyển</legend>"

                        ltContent += "<div class='col-md-12'>Tên hồ sơ:  <b>" & objJobUs.Title & "</b></div>"
                        ltContent += "<div class='col-md-12'>Ngành nghề:  <b>" & flCheck.Career_Name(pid, objJobUs.Career_ID) & "</b></div>"
                        ltContent += "<div class='col-md-12'>Nơi ứng tuyển:  <b>" & flDic.RegionalName(pid, objJobUs.TinhTP, objJobUs.QuanHuyen) & "</b></div>"
                        ltContent += "<div class='col-md-4'>Chức vụ mong muốn: " & flDic.Position_Name(pid, objJobUs.LevelDesired) & "</div>"
                        ltContent += "<div class='col-md-4'>Chức vụ hiện tại: " & flDic.Position_Name(pid, objJobUs.CurrentLevel) & "</div>"
                        ltContent += "<div class='col-md-4'>Số năm kinh nghiệm: " & flCheck.Experience_Name(pid, objJobUs.Experience_ID) & "</div>"
                        ltContent += "<div class='col-md-4'>Trình độ: " & "" & "</div>"
                        ltContent += "<div class='col-md-4'>Mức lương đề xuất: " & flCheck.Salary_Name(pid, objJobUs.Salary_ID) & "</div>"
                        ltContent += "<div class='col-md-4'>Nhu cầu làm việc: " & "" & "</div>"
                        ltContent += "<div Class='col-md-12'>Trình độ học vấn: " & objJobUs.Education.Replace(vbCrLf, "<br/>") & "</div>"
                        ltContent += "<div Class='col-md-12'>Kinh nghiệm làm việc: " & objJobUs.CareerGoals.Replace(vbCrLf, "<br/>") & "</div>"
                        ltContent += "<div Class='col-md-12'>Mục tiêu nghề nghiệp: " & objJobUs.WorkExperience.Replace(vbCrLf, "<br/>") & "</div>"
                        ltContent += "<div Class='col-md-12'>Kỹ năng sở trường: " & objJobUs.SkillsForte.Replace(vbCrLf, "<br/>") & "</div>"
                        ltContent += "</fieldset>"
                        ltContent += "<div class=""clear""></div>"

                        ltContent += "<legend>Thông tin ứng viên</legend>"
                        ltContent += "<div class='col-md-12'>" & flCheck.ProfileMember(objJobUs.UserAdmin, False) & "</div>"
                        ltContent += "</fieldset>"
                        ltContent += "<div class=""clear""></div>"
                    End With
                Else
                    ltContent = "Không có dữ liệu được tìm thấy"
                End If
            End If
            ltContent += "</div>"
            strVal = "<div class=""modal-header"">"
            strVal += "<button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>"
            strVal += "<div class=""modal-title"" id=""modalTitle"">Thông tin chi tiết hồ sơ</div>"
            strVal += "</div>"

            data.Data = strVal & "<div class=""modal-body"" id=""modalBody"">" & ltContent & "</div>"
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FollowBusiness(pid As String, id As String, use As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj3 As New CMS_BusinessInfo

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj3 = CType(flCache.GetCache("CMS_Business_Get" & pid & "_" & id), CMS_BusinessInfo)
            If IsNothing(obj3) Then
                obj3 = objController.CMS_Business_Get(pid, id)
                flCache.SetCache("CMS_Business_Get" & pid & "_" & id, obj3, SecondCache.M5)
            End If
            If IsNothing(obj3) = False Then
                Dim objF = New CMS_JobFollowInfo
                objF.Business_ID = obj3.Business_ID
                objF.Business_Vn = obj3.Business_Vn
                objF.Business_En = obj3.Business_En
                objF.Business_Sort = obj3.Business_Sort
                objF.TinhTP = obj3.TinhTP
                objF.QuanHuyen = obj3.QuanHuyen
                objF.Mobile = obj3.Mobile
                objF.Email = obj3.Email
                objF.Address = obj3.Address
                objF.DeletedDate = flReg.DateNull()
                objF.CreatedDate = Now
                objF.CreatedUser = use
                objF.UpdatedDate = Now
                objF.UpdatedUser = use
                str = objController.CMS_JobFollow_Add(objF)
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobBlackList(pid As String, id As String, use As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj3 As New CMS_JobUserInfo

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj3 = CType(flCache.GetCache("CMS_JobUser_Get" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj3) Then
                obj3 = objController.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get" & pid & "_" & id, obj3, SecondCache.M5)
            End If
            If IsNothing(obj3) = False Then
                Dim objF = New CMS_JobBlackListInfo
                objF.JobUser_ID = obj3.JobUser_ID
                objF.Title = obj3.Title
                objF.TinhTP = obj3.TinhTP
                objF.QuanHuyen = obj3.QuanHuyen
                objF.DeletedDate = flReg.DateNull()
                objF.CreatedDate = Now
                objF.CreatedUser = use
                objF.UpdatedDate = Now
                objF.UpdatedUser = use
                str = objController.CMS_JobBlackList_Add(objF)
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
End Class

Public Class Response
    Public Property Data As Object
    Public Property Status As Short
    Public Property Message As String
End Class
