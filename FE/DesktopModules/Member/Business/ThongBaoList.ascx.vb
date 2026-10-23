Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CauController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String
        Dim obj As New BC_BusinessInfo
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ItemID.Value = WORK.flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/thong-bao-bien-dong/bus/" & ItemID.Value

        End Sub
        Private Sub LoadValues()
            obj = objController.BC_Business_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                TenDN.Text = obj.TenDoanhNghiep
                DiaChi.Text = flDic.Address(Me.PortalId, obj.SoNha, obj.XaPhuong, obj.QuanHuyen, obj.TinhTP)
                MaSoThue.Text = obj.TaxCode
                DienThoai.Text = obj.Mobile
                Email.Text = obj.Email
            Else
                Response.Redirect("/business/view/bus-update-profile", True)
            End If
            arrTemp = objController.BC_ThongBao_Get_By_BC_Business(Me.PortalId, ItemID.Value)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "ThongBao_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litCount.Text = 0
            litPage.Text = ""
            For Each Cr As BC_ThongBaoInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/thong-bao-bien-dong/bus/" & ItemID.Value
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
                litPage.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/bus/" & ItemID.Value, True)
        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged
            Response.Redirect(RedirectURL, True)
        End Sub

        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.BC_ThongBao_Delete(Me.PortalId, grdData.DataKeys(i))
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

            liter = e.Item.FindControl("NgayThongBao")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "NgayThongBao")

            liter = e.Item.FindControl("Years_ID")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Years_ID")

            liter = e.Item.FindControl("Period_ID")
            liter.Text = flCheck.Period_Name(DataBinder.Eval(e.Item.DataItem, "Period_ID"))

            liter = e.Item.FindControl("CreatedDate")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreatedDate"))

            liter = e.Item.FindControl("UpdatedDate")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "UpdatedDate"))


            If flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgayNop")) <> "" Then
                liter = e.Item.FindControl("TinhTrang")
                liter.Text = "Đã nộp thông báo ngày " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgayNop"))
                chBox = e.Item.FindControl("IsDelete")
                chBox.Enabled = False
            End If

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "ThongBao_ID") & "/bus/" & ItemID.Value
            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class='aedit' title='Chi tiết' href='" & strURL & "'><img src='" & flText.EditImg & "' alt='Sửa'/></a>"

        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName, True)
        End Sub
    End Class

End Namespace
