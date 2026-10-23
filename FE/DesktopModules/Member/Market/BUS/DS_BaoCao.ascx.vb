Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.DsBaoCao
    Partial Class View
        Inherits PortalModuleBase

        Public Sub LoadValue()
            Dim phienInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, Request.Item("itemid"))
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
                lblThoiGian.Text = flReg.ReadDate(phienInfo.ThoiGian_BatDau)
                lblThoiGianKetThuc.Text = flReg.ReadDate(phienInfo.ThoiGian_KetThuc)
                Dim tkInfo As CMS_ThongKeBaoCaoInfo = New WorkController().CMS_ThongKeBaoCao_SanVL(Me.PortalId, Request.Item("itemid"))
                If IsNothing(tkInfo) = False Then
                    lblSoBan.Text = tkInfo.SoBan
                    lblSoUngVien.Text = tkInfo.ThamGia
                    lblSoUngVienDat.Text = tkInfo.Dat
                    lblSoUngVienKhongDat.Text = tkInfo.KhongDat
                    lblSoUngVienHenGapLai.Text = tkInfo.GapLai
                    lblSoUngVienTrungTuyen.Text = tkInfo.TrungTuyen
                End If
            End If
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Call LoadValue()
        End Sub
    End Class
End Namespace
