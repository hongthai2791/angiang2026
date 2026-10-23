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
    Public Function UngTuyen(pid As Integer, phid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        arr = objControler.CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(pid, phid, id)
        Dim obj As CMS_UngVienInfo = objControler.CMS_UngVien_Get(pid, id)
        If IsNothing(obj) = False Then
            sVal = "<div class=""modal-header""><h4 class=""modal-title"">Kết quả ứng viên: " & obj.TenDayDu & "</h4></div>"
        End If
        sVal += "<div class=""modal-body"">"
        If arr.Count > 0 Then
            sVal += "<table class=""svl_table"" cellspacing=""0"" rules=""all"" border=""0"" style=""width: 100%; border-collapse: collapse;"">"
            sVal += "<tbody>"
            sVal += "<tr class=""svl_header"">"
            sVal += "<th style=""width: 5%;text-align:center"">STT</th>"
            sVal += "<th style=""width: 70%;"">Tên doanh nghiệp</th>"
            sVal += "<th style=""width: 25%;text-align:center"">Kết quả</th>"
            sVal += "</tr>"
            sCla = "svl_row" : iCount = 1
            For Each Cr As CMS_DoanhNghiep_UngVienInfo In arr
                sVal += "<tr class=""" & sCla & """>"
                sVal += "<td style=""text-align:center"">" & iCount & "</td>"
                sVal += "<td>" & Cr.Business_Vn & "<br/>"
                sVal += "<span style=""font-weight: bold; color: #900303"">Việc làm: " & Cr.TuyenDungName & "</span>"
                sVal += "</td>"
                sVal += "<td style=""text-align:center"">" & FormatKetQuaPhongVan(Cr.KetQuaPhongVan) & "</td>"
                sVal += "</tr>"
                If sCla = "svl_row" Then
                    sCla = "svl_altrow"
                Else
                    sCla = "svl_row"
                End If
                iCount += 1
            Next
            sVal += "</tbody>"
            sVal += "</table>"
        Else
            sVal += "<h2 class=""noti-none"">Hiện tại ứng viên chưa tham gia phỏng vấn!</h2>"
        End If
        sVal += "</div>"
        data.Data = sVal
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Function FormatKetQuaPhongVan(ByVal kq As Integer) As String
        If kq = 1 Then Return "Đạt"
        If kq = 2 Then Return "Không đạt"
        If kq = 3 Then Return "Hẹn phỏng vấn lại"
        If kq = 4 Then Return "Trúng sơ tuyển"
        Return "Chưa phỏng vấn"
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function values(pid As Integer, isflag As String, tinhTp As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            data.data = WorkHome(pid, isflag, flReg.WriteNumber(tinhTp))
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Private Function WorkHome(pid As Integer, isflag As Integer, tinhTp As String) As String
        sVal = "" : iCount = 0
        If isflag = 0 Then isflag = 1
        For Each Cr As CMS_WorkInfo In objControler.CMS_Work_List_Home(pid, isflag, 20, tinhTp)
            sVal += "<div class=""col-md-4 col-xs-12 " & IIf(iCount Mod 3 = 0, "hotflag""", """") & ">"
            sVal += "<div class=""box-ct-wh"">"
            sVal += "<div class=""col-sm-3 hidden-xs""><div class=""hm-work"">"
            sVal += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(pid, Cr.Business_ID), 105, 60, True) & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
            sVal += "</div></div>"
            sVal += "<div class=""col-sm-9 col-xs-12 range_mobile"">"
            sVal += "<div class=""row-w-work""><a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & Cr.Title & "</a></div>"
            sVal += "<div class=""row-w-bus""><a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID) & "</a></div>"
            sVal += "<div class=""row-w-add"">"
            sVal += "<div class=""col-sm-4 col-xs-4 pdr0""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>" & flReg.Trimstr((flDic.RegionalName(Cr.PortalID, Cr.TinhTP, Cr.QuanHuyen) & "").Replace("Thành phố", "TP."), 50) & "</div>"
            sVal += "<div class=""col-sm-4 col-xs-4 pdr0 "" title=""Hạn nộp hồ sơ"" style='font-weight:700;color:red !important'><i class=""fa fa-calendar"" aria-hidden=""true""></i>" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
            sVal += "<div class=""col-sm-4 col-xs-4 pdr0 w-bookmark "" title=""Kinh nghiệm"" style='font-weight:700;'><i class=""fa fa-bookmark"" aria-hidden=""true""></i>" & flCheck.Experience_Name(Cr.PortalID, Cr.Experience_ID) & "</div>"
            sVal += "</div>"
            sVal += "</div>"
            sVal += "<div class=""clear""></div>"
            sVal += "</div>"
            sVal += "</div>"
            iCount += 1
            If iCount Mod 3 = 0 And iCount > 0 Then sVal += "<div class=""clear""></div>"
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