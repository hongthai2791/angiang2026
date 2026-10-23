Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports GemBox.Spreadsheet

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim strURL As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Business_List_Active(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text), currPage.Value, drPageSize.SelectedValue,
                                 flReg.WriteNumber(TinhTP.SelectedValue), 0, flReg.WriteNumber(PhuongXa.SelectedValue), True)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litPage.Text = ""
            litCount.Text = 0
            For Each Cr As CMS_BusinessInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = flReg.FormatCount(Cr.Total)
                Exit For
            Next

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đang hoạt động", "1"))
            drSort.Items.Add(New ListItem("Ngừng hoạt động", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If PhuongXa.SelectedValue <> "" Then RedirectURL += "/px/" & PhuongXa.SelectedValue
            If drSort.SelectedValue <> "0" Then RedirectURL += "/sort/" & drSort.SelectedValue
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("~/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view"), True)
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, PhuongXa.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.CMS_Business_Delete(Me.PortalId, grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "Business_ID")
            strURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId

            liter = e.Item.FindControl("ID")
            liter.Text = flReg.FormatGenCode(DataBinder.Eval(e.Item.DataItem, "ID"))

            liter = e.Item.FindControl("ContactUser")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactUser")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            chBox = e.Item.FindControl("IsApproval")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsApproval")
            If chBox.Checked = False Then e.Item.CssClass = "blue"
            If IsSuper.Value <> "true" Then chBox.Enabled = False

            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class='aedit' title='Chi tiết' href='" & strURL & "'><img src='" & flText.EditImg & "' alt='Sửa'/></a>"

            liter = e.Item.FindControl("Business_Vn")
            If DataBinder.Eval(e.Item.DataItem, "Logo") & "" <> "" Then
                liter.Text = "<img align=""absmiddle"" style=""padding-right:5px;"" src=""" & flConnect.fileDomain & DataBinder.Eval(e.Item.DataItem, "Logo") & "?w=24&h=24"" />"
                liter.Text += "<a class='aedit' href=""" & strURL & """>" & DataBinder.Eval(e.Item.DataItem, "Business_Vn") & "</a>"
            Else
                liter.Text = "<a class='aedit' href='" & strURL & "'>" & DataBinder.Eval(e.Item.DataItem, "Business_Vn") & "</a>"
            End If
        End Sub
        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsApproval")
                    objController.CMS_Business_Update_Quick(Me.PortalId, grdData.DataKeys(i), chBox.Checked, Me.UserInfo.Username, Now)
                    icount = 1
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã cập nhật lại thông tin thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Sub ExportToExcel(ByVal response As HttpResponse)
            Try

                SpreadsheetInfo.SetLicense("EL6O-26C7-AZ0H-090X")
                Dim workbook = New ExcelFile()
                Dim worksheet = workbook.Worksheets.Add("DanhSach")
                worksheet.Cells(0, 0).Value = "STT"
                worksheet.Cells(0, 1).Value = "Mã"
                worksheet.Cells(0, 2).Value = "Tên doanh nghiệp"
                worksheet.Cells(0, 3).Value = "Người đại diện"
                worksheet.Cells(0, 4).Value = "Điện thoại"
                worksheet.Cells(0, 5).Value = "Địa chỉ"
                Dim totalRows As Integer = 0
                Dim totalCols As Integer = 6
                Dim i = 1
                For Each cr As CMS_BusinessInfo In objController.CMS_Business_List_Active(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text), 1, 10000,
                                 flReg.WriteNumber(TinhTP.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue), True)

                    worksheet.Cells(i, 0).Value = i
                    worksheet.Cells(i, 1).Value = cr.ID
                    worksheet.Cells(i, 2).Value = flReg.RemoveHTML(cr.Business_Vn)
                    worksheet.Cells(i, 3).Value = cr.ContactUser
                    worksheet.Cells(i, 4).Value = cr.ContactMobile
                    worksheet.Cells(i, 5).Value = cr.Address
                    i += 1 : totalRows += 1
                Next
                For col As Integer = 0 To totalCols - 1
                    worksheet.Columns(col).AutoFit()
                Next
                response.Clear()
                response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}.xlsx", "DanhSachDoanhNghiep" + Now.ToString("ddMMyyyy")))
                Using stream = New System.IO.MemoryStream()
                    workbook.Save(stream, SaveOptions.XlsxDefault)
                    stream.WriteTo(response.OutputStream)
                End Using
                response.Flush()
                response.[End]()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click

        End Sub

        Protected Sub cmdExcel_Click1(sender As Object, e As EventArgs)
            ExportToExcel(Response)
        End Sub
    End Class

End Namespace
