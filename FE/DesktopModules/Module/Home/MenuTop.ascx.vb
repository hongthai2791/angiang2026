Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class MenuTop
        Inherits PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim ObjController As New CmsController

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not Page.IsPostBack Then Call LoadMenu()
        End Sub
        Public Sub LoadMenu(ParentID As String)
            arrTemp = ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, ParentID)
            If arrTemp.Count > 0 Then
                litMenu.Text += "<ul>"
                For Each Cj As CMS_MenuDInfo In arrTemp
                    litMenu.Text += "<li><a href=""" & Cj.Url & """ title=""" & flReg.ImgAlt(Cj.MenuD_Name) & """>" & Cj.MenuD_Name & "</a>"
                    Call LoadMenu(Cj.MenuD_ID)
                    litMenu.Text += "<li>"
                Next
                litMenu.Text += "</ul>"
            End If
        End Sub
        Public Sub LoadMenu()
            litMenu.Text = flCache.GetCache("Menu_TOP_" & Me.PortalId) & ""
            If litMenu.Text = "" Then
                For Each Cr As CMS_MenuDInfo In ObjController.CMS_MenuD_List_By_MenuID(Me.PortalId, "TOP", Me.PortalId)
                    litMenu.Text += "<li><a href=""" & Cr.Url & """ title=""" & flReg.ImgAlt(Cr.MenuD_Name) & """>" & Cr.MenuD_Name & "</a>"
                    Call LoadMenu(Cr.MenuD_ID)
                    litMenu.Text += "<li>"
                Next
                flCache.SetCache("Menu_TOP_" & Me.PortalId, litMenu.Text)
            End If
        End Sub
    End Class
End Namespace