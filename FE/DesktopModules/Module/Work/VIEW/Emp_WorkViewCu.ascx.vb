Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, itemid As String
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim strURL As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
            'Call flFunction.LoadBusinessDN(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, True)
            Business_ID.SelectedValue = Request.Item("bus")
            'Call flFunction.LoadStatusWork(Status_ID)
            Call LoadStatus()
            Status_ID.SelectedValue = Request.Item("sta")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Work_List_Search(Me.PortalId, txtkey.Text.Trim, -1, currPage.Value,
                                                        drPageSize.SelectedValue, IsSuper.Value, Business_ID.SelectedValue, Salary_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, TinhTP.SelectedValue, QuanHuyen.SelectedValue, Status_ID.SelectedValue)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()

            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_WorkInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadStatus()
            Status_ID.Items.Clear()
            Status_ID.Items.Add(New ListItem("- - Trạng thái- -", "0"))
            Status_ID.Items.Add(New ListItem("Đã duyệt", 1))
            Status_ID.Items.Add(New ListItem("Tuyển gấp", 2))
            Status_ID.Items.Add(New ListItem("Dấu thông tin", 3))
            Status_ID.Items.Add(New ListItem("Tin nổi bật", 4))
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đã phê duyệt", "1"))
            drSort.Items.Add(New ListItem("Chưa phê duyệt", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If QuanHuyen.SelectedValue <> "" Then RedirectURL += "/qh/" & QuanHuyen.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Business_ID.SelectedValue <> "" Then RedirectURL += "/bus/" & Business_ID.SelectedValue
            If Status_ID.SelectedValue <> "-1" Then RedirectURL += "/sta/" & Status_ID.SelectedValue
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
                litCount.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("~/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/tp/" & TinhTP.SelectedValue & "/qh/" & QuanHuyen.SelectedValue & "/bus/" & Business_ID.SelectedValue, True)
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, Business_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged, Status_ID.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuanHuyen.SelectedIndexChanged
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.CMS_Work_Delete(Me.PortalId, grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            itemid = DataBinder.Eval(e.Item.DataItem, "Work_ID")
            strURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & itemid

            liter = e.Item.FindControl("Infomation")
            liter.Text = "<div>DN: " & flReg.RemoveScript(flCheck.Business_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Business_ID")), False) & "</div>"
            liter.Text += "<div>Kinh nghiệm: " & flCheck.Experience_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Experience_ID")) & "</div>"
            liter.Text += "<div>Mức lương: " & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</div>"
            liter.Text += "<div>Đăng từ: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</div>"
            liter.Text += "<div>Đến ngày: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "EndDate"), False) & "</div>"

            chBox = e.Item.FindControl("IsApproval")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsApproval")
            If chBox.Checked = False Then e.Item.CssClass = "blue"
            'If IsSuper.Value <> "true" Then chBox.Enabled = False

            chBox = e.Item.FindControl("IsUrgent")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsUrgent")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsHot")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsHot")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsFast")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsFast")
            chBox.Enabled = IsActive.Value

            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class='aedit' title='Chi tiết' href='" & strURL & "'><img src='" & flText.EditImg & "' alt='Sửa'/></a>"

            liter = e.Item.FindControl("Title")
            liter.Text = "<a class='aedit' href='" & strURL & "'>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"
            liter.Text += "<div>Khu vực: " & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</div>"
            If DataBinder.Eval(e.Item.DataItem, "IsView") <> "0" Then liter.Text += "<div"">Lượt xem: " & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsView")) & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
            If DataBinder.Eval(e.Item.DataItem, "GTVL") <> "0" Then liter.Text += "<div class=""label-success label"">Đã giới thiệu: " & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "GTVL")) & "</div></div>"


        End Sub

        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                icount = 0
                Dim cbIsHot, cbIsFast, cbIsUrgent As CheckBox
                For i As Integer = 0 To grdData.Items.Count - 1
                    cbIsHot = grdData.Items(i).FindControl("IsHot")
                    cbIsFast = grdData.Items(i).FindControl("IsFast")
                    cbIsUrgent = grdData.Items(i).FindControl("IsUrgent")
                    chBox = grdData.Items(i).FindControl("IsApproval")
                    objController.CMS_Work_Update_Quick(Me.PortalId, grdData.DataKeys(i), cbIsHot.Checked, cbIsFast.Checked, cbIsUrgent.Checked, chBox.Checked, Me.UserInfo.Username, Now)
                    icount = 1
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

    End Class

End Namespace
