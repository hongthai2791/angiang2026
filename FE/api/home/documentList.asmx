<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim arr As New ArrayList
    Dim litRow, litPage As String

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function docList(page As String, la As String, lv As String, cq As String, tx As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            page = flReg.WriteNumber(page)
            If tx <> "" Then tx = flReg.DeCode64(tx)
            cq = flCheck.DocUnit_Name(0, cq)
            arr = New CmsController().CMS_Document_List_Home(0, tx.Trim(), la, lv, cq, page, 20)
            lbTotal = 0 : litRow = ""
            For Each Cr As CMS_DocumentInfo In arr
                litRow += "<tr>"
                litRow += "<td style=""width: 15%; padding-left: 7px; vertical-align: middle"">" & Cr.NoCode & "</td>"
                litRow += "<td class=""hidden-xs"" style=""width: 15%; text-align: center; vertical-align: middle"">" & flReg.ReadDate(Cr.PromDate, False) & "</td>"
                litRow += "<td style=""width: 60%; padding-left: 3px; vertical-align: middle""><span>" & Cr.Document_Name & "</span></td>"
                litRow += "<td style=""width: 10%; text-align: center; vertical-align: middle"">"
                litRow += "<a onclick='updateDownload(""" & Cr.Document_ID & """,""0"");' title='" & Cr.FileName & "'>"
                litRow += "<i class=""fa fa-download"" aria-hidden=""true""></i></a></td>"
                litRow += "</tr>"
            Next
            For Each Cr As CMS_DocumentInfo In arr
                If Cr.Total > 20 Then
                    litPage = "<div class=""phan-trang"">"
                    litPage += flReg.NextPageJs(Cr.Total, 20, page, 5, "fnext(")
                    litPage += "</div>"
                End If
            Next

            data.data = litRow
            data.message = litPage
        Catch ex As Exception
            data.data = ex.Message
            data.message = 0
            data.value = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
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