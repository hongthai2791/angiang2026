Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class MenuMobile
        Inherits PortalModuleBase
        Dim arrTemp, arrTempChild As New ArrayList
        Dim ObjController As New CmsController
        Dim _i As Integer = 1, _ii As Integer = 1000

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not Page.IsPostBack Then
                    Call LoadMenu()
                End If
            Catch ex As Exception
                litMenu.Text = ex.Message
            End Try
        End Sub
        Public Sub LoadMenu(ParentID As String, _IndexUl As Integer, Optional ByVal Conlapse As Boolean = False)
            arrTemp = ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, ParentID)
            If arrTemp.Count > 0 Then
                If Conlapse = True Then
                    litMenu.Text += "<ul class=""collapse"" id=""parentli_" & _IndexUl & """>"
                Else
                    litMenu.Text += "<ul>"
                End If
                For Each Cj As CMS_MenuDInfo In arrTemp
                    arrTempChild = ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, Cj.MenuD_ID)
                    If arrTempChild.Count > 0 Then
                        litMenu.Text += "<li><span class=""bthover-menu collapsed"" data-toggle=""collapse"" data-target=""#parentli_" & _ii + _IndexUl & """></span>"
                        litMenu.Text += "<a href =""" & Cj.Url & """ title=""" & flReg.ImgAlt(Cj.MenuD_Name) & """>" & Cj.MenuD_Name & "</a>"
                        Call LoadMenu(Cj.MenuD_ID, _ii + _IndexUl, True) 'Đánh dấu Index ul sau
                        litMenu.Text += "</li>"
                    Else
                        litMenu.Text += "<li>"
                        litMenu.Text += "<a href=""" & Cj.Url & """ title=""" & flReg.ImgAlt(Cj.MenuD_Name) & """>" & Cj.MenuD_Name & "</a>"
                        litMenu.Text += "</li>"
                    End If
                    _ii += 1
                Next
                litMenu.Text += "</ul>"
            End If
        End Sub
        Public Sub LoadMenu()
            litMenu.Text = "" ' flCache.GetCache("Menu_MOBILE_" & Me.PortalId) & ""
            If litMenu.Text = "" Then
                For Each Cr As CMS_MenuDInfo In ObjController.CMS_MenuD_List_By_MenuID(Me.PortalId, "HOME", Me.PortalId)
                    arrTemp = ObjController.CMS_MenuD_List_By_ParentID(Me.PortalId, Cr.MenuD_ID)
                    litMenu.Text += "<li><a href=""" & Cr.Url & """ title=""" & flReg.ImgAlt(Cr.MenuD_Name) & """>" & Cr.MenuD_Name & "</a>"
                    Call LoadMenu(Cr.MenuD_ID, _i)
                    litMenu.Text += "</li>"
                    _i += 1
                Next
                flCache.SetCache("Menu_MOBILE_" & Me.PortalId, litMenu.Text)
            End If
        End Sub


    End Class
End Namespace