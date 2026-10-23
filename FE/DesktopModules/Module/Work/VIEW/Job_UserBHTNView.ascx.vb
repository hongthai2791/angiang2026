Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.Job_UserBHTN
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String

        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = "true" 'flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False
            Call LoadTrinhDo()
            If flReg.WriteNumber(Request.Item("td")) <> -1 Or String.IsNullOrEmpty(Request.Item("td")) = False Then
                TrinhDo.SelectedValue = Request.Item("td")
            End If
            Call LoadViTri()
            If flReg.WriteNumber(Request.Item("vt")) <> -1 Or String.IsNullOrEmpty(Request.Item("vt")) = False Then
                ViTri.SelectedValue = Request.Item("td")
            End If

            Call LoadCongViec()
            If flReg.WriteNumber(Request.Item("cv")) <> -1 Or String.IsNullOrEmpty(Request.Item("cn")) = False Then
                CongViec.SelectedValue = Request.Item("td")
            End If
        End Sub
        Private Sub LoadTrinhDo()
            TrinhDo.Items.Clear()
            TrinhDo.Items.Add(New ListItem("Tất cả", -1))
            For Each cr As DanhMucChungBHTN In objController.DanhMucChungBHTN_List("DM_ChuyenMonKyThuat")
                TrinhDo.Items.Add(New ListItem(cr.Name, cr.Id))
            Next
        End Sub
        Private Sub LoadViTri()
            ViTri.Items.Clear()
            ViTri.Items.Add(New ListItem("Tất cả", -1))
            For Each cr As DanhMucChungBHTN In objController.DanhMucChungBHTN_List("DM_Vitricongviec")
                ViTri.Items.Add(New ListItem(cr.Name, cr.Id))
            Next
        End Sub
        Private Sub LoadCongViec()
            CongViec.Items.Clear()
            CongViec.Items.Add(New ListItem("Tất cả", -1))
            For Each cr As DanhMucChungBHTN In objController.DanhMucChungBHTN_List("DM_Nganhnghe_tuyendung")
                CongViec.Items.Add(New ListItem(cr.Name, cr.Id))
            Next
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_JobUserBHTN_List_Search(txtkey.Text.Trim, TrinhDo.SelectedValue, ViTri.SelectedValue, -1, CongViec.SelectedValue, flReg.WebConfig("PortalBHTN"), currPage.Value, drPageSize.SelectedValue)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litCount.Text = 0 : litPage.Text = ""
            For Each Cr As HoSoBHTNInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.TotalRow, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.TotalRow
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If TrinhDo.SelectedValue <> "-1" Then RedirectURL += "/td/" & TrinhDo.SelectedValue
            If ViTri.SelectedValue <> "-1" Then RedirectURL += "/vt/" & ViTri.SelectedValue
            If CongViec.SelectedValue <> "-1" Then RedirectURL += "/cv/" & CongViec.SelectedValue
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, TrinhDo.SelectedIndexChanged, ViTri.SelectedIndexChanged, CongViec.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("HoTen")
            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/id/" & DataBinder.Eval(e.Item.DataItem, "SoSoBHXH").ToString()
            liter.Text = "<a title='click để xem chi tiết hồ sơ bhtn này' href='" & strURL & "'>" & DataBinder.Eval(e.Item.DataItem, "HoTen") & "</a>"
            liter = e.Item.FindControl("Tuoi")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Tuoi")
            liter = e.Item.FindControl("CMND")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "CMND")
            liter = e.Item.FindControl("Email")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")
            liter = e.Item.FindControl("SDT")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "SDT")
            liter = e.Item.FindControl("SoSoBHXH")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "SoSoBHXH")

        End Sub

        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsApproval")
                    objController.CMS_JobUser_Update_Quick(Me.PortalId, grdData.DataKeys(i),
                                                           chBox.Checked, Me.UserInfo.Username, Now)
                Next
                Call LoadValues()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class

End Namespace
