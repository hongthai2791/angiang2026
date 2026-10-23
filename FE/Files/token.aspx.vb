Partial Class _Token
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("token_f") = ""
        Session("token_u") = ""
        Session("token_c") = ""
        Session("token_i") = ""
    End Sub
End Class
