Namespace Modules.PageWork
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                EPORTAL.flCache.RemoveCache("CheckInfoUser_" & Me.PortalId & "_" & Me.UserInfo.Username)
            End If
        End Sub
    End Class
End Namespace