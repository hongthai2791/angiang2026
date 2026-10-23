Partial Class ResetPassword
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            litRes.Text = helper.ResetPass(Request.Item("rs"))
            Config.Touch()
        End If
    End Sub
End Class
