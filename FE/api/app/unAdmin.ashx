<%@ WebHandler Language="VB" Class="unAdmin" %>
Imports DotNetNuke.APP
Imports DotNetNuke.EPORTAL
Imports System.Threading

Public Class unAdmin : Implements IHttpHandler

    Dim usID, buID As String
    Dim pid As Integer
    Dim objController As New AppController

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        usID = context.Request.Item("uid")
        buID = context.Request.Item("buid")
        pid = flReg.WriteNumber(context.Request.Item("p"))
        Try
            objController.CMS_BusUser_Update_Admin(pid, usID, buID)
        Catch ex As Exception
        End Try
        context.Response.Write("")
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
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