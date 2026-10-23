<%@ WebService Language="VB" Class="fcm" %>
Imports System.Web.Services
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class fcm
    Inherits System.Web.Services.WebService
    Dim pid As Integer = 0
    Dim objController As New AppController
    Dim fbj As New CMS_FCMInfo

    Private Function getNull(val As String) As String
        If val = "null" Or val = "undefined" Then
            Return ""
        Else
            Return val.Trim()
        End If
    End Function
    <WebMethod()>
    Public Sub versionGet(appType As String, appSys As String)
        Call EPORTAL.flReg.SetContentResponse()
        Dim data = New EPORTAL.Response
        data.status = EPORTAL.ServiceStatus.NODATA
        data.message = "Error"

        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If appType = "Keng" Then
                data.message = "Success"
                If appSys = "0" Then 'Android
                    data.data = "2.1.3"
                Else 'IOS
                    data.data = "2.1.3"
                End If
            ElseIf appType = "Keng_DN" Then
                If appSys = "0" Then 'Android
                    data.data = "1.0.3"
                    'data.message = "OTP" 'Đăng ký xác thực OTP
                    data.message = "Success" 'Đăng ký không cần xác thực OTP
                Else 'IOS
                    data.data = "1.0.3"
                    'data.message = "OTP" 'Đăng ký xác thực OTP
                    data.message = "Success" 'Đăng ký không cần xác thực OTP
                End If
            ElseIf appType = "Keng_SK" Then
                data.message = "Success"
                If appSys = "0" Then 'Android
                    data.data = "1.0.0"
                Else 'IOS
                    data.data = "1.0.0"
                End If
            End If
            data.status = EPORTAL.ServiceStatus.SUCCESS
        Catch ex As Exception
            data.message = ex.Message
            data.status = EPORTAL.ServiceStatus.FAILED
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub fcmAdd(token As String, appID As String)
        Call EPORTAL.flReg.SetContentResponse()
        Dim data = New EPORTAL.Response
        data.Status = EPORTAL.ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            fbj = New CMS_FCMInfo
            fbj.Token = token
            fbj.AppID = appID
            fbj.AppType = "Keng"
            objController.CMS_FCM_Add(pid, fbj)
            EPORTAL.flCache.RemoveCache("getFcmToken_" & fbj.AppID & "_" & fbj.AppType)
            data.status = EPORTAL.ServiceStatus.NODATA
            data.message = "Success"
        Catch ex As Exception
            data.status = EPORTAL.ServiceStatus.FAILED
            data.message = ex.Message
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub fcmAdd1(token As String, appID As String)
        Call EPORTAL.flReg.SetContentResponse()
        Dim data = New EPORTAL.Response
        data.status = EPORTAL.ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            fbj = New CMS_FCMInfo
            fbj.Token = Server.HtmlDecode(token)
            fbj.AppID = appID
            fbj.AppType = "Keng"
            objController.CMS_FCM_Add(pid, fbj)
            EPORTAL.flCache.RemoveCache("getFcmToken_" & fbj.AppID & "_" & fbj.AppType)
            data.status = EPORTAL.ServiceStatus.NODATA
            data.message = "Success"
        Catch ex As Exception
            data.status = EPORTAL.ServiceStatus.FAILED
            data.message = ex.Message
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub fcmAddNew(token As String, appID As String, appType As String)
        Call EPORTAL.flReg.SetContentResponse()
        Dim data = New EPORTAL.Response
        data.status = EPORTAL.ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            fbj = New CMS_FCMInfo
            fbj.Token = Server.HtmlDecode(token)
            fbj.AppID = appID
            fbj.AppType = appType
            objController.CMS_FCM_Add(pid, fbj)
            EPORTAL.flCache.RemoveCache("getFcmToken_" & fbj.AppID & "_" & fbj.AppType)

            data.status = EPORTAL.ServiceStatus.NODATA
            data.message = "Success"
        Catch ex As Exception
            data.status = EPORTAL.ServiceStatus.FAILED
            data.message = ex.Message
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    Public Sub loginGet(appID As String, appSystem As Integer, location As String)
        Call EPORTAL.flReg.SetContentResponse()
        Dim data = New EPORTAL.Response
        data.status = EPORTAL.ServiceStatus.NODATA
        data.message = "Error"
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim obj As New CMS_TokenInfo
            If getNull(appID) <> "" Then
                If IsNothing(EPORTAL.flCache.GetCache("app_appID_" & appID & "_" & appSystem)) Then
                    obj = New CMS_TokenInfo
                    obj.token = EPORTAL.flReg.Token()
                    obj.appID = appID
                    obj.status = objController.CMS_AppLog_Get_Login(pid, appID, obj.token, appSystem, location)

                    EPORTAL.flCache.SetCache("app_appID_" & appID & "_" & appSystem, obj, EPORTAL.SecondCache.S2)
                Else
                    obj = CType(EPORTAL.flCache.GetCache("app_appID_" & appID & "_" & appSystem), CMS_TokenInfo)
                End If
                data.data = obj
                data.status = EPORTAL.ServiceStatus.SUCCESS
                data.message = "Success"
            Else
                obj = New CMS_TokenInfo
                obj.token = EPORTAL.flReg.Token()
                obj.appID = ""
                obj.status = 3
                data.data = obj
                data.status = EPORTAL.ServiceStatus.NODATA
            End If
        Catch ex As Exception
            data.status = EPORTAL.ServiceStatus.FAILED
            data.message = ex.Message
        End Try
        Context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub


End Class
