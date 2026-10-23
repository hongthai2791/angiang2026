Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK

Namespace Modules.SVL.US.Market_Run
    Partial Class View
        Inherits PortalModuleBase
        Public idtab As String
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                litTitle.Text = "<h3 class=""box-title"">Thông tin phiên giao dịch việc làm</h3>"
                Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, Request.Item("itemid"))
                If IsNothing(phInfo) = False Then TenPhien.Text = phInfo.TenPhien
                idtab = Request.Item("idtab")
            End If
        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), True)
        End Sub
    End Class
End Namespace
