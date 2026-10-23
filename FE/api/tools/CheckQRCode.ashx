<%@ WebHandler Language="VB" Class="CheckQRCode" %>
Imports System
Imports System.Data.SqlClient
Imports System.Web
Imports System.Configuration

Public Class CheckQRCode
    Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim qrCode As String = context.Request.Form("qrCode")
        If String.IsNullOrEmpty(qrCode) Then
            context.Response.Write("❌ Vui lòng nhập dữ liệu QR Code.")
            Return
        End If

        Dim connString As String = ConfigurationManager.ConnectionStrings("ToolsConnect").ConnectionString
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT Name, Description FROM ExcelData WHERE Code = @Code", conn)
            cmd.Parameters.AddWithValue("@Code", qrCode)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim name As String = reader("Name").ToString()
                Dim description As String = reader("Description").ToString()
                context.Response.Write($"✅ Hợp lệ! <br/> <strong>Tên:</strong> {name} <br/> <strong>Mô tả:</strong> {description}")
            Else
                context.Response.Write("❌ Không tìm thấy dữ liệu!")
            End If
            conn.Close()
        End Using
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class

