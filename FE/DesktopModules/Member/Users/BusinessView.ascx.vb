Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim obj As New CMS_BusinessInfo
        Dim bUinfo As New CMS_BusUserInfo

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
			'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
			Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName
			If IsNothing(Request.UrlReferrer) = False Then ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
		End Sub
		Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
		Private Sub LoadValue()
			obj = objController.CMS_Business_Get(Me.PortalId, Request.Item("itemid"))
			If IsNothing(obj) = False Then
				ItemID.Value = obj.Business_ID
				Business_Vn.Text = obj.Business_Vn
				Business_En.Text = obj.Business_En
				Business_Sort.Text = obj.Business_Sort
				TinhTP.SelectedValue = obj.TinhTP
				Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
				QuanHuyen.SelectedValue = obj.QuanHuyen
				If obj.Logo & "" <> "" Then
					imgDD.InnerHtml = "<img alt='ảnh đại diện' src='" & flConnect.fileDomain & obj.Logo & "?dpi=150&quality=100&w=145&h=120' />"
				End If
				LogoDN.Value = obj.Logo

				Description.Text = obj.Description
				TaxCode.Text = obj.TaxCode
				'Mobile.Text = obj.Mobile
				Scale.Text = obj.Scale
				'Fax.Text = obj.Fax
				Website.Text = obj.Website
				'Email.Text = obj.Email
				Address.Text = obj.Address
				ContactUser.Text = obj.ContactUser
				ContactMobile.Text = obj.ContactMobile
				ContactEmail.Text = obj.ContactEmail
				IsApproval.Checked = obj.IsApproval
			End If
		End Sub
		Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
			Call BackEnd()
		End Sub

	End Class
End Namespace
