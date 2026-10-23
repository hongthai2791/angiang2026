Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace Modules.PageWork
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objCTL As New WorkController
        Dim arr As New ArrayList
        Dim strUrl, str() As String
        Dim liter As Literal
        Dim cbActive As CheckBox
        Dim obj As New CMS_RecruitmentInfo
        Dim wbj As New CMS_WorkInfo
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName

        Private Sub GetID()
            WID.Value = Request.Item("wid")
            If WID.Value = "" Then WID.Value = Request.Item("itemid")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")

            Call ActiveSelect()

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ViewState("backUrl") = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("page") & "/itemid/" & WID.Value

        End Sub
        Private Sub ActiveSelect()
            wbj = objCTL.CMS_Work_Get(Me.PortalId, WID.Value)
            If IsNothing(wbj) = False Then
                If Request.Item("tp") <> "" Then
                    TinhTP.SelectedValue = Request.Item("tp")
                ElseIf Request.Item("wid") & "" <> "" Then
                    str = wbj.TinhTP.Split(",")
                    TinhTP.SelectedValue = str(str.Length - 1)
                End If
                Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
                If Request.Item("qh") <> "" Then
                    QuanHuyen.SelectedValue = Request.Item("qh")
                ElseIf Request.Item("wid") & "" <> "" Then
                    str = wbj.QuanHuyen.Split(",")
                    QuanHuyen.SelectedValue = str(str.Length - 1)
                End If
                If Request.Item("sal") <> "" Then
                    Salary_ID.SelectedValue = Request.Item("sal") & ""
                ElseIf Request.Item("wid") & "" <> "" Then
                    Salary_ID.SelectedValue = wbj.Salary_ID
                End If
                If Request.Item("exp") <> "" Then
                    Experience_ID.SelectedValue = Request.Item("exp") & ""
                ElseIf Request.Item("wid") & "" <> "" Then
                    Experience_ID.SelectedValue = wbj.Experience_ID
                End If
                If Request.Item("car") <> "" Then
                    Career_ID.SelectedValue = Request.Item("car") & ""
                ElseIf Request.Item("wid") & "" <> "" Then
                    Career_ID.SelectedValue = wbj.Career_ID
                End If

            End If
        End Sub

        Private Sub LoadValue()
            arr = objCTL.CMS_JUser_List_GTVL(Me.PortalId, txtkey.Text.Trim, currPage.Value, 35, Career_ID.SelectedValue, Salary_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, TinhTP.SelectedValue, QuanHuyen.SelectedValue, WID.Value)
            grdData.DataSource = arr
            grdData.DataKeyField = "JobUser_ID"
            grdData.DataBind()
            litPage.Text = "" : litCount.Text = 0
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_JobUserInfo In arr
                litPage.Text = flReg.NextPage(Cr.Total, 35, currPage.Value, 5, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next

        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()
            strUrl = "/" & _tabName & "/edit/" & Request.Item("view") & "/itemID/" & grdData.DataKeys(e.Item.ItemIndex)

            liter = e.Item.FindControl("CVUngVien")
            liter.Text += "<div class=""hotenvi""><a onclick='popDetailJobuser(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & """,""" & Me.UserInfo.Username & """);'  title='Xem chi tiết thông tin hồ sơ' class=""text_grey3"">"
            liter.Text += "<img src=""/image/images/view.png?w"" />&nbsp;" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a></div>"

            liter = e.Item.FindControl("HoTen")

            liter.Text = flDic.getHoTen(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "UserAdmin"), flConnect.DnnSqlServer)
            liter = e.Item.FindControl("DienThoai")
            liter.Text = flDic.getTelephone(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "UserAdmin"), flConnect.DnnSqlServer)

            liter = e.Item.FindControl("NganhNghe")
            liter.Text = flCheck.Career_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Career_ID"))

            liter = e.Item.FindControl("Tuoi")
            liter.Text = flDic.getTuoi(flDic.getNgaySinh(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "UserAdmin"), flConnect.DnnSqlServer))

            liter = e.Item.FindControl("TrinhDo")
            liter.Text = flDic.Education_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Level_ID"))

        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & _tabName & "/edit/" & Request.Item("edit") & "/itemid/" & WID.Value & "/page/" & Request.Item("page")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If QuanHuyen.SelectedValue <> "" Then RedirectURL += "/qh/" & QuanHuyen.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Career_ID.SelectedValue <> "" Then RedirectURL += "/car/" & Career_ID.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "app")
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged, QuanHuyen.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValue()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValue()
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    cbActive = grdData.Items(i).FindControl("IsSelect")
                    If cbActive.Checked = True Then
                        obj = New CMS_RecruitmentInfo
                        obj.Work_ID = WID.Value
                        obj.JobUser_ID = grdData.DataKeys(i)
                        obj.CreateDate = Now
                        obj.UserName = Me.UserInfo.Username
                        obj.IsInvite = 1
                        obj.Recruitment_ID = flReg.GenKey()
                        obj.UpdatedDate = flReg.DateNull
                        obj.UpdatedUser = ""
                        objCTL.CMS_Recruitment_Add(Me.PortalId, obj)
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "pag_suc", "removewaiting();notify('success', 'Đã giới thiệu ứng viên thành công.', 'Thông báo', false);", True)
                    Call LoadValue()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn ứng viên nào để giới thiệu', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "pag_noti", "removewaiting();notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace