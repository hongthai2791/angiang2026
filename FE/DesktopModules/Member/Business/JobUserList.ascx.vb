Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace Modules.PageWork
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objContrller As New WorkController
        Dim arr As New ArrayList
        Dim obj As New CMS_SearchInfo
        Dim cInfo As New CMS_CareerInfo
        Dim str As String
        Dim liter As Literal
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName

        Private Sub GetID()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = 0 Then currPage.Value = 1
            Call flDic.LoadSex(GioiTinh, "Tất cả Giới tính")
            If Request.Item("gt") & "" <> "" Then GioiTinh.SelectedValue = Request.Item("gt")

            Call flFunction.LoadCareer(Me.PortalId, NganhNghe, "Tất cả Ngành nghề")
            If Request.Item("caid") & "" <> "" Then NganhNghe.SelectedValue = Request.Item("caid")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") & "" <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadEducation(Me.PortalId, TrinhDo, "Tất cả Trình độ")
            If Request.Item("lev") & "" <> "" Then TrinhDo.SelectedValue = Request.Item("lev")

            Call flDic.LoadPosition(Me.PortalId, ChucVu, "Tất cả Chức vụ")
            If Request.Item("pos") & "" <> "" Then ChucVu.SelectedValue = Request.Item("pos")

            Call flFunction.LoadSalary(Me.PortalId, MucLuong, "Tất cả Mức lương")
            If Request.Item("sar") & "" <> "" Then MucLuong.SelectedValue = Request.Item("sar")

            Call flFunction.LoadExperience(Me.PortalId, KinhNghiem, "Tất cả Kinh nghiệm")
            If Request.Item("ex") & "" <> "" Then KinhNghiem.SelectedValue = Request.Item("ex")
            usName.Value = Me.UserInfo.Username
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
            Dim strScript = "popDetailJobuser(" & Me.PortalId & ",'" & Request.Item("itemid") & "','" & Me.UserInfo.Username & "')" & ";"
            If flReg.WriteNumber(Request.Item("itemid")) <> 0 Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "popDetailJobuser", "addClassModal();" & strScript, True)
            End If

        End Sub

        Private Sub LoadValue()
            arr = objContrller.CMS_JobUser_List_Home_BKUV(Me.PortalId, flReg.RemoveScript(txtkey.Text, False), currPage.Value, 35, NganhNghe.SelectedValue, TrinhDo.SelectedValue, ChucVu.SelectedValue, MucLuong.SelectedValue, KinhNghiem.SelectedValue, TinhTP.SelectedValue, GioiTinh.SelectedValue)
            grdData.DataSource = arr
            grdData.DataKeyField = "JobUser_ID"
            grdData.DataBind()
            litPage.Text = "" : litCount.Text = 0
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_JobUserInfo In arr
                litPage.Text = flReg.NextPage(Cr.Total, 35, currPage.Value, 5, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next


        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()
            'strUrl = "/" & _tabName & "/edit/" & Request.Item("view") & "/itemID/" & DataBinder.Eval(e.Item.DataItem, "ID")

            liter = e.Item.FindControl("CVUngVien")
            'liter.Text += "<a href=""/business/edit/bus-jobuser/itemid/" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & """ title=""" & flReg.ImgAlt(DataBinder.Eval(e.Item.DataItem, "Title")) & """ class=""text_grey2"">" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"

            liter.Text = "<div class=""hotenvi""><a onclick='popDetailJobuser(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & """,""" & Me.UserInfo.Username & """);'  title='Xem chi tiết thông tin hồ sơ'>"
            liter.Text += DataBinder.Eval(e.Item.DataItem, "Title") & "</a></div>"

            liter = e.Item.FindControl("MucLuong")
            liter.Text += IIf(DataBinder.Eval(e.Item.DataItem, "Salary_ID") = "", "Thỏa thuận", flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")))

            liter = e.Item.FindControl("NganhNghe")
            liter.Text += flCheck.Career_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Career_ID"))

            liter = e.Item.FindControl("TrinhDo")
            liter.Text += flDic.Education_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Level_ID"))
            liter = e.Item.FindControl("NgayDang")
            liter.Text += flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False)


            liter = e.Item.FindControl("DiaChi")
            liter.Text = flDic.Regional_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), "", True)

        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & _tabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If NganhNghe.SelectedValue <> "" Then RedirectURL += "/caid/" & NganhNghe.SelectedValue
            If TrinhDo.SelectedValue <> "" Then RedirectURL += "/lev/" & TrinhDo.SelectedValue
            If ChucVu.SelectedValue <> "" Then RedirectURL += "/pos/" & ChucVu.SelectedValue
            If MucLuong.SelectedValue <> "" Then RedirectURL += "/sar/" & MucLuong.SelectedValue
            If KinhNghiem.SelectedValue <> "" Then RedirectURL += "/ex/" & KinhNghiem.SelectedValue
            If GioiTinh.SelectedValue <> "" Then RedirectURL += "/gt/" & GioiTinh.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                'flReg.BugLog(Me.PortalId, ex.Message, "app")
                litPage.Text = ex.Message
            End Try
        End Sub
        Private Sub KinhNghiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KinhNghiem.SelectedIndexChanged, TinhTP.SelectedIndexChanged, MucLuong.SelectedIndexChanged, TrinhDo.SelectedIndexChanged, ChucVu.SelectedIndexChanged, NganhNghe.SelectedIndexChanged, cmdSearch.Click, GioiTinh.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValue()
        End Sub
    End Class
End Namespace