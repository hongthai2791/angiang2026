Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Modules

Namespace DesktopModules.Modules.Home
    Partial Class MenuHome
        Inherits PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim ObjController As New CmsController

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                'If Not Page.IsPostBack Then
                Call LoadMenu()
                'End If
            Catch ex As Exception
                litMenu.Text = ex.Message
            End Try
        End Sub
        Public Sub LoadMenu(ParentID As String)
            arrTemp = ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, ParentID)
            If arrTemp.Count > 0 Then
                litMenu.Text += "<ul>"
                For Each Cj As CMS_MenuDInfo In arrTemp
                    If Cj.MenuD_Name <> "" Then
                        If ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, Cj.MenuD_ID).Count > 0 Then
                            litMenu.Text += "<li><a href=""" & Cj.Url & """ title=""" & flReg.ImgAlt(Cj.MenuD_Name) & """>" & Cj.MenuD_Name & " <i class=""glyphicon glyphicon-triangle-right""></i></a>"
                        Else
                            litMenu.Text += "<li><a href=""" & Cj.Url & """ title=""" & flReg.ImgAlt(Cj.MenuD_Name) & """>" & Cj.MenuD_Name & "</a>"
                        End If
                        Call LoadMenu(Cj.MenuD_ID)
                        litMenu.Text += "</li>"
                    End If
                Next
                litMenu.Text += "</ul>"
            End If
        End Sub
        Public Sub LoadMenu()
            litMenu.Text = "" 'flCache.GetCache("Menu_HOME_" & Me.PortalId) & ""
            If litMenu.Text = "" Then
                For Each Cr As CMS_MenuDInfo In ObjController.CMS_MenuD_List_By_MenuID(Me.PortalId, "HOME", Me.PortalId)
                    litMenu.Text += "<li><a href=""" & Cr.Url & """ title=""" & flReg.ImgAlt(Cr.MenuD_Name) & """>" & Cr.MenuD_Name & "</a>"
                    Call LoadMenu(Cr.MenuD_ID)
                    litMenu.Text += "</li>"
                Next


                flCache.SetCache("Menu_HOME_" & Me.PortalId, litMenu.Text)
            End If
        End Sub

    End Class
End Namespace