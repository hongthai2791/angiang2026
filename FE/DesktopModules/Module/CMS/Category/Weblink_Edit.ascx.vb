Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Weblinks
    Partial Public Class Weblink_Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim objInfo As New CMS_WebLinkInfo
        Dim arr As New ArrayList

        Private Sub LoadValue()
            ItemID.Value = flReg.WriteNumber(Request.Item("itemid"))
            objInfo = ObjController.CMS_WebLink_Get(ddlPortal.SelectedValue, ItemID.Value)
            If IsNothing(objInfo) = False Then
                Name.Text = objInfo.Name
                Description.Text = objInfo.Description
                WebLinkType.SelectedValue = objInfo.ViewType
                ddlPortal.SelectedValue = objInfo.PortalId
                OrderNo.Text = objInfo.OrderNo
                Url.Text = objInfo.Url

                If objInfo.Image & "" <> "" Then
                    imgDD.InnerHtml = "<img src=""" & EPORTAL.flConnect.fileDomain & objInfo.Image & "?w=120""/>"
                    lbtDelImg.Attributes("style") = "display: block;"
                End If
                txtImagePath.Value = objInfo.Image
                cmdDel.Visible = True
            End If
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
                If IsNothing(Request.UrlReferrer) = False Then Session("UrlReferrer_Link") = Convert.ToString(Request.UrlReferrer.ToString) & ""
                Call BindLoadPortal()
                Call flFunction.LoadWebLinkType(WebLinkType)
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
                objInfo.Url = Url.Text
                objInfo.Name = Name.Text
                objInfo.Description = Description.Text
                objInfo.ViewType = WebLinkType.SelectedValue
                objInfo.PortalId = ddlPortal.SelectedValue
                objInfo.LanguageId = flConnect.IsLang
                objInfo.OrderNo = flReg.WriteNumber(OrderNo.Text)
                objInfo.ViewCount = 0
                objInfo.Image = txtImagePath.Value
                objInfo.Createdate = Now
                objInfo.UserName = Me.UserInfo.Username
                If ItemID.Value <> "0" Then
                    objInfo.Id = ItemID.Value
                    ObjController.CMS_WebLink_Update(ddlPortal.SelectedValue, objInfo)
                Else
                    ItemID.Value = ObjController.CMS_WebLink_Add(ddlPortal.SelectedValue, objInfo)
                End If
                Call SV_CMS_WebLink_Add(objInfo)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyError", " notifyError('Lỗi cập nhật lại thông tin!');", True)
            End Try
        End Sub

        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Call BackEnd()
        End Sub

        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            ObjController.CMS_WebLink_Delete(ddlPortal.SelectedValue, ItemID.Value)
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

#End Region

    End Class
End Namespace

