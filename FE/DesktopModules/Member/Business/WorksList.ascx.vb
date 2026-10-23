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
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
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
            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)

            Call LoadBus()
        End Sub
        Private Sub LoadBus()
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                TinhTP.Value = buInfo.TinhTP
            End If
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Work_List_Search(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value,
                                                        drPageSize.SelectedValue, Me.UserInfo.Username, Business_ID.Value, Salary_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, "0", "0", Status_ID.SelectedValue)
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

        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("~/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/tp/" & TinhTP.Value, True)
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged, Status_ID.SelectedIndexChanged
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
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
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
            If flReg.WriteNumber(DataBinder.Eval(e.Item.DataItem, "YeuCauKinhNghiem")) = 0 Then
                liter.Text += "<div>Kinh nghiệm: Chưa cập nhật</div>"
            Else
                liter.Text += "<div>Kinh nghiệm: " & flDic.TenDanhMucChung(Me.PortalId, "CMS_KinhNghiem", DataBinder.Eval(e.Item.DataItem, "YeuCauKinhNghiem")) & "</div>"

            End If
            If flReg.WriteNumber(DataBinder.Eval(e.Item.DataItem, "KieuLuong")) = 0 Then
                liter.Text += "<div>Mức lương: Chưa cập nhật</div>"
            Else

                Select Case DataBinder.Eval(e.Item.DataItem, "KieuLuong")
                    Case 1
                        liter.Text += "<div>Kiểu lương: Lương tháng</div>"
                        liter.Text += "<div>Mức lương: " & flDic.TenDanhMucChung(Me.PortalId, "CMS_MucLuongLV", DataBinder.Eval(e.Item.DataItem, "Salary_Option")) & "</div>"
                    Case 2
                        liter.Text += "<div>Kiểu lương: Lương ngày</div>"
                        liter.Text += "<div>Mức lương: " & DataBinder.Eval(e.Item.DataItem, "Salary_Text") & "</div>"
                    Case 3
                        liter.Text += "<div>Kiểu lương: Lương giờ</div>"
                        liter.Text += "<div>Mức lương: " & DataBinder.Eval(e.Item.DataItem, "Salary_Text") & "</div>"
                    Case Else
                        liter.Text += "<div>Mức lương: Chưa cập nhật</div>"

                End Select
            End If

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</div>"

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
            liter.Text = "<a class='aedit' title='Bấm để xem chi tiết hoặc cập nhật thông tin' href='" & strURL & "'>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"
            liter.Text += "<div>Khu vực: " & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</div>"
            If DataBinder.Eval(e.Item.DataItem, "IsView") <> "0" Then liter.Text += "<div>Lượt xem: " & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsView")) & "</div>"
        End Sub
    End Class

End Namespace
