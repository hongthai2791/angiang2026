Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules

    Public MustInherit Class News_Admin
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim IsLang As String = Threading.Thread.CurrentThread.CurrentCulture.Name
        Dim arr As ArrayList, lit As Literal
        Dim hLink As HyperLink, strUrl As String
        Dim ckSelect As CheckBox, crTotal As Integer
        Dim str() As String, isLock As Boolean
        Public strCssCn As String


        Private Sub GetID()
            If Request.Item("isactive") & "" <> "" Then
                chkIsActive.Checked = Request.Item("isactive")
                lbtShowNews.Visible = chkIsActive.Checked
                lbtDelete.Visible = chkIsActive.Checked
                lbtHideNews.Visible = Not chkIsActive.Checked
            End If
            strUrl = Request.Item("flag") & ""
            If strUrl <> "" Then
                If strUrl.Contains("1") = True Then chkIsFocus.Checked = True
                If strUrl.Contains("2") = True Then chkHotSite.Checked = True
                If strUrl.Contains("3") = True Then chkIsEvent.Checked = True
                If strUrl.Contains("4") = True Then chkHotCat.Checked = True
            End If
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1

            txtTitle.Text = flCheck.DecodeSearch(Request.Item("key") & "")

            If Request.Item("fromdate") & "" <> "" Then
                FromDate.Text = Request.Item("fromdate").Replace("-", "/")
            Else
                FromDate.Text = Now.AddMonths(-3).ToString("dd/MM/yyyy")
            End If
            If Request.Item("todate") & "" <> "" Then
                ToDate.Text = Request.Item("todate").Replace("-", "/")
            Else
                ToDate.Text = Now.AddMonths(1).ToString("dd/MM/yyyy")
            End If
            WF_Status.Value = flReg.WriteNumber(Request.Item("status"))
            If chkIsActive.Checked = True Then hdf_Active.Value = 0
        End Sub

        Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Try
                txtTitle.Attributes.Add("onkeypress", "return clickButton(event,'" + lbtFind.ClientID + "')")
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    Call GetID()
                    Call flFunction.LoadCategories(ddlCategory, ddlPortal.SelectedValue, "admin", CategoryType.Album)
                    ddlCategory.SelectedValue = flReg.WriteNumber(Request.Item("catid"))
                    Call LoadValues()
                    txtTitle.Focus()
                    drgDataViewer.Columns(4).Visible = False
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Private Sub BindLoadPortal()

            ddlPortal.DataSource = Ultis.UserPortal(Me.UserInfo.Username)
            ddlPortal.DataTextField = "PortalName"
            ddlPortal.DataValueField = "PortalId"
            ddlPortal.DataBind()
            If Request.Item("pid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("pid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
            Call ChangeFont()
        End Sub

        Private Sub ChangeFont()
            strCssCn = "<link  rel='stylesheet' href='/portals/_default/skins/vbn/css/vi.css?v=3.3.3'/>"
        End Sub
        Private Function StatusCss(intStatus As Integer) As String
            If WF_Status.Value = intStatus Then Return "status-active"
            Return ""
        End Function

        Private Sub LoadValues()
            Try
                Dim arrTemp As New ArrayList
                Dim objTongHop As New CMS_TongHopInfo

                objTongHop = ObjController.CMS_News_ListAdmin_Count(ddlPortal.SelectedValue, txtTitle.Text.Trim, ddlCategory.SelectedValue,
                                                                ddlPortal.SelectedValue, flConnect.IsLang, "-1", True, hdf_Active.Value,
                                                                Request.Item("flag") & "", Ultis.getDate(FromDate.Text, True), Ultis.getDate(ToDate.Text, False))
                arrTemp = ObjController.CMS_News_ListAdmin_Search(ddlPortal.SelectedValue, txtTitle.Text.Trim, ddlCategory.SelectedValue,
                                                             ddlPortal.SelectedValue, flConnect.IsLang, WF_Status.Value, "-1", CurrentPage.Value, 35, True, hdf_Active.Value,
                                                             Request.Item("flag") & "", Ultis.getDate(FromDate.Text, True), Ultis.getDate(ToDate.Text, False))

                Select Case WF_Status.Value
                    Case "1"
                        crTotal = objTongHop.ChoDuyet
                    Case "2"
                        crTotal = objTongHop.DaXuatBan
                    Case "3"
                        crTotal = objTongHop.TraLai
                    Case "4"
                        crTotal = objTongHop.NgungXuatBan
                    Case "5"
                        crTotal = objTongHop.ChoXuatBan
                    Case Else
                        crTotal = objTongHop.DangSoan
                End Select


                If crTotal > 35 Then
                    litPage.Text = flReg.NextPage(crTotal, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                End If
                lbTotal.Text = flReg.FormatPrice(crTotal)
                drgDataViewer.DataKeyField = "NewID"
                drgDataViewer.DataSource = arrTemp
                drgDataViewer.DataBind()

                Dim surl = ""
                If Request.Item("key") & "" <> "" Then surl += "/key/" & Request.Item("key")
                If Request.Item("pid") & "" <> "" Then surl += "/pid/" & Request.Item("pid")
                If Request.Item("catid") & "" <> "" Then surl += "/catid/" & Request.Item("catid")
                If Request.Item("isactive") & "" <> "" Then surl += "/isactive/" & Request.Item("isactive")
                If Request.Item("flag") & "" <> "" Then surl += "/flag/" & Request.Item("flag")
                If Request.Item("fromdate") & "" <> "" Then surl += "/fromdate/" & Request.Item("fromdate")
                If Request.Item("todate") & "" <> "" Then surl += "/todate/" & Request.Item("todate")

                ltMyNewsCount.Text = "<a class='btmynews " & StatusCss(0) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/0" & surl & """>Đang soạn (" & objTongHop.DangSoan & ")</a>"
                ltMyNewsCount.Text += " &nbsp;<a class='btmynews " & StatusCss(1) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/1" & surl & """>Chờ duyệt (" & objTongHop.ChoDuyet & ")</a>"
                ltMyNewsCount.Text += " &nbsp;<a class='btmynews " & StatusCss(3) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/3" & surl & """>Trả lại (" & objTongHop.TraLai & ")</a>"
                ltMyNewsCount.Text += " &nbsp;<a class='btmynews " & StatusCss(5) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/5" & surl & """>Chờ xuất bản (" & objTongHop.ChoXuatBan & ")</a>"
                ltMyNewsCount.Text += " &nbsp;<a class='btmynews " & StatusCss(2) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/2" & surl & """>Đã xuất bản (" & objTongHop.DaXuatBan & ")</a>"
                ltMyNewsCount.Text += " &nbsp;<a class='btmynews " & StatusCss(4) & "' href=""/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/4" & surl & """>Ngừng xuất bản (" & objTongHop.NgungXuatBan & ")</a>"

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Function sortFlag() As String
            sortFlag = ""
            If chkIsFocus.Checked = True Then sortFlag += "1"
            If chkHotSite.Checked = True Then sortFlag += "2"
            If chkIsEvent.Checked = True Then sortFlag += "3"
            If chkHotCat.Checked = True Then sortFlag += "4"
            If sortFlag <> "" Then sortFlag = "/flag/" & sortFlag
            Return sortFlag
        End Function
        Private Function RedirectURL() As String
            Dim strFind As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/status/" & WF_Status.Value
            If txtTitle.Text.Trim <> "" Then strFind += "/key/" & flCheck.EncodeSearch(txtTitle.Text.Trim)
            If ddlPortal.SelectedValue <> Me.PortalId Then strFind += "/pid/" & ddlPortal.SelectedValue
            If ddlCategory.SelectedValue <> "0" Then strFind += "/catid/" & ddlCategory.SelectedValue
            If chkIsActive.Checked = True Then strFind += "/isactive/" & chkIsActive.Checked
            If FromDate.Text <> "" Then strFind += "/fromdate/" & FromDate.Text.Replace("/", "-")
            If ToDate.Text <> "" Then strFind += "/todate/" & ToDate.Text.Replace("/", "-")
            Return strFind & sortFlag()
        End Function
        Private Sub lbtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlPortal.SelectedIndexChanged, lbtFind.Click, ddlCategory.SelectedIndexChanged, chkIsActive.CheckedChanged, chkIsFocus.CheckedChanged, chkHotSite.CheckedChanged, chkIsEvent.CheckedChanged, chkHotCat.CheckedChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
        Protected Sub drgDataViewer_ItemDataBound(sender As Object, e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgDataViewer.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            isLock = Ultis.FormatLockByUser(DataBinder.Eval(e.Item.DataItem, "PortalId"), DataBinder.Eval(e.Item.DataItem, "IsEdited"),
                                                          Me.UserInfo.Username, DataBinder.Eval(e.Item.DataItem, "EditedUser"),
                                                          DataBinder.Eval(e.Item.DataItem, "EditedTime"), DataBinder.Eval(e.Item.DataItem, "newid"))

            hLink = e.Item.FindControl("hplTitle")
			If isLock = False Then hLink.NavigateUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "newid") & "/pid/" & ddlPortal.SelectedValue & "/page/" & Request.Item("view")

			lit = e.Item.FindControl("litProcess")
            lit.Text = "<a class=""hove-point"" onclick=""popHistory(800,600," & DataBinder.Eval(e.Item.DataItem, "newid") & "," & DataBinder.Eval(e.Item.DataItem, "PortalId") & ")"">"
            lit.Text += "<img src=""/images/cog_go.png"" alt=""Lich su""></a>"

            lit = e.Item.FindControl("litDate")
            If DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.DaXuatBan Then
                lit.Text = "<span> Ngày xuất bản: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "PublishedDate")) & " </span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.HuyXuatBan Then
                lit.Text = "<span> Người dừng: " & flCheck.GetSend2ApprovalInfo(PortalId, DataBinder.Eval(e.Item.DataItem, "CancelPublishUser"), DataBinder.Eval(e.Item.DataItem, "CancelPublishDate")) & " </span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.BiTraLai Then
                lit.Text = "<span> Người trả lại: " & flCheck.GetSend2ApprovalInfo(PortalId, DataBinder.Eval(e.Item.DataItem, "ReturnedUser"), DataBinder.Eval(e.Item.DataItem, "ReturnedDate")) & " </span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.DangBienSoan Then
                lit.Text = "<span> Người tạo: " & flCheck.GetSend2ApprovalInfo(PortalId, DataBinder.Eval(e.Item.DataItem, "UserId"), DataBinder.Eval(e.Item.DataItem, "Createdate")) & " </span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "ApprovalRequestDate") & "" <> "12:00:00 AM" Then
                lit.Text = "<span> Người gửi: " & flCheck.GetSend2ApprovalInfo(PortalId, DataBinder.Eval(e.Item.DataItem, "UserId"), DataBinder.Eval(e.Item.DataItem, "ApprovalRequestDate")) & " </span>"
            Else
                lit.Text = "<span> Người gửi: " & flCheck.GetSend2ApprovalInfo(PortalId, DataBinder.Eval(e.Item.DataItem, "ApprovalUser"), DataBinder.Eval(e.Item.DataItem, "ApprovalDate")) & " </span>"
            End If
        End Sub
        Private Sub drgDataViewer_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles drgDataViewer.ItemCommand
            Try
                Select Case e.CommandName
                    Case "cmdUnlock"
                        '1. Unlock
                        Dim newid As Integer = Integer.Parse(e.CommandArgument)
                        Ultis.UnlockNews(ddlPortal.SelectedValue, newid, Me.UserInfo.Username)
                        Call LoadValues()
                End Select
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub lbtHideNews_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtHideNews.Click
            Dim i As Integer
            Dim chkBox As CheckBox
            Dim objProcessInfo As New CMS_News_ProcessInfo

            For i = 0 To (Me.drgDataViewer.Items.Count - 1)
                chkBox = Me.drgDataViewer.Items(i).FindControl("chkItems")
                If chkBox.Checked = True Then
                    ObjController.CMS_News_Update_Visible(ddlPortal.SelectedValue, drgDataViewer.DataKeys(i), False)
                    'Version
                    With objProcessInfo
                        .ItemID = drgDataViewer.DataKeys(i)
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = ObjController.CMS_News_Get(ddlPortal.SelectedValue, drgDataViewer.DataKeys(i)).Status
                        .ProcessName = "--> Xóa dữ liệu"
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                End If
            Next
            Call LoadValues()
        End Sub
        Protected Sub lbtDelete_Click(sender As Object, e As System.EventArgs) Handles lbtDelete.Click
            Try
                Dim chkBox As CheckBox
                For i As Integer = 0 To (Me.drgDataViewer.Items.Count - 1)
                    chkBox = Me.drgDataViewer.Items(i).FindControl("chkItems")
                    If chkBox.Checked = True Then
                        Ultis.NewsHardDelete(ddlPortal.SelectedValue, Server, drgDataViewer.DataKeys(i))
                        ObjController.CMS_News_Delete(ddlPortal.SelectedValue, drgDataViewer.DataKeys(i))
                    End If
                Next
                Call LoadValues()
            Catch ex As Exception
                lbTotal.Text = ex.Message
            End Try
        End Sub
        Protected Sub lbtShowNews_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtShowNews.Click
            Dim chkBox As CheckBox
            Dim objProcessInfo As New CMS_News_ProcessInfo
            For i As Integer = 0 To (Me.drgDataViewer.Items.Count - 1)
                chkBox = Me.drgDataViewer.Items(i).FindControl("chkItems")
                If chkBox.Checked = True Then
                    ObjController.CMS_News_Update_Visible(ddlPortal.SelectedValue, drgDataViewer.DataKeys(i), True)
                    'Version
                    With objProcessInfo
                        .ItemID = drgDataViewer.DataKeys(i)
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = ObjController.CMS_News_Get(ddlPortal.SelectedValue, drgDataViewer.DataKeys(i)).Status
                        .ProcessName = "--> Khôi phục dữ liệu"
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                End If
            Next
            Call LoadValues()
        End Sub
        Function Highlight(ByVal InputTxt As String, ByVal StartTag As String, ByVal EndTag As String) As String
            If txtTitle.Text.Trim = "" Then Return InputTxt
            Highlight = InputTxt
            Dim strArr As String() = flReg.HightLightSearch(txtTitle.Text.Trim).Split("-")
            For Each word As String In strArr
                Highlight = Regex.Replace(Highlight, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase)
            Next
        End Function
        Function HighlightCM(ByVal catParentName As String, ByVal catName As String) As String
            If catParentName <> "" Then
                Return "<span class=""scmchinh"">" & catParentName & "</span> / <span class=""scmphu"">" & catName & "</span>"
            Else
                Return "<span class=""scmchinh"">" & catName & "</span>"
            End If
        End Function
    End Class
End Namespace