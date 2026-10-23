Imports System.IO
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String
        Dim wsh As ExcelWorksheet
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã- -")
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, PhuongXa.SelectedValue, "")
            Business_ID.SelectedValue = Request.Item("bus")

            Call flFunction.LoadStatusType(Status_ID)
            If Request.Item("sta") <> "" Then Status_ID.SelectedValue = flReg.WriteNumber(Request.Item("sta"))


            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car")

            Call flFunction.LoadGender(Gender, "- - Giới tính - -")
            Gender.SelectedValue = Request.Item("gen")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Recruitment_List_Search_HSUT(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, Gender.SelectedValue, Business_ID.SelectedValue, Experience_ID.SelectedValue,
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
            If Business_ID.SelectedValue <> "" Then RedirectURL += "/bus/" & Business_ID.SelectedValue
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged,
                        drSort.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged,
                        Status_ID.SelectedIndexChanged, Business_ID.SelectedIndexChanged, Gender.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "- - Phường/ xã- -")
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, PhuongXa.SelectedValue, "")

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PhuongXa.SelectedIndexChanged
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, PhuongXa.SelectedValue, "")

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.CMS_Recruitment_Delete(Me.PortalId, grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Không có nội dung để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "Recruitment_ID")
            strURL = PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view")

            liter = e.Item.FindControl("ProfileWork")
            liter.Text = flCheck.Work_Name(strURL, Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Work_ID"), True)
            liter.Text += "<div>Ngày nộp: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate")) & "</b></div>"

            liter = e.Item.FindControl("ProfileUser")
            liter.Text = "<div>Họ tên: <b>" & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "CreatedUser")) & "</b></div>"
            liter.Text += flCheck.JobUser_Name(PortalSettings.ActiveTab.TabName & "/edit/job-job-user", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "JobUser_ID"), True)
            If DataBinder.Eval(e.Item.DataItem, "IsInvite") <> "0" Then liter.Text += "<div class=""label-success label"">Đã chắp nối</div></div>"

            chBox = e.Item.FindControl("IsView")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsView")
            chBox.Enabled = IsActive.Value
            If chBox.Checked = False Then e.Item.CssClass = "blue"

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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã cập nhật lại thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Sub SetBorderRPT(celName As String, row As Integer)
            wsh.Cells(celName & row).Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black)
        End Sub
        Private Function GetPositionName(id As String) As String
            Dim objPos As CMS_PositionInfo = flDnn.CMS_Position_Get(Me.PortalId, flReg.WriteNumber(id))
            If objPos IsNot Nothing Then
                GetPositionName = flReg.RemoveScript(objPos.Position_Name, False)
            Else
                GetPositionName = ""
            End If
        End Function
        Private Function GetEducationName(id As String) As String
            Dim objPos As CMS_EducationInfo = flDnn.CMS_Education_Get(Me.PortalId, flReg.WriteNumber(id))
            If objPos IsNot Nothing Then
                GetEducationName = flReg.RemoveScript(objPos.Education_Name, False)
            Else
                GetEducationName = ""
            End If
        End Function
        Protected Sub btnExport_Click(sender As Object, e As EventArgs)
            Try
                Dim fileSave = flReg.GenKey() & ".xlsx"
                Dim pathTemp = Server.MapPath(flReg.MapPath("/data/" & Me.PortalId & "/temps/") & fileSave)
                Dim file As FileInfo
                Dim IsRows, intI As Integer
                Dim package As ExcelPackage
                Dim ubj As CMSUserPortalInfo
                Dim objW As CMS_WorkInfo
                Dim objJUS As CMS_JobUserInfo
                file = New FileInfo(Server.MapPath("/api/work/Template/HSDaUngTuyen.xlsx"))
                package = New ExcelPackage(file)
                wsh = package.Workbook.Worksheets.First()
                If IsNothing(wsh) = False Then
                    wsh.Cells("A2").Value = "DANH SÁCH LAO ĐỘNG ĐÃ ỨNG TUYỂN"
                    IsRows = 4 : intI = 1
                    arrTemp = objController.CMS_Recruitment_List_Search_HSUT(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, 1,
                                                       10000, Gender.SelectedValue, Business_ID.SelectedValue, Experience_ID.SelectedValue,
                                                        TinhTP.SelectedValue, PhuongXa.SelectedValue, Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, "")
                    For Each Cr As CMS_RecruitmentInfo In arrTemp
                        wsh.Cells("A" & IsRows).Value = intI : SetBorderRPT("A", IsRows)
                        wsh.Cells("B" & IsRows).Value = flReg.ReadDate(Cr.CreateDate, False) : SetBorderRPT("B", IsRows)
                        wsh.Cells("C" & IsRows).Value = flReg.GetUserName(Cr.CreatedUser) : SetBorderRPT("C", IsRows)
                        ubj = flDnn.CMSUserPortal_Get_By_User("", Cr.CreatedUser, "", Me.PortalId)
                        If ubj IsNot Nothing Then
                            wsh.Cells("D" & IsRows).Value = flReg.ReadDate(ubj.DateOfBirth, False) : SetBorderRPT("D", IsRows)
                            wsh.Cells("E" & IsRows).Value = flDic.Sex_Name(ubj.Gender) : SetBorderRPT("E", IsRows)
                            wsh.Cells("F" & IsRows).Value = ubj.CMND : SetBorderRPT("F", IsRows)
                            wsh.Cells("G" & IsRows).Value = ubj.Telephone : SetBorderRPT("G", IsRows)
                            wsh.Cells("H" & IsRows).Value = ubj.Email : SetBorderRPT("H", IsRows)
                            wsh.Cells("I" & IsRows).Value = ubj.Address : SetBorderRPT("I", IsRows)
                        Else
                            wsh.Cells("D" & IsRows).Value = "" : SetBorderRPT("D", IsRows)
                            wsh.Cells("E" & IsRows).Value = "" : SetBorderRPT("E", IsRows)
                            wsh.Cells("F" & IsRows).Value = "" : SetBorderRPT("F", IsRows)
                            wsh.Cells("G" & IsRows).Value = "" : SetBorderRPT("G", IsRows)
                            wsh.Cells("H" & IsRows).Value = "" : SetBorderRPT("H", IsRows)
                            wsh.Cells("I" & IsRows).Value = "" : SetBorderRPT("I", IsRows)
                        End If
                        objJUS = objController.CMS_JobUser_Get(Me.PortalId, Cr.JobUser_ID)
                        If objJUS IsNot Nothing Then
                            wsh.Cells("J" & IsRows).Value = flReg.RemoveHTML(HttpUtility.HtmlDecode(objJUS.Education)) : SetBorderRPT("J", IsRows)
                            wsh.Cells("K" & IsRows).Value = GetEducationName(objJUS.Level_ID) : SetBorderRPT("K", IsRows)
                            wsh.Cells("L" & IsRows).Value = flCheck.Career_Name(Me.PortalId, objJUS.Career_ID) : SetBorderRPT("L", IsRows)
                            wsh.Cells("M" & IsRows).Value = "" : SetBorderRPT("M", IsRows)
                            wsh.Cells("N" & IsRows).Value = "" : SetBorderRPT("N", IsRows)
                            wsh.Cells("O" & IsRows).Value = flCheck.Experience_Name(Me.PortalId, objJUS.Experience_ID) : SetBorderRPT("O", IsRows)
                            wsh.Cells("P" & IsRows).Value = GetPositionName(objJUS.LevelDesired) : SetBorderRPT("P", IsRows)
                        Else
                            wsh.Cells("J" & IsRows).Value = "" : SetBorderRPT("J", IsRows)
                            wsh.Cells("K" & IsRows).Value = "" : SetBorderRPT("K", IsRows)
                            wsh.Cells("L" & IsRows).Value = "" : SetBorderRPT("L", IsRows)
                            wsh.Cells("M" & IsRows).Value = "" : SetBorderRPT("M", IsRows)
                            wsh.Cells("N" & IsRows).Value = "" : SetBorderRPT("N", IsRows)
                            wsh.Cells("O" & IsRows).Value = "" : SetBorderRPT("O", IsRows)
                            wsh.Cells("P" & IsRows).Value = "" : SetBorderRPT("P", IsRows)
                        End If
                        objW = objController.CMS_Work_Get(Me.PortalId, Cr.Work_ID)
                        If objW IsNot Nothing Then
                            wsh.Cells("Q" & IsRows).Value = flReg.ReadDate(objW.CreatedDate, False) : SetBorderRPT("Q", IsRows)
                            wsh.Cells("R" & IsRows).Value = flCheck.Business_Name("", Me.PortalId, objW.Business_ID, Me.PortalId) : SetBorderRPT("R", IsRows)
                            wsh.Cells("S" & IsRows).Value = flDic.RegionalName(Me.PortalId, objW.TinhTP, "") : SetBorderRPT("S", IsRows)

                            Dim status As String = ""

                            If Cr.IsView Then status += "Đã xem;"
                            If Cr.IsContact Then status += "Đã liên hệ;"
                            If Cr.IsInterview Then status += "Đã phỏng vấn;"
                            If Cr.IsTest Then status += "Đã test;"
                            If Cr.IsElect Then status += "Trúng tuyển;"
                            If Cr.IsCancel Then status += "Từ chối;"

                            wsh.Cells("T" & IsRows).Value = status : SetBorderRPT("T", IsRows)
                            Else
                                wsh.Cells("Q" & IsRows).Value = "" : SetBorderRPT("Q", IsRows)
                            wsh.Cells("R" & IsRows).Value = "" : SetBorderRPT("R", IsRows)
                            wsh.Cells("S" & IsRows).Value = "" : SetBorderRPT("S", IsRows)
                            wsh.Cells("T" & IsRows).Value = "" : SetBorderRPT("T", IsRows)
                        End If

                        IsRows += 1 : intI += 1
                    Next
                    package.SaveAs(New FileInfo(pathTemp))
                    package.Dispose()
                    flReg.SaveFileName(pathTemp, "HSDaUngTuyen" & Now.ToString("_dd_MM_yy") & ".xlsx")
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class

End Namespace
