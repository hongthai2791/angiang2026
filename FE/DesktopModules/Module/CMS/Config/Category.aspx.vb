Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.TinTuc.Control
    Partial Class ChooseCategory
        Inherits CDefault
        Dim ObjController As New CmsController
        Dim pId As Integer
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                pId = flReg.WriteNumber(Context.Request.Item("pid"))
                If Request.IsAuthenticated Then
                    If Not IsPostBack Then
                        Call BindData()
                    End If
                Else
                    Response.Redirect("/")
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(pId, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub BindData()
            Try
                Dim arrNewsCategories As New ArrayList
                If Request.Item("settings") = "settingAudio" Then
                    arrNewsCategories = ObjController.CMS_NewsCategories_List_All(pId, pId, flConnect.IsLang, CategoryType.Audio)
                Else
                    arrNewsCategories = ObjController.CMS_NewsCategories_List_All(pId, pId, flConnect.IsLang, CategoryType.News)

                End If
                Dim arrTemp As New ArrayList
                If arrNewsCategories.Count > 0 Then
                    For Each Cr1 As CMS_NewsCategoriesInfo In arrNewsCategories
                        If Cr1.ParentId = 0 Then
                            arrTemp.Add(Cr1)
                            For Each Cr2 As CMS_NewsCategoriesInfo In arrNewsCategories
                                If Cr2.ParentId = Cr1.CategoryID Then
                                    Cr2.CategoryName = "|----" & Cr2.CategoryName
                                    arrTemp.Add(Cr2)
                                    For Each Cr3 As CMS_NewsCategoriesInfo In arrNewsCategories
                                        If Cr3.ParentId = Cr2.CategoryID Then
                                            Cr3.CategoryName = "|--------" & Cr3.CategoryName
                                            arrTemp.Add(Cr3)
                                        End If
                                    Next

                                End If
                            Next
                        End If
                    Next
                End If
                drgData.DataSource = arrTemp
                drgData.DataBind()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(pId, ex.Message, "cms") & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace