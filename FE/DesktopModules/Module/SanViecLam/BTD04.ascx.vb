Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK
Namespace DesktopModules.Modules

    Partial Class BTD04
        Inherits PortalModuleBase
        Dim objControl As New WorkController()
        Public Property Business_ID() As String
            Get
                Return BusID.Value
            End Get
            Set(ByVal value As String)
                BusID.Value = value
            End Set
        End Property
        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property
        Public Sub LoadValue()
            Dim phienInfo As CMS_PhienGiaoDichInfo = objControl.CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
                lbtBussines.Text = flCheck.Business_Vn(Me.PortalId, Business_ID)

                lblThoiGian.Text = phienInfo.ThoiGian_BatDau.ToString("dd/MM/yyy HH:mm")
                lblThoiGianKetThuc.Text = phienInfo.ThoiGian_KetThuc.ToString("dd/MM/yyy HH:mm")
                Dim tkInfo As CMS_ThongKeBaoCaoInfo = objControl.CMS_ThongKeBaoCao_SanVL(Me.PortalId, PhienGD_ID, Business_ID)
                If IsNothing(tkInfo) = False Then
                    lblSoBan.Text = tkInfo.SoBan
                    lblSoUngVien.Text = tkInfo.ThamGia
                    lblSoUngVienDat.Text = tkInfo.Dat
                    lblSoUngVienKhongDat.Text = tkInfo.KhongDat
                    lblSoUngVienHenGapLai.Text = tkInfo.GapLai
                    lblSoUngVienTrungTuyen.Text = tkInfo.TrungTuyen
                End If

                GridView1.DataSource = objControl.CMS_DoanhNghiep_UngVien_Get_By_Business(Me.PortalId, PhienGD_ID, Business_ID)
                GridView1.DataBind()
            End If
        End Sub
        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                Call LoadValue()
            Catch ex As Exception
                lblSoUngVien.Text = ex.Message
            End Try
        End Sub
        Public Function FormatKetQuaPhongVan(ByVal kq As Integer) As String
            If kq = 1 Then Return "Đạt"
            If kq = 2 Then Return "Không đạt"
            If kq = 3 Then Return "Hẹn phỏng vấn lại"
            If kq = 4 Then Return "Trúng sơ tuyển"
            Return "Chưa có kết quả"
        End Function
    End Class


End Namespace