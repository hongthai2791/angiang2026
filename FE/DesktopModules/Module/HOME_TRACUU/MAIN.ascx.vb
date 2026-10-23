Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU
Namespace DesktopModules.Modules.Home
    Partial Class MAIN
        Inherits Entities.Modules.PortalModuleBase

        Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load
            InitData()
        End Sub
        Private Sub InitData()
            Call flFunction.LoadSatellite(flReg.WebConfig("TinhTP"), VeTinh, "")
        End Sub
    End Class
End Namespace