Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.Mar_DSMoiUV

    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arr1, arr2 As New ArrayList
        Dim liter As Literal, iTuyen As Integer
        Dim obj As New CMS_UngVienInfo

        Public Property PhienGD_ID() As String
            Get
                Return DSMoiUV_ItemID.Value
            End Get
            Set(ByVal value As String)
                DSMoiUV_ItemID.Value = value
            End Set
        End Property

        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Try
                PhienGD_ID = Request.Item("itemid")
                Call flFunction.LoadCareer(Me.PortalId, N_NganhNghe)
                Call flDic.LoadSex(N_GioiTinh)
                Call flDic.LoadEducation(Me.PortalId, N_ChuyenMon)
                Call LoadDoanhNghiep()
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Public Sub LoadValues()
            arrTemp = flDnn.DNN_UserConfig_List_By_Roles(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, DSMoiUV_Find.Text.Trim, DSMoiUV_currPage.Value, 35, flReg.GetRolesID(Me.PortalSettings.ActiveTab.TabName, "Nguoi lao dong"), 0)
            For Each Ck As CMS_UngVienInfo In objController.CMS_UngVien_List_PhienGD_ID(Me.PortalId, PhienGD_ID)
                For Each item As DnnInfo In arrTemp
                    If item.Username = Ck.NguoiTimViec_ID Then
                        arrTemp.Remove(item)
                        iTuyen += 1
                        Exit For
                    End If
                Next
            Next
            dgrDanhSachUngVien.DataSource = arrTemp
            dgrDanhSachUngVien.DataKeyField = "UserName"
            dgrDanhSachUngVien.PageSize = 35
            dgrDanhSachUngVien.DataBind()

            For Each Cr As DnnInfo In arrTemp
                Session.Item("DSMoiUV_" & PhienGD_ID) = Cr.Total - iTuyen
                litPage.Text = flReg.NextPageJs(Cr.Total, 35, 1, 10, "nextpage_uv(")
                Exit For
            Next
            Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
            If IsNothing(phInfo) = False Then
                If Now > phInfo.ThoiGian_KetThuc Then
                    cmdDSMoiUV_Active.Enabled = False
                End If
            End If
        End Sub
        Private Sub LoadDoanhNghiep()
            N_TenDN.Items.Clear()
            N_TenDN.Items.Add(New ListItem("- - Chọn doanh nghiệp cho ứng viên - -", ""))
            For Each Cr As CMS_BusinessInfo In objController.CMS_DoanhNghiep_List_Search(Me.PortalId, "", 1, 50, PhienGD_ID)
                N_TenDN.Items.Add(New ListItem(Cr.Business_Vn, Cr.DoanhNghiep_ID))
            Next
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles dgrDanhSachUngVien.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (dgrDanhSachUngVien.CurrentPageIndex * dgrDanhSachUngVien.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("Tel")
            liter.Text = flReg.Telephone(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "UserName"))

            liter = e.Item.FindControl("Email")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")

            liter = e.Item.FindControl("TenDayDu")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DisplayName")

            liter = e.Item.FindControl("UserName")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "UserName")

        End Sub
        Private Sub cmdDSMoiUV_Search_Click(sender As Object, e As EventArgs) Handles cmdDSMoiUV_Search.Click
            Call LoadValues()
        End Sub
        Private Sub cmdDSMoiUV_Active_Click(sender As Object, e As EventArgs) Handles cmdDSMoiUV_Active.Click
            Try
                Dim count As Integer
                Dim chBox As CheckBox
                For i As Integer = 0 To dgrDanhSachUngVien.Items.Count - 1
                    chBox = dgrDanhSachUngVien.Items(i).FindControl("IsCheck")
                    If chBox.Checked = True Then
                        obj = New CMS_UngVienInfo
                        obj.UngVien_ID = flReg.GenKey()

                        liter = dgrDanhSachUngVien.Items(i).FindControl("Email")
                        obj.Email = liter.Text

                        liter = dgrDanhSachUngVien.Items(i).FindControl("Tel")
                        obj.Tel = liter.Text

                        liter = dgrDanhSachUngVien.Items(i).FindControl("TenDayDu")
                        obj.TenDayDu = liter.Text

                        liter = dgrDanhSachUngVien.Items(i).FindControl("UserName")
                        obj.NguoiTimViec_ID = liter.Text

                        obj.LoaiUngVien = LoaiUngVien.DaDangKy
                        obj.NamKinhNghiem = 0
                        obj.NganhNghe = 0
                        obj.ViTriUngTuyen = ""
                        obj.TrinhDoChuyenMon = ""
                        obj.NgaySinh = flReg.DateNull
                        obj.CreatedBy = Now
                        obj.DiaChi = ""
                        obj.GioiTinh = -1
                        obj.PhienGD_ID = PhienGD_ID
                        objController.CMS_UngVien_Add(Me.PortalId, obj)
                        count = 1
                    End If
                Next
                If count = 1 Then
                    Call LoadValues()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting(); notify('success','Đã thêm ứng viên vào phiên thành công.', 'Thông báo', false);location.reload()", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', 'Bạn chưa chọn ứng viên nào để thêm vào phiên.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdDSMoiUV_Next_Click(sender As Object, e As EventArgs) Handles cmdDSMoiUV_Next.Click
            Call LoadValues()
        End Sub

    End Class

End Namespace