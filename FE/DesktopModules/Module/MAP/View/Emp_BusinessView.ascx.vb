Imports DotNetNuke.MAP
Imports DotNetNuke.EPORTAL

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New MapController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim strURL As String
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            cmdNew.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn đồng bộ lại dữ liệu này không?');")
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "", "")
            TinhTP.SelectedValue = flReg.WebConfig("TinhTp")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, QuanHuyen.SelectedValue)
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.MAP_DATA_BUSSINESS_List_Search(Me.PortalId, txtkey.Text.Trim, currPage.Value, drPageSize.SelectedValue,
                                 TinhTP.SelectedValue, flReg.WriteNumber(QuanHuyen.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue))
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            litPage.Text = ""
            litCount.Text = 0
            For Each Cr As MAP_DATA_BUSSINESSInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If QuanHuyen.SelectedValue <> "" Then RedirectURL += "/qh/" & QuanHuyen.SelectedValue
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Try
                Dim wCTL As New WORK.WorkController
                Dim busNew As MAP_DATA_BUSSINESSInfo
                objController.MAP_DATA_BUSSINESS_Delete_ByHC(Me.PortalId, TinhTP.SelectedValue, QuanHuyen.SelectedValue, PhuongXa.SelectedValue)
                arrTemp = wCTL.CMS_Business_List_LatLng(TinhTP.SelectedValue, flReg.WriteNumber(QuanHuyen.SelectedValue), flReg.WriteNumber(PhuongXa.SelectedValue))
                For Each cr As WORK.CMS_BusinessInfo In arrTemp
                    busNew = New MAP_DATA_BUSSINESSInfo
                    busNew.Business_ID = cr.Business_ID
                    busNew.Business_Vn = cr.Business_Vn
                    busNew.TinhTP = cr.TinhTP
                    busNew.QuanHuyen = cr.QuanHuyen
                    busNew.XaPhuong = cr.PhuongXa
                    busNew.Description = cr.Description
                    busNew.TaxCode = cr.TaxCode
                    busNew.Mobile = cr.Mobile
                    busNew.Fax = cr.Fax
                    busNew.Website = cr.Website
                    busNew.Email = cr.Email
                    busNew.Address = cr.Address
                    busNew.Lat = cr.Lat
                    busNew.Lng = cr.Lng
                    busNew.Career_ID = cr.Career_ID
                    busNew.LoaiHinh_ID = cr.LoaiHinh_ID
                    busNew.ToURL = WORK.flCheck.GetHomeLinkBusiness(cr.Business_ID)
                    objController.MAP_DATA_BUSSINESS_Add(Me.PortalId, busNew)
                Next
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('success', 'Đã đồng bộ dữ liệu thành công.', 'Thông báo', false);", True)
                Call LoadValues()
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.ToString, Me.PortalSettings.ActiveTab.TabName)
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, QuanHuyen.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub

        Protected Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsDelete")
                    If chBox.Checked = True Then
                        objController.MAP_DATA_BUSSINESS_Delete(Me.PortalId, grdData.DataKeys(i))
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

            ItemId = DataBinder.Eval(e.Item.DataItem, "Business_ID")
            strURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId


            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            liter = e.Item.FindControl("Business_Vn")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Business_Vn")

            liter = e.Item.FindControl("Lat")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Lat")

            liter = e.Item.FindControl("Lng")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Lng")
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
    End Class

End Namespace
