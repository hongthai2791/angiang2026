Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules

    Public MustInherit Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim arrTemp As New ArrayList
        Dim objInfo As New CMS_NewsCategoriesInfo
        Dim txtg As TextBox
        Dim liter As Literal

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    cmdDel.OnClientClick = "return confirm('Bạn có muốn xóa chuyên mục đã chọn không?');"
                    txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdSearch.ClientID + "')")
                    txtkey.Text = flReg.RequestSearch(Request.RawUrl)
                    Call BindLoadPortal()
                    Call flFunction.LoadCategoryType(drlType)
                    If Request.Item("type") & "" <> "" Then drlType.SelectedValue = Request.Item("type")
                    If Request.Item("sd") = "False" Then
                        IsActive.Checked = False
                    Else
                        IsActive.Checked = True
                    End If
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub LoadParent(ParentID As Integer, str As String)
            For Each Cj As CMS_NewsCategoriesInfo In ObjController.CMS_NewsCategories_ByParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, drlType.SelectedValue, ParentID, txtkey.Text)
                Cj.CategoryName = str & " " & Cj.CategoryName
                If Cj.IsActive = IsActive.Checked Then arrTemp.Add(Cj)
                Call LoadParent(Cj.CategoryID, str & "|---")
            Next
        End Sub
        Private Sub LoadValue()
            arrTemp = New ArrayList
            For Each Cr As CMS_NewsCategoriesInfo In ObjController.CMS_NewsCategories_ByParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, drlType.SelectedValue, 0, txtkey.Text)
                If Cr.IsActive = IsActive.Checked Then arrTemp.Add(Cr)
                Call LoadParent(Cr.CategoryID, "|---")
            Next
            drgViewData.DataSource = arrTemp
            drgViewData.DataBind()
        End Sub
        Protected Sub cmdDel_Click(sender As Object, e As System.EventArgs) Handles cmdDel.Click
            Try
                Dim i As Integer
                Dim chkBox As CheckBox
                For i = 0 To drgViewData.Items.Count - 1
                    chkBox = drgViewData.Items(i).FindControl("chkItems")
                    liter = drgViewData.Items(i).FindControl("TabID")
                    If chkBox.Checked = True Then
                        ObjController.CMS_NewsCategories_Delete(ddlPortal.SelectedValue, drgViewData.DataKeys(i))
                    End If
                Next
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            Try
                For Each item As DataGridItem In Me.drgViewData.Items
                    txtg = item.FindControl("IsOrder")
                    ObjController.CMS_NewsCategories_Update_Order(ddlPortal.SelectedValue, drgViewData.DataKeys(item.ItemIndex), flReg.WriteNumber(txtg.Text))
                Next
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Đã cập nhật lại dữ liệu thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/type/" & drlType.SelectedValue & "/pid/" & ddlPortal.SelectedValue)
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
        Protected Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged, drlType.SelectedIndexChanged, IsActive.CheckedChanged
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue & "/type/" & drlType.SelectedValue & "/sd/" & IsActive.Checked, True)
        End Sub

        Private Sub drgViewData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles drgViewData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            txtg = e.Item.FindControl("IsOrder")
            txtg.Text = e.Item.ItemIndex + 1

            liter = e.Item.FindControl("CategoryName")
            liter.Text = "<a href='/cms/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "CategoryID") & "/pid/" & DataBinder.Eval(e.Item.DataItem, "PortalId") & "'>" & DataBinder.Eval(e.Item.DataItem, "CategoryName") & "</a>"

            liter = e.Item.FindControl("CategoryID")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "CategoryID")

            liter = e.Item.FindControl("TabID")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "TabID")

            If DataBinder.Eval(e.Item.DataItem, "IsActive") = "False" Then e.Item.CssClass = "red"

        End Sub

        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            LoadValue()
        End Sub
    End Class
End Namespace