Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Namespace DesktopModules.CongTacVien
    Public MustInherit Class CMS_AuthorsList
        Inherits Entities.Modules.PortalModuleBase
#Region "Variable"
        Dim arr, arrTemp, arrTemp1 As New ArrayList
        Dim ObjController As New CmsController
        Dim liter As Literal
        Dim cbDelete As CheckBox
        Dim itemID, strURL As String
#End Region
#Region "Function"
        Private Sub InitControl()
            Call BindLoadPortal()
            txtKey.Attributes.Add("onkeypress", "return clickButton(event,'" + lbtFind.ClientID + "')")
            txtKey.Text = flCheck.DecodeSearch(Request.QueryString("key") & "")

            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1

            If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Manager") = False And flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Administrators") = False Then
                RegisterUser.Enabled = False
                Call flDic.ListUserName(RegisterUser, Me.UserInfo.Username)
                RegisterUser.SelectedValue = Me.UserInfo.Username
            Else
                Call flDic.ListUserName(RegisterUser, "true")
				RegisterUser.SelectedValue = Request.QueryString("user") & ""
            End If
        End Sub
        Private Sub LoadValue()
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
            arrTemp = ObjController.CMS_Authors_List_Search(ddlPortal.SelectedValue, flCheck.DecodeSearch(txtKey.Text.Trim), 0, CurrentPage.Value, 35, RegisterUser.SelectedValue)
            For Each Cr As CMS_AuthorsInfo In arrTemp
                lbTotal.Text = flReg.FormatPrice(Cr.Total)
                If Cr.Total > 35 Then
                    litPage.Text = flReg.NextPage(Cr.Total, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                End If
                Exit For
            Next
            grdData.DataSource = arrTemp
            grdData.DataKeyField = "Authors_ID"
            grdData.DataBind()
        End Sub
        Private Function RedirectURL() As String
            Dim str As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If ddlPortal.SelectedValue <> Me.PortalId Then str += "/pid/" & ddlPortal.SelectedValue
            If RegisterUser.SelectedValue <> "" Then str += "/user/" & RegisterUser.SelectedValue
            If txtKey.Text.Trim <> "" Then str += "/key/" & flCheck.EncodeSearch(txtKey.Text.Trim)
            Return str
        End Function

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


#End Region
#Region "Event"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Call InitControl()
                Call LoadValue()
            End If
        End Sub

        Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            If RegisterUser.SelectedValue <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue & "/user/" & RegisterUser.SelectedValue, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
            End If
        End Sub

        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "Authors_ID") & "/pid/" & ddlPortal.SelectedValue

            liter = e.Item.FindControl("STT")
            liter.Text = grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1
            itemID = DataBinder.Eval(e.Item.DataItem, "Authors_ID")

            liter = e.Item.FindControl("FullName")
            liter.Text = "<a title='" & DataBinder.Eval(e.Item.DataItem, "FullName") & "' href='" & strURL & "'> " & DataBinder.Eval(e.Item.DataItem, "FullName") & "</a>"

            liter = e.Item.FindControl("PenName")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "PenName")

            liter = e.Item.FindControl("Phone")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Phone")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

        End Sub

        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            Try
                Dim icount As Integer = 0

                For i As Integer = 0 To grdData.Items.Count - 1
                    cbDelete = grdData.Items(i).FindControl("chkItems")
                    If cbDelete.Checked = True Then
                        itemID = grdData.DataKeys(i)
                        ObjController.CMS_Authors_Delete(ddlPortal.SelectedValue, itemID)
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

        Private Sub lbtFind_Click(sender As Object, e As EventArgs) Handles lbtFind.Click, RegisterUser.SelectedIndexChanged, ddlPortal.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
#End Region
    End Class
End Namespace
