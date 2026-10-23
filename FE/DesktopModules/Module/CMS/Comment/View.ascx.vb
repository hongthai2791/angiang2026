Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules.FeedBack
    Partial Public Class view_comment
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim arr As New ArrayList
        Dim lit As Literal, strLink As String
        Dim dicInfo As New CMS_NewsInfo
        Dim lbtItem As LinkButton
        Dim ctl As Label

#Region "Function"
        Private Function RedirectURL() As String
            Dim str As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If ddlPortal.SelectedValue <> Me.PortalId Then str += "/pid/" & ddlPortal.SelectedValue
            str += "/type/" & drlType.SelectedValue & "/status/" & drlStatus.SelectedValue
            Return str
        End Function
        Public Sub BindDataToGrid()
            arr = ObjController.CMS_NewsFeedback_List_Search(ddlPortal.SelectedValue, -1, drlStatus.SelectedValue, drlType.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, CurrentPage.Value, 30)
            drgContent.DataSource = arr
            drgContent.PageSize = 35
            drgContent.DataBind()
            litPage.Text = "" : lbTotal.Text = "0"
            For Each Cr As CMS_NewsFeedbackInfo In arr
                litPage.Text = flReg.NextPage(Cr.Total, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                lbTotal.Text = flReg.FormatPrice(Cr.Total)
                Exit For
            Next
        End Sub
        Public Sub bindDrlStatus()
            drlStatus.Items.Add(New ListItem("Chưa duyệt", CommentStatus.Created))
            drlStatus.Items.Add(New ListItem("Đang chờ duyệt", CommentStatus.Watting))
            drlStatus.Items.Add(New ListItem("Đã xuất bản, không gửi mail", CommentStatus.Active))
            drlStatus.Items.Add(New ListItem("Đã xuất bản, gửi mail", CommentStatus.Pulished))
            drlStatus.Items.Add(New ListItem("Không xuất bản, gửi mail", CommentStatus.SendMail))
            If Request.Item("status") <> "" Then drlStatus.SelectedValue = Request.Item("status")
        End Sub
        Public Sub bindDrlType()
            drlType.Items.Add(New ListItem("Tin tức", CommentType.NEWS))
            drlType.Items.Add(New ListItem("Văn bản", CommentType.DOCUMENTS))
            If Request.Item("type") <> "" Then drlType.SelectedValue = Request.Item("type")
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
        End Sub
#End Region
#Region "Event"

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Page.IsPostBack = False Then
                    CurrentPage.Value = 1
                    If Request.Item("p") & "" <> "" Then CurrentPage.Value = Request.Item("p")
                    Call BindLoadPortal()
                    Call bindDrlStatus()
                    Call bindDrlType()
                    Call BindDataToGrid()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Private Sub drgContent_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles drgContent.ItemCommand
            Try
                Select Case e.CommandName
                    Case "Delete"
                        Dim commentId As Integer = Int64.Parse(e.CommandArgument)
                        ObjController.CMS_NewsFeedback_Delete(ddlPortal.SelectedValue, commentId)
                        Call BindDataToGrid()
                    Case "ViewItem"
                        Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/itemid/" & e.CommandArgument)

                End Select
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub drgContent_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgContent.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            ctl = e.Item.FindControl("numberLabel")
            ctl.Text = (e.Item.ItemIndex + 1).ToString

            strLink = Ultis.PublicLink(ddlPortal.SelectedValue, DataBinder.Eval(e.Item.DataItem, "CategoryId"), DataBinder.Eval(e.Item.DataItem, "itemid"), DataBinder.Eval(e.Item.DataItem, "ToUrl"), flReg.WebConfig("works"))
            lit = e.Item.FindControl("Link")
            lit.Text = "<a target=""_blank"" href=""" & strLink & """>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"

        End Sub
        Private Sub drlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlStatus.SelectedIndexChanged, drlType.SelectedIndexChanged, ddlPortal.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
        Public Function StatusCm(ByVal stt As String) As String
            StatusCm = "Chưa duyệt"
            If stt = CommentStatus.Pulished Then
                StatusCm = "Đã xuất bản, gửi mail"
            ElseIf stt = CommentStatus.SendMail Then
                StatusCm = "Không xuất bản, gửi mail"
            ElseIf stt = CommentStatus.Watting Then
                StatusCm = "Đang chờ duyệt"
            ElseIf stt = CommentStatus.Active Then
                StatusCm = "Đã xuất bản, không gửi mail"
            End If
        End Function
#End Region
    End Class
End Namespace