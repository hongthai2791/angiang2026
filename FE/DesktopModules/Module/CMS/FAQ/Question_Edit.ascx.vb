Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.FAQ
    Partial Public Class Question_Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim objInfo As New CMS_FAQQuestionsInfo
        Dim arr As New ArrayList

        Private Sub LoadValue()
            ItemID.Value = flReg.WriteNumber(Request.Item("itemid"))
            objInfo = ObjController.CMS_FAQQuestions_Get(ddlPortal.SelectedValue, ItemID.Value)
            If IsNothing(objInfo) = False Then
                _Name.Text = objInfo.Name
                _Contents.Text = objInfo.Contents
                _Email.Text = objInfo.Email
                _Phone.Text = objInfo.Phone
                _FAQAnswer.Text = objInfo.ContentAnswer
                If objInfo.Status = QuestionStatus.DaGui Or objInfo.Status = QuestionStatus.HuyBo Then
                    cmdDuyet.Visible = True
                    cmdDel.Visible = True
                    cmdHuyDuyet.Visible = False
                ElseIf objInfo.Status = QuestionStatus.DaDuyet Then
                    cmdDuyet.Visible = False
                    cmdDel.Visible = False
                    cmdHuyDuyet.Visible = True
                Else
                    cmdDuyet.Visible = False
                    cmdDel.Visible = False
                    cmdHuyDuyet.Visible = False
                End If
            End If
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
                If IsNothing(Request.UrlReferrer) = False Then Session("UrlReferrer_Link") = Convert.ToString(Request.UrlReferrer.ToString) & ""
                Call BindLoadPortal()
                Call LoadValue()
            End If
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

        Private Sub BackEnd()
            If Session("UrlReferrer_Link") <> "" Then
                Response.Redirect(Session("UrlReferrer_Link"), True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), True)
            End If
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                ObjController.CMS_FAQQuestions_Update_Answer(ddlPortal.SelectedValue, ItemID.Value, _FAQAnswer.Text, Me.UserInfo.DisplayName, Me.UserInfo.Username, DateTime.Now)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyError", " notifyError('Lỗi cập nhật lại thông tin!');", True)
            End Try
        End Sub

        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Call BackEnd()
        End Sub

        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            ObjController.CMS_FAQQuestions_Delete(ddlPortal.SelectedValue, ItemID.Value)
            Call BackEnd()
        End Sub

#Region "Service"
        Private Sub SV_CMS_WebLink_Add(obj As CMS_WebLinkInfo)
            'Try
            '    Dim objSend As New vn.qdnd.WebService
            '    Dim SendView As String = objSend.SV_CMS_WebLink_Add(flCheck.setCode(Me.UserId), ddlPortal.SelectedValue,
            '                obj.Id, flReg.EnCode64(obj.Name), obj.OrderNo, flReg.EnCode64(obj.Url), obj.Image, flReg.EnCode64(obj.Description),
            '                obj.PortalId, obj.LanguageId, obj.ViewType, obj.UserName, obj.Createdate)

            '    ObjController.SV_Update_CMS_WebLink_SendView(ddlPortal.SelectedValue, obj.Id, SendView)
            'Catch ex As Exception
            '    ObjController.SV_Update_CMS_WebLink_SendView(ddlPortal.SelectedValue, obj.Id, False)
            'End Try
        End Sub
        Private Function SV_CMS_WebLink_Update_Delete(ID As Integer) As Boolean
            'Try
            '    Dim objSend As New vn.qdnd.WebService
            '    Dim SendView As Boolean = objSend.SV_CMS_WebLink_Update_Delete(flCheck.setCode(Me.UserId), ddlPortal.SelectedValue, ID)
            '    ObjController.SV_Update_CMS_WebLink_SendView(ddlPortal.SelectedValue, ID, SendView)
            '    Return SendView
            'Catch ex As Exception
            '    ObjController.SV_Update_CMS_WebLink_SendView(ddlPortal.SelectedValue, ID, False)
            Return False
            'End Try
        End Function

        Private Sub cmdDuyet_Click(sender As Object, e As EventArgs) Handles cmdDuyet.Click
            Try
                ObjController.CMS_FAQQuestions_Update_Status(ddlPortal.SelectedValue, ItemID.Value, QuestionStatus.DaDuyet)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyError", " notifyError('Lỗi cập nhật lại thông tin!');", True)
            End Try
        End Sub

        Private Sub cmdHuyDuyet_Click(sender As Object, e As EventArgs) Handles cmdHuyDuyet.Click
            Try
                ObjController.CMS_FAQQuestions_Update_Status(ddlPortal.SelectedValue, ItemID.Value, QuestionStatus.HuyBo)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyError", " notifyError('Lỗi cập nhật lại thông tin!');", True)
            End Try
        End Sub

#End Region

    End Class
End Namespace

