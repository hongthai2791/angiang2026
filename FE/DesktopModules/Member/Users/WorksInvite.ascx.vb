Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String
        Dim status As Integer = 0
        Dim str() As String
        Dim lnk, lnkTC As LinkButton
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            If Request.Item("sort") <> "" Then drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            'Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã - -")
            If Request.Item("qh") <> "" Then PhuongXa.SelectedValue = Request.Item("qh")

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car") & ""

            Call flFunction.LoadTypeOf(Me.PortalId, TypeOf_ID, "- - Loại công việc - -")
            TypeOf_ID.SelectedValue = Request.Item("typ") & ""

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_JobInvite_List_Search_users(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, 1, "", TypeOf_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, Salary_ID.SelectedValue, Career_ID.SelectedValue, TinhTP.SelectedValue, flReg.WriteNumber(PhuongXa.SelectedValue), Me.UserInfo.Username)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "JobInvite_ID"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
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
            drSort.Items.Add(New ListItem("Mới", "0"))
            drSort.Items.Add(New ListItem("Đồng ý", "1"))
            drSort.Items.Add(New ListItem("Từ chối", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If PhuongXa.SelectedValue <> "" Then RedirectURL += "/qh/" & PhuongXa.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Career_ID.SelectedValue <> "" Then RedirectURL += "/car/" & Career_ID.SelectedValue
            If TypeOf_ID.SelectedValue <> "" Then RedirectURL += "/typ/" & TypeOf_ID.SelectedValue
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã - -")
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged,
                                                    drSort.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged,
                                                    Experience_ID.SelectedIndexChanged, PhuongXa.SelectedIndexChanged, TypeOf_ID.SelectedIndexChanged
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
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("JobWork")
            liter.Text = flCheck.Work_Name("users/edit/us-works/busID/" & DataBinder.Eval(e.Item.DataItem, "BusID"), Me.PortalId, DataBinder.Eval(e.Item.DataItem, "WorkID"), True)
            liter.Text += "<div>Ngày mời: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate")) & "</b></div>"

            liter = e.Item.FindControl("BusID")
            'liter.Text = flCheck.Business_Name("users/view/us-business", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "IdName"), True)
            liter.Text = "<a onclick='popDetailDN(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "BusID") & """);'  title='Xem chi tiết Doanh nghiệp' class=""text_grey2"">" & flCheck.Business_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "BusID"), True) & "</a>"

            liter = e.Item.FindControl("JobID")
            liter.Text = "<a  title='Xem chi tiết hồ sơ' class=""text_grey2"">" & flCheck.JobUser_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "JobID"), True) & "</a>"
            status = flReg.WriteNumber(DataBinder.Eval(e.Item.DataItem, "IsStatus"))

            lnk = e.Item.FindControl("lnkNopHS")
            lnk.CommandArgument = DataBinder.Eval(e.Item.DataItem, "JobID")
            lnk.CommandName = DataBinder.Eval(e.Item.DataItem, "JobInvite_ID") & "," & DataBinder.Eval(e.Item.DataItem, "WorkID")

            lnkTC = e.Item.FindControl("lnkTuChoi")
            lnkTC.CommandArgument = DataBinder.Eval(e.Item.DataItem, "JobID")
            lnkTC.CommandName = DataBinder.Eval(e.Item.DataItem, "JobInvite_ID")
            liter = e.Item.FindControl("litStatus")
            If objController.CMS_UserWork_Check(Me.PortalId, Me.UserInfo.Username, DataBinder.Eval(e.Item.DataItem, "WorkID")) Then
                liter.Text = "<span class='label label-info'>Đã nộp hồ sơ</span>"
                lnkTC.Visible = False
                lnk.Visible = False

            ElseIf status = 1 Then
            liter.Text = "<span class='label label-info'>Đã nộp hồ sơ</span>"
                lnkTC.Visible = False
                lnk.Visible = False
            ElseIf status = 2 Then
                liter.Text = "<span class='label label-warning'>Đã từ chối</span>"
                lnkTC.Visible = False
                lnk.Visible = False
            End If

        End Sub
        Protected Sub lnkNopHS_Command(sender As Object, e As CommandEventArgs)
            Try

                lnk = TryCast(sender, LinkButton)
                str = lnk.CommandName.Split(",")
                If str.Count >= 2 Then
                    Dim reInfo As New CMS_RecruitmentInfo
                    reInfo.Recruitment_ID = flReg.GenKey()
                    reInfo.JobUser_ID = lnk.CommandArgument
                    reInfo.Work_ID = str(1)
                    reInfo.IsView = 0
                    reInfo.IsContact = 0
                    reInfo.IsCancel = 0
                    reInfo.IsElect = 0
                    reInfo.IsInterview = 0
                    reInfo.IsTest = 0
                    reInfo.CreateDate = Now
                    reInfo.UserName = Me.UserInfo.Username
                    reInfo.UpdatedUser = Me.UserInfo.Username
                    reInfo.UpdatedDate = flReg.DateNull
                    objController.CMS_Recruitment_Add(Me.PortalId, reInfo)
                    objController.CMS_JobInvite_Update_Status(Me.PortalId, str(0), 1)
                    flCache.RemoveCache("CMS_Recruitment_List_UserName_" & str(1) & "_" & Me.UserInfo.Username)
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('success', 'Đã nộp hồ sơ thành công');", True)
                    Call LoadValues()
                End If
            Catch ex As Exception
                litCount.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Protected Sub lnkTuChoi_Command(sender As Object, e As CommandEventArgs)
            Try

                lnk = TryCast(sender, LinkButton)
                objController.CMS_JobInvite_Update_Status(Me.PortalId, lnk.CommandName, 2)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('success', 'Đã từ chối nộp hồ sơ thành công');", True)
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class

End Namespace
