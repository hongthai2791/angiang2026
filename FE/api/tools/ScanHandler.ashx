<%@ WebHandler Language="VB" Class="ScanHandler" %>

Imports System
Imports System.Web
Imports System.IO
Imports System.Collections.Generic
Imports System.Web.Script.Serialization

Public Class ScanHandler : Implements IHttpHandler

    Private Shared filePath As String = HttpContext.Current.Server.MapPath("/DATA/7/temps/scan_data.json")

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "application/json"

        Dim action As String = context.Request("action")

        If action = "save" Then
            ' Nhận mã QR từ AJAX
            Dim qrCode As String = context.Request("qrCode")
            If Not String.IsNullOrEmpty(qrCode) Then
                Dim qrList As New List(Of String)

                ' Nếu file đã tồn tại, đọc dữ liệu cũ
                If File.Exists(filePath) Then
                    Dim existingData As String = File.ReadAllText(filePath)
                    qrList = New JavaScriptSerializer().Deserialize(Of List(Of String))(existingData)
                End If

                ' Thêm mã QR nếu chưa có
                If Not qrList.Contains(qrCode) Then
                    qrList.Add(qrCode)
                    File.WriteAllText(filePath, New JavaScriptSerializer().Serialize(qrList))
                End If
            End If
            context.Response.Write("{""status"":""success""}")

        ElseIf action = "read" Then
            ' Đọc danh sách mã QR từ file JSON
            If File.Exists(filePath) Then
                Dim jsonData As String = File.ReadAllText(filePath)
                If jsonData.StartsWith("[") AndAlso jsonData.EndsWith("]") Then
                    context.Response.Write(jsonData)
                Else
                    context.Response.Write("[]") ' Tránh lỗi JSON
                End If
            Else
                context.Response.Write("[]")
            End If
        End If
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class

