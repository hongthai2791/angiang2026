Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK

Namespace Modules.SVL.Mar_MarketBus
    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController()
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Dim phInfo As CMS_PhienGiaoDichInfo = objController.CMS_PhienGiaoDich_Get(Me.PortalId, Request.Item("itemid"))
                If IsNothing(phInfo) = False Then litTitle.Text = "<h3 class=""box-title"">" & phInfo.TenPhien & "</h3>"
                Dim buInfo As CMS_BusinessInfo = objController.CMS_Business_Get(Me.PortalId, Request.Item("busid"))
                If IsNothing(buInfo) = False Then TenPhien.Text = buInfo.Business_Vn
            End If
        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/mar-market-run/itemid/" & Request.Item("itemid"), True)

        End Sub
    End Class
End Namespace
