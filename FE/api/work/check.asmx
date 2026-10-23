<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim obj As New CMS_BusinessInfo
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub taxcode(id As String, pid As String, code As String)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data = New Response
        Dim listReturn As New List(Of CMS_BusinessInfo)
        obj = New WorkController().CMS_Business_Check_TaxCode(pid, id, code)
        If IsNothing(obj) = False Then
            listReturn.Add(obj)
            data.Data = listReturn
        Else
            Dim bcInfo As CAU.BC_BusinessInfo = New CAU.CauController().BC_Business_Check_TaxCode(pid, id, code)
            If IsNothing(bcInfo) = False Then
                obj = New CMS_BusinessInfo
                obj.Business_ID = bcInfo.DoanhNghiep_ID
                obj.Business_Vn = bcInfo.TenDoanhNghiep
                obj.Address = bcInfo.SoNha
                obj.ContactUser = bcInfo.CreatedUser
                obj.ContactMobile = bcInfo.Mobile
                obj.ContactEmail = bcInfo.Email
                listReturn.Add(obj)
                data.Data = listReturn
            Else
                data.Data = "error"
            End If
        End If
        context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function checkcode(id As String, pid As String, code As String) As String
        Call flReg.SetContentResponse()
        data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.data = "DONE"

        obj = New WorkController().CMS_Business_Check_TaxCode(pid, id, code)
        If IsNothing(obj) = False Then
            data.data = "<div class='bug-val'>Mã số này đã được sử dụng trên hệ thống, vui lòng kiểm tra lại.</div>"
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As Response)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
    End Sub
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
 