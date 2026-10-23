Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.INSU
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_ProSubsiInfo
        Dim sFileType As String
        Public _pid As Integer
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            drPortal.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, TT_TinhTP)
            TT_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))
            Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")

            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            CO_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))
            Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")

            Call flDic.LoadRegional_Parent_Null(0, CT_TinhTP)
            CT_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))
            Call flDic.LoadRegional_Parent_ID(0, CT_QuanHuyen, CT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            Call flFunction.LoadDVTV(LoaiDVTV)
            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadReligion(0, TonGiao)
            Call flFunction.LoadCauseOf(0, NguyenNhanNV)
            Call flFunction.LoadBanking(0, NganHang, "- - - Chọn ngân hàng - - -")
            Call flFunction.LoadPreCareer(0, NgheTruocNghi)
            Call flFunction.LoadPreIndu(0, NganhTruocNghi)
            Call flFunction.LoadCareer(0, NganhDT)
            Call flFunction.LoadTechnical(0, TrinhDo)
            Call flFunction.LoadInsurance(drPortal.SelectedValue, NoiDKKCB)
            Call flFunction.LoadRecipients(drPortal.SelectedValue, NoiNhanTCTN)
            Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
            Call flFunction.LoadContractType(0, LoaiHD)
            Call flDic.LoadPlace(0, NoiCap)
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn hủy hồ sơ tư vấn này không?');")
            _pid = Me.PortalId
            ItemID.Value = Request.Item("id")
        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_ProSubsi_Get(Me.PortalId, ItemID.Value)

            If IsNothing(obj) = False Then
                drPortal.SelectedValue = obj.PortalID
                drPortal.Enabled = False
                NoCode.Value = obj.NoCode

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
                lbTrangThai.Text = "<span class='label label-info'>" & flCheck.getTrangThai(obj.TrangThai) & "</span>"
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
                TenCT.Text = flReg.RemoveScript(obj.CongTy, False)
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

                TenTepDK.Value = obj.TenTepDK
                DuongDanDK.Value = obj.DuongDanDK
                If obj.TrangThai >= TrangThaiHS.DaNop Then
                    cmdSave.Visible = False
                    cmdSend.Visible = False
                End If
                If obj.DuongDanDK <> "" Then
                    litUp.Text = "<div class=""download""><a target=""_blank"" href=""" & obj.DuongDanDK & """ title=""Tải xuống"">"
                    litUp.Text += "<img src=""/image/images/download.png"" alt=""Tải xuống"" /></a><div><span class=""dname"">" & obj.TenTepDK & "</div></div>"
                End If
            Else
                HoTen.Text = Me.UserInfo.DisplayName
                Email.Text = Me.UserInfo.Email
                DienThoai.Text = Me.UserInfo.Profile.Telephone
                drPortal.SelectedValue = flReg.WebConfig("TinhTP")
            End If
        End Sub
        Private Sub SaveAttch(obj As EXE_ProSubsiInfo)
            obj.TenTepDK = TenTepDK.Value
            obj.DuongDanDK = DuongDanDK.Value
            For Each a As HttpPostedFile In AttactFilePath.PostedFiles
                If a.ContentLength > 0 Then
                    sFileType = flReg.GetFileType(a.FileName, ".").ToLower
                    If ".pdf,.jpg,.png".Contains(sFileType) Then
                        obj.DuongDanDK = flText.DOC_DOC & "/" & flReg.GenKey() & "." & sFileType
                        obj.TenTepDK = flReg.RemoveScript(a.FileName)
                        a.SaveAs(Server.MapPath(obj.DuongDanDK))
                        Exit Sub
                    End If
                End If
            Next
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
        Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
            Try
                obj = New EXE_ProSubsiInfo
                Call SaveAttch(obj)
                    obj.HoTen = flReg.RemoveScript(HoTen.Text.ToUpper.Trim())
                    obj.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                    obj.GioiTinh = GioiTinh.SelectedValue
                    obj.SoCMND = flReg.RemoveScript(SoCMND.Text.Trim())
                    obj.NgayCap = flReg.WriteDate(NgayCap.Text, False)
                    obj.NoiCap = flReg.RemoveScript(NoiCap.Text.Trim())
                    obj.SoBHXH = flReg.RemoveScript(SoBHXH.Text.Trim())
                    obj.Email = flReg.RemoveScript(Email.Text.Trim())
                    obj.DienThoai = flReg.RemoveScript(DienThoai.Text.Trim())
                    obj.DanToc = DanToc.SelectedValue
                    obj.TonGiao = TonGiao.SelectedValue
                    obj.SoTaiKhoan = flReg.RemoveScript(SoTaiKhoan.Text.Trim())
                    obj.NganHang = NganHang.SelectedValue
                    obj.ChiNhanhNH = ChiNhanhNH.SelectedValue
                    obj.TT_TinhTP = TT_TinhTP.SelectedValue
                    obj.TT_QuanHuyen = TT_QuanHuyen.SelectedValue
                    obj.TT_XaPhuong = TT_XaPhuong.SelectedValue
                    obj.TT_DuongPho = flReg.RemoveScript(TT_DuongPho.Text.Trim())
                    obj.CO_TinhTP = CO_TinhTP.SelectedValue
                    obj.CO_QuanHuyen = CO_QuanHuyen.SelectedValue
                    obj.CO_XaPhuong = CO_XaPhuong.SelectedValue
                    obj.CO_DuongPho = flReg.RemoveScript(CO_DuongPho.Text.Trim())
                    obj.NganhDT = NganhDT.SelectedValue
                    obj.TrinhDo = TrinhDo.SelectedValue
                    obj.NgayNghiViec = flReg.WriteDate(NgayNghiViec.Text, False)
                    obj.ThangDong = flReg.WriteNumber(ThangDong.Text.Trim())
                    obj.LoaiHD = LoaiHD.SelectedValue
                    obj.CongTy = flReg.RemoveScript(TenCT.Text)
                    obj.SoDKKD = flReg.RemoveScript(SoDKKD.Text.Trim())
                    obj.CT_TinhTP = CT_TinhTP.SelectedValue
                    obj.CT_QuanHuyen = CT_QuanHuyen.SelectedValue
                    obj.CT_XaPhuong = CT_XaPhuong.SelectedValue
                    obj.CT_DuongPho = flReg.RemoveScript(CT_DuongPho.Text.Trim())
                    obj.NoiNhanTCTN = NoiNhanTCTN.SelectedValue
                    obj.NoiDKKCB = NoiDKKCB.SelectedValue
                    obj.NguyenNhanNV = NguyenNhanNV.SelectedValue
                    obj.NgheTruocNghi = NgheTruocNghi.SelectedValue
                    obj.NganhTruocNghi = NganhTruocNghi.SelectedValue
                    obj.PortalID = drPortal.SelectedValue
                    obj.TrangThai = TrangThaiHS.DaNop
                obj.NgayNopHS = flReg.DateNull
                obj.NgayTiepNhan = flReg.DateNull
                    obj.NguoiTiepNhan = ""
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username

                    If ItemID.Value <> "" Then
                        obj.ProSubsi_ID = ItemID.Value
                        obj.NoCode = NoCode.Value
                        obj.UpdatedDate = Now
                        obj.UpdatedUser = Me.UserInfo.Username
                        objController.EXE_ProSubsi_Update(drPortal.SelectedValue, obj)
                        objController.EXE_ProSubsi_Update_TrangThai(drPortal.SelectedValue, ItemID.Value, TrangThaiHS.DaNop, Now, "Guest", "")
                    Else
                        obj.ProSubsi_ID = flReg.GenKey()
                        obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.TCTN)
                        obj.UpdatedDate = flReg.DateNull
                        obj.UpdatedUser = ""
                        objController.EXE_ProSubsi_Add(drPortal.SelectedValue, obj)
                    End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Nộp hồ sơ thành công', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "insu") & "', 'Thông báo', false);", True)
                'Response.Redirect("/nop-ho-so/tb/nop-ho-so-that-bai", True)
            End Try
        End Sub
        Private Sub CO_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CO_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            CO_XaPhuong.Items.Clear()
            'CO_QuanHuyen.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub CO_QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CO_QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
            'CO_XaPhuong.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub CT_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CT_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CT_QuanHuyen, CT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            CT_XaPhuong.Items.Clear()
            'CT_QuanHuyen.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub CT_QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CT_QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CT_XaPhuong, CT_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
            'CT_XaPhuong.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub TT_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            TT_XaPhuong.Items.Clear()
            'TT_QuanHuyen.Focus()
            If CO_TinhTP.SelectedValue = "" Then
                CO_TinhTP.SelectedValue = TT_TinhTP.SelectedValue
                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue)
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub TT_QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, TT_XaPhuong, TT_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
            'TT_XaPhuong.Focus()
            If CO_QuanHuyen.SelectedValue = "" Then
                CO_QuanHuyen.SelectedValue = TT_QuanHuyen.SelectedValue
                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue)
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/users/view/dang-ky-tu-van", True)
        End Sub
        Private Sub NganHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NganHang.SelectedIndexChanged
            Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
            'ChiNhanhNH.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub TT_XaPhuong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_XaPhuong.SelectedIndexChanged
            If CO_XaPhuong.SelectedValue = "" Then CO_XaPhuong.SelectedValue = TT_XaPhuong.SelectedValue
            'TT_DuongPho.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub drPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drPortal.SelectedIndexChanged
            Call flFunction.LoadInsurance(drPortal.SelectedValue, NoiDKKCB)
            Call flFunction.LoadRecipients(drPortal.SelectedValue, NoiNhanTCTN)
            Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub

        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                obj = New EXE_ProSubsiInfo
                Call SaveAttch(obj)
                    obj.HoTen = flReg.RemoveScript(HoTen.Text.ToUpper.Trim())
                    obj.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                    obj.GioiTinh = GioiTinh.SelectedValue
                    obj.SoCMND = flReg.RemoveScript(SoCMND.Text.Trim())
                    obj.NgayCap = flReg.WriteDate(NgayCap.Text, False)
                    obj.NoiCap = flReg.RemoveScript(NoiCap.Text.Trim())
                    obj.SoBHXH = flReg.RemoveScript(SoBHXH.Text.Trim())
                    obj.Email = flReg.RemoveScript(Email.Text.Trim())
                    obj.DienThoai = flReg.RemoveScript(DienThoai.Text.Trim())
                    obj.DanToc = DanToc.SelectedValue
                    obj.TonGiao = TonGiao.SelectedValue
                    obj.SoTaiKhoan = flReg.RemoveScript(SoTaiKhoan.Text.Trim())
                    obj.NganHang = NganHang.SelectedValue
                    obj.ChiNhanhNH = ChiNhanhNH.SelectedValue
                    obj.TT_TinhTP = TT_TinhTP.SelectedValue
                    obj.TT_QuanHuyen = TT_QuanHuyen.SelectedValue
                    obj.TT_XaPhuong = TT_XaPhuong.SelectedValue
                    obj.TT_DuongPho = flReg.RemoveScript(TT_DuongPho.Text.Trim())
                    obj.CO_TinhTP = CO_TinhTP.SelectedValue
                    obj.CO_QuanHuyen = CO_QuanHuyen.SelectedValue
                    obj.CO_XaPhuong = CO_XaPhuong.SelectedValue
                    obj.CO_DuongPho = flReg.RemoveScript(CO_DuongPho.Text.Trim())
                    obj.NganhDT = NganhDT.SelectedValue
                    obj.TrinhDo = TrinhDo.SelectedValue
                    obj.NgayNghiViec = flReg.WriteDate(NgayNghiViec.Text, False)
                    obj.ThangDong = flReg.WriteNumber(ThangDong.Text.Trim())
                    obj.LoaiHD = LoaiHD.SelectedValue
                    obj.CongTy = flReg.RemoveScript(TenCT.Text)
                    obj.SoDKKD = flReg.RemoveScript(SoDKKD.Text.Trim())
                    obj.CT_TinhTP = CT_TinhTP.SelectedValue
                    obj.CT_QuanHuyen = CT_QuanHuyen.SelectedValue
                    obj.CT_XaPhuong = CT_XaPhuong.SelectedValue
                    obj.CT_DuongPho = flReg.RemoveScript(CT_DuongPho.Text.Trim())
                    obj.NoiNhanTCTN = NoiNhanTCTN.SelectedValue
                    obj.NoiDKKCB = NoiDKKCB.SelectedValue
                    obj.NguyenNhanNV = NguyenNhanNV.SelectedValue
                    obj.NgheTruocNghi = NgheTruocNghi.SelectedValue
                    obj.NganhTruocNghi = NganhTruocNghi.SelectedValue
                    obj.PortalID = drPortal.SelectedValue
                    obj.TrangThai = TrangThaiHS.DangSoan
                    obj.NgayNopHS = Now
                    obj.NgayTiepNhan = flReg.DateNull
                    obj.NguoiTiepNhan = ""
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username
                    obj.IsType = LoaiDVTV.SelectedValue
                    If ItemID.Value <> "" Then
                        obj.ProSubsi_ID = ItemID.Value
                        obj.NoCode = NoCode.Value
                        obj.UpdatedDate = Now
                        obj.UpdatedUser = Me.UserInfo.Username
                        objController.EXE_ProSubsi_Update(drPortal.SelectedValue, obj)
                    Else
                        obj.ProSubsi_ID = flReg.GenKey()
                        obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.TCTN)
                        obj.UpdatedDate = flReg.DateNull
                        obj.UpdatedUser = ""
                        objController.EXE_ProSubsi_Add(drPortal.SelectedValue, obj)
                    End If

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Lưu thông tin thành công', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "insu") & "', 'Thông báo', false);", True)
                'Response.Redirect("/nop-ho-so/tb/nop-ho-so-that-bai", True)
            End Try
        End Sub

        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.EXE_ProSubsi_Delete(Me.PortalId, ItemID.Value)
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace

