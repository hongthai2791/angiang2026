Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim tkInfo As New CMS_ThongKeBaoCaoInfo
        Dim strURL, sClass As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onClick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            IsSuper.Value = "true" 'flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            If IsSuper.Value <> "true" Then IsActive.Visible = False
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_PhienGiaoDich_List_Search(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value, drPageSize.SelectedValue, IsSuper.Value)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "PhienGD_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litCount.Text = 0 : litPage.Text = ""
            For Each Cr As CMS_PhienGiaoDichInfo In arrTemp
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
            RedirectURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
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
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view"), True)
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged
            Response.Redirect(RedirectURL, True)
        End Sub

        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.CMS_PhienGiaoDich_Delete(Me.PortalId, grdData.DataKeys(i))
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
        Private Function Progerss(BatDau As DateTime, KetThuc As DateTime) As String
            If KetThuc < Now Then
                sClass = "mr-da"
                Return "<div class='progress-end'>Đã diễn ra</div>"
            ElseIf BatDau > Now Then
                sClass = "mr-sap"
                Return "<div class='progress-new'>Sắp diễn ra</div>"
            Else
                sClass = "mr-dang"
                Return "<div class='progress-run'>Đang diễn ra</div>"
            End If
        End Function

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "PhienGD_ID")

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId

            liter = e.Item.FindControl("ThoiGian")
            liter.Text = "<div>Từ: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "Thoigian_BatDau")) & "</div>"
            liter.Text += "<div>Đến: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ThoiGian_KetThuc")) & "</div>"

            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class='aedit' title='Chi tiết' href='" & strURL & "'><img src='" & flText.EditImg & "' alt='Sửa'/></a>"
            liter.Text += "&nbsp;|&nbsp;<a class='view' onclick='viewresult(""" & ItemId & """);' title='Xem kết quả việc làm' ><img src='" & flText.ViewImg & "' alt='View'/></a>"

            liter = e.Item.FindControl("PhienGiaoDich")
            liter.Text = "<a class='td-a-title " & sClass & "' href='/" & PortalSettings.ActiveTab.TabName & "/view/mar-market-run/itemid/" & ItemId & "'>" & DataBinder.Eval(e.Item.DataItem, "Tenphien") & "</a><br/>"
            liter.Text += "<span >Địa điểm: " & DataBinder.Eval(e.Item.DataItem, "Diadiem") & "</span><br />"
            If DataBinder.Eval(e.Item.DataItem, "Hotline") <> "" Then liter.Text += "<span> Hotline: " & DataBinder.Eval(e.Item.DataItem, "Hotline") & "</span>"

            liter = e.Item.FindControl("ThongTin")
            liter.Text = "<a class='td-a-title' href='/" & PortalSettings.ActiveTab.TabName & "/view/mar-market-run/itemid/" & ItemId & "'>"
            liter.Text += "<div class='col-sm-4'>" & Progerss(DataBinder.Eval(e.Item.DataItem, "Thoigian_BatDau"), DataBinder.Eval(e.Item.DataItem, "ThoiGian_KetThuc")) & "</div></a>"

            tkInfo = objController.CMS_ThongKeBaoCao_SanVL(Me.PortalId, ItemId)
            If IsNothing(tkInfo) = False Then
                liter.Text += "<div class='col-sm-8'>Nhà tuyển dụng: " & tkInfo.SoBan & " <br/>"
                liter.Text += "Số lượng tin tuyển dụng: " & tkInfo.ViecLam & "<br/>"
                liter.Text += "Ứng viên: " & tkInfo.ThamGia & "</div>"
            Else
                liter.Text += "<div class='col-sm-8'>Nhà tuyển dụng: 0 <br/>"
                liter.Text += "Số lượng tin tuyển dụng: 0<br/>"
                liter.Text += "Ứng viên: 0</div>"
            End If

            'e.Item.CssClass = sClass
        End Sub

    End Class

End Namespace
