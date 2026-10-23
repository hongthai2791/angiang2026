Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.DS_ViecLam
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim liter As Literal, count As Integer
        Dim chBox As CheckBox
        Dim strUrl As String
        Dim wID As HiddenField

        Private Sub LoadValue()
            arrTemp = objController.CMS_TuyenDung_List_Search_Vl(Me.PortalId, txtFind.Text.Trim, ItemID.Value, Business_ID.Value, 0, 1)
            grdData.DataSource = arrTemp
            grdData.PageSize = 35
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()
            Session.Item("DN_MoiTG") = arrTemp.Count

        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            wID = e.Item.FindControl("Work_ID")
            wID.Value = DataBinder.Eval(e.Item.DataItem, "Work_ID")
            chBox = e.Item.FindControl("IsSelect")
            If flCheck.SVL_TinhTrangDoanhNghiep(Me.PortalId, ItemID.Value, Business_ID.Value) Then
                chBox.Enabled = True
            Else
                chBox.Enabled = False
            End If
            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</b></div>"
            liter.Text += "<div>Đăng từ: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</b></div>"
            liter.Text += "<div>Đến ngày: <b>" & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "EndDate"), False) & "</b></div>"

            liter = e.Item.FindControl("Title")
            strUrl = flReg.WebConfig("works") & "/viec-lam/" & flCheck.LinkUrl(DataBinder.Eval(e.Item.DataItem, "Title"), DataBinder.Eval(e.Item.DataItem, "ID"), "VL")
            liter.Text = "<a target=""_bank"" href='" & strUrl & "'><b>" & DataBinder.Eval(e.Item.DataItem, "Title") & "</b></a>"
            liter.Text += "<div>Khu vực: <b>" & flDic.Regional_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP")) & "</b></div>"
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
                DoanhNghiep_ID.Value = Request.Item("dn") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            Call LoadValue()
        End Sub

        Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
            Try
                Dim dnInfo As CMS_TuyenDungInfo
                count = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsSelect")
                    If chBox.Checked = True Then
                        wID = grdData.Items(i).FindControl("Work_ID")
                        dnInfo = New CMS_TuyenDungInfo
                        dnInfo.TuyenDung_ID = flReg.GenKey()
                        dnInfo.DoanhNghiep_ID = DoanhNghiep_ID.Value
                        dnInfo.Work_ID = wID.Value
                        dnInfo.PhienGD_ID = ItemID.Value
                        dnInfo.UserName = Me.UserInfo.Username
                        dnInfo.CreatedBy = Now
                        objController.CMS_TuyenDung_Add(Me.PortalId, dnInfo)
                        count = 1
                    End If
                Next
                If count = 1 Then
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã thêm việc làm vào phiên thành công.', 'Thông báo', false);location.reload()", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', 'Bạn chưa chọn việc làm nào để thêm vào phiên.', 'Thông báo', false);", True)
                End If

            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                ItemID.Value = Request.Item("itemid") & ""
                DoanhNghiep_ID.Value = Request.Item("dn") & ""
                Business_ID.Value = Request.Item("busid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace
