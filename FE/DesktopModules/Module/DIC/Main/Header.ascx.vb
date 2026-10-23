Imports DotNetNuke.EPORTAL

Namespace Modules.Main
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim strImg, strUrl As String
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim _userName As String = Me.UserInfo.Username
        Public _tabName As String = PortalSettings.ActiveTab.TabName
        Public _SystemName As String = PortalSettings.ActiveTab.Title
        Dim _viewTable As String

        Private Sub LoadValue()
            litU.Text = "<div class=""gb_Zc gb_r"">"
            litU.Text += "<div class=""gb_na gb_8"">"
            litU.Text += "<div class=""gb_Mg"">"
            If Me.UserInfo.Username = "host" Then
                litU.Text += "<a href=""/" & _tabName & "/view/module"" title=""Thiết lập module"">"
                litU.Text += "<img alt=""Module"" src=""/image/images/module-white.png"">"
                litU.Text += "</a>&nbsp;&nbsp;&nbsp;&nbsp;"
            End If
            If _tabName = "app" Then
                litU.Text += "<a href=""/" & _tabName & "/view/notify-list"" title=""Thông báo"">"
                litU.Text += "<i class=""fa fa-bell vibrate-noti"" aria-hidden=""true""></i>"
                litU.Text += "</a>&nbsp;&nbsp;"
            End If
            litU.Text += "</div>"
            litU.Text += "<div class=""gb_Lc"">"

            strUrl = "/profiles/userid/" & Me.UserId & "/pageno/1"

            'litU.Text += "<a href=""" & strUrl & """ rel=""nofollow"" title=""Thông tin tài khoản"">"
            'litU.Text += Me.UserInfo.DisplayName & "</a>"

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
            litU.Text += "<a target=""_blank"" href=""/profiles/userid/" & Me.UserId & "/pageno/2/"">Đổi mật khẩu</a>"
            litU.Text += "</div>"
            litU.Text += "<a target=""_blank"" href=""/profiles/userid/" & Me.UserId & "/pageno/1/"" class=""gb_bc gbp1 gb_a"">Tài khoản của tôi</a>"
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

            If Me.PortalId = 7 Then
                litMenu.Text = ""
                Return
            End If
            _userName = flReg.RolesND(Me.PortalId, Me.UserInfo.Username, _tabName)

            litMenu.Text = "<ul>"
            arrTemp = flDnn.CMS_Module_List_Menu_Top(flConnect.DmConnect, _tabName, _userName, "")
            If arrTemp.Count > 0 Then
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
            End If
            litMenu.Text += "<li class='top-system'>"
            litMenu.Text += "<a title='Di chuyển nhanh'  href='/system'><i class='fa fa-cube' style='line-height: 45px;font-Size:20px;padding: 0 20px;'></i></a>"
            litMenu.Text += "<ul>"

            Dim obj As New EPORTAL.CMSUserPortalInfo
            If Me.UserInfo.Username = "host" Then
                For Each Cr As EPORTAL.CMS_SubModInfo In EPORTAL.flDnn.CMS_SubMod_List(Me.PortalId)
                    litMenu.Text += "<li><a href=""/" & Cr.SubMod_Path & """>" & Cr.SubMod_Name & "</a></li>"
                Next
            Else
                For Each Cr As EPORTAL.CMS_SubModInfo In EPORTAL.flDnn.CMS_SubMod_List(Me.PortalId)
                    obj = EPORTAL.flDnn.CMSUserPortal_Get_By_User("", Me.UserInfo.Username, Cr.SubMod_Path, Me.PortalId)
                    If IsNothing(obj) = False Then
                        litMenu.Text += "<li><a href=""/" & Cr.SubMod_Path & """>" & Cr.SubMod_Name & "</a></li>"
                    End If
                Next
            End If
            litMenu.Text += "</ul>"
            litMenu.Text += "</li>"
            litMenu.Text += "</ul>"

        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    ctlView.Visible = Me.EditMode
                    Call LoadMenu()
                    Call LoadValue()
                    flCache.SetCache("profile_" & Me.UserInfo.Username, litU.Text)
                    If ctlView.Visible = False Then Pnview.Visible = True
                End If
            Catch ex As Exception
                litMenu.Text = ex.Message
            End Try

        End Sub

    End Class

End Namespace
