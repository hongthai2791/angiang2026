Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Modules

Namespace DotNetNuke.Modules
    Partial Public Class MainSettings
        Inherits ModuleSettingsBase
        Public Shared CONTROL_NAME_KEY As String = "CONTROL_NAME_KEY"
        Dim objModules As New Entities.Modules.ModuleController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Me.UserId < 0 Then Response.Redirect("/404.aspx", True)
            lit.Text = "Thiết lập cài đặt module " & Me.TabModuleId
            If Not IsPostBack Then
                Call LoadSettings()
            End If
        End Sub
        Public Overrides Sub LoadSettings()
            Try
                litModule.Text = flDnn.DNN_TabModuleSettings_Get_Value(flConnect.DnnSqlServer, Me.PortalId, Me.TabModuleId, CONTROL_NAME_KEY).Replace("\", "/")
                hidPath.Value = litModule.Text.Replace("\", "/")
            Catch exc As Exception
            End Try
        End Sub
        Public Overrides Sub UpdateSettings()
            flDnn.DNN_TabModuleSettings_Add(flConnect.DnnSqlServer, Me.PortalId, Me.TabModuleId, CONTROL_NAME_KEY, (hidPath.Value), 1, Now, 1, Now)
        End Sub

        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                flDnn.DNN_TabModuleSettings_Add(flConnect.DnnSqlServer, Me.PortalId, Me.TabModuleId, CONTROL_NAME_KEY, hidPath.Value.Replace("/", "\"), 1, Now, 1, Now)
                Response.Redirect(NavigateURL(Me.TabId), True)
            Catch ex As Exception
                litModule.Text = ex.Message
            End Try
        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(NavigateURL(Me.TabId), True)
        End Sub
    End Class
End Namespace