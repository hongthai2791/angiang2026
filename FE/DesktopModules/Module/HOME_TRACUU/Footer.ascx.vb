Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CHATBOT

Namespace DesktopModules.Home
    Partial Class Footer
        Inherits PortalModuleBase
        Dim wCtl As New WORK.WorkController
        Dim arr As New ArrayList
        Dim obStatic As New WORK.CMS_SysStatisticInfo
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        End Sub


    End Class
End Namespace

