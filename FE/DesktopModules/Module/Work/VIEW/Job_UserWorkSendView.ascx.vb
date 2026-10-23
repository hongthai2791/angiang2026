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
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã - -")
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")

            Call flFunction.LoadStatusType(Status_ID)
            If Request.Item("sta") <> "" Then Status_ID.SelectedValue = flReg.WriteNumber(Request.Item("sta"))


            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car") & ""

            Call flFunction.LoadGender(Gender, "- - Giới tính - -")
            Gender.SelectedValue = Request.Item("gen")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = "true" ' flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Recruitment_List_Search(Me.PortalId, txtkey.Text.Trim, -1, currPage.Value,
                                                        drPageSize.SelectedValue, IsSuper.Value, Gender.SelectedValue, "", Experience_ID.SelectedValue,
                                                        TinhTP.SelectedValue, PhuongXa.SelectedValue, Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, "")
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Recruitment_ID"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_RecruitmentInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đã test", "1"))
            drSort.Items.Add(New ListItem("Đã liên hệ", "2"))
            drSort.Items.Add(New ListItem("Đã trúng tuyển", "3"))
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If PhuongXa.SelectedValue <> "" Then RedirectURL += "/px/" & PhuongXa.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Career_ID.SelectedValue <> "" Then RedirectURL += "/car/" & Career_ID.SelectedValue
            If Gender.SelectedValue <> "" Then RedirectURL += "/gen/" & Gender.SelectedValue
            If Status_ID.SelectedValue <> "0" Then RedirectURL += "/sta/" & Status_ID.SelectedValue
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
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã - -")
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged,
                        drSort.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged,
                        PhuongXa.SelectedIndexChanged, Status_ID.SelectedIndexChanged, Gender.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            strURL = Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view")
            liter = e.Item.FindControl("ProfileWork")
            liter.Text = flCheck.Work_Name(strURL, Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Work_ID"), True)
            liter.Text += "<div>Ngày nộp: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate")) & "</b></div>"

            liter = e.Item.FindControl("ProfileBus")
            liter.Text = flCheck.Business_Name(Me.PortalSettings.ActiveTab.TabName & "/edit/business-public", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Business_ID"), True)
            'liter.Text = "<a onclick='popDetailDN(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Business_ID") & """);'  title='Xem chi tiết Doanh nghiệp' class=""text_grey2"">" & flCheck.Business_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Business_ID"), True) & "</a>"
            chBox = e.Item.FindControl("IsView")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsView")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsContact")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsContact")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsInterview")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsInterview")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsTest")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsTest")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsElect")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsElect")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsCancel")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsCancel")
            chBox.Enabled = IsActive.Value

        End Sub

    End Class

End Namespace
