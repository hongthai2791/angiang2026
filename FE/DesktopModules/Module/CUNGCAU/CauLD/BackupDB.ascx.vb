Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim obj As New BC_BackupInfo
        Dim objController As New CauController
        Private Sub LoadValue()
            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP, "")
            If flReg.WebConfig("TinhTP") <> "0" Then
                TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            End If
            cmdBackup.Visible = True : lbMsg.Text = ""
            Dim bj = objController.BC_SendMail_List_Years(Me.PortalId, TinhTP.SelectedValue, Me.PortalId)
            If (IsNothing(bj) = False) Then
                obj = objController.BC_Backup_Get_TinhTP_Years(Me.PortalId, TinhTP.SelectedValue, bj.Years_ID)
                Years.Text = bj.Years_ID
            End If
            If IsNothing(obj) = False Then
                lbMsg.Text = "<div class=""cmsUpdate1"">Dữ liệu đã được sao lưu bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & " đã sao lưu được <b>(" & obj.IsData & ")</b> vào ngày " & flReg.ReadDate(obj.CreatedDate) & "</div>"
                cmdBackup.Visible = False
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then

                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdBackup_Click(sender As Object, e As EventArgs) Handles cmdBackup.Click
            Try
                obj = New BC_BackupInfo
                obj.ID = flReg.GenKey()
                obj.TinhTP = TinhTP.SelectedValue
                obj.PortalId = Me.PortalId
                obj.Years = flReg.WriteNumber(Years.Text)
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                objController.BC_Backup_Add(Me.PortalId, obj)
                objController.BC_Business_Backup_Add(Me.PortalId, TinhTP.SelectedValue, obj.Years)

                objController.BC_SendMail_Update_Active(Me.PortalId, TinhTP.SelectedValue, obj.Years, Me.PortalId, Me.UserInfo.Username)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_done", "removewaiting(); notify('success','Đã sao lưu dữ liệu thành công.', 'Thông báo', false);", True)
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call LoadValue()
        End Sub
    End Class
End Namespace
