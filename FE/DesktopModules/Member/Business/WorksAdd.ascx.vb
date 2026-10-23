Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports GemBox.Document

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim objExtend As New CMS_WorkExtendInfo
        Dim obj As New CMS_WorkInfo
        Dim str() As String
        Dim buInfo As New CMS_BusinessInfo
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then

                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub SendMail(email As String, buID As String)
            Dim subject As String = "VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & ": Việc làm phù hợp."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào bạn</p>"
            body += "<p>VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & " giới thiệu đến bạn những việc làm mới từ các nhà tuyển dụng hàng đầu</p>"
            body += "<p>Doanh nghiệp: <b><a href='" & flReg.UrlAlias & flCheck.GetHomeLinkBusiness(buID) & "'>" & Business_Name.Text & "</a></b></p>"
            body += "<p>Việc làm mới: <a href='" & flReg.UrlAlias & flCheck.GetHomeLinkWork(Title.Text.Trim, ItemID.Value) & "' title='" & Title.Text.Trim & "'>"
            body += Title.Text.Trim & "</a></p>"
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & "</div>"
            flDnn.DNN_SendMail(email, subject, body)
        End Sub
        Private Sub LoadBus()
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                TaxCode.Text = buInfo.TaxCode
                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                ContactAddress.Text = flReg.RemoveScript(buInfo.Address, False)
                ContactUser.Text = flReg.RemoveScript(buInfo.ContactUser, False)
                ContactMobile.Text = buInfo.ContactMobile
                ContactEmail.Text = buInfo.ContactEmail
                TinhTP.SelectedValue = buInfo.TinhTP
                Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "")
            End If
        End Sub
        Private Sub SendMailAuto(buID As String)
            Try
                arrTemp = objController.CMS_JobUser_List_SendMail(Me.PortalId, CareerID.Value, 0)
                Dim sMail As String = ""
                For Each Cr As CMS_JobUserInfo In arrTemp
                    For Each Ck As DnnInfo In flDnn.DNN_User_Get(Me.PortalId, Cr.UserAdmin)
                        sMail += Ck.Email & ";"
                    Next
                Next
                Call SendMail(sMail, buID)
            Catch ex As Exception
            End Try
        End Sub
        Private Function GetBusiness_ID() As String
            Dim obj As New CMS_BusinessInfo
            obj.Business_ID = flReg.GenKey()
            obj.Business_Vn = flReg.RemoveScript(Business_Name.Text.Trim & "")
            obj.Business_En = ""
            obj.Business_Sort = ""
            obj.TinhTP = flReg.WriteNumber(TinhTP.SelectedValue)
            obj.Logo = ""
            obj.Description = ContactDes.Text & ""
            obj.TaxCode = TaxCode.Text & ""
            obj.Mobile = ContactMobile.Text & ""
            obj.Fax = ""
            obj.Website = ""
            obj.Email = ContactEmail.Text & ""
            obj.Address = ContactAddress.Text & ""
            obj.Scale = ""
            obj.ContactUser = ContactUser.Text & ""
            obj.ContactMobile = ContactMobile.Text & ""
            obj.ContactEmail = ContactEmail.Text & ""
            obj.IsApproval = True
            obj.ApprovalUser = Me.UserInfo.Username
            obj.ApprovalDate = Now
            obj.PortalId = Me.PortalId
            obj.CreatedDate = Now
            obj.CreatedUser = ""
            obj.UpdatedUser = Me.UserInfo.Username
            obj.UpdatedDate = Now
            Return objController.CMS_Business_Check(Me.PortalId, obj)
        End Function
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            ItemID.Value = Request.Item("itemid")
            hidBusinessID.Value = Request.Item("bid")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "", "")
            'Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTPMulti, "", "")
            Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            Call flFunction.LoadGender(Gender_ID)
            Call flDic.LoadEducation(Me.PortalId, Level_ID)
            Call flDic.LoadDropList(LevelDesired, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ChucVuMongMuon"))
            Call flDic.LoadDropList(MongMuonDN, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_MongMuonDN"))
            'Call flDic.LoadPosition(Me.PortalId, LevelDesired)
            Call flFunction.LoadTypeOf(Me.PortalId, TypeOf_ID)
            Call flFunction.LoadJobPlaceID(Me.PortalId, JobPlace_ID)
            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "")
            'Call flFunction.LoadCareer(Me.PortalId, MaNghe_Id, "")
            Call flFunction.LoadNgheCongViec(Me.PortalId, MaNghe_Id, "")
            Call flDic.LoadEducation(Me.PortalId, TrinhDoHocVan, , False)
            Call flWork.LoadSpecialize(Me.PortalId, TrinhDoChuyenMon)
            Call flDic.LoadKhaNangSuDung(TrinhDoNgoaiNgu1)
            Call flDic.LoadKhaNangSuDung(TrinhDoNgoaiNgu2)
            Call flDic.LoadKhaNangSuDung(TrinhDoTinHoc_KhaNang)
            Call flDic.LoadKhaNangSuDung(TrinhDoTinHoc_Khac_KhaNang)
            Call flDic.LoadDropList(KyNangMem, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KyNangMem"))
            Call flDic.LoadDropList(YeuCauKinhNghiem, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KinhNghiem"), False, "Chưa có kinh nghiệm")
            Call flDic.LoadDropList(ContractType_Option, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_LoaiHopDong"))
            Call flDic.LoadDropList(HinhThucLamViec, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucLamViec"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(MucDich_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_MucDichLV"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(KieuLuong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KieuLuong"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(Salary_Option, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_MucLuongLV"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(HoTroAn, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HoTroAn"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(PhucLoi, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_PhucLoi"))
            Call flDic.LoadDropList(XeDuaDon, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_XeDuaDon"))
            Call flDic.LoadDropList(HoTro, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HoTro"))
            Call flDic.LoadDropList(NoiLamViec, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NoiLamViec"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecTrongLuong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_TrongLuongNang"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecDiLai, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DungDiLai"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecNgheNoi, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NgheNoi"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecThiLuc, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ThiLuc"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecThaoTacBangTay, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_ThaoTacBangTay"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(NoiLamViecDung2Tay, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DungHaiTay"),, "- - - Chọn - - -")
            Call flDic.LoadDropList(DoiTuongUuTien, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DoiTuongUuTien"))
            Call flDic.LoadDropList(HinhThucTuyenDung, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucTuyenDung"))
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
            Call LoadBus()
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub LoadExtend()
            objExtend = objController.CMS_WorkExtend_Get(Me.PortalId, ItemID.Value)
            If objExtend IsNot Nothing Then

                JobPlace_ID.SelectedValue = objExtend.JobPlace_ID
                Gender_ID.SelectedValue = objExtend.Gender_ID

                MaNghe_Id.SelectedValue = objExtend.MaNghe_Id
                MaNgheCap1.Text = objExtend.MaNgheCap1
                MaNgheCap2.Text = objExtend.MaNgheCap2
                MaNgheCap3.Text = objExtend.MaNgheCap3
                MaNgheCap4.Text = objExtend.MaNgheCap4
                LevelDesired.SelectedValue = objExtend.LevelDesired
                If (LevelDesired.SelectedItem.Text.ToLower() = "khác") Then
                    pnlLevelDesiredOther.Visible = True
                Else
                    pnlLevelDesiredOther.Visible = False
                End If
                Requirement.Text = objExtend.Requirement
                RequirementsProfile.Text = objExtend.RequirementsProfile
                TrinhDoHocVan.SelectedValue = objExtend.TrinhDoHocVan
                TrinhDoChuyenMon.SelectedValue = objExtend.TrinhDoChuyenMon
                ChuyenNganhDaoTao.Text = objExtend.ChuyenNganhDaoTao
                TrinhDoKhac.Text = objExtend.TrinhDoKhac
                TrinhDoKhac2.Text = objExtend.TrinhDoKhac2
                KyNangNghe.Text = objExtend.KyNangNghe
                KyNangNgheBac.Text = objExtend.KyNangNgheBac
                NgoaiNgu1.Text = objExtend.NgoaiNgu1
                NgoaiNgu1ChungChi.Text = objExtend.NgoaiNgu1ChungChi
                TrinhDoNgoaiNgu1.SelectedValue = objExtend.TrinhDoNgoaiNgu1
                NgoaiNgu2.Text = objExtend.NgoaiNgu2
                NgoaiNgu2ChungChi.Text = objExtend.NgoaiNgu1ChungChi2
                TrinhDoNgoaiNgu2.SelectedValue = objExtend.TrinhDoNgoaiNgu2
                TrinhDoTinHoc.Text = objExtend.TrinhDoTinHoc
                TrinhDoTinHoc_KhaNang.SelectedValue = objExtend.TrinhDoTinHoc_KhaNang
                TrinhDoTinHoc_Khac.Text = objExtend.TrinhDoTinHoc_Khac
                TrinhDoTinHoc_Khac_KhaNang.SelectedValue = objExtend.TrinhDoTinHoc_Khac_KhaNang
                HidKyNangMem.Value = objExtend.KyNangMem
                YeuCauKinhNghiem.SelectedValue = objExtend.YeuCauKinhNghiem
                ContractType_Option.SelectedValue = objExtend.ContractType_Option
                IsLamCa.Checked = objExtend.IsLamCa
                IsDiCongTac.Checked = objExtend.IsDiCongTac
                IsDiBietPhai.Checked = objExtend.IsDiBietPhai
                HinhThucLamViec.SelectedValue = objExtend.HinhThucLamViec
                MucDich_ID.SelectedValue = objExtend.MucDich_ID
                KieuLuong.SelectedValue = objExtend.KieuLuong
                Salary_Option.SelectedValue = objExtend.Salary_Option
                Salary_Text.Text = objExtend.Salary_Text
                Call LoadSalaryId()
                IsHoaHong.Checked = objExtend.IsHoaHong
                HinhThucNop.Text = objExtend.HinhThucNop
                HoTroAn.SelectedValue = objExtend.HoTroAn
                HidPhucLoi.Value = objExtend.PhucLoi
                HidXeDuaDon.Value = objExtend.XeDuaDon
                HidHoTro.Value = objExtend.HoTro
                PhucLoiKhac.Text = objExtend.PhucLoiKhac
                NoiLamViec.SelectedValue = objExtend.NoiLamViec
                NoiLamViecTrongLuong.SelectedValue = objExtend.NoiLamViecTrongLuong
                NoiLamViecDiLai.SelectedValue = objExtend.NoiLamViecDiLai
                NoiLamViecNgheNoi.SelectedValue = objExtend.NoiLamViecNgheNoi
                NoiLamViecThiLuc.SelectedValue = objExtend.NoiLamViecThiLuc
                NoiLamViecThaoTacBangTay.SelectedValue = objExtend.NoiLamViecThaoTacBangTay
                NoiLamViecDung2Tay.SelectedValue = objExtend.NoiLamViecDung2Tay
                HidDoiTuongUuTien.Value = objExtend.DoiTuongUuTien
                HidHinhThucTuyenDung.Value = objExtend.HinhThucTuyenDung
                ThoiHanTuyenDung.Text = flReg.ReadDate(objExtend.ThoiHanTuyenDung)
                LevelDesiredOther.Text = objExtend.LevelDesiredOther
                chkThoaThuan.Checked = objExtend.IsThoaThuan
                MongMuonDN.SelectedValue = objExtend.MongMuonDN
            End If
        End Sub
        Private Sub LoadValue()
            obj = objController.CMS_Work_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                HF_ID.Value = obj.ID
                hidBusinessID.Value = obj.Business_ID
                HidTinhTP.Value = obj.TinhTP
                TinhTP.SelectedValue = HidTinhTP.Value
                Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "")
                PhuongXa.SelectedValue = obj.PhuongXa
                IsApproval.Checked = obj.IsApproval
                IsHot.Checked = obj.IsHot
                IsFast.Checked = obj.IsFast
                IsUrgent.Checked = obj.IsUrgent
                IsGhim.Checked = obj.IsGhim
                StartDate.Text = flReg.ReadDate(obj.StartDate)
                EndDate.Text = flReg.ReadDate(obj.EndDate)
                Title.Text = obj.Title
                Quantity.Text = obj.Quantity
                ExpiredDate.Text = flReg.ReadDate(obj.ExpiredDate)
                Salary_ID.SelectedValue = obj.Salary_ID
                Experience_ID.SelectedValue = obj.Experience_ID
                SubmissionSend.Text = obj.SubmissionSend
                obj.Level_ID = Level_ID.SelectedValue
                Ages.Text = obj.Ages
                TypeOf_ID.SelectedValue = obj.TypeOf_ID
                Career_ID.SelectedValue = obj.Career_ID
                WorkTime.Text = obj.WorkTime
                Description.Text = obj.Description
                Benefit.Text = obj.Benefit
                txtLat.Text = obj.Lat
                txtLng.Text = obj.Lng
                If String.IsNullOrEmpty(obj.ContactUser) = False Then

                    ContactUser.Text = obj.ContactUser
                    ContactMobile.Text = obj.ContactMobile
                    ContactEmail.Text = obj.ContactEmail
                End If

                litUpdate.Text = "<div Class=""cmsUpdate"">Ngày tạo:    " & flReg.ReadDate(obj.CreatedDate)
                    litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                    If obj.UpdatedUser <> "" Then
                        litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                        litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                    End If
                    If Me.UserInfo.Username <> obj.CreatedUser Then cmdDelete.Visible = False
                Else
                    cmdDelete.Visible = False
            End If
            Call LoadExtend()
            'If hidBusinessID.Value <> "" Then
            '    Dim objBID As CMS_BusinessInfo = objController.CMS_Business_Get(Me.PortalId, hidBusinessID.Value)
            '    If IsNothing(objBID) = False Then
            '        Business_Name.Text = flReg.RemoveScript(objBID.Business_Vn, False)
            '        ContactAddress.Text = objBID.Address
            '        TaxCode.Text = objBID.TaxCode
            '        ContactUser.Text = objBID.ContactUser
            '        ContactMobile.Text = objBID.ContactMobile
            '        ContactEmail.Text = objBID.ContactEmail
            '    End If
            'End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
        Private Sub SaveWorkCarrer()
            objController.CMS_WorkCareer_Delete_By_CMS_Work(Me.PortalId, ItemID.Value)
            str = CareerID.Value.Split(",")
            Dim wcInfo As New CMS_WorkCareerInfo
            For i As Integer = 0 To str.Length - 1
                If str(i) <> "" Then
                    wcInfo = New CMS_WorkCareerInfo
                    wcInfo.Career_ID = str(i)
                    wcInfo.Work_ID = ItemID.Value
                    objController.CMS_WorkCareer_Add(Me.PortalId, wcInfo)
                End If
            Next
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "", "")
        End Sub

        Private Sub cleartd()
            IsApproval.Checked = False
            IsHot.Checked = False
            IsFast.Checked = False
            IsUrgent.Checked = False
            IsGhim.Checked = False
            StartDate.Text = ""
            EndDate.Text = ""
            Title.Text = ""
            Quantity.Text = ""
            ExpiredDate.Text = ""
            TinhTP.SelectedValue = "0"
            HidTinhTP.Value = ""
            Salary_ID.SelectedValue = "0"
            Experience_ID.SelectedValue = "0"
            SubmissionSend.Text = ""
            Level_ID.SelectedValue = "0"
            JobPlace_ID.SelectedValue = "0"
            Gender_ID.SelectedValue = "0"
            Ages.Text = ""
            TypeOf_ID.SelectedValue = "0"
            Career_ID.SelectedValue = "0"
            WorkTime.Text = ""
            obj.Description = Description.Text & ""
            Benefit.Text = ""
            MaNghe_Id.SelectedValue = "0"
            MaNgheCap1.Text = ""
            MaNgheCap2.Text = ""
            MaNgheCap3.Text = ""
            MaNgheCap4.Text = ""
            LevelDesired.SelectedValue = "0"
            Requirement.Text = ""
            RequirementsProfile.Text = ""
            TrinhDoHocVan.SelectedValue = "0"
            TrinhDoChuyenMon.SelectedValue = "0"
            ChuyenNganhDaoTao.Text = ""
            TrinhDoKhac.Text = ""
            TrinhDoKhac2.Text = ""
            KyNangNghe.Text = ""
            KyNangNgheBac.Text = ""
            NgoaiNgu1.Text = ""
            NgoaiNgu1ChungChi.Text = ""
            TrinhDoNgoaiNgu1.SelectedValue = "0"
            NgoaiNgu2.Text = ""
            NgoaiNgu2ChungChi.Text = ""
            TrinhDoNgoaiNgu2.SelectedValue = "0"
            TrinhDoTinHoc.Text = ""
            TrinhDoTinHoc_KhaNang.SelectedValue = "0"
            TrinhDoTinHoc_Khac.Text = ""
            TrinhDoTinHoc_Khac_KhaNang.SelectedValue = "0"
            HidKyNangMem.Value = ""
            YeuCauKinhNghiem.SelectedValue = "0"
            ContractType_Option.SelectedValue = "0"
            IsLamCa.Checked = False
            IsDiCongTac.Checked = False
            IsDiBietPhai.Checked = False
            HinhThucLamViec.SelectedValue = "0"
            MucDich_ID.SelectedValue = "0"
            KieuLuong.SelectedValue = "0"
            Salary_Option.SelectedValue = "0"
            Salary_Text.Text = ""
            IsHoaHong.Checked = False
            HinhThucNop.Text = ""
            HoTroAn.SelectedValue = "0"
            HidPhucLoi.Value = ""
            HidXeDuaDon.Value = ""
            HidHoTro.Value = ""
            PhucLoiKhac.Text = ""
            NoiLamViec.SelectedValue = "0"
            NoiLamViecTrongLuong.SelectedValue = "0"
            NoiLamViecDiLai.SelectedValue = "0"
            NoiLamViecNgheNoi.SelectedValue = "0"
            NoiLamViecThiLuc.SelectedValue = "0"
            NoiLamViecThaoTacBangTay.SelectedValue = "0"
            NoiLamViecDung2Tay.SelectedValue = "0"
            HidDoiTuongUuTien.Value = ""
            HidHinhThucTuyenDung.Value = ""
            ThoiHanTuyenDung.Text = ""
            ItemID.Value = ""
            LevelDesiredOther.Text = ""
            chkThoaThuan.Checked = False
            MongMuonDN.SelectedValue = "0"
        End Sub
        Private Sub SaveWork()
            If flReg.WriteDate(EndDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Ngày hết hạn đăng phải lớn hơn hoặc bằng ngày bắt đầu!', 'Thông báo', false);", True)
                Exit Sub
            End If
            If flReg.WriteDate(ExpiredDate.Text, False) < flReg.WriteDate(EndDate.Text, False) Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Hạn nộp hồ sơ phải lớn hơn Đến hết ngày!', 'Thông báo', false);", True)
                Exit Sub
            End If
            obj = New CMS_WorkInfo
            obj.Business_ID = Business_ID.Value
            obj.IsApproval = flReg.ToBoolean(IsApproval.Checked)
            obj.IsHot = flReg.ToBoolean(IsHot.Checked)
            obj.IsFast = flReg.ToBoolean(IsFast.Checked)
            obj.IsUrgent = flReg.ToBoolean(IsUrgent.Checked)
            obj.IsGhim = flReg.ToBoolean(IsGhim.Checked)
            obj.StartDate = flReg.WriteDate(StartDate.Text)
            obj.EndDate = flReg.WriteDate(EndDate.Text)
            obj.Title = Title.Text & ""
            obj.Quantity = flReg.WriteNumber(Quantity.Text)
            obj.TinhTP = TinhTP.SelectedValue
            obj.QuanHuyen = 0
            obj.PhuongXa = PhuongXa.SelectedValue
            obj.Salary_ID = Salary_ID.SelectedValue
            obj.Experience_ID = Experience_ID.SelectedValue
            obj.SubmissionSend = SubmissionSend.Text & ""
            obj.Level_ID = Level_ID.SelectedValue
            obj.Ages = flReg.RemoveScript(Ages.Text)
            obj.TypeOf_ID = TypeOf_ID.SelectedValue
            obj.Career_ID = Career_ID.SelectedValue
            obj.WorkTime = WorkTime.Text & ""
            obj.Description = Description.Text & ""
            obj.Benefit = Benefit.Text & ""
            obj.LevelDesired_ID = ""
            obj.ExpiredDate = flReg.WriteDate(ThoiHanTuyenDung.Text, False)
            obj.Requirement = Requirement.Text & ""
            obj.RequirementsProfile = RequirementsProfile.Text & ""

            obj.HinhThucLamViec = HinhThucLamViec.SelectedValue

            obj.ContactUser = ContactUser.Text
            obj.ContactAddress = ContactAddress.Text
            obj.ContactMobile = ContactMobile.Text
            obj.ContactEmail = ContactEmail.Text

            obj.IsDelete = False
            obj.DeletedUser = ""
            obj.DeletedDate = flReg.DateNull

            ''''
            If ItemID.Value <> "" Then
                obj.Work_ID = ItemID.Value
                obj.CreatedDate = Now
                obj.CreatedUser = ""
                obj.UpdatedUser = Me.UserInfo.Username
                obj.UpdatedDate = Now
                objController.CMS_Work_Update(Me.PortalId, obj)
                flCache.RemoveCache("Work_" & ItemID.Value)
                flCache.RemoveCache("Work_False" & ItemID.Value)
                flCache.RemoveCache("Work_True" & ItemID.Value)
            Else 'Update
                ItemID.Value = flReg.GenKey()
                obj.Work_ID = ItemID.Value
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = flReg.DateNull
                objController.CMS_Work_Add(Me.PortalId, obj)
            End If
            Call objController.CMS_Work_Update_LatLng(Me.PortalId, ItemID.Value, txtLat.Text.Trim, txtLng.Text.Trim)
            Call SaveExtend()
            Call SaveWorkCarrer()
            Call SendMailAuto(obj.Business_ID)
        End Sub
        Private Sub SaveExtend()

            objExtend.Work_ID = ItemID.Value

            objExtend.Business_ID = obj.Business_ID
            objExtend.IsApproval = obj.IsApproval
            objExtend.IsHot = obj.IsHot
            objExtend.IsFast = obj.IsFast
            objExtend.IsUrgent = obj.IsUrgent
            objExtend.IsGhim = obj.IsGhim
            objExtend.StartDate = obj.StartDate
            objExtend.EndDate = obj.EndDate
            objExtend.Title = obj.Title
            objExtend.ExpiredDate = obj.ExpiredDate
            objExtend.TinhTP = obj.TinhTP
            objExtend.QuanHuyen = obj.QuanHuyen
            objExtend.Salary_ID = obj.Salary_ID
            objExtend.Experience_ID = obj.Experience_ID
            objExtend.SubmissionSend = obj.SubmissionSend
            objExtend.Level_ID = obj.Level_ID
            objExtend.Ages = obj.Ages
            objExtend.TypeOf_ID = obj.TypeOf_ID
            objExtend.Career_ID = obj.Career_ID
            objExtend.WorkTime = obj.WorkTime
            objExtend.Description = obj.Description
            objExtend.Benefit = obj.Benefit
            objExtend.Requirement = obj.Requirement
            objExtend.RequirementsProfile = obj.RequirementsProfile
            objExtend.HinhThucLamViec = obj.HinhThucLamViec


            objExtend.JobPlace_ID = JobPlace_ID.SelectedValue
            objExtend.Gender_ID = Gender_ID.SelectedValue
            objExtend.MaNghe_Id = MaNghe_Id.SelectedValue
            objExtend.MaNgheCap1 = MaNgheCap1.Text & ""
            objExtend.MaNgheCap2 = MaNgheCap2.Text & ""
            objExtend.MaNgheCap3 = MaNgheCap3.Text & ""
            objExtend.MaNgheCap4 = MaNgheCap4.Text & ""
            objExtend.LevelDesired = LevelDesired.SelectedValue
            objExtend.TrinhDoHocVan = TrinhDoHocVan.SelectedValue
            objExtend.TrinhDoChuyenMon = TrinhDoChuyenMon.SelectedValue
            objExtend.ChuyenNganhDaoTao = ChuyenNganhDaoTao.Text & ""
            objExtend.TrinhDoKhac = TrinhDoKhac.Text & ""
            objExtend.TrinhDoKhac2 = TrinhDoKhac2.Text & ""
            objExtend.KyNangNghe = KyNangNghe.Text & ""
            objExtend.KyNangNgheBac = KyNangNgheBac.Text & ""
            objExtend.NgoaiNgu1 = NgoaiNgu1.Text & ""
            objExtend.NgoaiNgu1ChungChi = NgoaiNgu1ChungChi.Text & ""
            objExtend.TrinhDoNgoaiNgu1 = TrinhDoNgoaiNgu1.SelectedValue
            objExtend.NgoaiNgu2 = NgoaiNgu2.Text & ""
            objExtend.NgoaiNgu1ChungChi2 = NgoaiNgu2ChungChi.Text & ""
            objExtend.TrinhDoNgoaiNgu2 = TrinhDoNgoaiNgu2.SelectedValue
            objExtend.TrinhDoTinHoc = TrinhDoTinHoc.Text & ""
            objExtend.TrinhDoTinHoc_KhaNang = TrinhDoTinHoc_KhaNang.SelectedValue
            objExtend.TrinhDoTinHoc_Khac = TrinhDoTinHoc_Khac.Text & ""
            objExtend.TrinhDoTinHoc_Khac_KhaNang = TrinhDoTinHoc_Khac_KhaNang.SelectedValue
            objExtend.KyNangMem = HidKyNangMem.Value & ""
            objExtend.YeuCauKinhNghiem = YeuCauKinhNghiem.SelectedValue
            objExtend.ContractType_Option = ContractType_Option.SelectedValue
            objExtend.IsLamCa = flReg.ToBoolean(IsLamCa.Checked)
            objExtend.IsDiCongTac = flReg.ToBoolean(IsDiCongTac.Checked)
            objExtend.IsDiBietPhai = flReg.ToBoolean(IsDiBietPhai.Checked)
            objExtend.MucDich_ID = MucDich_ID.SelectedValue
            objExtend.KieuLuong = KieuLuong.SelectedValue
            objExtend.Salary_Option = Salary_Option.SelectedValue
            objExtend.Salary_Text = Salary_Text.Text & ""
            objExtend.IsHoaHong = flReg.ToBoolean(IsHoaHong.Checked)
            objExtend.HinhThucNop = HinhThucNop.Text & ""
            objExtend.HoTroAn = HoTroAn.SelectedValue
            objExtend.PhucLoi = HidPhucLoi.Value & ""
            objExtend.XeDuaDon = HidXeDuaDon.Value & ""
            objExtend.HoTro = HidHoTro.Value & ""
            objExtend.PhucLoiKhac = PhucLoiKhac.Text & ""
            objExtend.NoiLamViec = NoiLamViec.SelectedValue
            objExtend.NoiLamViecTrongLuong = NoiLamViecTrongLuong.SelectedValue
            objExtend.NoiLamViecDiLai = NoiLamViecDiLai.SelectedValue
            objExtend.NoiLamViecNgheNoi = NoiLamViecNgheNoi.SelectedValue
            objExtend.NoiLamViecThiLuc = NoiLamViecThiLuc.SelectedValue
            objExtend.NoiLamViecThaoTacBangTay = NoiLamViecThaoTacBangTay.SelectedValue
            objExtend.NoiLamViecDung2Tay = NoiLamViecDung2Tay.SelectedValue
            objExtend.DoiTuongUuTien = HidDoiTuongUuTien.Value & ""
            objExtend.HinhThucTuyenDung = HidHinhThucTuyenDung.Value & ""
            objExtend.ThoiHanTuyenDung = flReg.WriteDate(ThoiHanTuyenDung.Text, False)
            objExtend.CreatedDate = Now
            objExtend.UpdatedDate = Now
            objExtend.DeletedDate = flReg.DateNull
            objExtend.CreatedUser = Me.UserInfo.Username
            objExtend.UpdatedUser = Me.UserInfo.Username
            objExtend.DeletedUser = ""
            objExtend.LevelDesiredOther = LevelDesiredOther.Text
            objExtend.IsThoaThuan = chkThoaThuan.Checked
            objExtend.MongMuonDN = MongMuonDN.SelectedValue
            objController.CMS_WorkExtend_Add(Me.PortalId, objExtend)
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                Call SaveWork()
                'Call cleartd()
                'Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công! Hệ thống sẽ tự đóng màn hình này lại trong vài giây nữa', 'Thông báo', false);backend('" & ViewState("UrlReferrer") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "removewaiting", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        'Private Sub chkMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiple.CheckedChanged
        '    If chkMultiple.Checked Then
        '        TinhTP.Visible = False
        '        TinhTPMulti.CssClass = "selectpicker TinhTP2 validate[required]"
        '        divSelectQH.Attributes.Add("class", "none")

        '        divSelectTP.Attributes.Remove("class")
        '        divSelectTP.Attributes.Add("class", "col-md-10")

        '    Else
        '        TinhTP.Visible = True
        '        TinhTPMulti.CssClass = "none selectpicker TinhTP2 validate[required]"
        '        divSelectQH.Attributes.Remove("class")
        '        divSelectQH.Attributes.Add("class", "col-md-6 divQuanHuyen")

        '        divSelectTP.Attributes.Remove("class")
        '        divSelectTP.Attributes.Add("class", "col-md-4")
        '    End If
        '    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        'End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_Work_Delete(Me.PortalId, ItemID.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "myFunction", "removewaiting();", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Public Sub SalaryIDSelectedIndexChanged(sender As Object, e As EventArgs) Handles KieuLuong.SelectedIndexChanged
            'If (Salary_ID.SelectedItem.Text.ToLower() = "7ff812b5-2a2f-4857-8de7-1325a91745e3") Then
            Call LoadSalaryId()
        End Sub
        Private Sub LoadSalaryId()
            If (KieuLuong.SelectedItem.Text.ToLower() = "lương tháng") Then
                pnlSalary_Option.Visible = True
                pnlSalary_Option_Choose.Visible = True
                pnlSalary_Input_Choose.Visible = False
            ElseIf ("lương ngày,lương giờ".Split(",").Contains(KieuLuong.SelectedItem.Text.ToLower())) Then
                pnlSalary_Option.Visible = True
                pnlSalary_Option_Choose.Visible = False
                pnlSalary_Input_Choose.Visible = True
                Salary_Text_DVT.Text = "<span class='ms'>đồng/ngày</span>"
                If KieuLuong.SelectedItem.Text.ToLower() = "lương giờ" Then
                    Salary_Text_DVT.Text = "<span class='ms'>đồng/giờ</span>"
                End If
            Else
                pnlSalary_Option.Visible = False
            End If
        End Sub

        Private Function getCheck(val As String, index As String, Optional ByVal isContain As Boolean = False) As String
            Try
                If isContain Then
                    If val.ToString.Contains(index.ToString) Then
                        Return "[ x ]"
                    Else
                        Return "[   ]"
                    End If
                Else
                    If val.Equals(index) Then
                        Return "[ x ]"
                    Else
                        Return "[   ]"
                    End If
                End If

            Catch ex As Exception
                Return "[   ]"
            End Try
        End Function
        Private Function ClearEmptyText(valStr As String) As String
            Return valStr.Replace("- - - Chọn - - -", "").Replace("--- Chọn ---", "")
        End Function
        Public Sub LevelDesiredSelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelDesired.SelectedIndexChanged
            If (LevelDesired.SelectedItem.Text.ToLower() = "khác") Then
                pnlLevelDesiredOther.Visible = True
            Else
                pnlLevelDesiredOther.Visible = False
            End If
        End Sub
        Public Sub MaNghe_IdSelectedIndexChanged(sender As Object, e As EventArgs) Handles MaNghe_Id.SelectedIndexChanged
            Try
                MaNgheCap1.Text = ""
                MaNgheCap2.Text = ""
                MaNgheCap3.Text = ""
                MaNgheCap4.Text = ""
                Dim arrayList As ArrayList = flCache.GetCache("CMS_NgheCongViec_List_" & PortalId)
                Dim objCareer As List(Of CMS_NgheCongViecInfo) = arrayList.Cast(Of CMS_NgheCongViecInfo).ToList()
                Dim parents = flFunction.GetAllParents(MaNghe_Id.SelectedValue, objCareer)
                Select Case (parents.Count)
                    Case 1
                        MaNgheCap1.Text = parents(0).Item1.Career_Name
                    Case 2
                        MaNgheCap1.Text = parents(1).Item1.Career_Name
                        MaNgheCap2.Text = parents(0).Item1.Career_Name
                    Case 3
                        MaNgheCap1.Text = parents(2).Item1.Career_Name
                        MaNgheCap2.Text = parents(1).Item1.Career_Name
                        MaNgheCap3.Text = parents(0).Item1.Career_Name
                    Case 4
                        MaNgheCap1.Text = parents(3).Item1.Career_Name
                        MaNgheCap2.Text = parents(2).Item1.Career_Name
                        MaNgheCap3.Text = parents(1).Item1.Career_Name
                        MaNgheCap4.Text = parents(0).Item1.Career_Name
                End Select
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace
