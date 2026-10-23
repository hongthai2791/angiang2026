Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports System.Threading
Imports Telerik.Web.UI

Namespace DesktopModules.DanhMuc.PhongBan
    Public MustInherit Class inc_list
        Inherits Entities.Modules.PortalModuleBase
        Public isLang As String = Thread.CurrentThread.CurrentCulture.Name
        Dim ObjController As New CmsController
        Dim arr As New ArrayList
        Dim txtg As RadNumericTextBox
        Dim ItemID, strURL As String
        Dim liter As Literal

        Private Sub LoadMonth()
            Months.Items.Clear()
            For i As Integer = 1 To 12
                Months.Items.Add(New ListItem("Tháng " + i.ToString(), i))
            Next
            If Request.Item("month") & "" <> "" Then
                Months.SelectedValue = Request.Item("month")
            Else
                Months.SelectedValue = Now.Month
            End If
        End Sub
        Private Sub LoadYear()
            Years.Items.Clear()
            For i As Integer = 2015 To Now.Year + 1
                Years.Items.Add(New ListItem("Năm " + i.ToString(), i))
            Next
            If Request.Item("year") & "" <> "" Then
                Years.SelectedValue = Request.Item("year")
            Else
                Years.SelectedValue = Now.Year
            End If
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    Call LoadMonth()
                    Call LoadYear()
                    Call LoadValue()
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub LoadValue()
            arr = ObjController.CMS_DMNhuanBut_List_Search(ddlPortal.SelectedValue, "", 1, Months.SelectedValue, Years.SelectedValue)
            drgViewData.DataSource = arr
            drgViewData.PageSize = 20
            drgViewData.DataKeyField = "ID"
            drgViewData.DataBind()
            litCount.Value = arr.Count
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "removewaiting();", True)
        End Sub

        Protected Sub drgViewData_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles drgViewData.ItemCommand
            Select Case e.CommandName
                Case "imb_edit"
                    Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/view/detail/itemid/" & drgViewData.DataKeys.Item(e.CommandArgument).ToString, True)
            End Select
        End Sub

        Protected Sub drgViewData_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles drgViewData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            txtg = e.Item.FindControl("Orders")
            txtg.Text = e.Item.ItemIndex + 1

            liter = e.Item.FindControl("Description")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Description")

            liter = e.Item.FindControl("Price")
            liter.Text = "<span style='font-weight:bold; color:green;float:right;'>" & DataBinder.Eval(e.Item.DataItem, "DonGia") & "</span>"

            ItemID = DataBinder.Eval(e.Item.DataItem, "ID")

            liter = e.Item.FindControl("Type")

            If DataBinder.Eval(e.Item.DataItem, "Type") = 1 Then
                liter.Text = "Định mức cho tin"
            Else
                liter.Text = "Định mức cho ảnh"
            End If

            liter = e.Item.FindControl("CreateUser")

            If DataBinder.Eval(e.Item.DataItem, "UpdateUser") <> "" Then
                liter.Text = flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "UpdateUser"))
            Else
                liter.Text = flReg.GetUserName(DataBinder.Eval(e.Item.DataItem, "CreateUser"))
            End If

            liter = e.Item.FindControl("CreateDate")

            If DataBinder.Eval(e.Item.DataItem, "UpdateUser") <> "" Then
                liter.Text = DateTime.Parse(DataBinder.Eval(e.Item.DataItem, "UpdateDate")).ToString("dd/MM/yyyy")
            Else
                liter.Text = DateTime.Parse(DataBinder.Eval(e.Item.DataItem, "CreateDate")).ToString("dd/MM/yyyy")
            End If

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & ItemID

            liter = e.Item.FindControl("IsEdit")
            liter.Text = "<a class=""aedit"" href=""" & strURL & """><img src=""/image/images/F-edit.png"" alt=""edit"" /></a>"

            liter = e.Item.FindControl("MaDM")
            liter.Text = "<a class=""aedit"" href=""" & strURL & """><span style='font-weight:bold;'>" & DataBinder.Eval(e.Item.DataItem, "MaDM") & "</span></a>"

        End Sub

        Protected Sub lbtAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/c/" & Integer.Parse(litCount.Value) + 1, True)
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

        Private Function RedirectURL() As String
            RedirectURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            RedirectURL += "/pid/" & ddlPortal.SelectedValue
            RedirectURL += "/year/" & Years.SelectedValue
            RedirectURL += "/month/" & Months.SelectedValue
        End Function
        Private Sub Months_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged, Months.SelectedIndexChanged, Years.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
    End Class
End Namespace
