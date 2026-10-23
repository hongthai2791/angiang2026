<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim ObjController As New CauController()
    Dim _tabName As String = "work"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function guiThongBao(id As String, d As Integer) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            If (d = 1) Then
                ObjController.BC_Business_Update_TbGui(0, id, True)
            Else
                ObjController.BC_Business_Update_TbGui(0, id, False)
            End If
            data.status = 1
        Catch ex As Exception
            data.status = 0
            data.data = flReg.BugLog(0, ex.Message, _tabName)
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function tonghop(pid As Integer, tp As String, id As String, year As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        year = flReg.WriteNumber(year)
        If year = 0 Then year = Now.Year
        Try
            If id = "0" Or id = "1" Then
                For Each Cr As BC_CauLDInfo In New CauController().BC_CauLD_List_By_Flag(pid, id)
                    ObjController.RPT_TongHop_SoLieu(flReg.WriteNumber(pid), tp, year, Cr.ID & "A")
                Next
            Else
                ObjController.RPT_TongHop_SoLieu(flReg.WriteNumber(pid), tp, year, id)
            End If
            data.data = "Đã tổng hợp số liệu thành công"
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, _tabName)
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