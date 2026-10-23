Imports DotNetNuke.Entities.Modules

Namespace DesktopModules.Modules
    Partial Class FindMode
        Inherits PortalModuleBase
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                ctlView.Visible = Me.EditMode
                If ctlView.Visible = False Then Pnview.Visible = True
            End If
        End Sub

    End Class
End Namespace

