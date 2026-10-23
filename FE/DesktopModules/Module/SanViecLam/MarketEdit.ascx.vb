Imports DotNetNuke.Entities.Modules

Namespace DesktopModules.Modules

    Partial Class MarketEdit
        Inherits PortalModuleBase

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            If Not Page.IsPostBack Then
                Dim busID As String = Request.Item("busid") & ""
                Dim PhienGD_ID As String = Request.Item("itemid")
                If busID = "" Then
                    'Response.Redirect("/san-viec-lam")
                Else
                    ctlBTD00.Business_ID = busID
                    ctlBTD00.PhienGD_ID = PhienGD_ID

                    ctlBTD01.Business_ID = busID
                    ctlBTD01.PhienGD_ID = PhienGD_ID

                    ctlBTD02.PhienGD_ID = PhienGD_ID
                    ctlBTD02.Business_ID = busID

                    ctlBTD03.Business_ID = busID

                    ctlBTD04.Business_ID = busID
                    ctlBTD04.PhienGD_ID = PhienGD_ID
                End If
            End If

        End Sub

        Protected Sub ctlBTD00_OnClose() Handles ctlBTD00.OnClose
            'ctlBTD02.bindData()
            'lblNoUngVien.Text = ctlBTD02.CMS_SoUngVienThamGiaPhien
        End Sub

    End Class
End Namespace
