Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.TinTuc.Control
    Partial Class Choose
        Inherits CDefault
        Dim lit As Literal, Str() As String
        Dim ObjController As New CmsController()
        Dim arr As New ArrayList
        Private Function RedirectURL() As String
            Dim str As String = "/desktopmodules/module/cms/config/link.aspx?portalid=" & PortalID.Value
            str += "&flag=" & flag.Value
            If txtTitle.Text.Trim <> "" Then str += "&key=" & flCheck.EncodeSearch(txtTitle.Text.Trim)
            If ddlCategory.SelectedValue <> "0" Then str += "&catid=" & ddlCategory.SelectedValue
            If txtStartdate.Text <> "" Then str += "&fromdate=" & txtStartdate.Text.Replace("/", "-")
            If txtEndDate.Text <> "" Then str += "&todate=" & txtEndDate.Text.Replace("/", "-")
            Return str
        End Function
        Private Sub GetID()
            flag.Value = Request.Item("flag")
            PortalID.Value = flReg.WriteNumber(Request.Item("pid"))
            txtTitle.Text = flCheck.DecodeSearch(Request.Item("key") & "")
            If Request.Item("fromdate") & "" <> "" Then
                txtStartdate.Text = Request.Item("fromdate").Replace("-", "/")
            Else
                txtStartdate.Text = Now.AddMonths(-2).ToString("dd/MM/yyyy")
            End If
            If Request.Item("todate") & "" <> "" Then
                txtEndDate.Text = Request.Item("todate").Replace("-", "/")
            Else
                txtEndDate.Text = Now.AddDays(7).ToString("dd/MM/yyyy")
            End If
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1
        End Sub
        Private Function getDate(dates As String, bFrom As Boolean) As DateTime
            If bFrom = True Then
                If dates = "" Then dates = Now.AddYears(-3).ToString("dd/MM/yyyy")
                Str = dates.Split("/")
                Return New Date(Str(2), Str(1), Str(0), 0, 0, 0)
            Else
                If dates = "" Then dates = Now.AddDays(7).ToString("dd/MM/yyyy")
                Str = dates.Split("/")
                Return New Date(Str(2), Str(1), Str(0), 23, 59, 59)
            End If
        End Function
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    If UserInfo.IsInRole("Manager") = True Then
                        Call flFunction.LoadCategories(ddlCategory, PortalID.Value, "admin", CategoryType.News)
                    Else
                        Call flFunction.LoadCategories(ddlCategory, PortalID.Value, GetPortalSettings.UserInfo.Username, CategoryType.News)
                    End If
                    ddlCategory.SelectedValue = flReg.WriteNumber(Request.Item("catid"))
                    Call BindgrdData()
                    txtTitle.Focus()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub BindgrdData()
            Try
                litPage.Text = ""
                If UserInfo.IsInRole("Xuat ban") Then
                    arr = ObjController.CMS_News_List_GetLink(PortalID.Value, getDate(txtStartdate.Text, True), getDate(txtEndDate.Text, False), Ultis.FullTextSearch(txtTitle.Text.Trim, False),
                                                                ddlCategory.SelectedValue, PortalID.Value, NewsStatus.DaXuatBan, "admin", CurrentPage.Value, 30)
                Else
                    arr = ObjController.CMS_News_List_GetLink(PortalID.Value, getDate(txtStartdate.Text, True), getDate(txtEndDate.Text, False), Ultis.FullTextSearch(txtTitle.Text.Trim, False),
                                                                ddlCategory.SelectedValue, PortalID.Value, NewsStatus.DaXuatBan, UserInfo.Username, CurrentPage.Value, 30)
                End If
                grdData.DataSource = arr
                grdData.PageSize = 30
                grdData.DataBind()
                For Each Cr As CMS_NewsInfo In arr
                    litPage.Text = flReg.NextPage(Cr.Total, 20, CurrentPage.Value, 5, RedirectURL() & "&p=")
                    Exit For
                Next
            Catch ex As Exception
                litPage.Text = ex.Message
            End Try
        End Sub
        Protected Sub grdData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            lit = e.Item.FindControl("IsOrder")
            lit.Text = e.Item.ItemIndex + 1

            lit = e.Item.FindControl("litDate")
            If DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.DaXuatBan Then
                lit.Text = "<span> Ngày xuất bản: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "PublishedDate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "PublishedUser")) & "</span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "Status") & "" = NewsStatus.HuyXuatBan Then
                lit.Text = "<span> Ngày dừng: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CancelPublishDate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "CancelPublishUser")) & "</span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "Status") = NewsStatus.BiTraLai Or DataBinder.Eval(e.Item.DataItem, "Status") = NewsStatus.TraLaiQT Then
                lit.Text = "<span> Ngày trả lại: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ReturnedDate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "ReturnedUser")) & "</span>"

            ElseIf DataBinder.Eval(e.Item.DataItem, "ApprovalRequestDate") & "" <> "12:00:00 AM" Then
                lit.Text = "<span> Ngày gửi: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ApprovalRequestDate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "UserId")) & "</span>"
            ElseIf DataBinder.Eval(e.Item.DataItem, "ApprovalDate") & "" <> "12:00:00 AM" Then
                lit.Text = "<span> Ngày gửi: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ApprovalDate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "ApprovalUser")) & "</span>"
            Else
                lit.Text = "<span> Ngày gửi: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "Createdate")) & " - " & flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "UserId")) & "</span>"
            End If

        End Sub

        Private Sub lbtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbtFind.Click, ddlCategory.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
        Function Highlight(ByVal InputTxt As String, ByVal StartTag As String, ByVal EndTag As String) As String
            Dim ResultStr As String = InputTxt
            Dim strArr As String() = txtTitle.Text.Trim.Split(" ")
            For Each word As String In strArr
                ResultStr = Regex.Replace(ResultStr, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase)
            Next

            Return ResultStr
        End Function
    End Class
    Public Module Moduler
        Public ReadOnly Property UserInfo As UserInfo
            Get
                Dim user As UserInfo
                If (HttpContext.Current Is Nothing) Then
                    If Not System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                        Return New UserInfo()
                    End If
                    Dim portalSettings = PortalController.GetCurrentPortalSettings()
                    If portalSettings IsNot Nothing Then
                        user = UserController.GetCachedUser(portalSettings.PortalId, System.Threading.Thread.CurrentPrincipal.Identity.Name)
                        Return If(user, New UserInfo())
                    End If
                    Return New UserInfo()
                ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                    If HttpContext.Current.Request.IsAuthenticated Then
                        user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                        HttpContext.Current.Items("UserInfo") = user
                    End If
                End If
                user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
                Return If(user, New UserInfo())
            End Get
        End Property
    End Module
End Namespace