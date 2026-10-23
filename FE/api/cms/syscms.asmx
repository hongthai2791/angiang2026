<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Web.Services.Protocols

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class AuthHeader
    Inherits SoapHeader
    Public Username As String
    Public Password As String
End Class

Public Class WebService
    Inherits System.Web.Services.WebService

    Public Authentication As AuthHeader
    Dim ObjController As New CmsController
    Dim data As New Response, isTotal As Integer
    Dim settings As New JsonSerializerSettings()
    Dim objWF As New CMS_News_UserWFInfo
    Dim WF_FROM, WF_RETURN, WfID, STATUS As Integer
    Dim WF_STEP As Boolean, createUs As String

    <WebMethod(EnableSession:=True)>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function FileToken(IdKey As String) As String
        IdKey = flReg.DeCode64(IdKey)
        FileToken = Session(IdKey) & ""
        If FileToken = "" Then
            Dim obj As CMSCookieInfo = flDnn.CMSCookie_Get_Token(IdKey)
            If IsNothing(obj) = False Then
                If flReg.Security(flReg.DeCode64(obj.CrtVal)) = True Then
                    FileToken = obj.UserName
                    Session(IdKey) = FileToken
                Else
                    FileToken = ""
                End If
            End If
        End If
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    <SoapHeader("Authentication")>
    Public Function Update_View(PortalConnect As Integer, IdKey As String, NewsID As Integer) As Boolean
        Try
            If Authentication.Username <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then Return False
            ObjController.CMS_Update_View(PortalConnect, IdKey, NewsID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GetUserName(userName As String) As String
        Return flReg.GetUserName(userName)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    <SoapHeader("Authentication")>
    Public Function CMS_NewsFeedback_Add(PortalConnect As Integer, ItemId As Integer, Content As String, FullName As String, Status As Integer, IPTrack As String, Email As String) As Boolean
        If Authentication.Username <> flReg.WebConfig("SoapUser") Or Authentication.Password <> flReg.WebConfig("SoapPass") Then Return False
        Call SetContentResponse()
        data = New Response
        settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim info As New CMS_NewsFeedbackInfo
            With info
                .ItemId = ItemId
                .Content = flReg.DeCode64(Content)
                .FullName = flReg.DeCode64(FullName)
                .Status = CommentStatus.Created
                .CreateDate = Now
                .Type = 1
                .Avatar = "/images/noavatar.png"
                .IPTrack = flReg.DeCode64(IPTrack)
                .PortalId = PortalConnect
                .LanguageId = flConnect.IsLang
                .Email = flReg.DeCode64(Email)
            End With
            info.NewsFeedbackId = ObjController.CMS_NewsFeedback_Add(PortalConnect, info)

            Dim hisInfo As New CMS_NewsFeedBack_HistoryInfo
            hisInfo.NewFB_ID = info.NewsFeedbackId
            hisInfo.Contents = info.Content
            hisInfo.CreateDate = Now
            hisInfo.UserName = info.FullName
            ObjController.CMS_NewsFeedBack_History_Add(PortalConnect, hisInfo)

            data.Data = "True"
        Catch ex As Exception
            data.Data = "False"
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Class Response
    Public Property Data As Object
End Class
