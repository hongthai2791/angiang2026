<%@ WebHandler Language="VB" Class="cache" %>

Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Public Class cache : Implements IHttpHandler
    Dim IdKey, IdValue, newid As String
    Dim PortalID As Integer, IsStop As Boolean
    Dim arrTemp As New ArrayList
    Dim ObjController As New CmsController

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            IdKey = context.Request.Item("key")
            newid = context.Request.Item("id")
            IdValue = context.Request.Item("val")
            PortalID = flReg.WriteNumber(context.Request.Item("p"))
            IsStop = False
            If context.Request.Item("d") & "" = "1" Then IsStop = True

            Select Case IdKey
                Case "banner" 'Cache banner, fotter
                    flCache.RemoveCache("HomeFooter")
                    flCache.RemoveCache("FooterLogo")
                Case "adv" 'Cache adv
                    Dim arr As ArrayList = flDnn.DNN_TabModuleSettings_Get_Control(Me.PortalID, Me.PortalID, "\DesktopModules\Modules\CMS\Banner\BannerQuangCao.ascx")
                    For Each Cr As DnnInfo In arr
                        flCache.RemoveCache("BannerQuangCao" & Cr.TabModuleID)
                    Next
                Case "settings"
                    flCache.RemoveCache(IdValue)
                    PortalController.UpdatePortalSetting(PortalID, IdValue, newid, True)
            End Select
            context.Response.Write("")
        Catch
            context.Response.Write("")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class