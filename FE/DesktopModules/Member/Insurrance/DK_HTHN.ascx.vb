Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_ApprenticeInfo
        Dim sFileType As String

        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            drPortal.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            CO_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))
            Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_TinhTP.SelectedValue, "- - Phường/ xã- -")

            Call flDic.LoadNation(0, DanToc)
            Call flDic.LoadReligion(0, TonGiao)
            Call flDic.LoadPlace(0, NoiCap)

            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flFunction.LoadTraining(drPortal.SelectedValue, CoSoDT)
            ItemID.Value = Request.Item("itemid")
        End Sub
        Private Sub LoadValue()
            obj = objController.EXE_Apprentice_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                If obj.TrangThai <> TrangThaiHS.TraLai Then Response.Redirect("/", True)
                drPortal.SelectedValue = obj.PortalID
                drPortal.Enabled = False
                NoCode.Value = obj.NoCode

                Call flFunction.LoadTraining(drPortal.SelectedValue, CoSoDT)
                CoSoDT.SelectedValue = obj.CoSoDT

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


                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_TinhTP.SelectedValue, "- - Phường/Xã - -")
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

            Else

                drPortal.SelectedValue = flReg.WebConfig("TinhTP")
            End If
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
        Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
            Try
                obj = New EXE_ApprenticeInfo

                obj.HoTen = flReg.RemoveScript(HoTen.Text.ToUpper.Trim())
                obj.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                obj.GioiTinh = GioiTinh.SelectedValue
                obj.SoCMND = flReg.RemoveScript(SoCMND.Text.Trim())
                obj.NgayCap = flReg.WriteDate(NgayCap.Text, False)
                obj.NoiCap = flReg.RemoveScript(NoiCap.Text.Trim())
                obj.SoBHXH = flReg.RemoveScript(SoBHXH.Text.Trim())
                obj.Email = flReg.RemoveScript(Email.Text.Trim())
                obj.DienThoai = flReg.RemoveScript(DienThoai.Text.Trim())
                obj.DanToc = DanToc.SelectedValue
                obj.TonGiao = TonGiao.SelectedValue
                obj.CO_TinhTP = CO_TinhTP.SelectedValue
                obj.CO_QuanHuyen = 0
                obj.CO_XaPhuong = CO_XaPhuong.SelectedValue
                obj.CO_DuongPho = flReg.RemoveScript(CO_DuongPho.Text.Trim())
                obj.ThangDong = flReg.WriteNumber(ThangDong.Text)
                obj.ThangHuong = flReg.WriteNumber(ThangHuong.Text)
                obj.QDH_So = flReg.RemoveScript(QDH_So.Text)
                obj.QDH_TuNgay = flReg.WriteDate(QDH_TuNgay.Text, False)
                obj.QDH_DenNgay = flReg.WriteDate(QDH_DenNgay.Text, False)
                obj.CoSoDT = CoSoDT.SelectedValue
                obj.KhoaDT = KhoaDT.SelectedValue
                obj.ThoiGianDT = flReg.WriteNumber(ThoiGianDT.Text)
                obj.HocPhi = flReg.WriteNumber(HocPhi.Text)
                obj.PortalID = drPortal.SelectedValue
                obj.TrangThai = TrangThaiHS.DaNop
                obj.NgayNopHS = Now
                obj.NgayTiepNhan = flReg.DateNull
                obj.NguoiTiepNhan = ""
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = flReg.DateNull
                obj.UpdatedUser = ""

                If ItemID.Value <> "" Then
                    obj.Apprentice_ID = ItemID.Value
                    obj.NoCode = NoCode.Value
                    obj.UpdatedDate = Now
                    obj.UpdatedUser = "Guest"
                    objController.EXE_Apprentice_Update(drPortal.SelectedValue, obj)
                    objController.EXE_Apprentice_Update_TrangThai(drPortal.SelectedValue, ItemID.Value, TrangThaiHS.DaNop, Now, "Guest", "")
                Else
                    obj.Apprentice_ID = flReg.GenKey()
                    obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.HTHN)
                    obj.UpdatedDate = flReg.DateNull
                    obj.UpdatedUser = ""
                    objController.EXE_Apprentice_Add(drPortal.SelectedValue, obj)
                End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Nộp hồ sơ thành công', 'Thông báo', false);", True)

            Catch ex As Exception
            End Try
        End Sub
        Private Sub CO_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CO_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_TinhTP.SelectedValue, "- - Phường/ xã- -")
            CO_XaPhuong.Items.Clear()
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/", True)
        End Sub
        Private Sub drPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drPortal.SelectedIndexChanged
            Call flFunction.LoadTraining(drPortal.SelectedValue, CoSoDT)
            KhoaDT.Items.Clear()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub CoSoDT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoSoDT.SelectedIndexChanged
            Call flFunction.LoadCourse(drPortal.SelectedValue, KhoaDT, CoSoDT.SelectedValue)
            'KhoaDT.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
    End Class
End Namespace

