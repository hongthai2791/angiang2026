Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList, ItemId As String
        Dim chBox As CheckBox, liter As Literal
        Dim Hf As HiddenField
        Dim icount As Integer = 0
        Dim strURL As String
        Public Event OnSubmit()
        Public Property SelectedGrdItem() As Integer
            Get
                Return _HF_GrItem.Value
            End Get
            Set(ByVal value As Integer)
                _HF_GrItem.Value = value
            End Set
        End Property
        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            If Request.Item("px") <> "" Then PhuongXa.SelectedValue = Request.Item("px")
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Business_List_NotJoinPhienGD(Me.PortalId, txtkey.Text.Trim, currPage.Value, drPageSize.SelectedValue, _PGDId.Value)
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Business_ID"
            grdData.DataBind()
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đang hoạt động", "1"))
            drSort.Items.Add(New ListItem("Ngừng hoạt động", "2"))
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If PhuongXa.SelectedValue <> "" Then RedirectURL += "/px/" & PhuongXa.SelectedValue
            If drSort.SelectedValue <> "0" Then RedirectURL += "/sort/" & drSort.SelectedValue
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, PhuongXa.SelectedIndexChanged
            Call LoadValues()
        End Sub

        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            ItemId = DataBinder.Eval(e.Item.DataItem, "Business_ID")

            liter = e.Item.FindControl("ID")
            liter.Text = flReg.FormatGenCode(DataBinder.Eval(e.Item.DataItem, "ID"))
            Hf = e.Item.FindControl("HF_ID_InGrid")
            Hf.Value = DataBinder.Eval(e.Item.DataItem, "Business_ID")
            liter = e.Item.FindControl("ContactUser")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactUser")

            liter = e.Item.FindControl("ContactMobile")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ContactMobile")

            liter = e.Item.FindControl("Address")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Address")

            liter = e.Item.FindControl("Business_Vn")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Business_Vn")
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue)
            Call LoadValues()
        End Sub

        Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
            Try

                Dim obDN As New CMS_DoanhNghiepInfo
                obDN = objController.CMS_DoanhNghiep_Get(Me.PortalId, _SelectedId.Value)
                obDN.Business_ID = _HF_GrItem.Value
                obDN.UpdatedBy = Now
                obDN.UserUpdate = Me.UserInfo.Username
                Call objController.CMS_DoanhNghiep_Replace(Me.PortalId, obDN)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "closeDialogDoanhNghiep();notify('succcess', 'Thay thế doanh nghiệp thành công', 'Thông báo', false);", True)
                Call LoadValues()
                RaiseEvent OnSubmit()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class

End Namespace
