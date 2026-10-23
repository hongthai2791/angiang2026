<%@ WebHandler Language="VB" Class="idcookie" %>
Imports DotNetNuke.EPORTAL

Public Class idcookie : Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim obj As New CMSCookieInfo
        obj.IdKey = flReg.GenKey()
        obj.IdValue = ""
        If context.Request.Item("i") = "multinew" Then
            obj.UserName = flReg.EnCode64("Multimedia")
        Else
            obj.UserName = flReg.EnCode64(UserInfo.Username)
        End If
        obj.CrtVal = flReg.EnCode64(flReg.EncodeUserName(""))
        obj.CrtDate = Now.AddMinutes(5)

        flDnn.CMSCookie_Add(obj)
        context.Response.Write(flReg.EnCode64(obj.IdKey))
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
                If Not System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, System.Threading.Thread.CurrentPrincipal.Identity.Name)
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