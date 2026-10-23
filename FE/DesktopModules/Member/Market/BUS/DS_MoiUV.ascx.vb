Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.DSMoiUV

    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arr1, arr2 As New ArrayList
        Dim liter As Literal, iTuyen As Integer
        Dim obj As New CMS_UngVienInfo
        Dim cbBox As CheckBox
        Public Property PhienGD_ID() As String
            Get
                Return DSMoiUV_ItemID.Value
            End Get
            Set(ByVal value As String)
                DSMoiUV_ItemID.Value = value
            End Set
        End Property
        Public Property Business_ID() As String
            Get
                Return hidBusiness_ID.Value
            End Get
            Set(ByVal value As String)
                hidBusiness_ID.Value = value
            End Set
        End Property
        Private Sub InitControls()
            Call LoadStatus()
            If Request.Item("sta") & "" <> "" Then drtrangthai.SelectedValue = Request.Item("sta")
        End Sub
        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Business_ID = Request.Item("busid") & ""
                PhienGD_ID = Request.Item("itemid") & ""
                Call InitControls()
                Call LoadTinTuyenDung()
                Call LoadValues()
            End If
        End Sub
        Private Sub LoadStatus()
            drtrangthai.Items.Clear()
            drtrangthai.Items.Add(New ListItem("- - Tình trạng- -", "0"))
            drtrangthai.Items.Add(New ListItem("Đã mời", 1))
            drtrangthai.Items.Add(New ListItem("Chưa mời", 2))
        End Sub
        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Try

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Public Sub LoadValues()
            arrTemp = objController.CMS_UngVien_List_PhienGD_ID(Me.PortalId, PhienGD_ID)
            If arrTemp.Count > 0 Then
                arr1 = objController.CMS_DoanhNghiep_UngVien_Get_By_Business(Me.PortalId, PhienGD_ID, Business_ID)
                For Each item As CMS_DoanhNghiep_UngVienInfo In arr1
                    For Each Cr As CMS_UngVienInfo In arrTemp
                        Session.Item("DS_MoiUV") = Cr.Total
                    Next
                Next
                If arr1.Count <= 0 Then
                    For Each Cr As CMS_UngVienInfo In arrTemp
                        Session.Item("DS_MoiUV") = Cr.Total
                        Exit For
                    Next
                End If
                Session.Item("DS_MoiUV") = Session.Item("DS_MoiUV") - iTuyen
                gdUv.DataSource = arrTemp
                gdUv.PageSize = arrTemp.Count + 1
                gdUv.DataKeyField = "UngVien_ID"
                gdUv.DataBind()
                gdUv.Visible = True
            Else
                litPage.Text = "Hiện tại chưa có ứng viên tham gia sàn!"
                Session.Item("DS_MoiUV") = "0"
            End If

        End Sub
        Private Sub LoadTinTuyenDung()
            tinTuyenDung.Items.Clear()
            tinTuyenDung.Items.Add(New ListItem("- - - Chọn tin tuyển dụng - - -"))
            For Each Cr As CMS_WorkInfo In objController.CMS_TuyenDung_List_Search(Me.PortalId, "", PhienGD_ID, Business_ID, 1)
                tinTuyenDung.Items.Add(New ListItem(flCheck.Work_Name("", 0, Cr.Work_ID), Cr.TuyenDung_ID))
            Next
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles gdUv.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            liter = e.Item.FindControl("Tel")
            If DataBinder.Eval(e.Item.DataItem, "Tel") = "" And DataBinder.Eval(e.Item.DataItem, "LoaiUngVien") = LoaiUngVien.DaDangKy Then
                liter.Text = flReg.Telephone(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "NguoiTimViec_ID"))
            Else
                liter.Text = DataBinder.Eval(e.Item.DataItem, "Tel")
            End If

            liter = e.Item.FindControl("Email")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")
            liter = e.Item.FindControl("TenDayDu")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "TenDayDu")
            liter = e.Item.FindControl("TrangThai")
            cbBox = e.Item.FindControl("IsCheck")
            If flCheck.SVL_TinhTrangUngVien(Me.PortalId, PhienGD_ID, tinTuyenDung.SelectedValue, DataBinder.Eval(e.Item.DataItem, "NguoiTimViec_ID")) Then
                cbBox.Enabled = True
                liter.Text = "<span class='label label-info' >Chưa mời</span"
            Else
                cbBox.Enabled = False
                liter.Text = "<span class='label label-success' >Đã mời</span"
            End If

            liter = e.Item.FindControl("IsOrder")
            liter.Text = e.Item.ItemIndex + 1

        End Sub
        Private Sub tinTuyenDung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdDSMoiUV_Next.Click, tinTuyenDung.SelectedIndexChanged, drtrangthai.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeURL", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        Public Sub ActiveUV(sender As Object, e As CommandEventArgs) Handles cmdDSMoiUV_Active.Command
            If e.CommandName = "InviteUV" Then
                Try
                    If tinTuyenDung.SelectedValue = "" Or tinTuyenDung.SelectedValue = "- - - Chọn tin tuyển dụng - - -" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('warning', 'Bạn chưa chọn tin tuyển dụng để mời ứng viên.', 'Thông báo', false);", True)
                        Exit Sub
                    End If
                    Dim count As Integer
                    Dim chBox As CheckBox
                    Dim duvInfo As New CMS_DoanhNghiep_UngVienInfo
                    'Dim objI As New CMS_JobInviteInfo
                    For i As Integer = 0 To gdUv.Items.Count - 1
                        chBox = gdUv.Items(i).FindControl("IsCheck")
                        If chBox.Checked = True Then
                            duvInfo = New CMS_DoanhNghiep_UngVienInfo
                            duvInfo.DNUV_ID = flReg.GenKey
                            duvInfo.PhienGD_ID = PhienGD_ID
                            duvInfo.DoanhNghiep_ID = Request.Item("dn")
                            duvInfo.UngVien_ID = gdUv.DataKeys(i)
                            duvInfo.BanPhongVan = flCheck.SoBan(0, PhienGD_ID, Business_ID)
                            duvInfo.TinhTrangPhongVan = 0
                            duvInfo.KetQuaPhongVan = 5
                            duvInfo.ChiTietPhongVan = ""
                            duvInfo.ThuTuPhongVan = 0
                            duvInfo.TuyenDung_ID = tinTuyenDung.SelectedValue
                            duvInfo.TuyenDungName = tinTuyenDung.SelectedItem.Text
                            duvInfo.ViTriDat = ""
                            duvInfo.ViTriDatName = ""
                            duvInfo.CreatedBy = Now
                            duvInfo.UserName = Me.UserInfo.Username
                            duvInfo.UpdatedBy = flReg.DateNull
                            duvInfo.UserUpdate = ""
                            duvInfo.IsStatus = 1
                            objController.CMS_DoanhNghiep_UngVien_Add(Me.PortalId, duvInfo)
                            count = 1
                        End If
                    Next
                    If count = 1 Then
                        Call LoadValues()
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting(); notify('success','Đã mời ứng viên tham gia phỏng vấn.', 'Thông báo', false);", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', 'Bạn chưa chọn ứng viên nào để mời phỏng vấn.', 'Thông báo', false);", True)
                    End If
                Catch ex As SqlClient.SqlException
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End Try
            End If
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit")
            RedirectURL += "/itemid/" & Request.Item("itemid")
            RedirectURL += "/busid/" & Request.Item("busid")
            RedirectURL += "/dn/" & Request.Item("dn")
            If drtrangthai.SelectedValue <> "-1" Then RedirectURL += "/sta/" & drtrangthai.SelectedValue
        End Function

    End Class

End Namespace