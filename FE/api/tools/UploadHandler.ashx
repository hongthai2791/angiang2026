<%@ WebHandler Language="VB" Class="UploadHandler" %>
Imports System
Imports System.IO
Imports System.Web
Imports GemBox.Spreadsheet
Imports System.Data.SqlClient
Imports System.Configuration

Public Class UploadHandler
    Implements IHttpHandler
    Private Function CheckValidCell(ob As Object) As String
        Try
            If String.IsNullOrEmpty(ob) = False Then
                Return ob.ToString().Trim()
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Shared Function WriteDate(dates As String, Optional ByVal time As Boolean = True, Optional ByVal yyMMdd As Boolean = False) As DateTime?
        Try
            Dim Str()
            If dates & "" <> "" Then
                dates = ((dates.Replace(" ", "/")).Replace(":", "/")).Replace("-", "/")
                Str = dates.Split("/")
                If yyMMdd = False Then
                    If time = True Then
                        If EPORTAL.flReg.WriteNumber(Str(1)) > 12 Then
                            Return New Date(Str(2), Str(0), Str(1), Str(3), Str(4), 0)
                        Else
                            Return New Date(Str(2), Str(1), Str(0), Str(3), Str(4), 0)
                        End If
                    Else 'Ghi ngày không
                        If EPORTAL.flReg.WriteNumber(Str(1)) > 12 Then
                            Return New Date(Str(2), Str(0), Str(1))
                        Else
                            Return New Date(Str(2), Str(1), Str(0))
                        End If
                    End If
                Else
                    Return New Date(Str(0), Str(1), Str(2))
                End If
            Else
                Return CType(Nothing, DateTime?)
            End If
        Catch ex As Exception
            Return CType(Nothing, DateTime?)
        End Try
    End Function
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim sqlText As String = ""
        Try
            If context.Request.Files.Count > 0 Then


                Dim files As HttpFileCollection = context.Request.Files
                Dim portal = DotNetNuke.EPORTAL.flReg.WriteNumber(context.Request.Item("portal") & "")
                Dim rowId = DotNetNuke.EPORTAL.flReg.WriteNumber(context.Request.Item("rid") & "")
                Dim trackingId = context.Request.Item("tid")
                Dim orderId = context.Request.Item("oid")
                Dim typeId = context.Request.Item("typeid")
                Dim timeid = context.Request.Item("timeid")
                Dim dateId = context.Request.Item("did")
                Dim uid = context.Request.Item("uid")
                Dim pathSave = DotNetNuke.EPORTAL.flReg.DeCode64(context.Request.Item("pathsave"))
                SpreadsheetInfo.SetLicense("EL6O-26C7-AZ0H-090X")
                Dim ef As ExcelFile = New ExcelFile
                Dim ws As ExcelWorksheet
                Dim sSavePath As String = ""
                Dim dem = 0
                'sqlText += "TRUNCATE TABLE ExcelData;"
                Dim gid = ""
                Dim utc = ""
                For i As Integer = 0 To context.Request.Files.Count - 1
                    Dim uploadedFile As HttpPostedFile = context.Request.Files(i)
                    If (uploadedFile.FileName.ToUpper.EndsWith(".XLS") Or uploadedFile.FileName.ToUpper.EndsWith(".XLSX")) Or uploadedFile.FileName.ToUpper.EndsWith(".XLSM") Then
                        gid = Guid.NewGuid().ToString
                        utc = Now.ToString("yyyyMMddhhmmss")
                        sSavePath = pathSave + gid + "_" + utc + ".xlsx"
                        uploadedFile.SaveAs(sSavePath)
                        ef = ExcelFile.Load(sSavePath)
                        ws = ef.Worksheets(0)
                    End If
                    For j As Integer = rowId To ws.Rows.Count - 1
                        If String.IsNullOrEmpty(ws.Cells(j, 1).Value) = False And String.IsNullOrEmpty(ws.Cells(trackingId & j).Value) = False Then
                            sqlText += String.Format("INSERT INTO ExcelData (FID,ROWID,ORDER_ID,TRACKING_ID,TYPE_ID,TIME_ID,DATE_ID,UID, UTC) SELECT '{0}',{1}, '{2}', '{3}', '{4}','{5}','{6}', {7}, {8} WHERE NOT EXISTS (SELECT 1 FROM ExcelData WHERE TRACKING_ID =  '{3}');", gid, j, ws.Cells(orderId & j).Value.ToString().Trim(), ws.Cells(trackingId & j).Value.ToString().Trim(), ws.Cells(typeId & j).Value.ToString().Trim(), WriteDate(CheckValidCell(ws.Cells(timeid & j).Value)), WriteDate(CheckValidCell(ws.Cells(dateId & j).Value)), uid, utc)
                            dem += 1
                        End If
                    Next
                Next

                Dim connString As String = ConfigurationManager.ConnectionStrings("ToolsConnect").ConnectionString
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Dim insertCmd As New SqlCommand(sqlText, conn)
                    insertCmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                context.Response.Write("Dữ liệu đã lưu vào Database!")
            Else
                context.Response.Write("Vui lòng chọn file!")
            End If
        Catch ex As Exception
            context.Response.Write(sqlText + ex.ToString)
        End Try
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class
