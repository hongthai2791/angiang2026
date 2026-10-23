Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class LeftMenu
        Inherits PortalModuleBase
        Dim UrlAlias As String = flReg.UrlAlias
        Dim pid = flReg.WebConfig("PortalWork")
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

    End Class
End Namespace

