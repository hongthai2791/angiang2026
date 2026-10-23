Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK


Namespace DesktopModules.TinTuc.Control
    Partial Class Tbkq
        Inherits CDefault
        Dim ObjController As New WorkController
        Dim arr As New ArrayList
        Dim marInfo As New CMS_PhienGiaoDichInfo
        Private Sub GetID()
            PortalID.Value = flReg.WriteNumber(Request.Item("pid"))
            ItemID.Value = Request.Item("id")
        End Sub

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Function getKetQua(UngVienID As String) As String
            getKetQua = ""
            For Each Cr As CMS_DoanhNghiep_UngVienInfo In ObjController.CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(PortalID.Value, ItemID.Value, UngVienID)
                getKetQua = Cr.Business_Vn & " | <b>" & FormatKetQuaPhongVan(Cr.KetQuaPhongVan) & "</b><br/>"
            Next
        End Function
        Public Function FormatKetQuaPhongVan(kq As Integer) As String
            If kq = 1 Then Return "Đạt"
            If kq = 2 Then Return "Không đạt"
            If kq = 3 Then Return "Hẹn phỏng vấn lại"
            If kq = 4 Then Return "Trúng sơ tuyển"
            Return "Chờ phỏng vấn"
        End Function
        Private Sub LoadValue()
            Try
                litContent.Text = ""
                marInfo = ObjController.CMS_PhienGiaoDich_Get(PortalID.Value, ItemID.Value)
                If IsNothing(marInfo) = False Then
                    ltTitle.Text = marInfo.TenPhien

                    arr = ObjController.CMS_UngVien_List_PhienGD_ID(PortalID.Value, marInfo.PhienGD_ID)
                    lblSoUngVien.Text = arr.Count
                    lblThoiGian.Text = marInfo.ThoiGian_BatDau.ToString("dd/MM HH:mm")
                    lblThoiGianKetThuc.Text = marInfo.ThoiGian_KetThuc.ToString("dd/MM HH:mm")

                    litContent.Text += " <table width=""100%"" Class=""table table-bordered "">"
                    Dim i As Integer = 1
                    For Each listtable As CMS_UngVienInfo In arr
                        litContent.Text += "<tr>"
                        litContent.Text += "<td  width=""4%"" class=""txt-center"">" & i & "</td>"
                        litContent.Text += "<td width=""15%"">" & listtable.TenDayDu & "</td>"
                        litContent.Text += "<td width=""7%"" class=""txt-center"">" & flCheck.GioiTinh(IIf(listtable.GioiTinh = 2, -1, listtable.GioiTinh)) & "</td>"
                        litContent.Text += "<td width=""10%"" class=""txt-center"">" & flReg.ReadDate((listtable.NgaySinh), False) & "</td>"
                        litContent.Text += "<td width=""25%"">" & listtable.DiaChi & "</td>"
                        litContent.Text += "<td width=""38%"">" & getKetQua(listtable.UngVien_ID) & "</td>"
                        litContent.Text += "</tr>"
                        i += 1
                    Next
                    litContent.Text += "</table>"
                    Dim tkInfo As CMS_ThongKeBaoCaoInfo = ObjController.CMS_ThongKeBaoCao_SanVL(PortalID.Value, marInfo.PhienGD_ID)
                    If IsNothing(tkInfo) = False Then
                        lblSoUngVien.Text = tkInfo.ThamGia
                        lblSoUngVienDat.Text = tkInfo.Dat
                        lblSoUngVienHenGapLai.Text = tkInfo.KhongDat
                        lblSoUngVienKhac.Text = tkInfo.ThamGia - tkInfo.Dat - tkInfo.KhongDat
                    End If
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class
End Namespace