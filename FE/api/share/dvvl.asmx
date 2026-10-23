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

#Region "Doanh nghiệp"

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function DoanhNghiep_List(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, maTinh As Integer, maHuyen As Integer, maXa As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_Business_List_Active(pid, flReg.RemoveScript(tuKhoa), flReg.RemoveScript(tuKhoa), soTrangHienTai, soBanGhiTrenTrang,
                                 maTinh, maHuyen, maXa, True)
        End If
        Return JsonConvert.SerializeObject(ConvertListAPI(arr), SettingAPI())
    End Function
#End Region

#Region "Người lao động"
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function NguoiLD_List(tuKhoa As String, soTrangHienTai As Integer, soBanGhiTrenTrang As Integer, maTinh As Integer, maHuyen As Integer) As String
        HostUser()
        GetUser(Authentication.userId)
        If obj IsNot Nothing Then
            arr = workCtl.CMS_JobUser_List_Search(pid, flReg.RemoveScript(tuKhoa), 0, soTrangHienTai, soBanGhiTrenTrang, "true", "", "", "", maTinh, maHuyen)
        End If
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
#End Region
End Class