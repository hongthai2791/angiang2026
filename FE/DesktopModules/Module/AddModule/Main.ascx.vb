Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL

Namespace DotNetNuke.Modules
    Partial Public Class Main
        Inherits PortalModuleBase
        Dim objModule As New PortalModuleBase
        Dim DynamicPage As String

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Try
                DynamicPage = flDnn.DNN_TabModuleSettings_Get_Value(flConnect.DnnSqlServer, PortalId, TabModuleId, "CONTROL_NAME_KEY")
                If Request.Item("view") = "settings" And Me.TabModuleId = Request.Item("mdid") Then DynamicPage = "Settings.ascx"
                If DynamicPage = "" Then DynamicPage = "None.ascx"
                objModule = CType(Me.LoadControl(DotNetNuke.Common.ResolveUrl(DynamicPage)), PortalModuleBase)
                If Not objModule Is Nothing Then
                    objModule.ModuleConfiguration = Me.ModuleConfiguration
                    plControl.Controls.Add(objModule)
                End If
                If Me.UserInfo.Username = "host" Then cmdSetting.Visible = True
            Catch ex As Exception
                If Me.UserInfo.Username = "host" Then
                    lbm.InnerHtml = "<div style='font-size:14px;color:blue'>Lỗi: " & ex.Message & "</div>"
                End If
            End Try
        End Sub
        Private Sub cmdSetting_Click(sender As Object, e As EventArgs) Handles cmdSetting.Click
            Response.Redirect(NavigateURL(Me.TabId)& "?mdid=" & Me.TabModuleId & "&view=settings", True)
        End Sub
    End Class
End Namespace
