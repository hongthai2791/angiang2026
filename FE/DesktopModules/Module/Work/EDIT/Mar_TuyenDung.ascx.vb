Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL


Namespace Modules.SVL.Mar_TuyenDung
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim liter As Literal, count As Integer
        Dim chBox As CheckBox
        Dim strURL As String

        Private Sub LoadValue()
            arrTemp = objController.CMS_TuyenDung_List_Search(Me.PortalId, TuyenDung_Find.Text.Trim, ItemID.Value, Business_ID.Value, 1)
            grdData.DataSource = arrTemp
            grdData.PageSize = 35
            grdData.DataKeyField = "TuyenDung_ID"
            grdData.DataBind()
            Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, ItemID.Value)
            If IsNothing(phInfo) = False Then
                If Now > phInfo.ThoiGian_KetThuc Then
                    cmdTuyenDung_Delete.Enabled = False
                End If
            End If

        End Sub
        Public Function FormatApproval(ByVal tinhtrang As Integer) As String
            Return IIf(tinhtrang = 0, "<img src='/image/images/unselect.png' title='Chưa duyệt'>", "<img src='/image/images/select.png' title='Duyệt'>")
        End Function


        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</b></div>"
            liter.Text += "<div>Đăng từ: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</b></div>"
            liter.Text += "<div>Đến ngày: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "EndDate"), False) & "</b></div>"

            liter = e.Item.FindControl("Title")
            'strURL = PublicLink(ddlPortal.SelectedValue, DataBinder.Eval(e.Item.DataItem, "CategoryId"), DataBinder.Eval(e.Item.DataItem, "itemid"), DataBinder.Eval(e.Item.DataItem, "ToUrl"), flReg.WebConfig("works"))
            strURL = flReg.WebConfig("works") & "/viec-lam/" & flCheck.LinkUrl(DataBinder.Eval(e.Item.DataItem, "Title"), DataBinder.Eval(e.Item.DataItem, "ID"), "VL")
            liter.Text = "<a target=""_bank"" href='" & strURL & "'><b>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</b></a>"
            liter.Text += "<div>Khu vực: <b>" & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</b></div>"
            liter.Text += "<div>Lượt xem: <b>" & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsView"))
            liter.Text += "</b> - Nộp hồ sơ: <b>" & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsSend")) & "</b></div>"

            liter = e.Item.FindControl("Infomation")
            liter.Text = "<div>Kinh nghiệm: <b>" & flCheck.Experience_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Experience_ID")) & "</b></div>"
            liter.Text += "<div>Mức lương: <b>" & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</b></div>"

        End Sub

        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                ItemID.Value = Request.Item("itemid") & ""
                Business_ID.Value = Request.Item("busid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdTuyenDung_Search.Click
            Call LoadValue()
        End Sub

        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdTuyenDung_Delete.Click
            Try
                count = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsSelect")
                    If chBox.Checked = True Then
                        objController.CMS_TuyenDung_Delete(Me.PortalId, grdData.DataKeys(i))
                        count = 1
                    End If
                Next
                If count = 1 Then
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('success', 'Đã bỏ doanh nghiệp khỏi phiên thành công.', 'Thông báo', false);", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();notify('info', 'Bạn chưa chọn doanh nghiệp nào để bỏ khỏi phiên.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                ItemID.Value = Request.Item("itemid") & ""
                Business_ID.Value = Request.Item("busid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace
