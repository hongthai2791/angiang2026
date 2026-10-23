Namespace Modules.LoginPage
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Request.Item("returnurl") & "" <> "" Then Response.Redirect("/", True)
        End Sub

    End Class

End Namespace
