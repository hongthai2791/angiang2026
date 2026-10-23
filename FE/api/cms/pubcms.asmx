<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim ObjController As New CmsController
    Dim data As New Response, isTotal As Integer
    Dim settings As New JsonSerializerSettings()
    Dim objWF As New CMS_News_UserWFInfo
    Dim WF_FROM, WF_RETURN, WfID, STATUS As Integer
    Dim WF_STEP As Boolean, createUs As String
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
    Private Sub GetStatus(pid As String, table As String, us As String)
        createUs = us
        Select Case table.Substring(0, table.LastIndexOf("-"))
            Case "news", "album"
                If table = "news-my" Or table = "album-my" Then
                    STATUS = NewsStatus.BiTraLai
                    WF_RETURN = 0
                    WfID = 0
                    WF_STEP = False
                Else
                    If us = "host" Then createUs = "admin"
                    WF_FROM = flReg.WriteNumber(flCache.GetCache("WF_FROM_" & pid & table))
                    If WF_FROM = 0 Then
                        WF_FROM = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, "cms", "WF_FROM", table))
                        flCache.SetCache("WF_FROM_" & pid & table, WF_FROM)
                    End If

                    WF_RETURN = flReg.WriteNumber(flCache.GetCache("WF_RETURN_" & pid & table))
                    If WF_RETURN = 0 Then
                        WF_RETURN = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, "cms", "WF_RETURN", table))
                        flCache.SetCache("WF_RETURN_" & pid & table, WF_RETURN)
                    End If

                    If IsNothing(flCache.GetCache("WF_STEP_" & pid & table)) = True Then
                        WF_STEP = flReg.ToBoolean(flReg.SettingValue(flConnect.DmConnect, "cms", "WF_STEP", table))
                        flCache.SetCache("WF_STEP_" & pid & table, WF_STEP)
                    Else
                        WF_STEP = flReg.ToBoolean(flCache.GetCache("WF_STEP_" & pid & table))
                    End If

                    STATUS = flReg.WriteNumber(flCache.GetCache("STATUS_" & pid & table))
                    WfID = flReg.WriteNumber(flCache.GetCache("WfID_" & pid & table))
                    If WfID = 0 Then
                        Dim objWF As CMS_News_UserWFInfo = ObjController.CMS_News_UserWF_Get(pid, WF_FROM)
                        If IsNothing(objWF) = False Then
                            WfID = objWF.ID
                            STATUS = objWF.TrangThaiDich
                        End If
                        flCache.SetCache("WfID_" & pid & table, WfID)
                        flCache.SetCache("STATUS_" & pid & table, STATUS)
                    End If
                End If
            Case "video", "audio"
                If table = "video-my" Or table = "audio-my" Then
                    STATUS = NewsStatus.BiTraLai
                    WF_RETURN = 0
                    WfID = 0
                    WF_STEP = False
                Else
                    STATUS = flReg.WriteNumber(flCache.GetCache("STATUS_" & pid & table))
                    If STATUS = 0 Then
                        table = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, "cms", "WF_FROM", table))
                        objWF = ObjController.CMS_News_UserWF_Get(pid, table)
                        If IsNothing(objWF) = False Then
                            STATUS = objWF.TrangThaiDich
                            flCache.SetCache("STATUS_" & pid & table, WF_FROM)
                        End If
                    End If
                    WF_RETURN = 0
                    WfID = 0
                    WF_STEP = False
                End If
        End Select
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Notification(id As String, pa As String, us As String, pid As String) As String
        Call SetContentResponse()
        data = New Response
        settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        Try
            Call GetStatus(pid, id, us)
            id = id.Substring(0, id.LastIndexOf("-"))
            If UserInfo.IsInRole("Xuat ban") = True Then
                isTotal = ObjController.CMS_Notification(pid, flConnect.IsLang, id, STATUS, WF_STEP, WfID, WF_RETURN, "admin", 0)
            Else
                isTotal = ObjController.CMS_Notification(pid, flConnect.IsLang, id, STATUS, WF_STEP, WfID, WF_RETURN, createUs, 0)
            End If
            If isTotal > 0 Then data.Data = "<span class=""noti-span"">" & isTotal & "</span>"
        Catch ex As Exception
            data.Data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Class Response
    Public Property Data As Object
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