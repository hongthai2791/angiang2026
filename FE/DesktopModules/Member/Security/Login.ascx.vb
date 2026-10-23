Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication
'Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Namespace Modules.MemberLogin
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim myCookie As HttpCookie
        Dim status As New DotNetNuke.Security.Membership.UserLoginStatus()
        Dim valOne As String = "ONEVB-UVOLS-FAPEA"
        Dim valTow As String = "TOWVB-TBLOP-UFQUV"
        Dim str() As String
        Private Sub BackLogin(uInfo As UserInfo)

            If uInfo.UserID > 0 Then
                If uInfo.IsInRole("business") Or uInfo.IsInRole("users") Then
                    If uInfo.IsInRole("business") Then
                        If ViewState("return_nn") & "" <> "" Then
                            Dim itemid As Integer = WORK.flNotify.GetRequestId(ViewState("return_nn"))
                            If itemid > 0 Then
                                Dim url As String = ViewState("return_nn").Replace(itemid, "")
                                Response.Redirect("/business/edit/bus-jobuser-career/caid/" & url.Remove(url.Length - 1) & "/itemid/" & itemid, True)
                            Else
                                Response.Redirect("/business/edit/bus-jobuser-career/caid/" & ViewState("return_nn"), True)
                            End If
                        ElseIf ViewState("return_hs") & "" <> "" Then
                            ViewState("return_hs") = flNotify.GetRequestId(ViewState("return_hs"))
                            Response.Redirect("/business/edit/bus-jobuser/itemid/" & flCheck.JobUser_ID(Me.PortalId, ViewState("return_hs")), True)
                        ElseIf ViewState("return_nophsvl") & "" <> "" Then
                            Response.Redirect("/send-link/nop-hsvl/" & ViewState("return_nophsvl"), True)
                        ElseIf ViewState("return_vl") & "" <> "" Then
                            Dim itemid As Integer = WORK.flNotify.GetRequestId(ViewState("return_vl"))
                            If itemid > 0 Then
                                Dim url As String = ViewState("return_vl").Replace(itemid, "")
                                Response.Redirect("/business/view/" & url.Remove(url.Length - 1) & "/itemid/" & itemid, True)
                            Else
                                Response.Redirect("/business/view/" & ViewState("return_vl"), True)
                            End If
                        ElseIf ViewState("return_nophs") & "" <> "" Then
                            Response.Redirect("/send-link/nop-hs/" & ViewState("return_nophs"), True)

                        ElseIf ViewState("return_tuyendung") & "" <> "" Then
                            Response.Redirect("/business/edit/bus-works-list/tp/1", True)

                        ElseIf ViewState("return_timkiem") & "" <> "" Then
                            Response.Redirect("/business/view/bus-profile-suit", True)
                        ElseIf ViewState("return_svl") & "" <> "" Then
                            'Response.Redirect("/business/view/bus-mark-list", True)
                            Response.Redirect("/send-link/svl/" & ViewState("return_svl"), True)

                        ElseIf ViewState("return_khampha") & "" <> "" Then
                            Response.Redirect("/business/view/bus-jobuser", True)
                        Else
                            Response.Redirect("/business", True)
                        End If
                    End If
                    If uInfo.IsInRole("users") Then 'Người lao động
                        If ViewState("return_nn") & "" <> "" Then
                            Response.Redirect("/send-link/xem-nn/" & ViewState("return_nn"), True)
                        ElseIf ViewState("return_hs") & "" <> "" Then
                            Response.Redirect("/send-link/luu-hs/" & ViewState("return_hs"), True)
                        ElseIf ViewState("return_vl") & "" <> "" Then
                            Response.Redirect("/send-link/vl/" & ViewState("return_vl"), True)

                        ElseIf ViewState("return_svl") & "" <> "" Then
                            Response.Redirect("/send-link/svl/" & ViewState("return_svl"), True)
                        ElseIf ViewState("return_nophsvl") & "" <> "" Then
                            Response.Redirect("/users/edit/us-mark-list/itemid/" & ViewState("return_nophsvl") & "/idw/" & ViewState("return_nophsvl_idw") & "/idb/" & ViewState("return_nophsvl_idb") & "/idtab/" & ViewState("return_nophsvl_idtab"), True)
                        Else
                            If ViewState("Return") & "" <> "" Then
                                Response.Redirect("/users/edit/us-works/itemid/" & flCheck.getWork_ID(Me.PortalId, ViewState("Return")), True)
                            ElseIf ViewState("return_nophs") & "" <> "" Then
                                ViewState("return_nophs") = flNotify.GetRequestId(ViewState("return_nophs"))
                                Response.Redirect("/users/edit/us-works/itemid/" & flCheck.getWork_ID(Me.PortalId, ViewState("return_nophs")), True)

                            ElseIf ViewState("return_tuyendung") & "" <> "" Then
                                Response.Redirect("/send-link/tuyen-dung/" & ViewState("return_tuyendung"), True)
                            ElseIf ViewState("return_timkiem") & "" <> "" Then
                                Response.Redirect("/send-link/tim-kiem/" & ViewState("return_timkiem"), True)
                            ElseIf ViewState("return_khampha") & "" <> "" Then
                                Response.Redirect("/send-link/kham-pha/" & ViewState("return_khampha"), True)
                            Else
                                Response.Redirect("/users", True)
                            End If
                        End If

                    End If
                Else
                    Response.Redirect("/system", True)
                End If
            Else
                Response.Redirect("/", True)
            End If

        End Sub
        Private Function getRequestURL(url As String, val As String) As String
            str = url.Split("/")
            If str(str.Length - 2) = val Then
                Return str(str.Length - 1)
            Else
                Return ""
            End If
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Me.UserInfo.UserID > 0 Then Call BackLogin(Me.UserInfo)
            If IsNothing(Request.UrlReferrer) = False Then
                If getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "xem-nn") & "" <> "" Then
                    ViewState("return_nn") = getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "xem-nn")

                ElseIf getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "nop-hs") & "" <> "" Then
                    ViewState("return_nophs") = getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "nop-hs")
                ElseIf Request.Item("nop-hsvl") & "" <> "" Then
                    ViewState("return_nophsvl") = Request.Item("nop-hsvl")
                    ViewState("return_nophsvl_idw") = Request.Item("idw")
                    ViewState("return_nophsvl_idb") = Request.Item("idb")
                    ViewState("return_nophsvl_idtab") = Request.Item("idtab")
                ElseIf getRequestURL(Request.RawUrl, "nop-hs") & "" <> "" Then
                    ViewState("return_nophs") = getRequestURL(Request.RawUrl, "nop-hs")
                ElseIf getRequestURL(Request.RawUrl, "luu-hs") & "" <> "" Then
                    ViewState("return_hs") = getRequestURL(Request.RawUrl, "luu-hs")
                ElseIf getRequestURL(Request.RawUrl, "tuyen-dung") & "" <> "" Then
                    ViewState("return_tuyendung") = getRequestURL(Request.RawUrl, "tuyen-dung")

                ElseIf getRequestURL(Request.RawUrl, "tim-kiem") & "" <> "" Then
                    ViewState("return_timkiem") = getRequestURL(Request.RawUrl, "tim-kiem")

                ElseIf getRequestURL(Request.RawUrl, "kham-pha") & "" <> "" Then
                    ViewState("return_khampha") = getRequestURL(Request.RawUrl, "kham-pha")

                ElseIf getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "vl") & "" <> "" Then
                    ViewState("return_vl") = getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "vl")
                ElseIf getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "svl") & "" <> "" Then
                    ViewState("return_svl") = getRequestURL(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "svl")

                ElseIf flNotify.GetRequestId(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)) > 0 Then
                    ViewState("Return") = flNotify.GetRequestId(flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName))
                End If
            End If
            txtUsername.Attributes.Add("onkeypress", "Return clickButton(Event,'" + cmdLogin.ClientID + "')")
            txtPassword.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdLogin.ClientID + "')")
            If IsNothing(Request.Cookies(valTow)) Then
                VbCapchar.Visible = False
            Else
                VbCapchar.Visible = True
            End If
        End Sub
        Private Sub CookiesLog(name As String, ex As DateTime)
            myCookie = New HttpCookie(name)
            myCookie.Values.Add("ubLi", "1")
            myCookie.Expires = ex
            Response.Cookies.Add(myCookie)
        End Sub
        Private Sub SetLogin()
            If IsNothing(Request.Cookies(valOne)) Then
                Call CookiesLog(valOne, Now.AddMinutes(5))
                VbCapchar.Visible = False
            Else
                Call CookiesLog(valTow, Now.AddMinutes(5))
                VbCapchar.Visible = True
            End If
        End Sub
        Private Sub LoginUser()
            Try
                Dim obj = UserController.ValidateUser(PortalId, txtUsername.Text.Trim, txtPassword.Text, "DNN", PortalSettings.PortalName, AuthenticationLoginBase.GetIPAddress(), status)
                If status = UserLoginStatus.LOGIN_SUCCESS OrElse status = UserLoginStatus.LOGIN_SUPERUSER Then
                    UserController.UserLogin(PortalId, obj, PortalSettings.PortalName, AuthenticationLoginBase.GetIPAddress(), False)
                    Dim eventArgs As New UserAuthenticatedEventArgs(obj, txtUsername.Text.Trim, status, "DNN")
                    eventArgs.Authenticated = True

                    Call CookiesLog(valTow, Now.AddDays(-1))
                    Call CookiesLog(valOne, Now.AddDays(-1))

                    Call BackLogin(obj)
                ElseIf status = UserLoginStatus.LOGIN_USERLOCKEDOUT Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Tài khoản này đã bị khóa. Hãy đợi 10 phút trước khi thử đăng nhập lại.', 'Thông báo', false);", True)
                    Call SetLogin()
                Else
                    Dim itemU = flDnn.DNN_User_Get_UserName(Me.PortalId, txtUsername.Text.Trim)
                    If itemU.IsDeleted Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Tài khoản của bạn đã bị khóa, vui lòng liên hệ với quản trị!', 'Thông báo', false);", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng kiểm tra lại!', 'Thông báo', false);", True)
                    End If
                    Call SetLogin()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng kiểm tra lại!', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
            status = UserLoginStatus.LOGIN_FAILURE
            If IsNothing(Request.Cookies(valTow)) Then
                Call LoginUser()
            Else
                If VbCapchar.IsValid Then
                    Call LoginUser()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_warning", "notify('warning', 'Bạn chưa tích chọn mã xác minh bảo mật!', 'Thông báo', false);", True)

                    Call SetLogin()
                End If
            End If
        End Sub
    End Class

End Namespace
