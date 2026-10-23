 <%@ WebService Language="VB" Class="common" %>
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CHATBOT
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication
Imports DotNetNuke.Security.Roles
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

    <WebMethod()>
    <SoapHeader("Authentication")>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub kichban_updateorderby(idStr As String, idStr2 As String, idNhomKichBan As Integer, idNhomKichBan2 As Integer)
        'Return JsonConvert.SerializeObject(ConvertObjectAPI(iCount, False), SettingAPI())
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If idNhomKichBan > 0 And idNhomKichBan2 > 0 Then
                Dim iCount = flReg.WriteNumber(flChatBot.KichBan_Update_OrderBy(pid, getNull(idStr), getNull(idStr2), idNhomKichBan, idNhomKichBan2, UserInfo.Username))
                If iCount > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                Else
                    rs.status = ServiceStatus.FAILED
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
    Public Sub tinnhansub_updateorderby(idStr As String)
        'Return JsonConvert.SerializeObject(ConvertObjectAPI(iCount, False), SettingAPI())
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If getNull(idStr) <> "" Then
                Dim iCount = flReg.WriteNumber(flChatBot.TinNhanSub_Update_OrderBy(pid, getNull(idStr), UserInfo.Username))
                If iCount > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                Else
                    rs.status = ServiceStatus.FAILED
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
    Public Sub tinnhan_searchkeyword(idBot As Integer, keyWord As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.getStringNullHtml(keyWord) <> "" Then
                Dim lstTinNhan = flChatBot.TinNhan_By_KeyWord(pid, idBot, flConnect.fileDomain, flReg.getStringNullHtml(keyWord), UserInfo.Username)
                If lstTinNhan.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstTinNhan
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
    Public Sub tinnhan_bykichban(idBot As Integer, idKichBan As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.WriteNumber(idKichBan) > 0 Then
                Dim lstTinNhan = flChatBot.TinNhan_By_KichBanId(pid, idBot, flConnect.fileDomain, idKichBan)
                If lstTinNhan.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstTinNhan
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
    Public Sub tinnhan_bynhomkichban(idBot As Integer, idKichBan As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.WriteNumber(idKichBan) > 0 Then
                Dim lstTinNhan = flChatBot.TinNhan_By_NhomKichBanId(pid, idBot, flConnect.fileDomain, idKichBan)
                If lstTinNhan.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstTinNhan
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
    Public Sub bien_by_bobienid(idBoBien As Integer)
        'Return JsonConvert.SerializeObject(ConvertObjectAPI(iCount, False), SettingAPI())
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.WriteNumber(idBoBien) > 0 Then
                Dim lstBien = flChatBot.Bien_List_By_IdBoBien(pid, idBoBien)
                If lstBien.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstBien
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
    Public Sub tinhoithoai_add(noiDungHtml As String, noiDungText As String, idHoiTHoai As Integer, type As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If idHoiTHoai > 0 Then
                Dim item As New TinHoiThoaiInfo
                item.IdHoiThoai = idHoiTHoai
                item.NoiDungHTML = noiDungHtml.Trim()
                item.NoiDungText = noiDungText.Trim()
                item.Type = type
                item.CreatedDate = Now
                item.CreatedUser = UserInfo.Username
                item.UpdatedUser = UserInfo.Username
                item.UpdatedDate = Now
                item.DeletedDate = Now
                item.IsActive = True
                Dim iCount = flReg.WriteNumber(flChatBot.TinHoiThoai_Add(pid, item))
                If iCount > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                Else
                    rs.status = ServiceStatus.FAILED
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
    Public Sub tinhoithoai_list(idHoiTHoai As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If idHoiTHoai > 0 Then
                Dim lstBien = flChatBot.TinHoiThoai_List(pid, idHoiTHoai)
                If lstBien.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstBien
                Else
                    rs.status = ServiceStatus.FAILED
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
    Public Sub tukhoa_list(idBot As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If idBot > 0 Then
                Dim lstBien = flChatBot.TuKhoa_List(pid, idBot)
                If lstBien.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstBien
                Else
                    rs.status = ServiceStatus.FAILED
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
    Public Sub tinnhan_bynhomtukhoa(idBot As Integer, idNhomTuKhoa As Integer)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If flReg.WriteNumber(idNhomTuKhoa) > 0 Then
                Dim lstTinNhan = flChatBot.TinNhan_By_NhomTuKhoaId(pid, idBot, flConnect.fileDomain, idNhomTuKhoa)
                If lstTinNhan.Count() > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                    rs.data = lstTinNhan
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
    Public Sub tinnhan_updateorderby(idStr As String, idKichBan As Integer)
        'Return JsonConvert.SerializeObject(ConvertObjectAPI(iCount, False), SettingAPI())
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim rs = New Response
        Try
            If idKichBan > 0 Then
                Dim iCount = flReg.WriteNumber(flChatBot.TinNhan_Update_OrderBy(pid, getNull(idStr), idKichBan, UserInfo.Username))
                If iCount > 0 Then
                    rs.status = ServiceStatus.SUCCESS
                Else
                    rs.status = ServiceStatus.FAILED
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