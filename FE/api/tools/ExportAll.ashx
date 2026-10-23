<%@ WebHandler Language="VB" Class="ExportAll" %>

Imports System
Imports System.Web
Imports GemBox.Spreadsheet
Imports System.Drawing

Public Class ExportAll : Implements IHttpHandler
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        ' Kích hoạt bản miễn phí của GemBox.Spreadsheet
        SpreadsheetInfo.SetLicense("EL6O-26C7-AZ0H-090X")

        Dim connString As String = ConfigurationManager.ConnectionStrings("ToolsConnect").ConnectionString
        Dim ef As ExcelFile = New ExcelFile
        Dim workbook As New ExcelFile()
        Dim sSavePath As String = DotNetNuke.EPORTAL.flReg.DeCode64(context.Request.Item("pathsave"))

        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT TOP 1 FID, UTC FROM ExcelData", conn)

        End Using
        ef = ExcelFile.Load(sSavePath)
        ws = ef.Worksheets(0)
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT ROWID, TRACKING_ID FROM ExcelData", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim html As String = ""
            Dim totalRecords As Integer = 0
            While reader.Read()
                html += String.Format("<tr><td>{0}</td><td>{1}</td></tr>", reader("ROWID"), reader("TRACKING_ID"))
                totalRecords += 1
            End While
            Dim result As New Dictionary(Of String, Object) From {
                {"html", html},
                {"totalRecords", totalRecords}
            }
            context.Response.ContentType = "application/json"
            context.Response.Write(New JavaScriptSerializer().Serialize(result))
        End Using
        conn.Close()
        '' Thêm tiêu đề
        'worksheet.Cells(0, 0).Value = "ID Hàng"
        'worksheet.Cells(0, 1).Value = "Mã đơn (TrackingID)"

        '' Dữ liệu từ bảng HTML (có thể lấy từ client)
        'Dim excelData As List(Of Tuple(Of String, String)) = New List(Of Tuple(Of String, String)) From {
        '    Tuple.Create("1", "12345"),
        '    Tuple.Create("2", "67890"),
        '    Tuple.Create("3", "ABCDE"),
        '    Tuple.Create("4", "XYZ12")
        '}

        '' Danh sách mã hợp lệ
        'Dim validList As List(Of String) = New List(Of String) From {"12345", "67890", "ABCDE"}

        '' Ghi dữ liệu vào Excel
        'Dim rowIndex As Integer = 1
        'For Each rowData In excelData
        '    worksheet.Cells(rowIndex, 0).Value = rowData.Item1
        '    worksheet.Cells(rowIndex, 1).Value = rowData.Item2

        '    ' Nếu mã không hợp lệ, tô màu đỏ
        '    If Not validList.Contains(rowData.Item2) Then
        '        Dim style As CellStyle = worksheet.Cells(rowIndex, 1).Style
        '        style.FillPattern.SetSolid(Color.Red)
        '        style.Font.Color = Color.White
        '    End If

        '    rowIndex += 1
        'Next

        ' Xuất file Excel về client
        context.Response.Clear()
        context.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        context.Response.AddHeader("Content-Disposition", "attachment; filename=DanhSach_Xuat.xlsx")

        workbook.Save(context.Response.OutputStream)
        context.Response.End()
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class


