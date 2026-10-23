Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim buInfo As New CMS_BusinessInfo
        Dim i, j As Integer, pnV As Panel
        Dim ctotal As Integer
        Dim obj As New CMS_WorkInfo
        Dim obj2 As New CMS_BusinessInfo
        Private Sub InitControls()
            hIdUser.Value = Me.UserInfo.Username
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

            Call flFunction.LoadStatusType(Status_ID)
            Status_ID.SelectedValue = Request.Item("sta")

            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car")

            Call flDic.LoadSex(Gender, "- - Giới tính - -")
            Gender.SelectedValue = Request.Item("gen")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
            Call LoadBus()
        End Sub
        Private Sub LoadBus()

            obj = objController.CMS_Work_Get(Me.PortalId, ItemID.Value)
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                TinhTP.Value = buInfo.TinhTP
                QuanHuyen.Value = buInfo.QuanHuyen
            End If
        End Sub
        Private Sub LoadValues()
            Dim totalCV As Integer = 0
            arrTemp = New ArrayList : i = 1 : ctotal = 0
            For Each Cr As CMS_RecruitmentInfo In objController.CMS_Recruitment_List_Send(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text), drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, "", Gender.SelectedValue, Business_ID.Value, Experience_ID.SelectedValue,
                                                        "", "", Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, "")
                Cr.STT = i
                arrTemp.Add(Cr)
                j = 1
                For Each Cj As CMS_RecruitmentInfo In objController.CMS_Recruitment_List_Send(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text), drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, "", Gender.SelectedValue, Business_ID.Value, Experience_ID.SelectedValue,
                                                        "", "", Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, Cr.Work_ID)
                    Cj.STT = i & "." & j
                    arrTemp.Add(Cj)

                    j += 1
                    ctotal += 1
                    totalCV += 1
                Next
                Cr.Ctotal = ctotal
                ctotal = 0
                i += 1

            Next

            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Recruitment_ID"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_RecruitmentInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = totalCV
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
                    'Call InitControls()
                    'Call LoadValues()
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
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged,
                        drSort.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged,
                        Status_ID.SelectedIndexChanged, Gender.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound

            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "STT")

            If DataBinder.Eval(e.Item.DataItem, "W_Title") <> "" Then
                e.Item.CssClass = "black bold tr-parent"
                liter = e.Item.FindControl("W_Title")
                liter.Text = "<div style='float:left; width:calc(100% - 35px);'><a onclick='popDetailVL(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Work_ID") & """);'  title='Xem chi tiết tin tuyển dụng' class=""text_grey2"">"
                liter.Text += "<img src='/image/images/view.png?w' title='Xem tin tuyển dụng'>&nbsp;</a>[" & flCheck.ReadCode(DataBinder.Eval(e.Item.DataItem, "ID")) & "]&nbsp;" & DataBinder.Eval(e.Item.DataItem, "W_Title") & "</div>"
                liter.Text += "<div class=""td-angle header expand""><i class=""fa fa-angle-double-down"" aria-hidden=""true"" ></i></div>"

                liter = e.Item.FindControl("CV_UngTuyen")
                liter.Text = "Lượt xem: " & DataBinder.Eval(e.Item.DataItem, "LuotXem")
                liter = e.Item.FindControl("SoLuong")
                liter.Text = "<div class=""col-md-6"">Cần tuyển: " & DataBinder.Eval(e.Item.DataItem, "Quantity") & "</div>"
                liter.Text += "<div class=""col-md-6"">Ứng tuyển: " & DataBinder.Eval(e.Item.DataItem, "Ctotal") & "</div>"

                pnV = e.Item.FindControl("pnTrangThai")
                pnV.Visible = False
            Else

                liter = e.Item.FindControl("HoTen")
                liter.Text = "<div class=""col-sm-2""><img align=""absmiddle"" src=""" & flReg.PhotoURLFile(DataBinder.Eval(e.Item.DataItem, "UserAdmin"), Me.PortalId) & "?w=48"" title=""Ảnh đại diện""></div>"
                liter.Text += "<div class=""col-sm-10""><b>" & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "UserAdmin")) & "</b>"
                liter.Text += "<div>Địa chỉ:  " & flDic.getDiaChi(0, DataBinder.Eval(e.Item.DataItem, "UserAdmin")) & "</div>"

                liter.Text += "<div class=""col-sm-12 pdl0"">Ngày ứng tuyển: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate"), False) & "</div>"
                liter.Text += "<div class=""col-sm-12 pdl0"">Mức lương: " & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"
                liter.Text += "</div> "
                liter = e.Item.FindControl("Tuoi")
                liter.Text = flDic.getTuoi(flDic.getNgaySinh(0, DataBinder.Eval(e.Item.DataItem, "UserAdmin")))

                liter = e.Item.FindControl("CV_UngTuyen")
                liter.Text += "<div class=""col-md-12 bus-gt""><a onclick='popDetailVLUV(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & """,""" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & """,""" & Me.UserInfo.Username & """);'  title='Xem chi tiết hồ sơ ứng viên' class=""text_grey2"">"
                liter.Text += "<img src='/image/images/view.png?w' title='Xem hồ sơ ứng viên'>&nbsp;&nbsp;" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a></div>"
                If DataBinder.Eval(e.Item.DataItem, "IsInvite") <> "0" Then liter.Text += "<div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class=""label-success label"">Được giới thiệu</span></div>"
                chBox = e.Item.FindControl("IsView")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsView")
                chBox.Enabled = False
                chBox.InputAttributes.Add("class", "m-IsView-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'1','" & Me.UserInfo.Username & "')")
                If chBox.Checked = False Then e.Item.CssClass = "blue tr-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID")

                chBox = e.Item.FindControl("IsContact")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsContact")
                chBox.InputAttributes.Add("class", "m-IsContact-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'2','" & Me.UserInfo.Username & "')")

                chBox = e.Item.FindControl("IsInterview")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsInterview")
                chBox.InputAttributes.Add("class", "m-IsInterview-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'3','" & Me.UserInfo.Username & "')")

                chBox = e.Item.FindControl("IsTest")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsTest")
                chBox.InputAttributes.Add("class", "m-IsTest-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'4','" & Me.UserInfo.Username & "')")

                chBox = e.Item.FindControl("IsElect")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsElect")
                chBox.InputAttributes.Add("class", "m-IsElect-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'5','" & Me.UserInfo.Username & "')")

                chBox = e.Item.FindControl("IsCancel")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsCancel")
                chBox.InputAttributes.Add("class", "m-IsCancel-" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID"))
                chBox.InputAttributes.Add("onchange", "setTrangThaiUV('" & Me.PortalId & "','" & DataBinder.Eval(e.Item.DataItem, "Recruitment_ID") & "',this,'6','" & Me.UserInfo.Username & "')")
            End If
        End Sub

        Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
            Try
                Dim cbIsView, cbIsContact, cbIsInterview, cbIsTest, cbIsElect As CheckBox
                For i As Integer = 0 To grdData.Items.Count - 1
                    cbIsView = grdData.Items(i).FindControl("IsView")
                    cbIsContact = grdData.Items(i).FindControl("IsContact")
                    cbIsInterview = grdData.Items(i).FindControl("IsInterview")
                    cbIsTest = grdData.Items(i).FindControl("IsTest")
                    cbIsElect = grdData.Items(i).FindControl("IsElect")
                    chBox = grdData.Items(i).FindControl("IsCancel")
                    objController.CMS_Recruitment_Update_Quick(Me.PortalId, grdData.DataKeys(i),
                                cbIsView.Checked, cbIsContact.Checked, cbIsInterview.Checked, cbIsTest.Checked,
                                cbIsElect.Checked, chBox.Checked, Now, Me.UserInfo.Username)
                Next
                Call LoadValues()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

    End Class

End Namespace
