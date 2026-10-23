<%@ WebHandler Language="VB" Class="GetExcelData" %>
Imports System
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports System.Web.Script.Serialization

Public Class GetExcelData
    Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim connString As String = ConfigurationManager.ConnectionStrings("ToolsConnect").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT ROWID,ORDER_ID, TRACKING_ID,TYPE_ID,TIME_ID,DATE_ID FROM ExcelData", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim html As String = ""
            Dim totalRecords As Integer = 0
            While reader.Read()
                html += String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td></tr>", reader("ROWID"), reader("ORDER_ID"), reader("TRACKING_ID"), reader("TYPE_ID"), reader("TIME_ID"), reader("DATE_ID"))
                totalRecords += 1
            End While
            Dim result As New Dictionary(Of String, Object) From {
                {"html", html},
                {"totalRecords", totalRecords}
            }
            context.Response.ContentType = "application/json"
            context.Response.Write(New JavaScriptSerializer().Serialize(result))
            conn.Close()
        End Using
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class


