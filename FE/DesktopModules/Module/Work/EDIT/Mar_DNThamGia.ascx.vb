Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.DNThamGia
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim liter As Literal, count As Integer
        Dim chBox As CheckBox, tBox As TextBox
        Private Sub LoadValue()
            arrTemp = objController.CMS_DoanhNghiep_List_Search(Me.PortalId, DNThamGia_Find.Text.Trim,
                                                                DNThamGia_currPage.Value, 35, DNThamGia_ItemID.Value)
            grdData.DataSource = arrTemp
            grdData.PageSize = 35
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            litPage.Text = ""
            For Each Cr As CMS_BusinessInfo In arrTemp
                If Cr.Total = 0 Then
                    Session.Item("DNThamGia_" & DNThamGia_ItemID.Value) = 0
                Else
                    Session.Item("DNThamGia_" & DNThamGia_ItemID.Value) = Cr.Total
                End If
                litPage.Text = flReg.NextPageJs(Cr.Total, 35, DNThamGia_currPage.Value, 10, "nexttab1(")
                Exit For
            Next
            Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, DNThamGia_ItemID.Value)
            If IsNothing(phInfo) = False Then
                If Now > phInfo.ThoiGian_KetThuc Then
                    cmdDNThamGia_Active.Enabled = False
                    cmdDNThamGia_Delete.Enabled = False
                End If
            End If
        End Sub
        Public Function FormatApproval(ByVal tinhtrang As Integer) As String
            Return IIf(tinhtrang = 0, "<img src='/image/images/unselect.png' title='Chưa duyệt'>", "<img src='/image/images/select.png' title='Duyệt'>")
        End Function
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            tBox = e.Item.FindControl("SoBan")
            tBox.Text = DataBinder.Eval(e.Item.DataItem, "SoBan")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")

            liter = e.Item.FindControl("TinhTrang")
            liter.Text = FormatApproval(DataBinder.Eval(e.Item.DataItem, "TinhTrang"))

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            liter = e.Item.FindControl("Business_Vn")
            If DataBinder.Eval(e.Item.DataItem, "Logo") & "" <> "" Then
                liter.Text = "<img align=""absmiddle"" style=""padding-right:5px;"" src=""" & flConnect.fileDomain & DataBinder.Eval(e.Item.DataItem, "Logo") & "?w=24&h=24"" />"
                liter.Text += flReg.RemoveScript(DataBinder.Eval(e.Item.DataItem, "Business_Vn"), False)
            Else
                liter.Text = flReg.RemoveScript(DataBinder.Eval(e.Item.DataItem, "Business_Vn"), False)
            End If
            liter = e.Item.FindControl("TinTuyenDung")
            liter.Text = "<a href='/" & Me.PortalSettings.ActiveTab.TabName & "/edit/mar-market-bus/itemid/" & DNThamGia_ItemID.Value & "/busid/" & DataBinder.Eval(e.Item.DataItem, "Business_ID") & "/dn/" & DataBinder.Eval(e.Item.DataItem, "DoanhNghiep_ID") & "'>Chi tiết</a>"
            liter = e.Item.FindControl("ThayThe")
            liter.Text = "<a title='Thay thế doanh nghiệp' onclick=""showDialogDoanhNghiep('" & DNThamGia_ItemID.Value & "','" & DataBinder.Eval(e.Item.DataItem, "DoanhNghiep_ID") & "')"" <span class=""label label-warning pd5""><i class=""fa fa-refresh""></i></span>"
        End Sub

        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    DNThamGia_ItemID.Value = Request.Item("itemid") & ""
                    DNThamGia_currPage.Value = flReg.WriteNumber(Request.Item("p") & "")
                    If DNThamGia_currPage.Value = "0" Then DNThamGia_currPage.Value = "1"
                    Call LoadValue()
                End If

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdDNThamGia_Search_Click(sender As Object, e As EventArgs) Handles cmdDNThamGia_Search.Click
            Call LoadValue()
        End Sub

        Private Sub cmdDNThamGia_Active_Click(sender As Object, e As EventArgs) Handles cmdDNThamGia_Active.Click
            Try
                count = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsCheck")
                    If chBox.Checked = True Then
                        tBox = grdData.Items(i).FindControl("SoBan")
                        objController.CMS_DoanhNghiep_Update_Quick(Me.PortalId, DNThamGia_ItemID.Value, grdData.DataKeys(i), flReg.WriteNumber(tBox.Text), 1, Now, Me.UserInfo.Username)
                        count += 1
                    End If
                Next
                If count > 0 Then
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('success', 'Đã cập nhật thông tin doanh nghiệp vào phiên thành công.', 'Thông báo', false);location.reload()", True)
                End If

            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdDNThamGia_Delete_Click(sender As Object, e As EventArgs) Handles cmdDNThamGia_Delete.Click
            Try
                count = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsCheck")
                    If chBox.Checked = True Then
                        objController.CMS_DoanhNghiep_Delete_Business_ID(Me.PortalId, DNThamGia_ItemID.Value, grdData.DataKeys(i))
                        count += 1
                    End If
                Next
                If count > 0 Then
                    Session.Item("DNThamGia_" & DNThamGia_ItemID.Value) = Session.Item("DNThamGia_" & DNThamGia_ItemID.Value) - count
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('success', 'Đã bỏ doanh nghiệp khỏi phiên thành công.', 'Thông báo', false);location.reload()", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Bạn chưa chọn doanh nghiệp nào để bỏ khỏi phiên.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                DNThamGia_ItemID.Value = Request.Item("itemid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Function RedirectUrl() As String
            RedirectUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            RedirectUrl += "/itemid/" & Request.Item("itemid") & "/p/" & DNThamGia_currPage.Value
        End Function
        Private Sub cmdDNThamGia_Next_Click(sender As Object, e As EventArgs) Handles cmdDNThamGia_Next.Click
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeUrl", "changeUrl('" & RedirectUrl() & "');", True)
            Call LoadValue()
        End Sub
        Protected Sub BusinessView_Close() Handles ctlBusinessView.OnSubmit
            Try
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('succcess', 'Thay thế doanh nghiệp thành công', 'Thông báo', false);", True)
            Catch ex As Exception

            End Try
        End Sub
        Protected Sub lnkEdit_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
