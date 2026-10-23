Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.INSU
Imports DotNetNuke.EPORTAL
Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim arr As New ArrayList
        Dim adsInfo As EXE_AdvisorySInfo
        Dim adcInfo As EXE_AdvisoryCInfo
        Dim obj As EXE_AdvisoryInfo
        Dim tbox As TextBox, lit As Literal
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            drPortal.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, TT_TinhTP)
            TT_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            CO_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, GT_TinhTP)
            GT_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadReligion(0, TonGiao)
            Call flDic.LoadLanguage(0, NgoaiNgu)
            Call flFunction.LoadBanking(0, NganHang, "- - - Chọn ngân hàng - - -")
            Call flDic.LoadPlace(0, NoiCap)
            Call flFunction.LoadTechnology(0, TinHoc)
            Call flFunction.LoadTechnical(0, ChuyenMonKT)
            Call flFunction.LoadLeaving(0, LyDoNghi)
            Call flFunction.LoadSkill(0, KyNangNghe)
            Call flFunction.LoadLocation(0, GT_ViTri)
            Call flFunction.LoadWage(0, GT_MucLuong)
            Call flFunction.LoadComType(0, GT_LoaiHinh)
            Call flFunction.LoadRecruitment(0, GT_CongViec)
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn hủy hồ sơ tư vấn này không?');")

            ItemID.Value = Request.Item("itemid")

        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_Advisory_Get(Me.PortalId, ItemID.Value)
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
                ChiNhanhNH.SelectedValue = obj.ChiNhanhNH
                TT_TinhTP.SelectedValue = obj.TT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                TT_QuanHuyen.SelectedValue = obj.TT_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, TT_XaPhuong, TT_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                TT_XaPhuong.SelectedValue = obj.TT_XaPhuong

                TT_DuongPho.Text = flReg.RemoveScript(obj.TT_DuongPho, False)
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong

                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)

                SucKhoe.Text = flReg.RemoveScript(obj.SucKhoe, False)
                ChieuCao.Text = flReg.RemoveScript(obj.ChieuCao, False)
                CanNang.Text = flReg.RemoveScript(obj.CanNang, False)
                NgoaiNgu.SelectedValue = obj.NgoaiNgu
                GiaoDucPT.Text = flReg.RemoveScript(obj.GiaoDucPT, False)
                TinHoc.SelectedValue = obj.TinHoc
                ChuyenMonKT.SelectedValue = obj.ChuyenMonKT
                MucLuong.Text = flReg.RemoveScript(obj.MucLuong, False)
                LyDoNghi.SelectedValue = obj.LyDoNghi
                DaTimViecTai.Text = flReg.RemoveScript(obj.DaTimViecTai, False)
                KyNangNghe.SelectedValue = obj.KyNangNghe
                KhaNangNoiTroi.Text = flReg.RemoveScript(obj.KhaNangNoiTroi, False)
                TuVan_ChinhSach.Checked = obj.TuVan_ChinhSach
                TuVan_ViecLam.Checked = obj.TuVan_ViecLam
                TuVan_BHTN.Checked = obj.TuVan_BHTN
                TuVan_Khac.Checked = obj.TuVan_Khac
                GT_ViTri.SelectedValue = obj.GT_ViTri
                GT_MucLuong.SelectedValue = obj.GT_MucLuong
                GT_CongViec.SelectedValue = obj.GT_CongViec
                GT_TinhTP.SelectedValue = obj.GT_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, GT_QuanHuyen, GT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                GT_QuanHuyen.SelectedValue = obj.GT_QuanHuyen

                GT_LoaiHinh.SelectedValue = obj.GT_LoaiHinh
                GT_DieuKien.Text = flReg.RemoveScript(obj.GT_DieuKien, False)
                GT_Khac.Text = flReg.RemoveScript(obj.GT_Khac, False)

                arr = objController.EXE_AdvisoryS_Get_By_EXE_Advisory(Me.PortalId, ItemID.Value)
                If arr.Count = 0 Then Call AdsRows(3, arr)
                grdAds.DataSource = arr
                grdAds.PageSize = arr.Count + 1
                grdAds.DataKeyField = "AdvisoryS_ID"
                grdAds.DataBind()

                If obj.TrangThai >= TrangThaiHS.DaNop Then
                    cmdSave.Visible = False
                    cmdSend.Visible = False
                End If
                arr = objController.EXE_AdvisoryC_Get_By_EXE_Advisory(Me.PortalId, ItemID.Value)
                If arr.Count = 0 Then Call AdcRows(3, arr)
                grdAdc.DataSource = arr
                grdAdc.PageSize = arr.Count + 1
                grdAdc.DataKeyField = "AdvisoryC_ID"
                grdAdc.DataBind()
            Else
                HoTen.Text = Me.UserInfo.DisplayName
                Email.Text = Me.UserInfo.Email
                DienThoai.Text = Me.UserInfo.Profile.Telephone
                arr = New ArrayList
                Call AdsRows(3, arr)
                grdAds.DataSource = arr
                grdAds.DataKeyField = "AdvisoryS_ID"
                grdAds.DataBind()

                arr = New ArrayList
                Call AdcRows(3, arr)
                grdAdc.DataSource = arr
                grdAdc.DataKeyField = "AdvisoryC_ID"
                grdAdc.DataBind()
                drPortal.SelectedValue = flReg.WebConfig("TinhTP")

            End If
        End Sub
        Private Sub AdsRows(j As Integer, arrA As ArrayList)
            For i As Integer = 1 To j
                adsInfo = New EXE_AdvisorySInfo
                adsInfo.AdvisoryS_ID = flReg.GenKey()
                adsInfo.Specialized = ""
                adsInfo.LevelName = ""
                adsInfo.IsOrder = grdAds.Items.Count + i
                arrA.Add(adsInfo)
            Next
        End Sub
        Private Sub AdcRows(j As Integer, arrA As ArrayList)
            For i As Integer = 1 To j
                adcInfo = New EXE_AdvisoryCInfo
                adcInfo.AdvisoryC_ID = flReg.GenKey()
                adcInfo.Company = ""
                adcInfo.TimeWork = ""
                adcInfo.Location = ""
                adcInfo.IsOrder = grdAdc.Items.Count + i
                arrA.Add(adcInfo)
            Next
        End Sub
        Private Function GetAds() As ArrayList
            GetAds = New ArrayList
            For Each Item As DataGridItem In grdAds.Items
                adsInfo = New EXE_AdvisorySInfo
                adsInfo.AdvisoryS_ID = grdAds.DataKeys(Item.ItemIndex)

                tbox = Item.FindControl("Specialized")
                adsInfo.Specialized = tbox.Text.Trim()

                tbox = Item.FindControl("LevelName")
                adsInfo.LevelName = tbox.Text.Trim()

                tbox = Item.FindControl("IsOrder")
                adsInfo.IsOrder = tbox.Text.Trim()

                GetAds.Add(adsInfo)
            Next
        End Function
        Private Function GetAdc() As ArrayList
            GetAdc = New ArrayList
            For Each Item As DataGridItem In grdAdc.Items
                adcInfo = New EXE_AdvisoryCInfo
                adcInfo.AdvisoryC_ID = grdAdc.DataKeys(Item.ItemIndex)

                tbox = Item.FindControl("Company")
                adcInfo.Company = tbox.Text.Trim()

                tbox = Item.FindControl("TimeWork")
                adcInfo.TimeWork = tbox.Text.Trim()

                tbox = Item.FindControl("Location")
                adcInfo.Location = tbox.Text.Trim()

                tbox = Item.FindControl("IsOrder")
                adcInfo.IsOrder = tbox.Text.Trim()

                GetAdc.Add(adcInfo)
            Next
        End Function
        Private Sub SaveAdc(AdvisoryID As String)
            For Each Cr As EXE_AdvisoryCInfo In GetAdc()
                If Cr.Company <> "" Then
                    Cr.Advisory_ID = AdvisoryID
                    objController.EXE_AdvisoryC_Add(drPortal.SelectedValue, Cr)
                Else
                    objController.EXE_AdvisoryC_Delete(drPortal.SelectedValue, Cr.AdvisoryC_ID)
                End If
            Next
        End Sub
        Private Sub SaveAds(AdvisoryID As String)
            For Each Cr As EXE_AdvisorySInfo In GetAds()
                If Cr.Specialized <> "" Then
                    Cr.Advisory_ID = AdvisoryID
                    objController.EXE_AdvisoryS_Add(drPortal.SelectedValue, Cr)
                Else
                    objController.EXE_AdvisoryS_Delete(drPortal.SelectedValue, Cr.AdvisoryS_ID)
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
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                obj = New EXE_AdvisoryInfo
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

                obj.SucKhoe = flReg.RemoveScript(SucKhoe.Text.Trim())
                obj.ChieuCao = flReg.RemoveScript(ChieuCao.Text.Trim())
                obj.CanNang = flReg.RemoveScript(CanNang.Text.Trim())
                obj.NgoaiNgu = NgoaiNgu.SelectedValue
                obj.GiaoDucPT = flReg.RemoveScript(GiaoDucPT.Text.Trim())
                obj.TinHoc = TinHoc.SelectedValue
                obj.ChuyenMonKT = ChuyenMonKT.SelectedValue
                obj.MucLuong = flReg.RemoveScript(MucLuong.Text.Trim())
                obj.LyDoNghi = LyDoNghi.SelectedValue
                obj.DaTimViecTai = flReg.RemoveScript(DaTimViecTai.Text.Trim())
                obj.KyNangNghe = KyNangNghe.SelectedValue
                obj.KhaNangNoiTroi = flReg.RemoveScript(KhaNangNoiTroi.Text.Trim())
                obj.TuVan_ChinhSach = TuVan_ChinhSach.Checked
                obj.TuVan_ViecLam = TuVan_ViecLam.Checked
                obj.TuVan_BHTN = TuVan_BHTN.Checked
                obj.TuVan_Khac = TuVan_Khac.Checked
                obj.GT_ViTri = GT_ViTri.SelectedValue
                obj.GT_MucLuong = GT_MucLuong.SelectedValue
                obj.GT_CongViec = GT_CongViec.SelectedValue
                obj.GT_TinhTP = flReg.WriteNumber(GT_TinhTP.SelectedValue)
                obj.GT_QuanHuyen = flReg.WriteNumber(GT_QuanHuyen.SelectedValue)
                obj.GT_LoaiHinh = GT_LoaiHinh.SelectedValue
                obj.GT_DieuKien = flReg.RemoveScript(GT_DieuKien.Text.Trim())
                obj.GT_Khac = flReg.RemoveScript(GT_Khac.Text.Trim())
                obj.PortalID = drPortal.SelectedValue
                obj.TrangThai = TrangThaiHS.DangSoan
                obj.NgayNopHS = flReg.DateNull
                obj.NgayTiepNhan = flReg.DateNull
                obj.NguoiTiepNhan = ""
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = flReg.DateNull
                obj.UpdatedUser = ""

                If ItemID.Value <> "" Then
                    obj.Advisory_ID = ItemID.Value
                    obj.NoCode = NoCode.Value
                    obj.UpdatedDate = Now
                    obj.UpdatedUser = "Guest"
                    objController.EXE_Advisory_Update(drPortal.SelectedValue, obj)
                    objController.EXE_Advisory_Update_TrangThai(drPortal.SelectedValue, ItemID.Value, TrangThaiHS.DaNop, Now, "Guest", "")
                Else
                    obj.Advisory_ID = flReg.GenKey()
                    obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.TVGT)
                    obj.UpdatedDate = flReg.DateNull
                    obj.UpdatedUser = ""
                    objController.EXE_Advisory_Add(drPortal.SelectedValue, obj)
                End If

                Call SaveAdc(obj.Advisory_ID)
                Call SaveAds(obj.Advisory_ID)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Lưu thông tin thành công', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "insu") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
            Try
                obj = New EXE_AdvisoryInfo
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

                obj.SucKhoe = flReg.RemoveScript(SucKhoe.Text.Trim())
                obj.ChieuCao = flReg.RemoveScript(ChieuCao.Text.Trim())
                obj.CanNang = flReg.RemoveScript(CanNang.Text.Trim())
                obj.NgoaiNgu = NgoaiNgu.SelectedValue
                obj.GiaoDucPT = flReg.RemoveScript(GiaoDucPT.Text.Trim())
                obj.TinHoc = TinHoc.SelectedValue
                obj.ChuyenMonKT = ChuyenMonKT.SelectedValue
                obj.MucLuong = flReg.RemoveScript(MucLuong.Text.Trim())
                obj.LyDoNghi = LyDoNghi.SelectedValue
                obj.DaTimViecTai = flReg.RemoveScript(DaTimViecTai.Text.Trim())
                obj.KyNangNghe = KyNangNghe.SelectedValue
                obj.KhaNangNoiTroi = flReg.RemoveScript(KhaNangNoiTroi.Text.Trim())
                obj.TuVan_ChinhSach = TuVan_ChinhSach.Checked
                obj.TuVan_ViecLam = TuVan_ViecLam.Checked
                obj.TuVan_BHTN = TuVan_BHTN.Checked
                obj.TuVan_Khac = TuVan_Khac.Checked
                obj.GT_ViTri = GT_ViTri.SelectedValue
                obj.GT_MucLuong = GT_MucLuong.SelectedValue
                obj.GT_CongViec = GT_CongViec.SelectedValue
                obj.GT_TinhTP = flReg.WriteNumber(GT_TinhTP.SelectedValue)
                obj.GT_QuanHuyen = flReg.WriteNumber(GT_QuanHuyen.SelectedValue)
                obj.GT_LoaiHinh = GT_LoaiHinh.SelectedValue
                obj.GT_DieuKien = flReg.RemoveScript(GT_DieuKien.Text.Trim())
                obj.GT_Khac = flReg.RemoveScript(GT_Khac.Text.Trim())
                obj.PortalID = drPortal.SelectedValue
                obj.TrangThai = TrangThaiHS.DaNop
                obj.NgayNopHS = Now
                obj.NgayTiepNhan = flReg.DateNull
                obj.NguoiTiepNhan = ""
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = flReg.DateNull
                obj.UpdatedUser = ""

                If ItemID.Value <> "" Then
                    obj.Advisory_ID = ItemID.Value
                    obj.NoCode = NoCode.Value
                    obj.UpdatedDate = Now
                    obj.UpdatedUser = "Guest"
                    objController.EXE_Advisory_Update(drPortal.SelectedValue, obj)
                    objController.EXE_Advisory_Update_TrangThai(drPortal.SelectedValue, ItemID.Value, TrangThaiHS.DaNop, Now, "Guest", "")
                Else
                    obj.Advisory_ID = flReg.GenKey()
                    obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.TVGT)
                    obj.UpdatedDate = flReg.DateNull
                    obj.UpdatedUser = ""
                    objController.EXE_Advisory_Add(drPortal.SelectedValue, obj)
                End If

                Call SaveAdc(obj.Advisory_ID)
                Call SaveAds(obj.Advisory_ID)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Nộp hồ sơ thành công', 'Thông báo', false);", True)

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "insu") & "', 'Thông báo', false);", True)

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
        Private Sub TT_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, TT_QuanHuyen, TT_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            If CO_TinhTP.SelectedValue = "" Then
                CO_TinhTP.SelectedValue = TT_TinhTP.SelectedValue
                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue)
            End If
            TT_XaPhuong.Items.Clear()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
            'TT_QuanHuyen.Focus()
        End Sub
        Private Sub TT_QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, TT_XaPhuong, TT_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
            If CO_QuanHuyen.SelectedValue = "" Then
                CO_QuanHuyen.SelectedValue = TT_QuanHuyen.SelectedValue
                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue)
            End If
            'TT_XaPhuong.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub GT_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GT_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, GT_QuanHuyen, GT_TinhTP.SelectedValue)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/", True)
        End Sub
        Private Sub TT_XaPhuong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_XaPhuong.SelectedIndexChanged
            If CO_XaPhuong.SelectedValue = "" Then CO_XaPhuong.SelectedValue = TT_XaPhuong.SelectedValue
            'TT_DuongPho.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub grdAds_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdAds.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            tbox = e.Item.FindControl("IsOrder")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            tbox = e.Item.FindControl("Specialized")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "Specialized")

            tbox = e.Item.FindControl("LevelName")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "LevelName")

            lit = e.Item.FindControl("IsDelete")
            lit.Text = "<a herf=""javascript:;"" class=""delrows"" onclick=""delrows(this);""><img src='/portals/_default/skins/vbn/images/delete.png' title='Xóa dòng này'/></a>"

        End Sub
        Private Sub grdAdc_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdAdc.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            tbox = e.Item.FindControl("IsOrder")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            tbox = e.Item.FindControl("Company")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "Company")

            tbox = e.Item.FindControl("TimeWork")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "TimeWork")

            tbox = e.Item.FindControl("Location")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "Location")

            lit = e.Item.FindControl("IsDelete")
            lit.Text = "<a herf=""javascript:;"" class=""delrows"" onclick=""delrows(this);""><img src='/portals/_default/skins/vbn/images/delete.png' title='Xóa dòng này'/></a>"

        End Sub
        Private Sub cmdAds_Click(sender As Object, e As EventArgs) Handles cmdAds.Click
            arr = GetAds()
            Call AdsRows(1, arr)
            grdAds.DataSource = arr
            grdAds.PageSize = arr.Count + 1
            grdAds.DataKeyField = "AdvisoryS_ID"
            grdAds.DataBind()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub cmdAdc_Click(sender As Object, e As EventArgs) Handles cmdAdc.Click
            arr = GetAdc()
            Call AdcRows(1, arr)
            grdAdc.DataSource = arr
            grdAdc.PageSize = arr.Count + 1
            grdAdc.DataKeyField = "AdvisoryC_ID"
            grdAdc.DataBind()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub drPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drPortal.SelectedIndexChanged
            Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub NganHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NganHang.SelectedIndexChanged
            Call flFunction.LoadBranch(drPortal.SelectedValue, ChiNhanhNH, NganHang.SelectedValue, "- - - Chọn chi nhánh - - -")
            'ChiNhanhNH.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub

        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.EXE_Advisory_Delete(Me.PortalId, ItemID.Value)

            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace

