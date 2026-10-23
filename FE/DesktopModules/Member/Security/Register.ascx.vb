Imports DotNetNuke.Security.Roles
Imports DotNetNuke.Security.Membership
Imports DotNetNuke.EPORTAL

Namespace Modules.MemberRegister
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ctlRole As New RoleController
        Dim roInfo As New RoleInfo

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Me.UserInfo.UserID > 0 Then Response.Redirect("/", True)
            'Call LoadLogo()
        End Sub
        'Private Sub LoadLogo()
        '    litLogo.Text = EPORTAL.flCache.GetCache("LoadLogo_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias) & ""
        '    If litLogo.Text = "" Then
        '        litLogo.Text = EPORTAL.flCache.GetCache("LoadLogo_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias) & ""
        '        If litLogo.Text = "" Then
        '            For Each Cr As CMS.CMS_InfomationInfo In New CMS.CmsController().CMS_Infomation_List(0, 0)
        '                litLogo.Text = "<a href=""" & EPORTAL.flConnect.WebDomain(0) & """ target=""_blank"" title=""home""><img src=""" & EPORTAL.flReg.ImgSRC(Cr.ImagePath, 0, 48, True) & """ alt=""logo"" /></a>"
        '            Next
        '            If litLogo.Text <> "" Then
        '                EPORTAL.flCache.SetCache("LoadLogo_" & EPORTAL.flReg.WebConfig("TinhTP") & "_" & EPORTAL.flReg.UrlAlias, litLogo.Text)
        '            Else
        '                litLogo.Text = "<a href=""" & EPORTAL.flConnect.WebDomain(0) & """ target=""_blank"" title=""home""><img src=""/image/hng/bigtech.png?h=40"" alt=""logo"" /></a>"
        '            End If
        '        End If
        '    End If
        'End Sub

        Private Sub SendMail(UserID As Integer)
            Dim subject As String = "Xác nhận đăng ký tài khoản."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += String.Format("Cảm ơn <b>Ông/Bà</b> đã đăng ký sử dụng dịch vụ đăng tin tuyển dụng, tra cứu thông tin việc làm tại {0} .<p></p>", flReg.WebConfig("works"))
            body += "Tài khoản đăng nhập của Ông/Bà là: <span style='color: green; font-weight: bold;'>" & txtEmail.Text.Trim & "</span>.<br/> "
            body += "<p>Ông/Bà đã nhập " & txtEmail.Text.Trim & " làm địa chỉ email liên lạc cho tài khoản trên hệ thống.</p> "
            body += "<p>Để kích hoạt sử dụng tài khoản, vui lòng bấm <a href=""" & flReg.UrlAlias & "/kich-hoat-tai-khoan/id/" & flReg.Encrypt("1", UserID) & """ title=""Link kích hoạt dịch vụ"">vào đây</a> để sử dụng dịch vụ.</p> "
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị</div>"
            flDnn.DNN_SendMail(txtEmail.Text.Trim, subject, body)
        End Sub
        Private Sub CreateUser()
            Try
                If UserController.GetUsersByEmail(Me.PortalId, txtEmail.Text.Trim, 1, 1, 1, True, False).Count > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting(); notify('danger','Email bạn nhập đã được đăng ký trên hệ thống. Vui lòng thử lại với email khác!', 'Thông báo', false);", True)
                    Return
                End If

                Dim objUser As New UserInfo()
                objUser.AffiliateID = Null.NullInteger
                objUser.Username = txtEmail.Text.Trim
                objUser.Email = txtEmail.Text.Trim
                objUser.LastName = LastName.Text.Trim
                objUser.FirstName = FirstName.Text.Trim
                objUser.DisplayName = FirstName.Text.Trim & " " & LastName.Text.Trim
                objUser.IsSuperUser = False
                objUser.PortalID = Me.PortalId
                objUser.Membership.Password = txtPassword.Text
                objUser.Membership.Approved = True
                objUser.Membership.UpdatePassword = False
                objUser.Membership.IsDeleted = False
                objUser.Profile.InitialiseProfile(Me.PortalId)
                objUser.Profile.Country = ""
                objUser.Profile.Street = ""
                objUser.Profile.City = ""
                objUser.Profile.Region = ""
                objUser.Profile.PostalCode = ""
                objUser.Profile.Unit = ""
                objUser.Profile.Telephone = txtSoDienThoai.Text.Trim
                objUser.Profile.FirstName = FirstName.Text.Trim
                objUser.Profile.LastName = LastName.Text.Trim
                Dim objCreateStatus As UserCreateStatus = UserController.CreateUser(objUser)

                If objCreateStatus = UserCreateStatus.Success Then
                    Dim obj As New CMSUserPortalInfo
                    obj.PortalID = 0
                    obj.UserName = objUser.Username
                    obj.DisplayName = objUser.DisplayName
                    obj.Email = objUser.Email
                    obj.SubMod = "work"
                    obj.ProvinID = flReg.WebConfig("TinhTP")
                    obj.DistrictID = 0
                    obj.WardID = 0
                    obj.Telephone = txtSoDienThoai.Text.Trim
                    If chDoanhNghiep.Checked = True Then
                        obj.RolesID = flReg.GetRolesID("work", "Doanh nghiep")
                        roInfo = ctlRole.GetRoleByName(Me.PortalId, "business")
                    Else
                        obj.RolesID = flReg.GetRolesID("work", "Nguoi lao dong")
                        roInfo = ctlRole.GetRoleByName(Me.PortalId, "users")
                    End If
                    flDnn.CMSUserPortal_Add(obj)
                    If IsNothing(roInfo) = False Then
                        ctlRole.AddUserRole(Me.PortalId, objUser.UserID, roInfo.RoleID, Null.NullDate, Null.NullDate)
                    End If
                    Try
                        If flReg.WebConfig("ActiveByEmail") Then 'Kích hoạt tài khoản qua email
                            EPORTAL.flDnn.DNN_User_Lock(objUser.UserID, True, Me.PortalId)
                            Call SendMail(objUser.UserID)
                            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting(); notify('success','Tài khoản của bạn đã được tạo trên hệ thống, vui lòng check mail để kích hoạt dịch vụ.', 'Thông báo', false);", True)
                        Else
                            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting(); notify('success','Tài khoản của bạn đã được tạo trên hệ thống, đăng nhập để tiếp tục sử dụng dịch vụ.', 'Thông báo', false);", True)

                        End If
                    Catch ex As Exception
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting(); notify('success','Tài khoản của bạn đã được tạo trên hệ thống, đăng nhập để tiếp tục sử dụng dịch vụ.', 'Thông báo', false);", True)
                    End Try

                Else

                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), String.Format("removewaiting(); notify('info','{0}', 'Thông báo', false);", ReadErCreateUser(objCreateStatus)), True)
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Function ReadErCreateUser(erCode As UserCreateStatus) As String
            Select Case erCode
                Case UserCreateStatus.UsernameAlreadyExists, UserCreateStatus.DuplicateEmail, UserCreateStatus.DuplicateUserName
                    ReadErCreateUser = "Email đã tồn tại trong hệ thống. Vui lòng sử dụng địa chỉ email khác hoặc sử dụng chức năng quên mật khẩu"
                Case UserCreateStatus.UserAlreadyRegistered
                    ReadErCreateUser = "Email của bạn đã được đăng ký trên hệ thống. Vui lòng sử dụng địa chỉ email khác hoặc sử dụng chức năng quên mật khẩu"
                Case UserCreateStatus.InvalidEmail, UserCreateStatus.InvalidUserName
                    ReadErCreateUser = "Email không hợp lệ"
                Case UserCreateStatus.UnexpectedError, UserCreateStatus.UserRejected
                    ReadErCreateUser = String.Format("[{0}] Hệ thống đang bận, vui lòng thử lại sau ít phút", erCode)
                Case UserCreateStatus.InvalidPassword
                    ReadErCreateUser = String.Format("Mật khẩu không hợp lệ, vui lòng thử lại với mật khẩu từ 7 ký tự", erCode)
                Case UserCreateStatus.BannedPasswordUsed
                    ReadErCreateUser = "Tài khoản của bạn đã bị khóa, vui lòng liên hệ quản trị hệ thống"
                Case Else
                    ReadErCreateUser = String.Format("[{0}] Hệ thống đang bận, vui lòng thử lại sau ít phút", erCode)
            End Select
        End Function
        Private Sub cmdReg_Click(sender As Object, e As EventArgs) Handles cmdReg.Click
            If chCaNhan.Checked = False And chDoanhNghiep.Checked = False Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning_1", "notify('warning', 'Bạn chưa chọn loại tài khoản đăng ký!', 'Thông báo', false);", True)
                Exit Sub
            End If
            If VbCapchar.IsValid Then
                Call CreateUser()
            Else
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Bạn chưa tích chọn mã xác minh bảo mật!', 'Thông báo', false);", True)
            End If
        End Sub
    End Class

End Namespace
