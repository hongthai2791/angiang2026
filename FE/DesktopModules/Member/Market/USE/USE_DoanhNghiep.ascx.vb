Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.US.USE_DoanhNghiep
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim liter As Literal
        Dim strURL As String, txt As TextBox

        Private Sub LoadValue()
            arrTemp = objController.CMS_DoanhNghiep_List_Search(Me.PortalId, "", -1, 35, ItemID.Value)
            grdData.DataSource = arrTemp
            grdData.PageSize = 35
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            Session.Item("USE_DoanhNghiep") = arrTemp.Count
        End Sub
        Public Function FormatApproval(ByVal tinhtrang As Integer) As String
            Return IIf(tinhtrang = 0, "<img src='/image/images/unselect.png' title='Chưa duyệt'>", "<img src='/image/images/select.png' title='Duyệt'>")
        End Function

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            txt = e.Item.FindControl("SoBan")
            txt.Text = DataBinder.Eval(e.Item.DataItem, "SoBan")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            liter = e.Item.FindControl("Business_Vn")
            If DataBinder.Eval(e.Item.DataItem, "Logo") & "" <> "" Then
                liter.Text = "<img align=""absmiddle"" style=""padding-right:5px;"" src=""" & flConnect.fileDomain & DataBinder.Eval(e.Item.DataItem, "Logo") & "?w=24&h=24"" />"
                'liter.Text += DataBinder.Eval(e.Item.DataItem, "Business_Vn")
                liter.Text += "<a onclick='popDetailDN(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Business_ID") & """);'  title='Xem chi tiết Doanh nghiệp' >" & DataBinder.Eval(e.Item.DataItem, "Business_Vn") & "</a>"
            Else
                'liter.Text = DataBinder.Eval(e.Item.DataItem, "Business_Vn")
                liter.Text = "<a onclick='popDetailDN(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Business_ID") & """);'  title='Xem chi tiết Doanh nghiệp'>" & DataBinder.Eval(e.Item.DataItem, "Business_Vn") & "</a>"
            End If
        End Sub

        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                ItemID.Value = Request.Item("itemid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                ItemID.Value = Request.Item("itemid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace
