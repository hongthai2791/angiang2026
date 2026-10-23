Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim strURL As String
        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            ''If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Business_List_Active(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text), currPage.Value, drPageSize.SelectedValue,
                                 flReg.WriteNumber(TinhTP.SelectedValue), 0, flReg.WriteNumber(PhuongXa.SelectedValue), False)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litPage.Text = ""
            litCount.Text = 0
            For Each Cr As CMS_BusinessInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, PhuongXa.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "Business_ID")
            strURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId

            liter = e.Item.FindControl("ContactUser")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactUser")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            chBox = e.Item.FindControl("IsApproval")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsApproval")
            If chBox.Checked = False Then e.Item.CssClass = "blue"

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
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
    End Class

End Namespace
