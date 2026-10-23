Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.Mar_DNMoiTG
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim dnInfo As New CMS_DoanhNghiepInfo
        Dim phInfo As New CMS_PhienGiaoDichInfo
        Dim liter As Literal, count As Integer
        Dim chBox As CheckBox
        Dim buID As HiddenField
        Private Sub InitControls()
            Call LoadStatus()
            If Request.Item("sta") & "" <> "" Then drtrangthai.SelectedValue = Request.Item("sta")
            If Request.Item("pa") & "" <> "" Then
                DNMoiTG_currPage.Value = Request.Item("pa")
            Else
                DNMoiTG_currPage.Value = 1
            End If
            Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, DNMoiTG_ItemID.Value)
            If IsNothing(phInfo) = False Then
                If Now > phInfo.ThoiGian_KetThuc Then
                    cmdDNMoiTG_Add.Enabled = False
                    cmdDNMoiTG_Email.Enabled = False
                End If
            End If
        End Sub
        Private Sub LoadStatus()
            drtrangthai.Items.Clear()
            drtrangthai.Items.Add(New ListItem("- - Tình trạng- -", 0))
            drtrangthai.Items.Add(New ListItem("Đã gửi thư mời", 1))
            drtrangthai.Items.Add(New ListItem("Chưa gửi thư mời", 2))
        End Sub
        Private Sub LoadValue()
            arrTemp = objController.CMS_Business_List_SVL_QT(Me.PortalId, DNMoiTG_Find.Text.Trim, DNMoiTG_currPage.Value, 35, DNMoiTG_ItemID.Value, drtrangthai.SelectedValue)
            grdData.DataSource = arrTemp
            grdData.PageSize = 35
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            litPage.Text = ""
            For Each Cr As CMS_BusinessInfo In arrTemp
                Session.Item("DNMoiTG_" & DNMoiTG_ItemID.Value) = Cr.Total
                litPage.Text = flReg.NextPageJs(Cr.Total, 35, DNMoiTG_currPage.Value, 10, "nexttab2(")
                Exit For
            Next
        End Sub

        Private Sub ThemVaoPhien()
            phInfo = objController.CMS_PhienGiaoDich_Get(Me.PortalId, DNMoiTG_ItemID.Value)
            If IsNothing(phInfo) = False Then
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsCheck")
                    If chBox.Checked = True Then
                        buID = grdData.Items(i).FindControl("Business_ID")

                        dnInfo = New CMS_DoanhNghiepInfo
                        dnInfo.DoanhNghiep_ID = flReg.GenKey()
                        dnInfo.Business_ID = buID.Value
                        dnInfo.PhienGD_ID = DNMoiTG_ItemID.Value
                        dnInfo.GioBatDau = phInfo.ThoiGian_BatDau
                        dnInfo.GioKetThuc = phInfo.ThoiGian_KetThuc
                        dnInfo.UserName = Me.UserInfo.Username
                        dnInfo.CreatedBy = Now
                        dnInfo.FileDinhKem = ""
                        dnInfo.SoBan = 0
                        dnInfo.UpdatedBy = flReg.DateNull
                        dnInfo.UserName = ""
                        dnInfo.TinhTrangThamGia = 1
                        objController.CMS_DoanhNghiep_Add(Me.PortalId, dnInfo)
                        count = 1
                        Session.Item("DNMoiTG_" & DNMoiTG_ItemID.Value) = Session.Item("DNMoiTG_" & DNMoiTG_ItemID.Value) + 1
                    End If

                Next

            End If

        End Sub
        Private Sub SendMail(email As String, buID As String, phien As CMS_PhienGiaoDichInfo)
            Dim subject As String = "VL-" & flDic.Regional_Name(Me.PortalId, phien.TinhTP) & ": Sàn giao dịch việc làm."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào Quý đơn vị</p>"
            body += "<p>Trung tâm dịch vụ việc làm: Mở phiên giao dịch việc làm: <b>" & phien.TenPhien & "</b></p>"
            body += "<p>Thời gian diễn ra từ ngày: <b>" & phien.ThoiGian_BatDau & "</b></p>"
            body += "<p>Đến hết ngày: <b>" & phien.ThoiGian_KetThuc & "</b></p>"
            body += "<p>Kính mời Quý đơn vị tham gia, để lựa chọn được những ứng viên tiêu biểu nhất, phù hợp với nhu cầu tuyển dụng của đơn vị</p>"
            body += "<p><i>Để biết thêm thông tin chi tiết về phiên giao dịch vui lòng liên hệ với trung tâm để được hỗ trợ.</i></p><p></p>"

            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị</div>"
            flDnn.DNN_SendMail(email, subject, body)
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("ContactUser")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactUser")
            liter = e.Item.FindControl("TaxCode")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "TaxCode")

            buID = e.Item.FindControl("Business_ID")
            buID.Value = DataBinder.Eval(e.Item.DataItem, "Business_ID")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")
            chBox = e.Item.FindControl("IsCheck")
            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")
            liter = e.Item.FindControl("Trangthai")
            If flReg.ToBoolean(DataBinder.Eval(e.Item.DataItem, "IsInvite")) = True Then
                chBox.Enabled = True
                liter.Text = "<span class='label label-success' >Đã gửi thư mời</span"
            Else
                chBox.Enabled = True
                liter.Text = "<span class='label label-info' style=""background-color: #828a86 !important;"">Chưa gửi thư mời</span"
            End If
            liter = e.Item.FindControl("Business_Vn")
            If DataBinder.Eval(e.Item.DataItem, "Logo") & "" <> "" Then
                liter.Text = "<img align=""absmiddle"" style=""padding-right:5px;"" src=""" & flConnect.fileDomain & DataBinder.Eval(e.Item.DataItem, "Logo") & "?w=24&h=24"" />"
                liter.Text += flReg.RemoveScript(DataBinder.Eval(e.Item.DataItem, "Business_Vn"), False)
            Else
                liter.Text = flReg.RemoveScript(DataBinder.Eval(e.Item.DataItem, "Business_Vn"), False)
            End If
        End Sub
        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    DNMoiTG_ItemID.Value = Request.Item("itemid")
                    DNMoiTG_currPage.Value = flReg.WriteNumber(Request.Item("p") & "")
                    If DNMoiTG_currPage.Value = "0" Then DNMoiTG_currPage.Value = "1"

                    Call InitControls()
                    Call LoadValue()
                End If

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdDNMoiTG_Search_Click(sender As Object, e As EventArgs) Handles cmdDNMoiTG_Search.Click, drtrangthai.SelectedIndexChanged
            DNMoiTG_currPage.Value = "1"
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeURL", "changeUrl('" & RedirectURL() & "');", True)
            'Call LoadValue()
        End Sub

        Private Sub cmdDNMoiTG_Add_Click(sender As Object, e As EventArgs) Handles cmdDNMoiTG_Add.Click

            Try
                count = 0
                Call ThemVaoPhien()
                If count = 1 Then
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã thêm doanh nghiệp vào phiên thành công.', 'Thông báo', false);location.reload()", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Bạn chưa chọn doanh nghiệp nào để thêm vào phiên.', 'Thông báo', false);", True)
                End If

            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                DNMoiTG_ItemID.Value = Request.Item("itemid")
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            RedirectURL += "/itemid/" & Request.Item("itemid")
            If drtrangthai.SelectedValue <> "-1" Then RedirectURL += "/sta/" & drtrangthai.SelectedValue
            If DNMoiTG_currPage.Value <> "-1" Then RedirectURL += "/pa/" & DNMoiTG_currPage.Value

        End Function
        Private Sub cmdDNMoiTG_Next_Click(sender As Object, e As EventArgs) Handles cmdDNMoiTG_Next.Click
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValue()
        End Sub
        Private Sub cmdDNMoiTG_Email_Click(sender As Object, e As EventArgs) Handles cmdDNMoiTG_Email.Click
            Dim icount As Integer = 0

            phInfo = objController.CMS_PhienGiaoDich_Get(Me.PortalId, DNMoiTG_ItemID.Value)
            If IsNothing(phInfo) = False Then
                For i = 0 To grdData.Items.Count - 1
                    If objController.CMS_SendMail_Check(Me.PortalId, grdData.DataKeys(i), DNMoiTG_ItemID.Value) = False Then
                        chBox = grdData.Items(i).FindControl("IsCheck")
                        If chBox.Checked = True Then
                            Dim obj As New CMS_SendMailInfo
                            If IsNothing(obj) = False Then
                                obj.DoanhNghiep_ID = grdData.DataKeys(i)
                                obj.PhienGD_ID = DNMoiTG_ItemID.Value
                                obj.NgayGui = Now
                                objController.CMS_SendMail_Add(Me.PortalId, obj)
                                SendMail(flCheck.Business_Email(Me.PortalId, grdData.DataKeys(i)), grdData.DataKeys(i), phInfo)
                            End If
                            icount += 1
                        End If
                    End If
                Next
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('success', 'Đã gửi thư mời thành công tới " & icount & " doanh nghiệp!', 'Thông báo', false);", True)
            Call LoadValue()
        End Sub
    End Class
End Namespace
