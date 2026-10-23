Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim obj As New CMS_BusinessInfo
        Dim bUinfo As New CMS_BusUserInfo
        Dim ubj As New CMSUserPortalInfo
        Dim liter As Literal
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "app") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub InitControls()
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP)
            If flReg.WebConfig("TinhTP") <> "" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Xã/ phường - -", "XP")

            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName
            'Call flFunction.LoadCareer(Me.PortalId, Career_ID, "")
            Call flDic.LoadDropList(Types, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_LoaiChuThe"))
            Call flDic.LoadDropList(LoaiHinh_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_LOAIHINH"))
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID, TinhTP.SelectedValue, 0, "")
            Call flDic.LoadDropList(Career_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NganhNgheKinhDoanh"))
            Call flDic.LoadDropList(QuyMoLaoDong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_QuyMoLaoDong"))
            Call flDic.LoadDropList(DichVuDangKy, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DichVuDangKy"))
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub LoadValue()
            obj = objController.CMS_Business_Get_UserAdmin(Me.PortalId, Me.UserInfo.Username)
            If IsNothing(obj) = False Then
                ItemID.Value = obj.Business_ID
                Business_Vn.Text = flReg.RemoveScript(obj.Business_Vn, False)
                'Business_En.Text = flReg.RemoveScript(obj.Business_En, False)
                'Business_Sort.Text = flReg.RemoveScript(obj.Business_Sort, False)
                TinhTP.SelectedValue = obj.TinhTP
                Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - - Chọn - - -", "XP")
                XaPhuong.SelectedValue = obj.XaPhuong

                TaxCode.Text = obj.TaxCode
                Mobile.Text = flReg.RemoveScript(obj.Mobile, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                Address.Text = flReg.RemoveScript(obj.Address, False)
                ContactUser.Text = flReg.RemoveScript(obj.ContactUser, False)
                ContactMobile.Text = flReg.RemoveScript(obj.ContactMobile, False)
                cmdUpdate.Visible = obj.IsAdmin
                CareerID.Value = obj.Career_ID
                Types.Text = obj.Types
                KCN.Checked = obj.KCN
                KCN_ID.Text = obj.KCN_ID
                SoLD6ThangToi.Text = obj.SoLD6ThangToi
                SanPhamChinh.Text = obj.SanPhamChinh
                QuyMoLaoDong.SelectedValue = obj.QuyMoLaoDong
                ContactChucVu.Text = obj.ContactChucVu
                ContactLHKhac.Text = obj.ContactLHKhac
                HidDichVuDangKy.Value = obj.DichVuDangKy
                DichVuDangKyKhac.Text = obj.DichVuDangKyKhac
                CreatedDate.Text = flReg.ReadDate(obj.CreatedDate)
                'Call LoadBusUser(obj.Business_ID)

                If obj.IsApproval = False Then
                    lbMsg.Text = "<div class=""cmsUpdate1"">Hiện tại Doanh nghiệp của bạn không hoạt động, vui lòng liên hệ quản trị để được phục vụ.</div>"
                End If
                If WORK.flCheck.CheckInfoUser(Me.PortalId, Me.UserInfo.Username) = False Then
                    lbMsg.Text = "<div class=""cmsUpdate1"">Bạn cần được phê duyệt thông tin trước khi tiếp tục, vui lòng liên hệ quản trị để được phục vụ.</div>"
                End If
            Else
                CreatedDate.Text = flReg.ReadDate(Now.Date)

                lbMsg.Text = "<div class=""cmsUpdate1"">Bạn phải cập nhật thông tin doanh nghiệp trước khi đăng hồ sơ.</div>"
                ubj = flDnn.CMSUserPortal_Get_By_User("", Me.UserInfo.Username, "", 0)
                If IsNothing(ubj) = False Then
                    Address.Text = ubj.Address
                    ContactMobile.Text = ubj.Telephone
                    Mobile.Text = ubj.Telephone
                    Email.Text = ubj.Email
                    ContactUser.Text = ubj.DisplayName

                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
                End If
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
        'Private Sub LoadBusUser(busID As String)
        '    bUinfo = objController.CMS_BusUser_Get_Business_User(Me.PortalId, busID, Me.UserInfo.Username)
        '    If IsNothing(bUinfo) = False Then
        '        uIsActive.Checked = bUinfo.IsActive
        '        If bUinfo.IsActive = True Then
        '            lbLogo.Text = "<img src=""/image/ok.png?h=80"" class=""xac-thuc"" alt=""Đã xác thực"">"
        '            cmdUpdate.Attributes.Add("onclick", "javascript:return confirm('Hồ sơ này của bạn đã kiểm duyệt?<br/><b>Lưu ý: </b>Nếu thay đổi, hồ sơ của bạn sẽ được <b style='color:red'>kiểm duyệt lại</b> trước khi đăng thông tin. <b>Bạn có chắc muốn thay đổi không?</b>');")
        '        Else
        '            lbLogo.Text = "<img src=""/image/unOk.png?h=80"" class=""xac-thuc"" alt=""Chờ xác thực"">"
        '            lbMsg.Text = "<div class=""cmsUpdate1 block mgbt20 unactive-buss"">Hồ sơ của bạn chưa được phê duyệt, vui lòng liên hệ tới ban quản trị để được hỗ trợ.</div>"
        '            cmdUpdate.Visible = False
        '            Response.Redirect("/business/view/active", True)
        '        End If
        '    Else
        '        uIsActive.Checked = False
        '    End If
        'End Sub
        Private Sub SaveBusUser(busID As String, isActive As Boolean, isAdmin As Boolean)
            Try
                bUinfo = New CMS_BusUserInfo
                bUinfo.BusUser_ID = flReg.GenKey()
                bUinfo.Business_ID = busID
                bUinfo.IsActive = isActive
                bUinfo.IsAdmin = isAdmin
                bUinfo.UserAdmin = Me.UserInfo.Username
                bUinfo.CreatedDate = Now
                bUinfo.UpdatedDate = flReg.DateNull
                If isActive = True Then
                    bUinfo.ApprovalDate = Now
                    bUinfo.ApprovalUser = "auto"
                Else
                    bUinfo.ApprovalDate = flReg.DateNull
                    bUinfo.ApprovalUser = ""
                End If
                objController.CMS_BusUser_Add(Me.PortalId, bUinfo)
            Catch ex As Exception

            End Try
        End Sub
        Private Sub SaveBusiness()
            obj.Business_Vn = flReg.RemoveScript(Business_Vn.Text)
            'obj.Business_En = flReg.RemoveScript(Business_En.Text)
            'obj.Business_Sort = flReg.RemoveScript(Business_Sort.Text)
            obj.TinhTP = TinhTP.SelectedValue
            obj.QuanHuyen = XaPhuong.SelectedValue
            obj.TaxCode = TaxCode.Text
            obj.Mobile = flReg.RemoveScript(Mobile.Text)
            obj.Email = flReg.RemoveScript(Email.Text)
            obj.Address = flReg.RemoveScript(Address.Text)
            obj.ContactUser = flReg.RemoveScript(ContactUser.Text)
            obj.ContactMobile = flReg.RemoveScript(ContactMobile.Text)
            obj.Career_ID = CareerID.Value & ""
            obj.IsApproval = False
            obj.Types = flReg.WriteNumber(Types.SelectedValue)
            obj.KCN = _KCN.Checked
            obj.KCN_ID = _KCN_ID.SelectedValue
            obj.SanPhamChinh = _SanPhamChinh.Text
            obj.QuyMoLaoDong = flReg.WriteNumber(_QuyMoLaoDong.SelectedValue)
            obj.ContactChucVu = _ContactChucVu.Text
            obj.ContactLHKhac = _ContactLHKhac.Text
            obj.SoLD6ThangToi = SoLD6ThangToi.Text
            obj.DichVuDangKy = HidDichVuDangKy.value
            obj.DichVuDangKyKhac = _DichVuDangKyKhac.Text
            obj.XaPhuong = _XaPhuong.SelectedValue
            obj.ApprovalDate = flReg.DateNull
            obj.CreatedDate = Now
            obj.UpdatedDate = Now
        End Sub
        Private Sub ClearCache()
            flCache.RemoveCache("Business_" & ItemID.Value)
            flCache.RemoveCache("Business_False" & ItemID.Value)
            flCache.RemoveCache("Business_True" & ItemID.Value)
            flCache.RemoveCache("Business_Logo_" & ItemID.Value)
            flCache.RemoveCache("Business_TP" & ItemID.Value)
            flCache.RemoveCache("Business_ID" & ItemID.Value)
            flCache.RemoveCache("Business_Address" & ItemID.Value)
            flCache.RemoveCache("Business_TaxCode" & ItemID.Value)
            flCache.RemoveCache("Business_Mobile" & ItemID.Value)
            flCache.RemoveCache("Business_Email" & ItemID.Value)
            flCache.RemoveCache("Business_ContactUser" & ItemID.Value)
            flCache.RemoveCache("Business_Vn_" & ItemID.Value)
            flCache.RemoveCache("Business_Approval_" & ItemID.Value)
            flCache.RemoveCache("Business_Code_" & ItemID.Value)
            flCache.RemoveCache("Business_Link_" & ItemID.Value)
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If DoanhNghiepID.Value <> "" Then
                    Call SaveBusiness()
                    If _PortalID.Value = "-1" Then 'Doanh nghiệp có trong bảng CSDL cầu
                        ItemID.Value = DoanhNghiepID.Value
                        obj.Business_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = UserInfo.Username
                        obj.UpdatedDate = flReg.DateNull
                        objController.CMS_Business_Add(Me.PortalId, obj)
                    Else
                        ItemID.Value = DoanhNghiepID.Value
                        obj.Business_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = ""
                        obj.UpdatedUser = UserInfo.Username
                        obj.UpdatedDate = Now
                        objController.CMS_Business_Update(Me.PortalId, obj)

                    End If
                    Call SaveBusUser(DoanhNghiepID.Value, False, False)
                Else
                    obj = New CMS_BusinessInfo
                    Call SaveBusiness()
                    If ItemID.Value <> "" Then
                        obj.Business_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = ""
                        obj.UpdatedUser = UserInfo.Username
                        obj.UpdatedDate = Now
                        objController.CMS_Business_Update(Me.PortalId, obj)
                        Call SaveBusUser(ItemID.Value, True, True)
                        If uIsActive.Checked Then
                            objController.CMS_BusUser_Update_Active(PortalId, Me.UserInfo.Username, False, "auto", Now)
                        End If
                    Else 'Thêm mới
                        ItemID.Value = flReg.GenKey()
                        obj.Business_ID = ItemID.Value
                        obj.CreatedDate = Now
                        obj.CreatedUser = UserInfo.Username
                        obj.UpdatedDate = flReg.DateNull
                        obj.ApprovalDate = Now
                        objController.CMS_Business_Add(Me.PortalId, obj)
                        Call SaveBusUser(ItemID.Value, flReg.ToBoolean(flReg.WebConfig("ActiveBusiness")), True)
                    End If
                End If
                Call ClearCache()
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('success', 'Đã cập nhật lại thông tin tài khoản doanh nghiệp thành công!', 'Thông báo', false);backend('/business/');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "app") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Phường/ xã - -")
            Call flDic.LoadDropList(KCN_ID, flDnn.CMS_KhuCongNghiep_List_ByTP(Me.PortalId, TinhTP.SelectedValue, 0, 0))

        End Sub
    End Class
End Namespace
