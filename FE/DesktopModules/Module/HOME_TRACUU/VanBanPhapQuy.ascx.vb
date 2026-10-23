Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Home
    Partial Class VanBanPhapQuy
        Inherits PortalModuleBase
        Dim arr As New ArrayList
        Dim objControll As New CmsController()
        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub InitControls()
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = 0 Then currPage.Value = 1

            Call flFunction.LoadDocField(0, DocField_ID, "- -  Lĩnh vực văn bản - -")
            DocField_ID.SelectedValue = Request.Item("field") & ""

            Call flFunction.LoadDocType(0, DocType_ID, "- -  Loại văn bản- -")
            DocType_ID.SelectedValue = Request.Item("type") & ""

            Call flFunction.LoadDocUnit(0, DocUnit_ID, "- -  Cơ quan ban hành - -")
            DocUnit_ID.SelectedValue = Request.Item("pro") & ""

            Search.Text = flCheck.DecodeSearch(Request.Item("key") & "")
            DOC_LIST_GROUP.Value = flReg.SettingValue(flConnect.DmConnect, _tabName, "DOC_LIST_GROUP", _tabName)
            If Me.UserInfo.Username = "host" Then
                Call flFunction.LoadDocGroup_Parent_Null(Me.PortalId, DocGroup_ID)
                DocGroup_ID.SelectedValue = DOC_LIST_GROUP.Value
            Else
                Call flFunction.LoadDocGroup_Parent_ID(Me.PortalId, DocGroup_ID, DOC_LIST_GROUP.Value)
            End If
        End Sub

        Private Function RedirectURL() As String
            RedirectURL = NavigateURL(Me.TabId)
            If DocField_ID.SelectedValue <> "" Then RedirectURL += "/field/" & DocField_ID.SelectedValue
            If DocType_ID.SelectedValue <> "" Then RedirectURL += "/type/" & DocType_ID.SelectedValue
            If DocUnit_ID.Text <> "" Then RedirectURL += "/pro/" & DocUnit_ID.Text
            If Search.Text.Trim <> "" Then RedirectURL += "/key/" & flCheck.EncodeSearch(Search.Text.Trim)
        End Function
        Private Sub LoadValue()
            litRow.Text = ""
            If DocGroup_ID.SelectedValue <> "" Then
                arr = objControll.CMS_Document_List_Home(0, Search.Text, DocType_ID.SelectedValue, DocField_ID.SelectedValue, DocUnit_ID.SelectedValue, DocGroup_ID.SelectedValue, currPage.Value, 10)
            Else
                arr = objControll.CMS_Document_List_Home(0, Search.Text, DocType_ID.SelectedValue, DocField_ID.SelectedValue, DocUnit_ID.SelectedValue, DOC_LIST_GROUP.Value, currPage.Value, 10)
            End If
            For Each Cr As CMS_DocumentInfo In arr
                litRow.Text += "<tr>"
                litRow.Text += "<td style=""width: 15%; padding-left: 7px; vertical-align: middle"">"
                litRow.Text += "<a onclick='updateDownload(""" & Cr.Document_ID & """,""" & Me.PortalId & """);' target=""_blank"" title=""" & Cr.NoCode & """ href=""" & flConnect.fileDomain & Cr.FileSource & """>" & Cr.NoCode & "</a>"
                litRow.Text += "</td>"
                litRow.Text += "<td class=""hidden-xs"" style=""width: 15%; text-align: center; vertical-align: middle"">" & flReg.ReadDate(Cr.PromDate, False) & "</td>"
                litRow.Text += "<td style=""width: 60%; padding-left: 3px; vertical-align: middle"">"
                litRow.Text += "<span>" & Cr.Document_Name & "</span>"
                litRow.Text += "</td>"
                litRow.Text += "<td style=""width: 10%; text-align: center; vertical-align: middle"">"
                litRow.Text += "<a target=""_blank"" href=""/api/home/download.aspx?pid=" & Me.PortalId & "&id=" & Cr.Document_ID & " title=""Tải tài liệu"">"
                litRow.Text += "<i class=""fa fa-download"" aria-hidden=""true""></i></a>"
                litRow.Text += "</td>"
                litRow.Text += "</tr>"
            Next
            lbTotal.Text = "" : litPage.Text = "" 'Phân trang
            For Each Ci As CMS_DocumentInfo In arr
                litPage.Text = flReg.NextPage(Ci.Total, 35, currPage.Value, 10, RedirectURL() & "/p/")
                lbTotal.Text = "Có tất cả: <b>" & Ci.Total & "</b> văn bản."
                Exit For
            Next
        End Sub

        Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles DocGroup_ID.SelectedIndexChanged, cmdFind.Click, DocField_ID.SelectedIndexChanged, DocType_ID.SelectedIndexChanged, DocUnit_ID.SelectedIndexChanged
            Try

                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifyinfo", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "cms") & "', 'Thông báo', false);", True)
            End Try

        End Sub
    End Class
End Namespace

