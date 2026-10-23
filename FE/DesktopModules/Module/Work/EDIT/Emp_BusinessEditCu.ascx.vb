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
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
            ItemID.Value = Request.Item("itemid")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, PortalSettings.ActiveTab.TabName)

            Call CAU.flFunction.LoadLoaiHinhDN(Me.PortalId, LoaiHinh_ID)
            If flReg.IsInRole(Me.PortalId, PortalSettings.ActiveTab.TabName, "Trung tam") = True And ItemID.Value = "" And Me.UserInfo.Username <> "host" Then
                grdData.Visible = False
            Else
                LitDN.Text = "<h3 class=""box-title mgt0"">Danh sách tài khoản quản trị doanh nghiệp</h3>"
            End If
            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "")
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
            If IsNothing(obj) = False Then
                Business_Vn.Text = flReg.RemoveScript(obj.Business_Vn, False)
                Business_En.Text = flReg.RemoveScript(obj.Business_En, False)
                Business_Sort.Text = flReg.RemoveScript(obj.Business_Sort, False)
                TinhTP.SelectedValue = obj.TinhTP
                Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
                QuanHuyen.SelectedValue = obj.QuanHuyen
                If obj.Logo & "" <> "" Then
                    imgDD.InnerHtml = "<img alt='ảnh đại diện' src='" & flConnect.fileDomain & obj.Logo & "?dpi=150&quality=100&w=145&h=120' />"
                End If
                LogoDN.Value = obj.Logo
                Description.Text = flReg.RemoveScript(obj.Description, False)
                TaxCode.Text = obj.TaxCode
                Mobile.Text = obj.Mobile
                Scale.Text = obj.Scale
                Fax.Text = obj.Fax
                Website.Text = obj.Website
                Email.Text = obj.Email
                CareerID.Value = obj.Career_ID
                LoaiHinh_ID.SelectedValue = obj.LoaiHinh_ID
                txtLat.Text = obj.Lat
                txtLng.Text = obj.Lng
                Address.Text = flReg.RemoveScript(obj.Address, False)
                ContactUser.Text = flReg.RemoveScript(obj.ContactUser, False)
                ContactMobile.Text = obj.ContactMobile
                ContactEmail.Text = obj.ContactEmail
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
                obj.Business_En = flReg.RemoveScript(Business_En.Text)
                obj.Business_Sort = flReg.RemoveScript(Business_Sort.Text)
                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = QuanHuyen.SelectedValue
                obj.Logo = LogoDN.Value
                obj.Description = Description.Text
                obj.TaxCode = TaxCode.Text
                obj.Mobile = Mobile.Text
                obj.Career_ID = CareerID.Value & ""
                obj.LoaiHinh_ID = LoaiHinh_ID.SelectedValue
                obj.Fax = Fax.Text
                obj.Website = Website.Text
                obj.Email = Email.Text
                obj.Address = Address.Text
                obj.Scale = Scale.Text
                obj.ContactUser = ContactUser.Text
                obj.ContactMobile = ContactMobile.Text
                obj.ContactEmail = ContactEmail.Text
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
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
        End Sub

        Private Sub cmdNewWork_Click(sender As Object, e As EventArgs) Handles cmdNewWork.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/emp-works/bid/" & ItemID.Value)
        End Sub
    End Class



End Namespace
