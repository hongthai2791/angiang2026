Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules

    Public MustInherit Class News_Admin
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim arr As ArrayList, lit As Literal
        Dim hLink As HyperLink, strUrl As String
        Dim ckSelect As CheckBox
        Dim str() As String
        Public strCssCn As String

#Region "Function"
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
        Private Sub LoadValue()
            Try
                arr = ObjController.CMS_News_ListAdmin_Progress(ddlPortal.SelectedValue, Ultis.FullTextSearch(txtTitle.Text.Trim, False), ddlCategory.SelectedValue,
                                                         ddlPortal.SelectedValue, "-1", 0, Me.UserInfo.Username, CurrentPage.Value, 35, False, 1,
                                                         Request.Item("flag") & "", flReg.NameUrl(txtTitle.Text.Trim), getDate(FromDate.Text, True), getDate(ToDate.Text, False))
                For Each Cr As CMS_NewsInfo In arr
                    litPage.Text = flReg.NextPage(Cr.Total, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                    lbTotal.Text = flReg.FormatPrice(Cr.Total)
                    Exit For
                Next
                grdData.DataSource = arr
                grdData.DataKeyField = "NewID"
                grdData.DataBind()

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub GetID()
            strUrl = Request.Item("flag") & ""
            If strUrl <> "" Then
                If strUrl.Contains("1") = True Then chkIsFocus.Checked = True
                If strUrl.Contains("2") = True Then chkHotSite.Checked = True
                If strUrl.Contains("3") = True Then chkIsEvent.Checked = True
                If strUrl.Contains("4") = True Then chkHotCat.Checked = True
                If strUrl.Contains("5") = True Then chkCare.Checked = True
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
            Call flFunction.LoadCategories(ddlCategory, ddlPortal.SelectedValue, "admin", CategoryType.News)
            ddlCategory.SelectedValue = flReg.WriteNumber(Request.Item("catid"))
        End Sub
        Private Function sortFlag() As String
            sortFlag = ""
            If chkIsFocus.Checked = True Then sortFlag += "1"
            If chkHotSite.Checked = True Then sortFlag += "2"
            If chkIsEvent.Checked = True Then sortFlag += "3"
            If chkHotCat.Checked = True Then sortFlag += "4"
            If chkCare.Checked = True Then sortFlag += "5"
            If sortFlag <> "" Then sortFlag = "/flag/" & sortFlag
            Return sortFlag
        End Function
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
#End Region

#Region "Event Handlers"

        Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Try
                txtTitle.Attributes.Add("onkeypress", "return clickButton(event,'" + lbtFind.ClientID + "')")
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    Call GetID()
                    Call LoadValue()
                    txtTitle.Focus()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Function RedirectURL() As String
            Dim strFind As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If txtTitle.Text.Trim <> "" Then strFind += "/key/" & flCheck.EncodeSearch(txtTitle.Text.Trim)
            If ddlPortal.SelectedValue <> Me.PortalId Then strFind += "/pid/" & ddlPortal.SelectedValue
            If ddlCategory.SelectedValue <> "0" Then strFind += "/catid/" & ddlCategory.SelectedValue

            If FromDate.Text <> "" Then strFind += "/fromdate/" & FromDate.Text.Replace("/", "-")
            If ToDate.Text <> "" Then strFind += "/todate/" & ToDate.Text.Replace("/", "-")
            Return strFind & sortFlag()
        End Function

        Private Sub lbtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlPortal.SelectedIndexChanged, lbtFind.Click, ddlCategory.SelectedIndexChanged, chkIsFocus.CheckedChanged, chkHotSite.CheckedChanged, chkIsEvent.CheckedChanged, chkHotCat.CheckedChanged, chkCare.CheckedChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("STT")
            lit.Text = grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1

            lit = e.Item.FindControl("StatusName")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "StatusName")

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

            lit = e.Item.FindControl("litProcess")
            lit.Text = "<a class=""hove-point"" title=""Phiên bản"" onclick=""popVersion(1000,650," & DataBinder.Eval(e.Item.DataItem, "newid") & "," & DataBinder.Eval(e.Item.DataItem, "PortalId") & ",'all')"">"
            lit.Text += "<img src=""/image/icon/history.png"" alt=""phiên bản""></a>"

        End Sub

#End Region

    End Class
End Namespace