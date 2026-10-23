Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_LopHocView

    Partial Class View
        Inherits Entities.Modules.PortalModuleBase

#Region "Varial..."

        Dim strURL As String
        Dim liter As Literal
        Dim chkBox As CheckBox
        Dim arrTemp As New ArrayList
        Dim ObjController As New WorkController
#End Region

#Region "Function..."
        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdSearch.ClientID + "')")
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có chắc chắn muốn xóa các lớp học đã chọn không?');")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)

            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")

            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Sắp xếp mặc định", "0"))
            drSort.Items.Add(New ListItem("Sắp xếp theo tên", "1"))
        End Sub
        Private Function regUrl(id As String) As String
            regUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & id
        End Function
        Private Sub LoadValues()
            arrTemp = ObjController.DTNGHE_LopHoc_List_Search(txtkey.Text, drSort.SelectedValue, currPage.Value, drPageSize.SelectedValue, "")

            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Id"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectUrl()
            For Each Ci As DTNGHE_LopHocInfo In arrTemp
                litPage.Text = flReg.NextPage(Ci.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Ci.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(Me.pageView, Me.pageView.GetType(), "removewaiting", "removewaiting();", True)
        End Sub

#End Region

#Region "Event..."
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Function RedirectUrl() As String
            RedirectUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If drPageSize.SelectedValue <> "35" Then RedirectUrl += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectUrl += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function

        Protected Sub grdData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            strURL = regUrl(DataBinder.Eval(e.Item.DataItem, "Id"))

            liter = e.Item.FindControl("TenLopHoc")
            liter.Text = "<a class=""aedit"" href=""" & strURL & """>" & DataBinder.Eval(e.Item.DataItem, "TenLopHoc") & "</a>"

            liter = e.Item.FindControl("NgheDaoTao")
            liter.Text = flCheck.DTNGHE_NgheDaoTao_Name(DataBinder.Eval(e.Item.DataItem, "NgheDaoTao"))

            liter = e.Item.FindControl("NgayKhaiGiang")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgayKhaiGiang"), True)

            liter = e.Item.FindControl("NgayKetThuc")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgayKetThuc"), True)
            liter = e.Item.FindControl("TenGiangVien")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "TenGiangVien")

            liter = e.Item.FindControl("ThoiGianDaoTao")
            liter.Text = flCheck.DTNGHE_ThoiGianDaoTao_Name(DataBinder.Eval(e.Item.DataItem, "ThoiGianDaoTao"))

            liter = e.Item.FindControl("TrangThai")
            Dim statusValue As Integer = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "TrangThai"))
            Select Case statusValue
                Case 1
                    liter.Text = "<span class='label label-info'>Sắp mở</span>"
                Case 2
                    liter.Text = "<span class='label label-success'>Đang diễn ra</span>"
                Case 3
                    liter.Text = "<span class='label label-default'>Đã kết thúc</span>"
                Case 4
                    liter.Text = "<span class='label label-danger'>Đã hủy</span>"
                Case Else
                    liter.Text = ""
            End Select
            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class=""aedit"" href=""" & strURL & """><img src=""" & flText.EditImg & "?w=20"" alt=""edit"" /></a>"

        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drSort.SelectedIndexChanged, drPageSize.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectUrl() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub cmdNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click
            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view")
            Response.Redirect(strURL & "/c/" & flReg.WriteNumber(litCount.Text) + 1, True)
        End Sub
        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chkBox = grdData.Items(i).FindControl("IsDelete")
                    If chkBox.Checked = True Then
                        ObjController.DTNGHE_LopHoc_Delete(grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success", "removewaiting();notify('success', 'Đã xóa các lớp học được chọn.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn lớp học nào để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.pageView, Me.pageView.GetType(), "error", "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết, không xóa được.', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName, True)
        End Sub
#End Region

    End Class

End Namespace