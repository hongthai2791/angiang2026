Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.WORK
Imports OfficeOpenXml
Imports System.IO
Namespace DesktopModules.PDK
    Public MustInherit Class XKL_DangKy_List
        Inherits Entities.Modules.PortalModuleBase
#Region "Variable"
        Dim arr, arrTemp, arrTemp1 As New ArrayList
        Dim ObjController As New WorkController
        Dim liter As Literal
        Dim cbDelete As CheckBox
        Dim itemID, strURL As String
#End Region
#Region "Function"
        Private Sub InitControl()
            Call BindLoadPortal()
            txtKey.Attributes.Add("onkeypress", "return clickButton(event,'" + lbtFind.ClientID + "')")
            txtKey.Text = CMS.flCheck.DecodeSearch(Request.QueryString("key") & "")
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1
            EPORTAL.flDic.LoadYear(drYear, Now.Year - 5, Now.Year, False)
            If flReg.WriteNumber(Request.Item("yid")) = 0 Then
                drYear.SelectedValue = Now.Year - 1
            Else
                drYear.SelectedValue = flReg.WriteNumber(Request.Item("yid"))
            End If
        End Sub
        Private Sub LoadValue()
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung đã chọn không?');"
            arrTemp = ObjController.XKL_DangKy_List_Search(CMS.flCheck.DecodeSearch(txtKey.Text.Trim), 0, CurrentPage.Value, 35, "", drYear.SelectedValue)
            For Each Cr As XKL_DangKyInfo In arrTemp
                lbTotal.Text = flReg.FormatPrice(Cr.Total)
                If Cr.Total > 35 Then
                    litPage.Text = flReg.NextPage(Cr.Total, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                End If
                Exit For
            Next
            grdData.DataSource = arrTemp
            grdData.DataKeyField = "ID"
            grdData.DataBind()
        End Sub
        Private Function RedirectURL() As String
            Dim str As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If ddlPortal.SelectedValue <> Me.PortalId Then str += "/pid/" & ddlPortal.SelectedValue
            If drYear.SelectedValue <> 0 Then str += "/yid/" & drYear.SelectedValue
            If txtKey.Text.Trim <> "" Then str += "/key/" & CMS.flCheck.EncodeSearch(txtKey.Text.Trim)
            Return str
        End Function

        Private Sub BindLoadPortal()

            ddlPortal.DataSource = CMS.Ultis.UserPortal(Me.UserInfo.Username)
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
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Call InitControl()
                Call LoadValue()
            End If
        End Sub

        Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
        End Sub

        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "ID") & "/pid/" & ddlPortal.SelectedValue

            liter = e.Item.FindControl("STT")
            liter.Text = grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1

            liter = e.Item.FindControl("QuocGia")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "QuocGia")

            liter = e.Item.FindControl("Col1")
            liter.Text = "<a title='" & DataBinder.Eval(e.Item.DataItem, "HoTen") & "' href='" & strURL & "'> " & DataBinder.Eval(e.Item.DataItem, "HoTen") & "</a>"

            liter = e.Item.FindControl("Col2")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "CCCD")

            liter = e.Item.FindControl("Col3")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgaySinh"), False)

            liter = e.Item.FindControl("Col4")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DienThoai")

            liter = e.Item.FindControl("Col5")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")

            liter = e.Item.FindControl("Col6")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "SignDate"), False)

        End Sub
        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            Try
                Dim icount As Integer = 0

                For i As Integer = 0 To grdData.Items.Count - 1
                    cbDelete = grdData.Items(i).FindControl("chkItems")
                    If cbDelete.Checked = True Then
                        itemID = grdData.DataKeys(i)
                        ObjController.ND23_PLI_Delete(ddlPortal.SelectedValue, itemID)
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValue()
                End If
            Catch exc As SqlClient.SqlException
                If exc.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('warning', 'Lỗi có dữ liệu liên kết, không thể xóa được!.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, exc.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Private Sub lbtFind_Click(sender As Object, e As EventArgs) Handles lbtFind.Click, ddlPortal.SelectedIndexChanged, drYear.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
#End Region


    End Class
End Namespace
