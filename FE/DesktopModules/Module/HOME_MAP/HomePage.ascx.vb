Namespace Modules.HomePage
	Partial Class View
		Inherits Entities.Modules.PortalModuleBase
		Public homeTitle As String

		Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
			If Me.UserInfo.UserID > 0 And Request.Item("ctl") = "" Then Response.Redirect("/system", True)
			homeTitle = "HỆ QUẢN TRỊ TẬP TRUNG - EPORTAL v2.0"
		End Sub

	End Class

End Namespace
