Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_ThoiGianDaoTaoEdit
    Partial Class Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ItemId.Value = flReg.WriteNumber(Request.QueryString("itemid"))
            If Not Page.IsPostBack Then
                InitControls()
                If CInt(ItemId.Value) > 0 Then
                    cmdDelete.Visible = True
                    Call LoadValues()
                Else
                    cmdDelete.Visible = False
                End If
            End If
        End Sub

        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có chắc chắn muốn xóa không?');")
            If IsNothing(Request.UrlReferrer) = False Then ViewState("UrlReferrer") = Request.UrlReferrer.ToString & ""
        End Sub

        Private Sub LoadValues()
            Dim obj As DTNGHE_ThoiGianDaoTaoInfo = ObjController.DTNGHE_ThoiGianDaoTao_Get(CInt(ItemId.Value))
            txtCode.Text = obj.Code
            txtName.Text = obj.Name
            txtIsOrder.Text = obj.IsOrder
            chkIsActive.Checked = obj.IsActive
        End Sub

        Private Sub BackEnd()
            Dim scs = ViewState("UrlReferrer")
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub

        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Dim obj As New DTNGHE_ThoiGianDaoTaoInfo With {
                .ID = flReg.WriteNumber(ItemId.Value),
                .Code = txtCode.Text,
                .Name = txtName.Text,
                .IsOrder = flReg.WriteNumber(txtIsOrder.Text),
                .IsActive = chkIsActive.Checked
            }
            If obj.ID > 0 Then
                ObjController.DTNGHE_ThoiGianDaoTao_Update(obj)
            Else
                ObjController.DTNGHE_ThoiGianDaoTao_Add(obj)
            End If
            Call BackEnd()
        End Sub

        Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Try
                ObjController.DTNGHE_ThoiGianDaoTao_Delete(ItemId.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "error", "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết, không xóa được.', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace