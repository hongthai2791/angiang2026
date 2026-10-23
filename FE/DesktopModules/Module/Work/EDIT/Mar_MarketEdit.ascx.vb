Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.Market.Work
    Partial Class Edit
        Inherits PortalModuleBase
        Dim Objcontroller As New WorkController
        Dim obj As New CMS_PhienGiaoDichInfo

        Private Sub LoadValue()
            obj = Objcontroller.CMS_PhienGiaoDich_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                TinhTP.SelectedValue = obj.TinhTP
                txtPhien.Text = obj.TenPhien
                txtDiaDiem.Text = obj.DiaDiem
                txtHotLine.Text = obj.Hotline
                chkOnline.Checked = obj.IsActive
                ddlLoaiSan.SelectedValue = obj.LoaiPhien
                txtChiTiet.Text = obj.MoTa
                txtBatDau.Text = flReg.ReadDate(obj.ThoiGian_BatDau)
                txtKetThuc.Text = flReg.ReadDate(obj.ThoiGian_KetThuc)

                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedBy)
                litUpdate.Text += " - bởi: " & obj.UserName & " - " & flReg.GetUserName(obj.UserName) & "</div>"
                If obj.UserUpdate <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedBy)
                    litUpdate.Text += " - bởi: " & obj.UserUpdate & " - " & flReg.GetUserName(obj.UserUpdate) & "</div>"
                End If
            End If
        End Sub
        Private Sub InitControls()
            ItemID.Value = Request.Item("itemid") & ""
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP)
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try

        End Sub

        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                obj = New CMS_PhienGiaoDichInfo
                obj.TinhTP = TinhTP.SelectedValue
                obj.PortalId = Me.PortalId
                obj.TenPhien = txtPhien.Text.Trim
                obj.DiaDiem = txtDiaDiem.Text.Trim
                obj.MoTa = txtChiTiet.Text.Trim
                obj.ThoiGian_BatDau = flReg.WriteDate(txtBatDau.Text)
                obj.ThoiGian_KetThuc = flReg.WriteDate(txtKetThuc.Text)
                obj.Hotline = txtHotLine.Text.Trim
                obj.IsActive = chkOnline.Checked
                obj.LoaiPhien = ddlLoaiSan.SelectedValue
                obj.Hotline = txtHotLine.Text
                obj.Email = ""
                obj.KetQua = ""
                obj.FileDinhKem = ""
                If ItemID.Value = "" Then
                    ItemID.Value = flReg.GenKey()
                    obj.PhienGD_ID = ItemID.Value
                    obj.CreatedBy = Now.Date
                    obj.UserName = Me.UserInfo.Username
                    obj.UpdatedBy = flReg.DateNull
                    obj.UserUpdate = ""
                    Objcontroller.CMS_PhienGiaoDich_Add(Me.PortalId, obj)
                Else
                    obj.PhienGD_ID = ItemID.Value
                    obj.CreatedBy = Now.Date
                    obj.UserName = Me.UserInfo.Username
                    obj.UpdatedBy = Now
                    obj.UserUpdate = Me.UserInfo.Username
                    Objcontroller.CMS_PhienGiaoDich_Update(Me.PortalId, obj)
                End If
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/mar-market-list", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try

        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/mar-market-list", True)
        End Sub
    End Class
End Namespace
