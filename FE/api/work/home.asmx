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
    Dim objControler As New WorkController
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()
    Dim strVal, str(), stravatar As String

    Private Function CareerMultiName(id As String) As String
        CareerMultiName = ""
        str = id.Split(",")
        For i = 0 To str.Count - 1
            If String.IsNullOrEmpty(str(i)) = False Then
                CareerMultiName += flCheck.Career_Name(0, str(i)) & IIf(i = str.Count - 1, "", ", ")
            End If
        Next
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function jobUser() As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Try
            strVal = "" ' flCache.GetCache("Home_JobUser_" & 0) & ""
            If strVal = "" Then
                strVal = "<div class=""col-md-12"">"
                Dim iCount = 0
                For Each Cr As CMS_JobUserInfo In New WorkController().CMS_JobUser_List_Home(0, "", 1, 15, "", "", "", "0")
                    strVal += "<div class=""col-md-4" & IIf(iCount Mod 4 = 0, " hotflag""", """") & ">"
                    strVal += "<div class=""box-jobus"">"

                    strVal += "<div class=""avatar-jobus"">"
                    strVal += "<img src=""" & flReg.UrlAlias & flReg.PhotoURLFile(Cr.UserAdmin, flReg.WebConfig("PortalWork")) & "?dpi=150&quality=100&w=65&h=65"" alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
                    strVal += "</div>"
                    strVal += "<div class=""des-jobus"">"
                    strVal += "<a class=""link-jobus"" href=""" & flCheck.GetHomeLinkJobUser(Cr.JobUser_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & Cr.Title & "</a>"
                    If Cr.Career_ID <> "" Then
                        strVal += "<p class=""name-jobus"">Ngành nghề: " & CareerMultiName(Cr.Career_ID) & "</p>"
                    Else
                        strVal += "<p class=""name-jobus"">Ngành nghề: Khác</p>"
                    End If

                    strVal += "<p class=""ex-jobus"">Ngày đăng: " & flReg.ReadDate(Cr.StartDate, False) & "</p>"
                    strVal += "</div>"
                    strVal += "</div>"
                    strVal += "</div>"
                    iCount += 1
                Next
                strVal += "</div>"
                flCache.SetCache("Home_JobUser_" & 0, strVal, SecondCache.S3)
            End If
            data.data = strVal
            data.status = ServiceStatus.SUCCESS
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function getavatar(id As String) As String
        Call flReg.SetContentResponse()
        Dim obj As New CMS_JobUserInfo
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Try
            stravatar = flCache.GetCache("CMS_JobUser_Get_ID_" & 0 & "_" & id) & ""
            If stravatar = "" Then
                obj = New WorkController().CMS_JobUser_Get_ID(0, id)
                If IsNothing(obj) = False Then
                    stravatar += "<div class=""txt-center"">"
                    stravatar += "<img src=""" & flReg.UrlAlias & flReg.PhotoURLFile(obj.UserAdmin, flReg.WebConfig("PortalWork")) & "?dpi=150&quality=100&w=100&h=100"" alt=""Logo"" />"
                    stravatar += "</div>"
                    flCache.SetCache("CMS_JobUser_Get_ID_" & 0 & "_" & id, stravatar, SecondCache.S3)
                End If
            End If
            data.data = stravatar
            data.status = ServiceStatus.SUCCESS
        Catch ex As Exception
            data.data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class

 