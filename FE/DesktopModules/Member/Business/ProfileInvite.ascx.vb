Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim buInfo As New CMS_BusinessInfo
        Dim strURL As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            If Request.Item("sort") <> "" Then drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
            Call LoadBus()
        End Sub
        Private Sub LoadBus()
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                'Business_Name.Text = buInfo.Business_Vn
                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                TinhTP.Value = buInfo.TinhTP
                QuanHuyen.Value = buInfo.QuanHuyen
            End If
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_JobInvite_List_Search(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value,
                                            drPageSize.SelectedValue, 1, Business_ID.Value, "", Experience_ID.SelectedValue,
                                             Salary_ID.SelectedValue, Career_ID.SelectedValue, 0, 0)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "JobInvite_ID"
            grdData.DataBind()
            litPage.Text = "" : litCount.Text = 0
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_JobInviteInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Tất cả", "-1"))
            drSort.Items.Add(New ListItem("Đang chờ", "0"))
            drSort.Items.Add(New ListItem("Đã nộp hồ sơ", "1"))
            drSort.Items.Add(New ListItem("Đã từ chối", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Career_ID.SelectedValue <> "" Then RedirectURL += "/car/" & Career_ID.SelectedValue
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.CMS_JobInvite_Delete(Me.PortalId, grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "JobInvite_ID")

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/bus-works-add/itemid/" & DataBinder.Eval(e.Item.DataItem, "JobID")
            liter = e.Item.FindControl("JobWork")
            'liter.Text = "<a href=""" & strURL & """>" & flCheck.JobUser_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "IdKey"), False) & "</a>"
            liter.Text += "<div class=""col-md-11""><a onclick='popDetailVLUV1(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "JobID") & """);'  title='Xem chi tiết hồ sơ ứng viên' class=""text_grey2"">"
            liter.Text += "<img src='/image/images/view.png?w=48' title='Xem chi tiết hồ sơ ứng tuyển'>&nbsp;" & flCheck.JobUser_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "JobID"), False) & "</a></div>"

            liter = e.Item.FindControl("CreateDate")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate"))

            liter = e.Item.FindControl("Work_ID")
            liter.Text = flCheck.Work_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "WorkID"), False)

            liter = e.Item.FindControl("IsStatus")
            If DataBinder.Eval(e.Item.DataItem, "IsStatus") = 1 Then
                liter.Text = "<span class='label label-success'>Đã nộp hồ sơ</span>"

            ElseIf DataBinder.Eval(e.Item.DataItem, "IsStatus") = 2 Then
                liter.Text = "<span class='label label-warning'>Đã từ chối</span>"
            Else
                liter.Text = "<span class='label label-info'>Đang chờ</span>"
            End If

        End Sub

    End Class

End Namespace
