Imports DotNetNuke.Entities.Modules
Namespace DesktopModules.Modules.Home
    Partial Class FindMode
        Inherits PortalModuleBase
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                If Request.Item("fbclid") & "" <> "" Then Response.Redirect(Request.RawUrl.Substring(0, Request.RawUrl.IndexOf("?fbclid")), True)
            End If
        End Sub
    End Class
End Namespace

