Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim obj As New CMS_JobUserInfo
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim strURL As String


        Private Sub LoadValues()
            ItemID.Value = Request.Item("itemid")
            obj = objController.CMS_JobUser_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                JobTitle.Text = obj.Title
            End If
            arrTemp = objController.CMS_JobHistory_List_ByJobUserID(Me.PortalId, ItemID.Value)
            rptBienDong.DataSource = arrTemp
            rptBienDong.DataBind()
        End Sub

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub BackEnd()
            If ViewState("UrlReferrer") IsNot Nothing Then
                Response.Redirect(ViewState("UrlReferrer"), True)
            End If
        End Sub

    End Class

End Namespace
