<%@ WebService Language="VB" Class="common" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports DotNetNuke.EPORTAL
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

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
    Dim objController As New AppController
    Dim workCtl As New WorkController
    Dim staDay As Integer = 0
    Dim pid As Integer = 0
    Dim arr, arr1, arr2 As New ArrayList
    Dim careInfo As New CMS_CareerInfo
    Dim foD, toD As DateTime
    Dim str(), spage As String, ptrang As Integer
    Dim sbj As New CountInfo

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
    Private Function LinkNganhNghe(id As String) As String
        str = id.Split(",")
        LinkNganhNghe = ""
        For i As Integer = 0 To str.Length - 1
            careInfo = objController.CMS_Career_Get(pid, str(i))
            If IsNothing(careInfo) = False Then
                LinkNganhNghe += flReg.RemoveScript(careInfo.Career_Name, False) & "; "
            End If
        Next
    End Function
    Private Function saveFiles(fileAttch As String, folder As String, fileType As String) As String
        saveFiles = ""
        Try
            If getNull(fileAttch) <> "" Then
                If fileType = "" Then fileType = "jpg"

                fileAttch = Server.HtmlDecode(fileAttch).Replace("data:image/jpeg;base64,", "")
                Dim filebytes() As Byte = Convert.FromBase64String(fileAttch)
                Dim diroot As IO.DirectoryInfo = New IO.DirectoryInfo(Server.MapPath("/DATA/" & pid & "/" & folder))
                If Not diroot.Exists Then diroot.Create()

                saveFiles = "/DATA/" & pid & "/" & folder & "/" & flReg.GenKey() & "." & fileType
                Dim fs As IO.FileStream = New IO.FileStream(Server.MapPath(saveFiles), IO.FileMode.CreateNew, IO.FileAccess.Write, IO.FileShare.None)
                fs.Write(filebytes, 0, filebytes.Length)
                fs.Close()
            End If
        Catch ex As Exception
            saveFiles = ""
        End Try
    End Function
    Public Function HtmlDecode(value As String) As String
        value = Server.HtmlDecode(value)
        value = value.Replace("http://hng.file", "http://app.keng.com.vn")
        Dim arr1 As String() = New String() {"/image/images/center.png", "/image/images/left.png", "/image/images/right.png", "/images/red-error_16px.gif"}
        For i As Integer = 0 To arr1.Length - 1
            value = value.Replace(arr1(i), flConnect.fileDomain & "/image/none.png?dpi=150&quality=100")
        Next
        Return value
    End Function
    Private Function checkFlag(isFlag As Integer) As String
        Select Case isFlag
            Case 1
                Return "<span class='icon-like icon has-text-success'><i class='fa fa-thumbs-up'></i></span>"
            Case 2
                Return "<span class='icon-like icon has-text-danger'><i class='fa fa-thumbs-down'></i></span>"
            Case 3
                Return "<span class='icon-like icon has-text-danger'><i class='fa fa-ban'></i></span>"
            Case Else
                Return "<span class='icon has-text-info'><i class='fa fa-comments'></i></span>"
        End Select
    End Function

    <WebMethod()>
    Public Sub advertiseGet(appID As String, pageLocalID As String, top As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_advertiseGet_" & pageLocalID & "_" & flCheck.getTinhTP(pid, appID))) Then
                Dim sbj As New AdvertiseInfo
                For Each Cr As CMS_AdvertiseInfo In objController.CMS_Advertise_List_Home(pid, flCheck.getTinhTP(pid, appID), pageLocalID, top)
                    sbj = New AdvertiseInfo
                    sbj.advertise_ID = Cr.Advertise_ID
                    sbj.advertise_Name = Cr.Advertise_Name
                    sbj.images = "http://app.keng.com.vn" & Cr.Images & "?dpi=150&quality=100&h=200"
                    sbj.target = Cr.Target
                    sbj.isURL = Cr.IsURL
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_advertiseGet_" & pageLocalID & "_" & flCheck.getTinhTP(pid, appID), arr1, SecondCache.M5)
            Else
                arr1 = CType(flCache.GetCache("app_advertiseGet_" & pageLocalID & "_" & flCheck.getTinhTP(pid, appID)), ArrayList)
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
    Public Sub salaryGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_salaryGet_" & pid)) Then
                Dim cbj As New SalaryInfo
                For Each Cr As CMS_SalaryInfo In objController.CMS_Salary_List(pid)
                    cbj = New SalaryInfo
                    cbj.salary_ID = Cr.Salary_ID
                    cbj.salary_Name = flReg.RemoveScript(Cr.Salary_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_salaryGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_salaryGet_" & pid), ArrayList)
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
    Public Sub ngayGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_ngayGet_" & pid)) Then
                Dim sbj As New ValueInfo
                For i As Integer = 1 To 31
                    sbj = New ValueInfo
                    sbj.value = flReg.FormatNumber(i)
                    sbj.name = flReg.FormatNumber(i)
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_ngayGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_ngayGet_" & pid), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = Now.ToString("dd")
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub thangGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_thangGet_" & pid)) Then
                Dim sbj As New ValueInfo
                For i As Integer = 1 To 12
                    sbj = New ValueInfo
                    sbj.value = flReg.FormatNumber(i)
                    sbj.name = flReg.FormatNumber(i)
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_thangGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_thangGet_" & pid), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = Now.ToString("MM")
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub ngayGets(nam As Integer, thang As String, toDay As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If thang = Now.Month And nam = Now.Year And toDay = 1 Then
                toDay = Now.Day
            Else
                toDay = DateTime.DaysInMonth(nam, flReg.WriteNumber(thang))
            End If
            If IsNothing(flCache.GetCache("app_ngayGets_" & nam & "_" & thang & "_" & toDay)) Then
                Dim sbj As New ValueInfo
                For i As Integer = 1 To toDay
                    sbj = New ValueInfo
                    sbj.value = flReg.FormatNumber(i)
                    sbj.name = flReg.FormatNumber(i)
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_ngayGets_" & nam & "_" & thang & "_" & toDay, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_ngayGets_" & nam & "_" & thang & "_" & toDay), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = Now.ToString("dd")
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub thangGets(nam As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If nam = Now.Year Then
                pid = Now.Month
            Else
                pid = 12
            End If
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_thangGets_" & nam & "_" & pid)) Then
                Dim sbj As New ValueInfo
                For i As Integer = 1 To pid
                    sbj = New ValueInfo
                    sbj.value = flReg.FormatNumber(i)
                    sbj.name = flReg.FormatNumber(i)
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_thangGets_" & nam & "_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_thangGets_" & nam & "_" & pid), ArrayList)
            End If
            If arr1.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr1
            data.message = Now.ToString("MM")
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub namGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_namGet_" & pid)) Then
                Dim sbj As New ValueInfo
                For i As Integer = Now.Year - 15 To 1950 Step -1
                    sbj = New ValueInfo
                    sbj.value = i
                    sbj.name = i
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_namGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_namGet_" & pid), ArrayList)
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
    Public Sub namGets()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_namGet_" & pid)) Then
                Dim sbj As New ValueInfo
                For i As Integer = Now.Year To 1950 Step -1
                    sbj = New ValueInfo
                    sbj.value = i
                    sbj.name = i
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_namGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_namGet_" & pid), ArrayList)
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
    Public Sub getFYears(fYear As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_getFYears_" & fYear)) Then
                Dim sbj As New ValueInfo
                For i As Integer = Now.Year To fYear Step -1
                    sbj = New ValueInfo
                    sbj.value = i
                    sbj.name = i
                    arr1.Add(sbj)
                Next
                flCache.SetCache("app_getFYears_" & fYear, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_getFYears_" & fYear), ArrayList)
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
    Private Sub addCalender(sbj As dayOfMonthInfo, fDate As DateTime)
        staDay = 1
        Select Case fDate.DayOfWeek
            Case 1
                sbj.t2 = fDate.Day()
            Case 2
                sbj.t3 = fDate.Day()
            Case 3
                sbj.t4 = fDate.Day()
            Case 4
                sbj.t5 = fDate.Day()
            Case 5
                sbj.t6 = fDate.Day()
            Case 6
                sbj.t7 = fDate.Day()
            Case Else
                sbj.cn = fDate.Day()
                staDay = 0
        End Select
    End Sub
    <WebMethod()>
    Public Sub dayOfMonth(months As Integer, years As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If months = 0 Then months = Now.Month
            If years = 0 Then years = Now.Year
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_dayOfMonth_" & months & "_" & years)) Then
                Dim sbj As New dayOfMonthInfo
                For days As Integer = 1 To DateTime.DaysInMonth(years, months)
                    If staDay = 0 Then
                        sbj = New dayOfMonthInfo
                        Call addCalender(sbj, New DateTime(years, months, days))
                        arr1.Add(sbj)
                    Else
                        Call addCalender(sbj, New DateTime(years, months, days))
                    End If
                Next
                flCache.SetCache("app_dayOfMonth_" & months & "_" & years, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_dayOfMonth_" & months & "_" & years), ArrayList)
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
    Public Sub positionGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_positionGet_" & pid)) Then
                Dim cbj As New PositionInfo
                For Each Cr As CMS_PositionInfo In flDnn.CMS_Position_List(pid)
                    cbj = New PositionInfo
                    cbj.position_ID = Cr.Position_ID
                    cbj.position_Name = flReg.RemoveScript(Cr.Position_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_positionGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_positionGet_" & pid), ArrayList)
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
    Public Sub educationGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_educationGet_" & pid)) Then
                Dim cbj As New EducationInfo
                For Each Cr As CMS_EducationInfo In flDnn.CMS_Education_List(pid)
                    cbj = New EducationInfo
                    cbj.education_ID = Cr.Education_ID
                    cbj.education_Name = flReg.RemoveScript(Cr.Education_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_educationGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_educationGet_" & pid), ArrayList)
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
    Public Sub experienceGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_experienceGet_" & pid)) Then
                Dim cbj As New ExperienceInfo
                For Each Cr As CMS_ExperienceInfo In objController.CMS_Experience_List(pid)
                    cbj = New ExperienceInfo
                    cbj.experience_ID = Cr.Experience_ID
                    cbj.experience_Name = flReg.RemoveScript(Cr.Experience_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_experienceGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_experienceGet_" & pid), ArrayList)
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
    Public Sub needsGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_needsGet_" & pid)) Then
                Dim cbj As New NeedsInfo
                For Each Cr As CMS_NeedsInfo In objController.CMS_Needs_List(pid)
                    cbj = New NeedsInfo
                    cbj.needs_ID = Cr.Needs_ID
                    cbj.needs_Name = flReg.RemoveScript(Cr.Needs_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_needsGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_needsGet_" & pid), ArrayList)
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
    Public Sub careerList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_careerList_" & pid)) Then
                Dim cbj As New CareerInfo
                cbj = New CareerInfo
                cbj.career_ID = ""
                cbj.career_Name = "Tất cả nghề"
                arr1.Add(cbj)
                For Each Cr As CMS_CareerInfo In objController.CMS_Career_List(0)
                    cbj = New CareerInfo
                    cbj.career_ID = Cr.Career_ID
                    cbj.career_Name = flReg.RemoveScript(Cr.Career_Name, False)
                    arr1.Add(cbj)
                Next

                flCache.SetCache("app_careerList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_careerList_" & pid), ArrayList)
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
    Public Sub careerGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_careerGet_" & pid)) Then
                Dim cbj As New CareerInfo
                For Each Cr As CMS_CareerInfo In objController.CMS_Career_List(0)
                    cbj = New CareerInfo
                    cbj.career_ID = Cr.Career_ID
                    cbj.career_Name = flReg.RemoveScript(Cr.Career_Name, False)
                    arr1.Add(cbj)
                Next

                flCache.SetCache("app_careerGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_careerGet_" & pid), ArrayList)
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
    Public Sub regionalGet()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_regionalGet_" & pid)) Then
                Dim cbj As New RegionalInfo
                For Each Cr As CMS_RegionalInfo In flDnn.CMS_Regional_List_Parent_Null(0)
                    Cr.Regional_Name = flReg.RemoveScript(Cr.Regional_Name, False)
                    Cr.Regional_Name = Cr.Regional_Name.Replace("Tỉnh ", "").Trim()
                    Cr.Regional_Name = Cr.Regional_Name.Replace("Thành phố ", "").Trim()

                    cbj = New RegionalInfo
                    cbj.regional_ID = Cr.Regional_ID
                    cbj.regional_Name = Cr.Regional_Name
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_regionalGet_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_regionalGet_" & pid), ArrayList)
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
    Private Function repName(name As String) As String
        repName = name.Replace("Tỉnh ", "").Replace("Thành phố ", "TP.")
        repName = repName.Replace("Quận ", "Q.").Replace("Huyện ", "")
        repName = repName.Replace("Thị Xã ", "TX.").Replace("Xã ", "")
        repName = repName.Replace("Phường ", "P.").Replace("Thị trấn ", "TT.").Trim()
    End Function
    <WebMethod()>
    Public Sub regionalList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_regionalList_" & pid)) Then
                Dim cbj As New RegionalInfo
                cbj = New RegionalInfo
                cbj.regional_ID = "0"
                cbj.regional_Name = "Tất cả tỉnh"
                arr1.Add(cbj)

                For Each Cr As CMS_RegionalInfo In flDnn.CMS_Regional_List_Parent_Null(pid)
                    cbj = New RegionalInfo
                    cbj.regional_ID = Cr.Regional_ID
                    cbj.regional_Name = repName(flReg.RemoveScript(Cr.Regional_Name, False))
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_regionalList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_regionalList_" & pid), ArrayList)
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
    Public Sub religionList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_religionList_" & pid)) Then
                Dim cbj As New ReligionInfo
                For Each Cr As CMS_ReligionInfo In flDnn.CMS_Religion_List(pid)
                    cbj = New ReligionInfo
                    cbj.religion_ID = Cr.Religion_ID
                    cbj.religion_Name = flReg.RemoveScript(Cr.Religion_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_religionList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_religionList_" & pid), ArrayList)
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
    Public Sub nationalList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_nationalList_" & pid)) Then
                Dim cbj As New NationalInfo
                For Each Cr As CMS_NationalInfo In flDnn.CMS_National_List(pid)
                    cbj = New NationalInfo
                    cbj.national_ID = Cr.National_ID
                    cbj.national_Name = flReg.RemoveScript(Cr.National_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_nationalList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_nationalList_" & pid), ArrayList)
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
    Public Sub relationList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_relationList_" & pid)) Then
                Dim cbj As New RelationInfo
                For Each Cr As CMS_RelationInfo In flDnn.CMS_Relation_List(pid)
                    cbj = New RelationInfo
                    cbj.relation_ID = Cr.Relation_ID
                    cbj.relation_Name = flReg.RemoveScript(Cr.Relation_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_relationList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_relationList_" & pid), ArrayList)
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
    Public Sub nationList()
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_nationList_" & pid)) Then
                Dim cbj As New NationInfo
                For Each Cr As CMS_NationInfo In flDnn.CMS_Nation_List(pid)
                    cbj = New NationInfo
                    cbj.nation_ID = Cr.Nation_ID
                    cbj.nation_Name = flReg.RemoveScript(Cr.Nation_Name, False)
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_nationList_" & pid, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_nationList_" & pid), ArrayList)
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
    Public Sub regionalListByParent(regionID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_regionalListByParent_" & pid & "_" & regionID)) Then
                Dim cbj As New RegionalInfo
                cbj = New RegionalInfo
                cbj.regional_ID = "0"
                cbj.regional_Name = "Tất cả"
                arr1.Add(cbj)
                For Each Cr As CMS_RegionalInfo In flDnn.CMS_Regional_Get_By_CMS_Regional(pid, regionID)
                    cbj = New RegionalInfo
                    cbj.regional_ID = Cr.Regional_ID
                    cbj.regional_Name = repName(flReg.RemoveScript(Cr.Regional_Name, False))
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_regionalListByParent_" & pid & "_" & regionID, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_regionalListByParent_" & pid & "_" & regionID), ArrayList)
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
    Public Sub regionalParent(regionID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If IsNothing(flCache.GetCache("app_regionalParent_" & pid & "_" & regionID)) Then
                Dim cbj As New RegionalInfo
                For Each Cr As CMS_RegionalInfo In flDnn.CMS_Regional_Get_By_CMS_Regional(pid, regionID)
                    cbj = New RegionalInfo
                    cbj.regional_ID = Cr.Regional_ID
                    cbj.regional_Name = repName(flReg.RemoveScript(Cr.Regional_Name, False))
                    arr1.Add(cbj)
                Next
                flCache.SetCache("app_regionalParent_" & pid & "_" & regionID, arr1)
            Else
                arr1 = CType(flCache.GetCache("app_regionalParent_" & pid & "_" & regionID), ArrayList)
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
    Public Sub worksFind(token As String, appID As String, pages As Integer, nghe As String, tp As String, td As String,
                                vt As String, ml As String, gt As String, title As String, kn As String, vd As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            vd = flReg.WriteNumber(vd)
            If vd = 6 Then
                foD = Now.AddMonths(-1)
                foD = New Date(foD.Year, foD.Month, foD.Day, 0, 0, 0)
                toD = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
            Else
                foD = New Date(1945, 1, 1, 0, 0, 0)
                toD = New Date(1945, 1, 1, 0, 0, 0)
            End If
            tp = flReg.WriteNumber(tp)
            arr = New ArrayList
            spage = "app_worksFind_" & vd & "_" & pages & "_" & nghe & "_" & tp & "_" & td & "_" & vt & "_" & ml & "_" & kn & "_" & gt & "_" & flReg.NameUrl(title)
            If IsNothing(flCache.GetCache(spage)) Then
                Dim sbj As New WorksInfo
                For Each Cr As CMS_WorksInfo In objController.CMS_Works_List_Pages_ToApp(pid, pages, 7, nghe, tp, td, vt, ml, kn, gt, title, flReg.RemoveScript(title), foD, toD)
                    sbj = New WorksInfo
                    sbj.ID = Cr.ID
                    sbj.work_ID = Cr.Work_ID
                    sbj.business_ID = Cr.Business_ID
                    sbj.logo = "http://app.keng.com.vn" & flCheck.Business_Logo(pid, Cr.Business_ID) & "?dpi=150&quality=100&w=150&h=150"
                    sbj.title = flReg.RemoveScript(Cr.Title, False)
                    sbj.business_Name = flReg.RemoveScript(Cr.Business_Name, False)
                    sbj.expiredDate = flReg.ReadDate(Cr.ExpiredDate, False)
                    sbj.tinhTP = flDic.RegionalName(pid, Cr.TinhTP, "")
                    sbj.isClass = Cr.IsClass
                    sbj.quanHuyen = Cr.QuanHuyen
                    sbj.experience_ID = Cr.Experience_ID
                    sbj.salary_ID = Cr.Salary_ID
                    sbj.salary_Name = flCheck.Salary_Name(pid, Cr.Salary_ID)
                    sbj.experience_Name = flCheck.Experience_Name(pid, Cr.Experience_ID)
                    sbj.total = Cr.Total
                    arr.Add(sbj)
                Next
                flCache.SetCache(spage, arr, SecondCache.S10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache(spage), ArrayList)
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
    Public Sub worksList(token As String, search As String, tinhTP As Integer, careerID As String, salaryID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_worksList_" & search & "_" & tinhTP & "_" & careerID & "_" & salaryID & "_" & page & "_" & recod)) Then
                Dim sbj As New WorksInfo
                For Each Cr As CMS_WPublicInfo In objController.CMS_WPublic_List_TinhTP(pid, flReg.RemoveScript(search), tinhTP, careerID, salaryID, page, recod)
                    sbj = New WorksInfo
                    sbj.ID = Cr.ID
                    sbj.work_ID = Cr.Work_ID
                    sbj.business_ID = Cr.Business_ID
                    sbj.logo = "http://app.keng.com.vn" & flCheck.Business_Logo(pid, Cr.Business_ID) & "?dpi=150&quality=100&w=150&h=150"
                    sbj.title = flReg.RemoveScript(Cr.Title, False)
                    sbj.business_Name = flReg.RemoveScript(Cr.Business_Name, False)
                    sbj.expiredDate = flReg.ReadDate(Cr.ExpiredDate, False)
                    sbj.tinhTP = flDic.RegionalName(pid, Cr.TinhTP, "")
                    sbj.isClass = Cr.IsClass
                    sbj.quanHuyen = Cr.QuanHuyen
                    sbj.experience_ID = Cr.Experience_ID
                    sbj.salary_ID = Cr.Salary_ID
                    sbj.salary_Name = flCheck.Salary_Name(pid, Cr.Salary_ID)
                    sbj.experience_Name = flCheck.Experience_Name(pid, Cr.Experience_ID)

                    arr.Add(sbj)
                Next
                flCache.SetCache("app_worksList_" & search & "_" & tinhTP & "_" & careerID & "_" & salaryID & "_" & page & "_" & recod, arr, SecondCache.S10)
            Else
                arr = CType(flCache.GetCache("app_worksList_" & search & "_" & tinhTP & "_" & careerID & "_" & salaryID & "_" & page & "_" & recod), ArrayList)
            End If
            If arr.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub worksRelate(token As String, appID As String, workID As String, top As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_worksRelate_" & workID & "_" & top)) Then
                Dim sbj As New WorksInfo
                For Each Cr As CMS_WPublicInfo In objController.CMS_WPublic_List_TinhTP_Relate(pid, workID, top)
                    sbj = New WorksInfo
                    sbj.ID = Cr.ID
                    sbj.work_ID = Cr.Work_ID
                    sbj.business_ID = Cr.Business_ID
                    sbj.logo = "http://app.keng.com.vn" & flCheck.Business_Logo(pid, Cr.Business_ID) & "?dpi=150&quality=100&w=150&h=150"
                    sbj.title = flReg.RemoveScript(Cr.Title, False)
                    sbj.business_Name = flReg.RemoveScript(Cr.Business_Name, False)
                    sbj.expiredDate = flReg.ReadDate(Cr.ExpiredDate, False)
                    sbj.tinhTP = flDic.RegionalName(pid, Cr.TinhTP, "")
                    sbj.isClass = Cr.IsClass
                    sbj.quanHuyen = Cr.QuanHuyen
                    sbj.experience_ID = Cr.Experience_ID
                    sbj.salary_ID = Cr.Salary_ID
                    sbj.salary_Name = flCheck.Salary_Name(pid, Cr.Salary_ID)
                    sbj.experience_Name = flCheck.Experience_Name(pid, Cr.Experience_ID)

                    arr.Add(sbj)
                Next
                flCache.SetCache("app_worksRelate_" & workID & "_" & top, arr, SecondCache.M3)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_worksRelate_" & workID & "_" & top), ArrayList)
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
    Public Sub worksGet(appID As String, workID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New WPublicInfo
            If IsNothing(flCache.GetCache("app_worksGet_" & workID)) Then
                Dim obj As CMS_WPublicInfo = objController.CMS_WPublic_Get(pid, workID)
                If IsNothing(obj) = False Then
                    objController.CMS_Works_Update_View(pid, workID)

                    sbj = New WPublicInfo
                    sbj.iDCode = flCheck.ReadCode(obj.ID)
                    sbj.work_ID = obj.Work_ID
                    sbj.business_ID = obj.Business_ID
                    sbj.business_Name = obj.Business_Name
                    sbj.business_Logo = "http://app.keng.com.vn" & flCheck.Business_Logo(pid, obj.Business_ID) & "?dpi=150&quality=100&w=50&h=50"
                    sbj.business_Address = flCheck.Business_Address(pid, obj.Business_ID)
                    sbj.title = flReg.RemoveScript(obj.Title, False)
                    sbj.salary_Name = flCheck.Salary_Name(pid, obj.Salary_ID)
                    sbj.quantity = obj.Quantity
                    sbj.experience_Name = flCheck.Experience_Name(pid, obj.Experience_ID)
                    sbj.gender = flCheck.GioiTinh(obj.Gender)
                    sbj.level_Name = flDic.Education_Name(pid, obj.Level_ID)
                    sbj.diaDiem = flDic.RegionalName(pid, obj.TinhTP, obj.QuanHuyen)
                    sbj.typeOf_Name = flCheck.TypeOf_Name(pid, obj.TypeOf_ID)
                    sbj.career_Name = LinkNganhNghe(obj.Career_ID)
                    sbj.description = flReg.RemoveScript(obj.Description, False).Replace(vbLf, "<br/>")
                    sbj.requirement = flReg.RemoveScript(obj.Requirement, False).Replace(vbLf, "<br/>")
                    sbj.benefit = flReg.RemoveScript(obj.Benefit, False).Replace(vbLf, "<br/>")
                    sbj.requirementsProfile = flReg.RemoveScript(obj.RequirementsProfile, False).Replace(vbLf, "<br/>")
                    sbj.expiredDate = flReg.ReadDate(obj.ExpiredDate, False)
                    sbj.submissionSend = flReg.RemoveScript(obj.SubmissionSend, False)
                    sbj.startDate = flReg.ReadDate(obj.StartDate, False)
                    sbj.endDate = flReg.ReadDate(obj.EndDate, False)
                    sbj.contactUser = flReg.RemoveScript(obj.ContactUser, False)
                    sbj.contactAddress = flReg.RemoveScript(obj.ContactAddress, False)
                    sbj.contactMobile = flReg.RemoveScript(obj.ContactMobile, False)
                    sbj.contactEmail = flReg.RemoveScript(obj.ContactEmail, False)
                    sbj.contactDes = flReg.RemoveScript(obj.ContactDes, False).Replace(vbLf, "<br/>")
                    sbj.createdDate = flReg.ReadDate(obj.CreatedDate, False)
                    sbj.levelDesired_Name = flDic.Position_Name(pid, obj.LevelDesired_ID)
                    sbj.isView = obj.IsView
                    sbj.isFlag = obj.IsFlag
                    sbj.jobPlace = flCheck.JobPlace_Name(pid, obj.JobPlace)
                    sbj.nopHoSo = False

                    Dim reInfo As New CMS_RecruitmentInfo
                    If IsNothing(flCache.GetCache("CMS_Recruitment_List_UserName_" & obj.Work_ID & "_" & appID)) Then
                        reInfo = objController.CMS_Recruitment_List_UserName(pid, obj.Work_ID, appID)
                    Else
                        reInfo = CType(flCache.GetCache("CMS_Recruitment_List_UserName_" & obj.Work_ID & "_" & appID), CMS_RecruitmentInfo)
                    End If
                    If IsNothing(reInfo) = False Then
                        flCache.SetCache("CMS_Recruitment_List_UserName_" & obj.Work_ID & "_" & appID, reInfo, SecondCache.M30)
                        sbj.nopHoSo = True
                    End If
                End If
                flCache.SetCache("app_worksGet_" & workID, sbj, SecondCache.M10)
            Else
                sbj = CType(flCache.GetCache("app_worksGet_" & workID), WPublicInfo)
            End If

            data.status = ServiceStatus.SUCCESS
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub businessGet(business_ID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New BusinessInfo
            If IsNothing(flCache.GetCache("app_businessGet_" & business_ID)) Then
                Dim obj As CMS_BusinessInfo = objController.CMS_Business_Get(pid, business_ID)
                If IsNothing(obj) = False Then
                    sbj = New BusinessInfo
                    sbj.business_ID = obj.Business_ID
                    sbj.business_Vn = obj.Business_Vn
                    sbj.logo = flReg.ImgSRC(obj.Logo, 0, 100, True, "logo-dn.png", "http://app.keng.com.vn")
                    sbj.address = obj.Address
                    sbj.description = flReg.RemoveScript(obj.Description, False)
                    sbj.xemThem = False
                    If sbj.description.Length > 120 Then
                        sbj.desLength = sbj.description.Substring(0, 120)
                        sbj.xemThem = True
                    End If
                    sbj.website = obj.Website
                    sbj.scale = obj.Scale
                    sbj.isApproval = obj.IsApproval
                    sbj.total = obj.Total

                    Dim objM As CMS_ReviewMInfo = objController.CMS_Review_DashBoard(pid, business_ID, 1)
                    If IsNothing(objM) = False Then
                        sbj.countReview = flReg.FormatNumber(objM.CountReview)
                        sbj.countLike = flReg.FormatNumber(objM.CountLike)
                        sbj.countDisLike = flReg.FormatNumber(objM.CountDisLike)
                        sbj.countRemove = flReg.FormatNumber(objM.CountRemove)
                    End If
                End If
                flCache.SetCache("app_businessGet_" & business_ID, sbj, SecondCache.M10)
            Else
                sbj = CType(flCache.GetCache("app_businessGet_" & business_ID), BusinessInfo)
            End If
            data.status = ServiceStatus.SUCCESS
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub uIDGet(uID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New BusinessInfo
            If IsNothing(flCache.GetCache("app_Business_Get_ID_" & uID)) Then
                Dim obj As CMS_BusinessInfo = objController.CMS_Business_Get_ID(pid, flReg.WriteNumber(uID))
                If IsNothing(obj) = False Then
                    sbj = New BusinessInfo
                    sbj.iD = obj.ID
                    sbj.business_ID = obj.Business_ID
                    sbj.business_Vn = obj.Business_Vn
                    If obj.Logo <> "" Then
                        sbj.logo = "http://app.keng.com.vn/" & obj.Logo.ToLower() & "?dpi=150&quality=100&w=180"
                    Else
                        sbj.logo = "/assets/images/noimage.png"
                    End If
                    sbj.address = obj.Address
                    sbj.description = flReg.RemoveScript(obj.Description, False)
                    sbj.xemThem = False
                    If sbj.description.Length > 120 Then
                        sbj.desLength = sbj.description.Substring(0, 120)
                        sbj.xemThem = True
                    End If
                    sbj.website = obj.Website
                    sbj.scale = obj.Scale
                    sbj.isApproval = obj.IsApproval
                    sbj.total = obj.Total
                End If
                flCache.SetCache("app_Business_Get_ID_" & uID, sbj, SecondCache.M10)
            Else
                sbj = CType(flCache.GetCache("app_Business_Get_ID_" & uID), BusinessInfo)
            End If
            data.status = ServiceStatus.SUCCESS
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub businessGetAppID(appID As String, setToken As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New BusinessUserInfo
            If IsNothing(flCache.GetCache("app_businessGetAppID_" & appID & "_" & setToken)) Then
                Dim obj As CMS_BusinessInfo = objController.CMS_Business_Get_ByAppID(pid, appID)
                If IsNothing(obj) = False Then
                    sbj = New BusinessUserInfo
                    sbj.iD = obj.ID
                    sbj.business_ID = obj.Business_ID
                    sbj.business_Name = obj.Business_Vn
                    sbj.logo = "http://app.keng.com.vn" & obj.Logo & "?dpi=150&quality=100&w=150"
                    sbj.address = obj.Address
                    sbj.website = obj.Website
                    sbj.employeeCode = obj.EmployeeCode
                    sbj.departmentCode = obj.DepartmentCode
                    sbj.appName = flCheck.getAppFullName(pid, appID)
                    sbj.tokenManager = Keng.flFunction.getToken(obj.ID, flReg.SettingValue(flConnect.DmConnect, "keng-manager", "KENG_NOTI_" & setToken & "_" & obj.ID, "setting-noti"))
                End If
                flCache.SetCache("app_businessGetAppID_" & appID & "_" & setToken, sbj, SecondCache.M10)
            Else
                sbj = CType(flCache.GetCache("app_businessGetAppID_" & appID & "_" & setToken), BusinessUserInfo)
            End If
            data.status = ServiceStatus.SUCCESS
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub businessWorks(business_ID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_businessWorks_" & business_ID & "_" & page & "_" & recod)) Then
                Dim sbj As New WorksInfo
                For Each Cr As CMS_WorksInfo In objController.CMS_Works_List_By_Business_Home(pid, business_ID, pid, page, recod)
                    sbj = New WorksInfo
                    sbj.ID = Cr.ID
                    sbj.work_ID = Cr.Work_ID
                    sbj.business_ID = Cr.Business_ID
                    sbj.logo = "http://app.keng.com.vn" & flCheck.Business_Logo(pid, Cr.Business_ID) & "?dpi=150&quality=100&w=150"
                    sbj.title = flReg.RemoveScript(Cr.Title, False)
                    sbj.business_Name = flReg.RemoveScript(Cr.Business_Name, False)
                    sbj.expiredDate = flReg.ReadDate(Cr.ExpiredDate, False)
                    sbj.tinhTP = flDic.Regional_Name(pid, Cr.TinhTP, "", True)
                    sbj.isClass = Cr.IsClass
                    sbj.quanHuyen = Cr.QuanHuyen
                    sbj.experience_ID = Cr.Experience_ID
                    sbj.salary_ID = Cr.Salary_ID
                    sbj.salary_Name = flCheck.Salary_Name(pid, Cr.Salary_ID)
                    sbj.experience_Name = flCheck.Experience_Name(pid, Cr.Experience_ID)

                    arr.Add(sbj)
                Next
                flCache.SetCache("app_businessWorks_" & business_ID & "_" & page & "_" & recod, arr, SecondCache.M3)
            Else
                arr = CType(flCache.GetCache("app_businessWorks_" & business_ID & "_" & page & "_" & recod), ArrayList)
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
    Public Sub newsFindUID(token As String, appID As String, find As String, uID As Integer, cateID As Integer, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If uID <> 0 Then
                If IsNothing(flCache.GetCache("app_newsFindUID_" & flReg.NameUrl(find) & "_" & uID & "_" & cateID & "_" & page & "_" & recod)) Then
                    arr1 = objController.CMS_News_List_AppFind(pid, CMS.Ultis.FullTextSearch(find.Trim, False), uID, cateID, page, recod)
                    Dim sbj As New NewsInfo
                    For Each Cr As CMS_NewsInfo In arr1
                        sbj = New NewsInfo
                        sbj.newsID = Cr.NewsID
                        sbj.summary = flReg.RemoveScript(Cr.Summary, False)
                        sbj.publishedDate = flReg.ReadDate(Cr.PublishedDate)
                        sbj.imagePath = ""
                        If cateID = 2 Or cateID = -3 And Cr.ImagePath <> "" Then
                            sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&h=400"
                            sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                        ElseIf Cr.ImagePath <> "" Then
                            sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&w=200"
                            sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                        Else
                            sbj.imagePath = "NULL"
                            sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                        End If
                        sbj.isView = Cr.IsView
                        sbj.isLike = Cr.IsLike
                        sbj.toUrl = Cr.ToUrl
                        arr.Add(sbj)
                    Next
                    flCache.SetCache("app_newsFindUID_" & flReg.NameUrl(find) & "_" & uID & "_" & cateID & "_" & page & "_" & recod, arr, SecondCache.M3)
                    objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
                Else
                    arr = CType(flCache.GetCache("app_newsFindUID_" & flReg.NameUrl(find) & "_" & uID & "_" & cateID & "_" & page & "_" & recod), ArrayList)
                End If
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
    Public Sub newsFind(token As String, appID As String, find As String, cateID As Integer, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_newsFind_" & flReg.NameUrl(find) & "_" & cateID & "_" & page & "_" & recod)) Then
                arr1 = objController.CMS_News_List_AppFind(pid, CMS.Ultis.FullTextSearch(find.Trim, False), flCheck.getTinhTP(pid, appID), cateID, page, recod)
                Dim sbj As New NewsInfo
                For Each Cr As CMS_NewsInfo In arr1
                    sbj = New NewsInfo
                    sbj.newsID = Cr.NewsID
                    sbj.summary = flReg.RemoveScript(Cr.Summary, False)
                    sbj.publishedDate = flReg.ReadDate(Cr.PublishedDate)
                    sbj.imagePath = ""
                    If cateID = 2 Or cateID = -3 And Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&h=400"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                    ElseIf Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&w=200"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                    Else
                        sbj.imagePath = "NULL"
                        sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    End If
                    sbj.isView = Cr.IsView
                    sbj.isLike = Cr.IsLike
                    sbj.toUrl = Cr.ToUrl
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_newsFind_" & flReg.NameUrl(find) & "_" & cateID & "_" & page & "_" & recod, arr, SecondCache.M10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_newsFind_" & flReg.NameUrl(find) & "_" & cateID & "_" & page & "_" & recod), ArrayList)
            End If

            If arr.Count > 0 Then
                data.status = ServiceStatus.SUCCESS
            Else
                data.status = ServiceStatus.NODATA
            End If
            data.data = arr
            data.message = CMS.Ultis.FullTextSearch("chấm công", False)
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub newsList(token As String, appID As String, cateID As Integer, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_newsList_" & cateID & "_" & page & "_" & recod)) Then
                Dim sbj As New NewsInfo
                For Each Cr As CMS_NewsInfo In objController.CMS_News_List_TinhTP(pid, flCheck.getTinhTP(pid, appID), cateID, page, recod)
                    sbj = New NewsInfo
                    sbj.newsID = Cr.NewsID
                    sbj.summary = flReg.RemoveScript(Cr.Summary, False)
                    sbj.publishedDate = flReg.ReadDate(Cr.PublishedDate)
                    sbj.imagePath = ""
                    If cateID = 2 And Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&h=300"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                    ElseIf Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&w=150"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 60)
                    Else
                        sbj.imagePath = "NULL"
                        sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    End If
                    sbj.isView = Cr.IsView
                    sbj.isLike = Cr.IsLike
                    sbj.toUrl = Cr.ToUrl
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_newsList_" & cateID & "_" & page & "_" & recod, arr, SecondCache.M10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_newsList_" & cateID & "_" & page & "_" & recod), ArrayList)
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
    Public Sub newsRelate(token As String, appID As String, newsID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_newsRelate_" & newsID)) Then
                Dim sbj As New NewsInfo
                For Each Cr As CMS_NewsInfo In objController.CMS_News_List_Relate(pid, newsID)
                    sbj = New NewsInfo
                    sbj.newsID = Cr.NewsID
                    sbj.publishedDate = flReg.ReadDate(Cr.PublishedDate)
                    If Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&w=150"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 70)
                    Else
                        sbj.imagePath = "NULL"
                        sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    End If
                    sbj.isView = Cr.IsView
                    sbj.isLike = Cr.IsLike
                    sbj.toUrl = Cr.ToUrl
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_newsRelate_" & newsID, arr, SecondCache.M10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_newsRelate_" & newsID), ArrayList)
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
    Public Sub newsRelateUID(token As String, uID As String, appID As String, newsID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_newsRelateUID_" & newsID & "_" & uID)) Then
                Dim sbj As New NewsInfo
                For Each Cr As CMS_NewsInfo In objController.CMS_News_List_Relate_UID(pid, newsID, uID)
                    sbj = New NewsInfo
                    sbj.newsID = Cr.NewsID
                    sbj.publishedDate = flReg.ReadDate(Cr.PublishedDate)
                    If Cr.ImagePath <> "" Then
                        sbj.imagePath = "http://app.keng.com.vn" & Cr.ImagePath & "?dpi=150&quality=100&w=150"
                        sbj.titles = flReg.Trimstr(flReg.RemoveScript(Cr.Titles, False), 70)
                    Else
                        sbj.imagePath = "NULL"
                        sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    End If
                    sbj.isView = Cr.IsView
                    sbj.isLike = Cr.IsLike
                    sbj.toUrl = Cr.ToUrl
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_newsRelate_" & newsID & "_" & uID, arr, SecondCache.M10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_newsRelate_" & newsID & "_" & uID), ArrayList)
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
    Public Sub advertiseClick(advertiseID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objController.CMS_Advertise_Update_Click(pid, advertiseID)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub newsGet(newsID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New News1Info
            objController.CMS_News_Update_View(pid, newsID)
            If IsNothing(flCache.GetCache("app_newsGet_" & newsID)) Then
                Dim obj As CMS_NewsInfo = objController.CMS_News_Get(pid, newsID)
                sbj.newsID = obj.NewsID
                sbj.introduction = obj.Introduction
                sbj.titles = obj.Titles
                sbj.toUrl = obj.ToUrl
                sbj.imagePath = "http://app.keng.com.vn" & obj.ImagePath & "?dpi=150&quality=100&w=300"
                sbj.summary = obj.Summary
                sbj.contents = HtmlDecode(obj.Contents)
                sbj.links = obj.Links
                sbj.tags = obj.Tags
                sbj.isLike = obj.IsLike
                sbj.isView = obj.IsView
                sbj.publishedDate = flReg.ReadDate(obj.PublishedDate)
                sbj.writerName = obj.WriterName
                flCache.SetCache("app_newsGet_" & newsID, sbj, SecondCache.M10)
            Else
                sbj = CType(flCache.GetCache("app_newsGet_" & newsID), News1Info)
            End If

            data.data = sbj
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub newsLike(newsID As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objController.CMS_News_Update_Like(pid, newsID)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub notiRead(notiId As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objController.CMS_NotiSend_Update_TinhTrang(pid, notiId, appNotiSend.Read)

            data.data = appNotiSend.Read
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub notiReadAll(appID As String, appType As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objController.CMS_NotiSend_Update_TinhTrang_Read(pid, appType, appID, appNotiSend.Read)

            data.data = appNotiSend.Read
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub jobUserGet(token As String, appID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim sbj As New JobUserInfo
            If IsNothing(flCache.GetCache("app_jobUserGet_" & appID)) Then
                Dim obj As CMS_JobUserInfo = objController.CMS_JobUser_Get_ByUserAdmin(pid, appID)
                If IsNothing(obj) = False Then
                    sbj = New JobUserInfo
                    sbj.jobUser_ID = obj.JobUser_ID

                    If obj.Logo <> "" Then
                        sbj.logo = flReg.UrlAlias & obj.Logo.ToLower() & "?dpi=150&quality=100&w=120"
                    Else
                        sbj.logo = "/assets/images/noimage.png"
                    End If

                    sbj.title = flReg.RemoveScript(obj.Title, False)
                    sbj.career_ID = obj.Career_ID
                    sbj.currentLevel = obj.CurrentLevel
                    sbj.levelDesired = obj.LevelDesired
                    sbj.tinhTP = obj.TinhTP
                    sbj.quanHuyen = obj.QuanHuyen
                    sbj.experience_ID = obj.Experience_ID
                    sbj.level_ID = obj.Level_ID
                    sbj.salary_ID = obj.Salary_ID
                    sbj.needs_ID = obj.Needs_ID
                    sbj.education = obj.Education
                    sbj.careerGoals = obj.CareerGoals
                    sbj.workExperience = obj.WorkExperience
                    sbj.skillsForte = obj.SkillsForte
                    sbj.isApproval = obj.IsApproval
                    sbj.isView = obj.IsView
                    flCache.SetCache("app_jobUserGet_" & appID, sbj, SecondCache.M10)
                    objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
                Else
                    sbj = New JobUserInfo
                    sbj.jobUser_ID = flReg.GenKey()
                    sbj.logo = "/assets/images/noimage.png"
                    sbj.isView = -1

                    Dim uInfo As CMS_UserProfileInfo = objController.CMS_UserProfile_Get_By_UserName(pid, appID)
                    If IsNothing(uInfo) = False Then
                        If uInfo.LogoAvatar <> "" Then
                            sbj.logo = flReg.UrlAlias & uInfo.LogoAvatar.ToLower() & "?dpi=150&quality=100&w=120"
                        End If
                        sbj.salary_ID = uInfo.Salary_ID
                        sbj.levelDesired = uInfo.LevelDesired_ID
                        sbj.level_ID = uInfo.Level_ID
                        sbj.experience_ID = uInfo.Experience_ID
                        sbj.needs_ID = uInfo.Needs_ID
                        sbj.career_ID = uInfo.Career_ID
                        sbj.tinhTP = uInfo.W_TinhTP
                        sbj.quanHuyen = uInfo.W_QuanHuyen
                        sbj.isView = 0
                    End If
                End If
            Else
                sbj = CType(flCache.GetCache("app_jobUserGet_" & appID), JobUserInfo)
            End If
            data.data = sbj
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub recruitmentAdd(appID As String, workID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As CMS_JobUserInfo = objController.CMS_JobUser_Get_ByUserAdmin(pid, appID)
            If IsNothing(obj) = False Then
                If obj.IsApproval = True Then
                    Dim sbj As New CMS_RecruitmentInfo
                    sbj.Recruitment_ID = flReg.GenKey()
                    sbj.JobUser_ID = obj.JobUser_ID
                    sbj.Work_ID = workID
                    sbj.IsView = 0
                    sbj.IsContact = 0
                    sbj.IsCancel = 0
                    sbj.IsElect = 0
                    sbj.IsInterview = 0
                    sbj.IsTest = 0
                    sbj.CreateDate = Now
                    sbj.UserName = appID
                    sbj.UpdatedUser = appID
                    sbj.UpdatedDate = flReg.DateNull
                    objController.CMS_Recruitment_Add(pid, sbj)

                    flCache.RemoveCache("CMS_Recruitment_List_UserName_" & workID & "_" & appID)

                    data.data = sbj.Recruitment_ID
                    data.status = ServiceStatus.SUCCESS
                    data.message = "Success"
                Else
                    data.message = "NoActive"
                    data.status = ServiceStatus.EXCEPTION
                End If
            Else
                data.message = "NoData"
                data.status = ServiceStatus.NODATA
            End If
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub jobUserAdd(appID As String, jobUser_ID As String, title As String, career_ID As String, currentLevel As String, levelDesired As String, tinhTP As String, quanHuyen As String, experience_ID As String, level_ID As String, salary_ID As String, needs_ID As String, education As String, careerGoals As String, workExperience As String, skillsForte As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New CMS_JobUserInfo
            obj.JobUser_ID = jobUser_ID
            obj.Title = flReg.RemoveScript(getNull(title.Trim()))
            obj.Career_ID = getNull(career_ID.Trim())
            obj.CurrentLevel = getNull(currentLevel.Trim())
            obj.LevelDesired = getNull(levelDesired.Trim())
            obj.TinhTP = getNull(tinhTP.Trim())
            obj.QuanHuyen = getNull(quanHuyen.Trim())
            obj.Experience_ID = getNull(experience_ID.Trim())
            obj.Level_ID = getNull(level_ID.Trim())
            obj.Salary_ID = getNull(salary_ID.Trim())
            obj.Needs_ID = getNull(needs_ID.Trim())
            obj.Education = Server.HtmlDecode(getNull(education))
            obj.CareerGoals = Server.HtmlDecode(getNull(careerGoals))
            obj.WorkExperience = Server.HtmlDecode(getNull(workExperience))
            obj.SkillsForte = Server.HtmlDecode(getNull(skillsForte))
            obj.UserAdmin = appID
            obj.StartDate = Now
            obj.EndDate = Now.AddMonths(3)
            obj.IsApproval = False
            obj.ApprovalUser = ""
            obj.ApprovalDate = flReg.DateNull()
            obj.CreatedDate = Now
            obj.CreatedUser = appID
            obj.UpdatedDate = Now
            obj.UpdatedUser = appID
            obj.PortalID = flReg.WebConfig("PortalApp")
            obj.IsTemp = 0
            objController.CMS_JobUser_Add_App(pid, obj)

            flCache.RemoveCache("app_jobUserGet_" & appID)

            data.status = ServiceStatus.SUCCESS
            data.data = jobUser_ID
            data.message = "Success"
        Catch ex As Exception
            data.data = ex.Message
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub notiList(token As String, appID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_notiList_" & appID & "_" & page & "_" & recod)) Then
                Dim sbj As New NotiSendInfo
                For Each Cr As CMS_NotiSendInfo In objController.CMS_NotiSend_List_By_AppID(pid, appID, -1, "", page, recod, "Keng")
                    sbj = New NotiSendInfo
                    sbj.notiSend_ID = Cr.NotiSend_ID
                    sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    sbj.contents = flReg.RemoveScript(Cr.Contents, False)
                    sbj.fullContents = flReg.RemoveScript(Cr.Contents, False)
                    sbj.xemThem = IIf(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)).Length > 60, True, False)
                    sbj.fcmContent = flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False))
                    sbj.sendDate = flReg.ReadDate(Cr.SendDate)
                    sbj.readDate = flReg.ReadDate(Cr.ReadDate)
                    sbj.idKey = Cr.IdKey
                    sbj.hoVaTen = Cr.HoVaTen
                    sbj.flags = Cr.Flags
                    sbj.tinhTrang = Cr.TinhTrang
                    If flReg.WriteNumber(Cr.Logo) > 0 Or Cr.Logo = "0" Then
                        sbj.logo = "http://app.keng.com.vn" & "/image/tbao" & flReg.WriteNumber(Cr.Logo) + 1 & ".png?dpi=150&quality=100&w=48"
                    Else
                        sbj.logo = "http://app.keng.com.vn" & "/image/" & Cr.Logo & "?dpi=150&quality=100&w=48"
                    End If
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_notiList_" & appID & "_" & page & "_" & recod, arr, SecondCache.S3)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_notiList_" & appID & "_" & page & "_" & recod), ArrayList)
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
    Public Sub notiListNew(token As String, appType As String, appID As String, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_notiListNew_" & appID & "_" & page & "_" & recod)) Then
                Dim sbj As New NotiSendInfo
                For Each Cr As CMS_NotiSendInfo In objController.CMS_NotiSend_List_By_AppID(pid, appID, -1, "", page, recod, appType)
                    sbj = New NotiSendInfo
                    sbj.notiSend_ID = Cr.NotiSend_ID
                    sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    sbj.xemThem = IIf(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)).Length > 60, True, False)
                    sbj.contents = flReg.Trimstr(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)), 60)
                    sbj.fullContents = flReg.RemoveScript(Cr.Contents, False)
                    sbj.fcmContent = flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False))
                    sbj.idKey = Cr.IdKey
                    sbj.hoVaTen = Cr.HoVaTen
                    sbj.sendDate = flReg.ReadDate(Cr.SendDate)
                    sbj.readDate = flReg.ReadDate(Cr.ReadDate)
                    sbj.tinhTrang = Cr.TinhTrang
                    sbj.flags = Cr.Flags
                    If flReg.WriteNumber(Cr.Logo) > 0 Or Cr.Logo = "0" Then
                        sbj.logo = "http://app.keng.com.vn" & "/image/tbao" & flReg.WriteNumber(Cr.Logo) + 1 & ".png?dpi=150&quality=100&w=48"
                    Else
                        sbj.logo = "http://app.keng.com.vn" & "/image/" & Cr.Logo & "?dpi=150&quality=100&w=48"
                    End If
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_notiListNew_" & appID & "_" & page & "_" & recod, arr, SecondCache.S2)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_notiListNew_" & appID & "_" & page & "_" & recod), ArrayList)
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
    Public Sub notiNew(appID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_notiNew_" & appID)) Then
                Dim sbj As New NotiSendInfo
                For Each Cr As CMS_NotiSendInfo In objController.CMS_NotiSend_List_By_AppID_News(pid, appID, "Keng")
                    sbj = New NotiSendInfo
                    sbj.notiSend_ID = Cr.NotiSend_ID
                    sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    sbj.contents = flReg.Trimstr(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)), 60)
                    sbj.fullContents = flReg.RemoveScript(Cr.Contents, False)
                    sbj.fcmContent = flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False))
                    sbj.xemThem = IIf(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)).Length > 60, True, False)
                    sbj.sendDate = flReg.ReadDate(Cr.SendDate)
                    sbj.readDate = flReg.ReadDate(Cr.ReadDate)
                    sbj.idKey = Cr.IdKey
                    sbj.hoVaTen = Cr.HoVaTen
                    sbj.flags = Cr.Flags
                    sbj.tinhTrang = Cr.TinhTrang
                    If flReg.WriteNumber(Cr.Logo) > 0 Or Cr.Logo = "0" Then
                        sbj.logo = "http://app.keng.com.vn" & "/image/tbao" & flReg.WriteNumber(Cr.Logo) + 1 & ".png?dpi=150&quality=100&w=48"
                    Else
                        sbj.logo = "http://app.keng.com.vn" & "/image/" & Cr.Logo & "?dpi=150&quality=100&w=48"
                    End If
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_notiNew_" & appID, arr, SecondCache.S2)
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
    Public Sub notifyNew(appID As String, appType As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_notifyNew_" & appID & "_" & appType)) Then
                Dim sbj As New NotiSendInfo
                For Each Cr As CMS_NotiSendInfo In objController.CMS_NotiSend_List_By_AppID_News(pid, appID, appType)
                    sbj = New NotiSendInfo
                    sbj.notiSend_ID = Cr.NotiSend_ID
                    sbj.titles = flReg.RemoveScript(Cr.Titles, False)
                    sbj.contents = flReg.Trimstr(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)), 60)
                    sbj.xemThem = IIf(flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False)).Length > 60, True, False)
                    sbj.fcmContent = flReg.RemoveHTML(flReg.RemoveScript(Cr.Contents, False))
                    sbj.fullContents = flReg.RemoveScript(Cr.Contents, False)
                    sbj.sendDate = flReg.ReadDate(Cr.SendDate)
                    sbj.readDate = flReg.ReadDate(Cr.ReadDate)
                    sbj.idKey = Cr.IdKey
                    sbj.hoVaTen = Cr.HoVaTen
                    sbj.tinhTrang = Cr.TinhTrang
                    sbj.flags = Cr.Flags
                    If flReg.WriteNumber(Cr.Logo) > 0 Or Cr.Logo = "0" Then
                        sbj.logo = "http://app.keng.com.vn" & "/image/tbao" & flReg.WriteNumber(Cr.Logo) + 1 & ".png?dpi=150&quality=100&w=48"
                    Else
                        sbj.logo = "http://app.keng.com.vn" & "/image/" & Cr.Logo & "?dpi=150&quality=100&w=48"
                    End If
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_notifyNew_" & appID & "_" & appType, arr, SecondCache.S2)
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
    Public Sub notiUnRead(appID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            data.data = objController.CMS_NotiSend_UnRead_AppID(pid, appID, "Keng")
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub notiUnReadNew(appID As String, appType As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If IsNothing(flCache.GetCache("app_notiUnReadNew_" & appID & "_" & appType)) Then
                data.data = objController.CMS_NotiSend_UnRead_AppID(pid, appID, appType)
                flCache.SetCache("app_notiUnReadNew_" & appID & "_" & appType, data.data, SecondCache.S2)
            Else
                data.data = 0
            End If
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub questionList(token As String, appID As String, search As String, type As Integer, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_questionList_" & appID & "_" & type & "_" & page & "_" & recod)) Then
                Dim sbj As New QuestionInfo
                For Each Cr As CMS_QuestionInfo In objController.CMS_Question_List_Home(pid, search, appID, flCheck.getTinhTP(pid, appID), type, page, recod)
                    sbj = New QuestionInfo
                    sbj.question_ID = Cr.Question_ID
                    sbj.contents = Cr.Contents
                    sbj.createdDate = flReg.ReadDate(Cr.CreatedDate)
                    sbj.total = Cr.Total
                    sbj.open = 0
                    sbj.an_Contents = Cr.An_Contents
                    sbj.an_HoVaTen = Cr.An_HoVaTen
                    sbj.an_CreatedDate = flReg.ReadDate(Cr.An_CreatedDate)
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_questionList_" & appID & "_" & type & "_" & page & "_" & recod, arr, SecondCache.S10)
                objController.CMS_AppLog_Update_LogEnd(pid, token, appID, Now)
            Else
                arr = CType(flCache.GetCache("app_questionList_" & appID & "_" & type & "_" & page & "_" & recod), ArrayList)
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
    Public Sub questionAdd(appID As String, contents As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New CMS_QuestionInfo
            obj.AppID = appID
            obj.Contents = contents
            obj.Frequent = False
            obj.Status = appQuestionStatus.DangSoan
            obj.TinhTP = flCheck.getTinhTP(pid, appID)
            obj.HoVaTen = flCheck.getHoVaTen(pid, appID)
            obj.CreatedDate = Now
            obj.CreatedUser = appID
            obj.Question_ID = flReg.GenKey()
            obj.UpdatedDate = flReg.DateNull()
            obj.UpdatedUser = ""
            If obj.HoVaTen <> "" Then obj.CreatedUser = obj.HoVaTen

            objController.CMS_Question_Add(pid, obj)

            data.status = ServiceStatus.SUCCESS
            data.data = obj.Question_ID
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub newsFBAdd(appID As String, idKey As String, contents As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New CMS_NewsFBInfo
            obj.NewsFB_ID = flReg.GenKey()
            obj.IdKey = idKey
            obj.AppID = appID
            obj.Contents = contents
            obj.Status = appQuestionStatus.DangSoan
            obj.IsFlag = appQuestion.MoiGui
            obj.CreatedDate = Now
            obj.CreatedUser = appID
            obj.UpdatedDate = flReg.DateNull()
            obj.UpdatedUser = ""
            obj.TinhTP = flCheck.getTinhTP(pid, appID)
            objController.CMS_NewsFB_Add(pid, obj)

            data.status = ServiceStatus.SUCCESS
            data.data = obj.NewsFB_ID
            data.message = "Success"
        Catch ex As Exception

            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub newsFBList(newsID As Integer, page As Integer, recod As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            If IsNothing(flCache.GetCache("app_newsFBList_" & newsID & "_" & page & "_" & recod)) Then
                Dim sbj As New NewsFBInfo
                For Each Cr As CMS_NewsFBInfo In objController.CMS_NewsFB_List_Home(pid, newsID, page, recod)
                    sbj = New NewsFBInfo
                    sbj.newsFB_ID = Cr.NewsFB_ID
                    sbj.idKey = Cr.IdKey
                    sbj.appID = Cr.AppID
                    sbj.contents = Cr.Contents
                    sbj.createdDate = flReg.ReadDate(Cr.CreatedDate, True)
                    sbj.re_Contents = Cr.Re_Contents
                    sbj.re_CreatedDate = flReg.ReadDate(Cr.Re_CreatedDate, True)
                    sbj.tinhTP = flDic.Regional_Name(pid, Cr.TinhTP, "", True)
                    arr.Add(sbj)
                Next
                flCache.SetCache("app_newsFBList_" & newsID & "_" & page & "_" & recod, arr, SecondCache.M1)
            Else
                arr = CType(flCache.GetCache("app_newsFBList_" & newsID & "_" & page & "_" & recod), ArrayList)
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
    Public Sub upProfile(appID As String, avatar As String, typeFile As String, tinhTP As String, hoVaTen As String, gTinh As String,
                    ngaySinh As String, thangSinh As String, namSinh As String, soCMND As String, dienThoai As String, soBHXH As String, salary_ID As String,
                    levelDesired_ID As String, level_ID As String, experience_ID As String, needs_ID As String, career_ID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try

            Dim strPath As String = saveFiles(avatar, "AVATAR", flReg.GetFileType(typeFile, "."))

            dienThoai = getNull(dienThoai)
            If dienThoai = "" Then dienThoai = appID

            ngaySinh = getNull(ngaySinh) & "/" & getNull(thangSinh) & "/" & getNull(namSinh)

            objController.CMS_App_Update_Profile(pid, appID, -1, strPath, hoVaTen.ToUpper(), flReg.WriteNumber(gTinh),
                                                ngaySinh, getNull(soCMND), getNull(soBHXH),
                                                dienThoai, flReg.WriteNumber(tinhTP))
            Dim pInfo As New CMS_UserProfileInfo
            pInfo.LogoAvatar = strPath
            pInfo.ID = flReg.GenKey()
            pInfo.UserName = appID
            pInfo.HoVaTen = hoVaTen.ToUpper()
            pInfo.GioiTinh = flReg.WriteNumber(gTinh)
            pInfo.NgaySinh = ngaySinh
            pInfo.Salary_ID = getNull(salary_ID)
            pInfo.LevelDesired_ID = getNull(levelDesired_ID)
            pInfo.Level_ID = getNull(level_ID)
            pInfo.Experience_ID = getNull(experience_ID)
            pInfo.Needs_ID = getNull(needs_ID)
            pInfo.Career_ID = getNull(career_ID)
            pInfo.W_TinhTP = getNull(tinhTP)
            pInfo.W_QuanHuyen = ""
            pInfo.IsSystem = sysReg.App

            objController.CMS_UserProfile_Add(pid, pInfo)


            flCache.RemoveCache("app_appGet_" & appID)
            flCache.RemoveCache("app_userGet_" & appID)
            flCache.RemoveCache("app_jobUserGet_" & appID)
            flCache.RemoveCache("getFcmToken_" & appID & "_Keng")
            flCache.RemoveCache("getFcmToken_" & appID & "_Keng_DN")

            flCache.RemoveCache("getAppAvatar_" & pid & "_" & appID)
            flCache.RemoveCache("CMS_App_Get_AppID_" & pid & "_" & appID)
            flCache.RemoveCache("getAppAvatarToEmp_" & pid & "_" & appID)

            flCache.RemoveCache("getAppFullName_" & pid & "_" & appID & "_True")
            flCache.RemoveCache("getAppFullName_" & pid & "_" & appID & "_False")

            data.data = pInfo.ID
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.data = ex.Message
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub searchAdv(tinhTP As String, careerID As String, find As String, isFlag As Integer)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr1 = New ArrayList
            If isFlag = 6 Then
                foD = Now.AddMonths(-1)
                foD = New Date(foD.Year, foD.Month, foD.Day, 0, 0, 0)
                toD = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
            Else
                foD = New Date(1945, 1, 1, 0, 0, 0)
                toD = New Date(1945, 1, 1, 0, 0, 0)
            End If
            tinhTP = flReg.WriteNumber(tinhTP)
            spage = "app_searchAdv_" & tinhTP & "_" & careerID & "_" & foD.ToString("dd_MM_yyyy") & "_" & toD.ToString("dd_MM_yyyy_HH_mm") & "_" & flReg.NameUrl(find) & "_" & isFlag
            If IsNothing(flCache.GetCache(spage)) Then
                If isFlag = 6 Then
                    arr2 = getFlag6()
                ElseIf isFlag = 5 Then
                    arr2 = getFlag5()
                ElseIf isFlag = 4 Then
                    arr2 = getFlag4()
                ElseIf isFlag = 3 Then
                    arr2 = getFlag3()
                ElseIf isFlag = 2 Then
                    arr2 = getFlag2()
                ElseIf isFlag = 1 Then
                    arr2 = getFlag1()
                End If
                arr = objController.CMS_Works_Count_ToApp(pid, tinhTP, careerID, foD, toD, find, flReg.RemoveScript(find), isFlag)
                For Each Cr As CountInfo In arr2
                    For Each Cj As CountInfo In arr
                        If Cr.id = Cj.id And Cj.total > 0 Then
                            Cr.total = Cj.total
                            arr1.Add(Cr)
                            Exit For
                        End If
                    Next
                Next
                flCache.SetCache(spage, arr1, SecondCache.M1)
            Else
                arr1 = CType(flCache.GetCache(spage), ArrayList)
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
    Private Function getFlag6() As ArrayList
        getFlag6 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag6_List_" & pid)) Then
            getFlag6 = New ArrayList
            sbj = New CountInfo
            sbj.id = "6"
            sbj.name = "30 ngày qua"
            getFlag6.Add(sbj)

            flCache.SetCache("App_getFlag6_List_" & pid, getFlag6)
        Else
            getFlag6 = CType(flCache.GetCache("App_getFlag6_List_" & pid), ArrayList)
        End If
    End Function
    Private Function getFlag5() As ArrayList
        getFlag5 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag5_List_" & pid)) Then
            For Each Ci As CMS_SalaryInfo In objController.CMS_Salary_List(pid)
                sbj = New CountInfo
                sbj.id = Ci.Salary_ID
                sbj.name = flReg.RemoveScript(Ci.Salary_Name, False)
                getFlag5.Add(sbj)
            Next
            flCache.SetCache("App_getFlag5_List_" & pid, getFlag5)
        Else
            getFlag5 = CType(flCache.GetCache("App_getFlag5_List_" & pid), ArrayList)
        End If
    End Function
    Private Function getFlag4() As ArrayList
        getFlag4 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag4_List_" & pid)) Then
            For Each Ci As CMS_ExperienceInfo In objController.CMS_Experience_List(pid)
                sbj = New CountInfo
                sbj.id = Ci.Experience_ID
                sbj.name = flReg.RemoveScript(Ci.Experience_Name, False)
                getFlag4.Add(sbj)
            Next
            flCache.SetCache("App_getFlag4_List_" & pid, getFlag4)
        Else
            getFlag4 = CType(flCache.GetCache("App_getFlag4_List_" & pid), ArrayList)
        End If
    End Function
    Private Function getFlag3() As ArrayList
        getFlag3 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag3_List_" & pid)) Then
            For Each Ci As CMS_JobPlaceInfo In objController.CMS_JobPlace_List(pid)
                sbj = New CountInfo
                sbj.id = Ci.JobPlace_ID
                sbj.name = flReg.RemoveScript(Ci.JobPlace_Name, False)
                getFlag3.Add(sbj)
            Next
            flCache.SetCache("App_getFlag3_List_" & pid, getFlag3)
        Else
            getFlag3 = CType(flCache.GetCache("App_getFlag3_List_" & pid), ArrayList)
        End If
    End Function
    Private Function getFlag2() As ArrayList
        getFlag2 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag2_List_" & pid)) Then
            For Each Ci As CMS_EducationInfo In flDnn.CMS_Education_List(pid)
                sbj = New CountInfo
                sbj.id = Ci.Education_ID
                sbj.name = flReg.RemoveScript(Ci.Education_Name, False)
                getFlag2.Add(sbj)
            Next
            flCache.SetCache("App_getFlag2_List_" & pid, getFlag2)
        Else
            getFlag2 = CType(flCache.GetCache("App_getFlag2_List_" & pid), ArrayList)
        End If
    End Function
    Private Function getFlag1() As ArrayList
        getFlag1 = New ArrayList
        If IsNothing(flCache.GetCache("App_getFlag1_List_" & pid)) Then
            sbj = New CountInfo
            sbj.id = "1"
            sbj.name = "Nam"
            getFlag1.Add(sbj)

            sbj = New CountInfo
            sbj.id = "0"
            sbj.name = "Nữ"
            getFlag1.Add(sbj)

            sbj = New CountInfo
            sbj.id = "2"
            sbj.name = "Không yêu cầu"
            getFlag1.Add(sbj)

            flCache.SetCache("App_getFlag1_List_" & pid, getFlag1)
        Else
            getFlag1 = CType(flCache.GetCache("App_getFlag1_List_" & pid), ArrayList)
        End If
    End Function
    <WebMethod()>
    Public Sub configList(uID As String, eID As String, dID As String)
        Call flReg.SetContentResponse()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = New ArrayList
            uID = flReg.WriteNumber(uID) : eID = getNull(eID) : dID = getNull(dID)
            If IsNothing(flCache.GetCache("app_configList_" & uID & "_" & eID & "_" & dID)) Then
                Dim permistion As Integer = New Keng.Kengcontroller().CMS_Employee_Permistion(pid, uID, eID, dID)
                For Each Cr As ConfigSystemInfo In objController.CMS_ConfigSystem_List_Permistion(pid, permistion, uID)
                    Cr.isLogo = flReg.UrlAlias & Cr.isLogo & "?dpi=150&quality=100&w=32"
                    arr.Add(Cr)
                Next
                Dim sbj As New ConfigSystemInfo
                sbj.cssClass = "clear"
                arr.Add(sbj)

                flCache.SetCache("app_configList_" & uID & "_" & eID & "_" & dID, arr)
            Else
                arr = CType(flCache.GetCache("app_configList_" & uID & "_" & eID & "_" & dID), ArrayList)
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

    <WebMethod>
    Public Sub businessGetByAppID(appID As String)
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Try
            Dim sbj As New BusinessInfo
            If IsNothing(flCache.GetCache("app_businessGetByAppID_" & appID)) Then
                Dim obj As CMS_BusinessInfo = objController.CMS_Business_Get_ByAppID(pid, appID)
                If IsNothing(obj) = False Then
                    sbj.business_ID = obj.Business_ID
                    sbj.business_Vn = obj.Business_Vn
                    sbj.logo = flReg.UrlAlias & obj.Logo & "?dpi=150&quality=100&w=120"
                    sbj.address = obj.Address
                    sbj.website = obj.Website

                    flCache.SetCache("app_businessGetByAppID_" & appID, sbj, SecondCache.M3)
                End If
            Else
                sbj = CType(flCache.GetCache("app_businessGetByAppID_" & appID), BusinessInfo)
            End If
            data.status = ServiceStatus.SUCCESS
            data.data = sbj
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))

    End Sub
End Class