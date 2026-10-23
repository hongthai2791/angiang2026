Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK

Namespace Modules.SVL
    Partial Class View
        Inherits PortalModuleBase
        Public PhienGD As String
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                litTitle.Text = "<h3 class=""box-title"">Thông tin phiên giao dịch việc làm</h3>"
                PhienGD = Request.Item("itemid")
                Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD)
                If IsNothing(phInfo) = False Then TenPhien.Text = phInfo.TenPhien
            End If
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/mar-market-list", True)
        End Sub
    End Class
End Namespace
