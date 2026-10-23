Imports System.Text
Imports System.Web.Script.Serialization
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace Modules.ReportView
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New InsuController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadChartData()
            End If
        End Sub

        Private Sub LoadChartData()
            Dim thongKeData As ArrayList = ObjController.EXE_NumberAuto_Report(Me.PortalId, 1)

            Dim highchartsData As New List(Of Object)

            For Each item As ReportInfo In thongKeData
                highchartsData.Add(New With {
                    .name = item.Ten,
                    .y = item.SoLuong
                })
            Next
            Dim serializer As New JavaScriptSerializer()
            Dim jsonString As String = serializer.Serialize(highchartsData)
            Dim script As String = "var chartData = " & jsonString & ";"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ChartDataScript", script, True)
        End Sub

    End Class
End Namespace