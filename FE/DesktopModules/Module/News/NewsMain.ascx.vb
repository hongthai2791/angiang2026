Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home

    Public MustInherit Class Main
        Inherits Entities.Modules.PortalModuleBase
        Dim obj As New CMS_NewsInfo

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Dim o_control As UserControl = CType(Page.LoadControl(Me.TemplateSourceDirectory & "/NewsList.ascx"), UserControl)
                Dim sId As Integer = Ultis.GetRequestId(Request.RawUrl)
                If sId > 0 Then
                    obj = New CmsController().CMS_News_Get(PortalId, sId)
                    If IsNothing(obj) = False Then
                        Dim strUrl As String = Ultis.FormatLink(Me.PortalId, obj.CategoryId, obj.NewId, obj.ToUrl)
                        o_control = CType(Page.LoadControl(Me.TemplateSourceDirectory & "/NewsRead.ascx"), UserControl)
                        If strUrl.Contains(Request.RawUrl) = False Then
                            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "change_url", "changeUrl('" & strUrl & "');", True)
                        End If
                    End If
                Else
                    If Request.Item("view") <> "settings" And Request.Item("mdid") <> "" And Request.RawUrl.ToString().ToLower() <> Me.PortalSettings.ActiveTab.TabPath.Replace("//", "/").ToLower() & IIf(Request.Item("p") & "" <> "", "/p/" & Request.Item("p"), "") Then
                        Response.Redirect(flReg.UrlAlias & "/404.aspx", True)
                    End If
                End If
                Me.plhNews.Controls.Add(o_control)
            Catch ex As Exception
            End Try
        End Sub

    End Class
End Namespace