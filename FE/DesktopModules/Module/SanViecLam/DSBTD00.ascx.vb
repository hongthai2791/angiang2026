Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules

    Partial Class DSBTD00
        Inherits PortalModuleBase
        Dim objController As New WorkController

        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property

        Public Sub LoadValue()
            Try
                Dim phien As CMS_PhienGiaoDichInfo = objController.CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
                lblTenPhien.Text = phien.TenPhien.ToUpper
                lblDiaDiem.Text = phien.DiaDiem
                lblHotline.Text = phien.Hotline
                lblThoiGianBatDau.Text = phien.ThoiGian_BatDau.ToString("HH:mm dd/MM/yyyy")
                lblThoiGianKetThuc.Text = phien.ThoiGian_KetThuc.ToString("HH:mm dd/MM/yyyy")

                Panel1.CssClass = FormatClass(phien.IsActive, phien.ThoiGian_BatDau, phien.ThoiGian_KetThuc)

                If Now > phien.ThoiGian_KetThuc Then
                    btnThamGiaNgay.Enabled = False
                    btnThamGiaNgay.Text = "Phiên giao dịch đã kết thúc"
                ElseIf Now < phien.ThoiGian_BatDau Then
                    btnThamGiaNgay.Enabled = False
                    btnThamGiaNgay.Text = "Phiên đang sắp diễn ra"
                Else
                    'btnThamGiaNgay.Visible = False
                End If
            Catch ex As Exception
                btnThamGiaNgay.Enabled = False
                btnThamGiaNgay.Text = "Hiện chưa có sàn nào."
                btnBangGiaoDichChung.Enabled = False
                btnBangTinViecTimNguoi.Enabled = False
                btnBangTinNguoiTimViec.Enabled = False
            End Try
        End Sub

        Public Function FormatClass(ByVal IsActive As Integer, ByVal batdat As Date, ByVal ketthuc As Date) As String
            Dim isPhien As Integer = 1
            If batdat > Now Or ketthuc < Now Then
                isPhien = 0
            End If
            Return String.Format("{0}", If(isPhien = 1, IIf(IsActive, "box-PhienName-online", "box-PhienName"), IIf(IsActive, "box-PhienName", "box-PhienName")))
        End Function
        Protected Sub btnThamGiaNgay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThamGiaNgay.Click
            Response.Redirect(EPORTAL.flReg.WebConfig("member"), True)
        End Sub
        'Protected Sub btnBangGiaoDichChung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBangGiaoDichChung.Click
        '    Response.Redirect("/san-viec-lam/bang-thong-tin-chung/itemid/" & PhienGD_ID)
        'End Sub
        'Protected Sub btnBangTinNguoiTimViec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBangTinNguoiTimViec.Click
        '    Response.Redirect("/san-viec-lam/danh-sach-ntv/itemid/" & PhienGD_ID)
        'End Sub
        'Protected Sub btnBangTinViecTimNguoi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBangTinViecTimNguoi.Click
        '    Response.Redirect("/san-viec-lam/danh-sach-vtn/itemid/" & PhienGD_ID)
        'End Sub

    End Class

End Namespace