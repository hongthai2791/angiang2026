<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim obj, cbj As New CMS_BusinessInfo
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()
    Dim objControler As New AppController()

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function delHelpInsu(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_HelpInsuD_Delete(pid, id)
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function delWprice(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_WPrice_Delete(pid, id)
            data.Data = "1"
        Catch ex As Exception
            data.Data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub taxcode(id As String, pid As String, code As String)
        Dim context As HttpContext = HttpContext.Current
        settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data = New Response
        Dim listReturn As New List(Of CMS_BusinessInfo)
        obj = objControler.CMS_Business_Check_TaxCode(pid, id, code)
        If IsNothing(obj) = False Then
            cbj = New CMS_BusinessInfo
            cbj.ID = obj.ID
            cbj.Business_ID = obj.Business_ID
            cbj.Business_Vn = flReg.RemoveScript(obj.Business_Vn, False)
            cbj.Business_En = flReg.RemoveScript(obj.Business_En, False)
            cbj.Business_Sort = flReg.RemoveScript(obj.Business_Sort, False)
            cbj.TinhTP = obj.TinhTP
            cbj.QuanHuyen = obj.QuanHuyen
            cbj.Logo = obj.Logo
            cbj.Description = flReg.RemoveScript(obj.Description, False)
            cbj.TaxCode = obj.TaxCode
            cbj.Mobile = flReg.RemoveScript(obj.Mobile, False)
            cbj.Fax = flReg.RemoveScript(obj.Fax, False)
            cbj.Website = flReg.RemoveScript(obj.Website, False)
            cbj.Email = flReg.RemoveScript(obj.Email, False)
            cbj.Address = flReg.RemoveScript(obj.Address, False)
            cbj.ContactUser = flReg.RemoveScript(obj.ContactUser, False)
            cbj.ContactMobile = flReg.RemoveScript(obj.ContactMobile, False)
            cbj.ContactEmail = flReg.RemoveScript(obj.ContactEmail, False)
            cbj.CreatedDate = obj.CreatedDate
            cbj.CreatedUser = obj.CreatedUser
            cbj.UpdatedDate = obj.UpdatedDate
            cbj.UpdatedUser = obj.UpdatedUser
            cbj.IsApproval = obj.IsApproval
            listReturn.Add(cbj)
            data.Data = listReturn
        Else
            data.Data = "error"
        End If
        context.Response.Write(JsonConvert.SerializeObject(data, settings))
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function checkcode(id As String, pid As String, code As String) As String
        Call flReg.SetContentResponse()
        data = New Response
        settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = "DONE"
        obj = objControler.CMS_Business_Check_TaxCode(pid, id, code)
        If IsNothing(obj) = False Then
            data.Data = "<div class='bug-val'>Mã <b style='color:yellow'>" & code & "</b> đã được sử dụng trên hệ thống, vui lòng kiểm tra lại.</div>"

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
 