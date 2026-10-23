Imports GemBox.Spreadsheet

Namespace DesktopModules.View
    Public MustInherit Class QRCheckList
        Inherits Entities.Modules.PortalModuleBase

        Private Sub QRCheckList_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then

                HidPortalID.Value = Me.PortalId
                HidUID.Value = Me.UserId
                PathSave.Value = EPORTAL.flReg.EnCode64(Server.MapPath("/DATA/" & Me.PortalId & "/dcdl/"))
            End If
        End Sub

        'Private Sub btnTaiLen_Click(sender As Object, e As EventArgs) Handles btnTaiLen.Click
        '    Try


        '        GemBox.Document.ComponentInfo.SetLicense(EPORTAL.flReg.WebConfig("GemBoxKey"))
        '        Dim ef As ExcelFile = New ExcelFile
        '        Dim ws As ExcelWorksheet
        '        Dim sSavePath As String = ""
        '        Dim dem = 0
        '        For Each uploadedFile As HttpPostedFile In _FileUpload.PostedFiles
        '            If String.IsNullOrEmpty(uploadedFile.FileName) Then
        '                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Không tìm thấy tệp để import dữ liệu', 'Thông báo', false);", True)

        '                Return
        '            End If
        '            If (uploadedFile.FileName.ToUpper.EndsWith(".XLS") Or uploadedFile.FileName.ToUpper.EndsWith(".XLSX")) Or uploadedFile.FileName.ToUpper.EndsWith(".XLSM") Then
        '                sSavePath = Server.MapPath("/DATA/" & Me.PortalId & "/dcdl/") + Guid.NewGuid().ToString + uploadedFile.FileName
        '                uploadedFile.SaveAs(sSavePath)
        '                ef = ExcelFile.Load(sSavePath)
        '                ws = ef.Worksheets(0)

        '            End If
        '            For i As Integer = 2 To ws.Rows.Count - 1
        '                If String.IsNullOrEmpty(ws.Cells(i, 1).Value) = False Then

        '                    dem += 1
        '                End If
        '            Next
        '        Next
        '    Catch ex As Exception

        '    End Try
        'End Sub
    End Class
End Namespace
