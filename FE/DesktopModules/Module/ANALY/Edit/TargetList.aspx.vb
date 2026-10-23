Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.ANALY

Namespace DesktopModules.TinTuc.Control

    Partial Class ChooseCategory
        Inherits CDefault
        Dim ObjController1 As New CmsController
        Dim dicInfo As New CMS_MagazineInfo
        Dim pId As Integer
        Dim liter As Literal
        Dim cbox As CheckBox
        Dim arr, arval As New ArrayList
        Dim ObjControler As New AnalyController
        Dim tinhTP As Integer
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                pId = flReg.WriteNumber(Context.Request.Item("PId"))
                If Request.IsAuthenticated Then
                    If Not IsPostBack Then
                        Call ANALY.flFunction.LoadGroup(pId, drGroup, 0, 0, "")
                        Call InitData()
                        ' Call BindData()
                        Call LoadTarget()
                    End If
                Else
                    Response.Redirect("/")
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(pId, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub InitData()
            ItemId.Value = flReg.WriteNumber(Request.Item("itemid"))
            tinhTP = flReg.WriteNumber(Request.Item("tp"))
            ViewState("UrlReferrer") = Request.UrlReferrer.ToString & ""

        End Sub
        Private Sub LoadTarget()
            arval = ObjControler.CMS_MagazineData_List(pId)
            For Each C1 As CMS_TargetsInfo In ObjControler.CMS_Targets_List_Parent_Null(pId, tinhTP, drGroup.SelectedValue)
                C1.Targets_Name = "<b>" & C1.Targets_Name & "</b>"
                RegTarget(arr, C1)
                arr.Add(C1)
                For Each C2 As CMS_TargetsInfo In ObjControler.CMS_Targets_Get_By_CMS_Targets(pId, C1.Targets_ID)
                    C2.Targets_Name = "&nbsp;&nbsp; --> " & C2.Targets_Name
                    arr.Add(C2)
                    RegTarget(arr, C2)
                Next
            Next
            grdTarget.DataSource = arr
            grdTarget.PageSize = arr.Count + 1
            grdTarget.DataKeyField = "Targets_ID"
            grdTarget.DataBind()
        End Sub
        Private Sub RegTarget(ar As ArrayList, tarInfo As CMS_TargetsInfo)
            For Each Cj As CMS_MagazineDataInfo In arval
                If Cj.TargetID = tarInfo.Targets_ID Then
                    tarInfo.IsActive = True
                    arval.Remove(Cj)
                    Exit For
                End If
            Next
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub drGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drGroup.SelectedIndexChanged
            Call InitData()
            Call LoadTarget()
        End Sub
        Private Sub BindData()
            Try
                Dim arrNewsCategories As New ArrayList
                If Request.Item("settings") = "settingAudio" Then
                    arrNewsCategories = ObjController1.CMS_NewsCategories_List_All(pId, pId, flConnect.IsLang, CategoryType.Audio)
                Else
                    arrNewsCategories = ObjController1.CMS_NewsCategories_List_All(pId, pId, flConnect.IsLang, CategoryType.News)

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
                grdTarget.DataSource = arrTemp
                grdTarget.DataBind()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(pId, ex.Message, "cms") & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace