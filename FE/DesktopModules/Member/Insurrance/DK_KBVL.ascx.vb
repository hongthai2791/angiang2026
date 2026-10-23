Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_NotificationInfo
        Dim dbj As New EXE_NotificationDInfo
        Dim tbox As TextBox, arr As New ArrayList
        Private Sub LoadValue()
            obj = objController.EXE_Notification_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                If obj.TrangThai <> TrangThaiHS.TraLai Then Response.Redirect("/", True)
                drPortal.SelectedValue = obj.PortalID
                drPortal.Enabled = False
                NoCode.Value = obj.NoCode

                ThangHuong.Text = obj.ThangHuong
                HoTen.Text = flReg.RemoveScript(obj.HoTen, False)
                Email.Text = flReg.RemoveScript(obj.Email, False)
                NgaySinh.Text = flReg.ReadDate(obj.NgaySinh, False)
                GioiTinh.SelectedValue = obj.GioiTinh
                SoCMND.Text = flReg.RemoveScript(obj.SoCMND, False)
                NgayCap.Text = flReg.ReadDate(obj.NgayCap, False)
                NoiCap.Text = flReg.RemoveScript(obj.NoiCap, False)
                DienThoai.Text = flReg.RemoveScript(obj.DienThoai, False)
                CO_TinhTP.SelectedValue = obj.CO_TinhTP

                Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
                CO_QuanHuyen.SelectedValue = obj.CO_QuanHuyen

                Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phương - -")
                CO_XaPhuong.SelectedValue = obj.CO_XaPhuong

                CO_DuongPho.Text = flReg.RemoveScript(obj.CO_DuongPho, False)
                QD_So.Text = flReg.RemoveScript(obj.QD_So, False)
                QD_Ngay.Text = flReg.ReadDate(obj.QD_Ngay, False)
                QD_TuNgay.Text = flReg.ReadDate(obj.QD_TuNgay, False)
                QD_DenNgay.Text = flReg.ReadDate(obj.QD_DenNgay, False)
                QD_ThangHuong.Text = obj.QD_ThangHuong
                QD_TinhTP.SelectedValue = obj.QD_TinhTP
                TinhTrang.Checked = obj.TinhTrang
                NeuCoVL.Text = flReg.RemoveScript(obj.NeuCoVL, False)
                TT_Khac.Text = flReg.RemoveScript(obj.TT_Khac, False)

                arr = objController.EXE_NotificationD_Get_By_EXE_Notification(Me.PortalId, ItemID.Value)
                If arr.Count = 0 Then Call AddRows(3, arr)
                grdData.DataSource = arr
                grdData.PageSize = arr.Count + 1
                grdData.DataKeyField = "NotificationD_ID"
                grdData.DataBind()
            Else
                arr = New ArrayList
                Call AddRows(3, arr)
                grdData.DataSource = arr
                grdData.DataKeyField = "NotificationD_ID"
                grdData.DataBind()

                drPortal.SelectedValue = flReg.WebConfig("TinhTP")
            End If
        End Sub
        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            drPortal.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flDic.LoadRegional_Parent_Null(0, CO_TinhTP)
            CO_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))
            Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")

            Call flDic.LoadRegional_Parent_Null(0, QD_TinhTP)
            QD_TinhTP.SelectedValue = flReg.WriteNumber(Request.Item("pid"))

            Call flFunction.LoadGioiTinh(GioiTinh)
            Call flDic.LoadPlace(0, NoiCap)

            ItemID.Value = Request.Item("itemid")
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
                obj = New EXE_NotificationInfo

                obj.ThangHuong = flReg.WriteNumber(ThangHuong.Text)
                    obj.HoTen = flReg.RemoveScript(HoTen.Text.ToUpper.Trim())
                    obj.Email = flReg.RemoveScript(Email.Text.Trim())
                    obj.NgaySinh = flReg.WriteDate(NgaySinh.Text, False)
                    obj.GioiTinh = GioiTinh.SelectedValue
                    obj.SoCMND = flReg.RemoveScript(SoCMND.Text.Trim())
                    obj.NgayCap = flReg.WriteDate(NgayCap.Text, False)
                    obj.NoiCap = flReg.RemoveScript(NoiCap.Text.Trim())
                    obj.DienThoai = flReg.RemoveScript(DienThoai.Text.Trim())
                    obj.CO_TinhTP = CO_TinhTP.SelectedValue
                    obj.CO_QuanHuyen = CO_QuanHuyen.SelectedValue
                    obj.CO_XaPhuong = CO_XaPhuong.SelectedValue
                    obj.CO_DuongPho = flReg.RemoveScript(CO_DuongPho.Text.Trim())
                    obj.QD_So = flReg.RemoveScript(QD_So.Text)
                    obj.QD_Ngay = flReg.WriteDate(QD_Ngay.Text, False)
                    obj.QD_TuNgay = flReg.WriteDate(QD_TuNgay.Text, False)
                    obj.QD_DenNgay = flReg.WriteDate(QD_DenNgay.Text, False)
                    obj.QD_ThangHuong = flReg.WriteNumber(QD_ThangHuong.Text)
                    obj.QD_TinhTP = QD_TinhTP.SelectedValue
                    obj.TinhTrang = TinhTrang.Checked
                    obj.NeuCoVL = flReg.RemoveScript(NeuCoVL.Text.Trim())
                    obj.TT_Khac = flReg.RemoveScript(TT_Khac.Text.Trim())
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
                        obj.Notification_ID = ItemID.Value
                        obj.NoCode = NoCode.Value
                        obj.UpdatedDate = Now
                        obj.UpdatedUser = "Guest"
                        objController.EXE_Notification_Update(drPortal.SelectedValue, obj)
                        objController.EXE_Notification_Update_TrangThai(drPortal.SelectedValue, ItemID.Value, TrangThaiHS.DaNop, Now, "Guest", "")
                    Else
                        obj.Notification_ID = flReg.GenKey()
                        obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.KBVL)
                        obj.UpdatedDate = flReg.DateNull
                        obj.UpdatedUser = ""
                        objController.EXE_Notification_Add(drPortal.SelectedValue, obj)
                    End If

                    Call SaveNotiD(obj.Notification_ID)
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Nộp hồ sơ thành công', 'Thông báo', false);", True)


            Catch ex As Exception
            End Try
        End Sub
        Private Sub CO_TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CO_TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CO_QuanHuyen, CO_TinhTP.SelectedValue, "- - Quận/ Huyện - -")
            CO_XaPhuong.Items.Clear()
            'CO_QuanHuyen.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub CO_QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CO_QuanHuyen.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(0, CO_XaPhuong, CO_QuanHuyen.SelectedValue, "- - Xã/ Phường - -")
            'CO_XaPhuong.Focus()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/", True)
        End Sub
        Private Sub AddRows(j As Integer, arrA As ArrayList)
            For i As Integer = 1 To j
                dbj = New EXE_NotificationDInfo
                dbj.NotificationD_ID = flReg.GenKey()
                dbj.TenDonVi = ""
                dbj.DiaChi = ""
                dbj.NguoiLienHe = ""
                dbj.ViTriDuTuyen = ""
                dbj.KetQua = ""
                dbj.IsOrder = grdData.Items.Count + i
                arrA.Add(dbj)
            Next
        End Sub
        Private Function GetNotiD() As ArrayList
            GetNotiD = New ArrayList
            For Each Item As DataGridItem In grdData.Items
                dbj = New EXE_NotificationDInfo
                dbj.NotificationD_ID = grdData.DataKeys(Item.ItemIndex)

                tbox = Item.FindControl("TenDonVi")
                dbj.TenDonVi = tbox.Text.Trim()

                tbox = Item.FindControl("DiaChi")
                dbj.DiaChi = tbox.Text.Trim()

                tbox = Item.FindControl("NguoiLienHe")
                dbj.NguoiLienHe = tbox.Text.Trim()

                tbox = Item.FindControl("ViTriDuTuyen")
                dbj.ViTriDuTuyen = tbox.Text.Trim()

                tbox = Item.FindControl("KetQua")
                dbj.KetQua = tbox.Text.Trim()

                tbox = Item.FindControl("IsOrder")
                dbj.IsOrder = tbox.Text.Trim()

                GetNotiD.Add(dbj)
            Next
        End Function
        Private Sub SaveNotiD(NotiID As String)
            For Each Cr As EXE_NotificationDInfo In GetNotiD()
                If Cr.TenDonVi <> "" Then
                    Cr.Notification_ID = NotiID
                    objController.EXE_NotificationD_Add(drPortal.SelectedValue, Cr)
                Else
                    objController.EXE_NotificationD_Delete(drPortal.SelectedValue, Cr.NotificationD_ID)
                End If
            Next
        End Sub
        Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
            arr = GetNotiD()
            Call AddRows(1, arr)
            grdData.DataSource = arr
            grdData.PageSize = arr.Count + 1
            grdData.DataKeyField = "NotificationD_ID"
            grdData.DataBind()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMask", "BindMask();", True)
        End Sub
        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            tbox = e.Item.FindControl("IsOrder")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "IsOrder")

            tbox = e.Item.FindControl("KetQua")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "KetQua")

            tbox = e.Item.FindControl("ViTriDuTuyen")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "ViTriDuTuyen")

            tbox = e.Item.FindControl("NguoiLienHe")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "NguoiLienHe")

            tbox = e.Item.FindControl("DiaChi")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "DiaChi")

            tbox = e.Item.FindControl("TenDonVi")
            tbox.Text = DataBinder.Eval(e.Item.DataItem, "TenDonVi")
        End Sub
    End Class
End Namespace

