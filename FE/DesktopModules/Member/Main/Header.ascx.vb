Imports DotNetNuke.EPORTAL

Namespace Modules.Main
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim strImg, strUrl As String
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim _userName As String = Me.UserInfo.Username
        Public _tabName As String = PortalSettings.ActiveTab.TabName
        Dim _viewTable As String

        Private Sub LoadValue()
            litU.Text = "<div class=""gb_Zc gb_r"">"
            litU.Text += "<div class=""gb_na gb_8"">"
            litU.Text += "<div class=""gb_Mg"">"
            If Me.UserInfo.Username = "host" Then
                litU.Text += "<a href=""/" & _tabName & "/view/module"" title=""Thiết lập module"">"
                litU.Text += "<img alt=""Module"" src=""/image/images/module-white.png"">"
                litU.Text += "</a>&nbsp;&nbsp;"
            End If
            litU.Text += "</div>"
            litU.Text += "<div class=""gb_Lc"">"

            strUrl = "/" & _tabName & "/view/profile-user"

            litU.Text += "<a href=""" & strUrl & """ rel=""nofollow"" title=""Thông tin tài khoản"">"
            litU.Text += Me.UserInfo.DisplayName & "</a>"

            litU.Text += "</div>"
            litU.Text += "<div class=""gb_oa"">"
            litU.Text += "<a title=""" & Me.UserInfo.DisplayName & "(" & Me.UserInfo.Email & ")"""
            litU.Text += "href=""#"" onclick=""ariaexpan(this);"" class=""unnone gb_pa gb_l gb_r"">"
            litU.Text += "<div class=""gb_img"">"

            strImg = flDic.PhotoURLFile(Me.UserInfo.Username, Me.PortalId)
            litU.Text += "<img alt=""Ảnh đại diện"" src=""" & strImg & "?h=48&w=48"">"
            litU.Text += "</div>"
            litU.Text += "</a>"
            litU.Text += "<div class=""gbUser none gb_v""></div>"
            litU.Text += "<div class=""gbUser none gb_u""></div>"
            litU.Text += "</div>"
            litU.Text += "<div id=""ariaUser"" class=""gb_w gb_qa none"">"
            litU.Text += "<div class=""gb_J"">"
            litU.Text += "<div>Tài khoản này được quản lý bởi <b>" & PortalSettings.PortalAlias.HTTPAlias & "</b>.</div>"
            litU.Text += "</div>"
            litU.Text += "<div class=""gb_z"">"
            litU.Text += "<a target=""_blank"" href=""" & strUrl & """ class=""gb_A gb_ec"">"

            litU.Text += "<img alt=""Ảnh đại diện"" src=""" & strImg & "?h=96&w=96"">"
            litU.Text += "<span class=""gb_C"">Thay đổi ảnh</span></a><div class=""gb_B"">"
            litU.Text += "<div class=""gb_D"">" & Me.UserInfo.DisplayName & "</div>"
            litU.Text += "<div class=""gb_E"">" & Me.UserInfo.Email & "</div>"
            litU.Text += "<div class=""gb_y"">"
            litU.Text += "<a target=""_blank"" href=""/" & _tabName & "/view/change-pass"">Đổi mật khẩu</a>"
            litU.Text += "</div>"
            litU.Text += "<a target=""_blank"" href=""/" & _tabName & "/view/profile-user"" class=""gb_bc gbp1 gb_a"">Tài khoản của tôi</a>"
            litU.Text += "</div>"
            litU.Text += "</div>"
            litU.Text += "<div class=""gb_F"">"
            litU.Text += "<div><a target=""_top"" href=""/home?ctl=logoff"" id=""gb_71"" class=""gb_cc gb_jc gb_a"">Đăng xuất</a></div>"
            litU.Text += "</div>"
            litU.Text += "</div>"
            litU.Text += "</div>"
            litU.Text += "</div>"
        End Sub
        Private Sub LoadMenu()
            _userName = flReg.RolesND(Me.PortalId, Me.UserInfo.Username, _tabName)
            arrTemp = flDnn.CMS_Module_List_Menu_Top(flConnect.DmConnect, _tabName, _userName, "")
            If arrTemp.Count > 0 Then
                litMenu.Text = "<ul>"
                For Each Cr As CMS_ModuleInfo In arrTemp
                    _viewTable = flReg.Decrypt("1", Cr.ModuleSrc)
                    litMenu.Text += "<li class='top-" & _viewTable & "'>"
                    If Cr.ctlView <> "" Then
                        litMenu.Text += "<a href=""/" & _tabName & "/view/" & _viewTable & """>" & Cr.ModuleName & "</a>"
                    Else
                        litMenu.Text += "<a href=""javascript::"">" & Cr.ModuleName & "</a>"
                    End If
                    arrTemp1 = flDnn.CMS_Module_List_Menu_Top(flConnect.DmConnect, _tabName, _userName, Cr.Module_ID)
                    If arrTemp1.Count > 0 Then
                        litMenu.Text += "<ul>"
                        For Each Ci As CMS_ModuleInfo In arrTemp1
                            _viewTable = flReg.Decrypt("1", Ci.ModuleSrc)
                            litMenu.Text += "<li><a href=""/" & _tabName & "/view/" & _viewTable & """>" & Ci.ModuleName & "</a></li>"
                        Next
                        litMenu.Text += "</ul>"
                    End If
                    litMenu.Text += "</li>"
                Next
                litMenu.Text += "</ul>"
            End If

        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                If Request.Item("nop-hs") & "" <> "" Then
                    Response.Redirect("/users/edit/us-works/itemid/" & WORK.flCheck.getWork_ID(Me.PortalId, WORK.flNotify.GetRequestId(Request.Item("nop-hs"))), True)
                ElseIf Request.Item("xem-nn") & "" <> "" Then
                    Response.Redirect("/business/edit/bus-jobuser/caid/" & Request.Item("xem-nn"), True)
                ElseIf Request.Item("vl") & "" <> "" Then
                    Response.Redirect("/business/view/" & Request.Item("vl"), True)
                End If
                ctlView.Visible = Me.EditMode
                Call LoadMenu()
                Call LoadValue()
                flCache.SetCache("profile_" & Me.UserInfo.Username, litU.Text)
                If ctlView.Visible = False Then
                    If Request.Item("view") = "profile-user" Then
                        pnFile.Visible = True
                    Else
                        Pnview.Visible = True
                    End If
                End If
                If Request.Item("view") = "bus-profile-user" Or Request.Item("view") = "bus-change-pass" Then Pnview.Visible = False
            End If
        End Sub

    End Class

End Namespace
