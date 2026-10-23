Imports DotNetNuke.UI.UserControls
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.Vbn
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim obj As New CMS_JobUserInfo
        Dim objExtra As New CMS_JobUserExtraInfo

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            ItemID.Value = Request.Item("itemid")
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            IsApproval.Checked = True
            StartDate.Text = flReg.ReadDate(DateTime.Now, False)
            EndDate.Text = flReg.ReadDate(DateTime.Now.AddMonths(3), False)

            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP)
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP2)
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = TinhTP2.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTPMulti, "", "")
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTPMulti2, "", "")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTPMulti.SelectedValue = TinhTPMulti2.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTPMulti.SelectedValue = TinhTPMulti2.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegionalXP(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
            Call flDic.LoadRegionalXP(Me.PortalId, QuanHuyen2, TinhTP2.SelectedValue)
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = QuanHuyen2.SelectedValue = Request.Item("qh")
            'Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flDic.LoadDropList(Salary_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KieuLuong"),, "- - - Chọn - - -")
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            'Call flFunction.LoadSanSangLamViecOption(Me.PortalId, drSanSangLamViec)
            Call flDic.LoadDropList(drSanSangLamViec, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucLamViec"),, "- - - Chọn - - -")
            'Call flFunction.LoadCareer(Me.PortalId, Career_ID)

            Call flFunction.LoadNgheCongViec(Me.PortalId, Career_ID, "")
            'Call flDic.LoadPosition(Me.PortalId, LevelDesired)

            Call flDic.LoadDropList(LevelDesired, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ChucVuMongMuon"))
            Call flFunction.ListUserName(UserAdmin, IsSuper.Value, Me.PortalSettings.ActiveTab.TabName, StatusBus.NguoiTimViec)

            ''Loại hình doanh nghiệp
            Call flDic.LoadDropList(drLoaiHinhDoanhNghiep, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_LOAIHINH"))
            Call flDic.LoadDropList(MucDich_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_MucDichLV"),,)
            Call flDic.LoadDropList(Salary_Option, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_MucLuongLV"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(ContractType_Option, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_LoaiHopDong"))
            'Call flFunction.LoadNoiLamViecHuyenOption(Me.PortalId, drNoiLamViecHuyen)
            'Call flFunction.LoadNoiLamViecHuyenOption(Me.PortalId, drNoiLamViecHuyen2)
            'Call flFunction.LoadTypeOf(Me.PortalId, TypeOf_ID, "")
            Call flDic.LoadDropList(TypeOf_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucLamViec"),, "- - - Chọn - - -")

            ''Chế độ phúc lợi
            Call flDic.LoadDropList(drHoTroAn, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HoTroAn"),,)
            Call flDic.LoadDropList(drPhucLoi, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_PhucLoi"))
            Call flDic.LoadDropList(drXeDuaDon, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_XeDuaDon"))
            Call flDic.LoadDropList(drPhucLoiKhac, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HoTro"))
            'Call flFunction.LoadPhucLoiKhac(Me.PortalId, drPhucLoiKhac)

            ''Điều kiện làm việc
            Call flDic.LoadDropList(drNoiLamViec, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NoiLamViec"),, )
            Call flDic.LoadDropList(drNoiLamViecTrongLuong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_TrongLuongNang"),, )
            Call flDic.LoadDropList(drNoiLamViecDiLai, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DungDiLai"),, )
            Call flDic.LoadDropList(drNoiLamViecNgheNoi, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NgheNoi"),,)
            Call flDic.LoadDropList(drNoiLamViecThiLuc, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ThiLuc"),,)
            Call flDic.LoadDropList(drNoiLamViecThaoTacBangTay, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ThaoTacBangTay"),,)
            Call flDic.LoadDropList(drNoiLamViecDung2Tay, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DungHaiTay"),,)

            ''Hình thức tuyển dụng
            Call flDic.LoadDropList(drHinhThucTuyenDung, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucTuyenDung"))
            UserAdmin.SelectedValue = Me.UserInfo.Username
            If Request.UrlReferrer IsNot Nothing Then
                ViewState("UrlReferrer") = Request.UrlReferrer.ToString()
            End If
        End Sub
        Private Sub BackEnd()
            If ViewState("UrlReferrer") IsNot Nothing Then
                Response.Redirect(ViewState("UrlReferrer"), True)
            End If
        End Sub
        Private Sub LoadValue()
            obj = objController.CMS_JobUser_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                HF_ID.Value = obj.ID
                HF_CreatedDate.Value = flReg.ReadDate(obj.CreatedDate, False)
                Title.Text = flReg.RemoveScript(obj.Title, False)
                LevelDesired.SelectedValue = obj.LevelDesired
                If (LevelDesired.SelectedItem.Text.ToLower() = "khác") Then
                    pnlLevelDesiredOther.Visible = True
                Else
                    pnlLevelDesiredOther.Visible = False
                End If
                TinhTP.SelectedValue = obj.TinhTP
                Call flDic.LoadRegionalXP(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
                HidQuanHuyen.Value = obj.QuanHuyen
                'If HidTinhTP.Value.Contains(",") Then
                '    chkMultiple.Checked = True
                '    divSelectQH.Attributes.Add("class", "none")
                '    TinhTPMulti.CssClass = "selectpicker TinhTP validate[required]"
                '    TinhTP.Visible = False
                'Else
                '    TinhTPMulti.CssClass = "none selectpicker TinhTP validate[required]"
                '    TinhTP.SelectedValue = HidTinhTP.Value
                '    chkMultiple.Checked = False
                '    HidQuanHuyen.Value = obj.QuanHuyen
                'End If

                'HidTinhTP2.Value = obj.TinhTP2
                'If HidTinhTP2.Value.Contains(",") Then
                '    chkMultiple2.Checked = True
                '    divSelectQH2.Attributes.Add("class", "none")
                '    TinhTPMulti2.CssClass = "selectpicker TinhTP2 validate[required]"
                'Else
                '    TinhTPMulti2.CssClass = "none selectpicker TinhTP2 validate[required]"
                '    TinhTP2.SelectedValue = HidTinhTP2.Value
                '    chkMultiple2.Checked = False
                '    Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen2, TinhTP2.SelectedValue, "")
                '    'HidQuanHuyen2.Value = obj.QuanHuyen2
                'End If

                UserAdmin.SelectedValue = obj.UserAdmin
                LoadUserAdmin(obj.UserAdmin)
                Experience_ID.SelectedValue = obj.Experience_ID
                Salary_ID.SelectedValue = obj.Salary_ID
                If Salary_ID.SelectedValue <> "- - - Chọn - - -" Then
                    pnlSalary_Option.Visible = True
                End If
                StartDate.Text = flReg.ReadDate(obj.StartDate, False)
                EndDate.Text = flReg.ReadDate(obj.EndDate, False)

                IsApproval.Checked = obj.IsApproval
                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo:    " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If

                GetSelectedItems(obj.JobUser_ID)
                Call LoadRefer()
                'Career_IDSelectedIndexChanged(Nothing, Nothing)
                SanSangLamViecSelectedIndexChanged(Nothing, Nothing)

                If Me.UserInfo.Username <> obj.CreatedUser Then cmdDelete.Visible = False
            Else
                cmdDelete.Visible = False
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)

        End Sub
        Private Sub LoadRefer()
            Dim arr As ArrayList = objController.CMS_JobUserRefer_List_ByJobUserID(Me.PortalId, ItemID.Value)
            Dim obRe1 As CMS_JobUserReferInfo
            Dim obRe2 As CMS_JobUserReferInfo
            Dim obRe3 As CMS_JobUserReferInfo
            If arr.Count >= 3 Then
                obRe3 = arr(2)
            End If
            If arr.Count >= 2 Then
                obRe2 = arr(1)
            End If
            If arr.Count >= 1 Then
                obRe1 = arr(0)
            End If
            If IsNothing(obRe1) = False Then
                HF_NTK1_ID.Value = obRe1.ID
                NTK1_HoTen.Text = obRe1.HoTen
                NTK1_ChucVu.Text = obRe1.ChucVu
                NTK1_NoiCongTac.Text = obRe1.NoiCongTac
                NTK1_SoDienThoai.Text = obRe1.SoDienThoai
                NTK1_Email.Text = obRe1.Email
                NTK1_MoiQuanHe.Text = obRe1.MoiQuanHe
            End If
            If IsNothing(obRe2) = False Then
                HF_NTK2_ID.Value = obRe2.ID
                NTK2_HoTen.Text = obRe2.HoTen
                NTK2_ChucVu.Text = obRe2.ChucVu
                NTK2_NoiCongTac.Text = obRe2.NoiCongTac
                NTK2_SoDienThoai.Text = obRe2.SoDienThoai
                NTK2_Email.Text = obRe2.Email
                NTK2_MoiQuanHe.Text = obRe2.MoiQuanHe
            End If
            If IsNothing(obRe3) = False Then
                HF_NTK3_ID.Value = obRe3.ID
                NTK3_HoTen.Text = obRe3.HoTen
                NTK3_ChucVu.Text = obRe3.ChucVu
                NTK3_NoiCongTac.Text = obRe3.NoiCongTac
                NTK3_SoDienThoai.Text = obRe3.SoDienThoai
                NTK3_Email.Text = obRe3.Email
                NTK3_MoiQuanHe.Text = obRe3.MoiQuanHe
            End If
        End Sub
        Private Sub GetSelectedItems(mapId As String)
            objExtra = objController.CMS_JobUserExtra_Get(Me.PortalId, mapId)
            If IsNothing(objExtra) = False Then
                TinhTP2.SelectedValue = objExtra.TinhTP2
                Call flDic.LoadRegionalXP(Me.PortalId, QuanHuyen2, TinhTP2.SelectedValue)
                HidQuanHuyen2.Value = objExtra.QuanHuyen2
                Description.Text = objExtra.Description
                IsLamCa.Checked = objExtra.IsLamCa
                IsDiCongTac.Checked = objExtra.IsDiCongTac
                IsDiBietPhai.Checked = objExtra.IsDiBietPhai
                chkHoaHong.Checked = objExtra.IsHoaHong
                txtPhucLoiKhac.Text = objExtra.PhucLoiKhacText
                TextSanSangLamViec.Text = objExtra.TextSanSangLamViec
                Salary_Option.SelectedValue = objExtra.Salary_Option
                Salary_Text.Text = objExtra.Salary_Text
                Call LoadSalaryId()
                HidLoaiHinhDoanhNghiep.Value = objExtra.LoaiHinhDoanhNghiep
                HidHoTroAn.Value = objExtra.HoTroAn
                HidPhucLoi.Value = objExtra.PhucLoi
                HidXeDuaDon.Value = objExtra.XeDuaDon
                HidPhucLoiKhac.Value = objExtra.PhucLoiKhac
                HidNoiLamViec.Value = objExtra.NoiLamViec
                HidNoiLamViecNgheNoi.Value = objExtra.NoiLamViecNgheNoi
                HidNoiLamViecTrongLuong.Value = objExtra.NoiLamViecTrongLuong
                HidNoiLamViecDiLai.Value = objExtra.NoiLamViecDiLai
                HidNoiLamViecThiLuc.Value = objExtra.NoiLamViecThiLuc
                HidNoiLamViecThaoTacBangTay.Value = objExtra.NoiLamViecThaoTacBangTay
                HidNoiLamViecDung2Tay.Value = objExtra.NoiLamViecDung2Tay
                HidHinhThucTuyenDung.Value = objExtra.HinhThucTuyenDung
                HidContractType.Value = objExtra.ContractType_Option
                HidTypeOf.Value = objExtra.TypeOf_ID
                HidHinhThucTuyenDung.Value = objExtra.HinhThucTuyenDung
                HidMucDich.Value = objExtra.MucDich
                Career_ID.SelectedValue = objExtra.Career_ID
                drSanSangLamViec.SelectedValue = objExtra.SanSangLamViec
                txtMaNgheCap1.Text = objExtra.MaNgheCap1
                txtMaNgheCap2.Text = objExtra.MaNgheCap2
                txtMaNgheCap3.Text = objExtra.MaNgheCap3
                txtMaNgheCap4.Text = objExtra.MaNgheCap4
                LevelDesiredOther.Text = objExtra.LevelDesiredOther
                chkThoaThuan.Checked = objExtra.IsThoaThuan
            End If
        End Sub
        Private Sub SendMail(email As String)
            Dim subject As String = "VL-" & flDic.RegionalTP_Name(Me.PortalId, TinhTP.SelectedValue) & ": Ứng viên phù hợp."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào bạn</p>"
            body += "<p>VL-" & flDic.RegionalTP_Name(Me.PortalId, TinhTP.SelectedValue) & " giới thiệu đến bạn những ứng viên mới phù hợp với nhu cầu tuyển dụng của quý vị.</p>"
            body += "<p>Ứng viên: <b>" & flReg.GetUserName(UserAdmin.SelectedValue) & "</b></p>"
            body += "<p>Hồ sơ tìm việc: <a href='" & flReg.UrlAlias & flCheck.GetLinkProfile(Title.Text, ItemID.Value) & "' title='" & Title.Text.Trim & "'>"
            body += Title.Text.Trim & "</a></p>"
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị VL-" & flDic.RegionalTP_Name(Me.PortalId, TinhTP.SelectedValue) & "</div>"
            flDnn.DNN_SendMail(email, subject, body)
        End Sub
        Private Sub SendMailAuto()
            Try
                arrTemp = objController.CMS_JobUser_List_SendMail(Me.PortalId, Career_ID.SelectedValue, 1)
                Dim sMail As String = ""
                For Each Cr As CMS_JobUserInfo In arrTemp
                    sMail += Cr.UserAdmin & ";"
                Next
                Call SendMail(sMail)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub LoadUserAdmin(userName As String)
            Dim user = flDnn.CMSUserPortal_Get_By_User("", userName, "", Me.PortalId)
            If IsNothing(user) = False Then
                DisplayName.Text = user.DisplayName
                CCCD.Text = user.CMND
                Email.Text = user.Email
                SDT.Text = user.Telephone
                NgaySinh.Text = flReg.ReadDate(user.DateOfBirth, False)
                GioiTinh.Text = IIf(user.Gender = 1, "Nữ", "Nam")
                DiaChi1.Text = flDic.Address(PortalId, user.Address, "", user.WardID, user.DistrictID, user.ProvinID)
            End If
            Dim userExtr = flDnn.CMSUserExtra_Get_By_User("", userName, Me.PortalId)
            If IsNothing(userExtr) = False Then
                BHXH.Text = userExtr.BHXH
                DanToc.Text = userExtr.DanToc
                TonGiao.Text = userExtr.TonGiao
                DiaChi2.Text = flDic.Address(PortalId, userExtr.Address2, "", userExtr.WardID2, userExtr.DistrictID2, userExtr.ProvinID2)
            End If
        End Sub

        Private Sub JobHistory(_hisName As String)
            Try
                Dim item = New CMS_JobHistoryInfo
                item.JobUserID = ItemID.Value
                item.HisDate = Now
                item.UserName = UserInfo.Username
                item.HisName = _hisName
                objController.CMS_JobHistory_Add(Me.PortalId, item)
            Catch ex As Exception

            End Try
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If flReg.WriteDate(EndDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Ngày đăng phải diễn ra trước ngày hết hạn!', 'Thông báo', false);", True)
                    Exit Sub
                End If
                obj = New CMS_JobUserInfo
                obj.Title = flReg.RemoveScript(Title.Text.Trim)
                obj.LevelDesired = LevelDesired.SelectedValue

                'If chkMultiple.Checked = False Then
                '    obj.TinhTP = TinhTP.SelectedValue
                '    obj.QuanHuyen = HidQuanHuyen.Value & ""
                'Else
                '    obj.TinhTP = HidTinhTP.Value & ""
                'End If
                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = HidQuanHuyen.Value

                obj.Experience_ID = Experience_ID.SelectedValue
                obj.Salary_ID = Salary_ID.SelectedValue

                obj.UserAdmin = UserInfo.Username
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)

                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull

                obj.IsApproval = False
                obj.ApprovalUser = ""
                obj.ApprovalDate = flReg.DateNull
                obj.PortalID = Me.PortalId

                If ItemID.Value <> "" Then
                    obj.JobUser_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = UserInfo.Username
                    obj.UpdatedDate = Now
                    objController.CMS_JobUser_Update(Me.PortalId, obj)
                    Call JobHistory("Cập nhật thông tin hồ sơ")
                Else 'Update
                    obj.JobUser_ID = flReg.GenKey()
                    obj.CreatedDate = Now
                    obj.CreatedUser = UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull
                    objController.CMS_JobUser_Add(Me.PortalId, obj)
                    Call JobHistory("Thêm mới hồ sơ")
                End If
                Call SaveSelectedItems(obj.JobUser_ID)
                Call SaveRefer()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã cập nhật thông tin thành công!', 'Thông báo', false);", True)
                Call SendMailAuto()
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub SaveRefer()
            Dim objData1 = New CMS_JobUserReferInfo
            objData1.ID = HF_NTK1_ID.Value
            objData1.JobUserID = ItemID.Value
            objData1.HoTen = NTK1_HoTen.Text
            objData1.ChucVu = NTK1_ChucVu.Text
            objData1.NoiCongTac = NTK1_NoiCongTac.Text
            objData1.SoDienThoai = NTK1_SoDienThoai.Text
            objData1.Email = NTK1_Email.Text
            objData1.MoiQuanHe = NTK1_MoiQuanHe.Text

            If HF_NTK1_ID.Value > 0 Then
                objController.CMS_JobUserRefer_Update(Me.PortalId, objData1)
            Else

                objController.CMS_JobUserRefer_Add(Me.PortalId, objData1)
            End If
            Dim objData2 = New CMS_JobUserReferInfo
            objData2.ID = HF_NTK2_ID.Value
            objData2.JobUserID = ItemID.Value
            objData2.HoTen = NTK2_HoTen.Text
            objData2.ChucVu = NTK2_ChucVu.Text
            objData2.NoiCongTac = NTK2_NoiCongTac.Text
            objData2.SoDienThoai = NTK2_SoDienThoai.Text
            objData2.Email = NTK2_Email.Text
            objData2.MoiQuanHe = NTK2_MoiQuanHe.Text
            If HF_NTK2_ID.Value > 0 Then
                objController.CMS_JobUserRefer_Update(Me.PortalId, objData2)
            Else

                objController.CMS_JobUserRefer_Add(Me.PortalId, objData2)
            End If
            Dim objData3 = New CMS_JobUserReferInfo
            objData3.ID = HF_NTK3_ID.Value
            objData3.JobUserID = ItemID.Value
            objData3.HoTen = NTK3_HoTen.Text
            objData3.ChucVu = NTK3_ChucVu.Text
            objData3.NoiCongTac = NTK3_NoiCongTac.Text
            objData3.SoDienThoai = NTK3_SoDienThoai.Text
            objData3.Email = NTK3_Email.Text
            objData3.MoiQuanHe = NTK3_MoiQuanHe.Text
            If HF_NTK3_ID.Value > 0 Then
                objController.CMS_JobUserRefer_Update(Me.PortalId, objData3)
            Else

                objController.CMS_JobUserRefer_Add(Me.PortalId, objData3)
            End If
        End Sub
        Private Sub SaveSelectedItems(JobUser_ID As String)
            Dim jobUserExtra = New CMS_JobUserExtraInfo
            jobUserExtra.JobUser_ID = JobUser_ID
            'If chkMultiple2.Checked = False Then
            '    jobUserExtra.TinhTP2 = TinhTP2.SelectedValue
            '    jobUserExtra.QuanHuyen2 = HidQuanHuyen2.Value & ""
            'Else
            '    jobUserExtra.TinhTP2 = HidTinhTP2.Value & ""
            'End If
            jobUserExtra.TinhTP2 = TinhTP2.SelectedValue
            jobUserExtra.QuanHuyen2 = HidQuanHuyen2.Value
            jobUserExtra.Description = Description.Text
            jobUserExtra.IsLamCa = IsLamCa.Checked
            jobUserExtra.IsDiCongTac = IsDiCongTac.Checked
            jobUserExtra.IsDiBietPhai = IsDiBietPhai.Checked
            jobUserExtra.IsHoaHong = chkHoaHong.Checked
            jobUserExtra.PhucLoiKhacText = txtPhucLoiKhac.Text
            jobUserExtra.TextSanSangLamViec = TextSanSangLamViec.Text
            jobUserExtra.Salary_Option = Salary_Option.SelectedValue
            jobUserExtra.Salary_Text = Salary_Text.Text
            jobUserExtra.LoaiHinhDoanhNghiep = HidLoaiHinhDoanhNghiep.Value
            jobUserExtra.HoTroAn = HidHoTroAn.Value
            jobUserExtra.PhucLoi = HidPhucLoi.Value
            jobUserExtra.XeDuaDon = HidXeDuaDon.Value
            jobUserExtra.PhucLoiKhac = HidPhucLoiKhac.Value
            jobUserExtra.NoiLamViec = HidNoiLamViec.Value
            jobUserExtra.NoiLamViecNgheNoi = HidNoiLamViecNgheNoi.Value
            jobUserExtra.NoiLamViecTrongLuong = HidNoiLamViecTrongLuong.Value
            jobUserExtra.NoiLamViecDiLai = HidNoiLamViecDiLai.Value
            jobUserExtra.NoiLamViecThiLuc = HidNoiLamViecThiLuc.Value
            jobUserExtra.NoiLamViecThaoTacBangTay = HidNoiLamViecThaoTacBangTay.Value
            jobUserExtra.NoiLamViecDung2Tay = HidNoiLamViecDung2Tay.Value
            jobUserExtra.HinhThucTuyenDung = HidHinhThucTuyenDung.Value
            jobUserExtra.ContractType_Option = HidContractType.Value
            jobUserExtra.TypeOf_ID = HidTypeOf.Value
            jobUserExtra.HinhThucTuyenDung = HidHinhThucTuyenDung.Value
            jobUserExtra.MucDich = HidMucDich.Value
            jobUserExtra.Career_ID = Career_ID.SelectedValue
            jobUserExtra.SanSangLamViec = drSanSangLamViec.SelectedValue
            jobUserExtra.MaNgheCap1 = txtMaNgheCap1.Text
            jobUserExtra.MaNgheCap2 = txtMaNgheCap2.Text
            jobUserExtra.MaNgheCap3 = txtMaNgheCap3.Text
            jobUserExtra.MaNgheCap4 = txtMaNgheCap4.Text
            jobUserExtra.LevelDesiredOther = LevelDesiredOther.Text
            jobUserExtra.IsThoaThuan = chkThoaThuan.Checked
            objController.CMS_JobUserExtra_Add(Me.PortalId, jobUserExtra)
        End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_JobUser_Delete(Me.PortalId, ItemID.Value)
                Call BackEnd()
            Catch exc As SqlClient.SqlException
                If exc.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, exc.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Protected Sub UserAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserAdmin.SelectedIndexChanged
            'imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(UserAdmin.SelectedValue, Me.PortalId) & "?w=120"" alt=""Ảnh đại diện"" />"
            LoadUserAdmin(UserAdmin.SelectedValue)
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "")
        End Sub

        Private Sub TinhTP2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP2.SelectedIndexChanged
            Call flDic.LoadRegionalQH(Me.PortalId, QuanHuyen2, TinhTP2.SelectedValue, "")
        End Sub
        Private Sub chkMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiple.CheckedChanged
            If chkMultiple.Checked Then
                TinhTP.Visible = False
                TinhTPMulti.CssClass = "selectpicker TinhTP validate[required]"
                divSelectQH.Attributes.Add("class", "none")
            Else
                TinhTP.Visible = True
                TinhTPMulti.CssClass = "none selectpicker TinhTP validate[required]"
                divSelectQH.Attributes.Remove("class")
                divSelectQH.Attributes.Add("class", "col-md-7 divQuanHuyen")
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub

        Private Sub chkMultiple2_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiple2.CheckedChanged
            If chkMultiple2.Checked Then
                TinhTP2.Visible = False
                TinhTPMulti2.CssClass = "selectpicker TinhTP validate[required]"
            Else
                TinhTP2.Visible = True
                TinhTPMulti2.CssClass = "none selectpicker TinhTP validate[required]"
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub

        Public Sub SanSangLamViecSelectedIndexChanged(sender As Object, e As EventArgs) Handles drSanSangLamViec.SelectedIndexChanged
            'If (Salary_ID.SelectedItem.Text.ToLower() = "7ff812b5-2a2f-4857-8de7-1325a91745e3") Then
            If (drSanSangLamViec.SelectedItem.Text.ToLower() = "làm việc sau") Then
                pnlSanSangLamViec.Visible = True
            Else
                pnlSanSangLamViec.Visible = False
            End If
        End Sub

        Protected Sub btnXoa1_Click(sender As Object, e As EventArgs)
            Try
                objController.CMS_JobUserRefer_Delete(Me.PortalId, HF_NTK1_ID.Value)
                Call LoadValue()
            Catch ex As Exception
            End Try
        End Sub

        Protected Sub btnXoa2_Click(sender As Object, e As EventArgs)
            Try
                objController.CMS_JobUserRefer_Delete(Me.PortalId, HF_NTK2_ID.Value)
                Call LoadValue()
            Catch ex As Exception

            End Try
        End Sub

        Protected Sub btnXoa3_Click(sender As Object, e As EventArgs)
            Try
                objController.CMS_JobUserRefer_Delete(Me.PortalId, HF_NTK3_ID.Value)
                Call LoadValue()
            Catch ex As Exception

            End Try
        End Sub
        Public Sub Career_IDSelectedIndexChanged(sender As Object, e As EventArgs) Handles Career_ID.SelectedIndexChanged
            Try
                txtMaNgheCap1.Text = ""
                txtMaNgheCap2.Text = ""
                txtMaNgheCap3.Text = ""
                txtMaNgheCap4.Text = ""
                Dim arrayList As ArrayList = flCache.GetCache("CMS_NgheCongViec_List_" & PortalId)
                Dim objCareer As List(Of CMS_NgheCongViecInfo) = arrayList.Cast(Of CMS_NgheCongViecInfo).ToList()
                Dim parents = flFunction.GetAllParents(Career_ID.SelectedValue, objCareer)
                Select Case (parents.Count)
                    Case 1
                        txtMaNgheCap1.Text = parents(0).Item1.Career_Name
                    Case 2
                        txtMaNgheCap1.Text = parents(1).Item1.Career_Name
                        txtMaNgheCap2.Text = parents(0).Item1.Career_Name
                    Case 3
                        txtMaNgheCap1.Text = parents(2).Item1.Career_Name
                        txtMaNgheCap2.Text = parents(1).Item1.Career_Name
                        txtMaNgheCap3.Text = parents(0).Item1.Career_Name
                    Case 4
                        txtMaNgheCap1.Text = parents(3).Item1.Career_Name
                        txtMaNgheCap2.Text = parents(2).Item1.Career_Name
                        txtMaNgheCap3.Text = parents(1).Item1.Career_Name
                        txtMaNgheCap4.Text = parents(0).Item1.Career_Name
                End Select
            Catch ex As Exception

            End Try
        End Sub

        Public Sub LevelDesiredSelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelDesired.SelectedIndexChanged
            If (LevelDesired.SelectedItem.Text.ToLower() = "khác") Then
                pnlLevelDesiredOther.Visible = True
            Else
                pnlLevelDesiredOther.Visible = False
            End If
        End Sub
        Public Sub SalaryIDSelectedIndexChanged(sender As Object, e As EventArgs) Handles Salary_ID.SelectedIndexChanged
            'If (Salary_ID.SelectedItem.Text.ToLower() = "7ff812b5-2a2f-4857-8de7-1325a91745e3") Then
            Call LoadSalaryId()
        End Sub
        Private Sub LoadSalaryId()
            If (Salary_ID.SelectedItem.Text.ToLower() = "lương tháng") Then
                pnlSalary_Option.Visible = True
                pnlSalary_Option_Choose.Visible = True
                pnlSalary_Input_Choose.Visible = False
            ElseIf ("lương ngày,lương giờ".Split(",").Contains(Salary_ID.SelectedItem.Text.ToLower())) Then
                pnlSalary_Option.Visible = True
                pnlSalary_Option_Choose.Visible = False
                pnlSalary_Input_Choose.Visible = True
                Salary_Text_DVT.Text = "<span class='ms'>đồng/ngày</span>"
                If Salary_ID.SelectedItem.Text.ToLower() = "lương giờ" Then
                    Salary_Text_DVT.Text = "<span class='ms'>đồng/giờ</span>"
                End If
            Else
                pnlSalary_Option.Visible = False
            End If
        End Sub
    End Class



End Namespace
