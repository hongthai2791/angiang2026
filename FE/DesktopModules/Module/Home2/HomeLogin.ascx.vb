Namespace Modules.HomeLogin
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            ctlView.Visible = Me.EditMode
        End Sub

    End Class

End Namespace
