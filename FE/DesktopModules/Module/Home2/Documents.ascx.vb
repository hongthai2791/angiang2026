Imports DotNetNuke.CMS
Imports DotNetNuke.Entities.Modules

Namespace DesktopModules.Home
    Partial Class Documents
        Inherits PortalModuleBase
        Dim arr As New ArrayList

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    timKiem.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdSearch.ClientID + "')")
                    Call flFunction.LoadDocField(0, LinhVuc, "- -  Chọn lĩnh vực - -")
                    Call flFunction.LoadDocType(0, LoaiVanBan, "- -  Chọn loại văn bản- -")
                    Call flFunction.LoadDocUnit(0, CoQuanBH, "- -  Chọn cơ quan ban hành - -")
                    Call LoadValues()
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub LoadValues()
            If CoQuanBH.SelectedValue <> "" Then
                arr = New CmsController().CMS_Document_List_Home(0, timKiem.Text.Trim(), LoaiVanBan.SelectedValue, LinhVuc.SelectedValue, CoQuanBH.SelectedItem.Text, 1, 20)
            Else
                arr = New CmsController().CMS_Document_List_Home(0, timKiem.Text.Trim(), LoaiVanBan.SelectedValue, LinhVuc.SelectedValue, "", 1, 20)
            End If
            lbTotal.Text = 0 : litRow.Text = ""
            For Each Cr As CMS_DocumentInfo In arr
                litRow.Text += "<tr>"
                litRow.Text += "<td style=""width: 15%; padding-left: 7px; vertical-align: middle"">" & Cr.NoCode & "</td>"
                litRow.Text += "<td class=""hidden-xs"" style=""width: 15%; text-align: center; vertical-align: middle"">" & EPORTAL.flReg.ReadDate(Cr.PromDate, False) & "</td>"
                litRow.Text += "<td style=""width: 60%; padding-left: 3px; vertical-align: middle""><span>" & Cr.Document_Name & "</span></td>"
                litRow.Text += "<td style=""width: 10%; text-align: center; vertical-align: middle"">"
                litRow.Text += "<a onclick='updateDownload(""" & Cr.Document_ID & """,""" & Me.PortalId & """);' title='" & Cr.FileName & "'>"
                litRow.Text += "<i class=""fa fa-download"" aria-hidden=""true""></i></a></td>"
                litRow.Text += "</tr>"
            Next
            For Each Cr As CMS_DocumentInfo In arr
                lbTotal.Text = EPORTAL.flReg.FormatPrice(Cr.Total)
                If Cr.Total > 20 Then
                    litPage.Text = "<div class=""phan-trang"">"
                    litPage.Text += EPORTAL.flReg.NextPageJs(Cr.Total, 20, 1, 5, "fnext(")
                    litPage.Text += "</div>"
                End If
            Next
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, LoaiVanBan.SelectedIndexChanged, LinhVuc.SelectedIndexChanged, CoQuanBH.SelectedIndexChanged
            Call LoadValues()
        End Sub
    End Class
End Namespace

