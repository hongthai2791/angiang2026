Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.US.Market_List
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String, bitActive As Integer
        Dim tkInfo As New CMS_ThongKeBaoCaoInfo

        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
        End Sub

        Private Sub LoadValues()
            arrTemp = objController.CMS_PhienGiaoDich_List_Search_Member(Me.PortalId, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value, drPageSize.SelectedValue)
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
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged
            Response.Redirect(RedirectURL, True)
        End Sub

        Private Function Progerss(BatDau As DateTime, KetThuc As DateTime) As String
            If KetThuc < Now Then
                bitActive = 1
                Return "<div class='progress-end'>Đã diễn ra</div>"
            ElseIf BatDau > Now Then
                bitActive = 2
                Return "<div class='progress-new'>Sắp diễn ra</div>"
            Else
                bitActive = 3
                Return "<div class='progress-run'>Đang diễn ra</div>"
            End If
        End Function

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "PhienGD_ID")

            If flCheck.UngVien_ID(Me.PortalId, ItemId, Me.UserInfo.Username) = "" Then
                liter = e.Item.FindControl("PhienGiaoDich")
                liter.Text = "<a class='td-a-title' href='javascript::'>" & DataBinder.Eval(e.Item.DataItem, "Tenphien") & "</a><br/>"
                liter.Text += "<span style = ""font-size:13px;"" >Địa điểm: " & DataBinder.Eval(e.Item.DataItem, "Diadiem") & "</span><br />"
                liter.Text += "<span style = ""font-size:13px;"" > Hotline: " & DataBinder.Eval(e.Item.DataItem, "Hotline") & "</span>"

                liter = e.Item.FindControl("ThongTin")
                liter.Text = "<div class='col-sm-4'>" & Progerss(DataBinder.Eval(e.Item.DataItem, "Thoigian_BatDau"), DataBinder.Eval(e.Item.DataItem, "ThoiGian_KetThuc")) & "</div>"

                liter = e.Item.FindControl("IsEdit")
                If bitActive > 1 Then
                    liter.Text = "<a title='Chi tiết' onclick=""thamgia('" & ItemId & "')"">Đăng ký tham gia</a>"
                Else
                    liter.Text = "Đã quá hạn"
                End If
            Else
                liter = e.Item.FindControl("IsEdit")
                liter.Text = "Đã tham gia"

                liter = e.Item.FindControl("PhienGiaoDich")
                liter.Text = "<a class='td-a-title' href='/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId & "'>" & DataBinder.Eval(e.Item.DataItem, "Tenphien") & "</a><br/>"
                liter.Text += "<span style = ""font-size:13px;"" >Địa điểm: " & DataBinder.Eval(e.Item.DataItem, "Diadiem") & "</span><br />"
                liter.Text += "<span style = ""font-size:13px;"" > Hotline: " & DataBinder.Eval(e.Item.DataItem, "Hotline") & "</span>"

                liter = e.Item.FindControl("ThongTin")
                liter.Text = "<div class='col-sm-4'><a class='td-a-title' href='/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemId & "'>" & Progerss(DataBinder.Eval(e.Item.DataItem, "Thoigian_BatDau"), DataBinder.Eval(e.Item.DataItem, "ThoiGian_KetThuc")) & "</a></div>"

            End If
            tkInfo = objController.CMS_ThongKeBaoCao_SanVL(Me.PortalId, ItemId)
            liter = e.Item.FindControl("ThongTin")
            If IsNothing(tkInfo) = False Then
                liter.Text += "<div class='col-sm-8'>Nhà tuyển dụng: " & tkInfo.SoBan & " <br/>"
                liter.Text += "Số lượng tuyển dụng: " & tkInfo.ViecLam & "<br/>"
                liter.Text += "Ứng viên: " & tkInfo.ThamGia & "</div>"
            Else
                liter.Text += "<div class='col-sm-8'>Nhà tuyển dụng: 0 <br/>"
                liter.Text += "Số lượng tuyển dụng: 0<br/>"
                liter.Text += "Ứng viên: 0</div>"
            End If

            liter = e.Item.FindControl("ThoiGian")
            liter.Text = "<div>Từ: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "Thoigian_BatDau")) & "</b></div>"
            liter.Text += "<div>Đến: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ThoiGian_KetThuc")) & "</b></div>"
        End Sub

        Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
            Try
                Dim objPhien As CMS_PhienGiaoDichInfo = objController.CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID.Value)
                If IsNothing(objPhien) = False Then
                    Dim obj As New CMS_UngVienInfo
                    obj.UngVien_ID = flReg.GenKey()
                    obj.Email = Me.UserInfo.Email
                    obj.Tel = flReg.Telephone(Me.PortalId, Me.UserInfo.Username)
                    obj.TenDayDu = Me.UserInfo.DisplayName
                    obj.NguoiTimViec_ID = Me.UserInfo.Username
                    obj.LoaiUngVien = LoaiUngVien.DaDangKy
                    obj.NamKinhNghiem = 0
                    obj.NganhNghe = 0
                    obj.ViTriUngTuyen = ""
                    obj.TrinhDoChuyenMon = ""
                    'obj.NgaySinh = flReg.DateNull
                    obj.NgaySinh = flReg.WriteDate(flDic.getNgaySinh(0, Me.UserInfo.Username, ""), False)
                    obj.CreatedBy = Now
                    obj.GioiTinh = flDic.getGioiTinh(0, Me.UserInfo.Username, "")
                    obj.DiaChi = flDic.getDiaChi(0, Me.UserInfo.Username, "")
                    obj.PhienGD_ID = PhienGD_ID.Value
                    objController.CMS_UngVien_Add(Me.PortalId, obj)
                End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã đăng ký tham gia thành công.', 'Thông báo', false);", True)
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class

End Namespace
