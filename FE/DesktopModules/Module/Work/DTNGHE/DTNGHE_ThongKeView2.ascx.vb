Imports System.Text
Imports System.Web.Script.Serialization
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_ThongKeNgayTCView
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call PopulateFilters()
                Call LoadChartData()
            End If
        End Sub

        Private Sub PopulateFilters()
            For i As Integer = Date.Now.Year + 1 To Date.Now.Year - 5 Step -1
                drNam.Items.Add(New ListItem(i.ToString(), i.ToString()))
            Next
            drNam.SelectedValue = Date.Now.Year

            For i As Integer = 1 To 12
                drThang.Items.Add(New ListItem("Tháng " & i, i.ToString()))
            Next
            drThang.SelectedValue = Date.Now.Month
        End Sub

        Protected Sub rblViewType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblViewType.SelectedIndexChanged
            drThang.Visible = (rblViewType.SelectedValue = "MONTH")
        End Sub

        Protected Sub cmdXemThongKe_Click(sender As Object, e As EventArgs) Handles cmdXemThongKe.Click
            Call LoadChartData()
        End Sub

        Private Sub LoadChartData()
            Dim viewType As String = rblViewType.SelectedValue
            Dim year As Integer = CInt(drNam.SelectedValue)
            Dim month As Integer = CInt(drThang.SelectedValue)

            Dim dbData As ArrayList = ObjController.DTNGHE_ThongKe_LopHoc_TheoNgayKhaiGiang(viewType, year, month)
            Dim dataDict As New Dictionary(Of Integer, Integer)
            For Each item As DTNGHE_ThongKeInfo In dbData
                dataDict(item.Ten) = item.SoLuong
            Next

            Dim categories As New List(Of String)
            Dim seriesData As New List(Of Integer)
            Dim chartTitle As String = ""
            Dim xAxisTitle As String = ""

            If viewType = "YEAR" Then
                chartTitle = "Thống kê lớp học các tháng trong năm " & year
                xAxisTitle = "Tháng"
                For i As Integer = 1 To 12
                    categories.Add("Tháng " & i)
                    seriesData.Add(If(dataDict.ContainsKey(i), dataDict(i), 0))
                Next
            Else
                chartTitle = "Thống kê lớp học các ngày trong tháng " & month & "/" & year
                xAxisTitle = "Ngày"
                Dim daysInMonth = Date.DaysInMonth(year, month)
                For i As Integer = 1 To daysInMonth
                    categories.Add("Ngày " & i)
                    seriesData.Add(If(dataDict.ContainsKey(i), dataDict(i), 0))
                Next
            End If

            Dim serializer As New JavaScriptSerializer()
            Dim jsonCategories As String = serializer.Serialize(categories)
            Dim jsonSeriesData As String = serializer.Serialize(seriesData)

            Dim scriptBuilder As New StringBuilder()

            scriptBuilder.Append("Highcharts.chart('chartContainerNgayTC', {")
            scriptBuilder.Append("chart: { type: 'column' },")
            scriptBuilder.Append("title: { text: ' " & chartTitle & "' },")
            scriptBuilder.Append("xAxis: { categories:  " & jsonCategories & ", title: { text: ' " & xAxisTitle & "' } },")
            scriptBuilder.Append("yAxis: { min: 0, title: { text: 'Số lượng lớp' }, allowDecimals: false },")
            scriptBuilder.Append("legend: { enabled: false },")
            scriptBuilder.Append("tooltip: { pointFormat: 'Có <b>{point.y}</b> lớp' },")
            scriptBuilder.Append("series: [{ name: 'Số lượng lớp', data: " & jsonSeriesData & " }]")
            scriptBuilder.Append("});")

            ScriptManager.RegisterStartupScript(upChart, upChart.GetType(), "ChartScript", scriptBuilder.ToString(), True)
        End Sub
    End Class
End Namespace