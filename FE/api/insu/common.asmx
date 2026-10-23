<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.INSU
Imports DotNetNuke.VBN
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading
<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private objController As New InsuController
    Dim arr, arr1 As New ArrayList
    Dim pid As Integer = 0
    Dim str As String, acM, acY As Integer
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function traLai(pid As String, id As String, lydo As String, type As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            lydo = flReg.DeCode64(lydo)
            If type = "ProSubsi" Then
                objController.EXE_ProSubsi_Update_TrangThai(pid, id, TrangThaiHS.TraLai, Now, UserInfo.Username, lydo)
            ElseIf type = "Apprentice" Then
                objController.EXE_Apprentice_Update_TrangThai(pid, id, TrangThaiHS.TraLai, Now, UserInfo.Username, lydo)
            ElseIf type = "Advisory" Then
                objController.EXE_Advisory_Update_TrangThai(pid, id, TrangThaiHS.TraLai, Now, UserInfo.Username, lydo)
            Else
                objController.EXE_Notification_Update_TrangThai(pid, id, TrangThaiHS.TraLai, Now, UserInfo.Username, lydo)
            End If
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    Public Sub yearGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_yearGet_" & pid)) Then
                Dim sbj As New APP.ValueInfo
                For i As Integer = 2020 To Now.Year
                    sbj = New APP.ValueInfo
                    sbj.value = i
                    sbj.name = i
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_yearGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_yearGet_" & pid), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = Now.Year
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub portalGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_portalGet_" & pid)) Then
                Dim sbj As New PortalInfo
                For Each Cr As CMS_PortalInfo In objController.CMS_Portal_List_App(pid)
                    sbj = New PortalInfo
                    sbj.portalID = Cr.PortalID
                    sbj.portalName = flReg.RemoveScript(Cr.PortalName, False)
                    sbj.portalName = sbj.portalName.Replace("Trung tâm dịch vụ việc làm", "")
                    sbj.total = Cr.Total
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_portalGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_portalGet_" & pid), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub portalGetNew(type As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            Dim sbj, pbj As New PortalInfo
            If IsNothing(flCache.GetCache("app_portalGetNew_" & pid & "_" & type)) Then
                For Each Cr As CMS_PortalInfo In objController.CMS_Portal_List_App_Type(pid, type)
                    sbj = New PortalInfo
                    sbj.portalID = Cr.PortalID
                    sbj.portalName = flReg.RemoveScript(Cr.PortalName, False)
                    sbj.portalName = sbj.portalName.Replace("Trung tâm dịch vụ việc làm", "")
                    sbj.total = Cr.Total
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_portalGetNew_" & pid & "_" & type, arr)
            Else
                arr = CType(flCache.GetCache("app_portalGetNew_" & pid & "_" & type), ArrayList)
            End If

            If arr.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.message = "Success"
            data.data = arr
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub

    <WebMethod()>
    Public Sub satelliteGet(donVi As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_satelliteGet_" & pid & "_" & donVi)) Then
                Dim sbj As New SatelliteInfo
                For Each Cr As CMS_SatelliteInfo In objController.CMS_Satellite_List_ToApp(pid, donVi)
                    sbj = New SatelliteInfo
                    sbj.satellite_ID = Cr.Satellite_ID
                    sbj.satellite_Name = flReg.RemoveScript(Cr.Satellite_Name, False)
                    sbj.total = Cr.Total
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_satelliteGet_" & pid & "_" & donVi, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_satelliteGet_" & pid & "_" & donVi), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub serviceGet(donVi As Integer, veTinh As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_serviceGet_" & donVi & "_" & veTinh)) Then
                Dim sbj As New ServicesInfo
                For Each Cr As CMS_SettingAutoInfo In objController.CMS_SettingAuto_List_Service(donVi, veTinh)
                    sbj = New ServicesInfo
                    sbj.dichVuID = Cr.FlagType
                    sbj.dichVuName = flCheck.getFlagTypeName(Cr.FlagType)
                    sbj.total = Cr.Total
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_serviceGet_" & donVi & "_" & veTinh, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_serviceGet_" & donVi & "_" & veTinh), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub numberAutoAdd(appID As String, hoTen As String, dienThoai As String, soBHXH As String, ngaySinh As String, ngayNghiViec As String, dichVu As Integer, portalID As Integer, veTinhID As String, sangChieu As String, ngayDangKy As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New EXE_NumberAutoInfo
            obj.NumberAuto_ID = flReg.GenKey()
            obj.NoCode = flCheck.NoCode(portalID, ProType.DKXH)
            obj.HoTen = hoTen
            obj.DienThoai = dienThoai
            obj.SoBHXH = soBHXH
            obj.NgaySinh = flReg.WriteDate(ngaySinh, False)
            obj.NgayNghiViec = flReg.WriteDate(ngayNghiViec, False)
            obj.DichVu = dichVu
            obj.PortalID = portalID
            obj.VeTinhID = veTinhID
            obj.SangChieu = sangChieu
            obj.NgayDangKy = flReg.WriteDate(ngayDangKy, False)
            obj.TinhTrang = numberStatus.DangCho
            obj.CreatedDate = Now
            obj.CreatedUser = appID

            Dim appController As New APP.AppController()
            appController.CMS_App_Update_Insu(pid, appID, hoTen, flReg.WriteDate(ngaySinh, False), soBHXH, dienThoai, APP.flCheck.getAppSystem(pid, dienThoai))

            flCache.RemoveCache("app_doorList_" & portalID & "_" & veTinhID & "_" & dichVu & "_" & ngayNghiViec & "_" & obj.NgayDangKy.Month & "_" & obj.NgayDangKy.Year)
            flCache.RemoveCache("app_doorYear_" & portalID & "_" & veTinhID & "_" & dichVu & "_" & ngayNghiViec)
            flCache.RemoveCache("app_doorYear_" & portalID & "_" & veTinhID & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH)
            flCache.RemoveCache("app_numberAutoList_" & portalID & "_" & dienThoai & "_1_10")
            flCache.RemoveCache("app_numberAutoList_" & portalID & "_" & dienThoai & "_2_10")
            flCache.RemoveCache("app_numberAutoList_" & portalID & "_" & dienThoai & "_3_10")
            flCache.RemoveCache("app_numberAutoList_" & portalID & "_" & dienThoai & "_4_10")
            flCache.RemoveCache("app_numberAutoList_" & portalID & "_" & dienThoai & "_5_10")
            data.status = ServiceStatus.SUCCESS
            str = objController.EXE_NumberAuto_Add(portalID, obj)
            If str <> "0" Then
                obj = objController.EXE_NumberAuto_Get(portalID, obj.NumberAuto_ID)
                If IsNothing(obj) = False Then
                    str = "<div class=""col-xs-12 col-sm-8"">"
                    str += "<p class='tbnote1'>" & flCheck.Portal_Name(0, obj.PortalID).ToUpper() & "</p>"
                    str += "<p class='tbnote2'>" & flCheck.Satellite_Name(0, obj.VeTinhID) & "</p>"
                    str += "<p class='tbnote3'>" & TenDichVu(obj.DichVu) & "</p></div>"
                    str += "<div class=""col-xs-4 col-sm-6 qrcode""><img src=""" & flReg.UrlAlias & bigCode.QRCode(obj.NoCode, flReg.ToEnglish(obj.HoTen).ToUpper() & "; SoBHXH: " & obj.SoBHXH & "; Ngay dang ky: " & obj.NgayDangKy.ToString("dd-MM-yyyy") & " " & obj.GioDangKy & "; STT: " & obj.ThuTu & "; So phieu: ") & """ alt=""Mã hồ sơ""></div>"
                    str += "<div class=""col-xs-8 txt-center col-sm-6"">"
                    str += "<p class=""pdt10"">Mã số đăng ký của bạn là</p>"
                    str += "<div class='txt-center'><img src=""" & flReg.UrlAlias & bigCode.BARCode(obj.NoCode, False) & """ alt=""Mã hồ sơ""></div>"
                    str += "<span class='nocode'>" & obj.NoCode & "</span></div>"
                    str += "<div class=""clear""></div>"
                    str += "<div class=""col-md-12""><p class='tbnote3'>SỐ THỨ TỰ</p><div class='tbnote4'>" & obj.ThuTu & "</div></div>"
                    str += "<div class=""clear""></div>"
                    str += "<div class=""col-md-12 pdt10"">"
                    str += "<p class='tbnote3'>Thông tin đăng ký</p>"
                    str += "<div class='tbnote5'>Họ tên: <b>" & obj.HoTen.ToUpper() & "</b></div>"
                    str += "<div class='tbnote5'>Sổ BHXH: <b>" & obj.SoBHXH & "</b></div>"
                    str += "</div>"
                    str += "<div class=""col-md-12 note"">Bạn cần lưu ý: </div>"
                    str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Thời gian: ngày hẹn <b> " & obj.NgayDangKy.ToString("dd/MM/yyyy") & "</b> vào lúc <b>" & obj.GioDangKy & "</b>, vui lòng đến sớm <b>trước giờ hẹn 15 phút</b>.</div>"
                    'str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Mã Qrcode hoặc Barcode dùng để kiểm tra khi đến làm việc tại đơn vị.</div>"
                    str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Chụp lại màn hình phiếu đăng ký để đối chiếu khi đến làm việc tại điểm đã đăng ký.</div>"
                    str += "<div class=""clear""></div>"
                    str += "<div class=""col-md-12 note"">Bạn cần mang theo: </div>"
                    If dichVu = FlagService.DKBHTN Then          'Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Quyết định nghỉ việc bản gốc hoặc công chứng.</div>"
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Sổ BHXH đã chốt + 1 bản photo.</div>"
                    ElseIf dichVu = FlagService.DKHN Then       'Nộp hồ sơ đăng ký hỗ trợ học nghề
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Quyết định hưởng trợ cấp thất nghiệp (bản gốc).</div>"
                    ElseIf dichVu = FlagService.DKTVGTVL Then   'Nộp hồ sơ đăng ký tư vấn, giới thiệu việc làm
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Quyết định hưởng trợ cấp thất nghiệp (bản gốc).</div>"
                    ElseIf dichVu = FlagService.TBTKVL Then     'Nộp hồ sơ đăng ký thông báo tìm kiếm việc làm
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Quyết định hưởng trợ cấp thất nghiệp (bản gốc).</div>"
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Phiếu khai báo việc làm hàng tháng (bản gốc).</div>"
                    ElseIf dichVu = FlagService.NHANKQ Then     'Nhận kết quả
                        str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>Phiếu hẹn trả kết quả (bản gốc).</div>"
                    End If
                    str += "<div class=""col-md-12 note-1""><i class=""fa fa-check"" aria-hidden=""true""></i>CMND/ Thẻ căn cước/ Hộ chiếu (bản gốc).</div>"
                    str += "<div class=""clear""></div>"
                Else
                    str = 0
                End If
            End If
            data.data = str
            data.message = "Success"
        Catch ex As Exception
            data.data = "0"
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub doorList(donVi As Integer, veTinh As String, dichVu As Integer, ngayNghiViec As String, months As Integer, years As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            Dim sbj As New SettingDoorInfo
            If IsNothing(flCache.GetCache("app_doorList_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & months & "_" & years)) Then
                Dim fDate As Date = flReg.WriteDate(ngayNghiViec, False)
                fDate = New Date(fDate.Year, fDate.Month, fDate.Day, Now.Hour, Now.Minute, Now.Second)
                Dim tDate As Date = fromDate(dichVu, fDate)
                If fDate < Now Then fDate = Now

                arr = objController.CMS_SettingDoor_List_To_App(donVi, veTinh, dichVu, fDate, tDate, months, years)

                For Each Cr As CMS_SettingDoorInfo In arr
                    If (Cr.SAWelcome + Cr.CHWelcome) - (Cr.SARegister + Cr.CHRegister) > 0 Then
                        sbj = New SettingDoorInfo
                        sbj.iD = Cr.ID
                        sbj.satellite_ID = Cr.Satellite_ID
                        sbj.portal_ID = Cr.Portal_ID
                        sbj.flagType = Cr.FlagType
                        sbj.dateSetting = Cr.DateSetting
                        sbj.monthSetting = Cr.MonthSetting
                        sbj.yearSetting = Cr.YearSetting
                        sbj.dayText = Cr.DayText
                        sbj.numDoor = Cr.NumDoor
                        sbj.saWelcome = Cr.SAWelcome
                        sbj.chWelcome = Cr.CHWelcome
                        sbj.totalWelcome = Cr.SAWelcome + Cr.CHWelcome
                        sbj.saRegister = Cr.SARegister
                        sbj.saNumber = sbj.saWelcome - sbj.saRegister
                        sbj.chRegister = Cr.CHRegister
                        sbj.totalRegister = Cr.SARegister + Cr.CHRegister
                        sbj.chNumber = sbj.chWelcome - sbj.chRegister
                        sbj.sumExist = sbj.totalWelcome - sbj.totalRegister
                        sbj.notes = Cr.Notes
                        If Now.Hour <= 12 Then
                            sbj.saWelcome = 0
                        Else
                            sbj.saWelcome = 0
                            sbj.chWelcome = 0
                        End If
                        arr1.Add(sbj)
                    End If
                Next
                flCache.SetCache("app_doorList_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & months & "_" & years, arr1, SecondCache.S3)
            Else
                arr1 = CType(flCache.GetCache("app_doorList_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & months & "_" & years), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub checkRegister(appID As String, donVi As Integer, dichVu As Integer, ngayNghiViec As String, soBHXH As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New EXE_NumberAutoInfo
            If IsNothing(flCache.GetCache("app_checkRegister_" & donVi & "_" & appID & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH)) Then
                obj = objController.EXE_NumberAuto_Check_Register(donVi, dichVu, flReg.WriteDate(ngayNghiViec, False), appID, soBHXH)
                flCache.SetCache("app_checkRegister_" & donVi & "_" & appID & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH, obj, SecondCache.M3)
            Else
                obj = CType(flCache.GetCache("app_checkRegister_" & donVi & "_" & appID & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH), EXE_NumberAutoInfo)
            End If
            If IsNothing(obj) = False Then
                If obj.DichVu >= 5 Then 'Số điện thoại cài quá 5 số sổ BHXH
                    data.data = "Số điện thoại của bạn không được phép đăng ký lấy quá 5 số."
                    data.status = ServiceStatus.FAILED
                ElseIf obj.ThuTu >= 2 Then 'Số sổ bảo hiểm xã hội theo ngày nghỉ việc đã đăng ký lấy số quá 2 lần
                    data.data = "Số sổ BHXH của bạn đã đăng ký lấy số xếp hàng online 2 lần."
                    data.status = ServiceStatus.FAILED
                Else
                    data.status = ServiceStatus.SUCCESS
                End If
            Else
                data.status = ServiceStatus.SUCCESS
            End If
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub doorYear(donVi As Integer, veTinh As String, dichVu As Integer, ngayNghiViec As String, soBHXH As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            Dim sbj As New DoorYearInfo
            If IsNothing(flCache.GetCache("app_doorYear_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH)) Then
                Dim fDate As Date = flReg.WriteDate(ngayNghiViec, False)
                fDate = New Date(fDate.Year, fDate.Month, fDate.Day, Now.Hour, Now.Minute, Now.Second)

                Dim tDate As Date = fromDate(dichVu, fDate)
                If fDate < Now Then fDate = Now

                arr = objController.CMS_SettingDoor_Select_To_App(donVi, veTinh, dichVu, fDate, tDate, soBHXH)
                acM = 0 : acY = 0

                For Each Cr As CMS_SettingDoorInfo In arr
                    If Cr.YearSetting = 1 Then
                        sbj = New DoorYearInfo
                        sbj.yearSetting = Cr.YearSetting
                        sbj.notes = "Số sổ BHXH <b>" & soBHXH & "</b> đã đăng ký lấy số ngày <b>" & Cr.CreatedDate.ToString("dd/MM/yyyy") & "</b>. <br/>"
                        sbj.notes += "Tại:&nbsp;" & flCheck.Satellite_Name(pid, Cr.Satellite_ID)
                        arr1.Add(sbj)
                        Exit For
                    Else
                        If acM = 0 Then
                            acM = Cr.MonthSetting
                            acY = Cr.YearSetting
                        End If
                        sbj = New DoorYearInfo
                        sbj.yearSetting = Cr.YearSetting
                        sbj.monthSetting = Cr.MonthSetting
                        sbj.monthActive = acM
                        sbj.yearActive = acY
                        arr1.Add(sbj)
                    End If
                Next
                flCache.SetCache("app_doorYear_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH, arr1, SecondCache.S3)
            Else
                arr1 = CType(flCache.GetCache("app_doorYear_" & donVi & "_" & veTinh & "_" & dichVu & "_" & ngayNghiViec & "_" & soBHXH), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub numberAutoList(donVi As Integer, appID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            Dim sbj As New NumberAutoInfo
            If IsNothing(flCache.GetCache("app_numberAutoList_" & donVi & "_" & appID & "_" & page & "_" & recod)) Then

                arr = objController.EXE_NumberAuto_Get_ToApp(donVi, appID, page, recod)

                For Each Cr As EXE_NumberAutoInfo In arr
                    sbj = New NumberAutoInfo
                    sbj.qRCode = flReg.UrlAlias & bigCode.QRCode(Cr.NoCode, flReg.ToEnglish(Cr.HoTen).ToUpper() & "; SoBHXH: " & Cr.SoBHXH & "; Ngay dang ky: " & Cr.NgayDangKy.ToString("dd-MM-yyyy") & " " & Cr.GioDangKy & "; STT: " & Cr.ThuTu & "; So phieu: ") & "?dpi=150&quality=100&w=55"
                    sbj.numberAuto_ID = Cr.NumberAuto_ID
                    sbj.noCode = Cr.NoCode
                    sbj.hoTen = Cr.HoTen
                    sbj.dienThoai = Cr.DienThoai
                    sbj.soBHXH = Cr.SoBHXH
                    sbj.ngayNghiViec = flReg.ReadDate(Cr.NgayNghiViec, False)
                    sbj.dichVu = TenDichVu(Cr.DichVu, True)
                    sbj.thuTu = Cr.ThuTu
                    sbj.portalID = Cr.PortalID
                    sbj.veTinhID = flCheck.Satellite_Name(pid, Cr.VeTinhID).Replace("Điểm tiếp nhận ", "").Replace("điểm tiếp nhận ", "")
                    sbj.gioDangKy = Cr.GioDangKy
                    sbj.ngayDangKy = flReg.ReadDate(Cr.NgayDangKy, False)
                    sbj.tinhTrang = Cr.TinhTrang
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_numberAutoList_" & donVi & "_" & appID & "_" & page & "_" & recod, arr1, SecondCache.M10)
            Else
                arr1 = CType(flCache.GetCache("app_numberAutoList_" & donVi & "_" & appID & "_" & page & "_" & recod), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    Private Function TenDichVu(dichVu As Integer, Optional ByVal vietTat As Boolean = False) As String
        TenDichVu = ""
        If vietTat = False Then
            If dichVu = FlagService.DKBHTN Then
                Return "Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp"
            ElseIf dichVu = FlagService.DKHN Then
                Return "Nộp hồ sơ đăng ký hỗ trợ học nghề"
            ElseIf dichVu = FlagService.DKTVGTVL Then
                Return "Nộp hồ sơ đăng ký tư vấn, giới thiệu việc làm"
            ElseIf dichVu = FlagService.TBTKVL Then
                Return "Nộp hồ sơ đăng ký thông báo tìm kiếm việc làm"
            End If
        Else
            If dichVu = FlagService.DKBHTN Then
                Return "Nộp hồ sơ đăng ký hưởng BHTN"
            ElseIf dichVu = FlagService.DKHN Then
                Return "Nộp hồ sơ đăng ký hỗ trợ học nghề"
            ElseIf dichVu = FlagService.DKTVGTVL Then
                Return "Nộp hồ sơ đăng ký tư vấn, GTVL"
            ElseIf dichVu = FlagService.TBTKVL Then
                Return "Nộp hồ sơ đăng ký thông báo TKVL"
            End If
        End If
    End Function
    Private Function fromDate(dv As Integer, tdate As DateTime) As DateTime
        If dv = FlagService.DKBHTN Then
            Return tdate.AddMonths(3)
        Else
            Return Now.AddMonths(3)
        End If
    End Function
    <WebMethod()>
    Public Sub notificationRemove(dvID As Integer, decideID As String, noID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objController.EXE_Notification_Delete(dvID, noID)
            flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_1_10")
            flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_2_10")
            flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_3_10")

            data.data = noID
            data.message = "Success"
        Catch ex As Exception
            data.status = ServiceStatus.FAILED
            data.message = "Error"
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))

    End Sub
    <WebMethod()>
    Public Sub notificationGet(dvID As Integer, noID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New NotificationInfo
            If IsNothing(flCache.GetCache("EXE_Notification_Get_" & noID & "_" & dvID)) Then
                Dim obj As EXE_NotificationInfo = objController.EXE_Notification_Get(dvID, noID)
                Dim dbj As New NotificationDInfo
                If IsNothing(obj) = False Then
                    sbj = New NotificationInfo
                    sbj.notification_ID = obj.Notification_ID
                    sbj.noCode = obj.NoCode
                    sbj.thangHuong = obj.ThangHuong
                    sbj.hoTen = obj.HoTen.Trim()
                    sbj.ngaySinh = flReg.ReadDate(obj.NgaySinh, False)
                    sbj.gioiTinh = obj.GioiTinh
                    sbj.soCMND = obj.SoCMND.Trim()
                    sbj.dienThoai = obj.DienThoai.Trim()
                    sbj.qD_So = obj.QD_So.Trim()
                    sbj.qD_Ngay = flReg.ReadDate(obj.QD_Ngay, False)
                    sbj.qD_ThangHuong = obj.QD_ThangHuong
                    sbj.qD_TuNgay = flReg.ReadDate(obj.QD_TuNgay, False)
                    sbj.qD_DenNgay = flReg.ReadDate(obj.QD_DenNgay, False)
                    sbj.qD_TinhTP = obj.QD_TinhTP
                    sbj.qD_VeTinh = obj.QD_VeTinh
                    sbj.tinhTrang = obj.TinhTrang
                    sbj.neuCoVL = obj.NeuCoVL.Trim()
                    sbj.tT_Khac = obj.TT_Khac.Trim()
                    sbj.portalID = obj.PortalID
                    sbj.portalID = obj.PortalID
                    sbj.trangThai = obj.TrangThai
                    sbj.ngayNopHS = flReg.ReadDate(obj.NgayNopHS, True)
                    sbj.ngayTiepNhan = flReg.ReadDate(obj.NgayTiepNhan, True)
                    sbj.nguoiTiepNhan = obj.NguoiTiepNhan
                    sbj.decide_ID = obj.Decide_ID

                    For Each Ck As EXE_NotificationDInfo In objController.EXE_NotificationD_Get_By_EXE_Notification(dvID, noID)
                        dbj = New NotificationDInfo
                        dbj.tenDonVi = Ck.TenDonVi.Trim()
                        dbj.diaChi = Ck.DiaChi.Trim()
                        dbj.nguoiLienHe = Ck.NguoiLienHe.Trim()
                        dbj.viTriDuTuyen = Ck.ViTriDuTuyen.Trim()
                        dbj.ketQua = Ck.KetQua.Trim()
                        Exit For
                    Next
                    sbj.notiD = dbj

                    flCache.SetCache("EXE_Notification_Get_" & noID & "_" & dvID, sbj, SecondCache.M1)
                    data.status = ServiceStatus.SUCCESS
                Else
                    data.status = ServiceStatus.NODATA
                End If
            Else
                sbj = CType(flCache.GetCache("EXE_Notification_Get_" & noID & "_" & dvID), NotificationInfo)
                data.status = ServiceStatus.SUCCESS
            End If
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.status = ServiceStatus.FAILED
            data.message = "Error"
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))

    End Sub
    <WebMethod()>
    Public Sub notificationList(dvID As Integer, decideID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("EXE_Notification_List_" & decideID & "_" & dvID & "_" & page & "_" & recod)) Then
                Dim sbj As New NotificationInfo
                Dim dbj As New NotificationDInfo
                Dim fbj As New FileAttchInfo
                For Each Cr As EXE_NotificationInfo In objController.EXE_Notification_List_AppID(dvID, page, recod, decideID)
                    sbj = New NotificationInfo
                    sbj.notification_ID = Cr.Notification_ID
                    sbj.noCode = Cr.NoCode
                    sbj.thangHuong = Cr.ThangHuong
                    sbj.hoTen = Cr.HoTen.Trim()
                    sbj.ngaySinh = flReg.ReadDate(Cr.NgaySinh, False)
                    sbj.gioiTinh = Cr.GioiTinh
                    sbj.soCMND = Cr.SoCMND.Trim()
                    sbj.dienThoai = Cr.DienThoai.Trim()
                    sbj.qD_So = Cr.QD_So.Trim()
                    sbj.qD_Ngay = flReg.ReadDate(Cr.QD_Ngay, False)
                    sbj.qD_ThangHuong = Cr.QD_ThangHuong
                    sbj.qD_TuNgay = flReg.ReadDate(Cr.QD_TuNgay, False)
                    sbj.qD_DenNgay = flReg.ReadDate(Cr.QD_DenNgay, False)
                    sbj.qD_TinhTP = Cr.QD_TinhTP
                    sbj.qD_VeTinh = Cr.QD_VeTinh
                    sbj.tinhTrang = Cr.TinhTrang
                    sbj.portalID = Cr.PortalID
                    sbj.neuCoVL = Cr.NeuCoVL.Trim()
                    sbj.tT_Khac = Cr.TT_Khac.Trim()
                    sbj.portalID = Cr.PortalID
                    sbj.trangThai = Cr.TrangThai
                    sbj.ngayNopHS = flReg.ReadDate(Cr.NgayNopHS, True)
                    sbj.ngayTiepNhan = flReg.ReadDate(Cr.NgayTiepNhan, True)
                    sbj.nguoiTiepNhan = Cr.NguoiTiepNhan
                    sbj.decide_ID = Cr.Decide_ID
                    For Each Ck As EXE_NotificationDInfo In objController.EXE_NotificationD_Get_By_EXE_Notification(Cr.PortalID, Cr.Notification_ID)
                        dbj = New NotificationDInfo
                        dbj.tenDonVi = Ck.TenDonVi.Trim()
                        dbj.diaChi = Ck.DiaChi.Trim()
                        dbj.nguoiLienHe = Ck.NguoiLienHe.Trim()
                        dbj.viTriDuTuyen = Ck.ViTriDuTuyen.Trim()
                        dbj.ketQua = Ck.KetQua.Trim()
                        Exit For
                    Next
                    sbj.notiD = dbj
                    arr1 = New ArrayList
                    For Each Ck As EXE_FileAttchInfo In objController.EXE_FileAttch_List_By_IdKey(Cr.PortalID, Cr.Notification_ID)
                        fbj = New FileAttchInfo
                        fbj.fileName = Ck.FileName
                        fbj.filePaths = "http://app.keng.com.vn" & Ck.FilePaths & "?dpi=150&quality=100&w=50"
                        fbj.idKey = Ck.IdKey
                        fbj.iD = Ck.ID
                        arr1.Add(fbj)
                    Next
                    sbj.notiF = arr1
                    arr.Add(sbj)
                Next
                flCache.SetCache("EXE_Notification_List_" & decideID & "_" & dvID & "_" & page & "_" & recod, arr, SecondCache.S2)
            Else
                arr = CType(flCache.GetCache("EXE_Notification_List_" & decideID & "_" & dvID & "_" & page & "_" & recod), ArrayList)
            End If
            If arr.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub notiFAdd(dvID As Integer, noID As String, fileAttach As String, isOrder As Integer)
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            fileAttach = Server.HtmlDecode(fileAttach)
            Dim filebytes() As Byte = Convert.FromBase64String(fileAttach)
            Dim diroot As IO.DirectoryInfo = New IO.DirectoryInfo(Server.MapPath("/DATA/" & pid & "/INSU"))
            If Not diroot.Exists Then diroot.Create()

            fileAttach = "/DATA/" & pid & "/INSU/" & flReg.GenKey() & ".jpg"
            Dim fs As IO.FileStream = New IO.FileStream(Server.MapPath(fileAttach), IO.FileMode.CreateNew, IO.FileAccess.Write, IO.FileShare.None)
            fs.Write(filebytes, 0, filebytes.Length)
            fs.Close()

            Dim obj As New EXE_FileAttchInfo
            obj.ID = flReg.GenKey()
            obj.IdKey = noID
            obj.FilePaths = fileAttach
            obj.FileName = "Phieu_Khai_Bao_" & isOrder & ".jpg"
            obj.IsOrder = isOrder
            obj.Flags = "PKB"
            objController.EXE_FileAttch_Add(dvID, obj)

            data.data = obj.ID
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))


    End Sub
    <WebMethod()>
    Public Sub notificationAdd(dvID As Integer, appID As String, decideID As String, thangHuong As Integer, tinhTrang As Integer,
                               neuCoVL As String, tT_Khac As String, tenDonVi As String, diaChi As String, nguoiLienHe As String,
                               viTriDuTuyen As String, ketQua As String)
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            Dim apCtl As New APP.AppController
            Dim cbj As APP.CMS_DecideInfo = apCtl.CMS_Decide_Get(pid, decideID)
            If IsNothing(cbj) = False Then
                Dim obj As New EXE_NotificationInfo
                obj.Notification_ID = flReg.GenKey()
                obj.NoCode = flCheck.NoCode(dvID, ProType.KBVL)
                obj.HoTen = cbj.HoVaTen
                obj.NgaySinh = cbj.NgaySinh
                obj.GioiTinh = cbj.GioiTinh
                obj.SoCMND = cbj.SoCMND
                obj.NgayCap = flReg.DateNull()
                obj.NoiCap = ""
                obj.DienThoai = cbj.DienThoai
                obj.Email = ""
                obj.CO_TinhTP = cbj.CO_TinhTP
                obj.CO_QuanHuyen = ""
                obj.CO_XaPhuong = ""
                obj.CO_DuongPho = ""
                obj.QD_So = cbj.QD_So
                obj.QD_Ngay = cbj.QD_Ngay
                obj.QD_ThangHuong = cbj.ThangHuong
                obj.QD_TuNgay = cbj.TuNgay
                obj.QD_DenNgay = cbj.DenNgay
                obj.QD_TinhTP = cbj.TinhTP
                obj.QD_VeTinh = cbj.QD_VeTinh

                obj.ThangHuong = thangHuong
                obj.TinhTrang = tinhTrang
                obj.NeuCoVL = Server.HtmlDecode(neuCoVL)
                obj.TT_Khac = Server.HtmlDecode(tT_Khac)
                obj.PortalID = dvID
                obj.TrangThai = TrangThaiHS.DaNop
                obj.NgayNopHS = Now
                obj.NgayTiepNhan = flReg.DateNull
                obj.NguoiTiepNhan = ""
                obj.CreatedDate = Now
                obj.CreatedUser = appID.Trim()
                obj.UpdatedDate = flReg.DateNull
                obj.UpdatedUser = appID.Trim()
                obj.Decide_ID = decideID

                objController.EXE_Notification_Add(dvID, obj)

                Dim dbj As New EXE_NotificationDInfo
                dbj.NotificationD_ID = flReg.GenKey()
                dbj.Notification_ID = obj.Notification_ID
                dbj.TenDonVi = Server.HtmlDecode(tenDonVi)
                dbj.DiaChi = Server.HtmlDecode(diaChi)
                dbj.NguoiLienHe = Server.HtmlDecode(nguoiLienHe)
                dbj.ViTriDuTuyen = Server.HtmlDecode(viTriDuTuyen)
                dbj.KetQua = Server.HtmlDecode(ketQua)
                dbj.IsOrder = 1

                objController.EXE_NotificationD_Add(pid, dbj)

                flCache.RemoveCache("EXE_Notification_Get_" & obj.Notification_ID & "_" & dvID)
                flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_1_10")
                flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_2_10")
                flCache.RemoveCache("EXE_Notification_List_" & decideID & "_" & dvID & "_3_10")

                data.data = obj.Notification_ID
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Else
                data.status = ServiceStatus.FAILED
                data.message = "Error"
            End If
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub warning(type As Integer)
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            If type = 1 Then 'Lấy số xếp hàng
                data.data = "Chức năng lấy số xếp hàng chỉ áp dụng tại Hà Nội, bạn có muốn tiếp tục không?"
                data.status = ServiceStatus.SUCCESS
            ElseIf type = 2 Then 'Khai báo
                data.data = "Chức năng thông báo tìm kiếm việc làm chỉ áp dụng tại Đà Nẵng trong thời điểm hiện tại, bạn có muốn tiếp tục không?"
                data.status = ServiceStatus.SUCCESS
            End If
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
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