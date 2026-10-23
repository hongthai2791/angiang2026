Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String
        Private Sub InitControls()
            'cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"
            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_JobFollow_List_Search(txtkey.Text.Trim, 0, currPage.Value,
                                                        drPageSize.SelectedValue, Me.UserInfo.Username)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Id"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_JobFollowInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
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
                litCount.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        'Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        '    Try
        '        Dim icount As Integer = 0
        '        For i As Integer = 0 To grdData.Items.Count - 1
        '            chBox = grdData.Items(i).FindControl("IsDelete")
        '            If chBox.Checked = True Then
        '                objController.CMS_JobView_Delete(Me.PortalId, grdData.DataKeys(i))
        '                icount = 1
        '            End If
        '        Next
        '        If icount > 0 Then
        '            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
        '            Call LoadValues()
        '        Else
        '            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
        '        End If
        '    Catch ex As SqlClient.SqlException
        '        If ex.Number = 547 Then 'Loi co du lieu lien ket
        '            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
        '        Else 'Loi xoa du lieu
        '            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
        '        End If
        '    End Try
        'End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("Mobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Mobile")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            liter = e.Item.FindControl("Email")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")

            liter = e.Item.FindControl("JobWork")
            liter.Text = "<a onclick='popDetailDN(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Business_ID") & """);'  title='Xem chi tiết Doanh nghiệp' class=""text_grey2"">" & DataBinder.Eval(e.Item.DataItem, "Business_Vn") & "</a>"


        End Sub
    End Class

End Namespace
