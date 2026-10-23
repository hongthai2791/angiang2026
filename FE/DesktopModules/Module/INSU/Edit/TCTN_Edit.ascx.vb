Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.INSU
Imports DotNetNuke.EPORTAL

Namespace Modules.TCTN
    Partial Class Edit
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_ProSubsiInfo
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Public _pid As Integer
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            Call flDic.LoadRegional_Parent_Null(0, TT_TinhTP)
            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            Call flDic.LoadRegional_Parent_Null(0, CT_TinhTP)

            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadPlace(0, NoiCap)
            Call flDic.LoadReligion(0, TonGiao)
            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flFunction.LoadCauseOf(0, NguyenNhanNV)
            Call flFunction.LoadBanking(0, NganHang, "- - - Chọn ngân hàng - - -")
            Call flFunction.LoadPreCareer(0, NgheTruocNghi)
            Call flFunction.LoadPreIndu(0, NganhTruocNghi)
            Call flFunction.LoadCareer(0, NganhDT)
            Call flFunction.LoadTechnical(0, TrinhDo)
            Call flFunction.LoadContractType(0, LoaiHD)

            ItemID.Value = Request.Item("id")
            _pid = flReg.WriteNumber(Request.Item("pid"))
        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_ProSubsi_Get(_pid, ItemID.Value)

            If IsNothing(obj) = False Then
                drPortal.SelectedValue = obj.PortalID
                NoCode.Text = "<span class='hdh-span'>Mã HS: </span><span class='apid-span'>" & obj.NoCode & "</span>"
                HidNoCode.Value = obj.NoCode
                HoTen.Text = flReg.RemoveScript(obj.HoTen, False)
                NgaySinh.Text = flReg.ReadDate(obj.NgaySinh, False)
                GioiTinh.SelectedValue = obj.GioiTinh
                SoCMND.Text = flReg.RemoveScript(obj.SoCMND, False)
                NgayCap.Text = flReg.ReadDate(obj.NgayCap, False)
                NoiCap.Text = flReg.RemoveScript(obj.NoiCap, False)
                SoBHXH.Text = flReg.RemoveScript(obj.SoBHXH, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                DienThoai.Text = flReg.RemoveScript(obj.DienThoai, False)
                DanToc.SelectedValue = obj.DanToc
                TonGiao.SelectedValue = obj.TonGiao
                SoTaiKhoan.Text = flReg.RemoveScript(obj.SoTaiKhoan, False)
                NganHang.SelectedValue = obj.NganHang
                TT_TinhTP.SelectedValue = obj.TT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                TT_QuanHuyen.SelectedValue = obj.TT_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, TT_XaPhuong, TT_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
                TT_XaPhuong.SelectedValue = obj.TT_XaPhuong

                TT_DuongPho.Text = flReg.RemoveScript(obj.TT_DuongPho, False)
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong

                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)
                NganhDT.SelectedValue = obj.NganhDT
                TrinhDo.SelectedValue = obj.TrinhDo
                NgayNghiViec.Text = flReg.ReadDate(obj.NgayNghiViec, False)
                ThangDong.Text = obj.ThangDong
                LoaiHD.SelectedValue = obj.LoaiHD
                CongTy.Text = flReg.RemoveScript(obj.CongTy, False)
                SoDKKD.Text = flReg.RemoveScript(obj.SoDKKD, False)
                CT_TinhTP.SelectedValue = obj.CT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CT_QuanHuyen, CT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CT_QuanHuyen.SelectedValue = obj.CT_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CT_XaPhuong, CT_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
                CT_XaPhuong.SelectedValue = obj.CT_XaPhuong

                CT_DuongPho.Text = flReg.RemoveScript(obj.CT_DuongPho, False)

                Call flFunction.LoadInsurance(drPortal.SelectedValue, NoiDKKCB)
                NoiDKKCB.SelectedValue = obj.NoiDKKCB

                Call flFunction.LoadRecipients(drPortal.SelectedValue, NoiNhanTCTN)
                NoiNhanTCTN.SelectedValue = obj.NoiNhanTCTN

                Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
                ChiNhanhNH.SelectedValue = obj.ChiNhanhNH

                NguyenNhanNV.SelectedValue = obj.NguyenNhanNV
                NgheTruocNghi.SelectedValue = obj.NgheTruocNghi
                NganhTruocNghi.SelectedValue = obj.NganhTruocNghi
                _NgayHenTra.Text = flReg.ReadDate(obj.NgayTraKetQua, False)
                If obj.DuongDanDK <> "" Then
                    litUp.Text = "<div class=""download""><a target=""_blank"" href=""" & obj.DuongDanDK & """ title=""Tải xuống"">"
                    litUp.Text += "<img src=""/image/images/download.png"" alt=""Tải xuống"" /></a><div><span class=""dname"">" & obj.TenTepDK & "</div></div>"
                End If

                If obj.TrangThai <> TrangThaiHS.DaNop Then
                    cmdActive.Visible = False
                    cmdReturn.Visible = False
                End If
            End If
            ViewState("backUrl") = "/" & _tabName & "/view/" & Request.Item("edit") & "/pid/" & drPortal.SelectedValue
        End Sub
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InnitController()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                objController.EXE_ProSubsi_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.TiepNhan, Now, Me.UserInfo.Username, "")

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã tiếp nhận và chuyển xử lý hồ sơ thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdPhieuHen_Click(sender As Object, e As EventArgs) Handles cmdPhieuHen.Click
            Try

                objController.EXE_ProSubsi_Update_PhieuHen(Me.PortalId, ItemID.Value, flReg.WriteDate(_NgayHenTra.Text, False), bigCode.QRCode(HidNoCode.Value, ""))
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Lập phiếu hẹn thành công. Mời tải phiếu hẹn', 'Thông báo', false);backend('" & ViewState("backUrl") & "');", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class
End Namespace

