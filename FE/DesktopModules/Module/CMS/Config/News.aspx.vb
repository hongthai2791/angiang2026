Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Namespace DesktopModules.Modules
    Partial Class News
        Inherits CDefault
        Dim ObjController As New CmsController
        Dim str(), setting As String
        Public strCssCn As String
        Dim arr As New ArrayList
        Dim lit As Literal
        Private Function RedirectURL() As String
            Dim str As String = "/desktopmodules/module/cms/config/news.aspx?portalid=" & Request.Item("pid")
            If Request.Item("s") <> "" Then str += "&s=" & Request.Item("s")
            If txtTitle.Text.Trim <> "" Then str += "&key=" & flCheck.EncodeSearch(txtTitle.Text.Trim)
            If ddlCategory.SelectedValue <> "0" Then str += "&catid=" & ddlCategory.SelectedValue
            If txtStartdate.Text <> "" Then str += "&fromdate=" & txtStartdate.Text.Replace("/", "-")
            If txtEndDate.Text <> "" Then str += "&todate=" & txtEndDate.Text.Replace("/", "-")
            Return str
        End Function
        Private Sub ChangeFont()
            strCssCn = "<link  rel='stylesheet' href='/portals/_default/skins/vbn/css/vi.css?v=3.3.3'/>"
        End Sub
        Private Sub GetID()
            PortalID.Value = Context.Request.Item("pid")
            setting = Context.Request.Item("s")
            txtTitle.Text = flCheck.DecodeSearch(Request.Item("key") & "")
            If Request.Item("fromdate") & "" <> "" Then
                txtStartdate.Text = Request.Item("fromdate").Replace("-", "/")
            Else
                txtStartdate.Text = Now.AddMonths(-2).ToString("dd/MM/yyyy")
            End If
            If Request.Item("todate") & "" <> "" Then
                txtEndDate.Text = Request.Item("todate").Replace("-", "/")
            Else
                txtEndDate.Text = Now.AddDays(15).ToString("dd/MM/yyyy")
            End If
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1

        End Sub
        Private Function getDate(dates As String, bFrom As Boolean) As DateTime
            If bFrom = True Then
                If dates = "" Then dates = "01/01/2000"
                str = dates.Split("/")
                Return New Date(str(2), str(1), str(0), 0, 0, 0)
            Else
                If dates = "" Then dates = Now.AddMonths(1).ToString("dd/MM/yyyy")
                str = dates.Split("/")
                Return New Date(str(2), str(1), str(0), 23, 59, 59)
            End If
        End Function
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                Call ChangeFont()
                If Request.IsAuthenticated Then
                    DotNetNuke.UI.Utilities.ClientAPI.RegisterKeyCapture(Me.Parent, Me.lbtFind, Asc(vbCr))
                    If Not IsPostBack Then
                        Call GetID()
                        If Request.Item("s") = "settingsphongsuanh" Then
                            Call flFunction.LoadCategories(ddlCategory, PortalID.Value, "admin", CategoryType.Album)
                        Else
                            If UserInfo.IsInRole("Manager") = True Then
                                Call flFunction.LoadCategories(ddlCategory, PortalID.Value, "admin", CategoryType.News)
                            Else
                                Call flFunction.LoadCategories(ddlCategory, PortalID.Value, GetPortalSettings.UserInfo.Username, CategoryType.News)
                            End If
                        End If
                        ddlCategory.SelectedValue = flReg.WriteNumber(Request.Item("catid"))
                        Call BinddrgDataViewer()
                        txtTitle.Focus()
                    End If
                Else
                    Response.Redirect("/")
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub BinddrgDataViewer()
            If Request.Item("s") = "settingsphongsuanh" Then
                arr = ObjController.CMS_News_List_Search(PortalID.Value, NewsStatus.DaXuatBan, 0, PortalID.Value, flConnect.IsLang, ddlCategory.SelectedValue,
                                            Ultis.FullTextSearch(txtTitle.Text.Trim, False), CurrentPage.Value, 20, Request.Item("flag") & "",
                                            getDate(txtStartdate.Text, True), getDate(txtEndDate.Text, False), "admin", 0, True, 0, True)
            Else
                arr = ObjController.CMS_News_List_Search(PortalID.Value, NewsStatus.DaXuatBan, 0, PortalID.Value, flConnect.IsLang, ddlCategory.SelectedValue,
                                                Ultis.FullTextSearch(txtTitle.Text.Trim, False), CurrentPage.Value, 20, Request.Item("flag") & "",
                                                getDate(txtStartdate.Text, True), getDate(txtEndDate.Text, False), "admin", 0, False, 0, True)
            End If
            drgDataViewer.DataSource = arr
            drgDataViewer.DataBind()

            For Each Cr As CMS_NewsInfo In arr
                litPage.Text = flReg.NextPage(Cr.Total, 20, CurrentPage.Value, 5, RedirectURL() & "&p=")
                Exit For
            Next
        End Sub
        Private Sub lbtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbtFind.Click, ddlCategory.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
        Protected Sub drgDataViewer_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgDataViewer.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("STT")
            lit.Text = e.Item.ItemIndex + 1

            lit = e.Item.FindControl("ViewCount")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "ViewCount")

            lit = e.Item.FindControl("CategoryName")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "CategoryName")

            lit = e.Item.FindControl("View")
            lit.Text = "<a onclick='preview(" & DataBinder.Eval(e.Item.DataItem, "newid") & "," & DataBinder.Eval(e.Item.DataItem, "PortalId") & ")' title='Xem' class='printview'>"
            lit.Text += "<img src='/images/view.gif' alt='Xem tin bài'/></a>"
        End Sub
        Function Highlight(ByVal InputTxt As String, ByVal StartTag As String, ByVal EndTag As String) As String
            If txtTitle.Text.Trim <> "" Then
                Dim ResultStr As String = InputTxt
                Dim strArr As String() = txtTitle.Text.Trim.Split(" ")
                For Each word As String In strArr
                    ResultStr = Regex.Replace(ResultStr, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase)
                Next
                Return ResultStr
            Else
                Return InputTxt
            End If
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