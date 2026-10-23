Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL
    Partial Class View
        Inherits PortalModuleBase

        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property
        Public Sub LoadValue()
            Dim phienInfo As CMS_PhienGiaoDichInfo = New WORKController().CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
                lblThoiGian.Text = phienInfo.ThoiGian_BatDau.ToString("dd/MM/yyy HH:mm")
                lblThoiGianKetThuc.Text = phienInfo.ThoiGian_KetThuc.ToString("dd/MM/yyy HH:mm")
                Dim tkInfo As CMS_ThongKeBaoCaoInfo = New WORKController().CMS_ThongKeBaoCao_SanVL(Me.PortalId, PhienGD_ID)
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

