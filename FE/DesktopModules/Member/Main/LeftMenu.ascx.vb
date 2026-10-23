Imports DotNetNuke.EPORTAL

Namespace Modules.LeftMenu
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim strMode, _viewTable As String
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName

        Private Function active(menu As String) As String
            active = ""
            If Request.Item("view") = menu Or Request.Item("edit") = menu Then Return "active"
        End Function
        Private Function cssTable(_viewTa As String) As String
            If _viewTa.Length > 4 Then
                Return _viewTable.Substring(4)
            Else
                Return _viewTa
            End If
        End Function
        Private Sub LoadMenu(connection As String)
            arrTemp = flDnn.CMS_Module_List_Menu(connection, _tabName, VaiTroND.Value)
            If arrTemp.Count > 0 Then
                litMenu.Text = "<ul class=""sidebar-menu"">"
                For Each Cr As CMS_ModuleInfo In arrTemp
                    _viewTable = flReg.Decrypt("1", Cr.ModuleSrc)

                    arrTemp1 = flDnn.CMS_Module_List_By_User(connection, _tabName, VaiTroND.Value, Cr.Module_ID)
                    litMenu.Text += "<li class='treeview " & active(_viewTable) & "'>"
                    litMenu.Text += "<a class=""a-choose"" href=""/" & _tabName & "/" & IIf(Cr.ctlView = "", "edit", "view") & "/" & _viewTable & """>"
                    litMenu.Text += "<i class=""fa fa-" & IIf(Cr.Img = "", "reorder", Cr.Img) & """></i><span>" & Cr.ModuleName
                    litMenu.Text += "<span class='pa-" & _viewTable & " " & _viewTable & "' id='" & _viewTable & "' val='1'>"
                    If arrTemp1.Count > 0 Then litMenu.Text += "</span></span><i class=""fa fa-angle-left pull-right""></i>"
                    litMenu.Text += "</a>"

                    If arrTemp1.Count > 0 Then
                        litMenu.Text += strMode
                        For Each Ci As CMS_ModuleInfo In arrTemp1
                            _viewTable = flReg.Decrypt("1", Ci.ModuleSrc)
                            litMenu.Text += "<li class='" & active(_viewTable) & "'>"

                            litMenu.Text += "<a class=""a-choose"" href=""/" & _tabName & "/" & IIf(Ci.ctlView = "", "edit", "view") & "/" & _viewTable & """>"
                            litMenu.Text += "<i class=""fa fa-caret-right""></i><span>" & Ci.ModuleName
                            litMenu.Text += "<span class='" & cssTable(_viewTable) & " " & _viewTable & "' id='" & _viewTable & "' val='0'>"
                            litMenu.Text += "</span></span></a></li>"
                        Next
                        litMenu.Text += "</ul>"
                        strMode = "<ul class=""treeview-menu"">"
                    End If
                    litMenu.Text += "</li>"
                Next
                litMenu.Text += "</ul>"
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Try
                    If Me.UserInfo.IsInRole(_tabName) = False Then
                        Response.Redirect("/404.aspx")
                    Else
                        VaiTroND.Value = "-10"
                        _PortalID.Value = Me.PortalId
                        If Request.Item("view") = "" And Request.Item("edit") = "" Then
                            strMode = "<ul class=""treeview-menu menu-open"" style='display:block'>"
                        Else
                            strMode = "<ul class=""treeview-menu"">"
                        End If
                        Call LoadMenu(flConnect.DmConnect)
                    End If
                Catch ex As Exception
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
                End Try
            End If
        End Sub

    End Class

End Namespace
