Imports DotNetNuke.EPORTAL
Imports DotnetNuke.WORK
Imports DotNetNuke.UI.WebControls

Namespace DesktopModules.Modules.FeedBack
    Partial Public Class send_comment
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController
        Dim arr As New ArrayList
        Dim htmlMail, htmlMail1 As String
        Dim lit As Literal, strLink As String
        Dim dicInfo As New CMS_WorkInfo
        Dim lbtItem As LinkButton
        Dim ctl As Label
        Dim cmdDelete As CommandButton
        Dim fbInfo As New CMS_NewsFeedbackInfo

#Region "Property"

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
        Protected Sub updateComment(ByVal type As String)
            Select Case type
                Case "public"
                    For Each item As DataGridItem In drgContent.Items
                        Dim cb As CheckBox = CType(item.FindControl("cbCheck"), CheckBox)
                        If cb.Checked Then
                            Dim id As Integer = drgContent.DataKeys().Item(item.ItemIndex).ToString
                            Dim info As CMS_NewsFeedbackInfo = ObjController.CMS_NewsFeedback_Get(ddlPortal.SelectedValue, id)
                            info.Status = CommentStatus.Pulished
                            ObjController.CMS_NewsFeedback_Update(ddlPortal.SelectedValue, info)
                        End If
                    Next
                    BindDataToGrid()
                Case "delete"
                    For Each item As DataGridItem In drgContent.Items
                        Dim cb As CheckBox = CType(item.FindControl("cbCheck"), CheckBox)
                        If cb.Checked Then
                            ObjController.CMS_NewsFeedback_Delete(ddlPortal.SelectedValue, drgContent.DataKeys().Item(item.ItemIndex))
                        End If
                    Next
                    BindDataToGrid()
                Case Else
                    Return
            End Select
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

        Public Sub bindDrlStatus()
            'drlStatus.Items.Add(New ListItem("- - - Tất cả - -", -2))
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

            cmdDelete = e.Item.FindControl("cmdDelete")
            cmdDelete.OnClick = "javascript:return confirm('Bạn có đồng ý xóa ý kiến phản hồi này không?');"
            lit = e.Item.FindControl("Link")
            lit.Text = "<a target=""_blank"" href=""" & flCheck.GetHomeLinkWork(DataBinder.Eval(e.Item.DataItem, "Title"), DataBinder.Eval(e.Item.DataItem, "ItemId")) & """>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a>"
            lit = e.Item.FindControl("litTitle")
            If DataBinder.Eval(e.Item.DataItem, "Status") = CommentStatus.Watting Then
                lit.Text = "<div class='div-row-a'>"
                lit.Text += "<div class='cmdbtt cmdSave' onClick='OnSave(" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId") & ")'>Xuất bản, không gửi mail</div>"
                lit.Text += "<div class='cmdbtt cmdRun' onClick='OnPublic(" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId") & ")'>Xuất bản, gửi mail</div>"
                lit.Text += "<div class='cmdbtt cmdStop' onClick='OnPrivate(" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId") & ")'>Không xuất bản, gửi mail</div>"
                lit.Text += "</div>"
                lit.Text += "<div style ='margin-top: 10px;'>"
                lit.Text += "<a title='Chi tiết' href='/cms/edit/" & Request.Item("view") & "/idfeed/" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId")
                lit.Text += "/editid/" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId") & "/type/" & DataBinder.Eval(e.Item.DataItem, "Type")
                lit.Text += "/itemid/" & DataBinder.Eval(e.Item.DataItem, "ItemID") & "/pid/" & DataBinder.Eval(e.Item.DataItem, "PortalId") & "/capnhat/1'>"
                lit.Text += Server.HtmlDecode(DataBinder.Eval(e.Item.DataItem, "Content")) & "</a></div>"
            Else
                lit.Text += "<a title='Chi tiết' href='/cms/edit/" & Request.Item("view") & "/idfeed/" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId")
                lit.Text += "/editid/" & DataBinder.Eval(e.Item.DataItem, "NewsFeedbackId") & "/type/" & DataBinder.Eval(e.Item.DataItem, "Type")
                lit.Text += "/itemid/" & DataBinder.Eval(e.Item.DataItem, "ItemID") & "/pid/" & DataBinder.Eval(e.Item.DataItem, "PortalId") & "/capnhat/1'>"
                lit.Text += Server.HtmlDecode(DataBinder.Eval(e.Item.DataItem, "Content")) & "</a>"
            End If
        End Sub
        Private Sub drlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlStatus.SelectedIndexChanged
            CurrentPage.Value = 1
            BindDataToGrid()
        End Sub
        Private Sub drlType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlType.SelectedIndexChanged
            CurrentPage.Value = 1
            BindDataToGrid()
        End Sub
        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            If ddlPortal.SelectedValue <> Me.PortalId Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view"), True)
            End If
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
        Private Sub cmdPrivate_Click(sender As Object, e As EventArgs) Handles cmdPrivate.Click
            Try
                htmlMail1 = ""
                ObjController.CMS_NewsFeedback_Update_Status(ddlPortal.SelectedValue, NewFB_ID.Value, CommentStatus.SendMail)
                arr = ObjController.CMS_NewsFeedback_Get_By_FBID(ddlPortal.SelectedValue, NewFB_ID.Value)
                For Each cr As CMS_NewsFeedbackInfo In arr
                    If cr.ParentID = 0 Then
                        htmlMail = "<strong>Tên bài viết: </strong>" & cr.Title & "<br/>"
                        htmlMail += "<a href=" & flCheck.GetHomeLinkWork(cr.Title, cr.ItemId) & ">Xem chi tiết tại địa chỉ</a><br/>"
                        htmlMail += "<strong>Nội dung phản hồi </strong>" & cr.Content & "<br/>"
                        hdMailTo.Value = cr.Email
                    Else
                        htmlMail1 += cr.Content & "<p/>"
                    End If
                Next
                htmlMail += "<strong>Nội dung trả lời </strong>" & htmlMail1
                flDnn.DNN_SendMail(hdMailTo.Value, "Trung tâm dịch vụ việc làm trả lời người lao động:", htmlMail)

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdPrivate_Click", " notify('success', 'Đã không xuất bản và gửi mail thành công.', 'Thông báo', false);", True)
                Call BindDataToGrid()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdPrivate_Error", " notify('success', 'Lỗi không xuất bản và gửi mail.', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdPublic_Click(sender As Object, e As EventArgs) Handles cmdPublic.Click
            Try
                htmlMail1 = ""
                arr = ObjController.CMS_NewsFeedback_Get_By_FBID(ddlPortal.SelectedValue, NewFB_ID.Value)
                For Each cr As CMS_NewsFeedbackInfo In arr
                    If cr.ParentID = 0 Then
                        htmlMail = "<strong>Tên bài viết: </strong>" & cr.Title & "<br/>"

                        htmlMail += "<a href=" & flCheck.GetHomeLinkWork(cr.Title, cr.ItemId) & ">Xem chi tiết tại địa chỉ</a><br/>"
                        htmlMail += "<strong>Nội dung phản hồi </strong>" & cr.Content & "<br/>"
                        hdMailTo.Value = cr.Email
                    Else
                        htmlMail1 += cr.Content & "<p/>"
                    End If
                Next
                htmlMail += "<strong>Nội dung trả lời </strong>" & htmlMail1

                ObjController.CMS_NewsFeedback_Update_Status(ddlPortal.SelectedValue, NewFB_ID.Value, CommentStatus.Pulished)
                fbInfo = ObjController.CMS_NewsFeedback_Get(ddlPortal.SelectedValue, NewFB_ID.Value)
                flDnn.DNN_SendMail(hdMailTo.Value, "Trung tâm dịch vụ việc làm trả lời người lao động:", htmlMail)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdPublic_Click", " notify('success', 'Đã xuất bản và gửi mail thành công.', 'Thông báo', false);", True)
                Call BindDataToGrid()

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdPublic_Error", "removewaiting(); notify('success','Lỗi xuất bản và gửi mail.', 'Thông báo', false);", True)
            End Try

        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                ObjController.CMS_NewsFeedback_Update_Status(ddlPortal.SelectedValue, NewFB_ID.Value, CommentStatus.Active)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdSave_Click", " notify('success', 'Đã xuất bản và không gửi mail thành công.', 'Thông báo', false);", True)
                Call BindDataToGrid()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cmdSave_Error", " notify('success', 'Lỗi không xuất bản và không gửi mail.', 'Thông báo', false);", True)
            End Try

        End Sub
#End Region
    End Class
End Namespace