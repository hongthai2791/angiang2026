Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_NgheDaoTaoView
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController

        Dim strURL As String
        Dim liter As Literal
        Dim chkBox As CheckBox
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadValues()
            End If
        End Sub

        Private Sub LoadValues()
            grdData.DataSource = ObjController.DTNGHE_NgheDaoTao_List()
            grdData.DataKeyField = "Id"
            grdData.DataBind()
            litCount.Text = grdData.Items.Count.ToString()
        End Sub

        Private Function regUrl(id As String) As String
            regUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & id
        End Function
        Protected Sub grdData_ItemDataBound(sender As Object, e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            strURL = regUrl(DataBinder.Eval(e.Item.DataItem, "Id"))
            CType(e.Item.FindControl("IsActive"), CheckBox).Checked = Convert.ToBoolean(DataBinder.Eval(e.Item.DataItem, "IsActive"))
            CType(e.Item.FindControl("IsEdit"), Literal).Text = "<a class=""aedit"" href=""" & strURL & """><img src=""" & flText.EditImg & "?w=20"" alt=""edit"" /></a>"
        End Sub

        Protected Sub cmdNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view")
            Response.Redirect(strURL & "/c/" & flReg.WriteNumber(litCount.Text) + 1, True)
        End Sub
        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Try
                Dim icount As Integer = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chkBox = grdData.Items(i).FindControl("IsDelete")
                    If chkBox.Checked = True Then
                        ObjController.DTNGHE_NgheDaoTao_Delete(grdData.DataKeys(i))
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success", "removewaiting();notify('success', 'Đã xóa các học viên được chọn.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn học viên nào để xóa.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.pageView, Me.pageView.GetType(), "error", "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết, không xóa được.', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace