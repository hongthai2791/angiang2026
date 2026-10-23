Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CauController()
        Dim arrTemp As New ArrayList
        Dim _cot3, _cot4, _cot5, _cot6, _cot7, _cot8 As Integer
        Dim str As String = ""
        Private Sub InitControls()
            cmdTongHop.Attributes.Add("onclick", "javascript:return confirm('Khi tổng hợp lại số liệu báo cáo, toàn bộ dữ liệu báo cáo hiện tại sẽ được thay thế mới. <br/>Bạn có chắc muốn tiếp tục thực hiện không?');")

            Call flDic.LoadRegionalTP(Me.PortalId, drTinhTP, "", "TP")
            If Request.Item("tp") <> "" Then
                drTinhTP.SelectedValue = Request.Item("tp")
            Else
                If flReg.WebConfig("TinhTP") <> "0" Then drTinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            End If
            Call flDic.LoadYear(drYear, Now.Year - 5, Now.Year, False)
            If Request.Item("nam") <> "" Then
                drYear.SelectedValue = Request.Item("nam")
            Else
                If flReg.WriteNumber(flCache.GetCache("BC_KyNhapLieu_Years_" & drTinhTP.SelectedValue)) > 0 Then
                    drYear.SelectedValue = flCache.GetCache("BC_KyNhapLieu_Years_" & drTinhTP.SelectedValue)
                Else
                    drYear.SelectedValue = Now.Year
                End If
            End If
        End Sub
        Private Sub LoadValues()
            litRow.Text = ""
            arrTemp = objController.RPT_Run_THBienDong(Me.PortalId, drTinhTP.SelectedValue, drYear.SelectedValue)
            For Each Cr As Rpt_CauInfo In arrTemp
                litRow.Text += "<tr>"
                litRow.Text += "<td style='text-align: center'>" & Cr.STT & "</td>"
                litRow.Text += "<td>" & Cr.cot2 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot3 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot4 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot5 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot6 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot7 & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.cot8 & "</td>"
                litRow.Text += "</tr>"
                _cot3 += flReg.WriteNumber(Cr.cot3)
                _cot4 += flReg.WriteNumber(Cr.cot4)
                _cot5 += flReg.WriteNumber(Cr.cot5)
                _cot6 += flReg.WriteNumber(Cr.cot6)
                _cot7 += flReg.WriteNumber(Cr.cot7)
                _cot8 += flReg.WriteNumber(Cr.cot8)
            Next

            str = "<tr style='text-align: center;font-weight: bold; '>"
            str += "<td></td>"
            str += "<td>Tổng số</td>"
            str += "<td>" & _cot3 & "</td>"
            str += "<td>" & _cot4 & "</td>"
            str += "<td>" & _cot5 & "</td>"
            str += "<td>" & _cot6 & "</td>"
            str += "<td>" & _cot7 & "</td>"
            str += "<td>" & _cot8 & "</td>"
            str += "</tr>"
            litRow.Text = str & litRow.Text
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdTongHop_Click(sender As Object, e As EventArgs) Handles cmdTongHop.Click
            Try
                objController.RPT_TongHop_SoLieu(Me.PortalId, drTinhTP.SelectedValue, drYear.SelectedValue, "THBienDong")
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Đã tổng hợp lại số liệu báo cáo thành công!', 'Thông báo', false);", True)
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
            Try
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class

End Namespace
