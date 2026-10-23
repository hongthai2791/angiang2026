Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace Modules.HTHN
    Partial Class Edit
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_ApprenticeInfo
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Public _pid As Integer
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadReligion(0, TonGiao)
            Call flDic.LoadPlace(0, NoiCap)

            ItemID.Value = Request.Item("itemid")
            _pid = flReg.WriteNumber(Request.Item("pid"))
        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_Apprentice_Get(_pid, ItemID.Value)
            If IsNothing(obj) = False Then
                drPortal.SelectedValue = obj.PortalID
                Call flFunction.LoadTraining(drPortal.SelectedValue, CoSoDT)
                CoSoDT.SelectedValue = obj.CoSoDT
                NoCode.Text = "<span class='hdh-span'>Mã HS: </span><span class='apid-span'>" & obj.NoCode & "</span>"

                HoTen.Text = flReg.RemoveScript(obj.HoTen, False)
                NgaySinh.Text = flReg.ReadDate(obj.NgaySinh, False)
                GioiTinh.SelectedValue = obj.GioiTinh
                SoCMND.Text = flReg.RemoveScript(obj.SoCMND, False)
                NgayCap.Text = flReg.ReadDate(obj.NgayCap, False)
                NoiCap.Text = flReg.RemoveScript(obj.NoiCap, False)
                SoBHXH.Text = flReg.RemoveScript(obj.SoBHXH, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                DienThoai.Text = flReg.RemoveScript(obj.DienThoai, False)
                DanToc.SelectedValue = obj.DanToc
                TonGiao.SelectedValue = obj.TonGiao
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong
                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)
                ThangDong.Text = obj.ThangDong
                ThangHuong.Text = obj.ThangHuong
                QDH_So.Text = flReg.RemoveScript(obj.QDH_So, False)
                QDH_TuNgay.Text = flReg.ReadDate(obj.QDH_TuNgay, False)
                QDH_DenNgay.Text = flReg.ReadDate(obj.QDH_DenNgay, False)
                KhoaDT.SelectedValue = obj.KhoaDT
                ThoiGianDT.Text = obj.ThoiGianDT
                HocPhi.Text = obj.HocPhi

                If obj.DuongDanDK <> "" Then
                    litUp.Text = "<div class=""download""><a target=""_blank"" href=""" & obj.DuongDanDK & """ title=""Tải xuống"">"
                    litUp.Text += "<img src=""/image/images/download.png"" alt=""Tải xuống"" /></a><div><span class=""dname"">" & obj.TenTepDK & "</div></div>"
                End If

                If obj.TrangThai <> TrangThaiHS.DaNop Then
                    cmdActive.Visible = False
                    cmdReturn.Visible = False
                End If
            End If
            ViewState("backUrl") = "/" & _tabName & "/view/" & Request.Item("edit") & "/pid/" & drPortal.SelectedValue
        End Sub
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InnitController()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                objController.EXE_Apprentice_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.TiepNhan, Now, Me.UserInfo.Username, "")
                objController.EXE_Apprentice_Update_TrangThai(Me.PortalId, ItemID.Value, TrangThaiHS.ChuyenXuLy, Now, Me.UserInfo.Username, "")

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã tiếp nhận và chuyển xử lý hồ sơ thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace

