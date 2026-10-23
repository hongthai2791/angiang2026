Imports DotNetNuke.EPORTAL
Imports DotNetNuke.MAP

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New MapController()
        Dim arrTemp As New ArrayList, itemid As String
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim strURL As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            cmdNew.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn đồng bộ lại dữ liệu này không?');")

            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "", "")

            TinhTP.SelectedValue = flReg.WebConfig("TinhTp")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, QuanHuyen.SelectedValue)
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.MAP_DATA_WORK_List_Search(Me.PortalId, txtkey.Text.Trim, currPage.Value, drPageSize.SelectedValue,
                                 TinhTP.SelectedValue, flReg.WriteNumber(QuanHuyen.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue))
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()

            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As MAP_DATA_WORKInfo In arrTemp
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
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If QuanHuyen.SelectedValue <> "" Then RedirectURL += "/qh/" & QuanHuyen.SelectedValue
            If PhuongXa.SelectedValue <> "" Then RedirectURL += "/px/" & PhuongXa.SelectedValue
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
            Try
                Dim wCTL As New WORK.WorkController
                Dim workNew As MAP_DATA_WORKInfo
                objController.MAP_DATA_WORK_Delete_ByHC(Me.PortalId, TinhTP.SelectedValue, QuanHuyen.SelectedValue, PhuongXa.SelectedValue)
                arrTemp = wCTL.CMS_Work_List_LatLng(TinhTP.SelectedValue, flReg.WriteNumber(QuanHuyen.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue))
                For Each cr As WORK.CMS_WorkInfo In arrTemp
                    workNew = New MAP_DATA_WORKInfo
                    workNew.Id = cr.ID
                    workNew.Work_ID = cr.Work_ID
                    workNew.Business_ID = cr.Business_ID
                    workNew.Title = cr.Title
                    workNew.Salary_ID = cr.Salary_ID
                    workNew.Quantity = cr.Quantity
                    workNew.Experience_ID = cr.Experience_ID
                    workNew.Gender = cr.Gender
                    workNew.Level_ID = cr.Level_ID
                    workNew.TinhTP = cr.TinhTP
                    workNew.QuanHuyen = cr.QuanHuyen
                    workNew.XaPhuong = cr.PhuongXa
                    workNew.TypeOf_ID = cr.TypeOf_ID
                    workNew.Career_ID = cr.Career_ID
                    workNew.Description = cr.Description
                    workNew.ExpiredDate = flReg.WriteDate(cr.ExpiredDate)
                    workNew.StartDate = flReg.WriteDate(cr.StartDate)
                    workNew.EndDate = flReg.WriteDate(cr.EndDate)
                    workNew.IsHot = cr.IsHot
                    workNew.IsUrgent = cr.IsUrgent
                    workNew.Lat = cr.Lat
                    workNew.Lng = cr.Lng

                    workNew.TenTinh = flDic.Regional_Name(PortalId, cr.TinhTP, "", True)
                    workNew.TenHuyen = flDic.Regional_Name(PortalId, cr.QuanHuyen, "", True)
                    workNew.TenXa = flDic.Regional_Name(PortalId, cr.PhuongXa, "", True)
                    workNew.MucLuong = WORK.flCheck.Salary_Name(Me.PortalId, cr.Salary_ID)
                    workNew.KinhNghiem = WORK.flCheck.Experience_Name(Me.PortalId, cr.Experience_ID)
                    workNew.TenDoanhNghiep = WORK.flCheck.Business_Vn(Me.PortalId, cr.Business_ID)
                    workNew.ToUrl = WORK.flCheck.GetHomeLinkWork(cr.Title, cr.ID)
                    objController.MAP_DATA_WORK_Add(Me.PortalId, workNew)
                Next
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('success', 'Đã đồng bộ dữ liệu thành công.', 'Thông báo', false);", True)
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuanHuyen.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.MAP_DATA_WORK_Delete(Me.PortalId, grdData.DataKeys(i))
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
            liter = e.Item.FindControl("Infomation")
            liter.Text = "<div>DN: " & flReg.RemoveScript(WORK.flCheck.Business_Name("", Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Business_ID")), False) & "</div>"
            liter.Text += "<div>Kinh nghiệm: " & WORK.flCheck.Experience_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Experience_ID")) & "</div>"
            liter.Text += "<div>Mức lương: " & WORK.flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</div>"
            liter.Text += "<div>Đăng từ: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</div>"
            liter.Text += "<div>Đến ngày: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "EndDate"), False) & "</div>"

            liter = e.Item.FindControl("Title")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Title")
            liter.Text += "<div>Khu vực: " & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</div>"

            liter = e.Item.FindControl("Lat")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Lat")

            liter = e.Item.FindControl("Lng")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Lng")

        End Sub


    End Class

End Namespace
