Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.Mar_DSBaoCao
    Partial Class View
        Inherits PortalModuleBase
        Dim objContrller As New WorkController
        Public Sub LoadValue()
            DSBaoCao_ItemID.Value = Request.Item("itemid")
            Dim phienInfo As CMS_PhienGiaoDichInfo = objContrller.CMS_PhienGiaoDich_Get(Me.PortalId, DSBaoCao_ItemID.Value)
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
                lblThoiGian.Text = flReg.ReadDate(phienInfo.ThoiGian_BatDau)
                lblThoiGianKetThuc.Text = flReg.ReadDate(phienInfo.ThoiGian_KetThuc)

                Dim tkInfo As CMS_ThongKeBaoCaoInfo = objContrller.CMS_ThongKeBaoCao_SanVL(Me.PortalId, DSBaoCao_ItemID.Value)
                If IsNothing(tkInfo) = False Then
                    lblSoBan.Text = tkInfo.SoBan
                    lblSoUngVien.Text = tkInfo.ThamGia
                    lblSoUngVienDat.Text = tkInfo.Dat
                    lblSoUngVienKhongDat.Text = tkInfo.KhongDat
                    lblSoUngVienHenGapLai.Text = tkInfo.GapLai
                    lblSoUngVienTrungTuyen.Text = tkInfo.TrungTuyen
                    lbldnchuagioithieu.Text = tkInfo.Dnchuagioithieu
                    lbldngioithieu.Text = tkInfo.Dndagioithieu
                    lbluvchuagioithieu.Text = Session.Item("DSMoiUV_" & DSBaoCao_ItemID.Value)
                    lbluvdagioithieu.Text = tkInfo.Uvdagioithieu
                End If
            End If
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Call LoadValue()
        End Sub
    End Class
End Namespace
