<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading


<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.Status = ServiceStatus.NODATA, .Data = Nothing, .Message = String.Empty}
    Dim objControler As New WorkController
    Dim sVal, sCla As String, iCount As Integer
    Dim arr As New ArrayList
    Dim wCtl As New WORK.WorkController

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Regmail(pid As Integer, email As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim obj As New CMS_RegEmailInfo
            obj.RegEmail_ID = flReg.GenKey()
            obj.RegEmail = email
            wCtl.CMS_RegEmail_Add(0, flReg.GenKey(), email, Now)
            'Dim myCookie As HttpCookie = New HttpCookie("RegEmailSend")
            'myCookie.Values.Add("val", email.Trim())
            'myCookie.Expires = Now.AddDays(7)
            'Response.Cookies.Add(myCookie)
            data.status = ServiceStatus.SUCCESS
            data.message = "Success"
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "work")
            data.message = "Error"
            data.status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function values(pid As Integer, flag As String, veTinh As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New EXE_NumberAutoInfo
            obj = New EXE_NumberAutoInfo
            obj.NumberAuto_ID = flReg.GenKey()
            obj.NoCode = INSU.flCheck.NoCode(pid, ProType.DKXH)
            obj.HoTen = "KIOSK_" & Now.ToString("hhmmssddMMyy")
            obj.DienThoai = ""
            obj.NgayDangKy = Now
            obj.DichVu = flag
            obj.PortalID = pid
            obj.VeTinhID = veTinh
            obj.CreatedDate = Now
            obj.CreatedUser = "KIOSK"
            data.data = New InsuController().EXE_NumberAuto_Add_Lite(pid, obj)
        Catch ex As Exception
            data.data = 0
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FindNguoiTimViec(cccd As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As EPORTAL.CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_CCCD(0, cccd.Trim())
            Dim objEx As New CMSUserPortalJsonInfo
            If obj IsNot Nothing Then
                objEx.HoTen = obj.DisplayName
                objEx.NgaySinh = flReg.WriteDate(obj.DateOfBirth, False)
                objEx.GioiTinh = IIf(obj.Gender = 0, "Nam", "Nữ")
                objEx.DiaChi = obj.Address
            End If
            data.data = objEx
        Catch ex As Exception
            data.data = 0
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FindPhieuHen(qrcode As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As EXE_ProSubsiInfo = New InsuController().EXE_ProSubsi_Find(0, qrcode.Trim())
            Dim objEx As New EXE_ProSubsiExtraInfo
            If obj IsNot Nothing Then
                objEx.HoTen = obj.HoTen
                objEx.NgaySinh = flReg.WriteDate(obj.NgaySinh, False)
                objEx.MaPhieu = obj.NoCode
                objEx.NgayTiepNhan = flReg.WriteDate(obj.NgayTiepNhan, False)
                objEx.NgayHenTra = flReg.WriteDate(obj.NgayTraKetQua, False)
            End If
            data.data = objEx
        Catch ex As Exception
            data.data = 0
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Class CMSUserPortalJsonInfo
    Inherits EPORTAL.CMSUserPortalInfo
    Public Property HoTen() As String
    Public Property NgaySinh() As String
    Public Property GioiTinh() As String
    Public Property DiaChi() As String
End Class
Public Class EXE_ProSubsiExtraInfo
    Inherits INSU.EXE_ProSubsiInfo
    Public Property HoTen() As String
    Public Property NgaySinh() As String
    Public Property MaPhieu() As String
    Public Property NgayTiepNhan() As String
    Public Property NgayHenTra() As String
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