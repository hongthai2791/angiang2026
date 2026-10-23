Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Namespace DesktopModules.TinTuc.Control
    Partial Class ChooseVideo
        Inherits CDefault
        Dim ObjController As New CmsController
        Dim arr As New ArrayList
        Dim setting, Str() As String
        Dim lit As Literal
        Dim i As Integer

        Private Sub GetID()
            PortalID.Value = flReg.WriteNumber(Request.Item("pid"))
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1
            txtTitle.Text = flCheck.DecodeSearch(Request.Item("key") & "")

            If Request.Item("fromdate") & "" <> "" Then
                FromDate.Text = Request.Item("fromdate").Replace("-", "/")
            Else
                FromDate.Text = Now.AddMonths(-2).ToString("dd/MM/yyyy")
            End If
            If Request.Item("todate") & "" <> "" Then
                ToDate.Text = Request.Item("todate").Replace("-", "/")
            Else
                ToDate.Text = Now.AddDays(15).ToString("dd/MM/yyyy")
            End If

            Call flFunction.LoadCategories(ddlCategory, PortalID.Value, "admin", CategoryType.Video)
            If Request.Item("catid") <> "" Then ddlCategory.SelectedValue = Request.Item("catid")
        End Sub
        Private Function getDate(dates As String, bFrom As Boolean) As DateTime
            If bFrom = True Then
                If dates = "" Then dates = "01/01/2000"
                Str = dates.Split("/")
                Return New Date(Str(2), Str(1), Str(0), 0, 0, 0)
            Else
                If dates = "" Then dates = Now.AddMonths(1).ToString("dd/MM/yyyy")
                Str = dates.Split("/")
                Return New Date(Str(2), Str(1), Str(0), 23, 59, 59)
            End If
        End Function

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Function RedirectURL() As String
            Dim str As String = "/desktopmodules/module/cms/config/video.aspx?portalid=" & Request.Item("pid")
            If Request.Item("s") <> "" Then str += "&s=" & Request.Item("s")
            If txtTitle.Text.Trim <> "" Then str += "&key=" & flCheck.EncodeSearch(txtTitle.Text.Trim)
            If ddlCategory.SelectedValue <> "0" Then str += "&catid=" & ddlCategory.SelectedValue
            If FromDate.Text <> "" Then str += "&fromdate=" & FromDate.Text.Replace("/", "-")
            If ToDate.Text <> "" Then str += "&todate=" & ToDate.Text.Replace("/", "-")
            Return str
        End Function
        Private Sub LoadValue()
            Try
                setting = 3
                If (Request.Item("s") & "").ToLower() = "settingsvideonb" Then
                    setting = 1
                ElseIf (Request.Item("s") & "").ToLower() = "settingsvideo" Then
                    setting = 2
                End If
                arr = ObjController.CMS_Media_List_Select(PortalID.Value, getDate(FromDate.Text, True), getDate(ToDate.Text, False), txtTitle.Text.Trim, ddlCategory.SelectedValue, PortalID.Value, CurrentPage.Value, 20, mediaType.Video, i)

                For Each Cr As CMS_MediaInfo In arr
                    litPage.Text = flReg.NextPage(Cr.Total, 20, CurrentPage.Value, 5, RedirectURL() & "/p/")
                    Exit For
                Next
                grdData.DataSource = arr
                grdData.DataBind()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub lbtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbtFind.Click, ddlCategory.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub

        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("STT")
            lit.Text = e.Item.ItemIndex + 1
        End Sub
    End Class
End Namespace