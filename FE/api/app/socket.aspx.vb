Partial Class Socket_Client
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'Config.Touch() Xóa cache iis
        End If
    End Sub
End Class
