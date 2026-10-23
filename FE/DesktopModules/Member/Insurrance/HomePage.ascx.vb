Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim arr As New ArrayList, i As Integer
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Call flFunction.LoadPortals(Me.PortalId, drPortal)
        End Sub

        Public Sub cmSearch_Click() Handles cmSearch.Click
            If (txtSearch.Text.Trim & "" = "") Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "warning_box", ";notify('info', 'Nhập mã số hồ sơ để tìm kiếm', 'Thông báo', false);", True)
            Else
                Response.Redirect("/tra-cuu-ho-so/ma-hs/" & txtSearch.Text.Trim(), True)
            End If
        End Sub

        Public Sub cmSearch1_Click() Handles cmSearch1.Click
            If (txtSearch1.Text.Trim & "" = "") Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "warning_box", ";notify('info', 'Nhập mã số hồ sơ để tìm kiếm', 'Thông báo', false);", True)
            Else
                Response.Redirect("/tra-cuu-ho-so/ma-hs/" & txtSearch1.Text.Trim(), True)
            End If
        End Sub

        Private Sub cmdBHTN_Click(sender As Object, e As EventArgs) Handles cmdBHTN.Click
            Response.Redirect("/nop-ho-so/pid/" & drPortal.SelectedValue & "/hs/tro-cap-that-nghiep", True)
        End Sub

        Private Sub cmdHocNghe_Click(sender As Object, e As EventArgs) Handles cmdHocNghe.Click
            Response.Redirect("/nop-ho-so/pid/" & drPortal.SelectedValue & "/hs/ho-tro-hoc-nghe", True)
        End Sub

        Private Sub cmdTuVan_Click(sender As Object, e As EventArgs) Handles cmdTuVan.Click
            Response.Redirect("/nop-ho-so/pid/" & drPortal.SelectedValue & "/hs/tu-van-gioi-thieu", True)
        End Sub

        Private Sub cmdKhaiBao_Click(sender As Object, e As EventArgs) Handles cmdKhaiBao.Click
            Response.Redirect("/nop-ho-so/pid/" & drPortal.SelectedValue & "/hs/khai-bao-viec-lam", True)
        End Sub

        Private Sub cmdXepHang_Click(sender As Object, e As EventArgs) Handles cmdXepHang.Click
            Response.Redirect("/nop-ho-so/pid/" & drPortal.SelectedValue & "/hs/dang-ky-lay-so", True)
        End Sub
    End Class
End Namespace

