Imports DotNetNuke.UI.UserControls
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator
Imports DevExpress.Entity.ProjectModel

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim obj As New CMS_JobUserInfo
        Dim objExtra As New CMS_JobUserExtraInfo

        Dim ubj As New CMSUserPortalInfo
        Dim userExtraInfo As CMSUserExtraInfo
        Dim objUs As New UserInfo
        Dim userControler As New UserController
        Dim TenDonVi, ChucVu, CongViecChinh, FromDate, ToDate As System.Web.UI.WebControls.TextBox
        Private Sub LoadNTV()
            ItemUSID.Value = flDic.getUserID(Me.PortalId, UserAdmin.SelectedValue)
            If ItemUSID.Value <> "" Then
                objUs = userControler.GetUser(PortalSettings.PortalId, ItemUSID.Value)
                If IsNothing(objUs) Then
                    objUs = userControler.GetUser(flReg.WebConfig("PortalWork"), ItemUSID.Value)
                End If
                If IsNothing(objUs) = False Then
                    If Me.UserId <> ItemUSID.Value Then
                        HF_ID.Value = objUs.UserID
                        HF_CreatedDate.Value = objUs.CreatedOnDate
                        hdUserName.Value = objUs.Username
                        _PortalID.Value = objUs.PortalID
                        Username.Text = objUs.Username
                        DisplayName.Text = objUs.DisplayName
                        Email.Text = objUs.Email
                        Telephone.Text = objUs.Profile.Telephone
                        CreatedOnDate.Text = flReg.ReadDate(objUs.CreatedOnDate)
                        LastPasswordChangeDate.Text = flReg.ReadDate(objUs.Membership.LastPasswordChangeDate)
                        LastLoginDate.Text = flReg.ReadDate(objUs.Membership.LastLoginDate)

                        If Me.UserInfo.Username <> "host" And Me.UserInfo.Username <> "admin" Then
                            pnaView.Visible = True
                            litLogo.Text = "<img src=""" & flReg.PhotoURLFile(objUs.Username, _PortalID.Value) & "?w=200"" title=""Chọn ảnh"" />"
                        End If
                    Else
                        Username.Text = objUs.Username
                        DisplayName.Text = objUs.DisplayName
                        Email.Text = objUs.Email
                        Telephone.Text = objUs.Profile.Telephone
                        CreatedOnDate.Text = flReg.ReadDate(objUs.CreatedOnDate)
                        LastPasswordChangeDate.Text = flReg.ReadDate(objUs.Membership.LastPasswordChangeDate)
                        LastLoginDate.Text = flReg.ReadDate(objUs.Membership.LastLoginDate)

                    End If

                    ubj = flDnn.CMSUserPortal_Get_By_User("", objUs.Username, "", Me.PortalId)
                    If IsNothing(ubj) = False Then
                        Address.Text = ubj.Address
                        DateOfBirth.Text = flReg.ReadDate(ubj.DateOfBirth, False)
                        Gender.SelectedValue = ubj.Gender

                        NTV_Tinh_TT.SelectedValue = ubj.ProvinID

                        flDic.LoadRegionalXP(Me.PortalId, NTV_XaPhuong_TT, NTV_Tinh_TT.SelectedValue, "- - Xã/Phường - -")
                        NTV_XaPhuong_TT.SelectedValue = ubj.WardID
                        UsSubMod.Value = ubj.SubMod
                        UsVaiTro.Value = ubj.RolesID
                        CMND.Text = ubj.CMND
                    End If


                    userExtraInfo = flDnn.CMSUserExtra_Get_By_User("", objUs.Username, Me.PortalId)
                    If IsNothing(userExtraInfo) = False Then
                        Address2.Text = userExtraInfo.Address2
                        NTV_Tinh_HN.SelectedValue = userExtraInfo.ProvinID2

                        flDic.LoadRegionalXP(Me.PortalId, NTV_XaPhuong_HN, NTV_Tinh_HN.SelectedValue, "- - Xã/Phường - -")
                        NTV_XaPhuong_HN.SelectedValue = userExtraInfo.WardID2
                        HidKyNangMem.Value = userExtraInfo.KyNangMem
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();setMultiple();", True)

                        Level_ID.SelectedValue = userExtraInfo.LevelId
                        'UsXa.Value = ubj.WardID
                        BHXH.Text = userExtraInfo.BHXH
                        drNation.SelectedValue = userExtraInfo.DanToc
                        drReligion.SelectedValue = userExtraInfo.TonGiao
                        txtChuyenNganhDaoTao.Text = userExtraInfo.NganhDaoTao
                        txtChuyenNganhDaoTaoKhac.Text = userExtraInfo.NganhDaoTaoKhac
                        txtTrinhDoKhac.Text = userExtraInfo.TrinhDoKhac1
                        txtTrinhDoKhac2.Text = userExtraInfo.TrinhDoKhac2
                        txtKyNangNghe.Text = userExtraInfo.KyNangNghe
                        txtKyNangNgheBac.Text = userExtraInfo.KyNangNgheBac
                        txtNgoaiNgu1.Text = userExtraInfo.NgoaiNgu1
                        txtNgoaiNgu1ChungChi.Text = userExtraInfo.NgoaiNgu1ChungChi
                        txtNgoaiNgu2.Text = userExtraInfo.NgoaiNgu2
                        txtNgoaiNgu2ChungChi.Text = userExtraInfo.NgoaiNgu2ChungChi
                        txtTrinhDoTinHoc.Text = userExtraInfo.TrinhDoTinHoc
                        txtTrinhDoTinHoc_Khac.Text = userExtraInfo.TrinhDoTinHocKhac
                        txtKyNangMemKhac.Text = userExtraInfo.KyNangMemKhac
                        TrinhDoChuyenMon.SelectedValue = userExtraInfo.TrinhDoChuyenMon
                        TrinhDoChuyenMonKhac.SelectedValue = userExtraInfo.TrinhDoChuyenMonKhac
                        drTrinhDoNgoaiNgu1.SelectedValue = userExtraInfo.NgoaiNgu1KN
                        drTrinhDoNgoaiNgu2.SelectedValue = userExtraInfo.NgoaiNgu2KN
                        drTrinhDoTinHoc_KhaNang.SelectedValue = userExtraInfo.TrinhDoTinHocKN
                        drTrinhDoTinHoc_Khac_KhaNang.SelectedValue = userExtraInfo.TrinhDoTinHocKhacKN
                        drNational.SelectedValue = userExtraInfo.DaLamViecNN
                        LienHeKhac.Text = userExtraInfo.LienHeKhac
                        DTUuTien.SelectedValue = userExtraInfo.DTUuTien
                        DTUuTienKhac.Text = userExtraInfo.DTUuTienKhac
                        DichVu.SelectedValue = userExtraInfo.DKDichVu
                        DichVuKhac.Text = userExtraInfo.DKDichVuKhac
                    End If
                    Call GetSelectedItemsKM(objUs.Username)
                End If
            End If
        End Sub
        Private Sub InitControlNTV()
            Call WORK.flFunction.LoadGender(Gender)

            flDic.LoadRegionalTP(Me.PortalId, NTV_Tinh_TT, "- - Chọn tỉnh/ TP - -", "")
            NTV_Tinh_TT.SelectedValue = flReg.ProvinND(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            flDic.LoadRegionalXP(Me.PortalId, NTV_XaPhuong_TT, NTV_Tinh_TT.SelectedValue, "- - Phường/Xã - -")

            flDic.LoadRegionalTP(Me.PortalId, NTV_Tinh_HN, "- - Chọn tỉnh/ TP - -", "")
            NTV_Tinh_HN.SelectedValue = flReg.ProvinND(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            flDic.LoadRegionalXP(Me.PortalId, NTV_XaPhuong_HN, NTV_Tinh_HN.SelectedValue, "- - Phường/Xã - -")

            Call flDic.LoadEducation(Me.PortalId, Level_ID, , False)
            Call flDic.LoadDropList(drKyNangMem, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KyNangMem"))
            Call flDic.LoadDropList(DTUuTien, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DTUT"))
            Call flDic.LoadDropList(DichVu, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DKDichVu"))
            Call flWork.LoadSpecialize(Me.PortalId, TrinhDoChuyenMon)
            Call flWork.LoadSpecialize(Me.PortalId, TrinhDoChuyenMonKhac)
            Call flDic.LoadKhaNangSuDung(drTrinhDoNgoaiNgu1)
            Call flDic.LoadKhaNangSuDung(drTrinhDoNgoaiNgu2)
            Call flDic.LoadKhaNangSuDung(drTrinhDoTinHoc_KhaNang)
            Call flDic.LoadKhaNangSuDung(drTrinhDoTinHoc_Khac_KhaNang)

            Call flDic.LoadNation(Me.PortalId, drNation)
            Call flDic.LoadNational(Me.PortalId, drNational)
            Call flDic.LoadReligion(Me.PortalId, drReligion)

            'Kinh nghiệm làm việc
            Dim data As New List(Of MAP_ExperienceInfo)
            Call InsertRows(3, data)
            grdData.AllowPaging = False
            RefreshGrid(data)

            UsVaiTro.Value = flReg.GetRolesID("work", "Nguoi lao dong")
            UsSubMod.Value = Me.PortalSettings.ActiveTab.TabName
        End Sub

        Private Sub InsertRows(j As Integer, ByRef datas As List(Of MAP_ExperienceInfo))
            For i As Integer = 1 To j
                datas.Add(New MAP_ExperienceInfo())
            Next
        End Sub
        Private Sub RefreshGrid(data As List(Of MAP_ExperienceInfo))
            If data.Any Then
                grdData.DataSource = data
                grdData.PageSize = data.Count
                grdData.DataKeyField = "UserName"
                grdData.DataBind()
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call InitControlNTV()
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

            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP, "", "")
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP2, "", "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = TinhTP2.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTPMulti, "", "")
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTPMulti2, "", "")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTPMulti.SelectedValue = TinhTPMulti2.SelectedValue = flReg.WebConfig("TinhTP")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTP2.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTPMulti.SelectedValue = TinhTPMulti2.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - - Chọn - - -")
            Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa2, TinhTP2.SelectedValue, "- - - Chọn - - -")
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = PhuongXa2.SelectedValue = Request.Item("px")
            'Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flDic.LoadDropList(Salary_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_KieuLuong"),, "- - - Chọn - - -")
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            'Call flFunction.LoadSanSangLamViecOption(Me.PortalId, drSanSangLamViec)
            'Call flDic.LoadDropList(drSanSangLamViec, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucLamViec"),, "- - - Chọn - - -")
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
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID, TinhTP.SelectedValue, flReg.WriteNumber(PhuongXa.SelectedValue), "- - - Chọn - - -")
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID2, TinhTP2.SelectedValue, flReg.WriteNumber(PhuongXa2.SelectedValue), "- - - Chọn - - -")
            'Call flFunction.LoadTypeOf(Me.PortalId, TypeOf_ID, "")
            Call flDic.LoadDropList(TypeOf_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_HinhThucLamViec"),,)

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
                Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
                PhuongXa.SelectedValue = obj.QuanHuyen
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

                'Career_IDSelectedIndexChanged(Nothing, Nothing)
                SanSangLamViecSelectedIndexChanged(Nothing, Nothing)

                If Me.UserInfo.Username <> obj.CreatedUser Then cmdDelete.Visible = False
                Call LoadNTV()
            Else
                cmdDelete.Visible = False
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)

        End Sub
        Private Sub GetSelectedItems(mapId As String)
            objExtra = objController.CMS_JobUserExtra_Get(Me.PortalId, mapId)
            If IsNothing(objExtra) = False Then
                TinhTP2.SelectedValue = objExtra.TinhTP2
                Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa2, TinhTP2.SelectedValue)
                PhuongXa2.SelectedValue = objExtra.QuanHuyen2
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
                KCN_ID.SelectedValue = objExtra.KCN_ID
                KCN_ID2.SelectedValue = objExtra.KCN_ID2
            End If
        End Sub
        Private Sub GetSelectedItemsKM(userName As String)
            RefreshGrid(objController.MAPWork_GetAllByMapId_ToArrayList(Of MAP_ExperienceInfo)(PortalId, userName).ToList())
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
                HidCMKT.Value = userExtr.TrinhDoChuyenMon
                DiaChi2.Text = flDic.Address(PortalId, userExtr.Address2, "", userExtr.WardID2, userExtr.DistrictID2, userExtr.ProvinID2)
            End If
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
                obj.QuanHuyen = PhuongXa.SelectedValue

                obj.Experience_ID = Experience_ID.SelectedValue
                obj.Salary_ID = Salary_ID.SelectedValue

                obj.UserAdmin = UserAdmin.SelectedValue
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)

                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull

                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = UserInfo.Username
                obj.ApprovalDate = Now
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã cập nhật thông tin thành công!', 'Thông báo', false);", True)
                Call SendMailAuto()
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
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
            jobUserExtra.QuanHuyen2 = PhuongXa2.SelectedValue
            jobUserExtra.Description = Description.Text
            jobUserExtra.IsLamCa = IsLamCa.Checked
            jobUserExtra.IsDiCongTac = IsDiCongTac.Checked
            jobUserExtra.IsDiBietPhai = IsDiBietPhai.Checked
            jobUserExtra.IsHoaHong = chkHoaHong.Checked
            jobUserExtra.PhucLoiKhacText = txtPhucLoiKhac.Text
            jobUserExtra.TextSanSangLamViec = flReg.WriteNumber(TextSanSangLamViec.Text)
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
            jobUserExtra.TrinhDoChuyenMon = HidCMKT.Value
            jobUserExtra.KCN_ID = KCN_ID.SelectedValue
            jobUserExtra.KCN_ID2 = KCN_ID2.SelectedValue
            objController.CMS_JobUserExtra_Add(Me.PortalId, jobUserExtra)
        End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_JobUser_Delete(Me.PortalId, ItemID.Value)
                Call JobHistory("Xóa thông tin hồ sơ")
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
            Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - - Chọn - - -")
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID, TinhTP.SelectedValue, flReg.WriteNumber(PhuongXa.SelectedValue), "- - - Chọn - - -")
        End Sub

        Private Sub TinhTP2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP2.SelectedIndexChanged
            Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa2, TinhTP2.SelectedValue, "- - - Chọn - - -")
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID2, TinhTP2.SelectedValue, flReg.WriteNumber(PhuongXa2.SelectedValue), "- - - Chọn - - -")
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
        Protected Sub cmdExtt11_Click(sender As Object, e As EventArgs) Handles cmdExTT11.Click
            Try

                GemBox.Document.ComponentInfo.SetLicense(flReg.WebConfig("GemBoxKey"))
                Dim doc As GemBox.Document.DocumentModel = GemBox.Document.DocumentModel.Load(Server.MapPath("/api/work/Template/TT11_NguoiTimViec.docx"))

                If doc IsNot Nothing Then
                    'start ntv
                    doc.MailMerge.Execute(New With {.TENNLD = DisplayName.Text.Trim})
                    doc.MailMerge.Execute(New With {.CMND = CMND.Text.Trim})
                    doc.MailMerge.Execute(New With {.NgaySinh = DateOfBirth.Text.Trim})
                    doc.MailMerge.Execute(New With {.SoBHXH = BHXH.Text.Trim})
                    doc.MailMerge.Execute(New With {.GT1 = flReg.getCheck(Gender.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.GT0 = flReg.getCheck(Gender.SelectedValue, 0)})
                    doc.MailMerge.Execute(New With {.DanToc = flReg.ClearEmptyDropList(drNation)})
                    doc.MailMerge.Execute(New With {.TonGiao = flReg.ClearEmptyDropList(drReligion)})
                    doc.MailMerge.Execute(New With {.Tinh_TT = flReg.ClearEmptyDropList(NTV_Tinh_TT)})
                    doc.MailMerge.Execute(New With {.Huyen_TT = flReg.ClearEmptyDropList(NTV_XaPhuong_TT)})
                    doc.MailMerge.Execute(New With {.Xa_TT = flReg.ClearEmptyDropList(NTV_XaPhuong_TT)})
                    doc.MailMerge.Execute(New With {.DiaChi_TT = Address.Text})
                    doc.MailMerge.Execute(New With {.Tinh_HT = flReg.ClearEmptyDropList(NTV_Tinh_HN)})
                    doc.MailMerge.Execute(New With {.Huyen_HT = flReg.ClearEmptyDropList(NTV_XaPhuong_HN)})
                    doc.MailMerge.Execute(New With {.Xa_HT = flReg.ClearEmptyDropList(NTV_XaPhuong_HN)})
                    doc.MailMerge.Execute(New With {.DiaChi_HT = Address2.Text})
                    doc.MailMerge.Execute(New With {.HV1 = flReg.getCheck(Level_ID.SelectedValue, 1024)})
                    doc.MailMerge.Execute(New With {.HV2 = flReg.getCheck(Level_ID.SelectedValue, 1025)})
                    doc.MailMerge.Execute(New With {.HV3 = flReg.getCheck(Level_ID.SelectedValue, 1026)})
                    doc.MailMerge.Execute(New With {.HV4 = flReg.getCheck(Level_ID.SelectedValue, 1027)})

                    doc.MailMerge.Execute(New With {.DTUT1 = flReg.getCheck(DTUuTien.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.DTUT2 = flReg.getCheck(DTUuTien.SelectedValue, 4)})
                    doc.MailMerge.Execute(New With {.DTUT3 = flReg.getCheck(DTUuTien.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.DTUT4 = flReg.getCheck(DTUuTien.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.DTUT5 = flReg.getCheck(DTUuTien.SelectedValue, 5)})
                    doc.MailMerge.Execute(New With {.DTUTK = DTUuTienKhac.Text.Trim})

                    doc.MailMerge.Execute(New With {.CM1 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 16)})
                    doc.MailMerge.Execute(New With {.CM2 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 17)})
                    doc.MailMerge.Execute(New With {.CM3 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 18)})
                    doc.MailMerge.Execute(New With {.CM4 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 19)})
                    doc.MailMerge.Execute(New With {.CM5 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 22)})
                    doc.MailMerge.Execute(New With {.CM6 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 24)})
                    doc.MailMerge.Execute(New With {.CM7 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 25)})
                    doc.MailMerge.Execute(New With {.CM8 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 29)})
                    doc.MailMerge.Execute(New With {.CM9 = flReg.getCheck(TrinhDoChuyenMon.SelectedValue, 27)})
                    doc.MailMerge.Execute(New With {.CM10 = txtChuyenNganhDaoTao.Text})

                    doc.MailMerge.Execute(New With {.CMK1 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 16)})
                    doc.MailMerge.Execute(New With {.CMK2 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 17)})
                    doc.MailMerge.Execute(New With {.CMK3 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 18)})
                    doc.MailMerge.Execute(New With {.CMK4 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 19)})
                    doc.MailMerge.Execute(New With {.CMK5 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 22)})
                    doc.MailMerge.Execute(New With {.CMK6 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 24)})
                    doc.MailMerge.Execute(New With {.CMK7 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 25)})
                    doc.MailMerge.Execute(New With {.CMK8 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 29)})
                    doc.MailMerge.Execute(New With {.CMK9 = flReg.getCheck(TrinhDoChuyenMonKhac.SelectedValue, 27)})
                    doc.MailMerge.Execute(New With {.CMK10 = txtChuyenNganhDaoTaoKhac.Text})

                    doc.MailMerge.Execute(New With {.TDK1 = txtTrinhDoKhac.Text})
                    doc.MailMerge.Execute(New With {.TDK2 = txtTrinhDoKhac2.Text})

                    doc.MailMerge.Execute(New With {.TDN = txtKyNangNghe.Text})
                    doc.MailMerge.Execute(New With {.BTDN = txtKyNangNgheBac.Text})

                    doc.MailMerge.Execute(New With {.NN1 = txtNgoaiNgu1.Text})
                    doc.MailMerge.Execute(New With {.CCNN1 = txtNgoaiNgu1ChungChi.Text})
                    doc.MailMerge.Execute(New With {.NN1TO = flReg.getCheck(drTrinhDoNgoaiNgu1.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.NN1K = flReg.getCheck(drTrinhDoNgoaiNgu1.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.NN1T = flReg.getCheck(drTrinhDoNgoaiNgu1.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.NN2 = txtNgoaiNgu2.Text})
                    doc.MailMerge.Execute(New With {.CCNN2 = txtNgoaiNgu2ChungChi.Text})
                    doc.MailMerge.Execute(New With {.NN2TO = flReg.getCheck(drTrinhDoNgoaiNgu2.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.NN2K = flReg.getCheck(drTrinhDoNgoaiNgu2.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.NN2T = flReg.getCheck(drTrinhDoNgoaiNgu2.SelectedValue, 3)})

                    doc.MailMerge.Execute(New With {.THVP = IIf(txtTrinhDoTinHoc.Text <> "", "[ x ]", "[   ]")})
                    doc.MailMerge.Execute(New With {.THVPT = txtTrinhDoTinHoc.Text})
                    doc.MailMerge.Execute(New With {.THVPTO = flReg.getCheck(drTrinhDoTinHoc_KhaNang.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.THVPK = flReg.getCheck(drTrinhDoTinHoc_KhaNang.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.THVPT = flReg.getCheck(drTrinhDoTinHoc_KhaNang.SelectedValue, 3)})

                    doc.MailMerge.Execute(New With {.THVPK = IIf(txtTrinhDoTinHoc_Khac.Text <> "", "[ x ]", "[   ]")})
                    doc.MailMerge.Execute(New With {.THVPKT = txtTrinhDoTinHoc_Khac.Text})
                    doc.MailMerge.Execute(New With {.THVPKTO = flReg.getCheck(drTrinhDoTinHoc_Khac_KhaNang.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.THVPKK = flReg.getCheck(drTrinhDoTinHoc_Khac_KhaNang.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.THVPKT = flReg.getCheck(drTrinhDoTinHoc_Khac_KhaNang.SelectedValue, 3)})

                    doc.MailMerge.Execute(New With {.KNM1 = flReg.getCheck(HidKyNangMem.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.KNM2 = flReg.getCheck(HidKyNangMem.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.KNM3 = flReg.getCheck(HidKyNangMem.Value, 8, True)})
                    doc.MailMerge.Execute(New With {.KNM4 = flReg.getCheck(HidKyNangMem.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.KNM5 = flReg.getCheck(HidKyNangMem.Value, 7, True)})
                    doc.MailMerge.Execute(New With {.KNM6 = flReg.getCheck(HidKyNangMem.Value, 11, True)})
                    doc.MailMerge.Execute(New With {.KNM7 = flReg.getCheck(HidKyNangMem.Value, 4, True)})
                    doc.MailMerge.Execute(New With {.KNM8 = flReg.getCheck(HidKyNangMem.Value, 5, True)})
                    doc.MailMerge.Execute(New With {.KNM9 = flReg.getCheck(HidKyNangMem.Value, 6, True)})
                    doc.MailMerge.Execute(New With {.KNM10 = flReg.getCheck(HidKyNangMem.Value, 12, True)})
                    doc.MailMerge.Execute(New With {.KNM11 = flReg.getCheck(HidKyNangMem.Value, 13, True)})
                    doc.MailMerge.Execute(New With {.KNM12 = flReg.getCheck(HidKyNangMem.Value, 9, True)})
                    doc.MailMerge.Execute(New With {.KNM13 = txtKyNangMemKhac.Text})

                    TenDonVi = grdData.Items(0).FindControl("TenDonVi")
                    ChucVu = grdData.Items(0).FindControl("ChucVu")
                    CongViecChinh = grdData.Items(0).FindControl("CongViecChinh")
                    FromDate = grdData.Items(0).FindControl("FromDate")
                    ToDate = grdData.Items(0).FindControl("ToDate")

                    doc.MailMerge.Execute(New With {.KN1_DonVi = TenDonVi.Text})
                    doc.MailMerge.Execute(New With {.KN1_CVU = ChucVu.Text})
                    doc.MailMerge.Execute(New With {.KN1_CV = CongViecChinh.Text})
                    doc.MailMerge.Execute(New With {.KN1_S = FromDate.Text})
                    doc.MailMerge.Execute(New With {.KN1_E = ToDate.Text})

                    TenDonVi = grdData.Items(1).FindControl("TenDonVi")
                    ChucVu = grdData.Items(1).FindControl("ChucVu")
                    CongViecChinh = grdData.Items(1).FindControl("CongViecChinh")
                    FromDate = grdData.Items(1).FindControl("FromDate")
                    ToDate = grdData.Items(1).FindControl("ToDate")

                    doc.MailMerge.Execute(New With {.KN2_DonVi = TenDonVi.Text})
                    doc.MailMerge.Execute(New With {.KN2_CVU = ChucVu.Text})
                    doc.MailMerge.Execute(New With {.KN2_CV = CongViecChinh.Text})
                    doc.MailMerge.Execute(New With {.KN2_S = FromDate.Text})
                    doc.MailMerge.Execute(New With {.KN2_E = ToDate.Text})

                    TenDonVi = grdData.Items(2).FindControl("TenDonVi")
                    ChucVu = grdData.Items(2).FindControl("ChucVu")
                    CongViecChinh = grdData.Items(2).FindControl("CongViecChinh")
                    FromDate = grdData.Items(2).FindControl("FromDate")
                    ToDate = grdData.Items(2).FindControl("ToDate")

                    doc.MailMerge.Execute(New With {.KN3_DonVi = TenDonVi.Text})
                    doc.MailMerge.Execute(New With {.KN3_CVU = ChucVu.Text})
                    doc.MailMerge.Execute(New With {.KN3_CV = CongViecChinh.Text})
                    doc.MailMerge.Execute(New With {.KN3_S = FromDate.Text})
                    doc.MailMerge.Execute(New With {.KN3_E = ToDate.Text})


                    doc.MailMerge.Execute(New With {.CLVNN = IIf(flReg.ClearEmptyText(drNational.SelectedItem.Text) <> "", "[ x ]", "[   ]")})
                    doc.MailMerge.Execute(New With {.LVNN = flReg.ClearEmptyText(drNational.SelectedItem.Text)})

                    doc.MailMerge.Execute(New With {.SoDienThoai = Telephone.Text})
                    doc.MailMerge.Execute(New With {.Email = Email.Text})
                    doc.MailMerge.Execute(New With {.LienHeKhac = ""})


                    doc.MailMerge.Execute(New With {.DKDV1 = flReg.getCheck(DichVu.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.DKDV2 = flReg.getCheck(DichVu.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.DKDV3 = flReg.getCheck(DichVu.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.DKDV4 = flReg.getCheck(DichVu.SelectedValue, 4)})
                    doc.MailMerge.Execute(New With {.DKDV5 = flReg.getCheck(DichVu.SelectedValue, 5)})
                    doc.MailMerge.Execute(New With {.DKDVK = DichVuKhac.Text.Trim})
                    'end ntv

                    'doc.MailMerge.Execute(New With {.ID = HF_ID.Value})
                    doc.MailMerge.Execute(New With {.ID = ItemUSID.Value})

                    doc.MailMerge.Execute(New With {.TenVL = Title.Text.Trim})
                    doc.MailMerge.Execute(New With {.LHDN1 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.LHDN2 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.LHDN3 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.LHDN4 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 4, True)})

                    doc.MailMerge.Execute(New With {.TenCV = Title.Text.Trim})
                    doc.MailMerge.Execute(New With {.MotaCV = Description.Text.Trim})
                    doc.MailMerge.Execute(New With {.MNC0 = Career_ID.SelectedItem.Text})
                    doc.MailMerge.Execute(New With {.MNC1 = txtMaNgheCap1.Text})
                    doc.MailMerge.Execute(New With {.MNC2 = txtMaNgheCap2.Text})
                    doc.MailMerge.Execute(New With {.MNC3 = txtMaNgheCap3.Text})
                    doc.MailMerge.Execute(New With {.MNC4 = txtMaNgheCap4.Text})

                    doc.MailMerge.Execute(New With {.CV1 = flReg.getCheck(LevelDesired.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.CV2 = flReg.getCheck(LevelDesired.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.CV3 = flReg.getCheck(LevelDesired.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.CV4 = flReg.getCheck(LevelDesired.SelectedValue, 4)})
                    doc.MailMerge.Execute(New With {.CVK = LevelDesiredOther.Text.Trim})

                    doc.MailMerge.Execute(New With {.KN1 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435105")})
                    doc.MailMerge.Execute(New With {.KN2 = flReg.getCheck(Experience_ID.SelectedValue, "8815044d-0c9d-42ea-a5cf-17bbf3a3094c")})
                    doc.MailMerge.Execute(New With {.KN3 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435101")})
                    doc.MailMerge.Execute(New With {.KN4 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435102")})
                    doc.MailMerge.Execute(New With {.KN5 = flReg.getCheck(Experience_ID.SelectedValue, "9b4dc263-f011-4f36-926b-331d58b0d073")})

                    doc.MailMerge.Execute(New With {.Tinh_UT = flReg.ClearEmptyText(TinhTP.SelectedItem.Text)})
                    doc.MailMerge.Execute(New With {.Huyen_UT = flReg.ClearEmptyText(PhuongXa.SelectedItem.Text)})
                    doc.MailMerge.Execute(New With {.Tinh_UT2 = flReg.ClearEmptyText(TinhTP2.SelectedItem.Text)})
                    doc.MailMerge.Execute(New With {.Huyen_UT2 = flReg.ClearEmptyText(PhuongXa2.SelectedItem.Text)})
                    doc.MailMerge.Execute(New With {.KCN1 = IIf(flReg.WriteNumber(KCN_ID.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID.SelectedItem.Text), "")})
                    doc.MailMerge.Execute(New With {.KCN2 = IIf(flReg.WriteNumber(KCN_ID2.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID2.SelectedItem.Text), "")})

                    doc.MailMerge.Execute(New With {.LHD1 = flReg.getCheck(HidContractType.Value, 1, True)})
                    Dim _lhd2 = flReg.getCheck(HidContractType.Value, 2, True)
                    _lhd2 = IIf(_lhd2 <> "[ x ]", flReg.getCheck(HidContractType.Value, 3, True), _lhd2)
                    doc.MailMerge.Execute(New With {.LHD2 = _lhd2})
                    doc.MailMerge.Execute(New With {.LHD3 = "[   ]"})

                    doc.MailMerge.Execute(New With {.HTLV1 = flReg.getCheck(HidTypeOf.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.HTLV2 = flReg.getCheck(HidTypeOf.Value, 2, True)})

                    doc.MailMerge.Execute(New With {.YCT1 = flReg.getCheck(IsLamCa.Checked, True)})
                    doc.MailMerge.Execute(New With {.YCT2 = flReg.getCheck(IsDiCongTac.Checked, True)})
                    doc.MailMerge.Execute(New With {.YCT3 = flReg.getCheck(IsDiBietPhai.Checked, True)})

                    doc.MailMerge.Execute(New With {.MDLV1 = flReg.getCheck(HidMucDich.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.MDLV2 = flReg.getCheck(HidMucDich.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.MDLV3 = flReg.getCheck(HidMucDich.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.LUONGTHANG = flReg.getCheck(Salary_ID.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.LUONGNGAY = flReg.getCheck(Salary_ID.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.LUONGGIO = flReg.getCheck(Salary_ID.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.LUONG1 = flReg.getCheck(Salary_Option.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.LUONG2 = flReg.getCheck(Salary_Option.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.LUONG3 = flReg.getCheck(Salary_Option.SelectedValue, 3)})
                    doc.MailMerge.Execute(New With {.LUONG4 = flReg.getCheck(Salary_Option.SelectedValue, 4)})
                    doc.MailMerge.Execute(New With {.LUONG5 = flReg.getCheck(Salary_Option.SelectedValue, 5)})
                    doc.MailMerge.Execute(New With {.LUONG6 = flReg.getCheck(Salary_Option.SelectedValue, 6)})
                    If Salary_ID.SelectedValue = 2 Then
                        doc.MailMerge.Execute(New With {.TIENLUONGNGAY = Salary_Text.Text.Trim})

                    Else
                        doc.MailMerge.Execute(New With {.TIENLUONGNGAY = ""})

                    End If
                    If Salary_ID.SelectedValue = 3 Then
                        doc.MailMerge.Execute(New With {.TIENLUONGGIO = Salary_Text.Text.Trim})

                    Else
                        doc.MailMerge.Execute(New With {.TIENLUONGGIO = ""})

                    End If

                    doc.MailMerge.Execute(New With {.LUONGTT = flReg.getCheck(chkThoaThuan.Checked, True)})
                    doc.MailMerge.Execute(New With {.HH = flReg.getCheck(chkHoaHong.Checked, True)})

                    doc.MailMerge.Execute(New With {.CDPLHTA1 = flReg.getCheck(HidHoTroAn.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.CDPLHTA2 = flReg.getCheck(HidHoTroAn.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.CDPLHTA3 = flReg.getCheck(HidHoTroAn.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.CDPLHTA4 = flReg.getCheck(HidHoTroAn.Value, 4, True)})
                    doc.MailMerge.Execute(New With {.CDPLHTA5 = flReg.getCheck(HidHoTroAn.Value, 5, True)})

                    doc.MailMerge.Execute(New With {.CDPLBH1 = flReg.getCheck(HidPhucLoi.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.CDPLBH2 = flReg.getCheck(HidPhucLoi.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.CDPLBH3 = flReg.getCheck(HidPhucLoi.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.CDPLBH4 = flReg.getCheck(HidPhucLoi.Value, 4, True)})

                    doc.MailMerge.Execute(New With {.CDPLDC1 = flReg.getCheck(HidXeDuaDon.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.CDPLDC2 = flReg.getCheck(HidXeDuaDon.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.CDPLDC3 = flReg.getCheck(HidXeDuaDon.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.CDPLDC4 = flReg.getCheck(HidXeDuaDon.Value, 4, True)})
                    doc.MailMerge.Execute(New With {.CDPLDC5 = flReg.getCheck(HidXeDuaDon.Value, 5, True)})

                    doc.MailMerge.Execute(New With {.CDPL1 = flReg.getCheck(HidPhucLoiKhac.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.CDPL2 = flReg.getCheck(HidPhucLoiKhac.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.CDPL3 = flReg.getCheck(HidPhucLoiKhac.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.CDPLK = txtPhucLoiKhac.Text.Trim})

                    doc.MailMerge.Execute(New With {.DKNLV1 = flReg.getCheck(HidNoiLamViec.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKNLV2 = flReg.getCheck(HidNoiLamViec.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKNLV3 = flReg.getCheck(HidNoiLamViec.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.DKTNL1 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKTNL2 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKTNL3 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.DKLVDC1 = flReg.getCheck(HidNoiLamViecDiLai.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKLVDC2 = flReg.getCheck(HidNoiLamViecDiLai.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKLVDC3 = flReg.getCheck(HidNoiLamViecDiLai.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.DKLVGT1 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKLVGT2 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKLVGT3 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.DKLVTL1 = flReg.getCheck(HidNoiLamViecThiLuc.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKLVTL2 = flReg.getCheck(HidNoiLamViecThiLuc.Value, 2, True)})

                    doc.MailMerge.Execute(New With {.DKLVTTBT1 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKLVTTBT2 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKLVTTBT3 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 3, True)})

                    doc.MailMerge.Execute(New With {.DKLVD2T1 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.DKLVD2T2 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.DKLVD2T3 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.DKLVDTAYTRAI = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 4, True)})
                    doc.MailMerge.Execute(New With {.DKLVDTAYPHAI = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 5, True)})

                    doc.MailMerge.Execute(New With {.SSLV1 = flReg.getCheck(drSanSangLamViec.SelectedValue, 1)})
                    doc.MailMerge.Execute(New With {.SSLV2 = flReg.getCheck(drSanSangLamViec.SelectedValue, 2)})
                    doc.MailMerge.Execute(New With {.ThangLV = flReg.WriteNumber(TextSanSangLamViec.Text)})

                    doc.MailMerge.Execute(New With {.HTTD1 = flReg.getCheck(HidHinhThucTuyenDung.Value, 1, True)})
                    doc.MailMerge.Execute(New With {.HTTD2 = flReg.getCheck(HidHinhThucTuyenDung.Value, 2, True)})
                    doc.MailMerge.Execute(New With {.HTTD3 = flReg.getCheck(HidHinhThucTuyenDung.Value, 3, True)})
                    doc.MailMerge.Execute(New With {.HTTD4 = flReg.getCheck(HidHinhThucTuyenDung.Value, 4, True)})

                    doc.MailMerge.Execute(New With {.TenDonVi = TinhTP.SelectedItem.Text})
                    doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                    doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                    doc.MailMerge.Execute(New With {.Thang = Now.Month})
                    doc.MailMerge.Execute(New With {.Nam = Now.Year})
                    doc.MailMerge.Execute(New With {.KCN1 = IIf(flReg.WriteNumber(KCN_ID.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID.SelectedItem.Text), "")})
                    doc.MailMerge.Execute(New With {.KCN2 = IIf(flReg.WriteNumber(KCN_ID2.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID2.SelectedItem.Text), "")})

                End If
                Dim fileSave = "TT11_HSXV_" & flReg.NameUrl(UserAdmin.SelectedItem.Text) & "_" & Now.ToString("ddMMyyyhhmmss") & ".docx"
                Dim pathTemp = Server.MapPath(flReg.MapPath("/data/0/temps/") & fileSave)
                doc.Save(pathTemp)
                lblDownLoad.Text = flReg.GenerateIframeDownloadHtmlCode(flReg.MapPath("/data/0/temps/") & fileSave)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('success', 'Xuất thông tin thành công!', 'Thông báo', false);", True)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.ToString, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdExND23_Click(sender As Object, e As EventArgs) Handles cmdExND23.Click
            GemBox.Document.ComponentInfo.SetLicense(flReg.WebConfig("GemBoxKey"))
            Dim doc As GemBox.Document.DocumentModel = GemBox.Document.DocumentModel.Load(Server.MapPath("/api/work/Template/ND23_HoSoXinViec.docx"))

            If doc IsNot Nothing Then
                'doc.MailMerge.Execute(New With {.ID = HF_ID.Value})
                doc.MailMerge.Execute(New With {.ID = ItemUSID.Value})


                doc.MailMerge.Execute(New With {.TenVL = Title.Text.Trim})

                doc.MailMerge.Execute(New With {.LHDN1 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 1, True)})
                doc.MailMerge.Execute(New With {.LHDN2 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 2, True)})
                doc.MailMerge.Execute(New With {.LHDN3 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 3, True)})
                doc.MailMerge.Execute(New With {.LHDN4 = flReg.getCheck(HidLoaiHinhDoanhNghiep.Value, 4, True)})

                doc.MailMerge.Execute(New With {.TenCV = Title.Text.Trim})
                doc.MailMerge.Execute(New With {.MotaCV = Description.Text.Trim})
                doc.MailMerge.Execute(New With {.MNC0 = Career_ID.SelectedItem.Text})
                doc.MailMerge.Execute(New With {.MNC1 = txtMaNgheCap1.Text})
                doc.MailMerge.Execute(New With {.MNC2 = txtMaNgheCap2.Text})
                doc.MailMerge.Execute(New With {.MNC3 = txtMaNgheCap3.Text})
                doc.MailMerge.Execute(New With {.MNC4 = txtMaNgheCap4.Text})

                doc.MailMerge.Execute(New With {.CV1 = flReg.getCheck(LevelDesired.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.CV2 = flReg.getCheck(LevelDesired.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.CV3 = flReg.getCheck(LevelDesired.SelectedValue, 3)})
                doc.MailMerge.Execute(New With {.CV4 = flReg.getCheck(LevelDesired.SelectedValue, 4)})
                doc.MailMerge.Execute(New With {.CVK = LevelDesiredOther.Text.Trim})

                doc.MailMerge.Execute(New With {.KN1 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435105")})
                doc.MailMerge.Execute(New With {.KN2 = flReg.getCheck(Experience_ID.SelectedValue, "8815044d-0c9d-42ea-a5cf-17bbf3a3094c")})
                doc.MailMerge.Execute(New With {.KN3 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435101")})
                doc.MailMerge.Execute(New With {.KN4 = flReg.getCheck(Experience_ID.SelectedValue, "d2315a91-8409-4cac-a69e-8bc145435102")})
                doc.MailMerge.Execute(New With {.KN5 = flReg.getCheck(Experience_ID.SelectedValue, "9b4dc263-f011-4f36-926b-331d58b0d073")})

                doc.MailMerge.Execute(New With {.Tinh_TT = flReg.ClearEmptyText(TinhTP.SelectedItem.Text)})
                doc.MailMerge.Execute(New With {.Huyen_TT = flReg.ClearEmptyText(PhuongXa.SelectedItem.Text)})
                doc.MailMerge.Execute(New With {.TinhTT2 = flReg.ClearEmptyText(TinhTP2.SelectedItem.Text)})
                doc.MailMerge.Execute(New With {.Huyen_TT2 = flReg.ClearEmptyText(PhuongXa2.SelectedItem.Text)})


                doc.MailMerge.Execute(New With {.LHD1 = flReg.getCheck(HidContractType.Value, 1, True)})
                doc.MailMerge.Execute(New With {.LHD2 = flReg.getCheck(HidContractType.Value, 2, True)})
                doc.MailMerge.Execute(New With {.LHD3 = flReg.getCheck(HidContractType.Value, 3, True)})

                doc.MailMerge.Execute(New With {.HTLV1 = flReg.getCheck(HidTypeOf.Value, 1, True)})
                doc.MailMerge.Execute(New With {.HTLV2 = flReg.getCheck(HidTypeOf.Value, 2, True)})

                doc.MailMerge.Execute(New With {.YCT1 = flReg.getCheck(IsLamCa.Checked, True)})
                doc.MailMerge.Execute(New With {.YCT2 = flReg.getCheck(IsDiCongTac.Checked, True)})
                doc.MailMerge.Execute(New With {.YCT3 = flReg.getCheck(IsDiBietPhai.Checked, True)})

                doc.MailMerge.Execute(New With {.MDLV1 = flReg.getCheck(HidMucDich.Value, 1, True)})
                doc.MailMerge.Execute(New With {.MDLV2 = flReg.getCheck(HidMucDich.Value, 2, True)})
                doc.MailMerge.Execute(New With {.MDLV3 = flReg.getCheck(HidMucDich.Value, 3, True)})

                doc.MailMerge.Execute(New With {.LUONGTHANG = flReg.getCheck(Salary_ID.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.LUONGNGAY = flReg.getCheck(Salary_ID.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.LUONGGIO = flReg.getCheck(Salary_ID.SelectedValue, 3)})
                doc.MailMerge.Execute(New With {.LUONG1 = flReg.getCheck(Salary_Option.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.LUONG2 = flReg.getCheck(Salary_Option.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.LUONG3 = flReg.getCheck(Salary_Option.SelectedValue, 3)})
                doc.MailMerge.Execute(New With {.LUONG4 = flReg.getCheck(Salary_Option.SelectedValue, 4)})
                doc.MailMerge.Execute(New With {.LUONG5 = flReg.getCheck(Salary_Option.SelectedValue, 5)})
                doc.MailMerge.Execute(New With {.LUONG6 = flReg.getCheck(Salary_Option.SelectedValue, 6)})
                If Salary_ID.SelectedValue = 2 Then
                    doc.MailMerge.Execute(New With {.TIENLUONGNGAY = Salary_Text.Text.Trim})

                Else
                    doc.MailMerge.Execute(New With {.TIENLUONGNGAY = ""})

                End If
                If Salary_ID.SelectedValue = 3 Then
                    doc.MailMerge.Execute(New With {.TIENLUONGGIO = Salary_Text.Text.Trim})

                Else
                    doc.MailMerge.Execute(New With {.TIENLUONGGIO = ""})

                End If

                doc.MailMerge.Execute(New With {.LUONGTT = flReg.getCheck(chkThoaThuan.Checked, True)})
                doc.MailMerge.Execute(New With {.HH = flReg.getCheck(chkHoaHong.Checked, True)})

                doc.MailMerge.Execute(New With {.CDPLHTA1 = flReg.getCheck(HidHoTroAn.Value, 1, True)})
                doc.MailMerge.Execute(New With {.CDPLHTA2 = flReg.getCheck(HidHoTroAn.Value, 2, True)})
                doc.MailMerge.Execute(New With {.CDPLHTA3 = flReg.getCheck(HidHoTroAn.Value, 3, True)})
                doc.MailMerge.Execute(New With {.CDPLHTA4 = flReg.getCheck(HidHoTroAn.Value, 4, True)})
                doc.MailMerge.Execute(New With {.CDPLHTA5 = flReg.getCheck(HidHoTroAn.Value, 5, True)})

                doc.MailMerge.Execute(New With {.CDPLBH1 = flReg.getCheck(HidPhucLoi.Value, 1, True)})
                doc.MailMerge.Execute(New With {.CDPLBH2 = flReg.getCheck(HidPhucLoi.Value, 2, True)})
                doc.MailMerge.Execute(New With {.CDPLBH3 = flReg.getCheck(HidPhucLoi.Value, 3, True)})
                doc.MailMerge.Execute(New With {.CDPLBH4 = flReg.getCheck(HidPhucLoi.Value, 4, True)})

                doc.MailMerge.Execute(New With {.CDPLDC1 = flReg.getCheck(HidXeDuaDon.Value, 1, True)})
                doc.MailMerge.Execute(New With {.CDPLDC2 = flReg.getCheck(HidXeDuaDon.Value, 2, True)})
                doc.MailMerge.Execute(New With {.CDPLDC3 = flReg.getCheck(HidXeDuaDon.Value, 3, True)})
                doc.MailMerge.Execute(New With {.CDPLDC4 = flReg.getCheck(HidXeDuaDon.Value, 4, True)})
                doc.MailMerge.Execute(New With {.CDPLDC5 = flReg.getCheck(HidXeDuaDon.Value, 5, True)})

                doc.MailMerge.Execute(New With {.CDPL1 = flReg.getCheck(HidPhucLoiKhac.Value, 1, True)})
                doc.MailMerge.Execute(New With {.CDPL2 = flReg.getCheck(HidPhucLoiKhac.Value, 2, True)})
                doc.MailMerge.Execute(New With {.CDPL3 = flReg.getCheck(HidPhucLoiKhac.Value, 3, True)})
                doc.MailMerge.Execute(New With {.CDPLK = txtPhucLoiKhac.Text.Trim})

                doc.MailMerge.Execute(New With {.DKNLV1 = flReg.getCheck(HidNoiLamViec.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKNLV2 = flReg.getCheck(HidNoiLamViec.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKNLV3 = flReg.getCheck(HidNoiLamViec.Value, 3, True)})

                doc.MailMerge.Execute(New With {.DKTNL1 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKTNL2 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKTNL3 = flReg.getCheck(HidNoiLamViecTrongLuong.Value, 3, True)})

                doc.MailMerge.Execute(New With {.DKLVDC1 = flReg.getCheck(HidNoiLamViecDiLai.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKLVDC2 = flReg.getCheck(HidNoiLamViecDiLai.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKLVDC3 = flReg.getCheck(HidNoiLamViecDiLai.Value, 3, True)})

                doc.MailMerge.Execute(New With {.DKLVGT1 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKLVGT2 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKLVGT3 = flReg.getCheck(HidNoiLamViecNgheNoi.Value, 3, True)})

                doc.MailMerge.Execute(New With {.DKLVTL1 = flReg.getCheck(HidNoiLamViecThiLuc.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKLVTL2 = flReg.getCheck(HidNoiLamViecThiLuc.Value, 2, True)})

                doc.MailMerge.Execute(New With {.DKLVTTBT1 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKLVTTBT2 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKLVTTBT3 = flReg.getCheck(HidNoiLamViecThaoTacBangTay.Value, 3, True)})

                doc.MailMerge.Execute(New With {.DKLVD2T1 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 1, True)})
                doc.MailMerge.Execute(New With {.DKLVD2T2 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 2, True)})
                doc.MailMerge.Execute(New With {.DKLVD2T3 = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 3, True)})
                doc.MailMerge.Execute(New With {.DKLVDTAYTRAI = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 4, True)})
                doc.MailMerge.Execute(New With {.DKLVDTAYPHAI = flReg.getCheck(HidNoiLamViecDung2Tay.Value, 5, True)})

                doc.MailMerge.Execute(New With {.SSLV1 = flReg.getCheck(drSanSangLamViec.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.SSLV2 = flReg.getCheck(drSanSangLamViec.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.ThangLV = flReg.WriteNumber(TextSanSangLamViec.Text)})

                doc.MailMerge.Execute(New With {.HTTD1 = flReg.getCheck(HidHinhThucTuyenDung.Value, 1, True)})
                doc.MailMerge.Execute(New With {.HTTD2 = flReg.getCheck(HidHinhThucTuyenDung.Value, 2, True)})
                doc.MailMerge.Execute(New With {.HTTD3 = flReg.getCheck(HidHinhThucTuyenDung.Value, 3, True)})
                doc.MailMerge.Execute(New With {.HTTD4 = flReg.getCheck(HidHinhThucTuyenDung.Value, 4, True)})

                doc.MailMerge.Execute(New With {.TenDonVi = TinhTP.SelectedItem.Text})
                doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                doc.MailMerge.Execute(New With {.Thang = Now.Month})
                doc.MailMerge.Execute(New With {.Nam = Now.Year})
                doc.MailMerge.Execute(New With {.KCN1 = IIf(flReg.WriteNumber(KCN_ID.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID.SelectedItem.Text), "")})
                doc.MailMerge.Execute(New With {.KCN2 = IIf(flReg.WriteNumber(KCN_ID2.SelectedValue) > 0, flReg.ClearEmptyText(KCN_ID2.SelectedItem.Text), "")})


            End If
            Dim fileSave = "ND23_HSXV_" & flReg.NameUrl(UserAdmin.SelectedItem.Text) & "_" & Now.ToString("ddMMyyyhhmmss") & ".docx"
            Dim pathTemp = Server.MapPath(flReg.MapPath("/data/0/temps/") & fileSave)
            doc.Save(pathTemp)
            lblDownLoad.Text = flReg.GenerateIframeDownloadHtmlCode(flReg.MapPath("/data/0/temps/") & fileSave)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub

        Protected Sub grdData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            TenDonVi = e.Item.FindControl("TenDonVi")
            TenDonVi.Text = CType(e.Item.DataItem, MAP_ExperienceInfo).TenDonVi

            ChucVu = e.Item.FindControl("ChucVu")
            ChucVu.Text = CType(e.Item.DataItem, MAP_ExperienceInfo).ChucVu

            CongViecChinh = e.Item.FindControl("CongViecChinh")
            CongViecChinh.Text = CType(e.Item.DataItem, MAP_ExperienceInfo).CongViecChinh

            ToDate = e.Item.FindControl("FromDate")
            ToDate.Text = CType(e.Item.DataItem, MAP_ExperienceInfo).FromDate.ToString("dd/MM/yyyy")

            ToDate = e.Item.FindControl("ToDate")
            ToDate.Text = CType(e.Item.DataItem, MAP_ExperienceInfo).ToDate.ToString("dd/MM/yyyy")

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
    End Class



End Namespace
