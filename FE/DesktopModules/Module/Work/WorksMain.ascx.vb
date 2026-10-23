Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules.Work
    Partial Class WorksMain
        Inherits Entities.Modules.PortalModuleBase
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Dim o_control As UserControl = CType(Page.LoadControl(Me.TemplateSourceDirectory & "/WorksList.ascx"), UserControl)
                Dim sId As Integer = CMS.Ultis.GetRequestId(Request.RawUrl)
                If sId > 0 And Request.Item("nganh-nghe") & "" = "" Then
                    Dim obj As New CMS_WorkInfo
                    obj = CType(flCache.GetCache("CMS_Work_Get_ID_" & sId), CMS_WorkInfo)
                    If IsNothing(obj) Then
                        obj = New WorkController().CMS_Work_Get_ID(PortalId, sId)
                        flCache.SetCache("CMS_Work_Get_ID_" & sId, obj, SecondCache.M30)
                    End If
                    If IsNothing(obj) = False Then
                        Dim strUrl As String = flCheck.GetHomeLinkWork(obj.Title, obj.ID)
                        o_control = CType(Page.LoadControl(Me.TemplateSourceDirectory & "/WorksDetails.ascx"), UserControl)
                        If strUrl.Contains(Request.RawUrl) = False Then
                            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "change_url", "changeUrl('" & strUrl & "');", True)
                        End If
                    End If
                Else
                    If Request.Item("view") <> "settings" And Request.Item("mdid") <> "" And Request.RawUrl.ToString().ToLower() <> Me.PortalSettings.ActiveTab.TabPath.Replace("//", "/").ToLower() & IIf(Request.Item("p") & "" <> "", "/p/" & Request.Item("p"), "") Then
                        Response.Redirect(flReg.UrlAlias & "/404.aspx", True)
                    End If
                End If
                Me.plhWork.Controls.Add(o_control)
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace