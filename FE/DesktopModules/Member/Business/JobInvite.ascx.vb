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
        Dim buInfo As New CMS_BusinessInfo
        Private Sub InitControls()
            cmdChoise.Attributes.Add("onclick", "javascript:return confirm('Bạn có chắc chắn muốn mời ứng viên vào các vị trí tuyển dụng đã chọn?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadStatusWork(Status_ID)
            Status_ID.SelectedValue = Request.Item("sta")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"
            ViewState("UrlReferrer") = IIf(IsNothing(Request.UrlReferrer) = False, flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName), "/" & Me.PortalSettings.ActiveTab.TabName)

            Call LoadBus()
            JobID.Value = Request.Item("jobid")
            Call LoadInvite()
        End Sub
        Private Sub LoadInvite()
            drInvite.Items.Clear()
            drInvite.Items.Add(New ListItem("Tin chưa mời", 0))
            drInvite.Items.Add(New ListItem("Tin đã mời", 1))
        End Sub
        Private Sub LoadBus()
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                'Business_Name.Text = buInfo.Business_Vn
                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                TinhTP.Value = buInfo.TinhTP
            End If
        End Sub

        Private Function CareerMultiName(id As String) As String
            CareerMultiName = ""
            Dim str() As String = id.Split(",")
            For i = 0 To str.Count - 1
                If String.IsNullOrEmpty(str(i)) = False Then
                    CareerMultiName += flCheck.Career_Name(Me.PortalId, str(i)) & IIf(i = str.Count - 1, "", ", ")
                End If
            Next
        End Function
        Private Sub LoadJobInfo()
            Dim obj As New CMS_JobUserInfo
            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & JobID.Value), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = New WorkController().CMS_JobUser_Get(PortalId, JobID.Value)
                flCache.SetCache("CMS_JobUser_Get_" & JobID.Value, obj, SecondCache.M30)
            End If
            If IsNothing(obj) = False Then
                JobUser_Vn.Text = flReg.GetUserName(obj.UserAdmin, Me.PortalId)
                JobUser_Img.Text = "<img src='" & flReg.ImgSRC(flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID), 150, 0, True, "noavatar.png") & "' alt='" & obj.Title & "' />"
                litInfo.Text = ""

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: "
                litInfo.Text += "<span class='job_value'>" & flDic.Position_Name(Me.PortalId, obj.LevelDesired) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-money icon_16'></i><span class='pl_28'>Mức lương: "
                litInfo.Text += "<span class='job_value'>" & flCheck.Salary_Name(Me.PortalId, obj.Salary_ID) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-age icon_16'></i><span class='pl_28'>Nhu cầu làm việc: "
                litInfo.Text += "<span class='job_value'>" & flCheck.Needs_Name(Me.PortalId, obj.Needs_ID) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litCin.Text = "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-address icon_16'></i><span class='pl_28'>Nơi làm việc: "
                litCin.Text += "<span class='job_value'>" & flDic.RegionalName(Me.PortalId, obj.TinhTP, obj.QuanHuyen) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"

                litCin.Text += "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề: "
                'litCin.Text += "<span class='job_value'>" & flCheck.Career_Name(Me.PortalId, obj.Career_ID) & "</span>"
                litCin.Text += "<span class='job_value'>" & CareerMultiName(obj.Career_ID) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"

                litCin.Text += "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-countdown icon_16'></i><span class='pl_28'>Ngày đăng tin: "
                litCin.Text += "<span class='job_value'>" & flReg.ReadDate(obj.StartDate, False) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"
            End If

        End Sub

        Private Sub LoadValues()
            arrTemp = objController.CMS_Work_List_Invite(Me.PortalId, txtkey.Text.Trim, drInvite.SelectedValue, drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, JobID.Value, Business_ID.Value, Salary_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, Status_ID.SelectedValue)
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
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đã phê duyệt", "1"))
            drSort.Items.Add(New ListItem("Chưa phê duyệt", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Status_ID.SelectedValue <> "-1" Then RedirectURL += "/sta/" & Status_ID.SelectedValue
            If drSort.SelectedValue <> "0" Then RedirectURL += "/sort/" & drSort.SelectedValue
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadJobInfo()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged, Status_ID.SelectedIndexChanged,drInvite.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        Protected Sub cmdChoise_Click(sender As Object, e As EventArgs) Handles cmdChoise.Click
            Try
                icount = 0
                Dim objI As New CMS_JobInviteInfo
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objI = New CMS_JobInviteInfo
                        objI.JobInvite_ID = flReg.GenKey
                        objI.JobID = JobID.Value
                        objI.WorkID = grdData.DataKeys(i)
                        objI.BusID = Business_ID.Value
                        objI.CreateDate = Now
                        objI.UserName = flCheck.JobUser_UserAdmin(Me.PortalId, JobID.Value)
                        objController.CMS_JobInvite_Add(Me.PortalId, objI)
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã mời ứng tuyển thành công.', 'Thông báo', false);backend('" & ViewState("UrlReferrer") & "');", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn tin tuyển dụng nào để mời.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            itemid = DataBinder.Eval(e.Item.DataItem, "Work_ID")
            strURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & itemid

            liter = e.Item.FindControl("Infomation")
            liter.Text = "<div>Kinh nghiệm: " & flCheck.Experience_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Experience_ID")) & "</div>"
            liter.Text += "<div>Mức lương: " & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</div>"
            liter.Text += "<div>Đăng từ: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</div>"

            chBox = e.Item.FindControl("IsApproval")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsApproval")
            If chBox.Checked = False Then e.Item.CssClass = "blue"
            chBox.Enabled = False

            chBox = e.Item.FindControl("IsUrgent")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsUrgent")
            chBox.Enabled = False

            chBox = e.Item.FindControl("IsHot")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsHot")
            chBox.Enabled = False

            chBox = e.Item.FindControl("IsFast")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsFast")
            chBox.Enabled = False

            liter = e.Item.FindControl("Title")
            liter.Text = "<a class='aedit'>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"
            liter.Text += "<div>Khu vực: " & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</div>"
            If DataBinder.Eval(e.Item.DataItem, "IsView") <> "0" Then liter.Text += "<div>Lượt xem: " & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsView")) & "</div>"
        End Sub
    End Class

End Namespace
