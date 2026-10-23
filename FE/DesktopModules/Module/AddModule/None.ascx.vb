Partial Class XTemplate
    Inherits Entities.Modules.PortalModuleBase
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.UserInfo.Username = "host" Then litView.Text = "<div style='font-size:12px;color:blue'>Bạn chưa thiết lập cài đặt Module</div>"
    End Sub
End Class
