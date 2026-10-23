<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim objControler As New WorkController
    Dim objCtl As New AppController
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()
    Dim sVal As String, iCount As Integer
    Dim total As Integer
    Dim foD, toD As DateTime
    Dim arr As New ArrayList, sAr(), str, sCache As String
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
            data.Data = "1"
        Catch ex As Exception
            data.Data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function saveUV(pid As Integer, phien As String, dnghiep As String, email As String, tel As String, hten As String, nkm As String, nghe As String, cmon As String, dchi As String, gtinh As String, nsinh As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New WORK.CMS_UngVienInfo
            obj.UngVien_ID = flReg.GenKey()
            obj.Email = email.Trim()
            obj.Tel = tel.Trim()
            obj.TenDayDu = hten.Trim()
            obj.NguoiTimViec_ID = email.Trim
            obj.LoaiUngVien = WORK.LoaiUngVien.ChuaDangKy
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
            data.Data = obj.UngVien_ID
            If dnghiep <> "" Then
                Dim kbj As New WORK.CMS_DoanhNghiep_UngVienInfo
                kbj.DNUV_ID = flReg.GenKey()
                kbj.DoanhNghiep_ID = dnghiep
                kbj.PhienGD_ID = phien
                kbj.UngVien_ID = obj.UngVien_ID
                kbj.BanPhongVan = 1
                kbj.TinhTrangPhongVan = 0
                kbj.KetQuaPhongVan = 0
                kbj.ChiTietPhongVan = ""
                kbj.ThuTuPhongVan = 1
                For Each Ck As CMS_WorkInfo In objControler.CMS_TuyenDung_List_Search(pid, "", phien, WORK.flCheck.getBusiness_ID(pid, dnghiep), 1)
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
                objControler.CMS_DoanhNghiep_UngVien_Add(pid, kbj)
            End If
        Catch ex As Exception
            data.Data = "ER"
            flReg.BugLog(pid, ex.Message, "works")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    Private Function readNull(val As String) As String
        If val = "undefined" Then
            Return ""
        Else
            Return val
        End If
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function saveView(pid As String, id As String, us As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim jbInfo As New APP.CMS_JobViewInfo
            jbInfo.JobView_ID = flReg.GenKey()
            jbInfo.IdKey = id
            jbInfo.UserName = us
            jbInfo.CreateDate = Now
            jbInfo.IsFlag = 1
            objCtl.CMS_JobView_Add(pid, jbInfo)
            If IsNothing(Context.Request.Cookies("cacheData")) = False Then
                flCache.RemoveCache(Context.Request.Cookies("cacheData").Value)
            End If
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Public Sub SetCookie(val As String)
        Context.Response.Cookies.Add(New HttpCookie("cacheData", val))
    End Sub

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function readSearch(txt As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            txt = readNull(txt).Replace(" ", "+")
            txt = flReg.DeCode64(txt)

            data.data = APP.flCheck.EncodeSearch(txt)
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DsTuyenDung(pid As Integer, vw As String, pages As Integer, nghe As String, tp As String, td As String,
                                vt As String, ml As String, gt As String, title As String, kn As String, vd As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        If IsNothing(Context.Request.Cookies("id_view")) = False Then
            sAr = Context.Request.Cookies("id_view").Value.Split(",")
        End If
        gt = readNull(gt)
        td = readNull(td)

        vt = APP.flCheck.getJobPlace_ID(0, readNull(vt))
        ml = APP.flCheck.getSalary_ID(0, readNull(ml))
        kn = APP.flCheck.getExperience_ID(0, readNull(kn))
        nghe = APP.flCheck.Career_ID(0, flReg.WriteNumber(readNull(nghe)))
        tp = flReg.WriteNumber(readNull(tp))
        title = APP.flCheck.DecodeSearch(readNull(title))
        Select Case flReg.WriteNumber(vd)
            Case 30
                foD = Now.AddMonths(-1)
                foD = New Date(foD.Year, foD.Month, foD.Day, 0, 0, 0)
                toD = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
            Case Else
                foD = New Date(1945, 1, 1, 0, 0, 0)
                toD = New Date(1945, 1, 1, 0, 0, 0)
        End Select
        sCache = vw & "_" & vd & "_" & pages & "_" & nghe & "_" & tp & "_" & td & "_" & vt & "_" & ml & "_" & kn & "_" & gt & "_" & flReg.NameUrl(title)

        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = CType(flCache.GetCache("DsTuyenDung_Data_" & sCache), ArrayList)
            If IsNothing(arr) Then
                arr = objCtl.CMS_Works_List_Pages(pid, pages, 16, nghe, tp, td, vt, ml, kn, gt, title, flReg.RemoveScript(title), foD, toD)
                flCache.SetCache("DsTuyenDung_Data_" & sCache, arr, SecondCache.S9)
            End If
            If vw = "list" Then
                str = ListData(pid, arr, pages)
            Else
                str = GridData(pid, arr, pages)
            End If
            If arr.Count <= 0 Then
                data.data = "Chúng tôi không tìm thấy tin tuyển dụng nào phù hợp với tiêu chí tìm kiếm <br/>"
            Else
                data.data = str
            End If
            data.message = total
        Catch ex As Exception
            data.data = ex.Message
        End Try
        'Try
        '    If flCache.GetCache("clearData") & "" = "True" Then
        '        str = ""
        '        flCache.SetCache("clearData", "False")
        '    Else
        '        str = flCache.GetCache("DsTuyenDung_Data_" & sCache) & ""
        '    End If
        '    Call SetCookie("DsTuyenDung_Data_" & sCache)
        '    total = flReg.WriteNumber(flCache.GetCache("DsTuyenDung_Total_" & sCache))
        '    If str = "" Then
        '        arr = objCtl.CMS_Works_List_Pages(pid, pages, 16, nghe, tp, td, vt, ml, kn, gt, title, flReg.RemoveScript(title), foD, toD)
        '        If vw = "list" Then
        '            str = ListData(pid, arr, pages)
        '        Else
        '            str = GridData(pid, arr, pages)
        '        End If
        '        flCache.SetCache("DsTuyenDung_Data_" & sCache, str, SecondCache.S9)
        '        flCache.SetCache("DsTuyenDung_Total_" & sCache, total, SecondCache.S9)
        '    End If
        '    If arr.Count <= 0 And str = "" Then
        '        data.data = "Chúng tôi không tìm thấy tin tuyển dụng nào phù hợp với tiêu chí tìm kiếm <br/>"
        '    Else
        '        data.data = str
        '    End If
        '    data.message = total
        'Catch ex As Exception
        '    data.data = ex.Message
        'End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    Private Function GridData(pid As Integer, ar As ArrayList, pages As Integer) As String
        GridData = ""
        For Each Cr As CMS_WorksInfo In ar
            GridData += "<div class=""col-md-6 col-lg-6 "">"
            GridData += "<div class=""pd5 item tinTD-gachc " & IIf(Cr.IsClass = classCSS.UuTien3, "clsut3", "") & """>"
            GridData += "<div class=""col-sm-3 col-xs-3 mobile-page-uv"">"
            GridData += "<div class=""company_logo"">"
            GridData += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & "/pages/us-works-list"" title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
            GridData += "<div class=""logo_box "">"
            GridData += "<img class=""lazy-load"" src=""" & flReg.ImgSRC(APP.flCheck.Business_Logo(pid, Cr.Business_ID), 120, 70, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """>"
            GridData += "<div>" & checkView(Cr.Work_ID) & "</div>"
            GridData += "</div>"
            GridData += "</a>"
            GridData += "</div></div>"
            GridData += "<div class=""col-sm-9 col-xs-9"">"
            GridData += "<div class=""content-wd"">"
            GridData += "<div class=""company_name"">"
            GridData += "<p class=""j_title text_ellipsis"">"
            GridData += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & "/pages/us-works-list"" title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
            If Cr.IsClass = classCSS.UuTien3 Then
                GridData += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.UuTien2 Then
                GridData += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.UuTien1 Then
                GridData += "<span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.TinThuong Then
                GridData += "<span class=""clsthuong"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            Else
                GridData += "<span>[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            End If
            GridData += "</p>"
            GridData += "</div>"
            GridData += "<div class=""col-sm-12 pd0"">"
            GridData += "<div class=""j_company"">"
            GridData += "<div class=""text_ellipsis"">"
            GridData += "<a href=""/app-users/view/us-business-detail/itemid/" & Cr.Business_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ >"
            GridData += "<span>" & Cr.Business_Name & "&nbsp;</span>"
            GridData += "</a>"
            GridData += "</div>"
            GridData += "</div>"
            GridData += "</div>"
            GridData += "<div class=""clear""></div>"
            GridData += "<div class=""col-sm-12 pd0"">"
            GridData += "<div class=""extra-info"">"
            GridData += "<div class=""col-sm-4 col-xs-4 pd0 location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(0, Cr.TinhTP, Cr.QuanHuyen) & "</div>"
            GridData += "<div class=""col-sm-4 col-xs-4 pd0 dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & APP.flCheck.Salary_Name(0, Cr.Salary_ID) & "</div>"
            GridData += "<div class=""col-sm-4 col-xs-4 pd0 txt-clxacthuc txt-right"">" & flReg.RelativeTime(Cr.ApprovalDate) & "</div>"
            GridData += "</div>"
            GridData += "</div>"
            GridData += "<div class=""clear""></div>"
            GridData += "</div>"
            GridData += "</div>"
            GridData += "<div class=""clear""></div>"
            GridData += "</div>"
            GridData += "</div>"
        Next
        GridData += "<div class=""clear""></div>"
        For Each Cr As CMS_WorksInfo In arr
            total = Cr.Total
            GridData += flReg.NextPageJs(Cr.Total, 16, pages, 5, "viewData('grid',")
            Exit For
        Next
    End Function

    Private Function ListData(pid As Integer, ar As ArrayList, pages As Integer) As String
        ListData = ""
        For Each Cr As CMS_WorksInfo In ar
            ListData += "<div class=""col-md-12 col-lg-12 item " & IIf(Cr.IsClass = classCSS.UuTien3, "clsut3", "") & " tinTD-gach"">"
            ListData += "<div class=""col-sm-2 col-xs-4 hidden-xs"">"
            ListData += "<div class=""company_logo"">"
            ListData += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & "/pages/us-works-list"" title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
            ListData += "<div class=""logo_box hidden-xs"">"
            ListData += "<img class=""lazy-load"" src=""" & flReg.ImgSRC(APP.flCheck.Business_Logo(pid, Cr.Business_ID), 120, 70, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """>"
            ListData += "<div>" & checkView(Cr.Work_ID) & "</div>"
            ListData += "</div></a></div></div>"
            ListData += "<div class=""col-sm-10"">"

            ListData += "<div class=""content-wd"">"
            ListData += "<div class=""col-sm-10"">"
            ListData += "<div class=""company_name"">"
            ListData += "<p class=""j_title text_ellipsis"">"
            ListData += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & "/pages/us-works-list"" title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"" onclick=""kiemTr()"">"

            If Cr.IsClass = classCSS.UuTien3 Then
                ListData += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.UuTien2 Then
                ListData += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.UuTien1 Then
                ListData += "<span class=""clsthuong clsut1"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            ElseIf Cr.IsClass = classCSS.TinThuong Then
                ListData += "<span class=""clsthuong"">[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            Else
                ListData += "<span>[" & APP.flCheck.ReadCode(Cr.ID) & "]&nbsp;" & Cr.Title & "</span></a>"
            End If
            ListData += "</p></div></div>"
            ListData += "<div class=""col-sm-2 name-td"">"

            ListData += "<div id =""txtdaxem"" class=""txt-right txt-luutin none "">Đã xem</div>"

            ListData += "</div>"
            ListData += "<div class=""col-sm-10 pd0"">"
            ListData += "<div class=""j_company"">"
            ListData += "<div class=""name-td"">"
            ListData += "<a href=""/app-users/view/us-business-detail/itemid/" & Cr.Business_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ >"
            ListData += "<span>" & Cr.Business_Name & "&nbsp;</span>"
            ListData += "</a></div></div></div>"
            ListData += "<div class=""col-sm-2 name-td"">"
            If APP.flCheck.CheckInJobView(pid, Cr.Work_ID, UserInfo.Username) Then
                ListData += "<div class=""txt-right txt-luutin daluu""><i class=""fa fa-heart"" aria-hidden=""True""></i>&nbsp;Đã lưu</div>"
            Else
                ListData += "<div  class=""txt-right txt-luutin""><a onclick='saveWView(this," & pid & ",""" & Cr.Work_ID & """,""" & UserInfo.Username & """)'><i class=""fa fa-heart-o"" aria-hidden=""True""></i>&nbsp;Lưu tin</a></div>"
            End If
            ListData += "</div>"
            ListData += "</div><div class=""clear""></div>"
            ListData += "<div class=""col-sm-10 pd0"">"
            ListData += "<div class=""extra-info"">"
            ListData += "<div title=""Nơi làm việc""  class=""col-sm-3 col-xs-7 pd0 location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(0, Cr.TinhTP, Cr.QuanHuyen) & "</div>"
            ListData += "<div title=""Hạn nộp""  class=""col-sm-3 col-xs-5 pd0 time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
            ListData += "<div title=""Mức lương"" class=""col-sm-3 col-xs-7 pd0 dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & APP.flCheck.Salary_Name(0, Cr.Salary_ID) & "</div>"
            ListData += "<div title=""Số lượng tuyển dụng"" class=""col-sm-3 col-xs-5 pd0 dollar""><i class=""fa fa-filter"" aria-hidden=""true""></i>&nbsp;Số lượng:&nbsp; " & Cr.Quantity & "</div>"

            ListData += "</div></div>"
            ListData += "<div class=""col-sm-2 pd0 txt-right"">"
            ListData += "<div class=""txt-clxacthuc"">" & flReg.RelativeTime(Cr.ApprovalDate) & "</div>"
            ListData += "</div><div class=""clear""></div>"
            ListData += "</div></div></div>"
        Next
        ListData += "</div><div class=""clear""></div>"
        For Each Cr As CMS_WorksInfo In ar
            total = Cr.Total
            ListData += flReg.NextPageJs(Cr.Total, 16, pages, 5, "viewData('list',")
            Exit For
        Next
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function numCount(pid As Integer, nghe As String, tp As String, title As String, id As String, fg As Integer) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            id = readNull(id)
            nghe = APP.flCheck.Career_ID(0, flReg.WriteNumber(readNull(nghe)))
            tp = flReg.WriteNumber(readNull(tp))
            title = APP.flCheck.DecodeSearch(readNull(title))
            sCache = fg & "_" & nghe & "_" & tp & "_" & id & "_" & flReg.NameUrl(title)
            total = flReg.WriteNumber(flCache.GetCache("numCount_" & sCache))
            If total = 0 Then
                Select Case fg
                    Case 6
                        foD = Now.AddMonths(-1)
                        foD = New Date(foD.Year, foD.Month, foD.Day, 0, 0, 0)
                        toD = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
                    Case Else
                        foD = New Date(1945, 1, 1, 0, 0, 0)
                        toD = New Date(1945, 1, 1, 0, 0, 0)
                End Select
                total = objCtl.CMS_Works_Count_Home(pid, tp, nghe, id, foD, toD, title, flReg.RemoveScript(title), fg)
                flCache.SetCache("numCount_" & sCache, total, SecondCache.S10)
            End If
            data.data = total
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
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function values(pid As Integer, isflag As String, tinhTp As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            data.data = objControler.CMS_Work_List_Home(pid, isflag, 10, tinhTp)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"

        Catch ex As Exception
            data.message = "error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
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