Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim obj As New CMS_BusinessInfo
        Dim uBinfo As New CMS_BusUserInfo
        Dim arr As New ArrayList
        Dim liter As Literal, dr As DropDownList
        Dim tBox As TextBox
        Dim cBox As CheckBox
        Dim rBox As RadioButton
        Dim str() As String
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
                If IsApproval.Checked Then
                    cmdNewWork.Visible = True
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub LoadUserAdmin()
            arr = objController.CMS_BusUser_Get_By_CMS_Business(Me.PortalId, ItemID.Value)
            For i As Integer = 1 To 3
                uBinfo = New CMS_BusUserInfo
                uBinfo.BusUser_ID = flReg.GenKey()
                uBinfo.IsActive = False
                arr.Add(uBinfo)
            Next
            grdData.DataSource = arr
            grdData.PageSize = arr.Count + 1
            grdData.DataKeyField = "BusUser_ID"
            grdData.DataBind()
        End Sub
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "- - Chọn tỉnh/ TP - -", "")
            If flReg.WebConfig("TinhTP") <> "" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
            ItemID.Value = Request.Item("itemid")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, PortalSettings.ActiveTab.TabName)

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Xã/ phường - -", "XP")

            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName
            Call flDic.LoadDropList(Types, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_LoaiChuThe"))
            Call flDic.LoadDropList(LoaiHinh_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DM_LOAIHINH"))
            Call flDic.LoadKhuCongNghiep(Me.PortalId, KCN_ID, TinhTP.SelectedValue, 0, "- - - Chọn - - -")
            Call flDic.LoadDropList(Career_ID, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_NganhNgheKinhDoanh"))
            Call flDic.LoadDropList(QuyMoLaoDong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_QuyMoLaoDong"))
            Call flDic.LoadDropList(DichVuDangKy, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_DichVuDangKy"))

            If flReg.IsInRole(Me.PortalId, PortalSettings.ActiveTab.TabName, "Trung tam") = True And ItemID.Value = "" And Me.UserInfo.Username <> "host" Then
                grdData.Visible = False
            Else
                LitDN.Text = "<h3 class=""box-title mgt0"">Danh sách tài khoản quản trị doanh nghiệp</h3>"
            End If

        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub

        Private Sub SaveBusUser()
            Try

                Dim bUinfo As New CMS_BusUserInfo
                If grdData.Visible = False Then
                    bUinfo = New CMS_BusUserInfo
                    bUinfo.BusUser_ID = flReg.GenKey()
                    bUinfo.Business_ID = ItemID.Value
                    bUinfo.IsActive = True
                    bUinfo.UserAdmin = Me.UserInfo.Username
                    bUinfo.CreatedDate = Now
                    bUinfo.UpdatedDate = flReg.DateNull
                    bUinfo.ApprovalDate = Now
                    bUinfo.ApprovalUser = Me.UserInfo.Username

                    objController.CMS_BusUser_Add_Import(Me.PortalId, bUinfo)
                Else
                    For i As Integer = 0 To grdData.Items.Count - 1
                        dr = grdData.Items(i).FindControl("UserAdmin")
                        If dr.SelectedValue <> "" Then
                            bUinfo = New CMS_BusUserInfo
                            bUinfo.BusUser_ID = flReg.GenKey()
                            bUinfo.Business_ID = ItemID.Value

                            cBox = grdData.Items(i).FindControl("IsActive")
                            bUinfo.IsActive = cBox.Checked

                            rBox = grdData.Items(i).FindControl("IsAdmin")
                            bUinfo.IsAdmin = rBox.Checked
                            bUinfo.UserAdmin = dr.SelectedValue
                            bUinfo.CreatedDate = Now
                            bUinfo.UpdatedDate = flReg.DateNull
                            If bUinfo.IsActive = True Then
                                bUinfo.ApprovalDate = Now
                                bUinfo.ApprovalUser = Me.UserInfo.Username
                            Else
                                bUinfo.ApprovalDate = flReg.DateNull
                                bUinfo.ApprovalUser = ""
                            End If
                            objController.CMS_BusUser_Add(Me.PortalId, bUinfo)
                        End If
                    Next
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Hệ thống không thể thiết lập tài khoản quản trị cho doanh nghiệp', 'Thông báo', false);", True)

                Exit Sub
            End Try
        End Sub
        Private Sub LoadValue()

            obj = objController.CMS_Business_Get(Me.PortalId, ItemID.Value)
            cmdExND23.Visible = False
            If IsNothing(obj) = False Then
                cmdExND23.Visible = True
                HF_ID.Value = obj.ID
                HF_CreatedDate.Value = obj.CreatedDate
                Business_Vn.Text = flReg.RemoveScript(obj.Business_Vn, False)
                TinhTP.SelectedValue = obj.TinhTP


                Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - - Chọn - - -", "XP")
                XaPhuong.SelectedValue = obj.XaPhuong



                TaxCode.Text = obj.TaxCode
                Mobile.Text = obj.Mobile
                Email.Text = obj.Email
                CareerID.Value = obj.Career_ID
                LoaiHinh_ID.SelectedValue = obj.LoaiHinh_ID
                txtLat.Text = obj.Lat
                txtLng.Text = obj.Lng
                Address.Text = flReg.RemoveScript(obj.Address, False)
                ContactUser.Text = flReg.RemoveScript(obj.ContactUser, False)
                ContactMobile.Text = obj.ContactMobile
                Types.Text = obj.Types
                KCN.Checked = obj.KCN
                KCN_ID.Text = obj.KCN_ID
                SanPhamChinh.Text = obj.SanPhamChinh
                QuyMoLaoDong.SelectedValue = obj.QuyMoLaoDong
                SoLD6ThangToi.Text = obj.SoLD6ThangToi
                ContactChucVu.Text = obj.ContactChucVu
                ContactLHKhac.Text = obj.ContactLHKhac
                HidDichVuDangKy.Value = obj.DichVuDangKy
                DichVuDangKyKhac.Text = obj.DichVuDangKyKhac
                CreatedDate.Text = flReg.ReadDate(obj.CreatedDate)
                IsTinCay.Checked = obj.IsTinCay
                IsApproval.Checked = obj.IsApproval
                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
                If Me.UserInfo.Username <> "host" Then cmdDelete.Visible = False

            Else
                cmdDelete.Visible = False
            End If
            Call LoadUserAdmin()

            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub

        Private Sub SendMail(email As String, isActive As Boolean)
            Try
                Dim subject As String = "Thông báo xác thực thông tin doanh nghiệp của bạn."
                Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
                body += "Cảm ơn <b>Ông/Bà</b> đã đăng ký sử dụng dịch vụ đăng tin tuyển dụng, tra cứu thông tin việc làm.<p></p>"
                If isActive = True Then
                    body += "Thông tin tài khoản doanh nghiệp của bạn đã được xác thực, vui lòng truy cập vào hệ thống để đăng tin tuyển dụng.<br/> "
                Else
                    body += "Thông tin tài khoản doanh nghiệp của bạn đã bị khóa, vui lòng liên hệ với quản trị để được hỗ trợ.<br/> "
                End If
                body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
                body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
                body += "Ban quản trị</div>"
                flDnn.DNN_SendMail(email, subject, body)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Hệ thống không thể gửi email thông báo tới tài khoản bị hủy duyệt', 'Thông báo', false);", True)
                Exit Sub
            End Try
        End Sub
        Protected Sub grdData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            liter = e.Item.FindControl("IsOrder")
            liter.Text = grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1

            dr = e.Item.FindControl("UserAdmin")
            Call flFunction.ListUserName(dr, "true", Me.PortalSettings.ActiveTab.TabName, StatusBus.DoanhNghiep)
            dr.SelectedValue = DataBinder.Eval(e.Item.DataItem, "UserAdmin")
            If DataBinder.Eval(e.Item.DataItem, "UserAdmin") <> "" Then
                dr.Items.Add(New ListItem(DataBinder.Eval(e.Item.DataItem, "UserAdmin")))
                dr.SelectedValue = DataBinder.Eval(e.Item.DataItem, "UserAdmin")
            End If
            If e.Item.ItemIndex = 0 Then
                If DataBinder.Eval(e.Item.DataItem, "UserAdmin") = "" Then
                    dr.Items.Add(Me.UserInfo.Username)
                    dr.SelectedValue = Me.UserInfo.Username
                End If
            End If
            liter = e.Item.FindControl("CreatedDate")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreatedDate"), True)

            liter = e.Item.FindControl("ApprovalDate")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ApprovalDate"), True)

            cBox = e.Item.FindControl("IsActive")
            cBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsActive")

            rBox = e.Item.FindControl("IsAdmin")
            rBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsAdmin")
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If valError.Value = "ERROR" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Mã số doanh nghiệp không hợp lệ, vui lòng kiểm tra lại!', 'Thông báo', false);", True)
                    msgError.InnerHtml = "<div class='bug-val'>Mã số này đã được sử dụng trên hệ thống, vui lòng kiểm tra lại.</div>"
                    Exit Sub
                End If
                If IsApproval.Checked And grdData.Visible = True Then
                    Dim isEm As Boolean = False
                    For i As Integer = 0 To grdData.Items.Count - 1
                        cBox = grdData.Items(i).FindControl("IsActive")
                        If cBox.Checked Then
                            isEm = True : Exit For
                        End If
                    Next
                    If isEm = False Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Bạn phải chọn một tài khoản được duyệt cho doanh nghiệp này!', 'Thông báo', false);", True)
                        Exit Sub
                    End If
                End If

                obj = New CMS_BusinessInfo
                obj.Business_Vn = flReg.RemoveScript(Business_Vn.Text)
                obj.TinhTP = TinhTP.SelectedValue
                obj.XaPhuong = XaPhuong.SelectedValue
                obj.TaxCode = TaxCode.Text
                obj.Mobile = Mobile.Text
                obj.Career_ID = CareerID.Value & ""
                obj.LoaiHinh_ID = LoaiHinh_ID.SelectedValue
                obj.Email = Email.Text
                obj.Address = Address.Text
                obj.ContactUser = ContactUser.Text
                obj.ContactMobile = ContactMobile.Text

                obj.Types = flReg.WriteNumber(Types.SelectedValue)
                obj.KCN = _KCN.Checked
                obj.KCN_ID = _KCN_ID.SelectedValue
                obj.SanPhamChinh = _SanPhamChinh.Text
                obj.QuyMoLaoDong = flReg.WriteNumber(_QuyMoLaoDong.SelectedValue)
                obj.SoLD6ThangToi = SoLD6ThangToi.Text
                obj.ContactChucVu = _ContactChucVu.Text
                obj.ContactLHKhac = _ContactLHKhac.Text
                obj.DichVuDangKy = HidDichVuDangKy.Value
                obj.DichVuDangKyKhac = _DichVuDangKyKhac.Text

                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = UserInfo.Username
                obj.ApprovalDate = Now
                obj.PortalId = Me.PortalId

                If ItemID.Value <> "" Then
                    obj.Business_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = UserInfo.Username
                    obj.UpdatedDate = Now
                    objController.CMS_Business_Update(Me.PortalId, obj)
                    flCache.RemoveCache("Business_" & ItemID.Value)
                    flCache.RemoveCache("Business_False" & ItemID.Value)
                    flCache.RemoveCache("Business_True" & ItemID.Value)
                    flCache.RemoveCache("Business_Logo_" & ItemID.Value)
                Else
                    ItemID.Value = flReg.GenKey()
                    obj.Business_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull
                    objController.CMS_Business_Add(Me.PortalId, obj)
                End If
                Call objController.CMS_Business_Update_LatLng(PortalId, ItemID.Value, txtLat.Text.Trim, txtLng.Text.Trim)
                Call objController.CMS_Business_Update_TinCay(PortalId, ItemID.Value, IsTinCay.Checked)

                Call SaveBusUser()

                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);backend('" & ViewState("UrlReferrer") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_Business_Delete(Me.PortalId, ItemID.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Phường/ xã - -")
        End Sub

        Private Sub cmdNewWork_Click(sender As Object, e As EventArgs) Handles cmdNewWork.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/emp-works/bid/" & ItemID.Value)
        End Sub

        Protected Sub cmdExND23_Click(sender As Object, e As EventArgs)
            GemBox.Document.ComponentInfo.SetLicense(flReg.WebConfig("GemBoxKey"))
            Dim doc As GemBox.Document.DocumentModel = GemBox.Document.DocumentModel.Load(Server.MapPath("/api/work/Template/ND23_DoanhNghiep.docx"))

            If doc IsNot Nothing Then
                doc.MailMerge.Execute(New With {.ID = HF_ID.Value})
                doc.MailMerge.Execute(New With {.TenDN = Business_Vn.Text.Trim})
                doc.MailMerge.Execute(New With {.TaxCode = TaxCode.Text.Trim})
                doc.MailMerge.Execute(New With {.CN = flReg.getCheck(Types.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.DN = flReg.getCheck(Types.SelectedValue, 2)})

                doc.MailMerge.Execute(New With {.LH1 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.LH2 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.LH3 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 3)})
                doc.MailMerge.Execute(New With {.LH4 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 4)})
                doc.MailMerge.Execute(New With {.LH5 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 5)})
                doc.MailMerge.Execute(New With {.LH6 = flReg.getCheck(LoaiHinh_ID.SelectedValue, 6)})

                doc.MailMerge.Execute(New With {.Tinh = TinhTP.SelectedItem.Text})
                doc.MailMerge.Execute(New With {.Huyen = ""})
                doc.MailMerge.Execute(New With {.Xa = XaPhuong.SelectedItem.Text})
                doc.MailMerge.Execute(New With {.DCChiTiet = Address.Text.Trim})

                doc.MailMerge.Execute(New With {.KCN = flReg.getCheck(KCN.Checked, True)})
                doc.MailMerge.Execute(New With {.KCN_ID = IIf(KCN_ID.SelectedValue <> "0", KCN_ID.SelectedItem.Text, "")})
                doc.MailMerge.Execute(New With {.Sdt = Mobile.Text.Trim})
                doc.MailMerge.Execute(New With {.Email = Email.Text.Trim})

                doc.MailMerge.Execute(New With {.KD1 = flReg.getCheck(CareerID.Value, 1, True)})
                doc.MailMerge.Execute(New With {.KD2 = flReg.getCheck(CareerID.Value, 2, True)})
                doc.MailMerge.Execute(New With {.KD3 = flReg.getCheck(CareerID.Value, 3, True)})
                doc.MailMerge.Execute(New With {.KD4 = flReg.getCheck(CareerID.Value, 4, True)})
                doc.MailMerge.Execute(New With {.KD5 = flReg.getCheck(CareerID.Value, 5, True)})
                doc.MailMerge.Execute(New With {.KD6 = flReg.getCheck(CareerID.Value, 6, True)})
                doc.MailMerge.Execute(New With {.KD7 = flReg.getCheck(CareerID.Value, 7, True)})
                doc.MailMerge.Execute(New With {.KD8 = flReg.getCheck(CareerID.Value, 8, True)})
                doc.MailMerge.Execute(New With {.KD9 = flReg.getCheck(CareerID.Value, 9, True)})
                doc.MailMerge.Execute(New With {.KD10 = flReg.getCheck(CareerID.Value, 10, True)})
                doc.MailMerge.Execute(New With {.KD11 = flReg.getCheck(CareerID.Value, 11, True)})
                doc.MailMerge.Execute(New With {.KD12 = flReg.getCheck(CareerID.Value, 12, True)})
                doc.MailMerge.Execute(New With {.KD13 = flReg.getCheck(CareerID.Value, 13, True)})
                doc.MailMerge.Execute(New With {.KD14 = flReg.getCheck(CareerID.Value, 14, True)})
                doc.MailMerge.Execute(New With {.KD15 = flReg.getCheck(CareerID.Value, 15, True)})
                doc.MailMerge.Execute(New With {.KD16 = flReg.getCheck(CareerID.Value, 16, True)})
                doc.MailMerge.Execute(New With {.KD17 = flReg.getCheck(CareerID.Value, 17, True)})
                doc.MailMerge.Execute(New With {.KD18 = flReg.getCheck(CareerID.Value, 18, True)})
                doc.MailMerge.Execute(New With {.KD19 = flReg.getCheck(CareerID.Value, 19, True)})
                doc.MailMerge.Execute(New With {.KD20 = flReg.getCheck(CareerID.Value, 20, True)})
                doc.MailMerge.Execute(New With {.KD21 = flReg.getCheck(CareerID.Value, 21, True)})
                doc.MailMerge.Execute(New With {.SanPhamChinh = SanPhamChinh.Text.Trim})

                doc.MailMerge.Execute(New With {.QM1 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 1)})
                doc.MailMerge.Execute(New With {.QM2 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 2)})
                doc.MailMerge.Execute(New With {.QM3 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 3)})
                doc.MailMerge.Execute(New With {.QM4 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 4)})
                doc.MailMerge.Execute(New With {.QM5 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 5)})
                doc.MailMerge.Execute(New With {.QM6 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 6)})
                doc.MailMerge.Execute(New With {.QM7 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 7)})
                doc.MailMerge.Execute(New With {.QM8 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 8)})
                doc.MailMerge.Execute(New With {.QM9 = flReg.getCheck(QuyMoLaoDong.SelectedValue, 9)})

                doc.MailMerge.Execute(New With {.LD6M = SoLD6ThangToi.Text.Trim})

                doc.MailMerge.Execute(New With {.TV1 = flReg.getCheck(HidDichVuDangKy.Value, 1, True)})
                doc.MailMerge.Execute(New With {.TV2 = flReg.getCheck(HidDichVuDangKy.Value, 2, True)})
                doc.MailMerge.Execute(New With {.TV3 = flReg.getCheck(HidDichVuDangKy.Value, 3, True)})
                doc.MailMerge.Execute(New With {.TV4 = flReg.getCheck(HidDichVuDangKy.Value, 4, True)})
                doc.MailMerge.Execute(New With {.TV5 = flReg.getCheck(HidDichVuDangKy.Value, 5, True)})

                doc.MailMerge.Execute(New With {.TVKhac = DichVuDangKyKhac.Text.Trim})
                doc.MailMerge.Execute(New With {.ThoiGianDangKy = flReg.ReadDate(HF_CreatedDate.Value, False)})


                doc.MailMerge.Execute(New With {.LH_HoTen = ContactUser.Text.Trim})
                doc.MailMerge.Execute(New With {.LH_ChucVu = ContactChucVu.Text.Trim})
                doc.MailMerge.Execute(New With {.LH_SDT = ContactMobile.Text.Trim})
                doc.MailMerge.Execute(New With {.LH_Khac = ContactLHKhac.Text.Trim})

                doc.MailMerge.Execute(New With {.TenDonVi = TinhTP.SelectedItem.Text})
                doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                doc.MailMerge.Execute(New With {.Ngay = Now.Day})
                doc.MailMerge.Execute(New With {.Thang = Now.Month})
                doc.MailMerge.Execute(New With {.Nam = Now.Year})


            End If
            Dim fileSave = "DN_" & flReg.NameUrl(Business_Vn.Text) & "_" & Now.ToString("ddMMyyyhhmmss") & ".docx"
            Dim pathTemp = Server.MapPath(flReg.MapPath("/data/0/temps/") & fileSave)
            doc.Save(pathTemp)
            lblDownLoad.Text = flReg.GenerateIframeDownloadHtmlCode(flReg.MapPath("/data/0/temps/") & fileSave)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
    End Class



End Namespace
