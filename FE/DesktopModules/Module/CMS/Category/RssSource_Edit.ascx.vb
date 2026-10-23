Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Namespace DesktopModules.Weblinks
    Partial Public Class Weblink_Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim objInfo As New NewsSourceInfo
        Dim arr As New ArrayList

        Private Sub LoadValue()
            ItemID.Value = Request.Item("itemid") & ""
            objInfo = ObjController.NewsSource_Get(ddlPortal.SelectedValue, ItemID.Value)
            If IsNothing(objInfo) = False Then
                Name.Text = objInfo.Name
                ddlPortal.SelectedValue = objInfo.PortalId
                Url.Text = objInfo.Link
                cmdDel.Visible = True
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
            ddlPortal.DataValueField = "PortalID"
            ddlPortal.DataBind()
            If Request.Item("portalid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("portalid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
        End Sub

        Private Sub BackEnd()
            If Session("UrlReferrer_Link") <> "" Then
                Response.Redirect(Session("UrlReferrer_Link"), True)
            Else
                Response.Redirect("/cms/view/" & Request.Item("edit"), True)
            End If
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                objInfo.Link = Url.Text
                objInfo.Name = Name.Text
                objInfo.PortalId = ddlPortal.SelectedValue
                objInfo.CreatedDate = Now
                objInfo.CreatedUser = Me.UserInfo.Username
                If ItemID.Value <> "" Then
                    objInfo.NewsSourceID = ItemID.Value
                    objInfo.UpdatedBy = Now
                    objInfo.UpdateName = Me.UserInfo.Username
                    ObjController.NewsSource_Update(ddlPortal.SelectedValue, objInfo)
                Else
                    objInfo.NewsSourceID = flReg.GenKey()
                    objInfo.UpdatedBy = Now
                    objInfo.UpdateName = Me.UserInfo.Username
                    ObjController.NewsSource_Add(ddlPortal.SelectedValue, objInfo)
                End If
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyError", " notifyError('Lỗi cập nhật lại thông tin!');", True)
            End Try
        End Sub

        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Call BackEnd()
        End Sub

        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            ObjController.NewsSource_Delete(ddlPortal.SelectedValue, ItemID.Value)
            Call BackEnd()
        End Sub



    End Class
End Namespace

