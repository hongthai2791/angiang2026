 <%@ WebService Language="VB" Class="common" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.MAP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

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
    Dim pid As Integer = 0
    Dim arr As New ArrayList
    Dim settings As New JsonSerializerSettings()
    Dim ObjController As New MapController

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Get_LopBanDoList_ById(idStr As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.getStringNullHtml(idStr) <> "" Then
                arr = ObjController.LopBanDo_List_ById(pid, idStr)
                If arr.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = arr
                Else
                    rs.status = ServiceStatus.NODATA
                End If
            Else
                rs.status = ServiceStatus.FAILED
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Get_LopBanDo_List_Search_By(targetGroup As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            'If MaTinh > 0 Then
            'arr = ObjController.LopBanDo_List_Search_By(pid, MaTinh, MaHuyen, MaXa)
            arr = ObjController.LopBanDo_List_Search_By(pid, flReg.WebConfig("TinhTP"), 0, 0, 0, targetGroup)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            'Else
            'rs.status = ServiceStatus.FAILED
            'End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Get_RegionalQHPX(MaHuyen As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If MaHuyen > 0 Then
                arr = flDnn.CMS_Regional_Get_By_CMS_Regional(pid, MaHuyen)
            Else
                arr = flDnn.CMS_Regional_Get_By_CMS_Regional(pid, flReg.WriteNumber(flReg.WebConfig("TinhTP")))
            End If
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub HOME_MAP_DATA_GetData_ForMap(tarCode As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            arr = ObjController.MAP_DATA_ListData_ForMap(pid, flReg.WebConfig("TinhTp"), 0, 0, 0, 0, tarCode, 1)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Map_List_Search_ByDoanhNghiep(targetGroup As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            'If MaTinh > 0 Then
            arr = ObjController.Map_List_Search_ByDoanhNghiep(pid, flReg.WebConfig("TinhTP"), 0, 0)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            'Else
            'rs.status = ServiceStatus.FAILED
            'End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Map_List_Search_ByTuyenDung(targetGroup As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            'If MaTinh > 0 Then
            arr = ObjController.Map_List_Search_ByTuyenDung(pid, flReg.WebConfig("TinhTP"), 0, 0)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            'Else
            'rs.status = ServiceStatus.FAILED
            'End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub MAP_DATA_WORK_List_Search(quanHuyen As String, searchKey As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            'arr = ObjController.MAP_DATA_WORK_List_Search(pid, flReg.DeCode64(searchKey), 1, 200, flReg.WebConfig("TinhTP"), quanHuyen, 0)
            arr = ObjController.MAP_DATA_WORK_List_Search(pid, flReg.DeCode64(searchKey), 1, 200, flReg.WebConfig("TinhTP"), 0, quanHuyen)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub
    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub MAP_DATA_BUSSINESS_List_Search(quanHuyen As String, searchKey As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            'arr = ObjController.MAP_DATA_BUSSINESS_List_Search(pid, flReg.DeCode64(searchKey), 1, 200, flReg.WebConfig("TinhTP"), quanHuyen, 0)
            arr = ObjController.MAP_DATA_BUSSINESS_List_Search(pid, flReg.DeCode64(searchKey), 1, 200, flReg.WebConfig("TinhTP"), 0, quanHuyen)
            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub HOME_MAP_DATA_ListData_By_List(maHuyen As String, maXa As String, maThon As String, tarCode As String, color As String, namBC As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            arr = ObjController.MAP_DATA_ListData_By_List(pid, flReg.WebConfig("TinhTp"), maHuyen, maXa, maThon, namBC, tarCode, color)

            If arr.Count() > 0 Then
                rs.status = ServiceStatus.SUCCESS
                rs.data = arr
            Else
                rs.status = ServiceStatus.NODATA
            End If
            rs.message = "Success"
        Catch ex As Exception
            LogException(ex)
            rs.message = ex.Message
            rs.status = ServiceStatus.FAILED
        End Try
        context.Response.Write(JsonConvert.SerializeObject(rs, settings))
    End Sub

    Private Function getNull(val As String) As String
        If val = "null" Or val = "undefined" Then
            Return ""
        Else
            Return val.Trim()
        End If
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