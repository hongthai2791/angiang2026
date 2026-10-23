<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.status = ServiceStatus.NODATA, .data = Nothing, .message = String.Empty}
    Dim objCTL As New AppController
    Dim str, sAtr() As String
    Dim arr, arr2 As New ArrayList
    Dim obj As New CMS_JobUserInfo
    Dim obj1 As New CMS_WPublicInfo
    Dim objUs As New CMS_UserProfileInfo
    Dim objController As New AppController()
    Dim name, phone, email, address, gioitinh As String
    Dim tuoi As Integer
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailWorksAdd(pid As String, id As String, vt As String, cer As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            str = "" 'flCache.GetCache("DetailWorks_POP_" & id & "_" & vt & "_" & cer) & ""
            If str = "" Then

                If id = "1" Then 'Hình thức nộp
                    str = "<div class='col-sm-12'><input type=""checkbox"" onchange=""getText(this,'SubmissionSend');"" value=""Trực tiếp"" id=""a1""><label class='pop-lab' for=""a1"">Trực tiếp</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getText(this,'SubmissionSend');"" value=""Nộp qua mail"" id=""a2""><label class='pop-lab' for=""a2"">Nộp qua mail</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getText(this,'SubmissionSend');"" value=""Khác"" id=""a3""><label class='pop-lab' for=""a3"">Khác</label></div>"
                ElseIf id = "2" Then 'Mô tả công việc
                    If cer.Length > 1 Then
                        sAtr = cer.Split(",")
                        Dim cerbj As New CMS_CareerInfo
                        For i As Integer = 0 To sAtr.Length - 1
                            cerbj = objController.CMS_Career_Get(pid, sAtr(i))
                            If IsNothing(cerbj) = False Then
                                If cerbj.Career_Des <> "" Then str += cerbj.Career_Des & vbLf
                            End If
                        Next
                    Else
                        Dim pjbj As CMS_JobPlaceInfo = objController.CMS_JobPlace_Get(pid, vt)
                        If IsNothing(pjbj) = False Then
                            If pjbj.MoTaCV <> "" Then str += pjbj.MoTaCV
                        End If
                    End If
                    If str.Trim.Length > 1 Then
                        sAtr = str.Split(vbLf) : str = ""
                        For i As Integer = 0 To sAtr.Length - 1
                            If sAtr(i).Trim <> "" Then
                                str += "<div class='col-sm-12'><input id =""a" & i & """ type=""checkbox"" onchange=""getText(this,'Description');"" value=""" & flReg.RemoveScript(sAtr(i), False) & """>"
                                str += "<label class='pop-lab' for=""a" & i & """>" & flReg.RemoveScript(sAtr(i), False) & "</label></div>"
                            End If
                        Next
                    End If
                ElseIf id = "3" Then 'Yêu cầu công việc
                    Dim pjbj As CMS_JobPlaceInfo = objController.CMS_JobPlace_Get(pid, vt)
                    If IsNothing(pjbj) = False Then
                        If pjbj.YeuCauCV <> "" Then str += pjbj.YeuCauCV
                    End If
                    If str.Trim.Length > 1 Then
                        sAtr = str.Split(vbLf) : str = ""
                        For i As Integer = 0 To sAtr.Length - 1
                            If sAtr(i).Trim <> "" Then
                                str += "<div class='col-sm-12'><input id =""a" & i & """ type=""checkbox"" onchange=""getText(this,'Requirement');"" value=""" & flReg.RemoveScript(sAtr(i), False) & """>"
                                str += "<label class='pop-lab' for=""a" & i & """>" & flReg.RemoveScript(sAtr(i), False) & "</label></div>"
                            End If
                        Next
                    End If
                ElseIf id = "4" Then 'Quyền lợi người lao động
                    Dim pjbj As CMS_JobPlaceInfo = objController.CMS_JobPlace_Get(pid, vt)
                    If IsNothing(pjbj) = False Then
                        If pjbj.QuyenLoi <> "" Then str += pjbj.QuyenLoi
                    End If
                    If str.Trim.Length > 1 Then
                        sAtr = str.Split(vbLf) : str = ""
                        For i As Integer = 0 To sAtr.Length - 1
                            If sAtr(i).Trim <> "" Then
                                str += "<div class='col-sm-12'><input id =""a" & i & """ type=""checkbox"" onchange=""getText(this,'Benefit');"" value=""" & flReg.RemoveScript(sAtr(i), False) & """>"
                                str += "<label class='pop-lab' for=""a" & i & """>" & flReg.RemoveScript(sAtr(i), False) & "</label></div>"
                            End If
                        Next
                    End If
                ElseIf id = "5" Then 'Yêu cầu hồ sơ
                    Dim pjbj As CMS_JobPlaceInfo = objController.CMS_JobPlace_Get(pid, vt)
                    If IsNothing(pjbj) = False Then
                        If pjbj.YeCauHoSo <> "" Then str += pjbj.YeCauHoSo
                    End If
                    If str.Trim.Length > 1 Then
                        sAtr = str.Split(vbLf) : str = ""
                        For i As Integer = 0 To sAtr.Length - 1
                            If sAtr(i).Trim <> "" Then
                                str += "<div class='col-sm-12'><input id =""a" & i & """ type=""checkbox"" onchange=""getText(this,'RequirementsProfile');"" value=""" & flReg.RemoveScript(sAtr(i), False) & """>"
                                str += "<label class='pop-lab' for=""a" & i & """>" & flReg.RemoveScript(sAtr(i), False) & "</label></div>"
                            End If
                        Next
                    End If
                End If
                flCache.SetCache("DetailWorks_POP_" & id & "_" & vt & "_" & cer, str)
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function popDetailjobuserAdd(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            str = "" 'flCache.GetCache("DetailWorks_POP_" & id & "_" & vt & "_" & cer) & ""
            If str = "" Then

                If id = "1" Then 'Quá trình học tập
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'Education');"" value=""Tốt nghiệp Đại học"" id=""b1""><label class='pop-lab' for=""b1"">Tốt nghiệp Đại học</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'Education');"" value=""Tốt nghiệp Cao đẳng"" id=""b2""><label class='pop-lab' for=""b2"">Tốt nghiệp Cao đẳng</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'Education');"" value=""Tốt nghiệp Trung cấp"" id=""b3""><label class='pop-lab' for=""b3"">Tốt nghiệp Trung cấp</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'Education');"" value=""Tốt nghiệp Trung học phổ thông"" id=""b4""><label class='pop-lab' for=""b4"">Tốt nghiệp Trung học phổ thông</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'Education');"" value=""Khác"" id=""b5""><label class='pop-lab' for=""b5"">Khác</label></div>"

                ElseIf id = "2" Then 'Kinh nghiệm làm việc
                    str = "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'CareerGoals');"" value=""Trực tiếp"" id=""c1""><label class='pop-lab' for=""c1"">Trực tiếp</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'CareerGoals');"" value=""Nộp qua mail"" id=""c2""><label class='pop-lab' for=""c2"">Nộp qua mail</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'CareerGoals');"" value=""Khác"" id=""c3""><label class='pop-lab' for=""c3"">Khác</label></div>"
                ElseIf id = "3" Then 'Mục tiêu nghề nghiệp
                    str = "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Không ngừng học hỏi và nâng cao trình độ chuyên môn, có chí cầu tiến"" id=""a1""><label class='pop-lab' for=""a1"">- Không ngừng học hỏi và nâng cao trình độ chuyên môn, có chí cầu tiến</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Hoàn thành, sáng tạo và đóng góp ý kiến xây dựng trong các mục tiêu công việc phụ trách góp phần vào mục tiêu chung của đơn vị ứng tuyển."" id=""a2""><label class='pop-lab' for=""a2"">- Hoàn thành, sáng tạo và đóng góp ý kiến xây dựng trong các mục tiêu công việc phụ trách góp phần vào mục tiêu chung của đơn vị ứng tuyển.</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Xây dựng, gắn kết môi trường làm việc chuyên nghiệp, cùng phát triển."" id=""a3""><label class='pop-lab' for=""a3"">- Xây dựng, gắn kết môi trường làm việc chuyên nghiệp, cùng phát triển.</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Mong muốn tìm được chỗ làm ổn định lâu dài, có mức lương tốt, có cơ hội thăng tiến"" id=""a4""><label class='pop-lab' for=""a4"">- Mong muốn tìm được chỗ làm ổn định lâu dài, có mức lương tốt, có cơ hội thăng tiến</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Mang lại hiệu quả cho nhiều người"" id=""a5""><label class='pop-lab' for=""a5"">- Mang lại hiệu quả cho nhiều người.</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Mong muốn trở thành một người năng động, hoàn thành tốt công việc."" id=""a6""><label class='pop-lab' for=""a6"">- Mong muốn trở thành một người năng động, hoàn thành tốt công việc.</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Được tiếp cận với môi trường làm việc chuyên nghiệp, trí tuệ và hòa hợp."" id=""a7""><label class='pop-lab' for=""a7"">- Được tiếp cận với môi trường làm việc chuyên nghiệp, trí tuệ và hòa hợp.</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'WorkExperience');"" value=""- Đạt được những mong muốn, kỳ vọng của công việc trong tổ chức."" id=""a8""><label class='pop-lab' for=""a8"">- Đạt được những mong muốn, kỳ vọng của công việc trong tổ chức.</label></div>"

                ElseIf id = "4" Then 'Kỹ năng sở trường
                    str = "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Kỹ năng lãnh đạo"" id=""d1""><label class='pop-lab' for=""d1"">- Kỹ năng lãnh đạo</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Kỹ năng làm việc nhóm"" id=""d2""><label class='pop-lab' for=""d2"">- Kỹ năng làm việc nhóm</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Giải quyết vấn đề"" id=""d3""><label class='pop-lab' for=""d3"">- Giải quyết vấn đề</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Ra quyết định"" id=""d4""><label class='pop-lab' for=""d4"">- Ra quyết định</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Giải quyết chiến lược"" id=""d5""><label class='pop-lab' for=""d5"">- Giải quyết chiến lược</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Quản lý thời gian hiệu quả"" id=""d6""><label class='pop-lab' for=""d6"">- Quản lý thời gian hiệu quả</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Quản lý sáng tạo"" id=""d7""><label class='pop-lab' for=""d7"">- Quản lý sáng tạo</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Kỹ năng thuyết trình"" id=""d8""><label class='pop-lab' for=""d8"">- Kỹ năng thuyết trình</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Dễ dàng thích nghi với môi trường mới"" id=""d9""><label class='pop-lab' for=""d9"">- Dễ dàng thích nghi với môi trường mới</label></div>"
                    str += "<div class='col-sm-12'><input type=""checkbox"" onchange=""getTextTelerik(this,'SkillsForte');"" value=""- Kỹ năng giao tiếp & đàm phán"" id=""d10""><label class='pop-lab' for=""d10"">- Kỹ năng giao tiếp & đàm phán</label></div>"


                End If
                flCache.SetCache("DetailWorks_POP_" & id, str)
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailGoiTin(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj6 As New CMS_WPublicInfo
        Dim tong As Double = 0
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = objController.CMS_WPrice_Get_By_CMS_Works(pid, id)
            obj6 = objCTL.CMS_WPublic_Get(pid, id)
            If IsNothing(obj6) = False Then

                str += "<div class=""col-md-12 pd0"" style=""color: #026b58;font-size: 18px;font-weight: 600;"">" & obj6.Title & "</div>"
                str += "<div class='clear'></div>"
                str += "<div class=""col-md-3"">Mã tin: <b style=""color:red;font-size:20px;"">" & flCheck.ReadCode(obj6.ID) & "</b></div>"
                'str += "<div class=""col-md-6 pd0 "">Khu vực: <span class=""TitleKhuVuc"">" & flDic.RegionalName(0, obj6.TinhTP, obj6.QuanHuyen) & "</span></div>"
                Dim dem As Integer
                Dim dt As DateTime = obj6.GhDenNgay
                If dt > DateTime.MinValue Then
                    dem = flReg.TruNgay(Now.Date, dt.Date, True)
                    If dem >= 10 Then
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-success "" style=""font-size:18px;"">" & dem & "&nbsp;ngày</span></div>"
                    ElseIf dem > 0 Then
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-warning"" style=""font-size:18px;"">" & dem & "&nbsp;ngày</span></div>"
                    Else
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-danger"" style=""font-size:18px;"">Đã hết hạn</span></div>"
                    End If
                Else
                    dt = obj6.EndDate
                    dem = flReg.TruNgay(Now.Date, dt.Date, True)
                    If dem >= 10 Then
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-success "" style=""font-size:18px;"">" & dem & "&nbsp;ngày</span></div>"
                    ElseIf dem > 0 Then
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-warning"" style=""font-size:18px;"">" & dem & "&nbsp;ngày</span></div>"
                    Else
                        str += "<div class=""col-md-3"">Thời hạn đăng tin: <span class=""label label-danger"" style=""font-size:18px;"">Đã hết hạn</span></div>"
                    End If
                End If
                For Each Cr As CMS_WPriceInfo In arr
                    tong += Cr.IsMoney
                Next

                str += "<div class=""col-md-6 txt-right pdr5 ""> Tổng phí đăng tin: <b style=""color:red;font-size:20px;"">" & flReg.FormatPriceForAjax(tong) & "</b>&nbsp;Đồng</div>"
                str += "<div class='gach clear'></div>"
                'str += "<div class=""pd0""> Thông tin chi tiết gói tin</div>"

                If arr.Count > 0 Then
                    str += "<table cellspacing='0' style ='width:100%!important; border:1px solid #bfbfbf !important'>"
                    str += "<tr style='text-align: center;height:30px; color: #fff; vertical-align: middle;background: #258cb8!important;border:1px solid #bfbfbf !important;'>"

                    str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>Gói tin đăng tuyển</td>"
                    str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>Số ngày đăng</td>"
                    str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>Từ ngày</td>"
                    str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>Đến hết ngày</td>"
                    str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>Phí đăng tin</td></tr>"
                    For Each Cr As CMS_WPriceInfo In arr
                        str += "<tr style ='text-align: center;height:30px; vertical-align: middle;border:1px solid #bfbfbf !important;'>"
                        str += "<td style='border:1px solid #bfbfbf !important'>" & flCheck.PriceList_Name(pid, Cr.PriceList_ID) & "</td>"
                        str += "<td style ='text-align: center;border:1px solid #bfbfbf !important'>" & Cr.IsTimeEnd & "&nbsp;ngày</td>"
                        str += "<td style ='text-align: center;border:1px solid #bfbfbf !important'>" & flReg.ReadDate(Cr.StartDate, False) & "</td>"
                        str += "<td style='text-align: center;border:1px solid #bfbfbf !important'>" & flReg.ReadDate(Cr.EndDate, False) & "</td>"
                        str += "<td style ='text-align: center;border:1px solid #bfbfbf !important'>" & flReg.FormatPriceForAjax(Cr.IsMoney) & "</td></tr>"

                    Next
                    str += "</table>"

                    str += "<div class='clear'></div>"
                Else
                    str = "Không có gói tin nào được tìm thấy"

                End If

            Else
                str = "Không có thông tin nào được tìm thấy"

            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Detailvieclam(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj1 = CType(flCache.GetCache("CMS_Works_Get_" & pid & "_" & id), CMS_WPublicInfo)
            If IsNothing(obj1) Then
                obj1 = objCTL.CMS_WPublic_Get(pid, id)
                flCache.SetCache("CMS_Works_Get_" & pid & "_" & id, obj1, SecondCache.M5)
            End If

            If IsNothing(obj1) = False Then

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(0, obj1.Business_ID), 140, 100) & """ alt='" & obj1.Business_Name & "'/>"
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
                'str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Hình thức nộp:" & obj1.SubmissionSend & "</div>"
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
                str += "<div class='col-md-12 wd-row'>Đơn vị: <b>" & obj1.Business_Name & "</b></div>"
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
    Public Function DetailBusiness(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj3 As New CMS_BusinessInfo

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj3 = CType(flCache.GetCache("CMS_Business_Get_" & pid & "_" & id), CMS_BusinessInfo)
            If IsNothing(obj3) Then
                obj3 = objController.CMS_Business_Get(pid, id)
                flCache.SetCache("CMS_Business_Get_" & pid & "_" & id, obj3, SecondCache.M5)
            End If

            If IsNothing(obj3) = False Then
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<div class='col-md-2 txt-center box-dn-img'><img src=""" & flReg.ImgSRC(flCheck.Business_Logo(pid, obj3.Business_ID), 140, 100) & """ alt='" & obj3.Business_Vn & "'/></div>"
                str += "<div class='col-md-10'>"
                str += "<div class='col-sm-12 pdbt10'>MST: <span class='TaxCode'>" & obj3.TaxCode & "</span></div>"
                str += "<div class='col-sm-12 pdbt10'>DN: <span class='title_details3'>" & obj3.Business_Vn & "</span></div>"
                str += "<div class='col-sm-12'>ĐC: " & obj3.Address & "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Tỉnh/Thành phố: " & flDic.RegionalName(pid, obj3.TinhTP, "") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quận/Huyện: " & flDic.RegionalName(pid, "", obj3.QuanHuyen) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: <b>" & obj3.Mobile & "</b></div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-address icon_16'></i><span class='pl_28'>Số Fax: " & obj3.Fax & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='fa fa-envelope-square iconcolor'></i><span class='pl_15'>Email: " & obj3.Email & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Website: " & obj3.Website & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Quy mô đơn vị: " & obj3.Scale & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Giới thiệu: " & obj3.Description & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Thông tin liên hệ</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Họ và tên: <b>" & obj3.ContactUser & "</b></div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số điệ thoại: <b>" & obj3.ContactMobile & "</b></div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Địa chỉ Email liên hệ: <b>" & obj3.ContactEmail & "</b></div>"
                str += "</div></div></div>"
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
    Public Function DetailUngVien(pid As String, id As String, rid As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_RecruitmentInfo
        Dim objmo As New CMS_MoneyOutputInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_UngVien" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objCTL.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_UngVien" & pid & "_" & id, obj, SecondCache.M5)
            End If
            obj5 = objCTL.CMS_Recruitment_Get(pid, rid)

            If IsNothing(obj) = False Then
                objCTL.CMS_JobUser_Update_View(pid, id)
                str += "<div id='detailJobUs'>"
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div>"

                str += "</div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-sm-7'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                If obj.UserAdmin.Contains("@") = False Then 'Kiểm tra xem tài khoản app nộp hay web nộp
                    Dim up As CMS_UserProfileInfo = objController.CMS_UserProfile_Get_By_UserName(pid, obj.UserAdmin)
                    If IsNothing(up) = False Then
                        str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & up.HoVaTen.ToUpper() & "</span></div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & obj.UserAdmin & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.Regional_Name(0, up.W_TinhTP) & "</div>"

                    Else
                        str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                        str += "<div class='col-md-12 pdl0'><i class=""fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"

                    End If
                Else
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"

                    str += "<div class='col-md-12 pdl0'><i class=""fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"



                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                End If

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
                str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv(" & pid & ",'" & obj.JobUser_ID & "','" & rid & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
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
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GTVL_UV(pid As String, id As String, rid As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_GTVLInfo
        Dim objp As New CMS_JUserPublicInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objp = CType(flCache.GetCache("CMS_JUserPublic_Get_UngVien" & pid & "_" & id), CMS_JUserPublicInfo)
            If IsNothing(objp) Then
                objp = objCTL.CMS_JUserPublic_Get(pid, id)
                flCache.SetCache("CMS_JUserPublic_Get_UngVien" & pid & "_" & id, objp, SecondCache.M5)
            End If
            obj5 = objCTL.CMS_GTVL_Get(pid, rid)

            If IsNothing(objp) = False Then
                objCTL.CMS_JobUser_Update_View(pid, id)

                str += "<div id='detailJobUs'>"
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(objp.PortalID, objp.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(objp.Title) & "'/></div></div>"


                str += "</div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-sm-7'>"
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, objp.UserAdmin)
                If IsNothing(aInfo) = False Then
                    str += "<div class='col-md-12 pdl0'><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & objp.Title & "</span></span></div>"
                    str += "<div Class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen & "</span></div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & aInfo.DienThoai & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                    str += "<div class='clear'></div>"
                Else
                    str += "<div class='col-md-12 pdl0'><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & objp.Title & "</span></span></div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, objp.UserAdmin).ToUpper() & "</span></div>"
                    str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, objp.UserAdmin) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, objp.UserAdmin) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.getDiaChi(0, objp.UserAdmin) & "</div>"
                    str += "<div class='clear'></div>"
                End If

                str += "</div>"
                str += "<div class='col-sm-5'>"
                str += "<div class='col-md-6'><input class=""IsView-" & objp.JobUser_ID & """ type=""checkbox"" value=""Đã xem"" checked=""" & obj5.IsView & """ disabled=""disabled"" id=""b1""><label class='pop-lab' for=""b1"">Đã xem</label></div>"
                str += "<div class='col-md-6'><input class=""IsContact-" & objp.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'2','" & username & "');"" value=""Đã liên hệ"" " & IIf(obj5.IsContact = True, "checked='checked'", "") & " id=""b2""><label class='pop-lab' for=""b1"">Đã liên hệ</label></div>"
                str += "<div class='col-md-6'><input class=""IsInterview-" & objp.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'3','" & username & "');"" value=""Đã phỏng vấn"" " & IIf(obj5.IsInterview = True, "checked='checked'", "") & " id=""b3""><label class='pop-lab' for=""b1"">Đã phỏng vấn</label></div>"
                str += "<div class='col-md-6'><input class=""IsTest-" & objp.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'4','" & username & "');"" value=""Đã test"" " & IIf(obj5.IsTest = True, "checked='checked'", "") & " id=""b4""><label class='pop-lab' for=""b1"">Đã test</label></div>"
                str += "<div class='col-md-6'><input class=""IsElect-" & objp.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'5','" & username & "');"" value=""Trúng tuyển"" " & IIf(obj5.IsElect = True, "checked='checked'", "") & " id=""b5""><label class='pop-lab' for=""b1"">Trúng tuyển</label></div>"
                str += "<div class='col-md-6'><input class=""IsCancel-" & objp.JobUser_ID & """ type=""checkbox"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'6','" & username & "');"" value=""Từ chối"" " & IIf(obj5.IsCancel = True, "checked='checked'", "") & " id=""b6""><label class='pop-lab' for=""b6"">Từ chối</label></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã CV ứng viên:&nbsp;</span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(objp.ID) & "</b>&nbsp;&nbsp;"
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
                str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv(" & pid & ",'" & objp.JobUser_ID & "','" & rid & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, objp.TinhTP, objp.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, objp.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(objp.StartDate, False) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, objp.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, objp.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, objp.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, objp.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, objp.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & objp.Education.Replace(vbLf, "") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & objp.CareerGoals.Replace(vbLf, "") & "</div>"
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
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & objp.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & objp.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                Call objController.CMS_GTVL_Update_Quick(pid, rid, True, obj5.IsContact, obj5.IsInterview, obj5.IsTest, obj5.IsElect, obj5.IsCancel, Now, username)

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
    Public Function GTVL_UVQT(pid As String, id As String, rid As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_GTVLInfo
        Dim objp As New CMS_JUserPublicInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objp = CType(flCache.GetCache("CMS_JUserPublic_Get_UngVien" & pid & "_" & id), CMS_JUserPublicInfo)
            If IsNothing(objp) Then
                objp = objCTL.CMS_JUserPublic_Get(pid, id)
                flCache.SetCache("CMS_JUserPublic_Get_UngVien" & pid & "_" & id, objp, SecondCache.M5)
            End If
            obj5 = objCTL.CMS_GTVL_Get(pid, rid)

            If IsNothing(objp) = False Then
                objCTL.CMS_JobUser_Update_View(pid, id)

                str += "<div id='detailJobUs'>"
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(objp.PortalID, objp.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(objp.Title) & "'/></div></div>"


                str += "</div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-sm-7'>"
                str += "<div class='col-md-12 pdl0'><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & objp.Title & "</span></span></div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, objp.UserAdmin).ToUpper() & "</span></div>"
                str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, objp.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, objp.UserAdmin) & "</div>"
                str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ: " & flDic.getDiaChi(0, objp.UserAdmin) & "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-sm-5'>"
                str += "<div class='col-md-6'><input class=""IsView-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'1','" & username & "');"" value=""Đã xem"" " & IIf(obj5.IsView = True, "checked='checked'", "") & " id=""b1""><label class='pop-lab' for=""b1"">Đã xem</label></div>"
                ' str += "<div class='col-md-6'><input class=""IsView-" & objp.JobUser_ID & """ type=""checkbox"" value=""Đã xem"" checked=""" & obj5.IsView & """ disabled=""disabled"" id=""b1""><label class='pop-lab' for=""b1"">Đã xem</label></div>"
                str += "<div class='col-md-6'><input class=""IsContact-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'2','" & username & "');"" value=""Đã liên hệ"" " & IIf(obj5.IsContact = True, "checked='checked'", "") & " id=""b2""><label class='pop-lab' for=""b1"">Đã liên hệ</label></div>"
                str += "<div class='col-md-6'><input class=""IsInterview-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'3','" & username & "');"" value=""Đã phỏng vấn"" " & IIf(obj5.IsInterview = True, "checked='checked'", "") & " id=""b3""><label class='pop-lab' for=""b1"">Đã phỏng vấn</label></div>"
                str += "<div class='col-md-6'><input class=""IsTest-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'4','" & username & "');"" value=""Đã test"" " & IIf(obj5.IsTest = True, "checked='checked'", "") & " id=""b4""><label class='pop-lab' for=""b1"">Đã test</label></div>"
                str += "<div class='col-md-6'><input class=""IsElect-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'5','" & username & "');"" value=""Trúng tuyển"" " & IIf(obj5.IsElect = True, "checked='checked'", "") & " id=""b5""><label class='pop-lab' for=""b1"">Trúng tuyển</label></div>"
                str += "<div class='col-md-6'><input class=""IsCancel-" & objp.JobUser_ID & """ type=""checkbox"" disabled=""disabled"" onchange=""setGTVL('" + pid + "','" + rid + "',this,'6','" & username & "');"" value=""Từ chối"" " & IIf(obj5.IsCancel = True, "checked='checked'", "") & " id=""b6""><label class='pop-lab' for=""b6"">Từ chối</label></div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã CV ứng viên:&nbsp;</span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(objp.ID) & "</b>&nbsp;&nbsp;"
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
                'str += "<div class='col-xs-2' style='margin-top:-5px;'>"
                'str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv(" & pid & ",'" & objp.JobUser_ID & "','" & rid & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                'str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                'str += "</div>"
                str += "<div class='clear'></div>"

                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-6 wd-row'><i class='icon-money icon_16'></i><span class='pl_28'>Nơi làm việc: " & flDic.RegionalName(0, objp.TinhTP, objp.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Ngành nghề: " & flCheck.Career_Name(0, objp.Career_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-career icon_16'></i><span class='pl_28'>Ngày đăng tin: " & flReg.ReadDate(objp.StartDate, False) & "</div>"

                str += "<div class='col-md-6 wd-row'><i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: " & flDic.Position_Name(0, objp.LevelDesired) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Mức lương: " & flCheck.Salary_Name(0, objp.Salary_ID) & "</div>"
                str += "<div class='col-md-6 wd-row'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, objp.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, objp.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, objp.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & objp.Education.Replace(vbLf, "") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & objp.CareerGoals.Replace(vbLf, "") & "</div>"
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
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & objp.WorkExperience.Replace(vbLf, "<br/>") & "</div>"
                str += "<div class='col-md-12 wd-row'>Kỹ năng sở trường: " & objp.SkillsForte.Replace(vbLf, "<br/>") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "</div>"
                Call objController.CMS_GTVL_Update_Quick(pid, rid, True, obj5.IsContact, obj5.IsInterview, obj5.IsTest, obj5.IsElect, obj5.IsCancel, Now, username)

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
        Dim objm As New CMS_MoneyOutputInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JobUser_Get_1" & pid & "_" & id), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = objCTL.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_1" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                objCTL.CMS_JobUser_Update_View(pid, id)
                objm = objController.CMS_MoneyOutput_Get_Money(pid, flCheck.Business_ID(pid, UserInfo.Username), obj.JobUser_ID)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += "<img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                If obj.IsSystem = -1 Then
                    If IsNothing(objm) = False Then
                        str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                    Else
                        If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, UserInfo.Username), obj.JobUser_ID) = False Then
                            str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & flDic.hideString(obj.Title, 3, "C") & "</span></span></div>"
                        Else
                            str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                        End If
                    End If
                Else
                    str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                End If
                str += "<div class='col-md-8'>"

                'If obj.IsSystem <> -1 Then
                '    name = flDic.getHoTen(0, obj.UserAdmin)
                '    phone = flDic.getTelephone(0, obj.UserAdmin)
                '    email = flDic.getEmail(0, obj.UserAdmin)
                '    address = flDic.getDiaChi(0, obj.UserAdmin)
                'Else
                '    objUs = objController.CMS_UserProfile_Get_By_UserName(pid, obj.UserAdmin)
                '    If IsNothing(objUs) = False Then
                '        With objUs
                '            name = .HoVaTen
                '            phone = .UserName
                '            email = ""
                '            address = .W_TinhTP
                '        End With
                '    End If
                'End If
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, obj.UserAdmin)
                If IsNothing(aInfo) = False Then
                    If IsNothing(objm) = False Then
                        str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper() & "</span></div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & aInfo.DienThoai & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                        str += "</div>"
                    Else
                        If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, UserInfo.Username), obj.JobUser_ID) = False Then
                            str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper() & "</span></div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(aInfo.DienThoai, 3, "C") & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                            str += "</div>"
                        Else
                            str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper() & "</span></div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & aInfo.DienThoai & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                            str += "</div>"
                        End If

                    End If

                Else
                    If IsNothing(objm) = False Then
                        str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                        str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                        str += "</div>"
                    Else
                        If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, UserInfo.Username), obj.JobUser_ID) = False Then
                            str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(flDic.getTelephone(0, obj.UserAdmin), 3, "C") & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(flDic.getEmail(0, obj.UserAdmin), 5, "D") & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                            str += "</div>"
                        Else
                            str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                            str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                            str += "</div>"
                        End If

                    End If

                End If

                str += "<div class='col-md-4'>"
                str += "<div class='col-md-12'><i class='icon-edu icon_16 mgt10'></i><span class='pl_28'>Mã CV:&nbsp;</span><b style='color:red;font-size:20px'>" & flCheck.ReadCode(obj.ID) & "</b>&nbsp;&nbsp;"
                str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv(" & pid & ",'" & obj.JobUser_ID & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span></div>"
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
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & flCheck.Experience_Name(0, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & obj.Education.Replace(vbLf, "") & "</div>"

                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Yêu cầu hồ sơ: " & obj.CareerGoals.Replace(vbLf, "") & "</div>"
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
    Public Function DetailUngVien2(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_RecruitmentInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try

            obj = CType(flCache.GetCache("CMS_JobUser_Get_2" & pid & "_" & id), CMS_JobUserInfo)

            If IsNothing(obj) Then
                obj = objCTL.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JobUser_Get_2" & pid & "_" & id, obj, SecondCache.M5)
            End If

            If IsNothing(obj) = False Then
                objCTL.CMS_JobUser_Update_View(pid, id)
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                str += " <div class='col-md-8'>"
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, obj.UserAdmin)
                If IsNothing(aInfo) = False Then
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper() & "</span></div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & aInfo.DienThoai & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                Else
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                    'str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(flDic.getEmail(0, obj.UserAdmin), 5, "D") & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.getEmail(0, obj.UserAdmin) & "</div>"
                    'str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.getTelephone(0, obj.UserAdmin) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                End If

                str += " <div class='col-md-4'>"
                str += "<div><p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p></div>"
                If flCheck.CheckInJobView(pid, obj.JobUser_ID, us) Then
                    str += "<div>"
                    str += "<span title='Hồ sơ này đã được lưu vào hệ thống' class=""panel-save""><i class=""fa fa-save""></i> Đã lưu hồ sơ</span></a>"
                    str += "&nbsp;&nbsp;<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv('" & pid & "','" & obj.JobUser_ID & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 1px;"" title=""Print"">"
                    str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                    str += "</div>"
                Else
                    str += "<div><a class=""btn btn-white btn-save-job"" onclick='LuuUngVien(" & pid & ",""" & id & """);' title='Click để lưu lại hồ sơ này' class=""text_grey2"">"
                    str += "<span class=""line-icon""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Lưu hồ sơ</span></span></a>"
                    str += "&nbsp;&nbsp;<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv('" & pid & "','" & obj.JobUser_ID & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 1px;"" title=""Print"">"
                    str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                    str += "</div>"
                End If

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
    Public Function DetailJobUserHasMoney(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JUserPublicInfo
        Dim objm As New CMS_MoneyInfo
        Dim objb As New CMS_BusJobFreeInfo
        Dim iView As Boolean = False
        Dim dt() As String
        Dim hetTien As Boolean = False
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JUserPublic_GetMoney_" & pid & "_" & id), CMS_JUserPublicInfo)
            If IsNothing(obj) Then
                obj = objCTL.CMS_JUserPublic_Get_ID(pid, id)
                flCache.SetCache("CMS_JUserPublic_GetMoney_" & pid & "_" & id, obj, SecondCache.M5)
            End If

            If IsNothing(obj) = False Then
                objb = New CMS_BusJobFreeInfo
                objb.Business_ID = flCheck.Business_ID(pid, UserInfo.Username)
                objb.JobUser_ID = obj.JobUser_ID
                objb.IsDemJob = 10
                objb.CreatedDate = Now
                objb.CreatedUser = UserInfo.Username
                objb.ID = objController.CMS_BusJobFree_Add_Job(pid, objb)

                If flCheck.CheckBusJobFree(pid, objb.Business_ID, objb.JobUser_ID) = False Then
                    'objm = objCTL.CMS_Money_Get(pid, flCheck.Business_ID(pid, UserInfo.Username))
                    'If IsNothing(objm) = False Then
                    '    If flReg.WriteNumber(objm.TongTienNap + objm.TienKM - objm.TongTienChi) < obj.Appraise Then
                    '        hetTien = True
                    '    Else
                    '        flFunction.AddMoneyOutput(pid, objb.Business_ID, obj.Appraise, "Xem CV " & flCheck.JobUser_Name("", pid, obj.JobUser_ID, False, False), obj.JobUser_ID, PhanLoaiNap.BinhThuong)
                    '    End If
                    'Else
                    iView = True
                    'End If
                End If
                'If obj.IsSystem <> -1 Then
                '    name = flDic.getHoTen(0, obj.UserAdmin)
                '    phone = flDic.getTelephone(0, obj.UserAdmin)
                '    email = flDic.getEmail(0, obj.UserAdmin)
                '    address = flDic.getDiaChi(0, obj.UserAdmin)
                'Else
                objUs = objController.CMS_UserProfile_Get_By_UserName(pid, obj.UserAdmin)
                If IsNothing(objUs) = False Then
                    With objUs
                        If objUs.IsSystem = "Web" Then
                            name = objUs.HoVaTen
                            phone = flDic.getTelephone(0, obj.UserAdmin)
                            email = objUs.UserName
                            address = objUs.W_DiaChi
                            tuoi = flReg.WriteNumber(flDic.getTuoi(objUs.NgaySinh))
                            gioitinh = flDic.Sex_Name(objUs.GioiTinh, False)
                        Else
                            name = flDic.getHoTen(0, obj.UserAdmin)
                            phone = flDic.getTelephone(0, obj.UserAdmin)
                            email = flDic.getEmail(0, obj.UserAdmin)
                            address = flDic.getDiaChi(0, obj.UserAdmin)
                            tuoi = flReg.WriteNumber(flDic.getTuoi(objUs.NgaySinh))
                            gioitinh = flDic.Sex_Name(objUs.GioiTinh, False)

                        End If
                    End With
                Else
                    name = flDic.getHoTen(0, obj.UserAdmin)
                    phone = flDic.getTelephone(0, obj.UserAdmin)
                    email = flDic.getEmail(0, obj.UserAdmin)
                    address = flDic.getDiaChi(0, obj.UserAdmin)
                    tuoi = flReg.WriteNumber(flDic.getTuoi(flDic.getNgaySinh(0, obj.UserAdmin)))
                    gioitinh = flDic.Sex_Name(flDic.getGioiTinh(0, obj.UserAdmin), False)
                End If
                'End If
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10 pd0'>"
                str += " <div class='col-md-9 pd0'>"
                str += "<div class='col-md-10 pdl0'>"
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, obj.UserAdmin)
                If IsNothing(aInfo) = False Then
                    dt = aInfo.DienThoai.Split("-")
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper & "</span></div>"
                    If iView = False Then
                        If flCheck.CheckBusJobFree(pid, objb.Business_ID, objb.JobUser_ID) = False Then
                            If dt.Count >= 2 Then
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(dt(0), 3, "C") & " - " & flDic.hideString(dt(1), 3, "C") & "</div>"
                            Else
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(aInfo.DienThoai, 3, "C") & "</div>"
                            End If
                            str += "</div>"
                            str += "<div class='col-md-2'>"
                            str += "</div>"
                            If email <> "" Then str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(email, 5, "D") & "</div>"

                        Else
                            If dt.Count >= 2 Then
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: <span class=""dthoai-uv"">" & dt(0) & " - " & dt(1) & "</span></span></div>"
                            Else
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: <span class=""dthoai-uv"">" & aInfo.DienThoai & "</span></span></div>"
                            End If
                            str += "</div>"
                            str += "<div class='col-md-2'>"
                            str += "</div>"
                            If email <> "" Then str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> <span class=""dthoai-uv"">" & email & "</span></div>"

                        End If

                    Else
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: <span class=""dthoai-uv"">" & aInfo.DienThoai & "</span></div>"
                        str += "</div>"
                        str += "<div class='col-md-2'>"
                        str += "</div>"
                        If email <> "" Then str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> <span class=""dthoai-uv"">" & email & "</span></div>"

                    End If

                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & address & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-age icon_16'></i><span class='pl_28'>Tuổi: " & flDic.getTuoi(aInfo.NgaySinh) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-gender icon_16'></i><span class='pl_28'>Giới tính: " & flDic.Sex_Name(aInfo.GioiTinh, False) & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                Else
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & name.ToUpper & "</span></div>"
                    If iView = True Then
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(phone, 3, "C") & "</div>"
                        str += "</div>"
                        str += "<div class='col-md-2'>"
                        str += "</div>"
                        If email <> "" Then str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(email, 5, "D") & "</div>"

                    Else
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & phone & "</span></div>"
                        str += "</div>"
                        str += "<div class='col-md-2'>"
                        str += "</div>"
                        If email <> "" Then str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> </span><span class=""dthoai-uv"">" & email & "</span></div>"

                    End If

                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & address & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-age icon_16'></i><span class='pl_28'>Tuổi: " & tuoi & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-gender icon_16'></i><span class='pl_28'>Giới tính: " & gioitinh & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                End If

                str += " <div class='col-md-3'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv('" & pid & "','" & obj.ID & "','" & UserInfo.Username & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                str += "</div></div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "<div class=""col-md-12 b text-info text-center"" id=""moneyalert""></div>"
                'If IsNothing(objm) = False Then
                '    str += "<div class='col-md-12 btn  chitiet'><a  onclick=""xemlienhe()"" Class=""btn-white"" >3333Thông tin liên hệ đang bị ẩn, để xem thông tin chi tiết vui lòng <span class=""chitiet-tt"">Bấm vào đây</span></a></div>"
                'End If
                str += "</div></div></div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12 pdl0 " & IIf(iView = True, "", "none") & " Xacthuclienhe Xacthuc'>"
                str += "<div class='col-md-12 txt-center xacthuctieude'>Đã  hết lượt xem CV miễn phí! Để tiếp tục xem thêm CV, Vui lòng liên hệ với chúng tôi qua số điện thoại</div>"
                str += "<div class='col-md-12 txt-center txt-hotline'>024.66.8182.96</div>"
                str += "</div>"
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
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & obj.WorkExperience.Replace(vbLf, "") & "</div>"
                str += "<div class='col-md-12 wd-row'>Thông tin khác: " & obj.SkillsForte.Replace(vbLf, "") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
            Else
                str = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str
            If hetTien = True Then data.message = "noMoney"
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DetailJobUser1(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JUserPublicInfo
        Dim objm As New CMS_MoneyInfo
        Dim objmo As New CMS_MoneyOutputInfo
        Dim dt() As String

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try

            obj = CType(flCache.GetCache("CMS_JUserPublic_Get_" & pid & "_" & id), CMS_JUserPublicInfo)
            If IsNothing(obj) Then
                obj = objCTL.CMS_JUserPublic_Get_ID(pid, id)
                flCache.SetCache("CMS_JUserPublic_Get_" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                'If obj.IsSystem <> -1 Then
                '    name = flDic.getHoTen(0, obj.UserAdmin)
                '    phone = flDic.getTelephone(0, obj.UserAdmin)
                '    email = flDic.getEmail(0, obj.UserAdmin)
                '    address = flDic.getDiaChi(0, obj.UserAdmin)
                'Else
                objUs = objController.CMS_UserProfile_Get_By_UserName(pid, obj.UserAdmin)
                If IsNothing(objUs) = False Then
                    If objUs.IsSystem = "Web" Then
                        name = objUs.HoVaTen
                        phone = flDic.getTelephone(0, obj.UserAdmin)
                        email = objUs.UserName
                        address = objUs.W_DiaChi
                    Else
                        name = flDic.getHoTen(0, obj.UserAdmin)
                        phone = flDic.getTelephone(0, obj.UserAdmin)
                        email = flDic.getEmail(0, obj.UserAdmin)
                        address = flDic.getDiaChi(0, obj.UserAdmin)
                    End If
                    tuoi = flReg.WriteNumber(flDic.getTuoi(objUs.NgaySinh))
                    gioitinh = flDic.Sex_Name(objUs.GioiTinh, False)
                Else
                    name = flDic.getHoTen(0, obj.UserAdmin)
                    phone = flDic.getTelephone(0, obj.UserAdmin)
                    email = flDic.getEmail(0, obj.UserAdmin)
                    address = flDic.getDiaChi(0, obj.UserAdmin)
                    tuoi = flReg.WriteNumber(flDic.getTuoi(flDic.getNgaySinh(0, obj.UserAdmin)))
                    gioitinh = flDic.Sex_Name(flDic.getGioiTinh(0, obj.UserAdmin), False)
                End If
                'End If

                objmo = objController.CMS_MoneyOutput_Get_Money(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID)

                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row chitieths'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                str += " <div class='col-md-10'>"
                str += " <div class='col-md-8'>"
                str += "<div class='col-md-10 pd0'>"
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, obj.UserAdmin)

                If IsNothing(aInfo) = False Then
                    dt = aInfo.DienThoai.Split("-")
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper & "</span></div>"
                    If IsNothing(objmo) = False Then
                        If dt.Count >= 2 Then
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & dt(0) & " - " & dt(1) & "</span></div>"
                        Else
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & aInfo.DienThoai & "</span></div>"
                        End If
                    Else
                        If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID) = False Then
                            If dt.Count >= 2 Then
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(dt(0), 3, "C") & " - " & flDic.hideString(dt(1), 3, "C") & "</span></div>"
                            Else
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(aInfo.DienThoai, 3, "C") & "</span></div>"
                            End If
                        Else
                            If dt.Count >= 2 Then
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & dt(0) & " - " & dt(1) & "</span></div>"
                            Else
                                str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & aInfo.DienThoai & "</span></div>"
                            End If

                        End If
                    End If

                    If address <> "" Then str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & address & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-age icon_16'></i><span class='pl_28'>Tuổi: " & flDic.getTuoi(aInfo.NgaySinh) & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-gender icon_16'></i><span class='pl_28'>Giới tính: " & flDic.Sex_Name(aInfo.GioiTinh, False) & "</div>"
                    str += "<div class='clear'></div>"
                Else
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & name.ToUpper & "</span></div>"

                    If IsNothing(objmo) = False Then
                        str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & phone & "</span></div>"
                    Else
                        If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID) = False Then
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(phone, 3, "C") & "</span></div>"
                        Else
                            str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: </span><span class=""dthoai-uv"">" & phone & "</span></div>"
                        End If
                    End If
                    If address <> "" Then str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & address & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Tuổi: " & tuoi & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Giới tính: " & gioitinh & "</div>"
                    str += "<div class='clear'></div>"

                End If
                str += "</div>"
                str += "<div class='col-md-2'>"
                str += "</div>"
                If email = "" Then
                    str += "<div class='col-md-12 pdl0 none'></div>"
                Else
                    If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID) = False Then
                        str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(email, 5, "D") & "</div>"
                    Else
                        str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & email & "</div>"
                    End If
                End If
                str += "<div class='clear'></div>"
                str += "</div>"
                str += " <div Class='col-md-4'>"

                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                If flCheck.CheckInJobView(pid, obj.JobUser_ID, us) Then
                    str += "<span title='Hồ sơ này đã được lưu vào hệ thống' class=""panel-save""><i class=""fa fa-save""></i> Đã lưu hồ sơ</span>"
                Else
                    str += "<a class=""btn btn-white btn-save-job"" onclick='LuuUngVien(" & pid & ",""" & obj.JobUser_ID & """);' title='Click để lưu lại hồ sơ này' class=""text_grey2"">"
                    str += "<span class=""line-icon""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Lưu hồ sơ</span></span></a>"
                End If

                str += "<span class=""btn btn-white btn-save-job pbt0""><a onclick=""printDiv('" & pid & "','" & obj.ID & "','" & us & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                str += "</div></div>"


                'If UserInfo.Username = "lamdoanhnghiep@gmail.com" Then
                'If IsNothing(objmo) Then
                objm = objCTL.CMS_Money_Get(pid, flCheck.Business_ID(pid, us))
                'If IsNothing(objmo) Then
                If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID) = False Then
                    str += "<div class='col-md-12 btn  chitiet'><a  onclick=""xemthongtin()"" Class="" btn-white"" >Thông tin liên hệ đang bị ẩn, để xem thông tin chi tiết vui lòng <span class=""chitiet-tt"">Bấm vào đây</span></a></div>"
                End If
                'End If
                str += "</div>"
                str += "<div class='col-md-12 pdl0 none Xacthuclienhe Xacthuc'>"
                str += "<div class='col-md-12 txt-center xacthuctieude'>Để xem chi tiết CV này! Vui lòng liên hệ với chúng tôi qua số điện thoại</div>"
                str += "<div class='col-md-12 txt-center txt-hotline'>024.66.8182.96</div>"
                str += "</div>"
                str += "<div class='col-md-12 pdl0 none Xacthuchoso'>"
                str += "<div class='col-md-2'></div>"
                str += "<div class='col-md-8 txt-center Xacthuc'>"
                If objCTL.CMS_BusJobFree_count(pid, flCheck.Business_ID(pid, us), 10) <= 0 Then
                    str += "<div class='col-md-12 txt-center xacthuctieude'>Đã hết lượt xem CV miễn phí! Để tiếp tục xem thêm CV, Vui lòng liên hệ với chúng tôi qua số điện thoại</div>"
                    str += "<div class='col-md-12 txt-center txt-hotline'>024.66.8182.96</div>"
                Else
                    str += "<div class='col-md-12 txt-center xacthuctieude'>BẠN CÓ CHẮC LÀ MUỐN XEM CHI TIẾT CV NÀY! </div>"
                    str += "<div class='col-md-12 txt-center xacthuccontent pdl0'> Bạn còn <span class=""sotienconlai""><b>" & objCTL.CMS_BusJobFree_count(pid, flCheck.Business_ID(pid, us), 10) & "</b></span> lượt xem CV miễn phí</div>"

                    str += "<div class='col-md-12 pdl0 txt-xacthuc'>"
                    str += "<div class='col-md-6 txt-center   pdl0'><a class=""xacthuca"" onclick=""thongbaosotien(1,'#moneyalert'," & obj.Appraise & "," & pid & ",'" & id & "')"">Đồng ý</a></div>"
                    str += "<div class='col-md-6 txt-center  pdl0'><a class=""xacthuchuy"" onclick=""thongbaosotien(0,'#moneyalert'," & obj.Appraise & "," & pid & ",'" & id & "')"">Hủy</a></div>"
                    str += "</div>"
                End If

                'str += "<div class='col-md-12 txt-center xacthuctieude'>BẠN CÓ CHẮC LÀ MUỐN XEM CHI TIẾT CV NÀY! </div>"
                'If flCheck.CheckBusJobFree(pid, flCheck.Business_ID(pid, us), obj.JobUser_ID) = False And objCTL.CMS_BusJobFree_count(pid, flCheck.Business_ID(pid, us), 10) <= 0 Then
                '    If IsNothing(objm) = False Then
                '        str += "<div class='col-md-6 txt-center xacthuccontent pdl0'> Bạn còn: <span class=""sotienconlai""><b>" & flReg.FormatPrice(flReg.WriteNumber(objm.TongTienNap + objm.TienKM - objm.TongTienChi)) & "</b> VND</span></div>"
                '    Else
                '        str += "<div class='col-md-6 txt-center xacthuccontent pdl0'> Bạn còn: <span class=""sotienconlai""><b>0</b> VND</span></div>"
                '    End If
                '    str += "<div class='col-md-6 txt-center xacthuccontent pdl0'> Phí xem CV này là: <span class=""sotienconlai""><b>" & flReg.FormatPrice(obj.Appraise) & "</b> VND</span></div>"
                'Else
                '    str += "<div class='col-md-12 txt-center xacthuccontent pdl0'> Bạn còn <span class=""sotienconlai""><b>" & objCTL.CMS_BusJobFree_count(pid, flCheck.Business_ID(pid, us), 10) & "</b></span> lượt xem CV miễn phí</div>"
                'End If

                'str += "<div class='col-md-12 pdl0 txt-xacthuc'>"
                'str += "<div class='col-md-6 txt-center   pdl0'><a class=""xacthuca"" onclick=""thongbaosotien(1,'#moneyalert'," & obj.Appraise & "," & pid & ",'" & id & "')"">Đồng ý</a></div>"
                'str += "<div class='col-md-6 txt-center  pdl0'><a class=""xacthuchuy"" onclick=""thongbaosotien(0,'#moneyalert'," & obj.Appraise & "," & pid & ",'" & id & "')"">Hủy</a></div>"
                'str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class=""col-md-12 b text-info text-center"" id=""moneyalert""></div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"

                str += "<div class='contentjobuser'>"
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
                str += "<div class='col-md-6 wd-row none'><i class='icon-countdown icon_16'></i><span class='pl_28'>Nhu cầu việc làm: " & flCheck.Needs_Name(0, obj.Needs_ID) & "</div>"
                str += "</div></div></div>"
                str += "<div class='clear'></div>"
                'str += "</div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row'>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseTTKN""><i class='fa fa-info'></i>&nbsp;Trình độ, kinh nghiệm</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row none'><i class='icon-exp icon_16'></i><span class='pl_28'>Số năm kinh nghiệm: " & flCheck.Experience_Name(0, obj.Experience_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-exp icon_16'></i><span class='pl_28'>Trình độ chuyên môn: " & flDic.Education_Name(0, obj.Level_ID) & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Quá trình học tập: " & obj.Education.Replace(vbLf, "") & "</div>"
                str += "<div class='col-md-12 wd-row'><i class='icon-edu icon_16'></i><span class='pl_28'>Kinh nghiệm việc làm: " & obj.CareerGoals.Replace(vbLf, "") & "</div>"
                str += " </div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"

                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser none'>"
                str += "<div class='row '>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Thông tin mục tiêu, kỹ năng</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'>Mục tiêu nghề nghiệp: " & obj.WorkExperience.Replace(vbLf, "") & "</div>"
                str += "<div class='col-md-12 wd-row'>Thông tin khác: " & obj.SkillsForte.Replace(vbLf, "") & "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "</div>"
                str += "<div class='clear'></div>"
                str += "<div class='col-md-12'>"
                str += "<div class='detail-jobuser'>"
                str += "<div class='row '>"
                str += "<span class='title_details' data-toggle="" collapse"" data-target=""#collapseMTKN""><i class='fa fa-plane'></i>&nbsp;Ghi chú</span>"
                str += "</div>"
                str += "<div class='row pdt10'>"
                str += "<div class='col-md-12 wd-row'>Để có thông tin chi tiết hơn vui lòng liên hệ với ứng viên hoặc " & flReg.WebConfig("TenDonVi")
                str += "<div class='col-md-6 wd-row chitiet-tt'>Email: " & flReg.WebConfig("Email")
                str += "</div>"
                str += "<div class='col-md-6 wd-row chitiet-tt'>Điện thoại: " & flReg.WebConfig("Hotline") & " </div>"
                str += "</div>"
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
    Public Function DetailJobUser2(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj As New CMS_JUserPublicInfo
        Dim objt As New CMS_JobUserInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            obj = CType(flCache.GetCache("CMS_JUserPublic_Get_" & pid & "_" & id), CMS_JUserPublicInfo)
            If IsNothing(obj) Then
                obj = objCTL.CMS_JUserPublic_Get_ID(pid, id)
                objt = objController.CMS_JobUser_Get(pid, id)
                flCache.SetCache("CMS_JUserPublic_Get_" & pid & "_" & id, obj, SecondCache.M5)
            End If
            If IsNothing(obj) = False Then
                str += "<div class='col-md-12'>"
                str += " <div class='detail-jobuser'>"
                str += " <div class='row'>"
                str += "<div class='col-md-2 txt-center '><div class='box-dn-img'><div class='box-cell'>"
                Dim aInfo As CMS_AppInfo = objController.CMS_App_Get_AppID(pid, obj.UserAdmin)
                If IsNothing(aInfo) = False Then
                    str += " <img src=""" & flReg.UrlAlias & aInfo.Avatar.ToLower() & "?w=140&h=100"" alt='Ảnh đại diện'/></div></div></div>"
                    str += " <div class='col-md-10'>"
                    str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                    str += " <div class='col-md-8'>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & aInfo.HoVaTen.ToUpper() & "</span></div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(aInfo.DienThoai, 3, "C") & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.Regional_Name(0, aInfo.TinhTP) & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                Else

                    str += " <img src=""" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=140&h=100"" alt='" & flReg.ImgAlt(obj.Title) & "'/></div></div></div>"
                    str += " <div class='col-md-10'>"
                    str += "<div class='col-md-12 '><i class='icon-exp icon_16'></i><span class='pl_28'>CV ứng tuyển:&nbsp;<span class='line-icon title_details3 '>" & obj.Title & "</span></span></div>"
                    str += " <div class='col-md-8'>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-position icon_16'></i><span class='pl_28'>Họ tên:&nbsp;" & flDic.getHoTen(0, obj.UserAdmin).ToUpper() & "</span></div>"
                    str += "<div class='col-md-12 pdl0'><i class="" fa fa-envelope-square iconcolor""></i><span class='pl_15'>Email:</span> " & flDic.hideString(flDic.getEmail(0, obj.UserAdmin), 5, "D") & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-countdown icon_16'></i><span class='pl_28'>Điện thoại: " & flDic.hideString(flDic.getTelephone(0, obj.UserAdmin), 3, "C") & "</div>"
                    str += "<div class='col-md-12 pdl0'><i class='icon-address icon_16'></i><span class='pl_28'>Địa chỉ liên hệ: " & flDic.getDiaChi(0, obj.UserAdmin) & "</div>"
                    str += "<div class='clear'></div>"
                    str += "</div>"
                End If
                str += " <div class='col-md-4'>"
                str += "<div>"
                str += "<p>Mã CV:&nbsp&nbsp<span class=""apid-span"">" & flCheck.ReadCode(obj.ID) & "</span></p>"
                str += "</div>"
                If flCheck.CheckInJobView(pid, obj.JobUser_ID, us) Then
                    str += "<div>"
                    str += "<span title='Hồ sơ này đã được lưu vào hệ thống' class=""panel-save""><i class=""fa fa-save""></i> Đã lưu hồ sơ</span>"
                    str += "&nbsp;&nbsp;<span class=""btn btn-white btn-save-job pdbt0""><a onclick=""printDiv('" & pid & "','" & obj.JobUser_ID & "');"" rel=""nofollow"" class=""printview"" style="" margin-right: 5px;"" title=""Print"">"
                    str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span></div>"
                    str += "</div>"
                Else
                    str += "<div><a class=""btn btn-white btn-save-job"" onclick='LuuUngVien(" & pid & ",""" & obj.JobUser_ID & """);' title='Click để lưu lại hồ sơ này' class=""text_grey2"">"
                    str += "<span class=""line-icon""><i class=""icon-star icon_free_style""></i><span class=""pl_28"">Lưu hồ sơ</span></span></a>"
                    str += "&nbsp;&nbsp;<span class=""btn btn-white btn-save-job pdbt0""><a onclick=""printDiv(" & pid & ",'" & obj.JobUser_ID & "','');"" rel=""nofollow"" href=""javascript:;"" class=""printview"" margin-right: 5px;"" title=""Print"">"
                    str += "<img src=""/image/images/print.png?w=20"" alt=""print""/>&nbsp;In hồ sơ</a></span>"
                    str += "</div>"
                End If

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
    Public Function LuuUngVien1(pid As Integer, id As String, username As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim jInfo As New CMS_JobViewInfo
            jInfo.JobView_ID = flReg.GenKey()
            jInfo.IdKey = id

            jInfo.UserName = username
            jInfo.CreateDate = Now
            jInfo.IsFlag = JobView.DoanhNghiepLuu
            objController.CMS_JobView_Add(pid, jInfo)
            obj = objController.CMS_JobUser_Get(pid, id)
            If IsNothing(obj) = False Then
                flFunction.PushNotification(pid, TypeNoti.NguoiLaoDong, obj.UserAdmin, "Mã hồ sơ " & "[" & flCheck.ReadCode(obj.ID) & "]" & "đã được " & flCheck.Business_Vn(pid, flCheck.Business_ID(pid, username)) & " lưu lại", "Hồ sơ <b>" & obj.Title & "</b> đã được doanh nghiệp " & flCheck.Business_Vn(pid, flCheck.Business_ID(pid, username)) & "lưu lại", obj.JobUser_ID, FlagNoti.HoSoCV)
            End If
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
    Public Function setGTVL(pid As String, rid As String, isval As Boolean, isflag As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim obj5 As New CMS_RecruitmentInfo
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Call objController.CMS_GTVL_Update_Acess(pid, rid, isval, isflag, Now, username)
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
            Call objController.CMS_Recruitment_Update_Acess(pid, rid, isval, isflag, Now, username)
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function JobUserList(pid As String, search As String, career_ID As String, salary_ID As String, experience_ID As String, tinhTP As String, ttvl As Integer) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim dem As Integer = 0
        Dim str2 As String
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = objCTL.CMS_JobUser_List_ByTTVL(pid, flNotify.FullTextSearch("", False), 1, 60, "", "", "", 0, ttvl)
            If arr.Count > 0 Then
                dem = 0 : str = "" : str2 = ""
                For Each Cr As CMS_JobUserInfo In arr
                    dem += 1
                    str += "<div class="" row"">"
                    str += "<div class="" col-md-5 col-xs-5"">"
                    str += "<span class="" span-tw"">"
                    str += "<a href=""" & flCheck.GetHomeLinkJobUser(Cr.JobUser_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class="" text_grey2"">" & Cr.Title & "</a>"
                    str += "</span>"
                    str += "</div>"
                    str += "<div class="" col-md-2 col-xs-2"">"
                    str += "<span>" & flDic.getHoTen(pid, Cr.UserAdmin, flConnect.DnnSqlServer(0)) & "</span>"
                    str += "</div>"
                    str += "<div class="" col-md-1 col-xs-1"">"
                    str += "<i class="" icon-age icon_16""></i><br>"
                    str += "<span>" & flDic.getTuoi(flDic.getNgaySinh(pid, Cr.UserAdmin, flConnect.DnnSqlServer(0))) & "</span>"
                    str += "</div>"
                    str += "<div class="" col-md-2 col-xs-2"">"
                    str += "<i class="" icon-money icon_16""></i><br>"
                    str += "<span>" & IIf(Cr.Salary_ID = "", "Thỏa thuận", flCheck.Salary_Name(pid, Cr.Salary_ID)) & "</span>"
                    str += "</div>"
                    str += "<div class="" col-md-2 col-xs-2"">"
                    str += "<i class="" icon-address icon_16""></i><br>"
                    str += "<span class="" lsaddress"">" & flDic.RegionalName(pid, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                    str += "</div>"
                    str += "<div class="" line_list""></div>"
                    str += "</div>"
                    str += "<div class='clear'></div>"
                    If dem = 6 Then
                        str2 += "<div class="" item"">" & str & "</div>"
                        str = "" : dem = 0
                    End If
                Next
            Else
                str2 = "Không có dữ liệu được tìm thấy"
            End If
            data.data = str2
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function PriceList(pid As String, priceType As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        priceType = flReg.WriteNumber(priceType)
        Try
            If priceType <= 0 Then
                arr2 = objCTL.CMS_PriceType_List(pid)
                For Each cr As CMS_PriceTypeInfo In arr2
                    str += "<div Class='title-bg collapsed' data-toggle='collapse' data-target='#banggia_ttg' style='margin-top: 20px; border-top-left-radius: 3px; border-top-right-radius: 3px;'>" & cr.TypePrice_Name & "<i class='fa fa-chevron-down'></i></div>"
                    str += "<table id = 'banggia_ttg' Class='collapse in table table-green table-bordered '>"
                    str += "<tbody>"
                    str += "<tr>"
                    str += "<th class='col-xs-3'> Tên loại dịch vụ</th>"
                    str += "<th class='col-xs-2'> Đơn giá/Thời hạn</th>"
                    str += "<th class='col-xs-3'> Loại dịch vụ</th>"
                    str += "<th class='col-xs-4'> Mô tả</th>"
                    str += "</tr>"

                    arr = objCTL.CMS_PriceList_List_Search(pid, "", 0, 1, 1000, cr.ID)
                    For Each cr2 As CMS_PriceListInfo In arr
                        str += "<tr>"
                        str += "<td><strong> " & cr2.PriceList_Name & "</strong></td>"
                        str += "<td>" & cr2.PriceList_Money & "</td>"
                        str += " <td>" & cr.TypePrice_Name & "</td>"
                        str += " <td> " & cr2.PriceList_Des & "</td>"
                    Next

                    str += "</tbody>"
                    str += "</table>"
                Next
            Else

                arr = objCTL.CMS_PriceList_List_Search(pid, "", 0, 1, 1000, priceType)
                str += "<div Class='title-bg collapsed' data-toggle='collapse' data-target='#banggia_ttg' style='margin-top: 20px; border-top-left-radius: 3px; border-top-right-radius: 3px;'>" & flCheck.PriceType_Name(pid, priceType) & "<i class='fa fa-chevron-down'></i></div>"
                str += "<table id = 'banggia_ttg' Class='collapse in table table-green table-bordered '>"
                str += "<tbody>"
                str += "<tr>"
                str += "<th style='width: 550px; padding-left: 0px;'> Tên loại dịch vụ</th>"
                str += "<th style='width: 300px'> Đơn giá/Thời hạn</th>"
                str += "<th style='width: 540px;'> Loại dịch vụ</th>"
                str += "<th style='width: 600px'> Mô tả</th>"
                str += "</tr>"

                arr = objCTL.CMS_PriceList_List_Search(pid, "", 0, 1, 1000, priceType)
                For Each cr2 As CMS_PriceListInfo In arr
                    str += "<tr>"
                    str += "<td><strong> " & cr2.PriceList_Name & "</strong></td>"
                    str += "<td>" & cr2.PriceList_Money & "</td>"
                    str += " <td>" & flCheck.PriceType_Name(pid, priceType) & "</td>"
                    str += " <td> " & cr2.PriceList_Des & "</td>"
                Next

                str += "</tbody>"
                str += "</table>"
            End If
            data.data = str
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
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